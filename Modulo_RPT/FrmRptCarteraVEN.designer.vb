<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptCarteraVEN
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
        Me.BtnProc = New System.Windows.Forms.Button()
        Me.CmbDB = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CarteraVencidaRPTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportesDS = New Agil.ReportesDS()
        Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboSucursal = New System.Windows.Forms.ComboBox()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SucursalesTableAdapter = New Agil.ReportesDSTableAdapters.SucursalesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaActivacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaTerminacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasRetrasoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoInsolutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoSeguroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoOtrosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvInte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentaCapitalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentaOtrosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentaInteresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Castigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Garantia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Opcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalVencidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoFinanciado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cultivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Giro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadInegi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadEconomica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reestructura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParteRelacionada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prendaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hipotecaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GarantiaLiquida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GarantiaFega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoLetras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetrasFacturadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarteraVencidaRPTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnProc
        '
        Me.BtnProc.Location = New System.Drawing.Point(320, 7)
        Me.BtnProc.Name = "BtnProc"
        Me.BtnProc.Size = New System.Drawing.Size(75, 23)
        Me.BtnProc.TabIndex = 2
        Me.BtnProc.Text = "Procesar"
        Me.BtnProc.UseVisualStyleBackColor = True
        '
        'CmbDB
        '
        Me.CmbDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDB.FormattingEnabled = True
        Me.CmbDB.Location = New System.Drawing.Point(14, 9)
        Me.CmbDB.Name = "CmbDB"
        Me.CmbDB.Size = New System.Drawing.Size(121, 21)
        Me.CmbDB.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.FechaActivacionDataGridViewTextBoxColumn, Me.FechaTerminacionDataGridViewTextBoxColumn, Me.DiasRetrasoDataGridViewTextBoxColumn, Me.SaldoInsolutoDataGridViewTextBoxColumn, Me.SaldoSeguroDataGridViewTextBoxColumn, Me.SaldoOtrosDataGridViewTextBoxColumn, Me.ProvInte, Me.RentaCapitalDataGridViewTextBoxColumn, Me.RentaOtrosDataGridViewTextBoxColumn, Me.RentaInteresDataGridViewTextBoxColumn, Me.Castigo, Me.Garantia, Me.Opcion, Me.TotalVencidoDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn, Me.Moneda, Me.EstatusDataGridViewTextBoxColumn, Me.Sucursal, Me.MontoFinanciado, Me.Cultivo, Me.Giro, Me.ActividadInegi, Me.ActividadEconomica, Me.Reestructura, Me.ParteRelacionada, Me.Prendaria, Me.Hipotecaria, Me.GarantiaLiquida, Me.GarantiaFega, Me.TipoPersona, Me.NoLetras, Me.LetrasFacturadas})
        Me.DataGridView1.DataSource = Me.CarteraVencidaRPTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 635)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1123, 57)
        Me.DataGridView1.TabIndex = 5
        '
        'CarteraVencidaRPTBindingSource
        '
        Me.CarteraVencidaRPTBindingSource.DataMember = "CarteraVencidaRPT"
        Me.CarteraVencidaRPTBindingSource.DataSource = Me.ReportesDS
        '
        'ReportesDS
        '
        Me.ReportesDS.DataSetName = "ReportesDS"
        Me.ReportesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CRViewer
        '
        Me.CRViewer.ActiveViewIndex = -1
        Me.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewer.Location = New System.Drawing.Point(12, 36)
        Me.CRViewer.Name = "CRViewer"
        Me.CRViewer.SelectionFormula = ""
        Me.CRViewer.Size = New System.Drawing.Size(1123, 593)
        Me.CRViewer.TabIndex = 6
        Me.CRViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CRViewer.ViewTimeSelectionFormula = ""
        '
        'DTPFecha
        '
        Me.DTPFecha.Enabled = False
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(401, 9)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(98, 20)
        Me.DTPFecha.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Sucursal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboSucursal
        '
        Me.ComboSucursal.DataSource = Me.SucursalesBindingSource
        Me.ComboSucursal.DisplayMember = "Nombre_Sucursal"
        Me.ComboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSucursal.FormattingEnabled = True
        Me.ComboSucursal.Location = New System.Drawing.Point(193, 8)
        Me.ComboSucursal.Name = "ComboSucursal"
        Me.ComboSucursal.Size = New System.Drawing.Size(121, 21)
        Me.ComboSucursal.TabIndex = 4
        Me.ComboSucursal.ValueMember = "ID_Sucursal"
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.ReportesDS
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1095, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "."
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaActivacionDataGridViewTextBoxColumn
        '
        Me.FechaActivacionDataGridViewTextBoxColumn.DataPropertyName = "FechaActivacion"
        Me.FechaActivacionDataGridViewTextBoxColumn.HeaderText = "FechaActivacion"
        Me.FechaActivacionDataGridViewTextBoxColumn.Name = "FechaActivacionDataGridViewTextBoxColumn"
        Me.FechaActivacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaTerminacionDataGridViewTextBoxColumn
        '
        Me.FechaTerminacionDataGridViewTextBoxColumn.DataPropertyName = "FechaTerminacion"
        Me.FechaTerminacionDataGridViewTextBoxColumn.HeaderText = "FechaTerminacion"
        Me.FechaTerminacionDataGridViewTextBoxColumn.Name = "FechaTerminacionDataGridViewTextBoxColumn"
        Me.FechaTerminacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiasRetrasoDataGridViewTextBoxColumn
        '
        Me.DiasRetrasoDataGridViewTextBoxColumn.DataPropertyName = "DiasRetraso"
        Me.DiasRetrasoDataGridViewTextBoxColumn.HeaderText = "DiasRetraso"
        Me.DiasRetrasoDataGridViewTextBoxColumn.Name = "DiasRetrasoDataGridViewTextBoxColumn"
        Me.DiasRetrasoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoInsolutoDataGridViewTextBoxColumn
        '
        Me.SaldoInsolutoDataGridViewTextBoxColumn.DataPropertyName = "SaldoInsoluto"
        Me.SaldoInsolutoDataGridViewTextBoxColumn.HeaderText = "SaldoInsoluto"
        Me.SaldoInsolutoDataGridViewTextBoxColumn.Name = "SaldoInsolutoDataGridViewTextBoxColumn"
        Me.SaldoInsolutoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoSeguroDataGridViewTextBoxColumn
        '
        Me.SaldoSeguroDataGridViewTextBoxColumn.DataPropertyName = "SaldoSeguro"
        Me.SaldoSeguroDataGridViewTextBoxColumn.HeaderText = "SaldoSeguro"
        Me.SaldoSeguroDataGridViewTextBoxColumn.Name = "SaldoSeguroDataGridViewTextBoxColumn"
        Me.SaldoSeguroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoOtrosDataGridViewTextBoxColumn
        '
        Me.SaldoOtrosDataGridViewTextBoxColumn.DataPropertyName = "SaldoOtros"
        Me.SaldoOtrosDataGridViewTextBoxColumn.HeaderText = "SaldoOtros"
        Me.SaldoOtrosDataGridViewTextBoxColumn.Name = "SaldoOtrosDataGridViewTextBoxColumn"
        Me.SaldoOtrosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProvInte
        '
        Me.ProvInte.DataPropertyName = "ProvInte"
        Me.ProvInte.HeaderText = "ProvInte"
        Me.ProvInte.Name = "ProvInte"
        Me.ProvInte.ReadOnly = True
        '
        'RentaCapitalDataGridViewTextBoxColumn
        '
        Me.RentaCapitalDataGridViewTextBoxColumn.DataPropertyName = "RentaCapital"
        Me.RentaCapitalDataGridViewTextBoxColumn.HeaderText = "RentaCapital"
        Me.RentaCapitalDataGridViewTextBoxColumn.Name = "RentaCapitalDataGridViewTextBoxColumn"
        Me.RentaCapitalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RentaOtrosDataGridViewTextBoxColumn
        '
        Me.RentaOtrosDataGridViewTextBoxColumn.DataPropertyName = "RentaOtros"
        Me.RentaOtrosDataGridViewTextBoxColumn.HeaderText = "RentaOtros"
        Me.RentaOtrosDataGridViewTextBoxColumn.Name = "RentaOtrosDataGridViewTextBoxColumn"
        Me.RentaOtrosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RentaInteresDataGridViewTextBoxColumn
        '
        Me.RentaInteresDataGridViewTextBoxColumn.DataPropertyName = "RentaInteres"
        Me.RentaInteresDataGridViewTextBoxColumn.HeaderText = "RentaInteres"
        Me.RentaInteresDataGridViewTextBoxColumn.Name = "RentaInteresDataGridViewTextBoxColumn"
        Me.RentaInteresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Castigo
        '
        Me.Castigo.DataPropertyName = "Castigo"
        Me.Castigo.HeaderText = "Castigo"
        Me.Castigo.Name = "Castigo"
        Me.Castigo.ReadOnly = True
        '
        'Garantia
        '
        Me.Garantia.DataPropertyName = "Garantia"
        Me.Garantia.HeaderText = "Garantia"
        Me.Garantia.Name = "Garantia"
        Me.Garantia.ReadOnly = True
        '
        'Opcion
        '
        Me.Opcion.DataPropertyName = "Opcion"
        Me.Opcion.HeaderText = "Opcion"
        Me.Opcion.Name = "Opcion"
        Me.Opcion.ReadOnly = True
        '
        'TotalVencidoDataGridViewTextBoxColumn
        '
        Me.TotalVencidoDataGridViewTextBoxColumn.DataPropertyName = "TotalVencido"
        Me.TotalVencidoDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalVencidoDataGridViewTextBoxColumn.Name = "TotalVencidoDataGridViewTextBoxColumn"
        Me.TotalVencidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoCreditoDataGridViewTextBoxColumn
        '
        Me.TipoCreditoDataGridViewTextBoxColumn.DataPropertyName = "Tipo Credito"
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "Tipo Credito"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Moneda
        '
        Me.Moneda.DataPropertyName = "Moneda"
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.Name = "Moneda"
        Me.Moneda.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Sucursal
        '
        Me.Sucursal.DataPropertyName = "Sucursal"
        Me.Sucursal.HeaderText = "Sucursal"
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.ReadOnly = True
        '
        'MontoFinanciado
        '
        Me.MontoFinanciado.DataPropertyName = "MontoFinanciado"
        Me.MontoFinanciado.HeaderText = "MontoFinanciado"
        Me.MontoFinanciado.Name = "MontoFinanciado"
        Me.MontoFinanciado.ReadOnly = True
        '
        'Cultivo
        '
        Me.Cultivo.DataPropertyName = "Cultivo"
        Me.Cultivo.HeaderText = "Cultivo"
        Me.Cultivo.Name = "Cultivo"
        Me.Cultivo.ReadOnly = True
        '
        'Giro
        '
        Me.Giro.DataPropertyName = "Giro"
        Me.Giro.HeaderText = "Giro"
        Me.Giro.Name = "Giro"
        Me.Giro.ReadOnly = True
        '
        'ActividadInegi
        '
        Me.ActividadInegi.DataPropertyName = "ActividadInegi"
        Me.ActividadInegi.HeaderText = "ActividadInegi"
        Me.ActividadInegi.Name = "ActividadInegi"
        Me.ActividadInegi.ReadOnly = True
        '
        'ActividadEconomica
        '
        Me.ActividadEconomica.DataPropertyName = "ActividadEconomica"
        Me.ActividadEconomica.HeaderText = "ActividadEconomica"
        Me.ActividadEconomica.Name = "ActividadEconomica"
        Me.ActividadEconomica.ReadOnly = True
        '
        'Reestructura
        '
        Me.Reestructura.DataPropertyName = "Reestructura"
        Me.Reestructura.HeaderText = "Reestructura"
        Me.Reestructura.Name = "Reestructura"
        Me.Reestructura.ReadOnly = True
        '
        'ParteRelacionada
        '
        Me.ParteRelacionada.DataPropertyName = "ParteRelacionada"
        Me.ParteRelacionada.HeaderText = "ParteRelacionada"
        Me.ParteRelacionada.Name = "ParteRelacionada"
        Me.ParteRelacionada.ReadOnly = True
        '
        'Prendaria
        '
        Me.Prendaria.DataPropertyName = "Prendaria"
        Me.Prendaria.HeaderText = "Prendaria"
        Me.Prendaria.Name = "Prendaria"
        Me.Prendaria.ReadOnly = True
        '
        'Hipotecaria
        '
        Me.Hipotecaria.DataPropertyName = "Hipotecaria"
        Me.Hipotecaria.HeaderText = "Hipotecaria"
        Me.Hipotecaria.Name = "Hipotecaria"
        Me.Hipotecaria.ReadOnly = True
        '
        'GarantiaLiquida
        '
        Me.GarantiaLiquida.DataPropertyName = "GarantiaLiquida"
        Me.GarantiaLiquida.HeaderText = "GarantiaLiquida"
        Me.GarantiaLiquida.Name = "GarantiaLiquida"
        Me.GarantiaLiquida.ReadOnly = True
        '
        'GarantiaFega
        '
        Me.GarantiaFega.DataPropertyName = "GarantiaFega"
        Me.GarantiaFega.HeaderText = "GarantiaFega"
        Me.GarantiaFega.Name = "GarantiaFega"
        Me.GarantiaFega.ReadOnly = True
        '
        'TipoPersona
        '
        Me.TipoPersona.DataPropertyName = "TipoPersona"
        Me.TipoPersona.HeaderText = "TipoPersona"
        Me.TipoPersona.Name = "TipoPersona"
        Me.TipoPersona.ReadOnly = True
        '
        'NoLetras
        '
        Me.NoLetras.DataPropertyName = "NoLetras"
        Me.NoLetras.HeaderText = "NoLetras"
        Me.NoLetras.Name = "NoLetras"
        Me.NoLetras.ReadOnly = True
        '
        'LetrasFacturadas
        '
        Me.LetrasFacturadas.DataPropertyName = "LetrasFacturadas"
        Me.LetrasFacturadas.HeaderText = "LetrasFacturadas"
        Me.LetrasFacturadas.Name = "LetrasFacturadas"
        Me.LetrasFacturadas.ReadOnly = True
        '
        'FrmRptCarteraVEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 704)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboSucursal)
        Me.Controls.Add(Me.DTPFecha)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CRViewer)
        Me.Controls.Add(Me.CmbDB)
        Me.Controls.Add(Me.BtnProc)
        Me.Name = "FrmRptCarteraVEN"
        Me.Text = "Reporte de Cartera"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarteraVencidaRPTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnProc As System.Windows.Forms.Button
    Friend WithEvents CmbDB As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ReportesDS As Agil.ReportesDS
    Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CarteraVencidaRPTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboSucursal As ComboBox
    Friend WithEvents SucursalesBindingSource As BindingSource
    Friend WithEvents SucursalesTableAdapter As ReportesDSTableAdapters.SucursalesTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaActivacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaTerminacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiasRetrasoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoInsolutoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoSeguroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoOtrosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvInte As DataGridViewTextBoxColumn
    Friend WithEvents RentaCapitalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentaOtrosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentaInteresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Castigo As DataGridViewTextBoxColumn
    Friend WithEvents Garantia As DataGridViewTextBoxColumn
    Friend WithEvents Opcion As DataGridViewTextBoxColumn
    Friend WithEvents TotalVencidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Sucursal As DataGridViewTextBoxColumn
    Friend WithEvents MontoFinanciado As DataGridViewTextBoxColumn
    Friend WithEvents Cultivo As DataGridViewTextBoxColumn
    Friend WithEvents Giro As DataGridViewTextBoxColumn
    Friend WithEvents ActividadInegi As DataGridViewTextBoxColumn
    Friend WithEvents ActividadEconomica As DataGridViewTextBoxColumn
    Friend WithEvents Reestructura As DataGridViewTextBoxColumn
    Friend WithEvents ParteRelacionada As DataGridViewTextBoxColumn
    Friend WithEvents Prendaria As DataGridViewTextBoxColumn
    Friend WithEvents Hipotecaria As DataGridViewTextBoxColumn
    Friend WithEvents GarantiaLiquida As DataGridViewTextBoxColumn
    Friend WithEvents GarantiaFega As DataGridViewTextBoxColumn
    Friend WithEvents TipoPersona As DataGridViewTextBoxColumn
    Friend WithEvents NoLetras As DataGridViewTextBoxColumn
    Friend WithEvents LetrasFacturadas As DataGridViewTextBoxColumn
End Class
