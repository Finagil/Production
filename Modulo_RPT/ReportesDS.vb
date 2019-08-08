
Imports System.Data.SqlClient
Partial Public Class ReportesDS
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
End Namespace
