<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActiVaDomi
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
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TxtDomi = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(133, 31)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(121, 23)
        Me.Button8.TabIndex = 51
        Me.Button8.Text = "Activa Domi."
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TxtDomi
        '
        Me.TxtDomi.Location = New System.Drawing.Point(15, 34)
        Me.TxtDomi.MaxLength = 10
        Me.TxtDomi.Name = "TxtDomi"
        Me.TxtDomi.Size = New System.Drawing.Size(112, 20)
        Me.TxtDomi.TabIndex = 50
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "Anexo"
        '
        'FrmActiVaDomi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 83)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TxtDomi)
        Me.Controls.Add(Me.Label18)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmActiVaDomi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activación y Desactivación de Domiciliacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button8 As Button
    Friend WithEvents TxtDomi As TextBox
    Friend WithEvents Label18 As Label
End Class
