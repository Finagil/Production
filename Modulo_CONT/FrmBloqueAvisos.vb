Public Class FrmBloqueAvisos
    Private Sub FrmBloqueAvisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FondeosTableAdapter.Fill(Me.ContaDS.Fondeos)
        Me.ClientesBloqTableAdapter.Fill(Me.ContaDS.ClientesBloq)
        ComboBox3_SelectedIndexChanged_1(Nothing, Nothing)
    End Sub


    Private Sub ComboBox3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboCli.SelectedIndexChanged
        If ComboCli.SelectedIndex >= 0 Then
            Me.AnexoBloqTableAdapter.Fill(Me.ContaDS.AnexoBloq, ComboCli.SelectedValue)
            Me.FacturasBloqTableAdapter.Fill(Me.ContaDS.FacturasBloq, ComboCli.SelectedValue)
        Else
            Me.ContaDS.AnexoBloq.Clear()
            Me.ContaDS.FacturasBloq.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DesBloqueaContrato(ComboAnexo.SelectedValue)
        Me.AnexoBloqTableAdapter.Fondeo(ComboFondeo.SelectedValue, ComboAnexo.SelectedValue)
        BloqueaContrato(ComboAnexo.SelectedValue)
        MessageBox.Show("Cambio de Fondeo realizado.", "Fondeo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.FacturasBloqTableAdapter.BloqAnexo(Not CheckBox1.Checked, ComboCli.SelectedValue)
        Me.FacturasBloqTableAdapter.Fill(Me.ContaDS.FacturasBloq, ComboCli.SelectedValue)
        MessageBox.Show("Cambio de Bloqueo de avisos", "Avisos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ComboAnexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboAnexo.SelectedIndexChanged

    End Sub
End Class