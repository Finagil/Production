Option Explicit On 

Imports System.Math

Module mCalcInte

    Public Sub CalcInte(ByVal drFacturas As DataRowCollection, ByRef nTasaFact As Decimal, ByRef nDiasFact As Integer, ByRef nIntReal As Decimal, ByVal cFeven As String, ByVal cAnexo As String, ByVal cFechacon As String, ByVal cLetra As String, ByVal nSaldo As Decimal, ByVal cTipta As String, ByVal nDifer As Decimal)

        Dim drFactura As DataRow
        Dim cAnterior As String = ""
        Dim dAnterior As Date
        Dim dFeven As Date
        Dim nLetra As Byte

        nLetra = Val(cLetra)

        If nLetra = 1 Then
            cAnterior = cFechacon
            dAnterior = CTOD(cAnterior)
            dFeven = CTOD(cFeven)
            nDiasFact = DateDiff(DateInterval.Day, dAnterior, dFeven)
        Else
            For Each drFactura In drFacturas
                If cAnexo = drFactura("Anexo") And Val(drFactura("Letra")) = nLetra - 1 Then
                    cAnterior = drFactura("Feven")
                    dFeven = CTOD(cFeven)
                    dAnterior = CTOD(cAnterior)
                    nDiasFact = IIf(dAnterior < dFeven, DateDiff(DateInterval.Day, dAnterior, dFeven), 0)
                End If
            Next
        End If

        ' Cuando se trata del primer vencimiento de un contrato, se aplica la tasa y el diferencial pactados
        ' en las condiciones del contrato.   Por esta razón, solamente calcula la tasa de facturación para
        ' vencimientos posteriores al primero

        If nLetra > 1 Then
            If cTipta <> "7" Then
                nTasaFact = Trae_tasa_Dia(cTipta, cAnterior, cAnexo)
            End If
        End If
        nTasaFact = nTasaFact + nDifer
        If nDiasFact < 0 Then
            nDiasFact = 0
            nIntReal = 0
        Else
            nIntReal = Round(nSaldo * nTasaFact / 36000 * nDiasFact, 2)
        End If

    End Sub

End Module
