<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPolLoc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupClientes = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BttModPol = New System.Windows.Forms.Button()
        Me.BttDevol = New System.Windows.Forms.Button()
        Me.GridActivos = New System.Windows.Forms.DataGridView()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActifijoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS()
        Me.BttLOCNew = New System.Windows.Forms.Button()
        Me.BttAltaNew = New System.Windows.Forms.Button()
        Me.CmbAnexo = New System.Windows.Forms.ComboBox()
        Me.AnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbClientes = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtidActivo = New System.Windows.Forms.TextBox()
        Me.TxtStatus = New System.Windows.Forms.TextBox()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.ClientesTableAdapter = New Agil.SegurosDSTableAdapters.ClientesTableAdapter()
        Me.AnexosTableAdapter = New Agil.SegurosDSTableAdapters.AnexosTableAdapter()
        Me.GroupDatos = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Txtobserv = New System.Windows.Forms.TextBox()
        Me.BttAltCancel = New System.Windows.Forms.Button()
        Me.BttAlta = New System.Windows.Forms.Button()
        Me.DTpag = New System.Windows.Forms.DateTimePicker()
        Me.DtFin = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPrima = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DTini = New System.Windows.Forms.DateTimePicker()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.CmbAseg = New System.Windows.Forms.ComboBox()
        Me.SEGAseguradorasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.TxtPol = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SEGPolizasBienesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActifijoTableAdapter = New Agil.SegurosDSTableAdapters.ActifijoTableAdapter()
        Me.SEG_AseguradorasTableAdapter = New Agil.SegurosDSTableAdapters.SEG_AseguradorasTableAdapter()
        Me.SEG_PolizasBienesTableAdapter = New Agil.SegurosDSTableAdapters.SEG_PolizasBienesTableAdapter()
        Me.GroupLOC = New System.Windows.Forms.GroupBox()
        Me.TxtidCli = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DtInstall = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BttCancel2 = New System.Windows.Forms.Button()
        Me.DTpago = New System.Windows.Forms.DateTimePicker()
        Me.DTsolic = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtImpo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DTTermina = New System.Windows.Forms.DateTimePicker()
        Me.Txtendoso = New System.Windows.Forms.TextBox()
        Me.CmbAeg2 = New System.Windows.Forms.ComboBox()
        Me.SEGAseguradorasCopyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cmbplataforma = New System.Windows.Forms.ComboBox()
        Me.TxtFactura = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BttSave = New System.Windows.Forms.Button()
        Me.TxtIDloc = New System.Windows.Forms.TextBox()
        Me.SEG_AseguradorasCopyTableAdapter = New Agil.SegurosDSTableAdapters.SEG_AseguradorasCopyTableAdapter()
        Me.GridPolizas = New System.Windows.Forms.DataGridView()
        Me.IdpolizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Poliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIniciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaTerminaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecLimPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aseguradora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAseguradoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdActivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupClientes.SuspendLayout()
        CType(Me.GridActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActifijoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDatos.SuspendLayout()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGPolizasBienesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupLOC.SuspendLayout()
        CType(Me.SEGAseguradorasCopyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupClientes
        '
        Me.GroupClientes.Controls.Add(Me.Button1)
        Me.GroupClientes.Controls.Add(Me.BttModPol)
        Me.GroupClientes.Controls.Add(Me.BttDevol)
        Me.GroupClientes.Controls.Add(Me.GridActivos)
        Me.GroupClientes.Controls.Add(Me.BttLOCNew)
        Me.GroupClientes.Controls.Add(Me.BttAltaNew)
        Me.GroupClientes.Controls.Add(Me.CmbAnexo)
        Me.GroupClientes.Controls.Add(Me.Label3)
        Me.GroupClientes.Controls.Add(Me.CmbClientes)
        Me.GroupClientes.Controls.Add(Me.Txtfiltro)
        Me.GroupClientes.Controls.Add(Me.Label1)
        Me.GroupClientes.Controls.Add(Me.TxtidActivo)
        Me.GroupClientes.Controls.Add(Me.TxtStatus)
        Me.GroupClientes.Controls.Add(Me.TxtSerie)
        Me.GroupClientes.Location = New System.Drawing.Point(12, 12)
        Me.GroupClientes.Name = "GroupClientes"
        Me.GroupClientes.Size = New System.Drawing.Size(898, 242)
        Me.GroupClientes.TabIndex = 8
        Me.GroupClientes.TabStop = False
        Me.GroupClientes.Text = "Selecionar Clientes"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(795, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 34)
        Me.Button1.TabIndex = 116
        Me.Button1.Text = "Adjuntar Archivos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BttModPol
        '
        Me.BttModPol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttModPol.Location = New System.Drawing.Point(595, 87)
        Me.BttModPol.Name = "BttModPol"
        Me.BttModPol.Size = New System.Drawing.Size(93, 34)
        Me.BttModPol.TabIndex = 114
        Me.BttModPol.Text = "Modificar Poliza"
        Me.BttModPol.UseVisualStyleBackColor = True
        '
        'BttDevol
        '
        Me.BttDevol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttDevol.Location = New System.Drawing.Point(795, 87)
        Me.BttDevol.Name = "BttDevol"
        Me.BttDevol.Size = New System.Drawing.Size(93, 34)
        Me.BttDevol.TabIndex = 113
        Me.BttDevol.Text = "Siniestros y Devoluciones"
        Me.BttDevol.UseVisualStyleBackColor = True
        '
        'GridActivos
        '
        Me.GridActivos.AllowUserToAddRows = False
        Me.GridActivos.AllowUserToDeleteRows = False
        Me.GridActivos.AutoGenerateColumns = False
        Me.GridActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridActivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.ID, Me.DetalleDataGridViewTextBoxColumn, Me.Tipo, Me.ModeloDataGridViewTextBoxColumn, Me.MotorDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.PlacaDataGridViewTextBoxColumn})
        Me.GridActivos.DataSource = Me.ActifijoBindingSource
        Me.GridActivos.Location = New System.Drawing.Point(12, 129)
        Me.GridActivos.MultiSelect = False
        Me.GridActivos.Name = "GridActivos"
        Me.GridActivos.ReadOnly = True
        Me.GridActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridActivos.Size = New System.Drawing.Size(876, 104)
        Me.GridActivos.TabIndex = 108
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Visible = False
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'DetalleDataGridViewTextBoxColumn
        '
        Me.DetalleDataGridViewTextBoxColumn.DataPropertyName = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DetalleDataGridViewTextBoxColumn.Name = "DetalleDataGridViewTextBoxColumn"
        Me.DetalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleDataGridViewTextBoxColumn.Width = 440
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 60
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Width = 60
        '
        'MotorDataGridViewTextBoxColumn
        '
        Me.MotorDataGridViewTextBoxColumn.DataPropertyName = "Motor"
        Me.MotorDataGridViewTextBoxColumn.HeaderText = "Motor"
        Me.MotorDataGridViewTextBoxColumn.Name = "MotorDataGridViewTextBoxColumn"
        Me.MotorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "Serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlacaDataGridViewTextBoxColumn
        '
        Me.PlacaDataGridViewTextBoxColumn.DataPropertyName = "Placa"
        Me.PlacaDataGridViewTextBoxColumn.HeaderText = "Placa"
        Me.PlacaDataGridViewTextBoxColumn.Name = "PlacaDataGridViewTextBoxColumn"
        Me.PlacaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PlacaDataGridViewTextBoxColumn.Width = 60
        '
        'ActifijoBindingSource
        '
        Me.ActifijoBindingSource.DataMember = "Actifijo"
        Me.ActifijoBindingSource.DataSource = Me.SegurosDS
        '
        'SegurosDS
        '
        Me.SegurosDS.DataSetName = "SegurosDS"
        Me.SegurosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BttLOCNew
        '
        Me.BttLOCNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttLOCNew.Location = New System.Drawing.Point(695, 87)
        Me.BttLOCNew.Name = "BttLOCNew"
        Me.BttLOCNew.Size = New System.Drawing.Size(93, 34)
        Me.BttLOCNew.TabIndex = 107
        Me.BttLOCNew.Text = "Localizador"
        Me.BttLOCNew.UseVisualStyleBackColor = True
        '
        'BttAltaNew
        '
        Me.BttAltaNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttAltaNew.Location = New System.Drawing.Point(495, 87)
        Me.BttAltaNew.Name = "BttAltaNew"
        Me.BttAltaNew.Size = New System.Drawing.Size(93, 34)
        Me.BttAltaNew.TabIndex = 94
        Me.BttAltaNew.Text = "Alta de Poliza"
        Me.BttAltaNew.UseVisualStyleBackColor = True
        '
        'CmbAnexo
        '
        Me.CmbAnexo.DataSource = Me.AnexosBindingSource
        Me.CmbAnexo.DisplayMember = "titulo"
        Me.CmbAnexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnexo.FormattingEnabled = True
        Me.CmbAnexo.Location = New System.Drawing.Point(14, 102)
        Me.CmbAnexo.Name = "CmbAnexo"
        Me.CmbAnexo.Size = New System.Drawing.Size(260, 21)
        Me.CmbAnexo.TabIndex = 9
        Me.CmbAnexo.ValueMember = "Anexo"
        '
        'AnexosBindingSource
        '
        Me.AnexosBindingSource.DataMember = "Anexos"
        Me.AnexosBindingSource.DataSource = Me.SegurosDS
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = " Anexos"
        '
        'CmbClientes
        '
        Me.CmbClientes.DataSource = Me.ClientesBindingSource
        Me.CmbClientes.DisplayMember = "Descr"
        Me.CmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(14, 61)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(427, 21)
        Me.CmbClientes.TabIndex = 7
        Me.CmbClientes.ValueMember = "Cliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.SegurosDS
        '
        'Txtfiltro
        '
        Me.Txtfiltro.Location = New System.Drawing.Point(14, 35)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(425, 20)
        Me.Txtfiltro.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Filtro"
        '
        'TxtidActivo
        '
        Me.TxtidActivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "ID", True))
        Me.TxtidActivo.Location = New System.Drawing.Point(827, 155)
        Me.TxtidActivo.Name = "TxtidActivo"
        Me.TxtidActivo.ReadOnly = True
        Me.TxtidActivo.Size = New System.Drawing.Size(46, 20)
        Me.TxtidActivo.TabIndex = 112
        '
        'TxtStatus
        '
        Me.TxtStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "Status", True))
        Me.TxtStatus.Location = New System.Drawing.Point(232, 103)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.ReadOnly = True
        Me.TxtStatus.Size = New System.Drawing.Size(17, 20)
        Me.TxtStatus.TabIndex = 113
        '
        'TxtSerie
        '
        Me.TxtSerie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "Serie", True))
        Me.TxtSerie.Location = New System.Drawing.Point(198, 103)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.ReadOnly = True
        Me.TxtSerie.Size = New System.Drawing.Size(17, 20)
        Me.TxtSerie.TabIndex = 115
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'AnexosTableAdapter
        '
        Me.AnexosTableAdapter.ClearBeforeFill = True
        '
        'GroupDatos
        '
        Me.GroupDatos.Controls.Add(Me.Label21)
        Me.GroupDatos.Controls.Add(Me.Txtobserv)
        Me.GroupDatos.Controls.Add(Me.BttAltCancel)
        Me.GroupDatos.Controls.Add(Me.BttAlta)
        Me.GroupDatos.Controls.Add(Me.DTpag)
        Me.GroupDatos.Controls.Add(Me.DtFin)
        Me.GroupDatos.Controls.Add(Me.Label10)
        Me.GroupDatos.Controls.Add(Me.Label5)
        Me.GroupDatos.Controls.Add(Me.TxtPrima)
        Me.GroupDatos.Controls.Add(Me.Label11)
        Me.GroupDatos.Controls.Add(Me.DTini)
        Me.GroupDatos.Controls.Add(Me.TxtTotal)
        Me.GroupDatos.Controls.Add(Me.CmbAseg)
        Me.GroupDatos.Controls.Add(Me.CmbTipo)
        Me.GroupDatos.Controls.Add(Me.TxtPol)
        Me.GroupDatos.Controls.Add(Me.Label9)
        Me.GroupDatos.Controls.Add(Me.Label7)
        Me.GroupDatos.Controls.Add(Me.Label4)
        Me.GroupDatos.Controls.Add(Me.Label2)
        Me.GroupDatos.Controls.Add(Me.Label12)
        Me.GroupDatos.Location = New System.Drawing.Point(12, 259)
        Me.GroupDatos.Name = "GroupDatos"
        Me.GroupDatos.Size = New System.Drawing.Size(898, 106)
        Me.GroupDatos.TabIndex = 95
        Me.GroupDatos.TabStop = False
        Me.GroupDatos.Text = "Datos de la Poliza"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(299, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 13)
        Me.Label21.TabIndex = 114
        Me.Label21.Text = "Observaciones"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txtobserv
        '
        Me.Txtobserv.Location = New System.Drawing.Point(299, 74)
        Me.Txtobserv.MaxLength = 200
        Me.Txtobserv.Name = "Txtobserv"
        Me.Txtobserv.Size = New System.Drawing.Size(381, 20)
        Me.Txtobserv.TabIndex = 107
        '
        'BttAltCancel
        '
        Me.BttAltCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttAltCancel.Location = New System.Drawing.Point(770, 71)
        Me.BttAltCancel.Name = "BttAltCancel"
        Me.BttAltCancel.Size = New System.Drawing.Size(67, 24)
        Me.BttAltCancel.TabIndex = 110
        Me.BttAltCancel.Text = "Cancelar"
        Me.BttAltCancel.UseVisualStyleBackColor = True
        '
        'BttAlta
        '
        Me.BttAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttAlta.Location = New System.Drawing.Point(686, 71)
        Me.BttAlta.Name = "BttAlta"
        Me.BttAlta.Size = New System.Drawing.Size(67, 24)
        Me.BttAlta.TabIndex = 109
        Me.BttAlta.Text = "Alta"
        Me.BttAlta.UseVisualStyleBackColor = True
        '
        'DTpag
        '
        Me.DTpag.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTpag.Location = New System.Drawing.Point(518, 32)
        Me.DTpag.Name = "DTpag"
        Me.DTpag.Size = New System.Drawing.Size(100, 20)
        Me.DTpag.TabIndex = 104
        '
        'DtFin
        '
        Me.DtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFin.Location = New System.Drawing.Point(407, 32)
        Me.DtFin.Name = "DtFin"
        Me.DtFin.Size = New System.Drawing.Size(100, 20)
        Me.DtFin.TabIndex = 103
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(515, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 13)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Fecha Limite de Pago"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(404, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Fecha Termina"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPrima
        '
        Me.TxtPrima.Location = New System.Drawing.Point(627, 31)
        Me.TxtPrima.Name = "TxtPrima"
        Me.TxtPrima.Size = New System.Drawing.Size(102, 20)
        Me.TxtPrima.TabIndex = 105
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(628, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "Prima"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DTini
        '
        Me.DTini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTini.Location = New System.Drawing.Point(299, 33)
        Me.DTini.Name = "DTini"
        Me.DTini.Size = New System.Drawing.Size(100, 20)
        Me.DTini.TabIndex = 102
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(735, 31)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(102, 20)
        Me.TxtTotal.TabIndex = 106
        '
        'CmbAseg
        '
        Me.CmbAseg.DataSource = Me.SEGAseguradorasBindingSource
        Me.CmbAseg.DisplayMember = "Aseguradora"
        Me.CmbAseg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAseg.FormattingEnabled = True
        Me.CmbAseg.Location = New System.Drawing.Point(20, 74)
        Me.CmbAseg.Name = "CmbAseg"
        Me.CmbAseg.Size = New System.Drawing.Size(273, 21)
        Me.CmbAseg.TabIndex = 107
        Me.CmbAseg.ValueMember = "IdAseguradora"
        '
        'SEGAseguradorasBindingSource
        '
        Me.SEGAseguradorasBindingSource.DataMember = "SEG_Aseguradoras"
        Me.SEGAseguradorasBindingSource.DataSource = Me.SegurosDS
        '
        'CmbTipo
        '
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"Nuevo", "Renovacion", "Externo", "Mutualista", "Plan Piso", "No Aplica"})
        Me.CmbTipo.Location = New System.Drawing.Point(190, 31)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(100, 21)
        Me.CmbTipo.TabIndex = 101
        '
        'TxtPol
        '
        Me.TxtPol.Location = New System.Drawing.Point(20, 33)
        Me.TxtPol.MaxLength = 25
        Me.TxtPol.Name = "TxtPol"
        Me.TxtPol.Size = New System.Drawing.Size(157, 20)
        Me.TxtPol.TabIndex = 100
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(732, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "Total"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Aseguradora"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Fecha Inicia"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(17, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "Poliza"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SEGPolizasBienesBindingSource
        '
        Me.SEGPolizasBienesBindingSource.DataMember = "SEG_PolizasBienes"
        Me.SEGPolizasBienesBindingSource.DataSource = Me.SegurosDS
        '
        'ActifijoTableAdapter
        '
        Me.ActifijoTableAdapter.ClearBeforeFill = True
        '
        'SEG_AseguradorasTableAdapter
        '
        Me.SEG_AseguradorasTableAdapter.ClearBeforeFill = True
        '
        'SEG_PolizasBienesTableAdapter
        '
        Me.SEG_PolizasBienesTableAdapter.ClearBeforeFill = True
        '
        'GroupLOC
        '
        Me.GroupLOC.Controls.Add(Me.TxtidCli)
        Me.GroupLOC.Controls.Add(Me.Label20)
        Me.GroupLOC.Controls.Add(Me.DtInstall)
        Me.GroupLOC.Controls.Add(Me.Label19)
        Me.GroupLOC.Controls.Add(Me.BttCancel2)
        Me.GroupLOC.Controls.Add(Me.DTpago)
        Me.GroupLOC.Controls.Add(Me.DTsolic)
        Me.GroupLOC.Controls.Add(Me.Label6)
        Me.GroupLOC.Controls.Add(Me.Label8)
        Me.GroupLOC.Controls.Add(Me.TxtImpo)
        Me.GroupLOC.Controls.Add(Me.Label13)
        Me.GroupLOC.Controls.Add(Me.DTTermina)
        Me.GroupLOC.Controls.Add(Me.Txtendoso)
        Me.GroupLOC.Controls.Add(Me.CmbAeg2)
        Me.GroupLOC.Controls.Add(Me.Cmbplataforma)
        Me.GroupLOC.Controls.Add(Me.TxtFactura)
        Me.GroupLOC.Controls.Add(Me.Label14)
        Me.GroupLOC.Controls.Add(Me.Label15)
        Me.GroupLOC.Controls.Add(Me.Label16)
        Me.GroupLOC.Controls.Add(Me.Label17)
        Me.GroupLOC.Controls.Add(Me.Label18)
        Me.GroupLOC.Controls.Add(Me.BttSave)
        Me.GroupLOC.Controls.Add(Me.TxtIDloc)
        Me.GroupLOC.Location = New System.Drawing.Point(12, 491)
        Me.GroupLOC.Name = "GroupLOC"
        Me.GroupLOC.Size = New System.Drawing.Size(898, 115)
        Me.GroupLOC.TabIndex = 112
        Me.GroupLOC.TabStop = False
        Me.GroupLOC.Text = "Localizador"
        '
        'TxtidCli
        '
        Me.TxtidCli.Location = New System.Drawing.Point(731, 40)
        Me.TxtidCli.MaxLength = 15
        Me.TxtidCli.Name = "TxtidCli"
        Me.TxtidCli.Size = New System.Drawing.Size(142, 20)
        Me.TxtidCli.TabIndex = 206
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(728, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 13)
        Me.Label20.TabIndex = 211
        Me.Label20.Text = "ID Cliente"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DtInstall
        '
        Me.DtInstall.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtInstall.Location = New System.Drawing.Point(624, 40)
        Me.DtInstall.Name = "DtInstall"
        Me.DtInstall.Size = New System.Drawing.Size(100, 20)
        Me.DtInstall.TabIndex = 205
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(621, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 13)
        Me.Label19.TabIndex = 208
        Me.Label19.Text = "Fecha Instalacion"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BttCancel2
        '
        Me.BttCancel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttCancel2.Location = New System.Drawing.Point(676, 82)
        Me.BttCancel2.Name = "BttCancel2"
        Me.BttCancel2.Size = New System.Drawing.Size(67, 24)
        Me.BttCancel2.TabIndex = 211
        Me.BttCancel2.Text = "Cancelar"
        Me.BttCancel2.UseVisualStyleBackColor = True
        '
        'DTpago
        '
        Me.DTpago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTpago.Location = New System.Drawing.Point(518, 40)
        Me.DTpago.Name = "DTpago"
        Me.DTpago.Size = New System.Drawing.Size(100, 20)
        Me.DTpago.TabIndex = 204
        '
        'DTsolic
        '
        Me.DTsolic.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTsolic.Location = New System.Drawing.Point(407, 40)
        Me.DTsolic.Name = "DTsolic"
        Me.DTsolic.Size = New System.Drawing.Size(100, 20)
        Me.DTsolic.TabIndex = 203
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(515, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Fecha de Pago"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(404, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Fecha Solicitada"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtImpo
        '
        Me.TxtImpo.Location = New System.Drawing.Point(183, 41)
        Me.TxtImpo.Name = "TxtImpo"
        Me.TxtImpo.Size = New System.Drawing.Size(102, 20)
        Me.TxtImpo.TabIndex = 201
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(180, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 106
        Me.Label13.Text = "Importe"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DTTermina
        '
        Me.DTTermina.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTTermina.Location = New System.Drawing.Point(299, 41)
        Me.DTTermina.Name = "DTTermina"
        Me.DTTermina.Size = New System.Drawing.Size(100, 20)
        Me.DTTermina.TabIndex = 202
        '
        'Txtendoso
        '
        Me.Txtendoso.Location = New System.Drawing.Point(99, 86)
        Me.Txtendoso.MaxLength = 50
        Me.Txtendoso.Name = "Txtendoso"
        Me.Txtendoso.Size = New System.Drawing.Size(189, 20)
        Me.Txtendoso.TabIndex = 208
        '
        'CmbAeg2
        '
        Me.CmbAeg2.DataSource = Me.SEGAseguradorasCopyBindingSource
        Me.CmbAeg2.DisplayMember = "Aseguradora"
        Me.CmbAeg2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAeg2.FormattingEnabled = True
        Me.CmbAeg2.Location = New System.Drawing.Point(299, 85)
        Me.CmbAeg2.Name = "CmbAeg2"
        Me.CmbAeg2.Size = New System.Drawing.Size(273, 21)
        Me.CmbAeg2.TabIndex = 209
        Me.CmbAeg2.ValueMember = "IdAseguradora"
        '
        'SEGAseguradorasCopyBindingSource
        '
        Me.SEGAseguradorasCopyBindingSource.DataMember = "SEG_AseguradorasCopy"
        Me.SEGAseguradorasCopyBindingSource.DataSource = Me.SegurosDS
        '
        'Cmbplataforma
        '
        Me.Cmbplataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbplataforma.FormattingEnabled = True
        Me.Cmbplataforma.Items.AddRange(New Object() {"No", "Si"})
        Me.Cmbplataforma.Location = New System.Drawing.Point(20, 85)
        Me.Cmbplataforma.Name = "Cmbplataforma"
        Me.Cmbplataforma.Size = New System.Drawing.Size(73, 21)
        Me.Cmbplataforma.TabIndex = 207
        '
        'TxtFactura
        '
        Me.TxtFactura.Location = New System.Drawing.Point(20, 41)
        Me.TxtFactura.MaxLength = 25
        Me.TxtFactura.Name = "TxtFactura"
        Me.TxtFactura.Size = New System.Drawing.Size(157, 20)
        Me.TxtFactura.TabIndex = 200
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(99, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "Endoso"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(299, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 95
        Me.Label15.Text = "Aseguradora"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(296, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 93
        Me.Label16.Text = "Fecha Termina"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 92
        Me.Label17.Text = "En Platadorma"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(17, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 16)
        Me.Label18.TabIndex = 91
        Me.Label18.Text = "Factura"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BttSave
        '
        Me.BttSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttSave.Location = New System.Drawing.Point(594, 82)
        Me.BttSave.Name = "BttSave"
        Me.BttSave.Size = New System.Drawing.Size(67, 24)
        Me.BttSave.TabIndex = 210
        Me.BttSave.Text = "Guadar"
        Me.BttSave.UseVisualStyleBackColor = True
        '
        'TxtIDloc
        '
        Me.TxtIDloc.Location = New System.Drawing.Point(602, 82)
        Me.TxtIDloc.Name = "TxtIDloc"
        Me.TxtIDloc.ReadOnly = True
        Me.TxtIDloc.Size = New System.Drawing.Size(23, 20)
        Me.TxtIDloc.TabIndex = 210
        '
        'SEG_AseguradorasCopyTableAdapter
        '
        Me.SEG_AseguradorasCopyTableAdapter.ClearBeforeFill = True
        '
        'GridPolizas
        '
        Me.GridPolizas.AllowUserToAddRows = False
        Me.GridPolizas.AllowUserToDeleteRows = False
        Me.GridPolizas.AutoGenerateColumns = False
        Me.GridPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPolizas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpolizaDataGridViewTextBoxColumn, Me.Poliza, Me.TipoDataGridViewTextBoxColumn, Me.FechaIniciaDataGridViewTextBoxColumn, Me.FechaTerminaDataGridViewTextBoxColumn, Me.PrimaDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.FecLimPagoDataGridViewTextBoxColumn, Me.Aseguradora, Me.IdAseguradoraDataGridViewTextBoxColumn, Me.IdActivoDataGridViewTextBoxColumn, Me.Observaciones})
        Me.GridPolizas.DataSource = Me.SEGPolizasBienesBindingSource
        Me.GridPolizas.Location = New System.Drawing.Point(18, 372)
        Me.GridPolizas.Name = "GridPolizas"
        Me.GridPolizas.ReadOnly = True
        Me.GridPolizas.Size = New System.Drawing.Size(882, 113)
        Me.GridPolizas.TabIndex = 114
        '
        'IdpolizaDataGridViewTextBoxColumn
        '
        Me.IdpolizaDataGridViewTextBoxColumn.DataPropertyName = "Id_poliza"
        Me.IdpolizaDataGridViewTextBoxColumn.HeaderText = "Id_poliza"
        Me.IdpolizaDataGridViewTextBoxColumn.Name = "IdpolizaDataGridViewTextBoxColumn"
        Me.IdpolizaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdpolizaDataGridViewTextBoxColumn.Visible = False
        '
        'Poliza
        '
        Me.Poliza.DataPropertyName = "Poliza"
        Me.Poliza.HeaderText = "Poliza"
        Me.Poliza.Name = "Poliza"
        Me.Poliza.ReadOnly = True
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Visible = False
        '
        'FechaIniciaDataGridViewTextBoxColumn
        '
        Me.FechaIniciaDataGridViewTextBoxColumn.DataPropertyName = "FechaInicia"
        Me.FechaIniciaDataGridViewTextBoxColumn.HeaderText = "Fecha Inicia"
        Me.FechaIniciaDataGridViewTextBoxColumn.Name = "FechaIniciaDataGridViewTextBoxColumn"
        Me.FechaIniciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaTerminaDataGridViewTextBoxColumn
        '
        Me.FechaTerminaDataGridViewTextBoxColumn.DataPropertyName = "FechaTermina"
        Me.FechaTerminaDataGridViewTextBoxColumn.HeaderText = "Fecha Termina"
        Me.FechaTerminaDataGridViewTextBoxColumn.Name = "FechaTerminaDataGridViewTextBoxColumn"
        Me.FechaTerminaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaTerminaDataGridViewTextBoxColumn.Width = 110
        '
        'PrimaDataGridViewTextBoxColumn
        '
        Me.PrimaDataGridViewTextBoxColumn.DataPropertyName = "Prima"
        Me.PrimaDataGridViewTextBoxColumn.HeaderText = "Prima"
        Me.PrimaDataGridViewTextBoxColumn.Name = "PrimaDataGridViewTextBoxColumn"
        Me.PrimaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FecLimPagoDataGridViewTextBoxColumn
        '
        Me.FecLimPagoDataGridViewTextBoxColumn.DataPropertyName = "FecLimPago"
        Me.FecLimPagoDataGridViewTextBoxColumn.HeaderText = "Fec. Lim. Pago"
        Me.FecLimPagoDataGridViewTextBoxColumn.Name = "FecLimPagoDataGridViewTextBoxColumn"
        Me.FecLimPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FecLimPagoDataGridViewTextBoxColumn.Width = 120
        '
        'Aseguradora
        '
        Me.Aseguradora.DataPropertyName = "Aseguradora"
        Me.Aseguradora.HeaderText = "Aseguradora"
        Me.Aseguradora.Name = "Aseguradora"
        Me.Aseguradora.ReadOnly = True
        Me.Aseguradora.Width = 200
        '
        'IdAseguradoraDataGridViewTextBoxColumn
        '
        Me.IdAseguradoraDataGridViewTextBoxColumn.DataPropertyName = "idAseguradora"
        Me.IdAseguradoraDataGridViewTextBoxColumn.HeaderText = "idAseguradora"
        Me.IdAseguradoraDataGridViewTextBoxColumn.Name = "IdAseguradoraDataGridViewTextBoxColumn"
        Me.IdAseguradoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAseguradoraDataGridViewTextBoxColumn.Visible = False
        '
        'IdActivoDataGridViewTextBoxColumn
        '
        Me.IdActivoDataGridViewTextBoxColumn.DataPropertyName = "idActivo"
        Me.IdActivoDataGridViewTextBoxColumn.HeaderText = "idActivo"
        Me.IdActivoDataGridViewTextBoxColumn.Name = "IdActivoDataGridViewTextBoxColumn"
        Me.IdActivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdActivoDataGridViewTextBoxColumn.Visible = False
        '
        'Observaciones
        '
        Me.Observaciones.DataPropertyName = "Observaciones"
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Width = 200
        '
        'FrmPolLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 618)
        Me.Controls.Add(Me.GridPolizas)
        Me.Controls.Add(Me.GroupLOC)
        Me.Controls.Add(Me.GroupDatos)
        Me.Controls.Add(Me.GroupClientes)
        Me.Name = "FrmPolLoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura de polizas y Localizadores Satelitales"
        Me.GroupClientes.ResumeLayout(False)
        Me.GroupClientes.PerformLayout()
        CType(Me.GridActivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActifijoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDatos.ResumeLayout(False)
        Me.GroupDatos.PerformLayout()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGPolizasBienesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupLOC.ResumeLayout(False)
        Me.GroupLOC.PerformLayout()
        CType(Me.SEGAseguradorasCopyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupClientes As System.Windows.Forms.GroupBox
    Friend WithEvents BttLOCNew As System.Windows.Forms.Button
    Friend WithEvents BttAltaNew As System.Windows.Forms.Button
    Friend WithEvents CmbAnexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents Txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SegurosDS As Agil.SegurosDS
    Friend WithEvents ClientesTableAdapter As Agil.SegurosDSTableAdapters.ClientesTableAdapter
    Friend WithEvents AnexosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexosTableAdapter As Agil.SegurosDSTableAdapters.AnexosTableAdapter
    Friend WithEvents GroupDatos As System.Windows.Forms.GroupBox
    Friend WithEvents DtFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPrima As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DTini As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents CmbAseg As System.Windows.Forms.ComboBox
    Friend WithEvents CmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPol As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DTpag As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BttAltCancel As System.Windows.Forms.Button
    Friend WithEvents BttAlta As System.Windows.Forms.Button
    Friend WithEvents GridActivos As System.Windows.Forms.DataGridView
    Friend WithEvents ActifijoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActifijoTableAdapter As Agil.SegurosDSTableAdapters.ActifijoTableAdapter
    Friend WithEvents SEGAseguradorasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEG_AseguradorasTableAdapter As Agil.SegurosDSTableAdapters.SEG_AseguradorasTableAdapter
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlacaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEGPolizasBienesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEG_PolizasBienesTableAdapter As Agil.SegurosDSTableAdapters.SEG_PolizasBienesTableAdapter
    Friend WithEvents TxtidActivo As System.Windows.Forms.TextBox
    Friend WithEvents GroupLOC As System.Windows.Forms.GroupBox
    Friend WithEvents BttCancel2 As System.Windows.Forms.Button
    Friend WithEvents BttSave As System.Windows.Forms.Button
    Friend WithEvents DTpago As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTsolic As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtImpo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DTTermina As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txtendoso As System.Windows.Forms.TextBox
    Friend WithEvents CmbAeg2 As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbplataforma As System.Windows.Forms.ComboBox
    Friend WithEvents TxtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DtInstall As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents SEGAseguradorasCopyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEG_AseguradorasCopyTableAdapter As Agil.SegurosDSTableAdapters.SEG_AseguradorasCopyTableAdapter
    Friend WithEvents TxtIDloc As System.Windows.Forms.TextBox
    Friend WithEvents BttDevol As System.Windows.Forms.Button
    Friend WithEvents BttModPol As System.Windows.Forms.Button
    Friend WithEvents TxtStatus As System.Windows.Forms.TextBox
    Friend WithEvents TxtSerie As System.Windows.Forms.TextBox
    Friend WithEvents TxtidCli As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Txtobserv As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GridPolizas As DataGridView
    Friend WithEvents IdpolizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Poliza As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaIniciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaTerminaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecLimPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Aseguradora As DataGridViewTextBoxColumn
    Friend WithEvents IdAseguradoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdActivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
End Class
