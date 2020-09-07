Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO

' Esta funci�n realiza el desglose de la aplicaci�n de un pago a una factura determinada.
' Es llamada por la forma frmAcepagoIVF la cual le env�a como argumentos:
' cAnexo (el n�mero de anexo)
' cLetra (la letra del vencimiento)
' nMontoPago (el monto pagado)
' nMoratorios
' nIvaMoratorios
' cBanco
' cCheque
' dtMovimientos (la cual contendr� los movimientos contables del pago y es pasada por referencia, por lo que se ve afectada por este proceso)
' cFechaAplicacion (que es la fecha con la que se generar� la factura electr�nica y con la que se registrar� el ingreso)
' cFechaPago (esta es la fecha en la que el cliente realiz� el pago y determina si proceden o no intereses moratorios)
' �Cu�l fecha se registra en FACTURAS como �ltimo pago?
' cSerie
' nRecibo
' Es importante comentar que el monto del pago NO es el importe total del pago, sino la parte del pago 
' que ser� aplicado a esta factura.

Module mAcepagov

    ' Declaraci�n de variables de alcance privado

    Dim cFeven As String = ""
    Dim cTipar As String = ""
    Dim nBaseFEGA As Decimal = 0
    Dim nImporteFac As Decimal = 0
    Dim nImporteFEGA As Decimal = 0
    Dim nIvaFEGA As Decimal = 0
    Dim nPagado As Decimal = 0
    Dim nSaldoFac As Decimal = 0
    Dim nTasaIVA As Decimal = 0
    Dim Factor As Decimal
    ' Tasa de IVA que le corresponde al cliente de acuerdo a su domicilio fiscal

    Private Structure Conceptos
        Public Concepto As String
        Public Importe As Decimal
        Public Porcentaje As Decimal
        Public Iva As Decimal
    End Structure

    Dim aConcepto As New Conceptos()

    Public Sub Acepagov(ByVal cAnexo As String, ByVal cLetra As String, ByVal nMontoPago As Decimal, ByVal nMoratorios As Decimal, ByVal nIvaMoratorios As Decimal, ByVal cBanco As String, ByVal cCheque As String, ByRef dtMovimientos As DataTable, ByVal cFecha As String, ByVal cFechaPago As String, ByRef cSerie As String, ByRef nRecibo As Decimal, InstrumentoMonetario As String, Metodo_Pago As String, Forma_Pago As String, NoGrupo As Decimal, FechaRealPago As Date)
        ' Declaraci�n de variables de conexi�n ADO .NET
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daFacturas As New SqlDataAdapter(cm1)

        Dim dsAgil As New DataSet
        Dim dtPagos As New DataTable("Pagos")
        Dim drPago As DataRow
        Dim drFactura As DataRow
        Dim drMovimiento As DataRow

        Dim strInsert As String
        Dim strUpdate As String

        ' Declaraci�n de variables de datos

        Dim aConceptos As New ArrayList()
        Dim cCalle As String = ""
        Dim cCatal As String = ""
        Dim cCliente As String = ""
        Dim cColonia As String = ""
        Dim cConcepto As String = ""
        Dim cCopos As String = ""
        Dim cCuentaPago As String = ""
        Dim cDelegacion As String = ""
        Dim cEstado As String = ""
        Dim cFepag As String = ""
        Dim cFormaPago As String = ""
        Dim cNombre As String = ""
        Dim cObserva As String = ""
        Dim cPrevio As String = ""
        Dim cRenglon As String = ""
        Dim cRfc As String = ""
        Dim cTipmon As String = ""
        Dim cTipos As String = ""
        Dim i As Integer
        Dim lCredito As Boolean
        Dim nAbonoCartera As Decimal = 0
        Dim nAbonoOtros As Decimal = 0
        Dim nBonifica As Decimal = 0
        Dim nCapitalEquipo As Decimal = 0
        Dim nCapitalOtros As Decimal = 0
        Dim nCapitalSeguro As Decimal = 0
        Dim nEsp As Decimal = 0
        Dim nFactura As Decimal = 0
        Dim nImporte As Decimal = 0
        Dim nInteres As Decimal = 0
        Dim nInteresSEG As Decimal = 0
        Dim nInteresOtros As Decimal = 0
        Dim nIva As Decimal = 0
        Dim nIvaCapital As Decimal = 0
        Dim nIvaInteres As Decimal = 0
        Dim nIvaInteresSeg As Decimal = 0
        Dim nIvaOtros As Decimal = 0
        Dim nPagoConcepto As Decimal = 0
        Dim nPrevioCartera As Decimal = 0
        Dim nPrevioOtros As Decimal = 0
        Dim nSeguroVida As Decimal = 0
        Dim nSubTotal As Decimal = 0
        Dim nTotal As Decimal = 0
        Dim cSerieMORA As String = ""
        Dim nReciboMORA As Integer = 0
        Dim PagoTotal As Boolean


        ' Luego creo la tabla dtPagos

        dtPagos.Columns.Add("Anexo", Type.GetType("System.String"))
        dtPagos.Columns.Add("Letra", Type.GetType("System.String"))
        dtPagos.Columns.Add("Tipos", Type.GetType("System.String"))
        dtPagos.Columns.Add("Fepag", Type.GetType("System.String"))
        dtPagos.Columns.Add("Concepto", Type.GetType("System.String"))
        dtPagos.Columns.Add("Importe", Type.GetType("System.Decimal"))
        dtPagos.Columns.Add("Tipmon", Type.GetType("System.String"))
        dtPagos.Columns.Add("Banco", Type.GetType("System.String"))
        dtPagos.Columns.Add("Iva", Type.GetType("System.Decimal"))
        dtPagos.Clear()

        ' El siguiente Stored Procedure trae todos los atributos de la factura correspondiente al anexo y al vencimiento dados

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Acepagov1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
            .Parameters.Add("@Letra", SqlDbType.NVarChar)
            .Parameters(1).Value = cLetra
        End With

        ' Llenar el DataSet a trav�s del DataAdapter, lo cual abre y cierra la conexi�n

        daFacturas.Fill(dsAgil, "Facturas")

        ' Te�ricamente, la tabla Facturas del dataset debe contener un solo registro

        drFactura = dsAgil.Tables("Facturas").Rows(0)

        ' Datos del Cliente

        cNombre = drFactura("Descr")
        cRfc = drFactura("Rfc")
        cCalle = RTrim(drFactura("Calle"))
        cColonia = RTrim(drFactura("Colonia"))
        cDelegacion = RTrim(drFactura("Delegacion"))
        cEstado = RTrim(drFactura("Estado"))
        cCopos = RTrim(drFactura("Copos"))
        cCliente = drFactura("Cliente")

        For i = 1 To 5
            Select Case i
                Case 1
                    If RTrim(drFactura("CuentadePago1")) <> "0" And RTrim(drFactura("FormadePago1")) <> "EFECTIVO" Then
                        cCuentaPago = drFactura("CuentadePago1")
                        cFormaPago = RTrim(drFactura("FormadePago1"))
                    ElseIf RTrim(drFactura("CuentadePago1")) = "0" And RTrim(drFactura("FormadePago1")) = "EFECTIVO" Then
                        cCuentaPago = "NO IDENTIFICABLE"
                        cFormaPago = RTrim(drFactura("FormadePago1"))
                    End If
                Case 2
                    If RTrim(drFactura("CuentadePago2")) <> "0" And RTrim(drFactura("FormadePago2")) <> "EFECTIVO" Then
                        cCuentaPago = cCuentaPago & "," & drFactura("CuentadePago2")
                        cFormaPago = cFormaPago & "," & RTrim(drFactura("FormadePago2"))
                    ElseIf RTrim(drFactura("CuentadePago2")) = "0" And RTrim(drFactura("FormadePago2")) = "EFECTIVO" Then
                        cCuentaPago = cCuentaPago & "," & "NO IDENTIFICABLE"
                        cFormaPago = cFormaPago & "," & RTrim(drFactura("FormadePago2"))
                    End If
                Case 3
                    If RTrim(drFactura("CuentadePago3")) <> "0" And RTrim(drFactura("FormadePago3")) <> "EFECTIVO" Then
                        cCuentaPago = cCuentaPago & "," & drFactura("CuentadePago3")
                        cFormaPago = cFormaPago & "," & RTrim(drFactura("FormadePago3"))
                    ElseIf RTrim(drFactura("CuentadePago3")) = "0" And RTrim(drFactura("FormadePago3")) = "EFECTIVO" Then
                        cCuentaPago = cCuentaPago & "," & "NO IDENTIFICABLE"
                        cFormaPago = cFormaPago & "," & RTrim(drFactura("FormadePago3"))
                    End If
                Case 4
                    If RTrim(drFactura("CuentadePago4")) <> "0" And RTrim(drFactura("FormadePago4")) <> "EFECTIVO" Then
                        cCuentaPago = cCuentaPago & "," & drFactura("CuentadePago4")
                        cFormaPago = cFormaPago & "," & RTrim(drFactura("FormadePago4"))
                    ElseIf RTrim(drFactura("CuentadePago4")) = "0" And RTrim(drFactura("FormadePago4")) = "EFECTIVO" Then
                        cCuentaPago = cCuentaPago & "," & "NO IDENTIFICABLE"
                        cFormaPago = cFormaPago & "," & RTrim(drFactura("FormadePago4"))
                    End If
                Case 5
                    If cCuentaPago = "" And cFormaPago = "" Then
                        cCuentaPago = "NO IDENTIFICABLE"
                        cFormaPago = "NO IDENTIFICABLE"
                    End If
            End Select
        Next

        ' Esta es una nueva forma de calcular el plazo que implement� a partir del 17 de octubre de 2011
        ' para determinar correctamente el plazo para frecuencias de pago diferentes a mensual


        CuentaPagos(cAnexo)

        ' Datos de la Factura

        cTipar = drFactura("Tipar")
        nTasaIVA = Round(drFactura("TasaIVA") / 100, 2)

        nFactura = drFactura("Factura")
        cFeven = drFactura("Feven")
        cFepag = drFactura("Fepag")
        nImporteFac = drFactura("ImporteFac")
        nSaldoFac = drFactura("SaldoFac")
        nPagado = nImporteFac - nSaldoFac

        nImporteFEGA = drFactura("ImporteFEGA")
        nBaseFEGA = Round(nImporteFEGA / (1 + nTasaIVA), 2)
        nIvaFEGA = Round(nImporteFEGA - nBaseFEGA, 2)

        nSeguroVida = drFactura("SeguroVida")

        nIvaOtros = drFactura("IvaOt")
        nInteresOtros = drFactura("InteresOt") + drFactura("VarOt")
        nCapitalOtros = drFactura("CapitalOt")

        nIvaInteres = drFactura("IvaPr")
        nIvaInteresSeg = drFactura("IvaSe")
        nInteres = drFactura("IntPr") + drFactura("VarPr")
        nInteresSEG = drFactura("IntSe") + drFactura("VarSe")
        nCapitalSeguro = drFactura("RenSe")
        nCapitalEquipo = drFactura("RenPr") - drFactura("IntPr")
        nIvaCapital = drFactura("IvaCapital")
        nBonifica = drFactura("Bonifica")

        'Codigo para facturas anteriores al primero de DICIEMBRE 2017*******
        If cSerie = "A" Then
            nRecibo = FOLIOS.FolioA
        ElseIf cSerie = "AB" Then
            nRecibo = FOLIOS.FolioBlanco
        ElseIf cSerie = "MXL" Then
            nRecibo = FOLIOS.FolioMXL
        End If

        If cFeven >= "20171201" And cSerie <> "AB" Then
            If FOLIOS.AnexosNoFacturables(cAnexo) <= 0 Then
                If FOLIOS.AvisoFacturado(nFactura) > 0 Then
                    'vencimientos YA FACTURADOS
                    cSerie = "REP"
                    nRecibo = FOLIOS.FolioPago
                    Metodo_Pago = "PPD"
                ElseIf nPagado = 0 And nMontoPago >= nImporteFac Then
                    'vencimientos pagados totalmente
                    Metodo_Pago = "PUE"
                ElseIf drFactura("Feven") <= drFactura("Fepag") And (nImporteFac - nMontoPago) <= 10 Then ' por saldos menores a 10 pesos
                    Metodo_Pago = "PUE"
                Else
                    'vencimientos pagados parcialmente
                    cSerie = "REP"
                    nRecibo = FOLIOS.FolioPago
                    Metodo_Pago = "PPD"
                End If
            Else
                    'vencimientos declarados no facturables
                    Metodo_Pago = "PUE"
            End If
        Else
            'vencimientos de antes de dic 2017
            Metodo_Pago = "PUE"
        End If
        cSerieMORA = "M"
        nReciboMORA = FOLIOS.FolioMora
        '*******************************************************************

        ' Los primeros conceptos que tengo que a�adir a la tabla dtPagos son los Moratorios y su IVA

        If nMoratorios > 0 Then
            drPago = dtPagos.NewRow()
            drPago("Anexo") = cAnexo
            drPago("Letra") = cLetra
            drPago("Tipos") = "2"
            drPago("Fepag") = cFecha
            drPago("Tipmon") = "01"
            drPago("Banco") = cBanco
            If cTipar = "B" Then
                drPago("Concepto") = "MORATORIOS MENSUALIDAD No. " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
            Else
                drPago("Concepto") = "MORATORIOS VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
            End If
            drPago("Importe") = nMoratorios
            drPago("Iva") = nIvaMoratorios
            dtPagos.Rows.Add(drPago)
            nMontoPago = Round(nMontoPago - nMoratorios, 2)
        End If

        If nIvaMoratorios > 0 Then
            drPago = dtPagos.NewRow()
            drPago("Anexo") = cAnexo
            drPago("Letra") = cLetra
            drPago("Tipos") = "2"
            drPago("Fepag") = cFecha
            drPago("Tipmon") = "01"
            drPago("Banco") = cBanco
            If cTipar = "B" Then
                drPago("Concepto") = "IVA MORATORIOS MENSUALIDAD No. " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
            Else
                drPago("Concepto") = "IVA MORATORIOS VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
            End If

            drPago("Importe") = nIvaMoratorios
            drPago("Iva") = 0
            dtPagos.Rows.Add(drPago)
            nMontoPago = Round(nMontoPago - nIvaMoratorios, 2)
        End If

        ' El siguiente arreglo de estructuras debe ser inicializado por cada factura que se pague ya que de ello depende la jerarquizaci�n del pago.
        ' Adem�s su conformaci�n depende del tipo de producto (es diferente para Arrendamiento Puro).

        If cFeven >= "20131001" Or cTipar = "P" Then

            ' Nueva forma de prelaci�n

            If nImporteFEGA > 0 Then
                aConcepto.Concepto = "FEGA"
                aConcepto.Importe = nBaseFEGA
                aConcepto.Porcentaje = nBaseFEGA / (nBaseFEGA + nIvaFEGA)
                aConcepto.Iva = nIvaFEGA
                aConceptos.Add(aConcepto)

                aConcepto.Concepto = "IVA FEGA"
                aConcepto.Importe = nIvaFEGA
                aConcepto.Porcentaje = 1
                aConcepto.Iva = 0
                aConceptos.Add(aConcepto)
            End If

            If nSeguroVida > 0 Then
                aConcepto.Concepto = "SEGURO DE VIDA"
                aConcepto.Importe = nSeguroVida
                aConcepto.Porcentaje = 1
                aConcepto.Iva = 0
                aConceptos.Add(aConcepto)
            End If

            If nInteresOtros > 0 Then
                aConcepto.Concepto = "INTERES OTROS ADEUDOS"
                aConcepto.Importe = nInteresOtros
                aConcepto.Porcentaje = nInteresOtros / (nInteresOtros + nIvaOtros)
                aConcepto.Iva = nIvaOtros
                aConceptos.Add(aConcepto)

                If nIvaOtros > 0 Then                                          ' Puede darse el caso en que haya Intereses pero no haya IVA de los intereses, por ejemplo
                    aConcepto.Concepto = "IVA INTERES OTROS ADEUDOS"           ' en un Cr�dito Refaccionario o Cr�dito Simple a Persona Moral o Persona F�sica con Actividad Empresarial
                    aConcepto.Importe = nIvaOtros
                    aConcepto.Porcentaje = 1
                    aConcepto.Iva = 0
                    aConceptos.Add(aConcepto)
                End If
            End If

            If nCapitalOtros > 0 Then
                aConcepto.Concepto = "CAPITAL OTROS ADEUDOS"
                aConcepto.Importe = nCapitalOtros
                aConcepto.Porcentaje = 1
                aConcepto.Iva = 0
                aConceptos.Add(aConcepto)
            End If

            If cTipar = "P" Then

                If drFactura("IntSe") + drFactura("VarSe") > 0 Then
                    aConcepto.Concepto = "INTERES SEGURO"
                    aConcepto.Importe = drFactura("IntSe") + drFactura("VarSe")
                    aConcepto.Porcentaje = (drFactura("IntSe") + drFactura("VarSe")) / (drFactura("IntSe") + drFactura("VarSe") + drFactura("IvaSe"))
                    aConcepto.Iva = drFactura("IvaSe")
                    aConceptos.Add(aConcepto)

                    If drFactura("IvaSe") > 0 Then                             ' Puede darse el caso en que haya Intereses pero no haya IVA de los intereses, por ejemplo
                        aConcepto.Concepto = "IVA INTERES SEGURO"              ' en un Cr�dito Refaccionario o Cr�dito Simple a Persona Moral o Persona F�sica con Actividad Empresarial
                        aConcepto.Importe = drFactura("IvaSe")
                        aConcepto.Porcentaje = 1
                        aConcepto.Iva = 0
                        aConceptos.Add(aConcepto)
                    End If
                End If

                If drFactura("Rense") > 0 Then
                    aConcepto.Concepto = "CAPITAL SEGURO"
                    aConcepto.Importe = drFactura("Rense")
                    aConcepto.Porcentaje = 1
                    aConcepto.Iva = 0
                    aConceptos.Add(aConcepto)
                End If

                If drFactura("RenPr") + drFactura("VarPr") > 0 Then
                    aConcepto.Concepto = "PAGO DE RENTA"
                    aConcepto.Importe = drFactura("RenPr") + drFactura("VarPr")
                    aConcepto.Porcentaje = (drFactura("RenPr") + drFactura("VarPr")) / (drFactura("RenPr") + drFactura("VarPr") + drFactura("IvaCapital") + drFactura("IvaPr"))
                    aConcepto.Iva = drFactura("IvaCapital") + drFactura("IvaPr")
                    aConceptos.Add(aConcepto)

                    aConcepto.Concepto = "IVA DEL PAGO DE RENTA"
                    aConcepto.Importe = drFactura("IvaCapital") + drFactura("IvaPr")
                    aConcepto.Porcentaje = 1
                    aConcepto.Iva = 0
                    aConceptos.Add(aConcepto)
                End If

            ElseIf cTipar = "B" Then
                If nCapitalEquipo > 0 Then
                    aConcepto.Concepto = "MENSUALIDAD"
                    aConcepto.Importe = nCapitalEquipo
                    aConcepto.Porcentaje = nCapitalEquipo / (nCapitalEquipo + nIvaCapital)
                    aConcepto.Iva = nIvaCapital
                    aConceptos.Add(aConcepto)

                    If nIvaCapital > 0 Then                                    ' Puede darse el caso en que haya Capital Equipo pero no haya IVA del Capital
                        aConcepto.Concepto = "IVA MENSUALIDAD"                     ' ya que �ste solamente existe para Arrendamiento Financiero
                        aConcepto.Importe = nIvaCapital
                        aConcepto.Porcentaje = 1
                        aConcepto.Iva = 0
                        aConceptos.Add(aConcepto)
                    End If
                End If
            Else

                If nInteresSEG > 0 Then
                    aConcepto.Concepto = "INTERES SEGURO"
                    aConcepto.Importe = nInteresSEG
                    aConcepto.Porcentaje = (drFactura("IntSe") + drFactura("VarSe")) / (drFactura("IntSe") + drFactura("VarSe") + drFactura("IvaSe"))
                    aConcepto.Iva = nIvaInteresSeg
                    aConceptos.Add(aConcepto)

                    If drFactura("IvaSe") > 0 Then                             ' Puede darse el caso en que haya Intereses pero no haya IVA de los intereses, por ejemplo
                        aConcepto.Concepto = "IVA INTERES SEGURO"              ' en un Cr�dito Refaccionario o Cr�dito Simple a Persona Moral o Persona F�sica con Actividad Empresarial
                        aConcepto.Importe = nIvaInteresSeg
                        aConcepto.Porcentaje = 1
                        aConcepto.Iva = 0
                        aConceptos.Add(aConcepto)
                    End If
                End If

                If nInteres > 0 Then
                    aConcepto.Concepto = "INTERESES"
                    aConcepto.Importe = nInteres
                    aConcepto.Porcentaje = nInteres / (nInteres + nIvaInteres)
                    aConcepto.Iva = nIvaInteres
                    aConceptos.Add(aConcepto)

                    If nIvaInteres > 0 Then                                    ' Puede darse el caso en que haya Intereses pero no haya IVA de los intereses, por ejemplo
                        aConcepto.Concepto = "IVA INTERESES"                   ' en un Cr�dito Refaccionario o Cr�dito Simple a Persona Moral o Persona F�sica con Actividad Empresarial
                        aConcepto.Importe = nIvaInteres
                        aConcepto.Porcentaje = 1
                        aConcepto.Iva = 0
                        aConceptos.Add(aConcepto)
                    End If
                End If



                If nCapitalSeguro > 0 Then
                    aConcepto.Concepto = "CAPITAL SEGURO"
                    aConcepto.Importe = nCapitalSeguro
                    aConcepto.Porcentaje = 1
                    aConceptos.Add(aConcepto)
                End If

                If nCapitalEquipo > 0 Then
                    aConcepto.Concepto = "CAPITAL EQUIPO"
                    aConcepto.Importe = nCapitalEquipo
                    aConcepto.Porcentaje = nCapitalEquipo / (nCapitalEquipo + nIvaCapital)
                    aConcepto.Iva = nIvaCapital
                    aConceptos.Add(aConcepto)

                    If nIvaCapital > 0 Then                                    ' Puede darse el caso en que haya Capital Equipo pero no haya IVA del Capital
                        aConcepto.Concepto = "IVA CAPITAL"                     ' ya que �ste solamente existe para Arrendamiento Financiero
                        aConcepto.Importe = nIvaCapital
                        aConcepto.Porcentaje = 1
                        aConcepto.Iva = 0
                        aConceptos.Add(aConcepto)

                        If nBonifica > 0 Then                                  ' Solamente puede haber bonificaci�n cuando existe IVA del Capital
                            aConcepto.Concepto = "BONIFICACION"
                            aConcepto.Importe = -nBonifica
                            aConcepto.Porcentaje = 1
                            aConcepto.Iva = 0
                            aConceptos.Add(aConcepto)
                        End If
                    End If
                End If

            End If

            If nPagado > 0 Then
                'AplicaPagoAnteriorII(aConceptos) '#ECT old
                aConceptos = AplicaPagoAnteriorIII(aConceptos)
            Else
                PagoTotal = True
            End If

            ' Al llegar aqu� existen 2 posibilidades: 

            ' Que sea el primer pago a la factura en cuyo caso no corri� AplicaPagoAnteriorII y los saldos del arreglo de conceptos est�n intactos o 
            ' Que sea un pago complementario (parcial o total) en cuyo caso corri� AplicaPagoAnteriorII y los saldos del arreglo de conceptos reflejan el adeudo de cada concepto

            ' Sea cual fuera lo ocurrido, procedo a aplicar el Monto del Pago

            For Each aConcepto In aConceptos

                If nMontoPago > 0 And aConcepto.Importe > 0 Then

                    cConcepto = aConcepto.Concepto

                    If nMontoPago >= aConcepto.Importe / aConcepto.Porcentaje Then

                        ' Pago completo del importe

                        nPagoConcepto = aConcepto.Importe
                        nMontoPago = nMontoPago - aConcepto.Importe
                        aConcepto.Importe = 0

                    Else
                        ' Pago parcial del importe
                        If aConcepto.Iva > 0 And nMontoPago < aConcepto.Importe + aConcepto.Importe Then
                            Factor = aConcepto.Iva / aConcepto.Importe
                            nPagoConcepto = Round(nMontoPago / (1 + Factor), 2)
                            aConcepto.Iva = Round(nMontoPago - nPagoConcepto, 2)
                            nMontoPago = aConcepto.Iva
                        Else
                            aConcepto.Importe = Round(nMontoPago * aConcepto.Porcentaje, 2)
                            nMontoPago = nMontoPago - aConcepto.Importe
                            nPagoConcepto = aConcepto.Importe
                            If cTipar = "B" Then
                                aConcepto.Iva = aConcepto.Importe * nTasaIVA
                            End If
                        End If
                    End If

                    drPago = dtPagos.NewRow()
                    drPago("Anexo") = cAnexo
                    drPago("Letra") = cLetra
                    drPago("Tipos") = "2"
                    drPago("Fepag") = cFecha
                    drPago("Tipmon") = "01"
                    drPago("Banco") = cBanco
                    If cTipar = "B" Then
                        drPago("Concepto") = cConcepto + " No. " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                    Else
                        drPago("Concepto") = cConcepto + " VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                    End If

                    drPago("Importe") = nPagoConcepto
                    drPago("Iva") = aConcepto.Iva
                    dtPagos.Rows.Add(drPago)

                End If

            Next

        Else

            ' La prelaci�n es la que se ven�a haciendo hasta el 22 de agosto de 2013

            aConcepto.Concepto = "FEGA"
            aConcepto.Importe = nImporteFEGA
            aConceptos.Add(aConcepto)

            aConcepto.Concepto = "SEGURO DE VIDA"
            aConcepto.Importe = nSeguroVida
            aConceptos.Add(aConcepto)

            aConcepto.Concepto = "IVA INTERES OTROS ADEUDOS"
            aConcepto.Importe = nIvaOtros
            aConceptos.Add(aConcepto)

            aConcepto.Concepto = "INTERES OTROS ADEUDOS"
            aConcepto.Importe = nInteresOtros
            aConceptos.Add(aConcepto)

            aConcepto.Concepto = "CAPITAL OTROS ADEUDOS"
            aConcepto.Importe = nCapitalOtros
            aConceptos.Add(aConcepto)

            aConcepto.Concepto = "IVA INTERESES"
            aConcepto.Importe = nIvaInteres
            aConceptos.Add(aConcepto)

            aConcepto.Concepto = "INTERESES"
            aConcepto.Importe = nInteres
            aConceptos.Add(aConcepto)

            aConcepto.Concepto = "IVA INTERESES SEGURO"
            aConcepto.Importe = nIvaInteresSeg
            aConceptos.Add(aConcepto)

            aConcepto.Concepto = "INTERES SEGURO"
            aConcepto.Importe = nInteresSEG
            aConceptos.Add(aConcepto)

            aConcepto.Concepto = "CAPITAL SEGURO"
            aConcepto.Importe = nCapitalSeguro
            aConceptos.Add(aConcepto)

            aConcepto.Concepto = "CAPITAL EQUIPO"
            aConcepto.Importe = nCapitalEquipo + nIvaCapital
            aConceptos.Add(aConcepto)

            If nSaldoFac = nMontoPago Then

                ' Se trata de un pago total a la factura y lo siguiente que tenemos que revisar es si se trata del primer pago o de un pago complementario

                If Val(cFepag) = 0 Then

                    ' Se trata del primer pago

                    PPTotal(dtPagos, aConceptos, drFactura, cFecha, cBanco)

                Else

                    ' Se trata de un pago complementario por lo que debe revisar la aplicaci�n de pagos anteriores

                    AplicaPagoAnterior(aConceptos, drFactura)
                    PCTotal(dtPagos, aConceptos, drFactura, cFecha, cBanco)

                End If

            Else

                ' Se trata de un pago parcial a la factura y lo siguiente que tenemos que revisar es si se trata del primer pago o de un pago complementario

                If Val(cFepag) = 0 Then

                    ' Se trata del primer pago

                    PPParcial(nMontoPago, dtPagos, aConceptos, drFactura, cFecha, cBanco)

                Else

                    ' Se trata de un pago complementario por lo que debe revisar la aplicaci�n de pagos
                    ' anteriores

                    AplicaPagoAnterior(aConceptos, drFactura)
                    PCParcial(nMontoPago, dtPagos, aConceptos, drFactura, cFecha, cBanco)

                End If

            End If

        End If




        cPrevio = "N"
        If Mid(cFeven, 1, 6) > Mid(cFecha, 1, 6) Then
            cPrevio = "S"
        End If

        ' Aqu� se descuentan los pagos que se hayan hecho a la factura exceptuando Moratorios y el IVA de los Moratorios
        ' a fin de determinar el saldo de la factura

        For Each drPago In dtPagos.Rows

            If cTipar = "B" Then
                If InStr(drPago("Concepto"), "No.") > 0 Then
                    cObserva = Mid(drPago("Concepto"), 1, InStr(drPago("Concepto"), "No.", CompareMethod.Text) - 2)
                End If
            Else
                cObserva = Mid(drPago("Concepto"), 1, InStr(drPago("Concepto"), "VENCIMIENTO", CompareMethod.Text) - 2)
            End If

            nImporte = drPago("Importe")

            If nImporte <> 0 And InStr(cObserva, "MORATORIOS", CompareMethod.Text) = 0 Then

                nSaldoFac = Round(nSaldoFac - nImporte, 2)

            End If

        Next

        ' Tengo que actualizar la tabla Facturas, considerando que si el saldo es menor o igual a 10 pesos
        ' debo liquidarla con cargo a resultados

        If nSaldoFac < 0 Then
            nSaldoFac = 0
        End If

        lCredito = False
        If (cTipar <> "L" And nSaldoFac <= 10) Or (cTipar = "L" And nSaldoFac <= 1) Then         ' Factura totalmente pagada
            If nSaldoFac > 0 Then
                lCredito = True
                strUpdate = "UPDATE Facturas SET SaldoFac = 0" & ", Fepag = '" & cFechaPago & "', Indpag = '" & "P" & "' WHERE Anexo = '" & cAnexo & "' AND Letra = '" & cLetra & "'"
            Else
                strUpdate = "UPDATE Facturas SET SaldoFac = " & nSaldoFac & ", Fepag = '" & cFechaPago & "', Indpag = '" & "P" & "' WHERE Anexo = '" & cAnexo & "' AND Letra = '" & cLetra & "'"
            End If
        Else                            ' Factura parcialmente pagada

            strUpdate = "UPDATE Facturas SET SaldoFac = " & nSaldoFac & ", Fepag = '" & cFechaPago & "' WHERE Anexo = '" & cAnexo & "' AND Letra = '" & cLetra & "'"

        End If

        cnAgil.Open()
        cm1 = New SqlCommand(strUpdate, cnAgil)
        cm1.ExecuteNonQuery()
        cnAgil.Close()

        nPrevioCartera = 0
        nPrevioOtros = 0
        nAbonoCartera = 0
        nAbonoOtros = 0

        ' En este punto est� hecha la aplicaci�n del pago, por lo que procedo a actualizar la historia de pagos y a generar los asientos contables 

        nSubTotal = 0
        nIva = 0
        nTotal = 0

        cnAgil.Open()

        For Each drPago In dtPagos.Rows

            cAnexo = drPago("Anexo")
            cLetra = drPago("Letra")
            cTipos = drPago("Tipos")
            cFepag = drPago("Fepag")
            If cTipar = "B" Then
                If InStr(drPago("Concepto"), "No.") > 0 Then
                    cObserva = Mid(drPago("Concepto"), 1, InStr(drPago("Concepto"), "No.", CompareMethod.Text) - 2)
                End If
                cCatal = "B"
            Else
                cObserva = Mid(drPago("Concepto"), 1, InStr(drPago("Concepto"), "VENCIMIENTO", CompareMethod.Text) - 2)
                cCatal = "F"
            End If
            nImporte = drPago("Importe")
            nEsp = 0
            cTipmon = drPago("Tipmon")
            cBanco = drPago("Banco")

            If nImporte <> 0 Then

                ' Actualizaci�n de la Historia de Pagos

                strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1, InstrumentoMonetario, FechaPago)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & "6" & "', '"
                If InStr(cObserva, "MORATORIOS", CompareMethod.Text) > 0 Then
                    strInsert = strInsert & cSerieMORA & "', "
                    strInsert = strInsert & nReciboMORA & ", '"
                Else
                    strInsert = strInsert & cSerie & "', "
                    strInsert = strInsert & nRecibo & ", '"
                End If
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cBanco & "', '"
                strInsert = strInsert & cCheque & "', '"
                If InStr(cObserva, "MORATORIOS", CompareMethod.Text) > 0 Then
                    strInsert = strInsert & "N" & "', '"
                Else
                    strInsert = strInsert & "S" & "', '"
                End If
                strInsert = strInsert & nImporte & "', '"
                strInsert = strInsert & cObserva
                strInsert = strInsert & "','" & InstrumentoMonetario & "','"
                strInsert += FechaRealPago.ToString("MM/dd/yyyy") & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
                If InStr(cObserva, "IVA", CompareMethod.Text) > 0 Then
                    nIva = nIva + nImporte
                Else
                    nSubTotal = nSubTotal + nImporte
                End If
                nTotal = nTotal + nImporte

            End If


            ' Aqu� se generan los asientos contables

            If InStr(cObserva, "MORATORIOS", CompareMethod.Text) > 0 Then

                ' El pago se hizo a destiempo por lo que genera intereses moratorios

                If cObserva = "MORATORIOS" Or cObserva = "MORATORIOS MENSUALIDAD" Then
                    drMovimiento = dtMovimientos.NewRow()
                    drMovimiento("Anexo") = cAnexo
                    drMovimiento("Letra") = cLetra
                    drMovimiento("Tipos") = cTipos
                    drMovimiento("Fepag") = cFepag
                    drMovimiento("Cve") = "22"
                    drMovimiento("Imp") = nImporte
                    drMovimiento("Tip") = "S"
                    drMovimiento("Catal") = cCatal
                    drMovimiento("Esp") = nEsp
                    drMovimiento("Coa") = "1"
                    drMovimiento("Tipmon") = cTipmon
                    drMovimiento("Banco") = cBanco
                    drMovimiento("Concepto") = cCheque
                    drMovimiento("Factura") = cSerieMORA & nReciboMORA '#ECT pala ligar folios Fiscales
                    drMovimiento("Grupo") = NoGrupo
                    dtMovimientos.Rows.Add(drMovimiento)
                End If

                If cObserva = "IVA MORATORIOS" Then
                    drMovimiento = dtMovimientos.NewRow()
                    drMovimiento("Anexo") = cAnexo
                    drMovimiento("Letra") = cLetra
                    drMovimiento("Tipos") = cTipos
                    drMovimiento("Fepag") = cFepag
                    drMovimiento("Cve") = "27"
                    drMovimiento("Imp") = nImporte
                    drMovimiento("Tip") = "S"
                    drMovimiento("Catal") = cCatal
                    drMovimiento("Esp") = nEsp
                    drMovimiento("Coa") = "1"
                    drMovimiento("Tipmon") = cTipmon
                    drMovimiento("Banco") = cBanco
                    drMovimiento("Concepto") = cCheque
                    drMovimiento("Factura") = cSerieMORA & nReciboMORA '#ECT pala ligar folios Fiscales
                    drMovimiento("Grupo") = NoGrupo
                    dtMovimientos.Rows.Add(drMovimiento)
                End If

            Else

                If cPrevio = "S" Then

                    ' El pago se hizo con anticipaci�n 

                    If cFeven < "20080701" Then

                        ' Las facturas anteriores a julio 2008 afectan �nicamente a la cartera exigible normal;
                        ' esto es, la cartera exigible del tipo de operaci�n que se trate. Por ejemplo:
                        ' cartera exigible de Arrendamiento Financiero,
                        ' cartera exigible de Cr�dito Refaccionario,
                        ' cartera exigible de Cr�dito Simple

                        nPrevioCartera = Round(nPrevioCartera + nImporte, 2)

                    Else

                        ' Las facturas de julio 2008 y posteriores afectan a la cartera exigible normal y
                        ' a la cartera exigible de cr�dito simple (siempre y cuando existan Otros Adeudos)

                        If cObserva = "IVA INTERES OTROS ADEUDOS" Or cObserva = "INTERES OTROS ADEUDOS" Or cObserva = "CAPITAL OTROS ADEUDOS" Then
                            nPrevioOtros = Round(nPrevioOtros + nImporte, 2)
                        Else
                            nPrevioCartera = Round(nPrevioCartera + nImporte, 2)
                        End If

                    End If

                Else

                    ' El pago se hizo a la exigibilidad

                    If cFeven < "20080701" Then

                        ' Las facturas anteriores a julio 2008 afectan �nicamente a la cartera exigible normal

                        nAbonoCartera = Round(nAbonoCartera + nImporte, 2)

                    Else

                        ' Las facturas de julio 2008 y posteriores afectan a la cartera exigible normal y
                        ' a la cartera exigible de cr�dito simple (siempre y cuando existan Otros Adeudos)

                        If cObserva = "IVA INTERES OTROS ADEUDOS" Or cObserva = "INTERES OTROS ADEUDOS" Or cObserva = "CAPITAL OTROS ADEUDOS" Then
                            nAbonoOtros = Round(nAbonoOtros + nImporte, 2)
                        Else
                            nAbonoCartera = Round(nAbonoCartera + nImporte, 2)
                        End If

                    End If

                End If

            End If

            ' Asientos que cancelan la provisi�n de IVA Capital

            If cObserva = "IVA CAPITAL" Then

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "09" 'IVA PENDIENTE DE COBRO             
                drMovimiento("Imp") = nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cCatal
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "0"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "08" 'IVA DE LA OPERACION                
                drMovimiento("Imp") = nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cCatal
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

            End If
            If cObserva = "IVA MENSUALIDAD" Then

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "05" 'IVA PENDIENTE DE COBRO             
                drMovimiento("Imp") = nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cCatal
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "0"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "14" 'IVA DE LA OPERACION                
                drMovimiento("Imp") = nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cCatal
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

            End If
            If cObserva = "IVA DEL PAGO DE RENTA" Then

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "09" 'IVA PENDIENTE DE COBRO             
                drMovimiento("Imp") = nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = "P"
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "0"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "08" 'IVA DE LA OPERACION                
                drMovimiento("Imp") = nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = "P"
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

            End If

            If cObserva = "APLICACION DEPOSITO vs IVA CAPITAL" Then

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "20" 'IVA DEPOSITO EN GARANTIA           
                drMovimiento("Imp") = -nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cCatal
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "0"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "09" 'IVA PENDIENTE DE COBRO             
                drMovimiento("Imp") = -nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cCatal
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

            End If

            ' Asientos que cancelan la provisi�n de IVA INTERESES

            'If cObserva = "IVA INTERESES" And IVA_Interes_TasaReal = False Then '#ECT para solo hacer el registro en caso de pago de iva en base a flujo
            If cObserva = "IVA INTERESES" And (cFeven <= "20151231" Or IVA_Interes_TasaReal = False) Then '#ECT para solo hacer el registro en caso de pago de iva en base a flujo

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "09"
                drMovimiento("Imp") = nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cCatal
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "0"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "21" 'IVA INTERESES                      
                drMovimiento("Imp") = nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cCatal
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

            End If

            ' Asientos que cancelan la provisi�n de IVA INTERES OTROS ADEUDOS

            If cObserva = "IVA INTERES OTROS ADEUDOS" And (cFeven <= "20151231" Or IVA_Interes_TasaReal = False) Then '#ECT para solo hacer el registro en caso de pago de iva en base a flujo

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "09"
                drMovimiento("Imp") = nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cCatal
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "0"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "33"
                drMovimiento("Imp") = nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cCatal
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

            End If

            ' Asientos que cancelan la provisi�n de IVA FEGA

            If cObserva = "IVA FEGA" Then

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "09"
                drMovimiento("Imp") = nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cCatal
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "0"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = cTipos
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "33"
                drMovimiento("Imp") = nImporte
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cCatal
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = cTipmon
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

            End If

        Next

        If lCredito = True Then

            If (cTipar = "L" And nSaldoFac <= 1) Then
                cObserva = "CANCELACION SALDO MENOR A 1 PESO"
            Else
                cObserva = "CANCELACION SALDO MENOR A 10 PESOS"
            End If

            strInsert = "INSERT INTO Historia(Documento, Serie, Numero, Fecha, Anexo, Letra, Banco, Cheque, Balance, Importe, Observa1, InstrumentoMonetario, FechaPago)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & "6" & "', '"
            strInsert = strInsert & cSerie & "', "
            strInsert = strInsert & nRecibo & ", '"
            strInsert = strInsert & cFecha & "', '"
            strInsert = strInsert & cAnexo & "', '"
            strInsert = strInsert & cLetra & "', '"
            strInsert = strInsert & cBanco & "', '"
            strInsert = strInsert & cCheque & "', '"
            strInsert = strInsert & "S" & "', '"
            strInsert = strInsert & nSaldoFac & "', '"
            strInsert = strInsert & cObserva
            strInsert = strInsert & "','" & InstrumentoMonetario & "','"
            strInsert += FechaRealPago.ToString("MM/dd/yyyy") & "')"
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()

            drMovimiento = dtMovimientos.NewRow()
            drMovimiento("Anexo") = cAnexo
            drMovimiento("Letra") = cLetra
            drMovimiento("Tipos") = cTipos
            drMovimiento("Fepag") = cFepag
            drMovimiento("Cve") = "34"
            drMovimiento("Imp") = nSaldoFac
            drMovimiento("Tip") = "S"
            drMovimiento("Catal") = cCatal
            drMovimiento("Esp") = nEsp
            drMovimiento("Coa") = "0"
            drMovimiento("Tipmon") = cTipmon
            drMovimiento("Banco") = cBanco
            drMovimiento("Concepto") = cCheque
            drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
            drMovimiento("Grupo") = NoGrupo
            dtMovimientos.Rows.Add(drMovimiento)

            drMovimiento = dtMovimientos.NewRow()
            drMovimiento("Anexo") = cAnexo
            drMovimiento("Letra") = cLetra
            drMovimiento("Tipos") = cTipos
            drMovimiento("Fepag") = cFepag
            Select Case cTipar
                Case "F"
                    drMovimiento("Cve") = "03"
                Case "P"
                    drMovimiento("Cve") = "03"
                Case "R"
                    drMovimiento("Cve") = "50"
                Case "S"
                    drMovimiento("Cve") = "56"
                Case "L"
                    drMovimiento("Cve") = "56"
                Case "B"
                    drMovimiento("Cve") = "11"
            End Select
            drMovimiento("Imp") = nSaldoFac
            drMovimiento("Tip") = "S"
            drMovimiento("Catal") = cCatal
            drMovimiento("Esp") = nEsp
            drMovimiento("Coa") = "1"
            drMovimiento("Tipmon") = cTipmon
            drMovimiento("Banco") = cBanco
            drMovimiento("Concepto") = cCheque
            drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
            drMovimiento("Grupo") = NoGrupo
            dtMovimientos.Rows.Add(drMovimiento)

        End If

        If cPrevio = "S" Then

            If nPrevioCartera > 0 Then

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = "2"
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "23"
                drMovimiento("Imp") = nPrevioCartera
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = "F"
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = "01"
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

                ' Aqu� tengo que insertar un registro en el archivo de Cobros por Aplicar

                strInsert = "INSERT INTO Cobrosxa(Factura, Feven, Anexo, Letra, Tipar, Importe)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & nFactura & "', '"
                strInsert = strInsert & cFeven & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & cTipar & "', '"     ' En este rengl�n se aplica al tipo de operaci�n que se trate (AF, CR, CS)
                strInsert = strInsert & nPrevioCartera
                strInsert = strInsert & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()

            End If

            If nPrevioOtros > 0 Then

                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = "2"
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "23"
                drMovimiento("Imp") = nPrevioOtros
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = "F"
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = "01"
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)

                ' Aqu� tengo que insertar un registro en el archivo de Cobros por Aplicar

                strInsert = "INSERT INTO Cobrosxa(Factura, Feven, Anexo, Letra, Tipar, Importe)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & nFactura & "', '"
                strInsert = strInsert & cFeven & "', '"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cLetra & "', '"
                strInsert = strInsert & "S" & "', '"        ' En este rengl�n se forza a que se aplique a Cr�dito Simple
                strInsert = strInsert & nPrevioOtros
                strInsert = strInsert & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()

            End If

        Else

            If nAbonoCartera > 0 Then
                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = "2"
                drMovimiento("Fepag") = cFepag
                Select Case cTipar
                    Case "F"
                        drMovimiento("Cve") = "03"
                    Case "P"
                        drMovimiento("Cve") = "03"
                    Case "R"
                        drMovimiento("Cve") = "50"
                    Case "S"
                        drMovimiento("Cve") = "56"
                    Case "L"
                        drMovimiento("Cve") = "56"
                    Case "B"
                        drMovimiento("Cve") = "11"
                End Select
                drMovimiento("Imp") = nAbonoCartera
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cTipar
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = "01"
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)
            End If

            If nAbonoOtros > 0 Then
                drMovimiento = dtMovimientos.NewRow()
                drMovimiento("Anexo") = cAnexo
                drMovimiento("Letra") = cLetra
                drMovimiento("Tipos") = "2"
                drMovimiento("Fepag") = cFepag
                drMovimiento("Cve") = "56"
                drMovimiento("Imp") = nAbonoOtros
                drMovimiento("Tip") = "S"
                drMovimiento("Catal") = cTipar
                drMovimiento("Esp") = nEsp
                drMovimiento("Coa") = "1"
                drMovimiento("Tipmon") = "01"
                drMovimiento("Banco") = cBanco
                drMovimiento("Concepto") = cCheque
                drMovimiento("Factura") = cSerie & nRecibo '#ECT pala ligar folios Fiscales
                drMovimiento("Grupo") = NoGrupo
                dtMovimientos.Rows.Add(drMovimiento)
            End If
        End If


        cnAgil.Close()
        cnAgil.Dispose()
        cm1.Dispose()

        ' Una vez que cerr� la conexi�n y que gener� los asientos contables, procedo a generar el archivo de texto para la factura electr�nica de pago

        dsAgil.Tables.Remove("Facturas")

        'Dim stmFactura As New FileStream("C:\Facturas\FACTURA_" & cSerie & "_" & nRecibo & ".txt", FileMode.Create, FileAccess.Write, FileShare.None)
        'Dim stmWriter As New StreamWriter(stmFactura, System.Text.Encoding.Default)

        If Not Directory.Exists("C:\Facturas\") Then
            Directory.CreateDirectory("C:\Facturas\")
        End If
        Dim Ruta As String = "C:\Facturas\FACTURA_"
        If cSerie = "AB" Then
            Ruta = "C:\Facturas\AppBlanco\FACTURA_"
            If Not Directory.Exists("C:\Facturas\AppBlanco\") Then
                Directory.CreateDirectory("C:\Facturas\AppBlanco\")
            End If
        End If

        Dim stmWriter As New StreamWriter(Ruta & cSerie & "_" & nRecibo & ".txt", False, System.Text.Encoding.Default)
        stmWriter.WriteLine("H1|" & FECHA_APLICACION.ToShortDateString & "|" & Metodo_Pago & "|" & Forma_Pago & "|" & cCheque & "|" & FechaRealPago.ToShortDateString)

        cRenglon = "H3|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|" & cSerie & "|" & nRecibo & "|" & Trim(cNombre) & "|" &
        Trim(cCalle) & "|||" & Trim(cColonia) & "|" & Trim(cDelegacion) & "|" & Trim(cEstado) & "|" & cCopos & "|" & cCuentaPago & "|" & cFormaPago & "|MEXICO|" & Trim(cRfc) & "|M.N.|" &
        "|FACTURA|" & cCliente & "|LEANDRO VALLE 402||REFORMA Y FFCCNN|TOLUCA|ESTADO DE MEXICO|50070|MEXICO|" & cAnexo & "|" & cLetra & "|"
        stmWriter.WriteLine(cRenglon)

        For Each drPago In dtPagos.Rows
            If InStr(Trim(drPago("Concepto")), "MORATORI") <= 0 Then
                cRenglon = "D1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|" & cSerie & "|" & nRecibo & "|1|||" & Trim(drPago("Concepto")) & "||" & drPago("Importe") & "|" & drPago("Iva")
                stmWriter.WriteLine(cRenglon)
            End If
        Next

        stmWriter.Flush()
        stmWriter.Close()

        If nMoratorios > 0 Then
            Dim stmWriter2 As New StreamWriter(Ruta & cSerieMORA & "_" & nReciboMORA & ".txt")

            stmWriter2.WriteLine("H1|" & FECHA_APLICACION.ToShortDateString & "|PUE|" & Forma_Pago & "|" & cCheque & "|" & FechaRealPago.ToShortDateString)

            cRenglon = "H3|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|" & cSerieMORA & "|" & nReciboMORA & "|" & Trim(cNombre) & "|" &
            Trim(cCalle) & "|||" & Trim(cColonia) & "|" & Trim(cDelegacion) & "|" & Trim(cEstado) & "|" & cCopos & "|" & cCuentaPago & "|" & cFormaPago & "|MEXICO|" & Trim(cRfc) & "|M.N.|" &
            "|FACTURA|" & cCliente & "|LEANDRO VALLE 402||REFORMA Y FFCCNN|TOLUCA|ESTADO DE MEXICO|50070|MEXICO|" & cAnexo & "|" & cLetra & "|"
            stmWriter2.WriteLine(cRenglon)

            For Each drPago In dtPagos.Rows
                If InStr(Trim(drPago("Concepto")), "MORATORI") Then
                    cRenglon = "D1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|" & cSerieMORA & "|" & nReciboMORA & "|1|||" & Trim(drPago("Concepto")) & "||" & drPago("Importe") & "|" & drPago("Iva")
                    stmWriter2.WriteLine(cRenglon)
                End If
            Next

            stmWriter2.Close()
            FOLIOS.ConsumeFolioMora()
        End If

        If cSerie = "REP" Then
            FOLIOS.ConsumeFolioPago()
        ElseIf cSerie = "AB" Then
            FOLIOS.ConsumeFolioBlanco()
        ElseIf cSerie = "A" Then
            FOLIOS.ConsumeFolioA()
        ElseIf cSerie = "MXL" Then
            FOLIOS.ConsumeFolioMXL()
        End If

        If FOLIOS.AvisoFacturado(nFactura) <= 0 And cSerie <> "REP" And Metodo_Pago = "PUE" Then
            FOLIOS.FacturaAviso(cSerie, nRecibo, nFactura)
        End If

        Try

        Catch eException As Exception
            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
        End Try

    End Sub

    Private Sub PPTotal(ByRef dtPagos As DataTable, ByVal aConceptos As ArrayList, ByVal drFactura As DataRow, ByVal cFecha As String, ByVal cBanco As String)

        ' Declaraci�n de variables de datos

        Dim cAnexo As String = ""
        Dim cLetra As String = ""
        Dim drPago As DataRow
        Dim nBonifica As Decimal = 0
        Dim nCapitalEquipo As Decimal = 0
        Dim nIvaCapital As Decimal = 0
        Dim nPorieq As Decimal = 0

        cAnexo = drFactura("Anexo")
        nCapitalEquipo = drFactura("RenPr") - drFactura("IntPr")
        nIvaCapital = drFactura("IvaCapital")
        nBonifica = drFactura("Bonifica")
        cLetra = drFactura("Letra")
        nPorieq = drFactura("Porieq")
        nImporteFEGA = drFactura("ImporteFEGA")


        For Each aConcepto In aConceptos

            If aConcepto.Importe > 0 Then

                If aConcepto.Concepto = "CAPITAL EQUIPO" Then
                    drPago = dtPagos.NewRow()
                    drPago("Anexo") = cAnexo
                    drPago("Letra") = cLetra
                    drPago("Tipos") = "2"
                    drPago("Fepag") = cFecha
                    drPago("Tipmon") = "01"
                    drPago("Banco") = cBanco
                    drPago("Concepto") = "CAPITAL EQUIPO VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                    drPago("Importe") = nCapitalEquipo
                    dtPagos.Rows.Add(drPago)
                    If nBonifica > 0 Then
                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = "APLICACION DEPOSITO vs CAPITAL VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = Round(-nBonifica / (1 + (nPorieq / 100)), 2)
                        dtPagos.Rows.Add(drPago)
                        nBonifica = Round(nBonifica - Round(nBonifica / (1 + (nPorieq / 100)), 2), 2)
                    End If
                    If nIvaCapital > 0 Then
                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = "IVA CAPITAL VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = nIvaCapital
                        dtPagos.Rows.Add(drPago)
                        If nBonifica > 0 Then
                            drPago = dtPagos.NewRow()
                            drPago("Anexo") = cAnexo
                            drPago("Letra") = cLetra
                            drPago("Tipos") = "2"
                            drPago("Fepag") = cFecha
                            drPago("Tipmon") = "01"
                            drPago("Banco") = cBanco
                            drPago("Concepto") = "APLICACION DEPOSITO vs IVA CAPITAL VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                            drPago("Importe") = -nBonifica
                            dtPagos.Rows.Add(drPago)
                            nBonifica = 0
                        End If
                    End If

                ElseIf aConcepto.Concepto = "FEGA" Then

                    drPago = dtPagos.NewRow()
                    drPago("Anexo") = cAnexo
                    drPago("Letra") = cLetra
                    drPago("Tipos") = "2"
                    drPago("Fepag") = cFecha
                    drPago("Tipmon") = "01"
                    drPago("Banco") = cBanco
                    drPago("Concepto") = "FEGA VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                    drPago("Importe") = nBaseFEGA
                    dtPagos.Rows.Add(drPago)

                    drPago = dtPagos.NewRow()
                    drPago("Anexo") = cAnexo
                    drPago("Letra") = cLetra
                    drPago("Tipos") = "2"
                    drPago("Fepag") = cFecha
                    drPago("Tipmon") = "01"
                    drPago("Banco") = cBanco
                    drPago("Concepto") = "IVA FEGA VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                    drPago("Importe") = nIvaFEGA
                    dtPagos.Rows.Add(drPago)

                Else

                    drPago = dtPagos.NewRow()
                    drPago("Anexo") = cAnexo
                    drPago("Letra") = cLetra
                    drPago("Tipos") = "2"
                    drPago("Fepag") = cFecha
                    drPago("Tipmon") = "01"
                    drPago("Banco") = cBanco
                    If cTipar = "B" Then
                        drPago("Concepto") = aConcepto.Concepto + " No. " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                    Else
                        drPago("Concepto") = aConcepto.Concepto + " VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                    End If

                    drPago("Importe") = aConcepto.Importe
                    dtPagos.Rows.Add(drPago)

                End If

            End If

        Next

    End Sub

    Private Sub PCTotal(ByRef dtPagos As DataTable, ByVal aConceptos As ArrayList, ByVal drFactura As DataRow, ByVal cFecha As String, ByVal cBanco As String)

        Dim cAnexo As String
        Dim cLetra As String
        Dim drPago As DataRow
        Dim nAplicacionDGvsCV As Decimal = 0
        Dim nAplicacionDGvsIC As Decimal = 0
        Dim nBonifica As Decimal = 0
        Dim nCapitalEquipo As Decimal = 0
        Dim nDiferenciaPorcentual As Decimal = 0
        Dim nIvaCapital As Decimal = 0
        Dim nPorieq As Decimal = 0
        Dim nPorcentajeActual As Decimal = 0
        Dim nPorcentajeOriginal As Decimal = 0

        cAnexo = drFactura("Anexo")
        nCapitalEquipo = drFactura("RenPr") - drFactura("IntPr")
        nIvaCapital = drFactura("IvaCapital")
        nBonifica = drFactura("Bonifica")
        cLetra = drFactura("Letra")
        nPorieq = drFactura("Porieq")
        nTasaIVA = Round(drFactura("TasaIVA") / 100, 2)

        If cTipar = "P" Then
            nCapitalEquipo = drFactura("RenPr") - drFactura("IntPr") + drFactura("VarPr")
        End If

        For Each aConcepto In aConceptos

            If aConcepto.Importe > 0 Then

                If aConcepto.Concepto = "CAPITAL EQUIPO" Then

                    If nIvaCapital > 0 Then

                        ' Calcular la base tanto del IVA al 16% como del IVA al 15%

                        nPorcentajeActual = Round(nIvaCapital / nCapitalEquipo, 2)                  ' IVA = 0.16
                        nPorcentajeOriginal = Round(nPorieq / 100, 2)                               ' IVA = 0.15
                        nDiferenciaPorcentual = Round(nPorcentajeActual - nPorcentajeOriginal, 2)   ' Diferencia = 0.01

                        nIvaCapital = Round(aConcepto.Importe / (1 + nPorcentajeActual), 2)
                        nIvaCapital = Round(nIvaCapital * nPorcentajeActual, 2)

                        If nBonifica > 0 Then

                            ' Calcular el importe de la bonificaci�n que le corresponde

                            nBonifica = Round(aConcepto.Importe / (1 + nPorcentajeActual), 2)
                            nBonifica = Round(nBonifica * nPorcentajeOriginal, 2)

                        End If

                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = "CAPITAL EQUIPO VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = Round(aConcepto.Importe - nIvaCapital, 2)
                        dtPagos.Rows.Add(drPago)
                        If nBonifica > 0 Then
                            nAplicacionDGvsCV = Round(nBonifica / (1 + nPorcentajeOriginal), 2)
                            drPago = dtPagos.NewRow()
                            drPago("Anexo") = cAnexo
                            drPago("Letra") = cLetra
                            drPago("Tipos") = "2"
                            drPago("Fepag") = cFecha
                            drPago("Tipmon") = "01"
                            drPago("Banco") = cBanco
                            drPago("Concepto") = "APLICACION DEPOSITO vs CAPITAL VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                            drPago("Importe") = -nAplicacionDGvsCV
                            dtPagos.Rows.Add(drPago)
                        End If
                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = "IVA CAPITAL VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = Round(nIvaCapital, 2)
                        dtPagos.Rows.Add(drPago)
                        If nBonifica > 0 Then
                            nAplicacionDGvsIC = Round(nBonifica - nAplicacionDGvsCV, 2)
                            drPago = dtPagos.NewRow()
                            drPago("Anexo") = cAnexo
                            drPago("Letra") = cLetra
                            drPago("Tipos") = "2"
                            drPago("Fepag") = cFecha
                            drPago("Tipmon") = "01"
                            drPago("Banco") = cBanco
                            drPago("Concepto") = "APLICACION DEPOSITO vs IVA CAPITAL VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                            drPago("Importe") = -nAplicacionDGvsIC
                            dtPagos.Rows.Add(drPago)
                        End If
                    Else
                        ' La operaci�n no tuvo IVA MOI, por lo que tampoco tiene Dep�sito en Garant�a
                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = "CAPITAL EQUIPO VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = aConcepto.Importe
                        dtPagos.Rows.Add(drPago)
                    End If

                ElseIf aConcepto.Concepto = "FEGA" Then

                    nImporteFEGA = aConcepto.Importe
                    nBaseFEGA = Round(nImporteFEGA / (1 + nTasaIVA), 2)
                    nIvaFEGA = Round(nImporteFEGA - nBaseFEGA, 2)

                    drPago = dtPagos.NewRow()
                    drPago("Anexo") = cAnexo
                    drPago("Letra") = cLetra
                    drPago("Tipos") = "2"
                    drPago("Fepag") = cFecha
                    drPago("Tipmon") = "01"
                    drPago("Banco") = cBanco
                    drPago("Concepto") = "FEGA VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                    drPago("Importe") = nBaseFEGA
                    dtPagos.Rows.Add(drPago)

                    drPago = dtPagos.NewRow()
                    drPago("Anexo") = cAnexo
                    drPago("Letra") = cLetra
                    drPago("Tipos") = "2"
                    drPago("Fepag") = cFecha
                    drPago("Tipmon") = "01"
                    drPago("Banco") = cBanco
                    drPago("Concepto") = "IVA FEGA VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                    drPago("Importe") = nIvaFEGA
                    dtPagos.Rows.Add(drPago)

                Else

                    drPago = dtPagos.NewRow()
                    drPago("Anexo") = cAnexo
                    drPago("Letra") = cLetra
                    drPago("Tipos") = "2"
                    drPago("Fepag") = cFecha
                    drPago("Tipmon") = "01"
                    drPago("Banco") = cBanco
                    If cTipar = "B" Then
                        drPago("Concepto") = aConcepto.Concepto + " No. " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                    Else
                        drPago("Concepto") = aConcepto.Concepto + " VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                    End If
                    drPago("Importe") = aConcepto.Importe
                    dtPagos.Rows.Add(drPago)

                End If

            End If

        Next

    End Sub

    Private Sub PPParcial(ByVal nImportePago As Decimal, ByRef dtPagos As DataTable, ByVal aConceptos As ArrayList, ByVal drFactura As DataRow, ByVal cFecha As String, ByVal cBanco As String)

        ' Declaraci�n de variables de datos

        Dim cAnexo As String
        Dim cLetra As String
        Dim drPago As DataRow
        Dim lCompleto As Boolean
        Dim nAplicacionDGvsCV As Decimal = 0
        Dim nAplicacionDGvsIC As Decimal = 0
        Dim nBonifica As Decimal = 0
        Dim nCapitalEquipo As Decimal = 0
        Dim nDiferenciaPorcentual As Decimal = 0
        Dim nIvaCapital As Decimal = 0
        Dim nParcial As Decimal = 0
        Dim nPorieq As Decimal = 0
        Dim nPorcentajeActual As Decimal = 0
        Dim nPorcentajeOriginal As Decimal = 0

        cAnexo = drFactura("Anexo")
        nCapitalEquipo = drFactura("RenPr") - drFactura("IntPr")
        nIvaCapital = drFactura("IvaCapital")
        nBonifica = drFactura("Bonifica")
        cLetra = drFactura("Letra")
        nPorieq = drFactura("Porieq")        ' Este es el porcentaje original del IVA (15% para contratos anteriores a 2010 y 16% para contratos de 2010 y posteriores)

        If cFeven >= "20130901" Then

            ' Los pagos a facturas con vencimiento mayor o igual al 1o. de septiembre de 2013 tendr�n una prelaci�n de pagos diferente.
            ' Puedo hacer que todos los conceptos se vean afectados en la misma proporci�n que guarden respecto al total de la factura.
            ' Por ejemplo, si una factura tiene 3 conceptos por 2,000.00 + 4,000.00 + 6,000.00 y le aplicamos un pago por 3,000.00 la aplicaci�n ser�a:
            ' Al concepto por 2,000.00 le aplicar�a 500.00 ya que 2,000.00 es la 6a. parte de 12,000.00
            ' Al concepto por 4,000.00 le aplicar�a 1,000.00 ya que 4,000.00 es la 3a. parte de 12,000.00
            ' Al concepto por 6,000.00 le aplicar�a 1,500.00 ya que 6,000.00 es la mitad de 12,000.00
            '
            ' Otra opci�n es agrupar conceptos que tengan Base e IVA para que �stos tengan la misma prelaci�n.   Por ejemplo:
            ' PAGO DE RENTA = 13,500.00 e IVA DE LA RENTA = 2,160.00 y si el importe del pago es por 6,750.00 la aplicaci�n del pago ser�a:
            ' Al PAGO DE RENTA le aplicar�a 5,818.97 ya que 13,500.00 es el 86.21% de 15,660.00
            ' Al IVA DE LA RENTA le aplicar�a 931.03 ya que 2,160 es el 13.79% de 15,660.00
            ' La proporci�n del IVA respecto a su Base ser�a 931.03 / 5,818.97 = 16% con lo que se respetar�a la proporci�n

        End If

        If cTipar = "P" Then
            nCapitalEquipo = drFactura("RenPr") - drFactura("IntPr") + drFactura("VarPr")
        End If

        nParcial = nImportePago

        For Each aConcepto In aConceptos

            If aConcepto.Importe > 0 And nParcial > 0 Then

                If aConcepto.Concepto = "CAPITAL EQUIPO" Then
                    ' Si se trata de un pago a cuenta del CAPITAL EQUIPO, debo restarle la bonificaci�n,
                    ' ya que de otra forma el concepto SIEMPRE se cubrir�a en forma parcial
                    aConcepto.Importe = aConcepto.Importe - nBonifica
                End If

                If nParcial >= aConcepto.Importe Then
                    lCompleto = True
                Else
                    lCompleto = False
                End If

                ' Una vez hecha la validaci�n de si se cubre o no el concepto, debemos volver a aumentar el saldo
                ' que hab�amos descontado.   Esto aplica solo si el concepto es CAPITAL EQUIPO

                If aConcepto.Concepto = "CAPITAL EQUIPO" Then
                    aConcepto.Importe = aConcepto.Importe + nBonifica
                End If

                If lCompleto = True Then

                    If aConcepto.Concepto = "FEGA" Then

                        nImporteFEGA = aConcepto.Importe
                        nBaseFEGA = Round(nImporteFEGA / (1 + nTasaIVA), 2)
                        nIvaFEGA = Round(nImporteFEGA - nBaseFEGA, 2)

                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = "FEGA VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = nBaseFEGA
                        dtPagos.Rows.Add(drPago)

                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = "IVA FEGA VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = nIvaFEGA
                        dtPagos.Rows.Add(drPago)

                    Else

                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        If cTipar = "B" Then
                            drPago("Concepto") = aConcepto.Concepto + " No. " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        Else
                            drPago("Concepto") = aConcepto.Concepto + " VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        End If

                        drPago("Importe") = aConcepto.Importe
                        dtPagos.Rows.Add(drPago)

                    End If

                Else

                    ' El concepto se cubre solo parcialmente

                    If aConcepto.Concepto = "CAPITAL EQUIPO" Then

                        If nIvaCapital > 0 Then

                            ' Calcular la base tanto del IVA al 16% como del IVA al 15%

                            nPorcentajeActual = Round(nIvaCapital / nCapitalEquipo, 2)                  ' IVA = 0.16
                            nPorcentajeOriginal = Round(nPorieq / 100, 2)                               ' IVA = 0.15
                            nDiferenciaPorcentual = Round(nPorcentajeActual - nPorcentajeOriginal, 2)   ' Diferencia = 0.01

                            If nBonifica > 0 Then

                                If nPorcentajeActual > nPorcentajeOriginal Then
                                    nCapitalEquipo = Round(nParcial / (1 + nDiferenciaPorcentual), 2)
                                    nIvaCapital = Round(nParcial / (1 + nDiferenciaPorcentual) * nPorcentajeActual, 2)
                                Else
                                    nCapitalEquipo = Round(nParcial, 2)
                                    nIvaCapital = Round(nParcial * nPorcentajeActual, 2)
                                End If

                                ' Calcular el importe de la bonificaci�n que le corresponde

                                nBonifica = Round(nParcial / (1 + nDiferenciaPorcentual), 2)
                                nBonifica = Round(nBonifica * nPorcentajeOriginal, 2)

                            Else

                                nCapitalEquipo = Round(nParcial / (1 + nPorcentajeActual), 2)
                                nIvaCapital = Round(nParcial - nCapitalEquipo, 2)

                            End If

                            drPago = dtPagos.NewRow()
                            drPago("Anexo") = cAnexo
                            drPago("Letra") = cLetra
                            drPago("Tipos") = "2"
                            drPago("Fepag") = cFecha
                            drPago("Tipmon") = "01"
                            drPago("Banco") = cBanco
                            drPago("Concepto") = "CAPITAL EQUIPO VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                            drPago("Importe") = Round(nCapitalEquipo, 2)
                            dtPagos.Rows.Add(drPago)
                            If nBonifica > 0 Then
                                nAplicacionDGvsCV = Round(nBonifica / (1 + nPorcentajeOriginal), 2)
                                drPago = dtPagos.NewRow()
                                drPago("Anexo") = cAnexo
                                drPago("Letra") = cLetra
                                drPago("Tipos") = "2"
                                drPago("Fepag") = cFecha
                                drPago("Tipmon") = "01"
                                drPago("Banco") = cBanco
                                drPago("Concepto") = "APLICACION DEPOSITO vs CAPITAL VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                                drPago("Importe") = -nAplicacionDGvsCV
                                dtPagos.Rows.Add(drPago)
                            End If
                            drPago = dtPagos.NewRow()
                            drPago("Anexo") = cAnexo
                            drPago("Letra") = cLetra
                            drPago("Tipos") = "2"
                            drPago("Fepag") = cFecha
                            drPago("Tipmon") = "01"
                            drPago("Banco") = cBanco
                            drPago("Concepto") = "IVA CAPITAL VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                            drPago("Importe") = Round(nIvaCapital, 2)
                            dtPagos.Rows.Add(drPago)
                            If nBonifica > 0 Then
                                nAplicacionDGvsIC = Round(nBonifica - nAplicacionDGvsCV, 2)
                                drPago = dtPagos.NewRow()
                                drPago("Anexo") = cAnexo
                                drPago("Letra") = cLetra
                                drPago("Tipos") = "2"
                                drPago("Fepag") = cFecha
                                drPago("Tipmon") = "01"
                                drPago("Banco") = cBanco
                                drPago("Concepto") = "APLICACION DEPOSITO vs IVA CAPITAL VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                                drPago("Importe") = -nAplicacionDGvsIC
                                dtPagos.Rows.Add(drPago)
                            End If
                        Else
                            ' La operaci�n no tuvo IVA MOI, por lo que tampoco tiene Dep�sito en Garant�a
                            drPago = dtPagos.NewRow()
                            drPago("Anexo") = cAnexo
                            drPago("Letra") = cLetra
                            drPago("Tipos") = "2"
                            drPago("Fepag") = cFecha
                            drPago("Tipmon") = "01"
                            drPago("Banco") = cBanco
                            drPago("Concepto") = "CAPITAL EQUIPO VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                            drPago("Importe") = nParcial
                            dtPagos.Rows.Add(drPago)
                        End If

                    ElseIf aConcepto.Concepto = "FEGA" Then

                        nImporteFEGA = nParcial
                        nBaseFEGA = Round(nImporteFEGA / (1 + nTasaIVA), 2)
                        nIvaFEGA = Round(nImporteFEGA - nBaseFEGA, 2)

                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = "FEGA VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = nBaseFEGA
                        dtPagos.Rows.Add(drPago)

                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = "IVA FEGA VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = nIvaFEGA
                        dtPagos.Rows.Add(drPago)

                    Else

                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        If cTipar = "B" Then
                            drPago("Concepto") = aConcepto.Concepto + " No. " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        Else
                            drPago("Concepto") = aConcepto.Concepto + " VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        End If

                        drPago("Importe") = nParcial
                        dtPagos.Rows.Add(drPago)

                    End If

                End If

                nParcial = nParcial - aConcepto.Importe

            End If

        Next

    End Sub

    Private Sub PCParcial(ByVal nImportePago As Decimal, ByRef dtPagos As DataTable, ByVal aConceptos As ArrayList, ByVal drFactura As DataRow, ByVal cFecha As String, ByVal cBanco As String)

        Dim cAnexo As String
        Dim cLetra As String
        Dim drPago As DataRow
        Dim lCompleto As Boolean
        Dim nAplicacionDGvsCV As Decimal = 0
        Dim nAplicacionDGvsIC As Decimal = 0
        Dim nBonifica As Decimal = 0
        Dim nCapitalEquipo As Decimal = 0
        Dim nDiferenciaPorcentual As Decimal = 0
        Dim nIvaCapital As Decimal = 0
        Dim nParcial As Decimal = 0
        Dim nPorieq As Decimal = 0
        Dim nPorcentajeActual As Decimal = 0
        Dim nPorcentajeOriginal As Decimal = 0

        nParcial = nImportePago

        cAnexo = drFactura("Anexo")
        nCapitalEquipo = drFactura("RenPr") - drFactura("IntPr")
        nIvaCapital = drFactura("IvaCapital")
        nBonifica = drFactura("Bonifica")
        cLetra = drFactura("Letra")
        nPorieq = drFactura("Porieq")

        If cTipar = "P" Then
            nCapitalEquipo = drFactura("RenPr") - drFactura("IntPr") + drFactura("VarPr")
        End If

        For Each aConcepto In aConceptos

            If aConcepto.Importe > 0 And nParcial > 0 Then

                If aConcepto.Concepto = "CAPITAL EQUIPO" Then

                    ' Calcular la base tanto del IVA al 16% como del IVA al 15%

                    nPorcentajeActual = Round(nIvaCapital / nCapitalEquipo, 2)                  ' IVA = 0.16
                    nPorcentajeOriginal = Round(nPorieq / 100, 2)                               ' IVA = 0.15
                    nDiferenciaPorcentual = Round(nPorcentajeActual - nPorcentajeOriginal, 2)   ' Diferencia = 0.01

                    If nBonifica > 0 Then

                        If nPorcentajeActual > nPorcentajeOriginal Then
                            nCapitalEquipo = Round(nParcial / (1 + nDiferenciaPorcentual), 2)
                            nIvaCapital = Round(nParcial / (1 + nDiferenciaPorcentual) * nPorcentajeActual, 2)
                        Else
                            nCapitalEquipo = Round(nParcial, 2)
                            nIvaCapital = Round(nParcial * nPorcentajeActual, 2)
                        End If

                        ' Calcular el importe de la bonificaci�n que le corresponde

                        nBonifica = Round(nParcial / (1 + nDiferenciaPorcentual), 2)
                        nBonifica = Round(nBonifica * nPorcentajeOriginal, 2)

                    Else

                        nCapitalEquipo = Round(nParcial / (1 + nPorcentajeActual), 2)
                        nIvaCapital = Round(nParcial - nCapitalEquipo, 2)

                    End If

                    ' Si se trata de un pago a cuenta del CAPITAL EQUIPO, debo restarle la bonificaci�n,
                    ' ya que de otra forma el concepto SIEMPRE se cubrir�a en forma parcial

                    aConcepto.Importe = Round(aConcepto.Importe - nBonifica, 2)

                End If

                If nParcial >= aConcepto.Importe Then
                    lCompleto = True
                Else
                    lCompleto = False
                End If

                ' Una vez hecha la validaci�n de si se cubre o no el concepto, debemos volver a aumentar el saldo
                ' que hab�amos descontado.   Esto aplica solo si el concepto es CAPITAL EQUIPO

                If aConcepto.Concepto = "CAPITAL EQUIPO" And nBonifica > 0 Then
                    aConcepto.Importe = Round(aConcepto.Importe + nBonifica, 2)
                End If

                If lCompleto Then

                    ' El concepto se cubre totalmente

                    If aConcepto.Concepto = "FEGA" Then

                        nImporteFEGA = aConcepto.Importe
                        nBaseFEGA = Round(nImporteFEGA / (1 + nTasaIVA), 2)
                        nIvaFEGA = Round(nImporteFEGA - nBaseFEGA, 2)

                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = "FEGA VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = nBaseFEGA
                        dtPagos.Rows.Add(drPago)

                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = "IVA FEGA VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = nIvaFEGA
                        dtPagos.Rows.Add(drPago)

                    End If

                    drPago = dtPagos.NewRow()
                    drPago("Anexo") = cAnexo
                    drPago("Letra") = cLetra
                    drPago("Tipos") = "2"
                    drPago("Fepag") = cFecha
                    drPago("Tipmon") = "01"
                    drPago("Banco") = cBanco
                    drPago("Concepto") = aConcepto.Concepto + " VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                    drPago("Importe") = aConcepto.Importe
                    dtPagos.Rows.Add(drPago)

                Else

                    ' El concepto se cubre parcialmente

                    If aConcepto.Concepto = "CAPITAL EQUIPO" Then

                        If nIvaCapital > 0 Then

                            If nBonifica > 0 Then

                                If nPorcentajeActual > nPorcentajeOriginal Then
                                    nCapitalEquipo = Round(nParcial / (1 + nDiferenciaPorcentual), 2)
                                    nIvaCapital = Round(nParcial / (1 + nDiferenciaPorcentual) * nPorcentajeActual, 2)
                                Else
                                    nCapitalEquipo = Round(nParcial, 2)
                                    nIvaCapital = Round(nParcial * nPorcentajeActual, 2)
                                End If

                                ' Calcular el importe de la bonificaci�n que le corresponde

                                nBonifica = Round(nParcial / (1 + nDiferenciaPorcentual), 2)
                                nBonifica = Round(nBonifica * nPorcentajeOriginal, 2)

                            Else

                                nCapitalEquipo = Round(nParcial / (1 + nPorcentajeActual), 2)
                                nIvaCapital = Round(nParcial - nCapitalEquipo, 2)
                            End If

                            drPago = dtPagos.NewRow()
                            drPago("Anexo") = cAnexo
                            drPago("Letra") = cLetra
                            drPago("Tipos") = "2"
                            drPago("Fepag") = cFecha
                            drPago("Tipmon") = "01"
                            drPago("Banco") = cBanco
                            drPago("Concepto") = "CAPITAL EQUIPO VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                            drPago("Importe") = Round(nCapitalEquipo, 2)
                            dtPagos.Rows.Add(drPago)
                            If nBonifica > 0 Then
                                nAplicacionDGvsCV = Round(nBonifica / (1 + nPorcentajeOriginal), 2)
                                drPago = dtPagos.NewRow()
                                drPago("Anexo") = cAnexo
                                drPago("Letra") = cLetra
                                drPago("Tipos") = "2"
                                drPago("Fepag") = cFecha
                                drPago("Tipmon") = "01"
                                drPago("Banco") = cBanco
                                drPago("Concepto") = "APLICACION DEPOSITO vs CAPITAL VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                                drPago("Importe") = -nAplicacionDGvsCV
                                dtPagos.Rows.Add(drPago)
                            End If
                            drPago = dtPagos.NewRow()
                            drPago("Anexo") = cAnexo
                            drPago("Letra") = cLetra
                            drPago("Tipos") = "2"
                            drPago("Fepag") = cFecha
                            drPago("Tipmon") = "01"
                            drPago("Banco") = cBanco
                            drPago("Concepto") = "IVA CAPITAL VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                            drPago("Importe") = Round(nIvaCapital, 2)
                            dtPagos.Rows.Add(drPago)
                            If nBonifica > 0 Then
                                nAplicacionDGvsIC = Round(nBonifica - nAplicacionDGvsCV, 2)
                                drPago = dtPagos.NewRow()
                                drPago("Anexo") = cAnexo
                                drPago("Letra") = cLetra
                                drPago("Tipos") = "2"
                                drPago("Fepag") = cFecha
                                drPago("Tipmon") = "01"
                                drPago("Banco") = cBanco
                                drPago("Concepto") = "APLICACION DEPOSITO vs IVA CAPITAL VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                                drPago("Importe") = -nAplicacionDGvsIC
                                dtPagos.Rows.Add(drPago)
                            End If
                        Else
                            ' La operaci�n no tuvo IVA MOI, por lo que tampoco tiene Dep�sito en Garant�a
                            drPago = dtPagos.NewRow()
                            drPago("Anexo") = cAnexo
                            drPago("Letra") = cLetra
                            drPago("Tipos") = "2"
                            drPago("Fepag") = cFecha
                            drPago("Tipmon") = "01"
                            drPago("Banco") = cBanco
                            drPago("Concepto") = "CAPITAL EQUIPO VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                            drPago("Importe") = nParcial
                            dtPagos.Rows.Add(drPago)
                        End If

                    ElseIf aConcepto.Concepto = "FEGA" Then

                        nImporteFEGA = nParcial
                        nBaseFEGA = Round(nImporteFEGA / (1 + nTasaIVA), 2)
                        nIvaFEGA = Round(nImporteFEGA - nBaseFEGA, 2)

                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = "FEGA VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = nBaseFEGA
                        dtPagos.Rows.Add(drPago)

                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = "IVA FEGA VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = nIvaFEGA
                        dtPagos.Rows.Add(drPago)

                    Else

                        drPago = dtPagos.NewRow()
                        drPago("Anexo") = cAnexo
                        drPago("Letra") = cLetra
                        drPago("Tipos") = "2"
                        drPago("Fepag") = cFecha
                        drPago("Tipmon") = "01"
                        drPago("Banco") = cBanco
                        drPago("Concepto") = aConcepto.Concepto + " VENCIMIENTO " + cLetra + "/0" + TaQUERY.UltimaLetra(cAnexo)
                        drPago("Importe") = nParcial
                        dtPagos.Rows.Add(drPago)

                    End If

                End If

                nParcial -= aConcepto.Importe

            End If

        Next

    End Sub

    Private Sub AplicaPagoAnterior(ByRef aConceptos As ArrayList, ByVal drFactura As DataRow)

        ' A partir del 01/03/2002, el sistema est� jerarquizando la aplicaci�n de los pagos, esto debido a la Reforma Fiscal que obliga a cobrar el IVA del Capital
        ' CONFORME SE COBRE el Capital

        Dim aTemporal As New ArrayList()
        Dim lCompleto As Boolean
        Dim nBonifica As Decimal = 0
        Dim nCapitalEquipo As Decimal = 0
        Dim nIvaCapital As Decimal = 0
        Dim nPorcentajeActual As Decimal = 0
        Dim nPorcentajeOriginal As Decimal = 0
        Dim nDiferenciaPorcentual As Decimal = 0
        Dim nPorieq As Decimal = 0

        nImporteFac = drFactura("ImporteFac")
        nSaldoFac = drFactura("SaldoFac")
        nCapitalEquipo = drFactura("RenPr") - drFactura("IntPr")
        nIvaCapital = drFactura("IvaCapital")
        nBonifica = drFactura("Bonifica")
        nPorieq = drFactura("Porieq")

        ' Lo primero que tenemos que determinar es cu�nto hab�a pagado el cliente y cu�les conceptos se
        ' cubrieron con dicho pago

        nPagado = nImporteFac - nSaldoFac

        For Each aConcepto In aConceptos

            If aConcepto.Importe > 0 And nPagado > 0 Then

                If aConcepto.Concepto = "CAPITAL EQUIPO" Then
                    ' Si se trata de un pago a cuenta del CAPITAL EQUIPO, debo restarle la bonificaci�n,
                    ' ya que de otra forma el concepto SIEMPRE se cubrir�a en forma parcial
                    aConcepto.Importe = aConcepto.Importe - nBonifica
                End If

                If nPagado >= aConcepto.Importe Then
                    lCompleto = True
                Else
                    lCompleto = False
                End If

                ' Una vez hecha la validaci�n de si se cubre o no el concepto, debemos volver a aumentar el saldo
                ' que hab�amos descontado.   Esto aplica solo si el concepto es CAPITAL EQUIPO

                If aConcepto.Concepto = "CAPITAL EQUIPO" Then
                    aConcepto.Importe = aConcepto.Importe + nBonifica
                End If

                If lCompleto = True Then

                    ' El concepto se cubre totalmente

                    nPagado = nPagado - aConcepto.Importe
                    aConcepto.Importe = 0

                Else

                    ' El concepto se cubre parcialmente

                    If aConcepto.Concepto = "CAPITAL EQUIPO" And nIvaCapital > 0 Then

                        ' Calcular la base tanto del IVA al 16% como del IVA al 15%

                        nPorcentajeActual = Round(nIvaCapital / nCapitalEquipo, 2)                  ' IVA = 0.16
                        nPorcentajeOriginal = Round(nPorieq / 100, 2)                               ' IVA = 0.15
                        nDiferenciaPorcentual = Round(nPorcentajeActual - nPorcentajeOriginal, 2)   ' Diferencia = 0.01

                        If nBonifica > 0 Then

                            If nPorcentajeActual > nPorcentajeOriginal Then
                                nCapitalEquipo = Round(nSaldoFac / (1 + nDiferenciaPorcentual), 2)
                                nIvaCapital = Round(nSaldoFac / (1 + nDiferenciaPorcentual) * nPorcentajeActual, 2)
                            Else
                                nCapitalEquipo = Round(nSaldoFac, 2)
                                nIvaCapital = Round(nSaldoFac * nPorcentajeActual, 2)
                            End If

                        Else

                            nCapitalEquipo = Round(nSaldoFac / (1 + nPorcentajeActual), 2)
                            nIvaCapital = Round(nSaldoFac - nCapitalEquipo, 2)

                        End If

                        aConcepto.Importe = Round(nCapitalEquipo + nIvaCapital, 2)

                    Else

                        aConcepto.Importe = aConcepto.Importe - nPagado

                    End If

                    nPagado = 0

                End If

            End If

            aTemporal.Add(aConcepto)

        Next

        aConceptos = aTemporal

    End Sub

    Private Function AplicaPagoAnteriorIII(ByVal aConceptos As ArrayList) As ArrayList '#ECT new
        ' Lo primero que tenemos que determinar es cu�nto hab�a pagado el cliente y cu�les conceptos se cubrieron con dicho pago
        Dim concep As String
        Dim ImporteT As Decimal
        Dim factor As Decimal

        AplicaPagoAnteriorIII = New ArrayList()
        For Each aConceptoX As Conceptos In aConceptos
            concep = aConceptoX.Concepto
            If nPagado > 0 Then
                If nPagado >= aConceptoX.Importe / aConceptoX.Porcentaje Then
                    'Pago completo del importe
                    ImporteT = Round(aConceptoX.Importe, 2)
                    nPagado = nPagado - ImporteT
                    aConceptoX.Importe = 0
                Else
                    ' Pago parcial del importe
                    If aConceptoX.Iva > 0 And nPagado < aConceptoX.Importe + aConceptoX.Importe Then
                        factor = aConceptoX.Iva / aConceptoX.Importe
                        ImporteT = Round(nPagado / (1 + factor), 2)
                        aConceptoX.Iva -= Round(nPagado - ImporteT, 2)
                        aConceptoX.Importe -= ImporteT
                        nPagado = nPagado - ImporteT
                    Else
                        ImporteT = Round(nPagado * aConceptoX.Porcentaje, 2)
                        aConceptoX.Importe = aConceptoX.Importe - ImporteT
                        nPagado = nPagado - ImporteT
                    End If


                End If
            End If
            AplicaPagoAnteriorIII.Add(aConceptoX)
        Next
        Return (AplicaPagoAnteriorIII)
    End Function '#ECT new

End Module
