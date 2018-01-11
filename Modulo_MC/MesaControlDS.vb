Partial Class MesaControlDS
    Partial Public Class Cambio_condicionesDataTable
        Private Sub Cambio_condicionesDataTable_Cambio_condicionesRowChanging(sender As Object, e As Cambio_condicionesRowChangeEvent) Handles Me.Cambio_condicionesRowChanging

        End Sub

    End Class

    Partial Public Class AviosMCDataTable
        Private Sub AviosMCDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CicloColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
    Partial Class HojaTasaDataTable

        Private Sub HojaTasaDataTable_HojaTasaRowChanging(ByVal sender As System.Object, ByVal e As HojaTasaRowChangeEvent) Handles Me.HojaTasaRowChanging

        End Sub

    End Class

End Class
