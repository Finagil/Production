<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTablasESP_PROM
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbCLI = New System.Windows.Forms.ComboBox()
        Me.ClientesTablaESPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS = New Agil.PromocionDS()
        Me.AnexosTablaESPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexosTablaESPTableAdapter = New Agil.PromocionDSTableAdapters.AnexosTablaESPTableAdapter()
        Me.ClientesTablaESPTableAdapter = New Agil.PromocionDSTableAdapters.ClientesTablaESPTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbAnexos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtMF = New System.Windows.Forms.TextBox()
        Me.CmbTipoTasa = New System.Windows.Forms.ComboBox()
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.TxtDif = New System.Windows.Forms.TextBox()
        Me.TxtPorcComi = New System.Windows.Forms.TextBox()
        Me.TxtComi = New System.Windows.Forms.TextBox()
        Me.TxtGastos = New System.Windows.Forms.TextBox()
        Me.TxtIvaGtos = New System.Windows.Forms.TextBox()
        Me.TxtTasaMora = New System.Windows.Forms.TextBox()
        Me.TxtTasPen = New System.Windows.Forms.TextBox()
        Me.TxtRD = New System.Windows.Forms.TextBox()
        Me.TxtDere = New System.Windows.Forms.TextBox()
        Me.TxtPlazo = New System.Windows.Forms.TextBox()
        Me.TxtImpRd = New System.Windows.Forms.TextBox()
        Me.TxtIvaRd = New System.Windows.Forms.TextBox()
        Me.TxtDG = New System.Windows.Forms.TextBox()
        Me.TxtIvadg = New System.Windows.Forms.TextBox()
        Me.TxtTipta = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FevenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NufacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndrecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbcapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaCapitalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComFegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvacomFegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TablaESPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TablaESPTableAdapter = New Agil.PromocionDSTableAdapters.TablaESPTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaInteresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaCapitalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TablaESPTMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Bttclear = New System.Windows.Forms.Button()
        Me.BttPaste = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtFEcCon = New System.Windows.Forms.TextBox()
        Me.BtnDomi = New System.Windows.Forms.Button()
        Me.TxtDomi = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtTasaIvaCap = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxtTipar = New System.Windows.Forms.TextBox()
        Me.LbTipoP = New System.Windows.Forms.Label()
        Me.CmbAcumInte = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CmbFega = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.CmbLiquidez = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TxtLiquidez = New System.Windows.Forms.TextBox()
        Me.TxtOpcion = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TxtMensu = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.DTPContrato = New System.Windows.Forms.DateTimePicker()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtFvenc = New System.Windows.Forms.TextBox()
        Me.ComboHipotec = New System.Windows.Forms.ComboBox()
        Me.CombopPrenda = New System.Windows.Forms.ComboBox()
        CType(Me.ClientesTablaESPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosTablaESPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaESPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaESPTMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'CmbCLI
        '
        Me.CmbCLI.DataSource = Me.ClientesTablaESPBindingSource
        Me.CmbCLI.DisplayMember = "Descr"
        Me.CmbCLI.FormattingEnabled = True
        Me.CmbCLI.Location = New System.Drawing.Point(12, 25)
        Me.CmbCLI.Name = "CmbCLI"
        Me.CmbCLI.Size = New System.Drawing.Size(478, 21)
        Me.CmbCLI.TabIndex = 1
        Me.CmbCLI.ValueMember = "Cliente"
        '
        'ClientesTablaESPBindingSource
        '
        Me.ClientesTablaESPBindingSource.DataMember = "ClientesTablaESP"
        Me.ClientesTablaESPBindingSource.DataSource = Me.PromocionDS
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnexosTablaESPBindingSource
        '
        Me.AnexosTablaESPBindingSource.DataMember = "AnexosTablaESP"
        Me.AnexosTablaESPBindingSource.DataSource = Me.PromocionDS
        '
        'AnexosTablaESPTableAdapter
        '
        Me.AnexosTablaESPTableAdapter.ClearBeforeFill = True
        '
        'ClientesTablaESPTableAdapter
        '
        Me.ClientesTablaESPTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Anexos"
        '
        'CmbAnexos
        '
        Me.CmbAnexos.DataSource = Me.AnexosTablaESPBindingSource
        Me.CmbAnexos.DisplayMember = "AnexoCon"
        Me.CmbAnexos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnexos.FormattingEnabled = True
        Me.CmbAnexos.Location = New System.Drawing.Point(12, 65)
        Me.CmbAnexos.Name = "CmbAnexos"
        Me.CmbAnexos.Size = New System.Drawing.Size(170, 21)
        Me.CmbAnexos.TabIndex = 3
        Me.CmbAnexos.ValueMember = "Anexo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "TipoCredito", True))
        Me.Label3.Location = New System.Drawing.Point(220, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Anexos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Monto Financiado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tipo Tasa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(104, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tasa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(150, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Diferencial"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(120, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Comisión%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(186, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Comisión"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(246, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Gastos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(337, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Iva Gtos."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(213, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Tasa Mora."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(275, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Tasa Pen."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Num. Rentas"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(94, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Importe Rentas"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(180, 176)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Iva Rentas"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(267, 176)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Dep. en Garantia"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(358, 176)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 13)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Iva Dep. Garantía"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(423, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 13)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Derchos"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(515, 89)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 13)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Plazo"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(457, 176)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 13)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Gtia. Prendaria"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(541, 176)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 13)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Gtia. Hipotecaria"
        '
        'TxtMF
        '
        Me.TxtMF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "MontoFinanciado", True))
        Me.TxtMF.Location = New System.Drawing.Point(16, 106)
        Me.TxtMF.Name = "TxtMF"
        Me.TxtMF.ReadOnly = True
        Me.TxtMF.Size = New System.Drawing.Size(100, 20)
        Me.TxtMF.TabIndex = 3
        Me.TxtMF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbTipoTasa
        '
        Me.CmbTipoTasa.Enabled = False
        Me.CmbTipoTasa.FormattingEnabled = True
        Me.CmbTipoTasa.Items.AddRange(New Object() {"Fija", "Variable"})
        Me.CmbTipoTasa.Location = New System.Drawing.Point(14, 143)
        Me.CmbTipoTasa.Name = "CmbTipoTasa"
        Me.CmbTipoTasa.Size = New System.Drawing.Size(84, 21)
        Me.CmbTipoTasa.TabIndex = 26
        '
        'TxtTasa
        '
        Me.TxtTasa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Tasas", True))
        Me.TxtTasa.Location = New System.Drawing.Point(107, 144)
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.ReadOnly = True
        Me.TxtTasa.Size = New System.Drawing.Size(38, 20)
        Me.TxtTasa.TabIndex = 11
        '
        'TxtDif
        '
        Me.TxtDif.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Difer", True))
        Me.TxtDif.Location = New System.Drawing.Point(153, 144)
        Me.TxtDif.Name = "TxtDif"
        Me.TxtDif.ReadOnly = True
        Me.TxtDif.Size = New System.Drawing.Size(54, 20)
        Me.TxtDif.TabIndex = 12
        '
        'TxtPorcComi
        '
        Me.TxtPorcComi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Porco", True))
        Me.TxtPorcComi.Location = New System.Drawing.Point(123, 105)
        Me.TxtPorcComi.Name = "TxtPorcComi"
        Me.TxtPorcComi.Size = New System.Drawing.Size(54, 20)
        Me.TxtPorcComi.TabIndex = 4
        '
        'TxtComi
        '
        Me.TxtComi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Comis", True))
        Me.TxtComi.Location = New System.Drawing.Point(189, 105)
        Me.TxtComi.Name = "TxtComi"
        Me.TxtComi.ReadOnly = True
        Me.TxtComi.Size = New System.Drawing.Size(54, 20)
        Me.TxtComi.TabIndex = 5
        '
        'TxtGastos
        '
        Me.TxtGastos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Gastos", True))
        Me.TxtGastos.Location = New System.Drawing.Point(249, 106)
        Me.TxtGastos.Name = "TxtGastos"
        Me.TxtGastos.Size = New System.Drawing.Size(81, 20)
        Me.TxtGastos.TabIndex = 6
        '
        'TxtIvaGtos
        '
        Me.TxtIvaGtos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "IvaGastos", True))
        Me.TxtIvaGtos.Location = New System.Drawing.Point(336, 106)
        Me.TxtIvaGtos.Name = "TxtIvaGtos"
        Me.TxtIvaGtos.Size = New System.Drawing.Size(81, 20)
        Me.TxtIvaGtos.TabIndex = 7
        '
        'TxtTasaMora
        '
        Me.TxtTasaMora.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Tasmor", True))
        Me.TxtTasaMora.Location = New System.Drawing.Point(213, 144)
        Me.TxtTasaMora.Name = "TxtTasaMora"
        Me.TxtTasaMora.ReadOnly = True
        Me.TxtTasaMora.Size = New System.Drawing.Size(56, 20)
        Me.TxtTasaMora.TabIndex = 13
        '
        'TxtTasPen
        '
        Me.TxtTasPen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Taspen", True))
        Me.TxtTasPen.Location = New System.Drawing.Point(275, 145)
        Me.TxtTasPen.Name = "TxtTasPen"
        Me.TxtTasPen.ReadOnly = True
        Me.TxtTasPen.Size = New System.Drawing.Size(56, 20)
        Me.TxtTasPen.TabIndex = 14
        '
        'TxtRD
        '
        Me.TxtRD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "NumRentas", True))
        Me.TxtRD.Location = New System.Drawing.Point(15, 192)
        Me.TxtRD.Name = "TxtRD"
        Me.TxtRD.ReadOnly = True
        Me.TxtRD.Size = New System.Drawing.Size(65, 20)
        Me.TxtRD.TabIndex = 15
        '
        'TxtDere
        '
        Me.TxtDere.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Derechos", True))
        Me.TxtDere.Location = New System.Drawing.Point(426, 106)
        Me.TxtDere.Name = "TxtDere"
        Me.TxtDere.Size = New System.Drawing.Size(81, 20)
        Me.TxtDere.TabIndex = 8
        '
        'TxtPlazo
        '
        Me.TxtPlazo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Plazo", True))
        Me.TxtPlazo.Location = New System.Drawing.Point(518, 105)
        Me.TxtPlazo.Name = "TxtPlazo"
        Me.TxtPlazo.ReadOnly = True
        Me.TxtPlazo.Size = New System.Drawing.Size(38, 20)
        Me.TxtPlazo.TabIndex = 9
        '
        'TxtImpRd
        '
        Me.TxtImpRd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "ImporteRD", True))
        Me.TxtImpRd.Location = New System.Drawing.Point(92, 192)
        Me.TxtImpRd.Name = "TxtImpRd"
        Me.TxtImpRd.ReadOnly = True
        Me.TxtImpRd.Size = New System.Drawing.Size(81, 20)
        Me.TxtImpRd.TabIndex = 16
        '
        'TxtIvaRd
        '
        Me.TxtIvaRd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "IvaRD", True))
        Me.TxtIvaRd.Location = New System.Drawing.Point(179, 192)
        Me.TxtIvaRd.Name = "TxtIvaRd"
        Me.TxtIvaRd.ReadOnly = True
        Me.TxtIvaRd.Size = New System.Drawing.Size(81, 20)
        Me.TxtIvaRd.TabIndex = 17
        '
        'TxtDG
        '
        Me.TxtDG.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "ImporteDG", True))
        Me.TxtDG.Location = New System.Drawing.Point(266, 192)
        Me.TxtDG.Name = "TxtDG"
        Me.TxtDG.ReadOnly = True
        Me.TxtDG.Size = New System.Drawing.Size(89, 20)
        Me.TxtDG.TabIndex = 18
        '
        'TxtIvadg
        '
        Me.TxtIvadg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "IvaDG", True))
        Me.TxtIvadg.Location = New System.Drawing.Point(361, 192)
        Me.TxtIvadg.Name = "TxtIvadg"
        Me.TxtIvadg.ReadOnly = True
        Me.TxtIvadg.Size = New System.Drawing.Size(90, 20)
        Me.TxtIvadg.TabIndex = 19
        '
        'TxtTipta
        '
        Me.TxtTipta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Tipta", True))
        Me.TxtTipta.Location = New System.Drawing.Point(48, 144)
        Me.TxtTipta.Name = "TxtTipta"
        Me.TxtTipta.ReadOnly = True
        Me.TxtTipta.Size = New System.Drawing.Size(10, 20)
        Me.TxtTipta.TabIndex = 27
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.LetraDataGridViewTextBoxColumn, Me.FevenDataGridViewTextBoxColumn, Me.NufacDataGridViewTextBoxColumn, Me.IndrecDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn, Me.AbcapDataGridViewTextBoxColumn, Me.InterDataGridViewTextBoxColumn, Me.IvaDataGridViewTextBoxColumn, Me.IvaCapitalDataGridViewTextBoxColumn, Me.ComFegaDataGridViewTextBoxColumn, Me.IvacomFegaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TablaESPBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 235)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(865, 150)
        Me.DataGridView1.TabIndex = 28
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Visible = False
        '
        'LetraDataGridViewTextBoxColumn
        '
        Me.LetraDataGridViewTextBoxColumn.DataPropertyName = "Letra"
        Me.LetraDataGridViewTextBoxColumn.HeaderText = "Letra"
        Me.LetraDataGridViewTextBoxColumn.Name = "LetraDataGridViewTextBoxColumn"
        Me.LetraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FevenDataGridViewTextBoxColumn
        '
        Me.FevenDataGridViewTextBoxColumn.DataPropertyName = "Feven"
        Me.FevenDataGridViewTextBoxColumn.HeaderText = "Fecha Venc."
        Me.FevenDataGridViewTextBoxColumn.Name = "FevenDataGridViewTextBoxColumn"
        Me.FevenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NufacDataGridViewTextBoxColumn
        '
        Me.NufacDataGridViewTextBoxColumn.DataPropertyName = "Nufac"
        Me.NufacDataGridViewTextBoxColumn.HeaderText = "Nufac"
        Me.NufacDataGridViewTextBoxColumn.Name = "NufacDataGridViewTextBoxColumn"
        Me.NufacDataGridViewTextBoxColumn.ReadOnly = True
        Me.NufacDataGridViewTextBoxColumn.Visible = False
        '
        'IndrecDataGridViewTextBoxColumn
        '
        Me.IndrecDataGridViewTextBoxColumn.DataPropertyName = "Indrec"
        Me.IndrecDataGridViewTextBoxColumn.HeaderText = "Indrec"
        Me.IndrecDataGridViewTextBoxColumn.Name = "IndrecDataGridViewTextBoxColumn"
        Me.IndrecDataGridViewTextBoxColumn.ReadOnly = True
        Me.IndrecDataGridViewTextBoxColumn.Visible = False
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        DataGridViewCellStyle1.Format = "n2"
        Me.SaldoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AbcapDataGridViewTextBoxColumn
        '
        Me.AbcapDataGridViewTextBoxColumn.DataPropertyName = "Abcap"
        DataGridViewCellStyle2.Format = "n2"
        Me.AbcapDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.AbcapDataGridViewTextBoxColumn.HeaderText = "Capital"
        Me.AbcapDataGridViewTextBoxColumn.Name = "AbcapDataGridViewTextBoxColumn"
        Me.AbcapDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InterDataGridViewTextBoxColumn
        '
        Me.InterDataGridViewTextBoxColumn.DataPropertyName = "Inter"
        DataGridViewCellStyle3.Format = "n2"
        Me.InterDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.InterDataGridViewTextBoxColumn.HeaderText = "Intereses"
        Me.InterDataGridViewTextBoxColumn.Name = "InterDataGridViewTextBoxColumn"
        Me.InterDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IvaDataGridViewTextBoxColumn
        '
        Me.IvaDataGridViewTextBoxColumn.DataPropertyName = "Iva"
        DataGridViewCellStyle4.Format = "n2"
        Me.IvaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.IvaDataGridViewTextBoxColumn.HeaderText = "Iva Interes"
        Me.IvaDataGridViewTextBoxColumn.Name = "IvaDataGridViewTextBoxColumn"
        Me.IvaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IvaCapitalDataGridViewTextBoxColumn
        '
        Me.IvaCapitalDataGridViewTextBoxColumn.DataPropertyName = "IvaCapital"
        DataGridViewCellStyle5.Format = "n2"
        Me.IvaCapitalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.IvaCapitalDataGridViewTextBoxColumn.HeaderText = "Iva Capital"
        Me.IvaCapitalDataGridViewTextBoxColumn.Name = "IvaCapitalDataGridViewTextBoxColumn"
        Me.IvaCapitalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComFegaDataGridViewTextBoxColumn
        '
        Me.ComFegaDataGridViewTextBoxColumn.DataPropertyName = "comFega"
        Me.ComFegaDataGridViewTextBoxColumn.HeaderText = "comFega"
        Me.ComFegaDataGridViewTextBoxColumn.Name = "ComFegaDataGridViewTextBoxColumn"
        Me.ComFegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ComFegaDataGridViewTextBoxColumn.Visible = False
        '
        'IvacomFegaDataGridViewTextBoxColumn
        '
        Me.IvacomFegaDataGridViewTextBoxColumn.DataPropertyName = "ivacomFega"
        Me.IvacomFegaDataGridViewTextBoxColumn.HeaderText = "ivacomFega"
        Me.IvacomFegaDataGridViewTextBoxColumn.Name = "IvacomFegaDataGridViewTextBoxColumn"
        Me.IvacomFegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IvacomFegaDataGridViewTextBoxColumn.Visible = False
        '
        'TablaESPBindingSource
        '
        Me.TablaESPBindingSource.DataMember = "TablaESP"
        Me.TablaESPBindingSource.DataSource = Me.PromocionDS
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(13, 216)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(89, 13)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "Tabla en Sistema"
        '
        'TablaESPTableAdapter
        '
        Me.TablaESPTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn1, Me.CapitalDataGridViewTextBoxColumn, Me.InteresDataGridViewTextBoxColumn, Me.IvaInteresDataGridViewTextBoxColumn, Me.IvaCapitalDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.TablaESPTMPBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(13, 415)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(865, 162)
        Me.DataGridView2.TabIndex = 30
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha Venc."
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoDataGridViewTextBoxColumn1
        '
        Me.SaldoDataGridViewTextBoxColumn1.DataPropertyName = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn1.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn1.Name = "SaldoDataGridViewTextBoxColumn1"
        Me.SaldoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CapitalDataGridViewTextBoxColumn
        '
        Me.CapitalDataGridViewTextBoxColumn.DataPropertyName = "Capital"
        Me.CapitalDataGridViewTextBoxColumn.HeaderText = "Capital"
        Me.CapitalDataGridViewTextBoxColumn.Name = "CapitalDataGridViewTextBoxColumn"
        Me.CapitalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InteresDataGridViewTextBoxColumn
        '
        Me.InteresDataGridViewTextBoxColumn.DataPropertyName = "Interes"
        Me.InteresDataGridViewTextBoxColumn.HeaderText = "Interes"
        Me.InteresDataGridViewTextBoxColumn.Name = "InteresDataGridViewTextBoxColumn"
        Me.InteresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IvaInteresDataGridViewTextBoxColumn
        '
        Me.IvaInteresDataGridViewTextBoxColumn.DataPropertyName = "IvaInteres"
        Me.IvaInteresDataGridViewTextBoxColumn.HeaderText = "Iva Interes"
        Me.IvaInteresDataGridViewTextBoxColumn.Name = "IvaInteresDataGridViewTextBoxColumn"
        Me.IvaInteresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IvaCapitalDataGridViewTextBoxColumn1
        '
        Me.IvaCapitalDataGridViewTextBoxColumn1.DataPropertyName = "IvaCapital"
        Me.IvaCapitalDataGridViewTextBoxColumn1.HeaderText = "Iva Capital"
        Me.IvaCapitalDataGridViewTextBoxColumn1.Name = "IvaCapitalDataGridViewTextBoxColumn1"
        Me.IvaCapitalDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TablaESPTMPBindingSource
        '
        Me.TablaESPTMPBindingSource.DataMember = "TablaESPTMP"
        Me.TablaESPTMPBindingSource.DataSource = Me.PromocionDS
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(11, 395)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(69, 13)
        Me.Label24.TabIndex = 31
        Me.Label24.Text = "Tabla Nueva"
        '
        'Bttclear
        '
        Me.Bttclear.Location = New System.Drawing.Point(713, 189)
        Me.Bttclear.Name = "Bttclear"
        Me.Bttclear.Size = New System.Drawing.Size(75, 23)
        Me.Bttclear.TabIndex = 32
        Me.Bttclear.Text = "Limpiar Datos"
        Me.Bttclear.UseVisualStyleBackColor = True
        '
        'BttPaste
        '
        Me.BttPaste.Location = New System.Drawing.Point(803, 391)
        Me.BttPaste.Name = "BttPaste"
        Me.BttPaste.Size = New System.Drawing.Size(75, 21)
        Me.BttPaste.TabIndex = 33
        Me.BttPaste.Text = "Pegar"
        Me.BttPaste.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(794, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Flcan", True))
        Me.Label25.Location = New System.Drawing.Point(193, 68)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(21, 13)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Anexos"
        '
        'TxtFEcCon
        '
        Me.TxtFEcCon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Fechacon", True))
        Me.TxtFEcCon.Location = New System.Drawing.Point(720, 142)
        Me.TxtFEcCon.Name = "TxtFEcCon"
        Me.TxtFEcCon.ReadOnly = True
        Me.TxtFEcCon.Size = New System.Drawing.Size(81, 20)
        Me.TxtFEcCon.TabIndex = 38
        '
        'BtnDomi
        '
        Me.BtnDomi.Location = New System.Drawing.Point(632, 189)
        Me.BtnDomi.Name = "BtnDomi"
        Me.BtnDomi.Size = New System.Drawing.Size(75, 23)
        Me.BtnDomi.TabIndex = 40
        Me.BtnDomi.Text = "Act. Domi."
        Me.BtnDomi.UseVisualStyleBackColor = True
        '
        'TxtDomi
        '
        Me.TxtDomi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Autoriza", True))
        Me.TxtDomi.Location = New System.Drawing.Point(562, 106)
        Me.TxtDomi.Name = "TxtDomi"
        Me.TxtDomi.ReadOnly = True
        Me.TxtDomi.Size = New System.Drawing.Size(63, 20)
        Me.TxtDomi.TabIndex = 41
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(559, 90)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 13)
        Me.Label26.TabIndex = 42
        Me.Label26.Text = "Domiciliación"
        '
        'TxtTasaIvaCap
        '
        Me.TxtTasaIvaCap.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "TasaIvaCapital", True))
        Me.TxtTasaIvaCap.Location = New System.Drawing.Point(632, 106)
        Me.TxtTasaIvaCap.Name = "TxtTasaIvaCap"
        Me.TxtTasaIvaCap.ReadOnly = True
        Me.TxtTasaIvaCap.Size = New System.Drawing.Size(71, 20)
        Me.TxtTasaIvaCap.TabIndex = 43
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(629, 90)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(74, 13)
        Me.Label28.TabIndex = 44
        Me.Label28.Text = "Tasa Iva Cap."
        '
        'TxtTipar
        '
        Me.TxtTipar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Tipar", True))
        Me.TxtTipar.Location = New System.Drawing.Point(58, 144)
        Me.TxtTipar.Name = "TxtTipar"
        Me.TxtTipar.ReadOnly = True
        Me.TxtTipar.Size = New System.Drawing.Size(10, 20)
        Me.TxtTipar.TabIndex = 45
        '
        'LbTipoP
        '
        Me.LbTipoP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesTablaESPBindingSource, "Tipo", True))
        Me.LbTipoP.Location = New System.Drawing.Point(496, 28)
        Me.LbTipoP.Name = "LbTipoP"
        Me.LbTipoP.Size = New System.Drawing.Size(21, 13)
        Me.LbTipoP.TabIndex = 46
        Me.LbTipoP.Text = "Anexos"
        '
        'CmbAcumInte
        '
        Me.CmbAcumInte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "AcumulaIntereses", True))
        Me.CmbAcumInte.Enabled = False
        Me.CmbAcumInte.FormattingEnabled = True
        Me.CmbAcumInte.Items.AddRange(New Object() {"NO", "SI"})
        Me.CmbAcumInte.Location = New System.Drawing.Point(340, 145)
        Me.CmbAcumInte.Name = "CmbAcumInte"
        Me.CmbAcumInte.Size = New System.Drawing.Size(84, 21)
        Me.CmbAcumInte.TabIndex = 48
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(341, 131)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(83, 13)
        Me.Label29.TabIndex = 47
        Me.Label29.Text = "Acum. Intereses"
        '
        'CmbFega
        '
        Me.CmbFega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "AcumulaIntereses", True))
        Me.CmbFega.FormattingEnabled = True
        Me.CmbFega.Items.AddRange(New Object() {"NO", "SI"})
        Me.CmbFega.Location = New System.Drawing.Point(433, 145)
        Me.CmbFega.Name = "CmbFega"
        Me.CmbFega.Size = New System.Drawing.Size(84, 21)
        Me.CmbFega.TabIndex = 50
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(434, 131)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(90, 13)
        Me.Label30.TabIndex = 49
        Me.Label30.Text = "Aplica Coberturas"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(530, 129)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(89, 13)
        Me.Label31.TabIndex = 51
        Me.Label31.Text = "Fecha (1er Vecn)"
        '
        'CmbLiquidez
        '
        Me.CmbLiquidez.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "AcumulaIntereses", True))
        Me.CmbLiquidez.Enabled = False
        Me.CmbLiquidez.FormattingEnabled = True
        Me.CmbLiquidez.Items.AddRange(New Object() {"NO", "SI"})
        Me.CmbLiquidez.Location = New System.Drawing.Point(630, 142)
        Me.CmbLiquidez.Name = "CmbLiquidez"
        Me.CmbLiquidez.Size = New System.Drawing.Size(84, 21)
        Me.CmbLiquidez.TabIndex = 54
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(631, 128)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(49, 13)
        Me.Label32.TabIndex = 53
        Me.Label32.Text = "Liquidez "
        '
        'TxtLiquidez
        '
        Me.TxtLiquidez.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "LiquidezInmediata", True))
        Me.TxtLiquidez.Location = New System.Drawing.Point(16, 143)
        Me.TxtLiquidez.Name = "TxtLiquidez"
        Me.TxtLiquidez.ReadOnly = True
        Me.TxtLiquidez.Size = New System.Drawing.Size(18, 20)
        Me.TxtLiquidez.TabIndex = 55
        '
        'TxtOpcion
        '
        Me.TxtOpcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Porop", True))
        Me.TxtOpcion.Location = New System.Drawing.Point(709, 105)
        Me.TxtOpcion.Name = "TxtOpcion"
        Me.TxtOpcion.ReadOnly = True
        Me.TxtOpcion.Size = New System.Drawing.Size(71, 20)
        Me.TxtOpcion.TabIndex = 56
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(706, 89)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(57, 13)
        Me.Label33.TabIndex = 57
        Me.Label33.Text = "Op. Comp."
        '
        'TxtMensu
        '
        Me.TxtMensu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Mensu", True))
        Me.TxtMensu.Location = New System.Drawing.Point(786, 105)
        Me.TxtMensu.Name = "TxtMensu"
        Me.TxtMensu.ReadOnly = True
        Me.TxtMensu.Size = New System.Drawing.Size(71, 20)
        Me.TxtMensu.TabIndex = 58
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(783, 89)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(67, 13)
        Me.Label34.TabIndex = 59
        Me.Label34.Text = "Mensualidad"
        '
        'DTPContrato
        '
        Me.DTPContrato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPContrato.Location = New System.Drawing.Point(720, 141)
        Me.DTPContrato.Name = "DTPContrato"
        Me.DTPContrato.Size = New System.Drawing.Size(96, 20)
        Me.DTPContrato.TabIndex = 61
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(720, 127)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(80, 13)
        Me.Label35.TabIndex = 60
        Me.Label35.Text = "Fecha Contrato"
        '
        'TxtFvenc
        '
        Me.TxtFvenc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Fvenc", True))
        Me.TxtFvenc.Location = New System.Drawing.Point(533, 146)
        Me.TxtFvenc.Name = "TxtFvenc"
        Me.TxtFvenc.ReadOnly = True
        Me.TxtFvenc.Size = New System.Drawing.Size(86, 20)
        Me.TxtFvenc.TabIndex = 62
        '
        'ComboHipotec
        '
        Me.ComboHipotec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "GHipotec", True))
        Me.ComboHipotec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboHipotec.FormattingEnabled = True
        Me.ComboHipotec.Items.AddRange(New Object() {"N", "S"})
        Me.ComboHipotec.Location = New System.Drawing.Point(542, 192)
        Me.ComboHipotec.Name = "ComboHipotec"
        Me.ComboHipotec.Size = New System.Drawing.Size(83, 21)
        Me.ComboHipotec.TabIndex = 21
        '
        'CombopPrenda
        '
        Me.CombopPrenda.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosTablaESPBindingSource, "Prenda", True))
        Me.CombopPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombopPrenda.FormattingEnabled = True
        Me.CombopPrenda.Items.AddRange(New Object() {"N", "S"})
        Me.CombopPrenda.Location = New System.Drawing.Point(456, 193)
        Me.CombopPrenda.Name = "CombopPrenda"
        Me.CombopPrenda.Size = New System.Drawing.Size(81, 21)
        Me.CombopPrenda.TabIndex = 20
        '
        'FrmTablasESP_PROM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 589)
        Me.Controls.Add(Me.ComboHipotec)
        Me.Controls.Add(Me.CombopPrenda)
        Me.Controls.Add(Me.DTPContrato)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.TxtMensu)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.TxtOpcion)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.CmbLiquidez)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.CmbFega)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.CmbAcumInte)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.LbTipoP)
        Me.Controls.Add(Me.TxtTasaIvaCap)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.TxtDomi)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.BtnDomi)
        Me.Controls.Add(Me.TxtFEcCon)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BttPaste)
        Me.Controls.Add(Me.Bttclear)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtIvadg)
        Me.Controls.Add(Me.TxtDG)
        Me.Controls.Add(Me.TxtIvaRd)
        Me.Controls.Add(Me.TxtImpRd)
        Me.Controls.Add(Me.TxtPlazo)
        Me.Controls.Add(Me.TxtDere)
        Me.Controls.Add(Me.TxtRD)
        Me.Controls.Add(Me.TxtTasPen)
        Me.Controls.Add(Me.TxtTasaMora)
        Me.Controls.Add(Me.TxtIvaGtos)
        Me.Controls.Add(Me.TxtGastos)
        Me.Controls.Add(Me.TxtComi)
        Me.Controls.Add(Me.TxtPorcComi)
        Me.Controls.Add(Me.TxtDif)
        Me.Controls.Add(Me.TxtTasa)
        Me.Controls.Add(Me.CmbTipoTasa)
        Me.Controls.Add(Me.TxtMF)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbAnexos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbCLI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTipta)
        Me.Controls.Add(Me.TxtTipar)
        Me.Controls.Add(Me.TxtLiquidez)
        Me.Controls.Add(Me.TxtFvenc)
        Me.Name = "FrmTablasESP_PROM"
        Me.Text = "Carga de Tablas Especiales"
        CType(Me.ClientesTablaESPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosTablaESPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaESPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaESPTMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbCLI As System.Windows.Forms.ComboBox
    Friend WithEvents AnexosTablaESPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PromocionDS As Agil.PromocionDS
    Friend WithEvents AnexosTablaESPTableAdapter As Agil.PromocionDSTableAdapters.AnexosTablaESPTableAdapter
    Friend WithEvents ClientesTablaESPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTablaESPTableAdapter As Agil.PromocionDSTableAdapters.ClientesTablaESPTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbAnexos As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtMF As System.Windows.Forms.TextBox
    Friend WithEvents CmbTipoTasa As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTasa As System.Windows.Forms.TextBox
    Friend WithEvents TxtDif As System.Windows.Forms.TextBox
    Friend WithEvents TxtPorcComi As System.Windows.Forms.TextBox
    Friend WithEvents TxtComi As System.Windows.Forms.TextBox
    Friend WithEvents TxtGastos As System.Windows.Forms.TextBox
    Friend WithEvents TxtIvaGtos As System.Windows.Forms.TextBox
    Friend WithEvents TxtTasaMora As System.Windows.Forms.TextBox
    Friend WithEvents TxtTasPen As System.Windows.Forms.TextBox
    Friend WithEvents TxtRD As System.Windows.Forms.TextBox
    Friend WithEvents TxtDere As System.Windows.Forms.TextBox
    Friend WithEvents TxtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents TxtImpRd As System.Windows.Forms.TextBox
    Friend WithEvents TxtIvaRd As System.Windows.Forms.TextBox
    Friend WithEvents TxtDG As System.Windows.Forms.TextBox
    Friend WithEvents TxtIvadg As System.Windows.Forms.TextBox
    Friend WithEvents TxtTipta As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TablaESPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TablaESPTableAdapter As Agil.PromocionDSTableAdapters.TablaESPTableAdapter
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LetraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FevenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NufacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndrecDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AbcapDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaCapitalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComFegaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvacomFegaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TablaESPTMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapitalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InteresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaInteresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaCapitalDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Bttclear As System.Windows.Forms.Button
    Friend WithEvents BttPaste As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtFEcCon As System.Windows.Forms.TextBox
    Friend WithEvents BtnDomi As System.Windows.Forms.Button
    Friend WithEvents TxtDomi As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TxtTasaIvaCap As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TxtTipar As System.Windows.Forms.TextBox
    Friend WithEvents LbTipoP As System.Windows.Forms.Label
    Friend WithEvents CmbAcumInte As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents CmbFega As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents CmbLiquidez As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TxtLiquidez As System.Windows.Forms.TextBox
    Friend WithEvents TxtOpcion As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TxtMensu As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents DTPContrato As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TxtFvenc As System.Windows.Forms.TextBox
    Friend WithEvents ComboHipotec As ComboBox
    Friend WithEvents CombopPrenda As ComboBox
End Class
