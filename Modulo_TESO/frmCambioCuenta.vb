Option Explicit On

Imports System.Data.SqlClient
Public Class frmCambioCuenta
    ' Declaración de variables de alcance privado

    Dim cProductor As String = ""
    Dim lFirstTime As Boolean = True

    Private Sub frmCambioCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daClientes As New SqlDataAdapter(cm1)
        Dim cm2 As New SqlCommand()
        Dim daBancos As New SqlDataAdapter(cm2)
        Dim dsBco As New DataSet()

        Dim dsAgil As New DataSet()

        Me.Text = "Selección de Cliente de Avío para Cambio de Cuenta"
        
        ' Este Stored Procedure trae los clientes que pertenezcan a la Sucursal de NAVOJOA, MEXICALI e IRAPUATO

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "ContClie2"
            .Connection = cnAgil
        End With

        cbProductores.MaxDropDownItems = 15

        ' Este Stored Procedure regresa los datos de los Bancos

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Bancos1"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daBancos.Fill(dsBco, "Bancos")

        ' Lleno cbBancos con el nombre de los Bancos

        cbBanco.DataSource = dsBco
        cbBanco.DisplayMember = "Bancos.DescBanco"
        cbBanco.ValueMember = "Bancos.Banco"
        cbBanco.Visible = True
        cbBanco.SelectedIndex = 0

        Try

            ' Llenar el DataSet

            daClientes.Fill(dsAgil, "Clientes")

            ' Ligar la tabla Clientes del dataset dsAgil al ComboBox

            cbProductores.DataSource = dsAgil
            cbProductores.DisplayMember = "Clientes.Descr"
            cbProductores.ValueMember = "Clientes.Cliente"
            lFirstTime = False

        Catch eException As Exception

            MsgBox(eException.Source & " " & eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub cbProductores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProductores.SelectedIndexChanged

        ' Declaración de variables de conexíón ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daCuentas As New SqlDataAdapter(cm1)
     
        Dim dsAgil As New DataSet()
        Dim drCuenta As DataRow

        ' Declaración de variables de datos

        Dim cBanco As String = ""
        Dim cCuentaBmer As String = ""
        Dim cCtaCLABE As String = ""
       
        If Not cbProductores.SelectedValue Is Nothing And lFirstTime = False Then

            cProductor = cbProductores.SelectedValue.ToString()

            ' El siguiente Command trae los contratos del Productor seleccionado

            With cm1
                .CommandType = CommandType.Text
                .CommandText = "SELECT Banco, CuentaBancomer, CuentaCLABE FROM Clientes " & _
                               "WHERE Cliente = " & cProductor
                .Connection = cnAgil
            End With

            ' Llenar el DataSet lo cual abre y cierra la conexión

            daCuentas.Fill(dsAgil, "Cuentas")

            ' Ya que se escogió un productor del listado, se llama a la forma frmAgricola mandándole
            ' como parámetro el número del productor seleccionado el cual coincide con el del contrato
            drCuenta = dsAgil.Tables("Cuentas").Rows(0)
       
            cBanco = drCuenta("Banco")
            cCuentaBmer = drCuenta("CuentaBancomer")
            cCtaCLABE = drCuenta("CuentaCLABE")
            txtBanco.Text = cBanco
            If Trim(cBanco) = "BANCOMER" Then
                txtCuenta.Text = cCuentaBmer
                txtCClabe.Text = cCtaCLABE
            Else
                txtCuenta.Text = cCtaCLABE
                txtCtaClabeBmer.Text = ""
            End If

        End If

    End Sub

    Private Sub cbBanco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBanco.SelectedIndexChanged

        If cbBanco.SelectedIndex = 0 Then
            Label3.Text = "Cuenta BANCOMER"
            txtCuentaNva.MaxLength = 10
            txtCuentaNva.Text = txtCuenta.Text
            Label4.Text = "Cuenta CLABE BANCOMER"
            Label4.Visible = True
            txtCtaClabeBmer.Visible = True
            txtCtaClabeBmer.MaxLength = 18
        Else
            Label3.Text = "Dame la Cuenta CLABE"
            txtCuentaNva.MaxLength = 18
            Label4.Visible = False
            txtCtaClabeBmer.Visible = False
        End If
        Label3.Visible = True
        btnSave.Visible = True
        txtCuentaNva.Visible = True

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Val(txtCuentaNva.Text) = 0 Then

            MsgBox("NO se ha capturado la CUENTA", MsgBoxStyle.Information, "Mensaje")

        Else

            Dim cnAgil As New SqlConnection(strConn)
            Dim cm1 As New SqlCommand()

            Dim strUpdate As String
            Dim cBanco1 As String

            cBanco1 = RTrim(cbBanco.Text)
     
            cnAgil.Open()

            If cBanco1 = "BANCOMER" Then

                strUpdate = "UPDATE Clientes SET CuentaBancomer = '" & txtCuentaNva.Text & "'"
                strUpdate = strUpdate & ", Banco = '" & cBanco1 & "'"
                strUpdate = strUpdate & ", CuentaCLABE = '" & txtCtaClabeBmer.Text & "'"
                strUpdate = strUpdate & " WHERE Cliente = '" & cProductor & "'"
                cm1 = New SqlCommand(strUpdate, cnAgil)
                cm1.ExecuteNonQuery()
            Else
                strUpdate = "UPDATE Clientes SET CuentaBancomer = '" & " " & "'"
                strUpdate = strUpdate & ", Banco = '" & cBanco1 & "'"
                strUpdate = strUpdate & ", CuentaCLABE = '" & txtCuentaNva.Text & "'"
                strUpdate = strUpdate & " WHERE Cliente = '" & cProductor & "'"
                cm1 = New SqlCommand(strUpdate, cnAgil)
                cm1.ExecuteNonQuery()

            End If

            Label3.Visible = False
            btnSave.Visible = False
            txtCuentaNva.Text = ""
            txtCuentaNva.Visible = False
            cbBanco.Visible = False
            Label4.Visible = False
            txtCtaClabeBmer.Visible = False
            cnAgil.Close()
            cnAgil = Nothing

        End If

    End Sub

End Class