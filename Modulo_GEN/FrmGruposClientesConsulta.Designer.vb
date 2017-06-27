<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGruposClientesConsulta


    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Public Sub New(ByVal cCliente As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtCliente.Text = cCliente
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.TxtCliente = New System.Windows.Forms.TextBox
        Me.mtxtCURP = New System.Windows.Forms.MaskedTextBox
        Me.ClientesGENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtRfc = New System.Windows.Forms.TextBox
        Me.txtDescTipo = New System.Windows.Forms.TextBox
        Me.lblTipo = New System.Windows.Forms.Label
        Me.txtDescr = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lblPass = New System.Windows.Forms.Label
        Me.txtCopos = New System.Windows.Forms.TextBox
        Me.mtxtColonia = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblGiro = New System.Windows.Forms.Label
        Me.txtMail2 = New System.Windows.Forms.TextBox
        Me.lblMail2 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblMail = New System.Windows.Forms.Label
        Me.txtMail1 = New System.Windows.Forms.TextBox
        Me.lblFax = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.lblTelef = New System.Windows.Forms.Label
        Me.txtTelef1 = New System.Windows.Forms.TextBox
        Me.txtTelef2 = New System.Windows.Forms.TextBox
        Me.txtTelef3 = New System.Windows.Forms.TextBox
        Me.lblDeleg = New System.Windows.Forms.Label
        Me.txtDelegacion = New System.Windows.Forms.TextBox
        Me.lblPostal = New System.Windows.Forms.Label
        Me.txtEstado = New System.Windows.Forms.TextBox
        Me.lblColonia = New System.Windows.Forms.Label
        Me.lblCalle = New System.Windows.Forms.Label
        Me.txtCalle = New System.Windows.Forms.TextBox
        Me.TxtGiro = New System.Windows.Forms.TextBox
        Me.TxtProm = New System.Windows.Forms.TextBox
        Me.TxtActEco = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtSucursal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtRiesgo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnRiesgo = New System.Windows.Forms.Button
        Me.BtoRiesgoComun = New System.Windows.Forms.Button
        Me.TxtIDGR = New System.Windows.Forms.TextBox
        Me.TxtIDRC = New System.Windows.Forms.TextBox
        Me.BttGR = New System.Windows.Forms.Button
        Me.ClientesGENTableAdapter = New Agil.GeneralDSTableAdapters.ClientesGENTableAdapter
        CType(Me.ClientesGENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(594, 8)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(12, 20)
        Me.TxtCliente.TabIndex = 0
        Me.TxtCliente.Visible = False
        '
        'mtxtCURP
        '
        Me.mtxtCURP.BeepOnError = True
        Me.mtxtCURP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "CURP", True))
        Me.mtxtCURP.Location = New System.Drawing.Point(357, 53)
        Me.mtxtCURP.Name = "mtxtCURP"
        Me.mtxtCURP.ReadOnly = True
        Me.mtxtCURP.Size = New System.Drawing.Size(128, 20)
        Me.mtxtCURP.TabIndex = 81
        Me.mtxtCURP.TabStop = False
        '
        'ClientesGENBindingSource
        '
        Me.ClientesGENBindingSource.DataMember = "ClientesGEN"
        Me.ClientesGENBindingSource.DataSource = Me.GeneralDS
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(314, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "CURP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(140, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "R.F.C."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtRfc
        '
        Me.txtRfc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "RFC", True))
        Me.txtRfc.Location = New System.Drawing.Point(180, 53)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.ReadOnly = True
        Me.txtRfc.Size = New System.Drawing.Size(111, 20)
        Me.txtRfc.TabIndex = 78
        Me.txtRfc.TabStop = False
        '
        'txtDescTipo
        '
        Me.txtDescTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "TipoPersona", True))
        Me.txtDescTipo.Location = New System.Drawing.Point(84, 29)
        Me.txtDescTipo.Name = "txtDescTipo"
        Me.txtDescTipo.ReadOnly = True
        Me.txtDescTipo.Size = New System.Drawing.Size(536, 20)
        Me.txtDescTipo.TabIndex = 75
        Me.txtDescTipo.TabStop = False
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(12, 33)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(56, 16)
        Me.lblTipo.TabIndex = 74
        Me.lblTipo.Text = "Tipo"
        Me.lblTipo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtDescr
        '
        Me.txtDescr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "Descr", True))
        Me.txtDescr.Location = New System.Drawing.Point(84, 5)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.ReadOnly = True
        Me.txtDescr.Size = New System.Drawing.Size(536, 20)
        Me.txtDescr.TabIndex = 73
        Me.txtDescr.TabStop = False
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(56, 16)
        Me.lblName.TabIndex = 72
        Me.lblName.Text = "Nombre"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "Cliente", True))
        Me.txtPassword.Location = New System.Drawing.Point(84, 53)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(41, 20)
        Me.txtPassword.TabIndex = 70
        Me.txtPassword.TabStop = False
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(12, 57)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(72, 16)
        Me.lblPass.TabIndex = 71
        Me.lblPass.Text = "No. Cliente"
        Me.lblPass.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtCopos
        '
        Me.txtCopos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "Copos", True))
        Me.txtCopos.Location = New System.Drawing.Point(94, 153)
        Me.txtCopos.MaxLength = 5
        Me.txtCopos.Name = "txtCopos"
        Me.txtCopos.ReadOnly = True
        Me.txtCopos.Size = New System.Drawing.Size(71, 20)
        Me.txtCopos.TabIndex = 85
        Me.txtCopos.TabStop = False
        '
        'mtxtColonia
        '
        Me.mtxtColonia.BeepOnError = True
        Me.mtxtColonia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "Colonia", True))
        Me.mtxtColonia.Location = New System.Drawing.Point(150, 101)
        Me.mtxtColonia.Name = "mtxtColonia"
        Me.mtxtColonia.ReadOnly = True
        Me.mtxtColonia.Size = New System.Drawing.Size(342, 20)
        Me.mtxtColonia.TabIndex = 87
        Me.mtxtColonia.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Estado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGiro
        '
        Me.lblGiro.AutoSize = True
        Me.lblGiro.Location = New System.Drawing.Point(12, 308)
        Me.lblGiro.Name = "lblGiro"
        Me.lblGiro.Size = New System.Drawing.Size(86, 13)
        Me.lblGiro.TabIndex = 103
        Me.lblGiro.Text = "Giro del Negocio"
        Me.lblGiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMail2
        '
        Me.txtMail2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "EMail2", True))
        Me.txtMail2.Location = New System.Drawing.Point(169, 256)
        Me.txtMail2.Name = "txtMail2"
        Me.txtMail2.ReadOnly = True
        Me.txtMail2.Size = New System.Drawing.Size(368, 20)
        Me.txtMail2.TabIndex = 98
        Me.txtMail2.TabStop = False
        '
        'lblMail2
        '
        Me.lblMail2.AutoSize = True
        Me.lblMail2.Location = New System.Drawing.Point(12, 258)
        Me.lblMail2.Name = "lblMail2"
        Me.lblMail2.Size = New System.Drawing.Size(90, 13)
        Me.lblMail2.TabIndex = 102
        Me.lblMail2.Text = "EMail Secundario"
        Me.lblMail2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Ejecutivo que lo atiende"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(12, 234)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(76, 13)
        Me.lblMail.TabIndex = 100
        Me.lblMail.Text = "EMail Principal"
        Me.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMail1
        '
        Me.txtMail1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "EMail1", True))
        Me.txtMail1.Location = New System.Drawing.Point(169, 231)
        Me.txtMail1.Name = "txtMail1"
        Me.txtMail1.ReadOnly = True
        Me.txtMail1.Size = New System.Drawing.Size(368, 20)
        Me.txtMail1.TabIndex = 96
        Me.txtMail1.TabStop = False
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(403, 182)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(24, 13)
        Me.lblFax.TabIndex = 97
        Me.lblFax.Text = "Fax"
        Me.lblFax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFax
        '
        Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "Fax", True))
        Me.txtFax.Location = New System.Drawing.Point(433, 179)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ReadOnly = True
        Me.txtFax.Size = New System.Drawing.Size(104, 20)
        Me.txtFax.TabIndex = 95
        Me.txtFax.TabStop = False
        '
        'lblTelef
        '
        Me.lblTelef.AutoSize = True
        Me.lblTelef.Location = New System.Drawing.Point(12, 182)
        Me.lblTelef.Name = "lblTelef"
        Me.lblTelef.Size = New System.Drawing.Size(54, 13)
        Me.lblTelef.TabIndex = 94
        Me.lblTelef.Text = "Teléfonos"
        Me.lblTelef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelef1
        '
        Me.txtTelef1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "Telef1", True))
        Me.txtTelef1.Location = New System.Drawing.Point(84, 179)
        Me.txtTelef1.Name = "txtTelef1"
        Me.txtTelef1.ReadOnly = True
        Me.txtTelef1.Size = New System.Drawing.Size(104, 20)
        Me.txtTelef1.TabIndex = 89
        Me.txtTelef1.TabStop = False
        '
        'txtTelef2
        '
        Me.txtTelef2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "Telef2", True))
        Me.txtTelef2.Location = New System.Drawing.Point(189, 179)
        Me.txtTelef2.Name = "txtTelef2"
        Me.txtTelef2.ReadOnly = True
        Me.txtTelef2.Size = New System.Drawing.Size(104, 20)
        Me.txtTelef2.TabIndex = 91
        Me.txtTelef2.TabStop = False
        '
        'txtTelef3
        '
        Me.txtTelef3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "Telef3", True))
        Me.txtTelef3.Location = New System.Drawing.Point(293, 179)
        Me.txtTelef3.Name = "txtTelef3"
        Me.txtTelef3.ReadOnly = True
        Me.txtTelef3.Size = New System.Drawing.Size(104, 20)
        Me.txtTelef3.TabIndex = 93
        Me.txtTelef3.TabStop = False
        '
        'lblDeleg
        '
        Me.lblDeleg.Location = New System.Drawing.Point(12, 129)
        Me.lblDeleg.Name = "lblDeleg"
        Me.lblDeleg.Size = New System.Drawing.Size(134, 16)
        Me.lblDeleg.TabIndex = 92
        Me.lblDeleg.Text = "Delegación o Municipio"
        Me.lblDeleg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDelegacion
        '
        Me.txtDelegacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "Delegacion", True))
        Me.txtDelegacion.Location = New System.Drawing.Point(150, 127)
        Me.txtDelegacion.MaxLength = 45
        Me.txtDelegacion.Name = "txtDelegacion"
        Me.txtDelegacion.ReadOnly = True
        Me.txtDelegacion.Size = New System.Drawing.Size(342, 20)
        Me.txtDelegacion.TabIndex = 86
        Me.txtDelegacion.TabStop = False
        '
        'lblPostal
        '
        Me.lblPostal.AutoSize = True
        Me.lblPostal.Location = New System.Drawing.Point(12, 155)
        Me.lblPostal.Name = "lblPostal"
        Me.lblPostal.Size = New System.Drawing.Size(72, 13)
        Me.lblPostal.TabIndex = 90
        Me.lblPostal.Text = "Código Postal"
        Me.lblPostal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEstado
        '
        Me.txtEstado.AcceptsReturn = True
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "DescPlaza", True))
        Me.txtEstado.Location = New System.Drawing.Point(223, 153)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(269, 20)
        Me.txtEstado.TabIndex = 84
        Me.txtEstado.TabStop = False
        '
        'lblColonia
        '
        Me.lblColonia.Location = New System.Drawing.Point(12, 103)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(134, 16)
        Me.lblColonia.TabIndex = 88
        Me.lblColonia.Text = "Colonia (solo el nombre)"
        Me.lblColonia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCalle
        '
        Me.lblCalle.Location = New System.Drawing.Point(12, 81)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(64, 16)
        Me.lblCalle.TabIndex = 83
        Me.lblCalle.Text = "Calle"
        Me.lblCalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCalle
        '
        Me.txtCalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "Calle", True))
        Me.txtCalle.Location = New System.Drawing.Point(84, 77)
        Me.txtCalle.MaxLength = 45
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.ReadOnly = True
        Me.txtCalle.Size = New System.Drawing.Size(536, 20)
        Me.txtCalle.TabIndex = 82
        Me.txtCalle.TabStop = False
        '
        'TxtGiro
        '
        Me.TxtGiro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "DescGiro", True))
        Me.TxtGiro.Location = New System.Drawing.Point(169, 308)
        Me.TxtGiro.Name = "TxtGiro"
        Me.TxtGiro.ReadOnly = True
        Me.TxtGiro.Size = New System.Drawing.Size(368, 20)
        Me.TxtGiro.TabIndex = 106
        Me.TxtGiro.TabStop = False
        '
        'TxtProm
        '
        Me.TxtProm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "DescPromotor", True))
        Me.TxtProm.Location = New System.Drawing.Point(169, 282)
        Me.TxtProm.Name = "TxtProm"
        Me.TxtProm.ReadOnly = True
        Me.TxtProm.Size = New System.Drawing.Size(368, 20)
        Me.TxtProm.TabIndex = 107
        Me.TxtProm.TabStop = False
        '
        'TxtActEco
        '
        Me.TxtActEco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "ActividadEco", True))
        Me.TxtActEco.Location = New System.Drawing.Point(169, 334)
        Me.TxtActEco.Name = "TxtActEco"
        Me.TxtActEco.ReadOnly = True
        Me.TxtActEco.Size = New System.Drawing.Size(368, 20)
        Me.TxtActEco.TabIndex = 109
        Me.TxtActEco.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 13)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Actividad Económica (PLD)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtSucursal
        '
        Me.TxtSucursal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "Nombre_Sucursal", True))
        Me.TxtSucursal.Location = New System.Drawing.Point(169, 205)
        Me.TxtSucursal.Name = "TxtSucursal"
        Me.TxtSucursal.ReadOnly = True
        Me.TxtSucursal.Size = New System.Drawing.Size(368, 20)
        Me.TxtSucursal.TabIndex = 111
        Me.TxtSucursal.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Sucursal"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtRiesgo
        '
        Me.TxtRiesgo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "GruposRiesgo", True))
        Me.TxtRiesgo.Location = New System.Drawing.Point(122, 360)
        Me.TxtRiesgo.Name = "TxtRiesgo"
        Me.TxtRiesgo.ReadOnly = True
        Me.TxtRiesgo.Size = New System.Drawing.Size(387, 20)
        Me.TxtRiesgo.TabIndex = 113
        Me.TxtRiesgo.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Grupo de Negocios"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnRiesgo
        '
        Me.BtnRiesgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRiesgo.Location = New System.Drawing.Point(515, 356)
        Me.BtnRiesgo.Name = "BtnRiesgo"
        Me.BtnRiesgo.Size = New System.Drawing.Size(51, 23)
        Me.BtnRiesgo.TabIndex = 116
        Me.BtnRiesgo.Text = "Det. GN"
        Me.BtnRiesgo.UseVisualStyleBackColor = True
        '
        'BtoRiesgoComun
        '
        Me.BtoRiesgoComun.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtoRiesgoComun.Location = New System.Drawing.Point(143, 387)
        Me.BtoRiesgoComun.Name = "BtoRiesgoComun"
        Me.BtoRiesgoComun.Size = New System.Drawing.Size(150, 23)
        Me.BtoRiesgoComun.TabIndex = 117
        Me.BtoRiesgoComun.Text = "Cálculo Riesgo Común "
        Me.BtoRiesgoComun.UseVisualStyleBackColor = True
        '
        'TxtIDGR
        '
        Me.TxtIDGR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesGENBindingSource, "id_GrupoRiesgo", True))
        Me.TxtIDGR.Location = New System.Drawing.Point(170, 360)
        Me.TxtIDGR.Name = "TxtIDGR"
        Me.TxtIDGR.ReadOnly = True
        Me.TxtIDGR.Size = New System.Drawing.Size(12, 20)
        Me.TxtIDGR.TabIndex = 118
        '
        'TxtIDRC
        '
        Me.TxtIDRC.Location = New System.Drawing.Point(143, 360)
        Me.TxtIDRC.Name = "TxtIDRC"
        Me.TxtIDRC.ReadOnly = True
        Me.TxtIDRC.Size = New System.Drawing.Size(20, 20)
        Me.TxtIDRC.TabIndex = 119
        '
        'BttGR
        '
        Me.BttGR.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttGR.Location = New System.Drawing.Point(569, 356)
        Me.BttGR.Name = "BttGR"
        Me.BttGR.Size = New System.Drawing.Size(52, 23)
        Me.BttGR.TabIndex = 120
        Me.BttGR.Text = "Saldo GN"
        Me.BttGR.UseVisualStyleBackColor = True
        '
        'ClientesGENTableAdapter
        '
        Me.ClientesGENTableAdapter.ClearBeforeFill = True
        '
        'FrmGruposClientesConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 415)
        Me.Controls.Add(Me.BttGR)
        Me.Controls.Add(Me.BtoRiesgoComun)
        Me.Controls.Add(Me.BtnRiesgo)
        Me.Controls.Add(Me.TxtRiesgo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtSucursal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtActEco)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtProm)
        Me.Controls.Add(Me.TxtGiro)
        Me.Controls.Add(Me.txtCopos)
        Me.Controls.Add(Me.mtxtColonia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGiro)
        Me.Controls.Add(Me.txtMail2)
        Me.Controls.Add(Me.lblMail2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.txtMail1)
        Me.Controls.Add(Me.lblFax)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.lblTelef)
        Me.Controls.Add(Me.txtTelef1)
        Me.Controls.Add(Me.txtTelef2)
        Me.Controls.Add(Me.txtTelef3)
        Me.Controls.Add(Me.lblDeleg)
        Me.Controls.Add(Me.txtDelegacion)
        Me.Controls.Add(Me.lblPostal)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.lblColonia)
        Me.Controls.Add(Me.lblCalle)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.mtxtCURP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRfc)
        Me.Controls.Add(Me.txtDescTipo)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.txtDescr)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.TxtIDRC)
        Me.Controls.Add(Me.TxtIDGR)
        Me.Name = "FrmGruposClientesConsulta"
        Me.Text = "Consulta de Cliente"
        CType(Me.ClientesGENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents GeneralDS As Agil.GeneralDS
    Friend WithEvents ClientesGENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesGENTableAdapter As Agil.GeneralDSTableAdapters.ClientesGENTableAdapter
    Friend WithEvents mtxtCURP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRfc As System.Windows.Forms.TextBox
    Friend WithEvents txtDescTipo As System.Windows.Forms.TextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents txtDescr As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtCopos As System.Windows.Forms.TextBox
    Friend WithEvents mtxtColonia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblGiro As System.Windows.Forms.Label
    Friend WithEvents txtMail2 As System.Windows.Forms.TextBox
    Friend WithEvents lblMail2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents txtMail1 As System.Windows.Forms.TextBox
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
    Friend WithEvents TxtGiro As System.Windows.Forms.TextBox
    Friend WithEvents TxtProm As System.Windows.Forms.TextBox
    Friend WithEvents TxtActEco As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtSucursal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtRiesgo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnRiesgo As System.Windows.Forms.Button
    Friend WithEvents BtoRiesgoComun As System.Windows.Forms.Button
    Friend WithEvents TxtIDGR As System.Windows.Forms.TextBox
    Friend WithEvents TxtIDRC As System.Windows.Forms.TextBox
    Friend WithEvents BttGR As System.Windows.Forms.Button
End Class
