' En este reporte la ubicación de los objetos en la interfaz gráfica depende de la opción seleccionada

Option Explicit On

Imports System.Data.SqlClient

Public Class frmConsRef

    Public Sub New(ByVal cReporte As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtReporte.Text = cReporte

    End Sub

    Private Sub frmConsRef_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daClientes As New SqlDataAdapter(cm1)
        DateTimePicker1.Value = FECHA_APLICACION
        DateTimePicker2.Value = FECHA_APLICACION
        DateTimePicker3.Value = FECHA_APLICACION

        If txtReporte.Text = "F" Then

            Label1.Visible = True
            DateTimePicker1.Visible = True
            Label2.Visible = True
            DateTimePicker2.Visible = True
            Label3.Visible = True
            DateTimePicker3.Visible = True
            btnProcesar.Visible = True

        ElseIf txtReporte.Text = "C" Then

            Me.lblClientes.Location = New System.Drawing.Point(12, 17)
            Me.ComboBox1.Location = New System.Drawing.Point(12, 38)
            Me.btnProcesar.Location = New System.Drawing.Point(468, 37)
            Me.btnSalir.Location = New System.Drawing.Point(563, 37)
            lblClientes.Visible = True
            ComboBox1.Visible = True
            btnProcesar.Visible = True

            ' Este Stored Procedure trae TODOS los clientes que existan en la tabla Clientes sin importar 
            ' si tienen o no contratos o solicitudes generadas

            With cm1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ContClie1"
                .Connection = cnAgil
            End With

            ComboBox1.MaxDropDownItems = 35

            Try

                ' Llenar el DataSet

                daClientes.Fill(dsAgil, "Clientes")

                ' Ligar la tabla Clientes del dataset dsAgil al ComboBox

                ComboBox1.DataSource = dsAgil
                ComboBox1.DisplayMember = "Clientes.Descr"
                ComboBox1.ValueMember = "Clientes.Descr"

            Catch eException As Exception

                MsgBox(eException.Source & " " & eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

            End Try

        End If

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnProcesar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Cursor.Current = Cursors.WaitCursor
        If txtReporte.Text = "F" Then

            ' Declaración de variables de conexión ADO .NET
            Dim taHist As New ReportesDSTableAdapters.HistoriaPagosTableAdapter
            Dim cnAgil As New SqlConnection(strConn)
            Dim cm1 As New SqlCommand()
            'Dim cm2 As New SqlCommand()
            'Dim cm3 As New SqlCommand()
            Dim dsAgil As New DataSet()
            Dim daReferen As New SqlDataAdapter(cm1)
            'Dim daContratos As New SqlDataAdapter(cm2)
            'Dim daFiraref As New SqlDataAdapter(cm3)
            'Dim dtReporte As New DataTable("Reporte")
            Dim dtReporte As New ReportesDS.DepoRefeDataTable
            Dim drDeposito As DataRow
            Dim drReporte As DataRow
            'Dim drCto As DataRow

            ' Declaración de variables de datos

            Dim cFechaIni As String
            Dim cFechaFin As String
            Dim cFechaAplica As String
            Dim cReportTitle As String
            Dim dFecha As Date
            Dim nCount As Integer
            Dim newrptConsRefe As New rptConsRefe1()
            Dim nCero As Integer = 0
            'Dim cGar As String = ""
            Dim RefBanco As String = ""
            Dim cAnexo As String = ""

            'btnGarantias.Visible = True
            cFechaIni = DateTimePicker1.Value.ToString("yyyyMMdd")
            cFechaFin = DateTimePicker2.Value.ToString("yyyyMMdd")
            cFechaAplica = DateTimePicker3.Value.ToString("yyyyMMdd")
            Me.Text = "Depósitos Referenciados del " & CTOD(cFechaIni) & " al " & CTOD(cFechaFin)

            ' Este Stored Procedure trae TODOS los movimientos registrados en 
            ' la Tabla Referenciado del cliente solicitado

            With cm1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "DatosRef1"
                .Connection = cnAgil
                .Parameters.Add("@Fechai", SqlDbType.NVarChar)
                .Parameters.Add("@Fechaf", SqlDbType.NVarChar)
                .Parameters(0).Value = cFechaIni
                .Parameters(1).Value = cFechaFin
            End With

            daReferen.Fill(dsAgil, "Movimientos")
            nCount = dsAgil.Tables("Movimientos").Rows.Count

            If nCount > 0 Then

                ' Ahora creo la tabla Anexos que será la base del reporte

                For Each drDeposito In dsAgil.Tables("Movimientos").Rows
                    'cGar = ""
                    cAnexo = Mid(drDeposito("Referencia"), 1, 5) & Mid(drDeposito("Referencia"), 7, 4)
                    dFecha = CTOD(drDeposito("Fecha"))
                    drReporte = dtReporte.NewRow()
                    drReporte("Fecha") = dFecha.ToShortDateString
                    drReporte("Nombre") = drDeposito("Nombre")
                    drReporte("Banco") = drDeposito("Banco")
                    drReporte("Referencia") = drDeposito("Referencia") '& " " ' & cGar
                    drReporte("Importe") = drDeposito("Importe")
                    drReporte("Efectivo") = drDeposito("Efectivo")
                    drReporte("Domiciliacion") = drDeposito("Domiciliacion")
                    drReporte("InterBancario") = drDeposito("InterBancario")
                    drReporte("TipoCredito") = TaQUERY.SacaTipar(cAnexo)
                    drReporte("InstrumentoMonetario") = drDeposito("InstrumentoMonetario")
                    RefBanco = Trim(drDeposito("RefBanco"))
                    drReporte("ImporteAplicado") = taHist.ImporteAplicado(cFechaAplica, cAnexo, RefBanco.Trim)
                    drReporte("BancoAplicado") = taHist.SacaBanco(cFechaAplica, cAnexo, RefBanco.Trim)
                    drReporte("Diferencia") = drReporte("Importe") - drReporte("ImporteAplicado")
                    dtReporte.Rows.Add(drReporte)
                Next
                dsAgil.Tables.Remove("Movimientos")
                dsAgil.Tables.Add(dtReporte)

                ' Descomentar la siguiente línea en caso de que se deseara modificar el reporte rptConsRefe
                'dsAgil.WriteXml("C:\Files\Schema33.xml", XmlWriteMode.WriteSchema)

                newrptConsRefe.SetDataSource(dsAgil)

                cReportTitle = "DEL " & CTOD(cFechaIni) & " AL " & CTOD(cFechaFin)

                newrptConsRefe.SummaryInfo.ReportTitle = cReportTitle

                CrystalReportViewer1.ReportSource = newrptConsRefe

            Else

                MsgBox("No hay depósitos referenciados en este rango de fechas", MsgBoxStyle.Information, "Mensaje")

            End If

            cnAgil.Dispose()
            'cm1.Dispose()

        ElseIf txtReporte.Text = "C" Then

            ' Declaración de variables de conexión ADO .NET

            Dim cnAgil As New SqlConnection(strConn)
            Dim cm1 As New SqlCommand()
            Dim dsAgil As New DataSet()
            Dim daReferen As New SqlDataAdapter(cm1)
            'Dim dtReporte As New DataTable("Reporte")
            Dim dtReporte As New ReportesDS.DepoRefeDataTable
            Dim drDeposito As DataRow
            Dim drReporte As DataRow

            ' Declaración de variables de datos

            Dim cName As String
            Dim cReportTitle As String
            Dim dFecha As Date
            Dim nCount As Integer
            Dim cGar As String = ""

            btnGarantias.Visible = False

            ' Declaración de variables de Crystal Reports

            Dim newrptConsRefe As New rptConsRefe()

            cName = RTrim(ComboBox1.SelectedValue.ToString())
            Me.Text = "Depósitos Referenciados de " & cName

            ' Este Stored Procedure trae TODOS los movimientos registrados en 
            ' la Tabla Referenciado del cliente solicitado

            With cm1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "DatosRef"
                .Connection = cnAgil
                .Parameters.Add("@Name", SqlDbType.NVarChar)
                .Parameters(0).Value = cName
            End With

            daReferen.Fill(dsAgil, "Movimientos")
            nCount = dsAgil.Tables("Movimientos").Rows.Count

            If nCount > 0 Then

                ' Ahora creo la tabla Anexos que será la base del reporte

                For Each drDeposito In dsAgil.Tables("Movimientos").Rows
                    dFecha = CTOD(drDeposito("Fecha"))
                    drReporte = dtReporte.NewRow()
                    drReporte("Fecha") = dFecha.ToShortDateString
                    'drReporte("Fec") = dFecha.ToOADate
                    drReporte("Banco") = drDeposito("Banco")
                    drReporte("Referencia") = drDeposito("Referencia") & cGar
                    drReporte("Importe") = drDeposito("Importe")
                    drReporte("InstrumentoMonetario") = drDeposito("InstrumentoMonetario")
                    dtReporte.Rows.Add(drReporte)
                Next
                dsAgil.Tables.Remove("Movimientos")
                dsAgil.Tables.Add(dtReporte)

                ' Descomentar la siguiente línea en caso de que se deseara modificar el reporte rptConsRefe
                'dsAgil.WriteXml("C:\Schema33.xml", XmlWriteMode.WriteSchema)

                newrptConsRefe.SetDataSource(dsAgil)

                cReportTitle = cName
                newrptConsRefe.SummaryInfo.ReportTitle = cReportTitle

                CrystalReportViewer1.ReportSource = newrptConsRefe

            Else

                MsgBox("El Cliente no tiene depósitos referenciados", MsgBoxStyle.Information, "Mensaje")

            End If

            cnAgil.Dispose()
            cm1.Dispose()

        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnGarantias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGarantias.Click
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daAVGarantia As New SqlDataAdapter(cm1)
        Dim daCRGarantia As New SqlDataAdapter(cm2)
        Dim daDatos As New SqlDataAdapter(cm3)
        Dim dtReporte1 As New DataTable("Garantias")
        Dim drGarantia As DataRow
        Dim drDatos As DataRow
        Dim drReporte As DataRow
        Dim drName As DataRow

        Dim nCero As Integer = 0
        Dim cCusnam As String
        Dim cReportTitle As String
        Dim newrptGarantiasE As New rptGarantiasEj()

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Anexo, Descr, IDPersona, IDGarantia, GarantiaFecha FROM Avios INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente WHERE IDGarantia > " & nCero
            .Connection = cnAgil
        End With

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT Anexo, IDPersona, IDGarantia, GarantiaFecha FROM FIRArefaccionarios WHERE IDGarantia > " & nCero
            .Connection = cnAgil
        End With

        With cm3
            .CommandType = CommandType.Text
            .CommandText = "SELECT DISTINCT AnexoCon, Vw_Anexos_Basic.Cliente, Descr FROM Vw_Anexos_Basic INNER JOIN Clientes ON Vw_Anexos_Basic.Cliente = Clientes.Cliente"
            .Connection = cnAgil
        End With

        daAVGarantia.Fill(dsAgil, "Avios")
        daCRGarantia.Fill(dsAgil, "Refacc")
        daDatos.Fill(dsAgil, "Nombres")

        ' Primero creo la tabla Reporte que será la base del reporte

        dtReporte1.Columns.Add("Contrato", Type.GetType("System.String"))
        dtReporte1.Columns.Add("Cliente", Type.GetType("System.String"))
        dtReporte1.Columns.Add("IDPersona", Type.GetType("System.String"))
        dtReporte1.Columns.Add("IDGarantia", Type.GetType("System.Decimal"))
        dtReporte1.Columns.Add("Fecha", Type.GetType("System.String"))
        dtReporte1.Columns.Add("Tipar", Type.GetType("System.String"))
        
        For Each drGarantia In dsAgil.Tables("Avios").Rows
            drReporte = dtReporte1.NewRow()
            drReporte("Contrato") = Mid(drGarantia("Anexo"), 1, 5) & "/" & Mid(drGarantia("Anexo"), 6, 4)
            drReporte("Cliente") = drGarantia("Descr")
            drReporte("IDPersona") = drGarantia("IDPersona")
            drReporte("IDGarantia") = drGarantia("IDGarantia")
            If Trim(drGarantia("GarantiaFecha")) = "" Then
                drReporte("Fecha") = ""
            Else
                drReporte("Fecha") = Mid(CTOD(drGarantia("GarantiaFecha")), 1, 10)
            End If

            drReporte("Tipar") = "Avio"
            dtReporte1.Rows.Add(drReporte)
        Next

        For Each drDatos In dsAgil.Tables("Refacc").Rows
            For Each drName In dsAgil.Tables("Nombres").Rows
                If drDatos("Anexo") = drName("Anexocon") Then
                    cCusnam = drName("Descr")
                End If
            Next

            drReporte = dtReporte1.NewRow()
            drReporte("Contrato") = drDatos("Anexo")
            drReporte("Cliente") = cCusnam
            drReporte("IDPersona") = drDatos("IDPersona")
            drReporte("IDGarantia") = drDatos("IDGarantia")
            drReporte("Fecha") = Mid(CTOD(drDatos("GarantiaFecha")), 1, 10)
            drReporte("Tipar") = "Refac"
            dtReporte1.Rows.Add(drReporte)
        Next

        dsAgil.Tables.Add(dtReporte1)

        ' Descomentar la siguiente línea en caso de que se deseara modificar el reporte rptConsRefe
        'dsAgil.WriteXml("C:\Files\Schema33.xml", XmlWriteMode.WriteSchema)

        newrptGarantiasE.SetDataSource(dsAgil)

        ' cReportTitle = cName
        'newrptConsRefe.SummaryInfo.ReportTitle = cReportTitle
    
        CrystalReportViewer1.ReportSource = newrptGarantiasE

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class