Public Class FrmCapFacturas
    Public cAnexo As String
    Dim Nuevo As Boolean
    Dim anexoTp As String

    Private Sub FrmCapFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ContaDS.CFDI_ConceptosActivoFijo' Puede moverla o quitarla según sea necesario.
        Me.CFDI_ConceptosActivoFijoTableAdapter.Fill(Me.ContaDS.CFDI_ConceptosActivoFijo)
        Call Botones(False)
        Me.ActifijoTableAdapter.Fill(ProductionDataSet.Actifijo, cAnexo)

        Dim dtaAnexo As New CreditoDSTableAdapters.Vw_AnexosTableAdapter
        anexoTp = dtaAnexo.Obt_TipoProd_ScalarQuery(cAnexo)

        If anexoTp = "ARRENDAMIENTO FINANCIERO" Or anexoTp = "ARRENDAMIENTO PURO" Or anexoTp = "FULL SERVICE" Then
            txtRFC.Enabled = True
        End If

    End Sub

    Private Sub btnAltaFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltaFact.Click
        Nuevo = True
        Call LimpiaTexto()
        Call Botones(True)
    End Sub

    Sub LimpiaTexto()
        For Each r As Control In Me.Panel1.Controls
            If TypeOf (r) Is TextBox Or TypeOf (r) Is RichTextBox Or TypeOf (r) Is MaskedTextBox Then
                r.Text = ""
            End If
        Next
    End Sub

    Sub Botones(ByVal B As Boolean)
        Panel1.Enabled = B
        DataGridView1.Enabled = Not B
        btnAltaFact.Enabled = Not B
        btnCambioFact.Enabled = Not B
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnIgnorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgnorar.Click
        Call Botones(False)
        Me.ActifijoTableAdapter.Fill(ProductionDataSet.Actifijo, cAnexo)
    End Sub

    Private Sub btnCambioFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambioFact.Click
        Nuevo = False
        Call Botones(True)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ComboBox1.SelectedIndex < 0 Then
            MessageBox.Show("Debe elegir Datos CFDI, favor de consulta a Contabilidad", "Datos CFDI", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Nuevo = True Then
            Me.ActifijoTableAdapter.Insert(cAnexo, txtFactura.Text, txtProveedor.Text, txtImporte.Text, 0,
            txtDetalle.Text, 0, txtModelo.Text, txtMotor.Text, txtSerie.Text, txtPlaca.Text _
            , "", "", "", "", "", "", "", "", "", CFDIConceptosActivoFijoBindingSource.Current("Codigo"),
             CFDIConceptosActivoFijoBindingSource.Current("UsoCFDI"), CFDIConceptosActivoFijoBindingSource.Current("UnidadMedida"), CFDIConceptosActivoFijoBindingSource.Current("id_ConceptoActivo"))
        Else
            Me.ActifijoTableAdapter.UpdateFACT(txtFactura.Text.Trim, txtProveedor.Text.Trim, txtImporte.Text, txtDetalle.Text.Trim, txtModelo.Text.Trim,
                                               txtMotor.Text.Trim, txtSerie.Text.Trim, txtPlaca.Text.Trim, CFDIConceptosActivoFijoBindingSource.Current("Codigo"),
             CFDIConceptosActivoFijoBindingSource.Current("UsoCFDI"), CFDIConceptosActivoFijoBindingSource.Current("UnidadMedida"), CFDIConceptosActivoFijoBindingSource.Current("id_ConceptoActivo"), TxtID.Text, cAnexo)
        End If
        Call Botones(False)
        Me.ActifijoTableAdapter.Fill(ProductionDataSet.Actifijo, cAnexo)
    End Sub

    Private Sub txtRFC_LostFocus(sender As Object, e As EventArgs) Handles txtRFC.LostFocus
        If txtRFC.Text.Length = 12 Or txtRFC.Text.Length = 13 Then
            Dim daA69 As New CreditoDSTableAdapters.CRED_Lista_Art69BTableAdapter
            Dim estatus As String = daA69.obt_Est_FillBy(txtRFC.Text)
            If estatus = "Desvirtuado" OrElse estatus = "N" Then
                If MsgBox("¿Desea imprimir el reporte?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                    frmConsultaSAT.txtRFC.Text = txtRFC.Text
                    frmConsultaSAT.txtRFCN.Text = txtRFC.Text
                    frmConsultaSAT.txtNombre.Text = txtProveedor.Text
                    If frmConsultaSAT.txtRFCN.Text.Length = 12 Then
                        frmConsultaSAT.txtTipoPersona.Text = "M"
                    Else
                        frmConsultaSAT.txtTipoPersona.Text = "F"
                    End If
                    frmConsultaSAT.Show()
                    Call frmConsultaSAT.btnEnviar_Click(sender, e)
                End If
            Else
                If MsgBox("El contribuyente presenta un mal comportamiento ante el SAT, ¿Desea imprimir el reporte?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                    frmConsultaSAT.txtRFC.Text = txtRFC.Text
                    frmConsultaSAT.Show()
                    Call Botones(False)
                    Call frmConsultaSAT.btnEnviar_Click(sender, e)
                End If
                Call Botones(False)
            End If
        Else
            MsgBox("Sintáxis incorrecta del RFC", MsgBoxStyle.Exclamation)
            txtRFC.Focus()
        End If
    End Sub
End Class