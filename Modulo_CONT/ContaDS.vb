Imports System.Data.SqlClient
Partial Public Class ContaDS
    Partial Public Class FinanAdicional_CPFDataTable
        Private Sub FinanAdicional_CPFDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.SegmentoNegocioColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub
    End Class
End Class

Namespace ContaDSTableAdapters
    Partial Public Class sp_CONT_RPT_MEZCLATableAdapter
        Public Property CommandTimeout As Int32
            Get
                Return Me.CommandCollection(0).CommandTimeout
            End Get
            Set(value As Int32)
                For Each cmd As SqlCommand In Me.CommandCollection
                    cmd.CommandTimeout = value
                Next
            End Set
        End Property
    End Class
    Partial Public Class DatosAnexoTableAdapter
        Public Property CommandTimeout As Int32
            Get
                Return Me.CommandCollection(0).CommandTimeout
            End Get
            Set(value As Int32)
                For Each cmd As SqlCommand In Me.CommandCollection
                    cmd.CommandTimeout = value
                Next
            End Set
        End Property
    End Class
End Namespace
