Public Class FrmCalculadoraRDC
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Ingresos As Decimal = CDec(SalarioNetoTextBox.Text) + CDec(IngresosAdicionalesTextBox.Text)
            txtTotalIngresosMensuales.Text = (CDec(SalarioNetoTextBox.Text) + CDec(IngresosAdicionalesTextBox.Text)).ToString("n2")
            Dim Antiguedad As Decimal
            Dim Finagil As Decimal = CDec(TxtPagofin.Text)
            Dim Egresos As Decimal = CDec(PagoPasivosTextBox.Text)
            If Finagil <= 0 Then
                MessageBox.Show("Pago Finagil no valido.", "Pago Finagil", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Antiguedad = DateDiff(DateInterval.Year, DtpFechaIngreso.Value, Date.Now.Date)
            If Antiguedad < 2 Then
                MessageBox.Show("El cliente no cumple la antigüedad necesaria.", "RECHAZADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CmbClaves.SelectedIndex < 0 Or CmbExpe.SelectedIndex < 0 Or CmboAtrasos.SelectedIndex < 0 Then
                MessageBox.Show("Falta información de Buro.", "Buro de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim RCD As Decimal = CalculaRDC(Ingresos, Egresos, Finagil)
            If (RCD <= 0.3 And Antiguedad >= 2 And Antiguedad <= 5) Or (RCD <= 0.35 And Antiguedad > 5) Then
                Select Case CmbClaves.SelectedIndex
                    Case 0, 1 ' sin Claves
                        Select Case CmbExpe.SelectedIndex
                            Case 0, 1 ' Bueno y regular
                                TextBox4.Text = "APROBADO"
                            Case 2 'Malo
                                TextBox4.Text = "A CREDITO"
                        End Select
                    Case 2 ' con Claves <> Comunicacion
                        TextBox4.Text = "A CREDITO"
                    Case Else
                        TextBox4.Text = "RECHAZADO"
                End Select
            Else
                TextBox4.Text = "A CREDITO"
            End If

            TextBox6.Text = RCD.ToString("n2")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

End Class