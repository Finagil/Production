Public Class FrmMarcaReestruct

    Private Sub FrmMarcaReestruct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AnexosSinPagoTableAdapter.Fill(Me.MesaControlDS.AnexosSinPago)
        CmbAcumula.SelectedIndex = 0
        CmbReest.SelectedIndex = 0
    End Sub

    Private Sub BttMarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttMarcar.Click
        If LstAnexos.SelectedIndex >= 0 Then
            If MsgBoxResult.Yes = MessageBox.Show("Esta seguro de Activar el contrato." & vbCrLf & LstAnexos.Text & vbCrLf & "con Fecha " & Dtp1.Value.ToShortDateString, "Marcar Reestructura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                Dim TA As New ProductionDataSetTableAdapters.AnexosTableAdapter
                Me.AnexosSinPagoTableAdapter.MarcaReestructura(Mid(CmbReest.Text, 1, 1), Dtp1.Value.ToString("yyyyMMdd"), CmbAcumula.Text, LstAnexos.SelectedValue)
                DesBloqueaContrato(LstAnexos.SelectedValue)
                BloqueaContrato(LstAnexos.SelectedValue)
                Me.AnexosSinPagoTableAdapter.Fill(Me.MesaControlDS.AnexosSinPago)
            End If
        Else
            MessageBox.Show("Falta Selecionar Anexo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class