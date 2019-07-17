Public Class FrmAlertasAnexo
    Public cAnexo As String
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextLE.KeyPress
        NumerosEnteros(sender, e)
    End Sub

    Private Sub FrmAlertasAnexo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = cAnexo
        Me.GEN_NotificacionesAnexosTableAdapter.Fill(PromocionDS.GEN_NotificacionesAnexos, cAnexo)
        Me.Vw_ZPromedioDiasVencTableAdapter.Fill(PromocionDS.Vw_ZPromedioDiasVenc, cAnexo)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        GENNotificacionesAnexosBindingSource.AddNew()
        GENNotificacionesAnexosBindingSource.Current("Anexo") = cAnexo
        GENNotificacionesAnexosBindingSource.Current("usuario") = UsuarioGlobal
        GENNotificacionesAnexosBindingSource.Current("Fecha") = Date.Now
        GENNotificacionesAnexosBindingSource.Current("Mensaje") = ""
        GENNotificacionesAnexosBindingSource.Current("CorreosAdicionales") = ""
        GENNotificacionesAnexosBindingSource.Current("LetraExacta") = 0
        GENNotificacionesAnexosBindingSource.Current("LetraRestante") = 0
        GENNotificacionesAnexosBindingSource.Current("id_notificacion") = -1
        GENNotificacionesAnexosBindingSource.EndEdit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not IsNothing(GENNotificacionesAnexosBindingSource.Current) Then
            Try
                If MessageBox.Show("¿Desea borrar el registro?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Me.GEN_NotificacionesAnexosTableAdapter.BorraNotificacion(GENNotificacionesAnexosBindingSource.Current("id_notificacion"))
                    Me.GEN_NotificacionesAnexosTableAdapter.Fill(PromocionDS.GEN_NotificacionesAnexos, cAnexo)
                    Button1.Enabled = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Valida() = True Then
                Me.GENNotificacionesAnexosBindingSource.EndEdit()
                Me.PromocionDS.GEN_NotificacionesAnexos.GetChanges()
                Me.GEN_NotificacionesAnexosTableAdapter.Update(Me.PromocionDS.GEN_NotificacionesAnexos)
                MessageBox.Show("Datos Guardados", "Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Valida() As Boolean
        Valida = False
        If CInt(TextLE.Text) <= 0 Then
            MessageBox.Show("Numero de letras invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If
        If CInt(TextLE.Text) <= CInt(TextFacturadas.Text) And CInt(TextLE.Text) > 0 Then
            MessageBox.Show("la letra excata debe ser mayor a las facturadas ", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If
        If CInt(TextLE.Text) > CInt(TextTletras.Text) And CInt(TextLE.Text) > 0 Then
            MessageBox.Show("la letra excata NO debe ser mayor al total de letras", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If
        If TextMensaje.Text.Length <= 0 Then
            MessageBox.Show("El mensaje no puede ir vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If
        If TextCorreos.Text.Length > 0 Then
            Dim cad As String() = TextCorreos.Text.Split(";")
            For x As Integer = 0 To cad.Length - 1
                If validar_Mail(cad(x)) = False Then
                    MessageBox.Show("Correo invalido: " & cad(x), "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                End If
            Next
        End If
        Return True
    End Function
End Class