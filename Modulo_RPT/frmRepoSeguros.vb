Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports Microsoft.VisualBasic

Public Class frmRepoSeguros
    Inherits System.Windows.Forms.Form
    'Dim dtReporte As New ReportesDS.dtReporteDataTable
    Dim cBase As String
    Dim ta As New ReportesDSTableAdapters.AnexosTableAdapter
    Dim ta2 As New ReportesDSTableAdapters.AviosTableAdapter
    Dim ta1 As New ReportesDSTableAdapters.TerminadosTableAdapter
    Dim r As ReportesDS.AnexosRow
    Dim t As New ReportesDS.AnexosDataTable
  
    Private Sub frmRepoSeguros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim t As New DataTable
        Dim r As DataRow
        t.Columns.Add("ID")
        t.Columns.Add("TIT")

        Dim Fecha As Date = Date.Now
        r = t.NewRow
        For x As Integer = 0 To 11
            Fecha = Fecha.AddDays(-1 * Fecha.Day)
            If Fecha >= "01/07/2019" Then
                r = t.NewRow
                r("ID") = Fecha.ToString("yyyyMMdd")
                r("TIT") = Mid(Fecha.ToString("yyyyMMM").ToUpper, 1, 7)
                t.Rows.Add(r)
            End If
        Next
        cbBase.DataSource = t
        cbBase.DisplayMember = t.Columns("TIT").ToString
        cbBase.ValueMember = t.Columns("ID").ToString
        cbBase.SelectedIndex = 0

    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Dim TaReest As New ReestructDSTableAdapters.REEST_AnexosBulletTableAdapter
        Dim Treest As New ReestructDS.REEST_AnexosBulletDataTable
        Dim Cont As Integer
        Dim Calcfini1 As frmCalcfiniAP
        Dim Calcfini2 As frmCalcfini
        Dim DB As String = My.Settings.BaseDatos
        Dim cFecha As String
        Dim dFecha As Date
        Dim cEdad As String
        Dim drReporte As ReportesDS.dtReporteRow
        Dim nIvaDiferido As Decimal
        Dim nIvaCap As Decimal
        Dim nBonifica As Decimal
        Dim nRentadep As Decimal
        Dim nTotalAd As Decimal
        Dim cReportTitle As String
        Dim newrptReporte As New rptSegurosCierre()
        DB = cbBase.Text
        Cursor.Current = Cursors.WaitCursor
        ta.Connection.ConnectionString = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
        ta1.Connection.ConnectionString = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
        ta2.Connection.ConnectionString = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
        Dim ConnAux As String = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
        cFecha = cbBase.SelectedValue
        dFecha = CTOD(cFecha)
        ReportesDS1.dtReporte.Clear()

        Try
            ta.Fill(t, cFecha)
        Catch ex As Exception
            MessageBox.Show("Error en la base de datos " & DB & vbCrLf & ex.Message, "Error ")
        End Try

        For Each r In t.Rows
            TaReest.FillByBullet(Treest, r.Anexo)
            If Treest.Rows.Count > 0 Then
                Continue For
            End If
            Label2.Text = r.Descr
            Label2.Update()
            cEdad = DameEdad(r.FechaNac.ToString("yyyyMMdd"), cFecha)

            drReporte = ReportesDS1.dtReporte.NewdtReporteRow
            drReporte.FechaNac = r.FechaNac.Date
            drReporte.Nombre = r.NombreCliente
            drReporte.Paterno = r.ApellidoPaterno
            drReporte.Materno = r.ApellidoMaterno
            drReporte.Nombre2 = ""
            drReporte.CURP = r.CURP
            drReporte.Sexo = r.Genero
            drReporte("Contrato") = Mid(r.Anexo, 1, 5) & "/" & Mid(r.Anexo, 6, 4)
            drReporte("NameCte") = Trim(r.Descr)
            drReporte("Edad") = cEdad
            drReporte("SaldoEq") = 0 'ta.SaldoEquipo(r.Anexo)
            drReporte("SaldoSeg") = 0 'ta.SaldoSeguro(r.Anexo)
            drReporte("SaldoOt") = 0 'ta.SaldoOtros(r.Anexo)
            drReporte("FechaCon") = r.Fechacon
            drReporte("FechaVecn") = ta.fechaVenc(r.Anexo)

            nIvaDiferido = 0
            nBonifica = 0
            drReporte("IvaCap") = 0 'nIvaCap
            drReporte("Rentasven") = 0 'ta.RentasVen(r.Anexo)
            drReporte("OpCompIva") = 0 'r.impopc
            drReporte("RtasDepIva") = 0 'nRentadep * -1
            drReporte("SaldoAvio") = 0

            If r.Tipar = "B" Then ' FULL SERVICE
                nTotalAd = 0
            End If
            If r.Tipar = "P" Then
                Calcfini1 = New frmCalcfiniAP(r.Anexo.Substring(0, 5) & "/" & r.Anexo.Substring(5, 4))
                Calcfini1.Hide()
                Calcfini1.CompletoFRM = False
                Calcfini1.ConnAux = ConnAux
                Calcfini1.DateTimePicker1.Value = dFecha
                Calcfini1.Show()
                Calcfini1.btnProcesar.PerformClick()
                Calcfini1.btnCalcular.PerformClick()
                nTotalAd = Calcfini1.txtImportePago.Text
                Calcfini1.Close()
            Else
                Calcfini2 = New frmCalcfini(r.Anexo.Substring(0, 5) & "/" & r.Anexo.Substring(5, 4))
                Calcfini2.ConnAux = ConnAux
                Calcfini2.DateTimePicker1.Value = dFecha
                Calcfini2.CompletoFRM = False
                Calcfini2.Show()
                Calcfini2.btnProcesar.PerformClick()
                Calcfini2.btnCalcular.PerformClick()
                nTotalAd = Calcfini2.txtImportePago.Text
                Calcfini2.Close()
            End If
            Cont += 1
            If Cont >= 5 Then
                ClearMemory()
                Cont = 0
            End If

            drReporte("TotalDeuda") = nTotalAd
            drReporte("Pago") = r.Mensu
            drReporte("RFC") = r.RFC
            drReporte("Calle") = r.Calle
            drReporte("Colonia") = r.Colonia
            drReporte("Copos") = r.Copos
            drReporte("Estado") = r.Estado
            drReporte("Sucursal") = r.Nombre_Sucursal
            ReportesDS1.dtReporte.Rows.Add(drReporte)
            'ta.UpdateQuery(r.Anexo, "")
        Next

        Dim t2 As New ReportesDS.AviosDataTable
        Dim r2 As ReportesDS.AviosRow

        '  Llena informacion de Avios
        ta2.Fill(t2, cFecha)

        For Each r2 In t2.Rows

            ' Si el tipo de cliente es persona física con actividad empresarial (E), debo cambiarlo a
            ' M para que lo agrupe con las personas morales ya que ambos forman la cartera de bienes 
            ' al Comercio


            Label2.Text = r2.Descr
            Label2.Update()
            cEdad = DameEdad(r2.FechaNac.ToString("yyyyMMdd"), cFecha)
            'registro del reporte
            drReporte = ReportesDS1.dtReporte.NewRow()
            drReporte.FechaNac = r2.FechaNac.Date
            drReporte.Nombre = r2.NombreCliente
            drReporte.Paterno = r2.ApellidoPaterno
            drReporte.Materno = r2.ApellidoMaterno
            drReporte.Nombre2 = ""
            drReporte.CURP = r2.CURP
            drReporte.Sexo = r2.Genero
            drReporte("Contrato") = r2.Anexo
            drReporte("NameCte") = r2.Descr
            drReporte("Edad") = cEdad
            drReporte("SaldoEq") = 0
            drReporte("SaldoSeg") = 0
            drReporte("SaldoOt") = 0
            drReporte("IvaCap") = 0
            drReporte("Rentasven") = 0
            drReporte("OpCompIva") = 0
            drReporte("RtasDepIva") = 0
            drReporte("SaldoAvio") = r2.Saldo
            drReporte("TotalDeuda") = r2.Saldo
            drReporte("Pago") = r2.Saldo
            drReporte("RFC") = r2.RFC
            drReporte("Calle") = r2.Calle
            drReporte("Colonia") = r2.Colonia
            drReporte("Copos") = r2.Copos
            drReporte("Estado") = r2.Estado
            drReporte("FechaCon") = r2.FechaAutorizacion
            drReporte("FechaVecn") = r2.FechaTerminacion
            drReporte("Sucursal") = r2.Nombre_Sucursal
            ReportesDS1.dtReporte.Rows.Add(drReporte)
            'ta.UpdateQuery(r2.Anexo, r2.Ciclo)
        Next

        Dim t1 As New ReportesDS.TerminadosDataTable
        Dim r1 As ReportesDS.TerminadosRow

        ' Llena informacion de Contratos Terminados con Adeudos
        ta1.Fill(t1)

        For Each r1 In t1.Rows
            Label2.Text = r1.Descr
            Label2.Update()
            cEdad = DameEdad(r1.FechaNac.ToString("yyyyMMdd"), cFecha)

            drReporte = ReportesDS1.dtReporte.NewRow()
            drReporte("Contrato") = r1.Anexo
            drReporte("NameCte") = r1.Descr
            drReporte("Edad") = "T " & cEdad
            drReporte("SaldoEq") = 0
            drReporte("SaldoSeg") = 0
            drReporte("SaldoOt") = 0
            drReporte("IvaCap") = 0
            drReporte("Rentasven") = r1.Deuda
            drReporte("OpCompIva") = r1.Opcion + r1.IvaOpcion
            drReporte("RtasDepIva") = r1.ImpDG + r1.IvaDG
            drReporte("SaldoAvio") = 0
            drReporte("TotalDeuda") = r1.Deuda + r1.Opcion + r1.IvaOpcion + r1.ImpDG + r1.IvaDG
            drReporte("Pago") = 0
            drReporte("RFC") = r1.RFC
            drReporte("Calle") = r1.Calle
            drReporte("Colonia") = r1.Colonia
            drReporte("Copos") = r1.Copos
            drReporte("Estado") = r1.Estado
            drReporte("FechaCon") = r1.Fechacon
            drReporte("FechaVecn") = ta.fechaVenc(r1.Anexo)
            drReporte("Sucursal") = r1.Nombre_Sucursal
            ReportesDS1.dtReporte.Rows.Add(drReporte)
            'ta.UpdateQuery(r1.Anexo, "")
        Next

        Try

            'Descomentar la siguiente línea en caso de que se deseara modificar el reporte rptRepSaldo

            cReportTitle = "REPORTE DE SEGUROS AL CIERRE DEL MES"

            ' Genero el reporte en Crystal Reports

            newrptReporte.SummaryInfo.ReportTitle = cReportTitle
            newrptReporte.SetDataSource(ReportesDS1)
            CrystalReportViewer2.ReportSource = newrptReporte

        Catch eException As Exception

            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

    End Sub

    Public Function DameEdad(ByVal cFechaNac As String, ByVal cFechaHoy As String) As String

        Dim Mes As Integer
        Dim Mes2 As Integer
        Dim Dia As Integer
        Dim Dia2 As Integer
        Dim nAño2 As Integer
        Dim nEAños As Integer
        Dim nEMeses As Integer
        Dim nEDias As Integer
        Dim nAño1 As Integer
  
        Mes = Month(CTOD(cFechaNac))
        Mes2 = Month(CTOD(cFechaHoy))
        Dia = Day(CTOD(cFechaNac))
        Dia2 = Day(CTOD(cFechaHoy))
        nAño1 = Year(CTOD(cFechaNac))
        nAño2 = Year(CTOD(cFechaHoy))

        If Mes2 >= Mes Then
            nEAños = nAño2 - nAño1
        Else
            nEAños = nAño2 - nAño1 - 1
        End If

        If Dia2 >= Dia Then
            nEDias = Dia2 - Dia
            nEMeses = Mes2 - Mes
        Else
            nEDias = 30 - Dia + Dia2
            nEMeses = Mes2 - Mes
        End If
        If nEMeses < 0 Then
            nEMeses = 12 + nEMeses
        End If

        If nEMeses = 1 And nEDias = 1 Then
            DameEdad = nEAños.ToString & " años " & nEMeses.ToString & " mes " & nEDias.ToString & " día"
        ElseIf nEMeses = 1 And nEDias > 1 Then
            DameEdad = nEAños.ToString & " años " & nEMeses.ToString & " mes " & nEDias.ToString & " días"
        ElseIf nEMeses > 1 And nEDias = 1 Then
            DameEdad = nEAños.ToString & " años " & nEMeses.ToString & " meses " & nEDias.ToString & " día"
        ElseIf nEMeses = 0 And nEDias = 0 Then
            DameEdad = nEAños.ToString & " años "
        ElseIf nEMeses = 1 And nEDias = 0 Then
            DameEdad = nEAños.ToString & " años " & nEMeses.ToString & " mes"
        ElseIf nEMeses = 0 And nEDias = 1 Then
            DameEdad = nEAños.ToString & " años " & nEDias.ToString & " día"
        ElseIf nEMeses = 0 And nEDias > 1 Then
            DameEdad = nEAños.ToString & " años " & nEDias.ToString & " días"
        ElseIf nEMeses > 1 And nEDias = 0 Then
            DameEdad = nEAños.ToString & " años " & nEMeses.ToString & " meses"
        ElseIf nEMeses > 1 And nEDias > 1 Then
            DameEdad = nEAños.ToString & " años " & nEMeses.ToString & " meses " & nEDias.ToString & " días"
        End If

    End Function

End Class
