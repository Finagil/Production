<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPideProductor
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
        Me.txtMenu = New System.Windows.Forms.TextBox()
        Me.lblProductores = New System.Windows.Forms.Label()
        Me.cbProductores = New System.Windows.Forms.ComboBox()
        Me.lblContratos = New System.Windows.Forms.Label()
        Me.lbContratos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnOnbaseCRE = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtanexo = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMenu
        '
        Me.txtMenu.Location = New System.Drawing.Point(16, 137)
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.ReadOnly = True
        Me.txtMenu.Size = New System.Drawing.Size(40, 20)
        Me.txtMenu.TabIndex = 12
        Me.txtMenu.Visible = False
        '
        'lblProductores
        '
        Me.lblProductores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductores.Location = New System.Drawing.Point(17, 40)
        Me.lblProductores.Name = "lblProductores"
        Me.lblProductores.Size = New System.Drawing.Size(432, 16)
        Me.lblProductores.TabIndex = 10
        Me.lblProductores.Text = "Selecciona un Productor de la siguiente Lista"
        '
        'cbProductores
        '
        Me.cbProductores.Location = New System.Drawing.Point(16, 65)
        Me.cbProductores.Name = "cbProductores"
        Me.cbProductores.Size = New System.Drawing.Size(424, 21)
        Me.cbProductores.TabIndex = 11
        Me.cbProductores.Text = "ComboBox1"
        '
        'lblContratos
        '
        Me.lblContratos.AutoSize = True
        Me.lblContratos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContratos.Location = New System.Drawing.Point(443, 24)
        Me.lblContratos.Name = "lblContratos"
        Me.lblContratos.Size = New System.Drawing.Size(166, 13)
        Me.lblContratos.TabIndex = 13
        Me.lblContratos.Text = "Contratos de este Productor"
        Me.lblContratos.Visible = False
        '
        'lbContratos
        '
        Me.lbContratos.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContratos.ItemHeight = 15
        Me.lbContratos.Location = New System.Drawing.Point(446, 40)
        Me.lbContratos.Name = "lbContratos"
        Me.lbContratos.Size = New System.Drawing.Size(571, 469)
        Me.lbContratos.TabIndex = 14
        Me.lbContratos.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 496)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "(A) Anticipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "(H) Avío"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 462)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "(CC) Cuenta Corriente"
        '
        'BtnOnbaseCRE
        '
        Me.BtnOnbaseCRE.Enabled = False
        Me.BtnOnbaseCRE.Location = New System.Drawing.Point(12, 92)
        Me.BtnOnbaseCRE.Name = "BtnOnbaseCRE"
        Me.BtnOnbaseCRE.Size = New System.Drawing.Size(104, 24)
        Me.BtnOnbaseCRE.TabIndex = 136
        Me.BtnOnbaseCRE.Text = "OnBase Crédito"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Filtro por contrato:"
        '
        'Txtanexo
        '
        Me.Txtanexo.Location = New System.Drawing.Point(131, 12)
        Me.Txtanexo.Mask = "00000/0000"
        Me.Txtanexo.Name = "Txtanexo"
        Me.Txtanexo.Size = New System.Drawing.Size(75, 20)
        Me.Txtanexo.TabIndex = 139
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(122, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 140
        Me.Button1.Text = "Doctos. Crédito"
        '
        'frmPideProductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 515)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txtanexo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnOnbaseCRE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblContratos)
        Me.Controls.Add(Me.lbContratos)
        Me.Controls.Add(Me.txtMenu)
        Me.Controls.Add(Me.lblProductores)
        Me.Controls.Add(Me.cbProductores)
        Me.Name = "frmPideProductor"
        Me.Text = "Selección de Productor y Contrato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMenu As System.Windows.Forms.TextBox
    Friend WithEvents lblProductores As System.Windows.Forms.Label
    Friend WithEvents cbProductores As System.Windows.Forms.ComboBox
    Friend WithEvents lblContratos As System.Windows.Forms.Label
    Friend WithEvents lbContratos As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnOnbaseCRE As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtanexo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As Button
End Class
