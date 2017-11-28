Public Class FrmCapFacturas
    Public cAnexo As String
    Dim Nuevo As Boolean

    Private Sub FrmCapFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ContaDS.CFDI_ConceptosActivoFijo' Puede moverla o quitarla según sea necesario.
        Me.CFDI_ConceptosActivoFijoTableAdapter.Fill(Me.ContaDS.CFDI_ConceptosActivoFijo)
        Call Botones(False)
        Me.ActifijoTableAdapter.Fill(ProductionDataSet.Actifijo, cAnexo)
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


End Class