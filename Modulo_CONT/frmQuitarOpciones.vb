Public Class frmQuitarOpciones
    Private Sub txtcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcliente.TextChanged
        If txtcliente.Text.Length > 4 Then
            Me.ClientesTableAdapter.select1(Me.MesaControlDS.Clientes, txtcliente.Text)
            If Not cbclientes.SelectedValue Is Nothing Then
                Me.ContratosSinDispersionTableAdapter.FillBy_ACT_TERM(Me.JuridicoDS.ContratosSinDispersion, cbclientes.SelectedValue)
            End If
        End If
    End Sub

    Private Sub cbclientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbclientes.SelectedIndexChanged
        If Not cbclientes.SelectedValue Is Nothing Then
            Me.ContratosSinDispersionTableAdapter.FillBy_ACT_TERM(Me.JuridicoDS.ContratosSinDispersion, cbclientes.SelectedValue)
        End If
    End Sub

    Private Sub ButtonOP_Click(sender As Object, e As EventArgs) Handles ButtonOP.Click
        Me.ContratosSinDispersionTableAdapter.QuitaOpcion(cbanexos.SelectedValue)
        BITACORA.Insert(UsuarioGlobal, Me.Name, Date.Now, "CambioCONT", System.Environment.MachineName, Label8.Text)
        MessageBox.Show("Datos Guardados", Label8.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.ContratosSinDispersionTableAdapter.FillBy_ACT_TERM(Me.JuridicoDS.ContratosSinDispersion, cbclientes.SelectedValue)
    End Sub

    Private Sub ContratosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ContratosBindingSource.CurrentChanged
        If Not IsNothing(ContratosBindingSource.Current) Then
            If ContratosBindingSource.Current("PAGADO") = "N" Then
                ButtonOP.Enabled = True
            Else
                ButtonOP.Enabled = False
            End If
        End If
    End Sub
End Class