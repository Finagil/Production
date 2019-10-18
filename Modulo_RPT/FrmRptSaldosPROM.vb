Public Class FrmRptSaldosPROM
    Dim ta As New ReportesDSTableAdapters.Vw_AnexosSaldosPromedioTableAdapter
    Dim taAux As New GeneralDSTableAdapters.QueryVariosTableAdapter
    Dim t As New ReportesDS.Vw_AnexosSaldosPromedioDataTable
    Dim r As ReportesDS.Vw_AnexosSaldosPromedioRow
    Dim rr, ro As ReportesDS.RPT_SaldosPromedioRow
    Dim taRpt As New ReportesDSTableAdapters.RPT_SaldosPromedioTableAdapter
    Dim TC As New ContaDSTableAdapters.TiposDeCambioTableAdapter
    Dim FechaProc As Date
    Dim FechaMes As Date

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
        Dim DB As String = My.Settings.BaseDatos
        Dim Aux As String = ""

        If CmbDB.SelectedIndex <> 0 Then DB = CmbDB.Text
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
                taRpt.Fill(ReportesDS.RPT_SaldosPromedio)
                If ReportesDS.RPT_SaldosPromedio.Rows.Count <= 0 Then
                    taRpt.DeleteAll()
                    ProcesaTODO = True
                Else
                    ProcesaTODO = False
                End If
            End If
            If ProcesaTODO = True Then
                Aux = Mid(CmbDB.SelectedValue, 1, 6)
                FechaProc = CTOD(Aux & "01")
                FechaMes = CTOD(Aux & "01")
            Else
                taRpt.Fill(ReportesDS.RPT_SaldosPromedio)
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la base de datos " & DB & vbCrLf & ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Dim dv As New DataView(t)
        'dv.Sort = "AnexoCon"
        't = dv.ToTable
        If ProcesaTODO = True Then
            ProgressBar1.Value = 0
            ProgressBar1.Visible = True
            ProgressBar1.Minimum = 0
            ProgressBar1.Step = 1

            ta.Fill(Me.ReportesDS.Vw_AnexosSaldosPromedio, Aux & "01", Aux & "31")
            ProgressBar1.Maximum = ReportesDS.Vw_AnexosSaldosPromedio.Rows.Count
            CargaDatos(False)
            ta.FillByCanceladosMES(Me.ReportesDS.Vw_AnexosSaldosPromedio, Aux & "01", Aux & "31")
            ProgressBar1.Maximum += ReportesDS.Vw_AnexosSaldosPromedio.Rows.Count
            CargaDatos(True)
            taRpt.Update(ReportesDS.RPT_SaldosPromedio)
            ProgressBar1.Visible = False
        End If

        Dim rpt As New RptSaldosPromedio
        rpt.SetDataSource(ReportesDS)
        rpt.SetParameterValue("Mes", CTOD(CmbDB.SelectedValue).ToString("MMMM \DEL yyyy").ToUpper)
        CRViewer.ReportSource = rpt
        Cursor.Current = Cursors.Default
        MessageBox.Show("Reporte Terminado", "Saldos Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If CmbDB.Text = "A la Fecha" Then
        Else
            taRpt.Conecciones = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
            taRpt.DeleteAll()
            MessageBox.Show("Terminado", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub CargaDatos(Cancelados As Boolean)
        Dim Fecha As Date = CTOD(CmbDB.SelectedValue)
        Dim AcumCAP As Decimal = 0
        Dim AcumSEG As Decimal = 0
        Dim AcumOTR As Decimal = 0
        Dim TipoCambio As Decimal = 0
        Dim Contador As Integer = 0
        Dim CAP As Object
        Dim SEG As Object
        Dim OTR As Object
        Dim FecUltPAgo As Date = Today

        For Each r In Me.ReportesDS.Vw_AnexosSaldosPromedio.Rows
            rr = ReportesDS.RPT_SaldosPromedio.NewRPT_SaldosPromedioRow
            rr.Anexo = r.Anexo
            rr.Ciclo_Pagare = r.CicloPagare
            rr.Cliente = r.Cliente.Trim
            rr.FechaContrato = r.Fecha_Contrato
            If r.Tipar = "H" Or r.Tipar = "A" Or r.Tipar = "C" Then
                If taRpt.NoMovimientosAV(r.AnexoSin, r.Ciclo) <= 0 Then
                    ProgressBar1.PerformStep()
                    Continue For 'se lo salta si no tiene movimientos de AV
                End If
                rr.Fecha_de_Pago = CTOD(taRpt.FechaPagoAV(r.AnexoSin, r.Ciclo))
            Else
                rr.Fecha_de_Pago = r.Fecha_Pago
            End If
            rr.Fecha_Terminacion = r.Fecha_Terminacion
            If InStr(r.Tipo_Tasa, "FIJA") Then
                rr.Tipo_Tasa = "F"
            Else
                rr.Tipo_Tasa = "V"
            End If
            rr.Tasa_Diff = r.Tasa
            rr.Tipo_Persona = r.Tipo_Persona
            rr.Tipo_Credito = r.Tipo_Credito
            rr.Sucursal = r.Sucursal
            If r.Estatus.ToLower = "terminado c/saldo" Then
                rr.Estatus = "Termiando"
            Else
                rr.Estatus = r.Estatus
            End If
            TipoCambio = TC.SacaTipoCambio(Fecha, r.Moneda)
            rr.Monto_Financiado = r.MontoFinanciado * TipoCambio
            'CALCULA PROMEDIO++++++++++++++++++++++++++++++++++++
            FechaProc = FechaMes
            Contador = 0
            AcumCAP = 0
            AcumSEG = 0
            AcumOTR = 0
            If Cancelados = True Then
                FecUltPAgo = CTOD(TaQUERY.UltimoPago(r.AnexoSin))
            End If
            While FechaProc.Month = FechaMes.Month
                Contador += 1
                If r.Tipar = "H" Or r.Tipar = "A" Or r.Tipar = "C" Then
                    CAP = taRpt.SaldoFechaAV(r.Ciclo, r.AnexoSin, FechaProc.ToString("yyyyMMdd")) * TipoCambio
                    SEG = 0
                    OTR = 0
                Else
                    CAP = taRpt.SaldoFechaCAP(r.AnexoSin, FechaProc.ToString("yyyyMMdd")) * TipoCambio
                    SEG = taRpt.SaldoFechaSEG(r.AnexoSin, FechaProc.ToString("yyyyMMdd")) * TipoCambio
                    OTR = taRpt.SaldoFechaOTR(r.AnexoSin, FechaProc.ToString("yyyyMMdd")) * TipoCambio
                    If Cancelados = True Then
                        If FecUltPAgo <= FechaProc Then
                            CAP = 0
                            SEG = 0
                            OTR = 0
                        End If
                    Else
                        If r.Fecha_Pago > FechaProc Then
                            CAP = 0
                            SEG = 0
                            OTR = 0
                        End If
                    End If
                End If
                If IsNothing(CAP) Then CAP = 0
                If IsNothing(SEG) Then SEG = 0
                If IsNothing(OTR) Then OTR = 0
                AcumCAP += CAP
                AcumSEG += SEG
                AcumOTR += OTR
                FechaProc = FechaProc.AddDays(1)
            End While
            rr.Saldo_al_Cierre = CAP
            rr.Saldo_Promedio = AcumCAP / Contador
            rr.Saldo_Promedio_Seguro = AcumSEG / Contador
            rr.Saldo_Promedio_Otros = AcumOTR / Contador
            'CALCULA PROMEDIO++++++++++++++++++++++++++++++++++++
            ReportesDS.RPT_SaldosPromedio.AddRPT_SaldosPromedioRow(rr)
            ProgressBar1.PerformStep()
        Next
    End Sub

End Class