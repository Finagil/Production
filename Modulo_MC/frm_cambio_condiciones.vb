
Public Class frm_cambio_condiciones
    Public anexo_cambio As String
    Public IDcambio As Decimal

    Private Sub frm_cambio_condiciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Vw_AnexosTableAdapter.SelectAnexo(Me.Bitacora_anexosDS.Vw_Anexos, anexo_cambio)
        cbanexos.SelectedIndex = 0
        If Not cbanexos.SelectedValue Is Nothing Then
            Me.ClientesTableAdapter.ObtenerCliente(Me.Bitacora_anexosDS.Clientes, cbanexos.SelectedValue)
            Me.Vw_AnexosTableAdapter.SelectAnexo(Me.Bitacora_anexosDS.Vw_Anexos, cbanexos.SelectedValue)
            Me.CONT_cambio_condicionesTableAdapter.FillID(Me.Cambios_condicionesDS.Cambio_condiciones, IDcambio)
        End If
        If IDcambio = 0 Then
            bt_imprimir.Enabled = False
            bt_guardar.Enabled = True
            Me.Cambios_condicionesDS.Cambio_condiciones.Clear()
        Else
            bt_imprimir.Enabled = True
            bt_guardar.Enabled = False
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            txt_otros.Enabled = False
        End If
    End Sub


    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        If txt_linea_cambio.Text.Length = 0 Then
            txt_linea_cambio.Text = 0
        End If
        If txt_pago_cambio.Text.Length = 0 Then
            txt_pago_cambio.Text = 0
        End If

        Dim FirmaProm As String = Encriptar(Date.Now.ToString("yyyyMMddhhmm") & "-" & UsuarioGlobal.Trim)

        If txt_anexo_existe.Text.Length = 0 Then
            Me.CONT_cambio_condicionesTableAdapter.InsertQueryCambio_Condiciones(cbanexos.SelectedValue, ch_linea.Checked, ch_recurso.Checked, ch_registro.Checked, ch_pago.Checked, ch_plazo.Checked, ch_otros.Checked, txt_linea_condicion.Text, txt_plazo_condicion.Text, txt_registro_condicion.Text, txt_recurso_condicion.Text, txt_pago_condicion.Text, txt_linea_cambio.Text, txt_plazo_cambio.Text, txt_registro_cambio.Text, txt_recurso_cambio.Text, txt_pago_cambio.Text, txt_otros.Text, Date.Now, Date.Now, FirmaProm, Trim(ClientesBindingSource.Current("Nombre_Sucursal")) & "X", "gbelloX")
        Else
            'Me.CONT_cambio_condicionesTableAdapter.UpdateQueryCambios(ch_linea.Checked, ch_recurso.Checked, ch_registro.Checked, ch_pago.Checked, ch_plazo.Checked, ch_otros.Checked, txt_linea_condicion.Text, txt_plazo_condicion.Text, txt_registro_condicion.Text, txt_recurso_condicion.Text, txt_pago_condicion.Text, txt_linea_cambio.Text, txt_plazo_cambio.Text, txt_registro_cambio.Text, txt_recurso_cambio.Text, txt_pago_cambio.Text, txt_otros.Text, Date.Now, Date.Now, cbanexos.SelectedValue)
        End If
        MessageBox.Show("Datos Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DialogResult = DialogResult.OK
    End Sub

    Private Sub ch_linea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_linea.CheckedChanged
        If ch_linea.Checked = True Then
            txt_linea_condicion.Enabled = True
            txt_linea_cambio.Enabled = True
        Else
            txt_linea_condicion.Enabled = False
            txt_linea_cambio.Enabled = False

        End If
    End Sub

    Private Sub ch_pago_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pago.CheckedChanged
        If ch_pago.Checked = True Then
            txt_pago_condicion.Enabled = True
            txt_pago_cambio.Enabled = True
        Else
            txt_pago_condicion.Enabled = False
            txt_pago_cambio.Enabled = False

        End If
    End Sub

    Private Sub ch_recurso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_recurso.CheckedChanged
        If ch_recurso.Checked = True Then
            txt_recurso_condicion.Enabled = True
            txt_recurso_cambio.Enabled = True
        Else
            txt_recurso_condicion.Enabled = False
            txt_recurso_cambio.Enabled = False

        End If
    End Sub

    Private Sub ch_plazo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_plazo.CheckedChanged
        If ch_plazo.Checked = True Then
            txt_plazo_condicion.Enabled = True
            txt_plazo_cambio.Enabled = True
        Else
            txt_plazo_condicion.Enabled = False
            txt_plazo_cambio.Enabled = False

        End If
    End Sub

    Private Sub ch_registro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_registro.CheckedChanged
        If ch_registro.Checked = True Then
            txt_registro_condicion.Enabled = True
            txt_registro_cambio.Enabled = True
        Else
            txt_registro_condicion.Enabled = False
            txt_registro_cambio.Enabled = False

        End If
    End Sub

    Private Sub ch_otros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_otros.CheckedChanged
        If ch_otros.Checked = True Then
            txt_otros.Enabled = True
        Else
            txt_otros.Enabled = False
        End If
    End Sub

    Private Sub bt_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_imprimir.Click
        If IDcambio > 0 Then
            Cursor.Current = Cursors.WaitCursor
            FrmRPT_MC.IDCambio = IDcambio
            FrmRPT_MC.NombreCli = TextBox1.Text.Trim()
            FrmRPT_MC.RPTTit = "Hoja de Cambios"
            FrmRPT_MC.NombreSUB = ClientesBindingSource.Current("NombreSub")
            FrmRPT_MC.Show()
            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub txt_linea_cambio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_linea_cambio.TextChanged
        If anexo_cambio.Length = 0 Then
            anexo_cambio = 0
        End If
    End Sub

    Private Sub txt_pago_cambio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pago_cambio.TextChanged
        If txt_pago_cambio.Text.Length = 0 Then
            txt_pago_cambio.Text = 0
        End If
    End Sub

End Class