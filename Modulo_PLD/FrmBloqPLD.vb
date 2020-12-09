Public Class FrmBloqPLD

    Private Sub FrmBloqPLD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PLD_Bloqueo_ClientesTableAdapter.Caducar()
        Me.UsuariosFinagilTableAdapter.FillByDepto(Me.SeguridadDS.UsuariosFinagil, "CREDITO")
        UsuariosFinagilBindingSource.Filter = "NOMBRE not in ('GUILLERMO','CARLOS ALBERTO','CRISTINA','KARLA','MARIA DEL REFUGIO')"
        Me.ClientesTableAdapter.Fill(Me.PLD_DS.Clientes)
        ComboClientes_SelectedIndexChanged(Nothing, Nothing)
        PLDBloqueoClientesBindingSource_CurrentChanged(Nothing, Nothing)
    End Sub

    Private Sub ComboClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbClientes.SelectedIndexChanged
        If CmbClientes.SelectedIndex >= 0 Then
            Me.PLD_Bloqueo_ClientesTableAdapter.Fill(Me.PLD_DS.PLD_Bloqueo_Clientes, CmbClientes.SelectedValue)
            If Me.PLD_DS.PLD_Bloqueo_Clientes.Rows.Count <= 0 Then
                GroupPLD.Enabled = False
            Else
                CmbPLD.SelectedIndex = CmbPLD.Items.Count - 1
                PLDBloqueoClientesBindingSource_CurrentChanged(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub BunAddAuto_Click(sender As Object, e As EventArgs) Handles BunAddAuto.Click
        If Me.PLD_Bloqueo_ClientesTableAdapter.EnValidacion(CmbClientes.SelectedValue) Then
            MessageBox.Show("No se puede agregar la autporización, exsisten datos en validación", "Autorizaciones PLD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.PLD_Bloqueo_ClientesTableAdapter.Autorizadas(CmbClientes.SelectedValue) Then
            MessageBox.Show("No se puede agregar la autporización, exsisten datos autorizados y vigentes", "Autorizaciones PLD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.PLD_Bloqueo_ClientesTableAdapter.InsertaDatos(CmbClientes.SelectedValue, False, False, False, False, False, False, False, False, False, Date.Now, Date.Now, "", "En Validación", "", False, ClientesBindingSource.Current("Anexo"), Date.Now)
        ComboClientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PLDBloqueoClientesBindingSource.EndEdit()
        Me.PLD_Bloqueo_ClientesTableAdapter.Update(PLD_DS.PLD_Bloqueo_Clientes)
        Me.PLD_Bloqueo_ClientesTableAdapter.ActualizarFechaMod(CmbPLD.SelectedValue, CmbPLD.SelectedValue)
        ComboClientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnAutorizar.Click
        Me.PLDBloqueoClientesBindingSource.EndEdit()
        Me.PLD_Bloqueo_ClientesTableAdapter.Update(PLD_DS.PLD_Bloqueo_Clientes)
        Me.PLD_Bloqueo_ClientesTableAdapter.Autorizar(CmbPLD.SelectedValue, CmbPLD.SelectedValue)
        Me.PLD_Bloqueo_ClientesTableAdapter.LiberaMinistracion("#" & UsuarioGlobal, True, ClientesBindingSource.Current("Anexo"))
        MandaCorreoPLD("Autorizacion")
        ComboClientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Sub MandaCorreoPLD(Tipo As String)
        Dim De As String = "PLD@finagil.com.mx"
        Dim Para As String = TxtPromoMail.Text.Trim & ";" & TxtAnalistaCorreo.Text & ";" & TxtmailSUB.Text
        Dim Asunto As String = ""
        Dim Mensaje As String = ""
        Select Case Tipo.ToUpper
            Case "AUTORIZACION"
                Asunto = "Autorización de PLD - Cliente: " & CmbClientes.Text.Trim
                Mensaje = "El cliente " & CmbClientes.Text.Trim & " cuenta con su expediente completo de PLD, por lo que puede seguir el proceso de formalización de contrato.<br>"
                Mensaje += "<BR>Esta autorización expira el día " & DPTvigencia.Value.ToShortDateString & ".<br>"
                Mensaje += "<BR>Comentarios: <BR>" & TxtComent.Text.Trim
            Case "EXPEDIENTE"
                Asunto = "Expediente de PLD incompleto - Cliente: " & CmbClientes.Text.Trim
                Mensaje = "<BR>Favor de completar el expediente del cliente  " & CmbClientes.Text.Trim & ", ya que no cuenta con la documentación necesaria.<br>"
                Mensaje += "<BR>Comentarios: <BR>" & TxtComent.Text.Trim
        End Select

        Dim sUC As String = ClientesBindingSource.Current("sucursal")
        MandaCorreo(De, Para, Asunto, Mensaje)
        MandaCorreoFase(De, sUC, Asunto, Mensaje)
        MandaCorreoFase(De, "MESA_CONTROL", Asunto, Mensaje)
        MandaCorreoFase(De, "PLD", Asunto, Mensaje)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        MandaCorreoPLD("EXPEDIENTE")
        MessageBox.Show("Mensaje Enviado", "Correo PLD", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TxtTipo_TextChanged(sender As Object, e As EventArgs) Handles TxtTipo.TextChanged
        If TxtTipo.Text = "M" Then
            CkINE.Enabled = False
            CkCurp.Enabled = False
            CkActa.Enabled = True
            Ckpoderes.Enabled = True
        Else
            CkINE.Enabled = True
            CkCurp.Enabled = True
            CkActa.Enabled = False
            Ckpoderes.Enabled = False
        End If
    End Sub

    Private Sub PLDBloqueoClientesBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles PLDBloqueoClientesBindingSource.CurrentChanged
        If TxtStatus.Text = "En Validación" Then
            GroupPLD.Enabled = True
            LbDias.Text = ""
        ElseIf TxtStatus.Text = "Autorizada" Then
            Dim dias As Integer
            dias = DateDiff(DateInterval.Day, Date.Now.Date, DPTvigencia.Value.Date)
            GroupPLD.Enabled = False
            LbDias.Text = "Quedan " & dias & " dias de vigencia."
        ElseIf TxtStatus.Text = "Caducada" Then
            LbDias.Text = "Autorización CADUCADA"
            GroupPLD.Enabled = False
        Else
            GroupPLD.Enabled = False
            LbDias.Text = ""
        End If
    End Sub


End Class