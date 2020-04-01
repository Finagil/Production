Option Explicit On 

Imports System.Data.SqlClient
Imports System.Math
Imports System.Security
Imports System.Security.Principal.WindowsIdentity

Public Class frmDatosconFull
    Inherits System.Windows.Forms.Form
    Dim myIdentity As Principal.WindowsIdentity
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Dim cUsuario As String
    Friend WithEvents ControlGastosEXT1 As Agil.ControlGastosEXT
    Friend WithEvents BtnOnbase As System.Windows.Forms.Button
    Dim Ta As New ProductionDataSetTableAdapters.FIRArefaccionariosTableAdapter
    Friend WithEvents TxtContMarco As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents BtnOnbaseCRE As System.Windows.Forms.Button
    Dim cAnexoOnbase As String = ""
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtFechaPAG As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TxtFechaACTI As System.Windows.Forms.TextBox
    Friend WithEvents TxtMensu1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtMensu As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ServiciosAdicionalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsultasDS As Agil.ConsultasDS
    Friend WithEvents ServiciosAdicionalesTableAdapter As Agil.ConsultasDSTableAdapters.ServiciosAdicionalesTableAdapter
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnSoldoc As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextPlanta As TextBox
    Friend WithEvents Label11 As Label
    Dim cAnexo As String = ""
    Friend WithEvents BtnObserva As Button
    Dim cCliente As String

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTipotasa As System.Windows.Forms.Label
    Friend WithEvents gpoPagos As System.Windows.Forms.GroupBox
    Friend WithEvents gpoPagosi As System.Windows.Forms.GroupBox
    Friend WithEvents lblComis As System.Windows.Forms.Label
    Friend WithEvents lblRatific As System.Windows.Forms.Label
    Friend WithEvents txtComis As System.Windows.Forms.TextBox
    Friend WithEvents lblMontof As System.Windows.Forms.Label
    Friend WithEvents lblOpcom As System.Windows.Forms.Label
    Friend WithEvents lblIvaeq As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblPlazo As System.Windows.Forms.Label
    Friend WithEvents txtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents txtIvaeq As System.Windows.Forms.TextBox
    Friend WithEvents btnDatoseq As System.Windows.Forms.Button
    Friend WithEvents btnReferencia As System.Windows.Forms.Button
    Friend WithEvents txtTermina As System.Windows.Forms.TextBox
    Friend WithEvents txtDescTipar As System.Windows.Forms.TextBox
    Friend WithEvents txtPorieq As System.Windows.Forms.TextBox
    Friend WithEvents txtPorco As System.Windows.Forms.TextBox
    Friend WithEvents txtPorop As System.Windows.Forms.TextBox
    Friend WithEvents txtTasas As System.Windows.Forms.TextBox
    Friend WithEvents txtDifer As System.Windows.Forms.TextBox
    Friend WithEvents txtGastos As System.Windows.Forms.TextBox
    Friend WithEvents txtImpEq As System.Windows.Forms.TextBox
    Friend WithEvents txtOpcion As System.Windows.Forms.TextBox
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents btnDatosCliente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnTablaEquipo As System.Windows.Forms.Button
    Friend WithEvents btnHistoria As System.Windows.Forms.Button
    Friend WithEvents txtMontoFinanciado As System.Windows.Forms.TextBox
    Friend WithEvents txtDescTasa As System.Windows.Forms.TextBox
    Friend WithEvents txtPagosIniciales As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblAnexo As System.Windows.Forms.Label
    Friend WithEvents lblDescr As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gpoPagosi = New System.Windows.Forms.GroupBox()
        Me.TxtMensu1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPagosIniciales = New System.Windows.Forms.TextBox()
        Me.txtGastos = New System.Windows.Forms.TextBox()
        Me.txtComis = New System.Windows.Forms.TextBox()
        Me.lblRatific = New System.Windows.Forms.Label()
        Me.lblComis = New System.Windows.Forms.Label()
        Me.gpoPagos = New System.Windows.Forms.GroupBox()
        Me.TxtMensu = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMontoFinanciado = New System.Windows.Forms.TextBox()
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.txtIvaeq = New System.Windows.Forms.TextBox()
        Me.txtImpEq = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblIvaeq = New System.Windows.Forms.Label()
        Me.lblOpcom = New System.Windows.Forms.Label()
        Me.lblMontof = New System.Windows.Forms.Label()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.txtDescTasa = New System.Windows.Forms.TextBox()
        Me.lblTipotasa = New System.Windows.Forms.Label()
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
        Me.btnHistoria = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblAnexo = New System.Windows.Forms.Label()
        Me.lblDescr = New System.Windows.Forms.Label()
        Me.BtnOnbase = New System.Windows.Forms.Button()
        Me.TxtContMarco = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.BtnOnbaseCRE = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtFechaPAG = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtFechaACTI = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciosAdicionalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultasDS = New Agil.ConsultasDS()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ServiciosAdicionalesTableAdapter = New Agil.ConsultasDSTableAdapters.ServiciosAdicionalesTableAdapter()
        Me.BtnSoldoc = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextPlanta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ControlGastosEXT1 = New Agil.ControlGastosEXT()
        Me.BtnObserva = New System.Windows.Forms.Button()
        Me.gpoPagosi.SuspendLayout()
        Me.gpoPagos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosAdicionalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultasDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpoPagosi
        '
        Me.gpoPagosi.Controls.Add(Me.TxtMensu1)
        Me.gpoPagosi.Controls.Add(Me.Label7)
        Me.gpoPagosi.Controls.Add(Me.Label14)
        Me.gpoPagosi.Controls.Add(Me.txtPagosIniciales)
        Me.gpoPagosi.Controls.Add(Me.txtGastos)
        Me.gpoPagosi.Controls.Add(Me.txtComis)
        Me.gpoPagosi.Controls.Add(Me.lblRatific)
        Me.gpoPagosi.Controls.Add(Me.lblComis)
        Me.gpoPagosi.Location = New System.Drawing.Point(384, 191)
        Me.gpoPagosi.Name = "gpoPagosi"
        Me.gpoPagosi.Size = New System.Drawing.Size(264, 128)
        Me.gpoPagosi.TabIndex = 49
        Me.gpoPagosi.TabStop = False
        Me.gpoPagosi.Text = "Pagos Iniciales"
        '
        'TxtMensu1
        '
        Me.TxtMensu1.Location = New System.Drawing.Point(168, 71)
        Me.TxtMensu1.Name = "TxtMensu1"
        Me.TxtMensu1.ReadOnly = True
        Me.TxtMensu1.Size = New System.Drawing.Size(88, 20)
        Me.TxtMensu1.TabIndex = 80
        Me.TxtMensu1.TabStop = False
        Me.TxtMensu1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Mensualidad con IVA"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 16)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Total de Pagos Iniciales"
        '
        'txtPagosIniciales
        '
        Me.txtPagosIniciales.Location = New System.Drawing.Point(168, 97)
        Me.txtPagosIniciales.Name = "txtPagosIniciales"
        Me.txtPagosIniciales.ReadOnly = True
        Me.txtPagosIniciales.Size = New System.Drawing.Size(88, 20)
        Me.txtPagosIniciales.TabIndex = 64
        Me.txtPagosIniciales.TabStop = False
        Me.txtPagosIniciales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGastos
        '
        Me.txtGastos.Location = New System.Drawing.Point(168, 45)
        Me.txtGastos.Name = "txtGastos"
        Me.txtGastos.ReadOnly = True
        Me.txtGastos.Size = New System.Drawing.Size(88, 20)
        Me.txtGastos.TabIndex = 60
        Me.txtGastos.TabStop = False
        Me.txtGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtComis
        '
        Me.txtComis.Location = New System.Drawing.Point(168, 19)
        Me.txtComis.Name = "txtComis"
        Me.txtComis.ReadOnly = True
        Me.txtComis.Size = New System.Drawing.Size(88, 20)
        Me.txtComis.TabIndex = 54
        Me.txtComis.TabStop = False
        Me.txtComis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRatific
        '
        Me.lblRatific.Location = New System.Drawing.Point(8, 48)
        Me.lblRatific.Name = "lblRatific"
        Me.lblRatific.Size = New System.Drawing.Size(156, 16)
        Me.lblRatific.TabIndex = 50
        Me.lblRatific.Text = "Ratificación con I.V.A."
        '
        'lblComis
        '
        Me.lblComis.Location = New System.Drawing.Point(8, 22)
        Me.lblComis.Name = "lblComis"
        Me.lblComis.Size = New System.Drawing.Size(156, 16)
        Me.lblComis.TabIndex = 47
        Me.lblComis.Text = "Comisión con I.V.A."
        '
        'gpoPagos
        '
        Me.gpoPagos.Controls.Add(Me.TxtMensu)
        Me.gpoPagos.Controls.Add(Me.Label10)
        Me.gpoPagos.Controls.Add(Me.txtMontoFinanciado)
        Me.gpoPagos.Controls.Add(Me.txtOpcion)
        Me.gpoPagos.Controls.Add(Me.txtIvaeq)
        Me.gpoPagos.Controls.Add(Me.txtImpEq)
        Me.gpoPagos.Controls.Add(Me.Label27)
        Me.gpoPagos.Controls.Add(Me.lblIvaeq)
        Me.gpoPagos.Controls.Add(Me.lblOpcom)
        Me.gpoPagos.Controls.Add(Me.lblMontof)
        Me.gpoPagos.Location = New System.Drawing.Point(384, 43)
        Me.gpoPagos.Name = "gpoPagos"
        Me.gpoPagos.Size = New System.Drawing.Size(264, 142)
        Me.gpoPagos.TabIndex = 48
        Me.gpoPagos.TabStop = False
        '
        'TxtMensu
        '
        Me.TxtMensu.Location = New System.Drawing.Point(168, 88)
        Me.TxtMensu.Name = "TxtMensu"
        Me.TxtMensu.ReadOnly = True
        Me.TxtMensu.Size = New System.Drawing.Size(88, 20)
        Me.TxtMensu.TabIndex = 78
        Me.TxtMensu.TabStop = False
        Me.TxtMensu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 16)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Mensualidad con IVA"
        '
        'txtMontoFinanciado
        '
        Me.txtMontoFinanciado.Location = New System.Drawing.Point(168, 112)
        Me.txtMontoFinanciado.Name = "txtMontoFinanciado"
        Me.txtMontoFinanciado.ReadOnly = True
        Me.txtMontoFinanciado.Size = New System.Drawing.Size(88, 20)
        Me.txtMontoFinanciado.TabIndex = 76
        Me.txtMontoFinanciado.TabStop = False
        Me.txtMontoFinanciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOpcion
        '
        Me.txtOpcion.Location = New System.Drawing.Point(168, 64)
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.ReadOnly = True
        Me.txtOpcion.Size = New System.Drawing.Size(88, 20)
        Me.txtOpcion.TabIndex = 74
        Me.txtOpcion.TabStop = False
        Me.txtOpcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.lblIvaeq.Location = New System.Drawing.Point(8, 43)
        Me.lblIvaeq.Name = "lblIvaeq"
        Me.lblIvaeq.Size = New System.Drawing.Size(144, 16)
        Me.lblIvaeq.TabIndex = 57
        Me.lblIvaeq.Text = "I.V.A. del Equipo"
        '
        'lblOpcom
        '
        Me.lblOpcom.Location = New System.Drawing.Point(8, 67)
        Me.lblOpcom.Name = "lblOpcom"
        Me.lblOpcom.Size = New System.Drawing.Size(144, 16)
        Me.lblOpcom.TabIndex = 55
        Me.lblOpcom.Text = "Opción a compra con I.V.A."
        '
        'lblMontof
        '
        Me.lblMontof.Location = New System.Drawing.Point(8, 115)
        Me.lblMontof.Name = "lblMontof"
        Me.lblMontof.Size = New System.Drawing.Size(144, 16)
        Me.lblMontof.TabIndex = 54
        Me.lblMontof.Text = "Monto Financiado"
        '
        'txtPlazo
        '
        Me.txtPlazo.Location = New System.Drawing.Point(322, 69)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.ReadOnly = True
        Me.txtPlazo.Size = New System.Drawing.Size(24, 20)
        Me.txtPlazo.TabIndex = 61
        Me.txtPlazo.TabStop = False
        Me.txtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPlazo
        '
        Me.lblPlazo.AutoSize = True
        Me.lblPlazo.Location = New System.Drawing.Point(235, 76)
        Me.lblPlazo.Name = "lblPlazo"
        Me.lblPlazo.Size = New System.Drawing.Size(81, 13)
        Me.lblPlazo.TabIndex = 59
        Me.lblPlazo.Text = "Plazo en meses"
        Me.lblPlazo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescTasa
        '
        Me.txtDescTasa.Location = New System.Drawing.Point(143, 191)
        Me.txtDescTasa.Name = "txtDescTasa"
        Me.txtDescTasa.ReadOnly = True
        Me.txtDescTasa.Size = New System.Drawing.Size(224, 20)
        Me.txtDescTasa.TabIndex = 47
        Me.txtDescTasa.TabStop = False
        '
        'lblTipotasa
        '
        Me.lblTipotasa.Location = New System.Drawing.Point(15, 191)
        Me.lblTipotasa.Name = "lblTipotasa"
        Me.lblTipotasa.Size = New System.Drawing.Size(120, 16)
        Me.lblTipotasa.TabIndex = 46
        Me.lblTipotasa.Text = "Tipo de Tasa"
        Me.lblTipotasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(352, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "%"
        '
        'txtDifer
        '
        Me.txtDifer.Location = New System.Drawing.Point(290, 166)
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
        Me.Label5.Location = New System.Drawing.Point(199, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "%"
        '
        'txtTasas
        '
        Me.txtTasas.Location = New System.Drawing.Point(143, 168)
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
        Me.Label9.Location = New System.Drawing.Point(199, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "%"
        '
        'txtPorop
        '
        Me.txtPorop.Location = New System.Drawing.Point(143, 144)
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
        Me.Label2.Location = New System.Drawing.Point(352, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "%"
        '
        'txtPorco
        '
        Me.txtPorco.Location = New System.Drawing.Point(290, 117)
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
        Me.Label1.Location = New System.Drawing.Point(351, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "%"
        '
        'txtPorieq
        '
        Me.txtPorieq.Location = New System.Drawing.Point(290, 93)
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
        Me.txtTermina.Location = New System.Drawing.Point(144, 119)
        Me.txtTermina.Name = "txtTermina"
        Me.txtTermina.ReadOnly = True
        Me.txtTermina.Size = New System.Drawing.Size(64, 20)
        Me.txtTermina.TabIndex = 16
        Me.txtTermina.TabStop = False
        Me.txtTermina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDifer
        '
        Me.lblDifer.AutoSize = True
        Me.lblDifer.Location = New System.Drawing.Point(227, 168)
        Me.lblDifer.Name = "lblDifer"
        Me.lblDifer.Size = New System.Drawing.Size(57, 13)
        Me.lblDifer.TabIndex = 13
        Me.lblDifer.Text = "Diferencial"
        Me.lblDifer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTasai
        '
        Me.lblTasai.Location = New System.Drawing.Point(15, 168)
        Me.lblTasai.Name = "lblTasai"
        Me.lblTasai.Size = New System.Drawing.Size(120, 16)
        Me.lblTasai.TabIndex = 12
        Me.lblTasai.Text = "Tasa de Interés"
        Me.lblTasai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Opción de Compra"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Comisión"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Location = New System.Drawing.Point(251, 97)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(33, 13)
        Me.lblIva.TabIndex = 9
        Me.lblIva.Text = "I.V.A."
        Me.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechafin
        '
        Me.lblFechafin.AutoSize = True
        Me.lblFechafin.Location = New System.Drawing.Point(16, 123)
        Me.lblFechafin.Name = "lblFechafin"
        Me.lblFechafin.Size = New System.Drawing.Size(113, 13)
        Me.lblFechafin.TabIndex = 8
        Me.lblFechafin.Text = "Fecha de Terminación"
        Me.lblFechafin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFvenc
        '
        Me.txtFvenc.Location = New System.Drawing.Point(144, 95)
        Me.txtFvenc.Name = "txtFvenc"
        Me.txtFvenc.ReadOnly = True
        Me.txtFvenc.Size = New System.Drawing.Size(64, 20)
        Me.txtFvenc.TabIndex = 7
        Me.txtFvenc.TabStop = False
        Me.txtFvenc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFechacon
        '
        Me.txtFechacon.Location = New System.Drawing.Point(144, 71)
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
        Me.lblFechaven1.Location = New System.Drawing.Point(16, 100)
        Me.lblFechaven1.Name = "lblFechaven1"
        Me.lblFechaven1.Size = New System.Drawing.Size(119, 13)
        Me.lblFechaven1.TabIndex = 3
        Me.lblFechaven1.Text = "Fecha 1er. Vencimiento"
        Me.lblFechaven1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechac
        '
        Me.lblFechac.AutoSize = True
        Me.lblFechac.Location = New System.Drawing.Point(16, 76)
        Me.lblFechac.Name = "lblFechac"
        Me.lblFechac.Size = New System.Drawing.Size(115, 13)
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
        Me.lblNumc.Location = New System.Drawing.Point(18, 9)
        Me.lblNumc.Name = "lblNumc"
        Me.lblNumc.Size = New System.Drawing.Size(88, 20)
        Me.lblNumc.TabIndex = 0
        Me.lblNumc.Text = "No. de Contrato"
        Me.lblNumc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDatosCliente
        '
        Me.btnDatosCliente.Enabled = False
        Me.btnDatosCliente.Location = New System.Drawing.Point(665, 97)
        Me.btnDatosCliente.Name = "btnDatosCliente"
        Me.btnDatosCliente.Size = New System.Drawing.Size(104, 24)
        Me.btnDatosCliente.TabIndex = 0
        Me.btnDatosCliente.Text = "Datos del Cliente"
        '
        'btnDatoseq
        '
        Me.btnDatoseq.Enabled = False
        Me.btnDatoseq.Location = New System.Drawing.Point(665, 126)
        Me.btnDatoseq.Name = "btnDatoseq"
        Me.btnDatoseq.Size = New System.Drawing.Size(104, 24)
        Me.btnDatoseq.TabIndex = 1
        Me.btnDatoseq.Text = "Datos del Equipo"
        '
        'btnReferencia
        '
        Me.btnReferencia.Enabled = False
        Me.btnReferencia.Location = New System.Drawing.Point(665, 155)
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
        Me.btnTablaEquipo.Location = New System.Drawing.Point(665, 184)
        Me.btnTablaEquipo.Name = "btnTablaEquipo"
        Me.btnTablaEquipo.Size = New System.Drawing.Size(104, 24)
        Me.btnTablaEquipo.TabIndex = 3
        Me.btnTablaEquipo.Text = "Tabla Equipo"
        '
        'btnHistoria
        '
        Me.btnHistoria.Enabled = False
        Me.btnHistoria.Location = New System.Drawing.Point(665, 213)
        Me.btnHistoria.Name = "btnHistoria"
        Me.btnHistoria.Size = New System.Drawing.Size(104, 24)
        Me.btnHistoria.TabIndex = 5
        Me.btnHistoria.Text = "Historia de Pagos"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(174, 12)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(105, 31)
        Me.lblStatus.TabIndex = 69
        '
        'lblAnexo
        '
        Me.lblAnexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnexo.Location = New System.Drawing.Point(99, 12)
        Me.lblAnexo.Name = "lblAnexo"
        Me.lblAnexo.Size = New System.Drawing.Size(72, 20)
        Me.lblAnexo.TabIndex = 70
        Me.lblAnexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescr
        '
        Me.lblDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescr.Location = New System.Drawing.Point(282, 12)
        Me.lblDescr.Name = "lblDescr"
        Me.lblDescr.Size = New System.Drawing.Size(487, 31)
        Me.lblDescr.TabIndex = 71
        '
        'BtnOnbase
        '
        Me.BtnOnbase.Location = New System.Drawing.Point(665, 296)
        Me.BtnOnbase.Name = "BtnOnbase"
        Me.BtnOnbase.Size = New System.Drawing.Size(104, 24)
        Me.BtnOnbase.TabIndex = 99
        Me.BtnOnbase.Text = "OnBase Contrato"
        '
        'TxtContMarco
        '
        Me.TxtContMarco.Location = New System.Drawing.Point(665, 71)
        Me.TxtContMarco.Name = "TxtContMarco"
        Me.TxtContMarco.ReadOnly = True
        Me.TxtContMarco.Size = New System.Drawing.Size(102, 20)
        Me.TxtContMarco.TabIndex = 132
        Me.TxtContMarco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(654, 49)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(118, 19)
        Me.Label22.TabIndex = 131
        Me.Label22.Text = "No. de Contrato Marco"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnOnbaseCRE
        '
        Me.BtnOnbaseCRE.Location = New System.Drawing.Point(665, 325)
        Me.BtnOnbaseCRE.Name = "BtnOnbaseCRE"
        Me.BtnOnbaseCRE.Size = New System.Drawing.Size(104, 24)
        Me.BtnOnbaseCRE.TabIndex = 135
        Me.BtnOnbaseCRE.Text = "OnBase Crédito"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(15, 216)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(120, 16)
        Me.Label25.TabIndex = 136
        Me.Label25.Text = "Fecha de Pago"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFechaPAG
        '
        Me.TxtFechaPAG.Location = New System.Drawing.Point(143, 215)
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
        Me.Label26.Location = New System.Drawing.Point(15, 243)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(105, 13)
        Me.Label26.TabIndex = 138
        Me.Label26.Text = "Fecha de Activación"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFechaACTI
        '
        Me.TxtFechaACTI.Location = New System.Drawing.Point(143, 240)
        Me.TxtFechaACTI.Name = "TxtFechaACTI"
        Me.TxtFechaACTI.ReadOnly = True
        Me.TxtFechaACTI.Size = New System.Drawing.Size(68, 20)
        Me.TxtFechaACTI.TabIndex = 139
        Me.TxtFechaACTI.TabStop = False
        Me.TxtFechaACTI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ServiciosAdicionalesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 326)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(419, 121)
        Me.DataGridView1.TabIndex = 140
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 250
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Format = "n2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiciosAdicionalesBindingSource
        '
        Me.ServiciosAdicionalesBindingSource.DataMember = "ServiciosAdicionales"
        Me.ServiciosAdicionalesBindingSource.DataSource = Me.ConsultasDS
        '
        'ConsultasDS
        '
        Me.ConsultasDS.DataSetName = "ConsultasDS"
        Me.ConsultasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "Servicios Adicionales"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ServiciosAdicionalesTableAdapter
        '
        Me.ServiciosAdicionalesTableAdapter.ClearBeforeFill = True
        '
        'BtnSoldoc
        '
        Me.BtnSoldoc.Location = New System.Drawing.Point(665, 355)
        Me.BtnSoldoc.Name = "BtnSoldoc"
        Me.BtnSoldoc.Size = New System.Drawing.Size(104, 24)
        Me.BtnSoldoc.TabIndex = 142
        Me.BtnSoldoc.Text = "Solicitar Doc."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(665, 385)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 152
        Me.Button2.Text = "Docs. Seguro"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(665, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 34)
        Me.Button1.TabIndex = 153
        Me.Button1.Text = "Doctos. FullService"
        '
        'TextPlanta
        '
        Me.TextPlanta.Location = New System.Drawing.Point(143, 266)
        Me.TextPlanta.Name = "TextPlanta"
        Me.TextPlanta.ReadOnly = True
        Me.TextPlanta.Size = New System.Drawing.Size(141, 20)
        Me.TextPlanta.TabIndex = 155
        Me.TextPlanta.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "Ciudad o Planta"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ControlGastosEXT1
        '
        Me.ControlGastosEXT1.Location = New System.Drawing.Point(665, 244)
        Me.ControlGastosEXT1.Name = "ControlGastosEXT1"
        Me.ControlGastosEXT1.Size = New System.Drawing.Size(102, 44)
        Me.ControlGastosEXT1.TabIndex = 98
        '
        'BtnObserva
        '
        Me.BtnObserva.Location = New System.Drawing.Point(555, 415)
        Me.BtnObserva.Name = "BtnObserva"
        Me.BtnObserva.Size = New System.Drawing.Size(104, 34)
        Me.BtnObserva.TabIndex = 175
        Me.BtnObserva.Text = "Observaciones Adicionales"
        '
        'frmDatosconFull
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(783, 456)
        Me.Controls.Add(Me.BtnObserva)
        Me.Controls.Add(Me.TextPlanta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnSoldoc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtFechaACTI)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TxtFechaPAG)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.BtnOnbaseCRE)
        Me.Controls.Add(Me.TxtContMarco)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.BtnOnbase)
        Me.Controls.Add(Me.ControlGastosEXT1)
        Me.Controls.Add(Me.lblDescr)
        Me.Controls.Add(Me.lblAnexo)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnHistoria)
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
        Me.Controls.Add(Me.lblTipotasa)
        Me.Controls.Add(Me.gpoPagosi)
        Me.Controls.Add(Me.lblPlazo)
        Me.Controls.Add(Me.txtPlazo)
        Me.Name = "frmDatosconFull"
        Me.Text = "Datos del Contrato"
        Me.gpoPagosi.ResumeLayout(False)
        Me.gpoPagosi.PerformLayout()
        Me.gpoPagos.ResumeLayout(False)
        Me.gpoPagos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosAdicionalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultasDS, System.ComponentModel.ISupportInitialize).EndInit()
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


        cAnexo = Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4)
        Me.ServiciosAdicionalesTableAdapter.Fill(ConsultasDS.ServiciosAdicionales, cAnexo)
        Dim TaPrenda As New ProductionDataSetTableAdapters.PrendaTableAdapter

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
            lblStatus.Text = SacaGEN_ESTAUS(cFlcan)
            lblDescr.Text = drAnexo("Descr")

            ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++
            Dim TaOnbase As New GeneralDSTableAdapters.OnBaseTableAdapter
            cAnexoOnbase = "% " & CDbl(Mid(cAnexo, 2, 8)) & " %"
            If TaOnbase.ScalarCuantosAreaAnexo("Mesa de Control", CadOnbase(cAnexo)) > 0 Then
                BtnOnbase.Enabled = True
            Else
                BtnOnbase.Enabled = False
            End If
            cCliente = drAnexo("cliente")
            If TaOnbase.ScalarCuantosAreaAnexo("Credito", CadOnbase(cCliente)) > 0 Then
                BtnOnbaseCRE.Enabled = True
            Else
                BtnOnbaseCRE.Enabled = False
            End If
            ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++

            cTipar = drAnexo("Tipar")
            txtDescTipar.Text = drAnexo("TipoCredito")
            txtFechacon.Text = CTOD(drAnexo("Fechacon"))
            txtFvenc.Text = CTOD(drAnexo("Fvenc"))
            txtPlazo.Text = drAnexo("Plazo")
            txtTermina.Text = Termina(cAnexo)
            txtPorieq.Text = Format(drAnexo("Porieq"), "##,##0.0000")
            txtPorco.Text = Format(drAnexo("Porco"), "F")
            txtPorop.Text = Format(drAnexo("Porop"), "F")
            txtTasas.Text = Format(drAnexo("Tasas"), "##,##0.0000")
            txtDifer.Text = Format(drAnexo("Difer"), "##,##0.0000")
            TxtMensu.Text = Format(drAnexo("Mensu"), "##,##0.00")
            TxtMensu1.Text = Format(drAnexo("Mensu"), "##,##0.00")
            TextPlanta.Text = Trim(drAnexo("CNempresa"))
            TxtContMarco.Text = drAnexo("ContratoMarco")
            If Trim(drAnexo("Fecha_Pago")) <> "" Then
                TxtFechaPAG.Text = CTOD(drAnexo("Fecha_Pago"))
            Else
                TxtFechaPAG.Text = ""
            End If
            If Trim(drAnexo("FechaActivacion")) <> "" Then
                TxtFechaACTI.Text = CTOD(drAnexo("FechaActivacion"))
            Else
                TxtFechaACTI.Text = ""
            End If

            txtDescTasa.Text = drAnexo("DescTasa")
            nImpEq = drAnexo("ImpEq")
            nPorop = drAnexo("Porop")
            Label27.Text = "Equipo con I.V.A."

            txtImpEq.Text = Format(drAnexo("ImpEq"), "##,##0.00")
            txtIvaeq.Text = Format(drAnexo("IvaEq"), "##,##0.00")


            If cTipar = "R" Then
            ElseIf cTipar = "P" Then

                Label4.Text = "Valor Residual"
                lblOpcom.Text = "Amortización Final"
            End If

            Dim IvaAux As Decimal = drAnexo("IvaEq") / (drAnexo("ImpEq") - drAnexo("IvaEq"))
            txtOpcion.Text = Format(drAnexo("OC"), "##,##0.00")
            txtMontoFinanciado.Text = Format((drAnexo("mensu") / (1 + IvaAux)) * drAnexo("Plazo"), "##,##0.00")
            txtComis.Text = Format(drAnexo("Comis"), "##,##0.00")

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

            txtGastos.Text = Format(drAnexo("Gastos") + drAnexo("IvaGastos"), "##,##0.00")
            nSaldoEquipo = Round(drAnexo("ImpEq") - drAnexo("IvaEq") - drAnexo("Amorin"), 2)
            txtPagosIniciales.Text = Format(drAnexo("Mensu") + drAnexo("Derechos") + drAnexo("Comis") + drAnexo("Gastos") + drAnexo("IvaGastos") + drAnexo("DepNafin"), "##,##0.00")
            txtCliente.Text = drAnexo("Cliente")
            txtReferencia.Text = drAnexo("Referencia")
        End If
        ColorBotonObservaciones(cAnexo, "", BtnObserva, "Observaciones")
        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnDatosCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatosCliente.Click
        Dim newfrmDatosClie As New frmDatosclie(txtCliente.Text)
        newfrmDatosClie.Show()
    End Sub

    Private Sub btnDatoseq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatoseq.Click
        Dim newfrmDatosEq As New FrmDatosVehiculo()
        newfrmDatosEq.Bloqueado = True
        newfrmDatosEq.Nombre = lblDescr.Text
        newfrmDatosEq.Contrato = cAnexo
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


    Private Sub btnHistoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistoria.Click
        Dim newfrmHistoria As New frmHistoria(lblAnexo.Text, "")
        Cursor.Current = Cursors.WaitCursor
        newfrmHistoria.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        f.AnexoOcliente = cCliente
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New FrmAtachments
        f.Anexo = Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4)
        f.Ciclo = ""
        f.Carpeta = "Seguros"
        If TaQUERY.SacaPermisoModulo("SEGUROS_DOC", UsuarioGlobal) > 0 Then
            f.Consulta = False
        Else
            f.Consulta = True
        End If
        f.Nombre = lblDescr.Text
        If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New FrmAtachments
        f.Anexo = Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4)
        f.Ciclo = ""
        f.Carpeta = "FullService"
        If TaQUERY.SacaPermisoModulo("FULL_SERVICE_DOC", UsuarioGlobal) > 0 Then
            f.Consulta = False
        Else
            f.Consulta = True
        End If
        f.Nombre = lblDescr.Text
        If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Private Sub BtnObserva_Click(sender As Object, e As EventArgs) Handles BtnObserva.Click
        Dim f As New FrmAtachments
        f.Anexo = Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4)
        f.Ciclo = ""
        f.Consulta = False
        f.Carpeta = "Observaciones"
        f.Nombre = lblDescr.Text
        If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        End If
        ColorBotonObservaciones(cAnexo, "", BtnObserva, "Observaciones")
    End Sub
End Class
