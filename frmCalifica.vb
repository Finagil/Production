Option Explicit On

Imports System.Data.SqlClient
Imports System.Math

Public Class frmCalifica

    ' Declaraci�n de variables de conexi�n ADO .NET de alcance privado

    Dim dsAgil As New DataSet()
    Dim dtDetalle As New DataTable("Detalle")
    Dim dtResumen As New DataTable("Resumen")

    ' Declaraci�n de variables de Crystal Reports de alcance privado

    Dim cReportTitle As String

    ' Declaraci�n de variable de datos de alcance privado

    Dim cFecha As String

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        ' Este programa debe tomar todos los contratos activos con fecha de contrataci�n menor o igual a la
        ' fecha de proceso.   Tambi�n debe tomar la tabla de amortizaci�n del equipo de todos los contratos
        ' obtenidos con el criterio anterior.   Aunque esto crear� un dataset con muchos registros, por
        ' otra parte permitir� mantener abierta la conexi�n �nicamente durante el tiempo que tarde en
        ' traer dicha informaci�n de la base de datos.

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim cm5 As New SqlCommand()
        Dim cm6 As New SqlCommand()
        Dim dsReporte As New DataSet()
        Dim daAnexos As New SqlDataAdapter(cm1)
        Dim daEdoctaV As New SqlDataAdapter(cm2)
        Dim daEdoctaS As New SqlDataAdapter(cm3)
        Dim daEdoctaO As New SqlDataAdapter(cm4)
        Dim daFacturas As New SqlDataAdapter(cm5)
        Dim daReestructurados As New SqlDataAdapter(cm6)
        Dim dtFinal As New DataTable()
        Dim drEdoctav As DataRow()
        Dim drEdoctas As DataRow()
        Dim drEdoctao As DataRow()
        Dim drRegistros As DataRow()
        Dim drAnexo As DataRow
        Dim drFactura As DataRow
        Dim drReestructura As DataRow
        Dim drRegistro As DataRow
        Dim drDetalle As DataRow
        Dim drResumen As DataRow
        Dim relAnexoEdoctav As DataRelation
        Dim relAnexoEdoctas As DataRelation
        Dim relAnexoEdoctao As DataRelation
        Dim myColArray(1) As DataColumn

        ' Declaraci�n de variables de datos

        Dim cAnexo As String = ""
        Dim cCusnam As String = ""
        Dim cVencida As String = ""
        Dim nCarteraEquipo As Decimal = 0
        Dim nSaldoSeguro As Decimal = 0
        Dim nSaldoOtros As Decimal = 0
        Dim nInteresSeguro As Decimal = 0
        Dim nInteresOtros As Decimal = 0
        Dim nCarteraSeguro As Decimal = 0
        Dim nCarteraOtros As Decimal = 0
        Dim nDiasVencido As Integer = 0
        Dim nInteresEquipo As Decimal = 0
        Dim nRango As Integer = 0
        Dim nSaldoEquipo As Decimal = 0
        Dim nSaldoFac As Decimal = 0

        btnProcesar.Enabled = False

        cFecha = DTOC(dtpProcesar.Value)

        ' Primero creo la tabla Detalle que ser� la base del reporte

        dtDetalle.Columns.Add("Anexo", Type.GetType("System.String"))
        dtDetalle.Columns.Add("Cliente", Type.GetType("System.String"))
        dtDetalle.Columns.Add("SaldoEquipo", Type.GetType("System.Decimal"))
        dtDetalle.Columns.Add("Dias", Type.GetType("System.Decimal"))
        dtDetalle.Columns.Add("AdeudoTotal", Type.GetType("System.Decimal"))
        dtDetalle.Columns.Add("Reestructurado", Type.GetType("System.String"))
        myColArray(0) = dtDetalle.Columns("Anexo")
        dtDetalle.PrimaryKey = myColArray

        ' A continuaci�n creo la tabla Resumen que contendr� el resumen del reporte

        dtResumen.Columns.Add("Rango", Type.GetType("System.Decimal"))
        dtResumen.Columns.Add("Grado1", Type.GetType("System.String"))
        dtResumen.Columns.Add("Porcentaje1", Type.GetType("System.Decimal"))
        dtResumen.Columns.Add("Adeudo1", Type.GetType("System.Decimal"))
        dtResumen.Columns.Add("Reserva1", Type.GetType("System.Decimal"))
        dtResumen.Columns.Add("Porcentaje2", Type.GetType("System.Decimal"))
        dtResumen.Columns.Add("Adeudo2", Type.GetType("System.Decimal"))
        dtResumen.Columns.Add("Reserva2", Type.GetType("System.Decimal"))
        myColArray(0) = dtResumen.Columns("Rango")
        dtResumen.PrimaryKey = myColArray

        drResumen = dtResumen.NewRow()
        drResumen("Rango") = 1
        drResumen("Grado1") = "0 a 30"
        drResumen("Porcentaje1") = 0.5
        drResumen("Adeudo1") = 0
        drResumen("Reserva1") = 0
        drResumen("Porcentaje2") = 2.0
        drResumen("Adeudo2") = 0
        drResumen("Reserva2") = 0
        dtResumen.Rows.Add(drResumen)

        drResumen = dtResumen.NewRow()
        drResumen("Rango") = 2
        drResumen("Grado1") = "31 a 60"
        drResumen("Porcentaje1") = 15.0
        drResumen("Adeudo1") = 0
        drResumen("Reserva1") = 0
        drResumen("Porcentaje2") = 30.0
        drResumen("Adeudo2") = 0
        drResumen("Reserva2") = 0
        dtResumen.Rows.Add(drResumen)

        drResumen = dtResumen.NewRow()
        drResumen("Rango") = 3
        drResumen("Grado1") = "61 a 90"
        drResumen("Porcentaje1") = 30.0
        drResumen("Adeudo1") = 0
        drResumen("Reserva1") = 0
        drResumen("Porcentaje2") = 40.0
        drResumen("Adeudo2") = 0
        drResumen("Reserva2") = 0
        dtResumen.Rows.Add(drResumen)

        drResumen = dtResumen.NewRow()
        drResumen("Rango") = 4
        drResumen("Grado1") = "91 a 120"
        drResumen("Porcentaje1") = 40.0
        drResumen("Adeudo1") = 0
        drResumen("Reserva1") = 0
        drResumen("Porcentaje2") = 50.0
        drResumen("Adeudo2") = 0
        drResumen("Reserva2") = 0
        dtResumen.Rows.Add(drResumen)

        drResumen = dtResumen.NewRow()
        drResumen("Rango") = 5
        drResumen("Grado1") = "121 a 150"
        drResumen("Porcentaje1") = 60.0
        drResumen("Adeudo1") = 0
        drResumen("Reserva1") = 0
        drResumen("Porcentaje2") = 70.0
        drResumen("Adeudo2") = 0
        drResumen("Reserva2") = 0
        dtResumen.Rows.Add(drResumen)

        drResumen = dtResumen.NewRow()
        drResumen("Rango") = 6
        drResumen("Grado1") = "151 a 180"
        drResumen("Porcentaje1") = 75.0
        drResumen("Adeudo1") = 0
        drResumen("Reserva1") = 0
        drResumen("Porcentaje2") = 85.0
        drResumen("Adeudo2") = 0
        drResumen("Reserva2") = 0
        dtResumen.Rows.Add(drResumen)

        drResumen = dtResumen.NewRow()
        drResumen("Rango") = 7
        drResumen("Grado1") = "181 a 210"
        drResumen("Porcentaje1") = 85.0
        drResumen("Adeudo1") = 0
        drResumen("Reserva1") = 0
        drResumen("Porcentaje2") = 95.0
        drResumen("Adeudo2") = 0
        drResumen("Reserva2") = 0
        dtResumen.Rows.Add(drResumen)

        drResumen = dtResumen.NewRow()
        drResumen("Rango") = 8
        drResumen("Grado1") = "211 a 240"
        drResumen("Porcentaje1") = 95.0
        drResumen("Adeudo1") = 0
        drResumen("Reserva1") = 0
        drResumen("Porcentaje2") = 100.0
        drResumen("Adeudo2") = 0
        drResumen("Reserva2") = 0
        dtResumen.Rows.Add(drResumen)

        drResumen = dtResumen.NewRow()
        drResumen("Rango") = 9
        drResumen("Grado1") = "241 en adelante"
        drResumen("Porcentaje1") = 100.0
        drResumen("Adeudo1") = 0
        drResumen("Reserva1") = 0
        drResumen("Porcentaje2") = 100.0
        drResumen("Adeudo2") = 0
        drResumen("Reserva2") = 0
        dtResumen.Rows.Add(drResumen)

        ' Este Stored Procedure trae todos los contratos activos con fecha de contrataci�n menor o igual
        ' a la de proceso

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv1"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortizaci�n del EQUIPO de todos los contratos activos
        ' con fecha de contrataci�n menor o igual a la de proceso

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv2"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortizaci�n del SEGURO de todos los contratos activos
        ' con fecha de contrataci�n menor o igual a la de proceso

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv3"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortizaci�n de OTROS ADEUDOS de todos los contratos activos
        ' con fecha de contrataci�n menor o igual a la de proceso

        With cm4
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv4"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae las facturas vencidas, el pago inicial (sin el 5% Nafin) 
        ' y la opci�n de compra exigible de los contratos activos o terminados con saldo en rentas

        With cm5
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RepAntig1"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure regresa el n�mero de los anexos activos o terminados que han tenido
        ' reestructura por capitalizaci�n de adeudo

        With cm6
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RepAntig5"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet a trav�s del DataAdapter, lo cual abre y cierra la conexi�n

        daAnexos.Fill(dsAgil, "Anexos")
        daEdoctaV.Fill(dsAgil, "Edoctav")
        daEdoctaS.Fill(dsAgil, "Edoctao")
        daEdoctaO.Fill(dsAgil, "Edoctas")
        daFacturas.Fill(dsAgil, "Facturas")
        daReestructurados.Fill(dsAgil, "Reestructurados")

        ' Establecer la relaci�n entre Anexos y EdoctaV

        relAnexoEdoctav = New DataRelation("AnexoEdoctav", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Edoctav").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctav)

        ' Establecer la relaci�n entre Anexos y EdoctaS

        relAnexoEdoctas = New DataRelation("AnexoEdoctas", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Edoctas").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctas)

        ' Establecer la relaci�n entre Anexos y EdoctaO

        relAnexoEdoctao = New DataRelation("AnexoEdoctao", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Edoctao").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctao)

        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = drAnexo("Anexo")
            cCusnam = drAnexo("Descr")
            cVencida = drAnexo("Vencida")

            If cVencida <> "C" Then

                ' Solamente procesa los contratos que no est�n Castigados

                nSaldoEquipo = 0
                nInteresEquipo = 0
                nCarteraEquipo = 0

                ' Esta instrucci�n trae la tabla de amortizaci�n del EQUIPO �nica y exclusivamente del contrato
                ' que est� siendo procesado

                drEdoctav = drAnexo.GetChildRows("AnexoEdoctav")
                TraeSald(drEdoctav, cFecha, nSaldoEquipo, nInteresEquipo, nCarteraEquipo, True, drAnexo("Tipar"))

                nSaldoSeguro = 0
                nInteresSeguro = 0
                nCarteraSeguro = 0

                ' Esta instrucci�n trae la tabla de amortizaci�n del SEGURO �nica y exclusivamente del contrato
                ' que est� siendo procesado

                drEdoctas = drAnexo.GetChildRows("AnexoEdoctas")
                TraeSald(drEdoctas, cFecha, nSaldoSeguro, nInteresSeguro, nCarteraSeguro, False, drAnexo("Tipar"))

                nSaldoOtros = 0
                nInteresOtros = 0
                nCarteraOtros = 0

                ' Esta instrucci�n trae la tabla de amortizaci�n de OTROS ADEUDOS �nica y exclusivamente del contrato
                ' que est� siendo procesado

                drEdoctao = drAnexo.GetChildRows("AnexoEdoctao")
                TraeSald(drEdoctao, cFecha, nSaldoOtros, nInteresOtros, nCarteraOtros, False, drAnexo("Tipar"))

                drDetalle = dtDetalle.NewRow()
                drDetalle("Anexo") = Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4)
                drDetalle("Cliente") = cCusnam
                drDetalle("SaldoEquipo") = nSaldoEquipo + nSaldoSeguro + nSaldoOtros
                drDetalle("Dias") = 0
                drDetalle("AdeudoTotal") = nSaldoEquipo + nSaldoSeguro + nSaldoOtros
                drDetalle("Reestructurado") = "N"
                dtDetalle.Rows.Add(drDetalle)

            End If

        Next

        ' Ahora barro la tabla Facturas para determinar la antiguedad del saldo de cada factura
        ' y posicionarla en el lugar que le corresponda

        For Each drFactura In dsAgil.Tables("Facturas").Rows

            cAnexo = Mid(drFactura("Anexo"), 1, 5) & "/" & Mid(drFactura("Anexo"), 6, 4)
            cCusnam = drFactura("Descr")
            cVencida = drFactura("Vencida")

            If cVencida <> "C" Then

                nSaldoFac = drFactura("SaldoFac")
                nDiasVencido = DateDiff(DateInterval.Day, CTOD(drFactura("Feven")), CTOD(cFecha)) + 1

                If nDiasVencido > 0 Then

                    drDetalle = dtDetalle.Rows.Find(cAnexo)

                    If drDetalle Is Nothing Then
                        drDetalle = dtDetalle.NewRow()
                        drDetalle("Anexo") = cAnexo
                        drDetalle("Cliente") = cCusnam
                        drDetalle("SaldoEquipo") = 0
                        drDetalle("Dias") = nDiasVencido
                        drDetalle("AdeudoTotal") = nSaldoFac
                        drDetalle("Reestructurado") = "N"
                        dtDetalle.Rows.Add(drDetalle)
                    Else
                        If nDiasVencido > drDetalle("Dias") Then
                            drDetalle("Dias") = nDiasVencido
                        End If
                        drDetalle("AdeudoTotal") += nSaldoFac
                    End If

                End If

            End If

        Next

        For Each drReestructura In dsAgil.Tables("Reestructurados").Rows
            cAnexo = Mid(drReestructura("Anexo"), 1, 5) & "/" & Mid(drReestructura("Anexo"), 6, 4)
            drDetalle = dtDetalle.Rows.Find(cAnexo)
            If Not drDetalle Is Nothing Then
                drDetalle("Reestructurado") = "S"
            End If
        Next

        dtFinal = dtDetalle.Clone()
        drRegistros = dtDetalle.Select(True, "Reestructurado DESC, Dias DESC, AdeudoTotal DESC")

        For Each drRegistro In drRegistros
            dtFinal.ImportRow(drRegistro)
        Next

        dtDetalle = dtFinal.Copy()

        ' Aqu� ya tengo el detalle del reporte ORDENADO por lo que solo tengo que procesarlo para obtener el resumen

        For Each drDetalle In dtDetalle.Rows

            nDiasVencido = drDetalle("Dias")

            Select Case nDiasVencido
                Case 0 To 30
                    nRango = 1
                Case 31 To 60
                    nRango = 2
                Case 61 To 90
                    nRango = 3
                Case 91 To 120
                    nRango = 4
                Case 121 To 150
                    nRango = 5
                Case 151 To 180
                    nRango = 6
                Case 181 To 210
                    nRango = 7
                Case 211 To 240
                    nRango = 8
                Case Else
                    nRango = 9
            End Select

            drResumen = dtResumen.Rows.Find(nRango)

            If Not drResumen Is Nothing Then
                If drDetalle("Reestructurado") = "N" Then
                    drResumen("Adeudo1") += drDetalle("AdeudoTotal")
                Else
                    drResumen("Adeudo2") += drDetalle("AdeudoTotal")
                End If
            End If

        Next

        For Each drResumen In dtResumen.Rows
            drResumen("Reserva1") = Round(drResumen("Adeudo1") * drResumen("Porcentaje1") / 100, 2)
            drResumen("Reserva2") = Round(drResumen("Adeudo2") * drResumen("Porcentaje2") / 100, 2)
        Next

        dsAgil.Relations.Clear()
        dsAgil.Tables("Anexos").Constraints.Clear()
        dsAgil.Tables("Edoctav").Constraints.Clear()
        dsAgil.Tables("Edoctas").Constraints.Clear()
        dsAgil.Tables("Edoctao").Constraints.Clear()
        dsAgil.Tables.Remove("Anexos")
        dsAgil.Tables.Remove("Edoctav")
        dsAgil.Tables.Remove("Edoctas")
        dsAgil.Tables.Remove("Edoctao")
        dsAgil.Tables.Remove("Facturas")
        dsAgil.Tables.Remove("Reestructurados")

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
        cm4.Dispose()
        cm5.Dispose()
        cm6.Dispose()

        btnProcesar.Enabled = False

        btnResumen.Visible = True
        btnDetalle.Visible = True

        CrystalReportViewer1.Visible = True

    End Sub

    Private Sub btnResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResumen.Click

        Dim newrptCalificaResumen As New rptCalificaResumen()

        If dsAgil.Tables.Contains("Resumen") = False Then
            dsAgil.Tables.Add(dtResumen)
        End If

        ' Descomentar la siguiente l�nea en caso de que se deseara modificar el reporte rptCalificaResumen
        ' dsAgil.WriteXml("C:\Schema15.xml", XmlWriteMode.WriteSchema)

        newrptCalificaResumen.SetDataSource(dsAgil)
        cReportTitle = "RESUMEN DE CALIFICACI�N DE LA CARTERA AL " & Mes(cFecha)
        newrptCalificaResumen.SummaryInfo.ReportTitle = cReportTitle
        CrystalReportViewer1.ReportSource = newrptCalificaResumen

    End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click

        Dim newrptCalificaDetalle As New rptCalificaDetalle()

        If dsAgil.Tables.Contains("Detalle") = False Then
            dsAgil.Tables.Add(dtDetalle)
        End If

        ' Descomentar la siguiente l�nea en caso de que se deseara modificar el reporte rptCalificaDetalle
        ' dsAgil.WriteXml("C:\Schema15.xml", XmlWriteMode.WriteSchema)

        newrptCalificaDetalle.SetDataSource(dsAgil)
        cReportTitle = "DETALLE DE CALIFICACI�N DE LA CARTERA AL " & Mes(cFecha)
        newrptCalificaDetalle.SummaryInfo.ReportTitle = cReportTitle
        CrystalReportViewer1.ReportSource = newrptCalificaDetalle

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class