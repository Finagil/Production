<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaLiquidez
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
        Me.Txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.CmbCli = New System.Windows.Forms.ComboBox()
        Me.ContClie1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New Agil.ProductionDataSet()
        Me.ContClie1TableAdapter = New Agil.ProductionDataSetTableAdapters.ContClie1TableAdapter()
        Me.BttNewCli = New System.Windows.Forms.Button()
        Me.Combosol = New System.Windows.Forms.ComboBox()
        Me.PROMSolicitudesLIQBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS = New Agil.PromocionDS()
        Me.lbSol = New System.Windows.Forms.Label()
        Me.BtnNewSol = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpFecSol = New System.Windows.Forms.DateTimePicker()
        Me.PROM_SolicitudesLIQTableAdapter = New Agil.PromocionDSTableAdapters.PROM_SolicitudesLIQTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.LIPlazosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LI_PlazosTableAdapter = New Agil.PromocionDSTableAdapters.LI_PlazosTableAdapter()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.LIPeriodosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LI_PeriodosTableAdapter = New Agil.PromocionDSTableAdapters.LI_PeriodosTableAdapter()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New Agil.PromocionDSTableAdapters.ClientesTableAdapter()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRFC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txtfecnac = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txtedad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.PlazasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PlazasTableAdapter = New Agil.PromocionDSTableAdapters.PlazasTableAdapter()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.PlazasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.DTPIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.TextBox39 = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TextBox40 = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.TextBox42 = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.TextBox43 = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.PromocionDS1 = New Agil.PromocionDS()
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROMSolicitudesLIQBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIPlazosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIPeriodosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlazasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlazasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtfiltro
        '
        Me.Txtfiltro.Location = New System.Drawing.Point(15, 25)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(424, 20)
        Me.Txtfiltro.TabIndex = 60
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
        Me.lblClientes.Location = New System.Drawing.Point(12, 48)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(206, 13)
        Me.lblClientes.TabIndex = 61
        Me.lblClientes.Text = "Selecciona un Cliente de la siguiente Lista"
        '
        'CmbCli
        '
        Me.CmbCli.DataSource = Me.ContClie1BindingSource
        Me.CmbCli.DisplayMember = "Descr"
        Me.CmbCli.Location = New System.Drawing.Point(15, 65)
        Me.CmbCli.MaxDropDownItems = 25
        Me.CmbCli.Name = "CmbCli"
        Me.CmbCli.Size = New System.Drawing.Size(424, 21)
        Me.CmbCli.TabIndex = 62
        Me.CmbCli.ValueMember = "Cliente"
        '
        'ContClie1BindingSource
        '
        Me.ContClie1BindingSource.DataMember = "ContClie1"
        Me.ContClie1BindingSource.DataSource = Me.ProductionDataSet
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContClie1TableAdapter
        '
        Me.ContClie1TableAdapter.ClearBeforeFill = True
        '
        'BttNewCli
        '
        Me.BttNewCli.Location = New System.Drawing.Point(445, 63)
        Me.BttNewCli.Name = "BttNewCli"
        Me.BttNewCli.Size = New System.Drawing.Size(75, 23)
        Me.BttNewCli.TabIndex = 64
        Me.BttNewCli.Text = "Cliente Nvo."
        Me.BttNewCli.UseVisualStyleBackColor = True
        '
        'Combosol
        '
        Me.Combosol.DataSource = Me.PROMSolicitudesLIQBindingSource
        Me.Combosol.DisplayMember = "Id_Solicitud"
        Me.Combosol.Enabled = False
        Me.Combosol.FormattingEnabled = True
        Me.Combosol.Location = New System.Drawing.Point(15, 119)
        Me.Combosol.Name = "Combosol"
        Me.Combosol.Size = New System.Drawing.Size(152, 21)
        Me.Combosol.TabIndex = 65
        Me.Combosol.ValueMember = "Id_Solicitud"
        '
        'PROMSolicitudesLIQBindingSource
        '
        Me.PROMSolicitudesLIQBindingSource.DataMember = "PROM_SolicitudesLIQ"
        Me.PROMSolicitudesLIQBindingSource.DataSource = Me.PromocionDS
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbSol
        '
        Me.lbSol.AutoSize = True
        Me.lbSol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSol.Location = New System.Drawing.Point(12, 102)
        Me.lbSol.Name = "lbSol"
        Me.lbSol.Size = New System.Drawing.Size(58, 13)
        Me.lbSol.TabIndex = 66
        Me.lbSol.Text = "Solicitudes"
        '
        'BtnNewSol
        '
        Me.BtnNewSol.Enabled = False
        Me.BtnNewSol.Location = New System.Drawing.Point(173, 119)
        Me.BtnNewSol.Name = "BtnNewSol"
        Me.BtnNewSol.Size = New System.Drawing.Size(75, 23)
        Me.BtnNewSol.TabIndex = 67
        Me.BtnNewSol.Text = "Nueva Sol."
        Me.BtnNewSol.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Fecha"
        '
        'DtpFecSol
        '
        Me.DtpFecSol.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PROMSolicitudesLIQBindingSource, "Fecha", True))
        Me.DtpFecSol.Enabled = False
        Me.DtpFecSol.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecSol.Location = New System.Drawing.Point(15, 159)
        Me.DtpFecSol.Name = "DtpFecSol"
        Me.DtpFecSol.Size = New System.Drawing.Size(113, 20)
        Me.DtpFecSol.TabIndex = 69
        '
        'PROM_SolicitudesLIQTableAdapter
        '
        Me.PROM_SolicitudesLIQTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(134, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Monto a Financiar"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "MontoFinanciado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextBox1.Location = New System.Drawing.Point(134, 159)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(240, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Plazo"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PROMSolicitudesLIQBindingSource, "Plazo", True))
        Me.ComboBox3.DataSource = Me.LIPlazosBindingSource
        Me.ComboBox3.DisplayMember = "Descripcion"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(243, 159)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox3.TabIndex = 73
        Me.ComboBox3.ValueMember = "Meses"
        '
        'LIPlazosBindingSource
        '
        Me.LIPlazosBindingSource.DataMember = "LI_Plazos"
        Me.LIPlazosBindingSource.DataSource = Me.PromocionDS
        '
        'LI_PlazosTableAdapter
        '
        Me.LI_PlazosTableAdapter.ClearBeforeFill = True
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PROMSolicitudesLIQBindingSource, "Periodicidad", True))
        Me.ComboBox4.DataSource = Me.LIPeriodosBindingSource
        Me.ComboBox4.DisplayMember = "Descripcion"
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(348, 158)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox4.TabIndex = 75
        Me.ComboBox4.ValueMember = "Descripcion"
        '
        'LIPeriodosBindingSource
        '
        Me.LIPeriodosBindingSource.DataMember = "LI_Periodos"
        Me.LIPeriodosBindingSource.DataSource = Me.PromocionDS
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(345, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Periodicidad"
        '
        'LI_PeriodosTableAdapter
        '
        Me.LI_PeriodosTableAdapter.ClearBeforeFill = True
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Descr", True))
        Me.TextBox2.Location = New System.Drawing.Point(15, 199)
        Me.TextBox2.MaxLength = 120
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(327, 20)
        Me.TextBox2.TabIndex = 77
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.PromocionDS
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Nombre"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ComboBox5
        '
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Genero", True))
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.ComboBox5.Location = New System.Drawing.Point(348, 199)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox5.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(345, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Genero"
        '
        'TxtRFC
        '
        Me.TxtRFC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "RFC", True))
        Me.TxtRFC.Location = New System.Drawing.Point(453, 200)
        Me.TxtRFC.Name = "TxtRFC"
        Me.TxtRFC.ReadOnly = True
        Me.TxtRFC.Size = New System.Drawing.Size(112, 20)
        Me.TxtRFC.TabIndex = 81
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(453, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "RFC"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "CURP", True))
        Me.TextBox4.Location = New System.Drawing.Point(571, 199)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(112, 20)
        Me.TextBox4.TabIndex = 83
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(571, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "CURP"
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nacionalidad", True))
        Me.TextBox5.Location = New System.Drawing.Point(689, 199)
        Me.TextBox5.MaxLength = 20
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 85
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(689, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Nacionalidad"
        '
        'Txtfecnac
        '
        Me.Txtfecnac.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "FechaNac", True))
        Me.Txtfecnac.Location = New System.Drawing.Point(795, 199)
        Me.Txtfecnac.Name = "Txtfecnac"
        Me.Txtfecnac.ReadOnly = True
        Me.Txtfecnac.Size = New System.Drawing.Size(100, 20)
        Me.Txtfecnac.TabIndex = 87
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(795, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Fecha de Nac."
        '
        'TextBox7
        '
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "SerieFiel", True))
        Me.TextBox7.Location = New System.Drawing.Point(939, 200)
        Me.TextBox7.MaxLength = 20
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 91
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(939, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "FIEL"
        '
        'Txtedad
        '
        Me.Txtedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Edad", True))
        Me.Txtedad.Location = New System.Drawing.Point(901, 200)
        Me.Txtedad.Name = "Txtedad"
        Me.Txtedad.ReadOnly = True
        Me.Txtedad.Size = New System.Drawing.Size(32, 20)
        Me.Txtedad.TabIndex = 89
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(901, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "Edad"
        '
        'ComboBox6
        '
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PROMSolicitudesLIQBindingSource, "EstadoNacimiento", True))
        Me.ComboBox6.DataSource = Me.PlazasBindingSource
        Me.ComboBox6.DisplayMember = "DescSEPOMEX"
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(1045, 200)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox6.TabIndex = 93
        Me.ComboBox6.ValueMember = "DescSEPOMEX"
        '
        'PlazasBindingSource
        '
        Me.PlazasBindingSource.DataMember = "Plazas"
        Me.PlazasBindingSource.DataSource = Me.PromocionDS
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1042, 186)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "Estado Nac."
        '
        'PlazasTableAdapter
        '
        Me.PlazasTableAdapter.ClearBeforeFill = True
        '
        'TextBox9
        '
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "PaisNacimiento", True))
        Me.TextBox9.Location = New System.Drawing.Point(1150, 200)
        Me.TextBox9.MaxLength = 20
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(110, 20)
        Me.TextBox9.TabIndex = 95
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1150, 186)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "Pais Nac."
        '
        'TextBox10
        '
        Me.TextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Calle", True))
        Me.TextBox10.Location = New System.Drawing.Point(15, 237)
        Me.TextBox10.MaxLength = 80
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(294, 20)
        Me.TextBox10.TabIndex = 97
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 223)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 13)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "Calle"
        '
        'TextBox11
        '
        Me.TextBox11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "NumExt", True))
        Me.TextBox11.Location = New System.Drawing.Point(315, 237)
        Me.TextBox11.MaxLength = 10
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(62, 20)
        Me.TextBox11.TabIndex = 99
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(315, 223)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "No. Exterior"
        '
        'TextBox12
        '
        Me.TextBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "NumInt", True))
        Me.TextBox12.Location = New System.Drawing.Point(383, 237)
        Me.TextBox12.MaxLength = 20
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(62, 20)
        Me.TextBox12.TabIndex = 101
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(383, 223)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 100
        Me.Label18.Text = "No. Interior"
        '
        'TextBox13
        '
        Me.TextBox13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Colonia", True))
        Me.TextBox13.Location = New System.Drawing.Point(451, 237)
        Me.TextBox13.MaxLength = 45
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(233, 20)
        Me.TextBox13.TabIndex = 103
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(451, 223)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 102
        Me.Label19.Text = "Colonia"
        '
        'TextBox14
        '
        Me.TextBox14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Delegacion", True))
        Me.TextBox14.Location = New System.Drawing.Point(690, 237)
        Me.TextBox14.MaxLength = 45
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(129, 20)
        Me.TextBox14.TabIndex = 105
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(690, 223)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 13)
        Me.Label20.TabIndex = 104
        Me.Label20.Text = "Delegación"
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Ciudad", True))
        Me.TextBox15.Location = New System.Drawing.Point(825, 237)
        Me.TextBox15.MaxLength = 45
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(129, 20)
        Me.TextBox15.TabIndex = 107
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(825, 223)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 106
        Me.Label21.Text = "Ciudad"
        '
        'ComboBox7
        '
        Me.ComboBox7.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesBindingSource, "Estado", True))
        Me.ComboBox7.DataSource = Me.PlazasBindingSource1
        Me.ComboBox7.DisplayMember = "DescSEPOMEX"
        Me.ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(960, 237)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox7.TabIndex = 109
        Me.ComboBox7.ValueMember = "DescSEPOMEX"
        '
        'PlazasBindingSource1
        '
        Me.PlazasBindingSource1.DataMember = "Plazas"
        Me.PlazasBindingSource1.DataSource = Me.PromocionDS
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(957, 223)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 108
        Me.Label22.Text = "Estado"
        '
        'TextBox16
        '
        Me.TextBox16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "PaisResidencia", True))
        Me.TextBox16.Location = New System.Drawing.Point(1065, 238)
        Me.TextBox16.MaxLength = 45
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(100, 20)
        Me.TextBox16.TabIndex = 111
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(1065, 224)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 13)
        Me.Label23.TabIndex = 110
        Me.Label23.Text = "Pais Residencia"
        '
        'TextBox17
        '
        Me.TextBox17.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Copos", True))
        Me.TextBox17.Location = New System.Drawing.Point(1171, 238)
        Me.TextBox17.MaxLength = 5
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(89, 20)
        Me.TextBox17.TabIndex = 113
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(1171, 224)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(27, 13)
        Me.Label24.TabIndex = 112
        Me.Label24.Text = "C.P."
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "EntreCalles", True))
        Me.TextBox3.Location = New System.Drawing.Point(15, 277)
        Me.TextBox3.MaxLength = 200
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(294, 20)
        Me.TextBox3.TabIndex = 115
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(15, 263)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 13)
        Me.Label25.TabIndex = 114
        Me.Label25.Text = "Entre calles"
        '
        'TextBox6
        '
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Ocupacion", True))
        Me.TextBox6.Location = New System.Drawing.Point(316, 277)
        Me.TextBox6.MaxLength = 45
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(129, 20)
        Me.TextBox6.TabIndex = 117
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(316, 263)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(59, 13)
        Me.Label26.TabIndex = 116
        Me.Label26.Text = "Ocupación"
        '
        'TextBox8
        '
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "EMail1", True))
        Me.TextBox8.Location = New System.Drawing.Point(451, 277)
        Me.TextBox8.MaxLength = 45
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(194, 20)
        Me.TextBox8.TabIndex = 119
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(451, 263)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 13)
        Me.Label27.TabIndex = 118
        Me.Label27.Text = "Correo"
        '
        'TextBox18
        '
        Me.TextBox18.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Telef1", True))
        Me.TextBox18.Location = New System.Drawing.Point(651, 277)
        Me.TextBox18.MaxLength = 45
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(129, 20)
        Me.TextBox18.TabIndex = 121
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(651, 263)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(76, 13)
        Me.Label28.TabIndex = 120
        Me.Label28.Text = "Telefono Casa"
        '
        'TextBox19
        '
        Me.TextBox19.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Telef2", True))
        Me.TextBox19.Location = New System.Drawing.Point(786, 277)
        Me.TextBox19.MaxLength = 45
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(129, 20)
        Me.TextBox19.TabIndex = 123
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(786, 263)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(85, 13)
        Me.Label29.TabIndex = 122
        Me.Label29.Text = "Telefono Oficina"
        '
        'TextBox20
        '
        Me.TextBox20.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Telef3", True))
        Me.TextBox20.Location = New System.Drawing.Point(921, 277)
        Me.TextBox20.MaxLength = 45
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(129, 20)
        Me.TextBox20.TabIndex = 125
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(921, 263)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(39, 13)
        Me.Label30.TabIndex = 124
        Me.Label30.Text = "Celular"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(1056, 263)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(51, 13)
        Me.Label31.TabIndex = 126
        Me.Label31.Text = "Edo. Civil"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "EstadoCivil", True))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SOLTERO", "CASADO"})
        Me.ComboBox1.Location = New System.Drawing.Point(1056, 276)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox1.TabIndex = 127
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "RegimenConyugal", True))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"NO APLICA", "SOCIEDAD CONYUGAL", "SEPARACION DE BIENES"})
        Me.ComboBox2.Location = New System.Drawing.Point(1161, 276)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox2.TabIndex = 129
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(1161, 263)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(49, 13)
        Me.Label32.TabIndex = 128
        Me.Label32.Text = "Regimen"
        '
        'TextBox21
        '
        Me.TextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "OcupacionConyuge", True))
        Me.TextBox21.Location = New System.Drawing.Point(316, 313)
        Me.TextBox21.MaxLength = 45
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(129, 20)
        Me.TextBox21.TabIndex = 133
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(316, 299)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(104, 13)
        Me.Label33.TabIndex = 132
        Me.Label33.Text = "Ocupación Conyuge"
        '
        'TextBox22
        '
        Me.TextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "NombreConyuge", True))
        Me.TextBox22.Location = New System.Drawing.Point(15, 313)
        Me.TextBox22.MaxLength = 200
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(294, 20)
        Me.TextBox22.TabIndex = 131
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(15, 299)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(89, 13)
        Me.Label34.TabIndex = 130
        Me.Label34.Text = "Nombre Conyuge"
        '
        'TextBox23
        '
        Me.TextBox23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "DepenEco", True))
        Me.TextBox23.Location = New System.Drawing.Point(451, 313)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(55, 20)
        Me.TextBox23.TabIndex = 135
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(451, 299)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(55, 13)
        Me.Label35.TabIndex = 134
        Me.Label35.Text = "Dep. Eco."
        '
        'TextBox24
        '
        Me.TextBox24.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Edades", True))
        Me.TextBox24.Location = New System.Drawing.Point(512, 313)
        Me.TextBox24.MaxLength = 25
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(129, 20)
        Me.TextBox24.TabIndex = 137
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(512, 299)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(43, 13)
        Me.Label36.TabIndex = 136
        Me.Label36.Text = "Edades"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PROMSolicitudesLIQBindingSource, "CargoPublico", True))
        Me.CheckBox1.Location = New System.Drawing.Point(648, 315)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox1.TabIndex = 138
        Me.CheckBox1.Text = "Cargo Público"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox8
        '
        Me.ComboBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Genero", True))
        Me.ComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"N/A", "LOCAL", "ESTATAL", "FEDERAL"})
        Me.ComboBox8.Location = New System.Drawing.Point(746, 312)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox8.TabIndex = 140
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(743, 298)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(31, 13)
        Me.Label37.TabIndex = 139
        Me.Label37.Text = "Nivel"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PROMSolicitudesLIQBindingSource, "ResidenciaExtranjero", True))
        Me.CheckBox2.Location = New System.Drawing.Point(851, 315)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(100, 17)
        Me.CheckBox2.TabIndex = 141
        Me.CheckBox2.Text = "Residencia Ext."
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TextBox25
        '
        Me.TextBox25.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "DomExtranjero", True))
        Me.TextBox25.Location = New System.Drawing.Point(957, 315)
        Me.TextBox25.MaxLength = 150
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(303, 20)
        Me.TextBox25.TabIndex = 143
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(957, 301)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(70, 13)
        Me.Label38.TabIndex = 142
        Me.Label38.Text = "Domicilio Ext."
        '
        'TextBox26
        '
        Me.TextBox26.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox26.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Empresa", True))
        Me.TextBox26.Location = New System.Drawing.Point(15, 349)
        Me.TextBox26.MaxLength = 45
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(211, 20)
        Me.TextBox26.TabIndex = 145
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(15, 335)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(48, 13)
        Me.Label39.TabIndex = 144
        Me.Label39.Text = "Empresa"
        '
        'TextBox27
        '
        Me.TextBox27.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox27.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Planta", True))
        Me.TextBox27.Location = New System.Drawing.Point(231, 349)
        Me.TextBox27.MaxLength = 45
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(211, 20)
        Me.TextBox27.TabIndex = 147
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(231, 335)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(37, 13)
        Me.Label40.TabIndex = 146
        Me.Label40.Text = "Planta"
        '
        'TextBox28
        '
        Me.TextBox28.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox28.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Puesto", True))
        Me.TextBox28.Location = New System.Drawing.Point(448, 349)
        Me.TextBox28.MaxLength = 45
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(208, 20)
        Me.TextBox28.TabIndex = 149
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(445, 335)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(40, 13)
        Me.Label41.TabIndex = 148
        Me.Label41.Text = "Puesto"
        '
        'DTPIngreso
        '
        Me.DTPIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PROMSolicitudesLIQBindingSource, "FechaIngreso", True))
        Me.DTPIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPIngreso.Location = New System.Drawing.Point(662, 349)
        Me.DTPIngreso.Name = "DTPIngreso"
        Me.DTPIngreso.Size = New System.Drawing.Size(113, 20)
        Me.DTPIngreso.TabIndex = 151
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(659, 333)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(75, 13)
        Me.Label42.TabIndex = 150
        Me.Label42.Text = "Fecha Ingreso"
        '
        'TextBox29
        '
        Me.TextBox29.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox29.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Telefono", True))
        Me.TextBox29.Location = New System.Drawing.Point(781, 349)
        Me.TextBox29.MaxLength = 45
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(134, 20)
        Me.TextBox29.TabIndex = 153
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(781, 335)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(49, 13)
        Me.Label43.TabIndex = 152
        Me.Label43.Text = "Telefono"
        '
        'TextBox30
        '
        Me.TextBox30.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox30.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Correo", True))
        Me.TextBox30.Location = New System.Drawing.Point(921, 349)
        Me.TextBox30.MaxLength = 45
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(339, 20)
        Me.TextBox30.TabIndex = 155
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(921, 335)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(38, 13)
        Me.Label44.TabIndex = 154
        Me.Label44.Text = "Correo"
        '
        'TextBox31
        '
        Me.TextBox31.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "DestinoCredito", True))
        Me.TextBox31.Location = New System.Drawing.Point(15, 388)
        Me.TextBox31.MaxLength = 150
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(432, 20)
        Me.TextBox31.TabIndex = 157
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(15, 374)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(96, 13)
        Me.Label45.TabIndex = 156
        Me.Label45.Text = "Destino del Credito"
        '
        'TextBox32
        '
        Me.TextBox32.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox32.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "FuenteIngresos", True))
        Me.TextBox32.Location = New System.Drawing.Point(453, 388)
        Me.TextBox32.MaxLength = 50
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(211, 20)
        Me.TextBox32.TabIndex = 159
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(453, 374)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(141, 13)
        Me.Label46.TabIndex = 158
        Me.Label46.Text = "Principal Fuente de Ingresos"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PROMSolicitudesLIQBindingSource, "OtrosIngresos", True))
        Me.CheckBox3.Location = New System.Drawing.Point(670, 390)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox3.TabIndex = 160
        Me.CheckBox3.Text = "Otros Ingresos"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TextBox33
        '
        Me.TextBox33.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox33.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "QueOtrosIngresos", True))
        Me.TextBox33.Location = New System.Drawing.Point(766, 387)
        Me.TextBox33.MaxLength = 50
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(129, 20)
        Me.TextBox33.TabIndex = 162
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(766, 373)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(75, 13)
        Me.Label47.TabIndex = 161
        Me.Label47.Text = "Otros Ingresos"
        '
        'TextBox34
        '
        Me.TextBox34.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox34.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Montos", True))
        Me.TextBox34.Location = New System.Drawing.Point(995, 387)
        Me.TextBox34.MaxLength = 50
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(129, 20)
        Me.TextBox34.TabIndex = 166
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(995, 373)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(83, 13)
        Me.Label48.TabIndex = 163
        Me.Label48.Text = "Monto Adicional"
        '
        'TextBox35
        '
        Me.TextBox35.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox35.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Fechas", True))
        Me.TextBox35.Location = New System.Drawing.Point(1130, 388)
        Me.TextBox35.MaxLength = 50
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(129, 20)
        Me.TextBox35.TabIndex = 168
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(1130, 374)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(99, 13)
        Me.Label49.TabIndex = 165
        Me.Label49.Text = "Fechas Adicionales"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PROMSolicitudesLIQBindingSource, "OtrosIngresos", True))
        Me.CheckBox4.Location = New System.Drawing.Point(901, 387)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox4.TabIndex = 164
        Me.CheckBox4.Text = "Aportaciones"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PROMSolicitudesLIQBindingSource, "FechaBC", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(15, 427)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(113, 20)
        Me.DateTimePicker1.TabIndex = 170
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Enabled = False
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(12, 411)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(54, 13)
        Me.Label50.TabIndex = 169
        Me.Label50.Text = "Fecha BC"
        '
        'TextBox36
        '
        Me.TextBox36.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox36.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "FolioBC", True))
        Me.TextBox36.Location = New System.Drawing.Point(134, 427)
        Me.TextBox36.MaxLength = 45
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(129, 20)
        Me.TextBox36.TabIndex = 172
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(134, 413)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(46, 13)
        Me.Label51.TabIndex = 171
        Me.Label51.Text = "Folio BC"
        '
        'TextBox37
        '
        Me.TextBox37.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox37.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "FolioCC", True))
        Me.TextBox37.Location = New System.Drawing.Point(269, 427)
        Me.TextBox37.MaxLength = 45
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(129, 20)
        Me.TextBox37.TabIndex = 174
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(269, 413)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(46, 13)
        Me.Label52.TabIndex = 173
        Me.Label52.Text = "Folio CC"
        '
        'TextBox38
        '
        Me.TextBox38.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox38.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "RefTel1", True))
        Me.TextBox38.Location = New System.Drawing.Point(836, 427)
        Me.TextBox38.MaxLength = 45
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(208, 20)
        Me.TextBox38.TabIndex = 180
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(833, 413)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(113, 13)
        Me.Label53.TabIndex = 179
        Me.Label53.Text = "Telefono Referencia 1"
        '
        'TextBox39
        '
        Me.TextBox39.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox39.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "RefDom1", True))
        Me.TextBox39.Location = New System.Drawing.Point(619, 427)
        Me.TextBox39.MaxLength = 45
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(211, 20)
        Me.TextBox39.TabIndex = 178
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(619, 413)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(113, 13)
        Me.Label54.TabIndex = 177
        Me.Label54.Text = "Domicilio Referencia 1"
        '
        'TextBox40
        '
        Me.TextBox40.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox40.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "RefNom1", True))
        Me.TextBox40.Location = New System.Drawing.Point(403, 427)
        Me.TextBox40.MaxLength = 45
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(211, 20)
        Me.TextBox40.TabIndex = 176
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(403, 413)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(108, 13)
        Me.Label55.TabIndex = 175
        Me.Label55.Text = "Nombre Referencia 1"
        '
        'TextBox41
        '
        Me.TextBox41.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox41.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "RefTel2", True))
        Me.TextBox41.Location = New System.Drawing.Point(448, 465)
        Me.TextBox41.MaxLength = 45
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New System.Drawing.Size(208, 20)
        Me.TextBox41.TabIndex = 186
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(445, 451)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(113, 13)
        Me.Label56.TabIndex = 185
        Me.Label56.Text = "Telefono Referencia 2"
        '
        'TextBox42
        '
        Me.TextBox42.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox42.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "RefDom2", True))
        Me.TextBox42.Location = New System.Drawing.Point(231, 465)
        Me.TextBox42.MaxLength = 45
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New System.Drawing.Size(211, 20)
        Me.TextBox42.TabIndex = 184
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(231, 451)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(113, 13)
        Me.Label57.TabIndex = 183
        Me.Label57.Text = "Domicilio Referencia 2"
        '
        'TextBox43
        '
        Me.TextBox43.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox43.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "RefNom2", True))
        Me.TextBox43.Location = New System.Drawing.Point(15, 465)
        Me.TextBox43.MaxLength = 45
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New System.Drawing.Size(211, 20)
        Me.TextBox43.TabIndex = 182
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(15, 451)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(108, 13)
        Me.Label58.TabIndex = 181
        Me.Label58.Text = "Nombre Referencia 2"
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(665, 462)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 187
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Enabled = False
        Me.BtnPrint.Location = New System.Drawing.Point(744, 462)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrint.TabIndex = 188
        Me.BtnPrint.Text = "Imprimir"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'PromocionDS1
        '
        Me.PromocionDS1.DataSetName = "PromocionDS"
        Me.PromocionDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrmAltaLiquidez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 493)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TextBox41)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.TextBox42)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.TextBox43)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.TextBox38)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.TextBox39)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.TextBox40)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.TextBox37)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.TextBox36)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.TextBox35)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.TextBox34)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.TextBox33)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.TextBox32)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.TextBox31)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.TextBox30)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.TextBox29)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.DTPIngreso)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.TextBox28)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.TextBox27)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.TextBox26)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.TextBox25)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.ComboBox8)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox24)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.TextBox23)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.TextBox21)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.TextBox22)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Txtedad)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Txtfecnac)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtRFC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DtpFecSol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnNewSol)
        Me.Controls.Add(Me.lbSol)
        Me.Controls.Add(Me.Combosol)
        Me.Controls.Add(Me.BttNewCli)
        Me.Controls.Add(Me.Txtfiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.CmbCli)
        Me.Name = "FrmAltaLiquidez"
        Me.Text = "Solicitud de Financiamiento (Liquidez Inmediata)"
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROMSolicitudesLIQBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIPlazosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIPeriodosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlazasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlazasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtfiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClientes As Label
    Friend WithEvents CmbCli As ComboBox
    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents ContClie1BindingSource As BindingSource
    Friend WithEvents ContClie1TableAdapter As ProductionDataSetTableAdapters.ContClie1TableAdapter
    Friend WithEvents BttNewCli As Button
    Friend WithEvents Combosol As ComboBox
    Friend WithEvents lbSol As Label
    Friend WithEvents BtnNewSol As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpFecSol As DateTimePicker
    Friend WithEvents PROMSolicitudesLIQBindingSource As BindingSource
    Friend WithEvents PromocionDS As PromocionDS
    Friend WithEvents PROM_SolicitudesLIQTableAdapter As PromocionDSTableAdapters.PROM_SolicitudesLIQTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents LIPlazosBindingSource As BindingSource
    Friend WithEvents LI_PlazosTableAdapter As PromocionDSTableAdapters.LI_PlazosTableAdapter
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LIPeriodosBindingSource As BindingSource
    Friend WithEvents LI_PeriodosTableAdapter As PromocionDSTableAdapters.LI_PeriodosTableAdapter
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents Label6 As Label
    Friend WithEvents ClientesTableAdapter As PromocionDSTableAdapters.ClientesTableAdapter
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtRFC As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txtfecnac As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Txtedad As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PlazasBindingSource As BindingSource
    Friend WithEvents PlazasTableAdapter As PromocionDSTableAdapters.PlazasTableAdapter
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents TextBox28 As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents DTPIngreso As DateTimePicker
    Friend WithEvents Label42 As Label
    Friend WithEvents TextBox29 As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents TextBox30 As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents TextBox31 As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents TextBox32 As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents TextBox34 As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents TextBox35 As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label50 As Label
    Friend WithEvents TextBox36 As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents TextBox37 As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents TextBox38 As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents TextBox39 As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents TextBox40 As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents TextBox41 As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents TextBox42 As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents TextBox43 As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents PromocionDS1 As PromocionDS
    Friend WithEvents PlazasBindingSource1 As BindingSource
End Class
