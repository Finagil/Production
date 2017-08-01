Option Explicit On 

Imports System.Data.SqlClient
Imports System.IO

Module mGenCatal
    Dim ta As New ProductionDataSetTableAdapters.ClientesActivosTableAdapter
    Dim daCatalogo As New ContaDSTableAdapters.Catalogo2TableAdapter
    Dim SAT As New ContaDSTableAdapters.AgrupadorSATTableAdapter
    Dim ds As New ContaDS
    Public Sub GenCatal()
        Dim fs As FileStream
        Dim oCatalogo As StreamWriter
        Dim Linea As String

        daCatalogo.Fill(ds.Catalogo2)

        fs = New FileStream("C:\Files\CATALOGO.TXT", FileMode.Create)
        oCatalogo = New StreamWriter(fs, System.Text.Encoding.ASCII)
        oCatalogo.WriteLine("F  1103000000000000               ")

        For Each r As ContaDS.Catalogo2Row In ds.Catalogo2.Rows()
            Linea = r("Id") & r("Acc") & r("AccName") & r("OtherName") & r("AccAditive") & r("AccType") & r("AccStatus") & r("ClaveFinan") _
            & r("AccFlow") & r("StatusDate") & r("AccSource") & r("AccCoin") & r("Agrupador") & r("IdSegNeg") & r("SegNegMovto") _
            & " 0 " & AgrupadorSAT(Mid(r("Acc"), 1, 8), "0" & Mid(r("Acc"), 9, 8), Mid(r("Acc"), 9, 4))
            oCatalogo.WriteLine(Linea)
        Next
        oCatalogo.Close()
        oCatalogo = Nothing
        daCatalogo.UpdateCatalogo()


    End Sub

    Function AgrupadorSAT(ByVal Cuenta As String, ByVal Anexo As String, ByVal Pasivo As String) As String
        Dim EsRela As Integer = ta.EsRelacionado(Anexo)
        Dim r As ContaDS.AgrupadorSATRow

        If Cuenta = "23110190" Then
            SAT.Fill(ds.AgrupadorSAT, Cuenta & Pasivo)
        Else
            SAT.Fill(ds.AgrupadorSAT, Cuenta)
        End If

        If ds.AgrupadorSAT.Rows.Count > 0 Then
            r = ds.AgrupadorSAT.Rows(0)
            If EsRela > 0 Then
                AgrupadorSAT = r.PR
            Else
                AgrupadorSAT = r.NPR
            End If
        Else
            AgrupadorSAT = "000.00"
        End If
        Return AgrupadorSAT
    End Function

End Module




