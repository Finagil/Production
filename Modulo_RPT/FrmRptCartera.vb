Public Class FrmRptCartera
    Dim ta As New ReportesDSTableAdapters.SP_Rpt_CarteraExigibleTableAdapter
    Dim taAux As New GeneralDSTableAdapters.QueryVariosTableAdapter
    Dim t As New ReportesDS.SP_Rpt_CarteraExigibleDataTable
    Dim r As ReportesDS.SP_Rpt_CarteraExigibleRow
    Dim rr, ro As ReportesDS.CarteraExigibleRPTRow
    Dim taRpt As New ReportesDSTableAdapters.CarteraExigibleRPTTableAdapter

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
        CmbDB.SelectedIndex = 1

    End Sub

    Private Sub BtnProc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProc.Click
        Cursor.Current = Cursors.WaitCursor
        Dim ProcesaTODO As Boolean = False
        Dim Anexo As String = ""
        Dim Status1 As String = "N"
        Dim Status2 As String = "X"
        Dim Status3 As String = "X"
        Dim DB As String = My.Settings.BaseDatos
        Dim dias As Integer = 0
        Dim Pag As Decimal = 0
        Dim ContRow As Integer = 0
        Dim Otros As Decimal = 0
        Dim Exigible As Decimal = 0
        Dim SaldoInsoluto As Decimal = 0
        Dim Aux As String

        Status1 = "N"
        Status2 = "S"
        Status3 = "C"
        If CmbDB.SelectedIndex <> 0 Then DB = CmbDB.Text
        ta.CommandTimeout = 180
        If CmbDB.Text = "A la Fecha" Then
            ta.Connection.ConnectionString = "Server=" & My.Settings.ServidorPROD & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
            taAux.Connection.ConnectionString = "Server=" & My.Settings.ServidorPROD & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
            taRpt.Connection.ConnectionString = "Server=" & My.Settings.ServidorPROD & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
        Else
            ta.Connection.ConnectionString = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
            taAux.Connection.ConnectionString = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
            taRpt.Connection.ConnectionString = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
        End If

        Try
            If DB.ToUpper <> My.Settings.BaseDatos.ToUpper Then
                taRpt.Fill(ReportesDS.CarteraExigibleRPT, "")
                If ReportesDS.CarteraExigibleRPT.Rows.Count <= 0 Then
                    taRpt.DeleteTipo("")
                    ta.CancelaFactEDOCTA(CmbDB.SelectedValue)
                    ProcesaTODO = True
                Else
                    ProcesaTODO = False
                End If
            End If
            If ProcesaTODO = True Then
                ta.Fill(t, CmbDB.SelectedValue, Status1, Status2, Status3, DB)
            Else
                taRpt.Fill(ReportesDS.CarteraExigibleRPT, "")
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la base de datos " & DB & vbCrLf & ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Dim dv As New DataView(t)
        'dv.Sort = "AnexoCon"
        't = dv.ToTable
        If ProcesaTODO = True Then
            For Each r In t.Rows
                ContRow += 1
                If InStr(r.AnexoCon, "03662/0001") Then
                    dias = 0
                End If
                If r.TipoCredito = "CREDITO DE AV�O" Or r.TipoCredito = "ANTICIPO AV�O" Or r.TipoCredito = "CUENTA CORRIENTE" Then

                    If Anexo <> r.AnexoCon And Anexo <> "" Then
                        ReportesDS.CarteraExigibleRPT.Rows.Add(rr)
                    End If
                    rr = ReportesDS.CarteraExigibleRPT.NewRow
                    rr._29dias = 0
                    rr._59Dias = 0
                    rr._89Dias = 0
                    rr._90Dias = 0
                    rr.Tipo = ""
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
                        rr.Tipo = ""
                        rr._29dias = 0
                        rr._59Dias = 0
                        rr._89Dias = 0
                        rr._90Dias = 0
                        rr.Total_Exigible = 0
                        rr.SaldoInsoluto = SaldoInsoluto
                        rr.Promotor = r.Iniciales_Promotor

                        ro.Tipo = ""
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
                        rr.Tipo = ""
                        rr._29dias = 0
                        rr._59Dias = 0
                        rr._89Dias = 0
                        rr._90Dias = 0
                        rr.Total_Exigible = 0
                        rr.SaldoInsoluto = SaldoInsoluto
                        rr.Promotor = r.Iniciales_Promotor

                        ro.Tipo = ""
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
                    'If My.Settings.BaseDatos.ToUpper = "PRODUCTIONE" Then 'RESPETA ESTATUS CONTABLE 
                    Aux = taAux.SacaEstatusContable(rr.Anexo.Substring(0, 5) & rr.Anexo.Substring(6, 4))
                    If Aux.ToUpper = "VENCIDA" Then
                        rr.Estatus = "Vencida"
                    End If
                    'endif
                    If ContRow = t.Rows.Count Then ' es el ultimo registro
                        ReportesDS.CarteraExigibleRPT.Rows.Add(rr)
                        If ro.Total_Exigible > 0 Then
                            ReportesDS.CarteraExigibleRPT.Rows.Add(ro)
                        End If
                    End If
                End If
                Anexo = r.AnexoCon
            Next

            'ProcesaFACTORAJE() ' FACTORAJE

            taRpt.Update(ReportesDS.CarteraExigibleRPT)
        End If

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If CmbDB.Text = "A la Fecha" Then
        Else
            taRpt.Conecciones = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
            taRpt.DeleteTipo("")
            MessageBox.Show("Terminado", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub SacaExigibleAvio()
        Dim dias As Integer
        Dim Capital As Decimal = r.Exigible ' para avio es ImporteCapital + Fega si hay trapaso en otro aso el saldo
        Dim PAGADO As Decimal = r.Otros * -1 ' contiene el Interes, dega y cap Pagado
        Dim InteresTRASP As Decimal = r.ImportetT ' contiene el interes traspasado
        Dim Aux As String
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
        'If My.Settings.BaseDatos.ToUpper = "PRODUCTIONE" Then 'RESPETA ESTATUS CONTABLE 
        Aux = taAux.SacaEstatusContable(rr.Anexo.Substring(0, 5) & rr.Anexo.Substring(6, 4))
        If Aux.ToUpper = "VENCIDA" Then
            rr.Estatus = "Vencida"
        End If
        'endif
    End Sub

    Sub ProcesaFACTORAJE()
        Dim Fecha As Date = CTOD(CmbDB.SelectedValue)
        Dim taFACTOR As New Factor100DSTableAdapters.Vw_ReporteDiarioCarteraSUMTableAdapter
        Dim FactorDS As New Factor100DS
        If CmbDB.SelectedIndex = 0 Then
            Fecha = taFACTOR.FechaMAX()
        End If

        taFACTOR.FillByVEN(FactorDS.Vw_ReporteDiarioCarteraSUM, Fecha, Date.Now.Date, 0, 59)

        For Each rx As Factor100DS.Vw_ReporteDiarioCarteraSUMRow In FactorDS.Vw_ReporteDiarioCarteraSUM.Rows
            rr = ReportesDS.CarteraExigibleRPT.NewRow
            LlenaVaciosFACTORAJE(rx)
            ReportesDS.CarteraExigibleRPT.Rows.Add(rr)
        Next

    End Sub

    Sub LlenaVaciosFACTORAJE(ByRef rx As Factor100DS.Vw_ReporteDiarioCarteraSUMRow)
        rr._29dias = 0
        rr._59Dias = 0
        rr._89Dias = 0
        rr._90Dias = 0
        rr.Tipo = ""
        rr.Total_Exigible = 0
        rr.SaldoInsoluto = 0
        rr.Promotor = "LA"
        rr.Estatus = "Exigible"
        rr.Anexo = rx.Factura
        rr.Cliente = rx.Nombre
        rr.Tipo_Credito = "FACTORAJE FINANCIERO"

        Select Case rx.Dias
            Case Is <= 30
                rr._29dias += rx.Cartera
            Case Is <= 60
                rr._59Dias += rx.Cartera
            Case Is < 90
                rr._89Dias += rx.Cartera
            Case Else
                rr._90Dias += rx.Cartera
        End Select
        rr.Total_Exigible += rx.Cartera
    End Sub

End Class