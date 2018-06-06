<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParametros
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbCiclo = New System.Windows.Forms.ComboBox()
        Me.CiclosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS()
        Me.CiclosTableAdapter = New Agil.SegurosDSTableAdapters.CiclosTableAdapter()
        Me.CmbSucursal = New System.Windows.Forms.ComboBox()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvioDS = New Agil.AviosDSX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbCultivo = New System.Windows.Forms.ComboBox()
        Me.SEGCultivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GEN_CultivosTableAdapter = New Agil.SegurosDSTableAdapters.GEN_CultivosTableAdapter()
        Me.ParametrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParametrosTableAdapter = New Agil.AviosDSXTableAdapters.ParametrosTableAdapter()
        Me.GroupDatos = New System.Windows.Forms.GroupBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.DTDTC3 = New System.Windows.Forms.DateTimePicker()
        Me.DTcosechaFin3 = New System.Windows.Forms.DateTimePicker()
        Me.DTcosechaIni3 = New System.Windows.Forms.DateTimePicker()
        Me.DTSiembrafin3 = New System.Windows.Forms.DateTimePicker()
        Me.DTSiembraini3 = New System.Windows.Forms.DateTimePicker()
        Me.DTTermina3 = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.DTDTC2 = New System.Windows.Forms.DateTimePicker()
        Me.DTcosechaFin2 = New System.Windows.Forms.DateTimePicker()
        Me.DTcosechaIni2 = New System.Windows.Forms.DateTimePicker()
        Me.DTSiembrafin2 = New System.Windows.Forms.DateTimePicker()
        Me.DTSiembraini2 = New System.Windows.Forms.DateTimePicker()
        Me.DTTermina2 = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.BtnMinistraciones = New System.Windows.Forms.Button()
        Me.TxtBuroPM = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtTonHecta = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.DTDTC = New System.Windows.Forms.DateTimePicker()
        Me.DTcosechaFin = New System.Windows.Forms.DateTimePicker()
        Me.DTcosechaIni = New System.Windows.Forms.DateTimePicker()
        Me.DTSiembrafin = New System.Windows.Forms.DateTimePicker()
        Me.DTSiembraini = New System.Windows.Forms.DateTimePicker()
        Me.DTTermina = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
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
        Me.BttSave = New System.Windows.Forms.Button()
        Me.SucursalesTableAdapter = New Agil.AviosDSXTableAdapters.SucursalesTableAdapter()
        CType(Me.CiclosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvioDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGCultivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ciclo"
        '
        'CmbCiclo
        '
        Me.CmbCiclo.DataSource = Me.CiclosBindingSource
        Me.CmbCiclo.DisplayMember = "DescCiclo"
        Me.CmbCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCiclo.FormattingEnabled = True
        Me.CmbCiclo.Location = New System.Drawing.Point(13, 26)
        Me.CmbCiclo.Name = "CmbCiclo"
        Me.CmbCiclo.Size = New System.Drawing.Size(208, 21)
        Me.CmbCiclo.TabIndex = 1
        Me.CmbCiclo.ValueMember = "Ciclo"
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
        'CmbSucursal
        '
        Me.CmbSucursal.DataSource = Me.SucursalesBindingSource
        Me.CmbSucursal.DisplayMember = "Nombre_Sucursal"
        Me.CmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSucursal.FormattingEnabled = True
        Me.CmbSucursal.Location = New System.Drawing.Point(13, 67)
        Me.CmbSucursal.Name = "CmbSucursal"
        Me.CmbSucursal.Size = New System.Drawing.Size(208, 21)
        Me.CmbSucursal.TabIndex = 3
        Me.CmbSucursal.ValueMember = "ID_Sucursal"
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.AvioDS
        '
        'AvioDS
        '
        Me.AvioDS.DataSetName = "AvioDS"
        Me.AvioDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sucursal"
        '
        'CmbCultivo
        '
        Me.CmbCultivo.DataSource = Me.SEGCultivosBindingSource
        Me.CmbCultivo.DisplayMember = "TitCombo"
        Me.CmbCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCultivo.FormattingEnabled = True
        Me.CmbCultivo.Location = New System.Drawing.Point(12, 107)
        Me.CmbCultivo.Name = "CmbCultivo"
        Me.CmbCultivo.Size = New System.Drawing.Size(208, 21)
        Me.CmbCultivo.TabIndex = 5
        Me.CmbCultivo.ValueMember = "idCultivo"
        '
        'SEGCultivosBindingSource
        '
        Me.SEGCultivosBindingSource.DataMember = "GEN_Cultivos"
        Me.SEGCultivosBindingSource.DataSource = Me.SegurosDS
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cultivo"
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
        Me.GroupDatos.Controls.Add(Me.Label36)
        Me.GroupDatos.Controls.Add(Me.Label35)
        Me.GroupDatos.Controls.Add(Me.DTDTC3)
        Me.GroupDatos.Controls.Add(Me.DTcosechaFin3)
        Me.GroupDatos.Controls.Add(Me.DTcosechaIni3)
        Me.GroupDatos.Controls.Add(Me.DTSiembrafin3)
        Me.GroupDatos.Controls.Add(Me.DTSiembraini3)
        Me.GroupDatos.Controls.Add(Me.DTTermina3)
        Me.GroupDatos.Controls.Add(Me.Label29)
        Me.GroupDatos.Controls.Add(Me.Label30)
        Me.GroupDatos.Controls.Add(Me.Label31)
        Me.GroupDatos.Controls.Add(Me.Label32)
        Me.GroupDatos.Controls.Add(Me.Label33)
        Me.GroupDatos.Controls.Add(Me.Label34)
        Me.GroupDatos.Controls.Add(Me.DTDTC2)
        Me.GroupDatos.Controls.Add(Me.DTcosechaFin2)
        Me.GroupDatos.Controls.Add(Me.DTcosechaIni2)
        Me.GroupDatos.Controls.Add(Me.DTSiembrafin2)
        Me.GroupDatos.Controls.Add(Me.DTSiembraini2)
        Me.GroupDatos.Controls.Add(Me.DTTermina2)
        Me.GroupDatos.Controls.Add(Me.Label23)
        Me.GroupDatos.Controls.Add(Me.Label24)
        Me.GroupDatos.Controls.Add(Me.Label25)
        Me.GroupDatos.Controls.Add(Me.Label26)
        Me.GroupDatos.Controls.Add(Me.Label27)
        Me.GroupDatos.Controls.Add(Me.Label28)
        Me.GroupDatos.Controls.Add(Me.BtnMinistraciones)
        Me.GroupDatos.Controls.Add(Me.TxtBuroPM)
        Me.GroupDatos.Controls.Add(Me.Label22)
        Me.GroupDatos.Controls.Add(Me.TxtTonHecta)
        Me.GroupDatos.Controls.Add(Me.TxtPrecio)
        Me.GroupDatos.Controls.Add(Me.DTDTC)
        Me.GroupDatos.Controls.Add(Me.DTcosechaFin)
        Me.GroupDatos.Controls.Add(Me.DTcosechaIni)
        Me.GroupDatos.Controls.Add(Me.DTSiembrafin)
        Me.GroupDatos.Controls.Add(Me.DTSiembraini)
        Me.GroupDatos.Controls.Add(Me.DTTermina)
        Me.GroupDatos.Controls.Add(Me.Label21)
        Me.GroupDatos.Controls.Add(Me.Label20)
        Me.GroupDatos.Controls.Add(Me.Label19)
        Me.GroupDatos.Controls.Add(Me.Label18)
        Me.GroupDatos.Controls.Add(Me.Label17)
        Me.GroupDatos.Controls.Add(Me.Label16)
        Me.GroupDatos.Controls.Add(Me.Label15)
        Me.GroupDatos.Controls.Add(Me.Label14)
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
        Me.GroupDatos.Location = New System.Drawing.Point(12, 134)
        Me.GroupDatos.Name = "GroupDatos"
        Me.GroupDatos.Size = New System.Drawing.Size(748, 296)
        Me.GroupDatos.TabIndex = 8
        Me.GroupDatos.TabStop = False
        Me.GroupDatos.Text = "Parametros Avio por Ciclo, Plaza y Cultivo"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(9, 231)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(40, 13)
        Me.Label36.TabIndex = 73
        Me.Label36.Text = "Año 3"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(10, 179)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(40, 13)
        Me.Label35.TabIndex = 72
        Me.Label35.Text = "Año 2"
        '
        'DTDTC3
        '
        Me.DTDTC3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDTC3.Location = New System.Drawing.Point(626, 261)
        Me.DTDTC3.Name = "DTDTC3"
        Me.DTDTC3.Size = New System.Drawing.Size(118, 20)
        Me.DTDTC3.TabIndex = 70
        '
        'DTcosechaFin3
        '
        Me.DTcosechaFin3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTcosechaFin3.Location = New System.Drawing.Point(502, 261)
        Me.DTcosechaFin3.Name = "DTcosechaFin3"
        Me.DTcosechaFin3.Size = New System.Drawing.Size(118, 20)
        Me.DTcosechaFin3.TabIndex = 69
        '
        'DTcosechaIni3
        '
        Me.DTcosechaIni3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTcosechaIni3.Location = New System.Drawing.Point(378, 261)
        Me.DTcosechaIni3.Name = "DTcosechaIni3"
        Me.DTcosechaIni3.Size = New System.Drawing.Size(118, 20)
        Me.DTcosechaIni3.TabIndex = 68
        '
        'DTSiembrafin3
        '
        Me.DTSiembrafin3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTSiembrafin3.Location = New System.Drawing.Point(255, 261)
        Me.DTSiembrafin3.Name = "DTSiembrafin3"
        Me.DTSiembrafin3.Size = New System.Drawing.Size(118, 20)
        Me.DTSiembrafin3.TabIndex = 67
        '
        'DTSiembraini3
        '
        Me.DTSiembraini3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTSiembraini3.Location = New System.Drawing.Point(130, 261)
        Me.DTSiembraini3.Name = "DTSiembraini3"
        Me.DTSiembraini3.Size = New System.Drawing.Size(118, 20)
        Me.DTSiembraini3.TabIndex = 66
        '
        'DTTermina3
        '
        Me.DTTermina3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTTermina3.Location = New System.Drawing.Point(6, 261)
        Me.DTTermina3.Name = "DTTermina3"
        Me.DTTermina3.Size = New System.Drawing.Size(118, 20)
        Me.DTTermina3.TabIndex = 65
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(627, 245)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(69, 13)
        Me.Label29.TabIndex = 64
        Me.Label29.Text = "Limite DTC"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(500, 245)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(109, 13)
        Me.Label30.TabIndex = 63
        Me.Label30.Text = "Finde de Cosecha"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(375, 245)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(109, 13)
        Me.Label31.TabIndex = 62
        Me.Label31.Text = "Inicio de Cosecha"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(252, 245)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(91, 13)
        Me.Label32.TabIndex = 61
        Me.Label32.Text = "Fin de Siembra"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(127, 245)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(105, 13)
        Me.Label33.TabIndex = 60
        Me.Label33.Text = "Inicio de Siembra"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(7, 245)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(115, 13)
        Me.Label34.TabIndex = 59
        Me.Label34.Text = "Fecha Terminacion"
        '
        'DTDTC2
        '
        Me.DTDTC2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDTC2.Location = New System.Drawing.Point(626, 208)
        Me.DTDTC2.Name = "DTDTC2"
        Me.DTDTC2.Size = New System.Drawing.Size(118, 20)
        Me.DTDTC2.TabIndex = 58
        '
        'DTcosechaFin2
        '
        Me.DTcosechaFin2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTcosechaFin2.Location = New System.Drawing.Point(502, 208)
        Me.DTcosechaFin2.Name = "DTcosechaFin2"
        Me.DTcosechaFin2.Size = New System.Drawing.Size(118, 20)
        Me.DTcosechaFin2.TabIndex = 57
        '
        'DTcosechaIni2
        '
        Me.DTcosechaIni2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTcosechaIni2.Location = New System.Drawing.Point(378, 208)
        Me.DTcosechaIni2.Name = "DTcosechaIni2"
        Me.DTcosechaIni2.Size = New System.Drawing.Size(118, 20)
        Me.DTcosechaIni2.TabIndex = 56
        '
        'DTSiembrafin2
        '
        Me.DTSiembrafin2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTSiembrafin2.Location = New System.Drawing.Point(255, 208)
        Me.DTSiembrafin2.Name = "DTSiembrafin2"
        Me.DTSiembrafin2.Size = New System.Drawing.Size(118, 20)
        Me.DTSiembrafin2.TabIndex = 55
        '
        'DTSiembraini2
        '
        Me.DTSiembraini2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTSiembraini2.Location = New System.Drawing.Point(130, 208)
        Me.DTSiembraini2.Name = "DTSiembraini2"
        Me.DTSiembraini2.Size = New System.Drawing.Size(118, 20)
        Me.DTSiembraini2.TabIndex = 54
        '
        'DTTermina2
        '
        Me.DTTermina2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTTermina2.Location = New System.Drawing.Point(6, 208)
        Me.DTTermina2.Name = "DTTermina2"
        Me.DTTermina2.Size = New System.Drawing.Size(118, 20)
        Me.DTTermina2.TabIndex = 53
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(627, 192)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 13)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "Limite DTC"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(500, 192)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(109, 13)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Finde de Cosecha"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(375, 192)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(109, 13)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Inicio de Cosecha"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(252, 192)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(91, 13)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "Fin de Siembra"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(127, 192)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(105, 13)
        Me.Label27.TabIndex = 48
        Me.Label27.Text = "Inicio de Siembra"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(7, 192)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(115, 13)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Fecha Terminacion"
        '
        'BtnMinistraciones
        '
        Me.BtnMinistraciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinistraciones.Location = New System.Drawing.Point(260, 153)
        Me.BtnMinistraciones.Name = "BtnMinistraciones"
        Me.BtnMinistraciones.Size = New System.Drawing.Size(116, 23)
        Me.BtnMinistraciones.TabIndex = 71
        Me.BtnMinistraciones.Text = "Ministraciones"
        Me.BtnMinistraciones.UseVisualStyleBackColor = True
        '
        'TxtBuroPM
        '
        Me.TxtBuroPM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "CostoBuroPM", True))
        Me.TxtBuroPM.Location = New System.Drawing.Point(624, 38)
        Me.TxtBuroPM.Name = "TxtBuroPM"
        Me.TxtBuroPM.Size = New System.Drawing.Size(116, 20)
        Me.TxtBuroPM.TabIndex = 18
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(621, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(111, 13)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Cuota Buro (PM) $"
        '
        'TxtTonHecta
        '
        Me.TxtTonHecta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "ToneladasHectarea", True))
        Me.TxtTonHecta.Location = New System.Drawing.Point(130, 156)
        Me.TxtTonHecta.Name = "TxtTonHecta"
        Me.TxtTonHecta.Size = New System.Drawing.Size(116, 20)
        Me.TxtTonHecta.TabIndex = 44
        '
        'TxtPrecio
        '
        Me.TxtPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "PrecioTonelada", True))
        Me.TxtPrecio.Location = New System.Drawing.Point(6, 156)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(116, 20)
        Me.TxtPrecio.TabIndex = 43
        '
        'DTDTC
        '
        Me.DTDTC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDTC.Location = New System.Drawing.Point(626, 115)
        Me.DTDTC.Name = "DTDTC"
        Me.DTDTC.Size = New System.Drawing.Size(118, 20)
        Me.DTDTC.TabIndex = 42
        '
        'DTcosechaFin
        '
        Me.DTcosechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTcosechaFin.Location = New System.Drawing.Point(502, 115)
        Me.DTcosechaFin.Name = "DTcosechaFin"
        Me.DTcosechaFin.Size = New System.Drawing.Size(118, 20)
        Me.DTcosechaFin.TabIndex = 41
        '
        'DTcosechaIni
        '
        Me.DTcosechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTcosechaIni.Location = New System.Drawing.Point(378, 115)
        Me.DTcosechaIni.Name = "DTcosechaIni"
        Me.DTcosechaIni.Size = New System.Drawing.Size(118, 20)
        Me.DTcosechaIni.TabIndex = 40
        '
        'DTSiembrafin
        '
        Me.DTSiembrafin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTSiembrafin.Location = New System.Drawing.Point(255, 115)
        Me.DTSiembrafin.Name = "DTSiembrafin"
        Me.DTSiembrafin.Size = New System.Drawing.Size(118, 20)
        Me.DTSiembrafin.TabIndex = 39
        '
        'DTSiembraini
        '
        Me.DTSiembraini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTSiembraini.Location = New System.Drawing.Point(130, 115)
        Me.DTSiembraini.Name = "DTSiembraini"
        Me.DTSiembraini.Size = New System.Drawing.Size(118, 20)
        Me.DTSiembraini.TabIndex = 38
        '
        'DTTermina
        '
        Me.DTTermina.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTTermina.Location = New System.Drawing.Point(6, 115)
        Me.DTTermina.Name = "DTTermina"
        Me.DTTermina.Size = New System.Drawing.Size(118, 20)
        Me.DTTermina.TabIndex = 37
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(130, 140)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 13)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Ton. x Hecta. $"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 140)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 13)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Precio x Ton. $"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(627, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 13)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Limite DTC"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(500, 99)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 13)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Fin de Cosecha"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(375, 99)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Inicio de Cosecha"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(252, 99)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Fin de Siembra"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(127, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Inicio de Siembra"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Fecha Terminacion"
        '
        'TxtMax
        '
        Me.TxtMax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "TasaMax", True))
        Me.TxtMax.Location = New System.Drawing.Point(502, 76)
        Me.TxtMax.Name = "TxtMax"
        Me.TxtMax.Size = New System.Drawing.Size(116, 20)
        Me.TxtMax.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(499, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Diferencial Max"
        '
        'TxtMin
        '
        Me.TxtMin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "TasaMin", True))
        Me.TxtMin.Location = New System.Drawing.Point(378, 76)
        Me.TxtMin.Name = "TxtMin"
        Me.TxtMin.Size = New System.Drawing.Size(116, 20)
        Me.TxtMin.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(375, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Diferencial Min"
        '
        'TxtTasa
        '
        Me.TxtTasa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "Tasa", True))
        Me.TxtTasa.Location = New System.Drawing.Point(255, 76)
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.Size = New System.Drawing.Size(116, 20)
        Me.TxtTasa.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(251, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Diferencial Default"
        '
        'TxtSegAgri
        '
        Me.TxtSegAgri.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "SeguroAgricolaHecta", True))
        Me.TxtSegAgri.Location = New System.Drawing.Point(130, 76)
        Me.TxtSegAgri.Name = "TxtSegAgri"
        Me.TxtSegAgri.Size = New System.Drawing.Size(116, 20)
        Me.TxtSegAgri.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(129, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Seg. Agricola $/Ha."
        '
        'TxtSegVid
        '
        Me.TxtSegVid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "SeguroVida", True))
        Me.TxtSegVid.Location = New System.Drawing.Point(8, 76)
        Me.TxtSegVid.Name = "TxtSegVid"
        Me.TxtSegVid.Size = New System.Drawing.Size(116, 20)
        Me.TxtSegVid.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Seg. Vida (al millar)"
        '
        'TxtBuro
        '
        Me.TxtBuro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "CostoBuro", True))
        Me.TxtBuro.Location = New System.Drawing.Point(502, 38)
        Me.TxtBuro.Name = "TxtBuro"
        Me.TxtBuro.Size = New System.Drawing.Size(116, 20)
        Me.TxtBuro.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(499, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Cuota Buro (PF) $"
        '
        'TxtComis
        '
        Me.TxtComis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "PorcComision", True))
        Me.TxtComis.Location = New System.Drawing.Point(378, 38)
        Me.TxtComis.Name = "TxtComis"
        Me.TxtComis.Size = New System.Drawing.Size(116, 20)
        Me.TxtComis.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(375, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 26)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Comi. X Dispos %. (Propios)"
        '
        'TxtGtosAdmin
        '
        Me.TxtGtosAdmin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "GastosAdmin", True))
        Me.TxtGtosAdmin.Location = New System.Drawing.Point(254, 38)
        Me.TxtGtosAdmin.Name = "TxtGtosAdmin"
        Me.TxtGtosAdmin.Size = New System.Drawing.Size(116, 20)
        Me.TxtGtosAdmin.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(252, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 27)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Gtos. X Apertura $ (Fira)"
        '
        'TxtGtosHecta
        '
        Me.TxtGtosHecta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "GastosAdminHecta", True))
        Me.TxtGtosHecta.Location = New System.Drawing.Point(130, 38)
        Me.TxtGtosHecta.Name = "TxtGtosHecta"
        Me.TxtGtosHecta.Size = New System.Drawing.Size(116, 20)
        Me.TxtGtosHecta.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(129, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Gtos. Admin. $/Ha."
        '
        'TxtCuota
        '
        Me.TxtCuota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "CuotaHectarea", True))
        Me.TxtCuota.Location = New System.Drawing.Point(6, 38)
        Me.TxtCuota.Name = "TxtCuota"
        Me.TxtCuota.Size = New System.Drawing.Size(116, 20)
        Me.TxtCuota.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cuota $/Ha."
        '
        'Txtid
        '
        Me.Txtid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosBindingSource, "ID_parametro", True))
        Me.Txtid.Location = New System.Drawing.Point(588, 76)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.ReadOnly = True
        Me.Txtid.Size = New System.Drawing.Size(30, 20)
        Me.Txtid.TabIndex = 28
        '
        'BttSave
        '
        Me.BttSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttSave.Location = New System.Drawing.Point(644, 436)
        Me.BttSave.Name = "BttSave"
        Me.BttSave.Size = New System.Drawing.Size(116, 23)
        Me.BttSave.TabIndex = 72
        Me.BttSave.Text = "Guardar Datos"
        Me.BttSave.UseVisualStyleBackColor = True
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
        '
        'FrmParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 466)
        Me.Controls.Add(Me.BttSave)
        Me.Controls.Add(Me.GroupDatos)
        Me.Controls.Add(Me.CmbCultivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbSucursal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbCiclo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmParametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros Modulo de Avío"
        CType(Me.CiclosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvioDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGCultivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDatos.ResumeLayout(False)
        Me.GroupDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents SegurosDS As Agil.SegurosDS
    Friend WithEvents CiclosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CiclosTableAdapter As Agil.SegurosDSTableAdapters.CiclosTableAdapter
    Friend WithEvents CmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AvioDS As Agil.AviosDSX
    Friend WithEvents CmbCultivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
    Friend WithEvents BttSave As System.Windows.Forms.Button
    Friend WithEvents Txtid As System.Windows.Forms.TextBox
    Friend WithEvents TxtTonHecta As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents DTDTC As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTcosechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTcosechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTSiembrafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTSiembraini As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTTermina As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtBuroPM As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents SucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SucursalesTableAdapter As Agil.AviosDSXTableAdapters.SucursalesTableAdapter
    Friend WithEvents BtnMinistraciones As System.Windows.Forms.Button
    Friend WithEvents DTDTC3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTcosechaFin3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTcosechaIni3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTSiembrafin3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTSiembraini3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTTermina3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents DTDTC2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTcosechaFin2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTcosechaIni2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTSiembrafin2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTSiembraini2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTTermina2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
End Class
