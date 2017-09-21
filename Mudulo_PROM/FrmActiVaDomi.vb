Public Class FrmActiVaDomi
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Dim Anexo As String = TxtDomi.Text
            If InStr(Anexo, "/") Then
                Anexo = Mid(Anexo, 1, InStr(Anexo, "/") - 1) & Mid(Anexo, InStr(Anexo, "/") + 1, Anexo.Length)
            End If

            Dim ta As New PromocionDSTableAdapters.AnexosTablaESPTableAdapter
            Dim Domi As String = ta.SacaDomiciliacion(Anexo)

            If Domi.ToUpper = "X" Then
                MessageBox.Show("Contrato no encontrado", "Domiciliación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Domi.ToUpper = "S" Then
                Domi = "N"
            Else
                Domi = "S"
            End If
            DesBloqueaContrato(Anexo)
            ta.ActivaDomi(Domi, Anexo)
            BloqueaContrato(Anexo)
            If Domi.ToUpper = "S" Then
                MessageBox.Show("Domiciliación Activada", "Domiciliación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Domiciliación Desactivada", "Domiciliación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class