Public Class frm_solicitudes
    Dim id As Integer = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Visible = False
        dt.Visible = False
        grupo.Enabled = True
        btn_guardar.Enabled = False
        BtnPrint.Enabled = False
        Borrar()
        If TaQUERY.SacaPermisoModulo("BORRAR_BITACORA_MC", UsuarioGlobal) > 0 Then
            ButtonDelete.Enabled = True
        End If
    End Sub

    Private Sub rb_pendientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_pendientes.CheckedChanged
        Me.MesaControlDS.Vw_Bitacora_anexo.Clear()
        Me.Vw_Bitacora_anexoTableAdapter.FillPendientes(Me.MesaControlDS.Vw_Bitacora_anexo)
        Label2.Visible = False
        dt.Visible = False
        grupo.Enabled = True
        btn_guardar.Enabled = False
        BtnPrint.Enabled = True
        btn_entregar.Enabled = True
        Borrar()
    End Sub

    Private Sub rb_entregados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_entregados.CheckedChanged
        Me.MesaControlDS.Vw_Bitacora_anexo.Clear()
        Me.Vw_Bitacora_anexoTableAdapter.FillEntregadas(Me.MesaControlDS.Vw_Bitacora_anexo)
        Label2.Visible = True
        dt.Visible = True
        grupo.Enabled = False
        btn_guardar.Enabled = True
        BtnPrint.Enabled = True
        btn_entregar.Enabled = False
        Borrar()
    End Sub

    Private Sub rb_devueltos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_devueltos.CheckedChanged
        Me.MesaControlDS.Vw_Bitacora_anexo.Clear()
        Me.Vw_Bitacora_anexoTableAdapter.FillDevueltas(Me.MesaControlDS.Vw_Bitacora_anexo)
        Label2.Visible = False
        dt.Visible = False
        grupo.Enabled = False
        btn_guardar.Enabled = False
        BtnPrint.Enabled = True
        btn_entregar.Enabled = False
        Borrar()
    End Sub

    Private Sub btn_entregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_entregar.Click

        'declaracion de variables

        Dim MC_Bitacora As New MesaControlDSTableAdapters.MC_BitacoraTableAdapter
        Dim fecha_entrega As Date = Date.Now
        If txtid.Text.Length <= 0 Then
            Exit Sub
        ElseIf CkAutoriza.Checked = False Then
            MessageBox.Show("Solicitud no autorizada", "No autorizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        id = txtid.Text
        'Modificar entrega
        If id > 0 Then
            MC_Bitacora.UpdateEntrega(pagare_org.Checked, txtpagare.Text, contrato_org.Checked, txtcontrato.Text, convenio_org.Checked, txtconvenio.Text,
                                      escrituras_org.Checked, txtescrituras.Text, facturas_org.Checked, txtfacturas.Text, garantias_org.Checked, txtgarantias.Text,
                                      fecha_entrega, txtnota.Text, CkCont.Checked, CkConv.Checked, CkEscri.Checked, CkFact.Checked, CkPagare.Checked, CkGarant.Checked, id)

            MessageBox.Show("Entrega realizada ", "Entrega de Documentación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'rb_pendientes.Checked = False
            'rb_entregados.Checked = True
            'Limpiar campos
            txtnota.Clear()
            txtcontrato.Clear()
            txtconvenio.Clear()
            txtescrituras.Clear()
            txtfacturas.Clear()
            txtgarantias.Clear()
            txtpagare.Clear()
            pagare_org.Checked = False
            contrato_org.Checked = False
            convenio_org.Checked = False
            escrituras_org.Checked = False
            facturas_org.Checked = False
            garantias_org.Checked = False
            DGV.DataBindings.Clear()
            Me.Vw_Bitacora_anexoTableAdapter.FillPendientes(Me.MesaControlDS.Vw_Bitacora_anexo)
            Borrar()
        End If

    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If MessageBox.Show("¿Esta seguro de marcar este expediete como devuelto?", "Devolver Expediente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim MC_Bitacora As New MesaControlDSTableAdapters.MC_BitacoraTableAdapter
            ' devolucion
            id = txtid.Text
            If id > 0 Then
                MC_Bitacora.UpdateDevolucion(dt.Text, id)
                MessageBox.Show("Devolución realizada ", "Devolución de Documentación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                DGV.DataBindings.Clear()
                Me.Vw_Bitacora_anexoTableAdapter.FillEntregadas(Me.MesaControlDS.Vw_Bitacora_anexo)
            End If
            Borrar()
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Cursor.Current = Cursors.WaitCursor
        id = txtid.Text
        If id > 0 Then
            Dim MC_Bitacora As New MesaControlDSTableAdapters.MC_BitacoraTableAdapter
            MC_Bitacora.UpdateDatos(pagare_org.Checked, txtpagare.Text, contrato_org.Checked, txtcontrato.Text, convenio_org.Checked, txtconvenio.Text,
                                      escrituras_org.Checked, txtescrituras.Text, facturas_org.Checked, txtfacturas.Text, garantias_org.Checked, txtgarantias.Text,
                                       txtnota.Text, CkCont.Checked, CkConv.Checked, CkEscri.Checked, CkFact.Checked, CkPagare.Checked, CkGarant.Checked, id)

            Dim f As New frm_acuse
            f.ID = txtid.Text
            If f.ShowDialog = DialogResult.OK Then
            End If
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub TxtFiltroCliente_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltroCliente.TextChanged
        If TxtFiltroCliente.Text.Length > 0 Then
            TxtFiltroAnexo.Text = ""
            TxtFiltroUser.Text = ""
            VwBitacoraanexoBindingSource1.Filter = "Cliente like '%" & TxtFiltroCliente.Text.Trim & "%'"
        End If
    End Sub

    Private Sub TxtFiltroAnexo_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltroAnexo.TextChanged
        If TxtFiltroAnexo.Text.Trim.Length > 1 Then
            TxtFiltroCliente.Text = ""
            TxtFiltroUser.Text = ""
            Dim cad As String = TxtFiltroAnexo.Text.Substring(0, 5).Trim
            If cad.Length >= 7 Then cad += TxtFiltroAnexo.Text.Substring(6, 4).Trim
            VwBitacoraanexoBindingSource1.Filter = "Anexo like '%" & cad & "%'"
        End If
    End Sub

    Private Sub Borrar()
        TxtFiltroCliente.Text = ""
        TxtFiltroAnexo.Text = ""
        VwBitacoraanexoBindingSource1.Filter = ""
    End Sub

    Private Sub CkCont_CheckedChanged(sender As Object, e As EventArgs) Handles CkCont.CheckedChanged
        GroupCont.Enabled = CkCont.Checked
    End Sub

    Private Sub CkConv_CheckedChanged(sender As Object, e As EventArgs) Handles CkConv.CheckedChanged
        GroupConv.Enabled = CkConv.Checked
    End Sub

    Private Sub CkEscri_CheckedChanged(sender As Object, e As EventArgs) Handles CkEscri.CheckedChanged
        GroupEscri.Enabled = CkEscri.Checked
    End Sub

    Private Sub CkFact_CheckedChanged(sender As Object, e As EventArgs) Handles CkFact.CheckedChanged
        GroupFact.Enabled = CkFact.Checked
    End Sub

    Private Sub CkGarant_CheckedChanged(sender As Object, e As EventArgs) Handles CkGarant.CheckedChanged
        GroupGarant.Enabled = CkGarant.Checked
    End Sub

    Private Sub CkPagare_CheckedChanged(sender As Object, e As EventArgs) Handles CkPagare.CheckedChanged
        GroupPag.Enabled = CkPagare.Checked
    End Sub

    Private Sub Textuser_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltroUser.TextChanged
        If TxtFiltroUser.Text.Length > 0 Then
            TxtFiltroCliente.Text = ""
            TxtFiltroAnexo.Text = ""
            VwBitacoraanexoBindingSource1.Filter = "Solicito like '%" & TxtFiltroUser.Text.Trim & "%'"
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If Not IsNothing(Me.VwBitacoraanexoBindingSource1.Current()) Then
            If MessageBox.Show("¿Estas Seguro de Borrar la solicitud selecionada?", "Borra Solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                Me.Vw_Bitacora_anexoTableAdapter.deleteSol(Me.VwBitacoraanexoBindingSource1.Current("Id_Bitacora"))
                DGV.DataBindings.Clear()
                Me.Vw_Bitacora_anexoTableAdapter.FillPendientes(Me.MesaControlDS.Vw_Bitacora_anexo)
            End If
        Else
                MessageBox.Show("No hay datos para Borrar.", "Borra Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class