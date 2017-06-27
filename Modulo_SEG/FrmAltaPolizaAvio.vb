Public Class FrmAltaPolizaAvio
    Dim Nuevo As Boolean = False
    Public USUARIOX As String

    Private Sub FrmAltaPolizaAvio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GEN_CultivosTableAdapter.Fill(Me.SegurosDS.GEN_Cultivos)
        Me.SEG_AseguradorasTableAdapter.Fill(Me.SegurosDS.SEG_Aseguradoras)
        Me.CiclosTableAdapter.Fill(Me.SegurosDS.Ciclos)
        CmbCiclo_SelectedIndexChanged(Nothing, Nothing)
        Bloquea(True)
        If UCase(USUARIOX) = "VELY" Or UCase(USUARIOX) = "GAGUILAR" Or UCase(USUARIOX) = "DESARROLLO" Then
            BttCatalogos.Visible = True
        Else
            BttCatalogos.Visible = False
        End If
    End Sub

    Private Sub CmbCiclo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCiclo.SelectedIndexChanged
        If CmbCiclo.SelectedIndex >= 0 Then
            LimpiaCampos()
            Me.SEG_PolizasAvioTableAdapter.Fill(Me.SegurosDS.SEG_PolizasAvio, CmbCiclo.SelectedValue)
            If Me.SegurosDS.SEG_PolizasAvio.Rows.Count > 0 Then
                CmbPol.SelectedIndex = 0
                CmbPol_SelectedIndexChanged(Nothing, Nothing)
            End If

        End If
    End Sub

    Private Sub Txtcuota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcuota.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not Txtcuota.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtSumaAseg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSumaAseg.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not TxtSumaAseg.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Sub Bloquea(ByVal B As Boolean)
        CmbCiclo.Enabled = B
        CmbPol.Enabled = B
        CmbAseg.Enabled = B
        BttNew.Enabled = B
        BttMod.Enabled = B
        BttDel.Enabled = B
        BttSave.Enabled = Not B
        BttCancel.Enabled = Not B
        TxtPol.Enabled = Not B
        DTpol.Enabled = Not B
        DTpag.Enabled = Not B
        DTini.Enabled = Not B
        DtFin.Enabled = Not B
        CmbCultivo.Enabled = Not B
        CmbAseg.Enabled = Not B
        Txtcuota.Enabled = Not B
        TxtSumaAseg.Enabled = Not B
        TxtPrima.Enabled = Not B
        Txtsuper.Enabled = Not B
    End Sub

    Sub LimpiaCampos()
        TxtPol.Text = ""
        DTpol.Value = Today
        DTpag.Value = Today
        DTini.Value = Today
        DtFin.Value = Today
        CmbAseg.Text = ""
        Txtcuota.Text = ""
        TxtSumaAseg.Text = ""
        TxtPrima.Text = ""
        Txtsuper.Text = ""
        TxtConCont.Text = ""
        TxtSinCont.Text = ""
        TxtDiff.Text = ""
        CmbCultivo.SelectedIndex = -1
        CmbAseg.SelectedIndex = -1
        TxtDiff.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub BttNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttNew.Click
        Bloquea(False)
        LimpiaCampos()
        Nuevo = True
    End Sub

    Private Sub BttMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttMod.Click
        Nuevo = False
        Bloquea(False)
    End Sub

    Private Sub BttSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttSave.Click
        If TxtPol.Text = "" Then
            MessageBox.Show("Poliza no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CmbCultivo.Text = "" Then
            MessageBox.Show("Cultivo no valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CmbAseg.Text = "" Then
            MessageBox.Show("Seguradora no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Txtcuota.Text = "" Then
            MessageBox.Show("Cuota no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtSumaAseg.Text = "" Then
            MessageBox.Show("Suma Asegurada no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        TxtPrima.Text = (Val(Txtcuota.Text) * Val(Txtsuper.Text))
        If TxtPrima.Text = "" Then
            MessageBox.Show("Prima no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Nuevo = True Then
            Me.SEG_PolizasAvioTableAdapter.Insert(UCase(TxtPol.Text), DTpol.Value.ToString("yyyyMMdd"), _
            DTini.Value.ToString("yyyyMMdd"), DtFin.Value.ToString("yyyyMMdd"), DTpag.Value.ToString("yyyyMMdd"), CmbCultivo.Text, CmbAseg.SelectedValue, _
            Txtcuota.Text, TxtSumaAseg.Text, TxtPrima.Text, CmbCiclo.SelectedValue, Txtsuper.Text)
        Else
            Me.SEG_PolizasAvioTableAdapter.Update(UCase(TxtPol.Text), DTpol.Value.ToString("yyyyMMdd"), _
                        DTini.Value.ToString("yyyyMMdd"), DtFin.Value.ToString("yyyyMMdd"), DTpag.Value.ToString("yyyyMMdd"), CmbCultivo.Text, CmbAseg.SelectedValue, _
                        Txtcuota.Text, TxtSumaAseg.Text, TxtPrima.Text, Txtsuper.Text, CmbPol.SelectedValue)
        End If
        Bloquea(True)
        LimpiaCampos()
        CmbCiclo_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub BttCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCancel.Click
        Bloquea(True)
        LimpiaCampos()
        CmbPol.SelectedIndex = -1
    End Sub

    Private Sub CmbPol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPol.SelectedIndexChanged
        If CmbPol.SelectedValue > 0 Then
            LimpiaCampos()
            CargaPoliza(CmbPol.SelectedValue)
        End If
    End Sub

    Sub CargaPoliza(ByVal id As Double)
        Dim T As New SegurosDS.SEG_PolizasAvioDataTable
        Me.SEG_PolizasAvioTableAdapter.FillByID(T, id)
        For Each r As SegurosDS.SEG_PolizasAvioRow In T.Rows
            TxtPol.Text = r.Poliza
            DTpol.Value = CTOD(r.FechaPoliza)
            DTpag.Value = CTOD(r.FechaPago)
            DTini.Value = CTOD(r.FechaInicia)
            DtFin.Value = CTOD(r.FechaTermina)
            CmbCultivo.Text = r.Cultivo
            Txtcuota.Text = r.Cuota
            TxtSumaAseg.Text = r.SumaAsegurada
            If Not IsDBNull(r.Superficie) Then Txtsuper.Text = r.Superficie Else Txtsuper.Text = 0
            TxtPrima.Text = (r.Cuota * Val(Txtsuper.Text)).ToString("n2") 'r.Prima
            TxtConCont.Text = Me.SEG_PolizasAvioTableAdapter.SupConCont(r.IdPoliza)
            TxtSinCont.Text = Me.SEG_PolizasAvioTableAdapter.SupSinCont(r.IdPoliza)
            TxtDiff.Text = (Val(Txtsuper.Text) - (Val(TxtConCont.Text) + Val(TxtSinCont.Text))).ToString("n2")
            If Val(TxtDiff.Text) <> 0 Then TxtDiff.BackColor = Color.Yellow Else TxtDiff.BackColor = Color.FromKnownColor(KnownColor.Control)
            CmbAseg.Text = Me.SEG_AseguradorasTableAdapter.ScalarAseg(r.idAseguradora)
        Next
    End Sub

    Private Sub BttDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttDel.Click
        If CmbPol.SelectedIndex < 0 Then
            MessageBox.Show("Debe seleccionar una poliza.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim X As Double = Me.SEG_PolizasAvioTableAdapter.Superficies(CmbPol.SelectedValue)
        If X > 0 Then
            MessageBox.Show("Esta poliza no puede ser eliminada. " & vbCrLf & " (tienes superficies dadas de alta).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("¿Está seguro de Borrar la poliza " & CmbPol.Text & "?", "Poliza", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.SEG_PolizasAvioTableAdapter.Delete(CmbPol.SelectedValue)
            LimpiaCampos()
            CmbCiclo_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Bloquea(True)
        LimpiaCampos()
        CmbPol.SelectedIndex = -1
        Dim f As New FrmSeguroAvio
        f.Show()
    End Sub

    Private Sub BttSiniestros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttSiniestros.Click
        Bloquea(True)
        LimpiaCampos()
        CmbPol.SelectedIndex = -1
        Dim f As New FrmSiniestros
        f.Show()
    End Sub

    Private Sub TxtPrima_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrima.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not TxtPrima.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txtsuper_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtsuper.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not Txtsuper.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        ElseIf e.KeyChar = "-" And Not Txtsuper.Text.IndexOf("-") Then
            e.Handled = True
        ElseIf e.KeyChar = "-" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BttCatalogos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCatalogos.Click
        Dim X As New FrmCatalogos
        X.Show()
    End Sub

End Class