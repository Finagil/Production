Public Class FrmFechasAplicacion
    
    Private Sub FrmFechasAplicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtFechaVigente.Text = FECHA_APLICACION.ToShortDateString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("¿Esta seguro de Cambiar la Fecha de Aplicacion?", "Fecha de Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Cursor.Current = Cursors.WaitCursor
            CambiaFechaAplicacion()
            If UsuarioGlobal.ToUpper = "DESARROLLO" And My.Settings.BaseDatos = "ProdictionE" Then
                Shell("C:\Users\ecacerest\Documents\Proyectos\TraspasosCartera\bin\Debug\TraspasosCartera.exe V", AppWinStyle.Hide, True)
            End If
            Cursor.Current = Cursors.Default
            MessageBox.Show("Dia Cerrado", "Fechas de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtFechaVigente.Text = FECHA_APLICACION.ToShortDateString
            If UsuarioGlobal.ToUpper = "LHERNANDEZ" Then
                End
            End If
        End If

    End Sub
End Class