Public Class FrmDatosEmpresaXanexo
    Public Anexo As String
    Dim ta As New ConsultasDSTableAdapters.AnexosDatosEmpresaTableAdapter
    Dim t As New ConsultasDS.AnexosDatosEmpresaDataTable
    Dim r As ConsultasDS.AnexosDatosEmpresaRow
    Private Sub FrmDatosEmpresaXanexo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ta.Fill(t, Anexo)
        r = t.Rows(0)
        TextAnexo.Text = Anexo.Substring(0, 5) & "/" & Anexo.Substring(5, 4)
        Textcli.Text = r.Descr.Trim
        TextEmpre.Text = r.CNEmpresa.Trim
        TextPlanta.Text = r.CNPlanta.Trim
        If r.Flcan <> "A" Then
            MessageBox.Show("El contrato no esta activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextEmpre.Text.ToUpper <> r.CNEmpresa.ToUpper Or TextPlanta.Text.ToUpper <> r.CNPlanta.ToUpper Then
                ta.UpdateAnexo(TextEmpre.Text.ToUpper.Trim, TextPlanta.Text.ToUpper.Trim, Anexo, Anexo)
                MessageBox.Show("Cambios Guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FrmDatosEmpresaXanexo_Load(Nothing, Nothing)
            Else
                MessageBox.Show("No existen modificaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class