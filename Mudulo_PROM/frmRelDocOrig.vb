Public Class frmRelDocOrig
    Private Sub frmRelDocOrig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.MaxDate = Date.Now
        dtpFecha.MinDate = Date.Now.AddDays(-3)
        txtFiltroCliente.Focus()
        Me.GEN_ProductosFinagilTableAdapter.Fill(Me.CreditoDS.GEN_ProductosFinagil)
        Me.CRED_RelDocumentosTableAdapter.Fill(Me.CreditoDS.CRED_RelDocumentos)
        Me.UsuariosFinagilTableAdapter.FillByDepto(Me.SeguridadDS.UsuariosFinagil, "CREDITO")
        Me.UsuariosFinagilTableAdapter.obt_Analista_Resg_FillBy(Me.SeguridadDS.UsuariosFinagil)
        limpiar()
    End Sub

    Private Sub txtFiltroCliente_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroCliente.TextChanged
        'If txtFiltroCliente.Text.Length > 0 Then
        '    ClientesBindingSource.Filter = "descr like '%" & txtFiltroCliente.Text & "%'"
        'Else
        '    ClientesBindingSource.Filter = ""
        'End If
    End Sub

    Private Sub SucursalTextBox_TextChanged(sender As Object, e As EventArgs) Handles SucursalTextBox.TextChanged
        txtSucursalName.Text = TaQUERY.SacaSucursal(SucursalTextBox.Text.Trim)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cmbClientes.Text.Trim <> "" And ClienteTextBox.Text.Trim <> "" And TipoTextBox.Text.Trim <> "" And SucursalTextBox.Text.Trim <> "" And cmbProducto.Text.Trim <> "" Then
            Try
                Me.CRED_RelDocumentosTableAdapter.Insert(cmbClientes.Text.Trim, ClienteTextBox.Text.Trim, TipoTextBox.Text.Trim, SucursalTextBox.Text.Trim, cmbProducto.Text.Trim, dtpFecha.Value, "0", cmbAnalista.Text.Trim, + _
                chkb_1.Checked, chkb_cop_1.Checked, txtObs_1.Text.Trim, + _
                chkb_2.Checked, chkb_cop_2.Checked, txtObs_2.Text.Trim, + _
                chkb_3.Checked, chkb_cop_3.Checked, txtObs_3.Text.Trim, + _
                chkb_4.Checked, chkb_cop_4.Checked, txtObs_4.Text.Trim, + _
                chkb_5.Checked, chkb_cop_5.Checked, txtObs_5.Text.Trim, + _
                chkb_6.Checked, chkb_cop_6.Checked, txtObs_6.Text.Trim, + _
                chkb_7.Checked, chkb_cop_7.Checked, txtObs_7.Text.Trim, + _
                chkb_8.Checked, chkb_cop_8.Checked, txtObs_8.Text.Trim, + _
                chkb_9.Checked, chkb_cop_9.Checked, txtObs_9.Text.Trim, + _
                chkb_10.Checked, chkb_cop_10.Checked, txtObs_10.Text.Trim, + _
                chkb_11.Checked, chkb_cop_11.Checked, txtObs_11.Text.Trim, + _
                chkb_12.Checked, chkb_cop_12.Checked, txtObs_12.Text.Trim, + _
                chkb_13.Checked, chkb_cop_13.Checked, txtObs_13.Text.Trim, + _
                chkb_14.Checked, chkb_cop_14.Checked, txtObs_14.Text.Trim, + _
                chkb_15.Checked, chkb_cop_15.Checked, txtObs_15.Text.Trim, + _
                chkb_16.Checked, chkb_cop_16.Checked, txtObs_16.Text.Trim, + _
                chkb_17.Checked, chkb_cop_17.Checked, txtObs_17.Text.Trim, + _
                chkb_18.Checked, chkb_cop_18.Checked, txtObs_18.Text.Trim, + _
                chk_cot1.Checked, chk_cot2.Checked, chk_cot3.Checked, + _
                chk_cot4.Checked, chk_cot5.Checked, chk_cot6.Checked, + _
                chk_cot7.Checked, chk_cot8.Checked, chk_cot9.Checked, + _
                chk_cot10.Checked, chk_cot11.Checked, chk_cot12.Checked, + _
                chk_cot13.Checked, chk_cot14.Checked, chk_cot15.Checked, + _
                chk_cot16.Checked, chk_cot17.Checked, chk_cot18.Checked, + _
                0, txtSucursalName.Text.Trim, txtObservaciones.Text.Trim, UsuarioGlobal, + _
                chkb_19.Checked, chkb_cop_19.Checked, chk_cot19.Checked, txtObs_19.Text.Trim, cmbResguarda.Text.Trim, chkb_20.Checked, chkb_cop_20.Checked, chk_cot20.Checked, txtObs_20.Text.Trim, + _
                 chkb_21.Checked, chkb_cop_21.Checked, chk_cot21.Checked, txtObs_21.Text.Trim, + _
                 chkb_22.Checked, chkb_cop_22.Checked, chk_cot22.Checked, txtObs_22.Text.Trim, + _
                 chkb_23.Checked, chkb_cop_23.Checked, chk_cot23.Checked, txtObs_23.Text.Trim, + _
                 chkb_24.Checked, chkb_cop_24.Checked, chk_cot24.Checked, txtObs_24.Text.Trim, + _
                 chkb_25.Checked, chkb_cop_25.Checked, chk_cot25.Checked, txtObs_25.Text.Trim, + _
                 chkb_26.Checked, chkb_cop_26.Checked, chk_cot26.Checked, txtObs_26.Text.Trim, + _
                 chkb_27.Checked, chkb_cop_27.Checked, chk_cot27.Checked, txtObs_27.Text.Trim)

                If MsgBox("Datos guardados correctamente, ¿Desea imprimir el reporte?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                    Dim ultimoID As String = Me.CRED_RelDocumentosTableAdapter.UltimoID.ToString
                    Me.CRED_RelDocumentosTableAdapter.Obt_Doc_FillBy(Me.CreditoDS.CRED_RelDocumentos, ultimoID)
                    Dim rpt As New rptDoctosRelacionados
                    rpt.SetDataSource(CreditoDS)
                    frmRepRelDocOrig.crv_doc.ReportSource = rpt
                    frmRepRelDocOrig.Show()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Datos incompletos, favor de capturar información faltante")
        End If
    End Sub

    Private Sub limpiar()
        txtFiltroCliente.Text = ""
        cmbClientes.Text = ""
        cmbProducto.Text = ""
        cmbAnalista.Text = ""
        TipoTextBox.Text = ""
        SucursalTextBox.Text = ""
        txtSucursalName.Text = ""
        chkb_1.Checked = False
        chkb_cop_1.Checked = False
        txtObs_1.Text = ""
        chkb_2.Checked = False
        chkb_cop_2.Checked = False
        txtObs_2.Text = ""
        chkb_3.Checked = False
        chkb_cop_3.Checked = False
        txtObs_3.Text = ""
        chkb_4.Checked = False
        chkb_cop_4.Checked = False
        txtObs_4.Text = ""
        chkb_5.Checked = False
        chkb_cop_5.Checked = False
        txtObs_5.Text = ""
        chkb_6.Checked = False
        chkb_cop_6.Checked = False
        txtObs_6.Text = ""
        chkb_7.Checked = False
        chkb_cop_7.Checked = False
        txtObs_7.Text = ""
        chkb_8.Checked = False
        chkb_cop_8.Checked = False
        txtObs_8.Text = ""
        chkb_9.Checked = False
        chkb_cop_9.Checked = False
        txtObs_9.Text = ""
        chkb_10.Checked = False
        chkb_cop_10.Checked = False
        txtObs_10.Text = ""
        chkb_11.Checked = False
        chkb_cop_11.Checked = False
        txtObs_11.Text = ""
        chkb_12.Checked = False
        chkb_cop_12.Checked = False
        txtObs_12.Text = ""
        chkb_13.Checked = False
        chkb_cop_13.Checked = False
        txtObs_13.Text = ""
        chkb_14.Checked = False
        chkb_cop_14.Checked = False
        txtObs_14.Text = ""
        chkb_15.Checked = False
        chkb_cop_15.Checked = False
        txtObs_15.Text = ""
        chkb_16.Checked = False
        chkb_cop_16.Checked = False
        txtObs_16.Text = ""
        chkb_17.Checked = False
        chkb_cop_17.Checked = False
        txtObs_17.Text = ""
        chkb_18.Checked = False
        chkb_cop_18.Checked = False
        txtObs_18.Text = ""

        chkb_19.Checked = False
        chkb_cop_19.Checked = False
        txtObs_19.Text = ""

        chkb_20.Checked = False
        chkb_cop_20.Checked = False
        txtObs_20.Text = ""

        chkb_21.Checked = False
        chkb_cop_21.Checked = False
        txtObs_21.Text = ""

        chkb_22.Checked = False
        chkb_cop_22.Checked = False
        txtObs_22.Text = ""

        chkb_23.Checked = False
        chkb_cop_23.Checked = False
        txtObs_23.Text = ""

        chk_cot1.Checked = False
        chk_cot2.Checked = False
        chk_cot3.Checked = False
        chk_cot4.Checked = False
        chk_cot5.Checked = False
        chk_cot6.Checked = False
        chk_cot7.Checked = False
        chk_cot8.Checked = False
        chk_cot9.Checked = False
        chk_cot10.Checked = False
        chk_cot11.Checked = False
        chk_cot12.Checked = False
        chk_cot13.Checked = False
        chk_cot14.Checked = False
        chk_cot15.Checked = False
        chk_cot16.Checked = False
        chk_cot17.Checked = False
        chk_cot18.Checked = False
        chk_cot19.Checked = False
        chk_cot20.Checked = False
        chk_cot21.Checked = False
        chk_cot22.Checked = False
        chk_cot23.Checked = False
        txtObservaciones.Text = ""
        ClienteTextBox.Text = ""
        cmbResguarda.Text = ""
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnReimprimir_Click(sender As Object, e As EventArgs) Handles btnReimprimir.Click
        frmImprRelDocOrig.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Cursor.Current = Cursors.WaitCursor
        If txtFiltroCliente.Text = "" Then
            If MessageBox.Show("¿Estás seguro de cargar todos los clientes?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.ClientesTableAdapter.Fill(Me.CreditoDS.Clientes)
            End If
        Else
            Me.ClientesTableAdapter.Obt_Clt_FillBy(Me.CreditoDS.Clientes, txtFiltroCliente.Text.Trim)
        End If
        cmbClientes.Enabled = True
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub cmbAnalista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnalista.SelectedIndexChanged
        cmbResguarda.Text = cmbAnalista.Text
    End Sub
End Class