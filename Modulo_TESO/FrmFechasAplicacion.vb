Public Class FrmFechasAplicacion
    
    Private Sub FrmFechasAplicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtFechaVigente.Text = FECHA_APLICACION.ToShortDateString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("¿Esta seguro de Cambiar la Fecha de Aplicacion?", "Fecha de Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            CambiaFechaAplicacion()
        End If
        TxtFechaVigente.Text = FECHA_APLICACION.ToShortDateString
    End Sub
End Class