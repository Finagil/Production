Public Class FrmRptCarteraVEN
    Dim ta As New ReportesDSTableAdapters.SP_Rpt_CarteraVencidaTableAdapter
    Dim taA As New ReportesDSTableAdapters.AvisosTableAdapter
    Dim Avi As New ReportesDS.AvisosDataTable
    Dim AA As ReportesDS.AvisosRow
    Dim t As New ReportesDS.SP_Rpt_CarteraVencidaDataTable
    Dim r As ReportesDS.SP_Rpt_CarteraVencidaRow
    Dim rr As ReportesDS.CarteraVencidaRPTRow

    Private Sub FrmRptCarteraVEN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim t As New DataTable
        Dim r As DataRow
        t.Columns.Add("ID")
        t.Columns.Add("TIT")

        Dim Fecha As Date = Date.Now
        r = t.NewRow
        r("ID") = Date.Now.ToString("yyyyMMdd")
        r("TIT") = "A la Fecha"
        t.Rows.Add(r)

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
        CmbDB.SelectedIndex = 1

    End Sub


    Private Sub BtnProc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProc.Click
        Dim Anexo As String = ""
        Dim Status1 As String = "N"
        Dim Status2 As String = "X"
        Dim Status3 As String = "X"
        Dim DB As String = "Production"
        Dim dias As Integer = 0
        Dim Pag As Decimal = 0
        Dim ContRow As Integer = 0
        Dim PAgo As Decimal = 0
        Dim Exigible As Decimal = 0
        Dim RentCAP As Decimal = 0
        Dim RentOTR As Decimal = 0
        Dim RentINT As Decimal = 0
        Dim OPcion As Decimal = 0
        Dim SaldoInsoluto As Decimal = 0
        Dim Castigo As Decimal
        Dim Garantia As Decimal
        Dim EsPagoUnico As Boolean = False
        Dim Aux As String
        Dim FechaAux As String

        If CmbDB.SelectedIndex = 0 Then
            FechaAux = DTPFecha.Value.ToString("yyyyMMdd")
        Else
            FechaAux = CmbDB.SelectedValue
        End If

        Status1 = "N"
        Status2 = "S"
        Status3 = "C"
        If CmbDB.SelectedIndex <> 0 Then DB = CmbDB.Text
        Cursor.Current = Cursors.WaitCursor
        ta.Connection.ConnectionString = "Server=SERVER-RAID; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"


        Try
            If DB.ToUpper <> "PRODUCTION" Then
                Dim TX As New ReportesDSTableAdapters.AvisosNoProcedentesTableAdapter
                TX.Connection.ConnectionString = "Server=SERVER-RAID; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
                Dim TXX As New ReportesDS.AvisosNoProcedentesDataTable
                Dim RX As ReportesDS.AvisosNoProcedentesRow
                TX.Fill(TXX, FechaAux)
                For Each RX In TXX.Rows
                    TX.QuitaAvisoTablaV(RX.Anexo, RX.Factura)
                    TX.QuitaAvisoTablaS(RX.Anexo, RX.Factura)
                    TX.QuitaAvisoTablaO(RX.Anexo, RX.Factura)
                    TX.QuitaAviso(RX.Factura)
                Next
            End If
            ta.Fill(t, FechaAux, Status1, Status2, Status3, DB)
        Catch ex As Exception
            MessageBox.Show("Error en la base de datos " & DB & vbCrLf & ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ReportesDS.CarteraVencidaRPT.Clear()

        For Each r In t.Rows
            ContRow += 1
            If InStr(r.AnexoCon, "02898/0001") Then
                dias = 0
            End If
            If r.TipoCredito = "CREDITO DE AVÍO" Or r.TipoCredito = "ANTICIPO AVÍO" Or r.TipoCredito = "CUENTA CORRIENTE" Then
                If Anexo <> r.AnexoCon And Anexo <> "" Then
                    ReportesDS.CarteraVencidaRPT.Rows.Add(rr)
                    rr = ReportesDS.CarteraVencidaRPT.NewRow
                    LlenaVacios(rr, SaldoInsoluto, Castigo, Garantia)
                End If

                SacaExigibleAvio(FechaAux, Castigo, Garantia)

                If ContRow = t.Rows.Count Then ' es el ultimo registro
                    ReportesDS.CarteraVencidaRPT.Rows.Add(rr)
                End If
            Else
                If Anexo = "" Then
                    rr = ReportesDS.CarteraVencidaRPT.NewRow
                    Anexo = r.AnexoCon
                    LlenaVacios(rr, SaldoInsoluto, Castigo, Garantia)

                    If r.Estatus <> "C" Then
                        If rr.Estatus = "" Then rr.Estatus = "Exigible"
                    Else
                        rr.Estatus = "Castigada"
                    End If
                End If

                If Anexo <> r.AnexoCon Then
                    ReportesDS.CarteraVencidaRPT.Rows.Add(rr)
                    rr = ReportesDS.CarteraVencidaRPT.NewRow
                    LlenaVacios(rr, SaldoInsoluto, Castigo, Garantia)

                    If r.Estatus <> "C" Then
                        If rr.Estatus = "" Then rr.Estatus = "Exigible"
                    Else
                        rr.Estatus = "Castigada"
                    End If
                    OPcion = r.Opcion
                End If

                rr.Anexo = r.AnexoCon
                Aux = Mid(r.AnexoCon, 1, 5) & Mid(r.AnexoCon, 7, 4)
                If ta.EsPagoUnico(Aux) <> False Then
                    EsPagoUnico = True
                Else
                    EsPagoUnico = False
                End If
                rr.Cliente = r.Descr
                rr.Tipo_Credito = r.TipoCredito
                dias = DateDiff(DateInterval.Day, CTOD(r.Feven), CTOD(FechaAux))
                Exigible = r.Exigible
                PAgo = r.ImportetT - r.Exigible

                Select Case dias
                    Case 30 To 89
                        If EsPagoUnico = True And r.Capital > 0 Then
                            rr.Estatus = "Vencida"
                        End If
                        If r.TipoCredito = "ARRENDAMIENTO PURO" Then
                            rr.Estatus = "Vencida"
                        End If
                    Case Is >= 90
                        If r.Estatus <> "C" Then
                            rr.Estatus = "Vencida"
                        End If
                        If r.Estatus = "C" And Castigo > 0 Then
                            rr.Estatus = "Vencida"
                        End If
                End Select
                If OPcion > 0 Then rr.Opcion = OPcion
                If rr.DiasRetraso <= dias Then
                    rr.DiasRetraso = dias
                End If

                rr.TotalVencido += Exigible + SaldoInsoluto + OPcion - Castigo - Garantia
                OPcion = 0
                SaldoInsoluto = 0
                Castigo = 0
                Garantia = 0
                taA.Fill(Avi, r.Aviso)
                If Avi.Rows.Count > 0 Then
                    AA = Avi.Rows(0)
                    RentCAP = AA.RenPr - AA.IntPr
                    RentINT = AA.IntPr + AA.InteresOt + AA.IntSe + AA.VarPr + AA.VarOt + AA.VarSe
                    RentOTR = -AA.Bonifica + AA.CapitalOt + AA.ImporteFEGA + AA.SeguroVida + AA.RenSe +
                              AA.IvaCapital + AA.IvaOpcion + AA.IvaOt + AA.IvaPr + AA.IvaSe + AA.Opcion
                    If PAgo > RentINT Then
                        PAgo -= RentINT
                        RentINT = 0
                    Else
                        RentINT -= PAgo
                        PAgo = 0
                    End If
                    If PAgo > RentOTR Then
                        PAgo -= RentOTR
                        RentOTR = 0
                    Else
                        RentOTR -= PAgo
                        PAgo = 0
                    End If
                    If PAgo > RentCAP Then
                        PAgo -= RentCAP
                        RentCAP = 0
                    Else
                        RentCAP -= PAgo
                        PAgo = 0
                    End If
                End If
                rr.RentaCapital += RentCAP
                rr.RentaInteres += RentINT
                rr.RentaOtros += RentOTR

                If ContRow = t.Rows.Count Then ' es el ultimo registro
                    ReportesDS.CarteraVencidaRPT.Rows.Add(rr)
                End If
            End If
            Anexo = r.AnexoCon
        Next

        Dim ReportesDS1 As New ReportesDS
        For Each rr In ReportesDS.CarteraVencidaRPT.Rows
            If rr.Estatus = "Vencida" Then
                ReportesDS1.CarteraVencidaRPT.ImportRow(rr)
            End If
        Next

        Dim rpt As New RptCarteraVencida
        rpt.SetDataSource(ReportesDS1)
        rpt.SetParameterValue("titulo", CTOD(FechaAux).ToString("dd \DE MMMM \DEL yyyy").ToUpper)
        rpt.SetParameterValue("Status1", "Vencida")
        rpt.SetParameterValue("Status2", "Vencida")

        'If CheckCAS.Checked = True Then
        '    rpt.SetParameterValue("Status3", "Castigada")
        'Else
        rpt.SetParameterValue("Status3", "Vencida")
        'End If

        CRViewer.ReportSource = rpt
        Cursor.Current = Cursors.Default
        MessageBox.Show("Reporte Terminado", "Cartera Vencida", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Sub SacaExigibleAvio(FechaAux As String, ByRef Castigo As Decimal, ByRef Garantia As Decimal)
        Dim dias As Integer
        Dim Capital As Decimal = r.Exigible ' para avio es ImporteCapital + Fega si hay trapaso en otro aso el saldo
        Dim GarantiaLIQ As Decimal = r.Otros 'garntia liquida de estado de cuenta
        Dim InteresTRASP As Decimal = r.ImportetT ' contiene el interes traspasado

        Capital -= GarantiaLIQ

        If rr.Estatus = "" Then
            rr.Estatus = "Exigible"
        End If
        rr.Anexo = r.AnexoCon
        rr.Cliente = r.Descr
        rr.Tipo_Credito = r.TipoCredito

        dias = DateDiff(DateInterval.Day, CTOD(r.Feven), CTOD(FechaAux))

        If r.Estatus = "C" And Castigo = 0 Then
            rr.Estatus = "Castigada"
        ElseIf dias >= 30 And r.TipoCredito <> "CUENTA CORRIENTE" Then
            rr.Estatus = "Vencida"
        ElseIf dias >= 60 And r.TipoCredito = "CUENTA CORRIENTE" Then
            rr.Estatus = "Vencida"
        End If
        rr.TotalVencido += Capital - Garantia - Castigo
        If rr.DiasRetraso <= dias Then
            rr.DiasRetraso= dias
        End If
        rr.RentaCapital = Capital
        rr.RentaInteres = InteresTRASP
        'rr.RentaOtros = r.Capital
        'rr.RentaOtros = Capital
    End Sub

    Sub LlenaVacios(ByRef rr As ReportesDS.CarteraVencidaRPTRow, ByRef SaldoInsoluto As Decimal, ByRef Castigo As Decimal, ByRef Garantia As Decimal)
        Dim Aux As String
        rr.DiasRetraso = 0
        rr.SaldoInsoluto = 0
        rr.SaldoSeguro = 0
        rr.SaldoOtros = 0
        rr.RentaCapital = 0
        rr.RentaInteres = 0
        rr.RentaOtros = 0
        rr.TotalVencido = 0
        rr.Castigo = 0
        rr.Garantia = 0
        rr.Opcion = 0
        rr.Estatus = ""
        If r.Fecha_Pago.Trim = "" Then
            rr.FechaActivacion = r.fechaCont
        Else
            rr.FechaActivacion = CTOD(r.Fecha_Pago)
        End If
        rr.FechaTerminacion = r.fechaVEN
        Aux = Mid(r.AnexoCon, 1, 5) & Mid(r.AnexoCon, 7, 4)
        rr.SaldoInsoluto = ta.SaldoInsolutoCAP(Aux)
        rr.SaldoSeguro = ta.SaldoInsolutoSeg(Aux)
        rr.SaldoOtros = ta.SaldoInsolutoOTR(Aux)
        Castigo = r.Castigo
        Garantia = r.Garantia
        rr.Castigo = r.Castigo
        rr.Garantia = r.Garantia
        If r.TipoCredito = "ARRENDAMIENTO PURO" Then
            SaldoInsoluto = 0 ' SOLO SUMAN LAS RENTAS VENCIDAS
        Else
            SaldoInsoluto = rr.SaldoInsoluto + rr.SaldoOtros + rr.SaldoSeguro
        End If
        If InStr(r.AnexoCon, "03021/0001") And Date.Now < CDate("30/06/2018") Then
            SaldoInsoluto += 253492.05
        End If

    End Sub

    Private Sub CmbDB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDB.SelectedIndexChanged
        If CmbDB.SelectedIndex = 0 Then
            DTPFecha.Enabled = True
            DTPFecha.MinDate = FECHA_APLICACION.AddDays(FECHA_APLICACION.Day * -1).AddDays(1)
            DTPFecha.MaxDate = FECHA_APLICACION
        Else
            DTPFecha.Enabled = False
        End If
    End Sub
End Class