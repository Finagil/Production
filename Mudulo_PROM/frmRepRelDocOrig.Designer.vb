<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepRelDocOrig
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
        Me.crv_doc = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptDoctosRelacionados1 = New Agil.rptDoctosRelacionados()
        Me.SuspendLayout()
        '
        'crv_doc
        '
        Me.crv_doc.ActiveViewIndex = -1
        Me.crv_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_doc.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_doc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_doc.Location = New System.Drawing.Point(0, 0)
        Me.crv_doc.Name = "crv_doc"
        Me.crv_doc.Size = New System.Drawing.Size(742, 311)
        Me.crv_doc.TabIndex = 0
        Me.crv_doc.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmRepRelDocOrig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 311)
        Me.Controls.Add(Me.crv_doc)
        Me.Name = "frmRepRelDocOrig"
        Me.Text = "frmRepRelDocOrig"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crv_doc As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptDoctosRelacionados1 As rptDoctosRelacionados
End Class
