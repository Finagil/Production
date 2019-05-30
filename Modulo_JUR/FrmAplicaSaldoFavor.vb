Public Class FrmAplicaSaldoFavor
    Dim ta As New JuridicoDSTableAdapters.VwSaldosFavorTableAdapter
    Dim tx As New ContaDSTableAdapters.CONT_SaldosFavorTableAdapter

    Private Sub FrmAplicaSaldoFavor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InstrumentoMonetarioTableAdapter.Fill(Me.GeneralDS.InstrumentoMonetario)
        Me.VwSaldosFavorTableAdapter.Fill(Me.JuridicoDS.VwSaldosFavor)
    End Sub

    Private Sub VwSaldosFavorBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles VwSaldosFavorBindingSource.CurrentChanged
        If Not IsNothing(VwSaldosFavorBindingSource.Current()) Then
            TextIntrMone.Text = ta.SacaInstrumentoMon(VwSaldosFavorBindingSource.Current("Anexo"))
            TextComenta.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("¿Esta seguro de solictar la aplicación?", "Aplicacion de Saldo a Favor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            GeneraCorreo()
            tx.ProcesarSaldoFavor(VwSaldosFavorBindingSource.Current("Anexo"), "", 0)
            tx.Insert(VwSaldosFavorBindingSource.Current("Anexo"), "", VwSaldosFavorBindingSource.Current("Importe") * -1,
                      UsuarioGlobal, Date.Now, FECHA_APLICACION.ToString("yyyyMMdd"), "00000", TextIntrMone.Text, True)
            Me.VwSaldosFavorTableAdapter.Fill(Me.JuridicoDS.VwSaldosFavor)
        End If
    End Sub

    Sub GeneraCorreo()
        Dim Asunto As String = "Aplicar Saldo a Favor: " & VwSaldosFavorBindingSource.Current("Descr")
        Dim Mensaje As String
        Mensaje = "Cliente: " & VwSaldosFavorBindingSource.Current("Descr")
        Mensaje += "<br>Anexo: " & VwSaldosFavorBindingSource.Current("AnexoCon")
        Mensaje += "<br>Importe: " & CDec(VwSaldosFavorBindingSource.Current("Importe")).ToString("N2")
        Mensaje += "<br>Instrumento Monetario: " & TextIntrMone.Text.ToUpper
        Mensaje += "<br>Notas: " & TextComenta.Text.ToUpper

        Dim t As New ContaDS.CONT_SaldosFavorDataTable
        tx.FillByAnexo(t, VwSaldosFavorBindingSource.Current("Anexo"), False)
        Mensaje += "<br><br>Detalle:<br><Table border='1'>"
        Mensaje += "<tr><th>Fecha Registro</th><th>Fecha Aplicacion</th><th>Importe</th></tr>"
        For Each r As ContaDS.CONT_SaldosFavorRow In t.Rows
            Mensaje += "<tr><th>" & r.Fecha.ToShortDateString & "</th><th>" & r.FechaAplicacion & "</th><th>" & r.Importe.ToString("n2") & "</th></tr>"
        Next
        Mensaje += "</Table>"

        MandaCorreoFase(UsuarioGlobalCorreo, "APLICA_PAGOS", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "CONTA", Asunto, Mensaje)
        MandaCorreo(UsuarioGlobalCorreo, UsuarioGlobalCorreo, Asunto, Mensaje)
    End Sub

    Private Sub TextImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextImporte.KeyPress
        NumerosyDescimalNegativos(TextImporte, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Anexo As String = mtxtContrato.Text.Replace("/", "")
        If ta.ExisteAnexoTRA(Anexo) <= 0 Then
            MessageBox.Show("No existe contrato", "Contrato Inexsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ta.EstatusAnexoTRA(Anexo) <> "A" Then
            MessageBox.Show("Contratos no activo", "Estatus Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not IsNumeric(TextImporte.Text) Then
            MessageBox.Show("Importe no válido", "Importe Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        tx.Insert(Anexo, "", TextImporte.Text, UsuarioGlobal, Date.Now.Date, Date.Now.Date.ToString("yyyyMMdd"), TaQUERY.SacaCliente(Anexo), ComboInstMon.SelectedValue, False)
        TextImporte.Clear()
        mtxtContrato.Clear()
        Me.VwSaldosFavorTableAdapter.Fill(Me.JuridicoDS.VwSaldosFavor)
    End Sub


End Class