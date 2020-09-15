<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJURBitacora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CmbCliente = New System.Windows.Forms.ComboBox()
        Me.ListaClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JuridicoDS = New Agil.JuridicoDS()
        Me.rbActivos = New System.Windows.Forms.RadioButton()
        Me.rbNoACTIVOS = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbATrad = New System.Windows.Forms.RadioButton()
        Me.rbAAvio = New System.Windows.Forms.RadioButton()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloPagareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreSucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwActivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTTermino = New System.Windows.Forms.DateTimePicker()
        Me.DTIniCto = New System.Windows.Forms.DateTimePicker()
        Me.DTAutorizacion = New System.Windows.Forms.DateTimePicker()
        Me.cbHipotec = New System.Windows.Forms.CheckBox()
        Me.cbPrenda = New System.Windows.Forms.CheckBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTProcuNot = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DTIngRPP = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNotario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTFirmaNot = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTFirmaPro = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTIngNot = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DTEntGVSucur = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DTInscripRUG = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTEntregaGV = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DTEntregaNot = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtObservaMC = New System.Windows.Forms.TextBox()
        Me.txtObserva = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bSave = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DTEntFisica = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DTEntGV = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DTFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRecibo = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.ListaClientesTableAdapter = New Agil.JuridicoDSTableAdapters.ListaClientesTableAdapter()
        Me.SucursalesTableAdapter = New Agil.JuridicoDSTableAdapters.SucursalesTableAdapter()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Vw_ActivosTableAdapter = New Agil.JuridicoDSTableAdapters.Vw_ActivosTableAdapter()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.CmbCtos = New System.Windows.Forms.ComboBox()
        Me.DTFechaLib = New System.Windows.Forms.DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.CmbLib = New System.Windows.Forms.ComboBox()
        CType(Me.ListaClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwActivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbCliente
        '
        Me.CmbCliente.DataSource = Me.ListaClientesBindingSource
        Me.CmbCliente.DisplayMember = "Descr"
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(18, 35)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(626, 21)
        Me.CmbCliente.TabIndex = 0
        Me.CmbCliente.ValueMember = "Cliente"
        '
        'ListaClientesBindingSource
        '
        Me.ListaClientesBindingSource.DataMember = "ListaClientes"
        Me.ListaClientesBindingSource.DataSource = Me.JuridicoDS
        '
        'JuridicoDS
        '
        Me.JuridicoDS.DataSetName = "JuridicoDS"
        Me.JuridicoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rbActivos
        '
        Me.rbActivos.AutoSize = True
        Me.rbActivos.Location = New System.Drawing.Point(694, 13)
        Me.rbActivos.Name = "rbActivos"
        Me.rbActivos.Size = New System.Drawing.Size(143, 17)
        Me.rbActivos.TabIndex = 1
        Me.rbActivos.TabStop = True
        Me.rbActivos.Text = "Solo Contratos ACTIVOS"
        Me.rbActivos.UseVisualStyleBackColor = True
        '
        'rbNoACTIVOS
        '
        Me.rbNoACTIVOS.AutoSize = True
        Me.rbNoACTIVOS.Location = New System.Drawing.Point(882, 12)
        Me.rbNoACTIVOS.Name = "rbNoACTIVOS"
        Me.rbNoACTIVOS.Size = New System.Drawing.Size(55, 17)
        Me.rbNoACTIVOS.TabIndex = 2
        Me.rbNoACTIVOS.TabStop = True
        Me.rbNoACTIVOS.Text = "Todos"
        Me.rbNoACTIVOS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbATrad)
        Me.GroupBox1.Controls.Add(Me.rbAAvio)
        Me.GroupBox1.Location = New System.Drawing.Point(684, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 63)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'rbATrad
        '
        Me.rbATrad.AutoSize = True
        Me.rbATrad.Location = New System.Drawing.Point(10, 35)
        Me.rbATrad.Name = "rbATrad"
        Me.rbATrad.Size = New System.Drawing.Size(88, 17)
        Me.rbATrad.TabIndex = 1
        Me.rbATrad.TabStop = True
        Me.rbATrad.Text = "Activos Trad."
        Me.rbATrad.UseVisualStyleBackColor = True
        '
        'rbAAvio
        '
        Me.rbAAvio.AutoSize = True
        Me.rbAAvio.Location = New System.Drawing.Point(10, 15)
        Me.rbAAvio.Name = "rbAAvio"
        Me.rbAAvio.Size = New System.Drawing.Size(84, 17)
        Me.rbAAvio.TabIndex = 0
        Me.rbAAvio.TabStop = True
        Me.rbAAvio.Text = "Activos Avio"
        Me.rbAAvio.UseVisualStyleBackColor = True
        '
        'cbSucursal
        '
        Me.cbSucursal.DataSource = Me.SucursalesBindingSource
        Me.cbSucursal.DisplayMember = "Nombre_Sucursal"
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(851, 66)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(144, 21)
        Me.cbSucursal.TabIndex = 4
        Me.cbSucursal.ValueMember = "Nombre_Sucursal"
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.JuridicoDS
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.CicloDataGridViewTextBoxColumn, Me.CicloPagareDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn, Me.NombreSucursalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VwActivosBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.Location = New System.Drawing.Point(21, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.RowTemplate.Height = 20
        Me.DataGridView1.Size = New System.Drawing.Size(972, 133)
        Me.DataGridView1.TabIndex = 40
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.FillWeight = 97.78019!
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Contrato"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CicloDataGridViewTextBoxColumn
        '
        Me.CicloDataGridViewTextBoxColumn.DataPropertyName = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.FillWeight = 55.18888!
        Me.CicloDataGridViewTextBoxColumn.HeaderText = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.Name = "CicloDataGridViewTextBoxColumn"
        Me.CicloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CicloPagareDataGridViewTextBoxColumn
        '
        Me.CicloPagareDataGridViewTextBoxColumn.DataPropertyName = "CicloPagare"
        Me.CicloPagareDataGridViewTextBoxColumn.FillWeight = 78.12829!
        Me.CicloPagareDataGridViewTextBoxColumn.HeaderText = "CicloPagare"
        Me.CicloPagareDataGridViewTextBoxColumn.Name = "CicloPagareDataGridViewTextBoxColumn"
        Me.CicloPagareDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescrDataGridViewTextBoxColumn
        '
        Me.DescrDataGridViewTextBoxColumn.DataPropertyName = "Descr"
        Me.DescrDataGridViewTextBoxColumn.FillWeight = 234.5177!
        Me.DescrDataGridViewTextBoxColumn.HeaderText = "Nombre del Cliente"
        Me.DescrDataGridViewTextBoxColumn.Name = "DescrDataGridViewTextBoxColumn"
        Me.DescrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.FillWeight = 78.12829!
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoCreditoDataGridViewTextBoxColumn
        '
        Me.TipoCreditoDataGridViewTextBoxColumn.DataPropertyName = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.FillWeight = 78.12829!
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreSucursalDataGridViewTextBoxColumn
        '
        Me.NombreSucursalDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Sucursal"
        Me.NombreSucursalDataGridViewTextBoxColumn.FillWeight = 78.12829!
        Me.NombreSucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.NombreSucursalDataGridViewTextBoxColumn.Name = "NombreSucursalDataGridViewTextBoxColumn"
        Me.NombreSucursalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwActivosBindingSource
        '
        Me.VwActivosBindingSource.DataMember = "Vw_Activos"
        Me.VwActivosBindingSource.DataSource = Me.JuridicoDS
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(719, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Fecha Termino Contrato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Fecha Inicio Contrato"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Fecha Autorización"
        '
        'DTTermino
        '
        Me.DTTermino.Enabled = False
        Me.DTTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTTermino.Location = New System.Drawing.Point(846, 254)
        Me.DTTermino.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTTermino.Name = "DTTermino"
        Me.DTTermino.Size = New System.Drawing.Size(84, 20)
        Me.DTTermino.TabIndex = 53
        Me.DTTermino.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'DTIniCto
        '
        Me.DTIniCto.Enabled = False
        Me.DTIniCto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTIniCto.Location = New System.Drawing.Point(601, 254)
        Me.DTIniCto.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTIniCto.Name = "DTIniCto"
        Me.DTIniCto.Size = New System.Drawing.Size(84, 20)
        Me.DTIniCto.TabIndex = 52
        Me.DTIniCto.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'DTAutorizacion
        '
        Me.DTAutorizacion.Enabled = False
        Me.DTAutorizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTAutorizacion.Location = New System.Drawing.Point(366, 254)
        Me.DTAutorizacion.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTAutorizacion.Name = "DTAutorizacion"
        Me.DTAutorizacion.Size = New System.Drawing.Size(84, 20)
        Me.DTAutorizacion.TabIndex = 51
        Me.DTAutorizacion.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'cbHipotec
        '
        Me.cbHipotec.AutoSize = True
        Me.cbHipotec.Enabled = False
        Me.cbHipotec.Location = New System.Drawing.Point(49, 271)
        Me.cbHipotec.Name = "cbHipotec"
        Me.cbHipotec.Size = New System.Drawing.Size(125, 17)
        Me.cbHipotec.TabIndex = 50
        Me.cbHipotec.Text = "Garantía Hipotecaria"
        Me.cbHipotec.UseVisualStyleBackColor = True
        '
        'cbPrenda
        '
        Me.cbPrenda.AutoSize = True
        Me.cbPrenda.Enabled = False
        Me.cbPrenda.Location = New System.Drawing.Point(49, 254)
        Me.cbPrenda.Name = "cbPrenda"
        Me.cbPrenda.Size = New System.Drawing.Size(116, 17)
        Me.cbPrenda.TabIndex = 49
        Me.cbPrenda.Text = "Garantía Prendaria"
        Me.cbPrenda.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(16, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(197, 13)
        Me.Label26.TabIndex = 88
        Me.Label26.Text = "Elige Nombre del Cliente o Razón Social"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(848, 45)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 13)
        Me.Label29.TabIndex = 100
        Me.Label29.Text = "Sucursal"
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(492, 318)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(57, 20)
        Me.txtHora.TabIndex = 105
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(15, 352)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(166, 17)
        Me.Label21.TabIndex = 116
        Me.Label21.Text = "INDICADORES NOTARIA"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(15, 297)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(130, 17)
        Me.Label20.TabIndex = 115
        Me.Label20.Text = "AGENDA INTERNA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(544, 372)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 13)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Fecha Procurar en Notaria"
        '
        'DTProcuNot
        '
        Me.DTProcuNot.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTProcuNot.Location = New System.Drawing.Point(688, 368)
        Me.DTProcuNot.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTProcuNot.Name = "DTProcuNot"
        Me.DTProcuNot.Size = New System.Drawing.Size(84, 20)
        Me.DTProcuNot.TabIndex = 113
        Me.DTProcuNot.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(257, 375)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 13)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Fecha Ingreso RPP y/o Ratif."
        '
        'DTIngRPP
        '
        Me.DTIngRPP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTIngRPP.Location = New System.Drawing.Point(415, 371)
        Me.DTIngRPP.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTIngRPP.Name = "DTIngRPP"
        Me.DTIngRPP.Size = New System.Drawing.Size(84, 20)
        Me.DTIngRPP.TabIndex = 111
        Me.DTIngRPP.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(575, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Notario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(457, 322)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Hora"
        '
        'txtNotario
        '
        Me.txtNotario.Location = New System.Drawing.Point(622, 317)
        Me.txtNotario.Name = "txtNotario"
        Me.txtNotario.Size = New System.Drawing.Size(381, 20)
        Me.txtNotario.TabIndex = 108
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Fecha Firma Notaria"
        '
        'DTFirmaNot
        '
        Me.DTFirmaNot.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFirmaNot.Location = New System.Drawing.Point(129, 371)
        Me.DTFirmaNot.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTFirmaNot.Name = "DTFirmaNot"
        Me.DTFirmaNot.Size = New System.Drawing.Size(84, 20)
        Me.DTFirmaNot.TabIndex = 106
        Me.DTFirmaNot.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Fecha Firma Productor"
        '
        'DTFirmaPro
        '
        Me.DTFirmaPro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFirmaPro.Location = New System.Drawing.Point(351, 316)
        Me.DTFirmaPro.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTFirmaPro.Name = "DTFirmaPro"
        Me.DTFirmaPro.Size = New System.Drawing.Size(84, 20)
        Me.DTFirmaPro.TabIndex = 103
        Me.DTFirmaPro.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Fecha Ingreso Notaria"
        '
        'DTIngNot
        '
        Me.DTIngNot.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTIngNot.Location = New System.Drawing.Point(132, 316)
        Me.DTIngNot.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTIngNot.Name = "DTIngNot"
        Me.DTIngNot.Size = New System.Drawing.Size(84, 20)
        Me.DTIngNot.TabIndex = 101
        Me.DTIngNot.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(15, 401)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(148, 17)
        Me.Label22.TabIndex = 125
        Me.Label22.Text = "REGISTRO RUG - GV"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(776, 425)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 13)
        Me.Label14.TabIndex = 124
        Me.Label14.Text = "Fecha Entrega GV Sucursal"
        '
        'DTEntGVSucur
        '
        Me.DTEntGVSucur.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTEntGVSucur.Location = New System.Drawing.Point(920, 421)
        Me.DTEntGVSucur.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTEntGVSucur.Name = "DTEntGVSucur"
        Me.DTEntGVSucur.Size = New System.Drawing.Size(84, 20)
        Me.DTEntGVSucur.TabIndex = 123
        Me.DTEntGVSucur.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(523, 425)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 13)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "Fecha Inscripción RUG"
        '
        'DTInscripRUG
        '
        Me.DTInscripRUG.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTInscripRUG.Location = New System.Drawing.Point(653, 421)
        Me.DTInscripRUG.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTInscripRUG.Name = "DTInscripRUG"
        Me.DTInscripRUG.Size = New System.Drawing.Size(84, 20)
        Me.DTInscripRUG.TabIndex = 121
        Me.DTInscripRUG.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(250, 424)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 13)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "Fecha Entrega  GV sin RUG"
        '
        'DTEntregaGV
        '
        Me.DTEntregaGV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTEntregaGV.Location = New System.Drawing.Point(400, 420)
        Me.DTEntregaGV.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTEntregaGV.Name = "DTEntregaGV"
        Me.DTEntregaGV.Size = New System.Drawing.Size(84, 20)
        Me.DTEntregaGV.TabIndex = 119
        Me.DTEntregaGV.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 424)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 13)
        Me.Label13.TabIndex = 118
        Me.Label13.Text = "Fecha Entrega Notaria"
        '
        'DTEntregaNot
        '
        Me.DTEntregaNot.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTEntregaNot.Location = New System.Drawing.Point(134, 420)
        Me.DTEntregaNot.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTEntregaNot.Name = "DTEntregaNot"
        Me.DTEntregaNot.Size = New System.Drawing.Size(84, 20)
        Me.DTEntregaNot.TabIndex = 117
        Me.DTEntregaNot.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(15, 543)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(143, 13)
        Me.Label27.TabIndex = 143
        Me.Label27.Text = "Observaciones Mesa Control"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(15, 451)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(78, 13)
        Me.Label24.TabIndex = 142
        Me.Label24.Text = "Observaciones"
        '
        'txtObservaMC
        '
        Me.txtObservaMC.Enabled = False
        Me.txtObservaMC.Location = New System.Drawing.Point(168, 538)
        Me.txtObservaMC.Name = "txtObservaMC"
        Me.txtObservaMC.Size = New System.Drawing.Size(381, 20)
        Me.txtObservaMC.TabIndex = 141
        '
        'txtObserva
        '
        Me.txtObserva.Location = New System.Drawing.Point(168, 448)
        Me.txtObserva.Name = "txtObserva"
        Me.txtObserva.Size = New System.Drawing.Size(381, 20)
        Me.txtObserva.TabIndex = 140
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(572, 570)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 139
        Me.Button1.Text = "Reporte Global"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bSave
        '
        Me.bSave.Location = New System.Drawing.Point(731, 570)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(114, 23)
        Me.bSave.TabIndex = 138
        Me.bSave.Text = "Guadar Datos"
        Me.bSave.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.Location = New System.Drawing.Point(886, 570)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(114, 23)
        Me.bSalir.TabIndex = 137
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(15, 486)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(141, 17)
        Me.Label23.TabIndex = 136
        Me.Label23.Text = "MESA DE CONTROL"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(796, 510)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 13)
        Me.Label19.TabIndex = 135
        Me.Label19.Text = "Fecha Entrega Física"
        '
        'DTEntFisica
        '
        Me.DTEntFisica.Enabled = False
        Me.DTEntFisica.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTEntFisica.Location = New System.Drawing.Point(920, 506)
        Me.DTEntFisica.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTEntFisica.Name = "DTEntFisica"
        Me.DTEntFisica.Size = New System.Drawing.Size(84, 20)
        Me.DTEntFisica.TabIndex = 134
        Me.DTEntFisica.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(569, 510)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 13)
        Me.Label18.TabIndex = 133
        Me.Label18.Text = "Fecha Entrega GV "
        '
        'DTEntGV
        '
        Me.DTEntGV.Enabled = False
        Me.DTEntGV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTEntGV.Location = New System.Drawing.Point(674, 506)
        Me.DTEntGV.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTEntGV.Name = "DTEntGV"
        Me.DTEntGV.Size = New System.Drawing.Size(84, 20)
        Me.DTEntGV.TabIndex = 132
        Me.DTEntGV.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(353, 510)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 13)
        Me.Label17.TabIndex = 131
        Me.Label17.Text = "Fecha de Pago"
        '
        'DTFechaPago
        '
        Me.DTFechaPago.Enabled = False
        Me.DTFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaPago.Location = New System.Drawing.Point(442, 506)
        Me.DTFechaPago.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTFechaPago.Name = "DTFechaPago"
        Me.DTFechaPago.Size = New System.Drawing.Size(84, 20)
        Me.DTFechaPago.TabIndex = 130
        Me.DTFechaPago.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(187, 514)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 129
        Me.Label16.Text = "No. Recibo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 514)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 128
        Me.Label15.Text = "Costo"
        '
        'txtRecibo
        '
        Me.txtRecibo.Enabled = False
        Me.txtRecibo.Location = New System.Drawing.Point(258, 507)
        Me.txtRecibo.Name = "txtRecibo"
        Me.txtRecibo.Size = New System.Drawing.Size(57, 20)
        Me.txtRecibo.TabIndex = 127
        '
        'txtCosto
        '
        Me.txtCosto.Enabled = False
        Me.txtCosto.Location = New System.Drawing.Point(58, 507)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(93, 20)
        Me.txtCosto.TabIndex = 126
        '
        'ListaClientesTableAdapter
        '
        Me.ListaClientesTableAdapter.ClearBeforeFill = True
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(456, 300)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(111, 13)
        Me.Label25.TabIndex = 144
        Me.Label25.Text = "Créditos Tradicionales"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(111, 81)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(137, 13)
        Me.Label28.TabIndex = 145
        Me.Label28.Text = "Información de los Créditos "
        '
        'Vw_ActivosTableAdapter
        '
        Me.Vw_ActivosTableAdapter.ClearBeforeFill = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(809, 401)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(11, 15)
        Me.Label30.TabIndex = 147
        Me.Label30.Text = " "
        '
        'CmbCtos
        '
        Me.CmbCtos.FormattingEnabled = True
        Me.CmbCtos.Location = New System.Drawing.Point(21, 78)
        Me.CmbCtos.Name = "CmbCtos"
        Me.CmbCtos.Size = New System.Drawing.Size(80, 21)
        Me.CmbCtos.TabIndex = 149
        '
        'DTFechaLib
        '
        Me.DTFechaLib.Enabled = False
        Me.DTFechaLib.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaLib.Location = New System.Drawing.Point(846, 537)
        Me.DTFechaLib.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTFechaLib.Name = "DTFechaLib"
        Me.DTFechaLib.Size = New System.Drawing.Size(84, 20)
        Me.DTFechaLib.TabIndex = 155
        Me.DTFechaLib.Value = New Date(1900, 1, 1, 16, 24, 0, 0)
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(729, 543)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 13)
        Me.Label32.TabIndex = 154
        Me.Label32.Text = "Fecha de Liberacion"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(599, 543)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 13)
        Me.Label31.TabIndex = 153
        Me.Label31.Text = "Liberado"
        '
        'CmbLib
        '
        Me.CmbLib.Enabled = False
        Me.CmbLib.FormattingEnabled = True
        Me.CmbLib.Items.AddRange(New Object() {"SI", "NO"})
        Me.CmbLib.Location = New System.Drawing.Point(656, 538)
        Me.CmbLib.Name = "CmbLib"
        Me.CmbLib.Size = New System.Drawing.Size(42, 21)
        Me.CmbLib.TabIndex = 152
        '
        'frmJURBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 612)
        Me.Controls.Add(Me.DTFechaLib)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.CmbLib)
        Me.Controls.Add(Me.CmbCtos)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtObservaMC)
        Me.Controls.Add(Me.txtObserva)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.DTEntFisica)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.DTEntGV)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DTFechaPago)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtRecibo)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DTEntGVSucur)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DTInscripRUG)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DTEntregaGV)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DTEntregaNot)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DTProcuNot)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DTIngRPP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNotario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DTFirmaNot)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTFirmaPro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DTIngNot)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTTermino)
        Me.Controls.Add(Me.DTIniCto)
        Me.Controls.Add(Me.DTAutorizacion)
        Me.Controls.Add(Me.cbHipotec)
        Me.Controls.Add(Me.cbPrenda)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbSucursal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rbNoACTIVOS)
        Me.Controls.Add(Me.rbActivos)
        Me.Controls.Add(Me.CmbCliente)
        Me.Name = "frmJURBitacora"
        Me.Text = "frmJURBitacora"
        CType(Me.ListaClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwActivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents rbActivos As System.Windows.Forms.RadioButton
    Friend WithEvents rbNoACTIVOS As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbATrad As System.Windows.Forms.RadioButton
    Friend WithEvents rbAAvio As System.Windows.Forms.RadioButton
    Friend WithEvents cbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTIniCto As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTAutorizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbHipotec As System.Windows.Forms.CheckBox
    Friend WithEvents cbPrenda As System.Windows.Forms.CheckBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DTProcuNot As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DTIngRPP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNotario As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DTFirmaNot As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTFirmaPro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTIngNot As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DTEntGVSucur As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DTInscripRUG As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DTEntregaGV As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DTEntregaNot As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtObservaMC As System.Windows.Forms.TextBox
    Friend WithEvents txtObserva As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bSave As System.Windows.Forms.Button
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DTEntFisica As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DTEntGV As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DTFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtRecibo As System.Windows.Forms.TextBox
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents JuridicoDS As Agil.JuridicoDS
    Friend WithEvents ListaClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaClientesTableAdapter As Agil.JuridicoDSTableAdapters.ListaClientesTableAdapter
    Friend WithEvents SucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SucursalesTableAdapter As Agil.JuridicoDSTableAdapters.SucursalesTableAdapter
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CicloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CicloPagareDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreSucursalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VwActivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_ActivosTableAdapter As Agil.JuridicoDSTableAdapters.Vw_ActivosTableAdapter
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents CmbCtos As System.Windows.Forms.ComboBox
    Friend WithEvents DTFechaLib As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents CmbLib As System.Windows.Forms.ComboBox
End Class
