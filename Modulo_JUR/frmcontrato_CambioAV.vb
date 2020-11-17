Public Class frmcontrato_CambioAV
    Private Sub bt_cambiar_Click(sender As Object, e As EventArgs) Handles bt_cambiarfec.Click
        Me.AviosCambiosTableAdapter.updateFechaTerminacion(dt_fecTerminacion.Value.ToString("yyyyMMdd"), AviosCambiosBindingSource.Current("Anexo"), AviosCambiosBindingSource.Current("ciclo"))
        BITACORA.Insert(UsuarioGlobal, Me.Name, Date.Now, "CambioJUR", System.Environment.MachineName, cbanexos.SelectedValue & LabelCiclo.Text & bt_cambiarfec.Text)
        MessageBox.Show("Datos Guardados", bt_cambiarfec.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cbclientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbclientes.SelectedIndexChanged
        If Not cbclientes.SelectedValue Is Nothing Then
            Me.AviosCambiosTableAdapter.Fill(Me.MesaControlDS.AviosCambios, cbclientes.SelectedValue)
        End If
    End Sub

    Private Sub ButtonDif_Click(sender As Object, e As EventArgs) Handles ButtonDif.Click
        Try
            Dim dif As Integer = InputBox("Nuevo Diferencial", "Diferencial Finagil", AviosCambiosBindingSource.Current("DiffORG"))
            Me.AviosCambiosTableAdapter.UpdateDiferencial(dif, AviosCambiosBindingSource.Current("Anexo"), AviosCambiosBindingSource.Current("ciclo"))
            BITACORA.Insert(UsuarioGlobal, Me.Name, Date.Now, "CambioJUR", System.Environment.MachineName, cbanexos.SelectedValue & LabelCiclo.Text & Label7.Text)
            MessageBox.Show("Datos Guardados", Label7.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.AviosCambiosTableAdapter.Fill(Me.MesaControlDS.AviosCambios, cbclientes.SelectedValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonFondeo_Click(sender As Object, e As EventArgs) Handles ButtonFondeo.Click
        Dim Fondeo As String
        If AviosCambiosBindingSource.Current("FondeoTit").ToString.ToUpper = "PROPIOS" Then
            Fondeo = "03" ' PASA A FIRA
        Else
            Fondeo = "01" ' PASA A PROPIOS
        End If
        Me.AviosCambiosTableAdapter.UpdateFondeo(Fondeo, AviosCambiosBindingSource.Current("Anexo"), AviosCambiosBindingSource.Current("ciclo"))
        BITACORA.Insert(UsuarioGlobal, Me.Name, Date.Now, "CambioJUR", System.Environment.MachineName, cbanexos.SelectedValue & LabelCiclo.Text & Label8.Text)
        MessageBox.Show("Datos Guardados", Label8.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.AviosCambiosTableAdapter.Fill(Me.MesaControlDS.AviosCambios, cbclientes.SelectedValue)
    End Sub

    Private Sub frmcontrato_CambioAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter.FillByAV(Me.MesaControlDS.Clientes)
        cbclientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.AviosCambiosTableAdapter.UpdateFechaContrato(DTp_FechaCont.Value.ToString("yyyyMMdd"), AviosCambiosBindingSource.Current("Anexo"), AviosCambiosBindingSource.Current("ciclo"))
        BITACORA.Insert(UsuarioGlobal, Me.Name, Date.Now, "CambioJUR", System.Environment.MachineName, cbanexos.SelectedValue & LabelCiclo.Text & Button1.Text)
        MessageBox.Show("Datos Guardados", Button1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class