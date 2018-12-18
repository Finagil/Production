Option Explicit On

Imports System.Data.SqlClient
Imports System.Math

Public Class frmRepAvisosxv

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim daAvisos As New SqlDataAdapter(cm1)
        Dim daAdeudo As New SqlDataAdapter(cm2)
        Dim daEdoctav As New SqlDataAdapter(cm3)
        Dim dsAgil As New DataSet()
        Dim dsReporte As New DataSet()
        Dim dtReporte As New DataTable("Avisosxv")
        Dim drAvisos As DataRow
        Dim drDeudas As DataRow
        Dim drReporte As DataRow
        Dim drEdoctav As DataRow()
        Dim relAnexoEdoctav As DataRelation

        ' Declaración de variables de datos

        Dim cFecha As String
        Dim cAnexo As String
        Dim cCusnam As String
        Dim cFvenc As String
        Dim cLetra As String
        Dim cTipar As String
        Dim nImpFa As Decimal
        Dim nImpSf As Decimal
        Dim nSegu As Decimal
        Dim nFactu As Decimal
        Dim nSdoven As Decimal
        Dim nSaldoa As Decimal
        Dim nRtasv As Decimal
        Dim nSaldoEquipo As Decimal
        Dim nInteresEquipo As Decimal
        Dim nCarteraEquipo As Decimal
        Dim nRtaven As Byte
        Dim nPlazo As Byte
       
        ' Declaración de variables de Crystal Reports

        Dim newrptRepAvisosxv As New rptRepAvisosxVen()
        
        cFecha = DTOC(dtpProcesar.Value)

        ' Primero creo la tabla Reporte que será la base del reporte

        dtReporte.Columns.Add("Contrato", Type.GetType("System.String"))
        dtReporte.Columns.Add("Cliente", Type.GetType("System.String"))
        dtReporte.Columns.Add("Feven", Type.GetType("System.String"))
        dtReporte.Columns.Add("Letra", Type.GetType("System.String"))
        dtReporte.Columns.Add("Tipar", Type.GetType("System.String"))
        dtReporte.Columns.Add("Saldoa", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("Saldov", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("Rtasven", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("ImpSeguro", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("ImpFactura", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("SaldoFact", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("NumFactura", Type.GetType("System.String"))

        ' Este Stored Procedure trae todos los Avisos de Vencimiento con Fecha mayor o igual a la solicitada

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Facturas.Anexo,Descr, Feven,Letra, Plazo, Rense+Intse+Varse+Facturas.Ivase as Segu, importeFac, SaldoFac, Factura, Iniciales, Tipar FROM Facturas " &
                        "INNER JOIN Anexos ON Anexos.Anexo = Facturas.Anexo INNER JOIN Clientes ON Clientes.Cliente = Facturas.Cliente" &
                        " INNER JOIN Promotores ON Anexos.Promotor = Promotores.Promotor WHERE Feven >= " & "'" & cFecha & "'" & " AND SaldoFac > 0" & " Order By Iniciales, Factura"
            .Connection = cnAgil
        End With

        ' El siguiente Stored Procedure trae todos los Bienes asociados a los Vencimientos solicitados
        
        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT Anexo, SaldoFac FROM Facturas WHERE Feven < " & "'" & cFecha & "'" & " Order By Facturas.Anexo"
            .Connection = cnAgil
        End With

        ' Este Stored Procedure trae la tabla de amortización del equipo de todos los contratos activos
        ' con fecha de contratación menor o igual a la de proceso

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv2"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        daAvisos.Fill(dsAgil, "Avisos")
        'daAdeudo.Fill(dsAgil, "Adeudo")
        daEdoctav.Fill(dsAgil, "Tablas")

        ' Establecer la relación entre Anexos y Edoctav

        relAnexoEdoctav = New DataRelation("AnexoEdoctav", dsAgil.Tables("Avisos").Columns("Anexo"), dsAgil.Tables("Tablas").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctav)

        For Each drAvisos In dsAgil.Tables("Avisos").Rows
            nSdoven = 0
            nRtaven = 0
            nSaldoEquipo = 0
            nInteresEquipo = 0
            nCarteraEquipo = 0
            cAnexo = drAvisos("Anexo")
            cCusnam = Trim(drAvisos("Descr"))
            cLetra = drAvisos("Letra")
            cFvenc = drAvisos("Feven")
            cTipar = drAvisos("Tipar")
            nPlazo = drAvisos("Plazo")
            nImpFa = drAvisos("ImporteFac")
            nImpSf = drAvisos("SaldoFac")
            nSegu = drAvisos("Segu")
            nFactu = drAvisos("Factura")

            cm2.CommandText = "SELECT Anexo, SaldoFac FROM Facturas WHERE Feven < " & "'" & cFecha & "' and Anexo = '" & cAnexo & "' and saldoFAC > 30 Order By Facturas.Anexo"
            daAdeudo.Fill(dsAgil, "Adeudo")
            

            ' Esta instrucción trae la tabla de amortización del Equipo única y exclusivamente del contrato
            ' que está siendo procesado

            drEdoctav = drAvisos.GetChildRows("AnexoEdoctav")
            TraeSald(drEdoctav, cFecha, nSaldoEquipo, nInteresEquipo, nCarteraEquipo, True, cTipar)

            For Each drDeudas In dsAgil.Tables("Adeudo").Rows
                If cAnexo = drDeudas("Anexo") And drDeudas("SaldoFac") > 30 Then
                    nSdoven += drDeudas("SaldoFac")
                    nRtaven += 1
                End If
            Next

            drReporte = dtReporte.NewRow()
            drReporte("Contrato") = Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4)
            drReporte("Cliente") = cCusnam
            drReporte("Feven") = CTOD(cFvenc).ToShortDateString
            drReporte("Letra") = Val(cLetra).ToString & " de " & nPlazo.ToString
            drReporte("Tipar") = cTipar
            drReporte("Saldoa") = nSaldoEquipo
            drReporte("Saldov") = nSdoven
            drReporte("Rtasven") = nRtaven
            drReporte("ImpSeguro") = nSegu
            drReporte("ImpFactura") = nImpFa
            drReporte("SaldoFact") = nImpSf
            drReporte("NumFactura") = nFactu.ToString & "  " & drAvisos("Iniciales")
            dtReporte.Rows.Add(drReporte)

        Next
        dsReporte.Tables.Add(dtReporte)

        ' Descomentar la siguiente línea en caso de que se deseara modificar el reporte rptRepSaldo
        'dsReporte.WriteXml("C:\Archivos de Programa\Agil\Schema4.xml", XmlWriteMode.WriteSchema)
        newrptRepAvisosxv.SetDataSource(dsReporte)
        CrystalReportViewer1.ReportSource = newrptRepAvisosxv

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class