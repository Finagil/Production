Public Class FrmGrupoLista
    Public ID As Double
    Public GrupoX As String
    Public Persona As String

    Private Sub FrmGrupoLista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GrupoX = "GR" Then
            Me.ClientesConGrupoTableAdapter.Fill(GeneralDS.ClientesConGrupo, ID)
            ListGR.Visible = True
            BttRC.Visible = False
            'BtnFirmantes.Visible = False
        Else
            If ID <> 0 Then
                GeneraRC()
            Else
                MessageBox.Show("Error RC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.ClientesConGrupoComunTableAdapter.Fill(GeneralDS.ClientesConGrupoComun, ID)
            ListRC.Visible = True
            If ListRC.Items.Count > 0 Then
                BttRC.Visible = True
            End If
            'BtnFirmantes.Visible = True
        End If
    End Sub

    Private Sub BttRC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttRC.Click
        Cursor.Current = Cursors.WaitCursor
        Dim f As New FrmRptGnerico
        f.Titulo = Me.Text
        f.Text = Me.Text
        f.ReporteNom = "RptRC"
        f.ID_grupo = ID
        Cursor.Current = Cursors.Default
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Sub GeneraRC()
        Dim cli As String
        Dim ta As New GeneralDSTableAdapters.RiesgoComunTableAdapter
        'ta.QuitaRC(ID)
        Dim ta1 As New GeneralDSTableAdapters.HistoriaPersonasTableAdapter
        Dim tT1 As New GeneralDS.HistoriaPersonasDataTable
        Dim r As GeneralDS.HistoriaPersonasRow
        ta1.FillByPersonaTodos(tT1, "%" & Persona & "%")
        For Each r In tT1.Rows
            cli = ta.SacaAcreditado(r.Acreditado)
            ta.CambioRC(ID, cli)
        Next
    End Sub

End Class