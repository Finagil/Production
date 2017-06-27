<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptCartera
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
        Me.CheckVEN = New System.Windows.Forms.CheckBox()
        Me.CheckCAS = New System.Windows.Forms.CheckBox()
        Me.BtnProc = New System.Windows.Forms.Button()
        Me.CmbDB = New System.Windows.Forms.ComboBox()
        Me.CheckGAR = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalExigibleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoInsoluto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promotor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarteraExigibleRPTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportesDS = New Agil.ReportesDS()
        Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarteraExigibleRPTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckVEN
        '
        Me.CheckVEN.AutoSize = True
        Me.CheckVEN.Location = New System.Drawing.Point(13, 13)
        Me.CheckVEN.Name = "CheckVEN"
        Me.CheckVEN.Size = New System.Drawing.Size(128, 17)
        Me.CheckVEN.TabIndex = 0
        Me.CheckVEN.Text = "+ marcados Vencidos"
        Me.CheckVEN.UseVisualStyleBackColor = True
        '
        'CheckCAS
        '
        Me.CheckCAS.AutoSize = True
        Me.CheckCAS.Location = New System.Drawing.Point(142, 13)
        Me.CheckCAS.Name = "CheckCAS"
        Me.CheckCAS.Size = New System.Drawing.Size(137, 17)
        Me.CheckCAS.TabIndex = 1
        Me.CheckCAS.Text = "+ Marcados Castigados"
        Me.CheckCAS.UseVisualStyleBackColor = True
        '
        'BtnProc
        '
        Me.BtnProc.Location = New System.Drawing.Point(533, 7)
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
        Me.CmbDB.Location = New System.Drawing.Point(406, 9)
        Me.CmbDB.Name = "CmbDB"
        Me.CmbDB.Size = New System.Drawing.Size(121, 21)
        Me.CmbDB.TabIndex = 3
        '
        'CheckGAR
        '
        Me.CheckGAR.AutoSize = True
        Me.CheckGAR.Enabled = False
        Me.CheckGAR.Location = New System.Drawing.Point(281, 13)
        Me.CheckGAR.Name = "CheckGAR"
        Me.CheckGAR.Size = New System.Drawing.Size(116, 17)
        Me.CheckGAR.TabIndex = 4
        Me.CheckGAR.Text = "+ Garantia Ejercida"
        Me.CheckGAR.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.DiasDataGridViewTextBoxColumn, Me.DiasDataGridViewTextBoxColumn1, Me.DiasDataGridViewTextBoxColumn2, Me.DiasDataGridViewTextBoxColumn3, Me.TotalExigibleDataGridViewTextBoxColumn, Me.SaldoInsoluto, Me.TipoCreditoDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.Promotor})
        Me.DataGridView1.DataSource = Me.CarteraExigibleRPTBindingSource
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
        'DiasDataGridViewTextBoxColumn
        '
        Me.DiasDataGridViewTextBoxColumn.DataPropertyName = "29dias"
        Me.DiasDataGridViewTextBoxColumn.HeaderText = "29dias"
        Me.DiasDataGridViewTextBoxColumn.Name = "DiasDataGridViewTextBoxColumn"
        Me.DiasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiasDataGridViewTextBoxColumn1
        '
        Me.DiasDataGridViewTextBoxColumn1.DataPropertyName = "59Dias"
        Me.DiasDataGridViewTextBoxColumn1.HeaderText = "59Dias"
        Me.DiasDataGridViewTextBoxColumn1.Name = "DiasDataGridViewTextBoxColumn1"
        Me.DiasDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DiasDataGridViewTextBoxColumn2
        '
        Me.DiasDataGridViewTextBoxColumn2.DataPropertyName = "89Dias"
        Me.DiasDataGridViewTextBoxColumn2.HeaderText = "89Dias"
        Me.DiasDataGridViewTextBoxColumn2.Name = "DiasDataGridViewTextBoxColumn2"
        Me.DiasDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DiasDataGridViewTextBoxColumn3
        '
        Me.DiasDataGridViewTextBoxColumn3.DataPropertyName = "90Dias"
        Me.DiasDataGridViewTextBoxColumn3.HeaderText = "90Dias"
        Me.DiasDataGridViewTextBoxColumn3.Name = "DiasDataGridViewTextBoxColumn3"
        Me.DiasDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'TotalExigibleDataGridViewTextBoxColumn
        '
        Me.TotalExigibleDataGridViewTextBoxColumn.DataPropertyName = "Total Exigible"
        Me.TotalExigibleDataGridViewTextBoxColumn.HeaderText = "Total Exigible"
        Me.TotalExigibleDataGridViewTextBoxColumn.Name = "TotalExigibleDataGridViewTextBoxColumn"
        Me.TotalExigibleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoInsoluto
        '
        Me.SaldoInsoluto.DataPropertyName = "SaldoInsoluto"
        Me.SaldoInsoluto.HeaderText = "SaldoInsoluto"
        Me.SaldoInsoluto.Name = "SaldoInsoluto"
        Me.SaldoInsoluto.ReadOnly = True
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
        'Promotor
        '
        Me.Promotor.DataPropertyName = "Promotor"
        Me.Promotor.HeaderText = "Promotor"
        Me.Promotor.Name = "Promotor"
        Me.Promotor.ReadOnly = True
        '
        'CarteraExigibleRPTBindingSource
        '
        Me.CarteraExigibleRPTBindingSource.DataMember = "CarteraExigibleRPT"
        Me.CarteraExigibleRPTBindingSource.DataSource = Me.ReportesDS
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
        Me.CRViewer.Location = New System.Drawing.Point(17, 36)
        Me.CRViewer.Name = "CRViewer"
        Me.CRViewer.SelectionFormula = ""
        Me.CRViewer.Size = New System.Drawing.Size(974, 593)
        Me.CRViewer.TabIndex = 6
        Me.CRViewer.ViewTimeSelectionFormula = ""
        '
        'FrmRptCartera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 704)
        Me.Controls.Add(Me.CRViewer)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CheckGAR)
        Me.Controls.Add(Me.CmbDB)
        Me.Controls.Add(Me.BtnProc)
        Me.Controls.Add(Me.CheckCAS)
        Me.Controls.Add(Me.CheckVEN)
        Me.Name = "FrmRptCartera"
        Me.Text = "Reportes de Cartera Exigible"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarteraExigibleRPTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckVEN As System.Windows.Forms.CheckBox
    Friend WithEvents CheckCAS As System.Windows.Forms.CheckBox
    Friend WithEvents BtnProc As System.Windows.Forms.Button
    Friend WithEvents CmbDB As System.Windows.Forms.ComboBox
    Friend WithEvents CheckGAR As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CarteraExigibleRPTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportesDS As Agil.ReportesDS
    Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalExigibleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoInsoluto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Promotor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
