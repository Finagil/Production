<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPolLoc3
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
        Me.BttModPol = New System.Windows.Forms.Button
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
        Me.ActifijoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS
        Me.TxtidActivo = New System.Windows.Forms.TextBox
        Me.GroupDatos = New System.Windows.Forms.GroupBox
        Me.CmbPagada = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbEntregada = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbGPS = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbUdi = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Txtobserv = New System.Windows.Forms.TextBox
        Me.BttAltCancel = New System.Windows.Forms.Button
        Me.BttAlta = New System.Windows.Forms.Button
        Me.DTpag = New System.Windows.Forms.DateTimePicker
        Me.DtFin = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPrima = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DTini = New System.Windows.Forms.DateTimePicker
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.CmbAseg = New System.Windows.Forms.ComboBox
        Me.SEGAseguradorasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbTipo = New System.Windows.Forms.ComboBox
        Me.TxtPol = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtIdpol = New System.Windows.Forms.TextBox
        Me.SEG_AseguradorasTableAdapter = New Agil.SegurosDSTableAdapters.SEG_AseguradorasTableAdapter
        Me.SEGAseguradorasCopyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SEG_AseguradorasCopyTableAdapter = New Agil.SegurosDSTableAdapters.SEG_AseguradorasCopyTableAdapter
        Me.ActifijoIITableAdapter = New Agil.SegurosDSTableAdapters.ActifijoIITableAdapter
        Me.SeG_PolizasBienesTableAdapter = New Agil.SegurosDSTableAdapters.SEG_PolizasBienesTableAdapter
        Me.GroupClientes.SuspendLayout()
        CType(Me.GridActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActifijoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDatos.SuspendLayout()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGAseguradorasCopyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupClientes
        '
        Me.GroupClientes.Controls.Add(Me.BttModPol)
        Me.GroupClientes.Controls.Add(Me.GridActivos)
        Me.GroupClientes.Controls.Add(Me.TxtidActivo)
        Me.GroupClientes.Location = New System.Drawing.Point(12, 12)
        Me.GroupClientes.Name = "GroupClientes"
        Me.GroupClientes.Size = New System.Drawing.Size(898, 242)
        Me.GroupClientes.TabIndex = 8
        Me.GroupClientes.TabStop = False
        Me.GroupClientes.Text = "Selecionar Polizas"
        '
        'BttModPol
        '
        Me.BttModPol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttModPol.Location = New System.Drawing.Point(769, 210)
        Me.BttModPol.Name = "BttModPol"
        Me.BttModPol.Size = New System.Drawing.Size(112, 22)
        Me.BttModPol.TabIndex = 114
        Me.BttModPol.Text = "Modificar Poliza"
        Me.BttModPol.UseVisualStyleBackColor = True
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
        Me.GridActivos.Location = New System.Drawing.Point(6, 19)
        Me.GridActivos.MultiSelect = False
        Me.GridActivos.Name = "GridActivos"
        Me.GridActivos.ReadOnly = True
        Me.GridActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridActivos.Size = New System.Drawing.Size(886, 187)
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
        'TxtidActivo
        '
        Me.TxtidActivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "ID", True))
        Me.TxtidActivo.Location = New System.Drawing.Point(151, 139)
        Me.TxtidActivo.Name = "TxtidActivo"
        Me.TxtidActivo.ReadOnly = True
        Me.TxtidActivo.Size = New System.Drawing.Size(46, 20)
        Me.TxtidActivo.TabIndex = 112
        '
        'GroupDatos
        '
        Me.GroupDatos.Controls.Add(Me.CmbPagada)
        Me.GroupDatos.Controls.Add(Me.Label1)
        Me.GroupDatos.Controls.Add(Me.CmbEntregada)
        Me.GroupDatos.Controls.Add(Me.Label3)
        Me.GroupDatos.Controls.Add(Me.CmbGPS)
        Me.GroupDatos.Controls.Add(Me.Label6)
        Me.GroupDatos.Controls.Add(Me.CmbUdi)
        Me.GroupDatos.Controls.Add(Me.Label8)
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
        Me.GroupDatos.Controls.Add(Me.TxtIdpol)
        Me.GroupDatos.Location = New System.Drawing.Point(12, 259)
        Me.GroupDatos.Name = "GroupDatos"
        Me.GroupDatos.Size = New System.Drawing.Size(898, 141)
        Me.GroupDatos.TabIndex = 95
        Me.GroupDatos.TabStop = False
        Me.GroupDatos.Text = "Datos de la Poliza"
        '
        'CmbPagada
        '
        Me.CmbPagada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPagada.FormattingEnabled = True
        Me.CmbPagada.Items.AddRange(New Object() {"SI", "NO"})
        Me.CmbPagada.Location = New System.Drawing.Point(113, 114)
        Me.CmbPagada.Name = "CmbPagada"
        Me.CmbPagada.Size = New System.Drawing.Size(84, 21)
        Me.CmbPagada.TabIndex = 123
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Pagada"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbEntregada
        '
        Me.CmbEntregada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEntregada.FormattingEnabled = True
        Me.CmbEntregada.Items.AddRange(New Object() {"SI", "NO"})
        Me.CmbEntregada.Location = New System.Drawing.Point(23, 114)
        Me.CmbEntregada.Name = "CmbEntregada"
        Me.CmbEntregada.Size = New System.Drawing.Size(84, 21)
        Me.CmbEntregada.TabIndex = 122
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Entregada"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbGPS
        '
        Me.CmbGPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGPS.Enabled = False
        Me.CmbGPS.FormattingEnabled = True
        Me.CmbGPS.Items.AddRange(New Object() {"SI", "NO"})
        Me.CmbGPS.Location = New System.Drawing.Point(776, 73)
        Me.CmbGPS.Name = "CmbGPS"
        Me.CmbGPS.Size = New System.Drawing.Size(84, 21)
        Me.CmbGPS.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(789, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Con GPS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbUdi
        '
        Me.CmbUdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUdi.Enabled = False
        Me.CmbUdi.FormattingEnabled = True
        Me.CmbUdi.Items.AddRange(New Object() {"10%", "15%"})
        Me.CmbUdi.Location = New System.Drawing.Point(686, 73)
        Me.CmbUdi.Name = "CmbUdi"
        Me.CmbUdi.Size = New System.Drawing.Size(84, 21)
        Me.CmbUdi.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(683, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "UDIS %"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Txtobserv.ReadOnly = True
        Me.Txtobserv.Size = New System.Drawing.Size(381, 20)
        Me.Txtobserv.TabIndex = 107
        '
        'BttAltCancel
        '
        Me.BttAltCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttAltCancel.Location = New System.Drawing.Point(792, 105)
        Me.BttAltCancel.Name = "BttAltCancel"
        Me.BttAltCancel.Size = New System.Drawing.Size(67, 24)
        Me.BttAltCancel.TabIndex = 111
        Me.BttAltCancel.Text = "Cancelar"
        Me.BttAltCancel.UseVisualStyleBackColor = True
        '
        'BttAlta
        '
        Me.BttAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttAlta.Location = New System.Drawing.Point(717, 105)
        Me.BttAlta.Name = "BttAlta"
        Me.BttAlta.Size = New System.Drawing.Size(67, 24)
        Me.BttAlta.TabIndex = 110
        Me.BttAlta.Text = "Guardar"
        Me.BttAlta.UseVisualStyleBackColor = True
        '
        'DTpag
        '
        Me.DTpag.Enabled = False
        Me.DTpag.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTpag.Location = New System.Drawing.Point(518, 32)
        Me.DTpag.Name = "DTpag"
        Me.DTpag.Size = New System.Drawing.Size(100, 20)
        Me.DTpag.TabIndex = 104
        '
        'DtFin
        '
        Me.DtFin.Enabled = False
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
        Me.TxtPrima.ReadOnly = True
        Me.TxtPrima.Size = New System.Drawing.Size(112, 20)
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
        Me.DTini.Enabled = False
        Me.DTini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTini.Location = New System.Drawing.Point(299, 33)
        Me.DTini.Name = "DTini"
        Me.DTini.Size = New System.Drawing.Size(100, 20)
        Me.DTini.TabIndex = 102
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(748, 31)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(112, 20)
        Me.TxtTotal.TabIndex = 106
        '
        'CmbAseg
        '
        Me.CmbAseg.DataSource = Me.SEGAseguradorasBindingSource
        Me.CmbAseg.DisplayMember = "Aseguradora"
        Me.CmbAseg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAseg.Enabled = False
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
        Me.CmbTipo.Enabled = False
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
        Me.TxtPol.ReadOnly = True
        Me.TxtPol.Size = New System.Drawing.Size(157, 20)
        Me.TxtPol.TabIndex = 100
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(745, 14)
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
        'TxtIdpol
        '
        Me.TxtIdpol.Location = New System.Drawing.Point(717, 105)
        Me.TxtIdpol.Name = "TxtIdpol"
        Me.TxtIdpol.ReadOnly = True
        Me.TxtIdpol.Size = New System.Drawing.Size(12, 20)
        Me.TxtIdpol.TabIndex = 112
        '
        'SEG_AseguradorasTableAdapter
        '
        Me.SEG_AseguradorasTableAdapter.ClearBeforeFill = True
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
        'ActifijoIITableAdapter
        '
        Me.ActifijoIITableAdapter.ClearBeforeFill = True
        '
        'SeG_PolizasBienesTableAdapter
        '
        Me.SeG_PolizasBienesTableAdapter.ClearBeforeFill = True
        '
        'FrmPolLoc3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 407)
        Me.Controls.Add(Me.GroupDatos)
        Me.Controls.Add(Me.GroupClientes)
        Me.Name = "FrmPolLoc3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Polizas Entregada-Pagada"
        Me.GroupClientes.ResumeLayout(False)
        Me.GroupClientes.PerformLayout()
        CType(Me.GridActivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActifijoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDatos.ResumeLayout(False)
        Me.GroupDatos.PerformLayout()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGAseguradorasCopyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupClientes As System.Windows.Forms.GroupBox
    Friend WithEvents SegurosDS As Agil.SegurosDS
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
    Friend WithEvents SEGAseguradorasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEG_AseguradorasTableAdapter As Agil.SegurosDSTableAdapters.SEG_AseguradorasTableAdapter
    Friend WithEvents TxtidActivo As System.Windows.Forms.TextBox
    Friend WithEvents SEGAseguradorasCopyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEG_AseguradorasCopyTableAdapter As Agil.SegurosDSTableAdapters.SEG_AseguradorasCopyTableAdapter
    Friend WithEvents BttModPol As System.Windows.Forms.Button
    Friend WithEvents TxtIdpol As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Txtobserv As System.Windows.Forms.TextBox
    Friend WithEvents CmbGPS As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbUdi As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ActifijoIITableAdapter As Agil.SegurosDSTableAdapters.ActifijoIITableAdapter
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
    Friend WithEvents CmbPagada As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbEntregada As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SeG_PolizasBienesTableAdapter As Agil.SegurosDSTableAdapters.SEG_PolizasBienesTableAdapter
End Class
