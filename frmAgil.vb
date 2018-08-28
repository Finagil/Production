Option Explicit On
Imports Microsoft.Win32
Imports System.Data.SqlClient
Imports System.IO
Imports System.Collections.Specialized
Imports System.Web
Imports System.Deployment.Application


Public Class frmAgil
    Inherits System.Windows.Forms.Form
    Dim USUARIOX As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuProm As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCred As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCob As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCont As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSist As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCons As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRep As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCierre As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdelanto As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRegenera As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDatosCon As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActiAnex As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAltaClie As System.Windows.Forms.MenuItem
    Friend WithEvents mnuContClie As System.Windows.Forms.MenuItem
    Friend WithEvents mnuContSoli As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReciPago As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPondera As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCierreCo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImprePol As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGenCatal As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRepoProm As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRepAntig As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSalir As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCaptFact As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrendaria As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCostoIng As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFisicas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFacSaldo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPortacar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDesactiv As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRepCierre As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBuroCred As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRepCobra As System.Windows.Forms.MenuItem
    Friend WithEvents mnuIntIvaPP As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSeguiCre As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRepoDisp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTesoreria As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMorales As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRepDiezP As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCalcfini As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImprActi As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRepGaran As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDCPorAnexo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDCPorNombre As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFiniquito As System.Windows.Forms.MenuItem
    Friend WithEvents mnuACPorAnexo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuACPorNombre As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCFPorAnexo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCFPorNombre As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTPorAnexo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFCPorAnexo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFCPorNombre As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSeguros As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCaptValo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCaptSegu As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFormMens As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConsRefe As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActuaTas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActuaUdis As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDRPorFecha As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDRPorCliente As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProyecta As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRepSald2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuComputo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConsAviso As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRepSalCli As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRecupera As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCosto As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBitacora As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSegBitacora As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSeguManu As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFacturar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGeneFac As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImpreFac As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRelaFact As System.Windows.Forms.MenuItem
    Friend WithEvents mnuArchivosDCI As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCifrasDCI As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAvisos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGenAviso As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImpAcuses As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRelaResp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCapitalizacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCAPorAnexo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDomicilio As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCotizar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuIntCosto As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImprCert As System.Windows.Forms.MenuItem
    Friend WithEvents mnuECPorAnexo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuECPorNombre As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCartas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReimprimir As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRiesgos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCCartera As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCartaRat As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCRPorAnexo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCRPorNombre As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRepoSegu As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDepoRefe As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFega As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReestructuras As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRCporAnexo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRCporNombre As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAplicaDR As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAvio As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAltaContratos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuModCtoAvio As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImpCtoAvio As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMinistraciones As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportes As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdoCtaAvio As System.Windows.Forms.MenuItem
    Friend WithEvents mnuECPP As System.Windows.Forms.MenuItem
    Friend WithEvents mnuECTC As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPagosPF As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSustrae As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRCS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPSC As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEstratificacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMemoria As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRE As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPagares As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCapturaPMI As System.Windows.Forms.MenuItem
    Friend WithEvents mnuModCtoAvioPorProductor As System.Windows.Forms.MenuItem
    Friend WithEvents mnuModCtoAvioPorContrato As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPagaresPorProductor As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPagaresPorContrato As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCapturaPMIPorProductor As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCapturaPMIPorContrato As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImpCtoAvioPorProductor As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImpCtoAvioPorContrato As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDocumentos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCheckList As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportecl As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConsultaCL As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLayOutAvio As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMinistracionesPorProductor As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMinistracionesPorContrato As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMinistracionFFP As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMinistracionFP As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBuscarSerie As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTasasApl As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRegTasas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActVigencia As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDocBlanco As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExpDigital As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGFE As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEFE As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAltacta As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGLDomic As System.Windows.Forms.MenuItem
    Friend WithEvents MnuCondusef As System.Windows.Forms.MenuItem
    Friend WithEvents MnuAltaPolAvi As System.Windows.Forms.MenuItem
    Friend WithEvents MnuParametrosAvio As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSolAvio As System.Windows.Forms.MenuItem
    Friend WithEvents MnuCalCartera As System.Windows.Forms.MenuItem
    Friend WithEvents MnuConsumo As System.Windows.Forms.MenuItem
    Friend WithEvents MnuComercial As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProxVen As System.Windows.Forms.MenuItem
    Friend WithEvents MnuGastosEXT As System.Windows.Forms.MenuItem
    Friend WithEvents MnuFondoRestit As System.Windows.Forms.MenuItem
    Friend WithEvents MnuAplicaFR As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSaldosPuros As System.Windows.Forms.MenuItem
    Friend WithEvents MnuFondoRPT As System.Windows.Forms.MenuItem
    Friend WithEvents MnuValPersonas As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSegFin As System.Windows.Forms.MenuItem
    Friend WithEvents MnuBitactoraProm As System.Windows.Forms.MenuItem
    Friend WithEvents PendientesORGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDS As Agil.GeneralDS
    Friend WithEvents PendientesORGTableAdapter As Agil.GeneralDSTableAdapters.PendientesORGTableAdapter
    Friend WithEvents PendientesFINBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PendientesFINTableAdapter As Agil.GeneralDSTableAdapters.PendientesFINTableAdapter
    Friend WithEvents AnexoConDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnexoConDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MnuJuridico As System.Windows.Forms.MenuItem
    Friend WithEvents MnuClavesOBS As System.Windows.Forms.MenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuAddPAg As System.Windows.Forms.MenuItem
    Friend WithEvents MnuIRcomun As System.Windows.Forms.MenuItem
    Friend WithEvents MnuClientesGrupos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuReestruct As System.Windows.Forms.MenuItem
    Friend WithEvents MnuConvenioJur As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSEG1 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSEG2 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSEG3 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSEG4 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSEG5 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSoliCC As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOperIR As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuDesbloqTasa As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuIGenPASS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCTradicional As System.Windows.Forms.MenuItem
    Friend WithEvents MnuCCXvencer As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuTablaESP As System.Windows.Forms.MenuItem
    Friend WithEvents MnuCancelaMov As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuFechaApp As System.Windows.Forms.MenuItem
    Friend WithEvents MnuFactorPol As System.Windows.Forms.MenuItem
    Friend WithEvents MnuFechasSuper As MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuCargosEXTRAS As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuBitaJur As System.Windows.Forms.MenuItem
    Friend WithEvents MnuBitaJurConsul As System.Windows.Forms.MenuItem
    Friend WithEvents MnuMcBitacora As MenuItem
    Friend WithEvents MnuRepCobDia As MenuItem
    Friend WithEvents MenuItem15 As MenuItem
    Friend WithEvents MnuBuroNom As MenuItem
    Friend WithEvents MnuPLD As MenuItem
    Friend WithEvents MnuPLdAuto As MenuItem
    Friend WithEvents MnuPortaCont As MenuItem
    Friend WithEvents MnuLiberMC As MenuItem
    Friend WithEvents MnuFechaPago As MenuItem
    Friend WithEvents MnuLiberAvio As MenuItem
    Friend WithEvents MnuAutoAviCRE As MenuItem
    Friend WithEvents MnuPagosAvio As MenuItem
    Friend WithEvents MniBloqAvisos As MenuItem
    Friend WithEvents MnuFira As MenuItem
    Friend WithEvents MenuItem16 As MenuItem
    Friend WithEvents MenuItem17 As MenuItem
    Friend WithEvents MenuItem18 As MenuItem
    Friend WithEvents MenuItem19 As MenuItem
    Friend WithEvents MenuItem20 As MenuItem
    Friend WithEvents MnuCarteVecnMonitor As MenuItem
    Friend WithEvents MenuTipoCambio As MenuItem
    Friend WithEvents MnuModReest As MenuItem
    Friend WithEvents MenuItem21 As MenuItem
    Friend WithEvents MenuItem9 As MenuItem
    Friend WithEvents MenuItem22 As MenuItem
    Friend WithEvents MenuItem8 As MenuItem
    Friend WithEvents MnuActiDomi As MenuItem
    Friend WithEvents MenuItem23 As MenuItem
    Friend WithEvents MnuLinCred As MenuItem
    Friend WithEvents MenuItem24 As MenuItem
    Friend WithEvents MenuItem25 As MenuItem
    Friend WithEvents MenuItem26 As MenuItem
    Friend WithEvents MenuItem27 As MenuItem
    Friend WithEvents MenuItem28 As MenuItem
    Friend WithEvents MenuItem29 As MenuItem
    Friend WithEvents MenuItem31 As MenuItem
    Friend WithEvents MenuItem32 As MenuItem
    Friend WithEvents MenuSegCred As MenuItem
    Friend WithEvents MenuItem33 As MenuItem
    Friend WithEvents MenuItem30 As MenuItem
    Friend WithEvents MenuItem34 As MenuItem
    Friend WithEvents MenuItem36 As MenuItem
    Friend WithEvents MenuItem35 As MenuItem
    Friend WithEvents MenuItem37 As MenuItem
    Friend WithEvents MenuItem38 As MenuItem
    Friend WithEvents MenuItem39 As MenuItem
    Friend WithEvents mnuRepNafin As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim mnuCAvio As System.Windows.Forms.MenuItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgil))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuProm = New System.Windows.Forms.MenuItem()
        Me.mnuCotizar = New System.Windows.Forms.MenuItem()
        Me.mnuAltaClie = New System.Windows.Forms.MenuItem()
        Me.mnuContClie = New System.Windows.Forms.MenuItem()
        Me.mnuContSoli = New System.Windows.Forms.MenuItem()
        Me.mnuCaptFact = New System.Windows.Forms.MenuItem()
        Me.mnuPrendaria = New System.Windows.Forms.MenuItem()
        Me.mnuActiAnex = New System.Windows.Forms.MenuItem()
        Me.mnuDesactiv = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MnuIRcomun = New System.Windows.Forms.MenuItem()
        Me.MnuAddPAg = New System.Windows.Forms.MenuItem()
        Me.MnuSoliCC = New System.Windows.Forms.MenuItem()
        Me.MnuTablaESP = New System.Windows.Forms.MenuItem()
        Me.MnuCargosEXTRAS = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MnuActiDomi = New System.Windows.Forms.MenuItem()
        Me.MenuSegCred = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.mnuCred = New System.Windows.Forms.MenuItem()
        Me.mnuSeguiCre = New System.Windows.Forms.MenuItem()
        Me.mnuDocumentos = New System.Windows.Forms.MenuItem()
        Me.mnuCheckList = New System.Windows.Forms.MenuItem()
        Me.mnuReportecl = New System.Windows.Forms.MenuItem()
        Me.MnuLinCred = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.mnuCob = New System.Windows.Forms.MenuItem()
        Me.mnuReciPago = New System.Windows.Forms.MenuItem()
        Me.mnuAdelanto = New System.Windows.Forms.MenuItem()
        Me.mnuACPorAnexo = New System.Windows.Forms.MenuItem()
        Me.mnuACPorNombre = New System.Windows.Forms.MenuItem()
        Me.mnuFiniquito = New System.Windows.Forms.MenuItem()
        Me.mnuFCPorAnexo = New System.Windows.Forms.MenuItem()
        Me.mnuFCPorNombre = New System.Windows.Forms.MenuItem()
        Me.mnuDomicilio = New System.Windows.Forms.MenuItem()
        Me.mnuImprActi = New System.Windows.Forms.MenuItem()
        Me.mnuRepCobra = New System.Windows.Forms.MenuItem()
        Me.mnuReestructuras = New System.Windows.Forms.MenuItem()
        Me.mnuRCporAnexo = New System.Windows.Forms.MenuItem()
        Me.mnuRCporNombre = New System.Windows.Forms.MenuItem()
        Me.mnuAplicaDR = New System.Windows.Forms.MenuItem()
        Me.mnuDocBlanco = New System.Windows.Forms.MenuItem()
        Me.mnuGFE = New System.Windows.Forms.MenuItem()
        Me.mnuEFE = New System.Windows.Forms.MenuItem()
        Me.MnuFondoRestit = New System.Windows.Forms.MenuItem()
        Me.MnuAplicaFR = New System.Windows.Forms.MenuItem()
        Me.mnuPagosPF = New System.Windows.Forms.MenuItem()
        Me.MnuFechaApp = New System.Windows.Forms.MenuItem()
        Me.mnuTesoreria = New System.Windows.Forms.MenuItem()
        Me.mnuRecupera = New System.Windows.Forms.MenuItem()
        Me.mnuRepGaran = New System.Windows.Forms.MenuItem()
        Me.mnuRepoDisp = New System.Windows.Forms.MenuItem()
        Me.mnuRepNafin = New System.Windows.Forms.MenuItem()
        Me.mnuActuaTas = New System.Windows.Forms.MenuItem()
        Me.mnuActuaUdis = New System.Windows.Forms.MenuItem()
        Me.mnuSeguManu = New System.Windows.Forms.MenuItem()
        Me.mnuFacturar = New System.Windows.Forms.MenuItem()
        Me.mnuGeneFac = New System.Windows.Forms.MenuItem()
        Me.mnuImpreFac = New System.Windows.Forms.MenuItem()
        Me.mnuImpAcuses = New System.Windows.Forms.MenuItem()
        Me.mnuRelaFact = New System.Windows.Forms.MenuItem()
        Me.mnuArchivosDCI = New System.Windows.Forms.MenuItem()
        Me.mnuCifrasDCI = New System.Windows.Forms.MenuItem()
        Me.mnuAvisos = New System.Windows.Forms.MenuItem()
        Me.mnuGenAviso = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuAltacta = New System.Windows.Forms.MenuItem()
        Me.mnuGLDomic = New System.Windows.Forms.MenuItem()
        Me.mnuDepoRefe = New System.Windows.Forms.MenuItem()
        Me.mnuLayOutAvio = New System.Windows.Forms.MenuItem()
        Me.MnuFechaPago = New System.Windows.Forms.MenuItem()
        Me.MnuPagosAvio = New System.Windows.Forms.MenuItem()
        Me.mnuSeguros = New System.Windows.Forms.MenuItem()
        Me.mnuCaptSegu = New System.Windows.Forms.MenuItem()
        Me.MnuSEG1 = New System.Windows.Forms.MenuItem()
        Me.MnuSEG2 = New System.Windows.Forms.MenuItem()
        Me.MnuSEG3 = New System.Windows.Forms.MenuItem()
        Me.MnuSEG4 = New System.Windows.Forms.MenuItem()
        Me.MnuSEG5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.mnuFormMens = New System.Windows.Forms.MenuItem()
        Me.MnuAltaPolAvi = New System.Windows.Forms.MenuItem()
        Me.MnuSegFin = New System.Windows.Forms.MenuItem()
        Me.MnuFactorPol = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.mnuCont = New System.Windows.Forms.MenuItem()
        Me.mnuImprCert = New System.Windows.Forms.MenuItem()
        Me.mnuECPorAnexo = New System.Windows.Forms.MenuItem()
        Me.mnuECPorNombre = New System.Windows.Forms.MenuItem()
        Me.mnuComputo = New System.Windows.Forms.MenuItem()
        Me.mnuPondera = New System.Windows.Forms.MenuItem()
        Me.mnuProyecta = New System.Windows.Forms.MenuItem()
        Me.mnuRelaResp = New System.Windows.Forms.MenuItem()
        Me.mnuIntCosto = New System.Windows.Forms.MenuItem()
        Me.mnuCosto = New System.Windows.Forms.MenuItem()
        Me.mnuCierre = New System.Windows.Forms.MenuItem()
        Me.mnuCierreCo = New System.Windows.Forms.MenuItem()
        Me.mnuImprePol = New System.Windows.Forms.MenuItem()
        Me.mnuGenCatal = New System.Windows.Forms.MenuItem()
        Me.mnuRepCierre = New System.Windows.Forms.MenuItem()
        Me.mnuRepDiezP = New System.Windows.Forms.MenuItem()
        Me.mnuIntIvaPP = New System.Windows.Forms.MenuItem()
        Me.mnuRepSald2 = New System.Windows.Forms.MenuItem()
        Me.MnuGastosEXT = New System.Windows.Forms.MenuItem()
        Me.MniBloqAvisos = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuTipoCambio = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.mnuSist = New System.Windows.Forms.MenuItem()
        Me.mnuRegenera = New System.Windows.Forms.MenuItem()
        Me.mnuRTPorAnexo = New System.Windows.Forms.MenuItem()
        Me.mnuBuroCred = New System.Windows.Forms.MenuItem()
        Me.mnuMorales = New System.Windows.Forms.MenuItem()
        Me.mnuFisicas = New System.Windows.Forms.MenuItem()
        Me.mnuCostoIng = New System.Windows.Forms.MenuItem()
        Me.mnuPortacar = New System.Windows.Forms.MenuItem()
        Me.mnuCapitalizacion = New System.Windows.Forms.MenuItem()
        Me.mnuCAPorAnexo = New System.Windows.Forms.MenuItem()
        Me.mnuCartas = New System.Windows.Forms.MenuItem()
        Me.mnuReimprimir = New System.Windows.Forms.MenuItem()
        Me.MenuIGenPASS = New System.Windows.Forms.MenuItem()
        Me.MnuCancelaMov = New System.Windows.Forms.MenuItem()
        Me.MnuBuroNom = New System.Windows.Forms.MenuItem()
        Me.MnuPortaCont = New System.Windows.Forms.MenuItem()
        Me.mnuCons = New System.Windows.Forms.MenuItem()
        Me.mnuDatosCon = New System.Windows.Forms.MenuItem()
        Me.mnuDCPorAnexo = New System.Windows.Forms.MenuItem()
        Me.mnuDCPorNombre = New System.Windows.Forms.MenuItem()
        Me.mnuFacSaldo = New System.Windows.Forms.MenuItem()
        Me.mnuCalcfini = New System.Windows.Forms.MenuItem()
        Me.mnuCFPorAnexo = New System.Windows.Forms.MenuItem()
        Me.mnuCFPorNombre = New System.Windows.Forms.MenuItem()
        Me.mnuConsRefe = New System.Windows.Forms.MenuItem()
        Me.mnuDRPorFecha = New System.Windows.Forms.MenuItem()
        Me.mnuDRPorCliente = New System.Windows.Forms.MenuItem()
        Me.mnuConsAviso = New System.Windows.Forms.MenuItem()
        Me.mnuRepSalCli = New System.Windows.Forms.MenuItem()
        Me.mnuConsultaCL = New System.Windows.Forms.MenuItem()
        Me.mnuBuscarSerie = New System.Windows.Forms.MenuItem()
        Me.MnuCondusef = New System.Windows.Forms.MenuItem()
        Me.mnuProxVen = New System.Windows.Forms.MenuItem()
        Me.MnuSaldosPuros = New System.Windows.Forms.MenuItem()
        Me.MnuValPersonas = New System.Windows.Forms.MenuItem()
        Me.MnuClientesGrupos = New System.Windows.Forms.MenuItem()
        Me.mnuCartaRat = New System.Windows.Forms.MenuItem()
        Me.mnuCRPorAnexo = New System.Windows.Forms.MenuItem()
        Me.mnuCRPorNombre = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MnuBitaJurConsul = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MnuCarteVecnMonitor = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.mnuRep = New System.Windows.Forms.MenuItem()
        Me.mnuRepoProm = New System.Windows.Forms.MenuItem()
        Me.mnuRepAntig = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.mnuRepoSegu = New System.Windows.Forms.MenuItem()
        Me.MnuCalCartera = New System.Windows.Forms.MenuItem()
        Me.MnuConsumo = New System.Windows.Forms.MenuItem()
        Me.MnuComercial = New System.Windows.Forms.MenuItem()
        Me.MnuFondoRPT = New System.Windows.Forms.MenuItem()
        Me.MnuBitactoraProm = New System.Windows.Forms.MenuItem()
        Me.mnuOperIR = New System.Windows.Forms.MenuItem()
        Me.MnuCCXvencer = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.mnuRiesgos = New System.Windows.Forms.MenuItem()
        Me.mnuCCartera = New System.Windows.Forms.MenuItem()
        Me.mnuFega = New System.Windows.Forms.MenuItem()
        Me.mnuTasasApl = New System.Windows.Forms.MenuItem()
        Me.mnuRegTasas = New System.Windows.Forms.MenuItem()
        Me.mnuActVigencia = New System.Windows.Forms.MenuItem()
        Me.MnuDesbloqTasa = New System.Windows.Forms.MenuItem()
        Me.mnuAvio = New System.Windows.Forms.MenuItem()
        Me.mnuAltaContratos = New System.Windows.Forms.MenuItem()
        Me.mnuModCtoAvio = New System.Windows.Forms.MenuItem()
        Me.mnuModCtoAvioPorProductor = New System.Windows.Forms.MenuItem()
        Me.mnuModCtoAvioPorContrato = New System.Windows.Forms.MenuItem()
        Me.mnuImpCtoAvio = New System.Windows.Forms.MenuItem()
        Me.mnuImpCtoAvioPorProductor = New System.Windows.Forms.MenuItem()
        Me.mnuImpCtoAvioPorContrato = New System.Windows.Forms.MenuItem()
        Me.mnuSustrae = New System.Windows.Forms.MenuItem()
        Me.mnuRCS = New System.Windows.Forms.MenuItem()
        Me.mnuPSC = New System.Windows.Forms.MenuItem()
        Me.mnuEstratificacion = New System.Windows.Forms.MenuItem()
        Me.mnuMemoria = New System.Windows.Forms.MenuItem()
        Me.mnuRE = New System.Windows.Forms.MenuItem()
        Me.mnuMinistraciones = New System.Windows.Forms.MenuItem()
        Me.mnuMinistracionesPorProductor = New System.Windows.Forms.MenuItem()
        Me.mnuMinistracionesPorContrato = New System.Windows.Forms.MenuItem()
        Me.mnuReportes = New System.Windows.Forms.MenuItem()
        Me.mnuMinistracionFFP = New System.Windows.Forms.MenuItem()
        Me.mnuMinistracionFP = New System.Windows.Forms.MenuItem()
        Me.mnuEdoCtaAvio = New System.Windows.Forms.MenuItem()
        Me.mnuECPP = New System.Windows.Forms.MenuItem()
        Me.mnuECTC = New System.Windows.Forms.MenuItem()
        Me.mnuPagares = New System.Windows.Forms.MenuItem()
        Me.mnuPagaresPorProductor = New System.Windows.Forms.MenuItem()
        Me.mnuPagaresPorContrato = New System.Windows.Forms.MenuItem()
        Me.mnuCapturaPMI = New System.Windows.Forms.MenuItem()
        Me.mnuCapturaPMIPorProductor = New System.Windows.Forms.MenuItem()
        Me.mnuCapturaPMIPorContrato = New System.Windows.Forms.MenuItem()
        Me.mnuExpDigital = New System.Windows.Forms.MenuItem()
        Me.MnuParametrosAvio = New System.Windows.Forms.MenuItem()
        Me.MnuSolAvio = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MnuFechasSuper = New System.Windows.Forms.MenuItem()
        Me.MnuJuridico = New System.Windows.Forms.MenuItem()
        Me.MnuClavesOBS = New System.Windows.Forms.MenuItem()
        Me.MnuConvenioJur = New System.Windows.Forms.MenuItem()
        Me.MnuBitaJur = New System.Windows.Forms.MenuItem()
        Me.mnuBitacora = New System.Windows.Forms.MenuItem()
        Me.mnuSegBitacora = New System.Windows.Forms.MenuItem()
        Me.MnuRepCobDia = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.mnuCaptValo = New System.Windows.Forms.MenuItem()
        Me.mnuCTradicional = New System.Windows.Forms.MenuItem()
        Me.MnuReestruct = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MnuMcBitacora = New System.Windows.Forms.MenuItem()
        Me.MnuLiberMC = New System.Windows.Forms.MenuItem()
        Me.MnuLiberAvio = New System.Windows.Forms.MenuItem()
        Me.MnuModReest = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MnuPLD = New System.Windows.Forms.MenuItem()
        Me.MnuPLdAuto = New System.Windows.Forms.MenuItem()
        Me.MnuFira = New System.Windows.Forms.MenuItem()
        Me.MnuAutoAviCRE = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.mnuSalir = New System.Windows.Forms.MenuItem()
        Me.PendientesORGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS()
        Me.PendientesFINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PendientesORGTableAdapter = New Agil.GeneralDSTableAdapters.PendientesORGTableAdapter()
        Me.PendientesFINTableAdapter = New Agil.GeneralDSTableAdapters.PendientesFINTableAdapter()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        mnuCAvio = New System.Windows.Forms.MenuItem()
        CType(Me.PendientesORGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PendientesFINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuCAvio
        '
        mnuCAvio.Index = 1
        mnuCAvio.Text = "Crédito AVIO"
        AddHandler mnuCAvio.Click, AddressOf Me.mnuCAvio_Click
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuProm, Me.mnuCred, Me.mnuCob, Me.mnuTesoreria, Me.mnuSeguros, Me.mnuCont, Me.mnuSist, Me.mnuCons, Me.mnuRep, Me.mnuRiesgos, Me.mnuAvio, Me.MnuJuridico, Me.MenuItem3, Me.MnuPLD, Me.MnuFira, Me.mnuSalir})
        '
        'mnuProm
        '
        Me.mnuProm.Enabled = False
        Me.mnuProm.Index = 0
        Me.mnuProm.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCotizar, Me.mnuAltaClie, Me.mnuContClie, Me.mnuContSoli, Me.mnuCaptFact, Me.mnuPrendaria, Me.mnuActiAnex, Me.mnuDesactiv, Me.MenuItem2, Me.MnuIRcomun, Me.MnuAddPAg, Me.MnuSoliCC, Me.MnuTablaESP, Me.MnuCargosEXTRAS, Me.MenuItem16, Me.MnuActiDomi, Me.MenuSegCred, Me.MenuItem36})
        Me.mnuProm.Text = "&Promoción"
        '
        'mnuCotizar
        '
        Me.mnuCotizar.Enabled = False
        Me.mnuCotizar.Index = 0
        Me.mnuCotizar.Text = "Cotizaciones"
        '
        'mnuAltaClie
        '
        Me.mnuAltaClie.Enabled = False
        Me.mnuAltaClie.Index = 1
        Me.mnuAltaClie.Text = "Alta de Clientes"
        '
        'mnuContClie
        '
        Me.mnuContClie.Enabled = False
        Me.mnuContClie.Index = 2
        Me.mnuContClie.Text = "Control de Clientes"
        '
        'mnuContSoli
        '
        Me.mnuContSoli.Enabled = False
        Me.mnuContSoli.Index = 3
        Me.mnuContSoli.Text = "Control de Solicitudes"
        '
        'mnuCaptFact
        '
        Me.mnuCaptFact.Enabled = False
        Me.mnuCaptFact.Index = 4
        Me.mnuCaptFact.Text = "Facturas Originales"
        '
        'mnuPrendaria
        '
        Me.mnuPrendaria.Enabled = False
        Me.mnuPrendaria.Index = 5
        Me.mnuPrendaria.Text = "Garantía Prendaria"
        '
        'mnuActiAnex
        '
        Me.mnuActiAnex.Enabled = False
        Me.mnuActiAnex.Index = 6
        Me.mnuActiAnex.Text = "Activación de Anexos"
        '
        'mnuDesactiv
        '
        Me.mnuDesactiv.Enabled = False
        Me.mnuDesactiv.Index = 7
        Me.mnuDesactiv.Text = "Desactivar un Anexo"
        '
        'MenuItem2
        '
        Me.MenuItem2.Enabled = False
        Me.MenuItem2.Index = 8
        Me.MenuItem2.Text = "Grupo de Negocios"
        '
        'MnuIRcomun
        '
        Me.MnuIRcomun.Enabled = False
        Me.MnuIRcomun.Index = 9
        Me.MnuIRcomun.Text = "Grupos de Riesgo Común"
        '
        'MnuAddPAg
        '
        Me.MnuAddPAg.Enabled = False
        Me.MnuAddPAg.Index = 10
        Me.MnuAddPAg.Text = "Agregar Pagaré CC"
        '
        'MnuSoliCC
        '
        Me.MnuSoliCC.Enabled = False
        Me.MnuSoliCC.Index = 11
        Me.MnuSoliCC.Text = "Solicitud CC"
        '
        'MnuTablaESP
        '
        Me.MnuTablaESP.Enabled = False
        Me.MnuTablaESP.Index = 12
        Me.MnuTablaESP.Text = "Carga Tabla Especial"
        '
        'MnuCargosEXTRAS
        '
        Me.MnuCargosEXTRAS.Enabled = False
        Me.MnuCargosEXTRAS.Index = 13
        Me.MnuCargosEXTRAS.Text = "Cargos Adicionales (Domiciliación)"
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = False
        Me.MenuItem16.Index = 14
        Me.MenuItem16.Text = "Correos Adicionales por Anexo"
        '
        'MnuActiDomi
        '
        Me.MnuActiDomi.Enabled = False
        Me.MnuActiDomi.Index = 15
        Me.MnuActiDomi.Text = "Activar/Desact. Domiciliación"
        '
        'MenuSegCred
        '
        Me.MenuSegCred.Enabled = False
        Me.MenuSegCred.Index = 16
        Me.MenuSegCred.Text = "Seguimiento de Crédito"
        '
        'MenuItem36
        '
        Me.MenuItem36.Enabled = False
        Me.MenuItem36.Index = 17
        Me.MenuItem36.Text = "Entrega de Expediente (Check List)"
        '
        'mnuCred
        '
        Me.mnuCred.Enabled = False
        Me.mnuCred.Index = 1
        Me.mnuCred.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSeguiCre, Me.mnuDocumentos, Me.MnuLinCred, Me.MenuItem27, Me.MenuItem31})
        Me.mnuCred.Text = "&Crédito"
        '
        'mnuSeguiCre
        '
        Me.mnuSeguiCre.Enabled = False
        Me.mnuSeguiCre.Index = 0
        Me.mnuSeguiCre.Text = "Seguimiento de Crédito"
        '
        'mnuDocumentos
        '
        Me.mnuDocumentos.Index = 1
        Me.mnuDocumentos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCheckList, Me.mnuReportecl})
        Me.mnuDocumentos.Text = "Documentación"
        '
        'mnuCheckList
        '
        Me.mnuCheckList.Index = 0
        Me.mnuCheckList.Text = "Control Exp. Físico"
        '
        'mnuReportecl
        '
        Me.mnuReportecl.Index = 1
        Me.mnuReportecl.Text = "Reporte"
        '
        'MnuLinCred
        '
        Me.MnuLinCred.Index = 2
        Me.MnuLinCred.Text = "Lineas de Crédito AV"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 3
        Me.MenuItem27.Text = "Liberación de Ministraciones"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 4
        Me.MenuItem31.Text = "Alta de Seguimientos"
        '
        'mnuCob
        '
        Me.mnuCob.Enabled = False
        Me.mnuCob.Index = 2
        Me.mnuCob.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuReciPago, Me.mnuAdelanto, Me.mnuFiniquito, Me.mnuDomicilio, Me.mnuImprActi, Me.mnuRepCobra, Me.mnuReestructuras, Me.mnuAplicaDR, Me.mnuDocBlanco, Me.mnuGFE, Me.mnuEFE, Me.MnuFondoRestit, Me.MnuAplicaFR, Me.mnuPagosPF, Me.MnuFechaApp})
        Me.mnuCob.Text = "C&obranza"
        '
        'mnuReciPago
        '
        Me.mnuReciPago.Enabled = False
        Me.mnuReciPago.Index = 0
        Me.mnuReciPago.Text = "Recepción de Pagos"
        '
        'mnuAdelanto
        '
        Me.mnuAdelanto.Enabled = False
        Me.mnuAdelanto.Index = 1
        Me.mnuAdelanto.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuACPorAnexo, Me.mnuACPorNombre})
        Me.mnuAdelanto.Text = "Adelantos a Capital"
        '
        'mnuACPorAnexo
        '
        Me.mnuACPorAnexo.Enabled = False
        Me.mnuACPorAnexo.Index = 0
        Me.mnuACPorAnexo.Text = "Por Anexo"
        '
        'mnuACPorNombre
        '
        Me.mnuACPorNombre.Enabled = False
        Me.mnuACPorNombre.Index = 1
        Me.mnuACPorNombre.Text = "Por Nombre"
        '
        'mnuFiniquito
        '
        Me.mnuFiniquito.Enabled = False
        Me.mnuFiniquito.Index = 2
        Me.mnuFiniquito.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFCPorAnexo, Me.mnuFCPorNombre})
        Me.mnuFiniquito.Text = "Finiquito de Contratos"
        '
        'mnuFCPorAnexo
        '
        Me.mnuFCPorAnexo.Enabled = False
        Me.mnuFCPorAnexo.Index = 0
        Me.mnuFCPorAnexo.Text = "Por Anexo"
        '
        'mnuFCPorNombre
        '
        Me.mnuFCPorNombre.Enabled = False
        Me.mnuFCPorNombre.Index = 1
        Me.mnuFCPorNombre.Text = "Por Nombre"
        '
        'mnuDomicilio
        '
        Me.mnuDomicilio.Enabled = False
        Me.mnuDomicilio.Index = 3
        Me.mnuDomicilio.Text = "Cambios de Domicilio y Retención"
        '
        'mnuImprActi
        '
        Me.mnuImprActi.Enabled = False
        Me.mnuImprActi.Index = 4
        Me.mnuImprActi.Text = "Imprimir Facturas de Activo Fijo"
        '
        'mnuRepCobra
        '
        Me.mnuRepCobra.Enabled = False
        Me.mnuRepCobra.Index = 5
        Me.mnuRepCobra.Text = "Reporte de Cobranza por día"
        '
        'mnuReestructuras
        '
        Me.mnuReestructuras.Enabled = False
        Me.mnuReestructuras.Index = 6
        Me.mnuReestructuras.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRCporAnexo, Me.mnuRCporNombre})
        Me.mnuReestructuras.Text = "Reestructuras y Capitalizaciones"
        '
        'mnuRCporAnexo
        '
        Me.mnuRCporAnexo.Index = 0
        Me.mnuRCporAnexo.Text = "por Anexo"
        '
        'mnuRCporNombre
        '
        Me.mnuRCporNombre.Index = 1
        Me.mnuRCporNombre.Text = "por Nombre"
        '
        'mnuAplicaDR
        '
        Me.mnuAplicaDR.Enabled = False
        Me.mnuAplicaDR.Index = 7
        Me.mnuAplicaDR.Text = "Aplicación Automatizada de Pagos"
        '
        'mnuDocBlanco
        '
        Me.mnuDocBlanco.Enabled = False
        Me.mnuDocBlanco.Index = 8
        Me.mnuDocBlanco.Text = "Imprimir Documentos en Blanco"
        '
        'mnuGFE
        '
        Me.mnuGFE.Index = 9
        Me.mnuGFE.Text = "Generar Facturas Electrónicas"
        '
        'mnuEFE
        '
        Me.mnuEFE.Enabled = False
        Me.mnuEFE.Index = 10
        Me.mnuEFE.Text = "Enviar Facturas Electrónicas"
        '
        'MnuFondoRestit
        '
        Me.MnuFondoRestit.Enabled = False
        Me.MnuFondoRestit.Index = 11
        Me.MnuFondoRestit.Text = "Restituir Fondo de Reserva"
        '
        'MnuAplicaFR
        '
        Me.MnuAplicaFR.Index = 12
        Me.MnuAplicaFR.Text = "Aplicar Fondo de Reserva"
        '
        'mnuPagosPF
        '
        Me.mnuPagosPF.Enabled = False
        Me.mnuPagosPF.Index = 13
        Me.mnuPagosPF.Text = "Pagos Productor-FINAGIL"
        '
        'MnuFechaApp
        '
        Me.MnuFechaApp.Index = 14
        Me.MnuFechaApp.Text = "Fecha de Aplicación"
        '
        'mnuTesoreria
        '
        Me.mnuTesoreria.Enabled = False
        Me.mnuTesoreria.Index = 3
        Me.mnuTesoreria.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRecupera, Me.mnuRepGaran, Me.mnuRepoDisp, Me.mnuRepNafin, Me.mnuActuaTas, Me.mnuActuaUdis, Me.mnuSeguManu, Me.mnuFacturar, Me.mnuDepoRefe, Me.mnuLayOutAvio, Me.MnuFechaPago, Me.MnuPagosAvio})
        Me.mnuTesoreria.Text = "Tesorería"
        '
        'mnuRecupera
        '
        Me.mnuRecupera.Enabled = False
        Me.mnuRecupera.Index = 0
        Me.mnuRecupera.Text = "Recuperación de Cuentas por Cobrar"
        '
        'mnuRepGaran
        '
        Me.mnuRepGaran.Enabled = False
        Me.mnuRepGaran.Index = 1
        Me.mnuRepGaran.Text = "Reporte de Aforos"
        '
        'mnuRepoDisp
        '
        Me.mnuRepoDisp.Enabled = False
        Me.mnuRepoDisp.Index = 2
        Me.mnuRepoDisp.Text = "Contratos disponibles para dar en Garantía"
        '
        'mnuRepNafin
        '
        Me.mnuRepNafin.Enabled = False
        Me.mnuRepNafin.Index = 3
        Me.mnuRepNafin.Text = "Reporte de Contratos Fondeados con NAFIN o FIRA"
        '
        'mnuActuaTas
        '
        Me.mnuActuaTas.Enabled = False
        Me.mnuActuaTas.Index = 4
        Me.mnuActuaTas.Text = "Actualización de Tasas"
        '
        'mnuActuaUdis
        '
        Me.mnuActuaUdis.Enabled = False
        Me.mnuActuaUdis.Index = 5
        Me.mnuActuaUdis.Text = "Actualización de UDIs"
        '
        'mnuSeguManu
        '
        Me.mnuSeguManu.Enabled = False
        Me.mnuSeguManu.Index = 6
        Me.mnuSeguManu.Text = "Capturar Seguros Financiados"
        '
        'mnuFacturar
        '
        Me.mnuFacturar.Enabled = False
        Me.mnuFacturar.Index = 7
        Me.mnuFacturar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuGeneFac, Me.mnuImpreFac, Me.mnuImpAcuses, Me.mnuRelaFact, Me.mnuArchivosDCI, Me.mnuCifrasDCI, Me.mnuAvisos, Me.mnuGenAviso, Me.MenuItem1})
        Me.mnuFacturar.Text = "Avisos de vencimiento de Renta"
        '
        'mnuGeneFac
        '
        Me.mnuGeneFac.Enabled = False
        Me.mnuGeneFac.Index = 0
        Me.mnuGeneFac.Text = "Generación de Avisos de Vencimiento"
        '
        'mnuImpreFac
        '
        Me.mnuImpreFac.Enabled = False
        Me.mnuImpreFac.Index = 1
        Me.mnuImpreFac.Text = "Impresión de Avisos de Vencimiento"
        '
        'mnuImpAcuses
        '
        Me.mnuImpAcuses.Enabled = False
        Me.mnuImpAcuses.Index = 2
        Me.mnuImpAcuses.Text = "Impresión de Acuses de Recibido"
        '
        'mnuRelaFact
        '
        Me.mnuRelaFact.Enabled = False
        Me.mnuRelaFact.Index = 3
        Me.mnuRelaFact.Text = "Relación de Facturación para Mensajería"
        '
        'mnuArchivosDCI
        '
        Me.mnuArchivosDCI.Enabled = False
        Me.mnuArchivosDCI.Index = 4
        Me.mnuArchivosDCI.MergeType = System.Windows.Forms.MenuMerge.Replace
        Me.mnuArchivosDCI.Text = "Generación de Avisos para Mensajería"
        '
        'mnuCifrasDCI
        '
        Me.mnuCifrasDCI.Enabled = False
        Me.mnuCifrasDCI.Index = 5
        Me.mnuCifrasDCI.Text = "Cifras de Control para DCI"
        '
        'mnuAvisos
        '
        Me.mnuAvisos.Enabled = False
        Me.mnuAvisos.Index = 6
        Me.mnuAvisos.Text = "Subir avisos a la página Web"
        '
        'mnuGenAviso
        '
        Me.mnuGenAviso.Enabled = False
        Me.mnuGenAviso.Index = 7
        Me.mnuGenAviso.Text = "Envío de Avisos por eMail"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 8
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAltacta, Me.mnuGLDomic})
        Me.MenuItem1.Text = "Domiciliación"
        '
        'mnuAltacta
        '
        Me.mnuAltacta.Enabled = False
        Me.mnuAltacta.Index = 0
        Me.mnuAltacta.Text = "Alta de Cuentas"
        '
        'mnuGLDomic
        '
        Me.mnuGLDomic.Index = 1
        Me.mnuGLDomic.Text = "Generar Layout Domiciliación"
        '
        'mnuDepoRefe
        '
        Me.mnuDepoRefe.Enabled = False
        Me.mnuDepoRefe.Index = 8
        Me.mnuDepoRefe.Text = "Depósitos Referenciados"
        '
        'mnuLayOutAvio
        '
        Me.mnuLayOutAvio.Enabled = False
        Me.mnuLayOutAvio.Index = 9
        Me.mnuLayOutAvio.Text = "Genera Lay Out de Avío"
        '
        'MnuFechaPago
        '
        Me.MnuFechaPago.Enabled = False
        Me.MnuFechaPago.Index = 10
        Me.MnuFechaPago.Text = "Captura Fecha de Pago"
        '
        'MnuPagosAvio
        '
        Me.MnuPagosAvio.Enabled = False
        Me.MnuPagosAvio.Index = 11
        Me.MnuPagosAvio.Text = "Subir Pagos Avío"
        '
        'mnuSeguros
        '
        Me.mnuSeguros.Enabled = False
        Me.mnuSeguros.Index = 4
        Me.mnuSeguros.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCaptSegu, Me.mnuFormMens, Me.MnuAltaPolAvi, Me.MnuSegFin, Me.MnuFactorPol, Me.MenuItem20})
        Me.mnuSeguros.Text = "Seguros"
        '
        'mnuCaptSegu
        '
        Me.mnuCaptSegu.Enabled = False
        Me.mnuCaptSegu.Index = 0
        Me.mnuCaptSegu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuSEG1, Me.MnuSEG2, Me.MnuSEG3, Me.MnuSEG4, Me.MnuSEG5, Me.MenuItem35})
        Me.mnuCaptSegu.Text = "Captura de Seguros"
        '
        'MnuSEG1
        '
        Me.MnuSEG1.Index = 0
        Me.MnuSEG1.Text = "Alta de Poliza"
        '
        'MnuSEG2
        '
        Me.MnuSEG2.Index = 1
        Me.MnuSEG2.Text = "Captura Datos Poliza"
        '
        'MnuSEG3
        '
        Me.MnuSEG3.Index = 2
        Me.MnuSEG3.Text = "Poliza Entregada-Pagada"
        '
        'MnuSEG4
        '
        Me.MnuSEG4.Index = 3
        Me.MnuSEG4.Text = "Alta GPS"
        '
        'MnuSEG5
        '
        Me.MnuSEG5.Index = 4
        Me.MnuSEG5.Text = "Alta de Siniestros y Devoluciones"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 5
        Me.MenuItem35.Text = "Consulta Polizas"
        '
        'mnuFormMens
        '
        Me.mnuFormMens.Enabled = False
        Me.mnuFormMens.Index = 1
        Me.mnuFormMens.Text = "Forma Mensajería"
        '
        'MnuAltaPolAvi
        '
        Me.MnuAltaPolAvi.Enabled = False
        Me.MnuAltaPolAvi.Index = 2
        Me.MnuAltaPolAvi.Text = "Alta Polizas Avio"
        '
        'MnuSegFin
        '
        Me.MnuSegFin.Enabled = False
        Me.MnuSegFin.Index = 3
        Me.MnuSegFin.Text = "Capturar Seguros Financiados"
        '
        'MnuFactorPol
        '
        Me.MnuFactorPol.Enabled = False
        Me.MnuFactorPol.Index = 4
        Me.MnuFactorPol.Text = "Captura Polizas Factoraje"
        '
        'MenuItem20
        '
        Me.MenuItem20.Enabled = False
        Me.MenuItem20.Index = 5
        Me.MenuItem20.Text = "Carga GPS"
        '
        'mnuCont
        '
        Me.mnuCont.Enabled = False
        Me.mnuCont.Index = 5
        Me.mnuCont.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuImprCert, Me.mnuComputo, Me.mnuPondera, Me.mnuProyecta, Me.mnuRelaResp, Me.mnuIntCosto, Me.mnuCosto, Me.mnuCierre, Me.mnuRepCierre, Me.mnuRepSald2, Me.MnuGastosEXT, Me.MniBloqAvisos, Me.MenuItem19, Me.MenuTipoCambio, Me.MenuItem24})
        Me.mnuCont.Text = "Co&ntabilidad"
        '
        'mnuImprCert
        '
        Me.mnuImprCert.Enabled = False
        Me.mnuImprCert.Index = 0
        Me.mnuImprCert.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuECPorAnexo, Me.mnuECPorNombre})
        Me.mnuImprCert.Text = "Estados de Cuenta Certificados"
        '
        'mnuECPorAnexo
        '
        Me.mnuECPorAnexo.Enabled = False
        Me.mnuECPorAnexo.Index = 0
        Me.mnuECPorAnexo.Text = "Por Anexo"
        '
        'mnuECPorNombre
        '
        Me.mnuECPorNombre.Enabled = False
        Me.mnuECPorNombre.Index = 1
        Me.mnuECPorNombre.Text = "Por Nombre"
        '
        'mnuComputo
        '
        Me.mnuComputo.Enabled = False
        Me.mnuComputo.Index = 1
        Me.mnuComputo.Text = "Cómputo de Capitalización"
        '
        'mnuPondera
        '
        Me.mnuPondera.Enabled = False
        Me.mnuPondera.Index = 2
        Me.mnuPondera.Text = "Ponderación de la Cartera"
        '
        'mnuProyecta
        '
        Me.mnuProyecta.Enabled = False
        Me.mnuProyecta.Index = 3
        Me.mnuProyecta.Text = "Conciliación de Cartera"
        '
        'mnuRelaResp
        '
        Me.mnuRelaResp.Enabled = False
        Me.mnuRelaResp.Index = 4
        Me.mnuRelaResp.Text = "Relación de Responsabilidades"
        '
        'mnuIntCosto
        '
        Me.mnuIntCosto.Enabled = False
        Me.mnuIntCosto.Index = 5
        Me.mnuIntCosto.Text = "Integración del Costo"
        '
        'mnuCosto
        '
        Me.mnuCosto.Enabled = False
        Me.mnuCosto.Index = 6
        Me.mnuCosto.Text = "Determinación del Costo"
        '
        'mnuCierre
        '
        Me.mnuCierre.Enabled = False
        Me.mnuCierre.Index = 7
        Me.mnuCierre.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCierreCo, Me.mnuImprePol, Me.mnuGenCatal})
        Me.mnuCierre.Text = "Cierre de Mes"
        '
        'mnuCierreCo
        '
        Me.mnuCierreCo.Enabled = False
        Me.mnuCierreCo.Index = 0
        Me.mnuCierreCo.Text = "Correr procesos de cierre de mes"
        '
        'mnuImprePol
        '
        Me.mnuImprePol.Enabled = False
        Me.mnuImprePol.Index = 1
        Me.mnuImprePol.Text = "Imprimir pólizas contables"
        '
        'mnuGenCatal
        '
        Me.mnuGenCatal.Enabled = False
        Me.mnuGenCatal.Index = 2
        Me.mnuGenCatal.Text = "Bajar catálogo de cuentas"
        '
        'mnuRepCierre
        '
        Me.mnuRepCierre.Enabled = False
        Me.mnuRepCierre.Index = 8
        Me.mnuRepCierre.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRepDiezP, Me.mnuIntIvaPP})
        Me.mnuRepCierre.Text = "Reportes de Cierre de Mes"
        '
        'mnuRepDiezP
        '
        Me.mnuRepDiezP.Enabled = False
        Me.mnuRepDiezP.Index = 0
        Me.mnuRepDiezP.Text = "Principales Clientes"
        '
        'mnuIntIvaPP
        '
        Me.mnuIntIvaPP.Enabled = False
        Me.mnuIntIvaPP.Index = 1
        Me.mnuIntIvaPP.Text = "Integración de IVA por pagar"
        '
        'mnuRepSald2
        '
        Me.mnuRepSald2.Enabled = False
        Me.mnuRepSald2.Index = 9
        Me.mnuRepSald2.Text = "Saldos Insolutos por Plaza"
        '
        'MnuGastosEXT
        '
        Me.MnuGastosEXT.Enabled = False
        Me.MnuGastosEXT.Index = 10
        Me.MnuGastosEXT.Text = "Gastos Extraordinarios"
        '
        'MniBloqAvisos
        '
        Me.MniBloqAvisos.Enabled = False
        Me.MniBloqAvisos.Index = 11
        Me.MniBloqAvisos.Text = "Bloqueo Desbloquedo Avisos"
        '
        'MenuItem19
        '
        Me.MenuItem19.Enabled = False
        Me.MenuItem19.Index = 12
        Me.MenuItem19.Text = "Captura de Castigos/Garantías"
        '
        'MenuTipoCambio
        '
        Me.MenuTipoCambio.Enabled = False
        Me.MenuTipoCambio.Index = 13
        Me.MenuTipoCambio.Text = "Alta de Tipos de Cambio"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 14
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem25, Me.MenuItem26, Me.MenuItem28, Me.MenuItem29})
        Me.MenuItem24.Text = "Configuración 3.3"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 0
        Me.MenuItem25.Text = "UsoCFDI por Producto"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 1
        Me.MenuItem26.Text = "Codigo Art. por Concepto"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 2
        Me.MenuItem28.Text = "UsoCFDI por contrato"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 3
        Me.MenuItem29.Text = "Conceptos Activo Fijo"
        '
        'mnuSist
        '
        Me.mnuSist.Enabled = False
        Me.mnuSist.Index = 6
        Me.mnuSist.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRegenera, Me.mnuBuroCred, Me.mnuCostoIng, Me.mnuPortacar, Me.mnuCapitalizacion, Me.mnuCartas, Me.mnuReimprimir, Me.MenuIGenPASS, Me.MnuCancelaMov, Me.MnuBuroNom, Me.MnuPortaCont})
        Me.mnuSist.Text = "S&istemas"
        '
        'mnuRegenera
        '
        Me.mnuRegenera.Enabled = False
        Me.mnuRegenera.Index = 0
        Me.mnuRegenera.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRTPorAnexo})
        Me.mnuRegenera.Text = "Regenerar Tablas de Amortización"
        '
        'mnuRTPorAnexo
        '
        Me.mnuRTPorAnexo.Enabled = False
        Me.mnuRTPorAnexo.Index = 0
        Me.mnuRTPorAnexo.Text = "Por Anexo"
        '
        'mnuBuroCred
        '
        Me.mnuBuroCred.Enabled = False
        Me.mnuBuroCred.Index = 1
        Me.mnuBuroCred.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMorales, Me.mnuFisicas})
        Me.mnuBuroCred.Text = "Buró de Crédito"
        '
        'mnuMorales
        '
        Me.mnuMorales.Enabled = False
        Me.mnuMorales.Index = 0
        Me.mnuMorales.Text = "BNC Personas Morales"
        '
        'mnuFisicas
        '
        Me.mnuFisicas.Enabled = False
        Me.mnuFisicas.Index = 1
        Me.mnuFisicas.Text = "BNC Personas Físicas"
        '
        'mnuCostoIng
        '
        Me.mnuCostoIng.Enabled = False
        Me.mnuCostoIng.Index = 2
        Me.mnuCostoIng.Text = "Conciliar Costo vs Ingreso"
        '
        'mnuPortacar
        '
        Me.mnuPortacar.Enabled = False
        Me.mnuPortacar.Index = 3
        Me.mnuPortacar.Text = "Portafolio de Cartera para NAFIN"
        '
        'mnuCapitalizacion
        '
        Me.mnuCapitalizacion.Enabled = False
        Me.mnuCapitalizacion.Index = 4
        Me.mnuCapitalizacion.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCAPorAnexo})
        Me.mnuCapitalizacion.Text = "Capitalización de Adeudos"
        '
        'mnuCAPorAnexo
        '
        Me.mnuCAPorAnexo.Enabled = False
        Me.mnuCAPorAnexo.Index = 0
        Me.mnuCAPorAnexo.Text = "Por Anexo"
        '
        'mnuCartas
        '
        Me.mnuCartas.Enabled = False
        Me.mnuCartas.Index = 5
        Me.mnuCartas.Text = "Cartas a Clientes con EMail"
        '
        'mnuReimprimir
        '
        Me.mnuReimprimir.Enabled = False
        Me.mnuReimprimir.Index = 6
        Me.mnuReimprimir.Text = "Reimprimir facturas de pago"
        '
        'MenuIGenPASS
        '
        Me.MenuIGenPASS.Enabled = False
        Me.MenuIGenPASS.Index = 7
        Me.MenuIGenPASS.Text = "Genera Contraseña"
        '
        'MnuCancelaMov
        '
        Me.MnuCancelaMov.Enabled = False
        Me.MnuCancelaMov.Index = 8
        Me.MnuCancelaMov.Text = "Cancela Moivimientos"
        '
        'MnuBuroNom
        '
        Me.MnuBuroNom.Enabled = False
        Me.MnuBuroNom.Index = 9
        Me.MnuBuroNom.Text = "Llena Nombres de Clientes"
        '
        'MnuPortaCont
        '
        Me.MnuPortaCont.Enabled = False
        Me.MnuPortaCont.Index = 10
        Me.MnuPortaCont.Text = "Cargar Portafolio Contable"
        '
        'mnuCons
        '
        Me.mnuCons.Enabled = False
        Me.mnuCons.Index = 7
        Me.mnuCons.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDatosCon, Me.mnuFacSaldo, Me.mnuCalcfini, Me.mnuConsRefe, Me.mnuConsAviso, Me.mnuRepSalCli, Me.mnuConsultaCL, Me.mnuBuscarSerie, Me.MnuCondusef, Me.mnuProxVen, Me.MnuSaldosPuros, Me.MnuValPersonas, Me.MnuClientesGrupos, Me.mnuCartaRat, Me.MenuItem12, Me.MnuBitaJurConsul, Me.MenuItem17, Me.MnuCarteVecnMonitor, Me.MenuItem33, Me.MenuItem39})
        Me.mnuCons.Text = "Cons&ultas"
        '
        'mnuDatosCon
        '
        Me.mnuDatosCon.Enabled = False
        Me.mnuDatosCon.Index = 0
        Me.mnuDatosCon.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDCPorAnexo, Me.mnuDCPorNombre})
        Me.mnuDatosCon.Text = "Datos del Contrato"
        '
        'mnuDCPorAnexo
        '
        Me.mnuDCPorAnexo.Enabled = False
        Me.mnuDCPorAnexo.Index = 0
        Me.mnuDCPorAnexo.Text = "Por Anexo"
        '
        'mnuDCPorNombre
        '
        Me.mnuDCPorNombre.Enabled = False
        Me.mnuDCPorNombre.Index = 1
        Me.mnuDCPorNombre.Text = "Por Nombre"
        '
        'mnuFacSaldo
        '
        Me.mnuFacSaldo.Enabled = False
        Me.mnuFacSaldo.Index = 1
        Me.mnuFacSaldo.Text = "Estados de Cuenta"
        '
        'mnuCalcfini
        '
        Me.mnuCalcfini.Enabled = False
        Me.mnuCalcfini.Index = 2
        Me.mnuCalcfini.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCFPorAnexo, Me.mnuCFPorNombre})
        Me.mnuCalcfini.Text = "Cálculo de Finiquitos"
        '
        'mnuCFPorAnexo
        '
        Me.mnuCFPorAnexo.Enabled = False
        Me.mnuCFPorAnexo.Index = 0
        Me.mnuCFPorAnexo.Text = "Por Anexo"
        '
        'mnuCFPorNombre
        '
        Me.mnuCFPorNombre.Enabled = False
        Me.mnuCFPorNombre.Index = 1
        Me.mnuCFPorNombre.Text = "Por Nombre"
        '
        'mnuConsRefe
        '
        Me.mnuConsRefe.Enabled = False
        Me.mnuConsRefe.Index = 3
        Me.mnuConsRefe.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDRPorFecha, Me.mnuDRPorCliente})
        Me.mnuConsRefe.Text = "Depósitos Referenciados"
        '
        'mnuDRPorFecha
        '
        Me.mnuDRPorFecha.Enabled = False
        Me.mnuDRPorFecha.Index = 0
        Me.mnuDRPorFecha.Text = "Por Fecha"
        '
        'mnuDRPorCliente
        '
        Me.mnuDRPorCliente.Enabled = False
        Me.mnuDRPorCliente.Index = 1
        Me.mnuDRPorCliente.Text = "Por Cliente"
        '
        'mnuConsAviso
        '
        Me.mnuConsAviso.Enabled = False
        Me.mnuConsAviso.Index = 4
        Me.mnuConsAviso.Text = "Avisos de Vencimiento"
        '
        'mnuRepSalCli
        '
        Me.mnuRepSalCli.Enabled = False
        Me.mnuRepSalCli.Index = 5
        Me.mnuRepSalCli.Text = "Saldos Insolutos por Cliente"
        '
        'mnuConsultaCL
        '
        Me.mnuConsultaCL.Index = 6
        Me.mnuConsultaCL.Text = "Documentación Check List"
        '
        'mnuBuscarSerie
        '
        Me.mnuBuscarSerie.Index = 7
        Me.mnuBuscarSerie.Text = "Buscar Numero de Serie ó Motor"
        '
        'MnuCondusef
        '
        Me.MnuCondusef.Index = 8
        Me.MnuCondusef.Text = "Estado de Cuenta CONDUSEF"
        '
        'mnuProxVen
        '
        Me.mnuProxVen.Index = 9
        Me.mnuProxVen.Text = "Próximos Vencimientos"
        '
        'MnuSaldosPuros
        '
        Me.MnuSaldosPuros.Index = 10
        Me.MnuSaldosPuros.Text = "Saldos Insolutos AP"
        '
        'MnuValPersonas
        '
        Me.MnuValPersonas.Index = 11
        Me.MnuValPersonas.Text = "Clientes Relacionados"
        '
        'MnuClientesGrupos
        '
        Me.MnuClientesGrupos.Index = 12
        Me.MnuClientesGrupos.Text = "Clientes (RC y GN)"
        '
        'mnuCartaRat
        '
        Me.mnuCartaRat.Enabled = False
        Me.mnuCartaRat.Index = 13
        Me.mnuCartaRat.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCRPorAnexo, Me.mnuCRPorNombre})
        Me.mnuCartaRat.Text = "Carta de Ratificación"
        '
        'mnuCRPorAnexo
        '
        Me.mnuCRPorAnexo.Enabled = False
        Me.mnuCRPorAnexo.Index = 0
        Me.mnuCRPorAnexo.Text = "Por Anexo"
        '
        'mnuCRPorNombre
        '
        Me.mnuCRPorNombre.Enabled = False
        Me.mnuCRPorNombre.Index = 1
        Me.mnuCRPorNombre.Text = "Por Nombre"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 14
        Me.MenuItem12.Text = "On Base"
        '
        'MnuBitaJurConsul
        '
        Me.MnuBitaJurConsul.Index = 15
        Me.MnuBitaJurConsul.Text = "Bitacora Juridico"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 16
        Me.MenuItem17.Text = "Promotores"
        '
        'MnuCarteVecnMonitor
        '
        Me.MnuCarteVecnMonitor.Index = 17
        Me.MnuCarteVecnMonitor.Text = "Monitor Cartera Vencida"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 18
        Me.MenuItem33.Text = "Monitor Seguimiento de Credito"
        '
        'mnuRep
        '
        Me.mnuRep.Enabled = False
        Me.mnuRep.Index = 8
        Me.mnuRep.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRepoProm, Me.mnuRepAntig, Me.MenuItem4, Me.mnuRepoSegu, Me.MnuCalCartera, Me.MnuFondoRPT, Me.MnuBitactoraProm, Me.mnuOperIR, Me.MnuCCXvencer, Me.MenuItem10, Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem18, Me.MenuItem38, Me.MenuItem21})
        Me.mnuRep.Text = "&Reportes"
        '
        'mnuRepoProm
        '
        Me.mnuRepoProm.Enabled = False
        Me.mnuRepoProm.Index = 0
        Me.mnuRepoProm.Text = "Reporte de Activaciones"
        '
        'mnuRepAntig
        '
        Me.mnuRepAntig.Enabled = False
        Me.mnuRepAntig.Index = 1
        Me.mnuRepAntig.Text = "Antigüedad de Saldos"
        '
        'MenuItem4
        '
        Me.MenuItem4.Enabled = False
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "Antigüedad de Saldos Hist."
        '
        'mnuRepoSegu
        '
        Me.mnuRepoSegu.Enabled = False
        Me.mnuRepoSegu.Index = 3
        Me.mnuRepoSegu.Text = "Reporte de Seguros"
        '
        'MnuCalCartera
        '
        Me.MnuCalCartera.Enabled = False
        Me.MnuCalCartera.Index = 4
        Me.MnuCalCartera.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuConsumo, Me.MnuComercial})
        Me.MnuCalCartera.Text = "Calificacion de Cartera"
        '
        'MnuConsumo
        '
        Me.MnuConsumo.Enabled = False
        Me.MnuConsumo.Index = 0
        Me.MnuConsumo.Text = "Consumo"
        '
        'MnuComercial
        '
        Me.MnuComercial.Enabled = False
        Me.MnuComercial.Index = 1
        Me.MnuComercial.Text = "Comercial"
        '
        'MnuFondoRPT
        '
        Me.MnuFondoRPT.Index = 5
        Me.MnuFondoRPT.Text = "Fondo de Reserva"
        '
        'MnuBitactoraProm
        '
        Me.MnuBitactoraProm.Index = 6
        Me.MnuBitactoraProm.Text = "Asignación de Promotores"
        '
        'mnuOperIR
        '
        Me.mnuOperIR.Index = 7
        Me.mnuOperIR.Text = "Op. Inusuales/Relevantes "
        '
        'MnuCCXvencer
        '
        Me.MnuCCXvencer.Enabled = False
        Me.MnuCCXvencer.Index = 8
        Me.MnuCCXvencer.Text = "Pagares por Vencer CC"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 9
        Me.MenuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem11})
        Me.MenuItem10.Text = "Reportes Conusef"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 0
        Me.MenuItem11.Text = "Reporte de Cartera"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 10
        Me.MenuItem13.Text = "Reporte Seguros (Aseguradora)"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 11
        Me.MenuItem14.Text = "Avíos por Vencer"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 12
        Me.MenuItem15.Text = "Reporte de Segumiento de Cob."
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 13
        Me.MenuItem18.Text = "Reporte Activaciones Junta de Consejo"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 14
        Me.MenuItem38.Text = "Pagos Anticipados"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 15
        Me.MenuItem21.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItem22, Me.MenuItem8, Me.MenuItem23})
        Me.MenuItem21.Text = "Reportes de Cartera"
        '
        'MenuItem9
        '
        Me.MenuItem9.Enabled = False
        Me.MenuItem9.Index = 0
        Me.MenuItem9.Text = "Reporte de Cartera Vencida"
        '
        'MenuItem22
        '
        Me.MenuItem22.Enabled = False
        Me.MenuItem22.Index = 1
        Me.MenuItem22.Text = "Reporte de Cartera Global"
        '
        'MenuItem8
        '
        Me.MenuItem8.Enabled = False
        Me.MenuItem8.Index = 2
        Me.MenuItem8.Text = "Reporte de Cartera Exigible"
        '
        'MenuItem23
        '
        Me.MenuItem23.Enabled = False
        Me.MenuItem23.Index = 3
        Me.MenuItem23.Text = "Reporte de Cartera Reestructurada"
        '
        'mnuRiesgos
        '
        Me.mnuRiesgos.Enabled = False
        Me.mnuRiesgos.Index = 9
        Me.mnuRiesgos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCCartera, Me.mnuFega, Me.mnuTasasApl, Me.mnuRegTasas, Me.mnuActVigencia, Me.MnuDesbloqTasa})
        Me.mnuRiesgos.Text = "Riesgos"
        '
        'mnuCCartera
        '
        Me.mnuCCartera.Enabled = False
        Me.mnuCCartera.Index = 0
        Me.mnuCCartera.Text = "Calificación de la Cartera"
        '
        'mnuFega
        '
        Me.mnuFega.Enabled = False
        Me.mnuFega.Index = 1
        Me.mnuFega.Text = "Captura comisión FEGA"
        '
        'mnuTasasApl
        '
        Me.mnuTasasApl.Index = 2
        Me.mnuTasasApl.Text = "Tasas Aplicables "
        '
        'mnuRegTasas
        '
        Me.mnuRegTasas.Index = 3
        Me.mnuRegTasas.Text = "Registro de Tasas Aplicables"
        '
        'mnuActVigencia
        '
        Me.mnuActVigencia.Index = 4
        Me.mnuActVigencia.Text = "Actualizar Vigencia de Tasas Apl."
        '
        'MnuDesbloqTasa
        '
        Me.MnuDesbloqTasa.Enabled = False
        Me.MnuDesbloqTasa.Index = 5
        Me.MnuDesbloqTasa.Text = "Desbloqueo de Anexos"
        '
        'mnuAvio
        '
        Me.mnuAvio.Enabled = False
        Me.mnuAvio.Index = 10
        Me.mnuAvio.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAltaContratos, Me.mnuModCtoAvio, Me.mnuImpCtoAvio, Me.mnuSustrae, Me.mnuEstratificacion, Me.mnuMinistraciones, Me.mnuReportes, Me.mnuEdoCtaAvio, Me.mnuPagares, Me.mnuCapturaPMI, Me.mnuExpDigital, Me.MnuParametrosAvio, Me.MnuSolAvio, Me.MenuItem5, Me.MnuFechasSuper})
        Me.mnuAvio.Text = "Avío"
        '
        'mnuAltaContratos
        '
        Me.mnuAltaContratos.Enabled = False
        Me.mnuAltaContratos.Index = 0
        Me.mnuAltaContratos.Text = "Alta de Contratos"
        '
        'mnuModCtoAvio
        '
        Me.mnuModCtoAvio.Enabled = False
        Me.mnuModCtoAvio.Index = 1
        Me.mnuModCtoAvio.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuModCtoAvioPorProductor, Me.mnuModCtoAvioPorContrato})
        Me.mnuModCtoAvio.Text = "Modificación de Contratos"
        '
        'mnuModCtoAvioPorProductor
        '
        Me.mnuModCtoAvioPorProductor.Index = 0
        Me.mnuModCtoAvioPorProductor.Text = "Por Productor"
        '
        'mnuModCtoAvioPorContrato
        '
        Me.mnuModCtoAvioPorContrato.Index = 1
        Me.mnuModCtoAvioPorContrato.Text = "Por Contrato"
        '
        'mnuImpCtoAvio
        '
        Me.mnuImpCtoAvio.Index = 2
        Me.mnuImpCtoAvio.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuImpCtoAvioPorProductor, Me.mnuImpCtoAvioPorContrato})
        Me.mnuImpCtoAvio.Text = "Impresión de Contratos"
        '
        'mnuImpCtoAvioPorProductor
        '
        Me.mnuImpCtoAvioPorProductor.Index = 0
        Me.mnuImpCtoAvioPorProductor.Text = "Por Productor"
        '
        'mnuImpCtoAvioPorContrato
        '
        Me.mnuImpCtoAvioPorContrato.Index = 1
        Me.mnuImpCtoAvioPorContrato.Text = "Por Contrato"
        '
        'mnuSustrae
        '
        Me.mnuSustrae.Enabled = False
        Me.mnuSustrae.Index = 3
        Me.mnuSustrae.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRCS, Me.mnuPSC})
        Me.mnuSustrae.Text = "Sustrae"
        '
        'mnuRCS
        '
        Me.mnuRCS.Index = 0
        Me.mnuRCS.Text = "Registro de Consultas"
        '
        'mnuPSC
        '
        Me.mnuPSC.Index = 1
        Me.mnuPSC.Text = "Productores sin consultar"
        '
        'mnuEstratificacion
        '
        Me.mnuEstratificacion.Enabled = False
        Me.mnuEstratificacion.Index = 4
        Me.mnuEstratificacion.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMemoria, Me.mnuRE})
        Me.mnuEstratificacion.Text = "Estratificación"
        '
        'mnuMemoria
        '
        Me.mnuMemoria.Index = 0
        Me.mnuMemoria.Text = "Determinación"
        '
        'mnuRE
        '
        Me.mnuRE.Index = 1
        Me.mnuRE.Text = "Reporte"
        '
        'mnuMinistraciones
        '
        Me.mnuMinistraciones.Enabled = False
        Me.mnuMinistraciones.Index = 5
        Me.mnuMinistraciones.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMinistracionesPorProductor, Me.mnuMinistracionesPorContrato})
        Me.mnuMinistraciones.Text = "Ministraciones"
        '
        'mnuMinistracionesPorProductor
        '
        Me.mnuMinistracionesPorProductor.Index = 0
        Me.mnuMinistracionesPorProductor.Text = "Por Productor"
        '
        'mnuMinistracionesPorContrato
        '
        Me.mnuMinistracionesPorContrato.Index = 1
        Me.mnuMinistracionesPorContrato.Text = "Por Contrato"
        '
        'mnuReportes
        '
        Me.mnuReportes.Enabled = False
        Me.mnuReportes.Index = 6
        Me.mnuReportes.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMinistracionFFP, Me.mnuMinistracionFP})
        Me.mnuReportes.Text = "Reporte de Ministraciones"
        '
        'mnuMinistracionFFP
        '
        Me.mnuMinistracionFFP.Index = 0
        Me.mnuMinistracionFFP.Text = "FIRA-FINAGIL-Productor"
        '
        'mnuMinistracionFP
        '
        Me.mnuMinistracionFP.Index = 1
        Me.mnuMinistracionFP.Text = "FINAGIL-Productor"
        '
        'mnuEdoCtaAvio
        '
        Me.mnuEdoCtaAvio.Enabled = False
        Me.mnuEdoCtaAvio.Index = 7
        Me.mnuEdoCtaAvio.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuECPP, Me.mnuECTC})
        Me.mnuEdoCtaAvio.Text = "Estado de Cuenta"
        '
        'mnuECPP
        '
        Me.mnuECPP.Index = 0
        Me.mnuECPP.Text = "Por Productor"
        '
        'mnuECTC
        '
        Me.mnuECTC.Index = 1
        Me.mnuECTC.Text = "Global"
        '
        'mnuPagares
        '
        Me.mnuPagares.Enabled = False
        Me.mnuPagares.Index = 8
        Me.mnuPagares.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPagaresPorProductor, Me.mnuPagaresPorContrato})
        Me.mnuPagares.Text = "Registro de Pagarés"
        '
        'mnuPagaresPorProductor
        '
        Me.mnuPagaresPorProductor.Index = 0
        Me.mnuPagaresPorProductor.Text = "Por Productor"
        '
        'mnuPagaresPorContrato
        '
        Me.mnuPagaresPorContrato.Index = 1
        Me.mnuPagaresPorContrato.Text = "Por Contrato"
        '
        'mnuCapturaPMI
        '
        Me.mnuCapturaPMI.Index = 9
        Me.mnuCapturaPMI.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCapturaPMIPorProductor, Me.mnuCapturaPMIPorContrato})
        Me.mnuCapturaPMI.Text = "Captura de Predios y Bienes"
        '
        'mnuCapturaPMIPorProductor
        '
        Me.mnuCapturaPMIPorProductor.Index = 0
        Me.mnuCapturaPMIPorProductor.Text = "Por Productor"
        '
        'mnuCapturaPMIPorContrato
        '
        Me.mnuCapturaPMIPorContrato.Index = 1
        Me.mnuCapturaPMIPorContrato.Text = "Por Contrato"
        '
        'mnuExpDigital
        '
        Me.mnuExpDigital.Index = 10
        Me.mnuExpDigital.Text = "Expediente Digital"
        '
        'MnuParametrosAvio
        '
        Me.MnuParametrosAvio.Index = 11
        Me.MnuParametrosAvio.Text = "Parametros Avio"
        '
        'MnuSolAvio
        '
        Me.MnuSolAvio.Index = 12
        Me.MnuSolAvio.Text = "Solicitudes Avio"
        '
        'MenuItem5
        '
        Me.MenuItem5.Enabled = False
        Me.MenuItem5.Index = 13
        Me.MenuItem5.Text = "Ampliacion de Anticipos"
        '
        'MnuFechasSuper
        '
        Me.MnuFechasSuper.Index = 14
        Me.MnuFechasSuper.Text = "Fechas Supervisión"
        '
        'MnuJuridico
        '
        Me.MnuJuridico.Enabled = False
        Me.MnuJuridico.Index = 11
        Me.MnuJuridico.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuClavesOBS, Me.MnuConvenioJur, Me.MnuBitaJur, Me.mnuBitacora, Me.mnuSegBitacora, Me.MnuRepCobDia, Me.MenuItem32, Me.MenuItem30})
        Me.MnuJuridico.Text = "Juridico"
        '
        'MnuClavesOBS
        '
        Me.MnuClavesOBS.Enabled = False
        Me.MnuClavesOBS.Index = 0
        Me.MnuClavesOBS.Text = "Claves de Observación (Buró)"
        '
        'MnuConvenioJur
        '
        Me.MnuConvenioJur.Enabled = False
        Me.MnuConvenioJur.Index = 1
        Me.MnuConvenioJur.Text = "Convenios Judiciales"
        '
        'MnuBitaJur
        '
        Me.MnuBitaJur.Enabled = False
        Me.MnuBitaJur.Index = 2
        Me.MnuBitaJur.Text = "Bitacora Juridico"
        '
        'mnuBitacora
        '
        Me.mnuBitacora.Enabled = False
        Me.mnuBitacora.Index = 3
        Me.mnuBitacora.Text = "Seguimiento de Cobranza"
        '
        'mnuSegBitacora
        '
        Me.mnuSegBitacora.Enabled = False
        Me.mnuSegBitacora.Index = 4
        Me.mnuSegBitacora.Text = "Reporte de Seguimiento"
        '
        'MnuRepCobDia
        '
        Me.MnuRepCobDia.Enabled = False
        Me.MnuRepCobDia.Index = 5
        Me.MnuRepCobDia.Text = "Reporte de Cobranza por día"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 6
        Me.MenuItem32.Text = "Cambio de Fecha de Contrato AV"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 7
        Me.MenuItem30.Text = "Retrasos Justificados BC"
        '
        'MenuItem3
        '
        Me.MenuItem3.Enabled = False
        Me.MenuItem3.Index = 12
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCaptValo, Me.MnuReestruct, Me.MenuItem6, Me.MenuItem7, Me.MnuMcBitacora, Me.MnuLiberMC, Me.MnuLiberAvio, Me.MnuModReest, Me.MenuItem34})
        Me.MenuItem3.Text = "Mesa de Control"
        '
        'mnuCaptValo
        '
        Me.mnuCaptValo.Enabled = False
        Me.mnuCaptValo.Index = 0
        Me.mnuCaptValo.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCTradicional, mnuCAvio})
        Me.mnuCaptValo.Text = "Captura de Valores"
        '
        'mnuCTradicional
        '
        Me.mnuCTradicional.Enabled = False
        Me.mnuCTradicional.Index = 0
        Me.mnuCTradicional.Text = "Crédito Tradicional"
        '
        'MnuReestruct
        '
        Me.MnuReestruct.Enabled = False
        Me.MnuReestruct.Index = 1
        Me.MnuReestruct.Text = "Reestructuras"
        '
        'MenuItem6
        '
        Me.MenuItem6.Enabled = False
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Text = "Reporte de Guardavalores"
        '
        'MenuItem7
        '
        Me.MenuItem7.Enabled = False
        Me.MenuItem7.Index = 3
        Me.MenuItem7.Text = "Hoja de Tasa Especial"
        '
        'MnuMcBitacora
        '
        Me.MnuMcBitacora.Enabled = False
        Me.MnuMcBitacora.Index = 4
        Me.MnuMcBitacora.Text = "Bitacora MC"
        '
        'MnuLiberMC
        '
        Me.MnuLiberMC.Enabled = False
        Me.MnuLiberMC.Index = 5
        Me.MnuLiberMC.Text = "Liberación Tradicionales"
        '
        'MnuLiberAvio
        '
        Me.MnuLiberAvio.Enabled = False
        Me.MnuLiberAvio.Index = 6
        Me.MnuLiberAvio.Text = "Liberacion Avío"
        '
        'MnuModReest
        '
        Me.MnuModReest.Enabled = False
        Me.MnuModReest.Index = 7
        Me.MnuModReest.Text = "Modulo Reestructuras"
        '
        'MenuItem34
        '
        Me.MenuItem34.Enabled = False
        Me.MenuItem34.Index = 8
        Me.MenuItem34.Text = "Historial Crediticio MC"
        '
        'MnuPLD
        '
        Me.MnuPLD.Enabled = False
        Me.MnuPLD.Index = 13
        Me.MnuPLD.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuPLdAuto})
        Me.MnuPLD.Text = "PLD"
        '
        'MnuPLdAuto
        '
        Me.MnuPLdAuto.Index = 0
        Me.MnuPLdAuto.Text = "Autirizaciones PLD"
        '
        'MnuFira
        '
        Me.MnuFira.Enabled = False
        Me.MnuFira.Index = 14
        Me.MnuFira.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuAutoAviCRE, Me.MenuItem37})
        Me.MnuFira.Text = "Oper. FIRA"
        '
        'MnuAutoAviCRE
        '
        Me.MnuAutoAviCRE.Enabled = False
        Me.MnuAutoAviCRE.Index = 0
        Me.MnuAutoAviCRE.Text = "Descuentos de Avío"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 1
        Me.MenuItem37.Text = "Reporte Supervisión FIRA"
        '
        'mnuSalir
        '
        Me.mnuSalir.Index = 15
        Me.mnuSalir.Text = "&Salir"
        '
        'PendientesORGBindingSource
        '
        Me.PendientesORGBindingSource.DataMember = "PendientesORG"
        Me.PendientesORGBindingSource.DataSource = Me.GeneralDSBindingSource
        '
        'GeneralDSBindingSource
        '
        Me.GeneralDSBindingSource.DataSource = Me.GeneralDS
        Me.GeneralDSBindingSource.Position = 0
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PendientesFINBindingSource
        '
        Me.PendientesFINBindingSource.DataMember = "PendientesFIN"
        Me.PendientesFINBindingSource.DataSource = Me.GeneralDSBindingSource
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PendientesORGTableAdapter
        '
        Me.PendientesORGTableAdapter.ClearBeforeFill = True
        '
        'PendientesFINTableAdapter
        '
        Me.PendientesFINTableAdapter.ClearBeforeFill = True
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 19
        Me.MenuItem39.Text = "Monitor Seguimiento Avío y CC"
        '
        'frmAgil
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1097, 0)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmAgil"
        Me.Text = "FINAGIL, S.A. de C.V. SOFOM, E.N.R."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PendientesORGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PendientesFINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call DOC_ConvenioLIQ.SacaConvenio("035730002")
        'Dim x As Date = Replace("23-ago-16", "Ago", "aug", 1, 1, CompareMethod.Text)
        'Dim c As String = Desencriptar("55B2MHBVkX9xu73sUSzlKuNdc9xVDdXA")
        'c = Desencriptar(c)
        'HistoriaEdoCtaV("035860002") 'ESTA SIRVE PARA RESPALDAR LA HISTORIA DEL EdoCtaV
        ' Declaración de variables de conexión ADO .NET
        'Dim RutaApp As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase)
        'AppSet_GetLockTimeOut()
        'algo mas
        Dim RutaApp As String = ""
        If Directory.Exists("c:\program files (x86)\") Then
            RutaApp = "c:\program files (x86)\"
        Else
            RutaApp = "C:\Archivos de programa\"
        End If
        Dim cn As New SqlConnection()
        Dim cm As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daMenus As New SqlDataAdapter(cm)
        Dim drMenu As DataRow
        Dim strConnectionSecurity As String
        Dim strSelect As String

        ' Declaración de variables de datos

        Dim aVariables() As String
        Dim CadenaClaves As String
        Dim Usuario As String
        Dim Password As String
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim Cadena As String = Encriptar("Edgar caceres trigueros as as as as as ")
        Cadena = Desencriptar(Cadena)
        Dim Args() As String
        Try
            Args = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData
        Catch ex As Exception
            ReDim Args(1)
            Args(0) = "1"
        End Try

        Try
            Dim rkCurrentUser As RegistryKey = Registry.CurrentUser
            ' Obtain the test key (read-only) and display it.
            Dim rkTest As RegistryKey = rkCurrentUser.OpenSubKey("Software\INFO100\FINANCIERA")
            rkTest.Close()
            rkCurrentUser.Close()
            rkTest = Registry.CurrentUser.OpenSubKey("Software\INFO100\FINANCIERA")
            rkTest.Close()
            rkTest = Registry.CurrentUser.OpenSubKey("Software\INFO100\FINANCIERA", True)
            strConnectionSecurity = rkTest.GetValue("SEGURIDAD").ToString
            Dim cadenacon As String
            cadenacon = rkTest.GetValue("FINANCIERA").ToString
            'Usuario = Mid(cadenacon, InStr(cadenacon, "user ID ="), 10)
            'Password = rkTest.GetValue("Contrasena").ToString
            Usuario = rkTest.GetValue("Usuario").ToString
            USUARIOX = Usuario
            UsuarioGlobal = Usuario
            Password = rkTest.GetValue("Contrasena").ToString
            rkTest.Close()

            If UsuarioGlobal <> "desarrollo" And UsuarioGlobal <> "lgarciacX" Then
                If (InStr(Args(0), "Agil.application") <= 0 And InStr(Args(0), "Finagil.application") <= 0) And UsuarioGlobal <> "desarrollo" Then
                    MessageBox.Show("Faltan argumentos para iniciar esta aplicación. (Error1) " & Args(0) & " " & UsuarioGlobal, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End
                End If
            End If

        Catch eException As Exception
            Console.WriteLine("The file could not be read:")
            MessageBox.Show(eException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try



        ' Esta consulta trae las opciones definidas para el usuario que está ingresando al sistema

        strSelect = "SELECT cve_menu, cve_submenu, cve_ssubmenu, cve_sssubmenu FROM SEG_MAESTRA " &
        "WHERE cve_perfil IN (SELECT PERFILES.cve_perfil FROM PERFILES " &
                              "INNER JOIN USUARIOS_PERFILES ON PERFILES.cve_perfil = USUARIOS_PERFILES.cve_perfil " &
                              "INNER JOIN USUARIO ON USUARIOS_PERFILES.cve_empleado = USUARIO.cve_empleado " &
                              "WHERE nom_sistema = 'FINANCIERA' AND (USUARIO.id_usuario = '" & Usuario & "' ))" &
        "ORDER BY cve_menu, cve_submenu, cve_ssubmenu, cve_sssubmenu"

        ' Aquí se crea la cadena de conexión a la base de datos SEGURIDAD

        cn.ConnectionString = strConnectionSecurity

        With cm
            .Connection = cn
            .CommandText = strSelect
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daMenus.Fill(dsAgil, "Menus")

        UsuarioGlobalNombre = USER_SEC.ScalarNombre(Usuario)
        UsuarioGlobalDepto = USER_SEC.ScalarDepto(Usuario)
        UsuarioGlobalCorreo = USER_SEC.ScalarCorreo(Usuario)

        ' La primera vez que corre esta rutina es para deshabilitar todas las opciones del menú y submenús.
        ' Si tenemos cuidado de deshabilitar los menús desde el diseño, entonces podemos omitir esta sección.
        ' MsgBox(strSelect)

        For i = 0 To Menu.MenuItems.Count - 1
            For j = 0 To Menu.MenuItems(i).MenuItems.Count - 1
                For k = 0 To Menu.MenuItems(i).MenuItems(j).MenuItems.Count - 1
                    Menu.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = False
                Next
                Menu.MenuItems(i).MenuItems(j).Enabled = False
            Next
            Menu.MenuItems(i).Enabled = False
        Next
        'MsgBox("Carga Menus")
        ' La segunda vez que corre esta rutina es para habilitar las opciones de menú que se hayan definido
        ' para el usuario que está ingresando al sistema.
        'MsgBox(dsAgil.Tables("Menus").Rows.Count)
        'MsgBox(cn.ConnectionString)
        Try
            For Each drMenu In dsAgil.Tables("Menus").Rows
                i = drMenu(0) - 1
                j = drMenu(1) - 1
                k = drMenu(2) - 1
                If drMenu(0) = 5 Then
                    i = i
                End If

                If i >= 0 Then
                    If j >= 0 Then
                        If k >= 0 Then
                            Menu.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = True
                        Else
                            Menu.MenuItems(i).MenuItems(j).Enabled = True
                        End If
                    Else
                        Menu.MenuItems(i).Enabled = True
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error de Menú, favor de notificar al area de Sistemas", "Error de Menú", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If UsuarioGlobal <> "desarrollo" And UsuarioGlobal <> "lgarciacX" Then
                End
            End If
        End Try

        If UsuarioGlobal = "desarrollo" Or UsuarioGlobal = "lgarciacX" Then
            For i = 0 To Menu.MenuItems.Count - 1
                For j = 0 To Menu.MenuItems(i).MenuItems.Count - 1
                    For k = 0 To Menu.MenuItems(i).MenuItems(j).MenuItems.Count - 1
                        Menu.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = True
                    Next
                    Menu.MenuItems(i).MenuItems(j).Enabled = True
                Next
                Menu.MenuItems(i).Enabled = True
            Next
        End If
        ' MsgBox("Carga Menus")

        ' En esta rutina se crea la cadena de conexión a la base de datos Production (si se deseara conectarse
        ' a otra base de datos habría que modificar el código en ModConexion.vb que es el módulo donde está
        ' contenida la variable pública StrConn y la rutina pública CreaCadenaConexion).

        CreaCadenaConexion(Usuario, Password, My.Settings.BaseDatos, My.Settings.ServidorX)
        CreaCadenaConexion("User_PRO", "User_PRO2015", My.Settings.BaseDatos, My.Settings.ServidorX)

        Dim Segurdad As New SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
        'If UsuarioGlobal = "vely" Or Segurdad.ScalarArea(UsuarioGlobal) = "PROMOCION" Then
        'Timer1.Enabled = True
        'Call Pendientes()
        'End If
        Segurdad.Dispose()
        Timer1.Start()

        'Usuario = "lhernandez"
        'USUARIOX = "lhernandez"
        'UsuarioGlobal = "lhernandez"

        SacaFechaAplicacion()
        Me.Text = "FINAGIL, S.A. de C.V. SOFOM, E.N.R.                   (Fecha de Aplicacion de Pagos: " & FECHA_APLICACION.ToShortDateString & ")                  Usuario: " & UsuarioGlobal & "          DB: " & My.Settings.BaseDatos

        'PRUEBA DE BLOQUEO DE CONTRATOS MESA DE CONTROL
        'Dim CANEXO As String = "123450000"
        'Dim BLOQ As Integer = DesBloqueaContrato(cAnexo) 'DESBLOQUEO MESA DE CONTROL+++++++++++++
        'BloqueaContrato(cAnexo, BLOQ) '*******************BLOQUEO MESA DE CONTROL++++++++++++++++

        If Not Directory.Exists("c:\Contratos\") Then
            Directory.CreateDirectory("c:\Contratos\")
        End If
        If Not Directory.Exists("c:\Files\") Then
            Directory.CreateDirectory("c:\Files\")
        End If
        Try
            Dim cad As String = TaQUERY.SacaCancelaMoraDiaFestivo
            CANCELA_MORA_DIA_FEST = cad.Split(";")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mnuCotizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCotizar.Click
        Dim newfrmCotizador As New frmCotizador()
        newfrmCotizador.Show()
    End Sub

    Private Sub mnuAltaClie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAltaClie.Click
        Dim newfrmAltaClie As New frmAltaClie()
        newfrmAltaClie.Show()
    End Sub

    Private Sub mnuContClie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuContClie.Click
        Dim newfrmContClie As New frmContClie()
        newfrmContClie.Show()
    End Sub

    Private Sub mnuContSoli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuContSoli.Click
        Dim newfrmPideCliente As New frmPideCliente("mnuContSoli")
        newfrmPideCliente.Show()
    End Sub

    Private Sub mnuCaptFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCaptFact.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuCaptFact")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuPrendaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrendaria.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuPrendaria")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuActiAnex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActiAnex.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuActiAnex")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuDesactiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDesactiv.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuDesactiv")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuSeguiCre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSeguiCre.Click
        Dim newfrmPideCliente As New frmPideCliente("mnuSeguiCre")
        newfrmPideCliente.Show()
    End Sub

    Private Sub mnuReciPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReciPago.Click
        Dim newfrmRecipago As New frmRecipago()
        newfrmRecipago.Show()
    End Sub

    Private Sub mnuACPorAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuACPorAnexo.Click
        Dim newfrmPideContrato As New frmPideContrato("mnuAdelanto")
        newfrmPideContrato.Show()
    End Sub

    Private Sub mnuACPorNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuACPorNombre.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuAdelanto")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuFCPorAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFCPorAnexo.Click
        Dim newfrmPideContrato As New frmPideContrato("mnuFiniquito")
        newfrmPideContrato.Show()
    End Sub

    Private Sub mnuFCPorNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFCPorNombre.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuFiniquito")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuImprActi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImprActi.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuImprActi")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuDomicilio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDomicilio.Click
        Dim newfrmDomicilio As New frmDomicilio()
        newfrmDomicilio.Show()
    End Sub

    Private Sub mnuRepCobra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRepCobra.Click
        Dim newfrmRepCobra As New frmRepcobra()
        newfrmRepCobra.Show()
    End Sub

    Private Sub mnuBitacora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBitacora.Click
        Dim newfrmBitacora As New frmBitacora()
        newfrmBitacora.Show()
    End Sub

    Private Sub mnuSegBitacora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSegBitacora.Click
        Dim newfrmSegBitacora As New frmSegBitacora()
        newfrmSegBitacora.Show()
    End Sub

    Private Sub mnuRecupera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRecupera.Click
        Dim newfrmRecuperacion As New frmRecuperacion()
        newfrmRecuperacion.Show()
    End Sub

    Private Sub mnuRepGaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRepGaran.Click
        Dim newfrmRepGaran As New frmRepGaran()
        newfrmRepGaran.Show()
    End Sub

    Private Sub mnuRepoDisp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRepoDisp.Click
        Dim newfrmRepoDisp As New frmRepoDisp()
        newfrmRepoDisp.Show()
    End Sub

    Private Sub mnuRepNafin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRepNafin.Click
        Dim newfrmRepNafin As New frmRepNafin()
        newfrmRepNafin.Show()
    End Sub

    Private Sub mnuActuatas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActuaTas.Click
        Dim newfrmActuatas As New frmActuatas()
        newfrmActuatas.Show()
    End Sub

    Private Sub mnuActuaUdis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActuaUdis.Click
        Dim newfrmActuaUdis As New frmActuaUdis()
        newfrmActuaUdis.Show()
    End Sub

    Private Sub mnuSegumanu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSeguManu.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuSegumanu")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuGeneFac_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuGeneFac.Click
        Dim newfrmGeneFact As New frmGeneFact()
        newfrmGeneFact.Show()
    End Sub

    Private Sub mnuImpreFac_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuImpreFac.Click
        Dim newfrmImpreFac As New frmImpreFac()
        newfrmImpreFac.Show()
    End Sub

    Private Sub mnuImpAcuses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImpAcuses.Click
        'Dim newfrmImpAcuses As New frmImpAcuses()
        'newfrmImpAcuses.Show()
    End Sub

    Private Sub mnuRelaFact_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRelaFact.Click
        Dim newfrmRelaFact As New frmRelaFact()
        newfrmRelaFact.Show()
    End Sub

    Private Sub mnuArchivosDCI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuArchivosDCI.Click
        'Dim newfrmArchivosDCI As New frmArchivosDCI()
        'newfrmArchivosDCI.Show()
    End Sub

    Private Sub mnuCifrasDCI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCifrasDCI.Click
        Dim newCifrascon As New frmCifrasCont()
        newCifrascon.Show()
    End Sub

    Private Sub mnuAvisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAvisos.Click
        'Dim newfrmAvisos As New frmAvisos()
        'newfrmAvisos.Show()
    End Sub

    Private Sub mnuGenAviso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGenAviso.Click
        Dim newfrmGenAviso As New frmGenAviso()
        newfrmGenAviso.Show()
    End Sub

    'Private Sub mnuCaptValo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCaptValo.Click
    '    Dim newfrmPideAnexo As New frmPideAnexo("mnuCaptValo")
    '    newfrmPideAnexo.Show()
    'End Sub


    'Private Sub mnuFormMens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFormMens.Click
    '    Dim newfrmMensajeria As New frmMensajeria()
    '    newfrmMensajeria.Show()
    'End Sub

    Private Sub mnuECPorAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuECPorAnexo.Click
        Dim newfrmPideContrato As New frmPideContrato("mnuImprCert")
        newfrmPideContrato.Show()
    End Sub

    Private Sub mnuECPorNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuECPorNombre.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuImprCert")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuComputo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuComputo.Click
        Dim newfrmComputo As New frmComputo
        newfrmComputo.Show()
    End Sub

    Private Sub mnuPondera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPondera.Click
        Dim newfrmPondera As New frmPondera()
        newfrmPondera.Show()
    End Sub

    Private Sub mnuProyecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProyecta.Click
        Dim newfrmProyecta As New frmConciliacionCartera()
        newfrmProyecta.Show()
    End Sub

    Private Sub mnuRelaResp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelaResp.Click
        Dim newfrmRelaResp As New frmRelaResp()
        newfrmRelaResp.Show()
    End Sub

    Private Sub mnuIntCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIntCosto.Click
        Dim newfrmIntCosto As New frmIntCosto()
        newfrmIntCosto.Show()
    End Sub

    Private Sub mnuCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCosto.Click
        Dim newfrmCosto As New frmCosto()
        newfrmCosto.Show()
    End Sub

    Private Sub mnuCierreCo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCierreCo.Click
        Dim newfrmCierreCo As New frmCierreCo()
        newfrmCierreCo.Show()
    End Sub

    Private Sub mnuTermimes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim newfrmTermimes As New  ()
        'newfrmTermimes.Show()
    End Sub

    Private Sub mnuImprePol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImprePol.Click
        Dim newfrmImprePol As New frmImprePol()
        newfrmImprePol.Show()
    End Sub

    Private Sub mnuConcAjus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim newfrmConcAjus As New frmConcAjus()
        'newfrmConcAjus.Show()
    End Sub

    Private Sub mnuGenCatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGenCatal.Click
        GenCatal()
        MsgBox("Catálogo de Cuentas creado", MsgBoxStyle.Information, "Mensaje")
    End Sub

    Private Sub mnuSubirCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'SubirCE()
        'MsgBox("Catálogo de Cuentas subido al sistema", MsgBoxStyle.Information, "Mensaje")
    End Sub

    Private Sub mnuRepoActi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim newfrmRepoActi As New frmRepoActi()
        'newfrmRepoActi.Show()
    End Sub

    Private Sub mnuPrepames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim newfrmPrepames As New frmPrepames()
        'newfrmPrepames.Show()
    End Sub

    Private Sub mnuRepDiezP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRepDiezP.Click
        Dim newfrmRepDiezP As New frmRepDiezp()
        newfrmRepDiezP.Show()
    End Sub

    Private Sub mnuRepAnti2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim newfrmRepAnti2 As New frmRepAnti2()
        'newfrmRepAnti2.Show()
    End Sub

    Private Sub mnuRepInter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim newfrmRepInter As New frmRepInter()
        'newfrmRepInter.Show()
    End Sub

    Private Sub mnuIntIvaPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIntIvaPP.Click
        'Dim newfrmIntIvaPP As New frmIntIvaPP()
        Dim newfrmIntIvaPP As New FrmIVApagar()
        newfrmIntIvaPP.Show()
    End Sub

    Private Sub mnuReproInt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim newfrmReproInt As New frmReproint()
        'newfrmReproInt.Show()
    End Sub

    Private Sub mnuRepMenBancos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim newfrmRepMenBancos As New frmRepMenBancos()
        'newfrmRepMenBancos.Show()
    End Sub

    Private Sub mnuRTPorAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRTPorAnexo.Click
        Dim newfrmPideContrato As New frmPideContrato("mnuRegenera")
        newfrmPideContrato.Show()
    End Sub

    Private Sub mnuMorales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMorales.Click
        Dim newfrmMorales As New frmMorales
        newfrmMorales.Show()
    End Sub

    Private Sub mnuFisicas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFisicas.Click
        Dim newfrmFisicas As New frmFisicas()
        newfrmFisicas.Show()
    End Sub

    Private Sub mnuCostoIng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCostoIng.Click
        Dim newfrmCostoIng As New frmCostoIng()
        newfrmCostoIng.Show()
    End Sub

    Private Sub mnuPortacar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPortacar.Click
        Dim newfrmPortacar As New frmPortacar()
        newfrmPortacar.Show()
    End Sub

    Private Sub mnuCAPorAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCAPorAnexo.Click
        Dim newfrmPideContrato As New frmPideContrato("mnuCapitalizacion")
        newfrmPideContrato.Show()
    End Sub

    Private Sub mnuCartas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCartas.Click
        Dim newfrmCartas As New frmCartas()
        newfrmCartas.Show()
    End Sub

    Private Sub mnuReimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReimprimir.Click
        Dim newfrmCambioFact As New frmCambioFact()
        newfrmCambioFact.Show()
    End Sub

    Private Sub mnuDCPorAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDCPorAnexo.Click
        Dim newfrmPideContrato As New frmPideContrato("mnuDatosCon")
        newfrmPideContrato.Show()
    End Sub

    Private Sub mnuDCPorNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDCPorNombre.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuDatosCon")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuFacSaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFacSaldo.Click
        Dim newfrmFacSaldo As New frmFacSaldo()
        newfrmFacSaldo.Show()
    End Sub

    Private Sub mnuCFPorAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCFPorAnexo.Click
        Dim newfrmPideContrato As New frmPideContrato("mnuCalcfini")
        newfrmPideContrato.Show()
    End Sub

    Private Sub mnuCFPorNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCFPorNombre.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuCalcfini")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuDRPorFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDRPorFecha.Click
        Dim newfrmConsRef As New frmConsRef("F")
        newfrmConsRef.Show()
    End Sub

    Private Sub mnuDRPorCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDRPorCliente.Click
        Dim newfrmConsRef As New frmConsRef("C")
        newfrmConsRef.Show()
    End Sub

    Private Sub mnuConsAviso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsAviso.Click
        Dim newfrmConsultaAviso As New frmConsultaAviso()
        newfrmConsultaAviso.Show()
    End Sub

    Private Sub mnuRepSalCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRepSalCli.Click
        Dim newfrmRepSalCli As New frmRepSalCli()
        newfrmRepSalCli.Show()
    End Sub

    Private Sub mnuRepSaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim newfrmRepSaldo As New frmRepSaldo()
        newfrmRepSaldo.Show()
    End Sub

    Private Sub mnuRepoProm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRepoProm.Click
        Dim newfrmRepoProm As New frmRepoProm()
        newfrmRepoProm.Show()
    End Sub

    Private Sub mnuRepAntig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRepAntig.Click
        Dim newfrmRepAntig As New frmRepAntig()
        newfrmRepAntig.Show()
    End Sub

    Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
        End
    End Sub

    Private Sub mnuRepSald2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRepSald2.Click
        Dim newfrmRepSald2 As New frmRepSald2()
        newfrmRepSald2.Show()
    End Sub

    Private Sub mnuRepoSegu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRepoSegu.Click
        Dim newfrmRepoSegu As New frmRepoSegu()
        newfrmRepoSegu.Show()
    End Sub

    Private Sub mnuRepoValo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim newfrmRepoValo As New frmRepoValo()
        newfrmRepoValo.Show()
    End Sub

    Private Sub mnuCRPorAnexo_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCRPorAnexo.Click
        Dim newfrmPideContrato As New frmPideContrato("mnuCartaRat")
        newfrmPideContrato.Show()
    End Sub

    Private Sub mnuCRPorNombre_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCRPorNombre.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuCartaRat")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuCCartera_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCCartera.Click
        Dim newfrmCalifica As New frmCalifica()
        newfrmCalifica.Show()
    End Sub

    Private Sub mnuDepoRefe_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDepoRefe.Click
        Dim newfrmDepoRefe As New frmDepoRefe()
        newfrmDepoRefe.Show()
    End Sub

    Private Sub mnuFega_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFega.Click
        Dim newfrmFega As New frmFega()
        newfrmFega.Show()
    End Sub

    Private Sub mnuRCporAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRCporAnexo.Click
        Dim newfrmPideContrato As New frmPideContrato("mnuReestructuras")
        newfrmPideContrato.Show()
    End Sub

    Private Sub mnuRCporNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRCporNombre.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuReestructuras")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuAplicaDR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAplicaDR.Click
        Dim newfrmAplicaDR As New frmAplicaDR()
        newfrmAplicaDR.Show()
    End Sub

    Private Sub mnuAltaContratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAltaContratos.Click
        Dim newfrmAltaContratos As New frmAltaContratos
        newfrmAltaContratos.Show()
    End Sub

    Private Sub mnuMinistracionFFP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMinistracionFFP.Click
        Dim newfrmMinistraciones As New frmMinistraciones()
        newfrmMinistraciones.Show()
    End Sub

    Private Sub mnuMinistracionFP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMinistracionFP.Click
        Dim newfrmMinistracionFP As New frmMinistracionFP()
        newfrmMinistracionFP.Show()
    End Sub

    Private Sub mnuECPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuECPP.Click
        'If LCase(USUARIOX) = "atrejo" Or LCase(USUARIOX) = "gisvazquez" Or UCase(USUARIOX) = "RALCANTARA" _
        'Or UCase(USUARIOX) = "LMERCADO" Or UCase(USUARIOX) = "KVICTORIANO" Or UCase(USUARIOX) = "EPINEDA" _
        'Or UCase(USUARIOX) = "ACAMACHO" Or UCase(USUARIOX) = "VCRUZ" Or UCase(USUARIOX) = "CRIVERA" _
        'Or UCase(USUARIOX) = "JJAVIER" Or UCase(USUARIOX) = "YHERNANDEZ" Or UCase(USUARIOX) = "LHERNANDEZ" _
        'Or LCase(USUARIOX) = "brivera" Or LCase(USUARIOX) = "cjuarez" Or LCase(USUARIOX) = "tcortez" _
        'Or UCase(USUARIOX) = Nothing Then
        Dim newfrmPideProductor As New frmPideProductor("mnuECPP")
        newfrmPideProductor.Show()
        'End If
    End Sub

    Private Sub mnuECPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub mnuECTC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuECTC.Click
        Dim newfrmECTC As New frmECTC()
        newfrmECTC.Show()
    End Sub

    Private Sub mnuPagosPF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPagosPF.Click
        Dim f As New FrmSelec
        f.Origen = "PagoAvio"
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Cursor.Current = Cursors.WaitCursor
            If Mid(f.Destino, 1, 4) = UCase("PAGO") Then
                Dim newfrmAplicacion As New frmAplicacion()
                newfrmAplicacion.Show()
            Else
                Dim newfrmAplicacion As New frmAplicacionNC()
                newfrmAplicacion.Show()
            End If
            Cursor.Current = Cursors.Default
        End If
        f.Dispose()
    End Sub

    Private Sub mnuRCS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRCS.Click
        Dim newfrmSustrae As New frmSustrae()
        newfrmSustrae.Show()
    End Sub

    Private Sub mnuRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRE.Click
        Dim newfrmRE As New frmRE()
        newfrmRE.Show()
    End Sub

    Private Sub mnuModCtoAvioPorProductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModCtoAvioPorProductor.Click
        Dim newfrmPideProductor As New frmPideProductor("mnuModCtoAvioPorProductor")
        newfrmPideProductor.Show()
    End Sub

    Private Sub mnuModCtoAvioPorContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModCtoAvioPorContrato.Click
        'Dim newfrmPideContrato As New frmPideContrato("mnuModCtoAvioPorContrato")
        'newfrmPideContrato.Show()
    End Sub

    Private Sub mnuMinistracionesPorProductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMinistracionesPorProductor.Click
        Dim newfrmPideProductor As New frmPideProductor("mnuPorProductor")
        newfrmPideProductor.Show()
    End Sub

    Private Sub mnuMinistracionesPorContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMinistracionesPorContrato.Click
        'Dim newfrmPideContrato As New frmPideContrato("mnuMinistracionesPorContrato")
        'newfrmPideContrato.Show()
    End Sub

    Private Sub mnuPagaresPorProductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPagaresPorProductor.Click
        Dim newfrmPideProductor As New frmPideProductor("mnuPagaresPorProductor")
        newfrmPideProductor.Show()
    End Sub

    Private Sub mnuPagaresPorContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPagaresPorContrato.Click
        'Dim newfrmPideContrato As New frmPideContrato("mnuPagaresPorContrato")
        'newfrmPideContrato.Show()
    End Sub

    Private Sub mnuCapturaPMIPorProductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCapturaPMIPorProductor.Click
        Dim newfrmPideProductor As New frmPideProductor("mnuCapturaPMIPorProductor")
        newfrmPideProductor.Show()
    End Sub

    Private Sub mnuCapturaPMIPorContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCapturaPMIPorContrato.Click
        'Dim newfrmPideContrato As New frmPideContrato("mnuCapturaPMIPorContrato")
        'newfrmPideContrato.Show()
    End Sub

    Private Sub mnuImpCtoAvioPorProductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImpCtoAvioPorProductor.Click
        Dim newfrmPideProductor As New frmPideProductor("mnuImpCtoAvioPorProductor")
        newfrmPideProductor.Show()
    End Sub

    Private Sub mnuImpCtoAvioPorContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImpCtoAvioPorContrato.Click
        'Dim newfrmPideContrato As New frmPideContrato("mnuImpCtoAvioPorContrato")
        'newfrmPideContrato.Show()
    End Sub

    Private Sub mnuCheckList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCheckList.Click
        'Dim newfrmPideAnexo As New frmPideAnexo("mnuCheckList")
        'newfrmPideAnexo.Show()
        Dim newfrmPideCliente As New frmPideCliente("mnuCheckList")
        newfrmPideCliente.Show()
    End Sub

    Private Sub mnuConsultaCL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultaCL.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuConsultaCL")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuReportecl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportecl.Click
        Dim newfrmRepCL As New frmReporteCheckList()
        newfrmRepCL.Show()
    End Sub

    Private Sub mnuLayOutAvio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuLayOutAvio.Click
        Dim newfrmLayOutAvio As New frmLayOut2017()
        newfrmLayOutAvio.Show()
    End Sub

    Private Sub mnuBuscarSerie_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBuscarSerie.Click
        Dim newfrmBuscarSerie As New frmBuscaSerie()
        newfrmBuscarSerie.Show()
    End Sub

    Private Sub mnuTasasApl_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTasasApl.Click
        Dim newfrmTasasApl As New frmConsTasasvig()
        newfrmTasasApl.Show()
    End Sub

    Private Sub mnuRegTasas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRegTasas.Click
        Dim newfrmAltaTasasvig As New frmALtaTasasvig()
        newfrmAltaTasasvig.Show()
    End Sub

    Private Sub mnuActVigencia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuActVigencia.Click
        VigenciaTasas()
        MsgBox("La Vigencia de las Tasas Aplicables se ha actualizado", MsgBoxStyle.Information, "Mensaje")
    End Sub

    Private Sub mnuDocBlanco_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDocBlanco.Click
        Dim newfrmImpBlanco As New frmImpBlanco()
        newfrmImpBlanco.Show()
    End Sub

    Private Sub mnuMemoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMemoria.Click
        Dim newfrmMemoria As New frmMemoria()
        newfrmMemoria.Show()
    End Sub

    Private Sub mnuExpDigital_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExpDigital.Click
        Shell("explorer.exe root = O:\", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub mnuGFE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGFE.Click
        'Dim newfrmGFE As New frmGFE()
        'newfrmGFE.Show()
    End Sub

    Private Sub mnuEFE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEFE.Click
        Dim newfrmEFE As New frmEFE
        newfrmEFE.Show()
    End Sub

    Private Sub mnuAltacta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAltacta.Click
        'Dim newfrmPideAnexo As New frmPideAnexo("mnuAltacta")
        'newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuGLDomic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGLDomic.Click
        Dim newfrmDomiciliacion As New frmDomiciliacion()
        newfrmDomiciliacion.Show()
    End Sub

    Private Sub MnuCondusef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCondusef.Click
        Dim FrmCodusef As New FrmEdoCtaCodusef
        FrmCodusef.Show()
    End Sub

    Private Sub MnuAltaPolAvi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAltaPolAvi.Click
        Dim FrmAltaPolAvi As New FrmAltaPolizaAvio
        FrmAltaPolAvi.USUARIOX = USUARIOX
        FrmAltaPolAvi.Show()
    End Sub

    Private Sub MnuParametrosAvio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuParametrosAvio.Click
        Dim f As New FrmParametros
        f.Show()
    End Sub

    Private Sub MnuSolAvio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSolAvio.Click
        Dim f As New FrmSolicitudesAVI
        f.Usuario = USUARIOX
        f.Show()
    End Sub

    Private Sub MnuConsumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuConsumo.Click
        Dim f As New FrmCALconsumo
        f.Show()
    End Sub

    Private Sub MnuComercial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuComercial.Click
        Dim f As New FrmCALComercial
        f.Show()
    End Sub

    Private Sub mnuProxVen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProxVen.Click
        Dim newfrmRepAvisosxv As New frmRepAvisosxv()
        newfrmRepAvisosxv.Show()
    End Sub

    Private Sub MnuGastosEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuGastosEXT.Click
        Dim f As New FrmGastosExtra
        f.Show()
    End Sub

    Private Sub MnuFondoRestit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFondoRestit.Click
        Dim f As New FrmRestiFondo
        f.Show()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAplicaFR.Click
        Dim f As New frmAplicaFR
        f.Show()
    End Sub

    Private Sub MnuSaoldosPuros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSaldosPuros.Click
        Dim f As New frmRepSaldoPuro
        f.Show()
    End Sub

    Private Sub MnuFondoRPT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFondoRPT.Click
        Dim f As New FrmReporteFR
        f.Show()
    End Sub


    Private Sub MnuValPersonas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuValPersonas.Click
        Dim f As New FrmValPersonas
        f.Show()
    End Sub

    Private Sub MnuSegFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSegFin.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuSegumanu")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub MnuBitactoraProm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuBitactoraProm.Click
        Dim f As New FrmRptBitacoraProm
        f.Show()
    End Sub

    Private Sub MnuClavesOBS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuClavesOBS.Click
        Dim f As New FrmCveObs
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Date.Now.Second = 0 Or Date.Now.Second = 30 Then
            'Call Pendientes()
        End If
        Dim inactiveTime = GetInactiveTime()
        If (inactiveTime Is Nothing) Then
            Me.Text = "Desconocido"
            'Me.BackColor = Color.Yellow
        ElseIf (inactiveTime.Totalminutes > 15) And UsuarioGlobal.ToUpper <> "EPINEDA" Then
            'Me.Text = String.Format("Inactivo por {0}segundos", inactiveTime.TotalSeconds)
            'Me.BackColor = Color.Red
            Application.Exit()
        Else
            'Me.Text = "Aplicacion Activa"
            'Me.BackColor = Color.Green
        End If

    End Sub




    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim f As New FrmGruposRiesgo
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub


    Private Sub MnuAddPAg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAddPAg.Click
        Dim f As New FrmAgregarPagare
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Private Sub MnuIRcomun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuIRcomun.Click
        Dim f As New FrmGruposRiesgoComun
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Private Sub MnuClientesGrupos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuClientesGrupos.Click
        Dim newfrmPideAnexo As New frmPideCliente("mnuGrupos")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub MnuReestruct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuReestruct.Click
        Dim f As New FrmMarcaReestruct
        f.Show()
    End Sub

    Private Sub MnuConvenioJur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuConvenioJur.Click
        Dim f As New FrmConvenioJUR
        f.Show()
    End Sub

    Private Sub MnuSEG1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSEG1.Click
        Dim newfrmPideAnexo As New FrmPolLoc1
        newfrmPideAnexo.Show()
    End Sub

    Private Sub MnuSEG2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSEG2.Click
        Dim newfrmPideAnexo As New FrmPolLoc2
        newfrmPideAnexo.Show()
    End Sub

    Private Sub MnuSEG3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSEG3.Click
        Dim newfrmPideAnexo As New FrmPolLoc3
        newfrmPideAnexo.Show()
    End Sub

    Private Sub MnuSEG4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSEG4.Click
        Dim newfrmPideAnexo As New FrmPolLoc4
        newfrmPideAnexo.Show()
    End Sub

    Private Sub MnuSEG5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSEG5.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuSiniestros")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub MnuSoliCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSoliCC.Click
        Dim f As New FrmSolicitudesCC
        f.Show()
    End Sub

    Private Sub mnuOperIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOperIR.Click
        Dim newfrmRelevantes As New frmRelevantes
        newfrmRelevantes.Show()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim newfrmRepAntig As New frmRepAntigHIST()
        newfrmRepAntig.Show()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim f As New FrmAmpliacionAnticipo
        f.Show()
    End Sub

    Private Sub MnuDesbloqTasa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuDesbloqTasa.Click
        Dim f As New FrmBloqueoTasas
        f.Show()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim newfrmRepoValo As New frmRepoValo()
        newfrmRepoValo.Show()
    End Sub

    Private Sub MenuIGenPASS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuIGenPASS.Click
        Dim f As New FrmGenPass
        f.Show()
    End Sub

    Private Sub mnuCTradicional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCTradicional.Click
        Dim newfrmPideAnexo As New frmPideAnexo("mnuCTradicional")
        newfrmPideAnexo.Show()
    End Sub

    Private Sub mnuCAvio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim newfrmPideProductor As New frmPideProductor("mnuCAvio")
        newfrmPideProductor.Show()
    End Sub

    Private Sub MnuCCXvencer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCCXvencer.Click
        Dim f As New FrmRptGnerico
        f.ReporteNom = "CCporVencer"
        f.Show()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim f As New FrmValidaHojaTasa
        f.Show()
    End Sub

    Private Sub MnuTablaESP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuTablaESP.Click
        Dim f As New FrmTablasESP
        f.Show()
    End Sub

    Private Sub MnuCancelaMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCancelaMov.Click
        Dim f As New FrmCancelaMov
        f.Show()
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        Dim f As New FrmRPTTrimestre
        f.Show()
    End Sub

    Private Sub MnuFechaApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFechaApp.Click
        Dim F As New FrmFechasAplicacion
        If F.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        Me.Text = "FINAGIL, S.A. de C.V. SOFOM, E.N.R.                   (Fecha de Aplicacion de Pagos: " & FECHA_APLICACION.ToShortDateString & ")                  Usuario: " & UsuarioGlobal & "          DB: " & My.Settings.BaseDatos
    End Sub

    Private Sub MnuFactorPol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFactorPol.Click
        Dim f As New FrmSegFactoraje
        f.Show()
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MnuFechasSuper.Click
        Dim f As New FrmFechasSupervision
        f.Show()
    End Sub

    Private Sub MenuItem12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Dim f As New FrmDocOnbase
        f.Show()
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCargosEXTRAS.Click
        Dim f As New frmCargosExtras
        f.Show()
    End Sub

    Private Sub MenuItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Dim f As New frmRepoSeguros
        f.Show()
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Dim f As New FrmRptGnerico
        f.ReporteNom = "AVporVencer"
        f.Show()
    End Sub

    Private Sub MnuBitaJur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuBitaJur.Click
        Dim f As New frmJURBitacora
        f.Show()
    End Sub

    Private Sub MnuBitaJurConsul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuBitaJurConsul.Click
        Dim f As New FrmDatosBitacora
        f.Show()
    End Sub

    Private Sub MenuItem15_Click(sender As Object, e As EventArgs) Handles MnuMcBitacora.Click
        Dim f As New frm_solicitudes
        f.Show()
    End Sub

    Private Sub MenuItem15_Click_1(sender As Object, e As EventArgs)
        Dim f As New frmbitacora_anexos
        f.Show()
    End Sub

    Private Sub MenuItem15_Click_2(sender As Object, e As EventArgs) Handles MnuRepCobDia.Click
        Dim newfrmRepCobra As New frmRepcobra()
        newfrmRepCobra.Show()
    End Sub

    Private Sub MenuItem15_Click_3(sender As Object, e As EventArgs) Handles MenuItem15.Click
        Dim newfrmSegBitacora As New frmSegBitacora()
        newfrmSegBitacora.Show()
    End Sub

    Private Sub MnuBuroNom_Click(sender As Object, e As EventArgs) Handles MnuBuroNom.Click
        Dim CN As New SqlConnection(Agil.My.Settings.ProductionConnectionString)
        Call LlenaNombres(CN)
    End Sub

    Private Sub MenuItem17_Click(sender As Object, e As EventArgs) Handles MnuPLdAuto.Click
        Dim f As New FrmBloqPLD
        f.Show()
    End Sub

    Private Sub MnuPortaCont_Click(sender As Object, e As EventArgs) Handles MnuPortaCont.Click
        Dim f As New frmPortaCon
        f.Show()
    End Sub

    Private Sub MnuLiberMC_Click(sender As Object, e As EventArgs) Handles MnuLiberMC.Click
        Dim f As New frmAutorizaTRA_MC("")
        f.Show()
    End Sub

    Private Sub MnuFechaPago_Click(sender As Object, e As EventArgs) Handles MnuFechaPago.Click
        Dim f As New FrmFechaPago
        f.Show()
    End Sub

    Private Sub MnuLiberAvio_Click(sender As Object, e As EventArgs) Handles MnuLiberAvio.Click
        Dim f As New FrmAutoroizaAV
        f.Show()
    End Sub

    Private Sub MnuAutoAviCRE_Click(sender As Object, e As EventArgs) Handles MnuAutoAviCRE.Click
        Dim f As New FrmAutoroizaAV_FIRA
        f.Show()
    End Sub

    Private Sub MenuItem16_Click(sender As Object, e As EventArgs) Handles MnuPagosAvio.Click
        Dim f As New FrmSubePagosAV
        f.Show()
    End Sub

    Private Sub MniBloqAvisos_Click(sender As Object, e As EventArgs) Handles MniBloqAvisos.Click
        Dim f As New FrmBloqueAvisos
        f.Show()
    End Sub

    Private Sub MenuItem16_Click_1(sender As Object, e As EventArgs) Handles MenuItem16.Click
        Dim f As New FrmCorreosAdicionales
        f.Show()
    End Sub

    Private Sub MenuItem17_Click_1(sender As Object, e As EventArgs) Handles MenuItem17.Click
        Dim f As New FrmPromotores
        f.Show()
    End Sub

    Private Sub MenuItem18_Click(sender As Object, e As EventArgs) Handles MenuItem18.Click
        Dim f As New frm_rpt_consejo
        f.Show()
    End Sub

    Private Sub MenuItem19_Click(sender As Object, e As EventArgs) Handles MenuItem19.Click
        Dim f As New FrmCastigoGaratia
        f.Show()
    End Sub

    Private Sub MenuItem20_Click(sender As Object, e As EventArgs) Handles MenuItem20.Click
        Dim newfrmPideContrato As New frmPideContrato("mnuCargaGPS")
        newfrmPideContrato.Show()
    End Sub

    Private Sub MnuCarteVecnMonitor_Click(sender As Object, e As EventArgs) Handles MnuCarteVecnMonitor.Click
        Dim f As New FrmCarteraVencidaMonitor
        f.Show()
    End Sub

    Private Sub MenuTipoCambio_Click(sender As Object, e As EventArgs) Handles MenuTipoCambio.Click
        Dim f As New FrmTiposCambio
        f.Show()
    End Sub

    Private Sub MenuItem9_Click_1(sender As Object, e As EventArgs) Handles MenuItem9.Click
        Dim f As New FrmRptCarteraVEN
        f.ESTATUS = "Vencida"
        f.Show()
    End Sub

    Private Sub MenuItem22_Click(sender As Object, e As EventArgs) Handles MenuItem22.Click
        Dim f As New FrmRptCarteraVEN
        f.ESTATUS = "Global"
        f.Show()
    End Sub

    Private Sub MenuItem8_Click_1(sender As Object, e As EventArgs) Handles MenuItem8.Click
        Dim f As New FrmRptCartera
        f.Show()
    End Sub

    Private Sub MnuModReest_Click(sender As Object, e As EventArgs) Handles MnuModReest.Click
        Cursor.Current = Cursors.WaitCursor
        Dim f As New FrmMOD_Reestructuras
        f.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MnuActiDomi_Click(sender As Object, e As EventArgs) Handles MnuActiDomi.Click
        Dim f As New FrmActiVaDomi
        f.Show()
    End Sub

    Private Sub MenuItem23_Click(sender As Object, e As EventArgs) Handles MenuItem23.Click
        Dim f As New FrmRptCarteraVEN
        f.ESTATUS = "Reestructurada"
        f.Show()
    End Sub

    Private Sub MnuLinCred_Click(sender As Object, e As EventArgs) Handles MnuLinCred.Click
        Dim f As New FrmLineasCredito
        f.Show()
    End Sub

    Private Sub MenuItem25_Click(sender As Object, e As EventArgs) Handles MenuItem25.Click
        Dim f As New FrmCodigoSAT
        f.Show()
    End Sub

    Private Sub MenuItem26_Click(sender As Object, e As EventArgs) Handles MenuItem26.Click
        Dim f As New FrmCodigoSATConcepto
        f.Show()
    End Sub

    Private Sub MenuItem27_Click(sender As Object, e As EventArgs) Handles MenuItem27.Click
        Dim f As New FrmAutoroizaAV_CRED
        f.Show()
    End Sub

    Private Sub MenuItem28_Click(sender As Object, e As EventArgs) Handles MenuItem28.Click
        Dim f As New FrmUsoCFDI
        f.Show()
    End Sub

    Private Sub MenuItem29_Click(sender As Object, e As EventArgs) Handles MenuItem29.Click
        Dim f As New FrmCFDIConcepActiFij
        f.Show()
    End Sub

    Private Sub MenuItem32_Click(sender As Object, e As EventArgs) Handles MenuItem32.Click
        Dim f As New frmcontrato_juridico
        f.Show()
    End Sub

    Private Sub MenuSegCred_Click(sender As Object, e As EventArgs) Handles MenuSegCred.Click
        Dim f As New FrmSeguimientoCRED
        f.Show()
    End Sub

    Private Sub MenuItem33_Click(sender As Object, e As EventArgs) Handles MenuItem33.Click
        Dim procID As Integer
        Dim newProc As Diagnostics.Process
        newProc = Diagnostics.Process.Start("iexplore.exe", "http://finagil.com.mx/weBtasas/10279124EA2D4A47A4CC.aspx")
        procID = newProc.Id
        Dim procEC As Integer = -1
        If newProc.HasExited Then
            procEC = newProc.ExitCode
        End If
        newProc.Close()
        newProc.Dispose()
    End Sub

    Private Sub MenuItem31_Click(sender As Object, e As EventArgs) Handles MenuItem31.Click
        Dim f As New FrmSeguimientoCRED
        f.Show()
    End Sub

    Private Sub MenuItem30_Click(sender As Object, e As EventArgs) Handles MenuItem30.Click
        Dim f As New FrmRetrasosJustifi
        f.Show()
    End Sub

    Private Sub MenuItem34_Click(sender As Object, e As EventArgs) Handles MenuItem34.Click
        Dim f As New FrmHistorialCRED_MC
        f.Show()
    End Sub

    Private Sub MenuItem36_Click(sender As Object, e As EventArgs) Handles MenuItem36.Click
        Dim f As New frmRelDocOrig
        Cursor.Current = Cursors.WaitCursor
        f.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem35_Click(sender As Object, e As EventArgs)
        Dim f As New frmRelDocOrig
        Cursor.Current = Cursors.WaitCursor
        f.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem35_Click_1(sender As Object, e As EventArgs) Handles MenuItem35.Click
        'Dim newfrmPideAnexo As New frmPideAnexo("mnuCaptSegu") '#ect OLD
        Dim newfrmPideAnexo As New FrmPolLoc
        newfrmPideAnexo.Show()
    End Sub

    Private Sub MenuItem37_Click(sender As Object, e As EventArgs) Handles MenuItem37.Click
        Dim f As New frmSupFIRA
        Cursor.Current = Cursors.WaitCursor
        f.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuRep_Click(sender As Object, e As EventArgs) Handles mnuRep.Click

    End Sub

    Private Sub MenuItem38_Click(sender As Object, e As EventArgs) Handles MenuItem38.Click
        Dim f As New frmPagoAnticipos
        Cursor.Current = Cursors.WaitCursor
        f.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem39_Click(sender As Object, e As EventArgs) Handles MenuItem39.Click
        Dim procID As Integer
        Dim newProc As Diagnostics.Process
        newProc = Diagnostics.Process.Start("iexplore.exe", "http://finagil.com.mx/webtasas/23EdbC95T-stat.aspx")
        procID = newProc.Id
        Dim procEC As Integer = -1
        If newProc.HasExited Then
            procEC = newProc.ExitCode
        End If
        newProc.Close()
        newProc.Dispose()
    End Sub
End Class
