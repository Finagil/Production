<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatosLegales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtEscritura = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS1 = New Agil.PromocionDS()
        Me.TxtFechaEscri = New System.Windows.Forms.TextBox()
        Me.TxtFE = New System.Windows.Forms.TextBox()
        Me.TxtNoNotario = New System.Windows.Forms.TextBox()
        Me.TxtNotarioDE = New System.Windows.Forms.TextBox()
        Me.TxtRegPublic = New System.Windows.Forms.TextBox()
        Me.TxtFolioMerc = New System.Windows.Forms.TextBox()
        Me.TxtFechaFol = New System.Windows.Forms.TextBox()
        Me.TxtRepre = New System.Windows.Forms.TextBox()
        Me.BttSafe = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.DatosLegalesTableAdapter = New Agil.PromocionDSTableAdapters.DatosLegalesTableAdapter()
        Me.TxtAtte = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbReprese = New System.Windows.Forms.ComboBox()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS2 = New Agil.PromocionDS()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. Escritura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de Escritura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Licenciado (Fe)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "No. Norario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Notario de:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Registo Público No."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Folio Mercantil"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 363)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Fecha Folio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 404)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(318, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Representante (o nombre del cliente en caso de acta constitutiva)"
        '
        'TxtEscritura
        '
        Me.TxtEscritura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "NoEscritura", True))
        Me.TxtEscritura.Location = New System.Drawing.Point(15, 92)
        Me.TxtEscritura.MaxLength = 10
        Me.TxtEscritura.Name = "TxtEscritura"
        Me.TxtEscritura.Size = New System.Drawing.Size(150, 20)
        Me.TxtEscritura.TabIndex = 11
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "DatosLegales"
        Me.BindingSource1.DataSource = Me.PromocionDS1
        '
        'PromocionDS1
        '
        Me.PromocionDS1.DataSetName = "PromocionDS"
        Me.PromocionDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtFechaEscri
        '
        Me.TxtFechaEscri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "EscrituraFecha", True))
        Me.TxtFechaEscri.Location = New System.Drawing.Point(16, 134)
        Me.TxtFechaEscri.MaxLength = 10
        Me.TxtFechaEscri.Name = "TxtFechaEscri"
        Me.TxtFechaEscri.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaEscri.TabIndex = 12
        '
        'TxtFE
        '
        Me.TxtFE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "FeLicenciado", True))
        Me.TxtFE.Location = New System.Drawing.Point(16, 175)
        Me.TxtFE.MaxLength = 60
        Me.TxtFE.Name = "TxtFE"
        Me.TxtFE.Size = New System.Drawing.Size(300, 20)
        Me.TxtFE.TabIndex = 13
        '
        'TxtNoNotario
        '
        Me.TxtNoNotario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "NumeroNotario", True))
        Me.TxtNoNotario.Location = New System.Drawing.Point(16, 216)
        Me.TxtNoNotario.MaxLength = 10
        Me.TxtNoNotario.Name = "TxtNoNotario"
        Me.TxtNoNotario.Size = New System.Drawing.Size(150, 20)
        Me.TxtNoNotario.TabIndex = 14
        '
        'TxtNotarioDE
        '
        Me.TxtNotarioDE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "NotarioDe", True))
        Me.TxtNotarioDE.Location = New System.Drawing.Point(16, 257)
        Me.TxtNotarioDE.MaxLength = 60
        Me.TxtNotarioDE.Name = "TxtNotarioDE"
        Me.TxtNotarioDE.Size = New System.Drawing.Size(300, 20)
        Me.TxtNotarioDE.TabIndex = 15
        '
        'TxtRegPublic
        '
        Me.TxtRegPublic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "RegistoPublicoNo", True))
        Me.TxtRegPublic.Location = New System.Drawing.Point(15, 298)
        Me.TxtRegPublic.MaxLength = 10
        Me.TxtRegPublic.Name = "TxtRegPublic"
        Me.TxtRegPublic.Size = New System.Drawing.Size(150, 20)
        Me.TxtRegPublic.TabIndex = 16
        '
        'TxtFolioMerc
        '
        Me.TxtFolioMerc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "FolioMercantil", True))
        Me.TxtFolioMerc.Location = New System.Drawing.Point(16, 339)
        Me.TxtFolioMerc.MaxLength = 10
        Me.TxtFolioMerc.Name = "TxtFolioMerc"
        Me.TxtFolioMerc.Size = New System.Drawing.Size(150, 20)
        Me.TxtFolioMerc.TabIndex = 17
        '
        'TxtFechaFol
        '
        Me.TxtFechaFol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "FechaFolio", True))
        Me.TxtFechaFol.Location = New System.Drawing.Point(16, 380)
        Me.TxtFechaFol.MaxLength = 10
        Me.TxtFechaFol.Name = "TxtFechaFol"
        Me.TxtFechaFol.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaFol.TabIndex = 18
        '
        'TxtRepre
        '
        Me.TxtRepre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Representante", True))
        Me.TxtRepre.Location = New System.Drawing.Point(16, 421)
        Me.TxtRepre.MaxLength = 100
        Me.TxtRepre.Name = "TxtRepre"
        Me.TxtRepre.Size = New System.Drawing.Size(300, 20)
        Me.TxtRepre.TabIndex = 19
        '
        'BttSafe
        '
        Me.BttSafe.Location = New System.Drawing.Point(625, 450)
        Me.BttSafe.Name = "BttSafe"
        Me.BttSafe.Size = New System.Drawing.Size(75, 23)
        Me.BttSafe.TabIndex = 20
        Me.BttSafe.Text = "Guardar"
        Me.BttSafe.UseVisualStyleBackColor = True
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(338, 93)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(362, 102)
        Me.TextBox10.TabIndex = 22
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Location = New System.Drawing.Point(338, 201)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(362, 129)
        Me.TextBox11.TabIndex = 23
        '
        'DatosLegalesTableAdapter
        '
        Me.DatosLegalesTableAdapter.ClearBeforeFill = True
        '
        'TxtAtte
        '
        Me.TxtAtte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "AtencionDe", True))
        Me.TxtAtte.Location = New System.Drawing.Point(15, 461)
        Me.TxtAtte.MaxLength = 100
        Me.TxtAtte.Name = "TxtAtte"
        Me.TxtAtte.Size = New System.Drawing.Size(300, 20)
        Me.TxtAtte.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 444)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Atención de:"
        '
        'CmbReprese
        '
        Me.CmbReprese.DataSource = Me.BindingSource2
        Me.CmbReprese.DisplayMember = "Representante"
        Me.CmbReprese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbReprese.FormattingEnabled = True
        Me.CmbReprese.Location = New System.Drawing.Point(12, 12)
        Me.CmbReprese.Name = "CmbReprese"
        Me.CmbReprese.Size = New System.Drawing.Size(329, 21)
        Me.CmbReprese.TabIndex = 10
        Me.CmbReprese.ValueMember = "Id_Legales"
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "DatosLegales"
        Me.BindingSource2.DataSource = Me.PromocionDS2
        '
        'PromocionDS2
        '
        Me.PromocionDS2.DataSetName = "PromocionDS"
        Me.PromocionDS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(347, 11)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(139, 22)
        Me.BtnAdd.TabIndex = 27
        Me.BtnAdd.Text = "Agregar Representante"
        Me.BtnAdd.UseVisualStyleBackColor = True
        Me.BtnAdd.Visible = False
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(561, 12)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(139, 22)
        Me.BtnDelete.TabIndex = 28
        Me.BtnDelete.Text = "Elimina Representante"
        Me.BtnDelete.UseVisualStyleBackColor = True
        Me.BtnDelete.Visible = False
        '
        'FrmDatosLegales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 488)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.CmbReprese)
        Me.Controls.Add(Me.TxtAtte)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.BttSafe)
        Me.Controls.Add(Me.TxtRepre)
        Me.Controls.Add(Me.TxtFechaFol)
        Me.Controls.Add(Me.TxtFolioMerc)
        Me.Controls.Add(Me.TxtRegPublic)
        Me.Controls.Add(Me.TxtNotarioDE)
        Me.Controls.Add(Me.TxtNoNotario)
        Me.Controls.Add(Me.TxtFE)
        Me.Controls.Add(Me.TxtFechaEscri)
        Me.Controls.Add(Me.TxtEscritura)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDatosLegales"
        Me.Text = "Datos Legales"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtEscritura As TextBox
    Friend WithEvents TxtFechaEscri As TextBox
    Friend WithEvents TxtFE As TextBox
    Friend WithEvents TxtNoNotario As TextBox
    Friend WithEvents TxtNotarioDE As TextBox
    Friend WithEvents TxtRegPublic As TextBox
    Friend WithEvents TxtFolioMerc As TextBox
    Friend WithEvents TxtFechaFol As TextBox
    Friend WithEvents TxtRepre As TextBox
    Friend WithEvents BttSafe As Button
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents PromocionDS1 As PromocionDS
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DatosLegalesTableAdapter As PromocionDSTableAdapters.DatosLegalesTableAdapter
    Friend WithEvents TxtAtte As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CmbReprese As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents PromocionDS2 As Agil.PromocionDS
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
End Class
