Public Class FrmNoDomiciliarAviso
    Dim ta As New JuridicoDSTableAdapters.JUR_NoDomiciliarAvisoTableAdapter
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        NumerosEnteros(TextBox1, e)
    End Sub

    Private Sub FrmNoDomiciliarAviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Vw_NoDomiciliarAvisoTableAdapter.Fill(Me.JuridicoDS.Vw_NoDomiciliarAviso)
    End Sub

    Private Sub BtnADD_Click(sender As Object, e As EventArgs) Handles BtnADD.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Aviso no valido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ta.ExisteAviso(TextBox1.Text) <= 0 Then
            MessageBox.Show("el aviso no exsiste.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ta.ExisteAvisoJUR(TextBox1.Text) > 0 Then
            MessageBox.Show("el aviso ya fué agregado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ta.Insert(TextBox1.Text, UsuarioGlobal, False)
        Me.Vw_NoDomiciliarAvisoTableAdapter.Fill(Me.JuridicoDS.Vw_NoDomiciliarAviso)
        MessageBox.Show("Aviso agregado con exito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNothing(Me.VwNoDomiciliarAvisoBindingSource.Current()) Then
            If MessageBox.Show("¿Está seguro de eliminar el aviso " & Me.VwNoDomiciliarAvisoBindingSource.Current("Aviso") & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ta.UpdateAviso(UsuarioGlobal, True, Me.VwNoDomiciliarAvisoBindingSource.Current("Aviso"))
                Me.Vw_NoDomiciliarAvisoTableAdapter.Fill(Me.JuridicoDS.Vw_NoDomiciliarAviso)
            End If
        End If
    End Sub
End Class