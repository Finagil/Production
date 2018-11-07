Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports System.Text.ASCIIEncoding

Public Class frmEmpleador
    Inherits System.Windows.Forms.Form
    Public Sub New(ByVal cCliente As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtPassword.Text = cCliente

    End Sub

    Dim cCodigoEdo As String
    Dim cCodigoMoneda As String
    Dim cCodigoPP As String
    Dim cEmpleador As String
    Dim cCliente As String
    Dim cFechaCto As String
    Dim cFechaUEmp As String
    Dim cFechaURev As String
    Dim cTipoEmp As String

    Private Sub frmEmpleador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daEmple As New SqlDataAdapter(cm1)
        Dim daPF As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()
        Dim drEmple As DataRow
        Dim drPF As DataRow

        cCliente = txtPassword.Text

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT Tipo FROM Clientes WHERE Cliente = " & cCliente
            .Connection = cnAgil
        End With
        daPF.Fill(dsAgil, "Fisica")
        drPF = dsAgil.Tables("Fisica").Rows(0)

        If drPF("Tipo") = "M" Then
            MsgBox("En Personas MORALES NO se requieren estos Datos", MsgBoxStyle.Information, "Validación de Sistema")
            Me.Close()
        ElseIf drPF("Tipo") = "F" Or drPF("Tipo") = "E" Then

            ' Declaración de variables de datos

            Dim nCount As Integer

            ' Con esta consulta obtengo los datos del Empleador del Cliente si es que existen

            With cm1
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM Empleadores WHERE Cliente = " & cCliente
                .Connection = cnAgil
            End With
            daEmple.Fill(dsAgil, "DatosEmp")
            nCount = dsAgil.Tables("DatosEmp").Rows.Count

            If nCount = 0 Then
                txtComo.Text = "I"
            Else
                txtComo.Text = "U"

                drEmple = dsAgil.Tables("DatosEmp").Rows(0)

                cTipoEmp = drEmple("TipoEmp")
                cEmpleador = drEmple("PE_Empleador")
                If cTipoEmp = "E" Then
                    rbSI.Checked = True
                    txtEmpresa.Text = cEmpleador
                ElseIf cTipoEmp = "O" Then
                    rbNO.Checked = True
                    txtEmpresa.Visible = False
                    cbSinEmpleador.Visible = True
                    Select Case Trim(cEmpleador)
                        Case "TRABAJADOR INDEPENDIENTE"
                            cbSinEmpleador.SelectedIndex = 0
                        Case "ESTUDIANTE"
                            cbSinEmpleador.SelectedIndex = 1
                        Case "LABORES DEL HOGAR"
                            cbSinEmpleador.SelectedIndex = 2
                        Case "JUBILADO"
                            cbSinEmpleador.SelectedIndex = 3
                        Case "DESEMPLEADO"
                            cbSinEmpleador.SelectedIndex = 4
                        Case "EXEMPLEADO"
                            cbSinEmpleador.SelectedIndex = 5
                    End Select

                End If
                TextCAlle1.Text = drEmple("PE_Calle1")
                Textcalle2.Text = drEmple("PE_Calle2")
                Textcol.Text = drEmple("PE_Colonia")
                TextDelegacion.Text = drEmple("PE_Delegacion")
                TextCiudad.Text = drEmple("PE_Ciudad")
                cCodigoEdo = Trim(drEmple("PE_Estado"))
                Codigo(cCodigoEdo)
                Textcp.Text = drEmple("PE_Copos")
                Texttel.Text = drEmple("PE_NumTelef")
                TextExte.Text = drEmple("PE_ExtTelef")
                TextFax.Text = drEmple("PE_NumFax")
                TextBox11.Text = drEmple("PE_Cargo")
                cFechaCto = drEmple("PE_FechaCto")
                DateTimePicker1.Value = CTOD(cFechaCto)
                cCodigoMoneda = Trim(drEmple("PE_Monedapag"))
                Select Case cCodigoMoneda
                    Case "US"
                        ComboBox2.SelectedIndex = 0
                    Case "MX"
                        ComboBox2.SelectedIndex = 1
                End Select
                TextBox12.Text = drEmple("PE_Mtopago")
                cCodigoPP = drEmple("PE_Ppago")
                Select Case cCodigoPP
                    Case "B"
                        ComboBox3.SelectedIndex = 0
                    Case "D"
                        ComboBox3.SelectedIndex = 1
                    Case "H"
                        ComboBox3.SelectedIndex = 2
                    Case "K"
                        ComboBox3.SelectedIndex = 3
                    Case "M"
                        ComboBox3.SelectedIndex = 4
                    Case "S"
                        ComboBox3.SelectedIndex = 5
                    Case "W"
                        ComboBox3.SelectedIndex = 5
                    Case "Y"
                        ComboBox3.SelectedIndex = 6
                End Select
                TextBox13.Text = drEmple("PE_NumEmpleado")
                cFechaUEmp = drEmple("PE_FUVTE")
                DateTimePicker2.Value = CTOD(cFechaUEmp)
                cFechaURev = drEmple("PE_FUVDE")
                DateTimePicker3.Value = CTOD(cFechaURev)
            End If

        End If

    End Sub

    Private Sub rbSI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSI.CheckedChanged
        txtEmpresa.Visible = True
        GroupBox1.Text = "DATOS DOMICILIO DEL EMPLEADOR"
        cTipoEmp = "E"
        cbSinEmpleador.Visible = False
        Btnempl.Enabled = True
    End Sub

    Private Sub rbNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNO.CheckedChanged
        cbSinEmpleador.Visible = True
        cbSinEmpleador.ResetText()
        txtEmpresa.Visible = False
        cTipoEmp = "O"
        GroupBox1.Text = "DATOS DOMICILIO DEL CLIENTE"
        Btnempl.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboEstado.SelectedIndexChanged
        Select Case ComboEstado.SelectedIndex
            Case 0
                cCodigoEdo = "AGS"
            Case 1
                cCodigoEdo = "BCN"
            Case 2
                cCodigoEdo = "BCS"
            Case 3
                cCodigoEdo = "CAM"
            Case 4
                cCodigoEdo = "CHS"
            Case 5
                cCodigoEdo = "CHI"
            Case 6
                cCodigoEdo = "COA"
            Case 7
                cCodigoEdo = "COL"
            Case 8
                cCodigoEdo = "DF"
            Case 9
                cCodigoEdo = "DGO"
            Case 10
                cCodigoEdo = "EM"
            Case 11
                cCodigoEdo = "GTO"
            Case 12
                cCodigoEdo = "GRO"
            Case 13
                cCodigoEdo = "HGO"
            Case 14
                cCodigoEdo = "JAL"
            Case 15
                cCodigoEdo = "MICH"
            Case 16
                cCodigoEdo = "MOR"
            Case 17
                cCodigoEdo = "NAY"
            Case 18
                cCodigoEdo = "NL"
            Case 19
                cCodigoEdo = "OAX"
            Case 20
                cCodigoEdo = "PUE"
            Case 21
                cCodigoEdo = "QRO"
            Case 22
                cCodigoEdo = "QR"
            Case 23
                cCodigoEdo = "SLP"
            Case 24
                cCodigoEdo = "SIN"
            Case 25
                cCodigoEdo = "SON"
            Case 26
                cCodigoEdo = "TAB"
            Case 27
                cCodigoEdo = "TAM"
            Case 28
                cCodigoEdo = "TLA"
            Case 29
                cCodigoEdo = "VER"
            Case 30
                cCodigoEdo = "YUC"
            Case 31
                cCodigoEdo = "ZAC"
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.SelectedIndex
            Case 0
                cCodigoMoneda = "US"
            Case 1
                cCodigoMoneda = "MX"
        End Select
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Select Case ComboBox3.SelectedIndex
            Case 0
                cCodigoPP = "B"
            Case 1
                cCodigoPP = "D"
            Case 2
                cCodigoPP = "H"
            Case 3
                cCodigoPP = "K"
            Case 4
                cCodigoPP = "M"
            Case 5
                cCodigoPP = "S"
            Case 6
                cCodigoPP = "W"
            Case 7
                cCodigoPP = "Y"
        End Select
    End Sub

    Private Sub cbSinEmpleador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSinEmpleador.SelectedIndexChanged
        Select Case cbSinEmpleador.SelectedIndex
            Case 0
                cEmpleador = "TRABAJADOR INDEPENDIENTE"
            Case 1
                cEmpleador = "ESTUDIANTE"
            Case 2
                cEmpleador = "LABORES DEL HOGAR"
            Case 3
                cEmpleador = "JUBILADO"
            Case 4
                cEmpleador = "DESEMPLEADO"
            Case 5
                cEmpleador = "EXEMPLEADO"
        End Select
    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub bSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSave.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim strInsert As String
        Dim strUpdate As String

        Dim lCorrecto As Boolean

        cFechaCto = DTOC(DateTimePicker1.Value)
        cFechaUEmp = DTOC(DateTimePicker2.Value)
        cFechaURev = DTOC(DateTimePicker3.Value)
        lCorrecto = True

        If Len(Trim(cEmpleador)) < 5 Then
            lCorrecto = False
            MsgBox("Es NECESARIO proporcipnar correctamente este dato", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If Len(Trim(TextCAlle1.Text)) < 5 Then
            lCorrecto = False
            MsgBox("Debes proporcionar CALLE y NUMERO de Empleador", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If Len(Trim(Textcol.Text)) < 5 Then
            lCorrecto = False
            MsgBox("Debes proporcionar COLONIA o POBLACION del Empleador", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If Len(Trim(TextDelegacion.Text)) < 5 Then
            lCorrecto = False
            MsgBox("Debes proporcionar DELEGACION o MUNICIPIO del Empleador", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If Len(Trim(TextCiudad.Text)) < 5 Then
            lCorrecto = False
            MsgBox("Debes proporcionar CIUDAD del Empleador", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If Trim(cCodigoEdo) = "" Then
            lCorrecto = False
            MsgBox("Debes SELECCIONAR el ESTADO en que radica el Empleador", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If Len(Trim(Textcp.Text)) < 5 Then
            lCorrecto = False
            MsgBox("Debes proporcionar el CODIGO POSTAL del Empleador", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If lCorrecto = True Then

            If Trim(Textcalle2.Text) = "" Then
                Textcalle2.Text = " "
            End If

            If Trim(Texttel.Text) = "" Then
                Texttel.Text = " "
            End If

            If Trim(TextExte.Text) = "" Then
                TextExte.Text = " "
            End If

            If Trim(TextFax.Text) = "" Then
                TextFax.Text = " "
            End If

            If Trim(TextBox11.Text) = "" Then
                TextBox11.Text = " "
                cFechaCto = " "
                cCodigoMoneda = " "
                cCodigoPP = " "
                cFechaUEmp = " "
                cFechaURev = " "
            End If

            If Trim(TextBox12.Text) = "" Then
                TextBox12.Text = 0
            End If

            If Trim(TextBox13.Text) = "" Then
                TextBox13.Text = " "
            End If

            If txtComo.Text = "I" Then
                cnAgil.Open()
                strInsert = "INSERT INTO Empleadores(Cliente, PE_Empleador, PE_Calle1, PE_Calle2, PE_Colonia, PE_Delegacion, PE_Ciudad, PE_Estado, PE_Copos, PE_NumTelef, PE_ExtTelef, PE_NumFax, PE_Cargo, PE_FechaCto, PE_Monedapag, PE_Mtopago, PE_Ppago, PE_NumEmpleado, PE_FUVTE, PE_FUVDE, TipoEmp)"
                strInsert = strInsert & " VALUES ('" & cCliente & "', '" & cEmpleador & "', '" & TextCAlle1.Text & "','" & Textcalle2.Text & "', '" & Textcol.Text & "', '" & TextDelegacion.Text & "', '" & TextCiudad.Text & "', '" & cCodigoEdo & "', '" & Textcp.Text & "', '" & Texttel.Text & "',  '"
                strInsert = strInsert & TextExte.Text & "', '" & TextFax.Text & "','" & TextBox11.Text & "', '" & cFechaCto & "', '" & cCodigoMoneda & "', '" & TextBox12.Text & "', '" & cCodigoPP & "','" & TextBox13.Text & "','" & cFechaUEmp & "','" & cFechaURev & "','" & cTipoEmp & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
                cnAgil.Close()
            Else
                strUpdate = "UPDATE Empleadores SET PE_Empleador = '" & cEmpleador & "'"
                strUpdate = strUpdate & ", PE_Calle1 = '" & TextCAlle1.Text & "'"
                strUpdate = strUpdate & ", PE_Calle2 = '" & Textcalle2.Text & "'"
                strUpdate = strUpdate & ", PE_Colonia = '" & Textcol.Text & "'"
                strUpdate = strUpdate & ", PE_Delegacion = '" & TextDelegacion.Text & "'"
                strUpdate = strUpdate & ", PE_Ciudad = '" & TextCiudad.Text & "'"
                strUpdate = strUpdate & ", PE_Estado = '" & cCodigoEdo & "'"
                strUpdate = strUpdate & ", PE_Copos = '" & Textcp.Text & "'"
                strUpdate = strUpdate & ", PE_NumTelef = '" & Texttel.Text & "'"
                strUpdate = strUpdate & ", PE_ExtTelef = '" & TextExte.Text & "'"
                strUpdate = strUpdate & ", PE_NumFax = '" & TextFax.Text & "'"
                strUpdate = strUpdate & ", PE_Cargo = '" & TextBox11.Text & "'"
                strUpdate = strUpdate & ", PE_FechaCto = '" & cFechaCto & "'"
                strUpdate = strUpdate & ", PE_Monedapag = '" & cCodigoMoneda & "'"
                strUpdate = strUpdate & ", PE_Mtopago = '" & TextBox12.Text & "'"
                strUpdate = strUpdate & ", PE_Ppago = '" & cCodigoPP & "'"
                strUpdate = strUpdate & ", PE_NumEmpleado = '" & TextBox13.Text & "'"
                strUpdate = strUpdate & ", PE_FUVTE = '" & cFechaUEmp & "'"
                strUpdate = strUpdate & ", PE_FUVDE = '" & cFechaURev & "'"
                strUpdate = strUpdate & ", TipoEmp = '" & cTipoEmp & "'"
                strUpdate = strUpdate & " WHERE Cliente = '" & cCliente & "'"
                cnAgil.Open()
                cm1 = New SqlCommand(strUpdate, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            MsgBox("Datos Actualizados Correctamente", MsgBoxStyle.Information, "Mensaje del Sistema")

        End If

    End Sub


    Private Sub txtEmpresa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpresa.TextChanged
        cEmpleador = txtEmpresa.Text
    End Sub

    Private Sub Btnempl_Click(sender As Object, e As EventArgs) Handles Btnempl.Click
        Dim f As New FrmEmpleadores
        If f.ShowDialog = DialogResult.OK Then
            txtEmpresa.Text = f.GENEmpleadoresBindingSource.Current("Empleador")
            TextCAlle1.Text = f.GENEmpleadoresBindingSource.Current("calle1")
            Textcalle2.Text = f.GENEmpleadoresBindingSource.Current("calle2")
            Textcol.Text = f.GENEmpleadoresBindingSource.Current("colonia")
            TextDelegacion.Text = f.GENEmpleadoresBindingSource.Current("delegacion")
            TextCiudad.Text = f.GENEmpleadoresBindingSource.Current("ciudad")
            cCodigoEdo = f.GENEmpleadoresBindingSource.Current("Estado")
            Codigo(cCodigoEdo)
            Textcp.Text = f.GENEmpleadoresBindingSource.Current("copos")
            Texttel.Text = f.GENEmpleadoresBindingSource.Current("Numtelef")
            TextExte.Text = f.GENEmpleadoresBindingSource.Current("Exttelef")
            TextFax.Text = f.GENEmpleadoresBindingSource.Current("Numfax")
        End If
    End Sub

    Sub Codigo(Cod As String)
        Select Case Cod
            Case "AGS"
                ComboEstado.SelectedIndex = 0
            Case "BCN"
                ComboEstado.SelectedIndex = 1
            Case "BCS"
                ComboEstado.SelectedIndex = 2
            Case "CAM"
                ComboEstado.SelectedIndex = 3
            Case "CHS"
                ComboEstado.SelectedIndex = 4
            Case "CHI"
                ComboEstado.SelectedIndex = 5
            Case "COA"
                ComboEstado.SelectedIndex = 6
            Case "COL"
                ComboEstado.SelectedIndex = 7
            Case "DF"
                ComboEstado.SelectedIndex = 8
            Case "DGO"
                ComboEstado.SelectedIndex = 9
            Case "EM"
                ComboEstado.SelectedIndex = 10
            Case "GTO"
                ComboEstado.SelectedIndex = 11
            Case "GRO"
                ComboEstado.SelectedIndex = 12
            Case "HGO"
                ComboEstado.SelectedIndex = 13
            Case "JAL"
                ComboEstado.SelectedIndex = 14
            Case "MICH"
                ComboEstado.SelectedIndex = 15
            Case "MOR"
                ComboEstado.SelectedIndex = 16
            Case "NAY"
                ComboEstado.SelectedIndex = 17
            Case "NL"
                ComboEstado.SelectedIndex = 18
            Case "OAX"
                ComboEstado.SelectedIndex = 19
            Case "PUE"
                ComboEstado.SelectedIndex = 20
            Case "QRO"
                ComboEstado.SelectedIndex = 21
            Case "QR"
                ComboEstado.SelectedIndex = 22
            Case "SLP"
                ComboEstado.SelectedIndex = 23
            Case "SIN"
                ComboEstado.SelectedIndex = 24
            Case "SON"
                ComboEstado.SelectedIndex = 25
            Case "TAB"
                ComboEstado.SelectedIndex = 26
            Case "TAM"
                ComboEstado.SelectedIndex = 27
            Case "TLA"
                ComboEstado.SelectedIndex = 28
            Case "VER"
                ComboEstado.SelectedIndex = 29
            Case "YUC"
                ComboEstado.SelectedIndex = 30
            Case "ZAC"
                ComboEstado.SelectedIndex = 31
        End Select
    End Sub
End Class
