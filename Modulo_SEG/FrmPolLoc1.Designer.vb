<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPolLoc1
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
        Me.GroupClientes = New System.Windows.Forms.GroupBox
        Me.GridActivos = New System.Windows.Forms.DataGridView
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ActifijoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS
        Me.BttAltaNew = New System.Windows.Forms.Button
        Me.CmbAnexo = New System.Windows.Forms.ComboBox
        Me.AnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbClientes = New System.Windows.Forms.ComboBox
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Txtfiltro = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtidActivo = New System.Windows.Forms.TextBox
        Me.TxtStatus = New System.Windows.Forms.TextBox
        Me.TxtSerie = New System.Windows.Forms.TextBox
        Me.ClientesTableAdapter = New Agil.SegurosDSTableAdapters.ClientesTableAdapter
        Me.AnexosTableAdapter = New Agil.SegurosDSTableAdapters.AnexosTableAdapter
        Me.GroupDatos = New System.Windows.Forms.GroupBox
        Me.CmbGPS = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbUdi = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Txtobserv = New System.Windows.Forms.TextBox
        Me.SEGPolizasBienesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BttAltCancel = New System.Windows.Forms.Button
        Me.BttAlta = New System.Windows.Forms.Button
        Me.CmbAseg = New System.Windows.Forms.ComboBox
        Me.SEGAseguradorasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbTipo = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtIdpol = New System.Windows.Forms.TextBox
        Me.ActifijoTableAdapter = New Agil.SegurosDSTableAdapters.ActifijoTableAdapter
        Me.SEG_AseguradorasTableAdapter = New Agil.SegurosDSTableAdapters.SEG_AseguradorasTableAdapter
        Me.SEG_PolizasBienesTableAdapter = New Agil.SegurosDSTableAdapters.SEG_PolizasBienesTableAdapter
        Me.SEGAseguradorasCopyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SEG_AseguradorasCopyTableAdapter = New Agil.SegurosDSTableAdapters.SEG_AseguradorasCopyTableAdapter
        Me.GridPolizas = New System.Windows.Forms.DataGridView
        Me.IdpolizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Poliza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaIniciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaTerminaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrimaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FecLimPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Aseguradora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdAseguradoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdActivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupClientes.SuspendLayout()
        CType(Me.GridActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActifijoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDatos.SuspendLayout()
        CType(Me.SEGPolizasBienesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGAseguradorasCopyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupClientes
        '
        Me.GroupClientes.Controls.Add(Me.GridActivos)
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
        'BttAltaNew
        '
        Me.BttAltaNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttAltaNew.Location = New System.Drawing.Point(346, 89)
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
        Me.GroupDatos.Controls.Add(Me.CmbGPS)
        Me.GroupDatos.Controls.Add(Me.Label5)
        Me.GroupDatos.Controls.Add(Me.CmbUdi)
        Me.GroupDatos.Controls.Add(Me.Label4)
        Me.GroupDatos.Controls.Add(Me.Label21)
        Me.GroupDatos.Controls.Add(Me.Txtobserv)
        Me.GroupDatos.Controls.Add(Me.BttAltCancel)
        Me.GroupDatos.Controls.Add(Me.BttAlta)
        Me.GroupDatos.Controls.Add(Me.CmbAseg)
        Me.GroupDatos.Controls.Add(Me.CmbTipo)
        Me.GroupDatos.Controls.Add(Me.Label7)
        Me.GroupDatos.Controls.Add(Me.Label2)
        Me.GroupDatos.Controls.Add(Me.TxtIdpol)
        Me.GroupDatos.Location = New System.Drawing.Point(12, 259)
        Me.GroupDatos.Name = "GroupDatos"
        Me.GroupDatos.Size = New System.Drawing.Size(898, 109)
        Me.GroupDatos.TabIndex = 95
        Me.GroupDatos.TabStop = False
        Me.GroupDatos.Text = "Datos de la Poliza"
        '
        'CmbGPS
        '
        Me.CmbGPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGPS.FormattingEnabled = True
        Me.CmbGPS.Items.AddRange(New Object() {"SI", "NO"})
        Me.CmbGPS.Location = New System.Drawing.Point(503, 34)
        Me.CmbGPS.Name = "CmbGPS"
        Me.CmbGPS.Size = New System.Drawing.Size(100, 21)
        Me.CmbGPS.TabIndex = 109
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(500, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Con GPS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbUdi
        '
        Me.CmbUdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUdi.FormattingEnabled = True
        Me.CmbUdi.Items.AddRange(New Object() {"10%", "15%"})
        Me.CmbUdi.Location = New System.Drawing.Point(397, 34)
        Me.CmbUdi.Name = "CmbUdi"
        Me.CmbUdi.Size = New System.Drawing.Size(100, 21)
        Me.CmbUdi.TabIndex = 108
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(394, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "UDIS %"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 13)
        Me.Label21.TabIndex = 114
        Me.Label21.Text = "Observaciones"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txtobserv
        '
        Me.Txtobserv.Location = New System.Drawing.Point(12, 78)
        Me.Txtobserv.MaxLength = 200
        Me.Txtobserv.Name = "Txtobserv"
        Me.Txtobserv.Size = New System.Drawing.Size(381, 20)
        Me.Txtobserv.TabIndex = 110
        '
        'SEGPolizasBienesBindingSource
        '
        Me.SEGPolizasBienesBindingSource.DataMember = "SEG_PolizasBienes"
        Me.SEGPolizasBienesBindingSource.DataSource = Me.SegurosDS
        '
        'BttAltCancel
        '
        Me.BttAltCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttAltCancel.Location = New System.Drawing.Point(503, 74)
        Me.BttAltCancel.Name = "BttAltCancel"
        Me.BttAltCancel.Size = New System.Drawing.Size(67, 24)
        Me.BttAltCancel.TabIndex = 112
        Me.BttAltCancel.Text = "Cancelar"
        Me.BttAltCancel.UseVisualStyleBackColor = True
        '
        'BttAlta
        '
        Me.BttAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttAlta.Location = New System.Drawing.Point(419, 74)
        Me.BttAlta.Name = "BttAlta"
        Me.BttAlta.Size = New System.Drawing.Size(67, 24)
        Me.BttAlta.TabIndex = 111
        Me.BttAlta.Text = "Alta"
        Me.BttAlta.UseVisualStyleBackColor = True
        '
        'CmbAseg
        '
        Me.CmbAseg.DataSource = Me.SEGAseguradorasBindingSource
        Me.CmbAseg.DisplayMember = "Aseguradora"
        Me.CmbAseg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAseg.FormattingEnabled = True
        Me.CmbAseg.Location = New System.Drawing.Point(118, 34)
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
        Me.CmbTipo.Location = New System.Drawing.Point(12, 34)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(100, 21)
        Me.CmbTipo.TabIndex = 101
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(118, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Aseguradora"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtIdpol
        '
        Me.TxtIdpol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGPolizasBienesBindingSource, "Id_poliza", True))
        Me.TxtIdpol.Location = New System.Drawing.Point(232, 35)
        Me.TxtIdpol.Name = "TxtIdpol"
        Me.TxtIdpol.ReadOnly = True
        Me.TxtIdpol.Size = New System.Drawing.Size(32, 20)
        Me.TxtIdpol.TabIndex = 112
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
        'SEGAseguradorasCopyBindingSource
        '
        Me.SEGAseguradorasCopyBindingSource.DataMember = "SEG_AseguradorasCopy"
        Me.SEGAseguradorasCopyBindingSource.DataSource = Me.SegurosDS
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
        Me.GridPolizas.Location = New System.Drawing.Point(24, 377)
        Me.GridPolizas.Name = "GridPolizas"
        Me.GridPolizas.ReadOnly = True
        Me.GridPolizas.Size = New System.Drawing.Size(878, 113)
        Me.GridPolizas.TabIndex = 112
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
        'FrmPolLoc1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 502)
        Me.Controls.Add(Me.GridPolizas)
        Me.Controls.Add(Me.GroupDatos)
        Me.Controls.Add(Me.GroupClientes)
        Me.Name = "FrmPolLoc1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de polizas"
        Me.GroupClientes.ResumeLayout(False)
        Me.GroupClientes.PerformLayout()
        CType(Me.GridActivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActifijoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDatos.ResumeLayout(False)
        Me.GroupDatos.PerformLayout()
        CType(Me.SEGPolizasBienesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGAseguradorasCopyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupClientes As System.Windows.Forms.GroupBox
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
    Friend WithEvents CmbAseg As System.Windows.Forms.ComboBox
    Friend WithEvents CmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents SEGAseguradorasCopyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEG_AseguradorasCopyTableAdapter As Agil.SegurosDSTableAdapters.SEG_AseguradorasCopyTableAdapter
    Friend WithEvents TxtIdpol As System.Windows.Forms.TextBox
    Friend WithEvents TxtStatus As System.Windows.Forms.TextBox
    Friend WithEvents TxtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Txtobserv As System.Windows.Forms.TextBox
    Friend WithEvents CmbGPS As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbUdi As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridPolizas As System.Windows.Forms.DataGridView
    Friend WithEvents IdpolizaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Poliza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaIniciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaTerminaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecLimPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aseguradora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdAseguradoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdActivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
