Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO

Module mAcepagoi

    Public Sub Acepagoi(ByVal cAnexo As String, ByVal cLetra As String, ByVal nMontoPago As Decimal, ByVal cBanco As String, ByVal cCheque As String, ByRef dtMovimientos As DataTable, ByVal cFecha As String, ByVal cSerie As String, ByVal nRecibo As Decimal, ByVal nTasaIVACliente As Decimal, InstrumentoMonetario As String, Forma_Pago As String, NoGrupo As Decimal)

        ' Declaraci�n de variables de conexi�n ADO .NET
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daAnexos As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet()
        Dim dtPagos As New DataTable("Pagos")
        Dim drAnexo As DataRow
        Dim drMovimiento As DataRow
        Dim drPago As DataRow
        Dim strInsert As String

        ' Declaraci�n de variables de datos

        Dim cCalle As String
        Dim cColonia As String
        Dim cCopos As String
        Dim cDelegacion As String
        Dim cEstado As String
        Dim cFechacon As String
        Dim cFondeo As String
        Dim cImporteLetra As String
        Dim cLeyenda As String = ""
        Dim cNombre As String
        Dim cRfc As String
        Dim cTipar As String
        Dim cCliente As String
        Dim cDia As String
        Dim cRenglon As String
        Dim cCuentaPago As String
        Dim cFormaPago As String
        Dim nAmorin As Decimal = 0
        Dim nComision As Decimal = 0
        Dim nDG As Byte = 0
        Dim nGastos As Decimal = 0
        Dim nImpDG As Decimal = 0
        Dim nImpEq As Decimal = 0
        Dim nImpRD As Decimal = 0
        Dim nIva As Decimal = 0
        Dim nIvaAmorin As Decimal = 0
        Dim nIvaComision As Decimal = 0
        Dim nIvaDG As Decimal = 0
        Dim nIvaEq As Decimal = 0
        Dim nIvaGastos As Decimal = 0
        Dim nIvaRD As Decimal = 0
        Dim nNafin As Decimal = 0
        Dim nPagosIniciales As Decimal = 0
        Dim nRD As Byte = 0
        Dim nSaldoEquipo As Decimal = 0
        Dim nSubTotal As Decimal = 0
        Dim nDerechos As Decimal = 0
        Dim nIVADerechos As Decimal = 0
        Dim nFondoReserva As Decimal = 0
        Dim i As Integer

        ' Primero creo la tabla Pagos que servir� como base para la generaci�n de la factura de pago

        dtPagos.Columns.Add("Concepto", Type.GetType("System.String"))
        dtPagos.Columns.Add("Importe", Type.GetType("System.Decimal"))
        dtPagos.Columns.Add("IVA", Type.GetType("System.Decimal"))
        dtPagos.Clear()

        ' El siguiente Stored Procedure trae todos los datos de un contrato dado, a fin de calcular
        ' el importe de sus pagos iniciales.   Adem�s trae los datos del cliente para la impresi�n
        ' de la factura de pago

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TraePI1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
        End With

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT ConRec FROM Llaves"
            .Connection = cnAgil
        End With

        Try

            'Codigo para facturas anteriores al primero de DICIEMBRE 2017*******
            If cSerie = "A" Then
                nRecibo = FOLIOS.FolioA
            ElseIf cSerie = "AB" Then
                nRecibo = FOLIOS.FolioBlanco
            ElseIf cSerie = "MXL" Then
                nRecibo = FOLIOS.FolioMXL
            End If
            '*******************************************************************

            'Llenar el DataSet a trav�s del DataAdapter, lo cual abre y cierra la conexi�n

            daAnexos.Fill(dsAgil, "Anexos")

            ' Te�ricamente, la tabla Anexos del dataset debe contener un solo registro

            drAnexo = dsAgil.Tables("Anexos").Rows(0)

            cNombre = drAnexo("Descr")
            cRfc = drAnexo("Rfc")
            cCalle = RTrim(drAnexo("Calle"))
            cColonia = RTrim(drAnexo("Colonia"))
            cDelegacion = RTrim(drAnexo("Delegacion"))
            cEstado = RTrim(drAnexo("Estado"))
            cCopos = RTrim(drAnexo("Copos"))
            cTipar = drAnexo("Tipar")
            cFondeo = drAnexo("Fondeo")
            cFechacon = drAnexo("Fechacon")
            cDia = Mid(drAnexo("Fvenc"), 7, 2)
            cCliente = drAnexo("Cliente")
            nImpEq = drAnexo("ImpEq")
            nIvaEq = drAnexo("IvaEq")
            nDerechos = Round(drAnexo("Derechos") / (1 + nTasaIVACliente / 100), 2)
            nIVADerechos = drAnexo("Derechos") - nDerechos
            nFondoReserva = drAnexo("FondoReserva")

            For i = 1 To 5
                Select Case i
                    Case 1
                        If RTrim(drAnexo("CuentadePago1")) <> "0" And RTrim(drAnexo("FormadePago1")) <> "EFECTIVO" Then
                            cCuentaPago = drAnexo("CuentadePago1")
                            cFormaPago = RTrim(drAnexo("FormadePago1"))
                        ElseIf RTrim(drAnexo("CuentadePago1")) = "0" And RTrim(drAnexo("FormadePago1")) = "EFECTIVO" Then
                            cCuentaPago = "NO IDENTIFICABLE"
                            cFormaPago = RTrim(drAnexo("FormadePago1"))
                        End If
                    Case 2
                        If RTrim(drAnexo("CuentadePago2")) <> "0" And RTrim(drAnexo("FormadePago2")) <> "EFECTIVO" Then
                            cCuentaPago = cCuentaPago & "," & drAnexo("CuentadePago2")
                            cFormaPago = cFormaPago & "," & RTrim(drAnexo("FormadePago2"))
                        ElseIf RTrim(drAnexo("CuentadePago2")) = "0" And RTrim(drAnexo("FormadePago2")) = "EFECTIVO" Then
                            cCuentaPago = cCuentaPago & "," & "NO IDENTIFICABLE"
                            cFormaPago = cFormaPago & "," & RTrim(drAnexo("FormadePago2"))
                        End If
                    Case 3
                        If RTrim(drAnexo("CuentadePago3")) <> "0" And RTrim(drAnexo("FormadePago3")) <> "EFECTIVO" Then
                            cCuentaPago = cCuentaPago & "," & drAnexo("CuentadePago3")
                            cFormaPago = cFormaPago & "," & RTrim(drAnexo("FormadePago3"))
                        ElseIf RTrim(drAnexo("CuentadePago3")) = "0" And RTrim(drAnexo("FormadePago3")) = "EFECTIVO" Then
                            cCuentaPago = cCuentaPago & "," & "NO IDENTIFICABLE"
                            cFormaPago = cFormaPago & "," & RTrim(drAnexo("FormadePago3"))
                        End If
                    Case 4
                        If RTrim(drAnexo("CuentadePago4")) <> "0" And RTrim(drAnexo("FormadePago4")) <> "EFECTIVO" Then
                            cCuentaPago = cCuentaPago & "," & drAnexo("CuentadePago4")
                            cFormaPago = cFormaPago & "," & RTrim(drAnexo("FormadePago4"))
                        ElseIf RTrim(drAnexo("CuentadePago4")) = "0" And RTrim(drAnexo("FormadePago4")) = "EFECTIVO" Then
                            cCuentaPago = cCuentaPago & "," & "NO IDENTIFICABLE"
                            cFormaPago = cFormaPago & "," & RTrim(drAnexo("FormadePago4"))
                        End If
                    Case 5
                        If cCuentaPago = "" And cFormaPago = "" Then
                            cCuentaPago = "NO IDENTIFICABLE"
                            cFormaPago = "NO IDENTIFICABLE"
                        End If
                End Select
            Next

            nAmorin = drAnexo("Amorin")
            nIvaAmorin = drAnexo("IvaAmorin")
            nDG = drAnexo("DG")
            nImpDG = drAnexo("ImpRD")
            nIvaDG = drAnexo("IvaRD")
            '*************para no desglosar IVA Deposito en garantia solicitado por Valentin
            nImpDG = nImpDG + nIvaDG
            nIvaDG = 0
            '*************para no desglosar IVA Deposito en garantia solicitado por Valentin

            nRD = drAnexo("RD")
            nImpRD = drAnexo("ImpDG")
            nIvaRD = drAnexo("IvaDG")
            nComision = Round(drAnexo("Comis") / (1 + (nTasaIVACliente / 100)), 2)
            nIvaComision = Round(drAnexo("Comis") - nComision, 2)
            nGastos = drAnexo("Gastos")
            nIvaGastos = drAnexo("IvaGastos")
            nSaldoEquipo = Round(nImpEq - nIvaEq - nAmorin, 2)

            nNafin = 0
            nSubTotal = Round(nAmorin + nImpDG + nImpRD + nComision + nGastos + nNafin + nDerechos + nFondoReserva, 2)
            nIva = Round(nIvaAmorin + nIvaDG + nIvaRD + nIvaComision + nIvaGastos + nIVADerechos, 2)
            nPagosIniciales = Round(nSubTotal + nIva, 2)
            cImporteLetra = Letras(nPagosIniciales.ToString)

            If nIvaEq > 0 Then
                cLeyenda = "EL MONTO DE ESTA OPERACION ES " & Format(nImpEq - nIvaEq, "C") & " Y SU IVA ES " & Format(nIvaEq, "C") & " LOS CUALES SERAN PAGADOS EN PARCIALIDADES."
            End If
            If cTipar = "F" And cLetra = "000" Then
                cLeyenda = "EL MONTO DE ESTA OPERACION ES " & Format(nImpEq - nIvaEq, "C") & " Y SU IVA ES " & Format(nIvaEq, "C") & " LOS CUALES SERAN PAGADOS EN PARCIALIDADES."
            End If
            If cTipar = "B" Then
                cLeyenda = ""
            End If


            If nImpRD > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "RENTA EN DEPOSITO"
                drPago("Importe") = nImpRD
                drPago("IVA") = nIvaRD
                dtPagos.Rows.Add(drPago)
            End If

            If nIvaRD > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "IVA RENTA EN DEPOSITO"
                drPago("Importe") = nIvaRD
                drPago("IVA") = 0
                dtPagos.Rows.Add(drPago)
            End If

            If nImpDG > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "DEPOSITO EN GARANTIA"
                drPago("Importe") = nImpDG
                drPago("IVA") = nIvaDG
                dtPagos.Rows.Add(drPago)
            End If

            If nIvaDG > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "IVA DEL DEPOSITO"
                drPago("Importe") = nIvaDG
                drPago("IVA") = 0
                dtPagos.Rows.Add(drPago)
            End If

            If nComision > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "COMISION"
                drPago("Importe") = nComision
                drPago("IVA") = nIvaComision
                dtPagos.Rows.Add(drPago)
            End If

            If nIvaComision > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "IVA DE LA COMISION"
                drPago("Importe") = nIvaComision
                drPago("IVA") = 0
                dtPagos.Rows.Add(drPago)
            End If

            If nAmorin > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "AMORTIZACION INICIAL"
                drPago("Importe") = nAmorin
                drPago("IVA") = nIvaAmorin
                dtPagos.Rows.Add(drPago)
            End If

            If nIvaAmorin > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "IVA DE LA AMORTIZACION"
                drPago("Importe") = nIvaAmorin
                drPago("IVA") = 0
                dtPagos.Rows.Add(drPago)
            End If

            If nGastos > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "GASTOS DE RATIFICACION"
                drPago("Importe") = nGastos
                drPago("IVA") = nIvaGastos
                dtPagos.Rows.Add(drPago)
            End If

            If nIvaGastos > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "IVA GASTOS RATIFICACION"
                drPago("Importe") = nIvaGastos
                drPago("IVA") = 0
                dtPagos.Rows.Add(drPago)
            End If

            If nNafin > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "5% NAFIN"
                drPago("Importe") = nNafin
                drPago("IVA") = 0
                dtPagos.Rows.Add(drPago)
            End If

            If nDerechos > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "DERECHOS DE REGISTRO"
                drPago("Importe") = nDerechos
                drPago("IVA") = nIVADerechos
                dtPagos.Rows.Add(drPago)
            End If

            If nIVADerechos > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "IVA DERECHOS DE REGISTRO"
                drPago("Importe") = nIVADerechos
                drPago("IVA") = 0
                dtPagos.Rows.Add(drPago)
            End If

            If nFondoReserva > 0 Then
                drPago = dtPagos.NewRow()
                drPago("Concepto") = "FONDO DE RESERVA"
                drPago("Importe") = nFondoReserva
                drPago("IVA") = 0
                dtPagos.Rows.Add(drPago)
            End If

            cnAgil.Open()

            ' Procedo a actualizar la Historia de Pagos

            If nImpRD > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nImpRD & "', '"
                strInsert = strInsert & "RENTA EN DEPOSITO"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            If nIvaRD > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nIvaRD & "', '"
                strInsert = strInsert & "IVA RENTA EN DEPOSITO"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            If nImpDG > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nImpDG & "', '"
                strInsert = strInsert & "DEPOSITO EN GARANTIA"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            If nIvaDG > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nIvaDG & "', '"
                strInsert = strInsert & "IVA DEL DEPOSITO"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            If nComision > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nComision & "', '"
                strInsert = strInsert & "COMISION"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            If nIvaComision > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nIvaComision & "', '"
                strInsert = strInsert & "IVA DE LA COMISION"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            If nAmorin > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nAmorin & "', '"
                strInsert = strInsert & "AMORTIZACION INICIAL"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            If nIvaAmorin > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nIvaAmorin & "', '"
                strInsert = strInsert & "IVA DE LA AMORTIZACION"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            If nGastos > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nGastos & "', '"
                strInsert = strInsert & "GASTOS DE RATIFICACION"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            If nIvaGastos > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nIvaGastos & "', '"
                strInsert = strInsert & "IVA GASTOS RATIFICACION"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            If nNafin > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nNafin & "', '"
                strInsert = strInsert & "5% NAFIN"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            If nDerechos > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nDerechos & "', '"
                strInsert = strInsert & "DERECHOS DE REGISTRO"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            If nIVADerechos > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nIVADerechos & "', '"
                strInsert = strInsert & "IVA DERECHOS DE REGISTRO"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            If nFondoReserva > 0 Then
                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1,InstrumentoMonetario)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                strInsert = strInsert & cSerie & "', "
                strInsert = strInsert & nRecibo & ", '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                strInsert = strInsert & "N" & "', '"
                strInsert = strInsert & nFondoReserva & "', '"
                strInsert = strInsert & "FONDO DE RESERVA"
                strInsert = strInsert & "','" & InstrumentoMonetario & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            End If

            cnAgil.Close()

            ' Aqu� se generan los asientos contables

            drMovimiento = dtMovimientos.NewRow()
            drMovimiento("Anexo") = cAnexo
            drMovimiento("Letra") = "000"
            drMovimiento("Tipos") = "1"
            drMovimiento("Fepag") = cFecha
            If cTipar = "F" Then
                drMovimiento("Cve") = "02"
            ElseIf cTipar = "P" Then
                drMovimiento("Cve") = "40"
            ElseIf cTipar = "R" Then
                drMovimiento("Cve") = "39"
            ElseIf cTipar = "S" Then
                drMovimiento("Cve") = "58"
            ElseIf cTipar = "B" Then
                drMovimiento("Cve") = "04"
            End If
            drMovimiento("Imp") = nPagosIniciales
            drMovimiento("Tip") = "S"
            drMovimiento("Catal") = cTipar
            drMovimiento("Esp") = 0
            drMovimiento("Coa") = "1"
            drMovimiento("Tipmon") = "01"
            drMovimiento("Banco") = cBanco
            drMovimiento("Concepto") = cCheque
            drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
            drMovimiento("Grupo") = NoGrupo
            dtMovimientos.Rows.Add(drMovimiento)

            drMovimiento = dtMovimientos.NewRow()
            drMovimiento("Anexo") = cAnexo
            drMovimiento("Letra") = "000"
            drMovimiento("Tipos") = "1"
            drMovimiento("Fepag") = cFecha
            drMovimiento("Cve") = "09"
            drMovimiento("Imp") = Round(nIvaAmorin + nIvaDG + nIvaRD + nIvaComision + nIvaGastos + nIVADerechos, 2)
            drMovimiento("Tip") = "S"
            drMovimiento("Catal") = cTipar
            drMovimiento("Esp") = 0
            drMovimiento("Coa") = "0"
            drMovimiento("Tipmon") = "01"
            drMovimiento("Banco") = cBanco
            drMovimiento("Concepto") = cCheque
            drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
            drMovimiento("Grupo") = NoGrupo
            dtMovimientos.Rows.Add(drMovimiento)

            If nIvaAmorin > 0 Then

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = "000"
                drMovimiento("Tipos") = "1"
                drMovimiento("Fepag") = cFecha
                drMovimiento("Cve") = "08"
                drMovimiento("Imp") = nIvaAmorin
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cTipar
                drMovimiento("Esp") = 0
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = "01"
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = "000"
                drMovimiento("Tipos") = "1"
                drMovimiento("Fepag") = cFecha
                drMovimiento("Cve") = "88"
                drMovimiento("Imp") = nIvaAmorin
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cTipar
                drMovimiento("Esp") = 0
                drMovimiento("Coa") = "0"
                drMovimiento("Tipmon") = "01"
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = "000"
                drMovimiento("Tipos") = "1"
                drMovimiento("Fepag") = cFecha
                drMovimiento("Cve") = "87"
                drMovimiento("Imp") = nIvaAmorin
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cTipar
                drMovimiento("Esp") = 0
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = "01"
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

            End If

            ' IVA de la Renta en Dep�sito

            If nIvaRD > 0 Then

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = "000"
                drMovimiento("Tipos") = "1"
                drMovimiento("Fepag") = cFecha
                drMovimiento("Cve") = "30"
                drMovimiento("Imp") = nIvaRD
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cTipar
                drMovimiento("Esp") = 0
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = "01"
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

            End If

            ' IVA del Dep�sito en Garant�a

            If nIvaDG > 0 Then

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = "000"
                drMovimiento("Tipos") = "1"
                drMovimiento("Fepag") = cFecha
                drMovimiento("Cve") = "20"
                drMovimiento("Imp") = nIvaDG
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cTipar
                drMovimiento("Esp") = 0
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = "01"
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

            End If

            If nIvaGastos > 0 Then

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = "000"
                drMovimiento("Tipos") = "1"
                drMovimiento("Fepag") = cFecha
                drMovimiento("Cve") = "31"
                drMovimiento("Imp") = nIvaGastos
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cTipar
                drMovimiento("Esp") = 0
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = "01"
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

            End If

            If nIvaComision > 0 Then

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = "000"
                drMovimiento("Tipos") = "1"
                drMovimiento("Fepag") = cFecha
                drMovimiento("Cve") = "32"
                drMovimiento("Imp") = nIvaComision
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cTipar
                drMovimiento("Esp") = 0
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = "01"
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

            End If

            If nIVADerechos > 0 Then

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = "000"
                drMovimiento("Tipos") = "1"
                drMovimiento("Fepag") = cFecha
                drMovimiento("Cve") = "90"
                drMovimiento("Imp") = nIVADerechos
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cTipar
                drMovimiento("Esp") = 0
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = "01"
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

            End If

            ' Una vez que cerr� la conexi�n y que gener� los asientos contables, podr�a generar el archivo txt que genera la factura electr�nica

            dsAgil.Tables.Remove("Anexos")
            dsAgil.Tables.Add(dtPagos)

            ' En esta parte del proceso se genera el archivo txt que se envia al directorios de EDCInvoice para generar la factura electr�nica
            Dim Ruta As String = "C:\Facturas\FACTURA_"
            If cSerie = "AB" Then
                Ruta = "C:\Facturas\AppBlanco\FACTURA_"
            End If

            Dim stmFactura As New FileStream(Ruta & cSerie & "_" & nRecibo & ".txt", FileMode.Create, FileAccess.Write, FileShare.None)
            Dim stmWriter As New StreamWriter(stmFactura, System.Text.Encoding.Default)

            stmWriter.WriteLine("H1|" & FECHA_APLICACION.ToShortDateString & "|PUE|" & Forma_Pago & "|" & cCheque)


            cRenglon = "H3|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|" & cSerie & "|" & nRecibo & "|" & Trim(cNombre) & "|" &
            Trim(cCalle) & "|||" & Trim(cColonia) & "|" & Trim(cDelegacion) & "|" & Trim(cEstado) & "|" & cCopos & "|" & cCuentaPago & "|" & cFormaPago & "|MEXICO|" & Trim(cRfc) & "|M.N.|" &
            "|FACTURA|" & cCliente & "|LEANDRO VALLE 402||REFORMA Y FFCCNN|TOLUCA|ESTADO DE MEXICO|50070|MEXICO|" & cAnexo & "|000|"

            cRenglon = cRenglon.Replace("�", Chr(165))
            cRenglon = cRenglon.Replace("�", Chr(164))
            cRenglon = cRenglon.Replace("�", Chr(160))
            cRenglon = cRenglon.Replace("�", Chr(130))
            cRenglon = cRenglon.Replace("�", Chr(161))
            cRenglon = cRenglon.Replace("�", Chr(162))
            cRenglon = cRenglon.Replace("�", Chr(163))
            cRenglon = cRenglon.Replace("�", Chr(181))
            cRenglon = cRenglon.Replace("�", Chr(144))
            cRenglon = cRenglon.Replace("�", Chr(224))
            cRenglon = cRenglon.Replace("�", Chr(233))
            cRenglon = cRenglon.Replace("�", Chr(167))
            stmWriter.WriteLine(cRenglon)

            For Each drPago In dsAgil.Tables("Pagos").Rows
                cRenglon = "D1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|" & cSerie & "|" & nRecibo & "|1|||" & Trim(drPago("Concepto")) & "||" & drPago("Importe") & "|" & drPago("IVA")
                cRenglon = cRenglon.Replace("�", Chr(165))
                cRenglon = cRenglon.Replace("�", Chr(164))
                cRenglon = cRenglon.Replace("�", Chr(160))
                cRenglon = cRenglon.Replace("�", Chr(130))
                cRenglon = cRenglon.Replace("�", Chr(161))
                cRenglon = cRenglon.Replace("�", Chr(162))
                cRenglon = cRenglon.Replace("�", Chr(163))
                cRenglon = cRenglon.Replace("�", Chr(181))
                cRenglon = cRenglon.Replace("�", Chr(144))
                cRenglon = cRenglon.Replace("�", Chr(224))
                cRenglon = cRenglon.Replace("�", Chr(233))
                cRenglon = cRenglon.Replace("�", Chr(167))
                stmWriter.WriteLine(cRenglon)
            Next

            If nIva = 0 Then
                cRenglon = "S1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|" & cSerie & "|" & nRecibo & "|" & nSubTotal & "|" & nIva & "|" & nPagosIniciales & "|" & Letras(nPagosIniciales.ToString) & "|||0"
            Else
                cRenglon = "S1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|" & cSerie & "|" & nRecibo & "|" & nSubTotal & "|" & nIva & "|" & nPagosIniciales & "|" & Letras(nPagosIniciales.ToString) & "|||16"
            End If
            stmWriter.WriteLine(cRenglon)
            cRenglon = "Z1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|" & cSerie & "|" & nRecibo & "|" & cCheque & "|" & Trim(cRfc) & "|" & cLeyenda

            stmWriter.WriteLine(cRenglon)

            stmWriter.Flush()
            stmFactura.Flush()
            stmFactura.Close()

            If cSerie = "AB" Then
                Folios.ConsumeFolioBlanco()
            ElseIf cSerie = "A" Then
                Folios.ConsumeFolioA()
            ElseIf cSerie = "MXL" Then
                Folios.ConsumeFolioMXL()
            End If

        Catch eException As Exception

            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()

    End Sub

End Module
