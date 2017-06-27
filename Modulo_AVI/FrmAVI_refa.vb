Imports Microsoft.Office.Interop
Public Class FrmAVI_Refa
    Public Fecha As Date = Date.Now


    Private Sub BttMinistraciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttMinistraciones.Click
        If Valida() = True Then
            Me.AviosDSX.FIRArefaccionarios.GetChanges()
            Me.FIRArefaccionariosTableAdapter.Update(Me.AviosDSX.FIRArefaccionarios)
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Function Valida() As Boolean
        Valida = True
        'Me.AviosDSX.AVI_MinistracionesSolicitudes.AcceptChanges()
        'For Each r As AviosDSX.AVI_MinistracionesSolicitudesRow In Me.AviosDSX.AVI_MinistracionesSolicitudes.Rows
        '    If r.Fecha.Length <> 8 Or Not IsNumeric(r.Fecha) Then
        '        MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Valida = False
        '        Exit Function
        '    End If
        '    If r.Importe <= 0 Then
        '        MessageBox.Show("Importe invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Valida = False
        '        Exit Function
        '    End If
        'Next
        'Me.AviosDSX.AVI_MinistracionesSolicitudes.AcceptChanges()
    End Function

    Private Sub BttValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttValidar.Click
        If Valida() = True Then

            Me.AviosDSX.FIRArefaccionarios.GetChanges()
            Me.FIRArefaccionariosTableAdapter.Update(Me.AviosDSX.FIRArefaccionarios)
            Me.FIRArefaccionariosTableAdapter.FillByGarantia(Me.AviosDSX.FIRArefaccionarios)
        End If

    End Sub

    Private Sub FrmAVI_Refa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FIRArefaccionariosTableAdapter.FillByGarantia(Me.AviosDSX.FIRArefaccionarios)
    End Sub

End Class