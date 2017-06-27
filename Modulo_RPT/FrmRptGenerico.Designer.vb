<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptGnerico
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
        Me.ReportesDS1 = New Agil.ReportesDS()
        Me.CRViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.AviosDS1 = New Agil.AviosDSX()
        CType(Me.ReportesDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportesDS1
        '
        Me.ReportesDS1.DataSetName = "ReportesDS"
        Me.ReportesDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CRViewer1
        '
        Me.CRViewer1.ActiveViewIndex = -1
        Me.CRViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CRViewer1.Name = "CRViewer1"
        Me.CRViewer1.SelectionFormula = ""
        Me.CRViewer1.Size = New System.Drawing.Size(787, 420)
        Me.CRViewer1.TabIndex = 0
        Me.CRViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CRViewer1.ViewTimeSelectionFormula = ""
        '
        'AviosDS1
        '
        Me.AviosDS1.DataSetName = "AviosDSX"
        Me.AviosDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrmRptGnerico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 420)
        Me.Controls.Add(Me.CRViewer1)
        Me.Name = "FrmRptGnerico"
        Me.Text = "Reporte de Bitacora de Asingacion de Promotores"
        CType(Me.ReportesDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportesDS1 As Agil.ReportesDS
    Friend WithEvents CRViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents AviosDS1 As Agil.AviosDSX
End Class
