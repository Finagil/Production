Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports System.Text.ASCIIEncoding


Public Class frmAplicacionNC

    Public Importe As Decimal = 0
    Public TIEE As Decimal = 0
    Public Diferencial As Decimal = 0
    Public Fondeo As String = ""
    Public AplicaGarantiaLIQ As String = ""
    Public GastosIniciales As Decimal = 0
    Public Tvida As Decimal = 0
    Public SegAgri As Decimal = 0
    Dim GarantiaLIQ As Decimal = 0.1
    Public Fecha As Date

    ' Declaración de variables de conexión ADO .NET de alcance privado
    Dim dtPagados As New DataTable
    Dim dtDetalleFINAGIL As New DataTable
    Dim drDetalleFINAGIL As DataRow
    Dim drSerie As DataRow
    Private BindingDeudores As Windows.Forms.BindingSource = New BindingSource

    ' Declaración de variables de alcance privado

    Dim cAnexo As String = ""
    Dim cCiclo As String = ""
    Dim cCliente As String = ""
    Dim cFecha As String = ""
    Dim cFechaFinal As String = ""
    Dim cFechaInicial As String = ""
    Dim cFechaAutorizacion As String = ""
    Dim cNombreProductor As String = ""
    Dim cTipar As String = ""
    Dim nCapital As Decimal = 0
    Dim nConsecutivo As Integer = 0
    Dim nConsecutivoSerie As Integer = 0
    Dim nDias As Integer = 0
    Dim nFEGA As Decimal = 0
    Dim nGarantia As Decimal = 0
    Dim nIntereses As Decimal = 0
    Dim nMontoTotal As Decimal = 0
    Dim nSaldoFinal As Decimal = 0
    Dim nSaldoInicial As Decimal = 0
    Dim nSumaIntereses As Decimal = 0
    Dim nTasaBP As Decimal = 0
    Dim nVeces As Integer = 0

    Private Sub frmAplicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Esta pantalla no se puede usar por el momento", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub


        Me.InstrumentoMonetarioTableAdapter.Fill(Me.GeneralDS.InstrumentoMonetario)
        dtpProceso.Value = FECHA_APLICACION
        DTPDesde.Value = FECHA_APLICACION
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daDeudores As New SqlDataAdapter(cm1)

        Dim dsAgil As New DataSet
        Dim dtDeudores As New DataTable
        Dim myColArray(1) As DataColumn

        Dim i As Byte = 0

        ToolStripStatusLabel1.Text = "Fecha de Aplicación " & FECHA_APLICACION.ToShortDateString

        ' En primer lugar creo la estructura de la tabla dtDetalleFINAGIL

        dtDetalleFINAGIL.Columns.Add("Anexo", Type.GetType("System.String"))
        dtDetalleFINAGIL.Columns.Add("Ciclo", Type.GetType("System.String"))
        dtDetalleFINAGIL.Columns.Add("Cliente", Type.GetType("System.String"))
        dtDetalleFINAGIL.Columns.Add("Consecutivo", Type.GetType("System.Decimal"))
        dtDetalleFINAGIL.Columns.Add("FechaInicial", Type.GetType("System.String"))
        dtDetalleFINAGIL.Columns.Add("FechaFinal", Type.GetType("System.String"))
        dtDetalleFINAGIL.Columns.Add("Dias", Type.GetType("System.Decimal"))
        dtDetalleFINAGIL.Columns.Add("TasaBP", Type.GetType("System.Decimal"))
        dtDetalleFINAGIL.Columns.Add("SaldoInicial", Type.GetType("System.Decimal"))
        dtDetalleFINAGIL.Columns.Add("SaldoFinal", Type.GetType("System.Decimal"))
        dtDetalleFINAGIL.Columns.Add("Concepto", Type.GetType("System.String"))
        dtDetalleFINAGIL.Columns.Add("Importe", Type.GetType("System.Decimal"))
        dtDetalleFINAGIL.Columns.Add("FEGA", Type.GetType("System.Decimal"))
        dtDetalleFINAGIL.Columns.Add("Garantia", Type.GetType("System.Decimal"))
        dtDetalleFINAGIL.Columns.Add("Intereses", Type.GetType("System.Decimal"))
        dtDetalleFINAGIL.Columns.Add("Tipar", Type.GetType("System.String"))

        ' El siguiente Stored Procedure trae los datos del contrato de Habilitación o Avío

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT * " & _
                           "FROM Vw_AdeudosAvio " & _
                           "ORDER BY Productor, Contrato, [Ciclo o Pagaré]"
            .Connection = cnAgil
        End With

        ' Llenar el dataset lo cual abre y cierra la conexión

        daDeudores.Fill(dsAgil, "Deudores")

        ' Primero creo la tabla dtDeudores y le defino una llave primaria para que siempre esté ordenada y para poder localizar un
        ' contrato en particular

        dtDeudores = dsAgil.Tables("Deudores")
        myColArray(0) = dtDeudores.Columns("Descr")
        dtDeudores.PrimaryKey = myColArray
        dgvDeudores.DataSource = dtDeudores
        BindingDeudores.DataSource = dtDeudores
        dgvDeudores.Columns(0).Width = 500
        dgvDeudores.Columns(1).Width = 80
        dgvDeudores.Columns(2).Width = 100
        dgvDeudores.Columns(3).Width = 80


        For i = 0 To dgvDeudores.Columns.Count - 1
            dgvDeudores.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            If i = 1 Then
                dgvDeudores.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el encabezado
                dgvDeudores.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el contenido
            End If
            If i = 3 Then
                dgvDeudores.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el encabezado
                dgvDeudores.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el contenido
                dgvDeudores.Columns(i).DefaultCellStyle.Format = "##,##0.00"
            End If
        Next
        dgvDeudores.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Ahora creo la tabla dtPagados

        dtPagados.Columns.Add("Productor", Type.GetType("System.String"))
        dtPagados.Columns.Add("Contrato", Type.GetType("System.String"))
        dtPagados.Columns.Add("Ciclo", Type.GetType("System.String"))
        dtPagados.Columns.Add("TipoPago", Type.GetType("System.String"))
        dtPagados.Columns.Add("Fecha", Type.GetType("System.String"))
        dtPagados.Columns.Add("Capital", Type.GetType("System.String"))
        dtPagados.Columns.Add("Garantia", Type.GetType("System.String"))
        dtPagados.Columns.Add("FEGA", Type.GetType("System.String"))
        dtPagados.Columns.Add("Intereses", Type.GetType("System.String"))
        dtPagados.Columns.Add("Total", Type.GetType("System.String"))
        dtPagados.Columns.Add("Concepto", Type.GetType("System.String"))

        dgvPagados.DataSource = dtPagados
        dgvPagados.Columns(0).Width = 240
        dgvPagados.Columns(1).Width = 70
        dgvPagados.Columns(2).Width = 50
        dgvPagados.Columns(3).Visible = False
        dgvPagados.Columns(4).Width = 70
        dgvPagados.Columns(5).Width = 80
        dgvPagados.Columns(6).Width = 80
        dgvPagados.Columns(7).Width = 80
        dgvPagados.Columns(9).Width = 80
        dgvPagados.Columns(10).Width = 160

        For i = 0 To dgvPagados.Columns.Count - 1
            dgvPagados.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            If i = 1 Or i = 2 Or i = 3 Then
                dgvPagados.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el encabezado
                dgvPagados.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el contenido
            End If
            If i > 3 And i <> 10 Then
                dgvPagados.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el encabezado
                dgvPagados.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el contenido
            End If
        Next

        cm1.Dispose()

    End Sub

    Private Sub dgvDeudores_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDeudores.CellMouseClick
        btnCalcularIntereses.Enabled = True
    End Sub

    Private Sub btnCalcularIntereses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularIntereses.Click
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daDetalle As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet
        Dim drDetalle As DataRow
        Dim dtTIIE As New DataTable
        Dim drTIIE As DataRow
        Dim myKeySearch(0) As String

        Dim cFechaTerminacion As String = ""
        Dim cTipta As String = ""
        Dim cUltimoCorte As String = ""
        Dim nDiferencial As Decimal = 0
        Dim nTasa As Decimal = 0

        cFecha = DTOC(dtpProceso.Value)

        cNombreProductor = dgvDeudores.CurrentRow.Cells(0).Value
        cAnexo = Mid(dgvDeudores.CurrentRow.Cells(1).Value, 1, 5) + Mid(dgvDeudores.CurrentRow.Cells(1).Value, 7, 4)
        cTipar = Mid(dgvDeudores.CurrentRow.Cells(2).Value, 1, 4)
        If cTipar = "Paga" Then
            cTipar = "C"
            cCiclo = Mid(dgvDeudores.CurrentRow.Cells(2).Value, 8, 2)
        Else
            cTipar = "H"
            cCiclo = Mid(dgvDeudores.CurrentRow.Cells(2).Value, 1, 2)
        End If
        nCapital = dgvDeudores.CurrentRow.Cells(3).Value

        ' Genero la tabla que contiene las TIIE promedio por mes.   Para FINAGIL considera todos los días del mes y redondea a 4 decimales

        dtTIIE = TIIEavg("FINAGIL")

        ' Tengo que copiar los movimientos que existan físicamente en DetalleFINAGIL en una tabla temporal para poder calcular el registro de intereses ordinarios
        ' (si procedieran) sin necesidad de insertar un registro en la tabla física

        ' El siguiente Command trae los movimientos que existan en DetalleFINAGIL del contrato seleccionado

        Shell("""F:\Executables\EstadoCuentaAVCC.exe"" " & cAnexo & " " & cCiclo & " FIN 0 " & UsuarioGlobal & " " & DIAS_MENOS, AppWinStyle.NormalFocus, True)
        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT DetalleFINAGIL.*, Tipta, Tasas, DiferencialFINAGIL, UltimoCorte, FechaTerminacion, fondeo, AplicaGarantiaLIQ, FechaAutorizacion FROM DetalleFINAGIL " & _
                           "INNER JOIN Avios ON DetalleFINAGIL.Anexo = Avios.Anexo AND DetalleFINAGIL.Ciclo = Avios.Ciclo " & _
                           "WHERE DetalleFINAGIL.Anexo = '" & cAnexo & "' AND DetalleFINAGIL.Ciclo = '" & cCiclo & "' " & _
                           "ORDER BY Consecutivo"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daDetalle.Fill(dsAgil, "Detalle")
        cFechaAutorizacion = ""
        For Each drDetalle In dsAgil.Tables("Detalle").Rows

            nTasa = drDetalle("Tasas")
            nDiferencial = drDetalle("DiferencialFINAGIL")
            Diferencial = nDiferencial 'para sugerencia
            Fondeo = drDetalle("Fondeo") 'para sugerencia
            AplicaGarantiaLIQ = drDetalle("AplicaGarantiaLIQ") 'para sugerencia
            cTipta = drDetalle("Tipta")
            cUltimoCorte = drDetalle("UltimoCorte")
            cFechaTerminacion = drDetalle("FechaTerminacion")
            If cFechaAutorizacion = "" Then cFechaAutorizacion = drDetalle("FechaAutorizacion")

            cCliente = drDetalle("Cliente")
            nConsecutivo = drDetalle("Consecutivo")
            cFechaInicial = drDetalle("FechaFinal")
            nSaldoInicial = drDetalle("SaldoFinal")

        Next

        If cFecha < cFechaInicial Then

            ' Se desea obtener el Estado de Cuenta a una fecha anterior al último movimiento registrado
            ' lo cual no es posible.   Lo que hace el sistema es cambiar la fecha de cálculo a la fecha
            ' del último movimiento registrado

            cFecha = cFechaInicial

        End If

        nConsecutivo += 1

        If cTipta = "7" Then

            nTasaBP = Round(nTasa + nDiferencial, 4)

        Else

            ' Construyo una fecha que me permita buscar el promedio de la tasa TIIE del mes inmediato anterior

            myKeySearch(0) = Mid(DTOC(DateAdd(DateInterval.Month, -1, CTOD(cFecha))), 1, 6)

            drTIIE = dtTIIE.Rows.Find(myKeySearch)

            If drTIIE Is Nothing Then
                nTasaBP = 0
            Else
                nTasaBP = drTIIE("Promedio")
            End If

            nTasaBP = Round(nTasaBP + nDiferencial, 4)

        End If

        If cFecha > cFechaTerminacion And Mid(cFecha, 5, 2) = Mid(cFechaTerminacion, 5, 2) Then ' corte de inetres por vencimiento
            Dim Aux As String = cFecha
            cFecha = cFechaTerminacion
            nDias = DateDiff(DateInterval.Day, CTOD(cFechaInicial), CTOD(cFecha))

            drDetalle = dsAgil.Tables("Detalle").NewRow
            drDetalle("Anexo") = cAnexo
            drDetalle("Cliente") = cCliente
            drDetalle("Consecutivo") = nConsecutivo
            drDetalle("FechaInicial") = cFechaInicial
            drDetalle("FechaFinal") = cFecha
            drDetalle("Dias") = nDias
            drDetalle("TasaBP") = nTasaBP
            drDetalle("SaldoInicial") = nSaldoInicial
            drDetalle("SaldoFinal") = nSaldoFinal
            drDetalle("Concepto") = "INTERESES"
            drDetalle("Importe") = 0
            drDetalle("FEGA") = 0
            drDetalle("Garantia") = 0
            drDetalle("Intereses") = 0
            dsAgil.Tables("Detalle").Rows.Add(drDetalle)
            nSumaIntereses = 0

            For Each drDetalle In dsAgil.Tables("Detalle").Rows

                cFechaFinal = drDetalle("FechaFinal")
                If Mid(cFechaFinal, 1, 6) = Mid(cFecha, 1, 6) And cFechaFinal > cUltimoCorte Then
                    nSaldoInicial = drDetalle("SaldoInicial")
                    nTasaBP = drDetalle("TasaBP")
                    nDias = drDetalle("Dias")
                    nIntereses = Round(nSaldoInicial * nTasaBP / 36000 * nDias, 2)
                    nSumaIntereses = Round(nSumaIntereses + nIntereses, 2)
                End If

                nConsecutivo = drDetalle("Consecutivo")

            Next

            nSaldoFinal = nSaldoInicial + nIntereses

            drDetalle("Intereses") = nIntereses
            drDetalle("SaldoFinal") = nSaldoFinal
            cFechaInicial = cFecha
            cFecha = Aux
            nSaldoInicial = nSaldoFinal
        End If

        If cFecha > cFechaTerminacion And cTipar <> "C" And cAnexo <> "085950003" Then
            nTasaBP = Round(nTasaBP * 3, 4)
        ElseIf cFecha > cFechaTerminacion And cTipar = "C" Then
            nTasaBP = Round(nTasaBP * 2, 4)
        End If

        nDias = DateDiff(DateInterval.Day, CTOD(cFechaInicial), CTOD(cFecha))

        drDetalle = dsAgil.Tables("Detalle").NewRow
        drDetalle("Anexo") = cAnexo
        drDetalle("Ciclo") = cCiclo
        drDetalle("Cliente") = cCliente
        drDetalle("Consecutivo") = nConsecutivo
        drDetalle("FechaInicial") = cFechaInicial
        drDetalle("FechaFinal") = cFecha
        drDetalle("Dias") = nDias
        drDetalle("TasaBP") = nTasaBP
        drDetalle("SaldoInicial") = nSaldoInicial
        drDetalle("SaldoFinal") = nSaldoFinal
        drDetalle("Concepto") = "INTERESES"
        drDetalle("Importe") = 0
        drDetalle("FEGA") = 0
        drDetalle("Garantia") = 0
        drDetalle("Intereses") = 0
        dsAgil.Tables("Detalle").Rows.Add(drDetalle)

        ' Aquí calculo los intereses del registro que acabo de aumentar (la variable nSumaIntereses contiene la sumatoria de los intereses de los movimientos posteriores
        ' a la fecha de último corte hasta la fecha del pago)

        nSumaIntereses = 0
        nIntereses = 0

        For Each drDetalle In dsAgil.Tables("Detalle").Rows

            cFechaFinal = drDetalle("FechaFinal")
            If Mid(cFechaFinal, 1, 6) = Mid(cFecha, 1, 6) And cFechaFinal > cUltimoCorte Then
                nSaldoInicial = drDetalle("SaldoInicial")
                nTasaBP = drDetalle("TasaBP")
                nDias = drDetalle("Dias")
                nIntereses = Round(nSaldoInicial * nTasaBP / 36000 * nDias, 2)
                nSumaIntereses = Round(nSumaIntereses + nIntereses, 2)
            End If

            nConsecutivo = drDetalle("Consecutivo")

        Next

        nSaldoFinal = nSaldoInicial + nIntereses

        drDetalle("Intereses") = nIntereses
        drDetalle("SaldoFinal") = nSaldoFinal

        If drDetalle("SaldoInicial") = 0 And drDetalle("SaldoFinal") = 0 Then
            dsAgil.Tables("Detalle").Rows(nConsecutivo - 1).Delete()
            nConsecutivo = nConsecutivo - 1
        ElseIf drDetalle("Importe") = 0 And drDetalle("FEGA") = 0 And drDetalle("Garantia") = 0 And drDetalle("Intereses") = 0 Then
            dsAgil.Tables("Detalle").Rows(nConsecutivo - 1).Delete()
            nConsecutivo = nConsecutivo - 1
        End If

        nCapital = 0
        nFEGA = 0
        nGarantia = 0
        nIntereses = 0

        For Each drDetalle In dsAgil.Tables("Detalle").Rows
            nCapital += drDetalle("Importe")
            nFEGA += drDetalle("FEGA")
            nGarantia += drDetalle("Garantia")
            nIntereses += drDetalle("Intereses")
        Next

        txtPagoTotal.Text = Format(nSaldoFinal - nGarantia, "##,##0.00")
        txtMontoNC.Text = Format(0, "##,##0.00")
        TxtGarantiaNC.Text = Format(0, "##,##0.00")
        TxtFegaNC.Text = Format(0, "##,##0.00")
        TxtInteNC.Text = Format(0, "##,##0.00")
        If nFEGA > 0 Then
            TxtFegaNC.Enabled = True
        Else
            TxtFegaNC.Enabled = False
        End If
        If nGarantia > 0 Then
            TxtGarantiaNC.Enabled = True
        Else
            TxtGarantiaNC.Enabled = False
        End If
        btnCalcularIntereses.Enabled = False
        dgvDeudores.Enabled = False
        btnAumentar.Enabled = True
        BtnSugerir.Enabled = True
        cm1.Dispose()
        CmbConceptos.SelectedIndex = 0
        txtMontoNC.Focus()
    End Sub

    Private Sub btnAumentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAumentar.Click
        If Not IsNumeric(txtMontoNC.Text) Then
            MessageBox.Show("Importe no Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMontoNC.Focus()
            Exit Sub
        End If
        If Not IsNumeric(TxtGarantiaNC.Text) Then
            MessageBox.Show("Importe no Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtGarantiaNC.Focus()
            Exit Sub
        End If
        If Not IsNumeric(TxtFegaNC.Text) Then
            MessageBox.Show("Importe no Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtFegaNC.Focus()
            Exit Sub
        End If
        If Not IsNumeric(TxtInteNC.Text) Then
            MessageBox.Show("Importe no Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtInteNC.Focus()
            Exit Sub
        End If
        If CDec(txtMontoNC.Text) + CDec(TxtGarantiaNC.Text) + CDec(TxtFegaNC.Text) + CDec(TxtInteNC.Text) <= 0 Then
            MessageBox.Show("Nota de credito sin importes", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMontoNC.Focus()
            Exit Sub
        End If
        If CDec(txtMontoNC.Text) + CDec(TxtGarantiaNC.Text) + CDec(TxtFegaNC.Text) + CDec(TxtInteNC.Text) >= CDec(txtPagoTotal.Text) Then
            MessageBox.Show("Nota de credito mayor al adeudo", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMontoNC.Focus()
            Exit Sub
        End If
        If CmbConceptos.SelectedIndex < 0 Then
            MessageBox.Show("Falta seleciona algun concepto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CmbConceptos.Focus()
            Exit Sub
        End If
        Dim nCapitalNC As Decimal = Val(txtMontoNC.Text)
        Dim nFEGANC As Decimal = Val(TxtFegaNC.Text)
        Dim nGarantiaNC As Decimal = Val(TxtGarantiaNC.Text)
        Dim nInteresesNC As Decimal = Val(TxtInteNC.Text)
        Dim nIvaNC As Decimal = 0
        Dim nIvaFegaNC As Decimal = 0
        Dim cnAgil As New SqlConnection(strConn)
        Dim drPagado As DataRow
        Dim cm2 As New SqlCommand()
        Dim daSeries As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()
        Dim nPagoParcial As Decimal = 0

        Select Case Mid(CmbConceptos.Text, 4, 3)
            Case "AVA", "BUR", "COM", "GAS", "NOT", "RPP"
                nCapitalNC = nCapitalNC / 1.16
                nIvaNC = nCapitalNC * 0.16
                nFEGANC = nFEGANC / 1.16
                nIvaFegaNC = nFEGANC * 0.16
                nCapitalNC = Round(nCapitalNC, 2)
                nFEGANC = Round(nFEGANC, 2)
                nIvaNC = Round(nIvaNC, 2)
                nIvaFegaNC = Round(nIvaFegaNC, 2)
            Case Else
                nFEGANC = nFEGANC / 1.16
                nIvaFegaNC = nFEGANC * 0.16
        End Select


        cFecha = DTOC(dtpProceso.Value)

        ' Este registro lo tengo que insertar hasta que se elige Añadir a la lista (contiene los intereses de la fecha de último corte a la fecha de pago)
        If nSumaIntereses > 0 And nVeces = 0 Then
            drDetalleFINAGIL = dtDetalleFINAGIL.NewRow
            drDetalleFINAGIL("Anexo") = cAnexo
            drDetalleFINAGIL("Ciclo") = cCiclo
            drDetalleFINAGIL("Cliente") = cCliente
            drDetalleFINAGIL("Consecutivo") = nConsecutivo
            drDetalleFINAGIL("FechaInicial") = cFechaInicial
            drDetalleFINAGIL("FechaFinal") = cFecha
            drDetalleFINAGIL("Dias") = nDias
            drDetalleFINAGIL("TasaBP") = nTasaBP
            drDetalleFINAGIL("SaldoInicial") = nSaldoInicial
            drDetalleFINAGIL("SaldoFinal") = nSaldoFinal
            drDetalleFINAGIL("Concepto") = "INTERESES"
            drDetalleFINAGIL("Importe") = 0
            drDetalleFINAGIL("FEGA") = 0
            drDetalleFINAGIL("Garantia") = 0
            drDetalleFINAGIL("Intereses") = nSumaIntereses
            drDetalleFINAGIL("Tipar") = cTipar
            dtDetalleFINAGIL.Rows.Add(drDetalleFINAGIL)
        End If
        nConsecutivo += 1


        drPagado = dtPagados.NewRow()
        drPagado("Contrato") = Mid(cAnexo, 1, 5) + "/" + Mid(cAnexo, 6, 4)
        drPagado("Ciclo") = cCiclo
        drPagado("Productor") = Trim(cNombreProductor)
        drPagado("TipoPago") = "NC"
        drPagado("Fecha") = Mid(cFecha, 7, 2) + "/" + Mid(cFecha, 5, 2) + "/" + Mid(cFecha, 1, 4)
        drPagado("Capital") = Format(nCapitalNC, "##,##0.00")
        drPagado("Garantia") = Format(nGarantiaNC, "##,##0.00")
        drPagado("FEGA") = Format(nFEGANC, "##,##0.00")
        drPagado("Intereses") = Format(nInteresesNC, "##,##0.00")
        drPagado("Total") = Format(nInteresesNC + nFEGANC + nCapitalNC + nGarantiaNC, "##,##0.00")
        drPagado("Concepto") = CmbConceptos.Text
        dtPagados.Rows.Add(drPagado)

        ' Inserto el segundo registro con los importes pagados

        drDetalleFINAGIL = dtDetalleFINAGIL.NewRow
        drDetalleFINAGIL("Anexo") = cAnexo
        drDetalleFINAGIL("Ciclo") = cCiclo
        drDetalleFINAGIL("Cliente") = cCliente
        drDetalleFINAGIL("Consecutivo") = nConsecutivo
        drDetalleFINAGIL("FechaInicial") = cFecha
        drDetalleFINAGIL("FechaFinal") = cFecha
        drDetalleFINAGIL("Dias") = 0
        drDetalleFINAGIL("TasaBP") = nTasaBP
        drDetalleFINAGIL("SaldoInicial") = nSaldoFinal
        drDetalleFINAGIL("SaldoFinal") = nSaldoFinal - Round(nInteresesNC + nFEGANC + nCapitalNC + nGarantiaNC, 2)
        drDetalleFINAGIL("Concepto") = CmbConceptos.Text
        drDetalleFINAGIL("Importe") = -nCapitalNC
        drDetalleFINAGIL("FEGA") = -nFEGANC
        drDetalleFINAGIL("Garantia") = -nGarantiaNC
        drDetalleFINAGIL("Intereses") = -nInteresesNC
        drDetalleFINAGIL("Tipar") = cTipar
        dtDetalleFINAGIL.Rows.Add(drDetalleFINAGIL)
        nConsecutivo += 1

        If nIvaNC + nFEGANC > 0 Then
            drPagado = dtPagados.NewRow()
            drPagado("Contrato") = Mid(cAnexo, 1, 5) + "/" + Mid(cAnexo, 6, 4)
            drPagado("Ciclo") = cCiclo
            drPagado("Productor") = Trim(cNombreProductor)
            drPagado("TipoPago") = "NC"
            drPagado("Fecha") = Mid(cFecha, 7, 2) + "/" + Mid(cFecha, 5, 2) + "/" + Mid(cFecha, 1, 4)
            drPagado("Capital") = Format(nIvaNC, "##,##0.00")
            drPagado("Garantia") = 0
            drPagado("FEGA") = Format(nIvaFegaNC, "##,##0.00")
            drPagado("Intereses") = 0
            drPagado("Total") = Format(nInteresesNC + nFEGANC + nCapitalNC + nGarantiaNC + nIvaNC + nIvaFegaNC, "##,##0.00")
            drPagado("Concepto") = "NC IVA"
            dtPagados.Rows.Add(drPagado)

            ' Inserto el segundo registro con los importes pagados

            drDetalleFINAGIL = dtDetalleFINAGIL.NewRow
            drDetalleFINAGIL("Anexo") = cAnexo
            drDetalleFINAGIL("Ciclo") = cCiclo
            drDetalleFINAGIL("Cliente") = cCliente
            drDetalleFINAGIL("Consecutivo") = nConsecutivo
            drDetalleFINAGIL("FechaInicial") = cFecha
            drDetalleFINAGIL("FechaFinal") = cFecha
            drDetalleFINAGIL("Dias") = 0
            drDetalleFINAGIL("TasaBP") = nTasaBP
            drDetalleFINAGIL("SaldoInicial") = nSaldoFinal
            drDetalleFINAGIL("SaldoFinal") = nSaldoFinal - Round(nInteresesNC + nFEGANC + nCapitalNC + nGarantiaNC + nIvaNC + nIvaFegaNC, 2)
            drDetalleFINAGIL("Concepto") = "NC IVA"
            drDetalleFINAGIL("Importe") = -nIvaNC
            drDetalleFINAGIL("FEGA") = -nIvaFegaNC
            drDetalleFINAGIL("Garantia") = 0
            drDetalleFINAGIL("Intereses") = 0
            drDetalleFINAGIL("Tipar") = cTipar
            dtDetalleFINAGIL.Rows.Add(drDetalleFINAGIL)
            nConsecutivo += 1
        End If

        txtMontoNC.Text = Format(0, "##,##0.00")
        TxtGarantiaNC.Text = Format(0, "##,##0.00")
        TxtFegaNC.Text = Format(0, "##,##0.00")
        TxtInteNC.Text = Format(0, "##,##0.00")

        nMontoTotal += nInteresesNC + nFEGANC + nCapitalNC + nGarantiaNC + nIvaNC + nIvaFegaNC
        txtMontoTotal.Text = Format(nMontoTotal, "##,##0.00")

        If nVeces = 0 Then
            With cm2
                .CommandType = CommandType.Text
                .CommandText = "SELECT IDNotasC FROM Llaves"
                .Connection = cnAgil
            End With
            daSeries.Fill(dsAgil, "Series")
            drSerie = dsAgil.Tables("Series").Rows(0)
            txtSerieA.Text = drSerie("IDNotasC").ToString
            Label8.Visible = True
            rbSerieA.Visible = True
            txtSerieA.Visible = True
            nVeces = 1
        End If
        cm2.Dispose()
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click
        'CLAVES DE MOVIMIENTOS PARA NOTAS DE CREDITO
        '01 NC ANALISIS DE SUELOS
        '02 NC(ASISTENCIA)
        '03 NC(AVALUO)
        '04 NC(BURO)
        '05 NC(COMISION)Avio
        '06 NC(COMISION)CC
        '07 NC(GASTOS)
        '08 NC(INTERESES)Avio
        '09 NC(INTERESES)CC
        '10 NC(NOTARIO)
        '11 NC(RPP)
        '12 NC(SEGURO)Irapuato
        '13 NC(SEGURO)los demas
        '14 NC SEGURO DE VIDA
        '15 NC(VALE)

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim daFactura As New SqlDataAdapter(cm2)
        Dim daGrupo As New SqlDataAdapter(cm3)

        Dim drConceptos As DataRow()
        Dim drFactura As DataRow
        Dim drMinistracion As DataRow
        Dim drMovimientos As DataRow
        Dim drPago As DataRow
        Dim dsFactura As New DataSet
        Dim dtMovimientos As New DataTable
        Dim relFacturas As DataRelation

        Dim strInsert As String
        Dim strUpdate As String

        ' Declaración de variables de datos

        Dim cCheque As String = ""
        Dim cCuentaPago As String = ""
        Dim cFechaPago As String = ""
        Dim cFormaPago As String = ""
        Dim cObserva As String = ""
        Dim cPagado As String = ""
        Dim cRenglon As String = ""
        Dim cClave As String = ""
        Dim cRFC As String = ""
        Dim cSerie As String = ""
        Dim cSerieX As String = "" '#ECT para ligar folios fiscales
        Dim i As Integer = 0
        Dim nCapital As Decimal = 0
        Dim nConsecutivoIni As Integer = 0
        Dim nIVA As Decimal = 0
        Dim nMinistracion As Decimal = 0
        Dim nNumero As Integer = 0
        Dim nPos As Integer = 0
        Dim nSaldoGarantia As Decimal = 0
        Dim nSaldoMinistracion As Decimal = 0
        Dim nSubTotal As Decimal = 0

        Dim oFactura As StreamWriter

        nConsecutivoIni = Val(txtFactuPago.Text)


        ' Tengo que procesar la tabla dtPagados y por cada registro voy a afectar las siguientes tablas: 
        ' DetalleFINAGIL
        ' Historia
        ' Hisgin

        ' Además tengo que generar el archivo TXT de la factura electrónica

        ' En primer lugar creo la tabla dtMovimientos

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
        dtMovimientos.Columns.Add("Factura", Type.GetType("System.String")) '#ECT se agrego para ligar folios fiscales

        cnAgil.Open()

        ' Grabo físicamente en DetalleFINAGIL los 2 registros que generó -para cada contrato- la aplicación de pago 

        For Each drDetalleFINAGIL In dtDetalleFINAGIL.Rows
            strInsert = "INSERT INTO DetalleFINAGIL(Anexo, Ciclo, Cliente, Consecutivo, FechaInicial, FechaFinal, Dias, TasaBP, SaldoInicial, SaldoFinal, Concepto, Importe, FEGA, Garantia, Intereses, Factura, Facturado)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & drDetalleFINAGIL("Anexo") & "', '"
            strInsert = strInsert & drDetalleFINAGIL("Ciclo") & "', '"
            strInsert = strInsert & drDetalleFINAGIL("Cliente") & "', "
            strInsert = strInsert & drDetalleFINAGIL("Consecutivo") & ", '"
            strInsert = strInsert & drDetalleFINAGIL("FechaInicial") & "', '"
            strInsert = strInsert & drDetalleFINAGIL("FechaFinal") & "', "
            strInsert = strInsert & drDetalleFINAGIL("Dias") & ", "
            strInsert = strInsert & drDetalleFINAGIL("TasaBP") & ", "
            strInsert = strInsert & drDetalleFINAGIL("SaldoInicial") & ", "
            strInsert = strInsert & drDetalleFINAGIL("SaldoFinal") & ", '"
            strInsert = strInsert & drDetalleFINAGIL("Concepto") & "', "
            strInsert = strInsert & drDetalleFINAGIL("Importe") & ", "
            strInsert = strInsert & drDetalleFINAGIL("FEGA") & ", "
            strInsert = strInsert & drDetalleFINAGIL("Garantia") & ", "
            strInsert = strInsert & drDetalleFINAGIL("Intereses") & ",'',1)"
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()
        Next

        ' Grabo físicamente en Avios la fecha de último corte para cada contrato afectado

        For Each drDetalleFINAGIL In dtDetalleFINAGIL.Rows
            cAnexo = drDetalleFINAGIL("Anexo")
            cFecha = drDetalleFINAGIL("FechaFinal")
            strUpdate = "UPDATE Avios SET UltimoCorte = '" & cFecha & "' WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
            cm1 = New SqlCommand(strUpdate, cnAgil)
            cm1.ExecuteNonQuery()
            Exit For
        Next

        '#ECT para ligar folios Fiscales
        cSerieX = "C"

        'Insertamos los Registros correspondientes en la Historia de Pagos
        For Each drDetalleFINAGIL In dtDetalleFINAGIL.Rows

            If Mid(drDetalleFINAGIL("Concepto"), 1, 2) = "NC" Then
                '#ECT se graba la factura en detalle finagil como informativo
                strUpdate = "UPDATE DetalleFinagil SET Facturado = 1, Factura = '" & cSerieX & nConsecutivoSerie & _
                "' WHERE Anexo = '" & drDetalleFINAGIL("Anexo") & _
                "' AND Ciclo = '" & drDetalleFINAGIL("Ciclo") & _
                "' AND Consecutivo = '" & drDetalleFINAGIL("Consecutivo") & "'"
                cm1 = New SqlCommand(strUpdate, cnAgil)
                cm1.ExecuteNonQuery()

                If drDetalleFINAGIL("Tipar") <> "C" Then
                    If Mid(drDetalleFINAGIL("Concepto"), 4, 3) = "COM" Then
                        cClave = "05"
                    End If
                Else
                    If Mid(drDetalleFINAGIL("Concepto"), 4, 3) = "COM" Then
                        cClave = "06"
                    End If
                End If
                Select Case Mid(drDetalleFINAGIL("Concepto"), 4, 3)
                    Case "IVA"
                        cClave = "77"
                    Case "ANA"
                        cClave = "01"
                    Case "ASI"
                        cClave = "02"
                    Case "AVA"
                        cClave = "03"
                    Case "BUR"
                        cClave = "04"
                    Case "GAS"
                        cClave = "07"
                    Case "NOT"
                        cClave = "10"
                    Case "RPP"
                        cClave = "11"
                    Case "SEG"
                        If InStr(drDetalleFINAGIL("Concepto"), "VIDA") Then
                            cClave = "14"
                        Else
                            If SegIrapuato(drDetalleFINAGIL("Cliente")) = True Then
                                cClave = "12"
                            Else
                                cClave = "13"
                            End If
                        End If
                    Case "VAL"
                        cClave = "15"
                End Select

                cAnexo = drDetalleFINAGIL("Anexo")

                drMovimientos = dtMovimientos.NewRow()
                drMovimientos("Anexo") = cAnexo
                drMovimientos("Letra") = "001"
                drMovimientos("Tipos") = "2"
                drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                drMovimientos("Cve") = cClave
                'drMovimientos("Imp") = (drDetalleFINAGIL("Importe") + drDetalleFINAGIL("FEGA") + drDetalleFINAGIL("Intereses") + drDetalleFINAGIL("Garantia")) * -1
                'drMovimientos("Imp") = (drDetalleFINAGIL("Importe") + drDetalleFINAGIL("FEGA")) * -1

                If Trim(drDetalleFINAGIL("Concepto")) = "NC IVA" Then
                    drMovimientos("Imp") = (drDetalleFINAGIL("Importe") + drDetalleFINAGIL("FEGA")) * -1
                Else
                    drMovimientos("Imp") = (drDetalleFINAGIL("Importe")) * -1
                End If
                drMovimientos("Tip") = "S"
                drMovimientos("Catal") = "N" 'ESTO ES PARA MOVIMIENTOS DE NOTAS DE CREDITO
                drMovimientos("Esp") = 0.0
                drMovimientos("Coa") = "0"
                drMovimientos("Tipmon") = "01"
                drMovimientos("Banco") = "00"
                drMovimientos("Concepto") = txtCheque.Text
                drMovimientos("Factura") = cSerieX & nConsecutivoSerie '#ECT para ligar folios Fiscales
                dtMovimientos.Rows.Add(drMovimientos)


                If Trim(drDetalleFINAGIL("Concepto")) = "NC IVA" Then
                    strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Importe, Banco, Cheque, Observa1, Balance,InstrumentoMonetarios)"
                    strInsert = strInsert & " VALUES ('"
                    strInsert = strInsert & "6" & "', '"
                    strInsert = strInsert & "C" & "', "
                    strInsert = strInsert & nConsecutivoSerie & ", '"
                    strInsert = strInsert & DTOC(FECHA_APLICACION) & "', '"
                    strInsert = strInsert & drDetalleFINAGIL("Anexo") & "', '"
                    strInsert = strInsert & "001" & "', "
                    strInsert = strInsert & (drDetalleFINAGIL("Importe") + drDetalleFINAGIL("Garantia") + drDetalleFINAGIL("FEGA")) * -1 & ", '"
                    strInsert = strInsert & "" & "', '"
                    strInsert = strInsert & txtCheque.Text & "', '"
                    strInsert = strInsert & drDetalleFINAGIL("Concepto") & "', '"
                    strInsert = strInsert & "N" & "','" & CmbInstruMon.SelectedValue & "') "
                    cm1 = New SqlCommand(strInsert, cnAgil)
                    cm1.ExecuteNonQuery()

                    drMovimientos = dtMovimientos.NewRow()
                    drMovimientos("Anexo") = cAnexo
                    drMovimientos("Letra") = "001"
                    drMovimientos("Tipos") = "2"
                    drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                    drMovimientos("Cve") = "65"
                    drMovimientos("Imp") = (drDetalleFINAGIL("Importe") + drDetalleFINAGIL("Garantia") + drDetalleFINAGIL("FEGA")) * -1
                    drMovimientos("Tip") = "S"
                    drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                    drMovimientos("Esp") = 0.0
                    drMovimientos("Coa") = "1"
                    drMovimientos("Tipmon") = "01"
                    drMovimientos("Banco") = "00"
                    drMovimientos("Concepto") = ""
                    drMovimientos("Factura") = cSerieX & nConsecutivoSerie '#ECT para ligar folios Fiscales
                    dtMovimientos.Rows.Add(drMovimientos)
                Else
                    If (drDetalleFINAGIL("Importe")) * -1 > 0 Then

                        strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Importe, Banco, Cheque, Observa1, Balance,InstrumentoMonetarios)"
                        strInsert = strInsert & " VALUES ('"
                        strInsert = strInsert & "6" & "', '"
                        strInsert = strInsert & "C" & "', "
                        strInsert = strInsert & nConsecutivoSerie & ", '"
                        strInsert = strInsert & DTOC(FECHA_APLICACION) & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Anexo") & "', '"
                        strInsert = strInsert & "001" & "', "
                        strInsert = strInsert & (drDetalleFINAGIL("Importe")) * -1 & ", '"
                        strInsert = strInsert & "" & "', '"
                        strInsert = strInsert & txtCheque.Text & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Concepto") & "', '"
                        strInsert = strInsert & "N" & "','" & CmbInstruMon.SelectedValue & "') "
                        cm1 = New SqlCommand(strInsert, cnAgil)
                        cm1.ExecuteNonQuery()

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "65"
                        drMovimientos("Imp") = (drDetalleFINAGIL("Importe")) * -1
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "1"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = "00"
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = cSerieX & nConsecutivoSerie '#ECT para ligar folios Fiscales
                        dtMovimientos.Rows.Add(drMovimientos)

                    End If

                    If (drDetalleFINAGIL("FEGA")) * -1 > 0 Then

                        strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Importe, Banco, Cheque, Observa1, Balance,InstrumentoMonetarios)"
                        strInsert = strInsert & " VALUES ('"
                        strInsert = strInsert & "6" & "', '"
                        strInsert = strInsert & "C" & "', "
                        strInsert = strInsert & nConsecutivoSerie & ", '"
                        strInsert = strInsert & DTOC(FECHA_APLICACION) & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Anexo") & "', '"
                        strInsert = strInsert & "001" & "', "
                        strInsert = strInsert & (drDetalleFINAGIL("FEGA")) * -1 & ", '"
                        strInsert = strInsert & "" & "', '"
                        strInsert = strInsert & txtCheque.Text & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Concepto") & " FEGA', '"
                        strInsert = strInsert & "N" & "','" & CmbInstruMon.SelectedValue & "') "
                        cm1 = New SqlCommand(strInsert, cnAgil)
                        cm1.ExecuteNonQuery()

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "65"
                        drMovimientos("Imp") = (drDetalleFINAGIL("FEGA")) * -1
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "1"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = "00"
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = cSerieX & nConsecutivoSerie '#ECT para ligar folios Fiscales
                        dtMovimientos.Rows.Add(drMovimientos)

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "03"
                        drMovimientos("Imp") = (drDetalleFINAGIL("FEGA")) * -1
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = "N"
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "0"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = "00"
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = cSerieX & nConsecutivoSerie '#ECT para ligar folios Fiscales
                        dtMovimientos.Rows.Add(drMovimientos)

                    End If

                    If (drDetalleFINAGIL("Garantia")) * -1 > 0 Then

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "55"
                        drMovimientos("Imp") = (drDetalleFINAGIL("Garantia")) * -1
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "1"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = "00"
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = cSerieX & nConsecutivoSerie '#ECT para ligar folios Fiscales
                        dtMovimientos.Rows.Add(drMovimientos)

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "67"
                        drMovimientos("Imp") = (drDetalleFINAGIL("Garantia")) * -1
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "0"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = "00"
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = cSerieX & nConsecutivoSerie '#ECT para ligar folios Fiscales
                        dtMovimientos.Rows.Add(drMovimientos)
                    End If

                    If drDetalleFINAGIL("Intereses") * -1 > 0 Then

                        If drDetalleFINAGIL("Tipar") <> "C" Then
                            cClave = "08"
                        Else
                            cClave = "09"
                        End If

                        strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Importe, Banco, Cheque, Observa1, Balance,InstrumentoMonetarios)"
                        strInsert = strInsert & " VALUES ('"
                        strInsert = strInsert & "6" & "', '"
                        strInsert = strInsert & "C" & "', "
                        strInsert = strInsert & nConsecutivoSerie & ", '"
                        strInsert = strInsert & DTOC(FECHA_APLICACION) & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Anexo") & "', '"
                        strInsert = strInsert & "001" & "', "
                        strInsert = strInsert & drDetalleFINAGIL("Intereses") * -1 & ", '"
                        strInsert = strInsert & "00" & "', '"
                        strInsert = strInsert & txtCheque.Text & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Concepto") & " INTERES', '"
                        strInsert = strInsert & "N" & "','" & CmbInstruMon.SelectedValue & "') "
                        cm1 = New SqlCommand(strInsert, cnAgil)
                        cm1.ExecuteNonQuery()

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = cClave
                        drMovimientos("Imp") = drDetalleFINAGIL("Intereses") * -1
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = "N"
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "0"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = "00"
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = cSerieX & nConsecutivoSerie '#ECT para ligar folios Fiscales
                        dtMovimientos.Rows.Add(drMovimientos)

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = cClave
                        drMovimientos("Imp") = drDetalleFINAGIL("Intereses") * -1
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = "N"
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "1"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = "00"
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = cSerieX & nConsecutivoSerie '#ECT para ligar folios Fiscales
                        dtMovimientos.Rows.Add(drMovimientos)
                    End If
                End If
            End If ' fin de NC
        Next
        nConsecutivoSerie += 1

        'Almacenamos los Movimientos Contables

        For Each drMovimientos In dtMovimientos.Rows
            strInsert = "INSERT INTO Hisgin(Anexo, Letra, Tipos, Fepag, Cve, Imp, Tip, Catal, Esp, Coa, Tipmon, Banco, Concepto, Factura)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & drMovimientos("Anexo") & "', '"
            strInsert = strInsert & drMovimientos("Letra") & "', '"
            strInsert = strInsert & drMovimientos("Tipos") & "', '"
            strInsert = strInsert & drMovimientos("Fepag") & "', '"
            strInsert = strInsert & drMovimientos("Cve") & "', "
            strInsert = strInsert & drMovimientos("Imp") & ", '"
            strInsert = strInsert & drMovimientos("Tip") & "', '"
            strInsert = strInsert & drMovimientos("Catal") & "', '"
            strInsert = strInsert & drMovimientos("Esp") & "', '"
            strInsert = strInsert & drMovimientos("Coa") & "', '"
            strInsert = strInsert & drMovimientos("Tipmon") & "', '"
            strInsert = strInsert & drMovimientos("Banco") & "', '"
            strInsert = strInsert & drMovimientos("Concepto") & "', '"
            strInsert = strInsert & drMovimientos("Factura") & "') "
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()
        Next

        ' Generación de la factura electrónica

        cFechaPago = DTOC(FECHA_APLICACION)

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT Numero, Fecha, Importe, Observa1 FROM Historia " & _
                           "WHERE Numero >= " & nConsecutivoIni & " AND Numero <= " & nConsecutivoSerie & " AND Fecha = " & "'" & cFechaPago & "'"
            .Connection = cnAgil
        End With

        With cm3
            .CommandType = CommandType.Text
            .CommandText = "SELECT DISTINCT Historia.Serie, Numero, Fecha, Historia.Anexo, Letra, Cheque, Clientes.Cliente, Descr, Calle, " & _
                           " Colonia, Delegacion, Copos, Clientes.Plaza, RFC, DescPlaza, CuentadePago1, FormadePago1, CuentadePago2, " & _
                           " FormadePago2, CuentadePago3, FormadePago3, CuentadePago4, FormadePago4 FROM Historia" & _
                           " INNER JOIN Avios ON Historia.Anexo = Avios.Anexo" & _
                           " INNER JOIN Clientes ON Avios.Cliente = Clientes. Cliente" & _
                           " INNER JOIN Plazas ON Clientes.Plaza = Plazas.Plaza" & _
                           " WHERE Numero >= " & nConsecutivoIni & " AND Numero <= " & nConsecutivoSerie & " AND Fecha = " & "'" & cFechaPago & "'"
            .Connection = cnAgil
        End With

        ' Llenar el dataset lo cual abre y cierra la conexión

        daFactura.Fill(dsFactura, "Facturas")
        daGrupo.Fill(dsFactura, "Grupo")

        relFacturas = New DataRelation("GpoFacturas", dsFactura.Tables("Grupo").Columns("Numero"), dsFactura.Tables("Facturas").Columns("Numero"))
        dsFactura.EnforceConstraints = False
        dsFactura.Relations.Add(relFacturas)
        dsFactura.EnforceConstraints = True

        For Each drFactura In dsFactura.Tables("Grupo").Rows

            cSerie = Trim(drFactura("Serie"))
            cCheque = Trim(drFactura("Cheque"))
            cRFC = Trim(drFactura("RFC"))
            nNumero = drFactura("Numero")

            For i = 1 To 5
                Select Case i
                    Case 1
                        If RTrim(drFactura("CuentadePago1")) <> "0" And RTrim(drFactura("FormadePago1")) <> "EFECTIVO" Then
                            cCuentaPago = drFactura("CuentadePago1")
                            cFormaPago = RTrim(drFactura("FormadePago1"))
                        ElseIf RTrim(drFactura("CuentadePago1")) = "0" And RTrim(drFactura("FormadePago1")) = "EFECTIVO" Then
                            cCuentaPago = "NO IDENTIFICABLE"
                            cFormaPago = RTrim(drFactura("FormadePago1"))
                        End If
                    Case 2
                        If RTrim(drFactura("CuentadePago2")) <> "0" And RTrim(drFactura("FormadePago2")) <> "EFECTIVO" Then
                            cCuentaPago = cCuentaPago & "," & drFactura("CuentadePago2")
                            cFormaPago = cFormaPago & "," & RTrim(drFactura("FormadePago2"))
                        ElseIf RTrim(drFactura("CuentadePago2")) = "0" And RTrim(drFactura("FormadePago2")) = "EFECTIVO" Then
                            cCuentaPago = cCuentaPago & "," & "NO IDENTIFICABLE"
                            cFormaPago = cFormaPago & "," & RTrim(drFactura("FormadePago2"))
                        End If
                    Case 3
                        If RTrim(drFactura("CuentadePago3")) <> "0" And RTrim(drFactura("FormadePago3")) <> "EFECTIVO" Then
                            cCuentaPago = cCuentaPago & "," & drFactura("CuentadePago3")
                            cFormaPago = cFormaPago & "," & RTrim(drFactura("FormadePago3"))
                        ElseIf RTrim(drFactura("CuentadePago3")) = "0" And RTrim(drFactura("FormadePago3")) = "EFECTIVO" Then
                            cCuentaPago = cCuentaPago & "," & "NO IDENTIFICABLE"
                            cFormaPago = cFormaPago & "," & RTrim(drFactura("FormadePago3"))
                        End If
                    Case 4
                        If RTrim(drFactura("CuentadePago4")) <> "0" And RTrim(drFactura("FormadePago4")) <> "EFECTIVO" Then
                            cCuentaPago = cCuentaPago & "," & drFactura("CuentadePago4")
                            cFormaPago = cFormaPago & "," & RTrim(drFactura("FormadePago4"))
                        ElseIf RTrim(drFactura("CuentadePago4")) = "0" And RTrim(drFactura("FormadePago4")) = "EFECTIVO" Then
                            cCuentaPago = cCuentaPago & "," & "NO IDENTIFICABLE"
                            cFormaPago = cFormaPago & "," & RTrim(drFactura("FormadePago4"))
                        End If
                    Case 5
                        If cCuentaPago = "" And cFormaPago = "" Then
                            cCuentaPago = "NO IDENTIFICABLE"
                            cFormaPago = "NO IDENTIFICABLE"
                        End If
                End Select
            Next

            Dim stmFactura As New FileStream("C:\Facturas\FACTURA_" & cSerie & "_" & nNumero.ToString & ".txt", FileMode.Create, FileAccess.Write, FileShare.None)
            Dim stmWriter As New StreamWriter(stmFactura, System.Text.Encoding.Default)

            stmWriter.WriteLine("H1|" & FECHA_APLICACION.ToShortDateString & "|")

            cRenglon = "M1|" & drFactura("Cliente") & "|" & Mid(drFactura("Anexo"), 1, 5) & "/" & Mid(drFactura("Anexo"), 6, 4) & "|" & cSerie & "|" & nNumero & "|lhernandez@finagil.com.mx|" & CTOD(cFechaPago).ToString("dd/MM/yyyy hh:mm:ss") & "|FINAGIL"
            stmWriter.WriteLine(cRenglon)

            cRenglon = "H3|" & drFactura("Cliente") & "|" & Mid(drFactura("Anexo"), 1, 5) & "/" & Mid(drFactura("Anexo"), 6, 4) & "|" & cSerie & "|" & nNumero & "|" & Trim(drFactura("Descr")) & "|" & _
            Trim(drFactura("Calle")) & "|||" & Trim(drFactura("Colonia")) & "|" & Trim(drFactura("Delegacion")) & "|" & Trim(drFactura("DescPlaza")) & "|" & drFactura("Copos") & "|" & cCuentaPago & "|" & cFormaPago & "|MEXICO|" & Trim(drFactura("RFC")) & "|M.N.|" & _
            "|FACTURA|" & drFactura("Cliente") & "|LEANDRO VALLE 402||REFORMA Y FFCCNN|TOLUCA|ESTADO DE MEXICO|50070|MEXICO"
            stmWriter.WriteLine(cRenglon)

            drConceptos = drFactura.GetChildRows("GpoFacturas")

            nIVA = 0
            nSubTotal = 0

            For Each drMovimientos In drConceptos

                If nNumero = drMovimientos("Numero") Then

                    cObserva = drMovimientos("Observa1")
                    If BuscarTexto(cObserva, "IVA") = False Then
                        cRenglon = "D1|" & drFactura("Cliente") & "|" & Mid(drFactura("Anexo"), 1, 5) & "/" & Mid(drFactura("Anexo"), 6, 4) & "|" & cSerie & "|" & drFactura("Numero") & "|1|||" & Trim(cObserva) & "||" & drMovimientos("Importe")
                        cRenglon = cRenglon.Replace("Ñ", Chr(165))
                        cRenglon = cRenglon.Replace("ñ", Chr(164))
                        cRenglon = cRenglon.Replace("á", Chr(160))
                        cRenglon = cRenglon.Replace("é", Chr(130))
                        cRenglon = cRenglon.Replace("í", Chr(161))
                        cRenglon = cRenglon.Replace("ó", Chr(162))
                        cRenglon = cRenglon.Replace("ú", Chr(163))
                        cRenglon = cRenglon.Replace("Á", Chr(181))
                        cRenglon = cRenglon.Replace("É", Chr(144))
                        cRenglon = cRenglon.Replace("Ó", Chr(224))
                        cRenglon = cRenglon.Replace("Ú", Chr(233))
                        cRenglon = cRenglon.Replace("°", Chr(167))
                        stmWriter.WriteLine(cRenglon)
                    End If

                    If BuscarTexto(cObserva, "IVA") = True Then
                        nIVA += drMovimientos("Importe")
                    Else
                        nSubTotal += drMovimientos("Importe")
                    End If

                End If

            Next

            If nIVA = 0 Then
                cRenglon = "S1|" & drFactura("Cliente") & "|" & Mid(drFactura("Anexo"), 1, 5) & "/" & Mid(drFactura("Anexo"), 6, 4) & "|" & cSerie & "|" & nNumero.ToString & "|" & nSubTotal & "|" & nIVA & "|" & nSubTotal + nIVA & "|" & Letras((nSubTotal + nIVA).ToString) & "|||0"
            Else
                cRenglon = "S1|" & drFactura("Cliente") & "|" & Mid(drFactura("Anexo"), 1, 5) & "/" & Mid(drFactura("Anexo"), 6, 4) & "|" & cSerie & "|" & nNumero.ToString & "|" & nSubTotal & "|" & nIVA & "|" & nSubTotal + nIVA & "|" & Letras((nSubTotal + nIVA).ToString) & "|||16"
            End If
            stmWriter.WriteLine(cRenglon)
            cRenglon = "Z1|" & drFactura("Cliente") & "|" & Mid(drFactura("Anexo"), 1, 5) & "/" & Mid(drFactura("Anexo"), 6, 4) & "|" & cSerie & "|" & nNumero.ToString & "|" & cCheque & "|" & Trim(cRFC) & "|"
            stmWriter.WriteLine(cRenglon)

            stmWriter.Flush()
            stmFactura.Flush()
            stmFactura.Close()

        Next

        strUpdate = "UPDATE Llaves SET IDNotasC = " & nNumero
        cm1 = New SqlCommand(strUpdate, cnAgil)
        cm1.ExecuteNonQuery()
        MsgBox("Proceso Completo", MsgBoxStyle.Information)

        cnAgil.Close()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()

        Me.Close()

    End Sub

    Private Sub rbSerieA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSerieA.CheckedChanged

        nConsecutivoSerie = drSerie("IDNotasC")
        nConsecutivoSerie = nConsecutivoSerie + 1

        Label7.Visible = True
        txtCheque.Visible = True
        'Label6.Visible = True
        'cbBancos.Visible = True
        txtFactuPago.Text = nConsecutivoSerie
        Label5.Visible = True
        txtFactuPago.Visible = True
        txtFactuPago.ReadOnly = True
        btnAplicar.Visible = True
        btnAumentar.Enabled = False

    End Sub

    Function BuscarTexto(ByVal Texto As String, ByVal Busca As String) As Boolean
        Dim i As Integer
        i = InStr(1, Texto, Busca)
        If i > 0 Then
            BuscarTexto = True
        Else
            BuscarTexto = False
        End If
    End Function

    Function SegIrapuato(ByVal Cli As String) As Boolean
        Dim ta As New AviosDSXTableAdapters.ClientesTableAdapter
        Dim x As Integer = ta.SegIraputado(Cli)
        ta.Dispose()
        If x > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub CalculaTabla(ByRef FechaDesde As String)
        Me.AviosDSX.EstadoCuenta.Clear()
        Dim dias As Integer = 0
        Dim FecIni As Date
        Dim fNext As Date = dtpProceso.Value
        Dim FinMes As Date
        Dim Fecfin As Date
        Dim Saldo As Decimal = 0
        Dim Fila As Integer = 1
        Dim POSS As Integer = 1
        Dim Hasta As Integer = 1
        Dim rr As AviosDSX.EstadoCuentaRow
        Dim rrr As AviosDSX.EstadoCuentaRow
        If AplicaGarantiaLIQ = "NO" Then GarantiaLIQ = 0
        For num As Integer = 1 To 2
            rr = Me.AviosDSX.EstadoCuenta.NewRow
            rr.id = POSS
            rr.Saldo = Saldo
            rr.Intereses = 0
            rr.Garantia = 0
            rr.Fega = 0
            rr.SeguroVida = 0
            rr.Dias = 0
            If Fila = 1 Then
                Saldo = GastosIniciales + Importe
                rr.Gastos = GastosIniciales
                FecIni = CTOD(FechaDesde)
                Fecfin = CTOD(FechaDesde)
                rr.FechaIni = FecIni
                rr.FechaFin = Fecfin
                If Fondeo = "03" Then
                    rr.Fega = (Saldo * 0.0116)
                    rr.Garantia = (Saldo * GarantiaLIQ)
                    Saldo += (Saldo * 0.0116) + (Saldo * GarantiaLIQ) '¿lleva IVA?
                End If
                TxtFegaNC.Text = rr.Fega.ToString("n2")
                TxtGarantiaNC.Text = rr.Garantia.ToString("n2")
                FinMes = Fecfin.AddMonths(1)
                FinMes = FinMes.AddDays((FinMes.Day) * -1)
                Fecfin = FinMes
                rr.SaldoFinal = Saldo
                Me.AviosDSX.EstadoCuenta.AddEstadoCuentaRow(rr)
            Else
                Fecfin = Fecha
                FinMes = Fecha
            End If
            rr.Efectivo = Importe
            If 1 > Fila Then
                fNext = CTOD(Me.AviosDSX.AVI_MinistracionesSolicitudes.Rows(Fila).Item("fecha"))
            Else
                fNext = Fecha
            End If

            Do While fNext >= Fecfin
                If FinMes <= fNext Then
                    If FinMes <= Fecfin Then
                        rrr = Me.AviosDSX.EstadoCuenta.NewRow
                        POSS += 1
                        rrr.id = POSS
                        rrr.Saldo = Saldo
                        rrr.Intereses = 0
                        rrr.Garantia = 0
                        rrr.Fega = 0
                        rrr.SeguroVida = 0
                        dias = DateDiff(DateInterval.Day, FecIni, FinMes)
                        rrr.Dias = dias
                        rrr.FechaIni = FecIni
                        rrr.FechaFin = FinMes
                        CalculaInetres(dias, Saldo, FinMes, 0, rrr)
                        rrr.SaldoFinal = Saldo
                        FecIni = FinMes
                        FinMes = FinMes.AddDays(1)
                        FinMes = FinMes.AddMonths(1)
                        FinMes = FinMes.AddDays(-1)
                        Fecfin = FinMes
                        Me.AviosDSX.EstadoCuenta.AddEstadoCuentaRow(rrr)
                    Else
                        dias = DateDiff(DateInterval.Day, FecIni, Fecfin)
                        rr.Dias = dias
                        rr.FechaIni = FecIni
                        rr.FechaFin = Fecfin
                        CalculaInetres(dias, Saldo, Fecfin, 0, rr)
                        FecIni = Fecfin
                        Fecfin = FinMes
                        If Fila <> 1 Then
                            rr.SaldoFinal = Saldo
                            Me.AviosDSX.EstadoCuenta.AddEstadoCuentaRow(rr)
                        End If
                    End If
                Else
                    Exit Do
                End If
            Loop
            Fila += 1
            POSS += 1
        Next
        'If Fondeo = "03" Then
        '    Montos(Fila - 1) = Saldo - (Importe * GarantiaLIQ)
        'Else
        '    Montos(Fila - 1) = Saldo
        'End If
        'Fechas(Fila - 1) = Fecha
        'Dim cat As Double = CATavio(Montos, Fechas)
        TxtInteNC.Text = (Saldo - (CDec(txtMontoNC.Text) + CDec(TxtGarantiaNC.Text) + CDec(TxtFegaNC.Text))).ToString("n2")


    End Sub

    Sub CalculaInetres(ByRef dias As Integer, ByRef Saldo As Decimal, ByVal f As Date, ByRef Accesorios As Decimal, ByRef rr As AviosDSX.EstadoCuentaRow)
        Dim Inte As Decimal
        Dim Vida As Decimal
        Dim Tasa As Decimal = (TIEE + Diferencial) / 100
        If dias > 0 Then
            Inte = (((Saldo * (Tasa)) / 360) * dias)
            rr.Intereses = Inte
            Saldo += Inte
            Saldo += Accesorios
            Accesorios = 0
            If f.AddDays(1).Day = 1 And Fecha <> f Then
                If Saldo <= 5000000 Then
                    Vida = Math.Round((Saldo / 1000) * (Tvida), 2)
                Else
                    Vida = Math.Round((5000000 / 1000) * (Tvida))
                End If
                rr.SeguroVida = Vida
                If Fondeo = "03" Then
                    Saldo += Vida + (Vida * 0.01) + (Vida * GarantiaLIQ)
                    rr.Fega += (Vida * 0.0116)
                    rr.Garantia += (Vida * GarantiaLIQ)
                Else
                    Saldo += Vida
                End If

            End If
        End If
    End Sub

    Sub SacaTIIE(ByVal Mes As String)
        Dim TIIE As New AviosDSXTableAdapters.Vw_SolicitudesTableAdapter
        Dim fec As Date = CTOD(Mes)
        fec = fec.AddMonths(-1)
        Mes = fec.ToString("yyyyMM")
        TIEE = TIIE.TIIE(Mes)
    End Sub

    Private Sub BtnSugerir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSugerir.Click
        Dim FechaDesde As String = DTPDesde.Value.ToString("yyyyMMdd")
        If Not IsNumeric(txtMontoNC.Text) Then
            MessageBox.Show("Importe no Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMontoNC.Focus()
            Exit Sub
        ElseIf (txtMontoNC.Text) <= 0 Then
            MessageBox.Show("Importe no Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMontoNC.Focus()
            Exit Sub
        End If
        If FechaDesde.Length <> 8 Or FechaDesde > DTOC(Date.Now) Then
            MessageBox.Show("Fecha no valida", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If DTPDesde.Value >= dtpProceso.Value Then
            MessageBox.Show("Fecha de cargo Mayor a la de proceso", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If DTPDesde.Value <= CTOD(cFechaAutorizacion) Then
            MessageBox.Show("Fecha de cargo menor a la fecha de primera ministracion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Importe = txtMontoNC.Text
        SacaTIIE(FechaDesde)
        GastosIniciales = 0
        Tvida = 0
        SegAgri = 0
        Fecha = dtpProceso.Value.ToShortDateString
        CalculaTabla(FechaDesde)
    End Sub

    Private Sub TextFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFiltro.TextChanged
        If TxtFiltro.Text.Length > 3 Then
            BindingDeudores.Filter = "productor like '%" & TxtFiltro.Text & "%'"
        Else
            BindingDeudores.Filter = ""
        End If
    End Sub

    
    Private Sub CmbConceptos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbConceptos.SelectedIndexChanged

    End Sub
End Class