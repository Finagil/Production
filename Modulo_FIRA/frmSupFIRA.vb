Public Class frmSupFIRA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            Me.FechasSupervisionTableAdapter.Fill(Me.ReportesDS.FechasSupervision, New System.Nullable(Of Date)(CType(dtpFechaInicio.Text, Date)), New System.Nullable(Of Date)(CType(dtpFechaFin.Text, Date)))
            Dim rpt As New rptSupFIRA
            rpt.SetDataSource(ReportesDS)
            rpt.SetParameterValue("fecha_inicio", dtpFechaInicio.Value.ToShortDateString)
            rpt.SetParameterValue("fecha_fin", dtpFechaFin.Value.ToShortDateString)
            Me.CrystalReportViewer1.ReportSource = rpt

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class