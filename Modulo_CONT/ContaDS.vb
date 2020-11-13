

Partial Public Class ContaDS
    Partial Public Class FinanAdicional_CPFDataTable
        Private Sub FinanAdicional_CPFDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.SegmentoNegocioColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class
