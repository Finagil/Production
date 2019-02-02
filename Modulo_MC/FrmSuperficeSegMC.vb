Public Class FrmSuperficeSegMC
    Public Anexo As String
    Public Ciclo As String
    Public Cliente As String
    Private Sub FrmSuperficeSegMC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuperficesAltasTableAdapter.Fill(Me.SegurosDS.SuperficesAltas, Anexo, Ciclo, Cliente)
    End Sub
End Class