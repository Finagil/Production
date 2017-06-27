Public Class FrmMinistracionesParametros
    Public ID As Integer = 0

    Private Sub BttMinistraciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttMinistraciones.Click
        If Valida() = True Then
            Me.AviosDSX.AVI_MinistracionesParametros.AcceptChanges()
            Me.AVI_MinistracionesParametrosTableAdapter.DeletePARA(ID)
            For Each r As AviosDSX.AVI_MinistracionesParametrosRow In Me.AviosDSX.AVI_MinistracionesParametros.Rows
                Me.AVI_MinistracionesParametrosTableAdapter.Insert(r.Id_Parametro, r.Fecha, r.Porcentaje)
            Next
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub FrmMinistracionesSOL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AVI_MinistracionesParametrosTableAdapter.Fill(Me.AviosDSX.AVI_MinistracionesParametros, ID)
    End Sub

    Private Sub DataGridView1_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles Grid1.RowsAdded
        Dim x As Integer = 0
        For x = 0 To Grid1.RowCount - 1
            Grid1.Item(1, x).Value = ID
        Next
    End Sub

    Function Valida() As Boolean
        Valida = True
        Dim PorcentajeT As Decimal = 0
        Me.AviosDSX.AVI_MinistracionesParametros.AcceptChanges()
        For Each r As AviosDSX.AVI_MinistracionesParametrosRow In Me.AviosDSX.AVI_MinistracionesParametros.Rows
            If r.Fecha.Length <> 8 Or Not IsNumeric(r.Fecha) Then
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Valida = False
                Exit Function
            End If
        Next
        Me.AviosDSX.AVI_MinistracionesParametros.AcceptChanges()
        For Each r As AviosDSX.AVI_MinistracionesParametrosRow In Me.AviosDSX.AVI_MinistracionesParametros.Rows
            PorcentajeT += Math.Round(r.Porcentaje, 2)
        Next
        If PorcentajeT <> 1 Then
            MessageBox.Show("Los porcentajes no dan 100%.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Valida = False
            Exit Function
        End If
    End Function

    Private Sub BttValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttValidar.Click
        If Valida() = True Then
            MessageBox.Show("Datos Correctos", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class