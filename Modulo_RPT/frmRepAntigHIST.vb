' Este reporte no debe considerar los avisos que tengan fecha de vencimiento igual a la fecha de proceso;
' sin embargo, para la contabilidad sí deben considerarse como exigibles dichos avisos.

Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports CrystalDecisions.Shared

Public Class frmRepAntigHIST

    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblPromotores As System.Windows.Forms.Label
    Friend WithEvents cbPromotores As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkConsiderarDia As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeguimiento As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AviosDSX1 As Agil.AviosDSX
    Friend WithEvents CmbDB As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lblPromotores = New System.Windows.Forms.Label()
        Me.cbPromotores = New System.Windows.Forms.ComboBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkConsiderarDia = New System.Windows.Forms.CheckBox()
        Me.chkSeguimiento = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AviosDSX1 = New Agil.AviosDSX()
        Me.CmbDB = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.AviosDSX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(944, 28)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(80, 24)
        Me.btnProcesar.TabIndex = 21
        Me.btnProcesar.Text = "Procesar"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(406, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Fecha de Proceso"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(409, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 19
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 61)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1238, 581)
        Me.CrystalReportViewer1.TabIndex = 22
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'lblPromotores
        '
        Me.lblPromotores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromotores.Location = New System.Drawing.Point(143, 9)
        Me.lblPromotores.Name = "lblPromotores"
        Me.lblPromotores.Size = New System.Drawing.Size(71, 16)
        Me.lblPromotores.TabIndex = 23
        Me.lblPromotores.Text = "Reporte de "
        Me.lblPromotores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbPromotores
        '
        Me.cbPromotores.Location = New System.Drawing.Point(139, 29)
        Me.cbPromotores.Name = "cbPromotores"
        Me.cbPromotores.Size = New System.Drawing.Size(264, 21)
        Me.cbPromotores.TabIndex = 24
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1030, 28)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 24)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(707, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Considerar este día como vencido?"
        '
        'chkConsiderarDia
        '
        Me.chkConsiderarDia.AutoSize = True
        Me.chkConsiderarDia.Location = New System.Drawing.Point(918, 34)
        Me.chkConsiderarDia.Name = "chkConsiderarDia"
        Me.chkConsiderarDia.Size = New System.Drawing.Size(15, 14)
        Me.chkConsiderarDia.TabIndex = 27
        Me.chkConsiderarDia.UseVisualStyleBackColor = True
        '
        'chkSeguimiento
        '
        Me.chkSeguimiento.AutoSize = True
        Me.chkSeguimiento.Location = New System.Drawing.Point(681, 34)
        Me.chkSeguimiento.Name = "chkSeguimiento"
        Me.chkSeguimiento.Size = New System.Drawing.Size(15, 14)
        Me.chkSeguimiento.TabIndex = 29
        Me.chkSeguimiento.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(520, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Reporte con Seguimiento?"
        '
        'AviosDSX1
        '
        Me.AviosDSX1.DataSetName = "AviosDSX"
        Me.AviosDSX1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbDB
        '
        Me.CmbDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDB.FormattingEnabled = True
        Me.CmbDB.Location = New System.Drawing.Point(12, 29)
        Me.CmbDB.Name = "CmbDB"
        Me.CmbDB.Size = New System.Drawing.Size(121, 21)
        Me.CmbDB.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Mes"
        '
        'frmRepAntigHIST
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1238, 642)
        Me.Controls.Add(Me.CmbDB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkSeguimiento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkConsiderarDia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblPromotores)
        Me.Controls.Add(Me.cbPromotores)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmRepAntigHIST"
        Me.Text = "Antigüedad de Saldos"
        CType(Me.AviosDSX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmRepAntig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim t As New DataTable
        Dim r As DataRow
        t.Columns.Add("ID")
        t.Columns.Add("TIT")
        Dim Fecha As Date = Date.Now
        For x As Integer = 0 To 11
            Fecha = Fecha.AddDays(-1 * Fecha.Day)
            If Fecha >= "01/01/2016" Then
                r = t.NewRow
                r("ID") = Fecha.ToString("yyyyMMdd")
                r("TIT") = Mid(Fecha.ToString("yyyyMMM").ToUpper, 1, 7)
                t.Rows.Add(r)
            End If
        Next
        CmbDB.DataSource = t
        CmbDB.DisplayMember = t.Columns("TIT").ToString
        CmbDB.ValueMember = t.Columns("ID").ToString
        CmbDB.SelectedIndex = 0
        DateTimePicker1.Value = CTOD(CmbDB.SelectedValue)

        CmbDB_SelectedIndexChanged(Nothing, Nothing)

    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Dim cFecha As String
        cFecha = DTOC(DateTimePicker1.Value)

        If cbPromotores.SelectedIndex = 7 Then 'Reporte de Antiguedad de Avio
            Dim ta As New AviosDSXTableAdapters.SaldosAvioTableAdapter
            Dim r As AviosDSX.SaldosAvioRow
            ta.Fill(AviosDSX1.Tables("SaldosAvio"), DateTimePicker1.Value.ToString("yyyyMMdd"))
            For Each r In AviosDSX1.Tables("SaldosAvio").Rows
                r.Dias = DateDiff(DateInterval.Day, CTOD(r.FechaTerminacion), DateTimePicker1.Value)
                Select Case r.Dias
                    Case Is < 30
                        r._1_29 = r.Saldo
                    Case Is < 60
                        r._30_59 = r.Saldo
                    Case Is < 90
                        r._60_89 = r.Saldo
                    Case Else
                        r._90_ = r.Saldo
                End Select
                If r.InteresMensual = "SI" Then

                End If
            Next
            Dim newrptRepAntigAvio As New rptRepAntiAvio
            newrptRepAntigAvio.SetDataSource(AviosDSX1)
            newrptRepAntigAvio.SummaryInfo.ReportTitle = "REPORTE DE ANTIGÜEDAD DE SALDOS DE CREDITOS DE AVÍO AL " & Mes(cFecha)
            CrystalReportViewer1.ReportSource = newrptRepAntigAvio
        Else

            ' Declaración de variables de conexión ADO .NET

            Dim cnAgil As New SqlConnection("Server=" & My.Settings.ServidorBACK & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015")
            Dim cm1 As New SqlCommand()
            Dim cm2 As New SqlCommand()
            Dim cm3 As New SqlCommand()
            Dim cm4 As New SqlCommand()
            Dim cm5 As New SqlCommand()
            Dim cm6 As New SqlCommand()
            Dim dsAgil As New DataSet()
            Dim daFacturas As New SqlDataAdapter(cm1)
            Dim daPagosIniciales As New SqlDataAdapter(cm2)
            Dim daOpciones As New SqlDataAdapter(cm3)
            Dim daAnexos As New SqlDataAdapter(cm4)
            Dim daReestructurados As New SqlDataAdapter(cm5)
            Dim daSeguimientos As New SqlDataAdapter(cm6)
            Dim drFactura As DataRow
            Dim drAnexo As DataRow
            Dim drSeguimiento As DataRow
            Dim dvClientes As DataView
            Dim dvAnexos As DataView
            Dim myColArray(1) As DataColumn
            Dim dtClientes As New DataTable()
            Dim dtAnexos As New DataTable()
            Dim dtReporte As New DataTable("Reporte")
            Dim drCliente As DataRow
            Dim drReporte As DataRow

            ' Declaración de variables de datos

            Dim cAnexo As String
            Dim cDigito As String
            Dim cCliente As String
            Dim cFechaLlamada As String = ""
            Dim cFechaSeguimiento As String = ""    ' Es la fecha a partir de la cual el sistema va a contar el número de gestiones de cobranza que se hubieran realizado
            Dim cGestor As String
            Dim cInicialesPromotor As String = ""
            Dim cLetra As String
            Dim cNombre As String
            Dim cPromotor As String
            Dim cSeguimiento As String = ""
            Dim cSucursal As String
            Dim cVencida As String = ""
            Dim cFechaPago As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim nAnexos As Integer = 0
            Dim nClientes As Integer = 0
            Dim nDiasVencido As Integer = 0
            Dim nGestion As Integer = 0
            Dim nPlazo As Byte
            Dim nSaldoFac As Decimal
            Dim nSaldoInsoluto As Decimal
            Dim cConvenioJUR As String

            ' Declaración de variables de Crystal Reports

            Dim newrptRepAntig1 As rptRepAnti3
            Dim newrptRepAntig2 As rptRepantig

            Dim cReportTitle As String
            Dim cReportComments As String


            ' Primero creo la tabla Clientes que me dará el orden del reporte, acumulando saldos por cliente

            dtClientes.Columns.Add("Cliente", Type.GetType("System.String"))
            dtClientes.Columns.Add("Col1a29", Type.GetType("System.Decimal"))
            dtClientes.Columns.Add("Col30a59", Type.GetType("System.Decimal"))
            dtClientes.Columns.Add("Col60a89", Type.GetType("System.Decimal"))
            dtClientes.Columns.Add("Col90omas", Type.GetType("System.Decimal"))
            dtClientes.Columns.Add("Promotor", Type.GetType("System.String"))
            dtClientes.Columns.Add("InicialesPromotor", Type.GetType("System.String"))
            dtClientes.Columns.Add("Gestor", Type.GetType("System.String"))
            dtClientes.Columns.Add("Sucursal", Type.GetType("System.String"))
            dtClientes.Columns.Add("Retraso", Type.GetType("System.Decimal"))           ' Guardo el máximo retraso del Cliente
            dtClientes.Columns.Add("PoN", Type.GetType("System.String"))
            dtClientes.Columns.Add("ConvenioJUR", Type.GetType("System.String"))
            myColArray(0) = dtClientes.Columns("Cliente")
            dtClientes.PrimaryKey = myColArray

            ' Ahora creo la tabla Anexos que será la base del reporte

            dtAnexos.Columns.Add("Anexo", Type.GetType("System.String"))
            dtAnexos.Columns.Add("Cliente", Type.GetType("System.String"))
            dtAnexos.Columns.Add("Nombre", Type.GetType("System.String"))
            dtAnexos.Columns.Add("Letra", Type.GetType("System.String"))
            dtAnexos.Columns.Add("Plazo", Type.GetType("System.Decimal"))
            dtAnexos.Columns.Add("Dia", Type.GetType("System.Decimal"))
            dtAnexos.Columns.Add("Saldo", Type.GetType("System.Decimal"))
            dtAnexos.Columns.Add("Col1a29", Type.GetType("System.Decimal"))
            dtAnexos.Columns.Add("Col30a59", Type.GetType("System.Decimal"))
            dtAnexos.Columns.Add("Col60a89", Type.GetType("System.Decimal"))
            dtAnexos.Columns.Add("Col90omas", Type.GetType("System.Decimal"))
            dtAnexos.Columns.Add("Total", Type.GetType("System.Decimal"))
            dtAnexos.Columns.Add("Retraso", Type.GetType("System.Decimal"))             ' Guardo el máximo retraso del Anexo
            dtAnexos.Columns.Add("Reestructura", Type.GetType("System.String"))
            dtAnexos.Columns.Add("PI", Type.GetType("System.Decimal"))
            dtAnexos.Columns.Add("OC", Type.GetType("System.Decimal"))
            dtAnexos.Columns.Add("Recursos", Type.GetType("System.String"))
            dtAnexos.Columns.Add("InicialesPromotor", Type.GetType("System.String"))
            dtAnexos.Columns.Add("Gestion", Type.GetType("System.Decimal"))
            dtAnexos.Columns.Add("Seguimiento", Type.GetType("System.String"))
            dtAnexos.Columns.Add("FechaLlamada", Type.GetType("System.String"))
            dtAnexos.Columns.Add("Vencida", Type.GetType("System.String"))
            dtAnexos.Columns.Add("FechaPago", Type.GetType("System.String"))
            dtAnexos.Columns.Add("ConvenioJUR", Type.GetType("System.String"))
            myColArray(0) = dtAnexos.Columns("Anexo")
            dtAnexos.PrimaryKey = myColArray

            dtReporte = dtAnexos.Clone

            ' Este Stored Procedure trae las facturas vencidas, el pago inicial (sin el 5% Nafin) 
            ' y la opción de compra exigible de los contratos activos o terminados con saldo en rentas

            With cm1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Repantig1"
                .Connection = cnAgil
                .Parameters.Add("@Fecha", SqlDbType.NVarChar)
                .Parameters(0).Value = cFecha
            End With

            ' Este Stored Procedure regresa los contratos activos, terminados o cancelados 
            ' que ya cubrieron su pago inicial

            With cm2
                .CommandType = CommandType.StoredProcedure
                .CommandText = "PagosIni1"
                .Connection = cnAgil
            End With

            ' Este Stored Procedure regresa todas las opciones de compra exigibles y no pagadas

            With cm3
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Repantig3"
                .Connection = cnAgil
            End With

            ' Este Stored Procedure regresa todas los contratos activos con fecha de contratación menor o igual
            ' a la fecha del reporte.   Esto me servirá para posteriormente verificar cuáles de estos contratos
            ' NO han cubierto sus pagos iniciales

            With cm4
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Repantig4"
                .Connection = cnAgil
                .Parameters.Add("@Fecha", SqlDbType.NVarChar)
                .Parameters(0).Value = cFecha
            End With

            ' Este Stored Procedure regresa el número de los anexos activos o terminados que han tenido
            ' reestructura por capitalización de adeudo

            With cm5
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Repantig5"
                .Connection = cnAgil
            End With

            ' El siguiente Command trae el seguimiento de los 30 días anteriores a la fecha del reporte y hasta la fecha del reporte

            cFechaSeguimiento = DTOC(DateAdd(DateInterval.Day, -30, CTOD(cFecha)))

            ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

            Try
                daFacturas.Fill(dsAgil, "Facturas")
                daAnexos.Fill(dsAgil, "Anexos")
                daPagosIniciales.Fill(dsAgil, "PagosIniciales")
                daOpciones.Fill(dsAgil, "Opciones")
                daReestructurados.Fill(dsAgil, "Reestructurados")

            Catch eException As Exception
                MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
            End Try

            ' Tengo que definir una llave primaria para la tabla de Pagos Iniciales para que se acelere la búsqueda
            ' cuando revise si existe el pago inicial de un contrato

            myColArray(0) = dsAgil.Tables("PagosIniciales").Columns("Anexo")
            dsAgil.Tables("PagosIniciales").PrimaryKey = myColArray

            ' En una sola barrida a la tabla Facturas voy a determinar la antigüedad por Cliente y por Anexo

            For Each drFactura In dsAgil.Tables("Facturas").Rows

                cDigito = IIf(Pow(-1, Val(Mid(drFactura("Cliente"), 5, 1))) > 0, "P", "N")
                cCliente = drFactura("Cliente")
                cNombre = drFactura("Descr")
                cAnexo = drFactura("Anexo")
                cLetra = drFactura("Letra")
                nPlazo = drFactura("Plazo")
                cPromotor = drFactura("DescPromotor")
                cInicialesPromotor = drFactura("Iniciales")
                cGestor = Trim(drFactura("Gestor"))
                cSucursal = drFactura("Sucursal")
                nSaldoInsoluto = drFactura("SaldoInsolutoTabla")
                nSaldoFac = drFactura("SaldoFac")
                cVencida = drFactura("Vencida")

                cConvenioJUR = drFactura("ConvenioJUR")
                If Trim(drFactura("Fecha_Pago")) <> "" Then
                    cFechaPago = CTOD(drFactura("Fecha_Pago")).ToShortDateString
                Else
                    cFechaPago = CTOD(drFactura("Fechacon")).ToShortDateString
                End If


                If chkConsiderarDia.Checked = True Then
                    nDiasVencido = DateDiff(DateInterval.Day, CTOD(drFactura("Feven")), CTOD(cFecha)) + 1
                Else
                    nDiasVencido = DateDiff(DateInterval.Day, CTOD(drFactura("Feven")), CTOD(cFecha))
                End If

                If nDiasVencido > 0 Then

                    ' Busco el Cliente en la tabla Clientes

                    drCliente = dtClientes.Rows.Find(cCliente)

                    If drCliente Is Nothing Then
                        drCliente = dtClientes.NewRow()
                        drCliente("Cliente") = cCliente
                        drCliente("Col1a29") = 0
                        drCliente("Col30a59") = 0
                        drCliente("Col60a89") = 0
                        drCliente("Col90omas") = 0
                        If nDiasVencido > 89 Then
                            drCliente("Col90omas") = nSaldoFac
                        ElseIf nDiasVencido > 59 Then
                            drCliente("Col60a89") = nSaldoFac
                        ElseIf nDiasVencido > 29 Then
                            drCliente("Col30a59") = nSaldoFac
                        ElseIf nDiasVencido > 0 Then
                            drCliente("Col1a29") = nSaldoFac
                        End If
                        drCliente("Promotor") = cPromotor
                        drCliente("InicialesPromotor") = cInicialesPromotor
                        drCliente("Gestor") = cGestor
                        drCliente("Sucursal") = cSucursal
                        drCliente("Retraso") = nDiasVencido
                        drCliente("PoN") = cDigito
                        drCliente("ConvenioJUR") = cConvenioJUR

                        ' Cuando estoy registrando por primera vez el cliente es cuando voy a determinar el número de gestiones de cobranza que se han realizado en los últimos 30 días
                        ' así como el resultado más reciente de dichas gestiones



                        nGestion = 0
                        cSeguimiento = ""
                        cFechaLlamada = ""

                        If chkSeguimiento.Checked = True Then
                            With cm6
                                .CommandType = CommandType.Text
                                .CommandText = "SELECT * FROM JUR_BitacoraCOB WHERE Fecha >= '" & cFechaSeguimiento & "' and cliente = '" & cCliente & "' ORDER BY Cliente, Fecha DESC, id_bitacoraCob "
                                .Connection = cnAgil
                                daSeguimientos.Fill(dsAgil, "Seguimientos")
                            End With

                            For Each drSeguimiento In dsAgil.Tables("Seguimientos").Rows
                                If drSeguimiento("Cliente") = cCliente Then
                                    nGestion = nGestion + 1
                                    If nGestion <= 3 Then
                                        cSeguimiento += Trim(drSeguimiento("Resultado")) & ","
                                        cFechaLlamada = drSeguimiento("Fecha")
                                        cFechaLlamada = Mid(cFechaLlamada, 7, 2) + "/" + Mid(cFechaLlamada, 5, 2) + "/" + Mid(cFechaLlamada, 1, 4)
                                    Else
                                        Exit For
                                    End If
                                End If
                            Next
                        End If

                        dtClientes.Rows.Add(drCliente)

                    Else
                        If nDiasVencido > 89 Then
                            drCliente("Col90omas") += nSaldoFac
                        ElseIf nDiasVencido > 59 Then
                            drCliente("Col60a89") += nSaldoFac
                        ElseIf nDiasVencido > 29 Then
                            drCliente("Col30a59") += nSaldoFac
                        ElseIf nDiasVencido > 0 Then
                            drCliente("Col1a29") += nSaldoFac
                        End If

                        ' La siguiente condición permite tener en el campo Retraso el máximo número de días vencidos del Cliente

                        If nDiasVencido > drCliente("Retraso") Then
                            drCliente("Retraso") = nDiasVencido
                        End If

                    End If

                    ' Busco el Anexo en la tabla Anexos

                    drAnexo = dtAnexos.Rows.Find(cAnexo)

                    If drAnexo Is Nothing Then

                        drAnexo = dtAnexos.NewRow()
                        drAnexo("Anexo") = cAnexo
                        drAnexo("Cliente") = cCliente
                        drAnexo("Nombre") = cNombre
                        drAnexo("Letra") = cLetra
                        drAnexo("Plazo") = nPlazo
                        drAnexo("Dia") = 1
                        drAnexo("Saldo") = nSaldoInsoluto
                        drAnexo("Col1a29") = 0
                        drAnexo("Col30a59") = 0
                        drAnexo("Col60a89") = 0
                        drAnexo("Col90omas") = 0
                        If nDiasVencido > 89 Then
                            drAnexo("Col90omas") = nSaldoFac
                        ElseIf nDiasVencido > 59 Then
                            drAnexo("Col60a89") = nSaldoFac
                        ElseIf nDiasVencido > 29 Then
                            drAnexo("Col30a59") = nSaldoFac
                        ElseIf nDiasVencido > 0 Then
                            drAnexo("Col1a29") = nSaldoFac
                        End If
                        drAnexo("Total") = nSaldoFac
                        drAnexo("Retraso") = nDiasVencido
                        drAnexo("Reestructura") = ""
                        drAnexo("PI") = 0
                        drAnexo("OC") = 0
                        drAnexo("Recursos") = ""
                        drAnexo("InicialesPromotor") = cInicialesPromotor
                        drAnexo("Gestion") = nGestion
                        drAnexo("Seguimiento") = cSeguimiento
                        drAnexo("FechaLlamada") = cFechaLlamada
                        drAnexo("Vencida") = cVencida
                        drAnexo("FechaPago") = cFechaPago
                        drAnexo("ConvenioJUR") = cConvenioJUR
                        dtAnexos.Rows.Add(drAnexo)

                    Else

                        If nDiasVencido > 89 Then
                            drAnexo("Col90omas") += nSaldoFac
                        ElseIf nDiasVencido > 59 Then
                            drAnexo("Col60a89") += nSaldoFac
                        ElseIf nDiasVencido > 29 Then
                            drAnexo("Col30a59") += nSaldoFac
                        ElseIf nDiasVencido > 0 Then
                            drAnexo("Col1a29") += nSaldoFac
                        End If
                        drAnexo("Total") += nSaldoFac

                        ' La siguiente condición permite tener en el campo Retraso el máximo número de
                        ' días vencidos del contrato

                        If nDiasVencido > drAnexo("Retraso") Then
                            drAnexo("Retraso") = nDiasVencido
                        End If

                    End If

                End If

            Next

            ' Esta vista de la tabla Clientes me permite que primero aparezcan los clientes que tienen mayor atraso en días

            dvClientes = New DataView(dtClientes)
            dvClientes = dtClientes.DefaultView
            dvClientes.Sort = "Col90omas DESC, Col60a89 DESC, Col30a59 DESC, Col1a29 DESC"

            Select Case cbPromotores.SelectedIndex()
                Case 0
                    ' Listado General (excepto NAVOJOA)
                    dvClientes.RowFilter() = "Sucursal <> '03'"
                Case 1
                    ' Cartera Exigible de 1 a 29 días
                    dvClientes.RowFilter() = "Sucursal <> '03' AND Retraso >= 1 AND Retraso <= 29"
                Case 2
                    ' Cartera Exigible de 30 a 59 días
                    dvClientes.RowFilter() = "Sucursal <> '03' AND Retraso >= 30 AND Retraso <= 59"
                Case 3
                    ' Cartera Exigible de 60 a 89 días
                    dvClientes.RowFilter() = "Sucursal <> '03' AND Retraso >= 60 AND Retraso <= 89"
                Case 4
                    ' Cartera Vencida
                    dvClientes.RowFilter() = "Sucursal <> '03' AND Retraso >= 90"
                Case 5
                    ' Cartera Castigada
                    dvClientes.RowFilter() = ""
                Case 6
                    ' Cartera Exigible y Vencida de NAVOJOA
                    dvClientes.RowFilter() = "Sucursal = '03'"
                Case 8
                    ' Cartera Exigible y Vencida Convenios Judiciales
                    dvClientes.RowFilter() = "ConvenioJUR = 'S'"
                Case Is >= 9
                    ' Cartera por Promotor
                    dvClientes.RowFilter() = "Promotor = '" & cbPromotores.SelectedItem & "'"
            End Select

            ' Esta vista de la tabla Anexos me permite ordenar el reporte por antigüedad del saldo

            dvAnexos = New DataView(dtAnexos)
            dvAnexos = dtAnexos.DefaultView
            dvAnexos.Sort = "Col90omas DESC, Col60a89 DESC, Col30a59 DESC, Col1a29 DESC"

            ' Por cada registro de la tabla Clientes, debo crear un filtro de la tabla Anexos dejando visibles
            ' solamente los contratos del cliente en cuestión, añadiéndolos a una tercera tabla llamada Reporte

            nClientes = dvClientes.Count()

            For i = 0 To nClientes - 1
                cCliente = dvClientes.Item(i)("Cliente")
                If cbPromotores.SelectedIndex = 8 Then
                    dvAnexos.RowFilter() = "ConvenioJUR = 'S' and Cliente = " & cCliente
                Else
                    dvAnexos.RowFilter() = "Cliente = " & cCliente
                End If

                nAnexos = dvAnexos.Count()
                For j = 0 To nAnexos - 1
                    If cbPromotores.SelectedIndex() = 5 Then
                        If dvAnexos.Item(j)("Vencida") = "C" Then
                            drReporte = dtReporte.NewRow()
                            drReporte("Anexo") = dvAnexos.Item(j)("Anexo")
                            drReporte("Cliente") = dvAnexos.Item(j)("Cliente")
                            drReporte("Nombre") = dvAnexos.Item(j)("Nombre")
                            drReporte("Letra") = dvAnexos.Item(j)("Letra")
                            drReporte("Plazo") = dvAnexos.Item(j)("Plazo")
                            drReporte("Dia") = dvAnexos.Item(j)("Dia")
                            drReporte("Saldo") = dvAnexos.Item(j)("Saldo")
                            drReporte("Col1a29") = dvAnexos.Item(j)("Col1a29")
                            drReporte("Col30a59") = dvAnexos.Item(j)("Col30a59")
                            drReporte("Col60a89") = dvAnexos.Item(j)("Col60a89")
                            drReporte("Col90omas") = dvAnexos.Item(j)("Col90omas")
                            drReporte("Total") = dvAnexos.Item(j)("Total")
                            drReporte("Retraso") = dvAnexos.Item(j)("Retraso")
                            drReporte("Reestructura") = dvAnexos.Item(j)("Reestructura")
                            drReporte("PI") = dvAnexos.Item(j)("PI")
                            drReporte("OC") = dvAnexos.Item(j)("OC")
                            drReporte("Recursos") = dvAnexos.Item(j)("Recursos")
                            drReporte("InicialesPromotor") = dvAnexos.Item(j)("InicialesPromotor")
                            drReporte("Gestion") = dvAnexos.Item(j)("Gestion")
                            drReporte("Seguimiento") = dvAnexos.Item(j)("Seguimiento")
                            drReporte("FechaLlamada") = dvAnexos.Item(j)("FechaLlamada")
                            drReporte("FechaPago") = dvAnexos.Item(j)("FechaPago")
                            dtReporte.Rows.Add(drReporte)
                        End If
                    Else
                        If dvAnexos.Item(j)("Vencida") <> "C" Then
                            drReporte = dtReporte.NewRow()
                            drReporte("Anexo") = dvAnexos.Item(j)("Anexo")
                            drReporte("Cliente") = dvAnexos.Item(j)("Cliente")
                            drReporte("Nombre") = dvAnexos.Item(j)("Nombre")
                            drReporte("Letra") = dvAnexos.Item(j)("Letra")
                            drReporte("Plazo") = dvAnexos.Item(j)("Plazo")
                            drReporte("Dia") = dvAnexos.Item(j)("Dia")
                            drReporte("Saldo") = dvAnexos.Item(j)("Saldo")
                            drReporte("Col1a29") = dvAnexos.Item(j)("Col1a29")
                            drReporte("Col30a59") = dvAnexos.Item(j)("Col30a59")
                            drReporte("Col60a89") = dvAnexos.Item(j)("Col60a89")
                            drReporte("Col90omas") = dvAnexos.Item(j)("Col90omas")
                            drReporte("Total") = dvAnexos.Item(j)("Total")
                            drReporte("Retraso") = dvAnexos.Item(j)("Retraso")
                            drReporte("Reestructura") = dvAnexos.Item(j)("Reestructura")
                            drReporte("PI") = dvAnexos.Item(j)("PI")
                            drReporte("OC") = dvAnexos.Item(j)("OC")
                            drReporte("Recursos") = dvAnexos.Item(j)("Recursos")
                            If cbPromotores.SelectedIndex() = 0 Then
                                drReporte("InicialesPromotor") = dvAnexos.Item(j)("InicialesPromotor")
                            Else
                                drReporte("InicialesPromotor") = ""
                            End If
                            drReporte("Gestion") = dvAnexos.Item(j)("Gestion")
                            drReporte("Seguimiento") = dvAnexos.Item(j)("Seguimiento")
                            drReporte("FechaLlamada") = dvAnexos.Item(j)("FechaLlamada")
                            drReporte("FechaPago") = dvAnexos.Item(j)("FechaPago")
                            dtReporte.Rows.Add(drReporte)
                        End If
                    End If
                Next
            Next

            dsAgil.Tables.Remove("Facturas")
            dsAgil.Tables.Remove("Anexos")
            dsAgil.Tables.Remove("PagosIniciales")
            dsAgil.Tables.Remove("Opciones")
            dsAgil.Tables.Remove("Reestructurados")
            If chkSeguimiento.Checked = True Then dsAgil.Tables.Remove("Seguimientos")

            dsAgil.Tables.Add(dtReporte)

            'Descomentar la siguiente línea en caso de que se deseara modificar el reporte rptRepAntig
            'dsAgil.WriteXml("C:\Schema1.xml", XmlWriteMode.WriteSchema)

            If chkSeguimiento.Checked = False Then

                newrptRepAntig1 = New rptRepAnti3
                newrptRepAntig1.SetDataSource(dsAgil)
                cReportTitle = "REPORTE DE ANTIGUEDAD DE SALDOS AL " & Mes(cFecha)
                If cbPromotores.SelectedIndex = 0 Then
                    cReportComments = "LISTADO GENERAL (Excepto NAVOJOA)"
                ElseIf cbPromotores.SelectedIndex <= 6 Then
                    cReportComments = RTrim(cbPromotores.SelectedItem)
                Else
                    cReportComments = "CLIENTES ASIGNADOS A " & RTrim(cbPromotores.SelectedItem)
                End If
                newrptRepAntig1.SummaryInfo.ReportTitle = cReportTitle
                newrptRepAntig1.SummaryInfo.ReportComments = cReportComments
                CrystalReportViewer1.ReportSource = newrptRepAntig1

            Else

                newrptRepAntig2 = New rptRepantig
                newrptRepAntig2.SetDataSource(dsAgil)
                cReportTitle = "REPORTE DE ANTIGUEDAD DE SALDOS AL " & Mes(cFecha)
                If cbPromotores.SelectedIndex = 0 Then
                    cReportComments = "LISTADO GENERAL (Excepto NAVOJOA)"
                ElseIf cbPromotores.SelectedIndex <= 6 Then
                    cReportComments = RTrim(cbPromotores.SelectedItem)
                Else
                    cReportComments = "CLIENTES ASIGNADOS A " & RTrim(cbPromotores.SelectedItem)
                End If
                newrptRepAntig2.SummaryInfo.ReportTitle = cReportTitle
                newrptRepAntig2.SummaryInfo.ReportComments = cReportComments
                CrystalReportViewer1.ReportSource = newrptRepAntig2

            End If

            CrystalReportViewer1.Zoom(100)

            cnAgil.Dispose()
            cm1.Dispose()
            cm2.Dispose()
            cm3.Dispose()
            cm4.Dispose()
            cm5.Dispose()
            cm6.Dispose()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CmbDB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDB.SelectedIndexChanged
        If CmbDB.SelectedIndex >= 0 And CmbDB.ValueMember <> "" Then
            DateTimePicker1.Value = CTOD(CmbDB.SelectedValue)
            ' Declaración de variables de conexión ADO .NET

            Dim cnAgil As New SqlConnection("Server=" & My.Settings.ServidorBACK & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015")
            Dim cm1 As New SqlCommand()
            Dim dsAgil As New DataSet()
            Dim daPromotores As New SqlDataAdapter(cm1)
            Dim drPromotor As DataRow

            ' Declaración de variables de datos

            Dim cDescPromotor As String = ""

            cbPromotores.MaxDropDownItems = 10

            cbPromotores.Items.Add("LISTADO GENERAL (excepto NAVOJOA)")
            cbPromotores.Items.Add("Cartera Exigible de 1 a 29 días")
            cbPromotores.Items.Add("Cartera Exigible de 30 a 59 días")
            cbPromotores.Items.Add("Cartera Exigible de 60 a 89 días")
            cbPromotores.Items.Add("Cartera Vencida")
            cbPromotores.Items.Add("Cartera Castigada")
            cbPromotores.Items.Add("Cartera Exigible y Vencida de NAVOJOA")
            cbPromotores.Items.Add("LISTADO GENERAL (Avio)")
            cbPromotores.Items.Add("LISTADO Convenios Judiciales")

            cbPromotores.SelectedIndex = 0

            ' El siguiente Command trae el nombre de los Promotes Activos

            With cm1
                .CommandType = CommandType.Text
                .CommandText = "SELECT DescPromotor FROM Promotores WHERE StatusPromotor = 'A' ORDER BY DescPromotor"
                .Connection = cnAgil
            End With

            ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

            Try
                daPromotores.Fill(dsAgil, "Promotores")
            Catch eException As Exception
                MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
            End Try

            For Each drPromotor In dsAgil.Tables("Promotores").Rows
                cDescPromotor = drPromotor("DescPromotor")
                cbPromotores.Items.Add(cDescPromotor)
            Next

            cnAgil.Dispose()
            cm1.Dispose()
        End If
    End Sub
End Class
