Public Class FrmCapFacturas
    Public cAnexo As String
    Dim Nuevo As Boolean

    Private Sub FrmCapFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If Nuevo = True Then
            Me.ActifijoTableAdapter.Insert(cAnexo, txtFactura.Text, txtProveedor.Text, txtImporte.Text, 0, _
            txtDetalle.Text, 0, txtModelo.Text, txtMotor.Text, txtSerie.Text, txtPlaca.Text _
            , "", "", "", "", "", "", "", "", "")
        Else
            Me.ActifijoTableAdapter.UpdateFACT(txtFactura.Text.Trim, txtProveedor.Text.Trim, txtImporte.Text, txtDetalle.Text.Trim, txtModelo.Text.Trim, txtMotor.Text.Trim, txtSerie.Text.Trim, txtPlaca.Text.Trim, TxtID.Text, cAnexo)
        End If
        Call Botones(False)
        Me.ActifijoTableAdapter.Fill(ProductionDataSet.Actifijo, cAnexo)
    End Sub
End Class