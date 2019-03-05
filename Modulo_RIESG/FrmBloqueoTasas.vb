Public Class FrmBloqueoTasas

    Private Sub FrmBloqueoTasas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GeneralDS.AnexosBloqueadoTasa' table. You can move, or remove it, as needed.
        Me.AnexosBloqueadoTasaTableAdapter.Fill(Me.GeneralDS.AnexosBloqueadoTasa, False, False)
        Me.AnexosBloqueadoTasaTableAdapter.Fill(Me.GeneralDS1.AnexosBloqueadoTasa, True, True)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TxtComents.Text = "" Then
            MessageBox.Show("Favor de poner comentarios", "Cometario de Area de Riesgos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtComents.Focus()
            Exit Sub
        End If
        If TxtIndica.Text = "" Then
            MessageBox.Show("Favor de poner indicadores.", "Cometario de Area de Riesgos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtIndica.Focus()
            Exit Sub
        End If
        Dim ta As New GeneralDSTableAdapters.GEN_Bloqueo_TasasTableAdapter
        Dim Diff As Decimal = CDec(TxtTasaPol.Text) - CDec(TxtTasasol.Text)
        Dim DG As Boolean = False
        Dim Autoriza As String = ""
        If Diff <= 0.5 And Diff >= -0.5 Then
            DG = True
            Autoriza = "RI"
        Else
            Autoriza = "DG"
        End If
        ta.Desbloqueo(TxtComents.Text, TxtIndica.Text, True, DG, Autoriza, TxtID.Text)
        TxtComents.Clear()
        TxtIndica.Clear()
        Me.AnexosBloqueadoTasaTableAdapter.Fill(Me.GeneralDS.AnexosBloqueadoTasa, False, False)
        Me.AnexosBloqueadoTasaTableAdapter.Fill(Me.GeneralDS1.AnexosBloqueadoTasa, True, True)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.AnexosBloqueadoTasaTableAdapter.AutorizaReserva(Me.AnexosBloqueadoTasaBindingSource.Current("Reserva"), Me.AnexosBloqueadoTasaBindingSource.Current("PorcReserva"), Me.AnexosBloqueadoTasaBindingSource.Current("id"))
        Me.AnexosBloqueadoTasaTableAdapter.UpdateAnexoReserva(TextReserva.Text, Me.AnexosBloqueadoTasaBindingSource.Current("Anexo"))
        Me.AnexosBloqueadoTasaTableAdapter.Fill(Me.GeneralDS.AnexosBloqueadoTasa, False, False)
        Me.AnexosBloqueadoTasaTableAdapter.Fill(Me.GeneralDS1.AnexosBloqueadoTasa, True, True)
    End Sub
End Class