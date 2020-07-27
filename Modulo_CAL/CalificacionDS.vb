Imports System.Data.SqlClient

Partial Public Class CalificacionDS
End Class

Namespace CalificacionDSTableAdapters
    Partial Public Class DatosConsumoTableAdapter
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

    Partial Public Class AnexosMezclaTableAdapter
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
