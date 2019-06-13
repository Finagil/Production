<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeguroAvio
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupClientes = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TxtSemilla = New System.Windows.Forms.TextBox()
        Me.AviosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.BTTcambioNew = New System.Windows.Forms.Button()
        Me.TxtSucursal = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtXaseg = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtHectaAseg = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtHectaAnexo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BttAltaNew = New System.Windows.Forms.Button()
        Me.CmbCiclos = New System.Windows.Forms.ComboBox()
        Me.CiclosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbAnexo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbClientes = New System.Windows.Forms.ComboBox()
        Me.Txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BttBajaNew = New System.Windows.Forms.Button()
        Me.TxtFondeo = New System.Windows.Forms.TextBox()
        Me.GroupAltas = New System.Windows.Forms.GroupBox()
        Me.CombotIPO = New System.Windows.Forms.ComboBox()
        Me.ChkPagado = New System.Windows.Forms.CheckBox()
        Me.CmbAlta = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCuota = New System.Windows.Forms.TextBox()
        Me.PolAvioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmboPOL = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTalta = New System.Windows.Forms.DateTimePicker()
        Me.TxtAltaSuper = New System.Windows.Forms.TextBox()
        Me.ButtAltCancel = New System.Windows.Forms.Button()
        Me.BttAlta = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GridAltas = New System.Windows.Forms.DataGridView()
        Me.IdPolizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDsuperficieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CultivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuperficieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AseguradoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PolizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuperficesAltasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBaja = New System.Windows.Forms.GroupBox()
        Me.TxtSuperalta = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.CmbSuper = New System.Windows.Forms.ComboBox()
        Me.Superficie = New System.Windows.Forms.Label()
        Me.DTFecBaja = New System.Windows.Forms.DateTimePicker()
        Me.BttCancelBaja = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuperficesBajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtTA = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTB = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupCambio = New System.Windows.Forms.GroupBox()
        Me.TxtSuperCam = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtXasegC = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtHectaAsegC = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtHectaAnexoC = New System.Windows.Forms.TextBox()
        Me.AviosCambioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CmbAnexoCamb = New System.Windows.Forms.ComboBox()
        Me.CmbSuper2 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BttCancel3 = New System.Windows.Forms.Button()
        Me.BttCambio = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtBalance = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtMinistrado = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.CiclosTableAdapter = New Agil.SegurosDSTableAdapters.CiclosTableAdapter()
        Me.AviosTableAdapter = New Agil.SegurosDSTableAdapters.AviosTableAdapter()
        Me.ClientesTableAdapter = New Agil.SegurosDSTableAdapters.ClientesTableAdapter()
        Me.PolAvioTableAdapter = New Agil.SegurosDSTableAdapters.PolAvioTableAdapter()
        Me.SuperficesAltasTableAdapter = New Agil.SegurosDSTableAdapters.SuperficesAltasTableAdapter()
        Me.SuperficesBajasTableAdapter = New Agil.SegurosDSTableAdapters.SuperficesBajasTableAdapter()
        Me.AviosCambioTableAdapter = New Agil.SegurosDSTableAdapters.AviosCambioTableAdapter()
        Me.TxtPorMinistrar = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxtNC = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtObser = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnMinistrar = New System.Windows.Forms.Button()
        Me.GroupClientes.SuspendLayout()
        CType(Me.AviosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiclosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupAltas.SuspendLayout()
        CType(Me.PolAvioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAltas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperficesAltasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBaja.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperficesBajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupCambio.SuspendLayout()
        CType(Me.AviosCambioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupClientes
        '
        Me.GroupClientes.Controls.Add(Me.Button3)
        Me.GroupClientes.Controls.Add(Me.TxtSemilla)
        Me.GroupClientes.Controls.Add(Me.Label24)
        Me.GroupClientes.Controls.Add(Me.BTTcambioNew)
        Me.GroupClientes.Controls.Add(Me.TxtSucursal)
        Me.GroupClientes.Controls.Add(Me.Label11)
        Me.GroupClientes.Controls.Add(Me.TxtXaseg)
        Me.GroupClientes.Controls.Add(Me.Label10)
        Me.GroupClientes.Controls.Add(Me.TxtHectaAseg)
        Me.GroupClientes.Controls.Add(Me.Label9)
        Me.GroupClientes.Controls.Add(Me.TxtHectaAnexo)
        Me.GroupClientes.Controls.Add(Me.Label8)
        Me.GroupClientes.Controls.Add(Me.BttAltaNew)
        Me.GroupClientes.Controls.Add(Me.CmbCiclos)
        Me.GroupClientes.Controls.Add(Me.Label2)
        Me.GroupClientes.Controls.Add(Me.CmbAnexo)
        Me.GroupClientes.Controls.Add(Me.Label3)
        Me.GroupClientes.Controls.Add(Me.CmbClientes)
        Me.GroupClientes.Controls.Add(Me.Txtfiltro)
        Me.GroupClientes.Controls.Add(Me.Label1)
        Me.GroupClientes.Controls.Add(Me.BttBajaNew)
        Me.GroupClientes.Controls.Add(Me.TxtFondeo)
        Me.GroupClientes.Location = New System.Drawing.Point(12, 12)
        Me.GroupClientes.Name = "GroupClientes"
        Me.GroupClientes.Size = New System.Drawing.Size(459, 287)
        Me.GroupClientes.TabIndex = 7
        Me.GroupClientes.TabStop = False
        Me.GroupClientes.Text = "Selecionar Clientes"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(378, 233)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 43)
        Me.Button3.TabIndex = 122
        Me.Button3.Text = "Adjuntar Archivos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TxtSemilla
        '
        Me.TxtSemilla.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AviosBindingSource, "Semilla", True))
        Me.TxtSemilla.Location = New System.Drawing.Point(224, 180)
        Me.TxtSemilla.Name = "TxtSemilla"
        Me.TxtSemilla.ReadOnly = True
        Me.TxtSemilla.Size = New System.Drawing.Size(37, 20)
        Me.TxtSemilla.TabIndex = 110
        '
        'AviosBindingSource
        '
        Me.AviosBindingSource.DataMember = "Avios"
        Me.AviosBindingSource.DataSource = Me.SegurosDS
        '
        'SegurosDS
        '
        Me.SegurosDS.DataSetName = "SegurosDS"
        Me.SegurosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(221, 164)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 13)
        Me.Label24.TabIndex = 109
        Me.Label24.Text = "Semilla"
        '
        'BTTcambioNew
        '
        Me.BTTcambioNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTTcambioNew.Location = New System.Drawing.Point(234, 241)
        Me.BTTcambioNew.Name = "BTTcambioNew"
        Me.BTTcambioNew.Size = New System.Drawing.Size(138, 26)
        Me.BTTcambioNew.TabIndex = 108
        Me.BTTcambioNew.Text = "Cambio de Contrato"
        Me.BTTcambioNew.UseVisualStyleBackColor = True
        '
        'TxtSucursal
        '
        Me.TxtSucursal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre_Sucursal", True))
        Me.TxtSucursal.Location = New System.Drawing.Point(166, 102)
        Me.TxtSucursal.Name = "TxtSucursal"
        Me.TxtSucursal.ReadOnly = True
        Me.TxtSucursal.Size = New System.Drawing.Size(119, 20)
        Me.TxtSucursal.TabIndex = 106
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.SegurosDS
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(163, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Sucursal"
        '
        'TxtXaseg
        '
        Me.TxtXaseg.Location = New System.Drawing.Point(152, 180)
        Me.TxtXaseg.Name = "TxtXaseg"
        Me.TxtXaseg.ReadOnly = True
        Me.TxtXaseg.Size = New System.Drawing.Size(66, 20)
        Me.TxtXaseg.TabIndex = 104
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(149, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Por Asegurar"
        '
        'TxtHectaAseg
        '
        Me.TxtHectaAseg.Location = New System.Drawing.Point(81, 180)
        Me.TxtHectaAseg.Name = "TxtHectaAseg"
        Me.TxtHectaAseg.ReadOnly = True
        Me.TxtHectaAseg.Size = New System.Drawing.Size(65, 20)
        Me.TxtHectaAseg.TabIndex = 102
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(78, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Aseguradas"
        '
        'TxtHectaAnexo
        '
        Me.TxtHectaAnexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AviosBindingSource, "Hecta", True))
        Me.TxtHectaAnexo.Location = New System.Drawing.Point(12, 180)
        Me.TxtHectaAnexo.Name = "TxtHectaAnexo"
        Me.TxtHectaAnexo.ReadOnly = True
        Me.TxtHectaAnexo.Size = New System.Drawing.Size(64, 20)
        Me.TxtHectaAnexo.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Hectareas"
        '
        'BttAltaNew
        '
        Me.BttAltaNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttAltaNew.Location = New System.Drawing.Point(12, 242)
        Me.BttAltaNew.Name = "BttAltaNew"
        Me.BttAltaNew.Size = New System.Drawing.Size(99, 26)
        Me.BttAltaNew.TabIndex = 94
        Me.BttAltaNew.Text = "Altas"
        Me.BttAltaNew.UseVisualStyleBackColor = True
        '
        'CmbCiclos
        '
        Me.CmbCiclos.DataSource = Me.CiclosBindingSource
        Me.CmbCiclos.DisplayMember = "DescCiclo"
        Me.CmbCiclos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCiclos.FormattingEnabled = True
        Me.CmbCiclos.Location = New System.Drawing.Point(14, 101)
        Me.CmbCiclos.Name = "CmbCiclos"
        Me.CmbCiclos.Size = New System.Drawing.Size(143, 21)
        Me.CmbCiclos.TabIndex = 11
        Me.CmbCiclos.ValueMember = "Ciclo"
        '
        'CiclosBindingSource
        '
        Me.CiclosBindingSource.DataMember = "Ciclos"
        Me.CiclosBindingSource.DataSource = Me.SegurosDS
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Ciclos"
        '
        'CmbAnexo
        '
        Me.CmbAnexo.DataSource = Me.AviosBindingSource
        Me.CmbAnexo.DisplayMember = "AnexoX"
        Me.CmbAnexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnexo.FormattingEnabled = True
        Me.CmbAnexo.Location = New System.Drawing.Point(14, 140)
        Me.CmbAnexo.Name = "CmbAnexo"
        Me.CmbAnexo.Size = New System.Drawing.Size(143, 21)
        Me.CmbAnexo.TabIndex = 9
        Me.CmbAnexo.ValueMember = "Anexo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = " Anexos"
        '
        'CmbClientes
        '
        Me.CmbClientes.DataSource = Me.ClientesBindingSource
        Me.CmbClientes.DisplayMember = "Descr"
        Me.CmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(14, 61)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(441, 21)
        Me.CmbClientes.TabIndex = 7
        Me.CmbClientes.ValueMember = "Cliente"
        '
        'Txtfiltro
        '
        Me.Txtfiltro.Location = New System.Drawing.Point(14, 35)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(439, 20)
        Me.Txtfiltro.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Filtro"
        '
        'BttBajaNew
        '
        Me.BttBajaNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttBajaNew.Location = New System.Drawing.Point(121, 242)
        Me.BttBajaNew.Name = "BttBajaNew"
        Me.BttBajaNew.Size = New System.Drawing.Size(99, 26)
        Me.BttBajaNew.TabIndex = 107
        Me.BttBajaNew.Text = "Baja Total"
        Me.BttBajaNew.UseVisualStyleBackColor = True
        Me.BttBajaNew.Visible = False
        '
        'TxtFondeo
        '
        Me.TxtFondeo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AviosBindingSource, "Fondeo", True))
        Me.TxtFondeo.Location = New System.Drawing.Point(121, 141)
        Me.TxtFondeo.Name = "TxtFondeo"
        Me.TxtFondeo.ReadOnly = True
        Me.TxtFondeo.Size = New System.Drawing.Size(20, 20)
        Me.TxtFondeo.TabIndex = 111
        '
        'GroupAltas
        '
        Me.GroupAltas.Controls.Add(Me.CombotIPO)
        Me.GroupAltas.Controls.Add(Me.ChkPagado)
        Me.GroupAltas.Controls.Add(Me.CmbAlta)
        Me.GroupAltas.Controls.Add(Me.Label23)
        Me.GroupAltas.Controls.Add(Me.Label4)
        Me.GroupAltas.Controls.Add(Me.TxtCuota)
        Me.GroupAltas.Controls.Add(Me.CmboPOL)
        Me.GroupAltas.Controls.Add(Me.Label7)
        Me.GroupAltas.Controls.Add(Me.DTalta)
        Me.GroupAltas.Controls.Add(Me.TxtAltaSuper)
        Me.GroupAltas.Controls.Add(Me.ButtAltCancel)
        Me.GroupAltas.Controls.Add(Me.BttAlta)
        Me.GroupAltas.Controls.Add(Me.Label5)
        Me.GroupAltas.Controls.Add(Me.Label6)
        Me.GroupAltas.Location = New System.Drawing.Point(477, 12)
        Me.GroupAltas.Name = "GroupAltas"
        Me.GroupAltas.Size = New System.Drawing.Size(561, 93)
        Me.GroupAltas.TabIndex = 12
        Me.GroupAltas.TabStop = False
        Me.GroupAltas.Text = "Alta de Superficie"
        '
        'CombotIPO
        '
        Me.CombotIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombotIPO.FormattingEnabled = True
        Me.CombotIPO.Items.AddRange(New Object() {"SEGURO", "EXCEDENTE", "SUBSIDIO"})
        Me.CombotIPO.Location = New System.Drawing.Point(282, 64)
        Me.CombotIPO.Name = "CombotIPO"
        Me.CombotIPO.Size = New System.Drawing.Size(121, 21)
        Me.CombotIPO.TabIndex = 104
        '
        'ChkPagado
        '
        Me.ChkPagado.AutoSize = True
        Me.ChkPagado.Location = New System.Drawing.Point(154, 65)
        Me.ChkPagado.Name = "ChkPagado"
        Me.ChkPagado.Size = New System.Drawing.Size(127, 17)
        Me.ChkPagado.TabIndex = 100
        Me.ChkPagado.Text = "Pagado por el Cliente"
        Me.ChkPagado.UseVisualStyleBackColor = True
        '
        'CmbAlta
        '
        Me.CmbAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAlta.FormattingEnabled = True
        Me.CmbAlta.Items.AddRange(New Object() {"Alta", "Baja"})
        Me.CmbAlta.Location = New System.Drawing.Point(486, 33)
        Me.CmbAlta.Name = "CmbAlta"
        Me.CmbAlta.Size = New System.Drawing.Size(67, 21)
        Me.CmbAlta.TabIndex = 98
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(483, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(28, 13)
        Me.Label23.TabIndex = 101
        Me.Label23.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Cuota"
        '
        'TxtCuota
        '
        Me.TxtCuota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PolAvioBindingSource, "Cuota", True))
        Me.TxtCuota.Location = New System.Drawing.Point(49, 64)
        Me.TxtCuota.Name = "TxtCuota"
        Me.TxtCuota.ReadOnly = True
        Me.TxtCuota.Size = New System.Drawing.Size(100, 20)
        Me.TxtCuota.TabIndex = 99
        '
        'PolAvioBindingSource
        '
        Me.PolAvioBindingSource.DataMember = "PolAvio"
        Me.PolAvioBindingSource.DataSource = Me.SegurosDS
        '
        'CmboPOL
        '
        Me.CmboPOL.DataSource = Me.PolAvioBindingSource
        Me.CmboPOL.DisplayMember = "Titulo"
        Me.CmboPOL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboPOL.FormattingEnabled = True
        Me.CmboPOL.Location = New System.Drawing.Point(219, 33)
        Me.CmboPOL.Name = "CmboPOL"
        Me.CmboPOL.Size = New System.Drawing.Size(261, 21)
        Me.CmboPOL.TabIndex = 97
        Me.CmboPOL.ValueMember = "IdPoliza"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(216, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Poliza"
        '
        'DTalta
        '
        Me.DTalta.Enabled = False
        Me.DTalta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTalta.Location = New System.Drawing.Point(104, 34)
        Me.DTalta.Name = "DTalta"
        Me.DTalta.Size = New System.Drawing.Size(109, 20)
        Me.DTalta.TabIndex = 96
        '
        'TxtAltaSuper
        '
        Me.TxtAltaSuper.Location = New System.Drawing.Point(14, 35)
        Me.TxtAltaSuper.Name = "TxtAltaSuper"
        Me.TxtAltaSuper.Size = New System.Drawing.Size(84, 20)
        Me.TxtAltaSuper.TabIndex = 95
        '
        'ButtAltCancel
        '
        Me.ButtAltCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtAltCancel.Location = New System.Drawing.Point(486, 61)
        Me.ButtAltCancel.Name = "ButtAltCancel"
        Me.ButtAltCancel.Size = New System.Drawing.Size(67, 24)
        Me.ButtAltCancel.TabIndex = 103
        Me.ButtAltCancel.Text = "Cancelar"
        Me.ButtAltCancel.UseVisualStyleBackColor = True
        '
        'BttAlta
        '
        Me.BttAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttAlta.Location = New System.Drawing.Point(413, 61)
        Me.BttAlta.Name = "BttAlta"
        Me.BttAlta.Size = New System.Drawing.Size(67, 24)
        Me.BttAlta.TabIndex = 102
        Me.BttAlta.Text = "Alta"
        Me.BttAlta.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Superficie"
        '
        'GridAltas
        '
        Me.GridAltas.AllowUserToAddRows = False
        Me.GridAltas.AllowUserToDeleteRows = False
        Me.GridAltas.AllowUserToOrderColumns = True
        Me.GridAltas.AutoGenerateColumns = False
        Me.GridAltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAltas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPolizaDataGridViewTextBoxColumn, Me.IDsuperficieDataGridViewTextBoxColumn, Me.CultivoDataGridViewTextBoxColumn, Me.SuperficieDataGridViewTextBoxColumn, Me.CuotaDataGridViewTextBoxColumn, Me.AseguradoraDataGridViewTextBoxColumn, Me.PolizaDataGridViewTextBoxColumn, Me.PrimaDataGridViewTextBoxColumn, Me.Pagada, Me.Tipo})
        Me.GridAltas.DataSource = Me.SuperficesAltasBindingSource
        Me.GridAltas.Location = New System.Drawing.Point(12, 321)
        Me.GridAltas.Name = "GridAltas"
        Me.GridAltas.ReadOnly = True
        Me.GridAltas.Size = New System.Drawing.Size(650, 152)
        Me.GridAltas.TabIndex = 13
        '
        'IdPolizaDataGridViewTextBoxColumn
        '
        Me.IdPolizaDataGridViewTextBoxColumn.DataPropertyName = "IdPoliza"
        Me.IdPolizaDataGridViewTextBoxColumn.HeaderText = "IdPoliza"
        Me.IdPolizaDataGridViewTextBoxColumn.Name = "IdPolizaDataGridViewTextBoxColumn"
        Me.IdPolizaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPolizaDataGridViewTextBoxColumn.Visible = False
        '
        'IDsuperficieDataGridViewTextBoxColumn
        '
        Me.IDsuperficieDataGridViewTextBoxColumn.DataPropertyName = "IDsuperficie"
        Me.IDsuperficieDataGridViewTextBoxColumn.HeaderText = "IDsuperficie"
        Me.IDsuperficieDataGridViewTextBoxColumn.Name = "IDsuperficieDataGridViewTextBoxColumn"
        Me.IDsuperficieDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDsuperficieDataGridViewTextBoxColumn.Visible = False
        '
        'CultivoDataGridViewTextBoxColumn
        '
        Me.CultivoDataGridViewTextBoxColumn.DataPropertyName = "Cultivo"
        Me.CultivoDataGridViewTextBoxColumn.HeaderText = "Cultivo"
        Me.CultivoDataGridViewTextBoxColumn.Name = "CultivoDataGridViewTextBoxColumn"
        Me.CultivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CultivoDataGridViewTextBoxColumn.Width = 70
        '
        'SuperficieDataGridViewTextBoxColumn
        '
        Me.SuperficieDataGridViewTextBoxColumn.DataPropertyName = "Superficie"
        Me.SuperficieDataGridViewTextBoxColumn.HeaderText = "Superficie"
        Me.SuperficieDataGridViewTextBoxColumn.Name = "SuperficieDataGridViewTextBoxColumn"
        Me.SuperficieDataGridViewTextBoxColumn.ReadOnly = True
        Me.SuperficieDataGridViewTextBoxColumn.Width = 70
        '
        'CuotaDataGridViewTextBoxColumn
        '
        Me.CuotaDataGridViewTextBoxColumn.DataPropertyName = "Cuota"
        DataGridViewCellStyle5.Format = "N2"
        Me.CuotaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.CuotaDataGridViewTextBoxColumn.HeaderText = "Cuota"
        Me.CuotaDataGridViewTextBoxColumn.Name = "CuotaDataGridViewTextBoxColumn"
        Me.CuotaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuotaDataGridViewTextBoxColumn.Width = 70
        '
        'AseguradoraDataGridViewTextBoxColumn
        '
        Me.AseguradoraDataGridViewTextBoxColumn.DataPropertyName = "Aseguradora"
        Me.AseguradoraDataGridViewTextBoxColumn.HeaderText = "Aseguradora"
        Me.AseguradoraDataGridViewTextBoxColumn.Name = "AseguradoraDataGridViewTextBoxColumn"
        Me.AseguradoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.AseguradoraDataGridViewTextBoxColumn.Width = 190
        '
        'PolizaDataGridViewTextBoxColumn
        '
        Me.PolizaDataGridViewTextBoxColumn.DataPropertyName = "Poliza"
        Me.PolizaDataGridViewTextBoxColumn.HeaderText = "Poliza"
        Me.PolizaDataGridViewTextBoxColumn.Name = "PolizaDataGridViewTextBoxColumn"
        Me.PolizaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimaDataGridViewTextBoxColumn
        '
        Me.PrimaDataGridViewTextBoxColumn.DataPropertyName = "Prima"
        DataGridViewCellStyle6.Format = "N2"
        Me.PrimaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrimaDataGridViewTextBoxColumn.HeaderText = "Prima"
        Me.PrimaDataGridViewTextBoxColumn.Name = "PrimaDataGridViewTextBoxColumn"
        Me.PrimaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Pagada
        '
        Me.Pagada.DataPropertyName = "Pagada"
        Me.Pagada.HeaderText = "Pagada"
        Me.Pagada.Name = "Pagada"
        Me.Pagada.ReadOnly = True
        Me.Pagada.Width = 50
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 60
        '
        'SuperficesAltasBindingSource
        '
        Me.SuperficesAltasBindingSource.DataMember = "SuperficesAltas"
        Me.SuperficesAltasBindingSource.DataSource = Me.SegurosDS
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 302)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 107
        Me.Label12.Text = "Altas"
        '
        'GroupBaja
        '
        Me.GroupBaja.Controls.Add(Me.TxtSuperalta)
        Me.GroupBaja.Controls.Add(Me.Label25)
        Me.GroupBaja.Controls.Add(Me.CmbSuper)
        Me.GroupBaja.Controls.Add(Me.Superficie)
        Me.GroupBaja.Controls.Add(Me.DTFecBaja)
        Me.GroupBaja.Controls.Add(Me.BttCancelBaja)
        Me.GroupBaja.Controls.Add(Me.Button2)
        Me.GroupBaja.Controls.Add(Me.Label15)
        Me.GroupBaja.Location = New System.Drawing.Point(477, 223)
        Me.GroupBaja.Name = "GroupBaja"
        Me.GroupBaja.Size = New System.Drawing.Size(561, 92)
        Me.GroupBaja.TabIndex = 101
        Me.GroupBaja.TabStop = False
        Me.GroupBaja.Text = "Baja Total de Superficie"
        '
        'TxtSuperalta
        '
        Me.TxtSuperalta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuperficesAltasBindingSource, "Superficie", True))
        Me.TxtSuperalta.Location = New System.Drawing.Point(72, 62)
        Me.TxtSuperalta.Name = "TxtSuperalta"
        Me.TxtSuperalta.ReadOnly = True
        Me.TxtSuperalta.Size = New System.Drawing.Size(66, 20)
        Me.TxtSuperalta.TabIndex = 114
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(13, 65)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 13)
        Me.Label25.TabIndex = 113
        Me.Label25.Text = "Superficie"
        '
        'CmbSuper
        '
        Me.CmbSuper.DataSource = Me.SuperficesAltasBindingSource
        Me.CmbSuper.DisplayMember = "Titulo"
        Me.CmbSuper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSuper.FormattingEnabled = True
        Me.CmbSuper.Location = New System.Drawing.Point(129, 30)
        Me.CmbSuper.Name = "CmbSuper"
        Me.CmbSuper.Size = New System.Drawing.Size(278, 21)
        Me.CmbSuper.TabIndex = 12
        Me.CmbSuper.ValueMember = "IDsuperficie"
        '
        'Superficie
        '
        Me.Superficie.AutoSize = True
        Me.Superficie.Location = New System.Drawing.Point(126, 14)
        Me.Superficie.Name = "Superficie"
        Me.Superficie.Size = New System.Drawing.Size(59, 13)
        Me.Superficie.TabIndex = 98
        Me.Superficie.Text = "Superficies"
        '
        'DTFecBaja
        '
        Me.DTFecBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFecBaja.Location = New System.Drawing.Point(14, 31)
        Me.DTFecBaja.Name = "DTFecBaja"
        Me.DTFecBaja.Size = New System.Drawing.Size(109, 20)
        Me.DTFecBaja.TabIndex = 97
        '
        'BttCancelBaja
        '
        Me.BttCancelBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttCancelBaja.Location = New System.Drawing.Point(486, 59)
        Me.BttCancelBaja.Name = "BttCancelBaja"
        Me.BttCancelBaja.Size = New System.Drawing.Size(67, 24)
        Me.BttCancelBaja.TabIndex = 94
        Me.BttCancelBaja.Text = "Cancelar"
        Me.BttCancelBaja.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(413, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 24)
        Me.Button2.TabIndex = 93
        Me.Button2.Text = "Baja"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Fecha"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 476)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 109
        Me.Label17.Text = "Bajas"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DataGridView1.DataSource = Me.SuperficesBajasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 494)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(650, 114)
        Me.DataGridView1.TabIndex = 108
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdPoliza"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdPoliza"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IDsuperficie"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IDsuperficie"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cultivo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cultivo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Superficie"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Superficie"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cuota"
        DataGridViewCellStyle7.Format = "N2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cuota"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Aseguradora"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Aseguradora"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 190
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Poliza"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Poliza"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Prima"
        DataGridViewCellStyle8.Format = "N2"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn8.HeaderText = "Prima"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 60
        '
        'SuperficesBajasBindingSource
        '
        Me.SuperficesBajasBindingSource.DataMember = "SuperficesBajas"
        Me.SuperficesBajasBindingSource.DataSource = Me.SegurosDS
        '
        'TxtTA
        '
        Me.TxtTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTA.Location = New System.Drawing.Point(667, 453)
        Me.TxtTA.Name = "TxtTA"
        Me.TxtTA.ReadOnly = True
        Me.TxtTA.Size = New System.Drawing.Size(101, 20)
        Me.TxtTA.TabIndex = 109
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(665, 437)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "Total Altas"
        '
        'TxtTB
        '
        Me.TxtTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTB.Location = New System.Drawing.Point(667, 494)
        Me.TxtTB.Name = "TxtTB"
        Me.TxtTB.ReadOnly = True
        Me.TxtTB.Size = New System.Drawing.Size(101, 20)
        Me.TxtTB.TabIndex = 111
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(665, 478)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "Total Bajas"
        '
        'GroupCambio
        '
        Me.GroupCambio.Controls.Add(Me.TxtSuperCam)
        Me.GroupCambio.Controls.Add(Me.Label22)
        Me.GroupCambio.Controls.Add(Me.TxtXasegC)
        Me.GroupCambio.Controls.Add(Me.Label19)
        Me.GroupCambio.Controls.Add(Me.TxtHectaAsegC)
        Me.GroupCambio.Controls.Add(Me.Label20)
        Me.GroupCambio.Controls.Add(Me.TxtHectaAnexoC)
        Me.GroupCambio.Controls.Add(Me.Label21)
        Me.GroupCambio.Controls.Add(Me.CmbAnexoCamb)
        Me.GroupCambio.Controls.Add(Me.CmbSuper2)
        Me.GroupCambio.Controls.Add(Me.Label16)
        Me.GroupCambio.Controls.Add(Me.BttCancel3)
        Me.GroupCambio.Controls.Add(Me.BttCambio)
        Me.GroupCambio.Controls.Add(Me.Label18)
        Me.GroupCambio.Location = New System.Drawing.Point(477, 114)
        Me.GroupCambio.Name = "GroupCambio"
        Me.GroupCambio.Size = New System.Drawing.Size(561, 106)
        Me.GroupCambio.TabIndex = 102
        Me.GroupCambio.TabStop = False
        Me.GroupCambio.Text = "Cambio de Contrato"
        '
        'TxtSuperCam
        '
        Me.TxtSuperCam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuperficesAltasBindingSource, "Superficie", True))
        Me.TxtSuperCam.Location = New System.Drawing.Point(225, 75)
        Me.TxtSuperCam.Name = "TxtSuperCam"
        Me.TxtSuperCam.ReadOnly = True
        Me.TxtSuperCam.Size = New System.Drawing.Size(66, 20)
        Me.TxtSuperCam.TabIndex = 112
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(222, 59)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 13)
        Me.Label22.TabIndex = 111
        Me.Label22.Text = "Superficie"
        '
        'TxtXasegC
        '
        Me.TxtXasegC.Location = New System.Drawing.Point(154, 75)
        Me.TxtXasegC.Name = "TxtXasegC"
        Me.TxtXasegC.ReadOnly = True
        Me.TxtXasegC.Size = New System.Drawing.Size(66, 20)
        Me.TxtXasegC.TabIndex = 110
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(151, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 13)
        Me.Label19.TabIndex = 109
        Me.Label19.Text = "Por Asegurar"
        '
        'TxtHectaAsegC
        '
        Me.TxtHectaAsegC.Location = New System.Drawing.Point(84, 75)
        Me.TxtHectaAsegC.Name = "TxtHectaAsegC"
        Me.TxtHectaAsegC.ReadOnly = True
        Me.TxtHectaAsegC.Size = New System.Drawing.Size(65, 20)
        Me.TxtHectaAsegC.TabIndex = 108
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(81, 59)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 13)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "Aseguradas"
        '
        'TxtHectaAnexoC
        '
        Me.TxtHectaAnexoC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AviosCambioBindingSource, "Hecta", True))
        Me.TxtHectaAnexoC.Location = New System.Drawing.Point(14, 75)
        Me.TxtHectaAnexoC.Name = "TxtHectaAnexoC"
        Me.TxtHectaAnexoC.ReadOnly = True
        Me.TxtHectaAnexoC.Size = New System.Drawing.Size(64, 20)
        Me.TxtHectaAnexoC.TabIndex = 106
        '
        'AviosCambioBindingSource
        '
        Me.AviosCambioBindingSource.DataMember = "AviosCambio"
        Me.AviosCambioBindingSource.DataSource = Me.SegurosDS
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(11, 59)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 105
        Me.Label21.Text = "Hectareas"
        '
        'CmbAnexoCamb
        '
        Me.CmbAnexoCamb.DataSource = Me.AviosCambioBindingSource
        Me.CmbAnexoCamb.DisplayMember = "AnexoX"
        Me.CmbAnexoCamb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnexoCamb.FormattingEnabled = True
        Me.CmbAnexoCamb.Location = New System.Drawing.Point(12, 36)
        Me.CmbAnexoCamb.Name = "CmbAnexoCamb"
        Me.CmbAnexoCamb.Size = New System.Drawing.Size(111, 21)
        Me.CmbAnexoCamb.TabIndex = 99
        Me.CmbAnexoCamb.ValueMember = "Anexo"
        '
        'CmbSuper2
        '
        Me.CmbSuper2.DataSource = Me.SuperficesAltasBindingSource
        Me.CmbSuper2.DisplayMember = "Titulo"
        Me.CmbSuper2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSuper2.FormattingEnabled = True
        Me.CmbSuper2.Location = New System.Drawing.Point(129, 36)
        Me.CmbSuper2.Name = "CmbSuper2"
        Me.CmbSuper2.Size = New System.Drawing.Size(278, 21)
        Me.CmbSuper2.TabIndex = 12
        Me.CmbSuper2.ValueMember = "IDsuperficie"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(126, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 13)
        Me.Label16.TabIndex = 98
        Me.Label16.Text = "Superficies"
        '
        'BttCancel3
        '
        Me.BttCancel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttCancel3.Location = New System.Drawing.Point(486, 33)
        Me.BttCancel3.Name = "BttCancel3"
        Me.BttCancel3.Size = New System.Drawing.Size(67, 24)
        Me.BttCancel3.TabIndex = 94
        Me.BttCancel3.Text = "Cancelar"
        Me.BttCancel3.UseVisualStyleBackColor = True
        '
        'BttCambio
        '
        Me.BttCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttCambio.Location = New System.Drawing.Point(413, 33)
        Me.BttCambio.Name = "BttCambio"
        Me.BttCambio.Size = New System.Drawing.Size(67, 24)
        Me.BttCambio.TabIndex = 93
        Me.BttCambio.Text = "Cambiar"
        Me.BttCambio.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Contrato"
        '
        'TxtBalance
        '
        Me.TxtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBalance.Location = New System.Drawing.Point(783, 476)
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.ReadOnly = True
        Me.TxtBalance.Size = New System.Drawing.Size(101, 20)
        Me.TxtBalance.TabIndex = 113
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(781, 460)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(46, 13)
        Me.Label26.TabIndex = 112
        Me.Label26.Text = "Balance"
        '
        'TxtMinistrado
        '
        Me.TxtMinistrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMinistrado.Location = New System.Drawing.Point(891, 475)
        Me.TxtMinistrado.Name = "TxtMinistrado"
        Me.TxtMinistrado.ReadOnly = True
        Me.TxtMinistrado.Size = New System.Drawing.Size(101, 20)
        Me.TxtMinistrado.TabIndex = 115
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(888, 457)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(55, 13)
        Me.Label27.TabIndex = 114
        Me.Label27.Text = "Ministrado"
        '
        'CiclosTableAdapter
        '
        Me.CiclosTableAdapter.ClearBeforeFill = True
        '
        'AviosTableAdapter
        '
        Me.AviosTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'PolAvioTableAdapter
        '
        Me.PolAvioTableAdapter.ClearBeforeFill = True
        '
        'SuperficesAltasTableAdapter
        '
        Me.SuperficesAltasTableAdapter.ClearBeforeFill = True
        '
        'SuperficesBajasTableAdapter
        '
        Me.SuperficesBajasTableAdapter.ClearBeforeFill = True
        '
        'AviosCambioTableAdapter
        '
        Me.AviosCambioTableAdapter.ClearBeforeFill = True
        '
        'TxtPorMinistrar
        '
        Me.TxtPorMinistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPorMinistrar.ForeColor = System.Drawing.Color.Black
        Me.TxtPorMinistrar.Location = New System.Drawing.Point(891, 518)
        Me.TxtPorMinistrar.Name = "TxtPorMinistrar"
        Me.TxtPorMinistrar.ReadOnly = True
        Me.TxtPorMinistrar.Size = New System.Drawing.Size(101, 20)
        Me.TxtPorMinistrar.TabIndex = 117
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(888, 500)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 13)
        Me.Label28.TabIndex = 116
        Me.Label28.Text = "Por Ministrar"
        '
        'TxtNC
        '
        Me.TxtNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNC.Location = New System.Drawing.Point(890, 434)
        Me.TxtNC.Name = "TxtNC"
        Me.TxtNC.ReadOnly = True
        Me.TxtNC.Size = New System.Drawing.Size(101, 20)
        Me.TxtNC.TabIndex = 119
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(887, 416)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(86, 13)
        Me.Label29.TabIndex = 118
        Me.Label29.Text = "Notas de Credito"
        '
        'TxtObser
        '
        Me.TxtObser.Location = New System.Drawing.Point(667, 349)
        Me.TxtObser.MaxLength = 300
        Me.TxtObser.Multiline = True
        Me.TxtObser.Name = "TxtObser"
        Me.TxtObser.Size = New System.Drawing.Size(366, 64)
        Me.TxtObser.TabIndex = 120
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(668, 331)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(78, 13)
        Me.Label30.TabIndex = 115
        Me.Label30.Text = "Observaciones"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(887, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 24)
        Me.Button1.TabIndex = 115
        Me.Button1.Text = "Guardar Observaciones"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnMinistrar
        '
        Me.BtnMinistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinistrar.Location = New System.Drawing.Point(891, 544)
        Me.BtnMinistrar.Name = "BtnMinistrar"
        Me.BtnMinistrar.Size = New System.Drawing.Size(102, 24)
        Me.BtnMinistrar.TabIndex = 121
        Me.BtnMinistrar.Text = "Ministrar"
        Me.BtnMinistrar.UseVisualStyleBackColor = True
        Me.BtnMinistrar.Visible = False
        '
        'FrmSeguroAvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 616)
        Me.Controls.Add(Me.BtnMinistrar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.TxtObser)
        Me.Controls.Add(Me.TxtNC)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TxtPorMinistrar)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.TxtMinistrado)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.TxtBalance)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.GroupCambio)
        Me.Controls.Add(Me.TxtTB)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtTA)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBaja)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GridAltas)
        Me.Controls.Add(Me.GroupAltas)
        Me.Controls.Add(Me.GroupClientes)
        Me.Name = "FrmSeguroAvio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "101"
        Me.GroupClientes.ResumeLayout(False)
        Me.GroupClientes.PerformLayout()
        CType(Me.AviosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiclosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupAltas.ResumeLayout(False)
        Me.GroupAltas.PerformLayout()
        CType(Me.PolAvioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAltas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperficesAltasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBaja.ResumeLayout(False)
        Me.GroupBaja.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperficesBajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupCambio.ResumeLayout(False)
        Me.GroupCambio.PerformLayout()
        CType(Me.AviosCambioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SegurosDS As Agil.SegurosDS
    Friend WithEvents CiclosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CiclosTableAdapter As Agil.SegurosDSTableAdapters.CiclosTableAdapter
    Friend WithEvents AviosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AviosTableAdapter As Agil.SegurosDSTableAdapters.AviosTableAdapter
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Agil.SegurosDSTableAdapters.ClientesTableAdapter
    Friend WithEvents GroupClientes As System.Windows.Forms.GroupBox
    Friend WithEvents CmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents Txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbAnexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbCiclos As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupAltas As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BttAlta As System.Windows.Forms.Button
    Friend WithEvents DTalta As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtAltaSuper As System.Windows.Forms.TextBox
    Friend WithEvents ButtAltCancel As System.Windows.Forms.Button
    Friend WithEvents CmboPOL As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PolAvioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PolAvioTableAdapter As Agil.SegurosDSTableAdapters.PolAvioTableAdapter
    Friend WithEvents BttAltaNew As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCuota As System.Windows.Forms.TextBox
    Friend WithEvents TxtHectaAnexo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtHectaAseg As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtXaseg As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtSucursal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GridAltas As System.Windows.Forms.DataGridView
    Friend WithEvents SuperficesAltasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuperficesAltasTableAdapter As Agil.SegurosDSTableAdapters.SuperficesAltasTableAdapter
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBaja As System.Windows.Forms.GroupBox
    Friend WithEvents CmbSuper As System.Windows.Forms.ComboBox
    Friend WithEvents Superficie As System.Windows.Forms.Label
    Friend WithEvents DTFecBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents BttCancelBaja As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BttBajaNew As System.Windows.Forms.Button
    Friend WithEvents SuperficesBajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuperficesBajasTableAdapter As Agil.SegurosDSTableAdapters.SuperficesBajasTableAdapter
    Friend WithEvents TxtTA As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtTB As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BTTcambioNew As System.Windows.Forms.Button
    Friend WithEvents GroupCambio As System.Windows.Forms.GroupBox
    Friend WithEvents CmbSuper2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BttCancel3 As System.Windows.Forms.Button
    Friend WithEvents BttCambio As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CmbAnexoCamb As System.Windows.Forms.ComboBox
    Friend WithEvents AviosCambioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AviosCambioTableAdapter As Agil.SegurosDSTableAdapters.AviosCambioTableAdapter
    Friend WithEvents TxtXasegC As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtHectaAsegC As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtHectaAnexoC As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TxtSuperCam As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CmbAlta As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtSuperalta As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtSemilla As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TxtBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TxtMinistrado As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TxtPorMinistrar As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TxtNC As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TxtObser As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnMinistrar As System.Windows.Forms.Button
    Friend WithEvents TxtFondeo As System.Windows.Forms.TextBox
    Friend WithEvents ChkPagado As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents IdPolizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDsuperficieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CultivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuperficieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AseguradoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PolizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Pagada As DataGridViewCheckBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents CombotIPO As ComboBox
End Class
