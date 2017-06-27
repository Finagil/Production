Public Class FrmRptBitacoraProm

    Private Sub FrmRptBitacoraProm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim reporte As New RptBitacoraProm
        Dim TA As New ReportesDSTableAdapters.BitacoraPromTableAdapter
        TA.Fill(ReportesDS1.BitacoraProm, "PRO")
        reporte.SetDataSource(ReportesDS1)
        CRViewer1.ReportSource = reporte
    End Sub
End Class