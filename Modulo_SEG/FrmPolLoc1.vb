Public Class FrmPolLoc1

    Dim LOC As New SegurosDSTableAdapters.SEG_LocalizadoresTableAdapter


    Private Sub Txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length >= 3 Then
            Me.ClientesTableAdapter.Fill(Me.SegurosDS.Clientes, Txtfiltro.Text)
            If Me.SegurosDS.Clientes.Rows.Count > 0 Then
                CmbClientes_SelectedIndexChanged(Nothing, Nothing)
            Else
                Me.ActifijoTableAdapter.Fill(Me.SegurosDS.Actifijo, 0)
                Me.SEG_PolizasBienesTableAdapter.Fill(Me.SegurosDS.SEG_PolizasBienes, 0)
            End If
        Else
            Me.SegurosDS.Clientes.Clear()
        End If
    End Sub

    Private Sub CmbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbClientes.SelectedIndexChanged
        If CmbClientes.SelectedIndex >= 0 Then
            Me.AnexosTableAdapter.Fill(Me.SegurosDS.Anexos, CmbClientes.SelectedValue)
            CmbAnexo_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub CmbAnexo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAnexo.SelectedIndexChanged
        Me.SegurosDS.Actifijo.Clear()
        If CmbAnexo.SelectedIndex >= 0 Then
            LimpiaCampos()
            Me.ActifijoTableAdapter.Fill(Me.SegurosDS.Actifijo, CmbAnexo.SelectedValue)
            If GridActivos.Rows.Count > 0 Then
                GridActivos.Rows(0).Selected = True
            End If
        End If
    End Sub

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
        CmbTipo.SelectedIndex = 0
        CmbAseg.SelectedIndex = 0
        CmbUdi.SelectedIndex = 0
        CmbGPS.SelectedIndex = 0
        Me.SegurosDS.SEG_PolizasBienes.Clear()
    End Sub

    Private Sub FrmPolLoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GeneraPolizasLuquidez()
        Me.SEG_AseguradorasCopyTableAdapter.Fill(Me.SegurosDS.SEG_AseguradorasCopy)
        Me.SEG_AseguradorasTableAdapter.Fill(Me.SegurosDS.SEG_Aseguradoras)
        Bloquea("Cancelar")
    End Sub

    Private Sub BttAltaNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttAltaNew.Click
        If TxtStatus.Text = "" Then
            MessageBox.Show("Sin contratos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtStatus.Text <> "Activo" Then
            MessageBox.Show("Contrato no activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.SegurosDS.Actifijo.Rows.Count > 0 Then
            LimpiaCampos()
            Bloquea("Poliza")
            BttAlta.Text = "Alta"
        End If
    End Sub

    Private Sub ButtAltCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttAltCancel.Click
        Bloquea("Cancelar")
    End Sub

    Private Sub BttAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttAlta.Click
        If CmbTipo.Text = "" Then
            MessageBox.Show("Tipo no valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CmbAseg.Text = "" Then
            MessageBox.Show("Seguradora no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        'If BttAlta.Text = "Guardar" Then
        '    Me.SEG_PolizasBienesTableAdapter.UpdatePolizaII(CmbTipo.Text, "19000101", "19000101", 0, _
        '    0, "19000101", CmbAseg.SelectedValue, "", UCase(Txtobserv.Text), Udi, CmbGPS.Text, TxtIdpol.Text)
        'Else
        Me.SEG_PolizasBienesTableAdapter.InsertPolizaII(CmbTipo.Text, "19000101", "19000101", 0, _
        0, "19000101", CmbAseg.SelectedValue, Val(TxtidActivo.Text), "", UCase(Txtobserv.Text), Udi, CmbGPS.Text, "NO", "NO")
        'End If
        Bloquea("Cancelar")
    End Sub

    Private Sub GridActivos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridActivos.SelectionChanged
        If TxtidActivo.Text > "" Then
            LimpiaCampos()
            Me.SEG_PolizasBienesTableAdapter.Fill(Me.SegurosDS.SEG_PolizasBienes, TxtidActivo.Text)
            CargaDatosPOL()
        End If
    End Sub

    Sub CargaDatosPOL()
        If TxtIdpol.Text <> "" Then
            Dim t As New SegurosDS.SEG_PolizasBienesDataTable
            Dim pol As New SegurosDSTableAdapters.SEG_PolizasBienesTableAdapter
            pol.FillByPoliza(t, TxtIdpol.Text)
            For Each r As SegurosDS.SEG_PolizasBienesRow In t.Rows
                CmbTipo.Text = r.Tipo
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