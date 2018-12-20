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
            If ClientesLiqBindingSource.Current("MontoFinanciado") > CDec(TaQUERY.ConfigDATO("LIQ_MONTO_CRE")) Then ' PASA A DIRECCION gENERAL
                Dim NotaDG As String = InputBox("Favor de agregar cometario para Dirección Gneral", "Comentario DG", "Comentario")
                ClientesLiqTableAdapter.UpdateEstatus("gbello", UsuarioGlobal, NotaDG, ClientesLiqBindingSource.Current("ID_SOLICITUD"))
                GeneraCorreoDG()
                MessageBox.Show("Se paso a Dirección General", "Dirección Genral", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmAltaLiquidezAutCRE_Load(Nothing, Nothing)
            Else ' CREDITO LO PASA
                ClientesLiqTableAdapter.UpdateEstatus("APROBADO", UsuarioGlobal, "", ClientesLiqBindingSource.Current("ID_SOLICITUD"))
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
            Dim NotaDG As String = InputBox("Favor de agregar cometario para Dirección Gneral", "Comentario DG", "Comentario")
            ClientesLiqTableAdapter.UpdateEstatus("RECHAZADO", UsuarioGlobal, "", ClientesLiqBindingSource.Current("ID_SOLICITUD"))
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
        Mensaje += "Monto Financiado: " & CDec(ClientesLiqBindingSource.Current("MontoFinanciado")).ToString("n2") & "<br>"

        MandaCorreo(UsuarioGlobalCorreo, "ecacerest@finagil.com.mx", Asunto, Mensaje)
        MandaCorreo(UsuarioGlobalCorreo, UsuarioGlobalCorreo, Asunto, Mensaje)
        MandaCorreoUser(UsuarioGlobalCorreo, TaQUERY.SacaCorreoPromo(ClientesLiqBindingSource.Current("Cliente")), Asunto, Mensaje)
    End Sub

    Sub GeneraCorreoDG()
        Dim Asunto As String = ""
        'para = "ecacerest@finagil.com.mx"
        Asunto = "Solicitud de Liquidez Inmediata para Autorización: " & ComboBox2.Text
        Dim Mensaje As String = ""

        Mensaje += "Cliente: " & ComboBox2.Text & "<br>"
        Mensaje += "Monto Financiado: " & CDec(ClientesLiqBindingSource.Current("MontoFinanciado")).ToString("n2") & "<br>"
        Mensaje += "<A HREF='http://finagil.com.mx/WEBtasas/232db951-DGLQ.aspx?User=gbello&ID=0'>Liga para Autorización.</A>"

        MandaCorreo(UsuarioGlobalCorreo, "ecacerest@finagil.com.mx", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobal, "DG", Asunto, Mensaje)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim NotaDG As String = InputBox("Favor de agregar cometario para Dirección Gneral", "Comentario DG", "Comentario")
        ClientesLiqTableAdapter.UpdateEstatus("gbello", UsuarioGlobal, NotaDG, ClientesLiqBindingSource.Current("ID_SOLICITUD"))
        GeneraCorreoDG()
        MessageBox.Show("Se paso a Dirección General", "Dirección Genral", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frmAltaLiquidezAutCRE_Load(Nothing, Nothing)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f As New FrmAltaLiquidezFinan
        f.Consulta = True
        f.ID_sol = ClientesLiqBindingSource.Current("ID_SOLICITUD")
        f.GeneroCli = ClientesLiqBindingSource.Current("Genero")
        If f.ShowDialog Then
        End If

    End Sub
End Class