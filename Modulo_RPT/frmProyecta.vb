Option Explicit On
Imports System.IO
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class frmProyecta


    ' Declaración de variables de conexión ADO .NET de alcance privado

    Dim dtReporte1 As New DataTable("Reporte1")
    Dim dtVenAn As New DataTable("VenAn")
    Dim dtVenAv As New DataTable("VenAv")
    Dim dtReporteAcum As New DataTable("ReporteAcum")
    Dim f1 As New StreamWriter("c:\Files\Detalle" & Date.Now.ToString("yyyyMMdd-hhmm") & ".txt")
    Dim f2 As New StreamWriter("c:\Files\DetalleTot" & Date.Now.ToString("yyyyMMdd-hhmm") & ".txt")
    ' Declaración de variables de datos de alcance privado

    Dim cFecha As String
    Dim cFechaInt As String
    Dim cFechaCortoPalzo As String
    Dim cYear As String
    Dim Total As Double
    Dim banderaTotal As Double = True

    Private Sub frmProyecta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        f1.Close()
        f2.Close()
    End Sub

    Private Sub frmProyecta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Carga_ComboDB()
        Me.SucursalesTableAdapter.FillMasTodas(Me.ReportesDS.Sucursales)
        ComboSucursal.SelectedIndex = ComboSucursal.Items.Count - 1
        f1.WriteLine("Contrato" & vbTab & "Cliente" & vbTab & "Tipar" & vbTab & "Monto" & vbTab & "Año" & vbTab & "Mes")
        f2.WriteLine("Contrato" & vbTab & "Cliente" & vbTab & "Tipar" & vbTab & "Monto" & vbTab & "Interes" & vbTab & "Partes" & vbTab & "Origen" & vbTab & "Monto Corto" & vbTab & "Inte Corto" & vbTab & "Monto Largo" & vbTab & "Inte Largo")
    End Sub

    Private Sub btnProceso_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProceso.Click
        Dim FechaAux As Date = CTOD(CmbDB.SelectedValue)
        Dim Suc1 As String = "00"
        Dim Suc2 As String = "99"
        If ComboSucursal.SelectedValue <> "99" Then
            Suc1 = ComboSucursal.SelectedValue
            Suc2 = ComboSucursal.SelectedValue
        End If
        Cursor.Current = Cursors.WaitCursor
        dtReporte1.Clear()
        dtReporteAcum.Clear()
        Total = 0

        Dim mes_t As String = (MonthName(FechaAux.Month).ToString)
        Dim anio As String = FechaAux.Year.ToString
        Dim name_month As String = mes_t.Substring(0, 3).ToUpper

        strConn = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cmAv As New SqlCommand()
        Dim cmAn As New SqlCommand()
        Dim tot As New SqlCommand()

        Dim daAnexo As New SqlDataAdapter(cm1)
        Dim daEdoctav As New SqlDataAdapter(cm2)
        Dim daFacturas As New SqlDataAdapter(cm3)
        Dim daVencimientosAV As New SqlDataAdapter(cmAv)
        Dim daVencimientosAn As New SqlDataAdapter(cmAn)
        Dim datot As New SqlDataAdapter(tot)

        Dim drtot As DataRow
        Dim drAnexo As DataRow
        Dim dsAgil As New DataSet()
        Dim relAnexoEdoctav As DataRelation
        Dim relAnexoFacturas As DataRelation
        Dim dvReporte1 As DataView
        Dim dvReporteX As DataView
        Dim myColArray(1) As DataColumn
        Dim myColArrayX(1) As DataColumn
        Dim myColArrayY(1) As DataColumn
        Dim myColArrayZ(1) As DataColumn

        ' Declaración de variables de 


        Dim cAnexo As String = ""
        Dim cTipta As String = ""
        Dim cCliente As String = ""
        Dim cTipar As String = ""
        Dim nTasa As Double

        Dim cvencida As String = "0"
        Dim carrendamiento As String = "0"
        Dim crefaccionario As String = "0"
        Dim csimple As String = "0"
        Dim csimpleLI As String = "0"
        Dim cavio As String = "0"
        Dim ccorriente As String = "0"
        Dim cfac_financiero As String = "0"
        Dim cces_derechos As String = "0"
        Dim cseguros As String = "0"
        Dim cexigible As String = "0"

        Dim totalCont As Double = 0.00

        cFecha = FechaAux.ToString("yyyyMMdd")
        cFechaCortoPalzo = FechaAux.AddYears(1).ToString("yyyyMMdd")
        cFechaInt = FechaAux.AddDays(1).ToString("yyyyMMdd")


        ' Primero creo la tabla Temporal que me permitirá acumular los saldos de los 
        ' contratos por cliente

        cYear = "2019"


        If dtReporte1.Columns.Count() = 0 Then
            dtReporte1.Columns.Add("Mes", Type.GetType("System.String"))
            dtReporte1.Columns.Add(cYear, Type.GetType("System.Decimal"))

            dtReporte1.Columns.Add(CStr(Val(cYear) + 1), Type.GetType("System.Decimal"))
            dtReporte1.Columns.Add(CStr(Val(cYear) + 2), Type.GetType("System.Decimal"))
            dtReporte1.Columns.Add(CStr(Val(cYear) + 3), Type.GetType("System.Decimal"))
            dtReporte1.Columns.Add(CStr(Val(cYear) + 4), Type.GetType("System.Decimal"))
            dtReporte1.Columns.Add(CStr(Val(cYear) + 5), Type.GetType("System.Decimal"))
            dtReporte1.Columns.Add(CStr(Val(cYear) + 6), Type.GetType("System.Decimal"))
            dtReporte1.Columns.Add(CStr(Val(cYear) + 7), Type.GetType("System.Decimal"))
            dtReporte1.Columns.Add(CStr(Val(cYear) + 8), Type.GetType("System.Decimal"))
            dtReporte1.Columns.Add(CStr(Val(cYear) + 9), Type.GetType("System.Decimal"))
            dtReporte1.Columns.Add(CStr(Val(cYear) + 10), Type.GetType("System.Decimal"))
            myColArray(0) = dtReporte1.Columns("Mes")
            dtReporte1.PrimaryKey = myColArray

        End If

        If dtReporteAcum.Columns.Count() = 0 Then

            dtReporteAcum.Columns.Add("Mes", Type.GetType("System.String"))
            dtReporteAcum.Columns.Add("Mes0", Type.GetType("System.String"))

            dtReporteAcum.Columns.Add(cYear, Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(cYear & "Variable", Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(cYear & "Fija", Type.GetType("System.Decimal"))

            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 1), Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 1) & "Variable", Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 1) & "Fija", Type.GetType("System.Decimal"))

            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 2), Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 2) & "Variable", Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 2) & "Fija", Type.GetType("System.Decimal"))

            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 3), Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 3) & "Variable", Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 3) & "Fija", Type.GetType("System.Decimal"))

            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 4), Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 4) & "Variable", Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 4) & "Fija", Type.GetType("System.Decimal"))

            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 5), Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 5) & "Variable", Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 5) & "Fija", Type.GetType("System.Decimal"))

            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 6), Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 6) & "Variable", Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 6) & "Fija", Type.GetType("System.Decimal"))

            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 7), Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 7) & "Variable", Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 7) & "Fija", Type.GetType("System.Decimal"))

            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 8), Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 8) & "Variable", Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 8) & "Fija", Type.GetType("System.Decimal"))

            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 9), Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 9) & "Variable", Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 9) & "Fija", Type.GetType("System.Decimal"))

            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 10), Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 10) & "Variable", Type.GetType("System.Decimal"))
            dtReporteAcum.Columns.Add(CStr(Val(cYear) + 10) & "Fija", Type.GetType("System.Decimal"))

            myColArrayX(0) = dtReporteAcum.Columns("Mes")
            dtReporteAcum.PrimaryKey = myColArrayX
        End If

        ' Con este Stored Procedure obtengo los contratos activos a la fecha solicitada

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv1_CortoLargo"
            .Connection = cnAgil
            .Parameters.Add("@Fechafin", SqlDbType.NVarChar)
            .Parameters.Add("@Suc1", SqlDbType.NVarChar)
            .Parameters.Add("@Suc2", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
            .Parameters(1).Value = Suc1
            .Parameters(2).Value = Suc2
        End With

        ' Con este Store Procedure obtengo la tabla de amortización del equipo de todos los contratos activos a la fecha solicitada

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv2_CortoLargo"
            .Connection = cnAgil
            .Parameters.Add("@Fechafin", SqlDbType.NVarChar)
            .Parameters.Add("@FechaInt", SqlDbType.NVarChar)
            .Parameters.Add("@Suc1", SqlDbType.NVarChar)
            .Parameters.Add("@Suc2", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
            .Parameters(1).Value = cFechaInt
            .Parameters(2).Value = Suc1
            .Parameters(3).Value = Suc2
        End With

        ' Este Stored Procedure trae todas las facturas no pagadas de todos los contratos activos con fecha de
        ' contratación menor o igual a la de proceso

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "CalcAnti_CortoLargo"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters.Add("@Suc1", SqlDbType.NVarChar)
            .Parameters.Add("@Suc2", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
            .Parameters(1).Value = Suc1
            .Parameters(2).Value = Suc2
        End With

        With cmAn
            .CommandType = CommandType.Text
            .CommandText = "select * from Vw_XRepAntiGeneralCarteraVencida"
            .Connection = cnAgil
        End With

        With cmAv
            .CommandType = CommandType.Text
            .CommandText = "select *, anexo+ciclo as anexox from Vw_CarteraVencidaAvio"
            .Connection = cnAgil
        End With

        With tot
            cYear = Mid(cFecha, 1, 4)
            .CommandType = CommandType.Text
            .CommandText = "select * from CONT_MezclaTotal where Mes='" & name_month & " " & cYear.ToString & "'"
            .Connection = cnAgil
            cYear = "2019"
        End With

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daAnexo.Fill(dsAgil, "Anexos")
        daEdoctav.Fill(dsAgil, "Edoctav")
        daFacturas.Fill(dsAgil, "Facturas")
        datot.Fill(dsAgil, "CONT_MezclaTotal")

        daVencimientosAn.Fill(dtVenAn)
        daVencimientosAV.Fill(dtVenAv)

        myColArrayZ(0) = dtVenAn.Columns("Anexo")
        dtVenAn.PrimaryKey = myColArrayZ
        myColArrayY(0) = dtVenAv.Columns("anexox")
        dtVenAv.PrimaryKey = myColArrayY


        ' Establecer la relación entre Anexos y Edoctav

        relAnexoEdoctav = New DataRelation("AnexoEdoctav", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Edoctav").Columns("Anexo"))
        dsAgil.EnforceConstraints = True
        dsAgil.Relations.Add(relAnexoEdoctav)

        ' Establecer la relación entre Anexos y Facturas

        relAnexoFacturas = New DataRelation("AnexoFacturas", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Facturas").Columns("Anexo"))
        dsAgil.EnforceConstraints = True
        dsAgil.Relations.Add(relAnexoFacturas)

        Dim gran_total As Double = 0.00

        If ComboSucursal.SelectedValue = "99" Then
            For Each drtot In dsAgil.Tables("CONT_MezclaTotal").Rows
                Dim v1 As String = drtot("TipoCartera")
                Select Case v1.Trim
                    Case "VENCIDA"
                        cvencida = drtot("CapitalCartera")
                    Case "ARRENDAMIENTO FINANCIERO"
                        carrendamiento = drtot("CapitalCartera")
                    Case "CRÉDITO REFACCIONARIO"
                        crefaccionario = drtot("CapitalCartera")
                    Case "CRÉDITO SIMPLE"
                        csimple = drtot("CapitalCartera")
                    Case "CRÉDITO LIQUIDEZ INMEDIATA"
                        csimpleLI = drtot("CapitalCartera")
                    Case "CRÉDITO DE AVÍO"
                        cavio = drtot("CapitalCartera")
                    Case "CUENTA CORRIENTE"
                        ccorriente = drtot("CapitalCartera")
                    Case "FACTORAJE FINANCIERO"
                        cfac_financiero = drtot("CapitalCartera")
                    Case "CESIÓN DE DERECHOS"
                        cces_derechos = drtot("CapitalCartera")
                    Case "SEGUROS"
                        cseguros = drtot("CapitalCartera")
                    Case "EXIGIBLE"
                        cexigible = drtot("CapitalCartera")
                End Select
                totalCont += drtot("CapitalCartera")
            Next
        End If

        Dim rpt As New rptGeneral
        'OK
#Region "ReporteTotal"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'excluye castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If ComboSucursal.SelectedValue <> "999" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "X", "", "", "")
                    banderaTotal = True
                End If
            End If
        Next
        'sacaAVCC("C", Suc1, Suc2)
        'sacaAVCC("H", Suc1, Suc2)


        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        Dim mes As String = FechaAux.Month.ToString("MMMM")

        Dim CPTotal As Decimal = 0
        Dim LPTotal As Decimal = 0
        Dim totales(9) As Double


        For Each filas As DataRow In dtReporteAcum.Rows
            totales(0) += filas.Item(2)
            totales(1) += filas.Item(5)
            totales(2) += filas.Item(8)
            totales(3) += filas.Item(11)
            totales(4) += filas.Item(14)
            totales(5) += filas.Item(17)
            totales(6) += filas.Item(20)
            totales(7) += filas.Item(23)
            totales(8) += filas.Item(26)
            totales(9) += filas.Item(29)
        Next

        Dim total_rep As Double = totales(0) + totales(1) + totales(2) + totales(3) + totales(4) + totales(5) + totales(6) + totales(7) + totales(8) + totales(9)

        gran_total = (CDbl(cvencida) - 1500000) + CDbl(cfac_financiero) + CDbl(cces_derechos) + CDbl(cseguros) + 1500000 + CDbl(total_rep) + cexigible

        If ComboSucursal.SelectedValue <> "99" Then
            gran_total = total_rep
        Else
            gran_total = (CDbl(cvencida) - 1500000) + CDbl(cfac_financiero) + CDbl(cces_derechos) + CDbl(cseguros) + 1500000 + CDbl(total_rep) + cexigible
        End If

        If ComboSucursal.SelectedValue = "99" Then
            For Each filas As DataRow In dtReporteAcum.Rows
                filas.Item(2) = porcentaje(total_rep, filas.Item(2), gran_total - totalCont)
                filas.Item(3) = porcentaje(total_rep, filas.Item(3), gran_total - totalCont)
                filas.Item(4) = porcentaje(total_rep, filas.Item(4), gran_total - totalCont)
                filas.Item(5) = porcentaje(total_rep, filas.Item(5), gran_total - totalCont)
                filas.Item(6) = porcentaje(total_rep, filas.Item(6), gran_total - totalCont)
                filas.Item(7) = porcentaje(total_rep, filas.Item(7), gran_total - totalCont)
                filas.Item(8) = porcentaje(total_rep, filas.Item(8), gran_total - totalCont)
                filas.Item(9) = porcentaje(total_rep, filas.Item(9), gran_total - totalCont)
                filas.Item(10) = porcentaje(total_rep, filas.Item(10), gran_total - totalCont)
                filas.Item(11) = porcentaje(total_rep, filas.Item(11), gran_total - totalCont)
                filas.Item(12) = porcentaje(total_rep, filas.Item(12), gran_total - totalCont)
                filas.Item(13) = porcentaje(total_rep, filas.Item(13), gran_total - totalCont)
                filas.Item(14) = porcentaje(total_rep, filas.Item(14), gran_total - totalCont)
                filas.Item(15) = porcentaje(total_rep, filas.Item(15), gran_total - totalCont)
                filas.Item(16) = porcentaje(total_rep, filas.Item(16), gran_total - totalCont)
                filas.Item(17) = porcentaje(total_rep, filas.Item(17), gran_total - totalCont)
                filas.Item(18) = porcentaje(total_rep, filas.Item(18), gran_total - totalCont)
                filas.Item(19) = porcentaje(total_rep, filas.Item(19), gran_total - totalCont)
                filas.Item(20) = porcentaje(total_rep, filas.Item(20), gran_total - totalCont)
                filas.Item(21) = porcentaje(total_rep, filas.Item(21), gran_total - totalCont)
                filas.Item(22) = porcentaje(total_rep, filas.Item(22), gran_total - totalCont)
                filas.Item(23) = porcentaje(total_rep, filas.Item(23), gran_total - totalCont)
                filas.Item(24) = porcentaje(total_rep, filas.Item(24), gran_total - totalCont)
                filas.Item(25) = porcentaje(total_rep, filas.Item(25), gran_total - totalCont)
                filas.Item(26) = porcentaje(total_rep, filas.Item(26), gran_total - totalCont)
                filas.Item(27) = porcentaje(total_rep, filas.Item(27), gran_total - totalCont)
                filas.Item(28) = porcentaje(total_rep, filas.Item(28), gran_total - totalCont)
                filas.Item(29) = porcentaje(total_rep, filas.Item(29), gran_total - totalCont)
                filas.Item(30) = porcentaje(total_rep, filas.Item(30), gran_total - totalCont)
                filas.Item(31) = porcentaje(total_rep, filas.Item(31), gran_total - totalCont)
                filas.Item(32) = porcentaje(total_rep, filas.Item(32), gran_total - totalCont)
                filas.Item(33) = porcentaje(total_rep, filas.Item(33), gran_total - totalCont)
                filas.Item(34) = porcentaje(total_rep, filas.Item(34), gran_total - totalCont)
                If FechaAux.Month = 12 Then
                    CPTotal += filas.Item(2)
                Else
                    CPTotal += filas.Item(2)
                    If Val(filas.Item(1)) <= FechaAux.Month Then
                        CPTotal += filas.Item(3)
                    End If
                End If
            Next
        End If

        dtReporteAcum.WriteXml("c:\Files\dtReporteAcum.xml", XmlWriteMode.WriteSchema)

        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region
        'OK
#Region "Arrendamiento"
        Dim total_repArrendamiento As Double = 0
#Region "ReporteArrendamientoB"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "F" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "X", "", "X", "")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"
        dtReporte1.WriteXml("c:\Files\dtReporteA_3.xml", XmlWriteMode.WriteSchema)
        Dim CPArrendamiento3 As Decimal = 0
        Dim LPArrendamiento3 As Decimal = 0

        Dim totalesB2(9) As Double

        For Each filas As DataRow In dtReporte1.Rows
            totalesB2(0) += filas.Item(1)
            totalesB2(1) += filas.Item(2)
            totalesB2(2) += filas.Item(3)
            totalesB2(3) += filas.Item(4)
            totalesB2(4) += filas.Item(5)
            totalesB2(5) += filas.Item(6)
            totalesB2(6) += filas.Item(7)
            totalesB2(7) += filas.Item(8)
        Next

        total_repArrendamiento = totalesB2(0) + totalesB2(1) + totalesB2(2) + totalesB2(3) + totalesB2(4) + totalesB2(5) + totalesB2(6) + totalesB2(7) + totalesB2(8) + totalesB2(9)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPArrendamiento3 += filas.Item(1)
            Else
                CPArrendamiento3 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPArrendamiento3 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteArrendamientoA"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "F" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "", "X", "", "X")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"
        dtReporte1.WriteXml("c:\Files\dtReporteA_2.xml", XmlWriteMode.WriteSchema)
        Dim CPArrendamiento2 As Decimal = 0
        Dim LPArrendamiento2 As Decimal = 0


        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPArrendamiento2 += filas.Item(1)
            Else
                CPArrendamiento2 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPArrendamiento2 += filas.Item(2)
                End If
            End If
        Next

        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteArrendamiento"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "F" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "X", "", "", "X")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"



        Dim CPArrendamiento1 As Decimal = 0
        Dim LPArrendamiento1 As Decimal = 0

        Dim totalesA2(9) As Double

        For Each filas As DataRow In dtReporte1.Rows
            totalesA2(0) += filas.Item(1)
            totalesA2(1) += filas.Item(2)
            totalesA2(2) += filas.Item(3)
            totalesA2(3) += filas.Item(4)
            totalesA2(4) += filas.Item(5)
            totalesA2(5) += filas.Item(6)
            totalesA2(6) += filas.Item(7)
            totalesA2(7) += filas.Item(8)
        Next

        Dim total_repArrendamientoRep As Double = totalesA2(0) + totalesA2(1) + totalesA2(2) + totalesA2(3) + totalesA2(4) + totalesA2(5) + totalesA2(6) + totalesA2(7) + totalesA2(8) + totalesA2(9)

        If ComboSucursal.SelectedValue <> "99" Then
            carrendamiento = total_repArrendamientoRep
        End If

        If ComboSucursal.SelectedValue = "99" Then
            For Each filas As DataRow In dtReporte1.Rows
                filas.Item(1) = porcentaje_sub(total_repArrendamientoRep, filas.Item(1), carrendamiento - (total_repArrendamientoRep + total_repArrendamiento))
                filas.Item(2) = porcentaje_sub(total_repArrendamientoRep, filas.Item(2), carrendamiento - (total_repArrendamientoRep + total_repArrendamiento))
                filas.Item(3) = porcentaje_sub(total_repArrendamientoRep, filas.Item(3), carrendamiento - (total_repArrendamientoRep + total_repArrendamiento))
                filas.Item(4) = porcentaje_sub(total_repArrendamientoRep, filas.Item(4), carrendamiento - (total_repArrendamientoRep + total_repArrendamiento))
                filas.Item(5) = porcentaje_sub(total_repArrendamientoRep, filas.Item(5), carrendamiento - (total_repArrendamientoRep + total_repArrendamiento))
                filas.Item(6) = porcentaje_sub(total_repArrendamientoRep, filas.Item(6), carrendamiento - (total_repArrendamientoRep + total_repArrendamiento))
                filas.Item(7) = porcentaje_sub(total_repArrendamientoRep, filas.Item(7), carrendamiento - (total_repArrendamientoRep + total_repArrendamiento))
                filas.Item(8) = porcentaje_sub(total_repArrendamientoRep, filas.Item(8), carrendamiento - (total_repArrendamientoRep + total_repArrendamiento))
            Next
        End If

        dtReporte1.WriteXml("c:\Files\dtReporte12.xml", XmlWriteMode.WriteSchema)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPArrendamiento1 += filas.Item(1)
            Else
                CPArrendamiento1 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPArrendamiento1 += filas.Item(2)
                End If
            End If
        Next

        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteArrendamientoC"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "F" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "", "X", "X", "")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"
        dtReporte1.WriteXml("c:\Files\dtReporteA_4.xml", XmlWriteMode.WriteSchema)
        Dim CPArrendamiento4 As Decimal = 0
        Dim LPArrendamiento4 As Decimal = 0

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPArrendamiento4 += filas.Item(1)
            Else
                CPArrendamiento4 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPArrendamiento4 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region
#End Region

#Region "Refaccionario"
        Dim total_repRefaccionario As Double = 0

#Region "ReporteRefaccionarioB"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "R" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "", "X", "", "X")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"
        dtReporte1.WriteXml("c:\Files\dtRefaccionarioB.xml", XmlWriteMode.WriteSchema)
        Dim CPRefaccionario2 As Decimal = 0
        Dim LPRefaccionario2 As Decimal = 0

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPRefaccionario2 += filas.Item(1)
            Else
                CPRefaccionario2 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPRefaccionario2 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteRefaccionarioC"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "R" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "X", "", "X", "")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        Dim CPRefaccionario3 As Decimal = 0
        Dim LPRefaccionario3 As Decimal = 0

        Dim totalesR2(9) As Double

        For Each filas As DataRow In dtReporte1.Rows
            totalesR2(0) += filas.Item(1)
            totalesR2(1) += filas.Item(2)
            totalesR2(2) += filas.Item(3)
            totalesR2(3) += filas.Item(4)
            totalesR2(4) += filas.Item(5)
            totalesR2(5) += filas.Item(6)
            totalesR2(6) += filas.Item(7)
            totalesR2(7) += filas.Item(8)
        Next

        total_repRefaccionario = totalesR2(0) + totalesR2(1) + totalesR2(2) + totalesR2(3) + totalesR2(4) + totalesR2(5) + totalesR2(6) + totalesR2(7) + totalesR2(8) + totalesR2(9)

        dtReporte1.WriteXml("c:\Files\dtRefaccionarioC.xml", XmlWriteMode.WriteSchema)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPRefaccionario3 += filas.Item(1)
            Else
                CPRefaccionario3 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPRefaccionario3 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteRefaccionarioA"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "R" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "X", "", "", "X")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        Dim CPRefaccionario1 As Decimal = 0
        Dim LPRefaccionario1 As Decimal = 0

        Dim totalesRA2(9) As Double

        For Each filas As DataRow In dtReporte1.Rows
            totalesRA2(0) += filas.Item(1)
            totalesRA2(1) += filas.Item(2)
            totalesRA2(2) += filas.Item(3)
            totalesRA2(3) += filas.Item(4)
            totalesRA2(4) += filas.Item(5)
            totalesRA2(5) += filas.Item(6)
            totalesRA2(6) += filas.Item(7)
            totalesRA2(7) += filas.Item(8)
        Next

        Dim total_repRefaccionarioRep As Double = totalesRA2(0) + totalesRA2(1) + totalesRA2(2) + totalesRA2(3) + totalesRA2(4) + totalesRA2(5) + totalesRA2(6) + totalesRA2(7) + totalesRA2(8) + totalesRA2(9)

        If ComboSucursal.SelectedValue <> "99" Then
            crefaccionario = total_repRefaccionarioRep
        End If

        If ComboSucursal.SelectedValue = "99" Then
            For Each filas As DataRow In dtReporte1.Rows
                filas.Item(1) = porcentaje_sub(total_repRefaccionarioRep, filas.Item(1), crefaccionario - (total_repRefaccionarioRep + total_repRefaccionario))
                filas.Item(2) = porcentaje_sub(total_repRefaccionarioRep, filas.Item(2), crefaccionario - (total_repRefaccionarioRep + total_repRefaccionario))
                filas.Item(3) = porcentaje_sub(total_repRefaccionarioRep, filas.Item(3), crefaccionario - (total_repRefaccionarioRep + total_repRefaccionario))
                filas.Item(4) = porcentaje_sub(total_repRefaccionarioRep, filas.Item(4), crefaccionario - (total_repRefaccionarioRep + total_repRefaccionario))
                filas.Item(5) = porcentaje_sub(total_repRefaccionarioRep, filas.Item(5), crefaccionario - (total_repRefaccionarioRep + total_repRefaccionario))
                filas.Item(6) = porcentaje_sub(total_repRefaccionarioRep, filas.Item(6), crefaccionario - (total_repRefaccionarioRep + total_repRefaccionario))
                filas.Item(7) = porcentaje_sub(total_repRefaccionarioRep, filas.Item(7), crefaccionario - (total_repRefaccionarioRep + total_repRefaccionario))
                filas.Item(8) = porcentaje_sub(total_repRefaccionarioRep, filas.Item(8), crefaccionario - (total_repRefaccionarioRep + total_repRefaccionario))
            Next
        End If

        dtReporte1.WriteXml("c:\Files\dtRefaccionarioA.xml", XmlWriteMode.WriteSchema)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPRefaccionario1 += filas.Item(1)
            Else
                CPRefaccionario1 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPRefaccionario1 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteRefaccionarioD"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "R" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "", "X", "X", "")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"
        dtReporte1.WriteXml("c:\Files\dtRefaccionarioD.xml", XmlWriteMode.WriteSchema)
        Dim CPRefaccionario4 As Decimal = 0
        Dim LPRefaccionario4 As Decimal = 0

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPRefaccionario4 += filas.Item(1)
            Else
                CPRefaccionario4 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPRefaccionario4 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region
#End Region

#Region "Reestructuras"
        Dim total_repReestructura As Double = 0

#Region "ReporteReestructurasC"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "S" And drAnexo("Reestructura") = "S" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "X", "", "X", "")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        Dim CPReestructuras3 As Decimal = 0
        Dim LPReestructuras3 As Decimal = 0


        Dim totalesREB2(9) As Double

        For Each filas As DataRow In dtReporte1.Rows
            totalesREB2(0) += filas.Item(1)
            totalesREB2(1) += filas.Item(2)
            totalesREB2(2) += filas.Item(3)
            totalesREB2(3) += filas.Item(4)
            totalesREB2(4) += filas.Item(5)
            totalesREB2(5) += filas.Item(6)
            totalesREB2(6) += filas.Item(7)
            totalesREB2(7) += filas.Item(8)
            totalesREB2(8) += filas.Item(9)
            totalesREB2(9) += filas.Item(10)
        Next

        total_repReestructura = totalesREB2(0) + totalesREB2(1) + totalesREB2(2) + totalesREB2(3) + totalesREB2(4) + totalesREB2(5) + totalesREB2(6) + totalesREB2(7) + totalesREB2(8) + totalesREB2(9)

        dtReporte1.WriteXml("c:\Files\dtReestructurasC.xml", XmlWriteMode.WriteSchema)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPReestructuras3 += filas.Item(1)
            Else
                CPReestructuras3 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPReestructuras3 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteReestructurasB"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "S" And drAnexo("Reestructura") = "S" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "", "X", "", "X")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        Dim CPReestructuras2 As Decimal = 0
        Dim LPReestructuras2 As Decimal = 0

        dtReporte1.WriteXml("c:\Files\dtReestructurasB.xml", XmlWriteMode.WriteSchema)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPReestructuras2 += filas.Item(1)
            Else
                CPReestructuras2 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPReestructuras2 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteReestructurasA"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "S" And drAnexo("Reestructura") = "S" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "X", "", "", "X")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        Dim CPReestructuras1 As Decimal = 0
        Dim LPReestructuras1 As Decimal = 0

        Dim totalesRsA2(9) As Double

        For Each filas As DataRow In dtReporte1.Rows
            totalesRsA2(0) += filas.Item(1)
            totalesRsA2(1) += filas.Item(2)
            totalesRsA2(2) += filas.Item(3)
            totalesRsA2(3) += filas.Item(4)
            totalesRsA2(4) += filas.Item(5)
            totalesRsA2(5) += filas.Item(6)
            totalesRsA2(6) += filas.Item(7)
            totalesRsA2(7) += filas.Item(8)
            totalesRsA2(8) += filas.Item(9)
        Next

        Dim total_repReestructuraRep As Double = totalesRsA2(0) + totalesRsA2(1) + totalesRsA2(2) + totalesRsA2(3) + totalesRsA2(4) + totalesRsA2(5) + totalesRsA2(6) + totalesRsA2(7) + totalesRsA2(8) + totalesRsA2(9)

        For Each filas As DataRow In dtReporte1.Rows
            filas.Item(1) = filas.Item(1)
            filas.Item(2) = filas.Item(2)
            filas.Item(3) = filas.Item(3)
            filas.Item(4) = filas.Item(4)
            filas.Item(5) = filas.Item(5)
            filas.Item(6) = filas.Item(8)
            filas.Item(7) = filas.Item(7)
            filas.Item(8) = filas.Item(8)
        Next

        dtReporte1.WriteXml("c:\Files\dtReestructurasA.xml", XmlWriteMode.WriteSchema)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPReestructuras1 += filas.Item(1)
            Else
                CPReestructuras1 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPReestructuras1 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteReestructurasD"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "S" And drAnexo("Reestructura") = "S" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "", "X", "X", "")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"
        dtReporte1.WriteXml("c:\Files\dtReestructurasD.xml", XmlWriteMode.WriteSchema)
        Dim CPReestructuras4 As Decimal = 0
        Dim LPReestructuras4 As Decimal = 0

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPReestructuras4 += filas.Item(1)
            Else
                CPReestructuras4 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPReestructuras4 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region
#End Region

#Region "Credito Simple"
        Dim total_repSimple As Double = 0
#Region "ReporteSimpleC"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "S" And drAnexo("Reestructura") <> "S" Then
                    'If cTipar = "S" And Trim(drAnexo("CNEmpresa")) <> "" And drAnexo("anexo") <> "32740002" And drAnexo("anexo") <> "32350001" And drAnexo("anexo") <> "28990002" And drAnexo("anexo") <> "34270001" And drAnexo("anexo") <> "20970004" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "X", "", "X", "")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        Dim CPSimple3 As Decimal = 0
        Dim LPSimple3 As Decimal = 0
        Dim totalesS2(9) As Double

        For Each filas As DataRow In dtReporte1.Rows
            totalesS2(0) += filas.Item(1)
            totalesS2(1) += filas.Item(2)
            totalesS2(2) += filas.Item(3)
            totalesS2(3) += filas.Item(4)
            totalesS2(4) += filas.Item(5)
            totalesS2(5) += filas.Item(6)
            totalesS2(6) += filas.Item(7)
            totalesS2(7) += filas.Item(8)
            totalesS2(8) += filas.Item(9)
        Next

        total_repSimple = totalesS2(0) + totalesS2(1) + totalesS2(2) + totalesS2(3) + totalesS2(4) + totalesS2(5) + totalesS2(6) + totalesS2(7) + totalesS2(8) + totalesS2(9)

        dtReporte1.WriteXml("c:\Files\dtSimpleC.xml", XmlWriteMode.WriteSchema)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPSimple3 += filas.Item(1)
            Else
                CPSimple3 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPSimple3 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteSimpleA"
        '*************************************************************************************************************************************************************
        dtReporte1.Clear()
        dtReporteAcum.Clear()

        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If (cTipar = "S") And drAnexo("Reestructura") <> "S" Then
                    'If cTipar = "S" And Trim(drAnexo("CNEmpresa")) <> "" And drAnexo("anexo") <> "32740002" And drAnexo("anexo") <> "32350001" And drAnexo("anexo") <> "28990002" And drAnexo("anexo") <> "34270001" And drAnexo("anexo") <> "20970004" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "X", "", "", "X")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        Dim CPSimple1 As Decimal = 0
        Dim LPSimple1 As Decimal = 0

        Dim totalesSA2(9) As Double

        For Each filas As DataRow In dtReporte1.Rows
            totalesSA2(0) += filas.Item(1)
            totalesSA2(1) += filas.Item(2)
            totalesSA2(2) += filas.Item(3)
            totalesSA2(3) += filas.Item(4)
            totalesSA2(4) += filas.Item(5)
            totalesSA2(5) += filas.Item(6)
            totalesSA2(6) += filas.Item(7)
            totalesSA2(7) += filas.Item(8)
            totalesSA2(8) += filas.Item(9)
        Next

        Dim total_repSimpleRep As Double = totalesSA2(0) + totalesSA2(1) + totalesSA2(2) + totalesSA2(3) + totalesSA2(4) + totalesSA2(5) + totalesSA2(6) + totalesSA2(7) + totalesSA2(8) + totalesSA2(9)
        total_repSimple = total_repSimpleRep + total_repReestructuraRep

        If ComboSucursal.SelectedValue <> "99" Then
            csimple = total_repSimple
        End If

        If ComboSucursal.SelectedValue = "99" Then
            For Each filas As DataRow In dtReporte1.Rows
                filas.Item(1) = porcentaje_cs(total_repSimpleRep, filas.Item(1), csimple - (total_repSimpleRep + total_repSimple))
                filas.Item(2) = porcentaje_cs(total_repSimpleRep, filas.Item(2), csimple - (total_repSimpleRep + total_repSimple))
                filas.Item(3) = porcentaje_cs(total_repSimpleRep, filas.Item(3), csimple - (total_repSimpleRep + total_repSimple))
                filas.Item(4) = porcentaje_cs(total_repSimpleRep, filas.Item(4), csimple - (total_repSimpleRep + total_repSimple))
                filas.Item(5) = porcentaje_cs(total_repSimpleRep, filas.Item(5), csimple - (total_repSimpleRep + total_repSimple))
                filas.Item(6) = porcentaje_cs(total_repSimpleRep, filas.Item(6), csimple - (total_repSimpleRep + total_repSimple))
                filas.Item(7) = porcentaje_cs(total_repSimpleRep, filas.Item(7), csimple - (total_repSimpleRep + total_repSimple))
                filas.Item(8) = porcentaje_cs(total_repSimpleRep, filas.Item(8), csimple - (total_repSimpleRep + total_repSimple))
                filas.Item(9) = porcentaje_cs(total_repSimpleRep, filas.Item(9), csimple - (total_repSimpleRep + total_repSimple))
            Next
        End If

        dtReporte1.WriteXml("c:\Files\dtSimpleA.xml", XmlWriteMode.WriteSchema)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPSimple1 += filas.Item(1)
            Else
                CPSimple1 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPSimple1 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteSimpleB"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If (cTipar = "S") And drAnexo("Reestructura") <> "S" Then
                    'If cTipar = "S" And Trim(drAnexo("CNEmpresa")) <> "" And drAnexo("anexo") <> "32740002" And drAnexo("anexo") <> "32350001" And drAnexo("anexo") <> "28990002" And drAnexo("anexo") <> "34270001" And drAnexo("anexo") <> "20970004" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "", "X", "", "X")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"
        dtReporte1.WriteXml("c:\Files\dtSimpleB.xml", XmlWriteMode.WriteSchema)
        Dim CPSimple2 As Decimal = 0
        Dim LPSimple2 As Decimal = 0

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPSimple2 += filas.Item(1)
            Else
                CPSimple2 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPSimple2 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteSimpleD"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If (cTipar = "S") And drAnexo("Reestructura") <> "S" Then
                    'If cTipar = "S" And Trim(drAnexo("CNEmpresa")) <> "" And drAnexo("anexo") <> "32740002" And drAnexo("anexo") <> "32350001" And drAnexo("anexo") <> "28990002" And drAnexo("anexo") <> "34270001" And drAnexo("anexo") <> "20970004" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "", "X", "X", "")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"
        dtReporte1.WriteXml("c:\Files\dtSimpleD.xml", XmlWriteMode.WriteSchema)
        Dim CPSimple4 As Decimal = 0
        Dim LPSimple4 As Decimal = 0

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPSimple4 += filas.Item(1)
            Else
                CPSimple4 += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPSimple4 += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region
#End Region

#Region "ReestructurasLI"
        Dim total_repReestructuraLI As Double = 0

#Region "ReporteReestructurasCLI"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "L" And drAnexo("Reestructura") = "S" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "X", "", "X", "")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        Dim CPReestructuras3LI As Decimal = 0
        Dim LPReestructuras3LI As Decimal = 0


        Dim totalesREB2LI(9) As Double

        For Each filas As DataRow In dtReporte1.Rows
            totalesREB2LI(0) += filas.Item(1)
            totalesREB2LI(1) += filas.Item(2)
            totalesREB2LI(2) += filas.Item(3)
            totalesREB2LI(3) += filas.Item(4)
            totalesREB2LI(4) += filas.Item(5)
            totalesREB2LI(5) += filas.Item(6)
            totalesREB2LI(6) += filas.Item(7)
            totalesREB2LI(7) += filas.Item(8)
            totalesREB2LI(8) += filas.Item(9)
            totalesREB2LI(9) += filas.Item(10)
        Next

        total_repReestructuraLI = totalesREB2LI(0) + totalesREB2LI(1) + totalesREB2LI(2) + totalesREB2LI(3) + totalesREB2LI(4) + totalesREB2LI(5) + totalesREB2LI(6) + totalesREB2LI(7) + totalesREB2LI(8) + totalesREB2LI(9)

        dtReporte1.WriteXml("c:\Files\dtReestructurasCLI.xml", XmlWriteMode.WriteSchema)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPReestructuras3LI += filas.Item(1)
            Else
                CPReestructuras3LI += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPReestructuras3LI += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteReestructurasBLI"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "L" And drAnexo("Reestructura") = "S" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "", "X", "", "X")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        Dim CPReestructuras2LI As Decimal = 0
        Dim LPReestructuras2LI As Decimal = 0

        dtReporte1.WriteXml("c:\Files\dtReestructurasBLI.xml", XmlWriteMode.WriteSchema)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPReestructuras2LI += filas.Item(1)
            Else
                CPReestructuras2LI += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPReestructuras2LI += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteReestructurasALI"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "L" And drAnexo("Reestructura") = "S" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "X", "", "", "X")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        Dim CPReestructuras1LI As Decimal = 0
        Dim LPReestructuras1LI As Decimal = 0

        Dim totalesRsA2LI(9) As Double

        For Each filas As DataRow In dtReporte1.Rows
            totalesRsA2LI(0) += filas.Item(1)
            totalesRsA2LI(1) += filas.Item(2)
            totalesRsA2LI(2) += filas.Item(3)
            totalesRsA2LI(3) += filas.Item(4)
            totalesRsA2LI(4) += filas.Item(5)
            totalesRsA2LI(5) += filas.Item(6)
            totalesRsA2LI(6) += filas.Item(7)
            totalesRsA2LI(7) += filas.Item(8)
            totalesRsA2LI(8) += filas.Item(9)
        Next

        Dim total_repReestructuraRepli As Double = totalesRsA2LI(0) + totalesRsA2LI(1) + totalesRsA2LI(2) + totalesRsA2LI(3) + totalesRsA2LI(4) + totalesRsA2LI(5) + totalesRsA2LI(6) + totalesRsA2LI(7) + totalesRsA2LI(8) + totalesRsA2LI(9)

        For Each filas As DataRow In dtReporte1.Rows
            filas.Item(1) = filas.Item(1)
            filas.Item(2) = filas.Item(2)
            filas.Item(3) = filas.Item(3)
            filas.Item(4) = filas.Item(4)
            filas.Item(5) = filas.Item(5)
            filas.Item(6) = filas.Item(8)
            filas.Item(7) = filas.Item(7)
            filas.Item(8) = filas.Item(8)
        Next

        dtReporte1.WriteXml("c:\Files\dtReestructurasALI.xml", XmlWriteMode.WriteSchema)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPReestructuras1LI += filas.Item(1)
            Else
                CPReestructuras1LI += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPReestructuras1LI += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteReestructurasDLI"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "L" And drAnexo("Reestructura") = "S" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "", "X", "X", "")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"
        dtReporte1.WriteXml("c:\Files\dtReestructurasDLI.xml", XmlWriteMode.WriteSchema)
        Dim CPReestructuras4LI As Decimal = 0
        Dim LPReestructuras4LI As Decimal = 0

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPReestructuras1LI += filas.Item(1)
            Else
                CPReestructuras1LI += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPReestructuras1LI += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#End Region
        '----------------------********************
#Region "Credito LI"
        Dim total_repSimpleLI As Double = 0
#Region "ReporteLIC"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "L" And drAnexo("Reestructura") <> "S" Then
                    'If cTipar = "S" And Trim(drAnexo("CNEmpresa")) <> "" And drAnexo("anexo") <> "32740002" And drAnexo("anexo") <> "32350001" And drAnexo("anexo") <> "28990002" And drAnexo("anexo") <> "34270001" And drAnexo("anexo") <> "20970004" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "X", "", "X", "")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        Dim CPSimple3LI As Decimal = 0
        Dim LPSimple3LI As Decimal = 0
        Dim totalesS2LI(9) As Double

        For Each filas As DataRow In dtReporte1.Rows
            totalesS2LI(0) += filas.Item(1)
            totalesS2LI(1) += filas.Item(2)
            totalesS2LI(2) += filas.Item(3)
            totalesS2LI(3) += filas.Item(4)
            totalesS2LI(4) += filas.Item(5)
            totalesS2LI(5) += filas.Item(6)
            totalesS2LI(6) += filas.Item(7)
            totalesS2LI(7) += filas.Item(8)
            totalesS2LI(8) += filas.Item(9)
        Next

        total_repSimpleLI = totalesS2LI(0) + totalesS2LI(1) + totalesS2LI(2) + totalesS2LI(3) + totalesS2LI(4) + totalesS2LI(5) + totalesS2LI(6) + totalesS2LI(7) + totalesS2LI(8) + totalesS2LI(9)

        dtReporte1.WriteXml("c:\Files\dtSimpleCLI.xml", XmlWriteMode.WriteSchema)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPSimple3LI += filas.Item(1)
            Else
                CPSimple3LI += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPSimple3LI += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteLIA"
        '*************************************************************************************************************************************************************
        dtReporte1.Clear()
        dtReporteAcum.Clear()

        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If (cTipar = "L") And drAnexo("Reestructura") <> "S" Then
                    'If cTipar = "S" And Trim(drAnexo("CNEmpresa")) <> "" And drAnexo("anexo") <> "32740002" And drAnexo("anexo") <> "32350001" And drAnexo("anexo") <> "28990002" And drAnexo("anexo") <> "34270001" And drAnexo("anexo") <> "20970004" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "X", "", "", "X")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        Dim CPSimple1LI As Decimal = 0
        Dim LPSimple1LI As Decimal = 0

        Dim totalesSA2LI(9) As Double

        For Each filas As DataRow In dtReporte1.Rows
            totalesSA2LI(0) += filas.Item(1)
            totalesSA2LI(1) += filas.Item(2)
            totalesSA2LI(2) += filas.Item(3)
            totalesSA2LI(3) += filas.Item(4)
            totalesSA2LI(4) += filas.Item(5)
            totalesSA2LI(5) += filas.Item(6)
            totalesSA2LI(6) += filas.Item(7)
            totalesSA2LI(7) += filas.Item(8)
            totalesSA2LI(8) += filas.Item(9)
        Next

        Dim total_repSimpleRepLI As Double = totalesSA2LI(0) + totalesSA2LI(1) + totalesSA2LI(2) + totalesSA2LI(3) + totalesSA2LI(4) + totalesSA2LI(5) + totalesSA2LI(6) + totalesSA2LI(7) + totalesSA2LI(8) + totalesSA2LI(9)
        total_repSimpleLI = total_repSimpleLI + total_repReestructuraRepli

        If ComboSucursal.SelectedValue <> "99" Then
            csimpleLI = total_repSimpleLI
        End If

        If ComboSucursal.SelectedValue = "99" Then
            For Each filas As DataRow In dtReporte1.Rows
                filas.Item(1) = porcentaje_cs(total_repSimpleRepLI, filas.Item(1), csimpleLI - (total_repSimpleRepLI + total_repSimpleLI))
                filas.Item(2) = porcentaje_cs(total_repSimpleRepLI, filas.Item(2), csimpleLI - (total_repSimpleRepLI + total_repSimpleLI))
                filas.Item(3) = porcentaje_cs(total_repSimpleRepLI, filas.Item(3), csimpleLI - (total_repSimpleRepLI + total_repSimpleLI))
                filas.Item(4) = porcentaje_cs(total_repSimpleRepLI, filas.Item(4), csimpleLI - (total_repSimpleRepLI + total_repSimpleLI))
                filas.Item(5) = porcentaje_cs(total_repSimpleRepLI, filas.Item(5), csimpleLI - (total_repSimpleRepLI + total_repSimpleLI))
                filas.Item(6) = porcentaje_cs(total_repSimpleRepLI, filas.Item(6), csimpleLI - (total_repSimpleRepLI + total_repSimpleLI))
                filas.Item(7) = porcentaje_cs(total_repSimpleRepLI, filas.Item(7), csimpleLI - (total_repSimpleRepLI + total_repSimpleLI))
                filas.Item(8) = porcentaje_cs(total_repSimpleRepLI, filas.Item(8), csimpleLI - (total_repSimpleRepLI + total_repSimpleLI))
                filas.Item(9) = porcentaje_cs(total_repSimpleRepLI, filas.Item(9), csimpleLI - (total_repSimpleRepLI + total_repSimpleLI))
            Next
        End If

        dtReporte1.WriteXml("c:\Files\dtSimpleALI.xml", XmlWriteMode.WriteSchema)

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPSimple1LI += filas.Item(1)
            Else
                CPSimple1LI += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPSimple1LI += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteSimpleBLI"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If cTipar = "L" And drAnexo("Reestructura") <> "S" Then
                    'If cTipar = "S" And Trim(drAnexo("CNEmpresa")) <> "" And drAnexo("anexo") <> "32740002" And drAnexo("anexo") <> "32350001" And drAnexo("anexo") <> "28990002" And drAnexo("anexo") <> "34270001" And drAnexo("anexo") <> "20970004" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "", "X", "", "X")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"
        dtReporte1.WriteXml("c:\Files\dtSimpleBLI.xml", XmlWriteMode.WriteSchema)
        Dim CPSimple2LI As Decimal = 0
        Dim LPSimple2LI As Decimal = 0

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPSimple2LI += filas.Item(1)
            Else
                CPSimple2LI += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPSimple2LI += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region

#Region "ReporteSimpleDLI"
        '*************************************************************************************************************************************************************
        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")
            'nTasa = drAnexo("Tasas")

            'exclulle castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                If (cTipar = "L") And drAnexo("Reestructura") <> "S" Then
                    'If cTipar = "S" And Trim(drAnexo("CNEmpresa")) <> "" And drAnexo("anexo") <> "32740002" And drAnexo("anexo") <> "32350001" And drAnexo("anexo") <> "28990002" And drAnexo("anexo") <> "34270001" And drAnexo("anexo") <> "20970004" Then
                    Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar, "", "X", "X", "")
                End If
            End If
        Next

        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        'DataGridView1.DataSource = dvReporte1
        'DataGridView2.DataSource = dvReporteX
        'DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"
        dtReporte1.WriteXml("c:\Files\dtSimpleDLI.xml", XmlWriteMode.WriteSchema)
        Dim CPSimple4LI As Decimal = 0
        Dim LPSimple4LI As Decimal = 0

        For Each filas As DataRow In dtReporte1.Rows
            If FechaAux.Month = 12 Then
                CPSimple4LI += filas.Item(1)
            Else
                CPSimple4LI += filas.Item(1)
                If filas.Item(0) <= FechaAux.Month Then
                    CPSimple4LI += filas.Item(2)
                End If
            End If
        Next
        dtReporte1.Clear()
        dtReporteAcum.Clear()
#End Region
#End Region
        '----------------------********************
#Region "CC"
        Dim total_cc As Decimal = 0
        Dim CPCC As Decimal = 0
        Dim LPCC As Decimal = 0

        banderaTotal = False
        'If RBcc.Checked = True Then
        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        sacaAVCC("C", Suc1, Suc2, FechaAux)


        ' End If

        For Each filas As DataRow In dtReporte1.Rows
            Dim mes_a As Date = CDate("01/" & filas.Item(0) & "/2019")
            Dim n_mes As Integer = Format(mes_a, "MM")
            If FechaAux.Month = 12 Then
                n_mes = 12
            End If
            If n_mes >= FechaAux.Month Then
                CPCC += filas.Item(1)
            End If
            If n_mes <= FechaAux.Month Then
                LPCC += filas.Item(2)
            End If
        Next

        total_cc = LPCC + CPCC

        If ComboSucursal.SelectedValue <> "99" Then
            ccorriente = total_cc
        End If

        If ComboSucursal.SelectedValue = "99" Then
            For Each filas As DataRow In dtReporte1.Rows
                filas.Item(1) = TruncateDecimal(porcentaje_cs(ccorriente, filas.Item(1), TruncateDecimal(ccorriente - total_cc, 8)), 2)
                filas.Item(2) = TruncateDecimal(porcentaje_cs(ccorriente, filas.Item(2), TruncateDecimal(ccorriente - total_cc, 8)), 2)
                filas.Item(3) = TruncateDecimal(porcentaje_cs(ccorriente, filas.Item(3), TruncateDecimal(ccorriente - total_cc, 8)), 2)
                filas.Item(4) = TruncateDecimal(porcentaje_cs(ccorriente, filas.Item(4), TruncateDecimal(ccorriente - total_cc, 8)), 2)
                filas.Item(5) = TruncateDecimal(porcentaje_cs(ccorriente, filas.Item(5), TruncateDecimal(ccorriente - total_cc, 8)), 2)
                filas.Item(6) = TruncateDecimal(porcentaje_cs(ccorriente, filas.Item(6), TruncateDecimal(ccorriente - total_cc, 8)), 2)
                filas.Item(7) = TruncateDecimal(porcentaje_cs(ccorriente, filas.Item(7), TruncateDecimal(ccorriente - total_cc, 8)), 2)
                filas.Item(8) = TruncateDecimal(porcentaje_cs(ccorriente, filas.Item(8), TruncateDecimal(ccorriente - total_cc, 8)), 2)
                filas.Item(9) = TruncateDecimal(porcentaje_cs(ccorriente, filas.Item(9), TruncateDecimal(ccorriente - total_cc, 8)), 2)
            Next
        End If

        dtReporte1.WriteXml("c:\Files\RBcc.xml", XmlWriteMode.WriteSchema)


        dtReporte1.Clear()
        dtReporteAcum.Clear()

#End Region

#Region "AV"
        Dim CPAV As Double = 0
        Dim LPAV As Double = 0
        Dim total_avio As Double = 0

        banderaTotal = True
        'If RBav.Checked = True Then
        dvReporte1 = New DataView(dtReporte1)
        dvReporte1.Sort = "Mes"
        dvReporteX = New DataView(dtReporteAcum)
        dvReporteX.Sort = "Mes0"
        sacaAVCC("H", Suc1, Suc2, FechaAux)

        'End If

        For Each filas As DataRow In dtReporte1.Rows
            Dim mes_a As Date = CDate("01/" & filas.Item(0) & "/2019")
            Dim n_mes As Integer = Format(mes_a, "MM")
            If FechaAux.Month = 12 Then
                n_mes = 12
            End If
            If n_mes >= FechaAux.Month Then
                CPAV += filas.Item(1)
            End If
            If n_mes <= FechaAux.Month Then
                LPAV += filas.Item(2)
            End If
        Next

        total_avio = CPAV + LPAV

        If ComboSucursal.SelectedValue <> "99" Then
            cavio = total_avio
        End If

        If ComboSucursal.SelectedValue = "99" Then
            For Each filas As DataRow In dtReporte1.Rows
                filas.Item(1) = porcentaje_av(total_avio, filas.Item(1), cavio - total_avio)
                filas.Item(2) = porcentaje_av(total_avio, filas.Item(2), cavio - total_avio)
                filas.Item(3) = porcentaje_av(total_avio, filas.Item(3), cavio - total_avio)
                filas.Item(4) = porcentaje_av(total_avio, filas.Item(4), cavio - total_avio)
                filas.Item(5) = porcentaje_av(total_avio, filas.Item(5), cavio - total_avio)
                filas.Item(6) = porcentaje_av(total_avio, filas.Item(6), cavio - total_avio)
                filas.Item(7) = porcentaje_av(total_avio, filas.Item(7), cavio - total_avio)
                filas.Item(8) = porcentaje_av(total_avio, filas.Item(8), cavio - total_avio)
                filas.Item(9) = porcentaje_av(total_avio, filas.Item(9), cavio - total_avio)
            Next
        End If

        dtReporte1.WriteXml("c:\Files\RBav.xml", XmlWriteMode.WriteSchema)

        dtReporte1.Clear()
        dtReporteAcum.Clear()

#End Region

        Cursor.Current = Cursors.Default
        rpt.SetParameterValue("Sucursal", ComboSucursal.Text.Trim, "rptG_CarteraTotal")
        rpt.SetParameterValue("var_anio", cYear.ToString, "rptG_CarteraTotal")
        rpt.SetParameterValue("var_mes", FechaAux, "rptG_CarteraTotal")
        rpt.SetParameterValue("var_dia", FechaAux.Day, "rptG_CarteraTotal")

        'variables reporte general
        rpt.SetParameterValue("var_CP", CPTotal, "rptG_CarteraTotal")
        rpt.SetParameterValue("var_LP", LPTotal, "rptG_CarteraTotal")
        rpt.SetParameterValue("var_vencida", cvencida, "rptG_CarteraTotal")
        rpt.SetParameterValue("var_fac_fin", cfac_financiero, "rptG_CarteraTotal")
        rpt.SetParameterValue("var_cesion", cces_derechos, "rptG_CarteraTotal")
        rpt.SetParameterValue("var_seguros", cseguros, "rptG_CarteraTotal")
        If ComboSucursal.SelectedValue = "99" Then
            rpt.SetParameterValue("var_vencida_fac", "1500000", "rptG_CarteraTotal")
        Else
            rpt.SetParameterValue("var_vencida_fac", 0, "rptG_CarteraTotal")
        End If
        rpt.SetParameterValue("var_exigible_fac", cexigible, "rptG_CarteraTotal")

        'variables arrendamiento
        rpt.SetParameterValue("var_anio", cYear.ToString, "rptArrendamiento_1")
        rpt.SetParameterValue("var_mes", FechaAux, "rptArrendamiento_1")
        rpt.SetParameterValue("var_CP", CPArrendamiento1, "rptArrendamiento_1")
        rpt.SetParameterValue("var_LP", LPArrendamiento1, "rptArrendamiento_1")
        rpt.SetParameterValue("var_2", total_repArrendamiento, "rptArrendamiento_1")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptArrendamiento_2")
        rpt.SetParameterValue("var_mes", FechaAux, "rptArrendamiento_2")
        rpt.SetParameterValue("var_CP", CPArrendamiento2, "rptArrendamiento_2")
        rpt.SetParameterValue("var_LP", LPArrendamiento2, "rptArrendamiento_2")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptArrendamiento_3")
        rpt.SetParameterValue("var_mes", FechaAux, "rptArrendamiento_3")
        rpt.SetParameterValue("var_CP", CPArrendamiento3, "rptArrendamiento_3")
        rpt.SetParameterValue("var_LP", LPArrendamiento3, "rptArrendamiento_3")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptArrendamiento_4")
        rpt.SetParameterValue("var_mes", FechaAux, "rptArrendamiento_4")
        rpt.SetParameterValue("var_CP", CPArrendamiento4, "rptArrendamiento_4")
        rpt.SetParameterValue("var_LP", LPArrendamiento4, "rptArrendamiento_4")

        'variables refaccionario
        rpt.SetParameterValue("var_anio", cYear.ToString, "rptRefaccionario_1")
        rpt.SetParameterValue("var_mes", FechaAux, "rptRefaccionario_1")
        rpt.SetParameterValue("var_CP", CPRefaccionario1, "rptRefaccionario_1")
        rpt.SetParameterValue("var_LP", LPRefaccionario1, "rptRefaccionario_1")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptRefaccionario_2")
        rpt.SetParameterValue("var_mes", FechaAux, "rptRefaccionario_2")
        rpt.SetParameterValue("var_CP", CPRefaccionario2, "rptRefaccionario_2")
        rpt.SetParameterValue("var_LP", LPRefaccionario2, "rptRefaccionario_2")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptRefaccionario_3")
        rpt.SetParameterValue("var_mes", FechaAux, "rptRefaccionario_3")
        rpt.SetParameterValue("var_CP", CPRefaccionario3, "rptRefaccionario_3")
        rpt.SetParameterValue("var_LP", LPRefaccionario3, "rptRefaccionario_3")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptRefaccionario_4")
        rpt.SetParameterValue("var_mes", FechaAux, "rptRefaccionario_4")
        rpt.SetParameterValue("var_CP", CPRefaccionario4, "rptRefaccionario_4")
        rpt.SetParameterValue("var_LP", LPRefaccionario4, "rptRefaccionario_4")

        'variables simple
        rpt.SetParameterValue("var_anio", cYear.ToString, "rptSimple_1")
        rpt.SetParameterValue("var_mes", FechaAux, "rptSimple_1")
        rpt.SetParameterValue("var_CP", CPSimple1, "rptSimple_1")
        rpt.SetParameterValue("var_LP", LPSimple1, "rptSimple_1")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptSimple_2")
        rpt.SetParameterValue("var_mes", FechaAux, "rptSimple_2")
        rpt.SetParameterValue("var_CP", CPSimple2, "rptSimple_2")
        rpt.SetParameterValue("var_LP", LPSimple2, "rptSimple_2")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptSimple_3")
        rpt.SetParameterValue("var_mes", FechaAux, "rptSimple_3")
        rpt.SetParameterValue("var_CP", CPSimple3, "rptSimple_3")
        rpt.SetParameterValue("var_LP", LPSimple3, "rptSimple_3")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptSimple_4")
        rpt.SetParameterValue("var_mes", FechaAux, "rptSimple_4")
        rpt.SetParameterValue("var_CP", CPSimple4, "rptSimple_4")
        rpt.SetParameterValue("var_LP", LPSimple4, "rptSimple_4")

        'variables liquidez inmediata
        rpt.SetParameterValue("var_anio", cYear.ToString, "rptLiquidezInmediata1")
        rpt.SetParameterValue("var_mes", FechaAux, "rptLiquidezInmediata1")
        rpt.SetParameterValue("var_CP", CPSimple1LI, "rptLiquidezInmediata1")
        rpt.SetParameterValue("var_LP", LPSimple1LI, "rptLiquidezInmediata1")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptLiquidezInmediata2")
        rpt.SetParameterValue("var_mes", FechaAux, "rptLiquidezInmediata2")
        rpt.SetParameterValue("var_CP", CPSimple2LI, "rptLiquidezInmediata2")
        rpt.SetParameterValue("var_LP", LPSimple2LI, "rptLiquidezInmediata2")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptLiquidezInmediata3")
        rpt.SetParameterValue("var_mes", FechaAux, "rptLiquidezInmediata3")
        rpt.SetParameterValue("var_CP", CPSimple3LI, "rptLiquidezInmediata3")
        rpt.SetParameterValue("var_LP", LPSimple3LI, "rptLiquidezInmediata3")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptLiquidezInmediata4")
        rpt.SetParameterValue("var_mes", FechaAux, "rptLiquidezInmediata4")
        rpt.SetParameterValue("var_CP", CPSimple4LI, "rptLiquidezInmediata4")
        rpt.SetParameterValue("var_LP", LPSimple4LI, "rptLiquidezInmediata4")

        'variables liquidez inmediata reestructiras
        rpt.SetParameterValue("var_anio", cYear.ToString, "rptLiquidezInmediataReest1")
        rpt.SetParameterValue("var_mes", FechaAux, "rptLiquidezInmediataReest1")
        rpt.SetParameterValue("var_CP", LPReestructuras1LI, "rptLiquidezInmediataReest1")
        rpt.SetParameterValue("var_LP", LPReestructuras1LI, "rptLiquidezInmediataReest1")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptLiquidezInmediataReest2")
        rpt.SetParameterValue("var_mes", FechaAux, "rptLiquidezInmediataReest2")
        rpt.SetParameterValue("var_CP", LPReestructuras2LI, "rptLiquidezInmediataReest2")
        rpt.SetParameterValue("var_LP", LPReestructuras2LI, "rptLiquidezInmediataReest2")

        'rpt.SetParameterValue("var_anio", cYear.ToString, "rptLiquidezInmediata3")
        'rpt.SetParameterValue("var_mes", FechaAux, "rptLiquidezInmediata3")
        'rpt.SetParameterValue("var_CP", CPSimple3LI, "rptLiquidezInmediata3")
        'rpt.SetParameterValue("var_LP", LPSimple3LI, "rptLiquidezInmediata3")

        'rpt.SetParameterValue("var_anio", cYear.ToString, "rptLiquidezInmediata4")
        'rpt.SetParameterValue("var_mes", FechaAux, "rptLiquidezInmediata4")
        'rpt.SetParameterValue("var_CP", CPSimple4LI, "rptLiquidezInmediata4")
        'rpt.SetParameterValue("var_LP", LPSimple4LI, "rptLiquidezInmediata4")

        'variables reestrtucturas
        rpt.SetParameterValue("var_anio", cYear.ToString, "rptSubinforme_1")
        rpt.SetParameterValue("var_mes", FechaAux, "rptSubinforme_1")
        rpt.SetParameterValue("var_CP", CPReestructuras1, "rptSubinforme_1")
        rpt.SetParameterValue("var_LP", LPReestructuras1, "rptSubinforme_1")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptSubinforme_2")
        rpt.SetParameterValue("var_mes", FechaAux, "rptSubinforme_2")
        rpt.SetParameterValue("var_CP", CPReestructuras2, "rptSubinforme_2")
        rpt.SetParameterValue("var_LP", LPReestructuras2, "rptSubinforme_2")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptSubinforme_3")
        rpt.SetParameterValue("var_mes", FechaAux, "rptSubinforme_3")
        rpt.SetParameterValue("var_CP", CPReestructuras3, "rptSubinforme_3")
        rpt.SetParameterValue("var_LP", LPReestructuras3, "rptSubinforme_3")

        rpt.SetParameterValue("var_anio", cYear.ToString, "rptSubinforme_4")
        rpt.SetParameterValue("var_mes", FechaAux, "rptSubinforme_4")
        rpt.SetParameterValue("var_CP", CPReestructuras4, "rptSubinforme_4")
        rpt.SetParameterValue("var_LP", LPReestructuras4, "rptSubinforme_4")

        'variables CC y AV
        rpt.SetParameterValue("var_mes", CPCC, "rptSubinforme_AV")
        rpt.SetParameterValue("var_mes", CPAV, "rptSubinformeCC")

        frmProyectaRep.CrystalReportViewer1.ReportSource = rpt
        frmProyectaRep.Refresh()
        frmProyectaRep.Show()
        'frmProyectaRep.CrystalReportViewer1.Refresh()

        'Dim ruta As String = "E:\" & Date.Now.ToString("yyyyMMddmmss") & ".xls"
        'rpt.ExportToDisk(ExportFormatType.Excel, ruta)

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
        Total = Total

    End Sub

    Private Sub Proyecta(ByVal cCliente As String, ByVal cAnexo As String, ByVal drAnexo As DataRow, ByVal cTipta As String, ByVal cTipar As String, ByVal Capital As String, ByVal Interes As String, ByVal PRSi As String, ByVal PRNo As String)
        ' Declaración de variables de conexión ADO .NET


        Dim drEdocta As DataRow
        Dim drEstados As DataRow()
        Dim drFacturas As DataRow()
        Dim drTemp As DataRow
        Dim drTempX As DataRow

        ' Declaración de variables de datos

        Dim cMonth As String
        Dim cMonthX As String
        Dim cYearPayment As String
        Dim lConsiderar As Boolean = False
        Dim nCounter As Integer
        Dim nMaxCounter As Integer = 100
        Dim nMonto As Decimal
        Dim nMontoI As Decimal
        Dim cOrigen As String = ""
        Dim cCiclo As String = ""
        Dim cad As String = ""
        Dim CliNom As String = ""
        Dim nMontoC As Decimal
        Dim nMontoL As Decimal
        Dim nMontoIC As Decimal
        Dim nMontoIL As Decimal
        Dim cAnexoX As String = ""
        Dim cTiparX As String = ""


        ' 00006 MOLINOS DEL SUDESTE
        ' 00015 PELICULAS PLASTICAS
        ' 00044 PAPELES CORRUGADOS
        ' 00045 CONSTRUCTORA Y URBANIZADORA PEGASO
        ' 00061 OPISEC
        ' 00066 TABLEX
        ' 00353 COMERCIALIZADORA LA MODERNA DE TOLUCA
        ' 00426 FABRICA DE GALLETAS LA MODERNA
        ' 00454 VICTORIA EUGENIA SAINT MARTIN DE MONROY
        ' 00457 CIA. NACIONAL DE HARINAS
        ' 00606 LA MODERNA DE OCCIDENTE
        ' 00676 PRODUCTOS ALIMENTICIOS LA MODERNA
        ' 00719 ARTE DIGITAL DE MEXICO
        ' 00898 TABLEX MILLER
        ' 01054 MOLINOS DEL FENIX
        ' 01101 CONCRETOS Y ASFALTOS DE TOLUCA
        ' 01455 CORPORATIVO LA MODERNA
        ' 01521 IMPULSORA DE BIENES INMUEBLES DE TOLUCA
        ' 01591 DEL REY INN HOTEL
        ' 01666 PASTAS CORA
        ' 02488 QUINTA DEL REY HOTEL
        ' 03193 GRUPO LA MODERNA
        ' 03348 TRANSPORTES ESPECIALIZADOS ROBLES NAVARRO
        ' 03671 SERVICIOS ARFIN
        ' 03921 JOSE ANTONIO MONROY CARRILLO
        ' 05107 HARINERA LOS PIRINEOS SA DE CV
        ' 05317 MCLIGHT OPERADORA SA DE CV
        ' 05318 INMOBILIARIA MEXICANA TURISTICA SA DE CV
        ' 05321 HARINERA LOS PIRINEOS SA DE CV (SUCURSAL IRAPUATO)

        If PRSi = "X" Then

            ' Solo considera contratos de créditos con partes relacionadas

            If InStr("00006|00015|00044|00045|00061|00066|00353|00426|00454|00457|00606|00676|00719|00898|01054|01101|01455|01521|01591|01666|02488|03193|03348|03671|03921|05107|05214|05317|05318|05321", cCliente) > 0 Then
                lConsiderar = True
                cad = "Relacionados" & vbTab
            End If

        ElseIf PRNo = "X" Then
            cad = "No Relacionados" & vbTab
            ' Solo considera contratos de créditos que no sean con partes relacionadas
            Dim x As Integer = InStr("00006|00015|00044|00045|00061|00066|00353|00426|00454|00457|00606|00676|00719|00898|01054|01101|01455|01521|01591|01666|02488|03193|03348|03671|03921|05107|05214|05317|05318|05321", cCliente)
            If InStr("00006|00015|00044|00045|00061|00066|00353|00426|00454|00457|00606|00676|00719|00898|01054|01101|01455|01521|01591|01666|02488|03193|03348|03671|03921|05107|05214|05317|05318|05321", cCliente) = 0 Then
                lConsiderar = True
            End If
        End If

        If Capital = "X" Then
            cad = cad & "Capital"
        ElseIf Interes = "X" = True Then
            cad = cad & "Interes"
        End If

        nCounter = 0
        drFacturas = drAnexo.GetChildRows("AnexoFacturas")
        CalcAnti(cAnexo, cFecha, nMaxCounter, nCounter, drFacturas)

        If lConsiderar = True And nCounter <= nMaxCounter Then

            drEstados = drAnexo.GetChildRows("AnexoEdoctav")


            For Each drEdocta In drEstados
                cOrigen = drEdocta("origen")

                If drEdocta("Feven") > cFecha And drEdocta("Nufac") <> 9999999 And cOrigen = "Contratos" Then
                    CliNom = drEdocta("Descr")
                    cYearPayment = Mid(drEdocta("Feven"), 1, 4)
                    cMonth = Mid(drEdocta("Feven"), 5, 2)
                    cMonthX = MonthName(Val(Mid(drEdocta("Feven"), 5, 2)))
                    If Capital = "X" Then
                        nMonto = drEdocta("Abcap")
                    ElseIf Interes = "X" Then
                        nMonto = drEdocta("Inter")
                    End If


                    drTemp = dtReporte1.Rows.Find(cMonth)

                    f1.WriteLine(cAnexo & vbTab & CliNom & vbTab & cTipar & vbTab & nMonto & vbTab & cMonth & vbTab & cad & vbTab & cOrigen)
                    If drTemp Is Nothing Then

                        ' El mes no existe en la tabla

                        drTemp = dtReporte1.NewRow()
                        drTemp("Mes") = cMonth
                        drTemp(cYear) = IIf(cYearPayment = cYear, nMonto, 0)
                        drTemp(CStr(Val(cYear) + 1)) = IIf(cYearPayment = CStr(Val(cYear) + 1), nMonto, 0)
                        drTemp(CStr(Val(cYear) + 2)) = IIf(cYearPayment = CStr(Val(cYear) + 2), nMonto, 0)
                        drTemp(CStr(Val(cYear) + 3)) = IIf(cYearPayment = CStr(Val(cYear) + 3), nMonto, 0)
                        drTemp(CStr(Val(cYear) + 4)) = IIf(cYearPayment = CStr(Val(cYear) + 4), nMonto, 0)
                        drTemp(CStr(Val(cYear) + 5)) = IIf(cYearPayment = CStr(Val(cYear) + 5), nMonto, 0)
                        drTemp(CStr(Val(cYear) + 6)) = IIf(cYearPayment = CStr(Val(cYear) + 6), nMonto, 0)
                        drTemp(CStr(Val(cYear) + 7)) = IIf(cYearPayment = CStr(Val(cYear) + 7), nMonto, 0)
                        drTemp(CStr(Val(cYear) + 8)) = IIf(cYearPayment = CStr(Val(cYear) + 8), nMonto, 0)
                        drTemp(CStr(Val(cYear) + 9)) = IIf(cYearPayment = CStr(Val(cYear) + 8), nMonto, 0)
                        drTemp(CStr(Val(cYear) + 10)) = IIf(cYearPayment = CStr(Val(cYear) + 8), nMonto, 0)
                        dtReporte1.Rows.Add(drTemp)

                    Else

                        ' El mes ya existe en la tabla

                        Select Case cYearPayment
                            Case cYear
                                drTemp(cYear) += nMonto
                            Case CStr(Val(cYear) + 1)
                                drTemp(CStr(Val(cYear) + 1)) += nMonto
                            Case CStr(Val(cYear) + 2)
                                drTemp(CStr(Val(cYear) + 2)) += nMonto
                            Case CStr(Val(cYear) + 3)
                                drTemp(CStr(Val(cYear) + 3)) += nMonto
                            Case CStr(Val(cYear) + 4)
                                drTemp(CStr(Val(cYear) + 4)) += nMonto
                            Case CStr(Val(cYear) + 5)
                                drTemp(CStr(Val(cYear) + 5)) += nMonto
                            Case CStr(Val(cYear) + 6)
                                drTemp(CStr(Val(cYear) + 6)) += nMonto
                            Case CStr(Val(cYear) + 7)
                                drTemp(CStr(Val(cYear) + 7)) += nMonto
                            Case CStr(Val(cYear) + 8)
                                drTemp(CStr(Val(cYear) + 8)) += nMonto
                            Case CStr(Val(cYear) + 9)
                                drTemp(CStr(Val(cYear) + 9)) += nMonto
                            Case CStr(Val(cYear) + 10)
                                drTemp(CStr(Val(cYear) + 10)) += nMonto
                        End Select
                    End If

                End If
                'MsgBox(drTemp(CStr(Val(cYear) + 4)).ToString)

            Next
            'MsgBox(nMonto.ToString)
        End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'nCounter = 0
        'drFacturas = drAnexo.GetChildRows("AnexoFacturas")
        'CalcAnti(cAnexo, cFecha, nMaxCounter, nCounter, drFacturas)
        'If nCounter <= nMaxCounter Then

        drEstados = drAnexo.GetChildRows("AnexoEdoctav")
        For Each drEdocta In drEstados

            If (drEdocta("Feven") > cFecha) And drEdocta("Nufac") <> 9999999 Then

                If InStr("00006|00015|00044|00045|00061|00066|00353|00426|00454|00457|00606|00676|00719|00898|01054|01101|01455|01521|01591|01666|02488|03193|03348|03671|03921|05107|05214|05317|05318|05321", cCliente) > 0 Then
                    cad = "Relacionados"
                Else
                    cad = "No Relacionados"
                End If
                cAnexoX = Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4)
                cOrigen = drEdocta("origen")
                If cOrigen = "Contratos" Or cOrigen = "Contratos Otros" Then
                    drTemp = dtVenAn.Rows.Find(cAnexoX)
                    If drTemp Is Nothing Then
                        cOrigen = "Contratos Vigentes"
                    Else
                        cOrigen = "Contratos Vencidos"
                    End If
                End If
                If cOrigen = "Seguros" Then
                    drTemp = dtVenAn.Rows.Find(cAnexoX)
                    If drTemp Is Nothing Then
                        cOrigen = "Seguros Vigentes"
                    Else
                        cOrigen = "Seguros Vencidos"
                    End If
                End If

                If cOrigen = "Avios" Then
                    cAnexoX = Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & drEdocta("letra")
                    If cTipar = "C" Then
                        cOrigen = "Cuenta Corriente"
                    End If
                    drTemp = dtVenAv.Rows.Find(cAnexoX)
                    If drTemp Is Nothing Then
                        cOrigen = cOrigen & " Vigentes"
                    Else
                        cOrigen = cOrigen & " Vencidos"
                    End If
                End If

                If cOrigen = "Garantias" Then
                    cTiparX = cTipar
                    cTipar = "S"
                End If

                cYearPayment = Mid(drEdocta("Feven"), 1, 4)
                cMonth = Mid(drEdocta("Feven"), 5, 2)
                cMonthX = MonthName(Val(Mid(drEdocta("Feven"), 5, 2)))
                Total = Total + drEdocta("Abcap")
                CliNom = drEdocta("Descr")

                nMonto = drEdocta("Abcap")
                nMontoI = drEdocta("Inter")

                If drEdocta("Feven") <= cFechaCortoPalzo Then
                    nMontoC = drEdocta("Abcap")
                    nMontoIC = drEdocta("Inter")
                    nMontoL = 0
                    nMontoIL = 0
                Else
                    nMontoL = drEdocta("Abcap")
                    nMontoIL = drEdocta("Inter")
                    nMontoC = 0
                    nMontoIC = 0
                End If

                drTempX = dtReporteAcum.Rows.Find(cMonthX)
                f2.WriteLine(cAnexo & vbTab & CliNom & vbTab & cTipar & vbTab & nMonto & vbTab & nMontoI & vbTab & cad & vbTab & cOrigen & vbTab & nMontoC & vbTab & nMontoIC & vbTab & nMontoL & vbTab & nMontoIL & vbTab & drEdocta("FechaIni") & vbTab & drEdocta("Feven"))

                If cOrigen = "Garantias" Then
                    cTipar = cTiparX
                End If

                'nMonto = drEdocta("Abcap") + drEdocta("Inter")

                If drTempX Is Nothing Then

                    ' El mes no existe en la tabla

                    drTempX = dtReporteAcum.NewRow()
                    drTempX("Mes") = cMonthX
                    drTempX("Mes0") = cMonth

                    drTempX(CStr(Val(cYear) + 0) & "Fija") = 0
                    drTempX(CStr(Val(cYear) + 1) & "Fija") = 0
                    drTempX(CStr(Val(cYear) + 2) & "Fija") = 0
                    drTempX(CStr(Val(cYear) + 3) & "Fija") = 0
                    drTempX(CStr(Val(cYear) + 4) & "Fija") = 0
                    drTempX(CStr(Val(cYear) + 5) & "Fija") = 0
                    drTempX(CStr(Val(cYear) + 6) & "Fija") = 0
                    drTempX(CStr(Val(cYear) + 7) & "Fija") = 0
                    drTempX(CStr(Val(cYear) + 8) & "Fija") = 0
                    drTempX(CStr(Val(cYear) + 9) & "Fija") = 0
                    drTempX(CStr(Val(cYear) + 10) & "Fija") = 0

                    drTempX(CStr(Val(cYear) + 0) & "Variable") = 0
                    drTempX(CStr(Val(cYear) + 1) & "Variable") = 0
                    drTempX(CStr(Val(cYear) + 2) & "Variable") = 0
                    drTempX(CStr(Val(cYear) + 3) & "Variable") = 0
                    drTempX(CStr(Val(cYear) + 4) & "Variable") = 0
                    drTempX(CStr(Val(cYear) + 5) & "Variable") = 0
                    drTempX(CStr(Val(cYear) + 6) & "Variable") = 0
                    drTempX(CStr(Val(cYear) + 7) & "Variable") = 0
                    drTempX(CStr(Val(cYear) + 8) & "Variable") = 0
                    drTempX(CStr(Val(cYear) + 9) & "Variable") = 0
                    drTempX(CStr(Val(cYear) + 10) & "Variable") = 0


                    drTempX(cYear) = IIf(cYearPayment = cYear, nMonto, 0)
                    If cTipta = "7" Then
                        drTempX(cYear & "Fija") = IIf(cYearPayment = cYear, nMonto, 0)
                    Else
                        drTempX(cYear & "Variable") = IIf(cYearPayment = cYear, nMonto, 0)
                    End If
                    drTempX(CStr(Val(cYear) + 1)) = IIf(cYearPayment = CStr(Val(cYear) + 1), nMonto, 0)
                    If cTipta = "7" Then
                        drTempX(CStr(Val(cYear) + 1) & "Fija") = IIf(cYearPayment = CStr(Val(cYear) + 1), nMonto, 0)
                    Else
                        drTempX(CStr(Val(cYear) + 1) & "Variable") = IIf(cYearPayment = CStr(Val(cYear) + 1), nMonto, 0)
                    End If
                    drTempX(CStr(Val(cYear) + 2)) = IIf(cYearPayment = CStr(Val(cYear) + 2), nMonto, 0)
                    If cTipta = "7" Then
                        drTempX(CStr(Val(cYear) + 2) & "Fija") = IIf(cYearPayment = CStr(Val(cYear) + 2), nMonto, 0)
                    Else
                        drTempX(CStr(Val(cYear) + 2) & "Variable") = IIf(cYearPayment = CStr(Val(cYear) + 2), nMonto, 0)
                    End If
                    drTempX(CStr(Val(cYear) + 3)) = IIf(cYearPayment = CStr(Val(cYear) + 3), nMonto, 0)
                    If cTipta = "7" Then
                        drTempX(CStr(Val(cYear) + 3) & "Fija") = IIf(cYearPayment = CStr(Val(cYear) + 3), nMonto, 0)
                    Else
                        drTempX(CStr(Val(cYear) + 3) & "Variable") = IIf(cYearPayment = CStr(Val(cYear) + 3), nMonto, 0)
                    End If
                    drTempX(CStr(Val(cYear) + 4)) = IIf(cYearPayment = CStr(Val(cYear) + 4), nMonto, 0)
                    If cTipta = "7" Then
                        drTempX(CStr(Val(cYear) + 4) & "Fija") = IIf(cYearPayment = CStr(Val(cYear) + 4), nMonto, 0)
                    Else
                        drTempX(CStr(Val(cYear) + 4) & "Variable") = IIf(cYearPayment = CStr(Val(cYear) + 4), nMonto, 0)
                    End If
                    drTempX(CStr(Val(cYear) + 5)) = IIf(cYearPayment = CStr(Val(cYear) + 5), nMonto, 0)
                    If cTipta = "7" Then
                        drTempX(CStr(Val(cYear) + 5) & "Fija") = IIf(cYearPayment = CStr(Val(cYear) + 5), nMonto, 0)
                    Else
                        drTempX(CStr(Val(cYear) + 5) & "Variable") = IIf(cYearPayment = CStr(Val(cYear) + 5), nMonto, 0)
                    End If
                    drTempX(CStr(Val(cYear) + 6)) = IIf(cYearPayment = CStr(Val(cYear) + 6), nMonto, 0)
                    If cTipta = "7" Then
                        drTempX(CStr(Val(cYear) + 6) & "Fija") = IIf(cYearPayment = CStr(Val(cYear) + 6), nMonto, 0)
                    Else
                        drTempX(CStr(Val(cYear) + 6) & "Variable") = IIf(cYearPayment = CStr(Val(cYear) + 6), nMonto, 0)
                    End If
                    drTempX(CStr(Val(cYear) + 7)) = IIf(cYearPayment = CStr(Val(cYear) + 7), nMonto, 0)
                    If cTipta = "7" Then
                        drTempX(CStr(Val(cYear) + 7) & "Fija") = IIf(cYearPayment = CStr(Val(cYear) + 7), nMonto, 0)
                    Else
                        drTempX(CStr(Val(cYear) + 7) & "Variable") = IIf(cYearPayment = CStr(Val(cYear) + 7), nMonto, 0)
                    End If
                    drTempX(CStr(Val(cYear) + 8)) = IIf(cYearPayment = CStr(Val(cYear) + 8), nMonto, 0)
                    If cTipta = "7" Then
                        drTempX(CStr(Val(cYear) + 8) & "Fija") = IIf(cYearPayment = CStr(Val(cYear) + 8), nMonto, 0)
                    Else
                        drTempX(CStr(Val(cYear) + 8) & "Variable") = IIf(cYearPayment = CStr(Val(cYear) + 8), nMonto, 0)
                    End If

                    drTempX(CStr(Val(cYear) + 9)) = IIf(cYearPayment = CStr(Val(cYear) + 9), nMonto, 0)
                    If cTipta = "7" Then
                        drTempX(CStr(Val(cYear) + 9) & "Fija") = IIf(cYearPayment = CStr(Val(cYear) + 9), nMonto, 0)
                    Else
                        drTempX(CStr(Val(cYear) + 9) & "Variable") = IIf(cYearPayment = CStr(Val(cYear) + 9), nMonto, 0)
                    End If

                    drTempX(CStr(Val(cYear) + 10)) = IIf(cYearPayment = CStr(Val(cYear) + 10), nMonto, 0)
                    If cTipta = "7" Then
                        drTempX(CStr(Val(cYear) + 10) & "Fija") = IIf(cYearPayment = CStr(Val(cYear) + 10), nMonto, 0)
                    Else
                        drTempX(CStr(Val(cYear) + 10) & "Variable") = IIf(cYearPayment = CStr(Val(cYear) + 10), nMonto, 0)
                    End If
                    dtReporteAcum.Rows.Add(drTempX)

                Else

                    ' El mes ya existe en la tabla
                    Select Case cYearPayment
                        Case cYear
                            drTempX(cYear) += nMonto
                            If cTipta = "7" Then
                                drTempX(cYear & "Fija") += nMonto
                            Else
                                drTempX(cYear & "Variable") += nMonto
                            End If
                        Case CStr(Val(cYear) + 1)
                            drTempX(CStr(Val(cYear) + 1)) += nMonto
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 1) & "Fija") += nMonto
                            Else
                                drTempX(CStr(Val(cYear) + 1) & "Variable") += nMonto
                            End If
                        Case CStr(Val(cYear) + 2)
                            drTempX(CStr(Val(cYear) + 2)) += nMonto
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 2) & "Fija") += nMonto
                            Else
                                drTempX(CStr(Val(cYear) + 2) & "Variable") += nMonto
                            End If
                        Case CStr(Val(cYear) + 3)
                            drTempX(CStr(Val(cYear) + 3)) += nMonto
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 3) & "Fija") += nMonto
                            Else
                                drTempX(CStr(Val(cYear) + 3) & "Variable") += nMonto
                            End If
                        Case CStr(Val(cYear) + 4)
                            drTempX(CStr(Val(cYear) + 4)) += nMonto
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 4) & "Fija") += nMonto
                            Else
                                drTempX(CStr(Val(cYear) + 4) & "Variable") += nMonto
                            End If
                        Case CStr(Val(cYear) + 5)
                            drTempX(CStr(Val(cYear) + 5)) += nMonto
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 5) & "Fija") += nMonto
                            Else
                                drTempX(CStr(Val(cYear) + 5) & "Variable") += nMonto
                            End If
                        Case CStr(Val(cYear) + 6)
                            drTempX(CStr(Val(cYear) + 6)) += nMonto
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 6) & "Fija") += nMonto
                            Else
                                drTempX(CStr(Val(cYear) + 6) & "Variable") += nMonto
                            End If
                        Case CStr(Val(cYear) + 7)
                            drTempX(CStr(Val(cYear) + 7)) += nMonto
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 7) & "Fija") += nMonto
                            Else
                                drTempX(CStr(Val(cYear) + 7) & "Variable") += nMonto
                            End If
                        Case CStr(Val(cYear) + 8)
                            drTempX(CStr(Val(cYear) + 8)) += nMonto
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 8) & "Fija") += nMonto
                            Else
                                drTempX(CStr(Val(cYear) + 8) & "Variable") += nMonto
                            End If
                        Case CStr(Val(cYear) + 9)
                            drTempX(CStr(Val(cYear) + 9)) += nMonto
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 9) & "Fija") += nMonto
                            Else
                                drTempX(CStr(Val(cYear) + 9) & "Variable") += nMonto
                            End If
                        Case CStr(Val(cYear) + 10)
                            drTempX(CStr(Val(cYear) + 10)) += nMonto
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 10) & "Fija") += nMonto
                            Else
                                drTempX(CStr(Val(cYear) + 10) & "Variable") += nMonto
                            End If
                    End Select
                End If
            End If
        Next

        'End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Sub sacaAVCC(tipo As String, Suc1 As String, Suc2 As String, FechaAux As Date)
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand
        If tipo = "H" Then
            cm1.CommandText = "Select * from Vw_AmortizacionesAV where mes > '" & FechaAux.ToString("yyyyMM") & "' and sucursal between '" & Suc1 & "' and '" & Suc2 & "'"
        Else
            cm1.CommandText = "Select * from Vw_AmortizacionesCC where mes > '" & FechaAux.ToString("yyyyMM") & "' and sucursal between '" & Suc1 & "' and '" & Suc2 & "'"
        End If
        cm1.CommandType = CommandType.Text
        cm1.Connection = cnAgil

        Dim daAvios As New SqlDataAdapter(cm1)
        Dim TAvios As New DataTable
        Dim drTemp As DataRow
        Dim drTempX As DataRow
        Dim cYearPayment As String = ""
        Dim Mess As String = ""
        Dim cTipta As String = ""

        For x As Integer = 1 To 12
            If x < 10 Then Mess = "0" & x Else Mess = x
            drTemp = dtReporte1.Rows.Find(Mess)
            If drTemp Is Nothing Then
                drTemp = dtReporte1.NewRow()
                drTemp("Mes") = Mess
                drTemp(cYear) = 0
                drTemp(CStr(Val(cYear) + 1)) = 0
                drTemp(CStr(Val(cYear) + 2)) = 0
                drTemp(CStr(Val(cYear) + 3)) = 0
                drTemp(CStr(Val(cYear) + 4)) = 0
                drTemp(CStr(Val(cYear) + 5)) = 0
                drTemp(CStr(Val(cYear) + 6)) = 0
                drTemp(CStr(Val(cYear) + 7)) = 0
                drTemp(CStr(Val(cYear) + 8)) = 0
                drTemp(CStr(Val(cYear) + 9)) = 0
                drTemp(CStr(Val(cYear) + 10)) = 0
                dtReporte1.Rows.Add(drTemp)
            End If
        Next

        daAvios.Fill(TAvios)
        For Each r As DataRow In TAvios.Rows
            Mess = Mid(r("Mes"), 5, 2)
            drTemp = dtReporte1.Rows.Find(Mess)

            cYearPayment = Mid(r("Mes"), 1, 4)
            cTipta = r("Tipta")
            If drTemp Is Nothing Then

                ' El mes no existe en la tabla
                drTemp = dtReporte1.NewRow()
                drTemp("Mes") = Mess
                drTemp(cYear) = IIf(cYearPayment = cYear, r("Total"), 0)
                drTemp(CStr(Val(cYear) + 1)) = IIf(cYearPayment = CStr(Val(cYear) + 1), r("Total"), 0)
                drTemp(CStr(Val(cYear) + 2)) = IIf(cYearPayment = CStr(Val(cYear) + 2), r("Total"), 0)
                drTemp(CStr(Val(cYear) + 3)) = IIf(cYearPayment = CStr(Val(cYear) + 3), r("Total"), 0)
                drTemp(CStr(Val(cYear) + 4)) = IIf(cYearPayment = CStr(Val(cYear) + 4), r("Total"), 0)
                drTemp(CStr(Val(cYear) + 5)) = IIf(cYearPayment = CStr(Val(cYear) + 5), r("Total"), 0)
                drTemp(CStr(Val(cYear) + 6)) = IIf(cYearPayment = CStr(Val(cYear) + 6), r("Total"), 0)
                drTemp(CStr(Val(cYear) + 7)) = IIf(cYearPayment = CStr(Val(cYear) + 7), r("Total"), 0)
                drTemp(CStr(Val(cYear) + 8)) = IIf(cYearPayment = CStr(Val(cYear) + 8), r("Total"), 0)
                drTemp(CStr(Val(cYear) + 9)) = IIf(cYearPayment = CStr(Val(cYear) + 8), r("Total"), 0)
                drTemp(CStr(Val(cYear) + 10)) = IIf(cYearPayment = CStr(Val(cYear) + 8), r("Total"), 0)
                dtReporte1.Rows.Add(drTemp)

            Else

                ' El mes ya existe en la tabla

                Select Case cYearPayment
                    Case cYear
                        drTemp(cYear) += r("Total")
                    Case CStr(Val(cYear) + 1)
                        drTemp(CStr(Val(cYear) + 1)) += r("Total")
                    Case CStr(Val(cYear) + 2)
                        drTemp(CStr(Val(cYear) + 2)) += r("Total")
                    Case CStr(Val(cYear) + 3)
                        drTemp(CStr(Val(cYear) + 3)) += r("Total")
                    Case CStr(Val(cYear) + 4)
                        drTemp(CStr(Val(cYear) + 4)) += r("Total")
                    Case CStr(Val(cYear) + 5)
                        drTemp(CStr(Val(cYear) + 5)) += r("Total")
                    Case CStr(Val(cYear) + 6)
                        drTemp(CStr(Val(cYear) + 6)) += r("Total")
                    Case CStr(Val(cYear) + 7)
                        drTemp(CStr(Val(cYear) + 7)) += r("Total")
                    Case CStr(Val(cYear) + 8)
                        drTemp(CStr(Val(cYear) + 8)) += r("Total")
                    Case CStr(Val(cYear) + 9)
                        drTemp(CStr(Val(cYear) + 9)) += r("Total")
                    Case CStr(Val(cYear) + 10)
                        drTemp(CStr(Val(cYear) + 10)) += r("Total")
                End Select
            End If

            If banderaTotal = True Then
                drTempX = dtReporteAcum.Rows.Find(MonthName(Val(Mess)))
                ' El mes ya existe en la tabla
                Try
                    Select Case cYearPayment
                        Case cYear
                            drTempX(cYear) += r("Total")
                            If cTipta = "7" Then
                                drTempX(cYear & "Fija") += r("Total")
                            Else
                                drTempX(cYear & "Variable") += r("Total")
                            End If
                        Case CStr(Val(cYear) + 1)
                            drTempX(CStr(Val(cYear) + 1)) += r("Total")
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 1) & "Fija") += r("Total")
                            Else
                                drTempX(CStr(Val(cYear) + 1) & "Variable") += r("Total")
                            End If
                        Case CStr(Val(cYear) + 2)
                            drTempX(CStr(Val(cYear) + 2)) += r("Total")
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 2) & "Fija") += r("Total")
                            Else
                                drTempX(CStr(Val(cYear) + 2) & "Variable") += r("Total")
                            End If
                        Case CStr(Val(cYear) + 3)
                            drTempX(CStr(Val(cYear) + 3)) += r("Total")
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 3) & "Fija") += r("Total")
                            Else
                                drTempX(CStr(Val(cYear) + 3) & "Variable") += r("Total")
                            End If
                        Case CStr(Val(cYear) + 4)
                            drTempX(CStr(Val(cYear) + 4)) += r("Total")
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 4) & "Fija") += r("Total")
                            Else
                                drTempX(CStr(Val(cYear) + 4) & "Variable") += r("Total")
                            End If
                        Case CStr(Val(cYear) + 5)
                            drTempX(CStr(Val(cYear) + 5)) += r("Total")
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 5) & "Fija") += r("Total")
                            Else
                                drTempX(CStr(Val(cYear) + 5) & "Variable") += r("Total")
                            End If
                        Case CStr(Val(cYear) + 6)
                            drTempX(CStr(Val(cYear) + 6)) += r("Total")
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 6) & "Fija") += r("Total")
                            Else
                                drTempX(CStr(Val(cYear) + 6) & "Variable") += r("Total")
                            End If
                        Case CStr(Val(cYear) + 7)
                            drTempX(CStr(Val(cYear) + 7)) += r("Total")
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 7) & "Fija") += r("Total")
                            Else
                                drTempX(CStr(Val(cYear) + 7) & "Variable") += r("Total")
                            End If
                        Case CStr(Val(cYear) + 8)
                            drTempX(CStr(Val(cYear) + 8)) += r("Total")
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 8) & "Fija") += r("Total")
                            Else
                                drTempX(CStr(Val(cYear) + 8) & "Variable") += r("Total")
                            End If
                        Case CStr(Val(cYear) + 9)
                            drTempX(CStr(Val(cYear) + 9)) += r("Total")
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 9) & "Fija") += r("Total")
                            Else
                                drTempX(CStr(Val(cYear) + 9) & "Variable") += r("Total")
                            End If
                        Case CStr(Val(cYear) + 10)
                            drTempX(CStr(Val(cYear) + 10)) += r("Total")
                            If cTipta = "7" Then
                                drTempX(CStr(Val(cYear) + 10) & "Fija") += r("Total")
                            Else
                                drTempX(CStr(Val(cYear) + 10) & "Variable") += r("Total")
                            End If
                    End Select
                Catch
                End Try
            End If
        Next
    End Sub

    Public Function porcentaje(total As Double, var1 As Double, dif As Double)
        Dim resultado As Double
        resultado = var1 - ((var1 / total) * dif)
        Return resultado
    End Function

    Public Function porcentaje_sub(total As Double, var1 As Double, dif As Double)
        Dim resultado As Double

        resultado = var1 + ((var1 / total) * dif)
        'resultado = (var1 / total) * total
        If dif < 0 Then
            resultado = var1 + ((var1 / total) * dif)
        End If
        Return resultado
    End Function

    Public Function porcentaje_cs(total As Double, var1 As Double, dif As Double)
        Dim resultado As Double

        resultado = var1 + ((var1 / total) * dif)
        'resultado = (var1 / total) * total
        If dif < 0 Then
            'resultado = var1
            resultado = var1 + ((var1 / total) * dif)
        End If
        Return resultado
    End Function

    Public Function porcentaje_css(total As Double, var1 As Double, dif As Double)
        Dim resultado As Double

        resultado = var1 + ((var1 / total) * dif)
        'resultado = (var1 / total) * total
        If dif < 0 Then
            'resultado = var1
            resultado = var1 + ((var1 / total) * Math.Abs(dif))
        End If
        Return resultado
    End Function

    Public Function porcentaje_av(total As Double, var1 As Double, dif As Double)
        Dim resultado As Double

        resultado = var1 + (Math.Round((var1 / total), 4) * dif)
        'resultado = (var1 / total) * total
        If dif <= 0 Then
            'resultado = var1
            resultado = var1 + (Math.Round((var1 / total), 4) * dif)
        End If
        Return resultado
    End Function

    Function TruncateDecimal(value As Decimal, precision As Integer) As Decimal
        Dim stepper As Decimal = Math.Pow(10, precision)
        Dim tmp As Decimal = Math.Truncate(stepper * value)
        Return tmp / stepper
    End Function

    Sub Carga_ComboDB()
        Dim t As New DataTable
        Dim r As DataRow
        t.Columns.Add("ID")
        t.Columns.Add("TIT")

        Dim Fecha As Date = Date.Now
        'r = t.NewRow
        'r("ID") = Date.Now.ToString("yyyyMMdd")
        'r("TIT") = "A la Fecha"
        't.Rows.Add(r)

        For x As Integer = 0 To 11
            Fecha = Fecha.AddDays(-1 * Fecha.Day)
            If Fecha >= "01/12/2018" Then
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
    End Sub

End Class

