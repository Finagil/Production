Option Explicit On 

Imports System.Data.SqlClient
Imports System.Math
Imports System.Security
Imports System.Security.Principal.WindowsIdentity

Public Class frmDatoscon

    Inherits System.Windows.Forms.Form
    Dim myIdentity As Principal.WindowsIdentity
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtGHipot As System.Windows.Forms.TextBox
    Friend WithEvents txtLugar As System.Windows.Forms.TextBox
    Friend WithEvents txtEscritura As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNotaria As System.Windows.Forms.TextBox
    Friend WithEvents TxtFondoReserva As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents gbDatosFIRA As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtIDDTU As System.Windows.Forms.TextBox
    Friend WithEvents txtIDCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtIDContrato As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtIDPersona As System.Windows.Forms.TextBox
    Friend WithEvents BtnFira As System.Windows.Forms.Button
    Friend WithEvents TxtZ25 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Dim cUsuario As String
    Friend WithEvents TxtIdgarantia As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DtGarantia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtValorGar As System.Windows.Forms.TextBox
    Friend WithEvents TxtValorHipo As System.Windows.Forms.TextBox
    Friend WithEvents ControlGastosEXT1 As Agil.ControlGastosEXT
    Friend WithEvents BtnOnbase As System.Windows.Forms.Button
    Dim Ta As New ProductionDataSetTableAdapters.FIRArefaccionariosTableAdapter
    Friend WithEvents TxtContMarco As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtTasaIvacap As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CkGSF As System.Windows.Forms.CheckBox
    Friend WithEvents BtnOnbaseCRE As System.Windows.Forms.Button
    Dim cAnexoOnbase As String = ""
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TxtZ08 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtFechaPAG As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TxtFechaACTI As System.Windows.Forms.TextBox
    Friend WithEvents BtnOnbaseFira As System.Windows.Forms.Button
    Friend WithEvents BtnSoldoc As Button
    Friend WithEvents FiraDatosBindingSource As BindingSource
    Friend WithEvents AviosDSX1 As AviosDSX
    Friend WithEvents locaBindingSource As BindingSource
    Friend WithEvents AviosDSX2 As AviosDSX
    Friend WithEvents MuniBindingSource As BindingSource
    Friend WithEvents EdosBindingSource As BindingSource
    Friend WithEvents FIRALocalidadesBindingSource As BindingSource
    Friend WithEvents FIRAMunicipiosBindingSource As BindingSource
    Friend WithEvents FIRAEstadosBindingSource As BindingSource
    Friend WithEvents FirA_AnexosDatosTableAdapter1 As AviosDSXTableAdapters.FIRA_AnexosDatosTableAdapter
    Friend WithEvents FIRA_EstadosTableAdapter As AviosDSXTableAdapters.FIRA_EstadosTableAdapter
    Friend WithEvents FIRA_MunicipiosTableAdapter As AviosDSXTableAdapters.FIRA_MunicipiosTableAdapter
    Friend WithEvents FIRA_LocalidadesTableAdapter As AviosDSXTableAdapters.FIRA_LocalidadesTableAdapter
    Friend WithEvents CmbLocaInver As ComboBox
    Friend WithEvents CmbMuniInver As ComboBox
    Friend WithEvents CmbEdoInver As ComboBox
    Friend WithEvents Txringresos As TextBox
    Friend WithEvents CmbLocaAcre As ComboBox
    Friend WithEvents CmbMuniAcre As ComboBox
    Friend WithEvents CbBEdoAcre As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents LbCastigo As Label
    Friend WithEvents Button1 As Button
    Dim ClienteAux As String = ""
    Friend WithEvents TxtMoneda As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents LbStatus As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents TxtTaspen As TextBox
    Friend WithEvents TxtSucursal As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Dim HCsol As Boolean

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal cAnexo As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.Text = "Datos del Contrato " & cAnexo
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
    Friend WithEvents lblIva As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTasai As System.Windows.Forms.Label
    Friend WithEvents lblDifer As System.Windows.Forms.Label
    Friend WithEvents lblCriteriotasa As System.Windows.Forms.Label
    Friend WithEvents lblFrecpag As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblRecursos As System.Windows.Forms.Label
    Friend WithEvents txtFondeo As System.Windows.Forms.TextBox
    Friend WithEvents lblEqmap As System.Windows.Forms.Label
    Friend WithEvents lblTipotasa As System.Windows.Forms.Label
    Friend WithEvents gpoPagos As System.Windows.Forms.GroupBox
    Friend WithEvents gpoPagosi As System.Windows.Forms.GroupBox
    Friend WithEvents lblComis As System.Windows.Forms.Label
    Friend WithEvents lblImpDG As System.Windows.Forms.Label
    Friend WithEvents lblIvag As System.Windows.Forms.Label
    Friend WithEvents lblRatific As System.Windows.Forms.Label
    Friend WithEvents lblNafin As System.Windows.Forms.Label
    Friend WithEvents lblTotalpagos As System.Windows.Forms.Label
    Friend WithEvents txtComis As System.Windows.Forms.TextBox
    Friend WithEvents txtNafin As System.Windows.Forms.TextBox
    Friend WithEvents lblSeg As System.Windows.Forms.Label
    Friend WithEvents lblPlazos As System.Windows.Forms.Label
    Friend WithEvents lblMontos As System.Windows.Forms.Label
    Friend WithEvents lblMontof As System.Windows.Forms.Label
    Friend WithEvents lblOpcom As System.Windows.Forms.Label
    Friend WithEvents lblIvaeq As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblPlazo As System.Windows.Forms.Label
    Friend WithEvents txtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents txtIvaeq As System.Windows.Forms.TextBox
    Friend WithEvents lblGaran As System.Windows.Forms.Label
    Friend WithEvents btnDatoseq As System.Windows.Forms.Button
    Friend WithEvents btnReferencia As System.Windows.Forms.Button
    Friend WithEvents txtTermina As System.Windows.Forms.TextBox
    Friend WithEvents txtDescTipar As System.Windows.Forms.TextBox
    Friend WithEvents txtPorieq As System.Windows.Forms.TextBox
    Friend WithEvents txtPorco As System.Windows.Forms.TextBox
    Friend WithEvents txtPorop As System.Windows.Forms.TextBox
    Friend WithEvents txtTasas As System.Windows.Forms.TextBox
    Friend WithEvents txtDifer As System.Windows.Forms.TextBox
    Friend WithEvents txtCritas As System.Windows.Forms.TextBox
    Friend WithEvents txtFrecuencia As System.Windows.Forms.TextBox
    Friend WithEvents txtForca As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenda As System.Windows.Forms.TextBox
    Friend WithEvents txtImpDG As System.Windows.Forms.TextBox
    Friend WithEvents txtIvaDG As System.Windows.Forms.TextBox
    Friend WithEvents txtGastos As System.Windows.Forms.TextBox
    Friend WithEvents txtImpEq As System.Windows.Forms.TextBox
    Friend WithEvents txtFinse As System.Windows.Forms.TextBox
    Friend WithEvents txtPlaseg As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoSeguro As System.Windows.Forms.TextBox
    Friend WithEvents txtOpcion As System.Windows.Forms.TextBox
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents btnDatosCliente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnTablaEquipo As System.Windows.Forms.Button
    Friend WithEvents btnTablaSeguro As System.Windows.Forms.Button
    Friend WithEvents btnHistoria As System.Windows.Forms.Button
    Friend WithEvents txtMontoFinanciado As System.Windows.Forms.TextBox
    Friend WithEvents txtDescTasa As System.Windows.Forms.TextBox
    Friend WithEvents txtPagosIniciales As System.Windows.Forms.TextBox
    Friend WithEvents txtIvaAmorin As System.Windows.Forms.TextBox
    Friend WithEvents txtAmorin As System.Windows.Forms.TextBox
    Friend WithEvents lblIvaamortiza As System.Windows.Forms.Label
    Friend WithEvents lblAmortiza As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblAnexo As System.Windows.Forms.Label
    Friend WithEvents txtImpRD As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnTablaOtros As System.Windows.Forms.Button
    Friend WithEvents txtIvaRD As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDescr As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtPrenda = New System.Windows.Forms.TextBox()
        Me.lblGaran = New System.Windows.Forms.Label()
        Me.gpoPagosi = New System.Windows.Forms.GroupBox()
        Me.TxtFondoReserva = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtIvaRD = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtImpRD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIvaAmorin = New System.Windows.Forms.TextBox()
        Me.txtAmorin = New System.Windows.Forms.TextBox()
        Me.lblIvaamortiza = New System.Windows.Forms.Label()
        Me.lblAmortiza = New System.Windows.Forms.Label()
        Me.txtPagosIniciales = New System.Windows.Forms.TextBox()
        Me.txtNafin = New System.Windows.Forms.TextBox()
        Me.txtGastos = New System.Windows.Forms.TextBox()
        Me.txtIvaDG = New System.Windows.Forms.TextBox()
        Me.txtImpDG = New System.Windows.Forms.TextBox()
        Me.txtComis = New System.Windows.Forms.TextBox()
        Me.lblTotalpagos = New System.Windows.Forms.Label()
        Me.lblNafin = New System.Windows.Forms.Label()
        Me.lblRatific = New System.Windows.Forms.Label()
        Me.lblIvag = New System.Windows.Forms.Label()
        Me.lblImpDG = New System.Windows.Forms.Label()
        Me.lblComis = New System.Windows.Forms.Label()
        Me.gpoPagos = New System.Windows.Forms.GroupBox()
        Me.txtMontoFinanciado = New System.Windows.Forms.TextBox()
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.txtSaldoSeguro = New System.Windows.Forms.TextBox()
        Me.txtPlaseg = New System.Windows.Forms.TextBox()
        Me.txtFinse = New System.Windows.Forms.TextBox()
        Me.txtIvaeq = New System.Windows.Forms.TextBox()
        Me.txtImpEq = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblIvaeq = New System.Windows.Forms.Label()
        Me.lblOpcom = New System.Windows.Forms.Label()
        Me.lblMontof = New System.Windows.Forms.Label()
        Me.lblMontos = New System.Windows.Forms.Label()
        Me.lblPlazos = New System.Windows.Forms.Label()
        Me.lblSeg = New System.Windows.Forms.Label()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.txtDescTasa = New System.Windows.Forms.TextBox()
        Me.lblTipotasa = New System.Windows.Forms.Label()
        Me.txtForca = New System.Windows.Forms.TextBox()
        Me.lblEqmap = New System.Windows.Forms.Label()
        Me.txtFondeo = New System.Windows.Forms.TextBox()
        Me.lblRecursos = New System.Windows.Forms.Label()
        Me.txtFrecuencia = New System.Windows.Forms.TextBox()
        Me.txtCritas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDifer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTasas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPorop = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPorco = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPorieq = New System.Windows.Forms.TextBox()
        Me.txtDescTipar = New System.Windows.Forms.TextBox()
        Me.txtTermina = New System.Windows.Forms.TextBox()
        Me.lblFrecpag = New System.Windows.Forms.Label()
        Me.lblCriteriotasa = New System.Windows.Forms.Label()
        Me.lblDifer = New System.Windows.Forms.Label()
        Me.lblTasai = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.lblFechafin = New System.Windows.Forms.Label()
        Me.txtFvenc = New System.Windows.Forms.TextBox()
        Me.txtFechacon = New System.Windows.Forms.TextBox()
        Me.lblFechaven1 = New System.Windows.Forms.Label()
        Me.lblFechac = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblNumc = New System.Windows.Forms.Label()
        Me.btnDatosCliente = New System.Windows.Forms.Button()
        Me.btnDatoseq = New System.Windows.Forms.Button()
        Me.btnReferencia = New System.Windows.Forms.Button()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.btnTablaEquipo = New System.Windows.Forms.Button()
        Me.btnTablaSeguro = New System.Windows.Forms.Button()
        Me.btnHistoria = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblAnexo = New System.Windows.Forms.Label()
        Me.lblDescr = New System.Windows.Forms.Label()
        Me.btnTablaOtros = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtGHipot = New System.Windows.Forms.TextBox()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.txtNotaria = New System.Windows.Forms.TextBox()
        Me.txtEscritura = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
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
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtZ08 = New System.Windows.Forms.TextBox()
        Me.CkGSF = New System.Windows.Forms.CheckBox()
        Me.DtGarantia = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtIdgarantia = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtZ25 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BtnFira = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtIDDTU = New System.Windows.Forms.TextBox()
        Me.txtIDCredito = New System.Windows.Forms.TextBox()
        Me.txtIDContrato = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtIDPersona = New System.Windows.Forms.TextBox()
        Me.TxtValorGar = New System.Windows.Forms.TextBox()
        Me.TxtValorHipo = New System.Windows.Forms.TextBox()
        Me.BtnOnbase = New System.Windows.Forms.Button()
        Me.TxtContMarco = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTasaIvacap = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BtnOnbaseCRE = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtFechaPAG = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtFechaACTI = New System.Windows.Forms.TextBox()
        Me.BtnOnbaseFira = New System.Windows.Forms.Button()
        Me.BtnSoldoc = New System.Windows.Forms.Button()
        Me.ControlGastosEXT1 = New Agil.ControlGastosEXT()
        Me.FirA_AnexosDatosTableAdapter1 = New Agil.AviosDSXTableAdapters.FIRA_AnexosDatosTableAdapter()
        Me.FIRA_EstadosTableAdapter = New Agil.AviosDSXTableAdapters.FIRA_EstadosTableAdapter()
        Me.FIRA_MunicipiosTableAdapter = New Agil.AviosDSXTableAdapters.FIRA_MunicipiosTableAdapter()
        Me.FIRA_LocalidadesTableAdapter = New Agil.AviosDSXTableAdapters.FIRA_LocalidadesTableAdapter()
        Me.LbCastigo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtMoneda = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.LbStatus = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TxtTaspen = New System.Windows.Forms.TextBox()
        Me.TxtSucursal = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.gpoPagosi.SuspendLayout()
        Me.gpoPagos.SuspendLayout()
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
        'txtPrenda
        '
        Me.txtPrenda.Location = New System.Drawing.Point(144, 432)
        Me.txtPrenda.Name = "txtPrenda"
        Me.txtPrenda.ReadOnly = True
        Me.txtPrenda.Size = New System.Drawing.Size(16, 20)
        Me.txtPrenda.TabIndex = 51
        Me.txtPrenda.TabStop = False
        '
        'lblGaran
        '
        Me.lblGaran.Location = New System.Drawing.Point(16, 432)
        Me.lblGaran.Name = "lblGaran"
        Me.lblGaran.Size = New System.Drawing.Size(120, 16)
        Me.lblGaran.TabIndex = 50
        Me.lblGaran.Text = "Garantía Prendaria ?"
        Me.lblGaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gpoPagosi
        '
        Me.gpoPagosi.Controls.Add(Me.TxtFondoReserva)
        Me.gpoPagosi.Controls.Add(Me.Label14)
        Me.gpoPagosi.Controls.Add(Me.txtIvaRD)
        Me.gpoPagosi.Controls.Add(Me.Label8)
        Me.gpoPagosi.Controls.Add(Me.txtImpRD)
        Me.gpoPagosi.Controls.Add(Me.Label7)
        Me.gpoPagosi.Controls.Add(Me.txtIvaAmorin)
        Me.gpoPagosi.Controls.Add(Me.txtAmorin)
        Me.gpoPagosi.Controls.Add(Me.lblIvaamortiza)
        Me.gpoPagosi.Controls.Add(Me.lblAmortiza)
        Me.gpoPagosi.Controls.Add(Me.txtPagosIniciales)
        Me.gpoPagosi.Controls.Add(Me.txtNafin)
        Me.gpoPagosi.Controls.Add(Me.txtGastos)
        Me.gpoPagosi.Controls.Add(Me.txtIvaDG)
        Me.gpoPagosi.Controls.Add(Me.txtImpDG)
        Me.gpoPagosi.Controls.Add(Me.txtComis)
        Me.gpoPagosi.Controls.Add(Me.lblTotalpagos)
        Me.gpoPagosi.Controls.Add(Me.lblNafin)
        Me.gpoPagosi.Controls.Add(Me.lblRatific)
        Me.gpoPagosi.Controls.Add(Me.lblIvag)
        Me.gpoPagosi.Controls.Add(Me.lblImpDG)
        Me.gpoPagosi.Controls.Add(Me.lblComis)
        Me.gpoPagosi.Location = New System.Drawing.Point(384, 230)
        Me.gpoPagosi.Name = "gpoPagosi"
        Me.gpoPagosi.Size = New System.Drawing.Size(264, 290)
        Me.gpoPagosi.TabIndex = 49
        Me.gpoPagosi.TabStop = False
        Me.gpoPagosi.Text = "Pagos Iniciales"
        '
        'TxtFondoReserva
        '
        Me.TxtFondoReserva.Location = New System.Drawing.Point(168, 240)
        Me.TxtFondoReserva.Name = "TxtFondoReserva"
        Me.TxtFondoReserva.ReadOnly = True
        Me.TxtFondoReserva.Size = New System.Drawing.Size(88, 20)
        Me.TxtFondoReserva.TabIndex = 87
        Me.TxtFondoReserva.TabStop = False
        Me.TxtFondoReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 266)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 16)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Total de Pagos Iniciales"
        '
        'txtIvaRD
        '
        Me.txtIvaRD.Location = New System.Drawing.Point(168, 216)
        Me.txtIvaRD.Name = "txtIvaRD"
        Me.txtIvaRD.ReadOnly = True
        Me.txtIvaRD.Size = New System.Drawing.Size(88, 20)
        Me.txtIvaRD.TabIndex = 85
        Me.txtIvaRD.TabStop = False
        Me.txtIvaRD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 16)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "I.V.A. Rentas en Depósito"
        '
        'txtImpRD
        '
        Me.txtImpRD.Location = New System.Drawing.Point(168, 192)
        Me.txtImpRD.Name = "txtImpRD"
        Me.txtImpRD.ReadOnly = True
        Me.txtImpRD.Size = New System.Drawing.Size(88, 20)
        Me.txtImpRD.TabIndex = 83
        Me.txtImpRD.TabStop = False
        Me.txtImpRD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 16)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Rentas en Depósito"
        '
        'txtIvaAmorin
        '
        Me.txtIvaAmorin.Location = New System.Drawing.Point(168, 48)
        Me.txtIvaAmorin.Name = "txtIvaAmorin"
        Me.txtIvaAmorin.ReadOnly = True
        Me.txtIvaAmorin.Size = New System.Drawing.Size(88, 20)
        Me.txtIvaAmorin.TabIndex = 81
        Me.txtIvaAmorin.TabStop = False
        Me.txtIvaAmorin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmorin
        '
        Me.txtAmorin.Location = New System.Drawing.Point(168, 24)
        Me.txtAmorin.Name = "txtAmorin"
        Me.txtAmorin.ReadOnly = True
        Me.txtAmorin.Size = New System.Drawing.Size(88, 20)
        Me.txtAmorin.TabIndex = 80
        Me.txtAmorin.TabStop = False
        Me.txtAmorin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblIvaamortiza
        '
        Me.lblIvaamortiza.Location = New System.Drawing.Point(8, 48)
        Me.lblIvaamortiza.Name = "lblIvaamortiza"
        Me.lblIvaamortiza.Size = New System.Drawing.Size(156, 16)
        Me.lblIvaamortiza.TabIndex = 79
        Me.lblIvaamortiza.Text = "I.V.A. de la Amortización"
        '
        'lblAmortiza
        '
        Me.lblAmortiza.Location = New System.Drawing.Point(8, 24)
        Me.lblAmortiza.Name = "lblAmortiza"
        Me.lblAmortiza.Size = New System.Drawing.Size(156, 16)
        Me.lblAmortiza.TabIndex = 78
        Me.lblAmortiza.Text = "Amortización Inicial"
        '
        'txtPagosIniciales
        '
        Me.txtPagosIniciales.Location = New System.Drawing.Point(168, 266)
        Me.txtPagosIniciales.Name = "txtPagosIniciales"
        Me.txtPagosIniciales.ReadOnly = True
        Me.txtPagosIniciales.Size = New System.Drawing.Size(88, 20)
        Me.txtPagosIniciales.TabIndex = 64
        Me.txtPagosIniciales.TabStop = False
        Me.txtPagosIniciales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNafin
        '
        Me.txtNafin.Location = New System.Drawing.Point(168, 168)
        Me.txtNafin.Name = "txtNafin"
        Me.txtNafin.ReadOnly = True
        Me.txtNafin.Size = New System.Drawing.Size(88, 20)
        Me.txtNafin.TabIndex = 62
        Me.txtNafin.TabStop = False
        Me.txtNafin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGastos
        '
        Me.txtGastos.Location = New System.Drawing.Point(168, 144)
        Me.txtGastos.Name = "txtGastos"
        Me.txtGastos.ReadOnly = True
        Me.txtGastos.Size = New System.Drawing.Size(88, 20)
        Me.txtGastos.TabIndex = 60
        Me.txtGastos.TabStop = False
        Me.txtGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIvaDG
        '
        Me.txtIvaDG.Location = New System.Drawing.Point(168, 120)
        Me.txtIvaDG.Name = "txtIvaDG"
        Me.txtIvaDG.ReadOnly = True
        Me.txtIvaDG.Size = New System.Drawing.Size(88, 20)
        Me.txtIvaDG.TabIndex = 58
        Me.txtIvaDG.TabStop = False
        Me.txtIvaDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpDG
        '
        Me.txtImpDG.Location = New System.Drawing.Point(168, 96)
        Me.txtImpDG.Name = "txtImpDG"
        Me.txtImpDG.ReadOnly = True
        Me.txtImpDG.Size = New System.Drawing.Size(88, 20)
        Me.txtImpDG.TabIndex = 56
        Me.txtImpDG.TabStop = False
        Me.txtImpDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtComis
        '
        Me.txtComis.Location = New System.Drawing.Point(168, 72)
        Me.txtComis.Name = "txtComis"
        Me.txtComis.ReadOnly = True
        Me.txtComis.Size = New System.Drawing.Size(88, 20)
        Me.txtComis.TabIndex = 54
        Me.txtComis.TabStop = False
        Me.txtComis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalpagos
        '
        Me.lblTotalpagos.Location = New System.Drawing.Point(8, 240)
        Me.lblTotalpagos.Name = "lblTotalpagos"
        Me.lblTotalpagos.Size = New System.Drawing.Size(156, 16)
        Me.lblTotalpagos.TabIndex = 52
        Me.lblTotalpagos.Text = "Fondo de Reserva"
        '
        'lblNafin
        '
        Me.lblNafin.Location = New System.Drawing.Point(8, 168)
        Me.lblNafin.Name = "lblNafin"
        Me.lblNafin.Size = New System.Drawing.Size(156, 16)
        Me.lblNafin.TabIndex = 51
        Me.lblNafin.Text = "5 % NAFIN"
        '
        'lblRatific
        '
        Me.lblRatific.Location = New System.Drawing.Point(8, 144)
        Me.lblRatific.Name = "lblRatific"
        Me.lblRatific.Size = New System.Drawing.Size(156, 16)
        Me.lblRatific.TabIndex = 50
        Me.lblRatific.Text = "Ratificación con I.V.A."
        '
        'lblIvag
        '
        Me.lblIvag.Location = New System.Drawing.Point(8, 120)
        Me.lblIvag.Name = "lblIvag"
        Me.lblIvag.Size = New System.Drawing.Size(156, 16)
        Me.lblIvag.TabIndex = 49
        Me.lblIvag.Text = "I.V.A. del Depósito"
        '
        'lblImpDG
        '
        Me.lblImpDG.Location = New System.Drawing.Point(8, 96)
        Me.lblImpDG.Name = "lblImpDG"
        Me.lblImpDG.Size = New System.Drawing.Size(156, 16)
        Me.lblImpDG.TabIndex = 48
        Me.lblImpDG.Text = "Depósito en Garantía"
        '
        'lblComis
        '
        Me.lblComis.Location = New System.Drawing.Point(8, 72)
        Me.lblComis.Name = "lblComis"
        Me.lblComis.Size = New System.Drawing.Size(156, 16)
        Me.lblComis.TabIndex = 47
        Me.lblComis.Text = "Comisión con I.V.A."
        '
        'gpoPagos
        '
        Me.gpoPagos.Controls.Add(Me.txtMontoFinanciado)
        Me.gpoPagos.Controls.Add(Me.txtOpcion)
        Me.gpoPagos.Controls.Add(Me.txtSaldoSeguro)
        Me.gpoPagos.Controls.Add(Me.txtPlaseg)
        Me.gpoPagos.Controls.Add(Me.txtFinse)
        Me.gpoPagos.Controls.Add(Me.txtIvaeq)
        Me.gpoPagos.Controls.Add(Me.txtImpEq)
        Me.gpoPagos.Controls.Add(Me.Label27)
        Me.gpoPagos.Controls.Add(Me.lblIvaeq)
        Me.gpoPagos.Controls.Add(Me.lblOpcom)
        Me.gpoPagos.Controls.Add(Me.lblMontof)
        Me.gpoPagos.Controls.Add(Me.lblMontos)
        Me.gpoPagos.Controls.Add(Me.lblPlazos)
        Me.gpoPagos.Controls.Add(Me.lblSeg)
        Me.gpoPagos.Location = New System.Drawing.Point(384, 32)
        Me.gpoPagos.Name = "gpoPagos"
        Me.gpoPagos.Size = New System.Drawing.Size(264, 192)
        Me.gpoPagos.TabIndex = 48
        Me.gpoPagos.TabStop = False
        '
        'txtMontoFinanciado
        '
        Me.txtMontoFinanciado.Location = New System.Drawing.Point(168, 160)
        Me.txtMontoFinanciado.Name = "txtMontoFinanciado"
        Me.txtMontoFinanciado.ReadOnly = True
        Me.txtMontoFinanciado.Size = New System.Drawing.Size(88, 20)
        Me.txtMontoFinanciado.TabIndex = 76
        Me.txtMontoFinanciado.TabStop = False
        Me.txtMontoFinanciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOpcion
        '
        Me.txtOpcion.Location = New System.Drawing.Point(168, 136)
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.ReadOnly = True
        Me.txtOpcion.Size = New System.Drawing.Size(88, 20)
        Me.txtOpcion.TabIndex = 74
        Me.txtOpcion.TabStop = False
        Me.txtOpcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoSeguro
        '
        Me.txtSaldoSeguro.Location = New System.Drawing.Point(168, 112)
        Me.txtSaldoSeguro.Name = "txtSaldoSeguro"
        Me.txtSaldoSeguro.ReadOnly = True
        Me.txtSaldoSeguro.Size = New System.Drawing.Size(88, 20)
        Me.txtSaldoSeguro.TabIndex = 72
        Me.txtSaldoSeguro.TabStop = False
        Me.txtSaldoSeguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPlaseg
        '
        Me.txtPlaseg.Location = New System.Drawing.Point(232, 88)
        Me.txtPlaseg.Name = "txtPlaseg"
        Me.txtPlaseg.ReadOnly = True
        Me.txtPlaseg.Size = New System.Drawing.Size(24, 20)
        Me.txtPlaseg.TabIndex = 71
        Me.txtPlaseg.TabStop = False
        Me.txtPlaseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFinse
        '
        Me.txtFinse.Location = New System.Drawing.Point(232, 64)
        Me.txtFinse.Name = "txtFinse"
        Me.txtFinse.ReadOnly = True
        Me.txtFinse.Size = New System.Drawing.Size(24, 20)
        Me.txtFinse.TabIndex = 70
        Me.txtFinse.TabStop = False
        Me.txtFinse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIvaeq
        '
        Me.txtIvaeq.Location = New System.Drawing.Point(168, 40)
        Me.txtIvaeq.Name = "txtIvaeq"
        Me.txtIvaeq.ReadOnly = True
        Me.txtIvaeq.Size = New System.Drawing.Size(88, 20)
        Me.txtIvaeq.TabIndex = 65
        Me.txtIvaeq.TabStop = False
        Me.txtIvaeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'lblIvaeq
        '
        Me.lblIvaeq.Location = New System.Drawing.Point(8, 40)
        Me.lblIvaeq.Name = "lblIvaeq"
        Me.lblIvaeq.Size = New System.Drawing.Size(144, 16)
        Me.lblIvaeq.TabIndex = 57
        Me.lblIvaeq.Text = "I.V.A. del Equipo"
        '
        'lblOpcom
        '
        Me.lblOpcom.Location = New System.Drawing.Point(8, 136)
        Me.lblOpcom.Name = "lblOpcom"
        Me.lblOpcom.Size = New System.Drawing.Size(144, 16)
        Me.lblOpcom.TabIndex = 55
        Me.lblOpcom.Text = "Opción a compra con I.V.A."
        '
        'lblMontof
        '
        Me.lblMontof.Location = New System.Drawing.Point(8, 160)
        Me.lblMontof.Name = "lblMontof"
        Me.lblMontof.Size = New System.Drawing.Size(144, 16)
        Me.lblMontof.TabIndex = 54
        Me.lblMontof.Text = "Monto Financiado"
        '
        'lblMontos
        '
        Me.lblMontos.Location = New System.Drawing.Point(8, 112)
        Me.lblMontos.Name = "lblMontos"
        Me.lblMontos.Size = New System.Drawing.Size(144, 16)
        Me.lblMontos.TabIndex = 53
        Me.lblMontos.Text = "Monto del Seguro"
        '
        'lblPlazos
        '
        Me.lblPlazos.Location = New System.Drawing.Point(8, 88)
        Me.lblPlazos.Name = "lblPlazos"
        Me.lblPlazos.Size = New System.Drawing.Size(144, 16)
        Me.lblPlazos.TabIndex = 52
        Me.lblPlazos.Text = "Plazo del Seguro en meses"
        '
        'lblSeg
        '
        Me.lblSeg.Location = New System.Drawing.Point(8, 64)
        Me.lblSeg.Name = "lblSeg"
        Me.lblSeg.Size = New System.Drawing.Size(144, 16)
        Me.lblSeg.TabIndex = 50
        Me.lblSeg.Text = "Seguro Financiado (S/N)"
        '
        'txtPlazo
        '
        Me.txtPlazo.Location = New System.Drawing.Point(240, 120)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.ReadOnly = True
        Me.txtPlazo.Size = New System.Drawing.Size(24, 20)
        Me.txtPlazo.TabIndex = 61
        Me.txtPlazo.TabStop = False
        Me.txtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPlazo
        '
        Me.lblPlazo.Location = New System.Drawing.Point(16, 124)
        Me.lblPlazo.Name = "lblPlazo"
        Me.lblPlazo.Size = New System.Drawing.Size(136, 16)
        Me.lblPlazo.TabIndex = 59
        Me.lblPlazo.Text = "No. Pagos"
        Me.lblPlazo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescTasa
        '
        Me.txtDescTasa.Location = New System.Drawing.Point(144, 408)
        Me.txtDescTasa.Name = "txtDescTasa"
        Me.txtDescTasa.ReadOnly = True
        Me.txtDescTasa.Size = New System.Drawing.Size(224, 20)
        Me.txtDescTasa.TabIndex = 47
        Me.txtDescTasa.TabStop = False
        '
        'lblTipotasa
        '
        Me.lblTipotasa.Location = New System.Drawing.Point(16, 408)
        Me.lblTipotasa.Name = "lblTipotasa"
        Me.lblTipotasa.Size = New System.Drawing.Size(120, 16)
        Me.lblTipotasa.TabIndex = 46
        Me.lblTipotasa.Text = "Tipo de Tasa"
        Me.lblTipotasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtForca
        '
        Me.txtForca.Location = New System.Drawing.Point(144, 384)
        Me.txtForca.Name = "txtForca"
        Me.txtForca.ReadOnly = True
        Me.txtForca.Size = New System.Drawing.Size(136, 20)
        Me.txtForca.TabIndex = 39
        Me.txtForca.TabStop = False
        '
        'lblEqmap
        '
        Me.lblEqmap.Location = New System.Drawing.Point(16, 384)
        Me.lblEqmap.Name = "lblEqmap"
        Me.lblEqmap.Size = New System.Drawing.Size(120, 16)
        Me.lblEqmap.TabIndex = 38
        Me.lblEqmap.Text = "Esquema de Pagos"
        Me.lblEqmap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFondeo
        '
        Me.txtFondeo.Location = New System.Drawing.Point(144, 360)
        Me.txtFondeo.Name = "txtFondeo"
        Me.txtFondeo.ReadOnly = True
        Me.txtFondeo.Size = New System.Drawing.Size(136, 20)
        Me.txtFondeo.TabIndex = 37
        Me.txtFondeo.TabStop = False
        '
        'lblRecursos
        '
        Me.lblRecursos.Location = New System.Drawing.Point(16, 360)
        Me.lblRecursos.Name = "lblRecursos"
        Me.lblRecursos.Size = New System.Drawing.Size(120, 16)
        Me.lblRecursos.TabIndex = 36
        Me.lblRecursos.Text = "Recursos"
        Me.lblRecursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFrecuencia
        '
        Me.txtFrecuencia.Location = New System.Drawing.Point(144, 336)
        Me.txtFrecuencia.Name = "txtFrecuencia"
        Me.txtFrecuencia.ReadOnly = True
        Me.txtFrecuencia.Size = New System.Drawing.Size(136, 20)
        Me.txtFrecuencia.TabIndex = 35
        Me.txtFrecuencia.TabStop = False
        '
        'txtCritas
        '
        Me.txtCritas.Location = New System.Drawing.Point(144, 312)
        Me.txtCritas.Name = "txtCritas"
        Me.txtCritas.ReadOnly = True
        Me.txtCritas.Size = New System.Drawing.Size(136, 20)
        Me.txtCritas.TabIndex = 34
        Me.txtCritas.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(200, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "%"
        '
        'txtDifer
        '
        Me.txtDifer.Location = New System.Drawing.Point(144, 263)
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
        Me.Label5.Location = New System.Drawing.Point(200, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "%"
        '
        'txtTasas
        '
        Me.txtTasas.Location = New System.Drawing.Point(144, 239)
        Me.txtTasas.Name = "txtTasas"
        Me.txtTasas.ReadOnly = True
        Me.txtTasas.Size = New System.Drawing.Size(56, 20)
        Me.txtTasas.TabIndex = 24
        Me.txtTasas.TabStop = False
        Me.txtTasas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(200, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "%"
        '
        'txtPorop
        '
        Me.txtPorop.Location = New System.Drawing.Point(144, 215)
        Me.txtPorop.Name = "txtPorop"
        Me.txtPorop.ReadOnly = True
        Me.txtPorop.Size = New System.Drawing.Size(56, 20)
        Me.txtPorop.TabIndex = 22
        Me.txtPorop.TabStop = False
        Me.txtPorop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "%"
        '
        'txtPorco
        '
        Me.txtPorco.Location = New System.Drawing.Point(104, 190)
        Me.txtPorco.Name = "txtPorco"
        Me.txtPorco.ReadOnly = True
        Me.txtPorco.Size = New System.Drawing.Size(56, 20)
        Me.txtPorco.TabIndex = 20
        Me.txtPorco.TabStop = False
        Me.txtPorco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "%"
        '
        'txtPorieq
        '
        Me.txtPorieq.Location = New System.Drawing.Point(144, 167)
        Me.txtPorieq.Name = "txtPorieq"
        Me.txtPorieq.ReadOnly = True
        Me.txtPorieq.Size = New System.Drawing.Size(56, 20)
        Me.txtPorieq.TabIndex = 18
        Me.txtPorieq.TabStop = False
        Me.txtPorieq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescTipar
        '
        Me.txtDescTipar.Location = New System.Drawing.Point(144, 48)
        Me.txtDescTipar.Name = "txtDescTipar"
        Me.txtDescTipar.ReadOnly = True
        Me.txtDescTipar.Size = New System.Drawing.Size(224, 20)
        Me.txtDescTipar.TabIndex = 17
        Me.txtDescTipar.TabStop = False
        '
        'txtTermina
        '
        Me.txtTermina.Location = New System.Drawing.Point(200, 144)
        Me.txtTermina.Name = "txtTermina"
        Me.txtTermina.ReadOnly = True
        Me.txtTermina.Size = New System.Drawing.Size(64, 20)
        Me.txtTermina.TabIndex = 16
        Me.txtTermina.TabStop = False
        Me.txtTermina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFrecpag
        '
        Me.lblFrecpag.Location = New System.Drawing.Point(16, 336)
        Me.lblFrecpag.Name = "lblFrecpag"
        Me.lblFrecpag.Size = New System.Drawing.Size(120, 16)
        Me.lblFrecpag.TabIndex = 15
        Me.lblFrecpag.Text = "Frecuencia de pago"
        Me.lblFrecpag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCriteriotasa
        '
        Me.lblCriteriotasa.Location = New System.Drawing.Point(16, 312)
        Me.lblCriteriotasa.Name = "lblCriteriotasa"
        Me.lblCriteriotasa.Size = New System.Drawing.Size(120, 16)
        Me.lblCriteriotasa.TabIndex = 14
        Me.lblCriteriotasa.Text = "Criterio de Tasa"
        Me.lblCriteriotasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDifer
        '
        Me.lblDifer.Location = New System.Drawing.Point(16, 263)
        Me.lblDifer.Name = "lblDifer"
        Me.lblDifer.Size = New System.Drawing.Size(120, 16)
        Me.lblDifer.TabIndex = 13
        Me.lblDifer.Text = "Diferencial"
        Me.lblDifer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTasai
        '
        Me.lblTasai.Location = New System.Drawing.Point(16, 239)
        Me.lblTasai.Name = "lblTasai"
        Me.lblTasai.Size = New System.Drawing.Size(120, 16)
        Me.lblTasai.TabIndex = 12
        Me.lblTasai.Text = "Tasa de Interés"
        Me.lblTasai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Opción de Compra"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Comisión"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIva
        '
        Me.lblIva.Location = New System.Drawing.Point(16, 167)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(120, 16)
        Me.lblIva.TabIndex = 9
        Me.lblIva.Text = "I.V.A."
        Me.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechafin
        '
        Me.lblFechafin.Location = New System.Drawing.Point(16, 148)
        Me.lblFechafin.Name = "lblFechafin"
        Me.lblFechafin.Size = New System.Drawing.Size(136, 16)
        Me.lblFechafin.TabIndex = 8
        Me.lblFechafin.Text = "Fecha de Terminación"
        Me.lblFechafin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFvenc
        '
        Me.txtFvenc.Location = New System.Drawing.Point(200, 96)
        Me.txtFvenc.Name = "txtFvenc"
        Me.txtFvenc.ReadOnly = True
        Me.txtFvenc.Size = New System.Drawing.Size(64, 20)
        Me.txtFvenc.TabIndex = 7
        Me.txtFvenc.TabStop = False
        Me.txtFvenc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFechacon
        '
        Me.txtFechacon.Location = New System.Drawing.Point(200, 72)
        Me.txtFechacon.Name = "txtFechacon"
        Me.txtFechacon.ReadOnly = True
        Me.txtFechacon.Size = New System.Drawing.Size(64, 20)
        Me.txtFechacon.TabIndex = 6
        Me.txtFechacon.TabStop = False
        Me.txtFechacon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFechaven1
        '
        Me.lblFechaven1.Location = New System.Drawing.Point(16, 100)
        Me.lblFechaven1.Name = "lblFechaven1"
        Me.lblFechaven1.Size = New System.Drawing.Size(136, 16)
        Me.lblFechaven1.TabIndex = 3
        Me.lblFechaven1.Text = "Fecha 1er. Vencimiento"
        Me.lblFechaven1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechac
        '
        Me.lblFechac.Location = New System.Drawing.Point(16, 76)
        Me.lblFechac.Name = "lblFechac"
        Me.lblFechac.Size = New System.Drawing.Size(136, 16)
        Me.lblFechac.TabIndex = 2
        Me.lblFechac.Text = "Fecha de Contratación"
        Me.lblFechac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(16, 48)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(103, 20)
        Me.lblTipo.TabIndex = 1
        Me.lblTipo.Text = "Producto"
        Me.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumc
        '
        Me.lblNumc.Location = New System.Drawing.Point(16, 12)
        Me.lblNumc.Name = "lblNumc"
        Me.lblNumc.Size = New System.Drawing.Size(88, 20)
        Me.lblNumc.TabIndex = 0
        Me.lblNumc.Text = "No. de Contrato"
        Me.lblNumc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDatosCliente
        '
        Me.btnDatosCliente.Enabled = False
        Me.btnDatosCliente.Location = New System.Drawing.Point(665, 119)
        Me.btnDatosCliente.Name = "btnDatosCliente"
        Me.btnDatosCliente.Size = New System.Drawing.Size(104, 24)
        Me.btnDatosCliente.TabIndex = 0
        Me.btnDatosCliente.Text = "Datos del Cliente"
        '
        'btnDatoseq
        '
        Me.btnDatoseq.Enabled = False
        Me.btnDatoseq.Location = New System.Drawing.Point(665, 148)
        Me.btnDatoseq.Name = "btnDatoseq"
        Me.btnDatoseq.Size = New System.Drawing.Size(104, 24)
        Me.btnDatoseq.TabIndex = 1
        Me.btnDatoseq.Text = "Datos del Equipo"
        '
        'btnReferencia
        '
        Me.btnReferencia.Enabled = False
        Me.btnReferencia.Location = New System.Drawing.Point(665, 177)
        Me.btnReferencia.Name = "btnReferencia"
        Me.btnReferencia.Size = New System.Drawing.Size(104, 24)
        Me.btnReferencia.TabIndex = 2
        Me.btnReferencia.Text = "Referencia"
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(618, 13)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(24, 20)
        Me.txtReferencia.TabIndex = 62
        Me.txtReferencia.Visible = False
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(588, 13)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(24, 20)
        Me.txtCliente.TabIndex = 63
        Me.txtCliente.Visible = False
        '
        'btnTablaEquipo
        '
        Me.btnTablaEquipo.Enabled = False
        Me.btnTablaEquipo.Location = New System.Drawing.Point(665, 206)
        Me.btnTablaEquipo.Name = "btnTablaEquipo"
        Me.btnTablaEquipo.Size = New System.Drawing.Size(104, 24)
        Me.btnTablaEquipo.TabIndex = 3
        Me.btnTablaEquipo.Text = "Tabla Equipo"
        '
        'btnTablaSeguro
        '
        Me.btnTablaSeguro.Enabled = False
        Me.btnTablaSeguro.Location = New System.Drawing.Point(665, 235)
        Me.btnTablaSeguro.Name = "btnTablaSeguro"
        Me.btnTablaSeguro.Size = New System.Drawing.Size(104, 24)
        Me.btnTablaSeguro.TabIndex = 4
        Me.btnTablaSeguro.Text = "Tabla Seguro"
        '
        'btnHistoria
        '
        Me.btnHistoria.Enabled = False
        Me.btnHistoria.Location = New System.Drawing.Point(665, 293)
        Me.btnHistoria.Name = "btnHistoria"
        Me.btnHistoria.Size = New System.Drawing.Size(104, 24)
        Me.btnHistoria.TabIndex = 5
        Me.btnHistoria.Text = "Historia de Pagos"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(192, 12)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(80, 20)
        Me.lblStatus.TabIndex = 69
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnexo
        '
        Me.lblAnexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnexo.Location = New System.Drawing.Point(112, 12)
        Me.lblAnexo.Name = "lblAnexo"
        Me.lblAnexo.Size = New System.Drawing.Size(72, 20)
        Me.lblAnexo.TabIndex = 70
        Me.lblAnexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescr
        '
        Me.lblDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescr.Location = New System.Drawing.Point(280, 12)
        Me.lblDescr.Name = "lblDescr"
        Me.lblDescr.Size = New System.Drawing.Size(480, 20)
        Me.lblDescr.TabIndex = 71
        Me.lblDescr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnTablaOtros
        '
        Me.btnTablaOtros.Enabled = False
        Me.btnTablaOtros.Location = New System.Drawing.Point(665, 264)
        Me.btnTablaOtros.Name = "btnTablaOtros"
        Me.btnTablaOtros.Size = New System.Drawing.Size(104, 24)
        Me.btnTablaOtros.TabIndex = 84
        Me.btnTablaOtros.Text = "Tabla Otros"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 454)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Garantía Hipotecaría ?"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGHipot
        '
        Me.txtGHipot.Location = New System.Drawing.Point(144, 453)
        Me.txtGHipot.Name = "txtGHipot"
        Me.txtGHipot.ReadOnly = True
        Me.txtGHipot.Size = New System.Drawing.Size(16, 20)
        Me.txtGHipot.TabIndex = 86
        Me.txtGHipot.TabStop = False
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(144, 499)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.ReadOnly = True
        Me.txtLugar.Size = New System.Drawing.Size(224, 20)
        Me.txtLugar.TabIndex = 87
        Me.txtLugar.TabStop = False
        Me.txtLugar.Visible = False
        Me.txtLugar.WordWrap = False
        '
        'txtNotaria
        '
        Me.txtNotaria.Location = New System.Drawing.Point(144, 521)
        Me.txtNotaria.Name = "txtNotaria"
        Me.txtNotaria.ReadOnly = True
        Me.txtNotaria.Size = New System.Drawing.Size(224, 20)
        Me.txtNotaria.TabIndex = 88
        Me.txtNotaria.TabStop = False
        Me.txtNotaria.Visible = False
        Me.txtNotaria.WordWrap = False
        '
        'txtEscritura
        '
        Me.txtEscritura.Location = New System.Drawing.Point(144, 543)
        Me.txtEscritura.Name = "txtEscritura"
        Me.txtEscritura.ReadOnly = True
        Me.txtEscritura.Size = New System.Drawing.Size(224, 20)
        Me.txtEscritura.TabIndex = 89
        Me.txtEscritura.TabStop = False
        Me.txtEscritura.Visible = False
        Me.txtEscritura.WordWrap = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(16, 502)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Lugar"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 524)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 16)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "Notaria"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(16, 544)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 16)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Escritura"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.Visible = False
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
        Me.gbDatosFIRA.Controls.Add(Me.Label28)
        Me.gbDatosFIRA.Controls.Add(Me.Label29)
        Me.gbDatosFIRA.Controls.Add(Me.Label30)
        Me.gbDatosFIRA.Controls.Add(Me.Label31)
        Me.gbDatosFIRA.Controls.Add(Me.Label32)
        Me.gbDatosFIRA.Controls.Add(Me.Label33)
        Me.gbDatosFIRA.Controls.Add(Me.Label34)
        Me.gbDatosFIRA.Controls.Add(Me.Label24)
        Me.gbDatosFIRA.Controls.Add(Me.TxtZ08)
        Me.gbDatosFIRA.Controls.Add(Me.CkGSF)
        Me.gbDatosFIRA.Controls.Add(Me.DtGarantia)
        Me.gbDatosFIRA.Controls.Add(Me.Label20)
        Me.gbDatosFIRA.Controls.Add(Me.TxtIdgarantia)
        Me.gbDatosFIRA.Controls.Add(Me.Label19)
        Me.gbDatosFIRA.Controls.Add(Me.TxtZ25)
        Me.gbDatosFIRA.Controls.Add(Me.Label18)
        Me.gbDatosFIRA.Controls.Add(Me.BtnFira)
        Me.gbDatosFIRA.Controls.Add(Me.Label21)
        Me.gbDatosFIRA.Controls.Add(Me.txtIDDTU)
        Me.gbDatosFIRA.Controls.Add(Me.txtIDCredito)
        Me.gbDatosFIRA.Controls.Add(Me.txtIDContrato)
        Me.gbDatosFIRA.Controls.Add(Me.Label15)
        Me.gbDatosFIRA.Controls.Add(Me.Label16)
        Me.gbDatosFIRA.Controls.Add(Me.Label17)
        Me.gbDatosFIRA.Controls.Add(Me.txtIDPersona)
        Me.gbDatosFIRA.Enabled = False
        Me.gbDatosFIRA.Location = New System.Drawing.Point(775, 26)
        Me.gbDatosFIRA.Name = "gbDatosFIRA"
        Me.gbDatosFIRA.Size = New System.Drawing.Size(251, 532)
        Me.gbDatosFIRA.TabIndex = 95
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
        Me.CmbLocaInver.Location = New System.Drawing.Point(114, 399)
        Me.CmbLocaInver.Name = "CmbLocaInver"
        Me.CmbLocaInver.Size = New System.Drawing.Size(128, 21)
        Me.CmbLocaInver.TabIndex = 101
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
        Me.CmbMuniInver.Location = New System.Drawing.Point(114, 372)
        Me.CmbMuniInver.Name = "CmbMuniInver"
        Me.CmbMuniInver.Size = New System.Drawing.Size(128, 21)
        Me.CmbMuniInver.TabIndex = 100
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
        Me.CmbEdoInver.Location = New System.Drawing.Point(114, 345)
        Me.CmbEdoInver.Name = "CmbEdoInver"
        Me.CmbEdoInver.Size = New System.Drawing.Size(128, 21)
        Me.CmbEdoInver.TabIndex = 99
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
        Me.Txringresos.Location = New System.Drawing.Point(114, 319)
        Me.Txringresos.Name = "Txringresos"
        Me.Txringresos.Size = New System.Drawing.Size(110, 20)
        Me.Txringresos.TabIndex = 98
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
        Me.CmbLocaAcre.Location = New System.Drawing.Point(114, 291)
        Me.CmbLocaAcre.Name = "CmbLocaAcre"
        Me.CmbLocaAcre.Size = New System.Drawing.Size(128, 21)
        Me.CmbLocaAcre.TabIndex = 97
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
        Me.CmbMuniAcre.Location = New System.Drawing.Point(114, 264)
        Me.CmbMuniAcre.Name = "CmbMuniAcre"
        Me.CmbMuniAcre.Size = New System.Drawing.Size(128, 21)
        Me.CmbMuniAcre.TabIndex = 96
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
        Me.CbBEdoAcre.Location = New System.Drawing.Point(114, 236)
        Me.CbBEdoAcre.Name = "CbBEdoAcre"
        Me.CbBEdoAcre.Size = New System.Drawing.Size(128, 21)
        Me.CbBEdoAcre.TabIndex = 95
        Me.CbBEdoAcre.ValueMember = "Cve Estado"
        '
        'FIRAEstadosBindingSource
        '
        Me.FIRAEstadosBindingSource.DataMember = "FIRA_Estados"
        Me.FIRAEstadosBindingSource.DataSource = Me.AviosDSX1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 402)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(99, 13)
        Me.Label28.TabIndex = 108
        Me.Label28.Text = "Localidad Inversión"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(7, 375)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(98, 13)
        Me.Label29.TabIndex = 107
        Me.Label29.Text = "Municipio Inversión"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(7, 348)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(86, 13)
        Me.Label30.TabIndex = 106
        Me.Label30.Text = "Estado Inversión"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(7, 322)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(78, 13)
        Me.Label31.TabIndex = 105
        Me.Label31.Text = "Ingresos Netos"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(7, 294)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(107, 13)
        Me.Label32.TabIndex = 104
        Me.Label32.Text = "Localidad Acreditado"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(7, 267)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(106, 13)
        Me.Label33.TabIndex = 103
        Me.Label33.Text = "Municipio Acreditado"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(7, 239)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(94, 13)
        Me.Label34.TabIndex = 102
        Me.Label34.Text = "Estado Acreditado"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 139)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(26, 13)
        Me.Label24.TabIndex = 91
        Me.Label24.Text = "Z08"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtZ08
        '
        Me.TxtZ08.Location = New System.Drawing.Point(76, 135)
        Me.TxtZ08.MaxLength = 1
        Me.TxtZ08.Name = "TxtZ08"
        Me.TxtZ08.Size = New System.Drawing.Size(38, 20)
        Me.TxtZ08.TabIndex = 80
        Me.TxtZ08.TabStop = False
        Me.TxtZ08.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CkGSF
        '
        Me.CkGSF.AutoSize = True
        Me.CkGSF.Location = New System.Drawing.Point(75, 207)
        Me.CkGSF.Name = "CkGSF"
        Me.CkGSF.Size = New System.Drawing.Size(91, 17)
        Me.CkGSF.TabIndex = 83
        Me.CkGSF.Text = "Gar.Sin.Fond."
        Me.CkGSF.UseVisualStyleBackColor = True
        '
        'DtGarantia
        '
        Me.DtGarantia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtGarantia.Location = New System.Drawing.Point(95, 181)
        Me.DtGarantia.Name = "DtGarantia"
        Me.DtGarantia.Size = New System.Drawing.Size(95, 20)
        Me.DtGarantia.TabIndex = 82
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 187)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 13)
        Me.Label20.TabIndex = 87
        Me.Label20.Text = "Fecha Garantia"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtIdgarantia
        '
        Me.TxtIdgarantia.Location = New System.Drawing.Point(76, 158)
        Me.TxtIdgarantia.MaxLength = 0
        Me.TxtIdgarantia.Name = "TxtIdgarantia"
        Me.TxtIdgarantia.Size = New System.Drawing.Size(82, 20)
        Me.TxtIdgarantia.TabIndex = 81
        Me.TxtIdgarantia.TabStop = False
        Me.TxtIdgarantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 163)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 13)
        Me.Label19.TabIndex = 85
        Me.Label19.Text = "ID Garantia"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtZ25
        '
        Me.TxtZ25.Location = New System.Drawing.Point(76, 111)
        Me.TxtZ25.MaxLength = 1
        Me.TxtZ25.Name = "TxtZ25"
        Me.TxtZ25.Size = New System.Drawing.Size(38, 20)
        Me.TxtZ25.TabIndex = 79
        Me.TxtZ25.TabStop = False
        Me.TxtZ25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 118)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 13)
        Me.Label18.TabIndex = 83
        Me.Label18.Text = "Z25"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnFira
        '
        Me.BtnFira.Location = New System.Drawing.Point(153, 499)
        Me.BtnFira.Name = "BtnFira"
        Me.BtnFira.Size = New System.Drawing.Size(89, 24)
        Me.BtnFira.TabIndex = 84
        Me.BtnFira.Text = "Guadar"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 13)
        Me.Label21.TabIndex = 81
        Me.Label21.Text = "ID DTU"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIDDTU
        '
        Me.txtIDDTU.Location = New System.Drawing.Point(76, 65)
        Me.txtIDDTU.Name = "txtIDDTU"
        Me.txtIDDTU.Size = New System.Drawing.Size(82, 20)
        Me.txtIDDTU.TabIndex = 77
        Me.txtIDDTU.TabStop = False
        Me.txtIDDTU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIDCredito
        '
        Me.txtIDCredito.Location = New System.Drawing.Point(76, 88)
        Me.txtIDCredito.Name = "txtIDCredito"
        Me.txtIDCredito.Size = New System.Drawing.Size(82, 20)
        Me.txtIDCredito.TabIndex = 78
        Me.txtIDCredito.TabStop = False
        Me.txtIDCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIDContrato
        '
        Me.txtIDContrato.Location = New System.Drawing.Point(76, 39)
        Me.txtIDContrato.Name = "txtIDContrato"
        Me.txtIDContrato.Size = New System.Drawing.Size(82, 20)
        Me.txtIDContrato.TabIndex = 76
        Me.txtIDContrato.TabStop = False
        Me.txtIDContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "ID Crédito"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "ID Contrato"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "ID Persona"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIDPersona
        '
        Me.txtIDPersona.Location = New System.Drawing.Point(75, 13)
        Me.txtIDPersona.Name = "txtIDPersona"
        Me.txtIDPersona.Size = New System.Drawing.Size(82, 20)
        Me.txtIDPersona.TabIndex = 75
        Me.txtIDPersona.TabStop = False
        Me.txtIDPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtValorGar
        '
        Me.TxtValorGar.Location = New System.Drawing.Point(166, 431)
        Me.TxtValorGar.Name = "TxtValorGar"
        Me.TxtValorGar.ReadOnly = True
        Me.TxtValorGar.Size = New System.Drawing.Size(114, 20)
        Me.TxtValorGar.TabIndex = 96
        Me.TxtValorGar.TabStop = False
        Me.TxtValorGar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtValorHipo
        '
        Me.TxtValorHipo.Location = New System.Drawing.Point(166, 454)
        Me.TxtValorHipo.Name = "TxtValorHipo"
        Me.TxtValorHipo.ReadOnly = True
        Me.TxtValorHipo.Size = New System.Drawing.Size(114, 20)
        Me.TxtValorHipo.TabIndex = 97
        Me.TxtValorHipo.TabStop = False
        Me.TxtValorHipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnOnbase
        '
        Me.BtnOnbase.Location = New System.Drawing.Point(665, 371)
        Me.BtnOnbase.Name = "BtnOnbase"
        Me.BtnOnbase.Size = New System.Drawing.Size(104, 24)
        Me.BtnOnbase.TabIndex = 99
        Me.BtnOnbase.Text = "OnBase Contrato"
        '
        'TxtContMarco
        '
        Me.TxtContMarco.Location = New System.Drawing.Point(655, 93)
        Me.TxtContMarco.Name = "TxtContMarco"
        Me.TxtContMarco.ReadOnly = True
        Me.TxtContMarco.Size = New System.Drawing.Size(114, 20)
        Me.TxtContMarco.TabIndex = 132
        Me.TxtContMarco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(654, 73)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(118, 19)
        Me.Label22.TabIndex = 131
        Me.Label22.Text = "No. de Contrato Marco"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTasaIvacap
        '
        Me.txtTasaIvacap.Location = New System.Drawing.Point(145, 288)
        Me.txtTasaIvacap.Name = "txtTasaIvacap"
        Me.txtTasaIvacap.ReadOnly = True
        Me.txtTasaIvacap.Size = New System.Drawing.Size(56, 20)
        Me.txtTasaIvacap.TabIndex = 134
        Me.txtTasaIvacap.TabStop = False
        Me.txtTasaIvacap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(16, 288)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(120, 16)
        Me.Label23.TabIndex = 133
        Me.Label23.Text = "Tasa I.V.A. Capital"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnOnbaseCRE
        '
        Me.BtnOnbaseCRE.Location = New System.Drawing.Point(665, 400)
        Me.BtnOnbaseCRE.Name = "BtnOnbaseCRE"
        Me.BtnOnbaseCRE.Size = New System.Drawing.Size(104, 24)
        Me.BtnOnbaseCRE.TabIndex = 135
        Me.BtnOnbaseCRE.Text = "OnBase Crédito"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(385, 525)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(120, 16)
        Me.Label25.TabIndex = 136
        Me.Label25.Text = "Fecha de Pago"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFechaPAG
        '
        Me.TxtFechaPAG.Location = New System.Drawing.Point(505, 524)
        Me.TxtFechaPAG.Name = "TxtFechaPAG"
        Me.TxtFechaPAG.ReadOnly = True
        Me.TxtFechaPAG.Size = New System.Drawing.Size(68, 20)
        Me.TxtFechaPAG.TabIndex = 137
        Me.TxtFechaPAG.TabStop = False
        Me.TxtFechaPAG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(385, 552)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(105, 13)
        Me.Label26.TabIndex = 138
        Me.Label26.Text = "Fecha de Activación"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFechaACTI
        '
        Me.TxtFechaACTI.Location = New System.Drawing.Point(505, 549)
        Me.TxtFechaACTI.Name = "TxtFechaACTI"
        Me.TxtFechaACTI.ReadOnly = True
        Me.TxtFechaACTI.Size = New System.Drawing.Size(68, 20)
        Me.TxtFechaACTI.TabIndex = 139
        Me.TxtFechaACTI.TabStop = False
        Me.TxtFechaACTI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnOnbaseFira
        '
        Me.BtnOnbaseFira.Location = New System.Drawing.Point(665, 429)
        Me.BtnOnbaseFira.Name = "BtnOnbaseFira"
        Me.BtnOnbaseFira.Size = New System.Drawing.Size(104, 24)
        Me.BtnOnbaseFira.TabIndex = 140
        Me.BtnOnbaseFira.Text = "OnBase Sup. Fira"
        '
        'BtnSoldoc
        '
        Me.BtnSoldoc.Location = New System.Drawing.Point(665, 458)
        Me.BtnSoldoc.Name = "BtnSoldoc"
        Me.BtnSoldoc.Size = New System.Drawing.Size(104, 24)
        Me.BtnSoldoc.TabIndex = 141
        Me.BtnSoldoc.Text = "Solicitar Doc."
        '
        'ControlGastosEXT1
        '
        Me.ControlGastosEXT1.Location = New System.Drawing.Point(665, 322)
        Me.ControlGastosEXT1.Name = "ControlGastosEXT1"
        Me.ControlGastosEXT1.Size = New System.Drawing.Size(102, 44)
        Me.ControlGastosEXT1.TabIndex = 98
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
        'LbCastigo
        '
        Me.LbCastigo.AutoSize = True
        Me.LbCastigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCastigo.ForeColor = System.Drawing.Color.Red
        Me.LbCastigo.Location = New System.Drawing.Point(948, 9)
        Me.LbCastigo.Name = "LbCastigo"
        Me.LbCastigo.Size = New System.Drawing.Size(78, 13)
        Me.LbCastigo.TabIndex = 142
        Me.LbCastigo.Text = "CASTIGADO"
        Me.LbCastigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LbCastigo.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(665, 487)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 143
        Me.Button1.Text = "Hoja de Cambios"
        '
        'TxtMoneda
        '
        Me.TxtMoneda.Location = New System.Drawing.Point(144, 477)
        Me.TxtMoneda.Name = "TxtMoneda"
        Me.TxtMoneda.ReadOnly = True
        Me.TxtMoneda.Size = New System.Drawing.Size(56, 20)
        Me.TxtMoneda.TabIndex = 145
        Me.TxtMoneda.TabStop = False
        Me.TxtMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(16, 477)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(95, 19)
        Me.Label35.TabIndex = 144
        Me.Label35.Text = "Moneda"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbStatus
        '
        Me.LbStatus.AutoSize = True
        Me.LbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbStatus.ForeColor = System.Drawing.Color.Black
        Me.LbStatus.Location = New System.Drawing.Point(16, 30)
        Me.LbStatus.Name = "LbStatus"
        Me.LbStatus.Size = New System.Drawing.Size(107, 13)
        Me.LbStatus.TabIndex = 146
        Me.LbStatus.Text = "Estatus Contable:"
        Me.LbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LbStatus.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(178, 193)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(121, 13)
        Me.Label37.TabIndex = 147
        Me.Label37.Text = "Penalización Prepago %"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTaspen
        '
        Me.TxtTaspen.Location = New System.Drawing.Point(312, 190)
        Me.TxtTaspen.Name = "TxtTaspen"
        Me.TxtTaspen.ReadOnly = True
        Me.TxtTaspen.Size = New System.Drawing.Size(56, 20)
        Me.TxtTaspen.TabIndex = 148
        Me.TxtTaspen.TabStop = False
        Me.TxtTaspen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSucursal
        '
        Me.TxtSucursal.Location = New System.Drawing.Point(655, 53)
        Me.TxtSucursal.Name = "TxtSucursal"
        Me.TxtSucursal.ReadOnly = True
        Me.TxtSucursal.Size = New System.Drawing.Size(114, 20)
        Me.TxtSucursal.TabIndex = 150
        Me.TxtSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(654, 31)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(118, 19)
        Me.Label36.TabIndex = 149
        Me.Label36.Text = "Sucursal"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(665, 516)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 151
        Me.Button2.Text = "Doctos. Seguro"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(665, 545)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 24)
        Me.Button3.TabIndex = 152
        Me.Button3.Text = "Doctos. Gestoría"
        '
        'frmDatoscon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1033, 575)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxtSucursal)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.TxtTaspen)
        Me.Controls.Add(Me.LbStatus)
        Me.Controls.Add(Me.TxtMoneda)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LbCastigo)
        Me.Controls.Add(Me.BtnSoldoc)
        Me.Controls.Add(Me.BtnOnbaseFira)
        Me.Controls.Add(Me.TxtFechaACTI)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TxtFechaPAG)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.BtnOnbaseCRE)
        Me.Controls.Add(Me.txtTasaIvacap)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TxtContMarco)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.BtnOnbase)
        Me.Controls.Add(Me.ControlGastosEXT1)
        Me.Controls.Add(Me.TxtValorHipo)
        Me.Controls.Add(Me.TxtValorGar)
        Me.Controls.Add(Me.gbDatosFIRA)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtEscritura)
        Me.Controls.Add(Me.txtNotaria)
        Me.Controls.Add(Me.txtLugar)
        Me.Controls.Add(Me.txtGHipot)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnTablaOtros)
        Me.Controls.Add(Me.lblDescr)
        Me.Controls.Add(Me.lblAnexo)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnHistoria)
        Me.Controls.Add(Me.btnTablaSeguro)
        Me.Controls.Add(Me.btnTablaEquipo)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.btnReferencia)
        Me.Controls.Add(Me.btnDatoseq)
        Me.Controls.Add(Me.btnDatosCliente)
        Me.Controls.Add(Me.lblNumc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFechac)
        Me.Controls.Add(Me.Label4)
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
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblIva)
        Me.Controls.Add(Me.txtPorop)
        Me.Controls.Add(Me.txtPorieq)
        Me.Controls.Add(Me.txtFvenc)
        Me.Controls.Add(Me.txtPorco)
        Me.Controls.Add(Me.txtDescTipar)
        Me.Controls.Add(Me.txtFechacon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gpoPagos)
        Me.Controls.Add(Me.txtDescTasa)
        Me.Controls.Add(Me.lblCriteriotasa)
        Me.Controls.Add(Me.lblTipotasa)
        Me.Controls.Add(Me.lblRecursos)
        Me.Controls.Add(Me.lblGaran)
        Me.Controls.Add(Me.txtFrecuencia)
        Me.Controls.Add(Me.lblFrecpag)
        Me.Controls.Add(Me.txtPrenda)
        Me.Controls.Add(Me.txtCritas)
        Me.Controls.Add(Me.txtFondeo)
        Me.Controls.Add(Me.txtForca)
        Me.Controls.Add(Me.lblEqmap)
        Me.Controls.Add(Me.gpoPagosi)
        Me.Controls.Add(Me.lblPlazo)
        Me.Controls.Add(Me.txtPlazo)
        Me.Name = "frmDatoscon"
        Me.Text = "Datos del Contrato"
        Me.gpoPagosi.ResumeLayout(False)
        Me.gpoPagosi.PerformLayout()
        Me.gpoPagos.ResumeLayout(False)
        Me.gpoPagos.PerformLayout()
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

