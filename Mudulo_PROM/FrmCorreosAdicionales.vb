Public Class FrmCorreosAdicionales

    Private Sub FrmCorreosAdicionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesActivosTableAdapter.Fill(Me.PromocionDS.ClientesActivos)
        ComboBox1_SelectedIndexChanged(Nothing, Nothing)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex >= 0 Then
            Me.ClientesActivosTableAdapter.FillByCliente(Me.PromocionDS1.ClientesActivos, ComboBox1.SelectedValue)
            ComboBox2_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex >= 0 Then
            Me.CorreosAnexosTableAdapter.Fill(Me.PromocionDS.CorreosAnexos, ComboBox2.SelectedValue)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As PromocionDS.CorreosAnexosRow
        r = Me.PromocionDS.CorreosAnexos.NewRow
        r.Anexo = ComboBox2.SelectedValue
        r.Correo1 = ""
        r.Correo2 = ""
        Me.PromocionDS.CorreosAnexos.AddCorreosAnexosRow(r)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.PromocionDS.CorreosAnexos.GetChanges()
            Me.CorreosAnexosTableAdapter.Update(Me.PromocionDS.CorreosAnexos)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dataGridView1_CellValidating(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
        Dim headerText As String = DataGridView1.Columns(e.ColumnIndex).HeaderText
        ' Abort validation if cell is not in the CompanyName column.
        If headerText.Equals("Correo1") Then
            If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                DataGridView1.Rows(e.RowIndex).ErrorText = "el correo no puede ir vacio"
                e.Cancel = True
            End If
            If InStr(e.FormattedValue.ToString(), "@") <= 0 Then
                DataGridView1.Rows(e.RowIndex).ErrorText = "No es un correo Valido"
                e.Cancel = True
            End If
        End If
        If headerText.Equals("Correo2") Then
            If e.FormattedValue.ToString.Length > 0 And InStr(e.FormattedValue.ToString(), "@") <= 0 Then
                DataGridView1.Rows(e.RowIndex).ErrorText = "No es un correo Valido"
                e.Cancel = True
            End If
        End If
        ' Confirm that the cell is not empty.

    End Sub

End Class