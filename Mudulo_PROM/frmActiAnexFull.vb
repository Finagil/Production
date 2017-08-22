Option Explicit On
Imports System.Data.SqlClient
Imports System.Math
Imports Microsoft.VisualBasic.Financial
Imports System.IO
Imports Word = Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop
Imports System.Security.Principal.WindowsIdentity
Imports System.Security

Public Class frmActiAnexFull
    Dim Anexo As String
    Dim cNota As String = ""
    Dim cNotaAval As String = ""
    Dim cNota2 As String = ""
    Dim cTipo As String = ""
    Dim cTipoAV As String = ""
    Dim cNomAval As String = ""
    Dim cNomAvalRepre As String = ""
    Dim cNotAval As String = ""
    Dim cContrato As String = ""
    Dim cCusnam As String = ""
    Dim cDomicilio As String = ""
    Dim cDomAval As String = ""
    Dim cNameCte As String = ""
    Dim cNumEscCte As String = ""
    Dim cFechaEscCte As String = ""
    Dim cNumNotCte As String = ""
    Dim cNotDeCte As String = ""
    Dim cFeLicCte As String = ""
    Dim cRegPubCte As String = ""
    Dim cFolioMerCte As String = ""
    Dim cFechaFolCte As String = ""
    Dim cRFC As String = ""
    Dim cNacionCte As String = ""
    Dim cFechanac As String = ""
    Dim cEdonac As String = ""
    Dim cTel1ava As String = ""
    Dim cTel2ava As String = ""
    Dim cMailava As String = ""
    Dim cNameRepCte As String = ""
    Dim cNumEscRepCte As String = ""
    Dim cFechaEscRepCte As String = ""
    Dim cNumNotRepCte As String = ""
    Dim cNotDeRepCte As String = ""
    Dim cFeLicRepCte As String = ""
    Dim cRegPubRepCte As String = ""
    Dim cFolioMerRepCte As String = ""
    Dim cFechaFolRepCte As String = ""
    Dim cNameRepAva As String = ""
    Dim cNameRepAvacte As String = ""
    Dim cNumEscRepAvacte As String = ""
    Dim cFechaEscRepAvacte As String = ""
    Dim cNumNotRepAvacte As String = ""
    Dim cNotDeRepAvacte As String = ""
    Dim cFeLicRepAvacte As String = ""
    Dim cRegPubRepAvacte As String = ""
    Dim cFolioMerRepAvacte As String = ""
    Dim cFechaFolRepAvacte As String = ""
    Dim cParrafo As String = ""
    Dim cExRepr As String = ""
    Dim cExAval As String = ""
    Dim nPlazo As Integer
    Dim drAnexoCTO As DataRow
    Dim drAnexoAVA As DataRow
    Dim cFirmaAval As String = ""
    Dim cNomAvFirma As String = ""
    Dim cDatosAvales As String = ""   'Nuevo
    Dim cDatosFirmas As String = ""  ' Nuevo
    Dim cDatosRepFirma As String = ""  'Nuevo
    Dim cLinea1 As String = ""  'Nuevo
    Dim cLinea2 As String = ""  'Nuevo
    Dim cFirmaCte As String = ""
    Dim cNRepCte As String = ""
    Dim cIniciso3 As Boolean = False
    Dim cAtteCli As String = ""
    Dim cAtteAval As String = ""
    Dim cCuadrocte As String = ""
    Dim cCuadroava As String = ""
    Dim cObli As String = ""
    Dim Parrafo6 As String = ""

    Dim CarpetaPalntillas As String = "f:\Full\"

    Public Sub New(ByVal cAnexo As String, ByVal Nombre As String)
        MyBase.New()
        InitializeComponent()
        txtAnexo.Text = cAnexo
        txtCusnam.Text = Nombre
        Anexo = Mid(cAnexo, 1, 5) & Mid(cAnexo, 7, 4)
    End Sub

    Private Sub btnCtom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtom.Click
        Cursor.Current = Cursors.WaitCursor
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document

        If cTipo = "M" Then
            cNota = "a) Que es una persona moral constituida conforme a las leyes de los Estados Unidos Mexicanos, seg�n consta en la escritura p�blica n�mero " & Trim(drAnexoCTO("NoEscritura")) & " de " & "fecha " & Mes(DTOC(Trim(drAnexoCTO("EscrituraFecha")))).ToLower & ", otorgada ante la fe del licenciado " & Trim(drAnexoCTO("FeLicenciado")) & ", Notario p�blico n�mero " & Trim(drAnexoCTO("NumeroNotario")) & " de " & Trim(drAnexoCTO("NotarioDe")) & ", inscrita en el Registro P�blico del Comercio de " & Trim(drAnexoCTO("RegistoPublicoNo")) & " bajo el folio mercantil n�mero " & Trim(drAnexoCTO("FolioMercantil")) & ", de fecha " & Mes(DTOC(Trim(drAnexoCTO("FechaFolio")))).ToLower & "."
            cNota = cNota & Chr(10) & "b) Que su objeto social le permite la celebraci�n del presente Contrato y sus anexos, por lo que la suscripci�n del mismo y de cualquier otro documento que se suscriba a su amparo no contraviene ni resultan en conflicto con sus estatutos; cualquier contrato o acto jur�dico que tenga celebrado; o con la legislaci�n, reglamentaci�n o normativa, federal, estatal o municipal vigente de los Estados Unidos Mexicanos que por cualquier causa le pudiese resultar aplicable."
            cNota = cNota & Chr(10) & "c) Que su domicilio se encuentra ubicado en " & cDomicilio & " y su Registro Federal de Contribuyentes es " & drAnexoCTO("RFC") & "."
            cNota = cNota & Chr(10) & "d) Que cuenta con la capacidad econ�mica para hacer frente a las obligaciones contra�das en el presente Contrato, sus anexos y cualquier otro documento que se suscriba a su amparo, sin que tenga obligaci�n contingente alguna que, de resultar exigible, pudiere tener un efecto adverso en su  situaci�n financiera o en sus operaciones y que pudiere representar un riesgo en el cumplimiento de las obligaciones que contraiga con el presente Contrato y sus Anexos."
            cNota = cNota & Chr(10) & "e) Que autoriza expresamente a 'LA PRESTADORA' para que, por conducto de sus funcionarios facultados lleve a cabo investigaciones, sobre su comportamiento crediticio en las sociedades de Informaci�n Crediticia que estime conveniente."
            cNota = cNota & Chr(10) & cLinea1
        Else
            cNota = Chr(10) & Chr(10) & "a)	Que es de nacionalidad " & Trim(drAnexoCTO("Nacionalidad")) & ", con fecha de nacimiento " & Mes(drAnexoCTO("Fecha1")).ToLower & ", originario de " & Trim(drAnexoCTO("PLD_Estadonac")) & ", cuya ocupaci�n es [*], [soltero/casado] bajo el r�gimen de [sociedad conyugal/separaci�n de bienes]."
            cNota = cNota & Chr(10) & "b) Que su domicilio se encuentra ubicado en " & cDomicilio & " y su Registro Federal de Contribuyentes es " & drAnexoCTO("RFC") & "."
            cNota = cNota & Chr(10) & "c) Que tiene plena capacidad para celebrar el presente Contrato, sus Anexos y cualesquiera otros documentos que se suscriban a su amparo, por lo que la celebraci�n de los mismos, constituyen o constituir�n, seg�n sea el caso, obligaciones v�lidas y vinculatorias para las Partes."
            cNota = cNota & Chr(10) & "d) Cuenta con la capacidad econ�mica para hacer frente a las obligaciones contra�das en el presente Contrato y sus Anexos, sin que tenga obligaci�n contingente alguna que, de resultar exigible, pudiere tener un efecto adverso en su situaci�n financiera o en sus operaciones y que pudiere representar un riesgo en el cumplimiento de las obligaciones que contraiga con el presente Contrato, sus Anexos y cualesquiera otros documentos suscritos a su amparo."
            cNota = cNota & Chr(10) & "e) Autoriza expresamente  a LA PRESTADORA para  que, por conducto de  sus  funcionarios facultados lleve a cabo investigaciones, sobre su comportamiento crediticio en las sociedades de Informaci�n Crediticia que estime conveniente. "
            cNota = cNota & Chr(10) & "f) Que es su voluntad contratar los servicios de 'LA PRESTADORA', mismos que describen a lo largo del presente Contrato y sus Anexos."
            cNota = cNota & Chr(10) & "g) Que 'LA PRESTADORA' ha puesto a su disposici�n como anexo del presente contrato el aviso de privacidad a que se refiere la Ley Federal de Protecci�n de Datos Personales en Posesi�n de los Particulares, mismo que ha consentido."
        End If
        If cIniciso3 = True Then
            If cTipoAV = "M" Then
                cNotAval = "III. Declara el 'OBLIGADO SOLIDARIO': "
                cNotAval = cNotAval & Parrafo6
            Else
                cNotAval = "III. Declara el 'OBLIGADO SOLIDARIO': "
                cNotAval = cNotAval & Parrafo6
            End If
        Else
            cNotAval = "III. No Aplica "
        End If
        cParrafo = " Declaran las PARTES y el 'OBLIGADO SOLIDARIO' bajo protesta de decir verdad, por conducto de sus representantes legales o apoderados o por su propio derecho, seg�n corresponda, que los recursos econ�micos para el cumplimiento de las obligaciones que contraen en t�rminos del presente Contrato, provienen y provendr�n de fuentes l�citas, asimismo manifiestan que los datos proporcionados y los asentados en este instrumento son verdaderos, conociendo las repercusiones que se puedan suscitar en su contra por declaraciones falsas; dedic�ndose a desarrollar una actividad l�cita, la cual les permitir� obtener los recursos necesarios para cumplir con todas y cada una de sus obligaciones de pago derivadas y que se deriven del presente instrumento y sus Anexos."
        oRuta = CarpetaPalntillas & "Contrato_STE.doc"
        oWordDoc = New Microsoft.Office.Interop.Word.Document()
        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        With oWordDoc.Sections(1)
            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(CarpetaPalntillas & "Logo.JPG")
            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "CONTRATO DE PRESTACION DE SERVICIOS DE TRANSPORTE EMPRESARIAL  No. " & drAnexoCTO("ContratoMarco"))
        End With

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code
            cFieldText = rFieldCode.Text
            If cFieldText.StartsWith(" MERGEFIELD") Then
                finMerge = cFieldText.IndexOf("\")
                fieldNameLen = cFieldText.Length - finMerge
                cfName = cFieldText.Substring(11, finMerge - 11)
                cfName = cfName.Trim()

                Select Case cfName

                    Case "mAnexo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drAnexoCTO("ContratoMarco")
                    Case "mNota"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cNota
                    Case "mAtencion"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("DescPromotor"))
                    Case "mDomicilio"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDomicilio)
                    Case "mName"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCusnam)
                    Case "mMail"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(drAnexoCTO("Email1")) <> "" And Trim(drAnexoCTO("Email2")) <> "" Then
                            myMField.Result.Text = Trim(drAnexoCTO("Email1")) & "; " & Trim(drAnexoCTO("Email2"))
                        Else
                            myMField.Result.Text = Trim(drAnexoCTO("Email1"))
                        End If
                    Case "mTel1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("Telef1"))
                    Case "mTel2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("Telef2"))
                    Case "mNotaAva"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cNotAval
                    Case "mParrafo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = "IV. " & cParrafo
                    Case "mApoderado"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cExAval = "" Then
                            myMField.Result.Text = ""
                        Else
                            myMField.Result.Text = cDatosFirmas   ''''
                        End If
                    Case "mApoderado2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaCte   ''''
                    Case "mObli2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cExAval = "" Then
                            myMField.Result.Text = ","
                        Else
                            myMField.Result.Text = " y " & cObli & " como obligado(s) solidario(s),"
                        End If
                    Case "mCorreo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("Correo"))
                    Case "mDomava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cDomAval) <> "" Then
                            myMField.Result.Text = Trim(cDomAval)
                        Else
                            myMField.Result.Text = ""
                        End If
                    Case "mNameava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cNameRepAva) <> "" Then
                            myMField.Result.Text = Trim(cNameRepAva)
                        Else
                            myMField.Result.Text = ""
                        End If
                    Case "mTelava1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cTel1ava) <> "" Then
                            myMField.Result.Text = cTel1ava
                        Else
                            myMField.Result.Text = ""
                        End If
                    Case "mTelava2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cTel2ava) <> "" Then
                            myMField.Result.Text = cTel2ava
                        Else
                            myMField.Result.Text = ""
                        End If
                    Case "mMailava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cMailava
                    Case "mFechacon"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(drAnexoCTO("Fechacon")).ToLower
                    Case "mFechacon2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = CTOD(drAnexoCTO("Fechacon"))
                    Case "mNomObli"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cNomAval)
                    Case "mTasa"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Round(drAnexoCTO("Tasas") + drAnexoCTO("Difer"), 2)
                    Case "mAtteCli"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cAtteCli
                    Case "mDatosAval"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDatosAvales
                    Case "mNameRepava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDatosRepFirma
                End Select
                oWord.Selection.Fields.Update()
            End If
        Next

        Dim oMissing As Object = System.Reflection.Missing.Value
        Dim oSaveAsFile As Object = "C:\contratos\" & Trim(cCusnam) & "_CTO_" & cContrato & ".doc"
        Try
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDatosVehi.Click
        Dim f As New FrmDatosVehiculo
        f.Contrato = Anexo
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Private Sub frmActiAnexFull_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        For Each Archivo As String In My.Computer.FileSystem.GetFiles("c:\Contratos\")
            Try
                File.Delete(Archivo)
            Catch ex As Exception
                MessageBox.Show("Favor de cerrar su docuemnto " & Archivo, "Archivo Abierto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next
        Dim ta As New GeneralDSTableAdapters.QueryVariosTableAdapter
        If ta.SacaStatus(Anexo) = "S" Then
            Bloquea(True)
        Else
            Bloquea(False)
        End If
        Dim drAval As DataRow
        Dim drCte As DataRow
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daDatosCto As New SqlDataAdapter(cm1)
        Dim daAvales As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()

        Dim nCount As Integer = 1
        Dim nCount2 As Integer = 1
        Dim nIn As Integer
        Dim nIn2 As Integer
        Dim cInciso As String = "a)b)c)d)e)f)g)h)i)j)k)l)m)n)�)o)p)q)r)s)t)u)v)w)x)y)z)"
        Dim cLinea0 As String = ""
        Dim cLineaB As String = ""
        Dim cClienteRep As String = ""
        Dim cCliente As String = ""
        Dim Parrafo1 As String = ""
        Dim Parrafo2 As String = ""
        Dim Parrafo3 As String = ""
        Dim Parrafo4 As String = ""
        Dim Parrafo5 As String = ""
        Dim Parrafo7 As String = ""
        Dim Obliant As String = ""
        Dim Nameant As String = ""
        Dim Numero As Integer

        ' Declaraci�n de variables de datos

        cContrato = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Vw_FULL_DatosContrato WHERE Anexo = " & "'" & cContrato & "'"
            .Connection = cnAgil
        End With
        daDatosCto.Fill(dsAgil, "DatosCto")
        If dsAgil.Tables("DatosCto").Rows.Count <= 0 Then
            MessageBox.Show("Falta capturar datos legales (Clientes, representantes o avales)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End If
        drAnexoCTO = dsAgil.Tables("DatosCto").Rows(0)

        '********Saca el nombre del cliete pasa sacar datos de acta contitutiva*****************
        cCusnam = drAnexoCTO("Descr").ToString.Trim
        dsAgil.Tables("DatosCto").Clear()
        cm1.CommandText = "SELECT * FROM Vw_FULL_DatosContrato WHERE Anexo = " & "'" & cContrato & "' and Representante = '" & cCusnam & "'"
        daDatosCto.Fill(dsAgil, "DatosCto")

        If dsAgil.Tables("DatosCto").Rows.Count <= 0 Then
            MessageBox.Show("Falta capturar datos legales (Acta consitutiva del Cliente)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End If
        drAnexoCTO = dsAgil.Tables("DatosCto").Rows(0)
        TxtContMarco.Text = drAnexoCTO("ContratoMarco")
        '*********Saca el nombre del cliete pasa sacar datos de acta contitutiva*****************



        cTipo = drAnexoCTO("Tipo")
        cCusnam = drAnexoCTO("Descr").ToString.Trim
        cCliente = drAnexoCTO("Cliente")
        cNameRepCte = Trim(drAnexoCTO("Nomrepr"))
        cDomicilio = "Calle " & Trim(drAnexoCTO("PLD_Calle")) & " Num. Ext. " & Trim(drAnexoCTO("PLD_Numext")) & " Num. Int. " & Trim(drAnexoCTO("PLD_Numint")) & " " & Trim(drAnexoCTO("PLD_Tipoasent")) & " " & Trim(drAnexoCTO("PLD_Asentamiento")) & " Delegaci�n " & Trim(drAnexoCTO("PLD_Delegacion")) & ", " & Trim(drAnexoCTO("PLD_Ciudad")) & Trim(drAnexoCTO("PLD_Estado")) & ", C.P. " & drAnexoCTO("PLD_Copos")
        If Trim(drAnexoCTO("Email1")) <> "" And Trim(drAnexoCTO("Email2")) <> "" Then
            cCuadrocte = "DENOMINACION SOCIAL: " & Trim(cCusnam) & Space(10) & "R.F.C.: " & drAnexoCTO("RFC") & "E_MAIL: " & Trim(drAnexoCTO("Email1")) & "; " & Trim(drAnexoCTO("Email2")) & Chr(10) & "DOMICILIO: " & cDomicilio & Space(10) & "TELEFONOS: " & Trim(drAnexoCTO("Telef1"))
        Else
            cCuadrocte = "DENOMINACION SOCIAL: " & Trim(cCliente) & Space(10) & "R.F.C.: " & drAnexoCTO("RFC") & "E_MAIL: " & Trim(drAnexoCTO("Email1")) & Chr(10) & cDomicilio & Space(10) & "TELEFONOS: " & Trim(drAnexoCTO("Telef1"))
        End If
        nPlazo = drAnexoCTO("Plazo")
        If Not IsDBNull(drAnexoCTO("AtencionDe")) Then
            cAtteCli = drAnexoCTO("AtencionDe")
        End If

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Vw_FULL_DatosContratoAvales WHERE Anexo = " & "'" & cContrato & "'"
            .Connection = cnAgil
        End With
        daAvales.Fill(dsAgil, "DatosAval")

        cm1.CommandText = "SELECT * FROM Vw_FULL_DatosContrato WHERE Anexo = " & "'" & cContrato & "' and Representante <> '" & cCusnam & "'"
        'dsAgil.Tables("DatosCtoAVA").Clear()
        daDatosCto.Fill(dsAgil, "DatosCtoAVA")
        drAnexoAVA = dsAgil.Tables("DatosCtoAVA").Rows(0)

        For Each drAval In dsAgil.Tables("DatosCtoAVA").Rows
            cExRepr = "S"
            cClienteRep = drAval("Cliente")
            cNumEscRepCte = drAval("NoEscritura")
            cFechaEscRepCte = DTOC(drAval("EscrituraFecha"))
            cNumNotRepCte = drAval("NumeroNotario")
            cNotDeRepCte = drAval("NotarioDe")
            cFeLicRepCte = drAval("FeLicenciado")
            cRegPubRepCte = drAval("RegistoPublicoNo")
            cFolioMerRepCte = drAval("FolioMercantil")
            cFechaFolRepCte = DTOC(drAval("FechaFolio"))
            cNameRepAva = Trim(drAval("Descr"))
            If nCount2 = 1 Then
                cNRepCte = Trim(drAval("Representante"))
            ElseIf nCount2 = dsAgil.Tables("DatosCto").Rows.Count And Trim(drAval("Representante")) <> "" Then
                cNRepCte += " y " & Trim(drAval("Representante"))
            ElseIf Trim(drAval("Representante")) <> "" Then
                cNRepCte += ", " & Trim(drAval("Representante"))
            End If

            If nCount2 = 1 Then
                nIn = 11
                cDatosRepFirma = ReplicateString("_", Len(Trim(drAval("Representante"))) + 6) & Chr(10) & "Por: " & Trim(drAval("Representante")) & Chr(10) & "Cargo:[APODERADO]"

                If cTipo = "M" Then
                    cLinea0 = ", posee las facultades suficientes y necesarias para celebrar en su representaci�n el presente Contrato, oblig�ndola en los t�rminos del mismo, lo cual se acredita con la escritura p�blica n�mero "
                    cLinea1 = Mid(cInciso, nIn, 2) & " Que su representante legal " & Trim(drAval("Representante")) & cLinea0 & cNumEscRepCte & ", de fecha " & Mes(cFechaEscRepCte).ToLower & ", otorgada ante la fe del notario p�blico n�mero " & cNumNotRepCte & " de " & cNotDeRepCte & ", licenciado " & cFeLicRepCte & ", inscrita en el Registro P�blico del Comercio de " & cRegPubRepCte & " bajo el folio mercantil n�mero " & cFolioMerRepCte & ", de fecha " & Mes(cFechaFolRepCte).ToLower & ", facultades que no le han sido modificadas, revocadas ni limitadas de forma alguna."
                    cFirmaCte = cCusnam & Chr(10) & Chr(10) & ReplicateString("_", Len(Trim(drAval("Representante"))) + 6) & Chr(10) & Trim(drAval("Representante")) & Chr(10) & "APODERADO"
                Else
                    cFirmaCte = Chr(10) & Chr(10) & ReplicateString("_", Len(cCusnam) + 6) & Chr(10) & cCusnam
                End If
            Else
                nIn += 2
                cDatosRepFirma += Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(Trim(drAval("Representante"))) + 6) & Chr(10) & "Por: " & Trim(drAval("Representante")) & Chr(10) & "Cargo:[APODERADO]"
                If cTipo = "M" Then
                    cLinea1 += Chr(10) & Mid(cInciso, nIn, 2) & " Que su representante legal " & Trim(drAval("Representante")) & cLinea0 & cNumEscRepCte & ", de fecha " & Mes(cFechaEscRepCte).ToLower & ", otorgada ante la fe del notario p�blico n�mero " & cNumNotRepCte & " de " & cNotDeRepCte & ", licenciado " & cFeLicRepCte & ", inscrita en el Registro P�blico del Comercio de " & cRegPubRepCte & " bajo el folio mercantil n�mero " & cFolioMerRepCte & ", de fecha " & Mes(cFechaFolRepCte).ToLower & ", facultades que no le han sido modificadas, revocadas ni limitadas de forma alguna."
                    cFirmaCte += Chr(10) & Chr(10) & cCusnam & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(Trim(drAval("Representante"))) + 6) & Chr(10) & Trim(drAval("Representante")) & Chr(10) & "APODERADO"
                End If
            End If
            nCount2 += 1
        Next
        nIn += 2
        cLinea1 += Chr(10) & Mid(cInciso, nIn, 2) & " Que es su voluntad contratar los servicios de 'LA PRESTADORA', mismos que se describen en el presente Contrato y sus Anexos. "


        If dsAgil.Tables("DatosAval").Rows.Count > 0 Then
            Try

                Numero = dsAgil.Tables("DatosAval").Rows.Count

                For Each drAval In dsAgil.Tables("DatosAval").Rows

                    If Trim(drAval("DescripPers")) = "OBLIGADO SOLIDARIO" Or Trim(drAval("DescripPers")) = "AVAL" Then

                        cExAval = "S"
                        If Not IsDBNull(drAval("NoEscritura")) And Not IsDBNull(drAval("EscrituraFecha")) Then
                            cNumEscCte = drAval("NoEscritura")
                            cFechaEscCte = DTOC(drAval("EscrituraFecha"))
                            cNumNotCte = drAval("NumeroNotario")
                            cNotDeCte = drAval("NotarioDe")
                            cFeLicCte = drAval("FeLicenciado")
                            cRegPubCte = drAval("RegistoPublicoNo")
                            cFolioMerCte = drAval("FolioMercantil")
                            cFechaFolCte = DTOC(drAval("FechaFolio"))
                            cNomAvalRepre = drAval("Representante")
                            cAtteAval = drAval("AtencionDe")
                        End If
                        cTipoAV = drAval("Tipo")
                        cRFC = drAval("RFC")
                        cNomAval = drAval("Descr")
                        cNomAvFirma = cNomAvFirma & " " & Trim(drAval("Descr"))  ' Nuevo
                        cNacionCte = drAval("Nacionalidad")
                        cFechanac = drAval("Fecha1")
                        cEdonac = drAval("PLD_Estadonac")
                        cTel1ava = drAval("Telef1")
                        cTel2ava = drAval("Telef2")
                        cMailava = drAval("EMail1")
                        cDomAval = "Calle " & Trim(drAval("PLD_Calle")) & " Num. Ext. " & Trim(drAval("PLD_Numext")) & " Num. Int. " & Trim(drAval("PLD_Numint")) & " " & Trim(drAval("PLD_Tipoasent")) & " " & Trim(drAval("PLD_Asentamiento")) & " Delegaci�n " & Trim(drAval("PLD_Delegacion")) & ", " & Trim(drAval("PLD_Ciudad")) & Trim(drAval("PLD_Estado")) & ", C.P. " & drAval("PLD_Copos")
                        cFirmaAval = cFirmaAval & Chr(10) & Chr(10) & Chr(10) & "EL AVAL" & Chr(10) & Trim(drAval("Descr") & Chr(10) & Chr(10) & ReplicateString("_", Len(Trim(cNomAvalRepre)) + 6) & Chr(10) & Trim(cNomAvalRepre))  ' Nuevo
                        cIniciso3 = True

                        If nCount = 1 Then

                            nIn2 = 1
                            cDatosAvales = "Domicilio de OBLIGADO SOLIDARIO: " & cDomAval & Chr(10)
                            cCuadroava = "DENOMINACION SOCIAL: " & Trim(cNomAval) & Space(10) & "R.F.C.: " & cRFC & Space(10) & "E_MAIL: " & cMailava & Chr(10) & cDomAval & Space(10) & Chr(10) & "TELEFONO: " & cTel1ava & Trim(cTel2ava)
                            cLineaB = " posee las facultades suficientes y necesarias para celebrar en su representaci�n el presente Contrato, oblig�ndola en los t�rminos del mismo, lo cual se acredita con la escritura p�blica n�mero "

                            If cTipoAV = "M" Then
                                Parrafo1 = "Que es una sociedad mercantil denominada " & Trim(cNomAval) & ",constituida de conformidad con las leyes de los Estados Unidos Mexicanos, seg�n consta en la escritura p�blica/p�liza n�mero" & cNumEscCte & " de " & "fecha " & Mes(cFechaEscCte).ToLower & ", otorgada ante la fe del [notario/corredor] p�blico n�mero " & Trim(cNumNotCte) & " de " & Trim(cNotDeCte) & ", licenciado " & Trim(cFeLicCte) & ", inscrita en el Registro P�blico del Comercio de " & Trim(cRegPubCte) & " bajo el folio mercantil n�mero " & Trim(cFolioMerCte) & ", de fecha " & Mes(cFechaFolCte).ToLower & "."
                                Parrafo2 = "Su objeto social le permite la celebraci�n del presente Contrato y sus Anexos en calidad de Obligado Solidario, por lo que la suscripci�n del mismo y cualesquiera otros documentos que se suscriban a su amparo no contravienen ni resultan en conflicto con sus estatutos; cualquier contrato o acto jur�dico que tenga celebrado, o con la legislaci�n, reglamentaci�n o normativa, federal, estatal o municipal vigente de los Estados Unidos Mexicanos que por cualquier causa le pudiese resultar aplicable."
                                Parrafo3 = "Su domicilio se encuentra ubicado en " & cDomAval & " y su Registro Federal de Contribuyentes es " & cRFC & "."

                                Parrafo4 = "Cuenta con la capacidad econ�mica para hacer frente a las obligaciones contra�das en el presente Contrato y sus Anexos, sin que tenga obligaci�n contingente alguna que, de resultar exigible, pudiere tener un efecto adverso en su situaci�n financiera o en sus operaciones y que pudiere representar un riesgo en el cumplimiento de las obligaciones que contraiga con el presente Contrato y cualesquiera otros documentos suscritos a su amparo."
                                Parrafo5 = "Autoriza expresamente  a LA PRESTADORA para  que, por conducto de  sus  funcionarios facultados lleve  a  cabo investigaciones, sobre su comportamiento crediticio en las sociedades de Informaci�n Crediticia que estime conveniente."
                                cLinea2 = Chr(10) & cNomAvalRepre & cLineaB & cNumEscCte & ", de fecha " & Mes(cFechaEscCte).ToLower & ", otorgada ante la fe del notario p�blico n�mero " & cNumNotCte & " de " & cNotDeCte & ", licenciado " & cFeLicCte & ", inscrita en el Registro P�blico de la Propiedad y del Comercio de " & cRegPubCte & " bajo el folio mercantil n�mero " & cFolioMerCte & ", de fecha " & Mes(cFechaFolCte).ToLower & ", facultades que no le han sido modificadas, revocadas ni limitadas de forma alguna."

                            Else
                                Parrafo1 = "Que su nombre es " & Trim(cNomAval) & " de nacionalidad " & Trim(cNacionCte) & ", con fecha de nacimiento " & Mes(cFechanac).ToLower & ", originario de " & Trim(cEdonac) & ", cuya ocupaci�n es [*], [soltero/casado] bajo el r�gimen de [sociedad conyugal/separaci�n de bienes]."
                                Parrafo2 = "Que tiene plena capacidad para celebrar el presente Contrato y cualesquiera otros documentos que se suscriban a su amparo, por lo que la celebraci�n de los mismos, constituyen, o despu�s de su celebraci�n constituir�n, seg�n sea el caso, obligaciones v�lidas y vinculatorias para las Partes."
                                Parrafo3 = cNotAval & Chr(10) & "Que su domicilio se encuentra ubicado en " & cDomAval & " y su Registro Federal de Contribuyentes es " & cRFC & "."
                                Parrafo4 = "Cuenta con la capacidad econ�mica para hacer frente a las obligaciones contra�das en el presente Contrato y cualesquiera otros documentos que se suscriban a su amparo, sin que tenga obligaci�n contingente alguna que, de resultar exigible, pudiere tener un efecto adverso en su situaci�n financiera o en sus operaciones y que pudiere representar un riesgo en el cumplimiento de las obligaciones que contraiga con el presente Contrato y sus anexos."
                                Parrafo5 = "Que 'LA PRESTADORA' ha puesto a su disposici�n el aviso de privacidad a que se refiere la Ley Federal de Protecci�n de Datos Personales en Posesi�n de los Particulares, mismo que ha consentido."
                                Parrafo7 = "Se constituye en este acto en Obligado Solidario a favor de LA PRESTADORA respecto de todas y cada una de las obligaciones que se deriven del presente Contrato, sus Anexos y dem�s documentos suscritos a su amparo, a cargo de EL CLIENTE, con la solidaridad que establecen los art�culos 1987, 1988 y 1989 del C�digo  Civil Federal, mismos que constituir�n obligaciones v�lidas y exigibles en su contra de conformidad con sus respectivos t�rminos. Esta responsabilidad solidaria incluye, sin limitar, el pago total de las Contraprestaciones, seg�n dicho t�rmino se define m�s adelante, el pago de los intereses, comisiones y dem�s accesorios que se originen a favor de LA PRESTADORA."

                            End If

                            If cTipoAV = "M" Then
                                cObli = Trim(cNomAval) & " Representada por " & Trim(cNomAvalRepre)
                                cDatosFirmas = "EL(LOS) 'OBLIGADO(S) SOLIDARIO(S)'" & Chr(10) & Trim(cNomAval) & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(cNomAvalRepre) + 6) & Chr(10) & "Por: " & Trim(cNomAvalRepre) & Chr(10) & "Cargo: [APODERADO]"
                                cDatosAvales += "1.- " & Trim(cNomAval) & " Representada por " & cNomAvalRepre & Chr(10)
                            Else
                                cObli = Trim(cNomAval)
                                cDatosFirmas = "EL(LOS) 'OBLIGADO(S) SOLIDARIO(S)'" & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(cNomAvalRepre) + 6) & Chr(10) & "Por: " & Trim(cNomAval) & Chr(10) & "Cargo: [APODERADO]"
                                cDatosAvales += "1.- " & Trim(cNomAval) & Chr(10)
                            End If
                        Else
                            cDatosAvales += "Domicilio de OBLIGADO SOLIDARIO: " & cDomAval & Chr(10)
                            cDatosFirmas += Chr(10) & Chr(10) & Chr(10) & Trim(cNomAval) & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(cNomAvalRepre) + 6) & Chr(10) & "Por: " & Trim(cNomAvalRepre) & Chr(10) & "Cargo: [APODERADO]"

                            If Trim(cNomAval) <> Obliant Then
                                cCuadroava += Chr(10) & Chr(10) & "DENOMINACION SOCIAL: " & Trim(cNomAval) & Space(10) & "R.F.C.: " & cRFC & Space(10) & "E_MAIL: " & cMailava & Chr(10) & cDomAval & Space(10) & "TELEFONO: " & cTel1ava & Trim(cTel2ava)

                                If cTipoAV = "M" Then
                                    Parrafo1 = "Que es una sociedad mercantil denominada " & Trim(cNomAval) & ",constituida de conformidad con las leyes de los Estados Unidos Mexicanos, seg�n consta en la escritura p�blica/p�liza n�mero" & cNumEscCte & " de " & "fecha " & Mes(cFechaEscCte).ToLower & ", otorgada ante la fe del [notario/corredor] p�blico n�mero " & Trim(cNumNotCte) & " de " & Trim(cNotDeCte) & ", licenciado " & Trim(cFeLicCte) & ", inscrita en el Registro P�blico del Comercio de " & Trim(cRegPubCte) & " bajo el folio mercantil n�mero " & Trim(cFolioMerCte) & ", de fecha " & Mes(cFechaFolCte).ToLower & "."
                                    Parrafo2 = "Su objeto social le permite la celebraci�n del presente Contrato y sus Anexos en calidad de Obligado Solidario, por lo que la suscripci�n del mismo y cualesquiera otros documentos que se suscriban a su amparo no contravienen ni resultan en conflicto con sus estatutos; cualquier contrato o acto jur�dico que tenga celebrado, o con la legislaci�n, reglamentaci�n o normativa, federal, estatal o municipal vigente de los Estados Unidos Mexicanos que por cualquier causa le pudiese resultar aplicable."
                                    Parrafo3 = "Su domicilio se encuentra ubicado en " & cDomAval & " y su Registro Federal de Contribuyentes es " & cRFC & "."

                                    Parrafo4 = "Cuenta con la capacidad econ�mica para hacer frente a las obligaciones contra�das en el presente Contrato y sus Anexos, sin que tenga obligaci�n contingente alguna que, de resultar exigible, pudiere tener un efecto adverso en su situaci�n financiera o en sus operaciones y que pudiere representar un riesgo en el cumplimiento de las obligaciones que contraiga con el presente Contrato y cualesquiera otros documentos suscritos a su amparo."
                                    Parrafo5 = "Autoriza expresamente  a LA PRESTADORA para  que, por conducto de  sus  funcionarios facultados lleve  a  cabo investigaciones, sobre su comportamiento crediticio en las sociedades de Informaci�n Crediticia que estime conveniente."
                                    cLinea2 = Chr(10) & cNomAvalRepre & cLineaB & cNumEscCte & ", de fecha " & Mes(cFechaEscCte).ToLower & ", otorgada ante la fe del notario p�blico n�mero " & cNumNotCte & " de " & cNotDeCte & ", licenciado " & cFeLicCte & ", inscrita en el Registro P�blico de la Propiedad y del Comercio de " & cRegPubCte & " bajo el folio mercantil n�mero " & cFolioMerCte & ", de fecha " & Mes(cFechaFolCte).ToLower & ", facultades que no le han sido modificadas, revocadas ni limitadas de forma alguna."

                                Else
                                    Parrafo1 = "Que su nombre es " & Trim(cNomAval) & " de nacionalidad " & Trim(cNacionCte) & ", con fecha de nacimiento " & Mes(cFechanac).ToLower & ", originario de " & Trim(cEdonac) & ", cuya ocupaci�n es [*], [soltero/casado] bajo el r�gimen de [sociedad conyugal/separaci�n de bienes]."
                                    Parrafo2 = "Que tiene plena capacidad para celebrar el presente Contrato y cualesquiera otros documentos que se suscriban a su amparo, por lo que la celebraci�n de los mismos, constituyen, o despu�s de su celebraci�n constituir�n, seg�n sea el caso, obligaciones v�lidas y vinculatorias para las Partes."
                                    Parrafo3 = cNotAval & Chr(10) & "Que su domicilio se encuentra ubicado en " & cDomAval & " y su Registro Federal de Contribuyentes es " & cRFC & "."
                                    Parrafo4 = "Cuenta con la capacidad econ�mica para hacer frente a las obligaciones contra�das en el presente Contrato y cualesquiera otros documentos que se suscriban a su amparo, sin que tenga obligaci�n contingente alguna que, de resultar exigible, pudiere tener un efecto adverso en su situaci�n financiera o en sus operaciones y que pudiere representar un riesgo en el cumplimiento de las obligaciones que contraiga con el presente Contrato y sus anexos."
                                    Parrafo5 = "Que 'LA PRESTADORA' ha puesto a su disposici�n el aviso de privacidad a que se refiere la Ley Federal de Protecci�n de Datos Personales en Posesi�n de los Particulares, mismo que ha consentido."
                                    Parrafo7 = "Se constituye en este acto en Obligado Solidario a favor de LA PRESTADORA respecto de todas y cada una de las obligaciones que se deriven del presente Contrato, sus Anexos y dem�s documentos suscritos a su amparo, a cargo de EL CLIENTE, con la solidaridad que establecen los art�culos 1987, 1988 y 1989 del C�digo  Civil Federal, mismos que constituir�n obligaciones v�lidas y exigibles en su contra de conformidad con sus respectivos t�rminos. Esta responsabilidad solidaria incluye, sin limitar, el pago total de las Contraprestaciones, seg�n dicho t�rmino se define m�s adelante, el pago de los intereses, comisiones y dem�s accesorios que se originen a favor de LA PRESTADORA."

                                End If

                            End If

                            If cTipoAV = "M" Then
                                cObli += ", " & Trim(cNomAval) & " Representada por " & Trim(cNomAvalRepre)
                                cDatosAvales += "1.- " & Trim(cNomAval) & " Representada por " & cNomAvalRepre & Chr(10)
                            Else
                                cObli += ", " & Trim(cNomAval)
                                cDatosAvales += "1.- " & Trim(cNomAval)
                            End If
                            If cTipoAV = "M" Then
                                cLinea2 = Chr(10) & cNomAvalRepre & cLineaB & cNumEscCte & ", de fecha " & Mes(cFechaEscCte).ToLower & ", otorgada ante la fe del notario p�blico n�mero " & cNumNotCte & " de " & cNotDeCte & ", licenciado " & cFeLicCte & ", inscrita en el Registro P�blico de la Propiedad y del Comercio de " & cRegPubCte & " bajo el folio mercantil n�mero " & cFolioMerCte & ", de fecha " & Mes(cFechaFolCte).ToLower & ", facultades que no le han sido modificadas, revocadas ni limitadas de forma alguna."
                            End If
                        End If
                        If Trim(Parrafo7) = "" Then
                            If nCount = 1 Then
                                Parrafo6 += Chr(10) & Mid(cInciso, nIn2, 2) & " " & Parrafo1 & Chr(10) & Parrafo2 & Chr(10) & Parrafo3 & Chr(10) & Parrafo4 & Chr(10) & Parrafo5 & cLinea2
                            End If
                        Else
                            Parrafo6 += Chr(10) & Mid(cInciso, nIn2, 2) & " " & Parrafo1 & Chr(10) & Parrafo2 & Chr(10) & Parrafo3 & Chr(10) & Parrafo4 & Chr(10) & Parrafo5 & Chr(10) & Parrafo7
                        End If

                        If Trim(drAval("Descr")) = Obliant And Obliant <> "" And Parrafo7 = "" Then
                            Nameant = Trim(drAval("Descr"))
                            Parrafo6 += cLinea2
                        ElseIf nCount > 1 And Trim(drAval("Descr")) <> Obliant And Obliant <> "" And Parrafo7 = "" Then
                            If Nameant <> Trim(drAval("Descr")) And Nameant <> "" Then
                                Parrafo6 += Chr(10) & " Se constituye en este acto en Obligado Solidario a favor de LA PRESTADORA respecto de todas y cada una de las obligaciones que se deriven del presente Contrato, sus Anexos y dem�s documentos suscritos a su amparo, a cargo de EL CLIENTE, con la solidaridad que establecen los art�culos 1987, 1988 y 1989 del C�digo  Civil Federal, mismos que constituir�n obligaciones v�lidas y exigibles en su contra de conformidad con sus respectivos t�rminos. Esta responsabilidad solidaria incluye, sin limitar, el pago total de las Contraprestaciones, seg�n dicho t�rmino se define m�s adelante, el pago de los intereses, comisiones y dem�s accesorios que se originen a favor de LA PRESTADORA."
                                Nameant = ""
                            End If
                            nIn2 += 2
                            If Nameant <> "" Then
                                cLinea2 += Chr(10) & " Se constituye en este acto en Obligado Solidario a favor de LA PRESTADORA respecto de todas y cada una de las obligaciones que se deriven del presente Contrato, sus Anexos y dem�s documentos suscritos a su amparo, a cargo de EL CLIENTE, con la solidaridad que establecen los art�culos 1987, 1988 y 1989 del C�digo  Civil Federal, mismos que constituir�n obligaciones v�lidas y exigibles en su contra de conformidad con sus respectivos t�rminos. Esta responsabilidad solidaria incluye, sin limitar, el pago total de las Contraprestaciones, seg�n dicho t�rmino se define m�s adelante, el pago de los intereses, comisiones y dem�s accesorios que se originen a favor de LA PRESTADORA."
                            End If
                            Parrafo6 += Chr(10) & Mid(cInciso, nIn2, 2) & " " & Parrafo1 & Chr(10) & Parrafo2 & Chr(10) & Parrafo3 & Chr(10) & Parrafo4 & Chr(10) & Parrafo5 & cLinea2
                        End If

                        If Numero = nCount Then
                            cLinea2 = Chr(10) & " Se constituye en este acto en Obligado Solidario a favor de LA PRESTADORA respecto de todas y cada una de las obligaciones que se deriven del presente Contrato, sus Anexos y dem�s documentos suscritos a su amparo, a cargo de EL CLIENTE, con la solidaridad que establecen los art�culos 1987, 1988 y 1989 del C�digo  Civil Federal, mismos que constituir�n obligaciones v�lidas y exigibles en su contra de conformidad con sus respectivos t�rminos. Esta responsabilidad solidaria incluye, sin limitar, el pago total de las Contraprestaciones, seg�n dicho t�rmino se define m�s adelante, el pago de los intereses, comisiones y dem�s accesorios que se originen a favor de LA PRESTADORA."
                            Parrafo6 += cLinea2
                        End If
                        cDatosAvales += "Tel�fono: " & cTel1ava & Chr(10)
                        cDatosAvales += "Telefax:  " & cTel2ava & Chr(10)
                        cDatosAvales += "Correo electr�nico:  " & cMailava & Chr(10)
                        cDatosAvales += "Atenci�n de: " & cAtteAval & Chr(10) & Chr(10)
                        nCount += 1
                        Obliant = Trim(cNomAval)
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Dispose()
            End Try
        End If

    End Sub

    Sub Bloquea(ByVal Activar As Boolean)
        btnActivar.Enabled = Activar
        btnCtom.Enabled = Not Activar
        btnACto.Enabled = Not Activar
        BtnPagare.Enabled = Not Activar
        BtnFPC.Enabled = Not Activar
        btnAvisoP.Enabled = Not Activar
        BtnDatosVehi.Enabled = Not Activar
        BtnPld.Enabled = Not Activar
        BtnHoja.Enabled = Not Activar
    End Sub

    Private Sub btnActivar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnActivar.Click
        Dim ta As New GeneralDSTableAdapters.AnexosTableAdapter
        If ta.TieneTabla(Anexo) > 0 Then
            ta.Activar(Anexo)
            MessageBox.Show("Contrato Activado", "Activaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Bloquea(False)
        Else
            MessageBox.Show("Contrato sin tabla, favor de cargar tabla", "Activaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnACto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnACto.Click
        Cursor.Current = Cursors.WaitCursor
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim drAnex As DataRow
        Dim drAval As DataRow
        Dim drServ As DataRow
        Dim drVehi As DataRow
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim daDatosCto As New SqlDataAdapter(cm1)
        Dim daAvales As New SqlDataAdapter(cm2)
        Dim daServicios As New SqlDataAdapter(cm3)
        Dim daVehiculos As New SqlDataAdapter(cm4)
        Dim dsAgil As New DataSet()

        ' Declaraci�n de variables de datos

        Dim cRFCava As String = ""
        Dim cEMailava1 As String = ""
        Dim cEMailava2 As String = ""
        Dim cCalleava As String = ""
        Dim cNumEava As String = ""
        Dim cNumIava As String = ""
        Dim cColava As String = ""
        Dim cCPava As String = ""
        Dim cDelava As String = ""
        Dim cEdoava As String = ""
        Dim cTelava As String = ""
        Dim cServicioscont As String = ""
        Dim cServiciosdesc As String = ""
        Dim cDescrpBienes As String = ""
        Dim cContrato As String = ""
        Dim cTipo As String = ""
        Dim cCusnam As String = ""
        Dim cDomicilio As String = ""
        Dim cNomAval As String = ""
        Dim cNameRepAva As String = ""
        Dim cNameRepCte As String = ""
        Dim cFvenc As String = ""
        Dim cNumIV As String = ""
        Dim nCount As Integer
        Dim nMensu As Decimal
        Dim nComis As Decimal
        Dim nGastos As Decimal

        cContrato = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Vw_FULL_DatosContrato WHERE Anexo = " & "'" & cContrato & "'"
            .Connection = cnAgil
        End With
        daDatosCto.Fill(dsAgil, "DatosCto")

        drAnex = dsAgil.Tables("DatosCto").Rows(0)
        cTipo = drAnex("Tipo")
        cCusnam = drAnex("Descr")
        nPlazo = drAnex("Plazo")
        nMensu = drAnex("Mensu") / 1.16
        nComis = drAnex("Comis") / 1.16
        nGastos = drAnex("Gastos")
        cFvenc = drAnex("Fvenc")

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Vw_FULL_DatosContratoAvales WHERE Anexo = " & "'" & cContrato & "'"
            .Connection = cnAgil
        End With
        daAvales.Fill(dsAgil, "DatosAval")

        With cm3
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Vw_FULL_ServiciosDatos WHERE Anexo = " & "'" & cContrato & "'"
            .Connection = cnAgil
        End With
        daServicios.Fill(dsAgil, "Servicios")

        With cm4
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM FULL_Vehiculos WHERE Anexo = " & "'" & cContrato & "'"
            .Connection = cnAgil
        End With
        daVehiculos.Fill(dsAgil, "Vehiculos")

        For Each drServ In dsAgil.Tables("Servicios").Rows
            nCount += 1
            If nCount = 1 Then
                cServicioscont = Trim(drServ("Descripcion")) & " con un Importe de $ " & FormatNumber(drServ("Importe")).ToString
                cServiciosdesc = Trim(drServ("DescripcionContrato"))
            Else
                cServicioscont = cServicioscont & Chr(13) & Trim(drServ("Descripcion")) & " con un Importe de $ " & FormatNumber(drServ("Importe")).ToString
                cServiciosdesc = cServiciosdesc & Chr(13) & Trim(drServ("DescripcionContrato"))
            End If
        Next

        nCount = 0
        For Each drVehi In dsAgil.Tables("Vehiculos").Rows
            nCount += 1
            If nCount = 1 Then
                cDescrpBienes = "Marca:  " & Trim(drVehi("Marca")) & Chr(13) _
                & "Submarca:  " & Trim(drVehi("SubMarca")) & Chr(13) _
                & "Tipo o versi�n:  " & Trim(drVehi("Version")) & Chr(13) _
                & "Color:  " & Trim(drVehi("Color")) & Chr(13) _
                & "A�o-modelo:  " & Trim(drVehi("Modelo")) & Chr(13) _
                & "N�mero de Identificaci�n Vehicular:  " & Trim(drVehi("NoIdentificacionVehic")) & Chr(13) _
                & "N�mero de Serie:  " & Trim(drVehi("Serie")) & Chr(13) _
                & "N�mero de Motor:  " & Trim(drVehi("Motor")) & Chr(13) _
                & "Capacidad:  " & Trim(drVehi("Capacidad")) & Chr(13) _
                & "N�mero de placas:  " & Trim(drVehi("Placas")) & Chr(13) _
                & "Lugar de entrega:  " & Trim(drVehi("LugarEntrega")) & Chr(13) _
                & "Fecha de entrega:  " & Trim(drVehi("FechaEntrega"))
            Else
                cDescrpBienes = cDescrpBienes & Chr(13) & "Marca:  " & Trim(drVehi("Marca")) & Chr(13) _
                & "Submarca:  " & Trim(drVehi("SubMarca")) & Chr(13) _
                & "Tipo o versi�n:  " & Trim(drVehi("Version")) & Chr(13) _
                & "Color:  " & Trim(drVehi("Color")) & Chr(13) _
                & "A�o-modelo:  " & Trim(drVehi("Modelo")) & Chr(13) _
                & "N�mero de Identificaci�n Vehicular:  " & Trim(drVehi("NoIdentificacionVehic")) & Chr(13) _
                & "Capacidad:  " & Trim(drVehi("Capacidad")) & Chr(13) _
                & "N�mero de placas:  " & Trim(drVehi("Placas")) & Chr(13) _
                & "Lugar de entrega:  " & Trim(drVehi("LugarEntrega")) & Chr(13) _
                & "Fecha de entrega:  " & Trim(drVehi("FechaEntrega"))
            End If
        Next

        For Each drAval In dsAgil.Tables("DatosAval").Rows
            If Trim(drAval("DescripPers")) = "REPRESENTANTE LEGAL" Then
                cNameRepAva = Trim(drAval("Descr"))
            ElseIf Trim(drAval("DescripPers")) = "OBLIGADO SOLIDARIO" Or Trim(drAval("DescripPers")) = "AVAL" Then
                cRFCava = drAval("RFC")
                cEMailava1 = drAval("EMail1")
                cEMailava2 = drAval("EMail2")
                cCalleava = drAval("PLD_Calle")
                cNumEava = drAval("PLD_Numext")
                cNumIava = drAval("PLD_Numint")
                cColava = drAval("PLD_Asentamiento")
                cCPava = drAval("PLD_Copos")
                cDelava = drAval("PLD_Delegacion")
                cEdoava = drAval("PLD_Estado")
                cTelava = Trim(drAval("Telef1")) & " " & Trim(drAval("Telef2"))
                cNomAval = drAval("Descr")
            End If
        Next

        ' Dim tableLocation As Word.Range = Me.Range(Start:=0, End:=0)
        '     oWord.Application.ActiveDocument.Tables.Add(Range:=tableLocation, NumRows:=3, NumColumns:=4)
        ' Abro el Contrato

        oRuta = CarpetaPalntillas & "Anexo_ContratoSTE.doc"
        oWordDoc = New Microsoft.Office.Interop.Word.Document()
        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)
        Dim tableLocation As Word.Range = oWord.Application.ActiveDocument.Range(Start:=0, End:=0)

        With oWordDoc.Sections(1)
            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(CarpetaPalntillas & "Logo.JPG")
            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "CONTRATO DE PRESTACION DE SERVICIOS DE TRANSPORTE EMPRESARIAL  No. " & drAnexoCTO("ContratoMarco"))
        End With

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo �nicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quit�ndole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable

                Select Case cfName
                    Case "mMailPromo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drAnex("Correo")
                    Case "mAnexo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drAnexoCTO("ContratoMarco")
                    Case "mCto"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cContrato
                    Case "mCallecte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("PLD_Calle"))
                    Case "mNumEIcte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("PLD_Numext")) & "-" & Trim(drAnexoCTO("PLD_Numint"))
                    Case "mCuadrocte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCuadrocte
                    Case "mCuadroava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cCuadroava) = "" Then
                            myMField.Result.Text = "NO APLICA"
                        Else
                            myMField.Result.Text = cCuadroava
                        End If
                    Case "mColcte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("PLD_Asentamiento"))
                    Case "mCPcte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("PLD_Copos"))
                    Case "mName"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCusnam)
                    Case "mMail"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(drAnexoCTO("Email1")) <> "" And Trim(drAnexoCTO("Email2")) <> "" Then
                            myMField.Result.Text = Trim(drAnexoCTO("Email1")) & "; " & Trim(drAnexoCTO("Email2"))
                        Else
                            myMField.Result.Text = Trim(drAnexoCTO("Email1"))
                        End If
                    Case "mTel1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("Telef1"))
                    Case "mDeleg"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("PLD_Delegacion"))
                    Case "mEstado"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("PLD_Estado"))
                    Case "mRFC"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drAnexoCTO("RFC")
                    Case "mRFCava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRFCava
                    Case "mNameava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cNomAval)
                    Case "mCalleava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCalleava)
                    Case "mNumEIava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cNumEava) <> "" And Trim(cNumIava) <> "" Then
                            myMField.Result.Text = Trim(cNumEava) & "-" & Trim(cNumIava)
                        Else
                            myMField.Result.Text = Trim(cNumEava)
                        End If
                    Case "mColava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cColava)
                    Case "mCPava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCPava)
                    Case "mDelgava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDelava)
                    Case "mEdoava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cEdoava)
                    Case "mTel1ava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cTelava) <> "" Then
                            myMField.Result.Text = cTelava
                        Else
                            myMField.Result.Text = ""
                        End If
                    Case "mMailava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cEMailava1) <> "" And Trim(cEMailava2) <> "" Then
                            myMField.Result.Text = Trim(cEMailava1) & "; " & Trim(cEMailava2)
                        ElseIf Trim(cEMailava1) <> "" And Trim(cEMailava2) = "" Then
                            myMField.Result.Text = Trim(cEMailava1)
                        Else
                            myMField.Result.Text = ""
                        End If
                    Case "mApodCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cNameRepAva) <> "" Then
                            myMField.Result.Text = cNRepCte
                        Else
                            myMField.Result.Text = ""
                        End If
                    Case "mObli"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cObli
                    Case "mNameRepava"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDatosRepFirma
                    Case "mMtoTotal"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(Round(nMensu * nPlazo, 2)).ToString & " " & Letras(Round(nMensu * nPlazo, 2))
                    Case "mPI"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(Round(nComis + nGastos + nMensu, 2)).ToString & " " & Letras(Round(nComis + nGastos + nMensu, 2))
                    Case "mPlazo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = nPlazo.ToString
                    Case "mMensu"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(Round(nMensu, 2)).ToString & " " & Letras(Round(nMensu, 2))
                    Case "mFvenc"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFvenc).ToLower
                    Case "mDia"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mid(cFvenc, 7, 2)
                    Case "mTermina"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(DTOC(Termina(cContrato))).ToLower
                    Case "mFechacon"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(drAnexoCTO("Fechacon")).ToLower
                    Case "mFechacon2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = CTOD(drAnexoCTO("Fechacon"))
                    Case "mServicioscont"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cServicioscont
                    Case "mDescServicios"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cServiciosdesc
                    Case "mDescBienes"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDescrpBienes
                    Case "mNomAvalRepre"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cNomAvalRepre
                    Case "mApoderado"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cExAval = "" Then
                            myMField.Result.Text = ""
                        Else
                            myMField.Result.Text = cDatosFirmas
                        End If

                End Select

                oWord.Selection.Fields.Update()

            End If
        Next

        'Guardo el documento

        Dim oMissing As Object = System.Reflection.Missing.Value
        Dim oSaveAsFile As Object = "C:\Contratos\" & Trim(cCusnam) & "_CTO_ANEXO_" & cContrato & ".doc"
        Try
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnFPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFPC.Click
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document

        Dim drVehi As DataRow

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daVehiculos As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet()

        Dim nCount As Integer
        Dim cDescBienes2 As String = ""

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM FULL_Vehiculos WHERE Anexo = " & "'" & cContrato & "'"
            .Connection = cnAgil
        End With
        daVehiculos.Fill(dsAgil, "Vehiculos")


        nCount = 0
        For Each drVehi In dsAgil.Tables("Vehiculos").Rows
            nCount += 1
            If nCount = 1 Then
                cDescBienes2 = "Marca:  " & Trim(drVehi("Marca")) & ", " & "Submarca:  " & Trim(drVehi("SubMarca")) & ", " _
                & "Tipo o versi�n:  " & Trim(drVehi("Version")) & ", " & "Color:  " & Trim(drVehi("Color")) & ", " _
                & "A�o-modelo:  " & Trim(drVehi("Modelo")) & ", " _
                & "N�mero de Identificaci�n Vehicular:  " & Trim(drVehi("NoIdentificacionVehic")) & ", " _
                & "N�mero de Serie:  " & Trim(drVehi("Serie")) & ", " _
                & "N�mero de Motor:  " & Trim(drVehi("Motor")) & ", " _
                & "Capacidad:  " & Trim(drVehi("Capacidad")) & ", " & "N�mero de placas:  " & Trim(drVehi("Placas")) & ", " _
                & "Lugar de entrega:  " & Trim(drVehi("LugarEntrega")) & ", " & "Fecha de entrega:  " & Trim(drVehi("FechaEntrega"))
            Else
                cDescBienes2 += ", Marca:  " & Trim(drVehi("Marca")) & ", " & "Submarca:  " & Trim(drVehi("SubMarca")) & ", " _
                & "Tipo o versi�n:  " & Trim(drVehi("Version")) & ", " & "Color:  " & Trim(drVehi("Color")) & ", " _
                & "A�o-modelo:  " & Trim(drVehi("Modelo")) & ", " _
                & "N�mero de Identificaci�n Vehicular:  " & Trim(drVehi("NoIdentificacionVehic")) & ", " _
                & "N�mero de Serie:  " & Trim(drVehi("Serie")) & ", " _
                & "N�mero de Motor:  " & Trim(drVehi("Motor")) & ", " _
                & "Capacidad:  " & Trim(drVehi("Capacidad")) & ", " & "N�mero de placas:  " & Trim(drVehi("Placas")) & ", " _
                & "Lugar de entrega:  " & Trim(drVehi("LugarEntrega")) & ", " & "Fecha de entrega:  " & Trim(drVehi("FechaEntrega"))
            End If
        Next


        If cTipo = "M" Then
            cNota2 = "a) Es una sociedad debidamente constituida de acuerdo con las leyes de la Rep�blica Mexicana, seg�n consta en la escritura p�blica n�mero " & Trim(drAnexoCTO("NoEscritura")) & ", otorgada ante la fe del licenciado " & Trim(drAnexoCTO("FeLicenciado")) & ", Notario p�blico n�mero " & Trim(drAnexoCTO("NumeroNotario")) & " de " & Trim(drAnexoCTO("NotarioDe")) & " e inscrita en el Registro P�blico del Comercio de " & Trim(drAnexoCTO("RegistoPublicoNo")) & " bajo el folio mercantil n�mero " & Trim(drAnexoCTO("FolioMercantil")) & "."
            cNota2 = cNota2 & Chr(10) & Chr(10) & "b) Su(s) representante(s) legal act�a(n) con todas la facultades necesarias para obligarla, as� como para suscribir el presente instrumento, facultades que a la fecha no le(s) han sido modificadas o limitadas seg�n consta en la escritura p�blica n�mero " & Trim(drAnexoCTO("NoEscritura")) & ", otrogada ante la fe del Lic. " & Trim(drAnexoCTO("FeLicenciado")) & ", Notario P�blico " & (drAnexoCTO("NumeroNotario")) & " de " & Trim(drAnexoCTO("NotarioDe")) & " e inscrita en el Registro P�blico de Comercio de " & Trim(drAnexoCTO("RegistoPublicoNo")) & " bajo el folio mercantil " & Trim(drAnexoCTO("FolioMercantil")) & "."
            cNota2 = cNota2 & Chr(10) & Chr(10) & "c) Su Registro Federal de Contribuyentes es " & drAnexoCTO("RFC") & " y su domicilio se encuentra ubicado en " & cDomicilio & "."
            cNota2 = cNota2 & Chr(10) & Chr(10) & "d) Que tiene plena capacidad para celebrar el presente Contrato y cualesquiera otros documentos que se suscriban a su amparo, por lo que la celebraci�n de los mismos, constituyen o constituir�n, seg�n sea el caso, obligaciones v�lidas y vinculatorias para las 'PARTES'."
            cNota2 = cNota2 & Chr(10) & Chr(10) & "e) Cuenta con la capacidad econ�mica para hacer frente a las obligaciones contra�das en el presente Contrato sin que tenga obligaci�n contingente alguna que, de resultar exigible, pudiere tener un efecto adverso en su situaci�n financiera o en sus operaciones y que pudiere representar un riesgo en el cumplimiento de las obligaciones que contraiga con el presente Contrato y cualesquiera otros documentos suscritos a su amparo."
        Else
            cNota2 = Chr(10) & Chr(10) & Chr(10) & "a) Que es de nacionalidad " & Trim(drAnexoCTO("Nacionalidad")) & ", con fecha de nacimiento " & Mes(drAnexoCTO("Fecha1")).ToLower & ", originario de " & Trim(drAnexoCTO("PLD_Estadonac")) & ", cuya ocupaci�n es [*], [soltero/casado] bajo el r�gimen de [sociedad conyugal/separaci�n de bienes]."
            cNota2 = cNota2 & Chr(10) & Chr(10) & "b)	Que su domicilio se encuentra ubicado en " & cDomicilio & " y su Registro Federal de Contribuyentes es " & drAnexoCTO("RFC") & "."
            cNota2 = cNota2 & Chr(10) & Chr(10) & "c)	Que tiene plena capacidad para celebrar el presente Contrato, sus Anexos y cualesquiera otros documentos que se suscriban a su amparo, por lo que la celebraci�n de los mismos, constituyen o constituir�n, seg�n sea el caso, obligaciones v�lidas y vinculatorias para las Partes."
            cNota2 = cNota2 & Chr(10) & Chr(10) & "d)	Cuenta con la capacidad econ�mica para hacer frente a las obligaciones contra�das en el presente Contrato y sus Anexos, sin que tenga obligaci�n contingente alguna que, de resultar exigible, pudiere tener un efecto adverso en su situaci�n financiera o en sus operaciones y que pudiere representar un riesgo en el cumplimiento de las obligaciones que contraiga con el presente Contrato, sus Anexos y cualesquiera otros documentos suscritos a su amparo."
        End If

        ' Abro el Contrato

        oRuta = CarpetaPalntillas & "PromCompraventa.doc"
        oWordDoc = New Microsoft.Office.Interop.Word.Document()
        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        With oWordDoc.Sections(1)
            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(CarpetaPalntillas & "Logo.JPG")
        End With

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo �nicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quit�ndole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable

                Select Case cfName

                    Case "mName"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCusnam)
                    Case "mNameFirma"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipo = "M" Then
                            myMField.Result.Text = Trim(cCusnam) & Chr(13) & "REPRESENTADA POR"
                        Else
                            myMField.Result.Text = ""
                        End If
                    Case "mApodCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cNameRepAva) <> "" Then
                            myMField.Result.Text = cNRepCte
                        Else
                            myMField.Result.Text = ""
                        End If
                    Case "mApodCteFirma"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cNameRepAva) <> "" Then
                            myMField.Result.Text = cNameRepAva
                        Else
                            myMField.Result.Text = cCusnam
                        End If
                    Case "mPlazo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = nPlazo.ToString
                    Case "mFechacon"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(drAnexoCTO("Fechacon")).ToLower
                    Case "mNota2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cNota2
                    Case "mTermina"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(DTOC(Termina(cContrato))).ToLower
                    Case "mContrato"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cContrato
                    Case "mDescBien2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDescBienes2
                    Case "mFirmaCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaCte
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        Dim oMissing As Object = System.Reflection.Missing.Value
        Dim oSaveAsFile As Object = "C:\Contratos\" & Trim(cCusnam) & "_FPC_" & cContrato & ".doc"
        Try
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try


    End Sub

    Private Sub btnAvisoP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvisoP.Click
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document

        ' Abro el Contrato

        oRuta = CarpetaPalntillas & "AvisoP.doc"

        'oWord = New Microsoft.Office.Interop.Word.Application()

        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantilla

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        With oWordDoc.Sections(1)
            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(CarpetaPalntillas & "Logo.JPG")
        End With

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo �nicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quit�ndole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable

                Select Case cfName

                    Case "mNameCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipo = "M" Then
                            myMField.Result.Text = Trim(cCusnam) & " " & "Representada por " & cNRepCte
                        Else
                            myMField.Result.Text = Trim(cCusnam)
                        End If
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        Dim oMissing As Object = System.Reflection.Missing.Value
        Dim oSaveAsFile As Object = "C:\Contratos\" & Trim(cCusnam) & "_AP_" & cContrato & ".doc"

        Try
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnPagare_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnPagare.Click
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document

        Dim drPagos As DataRow

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daTabla As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet()
        Dim cLetra As String = ""
        Dim cFeven As String = ""
        Dim cRenta As String = ""
        Dim cSucursal As String = ""
        Dim cLugar As String = ""
        Dim cCantidad As String = ""
        Dim cCantidad2 As String = ""

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Edoctav WHERE Anexo = " & "'" & cContrato & "'" & " order by Letra"
            .Connection = cnAgil
        End With
        daTabla.Fill(dsAgil, "Tabla")

        For Each drPagos In dsAgil.Tables("Tabla").Rows
            cLetra = cLetra & Chr(10) & drPagos("Letra")
            cFeven = cFeven & Chr(10) & CTOD(drPagos("Feven"))
            cRenta = cRenta & Chr(10) & FormatNumber(Round(drAnexoCTO("Mensu"), 2)).ToString
        Next

        cCantidad = Mid(Letras(drAnexoCTO("Mensu") * nPlazo), 1, Len(Letras(drAnexoCTO("Mensu") * nPlazo)) - 5)
        cCantidad = cCantidad.ToLower & "M.N.)"
        cCantidad2 = Mid(Cant_Letras(((drAnexoCTO("Tasas") + drAnexoCTO("Difer")) * 2).ToString, ""), 1, Len(Cant_Letras(((drAnexoCTO("Tasas") + drAnexoCTO("Difer")) * 2).ToString, "")) - 1)
        cCantidad2 = cCantidad2.ToLower & " por ciento) anual"

        cSucursal = drAnexoCTO("Sucursal")
        If cSucursal = "03" Then
            cLugar = "Navojoa, Sonora"
        ElseIf cSucursal = "04" Then
            cLugar = "Mexicali, Baja California"
        ElseIf cSucursal = "01" Then
            cLugar = "Toluca, Estado de M�xico"
        ElseIf cSucursal = "02" Then
            cLugar = "Quer�taro, Quer�taro"
        ElseIf cSucursal = "05" Then
            cLugar = "Irapuato, Guanajuato"
        End If

        ' Abro el Contrato

        oRuta = CarpetaPalntillas & "PAGARE_FS.doc"

        'oWord = New Microsoft.Office.Interop.Word.Application()

        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantilla

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        With oWordDoc.Sections(1)
            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(CarpetaPalntillas & "Logo.JPG")
        End With

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo �nicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quit�ndole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable

                Select Case cfName

                    Case "mNameCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipo = "M" Then
                            myMField.Result.Text = Trim(cCusnam) & " " & "Representada por " & cNRepCte
                        Else
                            myMField.Result.Text = Trim(cCusnam) & " y " & cNomAval
                        End If
                    Case "mTotal"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(Round(drAnexoCTO("Mensu") * nPlazo, 2)).ToString & " " & cCantidad
                    Case "mCusnam"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCusnam
                    Case "mTasmor"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Round((drAnexoCTO("Tasas") + drAnexoCTO("Difer")) * 2, 2).ToString & "% " & cCantidad2
                    Case "mDescr"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCusnam
                    Case "mCalle"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(drAnexoCTO("PLD_Numint")) <> "" Then
                            myMField.Result.Text = Trim(drAnexoCTO("PLD_Calle")) & " Num. Ext. " & Trim(drAnexoCTO("PLD_Numext")) & " Num. Int. " & Trim(drAnexoCTO("PLD_Numint"))
                        Else
                            myMField.Result.Text = Trim(drAnexoCTO("PLD_Calle")) & " Num. Ext. " & Trim(drAnexoCTO("PLD_Numext"))
                        End If
                    Case "mColonia"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("PLD_Tipoasent")) & " " & Trim(drAnexoCTO("PLD_Asentamiento"))
                    Case "mCopos"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drAnexoCTO("PLD_Copos")
                    Case "mDelegacion"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("PLD_Delegacion"))
                    Case "mEstado"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drAnexoCTO("PLD_Ciudad")) & Trim(drAnexoCTO("PLD_Estado"))
                    Case "mLugar"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cLugar)
                    Case "mFechacon"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(drAnexoCTO("Fechacon"))
                    Case "mLetrat"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLetra
                    Case "mFevent"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFeven
                    Case "mRenta"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRenta
                    Case "mFirmaCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaCte
                    Case "mFirmaAval"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval
                    Case "mNomAvalRepre"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cNomAvalRepre
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        Dim oMissing As Object = System.Reflection.Missing.Value
        Dim oSaveAsFile As Object = "C:\contratos\" & Trim(cCusnam) & "_PAG_FS_" & cContrato & ".doc"

        Try
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try

    End Sub

    Function ReplicateString(ByVal Source As String, ByVal Times As Long) As String
        Dim length As Long, index As Long
        ' Crea la l�nea
        length = Len(Source)
        ReplicateString = Space$(length * Times)
        ' Realiza multiples copias del valor Source 
        For index = 1 To Times
            Mid$(ReplicateString, (index - 1) * length + 1, length) = Source
        Next
    End Function

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPld.Click
        DOC_Pld.CreaDocumento(Anexo, "")
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHoja.Click
        DOC_DatosAnexoFull.GeneraDoc(Anexo)
    End Sub
End Class