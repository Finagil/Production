Public Class FrmPAGOSelec
    Public Ciclo As String
    Public CicloDSC As String
    Private Sub FrmCicloSelec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CiclosTableAdapter.Fill(Me.SegurosDS.Ciclos)
        CmbCiclo.SelectedIndex = 0
    End Sub

    Private Sub BttSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttSave.Click
        Ciclo = CmbCiclo.SelectedValue
        CicloDSC = CmbCiclo.Text
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BttCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class