<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCarga_PI_SP
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonSelect = New System.Windows.Forms.Button()
        Me.TextF1 = New System.Windows.Forms.TextBox()
        Me.TextF2 = New System.Windows.Forms.TextBox()
        Me.ButtonCarga = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'ButtonSelect
        '
        Me.ButtonSelect.Location = New System.Drawing.Point(258, 67)
        Me.ButtonSelect.Name = "ButtonSelect"
        Me.ButtonSelect.Size = New System.Drawing.Size(133, 23)
        Me.ButtonSelect.TabIndex = 0
        Me.ButtonSelect.Text = "Seleccionar Archivos"
        Me.ButtonSelect.UseVisualStyleBackColor = True
        '
        'TextF1
        '
        Me.TextF1.Location = New System.Drawing.Point(12, 15)
        Me.TextF1.Name = "TextF1"
        Me.TextF1.ReadOnly = True
        Me.TextF1.Size = New System.Drawing.Size(518, 20)
        Me.TextF1.TabIndex = 1
        '
        'TextF2
        '
        Me.TextF2.Location = New System.Drawing.Point(12, 41)
        Me.TextF2.Name = "TextF2"
        Me.TextF2.ReadOnly = True
        Me.TextF2.Size = New System.Drawing.Size(518, 20)
        Me.TextF2.TabIndex = 2
        '
        'ButtonCarga
        '
        Me.ButtonCarga.Enabled = False
        Me.ButtonCarga.Location = New System.Drawing.Point(397, 67)
        Me.ButtonCarga.Name = "ButtonCarga"
        Me.ButtonCarga.Size = New System.Drawing.Size(133, 23)
        Me.ButtonCarga.TabIndex = 3
        Me.ButtonCarga.Text = "Cargar Datos"
        Me.ButtonCarga.UseVisualStyleBackColor = True
        '
        'FrmCarga_PI_SP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 101)
        Me.Controls.Add(Me.ButtonCarga)
        Me.Controls.Add(Me.TextF2)
        Me.Controls.Add(Me.TextF1)
        Me.Controls.Add(Me.ButtonSelect)
        Me.Name = "FrmCarga_PI_SP"
        Me.Text = "Cargar Archivos Fira PI y SP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ButtonSelect As Button
    Friend WithEvents TextF1 As TextBox
    Friend WithEvents TextF2 As TextBox
    Friend WithEvents ButtonCarga As Button
End Class
