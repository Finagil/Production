<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAtachments
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
        Me.components = New System.ComponentModel.Container()
        Me.LstDoctos = New System.Windows.Forms.ListBox()
        Me.GENAtachmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GEN_AtachmentsTableAdapter = New Agil.GeneralDSTableAdapters.GEN_AtachmentsTableAdapter()
        Me.Grpdatos = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GENAtachmentsTipoAttachBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtFec = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtfile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtnotas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Buttonmod = New System.Windows.Forms.Button()
        Me.Buttonnew = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.GEN_AtachmentsTipoAttachTableAdapter = New Agil.GeneralDSTableAdapters.GEN_AtachmentsTipoAttachTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GENAtachmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grpdatos.SuspendLayout()
        CType(Me.GENAtachmentsTipoAttachBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstDoctos
        '
        Me.LstDoctos.DataSource = Me.GENAtachmentsBindingSource
        Me.LstDoctos.DisplayMember = "Titulo"
        Me.LstDoctos.FormattingEnabled = True
        Me.LstDoctos.Location = New System.Drawing.Point(12, 25)
        Me.LstDoctos.Name = "LstDoctos"
        Me.LstDoctos.Size = New System.Drawing.Size(549, 264)
        Me.LstDoctos.TabIndex = 0
        Me.LstDoctos.ValueMember = "id_Atachment"
        '
        'GENAtachmentsBindingSource
        '
        Me.GENAtachmentsBindingSource.DataMember = "GEN_Atachments"
        Me.GENAtachmentsBindingSource.DataSource = Me.GeneralDS
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Documentos (doble click para ver documento)"
        '
        'GEN_AtachmentsTableAdapter
        '
        Me.GEN_AtachmentsTableAdapter.ClearBeforeFill = True
        '
        'Grpdatos
        '
        Me.Grpdatos.Controls.Add(Me.Label7)
        Me.Grpdatos.Controls.Add(Me.ComboBox1)
        Me.Grpdatos.Controls.Add(Me.Button5)
        Me.Grpdatos.Controls.Add(Me.TxtUser)
        Me.Grpdatos.Controls.Add(Me.Label6)
        Me.Grpdatos.Controls.Add(Me.TxtFec)
        Me.Grpdatos.Controls.Add(Me.Label5)
        Me.Grpdatos.Controls.Add(Me.Txtfile)
        Me.Grpdatos.Controls.Add(Me.Label4)
        Me.Grpdatos.Controls.Add(Me.Txtnotas)
        Me.Grpdatos.Controls.Add(Me.Label3)
        Me.Grpdatos.Controls.Add(Me.TxtDesc)
        Me.Grpdatos.Controls.Add(Me.Label2)
        Me.Grpdatos.Enabled = False
        Me.Grpdatos.Location = New System.Drawing.Point(15, 291)
        Me.Grpdatos.Name = "Grpdatos"
        Me.Grpdatos.Size = New System.Drawing.Size(546, 256)
        Me.Grpdatos.TabIndex = 2
        Me.Grpdatos.TabStop = False
        Me.Grpdatos.Text = "Datos del Documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Tipo Documento"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GENAtachmentsBindingSource, "id_TipoAttch", True))
        Me.ComboBox1.DataSource = Me.GENAtachmentsTipoAttachBindingSource
        Me.ComboBox1.DisplayMember = "Descripcion"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(244, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "id_TipoAttch"
        '
        'GENAtachmentsTipoAttachBindingSource
        '
        Me.GENAtachmentsTipoAttachBindingSource.DataMember = "GEN_AtachmentsTipoAttach"
        Me.GENAtachmentsTipoAttachBindingSource.DataSource = Me.GeneralDS
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(465, 180)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Adjuntar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TxtUser
        '
        Me.TxtUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GENAtachmentsBindingSource, "Usuario", True))
        Me.TxtUser.Enabled = False
        Me.TxtUser.Location = New System.Drawing.Point(134, 222)
        Me.TxtUser.MaxLength = 100
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(119, 20)
        Me.TxtUser.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Usuario"
        '
        'TxtFec
        '
        Me.TxtFec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GENAtachmentsBindingSource, "Fecha", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.TxtFec.Enabled = False
        Me.TxtFec.Location = New System.Drawing.Point(9, 222)
        Me.TxtFec.MaxLength = 100
        Me.TxtFec.Name = "TxtFec"
        Me.TxtFec.Size = New System.Drawing.Size(119, 20)
        Me.TxtFec.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha"
        '
        'Txtfile
        '
        Me.Txtfile.AllowDrop = True
        Me.Txtfile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GENAtachmentsBindingSource, "Documento", True))
        Me.Txtfile.Location = New System.Drawing.Point(9, 183)
        Me.Txtfile.MaxLength = 100
        Me.Txtfile.Name = "Txtfile"
        Me.Txtfile.ReadOnly = True
        Me.Txtfile.Size = New System.Drawing.Size(450, 20)
        Me.Txtfile.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Archivo"
        '
        'Txtnotas
        '
        Me.Txtnotas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GENAtachmentsBindingSource, "NotasDoc", True))
        Me.Txtnotas.Location = New System.Drawing.Point(9, 82)
        Me.Txtnotas.MaxLength = 400
        Me.Txtnotas.Multiline = True
        Me.Txtnotas.Name = "Txtnotas"
        Me.Txtnotas.Size = New System.Drawing.Size(531, 82)
        Me.Txtnotas.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Notas"
        '
        'TxtDesc
        '
        Me.TxtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GENAtachmentsBindingSource, "Descripcion", True))
        Me.TxtDesc.Location = New System.Drawing.Point(259, 43)
        Me.TxtDesc.MaxLength = 100
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(281, 20)
        Me.TxtDesc.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripcion"
        '
        'ButtonDel
        '
        Me.ButtonDel.Enabled = False
        Me.ButtonDel.Location = New System.Drawing.Point(268, 553)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDel.TabIndex = 19
        Me.ButtonDel.Text = "Borrar"
        Me.ButtonDel.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Enabled = False
        Me.ButtonSave.Location = New System.Drawing.Point(187, 553)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 18
        Me.ButtonSave.Text = "Guardar"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Buttonmod
        '
        Me.Buttonmod.Enabled = False
        Me.Buttonmod.Location = New System.Drawing.Point(102, 553)
        Me.Buttonmod.Name = "Buttonmod"
        Me.Buttonmod.Size = New System.Drawing.Size(75, 23)
        Me.Buttonmod.TabIndex = 17
        Me.Buttonmod.Text = "Modificar"
        Me.Buttonmod.UseVisualStyleBackColor = True
        '
        'Buttonnew
        '
        Me.Buttonnew.Enabled = False
        Me.Buttonnew.Location = New System.Drawing.Point(18, 553)
        Me.Buttonnew.Name = "Buttonnew"
        Me.Buttonnew.Size = New System.Drawing.Size(75, 23)
        Me.Buttonnew.TabIndex = 16
        Me.Buttonnew.Text = "Nuevo"
        Me.Buttonnew.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Enabled = False
        Me.ButtonCancel.Location = New System.Drawing.Point(349, 553)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 20
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'GEN_AtachmentsTipoAttachTableAdapter
        '
        Me.GEN_AtachmentsTipoAttachTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(473, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Enviar Correo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmAtachments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 584)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonDel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Buttonmod)
        Me.Controls.Add(Me.Buttonnew)
        Me.Controls.Add(Me.Grpdatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LstDoctos)
        Me.Name = "FrmAtachments"
        Me.Text = "Atachments"
        CType(Me.GENAtachmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grpdatos.ResumeLayout(False)
        Me.Grpdatos.PerformLayout()
        CType(Me.GENAtachmentsTipoAttachBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstDoctos As ListBox
    Friend WithEvents GENAtachmentsBindingSource As BindingSource
    Friend WithEvents GeneralDS As GeneralDS
    Friend WithEvents Label1 As Label
    Friend WithEvents GEN_AtachmentsTableAdapter As GeneralDSTableAdapters.GEN_AtachmentsTableAdapter
    Friend WithEvents Grpdatos As GroupBox
    Friend WithEvents Txtnotas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtfile As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtFec As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonDel As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents Buttonmod As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Buttonnew As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GENAtachmentsTipoAttachBindingSource As BindingSource
    Friend WithEvents GEN_AtachmentsTipoAttachTableAdapter As GeneralDSTableAdapters.GEN_AtachmentsTipoAttachTableAdapter
    Friend WithEvents Button1 As Button
End Class
