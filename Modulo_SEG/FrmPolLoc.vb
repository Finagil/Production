Public Class FrmPolLoc

    Dim LOC As New SegurosDSTableAdapters.SEG_LocalizadoresTableAdapter


    Private Sub Txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length >= 3 Then
            Me.ClientesTableAdapter.Fill(Me.SegurosDS.Clientes, Txtfiltro.Text)
            If Me.SegurosDS.Clientes.Rows.Count > 0 Then
                CmbClientes_SelectedIndexChanged(Nothing, Nothing)
            Else
                Me.ActifijoTableAdapter.Fill(Me.SegurosDS.Actifijo, 0)
                Me.SEG_PolizasBienesTableAdapter.Fill(Me.SegurosDS.SEG_PolizasBienes, 0)
                Me.SegurosDS.Anexos.Clear()
            End If
        Else
            Me.SegurosDS.Clientes.Clear()
            Me.SegurosDS.Anexos.Clear()
        End If
    End Sub

    Private Sub CmbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbClientes.SelectedIndexChanged
        If CmbClientes.SelectedIndex >= 0 Then
            Me.AnexosTableAdapter.FillMasCC(Me.SegurosDS.Anexos, CmbClientes.SelectedValue)
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
                GroupLOC.Enabled = False
                GridPolizas.Enabled = False
            Case "LOCALIZADOR"
                GroupClientes.Enabled = False
                GroupDatos.Enabled = False
                GroupLOC.Enabled = True
                GridPolizas.Enabled = False
            Case "CANCELAR"
                GroupClientes.Enabled = True
                GroupDatos.Enabled = False
                GroupLOC.Enabled = False
                GridPolizas.Enabled = True
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
        GeneraPolizasLuquidez()
        Me.SEG_AseguradorasCopyTableAdapter.Fill(Me.SegurosDS.SEG_AseguradorasCopy)
        Me.SEG_AseguradorasTableAdapter.Fill(Me.SegurosDS.SEG_Aseguradoras)
        Bloquea("Cancelar")
    End Sub

    Private Sub BttLOCNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttLOCNew.Click
        If TxtStatus.Text = "" Then
            MessageBox.Show("Sin contratos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtStatus.Text <> "Activo" Then
            MessageBox.Show("Contrato no activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.SegurosDS.Actifijo.Rows.Count > 0 Then
            Dim t As New SegurosDS.SEG_LocalizadoresDataTable
            LOC.Fill(t, TxtidActivo.Text)
            If t.Rows.Count <= 0 Then
                TxtidCli.Text = Mid(CmbAnexo.Text, 1, 10) & "-" & Microsoft.VisualBasic.Right(Trim(TxtSerie.Text), 4)
            End If
            Bloquea("Localizador")
        End If
    End Sub

    Private Sub BttAltaNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttAltaNew.Click
        If TxtStatus.Text = "" Then
            MessageBox.Show("Sin contratos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If AnexosBindingSource.Current("flcan") = "W" Then
            If MessageBox.Show("El contrato esta TERMIANDO CON SALDO, ¿Deseas agregar la poliza?", "Terminado con Saldo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Exit Sub
            End If
        ElseIf AnexosBindingSource.Current("flcan") <> "A" And AnexosBindingSource.Current("flcan") <> "F" Then
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
            MessageBox.Show("Cuota no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtTotal.Text = "" Then
            MessageBox.Show("Suma Asegurada no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If BttAlta.Text = "Guardar" And IsNothing(SEGPolizasBienesBindingSource.Current) Then
            MessageBox.Show("No se ha selecionado poliza.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim Hoy As String = Today.ToString("yyyyMMdd")
        If BttAlta.Text = "Guardar" And DtFin.Value.ToString("yyyyMMdd") < Hoy Then
            MessageBox.Show("Poliza Terminada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If BttAlta.Text = "Guardar" Then
            Me.SEG_PolizasBienesTableAdapter.UpdatePoliza(CmbTipo.Text, DTini.Value.ToString("yyyyMMdd"), DtFin.Value.ToString("yyyyMMdd"), Val(TxtPrima.Text),
                        Val(TxtTotal.Text), DTpag.Value.ToString("yyyyMMdd"), CmbAseg.SelectedValue, UCase(TxtPol.Text), UCase(Txtobserv.Text), SEGPolizasBienesBindingSource.Current("Id_poliza"))
        Else
            Me.SEG_PolizasBienesTableAdapter.InsertPoliza(CmbTipo.Text, DTini.Value.ToString("yyyyMMdd"), DtFin.Value.ToString("yyyyMMdd"), Val(TxtPrima.Text),
            Val(TxtTotal.Text), DTpag.Value.ToString("yyyyMMdd"), CmbAseg.SelectedValue, Val(TxtidActivo.Text), UCase(TxtPol.Text), UCase(Txtobserv.Text), "NO", "NO", "NO")
        End If
        Me.ActifijoTableAdapter.UpdateVigencia(DTini.Value.ToString("yyyyMMdd"), DtFin.Value.ToString("yyyyMMdd"), Val(TxtidActivo.Text))

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
            Me.SEG_PolizasBienesTableAdapter.Fill(Me.SegurosDS.SEG_PolizasBienes, TxtidActivo.Text)
            CargaDatosPOL()
            CargaDatosLOC()
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
            LOC.Update(CmbAeg2.SelectedValue, TxtidCli.Text, UCase(TxtFactura.Text), TxtImpo.Text, DTTermina.Value.ToString("yyyyMMdd"), DTsolic.Value.ToString("yyyyMMdd"),
            DtInstall.Value.ToString("yyyyMMdd"), DTpago.Value.ToString("yyyyMMdd"), UCase(Txtendoso.Text), Cmbplataforma.Text, TxtidActivo.Text, TxtIDloc.Text)
        Else
            LOC.Insert(CmbAeg2.SelectedValue, TxtidCli.Text, UCase(TxtFactura.Text), TxtImpo.Text, DTTermina.Value.ToString("yyyyMMdd"), DTsolic.Value.ToString("yyyyMMdd"),
            DtInstall.Value.ToString("yyyyMMdd"), DTpago.Value.ToString("yyyyMMdd"), UCase(Txtendoso.Text), Cmbplataforma.Text, TxtidActivo.Text)
        End If
        Bloquea("Cancelar")

    End Sub

    Private Sub BttDevol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttDevol.Click
        If TxtStatus.Text = "" Then
            MessageBox.Show("Sin contratos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtStatus.Text <> "Activo" Then
            MessageBox.Show("Contrato no activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CmbAnexo.SelectedIndex >= 0 Then
            Dim pol As New SegurosDSTableAdapters.PolizasBienesTableAdapter
            Dim t As New SegurosDS.PolizasBienesDataTable
            pol.Fill(t, CmbAnexo.SelectedValue)
            If t.Rows.Count > 0 Then
                Dim f As New FrmSiniestrosBienes
                f.Anexo = CmbAnexo.SelectedValue
                f.Text = f.Text & " Anexo: " & CmbAnexo.SelectedText & "(" & Trim(CmbClientes.Text) & ")"
                f.Show()
            Else
                MessageBox.Show("No existen polizas de este contrato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Falta selecionar Anexo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TxtImpo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtImpo.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub BttModPol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttModPol.Click
        If TxtStatus.Text = "" Then
            MessageBox.Show("Sin contratos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtStatus.Text <> "Activo" Then
            MessageBox.Show("Contrato no activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.SegurosDS.Actifijo.Rows.Count > 0 Then
            If IsNothing(SEGPolizasBienesBindingSource.Current) Then
                MessageBox.Show("No existen polizas para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Bloquea("Poliza")
                CargaDatosPOL()
                BttAlta.Text = "Guardar"
            End If

        End If
    End Sub

    Sub CargaDatosPOL()
        If Not IsNothing(SEGPolizasBienesBindingSource.Current) Then
            Dim t As New SegurosDS.SEG_PolizasBienesDataTable
            Dim pol As New SegurosDSTableAdapters.SEG_PolizasBienesTableAdapter
            pol.FillByPoliza(t, SEGPolizasBienesBindingSource.Current("Id_poliza"))
            For Each r As SegurosDS.SEG_PolizasBienesRow In t.Rows
                TxtPol.Text = r.Poliza
                CmbTipo.Text = r.Tipo
                DTini.Value = CTOD(r.FechaInicia)
                DtFin.Value = CTOD(r.FechaTermina)
                DTpag.Value = CTOD(r.FecLimPago)
                TxtPrima.Text = r.Prima
                TxtTotal.Text = r.Total
                Txtobserv.Text = r.Observaciones
                CmbAseg.Text = Me.SEG_AseguradorasTableAdapter.ScalarAseg(r.idAseguradora)
            Next
        End If
    End Sub

    Private Sub GridPolizas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        CargaDatosPOL()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CmbAnexo.SelectedIndex >= 0 Then
            Dim f As New FrmAtachments
            f.Anexo = AnexosBindingSource.Current("Anexo")
            f.Ciclo = ""
            f.Carpeta = "Seguros"
            If TaQUERY.SacaPermisoModulo("SEGUROS_DOC", UsuarioGlobal) > 0 Then
                f.Consulta = False
            Else
                f.Consulta = True
            End If
            f.Nombre = CmbClientes.Text
            If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            End If
        End If
    End Sub

    Private Sub GridPolizas_DoubleClick(sender As Object, e As EventArgs) Handles GridPolizas.DoubleClick
        If Not IsNothing(Me.SEGPolizasBienesBindingSource.Current()) Then
            If MessageBox.Show("¿Estas Seguro de Borrar la poliza selecionada?", "Borra Solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                Me.SEG_PolizasBienesTableAdapter.DeletePoliza(Me.SEGPolizasBienesBindingSource.Current("Id_poliza"))
                Me.SEG_PolizasBienesTableAdapter.Fill(Me.SegurosDS.SEG_PolizasBienes, TxtidActivo.Text)
            End If
        Else
            MessageBox.Show("No hay datos para Borrar.", "Borra Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub BtnProx_Click(sender As Object, e As EventArgs) Handles BtnProx.Click
        If TxtStatus.Text = "" Then
            MessageBox.Show("Sin contratos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("¿Esta seguro de enviar el correo de PROXIMO A VENCER?", "Correo PROXIMO A VENCER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Exit Sub
        End If
        If Me.SegurosDS.Actifijo.Rows.Count > 0 Then
            If IsNothing(SEGPolizasBienesBindingSource.Current) Then
                MessageBox.Show("No existen poliza selecionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                GeneraCorreoSEG("PROXIMA")
            End If
        End If
    End Sub

    Private Sub BtnRenov_Click(sender As Object, e As EventArgs) Handles BtnRenov.Click
        If TxtStatus.Text = "" Then
            MessageBox.Show("Sin contratos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("¿Esta seguro de enviar el correo de RENOVACION?", "Correo RENOVACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Exit Sub
        End If
        If Me.SegurosDS.Actifijo.Rows.Count > 0 Then
            If IsNothing(SEGPolizasBienesBindingSource.Current) Then
                MessageBox.Show("No existen poliza selecionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                GeneraCorreoSEG("RENOVACION")
            End If
        End If
    End Sub

    Private Sub BtTermina_Click(sender As Object, e As EventArgs) Handles BtTermina.Click
        If TxtStatus.Text = "" Then
            MessageBox.Show("Sin contratos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("¿Esta seguro de enviar el correo de TERMINACION?", "Correo TERMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Exit Sub
        End If
        If Me.SegurosDS.Actifijo.Rows.Count > 0 Then
            MessageBox.Show("No existen Activo selecionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            GeneraCorreoSEG("TERMINACION")
        End If
    End Sub

    Sub GeneraCorreoSEG(TipoCorreo As String)
        Cursor.Current = Cursors.WaitCursor
        Dim Asunto As String = ""
        Dim Att As String = ""

        If TipoCorreo.ToUpper = "RENOVACION" Then
            Att = NOTIFICACION_RENOVACION_POLIZA(ClientesBindingSource.Current("Descr"), ActifijoBindingSource.Current("Serie"), CTOD(SEGPolizasBienesBindingSource.Current("FechaTermina")),
                    AnexosBindingSource.Current("TipoCredito"), AnexosBindingSource.Current("AnexoCon"))
            Asunto = "AVISO DE RENOVACIÓN DE POLIZA DE SEGURO: " & Me.AnexosBindingSource.Current("AnexoCon")
        ElseIf TipoCorreo.ToUpper = "TERMINACION" Then
            Att = AVISO_TERMINACIÓN_CONTRATO(ClientesBindingSource.Current("Descr"), ActifijoBindingSource.Current("Serie"), CTOD(TaQUERY.UltimoPago(AnexosBindingSource.Current("Anexo"))),
                    AnexosBindingSource.Current("TipoCredito"), AnexosBindingSource.Current("AnexoCon"))
            Asunto = "AVISO DE VENCIMIENTO DE PÓLIZA DE SEGURO: " & Me.AnexosBindingSource.Current("AnexoCon")
        ElseIf TipoCorreo.ToUpper = "PROXIMA" Then
            Att = NOTIFICACION_PROXIMA_VENCER(ClientesBindingSource.Current("Descr"), ActifijoBindingSource.Current("Serie"), CTOD(SEGPolizasBienesBindingSource.Current("FechaTermina")),
                    AnexosBindingSource.Current("TipoCredito"), AnexosBindingSource.Current("AnexoCon"))
            Asunto = "AVISO DE VENCIMIENTO DE PÓLIZA DE SEGURO: " & Me.AnexosBindingSource.Current("AnexoCon")
        End If
        Dim Mensaje As String = ""
        Mensaje += "Cliente: " & Me.ClientesBindingSource.Current("Descr") & "<br>"
        Mensaje += "Contrato: " & Me.AnexosBindingSource.Current("AnexoCon") & "<br>"
        Mensaje += "Serie: " & Me.ActifijoBindingSource.Current("Serie") & "<br>"

        MandaCorreoANEXO(Me.AnexosBindingSource.Current("Anexo"), Asunto, Mensaje, True, False, Att)
        MandaCorreoFase(UsuarioGlobalCorreo, "SEGUROS", Asunto, Mensaje, Att)
        MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", Asunto, Mensaje, Att)
        Cursor.Current = Cursors.Default
        MessageBox.Show("Correo Enviado", "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class