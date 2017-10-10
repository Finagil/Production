Imports System.Data.SqlClient
Imports System.Math
Module CONT_Global
    Public IVA_Interes_TasaReal As Boolean = True
    Public FECHA_APLICACION As Date = Date.Now
    Public DIAS_MENOS As Integer = 0
    Public CANCELA_MORA_DIA_FEST() As String 'Parametrizado en tabla llaves "Fecha;Domiciliacion:dias"

    Public Structure Movimiento
        Public Cve As String
        Public Anexo As String
        Public Cliente As String
        Public Imp As Decimal
        Public Tipar As String
        Public Coa As String
        Public Fecha As String
        Public Tipmov As String
        Public Banco As String
        Public Concepto As String
        Public Segmento As String
    End Structure

    Private Structure Provinte
        Public Tipar As String
        Public Anexo As String
        Public Saldo As Decimal
        Public Tasa As Decimal
        Public Difer As Decimal
        Public DiasProv As Integer
        Public Importe As Decimal
        Public FechaIni As String
        Public FechaFin As String
    End Structure

    Sub Genera_Trapasos_Avio(ByVal Fecha As String)
        Dim Aux As New ContaDSTableAdapters.AuxiliarTableAdapter
        Dim ta As New ContaDSTableAdapters.TraspasosAvioCCTableAdapter
        Dim t As New ContaDS.TraspasosAvioCCDataTable
        Dim R As ContaDS.TraspasosAvioCCRow
        ta.Fill(t, Fecha)
        For Each R In t.Rows
            'If R.Importe = 0 And R.Fega = 0 And R.GarantiaLiq = 0 Then
            'Continue For 'se omite ya que son INTERESES MENSUALES CUENTA CORRIENTE
            'End If
            If R.Importe + R.Intereses + R.InteresesDias + R.Fega > 0 Then
                Aux.Insert("66", R.Anexo, "", R.Importe + R.Intereses + R.InteresesDias + R.Fega, R.Tipar, "0", R.Fecha, "09", "", "Traspasos de Cartera", R.Segmento_Negocio)
            End If

            If R.Importe + R.Fega > 0 Then
                Aux.Insert("65", R.Anexo, "", R.Importe + R.Fega, R.Tipar, "1", R.Fecha, "09", "", "Traspasos de Cartera", R.Segmento_Negocio)
            End If

            If R.Intereses + R.InteresesDias > 0 Then
                Aux.Insert("72", R.Anexo, "", R.Intereses + R.InteresesDias, R.Tipar, "1", R.Fecha, "09", "", "Traspasos de Cartera", R.Segmento_Negocio)
            End If

            If R.GarantiaLiq > 0 Then
                Aux.Insert("55", R.Anexo, "", R.GarantiaLiq, R.Tipar, "1", R.Fecha, "09", "", "Traspasos de Cartera", R.Segmento_Negocio)
                Aux.Insert("67", R.Anexo, "", R.GarantiaLiq, R.Tipar, "0", R.Fecha, "09", "", "Traspasos de Cartera", R.Segmento_Negocio)
            End If
        Next
        ta.Dispose()
        Aux.Dispose()
        t.Dispose()
    End Sub

    Public Sub SacaFechaAplicacion()
        Dim ta As New ContaDSTableAdapters.FechasAplicacionTableAdapter
        Dim t As New ContaDS.FechasAplicacionDataTable
        Dim r As ContaDS.FechasAplicacionRow
        Try
            ta.Fill(t, "Vigente")
            r = t.Rows(0)
            FECHA_APLICACION = (r.Fecha)
            FECHA_APLICACION = FECHA_APLICACION.AddHours(22)
            DIAS_MENOS = DateDiff(DateInterval.Day, Date.Now, r.Fecha)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error fecha de Aplicación")
            FECHA_APLICACION = Date.Now.ToShortDateString
            FECHA_APLICACION = FECHA_APLICACION.AddHours(22)
        Finally
            ta.Dispose()
            t.Dispose()
        End Try
    End Sub

    Public Sub CambiaFechaAplicacion()
        Dim ta As New ContaDSTableAdapters.FechasAplicacionTableAdapter
        Dim t As New ContaDS.FechasAplicacionDataTable
        Dim r As ContaDS.FechasAplicacionRow
        Dim FechaVigente As Date
        Try
            ta.Fill(t, "Vigente")
            r = t.Rows(0)
            FechaVigente = r.Fecha
            ta.Update(FechaVigente, "Cerrado", FechaVigente, "Vigente")
            FechaVigente = FechaVigente.AddDays(1)
            If FechaVigente.DayOfWeek = DayOfWeek.Saturday Then FechaVigente = FechaVigente.AddDays(1)
            If FechaVigente.DayOfWeek = DayOfWeek.Sunday Then FechaVigente = FechaVigente.AddDays(1)
            ta.Insert(FechaVigente, "Vigente")
            FECHA_APLICACION = FechaVigente
            FECHA_APLICACION = FECHA_APLICACION.AddHours(22)
            DIAS_MENOS = DateDiff(DateInterval.Day, Date.Now, FECHA_APLICACION)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error fecha de Aplicación")
            FECHA_APLICACION = Date.Now.ToShortDateString
            FECHA_APLICACION = FECHA_APLICACION.AddHours(22)
        Finally
            ta.Dispose()
            t.Dispose()
        End Try
    End Sub

    Sub Genera_Trapasos_Vencida(ByVal Fecha As String)
        Dim TipoMov As String = "21"
        Dim Aux As New ContaDSTableAdapters.AuxiliarTableAdapter
        Dim ta As New ContaDSTableAdapters.TraspasosVencidosTableAdapter
        Dim t As New ContaDS.TraspasosVencidosDataTable
        Dim R As ContaDS.TraspasosVencidosRow
        ta.Fill(t, CTOD(Fecha).Year, CTOD(Fecha).Month)
        For Each R In t.Rows
            If R.Tipar = "F" Or R.Tipar = "R" Or R.Tipar = "S" Then
                Select Case R.Tipar
                    Case "F"
                        Aux.Insert("06", R.Anexo, "", R.SaldoInsoluto + R.CargaFinanciera, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                        Aux.Insert("07", R.Anexo, "", R.CargaFinanciera, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                    Case "R"
                        Aux.Insert("45", R.Anexo, "", R.SaldoInsoluto + R.CargaFinanciera, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                        Aux.Insert("46", R.Anexo, "", R.CargaFinanciera, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                    Case "S"
                        Aux.Insert("55", R.Anexo, "", R.SaldoInsoluto + R.CargaFinanciera, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                        Aux.Insert("59", R.Anexo, "", R.CargaFinanciera, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                End Select
                Aux.Insert("V01", R.Anexo, "", R.SaldoInsoluto, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

                Aux.Insert("28", R.Anexo, "", R.SaldoInsolutoSEG, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V01", R.Anexo, "", R.SaldoInsolutoSEG, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

                Aux.Insert("55", R.Anexo, "", R.SaldoInsolutoOTR + R.CargaFinancieraOTR, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("59", R.Anexo, "", R.CargaFinancieraOTR, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V01", R.Anexo, "", R.SaldoInsolutoOTR, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

                Select Case R.Tipar
                    Case "F"
                        Aux.Insert("03", R.Anexo, "", R.CapitalVencido + R.InteresVencido, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                    Case "R"
                        Aux.Insert("50", R.Anexo, "", R.CapitalVencido + R.InteresVencido, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                    Case "S"
                        Aux.Insert("56", R.Anexo, "", R.CapitalVencido + R.InteresVencido, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                End Select

                Aux.Insert("56", R.Anexo, "", R.CapitalVencidoOt + R.InteresVencidoOt, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V02", R.Anexo, "", R.CapitalVencido + R.CapitalVencidoOt, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V03", R.Anexo, "", R.InteresVencido + R.InteresVencidoOt, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V04", R.Anexo, "", R.IvaCapital, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

            ElseIf R.Tipar = "C" Or R.Tipar = "A" Or R.Tipar = "H" Then
                Aux.Insert("55", R.Anexo, "", R.CapitalVencido + R.InteresVencido, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("59", R.Anexo, "", R.CapitalVencido, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V01", R.Anexo, "", R.InteresVencido, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

            ElseIf R.Tipar = "P" Then
                Aux.Insert("03", R.Anexo, "", R.CapitalVencido + R.InteresVencido + R.IvaCapital + R.CargaFinancieraSEG, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("06", R.Anexo, "", R.CapitalVencido + R.InteresVencido + R.IvaCapital, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("28", R.Anexo, "", R.SaldoInsolutoSEG, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V01", R.Anexo, "", R.SaldoInsolutoSEG, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

                Aux.Insert("55", R.Anexo, "", R.SaldoInsolutoOTR + R.CargaFinancieraOTR, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("59", R.Anexo, "", R.CargaFinancieraOTR, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V01", R.Anexo, "", R.SaldoInsolutoOTR, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

                Aux.Insert("V03", R.Anexo, "", R.InteresVencidoOt + R.CargaFinancieraSEG, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("56", R.Anexo, "", R.CapitalVencidoOt + R.InteresVencidoOt, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V02", R.Anexo, "", R.CapitalVencidoOt, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

            ElseIf R.Tipar = "B" Then
                Aux.Insert("11", R.Anexo, "", R.CapitalVencido + R.IvaCapital, R.Tipar, "1", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)
                Aux.Insert("V08", R.Anexo, "", R.CapitalVencido + R.IvaCapital, R.Tipar, "0", R.Fecha.ToString("yyyyMMdd"), TipoMov, "", "Traspasos Cartera Vencida", R.Segmento_Negocio)

            End If
        Next
        Aux.DeleteCeros(TipoMov)
        ta.Dispose()
        Aux.Dispose()
        t.Dispose()
    End Sub

    Public Sub GeneProv(ByVal cFecha As String, ByVal strConnX As String)

        ' Este programa debe tomar los contratos activos de arrendamiento financiero, arrendamiento puro,
        ' crédito refaccionario, crédito simple cuya fecha de contratación sea menor o igual a la fecha de proceso.   
        ' También debe tomar la tabla de amortización del equipo, del seguro y de otros adeudos de todos los
        ' contratos obtenidos con el criterio anterior.   Aunque esto creará un dataset con muchísimos registros,
        ' por otra parte permitirá mantener abierta la conexión únicamente durante el tiempo que tarde en traer
        ' dicha información de la base de datos.

        ' Tratándose de arrendamiento puro, deberá provisionar dias de renta a diferencia de los demás tipos
        ' de crédito o arrendamiento en donde se provisiona dias de intereses.

        ' En el caso de otros adeudos, a partir del mes de julio de 2008

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConnX)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim daAnexos As New SqlDataAdapter(cm1)
        Dim daEdoctaV As New SqlDataAdapter(cm2)
        Dim daEdoctaS As New SqlDataAdapter(cm3)
        Dim daEdoctaO As New SqlDataAdapter(cm4)
        Dim dsAgil As New DataSet()
        Dim relAnexoEdoctaV As DataRelation
        Dim relAnexoEdoctaS As DataRelation
        Dim relAnexoEdoctaO As DataRelation
        Dim drAnexo As DataRow
        Dim drTemporal As DataRow
        Dim drEdoctaV As DataRow()
        Dim drEdoctaS As DataRow()
        Dim drEdoctaO As DataRow()
        Dim drVencimiento As DataRow
        Dim strInsert As String
        Dim dtTIIE As New DataTable()

        ' Declaración de variables de datos

        Dim aProvinte As New Provinte()
        Dim aProvintes As New ArrayList()
        Dim aMovimiento As New Movimiento()
        Dim aMovimientos As New ArrayList()
        Dim cAcumulaIntereses As String = "NO"
        Dim cAnexo As String = ""
        Dim cCorte As String = ""
        Dim cFechaAnterior As String = ""
        Dim cFechacon As String = ""
        Dim cFechaPago As String = ""
        ' Dim cFechaLimite As String = ""
        Dim cFondeo As String = ""
        Dim cForca As String = ""
        Dim cFvenc As String = ""
        Dim cSegmento As String = ""
        Dim cTipar As String = ""
        Dim cTipMov As String = "08"
        Dim cTipta As String = ""
        Dim cVencida As String = ""
        Dim nCarteraEquipo As Decimal = 0
        Dim nCarteraOtros As Decimal = 0
        Dim nCarteraSeguro As Decimal = 0
        Dim nDiasProv As Integer = 0
        Dim nDifer As Decimal = 0
        Dim nImporte As Decimal = 0
        Dim nInteresEquipo As Decimal = 0
        Dim nInteresOtros As Decimal = 0
        Dim nInteresSeguro As Decimal = 0
        Dim nLetra As Byte = 0
        Dim nNufac As Decimal = 0
        Dim nPlazo As Byte = 0
        Dim nSaldoEquipo As Decimal = 0
        Dim nSaldoOtros As Decimal = 0
        Dim nSaldoSeguro As Decimal = 0
        Dim nTasaFact As Decimal = 0
        Dim nTasas As Decimal = 0
        Dim taTasas As New TesoreriaDSTableAdapters.HistaTableAdapter

        ' La fecha de corte es el mes siguiente al de la fecha de proceso en el formato AAAAMM

        cCorte = Mid(DTOC(DateAdd(DateInterval.Month, 1, CTOD(cFecha))), 1, 6)

        ' Este Stored Procedure trae todos los contratos de arrendamiento financiero, arrendamiento puro,
        ' crédito refaccionario, crédito simple que estén activos y cuya fecha de contratación sea menor
        ' o igual a la de proceso

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv1"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortización del equipo de todos los contratos de
        ' arrendamiento financiero, arrendamiento puro, crédito refaccionario, crédito simple que estén activos 
        ' y cuya fecha de contratación sea menor o igual a la de proceso

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv2"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortización del seguro de todos los contratos 
        ' de arrendamiento financiero, arrendamiento puro, crédito refaccionario, crédito simple
        ' que estén activos y cuya fecha de contratación sea menor o igual a la de proceso

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv3"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortización de otros adeudos de todos los contratos 
        ' de arrendamiento financiero, arrendamiento puro, crédito refaccionario, crédito simple
        ' que estén activos y cuya fecha de contratación sea menor o igual a la de proceso

        With cm4
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv4"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daAnexos.Fill(dsAgil, "Anexos")
        daEdoctaV.Fill(dsAgil, "EdoctaV")
        daEdoctaS.Fill(dsAgil, "EdoctaS")
        daEdoctaO.Fill(dsAgil, "EdoctaO")

        ' Establecer la relación entre Anexos y Edoctav

        relAnexoEdoctaV = New DataRelation("AnexoEdoctaV", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("EdoctaV").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctaV)

        ' Establecer la relación entre Anexos y Edoctas

        relAnexoEdoctaS = New DataRelation("AnexoEdoctaS", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("EdoctaS").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctaS)

        ' Establecer la relación entre Anexos y Edoctao

        relAnexoEdoctaO = New DataRelation("AnexoEdoctaO", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("EdoctaO").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctaO)

        ' Genero la tabla que contiene las TIIE promedio por mes 
        ' Para FINAGIL considera todos los días del mes y redondea a 4 decimales

        dtTIIE = TIIEavg("FINAGIL")

        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = drAnexo("Anexo")
            If cAnexo = "025410024" Then
                cAnexo = "025410024"
            End If
            cVencida = drAnexo("Vencida")

            If cVencida <> "C" Then

                ' Solamente provisionarán intereses los contratos activos que no estén Castigados

                cTipar = drAnexo("Tipar")
                nPlazo = drAnexo("Plazo")
                cFechacon = drAnexo("Fechacon")
                cFechaPago = drAnexo("Fecha_pago")
                cFvenc = drAnexo("Fvenc")
                cFondeo = drAnexo("Fondeo")
                cAcumulaIntereses = drAnexo("AcumulaIntereses")
                cTipta = drAnexo("Tipta")
                nTasas = drAnexo("Tasas")
                nDifer = drAnexo("Difer")
                cForca = drAnexo("Forca")
                cSegmento = drAnexo("Segmento_Negocio")

                nSaldoEquipo = 0
                nInteresEquipo = 0
                nCarteraEquipo = 0

                ' Esta instrucción trae la tabla de amortización del Equipo única y exclusivamente del contrato
                ' que está siendo procesado

                drEdoctaV = drAnexo.GetChildRows("AnexoEdoctaV")
                TraeSald(drEdoctaV, cFecha, nSaldoEquipo, nInteresEquipo, nCarteraEquipo)

                nSaldoSeguro = 0
                nInteresSeguro = 0
                nCarteraSeguro = 0

                ' Esta instrucción trae la tabla de amortización del Seguro única y exclusivamente del contrato
                ' que está siendo procesado

                drEdoctaS = drAnexo.GetChildRows("AnexoEdoctaS")
                TraeSald(drEdoctaS, cFecha, nSaldoSeguro, nInteresSeguro, nCarteraSeguro)

                nSaldoOtros = 0
                nInteresOtros = 0
                nCarteraOtros = 0

                ' Esta instrucción trae la tabla de amortización de Otros Adeudos única y exclusivamente del contrato
                ' que está siendo procesado

                drEdoctaO = drAnexo.GetChildRows("AnexoEdoctaO")
                TraeSald(drEdoctaO, cFecha, nSaldoOtros, nInteresOtros, nCarteraOtros)

                nSaldoEquipo = Round(nSaldoEquipo + nSaldoSeguro, 2)

                ' A partir de este momento, la variable nSaldoEquipo incluye tanto el saldo del equipo como el saldo del seguro

                If nSaldoEquipo > 0 Then

                    ' Una vez calculado el saldo insoluto procedo a buscar la fecha del siguiente vencimiento,
                    ' ya que para llegar aquí, el contrato forzosamente debe tener saldo

                    For Each drVencimiento In drEdoctaV
                        If Mid(drVencimiento("Feven"), 1, 6) >= cCorte Then
                            nLetra = Val(drVencimiento("Letra"))
                            Exit For
                        End If
                    Next

                    If nLetra = 1 Then

                        cFechaAnterior = cFechacon
                        'solicitado por elisander
                        If Trim(cFechaPago) = "" Then
                            cFechaAnterior = cFecha
                        Else
                            cFechaAnterior = cFechaPago
                        End If

                    Else

                        ' Debo barrer la tabla de amortización del contrato para encontrar la fecha del vencimiento
                        ' anterior, a fin de determinar los días a provisionar

                        For Each drVencimiento In drEdoctaV
                            nNufac = drVencimiento("Nufac")
                            If Val(drVencimiento("Letra")) = (nLetra - 1) And nNufac <> 9999999 And nNufac <> 7777777 And nNufac >= 0 Then
                                cFechaAnterior = drVencimiento("Feven")
                            End If
                        Next

                    End If

                    ' Hasta el cierre de julio 2010, la fecha anterior NO podía ser menor al 1o. del mes que se estaba procesando,
                    ' lo que se traducía en que el número máximo de días que se provisionaba era 28, 29, 30 ó 31 días (los que tuviera
                    ' el mes para el cual se estaba realizando el proceso).

                    ' cFechaLimite = Mid(cFecha, 1, 6) & "01"

                    ' If cFechaAnterior < cFechaLimite Then
                    '     cFechaAnterior = cFechaLimite
                    ' End If

                    If cAcumulaIntereses = "SI" Then

                        nDiasProv = CInt(DateDiff(DateInterval.Day, CTOD(cFechaAnterior), CTOD(cFecha)))

                    Else

                        nDiasProv = CInt(DateDiff(DateInterval.Day, CTOD(cFechaAnterior), CTOD(cFecha))) + 1

                    End If


                    If nDiasProv > 0 Then

                        If cAcumulaIntereses = "SI" Then

                            nInteresEquipo = 0
                            For Each drTemporal In InteresAcumulado(cAnexo, cTipta, "FINAGIL", cFechaAnterior, nSaldoEquipo, nTasas, nDifer, cFecha, dtTIIE, cFecha, cTipar, False).Rows
                                nInteresEquipo += drTemporal("Interes")
                            Next
                            nTasaFact = Round(nInteresEquipo / nSaldoEquipo * 36000 / nDiasProv, 4)
                            nInteresOtros = Round(nSaldoOtros * nTasaFact / 36000 * nDiasProv, 2)

                            If cTipta <> "7" Then
                                nTasaFact = nTasaFact - nDifer
                            Else
                                nDifer = 0
                            End If

                        Else

                            nTasaFact = nTasas + nDifer

                            ' Es importante recordar que solamente se calcula la tasa de interés para los vencimientos
                            ' posteriores al primero

                            If nLetra > 1 Then
                                If cTipta <> "7" Then
                                    nTasaFact = taTasas.Trae_Tasa_Dia(cTipta, cFechaAnterior)
                                    nTasaFact += nDifer
                                End If
                            End If

                            nInteresEquipo = Round(nSaldoEquipo * nTasaFact / 36000 * nDiasProv, 2)
                            nInteresOtros = Round(nSaldoOtros * nTasaFact / 36000 * nDiasProv, 2)

                            ' A efecto de poder guardar por separado el valor de la tasa y el diferencial, tengo que restarle
                            ' el diferencial a la tasa de facturación aplicada ya que hasta este punto la tasa incluye el diferencial 

                            nTasaFact -= nDifer

                        End If

                        With aProvinte
                            .Tipar = cTipar
                            .Anexo = cAnexo
                            .Saldo = nSaldoEquipo
                            .Tasa = nTasaFact
                            .Difer = nDifer
                            .DiasProv = nDiasProv
                            .Importe = nInteresEquipo
                            .FechaIni = cFechaAnterior
                            .FechaFin = cFecha
                        End With
                        aProvintes.Add(aProvinte)

                        If nInteresOtros > 0 Then
                            With aProvinte
                                .Tipar = cTipar
                                .Anexo = cAnexo
                                .Saldo = nSaldoOtros
                                .Tasa = nTasaFact
                                .Difer = nDifer
                                .DiasProv = nDiasProv
                                .Importe = nInteresOtros
                                .FechaIni = cFechaAnterior
                                .FechaFin = cFecha
                            End With
                            aProvintes.Add(aProvinte)
                        End If

                        If cTipar = "F" Then

                            With aMovimiento
                                .Cve = "15"
                                .Anexo = cAnexo
                                .Imp = nInteresEquipo
                                .Tipar = cTipar
                                .Coa = "0"
                                .Fecha = cFecha
                                .Tipmov = cTipMov
                                .Banco = ""
                                .Concepto = ""
                                .Segmento = cSegmento
                            End With
                            aMovimientos.Add(aMovimiento)

                            With aMovimiento
                                .Cve = "14"
                                .Anexo = cAnexo
                                .Imp = nInteresEquipo
                                .Tipar = cTipar
                                .Coa = "1"
                                .Fecha = cFecha
                                .Tipmov = cTipMov
                                .Banco = ""
                                .Concepto = ""
                                .Segmento = cSegmento
                            End With
                            aMovimientos.Add(aMovimiento)

                        ElseIf cTipar = "R" Then

                            With aMovimiento
                                .Cve = "53"
                                .Anexo = cAnexo
                                .Imp = nInteresEquipo
                                .Tipar = cTipar
                                .Coa = "0"
                                .Fecha = cFecha
                                .Tipmov = cTipMov
                                .Banco = ""
                                .Concepto = ""
                                .Segmento = cSegmento
                            End With
                            aMovimientos.Add(aMovimiento)

                            With aMovimiento
                                .Cve = "54"
                                .Anexo = cAnexo
                                .Imp = nInteresEquipo
                                .Tipar = cTipar
                                .Coa = "1"
                                .Fecha = cFecha
                                .Tipmov = cTipMov
                                .Banco = ""
                                .Concepto = ""
                                .Segmento = cSegmento
                            End With
                            aMovimientos.Add(aMovimiento)

                        ElseIf cTipar = "S" Then

                            With aMovimiento
                                .Cve = "57"
                                .Anexo = cAnexo
                                .Imp = nInteresEquipo
                                .Tipar = cTipar
                                .Coa = "0"
                                .Fecha = cFecha
                                .Tipmov = cTipMov
                                .Banco = ""
                                .Concepto = ""
                                .Segmento = cSegmento
                            End With
                            aMovimientos.Add(aMovimiento)

                            With aMovimiento
                                .Cve = "62"
                                .Anexo = cAnexo
                                .Imp = nInteresEquipo
                                .Tipar = cTipar
                                .Coa = "1"
                                .Fecha = cFecha
                                .Tipmov = cTipMov
                                .Banco = ""
                                .Concepto = ""
                                .Segmento = cSegmento
                            End With
                            aMovimientos.Add(aMovimiento)

                        End If

                        ' Si existen otros adeudos, tengo que darle el mismo tratamiento que a un crédito simple

                        If nSaldoOtros > 0 Then

                            With aMovimiento
                                .Cve = "57"
                                .Anexo = cAnexo
                                .Imp = nInteresOtros
                                .Tipar = cTipar
                                .Coa = "0"
                                .Fecha = cFecha
                                .Tipmov = cTipMov
                                .Banco = ""
                                .Concepto = ""
                                .Segmento = cSegmento
                            End With
                            aMovimientos.Add(aMovimiento)

                            With aMovimiento
                                .Cve = "62"
                                .Anexo = cAnexo
                                .Imp = nInteresOtros
                                .Tipar = cTipar
                                .Coa = "1"
                                .Fecha = cFecha
                                .Tipmov = cTipMov
                                .Banco = ""
                                .Concepto = ""
                                .Segmento = cSegmento
                            End With
                            aMovimientos.Add(aMovimiento)

                        End If

                    End If

                End If

            End If

        Next

        cnAgil.Open()

        For Each aProvinte In aProvintes
            strInsert = "INSERT INTO CONT_Provinte(Tipar, Anexo, Saldo, Tasa, Difer, DiasProv, Importe, FechaIni, FechaFin)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & aProvinte.Tipar & "', '"
            strInsert = strInsert & aProvinte.Anexo & "', '"
            strInsert = strInsert & aProvinte.Saldo & "', '"
            strInsert = strInsert & aProvinte.Tasa & "', '"
            strInsert = strInsert & aProvinte.Difer & "', '"
            strInsert = strInsert & aProvinte.DiasProv & "', '"
            strInsert = strInsert & aProvinte.Importe & "', '"
            strInsert = strInsert & aProvinte.FechaIni & "', '"
            strInsert = strInsert & aProvinte.FechaFin
            strInsert = strInsert & "')"
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()
        Next

        For Each aMovimiento In aMovimientos
            strInsert = "INSERT INTO CONT_Auxiliar(Cve, Anexo, Imp, Tipar, Coa, Fecha, Tipmov, Banco, Concepto, Segmento)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & aMovimiento.Cve & "', '"
            strInsert = strInsert & aMovimiento.Anexo & "', '"
            strInsert = strInsert & aMovimiento.Imp & "', '"
            strInsert = strInsert & aMovimiento.Tipar & "', '"
            strInsert = strInsert & aMovimiento.Coa & "', '"
            strInsert = strInsert & aMovimiento.Fecha & "', '"
            strInsert = strInsert & aMovimiento.Tipmov & "', '"
            strInsert = strInsert & aMovimiento.Banco & "', '"
            strInsert = strInsert & aMovimiento.Concepto & "', '"
            strInsert = strInsert & aMovimiento.Segmento
            strInsert = strInsert & "')"
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()
        Next

        cnAgil.Close()

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
        cm4.Dispose()

    End Sub

End Module
