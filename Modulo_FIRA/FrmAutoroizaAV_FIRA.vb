Public Class FrmAutoroizaAV_FIRA
    Dim Fila As Integer = -1
    Private Sub FrmAutoroizaAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AviosFiraTableAdapter.Fill(Me.FiraDS.AviosFIRA)
        Call SumaGrid()
        CheckAll_CheckedChanged(Nothing, Nothing)
    End Sub

    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        Me.FiraDS.AviosFIRA.AcceptChanges()
        Dim cont As Integer = 0
        For Each r As FiraDS.AviosFIRARow In Me.FiraDS.AviosFIRA.Rows
            If r.AutorizaAut = True Then
                Me.AviosFiraTableAdapter.LiberaCRE(UsuarioGlobal, r.AutorizaAut, "TesoreriaCXPX", r.Anexo) ' casos de Irapuato
                Me.AviosFiraTableAdapter.LiberaFira(r.Anexo)
                cont += 1
            End If
        Next
        Me.AviosFiraTableAdapter.Fill(Me.FiraDS.AviosFIRA)
        CheckAll_CheckedChanged(Nothing, Nothing)
        MessageBox.Show(cont & " Contratos Liberados", "Liberación Avío (Crédito)", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SumaGrid()
        'Me.FiraDS.AviosFIRA.AcceptChanges()
        Dim Importe As Double = 0
        For Each r As FiraDS.AviosFIRARow In Me.FiraDS.AviosFIRA.Rows
            If r.AutorizaAut = True Then
                Importe += r.Importe
            End If
        Next
        TxttotMinis.Text = Importe.ToString("n2")
    End Sub

    Private Sub CheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAll.CheckedChanged
        For Each r As FiraDS.AviosFIRARow In Me.FiraDS.AviosFIRA.Rows
            r.AutorizaAut = CheckAll.Checked
        Next
        Me.FiraDS.AviosFIRA.AcceptChanges()
        SumaGrid()
        Fila = -1
    End Sub

    Private Sub GridAnexos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridAnexos.CellContentClick
        Try
            Dim importe As Double = CDbl(TxttotMinis.Text)
            If e.RowIndex > -1 And e.ColumnIndex = 9 Then
                If Fila = e.RowIndex Then
                    If Me.GridAnexos.Rows(e.RowIndex).Cells("AutorizaAutDataGridViewCheckBoxColumn").Value = True Then
                        importe += CType(Me.GridAnexos.Rows(e.RowIndex).Cells("ImporteDataGridViewTextBoxColumn").Value, Decimal)
                    Else
                        importe -= CType(Me.GridAnexos.Rows(e.RowIndex).Cells("ImporteDataGridViewTextBoxColumn").Value, Decimal)
                    End If
                    Fila = -1
                Else
                    If Me.GridAnexos.Rows(e.RowIndex).Cells("AutorizaAutDataGridViewCheckBoxColumn").Value = True Then
                        importe -= CType(Me.GridAnexos.Rows(e.RowIndex).Cells("ImporteDataGridViewTextBoxColumn").Value, Decimal)
                    Else
                        importe += CType(Me.GridAnexos.Rows(e.RowIndex).Cells("ImporteDataGridViewTextBoxColumn").Value, Decimal)
                    End If
                    Fila = e.RowIndex
                End If
                TxttotMinis.Text = importe.ToString("n2")

            End If
        Catch ex As Exception
        End Try
    End Sub

End Class