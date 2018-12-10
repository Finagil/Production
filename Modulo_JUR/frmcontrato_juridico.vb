Public Class frmcontrato_juridico
    Dim c As String
    Private Sub frmcontrato_juridico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcliente.TextChanged
        If txtcliente.Text.Length > 4 Then
            Me.ClientesTableAdapter.select1(Me.MesaControlDS.Clientes, txtcliente.Text)

            c = cbclientes.SelectedValue
            If Not cbclientes.SelectedValue Is Nothing Then
                Me.ContratosSinDispersionTableAdapter.Fill(Me.JuridicoDS.ContratosSinDispersion, cbclientes.SelectedValue)

            End If
        End If
    End Sub


    Private Sub bt_cambiar_Click(sender As Object, e As EventArgs) Handles bt_cambiar.Click
        Me.ContratosSinDispersionTableAdapter.UpdateFechaContrato(dt_fecontrato.Value.ToString("yyyyMMdd"), cbanexos.SelectedValue)
        MessageBox.Show("Datos Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    Private Sub cbclientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbclientes.SelectedIndexChanged
        If Not cbclientes.SelectedValue Is Nothing Then
            Me.ContratosSinDispersionTableAdapter.Fill(Me.JuridicoDS.ContratosSinDispersion, cbclientes.SelectedValue)
        End If
    End Sub
End Class