Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports Microsoft.VisualBasic.Financial
Imports System.IO
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop
Imports System.Security.Principal.WindowsIdentity
Imports System.Security

' Esta forma recibe como parámetro el número de contrato y lo primero que tiene
' que revisar es el estatus del contrato

Public Class frmActiAnexCS

    Inherits System.Windows.Forms.Form

    ' Declaración de variables de alcance privado
    Dim nTasaIvaCliente As Decimal
    Dim cAbcapt As String
    Dim cAval As String = ""
    Dim cAval1 As String = ""
    Dim cAnexo As String
    Dim cAval2 As String = ""
    Dim cAval3 As String = ""
    Dim cAval4 As String = ""
    Dim cAvales As String = ""
    Dim cAvalg1 As String = ""
    Dim cAvalg2 As String = ""
    Dim cAvalg3 As String = ""
    Dim cAvalg4 As String = ""
    Dim cBienes As String = ""
    Dim cBienes2 As String = ""
    Dim cCalle As String
    Dim cCliente As String = ""
    Dim cCoac As String = ""
    Dim cCoacp As String = ""
    Dim cCoac2 As String = ""
    Dim cColonia As String
    Dim cCopos As String
    Dim cContrato As String = ""
    Dim cCusnam As String = ""
    Dim cDato10 As String = ""
    Dim cDato7 As String = ""
    Dim cDato8 As String = ""
    Dim cDato9 As String = ""
    Dim cDelegacion As String
    Dim cDescDepGar As String = ""
    Dim cDescFrecuencia As String = ""
    Dim cDescPI As String = ""
    Dim cDescPrenda As String = ""
    Dim cDescPromotor As String = ""
    Dim cDescr As String = ""
    Dim cDescRecurso As String = ""
    Dim cDescTasa As String = ""
    Dim cDescTipta As String = ""
    Dim cDetalle As String = ""
    Dim cDiaPago As String = ""
    Dim cEncabezado As String = ""
    Dim cEstado As String
    Dim cFactura As String = ""
    Dim cFax As String = ""
    Dim cFeaut As String = ""
    Dim cFechacon As String = ""
    Dim cFecre As String = ""
    Dim cFevent As String
    Dim cFevig As String = ""
    Dim cFirmaAval1 As String = ""
    Dim cFirmaAval2 As String = ""
    Dim cFirmaAval3 As String = ""
    Dim cFirmaAval4 As String = ""
    Dim cFirmaTestigo1 As String = ""
    Dim cFirmaTestigo2 As String = ""
    Dim cFirmaCte As String = ""
    Dim cFlcan As String = ""
    Dim cFondeo As String
    Dim cForca As String = ""
    Dim cFvenc As String = ""
    Dim cGeneAva1 As String = ""
    Dim cGeneAva2 As String = ""
    Dim cGeneClie As String
    Dim cGenecoac As String = ""
    Dim cGeneObli As String = ""
    Dim cGenerav1 As String = ""
    Dim cGenerav2 As String = ""
    Dim cGenercoa As String = ""
    Dim cGenerep2 As String
    Dim cGenerepr As String
    Dim cGenerObl As String = ""
    Dim cImporte As String
    Dim cImpPI As String = ""
    Dim cImpProv As String = ""
    Dim cIntert As String
    Dim cIvaCapt As String
    Dim cIvat As String
    Dim cLetra As String = ""
    Dim cLetrat As String
    Dim cLugar As String = ""
    Dim cModelo As String = ""
    Dim cMotor As String = ""
    Dim cNomAval1 As String = ""
    Dim cNomAval2 As String = ""
    Dim cNomcoac As String = ""
    Dim cNomObli As String = ""
    Dim cNomrava1 As String = ""
    Dim cNomrava2 As String = ""
    Dim cNomrcoac As String = ""
    Dim cNomrObli As String = ""
    Dim cNotario As String = ""
    Dim cObi As String = ""
    Dim cObSol As String = ""
    Dim cObSol1 As String = ""
    Dim cPagomen As String = ""
    Dim cBonifica As String = ""
    Dim cPersonaAut As String = ""
    Dim cPodercoa As String = ""
    Dim cPoderep2 As String
    Dim cPoderepr As String
    Dim cPoderObl As String = ""
    Dim cPrenda As String = ""
    Dim cGHipotec As String = ""
    Dim cProducto As String = ""
    Dim cPromo As String = ""
    Dim cReca As String = "N/A"
    Dim cProveedor As String = ""
    Dim cProveedos As String = ""
    Dim cRefCliente As String = ""
    Dim cRefProdgral As String = ""
    Dim cRefProducto As String = ""
    Dim cRenta As String
    Dim cRentap As String
    Dim cRepresentante As String = ""
    Dim cRepresentante2 As String = ""
    Dim cRfc As String
    Dim cSaldot As String
    Dim cSerie As String = ""
    Dim cSucursal As String
    Dim cTelefono As String = ""
    Dim cTitulo1 As String = ""
    Dim cTermino As String = ""
    Dim cTexto As String = ""
    Dim cTipar As String = ""
    Dim cTipAval1 As String = ""
    Dim cTipAval2 As String = ""
    Dim cTipcoac As String = ""
    Dim cTipo As String = ""
    Dim cTipoObli As String = ""
    Dim cTippe As String = ""
    Dim cTipta As String
    Dim cUnidadEsp As String = ""
    Dim cVence As String = ""
    Dim cFecha1 As String
    Dim cCobert As String
    Dim cTotg As String
    Dim cTotgCAP As String
    Dim cEjecu As String = ""
    Dim cParrafoInteres As String = ""
    Dim cAplicaCobertura As String = ""
    Dim cSoli As String
    Dim cSubDPromo As String = ""
    Dim cSegVida As String = ""
    Dim cPersFirman
    Dim dTermino As Date

    Dim IvaRD As Decimal
    Dim nAbono As Decimal
    Dim nAmorin As Decimal
    Dim nComis As Decimal
    Dim nIvaComis As Decimal
    Dim nDepg As Decimal
    Dim nDepNafin As Decimal
    Dim nDifer As Decimal
    Dim nFactor As Decimal
    Dim nGastos As Decimal
    Dim nImpEq As Decimal
    Dim nImporte As Decimal
    Dim nImpRD As Decimal
    Dim nInteres As Decimal
    Dim nIVA As Decimal
    Dim nRtas As Decimal
    Dim nIvaAmorin As Decimal
    Dim nIvaCapital As Decimal
    Dim nIvaDepg As Decimal
    Dim nIvaEq As Decimal
    Dim nIvaGastos As Decimal
    Dim nIvard As Decimal
    Dim nIvaRtaD As Decimal
    Dim nIvaTabla As Decimal
    Dim nLinau As Decimal
    Dim nMensu As Decimal
    Dim nMtoFin As Decimal
    Dim nNafin As Decimal
    Dim nOpcion As Decimal
    Dim nPagosi As Decimal
    Dim nPiso As Decimal
    Dim nPlazo As Integer
    Dim nPorop As Decimal
    Dim nRenta As Decimal
    Dim nRentasD As Decimal
    Dim nRta As Decimal
    Dim nSaldo As Decimal
    Dim nSaldoAct As Decimal
    Dim nSaldoRiesgo As Decimal
    Dim nTaspen As Decimal
    Dim nTasas As Decimal
    Dim nTasmor As Decimal
    Dim nTecho As Decimal
    Dim nTotal As Decimal
    Dim nTotal2 As Decimal
    Dim nDerechos As Decimal
    Dim nCAT As Decimal
    Dim nCobertura As Decimal
    Dim nDiasp As Integer
    Dim nGtotalivacap As Decimal
    Dim nGtotaliva As Decimal
    Dim nTotalCobert As Decimal
    Dim nPorco As Decimal
    Dim nPorInt As Decimal = 16.0
    Dim nServicio As Decimal
    Dim nIVAServicio As Decimal
    Dim nFondoReserva As Decimal
    Dim nRD As Decimal
    Dim nDG As Decimal
    Dim nAmortizaciones As Decimal
    Dim bLiquidez As Boolean = False
    Dim cEmpresa As String = ""
    Dim cPlanta As String = ""
    Dim nPorcoTope As Decimal = 2
    Dim nUdi As Decimal = 0
    Dim nVMUdi As Decimal = 900000.0
    Dim cAutomovil As String = ""
    Dim nSumaCap As Decimal = 0
    Dim nSumaInt As Decimal = 0
    Dim nSumaRen As Decimal = 0
    Dim nSumaBoni As Decimal = 0
    Dim nSumaPmen As Decimal = 0
    Dim nSumaGtot As Decimal = 0
    Dim nPorcFEGA As Decimal = 0
    Dim PorcReserva As Decimal = 0

    Friend WithEvents btnDomi1 As System.Windows.Forms.Button
    Friend WithEvents btnDomi As System.Windows.Forms.Button
    Dim nAmort As Integer

    Dim cUsuario As String
    Friend WithEvents TxtContMarco As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnACto As System.Windows.Forms.Button
    Friend WithEvents btnCtom As System.Windows.Forms.Button
    Friend WithEvents btnPLD As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents SolicitudesTableAdapter1 As Agil.AviosDSXTableAdapters.SolicitudesTableAdapter
    Friend WithEvents PromocionDS As Agil.PromocionDS
    Friend WithEvents PromotoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PromotoresTableAdapter As Agil.PromocionDSTableAdapters.PromotoresTableAdapter
    Dim myIdentity As Principal.WindowsIdentity
    Friend WithEvents BtnAdenda As Button
    Friend WithEvents BtnCarta As Button

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal cAnexo As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtAnexo.Text = cAnexo

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
    Friend WithEvents txtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents txtCusnam As System.Windows.Forms.TextBox
    Friend WithEvents btnContrato As System.Windows.Forms.Button
    Friend WithEvents txtPrenda As System.Windows.Forms.TextBox
    Friend WithEvents btnPagare As System.Windows.Forms.Button
    Friend WithEvents btnHoja As System.Windows.Forms.Button
    Friend WithEvents btnActivar As System.Windows.Forms.Button
    Friend WithEvents btnValida As System.Windows.Forms.Button
    Friend WithEvents cReportTitle As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAnexoA As System.Windows.Forms.Button
    Friend WithEvents btnAnexoB As System.Windows.Forms.Button
    Friend WithEvents btnAnexoC As System.Windows.Forms.Button
    Friend WithEvents btnRatif As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtAnexo = New System.Windows.Forms.TextBox()
        Me.txtCusnam = New System.Windows.Forms.TextBox()
        Me.btnContrato = New System.Windows.Forms.Button()
        Me.btnAnexoA = New System.Windows.Forms.Button()
        Me.btnPagare = New System.Windows.Forms.Button()
        Me.txtPrenda = New System.Windows.Forms.TextBox()
        Me.btnHoja = New System.Windows.Forms.Button()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.btnValida = New System.Windows.Forms.Button()
        Me.cReportTitle = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAnexoB = New System.Windows.Forms.Button()
        Me.btnAnexoC = New System.Windows.Forms.Button()
        Me.btnRatif = New System.Windows.Forms.Button()
        Me.btnDomi1 = New System.Windows.Forms.Button()
        Me.btnDomi = New System.Windows.Forms.Button()
        Me.TxtContMarco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnACto = New System.Windows.Forms.Button()
        Me.btnCtom = New System.Windows.Forms.Button()
        Me.btnPLD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PromotoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS = New Agil.PromocionDS()
        Me.SolicitudesTableAdapter1 = New Agil.AviosDSXTableAdapters.SolicitudesTableAdapter()
        Me.PromotoresTableAdapter = New Agil.PromocionDSTableAdapters.PromotoresTableAdapter()
        Me.BtnAdenda = New System.Windows.Forms.Button()
        Me.BtnCarta = New System.Windows.Forms.Button()
        CType(Me.PromotoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAnexo
        '
        Me.txtAnexo.Enabled = False
        Me.txtAnexo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnexo.Location = New System.Drawing.Point(32, 24)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.Size = New System.Drawing.Size(72, 21)
        Me.txtAnexo.TabIndex = 0
        '
        'txtCusnam
        '
        Me.txtCusnam.Enabled = False
        Me.txtCusnam.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusnam.Location = New System.Drawing.Point(120, 24)
        Me.txtCusnam.Name = "txtCusnam"
        Me.txtCusnam.Size = New System.Drawing.Size(504, 21)
        Me.txtCusnam.TabIndex = 1
        '
        'btnContrato
        '
        Me.btnContrato.Location = New System.Drawing.Point(336, 72)
        Me.btnContrato.Name = "btnContrato"
        Me.btnContrato.Size = New System.Drawing.Size(70, 32)
        Me.btnContrato.TabIndex = 2
        Me.btnContrato.Text = "Contrato "
        '
        'btnAnexoA
        '
        Me.btnAnexoA.Location = New System.Drawing.Point(412, 72)
        Me.btnAnexoA.Name = "btnAnexoA"
        Me.btnAnexoA.Size = New System.Drawing.Size(70, 32)
        Me.btnAnexoA.TabIndex = 3
        Me.btnAnexoA.Text = "Anexo A"
        '
        'btnPagare
        '
        Me.btnPagare.Location = New System.Drawing.Point(260, 72)
        Me.btnPagare.Name = "btnPagare"
        Me.btnPagare.Size = New System.Drawing.Size(70, 32)
        Me.btnPagare.TabIndex = 4
        Me.btnPagare.Text = "Pagaré"
        '
        'txtPrenda
        '
        Me.txtPrenda.Location = New System.Drawing.Point(672, 24)
        Me.txtPrenda.Name = "txtPrenda"
        Me.txtPrenda.Size = New System.Drawing.Size(16, 20)
        Me.txtPrenda.TabIndex = 6
        Me.txtPrenda.Visible = False
        '
        'btnHoja
        '
        Me.btnHoja.Location = New System.Drawing.Point(184, 72)
        Me.btnHoja.Name = "btnHoja"
        Me.btnHoja.Size = New System.Drawing.Size(70, 32)
        Me.btnHoja.TabIndex = 7
        Me.btnHoja.Text = "Hoja"
        '
        'btnActivar
        '
        Me.btnActivar.Location = New System.Drawing.Point(32, 72)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(70, 32)
        Me.btnActivar.TabIndex = 8
        Me.btnActivar.Text = "Activar"
        '
        'btnValida
        '
        Me.btnValida.Location = New System.Drawing.Point(108, 72)
        Me.btnValida.Name = "btnValida"
        Me.btnValida.Size = New System.Drawing.Size(70, 32)
        Me.btnValida.TabIndex = 9
        Me.btnValida.Text = "Valida"
        '
        'cReportTitle
        '
        Me.cReportTitle.Location = New System.Drawing.Point(696, 24)
        Me.cReportTitle.Name = "cReportTitle"
        Me.cReportTitle.Size = New System.Drawing.Size(16, 20)
        Me.cReportTitle.TabIndex = 11
        Me.cReportTitle.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(974, 72)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(63, 32)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        '
        'btnAnexoB
        '
        Me.btnAnexoB.Location = New System.Drawing.Point(488, 72)
        Me.btnAnexoB.Name = "btnAnexoB"
        Me.btnAnexoB.Size = New System.Drawing.Size(70, 32)
        Me.btnAnexoB.TabIndex = 13
        Me.btnAnexoB.Text = "Anexo B"
        '
        'btnAnexoC
        '
        Me.btnAnexoC.Location = New System.Drawing.Point(564, 72)
        Me.btnAnexoC.Name = "btnAnexoC"
        Me.btnAnexoC.Size = New System.Drawing.Size(70, 32)
        Me.btnAnexoC.TabIndex = 14
        Me.btnAnexoC.Text = "Anexo C"
        '
        'btnRatif
        '
        Me.btnRatif.Location = New System.Drawing.Point(640, 72)
        Me.btnRatif.Name = "btnRatif"
        Me.btnRatif.Size = New System.Drawing.Size(72, 32)
        Me.btnRatif.TabIndex = 15
        Me.btnRatif.Text = "Ratificación"
        '
        'btnDomi1
        '
        Me.btnDomi1.Location = New System.Drawing.Point(718, 72)
        Me.btnDomi1.Name = "btnDomi1"
        Me.btnDomi1.Size = New System.Drawing.Size(72, 32)
        Me.btnDomi1.TabIndex = 19
        Me.btnDomi1.Text = "Datos Domi"
        '
        'btnDomi
        '
        Me.btnDomi.Location = New System.Drawing.Point(796, 72)
        Me.btnDomi.Name = "btnDomi"
        Me.btnDomi.Size = New System.Drawing.Size(83, 32)
        Me.btnDomi.TabIndex = 20
        Me.btnDomi.Text = "Formato Dom"
        '
        'TxtContMarco
        '
        Me.TxtContMarco.Location = New System.Drawing.Point(853, 24)
        Me.TxtContMarco.Name = "TxtContMarco"
        Me.TxtContMarco.ReadOnly = True
        Me.TxtContMarco.Size = New System.Drawing.Size(130, 20)
        Me.TxtContMarco.TabIndex = 132
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(734, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "No. de Contrato Marco"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnACto
        '
        Me.btnACto.Location = New System.Drawing.Point(336, 157)
        Me.btnACto.Name = "btnACto"
        Me.btnACto.Size = New System.Drawing.Size(100, 32)
        Me.btnACto.TabIndex = 133
        Me.btnACto.Text = " Anexos Contrato. "
        Me.btnACto.Visible = False
        '
        'btnCtom
        '
        Me.btnCtom.Location = New System.Drawing.Point(336, 119)
        Me.btnCtom.Name = "btnCtom"
        Me.btnCtom.Size = New System.Drawing.Size(100, 32)
        Me.btnCtom.TabIndex = 134
        Me.btnCtom.Text = " Contrato Maestro "
        Me.btnCtom.Visible = False
        '
        'btnPLD
        '
        Me.btnPLD.Location = New System.Drawing.Point(885, 72)
        Me.btnPLD.Name = "btnPLD"
        Me.btnPLD.Size = New System.Drawing.Size(83, 32)
        Me.btnPLD.TabIndex = 135
        Me.btnPLD.Text = "Formatos PLD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Selecciona al segundo Testigo"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PromotoresBindingSource
        Me.ComboBox1.DisplayMember = "DescPromotor"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(39, 255)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(308, 21)
        Me.ComboBox1.TabIndex = 138
        Me.ComboBox1.ValueMember = "Promotor"
        '
        'PromotoresBindingSource
        '
        Me.PromotoresBindingSource.DataMember = "Promotores"
        Me.PromotoresBindingSource.DataSource = Me.PromocionDS
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SolicitudesTableAdapter1
        '
        Me.SolicitudesTableAdapter1.ClearBeforeFill = True
        '
        'PromotoresTableAdapter
        '
        Me.PromotoresTableAdapter.ClearBeforeFill = True
        '
        'BtnAdenda
        '
        Me.BtnAdenda.Location = New System.Drawing.Point(336, 195)
        Me.BtnAdenda.Name = "BtnAdenda"
        Me.BtnAdenda.Size = New System.Drawing.Size(100, 32)
        Me.BtnAdenda.TabIndex = 140
        Me.BtnAdenda.Text = "Adenda"
        '
        'BtnCarta
        '
        Me.BtnCarta.Location = New System.Drawing.Point(796, 110)
        Me.BtnCarta.Name = "BtnCarta"
        Me.BtnCarta.Size = New System.Drawing.Size(83, 41)
        Me.BtnCarta.TabIndex = 141
        Me.BtnCarta.Text = "Carta Autorización"
        '
        'frmActiAnexCS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1069, 686)
        Me.Controls.Add(Me.BtnCarta)
        Me.Controls.Add(Me.BtnAdenda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnPLD)
        Me.Controls.Add(Me.btnCtom)
        Me.Controls.Add(Me.btnACto)
        Me.Controls.Add(Me.TxtContMarco)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDomi)
        Me.Controls.Add(Me.btnDomi1)
        Me.Controls.Add(Me.btnRatif)
        Me.Controls.Add(Me.btnAnexoC)
        Me.Controls.Add(Me.btnAnexoB)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cReportTitle)
        Me.Controls.Add(Me.btnValida)
        Me.Controls.Add(Me.btnActivar)
        Me.Controls.Add(Me.btnHoja)
        Me.Controls.Add(Me.txtPrenda)
        Me.Controls.Add(Me.btnPagare)
        Me.Controls.Add(Me.btnAnexoA)
        Me.Controls.Add(Me.btnContrato)
        Me.Controls.Add(Me.txtCusnam)
        Me.Controls.Add(Me.txtAnexo)
        Me.Name = "frmActiAnexCS"
        Me.Text = "Activación de Anexos Cédito Simple"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PromotoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmActiAnex_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If BORRA_CONTRATOS() = False Then
            Me.Close()
        End If
        'TODO: This line of code loads data into the 'PromocionDS.Promotores' table. You can move, or remove it, as needed.
        Me.PromotoresTableAdapter.Fill(Me.PromocionDS.Promotores)
        PromotoresBindingSource.Filter = "Promotor <> '002' and Promotor <> '023'"
        TraeDatos()
    End Sub


    Private Sub btnActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivar.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daBienes As New SqlDataAdapter(cm1)
        Dim daPrendas As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()
        Dim strUpdate As String

        ' Declaración de variables de datos

        Dim lActivar As Boolean
        Dim lActivo As Boolean
        Dim lPrenda As Boolean
        Dim nSuma As Decimal

        cContrato = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)

        lActivar = False
        lActivo = False
        lPrenda = False

        ' Este Stored Procedure trae los datos del equipo financiado

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DatosEquipo1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cContrato
        End With

        ' Este Stored Procedure trae los datos de la garantía prendaria

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DamePrenda1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cContrato
        End With

        Try

            daBienes.Fill(dsAgil, "ActiFijo")
            daPrendas.Fill(dsAgil, "Prendas")

            nSuma = 0

            If dsAgil.Tables("ActiFijo").Rows.Count > 0 Then
                'If nImpAnexo + nIvaAnexo = nSuma Then
                '    lActivar = True
                '    lActivo = True
                'End If
            End If
            If cPrenda = "S" Then
                If dsAgil.Tables("Prendas").Rows.Count > 0 Then
                    lActivar = True
                    lPrenda = True
                End If
            Else
                lActivar = True
                lPrenda = True
            End If

            If lActivar = True Then

                ' Actualización de la tabla Anexos para marcar el contrato como Activo

                cnAgil.Open()
                strUpdate = "UPDATE Anexos SET Flcan = 'A'" & " WHERE Anexo = '" & cContrato & "'"
                cm1 = New SqlCommand(strUpdate, cnAgil)
                cm1.ExecuteNonQuery()
                cnAgil.Close()

                MsgBox("El contrato está Activado", MsgBoxStyle.Information, "Mensaje")

            Else

                ' Revisar porqué razón no se puede activar

                If lActivo = False And lPrenda = True Then

                    ' Falta capturar los datos del bien y de la garantía prendaria

                    MsgBox("Falta capturar los datos del bien y de la garantía prendaria", MsgBoxStyle.Critical, "Mensaje de Error")

                ElseIf lActivo = False Then

                    MsgBox("Falta capturar los datos del bien o el importe de los bienes es incorrecto", MsgBoxStyle.Critical, "Mensaje de Error")

                ElseIf lPrenda = False Then

                    MsgBox("Falta capturar los datos de la garantía prendaria", MsgBoxStyle.Critical, "Mensaje de Error")

                End If

            End If

        Catch eException As Exception
            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
        End Try
        btnActivar.Enabled = False
        btnValida.Enabled = True
        btnHoja.Enabled = True
        btnPagare.Enabled = True
        btnContrato.Enabled = True

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()

        TraeDatos()

    End Sub

    Private Sub btnValida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValida.Click

        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document
        Dim dsTemporal As New DataSet()
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim drAnexo As DataRow
        Dim drTotal As DataRow

        'Dim RutaApp As String = ""
        'If Directory.Exists("c:\program files (x86)\") Then
        '    RutaApp = "c:\program files (x86)\"
        'Else
        '    RutaApp = "C:\Archivos de programa\"
        'End If

        dsTemporal.ReadXml("C:\Contratos\Schema2.xml")

        drAnexo = dsTemporal.Tables("Contrato").Rows(0)

        oRuta = DocCopiaLocal("F:\CS\Hoja Val.doc", 2)

        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantilla

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        If drAnexo("Coac") = "C" And drAnexo("Tipcoac") = "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
            If drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P" Then
                cCoac2 = Chr(10) & Chr(10) & "Declara  el COARRENDATARIO por conducto de su representante " & drAnexo("Nomrcoac") & " que:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            ElseIf drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S" Then
                cCoac2 = Chr(10) & Chr(10) & "Declara  el COACREDITADO por conducto de su representante " & drAnexo("Nomrcoac") & " que:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            End If
            cCoac2 = cCoac2 & Chr(10) & Chr(10) & drAnexo("Genercoa") & Chr(10) & Chr(10) & drAnexo("Podercoa")
        ElseIf drAnexo("Coac") = "C" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomrcoac")) = "" Then
            If drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P" Then
                cCoac2 = Chr(10) & Chr(10) & "Declara  el COARRENDATARIO por su propio derecho:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            ElseIf drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S" Then
                cCoac2 = Chr(10) & Chr(10) & "Declara  el COACREDITADO por su propio derecho:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            End If
        ElseIf drAnexo("Coac") = "S" And drAnexo("Tipcoac") = "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
            cCoac2 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por conducto de su representante " & drAnexo("Nomrcoac") & " que:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            cCoac2 = cCoac2 & Chr(10) & Chr(10) & drAnexo("Genercoa") & Chr(10) & Chr(10) & drAnexo("Podercoa")
        ElseIf drAnexo("Coac") = "S" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomrcoac")) = "" Then
            cCoac2 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por su propio derecho:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
        End If

        If drAnexo("Obli") = "S" And drAnexo("TipoObli") = "M" And Trim(drAnexo("NomObli")) <> "" Then
            cDato8 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por conducto de su representante " & drAnexo("NomrObl") & " que:" & Chr(10) & Chr(10) & drAnexo("GeneObli")
            cDato8 = cDato8 & Chr(10) & Chr(10) & drAnexo("GenerObl") & Chr(10) & Chr(10) & drAnexo("PoderObl")
        ElseIf drAnexo("Obli") = "S" And drAnexo("TipoObli") <> "M" And Trim(drAnexo("NomObli")) <> "" Then
            cDato8 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por su propio derecho:" & Chr(10) & Chr(10) & drAnexo("GeneObli")
        End If

        If drAnexo("Aval1") = "S" And drAnexo("TipAval1") = "M" And Trim(drAnexo("NomAval1")) <> "" Then
            cDato9 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por conducto de su representante " & drAnexo("Nomrava1") & " que:" & Chr(10) & Chr(10) & drAnexo("GeneAva1")
            cDato9 = cDato9 & Chr(10) & Chr(10) & drAnexo("Generav1") & Chr(10) & Chr(10) & drAnexo("PoderAv1")
        ElseIf drAnexo("Aval1") = "S" And drAnexo("TipAval1") <> "M" And Trim(drAnexo("NomAval1")) <> "" Then
            cDato9 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por su propio derecho:" & Chr(10) & Chr(10) & drAnexo("GeneAva1")
        End If

        If drAnexo("Aval2") = "S" And drAnexo("TipAval2") = "M" And Trim(drAnexo("NomrAva2")) <> "" Then
            cDato10 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por conducto de su representante " & drAnexo("Nomrava2") & " que:" & Chr(10) & Chr(10) & drAnexo("GeneAva2")
            cDato10 = cDato10 & Chr(10) & Chr(10) & drAnexo("Generav2") & Chr(10) & Chr(10) & drAnexo("PoderAv2")
        ElseIf drAnexo("Aval2") = "S" And drAnexo("TipAval2") <> "M" And Trim(drAnexo("NomrAva2")) = "" Then
            cDato10 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por su propio derecho:" & Chr(10) & Chr(10) & drAnexo("GeneAva2")
        End If

        If cForca = "1" Then
            cLetra = cForca & " PAGOS NIVELADOS"
        ElseIf cForca = "2" Then
            cLetra = cForca & " PAGOS DECRECIENTES"
        Else
            cLetra = cForca & " SPREAD PISO/TECHO"
        End If

        With oWordDoc.Sections(1)
            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "HOJA DE VALIDACION DE DATOS DEL CONTRATO No. " & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4))
        End With

        ' Abro el Contrato

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo únicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quitándole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable

                Select Case cfName

                    Case "mDescr"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCusnam)
                    Case "mCoac2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCoac2
                    Case "mDato7"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDato7)
                    Case "mDato8"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato8
                    Case "mDato9"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato9
                    Case "mCalle"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCalle
                    Case "mColonia"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cColonia
                    Case "mCopos"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCopos)
                    Case "mDelegacion"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDelegacion)
                    Case "mEstado"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cEstado)
                    Case "mRFC"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRfc.ToUpper
                    Case "mTelefono"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cTelefono.ToUpper
                    Case "mPersona"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cTipo.ToUpper
                    Case "mGeneClie"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cGeneClie.ToUpper
                    Case "mFax"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFax.ToUpper
                    Case "mDato10"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato10
                    Case "mPlazo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = nAmort.ToString & " Pagos con la periodicidad que se indica en la Tabla de Amortización"
                    Case "mBienes"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cBienes
                    Case "mPromo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cPromo
                    Case "mTasas"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = nTasas.ToString & Cant_Letras(nTasas, "")
                    Case "mDifer"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = nDifer.ToString & Cant_Letras(nDifer, "")
                    Case "mMensu"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nMensu).ToString & Letras(nMensu)
                    Case "mFechacon"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFechacon)
                    Case "mFeven"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFvenc
                    Case "mFechaTer"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFecha1)
                    Case "mTasmor"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = "LA RESULTANTE DE MULTIPLICAR POR " & nTasmor.ToString & " EL VALOR DE LA TASA DE INTERES ORDINARIO"
                    Case "mOpcion"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nOpcion) & Letras(nOpcion)
                    Case "mComis"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nComis / (1 + nPorInt)) & Letras(Round(nComis / (1 + nPorInt), 2))
                    Case "mIvaComis"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber((nComis / (1 + nPorInt)) * nPorInt) & Letras(Round((nComis / (1 + nPorInt)) * nPorInt, 2))
                    Case "mIvaeq"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nIvaEq) & Letras(nIvaEq)
                    Case "mImpRD"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nImpRD) & Letras(nImpRD)
                    Case "mRentasd"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nRentasD) & Letras(nRentasD)
                    Case "mIvard"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nIvard) & Letras(nIvard)
                    Case "mFReserva"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nFondoReserva) & Letras(nFondoReserva)
                    Case "mTotal"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipar = "P" Then
                            myMField.Result.Text = FormatNumber(nTotal) & Letras(nTotal)
                        Else
                            If cFondeo = "03" Then
                                myMField.Result.Text = FormatNumber(nTotal2 + nTotalCobert + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal2 + nTotalCobert + nGtotaliva + nGtotalivacap)
                            Else
                                myMField.Result.Text = FormatNumber(nTotal2 + nCobertura + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal2 + nCobertura + nGtotaliva + nGtotalivacap)
                            End If
                        End If
                    Case "mIvaDGar"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nIvaDepg) & Letras(nIvaDepg)
                    Case "mTipta"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cTipta & " " & cDescTasa
                    Case "mForca"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLetra
                    Case "mRefCliente"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRefCliente
                    Case "mRefProducto"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRefProducto
                    Case "mTexto"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cTexto
                    Case "mEjecu"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cEjecu
                    Case "mSubDPromo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cSubDPromo
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
        Dim oMissing = System.Reflection.Missing.Value

        Dim oSaveAsFile = "C:\contratos\" & Trim(cCusnam) & "_HV_" & cContrato & ".doc"

        Try
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnHoja_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHoja.Click
        Dim dsTemporal As New DataSet()
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim drAnexo As DataRow
        Dim drTotal As DataRow
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document

        'Dim RutaApp As String = ""
        'If Directory.Exists("c:\program files (x86)\") Then
        '    RutaApp = "c:\program files (x86)\"
        'Else
        '    RutaApp = "C:\Archivos de programa\"
        'End If

        oRuta = DocCopiaLocal("F:\CS\Hoja Disp.doc", 2)

        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantilla

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        dsTemporal.ReadXml("C:\Contratos\Schema2.xml")

        drAnexo = dsTemporal.Tables("Contrato").Rows(0)

        If cTipar = "S" Then
            If cFondeo = "03" Then
                With oWordDoc.Sections(1)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                    If Round(nMtoFin / nUdi, 2) < nVMUdi Then
                        .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318 ")
                    End If
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "HOJA DE DISPOSICION DE CREDITO SIMPLE Contrato No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
                End With
            Else
                With oWordDoc.Sections(1)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                    If Round(nMtoFin / nUdi, 2) < nVMUdi Then
                        If bLiquidez = True Then
                            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029254/01-01329-0318 ")
                        Else
                            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318 ")
                        End If
                    End If
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "HOJA DE DISPOSICION DE CREDITO SIMPLE Contrato No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
                End With
            End If
        End If

        ' Abro el Contrato

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo únicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quitándole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable

                Select Case cfName

                    Case "mDescr"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCusnam)
                    Case "mContrato"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4))
                    Case "mSaldoAct"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSaldoAct)
                    Case "mLinau"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nLinau)
                    Case "mFevig"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFevig)
                    Case "mProveedor"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cProveedor
                    Case "mImpProv"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cImpProv
                    Case "mImpeq"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nImpEq)
                    Case "mMtoFin"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nMtoFin)
                    Case "mPlazo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = nAmort.ToString & " Pagos especificados en la Tabla de Amortización correspondiente"
                    Case "mPromo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cPromo
                    Case "mTasas"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If nDifer > 0 Then
                            myMField.Result.Text = (nTasas - nDifer).ToString
                        Else
                            myMField.Result.Text = nTasas.ToString
                        End If
                    Case "mDifer"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = nDifer.ToString
                    Case "mMensu"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nMensu).ToString
                    Case "mFechacon"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFechacon)
                    Case "mFeven"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFvenc
                    Case "mFecre"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFecre)
                    Case "mFeaut"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFeaut)
                    Case "mSaldoRiesgo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSaldoRiesgo).ToString
                    Case "mSaldo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSaldo).ToString
                    Case "mIvaeq"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nIvaEq).ToString
                    Case "mDescFrecuencia"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDescFrecuencia
                    Case "mDescRecurso"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDescRecurso
                    Case "mOpcion"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = nPorop
                    Case "mTipta"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDescTasa
                    Case "mDescPI"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDescPI
                    Case "mImpPI"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cImpPI
                    Case "mEjecu"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cEjecu
                    Case "mSubDPromo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cSubDPromo
                    Case "mSucursal"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = TaQUERY.SacaSucursal(cSucursal)
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
        Dim oMissing = System.Reflection.Missing.Value

        Dim oSaveAsFile = "C:\contratos\" & Trim(cCusnam) & "_HD_" & cContrato & ".doc"

        Try
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try
        Cursor.Current = Cursors.Default


    End Sub

    Private Sub btnPagare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagare.Click

        Dim dsTemporal As New DataSet()
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim drAnexo As DataRow
        Dim drTotal As DataRow
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document
        Dim cArticulo As String = ""

        'Dim RutaApp As String = ""
        'If Directory.Exists("c:\program files (x86)\") Then
        '    RutaApp = "c:\program files (x86)\"
        'Else
        '    RutaApp = "C:\Archivos de programa\"
        'End If

        oRuta = DocCopiaLocal("F:\CS\PAGARE1.doc", 2)

        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantilla

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        dsTemporal.ReadXml("C:\Contratos\Schema2.xml")

        drAnexo = dsTemporal.Tables("Contrato").Rows(0)

        If Mid(drAnexo("Geneclie"), 1, 2) = "A)" Then
            cGeneClie = drAnexo("GeneClie") & Chr(10)
        ElseIf Mid(drAnexo("Geneclie"), 1, 2) = "a)" Then
            cGeneClie = drAnexo("GeneClie") & Chr(10)
        Else
            cGeneClie = drAnexo("GeneClie") & Chr(10)
        End If

        If cTipar = "R" Then
            cArticulo = "325 (TRESCIENTOS VEINTICINCO)"
        Else
            cArticulo = "409 (CUATROCIENTOS NUEVE)"
        End If

        If drAnexo("Tipo") = "M" Then
            cDato7 = Chr(10) & Chr(10) & "B) Su representante cuenta con facultades suficientes y declara que: "
            cDato7 = cDato7 & Chr(10) + Chr(10) & drAnexo("Generepr")
            cDato7 = cDato7 & Chr(10) & Chr(10) & drAnexo("Poderepr")
            If drAnexo("Nomrepr2") <> "" Then
                cDato7 = Chr(10) & Chr(10) & "Su segundo representante " & drAnexo("Nomrepr2") & " quien manifiesta"
                cDato7 = Chr(10) & Chr(10) & drAnexo("Poderep2")
            End If
        End If

        If drAnexo("Coac") = "C" And drAnexo("Tipcoac") = "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
            If drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P" Then
                cCoac2 = Chr(10) & Chr(10) & "Declara  el COARRENDATARIO por conducto de su representante que:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            ElseIf drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S" Then
                cCoac2 = Chr(10) & Chr(10) & "Declara  el COACREDITADO por conducto de su representante que:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            End If
            cCoac2 = cCoac2 & Chr(10) & Chr(10) & drAnexo("Podercoa")
            cCoacp = " así como " & Trim(drAnexo("Nomcoac") & " representada por " & Trim(drAnexo("Nomrcoac")))
        ElseIf drAnexo("Coac") = "C" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomrcoac")) = "" Then
            If drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P" Then
                cCoac2 = Chr(10) & Chr(10) & "Declara  el COARRENDATARIO por su propio derecho:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            ElseIf drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S" Then
                cCoac2 = Chr(10) & Chr(10) & "Declara  el COACREDITADO por su propio derecho:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            End If
            cCoacp = " así como " & Trim(drAnexo("Nomcoac"))
        ElseIf drAnexo("Coac") = "S" And drAnexo("Tipcoac") = "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
            cCoac2 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por conducto de su representante que:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            cCoac2 = cCoac2 & Chr(10) & Chr(10) & drAnexo("Podercoa")
            If drAnexo("Anexo") = "03602/0001" Then
                cCoacp = " así como " & Trim(drAnexo("Nomcoac") & " representado por " & Trim(drAnexo("Nomrcoac")))
            Else
                cCoacp = " así como " & Trim(drAnexo("Nomcoac"))
            End If
        ElseIf drAnexo("Coac") = "S" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomrcoac")) = "" Then
            cCoac2 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por su propio derecho:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            cCoacp = " así como " & Trim(drAnexo("Nomcoac"))
        End If


        If drAnexo("Obli") = "S" And drAnexo("TipoObli") = "M" And Trim(drAnexo("NomrObl")) = "" Then
            cDato8 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por conducto de su representante que:" & Chr(10) & Chr(10) & drAnexo("GeneObli")
            cDato8 = cDato8 & Chr(10) & Chr(10) & drAnexo("PoderObl")
            If Trim(cCoacp) <> "" Then
                cCoacp = cCoacp & ", " & Trim(drAnexo("NomrObl"))
            Else
                cCoacp = " así como " & Trim(drAnexo("NomrObl"))
            End If
        ElseIf drAnexo("Obli") = "S" And drAnexo("TipoObli") <> "M" And Trim(drAnexo("NomObli")) <> "" Then
            cDato8 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por su propio derecho:" & Chr(10) & Chr(10) & drAnexo("GeneObli")
            If Trim(cCoacp) <> "" Then
                cCoacp = cCoacp & ", " & Trim(drAnexo("NomObli"))
            Else
                cCoacp = " así como " & Trim(drAnexo("NomObli"))
            End If
        End If

        If drAnexo("Aval1") = "S" And drAnexo("TipAval1") = "M" And Trim(drAnexo("NomrAva1")) = "" Then
            cDato9 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por conducto de su representante que:" & Chr(10) & Chr(10) & drAnexo("GeneAva1")
            cDato9 = cDato9 & Chr(10) & Chr(10) & drAnexo("PoderAv1")
            If Trim(cCoacp) <> "" Then
                cCoacp = cCoacp & ", " & Trim(drAnexo("NomrAva1"))
            Else
                cCoacp = " así como " & Trim(drAnexo("NomrAva1"))
            End If
        ElseIf drAnexo("Aval1") = "S" And drAnexo("TipAval1") <> "M" And Trim(drAnexo("NomAval1")) <> "" Then
            cDato9 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por su propio derecho:" & Chr(10) & Chr(10) & drAnexo("GeneAva1")
            If Trim(cCoacp) <> "" Then
                cCoacp = cCoacp & ", " & Trim(drAnexo("NomAval1"))
            Else
                cCoacp = " así como " & Trim(drAnexo("NomAval1"))
            End If
        End If

        If drAnexo("Aval2") = "S" And drAnexo("TipAval2") = "M" And Trim(drAnexo("NomrAva2")) <> "" Then
            cDato10 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por conducto de su representante que:" & Chr(10) & Chr(10) & drAnexo("GeneAva2")
            cDato10 = cDato10 & Chr(10) & Chr(10) & drAnexo("PoderAv2")
            If Trim(cCoacp) <> "" Then
                cCoacp = cCoacp & ", " & Trim(drAnexo("NomrAva2"))
            Else
                cCoacp = " así como " & Trim(drAnexo("NomrAva2"))
            End If
        ElseIf drAnexo("Aval2") = "S" And drAnexo("TipAval2") <> "M" And Trim(drAnexo("NomAval2")) = "" Then
            cDato10 = Chr(10) & Chr(10) & "Declara  el OBLIGADO SOLIDARIO Y AVAL por su propio derecho:" & Chr(10) & Chr(10) & drAnexo("GeneAva2")
            If Trim(cCoacp) <> "" Then
                cCoacp = cCoacp & ", " & Trim(drAnexo("NomAval2"))
            Else
                cCoacp = " así como " & Trim(drAnexo("NomAval2"))
            End If
        End If

        If cTipta = "1" Then
            cLetra = cTipta & " PAGOS NIVELADOS"
        ElseIf cTipta = "2" Then
            cLetra = cTipta & " PAGOS DECRECIENTES"
        Else
            cLetra = cTipta & " SPREAD PISO/TECHO"
        End If

        If cTipta < "7" Then
            cDescTipta = "Tasa Promedio Máxima, equivalente a la que resulte mayor de comparar:"

            If cTipta = "3" Or cTipta = "6" Then
                cDescTipta = cDescTipta & Chr(10) & Chr(10) & "La tasa CETES (rendimiento de los Certificados de la "
                cDescTipta = cDescTipta & "Tesorería de la Federación) por emisiones a plazo de 28 "
                cDescTipta = cDescTipta & "días, determinada en la primera semana de cada periodo."
            End If
            If cTipta = "2" Or cTipta = "3" Or cTipta = "6" Then
                cDescTipta = cDescTipta & Chr(10) & Chr(10) & "La tasa C.P.P. (Costo Porcentual Promedio de Captación)"
                cDescTipta = cDescTipta & "publicada por el Banco de Máxico en el Diario Oficial de "
                cDescTipta = cDescTipta & "la Federación, aplicando la tasa vigente al inicio de "
                cDescTipta = cDescTipta & "cada periodo."
            End If
            If cTipta = "1" Or cTipta = "2" Or cTipta = "3" Then
                cDescTipta = cDescTipta & Chr(10) & Chr(10) & "La tasa TIIP (Tasa de interés Interbancaria Promedio) "
                cDescTipta = cDescTipta & "tasa de rendimiento anual, equivalente a 28 días, que sea "
                cDescTipta = cDescTipta & "o sean publicadas por el Banco de Máxico en el Diario "
                cDescTipta = cDescTipta & "Oficial de la Federaci¢n vigentes al inicio de cada "
                cDescTipta = cDescTipta & "periodo."
            End If
            If cTipta = "1" Or cTipta = "2" Or cTipta = "6" Or cTipta = "4" Then
                cDescTipta = cDescTipta & Chr(10) & Chr(10) & "La tasa TIIE (Tasa Anual de Interés Interbancaria de "
                cDescTipta = cDescTipta & "Equilibrio) que publica semanalmente Banco de México "
                cDescTipta = cDescTipta & "determinada en el periodo anterior a cada pago."
            End If

            cDescTipta = cDescTipta & Chr(10) & Chr(10) & "A dicha Tasa Promedio Máxima se adicionarán "
            cDescTipta = cDescTipta & Round(nDifer, 2).ToString & " " & Cant_Letras(nDifer, "") & " puntos porcentuales."

            cDescTipta = cDescTipta & Chr(10) & Chr(10) & "Tanto la Tasa Promedio Máxima as¡ como su diferencial de "
            cDescTipta = cDescTipta & "puntos se revisar n con la misma periodicidad que las "
            cDescTipta = cDescTipta & "parcialidades a efecto de adecuarlos a las condiciones del "
            cDescTipta = cDescTipta & "mercado en ese momento."

            cDescTipta = cDescTipta & Chr(10) & Chr(10) & "Este pagar‚ incluye intereses sobre saldos insolutos, que en "
            cDescTipta = cDescTipta & "su caso serán ajustables con la misma periodicidad que las "
            cDescTipta = cDescTipta & "parcialidades, desde la fecha de su expedición hasta la de "
            cDescTipta = cDescTipta & "su vencimiento de acuerdo al movimiento de la Tasa Promedio "
            cDescTipta = cDescTipta & "Máxima vigente durante el periodo en que se devenguen dichos "
            cDescTipta = cDescTipta & "intereses, aumentando "
            cDescTipta = cDescTipta & Round(nDifer, 2).ToString & " " & Cant_Letras(nDifer, "") & " puntos porcentuales."

        ElseIf cTipta = "7" Then
            cDescTipta = "TASA FIJA con un valor de " & Round(nTasas, 2).ToString & " " & Cant_Letras(nTasas, "") & " anual."
        ElseIf cTipta = "8" Then
            cDescTipta = "TASA PROTEGIDA con un valor de TIIE + '" & Round(nDifer, 2).ToString
            cDescTipta = cDescTipta & " porciento anual, estableciendo una TIIE maxima del 13.00 porciento anual."
        End If

        If cTipar = "S" Then
            If cFondeo = "03" Then
                With oWordDoc.Sections(1)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                    If Round(nMtoFin / nUdi, 2) < nVMUdi Then
                        .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318")
                    End If
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "PAGARE DE CREDITO SIMPLE Contrato No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
                End With
            Else
                With oWordDoc.Sections(1)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                    If Round(nMtoFin / nUdi, 2) < nVMUdi Then
                        If bLiquidez = True Then
                            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029254/01-01329-0318 ")
                        Else
                            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318 ")
                        End If
                    End If
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "PAGARE DE CREDITO SIMPLE Contrato No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
                End With
            End If
        End If

        ' Abro el Contrato

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo únicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quitándole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable

                Select Case cfName

                    Case "mContrato"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4))
                    Case "mDescr"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCusnam)
                    Case "mRepresentante"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cRepresentante)
                    Case "mCoacp"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCoacp
                    Case "mAval"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cAval.ToUpper
                    Case "mCalle"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCalle
                    Case "mColonia"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cColonia
                    Case "mCopos"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCopos)
                    Case "mDelegacion"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDelegacion)
                    Case "mEstado"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cEstado)
                    Case "mFechacon"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFechacon)
                    Case "mTasmor"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipar = "P" Then
                            myMField.Result.Text = Round(nTasas * nTasmor, 2) & " " & Cant_Letras(Round(nTasas * nTasmor, 2), "")
                        Else
                            myMField.Result.Text = Round(nTasmor, 2) & " " & Cant_Letras(nTasmor, "")
                        End If
                    Case "mTasaLetra"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipar = "P" Then
                            myMField.Result.Text = Cant_Letras(Round(nTasas * nTasmor, 2), "")
                        Else
                            myMField.Result.Text = Cant_Letras(Round(nTasmor, 2), "")
                        End If
                    Case "mTasmor1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = nTasmor
                    Case "mTotal"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nMtoFin) & Letras(nMtoFin)

                    Case "mLetrat"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLetrat
                    Case "mFevent"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFevent
                    Case "mRenta"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipar = "P" Then
                            myMField.Result.Text = cRentap
                        Else
                            myMField.Result.Text = cTotgCAP
                        End If
                        If cFondeo = "03" Then
                            myMField.Result.Text = cTotgCAP
                        End If
                    Case "mFirmaCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaCte.ToUpper
                    Case "mFirmaAval1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval1.ToUpper
                    Case "mFirmaAval2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval2.ToUpper
                    Case "mFirmaAval3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval3.ToUpper
                    Case "mFirmaAval4"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval4.ToUpper
                    Case "mDescTipta"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDescTipta
                    Case "mLugar"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLugar
                    Case "mProducto"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cProducto
                    Case "mArticulo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cArticulo
                    Case "mRefCliente"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRefCliente
                    Case "mParrafoInteres"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cParrafoInteres
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
        Dim oMissing = System.Reflection.Missing.Value

        Dim oSaveAsFile = "C:\contratos\" & Trim(cCusnam) & "_PAG_" & cContrato & ".doc"

        Try
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnContrato_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContrato.Click
        'If txtAnexo.Text = "00362/0014" Then ' se aplica bloqueo a partir de contratos con esta fecha
        Dim Ree As String = "N"
        Ree = TaQUERY.EsReestructura(Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4))
        If TaQUERY.SacaPermisoModulo("", UsuarioGlobal.ToLower) <= 0 Then
            If Ree <> "S" Then
                If cFechacon >= "20151001" Or txtAnexo.Text = "00362/0014" Then ' se aplica bloqueo a partir de contratos con esta fecha
                    If RevisaTasa(Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4), cCliente) Then
                        Exit Sub
                    End If
                End If
            End If
        End If
        Dim dsTemporal As New DataSet()
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim drAnexo As DataRow
        Dim drTotal As DataRow
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document

        ' Declaración de variables de datos

        Dim cFecha As String
        Dim cFeven As String
        Dim cDato1 As String = ""
        Dim cNota As String = ""
        Dim cDato12 As String = ""
        Dim cCoacre As String = ""
        Dim cDato12A As String = ""
        Dim cDato12B As String = ""
        Dim cDato12C As String = ""
        Dim cGenerep As String = ""
        Dim cDato15 As String = ""
        Dim cLetraImp As String = ""
        Dim cGeneEmp As String = ""
        Dim cTestigo1 As String = ""
        Dim cTestigo2 As String = ""
        Dim cLeyenda As String = ""
        Dim cCobertura As String = ""
        Dim cAporInv As String = ""
        Dim cCoberDet1 As String = ""
        Dim cCoberDet2 As String = ""
        Dim cRecur As String
        Dim cSeguro As String
        Dim nCount As Integer
        Dim nTIR As Decimal
        Dim nSaldo As Decimal
        Dim nMensu As Decimal
        Dim nDato2 As Decimal
        Dim nDepg As Decimal
        Dim i As Integer
        'Dim RutaApp As String = ""

        'If Directory.Exists("c:\program files (x86)\") Then
        '    RutaApp = "c:\program files (x86)\"
        'Else
        '    RutaApp = "C:\Archivos de programa\"
        'End If

        dsTemporal.ReadXml("C:\Contratos\Schema2.xml")

        drAnexo = dsTemporal.Tables("Contrato").Rows(0)

        cLetraImp = Letras(nTotal)


        cNota = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "NOTA: A través de la(s) firma(s) que de su puño y letra estampa(n) en el presente contrato el(los) OBLIGADO(S) SOLIDARIO(S) Y AVAL(ES) "
        cNota = cNota & "manifiesta(n) su conformidad y se da(n) por enterado(s) y advertido(s), que esta(n) obligado(s) a efectuar el "
        cNota = cNota & "pago en caso de que el obligado principal (LA ARRENDATARIA) incumpla con el mismo por cualquier causa."


        If drAnexo("Tipo") = "M" And Trim(drAnexo("Nomrepr")) <> "" Then
            cDato1 = "por conducto de su representante que:"
            cGeneEmp = Chr(10) & Chr(10) & "De la sociedad denominada " & cCusnam & " su representante de nombre " & cRepresentante & " manifiesta que " & cGeneClie & "Manifestando los comparecientes bajo protesta de decir verdad, que las facultades a ellos otorgadas, no les han sido revocadas, ni en forma alguna limitadas."
        Else
            cDato1 = "por su propio derecho:"
        End If

        cDato15 = Mid(drAnexo("Geneclie"), 1, 2)
        If cDato15 = "A)" Then
            cGeneClie = Mid(drAnexo("GeneClie"), 3, Len(drAnexo("GeneClie"))) & Chr(10)
        ElseIf cDato15 = "a)" Then
            cGeneClie = Mid(drAnexo("GeneClie"), 3, Len(drAnexo("GeneClie"))) & Chr(10)
        Else
            cGeneClie = drAnexo("GeneClie") & Chr(10)
        End If

        If drAnexo("Tipo") = "M" Then
            cDato7 = Chr(10) & Chr(10) & drAnexo("Generepr") & Chr(10) & Chr(10) & drAnexo("Poderepr")
            If drAnexo("Nomrepr2") <> "" Then
                cDato7 = Chr(10) & Chr(10) & "SU SEGUNDO REPRESENTANTE " & drAnexo("Nomrepr2") & " QUIEN MANIFIESTA" & Chr(10) & Chr(10) & drAnexo("Poderep2")
            End If
        End If

        cDato12 = "III.- "

        cCoac2 = ""
        cCoacre = ""
        If drAnexo("Coac") = "C" And drAnexo("Tipcoac") = "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
            If drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P" Then
                cCoacre = Chr(10) & Chr(10) & "COARRENDATARIO: " & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac") & Chr(10) & "REPRESENTADA EN ESTE ACTO POR: " & Trim(drAnexo("Nomrcoac")) & Chr(10) & Chr(10) & drAnexo("Genercoa") & Chr(10) & Chr(10) & drAnexo("Podercoa")
                ' cCoacre = Chr(10) & Chr(10) & "COARRENDATARIO: " & Trim(drAnexo("Nomrcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            ElseIf drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S" Then
                cCoacre = Chr(10) & Chr(10) & "COACREDITADO: " & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac") & Chr(10) & "REPRESENTADA EN ESTE ACTO POR: " & Trim(drAnexo("Nomrcoac")) & Chr(10) & Chr(10) & drAnexo("GenerCoa") & Chr(10) & Chr(10) & drAnexo("Podercoa")
                'cCoacre = Chr(10) & Chr(10) & "COACREDITADO: " & Trim(drAnexo("Nomrcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            End If
            cDato12C = cDato12C & Chr(10) & Chr(10) & drAnexo("Podercoa")
        ElseIf drAnexo("Coac") = "C" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomrcoac")) = "" Then
            If drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P" Then
                cCoacre = Chr(10) & Chr(10) & "COARRENDATARIO: " & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac")
                'cCoacre = Chr(10) & Chr(10) & "COARRENDATARIO: " & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            ElseIf drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S" Then
                cCoacre = Chr(10) & Chr(10) & "COACREDITADO: " & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac")
                'cCoacre = Chr(10) & Chr(10) & "COACREDITADO: " & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            End If
        ElseIf drAnexo("Coac") = "S" And drAnexo("Tipcoac") = "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
            cCoac2 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac") & Chr(10) & Chr(10) & "REPRESENTADA EN ESTE ACTO POR: " & Trim(drAnexo("Nomrcoac")) & Chr(10) & Chr(10) & drAnexo("Genercoa") & Chr(10) & Chr(10) & drAnexo("Podercoa")
        ElseIf drAnexo("Coac") = "S" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
            cCoac2 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL:" & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac")
        ElseIf drAnexo("Coac") = "S" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomcoac")) <> "" Then
            cCoac2 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL:" & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac")
        End If

        If cCoac2 <> "" Then
            cDato12 = "IV.- "
            cDato12A = "V.- "
            cDato12B = "VI.- "
            cDato12C = "VII.- "
        End If

        cDato8 = ""
        If drAnexo("Obli") = "S" And drAnexo("TipoObli") = "M" And Trim(drAnexo("NomObli")) <> "" Then
            cDato8 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & drAnexo("NomObli") & Chr(10) & drAnexo("GeneObli") & Chr(10) & "REPRESENTADA EN ESTE ACTO POR: " & Trim(drAnexo("NomrObl")) & Chr(10) & drAnexo("GenerObl") & Chr(10) & Chr(10) & drAnexo("PoderObl")
        ElseIf drAnexo("Obli") = "S" And drAnexo("TipoObli") <> "M" And Trim(drAnexo("NomrObl")) = "" Then
            cDato8 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & drAnexo("NomObli") & Chr(10) & drAnexo("GeneObli")
        End If

        If cDato8 <> "" And cDato12 = "IV.- " Then
            cDato12 = "V.- "
            cDato12A = "VI.- "
            cDato12B = "VII.- "
            cDato12C = "VIII.- "
        ElseIf cDato8 <> "" And cDato12 = "III.- " Then
            cDato12 = "IV.- "
            cDato12A = "V.- "
            cDato12B = "VI.- "
            cDato12C = "VII.- "
        End If

        If drAnexo("Aval1") = "S" And drAnexo("TipAval1") = "M" And Trim(drAnexo("NomAval1")) <> "" Then
            cDato9 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & Trim(drAnexo("NomAval1")) & Chr(10) & drAnexo("Geneava1") & Chr(10) & "REPRESENTADA EN ESTE ACTO POR:" & Trim(drAnexo("Nomrava1")) & Chr(10) & drAnexo("GenerAv1") & Chr(10) & Chr(10) & drAnexo("PoderAv1")
        ElseIf drAnexo("Aval1") = "S" And drAnexo("TipAval1") <> "M" And Trim(drAnexo("NomAval1")) <> "" Then
            cDato9 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & Trim(drAnexo("NomAval1")) & Chr(10) & drAnexo("GeneAva1")
        End If

        If cDato9 <> "" And cDato12 = "V.- " Then
            cDato12 = "VI.- "
            cDato12A = "VII.- "
            cDato12B = "VIII.- "
            cDato12C = "IX.- "
        ElseIf cDato9 <> "" And cDato12 = "IV.- " Then
            cDato12 = "V.- "
            cDato12A = "VI.- "
            cDato12B = "VII.- "
            cDato12C = "VIII.- "
        ElseIf cDato9 <> "" And cDato12 = "III.- " Then
            cDato12 = "IV.- "
            cDato12A = "V.- "
            cDato12B = "VI.- "
            cDato12C = "VII.- "
        ElseIf cDato9 <> "" And cDato12 = "VI.- " Then
            cDato12 = "VII.- "
            cDato12A = "VIII.- "
            cDato12B = "IX.- "
            cDato12C = "X.- "
        End If

        If drAnexo("Aval2") = "S" And drAnexo("TipAval2") = "M" And Trim(drAnexo("NomrAva2")) <> "" Then
            cDato10 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & Trim(drAnexo("Nomaval2")) & Chr(10) & Chr(10) & drAnexo("GeneAva2") & Chr(10) & Chr(10) & "REPRESENTADA EN ESTE ACTO POR: " & Trim(drAnexo("Nomrava2")) & Chr(10) & drAnexo("Generav2") & Chr(10) & Chr(10) & drAnexo("Poderav2")
        ElseIf drAnexo("Aval2") = "S" And drAnexo("TipAval2") <> "M" And Trim(drAnexo("NomrAva2")) = "" Then
            cDato10 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & Trim(drAnexo("Nomaval2")) & Chr(10) & Chr(10) & drAnexo("GeneAva2")
        End If

        If (drAnexo("Sucursal") = "01" Or drAnexo("Sucursal") = "02") And cTipar = "R" Then

            Dim ta As New PromocionDSTableAdapters.DatosTestigosTableAdapter
            Dim t As New PromocionDS.DatosTestigosDataTable
            Dim r As PromocionDS.DatosTestigosRow
            Dim cContrato = Mid(cAnexo, 1, 5) & Mid(cAnexo, 7, 4)

            ta.Fill(t, cContrato)
            r = t.Rows(0)

            cTestigo1 = Trim(r.Testigo1)
            cFirmaTestigo1 = Trim(r.FirmaT1)
            cTestigo2 = Trim(r.Testigo2)
            cFirmaTestigo2 = Trim(r.Firma2)

            'If Trim(drAnexo("DescPromotor")) = "C.P. GERALDO GARCIA VELEZ" Then
            '    cTestigo1 = "Llamarse Luis Manuel González Miranda, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 06 de enero de 1975, de profesión Contador Público, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. GOML750106SM8"
            '    cFirmaTestigo1 = "C.P. LUIS MANUEL GONZALEZ MIRANDA"
            'ElseIf Trim(drAnexo("DescPromotor")) = "ING. MIGUEL ANGEL LEAL RUIZ" Then
            '    cTestigo1 = "Llamarse Miguel Angel Leal Ruiz, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de México, D.F., lugar donde nació el día 12 de diciembre de 1961, de profesión Ingeniero Agronomo, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. LERM611212KS7"
            '    cFirmaTestigo1 = "ING. MIGUEL ANGEL LEAL RUIZ"
            'ElseIf Trim(drAnexo("DescPromotor")) = "C.P. JONATHAN HERNANDEZ ARIAS" Then
            '    cTestigo1 = "Llamarse Jonathan Hernández Arias, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 09 de julio de 1975, de profesión Contador Público, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. HEAJ7507096H2"
            '    cFirmaTestigo1 = "C.P. JONATHAN HERNANDEZ ARIAS"
            'ElseIf Trim(drAnexo("DescPromotor")) = "C.P. ENRIQUE YONG BETANCOURT" Then
            '    cTestigo1 = "Llamarse Enrique Yong Betancourt, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Querétaro, Querétaro, lugar donde nació el día 28 de abril de 1965, de profesión Contador Público, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. YOBE650428Q67"
            '    cFirmaTestigo1 = "C.P. ENRIQUE YONG BETANCOURT"
            'ElseIf Trim(drAnexo("DescPromotor")) = "C.P. LUIS MANUEL GONZALEZ MIRANDA" Then
            '    cTestigo1 = "Llamarse Luis Manuel González Miranda, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 06 de enero de 1975, de profesión Contador Público, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. GOML750106SM8"
            '    cFirmaTestigo1 = "C.P. LUIS MANUEL GONZALEZ MIRANDA"
            'ElseIf Trim(drAnexo("DescPromotor")) = "LAE RAFAEL DIAZ ORTIZ" Then
            '    cTestigo1 = "Llamarse Rafael Díaz Ortiz, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 03 de febrero de 1980, de profesión Lic. en Administración de Empresas, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. DIOR800203AG2"
            '    cFirmaTestigo1 = "LAE. RAFAEL DIAZ ORTIZ"
            'ElseIf Trim(drAnexo("DescPromotor")) = "C. PEDRO SOLIS FRANCO" Then
            '    cTestigo1 = "Llamarse Pedro Soli Franco, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de México, D.F., lugar donde nació el día 18 de marzo de 1978, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. SOFP7803186G8"
            '    cFirmaTestigo1 = "C. PEDRO SOLIS FRANCO"
            'ElseIf Trim(drAnexo("DescPromotor")) = "L.C. SERGIO SANCHEZ MACKENT" Then
            '    cTestigo1 = "Llamarse Sergio Sánchez Mackent, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de México, D.F., lugar donde nació el día 10 de septiembre de 1970, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. SAMS700910CW1"
            '    cFirmaTestigo1 = "L.C. SERGIO SANCHEZ MACKENT"
            'ElseIf Trim(drAnexo("DescPromotor")) = "GUILLERMO RAMIREZ GUZMAN" Then
            '    cTestigo1 = "Llamarse Guillermo Ramirez Guzman, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 20 de junio de 1961, de profesión Licenciado en Administración de Empresas, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. RAGG610620AF2"
            '    cFirmaTestigo1 = "LAE. GUILLERMO RAMIREZ GUZMAN"
            'End If

            'If Trim(drAnexo("DescPromotor")) = "LAE RAFAEL DIAZ ORTIZ" Then
            '    cTestigo2 = "Llamarse Jonathan Hernández Arias, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 09 de julio de 1975, de profesión Contador Público, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. HEAJ7507096H2"
            '    cFirmaTestigo2 = "C.P. JONATHAN HERNANDEZ ARIAS"
            'Else
            '    cTestigo2 = "Llamarse Rafael Díaz Ortiz, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 03 de febrero de 1980, de profesión Lic. en Administración de Empresas, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. DIOR800203AG2"
            '    cFirmaTestigo2 = "LAE RAFAEL DIAZ ORTIZ"
            'End If

        ElseIf drAnexo("Sucursal") = "03" Then
            cTestigo1 = "Llamarse Adolfo Pacheco Mendez, manifiesta por sus generales ser de nacionalidad mexicana, originaria de Ciudad Obregon, Sonora, lugar donde nació el día 01 de marzo de 1964, de profesión Ingeniero Agrónomo, con domicilio en Calle No Reelecion No. 712, colonia Centro Navojoa, Sonora México, y con R.F.C. PAMA6403012V1"
            cTestigo2 = "Llamarse Mitzi López Bojórquez, manifiesta por sus generales ser de nacionalidad mexicana, originario de Ciudad México, Distrito Federal, lugar donde nació el día 07 de noviembre de 1980, de profesión Licenciada en Sistemas de Información Administrativa, con domicilio en Calle No reelección No. 712 Col. Centro, Navojoa Sonora, México C.P. 85050 y con R.F.C. LOBM801107"
            cFirmaTestigo1 = "ING. ADOLFO PACHECO MENDEZ"
            cFirmaTestigo2 = "LIC. MITZI LOPÉZ BOJORQUEZ"
        ElseIf drAnexo("Sucursal") = "04" Then
            cTestigo1 = "Llamarse Janeth Ibarra Bibiano, manifiesta por sus generales ser de nacionalidad Mexicana, originario de la ciudad de Mexicali, Baja California, lugar donde nació el día 28 de Abril de 1986, de profesión Licenciada en Derecho, con domicilio en Avenida Electricistas número 1954, colonia Libertad, C.P. 21030, Mexicali, Baja California, y con R.F.C. IABJ860428TP8"
            cTestigo2 = "Llamarse Daniel Rentería, manifiesta por sus generales ser de nacionalidad mexicana, originaria de Ensenada, Baja California, lugar donde nació el día 15 de Octubre de 1959, de profesión Licenciado en Administración de Empresas, de estado civil casado, con domicilio en Puerta de Alcalá 2822 Frac. Puerta de Hierro, Mexicali, Baja California, México, C.P. 21255, con R.F.C. REDA591015HU8 y con CURP REXD591015HBCNXN00 "
            cFirmaTestigo1 = "LIC. JANETH IBARRA BIBIANO"
            cFirmaTestigo2 = "LIC. DANIEL RENTERIA"
        ElseIf drAnexo("Sucursal") = "05" Then
            cTestigo1 = "Llamarse Violeta María Lucia Tezcucano Contreras, manifiesta por sus generales ser de nacionalidad mexicana, originaria de la ciudad de Irapuato, Guanajuato, lugar donde nació el día 17 de enero de 1984, de profesión Licenciada en Contaduría, con domicilio en Av. de los Insurgentes 2604 Local B-4, colonia Los Fresnos C.P. 36555, Irapuato, Guanajuato, y con R.F.C. TECV8401179F0"
            cTestigo2 = "Llamarse José Juan Carlos Razo Guerra, manifiesta por sus generales ser de nacionalidad mexicana, originaria de la ciudad de Abasolo, Guanajuato, lugar donde nació el día 03 de mayo de 1984, de profesión Ingeniero Agroindustrial, con domicilio en Av. de los Insurgentes 2604 Local B-4, colonia Los Fresnos C.P. 36555, Irapuato, Guanajuato, y con R.F.C. RAGJ840503K35"
            cFirmaTestigo1 = "LIC. VIOLETA MARIA LUCIA TEZCUCANO CONTRERAS"
            cFirmaTestigo2 = "ING. RAUL ARMANDO VENEGAS MIRANDA"
        End If

        cFirmaTestigo1 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "PRIMER TESTIGO" & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(cFirmaTestigo1) + 6) & Chr(10) & cFirmaTestigo1
        cFirmaTestigo2 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "SEGUNDO TESTIGO" & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(cFirmaTestigo2) + 6) & Chr(10) & cFirmaTestigo2

        If cTipar = "F" Then
            cLeyenda = "Este documento no tiene ninguna validez legal ya que es solo hipotética, "
            cLeyenda = cLeyenda & " ejemplificativa e ilustrativa, toda vez que para la elaboración de esta tabla"
            cLeyenda = cLeyenda & " se tomó como base los meses con 30 días, por lo que puede haber variación"
            cLeyenda = cLeyenda & " de acuerdo al número real de días que tenga cada mes. Se precisa que los importes de esta tabla"
            cLeyenda = cLeyenda & " no incluyen los pagos del seguro de los bienes arrendados, seguro de vida (en su caso), ni del "
            cLeyenda = cLeyenda & "servicio de rastreador satelital, por lo que una vez determinados los montos de los pagos por estos"
            cLeyenda = cLeyenda & " conceptos, las partes acuerdan que serán financiados, se cargarán de forma mensual y de manera adicional"
            cLeyenda = cLeyenda & " deben ser pagados por la ARRENDATARIA. Las partes establecen que si durante el plazo de vigencia  del"
            cLeyenda = cLeyenda & " arrendamiento las autoridades decretan alguna variación en el Impuesto al Valor Agregado, los importes"
            cLeyenda = cLeyenda & " señalados en esta tabla por ese concepto se deberán ajustar a  esta variación y por lo tanto  cambiarán"
            cLeyenda = cLeyenda & " los montos reflejados en esta tabla."
        Else
            cLeyenda = "Este documento no tiene ninguna validez legal ya que es solo hipotética, "
            cLeyenda = cLeyenda & " ejemplificativa e ilustrativa, toda vez que para la elaboración de esta tabla"
            cLeyenda = cLeyenda & " se tomó como base los meses con 30 días, por lo que puede haber variación"
            cLeyenda = cLeyenda & " de acuerdo al número real de días que tenga cada mes. "
        End If

        If drAnexo("Tipo") = "M" Then
            If drAnexo("Coac") = "N" And cTipar = "P" Then
                cPersFirman = "COARRENDATARIA: N/A"
            Else
                cPersFirman = "PERSONAS QUE FIRMAN EN REPRESENTACIÓN DE LA EMPRESA: " & Trim(cCusnam) & " " & cRepresentante
            End If
            cSeguro = "N/A"
        Else
            If drAnexo("Coac") = "C" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomcoac")) <> "" Then
                If cTipar = "S" Then
                    cPersFirman = "COACREDITADO: " & Trim(drAnexo("Nomcoac"))
                Else
                    cPersFirman = "COARRENDATARIA: " & Trim(drAnexo("Nomcoac"))
                End If
            ElseIf drAnexo("Coac") = "C" And drAnexo("Tipcoac") = "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
                cPersFirman = "COARRENDATARIA: " & Trim(drAnexo("Nomcoac")) & " REPRESENTADO EN ESTE ACTO POR " & Trim(drAnexo("Nomrcoac"))
            End If
            If drAnexo("Coac") = "N" And cTipar = "P" Then
                cPersFirman = "COARRENDATARIA: N/A"
            End If
            cSeguro = "CONTRATADO CON GRUPO NACIONAL PROVINCIAL, S.A.B. CON LAS SIGUIENTES CONDICIONES APLICABLES"
        End If

        If cTipar = "S" Then
            oRuta = DocCopiaLocal("F:\CS\Contrato CS.doc", 2)
        End If

        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantilla  

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        cCoberDet2 = "En caso de que el recurso provenga de FIRA, contratar las coberturas para la administración del riesgo de acuerdo a las demandas del proyecto, a la disponibilidad de dichas "
        cCoberDet2 = cCoberDet2 & "coberturas, así como las políticas de riesgo de la SOFOM, tales como seguros, coberturas de precio y de tasas de interés y agricultura por contrato."

        If cFondeo = "03" Then
            cCobertura = "COBERTURA FEGA: " & (nPorcFEGA * 100).ToString("n2") & "% SOBRE SALDOS INSOLUTOS CONFORME A LA FECHA DE VENCIMIENTO EN TERMINOS DE LO ESTIPULAEDO EN LA CLAUSULA TRIGESIMA CUARTA Y TRIGESIMA SEXTA."
            cCobertura = cCobertura & Chr(10) & "LAS COBERTURAS ANTERIORES, SE FINANCIARAN, ÉSTAS Y LOS INTERESES SE COMPUTARAN Y PAGARAN MENSUALMENTE DE FORMA SUSCESIVA HASTA QUE SE LLEVE A CABO LA AMORTIZACION PRINCIPAL, DE ACUERDO A LO PLASMADO EN LA TABLA DE AMORTIZACION."
        End If

        If cTipar = "S" Then
            If cFondeo = "03" Then
                With oWordDoc.Sections(1)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                    If Round(nMtoFin / nUdi, 2) < nVMUdi Then
                        .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318 ")
                        cReca = "1907-439-029236/01-01233-0318 "
                    End If
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "CONTRATO DE CREDITO SIMPLE CON RECURSOS FIRA No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
                End With
            Else
                With oWordDoc.Sections(1)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                    If Round(nMtoFin / nUdi, 2) < nVMUdi Then
                        If bLiquidez = True Then
                            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029254/01-01329-0318 ")
                            cReca = "1907-439-029254/01-01329-0318 "
                        Else
                            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318 ")
                            cReca = "1907-439-029236/01-01233-0318 "
                        End If

                    End If
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "CONTRATO DE CREDITO SIMPLE No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
                End With
            End If
        End If

        If cFondeo = "03" Then
            cRecur = " FIRA (X)        NAFIN ( )        PROPIOS ( )"
        ElseIf cFondeo = "02" Then
            cRecur = " FIRA ( )        NAFIN (X)        PROPIOS ( )"
        ElseIf cFondeo = "01" Then
            cRecur = " FIRA ( )        NAFIN ( )        PROPIOS (X)"
        End If

        If cFondeo = "03" Then
            cAporInv = "APORTACION A LA INVERSION: " & FormatNumber((nMtoFin / 0.8) - nMtoFin).ToString & " " & Letras((nMtoFin / 0.8) - nMtoFin) & Chr(10)
        End If

        Dim nResultado As Decimal
        Dim nSumaBanamex As Decimal
        Dim nSumaBancomer As Decimal

        Dim cRefBanamex As String
        Dim cRefBanorte As String
        Dim cRefBancomer As String
        Dim cRefHSBC As String

        cAnexo = Mid(drAnexo("Anexo"), 1, 5) & Mid(drAnexo("Anexo"), 7, 4)
        cFlcan = drAnexo("Flcan")
        cTipo = drAnexo("Tipar")

        cRefBanamex = Mid(cAnexo, 1, 5) + Mid(cAnexo, 7, 3)
        cRefBancomer = Mid(cAnexo, 2, 4) + Mid(cAnexo, 7, 3)
        cRefBanorte = Mid(cAnexo, 2, 4) + Mid(cAnexo, 7, 3)

        nSumaBanamex = 1235
        nSumaBanamex += Val(Mid(cRefBanamex, 1, 1)) * 11
        nSumaBanamex += Val(Mid(cRefBanamex, 2, 1)) * 13
        nSumaBanamex += Val(Mid(cRefBanamex, 3, 1)) * 17
        nSumaBanamex += Val(Mid(cRefBanamex, 4, 1)) * 19
        nSumaBanamex += Val(Mid(cRefBanamex, 5, 1)) * 23
        nSumaBanamex += Val(Mid(cRefBanamex, 6, 1)) * 29
        nSumaBanamex += Val(Mid(cRefBanamex, 7, 1)) * 31
        nSumaBanamex += Val(Mid(cRefBanamex, 8, 1)) * 37

        nResultado = 99 - (nSumaBanamex Mod 97)
        If nResultado > 9 Then
            cRefBanamex += "-" + nResultado.ToString
        Else
            cRefBanamex += "-" + "0" + nResultado.ToString
        End If

        nSumaBancomer = 0
        nResultado = Val(Mid(cRefBancomer, 1, 1)) * 2
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 2, 1)) * 1
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 3, 1)) * 2
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 4, 1)) * 1
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 5, 1)) * 2
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 6, 1)) * 1
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 7, 1)) * 2
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If

        If nSumaBancomer > 60 Then
            nResultado = 70 - nSumaBancomer
        ElseIf nSumaBancomer > 50 Then
            nResultado = 60 - nSumaBancomer
        ElseIf nSumaBancomer > 40 Then
            nResultado = 50 - nSumaBancomer
        ElseIf nSumaBancomer > 30 Then
            nResultado = 40 - nSumaBancomer
        ElseIf nSumaBancomer > 20 Then
            nResultado = 30 - nSumaBancomer
        ElseIf nSumaBancomer > 10 Then
            nResultado = 20 - nSumaBancomer
        ElseIf nSumaBancomer > 0 Then
            nResultado = 10 - nSumaBancomer
        Else
            nResultado = 0
        End If

        cRefBancomer += "-" + nResultado.ToString
        cRefBanorte = cRefBancomer

        ' Abro el Contrato

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo únicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quitándole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable
                If cfName.ToLower = "mtotal" Then
                    cfName = cfName
                End If

                Select Case cfName

                    Case "mDescr"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCusnam)
                    Case "mRepresentante"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cRepresentante)
                    Case "mCoac"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCoac
                    Case "mReca"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cReca
                    Case "mCoac2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCoac2
                    Case "mCoacre"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCoacre
                    Case "mPersFirman"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cPersFirman & Chr(13)
                    Case "mDato1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDato1)
                    Case "mDato7"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDato7)
                    Case "mDato8"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato8
                    Case "mDato9"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato9
                    Case "mCalle"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCalle
                    Case "mColonia"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cColonia
                    Case "mCopos"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCopos)
                    Case "mDelegacion"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDelegacion)
                    Case "mEstado"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cEstado)
                    Case "mFirmaCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaCte.ToUpper
                    Case "mFirmaAval1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval1.ToUpper
                    Case "mFirmaAval2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval2.ToUpper
                    Case "mGeneClie"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cGeneClie.ToUpper
                    Case "mFirmaAval3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval3.ToUpper
                    Case "mFirmaAval4"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval4.ToUpper
                    Case "mFirmaTest1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaTestigo1.ToUpper
                    Case "mFirmaTest2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaTestigo2.ToUpper
                    Case "mDato10"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato10
                    Case "mDato12"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cCoac2) <> "" Then
                            myMField.Result.Text = "IV.- "
                        Else
                            myMField.Result.Text = "III.- "
                        End If
                    Case "mDato12A"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato12A
                    Case "mDato12B"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato12B
                    Case "mDato12C"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato12C
                    Case "mAval"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cAval) <> "" Then
                            myMField.Result.Text = cAval.ToUpper
                        Else
                            myMField.Result.Text = "N.A."
                        End If
                    Case "mNota"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cNota
                    Case "mObSol"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cObSol
                    Case "mObSol1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cObSol1
                    Case "mTasas"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Round(nTasas, 2).ToString & " %"
                    Case "mTipta"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDescTasa) & " "
                    Case "mTasas1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipta = "7" Then
                            myMField.Result.Text = Round(nTasas, 2).ToString & " %"
                        Else
                            myMField.Result.Text = "Tasa variable TIIE más " & nDifer.ToString & " puntos porcentuales."
                        End If
                    Case "mTmora"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipta = "7" Then
                            myMField.Result.Text = Round(nTasas * nTasmor, 2).ToString & " %"
                        Else
                            myMField.Result.Text = " "
                        End If
                    Case "mTasmor"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipar = "P" Then
                            myMField.Result.Text = Round(nTasmor * nTasas, 2)
                        Else
                            myMField.Result.Text = Round(nTasmor, 2)
                        End If
                    Case "mFecha"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = MesJuridico(cFechacon)
                    Case "mTotal"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipar = "P" Then
                            myMField.Result.Text = FormatNumber(nTotal).ToString & " " & Letras(nTotal)
                        Else
                            myMField.Result.Text = FormatNumber(nTotal + nGtotaliva + nGtotalivacap).ToString & " " & Letras(nTotal + nGtotaliva + nGtotalivacap)
                        End If
                    Case "mGTIvac"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nGtotalivacap)
                    Case "mGTIva"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nGtotaliva)
                    Case "mGTCob"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nTotalCobert)
                    Case "mGTCap"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSumaCap)
                    Case "mGTInt"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSumaInt)
                    Case "mGTRe"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSumaRen)
                    Case "mGTBo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSumaBoni)
                    Case "mGTPm"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSumaPmen)
                    Case "mGTFi"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSumaCap + nSumaInt - nSumaBoni + nGtotalivacap + nGtotaliva + nTotalCobert)
                    Case "mSVida"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cSegVida
                    Case "mLetraImp"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLetraImp
                    Case "mPlazo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = nAmort.ToString & " Pagos distribuidos como se muestra en su Tabla de Amortización"
                    Case "mFeven"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFvenc
                    Case "mGeneEmp"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cGeneEmp
                    Case "mGenerepr"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cGenerepr
                    Case "mAvales"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cAvales
                    Case "mTestigo1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cTestigo1
                    Case "mTestigo2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cTestigo2
                    Case "mLetrast"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLetrat
                    Case "mFevent"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFevent
                    Case "mDiaFeven"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = "El día " & Mid(cFevent, 1, 2) & " de cada mes como se indica en la Tabla de Amortización"
                    Case "mSaldot"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cSaldot
                    Case "mAbcapt"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cAbcapt
                    Case "mIntert"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cIntert
                    Case "mIvat"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cIvat
                    Case "mIvacapt"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cIvaCapt
                    Case "mMtoFin"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nMtoFin).ToString & " " & Letras(nMtoFin)
                    Case "mRenta"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRenta
                    Case "mPagosi"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nPagosi).ToString & " " & Letras(nPagosi)
                    Case "mRecur"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRecur
                    Case "mTaspen"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Round(nTaspen, 2)
                    Case "mBonifica"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cBonifica
                    Case "mPagomen"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cPagomen
                    Case "mAporInv"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cAporInv
                    Case "mCAT"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipar = "F" Or cTipar = "P" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = Round(nCAT, 1).ToString & " % " & Chr(10) & "CAT: 'El Costo Anual Total de financiamiento expresado en términos porcentuales anuales que, para fines informáticos y de comparación, incorpora la totalidad de los costos y gastos inherentes a los créditos.'"
                        End If
                    Case "mCAT2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipar = "P" Or cTipar = "F" Then
                            myMField.Result.Text = Round(0, 1).ToString & "%"
                        Else
                            myMField.Result.Text = Round(nCAT, 1).ToString & "%"
                        End If
                    Case "mLeyenda"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLeyenda
                    Case "mParrafoInteres"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cParrafoInteres
                    Case "mDetalle"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDetalle
                    Case "mDesGarantia"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cPrenda = "S" Then
                            myMField.Result.Text = "PRENDARIA(X), DESCRITA EN EL ANEXO 'C'"
                        ElseIf cGHipotec = "S" Then
                            myMField.Result.Text = "HIPOTECARIA(X), DESCRITA EN LA ESCRITURA PUBLICA ANTE NOTARIO"
                        Else
                            myMField.Result.Text = " "
                        End If
                    Case "mReferencia"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = "Refencias Bancarias para Pago:" & Chr(10) & "BANAMEX Suc.285 Cuenta 7944154 Referencia " & cRefBanamex & Chr(10) & "BANCOMER Convenio 581034 Referencia " & cRefBancomer & Chr(10) & "BANORTE CEP 36832 Referencia " & cRefBanorte
                    Case "mDisposicion"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mid(cAnexo, 6, 4)
                    Case "mCtoMaestro"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mid(cAnexo, 1, 5)
                    Case "mLugar"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLugar
                    Case "mCobertura"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Chr(10) & cCobertura & Chr(10)
                    Case "mCoberDet1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Chr(10) & cCoberDet1 & Chr(10)
                    Case "mCoberDet2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCoberDet2 & Chr(10)
                    Case "mCobertt2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCobert
                    Case "mTotg"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cTotg
                    Case "mPorco"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Round(nPorco, 2).ToString & "%"
                    Case "mDescPI"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDescPI
                    Case "mSegVida"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = "EL RESULTADO DE MULTIPLICAR EL SALDO INSOLUTO DEL PERIODO POR 0.00067"
                        End If
                    Case "mUnidadEsp"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cUnidadEsp
                    Case "mRefCliente"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRefCliente
                    Case "mImpPI"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cImpPI
                    Case "mTotal2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cFondeo = "03" Then
                            If nGtotaliva > 0 And nGtotalivacap > 0 Then
                                myMField.Result.Text = FormatNumber(nTotal2 + nGtotaliva + nGtotalivacap + nTotalCobert, 2).ToString & Letras(nTotal2 + nGtotaliva + nGtotalivacap + nGtotalivacap + nTotalCobert) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & FormatNumber(nTotal2 - nMtoFin, 2).ToString & " más Iva Interés por " & FormatNumber(nGtotaliva, 2).ToString & " más Iva Capital por " & FormatNumber(nGtotalivacap, 2).ToString & " más su Cobertura por " & FormatNumber(nTotalCobert, 2).ToString
                            ElseIf nGtotaliva > 0 And nGtotalivacap = 0 Then
                                myMField.Result.Text = FormatNumber(nTotal2 + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal2 + nGtotalivacap + nGtotaliva) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & FormatNumber(nTotal2 - nMtoFin, 2).ToString & " más Iva Interés por " & FormatNumber(nGtotaliva, 2).ToString
                            ElseIf nGtotaliva = 0 And nGtotalivacap > 0 Then
                                myMField.Result.Text = FormatNumber(nTotal2 + nGtotaliva + nGtotalivacap + nTotalCobert, 2).ToString & Letras(nTotal2 + nGtotalivacap + nTotalCobert) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & FormatNumber(nTotal2 - nMtoFin, 2).ToString & " más Iva Capital por " & FormatNumber(nGtotalivacap, 2).ToString & " más su Cobertura por " & FormatNumber(nTotalCobert, 2).ToString
                            ElseIf nGtotaliva = 0 And nGtotalivacap = 0 Then
                                myMField.Result.Text = FormatNumber(nTotal2 + nGtotaliva + nGtotalivacap + nTotalCobert, 2).ToString & Letras(nTotal2 + nGtotalivacap + nTotalCobert) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & FormatNumber(nTotal2 - nMtoFin, 2).ToString & " más su Cobertura por " & FormatNumber(nTotalCobert, 2).ToString
                            End If
                        Else
                            If nGtotaliva > 0 And nGtotalivacap > 0 Then
                                myMField.Result.Text = FormatNumber(nTotal2 + nGtotaliva + nGtotalivacap + nCobertura, 2).ToString & Letras(nTotal2 + nGtotalivacap + nCobertura) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & FormatNumber(nTotal2 - nMtoFin, 2).ToString & " más Iva Interés por " & FormatNumber(nGtotaliva, 2).ToString & " más Iva Capital por " & FormatNumber(nGtotalivacap, 2).ToString
                            ElseIf nGtotaliva > 0 And nGtotalivacap = 0 Then
                                myMField.Result.Text = FormatNumber(nTotal2 + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal2 + nGtotalivacap + nGtotaliva) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & FormatNumber(nTotal2 - nMtoFin, 2).ToString & " más Iva Interés por " & FormatNumber(nGtotaliva, 2).ToString
                            ElseIf nGtotaliva = 0 And nGtotalivacap > 0 Then
                                myMField.Result.Text = FormatNumber(nTotal2 + nGtotaliva + nGtotalivacap + nCobertura, 2).ToString & Letras(nTotal2 + nGtotalivacap + nCobertura) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & FormatNumber(nTotal2 - nMtoFin, 2).ToString & " más Iva Capital por " & FormatNumber(nGtotalivacap, 2).ToString
                            ElseIf nGtotaliva = 0 And nGtotalivacap = 0 Then
                                myMField.Result.Text = FormatNumber(nTotal2 + nGtotaliva + nGtotalivacap + nCobertura, 2).ToString & Letras(nTotal2 + nGtotalivacap + nCobertura) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & FormatNumber(nTotal2 - nMtoFin, 2).ToString
                            End If
                        End If

                    Case "mSeguros"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = cSeguro
                        End If
                    Case "mSegV1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = "Del 01 (uno) de noviembre de 2015 (dos mil quince) al 01 (uno) de noviembre de 2016 (dos mil dieciséis)."
                        End If
                    Case "mSegV2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = "Mensual vencida"
                        End If
                    Case "mSegV3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = "sobre el saldo insoluto, con un monto máximo por asegurado de $ 5´000,000.00 (cinco millones 00/100 M.N.)"
                        End If
                    Case "mSegV4"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = "70 (setenta) años"
                        End If
                    Case "mSegV5"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = "75 (setenta y cinco) años"
                        End If
                    Case "mSegV6"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            If cTipar <> "S" Then
                                myMField.Result.Text = "El resultado de multiplicar el saldo insoluto del periodo por 0.00067 (cero, punto, cero, cero, cero, seis, siete)."
                            Else
                                myMField.Result.Text = "El resultado de multiplicar el Saldo Total entre mil por el 1 entre 30.4 por los Dias del Periodo. " & Chr(10) & " Factor de Seguro: 1 " & Chr(10) & " Saldo Total = Saldo Insoluto del Equipo + Saldo Insoluto del Seguro + Saldo Insoluto Otros + Saldo en Facturas + Interes del Periodo " & Chr(10) & "Seguro de vida= (Saldo Total /1000)* (Factor del Seguro /30.4)* Dias del Periodo." & Chr(10)
                            End If
                        End If
                    Case "mSegV7"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = ""
                        Else
                            myMField.Result.Text = "Se establece que las condiciones del seguro de vida contratado se renovarán anualmente, en los términos que establece la compañía aseguradora." & Chr(10)
                        End If
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
        Dim oMissing = System.Reflection.Missing.Value

        Dim oSaveAsFile = "C:\contratos\" & Trim(cCusnam) & "_CTO_" & cContrato & ".doc"
        Try
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnAnexoA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnexoA.Click
        If cTipar <> "S" Then

            Dim dsTemporal As New DataSet()
            Dim oNulo As Object = System.Reflection.Missing.Value
            Dim oRuta As New Object
            Dim myMField As Microsoft.Office.Interop.Word.Field
            Dim rFieldCode As Microsoft.Office.Interop.Word.Range
            Dim cFieldText As String
            Dim finMerge As Integer
            Dim fieldNameLen As Integer
            Dim cfName As String
            Dim oWord As New Word.Application
            Dim oWordDoc As Microsoft.Office.Interop.Word.Document

            If cTipta <= "6" Then
                cDescTipta = "TASA PROMEDIO MAXIMA determinada en los términos establecidos en esta cláusula,  del "
            ElseIf cTipta = "7" Then
                cDescTipta = cDescTipta & "TASA FIJA del "
            ElseIf cTipta = "8" Then
                cDescTipta = cDescTipta & "TASA del "
            End If
            cDescTipta = cDescTipta & FormatNumber(Round(nTasas - nDifer, 2), 2).ToString & " " & Cant_Letras(nTasas - nDifer, "")
            If cTipta <= "6" Or cTipta = "8" Then
                cDescTipta = cDescTipta & " más " & FormatNumber(Round(nDifer, 2), 2).ToString & " " & Cant_Letras(nDifer, "") & " puntos "
                cDescTipta = cDescTipta & " porcentuales adicionales."
            ElseIf cTipta = "7" Then
                cDescTipta = cDescTipta & " por ciento anual."
            End If
            If cTipta <= "6" Then
                cDescTipta = cDescTipta & Chr(10) & Chr(10) & "Las rentas estipuladas en este anexo podrán aumentar o disminuir "
                cDescTipta = cDescTipta & "de acuerdo a lo establecido en la cláusula cuarta del Contrato "
                cDescTipta = cDescTipta & "de Arrendamiento Financiero celebrado entre las partes, en el "
                cDescTipta = cDescTipta & "entendido de que para el cálculo de la primera renta se toma "
                cDescTipta = cDescTipta & "como base la tasa de rendimiento neto que resulte de adicionar "
                cDescTipta = cDescTipta & FormatNumber(Round(nDifer, 2), 2) & " " & Cant_Letras(nDifer, "") & " puntos"
                cDescTipta = cDescTipta & "porcentuales sobre la tasa que resulte mayor entre "
                Select Case cTipta
                    Case "1"
                        cDescTipta = cDescTipta & "la tasa TIIP y la tasa TIIE, '"
                    Case "2"
                        cDescTipta = cDescTipta & "la tasa C.P.P., la tasa TIIP y la tasa TIIE, "
                    Case "3"
                        cDescTipta = cDescTipta & "la tasa CETES, la tasa C.P.P. y la tasa TIIP, "
                    Case "4"
                        cDescTipta = cDescTipta & "la tasa CETES, la tasa C.P.P. y la tasa TIIE, "
                    Case "6"
                        cDescTipta = cDescTipta & "la tasa TIIE, "
                End Select
                cDescTipta = cDescTipta & "tal y como las mismas se definen:"
                If cTipta = "3" Or cTipta = "6" Then
                    cDescTipta = cDescTipta & Chr(10) & Chr(10) & "Para los efectos de la presente cláusula se entenderá por tasa CETES la tasa de rendimiento de los Certificados de la "
                    cDescTipta = cDescTipta & "Tesorería de la Federación por emisiones a plazo de 28 (veintiocho) días, determinada en la primera semana de cada "
                    cDescTipta = cDescTipta & "periodo de intereses."
                End If
                If cTipta >= "2" And cTipta <= "4" Then
                    cDescTipta = cDescTipta & Chr(10) & Chr(10) & "Igualmente se entenderá por tasa C.P.P. (Costo Porcentual Promedio), aplicando la tasa vigente al inicio de cada "
                    cDescTipta = cDescTipta & "periodo de intereses.   Dicha tasa significa (i) el Costo Porcentual Promedio de Captación "
                    cDescTipta = cDescTipta & "por concepto de tasa, y en su caso sobretasa de interés, de los pasivos en moneda nacional a cargo de las "
                    cDescTipta = cDescTipta & "Instituciones de Banca Múltiple del país, correspondientes exclusivamente a préstamos a empresas, particulares y a "
                    cDescTipta = cDescTipta & "depósitos a plazo, excepto ahorro, respecto a un mes determinado que el propio Banco de México da a conocer "
                    cDescTipta = cDescTipta & "mensualmente a través del Diario Oficial de la Federación, según resoluciones del mismo, publicadas en ese Diario con "
                    cDescTipta = cDescTipta & "fechas 20 de octubre de 1981 y 17 de noviembre de 1988, o en su defecto, (ii) el Costo Porcentual Promedio que en su "
                    cDescTipta = cDescTipta & "caso sustituya al anterior por determinación de las autoridades competentes."
                End If
                If cTipta <= "3" Then
                    cDescTipta = cDescTipta & Chr(10) & Chr(10) & "Se entenderá por tasa TIIP (Tasa de Interés Interbancaria Promedio) la tasa de rendimiento anual, equivalente a 28 días, que sea o sean "
                    cDescTipta = cDescTipta & "publicadas por el Banco de México en el Diario Oficial de la Federación, vigente al inicio de cada periodo de intereses."
                End If
                If cTipta = "1" Or cTipta = "2" Or cTipta = "6" Or cTipta = "4" Then
                    cDescTipta = cDescTipta & Chr(10) & Chr(10) & "Se entenderá por tasa TIIE (Tasa de Interés Interbancaria de Equilibrio) la tasa de rendimiento anual, equivalente a 28 días, "
                    cDescTipta = cDescTipta & "que sea o sean publicadas por el Banco de México en el Diario Oficial de la Federación, vigente al inicio de cada periodo "
                    cDescTipta = cDescTipta & "de intereses."
                End If
                If cTipta <= "6" Then
                    cDescTipta = cDescTipta & Chr(10) & Chr(10) & "Los intereses siempre se computarán sobre la base de un año de 360 (trescientos sesenta) días por el número de días "
                    cDescTipta = cDescTipta & "efectivamente transcurridos."
                End If
                If cForca = "4" Then
                    cDescTipta = cDescTipta & Chr(10) & Chr(10) & "Para la determinaci¢n mensual del DIFERENCIAL aplicable a partir del segundo vencimiento, se multiplicar  la Tasa "
                    cDescTipta = cDescTipta & "Promedio M xima vigente en ese mes, por el factor de " & FormatNumber(nFactor, 2).ToString & Cant_Letras(nFactor, "")
                    cDescTipta = cDescTipta & "El resultado de la operaci¢n anterior ser  el DIFERENCIAL aplicable mismo que no podr  ser menor a "
                    cDescTipta = cDescTipta & FormatNumber(nPiso, 2).ToString & " " & Cant_Letras(nPiso, "") & " puntos porcentuales ni mayor a "
                    cDescTipta = cDescTipta & FormatNumber(nTecho, 2) & " " & Cant_Letras(nTecho, "") & "puntos porcentuales. A lo dispuesto en este p rrafo le "
                    cDescTipta = cDescTipta & "ser  aplicable lo establecido en la cláusula cuarta del Contrato de Arrendamiento Financiero No. "
                    cDescTipta = cDescTipta & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)
                End If
            End If
            If cTipta = "8" Then
                cDescTipta = cDescTipta & Chr(10) & Chr(10) & "Las rentas estipuladas en este anexo podrán aumentar o disminuir de acuerdo a lo establecido en la cláusula cuarta del Contrato "
                cDescTipta = cDescTipta & "de Arrendamiento Financiero celebrado entre las partes, en el entendido de que para el cálculo de la primera renta se toma "
                cDescTipta = cDescTipta & "como base la tasa de rendimiento neto que resulte de adicionar " & FormatNumber(nDifer, 2).ToString & " " & Cant_Letras(nDifer, "") & " puntos"
                cDescTipta = cDescTipta & "porcentuales al valor de la tasa TIIE la cual tendrá un valor máximo de " & FormatNumber(12, 2).ToString & " porciento anual.  Se entender  por tasa TIIE (Tasa de Interés Interbancaria de "
                cDescTipta = cDescTipta & "Equilibrio) la tasa de rendimiento anual, equivalente a 28 días, que sea o sean publicadas por el Banco de M‚xico en el Diario "
                cDescTipta = cDescTipta & "Oficial de la Federación, vigente al inicio de cada periodo de intereses."
            End If

            If nImpRD > 0 Then
                cDescDepGar = "VI.- DEPOSITO EN GARANTIA :"
                cDescDepGar = cDescDepGar & Chr(10) & Chr(10) & "Conforme a la cláusula decima primera del Contrato de Arrendamiento Financiero, la ARRENDATARIA entrega en el acto de firma del presente anexo, la cantidad de " & FormatNumber(nImpRD) & Letras(nImpRD)
                cDescDepGar = cDescDepGar & Chr(10) & Chr(10) & "En caso de que la ARRENDADORA tuviera que aplicar dicha cantidad de acuerdo a lo establecido en la cláusula antes citada, la ARRENDATARIA deberá resarcirla con la cantidad equivalente a la última parcialidad que debió haber pagado."
            End If


            oRuta = DocCopiaLocal("F:\CS\Anexo_A.doc", 2)

            oWordDoc = New Microsoft.Office.Interop.Word.Document()

            ' Cargo la plantilla

            oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

            If cTipar = "S" Then
                With oWordDoc.Sections(1)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                    If Round(nMtoFin / nUdi, 2) < nVMUdi Then
                        If bLiquidez = True Then
                            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029254/01-01329-0318 ")
                            cReca = "1907-439-029254/01-01329-0318 "
                        Else
                            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318 ")
                            cReca = "1907-439-029236/01-01233-0318 "
                        End If
                    End If
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "ANEXO A del Contrato No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
                End With
            End If

            For Each myMField In oWordDoc.Fields

                rFieldCode = myMField.Code

                cFieldText = rFieldCode.Text

                If cFieldText.StartsWith(" MERGEFIELD") Then

                    ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo únicamente

                    finMerge = cFieldText.IndexOf("\")

                    fieldNameLen = cFieldText.Length - finMerge

                    cfName = cFieldText.Substring(11, finMerge - 11)

                    ' Guardamos el nombre del campo en la variable, quitándole los espacios en blanco

                    cfName = cfName.Trim()

                    ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                    ' y si es asi le aplicamos el valor de la variable

                    Select Case cfName

                        Case "mContrato"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4))
                        Case "mDescr"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cCusnam)
                        Case "mRepresentante"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cRepresentante)
                        Case "mCoac"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cCoac
                        Case "mAval"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cAval.ToUpper
                        Case "mFirmaCte"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaCte.ToUpper
                        Case "mFirmaAval1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval1.ToUpper
                        Case "mFirmaAval2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval2.ToUpper
                        Case "mFirmaAval3"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval3.ToUpper
                        Case "mFirmaAval4"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval4.ToUpper
                        Case "mObSol"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cObSol
                        Case "mObSol1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cObSol1
                        Case "mFecha"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Mes(cFechacon)
                        Case "mDescTipta"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDescTipta
                        Case "mLugar"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cLugar
                        Case "mBienes"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cBienes
                        Case "mBienes2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cBienes2
                        Case "mRefCliente"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRefCliente
                        Case "mRefProdgral"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRefProdgral
                        Case "mRefProducto"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRefProducto
                        Case "mLetrast"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cLetrat
                        Case "mFevent"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFevent
                        Case "mSaldot"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cSaldot
                        Case "mAbcapt"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cAbcapt
                        Case "mIntert"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cIntert
                        Case "mIvat"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cIvat
                        Case "mIvacapt"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cIvaCapt
                        Case "mPagomen"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cPagomen
                        Case "mCobertt2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cCobert
                        Case "mTotg"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cTotg
                        Case "mTotal"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cFondeo = "03" Then
                                myMField.Result.Text = FormatNumber(nTotal + nTotalCobert + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal + nTotalCobert + nGtotaliva + nGtotalivacap) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & " más Iva Interés por " & FormatNumber(nGtotaliva, 2).ToString & " más Iva Capital por " & FormatNumber(nGtotalivacap, 2).ToString & FormatNumber(nTotal - nMtoFin, 2).ToString & " más su Cobertura por " & FormatNumber(nTotalCobert, 2).ToString
                                If cTipar = "P" Then
                                    myMField.Result.Text = FormatNumber(nTotal, 2).ToString & Letras(nTotal)
                                Else
                                    myMField.Result.Text = FormatNumber(nTotal + nTotalCobert + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal + nTotalCobert + nGtotaliva + nGtotalivacap)
                                End If
                            Else
                                myMField.Result.Text = FormatNumber(nTotal + nCobertura + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal + nCobertura + nGtotaliva + nGtotalivacap) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & FormatNumber(nTotal - nMtoFin, 2).ToString & " más Iva Interés por " & FormatNumber(nGtotaliva, 2).ToString & " más Iva Capital por " & FormatNumber(nGtotalivacap, 2).ToString
                                If cTipar = "P" Then
                                    myMField.Result.Text = FormatNumber(nTotal, 2).ToString & Letras(nTotal)
                                Else
                                    myMField.Result.Text = FormatNumber(nTotal + nCobertura + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal + nCobertura + nGtotaliva + nGtotalivacap)
                                End If
                            End If
                        Case "mImpEq"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = FormatNumber(nImpEq).ToString & " " & Letras(nImpEq)
                        Case "mSaldo"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = FormatNumber(nSaldo).ToString & " " & Letras(nSaldo)
                        Case "mProducto"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cProducto
                        Case "mProduc"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cFondeo = "03" Then
                                myMField.Result.Text = Mid(cProducto, 1, cProducto.Length - 18)
                            Else
                                myMField.Result.Text = cProducto
                            End If
                        Case "mImpDG"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = FormatNumber(nDepg, 2).ToString
                        Case "mIvaEq"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = FormatNumber(nIvaEq, 2).ToString & " " & Letras(nIvaEq)
                        Case "mComis"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = FormatNumber(nComis / (1 + nPorInt), 2).ToString
                        Case "mIvaComis"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = FormatNumber((nComis / (1 + nPorInt)) * nPorInt)
                        Case "mOpcion"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = FormatNumber(nOpcion) & Letras(nOpcion)
                        Case "mTotal2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cFondeo = "03" Then
                                myMField.Result.Text = FormatNumber(nTotal2 + nTotalCobert + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal2 + nTotalCobert + nGtotaliva + nGtotalivacap) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & " más Iva Interés por " & FormatNumber(nGtotaliva, 2).ToString & " más Iva Capital por " & FormatNumber(nGtotalivacap, 2).ToString & FormatNumber(nTotal2 - nMtoFin, 2).ToString & " más su Cobertura por " & FormatNumber(nTotalCobert, 2).ToString
                                If cTipar = "P" Then
                                    myMField.Result.Text = FormatNumber(nTotal2 + nTotalCobert + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal2 + nTotalCobert + nGtotaliva + nGtotalivacap)
                                End If
                            Else
                                myMField.Result.Text = FormatNumber(nTotal2 + nCobertura + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal2 + nCobertura + nGtotaliva + nGtotalivacap) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & FormatNumber(nTotal2 - nMtoFin, 2).ToString & " más Iva Interés por " & FormatNumber(nGtotaliva, 2).ToString & " más Iva Capital por " & FormatNumber(nGtotalivacap, 2).ToString
                                If cTipar = "P" Then
                                    myMField.Result.Text = FormatNumber(nTotal2 + nCobertura + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal2 + nCobertura + nGtotaliva + nGtotalivacap)
                                End If
                            End If
                        Case "mFeven"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFvenc
                        Case "mFevig"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Mes(cFevig)
                        Case "mTermino"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Mes(cFecha1)
                        Case "mTipar"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cProducto
                        Case "mTasas"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Round(nTasas, 2)
                        Case "mTasmor"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Round(nTasas * nTasmor, 2) & " " & Cant_Letras(Round(nTasas * nTasmor, 2), "")
                        Case "mTaspen"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Round(nTaspen, 2)
                        Case "mDescPI"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDescPI
                        Case "mImpPI"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cImpPI
                        Case "mDiaPago"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDiaPago
                        Case "mDescFrecuencia"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDescFrecuencia
                        Case "mDescDepGar"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDescDepGar
                        Case "mUnidadEsp"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cUnidadEsp
                        Case "mCAT"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Round(nCAT, 1).ToString & "%"
                        Case "mTipta"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cDescTasa) & " "
                        Case "mPersonaAut"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cPersonaAut
                    End Select

                    oWord.Selection.Fields.Update()

                End If

            Next

            'Guardo el documento

            Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
            Dim oMissing = System.Reflection.Missing.Value

            Dim oSaveAsFile = "C:\contratos\" & Trim(cCusnam) & "_A_" & cContrato & ".doc"

            Try
                oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
                oWordDoc.Close()
                oWord.Quit()
                Process.Start(oSaveAsFile)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                oWordDoc.Close(SaveChanges:=False)
                oWord.Quit(SaveChanges:=False)
            End Try
            Cursor.Current = Cursors.Default
        Else
            MsgBox("El Anexo A no Aplica en Crédito Simple", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btnAnexoB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnexoB.Click

        If cTipar <> "S" Then

            Dim oNulo As Object = System.Reflection.Missing.Value
            Dim oRuta As New Object
            Dim myMField As Microsoft.Office.Interop.Word.Field
            Dim rFieldCode As Microsoft.Office.Interop.Word.Range
            Dim cFieldText As String
            Dim finMerge As Integer
            Dim fieldNameLen As Integer
            Dim cfName As String
            Dim oWord As New Word.Application
            Dim oWordDoc As Microsoft.Office.Interop.Word.Document


            oRuta = DocCopiaLocal("F:\CS\Anexo_B.doc", 2)

            oWordDoc = New Microsoft.Office.Interop.Word.Document()

            ' Cargo la plantilla

            oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

            If cTipar = "S" Then
                With oWordDoc.Sections(1)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                    If Round(nMtoFin / nUdi, 2) < nVMUdi Then
                        If bLiquidez = True Then
                            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029254/01-01329-0318 ")
                            cReca = "1907-439-029254/01-01329-0318 "
                        Else
                            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318 ")
                            cReca = "1907-439-029236/01-01233-0318 "
                        End If
                    End If
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "ANEXO B del Contrato No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
                End With
            End If

            ' Abro el Contrato

            For Each myMField In oWordDoc.Fields

                rFieldCode = myMField.Code

                cFieldText = rFieldCode.Text

                If cFieldText.StartsWith(" MERGEFIELD") Then

                    ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo únicamente

                    finMerge = cFieldText.IndexOf("\")

                    fieldNameLen = cFieldText.Length - finMerge

                    cfName = cFieldText.Substring(11, finMerge - 11)

                    ' Guardamos el nombre del campo en la variable, quitándole los espacios en blanco

                    cfName = cfName.Trim()

                    ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                    ' y si es asi le aplicamos el valor de la variable

                    Select Case cfName

                        Case "mDescr"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cCusnam)
                        Case "mRepresentante"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cRepresentante)
                        Case "mCoac"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cCoac
                        Case "mFirmaCte"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaCte.ToUpper
                        Case "mFirmaAval1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval1.ToUpper
                        Case "mFirmaAval2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval2.ToUpper
                        Case "mFirmaAval3"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval3.ToUpper
                        Case "mFirmaAval4"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval4.ToUpper
                        Case "mObSol"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cObSol
                        Case "mObSol1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cObSol1
                        Case "mFecha"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Mes(cFechacon)
                        Case "mRefProdgral"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRefProdgral
                        Case "mRefProducto"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRefProducto
                        Case "mRefCliente"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRefCliente
                        Case "mAval"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cAval
                        Case "mProducto"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cProducto
                        Case "mBienes"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cBienes
                        Case "mPersonaAut"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cPersonaAut
                    End Select

                    oWord.Selection.Fields.Update()

                End If

            Next

            'Guardo el documento

            Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
            Dim oMissing = System.Reflection.Missing.Value

            Dim oSaveAsFile = "C:\contratos\" & Trim(cCusnam) & "_B_" & cContrato & ".doc"

            Try
                oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
                oWordDoc.Close()
                oWord.Quit()
                Process.Start(oSaveAsFile)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                oWordDoc.Close(SaveChanges:=False)
                oWord.Quit(SaveChanges:=False)
            End Try
            Cursor.Current = Cursors.Default
        Else
            MsgBox("El Anexo B no Aplica en Crédito Simple", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btnAnexoC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnexoC.Click

        If cPrenda = "S" Then

            Dim oNulo As Object = System.Reflection.Missing.Value
            Dim oRuta As New Object
            Dim myMField As Microsoft.Office.Interop.Word.Field
            Dim rFieldCode As Microsoft.Office.Interop.Word.Range
            Dim cFieldText As String
            Dim finMerge As Integer
            Dim fieldNameLen As Integer
            Dim cfName As String
            Dim oWord As New Word.Application
            Dim oWordDoc As Microsoft.Office.Interop.Word.Document


            oRuta = DocCopiaLocal("F:\CS\Anexo_C.doc", 2)

            oWordDoc = New Microsoft.Office.Interop.Word.Document()

            ' Cargo la plantilla

            oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

            If cTipar = "S" Then
                With oWordDoc.Sections(1)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                    If Round(nMtoFin / nUdi, 2) < nVMUdi Then
                        If bLiquidez = True Then
                            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029254/01-01329-0318 ")
                            cReca = "1907-439-029254/01-01329-0318 "
                        Else
                            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318 ")
                            cReca = "1907-439-029236/01-01233-0318 "
                        End If
                    End If
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "ANEXO C del Contrato No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
                End With
            End If

            ' Abro el Contrato

            For Each myMField In oWordDoc.Fields

                rFieldCode = myMField.Code

                cFieldText = rFieldCode.Text

                If cFieldText.StartsWith(" MERGEFIELD") Then

                    ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo únicamente

                    finMerge = cFieldText.IndexOf("\")

                    fieldNameLen = cFieldText.Length - finMerge

                    cfName = cFieldText.Substring(11, finMerge - 11)

                    ' Guardamos el nombre del campo en la variable, quitándole los espacios en blanco

                    cfName = cfName.Trim()

                    ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                    ' y si es asi le aplicamos el valor de la variable

                    Select Case cfName

                        Case "mDescr"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cCusnam)
                        Case "mRepresentante"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cRepresentante)
                        Case "mCoac"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cCoac
                        Case "mFirmaCte"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaCte.ToUpper
                        Case "mFirmaAval1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval1.ToUpper
                        Case "mFirmaAval2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval2.ToUpper
                        Case "mFirmaAval3"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval3.ToUpper
                        Case "mFirmaAval4"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval4.ToUpper
                        Case "mObSol"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cObSol
                        Case "mObSol1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cObSol1
                        Case "mTitulo1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cTitulo1
                        Case "mGeneClie"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Chr(10) & "DECLARA EL DEUDOR PRENDARIO " & cGeneClie.ToUpper
                        Case "mRefProdgral"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRefProdgral
                        Case "mRefCliente"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRefCliente
                        Case "mAval"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cAval
                        Case "mProducto"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cProducto
                        Case "mDato7"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDato7
                        Case "mCoac2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cCoac2
                        Case "mDato8"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDato8
                        Case "mDato9"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDato9
                        Case "mDato10"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDato10
                        Case "mCalle"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cCalle
                        Case "mColonia"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cColonia
                        Case "mCopos"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cCopos)
                        Case "mDelegacion"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cDelegacion)
                        Case "mEstado"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cEstado)
                        Case "mDescPrenda"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDescPrenda
                    End Select

                    oWord.Selection.Fields.Update()

                End If

            Next

            'Guardo el documento

            Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
            Dim oMissing = System.Reflection.Missing.Value

            Dim oSaveAsFile = "C:\contratos\" & Trim(cCusnam) & "_C_" & cContrato & ".doc"
            Try
                oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
                oWordDoc.Close()
                oWord.Quit()
                Process.Start(oSaveAsFile)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                oWordDoc.Close(SaveChanges:=False)
                oWord.Quit(SaveChanges:=False)
            End Try
            Cursor.Current = Cursors.Default
        Else
            MsgBox("Este contrato No tiene Garantía prendaria", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btnRatif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRatif.Click

        Dim dsTemporal As New DataSet()
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim drAnexo As DataRow
        Dim drTotal As DataRow
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document

        ' Declaración de variables de datos

        Dim cFeven As String
        Dim nCount As Integer
        'Dim RutaApp As String = ""
        'If Directory.Exists("c:\program files (x86)\") Then
        '    RutaApp = "c:\program files (x86)\"
        'Else
        '    RutaApp = "C:\Archivos de programa\"
        'End If

        dsTemporal.ReadXml("C:\Contratos\Schema2.xml")

        drAnexo = dsTemporal.Tables("Contrato").Rows(0)

        If Trim(drAnexo("Nomrepr")) <> "" Or Trim(drAnexo("Nomrepr2")) <> "" Then
            If LTrim(drAnexo("Nomrepr2")) <> "" Then
                cRepresentante = "REPRESENTADA EN ESTE ACTO POR " & LTrim(drAnexo("Nomrepr")) & " Y POR " & LTrim(drAnexo("Nomrepr2"))
            Else
                cRepresentante = "REPRESENTADA EN ESTE ACTO POR " & LTrim(drAnexo("Nomrepr"))
            End If
        End If

        If drAnexo("Coac") = "C" Then
            If Trim(drAnexo("Nomrcoac")) <> "" And (drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P") Then
                cCoac = " Y " & drAnexo("Nomcoac") & " COMO COARRENDATARIO REPRESENTADA POR " & drAnexo("Nomrcoac")
            ElseIf Trim(drAnexo("Nomcoac")) <> "" And (drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P") Then
                cCoac = " Y " & drAnexo("Nomcoac") & " COMO COARRENDATARIO "
            ElseIf Trim(drAnexo("Nomrcoac")) <> "" And (drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S") Then
                cCoac = " Y " & drAnexo("Nomcoac") & " COMO COACREDITADO REPRESENTADA POR " & drAnexo("Nomrcoac")
            ElseIf Trim(drAnexo("Nomcoac")) <> "" And (drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S") Then
                cCoac = " Y " & drAnexo("Nomcoac") & " COMO COACREDITADO "
            End If
        End If

        oRuta = DocCopiaLocal("F:\CS\RATIFICACION.doc", 2)

        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantillatR

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        If cTipar = "S" Then
            With oWordDoc.Sections(1)
                .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                If Round(nMtoFin / nUdi, 2) < nVMUdi Then
                    If bLiquidez = True Then
                        .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029254/01-01329-0318 ")
                        cReca = "1907-439-029254/01-01329-0318 "
                    Else
                        .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318 ")
                        cReca = "1907-439-029236/01-01233-0318 "
                    End If
                End If
                .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "RATIFICACION DEL CONTRATO DE CREDITO SIMPLE No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
            End With
        End If

        ' Abro el Contrato

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo únicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quitándole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable

                Select Case cfName

                    Case "mContrato"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4))
                    Case "mDescr"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCusnam)
                    Case "mRepresentante"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cRepresentante)
                    Case "mCoac"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCoac
                    Case "mFirmaCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaCte.ToUpper
                    Case "mFirmaAval1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval1.ToUpper
                    Case "mFirmaAval2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval2.ToUpper
                    Case "mFirmaAval3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval3.ToUpper
                    Case "mFirmaAval4"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval4.ToUpper
                    Case "mObSol"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cObSol
                    Case "mObSol1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cObSol1
                    Case "mFecha"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFechacon)
                    Case "mLugar"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLugar
                    Case "mNotario"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cNotario
                    Case "mRefProdgral"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRefProdgral
                    Case "mRefCliente"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRefCliente
                    Case "mAval"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cAval
                    Case "mProducto"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cProducto
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
        Dim oMissing = System.Reflection.Missing.Value

        Dim oSaveAsFile = "C:\contratos\" & Trim(cCusnam) & "_RAT_" & cContrato & ".doc"
        Try
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try
        Cursor.Current = Cursors.Default

    End Sub

    Private Function AcumulaSdo(ByVal cAnexo As String, ByVal cFecha As String) As Decimal

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daSaldos As New SqlDataAdapter(cm1)
        Dim drDato As DataRow

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DameAnexo1"
            .Connection = cnAgil
            .Parameters.Add("@cAnexo", SqlDbType.NVarChar)
            .Parameters.Add("@cFecha", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
            .Parameters(1).Value = cFecha
        End With

        daSaldos.Fill(dsAgil, "Anexo")
        If dsAgil.Tables("Anexo").Rows.Count > 0 Then
            drDato = dsAgil.Tables("Anexo").Rows(0)
            AcumulaSdo += drDato("Saldo")
        End If
        dsAgil.Tables.Remove("Anexo")

        dsAgil = Nothing
        cnAgil.Dispose()
        cm1.Dispose()

    End Function

    Private Sub TraeDatos()
        ' Declaración de variables de conexión ADO .NET
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim cm5 As New SqlCommand()
        Dim cm6 As New SqlCommand()
        Dim cm7 As New SqlCommand()
        Dim cm8 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daDatoscon As New SqlDataAdapter(cm1)
        Dim daAnexo As New SqlDataAdapter(cm2)
        Dim daEdoctav As New SqlDataAdapter(cm3)
        Dim daTabla As New SqlDataAdapter(cm4)
        Dim daSaldo As New SqlDataAdapter(cm5)
        Dim daRentas As New SqlDataAdapter(cm6)
        Dim daDomi As New SqlDataAdapter(cm7)
        Dim daUdi As New SqlDataAdapter(cm8)
        Dim drAnexo As DataRow
        Dim drRiesgo As DataRow
        Dim drRentas As DataRow
        Dim drTabla As DataRow
        Dim drEquipo As DataRow
        Dim drEdoctav As DataRow
        Dim drUdi As DataRow
        Dim drAnexos As DataRowCollection
        Dim drRiesgos As DataRowCollection
        Dim dtRiesgo As New Data.DataTable("Riesgo")

        ' Declaración de variables de datos

        Dim cFecha As String
        Dim cFeven As String
        Dim cFven1 As String
        Dim cPlaza As String
        Dim cDomi As String
        Dim nCount As Integer
        Dim nPanual As Integer
        Dim nTIR As Decimal
        Dim nDato2 As Decimal
        Dim i As Integer
        Dim P As Integer
        'CIERRA LA PANTALLA SI NO PUEDE EMITIR CONTRATOS
        Try
            If Directory.Exists("C:\Contratos\") = False Then
                Directory.CreateDirectory("C:\Contratos\")
            End If
            dsAgil.WriteXml("C:\Contratos\Schema2.xml", XmlWriteMode.WriteSchema)

        Catch ex As Exception
            MessageBox.Show("Error de permisos en carpetas del sistema, favor de contactar a su area de sistemas.", "Error Contratos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show(ex.Message, "Error Contratos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
            Exit Sub
        End Try

        myIdentity = GetCurrent()
        cUsuario = myIdentity.Name

        'Dim RutaApp As String = ""
        'If Directory.Exists("c:\program files (x86)\") Then
        '    RutaApp = "c:\program files (x86)\"
        'Else
        '    RutaApp = "C:\Archivos de programa\"
        'End If

        cContrato = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)
        TxtContMarco.Text = SacaContratoMarcoLargo(0, cContrato)
        cFecha = DTOC(Today)

        ' Obtengo los Datos Generales del Contrato

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DatosCon2"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cContrato
        End With

        daDatoscon.Fill(dsAgil, "Contrato")
        drAnexos = dsAgil.Tables("Contrato").Rows

        With cm8
            .CommandType = CommandType.Text
            .CommandText = "SELECT Udi FROM Udis WHERE Vigencia = " & cFecha
            .Connection = cnAgil
        End With
        daUdi.Fill(dsAgil, "Udi")
        If dsAgil.Tables("Udi").Rows.Count <= 0 Then
            MessageBox.Show("Falta capturar Udis, favor de reportar a tesoreria.", "UDIS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Else
            drUdi = dsAgil.Tables("Udi").Rows(0)
            nUdi = drUdi("Udi")
        End If

        For Each drAnexo In drAnexos
            cAnexo = drAnexo("Anexo")
            cFondeo = drAnexo("Fondeo")
            cFlcan = drAnexo("Flcan")
            cCusnam = drAnexo("Cusnam")
            cCliente = drAnexo("Cliente")
            cFechacon = drAnexo("Fechacon")
            cPrenda = drAnexo("Prenda")
            cGHipotec = drAnexo("GHipotec")
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cForca = drAnexo("Forca")
            cPlaza = drAnexo("Plaza")
            cSoli = drAnexo("Solicitud")
            cDescTasa = drAnexo("DescTasa")
            cCalle = drAnexo("Calle")
            nRD = drAnexo("RD")
            nDG = drAnexo("DG")
            cColonia = drAnexo("Colonia")
            cCopos = drAnexo("Copos")
            cDelegacion = drAnexo("Delegacion")
            cDescFrecuencia = "como se indica en la Tabla de Amortización"
            cDescRecurso = drAnexo("DescRecurso")
            cEstado = drAnexo("Estado")
            cTelefono = drAnexo("Telef1")
            cFax = drAnexo("Fax")
            cRfc = drAnexo("RFC")
            cSucursal = drAnexo("Sucursal")
            cPromo = drAnexo("DescPromotor")
            cDomi = drAnexo("Autoriza")
            dTermino = Termina(cAnexo)
            cTermino = DTOC(dTermino)
            nPlazo = drAnexo("Plazo")
            nAmorin = drAnexo("Amorin")
            nIvaAmorin = drAnexo("IvaAmorin")
            nMensu = drAnexo("Mensu")
            nComis = drAnexo("Comis")
            nDepg = drAnexo("ImpDG")
            nMtoFin = drAnexo("Impeq") - (drAnexo("Ivaeq") + drAnexo("Amorin"))
            nSaldo = drAnexo("Impeq") - drAnexo("Ivaeq") - drAnexo("Amorin")
            nDepNafin = drAnexo("DepNafin")
            cFvenc = Mes(drAnexo("Fvenc"))
            nTasas = drAnexo("Tasas") + drAnexo("Difer")
            nDifer = drAnexo("Difer")
            nImpRD = drAnexo("Imprd")
            nTasmor = drAnexo("Tasmor")
            nTaspen = drAnexo("Taspen")
            nOpcion = drAnexo("Opcion")
            nImpRD = drAnexo("ImpRD")
            nIvaDepg = drAnexo("IvaRD")
            nIvaEq = drAnexo("Ivaeq")
            nIvaRtaD = drAnexo("IvaDG")
            nDerechos = drAnexo("Derechos")
            nNafin = drAnexo("DepNafin")
            nGastos = drAnexo("Gastos")
            nIvaGastos = drAnexo("Ivagastos")
            nLinau = drAnexo("Linau")
            nImpEq = drAnexo("Impeq")
            nPorop = drAnexo("Porop")
            nPorco = drAnexo("Porco")
            ' nPorInt = drAnexo("PorInt")
            nRtas = drAnexo("Rtasd")
            nFondoReserva = drAnexo("FondoReserva")
            cFecre = drAnexo("Fecre")
            cFeaut = drAnexo("Feaut")
            cFevig = drAnexo("Fevig")
            nServicio = drAnexo("Servicio")
            nIVAServicio = drAnexo("IVAServicio")
            cAplicaCobertura = drAnexo("Cobertura")
            bLiquidez = drAnexo("LiquidezInmediata")
            cEmpresa = drAnexo("CNEmpresa")
            cPlanta = drAnexo("CNPlanta")
            nAmortizaciones = drAnexo("Amortizaciones")
            cSegVida = drAnexo("SegVida")
            cAutomovil = drAnexo("Automovil")
            cDescPrenda = IIf(IsDBNull(drAnexo("DescPrenda")), "", drAnexo("DescPrenda"))
            nPorcFEGA = drAnexo("PorcFega")
            PorcReserva = drAnexo("PorcReserva")
            If nPorcFEGA = 0 Then
                If cSucursal = "03" Or cSucursal = "04" Then
                    nPorcFEGA = PORC_FEGA_NORTE_TRA
                Else
                    nPorcFEGA = PORC_FEGA_TRA
                End If
            End If
        Next

        If bLiquidez = True Then
            BtnCarta.Enabled = True
            BtnAdenda.Enabled = True
        Else
            BtnCarta.Enabled = False
            BtnAdenda.Enabled = False
        End If
        If cTipar = "B" And nMensu = 0 Then
            MessageBox.Show("El contrato FULL SERVICE No tiene cargada la mensualidad", "FULL SERVICE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
            Exit Sub
        End If
        nPorInt = 16
        nPorInt = nPorInt / 100

        If Trim(cPromo) = "ING. FRANCISCO KOSO WAKIDA SUZUKI" Then
            cEjecu = "SUBGERENTE DE AGRONEGOCIOS"
        Else
            cEjecu = "EJECUTIVO DE CUENTA"
        End If

        If drAnexo("Tipo") = "M" And Trim(drAnexo("Nomrepr")) <> "" Then
            cPersonaAut = cCusnam & " por conducto de su representante legal " & drAnexo("Nomrepr")
        Else
            cPersonaAut = cCusnam
        End If

        If drAnexo("Tipo") = "M" And Trim(drAnexo("Nomrepr")) <> "" Then
            cTitulo1 = "por conducto de su representante que:"
        Else
            cTitulo1 = "por su propio derecho:"
        End If

        If Mid(drAnexo("Geneclie"), 1, 2) = "A)" Then
            cGeneClie = drAnexo("GeneClie") & Chr(10)
        ElseIf Mid(drAnexo("Geneclie"), 1, 2) = "a)" Then
            cGeneClie = drAnexo("GeneClie") & Chr(10)
        Else
            cGeneClie = drAnexo("GeneClie") & Chr(10)
        End If

        If drAnexo("Tipo") = "M" Then
            cDato7 = Chr(10) & Chr(10) & "B) Su representante cuenta con facultades suficientes y declara que: "
            cDato7 = cDato7 & Chr(10) + Chr(10) & drAnexo("Generepr")
            cDato7 = cDato7 & Chr(10) & Chr(10) & drAnexo("Poderepr")
            If drAnexo("Nomrepr2") <> "" Then
                cDato7 = Chr(10) & Chr(10) & "Su segundo representante " & drAnexo("Nomrepr2") & " quien manifiesta"
                cDato7 = cDato7 & Chr(10) & Chr(10) & drAnexo("Poderep2")
            End If
        End If

        If drAnexo("Coac") = "C" And drAnexo("Tipcoac") = "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
            If drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P" Then
                cDato8 = Chr(10) & Chr(10) & "DECLARA EL COARRENDATARIO por conducto de su representante que:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            ElseIf drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S" Then
                cDato8 = Chr(10) & Chr(10) & "DECLARA EL COACREDITADO por conducto de su representante que:" & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            End If
            cDato8 = cDato8 & Chr(10) & Chr(10) & drAnexo("Podercoa")
        ElseIf drAnexo("Coac") = "C" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomrcoac")) = "" Then
            If drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P" Then
                cDato8 = Chr(10) & Chr(10) & "DECLARA EL COARRENDATARIO por su propio derecho:" & drAnexo("GeneCoac")
            ElseIf drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S" Then
                cDato8 = Chr(10) & Chr(10) & "DECLARA EL COACREDITADO por su propio derecho:" & drAnexo("GeneCoac")
            End If
        ElseIf drAnexo("Coac") = "S" And drAnexo("Tipcoac") = "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
            cDato8 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL por conducto de su representante que:" & drAnexo("GeneCoac")
            cDato8 = cDato8 & Chr(10) & Chr(10) & drAnexo("Podercoa")
        ElseIf drAnexo("Coac") = "S" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomrcoac")) = "" Then
            cDato8 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & drAnexo("GeneCoac")
        End If

        If Trim(drAnexo("Nomrepr")) <> "" Or Trim(drAnexo("Nomrepr2")) <> "" Then
            If LTrim(drAnexo("Nomrepr2")) <> "" Then
                cRepresentante = "REPRESENTADA EN ESTE ACTO POR " & LTrim(drAnexo("Nomrepr")) & " Y POR " & LTrim(drAnexo("Nomrepr2"))
                cGenerepr = " como representante legal " & LTrim(drAnexo("Nomrepr")) & " quien manifiesta " & drAnexo("Generepr") & " y por " & LTrim(drAnexo("Nomrepr2")) & " quien manifiesta " & drAnexo("Generep2")
            Else
                cRepresentante = "REPRESENTADA EN ESTE ACTO POR " & LTrim(drAnexo("Nomrepr"))
                cGenerepr = " como representante legal " & LTrim(drAnexo("Nomrepr")) & " quien manifiesta " & drAnexo("Generepr")
            End If
        End If

        If drAnexo("Coac") = "C" Then
            If Trim(drAnexo("Nomrcoac")) <> "" And (drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P") Then
                cCoac = " Y " & drAnexo("Nomcoac") & " COMO COARRENDATARIO REPRESENTADA POR " & drAnexo("Nomrcoac")
            ElseIf Trim(drAnexo("Nomcoac")) <> "" And (drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P") Then
                cCoac = " Y " & drAnexo("Nomcoac") & " COMO COARRENDATARIO "
            ElseIf Trim(drAnexo("Nomrcoac")) <> "" And (drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S") Then
                cCoac = " Y " & drAnexo("Nomcoac") & " COMO COACREDITADO REPRESENTADA POR " & drAnexo("Nomrcoac")
            ElseIf Trim(drAnexo("Nomcoac")) <> "" And (drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S") Then
                cCoac = " Y " & drAnexo("Nomcoac") & " COMO COACREDITADO "
            End If
        End If

        If drAnexo("Coac") = "S" Or drAnexo("obli") = "S" Or drAnexo("Aval1") = "S" Or drAnexo("Aval2") = "S" Then
            If drAnexo("Coac") = "S" Then
                If LTrim(drAnexo("Nomrcoac")) <> "" Then
                    cAval1 = drAnexo("Nomcoac") & " REPRESENTADA POR " & drAnexo("Nomrcoac")
                    cAvalg1 = drAnexo("Nomcoac") & " REPRESENTADA POR " & drAnexo("Nomrcoac") & " quien manifiesta " & drAnexo("Genercoa")
                Else
                    cAval1 = drAnexo("Nomcoac")
                    cAvalg1 = drAnexo("Nomcoac") & " quien manifiesta " & drAnexo("Genecoac")
                End If
            End If

            If drAnexo("Obli") = "S" Then
                If LTrim(drAnexo("Nomrobl")) <> "" Then
                    cAval2 = drAnexo("Nomobli") & " REPRESENTADA POR " & drAnexo("Nomrobl")
                    cAvalg2 = drAnexo("Nomobli") & " REPRESENTADA POR " & drAnexo("Nomrobl") & " quien manifiesta " & drAnexo("Generobl")
                    cDato9 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & drAnexo("Nomobli") & " REPRESENTADA POR " & drAnexo("Nomrobl") & " quien manifiesta " & drAnexo("Generobl")
                Else
                    cAval2 = drAnexo("Nomobli")
                    cAvalg2 = drAnexo("Nomobli") & " quien manifiesta " & drAnexo("GeneObli")
                    cDato9 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & drAnexo("Nomobli") & " quien manifiesta " & drAnexo("GeneObli")
                End If
            End If

            If drAnexo("Aval1") = "S" Then
                If drAnexo("Tipaval1") = "M" And Trim(drAnexo("Nomrava1")) <> "" Then
                    cAval3 = drAnexo("Nomaval1") & " REPRESENTADA POR " & drAnexo("Nomrava1")
                    cAvalg3 = drAnexo("Nomaval1") & " REPRESENTADA POR " & drAnexo("Nomrava1") & " quien manifiesta " & drAnexo("Generav1")
                    cDato10 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & drAnexo("Nomaval1") & " REPRESENTADA POR " & drAnexo("Nomrava1") & " quien manifiesta " & drAnexo("Generav1")
                Else
                    cAval3 = drAnexo("Nomaval1")
                    cAvalg3 = drAnexo("Nomaval1") & " quien manifiesta " & drAnexo("Geneava1")
                    cDato10 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & drAnexo("Nomaval1") & " quien manifiesta " & drAnexo("Geneava1")
                End If
            End If

            If drAnexo("Aval2") = "S" Then
                If drAnexo("Tipaval2") = "M" And Trim(drAnexo("Nomrava2")) <> "" Then
                    cAval4 = drAnexo("Nomaval2") & " REPRESENTADA POR " & drAnexo("Nomrava2")
                    cAvalg4 = drAnexo("Nomaval2") & " REPRESENTADA POR " & drAnexo("Nomrava2") & " quien manifiesta " & drAnexo("Generav2")
                Else
                    cAval4 = drAnexo("Nomaval2")
                    cAvalg4 = drAnexo("Nomaval2") & " quien manifiesta " & drAnexo("Geneava2")
                End If
            End If
        End If

        If cAval1 = "" And cAval2 = "" And cAval3 = "" And cAval4 = "" Then
            cAval = ""
            cAvales = ""
        ElseIf cAval1 <> "" And cAval2 <> "" And cAval3 <> "" And cAval4 <> "" Then
            cAval = cAval1 & ", " & cAval2 & ", " & cAval3 & " Y " & cAval4
            cAvales = Chr(10) & Chr(10) & " sus avales " & Chr(10) & Chr(10) & cAvalg1 & Chr(10) & Chr(10) & cAvalg2 & Chr(10) & Chr(10) & cAvalg3 & " Y " & Chr(10) & Chr(10) & cAvalg4
        ElseIf cAval1 <> "" And cAval2 <> "" And cAval3 <> "" And cAval4 = "" Then
            cAval = cAval1 & ", " & cAval2 & " Y " & cAval3
            cAvales = Chr(10) & Chr(10) & " sus avales " & Chr(10) & Chr(10) & cAvalg1 & Chr(10) & Chr(10) & cAvalg2 & " Y " & Chr(10) & Chr(10) & cAvalg3
        ElseIf cAval1 <> "" And cAval2 <> "" And cAval3 = "" And cAval4 = "" Then
            cAval = cAval1 & " Y " & cAval2
            cAvales = Chr(10) & Chr(10) & " sus avales " & Chr(10) & Chr(10) & cAvalg1 & " Y " & Chr(10) & Chr(10) & cAvalg2
        ElseIf cAval1 <> "" And cAval2 = "" And cAval3 = "" And cAval4 = "" Then
            cAval = cAval1
            cAvales = Chr(10) & Chr(10) & " su aval " & Chr(10) & Chr(10) & cAvalg1
        ElseIf cAval1 <> "" And cAval2 <> "" And cAval3 = "" And cAval4 <> "" Then
            cAval = cAval1 & ", " & cAval2 & " Y " & cAval4
            cAvales = Chr(10) & Chr(10) & " sus avales " & Chr(10) & Chr(10) & cAvalg1 & Chr(10) & Chr(10) & cAvalg2 & " Y " & Chr(10) & Chr(10) & cAvalg4
        ElseIf cAval1 <> "" And cAval2 = "" And cAval3 <> "" And cAval4 <> "" Then
            cAval = cAval1 & ", " & cAval3 & " Y " & cAval4
            cAvales = Chr(10) & Chr(10) & " sus avales " & Chr(10) & Chr(10) & cAvalg1 & Chr(10) & Chr(10) & cAvalg3 & " Y " & Chr(10) & Chr(10) & cAvalg4
        ElseIf cAval1 <> "" And cAval2 = "" And cAval3 <> "" And cAval4 = "" Then
            cAval = cAval1 & " Y " & cAval3
            cAvales = Chr(10) & Chr(10) & " sus avales " & Chr(10) & Chr(10) & cAvalg1 & " Y " & Chr(10) & Chr(10) & cAvalg3
        ElseIf cAval1 <> "" And cAval2 = "" And cAval3 = "" And cAval4 <> "" Then
            cAval = cAval1 & " Y " & cAval4
            cAvales = Chr(10) & Chr(10) & " sus avales " & Chr(10) & Chr(10) & cAvalg1 & " Y " & Chr(10) & Chr(10) & cAvalg4
        ElseIf cAval1 = "" And cAval2 <> "" And cAval3 <> "" And cAval4 <> "" Then
            cAval = cAval2 & ", " & cAval3 & " Y " & cAval4
            cAvales = Chr(10) & Chr(10) & " sus avales " & Chr(10) & Chr(10) & cAvalg2 & Chr(10) & Chr(10) & cAvalg3 & " Y " & Chr(10) & Chr(10) & cAvalg4
        ElseIf cAval1 = "" And cAval2 <> "" And cAval3 <> "" And cAval4 = "" Then
            cAval = cAval2 & " Y " & cAval3
            cAvales = Chr(10) & Chr(10) & " sus avales " & Chr(10) & Chr(10) & cAvalg2 & " Y " & Chr(10) & Chr(10) & cAvalg3
        ElseIf cAval1 = "" And cAval2 <> "" And cAval3 = "" And cAval4 <> "" Then
            cAval = cAval2 & " Y " & cAval4
            cAvales = Chr(10) & Chr(10) & " sus avales " & Chr(10) & Chr(10) & cAvalg2 & " Y " & Chr(10) & Chr(10) & cAvalg4
        ElseIf cAval1 = "" And cAval2 <> "" And cAval3 = "" And cAval4 = "" Then
            cAval = cAval2
            cAvales = Chr(10) & Chr(10) & " su aval " & Chr(10) & Chr(10) & cAvalg2
        ElseIf cAval1 = "" And cAval2 = "" And cAval3 <> "" And cAval4 = "" Then
            cAval = cAval3
            cAvales = Chr(10) & Chr(10) & " su aval " & Chr(10) & Chr(10) & cAvalg3
        ElseIf cAval1 = "" And cAval2 = "" And cAval3 <> "" And cAval4 <> "" Then
            cAval = cAval3 & " Y " & cAval4
            cAvales = Chr(10) & Chr(10) & " sus avales " & Chr(10) & Chr(10) & cAvalg3 & " Y " & Chr(10) & Chr(10) & cAvalg4
        End If

        If cAval <> "" Then
            cObSol = " Y EN SU CARACTER DE OBLIGADO(S) SOLIDARIO(S) Y AVAL(ES) "
            cObSol1 = " A QUIEN(ES) EN LO SUCESIVO SE LE(S) DENOMINARA 'EL OBLIGADO SOLIDARIO Y AVAL' "
        End If

        If drAnexo("Tipo") = "F" Then
            cTipo = "PERSONA FISICA"
        ElseIf drAnexo("Tipo") = "E" Then
            cTipo = "PERSONA FISICA CON ACTIVIDAD EMPRESARIAL"
        ElseIf drAnexo("Tipo") = "M" Then
            cTipo = "PERSONA MORAL"
        End If


        If cFondeo = "03" Then
            cProducto = "CREDITO SIMPLE CON RECURSOS FIRA "
        Else
            cProducto = "CREDITO SIMPLE "
        End If


        cRefCliente = "ACREDITADA"
        cRefProducto = "CREDITO"
        cRefProdgral = "ACREDITANTE"

        If cTipar = "R" Then
            cTexto = "PAGO"
        Else
            cTexto = "RENTA"
        End If

        If drAnexo("Tipo") = "M" And Trim(drAnexo("Nomrepr")) <> "" Then
            cFirmaCte = cCusnam & Chr(10) & Chr(10) & ReplicateString("_", Len(drAnexo("Nomrepr")) + 6) & Chr(10) & drAnexo("Nomrepr") & Chr(10) & "APODERADO"
        Else
            cFirmaCte = Chr(10) & Chr(10) & ReplicateString("_", Len(cCusnam) + 6) & Chr(10) & cCusnam
        End If

        If drAnexo("TipCoac") = "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
            If drAnexo("Coac") = "C" Then
                If drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P" Then
                    cFirmaAval1 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "COARRENDATARIO" & Chr(10) & drAnexo("Nomcoac") & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(drAnexo("Nomrcoac")) + 6) & Chr(10) & drAnexo("Nomrcoac") & Chr(10) & "APODERADO"
                ElseIf drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S" Then
                    cFirmaAval1 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "COACREDITADO" & Chr(10) & drAnexo("Nomcoac") & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(drAnexo("Nomrcoac")) + 6) & Chr(10) & drAnexo("Nomrcoac") & Chr(10) & "APODERADO"
                End If
            Else
                cFirmaAval1 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(10) & drAnexo("Nomcoac") & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(drAnexo("Nomrcoac")) + 6) & Chr(10) & drAnexo("Nomrcoac") & Chr(10) & "APODERADO"
            End If
        ElseIf drAnexo("Coac") <> "N" Then
            If drAnexo("Coac") = "C" Then
                If drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P" Then
                    cFirmaAval1 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "COARRENDATARIO" & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(drAnexo("Nomcoac")) + 6) & Chr(10) & drAnexo("Nomcoac")
                ElseIf drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S" Then
                    cFirmaAval1 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "COACREDITADO" & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(drAnexo("Nomcoac")) + 6) & Chr(10) & drAnexo("Nomcoac")
                End If
            Else
                cFirmaAval1 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(drAnexo("Nomcoac")) + 6) & Chr(10) & drAnexo("Nomcoac")
            End If
        End If

        If drAnexo("TipoObli") = "M" And Trim(drAnexo("NomrObl")) <> "" Then
            cFirmaAval2 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(10) & drAnexo("NomObli") & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(drAnexo("NomrObl")) + 6) & Chr(10) & drAnexo("NomrObl") & Chr(10) & "APODERADO"
        ElseIf drAnexo("Obli") = "S" Then
            cFirmaAval2 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(drAnexo("NomObli")) + 6) & Chr(10) & drAnexo("NomObli")
        End If

        If drAnexo("TipAval1") = "M" And Trim(drAnexo("NomrAva1")) <> "" Then
            cFirmaAval3 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(10) & drAnexo("NomAval1") & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(drAnexo("Nomrava1")) + 6) & Chr(10) & drAnexo("Nomrava1") & Chr(10) & "APODERADO"
        ElseIf drAnexo("Aval1") = "S" Then
            cFirmaAval3 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(drAnexo("NomAval1")) + 6) & Chr(10) & drAnexo("NomAval1")
        End If

        If drAnexo("TipAval2") = "M" And Trim(drAnexo("NomrAva2")) <> "" Then
            cFirmaAval4 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(10) & drAnexo("NomAval2") & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(drAnexo("Nomrava2")) + 6) & Chr(10) & drAnexo("Nomrava2") & Chr(10) & "APODERADO"
        ElseIf drAnexo("Aval2") = "S" Then
            cFirmaAval4 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(drAnexo("NomAval2")) + 6) & Chr(10) & drAnexo("NomAval2")
        End If

        ' Se crea el arreglo para los valores de la Tabla que se usará en el cálculo de la TIR
        ' lo hago en esta parte, dado que depende del numero de letras que contenga el contrato

        txtCusnam.Text = cCusnam

        If cFlcan = "S" Then
            btnActivar.Enabled = True
            btnValida.Enabled = False
            btnHoja.Enabled = False
            btnPagare.Enabled = False
            btnContrato.Enabled = False
            btnAnexoA.Enabled = False
            btnAnexoB.Enabled = False
            btnAnexoC.Enabled = False
            btnRatif.Enabled = False
        Else
            btnActivar.Enabled = False
            btnValida.Enabled = True
            btnHoja.Enabled = True
            btnPagare.Enabled = True
            btnContrato.Enabled = True
            btnAnexoA.Enabled = True
            btnAnexoB.Enabled = True
            btnAnexoC.Enabled = True
            btnRatif.Enabled = False
        End If

        btnCtom.Enabled = False
        btnACto.Enabled = False

        If cDomi = "S" Then
            With cm7
                .CommandType = CommandType.Text
                .CommandText = "SELECT Anexo From CuentasDomi Where Anexo = " & "'" & cContrato & "'"
                .Connection = cnAgil
            End With
            daDomi.Fill(dsAgil, "Domi")
            nCount = dsAgil.Tables("Domi").Rows.Count
            If nCount <> 0 Then
                btnDomi1.Enabled = True
            End If
        Else
            btnDomi.Enabled = False
            btnDomi1.Enabled = False
        End If


        If cFlcan <> "S" Then

            cFeven = DTOC(Today)

            ' El siguiente Stored Procedure trae los Datos del equipo financiado

            With cm2
                .CommandType = CommandType.StoredProcedure
                .CommandText = "DatosEquipo1"
                .Connection = cnAgil
                .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                .Parameters(0).Value = cContrato
            End With

            ' Obtengo el total del contrato

            With cm3
                .CommandType = CommandType.Text
                .CommandText = "SELECT Round(Sum(Convert(Decimal(14,2), Abcap + Inter)),2) as Total,Round(Sum(Convert(Decimal(14,2), Abcap + Inter+Iva)),2) as Totalp From Edoctav Where Edoctav.Anexo = " & "'" & cContrato & "'"
                .Connection = cnAgil
            End With

            ' Este Stored Procedure trae la tabla de amortización del equipo para el contrato seleccionado

            With cm4
                .CommandType = CommandType.StoredProcedure
                .CommandText = "TablaEquipo1"
                .Connection = cnAgil
                .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                .Parameters(0).Value = cContrato
            End With

            ' Obtengo todos los contratos asociados al Cliente sin importar su estatus

            With cm5
                .CommandType = CommandType.StoredProcedure
                .CommandText = "PideAnex2"
                .Connection = cnAgil
                .Parameters.Add("@Cliente", SqlDbType.NVarChar)
                .Parameters(0).Value = cCliente
            End With

            'Obtengo las rentas en depósito que tenga este contrato

            With cm6
                .CommandType = CommandType.StoredProcedure
                .CommandText = "DameRentas"
                .Connection = cnAgil
                .Parameters.Add("@cAnexo", SqlDbType.Char)
                .Parameters(0).Value = cContrato
            End With

            daSaldo.Fill(dsAgil, "Saldo")
            daRentas.Fill(dsAgil, "Rentasdep")

            drRiesgos = dsAgil.Tables("Saldo").Rows
            nCount = dsAgil.Tables("Rentasdep").Rows.Count

            nRentasD = 0
            nIvard = 0
            nSaldoRiesgo = 0

            If nCount > 0 Then
                drRentas = dsAgil.Tables("Rentasdep").Rows(0)
                If Not IsDBNull(drRentas("Rta")) Then
                    nRentasD = drRentas("Rta")
                    nIvard = drRentas("iva")
                End If
            End If

            nPagosi = nImpRD + nIvaDepg + nComis + nAmorin + nIvaAmorin + nDepNafin + nGastos + nIvaGastos
            nPagosi = nPagosi + nRentasD + nIvaRtaD + nDerechos + nServicio + nIVAServicio + nFondoReserva

            If nIvaEq > 0 And cFechacon < "20020301" Then
                cDescPI = "IVA DE LA OPERACION"
                cImpPI = FormatNumber(nIvaEq, 2).ToString
            End If
            If nImpRD > 0 Then
                If cTipar = "R" Then
                    cDescPI = cDescPI & Chr(13) & "DEPOSITO FINAGIL"
                    cImpPI = cImpPI & Chr(13) & FormatNumber(nImpRD, 2).ToString
                Else
                    cDescPI = cDescPI & Chr(13) & "DEPOSITO EN GARANTIA"
                    cImpPI = cImpPI & Chr(13) & FormatNumber(nImpRD, 2).ToString
                End If
            End If
            If nIvaDepg > 0 Then
                If cTipar = "R" Then
                    cDescPI = cDescPI & Chr(13) & "IVA DEPOSITO FINAGIL"
                    cImpPI = cImpPI & Chr(13) & FormatNumber(nIvaDepg, 2).ToString
                Else
                    cDescPI = cDescPI & Chr(13) & "IVA DEL DEPOSITO"
                    cImpPI = cImpPI & Chr(13) & FormatNumber(nIvaDepg, 2).ToString
                End If
            End If
            If nComis > 0 Then
                cDescPI = cDescPI & Chr(13) & "COMISION POR APERTURA + IVA"
                cImpPI = cImpPI & Chr(13) & FormatNumber(nComis, 2).ToString
            End If
            If nDepNafin > 0 Then
                cDescPI = cDescPI & Chr(13) & "5 % NAFIN"
                cImpPI = cImpPI & Chr(13) & FormatNumber(nDepNafin, 2).ToString
            End If
            If nAmorin > 0 Then
                If cTipar = "R" Then
                    cDescPI = cDescPI & Chr(13) & "ENGANCHE"
                    cImpPI = cImpPI & Chr(13) & FormatNumber(nAmorin, 2).ToString
                ElseIf cTipar = "P" Then
                    cDescPI = cDescPI & Chr(13) & "RENTA INICIAL"
                    cImpPI = cImpPI & Chr(13) & FormatNumber(nAmorin, 2).ToString
                Else
                    cDescPI = cDescPI & Chr(13) & "AMORTIZACION INICIAL"
                    cImpPI = cImpPI & Chr(13) & FormatNumber(nAmorin, 2).ToString
                End If
            End If
            If nIvaAmorin > 0 Then
                If cTipar = "P" Then
                    cDescPI = cDescPI & Chr(13) & "IVA RENTA INICIAL"
                    cImpPI = cImpPI & Chr(13) & FormatNumber(nIvaAmorin, 2).ToString
                Else
                    cDescPI = cDescPI & Chr(13) & "IVA AMORTIZACION"
                    cImpPI = cImpPI & Chr(13) & FormatNumber(nIvaAmorin, 2).ToString
                End If
            End If
            If cTipar = "R" And nDerechos > 0 Then
                cDescPI = cDescPI & Chr(13) & "DERECHOS DE REGISTRO"
                cImpPI = cImpPI & Chr(13) & FormatNumber(nDerechos, 2).ToString
            End If
            If nGastos > 0 Then
                cDescPI = cDescPI & Chr(13) & "GASTOS DE RATIFICACION"
                cImpPI = cImpPI & Chr(13) & FormatNumber(nGastos, 2).ToString
            End If
            If nIvaGastos > 0 Then
                cDescPI = cDescPI & Chr(13) & "IVA GASTOS DE RATIFICACION"
                cImpPI = cImpPI & Chr(13) & FormatNumber(nIvaGastos, 2).ToString
            End If
            If nRentasD > 0 Then
                cDescPI = cDescPI & Chr(13) & "RENTAS EN DEPOSITO"
                cImpPI = cImpPI & Chr(13) & FormatNumber(nRentasD, 2).ToString
            End If
            If nIvaRtaD > 0 Then
                cDescPI = cDescPI & Chr(13) & "IVA RENTAS EN DEPOSITO"
                cImpPI = cImpPI & Chr(13) & FormatNumber(nIvaRtaD, 2).ToString
            End If
            If nServicio > 0 Then
                cDescPI = cDescPI & Chr(13) & "SERVICIO DE GARANTIA"
                cImpPI = cImpPI & Chr(13) & FormatNumber(nServicio, 2).ToString
            End If
            If nIVAServicio > 0 Then
                cDescPI = cDescPI & Chr(13) & "IVA SERVICIO DE GARANTIA"
                cImpPI = cImpPI & Chr(13) & FormatNumber(nIVAServicio, 2).ToString
            End If
            If nFondoReserva > 0 Then
                cDescPI = cDescPI & Chr(13) & "FONDO DE RESERVA"
                cImpPI = cImpPI & Chr(13) & FormatNumber(nFondoReserva, 2).ToString
            End If
            cImpPI = cImpPI & Chr(13) & "_________________"
            cImpPI = cImpPI & Chr(13) & FormatNumber(nPagosi, 2).ToString

            ' Crear tabla temporal para integrar el dato de saldo insoluto de contratos anteriores y Rentas
            ' en Depósito si existen

            dtRiesgo.Columns.Add("SaldoRiesgo", Type.GetType("System.String"))
            dtRiesgo.Columns.Add("Rentasd", Type.GetType("System.String"))
            dtRiesgo.Columns.Add("Ivartad", Type.GetType("System.String"))
            dtRiesgo.Columns.Add("CAT", Type.GetType("System.String"))

            nSaldoRiesgo = 0
            For Each drRiesgo In drRiesgos
                If drRiesgo("Flcan") = "A" And drRiesgo("Anexo") < cContrato Then
                    nSaldoRiesgo = AcumulaSdo(drRiesgo("Anexo"), cFecha) + nSaldoRiesgo
                End If
            Next
            nSaldoAct = nSaldo + nSaldoRiesgo

            daAnexo.Fill(dsAgil, "Actifijo")
            daEdoctav.Fill(dsAgil, "Edoctav")   'Contiene la sumatoria de las rentas
            daTabla.Fill(dsAgil, "Tabla")       'Contiene la tabla de amortización del contrato

            drEdoctav = dsAgil.Tables("Edoctav").Rows(0)
            nTotal2 = drEdoctav("Total")

            For Each drEquipo In dsAgil.Tables("Actifijo").Rows
                cBienes = cBienes & "FACTURA____ " & drEquipo("Factura") & Chr(10) & "PROVEEDOR_ " & drEquipo("Proveedor") & Chr(10) & "MODELO_____ " & drEquipo("Modelo") & Chr(10)
                cBienes = cBienes & "MOTOR______ " & drEquipo("Motor") & Chr(10) & "SERIE_______ " & drEquipo("Serie") & Chr(10) & "IMPORTE____ " & FormatNumber(drEquipo("Importe")).ToString & " " & Letras(drEquipo("Importe")) & Chr(10)
                cBienes = cBienes & Trim(drEquipo("Detalle")) & Chr(10) & Chr(10)
                cProveedor = cProveedor & drEquipo("Proveedor") & Chr(10)
                cImpProv = cImpProv & FormatNumber(drEquipo("Importe")).ToString & Chr(10)
                cDetalle = cDetalle & Trim(drEquipo("Detalle")) & Chr(10)
            Next

            For Each drEquipo In dsAgil.Tables("Actifijo").Rows
                cBienes2 = cBienes2 & "FACTURA____ " & drEquipo("Factura") & Chr(10) & "PROVEEDOR_ " & drEquipo("Proveedor") & Chr(10) & "MODELO_____ " & drEquipo("Modelo") & Chr(10)
                cBienes2 = cBienes2 & "MOTOR______ " & drEquipo("Motor") & Chr(10) & "SERIE_______ " & drEquipo("Serie") & Chr(10) & "IMPORTE____ " & drEquipo("Importe") & " " & Letras(drEquipo("Importe")) & Chr(10)
                cBienes2 = cBienes2 & "COBERTURA SEG. " & Chr(10) & "VIGENCIA SEG. " & Chr(10) & "BENEFICIARIO PREFERENTE  FINAGIL, S.A. DE C.V. SOFOM ENR" & Chr(10)
                cBienes2 = cBienes2 & Chr(10) & Trim(drEquipo("Detalle")) & Chr(10) & Chr(10)
            Next

            cDiaPago = " con las fechas estipuladas en su Tabla de Amortización correspondiente a partir del"

            i = 0
            For Each drTabla In dsAgil.Tables("Tabla").Rows
                If i = 0 Then
                    cFven1 = drTabla("Feven")
                End If
                cFevent = drTabla("Feven")
                i = i + 1
            Next
            If i = 1 Then
                nDiasp = DateDiff(DateInterval.Day, CTOD(cFechacon), CTOD(cFevent))
                nDiasp = nDiasp / (i)
            Else
                nDiasp = DateDiff(DateInterval.Day, CTOD(cFven1), CTOD(cFevent))
                nDiasp = nDiasp / (i - 1)
            End If

            i = 1
            nCobertura = 0
            nTotalCobert = 0
            nGtotaliva = 0
            nGtotalivacap = 0

            For Each drTabla In dsAgil.Tables("Tabla").Rows
                If i = 1 Then
                    cLetrat = drTabla("Letra")
                    cFevent = CTOD(drTabla("Feven"))
                    cSaldot = FormatNumber(drTabla("Saldo")).ToString
                    cAbcapt = FormatNumber(drTabla("Abcap")).ToString
                    cIntert = FormatNumber(drTabla("Inter")).ToString
                    cIvat = FormatNumber(drTabla("Iva")).ToString
                    cIvaCapt = FormatNumber(drTabla("IvaCapital")).ToString
                    nGtotalivacap += drTabla("IvaCapital")

                    nGtotaliva += drTabla("Iva")
                    nSumaCap += drTabla("Abcap")
                    nSumaInt += drTabla("Inter")
                    nSumaRen += drTabla("Abcap") + drTabla("Inter")
                    If cTipar = "P" Then
                        cRentap = FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva")).ToString
                        cRenta = FormatNumber(drTabla("Abcap") + drTabla("Inter")).ToString
                    Else
                        cRenta = FormatNumber(drTabla("Abcap") + drTabla("Inter")).ToString
                    End If
                    If nRtas = 0 And nImpRD > 0 And 0 = 1 Then ' SE QUITA BONOFICACION DE LA TABLA
                        cBonifica = FormatNumber(drTabla("IvaCapital")).ToString
                        nSumaBoni += drTabla("IvaCapital")
                        If cFondeo = "03" And cAplicaCobertura = "S" Then
                            Select Case nDiasp
                                Case Is <= 31
                                    cCobert = FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 12), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 12), 2)
                                Case 58 To 80
                                    cCobert = FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 6), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 6), 2)
                                Case 88 To 100
                                    cCobert = FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 4), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 4), 2)
                                Case 175 To 200
                                    cCobert = FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 2), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 2), 2)
                                Case Is > 250
                                    cCobert = FormatNumber(Round(drTabla("Saldo") * nPorcFEGA, 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * nPorcFEGA, 2)
                            End Select
                            cTotg = FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva") + nCobertura).ToString
                            cPagomen = FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva")).ToString
                            nTotalCobert = nTotalCobert + nCobertura
                            cTotgCAP = FormatNumber(drTabla("Abcap")).ToString
                        Else
                            cCobert = "0.00"
                            cPagomen = FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva")).ToString
                            cTotg = FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva")).ToString
                            cTotgCAP = FormatNumber(drTabla("Abcap")).ToString
                        End If
                    Else
                        cBonifica = "0.00"
                        If cFondeo = "03" And cAplicaCobertura = "S" Then
                            Select Case nDiasp
                                Case Is <= 31
                                    cCobert = FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 12), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 12), 2)
                                Case 58 To 80
                                    cCobert = FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 6), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 6), 2)
                                Case 88 To 100
                                    cCobert = FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 4), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 4), 2)
                                Case 175 To 200
                                    cCobert = FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 2), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 2), 2)
                                Case Is > 250
                                    cCobert = FormatNumber(Round(drTabla("Saldo") * nPorcFEGA, 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * nPorcFEGA, 2)
                            End Select
                            cTotg = FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva") + drTabla("IvaCapital") + nCobertura).ToString
                            cTotgCAP = FormatNumber(drTabla("Abcap")).ToString
                            cPagomen = FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva") + drTabla("IvaCapital")).ToString
                            nTotalCobert = nTotalCobert + nCobertura
                        Else
                            cPagomen = FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva") + drTabla("IvaCapital")).ToString
                            cTotg = FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva") + drTabla("IvaCapital")).ToString
                            cTotgCAP = FormatNumber(drTabla("Abcap")).ToString
                            cCobert = "0.00"
                        End If
                    End If
                    nSumaPmen += drTabla("Abcap") + drTabla("Inter") + drTabla("Iva") + drTabla("IvaCapital")
                Else
                    cLetrat = cLetrat & Chr(10) & drTabla("Letra")
                    cFevent = cFevent & Chr(10) & CTOD(drTabla("Feven"))
                    cSaldot = cSaldot & Chr(10) & FormatNumber(drTabla("Saldo")).ToString
                    cAbcapt = cAbcapt & Chr(10) & FormatNumber(drTabla("Abcap")).ToString
                    cIntert = cIntert & Chr(10) & FormatNumber(drTabla("Inter")).ToString
                    cIvat = cIvat & Chr(10) & FormatNumber(drTabla("Iva")).ToString
                    cIvaCapt = cIvaCapt & Chr(10) & FormatNumber(drTabla("IvaCapital")).ToString
                    nGtotaliva += drTabla("Iva")
                    nGtotalivacap += drTabla("IvaCapital")
                    nSumaCap += drTabla("Abcap")
                    nSumaInt += drTabla("Inter")
                    nSumaRen += drTabla("Abcap") + drTabla("Inter")
                    If cTipar = "P" Then
                        cRentap = cRentap & Chr(10) & FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva")).ToString
                        cRenta = cRenta & Chr(10) & FormatNumber(drTabla("Abcap") + drTabla("Inter")).ToString
                    Else
                        cRenta = cRenta & Chr(10) & FormatNumber(drTabla("Abcap") + drTabla("Inter")).ToString
                    End If
                    If nRtas = 0 And nImpRD > 0 And 0 = 1 Then ' SE QUITA BONOFICACION DE LA TABLA
                        cBonifica = cBonifica & Chr(10) & FormatNumber(drTabla("IvaCapital")).ToString
                        If cFondeo = "03" And cAplicaCobertura = "S" Then
                            cPagomen = cPagomen & Chr(10) & FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva")).ToString
                            Select Case nDiasp
                                Case Is <= 31
                                    cCobert = cCobert & Chr(10) & FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 12), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 12), 2)
                                Case 58 To 80
                                    cCobert = cCobert & Chr(10) & FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 6), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 6), 2)
                                Case 88 To 100
                                    cCobert = cCobert & Chr(10) & FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 4), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 4), 2)
                                Case 175 To 200
                                    cCobert = cCobert & Chr(10) & FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 2), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 2), 2)
                                Case Is > 250
                                    cCobert = cCobert & Chr(10) & FormatNumber(Round(drTabla("Saldo") * nPorcFEGA, 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * nPorcFEGA, 2)
                            End Select
                            cTotg = cTotg & Chr(10) & FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva") + nCobertura).ToString
                            cTotgCAP = cTotgCAP & Chr(10) & FormatNumber(drTabla("Abcap")).ToString
                            nTotalCobert = nTotalCobert + nCobertura
                        Else
                            cCobert = cCobert & Chr(10) & "0.00"
                            cPagomen = cPagomen & Chr(10) & FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva")).ToString
                            cTotg = cTotg & Chr(10) & FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva")).ToString
                            cTotgCAP = cTotgCAP & Chr(10) & FormatNumber(drTabla("Abcap")).ToString
                        End If
                        nSumaBoni += drTabla("IvaCapital")
                    Else
                        cBonifica = cBonifica & Chr(10) & "0.00"
                        If cFondeo = "03" And cAplicaCobertura = "S" Then
                            Select Case nDiasp
                                Case Is <= 31
                                    cCobert = cCobert & Chr(10) & FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 12), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 12), 2)
                                Case 58 To 80
                                    cCobert = cCobert & Chr(10) & FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 6), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 6), 2)
                                Case 88 To 100
                                    cCobert = cCobert & Chr(10) & FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 4), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 4), 2)
                                Case 175 To 200
                                    cCobert = cCobert & Chr(10) & FormatNumber(Round(drTabla("Saldo") * (nPorcFEGA / 2), 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * (nPorcFEGA / 2), 2)
                                Case Is > 250
                                    cCobert = cCobert & Chr(10) & FormatNumber(Round(drTabla("Saldo") * nPorcFEGA, 2)).ToString
                                    nCobertura = Round(drTabla("Saldo") * nPorcFEGA, 2)
                            End Select
                            cPagomen = cPagomen & Chr(10) & FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva") + drTabla("IvaCapital")).ToString
                            cTotg = cTotg & Chr(10) & FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva") + drTabla("IvaCapital") + nCobertura).ToString
                            cTotgCAP = cTotgCAP & Chr(10) & FormatNumber(drTabla("Abcap")).ToString
                            nTotalCobert = nTotalCobert + nCobertura
                        Else
                            cCobert = cCobert & Chr(10) & "0.00"
                            cPagomen = cPagomen & Chr(10) & FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva") + drTabla("IvaCapital")).ToString
                            cTotg = cTotg & Chr(10) & FormatNumber(drTabla("Abcap") + drTabla("Inter") + drTabla("Iva") + drTabla("IvaCapital")).ToString
                            cTotgCAP = cTotgCAP & Chr(10) & FormatNumber(drTabla("Abcap")).ToString
                        End If
                    End If
                    nSumaPmen += drTabla("Abcap") + drTabla("Inter") + drTabla("Iva") + drTabla("IvaCapital")
                End If
                nAmort = i
                i += 1
            Next

            If cSucursal = "03" Then
                cLugar = "Navojoa, Sonora"
                cNotario = "Lic. René Balderrama Sánchez, Notario Público No. 7 de la Ciudad de Navojoa, Sonora,"
                cUnidadEsp = "Avenida No Reelección número 712 (setecientos doce) sur, colonia Centro, entre las calles de Manuel Doblado y Nicolás Bravo, C.P. 85800 (ochenta y cinco mil ochocientos), Navojoa, Sonora, los teléfonos de atención a usuarios serán: (642) 422 56 50 y 01 800 836 23 92,"
            ElseIf cSucursal = "04" Then
                cLugar = "Mexicali, Baja California"
                cNotario = "Lic. Francisco Javier Briseño Arce, Registrador Agricola de la Ciudad de Mexicali, Baja California,"
                cUnidadEsp = "Avenida Rio San Angel número 48 (cuarenta y ocho) interior 7 (siete) y 8 (ocho), fraccionamiento Valle de Puebla, C.P. 21384 (veintiún mil trescientos ochenta y cuatro), Mexicali, Baja California, los teléfonos de atención a usuarios serán: (686) 577 80 60, (686) 577 80 50 y 01 800 626 02 27,"
            ElseIf cSucursal = "01" Then
                cLugar = "Toluca, Estado de México"
                cNotario = "Lic. Jorge Valdés Ramírez, Notario Público No. 24 de la Ciudad de Toluca, Estado de México."
                cUnidadEsp = "Leandro Valle, número 402 (cuatrocientos dos), colonia Reforma y Ferrocarriles Nacionales, C.P. 50070 (cincuenta mil setenta), Toluca, Estado de México, los teléfonos de atención a usuarios serán: (722) 214 5533 y 01 80072 77100,"
            ElseIf cSucursal = "02" Then
                cLugar = "Querétaro, Querétaro"
                cNotario = "Lic. Jorge Valdés Ramírez, Notario Público No. 24 de la Ciudad de Toluca, Estado de México."
                cUnidadEsp = "Avenida Tecnológico Sur número 100, cuarto piso, interior 408, fraccionamiento San Angel, edificio Tec 100, C.P. 76000 (setenta y seis mil), Querétaro , Querétaro, los teléfonos de atención a usuarios serán: (422) 223 45 43, (422) 223 65 02  y 01 800 727 85 71,"
            ElseIf cSucursal = "05" Then
                cLugar = "Irapuato, Guanajuato"
                cNotario = ""
                cUnidadEsp = "Avenida de los Insurgentes número 2604 (dos mil seiscientos cuatro), Local B-4, Plaza Inn, colonia Los Fresnos, C.P. 36555 (treinta y seis mil quinientos cincuenta y cinco), Irapuato, Guanajuato, los teléfonos de atención a usuarios serán: (462) 623 62 31, (462) 623 64 61 y 01 800 837 74 76,"
            ElseIf cSucursal = "07" Then
                cLugar = "Toluca, Estado de México"
                cNotario = "Lic. Jorge Valdés Ramírez, Notario Público No. 24 de la Ciudad de Toluca, Estado de México."
                cUnidadEsp = "Leandro Valle, número 402 (cuatrocientos dos), colonia Reforma y Ferrocarriles Nacionales, C.P. 50070 (cincuenta mil setenta), Toluca, Estado de México, los teléfonos de atención a usuarios serán: (722) 214 5533 y 01 80072 77100,"
            Else
                cLugar = "Toluca, Estado de México"
                cNotario = "Lic. Jorge Valdés Ramírez, Notario Público No. 24 de la Ciudad de Toluca, Estado de México."
                cUnidadEsp = "Leandro Valle, número 402 (cuatrocientos dos), colonia Reforma y Ferrocarriles Nacionales, C.P. 50070 (cincuenta mil setenta), Toluca, Estado de México, los teléfonos de atención a usuarios serán: (722) 214 5533 y 01 80072 77100,"
            End If


            'If cSucursal = "03" Or cSucursal = "04" Then
            'cSubDPromo = "C.P. GERALDO M. GARCIA VELEZ"
            'Else
            cSubDPromo = "ING. MIGUEL ANGEL LEAL RUIZ"
            'End If

            'Procedemos a llenar el arreglo para el cálculo de TIR
            Dim Valores() As Double
            Dim Fechas() As String
            Dim Guess As Double
            Dim x As Integer = 1
            ReDim Preserve Valores(x)
            ReDim Preserve Fechas(x)
            Valores(0) = -nMtoFin + ((nComis / (1 + nTasaIvaCliente / 100)) + nDepg)
            Fechas(0) = CTOD(cFechacon).ToString("MM/dd/yyyy")
            For Each drRiesgo In dsAgil.Tables("Tabla").Rows
                If drRiesgo("Nufac") < 7777777 And drRiesgo("Indrec") = "S" Then
                    i = Val(drRiesgo("Letra"))
                    nDato2 = drRiesgo("Renta")
                    cFecha1 = drRiesgo("Feven")
                    cFecha1 = drRiesgo("Feven")
                End If
                ' para CAT************************************
                ReDim Preserve Valores(x)
                ReDim Preserve Fechas(x)
                Valores(x) = drRiesgo("Renta")
                Fechas(x) = CTOD(drRiesgo("feven")).ToString("MM/dd/yyyy")
                x += 1
                ' para CAT************************************

                If cTipar = "P" Then
                    nTotal += (drRiesgo("Abcap") + drRiesgo("Inter") + drRiesgo("Iva"))
                Else
                    nTotal += (drRiesgo("Abcap") + drRiesgo("Inter"))
                End If
            Next
            nDiasp = DateDiff(DateInterval.Day, CTOD(cFechacon), CTOD(cFecha1))
            nPanual = Round(nDiasp / i, 0)
            cTermino = Mes(cFecha1)

            Select Case nPanual
                Case Is > 300
                    P = 1
                Case Is >= 179
                    P = 2
                Case Is >= 119
                    P = 3
                Case Is >= 89
                    P = 4
                Case Is >= 59
                    P = 6
                Case Is >= 29
                    P = 12
                Case Is = 28
                    P = 13
                Case Is >= 15, Is = 16, Is = 17
                    P = 24
                Case Is = 14
                    P = 26
                Case Is = 7
                    P = 52
            End Select

            If nPanual > 59 Then
                cParrafoInteres = "Los intereses se computaran mensualmente y se refinanciaran sumándose al saldo insoluto, pasando a formar parte del capital como nueva base de cómputo de intereses del mes siguiente y así sucesivamente hasta que se lleve a cabo la amortización principal."
            Else
                cParrafoInteres = "Los intereses pactados se calculan de acuerdo a lo establecido en las clausulas tercera y sexta."
            End If

            Guess = 0.01
            If P = 1 Then
                Dim oXL As Excel.Application
                oXL = CreateObject("Excel.Application")
                nCAT = oXL.Application.WorksheetFunction.Xirr(Valores, Fechas, Guess)
                nCAT = nCAT * 100
                oXL.Quit()
                oXL = Nothing
            Else
                nTIR = IRR(Valores, Guess)
                nTIR = Round(nTIR * 100, 3)
                nCAT = (Round(Pow(1 + (nTIR / 100), P), 8) - 1) * 100
            End If

            drRiesgo = dtRiesgo.NewRow()
            drRiesgo("SaldoRiesgo") = FormatNumber(nSaldoRiesgo.ToString, 2)
            drRiesgo("Rentasd") = FormatNumber(nRentasD.ToString, 2)
            drRiesgo("Ivartad") = FormatNumber(nIvard.ToString, 2)
            drRiesgo("CAT") = FormatNumber(nCAT, 1).ToString & "%"
            dtRiesgo.Rows.Add(drRiesgo)
            dsAgil.Tables.Add(dtRiesgo)

            dsAgil.WriteXml("C:\Contratos\Schema2.xml", XmlWriteMode.WriteSchema)

        End If

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
        cm4.Dispose()
        cm5.Dispose()
        cm6.Dispose()

    End Sub

    Function ReplicateString(ByVal Source As String, ByVal Times As Long) As String
        Dim length As Long, index As Long
        ' Crea la línea
        length = Len(Source)
        ReplicateString = Space$(length * Times)
        ' Realiza multiples copias del valor Source 
        For index = 1 To Times
            Mid$(ReplicateString, (index - 1) * length + 1, length) = Source
        Next
    End Function

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnDomi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDomi.Click
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daDatos As New SqlDataAdapter(cm1)
        Dim drDato As DataRow
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim drAnexo As DataRow
        Dim drTotal As DataRow
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document

        Dim cCuenta As String
        Dim cCuenta2 As String
        Dim cBanco As String
        Dim cConcepto As String
        Dim cTitular As String
        Dim cContrato As String
        Dim cCta1 As String

        cContrato = Mid(cAnexo, 1, 5) & Mid(cAnexo, 7, 4)

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM CuentasDomi WHERE Anexo = " & cContrato
            .Connection = cnAgil
        End With
        daDatos.Fill(dsAgil, "Anexo")
        drDato = dsAgil.Tables("Anexo").Rows(0)

        If dsAgil.Tables("Anexo").Rows.Count > 0 Then
            drDato = dsAgil.Tables("Anexo").Rows(0)
            If Trim(drDato("CuentaCLABE")) <> "" Then
                cCuenta = drDato("CuentaCLABE")
            ElseIf Trim(drDato("NumTarjeta")) <> "" Then
                cCuenta2 = drDato("NumTarjeta")
            ElseIf Trim(drDato("CuentaEJE")) <> "" Then
                cCuenta = drDato("CuentaEJE")
            End If
            cBanco = Trim(drDato("Banco"))
            cConcepto = Trim(drDato("DescPago"))
            cTitular = Trim(drDato("TitularCta"))
        End If
        cCta1 = Mid(cCuenta, 1, 1)

        oRuta = DocCopiaLocal("F:\CS\AUTORIZACIONDOM.doc", 2)

        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantillatR

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo únicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quitándole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable

                Select Case cfName

                    Case "mRef"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4))
                    Case "mCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCusnam)
                    Case "mRecibo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cConcepto)
                    Case "mTitular"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cTitular
                    Case "mBco"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cBanco
                    Case "mFecha"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFechacon)
                    Case "mNCta1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCuenta
                    Case "mNCta2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCuenta2
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        ' Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
        Dim oMissing = System.Reflection.Missing.Value

        Dim oSaveAsFile = "C:\contratos\" & Trim(cCusnam) & "_AUT_" & cContrato & ".doc"

        Try
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try
        Cursor.Current = Cursors.Default

        dsAgil = Nothing
        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnDomi1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDomi1.Click

        Dim cSolicitud As String

        cContrato = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)
        cSolicitud = cSoli

        Dim newfrmACD As New frmAltaCuentaDom(cContrato & cSolicitud)
        newfrmACD.Show()

    End Sub

    Private Sub btnCtom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtom.Click
        Dim dsTemporal As New DataSet()
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim drAnexo As DataRow
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document

        ' Declaración de variables de datos

        Dim cFecha As String
        Dim cNota As String = ""

        dsTemporal.ReadXml("C:\Contratos\Schema2.xml")

        drAnexo = dsTemporal.Tables("Contrato").Rows(0)

        cNota = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "NOTA: A través de la(s) firma(s) que de su puño y letra estampa(n) en el presente contrato el(los) OBLIGADO(S) SOLIDARIO(S) Y AVAL(ES) "
        cNota = cNota & "manifiesta(n) su conformidad y se da(n) por enterado(s) y advertido(s), que esta(n) obligado(s) a efectuar el "
        cNota = cNota & "pago en caso de que el obligado principal (LA ARRENDATARIA) incumpla con el mismo por cualquier causa."

        If cTipar = "S" Then
            oRuta = DocCopiaLocal("F:\CS\Contrato CS.doc", 2)
        End If

        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantilla  

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        If cTipar = "S" Then
            If cFondeo = "03" Then
                With oWordDoc.Sections(1)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318")
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "CONTRATO DE CREDITO SIMPLE CON RECURSOS FIRA No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
                End With
            Else
                With oWordDoc.Sections(1)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                    If bLiquidez = True Then
                        .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029254/01-01329-0318 ")
                        cReca = "1907-439-029254/01-01329-0318 "
                    Else
                        .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318 ")
                        cReca = "1907-439-029236/01-01233-0318 "
                    End If
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "CONTRATO DE CREDITO SIMPLE No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
                End With
            End If
        End If


        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo únicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quitándole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable

                Select Case cfName
                    Case "mLugar"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLugar

                    Case "mFirmaCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaCte.ToUpper
                    Case "mFirmaAval1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval1.ToUpper
                    Case "mFirmaAval2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval2.ToUpper
                    Case "mFirmaAval3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval3.ToUpper
                    Case "mFirmaAval4"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval4.ToUpper
                    Case "mUnidadEsp"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cUnidadEsp
                    Case "mNota"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cNota
                    Case "mFecha"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = MesJuridico(cFechacon)
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
        Dim oMissing = System.Reflection.Missing.Value

        Dim oSaveAsFile = "C:\contratos\" & Trim(cCusnam) & "_CTO_MTO_" & cContrato & ".doc"

        Try
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnACto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnACto.Click
        'If txtAnexo.Text = "00362/0014" Then ' se aplica bloqueo a partir de contratos con esta fecha
        Dim Ree As String = "N"
        Ree = TaQUERY.EsReestructura(Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4))
        If TaQUERY.SacaPermisoModulo("", UsuarioGlobal.ToLower) <= 0 Then
            If Ree <> "S" Then
                If cFechacon >= "20151001" Then ' se aplica bloqueo a partir de contratos con esta fecha
                    If RevisaTasa(Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4), cCliente) Then
                        Exit Sub
                    End If
                End If
            End If
        End If

        Dim dsTemporal As New DataSet()
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim drAnexo As DataRow
        Dim drTotal As DataRow
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document

        ' Declaración de variables de datos

        Dim cFecha As String
        Dim cFeven As String
        Dim cDato1 As String = ""
        Dim cNota As String = ""
        Dim cDato12 As String = ""
        Dim cDato12A As String = ""
        Dim cDato12B As String = ""
        Dim cDato12C As String = ""
        Dim cGenerep As String = ""
        Dim cDato15 As String = ""
        Dim cLetraImp As String = ""
        Dim cGeneEmp As String = ""
        Dim cTestigo1 As String = ""
        Dim cTestigo2 As String = ""
        Dim cLeyenda As String = ""
        Dim cAporInv As String = ""
        Dim cCobertura As String = ""
        Dim cCoberDet1 As String = ""
        Dim cCoberDet2 As String = ""
        Dim cCoacre As String = ""
        Dim cDato8 As String = ""
        Dim cRecur As String
        Dim cSeguro As String
        Dim nCount As Integer
        Dim nTIR As Decimal
        Dim nSaldo As Decimal
        Dim nMensu As Decimal
        Dim nDato2 As Decimal
        Dim nDepg As Decimal
        Dim i As Integer
        'Dim RutaApp As String = ""

        'If Directory.Exists("c:\program files (x86)\") Then
        '    RutaApp = "c:\program files (x86)\"
        'Else
        '    RutaApp = "C:\Archivos de programa\"
        'End If

        dsTemporal.ReadXml("C:\Contratos\Schema2.xml")

        drAnexo = dsTemporal.Tables("Contrato").Rows(0)
        cLetraImp = Letras(nTotal)

        cNota = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "NOTA: A través de la(s) firma(s) que de su puño y letra estampa(n) en el presente contrato el(los) OBLIGADO(S) SOLIDARIO(S) Y AVAL(ES) "
        cNota = cNota & "manifiesta(n) su conformidad y se da(n) por enterado(s) y advertido(s), que esta(n) obligado(s) a efectuar el "
        cNota = cNota & "pago en caso de que el obligado principal (LA ARRENDATARIA) incumpla con el mismo por cualquier causa."

        If drAnexo("Tipo") = "M" And Trim(drAnexo("Nomrepr")) <> "" Then
            cDato1 = "por conducto de su representante que:"
            cGeneEmp = Chr(10) & Chr(10) & "De la sociedad denominada " & cCusnam & " su representante de nombre " & cRepresentante & " manifiesta que " & cGeneClie & "Manifestando los comparecientes bajo protesta de decir verdad, que las facultades a ellos otorgadas, no les han sido revocadas, ni en forma alguna limitadas."
        Else
            cDato1 = "por su propio derecho:"
        End If

        cDato15 = Mid(drAnexo("Geneclie"), 1, 2)
        If cDato15 = "A)" Then
            cGeneClie = Mid(drAnexo("GeneClie"), 3, Len(drAnexo("GeneClie"))) & Chr(10)
        ElseIf cDato15 = "a)" Then
            cGeneClie = Mid(drAnexo("GeneClie"), 3, Len(drAnexo("GeneClie"))) & Chr(10)
        Else
            cGeneClie = drAnexo("GeneClie") & Chr(10)
        End If

        If drAnexo("Tipo") = "M" Then
            cDato7 = Chr(10) & Chr(10) & drAnexo("Generepr") & Chr(10) & Chr(10) & drAnexo("Poderepr")
            If drAnexo("Nomrepr2") <> "" Then
                cDato7 = Chr(10) & Chr(10) & "SU SEGUNDO REPRESENTANTE " & drAnexo("Nomrepr2") & " QUIEN MANIFIESTA" & Chr(10) & Chr(10) & drAnexo("Poderep2")
            End If
        End If

        cDato12 = "III.- "
        cCoac2 = ""
        If drAnexo("Coac") = "C" And drAnexo("Tipcoac") = "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
            If drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P" Then
                cCoacre = Chr(10) & Chr(10) & "DECLARA(N) EL(LOS) COARRENDATARIO(S): " & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac") & "REPRESENTADA EN ESTE ACTO POR: " & Trim(drAnexo("Nomrcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac") & Chr(10) & Chr(10) & drAnexo("Podercoa")
            ElseIf drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S" Then
                cCoacre = Chr(10) & Chr(10) & "DECLARA(N) EL(LOS) COACREDITADO(S): " & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac") & "REPRESENTADA EN ESTE ACTO POR: " & Trim(drAnexo("Nomrcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac") & Chr(10) & Chr(10) & drAnexo("Podercoa")
            End If
            cDato12C = cDato12C & Chr(10) & Chr(10) & drAnexo("Podercoa")
        ElseIf drAnexo("Coac") = "C" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomrcoac")) = "" Then
            If drAnexo("Tipar") = "F" Or drAnexo("Tipar") = "P" Then
                cCoacre = Chr(10) & Chr(10) & "DECLARA(N)EL(LOS) COARRENDATARIO(S): " & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            ElseIf drAnexo("Tipar") = "R" Or drAnexo("Tipar") = "S" Then
                cCoacre = Chr(10) & Chr(10) & "DECLARA(N) EL(LOS) COACREDITADO(S): " & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac")
            End If
        ElseIf drAnexo("Coac") = "S" And drAnexo("Tipcoac") = "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
            cCoac2 = Chr(10) & Chr(10) & cDato12 & "DECLARA(N) EL(LOS) OBLIGADO(S) SOLIDARIO(S) Y AVAL(ES): " & Chr(10) & Chr(10) & drAnexo("GeneCoac") & "REPRESENTADA EN ESTE ACTO POR: " & Trim(drAnexo("Nomrcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac") & Chr(10) & Chr(10) & drAnexo("Podercoa")
        ElseIf drAnexo("Coac") = "S" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
            cCoac2 = Chr(10) & Chr(10) & cDato12 & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL:" & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac")
        ElseIf drAnexo("Coac") = "S" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomcoac")) <> "" Then
            cCoac2 = Chr(10) & Chr(10) & cDato12 & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL:" & Trim(drAnexo("Nomcoac")) & Chr(10) & Chr(10) & drAnexo("GeneCoac")
        End If

        If cCoac2 <> "" Then
            cDato12 = "IV.- "
            cDato12A = "V.- "
            cDato12B = "VI.- "
            cDato12C = "VII.- "
        End If

        If drAnexo("Obli") = "S" And drAnexo("TipoObli") = "M" And Trim(drAnexo("NomObli")) <> "" Then
            cDato8 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & drAnexo("NomObli") & Chr(10) & drAnexo("GeneObli") & Chr(10) & "REPRESENTADA EN ESTE ACTO POR: " & Trim(drAnexo("NomrObl")) & Chr(10) & drAnexo("GenerObl") & Chr(10) & Chr(10) & drAnexo("PoderObl")
        ElseIf drAnexo("Obli") = "S" And drAnexo("TipoObli") <> "M" And Trim(drAnexo("NomObli")) <> "" Then
            cDato8 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & drAnexo("NomObli") & Chr(10) & drAnexo("GeneObli")
        End If

        ''If cDato8 <> "" And cDato12 = "IV.- " Then
        ''    cDato12A = "VI.- "
        ''    cDato12B = "VII.- "
        ''    cDato12C = "VIII.- "
        ''ElseIf cDato8 <> "" And cDato12 = "III.- " Then
        ''    cDato12 = "IV.- "
        ''    cDato12A = "V.- "
        ''    cDato12B = "VI.- "
        ''    cDato12C = "VII.- "
        ''End If

        cDato9 = ""
        If drAnexo("Aval1") = "S" And drAnexo("TipAval1") = "M" And Trim(drAnexo("NomAval1")) <> "" Then
            cDato9 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & Trim(drAnexo("NomAval1")) & Chr(10) & drAnexo("Geneava1") & Chr(10) & "REPRESENTADA EN ESTE ACTO POR:" & Trim(drAnexo("Nomrava1")) & Chr(10) & drAnexo("GenerAv1") & Chr(10) & Chr(10) & drAnexo("PoderAv1")
        ElseIf drAnexo("Aval1") = "S" And drAnexo("TipAval1") <> "M" And Trim(drAnexo("NomAval1")) <> "" Then
            cDato9 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & Trim(drAnexo("NomAval1")) & Chr(10) & drAnexo("GeneAva1")
        End If

        '' '' ''If cDato9 <> "" And cDato12 = "V.- " Then
        '' '' ''    cDato12 = "VI.- "
        '' '' ''    cDato12A = "VII.- "
        '' '' ''    cDato12B = "VIII.- "
        '' '' ''    cDato12C = "IX.- "
        '' '' ''ElseIf cDato9 <> "" And cDato12 = "IV.- " Then
        '' '' ''    cDato12 = "V.- "
        '' '' ''    cDato12A = "VI.- "
        '' '' ''    cDato12B = "VII.- "
        '' '' ''    cDato12C = "VIII.- "
        '' '' ''ElseIf cDato9 <> "" And cDato12 = "III.- " Then
        '' '' ''    cDato12 = "IV.- "
        '' '' ''    cDato12A = "V.- "
        '' '' ''    cDato12B = "VI.- "
        '' '' ''    cDato12C = "VII.- "
        '' '' ''ElseIf cDato9 <> "" And cDato12 = "VI.- " Then
        '' '' ''    cDato12 = "VII.- "
        '' '' ''    cDato12A = "VIII.- "
        '' '' ''    cDato12B = "IX.- "
        '' '' ''    cDato12C = "X.- "
        '' '' ''End If

        cDato10 = ""
        If drAnexo("Aval2") = "S" And drAnexo("TipAval2") = "M" And Trim(drAnexo("NomrAva2")) <> "" Then
            cDato10 = Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & Trim(drAnexo("Nomaval2")) & Chr(10) & drAnexo("GeneAva2") & Chr(10) & "representada en este acto por:" & Trim(drAnexo("Nomrava2")) & Chr(10) & "quien declara:" & drAnexo("GenerAv2") & Chr(10) & Chr(10) & drAnexo("Poderav2")
        ElseIf drAnexo("Aval2") = "S" And drAnexo("TipAval2") <> "M" And Trim(drAnexo("NomrAva2")) = "" Then
            cDato10 = Chr(10) & Chr(10) & cDato12 & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL " & Trim(drAnexo("Nomaval2")) & Chr(10) & Chr(10) & drAnexo("GeneAva2")
        End If

        If drAnexo("Sucursal") = "01" Or drAnexo("Sucursal") = "02" Then
            If Trim(drAnexo("DescPromotor")) = "C.P. GERALDO GARCIA VELEZ" Then
                cTestigo1 = "Llamarse Luis Manuel González Miranda, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 06 de enero de 1975, de profesión Contador Público, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. GOML750106SM8"
                cFirmaTestigo1 = "C.P. LUIS MANUEL GONZALEZ MIRANDA"
            ElseIf Trim(drAnexo("DescPromotor")) = "ING. MIGUEL ANGEL LEAL RUIZ" Then
                cTestigo1 = "Llamarse Miguel Angel Leal Ruiz, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de México, D.F., lugar donde nació el día 12 de diciembre de 1961, de profesión Ingeniero Agronomo, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. LERM611212KS7"
                cFirmaTestigo1 = "ING. MIGUEL ANGEL LEAL RUIZ"
            ElseIf Trim(drAnexo("DescPromotor")) = "C.P. JONATHAN HERNANDEZ ARIAS" Then
                cTestigo1 = "Llamarse Jonathan Hernández Arias, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 09 de julio de 1975, de profesión Contador Público, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. HEAJ7507096H2"
                cFirmaTestigo1 = "C.P. JONATHAN HERNANDEZ ARIAS"
            ElseIf Trim(drAnexo("DescPromotor")) = "C.P. ENRIQUE YONG BETANCOURT" Then
                cTestigo1 = "Llamarse Enrique Yong Betancourt, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Querétaro, Querétaro, lugar donde nació el día 28 de abril de 1965, de profesión Contador Público, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. YOBE650428Q67"
                cFirmaTestigo1 = "C.P. ENRIQUE YONG BETANCOURT"
            ElseIf Trim(drAnexo("DescPromotor")) = "C.P. LUIS MANUEL GONZALEZ MIRANDA" Then
                cTestigo1 = "Llamarse Luis Manuel González Miranda, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 06 de enero de 1975, de profesión Contador Público, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. GOML750106SM8"
                cFirmaTestigo1 = "C.P. LUIS MANUEL GONZALEZ MIRANDA"
            ElseIf Trim(drAnexo("DescPromotor")) = "LAE RAFAEL DIAZ ORTIZ" Then
                cTestigo1 = "Llamarse Rafael Díaz Ortiz, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 03 de febrero de 1980, de profesión Lic. en Administración de Empresas, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. DIOR800203AG2"
                cFirmaTestigo1 = "LAE. RAFAEL DIAZ ORTIZ"
            ElseIf Trim(drAnexo("DescPromotor")) = "C. PEDRO SOLIS FRANCO" Then
                cTestigo1 = "Llamarse Pedro Soli Franco, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de México, D.F., lugar donde nació el día 18 de marzo de 1978, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. SOFP7803186G8"
                cFirmaTestigo1 = "C. PEDRO SOLIS FRANCO"
            ElseIf Trim(drAnexo("DescPromotor")) = "SERGIO SANCHEZ MACKENT" Then
                cTestigo1 = "Llamarse Sergio Sánchez Mackent, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de México, D.F., lugar donde nació el día 10 de septiembre de 1970, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. SAMS700910CW1"
                cFirmaTestigo1 = "SERGIO SANCHEZ MACKENT"
            ElseIf Trim(drAnexo("DescPromotor")) = "GUILLERMO RAMIREZ GUZMAN" Then
                cTestigo1 = "Llamarse Guillermo Ramirez Guzman, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 20 de junio de 1961, de profesión Licenciado en Administración de Empresas, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. RAGG610620AF2"
                cFirmaTestigo1 = "LAE. GUILLERMO RAMIREZ GUZMAN"
            End If

            If Trim(drAnexo("DescPromotor")) = "LAE RAFAEL DIAZ ORTIZ" Then
                cTestigo2 = "Llamarse Jonathan Hernández Arias, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 09 de julio de 1975, de profesión Contador Público, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. HEAJ7507096H2"
                cFirmaTestigo2 = "C.P. JONATHAN HERNANDEZ ARIAS"
            Else
                cTestigo2 = "Llamarse Rafael Díaz Ortiz, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 03 de febrero de 1980, de profesión Lic. en Administración de Empresas, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. DIOR800203AG2"
                cFirmaTestigo2 = "LAE RAFAEL DIAZ ORTIZ"
            End If

        ElseIf drAnexo("Sucursal") = "03" Then
            cTestigo1 = "Llamarse Adolfo Pacheco Mendez, manifiesta por sus generales ser de nacionalidad mexicana, originaria de Ciudad Obregon, Sonora, lugar donde nació el día 01 de marzo de 1964, de profesión Ingeniero Agrónomo, con domicilio en Calle No Reelecion No. 712, colonia Centro Navojoa, Sonora México, y con R.F.C. PAMA6403012V1"
            cTestigo2 = "Llamarse Mitzi López Bojórquez, manifiesta por sus generales ser de nacionalidad mexicana, de la Ciudad de México Distrito Federal, lugar donde nació el día 07 de Noviembre de 1980, de profesión Licenciada en Sistemas de Información Administrativa, con domicilio en Calle No reelección No.  712 Col. Centro, Navojoa Sonora, México. C.P. 85050, y con R.F.C. LOBM801107"
            cFirmaTestigo1 = "ING. ADOLFO PACHECO MENDEZ"
            cFirmaTestigo2 = "LIC. MITZI LOPEZ BOJOQUEZ"
        ElseIf drAnexo("Sucursal") = "04" Then
            cTestigo1 = "Llamarse Jesus Oscar Cruz Terán, manifiesta por sus generales ser de nacionalidad mexicana, originario de Rayón, Estado de Sonora México, lugar donde nació el día 11 de diciembre de 1958, de profesión Ingeniero Agrónomo, con domicilio en Avenida  Rio San Angel número 48, fraccionamiento  Valle de  Puebla, Mexicali, Baja California, México, C.P. 21384, y con R.F.C. CUTJ581211JB1"
            cTestigo2 = "Llamarse Daniel Rentería, manifiesta por sus generales ser de nacionalidad mexicana, originaria de Ensenada, Baja California, lugar donde nació el día 15 de Octubre de 1959, de profesión Licenciado en Administración de Empresas, de estado civil casado, con domicilio en Puerta de Alcalá 2822 Frac. Puerta de Hierro, Mexicali, Baja California, México, C.P. 21255, con R.F.C. REDA591015HU8 y con CURP REXD591015HBCNXN00 "
            cFirmaTestigo1 = "ING. JESUS OSCAR CRUZ TERAN"
            cFirmaTestigo2 = "LIC. DANIEL RENTERIA"
        ElseIf drAnexo("Sucursal") = "05" Then
            '   cTestigo1 = "Llamarse Violeta María Lucia Tezcucano Contreras, manifiesta por sus generales ser de nacionalidad mexicana, originaria de la ciudad de Irapuato, Guanajuato, lugar donde nació el día 17 de enero de 1984, de profesión Licenciada en Contaduría, con domicilio en Av. de los Insurgentes 2604 Local B-4, colonia Los Fresnos C.P. 36555, Irapuato, Guanajuato, y con R.F.C. TECV8401179F0"
            cTestigo1 = "Llamarse Vianey Alejandra Yáñez Ortiz, manifiesta por sus generales ser de nacionalidad mexicana, originaria de la ciudad de Irapuato, Guanajuato, lugar donde nació el día 15 quince de mayo de 1991 mil novecientos noventa y uno, de ocupación estudiante, con domicilio en Avenida de los Insurgentes 2604 dos mil seiscientos cuatro, Local B-4 letra 'B', guión, cuatro colonia Los Fresnos C.P. 36555 treinta y seis mil quinientos cincuenta y cinco, Irapuato, Guanajuato, y con Registro Federal de Contribuyentes YAOV910515480"
            cTestigo2 = "Llamarse Raúl Armando Venegas Miranda, manifiesta por sus generales ser de nacionalidad mexicana, originaria de Irapuato, Guanajuato, lugar donde nació el día 01 uno de enero de 1978, de profesión Ingeniero, con domicilio en Av. de los Insurgentes 2604 Local B-4, colonia Los Fresnos C.P. 36555, Irapuato, Guanajuato, y con R.F.C. VEMR780101183"
            '  cFirmaTestigo1 = "LIC. VIOLETA MARIA LUCIA TEZCUCANO CONTRERAS"
            cFirmaTestigo1 = "VIANEY ALEJANDRA YAÑEZ ORTIZ"
            cFirmaTestigo2 = "ING. RAUL ARMANDO VENEGAS MIRANDA"
        ElseIf drAnexo("Sucursal") = "07" Then
            cTestigo1 = "Llamarse Carlos Mejía González, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de México D.F., Distrito Federal, lugar donde nació el día 11 de febrero de 1970, de profesión Licenciado en Administración de Empresas, con domicilio en Boulevard Manuel Ávila Camacho # 99 2do. Piso, colonia Alce Blanco C.P. 53370, Naucalpan, Estado de México, y con R.F.C. MEGC700211MU9"
            cTestigo2 = "Llamarse Geraldo García Velez, manifiesta por sus generales ser de nacionalidad mexicana, originario de la ciudad de Toluca, Estado de México, lugar donde nació el día 13 de marzo de 1970, de profesión Contador Público, con domicilio en Leandro Valle No. 402, colonia Reforma y FFCCNN, C.P. 50070, Toluca, Estado de México, y con R.F.C. GAVG700313"
            cFirmaTestigo1 = "LAE. CARLOS MEJIA GONZALEZ"
            cFirmaTestigo2 = "C.P. GERALDO GARCIA VELEZ"

        End If

        cFirmaTestigo1 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "PRIMER TESTIGO" & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(cFirmaTestigo1) + 6) & Chr(10) & cFirmaTestigo1
        cFirmaTestigo2 = Chr(10) & Chr(10) & Chr(10) & Chr(10) & "SEGUNDO TESTIGO" & Chr(10) & Chr(10) & Chr(10) & ReplicateString("_", Len(cFirmaTestigo2) + 6) & Chr(10) & cFirmaTestigo2

        cLeyenda = "Tratándose de créditos a tasa variable o en los que por su naturaleza, alguno de los conceptos referidos en la tabla de amortización "
        cLeyenda = cLeyenda & " anterior pudieran modificarse durante su vigencia, la ARRENDADORA deberán tomar el valor del concepto de que se trate vigente "
        cLeyenda = cLeyenda & " en la fecha en que se realice la tabla de amortización, asumiendo que dicho valor no cambiará durante la vigencia del crédito."
        cLeyenda = cLeyenda & Chr(10) & "Asimismo, la ARRENDADORA señala expresamente que esta tabla no tiene ninguna validez legal ya que es solo hipotética,"
        cLeyenda = cLeyenda & " ejemplificativa e ilustrativa, toda vez que para la elaboración de esta tabla se tomó como base los meses con 30"
        cLeyenda = cLeyenda & " días, por lo que puede haber variación de acuerdo al número real de días que tenga cada mes. Se precisa que los importes de esta tabla"
        cLeyenda = cLeyenda & " no incluyen los pagos del seguro de los bienes arrendados, seguro de vida (en su caso), ni del servicio de rastreador satelital,"
        cLeyenda = cLeyenda & " por lo que una vez determinados los montos de los pagos por estos conceptos, las partes acuerdan que serán financiados, se cargarán de forma mensual y de"
        cLeyenda = cLeyenda & " manera adicional deben ser pagados por la ARRENDATARIA. Las partes establecen que si durante el plazo de vigencia  del arrendamiento las autoridades decretan alguna variación "
        cLeyenda = cLeyenda & " en el Impuesto al Valor Agregado, los importes señalados en esta tabla por ese concepto se deberán ajustar a  esta variación y por lo tanto cambiarán"
        cLeyenda = cLeyenda & " los montos reflejados en esta tabla."

        If drAnexo("Tipo") = "M" Then
            If drAnexo("Coac") = "N" And cTipar = "P" Then
                cPersFirman = "COARRENDATARIA: N/A"
            Else
                cPersFirman = "PERSONAS QUE FIRMAN EN REPRESENTACIÓN DE LA EMPRESA: " & Trim(cCusnam) & " " & cRepresentante
            End If
            cSeguro = "N/A"
        Else
            If drAnexo("Coac") = "C" And drAnexo("Tipcoac") <> "M" And Trim(drAnexo("Nomcoac")) <> "" Then
                If cTipar = "S" Then
                    cPersFirman = "COACREDITADO: " & Trim(drAnexo("Nomcoac"))
                Else
                    cPersFirman = "COARRENDATARIA: " & Trim(drAnexo("Nomcoac"))
                End If
            ElseIf drAnexo("Coac") = "C" And drAnexo("Tipcoac") = "M" And Trim(drAnexo("Nomrcoac")) <> "" Then
                cPersFirman = "COARRENDATARIA: " & Trim(drAnexo("Nomcoac")) & " REPRESENTADO EN ESTE ACTO POR " & Trim(drAnexo("Nomrcoac"))
            End If
            If drAnexo("Coac") = "N" And cTipar = "P" Then
                cPersFirman = "COARRENDATARIA: N/A"
            End If
            cSeguro = "CONTRATADO CON GRUPO NACIONAL PROVINCIAL, S.A.B. CON LAS SIGUIENTES CONDICIONES APLICABLES"
        End If

        If cTipar = "S" Then
            oRuta = DocCopiaLocal("F:\CS\Contrato CS.doc", 2)
        End If

        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantilla  

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        cCoberDet2 = "En caso de que el recurso provenga de FIRA, contratar las coberturas para la administración del riesgo de acuerdo a las demandas del proyecto, a la disponibilidad de dichas "
        cCoberDet2 = cCoberDet2 & "coberturas, así como las políticas de riesgo de la SOFOM, tales como seguros, coberturas de precio y de tasas de interés y agricultura por contrato."

        If cFondeo = "03" Then
            cCobertura = "COBERTURA FEGA: " & (nPorcFEGA * 100).ToString("n2") & "% SOBRE SALDOS INSOLUTOS CONFORME A LA FECHA DE VENCIMIENTO EN TERMINOS DE LO ESTIPULAEDO EN LA CLAUSULA TRIGESIMA CUARTA Y TRIGESIMA SEXTA."
            cCobertura = cCobertura & Chr(10) & "LAS COBERTURAS ANTERIORES, SE FINANCIARAN, ÉSTAS Y LOS INTERESES SE COMPUTARAN Y PAGARAN MENSUALMENTE DE FORMA SUSCESIVA HASTA QUE SE LLEVE A CABO LA AMORTIZACION PRINCIPAL, DE ACUERDO A LO PLASMADO EN LA TABLA DE AMORTIZACION."
        End If

        If cTipar = "S" Then
            If cFondeo = "03" Then
                With oWordDoc.Sections(1)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318")
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "CONTRATO DE CREDITO SIMPLE CON RECURSOS FIRA No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
                End With
                cReca = "1907-439-029236/01-01233-0318"
            Else
                With oWordDoc.Sections(1)
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                    If bLiquidez = True Then
                        .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029254/01-01329-0318 ")
                        cReca = "1907-439-029254/01-01329-0318 "
                    Else
                        .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-439-029236/01-01233-0318 ")
                        cReca = "1907-439-029236/01-01233-0318 "
                    End If
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "CONTRATO DE CREDITO SIMPLE No. " & Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4)))
                End With
            End If
        End If

        If cFondeo = "03" Then
            cRecur = " FIRA (X)        NAFIN ( )        PROPIOS ( )"
        ElseIf cFondeo = "02" Then
            cRecur = " FIRA ( )        NAFIN (X)        PROPIOS ( )"
        ElseIf cFondeo = "01" Then
            cRecur = " FIRA ( )        NAFIN ( )        PROPIOS (X)"
        End If

        If cFondeo = "03" Then
            cAporInv = "APORTACION A LA INVERSION: " & FormatNumber((nMtoFin / 0.8) - nMtoFin).ToString & " " & Letras((nMtoFin / 0.8) - nMtoFin) & Chr(10)
        End If


        Dim nResultado As Decimal
        Dim nSumaBanamex As Decimal
        Dim nSumaBancomer As Decimal

        Dim cRefBanamex As String
        Dim cRefBanorte As String
        Dim cRefBancomer As String
        Dim cRefHSBC As String

        cAnexo = Mid(drAnexo("Anexo"), 1, 5) & Mid(drAnexo("Anexo"), 7, 4)
        cFlcan = drAnexo("Flcan")
        cTipo = drAnexo("Tipar")

        cRefBanamex = Mid(cAnexo, 1, 5) + Mid(cAnexo, 7, 3)
        cRefBancomer = Mid(cAnexo, 2, 4) + Mid(cAnexo, 7, 3)
        cRefBanorte = Mid(cAnexo, 2, 4) + Mid(cAnexo, 7, 3)

        nSumaBanamex = 1235
        nSumaBanamex += Val(Mid(cRefBanamex, 1, 1)) * 11
        nSumaBanamex += Val(Mid(cRefBanamex, 2, 1)) * 13
        nSumaBanamex += Val(Mid(cRefBanamex, 3, 1)) * 17
        nSumaBanamex += Val(Mid(cRefBanamex, 4, 1)) * 19
        nSumaBanamex += Val(Mid(cRefBanamex, 5, 1)) * 23
        nSumaBanamex += Val(Mid(cRefBanamex, 6, 1)) * 29
        nSumaBanamex += Val(Mid(cRefBanamex, 7, 1)) * 31
        nSumaBanamex += Val(Mid(cRefBanamex, 8, 1)) * 37

        nResultado = 99 - (nSumaBanamex Mod 97)
        If nResultado > 9 Then
            cRefBanamex += "-" + nResultado.ToString
        Else
            cRefBanamex += "-" + "0" + nResultado.ToString
        End If

        nSumaBancomer = 0
        nResultado = Val(Mid(cRefBancomer, 1, 1)) * 2
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 2, 1)) * 1
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 3, 1)) * 2
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 4, 1)) * 1
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 5, 1)) * 2
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 6, 1)) * 1
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 7, 1)) * 2
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If

        If nSumaBancomer > 60 Then
            nResultado = 70 - nSumaBancomer
        ElseIf nSumaBancomer > 50 Then
            nResultado = 60 - nSumaBancomer
        ElseIf nSumaBancomer > 40 Then
            nResultado = 50 - nSumaBancomer
        ElseIf nSumaBancomer > 30 Then
            nResultado = 40 - nSumaBancomer
        ElseIf nSumaBancomer > 20 Then
            nResultado = 30 - nSumaBancomer
        ElseIf nSumaBancomer > 10 Then
            nResultado = 20 - nSumaBancomer
        ElseIf nSumaBancomer > 0 Then
            nResultado = 10 - nSumaBancomer
        Else
            nResultado = 0
        End If

        cRefBancomer += "-" + nResultado.ToString
        cRefBanorte = cRefBancomer

        ' Abro el Contrato

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo únicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quitándole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable

                Select Case cfName

                    Case "mDescr"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCusnam)
                    Case "mRepresentante"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cRepresentante)
                    Case "mCoac"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCoac
                    Case "mCoac2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCoac2
                    Case "mCoacre"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCoacre
                    Case "mPersFirman"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cPersFirman & Chr(13)
                    Case "mDato1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDato1)
                    Case "mDato7"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDato7)
                    Case "mDato8"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato8
                    Case "mDato9"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato9
                    Case "mCalle"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCalle
                    Case "mReca"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cReca
                    Case "mColonia"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cColonia
                    Case "mCopos"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCopos)
                    Case "mDelegacion"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDelegacion)
                    Case "mEstado"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cEstado)
                    Case "mFirmaCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaCte.ToUpper
                    Case "mFirmaAval1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval1.ToUpper
                    Case "mFirmaAval2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval2.ToUpper
                    Case "mGeneClie"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = "DECLARA LA ARRENDATARIA " & cGeneClie.ToUpper
                    Case "mFirmaAval3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval3.ToUpper
                    Case "mFirmaAval4"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval4.ToUpper
                    Case "mFirmaTest1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaTestigo1.ToUpper
                    Case "mFirmaTest2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaTestigo2.ToUpper
                    Case "mDato10"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato10
                    Case "mDato12"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato12
                    Case "mDato12A"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato12A
                    Case "mDato12B"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato12B
                    Case "mDato12C"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDato12C
                    Case "mAval"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If Trim(cAval) <> "" Then
                            myMField.Result.Text = cAval.ToUpper
                        Else
                            myMField.Result.Text = "N.A."
                        End If
                    Case "mNota"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cNota
                    Case "mObSol"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cObSol
                    Case "mObSol1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cObSol1
                    Case "mTasas"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Round(nTasas, 2).ToString & " %"
                    Case "mTipta"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDescTasa) & " "
                    Case "mTasas1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipta = "7" Then
                            myMField.Result.Text = Round(nTasas, 2).ToString & " % " & Cant_Letras(Round(nTasas, 2), "") & " POR CIENTO"
                        Else
                            myMField.Result.Text = "Tasa variable TIIE más " & nDifer.ToString & " puntos porcentuales."
                        End If
                    Case "mTmora"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipta = "7" Then
                            myMField.Result.Text = Round(nTasas * nTasmor, 2).ToString & " % " & Cant_Letras(Round(nTasas * nTasmor, 2), "") & " POR CIENTO"
                        Else
                            myMField.Result.Text = " "
                        End If
                    Case "mTasmor"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        'If cTipar = "P" Then
                        'myMField.Result.Text = Round(nTasmor * nTasas, 2)
                        'Else
                        myMField.Result.Text = Round(nTasmor, 2) & " " & Cant_Letras(nTasmor, "")
                        'End If
                    Case "mFecha"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        'myMField.Result.Text = MesJuridico(cFechacon)
                        myMField.Result.Text = Mid(cFechacon, 7, 2) & " " & Cant_Letras(Val(Mid(cFechacon, 7, 2)), "") & Mid(MesJuridico(cFechacon), 3, Len(MesJuridico(cFechacon)) - 2) & " " & Cant_Letras(Val(Mid(cFechacon, 1, 4)), "") & ", " & cLugar
                    Case "mTotal"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nTotal + nGtotaliva + nGtotalivacap + nCobertura).ToString & " " & Letras(nTotal + nGtotaliva + nGtotalivacap + nCobertura)
                    Case "mGTIvac"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nGtotalivacap)
                    Case "mGTIva"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nGtotaliva)
                    Case "mGTCob"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nTotalCobert)
                    Case "mGTCap"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSumaCap)
                    Case "mGTInt"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSumaInt)
                    Case "mGTRe"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSumaRen)
                    Case "mGTBo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSumaBoni)
                    Case "mGTPm"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSumaPmen - nSumaBoni)
                    Case "mGTFi"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nSumaCap + nSumaInt - nSumaBoni + nGtotalivacap + nGtotaliva + nTotalCobert)
                    Case "mLetraImp"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLetraImp
                    Case "mPlazo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = nDiasp.ToString & " DIAS EN " & nAmort.ToString & " " & Cant_Letras(nAmort, "") & " PAGOS DISTRIBUIDOS COMO SE MUESTRA EN SU TABLA DE AMORTIZACION"
                    Case "mFeven"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFvenc
                    Case "mGeneEmp"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cGeneEmp
                    Case "mGenerepr"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cGenerepr
                    Case "mAvales"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cAvales
                    Case "mTestigo1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cTestigo1
                    Case "mTestigo2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cTestigo2
                    Case "mLetrast"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLetrat
                    Case "mFevent"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFevent
                    Case "mDiaFeven"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = "El día " & Mid(cFevent, 1, 2) & " " & Cant_Letras(Val(cFevent), "") & " de cada mes como se indica en la Tabla de Amortización"
                    Case "mSaldot"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cSaldot
                    Case "mAbcapt"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cAbcapt
                    Case "mIntert"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cIntert
                    Case "mIvat"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cIvat
                    Case "mIvacapt"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cIvaCapt
                    Case "mMtoFin"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nMtoFin).ToString & " " & Letras(nMtoFin)
                    Case "mRenta"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRenta
                    Case "mPagosi"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nPagosi).ToString & " " & Letras(nPagosi)
                    Case "mRecur"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRecur
                    Case "mTaspen"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Round(nTaspen, 2) & " % " & Cant_Letras(Round(nTaspen, 2), "") & " POR CIENTO"
                    Case "mBonifica"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cBonifica
                    Case "mPagomen"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cPagomen
                    Case "mAporInv"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cAporInv
                    Case "mCAT2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipar = "F" Or cTipar = "P" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = Round(nCAT, 1).ToString & " % " & Cant_Letras(Round(nCAT, 1), "") & " POR CIENTO"
                        End If
                    Case "mCAT"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cTipar = "F" Or cTipar = "P" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = Round(nCAT, 1).ToString & " % " & Chr(10) & "CAT: 'El Costo Anual Total de financiamiento expresado en términos porcentuales anuales que, para fines informáticos y de comparación, incorpora la totalidad de los costos y gastos inherentes a los créditos.'"
                        End If
                    Case "mLeyenda"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLeyenda
                    Case "mParrafoInteres"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cParrafoInteres
                    Case "mDetalle"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDetalle
                    Case "mDesGarantia"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cPrenda = "S" Then
                            myMField.Result.Text = "PRENDARIA(X), DESCRITA EN EL ANEXO 'C'"
                        ElseIf cGHipotec = "S" Then
                            myMField.Result.Text = "HIPOTECARIA(X), DESCRITA EN LA ESCRITURA PUBLICA ANTE NOTARIO"
                        Else
                            myMField.Result.Text = " "
                        End If
                    Case "mReferencia"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = "Refencias Bancarias para Pago:" & Chr(10) & "BANAMEX Suc.285 Cuenta 7944154 Referencia " & cRefBanamex & Chr(10) & "BANCOMER Convenio 581034 Referencia " & cRefBancomer & Chr(10) & "BANORTE CEP 36832 Referencia " & cRefBanorte
                    Case "mDisposicion"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mid(cAnexo, 6, 4)
                    Case "mCtoMaestro"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mid(cAnexo, 1, 5)
                    Case "mLugar"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLugar
                    Case "mCobertura"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Chr(10) & cCobertura & Chr(10)
                    Case "mCoberDet1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Chr(10) & cCoberDet1 & Chr(10)
                    Case "mCoberDet2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCoberDet2 & Chr(10)
                    Case "mCobertt2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCobert
                    Case "mTotg"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cTotg
                    Case "mPorco"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Round(nPorco, 2).ToString & " % " & Cant_Letras(Round(nPorco, 2), "") & " POR CIENTO"
                    Case "mDescPI"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDescPI
                    Case "mSegVida"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = "EL RESULTADO DE MULTIPLICAR EL SALDO INSOLUTO DEL PERIODO POR 0.00067"
                        End If
                    Case "mUnidadEsp"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cUnidadEsp
                    Case "mRefCliente"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRefCliente
                    Case "mImpPI"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cImpPI
                    Case "mTotal2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If cFondeo = "03" Then
                            myMField.Result.Text = FormatNumber(nTotal2 + nTotalCobert + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal2 + nTotalCobert + nGtotaliva + nGtotalivacap) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & FormatNumber(nTotal2 - nMtoFin, 2).ToString & " más Iva Interés por " & FormatNumber(nGtotaliva, 2).ToString & " más Iva Capital por " & FormatNumber(nGtotalivacap, 2).ToString & " más su Cobertura por " & FormatNumber(nTotalCobert, 2).ToString
                        Else
                            myMField.Result.Text = FormatNumber(nTotal2 + nCobertura + nGtotaliva + nGtotalivacap, 2).ToString & Letras(nTotal2 + nCobertura + nGtotaliva + nGtotalivacap) & " compuestos por Monto Financiado " & FormatNumber(nMtoFin, 2).ToString & " más su Interés por " & FormatNumber(nTotal2 - nMtoFin, 2).ToString & " más Iva Interés por " & FormatNumber(nGtotaliva, 2).ToString & " más Iva Capital por " & FormatNumber(nGtotalivacap, 2).ToString
                        End If
                    Case "mSeguros"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = cSeguro
                        End If
                    Case "mSegV1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = "Del 01 (uno) de noviembre de 2015 (dos mil quince) al 01 (uno) de noviembre de 2016 (dos mil dieciséis)."
                        End If
                    Case "mSegV2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = "Mensual vencida"
                        End If
                    Case "mSegV3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = "sobre el saldo insoluto, con un monto máximo por asegurado de $ 5,000,000.00 (cinco millones 00/100 M.N.)"
                        End If
                    Case "mSegV4"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = "70 (setenta) años"
                        End If
                    Case "mSegV5"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = "75 (setenta y cinco) años"
                        End If
                    Case "mSegV6"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = "N/A"
                        Else
                            myMField.Result.Text = "El resultado de multiplicar el saldo insoluto del periodo por 0.001 (cero, punto, cero, cero, uno)."
                        End If
                    Case "mSegV7"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        If drAnexo("Tipo") = "M" Then
                            myMField.Result.Text = ""
                        Else
                            myMField.Result.Text = "Se establece que las condiciones del seguro de vida contratado se renovarán anualmente, en los términos que establece la compañía aseguradora."
                        End If
                    Case "mComis"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nComis / (1 + nPorInt)) & Letras(Round(nComis / (1 + nPorInt), 2))
                    Case "mIvaComis"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber((nComis / (1 + nPorInt)) * nPorInt) & Letras(Round((nComis / (1 + nPorInt)) * nPorInt, 2))
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next
        cAnexo = drAnexo("Anexo") ' recarga el numero de contrato con diagonal
        'Guardo el documento

        Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
        Dim oMissing = System.Reflection.Missing.Value

        Dim oSaveAsFile = "C:\contratos\" & Trim(cCusnam) & "_CTO_Anexos" & cContrato & ".doc"

        Try
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try
        Cursor.Current = Cursors.Default

    End Sub

    Function RevisaTasa(ByVal Anexo As String, ByVal Clie As String) As Boolean

        Dim nTasasAux As Decimal = nTasas
        Dim Ree As String
        Ree = TaQUERY.EsReestructura(Anexo)
        RevisaTasa = False
        nPorcoTope = 2
        If cTipta <> "7" Or cTipar = "P" Then
            nTasasAux = 0
        End If
        Dim TasaPol As Decimal = SacaTasaPol()

        If TaQUERY.ParteRelacionada(Clie) > 0 And Clie <> "03671" Then nPorcoTope = 1.25

        Dim ta As New GeneralDSTableAdapters.GEN_Bloqueo_TasasTableAdapter
        Dim t As New GeneralDS.GEN_Bloqueo_TasasDataTable

        If (nTasasAux + nDifer) < TasaPol Or nPorco <> nPorcoTope Then
            Dim FirmaProm As String = Encriptar(Date.Now.ToString("yyyyMMddhhmm") & "-" & UsuarioGlobal.Trim)
            ta.Fill(t, Anexo)
            If t.Rows.Count <= 0 Then
                Dim Comentario As String = InputBox("Favor de poner sus comentarios para el área de Riegos.", "Autorización de Tasas Especiales", "Comentario")

                If cTipta = "7" Then
                    ta.Insert(Anexo, Mid(Comentario.ToUpper, 1, 400), "", "", TasaPol, nTasasAux + nDifer, False, False, "", False, FirmaProm, "", "", "", Date.Now, False, PorcReserva)
                Else
                    ta.Insert(Anexo, Mid(Comentario.ToUpper, 1, 400), "", "", TasaPol, nDifer, False, False, "", False, FirmaProm, "", "", "", Date.Now, False, PorcReserva)
                End If
                RevisaTasa = True
                MessageBox.Show("Este contrato requiere autorización de la Subdirección de Riesgos", "Autorización", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim r As GeneralDS.GEN_Bloqueo_TasasRow = t.Rows(0)
                If r.AutorizadoRI = True And r.AutorizadoDG = True And r.Reserva = True Then
                    Dim MSWord As New Word.Application
                    Dim Documento As Word.Document
                    Dim Doc As String

                    If r.Autoriza = "DG" Or r.Autoriza = "AUTOMATICO" Then
                        Doc = DocCopiaLocal("F:\Plantillas\TasaEspecial.doc", 2)
                    Else
                        Doc = DocCopiaLocal("F:\Plantillas\TasaEspecial.doc", 2)
                    End If

                    Documento = MSWord.Documents.Open(Doc)
                    Documento.Bookmarks.Item("Anexo").Range.Text = txtAnexo.Text
                    Documento.Bookmarks.Item("ComentariosPromo").Range.Text = r.ComentarioPromo
                    Documento.Bookmarks.Item("ComentariosRiesgos").Range.Text = r.ComentarioRiesgos
                    Documento.Bookmarks.Item("ComisionApert").Range.Text = nPorco & "%"
                    Documento.Bookmarks.Item("ComisionDisp").Range.Text = ""
                    Documento.Bookmarks.Item("Destino").Range.Text = cDetalle
                    Documento.Bookmarks.Item("DG").Range.Text = nImpRD.ToString("n")
                    Documento.Bookmarks.Item("Fecha").Range.Text = Date.Now.ToLongDateString
                    Documento.Bookmarks.Item("FechaImpre").Range.Text = Date.Now.ToShortDateString & " " & Date.Now.ToShortTimeString
                    Documento.Bookmarks.Item("FR").Range.Text = nFondoReserva.ToString("n")
                    Documento.Bookmarks.Item("Indicadores").Range.Text = r.Indicadores
                    Documento.Bookmarks.Item("MontoFin").Range.Text = nMtoFin.ToString("n2")
                    Documento.Bookmarks.Item("NombreCli").Range.Text = cCusnam
                    If cTipar = "P" Then
                        Documento.Bookmarks.Item("OC").Range.Text = nPorop.ToString("n2") & "%"
                    Else
                        Documento.Bookmarks.Item("OC").Range.Text = ""
                    End If
                    Documento.Bookmarks.Item("Penalizacion").Range.Text = nTaspen.ToString("n2")
                    Documento.Bookmarks.Item("Plazo").Range.Text = nPlazo
                    Documento.Bookmarks.Item("producto").Range.Text = cProducto
                    Documento.Bookmarks.Item("Promotor").Range.Text = cPromo
                    'If cSucursal = "03" Or cSucursal = "04" Then
                    '    Documento.Bookmarks.Item("Subdirector").Range.Text = "GERALDO GARCIA VELEZ"
                    'Else
                    Documento.Bookmarks.Item("Subdirector").Range.Text = "MIGUEL ANGEL LEAL"
                    ' End If
                    Documento.Bookmarks.Item("Promotor1").Range.Text = cPromo
                    Documento.Bookmarks.Item("RD").Range.Text = nRD.ToString("n2")
                    Documento.Bookmarks.Item("TasaPol").Range.Text = TasaPol.ToString("n2")
                    Documento.Bookmarks.Item("Tasasol").Range.Text = (nTasasAux + nDifer).ToString("n2")
                    Documento.Bookmarks.Item("Autoriza").Range.Text = r.Autoriza

                    Documento.Bookmarks.Item("Fprom").Range.Text = r.FirmaPromo
                    Documento.Bookmarks.Item("Fsub").Range.Text = r.FirmaSubPromo
                    Documento.Bookmarks.Item("Friesgos").Range.Text = r.FirmaRiesgos
                    Documento.Bookmarks.Item("Fdireccion").Range.Text = r.FirmaDireccion


                    Documento.Protect(Word.WdProtectionType.wdAllowOnlyReading, False, "FinagilSofmomENR", False, False)
                    Documento.SaveAs("C:\Contratos\TasaEspecial" & Anexo & ".doc")
                    MSWord.Visible = True
                    RevisaTasa = False
                Else
                    RevisaTasa = True
                    If r.AutorizadoRI = True And r.AutorizadoDG = True Then
                        MessageBox.Show("Este contrato requiere autorización de la Subdirección de Riesgos", "Autorización", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Este contrato requiere confirmación de Porcentaje de Resevas (Riesgos)", "Autorización", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        Else
            ta.Fill(t, Anexo)
            If t.Rows.Count > 0 Then
                ta.AutorizaAutomatico("AUTORIZACION AUTOMATICA POR CORRECION TASA POL: " & TasaPol & " TASA SOL: " & (nTasasAux + nDifer).ToString("n2") & " COMISION: " & nPorco, True, True, "AUTOMATICO", True, "X" & Mid(Anexo, 2, 10), Anexo, 0)
            Else
                If TaQUERY.EstaPagado(Mid(cAnexo, 1, 5) & Mid(cAnexo, 7, 4)) Then
                    RevisaTasa = False
                Else
                    If cTipta = "7" Then
                        ta.Insert(Anexo, "AUTORIZACION AUTOMATICA", "", "", TasaPol, nTasasAux + nDifer, True, True, "", False, "", "", "", "", Date.Now, False, PorcReserva)
                    Else
                        ta.Insert(Anexo, "AUTORIZACION AUTOMATICA", "", "", TasaPol, nDifer, True, True, "", False, "", "", "", "", Date.Now, False, PorcReserva)
                    End If
                End If
            End If
            ta.Fill(t, Anexo)
            Dim r As GeneralDS.GEN_Bloqueo_TasasRow = t.Rows(0)
            If r.Reserva = False Then
                MessageBox.Show("Este contrato requiere confirmación de Porcentaje de Resevas (Riesgos)", "Autorización", MessageBoxButtons.OK, MessageBoxIcon.Error)
                RevisaTasa = True
            End If
        End If
        Return (RevisaTasa)
    End Function

    Function SacaTasaPol() As Decimal
        Dim nTasas As Decimal
        Dim nDiferAux As Decimal = nDifer
        'If cTipta <> "7" And cTipar = "P" And cAutomovil = "N" Then
        If cTipar = "P" And cAutomovil = "N" Then
            nDiferAux = 99
        ElseIf cTipar = "B" Then
            nDiferAux = 0
            nTasas = 15
        End If
        If bLiquidez = True Then
            nPorcoTope = 0

            Dim Meses As Integer = 0
            Dim dias As Integer = TaQUERY.DiasEntreVecimientos(Mid(cAnexo, 1, 5) & Mid(cAnexo, 7, 4))
            Select Case dias
                Case 7
                    Meses = TaQUERY.SemanasMeses(nAmortizaciones)
                Case 14
                    Meses = TaQUERY.CatorcenasMeses(nAmortizaciones)
                Case 15 To 20
                    Meses = TaQUERY.QuincenasMeses(nAmortizaciones)
                Case Is > 20
                    Meses = nAmortizaciones
            End Select
            Select Case Meses
                Case Is <= 8
                    nTasas = 25
                Case Else
                    nTasas = 25
            End Select
            If cEmpresa.Trim = "SERVICIOS ARFIN" Or (cEmpresa.Trim = "MOFESA" And cPlanta.Trim = "FINAGIL NAVOJOA") Then
                nTasas = 14
            ElseIf cEmpresa.Trim = "CREDITARIA" Then
                nTasas = 25
            End If
            If cTipta = "7" Then
                nDifer = 0
            End If

        Else

            Dim cnAgil As New SqlConnection(strConn)
            Dim cm1 As New SqlCommand()
            Dim cm7 As New SqlCommand()
            Dim daTasasAplicables As New SqlDataAdapter(cm1)
            Dim daPeriodos As New SqlDataAdapter(cm7)
            Dim dsAgil As New DataSet()
            Dim drPeriodo As DataRow
            Dim nPeriodo As Decimal = 0

            With cm7
                .CommandType = CommandType.Text
                .CommandText = "SELECT Periodo, FechaInip, FechaFinp, Vigente FROM PeriodoTasas where FechaInip <= '" & cFechacon & "' and FechaFinp >= '" & cFechacon & "' Order by Periodo"
                .Connection = cnAgil
            End With

            daPeriodos.Fill(dsAgil, "Periodos")

            For Each drPeriodo In dsAgil.Tables("Periodos").Rows
                If drPeriodo("Vigente") = "S" Then
                    'cFechaInip = drPeriodo("FechaInip")
                    'cFechaFinp = drPeriodo("FechaFinp")
                ElseIf drPeriodo("Vigente") = "N" Then
                    'cFechaInip1 = drPeriodo("FechaInip")
                    'cFechaFinp1 = drPeriodo("FechaFinp")
                End If
                nPeriodo = drPeriodo("Periodo")
            Next

            With cm1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "TasasAplicables1"
                .Connection = cnAgil
                .Parameters.Add("@TipoCredito", SqlDbType.NVarChar)
                .Parameters(0).Value = "AFsinIVA"
                .Parameters.Add("@Periodo", SqlDbType.NVarChar)
                .Parameters(1).Value = nPeriodo
            End With

            ' Llenar el DataSet lo cual abre y cierra la conexión

            daTasasAplicables.Fill(dsAgil, "AFsinIVA")

            ' Ahora defino el segundo tipo de crédito

            cm1.Parameters(0).Value = "AFconIVA"
            daTasasAplicables.Fill(dsAgil, "AFconIVA")

            ' Ahora defino el tercer tipo de crédito

            cm1.Parameters(0).Value = "AP"
            daTasasAplicables.Fill(dsAgil, "AP")

            cm1.Parameters(0).Value = "TVAP"
            daTasasAplicables.Fill(dsAgil, "TVAP")

            ' Ahora defino el cuarto tipo de crédito

            cm1.Parameters(0).Value = "CR"
            daTasasAplicables.Fill(dsAgil, "CR")

            cm1.Parameters(0).Value = "TVCR"
            daTasasAplicables.Fill(dsAgil, "TVCR")

            cm1.Parameters(0).Value = "CS"
            daTasasAplicables.Fill(dsAgil, "CS")

            ' Ahora defino el quinto tipo de crédito

            cm1.Parameters(0).Value = "TVAFsinIVA"
            daTasasAplicables.Fill(dsAgil, "TVAFsinIVA")

            ' Ahora defino el sexto tipo de crédito

            cm1.Parameters(0).Value = "TVAFconIVA"
            daTasasAplicables.Fill(dsAgil, "TVAFconIVA")

            cm1.Parameters(0).Value = "TVCS"
            daTasasAplicables.Fill(dsAgil, "TVCS")


            Dim nDGX As Decimal = nDG
            'If nRD = 5 Then nDGX = 1
            'If nRD = 10 Then nDGX = 2
            'If nRD = 15 Then nDGX = 3

            If nDG = 5 Then nDGX = 1
            If nDG = 10 Then nDGX = 2
            If nDG = 15 Then nDGX = 3

            Dim DepG, RenD As Boolean
            If nDGX > 0 Then DepG = True
            If nRD > 0 Then RenD = True

            If cTipta <> "7" Then
                nDiferAux = 0
            End If

            TasaAplicable(cTipar, cTipta, TaQUERY.PlazoEnMeses(cContrato), nIvaEq, RenD, nRD, DepG, nDGX, dsAgil, nTasas, nDiferAux, nPorop)
        End If

        SacaTasaPol = (nTasas + nDiferAux)
    End Function

    Private Sub btnPLD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPLD.Click
        'Declaración de variables de conexión ADO.NET
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daDatos As New SqlDataAdapter(cm1)
        Dim drDato As DataRow

        Dim nVeces As Integer = 0
        Dim cName As String
        Dim cTipAval As String
        Dim cRepaval As String

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Coac, Tipcoac, Nomcoac, Nomrcoac, Obli, TipoObli, Nomobli, NomrObl, Aval1, Tipaval1, Nomaval1, Nomrava1, Aval2, Tipaval2, Nomaval2, Nomrava2 FROM Clientes WHERE Cliente = " & cCliente
            .Connection = cnAgil
        End With
        daDatos.Fill(dsAgil, "Avales")
        drDato = dsAgil.Tables("Avales").Rows(0)

        DocPLD(cCusnam, 0, cTipo, "", Trim(Mid(cRepresentante, 31, 60)))

        If (drDato("Coac") = "C" Or drDato("Coac") = "S") And drDato("Tipcoac") <> "M" Then
            cName = Trim(drDato("Nomcoac"))
            cTipAval = drDato("Tipcoac")
            cRepaval = drDato("Nomrcoac")
            DocPLD(cName, 1, cTipAval, cRepaval, cRepaval)
            DOC_Pld.F3_AVAL_PF(cName, "aval/obligado solidario", cCusnam, (cFechacon).ToLower, cContrato, cLugar)
        End If
        If (drDato("Coac") = "C" Or drDato("Coac") = "S") And drDato("Tipcoac") = "M" Then
            cName = Trim(drDato("Nomcoac"))
            cTipAval = drDato("Tipcoac")
            cRepaval = drDato("Nomrcoac")
            DOC_Pld.F3_AVAL_PM(cName, "aval/obligado solidario", cCusnam, (cFechacon).ToLower, cContrato, cLugar, cRepaval)
            DocPLD(cName, 1, "M", cRepaval, cRepaval)
        End If

        If drDato("Obli") = "S" And drDato("TipoObli") <> "M" Then
            cName = Trim(drDato("Nomobli"))
            cTipAval = drDato("TipoObli")
            cRepaval = drDato("NomrObl")
            DocPLD(cName, 2, cTipAval, cRepaval, cRepaval)
            DOC_Pld.F3_AVAL_PF(cName, "aval/obligado solidario", cCusnam, (cFechacon).ToLower, cContrato, cLugar)
        End If

        If drDato("Obli") = "S" And drDato("TipoObli") = "M" Then
            cName = Trim(drDato("Nomobli"))
            cTipAval = drDato("TipoObli")
            cRepaval = drDato("NomrObl")
            DOC_Pld.F3_AVAL_PM(cName, "aval/obligado solidario", cCusnam, (cFechacon).ToLower, cContrato, cLugar, cRepaval)
            DocPLD(cName, 1, "M", cRepaval, cRepaval)
        End If

        If drDato("Aval1") = "S" And drDato("Tipaval1") <> "M" Then
            cName = Trim(drDato("Nomaval1"))
            cTipAval = drDato("Tipaval1")
            cRepaval = drDato("Nomrava1")
            DocPLD(cName, 3, cTipAval, cRepaval, cRepaval)
            DOC_Pld.F3_AVAL_PF(cName, "aval/obligado solidario", cCusnam, (cFechacon).ToLower, cContrato, cLugar)
        End If

        If drDato("Aval1") = "S" And drDato("Tipaval1") = "M" Then
            cName = Trim(drDato("Nomaval1"))
            cTipAval = drDato("Tipaval1")
            cRepaval = drDato("Nomrava1")
            DOC_Pld.F3_AVAL_PM(cName, "aval/obligado solidario", cCusnam, (cFechacon).ToLower, cContrato, cLugar, cRepaval)
            DocPLD(cName, 1, "M", cRepaval, cRepaval)
        End If

        If drDato("Aval2") = "S" And drDato("Tipaval2") <> "M" Then
            cName = Trim(drDato("Nomaval2"))
            cTipAval = drDato("Tipaval2")
            cRepaval = drDato("Nomrava2")
            DocPLD(cName, 4, cTipAval, cRepaval, cRepaval)
            DOC_Pld.F3_AVAL_PF(cName, "aval/obligado solidario", cCusnam, (cFechacon).ToLower, cContrato, cLugar)
        End If

        If drDato("Aval2") = "S" And drDato("Tipaval2") = "M" Then
            cName = Trim(drDato("Nomaval2"))
            cTipAval = drDato("Tipaval2")
            cRepaval = drDato("Nomrava2")
            DOC_Pld.F3_AVAL_PM(cName, "AVAL", cCusnam, (cFechacon).ToLower, cContrato, cLugar, cRepaval)
            DocPLD(cName, 1, "M", cRepaval, cRepaval)
        End If

        Dim AnexoAux As String = cAnexo
        Dim Accionistas As New DocumentosDSTableAdapters.PLD_AccionistasTableAdapter
        Dim dsDocs As New DocumentosDS
        If InStr(AnexoAux, "/") Then AnexoAux = Mid(AnexoAux, 1, 5) + Mid(AnexoAux, 7, 4)
        Accionistas.Fill(dsDocs.PLD_Accionistas, AnexoAux)
        For Each r As DocumentosDS.PLD_AccionistasRow In dsDocs.PLD_Accionistas.Rows
            DocPLD(r.Acreditado, 1, r.Tipo, r.Representante, r.Representante)
            If r.Tipo = "M" Then
                DOC_Pld.F3_AVAL_PM(r.Acreditado.Trim, r.Personalidad.Trim, cCusnam, (cFechacon).ToLower, cContrato, cLugar, r.Representante.Trim)
            Else
                DOC_Pld.F3_AVAL_PF(r.Acreditado.Trim, r.Personalidad.Trim, cCusnam, (cFechacon).ToLower, cContrato, cLugar)
            End If
        Next

        dsAgil = Nothing
        cnAgil.Dispose()
        cm1.Dispose()
    End Sub

    Public Function DocPLD(ByVal cName As String, ByVal cDato As Integer, ByVal cTav As String, ByVal cRepaval As String, ByVal cRepresentante As String) As String
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daDatos As New SqlDataAdapter(cm1)
        Dim drDato As DataRow
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim drAnexo As DataRow
        Dim drTotal As DataRow
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document

        Dim cContrato As String

        cContrato = Mid(cAnexo, 1, 5) & Mid(cAnexo, 7, 4)

        If cDato = 0 Then
            If cTipo <> "PERSONA MORAL" Then
                oRuta = DocCopiaLocal("F:\PLD\PLD_ClientePF.doc", 2)
            Else
                oRuta = DocCopiaLocal("F:\PLD\PLD_ClientePM.doc", 2)
            End If
        Else
            If cTipo = "PERSONA MORAL" Then
                If cTav <> "M" Then
                    oRuta = DocCopiaLocal("F:\PLD\PLD_F5_AvalPF.doc", 2)
                Else
                    oRuta = DocCopiaLocal("F:\PLD\PLD_F5_AvalPM.doc", 2)
                End If
            Else
                oRuta = DocCopiaLocal("F:\PLD\PLD_F5_AvalPF.doc", 2)
            End If
        End If
        oWord = New Microsoft.Office.Interop.Word.Application()
        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantillatR

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        With oWordDoc.Sections(1)
            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
        End With

        For Each myMField In oWordDoc.Fields
            rFieldCode = myMField.Code
            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then
                finMerge = cFieldText.IndexOf("\")
                fieldNameLen = cFieldText.Length - finMerge
                cfName = cFieldText.Substring(11, finMerge - 11)
                cfName = cfName.Trim()
                Select Case cfName

                    Case "mRef"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 7, 4))
                    Case "mCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cName)
                    Case "mRepre"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRepresentante.Trim
                    Case "mRepav"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cRepaval)
                    Case "mLugar"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLugar
                    Case "mFecha"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFechacon).ToLower
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
        Dim oMissing = System.Reflection.Missing.Value

        oWord.ActiveDocument.Select()
        oWord.WordBasic.ToString()
        oWord.Visible = True

        If cDato = 0 Then
            Dim oSaveAsFile = "C:\contratos\" & cName & "_PLD_CTEPF" & cContrato & ".doc"
            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
        Else
            If cTipo = "PERSONA MORAL" Then
                If cTav <> "M" Then
                    Dim oSaveAsFile = "C:\contratos\" & cName & "_PLD_AVALPF_CPM" & cContrato & ".doc"
                    oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
                Else
                    Dim oSaveAsFile = "C:\contratos\" & cName & "_PLD_AVALPM" & cContrato & ".doc"
                    oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
                End If
            Else
                Dim oSaveAsFile = "C:\contratos\" & cName & "_PLD_AVALPF" & cContrato & ".doc"
                oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            End If
        End If
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedIndex >= 0 Then
            Dim ta As New PromocionDSTableAdapters.PromotoresTableAdapter
            Dim cContrato As String = ""
            cContrato = Mid(cAnexo, 1, 5) & Mid(cAnexo, 7, 4)

            ta.UpdatePromo2(ComboBox1.SelectedValue, cContrato)
            Label1.Visible = False
            ComboBox1.Visible = False
        End If

    End Sub

    Private Sub BtnAdenda_Click(sender As Object, e As EventArgs) Handles BtnAdenda.Click
        Cursor.Current = Cursors.WaitCursor
        DOC_LIQUIDEZ.SacaConvenio(cAnexo.Substring(0, 5) & cAnexo.Substring(6, 4))
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub BtnCarta_Click(sender As Object, e As EventArgs) Handles BtnCarta.Click
        Cursor.Current = Cursors.WaitCursor
        DOC_LIQUIDEZ.SacaCartaAutoriza(cAnexo.Substring(0, 5) & cAnexo.Substring(6, 4))
        Cursor.Current = Cursors.Default
    End Sub
End Class

