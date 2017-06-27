<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModCtoAvio
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
        Me.dtpFechaAutorizacion = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHectareasActual = New System.Windows.Forms.TextBox()
        Me.gbDatosFINAGIL = New System.Windows.Forms.GroupBox()
        Me.CmbZ08 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbZ25 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSustraeActual = New System.Windows.Forms.TextBox()
        Me.txtCostoHectarea = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDiferencialFINAGIL = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbEstratoActual = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtLineaActual = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.gbDatosFIRA = New System.Windows.Forms.GroupBox()
        Me.CmbLocaInver = New System.Windows.Forms.ComboBox()
        Me.FiraDatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AviosDSX1 = New Agil.AviosDSX()
        Me.locaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AviosDSX2 = New Agil.AviosDSX()
        Me.CmbMuniInver = New System.Windows.Forms.ComboBox()
        Me.MuniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbEdoInver = New System.Windows.Forms.ComboBox()
        Me.EdosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Txringresos = New System.Windows.Forms.TextBox()
        Me.CmbLocaAcre = New System.Windows.Forms.ComboBox()
        Me.FIRALocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbMuniAcre = New System.Windows.Forms.ComboBox()
        Me.FIRAMunicipiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbBEdoAcre = New System.Windows.Forms.ComboBox()
        Me.FIRAEstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CkGarantiaSinFondeo = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtGarantia = New System.Windows.Forms.DateTimePicker()
        Me.TxtIDgarantia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtIDDTU = New System.Windows.Forms.TextBox()
        Me.txtIDCredito = New System.Windows.Forms.TextBox()
        Me.txtIDContrato = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIDPersona = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtAnexo = New System.Windows.Forms.TextBox()
        Me.BtnRefa = New System.Windows.Forms.Button()
        Me.BtnOnbase = New System.Windows.Forms.Button()
        Me.TxtContMarco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FirA_AnexosDatosTableAdapter1 = New Agil.AviosDSXTableAdapters.FIRA_AnexosDatosTableAdapter()
        Me.FIRA_EstadosTableAdapter = New Agil.AviosDSXTableAdapters.FIRA_EstadosTableAdapter()
        Me.FIRA_MunicipiosTableAdapter = New Agil.AviosDSXTableAdapters.FIRA_MunicipiosTableAdapter()
        Me.FIRA_LocalidadesTableAdapter = New Agil.AviosDSXTableAdapters.FIRA_LocalidadesTableAdapter()
        Me.gbDatosFINAGIL.SuspendLayout()
        Me.gbDatosFIRA.SuspendLayout()
        CType(Me.FiraDatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosDSX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosDSX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FIRALocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FIRAMunicipiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FIRAEstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFechaAutorizacion
        '
        Me.dtpFechaAutorizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAutorizacion.Location = New System.Drawing.Point(220, 30)
        Me.dtpFechaAutorizacion.Name = "dtpFechaAutorizacion"
        Me.dtpFechaAutorizacion.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaAutorizacion.TabIndex = 71
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 16)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "No. de Hectáreas"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHectareasActual
        '
        Me.txtHectareasActual.Location = New System.Drawing.Point(206, 82)
        Me.txtHectareasActual.Name = "txtHectareasActual"
        Me.txtHectareasActual.Size = New System.Drawing.Size(100, 20)
        Me.txtHectareasActual.TabIndex = 86
        Me.txtHectareasActual.Text = "0"
        Me.txtHectareasActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbDatosFINAGIL
        '
        Me.gbDatosFINAGIL.Controls.Add(Me.CmbZ08)
        Me.gbDatosFINAGIL.Controls.Add(Me.Label6)
        Me.gbDatosFINAGIL.Controls.Add(Me.cbZ25)
        Me.gbDatosFINAGIL.Controls.Add(Me.Label1)
        Me.gbDatosFINAGIL.Controls.Add(Me.txtSustraeActual)
        Me.gbDatosFINAGIL.Controls.Add(Me.txtCostoHectarea)
        Me.gbDatosFINAGIL.Controls.Add(Me.Label18)
        Me.gbDatosFINAGIL.Controls.Add(Me.txtDiferencialFINAGIL)
        Me.gbDatosFINAGIL.Controls.Add(Me.Label25)
        Me.gbDatosFINAGIL.Controls.Add(Me.Label26)
        Me.gbDatosFINAGIL.Controls.Add(Me.Label27)
        Me.gbDatosFINAGIL.Controls.Add(Me.Label24)
        Me.gbDatosFINAGIL.Controls.Add(Me.Label2)
        Me.gbDatosFINAGIL.Controls.Add(Me.Label10)
        Me.gbDatosFINAGIL.Controls.Add(Me.txtHectareasActual)
        Me.gbDatosFINAGIL.Controls.Add(Me.dtpFechaAutorizacion)
        Me.gbDatosFINAGIL.Controls.Add(Me.cbEstratoActual)
        Me.gbDatosFINAGIL.Controls.Add(Me.Label15)
        Me.gbDatosFINAGIL.Controls.Add(Me.Label17)
        Me.gbDatosFINAGIL.Controls.Add(Me.txtLineaActual)
        Me.gbDatosFINAGIL.Controls.Add(Me.Label19)
        Me.gbDatosFINAGIL.Controls.Add(Me.Label20)
        Me.gbDatosFINAGIL.Location = New System.Drawing.Point(52, 71)
        Me.gbDatosFINAGIL.Name = "gbDatosFINAGIL"
        Me.gbDatosFINAGIL.Size = New System.Drawing.Size(395, 490)
        Me.gbDatosFINAGIL.TabIndex = 73
        Me.gbDatosFINAGIL.TabStop = False
        Me.gbDatosFINAGIL.Text = "Datos en FINAGIL"
        '
        'CmbZ08
        '
        Me.CmbZ08.FormattingEnabled = True
        Me.CmbZ08.Location = New System.Drawing.Point(113, 248)
        Me.CmbZ08.Name = "CmbZ08"
        Me.CmbZ08.Size = New System.Drawing.Size(44, 21)
        Me.CmbZ08.TabIndex = 106
        Me.CmbZ08.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Apoyo Z08"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbZ25
        '
        Me.cbZ25.FormattingEnabled = True
        Me.cbZ25.Location = New System.Drawing.Point(113, 225)
        Me.cbZ25.Name = "cbZ25"
        Me.cbZ25.Size = New System.Drawing.Size(44, 21)
        Me.cbZ25.TabIndex = 104
        Me.cbZ25.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Apoyo Z25"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSustraeActual
        '
        Me.txtSustraeActual.Location = New System.Drawing.Point(98, 338)
        Me.txtSustraeActual.Name = "txtSustraeActual"
        Me.txtSustraeActual.ReadOnly = True
        Me.txtSustraeActual.Size = New System.Drawing.Size(32, 20)
        Me.txtSustraeActual.TabIndex = 102
        Me.txtSustraeActual.TabStop = False
        Me.txtSustraeActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostoHectarea
        '
        Me.txtCostoHectarea.Location = New System.Drawing.Point(206, 108)
        Me.txtCostoHectarea.Name = "txtCostoHectarea"
        Me.txtCostoHectarea.Size = New System.Drawing.Size(100, 20)
        Me.txtCostoHectarea.TabIndex = 101
        Me.txtCostoHectarea.Text = "0.00"
        Me.txtCostoHectarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(16, 134)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(240, 17)
        Me.Label18.TabIndex = 100
        Me.Label18.Text = "Diferencial FINAGIL-Productor"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiferencialFINAGIL
        '
        Me.txtDiferencialFINAGIL.Location = New System.Drawing.Point(263, 134)
        Me.txtDiferencialFINAGIL.Name = "txtDiferencialFINAGIL"
        Me.txtDiferencialFINAGIL.Size = New System.Drawing.Size(43, 20)
        Me.txtDiferencialFINAGIL.TabIndex = 99
        Me.txtDiferencialFINAGIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(98, 445)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(271, 18)
        Me.Label25.TabIndex = 98
        Me.Label25.Text = "SI = Consultado y sí tiene Antecedentes negativos"
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(98, 410)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(271, 18)
        Me.Label26.TabIndex = 97
        Me.Label26.Text = "NO = Consultado y no tiene Antecedentes negativos"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(98, 380)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(271, 18)
        Me.Label27.TabIndex = 96
        Me.Label27.Text = "NC = No Consultado"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(98, 300)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(165, 18)
        Me.Label24.TabIndex = 93
        Me.Label24.Text = "Estrato NE = No Estratificado"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 16)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Costo por Hectárea"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbEstratoActual
        '
        Me.cbEstratoActual.FormattingEnabled = True
        Me.cbEstratoActual.Location = New System.Drawing.Point(98, 275)
        Me.cbEstratoActual.Name = "cbEstratoActual"
        Me.cbEstratoActual.Size = New System.Drawing.Size(59, 21)
        Me.cbEstratoActual.TabIndex = 76
        Me.cbEstratoActual.TabStop = False
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(16, 339)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 19)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "SUSTRAE"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(16, 276)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 19)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Estrato"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLineaActual
        '
        Me.txtLineaActual.Location = New System.Drawing.Point(206, 56)
        Me.txtLineaActual.Name = "txtLineaActual"
        Me.txtLineaActual.Size = New System.Drawing.Size(100, 20)
        Me.txtLineaActual.TabIndex = 72
        Me.txtLineaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(16, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 19)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "Línea autorizada"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(16, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(118, 19)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Fecha de Autorización"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbDatosFIRA
        '
        Me.gbDatosFIRA.Controls.Add(Me.CmbLocaInver)
        Me.gbDatosFIRA.Controls.Add(Me.CmbMuniInver)
        Me.gbDatosFIRA.Controls.Add(Me.CmbEdoInver)
        Me.gbDatosFIRA.Controls.Add(Me.Txringresos)
        Me.gbDatosFIRA.Controls.Add(Me.CmbLocaAcre)
        Me.gbDatosFIRA.Controls.Add(Me.CmbMuniAcre)
        Me.gbDatosFIRA.Controls.Add(Me.CbBEdoAcre)
        Me.gbDatosFIRA.Controls.Add(Me.Label16)
        Me.gbDatosFIRA.Controls.Add(Me.Label22)
        Me.gbDatosFIRA.Controls.Add(Me.Label23)
        Me.gbDatosFIRA.Controls.Add(Me.Label13)
        Me.gbDatosFIRA.Controls.Add(Me.Label12)
        Me.gbDatosFIRA.Controls.Add(Me.Label9)
        Me.gbDatosFIRA.Controls.Add(Me.Label7)
        Me.gbDatosFIRA.Controls.Add(Me.CkGarantiaSinFondeo)
        Me.gbDatosFIRA.Controls.Add(Me.Label4)
        Me.gbDatosFIRA.Controls.Add(Me.DtGarantia)
        Me.gbDatosFIRA.Controls.Add(Me.TxtIDgarantia)
        Me.gbDatosFIRA.Controls.Add(Me.Label3)
        Me.gbDatosFIRA.Controls.Add(Me.Label21)
        Me.gbDatosFIRA.Controls.Add(Me.txtIDDTU)
        Me.gbDatosFIRA.Controls.Add(Me.txtIDCredito)
        Me.gbDatosFIRA.Controls.Add(Me.txtIDContrato)
        Me.gbDatosFIRA.Controls.Add(Me.Label14)
        Me.gbDatosFIRA.Controls.Add(Me.Label11)
        Me.gbDatosFIRA.Controls.Add(Me.Label8)
        Me.gbDatosFIRA.Controls.Add(Me.txtIDPersona)
        Me.gbDatosFIRA.Location = New System.Drawing.Point(585, 71)
        Me.gbDatosFIRA.Name = "gbDatosFIRA"
        Me.gbDatosFIRA.Size = New System.Drawing.Size(394, 416)
        Me.gbDatosFIRA.TabIndex = 94
        Me.gbDatosFIRA.TabStop = False
        Me.gbDatosFIRA.Text = "Datos en FIRA"
        '
        'CmbLocaInver
        '
        Me.CmbLocaInver.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FiraDatosBindingSource, "LocalidadInversion", True))
        Me.CmbLocaInver.DataSource = Me.locaBindingSource
        Me.CmbLocaInver.DisplayMember = "Localidad"
        Me.CmbLocaInver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLocaInver.FormattingEnabled = True
        Me.CmbLocaInver.Location = New System.Drawing.Point(178, 364)
        Me.CmbLocaInver.Name = "CmbLocaInver"
        Me.CmbLocaInver.Size = New System.Drawing.Size(165, 21)
        Me.CmbLocaInver.TabIndex = 88
        Me.CmbLocaInver.ValueMember = "Cve Loc INEGI"
        '
        'FiraDatosBindingSource
        '
        Me.FiraDatosBindingSource.DataMember = "FIRA_AnexosDatos"
        Me.FiraDatosBindingSource.DataSource = Me.AviosDSX1
        '
        'AviosDSX1
        '
        Me.AviosDSX1.DataSetName = "AviosDSX"
        Me.AviosDSX1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'locaBindingSource
        '
        Me.locaBindingSource.DataMember = "FIRA_Localidades"
        Me.locaBindingSource.DataSource = Me.AviosDSX2
        '
        'AviosDSX2
        '
        Me.AviosDSX2.DataSetName = "AviosDSX"
        Me.AviosDSX2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbMuniInver
        '
        Me.CmbMuniInver.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FiraDatosBindingSource, "MunicipioInversion", True))
        Me.CmbMuniInver.DataSource = Me.MuniBindingSource
        Me.CmbMuniInver.DisplayMember = "Municipio"
        Me.CmbMuniInver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMuniInver.FormattingEnabled = True
        Me.CmbMuniInver.Location = New System.Drawing.Point(178, 337)
        Me.CmbMuniInver.Name = "CmbMuniInver"
        Me.CmbMuniInver.Size = New System.Drawing.Size(165, 21)
        Me.CmbMuniInver.TabIndex = 87
        Me.CmbMuniInver.ValueMember = "Cve Mun INEGI"
        '
        'MuniBindingSource
        '
        Me.MuniBindingSource.DataMember = "FIRA_Municipios"
        Me.MuniBindingSource.DataSource = Me.AviosDSX2
        '
        'CmbEdoInver
        '
        Me.CmbEdoInver.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FiraDatosBindingSource, "EstadoInversion", True))
        Me.CmbEdoInver.DataSource = Me.EdosBindingSource
        Me.CmbEdoInver.DisplayMember = "Estado"
        Me.CmbEdoInver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEdoInver.FormattingEnabled = True
        Me.CmbEdoInver.Location = New System.Drawing.Point(178, 310)
        Me.CmbEdoInver.Name = "CmbEdoInver"
        Me.CmbEdoInver.Size = New System.Drawing.Size(165, 21)
        Me.CmbEdoInver.TabIndex = 86
        Me.CmbEdoInver.ValueMember = "Cve Estado"
        '
        'EdosBindingSource
        '
        Me.EdosBindingSource.DataMember = "FIRA_Estados"
        Me.EdosBindingSource.DataSource = Me.AviosDSX2
        '
        'Txringresos
        '
        Me.Txringresos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FiraDatosBindingSource, "IngresosNetos", True))
        Me.Txringresos.Location = New System.Drawing.Point(178, 284)
        Me.Txringresos.Name = "Txringresos"
        Me.Txringresos.Size = New System.Drawing.Size(116, 20)
        Me.Txringresos.TabIndex = 85
        Me.Txringresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbLocaAcre
        '
        Me.CmbLocaAcre.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FiraDatosBindingSource, "LocalidadAcreditado", True))
        Me.CmbLocaAcre.DataSource = Me.FIRALocalidadesBindingSource
        Me.CmbLocaAcre.DisplayMember = "Localidad"
        Me.CmbLocaAcre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLocaAcre.Enabled = False
        Me.CmbLocaAcre.FormattingEnabled = True
        Me.CmbLocaAcre.Location = New System.Drawing.Point(178, 256)
        Me.CmbLocaAcre.Name = "CmbLocaAcre"
        Me.CmbLocaAcre.Size = New System.Drawing.Size(165, 21)
        Me.CmbLocaAcre.TabIndex = 84
        Me.CmbLocaAcre.ValueMember = "Cve Loc INEGI"
        '
        'FIRALocalidadesBindingSource
        '
        Me.FIRALocalidadesBindingSource.DataMember = "FIRA_Localidades"
        Me.FIRALocalidadesBindingSource.DataSource = Me.AviosDSX1
        '
        'CmbMuniAcre
        '
        Me.CmbMuniAcre.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FiraDatosBindingSource, "MunicipioAcreditado", True))
        Me.CmbMuniAcre.DataSource = Me.FIRAMunicipiosBindingSource
        Me.CmbMuniAcre.DisplayMember = "Municipio"
        Me.CmbMuniAcre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMuniAcre.Enabled = False
        Me.CmbMuniAcre.FormattingEnabled = True
        Me.CmbMuniAcre.Location = New System.Drawing.Point(178, 229)
        Me.CmbMuniAcre.Name = "CmbMuniAcre"
        Me.CmbMuniAcre.Size = New System.Drawing.Size(165, 21)
        Me.CmbMuniAcre.TabIndex = 83
        Me.CmbMuniAcre.ValueMember = "Cve Mun INEGI"
        '
        'FIRAMunicipiosBindingSource
        '
        Me.FIRAMunicipiosBindingSource.DataMember = "FIRA_Municipios"
        Me.FIRAMunicipiosBindingSource.DataSource = Me.AviosDSX1
        '
        'CbBEdoAcre
        '
        Me.CbBEdoAcre.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FiraDatosBindingSource, "EstadoAcreditado", True))
        Me.CbBEdoAcre.DataSource = Me.FIRAEstadosBindingSource
        Me.CbBEdoAcre.DisplayMember = "Estado"
        Me.CbBEdoAcre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbBEdoAcre.Enabled = False
        Me.CbBEdoAcre.FormattingEnabled = True
        Me.CbBEdoAcre.Location = New System.Drawing.Point(178, 201)
        Me.CbBEdoAcre.Name = "CbBEdoAcre"
        Me.CbBEdoAcre.Size = New System.Drawing.Size(165, 21)
        Me.CbBEdoAcre.TabIndex = 82
        Me.CbBEdoAcre.ValueMember = "Cve Estado"
        '
        'FIRAEstadosBindingSource
        '
        Me.FIRAEstadosBindingSource.DataMember = "FIRA_Estados"
        Me.FIRAEstadosBindingSource.DataSource = Me.AviosDSX1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(63, 367)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 13)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "Localidad Inversión"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(63, 340)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 13)
        Me.Label22.TabIndex = 93
        Me.Label22.Text = "Municipio Inversión"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(63, 313)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 13)
        Me.Label23.TabIndex = 92
        Me.Label23.Text = "Estado Inversión"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(63, 287)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Ingresos Netos"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(63, 259)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 13)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Localidad Acreditado"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Municipio Acreditado"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Estado Acreditado"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CkGarantiaSinFondeo
        '
        Me.CkGarantiaSinFondeo.AutoSize = True
        Me.CkGarantiaSinFondeo.Location = New System.Drawing.Point(224, 173)
        Me.CkGarantiaSinFondeo.Name = "CkGarantiaSinFondeo"
        Me.CkGarantiaSinFondeo.Size = New System.Drawing.Size(125, 17)
        Me.CkGarantiaSinFondeo.TabIndex = 81
        Me.CkGarantiaSinFondeo.Text = "Garantía Sin Fondeo"
        Me.CkGarantiaSinFondeo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(123, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 19)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Fecha Garantía"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DtGarantia
        '
        Me.DtGarantia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtGarantia.Location = New System.Drawing.Point(224, 147)
        Me.DtGarantia.Name = "DtGarantia"
        Me.DtGarantia.Size = New System.Drawing.Size(100, 20)
        Me.DtGarantia.TabIndex = 80
        '
        'TxtIDgarantia
        '
        Me.TxtIDgarantia.Location = New System.Drawing.Point(224, 120)
        Me.TxtIDgarantia.Name = "TxtIDgarantia"
        Me.TxtIDgarantia.Size = New System.Drawing.Size(82, 20)
        Me.TxtIDgarantia.TabIndex = 79
        Me.TxtIDgarantia.TabStop = False
        Me.TxtIDgarantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(123, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "ID Garantía"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(123, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 19)
        Me.Label21.TabIndex = 81
        Me.Label21.Text = "ID DTU"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIDDTU
        '
        Me.txtIDDTU.Location = New System.Drawing.Point(224, 67)
        Me.txtIDDTU.Name = "txtIDDTU"
        Me.txtIDDTU.Size = New System.Drawing.Size(82, 20)
        Me.txtIDDTU.TabIndex = 77
        Me.txtIDDTU.TabStop = False
        Me.txtIDDTU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIDCredito
        '
        Me.txtIDCredito.Location = New System.Drawing.Point(224, 93)
        Me.txtIDCredito.Name = "txtIDCredito"
        Me.txtIDCredito.Size = New System.Drawing.Size(82, 20)
        Me.txtIDCredito.TabIndex = 78
        Me.txtIDCredito.TabStop = False
        Me.txtIDCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIDContrato
        '
        Me.txtIDContrato.Location = New System.Drawing.Point(224, 41)
        Me.txtIDContrato.Name = "txtIDContrato"
        Me.txtIDContrato.Size = New System.Drawing.Size(82, 20)
        Me.txtIDContrato.TabIndex = 76
        Me.txtIDContrato.TabStop = False
        Me.txtIDContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(123, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 19)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "ID Crédito"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(123, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 19)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "ID Contrato"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(123, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 19)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "ID Persona"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIDPersona
        '
        Me.txtIDPersona.Location = New System.Drawing.Point(224, 16)
        Me.txtIDPersona.Name = "txtIDPersona"
        Me.txtIDPersona.Size = New System.Drawing.Size(82, 20)
        Me.txtIDPersona.TabIndex = 75
        Me.txtIDPersona.TabStop = False
        Me.txtIDPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(789, 538)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 89
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(904, 538)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 96
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtAnexo
        '
        Me.txtAnexo.Location = New System.Drawing.Point(52, 45)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.ReadOnly = True
        Me.txtAnexo.Size = New System.Drawing.Size(927, 20)
        Me.txtAnexo.TabIndex = 97
        '
        'BtnRefa
        '
        Me.BtnRefa.Location = New System.Drawing.Point(632, 538)
        Me.BtnRefa.Name = "BtnRefa"
        Me.BtnRefa.Size = New System.Drawing.Size(100, 23)
        Me.BtnRefa.TabIndex = 98
        Me.BtnRefa.Text = "Garantias"
        Me.BtnRefa.UseVisualStyleBackColor = True
        Me.BtnRefa.Visible = False
        '
        'BtnOnbase
        '
        Me.BtnOnbase.Location = New System.Drawing.Point(495, 538)
        Me.BtnOnbase.Name = "BtnOnbase"
        Me.BtnOnbase.Size = New System.Drawing.Size(104, 24)
        Me.BtnOnbase.TabIndex = 100
        Me.BtnOnbase.Text = "OnBase"
        '
        'TxtContMarco
        '
        Me.TxtContMarco.Location = New System.Drawing.Point(165, 19)
        Me.TxtContMarco.Name = "TxtContMarco"
        Me.TxtContMarco.ReadOnly = True
        Me.TxtContMarco.Size = New System.Drawing.Size(130, 20)
        Me.TxtContMarco.TabIndex = 130
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(46, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "No. de Contrato Marco"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FirA_AnexosDatosTableAdapter1
        '
        Me.FirA_AnexosDatosTableAdapter1.ClearBeforeFill = True
        '
        'FIRA_EstadosTableAdapter
        '
        Me.FIRA_EstadosTableAdapter.ClearBeforeFill = True
        '
        'FIRA_MunicipiosTableAdapter
        '
        Me.FIRA_MunicipiosTableAdapter.ClearBeforeFill = True
        '
        'FIRA_LocalidadesTableAdapter
        '
        Me.FIRA_LocalidadesTableAdapter.ClearBeforeFill = True
        '
        'frmModCtoAvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 702)
        Me.Controls.Add(Me.TxtContMarco)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnOnbase)
        Me.Controls.Add(Me.BtnRefa)
        Me.Controls.Add(Me.txtAnexo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbDatosFIRA)
        Me.Controls.Add(Me.gbDatosFINAGIL)
        Me.Name = "frmModCtoAvio"
        Me.Text = "Modificar Contrato de Avío"
        Me.gbDatosFINAGIL.ResumeLayout(False)
        Me.gbDatosFINAGIL.PerformLayout()
        Me.gbDatosFIRA.ResumeLayout(False)
        Me.gbDatosFIRA.PerformLayout()
        CType(Me.FiraDatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosDSX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosDSX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FIRALocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FIRAMunicipiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FIRAEstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaAutorizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtHectareasActual As System.Windows.Forms.TextBox
    Friend WithEvents gbDatosFINAGIL As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbEstratoActual As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtLineaActual As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDiferencialFINAGIL As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoHectarea As System.Windows.Forms.TextBox
    Friend WithEvents txtSustraeActual As System.Windows.Forms.TextBox
    Friend WithEvents gbDatosFIRA As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIDPersona As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIDCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtIDContrato As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtIDDTU As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents cbZ25 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRefa As System.Windows.Forms.Button
    Friend WithEvents TxtIDgarantia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtGarantia As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnOnbase As System.Windows.Forms.Button
    Friend WithEvents TxtContMarco As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CkGarantiaSinFondeo As System.Windows.Forms.CheckBox
    Friend WithEvents CmbZ08 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FirA_AnexosDatosTableAdapter1 As AviosDSXTableAdapters.FIRA_AnexosDatosTableAdapter
    Friend WithEvents AviosDSX1 As AviosDSX
    Friend WithEvents FiraDatosBindingSource As BindingSource
    Friend WithEvents CmbLocaInver As ComboBox
    Friend WithEvents CmbMuniInver As ComboBox
    Friend WithEvents CmbEdoInver As ComboBox
    Friend WithEvents Txringresos As TextBox
    Friend WithEvents CmbLocaAcre As ComboBox
    Friend WithEvents CmbMuniAcre As ComboBox
    Friend WithEvents CbBEdoAcre As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FIRAEstadosBindingSource As BindingSource
    Friend WithEvents FIRA_EstadosTableAdapter As AviosDSXTableAdapters.FIRA_EstadosTableAdapter
    Friend WithEvents FIRALocalidadesBindingSource As BindingSource
    Friend WithEvents FIRAMunicipiosBindingSource As BindingSource
    Friend WithEvents FIRA_MunicipiosTableAdapter As AviosDSXTableAdapters.FIRA_MunicipiosTableAdapter
    Friend WithEvents FIRA_LocalidadesTableAdapter As AviosDSXTableAdapters.FIRA_LocalidadesTableAdapter
    Friend WithEvents locaBindingSource As BindingSource
    Friend WithEvents AviosDSX2 As AviosDSX
    Friend WithEvents EdosBindingSource As BindingSource
    Friend WithEvents MuniBindingSource As BindingSource
End Class
