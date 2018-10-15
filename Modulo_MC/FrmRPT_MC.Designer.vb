<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRPT_MC
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BtnMail = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Crv
        '
        Me.Crv.ActiveViewIndex = -1
        Me.Crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crv.Location = New System.Drawing.Point(0, 0)
        Me.Crv.Name = "Crv"
        Me.Crv.ShowGroupTreeButton = False
        Me.Crv.Size = New System.Drawing.Size(1049, 591)
        Me.Crv.TabIndex = 0
        Me.Crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'BtnMail
        '
        Me.BtnMail.Location = New System.Drawing.Point(810, 6)
        Me.BtnMail.Name = "BtnMail"
        Me.BtnMail.Size = New System.Drawing.Size(75, 23)
        Me.BtnMail.TabIndex = 1
        Me.BtnMail.Text = "Enviar"
        Me.BtnMail.UseVisualStyleBackColor = True
        Me.BtnMail.Visible = False
        '
        'FrmRPT_MC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 591)
        Me.Controls.Add(Me.BtnMail)
        Me.Controls.Add(Me.Crv)
        Me.Name = "FrmRPT_MC"
        Me.Text = "Reportes Mesa de control"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnMail As Button
End Class
