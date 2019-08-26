Public Class FrmActividadInegi
    Public id As Integer = 1
    Private Sub FrmActividadInegi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GEN_ActividadInegiTableAdapter.Fill(Me.PromocionDS.GEN_ActividadInegi)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        id = ComboBox1.SelectedValue
        DialogResult = DialogResult.OK
    End Sub
End Class