<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRptSaldosPROM
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
        Me.BtnProc = New System.Windows.Forms.Button()
        Me.CmbDB = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.IdSaldoPromedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloPagareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaTerminacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoFinanciadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAlCierreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoPromedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoTasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaDiffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPersonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RPTSaldosPromedioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportesDS = New Agil.ReportesDS()
        Me.RPT_SaldosPromedioTableAdapter = New Agil.ReportesDSTableAdapters.RPT_SaldosPromedioTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RPTSaldosPromedioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnProc
        '
        Me.BtnProc.Location = New System.Drawing.Point(145, 7)
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
        Me.CmbDB.Location = New System.Drawing.Point(18, 9)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSaldoPromedioDataGridViewTextBoxColumn, Me.AnexoDataGridViewTextBoxColumn, Me.CicloPagareDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.FechaContratoDataGridViewTextBoxColumn, Me.FechaTerminacionDataGridViewTextBoxColumn, Me.FechaDePagoDataGridViewTextBoxColumn, Me.MontoFinanciadoDataGridViewTextBoxColumn, Me.SaldoAlCierreDataGridViewTextBoxColumn, Me.SaldoPromedioDataGridViewTextBoxColumn, Me.TipoTasaDataGridViewTextBoxColumn, Me.TasaDiffDataGridViewTextBoxColumn, Me.SucursalDataGridViewTextBoxColumn, Me.TipoPersonaDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RPTSaldosPromedioBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(18, 603)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(973, 89)
        Me.DataGridView1.TabIndex = 5
        '
        'CRViewer
        '
        Me.CRViewer.ActiveViewIndex = -1
        Me.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewer.Location = New System.Drawing.Point(17, 36)
        Me.CRViewer.Name = "CRViewer"
        Me.CRViewer.SelectionFormula = ""
        Me.CRViewer.Size = New System.Drawing.Size(974, 561)
        Me.CRViewer.TabIndex = 6
        Me.CRViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CRViewer.ViewTimeSelectionFormula = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(976, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(316, 7)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(534, 23)
        Me.ProgressBar1.TabIndex = 42
        Me.ProgressBar1.Visible = False
        '
        'IdSaldoPromedioDataGridViewTextBoxColumn
        '
        Me.IdSaldoPromedioDataGridViewTextBoxColumn.DataPropertyName = "id_SaldoPromedio"
        Me.IdSaldoPromedioDataGridViewTextBoxColumn.HeaderText = "id_SaldoPromedio"
        Me.IdSaldoPromedioDataGridViewTextBoxColumn.Name = "IdSaldoPromedioDataGridViewTextBoxColumn"
        Me.IdSaldoPromedioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdSaldoPromedioDataGridViewTextBoxColumn.Visible = False
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CicloPagareDataGridViewTextBoxColumn
        '
        Me.CicloPagareDataGridViewTextBoxColumn.DataPropertyName = "Ciclo Pagare"
        Me.CicloPagareDataGridViewTextBoxColumn.HeaderText = "Ciclo Pagare"
        Me.CicloPagareDataGridViewTextBoxColumn.Name = "CicloPagareDataGridViewTextBoxColumn"
        Me.CicloPagareDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaContratoDataGridViewTextBoxColumn
        '
        Me.FechaContratoDataGridViewTextBoxColumn.DataPropertyName = "FechaContrato"
        Me.FechaContratoDataGridViewTextBoxColumn.HeaderText = "FechaContrato"
        Me.FechaContratoDataGridViewTextBoxColumn.Name = "FechaContratoDataGridViewTextBoxColumn"
        Me.FechaContratoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaTerminacionDataGridViewTextBoxColumn
        '
        Me.FechaTerminacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha Terminacion"
        Me.FechaTerminacionDataGridViewTextBoxColumn.HeaderText = "Fecha Terminacion"
        Me.FechaTerminacionDataGridViewTextBoxColumn.Name = "FechaTerminacionDataGridViewTextBoxColumn"
        Me.FechaTerminacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDePagoDataGridViewTextBoxColumn
        '
        Me.FechaDePagoDataGridViewTextBoxColumn.DataPropertyName = "Fecha de Pago"
        Me.FechaDePagoDataGridViewTextBoxColumn.HeaderText = "Fecha de Pago"
        Me.FechaDePagoDataGridViewTextBoxColumn.Name = "FechaDePagoDataGridViewTextBoxColumn"
        Me.FechaDePagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoFinanciadoDataGridViewTextBoxColumn
        '
        Me.MontoFinanciadoDataGridViewTextBoxColumn.DataPropertyName = "Monto Financiado"
        Me.MontoFinanciadoDataGridViewTextBoxColumn.HeaderText = "Monto Financiado"
        Me.MontoFinanciadoDataGridViewTextBoxColumn.Name = "MontoFinanciadoDataGridViewTextBoxColumn"
        Me.MontoFinanciadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAlCierreDataGridViewTextBoxColumn
        '
        Me.SaldoAlCierreDataGridViewTextBoxColumn.DataPropertyName = "Saldo al Cierre"
        Me.SaldoAlCierreDataGridViewTextBoxColumn.HeaderText = "Saldo al Cierre"
        Me.SaldoAlCierreDataGridViewTextBoxColumn.Name = "SaldoAlCierreDataGridViewTextBoxColumn"
        Me.SaldoAlCierreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoPromedioDataGridViewTextBoxColumn
        '
        Me.SaldoPromedioDataGridViewTextBoxColumn.DataPropertyName = "Saldo Promedio"
        Me.SaldoPromedioDataGridViewTextBoxColumn.HeaderText = "Saldo Promedio"
        Me.SaldoPromedioDataGridViewTextBoxColumn.Name = "SaldoPromedioDataGridViewTextBoxColumn"
        Me.SaldoPromedioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoTasaDataGridViewTextBoxColumn
        '
        Me.TipoTasaDataGridViewTextBoxColumn.DataPropertyName = "Tipo Tasa"
        Me.TipoTasaDataGridViewTextBoxColumn.HeaderText = "Tipo Tasa"
        Me.TipoTasaDataGridViewTextBoxColumn.Name = "TipoTasaDataGridViewTextBoxColumn"
        Me.TipoTasaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TasaDiffDataGridViewTextBoxColumn
        '
        Me.TasaDiffDataGridViewTextBoxColumn.DataPropertyName = "Tasa Diff"
        Me.TasaDiffDataGridViewTextBoxColumn.HeaderText = "Tasa Diff"
        Me.TasaDiffDataGridViewTextBoxColumn.Name = "TasaDiffDataGridViewTextBoxColumn"
        Me.TasaDiffDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SucursalDataGridViewTextBoxColumn
        '
        Me.SucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.Name = "SucursalDataGridViewTextBoxColumn"
        Me.SucursalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoPersonaDataGridViewTextBoxColumn
        '
        Me.TipoPersonaDataGridViewTextBoxColumn.DataPropertyName = "Tipo Persona"
        Me.TipoPersonaDataGridViewTextBoxColumn.HeaderText = "Tipo Persona"
        Me.TipoPersonaDataGridViewTextBoxColumn.Name = "TipoPersonaDataGridViewTextBoxColumn"
        Me.TipoPersonaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoCreditoDataGridViewTextBoxColumn
        '
        Me.TipoCreditoDataGridViewTextBoxColumn.DataPropertyName = "Tipo Credito"
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "Tipo Credito"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RPTSaldosPromedioBindingSource
        '
        Me.RPTSaldosPromedioBindingSource.DataMember = "RPT_SaldosPromedio"
        Me.RPTSaldosPromedioBindingSource.DataSource = Me.ReportesDS
        '
        'ReportesDS
        '
        Me.ReportesDS.DataSetName = "ReportesDS"
        Me.ReportesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RPT_SaldosPromedioTableAdapter
        '
        Me.RPT_SaldosPromedioTableAdapter.ClearBeforeFill = True
        '
        'FrmRptSaldosPROM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 704)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CRViewer)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmbDB)
        Me.Controls.Add(Me.BtnProc)
        Me.Name = "FrmRptSaldosPROM"
        Me.Text = "Reportes de Saldos Promedio"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RPTSaldosPromedioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnProc As System.Windows.Forms.Button
    Friend WithEvents CmbDB As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents ReportesDS As ReportesDS
    Friend WithEvents RPTSaldosPromedioBindingSource As BindingSource
    Friend WithEvents RPT_SaldosPromedioTableAdapter As ReportesDSTableAdapters.RPT_SaldosPromedioTableAdapter
    Friend WithEvents IdSaldoPromedioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloPagareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaContratoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaTerminacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDePagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoFinanciadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoAlCierreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoPromedioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoTasaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TasaDiffDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoPersonaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
