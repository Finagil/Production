Public Class FrmAmpliacionAnticipo

    Private Sub FrmAmpliacionAnticipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AmpliacionAnticiposTableAdapter.FillAgrupado(AviosDSXCLIE.AmpliacionAnticipos, Date.Now.ToString("yyyyMMdd"))
        Cmbclie_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub TxtLinea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLinea.TextChanged
        If IsNumeric(TxtLinea.Text) Then
            TxtLinea.Text = CDbl(TxtLinea.Text).ToString("n")
        End If
    End Sub

    Private Sub Cmbclie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbclie.SelectedIndexChanged
        If Cmbclie.SelectedIndex >= 0 Then
            AmpliacionAnticiposTableAdapter.Fill(AviosDSX.AmpliacionAnticipos, Cmbclie.SelectedValue)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAnexo.SelectedIndexChanged
        RadioButton1.Checked = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Txtsuma.Enabled = True
            TxtImporte.Enabled = False
        Else
            Txtsuma.Enabled = False
            TxtImporte.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Bitacora As New GeneralDSTableAdapters.BitacoraControlTableAdapter
        If RadioButton1.Checked = True Then
            If Not IsNumeric(Txtsuma.Text) Then
                MessageBox.Show("Error en cantidad", "Error Ampliacion de Linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txtsuma.Focus()
                Exit Sub
            End If
            If MessageBox.Show("Esta seguro de cambiar la linea de " & CDbl(TxtLinea.Text).ToString("n") & " a " & (CDbl(TxtLinea.Text) + CDbl(Txtsuma.Text)).ToString("n"), "Ampliación de Línea", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                AmpliacionAnticiposTableAdapter.ApliarLinea(CDbl(TxtLinea.Text) + CDbl(Txtsuma.Text), Mid(CmbAnexo.SelectedValue, 1, 9), Mid(CmbAnexo.SelectedValue, 11, 2))
                Bitacora.Insert(UsuarioGlobal, "Avios Ampliaciones ", Date.Now, TxtLinea.Text & "|" & (CDbl(TxtLinea.Text) + CDbl(Txtsuma.Text)).ToString("n2"), "00000", Mid(CmbAnexo.SelectedValue, 1, 9))
                TxtLinea.Text = (CDbl(TxtLinea.Text) + CDbl(Txtsuma.Text)).ToString("n2")
            End If
        Else
            If Not IsNumeric(TxtImporte.Text) Then
                MessageBox.Show("Error en cantidad", "Error Ampliacion de Linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtImporte.Focus()
                Exit Sub
            End If
            If CDbl(TxtImporte.Text) <= CDbl(TxtLinea.Text) Then
                MessageBox.Show("Cantidad menor o igual a la Linea actual", "Error Ampliacion de Linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtImporte.Focus()
                Exit Sub
            End If
            If MessageBox.Show("Esta seguro de cambiar la linea de " & CDbl(TxtLinea.Text).ToString("n") & " a " & CDbl(TxtImporte.Text).ToString("n"), "Ampliación de Línea", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                AmpliacionAnticiposTableAdapter.ApliarLinea(CDbl(TxtImporte.Text), Mid(CmbAnexo.SelectedValue, 1, 9), Mid(CmbAnexo.SelectedValue, 11, 2))
                Bitacora.Insert(UsuarioGlobal, "Avios Ampliaciones", Date.Now, TxtLinea.Text & "|" & TxtImporte.Text, "00000", Mid(CmbAnexo.SelectedValue, 1, 9))
                TxtLinea.Text = (CDbl(TxtImporte.Text)).ToString("n2")
            End If
        End If
        Txtsuma.Clear()
        TxtImporte.Clear()
        'Cmbclie_SelectedIndexChanged(Nothing, Nothing)
    End Sub
End Class