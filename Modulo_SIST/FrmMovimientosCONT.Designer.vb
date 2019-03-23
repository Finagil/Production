<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMovimientosCONT
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextAnexo = New System.Windows.Forms.TextBox()
        Me.TextLetra = New System.Windows.Forms.TextBox()
        Me.TextFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AnexoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetraDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiposDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FepagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipmonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdhisginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HisginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContaDS = New Agil.ContaDS()
        Me.DocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChequeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observa1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MindsDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FolioFiscalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EsEfectivoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdhistoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstrumentoMonetarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasivoFiraDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistoriaTableAdapter = New Agil.ContaDSTableAdapters.HistoriaTableAdapter()
        Me.HisginTableAdapter = New Agil.ContaDSTableAdapters.HisginTableAdapter()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasTableAdapter = New Agil.ContaDSTableAdapters.FacturasTableAdapter()
        Me.FacturaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetraDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FevenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FepagDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldOtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RenPrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntPrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BonificaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaCapitalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarPrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaPrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RenSeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntSeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarSeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaSeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaOpcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitalOtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteresOtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarOtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaOtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeguroVidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteFEGADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipmonDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiferDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UDI1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UDI2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteFacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoFacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndPagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnviadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloqueoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FechaCreacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaCFDIDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SerieCFDIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoFacturaCFDIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HisginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Anexo"
        '
        'TextAnexo
        '
        Me.TextAnexo.Location = New System.Drawing.Point(15, 26)
        Me.TextAnexo.MaxLength = 9
        Me.TextAnexo.Name = "TextAnexo"
        Me.TextAnexo.Size = New System.Drawing.Size(72, 20)
        Me.TextAnexo.TabIndex = 1
        '
        'TextLetra
        '
        Me.TextLetra.Location = New System.Drawing.Point(93, 26)
        Me.TextLetra.MaxLength = 3
        Me.TextLetra.Name = "TextLetra"
        Me.TextLetra.Size = New System.Drawing.Size(31, 20)
        Me.TextLetra.TabIndex = 2
        '
        'TextFecha
        '
        Me.TextFecha.Location = New System.Drawing.Point(130, 26)
        Me.TextFecha.MaxLength = 8
        Me.TextFecha.Name = "TextFecha"
        Me.TextFecha.Size = New System.Drawing.Size(100, 20)
        Me.TextFecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Letra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(236, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Historia"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocumentoDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.NumeroDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.AnexoDataGridViewTextBoxColumn, Me.LetraDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.BancoDataGridViewTextBoxColumn, Me.ChequeDataGridViewTextBoxColumn, Me.Observa1DataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.MindsDataGridViewCheckBoxColumn, Me.FolioFiscalDataGridViewTextBoxColumn, Me.EsEfectivoDataGridViewCheckBoxColumn, Me.IdhistoriaDataGridViewTextBoxColumn, Me.InstrumentoMonetarioDataGridViewTextBoxColumn, Me.PasivoFiraDataGridViewCheckBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HistoriaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(18, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1094, 181)
        Me.DataGridView1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contabilidad"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn1, Me.LetraDataGridViewTextBoxColumn1, Me.TiposDataGridViewTextBoxColumn, Me.FepagDataGridViewTextBoxColumn, Me.CveDataGridViewTextBoxColumn, Me.ImpDataGridViewTextBoxColumn, Me.TipDataGridViewTextBoxColumn, Me.CatalDataGridViewTextBoxColumn, Me.EspDataGridViewTextBoxColumn, Me.CoaDataGridViewTextBoxColumn, Me.TipmonDataGridViewTextBoxColumn, Me.BancoDataGridViewTextBoxColumn1, Me.ConceptoDataGridViewTextBoxColumn, Me.FacturaDataGridViewTextBoxColumn, Me.IdhisginDataGridViewTextBoxColumn, Me.GrupoDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.HisginBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(15, 269)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1094, 181)
        Me.DataGridView2.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1034, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FacturaDataGridViewTextBoxColumn1, Me.AnexoDataGridViewTextBoxColumn2, Me.LetraDataGridViewTextBoxColumn2, Me.ClienteDataGridViewTextBoxColumn, Me.FevenDataGridViewTextBoxColumn, Me.FepagDataGridViewTextBoxColumn1, Me.SaldoDataGridViewTextBoxColumn, Me.SalseDataGridViewTextBoxColumn, Me.SaldOtDataGridViewTextBoxColumn, Me.RenPrDataGridViewTextBoxColumn, Me.IntPrDataGridViewTextBoxColumn, Me.BonificaDataGridViewTextBoxColumn, Me.IvaCapitalDataGridViewTextBoxColumn, Me.VarPrDataGridViewTextBoxColumn, Me.IvaPrDataGridViewTextBoxColumn, Me.RenSeDataGridViewTextBoxColumn, Me.IntSeDataGridViewTextBoxColumn, Me.VarSeDataGridViewTextBoxColumn, Me.IvaSeDataGridViewTextBoxColumn, Me.OpcionDataGridViewTextBoxColumn, Me.IvaOpcionDataGridViewTextBoxColumn, Me.CapitalOtDataGridViewTextBoxColumn, Me.InteresOtDataGridViewTextBoxColumn, Me.VarOtDataGridViewTextBoxColumn, Me.IvaOtDataGridViewTextBoxColumn, Me.SeguroVidaDataGridViewTextBoxColumn, Me.ImporteFEGADataGridViewTextBoxColumn, Me.TipmonDataGridViewTextBoxColumn1, Me.DiasDataGridViewTextBoxColumn, Me.TasaDataGridViewTextBoxColumn, Me.DiferDataGridViewTextBoxColumn, Me.UDI1DataGridViewTextBoxColumn, Me.UDI2DataGridViewTextBoxColumn, Me.TasaIVADataGridViewTextBoxColumn, Me.ImporteFacDataGridViewTextBoxColumn, Me.SaldoFacDataGridViewTextBoxColumn, Me.IndPagDataGridViewTextBoxColumn, Me.EnviadoDataGridViewTextBoxColumn, Me.BloqueoDataGridViewCheckBoxColumn, Me.FechaCreacionDataGridViewTextBoxColumn, Me.FacturaCFDIDataGridViewCheckBoxColumn, Me.SerieCFDIDataGridViewTextBoxColumn, Me.NoFacturaCFDIDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.FacturasBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(12, 470)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(1094, 77)
        Me.DataGridView3.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 453)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Facturas"
        '
        'AnexoDataGridViewTextBoxColumn1
        '
        Me.AnexoDataGridViewTextBoxColumn1.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn1.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn1.Name = "AnexoDataGridViewTextBoxColumn1"
        '
        'LetraDataGridViewTextBoxColumn1
        '
        Me.LetraDataGridViewTextBoxColumn1.DataPropertyName = "Letra"
        Me.LetraDataGridViewTextBoxColumn1.HeaderText = "Letra"
        Me.LetraDataGridViewTextBoxColumn1.Name = "LetraDataGridViewTextBoxColumn1"
        '
        'TiposDataGridViewTextBoxColumn
        '
        Me.TiposDataGridViewTextBoxColumn.DataPropertyName = "Tipos"
        Me.TiposDataGridViewTextBoxColumn.HeaderText = "Tipos"
        Me.TiposDataGridViewTextBoxColumn.Name = "TiposDataGridViewTextBoxColumn"
        '
        'FepagDataGridViewTextBoxColumn
        '
        Me.FepagDataGridViewTextBoxColumn.DataPropertyName = "Fepag"
        Me.FepagDataGridViewTextBoxColumn.HeaderText = "Fepag"
        Me.FepagDataGridViewTextBoxColumn.Name = "FepagDataGridViewTextBoxColumn"
        '
        'CveDataGridViewTextBoxColumn
        '
        Me.CveDataGridViewTextBoxColumn.DataPropertyName = "Cve"
        Me.CveDataGridViewTextBoxColumn.HeaderText = "Cve"
        Me.CveDataGridViewTextBoxColumn.Name = "CveDataGridViewTextBoxColumn"
        '
        'ImpDataGridViewTextBoxColumn
        '
        Me.ImpDataGridViewTextBoxColumn.DataPropertyName = "Imp"
        Me.ImpDataGridViewTextBoxColumn.HeaderText = "Imp"
        Me.ImpDataGridViewTextBoxColumn.Name = "ImpDataGridViewTextBoxColumn"
        '
        'TipDataGridViewTextBoxColumn
        '
        Me.TipDataGridViewTextBoxColumn.DataPropertyName = "Tip"
        Me.TipDataGridViewTextBoxColumn.HeaderText = "Tip"
        Me.TipDataGridViewTextBoxColumn.Name = "TipDataGridViewTextBoxColumn"
        '
        'CatalDataGridViewTextBoxColumn
        '
        Me.CatalDataGridViewTextBoxColumn.DataPropertyName = "Catal"
        Me.CatalDataGridViewTextBoxColumn.HeaderText = "Catal"
        Me.CatalDataGridViewTextBoxColumn.Name = "CatalDataGridViewTextBoxColumn"
        '
        'EspDataGridViewTextBoxColumn
        '
        Me.EspDataGridViewTextBoxColumn.DataPropertyName = "Esp"
        Me.EspDataGridViewTextBoxColumn.HeaderText = "Esp"
        Me.EspDataGridViewTextBoxColumn.Name = "EspDataGridViewTextBoxColumn"
        '
        'CoaDataGridViewTextBoxColumn
        '
        Me.CoaDataGridViewTextBoxColumn.DataPropertyName = "Coa"
        Me.CoaDataGridViewTextBoxColumn.HeaderText = "Coa"
        Me.CoaDataGridViewTextBoxColumn.Name = "CoaDataGridViewTextBoxColumn"
        '
        'TipmonDataGridViewTextBoxColumn
        '
        Me.TipmonDataGridViewTextBoxColumn.DataPropertyName = "Tipmon"
        Me.TipmonDataGridViewTextBoxColumn.HeaderText = "Tipmon"
        Me.TipmonDataGridViewTextBoxColumn.Name = "TipmonDataGridViewTextBoxColumn"
        '
        'BancoDataGridViewTextBoxColumn1
        '
        Me.BancoDataGridViewTextBoxColumn1.DataPropertyName = "Banco"
        Me.BancoDataGridViewTextBoxColumn1.HeaderText = "Banco"
        Me.BancoDataGridViewTextBoxColumn1.Name = "BancoDataGridViewTextBoxColumn1"
        '
        'ConceptoDataGridViewTextBoxColumn
        '
        Me.ConceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.HeaderText = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.Name = "ConceptoDataGridViewTextBoxColumn"
        '
        'FacturaDataGridViewTextBoxColumn
        '
        Me.FacturaDataGridViewTextBoxColumn.DataPropertyName = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.HeaderText = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.Name = "FacturaDataGridViewTextBoxColumn"
        '
        'IdhisginDataGridViewTextBoxColumn
        '
        Me.IdhisginDataGridViewTextBoxColumn.DataPropertyName = "id_hisgin"
        Me.IdhisginDataGridViewTextBoxColumn.HeaderText = "id_hisgin"
        Me.IdhisginDataGridViewTextBoxColumn.Name = "IdhisginDataGridViewTextBoxColumn"
        Me.IdhisginDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GrupoDataGridViewTextBoxColumn
        '
        Me.GrupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn.HeaderText = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn.Name = "GrupoDataGridViewTextBoxColumn"
        '
        'HisginBindingSource
        '
        Me.HisginBindingSource.DataMember = "Hisgin"
        Me.HisginBindingSource.DataSource = Me.ContaDS
        '
        'ContaDS
        '
        Me.ContaDS.DataSetName = "ContaDS"
        Me.ContaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DocumentoDataGridViewTextBoxColumn
        '
        Me.DocumentoDataGridViewTextBoxColumn.DataPropertyName = "Documento"
        Me.DocumentoDataGridViewTextBoxColumn.HeaderText = "Documento"
        Me.DocumentoDataGridViewTextBoxColumn.Name = "DocumentoDataGridViewTextBoxColumn"
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "Serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        '
        'LetraDataGridViewTextBoxColumn
        '
        Me.LetraDataGridViewTextBoxColumn.DataPropertyName = "Letra"
        Me.LetraDataGridViewTextBoxColumn.HeaderText = "Letra"
        Me.LetraDataGridViewTextBoxColumn.Name = "LetraDataGridViewTextBoxColumn"
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        '
        'BancoDataGridViewTextBoxColumn
        '
        Me.BancoDataGridViewTextBoxColumn.DataPropertyName = "Banco"
        Me.BancoDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.BancoDataGridViewTextBoxColumn.Name = "BancoDataGridViewTextBoxColumn"
        '
        'ChequeDataGridViewTextBoxColumn
        '
        Me.ChequeDataGridViewTextBoxColumn.DataPropertyName = "Cheque"
        Me.ChequeDataGridViewTextBoxColumn.HeaderText = "Cheque"
        Me.ChequeDataGridViewTextBoxColumn.Name = "ChequeDataGridViewTextBoxColumn"
        '
        'Observa1DataGridViewTextBoxColumn
        '
        Me.Observa1DataGridViewTextBoxColumn.DataPropertyName = "Observa1"
        Me.Observa1DataGridViewTextBoxColumn.HeaderText = "Observa1"
        Me.Observa1DataGridViewTextBoxColumn.Name = "Observa1DataGridViewTextBoxColumn"
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        '
        'MindsDataGridViewCheckBoxColumn
        '
        Me.MindsDataGridViewCheckBoxColumn.DataPropertyName = "Minds"
        Me.MindsDataGridViewCheckBoxColumn.HeaderText = "Minds"
        Me.MindsDataGridViewCheckBoxColumn.Name = "MindsDataGridViewCheckBoxColumn"
        '
        'FolioFiscalDataGridViewTextBoxColumn
        '
        Me.FolioFiscalDataGridViewTextBoxColumn.DataPropertyName = "FolioFiscal"
        Me.FolioFiscalDataGridViewTextBoxColumn.HeaderText = "FolioFiscal"
        Me.FolioFiscalDataGridViewTextBoxColumn.Name = "FolioFiscalDataGridViewTextBoxColumn"
        '
        'EsEfectivoDataGridViewCheckBoxColumn
        '
        Me.EsEfectivoDataGridViewCheckBoxColumn.DataPropertyName = "EsEfectivo"
        Me.EsEfectivoDataGridViewCheckBoxColumn.HeaderText = "EsEfectivo"
        Me.EsEfectivoDataGridViewCheckBoxColumn.Name = "EsEfectivoDataGridViewCheckBoxColumn"
        '
        'IdhistoriaDataGridViewTextBoxColumn
        '
        Me.IdhistoriaDataGridViewTextBoxColumn.DataPropertyName = "id_historia"
        Me.IdhistoriaDataGridViewTextBoxColumn.HeaderText = "id_historia"
        Me.IdhistoriaDataGridViewTextBoxColumn.Name = "IdhistoriaDataGridViewTextBoxColumn"
        Me.IdhistoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InstrumentoMonetarioDataGridViewTextBoxColumn
        '
        Me.InstrumentoMonetarioDataGridViewTextBoxColumn.DataPropertyName = "InstrumentoMonetario"
        Me.InstrumentoMonetarioDataGridViewTextBoxColumn.HeaderText = "InstrumentoMonetario"
        Me.InstrumentoMonetarioDataGridViewTextBoxColumn.Name = "InstrumentoMonetarioDataGridViewTextBoxColumn"
        '
        'PasivoFiraDataGridViewCheckBoxColumn
        '
        Me.PasivoFiraDataGridViewCheckBoxColumn.DataPropertyName = "PasivoFira"
        Me.PasivoFiraDataGridViewCheckBoxColumn.HeaderText = "PasivoFira"
        Me.PasivoFiraDataGridViewCheckBoxColumn.Name = "PasivoFiraDataGridViewCheckBoxColumn"
        '
        'FechaPagoDataGridViewTextBoxColumn
        '
        Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago"
        Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago"
        Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
        '
        'HistoriaBindingSource
        '
        Me.HistoriaBindingSource.DataMember = "Historia"
        Me.HistoriaBindingSource.DataSource = Me.ContaDS
        '
        'HistoriaTableAdapter
        '
        Me.HistoriaTableAdapter.ClearBeforeFill = True
        '
        'HisginTableAdapter
        '
        Me.HisginTableAdapter.ClearBeforeFill = True
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.ContaDS
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'FacturaDataGridViewTextBoxColumn1
        '
        Me.FacturaDataGridViewTextBoxColumn1.DataPropertyName = "Factura"
        Me.FacturaDataGridViewTextBoxColumn1.HeaderText = "Factura"
        Me.FacturaDataGridViewTextBoxColumn1.Name = "FacturaDataGridViewTextBoxColumn1"
        '
        'AnexoDataGridViewTextBoxColumn2
        '
        Me.AnexoDataGridViewTextBoxColumn2.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn2.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn2.Name = "AnexoDataGridViewTextBoxColumn2"
        '
        'LetraDataGridViewTextBoxColumn2
        '
        Me.LetraDataGridViewTextBoxColumn2.DataPropertyName = "Letra"
        Me.LetraDataGridViewTextBoxColumn2.HeaderText = "Letra"
        Me.LetraDataGridViewTextBoxColumn2.Name = "LetraDataGridViewTextBoxColumn2"
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        '
        'FevenDataGridViewTextBoxColumn
        '
        Me.FevenDataGridViewTextBoxColumn.DataPropertyName = "Feven"
        Me.FevenDataGridViewTextBoxColumn.HeaderText = "Feven"
        Me.FevenDataGridViewTextBoxColumn.Name = "FevenDataGridViewTextBoxColumn"
        '
        'FepagDataGridViewTextBoxColumn1
        '
        Me.FepagDataGridViewTextBoxColumn1.DataPropertyName = "Fepag"
        Me.FepagDataGridViewTextBoxColumn1.HeaderText = "Fepag"
        Me.FepagDataGridViewTextBoxColumn1.Name = "FepagDataGridViewTextBoxColumn1"
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        '
        'SalseDataGridViewTextBoxColumn
        '
        Me.SalseDataGridViewTextBoxColumn.DataPropertyName = "Salse"
        Me.SalseDataGridViewTextBoxColumn.HeaderText = "Salse"
        Me.SalseDataGridViewTextBoxColumn.Name = "SalseDataGridViewTextBoxColumn"
        '
        'SaldOtDataGridViewTextBoxColumn
        '
        Me.SaldOtDataGridViewTextBoxColumn.DataPropertyName = "SaldOt"
        Me.SaldOtDataGridViewTextBoxColumn.HeaderText = "SaldOt"
        Me.SaldOtDataGridViewTextBoxColumn.Name = "SaldOtDataGridViewTextBoxColumn"
        '
        'RenPrDataGridViewTextBoxColumn
        '
        Me.RenPrDataGridViewTextBoxColumn.DataPropertyName = "RenPr"
        Me.RenPrDataGridViewTextBoxColumn.HeaderText = "RenPr"
        Me.RenPrDataGridViewTextBoxColumn.Name = "RenPrDataGridViewTextBoxColumn"
        '
        'IntPrDataGridViewTextBoxColumn
        '
        Me.IntPrDataGridViewTextBoxColumn.DataPropertyName = "IntPr"
        Me.IntPrDataGridViewTextBoxColumn.HeaderText = "IntPr"
        Me.IntPrDataGridViewTextBoxColumn.Name = "IntPrDataGridViewTextBoxColumn"
        '
        'BonificaDataGridViewTextBoxColumn
        '
        Me.BonificaDataGridViewTextBoxColumn.DataPropertyName = "Bonifica"
        Me.BonificaDataGridViewTextBoxColumn.HeaderText = "Bonifica"
        Me.BonificaDataGridViewTextBoxColumn.Name = "BonificaDataGridViewTextBoxColumn"
        '
        'IvaCapitalDataGridViewTextBoxColumn
        '
        Me.IvaCapitalDataGridViewTextBoxColumn.DataPropertyName = "IvaCapital"
        Me.IvaCapitalDataGridViewTextBoxColumn.HeaderText = "IvaCapital"
        Me.IvaCapitalDataGridViewTextBoxColumn.Name = "IvaCapitalDataGridViewTextBoxColumn"
        '
        'VarPrDataGridViewTextBoxColumn
        '
        Me.VarPrDataGridViewTextBoxColumn.DataPropertyName = "VarPr"
        Me.VarPrDataGridViewTextBoxColumn.HeaderText = "VarPr"
        Me.VarPrDataGridViewTextBoxColumn.Name = "VarPrDataGridViewTextBoxColumn"
        '
        'IvaPrDataGridViewTextBoxColumn
        '
        Me.IvaPrDataGridViewTextBoxColumn.DataPropertyName = "IvaPr"
        Me.IvaPrDataGridViewTextBoxColumn.HeaderText = "IvaPr"
        Me.IvaPrDataGridViewTextBoxColumn.Name = "IvaPrDataGridViewTextBoxColumn"
        '
        'RenSeDataGridViewTextBoxColumn
        '
        Me.RenSeDataGridViewTextBoxColumn.DataPropertyName = "RenSe"
        Me.RenSeDataGridViewTextBoxColumn.HeaderText = "RenSe"
        Me.RenSeDataGridViewTextBoxColumn.Name = "RenSeDataGridViewTextBoxColumn"
        '
        'IntSeDataGridViewTextBoxColumn
        '
        Me.IntSeDataGridViewTextBoxColumn.DataPropertyName = "IntSe"
        Me.IntSeDataGridViewTextBoxColumn.HeaderText = "IntSe"
        Me.IntSeDataGridViewTextBoxColumn.Name = "IntSeDataGridViewTextBoxColumn"
        '
        'VarSeDataGridViewTextBoxColumn
        '
        Me.VarSeDataGridViewTextBoxColumn.DataPropertyName = "VarSe"
        Me.VarSeDataGridViewTextBoxColumn.HeaderText = "VarSe"
        Me.VarSeDataGridViewTextBoxColumn.Name = "VarSeDataGridViewTextBoxColumn"
        '
        'IvaSeDataGridViewTextBoxColumn
        '
        Me.IvaSeDataGridViewTextBoxColumn.DataPropertyName = "IvaSe"
        Me.IvaSeDataGridViewTextBoxColumn.HeaderText = "IvaSe"
        Me.IvaSeDataGridViewTextBoxColumn.Name = "IvaSeDataGridViewTextBoxColumn"
        '
        'OpcionDataGridViewTextBoxColumn
        '
        Me.OpcionDataGridViewTextBoxColumn.DataPropertyName = "Opcion"
        Me.OpcionDataGridViewTextBoxColumn.HeaderText = "Opcion"
        Me.OpcionDataGridViewTextBoxColumn.Name = "OpcionDataGridViewTextBoxColumn"
        '
        'IvaOpcionDataGridViewTextBoxColumn
        '
        Me.IvaOpcionDataGridViewTextBoxColumn.DataPropertyName = "IvaOpcion"
        Me.IvaOpcionDataGridViewTextBoxColumn.HeaderText = "IvaOpcion"
        Me.IvaOpcionDataGridViewTextBoxColumn.Name = "IvaOpcionDataGridViewTextBoxColumn"
        '
        'CapitalOtDataGridViewTextBoxColumn
        '
        Me.CapitalOtDataGridViewTextBoxColumn.DataPropertyName = "CapitalOt"
        Me.CapitalOtDataGridViewTextBoxColumn.HeaderText = "CapitalOt"
        Me.CapitalOtDataGridViewTextBoxColumn.Name = "CapitalOtDataGridViewTextBoxColumn"
        '
        'InteresOtDataGridViewTextBoxColumn
        '
        Me.InteresOtDataGridViewTextBoxColumn.DataPropertyName = "InteresOt"
        Me.InteresOtDataGridViewTextBoxColumn.HeaderText = "InteresOt"
        Me.InteresOtDataGridViewTextBoxColumn.Name = "InteresOtDataGridViewTextBoxColumn"
        '
        'VarOtDataGridViewTextBoxColumn
        '
        Me.VarOtDataGridViewTextBoxColumn.DataPropertyName = "VarOt"
        Me.VarOtDataGridViewTextBoxColumn.HeaderText = "VarOt"
        Me.VarOtDataGridViewTextBoxColumn.Name = "VarOtDataGridViewTextBoxColumn"
        '
        'IvaOtDataGridViewTextBoxColumn
        '
        Me.IvaOtDataGridViewTextBoxColumn.DataPropertyName = "IvaOt"
        Me.IvaOtDataGridViewTextBoxColumn.HeaderText = "IvaOt"
        Me.IvaOtDataGridViewTextBoxColumn.Name = "IvaOtDataGridViewTextBoxColumn"
        '
        'SeguroVidaDataGridViewTextBoxColumn
        '
        Me.SeguroVidaDataGridViewTextBoxColumn.DataPropertyName = "SeguroVida"
        Me.SeguroVidaDataGridViewTextBoxColumn.HeaderText = "SeguroVida"
        Me.SeguroVidaDataGridViewTextBoxColumn.Name = "SeguroVidaDataGridViewTextBoxColumn"
        '
        'ImporteFEGADataGridViewTextBoxColumn
        '
        Me.ImporteFEGADataGridViewTextBoxColumn.DataPropertyName = "ImporteFEGA"
        Me.ImporteFEGADataGridViewTextBoxColumn.HeaderText = "ImporteFEGA"
        Me.ImporteFEGADataGridViewTextBoxColumn.Name = "ImporteFEGADataGridViewTextBoxColumn"
        '
        'TipmonDataGridViewTextBoxColumn1
        '
        Me.TipmonDataGridViewTextBoxColumn1.DataPropertyName = "Tipmon"
        Me.TipmonDataGridViewTextBoxColumn1.HeaderText = "Tipmon"
        Me.TipmonDataGridViewTextBoxColumn1.Name = "TipmonDataGridViewTextBoxColumn1"
        '
        'DiasDataGridViewTextBoxColumn
        '
        Me.DiasDataGridViewTextBoxColumn.DataPropertyName = "Dias"
        Me.DiasDataGridViewTextBoxColumn.HeaderText = "Dias"
        Me.DiasDataGridViewTextBoxColumn.Name = "DiasDataGridViewTextBoxColumn"
        '
        'TasaDataGridViewTextBoxColumn
        '
        Me.TasaDataGridViewTextBoxColumn.DataPropertyName = "Tasa"
        Me.TasaDataGridViewTextBoxColumn.HeaderText = "Tasa"
        Me.TasaDataGridViewTextBoxColumn.Name = "TasaDataGridViewTextBoxColumn"
        '
        'DiferDataGridViewTextBoxColumn
        '
        Me.DiferDataGridViewTextBoxColumn.DataPropertyName = "Difer"
        Me.DiferDataGridViewTextBoxColumn.HeaderText = "Difer"
        Me.DiferDataGridViewTextBoxColumn.Name = "DiferDataGridViewTextBoxColumn"
        '
        'UDI1DataGridViewTextBoxColumn
        '
        Me.UDI1DataGridViewTextBoxColumn.DataPropertyName = "UDI1"
        Me.UDI1DataGridViewTextBoxColumn.HeaderText = "UDI1"
        Me.UDI1DataGridViewTextBoxColumn.Name = "UDI1DataGridViewTextBoxColumn"
        '
        'UDI2DataGridViewTextBoxColumn
        '
        Me.UDI2DataGridViewTextBoxColumn.DataPropertyName = "UDI2"
        Me.UDI2DataGridViewTextBoxColumn.HeaderText = "UDI2"
        Me.UDI2DataGridViewTextBoxColumn.Name = "UDI2DataGridViewTextBoxColumn"
        '
        'TasaIVADataGridViewTextBoxColumn
        '
        Me.TasaIVADataGridViewTextBoxColumn.DataPropertyName = "TasaIVA"
        Me.TasaIVADataGridViewTextBoxColumn.HeaderText = "TasaIVA"
        Me.TasaIVADataGridViewTextBoxColumn.Name = "TasaIVADataGridViewTextBoxColumn"
        '
        'ImporteFacDataGridViewTextBoxColumn
        '
        Me.ImporteFacDataGridViewTextBoxColumn.DataPropertyName = "ImporteFac"
        Me.ImporteFacDataGridViewTextBoxColumn.HeaderText = "ImporteFac"
        Me.ImporteFacDataGridViewTextBoxColumn.Name = "ImporteFacDataGridViewTextBoxColumn"
        '
        'SaldoFacDataGridViewTextBoxColumn
        '
        Me.SaldoFacDataGridViewTextBoxColumn.DataPropertyName = "SaldoFac"
        Me.SaldoFacDataGridViewTextBoxColumn.HeaderText = "SaldoFac"
        Me.SaldoFacDataGridViewTextBoxColumn.Name = "SaldoFacDataGridViewTextBoxColumn"
        '
        'IndPagDataGridViewTextBoxColumn
        '
        Me.IndPagDataGridViewTextBoxColumn.DataPropertyName = "IndPag"
        Me.IndPagDataGridViewTextBoxColumn.HeaderText = "IndPag"
        Me.IndPagDataGridViewTextBoxColumn.Name = "IndPagDataGridViewTextBoxColumn"
        '
        'EnviadoDataGridViewTextBoxColumn
        '
        Me.EnviadoDataGridViewTextBoxColumn.DataPropertyName = "Enviado"
        Me.EnviadoDataGridViewTextBoxColumn.HeaderText = "Enviado"
        Me.EnviadoDataGridViewTextBoxColumn.Name = "EnviadoDataGridViewTextBoxColumn"
        '
        'BloqueoDataGridViewCheckBoxColumn
        '
        Me.BloqueoDataGridViewCheckBoxColumn.DataPropertyName = "Bloqueo"
        Me.BloqueoDataGridViewCheckBoxColumn.HeaderText = "Bloqueo"
        Me.BloqueoDataGridViewCheckBoxColumn.Name = "BloqueoDataGridViewCheckBoxColumn"
        '
        'FechaCreacionDataGridViewTextBoxColumn
        '
        Me.FechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion"
        Me.FechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion"
        Me.FechaCreacionDataGridViewTextBoxColumn.Name = "FechaCreacionDataGridViewTextBoxColumn"
        '
        'FacturaCFDIDataGridViewCheckBoxColumn
        '
        Me.FacturaCFDIDataGridViewCheckBoxColumn.DataPropertyName = "FacturaCFDI"
        Me.FacturaCFDIDataGridViewCheckBoxColumn.HeaderText = "FacturaCFDI"
        Me.FacturaCFDIDataGridViewCheckBoxColumn.Name = "FacturaCFDIDataGridViewCheckBoxColumn"
        '
        'SerieCFDIDataGridViewTextBoxColumn
        '
        Me.SerieCFDIDataGridViewTextBoxColumn.DataPropertyName = "SerieCFDI"
        Me.SerieCFDIDataGridViewTextBoxColumn.HeaderText = "SerieCFDI"
        Me.SerieCFDIDataGridViewTextBoxColumn.Name = "SerieCFDIDataGridViewTextBoxColumn"
        '
        'NoFacturaCFDIDataGridViewTextBoxColumn
        '
        Me.NoFacturaCFDIDataGridViewTextBoxColumn.DataPropertyName = "NoFacturaCFDI"
        Me.NoFacturaCFDIDataGridViewTextBoxColumn.HeaderText = "NoFacturaCFDI"
        Me.NoFacturaCFDIDataGridViewTextBoxColumn.Name = "NoFacturaCFDIDataGridViewTextBoxColumn"
        '
        'FrmMovimientosCONT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 555)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextFecha)
        Me.Controls.Add(Me.TextLetra)
        Me.Controls.Add(Me.TextAnexo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMovimientosCONT"
        Me.Text = "Registro Contable"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HisginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextAnexo As TextBox
    Friend WithEvents TextLetra As TextBox
    Friend WithEvents TextFecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LetraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BancoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChequeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Observa1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MindsDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FolioFiscalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EsEfectivoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdhistoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstrumentoMonetarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasivoFiraDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FechaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HistoriaBindingSource As BindingSource
    Friend WithEvents ContaDS As ContaDS
    Friend WithEvents Button2 As Button
    Friend WithEvents HistoriaTableAdapter As ContaDSTableAdapters.HistoriaTableAdapter
    Friend WithEvents AnexoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LetraDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TiposDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FepagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CatalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipmonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BancoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdhisginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrupoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HisginBindingSource As BindingSource
    Friend WithEvents HisginTableAdapter As ContaDSTableAdapters.HisginTableAdapter
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents FacturaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents LetraDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FevenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FepagDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldOtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RenPrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IntPrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BonificaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IvaCapitalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarPrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IvaPrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RenSeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IntSeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarSeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IvaSeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IvaOpcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapitalOtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InteresOtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarOtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IvaOtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeguroVidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteFEGADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipmonDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TasaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiferDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UDI1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UDI2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TasaIVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteFacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoFacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndPagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnviadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BloqueoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FechaCreacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturaCFDIDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SerieCFDIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoFacturaCFDIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents FacturasTableAdapter As ContaDSTableAdapters.FacturasTableAdapter
End Class
