<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargosExtras
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblPagos = New System.Windows.Forms.Label()
        Me.btnAdeudos = New System.Windows.Forms.Button()
        Me.txtAdeudo = New System.Windows.Forms.TextBox()
        Me.btnEditarAdeudo = New System.Windows.Forms.Button()
        Me.cbDeudores = New System.Windows.Forms.ComboBox()
        Me.DeudoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS1 = New Agil.PromocionDS()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnIncluirCargo = New System.Windows.Forms.Button()
        Me.dgvCargosRegistrados = New System.Windows.Forms.DataGridView()
        Me.ContratoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetraDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDelClienteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDelCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdeudoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoratoriosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaMoratoriosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDelCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCargoExtraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargosExtrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaCargo = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCargoTotal = New System.Windows.Forms.TextBox()
        Me.txtIvaMoratorios = New System.Windows.Forms.TextBox()
        Me.txtMoratorios = New System.Windows.Forms.TextBox()
        Me.btnOmitirCargo = New System.Windows.Forms.Button()
        Me.txtTarjeta = New System.Windows.Forms.TextBox()
        Me.txtCuentaBancomer = New System.Windows.Forms.TextBox()
        Me.txtCuentaCLABE = New System.Windows.Forms.TextBox()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.lblTarjeta = New System.Windows.Forms.Label()
        Me.lblCuentaBancomer = New System.Windows.Forms.Label()
        Me.lblCuentaCLABE = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMensajeFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaMora = New System.Windows.Forms.DateTimePicker()
        Me.dgvAdeudos = New System.Windows.Forms.DataGridView()
        Me.ContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDelClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdeudoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaCLABEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumTarjetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaEJEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitularCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiparDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiferDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FevenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FepagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaIVAClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSaldos = New System.Windows.Forms.Label()
        Me.FacturasTableAdapter = New Agil.PromocionDSTableAdapters.FacturasTableAdapter()
        Me.Cargos_ExtrasTableAdapter = New Agil.PromocionDSTableAdapters.Cargos_ExtrasTableAdapter()
        Me.DeudoresTableAdapter = New Agil.PromocionDSTableAdapters.DeudoresTableAdapter()
        Me.Cargos_ExtrasTableAdapter1 = New Agil.PromocionDSTableAdapters.Cargos_ExtrasTableAdapter()
        Me.ChkProc = New System.Windows.Forms.CheckBox()
        CType(Me.DeudoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCargosRegistrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargosExtrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAdeudos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPagos
        '
        Me.lblPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagos.Location = New System.Drawing.Point(17, 9)
        Me.lblPagos.Name = "lblPagos"
        Me.lblPagos.Size = New System.Drawing.Size(651, 23)
        Me.lblPagos.TabIndex = 22
        Me.lblPagos.Text = "Estos son los ADEUDOS que se añadirán al cobro domiciliado (adicional a los venci" &
    "mientos domiciliados)"
        Me.lblPagos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnAdeudos
        '
        Me.btnAdeudos.ForeColor = System.Drawing.Color.Black
        Me.btnAdeudos.Location = New System.Drawing.Point(559, 236)
        Me.btnAdeudos.Name = "btnAdeudos"
        Me.btnAdeudos.Size = New System.Drawing.Size(86, 23)
        Me.btnAdeudos.TabIndex = 23
        Me.btnAdeudos.Text = "Ver adeudos"
        Me.btnAdeudos.UseVisualStyleBackColor = True
        '
        'txtAdeudo
        '
        Me.txtAdeudo.Location = New System.Drawing.Point(381, 22)
        Me.txtAdeudo.Name = "txtAdeudo"
        Me.txtAdeudo.Size = New System.Drawing.Size(100, 20)
        Me.txtAdeudo.TabIndex = 25
        Me.txtAdeudo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnEditarAdeudo
        '
        Me.btnEditarAdeudo.ForeColor = System.Drawing.Color.Black
        Me.btnEditarAdeudo.Location = New System.Drawing.Point(748, 84)
        Me.btnEditarAdeudo.Name = "btnEditarAdeudo"
        Me.btnEditarAdeudo.Size = New System.Drawing.Size(109, 23)
        Me.btnEditarAdeudo.TabIndex = 26
        Me.btnEditarAdeudo.Text = "Editar adeudo"
        Me.btnEditarAdeudo.UseVisualStyleBackColor = True
        '
        'cbDeudores
        '
        Me.cbDeudores.DataSource = Me.DeudoresBindingSource
        Me.cbDeudores.DisplayMember = "Descr"
        Me.cbDeudores.FormattingEnabled = True
        Me.cbDeudores.Location = New System.Drawing.Point(17, 236)
        Me.cbDeudores.Name = "cbDeudores"
        Me.cbDeudores.Size = New System.Drawing.Size(533, 21)
        Me.cbDeudores.TabIndex = 28
        Me.cbDeudores.ValueMember = "Cliente"
        '
        'DeudoresBindingSource
        '
        Me.DeudoresBindingSource.DataMember = "Deudores"
        Me.DeudoresBindingSource.DataSource = Me.PromocionDS1
        '
        'PromocionDS1
        '
        Me.PromocionDS1.DataSetName = "PromocionDS"
        Me.PromocionDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(537, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Selecciona el cliente y haz click en el botón para ver sus adeudos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnIncluirCargo
        '
        Me.btnIncluirCargo.Enabled = False
        Me.btnIncluirCargo.ForeColor = System.Drawing.Color.Black
        Me.btnIncluirCargo.Location = New System.Drawing.Point(508, 142)
        Me.btnIncluirCargo.Name = "btnIncluirCargo"
        Me.btnIncluirCargo.Size = New System.Drawing.Size(102, 23)
        Me.btnIncluirCargo.TabIndex = 43
        Me.btnIncluirCargo.Text = "Incluir cargo "
        Me.btnIncluirCargo.UseVisualStyleBackColor = True
        '
        'dgvCargosRegistrados
        '
        Me.dgvCargosRegistrados.AllowUserToAddRows = False
        Me.dgvCargosRegistrados.AllowUserToDeleteRows = False
        Me.dgvCargosRegistrados.AllowUserToResizeColumns = False
        Me.dgvCargosRegistrados.AllowUserToResizeRows = False
        Me.dgvCargosRegistrados.AutoGenerateColumns = False
        Me.dgvCargosRegistrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCargosRegistrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCargosRegistrados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCargosRegistrados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCargosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCargosRegistrados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ContratoDataGridViewTextBoxColumn1, Me.LetraDataGridViewTextBoxColumn1, Me.NombreDelClienteDataGridViewTextBoxColumn1, Me.FechaDelCargoDataGridViewTextBoxColumn, Me.AdeudoDataGridViewTextBoxColumn1, Me.MoratoriosDataGridViewTextBoxColumn, Me.IvaMoratoriosDataGridViewTextBoxColumn, Me.ImporteDelCargoDataGridViewTextBoxColumn, Me.IdCargoExtraDataGridViewTextBoxColumn, Me.usuario})
        Me.dgvCargosRegistrados.DataSource = Me.CargosExtrasBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCargosRegistrados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCargosRegistrados.GridColor = System.Drawing.SystemColors.Highlight
        Me.dgvCargosRegistrados.Location = New System.Drawing.Point(17, 35)
        Me.dgvCargosRegistrados.Name = "dgvCargosRegistrados"
        Me.dgvCargosRegistrados.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCargosRegistrados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCargosRegistrados.RowHeadersWidth = 30
        Me.dgvCargosRegistrados.RowTemplate.Height = 20
        Me.dgvCargosRegistrados.Size = New System.Drawing.Size(967, 156)
        Me.dgvCargosRegistrados.TabIndex = 47
        '
        'ContratoDataGridViewTextBoxColumn1
        '
        Me.ContratoDataGridViewTextBoxColumn1.DataPropertyName = "Contrato"
        Me.ContratoDataGridViewTextBoxColumn1.HeaderText = "Contrato"
        Me.ContratoDataGridViewTextBoxColumn1.Name = "ContratoDataGridViewTextBoxColumn1"
        Me.ContratoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'LetraDataGridViewTextBoxColumn1
        '
        Me.LetraDataGridViewTextBoxColumn1.DataPropertyName = "Letra"
        Me.LetraDataGridViewTextBoxColumn1.HeaderText = "Letra"
        Me.LetraDataGridViewTextBoxColumn1.Name = "LetraDataGridViewTextBoxColumn1"
        Me.LetraDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NombreDelClienteDataGridViewTextBoxColumn1
        '
        Me.NombreDelClienteDataGridViewTextBoxColumn1.DataPropertyName = "Nombre del Cliente"
        Me.NombreDelClienteDataGridViewTextBoxColumn1.HeaderText = "Nombre del Cliente"
        Me.NombreDelClienteDataGridViewTextBoxColumn1.Name = "NombreDelClienteDataGridViewTextBoxColumn1"
        Me.NombreDelClienteDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FechaDelCargoDataGridViewTextBoxColumn
        '
        Me.FechaDelCargoDataGridViewTextBoxColumn.DataPropertyName = "Fecha del Cargo"
        Me.FechaDelCargoDataGridViewTextBoxColumn.HeaderText = "Fecha del Cargo"
        Me.FechaDelCargoDataGridViewTextBoxColumn.Name = "FechaDelCargoDataGridViewTextBoxColumn"
        Me.FechaDelCargoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdeudoDataGridViewTextBoxColumn1
        '
        Me.AdeudoDataGridViewTextBoxColumn1.DataPropertyName = "Adeudo"
        Me.AdeudoDataGridViewTextBoxColumn1.HeaderText = "Adeudo"
        Me.AdeudoDataGridViewTextBoxColumn1.Name = "AdeudoDataGridViewTextBoxColumn1"
        Me.AdeudoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MoratoriosDataGridViewTextBoxColumn
        '
        Me.MoratoriosDataGridViewTextBoxColumn.DataPropertyName = "Moratorios"
        Me.MoratoriosDataGridViewTextBoxColumn.HeaderText = "Moratorios"
        Me.MoratoriosDataGridViewTextBoxColumn.Name = "MoratoriosDataGridViewTextBoxColumn"
        Me.MoratoriosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IvaMoratoriosDataGridViewTextBoxColumn
        '
        Me.IvaMoratoriosDataGridViewTextBoxColumn.DataPropertyName = "Iva Moratorios"
        Me.IvaMoratoriosDataGridViewTextBoxColumn.HeaderText = "Iva Moratorios"
        Me.IvaMoratoriosDataGridViewTextBoxColumn.Name = "IvaMoratoriosDataGridViewTextBoxColumn"
        Me.IvaMoratoriosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteDelCargoDataGridViewTextBoxColumn
        '
        Me.ImporteDelCargoDataGridViewTextBoxColumn.DataPropertyName = "Importe del Cargo"
        Me.ImporteDelCargoDataGridViewTextBoxColumn.HeaderText = "Importe del Cargo"
        Me.ImporteDelCargoDataGridViewTextBoxColumn.Name = "ImporteDelCargoDataGridViewTextBoxColumn"
        Me.ImporteDelCargoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCargoExtraDataGridViewTextBoxColumn
        '
        Me.IdCargoExtraDataGridViewTextBoxColumn.DataPropertyName = "id_Cargo_Extra"
        Me.IdCargoExtraDataGridViewTextBoxColumn.HeaderText = "id_Cargo_Extra"
        Me.IdCargoExtraDataGridViewTextBoxColumn.Name = "IdCargoExtraDataGridViewTextBoxColumn"
        Me.IdCargoExtraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCargoExtraDataGridViewTextBoxColumn.Visible = False
        '
        'usuario
        '
        Me.usuario.DataPropertyName = "usuario"
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'CargosExtrasBindingSource
        '
        Me.CargosExtrasBindingSource.DataMember = "Cargos_Extras"
        Me.CargosExtrasBindingSource.DataSource = Me.PromocionDS1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dgvAdeudos)
        Me.GroupBox1.Controls.Add(Me.lblSaldos)
        Me.GroupBox1.Controls.Add(Me.btnEditarAdeudo)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(968, 426)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dtpFechaCargo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCargoTotal)
        Me.GroupBox2.Controls.Add(Me.txtIvaMoratorios)
        Me.GroupBox2.Controls.Add(Me.txtMoratorios)
        Me.GroupBox2.Controls.Add(Me.btnOmitirCargo)
        Me.GroupBox2.Controls.Add(Me.txtTarjeta)
        Me.GroupBox2.Controls.Add(Me.txtCuentaBancomer)
        Me.GroupBox2.Controls.Add(Me.txtCuentaCLABE)
        Me.GroupBox2.Controls.Add(Me.txtBanco)
        Me.GroupBox2.Controls.Add(Me.lblTarjeta)
        Me.GroupBox2.Controls.Add(Me.lblCuentaBancomer)
        Me.GroupBox2.Controls.Add(Me.lblCuentaCLABE)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblMensajeFecha)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnIncluirCargo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpFechaMora)
        Me.GroupBox2.Controls.Add(Me.txtAdeudo)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(925, 208)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(239, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Fecha del Cargo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFechaCargo
        '
        Me.dtpFechaCargo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCargo.Location = New System.Drawing.Point(381, 78)
        Me.dtpFechaCargo.Name = "dtpFechaCargo"
        Me.dtpFechaCargo.Size = New System.Drawing.Size(103, 20)
        Me.dtpFechaCargo.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(486, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 13)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Importe Total a cargar"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(486, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "IVA Moratorios"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(486, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Moratorios"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCargoTotal
        '
        Me.txtCargoTotal.Enabled = False
        Me.txtCargoTotal.Location = New System.Drawing.Point(631, 83)
        Me.txtCargoTotal.Name = "txtCargoTotal"
        Me.txtCargoTotal.ReadOnly = True
        Me.txtCargoTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtCargoTotal.TabIndex = 69
        Me.txtCargoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIvaMoratorios
        '
        Me.txtIvaMoratorios.Enabled = False
        Me.txtIvaMoratorios.Location = New System.Drawing.Point(631, 53)
        Me.txtIvaMoratorios.Name = "txtIvaMoratorios"
        Me.txtIvaMoratorios.ReadOnly = True
        Me.txtIvaMoratorios.Size = New System.Drawing.Size(100, 20)
        Me.txtIvaMoratorios.TabIndex = 68
        Me.txtIvaMoratorios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMoratorios
        '
        Me.txtMoratorios.Enabled = False
        Me.txtMoratorios.Location = New System.Drawing.Point(631, 23)
        Me.txtMoratorios.Name = "txtMoratorios"
        Me.txtMoratorios.Size = New System.Drawing.Size(100, 20)
        Me.txtMoratorios.TabIndex = 67
        Me.txtMoratorios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnOmitirCargo
        '
        Me.btnOmitirCargo.ForeColor = System.Drawing.Color.Black
        Me.btnOmitirCargo.Location = New System.Drawing.Point(640, 142)
        Me.btnOmitirCargo.Name = "btnOmitirCargo"
        Me.btnOmitirCargo.Size = New System.Drawing.Size(102, 23)
        Me.btnOmitirCargo.TabIndex = 66
        Me.btnOmitirCargo.Text = "Omitir cargo"
        Me.btnOmitirCargo.UseVisualStyleBackColor = True
        '
        'txtTarjeta
        '
        Me.txtTarjeta.Enabled = False
        Me.txtTarjeta.Location = New System.Drawing.Point(127, 113)
        Me.txtTarjeta.Name = "txtTarjeta"
        Me.txtTarjeta.ReadOnly = True
        Me.txtTarjeta.Size = New System.Drawing.Size(100, 20)
        Me.txtTarjeta.TabIndex = 65
        '
        'txtCuentaBancomer
        '
        Me.txtCuentaBancomer.Enabled = False
        Me.txtCuentaBancomer.Location = New System.Drawing.Point(127, 83)
        Me.txtCuentaBancomer.Name = "txtCuentaBancomer"
        Me.txtCuentaBancomer.ReadOnly = True
        Me.txtCuentaBancomer.Size = New System.Drawing.Size(100, 20)
        Me.txtCuentaBancomer.TabIndex = 64
        '
        'txtCuentaCLABE
        '
        Me.txtCuentaCLABE.Enabled = False
        Me.txtCuentaCLABE.Location = New System.Drawing.Point(127, 53)
        Me.txtCuentaCLABE.Name = "txtCuentaCLABE"
        Me.txtCuentaCLABE.ReadOnly = True
        Me.txtCuentaCLABE.Size = New System.Drawing.Size(100, 20)
        Me.txtCuentaCLABE.TabIndex = 63
        '
        'txtBanco
        '
        Me.txtBanco.Enabled = False
        Me.txtBanco.Location = New System.Drawing.Point(127, 23)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.ReadOnly = True
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 62
        '
        'lblTarjeta
        '
        Me.lblTarjeta.AutoSize = True
        Me.lblTarjeta.Location = New System.Drawing.Point(17, 113)
        Me.lblTarjeta.Name = "lblTarjeta"
        Me.lblTarjeta.Size = New System.Drawing.Size(71, 13)
        Me.lblTarjeta.TabIndex = 61
        Me.lblTarjeta.Text = "No. de tarjeta"
        '
        'lblCuentaBancomer
        '
        Me.lblCuentaBancomer.AutoSize = True
        Me.lblCuentaBancomer.Location = New System.Drawing.Point(17, 86)
        Me.lblCuentaBancomer.Name = "lblCuentaBancomer"
        Me.lblCuentaBancomer.Size = New System.Drawing.Size(107, 13)
        Me.lblCuentaBancomer.TabIndex = 60
        Me.lblCuentaBancomer.Text = "Cuenta en Bancomer"
        '
        'lblCuentaCLABE
        '
        Me.lblCuentaCLABE.AutoSize = True
        Me.lblCuentaCLABE.Location = New System.Drawing.Point(17, 56)
        Me.lblCuentaCLABE.Name = "lblCuentaCLABE"
        Me.lblCuentaCLABE.Size = New System.Drawing.Size(78, 13)
        Me.lblCuentaCLABE.TabIndex = 59
        Me.lblCuentaCLABE.Text = "Cuenta CLABE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Banco"
        '
        'lblMensajeFecha
        '
        Me.lblMensajeFecha.AutoSize = True
        Me.lblMensajeFecha.Location = New System.Drawing.Point(290, 102)
        Me.lblMensajeFecha.Name = "lblMensajeFecha"
        Me.lblMensajeFecha.Size = New System.Drawing.Size(0, 13)
        Me.lblMensajeFecha.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(239, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Fecha del Moratorios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(239, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Adeudo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFechaMora
        '
        Me.dtpFechaMora.Enabled = False
        Me.dtpFechaMora.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMora.Location = New System.Drawing.Point(381, 52)
        Me.dtpFechaMora.Name = "dtpFechaMora"
        Me.dtpFechaMora.Size = New System.Drawing.Size(103, 20)
        Me.dtpFechaMora.TabIndex = 49
        '
        'dgvAdeudos
        '
        Me.dgvAdeudos.AllowUserToAddRows = False
        Me.dgvAdeudos.AllowUserToDeleteRows = False
        Me.dgvAdeudos.AutoGenerateColumns = False
        Me.dgvAdeudos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAdeudos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAdeudos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAdeudos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAdeudos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdeudos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ContratoDataGridViewTextBoxColumn, Me.LetraDataGridViewTextBoxColumn, Me.NombreDelClienteDataGridViewTextBoxColumn, Me.AdeudoDataGridViewTextBoxColumn, Me.BancoDataGridViewTextBoxColumn, Me.CuentaCLABEDataGridViewTextBoxColumn, Me.NumTarjetaDataGridViewTextBoxColumn, Me.CuentaEJEDataGridViewTextBoxColumn, Me.TitularCtaDataGridViewTextBoxColumn, Me.ReferenciaDataGridViewTextBoxColumn, Me.AutorizaDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.TiparDataGridViewTextBoxColumn, Me.TasaDataGridViewTextBoxColumn, Me.DiferDataGridViewTextBoxColumn, Me.FevenDataGridViewTextBoxColumn, Me.FepagDataGridViewTextBoxColumn, Me.TasaIVAClienteDataGridViewTextBoxColumn})
        Me.dgvAdeudos.DataSource = Me.FacturasBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAdeudos.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAdeudos.GridColor = System.Drawing.SystemColors.Highlight
        Me.dgvAdeudos.Location = New System.Drawing.Point(16, 37)
        Me.dgvAdeudos.Name = "dgvAdeudos"
        Me.dgvAdeudos.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAdeudos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvAdeudos.RowHeadersWidth = 30
        Me.dgvAdeudos.RowTemplate.Height = 20
        Me.dgvAdeudos.Size = New System.Drawing.Size(702, 135)
        Me.dgvAdeudos.TabIndex = 47
        '
        'ContratoDataGridViewTextBoxColumn
        '
        Me.ContratoDataGridViewTextBoxColumn.DataPropertyName = "Contrato"
        Me.ContratoDataGridViewTextBoxColumn.HeaderText = "Contrato"
        Me.ContratoDataGridViewTextBoxColumn.Name = "ContratoDataGridViewTextBoxColumn"
        Me.ContratoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LetraDataGridViewTextBoxColumn
        '
        Me.LetraDataGridViewTextBoxColumn.DataPropertyName = "Letra"
        Me.LetraDataGridViewTextBoxColumn.HeaderText = "Letra"
        Me.LetraDataGridViewTextBoxColumn.Name = "LetraDataGridViewTextBoxColumn"
        Me.LetraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDelClienteDataGridViewTextBoxColumn
        '
        Me.NombreDelClienteDataGridViewTextBoxColumn.DataPropertyName = "Nombre del Cliente"
        Me.NombreDelClienteDataGridViewTextBoxColumn.HeaderText = "Nombre del Cliente"
        Me.NombreDelClienteDataGridViewTextBoxColumn.Name = "NombreDelClienteDataGridViewTextBoxColumn"
        Me.NombreDelClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdeudoDataGridViewTextBoxColumn
        '
        Me.AdeudoDataGridViewTextBoxColumn.DataPropertyName = "Adeudo"
        Me.AdeudoDataGridViewTextBoxColumn.HeaderText = "Adeudo"
        Me.AdeudoDataGridViewTextBoxColumn.Name = "AdeudoDataGridViewTextBoxColumn"
        Me.AdeudoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BancoDataGridViewTextBoxColumn
        '
        Me.BancoDataGridViewTextBoxColumn.DataPropertyName = "Banco"
        Me.BancoDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.BancoDataGridViewTextBoxColumn.Name = "BancoDataGridViewTextBoxColumn"
        Me.BancoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuentaCLABEDataGridViewTextBoxColumn
        '
        Me.CuentaCLABEDataGridViewTextBoxColumn.DataPropertyName = "CuentaCLABE"
        Me.CuentaCLABEDataGridViewTextBoxColumn.HeaderText = "CuentaCLABE"
        Me.CuentaCLABEDataGridViewTextBoxColumn.Name = "CuentaCLABEDataGridViewTextBoxColumn"
        Me.CuentaCLABEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumTarjetaDataGridViewTextBoxColumn
        '
        Me.NumTarjetaDataGridViewTextBoxColumn.DataPropertyName = "NumTarjeta"
        Me.NumTarjetaDataGridViewTextBoxColumn.HeaderText = "NumTarjeta"
        Me.NumTarjetaDataGridViewTextBoxColumn.Name = "NumTarjetaDataGridViewTextBoxColumn"
        Me.NumTarjetaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuentaEJEDataGridViewTextBoxColumn
        '
        Me.CuentaEJEDataGridViewTextBoxColumn.DataPropertyName = "CuentaEJE"
        Me.CuentaEJEDataGridViewTextBoxColumn.HeaderText = "CuentaEJE"
        Me.CuentaEJEDataGridViewTextBoxColumn.Name = "CuentaEJEDataGridViewTextBoxColumn"
        Me.CuentaEJEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitularCtaDataGridViewTextBoxColumn
        '
        Me.TitularCtaDataGridViewTextBoxColumn.DataPropertyName = "TitularCta"
        Me.TitularCtaDataGridViewTextBoxColumn.HeaderText = "TitularCta"
        Me.TitularCtaDataGridViewTextBoxColumn.Name = "TitularCtaDataGridViewTextBoxColumn"
        Me.TitularCtaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReferenciaDataGridViewTextBoxColumn
        '
        Me.ReferenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.Name = "ReferenciaDataGridViewTextBoxColumn"
        Me.ReferenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AutorizaDataGridViewTextBoxColumn
        '
        Me.AutorizaDataGridViewTextBoxColumn.DataPropertyName = "Autoriza"
        Me.AutorizaDataGridViewTextBoxColumn.HeaderText = "Autoriza"
        Me.AutorizaDataGridViewTextBoxColumn.Name = "AutorizaDataGridViewTextBoxColumn"
        Me.AutorizaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TiparDataGridViewTextBoxColumn
        '
        Me.TiparDataGridViewTextBoxColumn.DataPropertyName = "Tipar"
        Me.TiparDataGridViewTextBoxColumn.HeaderText = "Tipar"
        Me.TiparDataGridViewTextBoxColumn.Name = "TiparDataGridViewTextBoxColumn"
        Me.TiparDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TasaDataGridViewTextBoxColumn
        '
        Me.TasaDataGridViewTextBoxColumn.DataPropertyName = "Tasa"
        Me.TasaDataGridViewTextBoxColumn.HeaderText = "Tasa"
        Me.TasaDataGridViewTextBoxColumn.Name = "TasaDataGridViewTextBoxColumn"
        Me.TasaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiferDataGridViewTextBoxColumn
        '
        Me.DiferDataGridViewTextBoxColumn.DataPropertyName = "Difer"
        Me.DiferDataGridViewTextBoxColumn.HeaderText = "Difer"
        Me.DiferDataGridViewTextBoxColumn.Name = "DiferDataGridViewTextBoxColumn"
        Me.DiferDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FevenDataGridViewTextBoxColumn
        '
        Me.FevenDataGridViewTextBoxColumn.DataPropertyName = "Feven"
        Me.FevenDataGridViewTextBoxColumn.HeaderText = "Feven"
        Me.FevenDataGridViewTextBoxColumn.Name = "FevenDataGridViewTextBoxColumn"
        Me.FevenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FepagDataGridViewTextBoxColumn
        '
        Me.FepagDataGridViewTextBoxColumn.DataPropertyName = "Fepag"
        Me.FepagDataGridViewTextBoxColumn.HeaderText = "Fepag"
        Me.FepagDataGridViewTextBoxColumn.Name = "FepagDataGridViewTextBoxColumn"
        Me.FepagDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TasaIVAClienteDataGridViewTextBoxColumn
        '
        Me.TasaIVAClienteDataGridViewTextBoxColumn.DataPropertyName = "TasaIVACliente"
        Me.TasaIVAClienteDataGridViewTextBoxColumn.HeaderText = "TasaIVACliente"
        Me.TasaIVAClienteDataGridViewTextBoxColumn.Name = "TasaIVAClienteDataGridViewTextBoxColumn"
        Me.TasaIVAClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.PromocionDS1
        '
        'lblSaldos
        '
        Me.lblSaldos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldos.Location = New System.Drawing.Point(16, 14)
        Me.lblSaldos.Name = "lblSaldos"
        Me.lblSaldos.Size = New System.Drawing.Size(533, 20)
        Me.lblSaldos.TabIndex = 46
        Me.lblSaldos.Text = "Selecciona el adeudo para editarlo"
        Me.lblSaldos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'Cargos_ExtrasTableAdapter
        '
        Me.Cargos_ExtrasTableAdapter.ClearBeforeFill = True
        '
        'DeudoresTableAdapter
        '
        Me.DeudoresTableAdapter.ClearBeforeFill = True
        '
        'Cargos_ExtrasTableAdapter1
        '
        Me.Cargos_ExtrasTableAdapter1.ClearBeforeFill = True
        '
        'ChkProc
        '
        Me.ChkProc.AutoSize = True
        Me.ChkProc.Location = New System.Drawing.Point(902, 15)
        Me.ChkProc.Name = "ChkProc"
        Me.ChkProc.Size = New System.Drawing.Size(82, 17)
        Me.ChkProc.TabIndex = 49
        Me.ChkProc.Text = "Procesados"
        Me.ChkProc.UseVisualStyleBackColor = True
        '
        'frmCargosExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 741)
        Me.Controls.Add(Me.ChkProc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvCargosRegistrados)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbDeudores)
        Me.Controls.Add(Me.btnAdeudos)
        Me.Controls.Add(Me.lblPagos)
        Me.Name = "frmCargosExtras"
        Me.Text = "Captura de Cargos Extras para Domiciliación"
        CType(Me.DeudoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCargosRegistrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargosExtrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvAdeudos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPagos As System.Windows.Forms.Label
    Friend WithEvents btnAdeudos As System.Windows.Forms.Button
    Friend WithEvents txtAdeudo As System.Windows.Forms.TextBox
    Friend WithEvents btnEditarAdeudo As System.Windows.Forms.Button
    Friend WithEvents cbDeudores As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnIncluirCargo As System.Windows.Forms.Button
    Friend WithEvents dgvCargosRegistrados As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvAdeudos As System.Windows.Forms.DataGridView
    Friend WithEvents lblSaldos As System.Windows.Forms.Label
    Friend WithEvents dtpFechaMora As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMensajeFecha As System.Windows.Forms.Label
    Friend WithEvents txtTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaBancomer As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaCLABE As System.Windows.Forms.TextBox
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents lblTarjeta As System.Windows.Forms.Label
    Friend WithEvents lblCuentaBancomer As System.Windows.Forms.Label
    Friend WithEvents lblCuentaCLABE As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnOmitirCargo As System.Windows.Forms.Button
    Friend WithEvents txtCargoTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIvaMoratorios As System.Windows.Forms.TextBox
    Friend WithEvents txtMoratorios As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents PromocionDS1 As PromocionDS
    Friend WithEvents FacturasTableAdapter As PromocionDSTableAdapters.FacturasTableAdapter
    Friend WithEvents ContratoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LetraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDelClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdeudoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BancoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuentaCLABEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumTarjetaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuentaEJEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitularCtaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutorizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiparDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TasaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiferDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FevenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FepagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TasaIVAClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CargosExtrasBindingSource As BindingSource
    Friend WithEvents Cargos_ExtrasTableAdapter As PromocionDSTableAdapters.Cargos_ExtrasTableAdapter
    Friend WithEvents DeudoresBindingSource As BindingSource
    Friend WithEvents DeudoresTableAdapter As PromocionDSTableAdapters.DeudoresTableAdapter
    Friend WithEvents Cargos_ExtrasTableAdapter1 As PromocionDSTableAdapters.Cargos_ExtrasTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCargo As System.Windows.Forms.DateTimePicker
    Friend WithEvents ContratoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LetraDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDelClienteDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDelCargoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdeudoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MoratoriosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaMoratoriosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDelCargoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCargoExtraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChkProc As System.Windows.Forms.CheckBox
End Class
