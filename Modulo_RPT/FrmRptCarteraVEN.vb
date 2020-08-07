Public Class FrmRptCarteraVEN
    Public ESTATUS As String = "Global"
    Dim ProcesarTODO As Boolean = False
    Dim TC As New ContaDSTableAdapters.TiposDeCambioTableAdapter
    Dim ta As New ReportesDSTableAdapters.SP_Rpt_CarteraVencidaTableAdapter
    Dim taA As New ReportesDSTableAdapters.AvisosTableAdapter
    Dim Avi As New ReportesDS.AvisosDataTable
    Dim AA As ReportesDS.AvisosRow
    Dim t As New ReportesDS.SP_Rpt_CarteraVencidaDataTable
    Dim r As ReportesDS.SP_Rpt_CarteraVencidaRow
    Dim rr As ReportesDS.CarteraVencidaRPTRow
    Dim TAtMP As New ReportesDSTableAdapters.Tmp_CarteraTableAdapter
    Dim taRpt As New ReportesDSTableAdapters.CarteraVencidaRPTTableAdapter

    Private Sub FrmRptCarteraVEN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SucursalesTableAdapter.FillMasTodas(Me.ReportesDS.Sucursales)
        ComboSucursal.SelectedIndex = ComboSucursal.Items.Count - 1
        Me.Text = "Reporte de Cartera " & ESTATUS
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
            If Fecha >= "01/07/2017" Then
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
        Dim Suc1 As String = "00"
        Dim Suc2 As String = "99"
        Dim Suc11 As String = ""
        Dim Suc22 As String = "ZZZZZZZZZZZZZZ"
        If ComboSucursal.SelectedValue <> "99" Then
            Suc1 = ComboSucursal.SelectedValue
            Suc2 = ComboSucursal.SelectedValue
            Suc11 = ComboSucursal.Text
            Suc22 = ComboSucursal.Text
        End If
        Dim Anexo As String = ""
        Dim Status1 As String = "N"
        Dim Status2 As String = "X"
        Dim Status3 As String = "X"
        Dim DB As String = My.Settings.BaseDatos
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
        Dim OtrosX As Decimal
        Dim Aux As String
        Dim FechaAux As String
        Dim ReportesDS1 As New ReportesDS

        If CmbDB.SelectedIndex = 0 Then
            FechaAux = DTPFecha.Value.ToString("yyyyMMdd")
        Else
            FechaAux = CmbDB.SelectedValue
        End If

        Status1 = "N"
        Status2 = "S"
        Status3 = "C"
        If CmbDB.SelectedIndex <> 0 Then DB = CmbDB.Text
        ta.CommandTimeout = 180
        If CmbDB.Text = "A la Fecha" Then
            ta.Connection.ConnectionString = "Server=" & My.Settings.ServidorPROD & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
            taA.Connection.ConnectionString = "Server=" & My.Settings.ServidorPROD & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
            TC.Connection.ConnectionString = "Server=" & My.Settings.ServidorPROD & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
            TaQUERY.Connection.ConnectionString = "Server=" & My.Settings.ServidorPROD & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
            taRpt.Conecciones = "Server=" & My.Settings.ServidorPROD & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
        Else
            ta.Connection.ConnectionString = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
            taA.Connection.ConnectionString = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
            TC.Connection.ConnectionString = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
            TaQUERY.Connection.ConnectionString = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
            taRpt.Conecciones = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
        End If

        Try
            If DB.ToUpper <> My.Settings.BaseDatos.ToUpper Then
                'REVISA SI YA HAY DATOS PROCESADOS
                taRpt.Fill(ReportesDS.CarteraVencidaRPT, ESTATUS, "", "ZZZZZZZZZZZZZZZ")
                If ReportesDS.CarteraVencidaRPT.Rows.Count <= 0 Then
                    ProcesarTODO = True
                Else
                    ProcesarTODO = False
                End If

                ''reversa a los avisos de vencimiento generados del mes siguiente, para que salga correcto el saldo insoluto
                'ta.CancelaFactEDOCTA(CmbDB.SelectedValue)
                ''quita mivimientos de avio de meses posteriores
                'ta.CacelaMovAvios(CmbDB.SelectedValue)
                If ProcesarTODO = True Then
                    Dim TX As New ReportesDSTableAdapters.AvisosNoProcedentesTableAdapter
                    TX.Connection.ConnectionString = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
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
            Else
                ProcesarTODO = True
            End If
            If ProcesarTODO = True Then
                taRpt.DeleteQuery(ESTATUS)
                ta.Fill(t, FechaAux, Status1, Status2, Status3, ESTATUS.ToUpper, Suc1, Suc2)
                taRpt.Fill(ReportesDS.CarteraVencidaRPT, ESTATUS, Suc11, Suc22)
            Else
                taRpt.Fill(ReportesDS1.CarteraVencidaRPT, ESTATUS, Suc11, Suc22)
                taRpt.Fill(ReportesDS.CarteraVencidaRPT, ESTATUS, Suc11, Suc22)
            End If


            If ESTATUS = "Global" And ProcesarTODO = True Then
                TAtMP.TruncarTabla()
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la base de datos " & DB & vbCrLf & ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If ProcesarTODO Then
            For Each r In t.Rows
                ContRow += 1
                If InStr(r.AnexoCon, "05183/0001") Then
                    dias = 0
                End If
                If r.IsFevenNull Then r.Feven = FechaAux
                If r.TipoCredito = "CREDITO DE AVÍO" Or r.TipoCredito = "ANTICIPO AVÍO" Or r.TipoCredito = "CUENTA CORRIENTE" Then
                    If Anexo <> r.AnexoCon And Anexo <> "" Then
                        ReportesDS.CarteraVencidaRPT.Rows.Add(rr)
                        rr = ReportesDS.CarteraVencidaRPT.NewRow
                        LlenaVacios(rr, SaldoInsoluto, Castigo, Garantia, OtrosX)
                    End If

                    SacaExigibleAvio(FechaAux, Castigo, Garantia, OtrosX)
                    If DB.ToUpper <> "PRODUCTIONXX" Then 'RESPETA ESTATUS CONTABLE en respaldos y PRODUCTIVO
                        Aux = TaQUERY.SacaEstatusContable(rr.Anexo.Substring(0, 5) & rr.Anexo.Substring(6, 4))
                        If Aux.ToUpper = "VENCIDA" Then
                            rr.Estatus = "Vencida"
                        End If
                    End If
                    If ContRow = t.Rows.Count Then ' es el ultimo registro
                        ReportesDS.CarteraVencidaRPT.Rows.Add(rr)
                    End If
                Else
                    If Anexo = "" Then
                        rr = ReportesDS.CarteraVencidaRPT.NewRow
                        Anexo = r.AnexoCon & r.Ciclo
                        LlenaVacios(rr, SaldoInsoluto, Castigo, Garantia, OtrosX)

                        If r.Estatus = "C" And Castigo = 0 Then
                            rr.Estatus = "Castigada"
                        End If
                    End If

                    If Anexo <> r.AnexoCon Then
                        ReportesDS.CarteraVencidaRPT.Rows.Add(rr)
                        rr = ReportesDS.CarteraVencidaRPT.NewRow
                        LlenaVacios(rr, SaldoInsoluto, Castigo, Garantia, OtrosX)

                        If r.Estatus = "C" And Castigo = 0 Then
                            rr.Estatus = "Castigada"
                        End If
                        OPcion = r.Opcion
                    End If

                    rr.Anexo = r.AnexoCon
                    rr.Sucursal = r.Nombre_Sucursal
                    Aux = Mid(r.AnexoCon, 1, 5) & Mid(r.AnexoCon, 7, 4)
                    dias = DateDiff(DateInterval.Day, CTOD(r.Feven), CTOD(FechaAux))
                    Exigible = r.Exigible
                    If Exigible > 0 Then
                        PAgo = r.ImportetT - r.Exigible
                        Select Case dias
                            Case 0 To 29
                                If rr.Estatus = "Vigente" Then
                                    rr.Estatus = "Exigible"
                                End If
                            Case 30 To 89
                                If ta.EsPagoUnicoInteresMensual(Aux) = 1 Then
                                    If ta.LetrasXfacturar(Aux) = 0 Then
                                        If ta.DiasCapital(CTOD(FechaAux), Aux) >= 30 Then
                                            rr.DiasRetraso = ta.DiasCapital(CTOD(FechaAux), Aux)
                                            rr.Estatus = "Vencida"
                                        End If
                                    End If
                                End If
                                If r.TipoCredito = "ARRENDAMIENTO PURO" Or r.TipoCredito = "FULL SERVICE" Then
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

                        rr.TotalVencido += Exigible + SaldoInsoluto + OPcion - Castigo - Garantia + OtrosX
                        OPcion = 0
                        SaldoInsoluto = 0
                        Castigo = 0
                        Garantia = 0
                        OtrosX = 0
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
                    End If
                    If DB.ToUpper <> "PRODUCTIONXX" Then 'RESPETA ESTATUS CONTABLE en respaldos y PRODUCTIVO
                        Aux = TaQUERY.SacaEstatusContable(rr.Anexo.Substring(0, 5) & rr.Anexo.Substring(6, 4))
                        If Aux.ToUpper = "VENCIDA" And r.Estatus <> "C" Then
                            rr.Estatus = "Vencida"
                            If rr.DiasRetraso <= dias Then
                                rr.DiasRetraso = dias
                            End If
                        End If
                    End If
                    If ContRow = t.Rows.Count Then ' es el ultimo registro
                        ReportesDS.CarteraVencidaRPT.Rows.Add(rr)
                    End If
                End If
                Anexo = r.AnexoCon & r.Ciclo
            Next

            ProcesaFACTORAJE(DTPFecha.Value) ' FACTORAJE

            Dim EstatusAUX As String = ESTATUS
            For Each rr In ReportesDS.CarteraVencidaRPT.Rows
                If ESTATUS = "Castigada" Then
                    'NO PASA AL REPORTE
                ElseIf ESTATUS = "Reestructurada" Then
                    If rr.Reestructura = "S" Then
                        If rr.Moneda <> "MXN" And rr.Moneda <> "MXP" Then
                            AplicarTipoCambio(rr)
                        End If
                        rr.TotalVencido = rr.SaldoInsoluto + rr.SaldoOtros + rr.SaldoSeguro + rr.ProvInte + rr.RentaCapital + rr.RentaInteres + rr.RentaOtros + rr.Opcion - rr.Castigo - rr.Garantia
                        ReportesDS1.CarteraVencidaRPT.ImportRow(rr)
                    End If
                ElseIf ESTATUS = "Global" Then
                    If rr.Moneda <> "MXN" And rr.Moneda <> "MXP" Then
                        AplicarTipoCambio(rr)
                    End If
                    rr.TotalVencido = rr.SaldoInsoluto + rr.SaldoOtros + rr.SaldoSeguro + rr.ProvInte + rr.RentaCapital + rr.RentaInteres + rr.RentaOtros + rr.Opcion - rr.Castigo - rr.Garantia
                    Try
                        TAtMP.Insert(rr.Anexo.Substring(0, 5) & rr.Anexo.Substring(6, 4), rr.TotalVencido, rr.Estatus, rr.Anexo.Substring(0, 10))
                    Catch ex As Exception

                    End Try
                    ReportesDS1.CarteraVencidaRPT.ImportRow(rr)
                Else
                    If rr.Estatus = ESTATUS Then
                        If rr.Moneda <> "MXN" And rr.Moneda <> "MXP" Then
                            AplicarTipoCambio(rr)
                        End If
                        rr.TotalVencido = rr.SaldoInsoluto + rr.SaldoOtros + rr.SaldoSeguro + rr.ProvInte + rr.RentaCapital + rr.RentaInteres + rr.RentaOtros + rr.Opcion - rr.Castigo - rr.Garantia
                        ReportesDS1.CarteraVencidaRPT.ImportRow(rr)
                    End If
                End If
            Next
            taRpt.Update(ReportesDS.CarteraVencidaRPT)
        Else
            For Each xx As DataRowView In Me.CarteraVencidaRPTBindingSource
                If xx.Row("Tipo Credito") = "CREDITO DE AVÍO" Then
                    xx.Row("Cultivo") = TaQUERY.SacaCultivo(xx.Row("Anexo").Replace("/", ""))
                End If
            Next
            CarteraVencidaRPTBindingSource.EndEdit()
            ReportesDS1.CarteraVencidaRPT.AcceptChanges()

        End If

        If ESTATUS = "Global" Or ESTATUS = "Reestructurada" Then
            Dim rpt As New RptCarteraGlobal
            rpt.SetDataSource(ReportesDS1)
            rpt.SetParameterValue("titulo", ESTATUS.ToUpper & " AL " & CTOD(FechaAux).ToString("dd \DE MMMM \DEL yyyy").ToUpper)
            CRViewer.ReportSource = rpt
        Else
            Dim rpt As New RptCarteraVencida
            rpt.SetDataSource(ReportesDS1)
            rpt.SetParameterValue("titulo", ESTATUS.ToUpper & " AL " & CTOD(FechaAux).ToString("dd \DE MMMM \DEL yyyy").ToUpper)
            CRViewer.ReportSource = rpt
        End If


        Cursor.Current = Cursors.Default
        MessageBox.Show("Reporte Terminado", "Cartera", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Sub SacaExigibleAvio(FechaAux As String, ByRef Castigo As Decimal, ByRef Garantia As Decimal, ByRef OtrosX As Decimal)
        Dim dias As Integer
        Dim Capital As Decimal = r.Exigible ' para avio es ImporteCapital + Fega si hay trapaso en otro aso el saldo
        Dim GarantiaLIQ As Decimal = r.Otros 'garntia liquida de estado de cuenta
        Dim InteresTRASP As Decimal = r.ImportetT ' contiene el interes traspasado

        InteresTRASP = 0 ' Valetin no lo quiere en el reporte
        Capital -= GarantiaLIQ
        Capital += OtrosX
        rr.Sucursal = r.Nombre_Sucursal
        rr.Cliente = r.Descr
        rr.Anexo = r.AnexoCon
        rr.Cultivo = TaQUERY.SacaCultivo(r.AnexoCon.Replace("/", ""))

        If r.TipoCredito = "ANTICIPO AVÍO" Then
            rr.Tipo_Credito = "CREDITO DE AVÍO"
        Else
            rr.Tipo_Credito = r.TipoCredito
            If r.TipoCredito = "CUENTA CORRIENTE" Then
                rr.Anexo = r.AnexoCon & "-" & r.Ciclo
            End If
        End If

        dias = DateDiff(DateInterval.Day, CTOD(r.Feven), CTOD(FechaAux))

        If r.Estatus = "C" And Castigo = 0 Then
            rr.Estatus = "Castigada"
        ElseIf dias >= 30 And r.TipoCredito <> "CUENTA CORRIENTE" Then
            rr.Estatus = "Vencida"
        ElseIf dias >= 60 And r.TipoCredito = "CUENTA CORRIENTE" Then
            rr.Estatus = "Vencida"
        End If
        If dias < 0 Then
            rr.SaldoInsoluto += r.Exigible - r.Otros
            rr.SaldoOtros += r.Otros
            rr.TotalVencido += r.Exigible
        Else
            rr.RentaCapital += Capital
            rr.RentaInteres += InteresTRASP
            rr.TotalVencido += Capital - Garantia - Castigo
        End If

        If rr.DiasRetraso <= dias Then
            rr.DiasRetraso = dias
        End If

    End Sub

    Sub LlenaVacios(ByRef rr As ReportesDS.CarteraVencidaRPTRow, ByRef SaldoInsoluto As Decimal, ByRef Castigo As Decimal, ByRef Garantia As Decimal, ByRef otrosX As Decimal)
        Dim Aux As String
        rr.Moneda = r.Moneda
        rr.Cliente = r.Descr
        rr.Tipo_Credito = r.TipoCredito

        rr.ParteRelacionada = r.ParteRelacionada
        rr.Prendaria = r.Prendaria
        rr.Hipotecaria = r.Hipotecaria
        rr.GarantiaLiquida = r.GarantiaLiquida
        rr.GarantiaFega = r.GarantiaFega

        rr.Reestructura = r.Reestructura
        rr.MontoFinanciado = r.MontoFinanciado
        rr.Fondeotit = r.Fondeotit
        rr.Fondeo = r.Fondeo
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
        rr.Cultivo = ""
        rr.ActividadEconomica = r.AE_Descrip
        rr.ActividadInegi = r.actividadInegi
        rr.Giro = r.descGiro
        rr.Estatus = "Vigente"
        rr.Tipo = ESTATUS
        If DTPFecha.Value.AddDays(1).Day = 1 Then
            rr.ProvInte = r.ProvInte
        Else
            rr.ProvInte = 0
        End If

        If r.Fecha_Pago.Trim = "" Then
            rr.FechaActivacion = r.fechaCont
        Else
            rr.FechaActivacion = CTOD(r.Fecha_Pago)
        End If
        rr.FechaTerminacion = r.fechaVEN
        Aux = Mid(r.AnexoCon, 1, 5) & Mid(r.AnexoCon, 7, 4)
        If r.Aviso < 0 Then
            If r.TipoCredito <> "ARRENDAMIENTO PURO" And r.TipoCredito <> "FULL SERVICE" Then
                rr.SaldoInsoluto = ta.SaldoInsolutoCAP(Aux)
            End If
        Else
            If r.TipoCredito <> "ARRENDAMIENTO PURO" And r.TipoCredito <> "FULL SERVICE" Then
                rr.SaldoInsoluto = ta.SaldoInsolutoCAP(Aux)
            End If
        End If
        rr.SaldoSeguro = ta.SaldoInsolutoSeg(Aux)
        rr.SaldoOtros = ta.SaldoInsolutoOTR(Aux)
        Castigo = r.Castigo
        Garantia = r.Garantia
        otrosX = r.OtrosX
        rr.Castigo = r.Castigo
        rr.Garantia = r.Garantia
        If r.TipoCredito <> "ARRENDAMIENTO PURO" And r.TipoCredito <> "FULL SERVICE" Then
            SaldoInsoluto = rr.SaldoInsoluto + rr.SaldoOtros + rr.SaldoSeguro
        End If
        If InStr(r.AnexoCon, "03021/0001") And Date.Now < CDate("30/06/2018") Then
            SaldoInsoluto += 253492.05 'se agrego su renta de Diciembre 2017 Valentin Cruz
        End If

    End Sub

    Private Sub CmbDB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDB.SelectedIndexChanged
        DTPFecha.MaxDate = "01/01/3000"
        DTPFecha.MinDate = "01/01/1900"

        If CmbDB.SelectedIndex = 0 Then
            DTPFecha.Enabled = True
            DTPFecha.MaxDate = FECHA_APLICACION
            DTPFecha.MinDate = FECHA_APLICACION.AddDays(FECHA_APLICACION.Day * -1).AddDays(1)
            DTPFecha.Value = FECHA_APLICACION
        Else
            DTPFecha.Enabled = False
            DTPFecha.MaxDate = CTOD(CmbDB.SelectedValue)
            DTPFecha.MinDate = CTOD(CmbDB.SelectedValue)
            DTPFecha.Value = CTOD(CmbDB.SelectedValue)
        End If
    End Sub

    Sub AplicarTipoCambio(ByRef rr As ReportesDS.CarteraVencidaRPTRow)
        Dim TipoCambio As Decimal = 1
        TipoCambio = TC.SacaTipoCambio(DTPFecha.Value, rr.Moneda)
        rr.SaldoInsoluto = rr.SaldoInsoluto * TipoCambio
        rr.MontoFinanciado = rr.MontoFinanciado * TipoCambio
        rr.SaldoSeguro = rr.SaldoSeguro * TipoCambio
        rr.SaldoOtros = rr.SaldoOtros * TipoCambio
        rr.RentaCapital = rr.RentaCapital * TipoCambio
        rr.RentaInteres = rr.RentaInteres * TipoCambio
        rr.RentaOtros = rr.RentaOtros * TipoCambio
        rr.TotalVencido = rr.TotalVencido * TipoCambio
        rr.Castigo = rr.Castigo * TipoCambio
        rr.Garantia = rr.Garantia * TipoCambio
        rr.Opcion = rr.Opcion * TipoCambio
        rr.ProvInte = rr.ProvInte * TipoCambio
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If CmbDB.Text = "A la Fecha" Then
        Else
            taRpt.Conecciones = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
            taRpt.DeleteQuery(ESTATUS)
            MessageBox.Show("Terminado", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub ProcesaFACTORAJE(ByVal Fecha As Date)
        Dim taFACTOR As New Factor100DSTableAdapters.Vw_ReporteDiarioCarteraSUMTableAdapter
        Dim FactorDS As New Factor100DS
        If CmbDB.SelectedIndex = 0 Then
            Fecha = taFACTOR.FechaMAX()
        End If

        If ESTATUS = "Global" Then
            taFACTOR.Fill(FactorDS.Vw_ReporteDiarioCarteraSUM, Fecha)
        Else
            taFACTOR.FillByVEN(FactorDS.Vw_ReporteDiarioCarteraSUM, Fecha, DTPFecha.Value.Date, 60, 999999)
        End If

        For Each rx As Factor100DS.Vw_ReporteDiarioCarteraSUMRow In FactorDS.Vw_ReporteDiarioCarteraSUM.Rows
            rr = ReportesDS.CarteraVencidaRPT.NewRow
            LlenaVaciosFACTORAJE(rr, rx, Fecha)
            ReportesDS.CarteraVencidaRPT.Rows.Add(rr)
        Next

    End Sub

    Sub LlenaVaciosFACTORAJE(ByRef rr As ReportesDS.CarteraVencidaRPTRow, ByRef r As Factor100DS.Vw_ReporteDiarioCarteraSUMRow, ByRef Fecha As Date)
        If ESTATUS = "Global" Then
            rr.Anexo = r.Cliente
        Else
            rr.Anexo = r.Factura
        End If
        rr.DiasRetraso = r.Dias
        rr.Moneda = r.Moneda
        rr.Cliente = r.Nombre
        rr.Tipo_Credito = "FACTORAJE FINANCIERO"
        rr.Reestructura = "N"
        rr.Fondeotit = r.Fondeo
        rr.Fondeo = "01"
        rr.SaldoInsoluto = 0
        rr.SaldoSeguro = 0
        rr.SaldoOtros = 0
        rr.RentaCapital = 0
        rr.RentaInteres = 0
        rr.RentaOtros = 0
        rr.TotalVencido = 0
        rr.MontoFinanciado = 0
        rr.Castigo = 0
        rr.Garantia = r.Aforo
        rr.Opcion = 0
        rr.Cultivo = ""
        rr.ActividadEconomica = "FACTORAJE"
        rr.ActividadInegi = "FACTORAJE"
        rr.Giro = "FACTORAJE"
        If r.Dias >= 60 Then
            rr.Estatus = "Vencida"
        Else
            rr.Estatus = "Vigente"
        End If
        rr.Tipo = ESTATUS
        rr.ProvInte = r.Interes_Por_Devengar
        rr.FechaActivacion = r.Fech_Operacion
        rr.FechaTerminacion = r.Fech_Vencimiento
        rr.SaldoInsoluto = r.Cartera
        rr.SaldoSeguro = 0
        rr.SaldoOtros = 0
        rr.Sucursal = "TOLUCA"
    End Sub

    Private Sub DTPFecha_ValueChanged(sender As Object, e As EventArgs) Handles DTPFecha.ValueChanged

    End Sub
End Class