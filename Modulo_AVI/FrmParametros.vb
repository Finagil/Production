Public Class FrmParametros

    Private Sub FrmParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ParametrosTableAdapter.Fill(Me.AvioDS.Parametros)
        Me.GEN_CultivosTableAdapter.Fill(Me.SegurosDS.GEN_Cultivos)
        Me.CiclosTableAdapter.FillByVigentes(Me.SegurosDS.Ciclos)
        Me.SucursalesTableAdapter.Fill(Me.AvioDS.Sucursales)
        CargaDatos()
    End Sub

    Sub CargaDatos()
        If CmbCiclo.SelectedIndex > -1 And CmbSucursal.SelectedIndex > -1 And CmbCultivo.SelectedIndex > -1 Then
            Me.ParametrosTableAdapter.FillByFiltro(Me.AvioDS.Parametros, CmbCiclo.SelectedValue, CmbSucursal.SelectedValue, CmbCultivo.SelectedValue)
            If Me.AvioDS.Parametros.Rows.Count <= 0 Then
                Me.ParametrosTableAdapter.Insert(CmbCiclo.SelectedValue, CmbSucursal.SelectedValue, CmbCultivo.SelectedValue, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", 0, 0, "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", "19000101")
                Me.ParametrosTableAdapter.FillByFiltro(Me.AvioDS.Parametros, CmbCiclo.SelectedValue, CmbSucursal.SelectedValue, CmbCultivo.SelectedValue)
            End If
            Dim r As AviosDSX.ParametrosRow
            r = Me.AvioDS.Parametros.Rows(0)
            DTTermina.Value = CTOD(r.FechaTerminacion)
            DTSiembraini.Value = CTOD(r.FechaSiembrai)
            DTSiembrafin.Value = CTOD(r.FechaSiembraf)
            DTcosechaIni.Value = CTOD(r.FechaCosechai)
            DTcosechaFin.Value = CTOD(r.FechaCosechaf)
            DTDTC.Value = CTOD(r.FechaLimiteDTC)
            'AÑO2++++++++++++++++++++++++++++++++++++++
            DTTermina2.Value = CTOD(r.FechaTerminacion2)
            DTSiembraini2.Value = CTOD(r.FechaSiembrai2)
            DTSiembrafin2.Value = CTOD(r.FechaSiembraf2)
            DTcosechaIni2.Value = CTOD(r.FechaCosechai2)
            DTcosechaFin2.Value = CTOD(r.FechaCosechaf2)
            DTDTC2.Value = CTOD(r.FechaLimiteDTC2)
            'AÑO3++++++++++++++++++++++++++++++++++++++
            DTTermina3.Value = CTOD(r.FechaTerminacion3)
            DTSiembraini3.Value = CTOD(r.FechaSiembrai3)
            DTSiembrafin3.Value = CTOD(r.FechaSiembraf3)
            DTcosechaIni3.Value = CTOD(r.FechaCosechai3)
            DTcosechaFin3.Value = CTOD(r.FechaCosechaf3)
            DTDTC3.Value = CTOD(r.FechaLimiteDTC3)
        End If
    End Sub

    Private Sub BttSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttSave.Click
        Dim c As Object
        For Each c In GroupDatos.Controls
            If c.GetType Is GetType(System.Windows.Forms.TextBox) Then
                If Not IsNumeric(c.Text) Then
                    MessageBox.Show("Error de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    c.Focus()
                    Exit Sub
                End If
                If Val(c.Text) <= 0 Then
                    MessageBox.Show("Error de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    c.Focus()
                    Exit Sub
                End If
            End If
        Next
        If Val(TxtMin.Text) > Val(TxtMax.Text) Then
            MessageBox.Show("Rango erroneo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtTasa.Focus()
            Exit Sub
        End If
        If Val(TxtTasa.Text) > Val(TxtMax.Text) Or Val(TxtTasa.Text) < Val(TxtMin.Text) Then
            MessageBox.Show("Tasa fuera de rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtTasa.Focus()
            Exit Sub
        End If
        Me.ParametrosTableAdapter.UpdateParametro(TxtCuota.Text, TxtGtosHecta.Text, _
        TxtGtosAdmin.Text, TxtComis.Text, TxtBuro.Text, TxtBuroPM.Text, TxtSegVid.Text, TxtSegAgri.Text, TxtMax.Text, TxtMin.Text, TxtTasa.Text, _
        DTTermina.Value.ToString("yyyyMMdd"), DTSiembraini.Value.ToString("yyyyMMdd"), DTSiembrafin.Value.ToString("yyyyMMdd"), DTcosechaIni.Value.ToString("yyyyMMdd"), _
        DTcosechaFin.Value.ToString("yyyyMMdd"), DTDTC.Value.ToString("yyyyMMdd"), TxtPrecio.Text, TxtTonHecta.Text, _
        DTTermina2.Value.ToString("yyyyMMdd"), DTSiembraini2.Value.ToString("yyyyMMdd"), DTSiembrafin2.Value.ToString("yyyyMMdd"), DTcosechaIni2.Value.ToString("yyyyMMdd"), _
        DTcosechaFin2.Value.ToString("yyyyMMdd"), DTDTC2.Value.ToString("yyyyMMdd"), _
        DTTermina3.Value.ToString("yyyyMMdd"), DTSiembraini3.Value.ToString("yyyyMMdd"), DTSiembrafin3.Value.ToString("yyyyMMdd"), DTcosechaIni3.Value.ToString("yyyyMMdd"), _
        DTcosechaFin3.Value.ToString("yyyyMMdd"), DTDTC3.Value.ToString("yyyyMMdd"), _
        Txtid.Text, Txtid.Text)
        CargaDatos()
    End Sub

    Private Sub CmbCiclo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCiclo.SelectedIndexChanged
        CargaDatos()
    End Sub

    Private Sub CmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSucursal.SelectedIndexChanged
        CargaDatos()
    End Sub

    Private Sub CmbCultivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCultivo.SelectedIndexChanged
        CargaDatos()
    End Sub

    Private Sub TxtCuota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCuota.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtGtosHecta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGtosHecta.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtGtosAdmin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGtosAdmin.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtComis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtComis.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtBuro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuro.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtBuroPM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuroPM.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtSegVid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSegVid.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtSegAgri_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSegAgri.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtTasa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTasa.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtMin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMin.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtMax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMax.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecio.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtTonHecta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTonHecta.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinistraciones.Click
        Dim f As New FrmMinistracionesParametros
        f.ID = Txtid.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub
End Class