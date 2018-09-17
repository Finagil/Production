Option Explicit On

Imports System.Data.SqlClient

Public Class frmContClie
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblClientes As System.Windows.Forms.Label
    Friend WithEvents btnModiGene As System.Windows.Forms.Button
    Friend WithEvents btnModiPers As System.Windows.Forms.Button
    Friend WithEvents gbContClie As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductionDataSet As Agil.ProductionDataSet
    Friend WithEvents ContClie1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContClie1TableAdapter As Agil.ProductionDataSetTableAdapters.ContClie1TableAdapter
    Friend WithEvents Txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents btnEmpleador As System.Windows.Forms.Button
    Friend WithEvents btnPLD As System.Windows.Forms.Button
    Friend WithEvents BtnLegales As Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ContClie1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New Agil.ProductionDataSet
        Me.lblClientes = New System.Windows.Forms.Label
        Me.gbContClie = New System.Windows.Forms.GroupBox
        Me.BtnLegales = New System.Windows.Forms.Button
        Me.btnPLD = New System.Windows.Forms.Button
        Me.btnEmpleador = New System.Windows.Forms.Button
        Me.Txtfiltro = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnModiPers = New System.Windows.Forms.Button
        Me.btnModiGene = New System.Windows.Forms.Button
        Me.ContClie1TableAdapter = New Agil.ProductionDataSetTableAdapters.ContClie1TableAdapter
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbContClie.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ContClie1BindingSource
        Me.ComboBox1.DisplayMember = "Descr"
        Me.ComboBox1.Location = New System.Drawing.Point(67, 93)
        Me.ComboBox1.MaxDropDownItems = 25
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(424, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "Cliente"
        '
        'ContClie1BindingSource
        '
        Me.ContClie1BindingSource.DataMember = "ContClie1"
        Me.ContClie1BindingSource.DataSource = Me.ProductionDataSet
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblClientes
        '
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(68, 75)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(432, 16)
        Me.lblClientes.TabIndex = 2
        Me.lblClientes.Text = "Selecciona un Cliente de la siguiente Lista"
        '
        'gbContClie
        '
        Me.gbContClie.Controls.Add(Me.BtnLegales)
        Me.gbContClie.Controls.Add(Me.btnPLD)
        Me.gbContClie.Controls.Add(Me.btnEmpleador)
        Me.gbContClie.Controls.Add(Me.Txtfiltro)
        Me.gbContClie.Controls.Add(Me.Label1)
        Me.gbContClie.Controls.Add(Me.btnCancelar)
        Me.gbContClie.Controls.Add(Me.btnModiPers)
        Me.gbContClie.Controls.Add(Me.btnModiGene)
        Me.gbContClie.Controls.Add(Me.lblClientes)
        Me.gbContClie.Controls.Add(Me.ComboBox1)
        Me.gbContClie.Location = New System.Drawing.Point(32, 24)
        Me.gbContClie.Name = "gbContClie"
        Me.gbContClie.Size = New System.Drawing.Size(536, 184)
        Me.gbContClie.TabIndex = 3
        Me.gbContClie.TabStop = False
        '
        'BtnLegales
        '
        Me.BtnLegales.Enabled = False
        Me.BtnLegales.Location = New System.Drawing.Point(375, 132)
        Me.BtnLegales.Name = "BtnLegales"
        Me.BtnLegales.Size = New System.Drawing.Size(87, 45)
        Me.BtnLegales.TabIndex = 7
        Me.BtnLegales.Text = "Datos Legales"
        '
        'btnPLD
        '
        Me.btnPLD.Enabled = False
        Me.btnPLD.Location = New System.Drawing.Point(284, 133)
        Me.btnPLD.Name = "btnPLD"
        Me.btnPLD.Size = New System.Drawing.Size(87, 45)
        Me.btnPLD.TabIndex = 6
        Me.btnPLD.Text = "Datos PLD"
        '
        'btnEmpleador
        '
        Me.btnEmpleador.Enabled = False
        Me.btnEmpleador.Location = New System.Drawing.Point(193, 133)
        Me.btnEmpleador.Name = "btnEmpleador"
        Me.btnEmpleador.Size = New System.Drawing.Size(87, 45)
        Me.btnEmpleador.TabIndex = 5
        Me.btnEmpleador.Text = "Datos Empleador"
        '
        'Txtfiltro
        '
        Me.Txtfiltro.Location = New System.Drawing.Point(67, 52)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(424, 20)
        Me.Txtfiltro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 16)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Filtro"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(466, 133)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 45)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Salir"
        '
        'btnModiPers
        '
        Me.btnModiPers.Enabled = False
        Me.btnModiPers.Location = New System.Drawing.Point(97, 133)
        Me.btnModiPers.Name = "btnModiPers"
        Me.btnModiPers.Size = New System.Drawing.Size(92, 45)
        Me.btnModiPers.TabIndex = 4
        Me.btnModiPers.Text = "Modificar Personalidades"
        '
        'btnModiGene
        '
        Me.btnModiGene.Enabled = False
        Me.btnModiGene.Location = New System.Drawing.Point(6, 133)
        Me.btnModiGene.Name = "btnModiGene"
        Me.btnModiGene.Size = New System.Drawing.Size(87, 45)
        Me.btnModiGene.TabIndex = 3
        Me.btnModiGene.Text = "Modificar Generales"
        '
        'ContClie1TableAdapter
        '
        Me.ContClie1TableAdapter.ClearBeforeFill = True
        '
        'frmContClie
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(600, 238)
        Me.Controls.Add(Me.gbContClie)
        Me.Name = "frmContClie"
        Me.Text = "Control de Clientes"
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbContClie.ResumeLayout(False)
        Me.gbContClie.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmContClie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ContClie1TableAdapter.Fill(Me.ProductionDataSet.ContClie1)
        Try
        Catch eException As Exception
            MsgBox(eException.Source & " " & eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim cCliente As String

        If Not ComboBox1.SelectedValue Is Nothing Then

            cCliente = ComboBox1.SelectedValue.ToString()

            ' Ya que se escogió un cliente del listado, se activan los botones Modificar Generales y Modificar
            ' Personalidades del cliente


            btnModiGene.Enabled = True
            btnModiPers.Enabled = True
            btnEmpleador.Enabled = True
            btnPLD.Enabled = True

            If TaQUERY.SacaTipoPersona(cCliente) = "M" Then
                BtnLegales.Enabled = True
            Else
                BtnLegales.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnModiGene_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModiGene.Click
        Dim cCliente As String
        cCliente = ComboBox1.SelectedValue.ToString()
        Dim newfrmModiGene As New frmModiGene(cCliente)
        newfrmModiGene.Show()
    End Sub

    Private Sub btnModiPers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModiPers.Click
        Dim cCliente As String
        cCliente = ComboBox1.SelectedValue.ToString()
        Dim newfrmModiPers As New frmModiPers(cCliente)
        newfrmModiPers.Show()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            ContClie1BindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
        Else
            ContClie1BindingSource.Filter = ""
        End If
    End Sub

    Private Sub btnEmpleador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpleador.Click
        Dim cCliente As String
        cCliente = ComboBox1.SelectedValue.ToString()
        Dim newfrmEmpleador As New frmEmpleador(cCliente)
        newfrmEmpleador.Show()
    End Sub

    Private Sub btnPLD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPLD.Click
        Dim cCliente As String
        cCliente = ComboBox1.SelectedValue.ToString()
        Dim newfrmDatosPLD As New frmDatosPLD(cCliente)
        newfrmDatosPLD.Show()
    End Sub

    Private Sub BtnLegales_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLegales.Click
        Dim newfrmDatos As New FrmDatosLegales
        newfrmDatos.Cliente = ComboBox1.SelectedValue.ToString()
        newfrmDatos.Nombre = ComboBox1.Text
        newfrmDatos.Show()
    End Sub
End Class
