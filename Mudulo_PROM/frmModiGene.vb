Option Explicit On

Imports System.Data.SqlClient

Public Class frmModiGene

    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal cCliente As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtPassword.Text = cCliente

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents lblTelef As System.Windows.Forms.Label
    Friend WithEvents txtTelef1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTelef2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTelef3 As System.Windows.Forms.TextBox
    Friend WithEvents lblDeleg As System.Windows.Forms.Label
    Friend WithEvents txtDelegacion As System.Windows.Forms.TextBox
    Friend WithEvents lblPostal As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents lblColonia As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtDescTipo As System.Windows.Forms.TextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents txtDescr As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents rbCoacF As System.Windows.Forms.RadioButton
    Friend WithEvents rbCoacM As System.Windows.Forms.RadioButton
    Friend WithEvents chkObli As System.Windows.Forms.CheckBox
    Friend WithEvents chkAval1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAval2 As System.Windows.Forms.CheckBox
    Friend WithEvents rbObliM As System.Windows.Forms.RadioButton
    Friend WithEvents rbObliF As System.Windows.Forms.RadioButton
    Friend WithEvents rbAval1M As System.Windows.Forms.RadioButton
    Friend WithEvents rbAval1F As System.Windows.Forms.RadioButton
    Friend WithEvents rbAval2M As System.Windows.Forms.RadioButton
    Friend WithEvents rbAval2F As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtMail2 As System.Windows.Forms.TextBox
    Friend WithEvents lblMail2 As System.Windows.Forms.Label
    Friend WithEvents txtMail1 As System.Windows.Forms.TextBox
    Friend WithEvents lblGiro As System.Windows.Forms.Label
    Friend WithEvents cbGiros As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRfc As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtxtColonia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCoac As System.Windows.Forms.CheckBox
    Friend WithEvents txtCopos As System.Windows.Forms.TextBox
    Friend WithEvents lblCopos As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mtxtCURP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbFormapag1 As System.Windows.Forms.ComboBox
    Friend WithEvents mtxtCuenta1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbFormapag4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbFormapag3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbFormapag2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents mtxtCuenta4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtCuenta3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtCuenta2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtVentas As System.Windows.Forms.TextBox
    Friend WithEvents cbPromotores As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CmbGR As System.Windows.Forms.ComboBox
    Friend WithEvents GeneralDS As Agil.GeneralDS
    Friend WithEvents GruposRiesgosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GruposRiesgosTableAdapter As Agil.GeneralDSTableAdapters.GruposRiesgosTableAdapter
    Friend WithEvents txtGrupoRiesgo As System.Windows.Forms.TextBox
    Friend WithEvents btnIntegrar As System.Windows.Forms.Button
    Friend WithEvents PromocionDS As PromocionDS
    Friend WithEvents MetodoPagoBindingSource As BindingSource
    Friend WithEvents MetodoPagoTableAdapter As PromocionDSTableAdapters.MetodoPagoTableAdapter
    Friend WithEvents Label16 As Label
    Friend WithEvents CmbInegi As ComboBox
    Friend WithEvents ClavesFIRABindingSource As BindingSource
    Friend WithEvents ClavesFIRATableAdapter As PromocionDSTableAdapters.ClavesFiraTableAdapter
    Friend WithEvents LbClave As Label
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbClave = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CmbInegi = New System.Windows.Forms.ComboBox()
        Me.ClavesFIRABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS = New Agil.PromocionDS()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtVentas = New System.Windows.Forms.TextBox()
        Me.cbFormapag4 = New System.Windows.Forms.ComboBox()
        Me.cbFormapag3 = New System.Windows.Forms.ComboBox()
        Me.cbFormapag2 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mtxtCuenta4 = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtCuenta3 = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtCuenta2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mtxtCuenta1 = New System.Windows.Forms.MaskedTextBox()
        Me.cbFormapag1 = New System.Windows.Forms.ComboBox()
        Me.MetodoPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCopos = New System.Windows.Forms.Label()
        Me.txtCopos = New System.Windows.Forms.TextBox()
        Me.mtxtColonia = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGiro = New System.Windows.Forms.Label()
        Me.cbGiros = New System.Windows.Forms.ComboBox()
        Me.cbPromotores = New System.Windows.Forms.ComboBox()
        Me.txtMail2 = New System.Windows.Forms.TextBox()
        Me.lblMail2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtMail1 = New System.Windows.Forms.TextBox()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.lblTelef = New System.Windows.Forms.Label()
        Me.txtTelef1 = New System.Windows.Forms.TextBox()
        Me.txtTelef2 = New System.Windows.Forms.TextBox()
        Me.txtTelef3 = New System.Windows.Forms.TextBox()
        Me.lblDeleg = New System.Windows.Forms.Label()
        Me.txtDelegacion = New System.Windows.Forms.TextBox()
        Me.lblPostal = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtDescTipo = New System.Windows.Forms.TextBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtDescr = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.rbCoacF = New System.Windows.Forms.RadioButton()
        Me.rbCoacM = New System.Windows.Forms.RadioButton()
        Me.chkObli = New System.Windows.Forms.CheckBox()
        Me.chkAval1 = New System.Windows.Forms.CheckBox()
        Me.chkAval2 = New System.Windows.Forms.CheckBox()
        Me.rbObliM = New System.Windows.Forms.RadioButton()
        Me.rbObliF = New System.Windows.Forms.RadioButton()
        Me.rbAval1M = New System.Windows.Forms.RadioButton()
        Me.rbAval1F = New System.Windows.Forms.RadioButton()
        Me.rbAval2M = New System.Windows.Forms.RadioButton()
        Me.rbAval2F = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkCoac = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.lblFecha1 = New System.Windows.Forms.Label()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtxtCURP = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CmbGR = New System.Windows.Forms.ComboBox()
        Me.GruposRiesgosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS()
        Me.GruposRiesgosTableAdapter = New Agil.GeneralDSTableAdapters.GruposRiesgosTableAdapter()
        Me.txtGrupoRiesgo = New System.Windows.Forms.TextBox()
        Me.btnIntegrar = New System.Windows.Forms.Button()
        Me.MetodoPagoTableAdapter = New Agil.PromocionDSTableAdapters.MetodoPagoTableAdapter()
        Me.ClavesFIRATableAdapter = New Agil.PromocionDSTableAdapters.ClavesFiraTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClavesFIRABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetodoPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GruposRiesgosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbClave)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.CmbInegi)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtVentas)
        Me.GroupBox1.Controls.Add(Me.cbFormapag4)
        Me.GroupBox1.Controls.Add(Me.cbFormapag3)
        Me.GroupBox1.Controls.Add(Me.cbFormapag2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.mtxtCuenta4)
        Me.GroupBox1.Controls.Add(Me.mtxtCuenta3)
        Me.GroupBox1.Controls.Add(Me.mtxtCuenta2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.mtxtCuenta1)
        Me.GroupBox1.Controls.Add(Me.cbFormapag1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblCopos)
        Me.GroupBox1.Controls.Add(Me.txtCopos)
        Me.GroupBox1.Controls.Add(Me.mtxtColonia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblGiro)
        Me.GroupBox1.Controls.Add(Me.cbGiros)
        Me.GroupBox1.Controls.Add(Me.cbPromotores)
        Me.GroupBox1.Controls.Add(Me.txtMail2)
        Me.GroupBox1.Controls.Add(Me.lblMail2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblMail)
        Me.GroupBox1.Controls.Add(Me.txtMail1)
        Me.GroupBox1.Controls.Add(Me.lblFax)
        Me.GroupBox1.Controls.Add(Me.txtFax)
        Me.GroupBox1.Controls.Add(Me.lblTelef)
        Me.GroupBox1.Controls.Add(Me.txtTelef1)
        Me.GroupBox1.Controls.Add(Me.txtTelef2)
        Me.GroupBox1.Controls.Add(Me.txtTelef3)
        Me.GroupBox1.Controls.Add(Me.lblDeleg)
        Me.GroupBox1.Controls.Add(Me.txtDelegacion)
        Me.GroupBox1.Controls.Add(Me.lblPostal)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.lblColonia)
        Me.GroupBox1.Controls.Add(Me.lblCalle)
        Me.GroupBox1.Controls.Add(Me.txtCalle)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 431)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'LbClave
        '
        Me.LbClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClave.Location = New System.Drawing.Point(491, 138)
        Me.LbClave.Name = "LbClave"
        Me.LbClave.Size = New System.Drawing.Size(236, 42)
        Me.LbClave.TabIndex = 61
        Me.LbClave.Text = "Proyecto suseptible de fondeo de acuerdo al programa de Financiamiento Rural (FIR" &
    "A)"
        Me.LbClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LbClave.Visible = False
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(492, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 16)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Localidad Inegi"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbInegi
        '
        Me.CmbInegi.DataSource = Me.ClavesFIRABindingSource
        Me.CmbInegi.DisplayMember = "NOM_LOC"
        Me.CmbInegi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbInegi.FormattingEnabled = True
        Me.CmbInegi.Location = New System.Drawing.Point(488, 116)
        Me.CmbInegi.Name = "CmbInegi"
        Me.CmbInegi.Size = New System.Drawing.Size(242, 21)
        Me.CmbInegi.TabIndex = 59
        Me.CmbInegi.ValueMember = "CVE_LOC"
        '
        'ClavesFIRABindingSource
        '
        Me.ClavesFIRABindingSource.DataMember = "ClavesFIRA"
        Me.ClavesFIRABindingSource.DataSource = Me.PromocionDS
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(270, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(272, 16)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "P. Morales y Fisicas con Actividad Empresarial"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(7, 217)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 16)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Importe  Ventas Anuales"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVentas
        '
        Me.txtVentas.Location = New System.Drawing.Point(144, 215)
        Me.txtVentas.Name = "txtVentas"
        Me.txtVentas.Size = New System.Drawing.Size(120, 20)
        Me.txtVentas.TabIndex = 56
        '
        'cbFormapag4
        '
        Me.cbFormapag4.FormattingEnabled = True
        Me.cbFormapag4.Items.AddRange(New Object() {"TRANSFERENCIAS ELECTRONICAS DE FONDOS", "TARJETA", "EFECTIVO", "CHEQUE"})
        Me.cbFormapag4.Location = New System.Drawing.Point(343, 400)
        Me.cbFormapag4.Name = "cbFormapag4"
        Me.cbFormapag4.Size = New System.Drawing.Size(226, 21)
        Me.cbFormapag4.TabIndex = 55
        '
        'cbFormapag3
        '
        Me.cbFormapag3.FormattingEnabled = True
        Me.cbFormapag3.Items.AddRange(New Object() {"TRANSFERENCIAS ELECTRONICAS DE FONDOS", "TARJETA", "EFECTIVO", "CHEQUE"})
        Me.cbFormapag3.Location = New System.Drawing.Point(344, 374)
        Me.cbFormapag3.Name = "cbFormapag3"
        Me.cbFormapag3.Size = New System.Drawing.Size(224, 21)
        Me.cbFormapag3.TabIndex = 54
        '
        'cbFormapag2
        '
        Me.cbFormapag2.FormattingEnabled = True
        Me.cbFormapag2.Items.AddRange(New Object() {"TRANSFERENCIAS ELECTRONICAS DE FONDOS", "TARJETA", "EFECTIVO", "CHEQUE"})
        Me.cbFormapag2.Location = New System.Drawing.Point(344, 348)
        Me.cbFormapag2.Name = "cbFormapag2"
        Me.cbFormapag2.Size = New System.Drawing.Size(224, 21)
        Me.cbFormapag2.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(247, 398)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 16)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Forma de Pago4"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(247, 376)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 16)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Forma de Pago3"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(247, 350)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Forma de Pago2"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mtxtCuenta4
        '
        Me.mtxtCuenta4.BeepOnError = True
        Me.mtxtCuenta4.Location = New System.Drawing.Point(199, 398)
        Me.mtxtCuenta4.Name = "mtxtCuenta4"
        Me.mtxtCuenta4.Size = New System.Drawing.Size(31, 20)
        Me.mtxtCuenta4.TabIndex = 49
        '
        'mtxtCuenta3
        '
        Me.mtxtCuenta3.BeepOnError = True
        Me.mtxtCuenta3.Location = New System.Drawing.Point(199, 372)
        Me.mtxtCuenta3.Name = "mtxtCuenta3"
        Me.mtxtCuenta3.Size = New System.Drawing.Size(31, 20)
        Me.mtxtCuenta3.TabIndex = 48
        '
        'mtxtCuenta2
        '
        Me.mtxtCuenta2.BeepOnError = True
        Me.mtxtCuenta2.Location = New System.Drawing.Point(199, 346)
        Me.mtxtCuenta2.Name = "mtxtCuenta2"
        Me.mtxtCuenta2.Size = New System.Drawing.Size(31, 20)
        Me.mtxtCuenta2.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 396)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 20)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Ulyimos 4 Digitos Cuenta de Pago4"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(5, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 20)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Ultimos 4 Digitos Cuenta de Pago3"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 20)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Ultimos 4 Digitos Cuenta de Pago2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mtxtCuenta1
        '
        Me.mtxtCuenta1.BeepOnError = True
        Me.mtxtCuenta1.Location = New System.Drawing.Point(199, 323)
        Me.mtxtCuenta1.Mask = "0000"
        Me.mtxtCuenta1.Name = "mtxtCuenta1"
        Me.mtxtCuenta1.Size = New System.Drawing.Size(31, 20)
        Me.mtxtCuenta1.TabIndex = 43
        '
        'cbFormapag1
        '
        Me.cbFormapag1.DataSource = Me.MetodoPagoBindingSource
        Me.cbFormapag1.DisplayMember = "Metodo"
        Me.cbFormapag1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormapag1.FormattingEnabled = True
        Me.cbFormapag1.Location = New System.Drawing.Point(344, 322)
        Me.cbFormapag1.Name = "cbFormapag1"
        Me.cbFormapag1.Size = New System.Drawing.Size(225, 21)
        Me.cbFormapag1.TabIndex = 42
        Me.cbFormapag1.ValueMember = "id_metodo"
        '
        'MetodoPagoBindingSource
        '
        Me.MetodoPagoBindingSource.DataMember = "MetodoPago"
        Me.MetodoPagoBindingSource.DataSource = Me.PromocionDS
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(247, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Forma de Pago1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Ultimos 4 Digitos Cuenta de Pago1"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCopos
        '
        Me.lblCopos.AutoSize = True
        Me.lblCopos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopos.ForeColor = System.Drawing.Color.Red
        Me.lblCopos.Location = New System.Drawing.Point(219, 48)
        Me.lblCopos.Name = "lblCopos"
        Me.lblCopos.Size = New System.Drawing.Size(0, 13)
        Me.lblCopos.TabIndex = 37
        Me.lblCopos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCopos
        '
        Me.txtCopos.Location = New System.Drawing.Point(144, 44)
        Me.txtCopos.MaxLength = 5
        Me.txtCopos.Name = "txtCopos"
        Me.txtCopos.Size = New System.Drawing.Size(71, 20)
        Me.txtCopos.TabIndex = 3
        '
        'mtxtColonia
        '
        Me.mtxtColonia.BeepOnError = True
        Me.mtxtColonia.Location = New System.Drawing.Point(144, 116)
        Me.mtxtColonia.Name = "mtxtColonia"
        Me.mtxtColonia.Size = New System.Drawing.Size(342, 20)
        Me.mtxtColonia.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Estado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGiro
        '
        Me.lblGiro.Location = New System.Drawing.Point(6, 190)
        Me.lblGiro.Name = "lblGiro"
        Me.lblGiro.Size = New System.Drawing.Size(134, 16)
        Me.lblGiro.TabIndex = 32
        Me.lblGiro.Text = "Giro del Negocio"
        Me.lblGiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbGiros
        '
        Me.cbGiros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGiros.Location = New System.Drawing.Point(144, 188)
        Me.cbGiros.Name = "cbGiros"
        Me.cbGiros.Size = New System.Drawing.Size(368, 21)
        Me.cbGiros.TabIndex = 9
        '
        'cbPromotores
        '
        Me.cbPromotores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPromotores.Location = New System.Drawing.Point(144, 292)
        Me.cbPromotores.Name = "cbPromotores"
        Me.cbPromotores.Size = New System.Drawing.Size(368, 21)
        Me.cbPromotores.TabIndex = 12
        '
        'txtMail2
        '
        Me.txtMail2.Location = New System.Drawing.Point(144, 268)
        Me.txtMail2.Name = "txtMail2"
        Me.txtMail2.Size = New System.Drawing.Size(368, 20)
        Me.txtMail2.TabIndex = 11
        '
        'lblMail2
        '
        Me.lblMail2.Location = New System.Drawing.Point(6, 270)
        Me.lblMail2.Name = "lblMail2"
        Me.lblMail2.Size = New System.Drawing.Size(134, 16)
        Me.lblMail2.TabIndex = 30
        Me.lblMail2.Text = "EMail Secundario"
        Me.lblMail2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Ejecutivo que lo atiende"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMail
        '
        Me.lblMail.Location = New System.Drawing.Point(6, 246)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(134, 16)
        Me.lblMail.TabIndex = 24
        Me.lblMail.Text = "EMail Principal"
        Me.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMail1
        '
        Me.txtMail1.Location = New System.Drawing.Point(144, 244)
        Me.txtMail1.Name = "txtMail1"
        Me.txtMail1.Size = New System.Drawing.Size(368, 20)
        Me.txtMail1.TabIndex = 10
        '
        'lblFax
        '
        Me.lblFax.Location = New System.Drawing.Point(6, 166)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(134, 16)
        Me.lblFax.TabIndex = 10
        Me.lblFax.Text = "Fax"
        Me.lblFax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(144, 164)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(104, 20)
        Me.txtFax.TabIndex = 8
        '
        'lblTelef
        '
        Me.lblTelef.Location = New System.Drawing.Point(6, 142)
        Me.lblTelef.Name = "lblTelef"
        Me.lblTelef.Size = New System.Drawing.Size(134, 16)
        Me.lblTelef.TabIndex = 8
        Me.lblTelef.Text = "Teléfonos"
        Me.lblTelef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelef1
        '
        Me.txtTelef1.Location = New System.Drawing.Point(144, 140)
        Me.txtTelef1.Name = "txtTelef1"
        Me.txtTelef1.Size = New System.Drawing.Size(104, 20)
        Me.txtTelef1.TabIndex = 5
        '
        'txtTelef2
        '
        Me.txtTelef2.Location = New System.Drawing.Point(249, 140)
        Me.txtTelef2.Name = "txtTelef2"
        Me.txtTelef2.Size = New System.Drawing.Size(104, 20)
        Me.txtTelef2.TabIndex = 6
        '
        'txtTelef3
        '
        Me.txtTelef3.Location = New System.Drawing.Point(353, 140)
        Me.txtTelef3.Name = "txtTelef3"
        Me.txtTelef3.Size = New System.Drawing.Size(104, 20)
        Me.txtTelef3.TabIndex = 7
        '
        'lblDeleg
        '
        Me.lblDeleg.Location = New System.Drawing.Point(6, 94)
        Me.lblDeleg.Name = "lblDeleg"
        Me.lblDeleg.Size = New System.Drawing.Size(134, 16)
        Me.lblDeleg.TabIndex = 7
        Me.lblDeleg.Text = "Delegación o Municipio"
        Me.lblDeleg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDelegacion
        '
        Me.txtDelegacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDelegacion.Location = New System.Drawing.Point(144, 92)
        Me.txtDelegacion.MaxLength = 45
        Me.txtDelegacion.Name = "txtDelegacion"
        Me.txtDelegacion.ReadOnly = True
        Me.txtDelegacion.Size = New System.Drawing.Size(342, 20)
        Me.txtDelegacion.TabIndex = 4
        Me.txtDelegacion.TabStop = False
        '
        'lblPostal
        '
        Me.lblPostal.Location = New System.Drawing.Point(6, 46)
        Me.lblPostal.Name = "lblPostal"
        Me.lblPostal.Size = New System.Drawing.Size(134, 16)
        Me.lblPostal.TabIndex = 5
        Me.lblPostal.Text = "Código Postal"
        Me.lblPostal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEstado
        '
        Me.txtEstado.AcceptsReturn = True
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.Location = New System.Drawing.Point(144, 68)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(342, 20)
        Me.txtEstado.TabIndex = 3
        Me.txtEstado.TabStop = False
        '
        'lblColonia
        '
        Me.lblColonia.Location = New System.Drawing.Point(6, 118)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(134, 16)
        Me.lblColonia.TabIndex = 4
        Me.lblColonia.Text = "Colonia (solo el nombre)"
        Me.lblColonia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCalle
        '
        Me.lblCalle.Location = New System.Drawing.Point(6, 22)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(64, 16)
        Me.lblCalle.TabIndex = 3
        Me.lblCalle.Text = "Calle"
        Me.lblCalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(80, 20)
        Me.txtCalle.MaxLength = 45
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(504, 20)
        Me.txtCalle.TabIndex = 2
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(365, 35)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(72, 16)
        Me.lblPass.TabIndex = 23
        Me.lblPass.Text = "Contraseña"
        Me.lblPass.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(437, 31)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(41, 20)
        Me.txtPassword.TabIndex = 22
        Me.txtPassword.TabStop = False
        '
        'txtDescTipo
        '
        Me.txtDescTipo.Location = New System.Drawing.Point(88, 31)
        Me.txtDescTipo.Name = "txtDescTipo"
        Me.txtDescTipo.ReadOnly = True
        Me.txtDescTipo.Size = New System.Drawing.Size(273, 20)
        Me.txtDescTipo.TabIndex = 34
        Me.txtDescTipo.TabStop = False
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(16, 36)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(56, 16)
        Me.lblTipo.TabIndex = 33
        Me.lblTipo.Text = "Tipo"
        Me.lblTipo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(88, 7)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.ReadOnly = True
        Me.txtDescr.Size = New System.Drawing.Size(657, 20)
        Me.txtDescr.TabIndex = 32
        Me.txtDescr.TabStop = False
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(16, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(56, 16)
        Me.lblName.TabIndex = 31
        Me.lblName.Text = "Nombre"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(131, 679)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(96, 32)
        Me.btnActualizar.TabIndex = 18
        Me.btnActualizar.Text = "Actualizar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(413, 679)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 32)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.Text = "Cancelar"
        '
        'rbCoacF
        '
        Me.rbCoacF.Location = New System.Drawing.Point(13, 42)
        Me.rbCoacF.Name = "rbCoacF"
        Me.rbCoacF.Size = New System.Drawing.Size(112, 16)
        Me.rbCoacF.TabIndex = 38
        Me.rbCoacF.Text = "Persona Física"
        '
        'rbCoacM
        '
        Me.rbCoacM.Location = New System.Drawing.Point(136, 42)
        Me.rbCoacM.Name = "rbCoacM"
        Me.rbCoacM.Size = New System.Drawing.Size(112, 16)
        Me.rbCoacM.TabIndex = 39
        Me.rbCoacM.Text = "Persona Moral"
        '
        'chkObli
        '
        Me.chkObli.Location = New System.Drawing.Point(16, 14)
        Me.chkObli.Name = "chkObli"
        Me.chkObli.Size = New System.Drawing.Size(120, 22)
        Me.chkObli.TabIndex = 15
        Me.chkObli.Text = "Segundo Aval"
        '
        'chkAval1
        '
        Me.chkAval1.Location = New System.Drawing.Point(11, 16)
        Me.chkAval1.Name = "chkAval1"
        Me.chkAval1.Size = New System.Drawing.Size(120, 16)
        Me.chkAval1.TabIndex = 16
        Me.chkAval1.Text = "Tercer Aval"
        '
        'chkAval2
        '
        Me.chkAval2.Location = New System.Drawing.Point(16, 16)
        Me.chkAval2.Name = "chkAval2"
        Me.chkAval2.Size = New System.Drawing.Size(120, 16)
        Me.chkAval2.TabIndex = 17
        Me.chkAval2.Text = "Cuarto Aval"
        '
        'rbObliM
        '
        Me.rbObliM.Location = New System.Drawing.Point(144, 38)
        Me.rbObliM.Name = "rbObliM"
        Me.rbObliM.Size = New System.Drawing.Size(112, 16)
        Me.rbObliM.TabIndex = 45
        Me.rbObliM.Text = "Persona Moral"
        '
        'rbObliF
        '
        Me.rbObliF.Location = New System.Drawing.Point(16, 38)
        Me.rbObliF.Name = "rbObliF"
        Me.rbObliF.Size = New System.Drawing.Size(112, 16)
        Me.rbObliF.TabIndex = 44
        Me.rbObliF.Text = "Persona Física"
        '
        'rbAval1M
        '
        Me.rbAval1M.Location = New System.Drawing.Point(140, 39)
        Me.rbAval1M.Name = "rbAval1M"
        Me.rbAval1M.Size = New System.Drawing.Size(112, 16)
        Me.rbAval1M.TabIndex = 47
        Me.rbAval1M.Text = "Persona Moral"
        '
        'rbAval1F
        '
        Me.rbAval1F.Location = New System.Drawing.Point(12, 39)
        Me.rbAval1F.Name = "rbAval1F"
        Me.rbAval1F.Size = New System.Drawing.Size(112, 16)
        Me.rbAval1F.TabIndex = 46
        Me.rbAval1F.Text = "Persona Física"
        '
        'rbAval2M
        '
        Me.rbAval2M.Location = New System.Drawing.Point(144, 40)
        Me.rbAval2M.Name = "rbAval2M"
        Me.rbAval2M.Size = New System.Drawing.Size(112, 16)
        Me.rbAval2M.TabIndex = 49
        Me.rbAval2M.Text = "Persona Moral"
        '
        'rbAval2F
        '
        Me.rbAval2F.Location = New System.Drawing.Point(16, 40)
        Me.rbAval2F.Name = "rbAval2F"
        Me.rbAval2F.Size = New System.Drawing.Size(112, 16)
        Me.rbAval2F.TabIndex = 48
        Me.rbAval2F.Text = "Persona Física"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCoac)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.rbCoacF)
        Me.GroupBox2.Controls.Add(Me.rbCoacM)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 517)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 72)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        '
        'chkCoac
        '
        Me.chkCoac.Location = New System.Drawing.Point(13, 17)
        Me.chkCoac.Name = "chkCoac"
        Me.chkCoac.Size = New System.Drawing.Size(108, 19)
        Me.chkCoac.TabIndex = 13
        Me.chkCoac.Text = "Coacreditado"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(137, 18)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(106, 19)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Primer Aval"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkObli)
        Me.GroupBox3.Controls.Add(Me.rbObliM)
        Me.GroupBox3.Controls.Add(Me.rbObliF)
        Me.GroupBox3.Location = New System.Drawing.Point(336, 519)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 72)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkAval1)
        Me.GroupBox4.Controls.Add(Me.rbAval1M)
        Me.GroupBox4.Controls.Add(Me.rbAval1F)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 597)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 72)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkAval2)
        Me.GroupBox5.Controls.Add(Me.rbAval2M)
        Me.GroupBox5.Controls.Add(Me.rbAval2F)
        Me.GroupBox5.Location = New System.Drawing.Point(336, 596)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(264, 72)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(493, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "R.F.C."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtRfc
        '
        Me.txtRfc.Location = New System.Drawing.Point(533, 31)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.ReadOnly = True
        Me.txtRfc.Size = New System.Drawing.Size(111, 20)
        Me.txtRfc.TabIndex = 55
        '
        'lblFecha1
        '
        Me.lblFecha1.AutoSize = True
        Me.lblFecha1.Location = New System.Drawing.Point(18, 57)
        Me.lblFecha1.Name = "lblFecha1"
        Me.lblFecha1.Size = New System.Drawing.Size(148, 13)
        Me.lblFecha1.TabIndex = 57
        Me.lblFecha1.Text = "Fecha de Nac. o Constitución"
        Me.lblFecha1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Enabled = False
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(172, 57)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "CURP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'mtxtCURP
        '
        Me.mtxtCURP.BeepOnError = True
        Me.mtxtCURP.Location = New System.Drawing.Point(309, 57)
        Me.mtxtCURP.Name = "mtxtCURP"
        Me.mtxtCURP.Size = New System.Drawing.Size(128, 20)
        Me.mtxtCURP.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(443, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "Grupo de Negocios"
        '
        'CmbGR
        '
        Me.CmbGR.DataSource = Me.GruposRiesgosBindingSource
        Me.CmbGR.DisplayMember = "NombreGrupo"
        Me.CmbGR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGR.FormattingEnabled = True
        Me.CmbGR.Location = New System.Drawing.Point(548, 55)
        Me.CmbGR.Name = "CmbGR"
        Me.CmbGR.Size = New System.Drawing.Size(197, 21)
        Me.CmbGR.TabIndex = 70
        Me.CmbGR.ValueMember = "id_GrupoRiesgo"
        '
        'GruposRiesgosBindingSource
        '
        Me.GruposRiesgosBindingSource.DataMember = "GruposRiesgos"
        Me.GruposRiesgosBindingSource.DataSource = Me.GeneralDS
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GruposRiesgosTableAdapter
        '
        Me.GruposRiesgosTableAdapter.ClearBeforeFill = True
        '
        'txtGrupoRiesgo
        '
        Me.txtGrupoRiesgo.Location = New System.Drawing.Point(562, 56)
        Me.txtGrupoRiesgo.Name = "txtGrupoRiesgo"
        Me.txtGrupoRiesgo.ReadOnly = True
        Me.txtGrupoRiesgo.Size = New System.Drawing.Size(30, 20)
        Me.txtGrupoRiesgo.TabIndex = 71
        '
        'btnIntegrar
        '
        Me.btnIntegrar.Location = New System.Drawing.Point(278, 678)
        Me.btnIntegrar.Name = "btnIntegrar"
        Me.btnIntegrar.Size = New System.Drawing.Size(96, 32)
        Me.btnIntegrar.TabIndex = 72
        Me.btnIntegrar.Text = "Integra Aval"
        '
        'MetodoPagoTableAdapter
        '
        Me.MetodoPagoTableAdapter.ClearBeforeFill = True
        '
        'ClavesFIRATableAdapter
        '
        Me.ClavesFIRATableAdapter.ClearBeforeFill = True
        '
        'frmModiGene
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(756, 715)
        Me.Controls.Add(Me.btnIntegrar)
        Me.Controls.Add(Me.CmbGR)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.mtxtCURP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFecha1)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRfc)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDescTipo)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.txtDescr)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtGrupoRiesgo)
        Me.Name = "frmModiGene"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Generales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClavesFIRABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetodoPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.GruposRiesgosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' Esta función recibe como parámetro el número del cliente y lo guarda en txtPassword.Text

    ' Declaración de variables de alcance privado

    Dim cPlaza As String = ""
    Dim PromAux As String = ""
    Dim GR_aux As String = ""
    Dim cCopos As String = "00000"


    Private Sub frmModiGene_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.MetodoPagoTableAdapter.Fill(Me.PromocionDS.MetodoPago)
        If UsuarioGlobal.ToLower <> "atorres" And UsuarioGlobal.ToLower <> "desarrollo" And UsuarioGlobal.ToLower <> "vely" Then
            'btnIntegrar.Enabled = False Se activa pata todos
        End If
        If UsuarioGlobal.ToLower = "mleal" Or UsuarioGlobal.ToLower = "desarrollo" Then
            'btnIntegrar.Enabled = False Se activa pata todos
            cbPromotores.Enabled = True
        Else
            cbPromotores.Enabled = False
        End If
        Me.GruposRiesgosTableAdapter.Fill(Me.GeneralDS.GruposRiesgos)

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim dsAgil As New DataSet()
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim daClientes As New SqlDataAdapter(cm1)
        Dim daPromotores As New SqlDataAdapter(cm2)
        Dim daGiros As New SqlDataAdapter(cm3)
        Dim drCliente As DataRow

        ' Declaración de variables de datos

        Dim cCliente As String
        Dim cTipo As String

        cCliente = txtPassword.Text

        ' El siguiente Stored Procedure trae todos los atributos de la tabla Clientes, para un cliente dado

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DatosClie1"
            .Connection = cnAgil
            .Parameters.Add("@Cliente", SqlDbType.NVarChar)
            .Parameters(0).Value = cCliente
        End With

        ' El siguiente Stored Procedure trae todos los atributos de todos los Promotores

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Promotores1"
            .Connection = cnAgil
        End With

        ' El siguiente Stored Procedure trae todos los atributos de todos los Giros

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Giros1"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daClientes.Fill(dsAgil, "Clientes")
        daPromotores.Fill(dsAgil, "Promotores")
        daGiros.Fill(dsAgil, "Giros")

        Try

            ' Ligar la tabla Giros del dataset dsAgil al ComboBox Giros

            cbGiros.DataSource = dsAgil
            cbGiros.DisplayMember = "Giros.DescGiro"
            cbGiros.ValueMember = "Giros.Giro"

            ' Ligar la tabla Promotores del dataset dsAgil al ComboBox Promotores

            cbPromotores.DataSource = dsAgil
            cbPromotores.DisplayMember = "Promotores.DescPromotor"
            cbPromotores.ValueMember = "Promotores.Promotor"

            If dsAgil.Tables("Clientes").Rows.Count > 0 Then

                drCliente = dsAgil.Tables("Clientes").Rows(0)
                txtDescr.Text = drCliente("Descr")
                cTipo = drCliente("Tipo")
                If cTipo = "F" Then
                    txtDescTipo.Text = "PERSONA FISICA"
                ElseIf cTipo = "E" Then
                    txtDescTipo.Text = "PERSONA FISICA CON ACTIVIDAD EMPRESARIAL"
                ElseIf cTipo = "M" Then
                    txtDescTipo.Text = "PERSONA MORAL"
                End If
                txtRfc.Text = drCliente("RFC")
                mtxtCURP.Text = drCliente("CURP")
                dtpFecha1.Value = CTOD(drCliente("Fecha1"))
                txtCalle.Text = RTrim(drCliente("Calle"))
                cCopos = Trim(drCliente("Copos"))
                txtCopos.Text = cCopos
                If cCopos <> "" And cCopos <> "00000" Then
                    cPlaza = drCliente("Plaza")
                    txtEstado.Text = RTrim(drCliente("Estado"))
                    txtDelegacion.Text = drCliente("Delegacion")
                    mtxtColonia.Text = drCliente("Colonia")
                    Me.ClavesFIRATableAdapter.Fill(Me.PromocionDS.ClavesFira, txtEstado.Text.Trim, txtDelegacion.Text.Trim)
                    If Not IsDBNull(drCliente("Cve_loc")) Then
                        If drCliente("Cve_loc") = 0 Then
                            CmbInegi.SelectedIndex = 0
                        Else
                            CmbInegi.SelectedValue = drCliente("Cve_loc")
                        End If
                    End If
                Else
                    mtxtColonia.Clear()
                    mtxtColonia.TextAlign = HorizontalAlignment.Left
                    mtxtColonia.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
                    cPlaza = 11
                    Me.PromocionDS.ClavesFira.Clear()
                End If
                txtTelef1.Text = drCliente("Telef1")
                txtTelef2.Text = drCliente("Telef2")
                txtTelef3.Text = drCliente("Telef3")
                txtFax.Text = drCliente("Fax")
                txtRfc.Text = drCliente("Rfc")

                txtGrupoRiesgo.Text = drCliente("id_GrupoRiesgo")
                If txtGrupoRiesgo.Text = "0" Then
                    'CmbGR.Text = "SIN GRUPO DE NEGOCIOS"
                    GR_aux = txtGrupoRiesgo.Text
                Else
                    CmbGR.Text = Me.GruposRiesgosTableAdapter.SacaNombre(txtGrupoRiesgo.Text)
                    'CmbGR.Enabled = False
                End If
                If Val(drCliente("Fecha1")) > 0 Then
                    dtpFecha1.Value = CTOD(drCliente("Fecha1"))
                Else
                    dtpFecha1.Value = DateSerial(Now.Year, Now.Month, Now.Day)
                End If
                cbGiros.SelectedIndex = Val(drCliente("Giro")) - 1
                txtVentas.Text = drCliente("VentasAnuales")
                txtMail1.Text = drCliente("EMail1")
                txtMail2.Text = drCliente("EMail2")
                If drCliente("Promo") = "000" Then
                    cbPromotores.SelectedIndex = 0
                    cbPromotores.Enabled = True
                Else
                    cbPromotores.SelectedIndex = Val(drCliente("Promo")) - 1
                End If

                PromAux = drCliente("Promo")
                mtxtCuenta1.Text = drCliente("CuentadePago1")
                mtxtCuenta2.Text = drCliente("CuentadePago2")
                mtxtCuenta3.Text = drCliente("CuentadePago3")
                mtxtCuenta4.Text = drCliente("CuentadePago4")

                cbFormapag1.Text = RTrim(drCliente("FormadePago1"))

                If RTrim(drCliente("FormadePago2")) = "TRANSFERENCIAS ELECTRONICAS DE FONDOS" Then
                    cbFormapag2.SelectedIndex = 0
                ElseIf RTrim(drCliente("FormadePago2")) = "TARJETA" Then
                    cbFormapag2.SelectedIndex = 1
                ElseIf RTrim(drCliente("FormadePago2")) = "EFECTIVO" Then
                    cbFormapag2.SelectedIndex = 2
                ElseIf RTrim(drCliente("FormadePago2")) = "CHEQUE" Then
                    cbFormapag2.SelectedIndex = 3
                End If

                If RTrim(drCliente("FormadePago3")) = "TRANSFERENCIAS ELECTRONICAS DE FONDOS" Then
                    cbFormapag3.SelectedIndex = 0
                ElseIf RTrim(drCliente("FormadePago3")) = "TARJETA" Then
                    cbFormapag3.SelectedIndex = 1
                ElseIf RTrim(drCliente("FormadePago3")) = "EFECTIVO" Then
                    cbFormapag3.SelectedIndex = 2
                ElseIf RTrim(drCliente("FormadePago3")) = "CHEQUE" Then
                    cbFormapag3.SelectedIndex = 3
                End If

                If RTrim(drCliente("FormadePago4")) = "TRANSFERENCIAS ELECTRONICAS DE FONDOS" Then
                    cbFormapag4.SelectedIndex = 0
                ElseIf RTrim(drCliente("FormadePago4")) = "TARJETA" Then
                    cbFormapag4.SelectedIndex = 1
                ElseIf RTrim(drCliente("FormadePago4")) = "EFECTIVO" Then
                    cbFormapag4.SelectedIndex = 2
                ElseIf RTrim(drCliente("FormadePago4")) = "CHEQUE" Then
                    cbFormapag4.SelectedIndex = 3
                End If

                ' Determina si existe Coacreditado

                If drCliente("Coac") = "S" Then
                    chkCoac.Checked = False
                    CheckBox1.Checked = True
                    If drCliente("TipCoac") = "F" Then
                        rbCoacF.Checked = True
                        rbCoacM.Checked = False
                    Else
                        rbCoacM.Checked = True
                        rbCoacF.Checked = False
                    End If
                ElseIf drCliente("Coac") = "C" Then
                    chkCoac.Checked = True
                    CheckBox1.Checked = False
                    If drCliente("TipCoac") = "F" Then
                        rbCoacF.Checked = True
                        rbCoacM.Checked = False
                    Else
                        rbCoacM.Checked = True
                        rbCoacF.Checked = False
                    End If
                Else
                    chkCoac.Checked = False
                    CheckBox1.Checked = False
                    rbCoacF.Checked = False
                    rbCoacM.Checked = False
                End If

                ' Determina si existe Obligado Solidario

                If drCliente("Obli") = "S" Then
                    chkObli.Checked = True
                    If drCliente("TipoObli") = "F" Then
                        rbObliF.Checked = True
                        rbObliM.Checked = False
                    Else
                        rbObliM.Checked = True
                        rbObliF.Checked = False
                    End If
                Else
                    chkObli.Checked = False
                    rbObliF.Checked = False
                    rbObliM.Checked = False
                End If

                ' Determina si existe Primer Aval

                If drCliente("Aval1") = "S" Then
                    chkAval1.Checked = True
                    If drCliente("Tipaval1") = "F" Then
                        rbAval1F.Checked = True
                        rbAval1M.Checked = False
                    Else
                        rbAval1M.Checked = True
                        rbAval1F.Checked = False
                    End If
                Else
                    chkAval1.Checked = False
                    rbAval1F.Checked = False
                    rbAval1M.Checked = False
                End If

                ' Determina si existe Segundo Aval

                If drCliente("Aval2") = "S" Then
                    chkAval2.Checked = True
                    If drCliente("Tipaval2") = "F" Then
                        rbAval2F.Checked = True
                        rbAval2M.Checked = False
                    Else
                        rbAval2M.Checked = True
                        rbAval2F.Checked = False
                    End If
                Else
                    chkAval2.Checked = False
                    rbAval2F.Checked = False
                    rbAval2M.Checked = False
                End If

            End If
        Catch eException As Exception
            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
        End Try

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()

    End Sub

    Private Sub txtCopos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCopos.LostFocus

        ' En este momento es cuando debo hacer la consulta a la tabla Copos para traer los datos del Estado y de la Delegación o Municipio

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daCodigos As New SqlDataAdapter(cm1)
        Dim daPlazas As New SqlDataAdapter(cm2)
        Dim drPlazas As DataRow

        Dim dsAgil As New DataSet()
        Dim drCodigo As DataRow

        ' El siguiente Stored Procedure trae todos los atributos de la tabla Clientes, para un cliente dado

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT DISTINCT Copos, Estado, Delegacion FROM Codigos WHERE Copos = " & txtCopos.Text
            .Connection = cnAgil
        End With

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Plazas"
            .Connection = cnAgil
        End With
        daPlazas.Fill(dsAgil, "Plazas")

        ' Llenar el Dataset lo cual abre y cierra la conexión

        daCodigos.Fill(dsAgil, "Codigos")

        If dsAgil.Tables("Codigos").Rows.Count > 0 Then

            lblCopos.Text = ""

            drCodigo = dsAgil.Tables("Codigos").Rows(0)
            txtEstado.Text = drCodigo("Estado")
            txtDelegacion.Text = drCodigo("Delegacion")

            txtEstado.Text = txtEstado.Text.Replace("Á", "A")
            txtEstado.Text = txtEstado.Text.Replace("É", "E")
            txtEstado.Text = txtEstado.Text.Replace("Í", "I")
            txtEstado.Text = txtEstado.Text.Replace("Ó", "O")
            txtEstado.Text = txtEstado.Text.Replace("Ü", "U")
            txtEstado.Text = Mid(txtEstado.Text, 1, 60)
            txtDelegacion.Text = txtDelegacion.Text.Replace("Á", "A")
            txtDelegacion.Text = txtDelegacion.Text.Replace("É", "E")
            txtDelegacion.Text = txtDelegacion.Text.Replace("Í", "I")
            txtDelegacion.Text = txtDelegacion.Text.Replace("Ó", "O")
            txtDelegacion.Text = txtDelegacion.Text.Replace("Ü", "U")
            txtDelegacion.Text = Mid(txtDelegacion.Text, 1, 60)

            If cPlaza = "" Then
                For Each drPlazas In dsAgil.Tables("Plazas").Rows
                    Dim BuscaAqui As String = drPlazas("DescPlaza")
                    Dim FirstCharacter As Integer = BuscaAqui.IndexOf(txtEstado.Text)

                    If FirstCharacter = 0 Then
                        cPlaza = drPlazas("Plaza")
                    ElseIf BuscaAqui = "ESTADO DE MEXICO         " Then
                        cPlaza = "11"
                    End If
                Next
            End If

            'cPlaza = drCodigo("Plaza")
            Me.ClavesFIRATableAdapter.Fill(Me.PromocionDS.ClavesFira, txtEstado.Text.Trim, txtDelegacion.Text.Trim)

        Else

            ' Código Postal inexistente
            Me.PromocionDS.ClavesFira.Clear()
            lblCopos.Text = "Código Postal inexistente, favor de revisarlo"

            txtEstado.Text = ""
            txtDelegacion.Text = ""
            cPlaza = ""

        End If

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim strUpdate As String

        ' Declaración de variables de datos

        Dim cAval1 As String
        Dim cAval2 As String
        Dim cCoac As String
        Dim cFecha1 As String
        Dim cGiro As String
        Dim cObli As String
        Dim cPromotor As String
        Dim cTipAval1 As String
        Dim cTipAval2 As String
        Dim cTipCoac As String
        Dim cTipoObli As String
        Dim cCero As String = "0"
        Dim lCorrecto As Boolean

        cFecha1 = DTOC(dtpFecha1.Value)
        cGiro = Stuff((cbGiros.SelectedIndex + 1).ToString, "I", "0", 2)
        cPromotor = Stuff((cbPromotores.SelectedIndex + 1).ToString, "I", "0", 3)

        lCorrecto = True

        ' Falta realizar algunas validaciones.   Por ejemplo, que no se deje la dirección 
        ' en(blanco)

        If lblCopos.Text <> "" Then
            MsgBox("Debe introducirse un Código Postal existente", MsgBoxStyle.Critical, "Error de Validación")
            lCorrecto = False
        End If

        If txtGrupoRiesgo.Text = "0" Then
            MsgBox("Falta asignar Grupo de Negocios", MsgBoxStyle.Critical, "Error de Validación")
            lCorrecto = False
        End If

        ' Si existe Coacreditado debe indicarse si se trata de persona física o moral

        If chkCoac.Checked = True Then
            cCoac = "C"
            If rbCoacF.Checked = False And rbCoacM.Checked = False Then
                MsgBox("Debe especificarse el tipo de coacreditado", MsgBoxStyle.Critical, "Error de Validación")
                lCorrecto = False
            Else
                If rbCoacF.Checked = True Then
                    cTipCoac = "F"
                ElseIf rbCoacM.Checked = True Then
                    cTipCoac = "M"
                End If
            End If
        ElseIf CheckBox1.Checked = True Then
            cCoac = "S"
            If rbCoacF.Checked = False And rbCoacM.Checked = False Then
                MsgBox("Debe especificarse el tipo de coacreditado", MsgBoxStyle.Critical, "Error de Validación")
                lCorrecto = False
            Else
                If rbCoacF.Checked = True Then
                    cTipCoac = "F"
                ElseIf rbCoacM.Checked = True Then
                    cTipCoac = "M"
                End If
            End If
        Else
            cCoac = "N"
            cTipCoac = " "
            rbCoacF.Checked = False
            rbCoacM.Checked = False
        End If

        ' Si existe Obligado Solidario, debe especificarse si se trata de persona física o moral

        If chkObli.Checked = True Then
            If rbObliF.Checked = False And rbObliM.Checked = False Then
                MsgBox("Debe especificarse el tipo de Obligado Solidario", MsgBoxStyle.Critical, "Error de Validación")
                lCorrecto = False
            Else
                cObli = "S"
                If rbObliF.Checked = True Then
                    cTipoObli = "F"
                ElseIf rbObliM.Checked = True Then
                    cTipoObli = "M"
                End If
            End If
        Else
            cObli = "N"
            cTipoObli = " "
            rbObliF.Checked = False
            rbObliM.Checked = False
        End If

        ' Si existe Primer Aval, debe especificarse si se trata de persona física o moral

        If chkAval1.Checked = True Then
            If rbAval1F.Checked = False And rbAval1M.Checked = False Then
                MsgBox("Debe especificarse el tipo de Primer Aval", MsgBoxStyle.Critical, "Error de Validación")
                lCorrecto = False
            Else
                cAval1 = "S"
                If rbAval1F.Checked = True Then
                    cTipAval1 = "F"
                ElseIf rbAval1M.Checked = True Then
                    cTipAval1 = "M"
                End If
            End If
        Else
            cAval1 = "N"
            cTipAval1 = " "
            rbAval1F.Checked = False
            rbAval1M.Checked = False
        End If

        ' Si existe Segundo Aval, debe especificarse si se trata de persona física o moral

        If chkAval2.Checked = True Then
            If rbAval2F.Checked = False And rbAval2M.Checked = False Then
                MsgBox("Debe especificarse el tipo de Segundo Aval", MsgBoxStyle.Critical, "Error de Validación")
                lCorrecto = False
            Else
                cAval2 = "S"
                If rbAval2F.Checked = True Then
                    cTipAval2 = "F"
                ElseIf rbAval2M.Checked = True Then
                    cTipAval2 = "M"
                End If
            End If
        Else
            cAval2 = "N"
            cTipAval2 = " "
            rbAval2F.Checked = False
            rbAval2M.Checked = False
        End If

        If lCorrecto = True Then
            strUpdate = "UPDATE Clientes SET Calle = '" & txtCalle.Text & "'"
            strUpdate = strUpdate & ", Colonia = '" & mtxtColonia.Text & "'"
            strUpdate = strUpdate & ", Copos = '" & txtCopos.Text & "'"
            strUpdate = strUpdate & ", Delegacion = '" & txtDelegacion.Text & "'"
            strUpdate = strUpdate & ", Estado = '" & txtEstado.Text & "'"
            strUpdate = strUpdate & ", Plaza = '" & cPlaza & "'"
            strUpdate = strUpdate & ", Telef1 = '" & txtTelef1.Text & "'"
            strUpdate = strUpdate & ", Telef2 = '" & txtTelef2.Text & "'"
            strUpdate = strUpdate & ", Telef3 = '" & txtTelef3.Text & "'"
            strUpdate = strUpdate & ", Fax = '" & txtFax.Text & "'"
            strUpdate = strUpdate & ", Giro = '" & cGiro & "'"
            strUpdate = strUpdate & ", CURP = '" & mtxtCURP.Text & "'"
            strUpdate = strUpdate & ", EMail1 = '" & txtMail1.Text & "'"
            strUpdate = strUpdate & ", EMail2 = '" & txtMail2.Text & "'"
            strUpdate = strUpdate & ", VentasAnuales = '" & txtVentas.Text & "'"
            strUpdate = strUpdate & ", Promo = '" & cPromotor & "'"
            strUpdate = strUpdate & ", Coac = '" & cCoac & "'"
            strUpdate = strUpdate & ", TipCoac = '" & cTipCoac & "'"
            strUpdate = strUpdate & ", Obli = '" & cObli & "'"
            strUpdate = strUpdate & ", TipoObli = '" & cTipoObli & "'"
            strUpdate = strUpdate & ", Aval1 = '" & cAval1 & "'"
            strUpdate = strUpdate & ", TipAval1 = '" & cTipAval1 & "'"
            strUpdate = strUpdate & ", Aval2 = '" & cAval2 & "'"
            strUpdate = strUpdate & ", TipAval2 = '" & cTipAval2 & "'"
            strUpdate = strUpdate & ", id_GrupoRiesgo = '" & txtGrupoRiesgo.Text & "'"
            strUpdate = strUpdate & ", CuentadePago1 = '" & mtxtCuenta1.Text & "'"
            strUpdate = strUpdate & ", FormadePago1 = '" & cbFormapag1.Text & "'"
            strUpdate = strUpdate & ", Cve_LOC = '" & CmbInegi.SelectedValue & "'"


            If cbFormapag2.SelectedItem = "EFECTIVO" Then
                strUpdate = strUpdate & ", CuentadePago2 = '" & cCero & "'"
                strUpdate = strUpdate & ", FormadePago2 = '" & cbFormapag2.SelectedItem & "'"
            Else
                strUpdate = strUpdate & ", CuentadePago2 = '" & mtxtCuenta2.Text & "'"
                strUpdate = strUpdate & ", FormadePago2 = '" & cbFormapag2.SelectedItem & "'"
            End If
            If cbFormapag3.SelectedItem = "EFECTIVO" Then
                strUpdate = strUpdate & ", CuentadePago3 = '" & cCero & "'"
                strUpdate = strUpdate & ", FormadePago3 = '" & cbFormapag3.SelectedItem & "'"
            Else
                strUpdate = strUpdate & ", CuentadePago3 = '" & mtxtCuenta3.Text & "'"
                strUpdate = strUpdate & ", FormadePago3 = '" & cbFormapag3.SelectedItem & "'"
            End If
            If cbFormapag4.SelectedItem = "EFECTIVO" Then
                strUpdate = strUpdate & ", CuentadePago4 = '" & cCero & "'"
                strUpdate = strUpdate & ", FormadePago4 = '" & cbFormapag4.SelectedItem & "'"
            Else
                strUpdate = strUpdate & ", CuentadePago4 = '" & mtxtCuenta4.Text & "'"
                strUpdate = strUpdate & ", FormadePago4 = '" & cbFormapag4.SelectedItem & "'"
            End If

            strUpdate = strUpdate & " WHERE Cliente = '" & txtPassword.Text & "'"
            If PromAux <> cPromotor Then
                Dim ta As New GeneralDSTableAdapters.GEN_BitacoraPromotoresTableAdapter
                ta.Insert(UsuarioGlobal, PromAux, cPromotor, Date.Now, txtPassword.Text, "PRO")
            End If
            If GR_aux <> txtGrupoRiesgo.Text Then
                Dim ta As New GeneralDSTableAdapters.GEN_BitacoraPromotoresTableAdapter
                ta.Insert(UsuarioGlobal, PromAux, cPromotor, Date.Now, txtPassword.Text, "GDN")
            End If
            Try
                cnAgil.Open()
                cm1 = New SqlCommand(strUpdate, cnAgil)
                cm1.ExecuteNonQuery()
                cnAgil.Close()
                cnAgil.Dispose()
                cm1.Dispose()
                Me.Close()
            Catch eException As Exception
                MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje")
            End Try
            'registra bitacora de cambios de asignacion de promotores

        End If

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            chkCoac.Checked = False
        Else
            chkCoac.Checked = True
        End If
    End Sub

    Private Sub mtxtCURP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtxtCURP.Click
        mtxtCURP.Clear()
        mtxtCURP.TextAlign = HorizontalAlignment.Left
        mtxtCURP.Mask = "????999999AAAAAAAA"
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Private Sub CmbGR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbGR.SelectedIndexChanged
        If CmbGR.SelectedValue >= 0 Then
            txtGrupoRiesgo.Text = CmbGR.SelectedValue
        End If

    End Sub


    Private Sub btnIntegrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntegrar.Click
        Dim cCliente As String
        Dim cNombre As String
        cCliente = txtPassword.Text
        cNombre = txtDescr.Text
        Dim newfrmAvalesAsociados As New frmAvalesAsociados(cCliente, cNombre)
        newfrmAvalesAsociados.Show()
    End Sub

    Private Sub CmbInegi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbInegi.SelectedIndexChanged
        If CmbInegi.SelectedIndex >= 0 Then

        End If
    End Sub

    Private Sub ClavesFIRABindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ClavesFIRABindingSource.CurrentChanged
        If Not IsNothing(Me.ClavesFIRABindingSource.Current("PTOT")) Then
            If Val(Me.ClavesFIRABindingSource.Current("PTOT")) <= 50000 Then
                LbClave.Visible = True
            Else
                LbClave.Visible = False
            End If
        Else
            LbClave.Visible = False
        End If
    End Sub
End Class
