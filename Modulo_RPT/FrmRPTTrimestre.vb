Public Class FrmRPTTrimestre

    Private Sub FrmRPTTrimestre_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim t As New DataTable
        Dim r As DataRow
        t.Columns.Add("ID")
        t.Columns.Add("TIT")

        Dim Fecha As Date = Date.Now
        'r = t.NewRow
        'r("ID") = Date.Now.ToString("yyyyMMdd")
        'r("TIT") = "A la Fecha"
        't.Rows.Add(r)


        For x As Integer = 0 To 11
            Fecha = Fecha.AddDays(-1 * Fecha.Day)
            If Fecha >= "01/12/2018" Then
                r = t.NewRow
                r("ID") = Fecha.ToString("yyyyMMdd")
                r("TIT") = Fecha.ToString("MMM yyyy").ToUpper
                t.Rows.Add(r)
            End If
        Next
        CmbMes.DataSource = t
        CmbMes.DisplayMember = t.Columns("TIT").ToString
        CmbMes.ValueMember = t.Columns("ID").ToString
        CmbMes.SelectedIndex = 0
        CmbMes.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor.Current = Cursors.WaitCursor
        Dim rs As New ReportesDS
        Dim rpt As New RptCondusefTRI
        Dim ta As New ReportesDSTableAdapters.MezclaTOTTableAdapter
        Dim t As New ReportesDS.MezclaTOTDataTable
        Dim r As ReportesDS.MezclaTOTRow
        Dim rr As ReportesDS.RptCONDUSEFRow
        Dim tt As New ReportesDS.RptCONDUSEFDataTable

        Dim fecha1 As Date = CTOD(CmbMes.SelectedValue)
        Dim fecha2 As Date = CTOD(CmbMes.SelectedValue)
        fecha1 = fecha1.AddDays(1).AddMonths(-3)
        Dim CadMes As String = ""

        If InStr(CmbMes.Text, ".") Then
            CadMes = CmbMes.Text.Substring(0, 3) & Space(1) & CmbMes.Text.Substring(5, 4)
        Else
            CadMes = CmbMes.Text.Substring(0, 3) & Space(1) & CmbMes.Text.Substring(4, 4)
        End If

        ta.Fill(t, CadMes)
        For Each r In t.Rows
            rr = rs.RptCONDUSEF.NewRow
            rr.Tipo_de_Credito = r.TipoCredito
            rr.Moneda = "Pesos"
            rr.Monto_de_Cartera_Vigente = r.Vigente / 1000
            rr.Monto_de_cartera_Vencida = r.Vencida / 1000
            rr.Numero_de_Contratos_Vigentes = r.Contratos
            rr.Numero_de_Contratos = ta.ContratosXFecha(fecha1.ToString("yyyyMMdd"), fecha2.ToString("yyyyMMdd"), r.Tipar)
            rr.Mes = CadMes
            rs.RptCONDUSEF.Rows.Add(rr)
        Next
       
        rpt.SetDataSource(rs)
        CRViewer1.ReportSource = rpt
        Cursor.Current = Cursors.Default
    End Sub
End Class