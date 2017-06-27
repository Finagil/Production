Module mCalcAnti

    Public Sub CalcAnti(ByVal cAnexo As String, ByVal cFecha As String, ByRef nMaxCounter As Integer, ByRef nCounter As Integer, ByVal drFacturas As DataRow())

        ' Esta funci�n calcula la antig�edad de todas las facturas no pagadas de este contrato, a fin de determinar
        ' la m�s antig�a de ellas.   Debe recibir como par�metro un DataRowCollection el cual contenga todas las
        ' facturas no pagadas de un contrato dado.

        ' Declaraci�n de variables de conexi�n

        Dim drFactura As DataRow

        ' Declaraci�n de variables de datos

        Dim cFeven As String
        Dim nDiasRetraso As Integer

        If cFecha >= "20000101" Then
            nMaxCounter = 89
        ElseIf cFecha >= "19970101" Then
            nMaxCounter = 90
        ElseIf cFecha >= "19960301" Then
            nMaxCounter = 180
        End If

        nCounter = 0

        For Each drFactura In drFacturas
            cFeven = drFactura("Feven")
            nDiasRetraso = DateDiff(DateInterval.Day, CTOD(cFeven), CTOD(cFecha))
            If nDiasRetraso > nCounter Then
                nCounter = nDiasRetraso
            End If
        Next

    End Sub

End Module
