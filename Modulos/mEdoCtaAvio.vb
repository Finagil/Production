Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO

Module mEdoCtaAvio
    Public UsuarioGlobal As String
    Public UsuarioGlobalNombre As String
    Public UsuarioGlobalDepto As String
    Public UsuarioGlobalCorreo As String
    Public appPath As String = Path.GetDirectoryName(Application.ExecutablePath)

    Public Function EdoCtaAvio(ByVal cAnexo As String, ByVal cFecha As String) As DataTable

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daMinistracion As New SqlDataAdapter(cm1)

        Dim dsAgil As New DataSet()
        Dim dtTIIE As New DataTable()
        Dim drMinistracion As DataRow
        Dim drEdoCtaAvio As DataRow
        Dim drTemporal As DataRow
        Dim dtEdoCtaAvio As New DataTable("EdoCtaAvio")

        ' Declaraci�n de variables de datos

        Dim cDocumento As String
        Dim cFechaDocumento As String = ""
        Dim cFechaGarantia As String = ""
        Dim cFechaInicioIntereses As String = ""
        Dim cFechaTerminacion As String = ""
        Dim cNombreProductor As String = ""
        Dim cPagado As String = ""
        Dim cReferencia As String = "FINAGIL"
        Dim cTipta As String = ""
        Dim cTipar As String = ""
        Dim cUltimoPago As String = ""
        Dim nDiferencialFINAGIL As Decimal = 0
        Dim nGarantiaLiquida As Decimal = 0
        Dim nImporte As Decimal = 0
        Dim nImporteMinistrado As Decimal = 0
        Dim nInteresCapital As Decimal = 0
        Dim nInteresGarantia As Decimal = 0
        Dim nMinistracion As Decimal = 0
        Dim nSaldoMinistracion As Decimal = 0
        Dim nSaldoGarantia As Decimal = 0
        Dim nTasas As Decimal = 0

        ' Primero creo la tabla dtEdoCtaAvio

        dtEdoCtaAvio.Columns.Add("Anexo", Type.GetType("System.String"))
        dtEdoCtaAvio.Columns.Add("Ministracion", Type.GetType("System.Decimal"))
        dtEdoCtaAvio.Columns.Add("Productor", Type.GetType("System.String"))
        dtEdoCtaAvio.Columns.Add("Documento", Type.GetType("System.String"))
        dtEdoCtaAvio.Columns.Add("FechaDocumento", Type.GetType("System.String"))
        dtEdoCtaAvio.Columns.Add("ImporteMinistrado", Type.GetType("System.Decimal"))
        dtEdoCtaAvio.Columns.Add("InteresCapital", Type.GetType("System.Decimal"))
        dtEdoCtaAvio.Columns.Add("GarantiaLiquida", Type.GetType("System.Decimal"))
        dtEdoCtaAvio.Columns.Add("InteresGarantia", Type.GetType("System.Decimal"))
        dtEdoCtaAvio.Columns.Add("SaldoTotal", Type.GetType("System.Decimal"))
        dtEdoCtaAvio.Columns.Add("TasaInteres", Type.GetType("System.String"))
        dtEdoCtaAvio.Columns.Add("UltimoPago", Type.GetType("System.String"))
        dtEdoCtaAvio.Columns.Add("SaldoMinistracion", Type.GetType("System.Decimal"))
        dtEdoCtaAvio.Columns.Add("SaldoGarantia", Type.GetType("System.Decimal"))

        ' Tengo que traer todas las ministraciones que le hemos hecho a los productores a la fecha
        ' y por cada una tengo que determinar el inter�s activo desde la fecha en que se ministr�
        ' y hasta la fecha del reporte.   Es importante comentar que este proceso es necesario realizarlo 
        ' desde el inicio de la ministraci�n porque los intereses son refinanciables.

        ' El siguiente Command trae las ministraciones que le haya hecho FINAGIL al contrato seleccionado y que tengan saldo

        'With cm1
        '    .CommandType = CommandType.Text
        '    .CommandText = "SELECT mFINAGIL.*, FechaTerminacion, Tipta, Tasas, DiferencialFINAGIL, Descr FROM mFINAGIL " & _
        '    "INNER JOIN Avios ON mFINAGIL.Anexo = Avios.Anexo " & _
        '    "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " & _
        '    "WHERE mFINAGIL.Anexo = " & "'" & cAnexo & "'" & " AND Pagado = 'N' AND SaldoMinistracion > 0 AND FechaDocumento <=" & " '" & cFecha & "' " & _
        '    "ORDER BY Ministracion"
        '    .Connection = cnAgil
        'End With

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT mFINAGIL.*, FechaTerminacion, Tipta, Tasas, DiferencialFINAGIL, Descr, tipar FROM mFINAGIL " & _
            "INNER JOIN Avios ON mFINAGIL.Anexo = Avios.Anexo " & _
            "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " & _
            "WHERE mFINAGIL.Anexo = " & "'" & cAnexo & "'" & " AND FechaDocumento <=" & " '" & cFecha & "' " & _
            "ORDER BY Ministracion"
            .Connection = cnAgil
        End With

        daMinistracion.Fill(dsAgil, "Ministraciones")

        ' Genero la tabla que contiene las TIIE promedio por mes 
        ' Para FINAGIL considera todos los d�as del mes y redondea a 4 decimales

        dtTIIE = TIIEavg("FINAGIL")

        For Each drMinistracion In dsAgil.Tables("Ministraciones").Rows

            cAnexo = drMinistracion("Anexo")
            cTipta = drMinistracion("Tipta")
            cTipar = drMinistracion("Tipar")
            nTasas = drMinistracion("Tasas")
            nMinistracion = drMinistracion("Ministracion")
            cNombreProductor = drMinistracion("Descr")
            cDocumento = drMinistracion("Documento")
            If Trim(cDocumento) = "EFECTIVO" Then
                cFechaDocumento = drMinistracion("FechaPago")
            Else
                cFechaDocumento = drMinistracion("FechaDocumento")
            End If
            cFechaTerminacion = drMinistracion("FechaTerminacion")
            cUltimoPago = drMinistracion("UltimoPago")
            nImporteMinistrado = drMinistracion("Importe")
            nGarantiaLiquida = drMinistracion("Garantia")
            nSaldoMinistracion = drMinistracion("SaldoMinistracion")
            nSaldoGarantia = drMinistracion("SaldoGarantia")
            nDiferencialFINAGIL = drMinistracion("DiferencialFINAGIL")
            cPagado = drMinistracion("Pagado")
            nInteresCapital = 0
            nInteresGarantia = 0

            If Trim(cUltimoPago) = "" Then

                ' Se trata del primer pago a este contrato

                cFechaInicioIntereses = cFechaDocumento

            Else

                ' Existe un pago anterior a este contrato

                cFechaInicioIntereses = cUltimoPago

            End If

            If cPagado = "N" And nSaldoMinistracion > 0 Then

                ' En esta parte proceso el importe correspondiente a la ministraci�n

                nImporte = drMinistracion("SaldoMinistracion")
                For Each drTemporal In InteresAcumulado(cAnexo, cTipta, cReferencia, cFechaInicioIntereses, nImporte, nTasas, nDiferencialFINAGIL, cFecha, dtTIIE, cFechaTerminacion, cTipar, False).Rows
                    nInteresCapital += drTemporal("Interes")
                Next

                ' En esta parte proceso el importe correspondiente a la garant�a l�quida, recordando que �sta genera intereses hasta la fecha de terminaci�n o hasta la fecha del reporte (lo que ocurra primero)

                cFechaGarantia = cFecha
                If cFecha > cFechaTerminacion Then
                    cFechaGarantia = cFechaTerminacion
                End If

                nImporte = drMinistracion("SaldoGarantia")
                For Each drTemporal In InteresAcumulado(cAnexo, cTipta, cReferencia, cFechaInicioIntereses, nImporte, nTasas, nDiferencialFINAGIL, cFechaGarantia, dtTIIE, cFechaTerminacion, cTipar, False).Rows
                    nInteresGarantia += drTemporal("Interes")
                Next

            End If

            ' Aqu� puedo generar el primer rengl�n del Estado de Cuenta

            drEdoCtaAvio = dtEdoCtaAvio.NewRow()
            drEdoCtaAvio("Anexo") = cAnexo
            drEdoCtaAvio("Ministracion") = nMinistracion
            drEdoCtaAvio("Productor") = Trim(cNombreProductor)
            If Trim(cDocumento) = "REEMBOLSO" Then
                cDocumento = "EFECTIVO"
            End If
            drEdoCtaAvio("Documento") = Trim(cDocumento)
            drEdoCtaAvio("FechaDocumento") = cFechaDocumento
            drEdoCtaAvio("ImporteMinistrado") = nImporteMinistrado
            drEdoCtaAvio("InteresCapital") = nInteresCapital
            drEdoCtaAvio("GarantiaLiquida") = nGarantiaLiquida
            drEdoCtaAvio("InteresGarantia") = nInteresGarantia
            drEdoCtaAvio("TasaInteres") = "TIIE + " + Str(nDiferencialFINAGIL)
            drEdoCtaAvio("UltimoPago") = cUltimoPago
            drEdoCtaAvio("SaldoMinistracion") = nSaldoMinistracion
            drEdoCtaAvio("SaldoGarantia") = nSaldoGarantia
            drEdoCtaAvio("SaldoTotal") = Round(nSaldoMinistracion + nInteresCapital + nSaldoGarantia + nInteresGarantia, 2)
            dtEdoCtaAvio.Rows.Add(drEdoCtaAvio)

        Next

        EdoCtaAvio = dtEdoCtaAvio

        cnAgil.Dispose()
        cm1.Dispose()

    End Function

    Public Function Estado_de_Cuenta_Avio(ByVal cAnexo As String, ByVal cCiclo As String, ByVal Proyectado As Integer, ByVal Usuario As String)
        Dim cnAgil As New SqlConnection(My.Settings.ProductionConnectionString)
        Dim Res As Object
        Dim cm1 As New SqlCommand()
        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "dbo.EstadoCuentaAvio"
            .CommandTimeout = 50
            .Parameters.AddWithValue("Anexo", cAnexo)
            .Parameters.AddWithValue("Ciclo", cCiclo)
            .Parameters.AddWithValue("Proyectado", Proyectado)
            .Parameters.AddWithValue("usuario", Usuario)
            .Connection = cnAgil
        End With
        cnAgil.Open()
        Res = cm1.ExecuteScalar()
        cnAgil.Close()
        cnAgil.Dispose()
        cm1.Dispose()
        Return (Res)
    End Function


End Module
