Public Class FrmSelecProd
    Public Origen As String
    Public Destino As String

    Private Sub FrmCicloSelec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UCase(Origen) = UCase("Solicitud") Then
            Me.ProductosTableAdapter.Fill(Me.PromocionDS.Productos)
            CmbProducto.SelectedIndex = 0
            If Destino = "F" Then
                ProductosBindingSource.Filter = "tipar <> 'B' "
            End If
        End If
        
    End Sub

    Private Sub BttSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttSave.Click
        Destino = UCase(CmbProducto.Text)
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BttCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class