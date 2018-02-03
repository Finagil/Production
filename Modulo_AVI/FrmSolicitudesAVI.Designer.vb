<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSolicitudesAVI
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
        Me.CiclosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS()
        Me.CiclosTableAdapter = New Agil.SegurosDSTableAdapters.CiclosTableAdapter()
        Me.AvioDS = New Agil.AviosDSX()
        Me.SEGCultivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEN_CultivosTableAdapter = New Agil.SegurosDSTableAdapters.GEN_CultivosTableAdapter()
        Me.ParametrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParametrosTableAdapter = New Agil.AviosDSXTableAdapters.ParametrosTableAdapter()
        Me.GroupDatos = New System.Windows.Forms.GroupBox()
        Me.TxtFinCiclo = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtBuroPM = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.CmbCultivo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbSucursal = New System.Windows.Forms.ComboBox()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbCiclo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMax = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtMin = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtSegAgri = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtSegVid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtBuro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtComis = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtGtosAdmin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtGtosHecta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCuota = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtid = New System.Windows.Forms.TextBox()
        Me.CmbClientes = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New Agil.AviosDSXTableAdapters.ClientesTableAdapter()
        Me.Cmbsolicitudes = New System.Windows.Forms.ComboBox()
        Me.SolicitudesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SolicitudesTableAdapter = New Agil.AviosDSXTableAdapters.SolicitudesTableAdapter()
        Me.GroupSolicitud = New System.Windows.Forms.GroupBox()
        Me.CmbFega = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.DtFechaVenAnticipo = New System.Windows.Forms.DateTimePicker()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CmbTrianual = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.CmbGarantia = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TxtPerBuro = New System.Windows.Forms.TextBox()
        Me.TxtPerBuroPM = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Cmbz25 = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TxtAnexo = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.CmbFondeo = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TxtCAT = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtLinea = New System.Windows.Forms.TextBox()
        Me.TxtTIIE = New System.Windows.Forms.TextBox()
        Me.TxtSegVida = New System.Windows.Forms.TextBox()
        Me.TxtSegAgriT = New System.Windows.Forms.TextBox()
        Me.TxtBuroT = New System.Windows.Forms.TextBox()
        Me.TxtComi = New System.Windows.Forms.TextBox()
        Me.TxtGastosAdmin = New System.Windows.Forms.TextBox()
        Me.CmbTipoSol = New System.Windows.Forms.ComboBox()
        Me.TxtDif = New System.Windows.Forms.TextBox()
        Me.TxtRendi = New System.Windows.Forms.TextBox()
        Me.TxtSuper = New System.Windows.Forms.TextBox()
        Me.DTfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxtIdSol = New System.Windows.Forms.TextBox()
        Me.TxtTipoPersona = New System.Windows.Forms.TextBox()
        Me.BttMinistraciones = New System.Windows.Forms.Button()
        Me.BttDel = New System.Windows.Forms.Button()
        Me.BttCancel = New System.Windows.Forms.Button()
        Me.BttSave = New System.Windows.Forms.Button()
        Me.BttMod = New System.Windows.Forms.Button()
        Me.BttNew = New System.Windows.Forms.Button()
        Me.SucursalesTableAdapter = New Agil.AviosDSXTableAdapters.SucursalesTableAdapter()
        Me.BtnInegi = New System.Windows.Forms.Button()
        Me.BtnAnexo = New System.Windows.Forms.Button()
        CType(Me.CiclosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvioDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGCultivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDatos.SuspendLayout()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolicitudesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupSolicitud.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiclosBindingSource
        '
        Me.CiclosBindingSource.DataMember = "Ciclos"
        Me.CiclosBindingSource.DataSource = Me.SegurosDS
        '
        'SegurosDS
        '
        Me.SegurosDS.DataSetName = "SegurosDS"
        Me.SegurosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CiclosTableAdapter
        '
        Me.CiclosTableAdapter.ClearBeforeFill = True
        '
        'AvioDS
        '
        Me.AvioDS.DataSetName = "AvioDS"
        Me.AvioDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SEGCultivosBindingSource
        '
        Me.SEGCultivosBindingSource.DataMember = "GEN_Cultivos"
        Me.SEGCultivosBindingSource.DataSource = Me.SegurosDS
        '
        'GEN_CultivosTableAdapter
        '
        Me.GEN_CultivosTableAdapter.ClearBeforeFill = True
        '
        'ParametrosBindingSource
        '
        Me.ParametrosBindingSource.DataMember = "Parametros"
        Me.ParametrosBindingSource.DataSource = Me.AvioDS
        '
        'ParametrosTableAdapter
        '
        Me.ParametrosTableAdapter.ClearBeforeFill = True
        '
        'GroupDatos
        '
        Me.GroupDatos.Controls.Add(Me.TxtFinCiclo)
        Me.GroupDatos.Controls.Add(Me.Label35)
        Me.GroupDatos.Controls.Add(Me.TxtBuroPM)
        Me.GroupDatos.Controls.Add(Me.Label33)
        Me.GroupDatos.Controls.Add(Me.CmbCultivo)
        Me.GroupDatos.Controls.Add(Me.Label3)
        Me.GroupDatos.Controls.Add(Me.CmbSucursal)
        Me.GroupDatos.Controls.Add(Me.Label2)
        Me.GroupDatos.Controls.Add(Me.CmbCiclo)
        Me.GroupDatos.Controls.Add(Me.Label1)
        Me.GroupDatos.Controls.Add(Me.TxtMax)
        Me.GroupDatos.Controls.Add(Me.Label13)
        Me.GroupDatos.Controls.Add(Me.TxtMin)
        Me.GroupDatos.Controls.Add(Me.Label12)
        Me.GroupDatos.Controls.Add(Me.TxtTasa)
        Me.GroupDatos.Controls.Add(Me.Label11)
        Me.GroupDatos.Controls.Add(Me.TxtSegAgri)
        Me.GroupDatos.Controls.Add(Me.Label10)
        Me.GroupDatos.Controls.Add(Me.TxtSegVid)
        Me.GroupDatos.Controls.Add(Me.Label9)
        Me.GroupDatos.Controls.Add(Me.TxtBuro)
        Me.GroupDatos.Controls.Add(Me.Label8)
        Me.GroupDatos.Controls.Add(Me.TxtComis)
        Me.GroupDatos.Controls.Add(Me.Label7)
        Me.GroupDatos.Controls.Add(Me.TxtGtosAdmin)
        Me.GroupDatos.Controls.Add(Me.Label6)
        Me.GroupDatos.Controls.Add(Me.TxtGtosHecta)
        Me.GroupDatos.Controls.Add(Me.Label5)
        Me.GroupDatos.Controls.Add(Me.TxtCuota)
        Me.GroupDatos.Controls.Add(Me.Label4)
        Me.GroupDatos.Controls.Add(Me.Txtid)
        Me.GroupDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDatos.Location = New System.Drawing.Point(12, 12)
        Me.GroupDatos.Name = "GroupDatos"
        Me.GroupDatos.Size = New System.Drawing.Size(750, 142)
        Me.GroupDatos.TabIndex = 8
        Me.GroupDatos.TabStop = False
        Me.GroupDatos.Text = "Parametros Avio"
        '
        'TxtFinCiclo
        '
        Me.TxtFinCiclo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "FechaTerminacion", True))
        Me.TxtFinCiclo.Location = New System.Drawing.Point(625, 110)
        Me.TxtFinCiclo.Name = "TxtFinCiclo"
        Me.TxtFinCiclo.ReadOnly = True
        Me.TxtFinCiclo.Size = New System.Drawing.Size(116, 20)
        Me.TxtFinCiclo.TabIndex = 37
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(622, 94)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(95, 13)
        Me.Label35.TabIndex = 36
        Me.Label35.Text = "Fecha Fin Ciclo"
        '
        'TxtBuroPM
        '
        Me.TxtBuroPM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "CostoBuroPM", True))
        Me.TxtBuroPM.Location = New System.Drawing.Point(625, 72)
        Me.TxtBuroPM.Name = "TxtBuroPM"
        Me.TxtBuroPM.ReadOnly = True
        Me.TxtBuroPM.Size = New System.Drawing.Size(116, 20)
        Me.TxtBuroPM.TabIndex = 35
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(622, 56)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(103, 13)
        Me.Label33.TabIndex = 34
        Me.Label33.Text = "Cuota Buro PM $"
        '
        'CmbCultivo
        '
        Me.CmbCultivo.DataSource = Me.SEGCultivosBindingSource
        Me.CmbCultivo.DisplayMember = "TitCombo"
        Me.CmbCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCultivo.FormattingEnabled = True
        Me.CmbCultivo.Location = New System.Drawing.Point(438, 33)
        Me.CmbCultivo.Name = "CmbCultivo"
        Me.CmbCultivo.Size = New System.Drawing.Size(208, 21)
        Me.CmbCultivo.TabIndex = 3
        Me.CmbCultivo.ValueMember = "idCultivo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(436, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Cultivo"
        '
        'CmbSucursal
        '
        Me.CmbSucursal.DataSource = Me.SucursalesBindingSource
        Me.CmbSucursal.DisplayMember = "Nombre_Sucursal"
        Me.CmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSucursal.FormattingEnabled = True
        Me.CmbSucursal.Location = New System.Drawing.Point(224, 33)
        Me.CmbSucursal.Name = "CmbSucursal"
        Me.CmbSucursal.Size = New System.Drawing.Size(208, 21)
        Me.CmbSucursal.TabIndex = 2
        Me.CmbSucursal.ValueMember = "ID_Sucursal"
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.AvioDS
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(221, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Sucursal"
        '
        'CmbCiclo
        '
        Me.CmbCiclo.DataSource = Me.CiclosBindingSource
        Me.CmbCiclo.DisplayMember = "DescCiclo"
        Me.CmbCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCiclo.FormattingEnabled = True
        Me.CmbCiclo.Location = New System.Drawing.Point(10, 33)
        Me.CmbCiclo.Name = "CmbCiclo"
        Me.CmbCiclo.Size = New System.Drawing.Size(208, 21)
        Me.CmbCiclo.TabIndex = 1
        Me.CmbCiclo.ValueMember = "Ciclo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Ciclo"
        '
        'TxtMax
        '
        Me.TxtMax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "TasaMax", True))
        Me.TxtMax.Location = New System.Drawing.Point(503, 110)
        Me.TxtMax.Name = "TxtMax"
        Me.TxtMax.ReadOnly = True
        Me.TxtMax.Size = New System.Drawing.Size(116, 20)
        Me.TxtMax.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(500, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Diferencial Max"
        '
        'TxtMin
        '
        Me.TxtMin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "TasaMin", True))
        Me.TxtMin.Location = New System.Drawing.Point(379, 110)
        Me.TxtMin.Name = "TxtMin"
        Me.TxtMin.ReadOnly = True
        Me.TxtMin.Size = New System.Drawing.Size(116, 20)
        Me.TxtMin.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(376, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Diferencial Min"
        '
        'TxtTasa
        '
        Me.TxtTasa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "Tasa", True))
        Me.TxtTasa.Location = New System.Drawing.Point(256, 110)
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.ReadOnly = True
        Me.TxtTasa.Size = New System.Drawing.Size(116, 20)
        Me.TxtTasa.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(252, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Diferencial Default"
        '
        'TxtSegAgri
        '
        Me.TxtSegAgri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "SeguroAgricolaHecta", True))
        Me.TxtSegAgri.Location = New System.Drawing.Point(131, 110)
        Me.TxtSegAgri.Name = "TxtSegAgri"
        Me.TxtSegAgri.ReadOnly = True
        Me.TxtSegAgri.Size = New System.Drawing.Size(116, 20)
        Me.TxtSegAgri.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(130, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Seg. Agricola $/Ha."
        '
        'TxtSegVid
        '
        Me.TxtSegVid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "SeguroVida", True))
        Me.TxtSegVid.Location = New System.Drawing.Point(9, 110)
        Me.TxtSegVid.Name = "TxtSegVid"
        Me.TxtSegVid.ReadOnly = True
        Me.TxtSegVid.Size = New System.Drawing.Size(116, 20)
        Me.TxtSegVid.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Seg. Vida (al millar)"
        '
        'TxtBuro
        '
        Me.TxtBuro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "CostoBuro", True))
        Me.TxtBuro.Location = New System.Drawing.Point(503, 72)
        Me.TxtBuro.Name = "TxtBuro"
        Me.TxtBuro.ReadOnly = True
        Me.TxtBuro.Size = New System.Drawing.Size(116, 20)
        Me.TxtBuro.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(500, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Cuota Buro PF $"
        '
        'TxtComis
        '
        Me.TxtComis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "PorcComision", True))
        Me.TxtComis.Location = New System.Drawing.Point(379, 72)
        Me.TxtComis.Name = "TxtComis"
        Me.TxtComis.ReadOnly = True
        Me.TxtComis.Size = New System.Drawing.Size(116, 20)
        Me.TxtComis.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(376, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Gtos. X Dispos %."
        '
        'TxtGtosAdmin
        '
        Me.TxtGtosAdmin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "GastosAdmin", True))
        Me.TxtGtosAdmin.Location = New System.Drawing.Point(255, 72)
        Me.TxtGtosAdmin.Name = "TxtGtosAdmin"
        Me.TxtGtosAdmin.ReadOnly = True
        Me.TxtGtosAdmin.Size = New System.Drawing.Size(116, 20)
        Me.TxtGtosAdmin.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(252, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Gtos. X Apertura $"
        '
        'TxtGtosHecta
        '
        Me.TxtGtosHecta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "GastosAdminHecta", True))
        Me.TxtGtosHecta.Location = New System.Drawing.Point(131, 72)
        Me.TxtGtosHecta.Name = "TxtGtosHecta"
        Me.TxtGtosHecta.ReadOnly = True
        Me.TxtGtosHecta.Size = New System.Drawing.Size(116, 20)
        Me.TxtGtosHecta.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Gtos. Admin. $/Ha."
        '
        'TxtCuota
        '
        Me.TxtCuota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "CuotaHectarea", True))
        Me.TxtCuota.Location = New System.Drawing.Point(7, 72)
        Me.TxtCuota.Name = "TxtCuota"
        Me.TxtCuota.ReadOnly = True
        Me.TxtCuota.Size = New System.Drawing.Size(116, 20)
        Me.TxtCuota.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cuota $/Ha."
        '
        'Txtid
        '
        Me.Txtid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "ID_parametro", True))
        Me.Txtid.Location = New System.Drawing.Point(576, 33)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.ReadOnly = True
        Me.Txtid.Size = New System.Drawing.Size(30, 20)
        Me.Txtid.TabIndex = 28
        '
        'CmbClientes
        '
        Me.CmbClientes.DataSource = Me.ClientesBindingSource
        Me.CmbClientes.DisplayMember = "Descr"
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(12, 174)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(495, 21)
        Me.CmbClientes.TabIndex = 36
        Me.CmbClientes.ValueMember = "Cliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.AvioDS
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 157)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Clientes"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Cmbsolicitudes
        '
        Me.Cmbsolicitudes.DataSource = Me.SolicitudesBindingSource
        Me.Cmbsolicitudes.DisplayMember = "Titulo"
        Me.Cmbsolicitudes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbsolicitudes.FormattingEnabled = True
        Me.Cmbsolicitudes.Location = New System.Drawing.Point(12, 216)
        Me.Cmbsolicitudes.Name = "Cmbsolicitudes"
        Me.Cmbsolicitudes.Size = New System.Drawing.Size(246, 21)
        Me.Cmbsolicitudes.TabIndex = 36
        Me.Cmbsolicitudes.ValueMember = "Id_Solicitud"
        '
        'SolicitudesBindingSource
        '
        Me.SolicitudesBindingSource.DataMember = "Solicitudes"
        Me.SolicitudesBindingSource.DataSource = Me.AvioDS
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 199)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Solicitudes"
        '
        'SolicitudesTableAdapter
        '
        Me.SolicitudesTableAdapter.ClearBeforeFill = True
        '
        'GroupSolicitud
        '
        Me.GroupSolicitud.Controls.Add(Me.CmbFega)
        Me.GroupSolicitud.Controls.Add(Me.Label39)
        Me.GroupSolicitud.Controls.Add(Me.DtFechaVenAnticipo)
        Me.GroupSolicitud.Controls.Add(Me.Label38)
        Me.GroupSolicitud.Controls.Add(Me.CmbTrianual)
        Me.GroupSolicitud.Controls.Add(Me.Label37)
        Me.GroupSolicitud.Controls.Add(Me.CmbGarantia)
        Me.GroupSolicitud.Controls.Add(Me.Label36)
        Me.GroupSolicitud.Controls.Add(Me.TxtPerBuro)
        Me.GroupSolicitud.Controls.Add(Me.TxtPerBuroPM)
        Me.GroupSolicitud.Controls.Add(Me.Label34)
        Me.GroupSolicitud.Controls.Add(Me.Cmbz25)
        Me.GroupSolicitud.Controls.Add(Me.Label32)
        Me.GroupSolicitud.Controls.Add(Me.TxtAnexo)
        Me.GroupSolicitud.Controls.Add(Me.Label31)
        Me.GroupSolicitud.Controls.Add(Me.CmbFondeo)
        Me.GroupSolicitud.Controls.Add(Me.Label30)
        Me.GroupSolicitud.Controls.Add(Me.TxtCAT)
        Me.GroupSolicitud.Controls.Add(Me.Label29)
        Me.GroupSolicitud.Controls.Add(Me.TxtLinea)
        Me.GroupSolicitud.Controls.Add(Me.TxtTIIE)
        Me.GroupSolicitud.Controls.Add(Me.TxtSegVida)
        Me.GroupSolicitud.Controls.Add(Me.TxtSegAgriT)
        Me.GroupSolicitud.Controls.Add(Me.TxtBuroT)
        Me.GroupSolicitud.Controls.Add(Me.TxtComi)
        Me.GroupSolicitud.Controls.Add(Me.TxtGastosAdmin)
        Me.GroupSolicitud.Controls.Add(Me.CmbTipoSol)
        Me.GroupSolicitud.Controls.Add(Me.TxtDif)
        Me.GroupSolicitud.Controls.Add(Me.TxtRendi)
        Me.GroupSolicitud.Controls.Add(Me.TxtSuper)
        Me.GroupSolicitud.Controls.Add(Me.DTfecha)
        Me.GroupSolicitud.Controls.Add(Me.Label16)
        Me.GroupSolicitud.Controls.Add(Me.Label17)
        Me.GroupSolicitud.Controls.Add(Me.Label18)
        Me.GroupSolicitud.Controls.Add(Me.Label19)
        Me.GroupSolicitud.Controls.Add(Me.Label20)
        Me.GroupSolicitud.Controls.Add(Me.Label21)
        Me.GroupSolicitud.Controls.Add(Me.Label22)
        Me.GroupSolicitud.Controls.Add(Me.Label23)
        Me.GroupSolicitud.Controls.Add(Me.Label24)
        Me.GroupSolicitud.Controls.Add(Me.Label25)
        Me.GroupSolicitud.Controls.Add(Me.Label26)
        Me.GroupSolicitud.Controls.Add(Me.Label27)
        Me.GroupSolicitud.Controls.Add(Me.Label28)
        Me.GroupSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupSolicitud.Location = New System.Drawing.Point(12, 243)
        Me.GroupSolicitud.Name = "GroupSolicitud"
        Me.GroupSolicitud.Size = New System.Drawing.Size(822, 142)
        Me.GroupSolicitud.TabIndex = 35
        Me.GroupSolicitud.TabStop = False
        Me.GroupSolicitud.Text = "Datos Solicitud"
        '
        'CmbFega
        '
        Me.CmbFega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFega.FormattingEnabled = True
        Me.CmbFega.Items.AddRange(New Object() {"Flat", "Dias Reales", "No Aplica"})
        Me.CmbFega.Location = New System.Drawing.Point(617, 73)
        Me.CmbFega.Name = "CmbFega"
        Me.CmbFega.Size = New System.Drawing.Size(69, 21)
        Me.CmbFega.TabIndex = 56
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(614, 57)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(35, 13)
        Me.Label39.TabIndex = 61
        Me.Label39.Text = "Fega"
        '
        'DtFechaVenAnticipo
        '
        Me.DtFechaVenAnticipo.Enabled = False
        Me.DtFechaVenAnticipo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaVenAnticipo.Location = New System.Drawing.Point(434, 115)
        Me.DtFechaVenAnticipo.Name = "DtFechaVenAnticipo"
        Me.DtFechaVenAnticipo.Size = New System.Drawing.Size(102, 20)
        Me.DtFechaVenAnticipo.TabIndex = 59
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(434, 98)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(79, 13)
        Me.Label38.TabIndex = 58
        Me.Label38.Text = "Fecha Venc."
        '
        'CmbTrianual
        '
        Me.CmbTrianual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTrianual.FormattingEnabled = True
        Me.CmbTrianual.Items.AddRange(New Object() {"Si", "NO"})
        Me.CmbTrianual.Location = New System.Drawing.Point(542, 72)
        Me.CmbTrianual.Name = "CmbTrianual"
        Me.CmbTrianual.Size = New System.Drawing.Size(69, 21)
        Me.CmbTrianual.TabIndex = 56
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(539, 57)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(53, 13)
        Me.Label37.TabIndex = 57
        Me.Label37.Text = "Trianual"
        '
        'CmbGarantia
        '
        Me.CmbGarantia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGarantia.FormattingEnabled = True
        Me.CmbGarantia.Items.AddRange(New Object() {"Si", "NO"})
        Me.CmbGarantia.Location = New System.Drawing.Point(743, 32)
        Me.CmbGarantia.Name = "CmbGarantia"
        Me.CmbGarantia.Size = New System.Drawing.Size(69, 21)
        Me.CmbGarantia.TabIndex = 43
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(740, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 13)
        Me.Label36.TabIndex = 55
        Me.Label36.Text = "Garantia Liq."
        '
        'TxtPerBuro
        '
        Me.TxtPerBuro.Location = New System.Drawing.Point(182, 34)
        Me.TxtPerBuro.Name = "TxtPerBuro"
        Me.TxtPerBuro.Size = New System.Drawing.Size(82, 20)
        Me.TxtPerBuro.TabIndex = 37
        '
        'TxtPerBuroPM
        '
        Me.TxtPerBuroPM.Location = New System.Drawing.Point(272, 34)
        Me.TxtPerBuroPM.Name = "TxtPerBuroPM"
        Me.TxtPerBuroPM.Size = New System.Drawing.Size(82, 20)
        Me.TxtPerBuroPM.TabIndex = 38
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(269, 18)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(88, 13)
        Me.Label34.TabIndex = 53
        Me.Label34.Text = "Pers. Buro PM"
        '
        'Cmbz25
        '
        Me.Cmbz25.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbz25.Enabled = False
        Me.Cmbz25.FormattingEnabled = True
        Me.Cmbz25.Items.AddRange(New Object() {"NO", "SI"})
        Me.Cmbz25.Location = New System.Drawing.Point(111, 72)
        Me.Cmbz25.Name = "Cmbz25"
        Me.Cmbz25.Size = New System.Drawing.Size(96, 21)
        Me.Cmbz25.TabIndex = 44
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(108, 56)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(68, 13)
        Me.Label32.TabIndex = 52
        Me.Label32.Text = "Apoyo Z25"
        '
        'TxtAnexo
        '
        Me.TxtAnexo.Location = New System.Drawing.Point(4, 73)
        Me.TxtAnexo.Name = "TxtAnexo"
        Me.TxtAnexo.Size = New System.Drawing.Size(91, 20)
        Me.TxtAnexo.TabIndex = 43
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(7, 56)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(42, 13)
        Me.Label31.TabIndex = 50
        Me.Label31.Text = "Anexo"
        '
        'CmbFondeo
        '
        Me.CmbFondeo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFondeo.FormattingEnabled = True
        Me.CmbFondeo.Items.AddRange(New Object() {"Fira", "Propios"})
        Me.CmbFondeo.Location = New System.Drawing.Point(668, 32)
        Me.CmbFondeo.Name = "CmbFondeo"
        Me.CmbFondeo.Size = New System.Drawing.Size(69, 21)
        Me.CmbFondeo.TabIndex = 42
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(665, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 13)
        Me.Label30.TabIndex = 49
        Me.Label30.Text = "Fondeo"
        '
        'TxtCAT
        '
        Me.TxtCAT.Location = New System.Drawing.Point(324, 116)
        Me.TxtCAT.Name = "TxtCAT"
        Me.TxtCAT.ReadOnly = True
        Me.TxtCAT.Size = New System.Drawing.Size(102, 20)
        Me.TxtCAT.TabIndex = 52
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(321, 102)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(31, 13)
        Me.Label29.TabIndex = 47
        Me.Label29.Text = "CAT"
        '
        'TxtLinea
        '
        Me.TxtLinea.Location = New System.Drawing.Point(214, 116)
        Me.TxtLinea.Name = "TxtLinea"
        Me.TxtLinea.ReadOnly = True
        Me.TxtLinea.Size = New System.Drawing.Size(102, 20)
        Me.TxtLinea.TabIndex = 51
        '
        'TxtTIIE
        '
        Me.TxtTIIE.Location = New System.Drawing.Point(115, 116)
        Me.TxtTIIE.Name = "TxtTIIE"
        Me.TxtTIIE.ReadOnly = True
        Me.TxtTIIE.Size = New System.Drawing.Size(92, 20)
        Me.TxtTIIE.TabIndex = 50
        '
        'TxtSegVida
        '
        Me.TxtSegVida.Location = New System.Drawing.Point(6, 116)
        Me.TxtSegVida.Name = "TxtSegVida"
        Me.TxtSegVida.ReadOnly = True
        Me.TxtSegVida.Size = New System.Drawing.Size(102, 20)
        Me.TxtSegVida.TabIndex = 49
        '
        'TxtSegAgriT
        '
        Me.TxtSegAgriT.Location = New System.Drawing.Point(434, 73)
        Me.TxtSegAgriT.Name = "TxtSegAgriT"
        Me.TxtSegAgriT.ReadOnly = True
        Me.TxtSegAgriT.Size = New System.Drawing.Size(102, 20)
        Me.TxtSegAgriT.TabIndex = 48
        '
        'TxtBuroT
        '
        Me.TxtBuroT.Location = New System.Drawing.Point(324, 73)
        Me.TxtBuroT.Name = "TxtBuroT"
        Me.TxtBuroT.ReadOnly = True
        Me.TxtBuroT.Size = New System.Drawing.Size(102, 20)
        Me.TxtBuroT.TabIndex = 47
        '
        'TxtComi
        '
        Me.TxtComi.Location = New System.Drawing.Point(213, 72)
        Me.TxtComi.Name = "TxtComi"
        Me.TxtComi.ReadOnly = True
        Me.TxtComi.Size = New System.Drawing.Size(102, 20)
        Me.TxtComi.TabIndex = 46
        '
        'TxtGastosAdmin
        '
        Me.TxtGastosAdmin.Location = New System.Drawing.Point(214, 73)
        Me.TxtGastosAdmin.Name = "TxtGastosAdmin"
        Me.TxtGastosAdmin.ReadOnly = True
        Me.TxtGastosAdmin.Size = New System.Drawing.Size(102, 20)
        Me.TxtGastosAdmin.TabIndex = 45
        '
        'CmbTipoSol
        '
        Me.CmbTipoSol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoSol.FormattingEnabled = True
        Me.CmbTipoSol.Items.AddRange(New Object() {"Anticipo (A)", "Habilitacion (H)", "Ampliación (AM)"})
        Me.CmbTipoSol.Location = New System.Drawing.Point(549, 32)
        Me.CmbTipoSol.Name = "CmbTipoSol"
        Me.CmbTipoSol.Size = New System.Drawing.Size(113, 21)
        Me.CmbTipoSol.TabIndex = 41
        '
        'TxtDif
        '
        Me.TxtDif.Location = New System.Drawing.Point(478, 33)
        Me.TxtDif.Name = "TxtDif"
        Me.TxtDif.Size = New System.Drawing.Size(65, 20)
        Me.TxtDif.TabIndex = 40
        '
        'TxtRendi
        '
        Me.TxtRendi.Location = New System.Drawing.Point(361, 34)
        Me.TxtRendi.Name = "TxtRendi"
        Me.TxtRendi.Size = New System.Drawing.Size(108, 20)
        Me.TxtRendi.TabIndex = 39
        '
        'TxtSuper
        '
        Me.TxtSuper.Location = New System.Drawing.Point(115, 34)
        Me.TxtSuper.Name = "TxtSuper"
        Me.TxtSuper.Size = New System.Drawing.Size(61, 20)
        Me.TxtSuper.TabIndex = 36
        '
        'DTfecha
        '
        Me.DTfecha.Enabled = False
        Me.DTfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTfecha.Location = New System.Drawing.Point(7, 33)
        Me.DTfecha.Name = "DTfecha"
        Me.DTfecha.Size = New System.Drawing.Size(102, 20)
        Me.DTfecha.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(112, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "TIIE"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(112, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Superficie"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Fecha Solicitud"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 101)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Seg. Vid (millar)"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(431, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Seguro Agricola"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(323, 58)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 13)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Buro"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(211, 57)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(111, 13)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Comision X Dispos"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(215, 57)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(101, 13)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Gtos. X Apertura"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(210, 102)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 13)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Monto Credito"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(549, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(85, 13)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Tipo Solicitud"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(475, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(68, 13)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Diferencial"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(358, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(111, 13)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "Rendimiento x Ha."
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(179, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(85, 13)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "Pers. Buro PF"
        '
        'TxtIdSol
        '
        Me.TxtIdSol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SolicitudesBindingSource, "Id_Solicitud", True))
        Me.TxtIdSol.Location = New System.Drawing.Point(215, 217)
        Me.TxtIdSol.Name = "TxtIdSol"
        Me.TxtIdSol.ReadOnly = True
        Me.TxtIdSol.Size = New System.Drawing.Size(30, 20)
        Me.TxtIdSol.TabIndex = 28
        '
        'TxtTipoPersona
        '
        Me.TxtTipoPersona.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Tipo", True))
        Me.TxtTipoPersona.Location = New System.Drawing.Point(513, 175)
        Me.TxtTipoPersona.Name = "TxtTipoPersona"
        Me.TxtTipoPersona.ReadOnly = True
        Me.TxtTipoPersona.Size = New System.Drawing.Size(30, 20)
        Me.TxtTipoPersona.TabIndex = 37
        '
        'BttMinistraciones
        '
        Me.BttMinistraciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttMinistraciones.Location = New System.Drawing.Point(421, 391)
        Me.BttMinistraciones.Name = "BttMinistraciones"
        Me.BttMinistraciones.Size = New System.Drawing.Size(97, 42)
        Me.BttMinistraciones.TabIndex = 119
        Me.BttMinistraciones.Text = "Calculo de CAT"
        Me.BttMinistraciones.UseVisualStyleBackColor = True
        '
        'BttDel
        '
        Me.BttDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttDel.Location = New System.Drawing.Point(340, 391)
        Me.BttDel.Name = "BttDel"
        Me.BttDel.Size = New System.Drawing.Size(72, 42)
        Me.BttDel.TabIndex = 118
        Me.BttDel.Text = "Eliminar"
        Me.BttDel.UseVisualStyleBackColor = True
        '
        'BttCancel
        '
        Me.BttCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttCancel.Location = New System.Drawing.Point(259, 391)
        Me.BttCancel.Name = "BttCancel"
        Me.BttCancel.Size = New System.Drawing.Size(72, 42)
        Me.BttCancel.TabIndex = 117
        Me.BttCancel.Text = "Cancelar"
        Me.BttCancel.UseVisualStyleBackColor = True
        '
        'BttSave
        '
        Me.BttSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttSave.Location = New System.Drawing.Point(178, 391)
        Me.BttSave.Name = "BttSave"
        Me.BttSave.Size = New System.Drawing.Size(72, 42)
        Me.BttSave.TabIndex = 116
        Me.BttSave.Text = "Guardar"
        Me.BttSave.UseVisualStyleBackColor = True
        '
        'BttMod
        '
        Me.BttMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttMod.Location = New System.Drawing.Point(97, 391)
        Me.BttMod.Name = "BttMod"
        Me.BttMod.Size = New System.Drawing.Size(72, 42)
        Me.BttMod.TabIndex = 115
        Me.BttMod.Text = "Modificar"
        Me.BttMod.UseVisualStyleBackColor = True
        '
        'BttNew
        '
        Me.BttNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttNew.Location = New System.Drawing.Point(16, 391)
        Me.BttNew.Name = "BttNew"
        Me.BttNew.Size = New System.Drawing.Size(72, 42)
        Me.BttNew.TabIndex = 114
        Me.BttNew.Text = "Nuevo"
        Me.BttNew.UseVisualStyleBackColor = True
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
        '
        'BtnInegi
        '
        Me.BtnInegi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInegi.Location = New System.Drawing.Point(556, 174)
        Me.BtnInegi.Name = "BtnInegi"
        Me.BtnInegi.Size = New System.Drawing.Size(102, 21)
        Me.BtnInegi.TabIndex = 120
        Me.BtnInegi.Text = "Form. Inegi"
        Me.BtnInegi.UseVisualStyleBackColor = True
        '
        'BtnAnexo
        '
        Me.BtnAnexo.Enabled = False
        Me.BtnAnexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnexo.Location = New System.Drawing.Point(524, 392)
        Me.BtnAnexo.Name = "BtnAnexo"
        Me.BtnAnexo.Size = New System.Drawing.Size(97, 42)
        Me.BtnAnexo.TabIndex = 121
        Me.BtnAnexo.Text = "Genera Num. Contrato"
        Me.BtnAnexo.UseVisualStyleBackColor = True
        '
        'FrmSolicitudesAVI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 446)
        Me.Controls.Add(Me.BtnAnexo)
        Me.Controls.Add(Me.BtnInegi)
        Me.Controls.Add(Me.BttMinistraciones)
        Me.Controls.Add(Me.BttDel)
        Me.Controls.Add(Me.BttCancel)
        Me.Controls.Add(Me.BttSave)
        Me.Controls.Add(Me.BttMod)
        Me.Controls.Add(Me.BttNew)
        Me.Controls.Add(Me.TxtTipoPersona)
        Me.Controls.Add(Me.GroupSolicitud)
        Me.Controls.Add(Me.Cmbsolicitudes)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CmbClientes)
        Me.Controls.Add(Me.GroupDatos)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtIdSol)
        Me.Name = "FrmSolicitudesAVI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitudes Avio"
        CType(Me.CiclosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvioDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGCultivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDatos.ResumeLayout(False)
        Me.GroupDatos.PerformLayout()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolicitudesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupSolicitud.ResumeLayout(False)
        Me.GroupSolicitud.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SegurosDS As Agil.SegurosDS
    Friend WithEvents CiclosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CiclosTableAdapter As Agil.SegurosDSTableAdapters.CiclosTableAdapter
    Friend WithEvents AvioDS As Agil.AviosDSX
    Friend WithEvents SEGCultivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GEN_CultivosTableAdapter As Agil.SegurosDSTableAdapters.GEN_CultivosTableAdapter
    Friend WithEvents ParametrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParametrosTableAdapter As Agil.AviosDSXTableAdapters.ParametrosTableAdapter
    Friend WithEvents GroupDatos As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBuro As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtComis As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtGtosAdmin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtGtosHecta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMax As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtMin As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtTasa As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtSegAgri As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtSegVid As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txtid As System.Windows.Forms.TextBox
    Friend WithEvents CmbCultivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Agil.AviosDSXTableAdapters.ClientesTableAdapter
    Friend WithEvents Cmbsolicitudes As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SolicitudesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SolicitudesTableAdapter As Agil.AviosDSXTableAdapters.SolicitudesTableAdapter
    Friend WithEvents GroupSolicitud As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TxtIdSol As System.Windows.Forms.TextBox
    Friend WithEvents TxtTipoPersona As System.Windows.Forms.TextBox
    Friend WithEvents BttMinistraciones As System.Windows.Forms.Button
    Friend WithEvents BttDel As System.Windows.Forms.Button
    Friend WithEvents BttCancel As System.Windows.Forms.Button
    Friend WithEvents BttSave As System.Windows.Forms.Button
    Friend WithEvents BttMod As System.Windows.Forms.Button
    Friend WithEvents BttNew As System.Windows.Forms.Button
    Friend WithEvents DTfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbTipoSol As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDif As System.Windows.Forms.TextBox
    Friend WithEvents TxtRendi As System.Windows.Forms.TextBox
    Friend WithEvents TxtSuper As System.Windows.Forms.TextBox
    Friend WithEvents TxtTIIE As System.Windows.Forms.TextBox
    Friend WithEvents TxtSegVida As System.Windows.Forms.TextBox
    Friend WithEvents TxtSegAgriT As System.Windows.Forms.TextBox
    Friend WithEvents TxtBuroT As System.Windows.Forms.TextBox
    Friend WithEvents TxtComi As System.Windows.Forms.TextBox
    Friend WithEvents TxtGastosAdmin As System.Windows.Forms.TextBox
    Friend WithEvents TxtLinea As System.Windows.Forms.TextBox
    Friend WithEvents TxtCAT As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents CmbFondeo As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TxtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Cmbz25 As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TxtBuroPM As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TxtPerBuroPM As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TxtPerBuro As System.Windows.Forms.TextBox
    Friend WithEvents SucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SucursalesTableAdapter As Agil.AviosDSXTableAdapters.SucursalesTableAdapter
    Friend WithEvents TxtFinCiclo As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents BtnInegi As System.Windows.Forms.Button
    Friend WithEvents CmbGarantia As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents BtnAnexo As System.Windows.Forms.Button
    Friend WithEvents CmbTrianual As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents DtFechaVenAnticipo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents CmbFega As ComboBox
    Friend WithEvents Label39 As Label
End Class
