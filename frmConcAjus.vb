' Falta que excluya los contratos que están en Cartera Vencida y que les dé otro tratamiento

Option Explicit On

Imports System.Data.SqlClient
Imports System.Data
Imports System.Math
Imports System.IO

Public Class frmConcAjus

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        ' Este programa debe tomar todos los contratos activos con fecha de contratación menor o igual a la fecha
        ' de proceso.   También debe tomar la tabla de amortización de todos los contratos obtenidos con el 
        ' criterio anterior, tanto la del equipo como la del seguro.   Aunque esto creará un dataset con muchísimos
        ' registros, por otra parte permitirá mantener abierta la conexión únicamente durante el tiempo que tarde
        ' en traer dicha información de la base de datos.

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim cm5 As New SqlCommand()
        Dim cm6 As New SqlCommand()
        Dim cm7 As New SqlCommand()
        Dim cm8 As New SqlCommand()
        Dim cm9 As New SqlCommand()
        Dim cm10 As New SqlCommand()
        Dim cm11 As New SqlCommand()
        Dim daAnexos As New SqlDataAdapter(cm1)
        Dim daEdoctav As New SqlDataAdapter(cm2)
        Dim daEdoctas As New SqlDataAdapter(cm3)
        Dim daEdoctao As New SqlDataAdapter(cm4)
        Dim daUdis As New SqlDataAdapter(cm5)
        Dim daHista As New SqlDataAdapter(cm6)
        Dim daFacturas As New SqlDataAdapter(cm7)
        Dim daOpciones As New SqlDataAdapter(cm8)
        Dim daCobrosxa As New SqlDataAdapter(cm9)
        Dim daFIRA As New SqlDataAdapter(cm10)
        Dim daFINAGIL As New SqlDataAdapter(cm11)
        Dim dsAgil As New DataSet()
        Dim drAnexo As DataRow
        Dim drEdoctav As DataRow
        Dim drEdoctas As DataRow
        Dim drEdoctao As DataRow
        Dim drFactura As DataRow
        Dim drOpcion As DataRow
        Dim drCobrosxa As DataRow
        Dim drTemporal As DataRow
        Dim drMinistracion As DataRow
        Dim dtSaldos As New DataTable("Saldos")
        Dim drSaldo As DataRow
        Dim myColArray(1) As DataColumn
        Dim myKeySearch(0) As String

        ' Declaración de variables de datos

        Dim cAnexo As String
        Dim cCliente As String
        Dim cConcepto As String
        Dim cCuenta As String
        Dim cDescRef As String
        Dim cEncabezado As String
        Dim cFecha As String
        Dim cFondeo As String
        Dim cImporte As String
        Dim cNaturaleza As String
        Dim cRenglon As String
        Dim cTipar As String
        Dim cTipo As String
        Dim lBalance As Boolean
        Dim lOrden As Boolean
        Dim nAdeudoEquipo As Decimal = 0
        Dim nAdeudoOtros As Decimal = 0
        Dim nImpDG As Decimal
        Dim nImporte As Decimal = 0
        Dim nImporteFac As Decimal = 0
        Dim nImportePagado As Decimal = 0
        Dim nImpRD As Decimal
        Dim nIvaCapital As Decimal
        Dim nPlazo As Byte
        Dim nPorieq As Decimal
        Dim nSaldoContable As Decimal = 0
        Dim nSaldoFac As Decimal = 0
        Dim oArchivo As StreamReader
        Dim oBalance As StreamWriter
        Dim oOrden As StreamWriter

        ' Declaración de variables de Crystal Reports

        Dim newrptConcAjus As New rptConcAjus()

        ' Primero creo la tabla dtSaldos

        dtSaldos.Columns.Add("Cuenta", Type.GetType("System.String"))
        dtSaldos.Columns.Add("Cliente", Type.GetType("System.String"))
        dtSaldos.Columns.Add("SaldoSistemas", Type.GetType("System.Decimal"))
        dtSaldos.Columns.Add("SaldoContable", Type.GetType("System.Decimal"))
        dtSaldos.Columns.Add("Naturaleza", Type.GetType("System.String"))

        ' Tengo que definir una llave primaria para la tabla dtSaldos a fin de buscar una cuenta y su anexo
        ' para acumular saldos

        myColArray(0) = dtSaldos.Columns("Cuenta")
        dtSaldos.PrimaryKey = myColArray

        ' Después leo el archivo ANEXOS.TXT el cual contiene los saldos contables

        Try

            oArchivo = New StreamReader("C:\ANEXOS.TXT")

            While (oArchivo.Peek() > -1)

                cRenglon = oArchivo.ReadLine()

                cCuenta = ""
                cNaturaleza = " "

                If Mid(cRenglon, 21, 4) <> "0000" Then

                    Select Case Mid(cRenglon, 5, 10)
                        Case "1301-02-01"               ' Cartera Vigente de Bienes al Comercio
                            cCuenta = "13010201"
                            cNaturaleza = "D"
                        Case "1302-02-01"               ' Cartera Vigente de Bienes al Consumo
                            cCuenta = "13020201"
                            cNaturaleza = "D"
                        Case "1401-02-01"               ' Cartera Vigente Crédito Refaccionario
                            cCuenta = "14010201"
                            cNaturaleza = "D"
                        Case "1402-02-01"               ' Cartera Vigente Crédito de Avío
                            cCuenta = "14020201"
                            cNaturaleza = "D"
                        Case "1402-02-03"               ' Provisión de intereses activos por Avío
                            cCuenta = "14020203"
                            cNaturaleza = "D"
                        Case "1403-02-01"               ' Cartera Vigente Crédito Simple
                            cCuenta = "14030201"
                            cNaturaleza = "D"
                        Case "1403-02-04"               ' Provisión de intereses activos por Garantía Líquida Avío
                            cCuenta = "14030204"
                            cNaturaleza = "D"
                        Case "1301-02-02"               ' Cartera Exigible de Bienes al Comercio
                            cCuenta = "13010202"
                            cNaturaleza = "D"
                        Case "1302-02-02"               ' Cartera Exigible de Bienes al Consumo
                            cCuenta = "13020202"
                            cNaturaleza = "D"
                        Case "1401-02-02"               ' Cartera Exigible Crédito Refaccionario
                            cCuenta = "14010202"
                            cNaturaleza = "D"
                        Case "1403-02-02"               ' Cartera Exigible Crédito Simple
                            cCuenta = "14030202"
                            cNaturaleza = "D"
                        Case "1801-15-03"               ' Equipo en Arrendamiento Puro
                            cCuenta = "18011503"
                            cNaturaleza = "D"
                        Case "2620-01-01"               ' Utilidades por realizar Bienes al Comercio
                            cCuenta = "26200101"
                            cNaturaleza = "A"
                        Case "2620-06-01"               ' Utilidades por realizar Bienes al Consumo
                            cCuenta = "26200601"
                            cNaturaleza = "A"
                        Case "2614-01-01"               ' Utilidades por realizar Créditos Refaccionarios
                            cCuenta = "26140101"
                            cNaturaleza = "A"
                        Case "2614-03-01"               ' Utilidades por realizar Crédito Simple
                            cCuenta = "26140301"
                            cNaturaleza = "A"
                        Case "1501-03-01"               ' Seguros Financiados
                            cCuenta = "15010301"
                            cNaturaleza = "D"
                        Case "1501-03-04"               ' Opciones de Compra por cobrar
                            cCuenta = "15010304"
                            cNaturaleza = "D"
                        Case "1501-03-05"               ' Otros Adeudos
                            cCuenta = "15010305"
                            cNaturaleza = "D"
                        Case "2204-01-02"               ' Saldos Insolutos FIRA
                            cCuenta = "22040102"
                            cNaturaleza = "A"
                        Case "2204-01-03"               ' Saldos Insolutos PARAFINANCIERA
                            cCuenta = "22040103"
                            cNaturaleza = "A"
                        Case "2204-01-05"               ' Saldos Insolutos FIRA Avío      
                            cCuenta = "22040105"
                            cNaturaleza = "A"
                            'Case "6390-02-01"               ' Opciones de Compra al Comercio
                            '    cCuenta = "63900201"
                            'Case "6390-02-02"               ' Opciones de Compra al Consumo
                            '    cCuenta = "63900202"
                            '    If Mid(cRenglon, 17, 4) <> "0000" Then
                            '    End If
                            'Case "6390-03-01"               ' Valor Contrato al Comercio
                            '    cCuenta = "63900301"
                            '    If Mid(cRenglon, 17, 4) <> "0000" Then
                            '    End If
                            'Case "6390-03-02"               ' Valor Contrato al Consumo
                            '    cCuenta = "63900302"
                            '    If Mid(cRenglon, 17, 4) <> "0000" Then
                            '    End If
                            'Case "6390-04-01"               ' Valor Equipo al Comercio
                            '    cCuenta = "63900401"
                            '    If Mid(cRenglon, 17, 4) <> "0000" Then
                            '    End If
                            'Case "6390-04-02"               ' Valor Equipo al Consumo
                            '    cCuenta = "63900402"
                            '    If Mid(cRenglon, 17, 4) <> "0000" Then
                            '    End If
                            'Case "6390-06-01"               ' IVA pendiente de cobro al Comercio
                            '    cCuenta = "63900601"
                            '    If Mid(cRenglon, 17, 4) <> "0000" Then
                            '    End If
                            'Case "6390-06-02"               ' IVA pendiente de cobro al Consumo
                            '    cCuenta = "63900602"
                            '    If Mid(cRenglon, 17, 4) <> "0000" Then
                            '    End If
                    End Select

                    Select Case Mid(cRenglon, 5, 15)
                        Case "2311-01-90-0001"          ' Rentas en Depósito
                            cCuenta = "231101900001"
                            cNaturaleza = "A"
                        Case "2311-01-90-0008"          ' Saldos a favor del cliente
                            cCuenta = "231101900008"
                            cNaturaleza = "A"
                        Case "2311-01-90-0010"          ' Depósitos en Garantía de Arrendamiento Financiero
                            cCuenta = "231101900010"
                            cNaturaleza = "A"
                        Case "2311-01-90-0014"          ' Depósitos en Garantía de Créditos Refaccionarios
                            cCuenta = "231101900014"
                            cNaturaleza = "A"
                    End Select

                End If

                If cCuenta <> "" Then
                    drSaldo = dtSaldos.NewRow()
                    If cCuenta = "231101900001" Or cCuenta = "231101900008" Or cCuenta = "231101900010" Or cCuenta = "231101900014" Then
                        drSaldo("Cuenta") = cCuenta & Mid(cRenglon, 21, 4)
                    Else
                        drSaldo("Cuenta") = cCuenta & Mid(cRenglon, 16, 4) & Mid(cRenglon, 21, 4)
                    End If
                    drSaldo("Cliente") = Mid(cRenglon, 32, 30)
                    drSaldo("SaldoSistemas") = 0
                    drSaldo("SaldoContable") = Mid(cRenglon, 133, 24)
                    drSaldo("Naturaleza") = cNaturaleza
                    dtSaldos.Rows.Add(drSaldo)
                End If

            End While

            oArchivo.Close()
            oArchivo = Nothing

        Catch eException As Exception

            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try


        ' Aquí ya tengo creada la tabla dtSaldos con los saldos contables, por lo que procedo a obtener
        ' los saldos del sistema

        cFecha = DTOC(dtpProceso.Value)

        ' Este Stored Procedure trae todos los contratos de arrendamiento financiero, arrendamiento puro,
        ' crédito refaccionario, crédito simple, que estén activos con fecha de contratación 
        ' menor o igual a la de proceso

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv1"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortización del equipo de todos los contratos de
        ' arrendamiento financiero, arrendamiento puro, crédito refaccionario, crédito simple, 
        ' que estén activos y cuya fecha de contratación sea menor o igual a la de proceso

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv2"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortización del seguro de todos los contratos 
        ' de arrendamiento financiero, arrendamiento puro, crédito refaccionario, crédito simple, 
        ' que estén activos y cuya fecha de contratación sea menor o igual a la de proceso

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv3"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortización de otros adeudos de todos los contratos
        ' de arrendamiento financiero, arrendamiento puro, crédito refaccionario, crédito simple,
        ' que estén activos y cuya fecha de contratación sea menor o igual a la de proceso

        With cm4
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv4"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae el valor de todas las UDIS, ordenadas por vigencia

        With cm5
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TraeUdis1"
            .Connection = cnAgil
        End With

        ' Este Stored Procedure trae el valor de todas las tasas, ordenadas por vigencia y por tasa

        With cm6
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv5"
            .Connection = cnAgil
        End With

        ' Este Stored Procedure trae las facturas vencidas, el pago inicial (sin el 5% Nafin) 
        ' y la opción de compra exigible de los contratos activos o terminados con saldo en rentas

        With cm7
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Repantig1"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure regresa todas las opciones de compra exigibles y no pagadas

        With cm8
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Repantig3"
            .Connection = cnAgil
        End With

        ' Este Stored Procedure regresa todos los cobros por aplicar a favor de los clientes

        With cm9
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Cobrosxa2"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' El siguiente comando trae todas las ministraciones acumuladas que ha cubierto FIRA a FINAGIL

        With cm10
            .CommandType = CommandType.Text
            .CommandText = "SELECT mFIRA.Anexo, Descr, SUM(Importe) AS ImporteMinistrado FROM mFIRA " & _
            "INNER JOIN Avios ON mFIRA.Anexo = Avios.Anexo " & _
            "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " & _
            "WHERE Estado <> 'LIQUIDADO' AND FechaProgramada <= " & "'" & cFecha & "'" & _
            "GROUP BY mFIRA.Anexo, Descr ORDER BY mFIRA.Anexo"
            .Connection = cnAgil
        End With

        ' El siguiente comando trae el saldo insoluto de todas las ministraciones FINAGIL-Productor

        With cm11
            .CommandType = CommandType.Text
            .CommandText = "SELECT Descr, mFINAGIL.Anexo, SUM(SaldoMinistracion) AS Capital, SUM(SaldoGarantia) AS GarantiaLiquida FROM mFINAGIL " & _
            "INNER JOIN Avios ON mFINAGIL.Anexo = Avios.Anexo " & _
            "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " & _
            "WHERE FechaPago <> '' AND LEFT(FechaPago,6) <= '" & Mid(cFecha, 1, 6) & "' " & _
            "GROUP BY Descr, mFINAGIL.Anexo " & _
            "HAVING (SUM(SaldoMinistracion) > 0) " & _
            "ORDER BY mFINAGIL.Anexo"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daAnexos.Fill(dsAgil, "Anexos")
        daEdoctav.Fill(dsAgil, "Edoctav")
        daEdoctas.Fill(dsAgil, "Edoctas")
        daEdoctao.Fill(dsAgil, "Edoctao")
        daFacturas.Fill(dsAgil, "Facturas")
        daOpciones.Fill(dsAgil, "Opciones")
        daCobrosxa.Fill(dsAgil, "Cobrosxa")
        daUdis.Fill(dsAgil, "Udis")
        daHista.Fill(dsAgil, "Hista")
        daFIRA.Fill(dsAgil, "FIRA")
        daFINAGIL.Fill(dsAgil, "FINAGIL")

        ' Calcula el saldo de la cartera vigente tanto de contratos en arrendamiento financiero, arrendamiento puro,
        ' crédito refaccionario y crédito simple (este último incluye la Garantía Líquida del Avío).

        For Each drEdoctav In dsAgil.Tables("Edoctav").Rows

            If drEdoctav("Vencida") <> "S" Then

                If (drEdoctav("Feven") > cFecha And drEdoctav("Indrec") = "S") Or drEdoctav("Nufac") = 0 Then

                    cAnexo = drEdoctav("Anexo")
                    cTipar = drEdoctav("Tipar")
                    cTipo = drEdoctav("Tipo")
                    cCliente = drEdoctav("Descr")

                    If cTipar = "F" Then
                        If cTipo = "M" Or cTipo = "E" Then
                            myKeySearch(0) = "13010201" & Mid(cAnexo, 2, 8)
                        Else
                            myKeySearch(0) = "13020201" & Mid(cAnexo, 2, 8)
                        End If
                    ElseIf cTipar = "P" Then
                        myKeySearch(0) = "18011503" & Mid(cAnexo, 2, 8)
                    ElseIf cTipar = "R" Then
                        myKeySearch(0) = "14010201" & Mid(cAnexo, 2, 8)
                    ElseIf cTipar = "S" Then
                        myKeySearch(0) = "14030201" & Mid(cAnexo, 2, 8)
                    End If

                    ' La siguiente validación la hago por si se creara un nuevo tipo de crédito o financiamiento

                    If InStr("FPRS", cTipar) > 0 Then
                        drTemporal = dtSaldos.Rows.Find(myKeySearch)
                        If drTemporal Is Nothing Then
                            drTemporal = dtSaldos.NewRow()
                            If cTipar = "F" Then
                                If cTipo = "M" Or cTipo = "E" Then
                                    drTemporal("Cuenta") = "13010201" & Mid(cAnexo, 2, 8)
                                Else
                                    drTemporal("Cuenta") = "13020201" & Mid(cAnexo, 2, 8)
                                End If
                            ElseIf cTipar = "P" Then
                                drTemporal("Cuenta") = "18011503" & Mid(cAnexo, 2, 8)
                            ElseIf cTipar = "R" Then
                                drTemporal("Cuenta") = "14010201" & Mid(cAnexo, 2, 8)
                            ElseIf cTipar = "S" Then
                                drTemporal("Cuenta") = "14030201" & Mid(cAnexo, 2, 8)
                            End If
                            drTemporal("Cliente") = cCliente
                            drTemporal("SaldoSistemas") = drEdoctav("Abcap") + drEdoctav("Inter")
                            drTemporal("SaldoContable") = 0
                            drTemporal("Naturaleza") = "D"
                            dtSaldos.Rows.Add(drTemporal)
                        Else
                            drTemporal("Cliente") = cCliente
                            drTemporal("SaldoSistemas") += drEdoctav("Abcap") + drEdoctav("Inter")
                        End If
                    End If

                End If

            End If

        Next

        ' Calcula el saldo de la cartera exigible diferenciando cuánto del saldo de la factura corresponde a
        ' cartera exigible del tipo de financiamiento ó crédito y cuánto corresponde al saldo de otros adeudos
        ' que se contabiliza como cartera exigible de crédito simple a partir de julio 2008

        For Each drFactura In dsAgil.Tables("Facturas").Rows

            cAnexo = drFactura("Anexo")
            cTipar = drFactura("Tipar")
            cTipo = drFactura("Tipo")
            cCliente = drFactura("Descr")

            nImporteFac = drFactura("ImporteFac")
            nSaldoFac = drFactura("SaldoFac")
            nImportePagado = nImporteFac - nSaldoFac

            nAdeudoOtros = drFactura("IvaOt") + drFactura("InteresOt") + drFactura("VarOt") + drFactura("CapitalOt")
            nAdeudoEquipo = nImporteFac - nAdeudoOtros

            If nImportePagado >= nAdeudoOtros Then
                nImportePagado = nImportePagado - nAdeudoOtros
                nAdeudoOtros = 0
            ElseIf nImportePagado < nAdeudoOtros Then
                nAdeudoOtros = nAdeudoOtros - nImportePagado
                nImportePagado = 0
            End If

            nAdeudoEquipo = nAdeudoEquipo - nImportePagado

            If drFactura("Feven") < "20080701" Then
                nAdeudoOtros = 0
                nAdeudoEquipo = nSaldoFac
            End If

            If drFactura("Vencida") <> "S" Then

                If cTipar = "F" Or cTipar = "P" Then
                    If cTipo = "M" Or cTipo = "E" Then
                        myKeySearch(0) = "13010202" & Mid(cAnexo, 2, 8)
                    Else
                        myKeySearch(0) = "13020202" & Mid(cAnexo, 2, 8)
                    End If
                ElseIf cTipar = "R" Then
                    myKeySearch(0) = "14010202" & Mid(cAnexo, 2, 8)
                ElseIf cTipar = "S" Then
                    myKeySearch(0) = "14030202" & Mid(cAnexo, 2, 8)
                End If

                ' La siguiente validación la hago por si se creara un nuevo tipo de crédito o financiamiento

                If InStr("FPRS", cTipar) > 0 Then
                    drTemporal = dtSaldos.Rows.Find(myKeySearch)
                    If drTemporal Is Nothing Then
                        drTemporal = dtSaldos.NewRow()
                        If cTipar = "F" Or cTipar = "P" Then
                            If cTipo = "M" Or cTipo = "E" Then
                                drTemporal("Cuenta") = "13010202" & Mid(cAnexo, 2, 8)
                            Else
                                drTemporal("Cuenta") = "13020202" & Mid(cAnexo, 2, 8)
                            End If
                        ElseIf cTipar = "R" Then
                            drTemporal("Cuenta") = "14010202" & Mid(cAnexo, 2, 8)
                        ElseIf cTipar = "S" Then
                            drTemporal("Cuenta") = "14030202" & Mid(cAnexo, 2, 8)
                        End If
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoSistemas") = nAdeudoEquipo
                        drTemporal("SaldoContable") = 0
                        drTemporal("Naturaleza") = "D"
                        dtSaldos.Rows.Add(drTemporal)
                    Else
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoSistemas") += nAdeudoEquipo
                    End If
                End If

            End If

            If nAdeudoOtros > 0 Then
                myKeySearch(0) = "14030202" & Mid(cAnexo, 2, 8)
                drTemporal = dtSaldos.Rows.Find(myKeySearch)
                If drTemporal Is Nothing Then
                    drTemporal = dtSaldos.NewRow()
                    drTemporal("Cuenta") = "14030202" & Mid(cAnexo, 2, 8)
                    drTemporal("Cliente") = cCliente
                    drTemporal("SaldoSistemas") = nAdeudoOtros
                    drTemporal("SaldoContable") = 0
                    drTemporal("Naturaleza") = "D"
                    dtSaldos.Rows.Add(drTemporal)
                Else
                    drTemporal("Cliente") = cCliente
                    drTemporal("SaldoSistemas") += nAdeudoOtros
                End If
            End If

        Next

        ' Calcula el saldo del seguro financiado de arrendamiento financiero, arrendamiento puro,
        ' crédito refaccionario y crédito simple

        For Each drEdoctas In dsAgil.Tables("Edoctas").Rows
            If (drEdoctas("Feven") > cFecha And drEdoctas("Indrec") = "S") Or drEdoctas("Nufac") = 0 Then
                cAnexo = drEdoctas("Anexo")
                cCliente = drEdoctas("Descr")
                myKeySearch(0) = "15010301" & Mid(cAnexo, 2, 8)
                drTemporal = dtSaldos.Rows.Find(myKeySearch)
                If drTemporal Is Nothing Then
                    drTemporal = dtSaldos.NewRow()
                    drTemporal("Cuenta") = "15010301" & Mid(cAnexo, 2, 8)
                    drTemporal("Cliente") = cCliente
                    drTemporal("SaldoSistemas") = drEdoctas("Abcap")
                    drTemporal("SaldoContable") = 0
                    drTemporal("Naturaleza") = "D"
                    dtSaldos.Rows.Add(drTemporal)
                Else
                    drTemporal("Cliente") = cCliente
                    drTemporal("SaldoSistemas") += drEdoctas("Abcap")
                End If
            End If
        Next

        ' Calcula el saldo insoluto de Otros Adeudos tanto de contratos en arrendamiento financiero,
        ' arrendamiento puro, crédito refaccionario y crédito simple.   Es importante recordar que a partir
        ' de julio 2008 estos adeudos se contabilizarán como cartera vigente de crédito simple.   La renta por
        ' plazo se considera cartera a diferencia de cuando se manejaba como otros adeudos en los que solo se 
        ' contabilizaba el saldo insoluto.   
        
        For Each drEdoctao In dsAgil.Tables("Edoctao").Rows

            If drEdoctao("Vencida") <> "S" Then

                If (drEdoctao("Feven") > cFecha And drEdoctao("Indrec") = "S") Or drEdoctao("Nufac") = 0 Then
                    cAnexo = drEdoctao("Anexo")
                    cCliente = drEdoctao("Descr")
                    myKeySearch(0) = "14030201" & Mid(cAnexo, 2, 8)
                    drTemporal = dtSaldos.Rows.Find(myKeySearch)
                    If drTemporal Is Nothing Then
                        drTemporal = dtSaldos.NewRow()
                        drTemporal("Cuenta") = "14030201" & Mid(cAnexo, 2, 8)
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoSistemas") = drEdoctao("Abcap") + drEdoctao("Inter")
                        drTemporal("SaldoContable") = 0
                        drTemporal("Naturaleza") = "D"
                        dtSaldos.Rows.Add(drTemporal)
                    Else
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoSistemas") += drEdoctao("Abcap") + drEdoctao("Inter")
                    End If

                    ' Ahora debe calcularse también utilidades por realizar de otros
                    ' adeudos (para manejarlo como utilidades por realizar de crédito simple).

                    myKeySearch(0) = "26140301" & Mid(cAnexo, 2, 8)
                    drTemporal = dtSaldos.Rows.Find(myKeySearch)
                    If drTemporal Is Nothing Then
                        drTemporal = dtSaldos.NewRow()
                        drTemporal("Cuenta") = "26140301" & Mid(cAnexo, 2, 8)
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoSistemas") = drEdoctao("Inter")
                        drTemporal("SaldoContable") = 0
                        drTemporal("Naturaleza") = "A"
                        dtSaldos.Rows.Add(drTemporal)
                    Else
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoSistemas") += drEdoctao("Inter")
                    End If

                End If

            End If

        Next

        ' Calcula el saldo de las opciones de compra por cobrar

        For Each drOpcion In dsAgil.Tables("Opciones").Rows

            cAnexo = drOpcion("Anexo")
            cCliente = drOpcion("Descr")
            nPlazo = drOpcion("Plazo")

            If Termina(cAnexo) <= CTOD(cFecha) Then

                ' Se trata de una opción de compra de un contrato terminado, por lo que hay que llevar
                ' a cabo su conciliación

                myKeySearch(0) = "15010304" & Mid(cAnexo, 2, 8)
                drTemporal = dtSaldos.Rows.Find(myKeySearch)
                If drTemporal Is Nothing Then
                    drTemporal = dtSaldos.NewRow()
                    drTemporal("Cuenta") = "15010304" & Mid(cAnexo, 2, 8)
                    drTemporal("Cliente") = cCliente
                    drTemporal("SaldoSistemas") = drOpcion("Opcion") + drOpcion("IvaOpcion")
                    drTemporal("SaldoContable") = 0
                    drTemporal("Naturaleza") = "D"
                    dtSaldos.Rows.Add(drTemporal)
                Else
                    drTemporal("Cliente") = cCliente
                    drTemporal("SaldoSistemas") += drOpcion("Opcion") + drOpcion("IvaOpcion")
                End If

            End If

        Next

        ' Calcula el saldo de las utilidades por realizar tanto de contratos en arrendamiento financiero,
        ' crédito refaccionario y crédito simple ya que para arrendamiento puro no existe el concepto
        ' de utilidades por realizar

        ' AQUÍ TENGO QUE PREGUNTAR SI EXISTE EL CONCEPTO DE UTILIDADES POR REALIZAR DE ARRENDAMIENTO PURO

        For Each drEdoctav In dsAgil.Tables("Edoctav").Rows

            If drEdoctav("Vencida") <> "S" Then

                If (drEdoctav("Feven") > cFecha And drEdoctav("Indrec") = "S") Or drEdoctav("Nufac") = 0 Then

                    cAnexo = drEdoctav("Anexo")
                    cTipar = drEdoctav("Tipar")
                    cTipo = drEdoctav("Tipo")
                    cCliente = drEdoctav("Descr")
                    If cTipar = "F" Then
                        If cTipo = "M" Or cTipo = "E" Then
                            myKeySearch(0) = "26200101" & Mid(cAnexo, 2, 8)
                        Else
                            myKeySearch(0) = "26200601" & Mid(cAnexo, 2, 8)
                        End If
                    ElseIf cTipar = "R" Then
                        myKeySearch(0) = "26140101" & Mid(cAnexo, 2, 8)
                    ElseIf cTipar = "S" Then
                        myKeySearch(0) = "26140301" & Mid(cAnexo, 2, 8)
                    End If

                    ' La siguiente validación la hago por si se creara un nuevo tipo de crédito o financiamiento

                    If InStr("FRS", cTipar) > 0 Then
                        drTemporal = dtSaldos.Rows.Find(myKeySearch)
                        If drTemporal Is Nothing Then
                            drTemporal = dtSaldos.NewRow()
                            If cTipar = "F" Then
                                If cTipo = "M" Or cTipo = "E" Then
                                    drTemporal("Cuenta") = "26200101" & Mid(cAnexo, 2, 8)
                                Else
                                    drTemporal("Cuenta") = "26200601" & Mid(cAnexo, 2, 8)
                                End If
                            ElseIf cTipar = "R" Then
                                drTemporal("Cuenta") = "26140101" & Mid(cAnexo, 2, 8)
                            ElseIf cTipar = "S" Then
                                drTemporal("Cuenta") = "26140301" & Mid(cAnexo, 2, 8)
                            End If
                            drTemporal("Cliente") = cCliente
                            drTemporal("SaldoSistemas") = drEdoctav("Inter")
                            drTemporal("SaldoContable") = 0
                            drTemporal("Naturaleza") = "A"
                            dtSaldos.Rows.Add(drTemporal)
                        Else
                            drTemporal("Cliente") = cCliente
                            drTemporal("SaldoSistemas") += drEdoctav("Inter")
                        End If
                    End If

                End If

            End If

        Next

        ' Calcula el saldo insoluto de los contratos descontados con FIRA

        For Each drEdoctav In dsAgil.Tables("Edoctav").Rows
            If (drEdoctav("Feven") > cFecha And drEdoctav("Indrec") = "S") Or drEdoctav("Nufac") = 0 Then
                cAnexo = drEdoctav("Anexo")
                cFondeo = drEdoctav("Fondeo")
                cCliente = drEdoctav("Descr")
                If cFondeo = "03" Then
                    myKeySearch(0) = "22040102" & Mid(cAnexo, 2, 8)
                    drTemporal = dtSaldos.Rows.Find(myKeySearch)
                    If drTemporal Is Nothing Then
                        drTemporal = dtSaldos.NewRow()
                        drTemporal("Cuenta") = "22040102" & Mid(cAnexo, 2, 8)
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoSistemas") = drEdoctav("Abcap")
                        drTemporal("SaldoContable") = 0
                        drTemporal("Naturaleza") = "A"
                        dtSaldos.Rows.Add(drTemporal)
                    Else
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoSistemas") += drEdoctav("Abcap")
                    End If
                End If
            End If
        Next

        ' Calcula el saldo insoluto de los contratos descontados con PARAFINANCIERA

        For Each drEdoctav In dsAgil.Tables("Edoctav").Rows
            If (drEdoctav("Feven") > cFecha And drEdoctav("Indrec") = "S") Or drEdoctav("Nufac") = 0 Then
                cAnexo = drEdoctav("Anexo")
                cFondeo = drEdoctav("Fondeo")
                cCliente = drEdoctav("Descr")
                If cFondeo = "04" Then
                    myKeySearch(0) = "22040103" & Mid(cAnexo, 2, 8)
                    drTemporal = dtSaldos.Rows.Find(myKeySearch)
                    If drTemporal Is Nothing Then
                        drTemporal = dtSaldos.NewRow()
                        drTemporal("Cuenta") = "22040103" & Mid(cAnexo, 2, 8)
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoSistemas") = drEdoctav("Abcap")
                        drTemporal("SaldoContable") = 0
                        drTemporal("Naturaleza") = "A"
                        dtSaldos.Rows.Add(drTemporal)
                    Else
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoSistemas") += drEdoctav("Abcap")
                    End If
                End If
            End If
        Next

        ' Calcula el saldo de las Rentas en Depósito de contratos en arrendamiento financiero o en
        ' arrendamiento puro.   Además calcula el saldo de los Depósitos en Garantía de crédito
        ' refaccionario o crédito simple

        ' NO SÉ SI LOS DEPÓSITOS EN GARANTÍA DE CRÉDITO SIMPLE SE VAN A CONTABILIZAR EN LA MISMA CUENTA
        ' DE LOS DEPÓSITOS EN GARANTÍA DE CRÉDITO REFACCIONARIO. POR EL MOMENTO CONSIDERÉ QUE SÍ.

        For Each drAnexo In dsAgil.Tables("Anexos").Rows
            cTipar = drAnexo("Tipar")
            If cTipar = "F" Or cTipar = "P" Then
                If drAnexo("RD") > 0 Then
                    cAnexo = drAnexo("Anexo")
                    cCliente = drAnexo("Descr")
                    nImpRD = drAnexo("ImpDG")
                    myKeySearch(0) = "231101900001" & Mid(cAnexo, 2, 4)
                    drTemporal = dtSaldos.Rows.Find(myKeySearch)
                    If drTemporal Is Nothing Then
                        drTemporal = dtSaldos.NewRow()
                        drTemporal("Cuenta") = "231101900001" & Mid(cAnexo, 2, 4)
                        drTemporal("SaldoSistemas") = nImpRD
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoContable") = 0
                        drTemporal("Naturaleza") = "A"
                        dtSaldos.Rows.Add(drTemporal)
                    Else
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoSistemas") += nImpRD
                    End If
                End If
            ElseIf cTipar = "R" Or cTipar = "S" Then
                If drAnexo("DG") > 0 Then
                    cAnexo = drAnexo("Anexo")
                    cCliente = drAnexo("Descr")
                    nImpDG = drAnexo("ImpRD")
                    myKeySearch(0) = "231101900014" & Mid(cAnexo, 2, 4)
                    drTemporal = dtSaldos.Rows.Find(myKeySearch)
                    If drTemporal Is Nothing Then
                        drTemporal = dtSaldos.NewRow()
                        drTemporal("Cuenta") = "231101900014" & Mid(cAnexo, 2, 4)
                        drTemporal("SaldoSistemas") = nImpDG
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoContable") = 0
                        drTemporal("Naturaleza") = "A"
                        dtSaldos.Rows.Add(drTemporal)
                    Else
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoSistemas") += nImpDG
                    End If
                End If
            End If
        Next

        ' Calcula el saldo de los Depósitos en Garantía de contratos en arrendamiento financiero

        For Each drEdoctav In dsAgil.Tables("Edoctav").Rows
            cTipar = drEdoctav("Tipar")
            If cTipar = "F" Then
                If ((drEdoctav("Feven") > cFecha And drEdoctav("Indrec") = "S") Or drEdoctav("Nufac") = 0) And drEdoctav("ImpRD") > 0 Then
                    cAnexo = drEdoctav("Anexo")
                    cCliente = drEdoctav("Descr")
                    nPorieq = drEdoctav("Porieq")
                    myKeySearch(0) = "231101900010" & Mid(cAnexo, 2, 4)
                    drTemporal = dtSaldos.Rows.Find(myKeySearch)
                    If drTemporal Is Nothing Then
                        drTemporal = dtSaldos.NewRow()
                        drTemporal("Cuenta") = "231101900010" & Mid(cAnexo, 2, 4)
                        drTemporal("SaldoSistemas") = Round(drEdoctav("Abcap") / (1 + (nPorieq / 100)) * nPorieq / 100, 2)
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoContable") = 0
                        drTemporal("Naturaleza") = "A"
                        dtSaldos.Rows.Add(drTemporal)
                    Else
                        drTemporal("Cliente") = cCliente
                        drTemporal("SaldoSistemas") += Round(drEdoctav("Abcap") / (1 + (nPorieq / 100)) * nPorieq / 100, 2)
                    End If
                End If
            End If
        Next

        ' Calcula el saldo de los cobros por aplicar a favor de los clientes

        For Each drCobrosxa In dsAgil.Tables("Cobrosxa").Rows
            cAnexo = drCobrosxa("Anexo")
            cCliente = drCobrosxa("Descr")
            myKeySearch(0) = "231101900008" & Mid(cAnexo, 2, 4)
            drTemporal = dtSaldos.Rows.Find(myKeySearch)
            If drTemporal Is Nothing Then
                drTemporal = dtSaldos.NewRow()
                drTemporal("Cuenta") = "231101900008" & Mid(cAnexo, 2, 4)
                drTemporal("Cliente") = cCliente
                drTemporal("SaldoSistemas") = drCobrosxa("Importe")
                drTemporal("SaldoContable") = 0
                drTemporal("Naturaleza") = "A"
                dtSaldos.Rows.Add(drTemporal)
            Else
                drTemporal("Cliente") = cCliente
                drTemporal("SaldoSistemas") += drCobrosxa("Importe")
            End If
        Next

        ' Calcula el Saldo de la Cartera Vigente de Créditos de Avío y de la Garantía Líquida del Avío

        For Each drMinistracion In dsAgil.Tables("FINAGIL").Rows

            cAnexo = drMinistracion("Anexo")
            cCliente = drMinistracion("Descr")

            nImporte = drMinistracion("Capital")
            myKeySearch(0) = "14020201" & Mid(cAnexo, 2, 8)
            drTemporal = dtSaldos.Rows.Find(myKeySearch)
            If drTemporal Is Nothing Then
                drTemporal = dtSaldos.NewRow()
                drTemporal("Cuenta") = "14020201" & Mid(cAnexo, 2, 8)
                drTemporal("Cliente") = cCliente
                drTemporal("SaldoSistemas") = nImporte
                drTemporal("SaldoContable") = 0
                drTemporal("Naturaleza") = "D"
                dtSaldos.Rows.Add(drTemporal)
            Else
                drTemporal("Cliente") = cCliente
                drTemporal("SaldoSistemas") += nImporte
            End If

            nImporte = drMinistracion("GarantiaLiquida")
            myKeySearch(0) = "14030201" & Mid(cAnexo, 2, 8)
            drTemporal = dtSaldos.Rows.Find(myKeySearch)
            If drTemporal Is Nothing Then
                drTemporal = dtSaldos.NewRow()
                drTemporal("Cuenta") = "14030201" & Mid(cAnexo, 2, 8)
                drTemporal("Cliente") = cCliente
                drTemporal("SaldoSistemas") = nImporte
                drTemporal("SaldoContable") = 0
                drTemporal("Naturaleza") = "D"
                dtSaldos.Rows.Add(drTemporal)
            Else
                drTemporal("Cliente") = cCliente
                drTemporal("SaldoSistemas") += nImporte
            End If

        Next

        ' Calcula el Saldo Insoluto FIRA Avío (Pasivo)

        For Each drMinistracion In dsAgil.Tables("FIRA").Rows
            cAnexo = drMinistracion("Anexo")
            cCliente = drMinistracion("Descr")
            nImporte = drMinistracion("ImporteMinistrado")
            myKeySearch(0) = "22040105" & Mid(cAnexo, 2, 8)
            drTemporal = dtSaldos.Rows.Find(myKeySearch)
            If drTemporal Is Nothing Then
                drTemporal = dtSaldos.NewRow()
                drTemporal("Cuenta") = "22040105" & Mid(cAnexo, 2, 8)
                drTemporal("Cliente") = cCliente
                drTemporal("SaldoSistemas") = nImporte
                drTemporal("SaldoContable") = 0
                drTemporal("Naturaleza") = "A"
                dtSaldos.Rows.Add(drTemporal)
            Else
                drTemporal("Cliente") = cCliente
                drTemporal("SaldoSistemas") += nImporte
            End If
        Next

        ' En esta sección se calcula el saldo de algunas cuentas de orden.   Es importante comentar
        ' que solo existen cuentas de orden para los contratos de Arrendamiento Financiero.   Lo primero que se
        ' calcula es el saldo del Valor Contrato tanto al Comercio como al Consumo

        'For Each drEdoctav In dsAgil.Tables("Edoctav").Rows
        '    cTipar = drEdoctav("Tipar")
        '    If cTipar = "F" Then
        '        If (drEdoctav("Feven") > cFecha And drEdoctav("Indrec") = "S") Or drEdoctav("Nufac") = 0 Then
        '            cAnexo = drEdoctav("Anexo")
        '            cTipo = drEdoctav("Tipo")
        '            cCliente = drEdoctav("Descr")
        '            If cTipo = "M" Or cTipo = "E" Then
        '                myKeySearch(0) = "63900301" & Mid(cAnexo, 2, 8)
        '            Else
        '                myKeySearch(0) = "63900302" & Mid(cAnexo, 2, 8)
        '            End If
        '            drTemporal = dtSaldos.Rows.Find(myKeySearch)
        '            If drTemporal Is Nothing Then
        '                drTemporal = dtSaldos.NewRow()
        '                If cTipo = "M" Or cTipo = "E" Then
        '                    drTemporal("Cuenta") = "63900301" & Mid(cAnexo, 2, 8)
        '                Else
        '                    drTemporal("Cuenta") = "63900302" & Mid(cAnexo, 2, 8)
        '                End If
        '                drTemporal("Cliente") = cCliente
        '                drTemporal("SaldoSistemas") = drEdoctav("Abcap") + drEdoctav("Inter")
        '                drTemporal("SaldoContable") = 0
        '                dtSaldos.Rows.Add(drTemporal)
        '            Else
        '                drTemporal("Cliente") = cCliente
        '                drTemporal("SaldoSistemas") += drEdoctav("Abcap") + drEdoctav("Inter")
        '            End If
        '        End If
        '    End If
        'Next

        ' Calcula el saldo del Valor Equipo tanto al Comercio como al Consumo

        'For Each drEdoctav In dsAgil.Tables("Edoctav").Rows
        '    cTipar = drEdoctav("Tipar")
        '    If cTipar = "F" Then
        '        If (drEdoctav("Feven") > cFecha And drEdoctav("Indrec") = "S") Or drEdoctav("Nufac") = 0 Then
        '            cAnexo = drEdoctav("Anexo")
        '            cTipo = drEdoctav("Tipo")
        '            cCliente = drEdoctav("Descr")
        '            If cTipo = "M" Or cTipo = "E" Then
        '                myKeySearch(0) = "63900401" & Mid(cAnexo, 2, 8)
        '            Else
        '                myKeySearch(0) = "63900402" & Mid(cAnexo, 2, 8)
        '            End If
        '            drTemporal = dtSaldos.Rows.Find(myKeySearch)
        '            If drTemporal Is Nothing Then
        '                drTemporal = dtSaldos.NewRow()
        '                If cTipo = "M" Or cTipo = "E" Then
        '                    drTemporal("Cuenta") = "63900401" & Mid(cAnexo, 2, 8)
        '                Else
        '                    drTemporal("Cuenta") = "63900402" & Mid(cAnexo, 2, 8)
        '                End If
        '                drTemporal("Cliente") = cCliente
        '                drTemporal("SaldoSistemas") = drEdoctav("Abcap")
        '                drTemporal("SaldoContable") = 0
        '                dtSaldos.Rows.Add(drTemporal)
        '            Else
        '                drTemporal("Cliente") = cCliente
        '                drTemporal("SaldoSistemas") += drEdoctav("Abcap")
        '            End If
        '        End If
        '    End If
        'Next

        ' Calcula el saldo del IVA pendiente de cobro tanto al Comercio como al Consumo

        'For Each drEdoctav In dsAgil.Tables("Edoctav").Rows
        '    cTipar = drEdoctav("Tipar")
        '    If cTipar = "F" Then
        '        nIvaCapital = drEdoctav("IvaCapital")
        '        If nIvaCapital > 0 Then
        '            If (drEdoctav("Feven") > cFecha And drEdoctav("Indrec") = "S") Or drEdoctav("Nufac") = 0 Then
        '                cAnexo = drEdoctav("Anexo")
        '                cTipo = drEdoctav("Tipo")
        '                cCliente = drEdoctav("Descr")
        '                If cTipo = "M" Or cTipo = "E" Then
        '                    myKeySearch(0) = "63900601" & Mid(cAnexo, 2, 8)
        '                Else
        '                    myKeySearch(0) = "63900602" & Mid(cAnexo, 2, 8)
        '                End If
        '                drTemporal = dtSaldos.Rows.Find(myKeySearch)
        '                If drTemporal Is Nothing Then
        '                    drTemporal = dtSaldos.NewRow()
        '                    If cTipo = "M" Or cTipo = "E" Then
        '                        drTemporal("Cuenta") = "63900601" & Mid(cAnexo, 2, 8)
        '                    Else
        '                        drTemporal("Cuenta") = "63900602" & Mid(cAnexo, 2, 8)
        '                    End If
        '                    drTemporal("Cliente") = cCliente
        '                    drTemporal("SaldoSistemas") = nIvaCapital
        '                    drTemporal("SaldoContable") = 0
        '                    dtSaldos.Rows.Add(drTemporal)
        '                Else
        '                    drTemporal("Cliente") = cCliente
        '                    drTemporal("SaldoSistemas") += nIvaCapital
        '                End If
        '            End If
        '        End If
        '    End If
        'Next

        ' Calcula el saldo de las Opciones de Compra

        'For Each drAnexo In dsAgil.Tables("Anexos").Rows
        '    cTipar = drAnexo("Tipar")
        '    If cTipar = "F" Then
        '        cAnexo = drAnexo("Anexo")
        '        cTipo = drAnexo("Tipo")
        '        cCliente = drAnexo("Descr")
        '        If cTipo = "M" Or cTipo = "E" Then
        '            myKeySearch(0) = "63900201" & Mid(cAnexo, 2, 8)
        '        Else
        '            myKeySearch(0) = "63900202" & Mid(cAnexo, 2, 8)
        '        End If
        '        drTemporal = dtSaldos.Rows.Find(myKeySearch)
        '        If drTemporal Is Nothing Then
        '            drTemporal = dtSaldos.NewRow()
        '            If cTipo = "M" Or cTipo = "E" Then
        '                drTemporal("Cuenta") = "63900201" & Mid(cAnexo, 2, 8)
        '            Else
        '                drTemporal("Cuenta") = "63900202" & Mid(cAnexo, 2, 8)
        '            End If
        '            drTemporal("Cliente") = cCliente
        '            drTemporal("SaldoSistemas") = drAnexo("Opcion")
        '            drTemporal("SaldoContable") = 0
        '            dtSaldos.Rows.Add(drTemporal)
        '        Else
        '            drTemporal("Cliente") = cCliente
        '            drTemporal("SaldoSistemas") += drAnexo("Opcion")
        '        End If
        '    End If
        'Next

        dsAgil.Tables.Remove("Anexos")
        dsAgil.Tables.Remove("Edoctav")
        dsAgil.Tables.Remove("Edoctas")
        dsAgil.Tables.Remove("Edoctao")
        dsAgil.Tables.Remove("Facturas")
        dsAgil.Tables.Remove("Opciones")
        dsAgil.Tables.Remove("Cobrosxa")
        dsAgil.Tables.Remove("Udis")
        dsAgil.Tables.Remove("Hista")
        dsAgil.Tables.Add(dtSaldos)

        ' Aquí llevo a cabo la cancelación de SALDOS menores o iguales a 10 pesos

        lBalance = False
        lOrden = False

        For Each drTemporal In dtSaldos.Rows
            cCuenta = drTemporal("Cuenta")
            nSaldoContable = drTemporal("SaldoContable")
            cNaturaleza = drTemporal("Naturaleza")
            cImporte = Stuff(Trim(Abs(nSaldoContable).ToString), "D", " ", 20)
            If Mid(cCuenta, 1, 12) = "231101900001" Or Mid(cCuenta, 1, 12) = "231101900008" Or Mid(cCuenta, 1, 12) = "231101900010" Or Mid(cCuenta, 1, 12) = "231101900014" Then
                cDescRef = "0" & Mid(cCuenta, 13, 4) & "/0000"
            Else
                cDescRef = "0" & Mid(cCuenta, 9, 4) & "/" & Mid(cCuenta, 13, 4)
            End If

            If nSaldoContable <> 0 And Abs(nSaldoContable) <= 10 Then

                If Mid(cCuenta, 1, 1) <> "6" Then

                    ' Se trata de una cuenta de Balance por lo que hay que revisar si es el 
                    ' primer registro que se encuentra para crear el archivo de salida

                    If lBalance = False Then
                        cConcepto = "AJUSTE DE SALDOS MENORES O IGUALES A 10 PESOS                                                       "
                        cEncabezado = "P  " & cFecha & "    3 " & "      " & "100" & " 1 0          " & cConcepto & " 11 0 0 "
                        oBalance = New StreamWriter("C:\PD100.TXT")
                        oBalance.WriteLine(cEncabezado)
                        lBalance = True
                    End If

                Else

                    If lOrden = False Then
                        cConcepto = "AJUSTE DE SALDOS MENORES O IGUALES A 10 PESOS                                                       "
                        cEncabezado = "P  " & cFecha & "    4 " & "      " & "100" & " 1 0          " & cConcepto & " 11 0 0 "
                        oOrden = New StreamWriter("C:\PO100.TXT")
                        oOrden.WriteLine(cEncabezado)
                        lOrden = True
                    End If

                End If

                If nSaldoContable > 0 Then
                    If cNaturaleza = "D" Then
                        cRenglon = "M  " & cCuenta & "               " & cDescRef & " 1 " & cImporte & " 0          0.0" & Space(124)
                    Else
                        cRenglon = "M  " & cCuenta & "               " & cDescRef & " 0 " & cImporte & " 0          0.0" & Space(124)
                    End If
                    If Mid(cCuenta, 1, 1) <> "6" Then
                        oBalance.WriteLine(cRenglon)
                    Else
                        oOrden.WriteLine(cRenglon)
                    End If
                    Select Case Mid(cCuenta, 1, 6)
                        Case "639002"                       ' Opciones de Compra
                            cCuenta = "6690020000000000"
                        Case "639003"                       ' Valor Contrato
                            cCuenta = "6690030000000000"
                        Case "639004"                       ' Valor Equipo
                            cCuenta = "6690040000000000"
                        Case "639006"                       ' IVA pendiente de cobro
                            cCuenta = "6690060000000000"
                        Case Else
                            cCuenta = "5211909000000000"
                    End Select
                    If cNaturaleza = "D" Then
                        cRenglon = "M  " & cCuenta & "               " & cDescRef & " 0 " & cImporte & " 0          0.0" & Space(124)
                    Else
                        cRenglon = "M  " & cCuenta & "               " & cDescRef & " 1 " & cImporte & " 0          0.0" & Space(124)
                    End If
                    If Mid(cCuenta, 1, 1) <> "6" Then
                        oBalance.WriteLine(cRenglon)
                    Else
                        oOrden.WriteLine(cRenglon)
                    End If
                Else
                    If cNaturaleza = "D" Then
                        cRenglon = "M  " & cCuenta & "               " & cDescRef & " 0 " & cImporte & " 0          0.0" & Space(124)
                    Else
                        cRenglon = "M  " & cCuenta & "               " & cDescRef & " 1 " & cImporte & " 0          0.0" & Space(124)
                    End If
                    If Mid(cCuenta, 1, 1) <> "6" Then
                        oBalance.WriteLine(cRenglon)
                    Else
                        oOrden.WriteLine(cRenglon)
                    End If
                    Select Case Mid(cCuenta, 1, 6)
                        Case "639002"                       ' Opciones de Compra
                            cCuenta = "6690020000000000"
                        Case "639003"                       ' Valor Contrato
                            cCuenta = "6690030000000000"
                        Case "639004"                       ' Valor Equipo
                            cCuenta = "6690040000000000"
                        Case "639006"                       ' IVA pendiente de cobro
                            cCuenta = "6690060000000000"
                        Case Else
                            cCuenta = "5211909000000000"
                    End Select
                    If cNaturaleza = "D" Then
                        cRenglon = "M  " & cCuenta & "               " & cDescRef & " 1 " & cImporte & " 0          0.0" & Space(124)
                    Else
                        cRenglon = "M  " & cCuenta & "               " & cDescRef & " 0 " & cImporte & " 0          0.0" & Space(124)
                    End If
                    If Mid(cCuenta, 1, 1) <> "6" Then
                        oBalance.WriteLine(cRenglon)
                    Else
                        oOrden.WriteLine(cRenglon)
                    End If
                End If
            End If
        Next

        If lBalance = True Then
            oBalance.Close()
        End If

        If lOrden = True Then
            oOrden.Close()
        End If

        ' Descomentar la siguiente línea en caso de que se deseara modificar el reporte rptConcajus
        ' dsAgil.WriteXml("C:\Schema41.xml", XmlWriteMode.WriteSchema)

        newrptConcAjus.SetDataSource(dsAgil)
        CrystalReportViewer1.ReportSource = newrptConcAjus

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
        cm4.Dispose()
        cm5.Dispose()
        cm6.Dispose()
        cm7.Dispose()
        cm8.Dispose()
        cm9.Dispose()
        cm10.Dispose()
        cm11.Dispose()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class