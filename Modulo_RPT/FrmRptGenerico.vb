Public Class FrmRptGnerico
    Public ReporteNom As String
    Public ID_grupo As Integer
    Public Titulo As String
    Public Cli As String
    Public Monto As Decimal
    Public MontoLetra As String
    Public InteresMes As String
    Public ComiDesc As String
    Public CAT As String
    Public DiasVenc As String
    Public ComiPorc As String
    Public ComiDisp As String
    Public Recursos As String




    Private Sub FrmRptBitacoraProm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Select Case ReporteNom
            Case "RptGR"
                Dim reporte As New RptGR
                Dim TA As New ReportesDSTableAdapters.ReporteGRTableAdapter
                TA.Fill(ReportesDS1.ReporteGR, ID_grupo)
                reporte.SetDataSource(ReportesDS1)
                reporte.SetParameterValue(0, Titulo)
                CRViewer1.ReportSource = reporte
            Case "RptRC"
                Dim reporte As New RptRC
                Dim TA As New ReportesDSTableAdapters.ReporteRCTableAdapter
                TA.Fill(ReportesDS1.ReporteRC, ID_grupo)
                reporte.SetDataSource(ReportesDS1)
                reporte.SetParameterValue(0, Titulo)
                CRViewer1.ReportSource = reporte
            Case "RptHistiCli"
                'GeneraHistoria(Cli)
            Case "RptCotCC"
                Dim reporte As New RPTCotCC
                Dim TA As New AviosDSXTableAdapters.AVI_SolicitudesCotizacionesTableAdapter
                TA.Fill(AviosDS1.AVI_SolicitudesCotizaciones, ID_grupo)
                reporte.SetDataSource(AviosDS1)
                reporte.SetParameterValue("Cliente", Titulo)
                reporte.SetParameterValue("Monto", Monto)
                reporte.SetParameterValue("Cat", cat)
                reporte.SetParameterValue("InteresMes", InteresMes)
                reporte.SetParameterValue("Comi", ComiDesc)
                reporte.SetParameterValue("Usuario", UsuarioGlobal)
                reporte.SetParameterValue("DiasVenc", DiasVenc)
                reporte.SetParameterValue("ComiPorc", ComiPorc)
                reporte.SetParameterValue("ComiDisp", ComiDisp)
                reporte.SetParameterValue("Recursos", Recursos)
                reporte.SetParameterValue("MontoLetra", MontoLetra)
                CRViewer1.ReportSource = reporte
            Case "CCporVencer"
                Dim reporte As New RPTCCporVencer
                Dim TA As New ReportesDSTableAdapters.SaldoCCTableAdapter
                TA.Fill(ReportesDS1.SaldoCC)
                reporte.SetDataSource(ReportesDS1)
                'reporte.SetParameterValue("Cliente", Titulo)                
                CRViewer1.ReportSource = reporte
            Case "AVporVencer"
                Dim reporte As New RPTAVporVencer
                Dim TA As New ReportesDSTableAdapters.SaldoAVTableAdapter
                TA.Fill(ReportesDS1.SaldoAV)
                reporte.SetDataSource(ReportesDS1)
                'reporte.SetParameterValue("Cliente", Titulo)                
                CRViewer1.ReportSource = reporte

        End Select
        Cursor.Current = Cursors.Default
    End Sub

    'Sub GeneraHistoria(ByVal Cliente As String)
    '    Dim Pagos As New ReportesDSTableAdapters.HistoriaPagosTableAdapter
    '    Dim HP As New ReportesDS.HistoriaPagosDataTable
    '    Dim TH As New ReportesDS.HistoricoCliDataTable
    '    Dim r As ReportesDS.ReporteGRRow

    '    Dim cAnexo As String
    '    Dim PrepagoImp As Double
    '    Dim PrepagoNo As Int16
    '    Dim AdelantoImp As Double
    '    Dim AdelantoNo As Int16
    '    Dim AtrasoMaxImp As Double
    '    Dim AtrasoMaxDias As Int16
    '    Dim AtrasoPromImp As Double
    '    Dim AtrasoPromDias As Int16
    '    Dim LetrasNo As Int16
    '    Dim AtrasosNo As Int16

    '    Pagos.Fill(HP, Cliente)
    '    For Each rr As ReportesDS.HistoriaPagosRow In HP.Rows

    '    Next


    'End Sub
End Class