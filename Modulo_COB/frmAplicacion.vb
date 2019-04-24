Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports System.Text.ASCIIEncoding

Public Class frmAplicacion

    ' Declaración de variables de conexión ADO .NET de alcance privado

    Dim dtPagados As New DataTable
    Dim dtDetalleFINAGIL As New DataTable
    Dim drDetalleFINAGIL As DataRow
    'Dim drSerie As DataRow
    Private BindingDeudores As Windows.Forms.BindingSource = New BindingSource

    ' Declaración de variables de alcance privado
    Dim cAnexo As String = ""
    Dim cCiclo As String = ""
    Dim cCliente As String = ""
    Dim cFecha As String = ""
    Dim cFechaFinal As String = ""
    Dim cFechaInicial As String = ""
    Dim cNombreProductor As String = ""
    Dim cTipar As String = ""
    Dim nCapital As Decimal = 0
    Dim nConsecutivo As Integer = 0
    'Dim nConsecutivoSerie As Integer = 0
    Dim nDias As Integer = 0
    Dim nFEGA As Decimal = 0
    Dim nGarantia As Decimal = 0
    Dim nIntereses As Decimal = 0
    Dim nMontoTotal As Decimal = 0
    Dim nSaldoFinal As Decimal = 0
    Dim nSaldoInicial As Decimal = 0
    Dim nSumaIntereses As Decimal = 0
    Dim nTasaBP As Decimal = 0
    Dim nTasaBPX As Decimal = 0
    Dim nMoratorios As Decimal = 0
    Dim nTasaMora As Decimal = 0
    Dim nSegVida As Decimal
    Dim nImporteSEGVID As Decimal
    Dim cTipoPersona As String = ""
    Dim SerieX As String = ""
    Dim cSucursal As String = ""
    Dim nEstaTraspasado As Integer = 0
    Dim FacturaMora As Boolean
    Dim SerieXM As String = "M"
    Dim FolioMora As Decimal
    Dim NoGrupo As Decimal = FOLIOS.SacaNoGrupo()

    Private Sub frmAplicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GeneralDS.InstrumentoMonetario' Puede moverla o quitarla según sea necesario.
        Me.InstrumentoMonetarioTableAdapter.Fill(Me.GeneralDS.InstrumentoMonetario)
        dtpProceso.Value = FECHA_APLICACION
        dtpProceso.MinDate = FECHA_APLICACION.AddDays((FECHA_APLICACION.Day - 1) * -1)
        dtpProceso.MaxDate = FECHA_APLICACION

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daDeudores As New SqlDataAdapter(cm1)

        Dim dsAgil As New DataSet
        Dim dtDeudores As New DataTable
        Dim myColArray(1) As DataColumn

        Dim i As Byte = 0
        dtpProceso.Value = FECHA_APLICACION
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
        dtDetalleFINAGIL.Columns.Add("SinMoratorios", Type.GetType("System.String"))

        ' El siguiente Stored Procedure trae los datos del contrato de Habilitación o Avío



        With cm1
            .CommandTimeout = 120
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Vw_AdeudosAvio ORDER BY Productor, Contrato, [Ciclo o Pagaré]"
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
        dgvDeudores.Columns(4).Visible = False
        dgvDeudores.Columns(5).Visible = False

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
        dtPagados.Columns.Add("FEGA", Type.GetType("System.String"))
        dtPagados.Columns.Add("Intereses", Type.GetType("System.String"))
        dtPagados.Columns.Add("Moratorios", Type.GetType("System.String"))
        dtPagados.Columns.Add("SeguroVida", Type.GetType("System.String"))
        dtPagados.Columns.Add("Total", Type.GetType("System.String"))

        dgvPagados.DataSource = dtPagados
        dgvPagados.Columns(0).Width = 250
        dgvPagados.Columns(0).Visible = False
        dgvPagados.Columns(1).Width = 80
        dgvPagados.Columns(2).Width = 60
        dgvPagados.Columns(3).Width = 70
        dgvPagados.Columns(4).Width = 80
        dgvPagados.Columns(5).Width = 80
        dgvPagados.Columns(6).Width = 80
        dgvPagados.Columns(7).Width = 80
        dgvPagados.Columns(8).Width = 80
        dgvPagados.Columns(9).Width = 80

        For i = 0 To dgvPagados.Columns.Count - 1
            dgvPagados.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            If i = 1 Or i = 2 Or i = 3 Then
                dgvPagados.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el encabezado
                dgvPagados.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el contenido
            End If
            If i > 3 Then
                dgvPagados.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el encabezado
                dgvPagados.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el contenido
            End If
        Next

        cm1.Dispose()

    End Sub

    Private Sub dgvDeudores_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDeudores.CellMouseClick
        Dim cCliente As String = dgvDeudores.CurrentRow.Cells(5).Value
        ControlGastosEXT1.CargaXCliente(cCliente)
        If ControlGastosEXT1.Saldo > 0 Then
            btnCalcularIntereses.Enabled = False
            CKaplicaBlanco.Enabled = False
            rbParcial.Enabled = False
            rbTotal.Enabled = False
        Else
            btnCalcularIntereses.Enabled = True
            CKaplicaBlanco.Enabled = True
            rbParcial.Enabled = True
            rbTotal.Enabled = True
        End If
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
        Dim cTipta As String = ""
        Dim cUltimoCorte As String = ""
        Dim nDiferencial As Decimal = 0
        Dim nTasa As Decimal = 0
        Dim cSinMoratorios As String = "N"
        Dim TaTasaMora As New Agil.AviosDSXTableAdapters.AnexosTasaMoraFecORdTableAdapter
        Dim cFechaTerminacion As String = ""
        Dim taTrapaso As New ContaDSTableAdapters.TraspasosAvioCCTableAdapter
        FacturaMora = False

        cFecha = DTOC(dtpProceso.Value)
        cNombreProductor = dgvDeudores.CurrentRow.Cells(0).Value
        cAnexo = Mid(dgvDeudores.CurrentRow.Cells(1).Value, 1, 5) + Mid(dgvDeudores.CurrentRow.Cells(1).Value, 7, 4)
        'NOTIFICACION DE GARANTIA EJERCIDA #ECT20141022+++++++++++++++++++++++++++++++++
        If Val(dgvDeudores.CurrentRow.Cells(4).Value) <> 0 Then
            LbGarantia.Visible = True
        Else
            LbGarantia.Visible = False
        End If
        'NOTIFICACION DE GARANTIA EJERCIDA #ECT20141022+++++++++++++++++++++++++++++++++
        cTipar = dgvDeudores.CurrentRow.Cells(2).Value
        If InStr(cTipar, "Paga") > 0 Then
            cTipar = "C"
            cCiclo = Mid(dgvDeudores.CurrentRow.Cells(2).Value, 1, 2)
        Else
            cTipar = "H"
            cCiclo = Mid(dgvDeudores.CurrentRow.Cells(2).Value, 1, 2)
        End If
        nCapital = dgvDeudores.CurrentRow.Cells(3).Value
        nEstaTraspasado = taTrapaso.EstaTraspasado(cAnexo, cCiclo)

        ' Genero la tabla que contiene las TIIE promedio por mes.   Para FINAGIL considera todos los días del mes y redondea a 4 decimales

        dtTIIE = TIIEavg("FINAGIL")

        ' Tengo que copiar los movimientos que existan físicamente en DetalleFINAGIL en una tabla temporal para poder calcular el registro de intereses ordinarios
        ' (si procedieran) sin necesidad de insertar un registro en la tabla física

        ' El siguiente Command trae los movimientos que existan en DetalleFINAGIL del contrato seleccionado

        'Shell(""My.Settings.RootDoc & "EstadoCuentaAVCC.exe"" " & cAnexo & " " & cCiclo & " FIN 0", AppWinStyle.NormalFocus, True)
        Dim ta As New AviosDSXTableAdapters.AviosTableAdapter
        Dim res As Object

        If UsuarioGlobal.ToLower = "desarrollo" Or UsuarioGlobal.ToLower = "lhernandez" Then
            If dtpProceso.Value >= FECHA_APLICACION Then
                Shell(My.Settings.RootDoc & "Executables\EstadoCuentaAVCC.exe " & cAnexo & " " & cCiclo & " FIN 0 " & UsuarioGlobal & " " & 0, AppWinStyle.NormalFocus, True)
            Else
                Shell(My.Settings.RootDoc & "Executables\EstadoCuentaAVCC.exe " & cAnexo & " " & cCiclo & " FIN 0 " & UsuarioGlobal & " " & DIAS_MENOS, AppWinStyle.NormalFocus, True)
            End If

            res = DBNull.Value
        Else
            'res = ta.EstadoCuentaAvio(cAnexo, cCiclo, 0, UsuarioGlobal)
            'res = Estado_de_Cuenta_Avio(cAnexo, cCiclo, 0, UsuarioGlobal)
            MessageBox.Show("Usuario no valido para aplicaciones", "Usuario NO Valido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If


        If Not IsDBNull(res) Then
            MessageBox.Show(res, "Error Estado de Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        cm1.CommandText = "SELECT SeguroVida FROM Avios WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
        cm1.Connection = cnAgil
        cnAgil.Open()
        nSegVida = cm1.ExecuteScalar
        cnAgil.Close()

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT DetalleFINAGIL.*, Tipta, Tasas, DiferencialFINAGIL, UltimoCorte, FechaTerminacion, SinMoratorios FROM DetalleFINAGIL " &
                           "INNER JOIN Avios ON DetalleFINAGIL.Anexo = Avios.Anexo AND DetalleFINAGIL.Ciclo = Avios.Ciclo " &
                           "WHERE DetalleFINAGIL.Anexo = '" & cAnexo & "' AND DetalleFINAGIL.Ciclo = '" & cCiclo & "' " &
                           "ORDER BY Consecutivo"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daDetalle.Fill(dsAgil, "Detalle")

        For Each drDetalle In dsAgil.Tables("Detalle").Rows

            nTasa = drDetalle("Tasas")
            nDiferencial = drDetalle("DiferencialFINAGIL")
            cTipta = drDetalle("Tipta")
            cUltimoCorte = drDetalle("UltimoCorte")
            cFechaTerminacion = drDetalle("FechaTerminacion")

            cCliente = drDetalle("Cliente")
            nConsecutivo = drDetalle("Consecutivo")
            cFechaInicial = drDetalle("FechaFinal")
            nSaldoInicial = drDetalle("SaldoFinal")
            cSinMoratorios = drDetalle("SinMoratorios")

        Next

        cm1.CommandText = "SELECT Tipo FROM Clientes WHERE cliente = '" & cCliente & "'"
        cm1.Connection = cnAgil
        cnAgil.Open()
        cTipoPersona = cm1.ExecuteScalar
        cnAgil.Close()

        cm1.CommandText = "SELECT Sucursal FROM Clientes WHERE cliente = '" & cCliente & "'"
        cm1.Connection = cnAgil
        cnAgil.Open()
        cSucursal = cm1.ExecuteScalar
        cnAgil.Close()

        If nEstaTraspasado > 0 Then
            SerieX = "REP"
            Label10.Text = "Serie REP"
            txtFolio.Text = Folios.FolioPago
        Else
            If cSucursal = "04" Then
                SerieX = "MXL"
                Label10.Text = "Serie MXL"
                txtFolio.Text = Folios.FolioMXL
            Else
                SerieX = "A"
                Label10.Text = "Serie A"
                txtFolio.Text = Folios.FolioA
            End If
        End If
        If CKaplicaBlanco.Checked = True Then
            SerieX = "AB"
            Label10.Text = "Serie AB"
            txtFolio.Text = Folios.FolioBlanco
        End If
        FolioMora = Folios.FolioMora

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

            'SOLICITADO POR ELISANDER DEBIDO A PRORROGA, SE SUMA UN PUNTO PORCENTUAL A PARTIR DE ENERO++++++++++++
            If (cAnexo = "070320012" Or cAnexo = "070860007" Or cAnexo = "070790010" Or cAnexo = "070780012" Or cAnexo = "070600011" Or cAnexo = "071330006") And CTOD(cFecha) >= CDate("01/01/2015") Then
                nTasaBP += 1
            End If
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        End If

        Select Case cAnexo 'PRUEBA ELISANDER
            Case "032620003"
                nTasaBP = 12.2915
            Case "086250006", "086310009"
                nTasaBP = Round(nTasaBP / 3, 4)
                If cFecha = "20161216" And cAnexo = "086310009" Then nTasaBP = 1.7571
                If cFecha = "20161222" And cAnexo = "086250006" Then nTasaBP = 7.2823
                nTasaMora = nTasaBP
            Case Else
                nTasaBPX = nTasaBP
                If cFecha > cFechaTerminacion And cTipar <> "C" And cSinMoratorios = "N" Then
                    nTasaBP = Round(nTasaBP * 3, 4)
                    nTasaMora = nTasaBP
                ElseIf cFecha > cFechaTerminacion And cTipar = "C" And cSinMoratorios = "N" Then
                    nTasaBP = Round(nTasaBP * 2, 4)
                    nTasaMora = nTasaBP
                End If
                '++++++++++REVISA SI TIENE DESPCUENTO PO DISMINUCION DE TASA
                If TaTasaMora.TieneTasaOrdinaria(cAnexo, cCiclo) > 0 Then
                    nTasaBP = nTasaBPX
                    If TaTasaMora.TieneTercioDeTasa(cAnexo, cCiclo, True) > 0 Then
                        nTasaBP = Math.Round(nTasaBPX / 3, 4)
                    End If
                End If
                '++++++++++REVISA SI TIENE DESPCUENTO PO DISMINUCION DE TASA
        End Select

        nDias = DateDiff(DateInterval.Day, CTOD(cFechaInicial), CTOD(cFecha))

        If cFecha <= cFechaTerminacion And cFechaTerminacion >= cUltimoCorte Then ' corte de interes ordinarios
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
            nIntereses = Round(nSaldoInicial * nTasaBP / 36000 * nDias, 2)
            nSaldoFinal = nSaldoInicial + nIntereses
            drDetalle("Intereses") = nIntereses
            drDetalle("SaldoFinal") = nSaldoFinal
            If nIntereses <> 0 Then
                dsAgil.Tables("Detalle").Rows.Add(drDetalle)
            End If

            nSumaIntereses = nIntereses
            nSaldoFinal = nSaldoInicial + nIntereses
            nDias = 0
            nIntereses = 0
            nImporteSEGVID = 0
        Else
            nSaldoFinal = nSaldoInicial
            nSumaIntereses = 0
            If nDias > 0 Then
                nMoratorios = Round(nSaldoInicial * nTasaBP / 36000 * nDias, 2)
                nImporteSEGVID = Round((nSaldoInicial) / 1000 * (nSegVida / 30) * nDias, 2)
                FacturaMora = True
                If cTipoPersona = "M" Then
                    nImporteSEGVID = 0
                End If
            End If
        End If

        nCapital = 0
        nFEGA = 0
        nGarantia = 0
        nIntereses = 0
        If nEstaTraspasado > 0 Then
            If cFecha < cFechaTerminacion Then
                MessageBox.Show("No se puede hacer un pago con fecha anterior a la de su vencimiento, contrato TRASPASADO como Exigible.", "Error Contrato Traspasado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            If FECHA_APLICACION.ToString("yyyyMMdd") > cFechaTerminacion Then
                MessageBox.Show("No se puede hacer un pago de un credito que aún se a Traspasado.", "Error Contrato Sin traspaso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        For Each drDetalle In dsAgil.Tables("Detalle").Rows
            nCapital += drDetalle("Importe")
            nFEGA += drDetalle("FEGA")
            nGarantia += drDetalle("Garantia")
            nIntereses += drDetalle("Intereses")
        Next

        rbTotal.Checked = False
        rbParcial.Checked = False
        btnAumentar.Enabled = False

        txtPagoTotal.Text = Format(nSaldoFinal - nGarantia + nImporteSEGVID + nMoratorios, "##,##0.00")
        txtPagoParcial.Text = Format(0, "##,##0.00")
        btnCalcularIntereses.Enabled = False
        CKaplicaBlanco.Enabled = False

        cm1.Dispose()

    End Sub

    Private Sub btnAumentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAumentar.Click
        If CDbl(txtPagoTotal.Text) < nMoratorios + nImporteSEGVID And rbTotal.Checked = True Then
            MessageBox.Show("el importe no cubre moratorios ni seguro de Vida.", "Pago Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CDbl(txtPagoParcial.Text) < nMoratorios + nImporteSEGVID And rbParcial.Checked = True Then
            MessageBox.Show("el importe no cubre moratorios ni seguro de Vida.", "Pago Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If nMoratorios > 0 Then
            Dim newfrmMoratorios As New frmMoratorios(nMoratorios, True)
            newfrmMoratorios.ShowDialog()
            nMoratorios = newfrmMoratorios.Moratorios()
        End If
        If nImporteSEGVID > 0 Then
            Dim newfrmMoratorios As New frmMoratorios(nImporteSEGVID, False)
            newfrmMoratorios.ShowDialog()
            nImporteSEGVID = newfrmMoratorios.Moratorios()
        End If



        Dim cnAgil As New SqlConnection(strConn)
        Dim drPagado As DataRow
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daBancos As New SqlDataAdapter(cm1)
        Dim daSeries As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()
        Dim dsBcos As New DataSet()

        Dim nPagoParcial As Decimal = 0
        Dim nVeces As Integer = 0

        cFecha = DTOC(dtpProceso.Value)

        ' Este registro lo tengo que insertar hasta que se elige Añadir a la lista (contiene los intereses de la fecha de último corte a la fecha de pago)

        If nSumaIntereses > 0 Then
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

        If rbTotal.Checked = True Then

            drPagado = dtPagados.NewRow()
            drPagado("Productor") = Trim(cNombreProductor)
            drPagado("Contrato") = Mid(cAnexo, 1, 5) + "/" + Mid(cAnexo, 6, 4)
            drPagado("Ciclo") = cCiclo
            drPagado("TipoPago") = "TOTAL"
            drPagado("Fecha") = Mid(cFecha, 7, 2) + "/" + Mid(cFecha, 5, 2) + "/" + Mid(cFecha, 1, 4)
            drPagado("Capital") = Format(nCapital, "##,##0.00")
            drPagado("FEGA") = Format(nFEGA, "##,##0.00")
            drPagado("Intereses") = Format(nIntereses, "##,##0.00")
            drPagado("Moratorios") = Format(nMoratorios, "##,##0.00")
            drPagado("SeguroVida") = Format(nImporteSEGVID, "##,##0.00")
            drPagado("Total") = Format(nIntereses + nFEGA + nCapital + nMoratorios + nImporteSEGVID, "##,##0.00")
            dtPagados.Rows.Add(drPagado)

            nMontoTotal += nIntereses + nFEGA + nCapital + nMoratorios + nImporteSEGVID
            txtMontoTotal.Text = Format(nMontoTotal, "##,##0.00")

            ' Inserto el segundo registro con los importes pagados

            drDetalleFINAGIL = dtDetalleFINAGIL.NewRow
            drDetalleFINAGIL("Anexo") = cAnexo
            drDetalleFINAGIL("Ciclo") = cCiclo
            drDetalleFINAGIL("Cliente") = cCliente
            drDetalleFINAGIL("Consecutivo") = nConsecutivo + 1
            drDetalleFINAGIL("FechaInicial") = cFecha
            drDetalleFINAGIL("FechaFinal") = cFecha
            drDetalleFINAGIL("Dias") = 0
            drDetalleFINAGIL("TasaBP") = nTasaBP
            drDetalleFINAGIL("SaldoInicial") = nSaldoFinal
            drDetalleFINAGIL("SaldoFinal") = 0
            drDetalleFINAGIL("Concepto") = "PAGO"
            drDetalleFINAGIL("Importe") = -nCapital
            drDetalleFINAGIL("FEGA") = -nFEGA
            drDetalleFINAGIL("Garantia") = -nGarantia
            drDetalleFINAGIL("Intereses") = -nIntereses
            drDetalleFINAGIL("Tipar") = cTipar
            dtDetalleFINAGIL.Rows.Add(drDetalleFINAGIL)

        ElseIf rbParcial.Checked = True Then

            nPagoParcial = CDbl(txtPagoParcial.Text)

            nPagoParcial = Round(nPagoParcial - nImporteSEGVID, 2)
            nPagoParcial = Round(nPagoParcial - nMoratorios, 2)


            If nPagoParcial > 0 And nPagoParcial >= nIntereses Then
                ' El pago cubre totalmente los intereses
                nPagoParcial = Round(nPagoParcial - nIntereses, 2)
            Else
                ' El pago cubre parcialmente los intereses
                nIntereses = nPagoParcial
                nGarantia = 0
                nFEGA = 0
                nCapital = 0
                nPagoParcial = 0
            End If

            ' Ahora reviso si el pago parcial cubre o no el importe de la Garantía FEGA

            If nPagoParcial > 0 And nPagoParcial >= nFEGA Then

                ' El pago parcial cubre totalmente la Garantía FEGA

                nPagoParcial = Round(nPagoParcial - nFEGA, 2)

            Else

                ' El pago cubre parcialmente la Garantía FEGA

                nGarantia = 0
                nFEGA = nPagoParcial
                nCapital = 0
                nPagoParcial = 0

            End If

            ' Por último reviso si el pago parcial cubre o no el importe del Capital

            If nPagoParcial > 0 Then

                If nPagoParcial >= nCapital Then

                    ' El pago cubre totalmente el Capital

                    nPagoParcial = Round(nPagoParcial - nCapital, 2)

                Else

                    ' El pago cubre parcialmente el Capital

                    nCapital = nPagoParcial
                    nPagoParcial = 0

                End If

            Else

                nCapital = 0

            End If

            If nCapital > 0 And nGarantia > 0 Then
                If (nCapital * 0.1) > nGarantia Then
                    nGarantia = Round(nGarantia, 2)
                Else
                    nGarantia = Round(nCapital * 0.1, 2)
                End If
            End If

            drPagado = dtPagados.NewRow()
            drPagado("Contrato") = Mid(cAnexo, 1, 5) + "/" + Mid(cAnexo, 6, 4)
            drPagado("Ciclo") = cCiclo
            drPagado("Productor") = Trim(cNombreProductor)
            drPagado("TipoPago") = "PARCIAL"
            drPagado("Fecha") = Mid(cFecha, 7, 2) + "/" + Mid(cFecha, 5, 2) + "/" + Mid(cFecha, 1, 4)
            drPagado("Capital") = Format(nCapital, "##,##0.00")
            drPagado("FEGA") = Format(nFEGA, "##,##0.00")
            drPagado("Intereses") = Format(nIntereses, "##,##0.00")
            drPagado("Moratorios") = Format(nMoratorios, "##,##0.00")
            drPagado("SeguroVida") = Format(nImporteSEGVID, "##,##0.00")
            drPagado("Total") = Format(nIntereses + nFEGA + nCapital + nMoratorios + nImporteSEGVID, "##,##0.00")
            dtPagados.Rows.Add(drPagado)

            ' Inserto el segundo registro con los importes pagados

            drDetalleFINAGIL = dtDetalleFINAGIL.NewRow
            drDetalleFINAGIL("Anexo") = cAnexo
            drDetalleFINAGIL("Ciclo") = cCiclo
            drDetalleFINAGIL("Cliente") = cCliente
            drDetalleFINAGIL("Consecutivo") = nConsecutivo + 1
            drDetalleFINAGIL("FechaInicial") = cFecha
            drDetalleFINAGIL("FechaFinal") = cFecha
            drDetalleFINAGIL("Dias") = 0
            drDetalleFINAGIL("TasaBP") = nTasaBP
            drDetalleFINAGIL("SaldoInicial") = nSaldoFinal
            drDetalleFINAGIL("SaldoFinal") = nSaldoFinal - Round(nIntereses + nFEGA + nCapital + nGarantia, 2)
            drDetalleFINAGIL("Concepto") = "PAGO"
            drDetalleFINAGIL("Importe") = -nCapital
            drDetalleFINAGIL("FEGA") = -nFEGA
            drDetalleFINAGIL("Garantia") = -nGarantia
            drDetalleFINAGIL("Intereses") = -nIntereses
            drDetalleFINAGIL("Tipar") = cTipar
            dtDetalleFINAGIL.Rows.Add(drDetalleFINAGIL)

            txtPagoParcial.Text = Format(nCapital + nFEGA + nIntereses, "##,##0.00")
            nMontoTotal += nIntereses + nFEGA + nCapital + nMoratorios + nImporteSEGVID
            txtMontoTotal.Text = Format(nMontoTotal, "##,##0.00")

        End If

        ' Quitar el contrato de Contratos con Adeudo

        dgvDeudores.Rows.Remove(dgvDeudores.CurrentRow)
        dgvDeudores.Update()

        If nVeces = 0 Then

            ' Este Stored Procedure regresa los datos de los Bancos

            With cm1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Bancos1"
                .Connection = cnAgil
            End With

            ' El siguiente Command trae los consecutivos de cada Serie

            With cm2
                .CommandType = CommandType.Text
                .CommandText = "SELECT IDSerieA, IDSerieMXL, IDBlanco FROM Llaves"
                .Connection = cnAgil
            End With

            ' Llenar los dataset lo cual abre y cierra la conexión

            daBancos.Fill(dsBcos, "Bancos")
            daSeries.Fill(dsAgil, "Series")

            ' Lleno cbBancos con el nombre de los Bancos

            cbBancos.DataSource = dsBcos
            cbBancos.DisplayMember = "Bancos.DescBanco"
            cbBancos.ValueMember = "Bancos.Banco"

            cbBancos.SelectedIndex = 0

            ' Toma el número consecutivo de facturas de pago -que depende de la Serie- y lo incrementa en uno

            'drSerie = dsAgil.Tables("Series").Rows(0)
            'txtSerie.Text = drSerie("IDSerieA").ToString
            'txtSerieMXL.Text = drSerie("IDSerieMXL").ToString
            'TxtSerieBlanco.Text = drSerie("IDBlanco").ToString

            'Label8.Visible = True
            'rbSerieA.Visible = True
            'txtSerie.Visible = True
            'rbSerieMXL.Visible = True
            'txtSerieMXL.Visible = True
            'RbSerieBlanco.Visible = True
            'TxtSerieBlanco.Visible = True


            nVeces = 1

        End If

        btnAumentar.Enabled = False
        btnAplicar.Visible = True
        cm1.Dispose()
        cm2.Dispose()

    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click

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

        Dim cBanco As String = ""
        Dim cCheque As String = ""
        Dim cCuentaPago As String = ""
        Dim cFechaPago As String = ""
        Dim cFormaPago As String = ""
        Dim cObserva As String = ""
        Dim cPagado As String = ""
        Dim cRenglon As String = ""
        Dim cRFC As String = ""
        'Dim cSerie As String = ""
        'Dim cSerieX As String = "" '#ECT para ligar folios fiscales
        Dim i As Integer = 0
        Dim nCapital As Decimal = 0
        Dim nConsecutivoIni As Integer = 0
        Dim nIVA As Decimal = 0
        Dim nMinistracion As Decimal = 0
        'Dim nNumero As Integer = 0
        Dim nPos As Integer = 0
        Dim nSaldoGarantia As Decimal = 0
        Dim nSaldoMinistracion As Decimal = 0
        Dim nSubTotal As Decimal = 0
        Dim oFactura As StreamWriter

        nConsecutivoIni = Val(txtFolio.Text)
        cBanco = cbBancos.SelectedValue

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
        dtMovimientos.Columns.Add("Grupo", Type.GetType("System.Decimal"))

        cnAgil.Open()

        ' Grabo físicamente en DetalleFINAGIL los 2 registros que generó -para cada contrato- la aplicación de pago 

        For Each drDetalleFINAGIL In dtDetalleFINAGIL.Rows
            strInsert = "INSERT INTO DetalleFINAGIL(Anexo, Ciclo, Cliente, Consecutivo, FechaInicial, FechaFinal, Dias, TasaBP, SaldoInicial, SaldoFinal, Concepto, Importe, FEGA, Garantia, Intereses)"
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
            strInsert = strInsert & drDetalleFINAGIL("Intereses") & ")"
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
        Next

        ''#ECT para ligar folios Fiscales
        'If rbSerieA.Checked = True Then
        '    cSerieX = "A"
        'ElseIf rbSerieMXL.Checked = True Then
        '    cSerieX = "MXL"
        'ElseIf RbSerieBlanco.Checked = True Then
        '    cSerieX = "AB"
        'End If
        'If nEstaTraspasado > 0 Then
        '    cSerieX = "REP"
        'End If


        'Insertamos los Registros correspondientes en la Historia de Pagos
        For Each drDetalleFINAGIL In dtDetalleFINAGIL.Rows

            '#ECT se graba la factura en detalle finagil como informativo
            strUpdate = "UPDATE DetalleFinagil SET Factura = '" & SerieX & txtFolio.Text &
            "' WHERE Anexo = '" & drDetalleFINAGIL("Anexo") &
            "' AND Ciclo = '" & drDetalleFINAGIL("Ciclo") &
            "' AND Consecutivo = '" & drDetalleFINAGIL("Consecutivo") & "'"
            cm1 = New SqlCommand(strUpdate, cnAgil)
            cm1.ExecuteNonQuery()

            If nEstaTraspasado = 0 Then
                If drDetalleFINAGIL("Concepto") = "PAGO" Then

                    cAnexo = drDetalleFINAGIL("Anexo")
                    drMovimientos = dtMovimientos.NewRow()
                    drMovimientos("Anexo") = cAnexo
                    drMovimientos("Letra") = "001"
                    drMovimientos("Tipos") = "2"
                    drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                    drMovimientos("Cve") = "99"
                    drMovimientos("Imp") = (drDetalleFINAGIL("Importe") + drDetalleFINAGIL("FEGA") + drDetalleFINAGIL("Intereses")) * -1 + nMoratorios + nImporteSEGVID
                    drMovimientos("Tip") = "S"
                    drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                    drMovimientos("Esp") = 0.0
                    drMovimientos("Coa") = "0"
                    drMovimientos("Tipmon") = "01"
                    drMovimientos("Banco") = cBanco
                    drMovimientos("Concepto") = txtCheque.Text
                    drMovimientos("Factura") = SerieX & txtFolio.Text '#ECT para ligar folios Fiscales
                    drMovimientos("Grupo") = NoGrupo
                    dtMovimientos.Rows.Add(drMovimientos)

                    If (drDetalleFINAGIL("Importe") + drDetalleFINAGIL("FEGA")) * -1 > 0 Then

                        strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Importe, Banco, Cheque, Observa1, Balance,InstrumentoMonetario, FechaPago)"
                        strInsert = strInsert & " VALUES ('"
                        strInsert = strInsert & "6" & "', '"
                        If CKaplicaBlanco.Checked = True Then
                            strInsert = strInsert & "AB" & "', "
                        Else
                            strInsert = strInsert & SerieX & "', "
                        End If
                        strInsert = strInsert & txtFolio.Text & ", '"
                        strInsert = strInsert & DTOC(FECHA_APLICACION) & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Anexo") & "', '"
                        strInsert = strInsert & cCiclo & "', "
                        strInsert = strInsert & (drDetalleFINAGIL("Importe") + drDetalleFINAGIL("FEGA")) * -1 & ", '"
                        strInsert = strInsert & cBanco & "', '"
                        strInsert = strInsert & txtCheque.Text & "', '"
                        strInsert = strInsert & "PAGO CREDITO DE AVIO" & "', '"
                        strInsert = strInsert & "N" & "','" & CmbInstruMon.SelectedValue & "','"
                        strInsert += dtpProceso.Value.ToString("MM/dd/yyyy") & "') "
                        cm1 = New SqlCommand(strInsert, cnAgil)
                        cm1.ExecuteNonQuery()

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "65"
                        drMovimientos("Imp") = (drDetalleFINAGIL("Importe") + drDetalleFINAGIL("FEGA")) * -1
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "1"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = cBanco
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = SerieX & txtFolio.Text '#ECT para ligar folios Fiscales
                        drMovimientos("Grupo") = NoGrupo
                        dtMovimientos.Rows.Add(drMovimientos)

                    End If

                    If (drDetalleFINAGIL("Garantia")) * -1 > 0 Then

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "73"
                        drMovimientos("Imp") = (drDetalleFINAGIL("Garantia")) * -1
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "1"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = cBanco
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = SerieX & txtFolio.Text '#ECT para ligar folios Fiscales
                        drMovimientos("Grupo") = NoGrupo
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
                        drMovimientos("Banco") = cBanco
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = SerieX & txtFolio.Text '#ECT para ligar folios Fiscales
                        drMovimientos("Grupo") = NoGrupo
                        dtMovimientos.Rows.Add(drMovimientos)

                    End If

                    If drDetalleFINAGIL("Intereses") * -1 > 0 Then

                        strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Importe, Banco, Cheque, Observa1, Balance,InstrumentoMonetario, FechaPago)"
                        strInsert = strInsert & " VALUES ('"
                        strInsert = strInsert & "6" & "', '"
                        If CKaplicaBlanco.Checked = True Then
                            strInsert = strInsert & "AB" & "', "
                        Else
                            strInsert = strInsert & SerieX & "', "
                        End If
                        strInsert = strInsert & txtFolio.Text & ", '"
                        strInsert = strInsert & DTOC(FECHA_APLICACION) & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Anexo") & "', '"
                        strInsert = strInsert & cCiclo & "', "
                        strInsert = strInsert & drDetalleFINAGIL("Intereses") * -1 & ", '"
                        strInsert = strInsert & cBanco & "', '"
                        strInsert = strInsert & txtCheque.Text & "', '"
                        strInsert = strInsert & "INTERESES AVIO" & "', '"
                        strInsert = strInsert & "N" & "','" & CmbInstruMon.SelectedValue & "','"
                        strInsert += dtpProceso.Value.ToString("MM/dd/yyyy") & "') "
                        cm1 = New SqlCommand(strInsert, cnAgil)
                        cm1.ExecuteNonQuery()

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "72"
                        drMovimientos("Imp") = drDetalleFINAGIL("Intereses") * -1
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "1"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = cBanco
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = SerieX & txtFolio.Text '#ECT para ligar folios Fiscales
                        drMovimientos("Grupo") = NoGrupo
                        dtMovimientos.Rows.Add(drMovimientos)
                    End If
                    If nMoratorios > 0 Then
                        strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Importe, Banco, Cheque, Observa1, Balance,InstrumentoMonetario, FechaPago)"
                        strInsert = strInsert & " VALUES ('"
                        strInsert = strInsert & "6" & "', '"
                        If CKaplicaBlanco.Checked = True Then
                            strInsert = strInsert & "AB" & "', "
                        Else
                            strInsert = strInsert & SerieXM & "', "
                        End If
                        strInsert = strInsert & FolioMora & ", '"
                        strInsert = strInsert & DTOC(FECHA_APLICACION) & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Anexo") & "', '"
                        strInsert = strInsert & cCiclo & "', "
                        strInsert = strInsert & nMoratorios & ", '"
                        strInsert = strInsert & cBanco & "', '"
                        strInsert = strInsert & txtCheque.Text & "', '"
                        strInsert = strInsert & "INTERESES MORATORIO AVIO" & "', '"
                        strInsert = strInsert & "N" & "','" & CmbInstruMon.SelectedValue & "','"
                        strInsert += dtpProceso.Value.ToString("MM/dd/yyyy") & "') "
                        cm1 = New SqlCommand(strInsert, cnAgil)
                        cm1.ExecuteNonQuery()

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "22"
                        drMovimientos("Imp") = nMoratorios
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "1"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = cBanco
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = SerieXM & FolioMora '#ECT para ligar folios Fiscales
                        drMovimientos("Grupo") = NoGrupo
                        dtMovimientos.Rows.Add(drMovimientos)

                    End If

                    If nImporteSEGVID > 0 Then
                        strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Importe, Banco, Cheque, Observa1, Balance,InstrumentoMonetario, FechaPago)"
                        strInsert = strInsert & " VALUES ('"
                        strInsert = strInsert & "6" & "', '"
                        If CKaplicaBlanco.Checked = True Then
                            strInsert = strInsert & "AB" & "', "
                        Else
                            strInsert = strInsert & SerieXM & "', "
                        End If
                        strInsert = strInsert & FolioMora & ", '"
                        strInsert = strInsert & DTOC(FECHA_APLICACION) & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Anexo") & "', '"
                        strInsert = strInsert & cCiclo & "', "
                        strInsert = strInsert & nImporteSEGVID & ", '"
                        strInsert = strInsert & cBanco & "', '"
                        strInsert = strInsert & txtCheque.Text & "', '"
                        strInsert = strInsert & "SEGURO DE VIDA" & "', '"
                        strInsert = strInsert & "N" & "','" & CmbInstruMon.SelectedValue & "','"
                        strInsert += dtpProceso.Value.ToString("MM/dd/yyyy") & "') "
                        cm1 = New SqlCommand(strInsert, cnAgil)
                        cm1.ExecuteNonQuery()

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "98"
                        drMovimientos("Imp") = nImporteSEGVID
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "1"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = cBanco
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = SerieXM & FolioMora '#ECT para ligar folios Fiscales
                        drMovimientos("Grupo") = NoGrupo
                        dtMovimientos.Rows.Add(drMovimientos)
                    End If
                    'txtfolio.text += 1
                End If
            Else '++++++++++++++++++++++++CREDITOS CON TRASPASOS DE CARTERA+++++++++++++++++++++++++++++++++++++++++++++++
                If drDetalleFINAGIL("Concepto") = "PAGO" Then

                    cAnexo = drDetalleFINAGIL("Anexo")
                    drMovimientos = dtMovimientos.NewRow()
                    drMovimientos("Anexo") = cAnexo
                    drMovimientos("Letra") = "001"
                    drMovimientos("Tipos") = "2"
                    drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                    drMovimientos("Cve") = "99"
                    drMovimientos("Imp") = (drDetalleFINAGIL("Importe") + drDetalleFINAGIL("FEGA") + drDetalleFINAGIL("Intereses")) * -1 + nMoratorios + nImporteSEGVID
                    drMovimientos("Tip") = "S"
                    drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                    drMovimientos("Esp") = 0.0
                    drMovimientos("Coa") = "0"
                    drMovimientos("Tipmon") = "01"
                    drMovimientos("Banco") = cBanco
                    drMovimientos("Concepto") = txtCheque.Text
                    drMovimientos("Factura") = SerieX & txtFolio.Text '#ECT para ligar folios Fiscales
                    drMovimientos("Grupo") = NoGrupo
                    dtMovimientos.Rows.Add(drMovimientos)

                    If (drDetalleFINAGIL("Importe") + drDetalleFINAGIL("FEGA")) * -1 > 0 Then

                        strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Importe, Banco, Cheque, Observa1, Balance,InstrumentoMonetario, FechaPago)"
                        strInsert = strInsert & " VALUES ('"
                        strInsert = strInsert & "6" & "', '"
                        If CKaplicaBlanco.Checked = True Then
                            strInsert = strInsert & "AB" & "', "
                        Else
                            strInsert = strInsert & SerieX & "', "
                        End If
                        strInsert = strInsert & txtFolio.Text & ", '"
                        strInsert = strInsert & DTOC(FECHA_APLICACION) & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Anexo") & "', '"
                        strInsert = strInsert & cCiclo & "', "
                        strInsert = strInsert & (drDetalleFINAGIL("Importe") + drDetalleFINAGIL("FEGA")) * -1 & ", '"
                        strInsert = strInsert & cBanco & "', '"
                        strInsert = strInsert & txtCheque.Text & "', '"
                        strInsert = strInsert & "PAGO CREDITO DE AVIO" & "', '"
                        strInsert = strInsert & "N" & "','" & CmbInstruMon.SelectedValue & "','"
                        strInsert += dtpProceso.Value.ToString("MM/dd/yyyy") & "') "
                        cm1 = New SqlCommand(strInsert, cnAgil)
                        cm1.ExecuteNonQuery()

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "66"
                        drMovimientos("Imp") = (drDetalleFINAGIL("Importe") + drDetalleFINAGIL("FEGA")) * -1
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "1"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = cBanco
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = SerieX & txtFolio.Text '#ECT para ligar folios Fiscales
                        drMovimientos("Grupo") = NoGrupo
                        dtMovimientos.Rows.Add(drMovimientos)

                    End If

                    If (drDetalleFINAGIL("Intereses")) * -1 > 0 Then

                        strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Importe, Banco, Cheque, Observa1, Balance,InstrumentoMonetario, FechaPago)"
                        strInsert = strInsert & " VALUES ('"
                        strInsert = strInsert & "6" & "', '"
                        If CKaplicaBlanco.Checked = True Then
                            strInsert = strInsert & "AB" & "', "
                        Else
                            strInsert = strInsert & SerieX & "', "
                        End If
                        strInsert = strInsert & txtFolio.Text & ", '"
                        strInsert = strInsert & DTOC(FECHA_APLICACION) & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Anexo") & "', '"
                        strInsert = strInsert & cCiclo & "', "
                        strInsert = strInsert & (drDetalleFINAGIL("Intereses")) * -1 & ", '"
                        strInsert = strInsert & cBanco & "', '"
                        strInsert = strInsert & txtCheque.Text & "', '"
                        strInsert = strInsert & "INTERESES AVIO" & "', '"
                        strInsert = strInsert & "N" & "','" & CmbInstruMon.SelectedValue & "','"
                        strInsert += dtpProceso.Value.ToString("MM/dd/yyyy") & "') "
                        cm1 = New SqlCommand(strInsert, cnAgil)
                        cm1.ExecuteNonQuery()

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "66"
                        drMovimientos("Imp") = (drDetalleFINAGIL("Intereses")) * -1
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "1"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = cBanco
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = SerieX & txtFolio.Text '#ECT para ligar folios Fiscales
                        drMovimientos("Grupo") = NoGrupo
                        dtMovimientos.Rows.Add(drMovimientos)

                    End If
                    If nMoratorios > 0 Then
                        strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Importe, Banco, Cheque, Observa1, Balance,InstrumentoMonetario, FechaPago)"
                        strInsert = strInsert & " VALUES ('"
                        strInsert = strInsert & "6" & "', '"
                        If CKaplicaBlanco.Checked = True Then
                            strInsert = strInsert & "AB" & "', "
                        Else
                            strInsert = strInsert & SerieXM & "', "
                        End If
                        strInsert = strInsert & FolioMora & ", '"
                        strInsert = strInsert & DTOC(FECHA_APLICACION) & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Anexo") & "', '"
                        strInsert = strInsert & cCiclo & "', "
                        strInsert = strInsert & nMoratorios & ", '"
                        strInsert = strInsert & cBanco & "', '"
                        strInsert = strInsert & txtCheque.Text & "', '"
                        strInsert = strInsert & "INTERESES MORATORIO AVIO" & "', '"
                        strInsert = strInsert & "N" & "','" & CmbInstruMon.SelectedValue & "','"
                        strInsert += dtpProceso.Value.ToString("MM/dd/yyyy") & "') "
                        cm1 = New SqlCommand(strInsert, cnAgil)
                        cm1.ExecuteNonQuery()

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "22"
                        drMovimientos("Imp") = nMoratorios
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "1"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = cBanco
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = SerieXM & FolioMora '#ECT para ligar folios Fiscales
                        drMovimientos("Grupo") = NoGrupo
                        dtMovimientos.Rows.Add(drMovimientos)

                    End If

                    If nImporteSEGVID > 0 Then
                        strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Importe, Banco, Cheque, Observa1, Balance,InstrumentoMonetario, FechaPago)"
                        strInsert = strInsert & " VALUES ('"
                        strInsert = strInsert & "6" & "', '"
                        If CKaplicaBlanco.Checked = True Then
                            strInsert = strInsert & "AB" & "', "
                        Else
                            strInsert = strInsert & SerieXM & "', "
                        End If
                        strInsert = strInsert & FolioMora & ", '"
                        strInsert = strInsert & DTOC(FECHA_APLICACION) & "', '"
                        strInsert = strInsert & drDetalleFINAGIL("Anexo") & "', '"
                        strInsert = strInsert & cCiclo & "', "
                        strInsert = strInsert & nImporteSEGVID & ", '"
                        strInsert = strInsert & cBanco & "', '"
                        strInsert = strInsert & txtCheque.Text & "', '"
                        strInsert = strInsert & "SEGURO DE VIDA" & "', '"
                        strInsert = strInsert & "N" & "','" & CmbInstruMon.SelectedValue & "','"
                        strInsert += dtpProceso.Value.ToString("MM/dd/yyyy") & "')"
                        cm1 = New SqlCommand(strInsert, cnAgil)
                        cm1.ExecuteNonQuery()

                        drMovimientos = dtMovimientos.NewRow()
                        drMovimientos("Anexo") = cAnexo
                        drMovimientos("Letra") = "001"
                        drMovimientos("Tipos") = "2"
                        drMovimientos("Fepag") = DTOC(FECHA_APLICACION)
                        drMovimientos("Cve") = "98"
                        drMovimientos("Imp") = nImporteSEGVID
                        drMovimientos("Tip") = "S"
                        drMovimientos("Catal") = drDetalleFINAGIL("Tipar")
                        drMovimientos("Esp") = 0.0
                        drMovimientos("Coa") = "1"
                        drMovimientos("Tipmon") = "01"
                        drMovimientos("Banco") = cBanco
                        drMovimientos("Concepto") = ""
                        drMovimientos("Factura") = SerieXM & FolioMora '#ECT para ligar folios Fiscales
                        drMovimientos("Grupo") = NoGrupo
                        dtMovimientos.Rows.Add(drMovimientos)
                    End If
                    'txtfolio.text += 1
                End If
            End If

        Next

        'Almacenamos los Movimientos Contables

        For Each drMovimientos In dtMovimientos.Rows
            strInsert = "INSERT INTO Hisgin(Anexo, Letra, Tipos, Fepag, Cve, Imp, Tip, Catal, Esp, Coa, Tipmon, Banco, Concepto, Factura, Grupo)"
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
            strInsert = strInsert & drMovimientos("Factura") & "', "
            strInsert = strInsert & drMovimientos("Grupo") & ") "
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()
        Next

        ' Generación de la factura electrónica
        cFechaPago = DTOC(FECHA_APLICACION)

        Dim Ruta As String = "C:\Facturas\FACTURA_"
        If SerieX = "AB" Then
            Ruta = "C:\Facturas\AppBlanco\FACTURA_"
        End If

        Dim stmFactura As FileStream
        Dim stmWriter As StreamWriter



        Dim Fila As Integer = 0
        Dim taMoviAV As New TesoreriaDSTableAdapters.MovimientosAVTableAdapter
        Dim MoviAV As New TesoreriaDS.MovimientosAVDataTable

        taMoviAV.Fill(MoviAV, txtFolio.Text, cFechaPago, SerieX)
        For Each rr As TesoreriaDS.MovimientosAVRow In MoviAV.Rows
            If Fila = 0 Then
                stmFactura = New FileStream(Ruta & rr.Serie.Trim & "_" & rr.Numero & ".txt", FileMode.Create, FileAccess.Write, FileShare.None)
                stmWriter = New StreamWriter(stmFactura, System.Text.Encoding.Default)

                If nEstaTraspasado = 0 Then
                    stmWriter.WriteLine("H1|" & FECHA_APLICACION.ToShortDateString & "|PUE|" & TaQUERY.SacaInstrumemtoMoneSAT(CmbInstruMon.SelectedValue) & "|" & cCheque & "|" & dtpProceso.Value.ToShortDateString)
                Else
                    stmWriter.WriteLine("H1|" & FECHA_APLICACION.ToShortDateString & "|PPD|" & TaQUERY.SacaInstrumemtoMoneSAT(CmbInstruMon.SelectedValue) & "|" & cCheque & "|" & dtpProceso.Value.ToShortDateString)
                End If

                cRenglon = "H3|" & rr.Cliente & "|" & Mid(rr.Anexo, 1, 5) & "/" & Mid(rr.Anexo, 6, 4) & "|" & rr.Serie.Trim & "|" & rr.Numero & "|" & Trim(rr.Descr) & "|" &
                Trim(rr.Calle) & "|||" & Trim(rr.Colonia) & "|" & Trim(rr.Delegacion) & "|" & Trim(rr.DescPlaza) & "|" & rr.Copos & "|" & cCuentaPago & "|" & cFormaPago & "|MEXICO|" & Trim(rr.RFC) & "|M.N.|" &
                "|FACTURA|" & rr.Cliente & "|LEANDRO VALLE 402||REFORMA Y FFCCNN|TOLUCA|ESTADO DE MEXICO|50070|MEXICO|" & cAnexo & "|" & cCiclo & "|"
                stmWriter.WriteLine(cRenglon)
                Fila = 1
            End If

            cRenglon = "D1|" & rr.Cliente & "|" & Mid(rr.Anexo, 1, 5) & "/" & Mid(rr.Anexo, 6, 4) & "|" & rr.Serie.Trim & "|" & rr.Numero & "|1|||" & Trim(rr.Observa1) & "||" & rr.Importe & "|0"
            stmWriter.WriteLine(cRenglon)
        Next

        If Fila = 1 Then
            stmWriter.Flush()
            stmFactura.Flush()
            stmFactura.Close()
        End If

        'Moratorios++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        Fila = 0
        taMoviAV.Fill(MoviAV, FolioMora, cFechaPago, SerieXM)
        For Each rr As TesoreriaDS.MovimientosAVRow In MoviAV.Rows
            If Fila = 0 Then
                stmFactura = New FileStream(Ruta & rr.Serie.Trim & "_" & rr.Numero & ".txt", FileMode.Create, FileAccess.Write, FileShare.None)
                stmWriter = New StreamWriter(stmFactura, System.Text.Encoding.Default)
                stmWriter.WriteLine("H1|" & FECHA_APLICACION.ToShortDateString & "|PUE|" & TaQUERY.SacaInstrumemtoMoneSAT(CmbInstruMon.SelectedValue) & "|" & cCheque & "|" & dtpProceso.Value.ToShortDateString)

                cRenglon = "H3|" & rr.Cliente & "|" & Mid(rr.Anexo, 1, 5) & "/" & Mid(rr.Anexo, 6, 4) & "|" & rr.Serie.Trim & "|" & rr.Numero & "|" & Trim(rr.Descr) & "|" &
                Trim(rr.Calle) & "|||" & Trim(rr.Colonia) & "|" & Trim(rr.Delegacion) & "|" & Trim(rr.DescPlaza) & "|" & rr.Copos & "|" & cCuentaPago & "|" & cFormaPago & "|MEXICO|" & Trim(rr.RFC) & "|M.N.|" &
                "|FACTURA|" & rr.Cliente & "|LEANDRO VALLE 402||REFORMA Y FFCCNN|TOLUCA|ESTADO DE MEXICO|50070|MEXICO|" & cAnexo & "|" & cCiclo & "|"
                stmWriter.WriteLine(cRenglon)
                Fila = 1
            End If

            cRenglon = "D1|" & rr.Cliente & "|" & Mid(rr.Anexo, 1, 5) & "/" & Mid(rr.Anexo, 6, 4) & "|" & rr.Serie.Trim & "|" & rr.Numero & "|1|||" & Trim(rr.Observa1) & "||" & rr.Importe & "|0"
            stmWriter.WriteLine(cRenglon)
        Next
        If Fila = 1 Then
            stmWriter.Flush()
            stmFactura.Flush()
            stmFactura.Close()
            Folios.ConsumeFolioMora()
        End If

        'Moratorios++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        ''Next

        ' Debe actualizar el atributo IDSerieA ó el atributo IDSerieMXL de la tabla Llaves

        If SerieX = "A" Then
            Folios.ConsumeFolioA()
        ElseIf SerieX = "MXL" Then
            Folios.ConsumeFolioMXL()
        ElseIf SerieX = "REP" Then
            Folios.ConsumeFolioPago()
        Else
            Folios.ConsumeFolioBlanco()
        End If


        MsgBox("Proceso Completo", MsgBoxStyle.Information)

        cnAgil.Close()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()

        Me.Close()

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

    Private Sub rbTotal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTotal.CheckedChanged
        btnAumentar.Enabled = True
    End Sub

    Private Sub rbParcial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbParcial.CheckedChanged
        btnAumentar.Enabled = True
    End Sub

    Private Sub TxtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFiltro.TextChanged
        If TxtFiltro.Text.Length > 3 Then
            BindingDeudores.Filter = "productor like '%" & TxtFiltro.Text & "%'"
        Else
            BindingDeudores.Filter = ""
        End If
    End Sub


End Class