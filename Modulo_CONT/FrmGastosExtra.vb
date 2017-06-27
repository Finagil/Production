Public Class FrmGastosExtra

    Private Sub TxtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtImporte.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not TxtImporte.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCAD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCAD.TextChanged
        If TxtCAD.Text.Length >= 3 Then
            Me.ClientesTableAdapter.Fill(Me.GastosDS.Clientes, TxtCAD.Text)
            CmbClientes_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub CmbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbClientes.SelectedIndexChanged
        If CmbClientes.SelectedIndex >= 0 Then
            Me.Vw_AnexosTableAdapter.Fill(Me.GastosDS.Vw_Anexos, CmbClientes.SelectedValue)
            CargaGrid()
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Me.CONT_GastosExtrasTableAdapter.Update(Me.GastosDS.CONT_GastosExtras)
        Me.CONT_GastosExtrasTableAdapter.Fill(Me.GastosDS.CONT_GastosExtras, CmbAnexo.SelectedValue)
        CargaGrid()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If CmbClientes.SelectedValue < 0 Then
            MessageBox.Show("Falta selecionar Cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CmbClientes.Focus()
            Exit Sub
        End If
        If CmbAnexo.SelectedValue < 0 Then
            MessageBox.Show("Falta Anexo del Cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CmbAnexo.Focus()
            Exit Sub
        End If
        If TxtDescrip.Text.Length <= 0 Then
            MessageBox.Show("Falta descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtDescrip.Focus()
            Exit Sub
        End If
        If Val(TxtImporte.Text) <= 0 Then
            MessageBox.Show("Importe No valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtImporte.Focus()
            Exit Sub
        End If
        Me.CONT_GastosExtrasTableAdapter.Insert(TxtDescrip.Text, TxtImporte.Text, DTFecha.Value.ToString("yyyyMMdd"), False, CmbClientes.SelectedValue, CmbAnexo.SelectedValue)
        CargaGrid()
        TxtImporte.Text = "0.0"
        TxtDescrip.Clear()
    End Sub

    Private Sub CmbAnexo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAnexo.SelectedIndexChanged
        If CmbAnexo.SelectedIndex >= 0 Then
            CargaGrid()
        Else
            TxtTotal.Text = "0.0"
        End If
    End Sub

    Private Sub CargaGrid()
        Me.CONT_GastosExtrasTableAdapter.Fill(Me.GastosDS.CONT_GastosExtras, CmbAnexo.SelectedValue)
        TxtTotal.Text = Me.CONT_GastosExtrasTableAdapter.TotalAnexo(CmbAnexo.SelectedValue)
        TxtTotal.Text = CDec(TxtTotal.Text).ToString("n2")
    End Sub
End Class