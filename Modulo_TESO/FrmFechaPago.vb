Public Class FrmFechaPago
    Dim taSegui As New TesoreriaDSTableAdapters.Vw_CRED_SeguimientosTableAdapter
    Dim tSegui As New TesoreriaDS.Vw_CRED_SeguimientosDataTable
    Dim R As TesoreriaDS.Vw_CRED_SeguimientosRow
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckAll_CheckedChanged(Nothing, Nothing)
        TextAnexo.Clear()
        TextCliente.Clear()
    End Sub

    Private Sub TextAnexo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextAnexo.GotFocus
        TextAnexo.Clear()
    End Sub

    Private Sub TextAnexo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextAnexo.TextChanged
        VwFechaPagosBindingSource.Filter = "Anexo like '" & TextAnexo.Text & "%'"
    End Sub

    Private Sub TextCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextCliente.GotFocus
        TextCliente.Clear()
    End Sub

    Private Sub TextCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCliente.TextChanged
        VwFechaPagosBindingSource.Filter = "Cliente like '" & TextCliente.Text & "%'"
    End Sub

    Private Sub ButtFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtFecha.Click
        If DateFecha.Value.DayOfWeek = DayOfWeek.Sunday Or DateFecha.Value.DayOfWeek = DayOfWeek.Saturday Then
            MessageBox.Show("La fecha es Fin de semana", "Error en Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If DateFecha.Value > Date.Now Then
            MessageBox.Show("La fecha no puede ser futura", "Error en Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim diff As Integer = DateDiff(DateInterval.Day, DateFecha.Value, Date.Now)
        If diff > 2 And Date.Now.DayOfWeek <> DayOfWeek.Monday And UsuarioGlobal.ToLower <> "desarrollo" Then
            MessageBox.Show("Demasiado dias Transcurridos, Pedir autorizacion para registrar fecha de pago.", "Error en Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If diff > 3 And Date.Now.DayOfWeek = DayOfWeek.Monday And UsuarioGlobal.ToLower <> "desarrollo" Then
            MessageBox.Show("Demasiado dias Transcurridos, Favor de pedir autorizacion para registrar fecha de pago.", "Error en Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim fechaSTR As String = DateFecha.Value.ToString("yyyyMMdd")
        Dim ta As New TesoreriaDSTableAdapters.AnexosTableAdapter
        Dim Anexo As String = Mid(TextAnexoX.Text, 1, 5) & Mid(TextAnexoX.Text, 7, 4)

        If TxtTipar.Text = "F" Then
            Dim IvaCap As Decimal = ta.IvaTabla(Anexo)
            Dim IvaEq As Decimal = CDec(TxtIVAeq.Text)
            Dim IvaAI As Decimal = CDec(TxtIvaAmorIn.Text)
            IvaEq = IvaEq - (IvaCap + IvaAI)
            If IvaEq <= -1 Or IvaEq >= 1 Then
                MessageBox.Show("El IVA del equipo no conicide con el IVA de la Tabla, Favor de notificar a CONTABILIDAD.", "Error en Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        ta.UpdateFechaPago(fechaSTR, Anexo)
        If TxtFecAct.Text.Trim.Length <> 8 Then
            ta.UpdateFechaActivacion(fechaSTR, Anexo)
        End If
        CorreoConfirmacion()

        Form1_Load(Nothing, Nothing)

    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DateFechaAct.Value.DayOfWeek = DayOfWeek.Sunday Or DateFechaAct.Value.DayOfWeek = DayOfWeek.Saturday Then
            MessageBox.Show("La fecha es Fin de semana", "Error en Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If DateFechaAct.Value > Date.Now Then
            MessageBox.Show("La fecha no puede ser futura", "Error en Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim diff As Integer = DateDiff(DateInterval.Day, DateFechaAct.Value, Date.Now)
        If diff > 4 And Date.Now.DayOfWeek <> DayOfWeek.Monday Then
            MessageBox.Show("Demasiado dias Transcurridos, Pedir autorizacion para registrar fecha de Activación.", "Error en Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim Anexo As String = Mid(TextAnexoX.Text, 1, 5) & Mid(TextAnexoX.Text, 7, 4)
        Dim fechaSTR As String = DateFechaAct.Value.ToString("yyyyMMdd")
        Dim ta As New TesoreriaDSTableAdapters.AnexosTableAdapter
        ta.UpdateFechaActivacion(fechaSTR, Anexo)
        CorreoConfirmacion()
        Form1_Load(Nothing, Nothing)
    End Sub

    Private Sub CheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAll.CheckedChanged
        ButtFecha.Enabled = Not CheckAll.Checked
        Button1.Enabled = Not CheckAll.Checked
        If CheckAll.Checked = False Then
            Me.Vw_FechaPagosTableAdapter.Fill(Me.ProductionDataSet.Vw_FechaPagos)
            LbTot.Text = "Total por Dispersar"
            TxtTotal.Text = CDec(Me.Vw_FechaPagosTableAdapter.Total()).ToString("n2")
        Else
            Me.Vw_FechaPagosTableAdapter.FillByAll(Me.ProductionDataSet.Vw_FechaPagos)
            LbTot.Text = "Pendiente de liberar"
            TxtTotal.Text = CDec(Me.Vw_FechaPagosTableAdapter.TotalAll()).ToString("n2")
        End If
        TextAnexo.Clear()
        TextCliente.Clear()

    End Sub

    Sub CorreoConfirmacion()
        Dim Asunto As String = "Ministración liberada por Tesoreria (" & TextAnexoX.Text & ")  "
        Dim Mensaje As String
        Mensaje = "<table BORDER=1><tr><td><strong>Contrato</strong></td><td><strong>Cliente</strong></td><td><strong>Importe</strong></td><td><strong>Producto</strong></td></tr>"
        Mensaje += "<tr><td>" & VwFechaPagosBindingSource.Current("Anexo") & "</td>"
        Mensaje += "<td>" & VwFechaPagosBindingSource.Current("Cliente") & "</td>"
        Mensaje += "<td ALIGN=RIGHT>" & Val(VwFechaPagosBindingSource.Current("Monto Financiado")).ToString("n2") & "</td>"
        Mensaje += "<td>" & VwFechaPagosBindingSource.Current("Producto") & "</td>"
        Mensaje += "</tr>"
        Mensaje += "</table>"
        MandaCorreoFase(UsuarioGlobalCorreo, "MESA_CONTROL", Asunto, Mensaje)
        MandaCorreo(UsuarioGlobalCorreo, "ecacerest@finagil.com.mx", Asunto, Mensaje)
        taSegui.FillSeguimientoSinAnexo(tSegui, VwFechaPagosBindingSource.Current("NoCliente"))
        If tSegui.Rows.Count > 0 Then
            Asunto = "Cliente con Seguimientos sin asignar (" & TextAnexoX.Text & ") "
            Mensaje += "<BR>Este Cliente tiene seguimientos sin asignación de contrato<BR>"
            For Each R In tSegui.Rows
                Mensaje += "<BR>" & R.Compromiso & "<BR>"
            Next
            MandaCorreoUser(UsuarioGlobalCorreo, R.Analista, Asunto, Mensaje)
            MandaCorreo(UsuarioGlobalCorreo, "ecacerest@finagil.com.mx", Asunto, Mensaje)
        End If

    End Sub

End Class
