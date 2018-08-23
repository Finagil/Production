Public Class frmPagoAnticipos


    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            Me.Vw_PagosAnticipadosTableAdapter.Fill(Me.ReportesDS.Vw_PagosAnticipados, dtpFecha1.Value.ToString("yyyyMMdd"), dtpFecha2.Value.ToString("yyyyMMdd"))
            'MsgBox(dtpFecha1.Value.ToString("yyyyMMdd"))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim rpt As New rptPagosAnticipados
        rpt.SetDataSource(ReportesDS)
        rpt.SetParameterValue("var_1", dtpFecha1.Value.ToShortDateString)
        rpt.SetParameterValue("var_2", dtpFecha2.Value.ToShortDateString)
        crvPagosAnticipados.ReportSource = rpt

    End Sub
End Class