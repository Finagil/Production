Public Class FrmPrendariaSEG
    Public cAnexo As String

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        Me.PrendaBindingSource.AddNew()
        Me.PrendaBindingSource.Current("IDPrenda") = ((Date.Now.Hour * 1000) + (Date.Now.Hour * 100) + (Date.Now.Hour * 10)) + -1
        Me.PrendaBindingSource.Current("Anexo") = cAnexo
        Me.PrendaBindingSource.Current("Seguro") = cAnexo
        Me.PrendaBindingSource.Current("ValorGar") = 0
        Me.PrendaBindingSource.Current("Prenda") = ""
        Me.PrendaBindingSource.EndEdit()
        Me.PrendaBindingSource.MoveLast()
    End Sub

    Private Sub ButtonDEL_Click(sender As Object, e As EventArgs) Handles ButtonDEL.Click
        If Not IsNothing(Me.PrendaBindingSource.Current()) Then
            If MessageBox.Show("¿Esta seguro de Borrar la garantia?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.PrendaBindingSource.RemoveCurrent()
                Me.PrendaBindingSource.EndEdit()
                Me.PromocionDS.Prenda.GetChanges()
                Me.PrendaTableAdapter.Update(PromocionDS.Prenda)
            End If
        Else
            MessageBox.Show("No hay elemento selecionado para Borrar", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonEXIT_Click(sender As Object, e As EventArgs) Handles ButtonEXIT.Click
        Me.Close()
    End Sub

    Private Sub ButtonSAVE_Click(sender As Object, e As EventArgs) Handles ButtonSAVE.Click
        Me.PrendaBindingSource.EndEdit()
        Me.PromocionDS.Prenda.GetChanges()
        Me.PrendaTableAdapter.Update(PromocionDS.Prenda)
    End Sub

    Private Sub FrmPrendariaSEG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PrendaTableAdapter.Fill(PromocionDS.Prenda, cAnexo)
    End Sub
End Class