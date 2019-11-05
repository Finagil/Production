
Imports System.Data.SqlClient
Partial Public Class ReportesDS
    Partial Public Class RPT_SaldosPromedioDataTable
        Private Sub RPT_SaldosPromedioDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Fecha_de_PagoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class

Namespace ReportesDSTableAdapters
    Partial Public Class SP_Rpt_CarteraVencidaTableAdapter
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

    Partial Public Class CarteraVencidaRPTTableAdapter
        Public Property Conecciones As String
            Get
                Return Me.CommandCollection(0).Connection.ConnectionString
            End Get
            Set(value As String)
                For Each cmd As SqlCommand In Me.CommandCollection
                    cmd.Connection.ConnectionString = value
                Next
            End Set
        End Property
    End Class

    Partial Public Class CarteraExigibleRPTTableAdapter
        Public Property Conecciones As String
            Get
                Return Me.CommandCollection(0).Connection.ConnectionString
            End Get
            Set(value As String)
                For Each cmd As SqlCommand In Me.CommandCollection
                    cmd.Connection.ConnectionString = value
                Next
            End Set
        End Property
    End Class

    Partial Public Class RPT_SaldosPromedioTableAdapter
        Public Property Conecciones As String
            Get
                Return Me.CommandCollection(0).Connection.ConnectionString
            End Get
            Set(value As String)
                For Each cmd As SqlCommand In Me.CommandCollection
                    cmd.Connection.ConnectionString = value
                Next
            End Set
        End Property
    End Class
End Namespace
