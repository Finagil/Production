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
    Public Sub GeneraPoliza(ByVal cTipoPol As String, ByVal cConceptoPoliza As String, ByVal cFecha As String, ByRef nPoliza As Integer, ByRef dsAgil As DataSet)

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

        ' Este comando trae todos los movimientos que se generaron para un proceso en particular en una fecha determinada

        With cm1
            .CommandType = CommandType.Text
            '.CommandText = "SELECT Auxiliar.*, Vw_AnexosResumen.Tipar AS TiparORG FROM CONT_Auxiliar " & _
            '              "WHERE Tipmov = '" & cTipoPol & "' AND Fecha = '" & cFecha & "' " & _
            '              "ORDER BY Anexo, Coa, Cve"

            .CommandText = "SELECT Auxiliar.Cve, Auxiliar.Anexo, Auxiliar.Cliente, Auxiliar.Imp, Auxiliar.Tipar, Auxiliar.Coa, Auxiliar.Fecha, Auxiliar.Tipmov, " &
                           "    Auxiliar.Banco,Auxiliar.Concepto, Auxiliar.Segmento, ISNULL(Vw_AnexosResumen.Tipar,'') AS TiparORG " &
                           "FROM CONT_Auxiliar Auxiliar LEFT OUTER JOIN Vw_AnexosResumen ON Auxiliar.Anexo = Vw_AnexosResumen.Anexo " &
                           "WHERE Tipmov = '" & cTipoPol & "' AND Fecha = '" & cFecha & "' " &
                           "ORDER BY Anexo, Coa, Cve"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daMovimientos.Fill(dsPoliza, "Movimientos")

        drMovimientos = dsPoliza.Tables("Movimientos").Rows

        If drMovimientos.Count > 0 Then

            If Len(nPoliza.ToString) = 1 Then
                If cTipoPol = "01" Then
                    cEncabezado = "P  " & cFecha & "    1 " & "        " & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                ElseIf cTipoPol = "11" Then ' Fondeo FIRA (cTipoPol = "11")
                ElseIf cTipoPol = "18" Then ' Pagos a FIRA (cTipoPol = "18")
                Else
                    cEncabezado = "P  " & cFecha & "    3 " & "        " & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                End If
            ElseIf Len(nPoliza.ToString) = 2 Then
                If cTipoPol = "01" Then
                    cEncabezado = "P  " & cFecha & "    1 " & "       " & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                Else
                    cEncabezado = "P  " & cFecha & "    3 " & "       " & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                End If
            Else
                If cTipoPol = "01" Then
                    cEncabezado = "P  " & cFecha & "    1 " & "      " & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                Else
                    If nPoliza >= 100 And nPoliza < 200 Then
                        cEncabezado = "P  " & cFecha & "    3 " & "      " & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                    ElseIf nPoliza > 200 And nPoliza < 300 Then
                        cEncabezado = "P  " & cFecha & "   12 " & "      " & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                    ElseIf nPoliza > 300 And nPoliza < 400 Then
                        cEncabezado = "P  " & cFecha & "   13 " & "      " & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                    Else
                        cEncabezado = "P  " & cFecha & "    3 " & "      " & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
                    End If
                End If
            End If

            If cTipoPol = "11" Then ' Fondeo FIRA (cTipoPol = "11")
                oBalance = New StreamWriter("C:\FILES\PD" & LTrim((nPoliza + 200).ToString) & ".txt")
                cEncabezado = "P  " & cFecha & "   12" & Space(10 - nPoliza.ToString.Length) & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
            ElseIf cTipoPol = "18" Then ' Pagos a FIRA (cTipoPol = "18")
                oBalance = New StreamWriter("C:\FILES\PD" & LTrim((nPoliza + 300).ToString) & ".txt")
                cEncabezado = "P  " & cFecha & "   13" & Space(10 - nPoliza.ToString.Length) & nPoliza.ToString & " 1 0          " & cConceptoPoliza & " 11 0 0 "
            Else
                oBalance = New StreamWriter("C:\FILES\PD" & LTrim(nPoliza.ToString) & ".txt")
            End If
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

                If cTipoPol = "11" Or cTipoPol = "14" Or cTipoPol = "18" Then
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
                If cTipoPol = "21" Then
                    If cCve = "66" Or (cCve = "03" And cTipar = "P") Then
                        myKeySearch(0) = cTipar
                    Else
                        myKeySearch(0) = Trim(cTipoCliente)
                    End If
                ElseIf (cTipar = "H" Or cTipar = "C" Or cTipar = "A" Or cTipar = "N") Or (cTipoPol = "11" Or cTipoPol = "18") Then
                    myKeySearch(0) = cTipar

                    If myKeySearch(0) = "A" And cTipoPol = "09" Then myKeySearch(0) = "H" ' los anticipos se tratan igual que el avio

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
                    If cTiparORG = "P" And (cTipoPol = "09" Or cTipoPol = "01" Or cTipoPol = "07") And (cCve = "03") Then
                        myKeySearch(0) = "P" '#ECT cartera exigible de las operaciones de arrendamiento puro
                    End If
                    If cTiparORG = "P" And (cTipoPol = "09") And (cCve = "00" Or cCve = "78") Then
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

                    cImporte = Stuff(Trim(nImp.ToString), "D", " ", 20)

                    'cRenglon = "M  " & cCuenta & "               " & cDescRef & " " & cCoa & " " & cImporte & " 0          0.0" & Space(18) & cConcepto & Space(1) & cSegmento & Space(1)
                    'oBalance.WriteLine(cRenglon)
                    cRenglon = "M1 " & cCuenta & Space(15) & cDescRef & Space(11) & cCoa & Space(1) & cImporte & " 0          0.0" & Space(18) & cConcepto & Space(1) & cSegmento & Space(1) & Space(37)
                    oBalance.WriteLine(cRenglon)
                    Add_GUID(UUID, oBalance)
                End If
            Next

            oBalance.Close()

            If cTipoPol <> "01" Then
                nPoliza = nPoliza + 1
            End If

        End If

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Public Sub GeneraPolizaIngresos(ByVal cTipoPol As String, ByVal cConceptoPoliza As String, ByVal cFecha As String, ByRef nPoliza As Integer, ByRef dsAgil As DataSet)
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

        ' Este comando trae todos los movimientos que se generaron para un proceso en particular en una fecha determinada

        With cm1
            .CommandType = CommandType.Text
            '.CommandText = "SELECT Auxiliar.*, Vw_AnexosResumen.Tipar AS TiparORG FROM CONT_Auxiliar " & _
            '              "WHERE Tipmov = '" & cTipoPol & "' AND Fecha = '" & cFecha & "' " & _
            '              "ORDER BY Anexo, Coa, Cve"

            .CommandText = "SELECT Auxiliar.Cve, Auxiliar.Anexo, Auxiliar.Cliente, Auxiliar.Imp, Auxiliar.Tipar, Auxiliar.Coa, Auxiliar.Fecha, Auxiliar.Tipmov, " &
                           "    Auxiliar.Banco,Auxiliar.Concepto, Auxiliar.Segmento, ISNULL(Vw_AnexosResumen.Tipar,'') AS TiparORG, Grupo " &
                           "FROM CONT_Auxiliar Auxiliar LEFT OUTER JOIN Vw_AnexosResumen ON Auxiliar.Anexo = Vw_AnexosResumen.Anexo " &
                           "WHERE Tipmov = '" & cTipoPol & "' AND Fecha = '" & cFecha & "' " &
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

                If cTipoPol = "11" Or cTipoPol = "14" Or cTipoPol = "18" Then
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
                If cTipoPol = "21" Then
                    If cCve = "66" Or (cCve = "03" And cTipar = "P") Then
                        myKeySearch(0) = cTipar
                    Else
                        myKeySearch(0) = Trim(cTipoCliente)
                    End If
                ElseIf (cTipar = "H" Or cTipar = "C" Or cTipar = "A" Or cTipar = "N") Or (cTipoPol = "11" Or cTipoPol = "18") Then
                    myKeySearch(0) = cTipar

                    If myKeySearch(0) = "A" And cTipoPol = "09" Then myKeySearch(0) = "H" ' los anticipos se tratan igual que el avio

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
                    If cTiparORG = "P" And (cTipoPol = "09" Or cTipoPol = "01" Or cTipoPol = "07") And (cCve = "03") Then
                        myKeySearch(0) = "P" '#ECT cartera exigible de las operaciones de arrendamiento puro
                    End If
                    If cTiparORG = "P" And (cTipoPol = "09") And (cCve = "00" Or cCve = "78") Then
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
