Public Class FrmCambioPlazoAV
    Public Anexo As String
    Public Ciclo As String
    Public NvoEstatus As String
    Private Sub FrmCambioPlazoAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AviosREESTTableAdapter.Fill(Me.ReestructDS.AviosREEST, Anexo, Ciclo)
        If Me.ReestructDS.AviosREEST.Rows.Count > 0 Then
            Dim fecVec As Date
            fecVec = CDate(AviosREESTBindingSource.Current("fechaVEN"))
            DateTimePicker1.MinDate = fecVec
            DateTimePicker1.Value = fecVec
            If fecVec.AddDays(30) >= Date.Now.Date Then
                MessageBox.Show("El contrato ya esta vencido", "Contrato Vencido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ta1 As New ReestructDSTableAdapters.CambiosAnexosTableAdapter
        If DateTimePicker1.Value <= Date.Now.Date Then
            MessageBox.Show("La nueva fecha debe ser mayor al dia de Hoy.", "Nueva Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.AviosREESTTableAdapter.CambioPlazoAV(DateTimePicker1.Value.ToString("yyyyMMdd"), True, IIf(NvoEstatus = "VIGENTE", "", NvoEstatus), Anexo, Ciclo)
        ta1.VencidaXReestructura(Anexo, Ciclo, FECHA_APLICACION)

        MessageBox.Show("Datos actualizados", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DialogResult = Windows.Forms.DialogResult.Yes
    End Sub
End Class