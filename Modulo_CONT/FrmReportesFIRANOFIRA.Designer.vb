<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportesFIRANOFIRA
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
        Me.cbBase = New System.Windows.Forms.ComboBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextFile = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lberror = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbBase
        '
        Me.cbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBase.FormattingEnabled = True
        Me.cbBase.Location = New System.Drawing.Point(176, 6)
        Me.cbBase.Name = "cbBase"
        Me.cbBase.Size = New System.Drawing.Size(105, 21)
        Me.cbBase.TabIndex = 26
        '
        'btnProcesar
        '
        Me.btnProcesar.ForeColor = System.Drawing.Color.Black
        Me.btnProcesar.Location = New System.Drawing.Point(713, 60)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 25
        Me.btnProcesar.Text = "Generar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Mes de la Base a procesar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Cartera Fira"
        '
        'TextFile
        '
        Me.TextFile.Location = New System.Drawing.Point(82, 33)
        Me.TextFile.Name = "TextFile"
        Me.TextFile.ReadOnly = True
        Me.TextFile.Size = New System.Drawing.Size(625, 20)
        Me.TextFile.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Cargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lberror
        '
        Me.Lberror.AutoSize = True
        Me.Lberror.ForeColor = System.Drawing.Color.Red
        Me.Lberror.Location = New System.Drawing.Point(79, 60)
        Me.Lberror.Name = "Lberror"
        Me.Lberror.Size = New System.Drawing.Size(29, 13)
        Me.Lberror.TabIndex = 30
        Me.Lberror.Text = "Error"
        Me.Lberror.Visible = False
        '
        'FrmReportesFIRANOFIRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 95)
        Me.Controls.Add(Me.Lberror)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbBase)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmReportesFIRANOFIRA"
        Me.Text = "Generacion de reportes de Cartera Fira y No Fira"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbBase As ComboBox
    Friend WithEvents btnProcesar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextFile As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Lberror As Label
End Class
