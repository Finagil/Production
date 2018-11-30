Public Class FrmAutoroizaAV_FIRA
    Private Sub FrmAutoroizaAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AviosFiraTableAdapter.Fill(Me.FiraDS.AviosFIRA)
        Call Suma()
    End Sub

    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        Me.FiraDS.AviosFIRA.AcceptChanges()
        Dim cont As Integer = 0
        For Each r As FiraDS.AviosFIRARow In Me.FiraDS.AviosFIRA.Rows
            If r.AutorizaAut = True Then
                Me.AviosFiraTableAdapter.LiberaCRE(UsuarioGlobal, r.AutorizaAut, "TesoreriaX", r.Anexo)
                Me.AviosFiraTableAdapter.LiberaFira(r.Anexo)
                cont += 1
            End If
        Next
        Me.AviosFiraTableAdapter.Fill(Me.FiraDS.AviosFIRA)
        Call SumaGrid()
        MessageBox.Show(cont & " Contratos Liberados", "Liberación Avío (Crédito)", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GridAnexos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridAnexos.CellValueChanged
        SumaGrid()
    End Sub

    Private Sub Suma()
        Dim Importe As Double = 0
        For Each r As FiraDS.AviosFIRARow In Me.FiraDS.AviosFIRA.Rows
            r.AutorizaAut = True
            Importe += r.Importe
        Next
        TxttotMinis.Text = Importe.ToString("n2")
    End Sub

    Private Sub SumaGrid()
        Dim Importe As Double = 0
        For Each r As FiraDS.AviosFIRARow In Me.FiraDS.AviosFIRA.Rows
            If r.AutorizaAut = True Then
                Importe += r.Importe
            End If
        Next
        TxttotMinis.Text = Importe.ToString("n2")
    End Sub

End Class