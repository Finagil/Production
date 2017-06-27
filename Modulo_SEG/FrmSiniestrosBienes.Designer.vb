<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSiniestrosBienes
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupSinietros = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IdSiniestroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDSuperficieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaIndeminacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SuperficieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEGSiniestrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS
        Me.Txtobserv = New System.Windows.Forms.TextBox
        Me.TxtMonto = New System.Windows.Forms.TextBox
        Me.TxtdIAS = New System.Windows.Forms.TextBox
        Me.DTfecIndem = New System.Windows.Forms.DateTimePicker
        Me.Ttxttipo = New System.Windows.Forms.TextBox
        Me.Dtfecha = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ButtAltCancel = New System.Windows.Forms.Button
        Me.BttAltaSin = New System.Windows.Forms.Button
        Me.TxtIdsin = New System.Windows.Forms.TextBox
        Me.GroupDevol = New System.Windows.Forms.GroupBox
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.IDdevolucionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDSuperficieDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoAplicadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoFavorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEGDevolucionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtDevolSaldo = New System.Windows.Forms.TextBox
        Me.TxtdevolMonto = New System.Windows.Forms.TextBox
        Me.dtDevol = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.BttCancel2 = New System.Windows.Forms.Button
        Me.BttDevolnew = New System.Windows.Forms.Button
        Me.TxtIddev = New System.Windows.Forms.TextBox
        Me.GroupPoliza = New System.Windows.Forms.GroupBox
        Me.BttModDevol = New System.Windows.Forms.Button
        Me.BttMod = New System.Windows.Forms.Button
        Me.PolizasBienesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BttSiniestros = New System.Windows.Forms.Button
        Me.BttDevol = New System.Windows.Forms.Button
        Me.CmbPol = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SEG_SiniestrosTableAdapter = New Agil.SegurosDSTableAdapters.SEG_SiniestrosTableAdapter
        Me.SEG_DevolucionesTableAdapter = New Agil.SegurosDSTableAdapters.SEG_DevolucionesTableAdapter
        Me.PolizasBienesTableAdapter = New Agil.SegurosDSTableAdapters.PolizasBienesTableAdapter
        Me.TxtDetalle = New System.Windows.Forms.TextBox
        Me.GroupSinietros.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGSiniestrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDevol.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGDevolucionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPoliza.SuspendLayout()
        CType(Me.PolizasBienesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupSinietros
        '
        Me.GroupSinietros.Controls.Add(Me.DataGridView1)
        Me.GroupSinietros.Controls.Add(Me.Txtobserv)
        Me.GroupSinietros.Controls.Add(Me.TxtMonto)
        Me.GroupSinietros.Controls.Add(Me.TxtdIAS)
        Me.GroupSinietros.Controls.Add(Me.DTfecIndem)
        Me.GroupSinietros.Controls.Add(Me.Ttxttipo)
        Me.GroupSinietros.Controls.Add(Me.Dtfecha)
        Me.GroupSinietros.Controls.Add(Me.Label8)
        Me.GroupSinietros.Controls.Add(Me.Label6)
        Me.GroupSinietros.Controls.Add(Me.Label5)
        Me.GroupSinietros.Controls.Add(Me.Label4)
        Me.GroupSinietros.Controls.Add(Me.Label3)
        Me.GroupSinietros.Controls.Add(Me.Label2)
        Me.GroupSinietros.Controls.Add(Me.ButtAltCancel)
        Me.GroupSinietros.Controls.Add(Me.BttAltaSin)
        Me.GroupSinietros.Controls.Add(Me.TxtIdsin)
        Me.GroupSinietros.Enabled = False
        Me.GroupSinietros.Location = New System.Drawing.Point(12, 140)
        Me.GroupSinietros.Name = "GroupSinietros"
        Me.GroupSinietros.Size = New System.Drawing.Size(842, 202)
        Me.GroupSinietros.TabIndex = 0
        Me.GroupSinietros.TabStop = False
        Me.GroupSinietros.Text = "Siniestros"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSiniestroDataGridViewTextBoxColumn, Me.IDSuperficieDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.FechaIndeminacionDataGridViewTextBoxColumn, Me.DiasDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.SuperficieDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SEGSiniestrosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(666, 112)
        Me.DataGridView1.TabIndex = 111
        '
        'IdSiniestroDataGridViewTextBoxColumn
        '
        Me.IdSiniestroDataGridViewTextBoxColumn.DataPropertyName = "IdSiniestro"
        Me.IdSiniestroDataGridViewTextBoxColumn.HeaderText = "IdSiniestro"
        Me.IdSiniestroDataGridViewTextBoxColumn.Name = "IdSiniestroDataGridViewTextBoxColumn"
        Me.IdSiniestroDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdSiniestroDataGridViewTextBoxColumn.Visible = False
        '
        'IDSuperficieDataGridViewTextBoxColumn
        '
        Me.IDSuperficieDataGridViewTextBoxColumn.DataPropertyName = "IDSuperficie"
        Me.IDSuperficieDataGridViewTextBoxColumn.HeaderText = "IDSuperficie"
        Me.IDSuperficieDataGridViewTextBoxColumn.Name = "IDSuperficieDataGridViewTextBoxColumn"
        Me.IDSuperficieDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDSuperficieDataGridViewTextBoxColumn.Visible = False
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 60
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 60
        '
        'FechaIndeminacionDataGridViewTextBoxColumn
        '
        Me.FechaIndeminacionDataGridViewTextBoxColumn.DataPropertyName = "FechaIndeminacion"
        Me.FechaIndeminacionDataGridViewTextBoxColumn.HeaderText = "FechaIndeminacion"
        Me.FechaIndeminacionDataGridViewTextBoxColumn.Name = "FechaIndeminacionDataGridViewTextBoxColumn"
        Me.FechaIndeminacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaIndeminacionDataGridViewTextBoxColumn.Width = 60
        '
        'DiasDataGridViewTextBoxColumn
        '
        Me.DiasDataGridViewTextBoxColumn.DataPropertyName = "Dias"
        DataGridViewCellStyle1.Format = "n2"
        Me.DiasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DiasDataGridViewTextBoxColumn.HeaderText = "Dias"
        Me.DiasDataGridViewTextBoxColumn.Name = "DiasDataGridViewTextBoxColumn"
        Me.DiasDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiasDataGridViewTextBoxColumn.Width = 60
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle2.Format = "n2"
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoDataGridViewTextBoxColumn.Width = 60
        '
        'SuperficieDataGridViewTextBoxColumn
        '
        Me.SuperficieDataGridViewTextBoxColumn.DataPropertyName = "Superficie"
        DataGridViewCellStyle3.Format = "n2"
        Me.SuperficieDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.SuperficieDataGridViewTextBoxColumn.HeaderText = "Superficie"
        Me.SuperficieDataGridViewTextBoxColumn.Name = "SuperficieDataGridViewTextBoxColumn"
        Me.SuperficieDataGridViewTextBoxColumn.ReadOnly = True
        Me.SuperficieDataGridViewTextBoxColumn.Width = 60
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Width = 300
        '
        'SEGSiniestrosBindingSource
        '
        Me.SEGSiniestrosBindingSource.DataMember = "SEG_Siniestros"
        Me.SEGSiniestrosBindingSource.DataSource = Me.SegurosDS
        '
        'SegurosDS
        '
        Me.SegurosDS.DataSetName = "SegurosDS"
        Me.SegurosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Txtobserv
        '
        Me.Txtobserv.Location = New System.Drawing.Point(577, 42)
        Me.Txtobserv.MaxLength = 300
        Me.Txtobserv.Multiline = True
        Me.Txtobserv.Name = "Txtobserv"
        Me.Txtobserv.Size = New System.Drawing.Size(259, 36)
        Me.Txtobserv.TabIndex = 110
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(466, 42)
        Me.TxtMonto.MaxLength = 50
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(100, 20)
        Me.TxtMonto.TabIndex = 108
        '
        'TxtdIAS
        '
        Me.TxtdIAS.Location = New System.Drawing.Point(357, 42)
        Me.TxtdIAS.MaxLength = 50
        Me.TxtdIAS.Name = "TxtdIAS"
        Me.TxtdIAS.Size = New System.Drawing.Size(100, 20)
        Me.TxtdIAS.TabIndex = 107
        '
        'DTfecIndem
        '
        Me.DTfecIndem.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTfecIndem.Location = New System.Drawing.Point(245, 42)
        Me.DTfecIndem.Name = "DTfecIndem"
        Me.DTfecIndem.Size = New System.Drawing.Size(97, 20)
        Me.DTfecIndem.TabIndex = 106
        '
        'Ttxttipo
        '
        Me.Ttxttipo.Location = New System.Drawing.Point(131, 43)
        Me.Ttxttipo.MaxLength = 50
        Me.Ttxttipo.Name = "Ttxttipo"
        Me.Ttxttipo.Size = New System.Drawing.Size(100, 20)
        Me.Ttxttipo.TabIndex = 105
        '
        'Dtfecha
        '
        Me.Dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtfecha.Location = New System.Drawing.Point(19, 44)
        Me.Dtfecha.Name = "Dtfecha"
        Me.Dtfecha.Size = New System.Drawing.Size(97, 20)
        Me.Dtfecha.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(574, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Observaciones"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(469, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Monto"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(356, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Dias"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(242, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Fecha Indemnizacion"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(128, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Tipo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Fecha"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtAltCancel
        '
        Me.ButtAltCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtAltCancel.Location = New System.Drawing.Point(764, 103)
        Me.ButtAltCancel.Name = "ButtAltCancel"
        Me.ButtAltCancel.Size = New System.Drawing.Size(67, 24)
        Me.ButtAltCancel.TabIndex = 96
        Me.ButtAltCancel.Text = "Cancelar"
        Me.ButtAltCancel.UseVisualStyleBackColor = True
        '
        'BttAltaSin
        '
        Me.BttAltaSin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttAltaSin.Location = New System.Drawing.Point(684, 103)
        Me.BttAltaSin.Name = "BttAltaSin"
        Me.BttAltaSin.Size = New System.Drawing.Size(67, 24)
        Me.BttAltaSin.TabIndex = 95
        Me.BttAltaSin.Text = "Alta"
        Me.BttAltaSin.UseVisualStyleBackColor = True
        '
        'TxtIdsin
        '
        Me.TxtIdsin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGSiniestrosBindingSource, "IdSiniestro", True))
        Me.TxtIdsin.Location = New System.Drawing.Point(572, 144)
        Me.TxtIdsin.MaxLength = 50
        Me.TxtIdsin.Name = "TxtIdsin"
        Me.TxtIdsin.ReadOnly = True
        Me.TxtIdsin.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdsin.TabIndex = 112
        '
        'GroupDevol
        '
        Me.GroupDevol.Controls.Add(Me.DataGridView2)
        Me.GroupDevol.Controls.Add(Me.TxtDevolSaldo)
        Me.GroupDevol.Controls.Add(Me.TxtdevolMonto)
        Me.GroupDevol.Controls.Add(Me.dtDevol)
        Me.GroupDevol.Controls.Add(Me.Label9)
        Me.GroupDevol.Controls.Add(Me.Label10)
        Me.GroupDevol.Controls.Add(Me.Label11)
        Me.GroupDevol.Controls.Add(Me.BttCancel2)
        Me.GroupDevol.Controls.Add(Me.BttDevolnew)
        Me.GroupDevol.Controls.Add(Me.TxtIddev)
        Me.GroupDevol.Enabled = False
        Me.GroupDevol.Location = New System.Drawing.Point(12, 348)
        Me.GroupDevol.Name = "GroupDevol"
        Me.GroupDevol.Size = New System.Drawing.Size(840, 185)
        Me.GroupDevol.TabIndex = 1
        Me.GroupDevol.TabStop = False
        Me.GroupDevol.Text = "Devoluciones"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDdevolucionDataGridViewTextBoxColumn, Me.IDSuperficieDataGridViewTextBoxColumn1, Me.MontoAplicadoDataGridViewTextBoxColumn, Me.SaldoFavorDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.SEGDevolucionesBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(6, 63)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(825, 112)
        Me.DataGridView2.TabIndex = 115
        '
        'IDdevolucionDataGridViewTextBoxColumn
        '
        Me.IDdevolucionDataGridViewTextBoxColumn.DataPropertyName = "IDdevolucion"
        Me.IDdevolucionDataGridViewTextBoxColumn.HeaderText = "IDdevolucion"
        Me.IDdevolucionDataGridViewTextBoxColumn.Name = "IDdevolucionDataGridViewTextBoxColumn"
        Me.IDdevolucionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDdevolucionDataGridViewTextBoxColumn.Visible = False
        '
        'IDSuperficieDataGridViewTextBoxColumn1
        '
        Me.IDSuperficieDataGridViewTextBoxColumn1.DataPropertyName = "IDSuperficie"
        Me.IDSuperficieDataGridViewTextBoxColumn1.HeaderText = "IDSuperficie"
        Me.IDSuperficieDataGridViewTextBoxColumn1.Name = "IDSuperficieDataGridViewTextBoxColumn1"
        Me.IDSuperficieDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDSuperficieDataGridViewTextBoxColumn1.Visible = False
        '
        'MontoAplicadoDataGridViewTextBoxColumn
        '
        Me.MontoAplicadoDataGridViewTextBoxColumn.DataPropertyName = "MontoAplicado"
        DataGridViewCellStyle4.Format = "n2"
        Me.MontoAplicadoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.MontoAplicadoDataGridViewTextBoxColumn.HeaderText = "Monto Aplicado"
        Me.MontoAplicadoDataGridViewTextBoxColumn.Name = "MontoAplicadoDataGridViewTextBoxColumn"
        Me.MontoAplicadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoAplicadoDataGridViewTextBoxColumn.Width = 150
        '
        'SaldoFavorDataGridViewTextBoxColumn
        '
        Me.SaldoFavorDataGridViewTextBoxColumn.DataPropertyName = "SaldoFavor"
        DataGridViewCellStyle5.Format = "N2"
        Me.SaldoFavorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.SaldoFavorDataGridViewTextBoxColumn.HeaderText = "Saldo a Favor"
        Me.SaldoFavorDataGridViewTextBoxColumn.Name = "SaldoFavorDataGridViewTextBoxColumn"
        Me.SaldoFavorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SEGDevolucionesBindingSource
        '
        Me.SEGDevolucionesBindingSource.DataMember = "SEG_Devoluciones"
        Me.SEGDevolucionesBindingSource.DataSource = Me.SegurosDS
        '
        'TxtDevolSaldo
        '
        Me.TxtDevolSaldo.Location = New System.Drawing.Point(235, 37)
        Me.TxtDevolSaldo.MaxLength = 50
        Me.TxtDevolSaldo.Name = "TxtDevolSaldo"
        Me.TxtDevolSaldo.Size = New System.Drawing.Size(100, 20)
        Me.TxtDevolSaldo.TabIndex = 114
        '
        'TxtdevolMonto
        '
        Me.TxtdevolMonto.Location = New System.Drawing.Point(126, 37)
        Me.TxtdevolMonto.MaxLength = 50
        Me.TxtdevolMonto.Name = "TxtdevolMonto"
        Me.TxtdevolMonto.Size = New System.Drawing.Size(100, 20)
        Me.TxtdevolMonto.TabIndex = 113
        '
        'dtDevol
        '
        Me.dtDevol.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDevol.Location = New System.Drawing.Point(14, 37)
        Me.dtDevol.Name = "dtDevol"
        Me.dtDevol.Size = New System.Drawing.Size(97, 20)
        Me.dtDevol.TabIndex = 112
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(238, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Saldo a Favor"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(125, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "Monto"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 109
        Me.Label11.Text = "Fecha"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BttCancel2
        '
        Me.BttCancel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttCancel2.Location = New System.Drawing.Point(764, 33)
        Me.BttCancel2.Name = "BttCancel2"
        Me.BttCancel2.Size = New System.Drawing.Size(67, 24)
        Me.BttCancel2.TabIndex = 98
        Me.BttCancel2.Text = "Cancelar"
        Me.BttCancel2.UseVisualStyleBackColor = True
        '
        'BttDevolnew
        '
        Me.BttDevolnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttDevolnew.Location = New System.Drawing.Point(684, 33)
        Me.BttDevolnew.Name = "BttDevolnew"
        Me.BttDevolnew.Size = New System.Drawing.Size(67, 24)
        Me.BttDevolnew.TabIndex = 97
        Me.BttDevolnew.Text = "Alta"
        Me.BttDevolnew.UseVisualStyleBackColor = True
        '
        'TxtIddev
        '
        Me.TxtIddev.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGDevolucionesBindingSource, "IDdevolucion", True))
        Me.TxtIddev.Location = New System.Drawing.Point(731, 108)
        Me.TxtIddev.MaxLength = 50
        Me.TxtIddev.Name = "TxtIddev"
        Me.TxtIddev.ReadOnly = True
        Me.TxtIddev.Size = New System.Drawing.Size(100, 20)
        Me.TxtIddev.TabIndex = 116
        '
        'GroupPoliza
        '
        Me.GroupPoliza.Controls.Add(Me.TxtDetalle)
        Me.GroupPoliza.Controls.Add(Me.BttModDevol)
        Me.GroupPoliza.Controls.Add(Me.BttMod)
        Me.GroupPoliza.Controls.Add(Me.BttSiniestros)
        Me.GroupPoliza.Controls.Add(Me.BttDevol)
        Me.GroupPoliza.Controls.Add(Me.CmbPol)
        Me.GroupPoliza.Controls.Add(Me.Label1)
        Me.GroupPoliza.Location = New System.Drawing.Point(12, 12)
        Me.GroupPoliza.Name = "GroupPoliza"
        Me.GroupPoliza.Size = New System.Drawing.Size(842, 122)
        Me.GroupPoliza.TabIndex = 2
        Me.GroupPoliza.TabStop = False
        Me.GroupPoliza.Text = "Datos de la Poliza"
        '
        'BttModDevol
        '
        Me.BttModDevol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttModDevol.Location = New System.Drawing.Point(744, 19)
        Me.BttModDevol.Name = "BttModDevol"
        Me.BttModDevol.Size = New System.Drawing.Size(92, 42)
        Me.BttModDevol.TabIndex = 5
        Me.BttModDevol.Text = "Modificar Devolucion"
        Me.BttModDevol.UseVisualStyleBackColor = True
        '
        'BttMod
        '
        Me.BttMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttMod.Location = New System.Drawing.Point(545, 19)
        Me.BttMod.Name = "BttMod"
        Me.BttMod.Size = New System.Drawing.Size(95, 42)
        Me.BttMod.TabIndex = 3
        Me.BttMod.Text = "Modificar Siniestro"
        Me.BttMod.UseVisualStyleBackColor = True
        '
        'PolizasBienesBindingSource
        '
        Me.PolizasBienesBindingSource.DataMember = "PolizasBienes"
        Me.PolizasBienesBindingSource.DataSource = Me.SegurosDS
        '
        'BttSiniestros
        '
        Me.BttSiniestros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttSiniestros.Location = New System.Drawing.Point(444, 19)
        Me.BttSiniestros.Name = "BttSiniestros"
        Me.BttSiniestros.Size = New System.Drawing.Size(95, 42)
        Me.BttSiniestros.TabIndex = 2
        Me.BttSiniestros.Text = "Alta Siniestro"
        Me.BttSiniestros.UseVisualStyleBackColor = True
        '
        'BttDevol
        '
        Me.BttDevol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttDevol.Location = New System.Drawing.Point(646, 19)
        Me.BttDevol.Name = "BttDevol"
        Me.BttDevol.Size = New System.Drawing.Size(92, 42)
        Me.BttDevol.TabIndex = 4
        Me.BttDevol.Text = "Alta Devolucion"
        Me.BttDevol.UseVisualStyleBackColor = True
        '
        'CmbPol
        '
        Me.CmbPol.DataSource = Me.PolizasBienesBindingSource
        Me.CmbPol.DisplayMember = "Poliza"
        Me.CmbPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPol.FormattingEnabled = True
        Me.CmbPol.Location = New System.Drawing.Point(49, 15)
        Me.CmbPol.Name = "CmbPol"
        Me.CmbPol.Size = New System.Drawing.Size(316, 21)
        Me.CmbPol.TabIndex = 1
        Me.CmbPol.ValueMember = "Id_poliza"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Polizas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SEG_SiniestrosTableAdapter
        '
        Me.SEG_SiniestrosTableAdapter.ClearBeforeFill = True
        '
        'SEG_DevolucionesTableAdapter
        '
        Me.SEG_DevolucionesTableAdapter.ClearBeforeFill = True
        '
        'PolizasBienesTableAdapter
        '
        Me.PolizasBienesTableAdapter.ClearBeforeFill = True
        '
        'TxtDetalle
        '
        Me.TxtDetalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PolizasBienesBindingSource, "descripcion", True))
        Me.TxtDetalle.Location = New System.Drawing.Point(11, 42)
        Me.TxtDetalle.MaxLength = 300
        Me.TxtDetalle.Multiline = True
        Me.TxtDetalle.Name = "TxtDetalle"
        Me.TxtDetalle.ReadOnly = True
        Me.TxtDetalle.Size = New System.Drawing.Size(427, 74)
        Me.TxtDetalle.TabIndex = 113
        '
        'FrmSiniestrosBienes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 537)
        Me.Controls.Add(Me.GroupPoliza)
        Me.Controls.Add(Me.GroupDevol)
        Me.Controls.Add(Me.GroupSinietros)
        Me.Name = "FrmSiniestrosBienes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Siniestros y Devoluciones"
        Me.GroupSinietros.ResumeLayout(False)
        Me.GroupSinietros.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGSiniestrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDevol.ResumeLayout(False)
        Me.GroupDevol.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGDevolucionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPoliza.ResumeLayout(False)
        Me.GroupPoliza.PerformLayout()
        CType(Me.PolizasBienesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupSinietros As System.Windows.Forms.GroupBox
    Friend WithEvents SegurosDS As Agil.SegurosDS
    Friend WithEvents GroupDevol As System.Windows.Forms.GroupBox
    Friend WithEvents ButtAltCancel As System.Windows.Forms.Button
    Friend WithEvents BttAltaSin As System.Windows.Forms.Button
    Friend WithEvents BttCancel2 As System.Windows.Forms.Button
    Friend WithEvents BttDevolnew As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtobserv As System.Windows.Forms.TextBox
    Friend WithEvents TxtMonto As System.Windows.Forms.TextBox
    Friend WithEvents TxtdIAS As System.Windows.Forms.TextBox
    Friend WithEvents DTfecIndem As System.Windows.Forms.DateTimePicker
    Friend WithEvents Ttxttipo As System.Windows.Forms.TextBox
    Friend WithEvents Dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdSiniestroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDSuperficieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaIndeminacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuperficieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEGSiniestrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEG_SiniestrosTableAdapter As Agil.SegurosDSTableAdapters.SEG_SiniestrosTableAdapter
    Friend WithEvents GroupPoliza As System.Windows.Forms.GroupBox
    Friend WithEvents BttSiniestros As System.Windows.Forms.Button
    Friend WithEvents BttDevol As System.Windows.Forms.Button
    Friend WithEvents CmbPol As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDevolSaldo As System.Windows.Forms.TextBox
    Friend WithEvents TxtdevolMonto As System.Windows.Forms.TextBox
    Friend WithEvents dtDevol As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents SEGDevolucionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEG_DevolucionesTableAdapter As Agil.SegurosDSTableAdapters.SEG_DevolucionesTableAdapter
    Friend WithEvents IDdevolucionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDSuperficieDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoAplicadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoFavorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PolizasBienesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PolizasBienesTableAdapter As Agil.SegurosDSTableAdapters.PolizasBienesTableAdapter
    Friend WithEvents BttMod As System.Windows.Forms.Button
    Friend WithEvents TxtIdsin As System.Windows.Forms.TextBox
    Friend WithEvents TxtIddev As System.Windows.Forms.TextBox
    Friend WithEvents BttModDevol As System.Windows.Forms.Button
    Friend WithEvents TxtDetalle As System.Windows.Forms.TextBox
End Class
