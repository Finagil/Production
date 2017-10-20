Public Class FrmUsoCFDI
    Dim ta As New ContaDSTableAdapters.ActifijoTableAdapter
    Dim t As New ContaDS.ActifijoDataTable
    Private Sub FrmUsoCFDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CFDI_DivisionTableAdapter.Fill(Me.ContaDS.CFDI_Division)
        Me.ProductosFinagilTableAdapter.Fill(Me.GeneralDS.ProductosFinagil)
        Me.UsosCFDITableAdapter.Fill(Me.ContaDS.UsosCFDI)
        CargaDatos()
        CmbDivision_SelectedIndexChanged(Nothing, Nothing)
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


    Sub CargaDatos()
        If CmbProduct.SelectedIndex >= 0 Then
            If RBSinDefinir.Checked = True Then
                Me.AnexosSinUsoCFDITableAdapter.Fill(Me.ContaDS.AnexosSinUsoCFDI, CmbProduct.SelectedValue)
            Else
                Me.AnexosSinUsoCFDITableAdapter.FillByALL(Me.ContaDS.AnexosSinUsoCFDI, CmbProduct.SelectedValue)
            End If
        End If
    End Sub

    Private Sub CmbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProduct.SelectedIndexChanged
        CargaDatos()
    End Sub

    Private Sub RBSinDefinir_CheckedChanged(sender As Object, e As EventArgs) Handles RBSinDefinir.CheckedChanged, RBactivos.CheckedChanged
        CargaDatos()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
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
            If RBSinDefinir.Checked = True Then
                Me.AnexosSinUsoCFDITableAdapter.InsertUsoCFDI(CmbUsoCFDI.SelectedValue, CmbClave.SelectedValue, Me.AnexosSinUsoCFDIBindingSource.Current("Anexo"))
            Else
                Me.AnexosSinUsoCFDITableAdapter.UpdateUsoCFDI(CmbUsoCFDI.SelectedValue, CmbClave.SelectedValue, Me.AnexosSinUsoCFDIBindingSource.Current("Anexo"))
            End If
            CargaDatos()
        Else
            MessageBox.Show("no exsisten cambio para guardar.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CmbClase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbClase.SelectedIndexChanged
        If CmbClase.SelectedIndex >= 0 Then
            Me.CFDI_ClaveProsServTableAdapter.Fill(Me.ContaDS.CFDI_ClaveProsServ, CmbDivision.SelectedValue, CmbGrupo.SelectedValue, CmbClase.SelectedValue)
            CmbClave.SelectedIndex = 0
        End If
    End Sub

    Private Sub CmbGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGrupo.SelectedIndexChanged
        If CmbGrupo.SelectedIndex >= 0 Then
            Me.CFDI_ClaseTableAdapter.Fill(Me.ContaDS.CFDI_Clase, CmbDivision.SelectedValue, CmbGrupo.SelectedValue)
            CmbClase_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub CmbDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDivision.SelectedIndexChanged
        If CmbDivision.SelectedIndex >= 0 Then
            Me.CFDI_GrupoTableAdapter.Fill(Me.ContaDS.CFDI_Grupo, CmbDivision.SelectedValue)
            CmbGrupo_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub
End Class