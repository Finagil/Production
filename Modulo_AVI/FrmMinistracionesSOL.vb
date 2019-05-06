Imports Microsoft.Office.Interop
Public Class FrmMinistracionesSOL
    Public ID As Integer = 0
    Public IDparametro As Integer = 0
    Public Importe As Decimal = 0
    Public TIEE As Decimal = 0
    Public Diferencial As Decimal = 0
    Public Fondeo As String = ""
    Public AplicaGarantiaLIQ As String = ""
    Public GastosIniciales As Decimal = 0
    Public Tvida As Decimal = 0
    Public SegAgri As Decimal = 0
    Public Fecha As Date
    Public Sucursal As String
    Public Cliente As String
    Public DiasVenc As Integer
    Public FegaFlat As Boolean
    Dim GarantiaLIQ As Decimal = 0.1
    Dim FEGA As Decimal = 0
    Dim TasaIVACliente As Decimal = 0


    Private Sub BttMinistraciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttMinistraciones.Click
        If Valida() = True Then
            Cursor.Current = Cursors.WaitCursor
            Me.AviosDSX.AVI_MinistracionesSolicitudes.AcceptChanges()
            CalculaTabla(True)
            Me.AVI_MinistracionesSolicitudesTableAdapter.DeleteSOL(ID)
            For Each r As AviosDSX.AVI_MinistracionesSolicitudesRow In Me.AviosDSX.AVI_MinistracionesSolicitudes.Rows
                Me.AVI_MinistracionesSolicitudesTableAdapter.Insert(r.Id_solicitud, r.Fecha, r.Importe, r.Porcentaje)
            Next
            Cursor.Current = Cursors.Default
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub FrmMinistracionesSOL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TasaIVACliente = TaQUERY.TasaIvaCliente(Cliente) / 100
        Me.AVI_MinistracionesSolicitudesTableAdapter.DeleteSOL(ID)
        Me.AVI_MinistracionesSolicitudesTableAdapter.InsertaMinistraciones(ID, IDparametro)
        Me.AVI_MinistracionesSolicitudesTableAdapter.UpdateImporte(Importe, ID, 0)
        Me.AVI_MinistracionesSolicitudesTableAdapter.Fill(Me.AviosDSX.AVI_MinistracionesSolicitudes, ID)
        Me.Text = Me.Text & " ImporteTotal: " & Importe.ToString("n2")
    End Sub

    Private Sub DataGridView1_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles Grid1.RowsAdded
        Dim x As Integer = 0
        For x = 0 To Grid1.RowCount - 1
            Grid1.Item(1, x).Value = ID
        Next
    End Sub

    Function Valida() As Boolean
        Valida = True
        Dim total As Double = 0
        For Each r As AviosDSX.AVI_MinistracionesSolicitudesRow In Me.AviosDSX.AVI_MinistracionesSolicitudes.Rows
            total += Math.Round(CDbl(r.Importe), 2)
            r.Porcentaje = Math.Round(r.Importe / Importe, 3)
        Next
        total = Math.Truncate(total * 100) / 100
        If Importe <> total Then
            If Importe <> total + 0.01 Then
                MessageBox.Show("Las ministraciones con cuadran con el importe total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Valida = False
                Exit Function
            End If
        End If
    End Function

    Private Sub BttValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttValidar.Click
        If Valida() = True Then
            Cursor.Current = Cursors.WaitCursor
            CalculaTabla(False)
            Cursor.Current = Cursors.Default
            'MessageBox.Show("Datos Correctos", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub CalculaTabla(ByVal b As Boolean)
        Me.AviosDSX.EstadoCuenta.Clear()
        Dim SAgri As Decimal = SegAgri
        Dim dias As Integer = 0
        Dim FecIni As Date
        Dim fNext As Date
        Dim FinMes As Date
        Dim Fecfin As Date
        Dim Saldo As Decimal = 0
        Dim Accesorios As Decimal = 0
        Dim Fila As Integer = 1
        Dim POSS As Integer = 1
        Dim Hasta As Integer = Me.AviosDSX.AVI_MinistracionesSolicitudes.Rows.Count
        Dim Fechas(Hasta) As Date
        Dim Montos(Hasta) As Double
        Dim DiasX(Hasta) As Double
        Dim Resultado(Hasta) As Double
        Dim rr As AviosDSX.EstadoCuentaRow
        Dim rrr As AviosDSX.EstadoCuentaRow
        Dim GTIAcum As Double = 0
        If AplicaGarantiaLIQ = "NO" Then GarantiaLIQ = 0 Else
        For Each r As AviosDSX.AVI_MinistracionesSolicitudesRow In Me.AviosDSX.AVI_MinistracionesSolicitudes.Rows
            rr = Me.AviosDSX.EstadoCuenta.NewRow
            rr.id = POSS
            Fechas(Fila - 1) = CTOD(r.Fecha)
            rr.Saldo = Saldo
            rr.Intereses = 0
            rr.Garantia = 0
            rr.Fega = 0
            rr.SeguroVida = 0
            rr.Dias = 0
            If Fila = 1 Then
                rr.SeguroAgricola = SAgri
                Saldo = GastosIniciales + r.Importe + SAgri
                rr.Gastos = GastosIniciales
                FecIni = CTOD(r.Fecha)
                Fecfin = CTOD(r.Fecha)
                rr.FechaIni = FecIni
                rr.FechaFin = Fecfin
                If Fondeo = "Fira" Then
                    If FEGA = 0 Then
                        If Sucursal = "03" Or Sucursal = "04" Or Sucursal = "08" Then
                            FEGA = PORC_FEGA_NORTE_TRA
                        Else
                            FEGA = PORC_FEGA_TRA
                        End If
                    End If
                    rr.Fega = CalculaFEGA(Saldo, FegaFlat, Date.Now.Date.AddDays(DiasVenc).ToString("yyyyMMdd"), True, FEGA, Cliente, Sucursal, "AV") / (1 + TasaIVACliente) ' quitamos el iva para  CAT
                    rr.Garantia = (Saldo * GarantiaLIQ)
                    GTIAcum += rr.Garantia
                    Saldo += (Saldo * 0.01) + (Saldo * GarantiaLIQ)
                End If
                Montos(Fila - 1) = (r.Importe - GastosIniciales) * -1
                FinMes = Fecfin.AddMonths(1)
                FinMes = FinMes.AddDays((FinMes.Day) * -1)
                Fecfin = FinMes
                rr.SaldoFinal = Saldo
                Me.AviosDSX.EstadoCuenta.AddEstadoCuentaRow(rr)
                SAgri = 0
            Else
                'Saldo += r.Importe
                'rr.Saldo = (r.Importe - SAgri)

                Montos(Fila - 1) = (r.Importe - SAgri) * -1
                If Fondeo = "Fira" Then
                    rr.Garantia = (r.Importe + SAgri) * GarantiaLIQ
                    GTIAcum += rr.Garantia
                    rr.Fega = CalculaFEGA(r.Importe + SAgri, FegaFlat, Date.Now.Date.AddDays(DiasVenc).ToString("yyyyMMdd"), True, FEGA, Cliente, Sucursal, "AV") / (1 + TasaIvaCliente) ' quitamos el iva para  CAT
                    Accesorios = r.Importe + SAgri + ((r.Importe + SAgri) * 0.01) + ((r.Importe + SAgri) * GarantiaLIQ) '¿lleva IVA?¿seguro lleVa garantia?
                    If r.Importe < SAgri Then
                        MessageBox.Show("El seguro agrícola es mayor a la ministracion." & vbCrLf & _
                        "Es necesario ajustar el porcentaje de la segunda ministración.", "Error de Datos", _
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    SAgri = 0
                Else
                    Accesorios = r.Importe + SAgri
                End If
                Fecfin = CTOD(r.Fecha)
            End If
            rr.Efectivo = r.Importe
            If Me.AviosDSX.AVI_MinistracionesSolicitudes.Rows.Count > Fila Then
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
                        rrr.Efectivo = 0
                        dias = DateDiff(DateInterval.Day, FecIni, FinMes)
                        rrr.Dias = dias
                        rrr.FechaIni = FecIni
                        rrr.FechaFin = FinMes
                        CalculaInetres(dias, Saldo, FinMes, Accesorios, rrr)
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
                        CalculaInetres(dias, Saldo, Fecfin, Accesorios, rr)
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
            Saldo += Accesorios
            Fila += 1
            POSS += 1
        Next
        If Fondeo = "Fira" Then
            Montos(Fila - 1) = Saldo - (GTIAcum)
        Else
            Montos(Fila - 1) = Saldo
        End If
        Fechas(Fila - 1) = Fecha
        POSS = 0
        dias = 0
        For Each rr In Me.AviosDSX.EstadoCuenta.Rows
            dias += rr.Dias
            If Not IsDBNull(rr.Efectivo) Then
                If rr.Efectivo > 0 Then
                    DiasX(POSS) = dias
                    POSS += 1
                End If
            End If
        Next
        DiasX(POSS) = dias
        Dim cat As Double = CATavio(Montos, Fechas, DiasX, Resultado)
        If b = True Then
            Me.AVI_MinistracionesSolicitudesTableAdapter.UpdateCAT(cat, ID)
        End If
        LbCAT.Text = "CAT: " & cat.ToString("p1")
        EstadoCuentaBindingSource.Sort = "id"

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
                If Fondeo = "Fira" Then
                    Saldo += Vida + (Vida * 0.01) + (Vida * GarantiaLIQ)
                    rr.Fega = CalculaFEGA(Vida, FegaFlat, Date.Now.Date.AddDays(DiasVenc).ToString("yyyyMMdd"), True, FEGA, Cliente, Sucursal, "AV") / (1 + TasaIvaCliente) ' quitamos el iva para  CAT
                    rr.Garantia += (Vida * GarantiaLIQ)
                Else
                    Saldo += Vida
                End If

            End If
        End If
    End Sub

    Function CATavio(ByVal p() As Double, ByVal d() As Date, ByVal di() As Double, ByVal r() As Double) As Double
        Dim Tasa As Double = 0
        Dim Suma As Double = 0.000001
        Dim catTIR As Double
        Dim Bandera As Boolean = True
        Dim Van As Double = 0
        Do While Bandera = True
            Tasa += Suma
            Van = 0
            For X As Integer = 0 To p.Length - 1
                'r(X) = p(X) / ((1 + (Tasa / (360 / 30))) ^ (di(X) / 30))'CAT SIMPLE
                r(X) = p(X) / ((1 + Tasa) ^ (di(X) / 360))
                Van += r(X)
            Next
            If Van <= 0 Then
                Bandera = False
                CATavio = Tasa
            End If
        Loop
        catTIR = IRR(p, 0.01)
        catTIR = Math.Round(((1 + catTIR) ^ (p.Length - 1)) - 1, 3)
        LbCATtir.Text = "CAT TIR: " & catTIR.ToString("p1")
        LbCATtir.Text = ""
        LbCAT1min.Text = ""

    End Function

    'Dim oXL As Excel.Application
    'Dim Guess As Double = 0.1
    'oXL = CreateObject("Excel.Application")
    'Try
    '    CATavio = oXL.Application.WorksheetFunction.Xirr(p, d, Guess)
    '    CATavio = Math.Round(CATavio, 3)
    '    oXL.Quit()
    '    oXL = Nothing
    'Catch ex As Exception
    '    oXL.Quit()
    '    CATavio = -1
    'End Try

End Class