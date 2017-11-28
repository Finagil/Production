Public Class FrmCFDIConcepActiFij
    Private Sub FrmCFDIConcepActiFij_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CFDI_ConceptosActivoFijoTableAdapter.Fill(Me.ContaDS.CFDI_ConceptosActivoFijo)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CFDIConceptosActivoFijoBindingSource.EndEdit()
        'Me.ContaDS.CFDI_ConceptosActivoFijo.AcceptChanges()
        Me.CFDI_ConceptosActivoFijoTableAdapter.Update(Me.ContaDS.CFDI_ConceptosActivoFijo)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As ContaDS.CFDI_ConceptosActivoFijoRow
        r = Me.ContaDS.CFDI_ConceptosActivoFijo.NewCFDI_ConceptosActivoFijoRow()
        Me.ContaDS.CFDI_ConceptosActivoFijo.AddCFDI_ConceptosActivoFijoRow(r)
        Me.CFDIConceptosActivoFijoBindingSource.MoveLast()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not IsNothing(Me.CFDIConceptosActivoFijoBindingSource.Current()) Then
            If MessageBox.Show("¿Esta Seguro de Eliminar el Registro?", "Eiminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.CFDIConceptosActivoFijoBindingSource.RemoveCurrent()
            End If
        End If
    End Sub
End Class