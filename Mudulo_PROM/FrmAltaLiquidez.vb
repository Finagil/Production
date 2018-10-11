Public Class FrmAltaLiquidez

    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            ContClie1BindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
            CmbCli_SelectedIndexChanged(Nothing, Nothing)
        Else
            ContClie1BindingSource.Filter = ""
        End If
    End Sub

    Private Sub FrmAltaLiquidez_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PlazasTableAdapter.Fill(Me.PromocionDS.Plazas)
        Me.LI_PeriodosTableAdapter.Fill(Me.PromocionDS.LI_Periodos)
        Me.LI_PlazosTableAdapter.Fill(Me.PromocionDS.LI_Plazos)
        Me.ContClie1TableAdapter.FillByPersonas(Me.ProductionDataSet.ContClie1)
    End Sub

    Private Sub BttNewCli_Click(sender As Object, e As EventArgs) Handles BttNewCli.Click
        Dim f As New frmAltaClie
        If f.ShowDialog = DialogResult.OK Then
            Me.ContClie1TableAdapter.FillByPersonas(Me.ProductionDataSet.ContClie1)
        End If
    End Sub

    Private Sub CmbCli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCli.SelectedIndexChanged
        If CmbCli.SelectedIndex >= 0 Then
            Me.ClientesTableAdapter.Fill(PromocionDS.Clientes, CmbCli.SelectedValue)
            Me.PROM_SolicitudesLIQTableAdapter.FillByProcesado(PromocionDS.PROM_SolicitudesLIQ, CmbCli.SelectedValue, False)
            If PromocionDS.PROM_SolicitudesLIQ.Rows.Count > 0 Then
                Botones(False)
            Else
                Botones(True)
            End If
        End If
    End Sub

    Private Sub BtnNewSol_Click(sender As Object, e As EventArgs) Handles BtnNewSol.Click
        Me.PROMSolicitudesLIQBindingSource.AddNew()
        ProcesaRFC()
        Me.PROMSolicitudesLIQBindingSource.Current("Cliente") = CmbCli.SelectedValue
        DTPIngreso.MaxDate = Date.Now.Date.AddYears(-2)
        DTPIngreso.Value = Date.Now.Date.AddYears(-2)
        Botones(False)
    End Sub

    Private Sub TxtRFC_TextChanged(sender As Object, e As EventArgs) Handles TxtRFC.TextChanged
        ProcesaRFC()
    End Sub

    Sub ProcesaRFC()
        If TxtRFC.Text.Trim.Length >= 10 Then
            Dim f As Date
            f = SacaFechaRFC(TxtRFC.Text).ToShortDateString
            Txtfecnac.Text = f.ToShortDateString
            Txtedad.Text = DateDiff(DateInterval.Year, f, Date.Now)
        Else
            Txtedad.Text = 0
            Txtfecnac.Text = "01/01/1900"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        NumerosyDecimal(TextBox1, e)
    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged
        NumerosyDecimal(TextBox23, e)
    End Sub

    Private Sub TextBox30_Leave(sender As Object, e As EventArgs) Handles TextBox30.Leave
        If validar_Mail(TextBox30.Text) = False Then
            MessageBox.Show("Correo Invalido", "Correo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Me.PROMSolicitudesLIQBindingSource.Current("NumInt").ToString.Length > 0 Then
            Me.ClientesBindingSource.Current("Calle") = PROMSolicitudesLIQBindingSource.Current("Calle") & " NO EXT." & PROMSolicitudesLIQBindingSource.Current("NumExt") & " NO INT." & PROMSolicitudesLIQBindingSource.Current("NumInt")
        Else
            Me.ClientesBindingSource.Current("Calle") = PROMSolicitudesLIQBindingSource.Current("Calle") & " NO EXT." & PROMSolicitudesLIQBindingSource.Current("NumExt")
        End If
        ClientesBindingSource.EndEdit()
        PROMSolicitudesLIQBindingSource.EndEdit()
        ClientesTableAdapter.Update(PromocionDS.Clientes)
        PROM_SolicitudesLIQTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ)
    End Sub

    Sub Botones(B As Boolean)
        BtnNewSol.Enabled = B
        BtnSave.Enabled = Not B
        BtnPrint.Enabled = Not B
    End Sub
End Class