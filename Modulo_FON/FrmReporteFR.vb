Public Class FrmReporteFR

    Private Sub FrmReporteFR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim reporte As New RptSaldoFondo
        Dim TA As New FondoResarvaDSTableAdapters.Vw_FON_RptFondoTableAdapter
        TA.Fill(FondoResarvaDS1.Vw_FON_RptFondo)
        reporte.SetDataSource(FondoResarvaDS1)
        ReportViewerFondo.ReportSource = reporte
    End Sub
End Class