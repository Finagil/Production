Imports System.ComponentModel

Public Class FrmRetrasosJustifi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.BuroDS.RetrasosJustificados.GetChanges()
            Me.RetrasosJustificadosTableAdapter1.Update(BuroDS.RetrasosJustificados)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        RetrasosJustificadosBindingSource.Current("USUARIO") = UsuarioGlobal
    End Sub

    Private Sub FrmRetrasosJustifi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RetrasosJustificadosTableAdapter1.Fill(Me.BuroDS.RetrasosJustificados)
    End Sub
End Class