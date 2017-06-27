Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmRelevantes
    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daRelev1 As New SqlDataAdapter(cm1)
        Dim daRelev2 As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()
        Dim drReporte As DataRow
        Dim drRelev As DataRow
        Dim dtReporte As New DataTable("Grales")

        ' Declaración de variables de datos

        Dim cFechaInicio As String
        Dim cFechaFinal As String
        Dim cTipo1 As String = "F"
      
        ' Declaración de variables de Crystal Reports

        Dim newrptRepoRele As New rptRelevantesC1()

        cFechaInicio = DTOC(dtpFechaIni.Value)
        cFechaFinal = DTOC(dtpFechaFin.Value)

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT CASE Tipo WHEN 'F' THEN 'Física' END AS TipoPersona, RTRIM(Descr) as Name, SUM(Importe) as Importe FROM Historia " & _
                           "INNER JOIN Anexos ON Historia.Anexo = Anexos.Anexo " & _
                           "INNER JOIN Clientes ON Anexos.Cliente = Clientes.Cliente " & _
                           "WHERE SubString(Fecha,1,6) = " & "'" & Mid(cFechaFinal, 1, 6) & "'" & " AND Tipo = " & "'" & cTipo1 & "'" & _
                           " GROUP BY Tipo, RTRIM(Descr) HAVING SUM(Importe) > 300000 UNION ALL SELECT Case Tipo WHEN 'E' THEN 'Física con actividad empresarial' " & _
                           "WHEN 'M' THEN 'Moral' END AS TipoPersona, RTRIM(Descr) as Name, SUM(Importe) as importe FROM Historia " & _
                           "INNER JOIN Anexos ON Historia.Anexo = Anexos.Anexo " & _
                           "INNER JOIN Clientes ON Anexos.Cliente = Clientes.Cliente " & _
                           "WHERE SubString(Fecha,1,6) = " & "'" & Mid(cFechaFinal, 1, 6) & "'" & " AND Tipo <> 'F' " & _
                           "GROUP BY Tipo, RTRIM(Descr) HAVING SUM(Importe) > 500000 ORDER BY TipoPersona, SUM(Importe) DESC"
            .Connection = cnAgil
        End With

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT CASE Tipo WHEN 'F' THEN 'Física' END AS TipoPersona, RTRIM(Descr) as Name, SUM(Importe) as Importe FROM Historia " & _
                           "INNER JOIN Avios ON Historia.Anexo = Avios.Anexo " & _
                           "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " & _
                           "WHERE SubString(Fecha,1,6) = " & "'" & Mid(cFechaFinal, 1, 6) & "'" & " AND Tipo = 'F'  AND Cheque NOT LIKE '%AVIO%' " & _
                           "GROUP BY Tipo, RTRIM(Descr) HAVING SUM(Importe) > 300000 UNION ALL SELECT distinct CASE Tipo WHEN 'E' THEN 'Física con actividad empresarial' " & _
                           "WHEN 'M' THEN 'Moral' END AS TipoPersona, RTRIM(Descr), SUM(Importe) FROM Historia " & _
                           "INNER JOIN Avios ON Historia.Anexo = Avios.Anexo " & _
                           "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " & _
                           "WHERE SubString(Fecha,1,6) = " & "'" & Mid(cFechaFinal, 1, 6) & "'" & " AND Tipo <> 'F'  AND Cheque NOT LIKE '%AVIO%' " & _
                           "GROUP BY Tipo, RTRIM(Descr), dbo.Avios.Ciclo HAVING SUM(Importe) > 500000 ORDER BY TipoPersona, SUM(Importe) DESC"
            .Connection = cnAgil
        End With
        daRelev1.Fill(dsAgil, "Criterio1A")
        daRelev2.Fill(dsAgil, "Criterio1B")

        ' Aquí creo la tabla Reporte que será la base del reporte

        dtReporte.Columns.Add("FechaIni", Type.GetType("System.String"))
        dtReporte.Columns.Add("FechaFin", Type.GetType("System.String"))
        dtReporte.Columns.Add("TipoPers", Type.GetType("System.String"))
        dtReporte.Columns.Add("Name", Type.GetType("System.String"))
        dtReporte.Columns.Add("PagoMes", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("TipoOp", Type.GetType("System.String"))
        dtReporte.Columns.Add("TipoCr", Type.GetType("System.String"))

        For Each drRelev In dsAgil.Tables("Criterio1A").Rows
            drReporte = dtReporte.NewRow()
            drReporte("FechaIni") = Mes(cFechaInicio)
            drReporte("FechaFin") = Mes(cFechaFinal)
            drReporte("TipoPers") = drRelev("TipoPersona")
            drReporte("Name") = drRelev("Name")
            drReporte("PagoMes") = drRelev("Importe")
            If drRelev("Importe") > 300000.0 Then
                drReporte("TipoOp") = "RELEVANTE"
            Else
                drReporte("TipoOp") = ""
            End If
            drReporte("TipoCr") = ""
            dtReporte.Rows.Add(drReporte)
        Next

        For Each drRelev In dsAgil.Tables("Criterio1B").Rows
            drReporte = dtReporte.NewRow()
            drReporte("FechaIni") = Mes(cFechaInicio)
            drReporte("FechaFin") = Mes(cFechaFinal)
            drReporte("TipoPers") = drRelev("TipoPersona")
            drReporte("Name") = drRelev("Name")
            drReporte("PagoMes") = drRelev("Importe")
            If drRelev("Importe") > 500000.0 Then
                drReporte("TipoOp") = "RELEVANTE"
            Else
                drReporte("TipoOp") = ""
            End If
            drReporte("TipoCr") = "Crédito de Avío"
            dtReporte.Rows.Add(drReporte)
        Next

        dsAgil.Tables.Remove("Criterio1A")
        dsAgil.Tables.Remove("Criterio1B")
        
        dsAgil.Tables.Add(dtReporte)

        ' Descomentar la siguiente línea en caso de que se deseara modificar el reporte rptRepoActi
        'dsAgil.WriteXml("C:\Files\Schema18.xml", XmlWriteMode.WriteSchema)

        newrptRepoRele.SetDataSource(dsAgil)
        CrystalReportViewer1.ReportSource = newrptRepoRele

        dtpFechaIni.Enabled = False
        dtpFechaFin.Enabled = False

    End Sub

    Private Sub btnProcesoI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesoI.Click
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim daMeses1 As New SqlDataAdapter(cm1)
        Dim daMeses2 As New SqlDataAdapter(cm2)
        Dim daMeses3 As New SqlDataAdapter(cm3)
        Dim dsAgil As New DataSet()
        Dim drReporte As DataRow
        Dim drInusual As DataRow
        Dim dtReporte As New DataTable("Grales")

        ' Declaración de variables de datos

        Dim cFechaInicio As String
        Dim cFechaFinal As String
        Dim cFechaInicio2 As String
        Dim cFechaInicio3 As String

        ' Declaración de variables de Crystal Reports

        Dim newrptRepoInus As New rptRepInusuales()

        cFechaInicio = DTOC(dtpFechaIni.Value)
        cFechaFinal = DTOC(dtpFechaFin.Value)

        cFechaInicio2 = DTOC(DateAdd(DateInterval.Month, -1, dtpFechaIni.Value))
        cFechaInicio3 = DTOC(DateAdd(DateInterval.Month, -2, dtpFechaIni.Value))

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT RTRIM(Descr) AS Name, SUBSTRING(Historia.Anexo,1,5)+'/'+SUBSTRING(Historia.Anexo,6,4) AS Contrato, ImpEq-IvaEq-Amorin AS MOI, SUM(Importe) AS Prepag FROM Historia " & _
                           "INNER JOIN Anexos ON Historia.Anexo = Anexos.Anexo " & _
                           "INNER JOIN Clientes ON Anexos.Cliente = Clientes.Cliente " & _
                           "WHERE Fecha >= " & "'" & cFechaInicio & "'" & " AND Fecha <= " & "'" & cFechaFinal & "'" & " AND Letra >= " & "'" & 888 & "'" & " AND Observa1 LIKE '%EQUIPO%' AND Observa1 NOT LIKE '%IVA%'" & _
                           "GROUP BY SUBSTRING(Historia.Anexo,1,5)+'/'+SUBSTRING(Historia.Anexo,6,4), RTRIM(Descr), ImpEq-IvaEq-Amorin HAVING(SUM(Importe) >= 250000) " & _
                           "ORDER BY SUBSTRING(Historia.Anexo,1,5)+'/'+SUBSTRING(Historia.Anexo,6,4), RTRIM(Descr), ImpEq-IvaEq-Amorin "
            .Connection = cnAgil
        End With

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT RTRIM(Descr) AS Name, SUBSTRING(Historia.Anexo,1,5)+'/'+SUBSTRING(Historia.Anexo,6,4) AS Contrato, ImpEq-IvaEq-Amorin AS MOI, SUM(Importe) AS Prepag FROM Historia " & _
                           "INNER JOIN Anexos ON Historia.Anexo = Anexos.Anexo " & _
                           "INNER JOIN Clientes ON Anexos.Cliente = Clientes.Cliente " & _
                           "WHERE Fecha >= " & "'" & cFechaInicio2 & "'" & " AND Fecha <= " & "'" & cFechaFinal & "'" & " AND Letra >= " & "'" & 888 & "'" & " AND Observa1 LIKE '%EQUIPO%' AND Observa1 NOT LIKE '%IVA%'" & _
                           "GROUP BY SUBSTRING(Historia.Anexo,1,5)+'/'+SUBSTRING(Historia.Anexo,6,4), RTRIM(Descr), ImpEq-IvaEq-Amorin HAVING(SUM(Importe) >= 250000) " & _
                           "ORDER BY SUBSTRING(Historia.Anexo,1,5)+'/'+SUBSTRING(Historia.Anexo,6,4), RTRIM(Descr), ImpEq-IvaEq-Amorin "
            .Connection = cnAgil
        End With

        With cm3
            .CommandType = CommandType.Text
            .CommandText = "SELECT RTRIM(Descr) AS Name, SUBSTRING(Historia.Anexo,1,5)+'/'+SUBSTRING(Historia.Anexo,6,4) AS Contrato, ImpEq-IvaEq-Amorin AS MOI, SUM(Importe) AS Prepag FROM Historia " & _
                           "INNER JOIN Anexos ON Historia.Anexo = Anexos.Anexo " & _
                           "INNER JOIN Clientes ON Anexos.Cliente = Clientes.Cliente " & _
                           "WHERE Fecha >= " & "'" & cFechaInicio3 & "'" & " AND Fecha <= " & "'" & cFechaFinal & "'" & " AND Letra >= " & "'" & 888 & "'" & " AND Observa1 LIKE '%EQUIPO%' AND Observa1 NOT LIKE '%IVA%'" & _
                           "GROUP BY SUBSTRING(Historia.Anexo,1,5)+'/'+SUBSTRING(Historia.Anexo,6,4), RTRIM(Descr), ImpEq-IvaEq-Amorin HAVING(SUM(Importe) >= 250000) " & _
                           "ORDER BY SUBSTRING(Historia.Anexo,1,5)+'/'+SUBSTRING(Historia.Anexo,6,4), RTRIM(Descr), ImpEq-IvaEq-Amorin "
            .Connection = cnAgil
        End With
        daMeses1.Fill(dsAgil, "Mes1")
        daMeses2.Fill(dsAgil, "Mes2")
        daMeses3.Fill(dsAgil, "Mes3")

        ' Aquí creo la tabla Reporte que será la base del reporte

        dtReporte.Columns.Add("FechaIni", Type.GetType("System.String"))
        dtReporte.Columns.Add("FechaFin", Type.GetType("System.String"))
        dtReporte.Columns.Add("Name", Type.GetType("System.String"))
        dtReporte.Columns.Add("Anexo", Type.GetType("System.String"))
        dtReporte.Columns.Add("ImpMOI", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("Prepago", Type.GetType("System.Decimal"))

        For Each drInusual In dsAgil.Tables("Mes1").Rows
            drReporte = dtReporte.NewRow()
            drReporte("FechaIni") = Mes(cFechaInicio)
            drReporte("FechaFin") = Mes(cFechaFinal)
            drReporte("Name") = drInusual("Name")
            drReporte("Anexo") = drInusual("Contrato")
            drReporte("ImpMOI") = drInusual("MOI")
            drReporte("Prepago") = drInusual("Prepag")
            dtReporte.Rows.Add(drReporte)
        Next

        For Each drInusual In dsAgil.Tables("Mes2").Rows
            drReporte = dtReporte.NewRow()
            drReporte("FechaIni") = Mes(cFechaInicio2)
            drReporte("FechaFin") = Mes(cFechaFinal)
            drReporte("Name") = drInusual("Name")
            drReporte("Anexo") = drInusual("Contrato")
            drReporte("ImpMOI") = drInusual("MOI")
            drReporte("Prepago") = drInusual("Prepag")
            dtReporte.Rows.Add(drReporte)
        Next

        For Each drInusual In dsAgil.Tables("Mes3").Rows
            drReporte = dtReporte.NewRow()
            drReporte("FechaIni") = Mes(cFechaInicio3)
            drReporte("FechaFin") = Mes(cFechaFinal)
            drReporte("Name") = drInusual("Name")
            drReporte("Anexo") = drInusual("Contrato")
            drReporte("ImpMOI") = drInusual("MOI")
            drReporte("Prepago") = drInusual("Prepag")
            dtReporte.Rows.Add(drReporte)
        Next
        dsAgil.Tables.Remove("Mes1")
        dsAgil.Tables.Remove("Mes2")
        dsAgil.Tables.Remove("Mes3")

        dsAgil.Tables.Add(dtReporte)

        ' Descomentar la siguiente línea en caso de que se deseara modificar el reporte rptRepoActi
        'dsAgil.WriteXml("C:\Files\Schema17.xml", XmlWriteMode.WriteSchema)

        newrptRepoInus.SetDataSource(dsAgil)
        CrystalReportViewer1.ReportSource = newrptRepoInus

        dtpFechaIni.Enabled = False
        dtpFechaFin.Enabled = False

    End Sub

    Private Sub btProcesa2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProcesa2.Click
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daRelev1 As New SqlDataAdapter(cm1)
        Dim daRelev2 As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()
        Dim drReporte As DataRow
        Dim drRelev As DataRow
        Dim dtReporte As New DataTable("Grales")

        ' Declaración de variables de datos

        Dim cFechaInicio As String
        Dim cFechaFinal As String
        Dim cTipo1 As String = "F"
        Dim nEquivalente As Decimal = 125000

        ' Declaración de variables de Crystal Reports

        Dim newrptRepoRele2 As New rptRelevantesC2()

        cFechaInicio = DTOC(dtpFechaIni.Value)
        cFechaFinal = DTOC(dtpFechaFin.Value)

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT CASE Tipo WHEN 'F' THEN 'Física' WHEN 'E' THEN 'Física con actividad empresarial' WHEN 'M' THEN 'Moral' END AS TipoPersona, " & _
                           "RTRIM(dbo.Clientes.Descr) AS Nombre, SUBSTRING(dbo.Historia.Fecha, 7, 2) + '/' + SUBSTRING(dbo.Historia.Fecha, 5, 2) + '/' + SUBSTRING(dbo.Historia.Fecha, 1, 4) AS Fecha2, dbo.Historia.Cheque, " & _
                           "SUM(dbo.Historia.Importe) AS Imp, dbo.Historia.Banco " & _
                           "FROM dbo.Historia INNER JOIN " & _
                           "dbo.Anexos ON dbo.Historia.Anexo = dbo.Anexos.Anexo INNER JOIN " & _
                           "dbo.Clientes ON dbo.Anexos.Cliente = dbo.Clientes.Cliente " & _
                           "WHERE  (LEFT(dbo.Historia.Fecha, 6) = LEFT('" & cFechaFinal & "', 6)) AND (dbo.Historia.Cheque NOT LIKE '%AVIO%') " & _
                           "GROUP BY dbo.Clientes.Tipo, RTRIM(dbo.Clientes.Descr), SUBSTRING(dbo.Historia.Fecha, 7, 2) + '/' + SUBSTRING(dbo.Historia.Fecha, 5, 2) + '/' + SUBSTRING(dbo.Historia.Fecha, 1, 4), dbo.Historia.Cheque, " & _
                           "dbo.Historia.Banco " & _
                           "HAVING (SUM(dbo.Historia.Importe) > " & nEquivalente & ") " & _
                           "ORDER BY dbo.Clientes.Tipo"
            .Connection = cnAgil
        End With

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT CASE WHEN Tipo = 'F' THEN 'Física' WHEN Tipo = 'E' THEN 'Física con actividad empresarial' WHEN Tipo = 'M' THEN 'Moral' ELSE '' END AS TipoPersona,  " & _
                           "RTRIM(dbo.Clientes.Descr) AS Nombre, SUBSTRING(dbo.Historia.Fecha, 7, 2) + '/' + SUBSTRING(dbo.Historia.Fecha, 5, 2) + '/' + SUBSTRING(dbo.Historia.Fecha, 1, 4) AS Fecha2, dbo.Historia.Cheque,  " & _
                           "SUM(dbo.Historia.Importe) AS Imp, dbo.Bancos.DescBanco " & _
                           "FROM dbo.Bancos INNER JOIN " & _
                           "dbo.Historia ON dbo.Bancos.Banco = dbo.Historia.Banco INNER JOIN " & _
                           "dbo.Clientes INNER JOIN " & _
                           "dbo.Vw_AviosDistinct ON dbo.Clientes.Cliente = dbo.Vw_AviosDistinct.Cliente ON dbo.Historia.Anexo = dbo.Vw_AviosDistinct.Anexo AND dbo.Historia.Anexo = dbo.Vw_AviosDistinct.Anexo " & _
                           "WHERE (LEFT(dbo.Historia.Fecha, 6) = LEFT('" & cFechaFinal & "', 6)) AND (dbo.Historia.Cheque NOT LIKE '%AVIO%') " & _
                           "GROUP BY dbo.Clientes.Tipo, RTRIM(dbo.Clientes.Descr), SUBSTRING(dbo.Historia.Fecha, 7, 2) + '/' + SUBSTRING(dbo.Historia.Fecha, 5, 2) + '/' + SUBSTRING(dbo.Historia.Fecha, 1, 4), dbo.Historia.Cheque,  " & _
                           "dbo.Bancos.DescBanco " & _
                           "HAVING (SUM(dbo.Historia.Importe) > " & nEquivalente & ") " & _
                           "ORDER BY dbo.Clientes.Tipo "
            .Connection = cnAgil
        End With
        daRelev1.Fill(dsAgil, "Criterio2A")
        daRelev2.Fill(dsAgil, "Criterio2B")

        ' Aquí creo la tabla Reporte que será la base del reporte

        dtReporte.Columns.Add("FechaIni", Type.GetType("System.String"))
        dtReporte.Columns.Add("FechaFin", Type.GetType("System.String"))
        dtReporte.Columns.Add("TipoPers", Type.GetType("System.String"))
        dtReporte.Columns.Add("Name", Type.GetType("System.String"))
        dtReporte.Columns.Add("Fecha", Type.GetType("System.String"))
        dtReporte.Columns.Add("Cheque", Type.GetType("System.String"))
        dtReporte.Columns.Add("Pago", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("Banco", Type.GetType("System.String"))
        dtReporte.Columns.Add("Tipoc", Type.GetType("System.String"))

        For Each drRelev In dsAgil.Tables("Criterio2A").Rows
            drReporte = dtReporte.NewRow()
            drReporte("FechaIni") = Mes(cFechaInicio)
            drReporte("FechaFin") = Mes(cFechaFinal)
            drReporte("TipoPers") = drRelev("TipoPersona")
            drReporte("Name") = drRelev("Nombre")
            drReporte("Fecha") = drRelev("Fecha2")
            drReporte("Cheque") = drRelev("Cheque")
            drReporte("Pago") = drRelev("Imp")
            Select Case drRelev("Banco")
                Case "00"
                    drReporte("Banco") = "FONDO RESERVA"
                Case "02"
                    drReporte("Banco") = "BANCOMER"
                Case "03"
                    drReporte("Banco") = "HSBC REF"
                Case "04"
                    drReporte("Banco") = "BANAMEX REF"
                Case "05"
                    drReporte("Banco") = "BANAMEX-NAFINSA"
                Case "06"
                    drReporte("Banco") = "BANAMEX"
                Case "07"
                    drReporte("Banco") = "BAJIO"
                Case "08"
                    drReporte("Banco") = "INVEX"
                Case "09"
                    drReporte("Banco") = "TRASPASOS"
                Case "10"
                    drReporte("Banco") = "BANORTE"
                Case "11"
                    drReporte("Banco") = "LINEA NAFIN"
                Case "14"
                    drReporte("Banco") = "HSBC"
            End Select
            drReporte("Tipoc") = ""
            dtReporte.Rows.Add(drReporte)
        Next

        For Each drRelev In dsAgil.Tables("Criterio2B").Rows
            drReporte = dtReporte.NewRow()
            drReporte("FechaIni") = Mes(cFechaInicio)
            drReporte("FechaFin") = Mes(cFechaFinal)
            drReporte("TipoPers") = drRelev("TipoPersona")
            drReporte("Name") = drRelev("Nombre")
            drReporte("Fecha") = drRelev("Fecha2")
            drReporte("Cheque") = drRelev("Cheque")
            drReporte("Pago") = drRelev("Imp")
            drReporte("Banco") = drRelev("DescBanco")
            drReporte("Tipoc") = "Crédito Avío"
            dtReporte.Rows.Add(drReporte)
        Next

        dsAgil.Tables.Remove("Criterio2A")
        dsAgil.Tables.Remove("Criterio2B")

        dsAgil.Tables.Add(dtReporte)

        ' Descomentar la siguiente línea en caso de que se deseara modificar el reporte rptRepoActi
        'dsAgil.WriteXml("C:\Files\Schema19.xml", XmlWriteMode.WriteSchema)

        newrptRepoRele2.SetDataSource(dsAgil)
        CrystalReportViewer1.ReportSource = newrptRepoRele2

        dtpFechaIni.Enabled = False
        dtpFechaFin.Enabled = False

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class