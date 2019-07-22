<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBloqPLD
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
        Me.CmbClientes = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLD_DS = New Agil.PLD_DS()
        Me.ClientesTableAdapter = New Agil.PLD_DSTableAdapters.ClientesTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbPLD = New System.Windows.Forms.ComboBox()
        Me.PLDBloqueoClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLD_Bloqueo_ClientesTableAdapter = New Agil.PLD_DSTableAdapters.PLD_Bloqueo_ClientesTableAdapter()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.GroupPLD = New System.Windows.Forms.GroupBox()
        Me.DPTvigencia = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CkVisita = New System.Windows.Forms.CheckBox()
        Me.LbDias = New System.Windows.Forms.Label()
        Me.BtnAutorizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbAnalista = New System.Windows.Forms.ComboBox()
        Me.UsuariosFinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguridadDS = New Agil.SeguridadDS()
        Me.TxtStatus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtComent = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CkSolicitud = New System.Windows.Forms.CheckBox()
        Me.CkFiel = New System.Windows.Forms.CheckBox()
        Me.CkRFC = New System.Windows.Forms.CheckBox()
        Me.CkListas = New System.Windows.Forms.CheckBox()
        Me.CkCurp = New System.Windows.Forms.CheckBox()
        Me.Ckdomicilio = New System.Windows.Forms.CheckBox()
        Me.CkActa = New System.Windows.Forms.CheckBox()
        Me.Ckpoderes = New System.Windows.Forms.CheckBox()
        Me.CkINE = New System.Windows.Forms.CheckBox()
        Me.TxtAnalistaCorreo = New System.Windows.Forms.TextBox()
        Me.BunAddAuto = New System.Windows.Forms.Button()
        Me.UsuariosFinagilTableAdapter = New Agil.SeguridadDSTableAdapters.UsuariosFinagilTableAdapter()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TxtPromoMail = New System.Windows.Forms.TextBox()
        Me.TxtmailSUB = New System.Windows.Forms.TextBox()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLD_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLDBloqueoClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPLD.SuspendLayout()
        CType(Me.UsuariosFinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'CmbClientes
        '
        Me.CmbClientes.DataSource = Me.ClientesBindingSource
        Me.CmbClientes.DisplayMember = "Descr"
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(16, 30)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(464, 21)
        Me.CmbClientes.TabIndex = 1
        Me.CmbClientes.ValueMember = "Cliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.PLD_DS
        '
        'PLD_DS
        '
        Me.PLD_DS.DataSetName = "PLD_DS"
        Me.PLD_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Autorizaciones PLD"
        '
        'CmbPLD
        '
        Me.CmbPLD.DataSource = Me.PLDBloqueoClientesBindingSource
        Me.CmbPLD.DisplayMember = "Fecha_Alta"
        Me.CmbPLD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPLD.FormattingEnabled = True
        Me.CmbPLD.Location = New System.Drawing.Point(16, 117)
        Me.CmbPLD.Name = "CmbPLD"
        Me.CmbPLD.Size = New System.Drawing.Size(175, 21)
        Me.CmbPLD.TabIndex = 3
        Me.CmbPLD.ValueMember = "id_Bloqueo"
        '
        'PLDBloqueoClientesBindingSource
        '
        Me.PLDBloqueoClientesBindingSource.DataMember = "PLD_Bloqueo_Clientes"
        Me.PLDBloqueoClientesBindingSource.DataSource = Me.PLD_DS
        '
        'PLD_Bloqueo_ClientesTableAdapter
        '
        Me.PLD_Bloqueo_ClientesTableAdapter.ClearBeforeFill = True
        '
        'TxtTipo
        '
        Me.TxtTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Tipo", True))
        Me.TxtTipo.Location = New System.Drawing.Point(485, 30)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.Size = New System.Drawing.Size(19, 20)
        Me.TxtTipo.TabIndex = 100
        '
        'GroupPLD
        '
        Me.GroupPLD.Controls.Add(Me.DPTvigencia)
        Me.GroupPLD.Controls.Add(Me.Label10)
        Me.GroupPLD.Controls.Add(Me.Button2)
        Me.GroupPLD.Controls.Add(Me.CkVisita)
        Me.GroupPLD.Controls.Add(Me.LbDias)
        Me.GroupPLD.Controls.Add(Me.BtnAutorizar)
        Me.GroupPLD.Controls.Add(Me.Button1)
        Me.GroupPLD.Controls.Add(Me.Label8)
        Me.GroupPLD.Controls.Add(Me.CmbAnalista)
        Me.GroupPLD.Controls.Add(Me.TxtStatus)
        Me.GroupPLD.Controls.Add(Me.Label7)
        Me.GroupPLD.Controls.Add(Me.TextBox3)
        Me.GroupPLD.Controls.Add(Me.TextBox2)
        Me.GroupPLD.Controls.Add(Me.TextBox1)
        Me.GroupPLD.Controls.Add(Me.Label6)
        Me.GroupPLD.Controls.Add(Me.TxtComent)
        Me.GroupPLD.Controls.Add(Me.Label5)
        Me.GroupPLD.Controls.Add(Me.Label4)
        Me.GroupPLD.Controls.Add(Me.Label3)
        Me.GroupPLD.Controls.Add(Me.CkSolicitud)
        Me.GroupPLD.Controls.Add(Me.CkFiel)
        Me.GroupPLD.Controls.Add(Me.CkRFC)
        Me.GroupPLD.Controls.Add(Me.CkListas)
        Me.GroupPLD.Controls.Add(Me.CkCurp)
        Me.GroupPLD.Controls.Add(Me.Ckdomicilio)
        Me.GroupPLD.Controls.Add(Me.CkActa)
        Me.GroupPLD.Controls.Add(Me.Ckpoderes)
        Me.GroupPLD.Controls.Add(Me.CkINE)
        Me.GroupPLD.Controls.Add(Me.TxtAnalistaCorreo)
        Me.GroupPLD.Location = New System.Drawing.Point(16, 145)
        Me.GroupPLD.Name = "GroupPLD"
        Me.GroupPLD.Size = New System.Drawing.Size(488, 340)
        Me.GroupPLD.TabIndex = 5
        Me.GroupPLD.TabStop = False
        Me.GroupPLD.Text = "Documentos PLD"
        '
        'DPTvigencia
        '
        Me.DPTvigencia.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PLDBloqueoClientesBindingSource, "Vigencia", True))
        Me.DPTvigencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPTvigencia.Location = New System.Drawing.Point(345, 118)
        Me.DPTvigencia.Name = "DPTvigencia"
        Me.DPTvigencia.Size = New System.Drawing.Size(134, 20)
        Me.DPTvigencia.TabIndex = 103
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(286, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Vigencia"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(193, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Pedir Expediente"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CkVisita
        '
        Me.CkVisita.AutoSize = True
        Me.CkVisita.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PLDBloqueoClientesBindingSource, "Visita", True))
        Me.CkVisita.Location = New System.Drawing.Point(44, 188)
        Me.CkVisita.Name = "CkVisita"
        Me.CkVisita.Size = New System.Drawing.Size(110, 17)
        Me.CkVisita.TabIndex = 14
        Me.CkVisita.Text = "Visita Domiciliaria "
        Me.CkVisita.UseVisualStyleBackColor = True
        '
        'LbDias
        '
        Me.LbDias.AutoSize = True
        Me.LbDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDias.Location = New System.Drawing.Point(294, 229)
        Me.LbDias.Name = "LbDias"
        Me.LbDias.Size = New System.Drawing.Size(170, 13)
        Me.LbDias.TabIndex = 21
        Me.LbDias.Text = "Quedan 30 dias de vigencia."
        '
        'BtnAutorizar
        '
        Me.BtnAutorizar.Location = New System.Drawing.Point(384, 197)
        Me.BtnAutorizar.Name = "BtnAutorizar"
        Me.BtnAutorizar.Size = New System.Drawing.Size(95, 23)
        Me.BtnAutorizar.TabIndex = 19
        Me.BtnAutorizar.Text = "Autorizar"
        Me.BtnAutorizar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(384, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Guardar Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(168, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Analista"
        '
        'CmbAnalista
        '
        Me.CmbAnalista.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PLDBloqueoClientesBindingSource, "Analista", True))
        Me.CmbAnalista.DataSource = Me.UsuariosFinagilBindingSource
        Me.CmbAnalista.DisplayMember = "NombreCompleto"
        Me.CmbAnalista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnalista.FormattingEnabled = True
        Me.CmbAnalista.Location = New System.Drawing.Point(218, 17)
        Me.CmbAnalista.Name = "CmbAnalista"
        Me.CmbAnalista.Size = New System.Drawing.Size(261, 21)
        Me.CmbAnalista.TabIndex = 16
        Me.CmbAnalista.ValueMember = "id_usuario"
        '
        'UsuariosFinagilBindingSource
        '
        Me.UsuariosFinagilBindingSource.DataMember = "UsuariosFinagil"
        Me.UsuariosFinagilBindingSource.DataSource = Me.SeguridadDS
        '
        'SeguridadDS
        '
        Me.SeguridadDS.DataSetName = "SeguridadDS"
        Me.SeguridadDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtStatus
        '
        Me.TxtStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLDBloqueoClientesBindingSource, "Status", True))
        Me.TxtStatus.Location = New System.Drawing.Point(345, 142)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.ReadOnly = True
        Me.TxtStatus.Size = New System.Drawing.Size(134, 20)
        Me.TxtStatus.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(297, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Estatus"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLDBloqueoClientesBindingSource, "FechaAutorizacion", True))
        Me.TextBox3.Location = New System.Drawing.Point(345, 94)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(134, 20)
        Me.TextBox3.TabIndex = 100
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLDBloqueoClientesBindingSource, "Fecha_Modificacion", True))
        Me.TextBox2.Location = New System.Drawing.Point(345, 70)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(134, 20)
        Me.TextBox2.TabIndex = 100
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLDBloqueoClientesBindingSource, "Fecha_Alta", True))
        Me.TextBox1.Location = New System.Drawing.Point(345, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(134, 20)
        Me.TextBox1.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Comentarios"
        '
        'TxtComent
        '
        Me.TxtComent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLDBloqueoClientesBindingSource, "Comentarios", True))
        Me.TxtComent.Location = New System.Drawing.Point(14, 247)
        Me.TxtComent.MaxLength = 500
        Me.TxtComent.Multiline = True
        Me.TxtComent.Name = "TxtComent"
        Me.TxtComent.Size = New System.Drawing.Size(465, 81)
        Me.TxtComent.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha Autorización"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha Ultima Modificación"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha de Alta"
        '
        'CkSolicitud
        '
        Me.CkSolicitud.AutoSize = True
        Me.CkSolicitud.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PLDBloqueoClientesBindingSource, "Solicitud", True))
        Me.CkSolicitud.Location = New System.Drawing.Point(44, 165)
        Me.CkSolicitud.Name = "CkSolicitud"
        Me.CkSolicitud.Size = New System.Drawing.Size(66, 17)
        Me.CkSolicitud.TabIndex = 13
        Me.CkSolicitud.Text = "Solicitud"
        Me.CkSolicitud.UseVisualStyleBackColor = True
        '
        'CkFiel
        '
        Me.CkFiel.AutoSize = True
        Me.CkFiel.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PLDBloqueoClientesBindingSource, "Fiel", True))
        Me.CkFiel.Location = New System.Drawing.Point(44, 142)
        Me.CkFiel.Name = "CkFiel"
        Me.CkFiel.Size = New System.Drawing.Size(42, 17)
        Me.CkFiel.TabIndex = 12
        Me.CkFiel.Text = "Fiel"
        Me.CkFiel.UseVisualStyleBackColor = True
        '
        'CkRFC
        '
        Me.CkRFC.AutoSize = True
        Me.CkRFC.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PLDBloqueoClientesBindingSource, "RFC", True))
        Me.CkRFC.Location = New System.Drawing.Point(44, 119)
        Me.CkRFC.Name = "CkRFC"
        Me.CkRFC.Size = New System.Drawing.Size(47, 17)
        Me.CkRFC.TabIndex = 11
        Me.CkRFC.Text = "RFC"
        Me.CkRFC.UseVisualStyleBackColor = True
        '
        'CkListas
        '
        Me.CkListas.AutoSize = True
        Me.CkListas.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PLDBloqueoClientesBindingSource, "Listas", True))
        Me.CkListas.Location = New System.Drawing.Point(44, 96)
        Me.CkListas.Name = "CkListas"
        Me.CkListas.Size = New System.Drawing.Size(53, 17)
        Me.CkListas.TabIndex = 10
        Me.CkListas.Text = "Listas"
        Me.CkListas.UseVisualStyleBackColor = True
        '
        'CkCurp
        '
        Me.CkCurp.AutoSize = True
        Me.CkCurp.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PLDBloqueoClientesBindingSource, "Curp", True))
        Me.CkCurp.Location = New System.Drawing.Point(14, 42)
        Me.CkCurp.Name = "CkCurp"
        Me.CkCurp.Size = New System.Drawing.Size(48, 17)
        Me.CkCurp.TabIndex = 6
        Me.CkCurp.Text = "Curp"
        Me.CkCurp.UseVisualStyleBackColor = True
        '
        'Ckdomicilio
        '
        Me.Ckdomicilio.AutoSize = True
        Me.Ckdomicilio.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PLDBloqueoClientesBindingSource, "Domicilio", True))
        Me.Ckdomicilio.Location = New System.Drawing.Point(44, 70)
        Me.Ckdomicilio.Name = "Ckdomicilio"
        Me.Ckdomicilio.Size = New System.Drawing.Size(68, 17)
        Me.Ckdomicilio.TabIndex = 9
        Me.Ckdomicilio.Text = "Domicilio"
        Me.Ckdomicilio.UseVisualStyleBackColor = True
        '
        'CkActa
        '
        Me.CkActa.AutoSize = True
        Me.CkActa.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PLDBloqueoClientesBindingSource, "Acta_Contitutiva", True))
        Me.CkActa.Location = New System.Drawing.Point(64, 42)
        Me.CkActa.Name = "CkActa"
        Me.CkActa.Size = New System.Drawing.Size(106, 17)
        Me.CkActa.TabIndex = 8
        Me.CkActa.Text = "Acta Constitutiva"
        Me.CkActa.UseVisualStyleBackColor = True
        '
        'Ckpoderes
        '
        Me.Ckpoderes.AutoSize = True
        Me.Ckpoderes.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PLDBloqueoClientesBindingSource, "Poderes", True))
        Me.Ckpoderes.Location = New System.Drawing.Point(64, 19)
        Me.Ckpoderes.Name = "Ckpoderes"
        Me.Ckpoderes.Size = New System.Drawing.Size(65, 17)
        Me.Ckpoderes.TabIndex = 7
        Me.Ckpoderes.Text = "Poderes"
        Me.Ckpoderes.UseVisualStyleBackColor = True
        '
        'CkINE
        '
        Me.CkINE.AutoSize = True
        Me.CkINE.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PLDBloqueoClientesBindingSource, "INE_Cliente", True))
        Me.CkINE.Location = New System.Drawing.Point(14, 19)
        Me.CkINE.Name = "CkINE"
        Me.CkINE.Size = New System.Drawing.Size(44, 17)
        Me.CkINE.TabIndex = 5
        Me.CkINE.Text = "INE"
        Me.CkINE.UseVisualStyleBackColor = True
        '
        'TxtAnalistaCorreo
        '
        Me.TxtAnalistaCorreo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosFinagilBindingSource, "correo", True))
        Me.TxtAnalistaCorreo.Location = New System.Drawing.Point(433, 17)
        Me.TxtAnalistaCorreo.Name = "TxtAnalistaCorreo"
        Me.TxtAnalistaCorreo.ReadOnly = True
        Me.TxtAnalistaCorreo.Size = New System.Drawing.Size(19, 20)
        Me.TxtAnalistaCorreo.TabIndex = 101
        '
        'BunAddAuto
        '
        Me.BunAddAuto.Location = New System.Drawing.Point(214, 117)
        Me.BunAddAuto.Name = "BunAddAuto"
        Me.BunAddAuto.Size = New System.Drawing.Size(136, 23)
        Me.BunAddAuto.TabIndex = 4
        Me.BunAddAuto.Text = "Agregar Autorización"
        Me.BunAddAuto.UseVisualStyleBackColor = True
        '
        'UsuariosFinagilTableAdapter
        '
        Me.UsuariosFinagilTableAdapter.ClearBeforeFill = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Promotor"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "DescPromotor", True))
        Me.TextBox4.Location = New System.Drawing.Point(16, 70)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(464, 20)
        Me.TextBox4.TabIndex = 102
        '
        'TxtPromoMail
        '
        Me.TxtPromoMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Correo", True))
        Me.TxtPromoMail.Location = New System.Drawing.Point(461, 70)
        Me.TxtPromoMail.Name = "TxtPromoMail"
        Me.TxtPromoMail.ReadOnly = True
        Me.TxtPromoMail.Size = New System.Drawing.Size(19, 20)
        Me.TxtPromoMail.TabIndex = 103
        '
        'TxtmailSUB
        '
        Me.TxtmailSUB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Sub_Correo", True))
        Me.TxtmailSUB.Location = New System.Drawing.Point(441, 70)
        Me.TxtmailSUB.Name = "TxtmailSUB"
        Me.TxtmailSUB.ReadOnly = True
        Me.TxtmailSUB.Size = New System.Drawing.Size(19, 20)
        Me.TxtmailSUB.TabIndex = 104
        '
        'FrmBloqPLD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 491)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TxtmailSUB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BunAddAuto)
        Me.Controls.Add(Me.GroupPLD)
        Me.Controls.Add(Me.TxtTipo)
        Me.Controls.Add(Me.CmbPLD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbClientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPromoMail)
        Me.Name = "FrmBloqPLD"
        Me.Text = "Bloqueo de Clientes PLD"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLD_DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLDBloqueoClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPLD.ResumeLayout(False)
        Me.GroupPLD.PerformLayout()
        CType(Me.UsuariosFinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CmbClientes As ComboBox
    Friend WithEvents PLD_DS As PLD_DS
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As PLD_DSTableAdapters.ClientesTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbPLD As ComboBox
    Friend WithEvents PLDBloqueoClientesBindingSource As BindingSource
    Friend WithEvents PLD_Bloqueo_ClientesTableAdapter As PLD_DSTableAdapters.PLD_Bloqueo_ClientesTableAdapter
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents GroupPLD As GroupBox
    Friend WithEvents Ckpoderes As CheckBox
    Friend WithEvents CkINE As CheckBox
    Friend WithEvents CkFiel As CheckBox
    Friend WithEvents CkRFC As CheckBox
    Friend WithEvents CkListas As CheckBox
    Friend WithEvents CkCurp As CheckBox
    Friend WithEvents Ckdomicilio As CheckBox
    Friend WithEvents CkActa As CheckBox
    Friend WithEvents CkSolicitud As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtComent As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TxtStatus As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BunAddAuto As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents CmbAnalista As ComboBox
    Friend WithEvents SeguridadDS As SeguridadDS
    Friend WithEvents UsuariosFinagilBindingSource As BindingSource
    Friend WithEvents UsuariosFinagilTableAdapter As SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
    Friend WithEvents BtnAutorizar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LbDias As Label
    Friend WithEvents CkVisita As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TxtPromoMail As TextBox
    Friend WithEvents TxtAnalistaCorreo As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtmailSUB As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DPTvigencia As DateTimePicker
End Class
