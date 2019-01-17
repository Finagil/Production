Public Class frmAltaLiquidezAut
    Public ID_Sol2, Antiguedad As Integer
    Public Cliente As String

    Private Sub frmAltaLiquidezAut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Fill(Me.PromocionDS.PROM_SolicitudesLIQ_Autorizacion, ID_Sol2)
        If PROM_SolicitudesLIQ_AutorizacionBindingSource.Count = 0 Then
            Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.AddNew()
            Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.Current("id_solicitud") = ID_Sol2
            Me.Validate()
            Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.EndEdit()
            Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ_Autorizacion)
            Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Fill(Me.PromocionDS.PROM_SolicitudesLIQ_Autorizacion, ID_Sol2)
        End If
        If TaQUERY.EsClienteFinagil(Cliente) > 0 Then
            Cliente_finagilCheckBox.Checked = True
        Else
            Cliente_finagilCheckBox.Checked = False
        End If
        Saldo_insolutoTextBox.Text = CDec(TaQUERY.SaldoInsolutoTRA(Cliente)).ToString("n2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.EndEdit()
        Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ_Autorizacion)
    End Sub

    Private Sub Saldo_insolutoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Saldo_insolutoTextBox.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TasaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TasaTextBox.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ta As New PromocionDSTableAdapters.AutorizacionRPTTableAdapter
        ta.Fill(Me.PromocionDS.AutorizacionRPT, ID_Sol2)
        'Me.PromocionDS.WriteXml("E:\dtReporteAcum.xml", XmlWriteMode.WriteSchema)
        Dim rpt As New rptAltaLiquidezAutorizacion
        rpt.SetDataSource(Me.PromocionDS)
        rpt.SetParameterValue("var_antiguedad", Antiguedad & " años")
        rpt.SetParameterValue("Autorizo", "")
        rpt.SetParameterValue("AreaAutorizo", "DIRECCION GENERAL")
        rpt.SetParameterValue("Firma", "Autorización Automática")
        rpt.SetParameterValue("Analista", "")
        rpt.SetParameterValue("FirmaAnalista", "Autorización Automática")
        frmRPTAltaLiquidezAut.CrystalReportViewer1.ReportSource = rpt
        frmRPTAltaLiquidezAut.Show()

    End Sub
End Class