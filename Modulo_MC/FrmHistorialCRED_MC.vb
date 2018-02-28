Imports System.IO
Public Class FrmHistorialCRED_MC
    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            ContClie1BindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
        Else
            ContClie1BindingSource.Filter = ""
        End If
    End Sub

    Private Sub FrmHistorialCRED_MC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ContClie1TableAdapter.Fill(Me.ProductionDataSet.ContClie1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ruta As String = "\\server-nas\OnBase\DATFinagil\HistorialMC\"
        If File.Exists(Ruta & ComboBox1.SelectedValue & ".docx") Then
        Else
            File.Copy(Ruta & "HistorialMC.docx", Ruta & ComboBox1.SelectedValue & ".docx")
        End If
        Process.Start(Ruta & ComboBox1.SelectedValue & ".docx")
    End Sub
End Class