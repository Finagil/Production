Public Class frmCondonaMoras

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Tipo As String = ""
            Select Case ComboTipo.SelectedIndex
                Case 0 'Domiciliado
                    Tipo = "V"
                Case 1 'Referenciado
                    Tipo = "F"
                Case 2 'Ambos
                    Tipo = "VF"
            End Select

            Tipo = DTPAplicacion.Value.ToString("yyyyMMdd") & ";" & Tipo & ";" & ComboDias.Text
            TaQUERY.UpdateMoraDiaFest(Tipo.ToUpper)
            CANCELA_MORA_DIA_FEST = Tipo.ToUpper.Split(";")
            MessageBox.Show("Cambio de Fecha Realizado", "Cancela Moratorios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmCondonaMoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTPAplicacion.Value = CTOD(CANCELA_MORA_DIA_FEST(0))
        DTPAplicacion.MinDate = CTOD(CANCELA_MORA_DIA_FEST(0))
        DTPAplicacion.MaxDate = FECHA_APLICACION

        Select Case CANCELA_MORA_DIA_FEST(1)
            Case "V" 'Domiciliado
                ComboTipo.SelectedIndex = 0
            Case "F" 'Referenciado
                ComboTipo.SelectedIndex = 1
            Case "VF" 'Ambos
                ComboTipo.SelectedIndex = 2
        End Select

        ComboDias.SelectedIndex = CInt(CANCELA_MORA_DIA_FEST(2)) - 1
    End Sub
End Class