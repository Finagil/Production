Option Explicit On

Imports System.Data.SqlClient

Public Class frmProyecta

    Private Sub btnProceso_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProceso.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim daAnexo As New SqlDataAdapter(cm1)
        Dim daEdocta As New SqlDataAdapter(cm2)
        Dim daFacturas As New SqlDataAdapter(cm3)
        Dim drAnexo As DataRow
        Dim drEdocta As DataRow
        Dim drTemp As DataRow
        Dim drFacturas As DataRow()
        Dim drEstados As DataRow()
        Dim dsAgil As New DataSet()
        Dim relAnexoEdoctav As DataRelation
        Dim relAnexoFacturas As DataRelation
        Dim dtReporte As New DataTable("Reporte")
        Dim dvReporte As DataView
        Dim myColArray(1) As DataColumn

        ' Declaración de variables de datos

        Dim cAnexo As String
        Dim cCliente As String
        Dim cFecha As String
        Dim cFondeo As String
        Dim cMonth As String
        Dim cTipar As String
        Dim cYear As String
        Dim cYearPayment As String
        Dim nCounter As Integer
        Dim nMaxCounter As Integer = 100
        Dim nMonto As Decimal
     
        cFecha = DTOC(DateTimePicker1.Value)
        
        ' Primero creo la tabla Temporal que me permitira acumular los saldos de los 
        ' contratos por cliente

        cYear = Mid(cFecha, 1, 4)

        dtReporte.Columns.Add("Mes", Type.GetType("System.String"))
        dtReporte.Columns.Add(cYear, Type.GetType("System.Decimal"))
        dtReporte.Columns.Add(CStr(Val(cYear) + 1), Type.GetType("System.Decimal"))
        dtReporte.Columns.Add(CStr(Val(cYear) + 2), Type.GetType("System.Decimal"))
        dtReporte.Columns.Add(CStr(Val(cYear) + 3), Type.GetType("System.Decimal"))
        dtReporte.Columns.Add(CStr(Val(cYear) + 4), Type.GetType("System.Decimal"))
        dtReporte.Columns.Add(CStr(Val(cYear) + 5), Type.GetType("System.Decimal"))
        myColArray(0) = dtReporte.Columns("Mes")
        dtReporte.PrimaryKey = myColArray

        ' Con este Stored Procedure obtengo los contratos Activos a la fecha solicitada

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv1"
            .Connection = cnAgil
            .Parameters.Add("@Fechafin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv2"
            .Connection = cnAgil
            .Parameters.Add("@Fechafin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae todas las facturas no pagadas de todos los contratos activos con fecha de
        ' contratación menor o igual a la de proceso

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "CalcAnti1"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daAnexo.Fill(dsAgil, "Anexos")
        daEdocta.Fill(dsAgil, "Edoctav")
        daFacturas.Fill(dsAgil, "Facturas")

        ' Establecer la relación entre Anexos y Edoctav

        relAnexoEdoctav = New DataRelation("AnexoEdoctav", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Edoctav").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctav)

        ' Establecer la relación entre Anexos y Facturas

        relAnexoFacturas = New DataRelation("AnexoFacturas", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Facturas").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoFacturas)

        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = drAnexo("Anexo")
            cTipar = drAnexo("Tipar")
            cCliente = drAnexo("Cliente")
            cFondeo = drAnexo("Fondeo")

            If cTipar = "F" Then
                ' If cTipar = "R" Then
                ' If InStr("00006|00015|00044|00045|00061|00066|00353|00426|00457|00606|00676|00719|00898|01054|01455|01521|03193", cCliente) Then
                ' If cFondeo = "03" Then
                ' If cFondeo = "02" Then

                nCounter = 0
                drFacturas = drAnexo.GetChildRows("AnexoFacturas")
                CalcAnti(cAnexo, cFecha, nMaxCounter, nCounter, drFacturas)

                If nCounter <= nMaxCounter Then

                    drEstados = drAnexo.GetChildRows("AnexoEdoctav")

                    For Each drEdocta In drEstados

                        If drEdocta("Feven") > cFecha And drEdocta("Nufac") <> 9999999 Then

                            cYearPayment = Mid(drEdocta("Feven"), 1, 4)
                            cMonth = Mid(drEdocta("Feven"), 5, 2)
                            nMonto = drEdocta("Abcap")

                            drTemp = dtReporte.Rows.Find(cMonth)

                            If drTemp Is Nothing Then

                                ' El mes no existe en la tabla

                                drTemp = dtReporte.NewRow()
                                drTemp("Mes") = cMonth
                                drTemp(cYear) = IIf(cYearPayment = cYear, nMonto, 0)
                                drTemp(CStr(Val(cYear) + 1)) = IIf(cYearPayment = CStr(Val(cYear) + 1), nMonto, 0)
                                drTemp(CStr(Val(cYear) + 2)) = IIf(cYearPayment = CStr(Val(cYear) + 2), nMonto, 0)
                                drTemp(CStr(Val(cYear) + 3)) = IIf(cYearPayment = CStr(Val(cYear) + 3), nMonto, 0)
                                drTemp(CStr(Val(cYear) + 4)) = IIf(cYearPayment = CStr(Val(cYear) + 4), nMonto, 0)
                                drTemp(CStr(Val(cYear) + 5)) = IIf(cYearPayment = CStr(Val(cYear) + 5), nMonto, 0)
                                dtReporte.Rows.Add(drTemp)

                            Else

                                ' El mes ya existe en la tabla

                                Select Case cYearPayment
                                    Case cYear
                                        drTemp(cYear) += nMonto
                                    Case CStr(Val(cYear) + 1)
                                        drTemp(CStr(Val(cYear) + 1)) += nMonto
                                    Case CStr(Val(cYear) + 2)
                                        drTemp(CStr(Val(cYear) + 2)) += nMonto
                                    Case CStr(Val(cYear) + 3)
                                        drTemp(CStr(Val(cYear) + 3)) += nMonto
                                    Case CStr(Val(cYear) + 4)
                                        drTemp(CStr(Val(cYear) + 4)) += nMonto
                                    Case CStr(Val(cYear) + 5)
                                        drTemp(CStr(Val(cYear) + 5)) += nMonto
                                End Select

                            End If

                        End If

                    Next

                End If

            End If

        Next

        dvReporte = New DataView(dtReporte)
        dvReporte.Sort = "Mes"
        DataGridView1.DataSource = dvReporte
        DataGridView1.Columns(1).ToolTipText = "Primer año de amortizaciones"

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class
