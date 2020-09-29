<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambioCuenta
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
        Me.cbProductores = New System.Windows.Forms.ComboBox
        Me.lblProductores = New System.Windows.Forms.Label
        Me.txtBanco = New System.Windows.Forms.TextBox
        Me.txtCuenta = New System.Windows.Forms.TextBox
        Me.cbBanco = New System.Windows.Forms.ComboBox
        Me.txtCuentaNva = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCtaClabeBmer = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCClabe = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbProductores
        '
        Me.cbProductores.Location = New System.Drawing.Point(10, 42)
        Me.cbProductores.Name = "cbProductores"
        Me.cbProductores.Size = New System.Drawing.Size(424, 21)
        Me.cbProductores.TabIndex = 12
        Me.cbProductores.Text = "ComboBox1"
        '
        'lblProductores
        '
        Me.lblProductores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductores.Location = New System.Drawing.Point(12, 23)
        Me.lblProductores.Name = "lblProductores"
        Me.lblProductores.Size = New System.Drawing.Size(432, 16)
        Me.lblProductores.TabIndex = 13
        Me.lblProductores.Text = "Selecciona un Productor de la siguiente Lista"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(15, 112)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.ReadOnly = True
        Me.txtBanco.Size = New System.Drawing.Size(128, 20)
        Me.txtBanco.TabIndex = 14
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(167, 112)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(125, 20)
        Me.txtCuenta.TabIndex = 15
        '
        'cbBanco
        '
        Me.cbBanco.FormattingEnabled = True
        Me.cbBanco.Items.AddRange(New Object() {"BANAMEX", "BANCO AHORRO", "BANCO AZTECA", "BANCOMER", "BANCOPPEL", "BANORTE", "HSBC", "INBURSA", "SANTANDER", "SCOTIABANK"})
        Me.cbBanco.Location = New System.Drawing.Point(18, 45)
        Me.cbBanco.Name = "cbBanco"
        Me.cbBanco.Size = New System.Drawing.Size(128, 21)
        Me.cbBanco.TabIndex = 46
        Me.cbBanco.Visible = False
        '
        'txtCuentaNva
        '
        Me.txtCuentaNva.Location = New System.Drawing.Point(167, 46)
        Me.txtCuentaNva.Name = "txtCuentaNva"
        Me.txtCuentaNva.Size = New System.Drawing.Size(125, 20)
        Me.txtCuentaNva.TabIndex = 47
        Me.txtCuentaNva.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(380, 76)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 48
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 16)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Datos de la Cuenta Actual"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 16)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Ingresa los  Datos de la Nueva Cuenta"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCtaClabeBmer)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbBanco)
        Me.Panel1.Controls.Add(Me.txtCuentaNva)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(15, 183)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 112)
        Me.Panel1.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'txtCtaClabeBmer
        '
        Me.txtCtaClabeBmer.Location = New System.Drawing.Point(322, 45)
        Me.txtCtaClabeBmer.Name = "txtCtaClabeBmer"
        Me.txtCtaClabeBmer.Size = New System.Drawing.Size(125, 20)
        Me.txtCtaClabeBmer.TabIndex = 50
        Me.txtCtaClabeBmer.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'txtCClabe
        '
        Me.txtCClabe.Location = New System.Drawing.Point(309, 112)
        Me.txtCClabe.Name = "txtCClabe"
        Me.txtCClabe.ReadOnly = True
        Me.txtCClabe.Size = New System.Drawing.Size(125, 20)
        Me.txtCClabe.TabIndex = 52
        '
        'frmCambioCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 307)
        Me.Controls.Add(Me.txtCClabe)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.txtBanco)
        Me.Controls.Add(Me.lblProductores)
        Me.Controls.Add(Me.cbProductores)
        Me.Name = "frmCambioCuenta"
        Me.Text = "frmCambioCuenta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbProductores As System.Windows.Forms.ComboBox
    Friend WithEvents lblProductores As System.Windows.Forms.Label
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents cbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents txtCuentaNva As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCtaClabeBmer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCClabe As System.Windows.Forms.TextBox
End Class
