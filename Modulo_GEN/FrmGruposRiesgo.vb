Public Class FrmGruposRiesgo
    Dim Nuevo As Boolean = False

    Private Sub FrmGruposRiesgo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GruposRiesgosTableAdapter.Fill(Me.GeneralDS.GruposRiesgos)
        Bloquea(True)
        If Me.GeneralDS.GruposRiesgos.Rows.Count <= 0 Then
            BttMOD.Enabled = False
            BttAsig.Enabled = False
        End If
    End Sub

    Private Sub Bloquea(ByVal B As Boolean)
        BttNew.Enabled = B
        BttMOD.Enabled = B
        BttSave.Enabled = Not B
        BttCancel.Enabled = Not B
        BttAsig.Enabled = B
        TxtGrupo.Visible = Not B
        CmbGrupo.Enabled = B
    End Sub

    Private Sub BttNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttNew.Click
        TxtGrupo.Text = ""
        Nuevo = True
        Bloquea(False)
        TxtGrupo.Focus()
    End Sub

    Private Sub BttMOD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttMOD.Click
        If CmbGrupo.Text.Trim <> "SIN GRUPO DE NEGOCIOS" Then
            Nuevo = False
            Bloquea(False)
            TxtGrupo.Focus()
        End If
    End Sub

    Private Sub BttSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttSave.Click
        If TxtGrupo.Text = "" Then
            MessageBox.Show("Nombre del grupo es incorrecto", "Grupo de Riesgo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtGrupo.Focus()
            Exit Sub
        End If
        If Nuevo = True Then
            GruposRiesgosTableAdapter.InsertGrupo(UCase(TxtGrupo.Text))
        Else
            GruposRiesgosTableAdapter.UpdateGrupo(UCase(TxtGrupo.Text), CmbGrupo.SelectedValue)
        End If
        FrmGruposRiesgo_Load(Nothing, Nothing)
    End Sub

    Private Sub BttCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCancel.Click
        FrmGruposRiesgo_Load(Nothing, Nothing)
    End Sub

    Private Sub BttAsig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttAsig.Click
        Dim f As New FrmGruposRiesgoAsig
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    
End Class