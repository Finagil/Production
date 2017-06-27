<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSegFactoraje
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbCliente = New System.Windows.Forms.ComboBox
        Me.FactorClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS
        Me.Factor_ClientesTableAdapter = New Agil.SegurosDSTableAdapters.Factor_ClientesTableAdapter
        Me.TxtLinea = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtVigencia = New System.Windows.Forms.TextBox
        Me.TxtMoneda = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbTipoSeg = New System.Windows.Forms.ComboBox
        Me.CmbAseg = New System.Windows.Forms.ComboBox
        Me.SEGAseguradorasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtEndoso = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtSumaAseg = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.DPVigencia = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GridDeudores = New System.Windows.Forms.DataGridView
        Me.Id_Deudor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DeudorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoSeguroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AseguradoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EndosoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SumaAseguradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VigenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VWDedudoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Factor_DeudoresTableAdapter = New Agil.SegurosDSTableAdapters.Factor_DeudoresTableAdapter
        Me.VW_DedudoresTableAdapter = New Agil.SegurosDSTableAdapters.VW_DedudoresTableAdapter
        Me.SEG_AseguradorasTableAdapter = New Agil.SegurosDSTableAdapters.SEG_AseguradorasTableAdapter
        Me.TxtID = New System.Windows.Forms.TextBox
        CType(Me.FactorClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDeudores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWDedudoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes Factoraje"
        '
        'CmbCliente
        '
        Me.CmbCliente.DataSource = Me.FactorClientesBindingSource
        Me.CmbCliente.DisplayMember = "Nombre"
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(12, 25)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(391, 21)
        Me.CmbCliente.TabIndex = 1
        Me.CmbCliente.ValueMember = "Id_Cliente"
        '
        'FactorClientesBindingSource
        '
        Me.FactorClientesBindingSource.DataMember = "Factor_Clientes"
        Me.FactorClientesBindingSource.DataSource = Me.SegurosDS
        '
        'SegurosDS
        '
        Me.SegurosDS.DataSetName = "SegurosDS"
        Me.SegurosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Factor_ClientesTableAdapter
        '
        Me.Factor_ClientesTableAdapter.ClearBeforeFill = True
        '
        'TxtLinea
        '
        Me.TxtLinea.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FactorClientesBindingSource, "Monto_Linea", True))
        Me.TxtLinea.Enabled = False
        Me.TxtLinea.Location = New System.Drawing.Point(12, 69)
        Me.TxtLinea.Name = "TxtLinea"
        Me.TxtLinea.Size = New System.Drawing.Size(106, 20)
        Me.TxtLinea.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Monto de la Linea"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Vigenia de la Linea"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Moneda"
        '
        'TxtVigencia
        '
        Me.TxtVigencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FactorClientesBindingSource, "Vigencia", True))
        Me.TxtVigencia.Enabled = False
        Me.TxtVigencia.Location = New System.Drawing.Point(124, 69)
        Me.TxtVigencia.Name = "TxtVigencia"
        Me.TxtVigencia.Size = New System.Drawing.Size(106, 20)
        Me.TxtVigencia.TabIndex = 6
        '
        'TxtMoneda
        '
        Me.TxtMoneda.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FactorClientesBindingSource, "Moneda", True))
        Me.TxtMoneda.Enabled = False
        Me.TxtMoneda.Location = New System.Drawing.Point(236, 69)
        Me.TxtMoneda.Name = "TxtMoneda"
        Me.TxtMoneda.Size = New System.Drawing.Size(106, 20)
        Me.TxtMoneda.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(12, 109)
        Me.TxtNombre.MaxLength = 80
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(218, 20)
        Me.TxtNombre.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(233, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tipo Seguro"
        '
        'CmbTipoSeg
        '
        Me.CmbTipoSeg.FormattingEnabled = True
        Me.CmbTipoSeg.Items.AddRange(New Object() {"INTERNO", "EXTERNO"})
        Me.CmbTipoSeg.Location = New System.Drawing.Point(236, 108)
        Me.CmbTipoSeg.Name = "CmbTipoSeg"
        Me.CmbTipoSeg.Size = New System.Drawing.Size(121, 21)
        Me.CmbTipoSeg.TabIndex = 11
        '
        'CmbAseg
        '
        Me.CmbAseg.DataSource = Me.SEGAseguradorasBindingSource
        Me.CmbAseg.DisplayMember = "Aseguradora"
        Me.CmbAseg.FormattingEnabled = True
        Me.CmbAseg.Location = New System.Drawing.Point(363, 108)
        Me.CmbAseg.Name = "CmbAseg"
        Me.CmbAseg.Size = New System.Drawing.Size(172, 21)
        Me.CmbAseg.TabIndex = 13
        Me.CmbAseg.ValueMember = "IdAseguradora"
        '
        'SEGAseguradorasBindingSource
        '
        Me.SEGAseguradorasBindingSource.DataMember = "SEG_Aseguradoras"
        Me.SEGAseguradorasBindingSource.DataSource = Me.SegurosDS
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(360, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Aseguradora"
        '
        'TxtEndoso
        '
        Me.TxtEndoso.Location = New System.Drawing.Point(541, 108)
        Me.TxtEndoso.MaxLength = 10
        Me.TxtEndoso.Name = "TxtEndoso"
        Me.TxtEndoso.Size = New System.Drawing.Size(81, 20)
        Me.TxtEndoso.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(540, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Endoso"
        '
        'TxtSumaAseg
        '
        Me.TxtSumaAseg.Location = New System.Drawing.Point(628, 109)
        Me.TxtSumaAseg.MaxLength = 15
        Me.TxtSumaAseg.Name = "TxtSumaAseg"
        Me.TxtSumaAseg.Size = New System.Drawing.Size(81, 20)
        Me.TxtSumaAseg.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(627, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Suma Asegurada"
        '
        'DPVigencia
        '
        Me.DPVigencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPVigencia.Location = New System.Drawing.Point(715, 109)
        Me.DPVigencia.Name = "DPVigencia"
        Me.DPVigencia.Size = New System.Drawing.Size(105, 20)
        Me.DPVigencia.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(712, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Vigencia"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Agregar Dedudor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GridDeudores
        '
        Me.GridDeudores.AllowUserToAddRows = False
        Me.GridDeudores.AllowUserToOrderColumns = True
        Me.GridDeudores.AutoGenerateColumns = False
        Me.GridDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDeudores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Deudor, Me.DeudorDataGridViewTextBoxColumn, Me.TipoSeguroDataGridViewTextBoxColumn, Me.AseguradoraDataGridViewTextBoxColumn, Me.EndosoDataGridViewTextBoxColumn, Me.SumaAseguradaDataGridViewTextBoxColumn, Me.VigenciaDataGridViewTextBoxColumn})
        Me.GridDeudores.DataSource = Me.VWDedudoresBindingSource
        Me.GridDeudores.Location = New System.Drawing.Point(15, 165)
        Me.GridDeudores.Name = "GridDeudores"
        Me.GridDeudores.ReadOnly = True
        Me.GridDeudores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDeudores.Size = New System.Drawing.Size(803, 224)
        Me.GridDeudores.TabIndex = 21
        '
        'Id_Deudor
        '
        Me.Id_Deudor.DataPropertyName = "Id_Deudor"
        Me.Id_Deudor.HeaderText = "Id_Deudor"
        Me.Id_Deudor.Name = "Id_Deudor"
        Me.Id_Deudor.ReadOnly = True
        Me.Id_Deudor.Visible = False
        '
        'DeudorDataGridViewTextBoxColumn
        '
        Me.DeudorDataGridViewTextBoxColumn.DataPropertyName = "Deudor"
        Me.DeudorDataGridViewTextBoxColumn.HeaderText = "Deudor"
        Me.DeudorDataGridViewTextBoxColumn.Name = "DeudorDataGridViewTextBoxColumn"
        Me.DeudorDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeudorDataGridViewTextBoxColumn.Width = 250
        '
        'TipoSeguroDataGridViewTextBoxColumn
        '
        Me.TipoSeguroDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Seguro"
        Me.TipoSeguroDataGridViewTextBoxColumn.HeaderText = "Tipo Seguro"
        Me.TipoSeguroDataGridViewTextBoxColumn.Name = "TipoSeguroDataGridViewTextBoxColumn"
        Me.TipoSeguroDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoSeguroDataGridViewTextBoxColumn.Width = 80
        '
        'AseguradoraDataGridViewTextBoxColumn
        '
        Me.AseguradoraDataGridViewTextBoxColumn.DataPropertyName = "Aseguradora"
        Me.AseguradoraDataGridViewTextBoxColumn.HeaderText = "Aseguradora"
        Me.AseguradoraDataGridViewTextBoxColumn.Name = "AseguradoraDataGridViewTextBoxColumn"
        Me.AseguradoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.AseguradoraDataGridViewTextBoxColumn.Width = 150
        '
        'EndosoDataGridViewTextBoxColumn
        '
        Me.EndosoDataGridViewTextBoxColumn.DataPropertyName = "Endoso"
        Me.EndosoDataGridViewTextBoxColumn.HeaderText = "Endoso"
        Me.EndosoDataGridViewTextBoxColumn.Name = "EndosoDataGridViewTextBoxColumn"
        Me.EndosoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EndosoDataGridViewTextBoxColumn.Width = 80
        '
        'SumaAseguradaDataGridViewTextBoxColumn
        '
        Me.SumaAseguradaDataGridViewTextBoxColumn.DataPropertyName = "Suma_Asegurada"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.SumaAseguradaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.SumaAseguradaDataGridViewTextBoxColumn.HeaderText = "Suma Asegurada"
        Me.SumaAseguradaDataGridViewTextBoxColumn.Name = "SumaAseguradaDataGridViewTextBoxColumn"
        Me.SumaAseguradaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VigenciaDataGridViewTextBoxColumn
        '
        Me.VigenciaDataGridViewTextBoxColumn.DataPropertyName = "Vigencia"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.VigenciaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.VigenciaDataGridViewTextBoxColumn.HeaderText = "Vigencia"
        Me.VigenciaDataGridViewTextBoxColumn.Name = "VigenciaDataGridViewTextBoxColumn"
        Me.VigenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VWDedudoresBindingSource
        '
        Me.VWDedudoresBindingSource.DataMember = "VW_Dedudores"
        Me.VWDedudoresBindingSource.DataSource = Me.SegurosDS
        '
        'Factor_DeudoresTableAdapter
        '
        Me.Factor_DeudoresTableAdapter.ClearBeforeFill = True
        '
        'VW_DedudoresTableAdapter
        '
        Me.VW_DedudoresTableAdapter.ClearBeforeFill = True
        '
        'SEG_AseguradorasTableAdapter
        '
        Me.SEG_AseguradorasTableAdapter.ClearBeforeFill = True
        '
        'TxtID
        '
        Me.TxtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWDedudoresBindingSource, "Id_Deudor", True))
        Me.TxtID.Enabled = False
        Me.TxtID.Location = New System.Drawing.Point(173, 139)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(106, 20)
        Me.TxtID.TabIndex = 22
        '
        'FrmSegFactoraje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 401)
        Me.Controls.Add(Me.GridDeudores)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DPVigencia)
        Me.Controls.Add(Me.TxtSumaAseg)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtEndoso)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbAseg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmbTipoSeg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtMoneda)
        Me.Controls.Add(Me.TxtVigencia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtLinea)
        Me.Controls.Add(Me.TxtID)
        Me.Name = "FrmSegFactoraje"
        Me.Text = "Polizas Factoraje"
        CType(Me.FactorClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDeudores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWDedudoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents SegurosDS As Agil.SegurosDS
    Friend WithEvents FactorClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Factor_ClientesTableAdapter As Agil.SegurosDSTableAdapters.Factor_ClientesTableAdapter
    Friend WithEvents TxtLinea As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtVigencia As System.Windows.Forms.TextBox
    Friend WithEvents TxtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbTipoSeg As System.Windows.Forms.ComboBox
    Friend WithEvents CmbAseg As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtEndoso As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtSumaAseg As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DPVigencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridDeudores As System.Windows.Forms.DataGridView
    Friend WithEvents Factor_DeudoresTableAdapter As Agil.SegurosDSTableAdapters.Factor_DeudoresTableAdapter
    Friend WithEvents VW_DedudoresTableAdapter As Agil.SegurosDSTableAdapters.VW_DedudoresTableAdapter
    Friend WithEvents VWDedudoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEGAseguradorasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEG_AseguradorasTableAdapter As Agil.SegurosDSTableAdapters.SEG_AseguradorasTableAdapter
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Id_Deudor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeudorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoSeguroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AseguradoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndosoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SumaAseguradaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VigenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
