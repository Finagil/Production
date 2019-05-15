<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSeguimientoCRED
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProductionDataSet = New Agil.ProductionDataSet()
        Me.ContClie1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContClie1TableAdapter = New Agil.ProductionDataSetTableAdapters.ContClie1TableAdapter()
        Me.Txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.ComboClientes = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.AnexosCREDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditoDS = New Agil.CreditoDS()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbAnexos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AnexosCREDTableAdapter = New Agil.CreditoDSTableAdapters.AnexosCREDTableAdapter()
        Me.CmbCompromisos = New System.Windows.Forms.ComboBox()
        Me.CREDSeguimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CRED_SeguimientoTableAdapter = New Agil.CreditoDSTableAdapters.CRED_SeguimientoTableAdapter()
        Me.DTPAlta = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTPcompromiso = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtResponsable = New System.Windows.Forms.TextBox()
        Me.TxtNotas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCompromiso = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtAnalista = New System.Windows.Forms.TextBox()
        Me.AuditoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuditoresDS = New Agil.SeguridadDS()
        Me.UsuariosFinagilTableAdapter = New Agil.SeguridadDSTableAdapters.UsuariosFinagilTableAdapter()
        Me.CmbAsignado = New System.Windows.Forms.ComboBox()
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonalDS1 = New Agil.SeguridadDS()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupAnalista = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CkFiltroCRED = New System.Windows.Forms.CheckBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GroupAuditor = New System.Windows.Forms.GroupBox()
        Me.BttLiberar = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.GroupPersonal = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ListDocs = New System.Windows.Forms.ListBox()
        Me.CREDSeguimientoDocumentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRED_SeguimientoDocumentosTableAdapter = New Agil.CreditoDSTableAdapters.CRED_SeguimientoDocumentosTableAdapter()
        Me.TxtEstatus = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TxtNotasDoc = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtNotasDev = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CmbAnexos2 = New System.Windows.Forms.ComboBox()
        Me.AnexosCREDBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditoDS1 = New Agil.CreditoDS()
        Me.BtnReea = New System.Windows.Forms.Button()
        Me.Btnnew2 = New System.Windows.Forms.Button()
        Me.CkFiltroCRED2 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.UsuariosFinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonalDS2 = New Agil.SeguridadDS()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BttCicloca = New System.Windows.Forms.Button()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosCREDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CREDSeguimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditoresDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupAnalista.SuspendLayout()
        Me.GroupAuditor.SuspendLayout()
        Me.GroupPersonal.SuspendLayout()
        CType(Me.CREDSeguimientoDocumentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosCREDBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosFinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContClie1BindingSource
        '
        Me.ContClie1BindingSource.DataMember = "ContClie1"
        Me.ContClie1BindingSource.DataSource = Me.ProductionDataSet
        '
        'ContClie1TableAdapter
        '
        Me.ContClie1TableAdapter.ClearBeforeFill = True
        '
        'Txtfiltro
        '
        Me.Txtfiltro.Location = New System.Drawing.Point(15, 28)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(424, 20)
        Me.Txtfiltro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Filtro"
        '
        'lblClientes
        '
        Me.lblClientes.AutoSize = True
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(16, 51)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(206, 13)
        Me.lblClientes.TabIndex = 61
        Me.lblClientes.Text = "Selecciona un Cliente de la siguiente Lista"
        '
        'ComboClientes
        '
        Me.ComboClientes.DataSource = Me.ContClie1BindingSource
        Me.ComboClientes.DisplayMember = "Descr"
        Me.ComboClientes.Location = New System.Drawing.Point(15, 69)
        Me.ComboClientes.MaxDropDownItems = 25
        Me.ComboClientes.Name = "ComboClientes"
        Me.ComboClientes.Size = New System.Drawing.Size(424, 21)
        Me.ComboClientes.TabIndex = 2
        Me.ComboClientes.ValueMember = "Cliente"
        '
        'Label25
        '
        Me.Label25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosCREDBindingSource, "Flcan", True))
        Me.Label25.Location = New System.Drawing.Point(196, 116)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(21, 13)
        Me.Label25.TabIndex = 68
        Me.Label25.Text = "."
        '
        'AnexosCREDBindingSource
        '
        Me.AnexosCREDBindingSource.DataMember = "AnexosCRED"
        Me.AnexosCREDBindingSource.DataSource = Me.CreditoDS
        '
        'CreditoDS
        '
        Me.CreditoDS.DataSetName = "CreditoDS"
        Me.CreditoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosCREDBindingSource, "TipoCredito", True))
        Me.Label3.Location = New System.Drawing.Point(223, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "."
        '
        'CmbAnexos
        '
        Me.CmbAnexos.DataSource = Me.AnexosCREDBindingSource
        Me.CmbAnexos.DisplayMember = "AnexoCon"
        Me.CmbAnexos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnexos.FormattingEnabled = True
        Me.CmbAnexos.Location = New System.Drawing.Point(15, 113)
        Me.CmbAnexos.Name = "CmbAnexos"
        Me.CmbAnexos.Size = New System.Drawing.Size(170, 21)
        Me.CmbAnexos.TabIndex = 3
        Me.CmbAnexos.ValueMember = "Anexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Anexos"
        '
        'AnexosCREDTableAdapter
        '
        Me.AnexosCREDTableAdapter.ClearBeforeFill = True
        '
        'CmbCompromisos
        '
        Me.CmbCompromisos.DataSource = Me.CREDSeguimientoBindingSource
        Me.CmbCompromisos.DisplayMember = "id_Seguimiento"
        Me.CmbCompromisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCompromisos.FormattingEnabled = True
        Me.CmbCompromisos.Location = New System.Drawing.Point(15, 155)
        Me.CmbCompromisos.Name = "CmbCompromisos"
        Me.CmbCompromisos.Size = New System.Drawing.Size(170, 21)
        Me.CmbCompromisos.TabIndex = 4
        Me.CmbCompromisos.ValueMember = "id_Seguimiento"
        '
        'CREDSeguimientoBindingSource
        '
        Me.CREDSeguimientoBindingSource.DataMember = "CRED_Seguimiento"
        Me.CREDSeguimientoBindingSource.DataSource = Me.CreditoDS
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Compromisos"
        '
        'CRED_SeguimientoTableAdapter
        '
        Me.CRED_SeguimientoTableAdapter.ClearBeforeFill = True
        '
        'DTPAlta
        '
        Me.DTPAlta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CREDSeguimientoBindingSource, "Fecha_Alta", True))
        Me.DTPAlta.Enabled = False
        Me.DTPAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPAlta.Location = New System.Drawing.Point(15, 251)
        Me.DTPAlta.Name = "DTPAlta"
        Me.DTPAlta.Size = New System.Drawing.Size(118, 20)
        Me.DTPAlta.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Fecha Alta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Fecha Compromiso"
        '
        'DTPcompromiso
        '
        Me.DTPcompromiso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CREDSeguimientoBindingSource, "Fecha_Compromiso", True))
        Me.DTPcompromiso.Enabled = False
        Me.DTPcompromiso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPcompromiso.Location = New System.Drawing.Point(139, 251)
        Me.DTPcompromiso.Name = "DTPcompromiso"
        Me.DTPcompromiso.Size = New System.Drawing.Size(118, 20)
        Me.DTPcompromiso.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(590, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Estatus"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Responsable"
        '
        'TxtResponsable
        '
        Me.TxtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtResponsable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "Responsable", True))
        Me.TxtResponsable.Location = New System.Drawing.Point(15, 295)
        Me.TxtResponsable.MaxLength = 50
        Me.TxtResponsable.Name = "TxtResponsable"
        Me.TxtResponsable.Size = New System.Drawing.Size(424, 20)
        Me.TxtResponsable.TabIndex = 8
        '
        'TxtNotas
        '
        Me.TxtNotas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "Notas", True))
        Me.TxtNotas.Location = New System.Drawing.Point(15, 372)
        Me.TxtNotas.MaxLength = 300
        Me.TxtNotas.Multiline = True
        Me.TxtNotas.Name = "TxtNotas"
        Me.TxtNotas.Size = New System.Drawing.Size(693, 82)
        Me.TxtNotas.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Notas"
        '
        'TxtCompromiso
        '
        Me.TxtCompromiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCompromiso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "Compromiso", True))
        Me.TxtCompromiso.Location = New System.Drawing.Point(15, 332)
        Me.TxtCompromiso.MaxLength = 50
        Me.TxtCompromiso.Name = "TxtCompromiso"
        Me.TxtCompromiso.Size = New System.Drawing.Size(424, 20)
        Me.TxtCompromiso.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 315)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Compromiso"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(297, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Analista"
        '
        'TxtAnalista
        '
        Me.TxtAnalista.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "Analista", True))
        Me.TxtAnalista.Location = New System.Drawing.Point(300, 201)
        Me.TxtAnalista.Name = "TxtAnalista"
        Me.TxtAnalista.ReadOnly = True
        Me.TxtAnalista.Size = New System.Drawing.Size(126, 20)
        Me.TxtAnalista.TabIndex = 86
        '
        'AuditoresBindingSource
        '
        Me.AuditoresBindingSource.DataMember = "UsuariosFinagil"
        Me.AuditoresBindingSource.DataSource = Me.AuditoresDS
        '
        'AuditoresDS
        '
        Me.AuditoresDS.DataSetName = "SeguridadDS"
        Me.AuditoresDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosFinagilTableAdapter
        '
        Me.UsuariosFinagilTableAdapter.ClearBeforeFill = True
        '
        'CmbAsignado
        '
        Me.CmbAsignado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CREDSeguimientoBindingSource, "Asignado", True))
        Me.CmbAsignado.DataSource = Me.PersonalBindingSource
        Me.CmbAsignado.DisplayMember = "NombreCompleto"
        Me.CmbAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAsignado.FormattingEnabled = True
        Me.CmbAsignado.Location = New System.Drawing.Point(15, 200)
        Me.CmbAsignado.Name = "CmbAsignado"
        Me.CmbAsignado.Size = New System.Drawing.Size(279, 21)
        Me.CmbAsignado.TabIndex = 6
        Me.CmbAsignado.ValueMember = "id_usuario"
        '
        'PersonalBindingSource
        '
        Me.PersonalBindingSource.DataMember = "UsuariosFinagil"
        Me.PersonalBindingSource.DataSource = Me.PersonalDS1
        '
        'PersonalDS1
        '
        Me.PersonalDS1.DataSetName = "SeguridadDS"
        Me.PersonalDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 185)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = "Asignado a:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "FechaSubsanar", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.TextBox1.Location = New System.Drawing.Point(263, 251)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(103, 20)
        Me.TextBox1.TabIndex = 92
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(260, 234)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "Solventado"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "FechaVobo", True))
        Me.TextBox2.Location = New System.Drawing.Point(372, 251)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(103, 20)
        Me.TextBox2.TabIndex = 94
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(369, 234)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 93
        Me.Label15.Text = "Vobo"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "FechaLiberacion", True))
        Me.TextBox3.Location = New System.Drawing.Point(481, 251)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(103, 20)
        Me.TextBox3.TabIndex = 96
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(478, 234)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 13)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "Liberado"
        '
        'GroupAnalista
        '
        Me.GroupAnalista.Controls.Add(Me.Button4)
        Me.GroupAnalista.Controls.Add(Me.Button2)
        Me.GroupAnalista.Controls.Add(Me.Button1)
        Me.GroupAnalista.Controls.Add(Me.CkFiltroCRED)
        Me.GroupAnalista.Controls.Add(Me.BtnCancel)
        Me.GroupAnalista.Controls.Add(Me.BtnNew)
        Me.GroupAnalista.Controls.Add(Me.BtnSave)
        Me.GroupAnalista.Location = New System.Drawing.Point(714, 486)
        Me.GroupAnalista.Name = "GroupAnalista"
        Me.GroupAnalista.Size = New System.Drawing.Size(688, 51)
        Me.GroupAnalista.TabIndex = 97
        Me.GroupAnalista.TabStop = False
        Me.GroupAnalista.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(598, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 23)
        Me.Button4.TabIndex = 101
        Me.Button4.Text = "Dev. Doc."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(512, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Cancela Seg."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(422, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Visto Bueno"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CkFiltroCRED
        '
        Me.CkFiltroCRED.AutoSize = True
        Me.CkFiltroCRED.Location = New System.Drawing.Point(6, 21)
        Me.CkFiltroCRED.Name = "CkFiltroCRED"
        Me.CkFiltroCRED.Size = New System.Drawing.Size(140, 17)
        Me.CkFiltroCRED.TabIndex = 100
        Me.CkFiltroCRED.Text = "Clientes con Pendientes"
        Me.CkFiltroCRED.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(332, 17)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(82, 23)
        Me.BtnCancel.TabIndex = 16
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(152, 17)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(82, 23)
        Me.BtnNew.TabIndex = 14
        Me.BtnNew.Text = "Nuevo"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(242, 17)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(82, 23)
        Me.BtnSave.TabIndex = 15
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'GroupAuditor
        '
        Me.GroupAuditor.Controls.Add(Me.BttLiberar)
        Me.GroupAuditor.Controls.Add(Me.BtnBack)
        Me.GroupAuditor.Location = New System.Drawing.Point(714, 372)
        Me.GroupAuditor.Name = "GroupAuditor"
        Me.GroupAuditor.Size = New System.Drawing.Size(688, 51)
        Me.GroupAuditor.TabIndex = 98
        Me.GroupAuditor.TabStop = False
        Me.GroupAuditor.Visible = False
        '
        'BttLiberar
        '
        Me.BttLiberar.Location = New System.Drawing.Point(388, 17)
        Me.BttLiberar.Name = "BttLiberar"
        Me.BttLiberar.Size = New System.Drawing.Size(75, 23)
        Me.BttLiberar.TabIndex = 87
        Me.BttLiberar.Text = "Liberar"
        Me.BttLiberar.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(226, 17)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 85
        Me.BtnBack.Text = "Regresar"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'GroupPersonal
        '
        Me.GroupPersonal.Controls.Add(Me.Button5)
        Me.GroupPersonal.Location = New System.Drawing.Point(714, 429)
        Me.GroupPersonal.Name = "GroupPersonal"
        Me.GroupPersonal.Size = New System.Drawing.Size(688, 51)
        Me.GroupPersonal.TabIndex = 98
        Me.GroupPersonal.TabStop = False
        Me.GroupPersonal.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(518, 17)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(164, 23)
        Me.Button5.TabIndex = 86
        Me.Button5.Text = "Solventar Compromiso (PDF)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 460)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 13)
        Me.Label17.TabIndex = 99
        Me.Label17.Text = "Documentos"
        '
        'ListDocs
        '
        Me.ListDocs.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CREDSeguimientoBindingSource, "id_Seguimiento", True))
        Me.ListDocs.DataSource = Me.CREDSeguimientoDocumentosBindingSource
        Me.ListDocs.DisplayMember = "Documento"
        Me.ListDocs.FormattingEnabled = True
        Me.ListDocs.Location = New System.Drawing.Point(15, 477)
        Me.ListDocs.Name = "ListDocs"
        Me.ListDocs.Size = New System.Drawing.Size(262, 69)
        Me.ListDocs.TabIndex = 11
        Me.ListDocs.ValueMember = "id_documento"
        '
        'CREDSeguimientoDocumentosBindingSource
        '
        Me.CREDSeguimientoDocumentosBindingSource.DataMember = "CRED_SeguimientoDocumentos"
        Me.CREDSeguimientoDocumentosBindingSource.DataSource = Me.CreditoDS
        '
        'CRED_SeguimientoDocumentosTableAdapter
        '
        Me.CRED_SeguimientoDocumentosTableAdapter.ClearBeforeFill = True
        '
        'TxtEstatus
        '
        Me.TxtEstatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "Estatus", True))
        Me.TxtEstatus.Location = New System.Drawing.Point(590, 251)
        Me.TxtEstatus.Name = "TxtEstatus"
        Me.TxtEstatus.ReadOnly = True
        Me.TxtEstatus.Size = New System.Drawing.Size(121, 20)
        Me.TxtEstatus.TabIndex = 101
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(202, 455)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 22)
        Me.Button3.TabIndex = 102
        Me.Button3.Text = "Abrir Doc."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TxtNotasDoc
        '
        Me.TxtNotasDoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoDocumentosBindingSource, "NotasDoc", True))
        Me.TxtNotasDoc.Location = New System.Drawing.Point(283, 477)
        Me.TxtNotasDoc.MaxLength = 300
        Me.TxtNotasDoc.Multiline = True
        Me.TxtNotasDoc.Name = "TxtNotasDoc"
        Me.TxtNotasDoc.ReadOnly = True
        Me.TxtNotasDoc.Size = New System.Drawing.Size(210, 70)
        Me.TxtNotasDoc.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(286, 460)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 13)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "Notas Documentos"
        '
        'TxtNotasDev
        '
        Me.TxtNotasDev.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoDocumentosBindingSource, "NotasDevolucion", True))
        Me.TxtNotasDev.Location = New System.Drawing.Point(499, 477)
        Me.TxtNotasDev.MaxLength = 300
        Me.TxtNotasDev.Multiline = True
        Me.TxtNotasDev.Name = "TxtNotasDev"
        Me.TxtNotasDev.ReadOnly = True
        Me.TxtNotasDev.Size = New System.Drawing.Size(209, 70)
        Me.TxtNotasDev.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(502, 460)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 13)
        Me.Label19.TabIndex = 106
        Me.Label19.Text = "Notas Devolución"
        '
        'CmbAnexos2
        '
        Me.CmbAnexos2.DataSource = Me.AnexosCREDBindingSource1
        Me.CmbAnexos2.DisplayMember = "AnexoCon"
        Me.CmbAnexos2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnexos2.Enabled = False
        Me.CmbAnexos2.FormattingEnabled = True
        Me.CmbAnexos2.Location = New System.Drawing.Point(585, 12)
        Me.CmbAnexos2.Name = "CmbAnexos2"
        Me.CmbAnexos2.Size = New System.Drawing.Size(123, 21)
        Me.CmbAnexos2.TabIndex = 108
        Me.CmbAnexos2.ValueMember = "Anexo"
        '
        'AnexosCREDBindingSource1
        '
        Me.AnexosCREDBindingSource1.DataMember = "AnexosCRED"
        Me.AnexosCREDBindingSource1.DataSource = Me.CreditoDS1
        '
        'CreditoDS1
        '
        Me.CreditoDS1.DataSetName = "CreditoDS"
        Me.CreditoDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnReea
        '
        Me.BtnReea.Enabled = False
        Me.BtnReea.Location = New System.Drawing.Point(633, 39)
        Me.BtnReea.Name = "BtnReea"
        Me.BtnReea.Size = New System.Drawing.Size(75, 23)
        Me.BtnReea.TabIndex = 109
        Me.BtnReea.Text = "Reasignar"
        Me.BtnReea.UseVisualStyleBackColor = True
        '
        'Btnnew2
        '
        Me.Btnnew2.Location = New System.Drawing.Point(15, 552)
        Me.Btnnew2.Name = "Btnnew2"
        Me.Btnnew2.Size = New System.Drawing.Size(82, 23)
        Me.Btnnew2.TabIndex = 102
        Me.Btnnew2.Text = "Nuevo"
        Me.Btnnew2.UseVisualStyleBackColor = True
        Me.Btnnew2.Visible = False
        '
        'CkFiltroCRED2
        '
        Me.CkFiltroCRED2.AutoSize = True
        Me.CkFiltroCRED2.Location = New System.Drawing.Point(103, 556)
        Me.CkFiltroCRED2.Name = "CkFiltroCRED2"
        Me.CkFiltroCRED2.Size = New System.Drawing.Size(140, 17)
        Me.CkFiltroCRED2.TabIndex = 102
        Me.CkFiltroCRED2.Text = "Clientes con Pendientes"
        Me.CkFiltroCRED2.UseVisualStyleBackColor = True
        Me.CkFiltroCRED2.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CREDSeguimientoBindingSource, "Vobo", True))
        Me.ComboBox1.DataSource = Me.UsuariosFinagilBindingSource
        Me.ComboBox1.DisplayMember = "NombreCompleto"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(191, 155)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(279, 21)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "id_usuario"
        '
        'UsuariosFinagilBindingSource
        '
        Me.UsuariosFinagilBindingSource.DataMember = "UsuariosFinagil"
        Me.UsuariosFinagilBindingSource.DataSource = Me.PersonalDS2
        '
        'PersonalDS2
        '
        Me.PersonalDS2.DataSetName = "SeguridadDS"
        Me.PersonalDS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(188, 140)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 13)
        Me.Label20.TabIndex = 111
        Me.Label20.Text = "Visto Bueno"
        '
        'BttCicloca
        '
        Me.BttCicloca.Enabled = False
        Me.BttCicloca.Location = New System.Drawing.Point(621, 153)
        Me.BttCicloca.Name = "BttCicloca"
        Me.BttCicloca.Size = New System.Drawing.Size(87, 23)
        Me.BttCicloca.TabIndex = 112
        Me.BttCicloca.Text = "Tarea Ciclica"
        Me.BttCicloca.UseVisualStyleBackColor = True
        '
        'FrmSeguimientoCRED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 607)
        Me.Controls.Add(Me.BttCicloca)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.CkFiltroCRED2)
        Me.Controls.Add(Me.Btnnew2)
        Me.Controls.Add(Me.BtnReea)
        Me.Controls.Add(Me.CmbAnexos2)
        Me.Controls.Add(Me.GroupPersonal)
        Me.Controls.Add(Me.GroupAuditor)
        Me.Controls.Add(Me.GroupAnalista)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TxtNotasDev)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtNotasDoc)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TxtEstatus)
        Me.Controls.Add(Me.ListDocs)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CmbAsignado)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtAnalista)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtCompromiso)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtNotas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtResponsable)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DTPcompromiso)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTPAlta)
        Me.Controls.Add(Me.CmbCompromisos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbAnexos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtfiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.ComboClientes)
        Me.Name = "FrmSeguimientoCRED"
        Me.Text = "Seguimiento de Pendientes"
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosCREDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CREDSeguimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditoresDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupAnalista.ResumeLayout(False)
        Me.GroupAnalista.PerformLayout()
        Me.GroupAuditor.ResumeLayout(False)
        Me.GroupPersonal.ResumeLayout(False)
        CType(Me.CREDSeguimientoDocumentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosCREDBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosFinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalDS2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents ContClie1BindingSource As BindingSource
    Friend WithEvents ContClie1TableAdapter As ProductionDataSetTableAdapters.ContClie1TableAdapter
    Friend WithEvents Txtfiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClientes As Label
    Friend WithEvents ComboClientes As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbAnexos As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AnexosCREDBindingSource As BindingSource
    Friend WithEvents CreditoDS As CreditoDS
    Friend WithEvents AnexosCREDTableAdapter As CreditoDSTableAdapters.AnexosCREDTableAdapter
    Friend WithEvents CmbCompromisos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CREDSeguimientoBindingSource As BindingSource
    Friend WithEvents CRED_SeguimientoTableAdapter As CreditoDSTableAdapters.CRED_SeguimientoTableAdapter
    Friend WithEvents DTPAlta As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DTPcompromiso As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtResponsable As TextBox
    Friend WithEvents TxtNotas As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtCompromiso As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtAnalista As TextBox
    Friend WithEvents AuditoresDS As SeguridadDS
    Friend WithEvents AuditoresBindingSource As BindingSource
    Friend WithEvents UsuariosFinagilTableAdapter As SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
    Friend WithEvents CmbAsignado As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PersonalDS1 As SeguridadDS
    Friend WithEvents PersonalBindingSource As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupAnalista As GroupBox
    Friend WithEvents GroupAuditor As GroupBox
    Friend WithEvents BttLiberar As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents GroupPersonal As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents CkFiltroCRED As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ListDocs As ListBox
    Friend WithEvents CREDSeguimientoDocumentosBindingSource As BindingSource
    Friend WithEvents CRED_SeguimientoDocumentosTableAdapter As CreditoDSTableAdapters.CRED_SeguimientoDocumentosTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtEstatus As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TxtNotasDoc As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtNotasDev As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents CmbAnexos2 As ComboBox
    Friend WithEvents BtnReea As Button
    Friend WithEvents CreditoDS1 As CreditoDS
    Friend WithEvents AnexosCREDBindingSource1 As BindingSource
    Friend WithEvents Btnnew2 As Button
    Friend WithEvents CkFiltroCRED2 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents UsuariosFinagilBindingSource As BindingSource
    Friend WithEvents PersonalDS2 As SeguridadDS
    Friend WithEvents BttCicloca As Button
End Class
