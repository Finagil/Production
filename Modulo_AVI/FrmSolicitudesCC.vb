Imports System.Data.SqlClient
Imports System.Math
Imports System.Security
Imports Microsoft.VisualBasic.Financial
Imports System.IO
Imports Word = Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop

Public Class FrmSolicitudesCC

    Dim Nuevo As Boolean = False
    Public Usuario As String
    Dim rrr As AviosDSX.ParametrosRow
    Dim TiptaX As String = ""

    Private Sub FrmParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CmbFondeo.Enabled = False
        Bloquea(True)
        CargaDatos()
    End Sub

    Sub CargaDatos()
        Me.ParametrosTableAdapter.FillByFiltro(Me.AvioDS.Parametros, "01", "01", 0)
        rrr = Me.AvioDS.Parametros.Rows(0)
    End Sub

    Private Sub CmbCiclo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargaDatos()
    End Sub

    Private Sub CmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargaDatos()
    End Sub

    Private Sub CmbCultivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargaDatos()
    End Sub

    Private Sub CmbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbClientes.SelectedIndexChanged
        If CmbClientes.SelectedIndex > -1 Then
            Me.SolicitudesTableAdapter.Fill(Me.AvioDS.Solicitudes, Txtid.Text, CmbClientes.SelectedValue)
            Cmbsolicitudes_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Sub Bloquea(ByVal B As Boolean)
        GroupDatos.Enabled = B
        CmbClientes.Enabled = B
        Cmbsolicitudes.Enabled = B
        BttNew.Enabled = B
        BttMod.Enabled = B
        BttMinistraciones.Enabled = B
        BtnAnexo.Enabled = B
        BttDel.Enabled = B
        BttSave.Enabled = Not B
        BttCancel.Enabled = Not B
        GroupSolicitud.Enabled = Not B
    End Sub

    Private Sub BttSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttSave.Click
        Dim CAT As Decimal = 0
        CAT = 0

        If Valida() = True Then
            SacaTIIE()
            Dim ta As New AviosDSXTableAdapters.AVI_SolicitudesTableAdapter
            Dim Importe As Decimal = 0
            Dim Tipta As String
            TxtGastosAdmin.Text = (CDec(TxtLinea.Text) * (CDec(CmbComiApert.Text) / 100)).ToString("n2")
            TxtComi.Text = (CDec(TxtLinea.Text) * (CDec(CmbComiDisp.Text) / 100)).ToString("n2")

            Importe = CDec(TxtLinea.Text)
            If Nuevo = True Then
                ta.Insert(Txtid.Text, DTfecha.Value.ToString("yyyyMMdd"), CmbClientes.SelectedValue, 0, _
                TxtTIIE.Text, TxtPerBuro.Text, TxtPerBuroPM.Text, 0, TxtDif.Text, TxtSegVida.Text, "S", CmbTipoSol.Text, CAT, _
                CmbFondeo.Text, TxtAnexo.Text, "01", Usuario, "N", CmbGarantia.Text, Importe, "NO", "19000101", TiptaX, _
                CmbAdescuento.Text, CmbDiasVenc.Text, CmbInteMensual.Text, CmbComiApert.Text, CmbComiDisp.Text)
            Else
                ta.UpdateSol(Txtid.Text, DTfecha.Value.ToString("yyyyMMdd"), CmbClientes.SelectedValue, 0, _
                TxtTIIE.Text, TxtPerBuro.Text, TxtPerBuroPM.Text, 0, TxtDif.Text, TxtSegVida.Text, "S", CmbTipoSol.Text, _
                CAT, CmbFondeo.Text, TxtAnexo.Text, "01", Usuario, "N", CmbGarantia.Text, Importe, "NO", "19000101", TiptaX, _
                CmbAdescuento.Text, CmbDiasVenc.Text, CmbInteMensual.Text, CmbComiApert.Text, CmbComiDisp.Text, TxtIdSol.Text, TxtIdSol.Text)
            End If
            Bloquea(True)
            'CargaDatos()
            CmbClientes_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub BttCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCancel.Click
        Bloquea(True)
        CargaDatos()
    End Sub

    Private Sub BttNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttNew.Click
        If Val(TxtGtosAdmin.Text) = 0 Or Val(TxtComis.Text) = 0 Then
            MessageBox.Show("Falta Capturar Parametros de Ciclo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtTipoPersona.Text = "F" Then
            MessageBox.Show("No se puede dar de alta un contrato e avio para persona Fisica (Sin actividad empresarial)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Nuevo = True
        CargaDatosSOL(0)
        TxtDif.Text = TxtTasa.Text
        Bloquea(False)
        TxtPerBuro.Focus()
    End Sub

    Private Sub BttMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttMod.Click
        If TxtIdSol.Text = "" Then
            MessageBox.Show("No hay Solicitud para Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Nuevo = False
        CargaDatosSOL(Cmbsolicitudes.SelectedValue)
        Bloquea(False)
    End Sub

    Private Sub Cmbsolicitudes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbsolicitudes.SelectedIndexChanged
        If Cmbsolicitudes.SelectedIndex > -1 Then
            CargaDatosSOL(Cmbsolicitudes.SelectedValue)
        Else
            CargaDatosSOL(0)
        End If
    End Sub

    Sub CargaDatosSOL(ByVal Id As Integer)
        Dim ta As New AviosDSXTableAdapters.Vw_SolicitudesTableAdapter
        Dim T As New AviosDSX.Vw_SolicitudesDataTable
        ta.Fill(T, Id)
        If T.Rows.Count <= 0 Then
            'limpia campos
            DTfecha.Value = Date.Now
            TxtPerBuro.Text = ""
            TxtPerBuroPM.Text = ""
            TxtDif.Text = ""
            CmbTipoSol.SelectedIndex = 0
            CmbFondeo.SelectedIndex = 1
            CmbGarantia.SelectedIndex = 1
            TxtGastosAdmin.Text = ""
            TxtComi.Text = ""
            TxtBuroT.Text = ""
            TxtSegVida.Text = ""
            TxtTIIE.Text = ""
            TxtLinea.Text = ""
            TxtCAT.Text = ""
            TxtAnexo.Text = ""
            BtnAnexo.Enabled = False
            BtnPrint.Enabled = False

            CmbTipoTasa.SelectedIndex = 0
            TiptaX = "4" 'Variable
            CmbAdescuento.SelectedIndex = 0
            CmbDiasVenc.SelectedIndex = 0
            CmbInteMensual.SelectedIndex = 0
            CmbComiApert.SelectedIndex = 0
            CmbComiDisp.SelectedIndex = 0

        Else
            Dim R As AviosDSX.Vw_SolicitudesRow = T.Rows(0)
            DTfecha.Value = CTOD(R.FechaSolicitud)
            TxtPerBuro.Text = R.PersonasBuro
            TxtPerBuroPM.Text = R.PersonasBuroPM
            TxtDif.Text = R.Diferencial.ToString("n2")
            CmbTipoSol.Text = R.Tipo
            CmbFondeo.Text = R.Fondeo
            TxtGastosAdmin.Text = (R.Importe * (CDec(R.ComiApertura) / 100)).ToString("n2")
            TxtComi.Text = (R.Importe * (CDec(R.ComiDisposicion) / 100)).ToString("n2")
            TxtBuroT.Text = R.Buro.ToString("n2")
            If (R.TipoP = "E" Or R.TipoP = "F") Then
                TxtSegVida.Text = R.SeguroVida.ToString("n2")
            Else
                TxtSegVida.Text = "0.0"
            End If
            TxtTIIE.Text = R.TIIE
            TxtLinea.Text = R.Importe.ToString("n2")
            TxtCAT.Text = R.CAT.ToString("p1")
            TxtAnexo.Text = R.Anexo
            TxtAnexo.ReadOnly = True
            
            CmbGarantia.Text = R.AplicaGarantiaLIQ
            If R.CAT <= 0 Then
                BtnAnexo.Enabled = False
                BtnPrint.Enabled = False
            Else
                BtnAnexo.Enabled = True
                BtnPrint.Enabled = True
            End If

            If R.Tipta = "7" Then
                CmbTipoTasa.SelectedIndex = 1 'Fija
                TiptaX = "7"
            Else
                CmbTipoTasa.SelectedIndex = 0 'Variable
                TiptaX = "4"
            End If
            CmbAdescuento.Text = R.Gatos_a_Descuento
            CmbDiasVenc.Text = R.VencimientoDias
            CmbInteMensual.Text = R.Interes_Mensual
            CmbComiApert.Text = R.ComiApertura.ToString("n1")
            CmbComiDisp.Text = R.ComiDisposicion


        End If
        ta.Dispose()
        T.Dispose()
    End Sub

    Sub SacaTIIE()
        Dim Mes As String = Date.Now.ToString("yyyyMMdd")
        Dim TIIE As New AviosDSXTableAdapters.Vw_SolicitudesTableAdapter
        Dim fec As Date = CTOD(Mes)
        fec = fec.AddMonths(-1)
        Mes = fec.ToString("yyyyMM")
        TxtTIIE.Text = TIIE.TIIE(Mes)
    End Sub

    Private Sub BttDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttDel.Click
        If TxtIdSol.Text = "" Then
            MessageBox.Show("No hay Solicitud para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("¿Esta seguro de eliminar esta solicitud?", "Eliminar Solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.SolicitudesTableAdapter.DeleteSolicitud(TxtIdSol.Text)
            Me.SolicitudesTableAdapter.DeleteMinistraciones(TxtIdSol.Text)
            Bloquea(True)
            CargaDatos()
            CmbClientes_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub BttMinistraciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttMinistraciones.Click
        Dim fe As Date = DTfecha.Value
        Dim ta As New AviosDSXTableAdapters.AVI_MinistracionesParametrosTableAdapter
        ' calcula ministraciones 
        ta.DeletePARA(Txtid.Text)
        Select Case CmbDiasVenc.Text
            Case "30"
                For ww As Integer = 1 To 12
                    ta.Insert(Txtid.Text, fe.ToString("yyyyMMdd"), 1)
                    fe = fe.AddDays(30)
                Next
            Case "60"
                For ww As Integer = 1 To 6
                    ta.Insert(Txtid.Text, fe.ToString("yyyyMMdd"), 1)
                    fe = fe.AddDays(60)
                Next
            Case "90"
                For ww As Integer = 1 To 4
                    ta.Insert(Txtid.Text, fe.ToString("yyyyMMdd"), 1)
                    fe = fe.AddDays(90)
                Next
            Case "120"
                For ww As Integer = 1 To 3
                    ta.Insert(Txtid.Text, fe.ToString("yyyyMMdd"), 1)
                    fe = fe.AddDays(120)
                Next
            Case "150"
                For ww As Integer = 1 To 2
                    ta.Insert(Txtid.Text, fe.ToString("yyyyMMdd"), 1)
                    fe = fe.AddDays(150)
                Next
            Case "180"
                For ww As Integer = 1 To 2
                    ta.Insert(Txtid.Text, fe.ToString("yyyyMMdd"), 1)
                    fe = fe.AddDays(180)
                Next
        End Select

        ta.Dispose()
        ' calcula ministraciones 

        If TxtIdSol.Text = "" Then
            MessageBox.Show("No hay Solicitud selecionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim f As New FrmCATCC
        f.ID = TxtIdSol.Text
        f.IDparametro = Txtid.Text
        f.Importe = TxtLinea.Text
        f.TIEE = TxtTIIE.Text
        f.Diferencial = TxtDif.Text
        f.GastosIniciales = CDec(TxtGastosAdmin.Text) + CDec(TxtBuroT.Text)
        f.ComisionXDisposicion = CDec(TxtComi.Text)
        f.Tvida = TxtSegVida.Text
        f.Fondeo = CmbFondeo.Text

        f.Tipta = TiptaX '7 fija 6 variavle
        f.GastosADescuento = CmbAdescuento.Text
        f.DiasVenc = CmbDiasVenc.Text
        f.InteMensual = CmbInteMensual.Text
        f.IVA = 0.16

        f.Fecha = DTfecha.Value.AddDays(360)
        f.AplicaGarantiaLIQ = CmbGarantia.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Cmbsolicitudes_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub CmbTipoSol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTipoSol.SelectedIndexChanged
        If CmbTipoSol.Text = "Cuenta Corriente (CC)" Then
            CmbFondeo.SelectedIndex = 1
            'CmbFondeo.Enabled = True hasta que tengamos fira
        End If
    End Sub

    Function Valida() As Boolean
        Valida = True
        If TxtPerBuro.Text = "" Or Not IsNumeric(TxtPerBuro.Text) Then
            MessageBox.Show("Error en Personas buro. PF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPerBuro.Focus()
            Valida = False
            Exit Function
        End If
        If TxtPerBuroPM.Text = "" Or Not IsNumeric(TxtPerBuroPM.Text) Then
            MessageBox.Show("Error en Personas buro. PM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPerBuroPM.Focus()
            Valida = False
            Exit Function
        End If
        If TxtTipoPersona.Text <> "M" Then
            If Val(TxtPerBuro.Text) < 1 Then
                MessageBox.Show("Error en Personas buro, debe ser mayor a 1. PF- PFAE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtPerBuro.Focus()
                Valida = False
                Exit Function
            End If
        Else
            If Val(TxtPerBuroPM.Text) < 1 Then
                MessageBox.Show("Error en Personas buro, debe ser mayor a 1. PM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtPerBuroPM.Focus()
                Valida = False
                Exit Function
            End If
        End If
        If TxtDif.Text = "" Or Not IsNumeric(TxtDif.Text) Then
            MessageBox.Show("Error en Diferencial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtDif.Focus()
            Valida = False
            Exit Function
        End If
        If Val(TxtDif.Text) > Val(TxtMax.Text) Or Val(TxtDif.Text) < Val(TxtMin.Text) Then
            MessageBox.Show("Error en Diferencial, fuera de rango.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtDif.Focus()
            Valida = False
            Exit Function
        End If
        
        If (TxtTipoPersona.Text = "E" Or TxtTipoPersona.Text = "F") And CmbTipoSol.Text = "Cuenta Corriente (CC)" Then
            TxtSegVida.Text = TxtSegVid.Text
        Else
            TxtSegVida.Text = 0
        End If

        If TxtLinea.Text = "" Or Not IsNumeric(TxtLinea.Text) Then
            MessageBox.Show("Error en Monto del credito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtLinea.Focus()
            Valida = False
            Exit Function
        End If
    End Function

   
    Private Sub CmbFondeo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbFondeo.SelectedIndexChanged
        If CmbFondeo.Text = "Fira" Then
            CmbGarantia.SelectedIndex = 0
            CmbGarantia.Enabled = True
        Else
            CmbGarantia.SelectedIndex = 1
            CmbGarantia.Enabled = False
        End If
        ' sin garantia liquida
        CmbGarantia.SelectedIndex = 1
        CmbGarantia.Enabled = False
    End Sub

    Private Sub BtnAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnexo.Click
        If MessageBox.Show("¿esta seguro de generar el contrato?", "Contrato Cuenta Corriente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim taAV As New AviosDSXTableAdapters.AviosTableAdapter
        Dim cAnexo As String = taAV.AnexoMAX(CmbClientes.SelectedValue)
        Dim Prefijo As String
        Dim x As Integer = 0
        If cAnexo.Trim = "0" Then
            Dim Id As Integer = taAV.SacaLlave()
            While x = 0
                Id += 1
                cAnexo = "0" & Id.ToString & "0001"
                If taAV.ExisteAnexoTRadicional(cAnexo) = 0 And taAV.ExisteAnexoAvio(cAnexo) = 0 Then
                    taAV.UpdateLLave(Id)
                    x = 1
                End If
            End While
        Else
            While x = 0
                Prefijo = Val(Mid(cAnexo, 6, 4)) + 1
                Select Case Prefijo.Length
                    Case 1
                        Prefijo = "000" & Prefijo
                    Case 2
                        Prefijo = "00" & Prefijo
                    Case 3
                        Prefijo = "0" & Prefijo
                End Select
                cAnexo = Mid(cAnexo, 1, 5) & Prefijo
                If taAV.ExisteAnexoAvio(cAnexo) = 0 Then
                    x = 1
                End If
            End While
        End If
        Dim Fondeo As String = "01"
        Dim Ampli As String = "N"
        Dim Tipta As String
        Dim Tasa As Decimal
        Dim Differ As Decimal

        If CmbTipoTasa.Text.ToUpper = "VARIABLE" Then
            Tipta = 6
            Tasa = 0
            Differ = TxtDif.Text
        Else
            Tipta = 7
            Tasa = TxtDif.Text
            Differ = 0
        End If

        'If CmbTipoSol.Text = "A    mpliación (AM)" Then Ampli = "S"

        If CmbFondeo.Text = "Fira" Then Fondeo = "03"
        Dim cat As Decimal = Math.Round(CDec(Mid(TxtCAT.Text, 1, TxtCAT.Text.Length - 1)), 1)
        Dim ContratoMarco As String = "0000000"
        ContratoMarco = Genera_Contrato_Marco(cAnexo, CmbClientes.SelectedValue, Mid(CmbTipoSol.Text, 1, 1))
        Me.SolicitudesTableAdapter.UpdateSol("A", cAnexo, Cmbsolicitudes.SelectedValue)
        taAV.InsertAnexoCC("01", cAnexo, "A", Mid(CmbTipoSol.Text, 1, 1), CmbClientes.SelectedValue, _
        DTfecha.Value.ToString("yyyyMMdd"), rrr.FechaTerminacion, TxtLinea.Text, 0, Tipta, Tasa, Differ, _
        rrr.CuotaHectarea, 0, 0, 0, DTfecha.Value.ToString("yyyyMMdd"), _
        rrr.FechaLimiteDTC, DTfecha.Value.ToString("yyyyMMdd"), rrr.FechaSiembrai, rrr.FechaSiembraf, rrr.FechaCosechai, rrr.FechaCosechaf, _
        CmbComiApert.Text, Fondeo, 0, "N", CmbInteMensual.Text.ToUpper, UCase(CmbGarantia.Text), ContratoMarco, cat, Ampli)
        ContratoMarco = SacaContratoMarcoLargo(0, cAnexo)
        MessageBox.Show("Se genero el contrato: " & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & vbCrLf & _
        "Se genero el contrato Marco: " & ContratoMarco, "Contrato Avío")
        'mexicalli(7000)
        'navojoa se toma conscutivo
        'irapuato(8695)
        'tradicionales 3590
        CmbClientes_SelectedIndexChanged(Nothing, Nothing)

    End Sub

    Private Sub Txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length >= 3 Then
            Me.ClientesTableAdapter.FillByNombreMorales(Me.AvioDS.Clientes, "%" & Txtfiltro.Text & "%")
            If Me.AvioDS.Clientes.Rows.Count > 0 Then
                CmbClientes_SelectedIndexChanged(Nothing, Nothing)
            Else
            End If
        Else
            Me.AvioDS.Clientes.Clear()
        End If
    End Sub

    Public Sub OpenFile(ByVal Path As String)

        Try

            Dim InfoProceso As New System.Diagnostics.ProcessStartInfo
            Dim Proceso As New System.Diagnostics.Process
            With InfoProceso
                .FileName = Path
                .CreateNoWindow = True
                .ErrorDialog = True
                .UseShellExecute = True
                .WindowStyle = ProcessWindowStyle.Normal
            End With
            Proceso.StartInfo = InfoProceso
            Proceso.Start()
            Proceso.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al abrir el documento")
        End Try

        Me.Close()

    End Sub

    Private Sub CmbTipoTasa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTipoTasa.SelectedIndexChanged
        If CmbTipoTasa.Text = "Fija" Then
            Label26.Text = "Tasa"
            TiptaX = "7"
        Else
            Label26.Text = "Diferencial"
            TiptaX = "4"
        End If
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Cursor.Current = Cursors.WaitCursor
        Dim f As New FrmRptGnerico

        f.ReporteNom = "RptCotCC"
        f.ID_grupo = TxtIdSol.Text
        f.Titulo = CmbClientes.Text
        f.Monto = TxtLinea.Text
        f.CAT = TxtCAT.Text
        If CmbInteMensual.Text = "SI" Then
            f.InteresMes = "MENSUAL"
        Else
            f.InteresMes = "AL VENCIMIENTO"
        End If
        If CmbAdescuento.Text = "SI" Then
            f.ComiDesc = "DESCUENTO"
        Else
            f.ComiDesc = "PAGO DIRECTO"
        End If
        f.DiasVenc = CmbDiasVenc.Text & " DÍAS"
        f.ComiPorc = (CDec(CmbComiApert.Text) / 100).ToString("P1")
        f.ComiDisp = (CDec(CmbComiDisp.Text) / 100).ToString("P1")
        f.MontoLetra = Letras(f.Monto)
        If CmbFondeo.Text.ToUpper = "FIRA" Then
            f.Recursos = "FIRA"
        Else
            f.Recursos = "BANCARIOS"
        End If
        Cursor.Current = Cursors.Default
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub
End Class