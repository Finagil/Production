Public Class FrmCveObs

    Private Sub Txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length >= 3 Then
            If CckReestruct.Checked = True Then
                Me.ClientesTableAdapter.FillByReestruct(Me.JuridicoDS.Clientes, "%" & Txtfiltro.Text.Trim & "%")
            Else
                Me.ClientesTableAdapter.Fill(Me.JuridicoDS.Clientes, "%" & Txtfiltro.Text.Trim & "%")
            End If

        Else
            Me.JuridicoDS.Clientes.Clear()
        End If
        CmbClientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    

    Private Sub CmbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbClientes.SelectedIndexChanged
        If CmbClientes.SelectedIndex >= 0 Then
            Me.Vw_AnexosResumenTableAdapter.Fill(Me.JuridicoDS.Vw_AnexosResumen, CmbClientes.SelectedValue)
            Me.ClavesObservacionTableAdapter.Fill(Me.JuridicoDS.ClavesObservacion, TxtTipo.Text)
            CmbAnexo_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub CmbAnexo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAnexo.SelectedIndexChanged
        If CmbAnexo.SelectedIndex >= 0 Then
            Me.AsignacionClavesOBSTableAdapter.Fill(JuridicoDS.AsignacionClavesOBS, CmbAnexo.SelectedValue)
            If JuridicoDS.AsignacionClavesOBS.Rows.Count > 0 Then
                TxtClave.Text = JuridicoDS.AsignacionClavesOBS.Rows(JuridicoDS.AsignacionClavesOBS.Rows.Count - 1).Item(1) 'Clave
            Else
                TxtClave.Text = "00"
            End If
        Else
            TxtClave.Text = "00"
        End If
        CmbClave.SelectedValue = TxtClave.Text
        If TxtClave.Text = "" Then Button1.Enabled = True
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CmbClave.SelectedIndex > 0 And CmbAnexo.SelectedIndex >= 0 Then
            Me.AsignacionClavesOBSTableAdapter.Insert(CmbAnexo.SelectedValue, CmbClave.SelectedValue, Date.Now, UsuarioGlobal)
            MessageBox.Show("Clave Guardada", "Clave de Observación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbAnexo_SelectedIndexChanged(Nothing, Nothing)
        Else
            MessageBox.Show("Faltan datos", "Error Clave de Observación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CmbClave_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbClave.SelectedIndexChanged
        If TxtClave.Text <> CmbClave.SelectedValue Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If

    End Sub

    
    Private Sub CckReestruct_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CckReestruct.CheckedChanged
        If Txtfiltro.Text.Length >= 3 Then
            If CckReestruct.Checked = True Then
                Me.ClientesTableAdapter.FillByReestruct(Me.JuridicoDS.Clientes, "%" & Txtfiltro.Text.Trim & "%")
            Else
                Me.ClientesTableAdapter.Fill(Me.JuridicoDS.Clientes, "%" & Txtfiltro.Text.Trim & "%")
            End If
        Else
            Me.JuridicoDS.Clientes.Clear()
        End If
        CmbClientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub
End Class