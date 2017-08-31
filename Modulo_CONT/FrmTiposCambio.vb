Public Class FrmTiposCambio
    Dim r As ContaDS.TiposDeCambioRow
    Private Sub FrmTiposCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MonedasTableAdapter.Fill(Me.ContaDS.Monedas)
        ComboMoneda.SelectedIndex = 1

    End Sub

    Private Sub ComboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMoneda.SelectedIndexChanged
        If ComboMoneda.SelectedIndex >= 0 Then
            CargaDatos()
        End If
    End Sub

    Sub CargaDatos()
        DTPmoneda.MinDate = "01/01/2017"
        DTPmoneda.MaxDate = Me.TiposDeCambioTableAdapter.FechaMax(ComboMoneda.SelectedValue)
        DTPmoneda.Value = DTPmoneda.MaxDate
        Me.TiposDeCambioTableAdapter.FillFechaMoneda(Me.ContaDS.TiposDeCambio, DTPmoneda.Value, ComboMoneda.SelectedValue)
        If Me.ContaDS.TiposDeCambio.Rows.Count > 0 Then
            Bloquea(False)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not IsNumeric(TxtTipoCambio.Text) Then
            MessageBox.Show("Dato no valido", "Tipo de Cambio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Val(TxtTipoCambio.Text) = 0 Then
            MessageBox.Show("Dato no valido", "Tipo de Cambio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            r.TipoCambio = TxtTipoCambio.Text
            Me.ContaDS.TiposDeCambio.AddTiposDeCambioRow(r)
            If r.Fecha.DayOfWeek = DayOfWeek.Friday Then
                'insertamos sabado
                r = ContaDS.TiposDeCambio.NewTiposDeCambioRow
                r.Fecha = DTPmoneda.Value.AddDays(1)
                r.TipoCambio = TxtTipoCambio.Text
                r.Moneda = ComboMoneda.SelectedValue
                Me.ContaDS.TiposDeCambio.AddTiposDeCambioRow(r)
                'insertamos Domingo
                r = ContaDS.TiposDeCambio.NewTiposDeCambioRow
                r.Fecha = DTPmoneda.Value.AddDays(2)
                r.TipoCambio = TxtTipoCambio.Text
                r.Moneda = ComboMoneda.SelectedValue
                Me.ContaDS.TiposDeCambio.AddTiposDeCambioRow(r)
            End If
            Me.ContaDS.TiposDeCambio.GetChanges()
            Me.TiposDeCambioTableAdapter.Update(Me.ContaDS.TiposDeCambio)
            CargaDatos()
        End If
    End Sub

    Sub Bloquea(B As Boolean)
        TxtTipoCambio.Enabled = B
        BtnSave.Enabled = B
        BtnNew.Enabled = Not B
        ComboMoneda.Enabled = Not B
        DTPmoneda.Enabled = Not B
    End Sub

    Private Sub DTPmoneda_ValueChanged(sender As Object, e As EventArgs) Handles DTPmoneda.ValueChanged
        Me.TiposDeCambioTableAdapter.FillFechaMoneda(Me.ContaDS.TiposDeCambio, DTPmoneda.Value, ComboMoneda.SelectedValue)
        If Me.ContaDS.TiposDeCambio.Rows.Count > 0 Then
            Bloquea(False)
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        DTPmoneda.MaxDate = Me.TiposDeCambioTableAdapter.FechaMax(ComboMoneda.SelectedValue)
        DTPmoneda.MaxDate = DTPmoneda.MaxDate.AddDays(1)
        DTPmoneda.Value = DTPmoneda.MaxDate

        Bloquea(True)
        TxtTipoCambio.Text = "0.0"
        r = ContaDS.TiposDeCambio.NewTiposDeCambioRow
        r.Fecha = DTPmoneda.Value
        r.TipoCambio = 0
        r.Moneda = ComboMoneda.SelectedValue
    End Sub
End Class