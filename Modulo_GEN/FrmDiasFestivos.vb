Public Class FrmDiasFestivos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.GEN_DiasFestivosTableAdapter.Update(Me.GeneralDS.GEN_DiasFestivos)
            Me.GEN_DiasFestivosTableAdapter.Fill(Me.GeneralDS.GEN_DiasFestivos)
            MessageBox.Show("Datos guardados.", "Días Festivos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmDiasFestivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GEN_DiasFestivosTableAdapter.Fill(GeneralDS.GEN_DiasFestivos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As GeneralDS.GEN_DiasFestivosRow
        r = Me.GeneralDS.GEN_DiasFestivos.NewGEN_DiasFestivosRow
        r.DiaFestivo = DateTimePicker1.Value
        Me.GeneralDS.GEN_DiasFestivos.AddGEN_DiasFestivosRow(r)
        Me.GEN_DiasFestivosTableAdapter.Update(Me.GeneralDS.GEN_DiasFestivos)
        Me.GEN_DiasFestivosTableAdapter.Fill(Me.GeneralDS.GEN_DiasFestivos)
        MessageBox.Show("Fecha agregada.", "Días Festivos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class