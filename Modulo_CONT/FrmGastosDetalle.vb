Public Class FrmGastosDetalle
    Public Opcion As String

    Private Sub FrmGastosDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Opcion.Length <= 5 Then
            Me.Vw_GastosTableAdapter.FillCliente(Me.GastosDS.Vw_Gastos, Opcion)
        Else
            Me.Vw_GastosTableAdapter.FillAnexo(Me.GastosDS.Vw_Gastos, Opcion)
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class