<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cambio_condiciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Bitacora_anexosDS = New Agil.MesaControlDS()
        Me.Vw_AnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_AnexosTableAdapter = New Agil.MesaControlDSTableAdapters.Vw_AnexosTableAdapter()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Agil.MesaControlDSTableAdapters.ClientesTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.date_cambio = New System.Windows.Forms.DateTimePicker()
        Me.cambio_condicionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cambios_condicionesDS = New Agil.MesaControlDS()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.date_autorizacion = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbanexos = New System.Windows.Forms.ComboBox()
        Me.txt_existe = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ch_otros = New System.Windows.Forms.CheckBox()
        Me.ch_plazo = New System.Windows.Forms.CheckBox()
        Me.ch_pago = New System.Windows.Forms.CheckBox()
        Me.ch_registro = New System.Windows.Forms.CheckBox()
        Me.ch_recurso = New System.Windows.Forms.CheckBox()
        Me.ch_linea = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_pago_condicion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_recurso_condicion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_registro_condicion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_plazo_condicion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_linea_condicion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_pago_cambio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_recurso_cambio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_registro_cambio = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_plazo_cambio = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_linea_cambio = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_otros = New System.Windows.Forms.TextBox()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.bt_imprimir = New System.Windows.Forms.Button()
        Me.CONT_cambio_condicionesTableAdapter = New Agil.MesaControlDSTableAdapters.Cambio_condicionesTableAdapter()
        Me.txt_anexo_existe = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        CType(Me.Bitacora_anexosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_AnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cambio_condicionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cambios_condicionesDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bitacora_anexosDS
        '
        Me.Bitacora_anexosDS.DataSetName = "Bitacora_anexosDS"
        Me.Bitacora_anexosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_AnexosBindingSource
        '
        Me.Vw_AnexosBindingSource.DataMember = "Vw_Anexos"
        Me.Vw_AnexosBindingSource.DataSource = Me.Bitacora_anexosDS
        '
        'Vw_AnexosTableAdapter
        '
        Me.Vw_AnexosTableAdapter.ClearBeforeFill = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.Bitacora_anexosDS
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Descr", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(114, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(573, 20)
        Me.TextBox1.TabIndex = 150
        '
        'date_cambio
        '
        Me.date_cambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "fe_cambios", True))
        Me.date_cambio.Enabled = False
        Me.date_cambio.Location = New System.Drawing.Point(487, 68)
        Me.date_cambio.Name = "date_cambio"
        Me.date_cambio.Size = New System.Drawing.Size(200, 20)
        Me.date_cambio.TabIndex = 149
        '
        'cambio_condicionesBindingSource
        '
        Me.cambio_condicionesBindingSource.DataMember = "cambio_condiciones"
        Me.cambio_condicionesBindingSource.DataSource = Me.Cambios_condicionesDS
        '
        'Cambios_condicionesDS
        '
        Me.Cambios_condicionesDS.DataSetName = "cambios_condicionesDS"
        Me.Cambios_condicionesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(360, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "Fe. Cambio Condiciones"
        '
        'date_autorizacion
        '
        Me.date_autorizacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "fe_autorizacion", True))
        Me.date_autorizacion.Enabled = False
        Me.date_autorizacion.Location = New System.Drawing.Point(144, 69)
        Me.date_autorizacion.Name = "date_autorizacion"
        Me.date_autorizacion.Size = New System.Drawing.Size(200, 20)
        Me.date_autorizacion.TabIndex = 147
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "Fe. Autorización Crédito"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Tipo de Contrato"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "Nombre del Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Contrato"
        '
        'cbanexos
        '
        Me.cbanexos.DataSource = Me.Vw_AnexosBindingSource
        Me.cbanexos.DisplayMember = "AnexoCon"
        Me.cbanexos.Enabled = False
        Me.cbanexos.FormattingEnabled = True
        Me.cbanexos.Location = New System.Drawing.Point(64, 36)
        Me.cbanexos.Name = "cbanexos"
        Me.cbanexos.Size = New System.Drawing.Size(116, 21)
        Me.cbanexos.TabIndex = 141
        Me.cbanexos.ValueMember = "Anexo"
        '
        'txt_existe
        '
        Me.txt_existe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_AnexosBindingSource, "TipoCredito", True))
        Me.txt_existe.Enabled = False
        Me.txt_existe.Location = New System.Drawing.Point(277, 37)
        Me.txt_existe.Name = "txt_existe"
        Me.txt_existe.Size = New System.Drawing.Size(176, 20)
        Me.txt_existe.TabIndex = 153
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ch_otros)
        Me.GroupBox1.Controls.Add(Me.ch_plazo)
        Me.GroupBox1.Controls.Add(Me.ch_pago)
        Me.GroupBox1.Controls.Add(Me.ch_registro)
        Me.GroupBox1.Controls.Add(Me.ch_recurso)
        Me.GroupBox1.Controls.Add(Me.ch_linea)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 77)
        Me.GroupBox1.TabIndex = 154
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cambios Autorizados"
        '
        'ch_otros
        '
        Me.ch_otros.AutoSize = True
        Me.ch_otros.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.cambio_condicionesBindingSource, "otros", True))
        Me.ch_otros.Location = New System.Drawing.Point(508, 54)
        Me.ch_otros.Name = "ch_otros"
        Me.ch_otros.Size = New System.Drawing.Size(51, 17)
        Me.ch_otros.TabIndex = 5
        Me.ch_otros.Text = "Otros"
        Me.ch_otros.UseVisualStyleBackColor = True
        '
        'ch_plazo
        '
        Me.ch_plazo.AutoSize = True
        Me.ch_plazo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.cambio_condicionesBindingSource, "plazo", True))
        Me.ch_plazo.Location = New System.Drawing.Point(277, 54)
        Me.ch_plazo.Name = "ch_plazo"
        Me.ch_plazo.Size = New System.Drawing.Size(52, 17)
        Me.ch_plazo.TabIndex = 4
        Me.ch_plazo.Text = "Plazo"
        Me.ch_plazo.UseVisualStyleBackColor = True
        '
        'ch_pago
        '
        Me.ch_pago.AutoSize = True
        Me.ch_pago.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.cambio_condicionesBindingSource, "pago_inicial", True))
        Me.ch_pago.Location = New System.Drawing.Point(34, 54)
        Me.ch_pago.Name = "ch_pago"
        Me.ch_pago.Size = New System.Drawing.Size(81, 17)
        Me.ch_pago.TabIndex = 3
        Me.ch_pago.Text = "Pago Inicial"
        Me.ch_pago.UseVisualStyleBackColor = True
        '
        'ch_registro
        '
        Me.ch_registro.AutoSize = True
        Me.ch_registro.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.cambio_condicionesBindingSource, "derechos_registro", True))
        Me.ch_registro.Location = New System.Drawing.Point(508, 29)
        Me.ch_registro.Name = "ch_registro"
        Me.ch_registro.Size = New System.Drawing.Size(129, 17)
        Me.ch_registro.TabIndex = 2
        Me.ch_registro.Text = "Derechos de Registro"
        Me.ch_registro.UseVisualStyleBackColor = True
        '
        'ch_recurso
        '
        Me.ch_recurso.AutoSize = True
        Me.ch_recurso.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.cambio_condicionesBindingSource, "tipo_recursos", True))
        Me.ch_recurso.Location = New System.Drawing.Point(277, 29)
        Me.ch_recurso.Name = "ch_recurso"
        Me.ch_recurso.Size = New System.Drawing.Size(110, 17)
        Me.ch_recurso.TabIndex = 1
        Me.ch_recurso.Text = "Tipo de Recursos"
        Me.ch_recurso.UseVisualStyleBackColor = True
        '
        'ch_linea
        '
        Me.ch_linea.AutoSize = True
        Me.ch_linea.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.cambio_condicionesBindingSource, "linea_credito", True))
        Me.ch_linea.Location = New System.Drawing.Point(34, 29)
        Me.ch_linea.Name = "ch_linea"
        Me.ch_linea.Size = New System.Drawing.Size(105, 17)
        Me.ch_linea.TabIndex = 0
        Me.ch_linea.Text = "Línea de Crédito"
        Me.ch_linea.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_pago_condicion)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_recurso_condicion)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_registro_condicion)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_plazo_condicion)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_linea_condicion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 260)
        Me.GroupBox2.TabIndex = 155
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Condiciones Autorizadas"
        '
        'txt_pago_condicion
        '
        Me.txt_pago_condicion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "pago_condicion", True))
        Me.txt_pago_condicion.Enabled = False
        Me.txt_pago_condicion.Location = New System.Drawing.Point(6, 217)
        Me.txt_pago_condicion.MaxLength = 50
        Me.txt_pago_condicion.Name = "txt_pago_condicion"
        Me.txt_pago_condicion.Size = New System.Drawing.Size(309, 20)
        Me.txt_pago_condicion.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Garantía"
        '
        'txt_recurso_condicion
        '
        Me.txt_recurso_condicion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "recurso_condicion", True))
        Me.txt_recurso_condicion.Enabled = False
        Me.txt_recurso_condicion.Location = New System.Drawing.Point(9, 178)
        Me.txt_recurso_condicion.MaxLength = 50
        Me.txt_recurso_condicion.Name = "txt_recurso_condicion"
        Me.txt_recurso_condicion.Size = New System.Drawing.Size(306, 20)
        Me.txt_recurso_condicion.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Tipo de Recursos"
        '
        'txt_registro_condicion
        '
        Me.txt_registro_condicion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "registro_condicion", True))
        Me.txt_registro_condicion.Enabled = False
        Me.txt_registro_condicion.Location = New System.Drawing.Point(9, 137)
        Me.txt_registro_condicion.MaxLength = 50
        Me.txt_registro_condicion.Name = "txt_registro_condicion"
        Me.txt_registro_condicion.Size = New System.Drawing.Size(306, 20)
        Me.txt_registro_condicion.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Objeto de Financiamiento"
        '
        'txt_plazo_condicion
        '
        Me.txt_plazo_condicion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "plazo_condicion", True))
        Me.txt_plazo_condicion.Enabled = False
        Me.txt_plazo_condicion.Location = New System.Drawing.Point(9, 88)
        Me.txt_plazo_condicion.MaxLength = 50
        Me.txt_plazo_condicion.Name = "txt_plazo_condicion"
        Me.txt_plazo_condicion.Size = New System.Drawing.Size(306, 20)
        Me.txt_plazo_condicion.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Plazo"
        '
        'txt_linea_condicion
        '
        Me.txt_linea_condicion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "linea_condicion", True))
        Me.txt_linea_condicion.Enabled = False
        Me.txt_linea_condicion.Location = New System.Drawing.Point(10, 47)
        Me.txt_linea_condicion.MaxLength = 50
        Me.txt_linea_condicion.Name = "txt_linea_condicion"
        Me.txt_linea_condicion.Size = New System.Drawing.Size(305, 20)
        Me.txt_linea_condicion.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Línea"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_pago_cambio)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_recurso_cambio)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_registro_cambio)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txt_plazo_cambio)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txt_linea_cambio)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(372, 178)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(321, 260)
        Me.GroupBox3.TabIndex = 156
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cambios"
        '
        'txt_pago_cambio
        '
        Me.txt_pago_cambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "pago_cambio", True))
        Me.txt_pago_cambio.Enabled = False
        Me.txt_pago_cambio.Location = New System.Drawing.Point(6, 217)
        Me.txt_pago_cambio.MaxLength = 50
        Me.txt_pago_cambio.Name = "txt_pago_cambio"
        Me.txt_pago_cambio.Size = New System.Drawing.Size(309, 20)
        Me.txt_pago_cambio.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Garantía"
        '
        'txt_recurso_cambio
        '
        Me.txt_recurso_cambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "recurso_cambio", True))
        Me.txt_recurso_cambio.Enabled = False
        Me.txt_recurso_cambio.Location = New System.Drawing.Point(9, 178)
        Me.txt_recurso_cambio.MaxLength = 50
        Me.txt_recurso_cambio.Name = "txt_recurso_cambio"
        Me.txt_recurso_cambio.Size = New System.Drawing.Size(306, 20)
        Me.txt_recurso_cambio.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 162)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Tipo de Recursos"
        '
        'txt_registro_cambio
        '
        Me.txt_registro_cambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "registro_cambio", True))
        Me.txt_registro_cambio.Enabled = False
        Me.txt_registro_cambio.Location = New System.Drawing.Point(9, 137)
        Me.txt_registro_cambio.MaxLength = 50
        Me.txt_registro_cambio.Name = "txt_registro_cambio"
        Me.txt_registro_cambio.Size = New System.Drawing.Size(306, 20)
        Me.txt_registro_cambio.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Objeto de Financiamiento"
        '
        'txt_plazo_cambio
        '
        Me.txt_plazo_cambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "plazo_cambio", True))
        Me.txt_plazo_cambio.Enabled = False
        Me.txt_plazo_cambio.Location = New System.Drawing.Point(9, 88)
        Me.txt_plazo_cambio.MaxLength = 50
        Me.txt_plazo_cambio.Name = "txt_plazo_cambio"
        Me.txt_plazo_cambio.Size = New System.Drawing.Size(306, 20)
        Me.txt_plazo_cambio.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Plazo"
        '
        'txt_linea_cambio
        '
        Me.txt_linea_cambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "linea_cambio", True))
        Me.txt_linea_cambio.Enabled = False
        Me.txt_linea_cambio.Location = New System.Drawing.Point(10, 47)
        Me.txt_linea_cambio.MaxLength = 50
        Me.txt_linea_cambio.Name = "txt_linea_cambio"
        Me.txt_linea_cambio.Size = New System.Drawing.Size(305, 20)
        Me.txt_linea_cambio.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Línea"
        '
        'txt_otros
        '
        Me.txt_otros.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "otros_txt", True))
        Me.txt_otros.Enabled = False
        Me.txt_otros.Location = New System.Drawing.Point(12, 460)
        Me.txt_otros.MaxLength = 500
        Me.txt_otros.Multiline = True
        Me.txt_otros.Name = "txt_otros"
        Me.txt_otros.Size = New System.Drawing.Size(681, 97)
        Me.txt_otros.TabIndex = 157
        '
        'bt_guardar
        '
        Me.bt_guardar.Location = New System.Drawing.Point(537, 576)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(75, 23)
        Me.bt_guardar.TabIndex = 158
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Location = New System.Drawing.Point(618, 576)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 23)
        Me.bt_imprimir.TabIndex = 160
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'CONT_cambio_condicionesTableAdapter
        '
        Me.CONT_cambio_condicionesTableAdapter.ClearBeforeFill = True
        '
        'txt_anexo_existe
        '
        Me.txt_anexo_existe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "Anexo", True))
        Me.txt_anexo_existe.Location = New System.Drawing.Point(170, 9)
        Me.txt_anexo_existe.Name = "txt_anexo_existe"
        Me.txt_anexo_existe.Size = New System.Drawing.Size(90, 20)
        Me.txt_anexo_existe.TabIndex = 160
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 442)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 161
        Me.Label16.Text = "Otros"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 560)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Firma Promotor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(185, 560)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 13)
        Me.Label18.TabIndex = 162
        Me.Label18.Text = "Firma SubDireccion"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(369, 560)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 13)
        Me.Label19.TabIndex = 163
        Me.Label19.Text = "Firma Direccion Gral."
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "FirmaPromo", True))
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(12, 576)
        Me.TextBox2.MaxLength = 50
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(142, 20)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "FirmaSubPromo", True))
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(188, 576)
        Me.TextBox3.MaxLength = 50
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(142, 20)
        Me.TextBox3.TabIndex = 164
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.cambio_condicionesBindingSource, "FirmaDireccion", True))
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(369, 576)
        Me.TextBox4.MaxLength = 50
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(142, 20)
        Me.TextBox4.TabIndex = 165
        '
        'frm_cambio_condiciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 605)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.bt_guardar)
        Me.Controls.Add(Me.txt_otros)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.date_cambio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.date_autorizacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbanexos)
        Me.Controls.Add(Me.txt_existe)
        Me.Controls.Add(Me.txt_anexo_existe)
        Me.Name = "frm_cambio_condiciones"
        Me.Text = "SOLICITUD CAMBIO DE CONDICIONES"
        CType(Me.Bitacora_anexosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_AnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cambio_condicionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cambios_condicionesDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bitacora_anexosDS As Agil.MesaControlDS
    Friend WithEvents Vw_AnexosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_AnexosTableAdapter As Agil.MesaControlDSTableAdapters.Vw_AnexosTableAdapter
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Agil.MesaControlDSTableAdapters.ClientesTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents date_cambio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents date_autorizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbanexos As System.Windows.Forms.ComboBox
    Friend WithEvents txt_existe As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ch_otros As System.Windows.Forms.CheckBox
    Friend WithEvents ch_plazo As System.Windows.Forms.CheckBox
    Friend WithEvents ch_pago As System.Windows.Forms.CheckBox
    Friend WithEvents ch_registro As System.Windows.Forms.CheckBox
    Friend WithEvents ch_recurso As System.Windows.Forms.CheckBox
    Friend WithEvents ch_linea As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pago_condicion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_recurso_condicion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_registro_condicion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_plazo_condicion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_linea_condicion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pago_cambio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_recurso_cambio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_registro_cambio As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_plazo_cambio As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_linea_cambio As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_otros As System.Windows.Forms.TextBox
    Friend WithEvents bt_guardar As System.Windows.Forms.Button
    Friend WithEvents bt_imprimir As System.Windows.Forms.Button
    Friend WithEvents Cambios_condicionesDS As Agil.MesaControlDS
    Friend WithEvents cambio_condicionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_cambio_condicionesTableAdapter As Agil.MesaControlDSTableAdapters.Cambio_condicionesTableAdapter
    Friend WithEvents txt_anexo_existe As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
