Public Class frmcontrato_juridico
    Dim c As String
    Private Sub frmcontrato_juridico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcliente.TextChanged
        If txtcliente.Text.Length > 4 Then
            Me.ClientesTableAdapter.select1(Me.MesaControlDS.Clientes, txtcliente.Text)

            c = cbclientes.SelectedValue
            If Not cbclientes.SelectedValue Is Nothing Then
                Me.AviosTableAdapter.anexo_cliente(Me.JuridicoDS.Avios, cbclientes.SelectedValue)

            End If
        End If
    End Sub


    Private Sub bt_cambiar_Click(sender As Object, e As EventArgs) Handles bt_cambiar.Click
        Dim fechacreacion As Date
        Dim fecha As String
        fechacreacion = dt_fecontrato.Text
        fecha = fechacreacion.ToString("yyyyMMdd")
        Dim contrato As String = cbanexos.SelectedValue
        Me.AviosTableAdapter.UpdateFechaContrato(fecha, cbanexos.SelectedValue)
        MessageBox.Show("Datos Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub cbanexos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbanexos.SelectedIndexChanged

    End Sub
End Class