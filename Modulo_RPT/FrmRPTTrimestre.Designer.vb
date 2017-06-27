<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRPTTrimestre
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbMes = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CRViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mes"
        '
        'CmbMes
        '
        Me.CmbMes.FormattingEnabled = True
        Me.CmbMes.Location = New System.Drawing.Point(45, 6)
        Me.CmbMes.Name = "CmbMes"
        Me.CmbMes.Size = New System.Drawing.Size(121, 21)
        Me.CmbMes.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(185, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Procesar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CRViewer1
        '
        Me.CRViewer1.ActiveViewIndex = -1
        Me.CRViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewer1.Location = New System.Drawing.Point(12, 33)
        Me.CRViewer1.Name = "CRViewer1"
        Me.CRViewer1.SelectionFormula = ""
        Me.CRViewer1.Size = New System.Drawing.Size(907, 426)
        Me.CRViewer1.TabIndex = 3
        Me.CRViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CRViewer1.ViewTimeSelectionFormula = ""
        '
        'FrmRPTTrimestre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 471)
        Me.Controls.Add(Me.CRViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmbMes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmRPTTrimestre"
        Me.Text = "Reporte de Informacion Trimestral"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CRViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
