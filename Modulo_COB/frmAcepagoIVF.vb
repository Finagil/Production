' Esta forma recibe como par�metro el n�mero del cliente del cual se desea obtener sus adeudos

Option Explicit On

Imports System.Data.SqlClient
Imports System.Math

Public Class frmAcepagoIVF

    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal cCliente As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtCliente.Text = cCliente

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
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnAplicarPago As System.Windows.Forms.Button
    Friend WithEvents lvPagos As System.Windows.Forms.ListView
    Friend WithEvents lvSaldos As System.Windows.Forms.ListView
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents txtMontoPagado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSaldos As System.Windows.Forms.Label
    Friend WithEvents lblPagos As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblFechaPago As System.Windows.Forms.Label
    Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSerieA As System.Windows.Forms.TextBox
    Friend WithEvents lblIDSerieA As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents lblIDSerieMXL As System.Windows.Forms.Label
    Friend WithEvents txtSerieMXL As System.Windows.Forms.TextBox
    Friend WithEvents LbGarantia As System.Windows.Forms.Label
    Friend WithEvents ControlGastosEXT1 As Agil.ControlGastosEXT
    Friend WithEvents CheckDG As System.Windows.Forms.CheckBox
    Friend WithEvents CheckRD As System.Windows.Forms.CheckBox
    Friend WithEvents TxtIDBlanco As System.Windows.Forms.TextBox
    Friend WithEvents LbBlanco As System.Windows.Forms.Label
    Friend WithEvents CkAppBlanco As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbInstruMon As ComboBox
    Friend WithEvents GeneralDS As GeneralDS
    Friend WithEvents InstrumentoMonetarioBindingSource As BindingSource
    Friend WithEvents InstrumentoMonetarioTableAdapter As GeneralDSTableAdapters.InstrumentoMonetarioTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.btnAplicarPago = New System.Windows.Forms.Button()
        Me.lvPagos = New System.Windows.Forms.ListView()
        Me.lvSaldos = New System.Windows.Forms.ListView()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.txtMontoPagado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSaldos = New System.Windows.Forms.Label()
        Me.lblPagos = New System.Windows.Forms.Label()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFechaPago = New System.Windows.Forms.Label()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.txtSerieA = New System.Windows.Forms.TextBox()
        Me.lblIDSerieA = New System.Windows.Forms.Label()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.lblIDSerieMXL = New System.Windows.Forms.Label()
        Me.txtSerieMXL = New System.Windows.Forms.TextBox()
        Me.LbGarantia = New System.Windows.Forms.Label()
        Me.CheckDG = New System.Windows.Forms.CheckBox()
        Me.CheckRD = New System.Windows.Forms.CheckBox()
        Me.TxtIDBlanco = New System.Windows.Forms.TextBox()
        Me.LbBlanco = New System.Windows.Forms.Label()
        Me.CkAppBlanco = New System.Windows.Forms.CheckBox()
        Me.ControlGastosEXT1 = New Agil.ControlGastosEXT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbInstruMon = New System.Windows.Forms.ComboBox()
        Me.InstrumentoMonetarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS()
        Me.InstrumentoMonetarioTableAdapter = New Agil.GeneralDSTableAdapters.InstrumentoMonetarioTableAdapter()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstrumentoMonetarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(25, 70)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(48, 20)
        Me.txtCliente.TabIndex = 11
        Me.txtCliente.TabStop = False
        Me.txtCliente.Visible = False
        '
        'btnAplicarPago
        '
        Me.btnAplicarPago.Location = New System.Drawing.Point(432, 588)
        Me.btnAplicarPago.Name = "btnAplicarPago"
        Me.btnAplicarPago.Size = New System.Drawing.Size(80, 23)
        Me.btnAplicarPago.TabIndex = 7
        Me.btnAplicarPago.Text = "Aplicar Pago"
        Me.btnAplicarPago.Visible = False
        '
        'lvPagos
        '
        Me.lvPagos.Location = New System.Drawing.Point(22, 388)
        Me.lvPagos.Name = "lvPagos"
        Me.lvPagos.Size = New System.Drawing.Size(672, 158)
        Me.lvPagos.TabIndex = 6
        Me.lvPagos.UseCompatibleStateImageBehavior = False
        Me.lvPagos.Visible = False
        '
        'lvSaldos
        '
        Me.lvSaldos.Location = New System.Drawing.Point(22, 161)
        Me.lvSaldos.Name = "lvSaldos"
        Me.lvSaldos.Size = New System.Drawing.Size(672, 158)
        Me.lvSaldos.TabIndex = 5
        Me.lvSaldos.UseCompatibleStateImageBehavior = False
        Me.lvSaldos.Visible = False
        '
        'cbBancos
        '
        Me.cbBancos.Location = New System.Drawing.Point(252, 39)
        Me.cbBancos.MaxDropDownItems = 10
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(224, 21)
        Me.cbBancos.TabIndex = 3
        '
        'txtMontoPagado
        '
        Me.txtMontoPagado.Location = New System.Drawing.Point(22, 41)
        Me.txtMontoPagado.Name = "txtMontoPagado"
        Me.txtMontoPagado.Size = New System.Drawing.Size(88, 20)
        Me.txtMontoPagado.TabIndex = 1
        Me.txtMontoPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Monto del Pago"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblSaldos
        '
        Me.lblSaldos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldos.Location = New System.Drawing.Point(22, 135)
        Me.lblSaldos.Name = "lblSaldos"
        Me.lblSaldos.Size = New System.Drawing.Size(329, 23)
        Me.lblSaldos.TabIndex = 17
        Me.lblSaldos.Text = "Hacer doble click sobre el concepto que se desea pagar"
        Me.lblSaldos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblSaldos.Visible = False
        '
        'lblPagos
        '
        Me.lblPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagos.Location = New System.Drawing.Point(22, 356)
        Me.lblPagos.Name = "lblPagos"
        Me.lblPagos.Size = New System.Drawing.Size(308, 23)
        Me.lblPagos.TabIndex = 18
        Me.lblPagos.Text = "Estos son los conceptos que se cubrir�n con el pago"
        Me.lblPagos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblPagos.Visible = False
        '
        'txtCheque
        '
        Me.txtCheque.Location = New System.Drawing.Point(126, 41)
        Me.txtCheque.MaxLength = 15
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(120, 20)
        Me.txtCheque.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(126, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "No. de Cheque"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(252, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Seleccione el Banco"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(764, 16)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(75, 23)
        Me.btnContinuar.TabIndex = 5
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 632)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(867, 22)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(132, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'lblFechaPago
        '
        Me.lblFechaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPago.Location = New System.Drawing.Point(479, 14)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(110, 16)
        Me.lblFechaPago.TabIndex = 68
        Me.lblFechaPago.Text = "Fecha de Pago"
        Me.lblFechaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(482, 39)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaPago.TabIndex = 4
        '
        'txtSerieA
        '
        Me.txtSerieA.Location = New System.Drawing.Point(609, 71)
        Me.txtSerieA.Name = "txtSerieA"
        Me.txtSerieA.ReadOnly = True
        Me.txtSerieA.Size = New System.Drawing.Size(85, 20)
        Me.txtSerieA.TabIndex = 114
        Me.txtSerieA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSerieA.Visible = False
        '
        'lblIDSerieA
        '
        Me.lblIDSerieA.AutoSize = True
        Me.lblIDSerieA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDSerieA.Location = New System.Drawing.Point(481, 74)
        Me.lblIDSerieA.Name = "lblIDSerieA"
        Me.lblIDSerieA.Size = New System.Drawing.Size(122, 13)
        Me.lblIDSerieA.TabIndex = 116
        Me.lblIDSerieA.Text = "Consecutivo Serie A"
        Me.lblIDSerieA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblIDSerieA.Visible = False
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(110, 70)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(37, 34)
        Me.DataGrid1.TabIndex = 117
        Me.DataGrid1.Visible = False
        '
        'lblIDSerieMXL
        '
        Me.lblIDSerieMXL.AutoSize = True
        Me.lblIDSerieMXL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDSerieMXL.Location = New System.Drawing.Point(464, 97)
        Me.lblIDSerieMXL.Name = "lblIDSerieMXL"
        Me.lblIDSerieMXL.Size = New System.Drawing.Size(139, 13)
        Me.lblIDSerieMXL.TabIndex = 119
        Me.lblIDSerieMXL.Text = "Consecutivo Serie MXL"
        Me.lblIDSerieMXL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblIDSerieMXL.Visible = False
        '
        'txtSerieMXL
        '
        Me.txtSerieMXL.Location = New System.Drawing.Point(609, 94)
        Me.txtSerieMXL.Name = "txtSerieMXL"
        Me.txtSerieMXL.ReadOnly = True
        Me.txtSerieMXL.Size = New System.Drawing.Size(85, 20)
        Me.txtSerieMXL.TabIndex = 121
        Me.txtSerieMXL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSerieMXL.Visible = False
        '
        'LbGarantia
        '
        Me.LbGarantia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGarantia.ForeColor = System.Drawing.Color.Red
        Me.LbGarantia.Location = New System.Drawing.Point(22, 329)
        Me.LbGarantia.Name = "LbGarantia"
        Me.LbGarantia.Size = New System.Drawing.Size(672, 27)
        Me.LbGarantia.TabIndex = 122
        Me.LbGarantia.Text = "CONTRATO CON GARANT�AS DE FIRA EJERCIDAS FAVOR DE VERIFICAR SU APLICACI�N CON CON" &
    "TRALOR�A"
        Me.LbGarantia.Visible = False
        '
        'CheckDG
        '
        Me.CheckDG.AutoSize = True
        Me.CheckDG.Enabled = False
        Me.CheckDG.Location = New System.Drawing.Point(684, 14)
        Me.CheckDG.Name = "CheckDG"
        Me.CheckDG.Size = New System.Drawing.Size(74, 17)
        Me.CheckDG.TabIndex = 124
        Me.CheckDG.Text = "Aplica DG"
        Me.CheckDG.UseVisualStyleBackColor = True
        '
        'CheckRD
        '
        Me.CheckRD.AutoSize = True
        Me.CheckRD.Enabled = False
        Me.CheckRD.Location = New System.Drawing.Point(684, 37)
        Me.CheckRD.Name = "CheckRD"
        Me.CheckRD.Size = New System.Drawing.Size(74, 17)
        Me.CheckRD.TabIndex = 125
        Me.CheckRD.Text = "Aplica RD"
        Me.CheckRD.UseVisualStyleBackColor = True
        '
        'TxtIDBlanco
        '
        Me.TxtIDBlanco.Location = New System.Drawing.Point(609, 117)
        Me.TxtIDBlanco.Name = "TxtIDBlanco"
        Me.TxtIDBlanco.ReadOnly = True
        Me.TxtIDBlanco.Size = New System.Drawing.Size(85, 20)
        Me.TxtIDBlanco.TabIndex = 127
        Me.TxtIDBlanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtIDBlanco.Visible = False
        '
        'LbBlanco
        '
        Me.LbBlanco.AutoSize = True
        Me.LbBlanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBlanco.Location = New System.Drawing.Point(429, 120)
        Me.LbBlanco.Name = "LbBlanco"
        Me.LbBlanco.Size = New System.Drawing.Size(174, 13)
        Me.LbBlanco.TabIndex = 126
        Me.LbBlanco.Text = "Consecutivo Aplic. en Blanco"
        Me.LbBlanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LbBlanco.Visible = False
        '
        'CkAppBlanco
        '
        Me.CkAppBlanco.AutoSize = True
        Me.CkAppBlanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkAppBlanco.Location = New System.Drawing.Point(22, 588)
        Me.CkAppBlanco.Name = "CkAppBlanco"
        Me.CkAppBlanco.Size = New System.Drawing.Size(146, 17)
        Me.CkAppBlanco.TabIndex = 128
        Me.CkAppBlanco.Text = "Aplicaci�n en Blanco"
        Me.CkAppBlanco.UseVisualStyleBackColor = True
        Me.CkAppBlanco.Visible = False
        '
        'ControlGastosEXT1
        '
        Me.ControlGastosEXT1.Location = New System.Drawing.Point(576, 16)
        Me.ControlGastosEXT1.Name = "ControlGastosEXT1"
        Me.ControlGastosEXT1.Size = New System.Drawing.Size(102, 44)
        Me.ControlGastosEXT1.TabIndex = 123
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 574)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Instrumento Monetario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'CmbInstruMon
        '
        Me.CmbInstruMon.DataSource = Me.InstrumentoMonetarioBindingSource
        Me.CmbInstruMon.DisplayMember = "Titulo"
        Me.CmbInstruMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbInstruMon.FormattingEnabled = True
        Me.CmbInstruMon.Location = New System.Drawing.Point(175, 590)
        Me.CmbInstruMon.Name = "CmbInstruMon"
        Me.CmbInstruMon.Size = New System.Drawing.Size(251, 21)
        Me.CmbInstruMon.TabIndex = 130
        Me.CmbInstruMon.ValueMember = "Clave"
        '
        'InstrumentoMonetarioBindingSource
        '
        Me.InstrumentoMonetarioBindingSource.DataMember = "InstrumentoMonetario"
        Me.InstrumentoMonetarioBindingSource.DataSource = Me.GeneralDS
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InstrumentoMonetarioTableAdapter
        '
        Me.InstrumentoMonetarioTableAdapter.ClearBeforeFill = True
        '
        'frmAcepagoIVF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(867, 654)
        Me.Controls.Add(Me.CmbInstruMon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CkAppBlanco)
        Me.Controls.Add(Me.TxtIDBlanco)
        Me.Controls.Add(Me.LbBlanco)
        Me.Controls.Add(Me.CheckRD)
        Me.Controls.Add(Me.CheckDG)
        Me.Controls.Add(Me.ControlGastosEXT1)
        Me.Controls.Add(Me.LbGarantia)
        Me.Controls.Add(Me.txtSerieMXL)
        Me.Controls.Add(Me.lblIDSerieMXL)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.lblIDSerieA)
        Me.Controls.Add(Me.txtSerieA)
        Me.Controls.Add(Me.lblFechaPago)
        Me.Controls.Add(Me.dtpFechaPago)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCheque)
        Me.Controls.Add(Me.lblPagos)
        Me.Controls.Add(Me.lblSaldos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMontoPagado)
        Me.Controls.Add(Me.cbBancos)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.btnAplicarPago)
        Me.Controls.Add(Me.lvPagos)
        Me.Controls.Add(Me.lvSaldos)
        Me.Name = "frmAcepagoIVF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepci�n de Pagos"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstrumentoMonetarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' Declaraci�n de variables de conexi�n ADO .NET de alcance Privado

    Dim dtMovimientos As New DataTable("Movimientos")

    ' Declaraci�n de variables de datos de alcance Privado

    Dim cCliente As String = ""
    Dim cFechaAplicacion As String = ""
    Dim cFechaPago As String = ""
    Dim cSerie As String = ""
    Dim cSucursal As String = ""
    Dim i As Integer = 0
    Dim j As Integer = 0
    'Dim nIDSerieA As Decimal = 0
    'Dim nIDSerieMXL As Decimal = 0
    'Dim nIDBlanco As Decimal = 0
    Dim nMontoPagado As Decimal = 0
    Dim nTasaIvaCliente As Decimal = 0
    Dim cAnexoDG As String = ""
    Dim nTotalDG As Decimal = 0
    Dim nDG As Decimal = 0
    Dim nDGIva As Decimal = 0
    Dim cAnexoRD As String = ""
    Dim nTotalRD As Decimal = 0
    Dim nRD As Decimal = 0
    Dim nRDIva As Decimal = 0
    Dim nProcDG As Decimal = 0
    Dim nProcRD As Decimal = 0


    Private Sub frmAcepagoIVF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta l�nea de c�digo carga datos en la tabla 'GeneralDS.InstrumentoMonetario' Puede moverla o quitarla seg�n sea necesario.
        Me.InstrumentoMonetarioTableAdapter.Fill(Me.GeneralDS.InstrumentoMonetario)
        dtpFechaPago.Value = FECHA_APLICACION
        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daClientes As New SqlDataAdapter(cm1)
        Dim daBancos As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()
        Dim dsBcos As New DataSet()
        Dim drCliente As DataRow
        Dim drBanco As DataRow

        cCliente = txtCliente.Text
        ControlGastosEXT1.CargaXCliente(cCliente)
        If ControlGastosEXT1.Saldo > 0 Then
            btnContinuar.Enabled = False
        End If

        cFechaAplicacion = FECHA_APLICACION.ToShortDateString 'Now().ToShortDateString #ECT FECHA DE APLICACION
        ToolStripStatusLabel1.Text = "Fecha de Aplicaci�n " & cFechaAplicacion
        cFechaAplicacion = Mid(cFechaAplicacion, 7, 4) & Mid(cFechaAplicacion, 4, 2) & Mid(cFechaAplicacion, 1, 2)

        txtMontoPagado.Focus()

        Try

            ' El siguiente Stored Procedure trae todos los atributos de la tabla Clientes, para un cliente dado.

            With cm1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "DatosClie1"
                .Connection = cnAgil
                .Parameters.Add("@Cliente", SqlDbType.NVarChar)
                .Parameters(0).Value = cCliente
            End With

            ' Este Stored Procedure regresa los datos de los Bancos

            With cm2
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Bancos1"
                .Connection = cnAgil
            End With

            ' Llenar el DataSet lo cual abre y cierra la conexi�n

            daClientes.Fill(dsAgil, "Clientes")
            daBancos.Fill(dsBcos, "Bancos")

            drCliente = dsAgil.Tables("Clientes").Rows(0)

            Me.Text = "Recepci�n de Pagos de " & Trim(drCliente("Descr"))

            ' Traigo la Sucursal y la Tasa de IVA que aplica al cliente a efecto de poder determinar la Serie a utilizar

            cSucursal = drCliente("Sucursal")
            nTasaIvaCliente = drCliente("TasaIVACliente")

            If cSucursal = "04" Or nTasaIvaCliente = 11 Then
                cSerie = "MXL"
            Else
                cSerie = "A"
            End If

            ' Lleno cbBancos con el nombre de los Bancos

            cbBancos.DataSource = dsBcos
            cbBancos.DisplayMember = "Bancos.DescBanco"
            cbBancos.ValueMember = "Bancos.Banco"

            cbBancos.SelectedIndex = 0

        Catch eException As Exception

            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje")

        End Try

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()

    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click

        ' Declaraci�n de variables de conexi�n ADO .NET
        Dim ta As New GeneralDSTableAdapters.QueryVariosTableAdapter
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim cm5 As New SqlCommand()
        Dim cm6 As New SqlCommand()
        Dim cm7 As New SqlCommand()
        Dim daFacturas As New SqlDataAdapter(cm1)
        Dim daAnexos As New SqlDataAdapter(cm2)
        Dim daPagosIniciales As New SqlDataAdapter(cm3)
        Dim daUdis As New SqlDataAdapter(cm4)
        Dim daOpciones As New SqlDataAdapter(cm5)
        Dim daSeries As New SqlDataAdapter(cm6)
        Dim dsAgil As New DataSet()
        Dim dtTemporal As New DataTable("Temporal")
        Dim dtAdeudos As New DataTable("Adeudos")
        Dim dvTemporal As DataView
        Dim drTemporal As DataRow
        Dim drSaldo As DataRow
        Dim drAnexos As DataRowCollection
        Dim drAnexo As DataRow
        Dim drUdis As DataRowCollection
        Dim drOpcion As DataRow
        Dim drSerie As DataRow
        Dim myColArray(1) As DataColumn

        ' Declaraci�n de variables de datos

        Dim cAnexo As String
        Dim cFechacon As String
        Dim cFepag As String
        Dim cFeven As String
        Dim cFondeo As String
        Dim cTermina As String
        Dim cTipar As String
        Dim cTipo As String
        Dim dTermina As Date
        Dim lDatosCorrectos As Boolean
        Dim nAmorin As Decimal
        Dim nCounter As Integer
        Dim nDiasMoratorios As Decimal
        Dim nImpEq As Decimal
        Dim nIvaEq As Decimal
        Dim nIvaMoratorios As Decimal
        Dim nMoratorios As Decimal
        Dim nPagosIniciales As Decimal
        Dim nSaldo As Decimal
        Dim nSaldoTotal As Decimal
        Dim nTasaMoratoria As Decimal
        Dim nFegaPagado As Decimal
        Dim nIDGarantia As Decimal

        cFechaPago = DTOC(dtpFechaPago.Value)

        ' Primero creo la tabla Movimientos que contendr� los registros contables de la cobranza

        dtMovimientos.Columns.Add("Anexo", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("Letra", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("Tipos", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("Fepag", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("Cve", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("Imp", Type.GetType("System.Decimal"))
        dtMovimientos.Columns.Add("Tip", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("Catal", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("Esp", Type.GetType("System.Decimal"))
        dtMovimientos.Columns.Add("Coa", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("Tipmon", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("Banco", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("Concepto", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("Factura", Type.GetType("System.String"))

        ' Luego creo dos tablas necesarias para ir guardando los adeudos

        dtTemporal.Columns.Add("Concepto", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Contrato", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Letra", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Vencimiento", Type.GetType("System.String"))
        dtTemporal.Columns.Add("UltimoPago", Type.GetType("System.String"))
        dtTemporal.Columns.Add("DiasMoratorios", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("Saldo", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("Moratorios", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("IvaMoratorios", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("SaldoTotal", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("Fega", Type.GetType("System.Decimal"))
        dtTemporal.Clear()

        dtAdeudos.Columns.Add("Concepto", Type.GetType("System.String"))
        dtAdeudos.Columns.Add("Contrato", Type.GetType("System.String"))
        dtAdeudos.Columns.Add("Letra", Type.GetType("System.String"))
        dtAdeudos.Columns.Add("Vencimiento", Type.GetType("System.String"))
        dtAdeudos.Columns.Add("UltimoPago", Type.GetType("System.String"))
        dtAdeudos.Columns.Add("DiasMoratorios", Type.GetType("System.Decimal"))
        dtAdeudos.Columns.Add("Saldo", Type.GetType("System.Decimal"))
        dtAdeudos.Columns.Add("Moratorios", Type.GetType("System.Decimal"))
        dtAdeudos.Columns.Add("IvaMoratorios", Type.GetType("System.Decimal"))
        dtAdeudos.Columns.Add("SaldoTotal", Type.GetType("System.Decimal"))
        dtAdeudos.Columns.Add("Fega", Type.GetType("System.Decimal"))
        dtAdeudos.Clear()

        lvSaldos.View = View.Details
        lvSaldos.Activation = ItemActivation.TwoClick
        lvSaldos.MultiSelect = False
        lvSaldos.FullRowSelect = True
        lvSaldos.HeaderStyle = ColumnHeaderStyle.Nonclickable
        lvSaldos.BorderStyle = BorderStyle.FixedSingle
        lvSaldos.GridLines = True
        lvSaldos.Size = New Size(760, 158)
        lvSaldos.Columns.Add("Concepto", 60, HorizontalAlignment.Center)
        lvSaldos.Columns.Add("Contrato", 80, HorizontalAlignment.Center)
        lvSaldos.Columns.Add("Letra", 45, HorizontalAlignment.Center)
        lvSaldos.Columns.Add("Vencimiento", 80, HorizontalAlignment.Center)
        lvSaldos.Columns.Add("Ultimo Pago", 80, HorizontalAlignment.Center)
        lvSaldos.Columns.Add("Retraso", 55, HorizontalAlignment.Right)
        lvSaldos.Columns.Add("Saldo", 90, HorizontalAlignment.Right)
        lvSaldos.Columns.Add("Moratorios", 90, HorizontalAlignment.Right)
        lvSaldos.Columns.Add("IVA Moratorios", 90, HorizontalAlignment.Right)
        lvSaldos.Columns.Add("Saldo Total", 90, HorizontalAlignment.Right)
        lvSaldos.Columns.Add("Fega", 90, HorizontalAlignment.Right)

        lvPagos.View = View.Details
        lvPagos.Activation = ItemActivation.TwoClick
        lvPagos.MultiSelect = False
        lvPagos.FullRowSelect = True
        lvPagos.HeaderStyle = ColumnHeaderStyle.Nonclickable
        lvPagos.BorderStyle = BorderStyle.FixedSingle
        lvPagos.GridLines = True
        lvPagos.Size = New Size(760, 158)
        lvPagos.Columns.Add("Concepto", 60, HorizontalAlignment.Center)
        lvPagos.Columns.Add("Contrato", 80, HorizontalAlignment.Center)
        lvPagos.Columns.Add("Letra", 45, HorizontalAlignment.Center)
        lvPagos.Columns.Add("Vencimiento", 80, HorizontalAlignment.Center)
        lvPagos.Columns.Add("Ultimo Pago", 80, HorizontalAlignment.Center)
        lvPagos.Columns.Add("Retraso", 55, HorizontalAlignment.Right)
        lvPagos.Columns.Add("Saldo", 90, HorizontalAlignment.Right)
        lvPagos.Columns.Add("Moratorios", 90, HorizontalAlignment.Right)
        lvPagos.Columns.Add("IVA Moratorios", 90, HorizontalAlignment.Right)
        lvPagos.Columns.Add("Pago Total", 90, HorizontalAlignment.Right)

        lvSaldos.Items.Clear()
        lvPagos.Items.Clear()

        ' El siguiente Stored Procedure trae todos los contratos con saldo en facturas 
        ' correspondientes al cliente dado aun cuando la factura no sea exigible todav�a

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TraeAV1"
            .Connection = cnAgil
            .Parameters.Add("@Cliente", SqlDbType.NVarChar)
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters(0).Value = cCliente
            .Parameters(1).Value = "29990101"
        End With


        ' El siguiente Stored Procedure trae todos los contratos activos, terminados 
        ' o cancelados del cliente seleccionado a fin de determinar si cubri� o no 
        ' sus pagos iniciales

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "PideAnex2"
            .Connection = cnAgil
            .Parameters.Add("@Cliente", SqlDbType.NVarChar)
            .Parameters(0).Value = cCliente
        End With

        ' Este Stored Procedure trae el n�mero de Anexo de los contratos
        ' que ya realizaron sus pagos iniciales, de un cliente determinado

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "PagosIni2"
            .Connection = cnAgil
            .Parameters.Add("@Cliente", SqlDbType.NVarChar)
            .Parameters(0).Value = cCliente
        End With

        ' Este Stored Procedure regresa todas las UDIS ordenadas por vigencia

        With cm4
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TraeUdis1"
            .Connection = cnAgil
        End With

        ' Este Stored Procedure trae las opciones de compra exigibles y no pagadas
        ' de un cliente determinado

        With cm5
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TraeOC1"
            .Connection = cnAgil
            .Parameters.Add("@Cliente", SqlDbType.NVarChar)
            .Parameters(0).Value = cCliente
        End With

        ' El siguiente Command trae los consecutivos de cada Serie

        With cm6
            .CommandType = CommandType.Text
            .CommandText = "SELECT IDSerieA, IDSerieMXL, IDBlanco FROM Llaves"
            .Connection = cnAgil
        End With

        Try

            ' Llenar el DataSet lo cual abre y cierra la conexi�n

            daFacturas.Fill(dsAgil, "Facturas")
            daAnexos.Fill(dsAgil, "Anexos")
            daPagosIniciales.Fill(dsAgil, "PagosIniciales")
            daUdis.Fill(dsAgil, "Udis")
            daOpciones.Fill(dsAgil, "Opciones")
            daSeries.Fill(dsAgil, "Series")

            ' Tengo que definir una llave primaria para la tabla de Pagos Iniciales 
            ' para que se acelere la b�squeda cuando revise si existe el pago inicial 
            ' de un contrato

            myColArray(0) = dsAgil.Tables("PagosIniciales").Columns("Anexo")
            dsAgil.Tables("PagosIniciales").PrimaryKey = myColArray

        Catch eException As Exception

            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

        ' Tengo que determinar cu�les contratos del cliente seleccionado no han cubierto
        ' sus PAGOS INICIALES y agregarlos a la tabla dtTemporal

        drAnexos = dsAgil.Tables("Anexos").Rows

        For Each drAnexo In drAnexos

            cAnexo = drAnexo("Anexo")

            If dsAgil.Tables("PagosIniciales").Rows.Find(cAnexo) Is Nothing Then

                ' Significa que NO se ha realizado el pago inicial de este contrato 
                ' por lo que tengo que a�adirlo al ListView lvSaldos

                cFondeo = drAnexo("Fondeo")
                cFechacon = drAnexo("Fechacon")
                nImpEq = drAnexo("ImpEq")
                nIvaEq = drAnexo("IvaEq")
                nAmorin = drAnexo("Amorin")
                nPagosIniciales = Round(drAnexo("ImpDG") + drAnexo("IvaDG") + drAnexo("ImpRD") + drAnexo("IvaRD") + drAnexo("Comis") + nAmorin + drAnexo("IvaAmorin") + drAnexo("Gastos") + drAnexo("IvaGastos") + drAnexo("DepNafin") + drAnexo("Derechos") + drAnexo("FondoReserva"), 2)
                If drAnexo("tipar") = "B" Then
                    If ta.FacturaLetra001(cAnexo) = 0 Then
                        Dim f As New frmGeneFact()
                        f.DateTimePicker1.Value = CTOD(ta.FechaLetra001(cAnexo))
                        f.CKcontrato.Checked = True
                        f.ContratoAux = cAnexo
                        f.btnProcesar_Click(Nothing, Nothing)
                        f.Dispose()
                        daFacturas.Fill(dsAgil, "Facturas")
                    End If
                End If

                ' Insertar un registro en la tabla dtTemporal
                If nPagosIniciales > 0 Then
                    drTemporal = dtTemporal.NewRow()
                    drTemporal("Concepto") = "PI"
                    drTemporal("Contrato") = Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4)
                    drTemporal("Letra") = "000"
                    drTemporal("Vencimiento") = cFechacon
                    drTemporal("UltimoPago") = "        "
                    drTemporal("DiasMoratorios") = DateDiff(DateInterval.Day, CTOD(cFechacon), CTOD(cFechaPago))
                    drTemporal("Saldo") = nPagosIniciales
                    drTemporal("Moratorios") = 0
                    drTemporal("IvaMoratorios") = 0
                    drTemporal("SaldoTotal") = nPagosIniciales
                    drTemporal("Fega") = 0
                    dtTemporal.Rows.Add(drTemporal)
                End If
            End If

        Next

        ' En drFacturas tengo los contratos del cliente seleccionado, siempre y cuando tengan SALDO EN FACTURAS, por lo que a�adir� elementos a la tabla dtTemporal por este concepto

        ' Tambi�n genero el DataRowCollection drUdis ya que necesito enviarlo como
        ' argumento a la funci�n CalcMora que calcula los moratorios ya que esta lo
        ' env�a a su vez a la funci�n CalcIvaU.

        drUdis = dsAgil.Tables("Udis").Rows

        For Each drSaldo In dsAgil.Tables("Facturas").Rows

            cTipar = drSaldo("Tipar")
            cTipo = drSaldo("Tipo")
            nSaldo = drSaldo("Saldo")
            nDiasMoratorios = 0
            nTasaMoratoria = drSaldo("TasaMoratoria")
            nMoratorios = 0
            nIvaMoratorios = 0
            cFeven = drSaldo("Feven")
            cFepag = drSaldo("Fepag")

            If Trim(cFepag) = "" Then
                nDiasMoratorios = DateDiff(DateInterval.Day, CTOD(cFeven), CTOD(cFechaPago))
            Else
                If cFeven >= cFepag Then
                    nDiasMoratorios = DateDiff(DateInterval.Day, CTOD(cFeven), CTOD(cFechaPago))
                Else
                    nDiasMoratorios = DateDiff(DateInterval.Day, CTOD(cFepag), CTOD(cFechaPago))
                End If
            End If
            If nDiasMoratorios < 0 Then
                nDiasMoratorios = 0
            End If

            If nDiasMoratorios > 0 Then
                CalcMora(cTipar, cTipo, cFechaPago, drUdis, nSaldo, nTasaMoratoria, nDiasMoratorios, nMoratorios, nIvaMoratorios, nTasaIvaCliente)
            End If

            nSaldoTotal = nSaldo + nMoratorios + nIvaMoratorios

            ' Insertar un registro en la tabla dtTemporal

            drTemporal = dtTemporal.NewRow()
            drTemporal("Concepto") = drSaldo("TipoMov")
            drTemporal("Contrato") = Mid(drSaldo("Anexo"), 1, 5) & "/" & Mid(drSaldo("Anexo"), 6, 4)
            drTemporal("Letra") = drSaldo("Letra")
            If Trim(drSaldo("Feven")) <> "" Then
                drTemporal("Vencimiento") = drSaldo("Feven")
            Else
                drTemporal("Vencimiento") = "        "
            End If
            If Trim(drSaldo("Fepag")) <> "" Then
                drTemporal("UltimoPago") = drSaldo("Fepag")
            Else
                drTemporal("UltimoPago") = "        "
            End If
            drTemporal("DiasMoratorios") = nDiasMoratorios
            drTemporal("Saldo") = nSaldo
            drTemporal("Moratorios") = nMoratorios
            drTemporal("IvaMoratorios") = nIvaMoratorios
            drTemporal("SaldoTotal") = nSaldoTotal
            drTemporal("Fega") = drSaldo("Fega")
            dtTemporal.Rows.Add(drTemporal)

        Next

        ' Por �ltimo, tengo que determinar cu�les contratos del cliente seleccionado adeudan OPCI�N DE COMPRA

        For Each drOpcion In dsAgil.Tables("Opciones").Rows

            dTermina = Termina(drOpcion("Anexo"))
            cTermina = DTOC(dTermina)

            If cTermina > cFechaPago Then
                nDiasMoratorios = 0
            Else
                nDiasMoratorios = DateDiff(DateInterval.Day, dTermina, CTOD(cFechaPago))
            End If

            ' Insertar un registro en la tabla dtTemporal

            drTemporal = dtTemporal.NewRow()
            drTemporal("Concepto") = "OC"
            drTemporal("Contrato") = Mid(drOpcion("Anexo"), 1, 5) & "/" & Mid(drOpcion("Anexo"), 6, 4)
            drTemporal("Letra") = Stuff(drOpcion("Letra"), "I", "0", 3)
            drTemporal("Vencimiento") = cTermina
            drTemporal("UltimoPago") = "        "
            drTemporal("DiasMoratorios") = nDiasMoratorios
            drTemporal("Saldo") = drOpcion("Saldo")
            drTemporal("Moratorios") = 0
            drTemporal("IvaMoratorios") = 0
            drTemporal("SaldoTotal") = drOpcion("Saldo")
            drTemporal("Fega") = 0
            dtTemporal.Rows.Add(drTemporal)

        Next

        ' Aqu� ya tengo todos los adeudos del cliente en la tabla dtTemporal por lo que procedo
        ' a ordenarla

        dvTemporal = New DataView(dtTemporal)
        dvTemporal = dtTemporal.DefaultView
        dvTemporal.Sort = "Vencimiento, Contrato"
        DataGrid1.DataSource = dtTemporal

        nCounter = dtTemporal.Rows.Count()

        For i = 0 To nCounter - 1
            drTemporal = dtAdeudos.NewRow()
            drTemporal("Concepto") = DataGrid1.Item(i, 0)
            drTemporal("Contrato") = DataGrid1.Item(i, 1)
            drTemporal("Letra") = DataGrid1.Item(i, 2)
            drTemporal("Vencimiento") = DataGrid1.Item(i, 3)
            drTemporal("UltimoPago") = DataGrid1.Item(i, 4)
            drTemporal("DiasMoratorios") = DataGrid1.Item(i, 5)
            drTemporal("Saldo") = DataGrid1.Item(i, 6)
            drTemporal("Moratorios") = DataGrid1.Item(i, 7)
            drTemporal("IvaMoratorios") = DataGrid1.Item(i, 8)
            drTemporal("SaldoTotal") = DataGrid1.Item(i, 9)
            drTemporal("Fega") = DataGrid1.Item(i, 10)
            dtAdeudos.Rows.Add(drTemporal)
        Next

        i = 0
        j = 0
        Dim taX As New ProductionDataSetTableAdapters.FIRArefaccionariosTableAdapter
        For Each drTemporal In dtAdeudos.Rows

            nIDGarantia = taX.ScalarIdGarantia(drTemporal("Contrato"))
            If nIDGarantia <> 0 Then
                LbGarantia.Visible = True
            End If

            lvSaldos.Items.Add(drTemporal("Concepto"))
            lvSaldos.Items(i).SubItems.Add(drTemporal("Contrato"))
            lvSaldos.Items(i).SubItems.Add(drTemporal("Letra"))
            lvSaldos.Items(i).SubItems.Add(Mid(drTemporal("Vencimiento"), 7, 2) & "/" & Mid(drTemporal("Vencimiento"), 5, 2) & "/" & Mid(drTemporal("Vencimiento"), 1, 4))
            If drTemporal("UltimoPago") <> "        " Then
                lvSaldos.Items(i).SubItems.Add(Mid(drTemporal("UltimoPago"), 7, 2) & "/" & Mid(drTemporal("UltimoPago"), 5, 2) & "/" & Mid(drTemporal("UltimoPago"), 1, 4))
            Else
                lvSaldos.Items(i).SubItems.Add(drTemporal("UltimoPago"))
            End If
            lvSaldos.Items(i).SubItems.Add(drTemporal("DiasMoratorios"))
            lvSaldos.Items(i).SubItems.Add(Format(drTemporal("Saldo"), "#,##0.00"))
            lvSaldos.Items(i).SubItems.Add(Format(drTemporal("Moratorios"), "#,##0.00"))
            lvSaldos.Items(i).SubItems.Add(Format(drTemporal("IvaMoratorios"), "#,##0.00"))
            lvSaldos.Items(i).SubItems.Add(Format(drTemporal("SaldoTotal"), "#,##0.00"))
            lvSaldos.Items(i).SubItems.Add(Format(drTemporal("Fega"), "#,##0.00"))
            i = i + 1
            If i > 9 Then
                lvSaldos.Width = 780
                lvSaldos.Height = 158
            End If
        Next

        ' Aqu� tengo que validar que se haya capturado informaci�n del monto pagado y del cheque

        lDatosCorrectos = True

        If txtCheque.Text = "" Then
            MsgBox("Falta capturar los datos del cheque", MsgBoxStyle.Critical, "Mensaje del Sistema")
            lDatosCorrectos = False
        End If

        If lDatosCorrectos = True Then

            lblSaldos.Visible = True
            lvSaldos.Visible = True

            lblPagos.Visible = True
            lvPagos.Visible = True

            btnAplicarPago.Visible = True

            nMontoPagado = CDec(txtMontoPagado.Text)
            txtMontoPagado.Enabled = False
            txtCheque.Enabled = False
            cbBancos.Enabled = False
            dtpFechaPago.Enabled = False
            btnContinuar.Visible = False
            CheckDG.Enabled = False
            CheckRD.Enabled = False

            ' Toma el n�mero consecutivo de facturas de pago -que depende de la Serie- y lo incrementa en uno

            drSerie = dsAgil.Tables("Series").Rows(0)
            'nIDSerieA = drSerie("IDSerieA")
            'nIDSerieMXL = drSerie("IDSerieMXL")
            'nIDBlanco = drSerie("IDBlanco")

            If cSerie = "A" Then
                txtSerieA.Text = drSerie("IDSerieA") + 1
                lblIDSerieA.Visible = True
                txtSerieA.Visible = True
            ElseIf cSerie = "MXL" Then
                txtSerieMXL.Text = drSerie("IDSerieMXL") + 1
                lblIDSerieMXL.Visible = True
                txtSerieMXL.Visible = True
            End If

            TxtIDBlanco.Text = drSerie("IDBlanco") + 1
            LbBlanco.Visible = True
            TxtIDBlanco.Visible = True
            CkAppBlanco.Visible = True
        End If

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
        cm4.Dispose()
        cm5.Dispose()
        cm6.Dispose()
        ta.Dispose()

    End Sub

    Private Sub lvSaldos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSaldos.DoubleClick

        ' Declaraci�n de variables de datos

        Dim cConcepto As String
        Dim lPagoSuficiente As Boolean
        Dim newfrmMoratorios As frmMoratorios
        Dim nIvaMoratorios As Decimal
        Dim nMoratorios As Decimal
        Dim nSaldo As Decimal
        Dim nSaldoTotal As Decimal
        Dim nTotalMoratorios As Decimal
        '#ECT new FEGA
        Dim cAnexo As String
        Dim cAnexoAUX As String
        Dim cLetra As String
        Dim cLetraMIN As String = "999"
        Dim nTotalFega As Decimal
        Dim nFegaPagado As Decimal
        Dim FegaPagado As New ProductionDataSetTableAdapters.HistoriaTableAdapter
        '#ECT new FEGA

        lPagoSuficiente = True

        cAnexo = lvSaldos.Items(lvSaldos.SelectedIndices(0)).SubItems(1).Text
        cAnexo = Mid(cAnexo, 1, 5) & Mid(cAnexo, 7, 4)
        cConcepto = lvSaldos.Items(lvSaldos.SelectedIndices(0)).Text
        nSaldo = CDec(lvSaldos.Items(lvSaldos.SelectedIndices(0)).SubItems(6).Text)
        nMoratorios = CDec(lvSaldos.Items(lvSaldos.SelectedIndices(0)).SubItems(7).Text)
        nIvaMoratorios = CDec(lvSaldos.Items(lvSaldos.SelectedIndices(0)).SubItems(8).Text)
        nTotalMoratorios = Round(nMoratorios + nIvaMoratorios, 2)

        '**************VALIDA QUE SEA EL ADEUDO MAS ANTIGUO

        For x As Integer = 0 To lvSaldos.Items.Count - 1
            cAnexoAUX = lvSaldos.Items(x).SubItems(1).Text
            cAnexoAUX = Mid(cAnexoAUX, 1, 5) & Mid(cAnexoAUX, 7, 4)
            cLetra = lvSaldos.Items(x).SubItems(2).Text
            If CDbl(cLetraMIN) >= CDbl(cLetra) And cAnexo = cAnexoAUX Then
                cLetraMIN = cLetra
            End If
        Next
        cLetra = lvSaldos.Items(lvSaldos.SelectedIndices(0)).SubItems(2).Text
        If CDbl(cLetra) > CDbl(cLetraMIN) Then
            MessageBox.Show("Existen adeudos del contrato " & cAnexo & " con mas antig�edad. Favor de aplicar en ese orden.", "Error de Pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lPagoSuficiente = False
        End If
        '**************VALIDA QUE SEA EL ADEUDO MAS ANTIGUO

        '#ECT Para aplicar DG***********************************************************
        If CheckDG.Checked = True Then
            If cAnexoDG = "" Then
                cAnexoDG = cAnexo
                nDG = TaQUERY.SacaDG(cAnexo)
                nDGIva = TaQUERY.SacaIvaDG(cAnexo)
                txtMontoPagado.Text = nDG + nDGIva
                nMontoPagado = nDG + nDGIva
            End If
            If cAnexoDG <> cAnexo Then
                MsgBox("Para aplicar DG solo pueden ser movimientos del mismo contrato", MsgBoxStyle.Critical, "Mensaje del Sistema")
                lPagoSuficiente = False
            Else
                nTotalDG += Round(nSaldo + nMoratorios + nIvaMoratorios, 2)
            End If
        End If
        If CheckRD.Checked = True Then
            If cAnexoRD = "" Then
                cAnexoRD = cAnexo
                nRD = TaQUERY.SacaRD(cAnexo)
                nRDIva = TaQUERY.SacaIvaRD(cAnexo)
                txtMontoPagado.Text = nRD + nRDIva
                nMontoPagado = nRD + nRDIva
            End If
            If cAnexoRD <> cAnexo Then
                MsgBox("Para aplicar RD solo pueden ser movimientos del mismo contrato", MsgBoxStyle.Critical, "Mensaje del Sistema")
                lPagoSuficiente = False
            Else
                nTotalRD += Round(nSaldo + nMoratorios + nIvaMoratorios, 2)
            End If
        End If
        '#ECT Para aplicar DG***********************************************************

        '#ECT new fega******************************************************************
        cLetra = lvSaldos.Items(lvSaldos.SelectedIndices(0)).SubItems(2).Text
        nFegaPagado = FegaPagado.FegaPagado(cAnexo, cLetra)
        nTotalFega = CDec(lvSaldos.Items(lvSaldos.SelectedIndices(0)).SubItems(10).Text)
        nTotalFega = nTotalFega - nFegaPagado
        If nTotalFega < 0 Then nTotalFega = 0
        nTotalFega = 0 '#ECT para activar bloqueo por no cubrir el fega se comenta esta linea
        '#ECT new fega******************************************************************

        If nTotalMoratorios > 0 And lPagoSuficiente = True Then
            newfrmMoratorios = New frmMoratorios(nTotalMoratorios)
            newfrmMoratorios.ShowDialog()
            nTotalMoratorios = newfrmMoratorios.Moratorios()
            nMoratorios = Round(nTotalMoratorios * (nMoratorios / (nMoratorios + nIvaMoratorios)), 2)
            nIvaMoratorios = Round(nTotalMoratorios - nMoratorios, 2)
        End If

        ' El �nico concepto que genera moratorios es AV (Aviso de Vencimiento)
        ' por lo que para PI (Pago Inicial) y OC (Opci�n de Compra) tengo que validar que
        ' se cubra totalmente el concepto ya que no se aceptan pagos a cuenta.

        If cConcepto = "PI" Or cConcepto = "OC" Then
            If nMontoPagado < nSaldo Then
                If cConcepto = "PI" Then
                    MsgBox("El importe del pago no alcanza a cubrir el Pago Inicial", MsgBoxStyle.Critical, "Mensaje del Sistema")
                Else
                    MsgBox("El importe del pago no alcanza a cubrir la Opci�n de Compra", MsgBoxStyle.Critical, "Mensaje del Sistema")
                End If
                lPagoSuficiente = False
            End If
        ElseIf cConcepto = "AV" Then
            If nMontoPagado < nTotalMoratorios + nTotalFega Then
                MsgBox("El importe del pago no alcanza a cubrir los moratorios y/o garantia FEGA")
                lPagoSuficiente = False
            End If
        End If



        If lPagoSuficiente = True Then

            nMontoPagado = Round(nMontoPagado - nTotalMoratorios, 2)
            If nMontoPagado > 0 Then

                ' Significa que todav�a hay un importe por aplicar, el cual se va a disminuir
                ' el adeudo principal

                If nMontoPagado >= nSaldo Then

                    ' El monto pagado cubre totalmente el adeudo principal por lo que tengo
                    ' que restar el adeudo principal del monto pagado

                    nMontoPagado = Round(nMontoPagado - nSaldo, 2)

                Else

                    ' El monto pagado no alcanza a cubrir totalmente el adeudo principal por lo que
                    ' solo se aplica el monto pagado y �ste se queda en cero

                    nSaldo = nMontoPagado
                    nMontoPagado = 0

                End If

            Else

                nSaldo = 0

            End If

            txtMontoPagado.Text = nMontoPagado.ToString
            nSaldoTotal = Round(nSaldo + nMoratorios + nIvaMoratorios, 2)

            lvPagos.Items.Add(cConcepto)
            lvPagos.Items(j).SubItems.Add(lvSaldos.Items(lvSaldos.SelectedIndices(0)).SubItems(1).Text)
            lvPagos.Items(j).SubItems.Add(lvSaldos.Items(lvSaldos.SelectedIndices(0)).SubItems(2).Text)
            lvPagos.Items(j).SubItems.Add(lvSaldos.Items(lvSaldos.SelectedIndices(0)).SubItems(3).Text)
            lvPagos.Items(j).SubItems.Add(lvSaldos.Items(lvSaldos.SelectedIndices(0)).SubItems(4).Text)
            lvPagos.Items(j).SubItems.Add(lvSaldos.Items(lvSaldos.SelectedIndices(0)).SubItems(5).Text)
            lvPagos.Items(j).SubItems.Add(nSaldo.ToString)
            lvPagos.Items(j).SubItems.Add(nMoratorios.ToString)
            lvPagos.Items(j).SubItems.Add(nIvaMoratorios.ToString)
            lvPagos.Items(j).SubItems.Add(nSaldoTotal.ToString)

            j = j + 1
            lvSaldos.Items.RemoveAt(lvSaldos.SelectedIndices(0))
            i = i - 1

        End If

    End Sub

    Private Sub btnAplicarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicarPago.Click

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim strUpdate As String = ""

        ' Declaraci�n de variables de datos

        Dim cAnexo As String
        Dim cBanco As String
        Dim cCheque As String
        Dim cLetra As String
        Dim cTipoMov As String
        Dim nIvaMoratorios As Decimal
        Dim nMontoPago As Decimal
        Dim nMoratorios As Decimal
        Dim nPago As Integer
        Dim nRecibo As Decimal = 0
        Dim ta As New ContaDSTableAdapters.PagosInicialesTableAdapter

        ''If cSerie = "A" Then
        ''    'nIDSerieA = CInt(txtSerieA.Text)
        ''    'nIDSerieA = nIDSerieA - 1
        ''    'nRecibo = nIDSerieA
        ''ElseIf cSerie = "MXL" Then
        ''    nIDSerieMXL = CInt(txtSerieMXL.Text)
        ''    nIDSerieMXL = nIDSerieMXL - 1
        ''    nRecibo = nIDSerieMXL
        ''End If

        If CkAppBlanco.Checked = True Then
            cSerie = "AB"
        End If

        If j > 0 Then

            ' Significa que existe por lo menos un pago por aplicar

            btnAplicarPago.Enabled = False

            cBanco = cbBancos.SelectedValue.ToString()
            cCheque = txtCheque.Text

            For nPago = 0 To j - 1

                cTipoMov = lvPagos.Items(nPago).Text

                cAnexo = Mid(lvPagos.Items(nPago).SubItems(1).Text, 1, 5) & Mid(lvPagos.Items(nPago).SubItems(1).Text, 7, 4)
                cLetra = lvPagos.Items(nPago).SubItems(2).Text
                nMoratorios = lvPagos.Items(nPago).SubItems(7).Text
                nIvaMoratorios = lvPagos.Items(nPago).SubItems(8).Text
                nMontoPago = lvPagos.Items(nPago).SubItems(9).Text

                Select Case cTipoMov

                    Case "PI" 'Pago inicial

                        nRecibo += 1
                        Acepagoi(cAnexo, cLetra, nMontoPago, cBanco, cCheque, dtMovimientos, cFechaAplicacion, cSerie, nRecibo, nTasaIvaCliente, CmbInstruMon.SelectedValue, TaQUERY.SacaInstrumemtoMoneSAT(CmbInstruMon.SelectedValue))
                        If Trim(ta.EstaActivado(cAnexo)) = "" Then
                            ta.Insert(cAnexo, cFechaAplicacion, False)
                        End If


                    Case "AV" ' Vencimiento

                        nRecibo += 1
                        Acepagov(cAnexo, cLetra, nMontoPago, nMoratorios, nIvaMoratorios, cBanco, cCheque, dtMovimientos, cFechaAplicacion, cFechaPago, cSerie, nRecibo, CmbInstruMon.SelectedValue, "PAGO", TaQUERY.SacaInstrumemtoMoneSAT(CmbInstruMon.SelectedValue))

                    Case "OC" ' opcion a compra

                        Acepagof(cAnexo, cLetra, nMontoPago, cBanco, cCheque, dtMovimientos, cFechaAplicacion, nTasaIvaCliente, CmbInstruMon.SelectedValue)

                End Select

            Next

            ' Debe actualizar el atributo IDSerieA � el atributo IDSerieMXL de la tabla Llaves
            '#ECT Para aplicar DG***********************************************************
            Dim tasa As Decimal = 0
            If CheckDG.Checked = True And nTotalDG > 0 Then
                tasa = nDGIva / nDG
                nDG = nDG + nDGIva - nTotalDG
                nDGIva = nDG * tasa
                nDG = nDG - nDGIva
                Dim BLOQ As Integer = DesBloqueaContrato(cAnexo) 'DESBLOQUEO MESA DE CONTROL+++++++++++++
                TaQUERY.CambiaDG(nDG, nDGIva, cAnexo)
                BloqueaContrato(cAnexo, BLOQ) '*******************BLOQUEO MESA DE CONTROL++++++++++++++++
            End If
            If CheckRD.Checked = True And nTotalRD > 0 Then
                tasa = nRDIva / nRD
                nRD = nRD + nRDIva - nTotalRD
                nRDIva = nRD * tasa
                nRD = nRD - nRDIva
                Dim BLOQ As Integer = DesBloqueaContrato(cAnexo) 'DESBLOQUEO MESA DE CONTROL+++++++++++++
                TaQUERY.CambiaRD(nRD, nRDIva, cAnexo)
                BloqueaContrato(cAnexo, BLOQ) '*******************BLOQUEO MESA DE CONTROL++++++++++++++++
            End If
            '#ECT Para aplicar DG***********************************************************


            'If CkAppBlanco.Checked = True Then
            '    strUpdate = "UPDATE Llaves SET IDBlanco = " & nRecibo
            'ElseIf cSerie = "A" Then
            '    strUpdate = "UPDATE Llaves SET IDSerieA = " & nRecibo
            'ElseIf cSerie = "MXL" Then
            '    strUpdate = "UPDATE Llaves SET IDSerieMXL = " & nRecibo
            'ElseIf cSerie = "REP" Then
            '    strUpdate = "UPDATE Llaves SET CFDI_Pago = " & nRecibo
            'End If

            'cm1 = New SqlCommand(strUpdate, cnAgil)
            'cnAgil.Open()
            'cm1.ExecuteNonQuery()
            'cnAgil.Close()

            cnAgil.Dispose()
            cm1.Dispose()

            ' En este punto llamo a la funci�n Ingresos para afectar la tabla Hisgin

            Ingresos(dtMovimientos)

            Me.Close()

        End If

    End Sub

    Private Sub txtMontoPagado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoPagado.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtMontoPagado.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CheckRD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckRD.CheckedChanged
        If CheckRD.Checked = True Then
            CheckDG.Checked = False
        End If
    End Sub

    Private Sub CheckDG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckDG.CheckedChanged
        If CheckDG.Checked = True Then
            CheckRD.Checked = False
        End If
    End Sub

    Private Sub CkAppBlanco_CheckedChanged(sender As Object, e As EventArgs) Handles CkAppBlanco.CheckedChanged

    End Sub
End Class
