Public Class FrmAsociarNew
    Public Cliente As String
    Public NvoEstatus As String
    Public NvoReestructura As String
    Public Anexo As String
    Public Ciclo As String
    Private Sub FrmAsociarNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AnexosSinActivarTableAdapter.Fill(ReestructDS.AnexosSinActivar, Cliente)
        If ReestructDS.AnexosSinActivar.Rows.Count <= 0 Then
            MessageBox.Show("No existen contratos para asociar", "Asociar Contrato", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Else
            ComboBox1_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.AnexosTableAdapter.Fill(ReestructDS.Anexos, ComboBox1.SelectedValue, "")
        If NvoEstatus = "VENCIDA" Then
            Label8.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BtnAsociar_Click(sender As Object, e As EventArgs) Handles BtnAsociar.Click
        Dim ta As New ReestructDSTableAdapters.AnexosAsociadosTableAdapter
        Dim ta1 As New ReestructDSTableAdapters.CambiosAnexosTableAdapter
        ta.Insert(Anexo, Ciclo, ComboBox1.SelectedValue, FECHA_APLICACION, UsuarioGlobal)
        If NvoEstatus = "VENCIDA" Then
            ta1.VencidaXReestructura(Anexo, Ciclo, FECHA_APLICACION)
        End If
        ta1.CambiaAnexoTRA(NvoReestructura, NvoEstatus, ComboBox1.SelectedValue)
        ta1.ActivarReest(DTP1.Value.ToString("yyyyMMdd"), ComboBox1.SelectedValue)
        MessageBox.Show("Anexos Asociados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        DialogResult = Windows.Forms.DialogResult.Yes
    End Sub
End Class