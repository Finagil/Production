Public Class FrmAgrupadorSAT
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.ContaDS.AgrupadorSAT.GetChanges()
            Me.AgrupadorSATTableAdapter.Update(Me.ContaDS.AgrupadorSAT)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmAgrupadorSAT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AgrupadorSATTableAdapter.FillByAll(Me.ContaDS.AgrupadorSAT)
    End Sub
End Class