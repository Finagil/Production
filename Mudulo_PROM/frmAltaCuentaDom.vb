Option Explicit On

Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Security
Imports System.Security.Principal.WindowsIdentity

Public Class frmAltaCuentaDom
    'Public Sub New()
    Public Sub New(ByVal cAnexo As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtAnexo.Text = cAnexo
        Me.Text = "Captura de Cuentas para Pago Domiciliado por Contrato"
    End Sub
    Dim cAnexo As String
    Dim cSolicitud As String
    Dim cDisposicion As String

    Private Sub frmAltaCuentaDom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daContratos As New SqlDataAdapter(cm1)
        Dim daCliente As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()
        Dim drCte As DataRow
        Dim drName As DataRow
        Dim cName As String
        Dim nCount As Integer
        Dim nCount1 As Integer

        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 6, 4)
        cSolicitud = Mid(txtAnexo.Text, 10, 6)
        cDisposicion = Mid(txtAnexo.Text, 7, 3)

        ' Este Stored Procedure trae TODOS los clientes que existan en la tabla Clientes sin importar 
        ' si tienen o no contratos o solicitudes generadas

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Descr, Detsol.AceptaDomi FROM Detsol INNER JOIN Clientes ON DetSol.Cliente = Clientes.Cliente WHERE Solicitud = " & "'" & cSolicitud & "'" & " AND Disposicion = " & "'" & cDisposicion & "'"
            .Connection = cnAgil
        End With
        daContratos.Fill(dsAgil, "Nombre")
        drName = dsAgil.Tables("Nombre").Rows(0)
        cName = drName("Descr")
        txtTitular.Text = cName

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM CuentasDomi WHERE Solicitud = " & "'" & cSolicitud & "'" & " AND Disposicion = " & "'" & cDisposicion & "'"
            .Connection = cnAgil
        End With
        daCliente.Fill(dsAgil, "Solicitud")
        nCount1 = dsAgil.Tables("Solicitud").Rows.Count
        If dsAgil.Tables("Solicitud").Rows.Count <= 0 Then
            cm1 = New SqlCommand("INSERT INTO CuentasDomi(Anexo, CuentaCLABE, NumTarjeta, CuentaEje, Banco, DescPago, TitularCta, Solicitud, Disposicion,usuario) 
                                VALUES ('', '', '', '', '', '', '', '" & cSolicitud & "', '" & cDisposicion & "','" & UsuarioGlobal & "')", cnAgil)
            cnAgil.Open()
            cm1.ExecuteNonQuery()
            cnAgil.Close()
            daCliente.Fill(dsAgil, "Solicitud")
            nCount1 = dsAgil.Tables("Solicitud").Rows.Count
        End If

        If nCount1 > 0 Then
            drCte = dsAgil.Tables("Solicitud").Rows(0)
            ComboBox1.Text = Trim(drCte("Banco"))
            ComboBox2.Text = Trim(drCte("DescPago"))
            btnUpdate.Enabled = False
            btnModif.Enabled = True
            txtCtaCLABE.Text = drCte("CuentaCLABE")
            txtCuentaD.Text = drCte("NumTarjeta")
            txtCuentaE.Text = drCte("CuentaEJE")
        Else
            btnUpdate.Enabled = True
            btnModif.Enabled = False
        End If
        If ComboBox1.Text = "BANCOMER" Then
            txtCtaCLABE.Enabled = True
            txtCuentaD.Enabled = True
        Else
            txtCtaCLABE.Enabled = True
            txtCuentaD.Enabled = False
        End If
        txtCuentaE.Enabled = False

    End Sub

    Private Sub txtCtaCLABE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtaCLABE.Click
        txtCuentaD.Enabled = False
        txtCuentaE.Enabled = False
    End Sub

    Private Sub txtCuentaD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuentaD.Click
        txtCtaCLABE.Enabled = False
        txtCuentaE.Enabled = False
    End Sub

    Private Sub txtCuentaE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuentaE.Click
        txtCtaCLABE.Enabled = False
        txtCuentaD.Enabled = False
    End Sub

    Private Sub btnModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModif.Click
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim strUpdate As String

        ' Declaración de variables de datos

        Dim cConcepto As String
        Dim cBanco As String
        Dim lPasa1 As Boolean

        lPasa1 = False
        cBanco = ComboBox1.SelectedItem
        cConcepto = ComboBox2.SelectedItem

        If Trim(txtCtaCLABE.Text) = "" And Trim(txtCuentaD.Text) = "" And Trim(txtCuentaE.Text) = "" Then
            MsgBox("Falta capturar los datos de la Cuenta", MsgBoxStyle.Critical, "Mensaje de Error")
            Me.Close()
        ElseIf Trim(txtCtaCLABE.Text) <> "" And Len(Trim(txtCtaCLABE.Text)) < 18 Or Len(Trim(txtCtaCLABE.Text)) > 18 Then
            MsgBox("La Cuenta CLABE debe tener 18 digitos", MsgBoxStyle.Critical, "Mensaje de Error")
            Me.Close()
        ElseIf Trim(txtCuentaD.Text) <> "" And Len(Trim(txtCuentaD.Text)) < 16 Or Len(Trim(txtCuentaD.Text)) > 16 Then
            MsgBox("La Cuenta de la Tarjeta debe tener 16 digitos", MsgBoxStyle.Critical, "Mensaje de Error")
            Me.Close()
        ElseIf Trim(txtCuentaE.Text) <> "" And Len(Trim(txtCuentaE.Text)) < 10 Or Len(Trim(txtCuentaE.Text)) > 10 Then
            MsgBox("La Cuenta EJE debe tener 10 digitos", MsgBoxStyle.Critical, "Mensaje de Error")
            Me.Close()
        ElseIf Trim(cBanco) = "" And Trim(cConcepto) = "" Then
            MsgBox("Falta seleccionar el Banco o el Concepto", MsgBoxStyle.Critical, "Mensaje de Error")
            Me.Close()
        Else
            lPasa1 = True
        End If

        If lPasa1 = True Then

            strUpdate = "UPDATE CuentasDomi SET CuentaCLABE = '" & txtCtaCLABE.Text & "'"
            strUpdate = strUpdate & ", NumTarjeta = '" & txtCuentaD.Text & "'"
            strUpdate = strUpdate & ", CuentaEJE = '" & txtCuentaE.Text & "'"
            strUpdate = strUpdate & ", Anexo = '" & cAnexo & "'"
            strUpdate = strUpdate & ", DescPago = '" & ComboBox2.Text & "'"
            strUpdate = strUpdate & ", Titularcta = '" & txtTitular.Text & "'"
            strUpdate = strUpdate & ", Banco = '" & cBanco & "'"
            strUpdate = strUpdate & ", usuario = '" & UsuarioGlobal & "'"
            strUpdate = strUpdate & " WHERE Solicitud = '" & cSolicitud & "'" & " AND Disposicion = '" & cDisposicion & "'"
            Try
                cnAgil.Open()
                cm1 = New SqlCommand(strUpdate, cnAgil)
                cm1.ExecuteNonQuery()
                cnAgil.Close()
                cnAgil = Nothing
                MsgBox("DATOS DE CUENTA ACTUALIZADOS CORRECTAMENTE", MsgBoxStyle.Information)
                Me.Close()
            Catch eException As Exception
                MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje")
            End Try
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text.Trim = "BANCOMER" Then
            txtCtaCLABE.Enabled = True
            txtCuentaD.Enabled = True
        Else
            txtCtaCLABE.Enabled = True
            txtCuentaD.Enabled = False
        End If
        txtCuentaD.Text = ""
        txtCuentaE.Text = ""
    End Sub

End Class