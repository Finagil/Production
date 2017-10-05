Public Class FrmCastigoGaratia
    Private Sub FrmCastigoGaratia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesConAnexoTableAdapter.Fill(Me.ContaDS.ClientesConAnexo)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex >= 0 Then
            Me.AnexosClienteTableAdapter.Fill(Me.ContaDS.AnexosCliente, ComboBox1.SelectedValue)
            AnexosClienteBindingSource_CurrentChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub TxtCasti_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCasti.KeyPress
        NumerosyDecimal(TxtCasti, e)
    End Sub

    Private Sub Txtgarat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtGarant.KeyPress
        NumerosyDecimal(TxtGarant, e)
    End Sub

    Private Sub TxtInte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtInte.KeyPress
        NumerosyDecimal(TxtInte, e)
    End Sub

    Private Sub TxtPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPago.KeyPress
        NumerosyDecimal(TxtPago, e)
    End Sub

    Private Sub BtAdd_Click(sender As Object, e As EventArgs) Handles BtAdd.Click
        Dim r As ContaDS.CONT_Castigos_GarantiasRow
        r = Me.ContaDS.CONT_Castigos_Garantias.NewCONT_Castigos_GarantiasRow
        r.Anexo = Me.AnexosClienteBindingSource.Current("Anexo")
        r.Ciclo = Me.AnexosClienteBindingSource.Current("Ciclo")
        r.Fecha = "01/01/1900"
        r.Garantia = 0
        r.Castigo = 0
        r.Pago = 0
        r.Interes = 0
        Me.ContaDS.CONT_Castigos_Garantias.AddCONT_Castigos_GarantiasRow(r)
        Me.ContaDS.CONT_Castigos_Garantias.GetChanges()
        Me.CONT_Castigos_GarantiasTableAdapter.Update(Me.ContaDS.CONT_Castigos_Garantias)
        GroupBox1.Enabled = True
        BtAdd.Enabled = False
    End Sub

    Private Sub AnexosClienteBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles AnexosClienteBindingSource.CurrentChanged
        If Not IsNothing(Me.AnexosClienteBindingSource.Current) Then
            Me.AnexosClienteBindingSource.Filter = ""
            Me.CONT_Castigos_GarantiasTableAdapter.Fill(Me.ContaDS.CONT_Castigos_Garantias, Me.AnexosClienteBindingSource.Current("Anexo"), Me.AnexosClienteBindingSource.Current("Ciclo"))
            If Me.ContaDS.CONT_Castigos_Garantias.Count > 0 Then
                GroupBox1.Enabled = True
                BtAdd.Enabled = False
            Else
                GroupBox1.Enabled = False
                BtAdd.Enabled = True
            End If
        End If
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        Try
            CONTCastigosGarantiasBindingSource.EndEdit()
            Me.ContaDS.CONT_Castigos_Garantias.GetChanges()
            Me.CONT_Castigos_GarantiasTableAdapter.Update(Me.ContaDS.CONT_Castigos_Garantias)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TextBox6_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtAnexo.KeyUp
        If TxtAnexo.Text = "" Then
            Me.ClientesConAnexoTableAdapter.Fill(Me.ContaDS.ClientesConAnexo)
        Else
            Me.ClientesConAnexoTableAdapter.FillByAnexo(Me.ContaDS.ClientesConAnexo, TxtAnexo.Text.Trim)
            ComboBox1_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub TxtAnexo_TextChanged(sender As Object, e As EventArgs) Handles TxtAnexo.TextChanged
        If TxtAnexo.Text <> "" Then
            Me.AnexosClienteBindingSource.Filter = "anexo like '%" & TxtAnexo.Text.Trim & "%' or anexoCon like '%" & TxtAnexo.Text.Trim & "%'"
        Else
            Me.AnexosClienteBindingSource.Filter = ""
        End If
    End Sub
End Class