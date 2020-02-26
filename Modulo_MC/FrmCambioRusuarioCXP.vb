Public Class FrmCambioRusuarioCXP
    Private Sub FrmCambioRusuarioCXP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GEN_CorreosFasesMCTableAdapter.Fill(Me.MesaControlDS.GEN_CorreosFasesMC)
        Me.UsuariosFinagilTableAdapter.FillByDepto(Me.SeguridadDS.UsuariosFinagil, "MESA DE CONTROL")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("¿Está seguro de cambiar el usuario a " & ComboBox1.Text & "?", "Usuario para Autorizaciones CXP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.GEN_CorreosFasesMCTableAdapter.UpdateMCONTROL_CXP(UsuariosFinagilBindingSource.Current("NombreCompleto").ToString.Trim & "  (Finagil) <" & UsuariosFinagilBindingSource.Current("Correo") & ">", UsuariosFinagilBindingSource.Current("NombreCompleto"), 0)
            MessageBox.Show("Cambio Realizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.GEN_CorreosFasesMCTableAdapter.Fill(Me.MesaControlDS.GEN_CorreosFasesMC)
        End If
    End Sub
End Class