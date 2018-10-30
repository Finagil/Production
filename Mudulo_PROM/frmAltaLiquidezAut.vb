Public Class frmAltaLiquidezAut
    Public ID_Sol2, Antiguedad As Integer

    Private Sub frmAltaLiquidezAut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PromocionDS.PROM_SolicitudesLIQ_Autorizacion' Puede moverla o quitarla según sea necesario.
        Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Fill(Me.PromocionDS.PROM_SolicitudesLIQ_Autorizacion, ID_Sol2)
        If PROM_SolicitudesLIQ_AutorizacionBindingSource.Count = 0 Then
            Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.AddNew()
            Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.Current("id_solicitud") = ID_Sol2
            Me.Validate()
            Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.EndEdit()
            Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ_Autorizacion)
            Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Fill(Me.PromocionDS.PROM_SolicitudesLIQ_Autorizacion, ID_Sol2)
        End If
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
        Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.DatosReporte(Me.PromocionDS.PROM_SolicitudesLIQ_Autorizacion, ID_Sol2)
        'Me.PromocionDS.WriteXml("E:\dtReporteAcum.xml", XmlWriteMode.WriteSchema)
        Dim rpt As New rptAltaLiquidezAutorizacion
        rpt.SetDataSource(Me.PromocionDS)
        rpt.SetParameterValue("var_antiguedad", Antiguedad)
        frmRPTAltaLiquidezAut.CrystalReportViewer1.ReportSource = rpt
        frmRPTAltaLiquidezAut.Show()

    End Sub
End Class