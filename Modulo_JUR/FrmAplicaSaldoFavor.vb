Public Class FrmAplicaSaldoFavor
    Dim ta As New JuridicoDSTableAdapters.VwSaldosFavorTableAdapter
    Private Sub FrmAplicaSaldoFavor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim ta As New ContaDSTableAdapters.CONT_SaldosFavorTableAdapter
            GeneraCorreo()
            ta.ProcesarSaldoFavor(VwSaldosFavorBindingSource.Current("Anexo"), "", 0)
            ta.Insert(VwSaldosFavorBindingSource.Current("Anexo"), "", VwSaldosFavorBindingSource.Current("Importe") * -1,
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

        MandaCorreoFase(UsuarioGlobalCorreo, "APLICA_PAGOS", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", Asunto, Mensaje)
        MandaCorreo(UsuarioGlobalCorreo, UsuarioGlobalCorreo, Asunto, Mensaje)
    End Sub

End Class