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


End Module
