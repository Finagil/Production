Imports System.ComponentModel

Public Class FrmFechasSupervision
    Private Sub FrmFechasSupervision_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'ProcesaFechas()
        Dim Thread As New System.Threading.Thread(AddressOf ProcesaFechas)
        Thread.Start()

        Me.ClientesFiraActivosTableAdapter.Fill(Me.AviosDSX.ClientesFiraActivos)
        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CmbClientes.SelectedIndexChanged
        If CmbClientes.SelectedValue <> Nothing Then
            Me.AnexosFiraActivosTableAdapter.Fill(AviosDSX.AnexosFiraActivos, CmbClientes.SelectedValue)
            CmbAnexos_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub CmbAnexos_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CmbAnexos.SelectedIndexChanged
        If CmbAnexos.SelectedValue <> Nothing Then
            Me.FechasSupervisionTableAdapter.Fill(Me.AviosDSX.FechasSupervision, Mid(CmbAnexos.SelectedValue, 1, 9), Mid(CmbAnexos.SelectedValue, 10, 2))
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSave.Click
        Try
            FechasSupervisionBindingSource.EndEdit()
            AviosDSX.FechasSupervision.GetChanges()
            Me.FechasSupervisionTableAdapter.Update(AviosDSX.FechasSupervision)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ProcesaFechas()
        Dim Anexo As String
        Dim t As New AviosDSX.AnexosFiraActivosDataTable
        Dim ta As New AviosDSXTableAdapters.AnexosFiraActivosTableAdapter
        Dim tf As New AviosDSXTableAdapters.FechasSupervisionTableAdapter
        ta.FillByAll(t)
        For Each r As AviosDSX.AnexosFiraActivosRow In t.Rows
            Anexo = Mid(r.Anexo, 1, 5) & Mid(r.Anexo, 7, 4)
            If Anexo <> "019140007" Then
                'Continue For
            End If
            If tf.HayFechas(Anexo, r.Ciclo).Value <= 0 Then
                Dim fecha1 As Date = CDate(r.FechaContrato)
                Dim fechaFin As Date = CDate(r.FechaVencimiento)
                fecha1 = fecha1.AddMonths(2)
                tf.Insert1erFecha(Anexo, r.Ciclo, fecha1)
                While fecha1 <= fechaFin
                    fecha1 = fecha1.AddYears(1)
                    tf.Insert1erFecha(Anexo, r.Ciclo, fecha1)
                End While
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New FrmAtachments
        f.Anexo = Mid(CmbAnexos.SelectedValue, 1, 9)
        f.Ciclo = ""
        f.Consulta = False
        f.Carpeta = "Supervisiones"
        f.Nombre = Me.ClientesFiraActivosBindingSource.Current("Nombre")
        If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub GridFechas_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles GridFechas.DefaultValuesNeeded
        e.Row.Cells(1).Value = CmbAnexos.SelectedValue.ToString.Trim
        e.Row.Cells(2).Value = ""
        e.Row.Cells(3).Value = Date.Now.Date
    End Sub

End Class