Public Class FrmValPersonas
    Dim TaOnbase As New GeneralDSTableAdapters.OnBaseTableAdapter

    Private Sub TxtPersona_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPersona.TextChanged
        CargaDatos()
    End Sub

    Private Sub RdbActivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbActivos.CheckedChanged
        CargaDatos()
    End Sub

    Private Sub RdBTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBTodos.CheckedChanged
        CargaDatos()
    End Sub

    Sub CargaDatos()
        If TxtPersona.Text.Length >= 6 Then
            If RdbActivos.Checked = True Then
                Me.HistoriaPersonasTableAdapter.FillByActivos(GeneralDS.HistoriaPersonas, "%" & TxtPersona.Text & "%")
            Else
                Me.HistoriaPersonasTableAdapter.FillByPersonaTodos(GeneralDS.HistoriaPersonas, "%" & TxtPersona.Text & "%")
            End If
            DataGridView1_Click(Nothing, Nothing)
            ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++
            Dim ArrOnbaseCliente() As String = CadOnbase(TxtPersona.Text.Trim)
            If TaOnbase.ScalarCuantosAreaAnexo("Credito", ArrOnbaseCliente(0), ArrOnbaseCliente(1), ArrOnbaseCliente(2), ArrOnbaseCliente(3)) > 0 Then
                BtnOnbase.Enabled = True
            Else
                BtnOnbase.Enabled = False
            End If
            ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++
        Else
            GeneralDS.HistoriaPersonas.Clear()
            GeneralDS.HistoriaPersonas1.Clear()
            BtnOnbase.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Dim cAnexo As String
        Dim cAnexoCon As String
        Dim cCiclo As String
        If DataGridView1.RowCount > 0 Then
            cAnexo = DataGridView1.CurrentRow.Cells(0).Value
            cCiclo = Mid(cAnexo, 12, 2)
            Me.HistoriaPersonas1TableAdapter.FillAnexo(GeneralDS.HistoriaPersonas1, cAnexo)
        Else
            GeneralDS.HistoriaPersonas1.Clear()
        End If

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim cAnexo As String
        Dim cAnexoCon As String
        Dim cCiclo As String

        If DataGridView1.RowCount > 0 Then
            cAnexo = DataGridView1.CurrentRow.Cells(0).Value
            cCiclo = Mid(cAnexo, 12, 2)
            If cCiclo <> "" Then
                cAnexoCon = Mid(cAnexo, 1, 10)
                cAnexo = Mid(cAnexo, 1, 5) & Mid(cAnexo, 7, 4)
                Dim tx As New GeneralDSTableAdapters.AviosXTableAdapter
                Dim t As New GeneralDS.AviosXDataTable
                tx.Fill(t, cAnexo, cCiclo)
                Dim newfrmEdoCtaAvio As New frmEdoCtaAvio(cAnexoCon & " " & t.Rows(0).Item("CicloPagare"))
                newfrmEdoCtaAvio.Show()
            Else
                Dim newfrmHistoria As New frmHistoria(DataGridView1.CurrentRow.Cells(0).Value, "")
                newfrmHistoria.Show()
            End If
        End If

    End Sub

    Private Sub BtnOnbase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOnbase.Click
        Dim f As New FrmDocOnbase
        f.Area = "Credito"
        f.NombreCliente = TxtPersona.Text.Trim
        f.Titulo = Me.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        f.Dispose()
    End Sub

    
End Class