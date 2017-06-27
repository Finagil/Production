Option Explicit On

Imports System.Data.SqlClient

Public Class frmMinistracionFP

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daFINAGIL As New SqlDataAdapter(cm1)

        Dim dsAgil As New DataSet
        Dim drMinistracion As DataRow
        Dim drTemporal As DataRow
        Dim dtMinistraciones As New DataTable("Ministraciones")
        Dim myColArray(1) As DataColumn
        Dim myKeySearch(0) As String

        ' Declaración de variables de datos

        Dim cProductor As String = ""
        Dim cDocumento As String = ""
        Dim cFecha As String
        Dim nHectareasActual As Decimal = 0
        Dim nImporte As Decimal = 0
        Dim nLineaAutorizada As Decimal = 0
        Dim cCiclo As String = "02"

        ' Primero creo la tabla dtMinistraciones

        dtMinistraciones.Columns.Add("Productor", Type.GetType("System.String"))
        dtMinistraciones.Columns.Add("HectareasActual", Type.GetType("System.Decimal"))
        dtMinistraciones.Columns.Add("LineaAutorizada", Type.GetType("System.Decimal"))
        dtMinistraciones.Columns.Add("Efectivo", Type.GetType("System.Decimal"))
        dtMinistraciones.Columns.Add("Vales", Type.GetType("System.Decimal"))
        dtMinistraciones.Columns.Add("Recibos", Type.GetType("System.Decimal"))
        dtMinistraciones.Columns.Add("Buro", Type.GetType("System.Decimal"))
        dtMinistraciones.Columns.Add("Notario", Type.GetType("System.Decimal"))
        dtMinistraciones.Columns.Add("RPP", Type.GetType("System.Decimal"))
        dtMinistraciones.Columns.Add("Gastos", Type.GetType("System.Decimal"))
        dtMinistraciones.Columns.Add("Asistencia", Type.GetType("System.Decimal"))
        dtMinistraciones.Columns.Add("Seguro", Type.GetType("System.Decimal"))
        dtMinistraciones.Columns.Add("Total", Type.GetType("System.Decimal"))

        ' Tengo que definir una llave primaria para la tabla dtMinistraciones a fin de buscar un productor
        ' para acumular ministraciones

        myColArray(0) = dtMinistraciones.Columns("Productor")
        dtMinistraciones.PrimaryKey = myColArray

        cFecha = DTOC(dtpProceso.Value)

        ' El siguiente Command trae los datos de las ministraciones FINAGIL - Productor

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT mFINAGIL.*, Descr, HectareasActual, LineaActual FROM mFINAGIL " & _
                           "INNER JOIN Avios ON mFINAGIL.Anexo = Avios.Anexo " & _
                           "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " & _
                           "WHERE mFINAGIL.Ciclo = '" & cCiclo & "' AND FechaPago <= " & "'" & cFecha & "' " & _
                           "ORDER BY Anexo"
            .Connection = cnAgil
        End With

        ' Llenar el dataset lo cual abre y cierra la conexión

        daFINAGIL.Fill(dsAgil, "FINAGIL")

        For Each drMinistracion In dsAgil.Tables("FINAGIL").Rows

            cProductor = drMinistracion("Descr")
            nImporte = drMinistracion("Importe")
            cDocumento = Trim(drMinistracion("Documento"))
            nHectareasActual = drMinistracion("HectareasActual")
            nLineaAutorizada = drMinistracion("LineaActual")

            myKeySearch(0) = cProductor

            drTemporal = dtMinistraciones.Rows.Find(myKeySearch)

            If drTemporal Is Nothing Then
                drTemporal = dtMinistraciones.NewRow()
                drTemporal("Productor") = cProductor
                drTemporal("HectareasActual") = nHectareasActual
                drTemporal("LineaAutorizada") = nLineaAutorizada
                drTemporal("Efectivo") = IIf(cDocumento = "EFECTIVO", nImporte, 0)
                drTemporal("Vales") = IIf(cDocumento = "VALE", nImporte, 0)
                drTemporal("Recibos") = IIf(cDocumento = "RECIBO", nImporte, 0)
                drTemporal("Buro") = IIf(cDocumento = "BURO", nImporte, 0)
                drTemporal("Notario") = IIf(cDocumento = "NOTARIO", nImporte, 0)
                drTemporal("RPP") = IIf(cDocumento = "RPP", nImporte, 0)
                drTemporal("Gastos") = IIf(cDocumento = "GASTOS", nImporte, 0)
                drTemporal("Asistencia") = IIf(cDocumento = "ASISTENCIA", nImporte, 0)
                drTemporal("Seguro") = IIf(cDocumento = "SEGURO", nImporte, 0)
                drTemporal("Total") = nImporte
                dtMinistraciones.Rows.Add(drTemporal)
            Else
                Select Case cDocumento
                    Case "EFECTIVO"
                        drTemporal("Efectivo") += nImporte
                    Case "VALE"
                        drTemporal("Vales") += nImporte
                    Case "RECIBO"
                        drTemporal("Recibos") += nImporte
                    Case "BURO"
                        drTemporal("Buro") += nImporte
                    Case "NOTARIO"
                        drTemporal("Notario") += nImporte
                    Case "RPP"
                        drTemporal("RPP") += nImporte
                    Case "GASTOS"
                        drTemporal("Gastos") += nImporte
                    Case "ASISTENCIA"
                        drTemporal("Asistencia") += nImporte
                    Case "SEGURO"
                        drTemporal("Seguro") += nImporte
                End Select
                drTemporal("Total") += nImporte
            End If

        Next

        dsAgil.Tables.Remove("FINAGIL")

        dsAgil.Tables.Add(dtMinistraciones)

        DataGridView1.DataSource = dtMinistraciones

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class