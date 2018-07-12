Option Explicit On 

Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Math

Public Class frmActuaDat

    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal cSolicitud As String, ByVal cDisposicion As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.Text = "Datos del Financiamiento Solicitud " & cSolicitud & " Disposición " & cDisposicion
        lblSolicitud.Text = cSolicitud
        lblDisposicion.Text = cDisposicion

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFechac As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFechaven1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblIva As System.Windows.Forms.Label
    Friend WithEvents txtPorop As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotEq As System.Windows.Forms.TextBox
    Friend WithEvents txtPorco As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gpoPagos As System.Windows.Forms.GroupBox
    Friend WithEvents txtMensu As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoFinanciado As System.Windows.Forms.TextBox
    Friend WithEvents txtOpcion As System.Windows.Forms.TextBox
    Friend WithEvents txtIvaeq As System.Windows.Forms.TextBox
    Friend WithEvents lblIvaeq As System.Windows.Forms.Label
    Friend WithEvents lblRtaeq As System.Windows.Forms.Label
    Friend WithEvents lblOpcom As System.Windows.Forms.Label
    Friend WithEvents lblMontof As System.Windows.Forms.Label
    Friend WithEvents lblCriteriotasa As System.Windows.Forms.Label
    Friend WithEvents lblTipotasa As System.Windows.Forms.Label
    Friend WithEvents lblFrecpag As System.Windows.Forms.Label
    Friend WithEvents lblEqmap As System.Windows.Forms.Label
    Friend WithEvents gpoPagosi As System.Windows.Forms.GroupBox
    Friend WithEvents txtNafin As System.Windows.Forms.TextBox
    Friend WithEvents txtGastos As System.Windows.Forms.TextBox
    Friend WithEvents txtIvaRD As System.Windows.Forms.TextBox
    Friend WithEvents txtImpRD As System.Windows.Forms.TextBox
    Friend WithEvents txtComis As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalpagos As System.Windows.Forms.Label
    Friend WithEvents lblNafin As System.Windows.Forms.Label
    Friend WithEvents lblRatific As System.Windows.Forms.Label
    Friend WithEvents lblIvag As System.Windows.Forms.Label
    Friend WithEvents lblDepos As System.Windows.Forms.Label
    Friend WithEvents lblComis As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbTasas As System.Windows.Forms.ComboBox
    Friend WithEvents cbCriterios As System.Windows.Forms.ComboBox
    Friend WithEvents cbFrecuencias As System.Windows.Forms.ComboBox
    Friend WithEvents cbEsquemas As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dtpFechacon As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFvenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPagosIniciales As System.Windows.Forms.TextBox
    Friend WithEvents txtIvaAmorin As System.Windows.Forms.TextBox
    Friend WithEvents lblIvaamortiza As System.Windows.Forms.Label
    Friend WithEvents txtAmorin As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbGPFalse As System.Windows.Forms.RadioButton
    Friend WithEvents rbGPTrue As System.Windows.Forms.RadioButton
    Friend WithEvents lblGaran As System.Windows.Forms.Label
    Friend WithEvents lblPlazo As System.Windows.Forms.Label
    Friend WithEvents txtTermina As System.Windows.Forms.TextBox
    Friend WithEvents lblFechafin As System.Windows.Forms.Label
    Friend WithEvents txtImpEq As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblSolicitud As System.Windows.Forms.Label
    Friend WithEvents lblDisposicion As System.Windows.Forms.Label
    Friend WithEvents lblDepNafin As System.Windows.Forms.Label
    Friend WithEvents panelDepNafin As System.Windows.Forms.Panel
    Friend WithEvents rbDNTrue As System.Windows.Forms.RadioButton
    Friend WithEvents rbDNFalse As System.Windows.Forms.RadioButton
    Friend WithEvents cbPorieq As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtRtasDep As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cbRtas As System.Windows.Forms.ComboBox
    Friend WithEvents rbRDFalse As System.Windows.Forms.RadioButton
    Friend WithEvents rbRDTrue As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbPlazo As System.Windows.Forms.ComboBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents rbDGFalse As System.Windows.Forms.RadioButton
    Friend WithEvents rbDGTrue As System.Windows.Forms.RadioButton
    Friend WithEvents lblRtasD As System.Windows.Forms.Label
    Friend WithEvents gpoTasaAplicable As System.Windows.Forms.GroupBox
    Friend WithEvents txtTasas As System.Windows.Forms.TextBox
    Friend WithEvents lblTasaInteres As System.Windows.Forms.Label
    Friend WithEvents lblDifer As System.Windows.Forms.Label
    Friend WithEvents txtDifer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblAmortiza As System.Windows.Forms.Label
    Friend WithEvents cbRecursos As System.Windows.Forms.ComboBox
    Friend WithEvents lblRecursos As System.Windows.Forms.Label
    Friend WithEvents cbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPIGastos As System.Windows.Forms.TextBox
    Friend WithEvents txtPIAmorin As System.Windows.Forms.TextBox
    Friend WithEvents lblPIRatific As System.Windows.Forms.Label
    Friend WithEvents lblPIAmortiza As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtIvaRtasDep As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbDomiNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbDomiSi As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rbCAutoNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbCAutoSi As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents gbNomina As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents rbPEmpNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbPEmpSi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDias As System.Windows.Forms.RadioButton
    Friend WithEvents rbMeses As System.Windows.Forms.RadioButton
    Friend WithEvents txtAmortizaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbDias As System.Windows.Forms.ComboBox
    Friend WithEvents cbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents txtPlanta As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents rbCNomNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbCNomSi As System.Windows.Forms.RadioButton
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtFondoReserva As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtFondoReser As System.Windows.Forms.TextBox
    Friend WithEvents cbTasaIVAcap As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents CmbAuto As System.Windows.Forms.ComboBox
    Friend WithEvents ChkTasa As System.Windows.Forms.CheckBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TxtDepGporc As TextBox
    Friend WithEvents TxtDepG As TextBox
    Friend WithEvents lblDescr As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblNumc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFechac = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFechaven1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.txtPorop = New System.Windows.Forms.TextBox()
        Me.txtSubtotEq = New System.Windows.Forms.TextBox()
        Me.txtPorco = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpoPagos = New System.Windows.Forms.GroupBox()
        Me.txtTermina = New System.Windows.Forms.TextBox()
        Me.lblFechafin = New System.Windows.Forms.Label()
        Me.txtMensu = New System.Windows.Forms.TextBox()
        Me.txtMontoFinanciado = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtImpEq = New System.Windows.Forms.TextBox()
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.txtIvaeq = New System.Windows.Forms.TextBox()
        Me.lblIvaeq = New System.Windows.Forms.Label()
        Me.lblRtaeq = New System.Windows.Forms.Label()
        Me.lblOpcom = New System.Windows.Forms.Label()
        Me.lblMontof = New System.Windows.Forms.Label()
        Me.lblCriteriotasa = New System.Windows.Forms.Label()
        Me.lblTipotasa = New System.Windows.Forms.Label()
        Me.lblFrecpag = New System.Windows.Forms.Label()
        Me.lblEqmap = New System.Windows.Forms.Label()
        Me.gpoPagosi = New System.Windows.Forms.GroupBox()
        Me.txtFondoReserva = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtIvaRtasDep = New System.Windows.Forms.TextBox()
        Me.txtPIGastos = New System.Windows.Forms.TextBox()
        Me.txtPIAmorin = New System.Windows.Forms.TextBox()
        Me.lblPIRatific = New System.Windows.Forms.Label()
        Me.lblPIAmortiza = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRtasDep = New System.Windows.Forms.TextBox()
        Me.txtIvaAmorin = New System.Windows.Forms.TextBox()
        Me.lblIvaamortiza = New System.Windows.Forms.Label()
        Me.txtPagosIniciales = New System.Windows.Forms.TextBox()
        Me.txtNafin = New System.Windows.Forms.TextBox()
        Me.txtIvaRD = New System.Windows.Forms.TextBox()
        Me.txtImpRD = New System.Windows.Forms.TextBox()
        Me.txtComis = New System.Windows.Forms.TextBox()
        Me.lblTotalpagos = New System.Windows.Forms.Label()
        Me.lblNafin = New System.Windows.Forms.Label()
        Me.lblIvag = New System.Windows.Forms.Label()
        Me.lblDepos = New System.Windows.Forms.Label()
        Me.lblComis = New System.Windows.Forms.Label()
        Me.txtAmorin = New System.Windows.Forms.TextBox()
        Me.txtGastos = New System.Windows.Forms.TextBox()
        Me.lblRatific = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbTasas = New System.Windows.Forms.ComboBox()
        Me.cbCriterios = New System.Windows.Forms.ComboBox()
        Me.cbFrecuencias = New System.Windows.Forms.ComboBox()
        Me.cbEsquemas = New System.Windows.Forms.ComboBox()
        Me.dtpFechacon = New System.Windows.Forms.DateTimePicker()
        Me.dtpFvenc = New System.Windows.Forms.DateTimePicker()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbGPFalse = New System.Windows.Forms.RadioButton()
        Me.rbGPTrue = New System.Windows.Forms.RadioButton()
        Me.lblGaran = New System.Windows.Forms.Label()
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.lblSolicitud = New System.Windows.Forms.Label()
        Me.lblDisposicion = New System.Windows.Forms.Label()
        Me.lblDescr = New System.Windows.Forms.Label()
        Me.panelDepNafin = New System.Windows.Forms.Panel()
        Me.lblDepNafin = New System.Windows.Forms.Label()
        Me.rbDNTrue = New System.Windows.Forms.RadioButton()
        Me.rbDNFalse = New System.Windows.Forms.RadioButton()
        Me.cbPorieq = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbRtas = New System.Windows.Forms.ComboBox()
        Me.rbRDFalse = New System.Windows.Forms.RadioButton()
        Me.rbRDTrue = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbPlazo = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtDepG = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxtDepGporc = New System.Windows.Forms.TextBox()
        Me.rbDGFalse = New System.Windows.Forms.RadioButton()
        Me.rbDGTrue = New System.Windows.Forms.RadioButton()
        Me.lblRtasD = New System.Windows.Forms.Label()
        Me.gpoTasaAplicable = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTasas = New System.Windows.Forms.TextBox()
        Me.lblTasaInteres = New System.Windows.Forms.Label()
        Me.lblDifer = New System.Windows.Forms.Label()
        Me.txtDifer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblAmortiza = New System.Windows.Forms.Label()
        Me.cbRecursos = New System.Windows.Forms.ComboBox()
        Me.lblRecursos = New System.Windows.Forms.Label()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbDomiNo = New System.Windows.Forms.RadioButton()
        Me.rbDomiSi = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rbCAutoNo = New System.Windows.Forms.RadioButton()
        Me.rbCAutoSi = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbNomina = New System.Windows.Forms.GroupBox()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbEmpresa = New System.Windows.Forms.ComboBox()
        Me.txtPlanta = New System.Windows.Forms.TextBox()
        Me.txtAmortizaciones = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbDias = New System.Windows.Forms.ComboBox()
        Me.cbMeses = New System.Windows.Forms.ComboBox()
        Me.rbDias = New System.Windows.Forms.RadioButton()
        Me.rbMeses = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.rbPEmpNo = New System.Windows.Forms.RadioButton()
        Me.rbPEmpSi = New System.Windows.Forms.RadioButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.rbCNomNo = New System.Windows.Forms.RadioButton()
        Me.rbCNomSi = New System.Windows.Forms.RadioButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtFondoReser = New System.Windows.Forms.TextBox()
        Me.cbTasaIVAcap = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CmbAuto = New System.Windows.Forms.ComboBox()
        Me.ChkTasa = New System.Windows.Forms.CheckBox()
        Me.gpoPagos.SuspendLayout()
        Me.gpoPagosi.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelDepNafin.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.gpoTasaAplicable.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gbNomina.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumc
        '
        Me.lblNumc.Location = New System.Drawing.Point(16, 12)
        Me.lblNumc.Name = "lblNumc"
        Me.lblNumc.Size = New System.Drawing.Size(48, 16)
        Me.lblNumc.TabIndex = 62
        Me.lblNumc.Text = "Solicitud"
        Me.lblNumc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 414)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "%"
        '
        'lblFechac
        '
        Me.lblFechac.Location = New System.Drawing.Point(16, 106)
        Me.lblFechac.Name = "lblFechac"
        Me.lblFechac.Size = New System.Drawing.Size(128, 16)
        Me.lblFechac.TabIndex = 64
        Me.lblFechac.Text = "Fecha de Contratación"
        Me.lblFechac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 436)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Opción de Compra"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaven1
        '
        Me.lblFechaven1.Location = New System.Drawing.Point(16, 130)
        Me.lblFechaven1.Name = "lblFechaven1"
        Me.lblFechaven1.Size = New System.Drawing.Size(128, 16)
        Me.lblFechaven1.TabIndex = 65
        Me.lblFechaven1.Text = "Fecha 1er. Vencimiento"
        Me.lblFechaven1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Comisión"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIva
        '
        Me.lblIva.Location = New System.Drawing.Point(16, 247)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(128, 16)
        Me.lblIva.TabIndex = 71
        Me.lblIva.Text = "Porcentaje de I.V.A."
        Me.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPorop
        '
        Me.txtPorop.Location = New System.Drawing.Point(144, 436)
        Me.txtPorop.Name = "txtPorop"
        Me.txtPorop.Size = New System.Drawing.Size(64, 20)
        Me.txtPorop.TabIndex = 84
        Me.txtPorop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubtotEq
        '
        Me.txtSubtotEq.Location = New System.Drawing.Point(144, 153)
        Me.txtSubtotEq.Name = "txtSubtotEq"
        Me.txtSubtotEq.Size = New System.Drawing.Size(88, 20)
        Me.txtSubtotEq.TabIndex = 80
        Me.txtSubtotEq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPorco
        '
        Me.txtPorco.Location = New System.Drawing.Point(144, 412)
        Me.txtPorco.Name = "txtPorco"
        Me.txtPorco.Size = New System.Drawing.Size(64, 20)
        Me.txtPorco.TabIndex = 82
        Me.txtPorco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "%"
        '
        'gpoPagos
        '
        Me.gpoPagos.Controls.Add(Me.txtTermina)
        Me.gpoPagos.Controls.Add(Me.lblFechafin)
        Me.gpoPagos.Controls.Add(Me.txtMensu)
        Me.gpoPagos.Controls.Add(Me.txtMontoFinanciado)
        Me.gpoPagos.Controls.Add(Me.Label27)
        Me.gpoPagos.Controls.Add(Me.txtImpEq)
        Me.gpoPagos.Controls.Add(Me.txtOpcion)
        Me.gpoPagos.Controls.Add(Me.txtIvaeq)
        Me.gpoPagos.Controls.Add(Me.lblIvaeq)
        Me.gpoPagos.Controls.Add(Me.lblRtaeq)
        Me.gpoPagos.Controls.Add(Me.lblOpcom)
        Me.gpoPagos.Controls.Add(Me.lblMontof)
        Me.gpoPagos.Location = New System.Drawing.Point(384, 48)
        Me.gpoPagos.Name = "gpoPagos"
        Me.gpoPagos.Size = New System.Drawing.Size(264, 160)
        Me.gpoPagos.TabIndex = 104
        Me.gpoPagos.TabStop = False
        '
        'txtTermina
        '
        Me.txtTermina.Location = New System.Drawing.Point(168, 16)
        Me.txtTermina.Name = "txtTermina"
        Me.txtTermina.ReadOnly = True
        Me.txtTermina.Size = New System.Drawing.Size(88, 20)
        Me.txtTermina.TabIndex = 80
        Me.txtTermina.TabStop = False
        Me.txtTermina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFechafin
        '
        Me.lblFechafin.Location = New System.Drawing.Point(8, 16)
        Me.lblFechafin.Name = "lblFechafin"
        Me.lblFechafin.Size = New System.Drawing.Size(144, 16)
        Me.lblFechafin.TabIndex = 79
        Me.lblFechafin.Text = "Fecha de Terminación"
        Me.lblFechafin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMensu
        '
        Me.txtMensu.Location = New System.Drawing.Point(168, 112)
        Me.txtMensu.Name = "txtMensu"
        Me.txtMensu.ReadOnly = True
        Me.txtMensu.Size = New System.Drawing.Size(88, 20)
        Me.txtMensu.TabIndex = 78
        Me.txtMensu.TabStop = False
        Me.txtMensu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMontoFinanciado
        '
        Me.txtMontoFinanciado.Location = New System.Drawing.Point(168, 136)
        Me.txtMontoFinanciado.Name = "txtMontoFinanciado"
        Me.txtMontoFinanciado.ReadOnly = True
        Me.txtMontoFinanciado.Size = New System.Drawing.Size(88, 20)
        Me.txtMontoFinanciado.TabIndex = 76
        Me.txtMontoFinanciado.TabStop = False
        Me.txtMontoFinanciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(8, 41)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(112, 16)
        Me.Label27.TabIndex = 143
        Me.Label27.Text = "Equipo con I.V.A."
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtImpEq
        '
        Me.txtImpEq.Location = New System.Drawing.Point(168, 40)
        Me.txtImpEq.Name = "txtImpEq"
        Me.txtImpEq.ReadOnly = True
        Me.txtImpEq.Size = New System.Drawing.Size(88, 20)
        Me.txtImpEq.TabIndex = 144
        Me.txtImpEq.TabStop = False
        Me.txtImpEq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOpcion
        '
        Me.txtOpcion.Location = New System.Drawing.Point(168, 88)
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.ReadOnly = True
        Me.txtOpcion.Size = New System.Drawing.Size(88, 20)
        Me.txtOpcion.TabIndex = 74
        Me.txtOpcion.TabStop = False
        Me.txtOpcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIvaeq
        '
        Me.txtIvaeq.Location = New System.Drawing.Point(168, 64)
        Me.txtIvaeq.Name = "txtIvaeq"
        Me.txtIvaeq.ReadOnly = True
        Me.txtIvaeq.Size = New System.Drawing.Size(88, 20)
        Me.txtIvaeq.TabIndex = 65
        Me.txtIvaeq.TabStop = False
        Me.txtIvaeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblIvaeq
        '
        Me.lblIvaeq.Location = New System.Drawing.Point(8, 64)
        Me.lblIvaeq.Name = "lblIvaeq"
        Me.lblIvaeq.Size = New System.Drawing.Size(144, 16)
        Me.lblIvaeq.TabIndex = 57
        Me.lblIvaeq.Text = "I.V.A. del Equipo"
        Me.lblIvaeq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRtaeq
        '
        Me.lblRtaeq.Location = New System.Drawing.Point(8, 112)
        Me.lblRtaeq.Name = "lblRtaeq"
        Me.lblRtaeq.Size = New System.Drawing.Size(144, 16)
        Me.lblRtaeq.TabIndex = 56
        Me.lblRtaeq.Text = "Renta del Equipo"
        Me.lblRtaeq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOpcom
        '
        Me.lblOpcom.Location = New System.Drawing.Point(8, 88)
        Me.lblOpcom.Name = "lblOpcom"
        Me.lblOpcom.Size = New System.Drawing.Size(144, 16)
        Me.lblOpcom.TabIndex = 55
        Me.lblOpcom.Text = "Opción a compra con I.V.A."
        Me.lblOpcom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMontof
        '
        Me.lblMontof.Location = New System.Drawing.Point(8, 136)
        Me.lblMontof.Name = "lblMontof"
        Me.lblMontof.Size = New System.Drawing.Size(144, 16)
        Me.lblMontof.TabIndex = 54
        Me.lblMontof.Text = "Monto Financiado"
        Me.lblMontof.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCriteriotasa
        '
        Me.lblCriteriotasa.Location = New System.Drawing.Point(16, 316)
        Me.lblCriteriotasa.Name = "lblCriteriotasa"
        Me.lblCriteriotasa.Size = New System.Drawing.Size(128, 16)
        Me.lblCriteriotasa.TabIndex = 76
        Me.lblCriteriotasa.Text = "Criterio de Tasa"
        Me.lblCriteriotasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipotasa
        '
        Me.lblTipotasa.Location = New System.Drawing.Point(16, 388)
        Me.lblTipotasa.Name = "lblTipotasa"
        Me.lblTipotasa.Size = New System.Drawing.Size(128, 16)
        Me.lblTipotasa.TabIndex = 102
        Me.lblTipotasa.Text = "Tipo de Tasa"
        Me.lblTipotasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFrecpag
        '
        Me.lblFrecpag.Location = New System.Drawing.Point(16, 340)
        Me.lblFrecpag.Name = "lblFrecpag"
        Me.lblFrecpag.Size = New System.Drawing.Size(128, 16)
        Me.lblFrecpag.TabIndex = 77
        Me.lblFrecpag.Text = "Frecuencia de pago"
        Me.lblFrecpag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEqmap
        '
        Me.lblEqmap.Location = New System.Drawing.Point(16, 364)
        Me.lblEqmap.Name = "lblEqmap"
        Me.lblEqmap.Size = New System.Drawing.Size(128, 16)
        Me.lblEqmap.TabIndex = 94
        Me.lblEqmap.Text = "Esquema de Pagos"
        Me.lblEqmap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gpoPagosi
        '
        Me.gpoPagosi.Controls.Add(Me.txtFondoReserva)
        Me.gpoPagosi.Controls.Add(Me.Label24)
        Me.gpoPagosi.Controls.Add(Me.Label13)
        Me.gpoPagosi.Controls.Add(Me.txtIvaRtasDep)
        Me.gpoPagosi.Controls.Add(Me.txtPIGastos)
        Me.gpoPagosi.Controls.Add(Me.txtPIAmorin)
        Me.gpoPagosi.Controls.Add(Me.lblPIRatific)
        Me.gpoPagosi.Controls.Add(Me.lblPIAmortiza)
        Me.gpoPagosi.Controls.Add(Me.Label11)
        Me.gpoPagosi.Controls.Add(Me.txtRtasDep)
        Me.gpoPagosi.Controls.Add(Me.txtIvaAmorin)
        Me.gpoPagosi.Controls.Add(Me.lblIvaamortiza)
        Me.gpoPagosi.Controls.Add(Me.txtPagosIniciales)
        Me.gpoPagosi.Controls.Add(Me.txtNafin)
        Me.gpoPagosi.Controls.Add(Me.txtIvaRD)
        Me.gpoPagosi.Controls.Add(Me.txtImpRD)
        Me.gpoPagosi.Controls.Add(Me.txtComis)
        Me.gpoPagosi.Controls.Add(Me.lblTotalpagos)
        Me.gpoPagosi.Controls.Add(Me.lblNafin)
        Me.gpoPagosi.Controls.Add(Me.lblIvag)
        Me.gpoPagosi.Controls.Add(Me.lblDepos)
        Me.gpoPagosi.Controls.Add(Me.lblComis)
        Me.gpoPagosi.Location = New System.Drawing.Point(384, 298)
        Me.gpoPagosi.Name = "gpoPagosi"
        Me.gpoPagosi.Size = New System.Drawing.Size(264, 300)
        Me.gpoPagosi.TabIndex = 105
        Me.gpoPagosi.TabStop = False
        Me.gpoPagosi.Text = "Pagos Iniciales"
        '
        'txtFondoReserva
        '
        Me.txtFondoReserva.Location = New System.Drawing.Point(168, 238)
        Me.txtFondoReserva.Name = "txtFondoReserva"
        Me.txtFondoReserva.ReadOnly = True
        Me.txtFondoReserva.Size = New System.Drawing.Size(88, 20)
        Me.txtFondoReserva.TabIndex = 83
        Me.txtFondoReserva.TabStop = False
        Me.txtFondoReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(8, 238)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(155, 16)
        Me.Label24.TabIndex = 82
        Me.Label24.Text = "Fondo de Reserva"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(155, 16)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "I.V.A. Rentas en Depósito"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIvaRtasDep
        '
        Me.txtIvaRtasDep.Location = New System.Drawing.Point(168, 214)
        Me.txtIvaRtasDep.Name = "txtIvaRtasDep"
        Me.txtIvaRtasDep.ReadOnly = True
        Me.txtIvaRtasDep.Size = New System.Drawing.Size(88, 20)
        Me.txtIvaRtasDep.TabIndex = 80
        Me.txtIvaRtasDep.TabStop = False
        Me.txtIvaRtasDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPIGastos
        '
        Me.txtPIGastos.Location = New System.Drawing.Point(168, 142)
        Me.txtPIGastos.Name = "txtPIGastos"
        Me.txtPIGastos.ReadOnly = True
        Me.txtPIGastos.Size = New System.Drawing.Size(88, 20)
        Me.txtPIGastos.TabIndex = 79
        Me.txtPIGastos.TabStop = False
        Me.txtPIGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPIAmorin
        '
        Me.txtPIAmorin.Location = New System.Drawing.Point(168, 22)
        Me.txtPIAmorin.Name = "txtPIAmorin"
        Me.txtPIAmorin.ReadOnly = True
        Me.txtPIAmorin.Size = New System.Drawing.Size(88, 20)
        Me.txtPIAmorin.TabIndex = 78
        Me.txtPIAmorin.TabStop = False
        Me.txtPIAmorin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPIRatific
        '
        Me.lblPIRatific.Location = New System.Drawing.Point(8, 142)
        Me.lblPIRatific.Name = "lblPIRatific"
        Me.lblPIRatific.Size = New System.Drawing.Size(155, 16)
        Me.lblPIRatific.TabIndex = 77
        Me.lblPIRatific.Text = "Ratificación con I.V.A."
        Me.lblPIRatific.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPIAmortiza
        '
        Me.lblPIAmortiza.Location = New System.Drawing.Point(8, 22)
        Me.lblPIAmortiza.Name = "lblPIAmortiza"
        Me.lblPIAmortiza.Size = New System.Drawing.Size(155, 16)
        Me.lblPIAmortiza.TabIndex = 76
        Me.lblPIAmortiza.Text = "Amortización Inicial"
        Me.lblPIAmortiza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 16)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Rentas en Depósito"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRtasDep
        '
        Me.txtRtasDep.Location = New System.Drawing.Point(168, 190)
        Me.txtRtasDep.Name = "txtRtasDep"
        Me.txtRtasDep.ReadOnly = True
        Me.txtRtasDep.Size = New System.Drawing.Size(88, 20)
        Me.txtRtasDep.TabIndex = 74
        Me.txtRtasDep.TabStop = False
        Me.txtRtasDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIvaAmorin
        '
        Me.txtIvaAmorin.Location = New System.Drawing.Point(168, 46)
        Me.txtIvaAmorin.Name = "txtIvaAmorin"
        Me.txtIvaAmorin.ReadOnly = True
        Me.txtIvaAmorin.Size = New System.Drawing.Size(88, 20)
        Me.txtIvaAmorin.TabIndex = 71
        Me.txtIvaAmorin.TabStop = False
        Me.txtIvaAmorin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblIvaamortiza
        '
        Me.lblIvaamortiza.Location = New System.Drawing.Point(8, 46)
        Me.lblIvaamortiza.Name = "lblIvaamortiza"
        Me.lblIvaamortiza.Size = New System.Drawing.Size(155, 16)
        Me.lblIvaamortiza.TabIndex = 70
        Me.lblIvaamortiza.Text = "I.V.A. de la Amortización"
        Me.lblIvaamortiza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPagosIniciales
        '
        Me.txtPagosIniciales.Location = New System.Drawing.Point(168, 272)
        Me.txtPagosIniciales.Name = "txtPagosIniciales"
        Me.txtPagosIniciales.ReadOnly = True
        Me.txtPagosIniciales.Size = New System.Drawing.Size(88, 20)
        Me.txtPagosIniciales.TabIndex = 64
        Me.txtPagosIniciales.TabStop = False
        Me.txtPagosIniciales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNafin
        '
        Me.txtNafin.Location = New System.Drawing.Point(168, 166)
        Me.txtNafin.Name = "txtNafin"
        Me.txtNafin.ReadOnly = True
        Me.txtNafin.Size = New System.Drawing.Size(88, 20)
        Me.txtNafin.TabIndex = 62
        Me.txtNafin.TabStop = False
        Me.txtNafin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIvaRD
        '
        Me.txtIvaRD.Location = New System.Drawing.Point(168, 118)
        Me.txtIvaRD.Name = "txtIvaRD"
        Me.txtIvaRD.ReadOnly = True
        Me.txtIvaRD.Size = New System.Drawing.Size(88, 20)
        Me.txtIvaRD.TabIndex = 58
        Me.txtIvaRD.TabStop = False
        Me.txtIvaRD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpRD
        '
        Me.txtImpRD.Location = New System.Drawing.Point(168, 94)
        Me.txtImpRD.Name = "txtImpRD"
        Me.txtImpRD.ReadOnly = True
        Me.txtImpRD.Size = New System.Drawing.Size(88, 20)
        Me.txtImpRD.TabIndex = 56
        Me.txtImpRD.TabStop = False
        Me.txtImpRD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtComis
        '
        Me.txtComis.Location = New System.Drawing.Point(168, 70)
        Me.txtComis.Name = "txtComis"
        Me.txtComis.ReadOnly = True
        Me.txtComis.Size = New System.Drawing.Size(88, 20)
        Me.txtComis.TabIndex = 54
        Me.txtComis.TabStop = False
        Me.txtComis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalpagos
        '
        Me.lblTotalpagos.Location = New System.Drawing.Point(8, 272)
        Me.lblTotalpagos.Name = "lblTotalpagos"
        Me.lblTotalpagos.Size = New System.Drawing.Size(155, 16)
        Me.lblTotalpagos.TabIndex = 52
        Me.lblTotalpagos.Text = "Total de Pagos Iniciales"
        Me.lblTotalpagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNafin
        '
        Me.lblNafin.Location = New System.Drawing.Point(8, 166)
        Me.lblNafin.Name = "lblNafin"
        Me.lblNafin.Size = New System.Drawing.Size(155, 16)
        Me.lblNafin.TabIndex = 51
        Me.lblNafin.Text = "5 % NAFIN"
        Me.lblNafin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIvag
        '
        Me.lblIvag.Location = New System.Drawing.Point(8, 118)
        Me.lblIvag.Name = "lblIvag"
        Me.lblIvag.Size = New System.Drawing.Size(155, 16)
        Me.lblIvag.TabIndex = 49
        Me.lblIvag.Text = "I.V.A. del Depósito"
        Me.lblIvag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepos
        '
        Me.lblDepos.Location = New System.Drawing.Point(8, 94)
        Me.lblDepos.Name = "lblDepos"
        Me.lblDepos.Size = New System.Drawing.Size(155, 16)
        Me.lblDepos.TabIndex = 48
        Me.lblDepos.Text = "Depósito en Garantía"
        Me.lblDepos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblComis
        '
        Me.lblComis.Location = New System.Drawing.Point(8, 70)
        Me.lblComis.Name = "lblComis"
        Me.lblComis.Size = New System.Drawing.Size(155, 16)
        Me.lblComis.TabIndex = 47
        Me.lblComis.Text = "Comisión con I.V.A."
        Me.lblComis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAmorin
        '
        Me.txtAmorin.Location = New System.Drawing.Point(144, 177)
        Me.txtAmorin.Name = "txtAmorin"
        Me.txtAmorin.Size = New System.Drawing.Size(88, 20)
        Me.txtAmorin.TabIndex = 73
        Me.txtAmorin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGastos
        '
        Me.txtGastos.Location = New System.Drawing.Point(144, 224)
        Me.txtGastos.Name = "txtGastos"
        Me.txtGastos.Size = New System.Drawing.Size(88, 20)
        Me.txtGastos.TabIndex = 60
        Me.txtGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRatific
        '
        Me.lblRatific.Location = New System.Drawing.Point(16, 224)
        Me.lblRatific.Name = "lblRatific"
        Me.lblRatific.Size = New System.Drawing.Size(128, 16)
        Me.lblRatific.TabIndex = 50
        Me.lblRatific.Text = "Ratificación con I.V.A."
        Me.lblRatific.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(798, 61)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(128, 23)
        Me.btnGuardar.TabIndex = 110
        Me.btnGuardar.Text = "Guardar Cambios"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(932, 61)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(128, 23)
        Me.btnSalir.TabIndex = 111
        Me.btnSalir.Text = "Salir"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(128, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Disposición"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbTasas
        '
        Me.cbTasas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTasas.Location = New System.Drawing.Point(144, 388)
        Me.cbTasas.Name = "cbTasas"
        Me.cbTasas.Size = New System.Drawing.Size(224, 21)
        Me.cbTasas.TabIndex = 119
        '
        'cbCriterios
        '
        Me.cbCriterios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCriterios.Location = New System.Drawing.Point(144, 316)
        Me.cbCriterios.Name = "cbCriterios"
        Me.cbCriterios.Size = New System.Drawing.Size(224, 21)
        Me.cbCriterios.TabIndex = 120
        '
        'cbFrecuencias
        '
        Me.cbFrecuencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFrecuencias.Location = New System.Drawing.Point(144, 340)
        Me.cbFrecuencias.Name = "cbFrecuencias"
        Me.cbFrecuencias.Size = New System.Drawing.Size(224, 21)
        Me.cbFrecuencias.TabIndex = 121
        '
        'cbEsquemas
        '
        Me.cbEsquemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEsquemas.Location = New System.Drawing.Point(144, 364)
        Me.cbEsquemas.Name = "cbEsquemas"
        Me.cbEsquemas.Size = New System.Drawing.Size(224, 21)
        Me.cbEsquemas.TabIndex = 123
        '
        'dtpFechacon
        '
        Me.dtpFechacon.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechacon.Location = New System.Drawing.Point(144, 106)
        Me.dtpFechacon.Name = "dtpFechacon"
        Me.dtpFechacon.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechacon.TabIndex = 3
        '
        'dtpFvenc
        '
        Me.dtpFvenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFvenc.Location = New System.Drawing.Point(144, 130)
        Me.dtpFvenc.Name = "dtpFvenc"
        Me.dtpFvenc.Size = New System.Drawing.Size(88, 20)
        Me.dtpFvenc.TabIndex = 4
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(664, 62)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(128, 23)
        Me.btnCalcular.TabIndex = 128
        Me.btnCalcular.Text = "Calcular Datos"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbGPFalse)
        Me.Panel2.Controls.Add(Me.rbGPTrue)
        Me.Panel2.Controls.Add(Me.lblGaran)
        Me.Panel2.Location = New System.Drawing.Point(7, 567)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 32)
        Me.Panel2.TabIndex = 135
        '
        'rbGPFalse
        '
        Me.rbGPFalse.Location = New System.Drawing.Point(179, 8)
        Me.rbGPFalse.Name = "rbGPFalse"
        Me.rbGPFalse.Size = New System.Drawing.Size(40, 16)
        Me.rbGPFalse.TabIndex = 135
        Me.rbGPFalse.Text = "No"
        '
        'rbGPTrue
        '
        Me.rbGPTrue.Location = New System.Drawing.Point(129, 8)
        Me.rbGPTrue.Name = "rbGPTrue"
        Me.rbGPTrue.Size = New System.Drawing.Size(40, 16)
        Me.rbGPTrue.TabIndex = 134
        Me.rbGPTrue.Text = "Sí"
        '
        'lblGaran
        '
        Me.lblGaran.Location = New System.Drawing.Point(8, 8)
        Me.lblGaran.Name = "lblGaran"
        Me.lblGaran.Size = New System.Drawing.Size(112, 16)
        Me.lblGaran.TabIndex = 133
        Me.lblGaran.Text = "Garantía Prendaria"
        Me.lblGaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlazo
        '
        Me.lblPlazo.Location = New System.Drawing.Point(16, 292)
        Me.lblPlazo.Name = "lblPlazo"
        Me.lblPlazo.Size = New System.Drawing.Size(128, 16)
        Me.lblPlazo.TabIndex = 141
        Me.lblPlazo.Text = "Plazo en meses"
        Me.lblPlazo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSolicitud
        '
        Me.lblSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolicitud.Location = New System.Drawing.Point(72, 12)
        Me.lblSolicitud.Name = "lblSolicitud"
        Me.lblSolicitud.Size = New System.Drawing.Size(48, 16)
        Me.lblSolicitud.TabIndex = 145
        Me.lblSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisposicion
        '
        Me.lblDisposicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisposicion.Location = New System.Drawing.Point(192, 12)
        Me.lblDisposicion.Name = "lblDisposicion"
        Me.lblDisposicion.Size = New System.Drawing.Size(24, 16)
        Me.lblDisposicion.TabIndex = 146
        Me.lblDisposicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescr
        '
        Me.lblDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescr.Location = New System.Drawing.Point(232, 12)
        Me.lblDescr.Name = "lblDescr"
        Me.lblDescr.Size = New System.Drawing.Size(560, 16)
        Me.lblDescr.TabIndex = 147
        Me.lblDescr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelDepNafin
        '
        Me.panelDepNafin.Controls.Add(Me.lblDepNafin)
        Me.panelDepNafin.Controls.Add(Me.rbDNTrue)
        Me.panelDepNafin.Controls.Add(Me.rbDNFalse)
        Me.panelDepNafin.Location = New System.Drawing.Point(7, 532)
        Me.panelDepNafin.Name = "panelDepNafin"
        Me.panelDepNafin.Size = New System.Drawing.Size(240, 32)
        Me.panelDepNafin.TabIndex = 148
        '
        'lblDepNafin
        '
        Me.lblDepNafin.Location = New System.Drawing.Point(8, 8)
        Me.lblDepNafin.Name = "lblDepNafin"
        Me.lblDepNafin.Size = New System.Drawing.Size(112, 16)
        Me.lblDepNafin.TabIndex = 134
        Me.lblDepNafin.Text = "5% Depósito NAFIN"
        Me.lblDepNafin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbDNTrue
        '
        Me.rbDNTrue.Location = New System.Drawing.Point(129, 8)
        Me.rbDNTrue.Name = "rbDNTrue"
        Me.rbDNTrue.Size = New System.Drawing.Size(40, 16)
        Me.rbDNTrue.TabIndex = 134
        Me.rbDNTrue.TabStop = True
        Me.rbDNTrue.Text = "Sí"
        Me.rbDNTrue.UseVisualStyleBackColor = True
        '
        'rbDNFalse
        '
        Me.rbDNFalse.Location = New System.Drawing.Point(179, 8)
        Me.rbDNFalse.Name = "rbDNFalse"
        Me.rbDNFalse.Size = New System.Drawing.Size(40, 16)
        Me.rbDNFalse.TabIndex = 135
        Me.rbDNFalse.TabStop = True
        Me.rbDNFalse.Text = "No"
        Me.rbDNFalse.UseVisualStyleBackColor = True
        '
        'cbPorieq
        '
        Me.cbPorieq.FormattingEnabled = True
        Me.cbPorieq.Location = New System.Drawing.Point(144, 247)
        Me.cbPorieq.Name = "cbPorieq"
        Me.cbPorieq.Size = New System.Drawing.Size(47, 21)
        Me.cbPorieq.TabIndex = 149
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 16)
        Me.Label10.TabIndex = 150
        Me.Label10.Text = "Subtotal del Equipo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cbRtas)
        Me.Panel4.Controls.Add(Me.rbRDFalse)
        Me.Panel4.Controls.Add(Me.rbRDTrue)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Enabled = False
        Me.Panel4.Location = New System.Drawing.Point(8, 462)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(360, 32)
        Me.Panel4.TabIndex = 151
        '
        'cbRtas
        '
        Me.cbRtas.Enabled = False
        Me.cbRtas.FormattingEnabled = True
        Me.cbRtas.Location = New System.Drawing.Point(313, 6)
        Me.cbRtas.Name = "cbRtas"
        Me.cbRtas.Size = New System.Drawing.Size(45, 21)
        Me.cbRtas.TabIndex = 150
        '
        'rbRDFalse
        '
        Me.rbRDFalse.Location = New System.Drawing.Point(179, 8)
        Me.rbRDFalse.Name = "rbRDFalse"
        Me.rbRDFalse.Size = New System.Drawing.Size(40, 16)
        Me.rbRDFalse.TabIndex = 133
        Me.rbRDFalse.Text = "No"
        '
        'rbRDTrue
        '
        Me.rbRDTrue.Location = New System.Drawing.Point(129, 8)
        Me.rbRDTrue.Name = "rbRDTrue"
        Me.rbRDTrue.Size = New System.Drawing.Size(40, 16)
        Me.rbRDTrue.TabIndex = 132
        Me.rbRDTrue.Text = "Sí"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 16)
        Me.Label12.TabIndex = 131
        Me.Label12.Text = "Rentas en Depósito "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbPlazo
        '
        Me.cbPlazo.FormattingEnabled = True
        Me.cbPlazo.Location = New System.Drawing.Point(144, 292)
        Me.cbPlazo.Name = "cbPlazo"
        Me.cbPlazo.Size = New System.Drawing.Size(47, 21)
        Me.cbPlazo.TabIndex = 153
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TxtDepG)
        Me.Panel5.Controls.Add(Me.Label28)
        Me.Panel5.Controls.Add(Me.TxtDepGporc)
        Me.Panel5.Controls.Add(Me.rbDGFalse)
        Me.Panel5.Controls.Add(Me.rbDGTrue)
        Me.Panel5.Controls.Add(Me.lblRtasD)
        Me.Panel5.Location = New System.Drawing.Point(7, 497)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(360, 32)
        Me.Panel5.TabIndex = 154
        '
        'TxtDepG
        '
        Me.TxtDepG.Location = New System.Drawing.Point(217, 6)
        Me.TxtDepG.Name = "TxtDepG"
        Me.TxtDepG.Size = New System.Drawing.Size(81, 20)
        Me.TxtDepG.TabIndex = 171
        Me.TxtDepG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(344, 7)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 18)
        Me.Label28.TabIndex = 170
        Me.Label28.Text = "%"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDepGporc
        '
        Me.TxtDepGporc.Location = New System.Drawing.Point(303, 6)
        Me.TxtDepGporc.Name = "TxtDepGporc"
        Me.TxtDepGporc.ReadOnly = True
        Me.TxtDepGporc.Size = New System.Drawing.Size(40, 20)
        Me.TxtDepGporc.TabIndex = 169
        Me.TxtDepGporc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rbDGFalse
        '
        Me.rbDGFalse.Location = New System.Drawing.Point(179, 8)
        Me.rbDGFalse.Name = "rbDGFalse"
        Me.rbDGFalse.Size = New System.Drawing.Size(40, 16)
        Me.rbDGFalse.TabIndex = 133
        Me.rbDGFalse.Text = "No"
        '
        'rbDGTrue
        '
        Me.rbDGTrue.Location = New System.Drawing.Point(129, 8)
        Me.rbDGTrue.Name = "rbDGTrue"
        Me.rbDGTrue.Size = New System.Drawing.Size(40, 16)
        Me.rbDGTrue.TabIndex = 132
        Me.rbDGTrue.Text = "Sí"
        '
        'lblRtasD
        '
        Me.lblRtasD.Location = New System.Drawing.Point(8, 8)
        Me.lblRtasD.Name = "lblRtasD"
        Me.lblRtasD.Size = New System.Drawing.Size(112, 16)
        Me.lblRtasD.TabIndex = 131
        Me.lblRtasD.Text = "Depósito en Garantía"
        Me.lblRtasD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gpoTasaAplicable
        '
        Me.gpoTasaAplicable.Controls.Add(Me.Label6)
        Me.gpoTasaAplicable.Controls.Add(Me.Label5)
        Me.gpoTasaAplicable.Controls.Add(Me.txtTasas)
        Me.gpoTasaAplicable.Controls.Add(Me.lblTasaInteres)
        Me.gpoTasaAplicable.Controls.Add(Me.lblDifer)
        Me.gpoTasaAplicable.Controls.Add(Me.txtDifer)
        Me.gpoTasaAplicable.Location = New System.Drawing.Point(384, 216)
        Me.gpoTasaAplicable.Name = "gpoTasaAplicable"
        Me.gpoTasaAplicable.Size = New System.Drawing.Size(264, 74)
        Me.gpoTasaAplicable.TabIndex = 155
        Me.gpoTasaAplicable.TabStop = False
        Me.gpoTasaAplicable.Text = "Tasa aplicable"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(235, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "%"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(235, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "%"
        '
        'txtTasas
        '
        Me.txtTasas.Location = New System.Drawing.Point(169, 22)
        Me.txtTasas.Name = "txtTasas"
        Me.txtTasas.Size = New System.Drawing.Size(64, 20)
        Me.txtTasas.TabIndex = 80
        Me.txtTasas.TabStop = False
        Me.txtTasas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTasaInteres
        '
        Me.lblTasaInteres.Location = New System.Drawing.Point(8, 22)
        Me.lblTasaInteres.Name = "lblTasaInteres"
        Me.lblTasaInteres.Size = New System.Drawing.Size(92, 16)
        Me.lblTasaInteres.TabIndex = 79
        Me.lblTasaInteres.Text = "Tasa de interés"
        Me.lblTasaInteres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDifer
        '
        Me.lblDifer.Location = New System.Drawing.Point(8, 46)
        Me.lblDifer.Name = "lblDifer"
        Me.lblDifer.Size = New System.Drawing.Size(92, 16)
        Me.lblDifer.TabIndex = 143
        Me.lblDifer.Text = "Diferencial"
        Me.lblDifer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDifer
        '
        Me.txtDifer.Location = New System.Drawing.Point(169, 46)
        Me.txtDifer.Name = "txtDifer"
        Me.txtDifer.Size = New System.Drawing.Size(64, 20)
        Me.txtDifer.TabIndex = 144
        Me.txtDifer.TabStop = False
        Me.txtDifer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(209, 438)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 16)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "%"
        '
        'lblAmortiza
        '
        Me.lblAmortiza.Location = New System.Drawing.Point(16, 177)
        Me.lblAmortiza.Name = "lblAmortiza"
        Me.lblAmortiza.Size = New System.Drawing.Size(128, 16)
        Me.lblAmortiza.TabIndex = 157
        Me.lblAmortiza.Text = "Amortización Inicial"
        Me.lblAmortiza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbRecursos
        '
        Me.cbRecursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRecursos.Location = New System.Drawing.Point(144, 82)
        Me.cbRecursos.Name = "cbRecursos"
        Me.cbRecursos.Size = New System.Drawing.Size(224, 21)
        Me.cbRecursos.TabIndex = 159
        '
        'lblRecursos
        '
        Me.lblRecursos.Location = New System.Drawing.Point(15, 82)
        Me.lblRecursos.Name = "lblRecursos"
        Me.lblRecursos.Size = New System.Drawing.Size(128, 16)
        Me.lblRecursos.TabIndex = 158
        Me.lblRecursos.Text = "Recursos"
        Me.lblRecursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbProducto
        '
        Me.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProducto.Location = New System.Drawing.Point(144, 58)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(224, 21)
        Me.cbProducto.TabIndex = 161
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(15, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 16)
        Me.Label8.TabIndex = 160
        Me.Label8.Text = "Producto"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbDomiNo)
        Me.Panel1.Controls.Add(Me.rbDomiSi)
        Me.Panel1.Location = New System.Drawing.Point(12, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(139, 35)
        Me.Panel1.TabIndex = 163
        '
        'rbDomiNo
        '
        Me.rbDomiNo.Location = New System.Drawing.Point(80, 11)
        Me.rbDomiNo.Name = "rbDomiNo"
        Me.rbDomiNo.Size = New System.Drawing.Size(40, 16)
        Me.rbDomiNo.TabIndex = 135
        Me.rbDomiNo.Tag = "    "
        Me.rbDomiNo.Text = "No"
        '
        'rbDomiSi
        '
        Me.rbDomiSi.Location = New System.Drawing.Point(11, 11)
        Me.rbDomiSi.Name = "rbDomiSi"
        Me.rbDomiSi.Size = New System.Drawing.Size(40, 16)
        Me.rbDomiSi.TabIndex = 134
        Me.rbDomiSi.Text = "Sí"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(9, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 133
        Me.Label14.Text = "Pago Domiciliado"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbCAutoNo)
        Me.Panel3.Controls.Add(Me.rbCAutoSi)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Location = New System.Drawing.Point(665, 158)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(213, 32)
        Me.Panel3.TabIndex = 164
        '
        'rbCAutoNo
        '
        Me.rbCAutoNo.Location = New System.Drawing.Point(166, 8)
        Me.rbCAutoNo.Name = "rbCAutoNo"
        Me.rbCAutoNo.Size = New System.Drawing.Size(40, 16)
        Me.rbCAutoNo.TabIndex = 135
        Me.rbCAutoNo.Text = "No"
        '
        'rbCAutoSi
        '
        Me.rbCAutoSi.Location = New System.Drawing.Point(110, 8)
        Me.rbCAutoSi.Name = "rbCAutoSi"
        Me.rbCAutoSi.Size = New System.Drawing.Size(40, 16)
        Me.rbCAutoSi.TabIndex = 134
        Me.rbCAutoSi.Text = "Sí"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 16)
        Me.Label15.TabIndex = 133
        Me.Label15.Text = "Crédito Autoágil"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbNomina
        '
        Me.gbNomina.Controls.Add(Me.txtEmpresa)
        Me.gbNomina.Controls.Add(Me.Label22)
        Me.gbNomina.Controls.Add(Me.Label21)
        Me.gbNomina.Controls.Add(Me.Label20)
        Me.gbNomina.Controls.Add(Me.Label19)
        Me.gbNomina.Controls.Add(Me.cbEmpresa)
        Me.gbNomina.Controls.Add(Me.txtPlanta)
        Me.gbNomina.Controls.Add(Me.txtAmortizaciones)
        Me.gbNomina.Controls.Add(Me.GroupBox2)
        Me.gbNomina.Controls.Add(Me.Label16)
        Me.gbNomina.Controls.Add(Me.Panel6)
        Me.gbNomina.Controls.Add(Me.Panel1)
        Me.gbNomina.Controls.Add(Me.Label14)
        Me.gbNomina.Location = New System.Drawing.Point(664, 242)
        Me.gbNomina.Name = "gbNomina"
        Me.gbNomina.Size = New System.Drawing.Size(439, 325)
        Me.gbNomina.TabIndex = 165
        Me.gbNomina.TabStop = False
        Me.gbNomina.Text = "Datos Adicionales para Creditos de Nomina y Autoágil"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(230, 180)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(10, 20)
        Me.txtEmpresa.TabIndex = 175
        Me.txtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmpresa.Visible = False
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(166, 245)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(112, 16)
        Me.Label22.TabIndex = 174
        Me.Label22.Text = "Planta"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(163, 180)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 16)
        Me.Label21.TabIndex = 173
        Me.Label21.Text = "Empresa"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(11, 197)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 16)
        Me.Label20.TabIndex = 172
        Me.Label20.Text = "Num. de Pagos"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(68, 224)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 16)
        Me.Label19.TabIndex = 171
        Me.Label19.Text = "1 a 160"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbEmpresa
        '
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Location = New System.Drawing.Point(164, 203)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(209, 21)
        Me.cbEmpresa.TabIndex = 170
        '
        'txtPlanta
        '
        Me.txtPlanta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlanta.Location = New System.Drawing.Point(169, 270)
        Me.txtPlanta.Name = "txtPlanta"
        Me.txtPlanta.Size = New System.Drawing.Size(204, 20)
        Me.txtPlanta.TabIndex = 169
        Me.txtPlanta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmortizaciones
        '
        Me.txtAmortizaciones.Location = New System.Drawing.Point(14, 220)
        Me.txtAmortizaciones.Name = "txtAmortizaciones"
        Me.txtAmortizaciones.Size = New System.Drawing.Size(48, 20)
        Me.txtAmortizaciones.TabIndex = 167
        Me.txtAmortizaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.cbDias)
        Me.GroupBox2.Controls.Add(Me.cbMeses)
        Me.GroupBox2.Controls.Add(Me.rbDias)
        Me.GroupBox2.Controls.Add(Me.rbMeses)
        Me.GroupBox2.Location = New System.Drawing.Point(169, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 133)
        Me.GroupBox2.TabIndex = 166
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Frecuencia de los pagos"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(182, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 16)
        Me.Label18.TabIndex = 154
        Me.Label18.Text = "7, 14 ó 15"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(179, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 16)
        Me.Label17.TabIndex = 153
        Me.Label17.Text = "1 a 12"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbDias
        '
        Me.cbDias.FormattingEnabled = True
        Me.cbDias.Items.AddRange(New Object() {"7", "14", "15"})
        Me.cbDias.Location = New System.Drawing.Point(122, 85)
        Me.cbDias.Name = "cbDias"
        Me.cbDias.Size = New System.Drawing.Size(52, 21)
        Me.cbDias.TabIndex = 152
        '
        'cbMeses
        '
        Me.cbMeses.FormattingEnabled = True
        Me.cbMeses.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbMeses.Location = New System.Drawing.Point(122, 40)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Size = New System.Drawing.Size(53, 21)
        Me.cbMeses.TabIndex = 151
        '
        'rbDias
        '
        Me.rbDias.Location = New System.Drawing.Point(14, 85)
        Me.rbDias.Name = "rbDias"
        Me.rbDias.Size = New System.Drawing.Size(88, 21)
        Me.rbDias.TabIndex = 136
        Me.rbDias.Text = "Cada n días"
        '
        'rbMeses
        '
        Me.rbMeses.Location = New System.Drawing.Point(14, 41)
        Me.rbMeses.Name = "rbMeses"
        Me.rbMeses.Size = New System.Drawing.Size(102, 16)
        Me.rbMeses.TabIndex = 135
        Me.rbMeses.Text = "Cada n meses"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(9, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 16)
        Me.Label16.TabIndex = 165
        Me.Label16.Text = "Paga la Empresa"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.rbPEmpNo)
        Me.Panel6.Controls.Add(Me.rbPEmpSi)
        Me.Panel6.Location = New System.Drawing.Point(11, 122)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(139, 35)
        Me.Panel6.TabIndex = 164
        '
        'rbPEmpNo
        '
        Me.rbPEmpNo.Location = New System.Drawing.Point(80, 11)
        Me.rbPEmpNo.Name = "rbPEmpNo"
        Me.rbPEmpNo.Size = New System.Drawing.Size(40, 16)
        Me.rbPEmpNo.TabIndex = 135
        Me.rbPEmpNo.Tag = "    "
        Me.rbPEmpNo.Text = "No"
        '
        'rbPEmpSi
        '
        Me.rbPEmpSi.Location = New System.Drawing.Point(11, 11)
        Me.rbPEmpSi.Name = "rbPEmpSi"
        Me.rbPEmpSi.Size = New System.Drawing.Size(40, 16)
        Me.rbPEmpSi.TabIndex = 134
        Me.rbPEmpSi.Text = "Sí"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.rbCNomNo)
        Me.Panel7.Controls.Add(Me.rbCNomSi)
        Me.Panel7.Controls.Add(Me.Label23)
        Me.Panel7.Location = New System.Drawing.Point(664, 118)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(213, 32)
        Me.Panel7.TabIndex = 166
        '
        'rbCNomNo
        '
        Me.rbCNomNo.Location = New System.Drawing.Point(166, 8)
        Me.rbCNomNo.Name = "rbCNomNo"
        Me.rbCNomNo.Size = New System.Drawing.Size(40, 16)
        Me.rbCNomNo.TabIndex = 135
        Me.rbCNomNo.Text = "No"
        '
        'rbCNomSi
        '
        Me.rbCNomSi.Location = New System.Drawing.Point(110, 8)
        Me.rbCNomSi.Name = "rbCNomSi"
        Me.rbCNomSi.Size = New System.Drawing.Size(40, 16)
        Me.rbCNomSi.TabIndex = 134
        Me.rbCNomSi.Text = "Sí"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(8, 8)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(112, 16)
        Me.Label23.TabIndex = 133
        Me.Label23.Text = "Crédito de Nomina"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(16, 200)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(128, 16)
        Me.Label25.TabIndex = 168
        Me.Label25.Text = "Fondo de Reserva"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFondoReser
        '
        Me.txtFondoReser.Location = New System.Drawing.Point(144, 200)
        Me.txtFondoReser.Name = "txtFondoReser"
        Me.txtFondoReser.Size = New System.Drawing.Size(88, 20)
        Me.txtFondoReser.TabIndex = 167
        Me.txtFondoReser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbTasaIVAcap
        '
        Me.cbTasaIVAcap.FormattingEnabled = True
        Me.cbTasaIVAcap.Items.AddRange(New Object() {"0%", "16%", "EXE"})
        Me.cbTasaIVAcap.Location = New System.Drawing.Point(144, 270)
        Me.cbTasaIVAcap.Name = "cbTasaIVAcap"
        Me.cbTasaIVAcap.Size = New System.Drawing.Size(47, 21)
        Me.cbTasaIVAcap.TabIndex = 170
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(16, 270)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(128, 16)
        Me.Label26.TabIndex = 169
        Me.Label26.Text = "Tasa I.V.A. Capital"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbAuto
        '
        Me.CmbAuto.FormattingEnabled = True
        Me.CmbAuto.Items.AddRange(New Object() {"NO", "SI"})
        Me.CmbAuto.Location = New System.Drawing.Point(145, 200)
        Me.CmbAuto.Name = "CmbAuto"
        Me.CmbAuto.Size = New System.Drawing.Size(47, 21)
        Me.CmbAuto.TabIndex = 167
        Me.CmbAuto.Visible = False
        '
        'ChkTasa
        '
        Me.ChkTasa.AutoSize = True
        Me.ChkTasa.Location = New System.Drawing.Point(665, 39)
        Me.ChkTasa.Name = "ChkTasa"
        Me.ChkTasa.Size = New System.Drawing.Size(132, 17)
        Me.ChkTasa.TabIndex = 171
        Me.ChkTasa.Text = "No usar tasa Aplicable"
        Me.ChkTasa.UseVisualStyleBackColor = True
        '
        'frmActuaDat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1114, 610)
        Me.Controls.Add(Me.ChkTasa)
        Me.Controls.Add(Me.CmbAuto)
        Me.Controls.Add(Me.cbTasaIVAcap)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtFondoReser)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.gbNomina)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.cbProducto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbRecursos)
        Me.Controls.Add(Me.lblRecursos)
        Me.Controls.Add(Me.lblAmortiza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAmorin)
        Me.Controls.Add(Me.gpoTasaAplicable)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.cbPlazo)
        Me.Controls.Add(Me.txtGastos)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbPorieq)
        Me.Controls.Add(Me.panelDepNafin)
        Me.Controls.Add(Me.lblDescr)
        Me.Controls.Add(Me.lblRatific)
        Me.Controls.Add(Me.lblDisposicion)
        Me.Controls.Add(Me.lblSolicitud)
        Me.Controls.Add(Me.lblPlazo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.dtpFvenc)
        Me.Controls.Add(Me.dtpFechacon)
        Me.Controls.Add(Me.cbEsquemas)
        Me.Controls.Add(Me.cbFrecuencias)
        Me.Controls.Add(Me.cbCriterios)
        Me.Controls.Add(Me.cbTasas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblNumc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFechac)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblFechaven1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblIva)
        Me.Controls.Add(Me.txtPorop)
        Me.Controls.Add(Me.txtSubtotEq)
        Me.Controls.Add(Me.txtPorco)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gpoPagos)
        Me.Controls.Add(Me.lblCriteriotasa)
        Me.Controls.Add(Me.lblTipotasa)
        Me.Controls.Add(Me.lblFrecpag)
        Me.Controls.Add(Me.lblEqmap)
        Me.Controls.Add(Me.gpoPagosi)
        Me.Name = "frmActuaDat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del Financiamiento"
        Me.gpoPagos.ResumeLayout(False)
        Me.gpoPagos.PerformLayout()
        Me.gpoPagosi.ResumeLayout(False)
        Me.gpoPagosi.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.panelDepNafin.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.gpoTasaAplicable.ResumeLayout(False)
        Me.gpoTasaAplicable.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.gbNomina.ResumeLayout(False)
        Me.gbNomina.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' Declaración de variables de alcance privado

    Dim cTipar As String = ""
    Dim cAutomovil As String = "N"
    Dim nPorcentajeIVA As Decimal = 0.16
    Dim cFechacon As String
    Dim cFechaInip As String = ""
    Dim cFechaFinp As String = ""
    Dim cFechaInip1 As String = ""
    Dim cFechaFinp1 As String = ""

    Private Sub frmActuaDat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        Dim daDisposicion As New SqlDataAdapter(cm1)
        Dim daFrecuencias As New SqlDataAdapter(cm2)
        Dim daTasas As New SqlDataAdapter(cm3)
        Dim daEsquemas As New SqlDataAdapter(cm4)
        Dim daRecursos As New SqlDataAdapter(cm5)
        Dim daCriterios As New SqlDataAdapter(cm6)
        Dim daEquipos As New SqlDataAdapter(cm7)
        Dim daEmpresas As New SqlDataAdapter(cm8)
        Dim drDisposicion As DataRow
        Dim drEmp As DataRow

        ' Declaración de variables de datos

        Dim cDeposito As String
        Dim cFondeo As String
        Dim cPrenda As String
        Dim cDomi As String
        Dim cPEmp As String
        Dim nAmorin As Decimal
        Dim nComis As Decimal
        Dim nDG As Integer
        Dim nGastos As Decimal
        Dim nImpEq As Decimal
        Dim nImpRD As Decimal
        Dim nIvaAmorin As Decimal
        Dim nIvaRD As Decimal
        Dim nMensu As Decimal
        Dim nNafin As Decimal
        Dim nOpcion As Decimal
        Dim nPlazo As Decimal
        Dim nPorieq As Decimal
        Dim nPorOp As Decimal
        Dim nRD As Integer
        Dim nResidual As Decimal
        Dim nRtasD As Integer
        Dim nRtasDep As Decimal
        Dim nSaldoEquipo As Decimal
        Dim nSubTotal As Decimal
        Dim nTasaAplicable As Decimal
        Dim nVFrec As Integer
        Dim nID As Integer = 0
        Dim nFReserva As Decimal

        ' El botón para Guardar Cambios estará deshabilitado hasta que se oprima el botón
        ' Calcular Datos, a fin de que los campos derivados o calculados sean determinados
        ' y de esta forma asegurarnos que la información capturada sea la correcta

        btnGuardar.Enabled = False

        ' El siguiente Stored Procedure trae todos los atributos de la tabla DetSol,
        ' para una Solicitud y Disposición dados

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "ActuaDat1"
            .Connection = cnAgil
            .Parameters.Add("@Solicitud", SqlDbType.NVarChar)
            .Parameters.Add("@Disposicion", SqlDbType.NVarChar)
            .Parameters(0).Value = lblSolicitud.Text
            .Parameters(1).Value = lblDisposicion.Text
        End With

        ' El siguiente Stored Procedure trae todos los atributos de todas las Frecuencias

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Frecuencias1"
            .Connection = cnAgil
        End With

        ' El siguiente Stored Procedure trae todos los atributos de todas las Tasas

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Tasas1"
            .Connection = cnAgil
        End With

        ' El siguiente Stored Procedure trae todos los atributos de todos los Esquemas

        With cm4
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Esquemas1"
            .Connection = cnAgil
        End With

        ' El siguiente Stored Procedure trae todos los atributos de todos los Recursos

        With cm5
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Recursos1"
            .Connection = cnAgil
        End With

        ' El siguiente Stored Procedure trae todos los atributos de todos los Criterios

        With cm6
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Criterios1"
            .Connection = cnAgil
        End With

        ' El siguiente Stored Procedure trae todos los atributos de todos los Equipos

        With cm7
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Equipos1"
            .Connection = cnAgil
        End With

        ' El siguiente Consulta trae todos los atributos de todos las Empresas para Nomina

        With cm8
            .CommandType = CommandType.Text
            .CommandText = "Select * FROM EmpresasNom"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daDisposicion.Fill(dsAgil, "Disposicion")
        daFrecuencias.Fill(dsAgil, "Frecuencias")
        daTasas.Fill(dsAgil, "Tasas")
        daEsquemas.Fill(dsAgil, "Esquemas")
        daRecursos.Fill(dsAgil, "Recursos")
        daCriterios.Fill(dsAgil, "Criterios")
        daEquipos.Fill(dsAgil, "Equipos")
        daEmpresas.Fill(dsAgil, "Empresas")

        drDisposicion = dsAgil.Tables("Disposicion").Rows(0)

        ' Llenar el comboBox para mostrar el número de rentas en depósito (solo arrendamiento financiero o puro)

        cbRtas.Items.Add("0")
        'cbRtas.Items.Add("1")
        'cbRtas.Items.Add("2")
        'cbRtas.Items.Add("3")

        ' Llenar el comboBox para mostrar los productos.

        cbProducto.Items.Add("ARRENDAMIENTO FINANCIERO")
        cbProducto.Items.Add("ARRENDAMIENTO PURO")
        cbProducto.Items.Add("CREDITO REFACCIONARIO")
        cbProducto.Items.Add("CREDITO SIMPLE")
        cbProducto.Items.Add("CAP. DE TRABAJO PERMANENTE(AVIO)")
        cbProducto.SelectedIndex = 0

        ' Traer el nombre del cliente

        lblDescr.Text = drDisposicion("Descr")

        ' El IVA unicamente podra tener el valor de 0 ó 16 %

        cbPorieq.Items.Add(" 0")
        cbPorieq.Items.Add("16")

        If drDisposicion("Porieq") > 0 And drDisposicion("Impeq") > 0 Then
            cbPorieq.SelectedIndex = 1
        ElseIf drDisposicion("Porieq") = 0 And drDisposicion("Impeq") > 0 Then
            cbPorieq.SelectedIndex = 0
        ElseIf drDisposicion("Porieq") = 0 And drDisposicion("Impeq") = 0 Then
            cbPorieq.SelectedIndex = 1
        End If

        ' Establecer los valores que puede asumir la variable Plazo

        cbPlazo.Items.Add(" 6")
        cbPlazo.Items.Add("12")
        cbPlazo.Items.Add("18")
        cbPlazo.Items.Add("24")
        cbPlazo.Items.Add("36")
        cbPlazo.Items.Add("48")
        cbPlazo.Items.Add("60")

        ' Ligar la tabla Criterios del dataset dsAgil al ComboBox Criterios

        cbCriterios.DataSource = dsAgil
        cbCriterios.DisplayMember = "Criterios.DescCriterio"
        cbCriterios.ValueMember = "Criterios.Criterio"
        cbCriterios.SelectedIndex = Val(drDisposicion("Critas")) - 1

        ' Ligar la tabla Frecuencias del dataset dsAgil al ComboBox Frecuencias

        cbFrecuencias.DataSource = dsAgil
        cbFrecuencias.DisplayMember = "Frecuencias.DescFrecuencia"
        cbFrecuencias.ValueMember = "Frecuencias.Frecuencia"
        cbFrecuencias.SelectedIndex = Val(drDisposicion("Tippe")) - 1

        ' Ligar la tabla Recursos del dataset dsAgil al ComboBox Recursos

        cbRecursos.DataSource = dsAgil
        cbRecursos.DisplayMember = "Recursos.DescRecurso"
        cbRecursos.ValueMember = "Recursos.Recurso"
        cbRecursos.SelectedIndex = Val(drDisposicion("Fondeo")) - 1

        ' Ligar la tabla Esquemas del dataset dsAgil al ComboBox Esquemas

        cbEsquemas.DataSource = dsAgil
        cbEsquemas.DisplayMember = "Esquemas.DescEsquema"
        cbEsquemas.ValueMember = "Esquemas.Esquema"
        cbEsquemas.SelectedIndex = Val(drDisposicion("Forca")) - 1

        ' Ligar la tabla Tasas del dataset dsAgil al ComboBox Tasas

        cbTasas.DataSource = dsAgil
        cbTasas.DisplayMember = "Tasas.DescTasa"
        cbTasas.ValueMember = "Tasas.Tasa"
        cbTasas.SelectedIndex = 1

        ' Llenar las variables de datos con la información que viene de la tabla DetSol

        cTipar = drDisposicion("Tipar")
        cAutomovil = drDisposicion("Automovil")
        If cAutomovil = "N" Then
            CmbAuto.SelectedIndex = 0
        Else
            CmbAuto.SelectedIndex = 1
        End If
        cFondeo = drDisposicion("Fondeo")
        cFechacon = drDisposicion("Fechacon")
        nPorieq = drDisposicion("Porieq")
        nSaldoEquipo = drDisposicion("ImpEq") - drDisposicion("IvaEq") - drDisposicion("Amorin")
        nTasaAplicable = (drDisposicion("Tasas") + drDisposicion("Difer")) / 1200
        nPlazo = drDisposicion("Plazo")
        nAmorin = drDisposicion("Amorin")
        If cTipar = "R" Then
            nIvaAmorin = drDisposicion("Derechos")
        Else
            nIvaAmorin = drDisposicion("IvaAmorin")
        End If
        nComis = drDisposicion("Comis")
        nImpEq = drDisposicion("ImpEq")
        nPorOp = drDisposicion("PorOp")
        nDG = drDisposicion("DG")
        nImpRD = drDisposicion("ImpRD") + drDisposicion("IvaRD")
        nIvaRD = 0
        nRtasD = drDisposicion("RtasD")
        cPrenda = drDisposicion("Prenda")
        nGastos = drDisposicion("Gastos") + drDisposicion("IvaGastos")
        nRD = drDisposicion("RD")
        nRtasDep = drDisposicion("ImpDG") + drDisposicion("IvaDG")
        nSubTotal = drDisposicion("ImpEq") - drDisposicion("IvaEq")
        cDomi = drDisposicion("AceptaDomi")
        cPEmp = drDisposicion("PagaEmp")
        nVFrec = drDisposicion("ValorFrecuencia")
        nFReserva = drDisposicion("FondoReserva")

        If cTipar = "F" Then
            Label26.Visible = True
            cbTasaIVAcap.Visible = True
            If Not IsDBNull(drDisposicion("TasaIvaCapital")) Then
                If Trim(drDisposicion("TasaIvaCapital")) = "0%" Then
                    cbTasaIVAcap.SelectedIndex = 0
                ElseIf drDisposicion("TasaIvaCapital") = "16%" Then
                    cbTasaIVAcap.SelectedIndex = 1
                Else
                    cbTasaIVAcap.SelectedIndex = 2
                End If
            End If
        Else
            Label26.Visible = False
            cbTasaIVAcap.Visible = False
        End If

        ' Las Rentas en Depósito podrán ser 1, 2 ó 3 máximo 

        ''If nRD > 0 Then
        ''    rbRDTrue.Checked = True
        ''Else
        ''    rbRDFalse.Checked = True
        ''End If

        'cbRtas.SelectedIndex = nRD

        nNafin = 0
        rbDNFalse.Checked = True
        If cFondeo = "02" Then
            nNafin = drDisposicion("DepNafin")
            If nNafin > 0 Then
                rbDNTrue.Checked = True
            Else
                rbDNFalse.Checked = True
            End If
        End If

        If drDisposicion("CNom") = "CN" Or drDisposicion("CNom") = "CA" Then
            If drDisposicion("CNom") = "CN" Then
                rbCNomSi.Checked = True
            Else
                rbCAutoSi.Checked = True
                rbCNomSi.Checked = False
            End If
            If cDomi = "N" Then
                rbDomiNo.Checked = True
            Else
                rbDomiSi.Checked = True
            End If
            If cPEmp = "N" Then
                rbPEmpNo.Checked = True
            Else
                rbPEmpSi.Checked = True
            End If
            If drDisposicion("TipoFrecuencia") = "MESES" Then
                rbMeses.Checked = True
                cbMeses.SelectedIndex = nVFrec - 1
                txtAmortizaciones.Text = drDisposicion("Amortizaciones")
                cbEmpresa.SelectedItem = drDisposicion("CNEmpresa")
                txtEmpresa.Text = drDisposicion("CNEmpresa")
                txtPlanta.Text = drDisposicion("CNPlanta")
            Else
                rbMeses.Checked = False
                Select Case nVFrec
                    Case Is = 7
                        nVFrec = 0
                    Case Is = 14
                        nVFrec = 1
                    Case Is = 15
                        nVFrec = 2
                End Select
                cbDias.SelectedIndex = nVFrec
                txtAmortizaciones.Text = drDisposicion("Amortizaciones")
                txtEmpresa.Text = drDisposicion("CNEmpresa")
                txtPlanta.Text = drDisposicion("CNPlanta")
            End If
        End If

        ' Ligar la tabla Empresas del dataset dsAgil al ComboBox de Empresas

        For Each drEmp In dsAgil.Tables("Empresas").Rows
            If Trim(drEmp("NombreEmp")) = Trim(txtEmpresa.Text) Then
                nID = drEmp("IDEmp")
            End If
        Next

        cbEmpresa.DataSource = dsAgil
        cbEmpresa.DisplayMember = "Empresas.NombreEmp"
        cbEmpresa.ValueMember = "Empresas.IDEmp"
        cbEmpresa.SelectedIndex = nID - 1

        If cTipar = "F" Then
            cbProducto.SelectedIndex = 0
        ElseIf cTipar = "P" Then
            cbProducto.SelectedIndex = 1
        ElseIf cTipar = "R" Then
            cbProducto.SelectedIndex = 2
        ElseIf cTipar = "S" Then
            cbProducto.SelectedIndex = 3
        ElseIf cTipar = "T" Then
            cbProducto.SelectedIndex = 4
        End If

        If cPrenda = "S" Then
            rbGPTrue.Checked = True
        Else
            rbGPFalse.Checked = True
        End If

        If nRtasD = 0 And nImpRD > 0 Then
            cDeposito = "S"
            rbDGTrue.Checked = True
        Else
            cDeposito = "N"
            rbDGFalse.Checked = True
            nImpRD = 0
            nIvaRD = 0
        End If

        If Trim(cFechacon) = "" Then
            dtpFechacon.Value = Now()
        Else
            dtpFechacon.Value = CTOD(cFechacon)
        End If

        If Trim(drDisposicion("Fvenc")) = "" Then
            dtpFvenc.Value = Now()
        Else
            dtpFvenc.Value = CTOD(drDisposicion("Fvenc"))
        End If

        Select Case nPlazo
            Case 6
                cbPlazo.SelectedIndex = 0
            Case 12
                cbPlazo.SelectedIndex = 1
            Case 18
                cbPlazo.SelectedIndex = 2
            Case 24
                cbPlazo.SelectedIndex = 3
            Case 3
                cbPlazo.SelectedIndex = 4
            Case 48
                cbPlazo.SelectedIndex = 5
        End Select

        If Val(drDisposicion("Fvenc")) > 0 And drDisposicion("Plazo") > 0 Then
            txtTermina.Text = TerminaANT(CTOD(drDisposicion("Fvenc")), drDisposicion("Plazo"))
        End If

        txtPorco.Text = Format(drDisposicion("Porco"), "##,##0.00")
        If cTipar = "R" Or cTipar = "S" Then
            txtPorop.Text = Format(0, "##,##0.00")
        Else
            txtPorop.Text = Format(nPorOp, "##,##0.00")
        End If

        txtTasas.Text = Format(drDisposicion("Tasas"), "##,##0.0000")
        txtDifer.Text = Format(drDisposicion("Difer"), "##,##0.0000")

        txtImpEq.Text = Format(nImpEq, "##,##0.00")
        txtIvaeq.Text = Format(drDisposicion("IvaEq"), "##,##0.00")

        If cTipar = "P" Then
            nResidual = Round(nImpEq * nPorOp / 100, 2) / (1 + nPorcentajeIVA)
            txtOpcion.Text = Format(nResidual, "##,##0.00")
        Else
            nOpcion = Round(nImpEq * nPorOp / 100, 2)
            txtOpcion.Text = Format(nOpcion, "##,##0.00")
        End If

        If nSaldoEquipo > 0 Then
            If cTipar = "F" Or cTipar = "R" Or cTipar = "S" Then
                nMensu = Round(Pmt(nTasaAplicable, nPlazo, -nSaldoEquipo, 0), 2)
            ElseIf cTipar = "P" Then
                nMensu = Round(Pmt(nTasaAplicable, nPlazo, -nSaldoEquipo, nResidual), 2) * (1 + nPorcentajeIVA)
            End If
        Else
            nMensu = 0
        End If
        txtMensu.Text = Format(nMensu, "##,##0.00")
        txtMontoFinanciado.Text = Format(drDisposicion("ImpEq") - drDisposicion("IvaEq") - drDisposicion("Amorin"), "##,##0.00")

        ' Las cajas de texto pueden tener el formato ##,##0.00 ya que en esta parte solamente se utilizan
        ' para mostrarse; sin embargo, tengo que quitar este formato en el recálculo de los datos ya que
        ' este formato trunca el valor de la variable que tenga asignada

        txtAmorin.Text = Format(drDisposicion("Amorin"), "##,##0.00")
        txtGastos.Text = Format(nGastos, "##,##0.00")
        txtSubtotEq.Text = Format(nSubTotal, "##,##0.00")
        txtFondoReser.Text = Format(nFReserva, "##,##0.00")

        ' Despliego los pagos iniciales

        txtPIAmorin.Text = Format(nAmorin, "##,##0.00")
        txtIvaAmorin.Text = Format(nIvaAmorin, "##,##0.00")
        txtComis.Text = Format(nComis, "##,##0.00")
        txtImpRD.Text = Format(nImpRD, "##,##0.00")
        If nImpRD > 0 Then
            TxtDepG.Text = Format(nImpRD, "##,##0.00")
        End If
        txtIvaRD.Text = Format(nIvaRD, "##,##0.00")
        txtPIGastos.Text = Format(nGastos, "##,##0.00")
        txtNafin.Text = Format(nNafin, "##,##0.00")
        txtRtasDep.Text = Format(nRtasDep, "##,##0.00")
        txtFondoReserva.Text = Format(nFReserva, "##,##0.00")

        txtPagosIniciales.Text = Format(Round(nAmorin + nIvaAmorin + nComis + nImpRD + nIvaRD + nGastos + nNafin + nRtasDep + nFReserva, 2), "##,##0.00")

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
        cm4.Dispose()
        cm5.Dispose()
        cm6.Dispose()
        cm7.Dispose()

    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daTasasAplicables As New SqlDataAdapter(cm1)
        Dim daDerechos As New SqlDataAdapter(cm2)
        Dim daPeriodos As New SqlDataAdapter(cm4)
        Dim drDatos As DataRow
        Dim drPeriodo As DataRow

        ' Declaración de variables de datos

        Dim cFechaant As String
        Dim cFechacon As String
        Dim cFondeo As String
        Dim cForca As String
        Dim cTipta As String
        Dim dFeven As Date
        Dim eControl As Control
        Dim lCorrecto As Boolean
        Dim lDG As Boolean
        Dim lRD As Boolean
        Dim nAbCap As Decimal
        Dim nAmorin As Decimal
        Dim nCapitalEquipo As Decimal
        Dim nComis As Decimal
        Dim nDep As Decimal
        Dim nDG As Decimal
        Dim nDifer As Decimal
        Dim nGastos As Decimal
        Dim nImpEq As Decimal
        Dim nImpRD As Decimal
        Dim nInteresEquipo As Decimal
        Dim nIvaAmorin As Decimal
        Dim nIvaDep As Decimal
        Dim nIvaEq As Decimal
        Dim nIvaIntEq As Decimal
        Dim nIvaRD As Decimal
        Dim nLetra As Integer
        Dim nMensu As Decimal
        Dim nMontofin As Decimal
        Dim nNafin As Decimal
        Dim nOpcion As Decimal
        Dim nPlazo As Integer
        Dim nPorCo As Decimal
        Dim nPorieq As Decimal
        Dim nPorOp As Decimal
        Dim nRD As Integer
        Dim nRentaDep As Decimal
        Dim nRentaEquipo As Decimal
        Dim nResidual As Decimal
        Dim nSaldoEquipo As Decimal
        Dim nSuma As Integer
        Dim nTasaAplicable As Decimal
        Dim nTasas As Decimal
        Dim nFReserva As Decimal
        Dim nPeriodo As Integer
        Dim nDia As Integer

        lCorrecto = True
        cFechacon = DTOC(dtpFechacon.Value)

        ' Con este Stored Procedure obtengo la información del periodo vigente

        With cm4
            .CommandType = CommandType.Text
            .CommandText = "SELECT Periodo, FechaInip, FechaFinp, Vigente FROM PeriodoTasas Order by Periodo"
            .Connection = cnAgil
        End With

        daPeriodos.Fill(dsAgil, "Periodos")

        For Each drPeriodo In dsAgil.Tables("Periodos").Rows
            If drPeriodo("Vigente") = "S" Then
                cFechaInip = drPeriodo("FechaInip")
                cFechaFinp = drPeriodo("FechaFinp")
            ElseIf drPeriodo("Vigente") = "N" Then
                cFechaInip1 = drPeriodo("FechaInip")
                cFechaFinp1 = drPeriodo("FechaFinp")
            End If
            nPeriodo = drPeriodo("Periodo")
        Next

        ' Este procedimiento debe determinar los campos calculados y si la validación
        ' es correcta, habilitará el botón Guardar Cambios; en caso contrario, enviará
        ' mensajes de error de validación

        cTipta = Trim(cbTasas.SelectedValue)
        cFondeo = cbRecursos.SelectedValue
        nRD = 0 'cbRtas.SelectedIndex
        nDG = 0
        nDia = (dtpFechacon.Value).DayOfWeek

        If nDia = 0 Or nDia = 6 Then
            lCorrecto = False
            If nDia = 6 Then
                MsgBox("NO puedes contratar en día SABADO", MsgBoxStyle.Critical)
            ElseIf nDia = 0 Then
                MsgBox("NO puedes contratar en día DOMINGO", MsgBoxStyle.Critical)
            End If
        End If

        If cFechacon < cFechaInip Then
            lCorrecto = False
            MsgBox("NO puedes contratar con FECHA ANTERIOR al Periodo Vigente de Tasas", MsgBoxStyle.Critical, "Error de Validación")
        ElseIf (cFechacon > cFechaFinp And cFechaInip1 = "") Or (cFechacon > cFechaFinp1 And cFechaFinp1 <> "") Then
            lCorrecto = False
            MsgBox("NO puedes contratar con esta FECHA aún NO HAY Periodo Vigente de Tasas", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If cFondeo = "03" Then
            'If cTipta <> "7" Then
            '    lCorrecto = False
            '    MsgBox("Un contrato descontado con FIRA debe tener TASA FIJA", MsgBoxStyle.Critical, "Error de Validación")
            'End If
            dFeven = DayWeek(dtpFvenc.Value)
            If dFeven <> (dtpFvenc.Value).ToShortDateString Then
                lCorrecto = False
                MsgBox("El primer vencimiento debe ser el día " & dFeven.ToShortDateString, MsgBoxStyle.Critical, "Error de Validación")
            End If
        ElseIf Day(dtpFvenc.Value) <> 6 And Day(dtpFvenc.Value) <> 20 And Day(dtpFvenc.Value) <> 25 Then
            lCorrecto = False
            MsgBox("Solo existen vencimientos los días 6, 20 y 25", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If (Val(cbPlazo.SelectedItem) < 24 Or Val(cbPlazo.SelectedItem) > 36) And cFondeo = "02" Then
            lCorrecto = False
            MsgBox("Un contrato descontado con NAFIN solo tiene plazos de 24 a 36 meses", MsgBoxStyle.Critical, "Error de Validación")
        End If

        'If (Val(cbPlazo.SelectedItem) < 24 Or Val(cbPlazo.SelectedItem) > 36) And cFondeo >= "03" Then
        '    lCorrecto = False
        '    MsgBox("Un contrato descontado con FIRA solo tiene plazos de 24 a 36 meses", MsgBoxStyle.Critical, "Error de Validación")
        'End If

        If cFondeo = "02" Then
            lCorrecto = False
            MsgBox("Ya NO Operan Recursos NAFIN ", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If cFondeo <> "02" And rbDNTrue.Checked = True Then
            lCorrecto = False
            MsgBox("Solo los contratos descontados con NAFIN pueden tener 5% de Depósito", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If cFondeo = "03" And rbDGTrue.Checked = True Then
            lCorrecto = False
            MsgBox("Un contrato descontado con FIRA no puede tener Depósito en Garantía", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If Val(txtPorop.Text) < 0 Then
            lCorrecto = False
            MsgBox("El porcentaje de Opción de Compra no puede ser negativo", MsgBoxStyle.Critical, "Error de Validación")
        End If

        ' Validaciones para Arrendamiento Financiero

        If cTipar = "F" Then

            If cbPorieq.SelectedIndex() = 0 And rbDGTrue.Checked = True Then
                lCorrecto = False
                MsgBox("Arrendamiento Financiero sin IVA no puede tener Depósito en Garantía", MsgBoxStyle.Critical, "Error de Validación")
            End If

            If CDbl(txtAmorin.Text) < 0 Then
                lCorrecto = False
                MsgBox("El valor de la amortización inicial no puede ser negativo", MsgBoxStyle.Critical, "Error de Validación")
            End If

            ' Si elegimos que la operación tenga Rentas en Depósito, tenemos que indicar el número de éstas

            If rbRDTrue.Checked = True And nRD = 0 Then
                lCorrecto = False
                MsgBox("Selecciona el número de rentas en depósito", MsgBoxStyle.Critical, "Error de Validación")
            End If

        End If

        ' Validaciones para Arrendamiento Puro

        If cTipar = "P" Then

            If cFondeo <> "01" Then
                lCorrecto = False
                MsgBox("Arrendamiento Puro solo con Recursos Propios", MsgBoxStyle.Critical, "Error de Validación")
            End If

            If CDbl(txtAmorin.Text) > 0 Then
                lCorrecto = False
                MsgBox("No debe haber Amortización Inicial en contratos de Arrendamiento Puro", MsgBoxStyle.Critical, "Error de Validación")
            End If

            If Val(cbPlazo.SelectedItem) < 24 Then
                lCorrecto = False
                MsgBox("El plazo mínimo de un Arrendamiento Puro es de 24 meses", MsgBoxStyle.Critical, "Error de Validación")
            End If

            ' Si elegimos que la operación tenga Rentas en Depósito, tenemos que indicar el número de éstas

            If rbRDTrue.Checked = True And nRD = 0 Then
                lCorrecto = False
                MsgBox("Selecciona el número de rentas en depósito", MsgBoxStyle.Critical, "Error de Validación")
            End If

        End If

        ' Validaciones para Crédito Refaccionario

        If cTipar = "R" Then

            If cFondeo <> "01" Then
                lCorrecto = False
                MsgBox("Crédito Refaccionario solo con Recursos Propios", MsgBoxStyle.Critical, "Error de Validación")
            End If

            If CDbl(txtAmorin.Text) = 0 Then
                lCorrecto = False
                MsgBox("El valor del enganche no puede ser cero", MsgBoxStyle.Critical, "Error de Validación")
            End If

            If CDbl(txtAmorin.Text) < 0 Then
                lCorrecto = False
                MsgBox("El valor del enganche no puede ser negativo", MsgBoxStyle.Critical, "Error de Validación")
            End If
        End If

        ' Si elegimos que tenga Depósito en Garantía, el importe no puede ser cero
        If rbDGTrue.Checked = True And Not IsNumeric(TxtDepG.Text) Then
            lCorrecto = False
            MsgBox("Error en el importe del depósito en garantía", MsgBoxStyle.Critical, "Error de Validación")
            TxtDepG.Focus()
        End If

        If rbDGTrue.Checked = True And Val(TxtDepG.Text) <= 0 Then
            lCorrecto = False
            MsgBox("Error en el importe del depósito en garantía", MsgBoxStyle.Critical, "Error de Validación")
            TxtDepG.Focus()
        End If

        ' Validaciones generales aplicables a todo tipo de arrendamiento o crédito

        If CDbl(txtGastos.Text) < 0 Then
            lCorrecto = False
            MsgBox("Los Gastos de Ratificación con IVA no pueden ser negativos", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If Val(txtPorco.Text) < 0 Then
            lCorrecto = False
            MsgBox("El porcentaje de Comisión no puede ser negativo", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If CDbl(txtSubtotEq.Text) < 1000 Then
            lCorrecto = False
            MsgBox("El valor mínimo del Equipo con IVA es de $1,000.00", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If DateDiff(DateInterval.Day, dtpFechacon.Value, dtpFvenc.Value) < 16 Then
            lCorrecto = False
            MsgBox("No puede haber menos de 16 días entre la fecha de contratación y la fecha de 1er. vencimiento", MsgBoxStyle.Critical, "Error de Validación")
        End If

        'If Val(txtTasas.Text) <= 0 Then
        '    lCorrecto = False
        '    MsgBox("El valor de la tasa de interés debe ser mayor que cero", MsgBoxStyle.Critical, "Error de Validación")
        'End If

        'If Val(txtDifer.Text) <= 0 Then
        '    lCorrecto = False
        '    MsgBox("El valor del diferencial debe ser mayor que cero", MsgBoxStyle.Critical, "Error de Validación")
        'End If

        If lCorrecto = True Then

            cFechaant = DTOC(DateAdd(DateInterval.Month, -1, dtpFechacon.Value))

            ' El siguiente Stored Procedure trae todas las tasas aplicables para el tipo de crédito especificado

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

            ' Ahora defino el cuarto tipo de crédito

            cm1.Parameters(0).Value = "CR"
            daTasasAplicables.Fill(dsAgil, "CR")

            ' Ahora defino el quinto tipo de crédito

            cm1.Parameters(0).Value = "CS"
            daTasasAplicables.Fill(dsAgil, "CS")

            ' Ahora defino el sexto tipo de crédito

            cm1.Parameters(0).Value = "TVAFsinIVA"
            daTasasAplicables.Fill(dsAgil, "TVAFsinIVA")

            ' Ahora defino el séptimo tipo de crédito

            cm1.Parameters(0).Value = "TVAFconIVA"
            daTasasAplicables.Fill(dsAgil, "TVAFconIVA")

            ' Ahora defino el octavo tipo de crédito

            cm1.Parameters(0).Value = "TVAP"
            daTasasAplicables.Fill(dsAgil, "TVAP")

            ' Ahora defino el noveno tipo de crédito

            cm1.Parameters(0).Value = "TVCR"
            daTasasAplicables.Fill(dsAgil, "TVCR")

            ' Definimos el decimo tipo de crédito

            cm1.Parameters(0).Value = "TVCS"
            daTasasAplicables.Fill(dsAgil, "TVCS")

            ' El siguiente Stored Procedure trae todos los atributos de la Tabla Derechos

            With cm2
                .CommandType = CommandType.StoredProcedure
                .CommandText = "TraeDerechos"
                .Connection = cnAgil
            End With

            ' Este comando regresa el valor de la tasa TIIE para la vigencia dada o si la fecha de contratación
            ' es a futuro, regresa el valor más reciente de la tasa TIIE

            With cm3
                .CommandType = CommandType.Text
                .CommandText = "SELECT Valor FROM Hista WHERE Tasa = " & "'4'" & " AND Vigencia = '" & cFechacon & "'"
                .Connection = cnAgil
            End With

            ' Llenar el DataSet lo cual abre y cierra la conexión

            daDerechos.Fill(dsAgil, "Derechos")

            ' Ahora procedo a calcular los datos derivados

            nImpEq = CDbl(txtSubtotEq.Text)
            txtSubtotEq.Text = Format(nImpEq, "##,##0.00")
            nFReserva = CDbl(txtFondoReser.Text)
            txtFondoReserva.Text = Format(nFReserva, "##,##0.00")

            nIvaEq = 0
            nPorieq = 0
            If cbPorieq.SelectedIndex = 1 Then
                nPorieq = 16 / 100
                nIvaEq = Round(nImpEq * nPorieq, 2)
            End If
            nImpEq = CDbl(txtSubtotEq.Text) + nIvaEq

            nAmorin = CDbl(txtAmorin.Text)
            txtAmorin.Text = Format(nAmorin, "##,##0.00")
            txtPIAmorin.Text = Format(nAmorin, "##,##0.00")

            nSaldoEquipo = Round(nImpEq - nIvaEq - nAmorin, 2)
            nPlazo = Val(cbPlazo.SelectedItem)

            nMontofin = nImpEq - nIvaEq - nAmorin

            If rbDGTrue.Checked = True And Val(TxtDepG.Text) >= nMontofin Then
                MsgBox("Error en el importe del depósito en garantía no puede ser mayor al monto financiado.", MsgBoxStyle.Critical, "Error de Validación")
                TxtDepG.Focus()
                Exit Sub
            End If

            ' En esta parte se determina la tasa a partir de los datos del financiamiento o del crédito
            ' y en el caso de Arrendamiento Puro se determina el porcentaje de valor residual

            If rbRDTrue.Checked = True Then
                lRD = True
            ElseIf rbRDFalse.Checked = True Then
                lRD = False
            End If

            If rbDGTrue.Checked = True Then
                lDG = True
            ElseIf rbDGFalse.Checked = True Then
                lDG = False
            End If

            cnAgil.Open()
            nTasas = cm3.ExecuteScalar()
            cnAgil.Close()

            If nTasas = 0 Then

                ' Significa que no encontró la fecha dada por lo que debe traer el registro más reciente

                cm3.CommandText = "SELECT TOP 1 Valor FROM Hista WHERE Tasa = " & "'4'" & " ORDER BY Vigencia DESC"
                cnAgil.Open()
                nTasas = cm3.ExecuteScalar()
                cnAgil.Close()

            End If

            nDifer = 0
            nPorOp = 0

            If rbDGTrue.Checked = True Then
                nImpRD = Round(CDec(TxtDepG.Text), 2)
                nIvaRD = 0
                nDG = Round((nImpRD / nMontofin) * 100, 2)
                TxtDepGporc.Text = nDG
                Select Case nDG
                    Case >= 15
                        nDG = 3
                    Case >= 10
                        nDG = 2
                    Case >= 5
                        nDG = 1
                End Select
            Else
                TxtDepG.Text = ""
                TxtDepGporc.Text = ""
                nImpRD = 0
                nIvaRD = 0
                nDG = 0
            End If

            ' Esta función determina la tasa aplicable a un contrato (si es tasa fija),
            ' el diferencial (si es un contrato con tasa variable) y 
            ' el porcentaje de valor residual (si se trata de un arrendamiento puro)
            If ChkTasa.Checked = False Or Not IsNumeric(txtTasas.Text) Then
                TasaAplicable(cTipar, cTipta, nPlazo, nIvaEq, lRD, nRD, lDG, nDG, dsAgil, nTasas, nDifer, nPorOp)
            Else
                nTasas = txtTasas.Text
                nDifer = txtDifer.Text
            End If

            'nTasas = 14.75
            txtTasas.Text = Format(nTasas, "##,##0.0000")
            txtDifer.Text = Format(nDifer, "##,##0.0000")

            nTasaAplicable = (nTasas + nDifer) / 1200

            ' Aquí tengo que calcular el Valor Residual de los contratos de Arrendamiento Puro
            ' ya que el porcentaje se determinó algunas líneas arriba por lo que
            ' NO debemos mover esta sección de código.

            ' Para los contratos de Arrendamiento Financiero, se determina el porcentaje de la Opción de Compra
            ' y se calcula el monto de la misma 

            nPorCo = Val(txtPorco.Text) / 100

            nOpcion = 0
            nResidual = 0

            If cTipar = "F" Then

                nPorOp = 1
                nOpcion = Round(nImpEq * nPorOp / 100, 2)
                txtOpcion.Text = Format(nOpcion, "##,##0.00")

            ElseIf cTipar = "P" Then

                ' Recordar que el porcentaje del valor residual se calcula algunas líneas arriba por lo que
                ' NO debemos mover esta sección de código

                nResidual = Round(nImpEq * nPorOp / 100, 2) / (1 + nPorcentajeIVA)
                txtOpcion.Text = Format(nResidual, "##,##0.00")

            ElseIf cTipar = "R" Or cTipar = "S" Then

                ' Ni los Créditos Refaccionarios ni los Créditos Simples llevan Opción de Compra ni Valor Residual

                txtOpcion.Text = Format(nOpcion, "##,##0.00")

            End If

            txtPorop.Text = Format(nPorOp, "F")

            If cTipar = "F" Or cTipar = "R" Or cTipar = "S" Then

                ' Arrendamiento Financiero, Crédito Refaccionario, Crédito Simple

                nMensu = Round(Pmt(nTasaAplicable, nPlazo, -nSaldoEquipo, 0), 2)

            ElseIf cTipar = "P" Then

                ' Arrendamiento Puro

                nMensu = Round(Pmt(nTasaAplicable, nPlazo, -nSaldoEquipo, nResidual), 2)

            End If

            If cTipar = "R" Then
                For Each drDatos In dsAgil.Tables("Derechos").Rows
                    If nMontofin >= drDatos("Limite1") Then
                        nIvaAmorin = drDatos("Cobro")
                        If nMontofin >= drDatos("Limite2") Then
                            nIvaAmorin = drDatos("Cobro")
                        End If
                    End If
                Next
            Else
                If cbPorieq.SelectedIndex = 1 Then
                    nIvaAmorin = Round(nAmorin * nPorieq, 2)
                Else
                    nIvaAmorin = 0
                End If
            End If

            If cTipar = "R" Or cTipar = "S" Then
                nComis = Round(nMontofin * nPorCo * (1 + nPorcentajeIVA), 2)
            Else
                nComis = Round(nSaldoEquipo * nPorCo * (1 + nPorcentajeIVA), 2)
            End If

            nGastos = CDbl(txtGastos.Text)
            txtGastos.Text = Format(nGastos, "##,##0.00")
            txtPIGastos.Text = Format(nGastos, "##,##0.00")

            ' Aquí calculo la tabla de amortización a fin de determinar el importe de las rentas en depósito
            ' de Arrendamiento Financiero o Arrendamiento Puro ya que si el cliente elige pagos decrecientes
            ' la renta no es igual para todos los periodos

            nRentaDep = 0
            nIvaDep = 0

            cForca = Trim(Str(cbEsquemas.SelectedIndex + 1))

            If rbRDTrue.Checked = True Then

                ' Toma la renta del equipo

                If cForca = "1" Then
                    nRentaEquipo = Round(nMensu, 2)
                ElseIf cForca = "2" Then
                    If cTipar = "F" Then
                        nAbCap = Round((nSaldoEquipo) / nPlazo, 2)
                    ElseIf cTipar = "P" Then
                        nAbCap = Round((nSaldoEquipo - nResidual) / nPlazo, 2)
                    End If
                End If

                nSuma = nPlazo - Val(cbRtas.SelectedItem)

                For nLetra = 1 To nPlazo

                    nInteresEquipo = Round(nSaldoEquipo * nTasaAplicable, 2)

                    If cForca = "1" Then
                        nCapitalEquipo = nRentaEquipo - nInteresEquipo
                    ElseIf cForca = "2" Then
                        nCapitalEquipo = nAbCap
                    End If

                    If cTipar = "F" And nLetra = nPlazo Then
                        nCapitalEquipo = nSaldoEquipo
                        nInteresEquipo = Round(nSaldoEquipo * nTasaAplicable, 2)
                    End If

                    nIvaIntEq = Round(nInteresEquipo * nPorcentajeIVA, 2)

                    ' Sumo las rentas en depósito que se integran a los Pagos Iniciales

                    If nLetra > nSuma Then

                        nRentaDep += nCapitalEquipo + nInteresEquipo

                        If cTipar = "F" Then

                            ' Tomamos el IVA de los intereses para considerarlo IVA de la Renta en Depósito

                            nIvaDep += nIvaIntEq

                            ' Si la operación tiene IVA MOI, debemos aumentar el IVA del Capital,
                            ' no importando si deja Depósito en Garantía

                            If nIvaEq > 0 Then
                                nIvaDep += Round(nCapitalEquipo * nPorcentajeIVA, 2)
                            End If

                        ElseIf cTipar = "P" Then

                            nIvaDep += Round((nCapitalEquipo + nInteresEquipo) * nPorcentajeIVA, 2)

                        End If

                    End If

                    nSaldoEquipo -= nCapitalEquipo

                Next

            End If

            If rbDNTrue.Checked = True And cFondeo = "02" Then
                nNafin = Round(nSaldoEquipo * 5 / 100, 2)
            Else
                nNafin = 0
            End If

            txtTermina.Text = TerminaANT(dtpFvenc.Value, Val(cbPlazo.SelectedItem))
            txtImpEq.Text = Format(nImpEq, "##,##0.00")
            txtIvaeq.Text = Format(nIvaEq, "##,##0.00")
            txtPorop.Text = Format(nPorOp, "##,##0.00")
            If cForca = "1" Then
                txtMensu.Text = Format(nMensu, "##,##0.00")
            ElseIf cForca = "2" Then
                txtMensu.Text = "DECRECIENTE"
            End If
            txtMontoFinanciado.Text = Format(nMontofin, "##,##0.00")

            txtIvaAmorin.Text = Format(nIvaAmorin, "##,##0.00")
            txtComis.Text = Format(nComis, "##,##0.00")
            txtImpRD.Text = Format(nImpRD, "##,##0.00")
            txtIvaRD.Text = Format(nIvaRD, "##,##0.00")
            txtNafin.Text = Format(nNafin, "##,##0.00")
            txtRtasDep.Text = Format(nRentaDep, "##,##0.00")
            txtIvaRtasDep.Text = Format(nIvaDep, "##,##0.00")

            txtPagosIniciales.Text = Format(Round(nAmorin + nIvaAmorin + nComis + nImpRD + nIvaRD + nGastos + nNafin + nRentaDep + nIvaDep + nFReserva, 2), "##,##0.00")

            btnGuardar.Enabled = True

            For Each eControl In Me.Controls
                If eControl.Name <> "btnGuardar" And eControl.Name <> "btnSalir" And eControl.Enabled = True Then
                    eControl.Enabled = False
                End If
            Next

            MsgBox("No olvides salvar los cambios", MsgBoxStyle.Exclamation, "Mensaje")

        End If

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
        cm4.Dispose()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daSolicitudes As New SqlDataAdapter(cm1)
        Dim strUpdate As String
        Dim drEmp As DataRow

        ' Declaración de variables de datos

        Dim cDisposicion As String
        Dim cFechacon As String
        Dim cFondeo As String
        Dim cForca As String
        Dim cFvenc As String
        Dim cPrenda As String
        Dim cSolicitud As String
        Dim cTippe As String
        Dim cTipta As String
        Dim cDomi As String
        Dim cPEmp As String
        Dim cCNom As String = "NO"
        Dim cTFrec As String = "MESES"
        Dim nDerechos As Decimal
        Dim nIvaAmorin As Decimal
        Dim nVFrec As Integer = 0
        Dim nPagos As Integer = 0
        Dim nDG As Integer = 0

        cSolicitud = lblSolicitud.Text
        cDisposicion = lblDisposicion.Text

        btnGuardar.Enabled = False

        cFechacon = DTOC(dtpFechacon.Value)
        cFvenc = DTOC(dtpFvenc.Value)

        cTippe = Stuff(Trim(Str(cbCriterios.SelectedIndex + 1)), "I", "0", 2)
        cFondeo = Stuff(Trim(Str(cbRecursos.SelectedIndex + 1)), "I", "0", 2)
        cForca = Trim(Str(cbEsquemas.SelectedIndex + 1))
        cTipta = Trim(Str(cbTasas.SelectedValue))

        nIvaAmorin = 0
        nDerechos = 0
        If CmbAuto.SelectedIndex = 0 Then
            cAutomovil = "N"
        Else
            cAutomovil = "S"
        End If

        If cTipar = "F" Or cTipar = "S" Then
            nIvaAmorin = CDbl(txtIvaAmorin.Text)
        ElseIf cTipar = "P" Then
            nIvaAmorin = CDbl(txtIvaAmorin.Text)
        ElseIf cTipar = "R" Then
            nDerechos = CDbl(txtIvaAmorin.Text)
        End If

        cPrenda = "N"
        If rbGPTrue.Checked = True Then
            cPrenda = "S"
        End If

        If rbCNomSi.Checked = True Then
            cCNom = "CN"
            nPagos = CDbl(txtAmortizaciones.Text)
        ElseIf rbCAutoSi.Checked = True Then
            cCNom = "CA"
            nPagos = CDbl(txtAmortizaciones.Text)
        End If
        If rbDias.Checked = True Then
            cTFrec = "DIAS"
            nVFrec = cbDias.SelectedItem
        Else
            nVFrec = cbMeses.SelectedItem
        End If

        If rbDomiSi.Checked = True Then
            cDomi = "S"
        Else
            cDomi = "N"
        End If

        If rbPEmpSi.Checked = True Then
            cPEmp = "S"
        Else
            cPEmp = "N"
        End If
        If cTipta = "7" Then
            txtDifer.Text = "0.0"
        End If

        If rbDGTrue.Checked = True Then
            Select Case CDec(TxtDepGporc.Text) / 100
                Case >= 0.15
                    nDG = 3
                Case >= 0.1
                    nDG = 2
                Case >= 0.5
                    nDG = 1
            End Select
        End If

        txtEmpresa.Text = cbEmpresa.Text

        strUpdate = "UPDATE Detsol SET ImpEq = " & CDbl(txtImpEq.Text) & ","
        strUpdate = strUpdate & " Tipar = " & "'" & cTipar & "',"
        strUpdate = strUpdate & " Plazo = " & Val(cbPlazo.SelectedItem) & ","
        strUpdate = strUpdate & " IvaEq = " & CDbl(txtIvaeq.Text) & ","
        strUpdate = strUpdate & " Porieq = " & Val(cbPorieq.SelectedItem) & ","
        strUpdate = strUpdate & " Amorin = " & CDbl(txtAmorin.Text) & ","
        strUpdate = strUpdate & " IvaAmorin = " & nIvaAmorin & ","
        strUpdate = strUpdate & " Tippe = " & "'" & cTippe & "',"
        strUpdate = strUpdate & " Tipta = " & "'" & cTipta & "',"
        strUpdate = strUpdate & " Tasas = " & Val(txtTasas.Text) & ","
        strUpdate = strUpdate & " Difer = " & Val(txtDifer.Text) & ","
        strUpdate = strUpdate & " Forca = " & "'" & cForca & "',"
        strUpdate = strUpdate & " ImpRD = " & CDbl(txtImpRD.Text) & ","
        strUpdate = strUpdate & " IvaRD = " & CDbl(txtIvaRD.Text) & ","
        strUpdate = strUpdate & " Porco = " & Val(txtPorco.Text) & ","
        strUpdate = strUpdate & " Comis = " & CDbl(txtComis.Text) & ","
        strUpdate = strUpdate & " Porop = " & Val(txtPorop.Text) & ","
        strUpdate = strUpdate & " Fechacon = " & "'" & cFechacon & "',"
        strUpdate = strUpdate & " Fvenc = " & "'" & cFvenc & "',"
        strUpdate = strUpdate & " Fondeo = " & "'" & cFondeo & "',"
        strUpdate = strUpdate & " DepNafin = " & CDbl(txtNafin.Text) & ","
        strUpdate = strUpdate & " Critas = " & "'" & "01" & "',"
        strUpdate = strUpdate & " Gastos = " & Round(CDbl(txtGastos.Text) / (1 + nPorcentajeIVA), 2) & ","
        strUpdate = strUpdate & " IvaGastos = " & Round(CDbl(txtGastos.Text) / (1 + nPorcentajeIVA) * nPorcentajeIVA, 2) & ","
        strUpdate = strUpdate & " Prenda = " & "'" & cPrenda & "',"
        strUpdate = strUpdate & " RD = 0," ' & Val(cbRtas.SelectedIndex) & ","
        strUpdate = strUpdate & " ImpDG = " & CDbl(txtRtasDep.Text) & ","
        strUpdate = strUpdate & " IvaDG = " & CDbl(txtIvaRtasDep.Text) & ","
        strUpdate = strUpdate & " Derechos = " & nDerechos & ","
        strUpdate = strUpdate & " DG = " & Val(nDG) & ","
        strUpdate = strUpdate & " Validado = " & "'" & "S" & "',"
        strUpdate = strUpdate & " AceptaDomi = " & "'" & cDomi & "',"
        strUpdate = strUpdate & " PagaEmp = " & "'" & cPEmp & "',"
        strUpdate = strUpdate & " CNom = " & "'" & cCNom & "',"
        strUpdate = strUpdate & " TipoFrecuencia = " & "'" & cTFrec & "',"
        strUpdate = strUpdate & " ValorFrecuencia = " & nVFrec & ","
        strUpdate = strUpdate & " Amortizaciones = " & nPagos & ","
        strUpdate = strUpdate & " FondoReserva = " & CDbl(txtFondoReser.Text) & ","
        strUpdate = strUpdate & " CNEmpresa = " & "'" & txtEmpresa.Text & "',"
        strUpdate = strUpdate & " CNPlanta = " & "'" & txtPlanta.Text & "',"
        strUpdate = strUpdate & " Automovil = " & "'" & cAutomovil & "',"
        strUpdate = strUpdate & " TasaIvaCapital = " & "'" & cbTasaIVAcap.SelectedItem & "' "
        strUpdate = strUpdate & " WHERE Solicitud = " & "'" & cSolicitud & "'"
        strUpdate = strUpdate & " AND Disposicion = " & "'" & cDisposicion & "'"
        Try
            cm1 = New SqlCommand(strUpdate, cnAgil)
            cnAgil.Open()
            cm1.ExecuteNonQuery()
            cnAgil.Close()
        Catch eException As Exception
            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
        End Try

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub cbProducto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProducto.SelectedIndexChanged

        Label26.Visible = False
        cbTasaIVAcap.Visible = False

        Label25.Text = "Fondo de Reserva"
        CmbAuto.Visible = False
        txtFondoReser.Visible = True

        If cbProducto.SelectedIndex = 0 Then


            ' Arrendamiento Financiero

            cTipar = "F"

            cbPorieq.Enabled = True
            txtFondoReser.Enabled = False

            txtFondoReser.Text = Format(0, "##,##0.00")
            txtFondoReser.Enabled = True

            txtAmorin.Enabled = True
            rbDGTrue.Enabled = True
            rbDGFalse.Enabled = True

            Label26.Visible = True
            cbTasaIVAcap.Visible = True

            Label4.Text = "Opción de Compra"
            Label10.Text = "SubTotal del Equipo"
            lblAmortiza.Text = "Amortización Inicial"
            lblPIAmortiza.Text = "Amortización Inicial"
            lblIvaamortiza.Text = "I.V.A. de la Amortización"
            lblOpcom.Text = "Opción a compra con I.V.A."
            lblRtaeq.Text = "Renta del Equipo"
            lblRtasD.Text = "Depósito en Garantía"
            lblDepos.Text = "Depósito en Garantía"
            rbRDTrue.Enabled = True
            rbRDFalse.Enabled = True
            rbDNTrue.Enabled = True
            rbDNFalse.Enabled = True
            TxtDepG.Enabled = False
            cbRecursos.Enabled = True
            If cbRecursos.SelectedIndex >= 0 Then cbRecursos.SelectedIndex = 0

        ElseIf cbProducto.SelectedIndex = 1 Then

            ' Arrendamiento Puro

            cTipar = "P"

            cbPorieq.Enabled = True

            txtPorop.Text = Format(1, "F")
            txtPorop.ReadOnly = False

            txtAmorin.Text = Format(0, "##,##0.00")

            txtFondoReser.Text = Format(0, "##,##0.00")
            txtFondoReser.Enabled = False

            Label25.Text = "Arrendamiento de Auto"
            CmbAuto.Visible = True
            txtFondoReser.Visible = False

            txtAmorin.Enabled = False

            ' Selecciono la opción de que no se tiene Depósito en Garantía, inhabilito la opción de modificarlo
            ' e inicializo a cero el porcentaje del Depósito en Garantía y por último inhabilito el comboBox
            ' de los porcentajes de Depósito en Garantía

            rbDGFalse.Checked = True
            rbDGTrue.Enabled = False
            rbDGFalse.Enabled = False
            TxtDepG.Enabled = False

            Label4.Text = "Valor Residual"
            Label10.Text = "SubTotal del Equipo"
            lblAmortiza.Text = "Amortización inicial"
            lblIvaamortiza.Text = "I.V.A. de la Amortización"
            lblOpcom.Text = "Amortización Final"
            lblRtaeq.Text = "Pago Mensual sin IVA"
            lblRtasD.Text = "Depósito en Garantía"
            lblDepos.Text = "Depósito en Garantía"
            rbRDTrue.Enabled = True
            rbRDFalse.Enabled = True
            rbDNTrue.Enabled = False
            rbDNFalse.Enabled = False
            cbRecursos.Enabled = True
            If cbRecursos.SelectedIndex >= 0 Then cbRecursos.SelectedIndex = 0

        ElseIf cbProducto.SelectedIndex = 2 Then

            ' Crédito Refaccionario

            cTipar = "R"

            cbPorieq.SelectedIndex = 0
            cbPorieq.Enabled = False
            txtPorop.Text = Format(0, "F")
            txtPorop.ReadOnly = True
            txtAmorin.Enabled = True

            txtFondoReser.Text = Format(0, "##,##0.00")
            txtFondoReser.Enabled = True

            Label4.Text = "Opción de Compra"
            Label10.Text = "Total del Equipo"
            lblAmortiza.Text = "Enganche"
            lblPIAmortiza.Text = "Enganche"
            lblIvaamortiza.Text = "Derechos de Registro"
            lblOpcom.Text = "Opción a compra con I.V.A."
            lblRtaeq.Text = "Renta del Equipo"
            lblRtasD.Text = "Depósito FINAGIL"
            lblDepos.Text = "Depósito FINAGIL"

            ' Recordar que en Crédito Refaccionario NO existen Rentas en Depósito

            rbRDTrue.Checked = False
            rbRDFalse.Checked = True
            rbRDTrue.Enabled = False
            rbRDFalse.Enabled = False
            cbRtas.SelectedIndex = 0

            rbDGTrue.Enabled = True
            rbDGFalse.Enabled = True

            rbDNTrue.Enabled = False
            rbDNFalse.Enabled = False
            cbRecursos.Enabled = True
            If cbRecursos.SelectedIndex >= 0 Then cbRecursos.SelectedIndex = 0

        ElseIf cbProducto.SelectedIndex = 3 Then

            ' Crédito Simple

            cTipar = "S"

            cbPorieq.SelectedIndex = 0
            cbPorieq.Enabled = False
            txtPorop.Text = Format(0, "F")
            txtPorop.ReadOnly = True
            txtAmorin.Enabled = True

            txtFondoReser.Text = Format(0, "##,##0.00")
            txtFondoReser.Enabled = True

            Label4.Text = "Opción de Compra"
            Label10.Text = "Total del Equipo"
            lblAmortiza.Text = "Amortización inicial"
            lblIvaamortiza.Text = "I.V.A. de la Amortización"
            lblOpcom.Text = "Amortización Final"
            lblOpcom.Text = "Opción a compra con I.V.A."
            lblRtaeq.Text = "Renta del Equipo"
            lblRtasD.Text = "Depósito FINAGIL"
            lblDepos.Text = "Depósito FINAGIL"

            ' Recordar que en Crédito Refaccionario NO existen Rentas en Depósito

            rbRDTrue.Checked = False
            rbRDFalse.Checked = True
            rbRDTrue.Enabled = False
            rbRDFalse.Enabled = False
            cbRtas.SelectedIndex = 0

            rbDGTrue.Enabled = True
            rbDGFalse.Enabled = True

            rbDNTrue.Enabled = False
            rbDNFalse.Enabled = False

            cbRecursos.Enabled = True
            If cbRecursos.SelectedIndex >= 0 Then cbRecursos.SelectedIndex = 0

        ElseIf cbProducto.SelectedIndex = 4 Then

            ' Crédito Refaccionario

            cTipar = "T"

            cbPorieq.SelectedIndex = 0
            cbPorieq.Enabled = False
            txtPorop.Text = Format(0, "F")
            txtPorop.ReadOnly = True
            txtAmorin.Enabled = True

            txtFondoReser.Text = Format(0, "##,##0.00")
            txtFondoReser.Enabled = True

            Label4.Text = "Opción de Compra"
            Label10.Text = "Total del Equipo"
            lblAmortiza.Text = "Enganche"
            lblPIAmortiza.Text = "Enganche"
            lblIvaamortiza.Text = "Derechos de Registro"
            lblOpcom.Text = "Opción a compra con I.V.A."
            lblRtaeq.Text = "Renta del Equipo"
            lblRtasD.Text = "Depósito FINAGIL"
            lblDepos.Text = "Depósito FINAGIL"

            ' Recordar que en Crédito Refaccionario NO existen Rentas en Depósito

            rbRDTrue.Checked = False
            rbRDFalse.Checked = True
            rbRDTrue.Enabled = False
            rbRDFalse.Enabled = False
            cbRtas.SelectedIndex = 0

            rbDGTrue.Enabled = True
            rbDGFalse.Enabled = True

            rbDNTrue.Enabled = False
            rbDNFalse.Enabled = False

            cbRecursos.Enabled = False
            If cbRecursos.SelectedIndex >= 0 Then cbRecursos.SelectedIndex = 2

        End If

    End Sub

    Private Sub rbDGTrue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDGTrue.Click
        If cTipar = "R" Or cTipar = "S" Then
            ' Crédito Refaccionario
            'TxtDepG.Enabled = True
        Else
            ' Arrendamiento Financiero ó Arrendamiento Puro
            'TxtDepG.Enabled = False
        End If
    End Sub

    Private Sub rbDGFalse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDGFalse.Click
        If cTipar = "R" Or cTipar = "S" Then
            'TxtDepG.Enabled = False
        End If
    End Sub

    Private Sub rbRDTrue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbRDTrue.Click
        cbRtas.Enabled = True
    End Sub

    Private Sub rbRDFalse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbRDFalse.Click
        cbRtas.Enabled = False
        cbRtas.SelectedIndex = 0
    End Sub

    Private Sub cbRecursos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbRecursos.SelectedIndexChanged

        If cbRecursos.SelectedIndex = 0 Then

            ' Recursos Propios

            rbRDTrue.Enabled = True
            rbRDFalse.Enabled = True
            rbDGTrue.Enabled = True
            rbDGFalse.Enabled = True
            rbDNTrue.Enabled = False
            rbDNFalse.Enabled = False

        ElseIf cbRecursos.SelectedIndex = 1 Then

            ' Recursos NAFIN

            rbRDTrue.Enabled = False
            rbRDFalse.Enabled = False
            rbDGTrue.Enabled = True
            rbDGFalse.Enabled = True
            rbDNTrue.Enabled = True
            rbDNFalse.Enabled = True

        ElseIf cbRecursos.SelectedIndex = 2 Then

            ' Recursos FIRA

            rbRDTrue.Enabled = False
            rbRDFalse.Enabled = False
            rbDGTrue.Enabled = False
            rbDGFalse.Enabled = False
            rbDNTrue.Enabled = False
            rbDNFalse.Enabled = False

        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub rbCNomSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCNomSi.CheckedChanged
        gbNomina.Visible = True
        rbGPTrue.Checked = False
        rbGPTrue.Enabled = False
        rbGPFalse.Enabled = False
        rbCAutoSi.Checked = False
        rbCAutoSi.Enabled = False
        rbCAutoNo.Enabled = False
    End Sub

    Private Sub rbCNomNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCNomNo.CheckedChanged
        gbNomina.Visible = False
        rbGPTrue.Enabled = True
        rbGPFalse.Enabled = True
        rbCAutoSi.Enabled = True
        rbCAutoNo.Enabled = True
    End Sub

    Private Sub rbDomiSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDomiSi.CheckedChanged
        rbPEmpSi.Enabled = False
        rbPEmpNo.Enabled = False
    End Sub

    Private Sub rbDomiNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDomiNo.CheckedChanged
        If rbPEmpNo.Checked = True And rbDomiNo.Checked = True Then
            rbPEmpSi.Enabled = True
            rbPEmpNo.Enabled = True
        Else
            rbPEmpSi.Enabled = True
            rbPEmpNo.Enabled = True
            rbDomiSi.Enabled = False
            rbDomiNo.Enabled = False
        End If
    End Sub

    Private Sub rbPEmpSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPEmpSi.CheckedChanged
        rbCNomSi.Checked = False
        rbCNomSi.Enabled = False
        rbCNomNo.Enabled = False
        rbDomiSi.Enabled = False
        rbDomiNo.Enabled = False
    End Sub

    Private Sub rbPEmpNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPEmpNo.CheckedChanged
        If rbDomiNo.Checked = True And rbPEmpNo.Checked = True Then
            rbDomiSi.Enabled = True
            rbDomiNo.Enabled = True
        Else
            rbDomiSi.Enabled = True
            rbDomiNo.Enabled = True
            rbPEmpSi.Enabled = False
            rbPEmpNo.Enabled = False
        End If
    End Sub

    Private Sub rbCAutoNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCAutoNo.CheckedChanged
        gbNomina.Visible = False
        rbCNomSi.Enabled = True
        rbCNomNo.Enabled = True
    End Sub

    Private Sub rbCAutoSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCAutoSi.CheckedChanged
        gbNomina.Visible = True
        rbCNomSi.Enabled = False
        rbCNomNo.Enabled = False
    End Sub

    Private Sub TxtDepG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDepG.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, TxtDepG.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub rbDGTrue_CheckedChanged(sender As Object, e As EventArgs) Handles rbDGTrue.CheckedChanged
        If rbDGTrue.Checked = True Then
            TxtDepG.Enabled = True
        End If
    End Sub

    Private Sub rbDGFalse_CheckedChanged(sender As Object, e As EventArgs) Handles rbDGFalse.CheckedChanged
        If rbDGTrue.Checked = False Then
            TxtDepG.Enabled = False
        End If
    End Sub

End Class
