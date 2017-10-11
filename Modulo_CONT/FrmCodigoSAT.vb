Public Class FrmCodigoSAT
    Private Sub FrmCodigoSAT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GeneralDS.ProductosFinagil' Puede moverla o quitarla según sea necesario.
        Me.ProductosFinagilTableAdapter.Fill(Me.GeneralDS.ProductosFinagil)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.GeneralDS.ProductosFinagil.GetChanges()
        Me.ProductosFinagilTableAdapter.Update(Me.GeneralDS.ProductosFinagil)
    End Sub
End Class