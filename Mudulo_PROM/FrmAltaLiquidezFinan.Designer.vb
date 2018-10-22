<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaLiquidezFinan
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PROMSolicitudesLIQBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS = New Agil.PromocionDS()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNumAmort = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPagofin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GridIngresos = New System.Windows.Forms.DataGridView()
        Me.IdimporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROMSolicitudesLIQImportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GridPagosBC = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROMSolicitudesLIQImportesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS1 = New Agil.PromocionDS()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CmbExpe = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmboAtrasos = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbClaves = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PROM_SolicitudesLIQTableAdapter = New Agil.PromocionDSTableAdapters.PROM_SolicitudesLIQTableAdapter()
        Me.PROM_SolicitudesLIQ_ImportesTableAdapter = New Agil.PromocionDSTableAdapters.PROM_SolicitudesLIQ_ImportesTableAdapter()
        CType(Me.PROMSolicitudesLIQBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROMSolicitudesLIQImportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPagosBC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROMSolicitudesLIQImportesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto Solicitado"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "MontoFinanciado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextBox1.Location = New System.Drawing.Point(16, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'PROMSolicitudesLIQBindingSource
        '
        Me.PROMSolicitudesLIQBindingSource.DataMember = "PROM_SolicitudesLIQ"
        Me.PROMSolicitudesLIQBindingSource.DataSource = Me.PromocionDS
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Plazo", True))
        Me.TextBox2.Location = New System.Drawing.Point(122, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Plazo"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Periodicidad", True))
        Me.TextBox3.Location = New System.Drawing.Point(228, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Periodicidad"
        '
        'TxtNumAmort
        '
        Me.TxtNumAmort.Location = New System.Drawing.Point(334, 24)
        Me.TxtNumAmort.Name = "TxtNumAmort"
        Me.TxtNumAmort.ReadOnly = True
        Me.TxtNumAmort.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumAmort.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(331, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No. Amortizaciones"
        '
        'TxtPagofin
        '
        Me.TxtPagofin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "PagoFinagil", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtPagofin.Location = New System.Drawing.Point(16, 67)
        Me.TxtPagofin.Name = "TxtPagofin"
        Me.TxtPagofin.Size = New System.Drawing.Size(100, 20)
        Me.TxtPagofin.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Pago Finagil"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Ingresos Netos Mensuales"
        '
        'GridIngresos
        '
        Me.GridIngresos.AutoGenerateColumns = False
        Me.GridIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridIngresos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdimporteDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.IdSolicitudDataGridViewTextBoxColumn})
        Me.GridIngresos.DataSource = Me.PROMSolicitudesLIQImportesBindingSource
        Me.GridIngresos.Location = New System.Drawing.Point(16, 230)
        Me.GridIngresos.Name = "GridIngresos"
        Me.GridIngresos.Size = New System.Drawing.Size(152, 150)
        Me.GridIngresos.TabIndex = 19
        '
        'IdimporteDataGridViewTextBoxColumn
        '
        Me.IdimporteDataGridViewTextBoxColumn.DataPropertyName = "id_importe"
        Me.IdimporteDataGridViewTextBoxColumn.HeaderText = "id_importe"
        Me.IdimporteDataGridViewTextBoxColumn.Name = "IdimporteDataGridViewTextBoxColumn"
        Me.IdimporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdimporteDataGridViewTextBoxColumn.Visible = False
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.Visible = False
        '
        'IdSolicitudDataGridViewTextBoxColumn
        '
        Me.IdSolicitudDataGridViewTextBoxColumn.DataPropertyName = "Id_Solicitud"
        Me.IdSolicitudDataGridViewTextBoxColumn.HeaderText = "Id_Solicitud"
        Me.IdSolicitudDataGridViewTextBoxColumn.Name = "IdSolicitudDataGridViewTextBoxColumn"
        Me.IdSolicitudDataGridViewTextBoxColumn.Visible = False
        '
        'PROMSolicitudesLIQImportesBindingSource
        '
        Me.PROMSolicitudesLIQImportesBindingSource.DataMember = "PROM_SolicitudesLIQ_Importes"
        Me.PROMSolicitudesLIQImportesBindingSource.DataSource = Me.PromocionDS
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(173, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Egresos netos Mesuales (BC y Otros)"
        '
        'GridPagosBC
        '
        Me.GridPagosBC.AutoGenerateColumns = False
        Me.GridPagosBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPagosBC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.GridPagosBC.DataSource = Me.PROMSolicitudesLIQImportesBindingSource1
        Me.GridPagosBC.Location = New System.Drawing.Point(176, 231)
        Me.GridPagosBC.Name = "GridPagosBC"
        Me.GridPagosBC.Size = New System.Drawing.Size(152, 150)
        Me.GridPagosBC.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_importe"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_importe"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Importe"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Id_Solicitud"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id_Solicitud"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'PROMSolicitudesLIQImportesBindingSource1
        '
        Me.PROMSolicitudesLIQImportesBindingSource1.DataMember = "PROM_SolicitudesLIQ_Importes"
        Me.PROMSolicitudesLIQImportesBindingSource1.DataSource = Me.PromocionDS1
        '
        'PromocionDS1
        '
        Me.PromocionDS1.DataSetName = "PromocionDS"
        Me.PromocionDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Calcular RDC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(102, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "RCD"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "RCD", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "p2"))
        Me.TextBox6.Location = New System.Drawing.Point(105, 407)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(47, 20)
        Me.TextBox6.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(351, 405)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Procesar Solicitud"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CmbExpe
        '
        Me.CmbExpe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "ExperienciaBC", True))
        Me.CmbExpe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbExpe.FormattingEnabled = True
        Me.CmbExpe.Items.AddRange(New Object() {"PAGOS PUNTUALES/SIN EXPERIENCIA", "≤ 10 ATRASOS DE HASTA 29 DÍAS ", "> 10 ATRASOS DE HASTA 29 DÍAS"})
        Me.CmbExpe.Location = New System.Drawing.Point(16, 149)
        Me.CmbExpe.Name = "CmbExpe"
        Me.CmbExpe.Size = New System.Drawing.Size(418, 21)
        Me.CmbExpe.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Experiencia de Pago"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Atrasos Vigentes"
        '
        'CmboAtrasos
        '
        Me.CmboAtrasos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "AtrasosBC", True))
        Me.CmboAtrasos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboAtrasos.FormattingEnabled = True
        Me.CmboAtrasos.Items.AddRange(New Object() {"SIN ATRASOS VIGENTES", "CON ATRASOS VIGENTES < AL 10% DEL MONTO SOLICITADO DE HASTA 29 DÍAS", "CON ATRASOS VIGENTES > AL 10% DEL MONTO SOLICITADO DE HASTA 29 DÍAS"})
        Me.CmboAtrasos.Location = New System.Drawing.Point(16, 189)
        Me.CmboAtrasos.Name = "CmboAtrasos"
        Me.CmboAtrasos.Size = New System.Drawing.Size(418, 21)
        Me.CmboAtrasos.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Claves de Prevención"
        '
        'CmbClaves
        '
        Me.CmbClaves.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "ClavesBC", True))
        Me.CmbClaves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClaves.FormattingEnabled = True
        Me.CmbClaves.Items.AddRange(New Object() {"SIN CLAVES DE PREVENCIÓN", "CON CLAVES DE PREVENCION = COMUNICACIONES", "CON CLAVES DE PREVENCIÓN <> COMUNICACIONES"})
        Me.CmbClaves.Location = New System.Drawing.Point(16, 107)
        Me.CmbClaves.Name = "CmbClaves"
        Me.CmbClaves.Size = New System.Drawing.Size(418, 21)
        Me.CmbClaves.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Estatus", True))
        Me.TextBox4.Location = New System.Drawing.Point(158, 407)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(170, 20)
        Me.TextBox4.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(155, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Estatus"
        '
        'PROM_SolicitudesLIQTableAdapter
        '
        Me.PROM_SolicitudesLIQTableAdapter.ClearBeforeFill = True
        '
        'PROM_SolicitudesLIQ_ImportesTableAdapter
        '
        Me.PROM_SolicitudesLIQ_ImportesTableAdapter.ClearBeforeFill = True
        '
        'FrmAltaLiquidezFinan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 435)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CmbClaves)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CmboAtrasos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmbExpe)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GridPagosBC)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GridIngresos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtPagofin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNumAmort)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "MontoFinanciado", True))
        Me.Name = "FrmAltaLiquidezFinan"
        Me.Text = "Datos Financieros Liquidez Inmediata"
        CType(Me.PROMSolicitudesLIQBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROMSolicitudesLIQImportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPagosBC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROMSolicitudesLIQImportesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNumAmort As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPagofin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PromocionDS As PromocionDS
    Friend WithEvents PROMSolicitudesLIQBindingSource As BindingSource
    Friend WithEvents PROM_SolicitudesLIQTableAdapter As PromocionDSTableAdapters.PROM_SolicitudesLIQTableAdapter
    Friend WithEvents Label9 As Label
    Friend WithEvents GridIngresos As DataGridView
    Friend WithEvents IdimporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdSolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PROMSolicitudesLIQImportesBindingSource As BindingSource
    Friend WithEvents PROM_SolicitudesLIQ_ImportesTableAdapter As PromocionDSTableAdapters.PROM_SolicitudesLIQ_ImportesTableAdapter
    Friend WithEvents Label10 As Label
    Friend WithEvents GridPagosBC As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents PromocionDS1 As PromocionDS
    Friend WithEvents PROMSolicitudesLIQImportesBindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents CmbExpe As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CmboAtrasos As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CmbClaves As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
End Class
