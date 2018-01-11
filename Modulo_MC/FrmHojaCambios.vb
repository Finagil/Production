Public Class FrmHojaCambios
    Public cAnexo As String
    Public BanSolHC As Boolean
    Private Sub FrmHojaCambios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text += cAnexo
        Me.Cambio_condicionesTableAdapter.Fill(Me.MesaControlDS.Cambio_condiciones, cAnexo)
        Button1.Enabled = BanSolHC
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CmbHoja.SelectedIndex >= 0 Then
            Dim f As New frm_cambio_condiciones
            f.IDcambio = CmbHoja.SelectedValue
            f.anexo_cambio = cAnexo
            f.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New frm_cambio_condiciones
        f.IDcambio = 0
        f.anexo_cambio = cAnexo
        If f.ShowDialog() = DialogResult.OK Then
            Me.Cambio_condicionesTableAdapter.Fill(Me.MesaControlDS.Cambio_condiciones, cAnexo)
        End If
    End Sub
End Class