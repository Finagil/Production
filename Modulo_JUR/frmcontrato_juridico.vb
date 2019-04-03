Public Class frmcontrato_juridico


    Private Sub txtcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcliente.TextChanged
        If txtcliente.Text.Length > 4 Then
            Me.ClientesTableAdapter.select1(Me.MesaControlDS.Clientes, txtcliente.Text)
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

    Private Sub ButtonAmorin_Click(sender As Object, e As EventArgs) Handles ButtonAmorin.Click
        If TextAmorin.Text = "" Then
            MessageBox.Show("El contrato no tiene Amortización Inicial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(TextAmorin.Text) <= 0 Then
            MessageBox.Show("El contrato no tiene Amortización Inicial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.ContratosSinDispersionTableAdapter.QuitaAmorin(cbanexos.SelectedValue)
        BITACORA.Insert(UsuarioGlobal, Me.Text, Date.Now, "CambioJUR", System.Environment.MachineName, Label7.Text)
        MessageBox.Show("Datos Guardados", Label7.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.ContratosSinDispersionTableAdapter.Fill(Me.JuridicoDS.ContratosSinDispersion, cbclientes.SelectedValue)

    End Sub

    Private Sub ButtonGastos_Click(sender As Object, e As EventArgs) Handles ButtonGastos.Click
        If TextGastos.Text = "" Then
            MessageBox.Show("El contrato no tiene confirurado gastos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(TextGastos.Text) <= 0 Then
            MessageBox.Show("El contrato no tiene gastos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.ContratosSinDispersionTableAdapter.QuitaAmorin(cbanexos.SelectedValue)
        BITACORA.Insert(UsuarioGlobal, Me.Text, Date.Now, "CambioJUR", System.Environment.MachineName, Label8.Text)
        MessageBox.Show("Datos Guardados", Label8.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.ContratosSinDispersionTableAdapter.Fill(Me.JuridicoDS.ContratosSinDispersion, cbclientes.SelectedValue)
    End Sub
End Class