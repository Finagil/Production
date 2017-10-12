Public Class FrmCodigoSATConcepto
    Private Sub FrmCodigoSATConcepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductosFinagilTableAdapter.Fill(Me.GeneralDS.ProductosFinagil)
        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProduct.SelectedIndexChanged
        If CmbProduct.SelectedIndex >= 0 Then
            Me.CodigosSAT_ConceptoTableAdapter.Fill(Me.ContaDS.CodigosSAT_Concepto, CmbProduct.SelectedValue)
        Else
            Me.ContaDS.CodigosSAT_Concepto.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            CodigosSATConceptoBindingSource.EndEdit()
            Me.ContaDS.CodigosSAT_Concepto.GetChanges()
            Me.CodigosSAT_ConceptoTableAdapter.Update(Me.ContaDS.CodigosSAT_Concepto)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Códigos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CodigosSATConceptoBindingSource_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles CodigosSATConceptoBindingSource.AddingNew
        Dim row As DataRowView = sender.List.Addnew()
        row("Tipar") = CmbProduct.SelectedValue
        e.NewObject = row
        sender.MoveLast()
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If
    End Sub
End Class