

Public Class FrmValidaHojaTasa

    Private Sub Txtfirma_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfirma.TextChanged
        If Txtfirma.Text.Length >= 2 Then
            Me.HojaTasaTableAdapter.Fill(MesaControlDS.HojaTasa, "%" & Txtfirma.Text.Trim & "%")
        Else
            MesaControlDS.HojaTasa.Clear()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListHojas.SelectedIndex >= 0 Then
            DOC_HojaCambioTasa.SacaHojaCambioTasa(ListHojas.Text)
        Else
            MessageBox.Show("no hay Contrato Selecionado", "Selecciona Contrato", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ListHojas.Focus()
        End If
    End Sub
End Class