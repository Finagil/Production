Public Class frm_rpt_consejo


    Private Sub bt_procesar_Click(sender As Object, e As EventArgs) Handles bt_procesar.Click
        Dim MesEspañol As String
        Dim MES, mes1 As Double
        ' AÑO = DateTime.Now.ToString("yyyy")
        ' MES_LETRA = Thread.CurrentThread.CurrentCulture.DateTimeFormat.MonthNames(Mes() - 1)
        Dim AÑO As String
        Dim FECHA As Date
        FECHA = dt_feini.Text
        AÑO = FECHA.ToString("yyyy")
        mes1 = FECHA.ToString("MM")
        MES = CInt(mes1)
        Select Case MES
            Case 1
                MesEspañol = "Enero"
            Case 2
                MesEspañol = "Febrero"
            Case 3
                MesEspañol = "Marzo"
            Case 4
                MesEspañol = "Abril"
            Case 5
                MesEspañol = "Mayo"
            Case 6
                MesEspañol = "Junio"
            Case 7
                MesEspañol = "Julio"
            Case 8
                MesEspañol = "Agosto"
            Case 9
                MesEspañol = "Septiembre"
            Case 10
                MesEspañol = "Octubre"
            Case 11
                MesEspañol = "Noviembre"


            Case 12
                MesEspañol = "Diciembre"
        End Select

        Dim fromDt As Date = dt_feini.Text
        Dim fechaini As String = Format(fromDt, "yyyyMMdd")
        Dim fromDt1 As Date = dt_fefin.Text
        Dim fechafin As String = Format(fromDt1, "yyyyMMdd")
        'fechaini = dt_feini.ToString("YYYY")
        'fechafin = dt_fefin.ToString("yyyyMMdd")

        Me.VW_ACTIVACIONESTableAdapter.Fill(Me.ReportesDS.VW_ACTIVACIONES, fechaini, fechafin)

        Dim r As ReportesDS.VW_ACTIVACIONESRow
        Dim TC As New ContaDSTableAdapters.TiposDeCambioTableAdapter

        Dim TipoCambio As Decimal = 1

        For Each r In Me.ReportesDS.VW_ACTIVACIONES.Rows
            If r.Moneda <> "MXN" And r.Moneda <> "MXP" Then
                TipoCambio = TC.SacaTipoCambio(fromDt1, r.Moneda)
            Else
                TipoCambio = 1
            End If
            r.MontoFinanciado = r.MontoFinanciado * TipoCambio
            r.Ivaeq = r.Ivaeq * TipoCambio
            r.Impeq = r.Impeq * TipoCambio
        Next

        Dim rpt As New rpt_consejo()

        rpt.SetDataSource(ReportesDS)
        rpt.SetParameterValue("AÑO", AÑO)
        rpt.SetParameterValue("MES", MesEspañol)
        crv.ReportSource = rpt

    End Sub
End Class