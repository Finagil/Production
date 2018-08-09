' Este programa recibe como parámetro el DataSet dsAgil, el cual contiene las siguientes tablas:

' FechaAltas            que son los diferentes días en que hubo Alta de Operaciones
' FechaTraspasos        que son los diferentes días en que hubo Traspasos de Cartera
' FechaSeguros          que son los diferentes días en que cargarmos seguros financiados
' FechaProgramada       que son los diferentes días en que FIRA nos fondeó recursos
' FechaEgresos          que son los diferentes días en que FINAGIL le hizo pagos a FIRA
' Catalogo              que es el Catálogo de Cuentas Contables
' Clientes              que es una copia de la tabla Clientes
' Interfase             que es la Interfase Contable

' Este parámetro se recibe por referencia para poder actualizar la tabla Catalogo

Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO

Module mGeneraPoliza
    Dim CFDI_ta As New ContaDSTableAdapters.Datos_CFDITableAdapter
    Dim CFDI_t As New ContaDS.Datos_CFDIDataTable
    Dim TC As New ContaDSTableAdapters.TiposDeCambioTableAdapter
    Public Sub GeneraPoliza(ByVal Tipmov As String, ByVal cConceptoPoliza As String, ByVal cFecha As String, ByRef nPoliza As Integer, ByRef dsAgil As DataSet)

        ' Declaración de variables de conexión ADO .NET
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daMovimientos As New SqlDataAdapter(cm1)
        Dim dsPoliza As New DataSet()
        Dim drCliente As DataRow
        Dim drCuenta As DataRow
        Dim drMovimiento As DataRow
        Dim drMovimientos As DataRowCollection
        Dim drTemporal As DataRow
        Dim myKeySearch(1) As String

        ' Declaración de variables de datos

        Dim cAccName As String = ""
        Dim cAnexo As String = ""
        Dim cAplicacion As String = ""
        Dim cBanco As String = ""
        Dim cCatalogo As String = ""
        Dim cCoa As String = ""
        Dim cConcepto As String = ""
        Dim cCuenta As String = ""
        Dim cCuentaAbuelo As String = ""
        Dim cCuentaPadre As String = ""
        Dim cCve As String = ""
        Dim cDescRef As String = ""
        Dim cDescripcion As String = ""
        Dim cEncabezado As String = ""
        Dim cImporte As String = ""
        Dim cImporteME As String = ""
        Dim cidDirario As String = "0"
        Dim cNivelFinal As String = ""
        Dim cNivelInicial As String = ""
        Dim cReferencia As String = ""
        Dim cRenglon As String = ""
        Dim cSegmento As String = ""
        Dim cTipar As String = ""
        Dim cTiparORG As String = ""
        Dim cTipeq As String = ""
        Dim cTipo As String = ""
        Dim cTipoCliente As String = ""
        Dim nImp As Decimal = 0
        Dim nImpME As Decimal = 0
        Dim nTipoCambio As Decimal = 0
        Dim i As Byte = 0
        Dim j As Byte = 0
        Dim lHijo As Boolean
        Dim oBalance As StreamWriter
        Dim UUID As String = ""

        ' 01 Ingresos de Avío y Cuenta Corriente                        OK
        ' 02 Alta de Operaciones de Bienes al Comercio
        ' 03 Alta de Operaciones de Bienes al Consumo
        ' 04 Alta de Operaciones Arrendamiento Puro
        ' 05 Alta de Créditos Refaccionarios
        ' 06 Alta de Créditos Simples
        ' 07 Aplicación de Saldos a favor
        ' 08 Provisión de intereses activos
        ' 09 Traspasos de Cartera
        ' 10 Seguros Financiados
        ' 11 Fondeo FIRA
        ' 12 Alta de Créditos de Avío y Cuenta Corriente                OK
        ' 13 Provisión de Intereses Pasivos con FIRA
        ' 14 Provisión de Intereses Activos (Avío)
        ' 15 Provisión de Intereses Activos (Garantía Líquida Avío)
        ' 16 Financiamiento Adicional otorgado por FIRA
        ' 17 Intereses pasivos pagados a FIRA
        ' 18 Pagos a FIRA
        ' 20 IVA DEVENGADO
        ' 21 cartera VECNIDA
        ' 22 cuentas de orden
        ' 23 Garantias Ejercidas
        ' 24 Recepcion de Fondeo no fira
        ' 25 Liquidacion de Fondeo no fira
        ' 26 Provision de Fondeo no fira

        ' Este comando trae todos los movimientos que se generaron para un proceso en particular en una fecha determinada

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Auxiliar.Cve, Auxiliar.Anexo, Auxiliar.Cliente, Auxiliar.Imp, Auxiliar.Tipar, Auxiliar.Coa, Auxiliar.Fecha, Auxiliar.Tipmov, " &
                           "    Auxiliar.Banco,Auxiliar.Concepto, Auxiliar.Segmento, ISNULL(Vw_AnexosResumen.Tipar,'') AS TiparORG " &
                           "FROM CONT_Auxiliar Auxiliar LEFT OUTER JOIN Vw_AnexosResumen ON Auxiliar.Anexo = Vw_AnexosResumen.Anexo " &
                           "WHERE Tipmov = '" & Tipmov & "' AND Fecha = '" & cFecha & "' " &
                           "ORDER BY Anexo, Coa, Cve"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daMovimientos.Fill(dsPoliza, "Movimientos")
        drMovimientos = dsPoliza.Tables("Movimientos").Rows

        If drMovimientos.Count > 0 Then
            Select Case Tipmov
                Case "01" ' comentado por que se procesa en otra funsion
                    'cEncabezado = "P  " & cFecha & "    1" & Space(10 - Len(nPoliza.ToString)) & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                    'oBalance = New StreamWriter("C:\FILES\PI_" & LTrim((nPoliza).ToString) & ".txt")
                Case "11" ' Recepcion Fondeo FIRA 
                    oBalance = New StreamWriter("C:\FILES\PI_FIRA" & LTrim((nPoliza).ToString) & ".txt")
                    cEncabezado = "P  " & cFecha & "   13" & Space(10 - nPoliza.ToString.Length) & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                Case "24" ' Recepcion fondeo NO FIRA
                    oBalance = New StreamWriter("C:\FILES\PI_NOFIRA" & LTrim((nPoliza).ToString) & ".txt")
                    cEncabezado = "P  " & cFecha & "   13" & Space(10 - nPoliza.ToString.Length) & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                Case "18" ' Pagos a FIRA 
                    oBalance = New StreamWriter("C:\FILES\PE_FIRA" & LTrim((nPoliza).ToString) & ".txt")
                    cEncabezado = "P  " & cFecha & "   12" & Space(10 - nPoliza.ToString.Length) & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                Case "25" ' Pagos a NO fira
                    oBalance = New StreamWriter("C:\FILES\PE_NOFIRA" & LTrim((nPoliza).ToString) & ".txt")
                    cEncabezado = "P  " & cFecha & "   12" & Space(10 - nPoliza.ToString.Length) & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                Case "22" ' Cuentas de orden
                    oBalance = New StreamWriter("C:\FILES\PO" & LTrim((nPoliza).ToString) & ".txt")
                    cEncabezado = "P  " & cFecha & "   13" & Space(10 - nPoliza.ToString.Length) & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                Case "26" ' provision
                    cEncabezado = "P  " & cFecha & "   15" & Space(10 - Len(nPoliza.ToString)) & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                    oBalance = New StreamWriter("C:\FILES\PD_NOFIRA" & LTrim(nPoliza.ToString) & ".txt")
                Case "13", "16", "18"
                    cEncabezado = "P  " & cFecha & "   15" & Space(10 - Len(nPoliza.ToString)) & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                    oBalance = New StreamWriter("C:\FILES\PD_FIRA" & LTrim(nPoliza.ToString) & ".txt")
                Case Else ' todo lo no configurado es PD
                    cEncabezado = "P  " & cFecha & "    3" & Space(10 - Len(nPoliza.ToString)) & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                    oBalance = New StreamWriter("C:\FILES\PD" & LTrim(nPoliza.ToString) & ".txt")
            End Select

            oBalance.WriteLine(cEncabezado)

            For Each drMovimiento In drMovimientos

                ' Campos de la tabla Auxiliar

                cCve = drMovimiento("Cve")
                cAnexo = drMovimiento("Anexo")
                nImp = drMovimiento("Imp")
                cTipar = drMovimiento("Tipar")
                cTiparORG = drMovimiento("TiparORG")
                If cTiparORG = "" Then cTiparORG = cTipar
                cCoa = drMovimiento("Coa")
                cBanco = drMovimiento("Banco")
                cConcepto = drMovimiento("Concepto")
                If cConcepto.Trim.Length >= 36 Then
                    UUID = Right(cConcepto.Trim, 36)
                Else
                    UUID = ""
                End If


                ' Campo de la tabla clientes que pertenece al dataset dsAgil

                drCliente = dsAgil.Tables("Clientes").Rows.Find(cAnexo)
                If Not drCliente Is Nothing Then
                    cTipeq = drCliente("Tipeq")
                    cAccName = drCliente("Descr")
                    cTipoCliente = drCliente("Tipo")
                    cSegmento = drCliente("Segmento_Negocio")
                    Select Case Trim(cSegmento)
                        Case "100"
                            cSegmento = "  1 "
                        Case "200"
                            cSegmento = "  2 "
                        Case "300"
                            cSegmento = "  3 "
                        Case "400"
                            cSegmento = "  4 "
                        Case "500"
                            cSegmento = "  5 "
                        Case "600"
                            cSegmento = "  6 "
                        Case "700"
                            cSegmento = "  7 "
                    End Select
                Else
                    cTipeq = ""
                    cAccName = ""
                    cTipoCliente = ""
                    cSegmento = ""
                End If

                ' Para las siguiente pólizas no debe buscar el Segmento de Negocio en Clientes sino considerar el que trae en la tabla Auxiliar
                ' Fondeo FIRA (cTipoPol = "11")
                ' Provisión de intereses Avío y Cuenta Corriente (cTipoPol = "14")
                ' Pagos a FIRA (cTipoPol = "18")

                If Tipmov = "11" Or Tipmov = "14" Or Tipmov = "18" Then
                    cSegmento = drMovimiento("Segmento")
                    Select Case Trim(cSegmento)
                        Case "100"
                            cSegmento = "  1 "
                        Case "200"
                            cSegmento = "  2 "
                        Case "300"
                            cSegmento = "  3 "
                        Case "400"
                            cSegmento = "  4 "
                        Case "500"
                            cSegmento = "  5 "
                        Case "600"
                            cSegmento = "  6 "
                        Case "700"
                            cSegmento = "  7 "
                    End Select
                End If

                ' Tengo que buscar la Clave del movimiento en la tabla Interfase
                If Tipmov = "21" Then
                    If cCve = "66" Or (cCve = "03" And cTipar = "P") Then
                        myKeySearch(0) = cTipar
                    Else
                        myKeySearch(0) = Trim(cTipoCliente)
                    End If
                ElseIf Array.IndexOf(New String() {"24", "25", "26"}, Tipmov) > -1 And cCve <> "99" Then
                    myKeySearch(0) = "W"
                ElseIf (cTipar = "H" Or cTipar = "C" Or cTipar = "A" Or cTipar = "N") Or (Tipmov = "11" Or Tipmov = "18") Then
                    myKeySearch(0) = cTipar

                    If myKeySearch(0) = "A" And Tipmov = "09" Then myKeySearch(0) = "H" ' los anticipos se tratan igual que el avio

                    If (cTipar = "H" Or cTipar = "A") And (cCve = "72") Then
                        myKeySearch(0) = Trim(cTipoCliente) '#ECT en ingreso trae el tipo de persona
                    End If
                    If (cTipar = "H" Or cTipar = "A") And (cCve = "74") Then
                        myKeySearch(0) = Trim(cAnexo) '#ECT en provision trae el tipo de persona
                    End If
                    If (cTipar = "C") And (cCve = "72" Or cCve = "74") And Trim(cAnexo) = "F" Then
                        myKeySearch(0) = "X" '#ECT en ingreso trae el tipo de persona
                    End If
                Else
                    myKeySearch(0) = cTipoCliente
                    If cTiparORG = "F" And (cCve = "22") Then
                        myKeySearch(0) = "X" '#ECT todos los moratorios de AF son grabados
                    End If
                    If cTiparORG = "P" And (cCve = "08") Then
                        myKeySearch(0) = "X" '#ECT todos los moratorios de AF son grabados
                    End If
                    If cTiparORG = "P" And (Tipmov = "09" Or Tipmov = "01" Or Tipmov = "07") And (cCve = "03") Then
                        myKeySearch(0) = "P" '#ECT cartera exigible de las operaciones de arrendamiento puro
                    End If
                    If cTiparORG = "P" And (Tipmov = "09") And (cCve = "00" Or cCve = "78") Then
                        myKeySearch(0) = "P" '#ECT cartera exigible de las operaciones de arrendamiento puro
                    End If
                End If

                If cTipar = "B" Then
                    myKeySearch(0) = cTipar
                End If

                myKeySearch(1) = cCve
                drTemporal = dsAgil.Tables("Interfase").Rows.Find(myKeySearch)

                If Not drTemporal Is Nothing Then

                    ' Campos de la tabla Catálogo de Movimientos

                    cDescripcion = drTemporal("Descripcion")
                    cCuenta = drTemporal("Cuenta")
                    cTipo = drTemporal("Tipo")
                    cNivelInicial = drTemporal("NivelInicial")
                    cNivelFinal = drTemporal("NivelFinal")
                    cAplicacion = drTemporal("Aplicacion")
                    cReferencia = drTemporal("Referencia")

                    Select Case cNivelInicial
                        Case Is = "1"
                            cCuenta = Mid(cCuenta, 1, 4)
                            i = 2
                            j = 5
                        Case Is = "2"                       ' Sólo cuando el movimiento es de Bancos
                            cCuenta = Mid(cCuenta, 1, 6)
                            i = 3
                            j = 5
                        Case Is = "3"
                            cCuenta = Mid(cCuenta, 1, 8)
                            i = 4
                            j = 5
                        Case Is = "4"
                            cCuenta = Mid(cCuenta, 1, 12)
                            i = 5
                            j = 5
                        Case Is = "5"
                            cCuenta = Mid(cCuenta, 1, 16)
                            i = 6
                            j = 5
                    End Select

                    lHijo = False
                    While i <= j
                        If i = 2 Or i = 3 Then
                            Select Case Mid(cAplicacion, i, 1)
                                Case Is = "1"
                                    If InStr("134", cTipeq, CompareMethod.Text) > 0 Then
                                        cCuenta += "01"
                                    ElseIf InStr("256", cTipeq, CompareMethod.Text) > 0 Then
                                        cCuenta += "02"
                                    ElseIf cTipeq = "9" Then
                                        cCuenta += "90"
                                    Else
                                        cCuenta += "00"
                                    End If
                                Case Is = "6"
                                    cCuenta += cBanco
                                Case Else
                                    cCuenta += "00"
                            End Select
                        Else
                            Select Case Mid(cAplicacion, i, 1)
                                Case Is = "3"
                                    cCuenta += Mid(cAnexo, 2, 4)
                                Case Is = "4"
                                    cCuenta += Mid(cAnexo, 6, 4)
                                    lHijo = True
                                Case Else
                                    cCuenta += "0000"
                            End Select
                        End If
                        i += 1
                    End While

                    Select Case cNivelFinal
                        Case Is = "1"
                            cCuentaPadre = Mid(cCuenta, 1, 2) & "000000000000000000"
                            cCuentaAbuelo = Mid(cCuenta, 1, 2) & "000000000000000000"
                        Case Is = "2"
                            cCuentaPadre = Mid(cCuenta, 1, 4) & "0000000000000000"
                            cCuentaAbuelo = Mid(cCuenta, 1, 4) & "0000000000000000"
                        Case Is = "3"
                            cCuentaPadre = Mid(cCuenta, 1, 6) & "00000000000000"
                            cCuentaAbuelo = Mid(cCuenta, 1, 6) & "00000000000000"
                        Case Is = "4"
                            cCuentaPadre = Mid(cCuenta, 1, 8) & "00000000000000"
                            cCuentaAbuelo = Mid(cCuenta, 1, 8) & "00000000000000"
                        Case Is = "5"
                            cCuentaPadre = Mid(cCuenta, 1, 12) & "0000"
                            cCuentaAbuelo = Mid(cCuenta, 1, 8) & "00000000"
                    End Select

                    ' Si se tratara de una cuenta hijo, primero debe validar si ya existe la cuenta padre.
                    ' En caso que no exista, debemos dar de alta primero la cuenta padre y luego la cuenta hijo

                    If lHijo = True Then
                        drCuenta = dsAgil.Tables("Catalogo").Rows.Find(cCuentaPadre)
                        If drCuenta Is Nothing Then
                            drCuenta = dsAgil.Tables("Catalogo").NewRow()
                            drCuenta("Acc") = cCuentaPadre
                            drCuenta("AccName") = Mid(cAccName, 1, 50)
                            drCuenta("AccAditive") = cCuentaAbuelo
                            drCuenta("AccType") = cTipo
                            drCuenta("StatusDate") = cFecha
                            dsAgil.Tables("Catalogo").Rows.Add(drCuenta)
                        End If
                    End If

                    ' Ahora revisamos si existe la cuenta (sin importar si son cuentas hijo o no).
                    ' En caso que no exista, debemos darla de alta.

                    drCuenta = dsAgil.Tables("Catalogo").Rows.Find(cCuenta)

                    ' Si no encuentra la cuenta en el catálogo, significa que debemos darla de alta

                    If drCuenta Is Nothing Then
                        drCuenta = dsAgil.Tables("Catalogo").NewRow()
                        drCuenta("Acc") = cCuenta
                        drCuenta("AccName") = Mid(cAccName, 1, 50)
                        drCuenta("AccAditive") = cCuentaPadre
                        drCuenta("AccType") = cTipo
                        drCuenta("StatusDate") = cFecha
                        dsAgil.Tables("Catalogo").Rows.Add(drCuenta)
                    End If

                    cDescRef = IIf(LTrim(cAnexo) = "", "          ", Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4))
                    cidDirario = Stuff(cidDirario, "D", " ", 10)

                    If drTemporal("Moneda") = "MXN" Then
                        cImporte = Stuff(Trim(nImp.ToString), "D", " ", 20)
                        cImporteME = Stuff("0.0", "D", " ", 20)
                    Else
                        nImpME = nImp
                        cImporteME = Stuff(Trim(nImpME.ToString), "D", " ", 20)
                        nTipoCambio = TC.SacaTipoCambio(CTOD(cFecha), drTemporal("Moneda"))
                        nImp = nImpME * nTipoCambio
                        cImporte = Stuff(Trim(nImp.ToString), "D", " ", 20)
                    End If

                    cRenglon = "M1 " & cCuenta & Space(15) & cDescRef & Space(11) & cCoa & Space(1) & cImporte & Space(1) & cidDirario & Space(1) & cImporteME & Space(1) & cConcepto & Space(1) & cSegmento & Space(1) & Space(37)
                    oBalance.WriteLine(cRenglon)
                    Add_GUID(UUID, oBalance)
                Else
                    oBalance.WriteLine("No existe la cuenta:" & myKeySearch(0) & "," & myKeySearch(1))
                End If
            Next
            oBalance.Close()
            nPoliza = nPoliza + 1
        End If

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Public Sub GeneraPolizaIngresos(ByVal Tipmov As String, ByVal cConceptoPoliza As String, ByVal cFecha As String, ByRef nPoliza As Integer, ByRef dsAgil As DataSet)
        ' Declaración de variables de conexión ADO .NET
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daMovimientos As New SqlDataAdapter(cm1)

        Dim dsPoliza As New DataSet()
        Dim drCliente As DataRow
        Dim drCuenta As DataRow
        Dim drMovimiento As DataRow
        Dim drMovimientos As DataRowCollection
        Dim drTemporal As DataRow
        Dim myKeySearch(1) As String

        ' Declaración de variables de datos

        Dim cAccName As String = ""
        Dim cAnexo As String = ""
        Dim Grupo As Decimal
        Dim cAplicacion As String = ""
        Dim cBanco As String = ""
        Dim cCatalogo As String = ""
        Dim cCoa As String = ""
        Dim cConcepto As String = ""
        Dim cCuenta As String = ""
        Dim cCuentaAbuelo As String = ""
        Dim cCuentaPadre As String = ""
        Dim cCve As String = ""
        Dim cDescRef As String = ""
        Dim cDescripcion As String = ""
        Dim cEncabezado As String = ""
        Dim cImporte As String = ""
        Dim cNivelFinal As String = ""
        Dim cNivelInicial As String = ""
        Dim cReferencia As String = ""
        Dim cRenglon As String = ""
        Dim cSegmento As String = ""
        Dim cTipar As String = ""
        Dim cTiparORG As String = ""
        Dim cTipeq As String = ""
        Dim cTipo As String = ""
        Dim cTipoCliente As String = ""
        Dim nImp As Decimal = 0
        Dim i As Byte = 0
        Dim j As Byte = 0
        Dim lHijo As Boolean
        Dim oBalance As StreamWriter
        Dim UUID As String = ""
        Dim Aux As String = ""

        ' 01 Ingresos de Avío y Cuenta Corriente                        OK
        ' 02 Alta de Operaciones de Bienes al Comercio
        ' 03 Alta de Operaciones de Bienes al Consumo
        ' 04 Alta de Operaciones Arrendamiento Puro
        ' 05 Alta de Créditos Refaccionarios
        ' 06 Alta de Créditos Simples
        ' 07 Aplicación de Saldos a favor
        ' 08 Provisión de intereses activos
        ' 09 Traspasos de Cartera
        ' 10 Seguros Financiados
        ' 11 Fondeo FIRA
        ' 12 Alta de Créditos de Avío y Cuenta Corriente                OK
        ' 13 Provisión de Intereses Pasivos con FIRA
        ' 14 Provisión de Intereses Activos (Avío)
        ' 15 Provisión de Intereses Activos (Garantía Líquida Avío)
        ' 16 Financiamiento Adicional otorgado por FIRA
        ' 17 Intereses pasivos pagados a FIRA
        ' 18 Pagos a FIRA
        ' 20 IVA DEVENGADO
        ' 21 cartera VECNIDA
        ' 22 cuentas de orden
        ' 23 Garantias Ejercidas

        ' Este comando trae todos los movimientos que se generaron para un proceso en particular en una fecha determinada

        With cm1
            .CommandType = CommandType.Text
            '.CommandText = "SELECT Auxiliar.*, Vw_AnexosResumen.Tipar AS TiparORG FROM CONT_Auxiliar " & _
            '              "WHERE Tipmov = '" & cTipoPol & "' AND Fecha = '" & cFecha & "' " & _
            '              "ORDER BY Anexo, Coa, Cve"

            .CommandText = "SELECT Auxiliar.Cve, Auxiliar.Anexo, Auxiliar.Cliente, Auxiliar.Imp, Auxiliar.Tipar, Auxiliar.Coa, Auxiliar.Fecha, Auxiliar.Tipmov, " &
                           "    Auxiliar.Banco,Auxiliar.Concepto, Auxiliar.Segmento, ISNULL(Vw_AnexosResumen.Tipar,'') AS TiparORG, Grupo " &
                           "FROM CONT_Auxiliar Auxiliar LEFT OUTER JOIN Vw_AnexosResumen ON Auxiliar.Anexo = Vw_AnexosResumen.Anexo " &
                           "WHERE Tipmov = '" & Tipmov & "' AND Fecha = '" & cFecha & "' " &
                           "ORDER BY Grupo, Anexo, Coa, Cve"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daMovimientos.Fill(dsPoliza, "Movimientos")

        drMovimientos = dsPoliza.Tables("Movimientos").Rows

        If drMovimientos.Count > 0 Then
            oBalance = New StreamWriter("C:\FILES\PI" & cFecha.Substring(6, 2) & ".txt")

            For Each drMovimiento In drMovimientos
                cCve = drMovimiento("Cve")
                cAnexo = drMovimiento("Anexo")


                If Grupo <> drMovimiento("Grupo") Then
                    nPoliza += 1
                    cEncabezado = "P  " & cFecha & "    1" & Space(10 - Len(nPoliza.ToString)) & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                    oBalance.WriteLine(cEncabezado)
                End If

                Grupo = drMovimiento("Grupo")
                nImp = drMovimiento("Imp")
                cTipar = drMovimiento("Tipar")
                cTiparORG = drMovimiento("TiparORG")
                If cTiparORG = "" Then cTiparORG = cTipar
                cCoa = drMovimiento("Coa")
                cBanco = drMovimiento("Banco")
                cConcepto = drMovimiento("Concepto")
                If cConcepto.Trim.Length >= 36 Then
                    UUID = Right(cConcepto.Trim, 36)
                Else
                    UUID = ""
                End If


                ' Campo de la tabla clientes que pertenece al dataset dsAgil

                drCliente = dsAgil.Tables("Clientes").Rows.Find(cAnexo)
                If Not drCliente Is Nothing Then
                    cTipeq = drCliente("Tipeq")
                    cAccName = drCliente("Descr")
                    cTipoCliente = drCliente("Tipo")
                    cSegmento = drCliente("Segmento_Negocio")
                    Select Case Trim(cSegmento)
                        Case "100"
                            cSegmento = "  1 "
                        Case "200"
                            cSegmento = "  2 "
                        Case "300"
                            cSegmento = "  3 "
                        Case "400"
                            cSegmento = "  4 "
                        Case "500"
                            cSegmento = "  5 "
                        Case "600"
                            cSegmento = "  6 "
                        Case "700"
                            cSegmento = "  7 "
                    End Select
                Else
                    cTipeq = ""
                    cAccName = ""
                    cTipoCliente = ""
                    cSegmento = ""
                End If

                ' Para las siguiente pólizas no debe buscar el Segmento de Negocio en Clientes sino considerar el que trae en la tabla Auxiliar
                ' Fondeo FIRA (cTipoPol = "11")
                ' Provisión de intereses Avío y Cuenta Corriente (cTipoPol = "14")
                ' Pagos a FIRA (cTipoPol = "18")

                If Tipmov = "11" Or Tipmov = "14" Or Tipmov = "18" Then
                    cSegmento = drMovimiento("Segmento")
                    Select Case Trim(cSegmento)
                        Case "100"
                            cSegmento = "  1 "
                        Case "200"
                            cSegmento = "  2 "
                        Case "300"
                            cSegmento = "  3 "
                        Case "400"
                            cSegmento = "  4 "
                        Case "500"
                            cSegmento = "  5 "
                        Case "600"
                            cSegmento = "  6 "
                        Case "700"
                            cSegmento = "  7 "
                    End Select
                End If

                ' Tengo que buscar la Clave del movimiento en la tabla Interfase
                If Tipmov = "21" Then
                    If cCve = "66" Or (cCve = "03" And cTipar = "P") Then
                        myKeySearch(0) = cTipar
                    Else
                        myKeySearch(0) = Trim(cTipoCliente)
                    End If
                ElseIf (cTipar = "H" Or cTipar = "C" Or cTipar = "A" Or cTipar = "N") Or (Tipmov = "11" Or Tipmov = "18") Then
                    myKeySearch(0) = cTipar

                    If myKeySearch(0) = "A" And Tipmov = "09" Then myKeySearch(0) = "H" ' los anticipos se tratan igual que el avio

                    If (cTipar = "H" Or cTipar = "A") And (cCve = "72") Then
                        myKeySearch(0) = Trim(cTipoCliente) '#ECT en ingreso trae el tipo de persona
                    End If
                    If (cTipar = "H" Or cTipar = "A") And (cCve = "74") Then
                        myKeySearch(0) = Trim(cAnexo) '#ECT en provision trae el tipo de persona
                    End If
                    If (cTipar = "C") And (cCve = "72" Or cCve = "74") And Trim(cAnexo) = "F" Then
                        myKeySearch(0) = "X" '#ECT en ingreso trae el tipo de persona
                    End If
                Else
                    myKeySearch(0) = cTipoCliente
                    If cTiparORG = "F" And (cCve = "22") Then
                        myKeySearch(0) = "X" '#ECT todos los moratorios de AF son grabados
                    End If
                    If cTiparORG = "P" And (cCve = "08") Then
                        myKeySearch(0) = "X" '#ECT todos los moratorios de AF son grabados
                    End If
                    If cTiparORG = "P" And (Tipmov = "09" Or Tipmov = "01" Or Tipmov = "07") And (cCve = "03") Then
                        myKeySearch(0) = "P" '#ECT cartera exigible de las operaciones de arrendamiento puro
                    End If
                    If cTiparORG = "P" And (Tipmov = "09") And (cCve = "00" Or cCve = "78") Then
                        myKeySearch(0) = "P" '#ECT cartera exigible de las operaciones de arrendamiento puro
                    End If
                End If

                If cTipar = "B" Then
                    myKeySearch(0) = cTipar
                End If

                If cCve = "99" Then ' revisa que sea domiciliado
                    Aux = Mid(cConcepto, 6, 8)
                    If CFDI_ta.EsDomiciliado(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4), cFecha, Aux) > 0 Then
                        myKeySearch(0) = "D"
                    End If
                End If

                myKeySearch(1) = cCve
                drTemporal = dsAgil.Tables("Interfase").Rows.Find(myKeySearch)

                If Not drTemporal Is Nothing Then

                    ' Campos de la tabla Catálogo de Movimientos

                    cDescripcion = drTemporal("Descripcion")
                    cCuenta = drTemporal("Cuenta")
                    cTipo = drTemporal("Tipo")
                    cNivelInicial = drTemporal("NivelInicial")
                    cNivelFinal = drTemporal("NivelFinal")
                    cAplicacion = drTemporal("Aplicacion")
                    cReferencia = drTemporal("Referencia")

                    Select Case cNivelInicial
                        Case Is = "1"
                            cCuenta = Mid(cCuenta, 1, 4)
                            i = 2
                            j = 5
                        Case Is = "2"                       ' Sólo cuando el movimiento es de Bancos
                            cCuenta = Mid(cCuenta, 1, 6)
                            i = 3
                            j = 5
                        Case Is = "3"
                            cCuenta = Mid(cCuenta, 1, 8)
                            i = 4
                            j = 5
                        Case Is = "4"
                            cCuenta = Mid(cCuenta, 1, 12)
                            i = 5
                            j = 5
                        Case Is = "5"
                            cCuenta = Mid(cCuenta, 1, 16)
                            i = 6
                            j = 5
                    End Select

                    lHijo = False
                    While i <= j
                        If i = 2 Or i = 3 Then
                            Select Case Mid(cAplicacion, i, 1)
                                Case Is = "1"
                                    If InStr("134", cTipeq, CompareMethod.Text) > 0 Then
                                        cCuenta += "01"
                                    ElseIf InStr("256", cTipeq, CompareMethod.Text) > 0 Then
                                        cCuenta += "02"
                                    ElseIf cTipeq = "9" Then
                                        cCuenta += "90"
                                    Else
                                        cCuenta += "00"
                                    End If
                                Case Is = "6"
                                    cCuenta += cBanco
                                Case Else
                                    cCuenta += "00"
                            End Select
                        Else
                            Select Case Mid(cAplicacion, i, 1)
                                Case Is = "3"
                                    cCuenta += Mid(cAnexo, 2, 4)
                                Case Is = "4"
                                    cCuenta += Mid(cAnexo, 6, 4)
                                    lHijo = True
                                Case Else
                                    cCuenta += "0000"
                            End Select
                        End If
                        i += 1
                    End While

                    Select Case cNivelFinal
                        Case Is = "1"
                            cCuentaPadre = Mid(cCuenta, 1, 2) & "000000000000000000"
                            cCuentaAbuelo = Mid(cCuenta, 1, 2) & "000000000000000000"
                        Case Is = "2"
                            cCuentaPadre = Mid(cCuenta, 1, 4) & "0000000000000000"
                            cCuentaAbuelo = Mid(cCuenta, 1, 4) & "0000000000000000"
                        Case Is = "3"
                            cCuentaPadre = Mid(cCuenta, 1, 6) & "00000000000000"
                            cCuentaAbuelo = Mid(cCuenta, 1, 6) & "00000000000000"
                        Case Is = "4"
                            cCuentaPadre = Mid(cCuenta, 1, 8) & "00000000000000"
                            cCuentaAbuelo = Mid(cCuenta, 1, 8) & "00000000000000"
                        Case Is = "5"
                            cCuentaPadre = Mid(cCuenta, 1, 12) & "0000"
                            cCuentaAbuelo = Mid(cCuenta, 1, 8) & "00000000"
                    End Select

                    ' Si se tratara de una cuenta hijo, primero debe validar si ya existe la cuenta padre.
                    ' En caso que no exista, debemos dar de alta primero la cuenta padre y luego la cuenta hijo

                    If lHijo = True Then
                        drCuenta = dsAgil.Tables("Catalogo").Rows.Find(cCuentaPadre)
                        If drCuenta Is Nothing Then
                            drCuenta = dsAgil.Tables("Catalogo").NewRow()
                            drCuenta("Acc") = cCuentaPadre
                            drCuenta("AccName") = Mid(cAccName, 1, 50)
                            drCuenta("AccAditive") = cCuentaAbuelo
                            drCuenta("AccType") = cTipo
                            drCuenta("StatusDate") = cFecha
                            dsAgil.Tables("Catalogo").Rows.Add(drCuenta)
                        End If
                    End If

                    ' Ahora revisamos si existe la cuenta (sin importar si son cuentas hijo o no).
                    ' En caso que no exista, debemos darla de alta.

                    drCuenta = dsAgil.Tables("Catalogo").Rows.Find(cCuenta)

                    ' Si no encuentra la cuenta en el catálogo, significa que debemos darla de alta

                    If drCuenta Is Nothing Then
                        drCuenta = dsAgil.Tables("Catalogo").NewRow()
                        drCuenta("Acc") = cCuenta
                        drCuenta("AccName") = Mid(cAccName, 1, 50)
                        drCuenta("AccAditive") = cCuentaPadre
                        drCuenta("AccType") = cTipo
                        drCuenta("StatusDate") = cFecha
                        dsAgil.Tables("Catalogo").Rows.Add(drCuenta)
                    End If

                    cDescRef = IIf(LTrim(cAnexo) = "", "          ", Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4))

                    cImporte = Stuff(Trim(nImp.ToString), "D", " ", 20)

                    'cRenglon = "M  " & cCuenta & "               " & cDescRef & " " & cCoa & " " & cImporte & " 0          0.0" & Space(18) & cConcepto & Space(1) & cSegmento & Space(1)
                    'oBalance.WriteLine(cRenglon)
                    cRenglon = "M1 " & cCuenta & Space(15) & cDescRef & Space(11) & cCoa & Space(1) & cImporte & " 0          0.0" & Space(18) & cConcepto & Space(1) & cSegmento & Space(1) & Space(37)
                    oBalance.WriteLine(cRenglon)
                    Add_GUID(UUID, oBalance)
                End If
            Next
            oBalance.Close()
        End If

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Sub Add_GUID(UUID As String, ByRef oBalance As StreamWriter)
        Dim Serie As String
        Dim Folio As Decimal
        If UUID.Length = 36 Then
            CFDI_ta.Fill(CFDI_t, UUID)
            If CFDI_t.Rows.Count <= 0 Then
                oBalance.WriteLine("AM " & UUID)
                oBalance.WriteLine("AD " & UUID)
            Else
                Serie = CFDI_t.Rows(0).Item("Serie")
                Folio = CFDI_t.Rows(0).Item("Folio")
                If Serie = "REP" Or Serie = "REPP" Then
                    CFDI_ta.Fill_CFDI_ORg(CFDI_t, Serie, Folio)
                    oBalance.WriteLine("AM " & UUID)
                    oBalance.WriteLine("AM " & CFDI_t.Rows(0).Item("GUID"))
                    oBalance.WriteLine("AD " & UUID)
                    oBalance.WriteLine("AD " & CFDI_t.Rows(0).Item("GUID"))
                Else
                    oBalance.WriteLine("AM " & UUID)
                    oBalance.WriteLine("AD " & UUID)
                End If
            End If
        End If
    End Sub

End Module
