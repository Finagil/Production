Public Class FrmCatalogos

    Private Sub FrmCatalogos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GEN_CultivosTableAdapter.Fill(Me.SegurosDS.GEN_Cultivos)
        Me.SEG_AseguradorasTableAdapter.Fill(Me.SegurosDS.SEG_Aseguradoras)
    End Sub

    Private Sub BttAltaNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttAltaNew.Click
        Me.GEN_CultivosTableAdapter.Update(Me.SegurosDS.GEN_Cultivos)
        Me.SEG_AseguradorasTableAdapter.Update(Me.SegurosDS.SEG_Aseguradoras)
        Me.GEN_CultivosTableAdapter.UpdateNombre(0)
        Me.SEG_AseguradorasTableAdapter.UpdateNombre(0)
        Me.GEN_CultivosTableAdapter.Fill(Me.SegurosDS.GEN_Cultivos)
        Me.SEG_AseguradorasTableAdapter.Fill(Me.SegurosDS.SEG_Aseguradoras)
    End Sub
End Class