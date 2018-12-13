Public Class frmAltaLiquidezAutCRE
    Private Sub frmAltaLiquidezAutCRE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesLiqTableAdapter.Fill(Me.CreditoDS.ClientesLiq)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.EndEdit()
        Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ_Autorizacion)
    End Sub

    Private Sub Saldo_insolutoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Saldo_insolutoTextBox.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TasaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TasaTextBox.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("¿Etas seguro de aprobar la solicitud de " & ComboBox2.Text & "?", "Aprobar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If ClientesLiqBindingSource.Current("MontoFinanciado") > CDec(TaQUERY.ConfigDATO("PORC_FEGA_AV")) Then ' PASA A DIRECCION gENERAL

            Else ' CREDITO LO PASA
                ClientesLiqTableAdapter.UpdateEstatus("APROBADO", UsuarioGlobal, ClientesLiqBindingSource.Current("ID_SOLICITUD"))
                ModuloCRE.AltaLineaCreditoLIQUIDEZ(ClientesLiqBindingSource.Current("Cliente"), ClientesLiqBindingSource.Current("MontoFinanciado"), "Autorizado por Crédito")
                GeneraCorreoAUT()
                frmAltaLiquidezAutCRE_Load(Nothing, Nothing)
            End If

        End If
    End Sub
    Private Sub ClientesLiqBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ClientesLiqBindingSource.CurrentChanged
        If Not IsNothing(ClientesLiqBindingSource.Current) Then
            Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Fill(Me.PromocionDS.PROM_SolicitudesLIQ_Autorizacion, ClientesLiqBindingSource.Current("id_solicitud"))
            If PROM_SolicitudesLIQ_AutorizacionBindingSource.Count = 0 Then
                Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.AddNew()
                Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.Current("id_solicitud") = ClientesLiqBindingSource.Current("id_solicitud")
                Me.Validate()
                Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.EndEdit()
                Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ_Autorizacion)
                Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Fill(Me.PromocionDS.PROM_SolicitudesLIQ_Autorizacion, ClientesLiqBindingSource.Current("id_solicitud"))
            End If
            If TaQUERY.EsClienteFinagil(ClientesLiqBindingSource.Current("Cliente")) > 0 Then
                Cliente_finagilCheckBox.Checked = True
            Else
                Cliente_finagilCheckBox.Checked = False
            End If
            Saldo_insolutoTextBox.Text = CDec(TaQUERY.SaldoInsolutoTRA(ClientesLiqBindingSource.Current("Cliente"))).ToString("n2")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("¿Etas seguro de rechazar la solicitud de " & ComboBox2.Text & "?", "Rechazar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ClientesLiqTableAdapter.UpdateEstatus("RECHAZADO", UsuarioGlobal, ClientesLiqBindingSource.Current("ID_SOLICITUD"))
            GeneraCorreoREC()
            frmAltaLiquidezAutCRE_Load(Nothing, Nothing)
        End If
    End Sub

    Sub GeneraCorreoAUT()
        Dim Asunto As String = ""
        'para = "ecacerest@finagil.com.mx"
        Asunto = "Solicitud de Liquidez Inmediata Autorizada: " & ComboBox2.Text
        Dim Mensaje As String = ""

        Mensaje += "Cliente: " & ComboBox2.Text & "<br>"
        Mensaje += "Monto Financiado: " & ClientesLiqBindingSource.Current("MontoFinanciado") & "<br>"

        MandaCorreo(UsuarioGlobalCorreo, "ecacerest@finagil.com.mx", Asunto, Mensaje)
        MandaCorreo(UsuarioGlobalCorreo, UsuarioGlobalCorreo, Asunto, Mensaje)
        MandaCorreoUser(UsuarioGlobalCorreo, TaQUERY.SacaCorreoPromo(ClientesLiqBindingSource.Current("Cliente")), Asunto, Mensaje)

    End Sub

    Sub GeneraCorreoREC()
        Dim Asunto As String = ""
        'para = "ecacerest@finagil.com.mx"
        Asunto = "Solicitud de Liquidez Inmediata Rechazada: " & ComboBox2.Text
        Dim Mensaje As String = ""

        Mensaje += "Cliente: " & ComboBox2.Text & "<br>"
        Mensaje += "Monto Financiado: " & ClientesLiqBindingSource.Current("MontoFinanciado") & "<br>"

        MandaCorreo(UsuarioGlobalCorreo, "ecacerest@finagil.com.mx", Asunto, Mensaje)
        MandaCorreo(UsuarioGlobalCorreo, UsuarioGlobalCorreo, Asunto, Mensaje)
        MandaCorreoUser(UsuarioGlobalCorreo, TaQUERY.SacaCorreoPromo(ClientesLiqBindingSource.Current("Cliente")), Asunto, Mensaje)
    End Sub

End Class