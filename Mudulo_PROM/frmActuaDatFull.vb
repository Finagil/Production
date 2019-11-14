Option Explicit On 

Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Math

Public Class frmActuaDatFull

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
    Friend WithEvents txtComis As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalpagos As System.Windows.Forms.Label
    Friend WithEvents lblNafin As System.Windows.Forms.Label
    Friend WithEvents lblRatific As System.Windows.Forms.Label
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
    Friend WithEvents lblPlazo As System.Windows.Forms.Label
    Friend WithEvents txtTermina As System.Windows.Forms.TextBox
    Friend WithEvents lblFechafin As System.Windows.Forms.Label
    Friend WithEvents txtImpEq As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblSolicitud As System.Windows.Forms.Label
    Friend WithEvents lblDisposicion As System.Windows.Forms.Label
    Friend WithEvents cbPorieq As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbPlazo As System.Windows.Forms.ComboBox
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
    Friend WithEvents cbTasaIVAcap As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
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
        Me.txtPIGastos = New System.Windows.Forms.TextBox()
        Me.txtPIAmorin = New System.Windows.Forms.TextBox()
        Me.lblPIRatific = New System.Windows.Forms.Label()
        Me.lblPIAmortiza = New System.Windows.Forms.Label()
        Me.txtIvaAmorin = New System.Windows.Forms.TextBox()
        Me.lblIvaamortiza = New System.Windows.Forms.Label()
        Me.txtPagosIniciales = New System.Windows.Forms.TextBox()
        Me.txtNafin = New System.Windows.Forms.TextBox()
        Me.txtComis = New System.Windows.Forms.TextBox()
        Me.lblTotalpagos = New System.Windows.Forms.Label()
        Me.lblNafin = New System.Windows.Forms.Label()
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
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.lblSolicitud = New System.Windows.Forms.Label()
        Me.lblDisposicion = New System.Windows.Forms.Label()
        Me.lblDescr = New System.Windows.Forms.Label()
        Me.cbPorieq = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbPlazo = New System.Windows.Forms.ComboBox()
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
        Me.cbTasaIVAcap = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.gpoPagos.SuspendLayout()
        Me.gpoPagosi.SuspendLayout()
        Me.gpoTasaAplicable.SuspendLayout()
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
        Me.Label2.Location = New System.Drawing.Point(209, 390)
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
        Me.Label4.Location = New System.Drawing.Point(16, 412)
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
        Me.Label3.Location = New System.Drawing.Point(16, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Comisión"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIva
        '
        Me.lblIva.Location = New System.Drawing.Point(16, 223)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(128, 16)
        Me.lblIva.TabIndex = 71
        Me.lblIva.Text = "Porcentaje de I.V.A."
        Me.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPorop
        '
        Me.txtPorop.Location = New System.Drawing.Point(144, 412)
        Me.txtPorop.Name = "txtPorop"
        Me.txtPorop.ReadOnly = True
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
        Me.txtPorco.Location = New System.Drawing.Point(144, 388)
        Me.txtPorco.Name = "txtPorco"
        Me.txtPorco.Size = New System.Drawing.Size(64, 20)
        Me.txtPorco.TabIndex = 82
        Me.txtPorco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 226)
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
        Me.lblCriteriotasa.Location = New System.Drawing.Point(16, 292)
        Me.lblCriteriotasa.Name = "lblCriteriotasa"
        Me.lblCriteriotasa.Size = New System.Drawing.Size(128, 16)
        Me.lblCriteriotasa.TabIndex = 76
        Me.lblCriteriotasa.Text = "Criterio de Tasa"
        Me.lblCriteriotasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipotasa
        '
        Me.lblTipotasa.Location = New System.Drawing.Point(16, 364)
        Me.lblTipotasa.Name = "lblTipotasa"
        Me.lblTipotasa.Size = New System.Drawing.Size(128, 16)
        Me.lblTipotasa.TabIndex = 102
        Me.lblTipotasa.Text = "Tipo de Tasa"
        Me.lblTipotasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFrecpag
        '
        Me.lblFrecpag.Location = New System.Drawing.Point(16, 316)
        Me.lblFrecpag.Name = "lblFrecpag"
        Me.lblFrecpag.Size = New System.Drawing.Size(128, 16)
        Me.lblFrecpag.TabIndex = 77
        Me.lblFrecpag.Text = "Frecuencia de pago"
        Me.lblFrecpag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEqmap
        '
        Me.lblEqmap.Location = New System.Drawing.Point(16, 340)
        Me.lblEqmap.Name = "lblEqmap"
        Me.lblEqmap.Size = New System.Drawing.Size(128, 16)
        Me.lblEqmap.TabIndex = 94
        Me.lblEqmap.Text = "Esquema de Pagos"
        Me.lblEqmap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gpoPagosi
        '
        Me.gpoPagosi.Controls.Add(Me.txtPIGastos)
        Me.gpoPagosi.Controls.Add(Me.txtPIAmorin)
        Me.gpoPagosi.Controls.Add(Me.lblPIRatific)
        Me.gpoPagosi.Controls.Add(Me.lblPIAmortiza)
        Me.gpoPagosi.Controls.Add(Me.txtIvaAmorin)
        Me.gpoPagosi.Controls.Add(Me.lblIvaamortiza)
        Me.gpoPagosi.Controls.Add(Me.txtPagosIniciales)
        Me.gpoPagosi.Controls.Add(Me.txtNafin)
        Me.gpoPagosi.Controls.Add(Me.txtComis)
        Me.gpoPagosi.Controls.Add(Me.lblTotalpagos)
        Me.gpoPagosi.Controls.Add(Me.lblNafin)
        Me.gpoPagosi.Controls.Add(Me.lblComis)
        Me.gpoPagosi.Location = New System.Drawing.Point(385, 285)
        Me.gpoPagosi.Name = "gpoPagosi"
        Me.gpoPagosi.Size = New System.Drawing.Size(264, 171)
        Me.gpoPagosi.TabIndex = 105
        Me.gpoPagosi.TabStop = False
        Me.gpoPagosi.Text = "Pagos Iniciales"
        '
        'txtPIGastos
        '
        Me.txtPIGastos.Location = New System.Drawing.Point(168, 94)
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
        Me.lblPIRatific.Location = New System.Drawing.Point(8, 94)
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
        Me.txtPagosIniciales.Location = New System.Drawing.Point(168, 143)
        Me.txtPagosIniciales.Name = "txtPagosIniciales"
        Me.txtPagosIniciales.ReadOnly = True
        Me.txtPagosIniciales.Size = New System.Drawing.Size(88, 20)
        Me.txtPagosIniciales.TabIndex = 64
        Me.txtPagosIniciales.TabStop = False
        Me.txtPagosIniciales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNafin
        '
        Me.txtNafin.Location = New System.Drawing.Point(168, 118)
        Me.txtNafin.Name = "txtNafin"
        Me.txtNafin.ReadOnly = True
        Me.txtNafin.Size = New System.Drawing.Size(88, 20)
        Me.txtNafin.TabIndex = 62
        Me.txtNafin.TabStop = False
        Me.txtNafin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.lblTotalpagos.Location = New System.Drawing.Point(8, 143)
        Me.lblTotalpagos.Name = "lblTotalpagos"
        Me.lblTotalpagos.Size = New System.Drawing.Size(155, 16)
        Me.lblTotalpagos.TabIndex = 52
        Me.lblTotalpagos.Text = "Total de Pagos Iniciales"
        Me.lblTotalpagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNafin
        '
        Me.lblNafin.Location = New System.Drawing.Point(8, 118)
        Me.lblNafin.Name = "lblNafin"
        Me.lblNafin.Size = New System.Drawing.Size(155, 16)
        Me.lblNafin.TabIndex = 51
        Me.lblNafin.Text = "5 % NAFIN"
        Me.lblNafin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.txtGastos.Location = New System.Drawing.Point(144, 200)
        Me.txtGastos.Name = "txtGastos"
        Me.txtGastos.Size = New System.Drawing.Size(88, 20)
        Me.txtGastos.TabIndex = 60
        Me.txtGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRatific
        '
        Me.lblRatific.Location = New System.Drawing.Point(16, 200)
        Me.lblRatific.Name = "lblRatific"
        Me.lblRatific.Size = New System.Drawing.Size(128, 16)
        Me.lblRatific.TabIndex = 50
        Me.lblRatific.Text = "Ratificación con I.V.A."
        Me.lblRatific.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(664, 91)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(128, 23)
        Me.btnGuardar.TabIndex = 110
        Me.btnGuardar.Text = "Guardar Cambios"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(664, 123)
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
        Me.cbTasas.Location = New System.Drawing.Point(144, 364)
        Me.cbTasas.Name = "cbTasas"
        Me.cbTasas.Size = New System.Drawing.Size(224, 21)
        Me.cbTasas.TabIndex = 119
        '
        'cbCriterios
        '
        Me.cbCriterios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCriterios.Location = New System.Drawing.Point(144, 292)
        Me.cbCriterios.Name = "cbCriterios"
        Me.cbCriterios.Size = New System.Drawing.Size(224, 21)
        Me.cbCriterios.TabIndex = 120
        '
        'cbFrecuencias
        '
        Me.cbFrecuencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFrecuencias.Location = New System.Drawing.Point(144, 316)
        Me.cbFrecuencias.Name = "cbFrecuencias"
        Me.cbFrecuencias.Size = New System.Drawing.Size(224, 21)
        Me.cbFrecuencias.TabIndex = 121
        '
        'cbEsquemas
        '
        Me.cbEsquemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEsquemas.Location = New System.Drawing.Point(144, 340)
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
        'lblPlazo
        '
        Me.lblPlazo.Location = New System.Drawing.Point(16, 268)
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
        'cbPorieq
        '
        Me.cbPorieq.FormattingEnabled = True
        Me.cbPorieq.Location = New System.Drawing.Point(144, 223)
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
        'cbPlazo
        '
        Me.cbPlazo.FormattingEnabled = True
        Me.cbPlazo.Location = New System.Drawing.Point(144, 268)
        Me.cbPlazo.Name = "cbPlazo"
        Me.cbPlazo.Size = New System.Drawing.Size(47, 21)
        Me.cbPlazo.TabIndex = 153
        '
        'gpoTasaAplicable
        '
        Me.gpoTasaAplicable.Controls.Add(Me.Label6)
        Me.gpoTasaAplicable.Controls.Add(Me.Label5)
        Me.gpoTasaAplicable.Controls.Add(Me.txtTasas)
        Me.gpoTasaAplicable.Controls.Add(Me.lblTasaInteres)
        Me.gpoTasaAplicable.Controls.Add(Me.lblDifer)
        Me.gpoTasaAplicable.Controls.Add(Me.txtDifer)
        Me.gpoTasaAplicable.Location = New System.Drawing.Point(385, 210)
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
        Me.txtTasas.ReadOnly = True
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
        Me.txtDifer.ReadOnly = True
        Me.txtDifer.Size = New System.Drawing.Size(64, 20)
        Me.txtDifer.TabIndex = 144
        Me.txtDifer.TabStop = False
        Me.txtDifer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(209, 414)
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
        Me.cbRecursos.Enabled = False
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
        Me.cbProducto.Enabled = False
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
        'cbTasaIVAcap
        '
        Me.cbTasaIVAcap.FormattingEnabled = True
        Me.cbTasaIVAcap.Items.AddRange(New Object() {"0%", "8%", "16%", "EXE"})
        Me.cbTasaIVAcap.Location = New System.Drawing.Point(144, 245)
        Me.cbTasaIVAcap.Name = "cbTasaIVAcap"
        Me.cbTasaIVAcap.Size = New System.Drawing.Size(47, 21)
        Me.cbTasaIVAcap.TabIndex = 170
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(16, 246)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(128, 16)
        Me.Label26.TabIndex = 169
        Me.Label26.Text = "Tasa I.V.A. Capital"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmActuaDatFull
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(805, 465)
        Me.Controls.Add(Me.cbTasaIVAcap)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.cbProducto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbRecursos)
        Me.Controls.Add(Me.lblRecursos)
        Me.Controls.Add(Me.lblAmortiza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAmorin)
        Me.Controls.Add(Me.gpoTasaAplicable)
        Me.Controls.Add(Me.cbPlazo)
        Me.Controls.Add(Me.txtGastos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbPorieq)
        Me.Controls.Add(Me.lblDescr)
        Me.Controls.Add(Me.lblRatific)
        Me.Controls.Add(Me.lblDisposicion)
        Me.Controls.Add(Me.lblSolicitud)
        Me.Controls.Add(Me.lblPlazo)
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
        Me.Name = "frmActuaDatFull"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del Financiamiento  FULL SERVICE"
        Me.gpoPagos.ResumeLayout(False)
        Me.gpoPagos.PerformLayout()
        Me.gpoPagosi.ResumeLayout(False)
        Me.gpoPagosi.PerformLayout()
        Me.gpoTasaAplicable.ResumeLayout(False)
        Me.gpoTasaAplicable.PerformLayout()
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
        Dim cDomi As String = "N"
        Dim cPEmp As String
        Dim cTasaIvaCap As String
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

        cbProducto.Items.Add("FULL SERVICE")
        cbProducto.SelectedIndex = 0

        ' Traer el nombre del cliente
        lblDescr.Text = drDisposicion("Descr")

        ' El IVA unicamente podra tener el valor de 0 ó 16 %

        cbPorieq.Items.Add("8")
        cbPorieq.Items.Add("16")
        cbPorieq.SelectedIndex = 0
        cbTasaIVAcap.SelectedIndex = 2

        ' Establecer los valores que puede asumir la variable Plazo

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
        cbTasas.SelectedIndex = 1 ' Tasa Fija

        ' Llenar las variables de datos con la información que viene de la tabla DetSol

        cTipar = "B"
        cFondeo = drDisposicion("Fondeo")
        cFechacon = drDisposicion("Fechacon")
        nPorieq = drDisposicion("Porieq")
        cTasaIvaCap = drDisposicion("TasaIvaCapital")
        nSaldoEquipo = drDisposicion("ImpEq") - drDisposicion("IvaEq") - drDisposicion("Amorin")
        nTasaAplicable = (drDisposicion("Tasas") + drDisposicion("Difer")) / 1200
        nPlazo = drDisposicion("Plazo")
        nAmorin = drDisposicion("Amorin")
        nIvaAmorin = drDisposicion("IvaAmorin")
        nComis = drDisposicion("Comis")
        nImpEq = drDisposicion("ImpEq")
        nPorOp = drDisposicion("PorOp")
        nDG = 0
        nImpRD = 0
        nIvaRD = 0
        nRtasD = 0
        cPrenda = 0
        nGastos = drDisposicion("Gastos") + drDisposicion("IvaGastos")
        nRD = 0
        nRtasDep = 0
        nSubTotal = drDisposicion("ImpEq") - drDisposicion("IvaEq")
        cDomi = drDisposicion("AceptaDomi")
        cPEmp = drDisposicion("PagaEmp")
        nVFrec = drDisposicion("ValorFrecuencia")
        nFReserva = drDisposicion("FondoReserva")


        'Label26.Visible = False
        'cbTasaIVAcap.Visible = False

        ' Ligar la tabla Empresas del dataset dsAgil al ComboBox de Empresas


        If cTipar = "B" Then
            cbProducto.SelectedIndex = 0
        End If

        cDeposito = "N"
        nImpRD = 0
        nIvaRD = 0


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
            Case 36
                cbPlazo.SelectedIndex = 0
            Case 48
                cbPlazo.SelectedIndex = 1
            Case 60
                cbPlazo.SelectedIndex = 2
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

        If nPorieq = 8 Then
            cbPorieq.SelectedIndex = 0
        Else
            cbPorieq.SelectedIndex = 1
        End If
        If cTasaIvaCap = "8%" Then
            cbTasaIVAcap.SelectedIndex = 1
        ElseIf cTasaIvaCap = "16%" Then
            cbTasaIVAcap.SelectedIndex = 2
        Else
            cbTasaIVAcap.SelectedIndex = 3
        End If
        txtMensu.Text = Format(nMensu, "##,##0.00")
        txtMontoFinanciado.Text = Format(drDisposicion("ImpEq") - drDisposicion("IvaEq") - drDisposicion("Amorin"), "##,##0.00")

        ' Las cajas de texto pueden tener el formato ##,##0.00 ya que en esta parte solamente se utilizan
        ' para mostrarse; sin embargo, tengo que quitar este formato en el recálculo de los datos ya que
        ' este formato trunca el valor de la variable que tenga asignada

        txtAmorin.Text = Format(drDisposicion("Amorin"), "##,##0.00")
        txtGastos.Text = Format(nGastos, "##,##0.00")
        txtSubtotEq.Text = Format(nSubTotal, "##,##0.00")

        ' Despliego los pagos iniciales

        txtPIAmorin.Text = Format(nAmorin, "##,##0.00")
        txtIvaAmorin.Text = Format(nIvaAmorin, "##,##0.00")
        txtComis.Text = Format(nComis, "##,##0.00")
        txtPIGastos.Text = Format(nGastos, "##,##0.00")
        txtNafin.Text = Format(nNafin, "##,##0.00")
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
        Dim nDG As Integer
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
        nRD = 0
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
            If cTipta <> "7" Then
                lCorrecto = False
                MsgBox("Un contrato descontado con FIRA debe tener TASA FIJA", MsgBoxStyle.Critical, "Error de Validación")
            End If
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

        If (Val(cbPlazo.SelectedItem) < 24 Or Val(cbPlazo.SelectedItem) > 36) And cFondeo >= "03" Then
            lCorrecto = False
            MsgBox("Un contrato descontado con FIRA solo tiene plazos de 24 a 36 meses", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If cFondeo = "02" Then
            lCorrecto = False
            MsgBox("Ya NO Operan Recursos NAFIN ", MsgBoxStyle.Critical, "Error de Validación")
        End If

        If Val(txtPorop.Text) < 0 Then
            lCorrecto = False
            MsgBox("El porcentaje de Opción de Compra no puede ser negativo", MsgBoxStyle.Critical, "Error de Validación")
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
            nFReserva = 0
            nIvaEq = 0
            nPorieq = 0
            If cbPorieq.SelectedIndex = 0 Then
                nPorieq = 8 / 100
                nIvaEq = Round(nImpEq * nPorieq, 2)
            Else
                nPorieq = 16 / 100
                nIvaEq = Round(nImpEq * nPorieq, 2)
            End If
            nImpEq = CDbl(txtSubtotEq.Text) + nIvaEq

            nAmorin = CDbl(txtAmorin.Text)
            txtAmorin.Text = Format(nAmorin, "##,##0.00")
            txtPIAmorin.Text = Format(nAmorin, "##,##0.00")

            nSaldoEquipo = Round(nImpEq - nIvaEq - nAmorin, 2)
            nPlazo = Val(cbPlazo.SelectedItem)

            ' En esta parte se determina la tasa a partir de los datos del financiamiento o del crédito
            ' y en el caso de Arrendamiento Puro se determina el porcentaje de valor residual

            lRD = False
            lDG = False

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

            ' Esta función determina la tasa aplicable a un contrato (si es tasa fija),
            ' el diferencial (si es un contrato con tasa variable) y 
            ' el porcentaje de valor residual (si se trata de un arrendamiento puro)

            TasaAplicable(cTipar, cTipta, nPlazo, nIvaEq, lRD, nRD, lDG, nDG, dsAgil, nTasas, nDifer, nPorOp)
            nTasas = 15
            nDifer = 0
            nPorOp = 20

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

            nPorOp = 1
            nOpcion = Round(nImpEq * nPorOp / 100, 2)
            txtOpcion.Text = Format(nOpcion, "##,##0.00")
            txtPorop.Text = Format(nPorOp, "F")
            nMensu = Round(Pmt(nTasaAplicable, nPlazo, -nSaldoEquipo, 0), 2)
            nMontofin = nImpEq - nIvaEq - nAmorin
            nIvaAmorin = 0
            nComis = Round(nMontofin * nPorCo * (1 + nPorcentajeIVA), 2)

            nGastos = CDbl(txtGastos.Text)
            txtGastos.Text = Format(nGastos, "##,##0.00")
            txtPIGastos.Text = Format(nGastos, "##,##0.00")

            ' Aquí calculo la tabla de amortización a fin de determinar el importe de las rentas en depósito
            ' de Arrendamiento Financiero o Arrendamiento Puro ya que si el cliente elige pagos decrecientes
            ' la renta no es igual para todos los periodos

            nRentaDep = 0
            nIvaDep = 0

            cForca = Trim(Str(cbEsquemas.SelectedIndex + 1))

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
            txtNafin.Text = Format(nNafin, "##,##0.00")
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

        cSolicitud = lblSolicitud.Text
        cDisposicion = lblDisposicion.Text

        btnGuardar.Enabled = False

        cFechacon = DTOC(dtpFechacon.Value)
        cFvenc = DTOC(dtpFvenc.Value)

        cTippe = Stuff(Trim(Str(cbCriterios.SelectedIndex + 1)), "I", "0", 2)
        cFondeo = Stuff(Trim(Str(cbRecursos.SelectedIndex + 1)), "I", "0", 2)
        cForca = Trim(Str(cbEsquemas.SelectedIndex + 1))
        cTipta = Trim(Str(cbTasas.SelectedIndex + 1))

        nIvaAmorin = 0
        nDerechos = 0
        cAutomovil = "N"
        nIvaAmorin = CDbl(txtIvaAmorin.Text)
        cPrenda = "N"
        cCNom = ""
        cPEmp = "N"

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
        strUpdate = strUpdate & " ImpRD = " & 0 & ","
        strUpdate = strUpdate & " IvaRD = " & 0 & ","
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
        strUpdate = strUpdate & " RD = " & 0 & ","
        strUpdate = strUpdate & " ImpDG = " & 0 & ","
        strUpdate = strUpdate & " IvaDG = " & 0 & ","
        strUpdate = strUpdate & " Derechos = " & nDerechos & ","
        strUpdate = strUpdate & " DG = " & 0 & ","
        strUpdate = strUpdate & " Validado = " & "'" & "S" & "',"
        strUpdate = strUpdate & " AceptaDomi = " & "'" & cDomi & "',"
        strUpdate = strUpdate & " PagaEmp = " & "'" & cPEmp & "',"
        strUpdate = strUpdate & " CNom = " & "'" & cCNom & "',"
        strUpdate = strUpdate & " TipoFrecuencia = " & "'" & cTFrec & "',"
        strUpdate = strUpdate & " ValorFrecuencia = " & nVFrec & ","
        strUpdate = strUpdate & " Amortizaciones = " & nPagos & ","
        strUpdate = strUpdate & " FondoReserva = " & 0 & ","
        strUpdate = strUpdate & " CNEmpresa = " & "'',"
        strUpdate = strUpdate & " CNPlanta = " & "'',"
        strUpdate = strUpdate & " Automovil = " & "'" & cAutomovil & "',"
        strUpdate = strUpdate & " TasaIvaCapital = " & "'" & cbTasaIVAcap.Text & "' "
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub


    'Private Sub cbRecursos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbRecursos.SelectedIndexChanged

    '    If cbRecursos.SelectedIndex = 0 Then

    '        ' Recursos Propios

    '        rbRDTrue.Enabled = True
    '        rbRDFalse.Enabled = True
    '        rbDGTrue.Enabled = True
    '        rbDGFalse.Enabled = True
    '        rbDNTrue.Enabled = False
    '        rbDNFalse.Enabled = False

    '    ElseIf cbRecursos.SelectedIndex = 1 Then

    '        ' Recursos NAFIN

    '        rbRDTrue.Enabled = False
    '        rbRDFalse.Enabled = False
    '        rbDGTrue.Enabled = True
    '        rbDGFalse.Enabled = True
    '        rbDNTrue.Enabled = True
    '        rbDNFalse.Enabled = True

    '    ElseIf cbRecursos.SelectedIndex = 2 Then

    '        ' Recursos FIRA

    '        rbRDTrue.Enabled = False
    '        rbRDFalse.Enabled = False
    '        rbDGTrue.Enabled = False
    '        rbDGFalse.Enabled = False
    '        rbDNTrue.Enabled = False
    '        rbDNFalse.Enabled = False

    '    End If

    'End Sub

    'Private Sub cbProducto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProducto.SelectedIndexChanged

    '    Label26.Visible = False
    '    cbTasaIVAcap.Visible = False

    '    If cbProducto.SelectedIndex = 0 Then


    '        ' Arrendamiento Financiero

    '        cTipar = "F"

    '        cbPorieq.Enabled = True
    '        Label26.Visible = True
    '        cbTasaIVAcap.Visible = True

    '        Label4.Text = "Opción de Compra"
    '        Label10.Text = "SubTotal del Equipo"
    '        lblAmortiza.Text = "Amortización Inicial"
    '        lblPIAmortiza.Text = "Amortización Inicial"
    '        lblIvaamortiza.Text = "I.V.A. de la Amortización"
    '        lblOpcom.Text = "Opción a compra con I.V.A."
    '        lblRtaeq.Text = "Renta del Equipo"
    '        cbRecursos.Enabled = True
    '        If cbRecursos.SelectedIndex >= 0 Then cbRecursos.SelectedIndex = 0

    '    ElseIf cbProducto.SelectedIndex = 1 Then

    '        ' Arrendamiento Puro

    '        cTipar = "P"

    '        cbPorieq.Enabled = True

    '        txtPorop.Text = Format(1, "F")
    '        txtPorop.ReadOnly = True

    '        txtAmorin.Text = Format(0, "##,##0.00")

    '        txtFondoReser.Text = Format(0, "##,##0.00")
    '        txtFondoReser.Enabled = False

    '        Label25.Text = "Arrendamiento de Auto"
    '        CmbAuto.Visible = True
    '        txtFondoReser.Visible = False

    '        txtAmorin.Enabled = False

    '        ' Selecciono la opción de que no se tiene Depósito en Garantía, inhabilito la opción de modificarlo
    '        ' e inicializo a cero el porcentaje del Depósito en Garantía y por último inhabilito el comboBox
    '        ' de los porcentajes de Depósito en Garantía

    '        rbDGFalse.Checked = True
    '        rbDGTrue.Enabled = False
    '        rbDGFalse.Enabled = False
    '        cbDepG.SelectedIndex = 0
    '        cbDepG.Enabled = False

    '        Label4.Text = "Valor Residual"
    '        Label10.Text = "SubTotal del Equipo"
    '        lblAmortiza.Text = "Amortización inicial"
    '        lblIvaamortiza.Text = "I.V.A. de la Amortización"
    '        lblOpcom.Text = "Amortización Final"
    '        lblRtaeq.Text = "Pago Mensual sin IVA"
    '        lblRtasD.Text = "Depósito en Garantía"
    '        lblDepos.Text = "Depósito en Garantía"
    '        rbRDTrue.Enabled = True
    '        rbRDFalse.Enabled = True
    '        rbDNTrue.Enabled = False
    '        rbDNFalse.Enabled = False
    '        cbRecursos.Enabled = True
    '        If cbRecursos.SelectedIndex >= 0 Then cbRecursos.SelectedIndex = 0

    '    ElseIf cbProducto.SelectedIndex = 2 Then

    '        ' Crédito Refaccionario

    '        cTipar = "R"

    '        cbPorieq.SelectedIndex = 0
    '        cbPorieq.Enabled = False
    '        txtPorop.Text = Format(0, "F")
    '        txtPorop.ReadOnly = True
    '        txtAmorin.Enabled = True

    '        txtFondoReser.Text = Format(0, "##,##0.00")
    '        txtFondoReser.Enabled = True

    '        Label4.Text = "Opción de Compra"
    '        Label10.Text = "Total del Equipo"
    '        lblAmortiza.Text = "Enganche"
    '        lblPIAmortiza.Text = "Enganche"
    '        lblIvaamortiza.Text = "Derechos de Registro"
    '        lblOpcom.Text = "Opción a compra con I.V.A."
    '        lblRtaeq.Text = "Renta del Equipo"
    '        lblRtasD.Text = "Depósito FINAGIL"
    '        lblDepos.Text = "Depósito FINAGIL"

    '        ' Recordar que en Crédito Refaccionario NO existen Rentas en Depósito

    '        rbRDTrue.Checked = False
    '        rbRDFalse.Checked = True
    '        rbRDTrue.Enabled = False
    '        rbRDFalse.Enabled = False
    '        cbRtas.SelectedIndex = 0

    '        rbDGTrue.Enabled = True
    '        rbDGFalse.Enabled = True

    '        rbDNTrue.Enabled = False
    '        rbDNFalse.Enabled = False
    '        cbRecursos.Enabled = True
    '        If cbRecursos.SelectedIndex >= 0 Then cbRecursos.SelectedIndex = 0

    '    ElseIf cbProducto.SelectedIndex = 3 Then

    '        ' Crédito Simple

    '        cTipar = "S"

    '        cbPorieq.SelectedIndex = 0
    '        cbPorieq.Enabled = False
    '        txtPorop.Text = Format(0, "F")
    '        txtPorop.ReadOnly = True
    '        txtAmorin.Enabled = True

    '        txtFondoReser.Text = Format(0, "##,##0.00")
    '        txtFondoReser.Enabled = True

    '        Label4.Text = "Opción de Compra"
    '        Label10.Text = "Total del Equipo"
    '        lblAmortiza.Text = "Amortización inicial"
    '        lblIvaamortiza.Text = "I.V.A. de la Amortización"
    '        lblOpcom.Text = "Amortización Final"
    '        lblOpcom.Text = "Opción a compra con I.V.A."
    '        lblRtaeq.Text = "Renta del Equipo"
    '        lblRtasD.Text = "Depósito FINAGIL"
    '        lblDepos.Text = "Depósito FINAGIL"

    '        ' Recordar que en Crédito Refaccionario NO existen Rentas en Depósito

    '        rbRDTrue.Checked = False
    '        rbRDFalse.Checked = True
    '        rbRDTrue.Enabled = False
    '        rbRDFalse.Enabled = False
    '        cbRtas.SelectedIndex = 0

    '        rbDGTrue.Enabled = True
    '        rbDGFalse.Enabled = True

    '        rbDNTrue.Enabled = False
    '        rbDNFalse.Enabled = False

    '        cbRecursos.Enabled = True
    '        If cbRecursos.SelectedIndex >= 0 Then cbRecursos.SelectedIndex = 0

    '    ElseIf cbProducto.SelectedIndex = 4 Then

    '        ' Crédito Refaccionario

    '        cTipar = "T"

    '        cbPorieq.SelectedIndex = 0
    '        cbPorieq.Enabled = False
    '        txtPorop.Text = Format(0, "F")
    '        txtPorop.ReadOnly = True
    '        txtAmorin.Enabled = True

    '        txtFondoReser.Text = Format(0, "##,##0.00")
    '        txtFondoReser.Enabled = True

    '        Label4.Text = "Opción de Compra"
    '        Label10.Text = "Total del Equipo"
    '        lblAmortiza.Text = "Enganche"
    '        lblPIAmortiza.Text = "Enganche"
    '        lblIvaamortiza.Text = "Derechos de Registro"
    '        lblOpcom.Text = "Opción a compra con I.V.A."
    '        lblRtaeq.Text = "Renta del Equipo"
    '        lblRtasD.Text = "Depósito FINAGIL"
    '        lblDepos.Text = "Depósito FINAGIL"

    '        ' Recordar que en Crédito Refaccionario NO existen Rentas en Depósito

    '        rbRDTrue.Checked = False
    '        rbRDFalse.Checked = True
    '        rbRDTrue.Enabled = False
    '        rbRDFalse.Enabled = False
    '        cbRtas.SelectedIndex = 0

    '        rbDGTrue.Enabled = True
    '        rbDGFalse.Enabled = True

    '        rbDNTrue.Enabled = False
    '        rbDNFalse.Enabled = False

    '        cbRecursos.Enabled = False
    '        If cbRecursos.SelectedIndex >= 0 Then cbRecursos.SelectedIndex = 2

    '    End If

    'End Sub


    Private Sub cbPorieq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPorieq.SelectedIndexChanged

    End Sub
End Class
