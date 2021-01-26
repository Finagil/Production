Public Class FrmActiVaDomi
    Dim ta As New PromocionDSTableAdapters.AnexosTablaESPTableAdapter
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Dim Domi As String
            Dim Anexo As String = TxtDomi.Text
            If InStr(Anexo, "/") Then
                Anexo = Mid(Anexo, 1, InStr(Anexo, "/") - 1) & Mid(Anexo, InStr(Anexo, "/") + 1, Anexo.Length)
            End If

            If TextDomi.Text = "ACTIVADA" Then
                Domi = "N"
                Button8.Text = "ACTIVAR"
            Else
                Domi = "S"
                Button8.Text = "DESACTIVAR"
            End If

            DesBloqueaContrato(Anexo)
            ta.ActivaDomi(Domi, Anexo)
            ta.UpdateUsuarioDomi(Anexo, UsuarioGlobal)
            BloqueaContrato(Anexo)
            If Domi.ToUpper = "S" Then
                MessageBox.Show("Domiciliación Activada", "Domiciliación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Domiciliación Desactivada", "Domiciliación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            AnexosDatosDomiTableAdapter.Fill(JuridicoDS.AnexosDatosDomi, Anexo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Anexo As String = TxtDomi.Text
        If InStr(Anexo, "/") Then
            Anexo = Mid(Anexo, 1, InStr(Anexo, "/") - 1) & Mid(Anexo, InStr(Anexo, "/") + 1, Anexo.Length)
        End If
        Dim Domi As String = ta.SacaDomiciliacion(Anexo)

        If Domi.ToUpper = "X" Then
            MessageBox.Show("Contrato no encontrado", "Domiciliación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtDomi.Clear()
            Exit Sub
        Else
            Button1.Enabled = False
            Button8.Enabled = True
            TxtDomi.ReadOnly = True
            AnexosDatosDomiTableAdapter.Fill(JuridicoDS.AnexosDatosDomi, Anexo)
            If TextDomi.Text = "ACTIVADA" Then
                Button8.Text = "DESACTIVAR"
            Else
                Button8.Text = "ACTIVAR"
            End If
        End If
    End Sub
End Class