Public Class FrmConvenioJUR

    Private Sub Txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length >= 3 Then
            Me.ClientesTableAdapter.Fill(Me.JuridicoDS.Clientes, "%" & Txtfiltro.Text & "%")
        Else
            Me.JuridicoDS.Clientes.Clear()
        End If
        CmbClientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub CmbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbClientes.SelectedIndexChanged
        If CmbClientes.SelectedIndex >= 0 Then
            Me.Vw_AnexosResumenTableAdapter.FillByConvenioJUR(Me.JuridicoDS.Vw_AnexosResumen, CmbClientes.SelectedValue)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CmbAnexo.SelectedIndex >= 0 Then
            DesBloqueaContrato(CmbAnexo.SelectedValue)
            Vw_AnexosResumenTableAdapter.ConvenioJUR("S", CmbAnexo.SelectedValue)
            BloqueaContrato(CmbAnexo.SelectedValue)
            CmbClientes_SelectedIndexChanged(Nothing, Nothing)
            Me.AnexosConvenioJURTableAdapter.Fill(Me.JuridicoDS.AnexosConvenioJUR)
        Else
            MessageBox.Show("Faltan datos", "Error Convenio Judicial", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FrmConvenioJUR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AnexosConvenioJURTableAdapter.Fill(Me.JuridicoDS.AnexosConvenioJUR)
    End Sub

    Private Sub ListConvenioJUR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListConvenioJUR.DoubleClick
        If ListConvenioJUR.SelectedIndex >= 0 Then
            If MessageBox.Show("¿está seguro de quitar el convenio judicial al contrato de " & ListConvenioJUR.Text & "?", "Quitar Convenio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DesBloqueaContrato(ListConvenioJUR.SelectedValue)
                Vw_AnexosResumenTableAdapter.ConvenioJUR("N", ListConvenioJUR.SelectedValue)
                BloqueaContrato(ListConvenioJUR.SelectedValue)
                CmbClientes_SelectedIndexChanged(Nothing, Nothing)
                Me.AnexosConvenioJURTableAdapter.Fill(Me.JuridicoDS.AnexosConvenioJUR)
            End If
        End If

    End Sub

    
    
End Class