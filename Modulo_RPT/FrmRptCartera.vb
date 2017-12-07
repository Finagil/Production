Public Class FrmRptCartera
    Dim ta As New ReportesDSTableAdapters.SP_Rpt_CarteraExigibleTableAdapter
    Dim t As New ReportesDS.SP_Rpt_CarteraExigibleDataTable
    Dim r As ReportesDS.SP_Rpt_CarteraExigibleRow
    Dim rr, ro As ReportesDS.CarteraExigibleRPTRow

    Private Sub FrmRptCartera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim Otros As Decimal = 0
        Dim Exigible As Decimal = 0
        Dim SaldoInsoluto As Decimal = 0

        Status1 = "N"
        Status2 = "S"
        Status3 = "C"
        If CmbDB.SelectedIndex <> 0 Then DB = CmbDB.Text
        Cursor.Current = Cursors.WaitCursor
        ta.Connection.ConnectionString = "Server=SERVER-RAID; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"

        Try
            If DB <> "Production" Then
                'reversa a los avisos de vencimiento generados del mes siguiente
                ta.CancelaFactEDOCTA(CmbDB.SelectedValue)
            End If
            ta.Fill(t, CmbDB.SelectedValue, Status1, Status2, Status3, DB)
        Catch ex As Exception
            MessageBox.Show("Error en la base de datos " & DB & vbCrLf & ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ReportesDS.CarteraExigibleRPT.Clear()
        'Dim dv As New DataView(t)
        'dv.Sort = "AnexoCon"
        't = dv.ToTable

        For Each r In t.Rows
            ContRow += 1
            If InStr(r.AnexoCon, "03803/0006") Then
                dias = 0
            End If
            If r.TipoCredito = "CREDITO DE AVÍO" Or r.TipoCredito = "ANTICIPO AVÍO" Or r.TipoCredito = "CUENTA CORRIENTE" Then

                If Anexo <> r.AnexoCon And Anexo <> "" Then
                    ReportesDS.CarteraExigibleRPT.Rows.Add(rr)
                End If
                rr = ReportesDS.CarteraExigibleRPT.NewRow
                rr._29dias = 0
                rr._59Dias = 0
                rr._89Dias = 0
                rr._90Dias = 0
                rr.Total_Exigible = 0
                rr.SaldoInsoluto = 0
                rr.Estatus = ""
                rr.Promotor = r.Iniciales_Promotor
                SacaExigibleAvio()
            Else

                If Anexo = "" Then
                    SaldoInsoluto = 0
                    SaldoInsoluto += ta.SaldoInsolutoCAP(r.Anexo)
                    SaldoInsoluto += ta.SaldoInsolutoSEG(r.Anexo)
                    rr = ReportesDS.CarteraExigibleRPT.NewRow
                    ro = ReportesDS.CarteraExigibleRPT.NewRow
                    Anexo = r.AnexoCon
                    rr._29dias = 0
                    rr._59Dias = 0
                    rr._89Dias = 0
                    rr._90Dias = 0
                    rr.Total_Exigible = 0
                    rr.SaldoInsoluto = SaldoInsoluto
                    rr.Promotor = r.Iniciales_Promotor

                    ro._29dias = 0
                    ro._59Dias = 0
                    ro._89Dias = 0
                    ro._90Dias = 0
                    ro.Total_Exigible = 0
                    ro.SaldoInsoluto = ta.SaldoInsolutoOTR(r.Anexo)
                    ro.Promotor = r.Iniciales_Promotor
                    If r.Estatus <> "C" Then
                        rr.Estatus = "Exigible"
                        ro.Estatus = "Exigible"
                    Else
                        rr.Estatus = "Castigada"
                        ro.Estatus = "Castigada"
                    End If

                End If

                If Anexo <> r.AnexoCon Then
                    SaldoInsoluto = 0
                    SaldoInsoluto += ta.SaldoInsolutoCAP(r.Anexo)
                    SaldoInsoluto += ta.SaldoInsolutoSEG(r.Anexo)
                    ReportesDS.CarteraExigibleRPT.Rows.Add(rr)
                    If ro.Total_Exigible > 0 Then
                        ReportesDS.CarteraExigibleRPT.Rows.Add(ro)
                    End If
                    rr = ReportesDS.CarteraExigibleRPT.NewRow
                    ro = ReportesDS.CarteraExigibleRPT.NewRow
                    rr._29dias = 0
                    rr._59Dias = 0
                    rr._89Dias = 0
                    rr._90Dias = 0
                    rr.Total_Exigible = 0
                    rr.SaldoInsoluto = SaldoInsoluto
                    rr.Promotor = r.Iniciales_Promotor

                    ro._29dias = 0
                    ro._59Dias = 0
                    ro._89Dias = 0
                    ro._90Dias = 0
                    ro.Total_Exigible = 0
                    ro.SaldoInsoluto = ta.SaldoInsolutoOTR(r.Anexo)
                    ro.Promotor = r.Iniciales_Promotor
                    If r.Estatus <> "C" Then
                        rr.Estatus = "Exigible"
                        ro.Estatus = "Exigible"
                    Else
                        rr.Estatus = "Castigada"
                        ro.Estatus = "Castigada"
                    End If
                End If

                rr.Anexo = r.AnexoCon
                rr.Cliente = r.Descr
                rr.Tipo_Credito = r.TipoCredito
                dias = DateDiff(DateInterval.Day, CTOD(r.Feven), CTOD(CmbDB.SelectedValue))
                Exigible = r.Exigible
                Otros = r.Otros
                If Otros > 0 And r.TipoCredito = "ARRENDAMIENTO FINANCIERO" Then
                    Pag = r.ImportetT - r.Exigible

                    If Pag >= r.Otros Then
                        Otros = 0
                    Else
                        Otros -= Pag
                    End If
                    If Otros > 0 Then
                        ro.Anexo = r.AnexoCon
                        ro.Cliente = r.Descr
                        ro.Tipo_Credito = "CREDITO SIMPLE"
                        Exigible -= Otros
                        Select Case dias
                            Case Is <= 30
                                ro._29dias += Otros
                            Case Is <= 60
                                ro._59Dias += Otros
                            Case Is < 90
                                ro._89Dias += Otros
                            Case Else
                                ro._90Dias += Otros
                                If r.Estatus <> "C" Then
                                    ro.Estatus = "Vencida"
                                End If
                        End Select
                        ro.Total_Exigible += Otros
                    End If
                End If

                Select Case dias
                    Case Is <= 30
                        rr._29dias += Exigible
                    Case Is <= 60
                        rr._59Dias += Exigible
                    Case Is < 90
                        rr._89Dias += Exigible
                    Case Else
                        rr._90Dias += Exigible
                        If r.Estatus <> "C" Then
                            rr.Estatus = "Vencida"
                        End If
                End Select
                rr.Total_Exigible += Exigible
                If ContRow = t.Rows.Count Then ' es el ultimo registro
                    ReportesDS.CarteraExigibleRPT.Rows.Add(rr)
                    If ro.Total_Exigible > 0 Then
                        ReportesDS.CarteraExigibleRPT.Rows.Add(ro)
                    End If
                End If
            End If
            Anexo = r.AnexoCon
        Next

        Dim ReportesDS1 As New ReportesDS
        For Each rr In ReportesDS.CarteraExigibleRPT.Rows
            If rr.Estatus = "Exigible" Then
                ReportesDS1.CarteraExigibleRPT.ImportRow(rr)
            End If
        Next

        Dim rpt As New RptCarteraExigible
        rpt.SetDataSource(ReportesDS1)
        rpt.SetParameterValue("titulo", CTOD(CmbDB.SelectedValue).ToString("dd \DE MMMM \DEL yyyy").ToUpper)
        CRViewer.ReportSource = rpt
        Cursor.Current = Cursors.Default
        MessageBox.Show("Reporte Terminado", "Cartera Exigible", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Sub SacaExigibleAvio()
        Dim dias As Integer
        Dim Capital As Decimal = r.Exigible ' para avio es ImporteCapital + Fega si hay trapaso en otro aso el saldo
        Dim PAGADO As Decimal = r.Otros * -1 ' contiene el Interes, dega y cap Pagado
        Dim InteresTRASP As Decimal = r.ImportetT ' contiene el interes traspasado
        'Dim SaldoInteresOrdinario As Decimal = 0
        If InteresTRASP > 0 Then
            If PAGADO >= InteresTRASP + Capital Then
                Capital = 0
                InteresTRASP = 0
            Else
                'InteresTRASP = InteresTRASP - InteresPAG
                If PAGADO > InteresTRASP Then
                    InteresTRASP = 0
                    PAGADO -= InteresTRASP
                Else
                    InteresTRASP -= PAGADO
                End If
                If PAGADO > Capital Then
                    Capital = 0
                Else
                    Capital -= PAGADO
                End If
            End If
        End If

        If rr.Estatus = "" Then
            rr.Estatus = "Exigible"
        End If
        If r.Estatus = "C" Then
            rr.Estatus = "Castigada"
        End If

        rr.Anexo = r.AnexoCon
        rr.Cliente = r.Descr
        rr.Tipo_Credito = r.TipoCredito
        dias = DateDiff(DateInterval.Day, CTOD(r.Feven), CTOD(CmbDB.SelectedValue))

        If r.Estatus = "C" Then
            rr.Estatus = "Castigada"
        ElseIf dias >= 30 And r.TipoCredito <> "CUENTA CORRIENTE" Then
            rr.Estatus = "Vencida"
        ElseIf dias >= 60 And r.TipoCredito = "CUENTA CORRIENTE" Then
            rr.Estatus = "Vencida"
        End If

        Select Case dias
            Case Is <= 30
                rr._29dias += Capital + InteresTRASP
            Case Is <= 60
                rr._59Dias += Capital + InteresTRASP
            Case Is < 90
                rr._89Dias += Capital + InteresTRASP
            Case Else
                rr._90Dias += Capital + InteresTRASP
        End Select
        rr.Total_Exigible += Capital + InteresTRASP

    End Sub

End Class