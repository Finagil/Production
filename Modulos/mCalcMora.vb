Option Explicit On

Imports System.Math

Module mCalcMora

    Public Function CalcMora(ByVal cTipar As String, ByVal cTipo As String, ByVal cFecha As String, ByVal drUdis As DataRowCollection, ByVal nSaldo As Decimal, ByVal nTasaMoratoria As Decimal, ByVal nDiasMoratorios As Decimal, ByRef nMoratorios As Decimal, ByRef nIvaMoratorios As Decimal, ByVal nTasaIVACliente As Decimal) As Decimal

        ' Declaraci�n de variables de datos

        Dim cFechaInicial As String
        Dim dFechaInicial As Date
        Dim nUdiFinal As Decimal
        Dim nUdiInicial As Decimal

        dFechaInicial = DateAdd(DateInterval.Day, -nDiasMoratorios, CTOD(cFecha))
        cFechaInicial = DTOC(dFechaInicial)
        nUdiInicial = 0
        nUdiFinal = 0

        nMoratorios = Round(nSaldo * nTasaMoratoria * (nDiasMoratorios) / 36000, 2)
        nIvaMoratorios = 0

        ' Hasta el 10 de enero de 2010 se calculaba el IVA de los moratorios en base a UDIS sin importar el tipo de financiamiento lo cual era incorrecto.
        ' A partir del 11 de enero solo existe IVA moratorios para :
        ' Arrendamiento Financiero (en base a UDIS) y para
        ' Cr�dito Refaccionario o Cr�dito Simple siempre y cuando se trate de una Persona F�sica SIN actividad empresarial en cuyo caso ser� igual al Porcentaje de IVA vigente 

        If cTipar = "F" Then
            nIvaMoratorios = CalcIvaU(drUdis, nSaldo, nTasaMoratoria, cFechaInicial, cFecha, nUdiInicial, nUdiFinal, (nTasaIVACliente / 100))
        Else
            If cTipo = "F" Then
                If IVA_Interes_TasaReal = False Or cFecha < "20160101" Then 'Enterar IVA Basado en fujo = TRUE o direco sobre base nominal = False #ECT20151015.n
                    nIvaMoratorios = Round(nMoratorios * (nTasaIVACliente / 100), 2)
                Else
                    nIvaMoratorios = CalcIvaU(drUdis, nSaldo, nTasaMoratoria, cFechaInicial, cFecha, nUdiInicial, nUdiFinal, (nTasaIVACliente / 100))
                End If
            End If
        End If

    End Function

End Module
