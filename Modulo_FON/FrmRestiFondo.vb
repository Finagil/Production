Public Class FrmRestiFondo
    Dim FondoTA As New FondoResarvaDSTableAdapters.FondosReservaTableAdapter
    Private Sub FrmRestiFondo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FondoResarvaDS.Bancos' table. You can move, or remove it, as needed.
        Me.BancosTableAdapter.Fill(Me.FondoResarvaDS.Bancos)
        Me.ClientesConFondoTableAdapter.Fill(Me.FondoResarvaDS.ClientesConFondo)
        CmbClientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub CmbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbClientes.SelectedIndexChanged
        If CmbClientes.SelectedIndex >= 0 Then
            Me.AnexosConFondoTableAdapter.Fill(Me.FondoResarvaDS.AnexosConFondo, CmbClientes.SelectedValue)
            ListContratos_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub ListContratos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListContratos.SelectedIndexChanged
        If ListContratos.SelectedIndex >= 0 Then
            Dim saldo As Decimal = FondoTA.SaldoFondo(ListContratos.SelectedValue)
            Dim Fondo As Decimal = CDec(TxtFondo.Text)
            TxtSaldo.Text = saldo.ToString("n2")
            TxtFondo.Text = CDec(TxtFondo.Text).ToString("n2")
            TxtMov.Text = (Fondo - saldo).ToString("n2")
        Else
            TxtSaldo.Text = "0.0"
            TxtFondo.Text = "0.0"
            TxtMov.Text = "0.0"
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Val(TxtMov.Text) <= 0 Or Not IsNumeric(TxtMov.Text) Then
            MessageBox.Show("El importe no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMov.Focus()
            Exit Sub
        End If
        Dim saldo As Decimal = FondoTA.SaldoFondo(ListContratos.SelectedValue)
        Dim Fondo As Decimal = CDec(TxtFondo.Text)
        Dim mov As Decimal = CDec(TxtMov.Text)
        If saldo + mov > Fondo Then
            MessageBox.Show("El importe excede el fondo de reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMov.Focus()
            Exit Sub
        End If
        If CmbBanco.SelectedIndex < 0 Then
            MessageBox.Show("Falta selecionar Banco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMov.Focus()
            Exit Sub
        End If
        Dim Contable As New FondoResarvaDSTableAdapters.HisginTableAdapter
        FondoTA.Insert(ListContratos.SelectedValue, DTFecha.Value.ToString("yyyyMMdd"), TxtMov.Text, True, "R", CmbBanco.SelectedValue)
        Contable.Insert(ListContratos.SelectedValue, "", "", DTFecha.Value.ToString("yyyyMMdd"), "99", TxtMov.Text, "S", "S", 0, 0, "01", CmbBanco.SelectedValue, "Resti.Fondo.Reserva", "")
        Contable.Insert(ListContratos.SelectedValue, "", "", DTFecha.Value.ToString("yyyyMMdd"), "68", TxtMov.Text, "S", "S", 0, 1, "01", CmbBanco.SelectedValue, "Resti.Fondo.Reserva", "")
        ListContratos_SelectedIndexChanged(Nothing, Nothing)
    End Sub
End Class