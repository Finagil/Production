Option Explicit On

Imports System.Data.SqlClient
Public Class frmReporteCheckList

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daDocumento As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet()

        Dim cReportTitle As String
        Dim cFecha As String

        ' Declaración de variables de Crystal Reports

        Dim newrptRepCheckList As New rptReporteCheckList()

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Documentos"
            .Connection = cnAgil
        End With

        daDocumento.Fill(dsAgil, "Datos")
        cFecha = DTOC(dtpProceso.Value)

        ' Descomentar la siguiente línea en caso de que se deseara modificar el reporte
        dsAgil.WriteXml("C:\Schema30.xml", XmlWriteMode.WriteSchema)

        newrptRepCheckList.SetDataSource(dsAgil)
        cReportTitle = "REPORTE DE DOCUMENTOS RECABADOS POR CONTRATO AL " & Mes(cFecha)

        newrptRepCheckList.SummaryInfo.ReportTitle = cReportTitle
        CrystalReportViewer1.ReportSource = newrptRepCheckList

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class