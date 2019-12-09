
Option Explicit On
Imports Word = Microsoft.Office.Interop.Word
Imports System.Data.SqlClient
Imports System.Math
Imports System.Security
Imports System.Security.Principal.WindowsIdentity

Public Class frmAutorizaTRA_MC
    Inherits System.Windows.Forms.Form
    Dim myIdentity As Principal.WindowsIdentity
    Dim cUsuario As String
    Friend WithEvents BtnOnbase As System.Windows.Forms.Button
    Dim Ta As New ProductionDataSetTableAdapters.FIRArefaccionariosTableAdapter
    Friend WithEvents txtTasaIvacap As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents BtnOnbaseCRE As System.Windows.Forms.Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPagosIniciales As TextBox
    Friend WithEvents lblMontof As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbAnexos As ComboBox
    Friend WithEvents MesaControlDS As MesaControlDS
    Friend WithEvents AnexosLiberacionBindingSource As BindingSource
    Friend WithEvents AnexosLiberacionTableAdapter As MesaControlDSTableAdapters.AnexosLiberacionTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFechaLib As TextBox
    Friend WithEvents TxtFechaRec As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnRecLib As Button
    Friend WithEvents LbFecha As Label
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbStatus As ComboBox
    Dim ClienteAux As String = ""
    Friend WithEvents TxtPromo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Btnchecklist As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtObs As TextBox
    Friend WithEvents BtnMail As Button
    Friend WithEvents BtnHojaCamb As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CkJur As CheckBox
    Friend WithEvents ckSEG As CheckBox
    Friend WithEvents CmbAnalista As ComboBox
    Friend WithEvents SeguridadDS As SeguridadDS
    Friend WithEvents UsuariosFinagilBindingSource As BindingSource
    Friend WithEvents UsuariosFinagilTableAdapter As SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
    Friend WithEvents CKcred As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtSaldoTRA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtSaldoAv As TextBox
    Friend WithEvents Label12 As Label
    Dim TaLib As New MesaControlDSTableAdapters.LiberacionesTableAdapter
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtAplicaFega As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtPorcFega As TextBox
    Dim tax As New MesaControlDSTableAdapters.AviosMCTableAdapter
    Dim cAnexo As String = ""


