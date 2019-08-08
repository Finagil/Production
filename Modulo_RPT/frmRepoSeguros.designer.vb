<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepoSeguros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtpProcesar = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cbBase = New System.Windows.Forms.ComboBox()
        Me.ReportesDS1 = New Agil.ReportesDS()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameCteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoEqDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoSegDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoOTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaCapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentasVenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpCompIvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RtasDepIvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAvioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDeudaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoposDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVecnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ReportesDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpProcesar
        '
        Me.dtpProcesar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProcesar.Location = New System.Drawing.Point(378, 9)
        Me.dtpProcesar.Name = "dtpProcesar"
        Me.dtpProcesar.Size = New System.Drawing.Size(88, 20)
        Me.dtpProcesar.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Selecciona  Año y Mes de la Base a procesar"
        '
        'btnProcesar
        '
        Me.btnProcesar.ForeColor = System.Drawing.Color.Black
        Me.btnProcesar.Location = New System.Drawing.Point(504, 6)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(78, 23)
        Me.btnProcesar.TabIndex = 14
        Me.btnProcesar.Text = "Generar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(651, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 18
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(8, 41)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.SelectionFormula = ""
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1079, 585)
        Me.CrystalReportViewer2.TabIndex = 22
        Me.CrystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer2.ViewTimeSelectionFormula = ""
        '
        'cbBase
        '
        Me.cbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBase.FormattingEnabled = True
        Me.cbBase.Location = New System.Drawing.Point(284, 8)
        Me.cbBase.Name = "cbBase"
        Me.cbBase.Size = New System.Drawing.Size(69, 21)
        Me.cbBase.TabIndex = 23
        '
        'ReportesDS1
        '
        Me.ReportesDS1.DataSetName = "ReportesDS"
        Me.ReportesDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ContratoDataGridViewTextBoxColumn, Me.NameCteDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.SaldoEqDataGridViewTextBoxColumn, Me.SaldoSegDataGridViewTextBoxColumn, Me.SaldoOTDataGridViewTextBoxColumn, Me.IvaCapDataGridViewTextBoxColumn, Me.RentasVenDataGridViewTextBoxColumn, Me.OpCompIvaDataGridViewTextBoxColumn, Me.RtasDepIvaDataGridViewTextBoxColumn, Me.SaldoAvioDataGridViewTextBoxColumn, Me.TotalDeudaDataGridViewTextBoxColumn, Me.PagoDataGridViewTextBoxColumn, Me.RFCDataGridViewTextBoxColumn, Me.CalleDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.CoposDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.FechaConDataGridViewTextBoxColumn, Me.FechaVecnDataGridViewTextBoxColumn, Me.Sucursal})
        Me.DataGridView1.DataMember = "dtReporte"
        Me.DataGridView1.DataSource = Me.ReportesDS1
        Me.DataGridView1.Location = New System.Drawing.Point(8, 632)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1079, 65)
        Me.DataGridView1.TabIndex = 24
        '
        'ContratoDataGridViewTextBoxColumn
        '
        Me.ContratoDataGridViewTextBoxColumn.DataPropertyName = "Contrato"
        Me.ContratoDataGridViewTextBoxColumn.HeaderText = "Contrato"
        Me.ContratoDataGridViewTextBoxColumn.Name = "ContratoDataGridViewTextBoxColumn"
        Me.ContratoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameCteDataGridViewTextBoxColumn
        '
        Me.NameCteDataGridViewTextBoxColumn.DataPropertyName = "NameCte"
        Me.NameCteDataGridViewTextBoxColumn.HeaderText = "NameCte"
        Me.NameCteDataGridViewTextBoxColumn.Name = "NameCteDataGridViewTextBoxColumn"
        Me.NameCteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "Edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "Edad"
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        Me.EdadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoEqDataGridViewTextBoxColumn
        '
        Me.SaldoEqDataGridViewTextBoxColumn.DataPropertyName = "SaldoEq"
        Me.SaldoEqDataGridViewTextBoxColumn.HeaderText = "SaldoEq"
        Me.SaldoEqDataGridViewTextBoxColumn.Name = "SaldoEqDataGridViewTextBoxColumn"
        Me.SaldoEqDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoSegDataGridViewTextBoxColumn
        '
        Me.SaldoSegDataGridViewTextBoxColumn.DataPropertyName = "SaldoSeg"
        Me.SaldoSegDataGridViewTextBoxColumn.HeaderText = "SaldoSeg"
        Me.SaldoSegDataGridViewTextBoxColumn.Name = "SaldoSegDataGridViewTextBoxColumn"
        Me.SaldoSegDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoOTDataGridViewTextBoxColumn
        '
        Me.SaldoOTDataGridViewTextBoxColumn.DataPropertyName = "SaldoOT"
        Me.SaldoOTDataGridViewTextBoxColumn.HeaderText = "SaldoOT"
        Me.SaldoOTDataGridViewTextBoxColumn.Name = "SaldoOTDataGridViewTextBoxColumn"
        Me.SaldoOTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IvaCapDataGridViewTextBoxColumn
        '
        Me.IvaCapDataGridViewTextBoxColumn.DataPropertyName = "IvaCap"
        Me.IvaCapDataGridViewTextBoxColumn.HeaderText = "IvaCap"
        Me.IvaCapDataGridViewTextBoxColumn.Name = "IvaCapDataGridViewTextBoxColumn"
        Me.IvaCapDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RentasVenDataGridViewTextBoxColumn
        '
        Me.RentasVenDataGridViewTextBoxColumn.DataPropertyName = "RentasVen"
        Me.RentasVenDataGridViewTextBoxColumn.HeaderText = "RentasVen"
        Me.RentasVenDataGridViewTextBoxColumn.Name = "RentasVenDataGridViewTextBoxColumn"
        Me.RentasVenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OpCompIvaDataGridViewTextBoxColumn
        '
        Me.OpCompIvaDataGridViewTextBoxColumn.DataPropertyName = "OpCompIva"
        Me.OpCompIvaDataGridViewTextBoxColumn.HeaderText = "OpCompIva"
        Me.OpCompIvaDataGridViewTextBoxColumn.Name = "OpCompIvaDataGridViewTextBoxColumn"
        Me.OpCompIvaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RtasDepIvaDataGridViewTextBoxColumn
        '
        Me.RtasDepIvaDataGridViewTextBoxColumn.DataPropertyName = "RtasDepIva"
        Me.RtasDepIvaDataGridViewTextBoxColumn.HeaderText = "RtasDepIva"
        Me.RtasDepIvaDataGridViewTextBoxColumn.Name = "RtasDepIvaDataGridViewTextBoxColumn"
        Me.RtasDepIvaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAvioDataGridViewTextBoxColumn
        '
        Me.SaldoAvioDataGridViewTextBoxColumn.DataPropertyName = "SaldoAvio"
        Me.SaldoAvioDataGridViewTextBoxColumn.HeaderText = "SaldoAvio"
        Me.SaldoAvioDataGridViewTextBoxColumn.Name = "SaldoAvioDataGridViewTextBoxColumn"
        Me.SaldoAvioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDeudaDataGridViewTextBoxColumn
        '
        Me.TotalDeudaDataGridViewTextBoxColumn.DataPropertyName = "TotalDeuda"
        Me.TotalDeudaDataGridViewTextBoxColumn.HeaderText = "TotalDeuda"
        Me.TotalDeudaDataGridViewTextBoxColumn.Name = "TotalDeudaDataGridViewTextBoxColumn"
        Me.TotalDeudaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagoDataGridViewTextBoxColumn
        '
        Me.PagoDataGridViewTextBoxColumn.DataPropertyName = "Pago"
        Me.PagoDataGridViewTextBoxColumn.HeaderText = "Pago"
        Me.PagoDataGridViewTextBoxColumn.Name = "PagoDataGridViewTextBoxColumn"
        Me.PagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RFCDataGridViewTextBoxColumn
        '
        Me.RFCDataGridViewTextBoxColumn.DataPropertyName = "RFC"
        Me.RFCDataGridViewTextBoxColumn.HeaderText = "RFC"
        Me.RFCDataGridViewTextBoxColumn.Name = "RFCDataGridViewTextBoxColumn"
        Me.RFCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CalleDataGridViewTextBoxColumn
        '
        Me.CalleDataGridViewTextBoxColumn.DataPropertyName = "Calle"
        Me.CalleDataGridViewTextBoxColumn.HeaderText = "Calle"
        Me.CalleDataGridViewTextBoxColumn.Name = "CalleDataGridViewTextBoxColumn"
        Me.CalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CoposDataGridViewTextBoxColumn
        '
        Me.CoposDataGridViewTextBoxColumn.DataPropertyName = "Copos"
        Me.CoposDataGridViewTextBoxColumn.HeaderText = "Copos"
        Me.CoposDataGridViewTextBoxColumn.Name = "CoposDataGridViewTextBoxColumn"
        Me.CoposDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaConDataGridViewTextBoxColumn
        '
        Me.FechaConDataGridViewTextBoxColumn.DataPropertyName = "FechaCon"
        Me.FechaConDataGridViewTextBoxColumn.HeaderText = "FechaCon"
        Me.FechaConDataGridViewTextBoxColumn.Name = "FechaConDataGridViewTextBoxColumn"
        Me.FechaConDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaVecnDataGridViewTextBoxColumn
        '
        Me.FechaVecnDataGridViewTextBoxColumn.DataPropertyName = "FechaVecn"
        Me.FechaVecnDataGridViewTextBoxColumn.HeaderText = "FechaVecn"
        Me.FechaVecnDataGridViewTextBoxColumn.Name = "FechaVecnDataGridViewTextBoxColumn"
        Me.FechaVecnDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Sucursal
        '
        Me.Sucursal.DataPropertyName = "Sucursal"
        Me.Sucursal.HeaderText = "Sucursal"
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.ReadOnly = True
        '
        'frmRepoSeguros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 701)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbBase)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpProcesar)
        Me.Name = "frmRepoSeguros"
        Me.Text = "Reporte de Seguros (Para Aseguradora)"
        CType(Me.ReportesDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpProcesar As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cbBase As System.Windows.Forms.ComboBox
    Friend WithEvents ReportesDS1 As ReportesDS
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ContratoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameCteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoEqDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoSegDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoOTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IvaCapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentasVenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpCompIvaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RtasDepIvaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoAvioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDeudaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RFCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoposDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaConDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaVecnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Sucursal As DataGridViewTextBoxColumn
End Class
