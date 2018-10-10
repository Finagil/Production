Public Class frmRepSeguAvi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ta As New SegurosDSTableAdapters.Vw_RptSegurosAvioTableAdapter
        Dim ds As New SegurosDS
        Dim newrptRepoSegu As New RptAviosSEG

        ta.Fill(ds.Vw_RptSegurosAvio, DateTimePicker1.Value.ToString("yyyyMMdd"), DateTimePicker2.Value.ToString("yyyyMMdd"))
        newrptRepoSegu.SetDataSource(ds)
        newrptRepoSegu.SummaryInfo.ReportTitle = "Seguros de Avio Ministrados del " & DateTimePicker1.Value.ToShortDateString & " al " & DateTimePicker2.Value.ToShortDateString & "."
        CrystalReportViewer1.ReportSource = newrptRepoSegu
        CrystalReportViewer1.Visible = True
    End Sub
End Class