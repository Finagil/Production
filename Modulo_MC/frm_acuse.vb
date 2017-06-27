Public Class frm_acuse
    Public ID As Integer = 0
    Private Sub frm_acuse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim qry As New SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
        Dim r As MesaControlDS.Vw_Bitacora_anexoRow
        Me.Vw_Bitacora_anexoTableAdapter.FillByID(Me.Bitacora_anexosDS.Vw_Bitacora_anexo, ID)
        r = Bitacora_anexosDS.Vw_Bitacora_anexo.Rows(0)
        Dim rpt As New rpt_acuse()
        Dim aux As String = ""
        rpt.SetDataSource(Bitacora_anexosDS)
        rpt.SetParameterValue("DEPARTAMENTO", qry.ScalarDepto(r.Solicito.Trim))
        rpt.SetParameterValue("SOLICITO", qry.ScalarNombre(r.Solicito.Trim))

        If r.vobo.Trim <> "" Or r.vobo.Trim <> "Enviado" Then
            Dim vobo As String = qry.ScalarNombre(r.vobo.Trim)
            rpt.SetParameterValue("VOBO", vobo)
        Else
            rpt.SetParameterValue("VOBO", "")
        End If
        If r.Autoriza <> "" Or r.Autoriza <> "Enviado" Then
            Dim auto As String = qry.ScalarNombre(r.Autoriza.Trim).ToString
            rpt.SetParameterValue("AUTORIZO", auto)
        Else
            rpt.SetParameterValue("AUTORIZO", "")
        End If
        crv.ReportSource = rpt
        Cursor.Current = Cursors.Default
    End Sub

End Class