Public Class FrmCarteraVencidaMonitor
    Private Sub FrmCarteraVencidaMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        DtpFecha.MinDate = FECHA_APLICACION
        DtpFecha.Value = FECHA_APLICACION
        DtpFecha.MaxDate = FECHA_APLICACION.AddMonths(1).AddDays(FECHA_APLICACION.Day * -1)
        Llena_Grid()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub DtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles DtpFecha.ValueChanged
        Cursor.Current = Cursors.WaitCursor
        Llena_Grid()
        Cursor.Current = Cursors.Default
    End Sub

    Sub Llena_Grid()
        Dim TipoCredito As String
        Dim X As Integer
        ConsultasDS.Monitor_Cartera_Vencida.Clear()
        Me.Monitor_Cartera_VencidaTableAdapter.Fill(ConsultasDS.Monitor_Cartera_Vencida, DtpFecha.Value.Date)
        Me.MonitorCarteraVencidaBindingSource.Sort = "Dias desc"

        For Each r As ConsultasDS.Monitor_Cartera_VencidaRow In ConsultasDS.Monitor_Cartera_Vencida.Rows
            If r.Dias < 0 Then
                r.Estatus = "VIGENTE"
                r.Orden = 4
            Else
                r.Estatus = "EXIGIBLE"
                r.Orden = 3
            End If
            Select Case r.TipoCredito.Trim
                Case "ANTICIPO AVÍO", "CREDITO DE AVÍO"
                    r.FechaTraspaso = r.FechaTraspaso.AddDays(30)
                    If r.Dias >= 30 Then
                        r.Estatus = "VENCIDA"
                        r.Orden = 1
                    ElseIf r.Dias <= 29 And r.Dias >= 20 Then
                        r.Orden = 2
                    End If
                Case "FULL SERVICE", "ARRENDAMIENTO PURO"
                    r.FechaTraspaso = r.FechaTraspaso.AddDays(30)
                    If r.Dias >= 30 Then
                        r.Estatus = "VENCIDA"
                        r.Orden = 1
                    ElseIf r.Dias <= 29 And r.Dias >= 20 Then
                        r.Orden = 2
                    End If
                Case "CUENTA CORRIENTE"
                    r.FechaTraspaso = r.FechaTraspaso.AddDays(60)
                    If r.Dias >= 60 Then
                        r.Estatus = "VENCIDA"
                        r.Orden = 1
                    ElseIf r.Dias <= 59 And r.Dias >= 40 Then
                        r.Orden = 2
                    End If
                Case "ARRENDAMIENTO FINANCIERO", "CREDITO REFACCIONARIO", "CREDITO SIMPLE", "CREDITO LIQUIDEZ INMEDIATA"
                    r.FechaTraspaso = r.FechaTraspaso.AddDays(90)
                    If Me.Monitor_Cartera_VencidaTableAdapter.EsPagoUnicoInteresMensual(r.AnexoCon.Replace("/", "")) = 1 Then
                        If Me.Monitor_Cartera_VencidaTableAdapter.LetrasXfacturar(r.AnexoCon.Replace("/", "")) = 0 And r.Dias < 90 Then
                            r.FechaTraspaso = r.FechaTraspaso.AddDays(30)
                            Dim Fec As Date = TaQUERY.FechaTerminacion(r.AnexoCon.Replace("/", ""))
                            r.FechaTraspaso = Fec.AddDays(30)
                            r.Dias = DateDiff(DateInterval.Day, Fec, DtpFecha.Value.Date)
                            If r.Dias >= 30 Then
                                r.Estatus = "VENCIDA"
                                r.Orden = 1
                            Else
                                r.Orden = 2
                            End If
                        Else
                            If r.Dias >= 90 Then
                                r.Estatus = "VENCIDA"
                                r.Orden = 1
                            ElseIf r.Dias <= 89 And r.Dias >= 60 Then
                                r.Orden = 2
                            End If
                        End If
                    Else
                        If r.Dias >= 90 Then
                            r.Estatus = "VENCIDA"
                            r.Orden = 1
                        ElseIf r.Dias <= 89 And r.Dias >= 60 Then
                            r.Orden = 2
                        End If
                    End If

            End Select
            X += 1
        Next
        Me.MonitorCarteraVencidaBindingSource.Sort = "orden asc, dias desc"
        For Each r As DataGridViewRow In GridCartera.Rows
            r.DefaultCellStyle.BackColor = Color.Green
            r.DefaultCellStyle.ForeColor = Color.White
            TipoCredito = r.Cells("TipoCreditoDataGridViewTextBoxColumn").Value
            Select Case TipoCredito
                Case "ANTICIPO AVÍO", "CREDITO DE AVÍO"
                    If r.Cells("DiasDataGridViewTextBoxColumn").Value >= 30 Then
                        r.DefaultCellStyle.BackColor = Color.Red
                    ElseIf r.Cells("DiasDataGridViewTextBoxColumn").Value <= 29 And r.Cells("DiasDataGridViewTextBoxColumn").Value >= 20 Then
                        r.DefaultCellStyle.BackColor = Color.Yellow
                        r.DefaultCellStyle.ForeColor = Color.Black
                    End If
                Case "FULL SERVICE"
                    If r.Cells("DiasDataGridViewTextBoxColumn").Value >= 30 Then
                        r.DefaultCellStyle.BackColor = Color.Red
                    ElseIf r.Cells("DiasDataGridViewTextBoxColumn").Value <= 29 And r.Cells("DiasDataGridViewTextBoxColumn").Value >= 20 Then
                        r.DefaultCellStyle.BackColor = Color.Yellow
                        r.DefaultCellStyle.ForeColor = Color.Black
                    End If
                Case "CUENTA CORRIENTE"
                    If r.Cells("DiasDataGridViewTextBoxColumn").Value >= 60 Then
                        r.DefaultCellStyle.BackColor = Color.Red
                    ElseIf r.Cells("DiasDataGridViewTextBoxColumn").Value <= 59 And r.Cells("DiasDataGridViewTextBoxColumn").Value >= 40 Then
                        r.DefaultCellStyle.BackColor = Color.Yellow
                        r.DefaultCellStyle.ForeColor = Color.Black
                    End If
                Case "ARRENDAMIENTO FINANCIERO", "CREDITO REFACCIONARIO", "CREDITO SIMPLE", "CREDITO LIQUIDEZ INMEDIATA"
                    If Me.Monitor_Cartera_VencidaTableAdapter.EsPagoUnicoInteresMensual(r.Cells("AnexoConDataGridViewTextBoxColumn").Value.Replace("/", "")) = 1 Then
                        If Me.Monitor_Cartera_VencidaTableAdapter.LetrasXfacturar(r.Cells("AnexoConDataGridViewTextBoxColumn").Value.Replace("/", "")) = 0 And
                            r.Cells("DiasDataGridViewTextBoxColumn").Value < 90 Then
                            If r.Cells("DiasDataGridViewTextBoxColumn").Value >= 30 Then
                                r.DefaultCellStyle.BackColor = Color.Red
                            ElseIf r.Cells("DiasDataGridViewTextBoxColumn").Value <= 29 And r.Cells("DiasDataGridViewTextBoxColumn").Value >= 20 Then
                                r.DefaultCellStyle.BackColor = Color.Yellow
                                r.DefaultCellStyle.ForeColor = Color.Black
                            End If
                        Else
                            If r.Cells("DiasDataGridViewTextBoxColumn").Value >= 90 Then
                                r.DefaultCellStyle.BackColor = Color.Red
                            ElseIf r.Cells("DiasDataGridViewTextBoxColumn").Value <= 89 And r.Cells("DiasDataGridViewTextBoxColumn").Value >= 60 Then
                                r.DefaultCellStyle.BackColor = Color.Yellow
                                r.DefaultCellStyle.ForeColor = Color.Black
                            End If
                        End If
                    Else
                        If r.Cells("DiasDataGridViewTextBoxColumn").Value >= 90 Then
                            r.DefaultCellStyle.BackColor = Color.Red
                        ElseIf r.Cells("DiasDataGridViewTextBoxColumn").Value <= 89 And r.Cells("DiasDataGridViewTextBoxColumn").Value >= 60 Then
                            r.DefaultCellStyle.BackColor = Color.Yellow
                            r.DefaultCellStyle.ForeColor = Color.Black
                        End If
                    End If

                Case "ARRENDAMIENTO PURO"
                    If r.Cells("DiasDataGridViewTextBoxColumn").Value >= 30 Then
                        r.DefaultCellStyle.BackColor = Color.Red
                    ElseIf r.Cells("DiasDataGridViewTextBoxColumn").Value <= 29 And r.Cells("DiasDataGridViewTextBoxColumn").Value >= 20 Then
                        r.DefaultCellStyle.BackColor = Color.Yellow
                        r.DefaultCellStyle.ForeColor = Color.Black
                    End If
            End Select
        Next
    End Sub
End Class