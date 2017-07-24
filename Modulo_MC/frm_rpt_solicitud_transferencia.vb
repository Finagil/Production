Public Class frm_rpt_solicitud_transferencia

    Private Sub frm_rpt_solicitud_transferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim User_Sec As New SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
        Me.Vw_MC_SOLICITUD_TRANSFERENCIATableAdapter.FillByAnexo_Fecha(Me.Solicitud_transDS.vw_MC_SOLICITUD_TRANSFERENCIA, frm_Solicitud_Transferencia.id_anexo, frm_Solicitud_Transferencia.Ciclo)
        Dim r As MesaControlDS.vw_MC_SOLICITUD_TRANSFERENCIARow
        r = Me.Solicitud_transDS.vw_MC_SOLICITUD_TRANSFERENCIA.Rows(0)
        Dim rpt As New rpt_solicitud_t
        Dim SUBDIR, FirmaDG, FirmaSUB As String
        SUBDIR = User_Sec.ScalarNombre(r.Vobo)
        FirmaDG = Encriptar(r.FechaAlta & "-Gbello")
        FirmaSUB = Encriptar(r.FechaAlta & "-" & r.Vobo.Trim)
        rpt.SetDataSource(Solicitud_transDS)
        rpt.SetParameterValue("IMPORTE", frm_Solicitud_Transferencia.IMPORTE_T)
        rpt.SetParameterValue("RECURSO", frm_Solicitud_Transferencia.recursos_fira)
        rpt.SetParameterValue("fecha", frm_Solicitud_Transferencia.fecha_p)
        rpt.SetParameterValue("TipoRecurso", frm_Solicitud_Transferencia.TipoRecurso)
        rpt.SetParameterValue("FirmaDG", FirmaDG)
        rpt.SetParameterValue("FimaSUB", FirmaSUB)
        rpt.SetParameterValue("SUB", SUBDIR)
        crv.ReportSource = rpt
    End Sub
End Class