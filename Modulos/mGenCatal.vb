Option Explicit On 

Imports System.Data.SqlClient
Imports System.IO

Module mGenCatal
    Dim ta As New ProductionDataSetTableAdapters.ClientesActivosTableAdapter
    Public Sub GenCatal()

        ' Declaración de variables de conexión ADO .NET

        Dim cn As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daCatalogo As New SqlDataAdapter(cm1)
        Dim dsCatalogo As New DataSet()
        Dim drCuenta As DataRow
        Dim strUpdate As String

        ' Declaración de variables de datos

        Dim cCuenta As String
        Dim fs As FileStream
        Dim oCatalogo As StreamWriter

        ' Este Stored Procedure trae del Catálogo de Cuentas las cuentas que no han sido dadas de alta en ContPaq

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Catalogo2"
            .Connection = cn
        End With

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daCatalogo.Fill(dsCatalogo, "Catalogo")

        fs = New FileStream("C:\Files\CATALOGO.TXT", FileMode.Create)
        oCatalogo = New StreamWriter(fs, System.Text.Encoding.ASCII)
        oCatalogo.WriteLine("F  1103000000000000               ")

        For Each drCuenta In dsCatalogo.Tables("Catalogo").Rows()
            cCuenta = drCuenta("Id")
            cCuenta = cCuenta & drCuenta("Acc")
            cCuenta = cCuenta & drCuenta("AccName")
            cCuenta = cCuenta & drCuenta("OtherName")
            cCuenta = cCuenta & drCuenta("AccAditive")
            cCuenta = cCuenta & drCuenta("AccType")
            cCuenta = cCuenta & drCuenta("AccStatus")
            cCuenta = cCuenta & drCuenta("ClaveFinan")
            cCuenta = cCuenta & drCuenta("AccFlow")
            cCuenta = cCuenta & drCuenta("StatusDate")
            cCuenta = cCuenta & drCuenta("AccSource")
            cCuenta = cCuenta & drCuenta("AccCoin")
            cCuenta = cCuenta & drCuenta("Agrupador")
            cCuenta = cCuenta & drCuenta("IdSegNeg")
            cCuenta = cCuenta & drCuenta("SegNegMovto")
            cCuenta = cCuenta & " 0 " & AgrupadorSAT(Mid(drCuenta("Acc"), 1, 8), "0" & Mid(drCuenta("Acc"), 9, 8), Mid(drCuenta("Acc"), 9, 4))
            oCatalogo.WriteLine(cCuenta)
        Next
        oCatalogo.Close()
        oCatalogo = Nothing

        cn.Open()
        strUpdate = "UPDATE Catalogo SET Alta = 'S' WHERE Alta = 'N'"
        cm1 = New SqlCommand(strUpdate, cn)
        cm1.ExecuteNonQuery()
        cn.Close()
        cn = Nothing

    End Sub

    Function AgrupadorSAT(ByVal Cuenta As String, ByVal Anexo As String, ByVal Pasivo As String) As String
        If ta.EsRelacionado(Anexo) <= 0 Then ' NO ES RELACIONADO
            Select Case Cuenta
                Case "17010101"
                    AgrupadorSAT = "115.01"
                Case "13190102", "15010317"
                    AgrupadorSAT = "106.1"
                Case "13010202", "13020202", "14010202", "14020202", "14030202", "14040202", "14020201", "14020203"
                    AgrupadorSAT = "106.01"
                Case "13010201", "13020201", "14010201", "14030201", "14040201", "26140101", "26140301", "26200101", "26200601"
                    AgrupadorSAT = "186.01"
                Case "15010301", "15010302", "15010304", "15010306", "15010307", "15010308", "15010309"
                    AgrupadorSAT = "106.01"
                Case "22040105", "22040108", "22040205", "22040208"
                    AgrupadorSAT = "202.01"
                Case "18011503"
                    AgrupadorSAT = "154.01"
                Case "18011501"
                    AgrupadorSAT = "155.01"
                Case "18011504"
                    AgrupadorSAT = "156.01"
                Case "18011505"
                    AgrupadorSAT = "153.01"
                Case "18011506"
                    AgrupadorSAT = "169.01"
                Case "23110190"
                    Select Case Cuenta & Pasivo
                        Case "231101900001", "231101900009", "231101900010", "231101900014"
                            AgrupadorSAT = "205.02"
                        Case "231101900020"
                            AgrupadorSAT = "218.01"
                        Case "231101900019", "231101900023"
                            AgrupadorSAT = "205.02"
                    End Select
                Case Else
                    AgrupadorSAT = "000.00"
            End Select
        Else
            Select Case Cuenta
                Case "17010101"
                    AgrupadorSAT = "115.01"
                Case "13190102", "15010317"
                    AgrupadorSAT = "106.3"
                Case "13010202", "13020202", "14010202", "14020202", "14030202", "14040202", "14020201", "15010301", "15010302", "15010304", "15010306", "15010307", "15010308", "15010309"
                    AgrupadorSAT = "106.03"
                Case "13010201", "13020201", "14010201", "14030201", "26140101", "26140301", "26200101", "26200601"
                    AgrupadorSAT = "186.03"
                Case "23110190"
                    Select Case Cuenta & Pasivo
                        Case "231101900001", "231101900009", "231101900010", "231101900014", "231101900019", "231101900023"
                            AgrupadorSAT = "205.04"
                    End Select
                Case Else
                    AgrupadorSAT = "000.00"
            End Select
        End If
        Return AgrupadorSAT
    End Function

End Module




