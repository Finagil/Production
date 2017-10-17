Public Class FrmUsoCFDI
    Dim ta As New ContaDSTableAdapters.ActifijoTableAdapter
    Dim t As New ContaDS.ActifijoDataTable
    Private Sub FrmUsoCFDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsosCFDITableAdapter.Fill(Me.ContaDS.UsosCFDI)
        CargaDatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If Not IsNothing(Me.AnexosSinUsoCFDIBindingSource.Current) Then
            If Me.AnexosSinUsoCFDIBindingSource.Current("tIPO") = "M" Then
                If UsosCFDIBindingSource.Current("Moral") = False Then
                    MessageBox.Show("Este uso No aplica para Personas Morales", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                If UsosCFDIBindingSource.Current("Fisica") = False Then
                    MessageBox.Show("Este uso No aplica para Personas Físicas", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            DesBloqueaContrato(Me.AnexosSinUsoCFDIBindingSource.Current("Anexo"))
            Me.AnexosSinUsoCFDITableAdapter.UpdateUsoCFDI_AV(CmbUsoCFDI.SelectedValue, Me.AnexosSinUsoCFDIBindingSource.Current("Anexo"))
            Me.AnexosSinUsoCFDITableAdapter.UpdateUsoCFDI_TRA(CmbUsoCFDI.SelectedValue, Me.AnexosSinUsoCFDIBindingSource.Current("Anexo"))
            BloqueaContrato(Me.AnexosSinUsoCFDIBindingSource.Current("Anexo"))
            CargaDatos()
        Else
            MessageBox.Show("no exsisten cambio para guardar.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AnexosSinUsoCFDIBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles AnexosSinUsoCFDIBindingSource.CurrentChanged
        TextBox1.Text = ""
        If Not IsNothing(Me.AnexosSinUsoCFDIBindingSource.Current) Then
            ta.Fill(t, Me.AnexosSinUsoCFDIBindingSource.Current("Anexo"))
            For Each r As ContaDS.ActifijoRow In t.Rows
                TextBox1.Text += r.Detalle & vbCrLf
            Next
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)
        CargaDatos()
    End Sub

    Sub CargaDatos()
        If RBSinDefinir.Checked = True Then
            Me.AnexosSinUsoCFDITableAdapter.Fill(Me.ContaDS.AnexosSinUsoCFDI)
        Else
            Me.AnexosSinUsoCFDITableAdapter.FillByActivos(Me.ContaDS.AnexosSinUsoCFDI)
        End If
    End Sub

End Class