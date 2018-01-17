Public Class FrmSeguimientoCRED
    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            ContClie1BindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
        Else
            ContClie1BindingSource.Filter = ""
        End If
    End Sub

    Private Sub ComboClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboClientes.SelectedIndexChanged
        If ComboClientes.SelectedIndex >= 0 Then
            Me.AnexosCREDTableAdapter.Fill(Me.CreditoDS.AnexosCRED, ComboClientes.SelectedValue)
        Else
            Me.CreditoDS.AnexosCRED.Clear()
        End If
    End Sub

    Private Sub CmbAnexos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAnexos.SelectedIndexChanged
        If CmbAnexos.SelectedIndex >= 0 Then
            Me.CRED_SeguimientoTableAdapter.Fill(Me.CreditoDS.CRED_Seguimiento, CmbAnexos.SelectedValue)
        Else
            Me.CreditoDS.CRED_Seguimiento.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        CREDSeguimientoBindingSource.AddNew()
        DTPAlta.Value = Date.Now
        DTPcompromiso.Value = Date.Now
        CmbEstatus.Text = "Pendiente"
        CREDSeguimientoBindingSource.Current("Anexo") = CmbAnexos.SelectedValue
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            CREDSeguimientoBindingSource.EndEdit()
            Me.CRED_SeguimientoTableAdapter.Update(Me.CreditoDS.CRED_Seguimiento)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        CREDSeguimientoBindingSource.CancelEdit()
    End Sub

    Private Sub FrmSeguimientoCRED_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ContClie1TableAdapter.Fill(Me.ProductionDataSet.ContClie1)
    End Sub
End Class