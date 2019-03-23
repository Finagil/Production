Public Class FrmMovimientosCONT
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.HistoriaTableAdapter.Fill(Me.ContaDS.Historia, TextAnexo.Text, TextLetra.Text, TextFecha.Text)
        Me.HisginTableAdapter.Fill(Me.ContaDS.Hisgin, TextAnexo.Text, TextFecha.Text)
        Me.FacturasTableAdapter.Fill(Me.ContaDS.Facturas, TextAnexo.Text, TextLetra.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("¿Esta seguro de guardar los cambios?", "Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Me.ContaDS.Historia.GetChanges()
                Me.HistoriaTableAdapter.Update(Me.ContaDS.Historia)
                Me.ContaDS.Hisgin.GetChanges()
                Me.HisginTableAdapter.Update(Me.ContaDS.Hisgin)
                Me.ContaDS.Facturas.GetChanges()
                Me.FacturasTableAdapter.Update(Me.ContaDS.Facturas)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


End Class