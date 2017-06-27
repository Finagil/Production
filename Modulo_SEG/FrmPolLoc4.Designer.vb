<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPolLoc4
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
        Me.GroupClientes = New System.Windows.Forms.GroupBox
        Me.TxtAnexo = New System.Windows.Forms.TextBox
        Me.ActifijoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS
        Me.TxtSerie = New System.Windows.Forms.TextBox
        Me.GridActivos = New System.Windows.Forms.DataGridView
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnexoCon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BttLOCNew = New System.Windows.Forms.Button
        Me.TxtidActivo = New System.Windows.Forms.TextBox
        Me.SEGAseguradorasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActifijoTableAdapter = New Agil.SegurosDSTableAdapters.ActifijoTableAdapter
        Me.SEG_AseguradorasTableAdapter = New Agil.SegurosDSTableAdapters.SEG_AseguradorasTableAdapter
        Me.GroupLOC = New System.Windows.Forms.GroupBox
        Me.TxtidCli = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.DtInstall = New System.Windows.Forms.DateTimePicker
        Me.Label19 = New System.Windows.Forms.Label
        Me.BttCancel2 = New System.Windows.Forms.Button
        Me.DTpago = New System.Windows.Forms.DateTimePicker
        Me.DTsolic = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtImpo = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.DTTermina = New System.Windows.Forms.DateTimePicker
        Me.Txtendoso = New System.Windows.Forms.TextBox
        Me.CmbAeg2 = New System.Windows.Forms.ComboBox
        Me.SEGAseguradorasCopyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cmbplataforma = New System.Windows.Forms.ComboBox
        Me.TxtFactura = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.BttSave = New System.Windows.Forms.Button
        Me.TxtIDloc = New System.Windows.Forms.TextBox
        Me.SEG_AseguradorasCopyTableAdapter = New Agil.SegurosDSTableAdapters.SEG_AseguradorasCopyTableAdapter
        Me.ActifijoIITableAdapter = New Agil.SegurosDSTableAdapters.ActifijoIITableAdapter
        Me.GroupClientes.SuspendLayout()
        CType(Me.ActifijoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupLOC.SuspendLayout()
        CType(Me.SEGAseguradorasCopyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupClientes
        '
        Me.GroupClientes.Controls.Add(Me.TxtAnexo)
        Me.GroupClientes.Controls.Add(Me.TxtSerie)
        Me.GroupClientes.Controls.Add(Me.GridActivos)
        Me.GroupClientes.Controls.Add(Me.BttLOCNew)
        Me.GroupClientes.Controls.Add(Me.TxtidActivo)
        Me.GroupClientes.Location = New System.Drawing.Point(12, 12)
        Me.GroupClientes.Name = "GroupClientes"
        Me.GroupClientes.Size = New System.Drawing.Size(898, 242)
        Me.GroupClientes.TabIndex = 8
        Me.GroupClientes.TabStop = False
        Me.GroupClientes.Text = "Selecionar Bienes"
        '
        'TxtAnexo
        '
        Me.TxtAnexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "AnexoCon", True))
        Me.TxtAnexo.Location = New System.Drawing.Point(827, 103)
        Me.TxtAnexo.Name = "TxtAnexo"
        Me.TxtAnexo.ReadOnly = True
        Me.TxtAnexo.Size = New System.Drawing.Size(46, 20)
        Me.TxtAnexo.TabIndex = 115
        '
        'ActifijoBindingSource
        '
        Me.ActifijoBindingSource.DataMember = "ActifijoII"
        Me.ActifijoBindingSource.DataSource = Me.SegurosDS
        '
        'SegurosDS
        '
        Me.SegurosDS.DataSetName = "SegurosDS"
        Me.SegurosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtSerie
        '
        Me.TxtSerie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "Serie", True))
        Me.TxtSerie.Location = New System.Drawing.Point(827, 129)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.ReadOnly = True
        Me.TxtSerie.Size = New System.Drawing.Size(46, 20)
        Me.TxtSerie.TabIndex = 114
        '
        'GridActivos
        '
        Me.GridActivos.AllowUserToAddRows = False
        Me.GridActivos.AllowUserToDeleteRows = False
        Me.GridActivos.AutoGenerateColumns = False
        Me.GridActivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.GridActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridActivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.Descr, Me.AnexoCon, Me.ID, Me.DetalleDataGridViewTextBoxColumn, Me.Tipo, Me.ModeloDataGridViewTextBoxColumn, Me.MotorDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.PlacaDataGridViewTextBoxColumn})
        Me.GridActivos.DataSource = Me.ActifijoBindingSource
        Me.GridActivos.Location = New System.Drawing.Point(6, 17)
        Me.GridActivos.MultiSelect = False
        Me.GridActivos.Name = "GridActivos"
        Me.GridActivos.ReadOnly = True
        Me.GridActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridActivos.Size = New System.Drawing.Size(815, 187)
        Me.GridActivos.TabIndex = 113
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Visible = False
        '
        'Descr
        '
        Me.Descr.DataPropertyName = "Descr"
        Me.Descr.HeaderText = "Cliente"
        Me.Descr.Name = "Descr"
        Me.Descr.ReadOnly = True
        Me.Descr.Width = 250
        '
        'AnexoCon
        '
        Me.AnexoCon.DataPropertyName = "AnexoCon"
        Me.AnexoCon.HeaderText = "Contrato"
        Me.AnexoCon.Name = "AnexoCon"
        Me.AnexoCon.ReadOnly = True
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
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DetalleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DetalleDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DetalleDataGridViewTextBoxColumn.Name = "DetalleDataGridViewTextBoxColumn"
        Me.DetalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleDataGridViewTextBoxColumn.Width = 250
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
        'BttLOCNew
        '
        Me.BttLOCNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttLOCNew.Location = New System.Drawing.Point(780, 210)
        Me.BttLOCNew.Name = "BttLOCNew"
        Me.BttLOCNew.Size = New System.Drawing.Size(93, 25)
        Me.BttLOCNew.TabIndex = 107
        Me.BttLOCNew.Text = "Localizador"
        Me.BttLOCNew.UseVisualStyleBackColor = True
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
        'SEGAseguradorasBindingSource
        '
        Me.SEGAseguradorasBindingSource.DataMember = "SEG_Aseguradoras"
        Me.SEGAseguradorasBindingSource.DataSource = Me.SegurosDS
        '
        'ActifijoTableAdapter
        '
        Me.ActifijoTableAdapter.ClearBeforeFill = True
        '
        'SEG_AseguradorasTableAdapter
        '
        Me.SEG_AseguradorasTableAdapter.ClearBeforeFill = True
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
        Me.GroupLOC.Location = New System.Drawing.Point(12, 260)
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
        'ActifijoIITableAdapter
        '
        Me.ActifijoIITableAdapter.ClearBeforeFill = True
        '
        'FrmPolLoc4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 388)
        Me.Controls.Add(Me.GroupLOC)
        Me.Controls.Add(Me.GroupClientes)
        Me.Name = "FrmPolLoc4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura de Localizadores Satelitales"
        Me.GroupClientes.ResumeLayout(False)
        Me.GroupClientes.PerformLayout()
        CType(Me.ActifijoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridActivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupLOC.ResumeLayout(False)
        Me.GroupLOC.PerformLayout()
        CType(Me.SEGAseguradorasCopyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupClientes As System.Windows.Forms.GroupBox
    Friend WithEvents BttLOCNew As System.Windows.Forms.Button
    Friend WithEvents SegurosDS As Agil.SegurosDS
    Friend WithEvents ActifijoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActifijoTableAdapter As Agil.SegurosDSTableAdapters.ActifijoTableAdapter
    Friend WithEvents SEGAseguradorasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEG_AseguradorasTableAdapter As Agil.SegurosDSTableAdapters.SEG_AseguradorasTableAdapter
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
    Friend WithEvents TxtidCli As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ActifijoIITableAdapter As Agil.SegurosDSTableAdapters.ActifijoIITableAdapter
    Friend WithEvents GridActivos As System.Windows.Forms.DataGridView
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnexoCon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlacaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents TxtSerie As System.Windows.Forms.TextBox
End Class
