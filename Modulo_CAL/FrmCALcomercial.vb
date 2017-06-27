Public Class FrmCALComercial

    Private Sub FrmCALComercial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TACalifica As New CalificacionDSTableAdapters.CalificaComercialTableAdapter
        Dim Fecha As Date = CTOD(TACalifica.MesCalificacion)
        TACalifica.Fill(CalificacionDS.CalificaComercial)
        Dim newrptRepoSegu As New RptComercial
        newrptRepoSegu.SetDataSource(CalificacionDS)
        newrptRepoSegu.SummaryInfo.ReportTitle = "Calificaci�n de la Cartera Comercial"
        newrptRepoSegu.SetParameterValue("Titulo", "Reporte de Calificaci�n de la Cartera de Creditos Comerciales del mes de " & MonthName(Fecha.Month) & " del " & Fecha.Year)
        CrystalReportViewer1.ReportSource = newrptRepoSegu
        CrystalReportViewer1.Visible = True

    End Sub
End Class