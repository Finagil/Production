Public Class FrmCALconsumo

    Private Sub FrmCALconsumo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        'dtpProceso.Value = CTOD(CmbDB.SelectedValue)
    End Sub

    Sub procesar()
        Dim TAmezcla As New CalificacionDSTableAdapters.AnexosMezclaTableAdapter
        Dim TAFacturas As New CalificacionDSTableAdapters.FacturasTableAdapter

        TAmezcla.Connection.ConnectionString = "Server=" & My.Settings.ServidorX & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015;Connection Timeout=60;"
        TAFacturas.Connection.ConnectionString = "Server=" & My.Settings.ServidorX & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"

        Dim Mezcla As New CalificacionDS.AnexosMezclaDataTable
        Dim Factura As New CalificacionDS.FacturasDataTable
        Dim R As CalificacionDS.ReporteRow
        Dim M As CalificacionDS.AnexosMezclaRow
        Dim F As CalificacionDS.FacturasRow
        Dim id As Integer = 0
        Dim cAnexo As String
        Dim Cad As String
        'Dim TOT As Decimal
        Dim Total As Decimal
        Dim logaritmo As Decimal
        Dim ATR As Decimal
        Dim MAXATR As Decimal
        Dim PAGO As Decimal
        Dim SDOIMP As Decimal
        Dim VECES As Decimal
        Dim Fecha As Date = CTOD(TAmezcla.MesCalificacion)
        logaritmo = Math.Exp(1)
        CalificacionDS.Tables("Reporte").Rows.Clear()

        TAmezcla.Fill(Mezcla)
        For Each M In Mezcla.Rows
            id += 1
            R = CalificacionDS.Tables("Reporte").NewRow
            cAnexo = Mid(M.Anexo, 1, 5) & Mid(M.Anexo, 7, 4)
            If cAnexo = "001020012" Then
                cAnexo = cAnexo
            End If
            R.ID = id
            R.Anexo = M.Anexo
            R.Cliente = M.Cliente
            R.Saldo = M.Saldo
            R.PI = 0
            R._PAGO_ = 0
            'R.MAXATR = 0
            R.NOMINA = 0
            R.PERSONAL = 0
            R.INDATR = 0
            R.OTRO = 0
            'R.PR = 0

            ATR = 0
            MAXATR = 0
            PAGO = 0
            SDOIMP = 0
            VECES = 0
            R.Vencimiento = Mid(M.Vencimiento, 1, 3)
            R.Dias = M.Dias
            R.MOI = M.MOI

            Select Case M.Vencimiento

                Case "Semanal"
                    R.ATR = Math.Ceiling((M.Dias) / 7)
                    R.MAXATR = Math.Ceiling(M.Dias / 7)
                    ATR = R.ATR
                    MAXATR = R.MAXATR
                    If R.ATR >= 14 Then R.PI = 1
                    If R.ATR < 40 Then R.SP = 0.65 Else R.SP = 1
                    If R.PI = 1 Then
                        R.RI = R.PI * R.SP
                        R.RI = R.Saldo * R.RI
                    Else
                        TAFacturas.FillBy5(Factura, cAnexo)
                        For Each F In Factura.Rows
                            R._PAGO_ += F.PagoMes / F.MontoFactura
                        Next
                        R._PAGO_ = ((R._PAGO_ + (5 - Factura.Rows.Count)) / 5)
                        PAGO = R._PAGO_
                        R.PR = 0
                        R._SDOIMP_ = (R.Saldo) / M.MOI
                        SDOIMP = R._SDOIMP_
                        R.OTRO = 0
                        R.NOMINA = 0
                        Cad = TAmezcla.ScalarAUTO(cAnexo)
                        If Trim(Cad) = "" Then
                            R._AUTO = 0
                            R.PERSONAL = 1
                        Else
                            R._AUTO = 1
                            R.PERSONAL = 0
                        End If
                        R.ATR = (-1.5651) + (0.0133 * R.ATR)
                        R.MAXATR = 0.1282 * R.MAXATR
                        R._PAGO_ = -3.4765 * R._PAGO_
                        R._SDOIMP_ = 1.6675 * R._SDOIMP_
                        Total = R.ATR + R.MAXATR + R._PAGO_ + R._SDOIMP_ + (-1.858 * R._AUTO) + (0.8535 * R.NOMINA) + (0.4955 * R.PERSONAL) + (-0.1344 * R.OTRO)
                        Total = (logaritmo ^ (Total * -1)) + 1
                        R.PI = Math.Round(1 / Total, 4)
                        R.RI = (R.PI * R.SP) * (R.Saldo)
                    End If
                    R.ATR = ATR
                    R.MAXATR = MAXATR
                    R._PAGO_ = PAGO
                    R._SDOIMP_ = SDOIMP
                Case "Catorcenal"
                    R.ATR = Math.Ceiling((M.Dias) / 15.2)
                    ATR = R.ATR

                    If R.ATR >= 7 Then R.PI = 1
                    If R.ATR < 20 Then R.SP = 0.65 Else R.SP = 1
                    If R.PI = 1 Then
                        R.RI = R.PI * R.SP
                        R.RI = R.Saldo * R.RI
                    Else
                        TAFacturas.FillBy13(Factura, cAnexo)
                        For Each F In Factura.Rows
                            R._PAGO_ += F.PagoMes / F.MontoFactura
                        Next
                        R._PAGO_ = ((R._PAGO_ + (13 - Factura.Rows.Count)) / 13)
                        PAGO = R._PAGO_
                        R.PR = (R.Saldo) / M.MOI
                        VECES = R.PR
                        Cad = TAmezcla.ScalarAUTO(cAnexo)
                        If Trim(Cad) = "" Then
                            R._AUTO = 0
                            R.OTRO = 1
                        Else
                            R._AUTO = 1
                            R.OTRO = 0
                        End If
                        R.ATR = (-0.6585) + (0.3435 * R.ATR)
                        If M.Dias > 0 Then R.INDATR = 1 * 0.777 Else R.INDATR = 0
                        R._PAGO_ = -4.2191 * R._PAGO_
                        R.PR = 2.3194 * R.PR
                        Total = R.ATR + R.INDATR + R._PAGO_ + R.PR + (-0.5615 * R._AUTO) + (0.1771 * R.NOMINA) + (-0.0149 * R.OTRO)
                        Total = (logaritmo ^ (Total * -1)) + 1
                        R.PI = Math.Round(1 / Total, 4)
                        R.RI = (R.PI * R.SP) * (R.Saldo)
                    End If
                    R.ATR = ATR
                    R._PAGO_ = PAGO
                    R.PR = VECES
                Case "Mensual"
                    R.ATR = Math.Ceiling((M.Dias) / 30.4)
                    ATR = R.ATR
                    If R.ATR >= 4 Then R.PI = 1
                    If R.ATR < 10 Then R.SP = 0.65 Else R.SP = 1
                    If R.PI = 1 Then
                        R.RI = R.PI * R.SP
                        R.RI = R.Saldo * R.RI
                    Else
                        R.VECES = TAFacturas.ScalarTotalPagado(cAnexo)
                        R.VECES = R.VECES / M.MOI
                        VECES = R.VECES
                        TAFacturas.FillBy4(Factura, cAnexo)
                        For Each F In Factura.Rows
                            R._PAGO_ += F.PagoMes / F.MontoFactura
                        Next
                        R._PAGO_ = ((R._PAGO_ + (4 - Factura.Rows.Count)) / 4)
                        PAGO = R._PAGO_

                        Cad = TAmezcla.ScalarAUTO(cAnexo)
                        If Trim(Cad) = "" Then
                            R._AUTO = 0
                            R.PERSONAL = 1
                        Else
                            R._AUTO = 1
                            R.PERSONAL = 0
                        End If
                        R.ATR = (-0.5753) + (0.4056 * R.ATR)
                        R.VECES = 0.7923 * R.VECES
                        R._PAGO_ = -4.1891 * R._PAGO_
                        Total = R.ATR + R.VECES + R._PAGO_ + (1.7709 * R._AUTO) + (-0.2089 * R.NOMINA) + (0.9962 * R.PERSONAL) + (-1.3956 * R.OTRO)
                        Total = (logaritmo ^ (Total * -1)) + 1
                        R.PI = Math.Round(1 / Total, 4)
                        R.RI = (R.PI * R.SP) * (R.Saldo)
                    End If
                    R.ATR = ATR
                    R._PAGO_ = PAGO
                    R.VECES = VECES
            End Select
            CalificacionDS.Tables("Reporte").Rows.Add(R)
        Next

        Dim newrptRepoSegu As New RptCalConsumo
        newrptRepoSegu.SetDataSource(CalificacionDS)
        newrptRepoSegu.SummaryInfo.ReportTitle = "Calificación de la Cartera de Consumo"
        newrptRepoSegu.SetParameterValue("Titulo", "Reporte de Calificación de la Cartera de Creditos al Consumo del mes de " & MonthName(Fecha.Month) & " del " & Fecha.Year)
        CrystalReportViewer1.ReportSource = newrptRepoSegu
        CrystalReportViewer1.Visible = True

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Cursor.Current = Cursors.WaitCursor
        procesar()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cursor.Current = Cursors.WaitCursor
        Dim Arr(89) As String
        Dim Cad As String
        Dim x As Integer = 0

        Dim tadatos As New CalificacionDSTableAdapters.DatosConsumoTableAdapter
        Dim t As New CalificacionDS.DatosConsumoDataTable
        Dim r As CalificacionDS.DatosConsumoRow

        Dim taAnexos As New CalificacionDSTableAdapters.Vw_AnexosTableAdapter
        Dim tt As New CalificacionDS.Vw_AnexosDataTable
        Dim rr As CalificacionDS.Vw_AnexosRow

        Dim taFac As New CalificacionDSTableAdapters.FacturasConsumoTableAdapter
        Dim ttFac As New CalificacionDS.FacturasConsumoDataTable
        Dim rfac As CalificacionDS.FacturasConsumoRow

        Dim tadias As New CalificacionDSTableAdapters.RetrasosTableAdapter
        Dim ttdias As New CalificacionDS.RetrasosDataTable
        Dim rdia As CalificacionDS.RetrasosRow

        Dim taaval As New CalificacionDSTableAdapters.AvalesTableAdapter
        Dim ttaval As New CalificacionDS.AvalesDataTable
        Dim raval As CalificacionDS.AvalesRow

        tadatos.Connection.ConnectionString = "Server=" & My.Settings.ServidorX & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015;Connection Timeout=120"
        taAnexos.Connection.ConnectionString = "Server=" & My.Settings.ServidorX & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        taFac.Connection.ConnectionString = "Server=" & My.Settings.ServidorX & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        tadias.Connection.ConnectionString = "Server=" & My.Settings.ServidorX & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        taaval.Connection.ConnectionString = "Server=" & My.Settings.ServidorX & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"

        tadatos.Fill(t)
        If t.Rows.Count >= 1 Then

            Dim Archivo As New IO.StreamWriter("c:\files\Consumo" & CmbDB.Text & ".csv", False)
            Archivo.WriteLine("ID_CREDITO_FIRA,ID_ACREDITADO_FIRA,ID_CREDITO_INST,ID_ACREDITADO_INST,FH_INICIO,FH_TERMINO,ST_CREDITO,PER_PAGO,ID_GRUPAL,EI,FH_ULT_PAGO,IM_PAGO_PERIODICO,IM_EXIG_C_T_13,IM_EXIG_C_T_12,IM_EXIG_C_T_11,IM_EXIG_C_T_10,IM_EXIG_C_T_9,IM_EXIG_C_T_8,IM_EXIG_C_T_7,IM_EXIG_C_T_6,IM_EXIG_C_T_5,IM_EXIG_C_T_4,IM_EXIG_C_T_3,IM_EXIG_C_T_2,IM_EXIG_C_T_1,IM_EXIG_C_T,IM_PAGO_T_13,IM_PAGO_T_12,IM_PAGO_T_11,IM_PAGO_T_10,IM_PAGO_T_9,IM_PAGO_T_8,IM_PAGO_T_7,IM_PAGO_T_6,IM_PAGO_T_5,IM_PAGO_T_4,IM_PAGO_T_3,IM_PAGO_T_2,IM_PAGO_T_1,IM_PAGO_T,DIAS_T_5,DIAS_T_4,DIAS_T_3,DIAS_T_2,DIAS_T_1,DIAS_T,IM_CREDITO,IM_VAL_BIEN,CD_DESTINO,MON,CICLOS,INTEG,GARANTIA_RF,NUM_GRF,GARANTIA_RNF,NUM_GRNF,GARANTIA_P,NUM_GP,TIPO_GRF,VALOR_CONTABLE_GRF1,VALOR_CONTABLE_GRF2,Hfx_GRF1,Hfx_GRF2,FACTOR_AJUSTE,TIPO_GRNF,GARANTIA_ART32,VALOR_GARANTIA_GRNF1,VALOR_GARANTIA_GRNF2,VALOR_GARANTIA_GRNF3,PORC_CUB_GP1,NOM_GARANTE1,RFC_GARANTE1,TIPO_GARANTE1,MONEDA_GP1,PORC_CUB_GP2,NOM_GARANTE2,RFC_GARANTE2,TIPO_GARANTE2,MONEDA_GP2,NOM_GARANTE_PM,NOM_GARANTE_PP,PORC_CUB_PM,PORC_CUB_SP,RFC_GARANTE_PM,RFC_GARANTE_PP,ID_PORTAFOLIO_PP,MONTO_PORTAFOLIO_PP,TIPO_GARANTE_PM,TIPO_GARANTE_PP,")
            For Each r In t.Rows
                taAnexos.Fill(tt, r.Anexo)
                rr = tt.Rows(0)
                Arr(1) = 0
                Arr(2) = 0
                Arr(3) = r.Anexo
                Arr(4) = rr.Cliente
                Arr(5) = rr.Fechacon
                Arr(6) = rr.Feven
                If rr.Vencida = "N" Then Arr(7) = "VI" Else Arr(7) = "VE"
                Select Case r.Vencimiento
                    Case "Semanal"
                        Arr(8) = "S"
                    Case "Quincenal", "Catorcenal"
                        Arr(8) = "Q"
                    Case Else
                        Arr(8) = "M"
                End Select
                Arr(9) = 0
                Arr(10) = tadatos.SaodloInsoluto(rr.Anexo)
                Cad = TaQUERY.UltimoPago(rr.Anexo)
                If Cad.Trim = "" Then
                    Arr(11) = rr.Fechacon
                Else
                    Arr(11) = Cad
                End If
                Arr(12) = rr.Mensu
                taFac.Fill(ttFac, rr.Anexo)
                x = 0
                For Each rfac In ttFac.Rows
                    x += 1
                    If x = 1 Then
                        Arr(26) = rfac.ImporteFac
                        Arr(40) = rfac.ImporteFac - rfac.SaldoFac
                    Else
                        Arr(11 + x) = rfac.ImporteFac
                        Arr(25 + x) = rfac.ImporteFac - rfac.SaldoFac
                    End If
                Next
                For y As Integer = x + 1 To 14
                    Arr(11 + y) = 0
                    Arr(25 + y) = 0
                Next
                tadias.Fill(ttdias, rr.Anexo)
                x = 0
                For Each rdia In ttdias.Rows
                    x += 1
                    If x = 1 Then
                        If rdia.Retraso < 0 Then
                            Arr(46) = 0
                        Else
                            Arr(46) = rdia.Retraso
                        End If
                    Else
                        If rdia.Retraso < 0 Then
                            Arr(39 + x) = 0
                        Else
                            Arr(39 + x) = rdia.Retraso
                        End If
                    End If
                Next
                For y As Integer = x + 1 To 6
                    Arr(11 + y) = 0
                    Arr(25 + y) = 0
                Next
                Arr(47) = rr.MontoFin
                Arr(48) = rr.impeq
                If r.Tipar = "S" Or r.Tipar = "L" Then
                    Arr(49) = "P"
                    Arr(55) = 2
                    Arr(56) = 0
                    Arr(65) = 0
                    Arr(68) = -999
                Else
                    Arr(49) = "A"
                    Arr(55) = 1
                    Arr(56) = 1
                    Arr(65) = 2
                    Arr(68) = rr.impeq
                End If
                Arr(50) = 1
                Arr(51) = 1
                Arr(52) = 1
                Arr(53) = 2
                Arr(54) = 0
                Arr(57) = 2
                Arr(58) = 0
                Arr(59) = 0
                Arr(60) = 0
                Arr(61) = 0
                Arr(62) = 0
                Arr(63) = 0
                Arr(64) = 0
                Arr(66) = 0
                Arr(67) = -999
                Arr(69) = -999
                Arr(70) = -999
                taaval.Fill(ttaval, rr.Anexo)
                If ttaval.Rows.Count <= 0 Then
                    Arr(71) = "ND"
                    Arr(72) = "ND"
                    Arr(73) = 0
                Else
                    raval = ttaval.Rows(0)
                    Cad = raval.Descr.Replace(",", "")
                    Arr(71) = Cad.Trim
                    Arr(72) = raval.RFC.Trim
                    If raval.Tipo = "M" Then
                        Arr(73) = 4
                    Else
                        Arr(73) = 3
                    End If
                End If
                Arr(74) = 1
                Arr(75) = -999
                Arr(76) = "ND"
                Arr(77) = "ND"
                Arr(78) = 0
                Arr(79) = 0
                Arr(80) = "ND"
                Arr(81) = "ND"
                Arr(82) = 0
                Arr(83) = 0
                Arr(84) = "ND"
                Arr(85) = "ND"
                Arr(86) = "ND"
                Arr(87) = 0
                Arr(88) = 0
                Arr(88) = 0
                Arr(89) = 0
                Cad = ""
                For y As Integer = 1 To 89
                    Cad += Arr(y) & ","
                Next
                Archivo.WriteLine(Cad)
            Next
            Archivo.Close()
        End If
        Cursor.Current = Cursors.Default
        MessageBox.Show("Proceso Terminado", "Layout", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class