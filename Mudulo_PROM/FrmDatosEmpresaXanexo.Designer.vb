<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatosEmpresaXanexo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextAnexo = New System.Windows.Forms.TextBox()
        Me.Textcli = New System.Windows.Forms.TextBox()
        Me.TextEmpre = New System.Windows.Forms.TextBox()
        Me.TextPlanta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Anexo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'TextAnexo
        '
        Me.TextAnexo.Location = New System.Drawing.Point(25, 39)
        Me.TextAnexo.Name = "TextAnexo"
        Me.TextAnexo.ReadOnly = True
        Me.TextAnexo.Size = New System.Drawing.Size(75, 20)
        Me.TextAnexo.TabIndex = 2
        '
        'Textcli
        '
        Me.Textcli.Location = New System.Drawing.Point(108, 39)
        Me.Textcli.Name = "Textcli"
        Me.Textcli.ReadOnly = True
        Me.Textcli.Size = New System.Drawing.Size(316, 20)
        Me.Textcli.TabIndex = 3
        '
        'TextEmpre
        '
        Me.TextEmpre.Location = New System.Drawing.Point(430, 39)
        Me.TextEmpre.MaxLength = 25
        Me.TextEmpre.Name = "TextEmpre"
        Me.TextEmpre.Size = New System.Drawing.Size(174, 20)
        Me.TextEmpre.TabIndex = 4
        '
        'TextPlanta
        '
        Me.TextPlanta.Location = New System.Drawing.Point(610, 39)
        Me.TextPlanta.MaxLength = 25
        Me.TextPlanta.Name = "TextPlanta"
        Me.TextPlanta.Size = New System.Drawing.Size(174, 20)
        Me.TextPlanta.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(428, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Empresa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(607, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Planta"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(790, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmDatosEmpresaXanexo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 77)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextPlanta)
        Me.Controls.Add(Me.TextEmpre)
        Me.Controls.Add(Me.Textcli)
        Me.Controls.Add(Me.TextAnexo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDatosEmpresaXanexo"
        Me.Text = "Datos de Empresa por Anexo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextAnexo As TextBox
    Friend WithEvents Textcli As TextBox
    Friend WithEvents TextEmpre As TextBox
    Friend WithEvents TextPlanta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
