<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.lblcontraseña = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblcontraseña
        '
        Me.lblcontraseña.Location = New System.Drawing.Point(9, 33)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(89, 13)
        Me.lblcontraseña.TabIndex = 76
        Me.lblcontraseña.Text = "Contraseña:"
        Me.lblcontraseña.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblusuario
        '
        Me.lblusuario.Location = New System.Drawing.Point(27, 10)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(71, 13)
        Me.lblusuario.TabIndex = 75
        Me.lblusuario.Text = "Usuario:"
        Me.lblusuario.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(152, 71)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(103, 28)
        Me.btncancelar.TabIndex = 74
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(27, 71)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(103, 28)
        Me.btnIngresar.TabIndex = 73
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtcontraseña
        '
        Me.txtcontraseña.BackColor = System.Drawing.Color.AliceBlue
        Me.txtcontraseña.Location = New System.Drawing.Point(104, 33)
        Me.txtcontraseña.MaxLength = 15
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtcontraseña.Size = New System.Drawing.Size(126, 20)
        Me.txtcontraseña.TabIndex = 71
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.AliceBlue
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(104, 7)
        Me.txtUsuario.MaxLength = 30
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(126, 20)
        Me.txtUsuario.TabIndex = 70
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 111)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblcontraseña)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcontraseña As System.Windows.Forms.Label
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
End Class
