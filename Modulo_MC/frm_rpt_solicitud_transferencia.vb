Public Class frm_rpt_solicitud_transferencia

    Private Sub frm_rpt_solicitud_transferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Vw_MC_SOLICITUD_TRANSFERENCIATableAdapter.FillByAnexo_Fecha(Me.Solicitud_transDS.vw_MC_SOLICITUD_TRANSFERENCIA, frm_Solicitud_Transferencia.id_anexo, frm_Solicitud_Transferencia.fechapago)
        Me.Vw_MC_SOLICITUD_TRANSFERENCIATableAdapter.FillByAnexo_Fecha(Me.Solicitud_transDS.vw_MC_SOLICITUD_TRANSFERENCIA, frm_Solicitud_Transferencia.id_anexo, frm_Solicitud_Transferencia.Ciclo)
        Dim rpt As New rpt_solicitud_t
        rpt.SetDataSource(Solicitud_transDS)
        rpt.SetParameterValue("IMPORTE", frm_Solicitud_Transferencia.IMPORTE_T)
        rpt.SetParameterValue("RECURSO", frm_Solicitud_Transferencia.recursos_fira)
        rpt.SetParameterValue("fecha", frm_Solicitud_Transferencia.fecha_p)
        rpt.SetParameterValue("TipoRecurso", frm_Solicitud_Transferencia.TipoRecurso)
        crv.ReportSource = rpt
    End Sub
End Class