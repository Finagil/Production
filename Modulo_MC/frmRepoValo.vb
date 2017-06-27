Option Explicit On

Imports System.Data.SqlClient

Public Class frmRepoValo

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim dsAgil As New DataSet()
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daAnexos As New SqlDataAdapter(cm1)
        Dim daEdoctav As New SqlDataAdapter(cm2)
        Dim drAnexo As DataRow
        Dim drAnexoIncompleto As DataRow
        Dim drEdoctav As DataRow()
        Dim dtRepoValo As New DataTable("RepoValo")
        Dim relAnexoEdoctav As DataRelation

        ' Declaraci�n de variables de datos

        Dim cAnexo As String
        Dim cDescr As String
        Dim cDoc1 As String
        Dim cDoc2 As String
        Dim cDoc3 As String
        Dim cFecha As String
        Dim cFechacon As String
        Dim cFvenc As String
        Dim cObserva As String
        Dim cTermina As String
        Dim cTipar As String = ""
        Dim lProcesar As Boolean
        Dim nContratos As Decimal
        Dim nFaltantes As Decimal
        Dim nMpt As Integer
        Dim nPlazo As Integer
        Dim nSaldoEquipo As Decimal
        Dim cReestructura As String

        ' Declaraci�n de variables de Crystal Reports

        Dim newrptRepoValo As New rptRepoValo()
        Dim cReportTitle As String
        Dim cReportComments As String

        cFecha = DTOC(dtpFechaReporte.Value)

        cReportTitle = "REPORTE DE CONTRATOS CON DOCUMENTACI�N PENDIENTE AL " & Mid(cFecha, 7, 2) & "/" & Mid(cFecha, 5, 2) & "/" & Mid(cFecha, 1, 4)

        ' Creamos una Tabla temporal para guardar cada uno de los registros que formar�n parte
        ' del reporte final de valores

        dtRepoValo.Columns.Add("Num", Type.GetType("System.Decimal"))
        dtRepoValo.Columns.Add("Tipar", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("Anexo", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("Descr", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("Inicio", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("Final", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("Mpt", Type.GetType("System.Decimal"))
        dtRepoValo.Columns.Add("Saldo", Type.GetType("System.Decimal"))
        dtRepoValo.Columns.Add("Factura", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("Contrato", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("Pagare", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("GHipotec", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("Prendaria", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("Scaneo", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("Observacion", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("Reestructura", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("Fecha_Pago", Type.GetType("System.DateTime"))
        dtRepoValo.Columns.Add("RUG", Type.GetType("System.String"))
        dtRepoValo.Columns.Add("PLD", Type.GetType("System.String"))

        dtRepoValo.Clear()

        ' El siguiente Stored Procedure trae todos los contratos activos a la fecha solicitada

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RepoValo1"
            .Connection = cnAgil
            .Parameters.Add("@Fechafin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' El siguiente Stored Procedure trae la tabla de amortizaci�n de todos los contratos 
        ' activos cuya fecha de contrataci�n sea menor o igual a la de proceso

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv2"
            .Connection = cnAgil
            .Parameters.Add("@Fechafin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexi�n

        daAnexos.Fill(dsAgil, "Anexos")
        daEdoctav.Fill(dsAgil, "Edoctav")

        ' Establecer la relaci�n entre Anexos y Edoctav

        relAnexoEdoctav = New DataRelation("AnexoEdoctav", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Edoctav").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctav)

        nContratos = 0
        nFaltantes = 0

        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            lProcesar = True

            nPlazo = drAnexo("Plazo")
            cFvenc = drAnexo("Fvenc")
            If drAnexo("Reestructura") = "S" Then
                cReestructura = "R"
            Else
                cReestructura = ""
            End If


            cAnexo = drAnexo("Anexo")
            cTermina = DTOC(Termina(cAnexo))
            cTipar = drAnexo("Tipar")
            Select Case cTipar
                Case "F"
                    cTipar = "AF"
                Case "P"
                    cTipar = "AP"
                Case "R"
                    cTipar = "CR"
                Case "S"
                    cTipar = "CS"
                Case "A"
                    cTipar = "CA"
                Case "B"
                    cTipar = "FS"
                Case Else
                    cTipar = "**"
            End Select
            nMpt = Mpt(CTOD(cTermina), CTOD(cFecha))

            ' Obtiene la tabla de amortizaci�n de un contrato en particular a fin de calcular el saldo insoluto

            nSaldoEquipo = 0
            drEdoctav = drAnexo.GetChildRows("AnexoEdoctav")
            TraeSald(drEdoctav, cFecha, nSaldoEquipo, 0, 0)

            ' Solo procesa contratos que terminen con posterioridad a la fecha de proceso
            If cTermina <= cFecha Then
                lProcesar = False
            End If
            ' Solo procesa contratos que tengan saldo insoluto ya que pudieran existir contratos
            ' que no est�n marcados como terminados pero que ya no tienen saldo insoluto
            If nSaldoEquipo <= 0 Then
                lProcesar = False
            End If

            ' ''lProcesar = False '#ECT pruebas
            ' '' ''If (cTermina <= cFecha Or drAnexo("FLCAN") = "T") And nSaldoEquipo > 0 Then '#ECT pruebas
            ' ''If (drAnexo("FLCAN") = "T") And nSaldoEquipo > 0 Then '#ECT pruebas
            ' ''    cTipar = "TS" '#ECT pruebas
            ' ''    lProcesar = True '#ECT pruebas
            ' ''End If '#ECT pruebas
            ' ''lProcesar = True '#ECT pruebas


            If lProcesar = True Then

                cDescr = drAnexo("Descr")
                cFechacon = drAnexo("Fechacon")
                cDoc1 = drAnexo("Doc1")
                cDoc2 = drAnexo("Doc2")
                cDoc3 = drAnexo("Doc3")
                cObserva = drAnexo("Observa")
                If cDoc1 <> "S" Or cDoc2 <> "S" Or cDoc3 <> "S" Or drAnexo("Prendaria") <> "S" Or drAnexo("scaneo") <> "S" Or drAnexo("GHipotec") <> "S" Then
                    drAnexoIncompleto = dtRepoValo.NewRow()
                    drAnexoIncompleto("Num") = nFaltantes
                    drAnexoIncompleto("Tipar") = cTipar
                    drAnexoIncompleto("Anexo") = cAnexo
                    drAnexoIncompleto("Descr") = RTrim(cDescr)
                    drAnexoIncompleto("Inicio") = Mid(CTOD(cFechacon), 1, 10)
                    drAnexoIncompleto("Final") = Mid(CTOD(cTermina), 1, 10)
                    drAnexoIncompleto("Mpt") = nMpt
                    drAnexoIncompleto("Saldo") = nSaldoEquipo
                    drAnexoIncompleto("Factura") = cDoc1
                    drAnexoIncompleto("Contrato") = cDoc2
                    drAnexoIncompleto("Pagare") = cDoc3
                    drAnexoIncompleto("Prendaria") = drAnexo("Prendaria")
                    drAnexoIncompleto("GHipotec") = drAnexo("GHipotec")
                    drAnexoIncompleto("Scaneo") = drAnexo("Scaneo")
                    drAnexoIncompleto("Observacion") = RTrim(cObserva)
                    drAnexoIncompleto("Reestructura") = cReestructura
                    drAnexoIncompleto("RUG") = drAnexo("RUG")
                    drAnexoIncompleto("PLD") = drAnexo("PLD")
                    drAnexoIncompleto("Fecha_Pago") = CTOD(drAnexo("Fecha_Pago"))
                    dtRepoValo.Rows.Add(drAnexoIncompleto)
                Else
                    If CheckAll.Checked = True Then
                        nFaltantes = nFaltantes + 1
                        drAnexoIncompleto = dtRepoValo.NewRow()
                        drAnexoIncompleto("Num") = nFaltantes
                        drAnexoIncompleto("Tipar") = cTipar
                        drAnexoIncompleto("Anexo") = cAnexo
                        drAnexoIncompleto("Descr") = RTrim(cDescr)
                        drAnexoIncompleto("Inicio") = Mid(CTOD(cFechacon), 1, 10)
                        drAnexoIncompleto("Final") = Mid(CTOD(cTermina), 1, 10)
                        drAnexoIncompleto("Mpt") = nMpt
                        drAnexoIncompleto("Saldo") = nSaldoEquipo
                        drAnexoIncompleto("Factura") = cDoc1
                        drAnexoIncompleto("Contrato") = cDoc2
                        drAnexoIncompleto("Pagare") = cDoc3
                        drAnexoIncompleto("Prendaria") = drAnexo("Prendaria")
                        drAnexoIncompleto("GHipotec") = drAnexo("GHipotec")
                        drAnexoIncompleto("Scaneo") = drAnexo("Scaneo")
                        drAnexoIncompleto("Observacion") = RTrim(cObserva)
                        drAnexoIncompleto("Reestructura") = cReestructura
                        drAnexoIncompleto("RUG") = drAnexo("RUG")
                        drAnexoIncompleto("PLD") = drAnexo("PLD")
                        drAnexoIncompleto("Fecha_Pago") = CTOD(drAnexo("Fecha_Pago"))
                        dtRepoValo.Rows.Add(drAnexoIncompleto)
                    End If
                End If
                nContratos = nContratos + 1

            End If

        Next

        cReportComments = "TOTAL DE BIENES " & nContratos

        dsAgil.Relations.Clear()
        dsAgil.Tables("Anexos").Constraints.Clear()
        dsAgil.Tables("Edoctav").Constraints.Clear()
        dsAgil.Tables.Remove("Anexos")
        dsAgil.Tables.Remove("Edoctav")
        dsAgil.Tables.Add(dtRepoValo)

        ' Descomentar esta linea cuando se desee modificar rptRepoValo
        'dsAgil.WriteXml("C:\Files\Schema45.xml", XmlWriteMode.WriteSchema)

        newrptRepoValo.SetDataSource(dsAgil)
        newrptRepoValo.SummaryInfo.ReportTitle = cReportTitle
        newrptRepoValo.SummaryInfo.ReportComments = cReportComments
        CrystalReportViewer1.ReportSource = newrptRepoValo
        CrystalReportViewer1.Visible = True

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class