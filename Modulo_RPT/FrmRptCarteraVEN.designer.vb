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
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaActivacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaTerminacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasRetrasoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoInsolutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoSeguroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoOtrosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentaCapitalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentaOtrosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentaInteresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Castigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Garantia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalVencidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarteraVencidaRPTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportesDS = New Agil.ReportesDS()
        Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarteraVencidaRPTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnProc
        '
        Me.BtnProc.Location = New System.Drawing.Point(141, 7)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.FechaActivacionDataGridViewTextBoxColumn, Me.FechaTerminacionDataGridViewTextBoxColumn, Me.DiasRetrasoDataGridViewTextBoxColumn, Me.SaldoInsolutoDataGridViewTextBoxColumn, Me.SaldoSeguroDataGridViewTextBoxColumn, Me.SaldoOtrosDataGridViewTextBoxColumn, Me.RentaCapitalDataGridViewTextBoxColumn, Me.RentaOtrosDataGridViewTextBoxColumn, Me.RentaInteresDataGridViewTextBoxColumn, Me.Castigo, Me.Garantia, Me.TotalVencidoDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CarteraVencidaRPTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 635)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(974, 57)
        Me.DataGridView1.TabIndex = 5
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
        'TotalVencidoDataGridViewTextBoxColumn
        '
        Me.TotalVencidoDataGridViewTextBoxColumn.DataPropertyName = "TotalVencido"
        Me.TotalVencidoDataGridViewTextBoxColumn.HeaderText = "TotalVencido"
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
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.CRViewer.Size = New System.Drawing.Size(974, 593)
        Me.CRViewer.TabIndex = 6
        Me.CRViewer.ViewTimeSelectionFormula = ""
        '
        'FrmRptCarteraVEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 704)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CRViewer)
        Me.Controls.Add(Me.CmbDB)
        Me.Controls.Add(Me.BtnProc)
        Me.Name = "FrmRptCarteraVEN"
        Me.Text = "Reporte de Cartera Vencida"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarteraVencidaRPTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnProc As System.Windows.Forms.Button
    Friend WithEvents CmbDB As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ReportesDS As Agil.ReportesDS
    Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CarteraVencidaRPTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaActivacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaTerminacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasRetrasoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoInsolutoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoSeguroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoOtrosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RentaCapitalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RentaOtrosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RentaInteresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Castigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Garantia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalVencidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
