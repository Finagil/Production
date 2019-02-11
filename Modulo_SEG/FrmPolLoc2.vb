Public Class FrmPolLoc2

    Dim LOC As New SegurosDSTableAdapters.SEG_LocalizadoresTableAdapter

    Sub Bloquea(ByVal Mov As String)
        Select Case UCase(Mov)
            Case "POLIZA"
                GroupClientes.Enabled = False
                GroupDatos.Enabled = True
            Case "LOCALIZADOR"
                GroupClientes.Enabled = False
                GroupDatos.Enabled = False
            Case "CANCELAR"
                GroupClientes.Enabled = True
                GroupDatos.Enabled = False
                LimpiaCampos()
                GridActivos_SelectionChanged(Nothing, Nothing)
        End Select
    End Sub

    Sub LimpiaCampos()
        TxtPol.Text = ""
        CmbTipo.SelectedIndex = 0
        DTini.Value = Today
        DtFin.Value = Today
        DTpag.Value = Today
        TxtPrima.Text = ""
        TxtTotal.Text = ""
        CmbAseg.SelectedIndex = 0
        Me.SegurosDS.SEG_PolizasBienes.Clear()
    End Sub

    Private Sub FrmPolLoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SEG_AseguradorasCopyTableAdapter.Fill(Me.SegurosDS.SEG_AseguradorasCopy)
        Me.SEG_AseguradorasTableAdapter.Fill(Me.SegurosDS.SEG_Aseguradoras)
        GeneraPolizasLuquidez()
        Me.ActifijoIITableAdapter.FillPendientes(Me.SegurosDS.ActifijoII)
        Bloquea("Cancelar")
    End Sub


    Private Sub ButtAltCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttAltCancel.Click
        Bloquea("Cancelar")
    End Sub

    Private Sub BttAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttAlta.Click
        If TxtPol.Text = "" Then
            MessageBox.Show("Poliza no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CmbTipo.Text = "" Then
            MessageBox.Show("Tipo no valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CmbAseg.Text = "" Then
            MessageBox.Show("Seguradora no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtPrima.Text = "" Then
            MessageBox.Show("Prima no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(TxtPrima.Text) <= 0 Then
            MessageBox.Show("Prima no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtTotal.Text = "" Then
            MessageBox.Show("Suma Asegurada no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(TxtTotal.Text) <= 0 Then
            MessageBox.Show("Suma Asegurada no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If BttAlta.Text = "Guardar" And TxtIdpol.Text = "" Then
            MessageBox.Show("No se ha selecionado poliza.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim Hoy As String = Today.ToString("yyyyMMdd")
        Dim Udi As Decimal = 0
        If CmbUdi.Text = "10%" Then
            Udi = 0.1
        Else
            Udi = 0.15
        End If
        If BttAlta.Text = "Guardar" And DtFin.Value.ToString("yyyyMMdd") < Hoy Then
            MessageBox.Show("Poliza Terminada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If BttAlta.Text = "Guardar" Then
            Me.SEG_PolizasBienesTableAdapter.UpdatePolizaII(CmbTipo.Text, DTini.Value.ToString("yyyyMMdd"), DtFin.Value.ToString("yyyyMMdd"), Val(TxtPrima.Text), _
                        Val(TxtTotal.Text), DTpag.Value.ToString("yyyyMMdd"), CmbAseg.SelectedValue, UCase(TxtPol.Text), UCase(Txtobserv.Text), Udi, CmbGPS.Text, "NO", "NO", TxtIdpol.Text)
        End If
        Me.ActifijoIITableAdapter.UpdateVigencia(DTini.Value.ToString("yyyyMMdd"), DtFin.Value.ToString("yyyyMMdd"), Val(TxtidActivo.Text))
        Me.ActifijoIITableAdapter.FillPendientes(Me.SegurosDS.ActifijoII)
        Bloquea("Cancelar")
    End Sub

    Private Sub TxtPrima_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrima.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TxtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTotal.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub GridActivos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridActivos.SelectionChanged
        If TxtidActivo.Text > "" Then
            LimpiaCampos()
            Me.SEG_PolizasBienesTableAdapter.FillByPendientes(Me.SegurosDS.SEG_PolizasBienes, TxtidActivo.Text)
            CargaDatosPOL()
        End If
    End Sub

    Private Sub BttCancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Bloquea("Cancelar")
    End Sub

    Private Sub BttModPol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttModPol.Click
        If Me.SegurosDS.ActifijoII.Rows.Count > 0 Then
            If TxtIdpol.Text = "" Then
                MessageBox.Show("No existen polizas para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Bloquea("Poliza")
                CargaDatosPOL()
                BttAlta.Text = "Guardar"
            End If
        End If
    End Sub

    Sub CargaDatosPOL()
        If TxtIdpol.Text <> "" Then
            Dim t As New SegurosDS.SEG_PolizasBienesDataTable
            Dim pol As New SegurosDSTableAdapters.SEG_PolizasBienesTableAdapter
            pol.FillByPoliza(t, TxtIdpol.Text)
            For Each r As SegurosDS.SEG_PolizasBienesRow In t.Rows
                TxtPol.Text = r.Poliza
                CmbTipo.Text = r.Tipo
                DTini.Value = CTOD(r.FechaInicia)
                DtFin.Value = CTOD(r.FechaTermina)
                DTpag.Value = CTOD(r.FecLimPago)
                TxtPrima.Text = r.Prima
                TxtTotal.Text = r.Total
                Txtobserv.Text = r.Observaciones
                CmbGPS.Text = r.GPS
                If r.PorcentajeUdi = 0.1 Then
                    CmbUdi.SelectedIndex = 0
                Else
                    CmbUdi.SelectedIndex = 1
                End If
                CmbAseg.Text = Me.SEG_AseguradorasTableAdapter.ScalarAseg(r.idAseguradora)
            Next
        End If
    End Sub

    Private Sub GridPolizas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        CargaDatosPOL()
    End Sub

End Class