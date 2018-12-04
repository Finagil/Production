Imports Microsoft.Office.Interop
Public Class FrmCATCC
    Public ID As Integer = 0
    Public IDparametro As Integer = 0
    Public DiasVenc As Integer = 0
    Public Importe As Decimal = 0
    Public TIEE As Decimal = 0
    Public Diferencial As Decimal = 0
    Public Fondeo As String = ""
    Public AplicaGarantiaLIQ As String = ""
    Public InteMensual As String = ""
    Public Tipta As String = ""
    Public GastosIniciales As Decimal = 0
    Public GastosADescuento As String = ""
    Public ComisionXDisposicion As Decimal = 0
    Public Tvida As Decimal = 0
    Public IVA As Decimal = 0
    Public Fecha As Date
    Public Sucursal As String
    Public Cliente As String
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
            Dim ta As New AviosDSXTableAdapters.AVI_SolicitudesCotizacionesTableAdapter
            ta.DeleteSolicitud(ID)
            For Each r As AviosDSX.EstadoCuentaRow In Me.AviosDSX.EstadoCuenta.Rows
                ta.Insert(r.id, r.FechaIni, r.FechaFin, r.Dias, r.Saldo, r.Efectivo, r.Buro, r.Gastos, r.SeguroAgricola, r.SeguroVida, r.Fega, r.Intereses, r.Garantia, r.SaldoFinal, ID)
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
        'If Importe <> total Then
        '    MessageBox.Show("Las ministraciones con cuadran con el importe total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Valida = False
        '    Exit Function
        'End If
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
        'Tvida = 0
        'IVA = 0
        Dim TasaIVA As Decimal = IVA
        Dim IvaGastos As Decimal = 0
        Dim dias As Integer = 0
        Dim FecIni As Date
        Dim fNext As Date
        Dim FinMes As Date
        Dim Fecfin As Date
        Dim Saldo As Decimal = 0
        Dim SaldoAux As Decimal = 0
        Dim FegaAux As Decimal = 0
        Dim SaldoFIN As Decimal = 0
        Dim Accesorios As Decimal = 0
        Dim Fila As Integer = 1
        Dim POSS As Integer = 1
        Dim Registro As Integer = 0
        Dim Acumula As Boolean = False
        Dim Montos() As Double
        Dim Resultado() As Double
        Dim rr As AviosDSX.EstadoCuentaRow
        Dim rrr As AviosDSX.EstadoCuentaRow
        Dim rrx As AviosDSX.EstadoCuentaRow
        Dim GTIAcum As Double = 0

        If AplicaGarantiaLIQ = "NO" Then GarantiaLIQ = 0 Else

        For Each r As AviosDSX.AVI_MinistracionesSolicitudesRow In Me.AviosDSX.AVI_MinistracionesSolicitudes.Rows
            Registro += 1
            rr = Me.AviosDSX.EstadoCuenta.NewRow
            rr.Buro = 0
            rr.Gastos = 0
            rr.SeguroAgricola = 0
            rr.id = POSS
            rr.Saldo = Saldo
            rr.Intereses = 0
            rr.Garantia = 0
            rr.Fega = 0
            rr.SeguroVida = 0
            rr.Dias = 0
            IvaGastos = ((GastosIniciales + ComisionXDisposicion) * TasaIVA)
            If Fila = 1 Then
                Saldo = r.Importe '+ ComisionXDisposicion + GastosIniciales
                rr.Gastos = GastosIniciales + ComisionXDisposicion
                rr.SeguroAgricola = IvaGastos
                FecIni = CTOD(r.Fecha)
                Fecfin = CTOD(r.Fecha)
                rr.FechaIni = FecIni
                rr.FechaFin = Fecfin
                If Fondeo = "Fira" Then
                    If FEGA = 0 Then
                        If Sucursal = "03" Or Sucursal = "04" Then
                            FEGA = PORC_FEGA_NORTE_TRA
                        Else
                            FEGA = PORC_FEGA_TRA
                        End If
                    End If
                    rr.Fega = CalculaFEGA(Saldo, FegaFlat, Date.Now.Date.AddDays(DiasVenc).ToString("yyyyMMdd"), True, FEGA, Cliente, Sucursal, "AV") / (1 + TasaIVACliente) ' quitamos el iva para  CAT
                    FegaAux = rr.Fega
                    rr.Garantia = (Saldo * GarantiaLIQ)
                    GTIAcum += rr.Garantia
                    Saldo += (Saldo * 0.01) + (Saldo * GarantiaLIQ)
                Else
                    rr.Fega = 0
                End If
                ReDim Preserve Montos(Fila - 1)
                If GastosADescuento = "NO" Then
                    Montos(Fila - 1) = (Saldo) * -1
                    Saldo = Saldo + GastosIniciales + ComisionXDisposicion + IvaGastos
                    rr.SaldoFinal = Saldo
                Else
                    Saldo = Saldo
                    Montos(Fila - 1) = (r.Importe - GastosIniciales - ComisionXDisposicion - IvaGastos) * -1
                    rr.SaldoFinal = Saldo - GastosIniciales - ComisionXDisposicion - IvaGastos - rr.Fega
                End If
                Montos(Fila - 1) = (r.Importe - GastosIniciales - ComisionXDisposicion) * -1
                FinMes = Fecfin.AddMonths(1)
                FinMes = FinMes.AddDays((FinMes.Day) * -1)
                Fecfin = FinMes
                Me.AviosDSX.EstadoCuenta.AddEstadoCuentaRow(rr)

                If GastosADescuento = "NO" Then
                    rrr = Me.AviosDSX.EstadoCuenta.NewRow
                    POSS += 1
                    rrr.Buro = 0
                    rrr.Gastos = 0
                    rrr.id = POSS
                    rrr.Saldo = Saldo
                    rrr.Intereses = 0
                    rrr.Garantia = 0
                    rrr.Fega = 0
                    rrr.SeguroVida = 0
                    rrr.SeguroAgricola = IvaGastos * -1
                    rrr.Gastos = (GastosIniciales + ComisionXDisposicion) * -1
                    rrr.Efectivo = 0
                    rrr.Dias = 0
                    rrr.FechaIni = FecIni
                    rrr.FechaFin = FecIni
                    Saldo = Saldo + rrr.SeguroAgricola + rrr.Gastos
                    rrr.SaldoFinal = Saldo
                    Me.AviosDSX.EstadoCuenta.AddEstadoCuentaRow(rrr)
                End If
            Else
                IvaGastos = ComisionXDisposicion * IVA
                SaldoAux = r.Importe
                rr.Saldo = 0
                If InteMensual = "SI" Then
                    Fila -= 1
                    Acumula = True
                Else
                    ReDim Preserve Montos(Fila - 1)
                    Montos(Fila - 1) = (r.Importe) * -1
                End If
                If DiasVenc = 180 And InteMensual = "NO" Then
                    'Acumula = True
                End If

                If Fondeo = "Fira" Then
                    'rr.Garantia = (r.Importe + SAgri) * GarantiaLIQ
                    'GTIAcum += rr.Garantia
                    'rr.Fega = (r.Importe) * 0.01
                    'FegaAux = CalculaFEGA(r.Importe, FegaFlat, Fecfin.ToString("yyyyMMdd"), True, FEGA, Cliente, Sucursal, "AV")
                    SaldoAux += FegaAux
                    'Accesorios = r.Importe + SAgri + ((r.Importe + SAgri) * 0.01) + ((r.Importe + SAgri) * GarantiaLIQ) '¿lleva IVA?¿seguro lleVa garantia?
                    'If r.Importe < SAgri Then
                    'MessageBox.Show("El seguro agrícola es mayor a la ministracion." & vbCrLf & _
                    '"Es necesario ajustar el porcentaje de la segunda ministración.", "Error de Datos", _
                    'MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Exit Sub
                    'End If
                    'SAgri = 0
                Else
                    'Accesorios = r.Importe + SAgri
                    rr.Fega = 0
                    FegaAux = 0
                End If
                Fecfin = CTOD(r.Fecha)
            End If
            rr.Efectivo = r.Importe
            If Me.AviosDSX.AVI_MinistracionesSolicitudes.Rows.Count > Fila And InteMensual = "NO" Then
                fNext = CTOD(Me.AviosDSX.AVI_MinistracionesSolicitudes.Rows(Fila).Item("fecha"))
            ElseIf Me.AviosDSX.AVI_MinistracionesSolicitudes.Rows.Count > Registro And InteMensual = "SI" Then
                fNext = CTOD(Me.AviosDSX.AVI_MinistracionesSolicitudes.Rows(Registro).Item("fecha"))
            Else
                fNext = Fecha
            End If

            Do While fNext >= Fecfin
                If FinMes <= fNext Then
                    If FinMes <= Fecfin Then
                        rrr = Me.AviosDSX.EstadoCuenta.NewRow
                        POSS += 1
                        rrr.Buro = 0
                        rrr.Gastos = 0
                        rrr.id = POSS
                        rrr.Saldo = Saldo
                        rrr.Intereses = 0
                        rrr.Garantia = 0
                        rrr.Fega = 0
                        rrr.SeguroVida = 0
                        rrr.SeguroAgricola = 0
                        rrr.Efectivo = 0
                        dias = DateDiff(DateInterval.Day, FecIni, FinMes)
                        rrr.Dias = dias
                        rrr.FechaIni = FecIni
                        rrr.FechaFin = FinMes
                        CalculaInetres(dias, Saldo, FinMes, Accesorios, rrr)
                        rrr.SaldoFinal = Saldo
                        If SaldoAux <> 0 Then
                            ReDim Preserve Montos(Fila - 1)
                            Montos(Fila - 1) = ((Saldo - SaldoAux) + ComisionXDisposicion)
                            rr.SaldoFinal = SaldoAux
                            Saldo = SaldoAux
                            SaldoAux = 0
                        End If
                        If InteMensual = "SI" Then
                            'linea pago
                            rrx = Me.AviosDSX.EstadoCuenta.NewRow
                            POSS += 1
                            rrx.Buro = 0
                            rrx.Gastos = 0
                            rrx.id = POSS
                            rrx.Saldo = Saldo
                            SaldoFIN = Saldo
                            rrx.Intereses = 0
                            rrx.Garantia = 0
                            rrx.Fega = 0
                            rrx.SeguroVida = 0
                            rrx.SeguroAgricola = 0
                            rrx.Gastos = 0
                            rrx.Efectivo = (Saldo - rrr.Saldo) * -1

                            If Acumula = False Then
                                If Fila = Montos.Length Then
                                    Fila += 1
                                End If
                                ReDim Preserve Montos(Fila - 1)
                                Montos(Fila - 1) = (Saldo - rrr.Saldo)
                            Else
                                Montos(Fila - 1) += (Saldo - rrr.Saldo)
                                Fila += 1
                                Acumula = False
                            End If
                            rrx.Dias = 0
                            rrx.FechaIni = FinMes
                            rrx.FechaFin = FinMes
                            rrx.SaldoFinal = rrr.Saldo
                            Saldo = rrr.Saldo
                            Me.AviosDSX.EstadoCuenta.AddEstadoCuentaRow(rrx)
                        Else
                            If DiasVenc = 180 And Registro = 2 And Acumula = True Then
                                Acumula = False
                                Montos(Fila - 1) += (Saldo - rrr.Saldo - FegaAux)
                            End If

                        End If

                        FecIni = FinMes
                        FinMes = FinMes.AddDays(1)
                        FinMes = FinMes.AddMonths(1)
                        FinMes = FinMes.AddDays(-1)
                        Fecfin = FinMes
                        If fNext < Fecfin And FecIni < fNext And Fecha = fNext Then
                            Fecfin = fNext
                            FinMes = fNext
                        End If

                        Me.AviosDSX.EstadoCuenta.AddEstadoCuentaRow(rrr)
                    Else
                        dias = DateDiff(DateInterval.Day, FecIni, Fecfin)
                        rr.Dias = dias
                        rr.FechaIni = FecIni
                        rr.FechaFin = Fecfin
                        rr.Efectivo = 0
                        rr.Saldo = Saldo
                        CalculaInetres(dias, Saldo, Fecfin, Accesorios, rr)
                        FecIni = Fecfin
                        Fecfin = FinMes
                        If Fila <> 1 Then
                            rr.SaldoFinal = Saldo
                            If SaldoAux <> 0 Then
                                'linea pago
                                rrr = Me.AviosDSX.EstadoCuenta.NewRow
                                POSS += 1
                                rrr.Buro = 0
                                rrr.Gastos = 0
                                rrr.id = POSS
                                rrr.Saldo = Saldo
                                rrr.Intereses = 0
                                rrr.Garantia = 0
                                rrr.Fega = 0
                                rrr.SeguroVida = 0
                                rrr.SeguroAgricola = 0
                                rrr.Gastos = 0
                                rrr.Efectivo = Saldo * -1
                                rrr.Dias = 0
                                rrr.FechaIni = FecIni
                                rrr.FechaFin = FecIni
                                'Saldo = 0
                                rrr.SaldoFinal = 0
                                Me.AviosDSX.EstadoCuenta.AddEstadoCuentaRow(rrr)

                                'linea ministracion
                                rrr = Me.AviosDSX.EstadoCuenta.NewRow
                                POSS += 1
                                rrr.Buro = 0
                                rrr.Gastos = 0
                                rrr.id = POSS
                                rrr.Saldo = 0
                                rrr.Intereses = 0
                                rrr.Garantia = 0
                                rrr.Fega = FegaAux
                                rrr.SeguroVida = 0
                                rrr.SeguroAgricola = IvaGastos
                                rrr.Gastos = ComisionXDisposicion
                                rrr.Efectivo = SaldoAux - FegaAux
                                rrr.Dias = 0
                                rrr.FechaIni = FecIni
                                rrr.FechaFin = FecIni
                                If GastosADescuento = "NO" Then
                                    rrr.SaldoFinal = SaldoAux + ComisionXDisposicion + IvaGastos - FegaAux
                                Else
                                    rrr.SaldoFinal = SaldoAux - ComisionXDisposicion - IvaGastos - FegaAux
                                End If
                                Me.AviosDSX.EstadoCuenta.AddEstadoCuentaRow(rrr)

                                If GastosADescuento = "NO" Then
                                    rrr = Me.AviosDSX.EstadoCuenta.NewRow
                                    POSS += 1
                                    rrr.Buro = 0
                                    rrr.Gastos = 0
                                    rrr.id = POSS
                                    rrr.Saldo = SaldoAux + ComisionXDisposicion + IvaGastos
                                    rrr.Intereses = 0
                                    rrr.Garantia = 0
                                    rrr.Fega = 0
                                    rrr.SeguroVida = 0
                                    rrr.SeguroAgricola = IvaGastos * -1
                                    rrr.Gastos = (ComisionXDisposicion) * -1
                                    rrr.Efectivo = 0
                                    rrr.Dias = 0
                                    rrr.FechaIni = FecIni
                                    rrr.FechaFin = FecIni
                                    rrr.SaldoFinal = SaldoAux
                                    Me.AviosDSX.EstadoCuenta.AddEstadoCuentaRow(rrr)
                                End If
                                ' ant Montos(Fila - 1) = ((Saldo - SaldoAux) + ComisionXDisposicion + IvaGastos)
                                If Fila = Montos.Length And InteMensual = "SI" Then
                                    Fila += 1
                                End If
                                ReDim Preserve Montos(Fila - 1)
                                Montos(Fila - 1) = ((Saldo - (SaldoAux - FegaAux)) + ComisionXDisposicion)
                                'rr.SaldoFinal = SaldoAux
                                Saldo = SaldoAux
                                SaldoAux = 0
                            End If
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
        ReDim Preserve Montos(Fila - 1)
        If Fondeo = "Fira" Then
            Montos(Fila - 1) = Saldo - (GTIAcum)
        Else
            Montos(Fila - 1) = Saldo
            If InteMensual = "SI" Then
                ReDim Preserve Montos(12)
                Montos(12) = SaldoFIN
                Me.AviosDSX.EstadoCuenta.Rows(Me.AviosDSX.EstadoCuenta.Rows.Count - 2).Item("efectivo") = Me.AviosDSX.EstadoCuenta.Rows(Me.AviosDSX.EstadoCuenta.Rows.Count - 2).Item("Saldo") * -1
                Me.AviosDSX.EstadoCuenta.Rows(Me.AviosDSX.EstadoCuenta.Rows.Count - 2).Item("Saldofinal") = 0
            Else
                'linea pago
                rrx = Me.AviosDSX.EstadoCuenta.NewRow
                POSS += 1
                rrx.Buro = 0
                rrx.Gastos = 0
                rrx.id = POSS
                rrx.Saldo = Saldo
                rrx.Intereses = 0
                rrx.Garantia = 0
                rrx.Fega = 0
                rrx.SeguroVida = 0
                rrx.SeguroAgricola = 0
                rrx.Gastos = 0
                rrx.Efectivo = (Saldo) * -1
                rrx.Dias = 0
                rrx.FechaIni = FinMes
                rrx.FechaFin = FinMes
                rrx.SaldoFinal = 0
                Me.AviosDSX.EstadoCuenta.AddEstadoCuentaRow(rrx)
            End If
        End If
        'Fechas(Fila - 1) = Fecha
        POSS = 0
        dias = 0
        ''For Each rr In Me.AviosDSX.EstadoCuenta.Rows
        ''    dias += rr.Dias
        ''    If Not IsDBNull(rr.Efectivo) Then
        ''        If rr.Efectivo > 0 Then
        ''            DiasX(POSS) = dias
        ''            POSS += 1
        ''        End If
        ''    End If
        ''Next
        ''DiasX(POSS) = dias
        'Dim cat As Double = CATavio(Montos, Fechas, DiasX, Resultado)
        'Dim catTIRNP As Double = 0
        Dim catTIR As Double = 0
        'CAT CON TIR**********************************************
        'Dim oXL As Excel.Application
        Dim Guess As Double = 0.01
        'oXL = CreateObject("Excel.Application")
        Try
            'catTIRNP = oXL.Application.WorksheetFunction.Xirr(Montos, Fechas, Guess)
            'catTIR = oXL.Application.WorksheetFunction.Irr(Montos, Guess)
            catTIR = IRR(Montos, Guess)
            'catTIRNP = Math.Round(catTIR, 3)
            If DiasVenc = 30 And InteMensual = "NO" Then
                catTIR = Math.Round(((1 + catTIR) ^ 12) - 1, 3)
            ElseIf DiasVenc = 60 And InteMensual = "NO" Then
                catTIR = Math.Round(((1 + catTIR) ^ 6) - 1, 3)
            ElseIf DiasVenc = 90 And InteMensual = "NO" Then
                catTIR = Math.Round(((1 + catTIR) ^ 4) - 1, 3)
            ElseIf DiasVenc = 120 And InteMensual = "NO" Then
                catTIR = Math.Round(((1 + catTIR) ^ 3) - 1, 3)
            ElseIf (DiasVenc = 150 Or DiasVenc = 180) And InteMensual = "NO" Then
                catTIR = Math.Round(((1 + catTIR) ^ 2) - 1, 3)
            Else
                catTIR = Math.Round(((1 + catTIR) ^ 12) - 1, 3)
            End If

            'oXL.Quit()
            'oXL = Nothing
        Catch ex As Exception
            'oXL.Quit()
            catTIR = -1
        End Try
        'CAT CON TIR**********************************************



        If b = True Then
            Me.AVI_MinistracionesSolicitudesTableAdapter.UpdateCAT(catTIR, ID)
        End If
        'LbCAT.Text = "CAT: " & cat.ToString("p1")
        LbCAT2.Text = "CAT TIR: " & catTIR.ToString("p1")
        'Lbcat3.Text = "CAT TIR No PER: " & catTIRNP.ToString("p1")
        EstadoCuentaBindingSource.Sort = "id"

    End Sub

    Sub CalculaInetres(ByRef dias As Integer, ByRef Saldo As Decimal, ByVal f As Date, ByRef Accesorios As Decimal, ByRef rr As AviosDSX.EstadoCuentaRow)
        Dim Inte As Decimal
        Dim Vida As Decimal
        Dim Tasa As Decimal = 0

        If Tipta = "7" Then
            Tasa = (Diferencial) / 100
        Else
            Tasa = (TIEE + Diferencial) / 100
        End If

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
                    rr.Fega += CalculaFEGA(Vida, FegaFlat, Date.Now.Date.AddDays(DiasVenc).ToString("yyyyMMdd"), True, FEGA, Cliente, Sucursal, "AV") / (1 + TasaIVACliente) ' quitamos el iva para  CAT
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
        Dim Bandera As Boolean = True
        Dim Van As Double = 0
        Do While Bandera = True
            Tasa += Suma
            Van = 0
            For X As Integer = 0 To p.Length - 1
                r(X) = p(X) / ((1 + (Tasa / (360 / 30))) ^ (di(X) / 30))
                Van += r(X)
            Next
            If Van <= 0 Then
                Bandera = False
                CATavio = Tasa
            End If
        Loop

        
    End Function

    

End Class