Public Class FrmCatalogos

    Private Sub FrmCatalogos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SEG_AseguradorasTableAdapter.Fill(Me.SegurosDS.SEG_Aseguradoras)
    End Sub

    Private Sub BttAltaNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttAltaNew.Click
        Try
            Me.SEG_AseguradorasTableAdapter.Update(Me.SegurosDS.SEG_Aseguradoras)
            Me.SEG_AseguradorasTableAdapter.UpdateNombre(0)
            Me.SEG_AseguradorasTableAdapter.Fill(Me.SegurosDS.SEG_Aseguradoras)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class