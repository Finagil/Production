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
            If ContratosBindingSource.Current("Anexo").Length = 9 Then
                TextRD.Text = TaQUERY.SacaRD(ContratosBindingSource.Current("Anexo"))
                TextDG.Text = TaQUERY.SacaDG(ContratosBindingSource.Current("Anexo"))
                TextIVARD.Text = TaQUERY.SacaIvaRD(ContratosBindingSource.Current("Anexo"))
                TextIVADG.Text = TaQUERY.SacaIvaDG(ContratosBindingSource.Current("Anexo"))
            Else
                TextRD.Clear()
                TextDG.Clear()
                TextIVARD.Clear()
                TextIVADG.Clear()
            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            TaQUERY.CambiaRD(TextRD.Text, TextIVARD.Text, ContratosBindingSource.Current("Anexo"))
            MessageBox.Show("Renta en deposito Cambiada", "Cambio RD", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            TaQUERY.CambiaDG(TextDG.Text, TextIVADG.Text, ContratosBindingSource.Current("Anexo"))
            MessageBox.Show("Depósito en garantía Cambiada", "Cambio DG", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class