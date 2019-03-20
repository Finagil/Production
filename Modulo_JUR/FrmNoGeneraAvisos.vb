Public Class FrmNoGeneraAvisos
    Private Sub FrmNoGeneraAvisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VW_AnexosNoGeneraAvisosTableAdapter.Fill(Me.JuridicoDS.VW_AnexosNoGeneraAvisos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cAnexo As String = TextAnexo.Text
        cAnexo = cAnexo.Replace("/", "")
        If Me.AnexosNoGeneraAvisosTableAdapter.ExisteAnexo_Anexos(cAnexo) <= 0 Then
            MessageBox.Show("El contrato no existe.", "Anexos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.AnexosNoGeneraAvisosTableAdapter.ExisteAnexo(cAnexo) > 0 Then
            MessageBox.Show("El contrato ya está dado de alta para no generar avisos de vencimiento.", "Anexos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.AnexosNoGeneraAvisosTableAdapter.Insert(cAnexo, TextNotas.Text, Date.Now, UsuarioGlobal)
        TextAnexo.Clear()
        TextNotas.Clear()
        Me.VW_AnexosNoGeneraAvisosTableAdapter.Fill(Me.JuridicoDS.VW_AnexosNoGeneraAvisos)
    End Sub
End Class