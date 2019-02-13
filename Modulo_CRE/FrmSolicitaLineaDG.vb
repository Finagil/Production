Public Class FrmSolicitaLineaDG
    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 3 Then
            Me.ClientesConLineaBindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
        Else
            Me.ClientesConLineaBindingSource.Filter = ""
        End If
    End Sub

    Private Sub FrmSolicitaLineaDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CRED_SolicitudLineaDGTableAdapter.Fill(Me.CreditoDS.CRED_SolicitudLineaDG)
        Me.ClientesConLineaTableAdapter.Fill(Me.CreditoDS.ClientesConLinea, "")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim r As CreditoDS.CRED_SolicitudLineaDGRow
        r = Me.CreditoDS.CRED_SolicitudLineaDG.NewCRED_SolicitudLineaDGRow
        r.Autoriza1 = "DG"
        r.Autoriza2 = ""
        r.Anexo = Me.ClientesConLineaBindingSource.Current("Solicitud")
        r.Ciclo = ""
        r.Cliente = Me.ClientesConLineaBindingSource.Current("Cliente")
        r.Tipo = "LineaCredito"
        r.Usuario = UsuarioGlobal
        r.Autorizacion1 = False
        r.Autorizacion2 = True
        r.Importe = 0
        r.Notas = ""
        r.Fecha = Date.Now
        Me.CreditoDS.CRED_SolicitudLineaDG.AddCRED_SolicitudLineaDGRow(r)
        GroupBox1.Enabled = True
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        GroupBox1.Enabled = False
        Me.CreditoDS.CRED_SolicitudLineaDG.Clear()
    End Sub

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        If Val(TextImporte.Text) <= 0 Then
            MessageBox.Show("Importe No valido", "Error Importe", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TextNotas.Text.Length <= 0 Then
            MessageBox.Show("Debe poner comentarios para Dirección General.", "Error Observaciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.CREDSolicitudLineaDGBindingSource.EndEdit()
        Me.CreditoDS.CRED_SolicitudLineaDG.GetChanges()
        Me.CRED_SolicitudLineaDGTableAdapter.Update(Me.CreditoDS.CRED_SolicitudLineaDG)
        GeneraCorreo()
        MessageBox.Show("Solicitud enviada a Dirección General.", "Correo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Dispose()
    End Sub

    Sub GeneraCorreo()
        Dim Asunto As String = "Solicitud de Linea de Credito Direccion General: " & Me.ClientesConLineaBindingSource.Current("Descr")
        Dim Mensaje As String = ""
        Mensaje += "Cliente: " & Me.ClientesConLineaBindingSource.Current("Descr") & "<br>"
        Mensaje += "Monto de la Linea: " & CDec(Me.CREDSolicitudLineaDGBindingSource.Current("Importe")).ToString("N2") & "<br>"
        Mensaje += "Observaciones: " & Me.CREDSolicitudLineaDGBindingSource.Current("Notas") & "<br>"
        'MandaCorreoPROMO(TaQUERY.SacaCorreoPromo(Me.ClientesConLineaBindingSource.Current("Cliente")), Asunto, Mensaje, True, False)
        MandaCorreoFase(UsuarioGlobalCorreo, "CREDITO", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "OPERACIONES", Asunto, Mensaje)

        Mensaje += "<A HREF='http://finagil.com.mx/WEBtasas/951db299-SLCDG.aspx?ID=" & Me.CREDSolicitudLineaDGBindingSource.Current("id_SolicitudLineaDG") & "'>Liga para Autorización.</A>"
        MandaCorreoFase(UsuarioGlobalCorreo, "DG", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", Asunto, Mensaje)
    End Sub

    Private Sub TextImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextImporte.KeyPress
        NumerosyDecimal(sender, e)
    End Sub
End Class