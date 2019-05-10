Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports Microsoft.VisualBasic

Public Class frmRepoSeguros
    Inherits System.Windows.Forms.Form
    'Dim dtReporte As New ReportesDS.dtReporteDataTable
    Dim cBase As String
    Dim ta As New ReportesDSTableAdapters.AnexosTableAdapter
    Dim r As ReportesDS.AnexosRow
    Dim t As New ReportesDS.AnexosDataTable
  
    Private Sub frmRepoSeguros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim t As New DataTable
        Dim r As DataRow
        t.Columns.Add("ID")
        t.Columns.Add("TIT")

        Dim Fecha As Date = Date.Now
        r = t.NewRow
        r("ID") = Date.Now.ToString("yyyyMMdd")
        r("TIT") = "A la Fecha"
        t.Rows.Add(r)

        For x As Integer = 0 To 11
            Fecha = Fecha.AddDays(-1 * Fecha.Day)
            If Fecha >= "01/12/2018" Then
                r = t.NewRow
                r("ID") = Fecha.ToString("yyyyMMdd")
                r("TIT") = Mid(Fecha.ToString("yyyyMMM").ToUpper, 1, 7)
                t.Rows.Add(r)
            End If
        Next
        cbBase.DataSource = t
        cbBase.DisplayMember = t.Columns("TIT").ToString
        cbBase.ValueMember = t.Columns("ID").ToString
        cbBase.SelectedIndex = 1

    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        ' Este programa debe tomar todos los contratos activos con fecha de contratación menor o igual a la
        ' fecha de proceso.  También debe tomar la tabla de amortización de los seguros y Otros adeudos 

        ' Adicionalmente deberá traer todas las facturas no pagadas de los contratos activos con fecha de
        ' contratación menor o igual a la fecha de proceso.

        Dim DB As String = My.Settings.BaseDatos
        Dim cFecha1 As String
        Dim cFecha As String
        Dim cEdad As String
        Dim drReporte As ReportesDS.dtReporteRow
        Dim nIvaDiferido As Decimal
        Dim nIvaCap As Decimal
        Dim nBonifica As Decimal
        Dim nRentadep As Decimal
        Dim nTotalAd As Decimal
        Dim cReportTitle As String
        Dim newrptReporte As New rptSegurosCierre()
        cFecha = DTOC(dtpProcesar.Value)
        If cbBase.SelectedIndex <> 0 Then DB = cbBase.Text
        Cursor.Current = Cursors.WaitCursor

        If cbBase.Text = "A la Fecha" Then
            ta.Connection.ConnectionString = "Server=" & My.Settings.ServidorPROD & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
        Else
            ta.Connection.ConnectionString = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
        End If
        ReportesDS1.dtReporte.Clear()

        Try
            ta.Fill(t, cFecha)
        Catch ex As Exception
            MessageBox.Show("Error en la base de datos " & DB, "Error ")
        End Try



        For Each r In t.Rows
            cFecha1 = "19" & Mid(r.Rfc, 5, 6)
            Label2.Text = r.Descr
            Label2.Update()

            If r.Tipo <> "M" And r.SegVida = "S" Then

                cEdad = DameEdad(cFecha1, cFecha)


                drReporte = ReportesDS1.dtReporte.NewdtReporteRow
                drReporte("Contrato") = Mid(r.Anexo, 1, 5) & "/" & Mid(r.Anexo, 6, 4)
                drReporte("NameCte") = Trim(r.Descr)
                drReporte("Edad") = cEdad
                drReporte("SaldoEq") = ta.SaldoEquipo(r.Anexo)
                drReporte("SaldoSeg") = ta.SaldoSeguro(r.Anexo)
                drReporte("SaldoOt") = ta.SaldoOtros(r.Anexo)
                drReporte("FechaCon") = r.Fechacon
                drReporte("FechaVecn") = ta.fechaVenc(r.Anexo)

                nIvaDiferido = 0
                If r.Fechacon >= "20020301" And r.IvaEq > 0 Then
                    nIvaDiferido = Round(drReporte("SaldoEq") * r.Porieq / 100, 2)
                End If

                nBonifica = 0
                If r.Fechacon >= "20020901" And r.ImpRd > 0 And r.Rtasd = 0 Then
                    nBonifica = Round(ta.SaldoEquipo(r.Anexo) * ((r.ImpRd + r.IvaRD) / r.mtofin), 2)
                End If

                If r.Tipar = "F" Then
                    nIvaCap = nIvaDiferido - nBonifica
                Else
                    nIvaCap = nIvaDiferido
                End If

                drReporte("IvaCap") = nIvaCap
                drReporte("Rentasven") = ta.RentasVen(r.Anexo)
                drReporte("OpCompIva") = r.impopc
                If r.Tipar = "F" Then
                    nRentadep = r.depg
                ElseIf r.Tipar = "R" Then
                    nRentadep = (r.depg) * -1
                Else
                    nRentadep = r.depg + (nBonifica) * -1
                End If

                drReporte("RtasDepIva") = nRentadep * -1
                drReporte("SaldoAvio") = 0
                nTotalAd = (drReporte("SaldoEq") + drReporte("SaldoSeg") + ta.SaldoOtros(r.Anexo) + nIvaCap + ta.RentasVen(r.Anexo) + r.impopc) - nRentadep
                
                drReporte("TotalDeuda") = nTotalAd
                drReporte("Pago") = r.Mensu
                drReporte("RFC") = r.Rfc
                drReporte("Calle") = r.Calle
                drReporte("Colonia") = r.Colonia
                drReporte("Copos") = r.Copos
                drReporte("Estado") = r.Estado
                ReportesDS1.dtReporte.Rows.Add(drReporte)
            End If
        Next

        Dim ta2 As New ReportesDSTableAdapters.AviosTableAdapter
        Dim t2 As New ReportesDS.AviosDataTable
        Dim r2 As ReportesDS.AviosRow

        '  Llena informacion de Avios

        ta2.Fill(t2, cFecha)

        For Each r2 In t2.Rows

            ' Si el tipo de cliente es persona física con actividad empresarial (E), debo cambiarlo a
            ' M para que lo agrupe con las personas morales ya que ambos forman la cartera de bienes 
            ' al Comercio

            If r2.SeguroVida >= 0 Then

                cFecha1 = "19" & Mid(r2.rfc, 5, 6)
                Label2.Text = r2.Descr
                Label2.Update()
                cEdad = DameEdad(cFecha1, cFecha)
                'registro del reporte
                drReporte = ReportesDS1.dtReporte.NewRow()
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
                drReporte("RFC") = r2.rfc
                drReporte("Calle") = r2.calle
                drReporte("Colonia") = r2.colonia
                drReporte("Copos") = r2.Copos
                drReporte("Estado") = r2.Estado
                drReporte("FechaCon") = r2.FechaAutorizacion
                drReporte("FechaVecn") = r2.FechaTerminacion
                ReportesDS1.dtReporte.Rows.Add(drReporte)

            End If
        Next

        Dim ta1 As New ReportesDSTableAdapters.TerminadosTableAdapter
        Dim t1 As New ReportesDS.TerminadosDataTable
        Dim r1 As ReportesDS.TerminadosRow

        ' Llena informacion de Contratos Terminados con Adeudos
        ta1.Fill(t1)

        For Each r1 In t1.Rows

            ' Si el tipo de cliente es persona física con actividad empresarial (E), debo cambiarlo a
            ' M para que lo agrupe con las personas morales ya que ambos forman la cartera de bienes 
            ' al Comercio

            If r1.Tipo <> "M" And r1.SegVida = "S" Then

                cFecha1 = "19" & Mid(r1.RFC, 5, 6)
                Label2.Text = r1.Descr
                Label2.Update()
                cEdad = DameEdad(cFecha1, cFecha)
                'registro del reporte
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
                drReporte("RtasDepIva") = r1.Impdg + r1.IvaDG
                drReporte("SaldoAvio") = 0
                drReporte("TotalDeuda") = r1.Deuda + r1.Opcion + r1.IvaOpcion + r1.Impdg + r1.IvaDG
                drReporte("Pago") = 0
                drReporte("RFC") = r1.RFC
                drReporte("Calle") = r1.Calle
                drReporte("Colonia") = r1.Colonia
                drReporte("Copos") = r1.Copos
                drReporte("Estado") = r1.Estado
                drReporte("FechaCon") = r1.Fechacon
                drReporte("FechaVecn") = ta.fechaVenc(r1.Anexo)
                ReportesDS1.dtReporte.Rows.Add(drReporte)

            End If

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
