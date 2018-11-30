Public Class FrmAlertasJUR
    Private Sub FrmAlertasJUR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ContClie1TableAdapter.Fill(Me.ProductionDataSet.ContClie1)
        Try
        Catch eException As Exception
            MsgBox(eException.Source & " " & eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
        End Try
    End Sub

    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            ContClie1BindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
        Else
            ContClie1BindingSource.Filter = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.JURAlertasClientesBindingSource.AddNew()
        Me.JURAlertasClientesBindingSource.Current("Fecha") = Date.Now
        Me.JURAlertasClientesBindingSource.Current("Usuario") = UsuarioGlobal
        Me.JURAlertasClientesBindingSource.Current("Activa") = True
        Me.JURAlertasClientesBindingSource.Current("Alerta") = ""
        Me.JURAlertasClientesBindingSource.Current("Cliente") = ComboBox1.SelectedValue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            JURAlertasClientesBindingSource.EndEdit()
            Me.JUR_AlertasClientesTableAdapter.Update(JuridicoDS.JUR_AlertasClientes)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.JURAlertasClientesBindingSource.CancelEdit()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex >= 0 Then
            Me.JUR_AlertasClientesTableAdapter.Fill(JuridicoDS.JUR_AlertasClientes, ComboBox1.SelectedValue)
        End If
    End Sub
End Class