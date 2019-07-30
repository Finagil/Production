Imports System.Text
Imports System.IO
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions


Module GEN_Globales
    Public TaQUERY As New GeneralDSTableAdapters.QueryVariosTableAdapter
    Public LOGO_PATH As String = My.Settings.RootDoc & "Plantillas\Logo.jpg"
    Public FOLIOS As New TesoreriaDSTableAdapters.LlavesTableAdapter
    Public USER_SEC As New SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
    Public TASA_IVA_SISTEM As Decimal = 0.16
    Public BITACORA As New GeneralDSTableAdapters.GEN_BitacoraFinagilTableAdapter


    Public Structure LASTINPUTINFO
        Public cbSize As UInteger
        Public dwTime As UInteger
    End Structure

    <DllImport("User32.dll")>
    Private Function GetLastInputInfo(ByRef plii As LASTINPUTINFO) As Boolean
    End Function

    Public Function GetInactiveTime() As Nullable(Of TimeSpan)
        Dim info As LASTINPUTINFO = New LASTINPUTINFO
        info.cbSize = CUInt(Marshal.SizeOf(info))
        If (GetLastInputInfo(info)) Then
            Return TimeSpan.FromMilliseconds(Environment.TickCount - info.dwTime)
        Else
            Return Nothing
        End If
    End Function

    Public Function Genera_Contrato_Marco(ByVal cAnexo As String, ByVal Cliente As String, ByVal TipoCredito As String) As String
        Dim ta1 As New GeneralDSTableAdapters.ContratosMarcoTableAdapter
        Dim t1 As New GeneralDS.ContratosMarcoDataTable
        ta1.Fill(t1, TipoCredito)
        If t1.Rows.Count > 0 Then
            Dim r1 As GeneralDS.ContratosMarcoRow = t1.Rows(0)
            Dim ta2 As New GeneralDSTableAdapters.ContratosMarcoClienteTableAdapter
            Dim t2 As New GeneralDS.ContratosMarcoClienteDataTable
            Dim r2 As GeneralDS.ContratosMarcoClienteRow
            ta2.Fill(t2, Cliente, TipoCredito, "ACT")
            If t2.Rows.Count > 0 Then
                r2 = t2.Rows(0)
            Else
                ta2.Insert(Cliente, TipoCredito, r1.RECA, r1.NoReca, r1.Version, Date.Now, "ACT")
                ta2.Fill(t2, Cliente, TipoCredito, "ACT")
                r2 = t2.Rows(0)
            End If
            Dim ta3 As New GeneralDSTableAdapters.ContratosMarcoOperacionesTableAdapter
            ta3.Insert(r2.IdContratoMarco, cAnexo, Date.Now)
            Return r2.IdContratoMarco.ToString
        Else
            Return "0000000"
        End If
    End Function

    Public Function SacaContratoMarcoLargo(ByVal id As Double, ByVal Anexo As String) As String
        Dim ta2 As New GeneralDSTableAdapters.ContratosMarcoClienteTableAdapter
        Dim t2 As New GeneralDS.ContratosMarcoClienteDataTable
        If id > 0 Then
            ta2.FillByID(t2, id)
            If t2.Rows.Count > 0 Then
                Dim r2 As GeneralDS.ContratosMarcoClienteRow = t2.Rows(0)
                Return r2.TipoCredito & r2.FechaAlta.ToString("yyyyMMdd") & r2.IdContratoMarco.ToString
            Else
                Return "0000000"
            End If
        Else
            Dim ta3 As New GeneralDSTableAdapters.ContratosMarcoOperacionesTableAdapter
            Dim t3 As New GeneralDS.ContratosMarcoOperacionesDataTable
            ta3.FillByAnexo(t3, Anexo)
            If t3.Rows.Count > 0 Then
                Dim r3 As GeneralDS.ContratosMarcoOperacionesRow = t3.Rows(0)
                ta2.FillByID(t2, r3.IdContratoMarco)
                If t2.Rows.Count > 0 Then
                    Dim r2 As GeneralDS.ContratosMarcoClienteRow = t2.Rows(0)
                    Return r2.TipoCredito & r2.FechaAlta.ToString("yyyyMMdd") & r2.IdContratoMarco.ToString
                Else
                    Return "0000000"
                End If
            Else
                Return "0000000"
            End If
        End If

    End Function

    Public Sub BloqueaContrato(ByVal Anexo As String, Optional ByVal Registros As Integer = 1)
        If Trim(Anexo) <> "" And Registros > 0 Then
            Dim ta As New GeneralDSTableAdapters.AnexosBloqueadosMCTableAdapter
            ta.Insert(Anexo)
            ta.Dispose()
        End If
    End Sub

    Public Function DesBloqueaContrato(ByVal Anexo As String) As Integer
        If Trim(Anexo) <> "" Then
            Dim ta As New GeneralDSTableAdapters.AnexosBloqueadosMCTableAdapter
            DesBloqueaContrato = ta.Delete(Anexo)
            ta.Dispose()
        End If
        Return DesBloqueaContrato
    End Function

    Public Function EstaBloqueadoAnexo(ByVal Anexo As String) As Boolean
        If Trim(Anexo) <> "" Then
            Dim ta As New GeneralDSTableAdapters.AnexosBloqueadosMCTableAdapter
            If ta.EstaBloqueado(Anexo) = 0 Then
                EstaBloqueadoAnexo = False
            Else
                EstaBloqueadoAnexo = True
            End If
            ta.Dispose()
        End If
        Return EstaBloqueadoAnexo
    End Function

    Public Sub HistoriaEdoCtaV(ByVal Anexo As String)
        Dim Org As New ProductionDataSetTableAdapters.EdoctavTableAdapter
        Dim Hist As New ProductionDataSetTableAdapters.EdoctavHistoriaTableAdapter
        Dim t As New ProductionDataSet.EdoctavDataTable
        Dim r As ProductionDataSet.EdoctavRow
        Dim NumTabla As Integer = Hist.ScalarNumTabla(Anexo)

        NumTabla += 1
        Org.Fill(t, Anexo)
        For Each r In t.Rows
            Hist.Insert(Anexo, r.Letra, r.Feven, r.Nufac, r.Indrec, r.Saldo, r.Abcap, r.Inter, r.Iva, r.IvaCapital, r.comFegaX, r.ivacomFegaX, NumTabla, Date.Now)
        Next

    End Sub

    Public Function Encriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("Finagil1") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return StrReverse(Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length())))

    End Function

    Public Function Desencriptar(ByVal Input As String) As String
        Input = StrReverse(Input)
        Try
            Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("Finagil1") 'La clave debe ser de 8 caracteres
            Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
            Dim buffer() As Byte = Convert.FromBase64String(Input)
            Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
            des.Key = EncryptionKey
            des.IV = IV
            Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
        Catch ex As Exception
            Return "Error o cadena no valida"
        End Try


    End Function

    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        Dim emailMatch As System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Function SacaDatosVehiculo(ByVal Anexo As String) As String
        Dim TA As New PromocionDSTableAdapters.VehiculosTableAdapter
        Dim T As New PromocionDS.VehiculosDataTable
        Dim R As PromocionDS.VehiculosRow
        TA.Fill(T, Anexo)
        Dim cad As String = ""
        If T.Rows.Count > 0 Then
            R = T.Rows(0)
            cad = "MARCA: " & R.Marca & vbCrLf
            cad += "SUBMARCA: " & R.SubMarca & vbCrLf
            cad += "VERSION: " & R.Version & vbCrLf
            cad += "MODELO: " & R.Modelo & vbCrLf
            cad += "COLOR: " & R.Color & vbCrLf
            cad += "PALCAS: " & R.Placas & vbCrLf
            cad += "SERIE: " & R.Serie
        End If
        Return cad
    End Function

    Public Function ReplicateString(ByVal Source As String, ByVal Times As Long) As String
        Dim length As Long, index As Long
        ' Crea la línea
        length = Len(Source)
        ReplicateString = Space$(length * Times)
        ' Realiza multiples copias del valor Source 
        For index = 1 To Times
            Mid$(ReplicateString, (index - 1) * length + 1, length) = Source
        Next
    End Function

    Public Sub MandaCorreo(De As String, Para As String, Asunto As String, Mensaje As String, Optional Archivo As String = "")
        Dim taCorreos As New GeneralDSTableAdapters.CorreosSistemaFinagilTableAdapter
        taCorreos.Insert(De, Para, Asunto, Mensaje, False, Archivo)
        taCorreos.Dispose()
    End Sub

    Public Sub MandaCorreoDepto(De As String, Depto As String, Asunto As String, Mensaje As String, Optional Archivo As String = "")
        Dim taCorreos As New GeneralDSTableAdapters.CorreosSistemaFinagilTableAdapter
        Dim users As New SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
        Dim tu As New SeguridadDS.UsuariosFinagilDataTable
        Dim r As SeguridadDS.UsuariosFinagilRow

        users.FillByDepto(tu, Depto)
        For Each r In tu.Rows
            taCorreos.Insert(De, r.correo, Asunto, Mensaje, False, Archivo)
        Next
        taCorreos.Dispose()
    End Sub

    Public Sub MandaCorreoUser(De As String, Usuario As String, Asunto As String, Mensaje As String, Optional Archivo As String = "")
        Dim taCorreos As New GeneralDSTableAdapters.CorreosSistemaFinagilTableAdapter
        Dim users As New SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
        Dim tu As New SeguridadDS.UsuariosFinagilDataTable
        Dim r As SeguridadDS.UsuariosFinagilRow
        If InStr(Usuario, "@") > 0 Then
            taCorreos.Insert(De, Usuario, Asunto, Mensaje, False, Archivo)
        Else
            users.FillByUsuario(tu, Usuario)
            For Each r In tu.Rows
                taCorreos.Insert(De, r.correo, Asunto, Mensaje, False, Archivo)
            Next
        End If
        taCorreos.Dispose()
    End Sub

    Public Function MandaCorreoFase(De As String, Fase As String, Asunto As String, Mensaje As String, Optional ByVal Archivo As String = "") As Boolean
        Dim taCorreos As New GeneralDSTableAdapters.CorreosSistemaFinagilTableAdapter
        Dim users As New GeneralDSTableAdapters.CorreosFasesTableAdapter
        Dim tu As New GeneralDS.CorreosFasesDataTable
        Dim r As GeneralDS.CorreosFasesRow
        MandaCorreoFase = False
        users.Fill(tu, Fase)
        For Each r In tu.Rows
            taCorreos.Insert(De, r.Correo, Asunto, Mensaje, False, Archivo)
            MandaCorreoFase = True
        Next
        taCorreos.Dispose()
        Return MandaCorreoFase
    End Function

    Public Sub MandaCorreoPROMO(Anexo As String, Asunto As String, Mensaje As String, Jefe As Boolean, CopiaRemitente As Boolean, Optional Archivo As String = "", Optional MsgPara As Boolean = False)
        Dim users As New SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
        Dim taCorreos As New GeneralDSTableAdapters.CorreosSistemaFinagilTableAdapter
        Dim promo As New GeneralDSTableAdapters.CorreoPROMOTableAdapter
        Dim tu As New GeneralDS.CorreoPROMODataTable
        Dim r As GeneralDS.CorreoPROMORow

        promo.FillByAnexo(tu, Anexo)
        If tu.Rows.Count > 0 Then
            r = tu.Rows(0)
            taCorreos.Insert(UsuarioGlobalCorreo, r.Correo, Asunto, Mensaje, False, Archivo)
            If MsgPara = True Then
                MessageBox.Show("Correo Enviado a " & r.Correo, "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If CopiaRemitente = True Then
                taCorreos.Insert(UsuarioGlobalCorreo, UsuarioGlobalCorreo, Asunto, Mensaje, False, Archivo)
            End If
            If Jefe = True Then
                Select Case UsuarioGlobal
                    Case "jpalacios", "arendon", "avelasco"
                        MandaCorreoFase(UsuarioGlobalCorreo, "SUB_MEXICO", Asunto, Mensaje, Archivo)
                    Case Else
                        MandaCorreoFase(UsuarioGlobalCorreo, "SUB_" & r.Nombre_Sucursal.Trim, Asunto, Mensaje, Archivo)
                End Select
            End If
        Else
            MandaCorreo("ecacerest@finagil.com.mx", "ecacerest@finagil.com.mx", "Sin promotor-" & Asunto, Mensaje)
        End If

        taCorreos.Dispose()
        promo.Dispose()
    End Sub

    Function BORRA_CONTRATOS() As Boolean
        BORRA_CONTRATOS = True
        For Each Archivo As String In My.Computer.FileSystem.GetFiles("c:\Contratos\")
            Try
                File.Delete(Archivo)
            Catch ex As Exception
                MessageBox.Show("Favor de cerrar su docuemnto " & Archivo, "Archivo Abierto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BORRA_CONTRATOS = False
            End Try
        Next
        Return BORRA_CONTRATOS
    End Function

    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub NumerosEnteros(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub NumerosyDescimalNegativos(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        ElseIf e.KeyChar = "-" And Not CajaTexto.Text.IndexOf("-") Then
            e.Handled = True
        ElseIf e.KeyChar = "-" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Function Trae_tasa_Dia(cTipta As String, cFechaAnterior As String, cAnexo As String) As Decimal
        Dim taTasas As New TesoreriaDSTableAdapters.HistaTableAdapter
        Dim tasa As Decimal = taTasas.Trae_Tasa_Dia(cTipta, cFechaAnterior)
        If tasa <= 0 And cFechaAnterior <= Today.ToString("yyyyMMdd") Then
            MandaCorreo("TasasFinagil@finagil.com.mx", "ecacerest@finagil.com.mx;vcruz@finagil.com.mx", "Error en tasa Provision", "TipoTasa:" & cTipta & " Fecha:" & cFechaAnterior & " Anexo:" & cAnexo)
        End If
        Return tasa
    End Function

    Function CalculaFEGA(Importe As Decimal, FegaFlat As Boolean, cFechaTerminacion As String, AplicaFega As Boolean, PorcentajeFEGA As Decimal, Cliente As String, Sucursal As String, Tra_Av As String) As Decimal
        Dim TasaFega As Decimal = PORC_FEGA_AV
        Dim TasaIvaCliente As Decimal = TaQUERY.TasaIvaCliente(Cliente) / 100
        If PorcentajeFEGA > 0 Then
            TasaFega = PorcentajeFEGA * (1 + TasaIvaCliente)
        Else
            If Tra_Av.ToUpper = "AV" Then
                If Sucursal = "03" Or Sucursal = "04" Or Sucursal = "08" Or Sucursal = "09" Then
                    TasaFega = PORC_FEGA_NORTE_AV * (1 + TasaIvaCliente)
                Else
                    TasaFega = PORC_FEGA_AV * (1 + TasaIvaCliente)
                End If
            Else ' TRA
                If Sucursal = "03" Or Sucursal = "04" Or Sucursal = "08" Or Sucursal = "09" Then
                    TasaFega = PORC_FEGA_NORTE_TRA * (1 + TasaIvaCliente)
                Else
                    TasaFega = PORC_FEGA_TRA * (1 + TasaIvaCliente)
                End If
            End If
        End If
        CalculaFEGA = Math.Round(Importe * TasaFega, 2)
        If AplicaFega = False Then
            CalculaFEGA = 0
        Else
            If FegaFlat = 0 Then
                Dim dias As Integer
                dias = DateDiff("d", Date.Now.Date, CTOD(cFechaTerminacion))
                CalculaFEGA = Math.Round(Importe * (TasaFega / 360) * dias, 2)
            End If
        End If
        Return CalculaFEGA
    End Function

    Function SacaFechaRFC(RFC As String) As Date
        RFC = RFC.Trim
        Dim AuxInt As Integer
        If RFC.Length >= 10 Then
            If Not IsNumeric(Mid(RFC, 4, 1)) Then
                AuxInt = Date.Now.Year - (CInt(RFC.Substring(4, 2)) + 1900)
                If AuxInt >= 100 Then
                    AuxInt = (CInt(RFC.Substring(4, 2)) + 2000)
                Else
                    AuxInt = (CInt(RFC.Substring(4, 2)) + 1900)
                End If
                SacaFechaRFC = New Date(AuxInt, RFC.Substring(6, 2), RFC.Substring(8, 2))
            Else
                AuxInt = Date.Now.Year - (CInt(RFC.Substring(3, 2)) + 1900)
                If AuxInt >= 100 Then
                    AuxInt = (CInt(RFC.Substring(3, 2)) + 2000)
                Else
                    AuxInt = (CInt(RFC.Substring(3, 2)) + 1900)
                End If
                SacaFechaRFC = New Date(AuxInt, RFC.Substring(5, 2), RFC.Substring(7, 2))
            End If
        Else
            SacaFechaRFC = "01/01/1900"
        End If
        Return SacaFechaRFC
    End Function

    Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Sub SacaAlerta(Cliente As String, Anexo As String)
        Dim cad As String
        Dim ta As New JuridicoDSTableAdapters.JUR_AlertasClientesTableAdapter
        Dim t As New JuridicoDS.JUR_AlertasClientesDataTable
        If Anexo <> "" Then
            ta.FillByAnexo(t, Anexo)
        Else
            ta.FillByCliente(t, Cliente)
        End If
        For Each r As JuridicoDS.JUR_AlertasClientesRow In t.Rows
            If cad = "" Then
                cad += r.Alerta
            Else
                cad += " " & r.Alerta
            End If
        Next
        If cad <> "" Then
            MessageBox.Show(cad, "Alerta de Cliente (JURIDICO)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Function DocCopiaLocal(ArchivoENT As String) As String
        Dim cad() As String = ArchivoENT.Split("\")
        File.Copy(ArchivoENT, "C:\Contratos\" & cad(cad.Length - 1), True)
        DocCopiaLocal = "C:\Contratos\" & cad(cad.Length - 1)
    End Function

    Function CalculaRDC(Ingresos As Decimal, Egresos As Decimal, Finagil As Decimal) As Decimal
        Dim PorcEGRE As Decimal = Egresos / Ingresos
        Dim PorcFINAgil As Decimal = Finagil / Ingresos
        Dim PorcLIBRE As Decimal = (Ingresos - Egresos - Finagil) / Ingresos
        Dim RCD As Decimal = PorcEGRE + PorcFINAgil
        Return RCD
    End Function
End Module
