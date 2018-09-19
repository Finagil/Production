Public Class FrmLiberaDocsPLD
    Private Sub FrmLiberaDocsPLD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PLD_DS.BitacoraMC' Puede moverla o quitarla según sea necesario.
        Me.BitacoraMCTableAdapter.Fill(Me.PLD_DS.BitacoraMC)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNothing(Me.BitacoraMCBindingSource.Current()) Then
            If MessageBox.Show("¿Estas seguro de liberar este contrato " & Me.BitacoraMCBindingSource.Current("Anexo") & "?", "Liberación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.BitacoraMCTableAdapter.LiberaDocumento(UsuarioGlobal & "X", True, Me.BitacoraMCBindingSource.Current("id_bitacora"))
            End If
        End If
    End Sub
End Class