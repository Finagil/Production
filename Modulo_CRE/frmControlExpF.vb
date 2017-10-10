Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports Microsoft.VisualBasic.Financial
Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Security.Principal.WindowsIdentity
Imports System.Security
Imports Word = Microsoft.Office.Interop.Word

Public Class frmControlExpF

    Public Sub New(ByVal cCliente As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtPassword.Text = cCliente

    End Sub

    Dim cSave As String = "I"

    Private Sub frmControlExpF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daCliente As New SqlDataAdapter(cm)
        Dim daDocumento As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()
        Dim drDocument As DataRow
        Dim drName As DataRow

        Dim cCliente As String

        With cm
            .CommandType = CommandType.Text
            .CommandText = "SELECT Descr FROM Clientes WHERE Cliente = " & "'" & txtPassword.Text & "'"
            .Connection = cnAgil
        End With
        daCliente.Fill(dsAgil, "Name")
        drName = dsAgil.Tables("Name").Rows(0)

        Me.Text = "Registro de Documentación del Cliente " & Trim(drName("Descr"))
        cCliente = txtPassword.Text

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM CtrlEF WHERE Cliente = " & "'" & cCliente & "'"
            .Connection = cnAgil
        End With

        daDocumento.Fill(dsAgil, "Datos")
        If dsAgil.Tables("Datos").Rows.Count > 0 Then
            drDocument = dsAgil.Tables("Datos").Rows(0)
            cSave = "M"
            TextBox12.Text = drDocument("Ejercicio")
            dtpFecha.Value = CTOD(drDocument("FechaEF"))
            ComboBox1.SelectedText = drDocument("Ine1")
            ComboBox2.SelectedText = drDocument("Ine2")
            ComboBox3.SelectedText = drDocument("Ine3")
            ComboBox4.SelectedText = drDocument("Pas1")
            ComboBox5.SelectedText = drDocument("Pas2")
            ComboBox6.SelectedText = drDocument("Pas3")
            ComboBox7.SelectedText = drDocument("Cep1")
            ComboBox8.SelectedText = drDocument("Cep2")
            ComboBox9.SelectedText = drDocument("Cep3")
            TextBox1.Text = drDocument("ObIof")
            ComboBox18.SelectedText = drDocument("Curp1")
            ComboBox17.SelectedText = drDocument("Curp2")
            ComboBox16.SelectedText = drDocument("Curp3")
            TextBox2.Text = drDocument("ObCurp")
            ComboBox15.SelectedText = drDocument("Fiel1")
            ComboBox14.SelectedText = drDocument("Fiel2")
            ComboBox13.SelectedText = drDocument("Fiel3")
            TextBox3.Text = drDocument("ObFiel")
            ComboBox12.SelectedText = drDocument("Rfc1")
            ComboBox11.SelectedText = drDocument("Rfc2")
            ComboBox10.SelectedText = drDocument("Rfc3")
            TextBox4.Text = drDocument("ObRfc")
            ComboBox27.SelectedText = drDocument("Cif1")
            ComboBox26.SelectedText = drDocument("Cif2")
            ComboBox25.SelectedText = drDocument("Cif3")
            TextBox5.Text = drDocument("ObCif")
            ComboBox24.SelectedText = drDocument("Anac1")
            ComboBox23.SelectedText = drDocument("Anac2")
            ComboBox22.SelectedText = drDocument("Anac3")
            TextBox6.Text = drDocument("ObAnac")
            ComboBox21.SelectedText = drDocument("Amat1")
            ComboBox20.SelectedText = drDocument("Amat2")
            ComboBox19.SelectedText = drDocument("Amat3")
            TextBox7.Text = drDocument("ObAmat")
            ComboBox36.SelectedText = drDocument("Cdom1")
            ComboBox35.SelectedText = drDocument("Cdom2")
            ComboBox34.SelectedText = drDocument("Cdom3")
            TextBox8.Text = drDocument("ObCdom")
            ComboBox33.SelectedText = drDocument("Acon1")
            ComboBox32.SelectedText = drDocument("Acon2")
            ComboBox31.SelectedText = drDocument("Acon3")
            TextBox9.Text = drDocument("ObAcon")
            ComboBox30.SelectedText = drDocument("Mac1")
            ComboBox29.SelectedText = drDocument("Mac2")
            ComboBox28.SelectedText = drDocument("Mac3")
            TextBox10.Text = drDocument("ObMac")
            ComboBox39.SelectedText = drDocument("Pod1")
            ComboBox38.SelectedText = drDocument("Pod2")
            ComboBox37.SelectedText = drDocument("Pod3")
            TextBox11.Text = drDocument("ObPod")
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()

        Dim strInsert As String
        Dim strUpdate As String
        Dim cCombo1 As String
        Dim cCombo2 As String
        Dim cCombo3 As String
        Dim cCombo4 As String
        Dim cCombo5 As String
        Dim cCombo6 As String
        Dim cCombo7 As String
        Dim cCombo8 As String
        Dim cCombo9 As String
        Dim cCombo10 As String
        Dim cCombo11 As String
        Dim cCombo12 As String
        Dim cCombo13 As String
        Dim cCombo14 As String
        Dim cCombo15 As String
        Dim cCombo16 As String
        Dim cCombo17 As String
        Dim cCombo18 As String
        Dim cCombo19 As String
        Dim cCombo20 As String
        Dim cCombo21 As String
        Dim cCombo22 As String
        Dim cCombo23 As String
        Dim cCombo24 As String
        Dim cCombo25 As String
        Dim cCombo26 As String
        Dim cCombo27 As String
        Dim cCombo28 As String
        Dim cCombo29 As String
        Dim cCombo30 As String
        Dim cCombo31 As String
        Dim cCombo32 As String
        Dim cCombo33 As String
        Dim cCombo34 As String
        Dim cCombo35 As String
        Dim cCombo36 As String
        Dim cCombo37 As String
        Dim cCombo38 As String
        Dim cCombo39 As String

        cCombo1 = IIf(ComboBox1.Text <> "", ComboBox1.Text, "")
        cCombo2 = IIf(ComboBox2.Text <> "", ComboBox2.Text, "")
        cCombo3 = IIf(ComboBox3.Text <> "", ComboBox3.Text, "")
        cCombo4 = IIf(ComboBox4.Text <> "", ComboBox4.Text, "")
        cCombo5 = IIf(ComboBox5.Text <> "", ComboBox5.Text, "")
        cCombo6 = IIf(ComboBox6.Text <> "", ComboBox6.Text, "")
        cCombo7 = IIf(ComboBox7.Text <> "", ComboBox7.Text, "")
        cCombo8 = IIf(ComboBox8.Text <> "", ComboBox8.Text, "")
        cCombo9 = IIf(ComboBox9.Text <> "", ComboBox9.Text, "")
        cCombo10 = IIf(ComboBox10.Text <> "", ComboBox10.Text, "")
        cCombo11 = IIf(ComboBox11.Text <> "", ComboBox11.Text, "")
        cCombo12 = IIf(ComboBox12.Text <> "", ComboBox12.Text, "")
        cCombo13 = IIf(ComboBox13.Text <> "", ComboBox13.Text, "")
        cCombo14 = IIf(ComboBox14.Text <> "", ComboBox14.Text, "")
        cCombo15 = IIf(ComboBox15.Text <> "", ComboBox15.Text, "")
        cCombo16 = IIf(ComboBox16.Text <> "", ComboBox16.Text, "")
        cCombo17 = IIf(ComboBox17.Text <> "", ComboBox17.Text, "")
        cCombo18 = IIf(ComboBox18.Text <> "", ComboBox18.Text, "")
        cCombo19 = IIf(ComboBox19.Text <> "", ComboBox19.Text, "")
        cCombo20 = IIf(ComboBox20.Text <> "", ComboBox20.Text, "")
        cCombo21 = IIf(ComboBox21.Text <> "", ComboBox21.Text, "")
        cCombo22 = IIf(ComboBox22.Text <> "", ComboBox22.Text, "")
        cCombo23 = IIf(ComboBox23.Text <> "", ComboBox23.Text, "")
        cCombo24 = IIf(ComboBox24.Text <> "", ComboBox24.Text, "")
        cCombo25 = IIf(ComboBox25.Text <> "", ComboBox25.Text, "")
        cCombo26 = IIf(ComboBox26.Text <> "", ComboBox26.Text, "")
        cCombo27 = IIf(ComboBox27.Text <> "", ComboBox27.Text, "")
        cCombo28 = IIf(ComboBox28.Text <> "", ComboBox28.Text, "")
        cCombo29 = IIf(ComboBox29.Text <> "", ComboBox29.Text, "")
        cCombo30 = IIf(ComboBox30.Text <> "", ComboBox30.Text, "")
        cCombo31 = IIf(ComboBox31.Text <> "", ComboBox31.Text, "")
        cCombo32 = IIf(ComboBox32.Text <> "", ComboBox32.Text, "")
        cCombo33 = IIf(ComboBox33.Text <> "", ComboBox33.Text, "")
        cCombo34 = IIf(ComboBox34.Text <> "", ComboBox34.Text, "")
        cCombo35 = IIf(ComboBox35.Text <> "", ComboBox35.Text, "")
        cCombo36 = IIf(ComboBox36.Text <> "", ComboBox36.Text, "")
        cCombo37 = IIf(ComboBox37.Text <> "", ComboBox37.Text, "")
        cCombo38 = IIf(ComboBox38.Text <> "", ComboBox38.Text, "")
        cCombo39 = IIf(ComboBox39.Text <> "", ComboBox39.Text, "")

        If cSave = "I" Then
            cnAgil.Open()
            strInsert = "INSERT INTO CtrlEF(Cliente,FechaEF,Ejercicio,Ine1,Ine2,Ine3,Pas1,Pas2,Pas3,Cep1,Cep2,Cep3,ObIof,Curp1,Curp2,Curp3,ObCurp,Fiel1,Fiel2,Fiel3,ObFiel,Rfc1,Rfc2,Rfc3,ObRfc,Cif1," & _
                        "Cif2,Cif3,ObCif,Anac1,Anac2,Anac3,ObAnac,Amat1,Amat2,Amat3,ObAmat,Cdom1,Cdom2,Cdom3,ObCdom,Acon1,Acon2,Acon3,ObAcon,Mac1,Mac2,Mac3,ObMac,Pod1,Pod2,Pod3,ObPod)"
            strInsert = strInsert & " VALUES ('" & txtPassword.Text & "', '" & DTOC(dtpFecha.Value) & "', '" & TextBox12.Text & "','" & cCombo1 & "', '" & cCombo2 & "', '"
            strInsert = strInsert & cCombo3 & "', '" & cCombo4 & "','" & cCombo5 & "', '"
            strInsert = strInsert & cCombo6 & "', '" & cCombo7 & "','" & cCombo8 & "', '"
            strInsert = strInsert & cCombo9 & "', '" & TextBox1.Text & "','" & cCombo18 & "', '"
            strInsert = strInsert & cCombo17 & "', '" & cCombo16 & "','" & TextBox2.Text & "', '"
            strInsert = strInsert & cCombo15 & "', '" & cCombo14 & "','" & cCombo13 & "', '"
            strInsert = strInsert & TextBox3.Text & "', '" & cCombo12 & "','" & cCombo11 & "', '"
            strInsert = strInsert & cCombo10 & "', '" & TextBox4.Text & "','" & cCombo27 & "', '"
            strInsert = strInsert & cCombo26 & "', '" & cCombo25 & "','" & TextBox5.Text & "', '"
            strInsert = strInsert & cCombo24 & "', '" & cCombo23 & "','" & cCombo22 & "', '"
            strInsert = strInsert & TextBox6.Text & "', '" & cCombo21 & "','" & cCombo20 & "', '"
            strInsert = strInsert & cCombo19 & "', '" & TextBox7.Text & "','" & cCombo36 & "', '"
            strInsert = strInsert & cCombo35 & "', '" & cCombo34 & "','" & TextBox8.Text & "', '"
            strInsert = strInsert & cCombo33 & "', '" & cCombo32 & "','" & cCombo31 & "', '"
            strInsert = strInsert & TextBox9.Text & "', '" & cCombo30 & "','" & cCombo29 & "', '"
            strInsert = strInsert & cCombo28 & "', '" & TextBox10.Text & "','" & cCombo39 & "', '"
            strInsert = strInsert & cCombo38 & "', '" & cCombo37 & "','" & TextBox11.Text & "')"
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()
            cnAgil.Close()

            MsgBox("Alta de Datos correcta", MsgBoxStyle.Information, "Mensaje de Sistema")

        End If

        If cSave = "M" Then
            strUpdate = "UPDATE CtrlEF SET Ine1 = '" & cCombo1 & "'"
            strUpdate = strUpdate & ", FechaEF = '" & DTOC(dtpFecha.Value) & "'"
            strUpdate = strUpdate & ", Ejercicio = '" & TextBox12.Text & "'"
            strUpdate = strUpdate & ", Ine2 = '" & cCombo2 & "'"
            strUpdate = strUpdate & ", Ine3 = '" & cCombo3 & "'"
            strUpdate = strUpdate & ", Pas1 = '" & cCombo4 & "'"
            strUpdate = strUpdate & ", Pas2 = '" & cCombo5 & "'"
            strUpdate = strUpdate & ", Pas3 = '" & cCombo6 & "'"
            strUpdate = strUpdate & ", Cep1 = '" & cCombo7 & "'"
            strUpdate = strUpdate & ", Cep2 = '" & cCombo8 & "'"
            strUpdate = strUpdate & ", Cep3 = '" & cCombo9 & "'"
            strUpdate = strUpdate & ", ObIof = '" & TextBox1.Text & "'"
            strUpdate = strUpdate & ", Curp1 = '" & cCombo18 & "'"
            strUpdate = strUpdate & ", Curp2 = '" & cCombo17 & "'"
            strUpdate = strUpdate & ", Curp3 = '" & cCombo16 & "'"
            strUpdate = strUpdate & ", ObCurp = '" & TextBox2.Text & "'"
            strUpdate = strUpdate & ", Fiel1 = '" & cCombo15 & "'"
            strUpdate = strUpdate & ", Fiel2 = '" & cCombo14 & "'"
            strUpdate = strUpdate & ", Fiel3 = '" & cCombo13 & "'"
            strUpdate = strUpdate & ", ObFiel = '" & TextBox3.Text & "'"
            strUpdate = strUpdate & ", Rfc1 = '" & cCombo12 & "'"
            strUpdate = strUpdate & ", Rfc2 = '" & cCombo11 & "'"
            strUpdate = strUpdate & ", Rfc3 = '" & cCombo10 & "'"
            strUpdate = strUpdate & ", ObRfc = '" & TextBox4.Text & "'"
            strUpdate = strUpdate & ", Cif1 = '" & cCombo27 & "'"
            strUpdate = strUpdate & ", Cif2 = '" & cCombo26 & "'"
            strUpdate = strUpdate & ", Cif3 = '" & cCombo25 & "'"
            strUpdate = strUpdate & ", ObCif = '" & TextBox5.Text & "'"
            strUpdate = strUpdate & ", Anac1 = '" & cCombo24 & "'"
            strUpdate = strUpdate & ", Anac2 = '" & cCombo23 & "'"
            strUpdate = strUpdate & ", Anac3 = '" & cCombo22 & "'"
            strUpdate = strUpdate & ", ObAnac = '" & TextBox6.Text & "'"
            strUpdate = strUpdate & ", Amat1 = '" & cCombo21 & "'"
            strUpdate = strUpdate & ", Amat2 = '" & cCombo20 & "'"
            strUpdate = strUpdate & ", Amat3 = '" & cCombo19 & "'"
            strUpdate = strUpdate & ", ObAmat = '" & TextBox7.Text & "'"
            strUpdate = strUpdate & ", Cdom1 = '" & cCombo36 & "'"
            strUpdate = strUpdate & ", Cdom2 = '" & cCombo35 & "'"
            strUpdate = strUpdate & ", Cdom3 = '" & cCombo34 & "'"
            strUpdate = strUpdate & ", ObCdom = '" & TextBox8.Text & "'"
            strUpdate = strUpdate & ", Acon1 = '" & cCombo33 & "'"
            strUpdate = strUpdate & ", Acon2 = '" & cCombo32 & "'"
            strUpdate = strUpdate & ", Acon3 = '" & cCombo31 & "'"
            strUpdate = strUpdate & ", ObAcon = '" & TextBox9.Text & "'"
            strUpdate = strUpdate & ", Mac1 = '" & cCombo30 & "'"
            strUpdate = strUpdate & ", Mac2 = '" & cCombo29 & "'"
            strUpdate = strUpdate & ", Mac3 = '" & cCombo28 & "'"
            strUpdate = strUpdate & ", ObMac = '" & TextBox10.Text & "'"
            strUpdate = strUpdate & ", Pod1 = '" & cCombo39 & "'"
            strUpdate = strUpdate & ", Pod2 = '" & cCombo38 & "'"
            strUpdate = strUpdate & ", Pod3 = '" & cCombo37 & "'"
            strUpdate = strUpdate & ", ObPod = '" & TextBox11.Text & "'"
            strUpdate = strUpdate & " WHERE Cliente = '" & txtPassword.Text & "'"
            cnAgil.Open()
            cm1 = New SqlCommand(strUpdate, cnAgil)
            cm1.ExecuteNonQuery()
            cnAgil.Close()

            MsgBox("Actualización correcta", MsgBoxStyle.Information, "Mensaje de Sistema")

        End If
        btnSave.Enabled = False
        cnAgil = Nothing

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim daCliente As New SqlDataAdapter(cm3)
        Dim daDocumento As New SqlDataAdapter(cm4)
        Dim dsAgil As New DataSet()
        Dim drCliente As DataRow
        Dim drDatos As DataRow

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

        oRuta = "F:\Hoja_CEF.doc"

        With cm3
            .CommandType = CommandType.Text
            .CommandText = "SELECT Descr FROM Clientes WHERE Cliente = " & "'" & txtPassword.Text & "'"
            .Connection = cnAgil
        End With
        daCliente.Fill(dsAgil, "Name")
        drCliente = dsAgil.Tables("Name").Rows(0)

        With cm4
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM CtrlEF WHERE Cliente = " & "'" & txtPassword.Text & "'"
            .Connection = cnAgil
        End With
        daDocumento.Fill(dsAgil, "Datos")
        drDatos = dsAgil.Tables("Datos").Rows(0)

        oWord = New Microsoft.Office.Interop.Word.Application()
        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantilla

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo únicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quitándole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable

                Select Case cfName

                    Case "mDescr"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(drCliente("Descr"))
                    Case "mFechaEF"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(drDatos("FechaEF"))
                    Case "mEjercicio"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Ejercicio")
                    Case "mI1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Ine1")
                    Case "mI2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Ine2")
                    Case "mI3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Ine3")
                    Case "mP1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Pas1")
                    Case "mP2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Pas2")
                    Case "mP3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Pas3")
                    Case "mC1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Cep1")
                    Case "mC2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Cep2")
                    Case "mC3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = drDatos("Cep3")
                    Case "mObser1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("ObIof")
                    Case "mU1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Curp1")
                    Case "mU2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Curp2")
                    Case "mU3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Curp3")
                    Case "mObser2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("ObCurp")
                    Case "mF1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Fiel1")
                    Case "mF2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Fiel2")
                    Case "mF3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Fiel3")
                    Case "mObser3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("ObFiel")
                    Case "mR1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Rfc1")
                    Case "mR2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Rfc2")
                    Case "mR3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Rfc3")
                    Case "mObser4"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("ObRfc")
                    Case "mE1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Cif1")
                    Case "mE2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Cif2")
                    Case "mE3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Cif3")
                    Case "mObser5"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("ObCif")
                    Case "mA1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Anac1")
                    Case "mA2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Anac2")
                    Case "mA3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Anac3")
                    Case "mObser6"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("ObAnac")
                    Case "mO1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Amat1")
                    Case "mO2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Amat2")
                    Case "mO3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Amat3")
                    Case "mObser7"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("ObAmat")
                    Case "mB1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Cdom1")
                    Case "mB2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Cdom2")
                    Case "mB3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Cdom3")
                    Case "mObser8"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("ObCdom")
                    Case "mD1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Acon1")
                    Case "mD2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Acon2")
                    Case "mD3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Acon3")
                    Case "mObser9"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("ObAcon")
                    Case "mM1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Mac1")
                    Case "mM2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Mac2")
                    Case "mM3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Mac3")
                    Case "mObser10"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("ObMac")
                    Case "mG1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Pod1")
                    Case "mG2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Pod2")
                    Case "mG3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("Pod3")
                    Case "mObser11"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = drDatos("ObPod")
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
        Dim oMissing = System.Reflection.Missing.Value

        oWord.ActiveDocument.Select()
        oWord.WordBasic.ToString()
        oWord.Visible = True

        Dim oSaveAsFile = "C:\contratos\CEF_" & Trim(drCliente("Descr")) & ".doc"

        oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class