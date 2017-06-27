Public Class FrmPendientes
    Public Tipo As String
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If DTFecha.Value < Date.Now.ToShortDateString Then
            MessageBox.Show("La fecha no puede ser menor al dia de hoy.", "Error Fecha Vencmiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DTFecha.Focus()
            Exit Sub
        End If
        If TxtAsunto.Text = "" Then
            MessageBox.Show("Asunto No valido.", "Error Asunto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtAsunto.Focus()
            Exit Sub
        End If
        If CmbCliente.Text = "" Then
            MessageBox.Show("Cliente No valido.", "Error Asunto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CmbCliente.Focus()
            Exit Sub
        End If
        Dim ta As New GeneralDSTableAdapters.GEN_PendientesTableAdapter
        Dim taU As New SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
        Dim tu As New SeguridadDS.UsuariosFinagilDataTable
        taU.FillByUsuario(tu, UsuarioGlobal)
        Dim Nom As String = tu.Item(0).NombreCompleto
        If Tipo = "H" Then
            ta.Insert("", Date.Now, DTFecha.Value, UCase(TxtAsunto.Text), UsuarioGlobal, CmbPersona.SelectedValue, "NEW", UsuarioGlobal, Nom, CmbArea.Text, CmbPersona.Text, CmbCliente.SelectedValue)
        Else
            ta.Insert("", Date.Now, DTFecha.Value, UCase(TxtAsunto.Text), CmbPersona.SelectedValue, UsuarioGlobal, "TMP", UsuarioGlobal, CmbPersona.Text, CmbArea.Text, Nom, CmbCliente.SelectedValue)
        End If

        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub FrmPendientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DepartamentosFinagilTableAdapter.Fill(Me.SeguridadDS.DepartamentosFinagil)
        Me.UsuariosFinagilTableAdapter.FillByDepto(Me.SeguridadDS.UsuariosFinagil, CmbArea.Text)
        Me.ContClie1TableAdapter.Fill(Me.ProductionDataSet.ContClie1)
        If Tipo = "H" Then
            Me.Text = "Realizar un compromiso."
        Else
            Me.Text = "Asignar un compromiso."
        End If
    End Sub

    Private Sub CmbArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbArea.SelectedIndexChanged
        If CmbArea.SelectedIndex >= 0 Then
            Me.UsuariosFinagilTableAdapter.FillByDepto(Me.SeguridadDS.UsuariosFinagil, CmbArea.Text)
        End If
    End Sub

    Private Sub TxtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFiltro.TextChanged
        If TxtFiltro.Text.Length > 0 Then
            ContClie1BindingSource.Filter = "descr like '%" & TxtFiltro.Text & "%'"
        Else
            ContClie1BindingSource.Filter = ""
        End If
    End Sub
End Class