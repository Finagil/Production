Public Class FrmGruposClientesConsulta

    Private Sub FrmGruposClientesConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ta As New GeneralDSTableAdapters.RiesgoComunTableAdapter
        TxtIDRC.Text = ta.SacaID_RC(TxtCliente.Text.Trim())
        If TxtIDRC.Text = "0" Then
            ta.InsertGrupo(TxtCliente.Text)
            TxtIDRC.Text = ta.SacaID_RC(TxtCliente.Text.Trim())
            ta.CambioRC(TxtIDRC.Text, TxtCliente.Text)
        End If

        Me.ClientesGENTableAdapter.Fill(GeneralDS.ClientesGEN, TxtCliente.Text)
        lblName.Focus()
        If TxtRiesgo.Text.Trim = "SIN GRUPO DE NEGOCIOS" Then
            BtnRiesgo.Enabled = False
            BttGR.Enabled = False
        End If

    End Sub

    Private Sub BtnRiesgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRiesgo.Click
        Dim f As New FrmGrupoLista
        f.Text = "Grupo de Negocios (" & TxtRiesgo.Text & ")"
        f.GrupoX = "GR"
        If TxtIDGR.Text = "0" Then
            f.ID = "-1"
        Else
            f.ID = TxtIDGR.Text
        End If

        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Private Sub BtoRiesgoComun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtoRiesgoComun.Click
        Dim ff As New FrmGruposRiesgoFirmantes
        ff.ID = TxtIDRC.Text
        If ff.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim f As New FrmGrupoLista
            f.Text = "Grupo de Riesgo Común (" & txtDescr.Text.Trim() & ")"
            f.GrupoX = "RC"
            f.Persona = txtDescr.Text.Trim()
            f.ID = TxtIDRC.Text
            If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttGR.Click
        Cursor.Current = Cursors.WaitCursor
        Dim f As New FrmRptGnerico
        f.Titulo = " Reporte Grupo de Negocios (" & TxtRiesgo.Text & ")"
        f.Text = " Reporte Grupo de Negocios (" & TxtRiesgo.Text & ")"
        f.ReporteNom = "RptGR"
        f.ID_grupo = TxtIDGR.Text
        Cursor.Current = Cursors.Default
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

End Class