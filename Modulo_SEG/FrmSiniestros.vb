Public Class FrmSiniestros

    Private Sub FrmSiniestros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CiclosTableAdapter.Fill(Me.SegurosDS.Ciclos)
        CmbCiclo_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub CmbCiclo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCiclo.SelectedIndexChanged
        If CmbCiclo.SelectedIndex >= 0 Then
            Bloquea("Cancela")
            Me.ClientesSuperficiesTableAdapter.Fill(Me.SegurosDS.ClientesSuperficies, CmbCiclo.SelectedValue)
            If Me.SegurosDS.ClientesSuperficies.Rows.Count > 0 Then
                CmbCliSuper.SelectedIndex = 0
                CmbCliSuper_SelectedIndexChanged(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub CmbPol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPol.SelectedIndexChanged
        If CmbPol.SelectedValue > 0 Then
            Bloquea("Cancela")
            Me.SuperficesAltasTableAdapter.FillByPolCli(Me.SegurosDS.SuperficesAltas, CmbPol.SelectedValue, CmbCliSuper.SelectedValue)
            CmbSuper_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub BttSiniestros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttSiniestros.Click
        Bloquea("Siniestro")
        LimpiaCampos()
        BttAltaSin.Text = "Alta"
    End Sub

    Private Sub BttDevol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttDevol.Click
        Bloquea("Devolucion")
        LimpiaCampos()
        BttDevolnew.Text = "Alta"
    End Sub

    Sub Bloquea(ByVal Mov As String)
        Select Case UCase(Mov)
            Case "CANCELA"
                LimpiaCampos()
                GroupPoliza.Enabled = True
                GroupSinietros.Enabled = False
                GroupDevol.Enabled = False
                GroupSinietros.Enabled = False
                CmbSuper_SelectedIndexChanged(Nothing, Nothing)
            Case "SINIESTRO"
                GroupPoliza.Enabled = False
                GroupSinietros.Enabled = False
                GroupDevol.Enabled = False
                GroupSinietros.Enabled = True
            Case "DEVOLUCION"
                GroupPoliza.Enabled = False
                GroupSinietros.Enabled = False
                GroupDevol.Enabled = True
                GroupSinietros.Enabled = False
        End Select
    End Sub

    Private Sub ButtAltCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtAltCancel.Click
        Bloquea("Cancela")
    End Sub

    Private Sub BttCancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCancel2.Click
        Bloquea("Cancela")
    End Sub

    Private Sub BttAltaSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttAltaSin.Click
        If Ttxttipo.Text = "" Then
            MessageBox.Show("Tipo no valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Ttxttipo.Focus()
            Exit Sub
        End If
        If TxtdIAS.Text = "" Then
            MessageBox.Show("Dias no validos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtdIAS.Focus()
            Exit Sub
        End If
        If TxtMonto.Text = "" Then
            MessageBox.Show("Monto no valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Focus()
            Exit Sub
        End If
        If TxtSuper.Text = "" Then
            MessageBox.Show("Superficie no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtSuper.Focus()
            Exit Sub
        End If
        If BttAltaSin.Text = "Guardar" And TxtIdsin.Text = "" Then
            MessageBox.Show("No se ha selecionado Siniestro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If BttAltaSin.Text = "Alta" Then
            Me.SEG_SiniestrosTableAdapter.Insert(CmbSuper.SelectedValue, Dtfecha.Value.ToString("yyyyMMdd"), Ttxttipo.Text, _
            DTfecIndem.Value.ToString("yyyyMMdd"), TxtdIAS.Text, TxtMonto.Text, TxtSuper.Text, Txtobserv.Text)
        Else
            Me.SEG_SiniestrosTableAdapter.UpdateSIN(Dtfecha.Value.ToString("yyyyMMdd"), Ttxttipo.Text, _
            DTfecIndem.Value.ToString("yyyyMMdd"), TxtdIAS.Text, TxtMonto.Text, TxtSuper.Text, Txtobserv.Text, TxtIdsin.Text)
        End If
        Bloquea("Cancela")

    End Sub

    Private Sub BttDevolnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttDevolnew.Click
        If TxtdevolMonto.Text = "" Then
            MessageBox.Show("Monto no valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtdevolMonto.Focus()
            Exit Sub
        End If
        If TxtDevolSaldo.Text = "" Then
            MessageBox.Show("Saldo no valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtDevolSaldo.Focus()
            Exit Sub
        End If
        If BttDevolnew.Text = "Guardar" And TxtIddev.Text = "" Then
            MessageBox.Show("No se ha selecionado devolucion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If BttDevolnew.Text = "Guardar" Then
            Me.SEG_DevolucionesTableAdapter.UpdateDEV(TxtdevolMonto.Text, TxtDevolSaldo.Text, dtDevol.Value.ToString("yyyyMMdd"), TxtIddev.Text)
        Else
            Me.SEG_DevolucionesTableAdapter.Insert(CmbSuper.SelectedValue, TxtdevolMonto.Text, TxtDevolSaldo.Text, dtDevol.Value.ToString("yyyyMMdd"))
        End If
        Bloquea("Cancela")

    End Sub

    Sub LimpiaCampos()
        Dtfecha.Value = Today
        DTfecIndem.Value = Today
        TxtdIAS.Text = ""
        TxtSuper.Text = ""
        TxtMonto.Text = ""
        Txtobserv.Text = ""

    End Sub

    Private Sub TxtdIAS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtdIAS.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub TxtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMonto.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtSuper_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSuper.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub CmbSuper_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSuper.SelectedIndexChanged
        If CmbSuper.SelectedIndex >= 0 Then
            Me.SEG_SiniestrosTableAdapter.Fill(Me.SegurosDS.SEG_Siniestros, CmbSuper.SelectedValue)
            Me.SEG_DevolucionesTableAdapter.Fill(Me.SegurosDS.SEG_Devoluciones, CmbSuper.SelectedValue)
        End If
    End Sub

    Private Sub TxtdevolMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtdevolMonto.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtDevolSaldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDevolSaldo.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Sub CargaDatosSIN()
        If TxtIdsin.Text <> "" Then
            Dim t As New SegurosDS.SEG_SiniestrosDataTable
            Dim pol As New SegurosDSTableAdapters.SEG_SiniestrosTableAdapter
            pol.FillBySin(t, TxtIdsin.Text)
            For Each r As SegurosDS.SEG_SiniestrosRow In t.Rows
                Ttxttipo.Text = r.Tipo
                Dtfecha.Value = CTOD(r.Fecha)
                DTfecIndem.Value = CTOD(r.FechaIndeminacion)
                TxtdIAS.Text = r.Dias
                TxtMonto.Text = r.Monto
                Txtobserv.Text = r.Observaciones
            Next
        End If
    End Sub

    Sub CargaDatosDEVOL()
        If TxtIddev.Text <> "" Then
            Dim t As New SegurosDS.SEG_DevolucionesDataTable
            Dim pol As New SegurosDSTableAdapters.SEG_DevolucionesTableAdapter
            pol.FillByDEV(t, TxtIddev.Text)
            For Each r As SegurosDS.SEG_DevolucionesRow In t.Rows
                dtDevol.Value = CTOD(r.Fecha)
                DTfecIndem.Value = CTOD(r.Fecha)
                TxtdevolMonto.Text = r.MontoAplicado
                TxtDevolSaldo.Text = r.SaldoFavor
            Next
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        CargaDatosSIN()
    End Sub

    Private Sub DataGridView2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.SelectionChanged
        CargaDatosDEVOL()
    End Sub
    
    Private Sub BttModSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttModSin.Click
        If Me.SegurosDS.SEG_Siniestros.Rows.Count > 0 Then
            If TxtIdsin.Text = "" Then
                MessageBox.Show("No existen Siniestros para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Bloquea("Siniestro")
                CargaDatosSIN()
                BttAltaSin.Text = "Guardar"
            End If
        End If
    End Sub

    Private Sub BttModDev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttModDev.Click
        If Me.SegurosDS.SEG_Devoluciones.Rows.Count > 0 Then
            If TxtIddev.Text = "" Then
                MessageBox.Show("No existen Devoluciones para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Bloquea("DEVOLUCION")
                CargaDatosDEVOL()
                BttDevolnew.Text = "Guardar"
            End If
        End If
    End Sub

    Private Sub CmbCliSuper_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCliSuper.SelectedIndexChanged
        If CmbCliSuper.SelectedIndex >= 0 Then
            Bloquea("Cancela")
            Me.PolizaSuperTableAdapter.Fill(Me.SegurosDS.PolizaSuper, CmbCliSuper.SelectedValue)
            If Me.SegurosDS.PolizaSuper.Rows.Count > 0 Then
                CmbPol.SelectedIndex = 0
                CmbPol_SelectedIndexChanged(Nothing, Nothing)
            End If
        End If
    End Sub
End Class