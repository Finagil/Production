<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCancelaAviso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.txtAviso = New System.Windows.Forms.TextBox()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.btnVerAviso = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LbfACTURA = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 50)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPageNavigateButtons = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.ShowZoomButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1008, 640)
        Me.CrystalReportViewer1.TabIndex = 6
        Me.CrystalReportViewer1.TabStop = False
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'txtAviso
        '
        Me.txtAviso.Location = New System.Drawing.Point(116, 19)
        Me.txtAviso.MaxLength = 6
        Me.txtAviso.Name = "txtAviso"
        Me.txtAviso.Size = New System.Drawing.Size(44, 20)
        Me.txtAviso.TabIndex = 1
        Me.txtAviso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInicio
        '
        Me.lblInicio.Location = New System.Drawing.Point(16, 19)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(94, 20)
        Me.lblInicio.TabIndex = 8
        Me.lblInicio.Text = "Número de  Aviso"
        Me.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnVerAviso
        '
        Me.btnVerAviso.Location = New System.Drawing.Point(166, 17)
        Me.btnVerAviso.Name = "btnVerAviso"
        Me.btnVerAviso.Size = New System.Drawing.Size(75, 23)
        Me.btnVerAviso.TabIndex = 2
        Me.btnVerAviso.Text = "Ver Aviso"
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(336, 17)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(244, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancela Aviso"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LbfACTURA
        '
        Me.LbfACTURA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbfACTURA.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LbfACTURA.Location = New System.Drawing.Point(565, 23)
        Me.LbfACTURA.Name = "LbfACTURA"
        Me.LbfACTURA.Size = New System.Drawing.Size(451, 23)
        Me.LbfACTURA.TabIndex = 10
        Me.LbfACTURA.Text = "SIN FACTURA"
        Me.LbfACTURA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LbfACTURA.Visible = False
        '
        'frmCancelaAviso
        '
        Me.AcceptButton = Me.btnVerAviso
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1024, 702)
        Me.Controls.Add(Me.LbfACTURA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVerAviso)
        Me.Controls.Add(Me.lblInicio)
        Me.Controls.Add(Me.txtAviso)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmCancelaAviso"
        Me.Text = "Cancelación de Avisos de Vencimiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtAviso As System.Windows.Forms.TextBox
    Friend WithEvents lblInicio As System.Windows.Forms.Label
    Friend WithEvents btnVerAviso As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LbfACTURA As Label
End Class