#End Region

    Private Sub frmDatosCon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daAnexos As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet()
        Dim drAnexo As DataRow

        ' Declaración de variables de datos

        Dim cAnexo As String = ""
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
        Dim nTasaIvaCli As Decimal = 0


        cAnexo = Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4)



        TxtContMarco.Text = SacaContratoMarcoLargo(0, cAnexo)

        Dim TaPrenda As New ProductionDataSetTableAdapters.PrendaTableAdapter

        TxtValorGar.Text = TaPrenda.ScalarValorGarantia(cAnexo)
        TxtValorGar.Text = Format(Val(TxtValorGar.Text), "###,##0.00")
        TaPrenda.Dispose()

        myIdentity = GetCurrent()
        cUsuario = myIdentity.Name

        ' El siguiente Stored Procedure trae todos los atributos de la tabla Anexos,
        ' para un anexo dado
        ControlGastosEXT1.CargaXAnexo(cAnexo)
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

            If cUsuario = "AGIL\seguros" Or cUsuario = "AGIL\seguros2" Then
                btnReferencia.Enabled = False
                btnTablaEquipo.Enabled = False
                btnHistoria.Enabled = False
            Else
                btnReferencia.Enabled = True
                btnTablaEquipo.Enabled = True
                btnHistoria.Enabled = True
            End If

            drAnexo = dsAgil.Tables("Anexos").Rows(0)
            cFlcan = drAnexo("Flcan")
            Select Case cFlcan
                Case "A"
                    lblStatus.Text = "ACTIVO"
                Case "S"
                    lblStatus.Text = "SUSPENSO"
                Case "T"
                    lblStatus.Text = "TERMINADO"
                Case "C"
                    lblStatus.Text = "CANCELADO"
                Case "B"
                    lblStatus.Text = "BAJA"
            End Select

            lblDescr.Text = drAnexo("Descr")
            ClienteAux = drAnexo("cliente")

            ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++
            Dim TaOnbase As New GeneralDSTableAdapters.OnBaseTableAdapter
            cAnexoOnbase = "% " & CDbl(Mid(cAnexo, 2, 8)) & " %"
            If Mid(ClienteAux, 1, 1) = "0" Then ClienteAux = Mid(ClienteAux, 2, 5)
            If Mid(ClienteAux, 1, 1) = "0" Then ClienteAux = Mid(ClienteAux, 2, 5)
            If Mid(ClienteAux, 1, 1) = "0" Then ClienteAux = Mid(ClienteAux, 2, 5)
            If Mid(ClienteAux, 1, 1) = "0" Then ClienteAux = Mid(ClienteAux, 2, 5)
            'If TaOnbase.ScalarCuantos(cAnexoOnbase, "%" & Mid(lblDescr.Text, 1, 10) & "%") > 0 Then
            If TaOnbase.ScalarCuantos("Mesa de Control%", cAnexoOnbase) > 0 Then
                BtnOnbase.Enabled = True
            Else
                BtnOnbase.Enabled = False
            End If
            If TaOnbase.ScalarCuantos2("Credito%", "%" & lblDescr.Text.Trim & "%", "%" & ClienteAux & " %") > 0 Then
                BtnOnbaseCRE.Enabled = True
            Else
                BtnOnbaseCRE.Enabled = False
            End If
            If TaOnbase.ScalarCuantos("Supervision%", "%" & cAnexoOnbase & " %") > 0 Then
                BtnOnbaseFira.Enabled = True
            Else
                BtnOnbaseFira.Enabled = False
            End If
            ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++

            cTipar = drAnexo("Tipar")
            If cTipar = "F" Then
                txtDescTipar.Text = "ARRENDAMIENTO FINANCIERO"
            ElseIf cTipar = "P" Then
                txtDescTipar.Text = "ARRENDAMIENTO PURO"
            ElseIf cTipar = "R" Then
                txtDescTipar.Text = "CREDITO REFACCIONARIO"
            ElseIf cTipar = "S" Then
                txtDescTipar.Text = "CREDITO SIMPLE"
            ElseIf cTipar = "B" Then
                txtDescTipar.Text = "FULL SERVICE"
            End If
            txtFechacon.Text = CTOD(drAnexo("Fechacon"))
            txtFvenc.Text = CTOD(drAnexo("Fvenc"))
            txtPlazo.Text = drAnexo("Plazo")
            txtTermina.Text = Termina(cAnexo)
            txtPorieq.Text = Format(drAnexo("Porieq"), "##,##0.0000")
            txtPorco.Text = Format(drAnexo("Porco"), "F")
            txtPorop.Text = Format(drAnexo("Porop"), "F")
            txtTasas.Text = Format(drAnexo("Tasas"), "##,##0.0000")
            txtDifer.Text = Format(drAnexo("Difer"), "##,##0.0000")
            TxtMoneda.Text = drAnexo("Moneda")
            TxtSucursal.Text = drAnexo("Nombre_Sucursal")
            If Trim(drAnexo("Fecha_Pago")) <> "" Then
                TxtFechaPAG.Text = CTOD(drAnexo("Fecha_Pago"))
                HCsol = True
            Else
                TxtFechaPAG.Text = ""
                HCsol = True
            End If
            If Trim(drAnexo("FechaActivacion")) <> "" Then
                TxtFechaACTI.Text = CTOD(drAnexo("FechaActivacion"))
            Else
                TxtFechaACTI.Text = ""
            End If

            CkGSF.Checked = drAnexo("GarantiaSinFondeo")
            If cTipar = "F" Then
                Label23.Visible = True
                txtTasaIvacap.Visible = True
                txtTasaIvacap.Text = drAnexo("TasaIvaCapital")
            Else
                Label23.Visible = False
                txtTasaIvacap.Visible = False
            End If

            txtCritas.Text = drAnexo("DescCriterio")
            txtFrecuencia.Text = drAnexo("DescFrecuencia")
            txtFondeo.Text = drAnexo("DescRecurso")
            txtForca.Text = drAnexo("DescEsquema")
            txtDescTasa.Text = drAnexo("DescTasa")
            nImpEq = drAnexo("ImpEq")
            nPorop = drAnexo("Porop")

            If cTipar = "R" Then
                Label27.Text = "Monto del Equipo"
                lblAmortiza.Text = "Enganche"
                lblIvaamortiza.Text = "Derechos de Registro"
            Else
                Label27.Text = "Equipo con I.V.A."
                lblAmortiza.Text = "Amortización inicial"
                lblIvaamortiza.Text = "I.V.A. de la Amortización"
            End If

            txtImpEq.Text = Format(drAnexo("ImpEq"), "##,##0.00")
            txtIvaeq.Text = Format(drAnexo("IvaEq"), "##,##0.00")
            txtAmorin.Text = Format(drAnexo("Amorin"), "##,##0.00")
            txtIvaAmorin.Text = Format(drAnexo("Ivaamorin"), "##,##0.00")
            nTasaIvaCli = drAnexo("TasaIvaCliente")
            If cTipar = "R" Then
                txtIvaAmorin.Text = Format(drAnexo("Derechos"), "##,##0.00")
                lblAmortiza.Text = "Enganche"
                lblIvaamortiza.Text = "Derechos de Registro"
            ElseIf cTipar = "P" Then
                txtIvaAmorin.Text = Format(drAnexo("IvaAmorin"), "##,##0.00")
                Label4.Text = "Valor Residual"
                lblOpcom.Text = "Amortización Final"
            End If
            txtFinse.Text = drAnexo("Finse")
            txtPlaseg.Text = drAnexo("Plaseg")
            txtSaldoSeguro.Text = Format(drAnexo("SegEq"), "##,##0.00")
            If cTipar = "P" Then
                'nResidual = Round(((drAnexo("ImpEq") - drAnexo("IvaEq") - drAnexo("Amorin")) * nPorop / 100), 2)
                'nResidual = nResidual * (1 + (nTasaIvaCli / 100))
                'nResidual = Round(((nImpEq) * nPorop / 100), 2) se cambio por el monto financiaro cambio rafa, elisander, valetin
                nResidual = Round(((drAnexo("ImpEq") - drAnexo("IvaEq") - drAnexo("Amorin")) * nPorop / 100), 2)
                txtOpcion.Text = Format(nResidual, "##,##0.00")
            Else
                txtOpcion.Text = Format(drAnexo("OC"), "##,##0.00")
            End If
            txtMontoFinanciado.Text = Format(drAnexo("ImpEq") - drAnexo("IvaEq") - drAnexo("Amorin"), "##,##0.00")

            txtComis.Text = Format(drAnexo("Comis"), "##,##0.00")
            TxtTaspen.Text = Format(drAnexo("Taspen"), "##,##0.00")

            nDG = drAnexo("DG")
            If nDG > 0 Then
                lblImpDG.Text = "Depósito en Garantía " & Str(nDG) & "%"
            End If
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

            txtImpDG.Text = Format(nImpDG, "##,##0.00")
            txtIvaDG.Text = Format(nIvaDG, "##,##0.00")

            txtImpRD.Text = Format(nImpRD, "##,##0.00")
            txtIvaRD.Text = Format(nIvaRD, "##,##0.00")

            txtGastos.Text = Format(drAnexo("Gastos") + drAnexo("IvaGastos"), "##,##0.00")
            nSaldoEquipo = Round(drAnexo("ImpEq") - drAnexo("IvaEq") - drAnexo("Amorin"), 2)
            txtNafin.Text = Format(drAnexo("DepNafin"), "##,##0.00")
            TxtFondoReserva.Text = Format(drAnexo("FondoReserva"), "##,##0.00")
            If drAnexo("Vencida") = "C" Then
                LbCastigo.Visible = True
            Else
                LbCastigo.Visible = False
            End If

            If drAnexo("EstatusContable") = "VENCIDA" Then
                LbStatus.Visible = True
                LbStatus.Text = "Estatus Contable: VENCIDA"
                LbStatus.ForeColor = Color.Red
            Else
                LbCastigo.Visible = False
                LbStatus.Text = "Estatus Contable: VIGENTE"
                LbStatus.ForeColor = Color.Black
            End If
            txtPagosIniciales.Text = Format(drAnexo("Amorin") + drAnexo("IvaAmorin") + drAnexo("Derechos") + drAnexo("Comis") + drAnexo("Gastos") + drAnexo("IvaGastos") + drAnexo("DepNafin") + nImpDG + nIvaDG + nImpRD + nIvaRD + drAnexo("FondoReserva"), "##,##0.00")

            txtPrenda.Text = "N"
            If drAnexo("Prenda") = "S" Then
                txtPrenda.Text = "S"
            End If

            txtGHipot.Text = "N"
            TxtValorHipo.Text = drAnexo("ValorHipoteca")
            TxtValorHipo.Text = Format(Val(TxtValorHipo.Text), "###,##0.00")
            If drAnexo("GHipotec") = "S" Then
                txtGHipot.Text = "S"
                Label11.Visible = True
                txtLugar.Text = drAnexo("Lugar")
                txtLugar.Visible = True
                Label12.Visible = True
                txtNotaria.Text = drAnexo("Notaria")
                txtNotaria.Visible = True
                Label13.Visible = True
                txtEscritura.Text = drAnexo("Escritura")
                txtEscritura.Visible = True
            End If

            txtCliente.Text = drAnexo("Cliente")
            txtReferencia.Text = drAnexo("Referencia")

            If txtFinse.Text = "S" And cUsuario <> "AGIL\seguros" And cUsuario <> "AGIL\seguros2" Then
                btnTablaSeguro.Enabled = True
            Else
                btnTablaSeguro.Enabled = False
            End If

            If drAnexo("Adeudo") = "S" And cUsuario <> "AGIL\seguros" And cUsuario <> "AGIL\seguros2" Then
                btnTablaOtros.Enabled = True
            Else
                btnTablaOtros.Enabled = False
            End If

            'Agrega datos fira para tradicionales+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ECT20141013.n
            If drAnexo("Fondeo") = "03" Then
                Me.FIRA_EstadosTableAdapter.Fill(Me.AviosDSX1.FIRA_Estados)
                Me.FIRA_EstadosTableAdapter.Fill(Me.AviosDSX2.FIRA_Estados)
                FirA_AnexosDatosTableAdapter1.Fill(AviosDSX1.FIRA_AnexosDatos, cAnexo, "")
                If AviosDSX1.FIRA_AnexosDatos.Rows.Count <= 0 Then
                    FirA_AnexosDatosTableAdapter1.InsertAnexo(cAnexo, "", "")
                    FirA_AnexosDatosTableAdapter1.Fill(AviosDSX1.FIRA_AnexosDatos, cAnexo, "")
                End If

                Dim t As New ProductionDataSet.FIRArefaccionariosDataTable
                Ta.UpdateNulos()
                Ta.FillByAnexo(t, lblAnexo.Text)
                If t.Rows.Count > 0 Then
                    Dim r As ProductionDataSet.FIRArefaccionariosRow
                    r = t.Rows(0)
                    txtIDContrato.Text = r.idContrato
                    txtIDCredito.Text = r.idcredito
                    txtIDDTU.Text = r.IdDtu
                    txtIDPersona.Text = r.IdPersona
                    TxtZ25.Text = r.Z25
                    TxtZ08.Text = r.Z08
                    TxtIdgarantia.Text = r.IdGarantia
                    DtGarantia.Value = CTOD(r.GarantiaFecha)
                Else
                    txtIDContrato.Text = 0
                    txtIDCredito.Text = 0
                    txtIDDTU.Text = 0
                    txtIDPersona.Text = 0
                    TxtZ25.Text = "N"
                    TxtZ08.Text = "N"
                    TxtIdgarantia.Text = 0
                    DtGarantia.Value = "01/01/1900"
                End If
                'MessageBox.Show(cUsuario)
                If (cUsuario = "AGIL\cristina-juarez" Or cUsuario = "AGIL\desarrollo") Then
                    gbDatosFIRA.Enabled = True
                Else
                    gbDatosFIRA.Enabled = False
                End If
            Else
                gbDatosFIRA.Enabled = False
                txtIDContrato.Text = ""
                txtIDCredito.Text = ""
                txtIDDTU.Text = ""
                txtIDPersona.Text = ""
                TxtZ25.Text = ""
                TxtZ08.Text = ""
                TxtIdgarantia.Text = ""
                DtGarantia.Value = "01/01/1900"
            End If

            'Agrega datos fira para tradicionales+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ECT20141013.n

        End If

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnDatosCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatosCliente.Click
        Dim newfrmDatosClie As New frmDatosclie(txtCliente.Text)
        newfrmDatosClie.Show()
    End Sub

    Private Sub btnDatoseq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatoseq.Click
        Dim newfrmDatosEq As New frmDatosEq(lblAnexo.Text)
        newfrmDatosEq.Show()
    End Sub

    Private Sub btnReferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReferencia.Click
        Dim newfrmReferencia As New frmReferencia(lblAnexo.Text, txtCliente.Text)
        newfrmReferencia.Show()
    End Sub

    Private Sub btnTablaEquipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTablaEquipo.Click
        Dim newfrmTablaEquipo As New frmTablaEquipo(lblAnexo.Text)
        newfrmTablaEquipo.Show()
    End Sub

    Private Sub btnTablaSeguro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTablaSeguro.Click
        Dim newfrmTablaSeguro As New frmTablaSeguro(lblAnexo.Text)
        newfrmTablaSeguro.Show()
    End Sub

    Private Sub btnHistoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistoria.Click
        Dim newfrmHistoria As New frmHistoria(lblAnexo.Text, "")
        Cursor.Current = Cursors.WaitCursor
        newfrmHistoria.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnTablaOtros_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTablaOtros.Click
        Dim newfrmTablaOtros As New frmTablaOtros(lblAnexo.Text)
        newfrmTablaOtros.Show()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnFira_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFira.Click
        If txtIDCredito.Text = "0" Or txtIDCredito.Text = "" Or Not IsNumeric(txtIDCredito.Text) Then
            MessageBox.Show("ID Credito invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtZ25.Text <> "N" And TxtZ25.Text <> "S" Then
            MessageBox.Show("Z25 solo acepta valores ""S"" y ""N"" invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtZ08.Text <> "N" And TxtZ08.Text <> "S" Then
            MessageBox.Show("Z08 solo acepta valores ""S"" y ""N"" invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Agrega datos fira para tradicionales+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ECT20141013.n

        Dim t As New ProductionDataSet.FIRArefaccionariosDataTable
        Ta.FillByAnexo(t, lblAnexo.Text)
        If t.Rows.Count > 0 Then
            Ta.UpdateAnexo(txtIDCredito.Text, TxtZ25.Text, txtIDPersona.Text, txtIDDTU.Text, txtIDContrato.Text, TxtIdgarantia.Text, DtGarantia.Value.ToString("yyyyMMdd"), TxtZ08.Text, lblAnexo.Text)
        Else
            Ta.Insert(txtIDCredito.Text, Date.Now, False, lblAnexo.Text, TxtZ25.Text, txtIDPersona.Text, txtIDDTU.Text, txtIDContrato.Text, TxtIdgarantia.Text, DtGarantia.Value.ToString("yyyyMMdd"), TxtZ08.Text)
        End If
        DesBloqueaContrato(Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4))
        Ta.UpdateGarantiaSinFondeo(CkGSF.Checked, Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4), 0)
        BloqueaContrato(Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4))
        Try
            FiraDatosBindingSource.EndEdit()
            Me.FirA_AnexosDatosTableAdapter1.Update(AviosDSX1.FIRA_AnexosDatos)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al Guardar Datos Fira Anexos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Agrega datos fira para tradicionales+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ECT20141013.n


    End Sub

    Private Sub BtnOnbase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOnbase.Click
        Dim f As New FrmDocOnbase
        f.Cadena1 = "Mesa de Control%"
        'f.Cadena2 = "%" & Mid(lblDescr.Text, 1, 10) & "%"
        f.Cadena2 = cAnexoOnbase
        f.Titulo = Me.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        f.Dispose()
    End Sub

    Private Sub BtnOnbaseCRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOnbaseCRE.Click
        Dim f As New FrmDocOnbase
        f.Cadena1 = "Credito%"
        f.Cadena2 = "%" & lblDescr.Text.Trim & "%"
        f.Cadena3 = "%" & ClienteAux & " %"
        f.Titulo = Me.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        f.Dispose()
    End Sub


    Private Sub BtnOnbaseFira_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOnbaseFira.Click
        Dim f As New FrmDocOnbase
        f.Cadena1 = "Supervision%"
        f.Cadena2 = cAnexoOnbase
        f.Titulo = Me.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        f.Dispose()
    End Sub

    Private Sub BtnSoldoc_Click(sender As Object, e As EventArgs) Handles BtnSoldoc.Click
        Dim F As New frmbitacora_anexos
        F.cAnexo = Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4)
        If F.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Private Sub CbBEdoAcre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbBEdoAcre.SelectedIndexChanged
        If CbBEdoAcre.SelectedIndex >= 0 Then
            Me.FIRA_MunicipiosTableAdapter.Fill(Me.AviosDSX1.FIRA_Municipios, CbBEdoAcre.SelectedValue)
        End If
    End Sub

    Private Sub CmbMuniAcre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMuniAcre.SelectedIndexChanged
        If CmbMuniAcre.SelectedIndex >= 0 Then
            Me.FIRA_LocalidadesTableAdapter.Fill(Me.AviosDSX1.FIRA_Localidades, CbBEdoAcre.SelectedValue, CmbMuniAcre.SelectedValue)
        End If
    End Sub

    Private Sub CmbEdoInver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEdoInver.SelectedIndexChanged
        If CmbEdoInver.SelectedIndex >= 0 Then
            Me.FIRA_MunicipiosTableAdapter.Fill(Me.AviosDSX2.FIRA_Municipios, CmbEdoInver.SelectedValue)
        End If
    End Sub

    Private Sub CmbMuniInver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMuniInver.SelectedIndexChanged
        If CmbMuniInver.SelectedIndex >= 0 Then
            Me.FIRA_LocalidadesTableAdapter.Fill(Me.AviosDSX2.FIRA_Localidades, CmbEdoInver.SelectedValue, CmbMuniInver.SelectedValue)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New FrmHojaCambios
        f.BanSolHC = HCsol
        f.cAnexo = Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4)
        f.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New FrmAtachments
        f.Anexo = Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4)
        f.Ciclo = ""
        f.Carpeta = "Seguros"
        f.Consulta = True
        f.Nombre = lblDescr.Text
        If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New FrmAtachments
        f.Anexo = Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4)
        f.Ciclo = ""
        f.Carpeta = "Gestoria"
        f.Consulta = True
        f.Nombre = lblDescr.Text
        If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub
End Class
