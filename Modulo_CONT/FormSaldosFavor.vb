Public Class FormSaldosFavor
    Private Sub FormSaldosFavor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesSaldoFavorTableAdapter.Fill(Me.ContaDS.ClientesSaldoFavor)
        TextDescuento.Text = "0.00"
    End Sub

    Private Sub ClientesSaldoFavorBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ClientesSaldoFavorBindingSource.CurrentChanged
        If Not IsNothing(Me.ClientesSaldoFavorBindingSource.Current()) Then
            Me.CONT_SaldosFavorTableAdapter.Fill(ContaDS.CONT_SaldosFavor, Me.ClientesSaldoFavorBindingSource.Current("Cliente"))
        Else
            ContaDS.CONT_SaldosFavor.Clear()
        End If
        If Not IsNothing(Me.CONTSaldosFavorBindingSource.Current()) Then
            TextSaldo.Text = Me.CONT_SaldosFavorTableAdapter.SaldoCliente(Me.ClientesSaldoFavorBindingSource.Current("Cliente"))
        Else
            TextSaldo.Text = "0.00"
        End If
        TextNotas.Clear()
    End Sub

    Private Sub TextDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextDescuento.KeyPress
        NumerosyDecimal(TextDescuento, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(TextDescuento.Text) Then
            MessageBox.Show("Descuento no válido", "Saldo a Favor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextDescuento.Focus()
            Exit Sub
        End If
        If Val(TextDescuento.Text) <= 0 Then
            MessageBox.Show("Descuento no válido", "Saldo a Favor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextDescuento.Focus()
            Exit Sub
        End If
        If Val(TextSaldo.Text) < Val(TextDescuento.Text) Then
            MessageBox.Show("Monto del descueto mayor al saldo", "Saldo a Favor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextDescuento.Focus()
            Exit Sub
        End If
        If TextNotas.Text = "" Then
            MessageBox.Show("Favor de agregar observaciones para la aplicación.", "Saldo a Favor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextNotas.Focus()
            Exit Sub
        End If

        Me.CONT_SaldosFavorTableAdapter.Insert("000000000", "", Val(TextDescuento.Text) * -1, UsuarioGlobal, Date.Now, Date.Now.ToString("yyyyMMdd"), Me.ClientesSaldoFavorBindingSource.Current("Cliente"))
        Me.CONT_SaldosFavorTableAdapter.Fill(ContaDS.CONT_SaldosFavor, Me.ClientesSaldoFavorBindingSource.Current("Cliente"))
        TextSaldo.Text = Me.CONT_SaldosFavorTableAdapter.SaldoCliente(Me.ClientesSaldoFavorBindingSource.Current("Cliente"))
        TextDescuento.Text = "0.00"
        TextNotas.Clear()
    End Sub

    Sub GeneraCorreo(Libera As Boolean)
        Dim Asunto As String = ""


        Asunto = "Aplicación de Saldo a Favor: " & ComboBox1.Text

        Dim Mensaje As String = ""

        Mensaje += "Cliente: " & ComboBox1.Text & "<br>"
        Mensaje += "Importe a aplicar: " & CDec(TextDescuento.Text).ToString("n2") & "<br>"
        Mensaje += "Solicitado por: " & UsuarioGlobal & "<br>"
        Mensaje += "Observaciones: " & textNotas.text & "<br>"

        MandaCorreo(UsuarioGlobalCorreo, TaQUERY.SacaCorreoPromo(Me.ClientesSaldoFavorBindingSource.Current("Cliente")), Asunto, Mensaje, "")
        MandaCorreoFase(UsuarioGlobalCorreo, "APLICA_PAGOS", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "COBRANZA_JUR", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", Asunto, Mensaje)
        MessageBox.Show("Correo Enviado ", "Envío de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class