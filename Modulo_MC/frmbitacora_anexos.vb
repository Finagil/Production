Public Class frmbitacora_anexos
    Public cAnexo As String = ""
    Public cCiclo As String = ""
    Dim nCiclo As Integer = 0

    Private Sub frmbitacora_anexos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UsuarioGlobalDepto <> "COBRANZAS" And UsuarioGlobalDepto <> "JURIDICO" And UsuarioGlobal.ToUpper <> "GRAMIREZ" Then
            If TaQUERY.SacaPermisoModulo("SOLICITAR_GV", UsuarioGlobal) <= 0 Then
                MessageBox.Show("No estas autorizado para solicitar documentos", "Expediente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Dispose()
            End If
        End If
        If cAnexo.Length > 0 Then
            txt_anexo.Text = cAnexo
            txtcliente.ReadOnly = True
            txt_anexo.ReadOnly = True
            cbanexos.Enabled = False
            cbclientes.Enabled = False
        End If
        Me.Text += " (" & UsuarioGlobal & ")"
    End Sub

    Private Sub txtcliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcliente.TextChanged
        If txtcliente.Text.Length > 4 And txt_anexo.Text.Length = 0 Then
            Me.ClientesTableAdapter.SelectClientes(Me.MesaControlDS.Clientes, txtcliente.Text)
            If Not cbclientes.SelectedValue Is Nothing Then
                Me.Vw_AnexosTableAdapter.AnexoPorCliente(Me.MesaControlDS.Vw_Anexos, cbclientes.SelectedValue)
            End If
        End If
    End Sub

    Private Sub txt_anexo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_anexo.TextChanged
        If txt_anexo.Text.Length > 2 And txtcliente.Text.Length = 0 Then
            Me.Vw_AnexosTableAdapter.SelectAnexo(Me.MesaControlDS.Vw_Anexos, txt_anexo.Text)
            If Not cbanexos.SelectedValue Is Nothing Then
                Me.ClientesTableAdapter.ObtenerCliente(Me.MesaControlDS.Clientes, cbanexos.SelectedValue)
                If IsNumeric(cCiclo) Then
                    nCiclo = CInt(cCiclo)
                    If cbanexos.Items.Count > nCiclo - 1 Then
                        cbanexos.SelectedIndex = nCiclo - 1
                    Else
                        cbanexos.SelectedIndex = cbanexos.Items.Count - 1
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cbanexos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbanexos.SelectedIndexChanged
        If cbanexos.SelectedValue > 0 And txtcliente.Text.Length = 0 Then
            Me.ClientesTableAdapter.ObtenerCliente(Me.MesaControlDS.Clientes, cbanexos.SelectedValue)
        End If
    End Sub

    Private Sub cbclientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbclientes.SelectedIndexChanged
        If cbclientes.SelectedValue > 0 And txt_anexo.Text.Length = 0 Then
            Me.Vw_AnexosTableAdapter.AnexoPorCliente(Me.MesaControlDS.Vw_Anexos, cbclientes.SelectedValue)
        End If
    End Sub

    Private Sub bt_solicitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_solicitar.Click
        Dim MC_Bitacora As New MesaControlDSTableAdapters.MC_BitacoraTableAdapter

        If MC_Bitacora.EstaPrestado(cbanexos.SelectedValue, cCiclo) > 0 Then
            MessageBox.Show("Expediente esta en prestamo.", "Expediente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MC_Bitacora.ExpedienteEnCaja(cbanexos.SelectedValue) > 0 And cCiclo = "" Then
            MessageBox.Show("el Expediente esta en resguardo externo", "Expediente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Guardar datos bitacora
        MC_Bitacora.InsertAnexo(cbanexos.SelectedValue, ckpagare.Checked, ckcontrato.Checked, ckconvenio.Checked,
        ckescritura.Checked, ckfactura.Checked, ckgarantia.Checked, Date.Now, txtjustificacion.Text, UsuarioGlobal,
        TxtCiclo.Text, CkAuditoria.Checked, CkNoAdeudo.Checked)
        MessageBox.Show("Solicitud Enviada", "Solicitud de Documentacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Limpiar Campos
        txtcliente.Clear()
        txt_anexo.Clear()
        txtjustificacion.Clear()
        ckpagare.Checked = False
        ckfactura.Checked = False
        ckgarantia.Checked = False
        ckconvenio.Checked = False
        ckcontrato.Checked = False
        ckescritura.Checked = False
        CkAuditoria.Checked = False
        CkNoAdeudo.Checked = False
        cbclientes.DataSource = Nothing
        cbanexos.DataSource = Nothing
        cbclientes.Items.Clear()
        cbanexos.Items.Clear()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
End Class