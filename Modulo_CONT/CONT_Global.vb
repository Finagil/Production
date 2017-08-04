Module CONT_Global
    Public IVA_Interes_TasaReal As Boolean = True
    Public FECHA_APLICACION As Date = Date.Now
    Public DIAS_MENOS As Integer = 0
    Public CANCELA_MORA_DIA_FEST() As String 'Parametrizado en tabla llaves "Fecha;Domiciliacion:dias"


    Sub Genera_Trapasos_Avio(ByVal Fecha As String)
        Dim Aux As New ContaDSTableAdapters.AuxiliarTableAdapter
        Dim ta As New ContaDSTableAdapters.TraspasosAvioCCTableAdapter
        Dim t As New ContaDS.TraspasosAvioCCDataTable
        Dim R As ContaDS.TraspasosAvioCCRow
        ta.Fill(t, Fecha)
        For Each R In t.Rows
            'If R.Importe = 0 And R.Fega = 0 And R.GarantiaLiq = 0 Then
            'Continue For 'se omite ya que son INTERESES MENSUALES CUENTA CORRIENTE
            'End If
            If R.Importe + R.Intereses + R.InteresesDias + R.Fega > 0 Then
                Aux.Insert("66", R.Anexo, "", R.Importe + R.Intereses + R.InteresesDias + R.Fega, R.Tipar, "0", R.Fecha, "09", "", "Traspasos de Cartera", R.Segmento_Negocio)
            End If

            If R.Importe + R.Fega > 0 Then
                Aux.Insert("65", R.Anexo, "", R.Importe + R.Fega, R.Tipar, "1", R.Fecha, "09", "", "Traspasos de Cartera", R.Segmento_Negocio)
            End If

            If R.Intereses + R.InteresesDias > 0 Then
                Aux.Insert("72", R.Anexo, "", R.Intereses + R.InteresesDias, R.Tipar, "1", R.Fecha, "09", "", "Traspasos de Cartera", R.Segmento_Negocio)
            End If

            If R.GarantiaLiq > 0 Then
                Aux.Insert("55", R.Anexo, "", R.GarantiaLiq, R.Tipar, "1", R.Fecha, "09", "", "Traspasos de Cartera", R.Segmento_Negocio)
                Aux.Insert("67", R.Anexo, "", R.GarantiaLiq, R.Tipar, "0", R.Fecha, "09", "", "Traspasos de Cartera", R.Segmento_Negocio)
            End If
        Next
        ta.Dispose()
        Aux.Dispose()
        t.Dispose()
    End Sub

    Public Sub SacaFechaAplicacion()
        Dim ta As New ContaDSTableAdapters.FechasAplicacionTableAdapter
        Dim t As New ContaDS.FechasAplicacionDataTable
        Dim r As ContaDS.FechasAplicacionRow
        Try
            ta.Fill(t, "Vigente")
            r = t.Rows(0)
            FECHA_APLICACION = (r.Fecha)
            FECHA_APLICACION = FECHA_APLICACION.AddHours(22)
            DIAS_MENOS = DateDiff(DateInterval.Day, Date.Now, r.Fecha)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error fecha de Aplicación")
            FECHA_APLICACION = Date.Now.ToShortDateString
            FECHA_APLICACION = FECHA_APLICACION.AddHours(22)
        Finally
            ta.Dispose()
            t.Dispose()
        End Try
    End Sub

    Public Sub CambiaFechaAplicacion()
        Dim ta As New ContaDSTableAdapters.FechasAplicacionTableAdapter
        Dim t As New ContaDS.FechasAplicacionDataTable
        Dim r As ContaDS.FechasAplicacionRow
        Dim FechaVigente As Date
        Try
            ta.Fill(t, "Vigente")
            r = t.Rows(0)
            FechaVigente = r.Fecha
            ta.Update(FechaVigente, "Cerrado", FechaVigente, "Vigente")
            FechaVigente = FechaVigente.AddDays(1)
            If FechaVigente.DayOfWeek = DayOfWeek.Saturday Then FechaVigente = FechaVigente.AddDays(1)
            If FechaVigente.DayOfWeek = DayOfWeek.Sunday Then FechaVigente = FechaVigente.AddDays(1)
            ta.Insert(FechaVigente, "Vigente")
            FECHA_APLICACION = FechaVigente
            FECHA_APLICACION = FECHA_APLICACION.AddHours(22)
            DIAS_MENOS = DateDiff(DateInterval.Day, Date.Now, FECHA_APLICACION)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error fecha de Aplicación")
            FECHA_APLICACION = Date.Now.ToShortDateString
            FECHA_APLICACION = FECHA_APLICACION.AddHours(22)
        Finally
            ta.Dispose()
            t.Dispose()
        End Try
    End Sub

    Sub Genera_Trapasos_Vencida(ByVal Fecha As String)
        Dim TipoMov As String = "21"
        Dim Aux As New ContaDSTableAdapters.AuxiliarTableAdapter
        Dim ta As New ContaDSTableAdapters.TraspasosVencidosTableAdapter
        Dim t As New ContaDS.TraspasosVencidosDataTable
        Dim R As ContaDS.TraspasosVencidosRow
        ta.Fill(t, CTOD(Fecha).Year, CTOD(Fecha).Month)
        For Each R In t.Rows
            If R.Tipar = "F" Or R.Tipar = "R" Or R.Tipar = "S" Then
                Select Case R.Tipar
                    Case "F"
                        Aux.Insert("06", R.Anexo, "", R.SaldoInsoluto + R.CargaFinanciera, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                        Aux.Insert("07", R.Anexo, "", R.CargaFinanciera, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                    Case "R"
                        Aux.Insert("45", R.Anexo, "", R.SaldoInsoluto + R.CargaFinanciera, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                        Aux.Insert("46", R.Anexo, "", R.CargaFinanciera, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                    Case "S"
                        Aux.Insert("55", R.Anexo, "", R.SaldoInsoluto + R.CargaFinanciera, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                        Aux.Insert("59", R.Anexo, "", R.CargaFinanciera, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                End Select
                Aux.Insert("V01", R.Anexo, "", R.SaldoInsoluto, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

                Aux.Insert("28", R.Anexo, "", R.SaldoInsolutoSEG, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V01", R.Anexo, "", R.SaldoInsolutoSEG, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

                Aux.Insert("55", R.Anexo, "", R.SaldoInsolutoOTR + R.CargaFinancieraOTR, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("59", R.Anexo, "", R.CargaFinancieraOTR, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V01", R.Anexo, "", R.SaldoInsolutoOTR, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

                Select Case R.Tipar
                    Case "F"
                        Aux.Insert("03", R.Anexo, "", R.CapitalVencido + R.InteresVencido, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                    Case "R"
                        Aux.Insert("50", R.Anexo, "", R.CapitalVencido + R.InteresVencido, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                    Case "S"
                        Aux.Insert("56", R.Anexo, "", R.CapitalVencido + R.InteresVencido, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                End Select

                Aux.Insert("56", R.Anexo, "", R.CapitalVencidoOt + R.InteresVencidoOt, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V02", R.Anexo, "", R.CapitalVencido + R.CapitalVencidoOt, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V03", R.Anexo, "", R.InteresVencido + R.InteresVencidoOt, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V04", R.Anexo, "", R.IvaCapital, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

            ElseIf R.Tipar = "C" Or R.Tipar = "A" Or R.Tipar = "H" Then
                Aux.Insert("55", R.Anexo, "", R.CapitalVencido + R.InteresVencido, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("59", R.Anexo, "", R.CapitalVencido, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V01", R.Anexo, "", R.InteresVencido, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

            ElseIf R.Tipar = "P" Then
                Aux.Insert("03", R.Anexo, "", R.CapitalVencido + R.InteresVencido + R.IvaCapital + R.CargaFinancieraSEG, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("06", R.Anexo, "", R.CapitalVencido + R.InteresVencido + R.IvaCapital, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("28", R.Anexo, "", R.SaldoInsolutoSEG, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V01", R.Anexo, "", R.SaldoInsolutoSEG, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

                Aux.Insert("55", R.Anexo, "", R.SaldoInsolutoOTR + R.CargaFinancieraOTR, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("59", R.Anexo, "", R.CargaFinancieraOTR, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V01", R.Anexo, "", R.SaldoInsolutoOTR, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

                Aux.Insert("V03", R.Anexo, "", R.InteresVencidoOt + R.CargaFinancieraSEG, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("56", R.Anexo, "", R.CapitalVencidoOt + R.InteresVencidoOt, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V02", R.Anexo, "", R.CapitalVencidoOt, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

            ElseIf R.Tipar = "B" Then
                Aux.Insert("11", R.Anexo, "", R.CapitalVencido + R.IvaCapital, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V08", R.Anexo, "", R.CapitalVencido + R.IvaCapital, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

            End If
        Next
        Aux.DeleteCeros(TipoMov)
        ta.Dispose()
        Aux.Dispose()
        t.Dispose()
    End Sub

End Module
