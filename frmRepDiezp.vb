' Este reporte excluye los contratos con rentas vencidas a mas de 89 d�as 
' y los contratos que no sean de arrendamiento financiero

Option Explicit On 

Imports System.Data.SqlClient
Imports System.Math
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmRepDiezp

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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 56)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1008, 640)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(136, 17)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(88, 20)
        Me.dtpDate.TabIndex = 9
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(264, 16)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 10
        Me.btnProcesar.Text = "Procesar"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(810, 16)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(37, 34)
        Me.DataGrid1.TabIndex = 11
        Me.DataGrid1.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fecha del Reporte"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(373, 16)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmRepDiezp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1024, 702)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmRepDiezp"
        Me.Text = "Reporte de los diez principales clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daAnexos As New SqlDataAdapter(cm1)
        Dim daEdoctav As New SqlDataAdapter(cm2)
        Dim daFacturas As New SqlDataAdapter(cm3)
        Dim daAvios As New SqlDataAdapter(cm4)
        Dim drAnexo As DataRow
        Dim drTemporal As DataRow
        Dim drEdoctav As DataRow()
        Dim drFacturas As DataRow()
        Dim myColArray(1) As DataColumn
        Dim relAnexoEdoctav As DataRelation
        Dim relAnexoFacturas As DataRelation
        Dim dtTemporal As New DataTable("Temporal")
        Dim dtReporte As New DataTable("Reporte")
        Dim dvReporte As DataView

        ' Declaraci�n de variables de datos

        Dim cFecha As String
        Dim cCliente As String
        Dim cName As String
        Dim cAnexo As String
        Dim i As Integer
        Dim nAcumula As Integer
        Dim nCarteraEquipo As Decimal
        Dim nCounter As Integer
        Dim nInteresEquipo As Decimal
        Dim nMaxCounter As Integer = 100
        Dim nOtrosCartera As Decimal
        Dim nOtrosContratos As Integer
        Dim nOtrosSaldoInsoluto As Decimal
        Dim nSaldoEquipo As Decimal
        Dim nSaldoTotal As Decimal
        Dim nSumaPorcentaje As Decimal
        Dim nCS As Decimal
        Dim nCR As Decimal
        Dim nAP As Decimal
        Dim nAF As Decimal
        Dim nAV As Decimal
        Dim nCC As Decimal

        ' Declaraci�n de variables de Crystal Reports

        Dim cReportTitle As String
        Dim newrptRepDiezp As New rptRepDiezp()

        cFecha = DTOC(dtpDate.Value)

        ' Este Stored Procedure trae todos los contratos activos con fecha de contrataci�n menor o igual
        ' a la de proceso

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv1"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortizaci�n del equipo de todos los contratos activos
        ' con fecha de contrataci�n menor o igual a la de proceso

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv2"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae todas las facturas no pagadas de todos los contratos activos con fecha de
        ' contrataci�n menor o igual a la de proceso

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "CalcAnti1"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae todos los Avios con saldo a la fecha de proceso

        With cm4
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProvAvio"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Llenar el DataSet a trav�s del DataAdapter, lo cual abre y cierra la conexi�n

        daAnexos.Fill(dsAgil, "Anexos")
        daEdoctav.Fill(dsAgil, "Edoctav")
        daFacturas.Fill(dsAgil, "Facturas")
        daAvios.Fill(dsAgil, "Avios")

        ' Establecer la relaci�n entre Anexos y Edoctav

        relAnexoEdoctav = New DataRelation("AnexoEdoctav", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Edoctav").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctav)

        ' Establecer la relaci�n entre Anexos y Facturas

        relAnexoFacturas = New DataRelation("AnexoFacturas", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Facturas").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoFacturas)

        ' Primero creo la tabla Temporal que me permitir� acumular los saldos de los 
        ' contratos por cliente

        dtTemporal.Columns.Add("Cliente", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Nombre", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Contratos", Type.GetType("System.String"))
        dtTemporal.Columns.Add("SdoInsol", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("Cartera", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("CS", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("CR", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("AP", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("AF", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("AV", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("CC", Type.GetType("System.Decimal"))
        dtTemporal.Clear()
        myColArray(0) = dtTemporal.Columns("Cliente")
        dtTemporal.PrimaryKey = myColArray

        ' Ahora creo la tabla Reporte que ser� la base del reporte

        dtReporte.Columns.Add("Cliente", Type.GetType("System.String"))
        dtReporte.Columns.Add("Nombre", Type.GetType("System.String"))
        dtReporte.Columns.Add("Contratos", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("SdoInsol", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("Porcentaje", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("Cartera", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("CS", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("CR", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("AP", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("AF", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("AV", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("CC", Type.GetType("System.Decimal"))
        dtReporte.Clear()

        nSaldoTotal = 0
        'llena contratos tradicionales
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cCliente = drAnexo("Cliente")
            cName = drAnexo("Descr")
            cAnexo = drAnexo("Anexo")

            drFacturas = drAnexo.GetChildRows("AnexoFacturas")
            CalcAnti(cAnexo, cFecha, nMaxCounter, nCounter, drFacturas)

            If nCounter <= nMaxCounter Then

                ' Se trata de un contrato que NO est� vencido (no tiene rentas vencidas a m�s de 89 d�as)

                nSaldoEquipo = 0
                nInteresEquipo = 0
                nCarteraEquipo = 0

                ' Esta instrucci�n trae la tabla de amortizaci�n del Equipo �nica y exclusivamente del contrato
                ' que est� siendo procesado

                drEdoctav = drAnexo.GetChildRows("AnexoEdoctav")
                TraeSald(drEdoctav, cFecha, nSaldoEquipo, nInteresEquipo, nCarteraEquipo)

                If nSaldoEquipo > 0 Then

                    drTemporal = dtTemporal.Rows.Find(cCliente)

                    If drTemporal Is Nothing Then

                        ' Si el cliente no existe en la tabla

                        drTemporal = dtTemporal.NewRow()
                        drTemporal("Cliente") = cCliente
                        drTemporal("Nombre") = cName
                        drTemporal("Contratos") = 1
                        drTemporal("SdoInsol") = nSaldoEquipo
                        drTemporal("Cartera") = nCarteraEquipo

                        drTemporal("CS") = 0
                        drTemporal("CR") = 0
                        drTemporal("AP") = 0
                        drTemporal("AF") = 0
                        drTemporal("AV") = 0
                        drTemporal("CC") = 0

                        Select Case drAnexo("Tipar")
                            Case "S"
                                drTemporal("CS") = nSaldoEquipo
                            Case "P"
                                drTemporal("AP") = nSaldoEquipo
                            Case "F"
                                drTemporal("AF") = nSaldoEquipo
                            Case "R"
                                drTemporal("CR") = nSaldoEquipo
                        End Select

                        dtTemporal.Rows.Add(drTemporal)


                    Else

                        ' El cliente ya existe en la tabla

                        drTemporal("Contratos") += 1
                        drTemporal("SdoInsol") += nSaldoEquipo
                        drTemporal("Cartera") += nCarteraEquipo

                        Select Case drAnexo("Tipar")
                            Case "S"
                                drTemporal("CS") += nSaldoEquipo
                            Case "P"
                                drTemporal("AP") += nSaldoEquipo
                            Case "F"
                                drTemporal("AF") += nSaldoEquipo
                            Case "R"
                                drTemporal("CR") += nSaldoEquipo
                        End Select

                    End If

                    nSaldoTotal = nSaldoTotal + nSaldoEquipo

                End If

            End If

        Next

        'llena contratos del Modulo de Avio (anticipos Avios y Cuentas Corrientes)
        For Each drAnexo In dsAgil.Tables("Avios").Rows

            cCliente = drAnexo("Cliente")
            cName = drAnexo("Descr")
            cAnexo = drAnexo("Anexo")


            nSaldoEquipo = drAnexo("Saldo") - drAnexo("Intereses")
            nCarteraEquipo = drAnexo("Saldo")

            ' Esta instrucci�n trae la tabla de amortizaci�n del Equipo �nica y exclusivamente del contrato
            ' que est� siendo procesado

            If nSaldoEquipo > 0 Then

                drTemporal = dtTemporal.Rows.Find(cCliente)

                If drTemporal Is Nothing Then

                    ' Si el cliente no existe en la tabla

                    drTemporal = dtTemporal.NewRow()
                    drTemporal("Cliente") = cCliente
                    drTemporal("Nombre") = cName
                    drTemporal("Contratos") = 1
                    drTemporal("SdoInsol") = nSaldoEquipo
                    drTemporal("Cartera") = nCarteraEquipo

                    drTemporal("CS") = 0
                    drTemporal("CR") = 0
                    drTemporal("AP") = 0
                    drTemporal("AF") = 0
                    drTemporal("AV") = 0
                    drTemporal("CC") = 0

                    Select Case drAnexo("Tipar")
                        Case "H"
                            drTemporal("AV") = nSaldoEquipo
                        Case "A"
                            drTemporal("AV") = nSaldoEquipo
                        Case "C"
                            drTemporal("CC") = nSaldoEquipo
                    End Select

                    dtTemporal.Rows.Add(drTemporal)

                Else

                    ' El cliente ya existe en la tabla

                    drTemporal("Contratos") += 1
                    drTemporal("SdoInsol") += nSaldoEquipo
                    drTemporal("Cartera") += nCarteraEquipo

                    Select Case drAnexo("Tipar")
                        Case "H"
                            drTemporal("AV") += nSaldoEquipo
                        Case "A"
                            drTemporal("AV") += nSaldoEquipo
                        Case "C"
                            drTemporal("CC") += nSaldoEquipo
                    End Select

                End If

                nSaldoTotal = nSaldoTotal + nSaldoEquipo

            End If
        Next

        dsAgil.Tables.Add(dtTemporal)
        dvReporte = New DataView(dtTemporal)
        dvReporte = dtTemporal.DefaultView
        dvReporte.Sort = "SdoInsol DESC"
        DataGrid1.DataSource = dtTemporal

        ' Ya que tengo los saldos insolutos ordenados en forma descendente, selecciono los 10
        ' m�s importantes y el resto se acumulan

        nAcumula = 0
        nOtrosContratos = 0
        nOtrosSaldoInsoluto = 0
        nSumaPorcentaje = 0
        nOtrosCartera = 0

        nCounter = dtTemporal.Rows.Count()

        For i = 0 To nCounter - 1
            If i <= 29 Then
                drTemporal = dtReporte.NewRow()
                drTemporal("Cliente") = DataGrid1.Item(i, 0)
                drTemporal("Nombre") = DataGrid1.Item(i, 1)
                drTemporal("Contratos") = DataGrid1.Item(i, 2)
                drTemporal("SdoInsol") = DataGrid1.Item(i, 3)
                drTemporal("Porcentaje") = Round(DataGrid1.Item(i, 3) * 100 / nSaldoTotal, 2)
                drTemporal("Cartera") = DataGrid1.Item(i, 4)

                drTemporal("CS") = DataGrid1.Item(i, 5)
                drTemporal("CR") = DataGrid1.Item(i, 6)
                drTemporal("AP") = DataGrid1.Item(i, 7)
                drTemporal("AF") = DataGrid1.Item(i, 8)
                drTemporal("AV") = DataGrid1.Item(i, 9)
                drTemporal("CC") = DataGrid1.Item(i, 10)

                dtReporte.Rows.Add(drTemporal)
                nSumaPorcentaje += Round(DataGrid1.Item(i, 3) * 100 / nSaldoTotal, 2)
            Else
                nAcumula += 1
                nOtrosContratos += DataGrid1.Item(i, 2)
                nOtrosSaldoInsoluto += DataGrid1.Item(i, 3)
                nOtrosCartera += DataGrid1.Item(i, 4)
                nCS += DataGrid1.Item(i, 5)
                nCR += DataGrid1.Item(i, 6)
                nAP += DataGrid1.Item(i, 7)
                nAF += DataGrid1.Item(i, 8)
                nAV += DataGrid1.Item(i, 9)
                nCC += DataGrid1.Item(i, 10)
            End If
        Next

        drTemporal = dtReporte.NewRow()
        drTemporal("Cliente") = " "
        drTemporal("Nombre") = "OTROS CLIENTES (" & nAcumula.ToString & ")"
        drTemporal("Contratos") = nOtrosContratos
        drTemporal("SdoInsol") = nOtrosSaldoInsoluto
        drTemporal("Porcentaje") = Round(100 - nSumaPorcentaje, 2)
        drTemporal("Cartera") = nOtrosCartera
        drTemporal("CS") = nCS
        drTemporal("CR") = nCR
        drTemporal("AP") = nAP
        drTemporal("AF") = nAF
        drTemporal("AV") = nAV
        drTemporal("CC") = nCC
        dtReporte.Rows.Add(drTemporal)

        dsAgil.Relations.Clear()
        dsAgil.Tables("Anexos").Constraints.Clear()
        dsAgil.Tables("Edoctav").Constraints.Clear()
        dsAgil.Tables("Facturas").Constraints.Clear()
        dsAgil.Tables.Remove("Anexos")
        dsAgil.Tables.Remove("Edoctav")
        dsAgil.Tables.Remove("Facturas")
        dsAgil.Tables.Remove("Temporal")
        dsAgil.Tables.Add(dtReporte)

        ' Descomentar la siguiente l�nea en caso de que se deseara modificar el reporte rptRepDiezp
        'dsAgil.WriteXml("C:\Schema27.xml", XmlWriteMode.WriteSchema)
        newrptRepDiezp.SetDataSource(dsAgil)
        cReportTitle = "REPORTE DE PRINCIPALES CLIENTES AL " & Mes(cFecha)
        newrptRepDiezp.SummaryInfo.ReportTitle = cReportTitle
        CrystalReportViewer1.ReportSource = newrptRepDiezp

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class
