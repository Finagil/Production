Public Class FrmSeguroAvio
    Dim Super As New SegurosDSTableAdapters.SEG_SuperficiesTableAdapter
    Dim OBSERV As New SegurosDSTableAdapters.SEG_ObservacionesAvioTableAdapter

    Private Sub FrmSeguroAvio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CiclosTableAdapter.Fill(Me.SegurosDS.Ciclos)
        Txtfiltro.Focus()
        Bloquea("CANCELAR")
    End Sub

    Private Sub Txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length >= 3 Then
            Me.ClientesTableAdapter.Fill(Me.SegurosDS.Clientes, Txtfiltro.Text)
        Else
            Me.SegurosDS.Clientes.Clear()
        End If
        CmbClientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub CmbCiclos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCiclos.SelectedIndexChanged
        If CmbCiclos.SelectedIndex >= 0 And CmbClientes.SelectedIndex >= 0 Then
            Me.AviosTableAdapter.Fill(Me.SegurosDS.Avios, CmbCiclos.SelectedValue, CmbClientes.SelectedValue)
            Me.PolAvioTableAdapter.Fill(Me.SegurosDS.PolAvio, CmbCiclos.SelectedValue)
            If CmbAnexo.SelectedIndex >= 0 Then
                CArgaDatos()
            End If
        End If
    End Sub

    Private Sub CmbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbClientes.SelectedIndexChanged
        If CmbCiclos.SelectedIndex >= 0 And CmbClientes.SelectedIndex >= 0 Then
            Me.AviosTableAdapter.Fill(Me.SegurosDS.Avios, CmbCiclos.SelectedValue, CmbClientes.SelectedValue)
            CmbCiclos_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAltaSuper.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Sub Bloquea(ByVal Mov As String)
        Select Case UCase(Mov)
            Case "ALTA"
                GroupClientes.Enabled = False
                GroupAltas.Enabled = True
                GroupBaja.Enabled = False
                GroupCambio.Enabled = False
                TxtAltaSuper.Text = ""
            Case "BAJA"
                GroupClientes.Enabled = False
                GroupAltas.Enabled = False
                GroupBaja.Enabled = True
                GroupCambio.Enabled = False
            Case "CANCELAR"
                GroupClientes.Enabled = True
                GroupAltas.Enabled = False
                GroupBaja.Enabled = False
                GroupCambio.Enabled = False
            Case "CAMBIO"
                GroupClientes.Enabled = False
                GroupAltas.Enabled = False
                GroupBaja.Enabled = False
                GroupCambio.Enabled = True
        End Select
    End Sub

    Private Sub BttAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttAlta.Click
        If TxtAltaSuper.Text = "" Then
            MessageBox.Show("Superficie no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(TxtAltaSuper.Text) <= 0 Then
            MessageBox.Show("Superficie no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CmboPOL.SelectedIndex < 0 Then
            MessageBox.Show("Falta selecionar poliza.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(TxtAltaSuper.Text) > Val(TxtHectaAnexo.Text) - Val(TxtHectaAseg.Text) And CmbAnexo.SelectedValue <> "Sin Cont." And CmbAlta.Text = "Alta" Then
            MessageBox.Show("La superfice sobrepasa las hecrarias contratadas." & vbCrLf & "Falta asegurar: " & Val(TxtHectaAnexo.Text) - Val(TxtHectaAseg.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CmbAlta.Text = "" Then
            MessageBox.Show("Movimiento no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim fecha As String = DTalta.Value.ToString("yyyyMMdd")
        Dim Monto As Double = Val(TxtAltaSuper.Text) * Val(TxtCuota.Text)
        If CmbAlta.Text = "Alta" Then
            Super.Insert(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue, TxtAltaSuper.Text, Monto, fecha, "", CmboPOL.SelectedValue, CmbClientes.SelectedValue, ChkPagado.Checked)
        Else
            Super.Insert(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue, (-1) * Val(TxtAltaSuper.Text), (-1) * Val(Monto), fecha, fecha, CmboPOL.SelectedValue, CmbClientes.SelectedValue, False)
        End If
        Bloquea("Cancelar")
        CmbCiclos_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub ButtAltCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtAltCancel.Click
        Bloquea("Cancelar")
    End Sub

    Private Sub BttAltaNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttAltaNew.Click
        Bloquea("Alta")
        CmbAlta.SelectedIndex = 0
        TxtAltaSuper.Focus()
    End Sub

    Private Sub CmbAnexo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAnexo.SelectedIndexChanged
        If CmbAnexo.SelectedIndex >= 0 Then
            TxtHectaAseg.Text = "0.0"
            TxtHectaAnexo.Text = "0.0"
            CargaDatos()
        End If
    End Sub

    Sub CargaDatos()
        'OLD Dim x As Decimal = Super.SuperficieBaja(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue, CmbClientes.SelectedValue)
        TxtHectaAseg.Text = Super.SuperficeAseg(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue, CmbClientes.SelectedValue) '- x
        TxtXaseg.Text = (Val(TxtHectaAnexo.Text) - Val(TxtHectaAseg.Text)).ToString("n2")
        Me.SuperficesAltasTableAdapter.Fill(SegurosDS.SuperficesAltas, CmbAnexo.SelectedValue, CmbCiclos.SelectedValue, CmbClientes.SelectedValue)
        Me.SuperficesBajasTableAdapter.Fill(SegurosDS.SuperficesBajas, CmbAnexo.SelectedValue, CmbCiclos.SelectedValue, CmbClientes.SelectedValue)
        TxtTA.Text = Me.SuperficesAltasTableAdapter.Total(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue, CmbClientes.SelectedValue)
        TxtTB.Text = Me.SuperficesBajasTableAdapter.Total(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue, CmbClientes.SelectedValue)
        If TxtTA.Text = "" Then TxtTA.Text = "0.0"
        If TxtTB.Text = "" Then TxtTB.Text = "0.0"
        TxtBalance.Text = (Val(TxtTA.Text) + Val(TxtTB.Text))
        TxtMinistrado.Text = Me.SuperficesAltasTableAdapter.Ministrado(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue)
        TxtNC.Text = Me.SuperficesAltasTableAdapter.NotasC(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue)
        TxtPorMinistrar.Text = Val(TxtBalance.Text) - Val(TxtMinistrado.Text)
        Me.AviosCambioTableAdapter.Fill(Me.SegurosDS.AviosCambio, CmbCiclos.SelectedValue, CmbClientes.SelectedValue)
        AviosCambioBindingSource.Filter = "Anexo <> '" & CmbAnexo.SelectedValue & "'"
        'x = Super.SuperficieBaja(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue, CmbClientes.SelectedValue)
        TxtHectaAsegC.Text = Super.SuperficeAseg(CmbAnexoCamb.SelectedValue, CmbCiclos.SelectedValue, CmbClientes.SelectedValue) '- x
        TxtXasegC.Text = Val(TxtHectaAnexoC.Text) - Val(TxtHectaAsegC.Text)
        'formato
        If Val(TxtPorMinistrar.Text) < 0 Then
            TxtPorMinistrar.BackColor = Color.Red
        Else
            TxtPorMinistrar.BackColor = SystemColors.Control
        End If
        TxtBalance.Text = Val(TxtBalance.Text).ToString("n2")
        TxtMinistrado.Text = Val(TxtMinistrado.Text).ToString("n2")
        TxtPorMinistrar.Text = Val(TxtPorMinistrar.Text).ToString("n2")
        TxtNC.Text = Val(TxtNC.Text).ToString("n2")
        Dim t As New SegurosDS.SEG_ObservacionesAvioDataTable
        OBSERV.Fill(t, CmbAnexo.SelectedValue, CmbCiclos.SelectedValue)
        If t.Rows.Count > 0 Then TxtObser.Text = t.Rows(0).Item("Observaciones") Else TxtObser.Text = ""
        t.Dispose()

        'MINISTRACIONES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        BtnMinistrar.Visible = True
        If Val(TxtPorMinistrar.Text) > 0 Then
            BtnMinistrar.Text = "Ministrar"
            BtnMinistrar.Enabled = True
            Dim ta As New SegurosDSTableAdapters.mFINAGILTableAdapter
            If ta.Pendiente(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue) > 0 Then
                BtnMinistrar.Text = "Minis. Pendiente"
                BtnMinistrar.Enabled = False
            End If
        ElseIf Val(TxtPorMinistrar.Text) = 0 Then
            BtnMinistrar.Text = "Ministrar"
            BtnMinistrar.Enabled = False
            BtnMinistrar.Visible = False
        Else
            BtnMinistrar.Text = "Nota de credito"
            BtnMinistrar.Enabled = False
        End If
        'MINISTRACIONES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CmbSuper.SelectedIndex < 0 Then
            MessageBox.Show("Falta Selecionar Superficie para baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Super.Baja(DTFecBaja.Value.ToString("yyyyMMdd"), CmbSuper.SelectedValue)
        Bloquea("Cancelar")
        CmbCiclos_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub BttBajaNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttBajaNew.Click
        Bloquea("Baja")
    End Sub

    Private Sub BttCancelBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCancelBaja.Click
        Bloquea("Cancelar")
    End Sub

    Private Sub BTTcambioNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTTcambioNew.Click
        Bloquea("Cambio")
    End Sub

    Private Sub BttCancel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCancel3.Click
        Bloquea("Cancelar")
    End Sub

    Private Sub BttCambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCambio.Click
        If CmbAnexoCamb.Items.Count <= 0 Then
            MessageBox.Show("No existen contratos para Cambio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CmbAnexo.SelectedValue = CmbAnexoCamb.SelectedValue Then
            MessageBox.Show("Falta Selecionar un contrato diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(TxtSuperCam.Text) > Val(TxtHectaAnexoC.Text) - Val(TxtHectaAsegC.Text) And CmbAnexoCamb.SelectedValue <> "Sin Cont." Then
            MessageBox.Show("La superfice sobrepasa las hecrarias contratadas." & vbCrLf & "Falta asegurar: " & Val(TxtHectaAnexo.Text) - Val(TxtHectaAseg.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Super.CambioAnexo(CmbAnexoCamb.SelectedValue, CmbSuper2.SelectedValue)
        Bloquea("Cancelar")
        CmbCiclos_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub TxtHectaAnexo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHectaAnexo.TextChanged
        If CmbAnexo.SelectedIndex >= 0 Then
            CargaDatos()
        End If
    End Sub

    Private Sub TxtHectaAnexoC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHectaAnexoC.TextChanged
        TxtHectaAsegC.Text = Super.SuperficeAseg(CmbAnexoCamb.SelectedValue, CmbCiclos.SelectedValue, CmbClientes.SelectedValue) '- x
        TxtXasegC.Text = Val(TxtHectaAnexoC.Text) - Val(TxtHectaAsegC.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OBSERV.ScalarAnexo(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue) > 0 Then
            OBSERV.UpdateAnexo(UCase(Trim(TxtObser.Text)), CmbAnexo.SelectedValue, CmbCiclos.SelectedValue)
        Else
            OBSERV.Insert(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue, CmbClientes.SelectedValue, UCase(Trim(TxtObser.Text)))
        End If
        TxtObser.Text = UCase(Trim(TxtObser.Text))
    End Sub

    Private Sub BtnMinistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinistrar.Click
        Dim Garantia As Decimal = 0
        Dim Fega As Decimal = 0
        Dim Xministrar As Decimal = TxtPorMinistrar.Text
        If TxtFondeo.Text = "03" Then
            Garantia = Xministrar * 0.1
            Fega = CalculaFEGA(Xministrar, AviosBindingSource.Current("FegaFlat"), AviosBindingSource.Current("FechaTerminacion"), AviosBindingSource.Current("AplicaFecga"), AviosBindingSource.Current("PorcFega"), CmbClientes.SelectedValue)
        End If
        Dim ta As New SegurosDSTableAdapters.mFINAGILTableAdapter
        Dim fec As String = Date.Now.ToString("yyyyMMdd")
        If Val(TxtPorMinistrar.Text) > 0 Then
            Dim x As Integer = ta.SigMinistracion(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue)
            ta.Insert(CmbAnexo.SelectedValue, CmbCiclos.SelectedValue, x, fec, fec, Xministrar,
             Garantia, "SEGURO", fec, Xministrar, Xministrar * Garantia, "", "N", False, "SEGUROS", Fega)
        Else

        End If
        ta.Dispose()
        CmbCiclos_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CmbAnexo.SelectedIndex >= 0 Then
            Dim f As New FrmAtachments
            f.Anexo = AviosBindingSource.Current("Anexo")
            f.Ciclo = AviosBindingSource.Current("Ciclo")
            f.Carpeta = "Seguros"
            f.Consulta = False
            f.Nombre = CmbClientes.Text
            If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            End If
        End If
    End Sub
End Class