<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCondonaMoras
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
        Me.DTPAplicacion = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboDias = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DTPAplicacion
        '
        Me.DTPAplicacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPAplicacion.Location = New System.Drawing.Point(15, 27)
        Me.DTPAplicacion.Name = "DTPAplicacion"
        Me.DTPAplicacion.Size = New System.Drawing.Size(108, 20)
        Me.DTPAplicacion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha de Aplición"
        '
        'ComboTipo
        '
        Me.ComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipo.FormattingEnabled = True
        Me.ComboTipo.Items.AddRange(New Object() {"Domiciliado", "Referenciado", "Domiciliado y Referenciado"})
        Me.ComboTipo.Location = New System.Drawing.Point(129, 27)
        Me.ComboTipo.Name = "ComboTipo"
        Me.ComboTipo.Size = New System.Drawing.Size(168, 21)
        Me.ComboTipo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha de Aplición"
        '
        'ComboDias
        '
        Me.ComboDias.FormattingEnabled = True
        Me.ComboDias.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboDias.Location = New System.Drawing.Point(303, 27)
        Me.ComboDias.Name = "ComboDias"
        Me.ComboDias.Size = New System.Drawing.Size(94, 21)
        Me.ComboDias.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Días de Moratorios"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(303, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCondonaMoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 88)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboDias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboTipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPAplicacion)
        Me.Name = "frmCondonaMoras"
        Me.Text = "Condonar Moratorios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTPAplicacion As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboTipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboDias As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
