Option Explicit On 

Imports System.Data.SqlClient

Public Class frmPrendaria
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal cAnexo As String, ByVal Descr As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtAnexo.Text = cAnexo
        txtCusnam.Text = Descr
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtCusnam As System.Windows.Forms.TextBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblContrato As System.Windows.Forms.Label
    Friend WithEvents lblGarantia As System.Windows.Forms.Label
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents btnCambios As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSEG As Button
    Friend WithEvents txtGarantia As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCusnam = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblContrato = New System.Windows.Forms.Label()
        Me.lblGarantia = New System.Windows.Forms.Label()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnCambios = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtAnexo = New System.Windows.Forms.TextBox()
        Me.txtGarantia = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.ButtonSEG = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCusnam
        '
        Me.txtCusnam.Location = New System.Drawing.Point(80, 8)
        Me.txtCusnam.Name = "txtCusnam"
        Me.txtCusnam.ReadOnly = True
        Me.txtCusnam.Size = New System.Drawing.Size(536, 20)
        Me.txtCusnam.TabIndex = 0
        Me.txtCusnam.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(16, 16)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(56, 16)
        Me.lblCliente.TabIndex = 7
        Me.lblCliente.Text = "Cliente"
        '
        'lblContrato
        '
        Me.lblContrato.Location = New System.Drawing.Point(16, 48)
        Me.lblContrato.Name = "lblContrato"
        Me.lblContrato.Size = New System.Drawing.Size(48, 16)
        Me.lblContrato.TabIndex = 8
        Me.lblContrato.Text = "Contrato"
        '
        'lblGarantia
        '
        Me.lblGarantia.Location = New System.Drawing.Point(16, 80)
        Me.lblGarantia.Name = "lblGarantia"
        Me.lblGarantia.Size = New System.Drawing.Size(152, 16)
        Me.lblGarantia.TabIndex = 9
        Me.lblGarantia.Text = "Descripci�n la(s) Garant�a(s)"
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(24, 248)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(80, 24)
        Me.btnAlta.TabIndex = 10
        Me.btnAlta.Text = "Salvar"
        '
        'btnCambios
        '
        Me.btnCambios.Location = New System.Drawing.Point(141, 248)
        Me.btnCambios.Name = "btnCambios"
        Me.btnCambios.Size = New System.Drawing.Size(80, 24)
        Me.btnCambios.TabIndex = 11
        Me.btnCambios.Text = "Modificar"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(263, 248)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 24)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        '
        'txtAnexo
        '
        Me.txtAnexo.Location = New System.Drawing.Point(80, 40)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.ReadOnly = True
        Me.txtAnexo.Size = New System.Drawing.Size(80, 20)
        Me.txtAnexo.TabIndex = 13
        Me.txtAnexo.TabStop = False
        '
        'txtGarantia
        '
        Me.txtGarantia.AcceptsTab = True
        Me.txtGarantia.Location = New System.Drawing.Point(16, 104)
        Me.txtGarantia.Name = "txtGarantia"
        Me.txtGarantia.Size = New System.Drawing.Size(600, 129)
        Me.txtGarantia.TabIndex = 1
        Me.txtGarantia.TabStop = False
        Me.txtGarantia.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(385, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Valor de la(s) Garant�a(s)"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(513, 75)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 15
        '
        'ButtonSEG
        '
        Me.ButtonSEG.Location = New System.Drawing.Point(513, 248)
        Me.ButtonSEG.Name = "ButtonSEG"
        Me.ButtonSEG.Size = New System.Drawing.Size(100, 24)
        Me.ButtonSEG.TabIndex = 16
        Me.ButtonSEG.Text = "Alta para SEG"
        '
        'frmPrendaria
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(632, 286)
        Me.Controls.Add(Me.ButtonSEG)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGarantia)
        Me.Controls.Add(Me.txtAnexo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCambios)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.lblGarantia)
        Me.Controls.Add(Me.lblContrato)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtCusnam)
        Me.Name = "frmPrendaria"
        Me.Text = "Datos Grarant�a Prendaria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim cAnexo As String

    Private Sub frmPrendaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As SqlConnection = New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim dsAgil As DataSet = New DataSet()
        Dim daAnexos As New SqlDataAdapter(cm1)
        Dim daPrenda As New SqlDataAdapter(cm2)
        Dim drPrenda As DataRow
        Dim drPrendas As DataRowCollection
        Dim drAnexo As DataRow
        Dim drAnexos As DataRowCollection

        ' Declaraci�n de variables de datos

        Dim cPrenda As String = "S"

        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 10)

        ' Este Stored Procedure trae los datos del contrato seleccionado

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Datoscon1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
        End With

        daAnexos.Fill(dsAgil, "Anexos")
        drAnexos = dsAgil.Tables("Anexos").Rows
        For Each drAnexo In drAnexos
            cPrenda = drAnexo("Prenda")
            txtCusnam.Text = drAnexo("Descr")
        Next

        If cPrenda = "S" Then
            With cm2
                .CommandType = CommandType.StoredProcedure
                .CommandText = "DamePrenda1"
                .Connection = cnAgil
                .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                .Parameters(0).Value = cAnexo
            End With
            daPrenda.Fill(dsAgil, "Prenda")
            drPrendas = dsAgil.Tables("Prenda").Rows

            For Each drPrenda In drPrendas
                txtGarantia.Text = drPrenda("DescPrenda")
                txtValor.Text = drPrenda("ValorGar")
            Next
            If Trim(txtGarantia.Text) <> "" Then
                btnAlta.Enabled = False
                ButtonSEG.Enabled = True
            Else
                ButtonSEG.Enabled = False
                btnCambios.Enabled = False
            End If

        Else
            MsgBox("El contrato dice que no hay garant�a prendaria", MsgBoxStyle.Information, "Mensaje")
            Me.Close()
        End If

    End Sub

    Private Sub btnAlta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAlta.Click

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As SqlConnection = New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim strActualiza As String
        If Not IsNumeric(txtValor.Text) Then
            MsgBox("Valor de las garantias no valida", MsgBoxStyle.Critical, "Mensaje de error")
            txtValor.Focus()
            Exit Sub
        End If

        Try
            cnAgil.Open()
            strActualiza = "INSERT INTO Prenda(Anexo, Prenda,ValorGar) VALUES('" & cAnexo & "', '" & txtGarantia.Text & "', '" & txtValor.Text & "') "
            cm1 = New SqlCommand(strActualiza, cnAgil)
            cm1.ExecuteNonQuery()
            ButtonSEG.Enabled = True
        Catch eException As Exception
            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de error")
        End Try
        btnAlta.Enabled = False
    End Sub

    Private Sub btnCambios_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCambios.Click

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As SqlConnection = New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim strActualiza As String

        Try
            cnAgil.Open()
            strActualiza = "UPDATE Prenda SET Anexo = " & "'" & cAnexo & "'," &
                                                            " Prenda = " & " '" & txtGarantia.Text & "'," &
                                                            " ValorGar = " & "'" & txtValor.Text & "'" &
                                                            "WHERE Anexo = " & "'" & cAnexo & "' and seguro is null"
            cm1 = New SqlCommand(strActualiza, cnAgil)
            cm1.ExecuteNonQuery()

        Catch eException As Exception
            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de error")
        End Try
        btnCambios.Enabled = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSEG.Click
        Dim f As New FrmPrendariaSEG
        f.cAnexo = cAnexo
        f.txtAnexo.Text = txtAnexo.Text
        f.txtCusnam.Text = txtCusnam.Text
        f.txtGarantia.Text = txtGarantia.Text
        f.txtValor.Text = txtValor.Text
        If f.ShowDialog Then
        End If
    End Sub
End Class
