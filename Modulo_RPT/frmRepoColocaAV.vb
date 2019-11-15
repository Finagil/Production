Public Class frmRepoColocaAV
    Private Sub frmRepoColocaAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SucursalesTableAdapter.FillMasTodas(Me.ReportesDS.Sucursales)
        ComboSucursal.SelectedIndex = ComboSucursal.Items.Count - 1
        Dim t As New DataTable
        Dim r As DataRow
        t.Columns.Add("ID")
        t.Columns.Add("TIT")

        Dim Fecha As Date = Date.Now
        r = t.NewRow
        r("ID") = Date.Now.ToString("yyyyMMdd")
        r("TIT") = "A la Fecha"
        t.Rows.Add(r)

        For x As Integer = 0 To 11
            Fecha = Fecha.AddDays(-1 * Fecha.Day)
            If Fecha >= "01/07/2017" Then
                r = t.NewRow
                r("ID") = Fecha.ToString("yyyyMMdd")
                r("TIT") = Mid(Fecha.ToString("yyyyMMM").ToUpper, 1, 7)
                t.Rows.Add(r)
            End If
        Next
        CmbDB.DataSource = t
        CmbDB.DisplayMember = t.Columns("TIT").ToString
        CmbDB.ValueMember = t.Columns("ID").ToString
        CmbDB.SelectedIndex = 1
    End Sub

    Private Sub BtnProc_Click(sender As Object, e As EventArgs) Handles BtnProc.Click
        Cursor.Current = Cursors.WaitCursor
        Dim Suc1 As String = "00"
        Dim Suc2 As String = "99"
        If ComboSucursal.SelectedValue <> "99" Then
            Suc1 = ComboSucursal.SelectedValue
            Suc2 = ComboSucursal.SelectedValue
        End If
        Me.Sp_ColocacionAvioResumenTableAdapter.Fill(Me.ReportesDS.sp_ColocacionAvioResumen, CmbDB.SelectedValue, Suc1, Suc2)
        Me.Sp_ColocacionAvioDetalleTableAdapter.Fill(Me.ReportesDS.sp_ColocacionAvioDetalle, CmbDB.SelectedValue, Suc1, Suc2)

        Dim RptAV As New RptColocacionAvio
        RptAV.SetDataSource(Me.ReportesDS)
        Dim cad As String = CTOD(CmbDB.SelectedValue).ToString("MMMM yyyy").ToUpper
        RptAV.SetParameterValue("Mes", cad)
        CrystalReportViewer1.ReportSource = RptAV

        Cursor.Current = Cursors.WaitCursor
    End Sub

    Private Sub CmbDB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDB.SelectedIndexChanged
        DTPFecha.MaxDate = "01/01/3000"
        DTPFecha.MinDate = "01/01/1900"

        If CmbDB.SelectedIndex = 0 Then
            DTPFecha.Enabled = False
            DTPFecha.MaxDate = FECHA_APLICACION
            DTPFecha.MinDate = FECHA_APLICACION
            DTPFecha.Value = FECHA_APLICACION
        Else
            DTPFecha.Enabled = False
            DTPFecha.MaxDate = CTOD(CmbDB.SelectedValue)
            DTPFecha.MinDate = CTOD(CmbDB.SelectedValue)
            DTPFecha.Value = CTOD(CmbDB.SelectedValue)
        End If
    End Sub
End Class