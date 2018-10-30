Public Class FrmAltaLiquidezFinan
    Public ID_sol As Integer

    Private Sub FrmAltaLiquidezFinan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Plazos As New PromocionDSTableAdapters.LI_PlazosTableAdapter
        Dim tPlazos As New PromocionDS.LI_PlazosDataTable
        Dim rPlazos As PromocionDS.LI_PlazosRow

        Me.PROM_SolicitudesLIQTableAdapter.FillByID(Me.PromocionDS.PROM_SolicitudesLIQ, ID_sol)
        Me.PROM_SolicitudesLIQ_ImportesTableAdapter.Fill(Me.PromocionDS.PROM_SolicitudesLIQ_Importes, ID_sol, "Ingreso")
        Me.PROM_SolicitudesLIQ_ImportesTableAdapter.Fill(Me.PromocionDS1.PROM_SolicitudesLIQ_Importes, ID_sol, "Egreso")
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
        PagoPasivosTextBox.Text = Me.PROMSolicitudesLIQBindingSource.Current("PagoPasivos").ToString
        txtTotalIngresosMensuales.Text = (CDec(SalarioNetoTextBox.Text) + CDec(IngresosAdicionalesTextBox.Text)).ToString
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
                txtTotalIngresosMensuales.Text = (CDec(SalarioNetoTextBox.Text) + CDec(IngresosAdicionalesTextBox.Text)).ToString
                Dim Finagil, Antiguedad As Decimal
                Dim Egresos As Decimal = CDec(PasivosTextBox.Text)

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
                Select Case Me.PROMSolicitudesLIQBindingSource.Current("Periodicidad").ToString
                    Case "Semanal"
                        Egresos = Egresos / 4
                        Ingresos = Ingresos / 4
                        Me.PROMSolicitudesLIQBindingSource.Current("PagoPasivos") = CDec(PasivosTextBox.Text) / 4
                    Case "Catorcenal", "Quincenal"
                        Egresos = Egresos / 2
                        Ingresos = Ingresos / 2
                        Me.PROMSolicitudesLIQBindingSource.Current("PagoPasivos") = CDec(PasivosTextBox.Text) / 2
                    Case "Mensual"
                End Select
                PagoPasivosTextBox.Text = Me.PROMSolicitudesLIQBindingSource.Current("PagoPasivos").ToString
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
        Me.PROMSolicitudesLIQBindingSource.EndEdit()
        Me.PROM_SolicitudesLIQTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ)
        If Me.PROMSolicitudesLIQBindingSource.Current("Estatus") = "APROBADO" Then
            MessageBox.Show("Linea de credito autorizada por " & TextBox1.Text & ", ya puedes generar el contrato.", "Crédito Aprobado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim f As New frmAltaLiquidezAut
            f.ID_Sol2 = Me.PROMSolicitudesLIQBindingSource.Current("Id_Solicitud").ToString
            f.Antiguedad = DateDiff(DateInterval.Year, Me.PROMSolicitudesLIQBindingSource.Current("FechaIngreso"), Date.Now.Date)
            f.Show()
        Else
            MessageBox.Show("Favor de pasar esta solicitud al area de crédito", "Solicitud para análisis de crédito.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.DialogResult = DialogResult.OK
    End Sub
End Class