<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaCuentaDom
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
        Me.components = New System.ComponentModel.Container()
        Me.txtCuentaD = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CXPBancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS = New Agil.PromocionDS()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtAnexo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCtaCLABE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCuentaE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.CXP_BancosTableAdapter = New Agil.PromocionDSTableAdapters.CXP_BancosTableAdapter()
        CType(Me.CXPBancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCuentaD
        '
        Me.txtCuentaD.Location = New System.Drawing.Point(183, 83)
        Me.txtCuentaD.Name = "txtCuentaD"
        Me.txtCuentaD.Size = New System.Drawing.Size(112, 20)
        Me.txtCuentaD.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CXPBancosBindingSource
        Me.ComboBox1.DisplayMember = "nombreCorto"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(183, 144)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(146, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "idBancos"
        '
        'CXPBancosBindingSource
        '
        Me.CXPBancosBindingSource.DataMember = "CXP_Bancos"
        Me.CXPBancosBindingSource.DataSource = Me.PromocionDS
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTitular
        '
        Me.txtTitular.Location = New System.Drawing.Point(183, 210)
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(322, 20)
        Me.txtTitular.TabIndex = 2
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(491, 265)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 23)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Alta de Cuenta"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtAnexo
        '
        Me.txtAnexo.Location = New System.Drawing.Point(445, 46)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.Size = New System.Drawing.Size(8, 20)
        Me.txtAnexo.TabIndex = 24
        Me.txtAnexo.Text = "TextBox1"
        Me.txtAnexo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "INFORMACION DE LA CUENTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Numero de Cuenta/Tarjeta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Seleccciona Banco de la Cuenta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Titular de la Cuenta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Numero de Cuenta CLABE"
        '
        'txtCtaCLABE
        '
        Me.txtCtaCLABE.Location = New System.Drawing.Point(183, 49)
        Me.txtCtaCLABE.Name = "txtCtaCLABE"
        Me.txtCtaCLABE.Size = New System.Drawing.Size(125, 20)
        Me.txtCtaCLABE.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Numero de Cuenta EJE"
        '
        'txtCuentaE
        '
        Me.txtCuentaE.Location = New System.Drawing.Point(183, 113)
        Me.txtCuentaE.Name = "txtCuentaE"
        Me.txtCuentaE.Size = New System.Drawing.Size(76, 20)
        Me.txtCuentaE.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Seleccciona Concepto del Pago"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"PAGOS DE CREDITO LIQUIDEZ INMEDIATA", "PAGOS DE CREDITO TRADICIONAL"})
        Me.ComboBox2.Location = New System.Drawing.Point(183, 175)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(413, 21)
        Me.ComboBox2.TabIndex = 33
        '
        'btnModif
        '
        Me.btnModif.Location = New System.Drawing.Point(348, 265)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(105, 23)
        Me.btnModif.TabIndex = 35
        Me.btnModif.Text = "Modificar Cuenta"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'CXP_BancosTableAdapter
        '
        Me.CXP_BancosTableAdapter.ClearBeforeFill = True
        '
        'frmAltaCuentaDom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 307)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCuentaE)
        Me.Controls.Add(Me.txtCtaCLABE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnexo)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtTitular)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtCuentaD)
        Me.Name = "frmAltaCuentaDom"
        Me.Text = "frmAltaCuentaDom"
        CType(Me.CXPBancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCuentaD As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtTitular As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCtaCLABE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaE As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents PromocionDS As PromocionDS
    Friend WithEvents CXPBancosBindingSource As BindingSource
    Friend WithEvents CXP_BancosTableAdapter As PromocionDSTableAdapters.CXP_BancosTableAdapter
End Class
