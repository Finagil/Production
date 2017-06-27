Public Class FrmPromotores
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FrmPromotores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ConsultasDS.Promotores' Puede moverla o quitarla según sea necesario.
        Me.PromotoresTableAdapter.Fill(Me.ConsultasDS.Promotores)

    End Sub
End Class