Public Class FrmSegFactoraje

    Private Sub FrmSegFactoraje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SEG_AseguradorasTableAdapter.Fill(Me.SegurosDS.SEG_Aseguradoras)
        ClientesFactor100()
        Me.Factor_ClientesTableAdapter.Fill(Me.SegurosDS.Factor_Clientes)
        TxtLinea.Text = Format(Val(TxtLinea.Text), "##,##0.00")
        CmbTipoSeg.SelectedIndex = 0
    End Sub

    Sub ClientesFactor100()
        Dim Clies As New Factor100DSTableAdapters.ClientesTableAdapter
        Dim t As New Factor100DS.ClientesDataTable
        Dim r As Factor100DS.ClientesRow
        Clies.Fill(t)
        For Each r In t.Rows
            Me.Factor_ClientesTableAdapter.Insert(r.CL_NUM, r.CL_NOMBRE, r.CL_RFC, r.CL_FECADU, r.DI_DIVISA, r.CL_LIMCR)
        Next
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TxtNombre.Text = "" Then
            MessageBox.Show("Falta nombre del Deudor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtNombre.Focus()
            Exit Sub
        End If
        If TxtEndoso.Text = "" Then
            MessageBox.Show("Falta endoso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtEndoso.Focus()
            Exit Sub
        End If
        If Not IsNumeric(TxtSumaAseg.Text) Then
            MessageBox.Show("Falta sumka Asegurada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtSumaAseg.Focus()
            Exit Sub
        End If
        Me.Factor_DeudoresTableAdapter.Insert(CmbCliente.SelectedValue, TxtMoneda.Text, TxtNombre.Text.ToUpper, CmbTipoSeg.Text, CmbAseg.SelectedValue, TxtEndoso.Text.ToUpper, TxtSumaAseg.Text, DPVigencia.Value, False, False)
        Borra_Datos()
        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCliente.SelectedIndexChanged
        Me.VW_DedudoresTableAdapter.Fill(SegurosDS.VW_Dedudores, TxtMoneda.Text, CmbCliente.SelectedValue)
    End Sub

    Private Sub FactorClientesBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FactorClientesBindingSource.CurrentChanged
        TxtLinea.Text = Format(Val(TxtLinea.Text), "##,##0.00")
    End Sub

    Sub Borra_Datos()
        TxtNombre.Clear()
        CmbTipoSeg.SelectedIndex = 0
        CmbAseg.SelectedIndex = 0
        TxtEndoso.Clear()
        TxtSumaAseg.Clear()
        DPVigencia.Value = Date.Now
        TxtLinea.Text = Format(Val(TxtLinea.Text), "##,##0.00")
    End Sub

    

    Private Sub GridDeudores_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles GridDeudores.UserDeletingRow
        If TxtID.Text = "" Then
            Exit Sub
            e.Cancel = True
        End If
        If MessageBox.Show("¿esta seguro de borrar el renglon selecionado?", "Borrar Deudor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Factor_DeudoresTableAdapter.Deletedeudor(TxtID.Text)
        Else
            e.Cancel = True
        End If
    End Sub
End Class