#Region " Windows Form Designer generated code "

    Public Sub New(ByVal cAnexo As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'Me.Text = "Datos del Contrato " & cAnexo
        lblAnexo.Text = cAnexo
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblNumc As System.Windows.Forms.Label
    Friend WithEvents lblFechac As System.Windows.Forms.Label
    Friend WithEvents lblFechaven1 As System.Windows.Forms.Label
    Friend WithEvents txtFechacon As System.Windows.Forms.TextBox
    Friend WithEvents txtFvenc As System.Windows.Forms.TextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblFechafin As System.Windows.Forms.Label
    Friend WithEvents lblTasai As System.Windows.Forms.Label
    Friend WithEvents lblDifer As System.Windows.Forms.Label
    Friend WithEvents lblFrecpag As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblRecursos As System.Windows.Forms.Label
    Friend WithEvents txtFondeo As System.Windows.Forms.TextBox
    Friend WithEvents lblTipotasa As System.Windows.Forms.Label
    Friend WithEvents gpoPagos As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblPlazo As System.Windows.Forms.Label
    Friend WithEvents txtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents btnDatoseq As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtTermina As System.Windows.Forms.TextBox
    Friend WithEvents txtDescTipar As System.Windows.Forms.TextBox
    Friend WithEvents txtTasas As System.Windows.Forms.TextBox
    Friend WithEvents txtDifer As System.Windows.Forms.TextBox
    Friend WithEvents txtFrecuencia As System.Windows.Forms.TextBox
    Friend WithEvents txtImpEq As System.Windows.Forms.TextBox
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents btnDatosCliente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnTablaEquipo As System.Windows.Forms.Button
    Friend WithEvents txtMontoFinanciado As System.Windows.Forms.TextBox
    Friend WithEvents txtDescTasa As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblAnexo As System.Windows.Forms.Label
    Friend WithEvents lblDescr As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gpoPagos = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPagosIniciales = New System.Windows.Forms.TextBox()
        Me.lblMontof = New System.Windows.Forms.Label()
        Me.txtMontoFinanciado = New System.Windows.Forms.TextBox()
        Me.txtImpEq = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.AnexosLiberacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MesaControlDS = New Agil.MesaControlDS()
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.txtDescTasa = New System.Windows.Forms.TextBox()
        Me.lblTipotasa = New System.Windows.Forms.Label()
        Me.txtFondeo = New System.Windows.Forms.TextBox()
        Me.lblRecursos = New System.Windows.Forms.Label()
        Me.txtFrecuencia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDifer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTasas = New System.Windows.Forms.TextBox()
        Me.txtDescTipar = New System.Windows.Forms.TextBox()
        Me.txtTermina = New System.Windows.Forms.TextBox()
        Me.lblFrecpag = New System.Windows.Forms.Label()
        Me.lblDifer = New System.Windows.Forms.Label()
        Me.lblTasai = New System.Windows.Forms.Label()
        Me.lblFechafin = New System.Windows.Forms.Label()
        Me.txtFvenc = New System.Windows.Forms.TextBox()
        Me.txtFechacon = New System.Windows.Forms.TextBox()
        Me.lblFechaven1 = New System.Windows.Forms.Label()
        Me.lblFechac = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblNumc = New System.Windows.Forms.Label()
        Me.btnDatosCliente = New System.Windows.Forms.Button()
        Me.btnDatoseq = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.btnTablaEquipo = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblAnexo = New System.Windows.Forms.Label()
        Me.lblDescr = New System.Windows.Forms.Label()
        Me.BtnOnbase = New System.Windows.Forms.Button()
        Me.txtTasaIvacap = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BtnOnbaseCRE = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbAnexos = New System.Windows.Forms.ComboBox()
        Me.AnexosLiberacionTableAdapter = New Agil.MesaControlDSTableAdapters.AnexosLiberacionTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.BtnRecLib = New System.Windows.Forms.Button()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFechaLib = New System.Windows.Forms.TextBox()
        Me.TxtFechaRec = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPromo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btnchecklist = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtObs = New System.Windows.Forms.TextBox()
        Me.BtnMail = New System.Windows.Forms.Button()
        Me.BtnHojaCamb = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CkJur = New System.Windows.Forms.CheckBox()
        Me.ckSEG = New System.Windows.Forms.CheckBox()
        Me.CmbAnalista = New System.Windows.Forms.ComboBox()
        Me.UsuariosFinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguridadDS = New Agil.SeguridadDS()
        Me.UsuariosFinagilTableAdapter = New Agil.SeguridadDSTableAdapters.UsuariosFinagilTableAdapter()
        Me.CKcred = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtSaldoTRA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtSaldoAv = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtAplicaFega = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtPorcFega = New System.Windows.Forms.TextBox()
        Me.gpoPagos.SuspendLayout()
        CType(Me.AnexosLiberacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UsuariosFinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpoPagos
        '
        Me.gpoPagos.Controls.Add(Me.Label14)
        Me.gpoPagos.Controls.Add(Me.txtPagosIniciales)
        Me.gpoPagos.Controls.Add(Me.lblMontof)
        Me.gpoPagos.Controls.Add(Me.txtMontoFinanciado)
        Me.gpoPagos.Controls.Add(Me.txtImpEq)
        Me.gpoPagos.Controls.Add(Me.Label27)
        Me.gpoPagos.Location = New System.Drawing.Point(378, 74)
        Me.gpoPagos.Name = "gpoPagos"
        Me.gpoPagos.Size = New System.Drawing.Size(264, 105)
        Me.gpoPagos.TabIndex = 48
        Me.gpoPagos.TabStop = False
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(6, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 16)
        Me.Label14.TabIndex = 145
        Me.Label14.Text = "Total de Pagos Iniciales"
        '
        'txtPagosIniciales
        '
        Me.txtPagosIniciales.Location = New System.Drawing.Point(168, 65)
        Me.txtPagosIniciales.Name = "txtPagosIniciales"
        Me.txtPagosIniciales.ReadOnly = True
        Me.txtPagosIniciales.Size = New System.Drawing.Size(88, 20)
        Me.txtPagosIniciales.TabIndex = 144
        Me.txtPagosIniciales.TabStop = False
        Me.txtPagosIniciales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMontof
        '
        Me.lblMontof.Location = New System.Drawing.Point(8, 43)
        Me.lblMontof.Name = "lblMontof"
        Me.lblMontof.Size = New System.Drawing.Size(144, 16)
        Me.lblMontof.TabIndex = 77
        Me.lblMontof.Text = "Monto Financiado"
        '
        'txtMontoFinanciado
        '
        Me.txtMontoFinanciado.Location = New System.Drawing.Point(168, 40)
        Me.txtMontoFinanciado.Name = "txtMontoFinanciado"
        Me.txtMontoFinanciado.ReadOnly = True
        Me.txtMontoFinanciado.Size = New System.Drawing.Size(88, 20)
        Me.txtMontoFinanciado.TabIndex = 76
        Me.txtMontoFinanciado.TabStop = False
        Me.txtMontoFinanciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpEq
        '
        Me.txtImpEq.Location = New System.Drawing.Point(168, 16)
        Me.txtImpEq.Name = "txtImpEq"
        Me.txtImpEq.ReadOnly = True
        Me.txtImpEq.Size = New System.Drawing.Size(88, 20)
        Me.txtImpEq.TabIndex = 63
        Me.txtImpEq.TabStop = False
        Me.txtImpEq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(8, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(144, 16)
        Me.Label27.TabIndex = 58
        Me.Label27.Text = "Equipo con I.V.A."
        '
        'txtPlazo
        '
        Me.txtPlazo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosLiberacionBindingSource, "Plazo", True))
        Me.txtPlazo.Location = New System.Drawing.Point(184, 158)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.ReadOnly = True
        Me.txtPlazo.Size = New System.Drawing.Size(24, 20)
        Me.txtPlazo.TabIndex = 61
        Me.txtPlazo.TabStop = False
        Me.txtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AnexosLiberacionBindingSource
        '
        Me.AnexosLiberacionBindingSource.DataMember = "AnexosLiberacion"
        Me.AnexosLiberacionBindingSource.DataSource = Me.MesaControlDS
        '
        'MesaControlDS
        '
        Me.MesaControlDS.DataSetName = "MesaControlDS"
        Me.MesaControlDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblPlazo
        '
        Me.lblPlazo.Location = New System.Drawing.Point(16, 163)
        Me.lblPlazo.Name = "lblPlazo"
        Me.lblPlazo.Size = New System.Drawing.Size(136, 16)
        Me.lblPlazo.TabIndex = 59
        Me.lblPlazo.Text = "No. Pagos"
        Me.lblPlazo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescTasa
        '
        Me.txtDescTasa.Location = New System.Drawing.Point(144, 336)
        Me.txtDescTasa.Name = "txtDescTasa"
        Me.txtDescTasa.ReadOnly = True
        Me.txtDescTasa.Size = New System.Drawing.Size(224, 20)
        Me.txtDescTasa.TabIndex = 47
        Me.txtDescTasa.TabStop = False
        '
        'lblTipotasa
        '
        Me.lblTipotasa.Location = New System.Drawing.Point(16, 336)
        Me.lblTipotasa.Name = "lblTipotasa"
        Me.lblTipotasa.Size = New System.Drawing.Size(120, 16)
        Me.lblTipotasa.TabIndex = 46
        Me.lblTipotasa.Text = "Tipo de Tasa"
        Me.lblTipotasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFondeo
        '
        Me.txtFondeo.Location = New System.Drawing.Point(76, 311)
        Me.txtFondeo.Name = "txtFondeo"
        Me.txtFondeo.ReadOnly = True
        Me.txtFondeo.Size = New System.Drawing.Size(103, 20)
        Me.txtFondeo.TabIndex = 37
        Me.txtFondeo.TabStop = False
        '
        'lblRecursos
        '
        Me.lblRecursos.AutoSize = True
        Me.lblRecursos.Location = New System.Drawing.Point(19, 314)
        Me.lblRecursos.Name = "lblRecursos"
        Me.lblRecursos.Size = New System.Drawing.Size(52, 13)
        Me.lblRecursos.TabIndex = 36
        Me.lblRecursos.Text = "Recursos"
        Me.lblRecursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFrecuencia
        '
        Me.txtFrecuencia.Location = New System.Drawing.Point(145, 286)
        Me.txtFrecuencia.Name = "txtFrecuencia"
        Me.txtFrecuencia.ReadOnly = True
        Me.txtFrecuencia.Size = New System.Drawing.Size(136, 20)
        Me.txtFrecuencia.TabIndex = 35
        Me.txtFrecuencia.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(200, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "%"
        '
        'txtDifer
        '
        Me.txtDifer.Location = New System.Drawing.Point(144, 235)
        Me.txtDifer.Name = "txtDifer"
        Me.txtDifer.ReadOnly = True
        Me.txtDifer.Size = New System.Drawing.Size(56, 20)
        Me.txtDifer.TabIndex = 26
        Me.txtDifer.TabStop = False
        Me.txtDifer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "%"
        '
        'txtTasas
        '
        Me.txtTasas.Location = New System.Drawing.Point(144, 211)
        Me.txtTasas.Name = "txtTasas"
        Me.txtTasas.ReadOnly = True
        Me.txtTasas.Size = New System.Drawing.Size(56, 20)
        Me.txtTasas.TabIndex = 24
        Me.txtTasas.TabStop = False
        Me.txtTasas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescTipar
        '
        Me.txtDescTipar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosLiberacionBindingSource, "TipoCredito", True))
        Me.txtDescTipar.Location = New System.Drawing.Point(76, 86)
        Me.txtDescTipar.Name = "txtDescTipar"
        Me.txtDescTipar.ReadOnly = True
        Me.txtDescTipar.Size = New System.Drawing.Size(292, 20)
        Me.txtDescTipar.TabIndex = 17
        Me.txtDescTipar.TabStop = False
        '
        'txtTermina
        '
        Me.txtTermina.Location = New System.Drawing.Point(144, 182)
        Me.txtTermina.Name = "txtTermina"
        Me.txtTermina.ReadOnly = True
        Me.txtTermina.Size = New System.Drawing.Size(64, 20)
        Me.txtTermina.TabIndex = 16
        Me.txtTermina.TabStop = False
        Me.txtTermina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFrecpag
        '
        Me.lblFrecpag.Location = New System.Drawing.Point(17, 286)
        Me.lblFrecpag.Name = "lblFrecpag"
        Me.lblFrecpag.Size = New System.Drawing.Size(120, 16)
        Me.lblFrecpag.TabIndex = 15
        Me.lblFrecpag.Text = "Frecuencia de pago"
        Me.lblFrecpag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDifer
        '
        Me.lblDifer.Location = New System.Drawing.Point(16, 235)
        Me.lblDifer.Name = "lblDifer"
        Me.lblDifer.Size = New System.Drawing.Size(120, 16)
        Me.lblDifer.TabIndex = 13
        Me.lblDifer.Text = "Diferencial"
        Me.lblDifer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTasai
        '
        Me.lblTasai.Location = New System.Drawing.Point(16, 211)
        Me.lblTasai.Name = "lblTasai"
        Me.lblTasai.Size = New System.Drawing.Size(120, 16)
        Me.lblTasai.TabIndex = 12
        Me.lblTasai.Text = "Tasa de Interés"
        Me.lblTasai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechafin
        '
        Me.lblFechafin.Location = New System.Drawing.Point(16, 187)
        Me.lblFechafin.Name = "lblFechafin"
        Me.lblFechafin.Size = New System.Drawing.Size(136, 16)
        Me.lblFechafin.TabIndex = 8
        Me.lblFechafin.Text = "Fecha de Terminación"
        Me.lblFechafin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFvenc
        '
        Me.txtFvenc.Location = New System.Drawing.Point(144, 134)
        Me.txtFvenc.Name = "txtFvenc"
        Me.txtFvenc.ReadOnly = True
        Me.txtFvenc.Size = New System.Drawing.Size(64, 20)
        Me.txtFvenc.TabIndex = 7
        Me.txtFvenc.TabStop = False
        Me.txtFvenc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFechacon
        '
        Me.txtFechacon.Location = New System.Drawing.Point(144, 110)
        Me.txtFechacon.Name = "txtFechacon"
        Me.txtFechacon.ReadOnly = True
        Me.txtFechacon.Size = New System.Drawing.Size(64, 20)
        Me.txtFechacon.TabIndex = 6
        Me.txtFechacon.TabStop = False
        Me.txtFechacon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFechaven1
        '
        Me.lblFechaven1.AutoSize = True
        Me.lblFechaven1.Location = New System.Drawing.Point(16, 139)
        Me.lblFechaven1.Name = "lblFechaven1"
        Me.lblFechaven1.Size = New System.Drawing.Size(119, 13)
        Me.lblFechaven1.TabIndex = 3
        Me.lblFechaven1.Text = "Fecha 1er. Vencimiento"
        Me.lblFechaven1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechac
        '
        Me.lblFechac.AutoSize = True
        Me.lblFechac.Location = New System.Drawing.Point(16, 115)
        Me.lblFechac.Name = "lblFechac"
        Me.lblFechac.Size = New System.Drawing.Size(115, 13)
        Me.lblFechac.TabIndex = 2
        Me.lblFechac.Text = "Fecha de Contratación"
        Me.lblFechac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(16, 87)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(50, 13)
        Me.lblTipo.TabIndex = 1
        Me.lblTipo.Text = "Producto"
        Me.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumc
        '
        Me.lblNumc.Location = New System.Drawing.Point(16, 51)
        Me.lblNumc.Name = "lblNumc"
        Me.lblNumc.Size = New System.Drawing.Size(88, 20)
        Me.lblNumc.TabIndex = 0
        Me.lblNumc.Text = "No. de Contrato"
        Me.lblNumc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDatosCliente
        '
        Me.btnDatosCliente.Enabled = False
        Me.btnDatosCliente.Location = New System.Drawing.Point(665, 81)
        Me.btnDatosCliente.Name = "btnDatosCliente"
        Me.btnDatosCliente.Size = New System.Drawing.Size(104, 24)
        Me.btnDatosCliente.TabIndex = 0
        Me.btnDatosCliente.Text = "Datos del Cliente"
        '
        'btnDatoseq
        '
        Me.btnDatoseq.Enabled = False
        Me.btnDatoseq.Location = New System.Drawing.Point(665, 110)
        Me.btnDatoseq.Name = "btnDatoseq"
        Me.btnDatoseq.Size = New System.Drawing.Size(104, 24)
        Me.btnDatoseq.TabIndex = 1
        Me.btnDatoseq.Text = "Datos del Equipo"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(665, 342)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(104, 24)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(618, 2)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(24, 20)
        Me.txtReferencia.TabIndex = 62
        Me.txtReferencia.Visible = False
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(588, 2)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(24, 20)
        Me.txtCliente.TabIndex = 63
        Me.txtCliente.Visible = False
        '
        'btnTablaEquipo
        '
        Me.btnTablaEquipo.Enabled = False
        Me.btnTablaEquipo.Location = New System.Drawing.Point(665, 139)
        Me.btnTablaEquipo.Name = "btnTablaEquipo"
        Me.btnTablaEquipo.Size = New System.Drawing.Size(104, 24)
        Me.btnTablaEquipo.TabIndex = 3
        Me.btnTablaEquipo.Text = "Tabla Equipo"
        '
        'lblStatus
        '
        Me.lblStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosLiberacionBindingSource, "Status", True))
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(181, 51)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(90, 20)
        Me.lblStatus.TabIndex = 69
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnexo
        '
        Me.lblAnexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosLiberacionBindingSource, "AnexoCon", True))
        Me.lblAnexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnexo.Location = New System.Drawing.Point(103, 51)
        Me.lblAnexo.Name = "lblAnexo"
        Me.lblAnexo.Size = New System.Drawing.Size(72, 20)
        Me.lblAnexo.TabIndex = 70
        Me.lblAnexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescr
        '
        Me.lblDescr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosLiberacionBindingSource, "Descr", True))
        Me.lblDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescr.Location = New System.Drawing.Point(291, 51)
        Me.lblDescr.Name = "lblDescr"
        Me.lblDescr.Size = New System.Drawing.Size(475, 20)
        Me.lblDescr.TabIndex = 71
        Me.lblDescr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnOnbase
        '
        Me.BtnOnbase.Location = New System.Drawing.Point(665, 197)
        Me.BtnOnbase.Name = "BtnOnbase"
        Me.BtnOnbase.Size = New System.Drawing.Size(104, 24)
        Me.BtnOnbase.TabIndex = 99
        Me.BtnOnbase.Text = "OnBase Contrato"
        '
        'txtTasaIvacap
        '
        Me.txtTasaIvacap.Location = New System.Drawing.Point(145, 260)
        Me.txtTasaIvacap.Name = "txtTasaIvacap"
        Me.txtTasaIvacap.ReadOnly = True
        Me.txtTasaIvacap.Size = New System.Drawing.Size(56, 20)
        Me.txtTasaIvacap.TabIndex = 134
        Me.txtTasaIvacap.TabStop = False
        Me.txtTasaIvacap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(17, 260)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(120, 16)
        Me.Label23.TabIndex = 133
        Me.Label23.Text = "Tasa I.V.A. Capital"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnOnbaseCRE
        '
        Me.BtnOnbaseCRE.Location = New System.Drawing.Point(665, 168)
        Me.BtnOnbaseCRE.Name = "BtnOnbaseCRE"
        Me.BtnOnbaseCRE.Size = New System.Drawing.Size(104, 24)
        Me.BtnOnbaseCRE.TabIndex = 135
        Me.BtnOnbaseCRE.Text = "OnBase Crédito"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Contratos Pendientes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbAnexos
        '
        Me.CmbAnexos.DataSource = Me.AnexosLiberacionBindingSource
        Me.CmbAnexos.DisplayMember = "Titulo"
        Me.CmbAnexos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnexos.FormattingEnabled = True
        Me.CmbAnexos.Location = New System.Drawing.Point(20, 25)
        Me.CmbAnexos.Name = "CmbAnexos"
        Me.CmbAnexos.Size = New System.Drawing.Size(749, 21)
        Me.CmbAnexos.TabIndex = 137
        Me.CmbAnexos.ValueMember = "Anexo"
        '
        'AnexosLiberacionTableAdapter
        '
        Me.AnexosLiberacionTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbStatus)
        Me.GroupBox1.Controls.Add(Me.BtnRecLib)
        Me.GroupBox1.Controls.Add(Me.LbFecha)
        Me.GroupBox1.Controls.Add(Me.DtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtFechaLib)
        Me.GroupBox1.Controls.Add(Me.TxtFechaRec)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(378, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 147)
        Me.GroupBox1.TabIndex = 146
        Me.GroupBox1.TabStop = False
        '
        'CmbStatus
        '
        Me.CmbStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosLiberacionBindingSource, "Status", True))
        Me.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"Recibido", "Con Pendiente", "No operado", "Liberado"})
        Me.CmbStatus.Location = New System.Drawing.Point(137, 66)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(119, 21)
        Me.CmbStatus.TabIndex = 148
        '
        'BtnRecLib
        '
        Me.BtnRecLib.Location = New System.Drawing.Point(139, 119)
        Me.BtnRecLib.Name = "BtnRecLib"
        Me.BtnRecLib.Size = New System.Drawing.Size(119, 24)
        Me.BtnRecLib.TabIndex = 147
        Me.BtnRecLib.Text = "Recibir"
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.Location = New System.Drawing.Point(6, 97)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(107, 13)
        Me.LbFecha.TabIndex = 147
        Me.LbFecha.Text = "Fecha de Recepción"
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(137, 91)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(119, 20)
        Me.DtpFecha.TabIndex = 146
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 16)
        Me.Label2.TabIndex = 145
        Me.Label2.Text = "Estatus"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Fecha de Liberación"
        '
        'TxtFechaLib
        '
        Me.TxtFechaLib.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosLiberacionBindingSource, "FechaLiberacion", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.TxtFechaLib.Location = New System.Drawing.Point(168, 40)
        Me.TxtFechaLib.Name = "TxtFechaLib"
        Me.TxtFechaLib.ReadOnly = True
        Me.TxtFechaLib.Size = New System.Drawing.Size(88, 20)
        Me.TxtFechaLib.TabIndex = 76
        Me.TxtFechaLib.TabStop = False
        Me.TxtFechaLib.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtFechaRec
        '
        Me.TxtFechaRec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosLiberacionBindingSource, "FechaRecepcion", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.TxtFechaRec.Location = New System.Drawing.Point(168, 16)
        Me.TxtFechaRec.Name = "TxtFechaRec"
        Me.TxtFechaRec.ReadOnly = True
        Me.TxtFechaRec.Size = New System.Drawing.Size(88, 20)
        Me.TxtFechaRec.TabIndex = 63
        Me.TxtFechaRec.TabStop = False
        Me.TxtFechaRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 16)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Fecha de Recepción"
        '
        'TxtPromo
        '
        Me.TxtPromo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosLiberacionBindingSource, "Nombre_Promotor", True))
        Me.TxtPromo.Location = New System.Drawing.Point(145, 362)
        Me.TxtPromo.Name = "TxtPromo"
        Me.TxtPromo.ReadOnly = True
        Me.TxtPromo.Size = New System.Drawing.Size(224, 20)
        Me.TxtPromo.TabIndex = 148
        Me.TxtPromo.TabStop = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(17, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "Ejecutivo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btnchecklist
        '
        Me.Btnchecklist.Location = New System.Drawing.Point(665, 226)
        Me.Btnchecklist.Name = "Btnchecklist"
        Me.Btnchecklist.Size = New System.Drawing.Size(104, 24)
        Me.Btnchecklist.TabIndex = 149
        Me.Btnchecklist.Text = "Check List MC"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 400)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 149
        Me.Label8.Text = "Observaciones"
        '
        'TxtObs
        '
        Me.TxtObs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosLiberacionBindingSource, "Observaciones", True))
        Me.TxtObs.Location = New System.Drawing.Point(19, 416)
        Me.TxtObs.MaxLength = 1000
        Me.TxtObs.Multiline = True
        Me.TxtObs.Name = "TxtObs"
        Me.TxtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObs.Size = New System.Drawing.Size(749, 96)
        Me.TxtObs.TabIndex = 150
        '
        'BtnMail
        '
        Me.BtnMail.Location = New System.Drawing.Point(377, 389)
        Me.BtnMail.Name = "BtnMail"
        Me.BtnMail.Size = New System.Drawing.Size(47, 21)
        Me.BtnMail.TabIndex = 149
        Me.BtnMail.Text = "Correo"
        '
        'BtnHojaCamb
        '
        Me.BtnHojaCamb.Location = New System.Drawing.Point(665, 255)
        Me.BtnHojaCamb.Name = "BtnHojaCamb"
        Me.BtnHojaCamb.Size = New System.Drawing.Size(104, 24)
        Me.BtnHojaCamb.TabIndex = 151
        Me.BtnHojaCamb.Text = "Hoja de Cambios"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(665, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 152
        Me.Button2.Text = "Hoja Camb Tasa"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosLiberacionBindingSource, "Nombre_Sucursal", True))
        Me.TextBox1.Location = New System.Drawing.Point(254, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(115, 20)
        Me.TextBox1.TabIndex = 156
        Me.TextBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(219, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 155
        Me.Label9.Text = "Suc."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CkJur
        '
        Me.CkJur.AutoSize = True
        Me.CkJur.Location = New System.Drawing.Point(430, 392)
        Me.CkJur.Name = "CkJur"
        Me.CkJur.Size = New System.Drawing.Size(43, 17)
        Me.CkJur.TabIndex = 157
        Me.CkJur.Text = "Jur."
        Me.CkJur.UseVisualStyleBackColor = True
        '
        'ckSEG
        '
        Me.ckSEG.AutoSize = True
        Me.ckSEG.Location = New System.Drawing.Point(479, 392)
        Me.ckSEG.Name = "ckSEG"
        Me.ckSEG.Size = New System.Drawing.Size(48, 17)
        Me.ckSEG.TabIndex = 158
        Me.ckSEG.Text = "Seg."
        Me.ckSEG.UseVisualStyleBackColor = True
        '
        'CmbAnalista
        '
        Me.CmbAnalista.DataSource = Me.UsuariosFinagilBindingSource
        Me.CmbAnalista.DisplayMember = "NombreCompleto"
        Me.CmbAnalista.FormattingEnabled = True
        Me.CmbAnalista.Location = New System.Drawing.Point(590, 388)
        Me.CmbAnalista.Name = "CmbAnalista"
        Me.CmbAnalista.Size = New System.Drawing.Size(178, 21)
        Me.CmbAnalista.TabIndex = 159
        Me.CmbAnalista.ValueMember = "correo"
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
        'UsuariosFinagilTableAdapter
        '
        Me.UsuariosFinagilTableAdapter.ClearBeforeFill = True
        '
        'CKcred
        '
        Me.CKcred.AutoSize = True
        Me.CKcred.Location = New System.Drawing.Point(533, 392)
        Me.CKcred.Name = "CKcred"
        Me.CKcred.Size = New System.Drawing.Size(51, 17)
        Me.CKcred.TabIndex = 160
        Me.CKcred.Text = "Cred."
        Me.CKcred.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(665, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 161
        Me.Button1.Text = "Sin Seguro"
        '
        'TxtSaldoTRA
        '
        Me.TxtSaldoTRA.Location = New System.Drawing.Point(477, 358)
        Me.TxtSaldoTRA.Name = "TxtSaldoTRA"
        Me.TxtSaldoTRA.ReadOnly = True
        Me.TxtSaldoTRA.Size = New System.Drawing.Size(107, 20)
        Me.TxtSaldoTRA.TabIndex = 165
        Me.TxtSaldoTRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(389, 361)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 164
        Me.Label11.Text = "Saldo Venc. Tra."
        '
        'TxtSaldoAv
        '
        Me.TxtSaldoAv.Location = New System.Drawing.Point(477, 335)
        Me.TxtSaldoAv.Name = "TxtSaldoAv"
        Me.TxtSaldoAv.ReadOnly = True
        Me.TxtSaldoAv.Size = New System.Drawing.Size(107, 20)
        Me.TxtSaldoAv.TabIndex = 163
        Me.TxtSaldoAv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(376, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 13)
        Me.Label12.TabIndex = 162
        Me.Label12.Text = "Saldo Vencido Avio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(185, 314)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 166
        Me.Label10.Text = "Aplica Fega"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtAplicaFega
        '
        Me.TxtAplicaFega.Location = New System.Drawing.Point(253, 311)
        Me.TxtAplicaFega.Name = "TxtAplicaFega"
        Me.TxtAplicaFega.ReadOnly = True
        Me.TxtAplicaFega.Size = New System.Drawing.Size(28, 20)
        Me.TxtAplicaFega.TabIndex = 167
        Me.TxtAplicaFega.TabStop = False
        Me.TxtAplicaFega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(291, 314)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 13)
        Me.Label13.TabIndex = 168
        Me.Label13.Text = "%"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPorcFega
        '
        Me.TxtPorcFega.Location = New System.Drawing.Point(312, 311)
        Me.TxtPorcFega.Name = "TxtPorcFega"
        Me.TxtPorcFega.ReadOnly = True
        Me.TxtPorcFega.Size = New System.Drawing.Size(56, 20)
        Me.TxtPorcFega.TabIndex = 169
        Me.TxtPorcFega.TabStop = False
        Me.TxtPorcFega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmAutorizaTRA_MC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(781, 519)
        Me.Controls.Add(Me.TxtPorcFega)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtAplicaFega)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtSaldoTRA)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtSaldoAv)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CKcred)
        Me.Controls.Add(Me.CmbAnalista)
        Me.Controls.Add(Me.ckSEG)
        Me.Controls.Add(Me.CkJur)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnHojaCamb)
        Me.Controls.Add(Me.BtnMail)
        Me.Controls.Add(Me.TxtObs)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btnchecklist)
        Me.Controls.Add(Me.TxtPromo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbAnexos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnOnbaseCRE)
        Me.Controls.Add(Me.txtTasaIvacap)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.BtnOnbase)
        Me.Controls.Add(Me.lblDescr)
        Me.Controls.Add(Me.lblAnexo)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnTablaEquipo)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnDatoseq)
        Me.Controls.Add(Me.btnDatosCliente)
        Me.Controls.Add(Me.lblNumc)
        Me.Controls.Add(Me.lblFechac)
        Me.Controls.Add(Me.lblFechaven1)
        Me.Controls.Add(Me.txtTermina)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblFechafin)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.txtDifer)
        Me.Controls.Add(Me.lblDifer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTasai)
        Me.Controls.Add(Me.txtTasas)
        Me.Controls.Add(Me.txtFvenc)
        Me.Controls.Add(Me.txtDescTipar)
        Me.Controls.Add(Me.txtFechacon)
        Me.Controls.Add(Me.gpoPagos)
        Me.Controls.Add(Me.txtDescTasa)
        Me.Controls.Add(Me.lblTipotasa)
        Me.Controls.Add(Me.lblRecursos)
        Me.Controls.Add(Me.txtFrecuencia)
        Me.Controls.Add(Me.lblFrecpag)
        Me.Controls.Add(Me.txtFondeo)
        Me.Controls.Add(Me.lblPlazo)
        Me.Controls.Add(Me.txtPlazo)
        Me.Name = "frmAutorizaTRA_MC"
        Me.Text = "Mesa de Control - Liberacion de Contratos"
        Me.gpoPagos.ResumeLayout(False)
        Me.gpoPagos.PerformLayout()
        CType(Me.AnexosLiberacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UsuariosFinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmDatosCon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.UsuariosFinagilTableAdapter.FillByDepto(Me.SeguridadDS.UsuariosFinagil, "CREDITO")
        Dim PLD As New PLD_DSTableAdapters.PLD_Bloqueo_ClientesTableAdapter
        PLD.Caducar()
        GeneraPolizasLuquidez()
        PLD.Dispose()
        Me.AnexosLiberacionTableAdapter.Fill(Me.MesaControlDS.AnexosLiberacion)
        CmbAnexos_SelectedIndexChanged(Nothing, Nothing)
        Cursor.Current = Cursors.Default
        If Me.MesaControlDS.AnexosLiberacion.Rows.Count <= 0 Then
            For Each ctrl As Control In Me.Controls
                If (TypeOf ctrl Is Button) Then
                    If ctrl.Name <> "btnSalir" Then
                        ctrl.Enabled = False
                    Else
                        BtnRecLib.Enabled = False
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub btnDatosCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatosCliente.Click
        Dim newfrmDatosClie As New frmDatosclie(txtCliente.Text)
        newfrmDatosClie.Show()
    End Sub

    Private Sub btnDatoseq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatoseq.Click
        Dim newfrmDatosEq As New frmDatosEq(lblAnexo.Text)
        newfrmDatosEq.Show()
    End Sub

    Private Sub btnTablaEquipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTablaEquipo.Click
        Dim newfrmTablaEquipo As New frmTablaEquipo(lblAnexo.Text)
        newfrmTablaEquipo.Show()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnOnbase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOnbase.Click
        Dim f As New FrmDocOnbase
        f.Area = "Mesa de Control"
        f.AnexoOcliente = cAnexo
        f.Titulo = Me.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        f.Dispose()
    End Sub

    Private Sub BtnOnbaseCRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOnbaseCRE.Click
        Dim f As New FrmDocOnbase
        f.Area = "Credito"
        f.AnexoOcliente = ClienteAux
        f.Titulo = Me.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        f.Dispose()
    End Sub

    Private Sub CmbAnexos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAnexos.SelectedIndexChanged
        If CmbAnexos.SelectedIndex >= 0 Then
            ' Declaración de variables de conexión ADO .NET

            Dim cnAgil As New SqlConnection(strConn)
            Dim cm1 As New SqlCommand()
            Dim daAnexos As New SqlDataAdapter(cm1)
            Dim dsAgil As New DataSet()
            Dim drAnexo As DataRow

            ' Declaración de variables de datos


            Dim cFlcan As String = ""
            Dim cTipar As String = ""
            Dim nDG As Byte = 0
            Dim nImpDG As Decimal = 0
            Dim nImpEq As Decimal = 0
            Dim nImpRD As Decimal = 0
            Dim nIvaDG As Decimal = 0
            Dim nIvaRD As Decimal = 0
            Dim nPorop As Decimal = 0
            Dim nRD As Byte = 0
            Dim nResidual As Decimal = 0
            Dim nSaldoEquipo As Decimal = 0


            cAnexo = CmbAnexos.SelectedValue
            myIdentity = GetCurrent()
            cUsuario = myIdentity.Name

            ' El siguiente Stored Procedure trae todos los atributos de la tabla Anexos,
            ' para un anexo dado
            With cm1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "DatosCon1"
                .Connection = cnAgil
                .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                .Parameters(0).Value = cAnexo
            End With

            ' Llenar el DataSet lo cual abre y cierra la conexión

            daAnexos.Fill(dsAgil, "Anexos")

            If dsAgil.Tables("Anexos").Rows.Count = 0 Then
                lblDescr.Text = "CONTRATO INEXISTENTE"
                BtnOnbase.Enabled = False
            Else
                btnDatosCliente.Enabled = True
                btnDatoseq.Enabled = True
                drAnexo = dsAgil.Tables("Anexos").Rows(0)
                cFlcan = drAnexo("Flcan")

                TxtSaldoAv.Text = Val(tax.SaldoVencAV(drAnexo("Cliente"), Date.Now.ToString("yyyyMMdd"))).ToString("n2")
                TxtSaldoTRA.Text = Val(tax.SaldoVencTRA(drAnexo("Cliente"), Date.Now.ToString("yyyyMMdd"))).ToString("n2")


                'lblDescr.Text = drAnexo("Descr")
                ClienteAux = drAnexo("cliente")

                ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++
                Dim TaOnbase As New GeneralDSTableAdapters.OnBaseTableAdapter

                If TaOnbase.ScalarCuantosAreaAnexo("Mesa de Control", CadOnbase(cAnexo)) > 0 Then
                    BtnOnbase.Enabled = True
                Else
                    BtnOnbase.Enabled = False
                End If
                If TaOnbase.ScalarCuantosAreaAnexo("Credito", CadOnbase(ClienteAux)) > 0 Then
                    BtnOnbaseCRE.Enabled = True
                Else
                    BtnOnbaseCRE.Enabled = False
                End If
                ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++

                cTipar = drAnexo("Tipar")

                txtFechacon.Text = CTOD(drAnexo("Fechacon"))
                txtFvenc.Text = CTOD(drAnexo("Fvenc"))
                txtTermina.Text = Termina(cAnexo)
                txtTasas.Text = Format(drAnexo("Tasas"), "##,##0.0000")
                txtDifer.Text = Format(drAnexo("Difer"), "##,##0.0000")

                txtFondeo.Text = drAnexo("DescRecurso")
                If txtFondeo.Text.Trim = "FIRA" Then
                    TxtAplicaFega.Text = drAnexo("AplicaFega")
                    If TxtAplicaFega.Text = "S" Then
                        TxtPorcFega.Text = drAnexo("PorcFega")
                    End If
                Else
                    TxtAplicaFega.Text = ""
                    TxtPorcFega.Text = ""
                End If



                If cTipar = "F" Then
                    Label23.Visible = True
                    txtTasaIvacap.Visible = True
                    txtTasaIvacap.Text = drAnexo("TasaIvaCapital")
                Else
                    Label23.Visible = False
                    txtTasaIvacap.Visible = False
                End If

                txtFrecuencia.Text = TaQUERY.SacaPeriodicidadTRA(cAnexo).ToString.ToUpper
                txtDescTasa.Text = drAnexo("DescTasa")
                nImpEq = drAnexo("ImpEq")
                nPorop = drAnexo("Porop")

                If cTipar = "R" Then
                    Label27.Text = "Monto del Equipo"
                Else
                    Label27.Text = "Equipo con I.V.A."
                End If

                txtImpEq.Text = Format(drAnexo("ImpEq"), "##,##0.00")
                If cTipar = "P" Then
                    nResidual = Round((nImpEq * nPorop / 100), 2)
                Else
                End If
                txtMontoFinanciado.Text = Format(drAnexo("ImpEq") - drAnexo("IvaEq") - drAnexo("Amorin"), "##,##0.00")
                nDG = drAnexo("DG")
                nImpDG = drAnexo("ImpRD")
                nIvaDG = drAnexo("IvaRD")
                '*************para no desglosar Deposito en garantia solicitado por Valentin
                nImpDG = nImpDG + nIvaDG
                nIvaDG = 0
                '*************para no desglosar Deposito en garantia solicitado por Valentin
                nRD = drAnexo("RD")
                If nRD > 0 Then
                    nImpRD = drAnexo("ImpDG")
                    nIvaRD = drAnexo("IvaDG")
                End If
                nSaldoEquipo = Round(drAnexo("ImpEq") - drAnexo("IvaEq") - drAnexo("Amorin"), 2)
                txtPagosIniciales.Text = Format(drAnexo("Amorin") + drAnexo("IvaAmorin") + drAnexo("Derechos") + drAnexo("Comis") + drAnexo("Gastos") + drAnexo("IvaGastos") + drAnexo("DepNafin") + nImpDG + nIvaDG + nImpRD + nIvaRD + drAnexo("FondoReserva"), "##,##0.00")
                txtCliente.Text = drAnexo("Cliente")
                txtReferencia.Text = drAnexo("Referencia")
            End If

            cnAgil.Dispose()
            cm1.Dispose()

            If TxtFechaRec.Text = "" Then
                BtnRecLib.Text = "Recibir"
                LbFecha.Text = "Fecha de Recepción"
                CmbStatus.Enabled = False
                TxtObs.Enabled = False
                BtnMail.Enabled = False
            Else
                BtnRecLib.Text = "Liberar"
                LbFecha.Text = "Fecha de Liberación"
                CmbStatus.Enabled = True
                TxtObs.Enabled = True
                BtnMail.Enabled = True
            End If
            If cTipar = "F" Then
                Dim ta As New TesoreriaDSTableAdapters.AnexosTableAdapter
                Dim IvaCap As Decimal = ta.IvaTabla(CmbAnexos.SelectedValue)
                Dim IvaEq As Decimal = drAnexo("IvaEq")
                Dim IvaAI As Decimal = drAnexo("IvaAmorin")
                IvaEq = IvaEq - (IvaCap + IvaAI)
                If IvaEq <= -1 Or IvaEq >= 1 Then
                    MessageBox.Show("El IVA del equipo no conicide con el IVA de la Tabla, Favor de notificar a CONTABILIDAD.", "Error en Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    BtnRecLib.Enabled = False
                End If
            End If
        Else
            'MessageBox.Show("se brinca", "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnRecLib_Click(sender As Object, e As EventArgs) Handles BtnRecLib.Click
        If BtnRecLib.Text.ToUpper = "RECIBIR" Then
            Dim indice As Integer = CmbAnexos.SelectedIndex
            TaLib.Recibir(CmbAnexos.SelectedValue, DtpFecha.Value)
            Me.AnexosLiberacionTableAdapter.Fill(Me.MesaControlDS.AnexosLiberacion)
            CmbAnexos.SelectedIndex = indice
        Else
            If AnexosLiberacionTableAdapter.TieneHojaCambPendiete(CmbAnexos.SelectedValue) > 0 Then
                MessageBox.Show("el Contrato tiene Hoja de Cambio pendiente", "Hojas de Cambios", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If AnexosLiberacionTableAdapter.ChekListImpreso(CmbAnexos.SelectedValue) <= 0 Then
                MessageBox.Show("el Contrato no tiene Check List Impreso", "Check List MC", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim f As New FrmLogin
            f.txtUsuario.Text = UsuarioGlobal
            If f.ShowDialog = DialogResult.OK Then
                TaLib.Liberacion(DtpFecha.Value, CmbAnexos.SelectedValue)
                If CmbStatus.Text = "Recibido" Then
                    CmbStatus.Text = "Liberado"
                    TaLib.CambiaStatus("Liberado", CmbAnexos.SelectedValue)
                End If
                GeneraCorreo(True)
                Me.AnexosLiberacionTableAdapter.Fill(Me.MesaControlDS.AnexosLiberacion)
                CmbAnexos_SelectedIndexChanged(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub CmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbStatus.SelectedIndexChanged
        If Not IsNothing(sender) And TxtFechaRec.Text <> "" And CmbAnexos.SelectedIndex >= 0 Then
            TaLib.CambiaStatus(CmbStatus.Text, CmbAnexos.SelectedValue)
        End If
    End Sub

    Private Sub TxtFechaRec_TextChanged(sender As Object, e As EventArgs) Handles TxtFechaRec.TextChanged
        If TxtFechaRec.Text = "" Then
            BtnRecLib.Text = "Recibir"
            CmbStatus.Enabled = False
            TxtObs.Enabled = False
            BtnMail.Enabled = False
        Else
            BtnRecLib.Text = "Liberar"
            CmbStatus.Enabled = True
            TxtObs.Enabled = True
            BtnMail.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TxtObs.LostFocus
        If CmbAnexos.SelectedIndex >= 0 Then
            TaLib.CambiaOBS(TxtObs.Text, CmbAnexos.SelectedValue)
        End If
    End Sub

    Sub GeneraCorreo(Libera As Boolean)
        Dim Asunto As String = ""
        Dim para As String = AnexosLiberacionBindingSource.Current("Correo")
        'para = "ecacerest@finagil.com.mx"
        If Libera = False Then
            Asunto = "Comentario MC contrato: " & CmbAnexos.Text
        Else
            Select Case CmbStatus.Text
                Case "Liberado", "Recibido"
                    Asunto = "Liberación de contrato MC: " & CmbAnexos.Text
                Case "No Operado"
                    Asunto = "Contrato Marcado como No Operado: " & CmbAnexos.Text
                Case "Con Pendiente"
                    Asunto = "Contrato Liberado con pendientes: " & CmbAnexos.Text
            End Select
        End If
        Dim Mensaje As String = ""
        If TxtFechaLib.Text = "" And Libera = True Then TxtFechaLib.Text = DtpFecha.Value.ToShortDateString
        Mensaje += "Cliente: " & AnexosLiberacionBindingSource.Current("Descr") & "<br>"
        Mensaje += "Contrato: " & AnexosLiberacionBindingSource.Current("AnexoCon") & "<br>"
        Mensaje += "Estatus: " & AnexosLiberacionBindingSource.Current("Status") & "<br>"
        Mensaje += "Fecha Recepción: " & AnexosLiberacionBindingSource.Current("FechaRecepcion") & "<br>"
        If Libera = True Then
            Mensaje += "Fecha Liberación: " & DtpFecha.Value & "<br>"
        Else
            Mensaje += "Fecha Liberación: <br>"
        End If

        Mensaje += "Observaciones: " & AnexosLiberacionBindingSource.Current("Observaciones") & "<br>"

        MandaCorreoPROMO(CmbAnexos.SelectedValue, Asunto, Mensaje, True, False)
        If AnexosLiberacionBindingSource.Current("Tipar") = "L" Then
            MandaCorreoFase(UsuarioGlobalCorreo, "LIQUIDEZ", Asunto, Mensaje)
        Else
            MandaCorreoFase(UsuarioGlobalCorreo, "ASIST_" & AnexosLiberacionBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
        End If
        MandaCorreoFase(UsuarioGlobalCorreo, "MESA_CONTROL", Asunto, Mensaje)
        If CkJur.Checked = True Then MandaCorreoFase(UsuarioGlobalCorreo, "JUR_" & AnexosLiberacionBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
        If ckSEG.Checked = True Then MandaCorreoFase(UsuarioGlobalCorreo, "SEGUROS", Asunto, Mensaje)
        If CKcred.Checked = True Then MandaCorreoUser(UsuarioGlobalCorreo, CmbAnalista.SelectedValue, Asunto, Mensaje)

        If Libera = True Then
            'MandaCorreoFase(UsuarioGlobalCorreo, "TESORERIA", Asunto, Mensaje)
        End If
        MessageBox.Show("Correo Enviado a " & para, "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnMail.Click
        GeneraCorreo(False)
    End Sub

    Private Sub Btnchecklist_Click(sender As Object, e As EventArgs) Handles Btnchecklist.Click
        Dim f As New Frm_Resguardo
        f.cAnexo = CmbAnexos.SelectedValue
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DOC_HojaCambioTasa.SacaHojaCambioTasa(CmbAnexos.SelectedValue)
    End Sub

    Private Sub BtnHojaCamb_Click(sender As Object, e As EventArgs) Handles BtnHojaCamb.Click
        If CmbAnexos.SelectedValue.Length > 0 Then
            Dim f As New FrmHojaCambios
            f.cAnexo = CmbAnexos.SelectedValue
            f.Show()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New FrmAnexoSinPoliza
        f.Show()
    End Sub

End Class
