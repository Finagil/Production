Option Explicit On 
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Module mActVigenciaTasas

    Public Sub VigenciaTasas()
        ' Las Tasas anteriores a las Actuales Tasas Vigentes se les pondra el parametro C de Caducada
        ' solo un Periodo puede estar Vigente.

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daPeriodos As New SqlDataAdapter(cm1)

        Dim strUpdate As String

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Periodo, FechaInip, FechaFinp, Vigente FROM PeriodoTasas Order by Periodo"
            .Connection = cnAgil
        End With
        daPeriodos.Fill(dsAgil, "Periodos")

        cnAgil.Open()
        strUpdate = "UPDATE PeriodoTasas SET Vigente = 'C'"
        strUpdate = strUpdate & " WHERE Vigente = 'S'"
        cm1 = New SqlCommand(strUpdate, cnAgil)
        cm1.ExecuteNonQuery()

        strUpdate = "UPDATE PeriodoTasas SET Vigente = 'S'"
        strUpdate = strUpdate & " WHERE Vigente = 'N'"
        cm1 = New SqlCommand(strUpdate, cnAgil)
        cm1.ExecuteNonQuery()

        cnAgil.Close()
    End Sub

End Module
