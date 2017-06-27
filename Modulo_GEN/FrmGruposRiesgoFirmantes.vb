Public Class FrmGruposRiesgoFirmantes
    Public ID As Integer = 0

    Private Sub FrmGruposRiesgoAsig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.HistoriaPersonasTableAdapter.FillPersonas(Me.GeneralDS.HistoriaPersonas)
        Dim ta As New GeneralDSTableAdapters.RiesgoComunTableAdapter
        ta.QuitaRC(ID)
        Me.GruposRiesgosTableAdapter.Fill(Me.GeneralDS.GruposRiesgos)
        Call Cargar()
    End Sub

    Private Sub Txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            HistoriaPersonasBindingSource.Filter = "nombre like '%" & Txtfiltro.Text & "%'"
        Else
            HistoriaPersonasBindingSource.Filter = ""
        End If
    End Sub

    Private Sub TxtFiltro2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFiltro2.TextChanged
        If TxtFiltro2.Text.Length > 0 Then
            ClientesConGrupoBindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
        Else
            ClientesConGrupoBindingSource.Filter = ""
        End If
    End Sub

    Private Sub ListaSin_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSin.DoubleClick
        If ListaSin.SelectedIndex >= 0 Then
            'Me.ClientesSinGrupoTableAdapter.UpdateGrupo(ID, ListaSin.SelectedValue)
            AddRC(ListaSin.Text.Trim, True)
            Me.GeneralDS.ClientesConGrupo.AddClientesConGrupoRow(ListaSin.SelectedValue, ListaSin.Text, ID)
            HistoriaPersonasBindingSource.RemoveCurrent()

        End If
    End Sub

    Private Sub ListaCon_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCon.DoubleClick
        If ListaCon.SelectedIndex >= 0 Then
            'Me.ClientesSinGrupoTableAdapter.UpdateGrupo(0, ListaCon.SelectedValue)
            AddRC(ListaCon.Text.Trim, False)
            Me.GeneralDS.ClientesSinGrupo.AddClientesSinGrupoRow(ListaCon.SelectedValue, ListaCon.Text, 0)
            ClientesConGrupoBindingSource.RemoveCurrent()
        End If
    End Sub

    Sub Cargar()
        Me.HistoriaPersonasTableAdapter.FillPersonas(Me.GeneralDS.HistoriaPersonas)
        Me.ClientesConGrupoTableAdapter.Fill(Me.GeneralDS.ClientesConGrupo, ID)
    End Sub

    Sub AddRC(ByVal Persona As String, ByVal Add As Boolean)
        Dim cli As String
        Dim ta As New GeneralDSTableAdapters.RiesgoComunTableAdapter
        Dim ta1 As New GeneralDSTableAdapters.HistoriaPersonasTableAdapter
        Dim tT1 As New GeneralDS.HistoriaPersonasDataTable
        Dim r As GeneralDS.HistoriaPersonasRow
        ta1.FillByPersonaTodos(tT1, "%" & Persona & "%")
        For Each r In tT1.Rows
            cli = ta.SacaAcreditado(r.Acreditado)
            If Add = True Then
                ta.CambioRC(ID, cli)
            Else
                ta.CambioRC(0, cli)
            End If
        Next
    End Sub
    
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class