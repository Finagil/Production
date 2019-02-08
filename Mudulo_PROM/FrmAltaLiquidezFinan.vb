﻿Imports System.IO
Public Class FrmAltaLiquidezFinan
    Public Consulta As Boolean = False
    Public ID_sol As Integer
    Public GeneroCli As String
    Dim rCli As PromocionDS.ClientesRow

    Private Sub FrmAltaLiquidezFinan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tCli As New PromocionDS.ClientesDataTable
        Dim taProd As New PromocionDSTableAdapters.ClientesTableAdapter
        Dim Plazos As New PromocionDSTableAdapters.LI_PlazosTableAdapter
        Dim tPlazos As New PromocionDS.LI_PlazosDataTable
        Dim rPlazos As PromocionDS.LI_PlazosRow
        Me.PROM_SolicitudesLIQTableAdapter.FillByID(Me.PromocionDS.PROM_SolicitudesLIQ, ID_sol)
        Me.PROM_SolicitudesLIQ_ImportesTableAdapter.Fill(Me.PromocionDS.PROM_SolicitudesLIQ_Importes, ID_sol, "Ingreso")
        Me.PROM_SolicitudesLIQ_ImportesTableAdapter.Fill(Me.PromocionDS1.PROM_SolicitudesLIQ_Importes, ID_sol, "Egreso")
        taProd.Fill(tCli, Me.PROMSolicitudesLIQBindingSource.Current("Cliente"))
        rCli = tCli.Rows.Item(0)
        Plazos.FillByPlazo(tPlazos, Me.PROMSolicitudesLIQBindingSource.Current("Plazo"))
        rPlazos = tPlazos.Rows(0)

        Select Case Me.PROMSolicitudesLIQBindingSource.Current("Periodicidad").ToString
            Case "Semanal"
                TxtNumAmort.Text = rPlazos.Semanas
            Case "Catorcenal"
                TxtNumAmort.Text = rPlazos.Catorcenas
            Case "Quincenal"
                TxtNumAmort.Text = rPlazos.Quincenas
            Case "Mensual"
                TxtNumAmort.Text = rPlazos.Meses
        End Select
        Label9.Text += " (" & Me.PROMSolicitudesLIQBindingSource.Current("Periodicidad").ToString & ")"
        Label10.Text += " (" & Me.PROMSolicitudesLIQBindingSource.Current("Periodicidad").ToString & ")"
        PagoPasivosTextBox.Text = CDec(Me.PROMSolicitudesLIQBindingSource.Current("PagoPasivos")).ToString("n2")
        Dim TotaIng As Decimal = IIf(IsNumeric(SalarioNetoTextBox.Text), SalarioNetoTextBox.Text, 0)
        TotaIng += IIf(IsNumeric(IngresosAdicionalesTextBox.Text), IngresosAdicionalesTextBox.Text, 0)
        txtTotalIngresosMensuales.Text = TotaIng.ToString("n2")
        If Consulta Then
            For Each ctrl As Control In Me.Controls
                ctrl.Enabled = False
            Next
        End If
    End Sub

    Function GuardarDatos() As Boolean
        Me.PROMSolicitudesLIQBindingSource.Current("ClavesBC") = CmbClaves.Text
        If Not IsNumeric(TxtPagofin.Text) Then
            MessageBox.Show("Pago Finagil no válido.", "Error de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPagofin.Focus()
            Return False
            Exit Function
        End If
        Try
            Me.PROMSolicitudesLIQBindingSource.EndEdit()
            Me.PROM_SolicitudesLIQTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ)

            Me.PROMSolicitudesLIQImportesBindingSource.EndEdit()
            Me.PROM_SolicitudesLIQ_ImportesTableAdapter.Update(Me.PromocionDS.PROM_SolicitudesLIQ_Importes)

            Me.PROMSolicitudesLIQImportesBindingSource1.EndEdit()
            Me.PROM_SolicitudesLIQ_ImportesTableAdapter.Update(Me.PromocionDS1.PROM_SolicitudesLIQ_Importes)

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al guardar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If GuardarDatos() = True Then
            Try
                Dim Ingresos As Decimal = CDec(SalarioNetoTextBox.Text) + CDec(IngresosAdicionalesTextBox.Text)
                txtTotalIngresosMensuales.Text = (CDec(SalarioNetoTextBox.Text) + CDec(IngresosAdicionalesTextBox.Text)).ToString("n2")
                Dim Finagil, Antiguedad As Decimal
                Dim Egresos As Decimal = CDec(PagoPasivosTextBox.Text)

                Finagil = Me.PROMSolicitudesLIQBindingSource.Current("PagoFinagil")
                Antiguedad = DateDiff(DateInterval.Year, Me.PROMSolicitudesLIQBindingSource.Current("FechaIngreso"), Date.Now.Date)
                If Antiguedad < 2 Then
                    MessageBox.Show("El cliente no cumple la antigüedad necesaria.", "RECHAZADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'For Each i As DataGridViewRow In GridIngresos.Rows
                '    Ingresos += i.Cells(1).Value
                'Next
                'For Each i As DataGridViewRow In GridPagosBC.Rows
                '    Egresos += i.Cells(1).Value
                'Next
                'Select Case Me.PROMSolicitudesLIQBindingSource.Current("Periodicidad").ToString
                '    Case "Semanal"
                '        Egresos = Egresos / 4
                '        Ingresos = Ingresos / 4
                '        Me.PROMSolicitudesLIQBindingSource.Current("PagoPasivos") = CDec(PasivosTextBox.Text) / 4
                '    Case "Catorcenal", "Quincenal"
                '        Egresos = Egresos / 2
                '        Ingresos = Ingresos / 2
                '        Me.PROMSolicitudesLIQBindingSource.Current("PagoPasivos") = CDec(PasivosTextBox.Text) / 2
                '    Case "Mensual"
                'End Select
                PagoPasivosTextBox.Text = CDec(Me.PROMSolicitudesLIQBindingSource.Current("PagoPasivos")).ToString("n2")
                Dim PorcEGRE As Decimal = Egresos / Ingresos
                Dim PorcFINAgil As Decimal = Finagil / Ingresos
                Dim PorcLIBRE As Decimal = (Ingresos - Egresos - Finagil) / Ingresos
                Dim RCD As Decimal = PorcEGRE + PorcFINAgil



                If (RCD <= 0.3 And Antiguedad >= 2 And Antiguedad <= 5) Or (RCD <= 0.35 And Antiguedad > 5) Then
                    Select Case CmbClaves.SelectedIndex
                        Case 0, 1 ' sin Claves
                            Select Case CmbExpe.SelectedIndex
                                Case 0, 1 ' Bueno y regular
                                    Me.PROMSolicitudesLIQBindingSource.Current("Estatus") = "APROBADO"
                                Case 2 'Malo
                                    Me.PROMSolicitudesLIQBindingSource.Current("Estatus") = "A CREDITO"
                            End Select
                        Case 2 ' con Claves <> Comunicacion
                            Me.PROMSolicitudesLIQBindingSource.Current("Estatus") = "A CREDITO"
                    End Select
                Else
                    Me.PROMSolicitudesLIQBindingSource.Current("Estatus") = "A CREDITO"
                End If

                Me.PROMSolicitudesLIQBindingSource.Current("RCD") = RCD
                Me.PROMSolicitudesLIQBindingSource.EndEdit()
                Me.PROM_SolicitudesLIQTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub GridIngresos_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs)
        Me.PROMSolicitudesLIQImportesBindingSource.Current("Tipo") = "Ingreso"
        Me.PROMSolicitudesLIQImportesBindingSource.Current("id_solicitud") = Me.PROMSolicitudesLIQBindingSource.Current("id_solicitud")
    End Sub

    Private Sub GridPagosBC_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs)
        Me.PROMSolicitudesLIQImportesBindingSource1.Current("Tipo") = "Egreso"
        Me.PROMSolicitudesLIQImportesBindingSource1.Current("id_solicitud") = Me.PROMSolicitudesLIQBindingSource.Current("id_solicitud")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.PROMSolicitudesLIQBindingSource.Current("procesado") = 1
        Me.PROMSolicitudesLIQBindingSource.Current("UsuarioCredito") = UsuarioGlobal
        Me.PROMSolicitudesLIQBindingSource.EndEdit()
        Me.PROM_SolicitudesLIQTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ)
        If Me.PROMSolicitudesLIQBindingSource.Current("Estatus") = "APROBADO" Then
            Dim f As New frmAltaLiquidezAut
            f.ID_Sol2 = Me.PROMSolicitudesLIQBindingSource.Current("Id_Solicitud").ToString
            f.Antiguedad = DateDiff(DateInterval.Year, Me.PROMSolicitudesLIQBindingSource.Current("FechaIngreso"), Date.Now.Date)
            f.Cliente = Me.PROMSolicitudesLIQBindingSource.Current("Cliente").ToString
            If f.ShowDialog Then
            End If
            ModuloCRE.AltaLineaCreditoLIQUIDEZ(PROMSolicitudesLIQBindingSource.Current("Cliente"), PROMSolicitudesLIQBindingSource.Current("MontoFinanciado"), "Autorización Automática")
            GeneraCorreoAUT()
            MessageBox.Show("Linea de credito autorizada por " & TextBox1.Text & ", ya puedes generar el contrato.", "Crédito Aprobado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Favor de pasar esta solicitud al área de crédito", "Solicitud para análisis de crédito.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GeneraCorreoCRE()
        End If
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub TxtPagofin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPagofin.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub SalarioNetoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SalarioNetoTextBox.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub IngresosAdicionalesTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IngresosAdicionalesTextBox.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub PasivosTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasivosTextBox.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Sub ImprimeSol()
        Dim taAltaLiquidez As New PromocionDSTableAdapters.VW__SolLiqTableAdapter
        taAltaLiquidez.Fill(Me.PromocionDS.VW__SolLiq, Me.PROMSolicitudesLIQBindingSource.Current("Id_Solicitud"))

        Dim genero As String = ""
        Dim regimen As String = ""
        Dim empleoExt As String = ""
        Dim nivel As String = ""
        Dim residencia As String = ""
        Dim otrosIngresos As String = ""
        Dim aportacionesAdic As String = ""


        genero = validaNull(GeneroCli.Replace("Masculino", "F ( )  M (X)").Replace("Femenino", "F (X)  M ( )"))
        If Me.PROMSolicitudesLIQBindingSource.Current("RegimenConyugal") = "SEPARACION DE BIENES" Then
            regimen = "( )  Sociedad Conyugal    (X)  Separación de Bienes    ( )  N/A"
        ElseIf Me.PROMSolicitudesLIQBindingSource.Current("RegimenConyugal") = "SOCIEDAD CONYUGAL" Then
            regimen = "(X)  Sociedad Conyugal    ( )  Separación de Bienes    ( )  N/A"
        ElseIf Me.PROMSolicitudesLIQBindingSource.Current("RegimenConyugal") = "N/A" Then
            regimen = "( )  Sociedad Conyugal    ( )  Separación de Bienes    (X)  N/A"
        End If
        empleoExt = IIf(Me.PROMSolicitudesLIQBindingSource.Current("CargoPublico") = True, "Si (X)    No ( )", "Si ( )    No (X)")
        nivel = validaNull(Me.PROMSolicitudesLIQBindingSource.Current("Nivel").Replace("Local", "Local  (X)    Estatal  ( )    Federal  ( )").Replace("Estatal", "Local  ( )    Estatal  (X)    Federal  ( )").Replace("Federal", "Local  ( )    Estatal  ( )    Federal  (X)"))
        residencia = validaNull(Me.PROMSolicitudesLIQBindingSource.Current("ResidenciaExtranjero").ToString.Replace("True", "Si  (X)    No  ( )").Replace("False", "Si  ( )    No  (X)"))
        otrosIngresos = validaNull(Me.PROMSolicitudesLIQBindingSource.Current("OtrosIngresos").ToString.Replace("True", "Si  (X)    No  ( )").Replace("False", "Si  ( )    No  (X)"))
        aportacionesAdic = validaNull(Me.PROMSolicitudesLIQBindingSource.Current("AportacionesAdicionales").ToString.Replace("True", "Si  (X)    No  ( )").Replace("False", "Si  ( )    No  (X)"))


        Dim rpt As New rptAltaLiquidezTodo
        rpt.SetDataSource(Me.PromocionDS)
        rpt.SetParameterValue("var_genero", genero, "rptAltaLiquidezAnverso")
        rpt.SetParameterValue("var_regimen", regimen, "rptAltaLiquidezAnverso")
        rpt.SetParameterValue("var_empleoExt", empleoExt, "rptAltaLiquidezAnverso")
        rpt.SetParameterValue("var_nivel", nivel, "rptAltaLiquidezAnverso")
        rpt.SetParameterValue("var_residencia", residencia, "rptAltaLiquidezAnverso")
        rpt.SetParameterValue("var_otrosIngresos", otrosIngresos, "rptAltaLiquidezAnverso")
        rpt.SetParameterValue("var_aportacionesAdic", aportacionesAdic, "rptAltaLiquidezAnverso")

        frmRPTAltaLiquidez.CrystalReportViewer1.ReportSource = rpt
        frmRPTAltaLiquidez.Show()
    End Sub

    Public Function validaNull(valor As Object)
        If String.IsNullOrEmpty(valor) Then
            Return ""
            Exit Function
        Else
            Return valor
            Exit Function
        End If
    End Function

    Sub GeneraCorreoCRE()
        Dim Asunto As String = ""
        'para = "ecacerest@finagil.com.mx"
        Asunto = "Solicitud de Liquidez Inmediata para Análisis de Crédito: " & rCli.Descr
        Dim Mensaje As String = ""

        Mensaje += "Cliente: " & rCli.Descr & "<br>"
        Mensaje += "Monto Solicitado: " & CDec(Me.PROMSolicitudesLIQBindingSource.Current("MontoFinanciado")).ToString("n2") & "<br>"

        MandaCorreoFase(UsuarioGlobalCorreo, "ACREDITOLIQ", Asunto, Mensaje)
        MandaCorreo(UsuarioGlobalCorreo, UsuarioGlobalCorreo, Asunto, Mensaje)

    End Sub

    Sub GeneraCorreoAUT()
        Dim Antiguedad As Integer = DateDiff(DateInterval.Year, PROMSolicitudesLIQBindingSource.Current("FechaIngreso"), Date.Now.Date)
        Dim Asunto As String = ""
        Dim Archivo As String = GeneraDocAutorizacion(PROMSolicitudesLIQBindingSource.Current("ID_SOLICITUD"), Antiguedad)
        Asunto = "Solicitud de Liquidez Inmediata Autorizada: " & rCli.Descr
        Dim Mensaje As String = ""

        Mensaje += "Cliente: " & rCli.Descr & "<br>"
        Mensaje += "Monto Financiado: " & CDec(Me.PROMSolicitudesLIQBindingSource.Current("MontoFinanciado")).ToString("n2") & "<br>"

        MandaCorreoFase(UsuarioGlobalCorreo, "AUTOMATICLIQ", Asunto, Mensaje, Archivo)
        MandaCorreo(UsuarioGlobalCorreo, UsuarioGlobalCorreo, Asunto, Mensaje, Archivo)

    End Sub

    Function GeneraDocAutorizacion(ID_Sol2 As Integer, Antiguedad As String) As String
        Cursor.Current = Cursors.WaitCursor
        Dim Archivo As String = My.Settings.RutaTMP & "Autoriza" & ID_Sol2 & ".Pdf"
        Dim Archivo2 As String = "Autoriza" & ID_Sol2 & ".Pdf"
        Dim reporte As New rptAltaLiquidezAutorizacion
        Dim ta As New PromocionDSTableAdapters.AutorizacionRPTTableAdapter
        ta.Fill(Me.PromocionDS.AutorizacionRPT, ID_Sol2)

        reporte.SetDataSource(Me.PromocionDS)
        reporte.SetParameterValue("var_antiguedad", Antiguedad)
        reporte.SetParameterValue("Autorizo", "")
        reporte.SetParameterValue("AreaAutorizo", "DIRECCION GENERAL")
        reporte.SetParameterValue("Firma", "Autorización Automática")
        reporte.SetParameterValue("Analista", "")
        reporte.SetParameterValue("FirmaAnalista", "Autorización Automática")
        reporte.SetParameterValue("FirmaPromo", Encriptar(UsuarioGlobal & Date.Now.ToString))
        Try
            File.Delete(Archivo)
            reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Archivo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Cursor.Current = Cursors.Default
        Return Archivo2
    End Function
End Class