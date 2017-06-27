Public Class FrmSelec
    Public Origen As String
    Public Destino As String

    Private Sub FrmCicloSelec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UCase(Origen) = "PAGOAVIO" Then
            CmbMovimiento.Items.Add("Pago de Avio")
            CmbMovimiento.Items.Add("Nota de crédito Avio")
        End If
        CmbMovimiento.SelectedIndex = 0
    End Sub

    Private Sub BttSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttSave.Click
        Destino = UCase(CmbMovimiento.Text)
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BttCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class