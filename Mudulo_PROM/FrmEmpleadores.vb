Public Class FrmEmpleadores
    Public r As PromocionDS.GEN_EmpleadoresRow
    Private Sub FrmEmpleadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GEN_EmpleadoresTableAdapter.Fill(Me.PromocionDS.GEN_Empleadores)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.GENEmpleadoresBindingSource.EndEdit()
            Me.GEN_EmpleadoresTableAdapter.Update(Me.PromocionDS.GEN_Empleadores)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Empleador", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not IsNothing(Me.GENEmpleadoresBindingSource.Current) Then
            Me.DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Falta seleccionar empleador.", "Empleador", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class