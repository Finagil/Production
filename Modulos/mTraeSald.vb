' Este programa calcula el saldo insoluto, la carga financiera por devengar, así como la cartera total.
' Utiliza como parámetros: la fecha de proceso, un DataRowCollection el cual contiene la tabla de amortización de 
' un solo contrato.

Option Explicit On

Imports System.Math

Module mTraeSald

    Public Sub TraeSald(ByVal drVencimientos As DataRow(), ByVal cFeven As String, ByRef nSaldo As Decimal, ByRef nInteres As Decimal, ByRef nCartera As Decimal, TablaEQ As Boolean, ByVal cTipar As String)
        Dim drVencimiento As DataRow
        ''esta parte trae la opcion a compra no pagada del Arrendamiento puro
        'If drVencimientos.Length > 0 Then
        '    drVencimiento = drVencimientos(0)
        '    If cTipar = "P" Then
        '        Dim Ta As New ProductionDataSetTableAdapters.OpcionesTableAdapter
        '        If Ta.SacaOpcion(drVencimiento("Anexo")) > 0 And TablaEQ = True Then
        '            nSaldo = Ta.SacaOpcion(drVencimiento("Anexo"))
        '        End If
        '    End If
        'End If

        ' Esta variable datarow contendrá los datos de 1 vencimiento a la vez, de la tabla Edoctav, Edoctas o Edoctao

        For Each drVencimiento In drVencimientos
            If (drVencimiento("Feven") >= cFeven And drVencimiento("IndRec") = "S") Or drVencimiento("Nufac") = 0 Then
                If cTipar = "P" Then
                    If nSaldo = 0 Then
                        nSaldo = drVencimiento("Saldo") ' toma el saldo insuoluto de la tabla no facturado
                    End If
                Else
                    nSaldo += drVencimiento("Abcap")
                End If
                nInteres += drVencimiento("Inter")
                nCartera += drVencimiento("Abcap") + drVencimiento("Inter")
            End If
        Next
        nSaldo = Round(nSaldo, 2)
        nInteres = Round(nInteres, 2)
        nCartera = Round(nCartera, 2)
    End Sub

End Module
