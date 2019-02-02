Public Class FrmAnexoSinPoliza
    Private Sub FrmAnexoSinPoliza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SegurosDS.Vw_SEG_ContratosSinPoliza' Puede moverla o quitarla según sea necesario.
        Me.Vw_SEG_ContratosSinPolizaTableAdapter.Fill(Me.SegurosDS.Vw_SEG_ContratosSinPoliza)

    End Sub
End Class