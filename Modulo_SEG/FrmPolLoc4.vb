Public Class FrmPolLoc4

    Dim LOC As New SegurosDSTableAdapters.SEG_LocalizadoresTableAdapter


    Sub Bloquea(ByVal Mov As String)
        Select Case UCase(Mov)
            Case "POLIZA"
                GroupClientes.Enabled = False
                GroupLOC.Enabled = False
            Case "LOCALIZADOR"
                GroupClientes.Enabled = False
                GroupLOC.Enabled = True
            Case "CANCELAR"
                GroupClientes.Enabled = True
                GroupLOC.Enabled = False
                'LimpiaCampos()
        End Select
    End Sub

    Sub LimpiaCampos()
        'localizadores
        TxtFactura.Text = ""
        TxtImpo.Text = ""
        DTTermina.Value = Today
        DTsolic.Value = Today
        DtInstall.Value = Today
        Cmbplataforma.SelectedIndex = 0
        Txtendoso.Text = ""
        TxtidCli.Text = ""
        CmbAeg2.SelectedIndex = 0
    End Sub

    Private Sub FrmPolLoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SEG_AseguradorasCopyTableAdapter.Fill(Me.SegurosDS.SEG_AseguradorasCopy)
        Me.SEG_AseguradorasTableAdapter.Fill(Me.SegurosDS.SEG_Aseguradoras)
        Me.ActifijoIITableAdapter.FillByGPS(Me.SegurosDS.ActifijoII)
        Bloquea("Cancelar")
    End Sub

    Private Sub BttLOCNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttLOCNew.Click
        If Me.SegurosDS.ActifijoII.Rows.Count > 0 Then
            Dim t As New SegurosDS.SEG_LocalizadoresDataTable
            LOC.Fill(t, TxtidActivo.Text)
            If t.Rows.Count <= 0 Then
                TxtidCli.Text = Mid(TxtAnexo.Text, 1, 10) & "-" & Microsoft.VisualBasic.Right(Trim(TxtSerie.Text), 4)
            End If
            Bloquea("Localizador")
        End If
    End Sub

    Sub CargaDatosLOC()
        Dim t As New SegurosDS.SEG_LocalizadoresDataTable
        LOC.Fill(t, TxtidActivo.Text)
        For Each r As SegurosDS.SEG_LocalizadoresRow In t.Rows
            TxtFactura.Text = r.Factura
            TxtImpo.Text = r.Importe
            DTTermina.Value = CTOD(r.FechaFin)
            DTsolic.Value = CTOD(r.FechaSolicitada)
            DTpago.Value = CTOD(r.FechaPago)
            DtInstall.Value = CTOD(r.FechaInstalacion)
            Cmbplataforma.Text = r.EnPlataforma
            Txtendoso.Text = r.Endoso
            TxtIDloc.Text = r.IDLocalizador
            TxtidCli.Text = Trim(r.IdCliente)
            CmbAeg2.Text = Me.SEG_AseguradorasCopyTableAdapter.ScalarAseg(r.IDaseguradora)
        Next
    End Sub

    Private Sub BttCancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCancel2.Click
        Bloquea("Cancelar")
    End Sub

    Private Sub BttSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttSave.Click
        If TxtFactura.Text = "" Then
            MessageBox.Show("Factura no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtImpo.Text = "" Then
            MessageBox.Show("Importe no valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Cmbplataforma.Text = "" Then
            Cmbplataforma.Text = "No"
        End If
        If Txtendoso.Text = "" Then
            MessageBox.Show("Endoso no valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim t As New SegurosDS.SEG_LocalizadoresDataTable
        LOC.Fill(t, TxtidActivo.Text)
        If t.Rows.Count > 0 Then
            LOC.Update(CmbAeg2.SelectedValue, TxtidCli.Text, UCase(TxtFactura.Text), TxtImpo.Text, DTTermina.Value.ToString("yyyyMMdd"), DTsolic.Value.ToString("yyyyMMdd"), _
            DtInstall.Value.ToString("yyyyMMdd"), DTpago.Value.ToString("yyyyMMdd"), UCase(Txtendoso.Text), Cmbplataforma.Text, TxtidActivo.Text, TxtIDloc.Text)
        Else
            LOC.Insert(CmbAeg2.SelectedValue, TxtidCli.Text, UCase(TxtFactura.Text), TxtImpo.Text, DTTermina.Value.ToString("yyyyMMdd"), DTsolic.Value.ToString("yyyyMMdd"), _
            DtInstall.Value.ToString("yyyyMMdd"), DTpago.Value.ToString("yyyyMMdd"), UCase(Txtendoso.Text), Cmbplataforma.Text, TxtidActivo.Text)
        End If
        LimpiaCampos()
        Me.ActifijoIITableAdapter.FillByGPS(Me.SegurosDS.ActifijoII)
        Bloquea("Cancelar")

    End Sub

    Private Sub TxtImpo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtImpo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not TxtImpo.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub GridActivos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridActivos.SelectionChanged
        If TxtidActivo.Text > "" Then
            LimpiaCampos()
            CargaDatosLOC()
        End If
    End Sub

End Class