Public Class FrmLineasCredito
    Private Sub FrmLineasCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CRED_CatalogoEstatusTableAdapter.Fill(Me.CreditoDS.CRED_CatalogoEstatus)
        Me.GEN_CultivosTableAdapter.Fill(Me.SegurosDS.GEN_Cultivos)
        Me.CiclosTableAdapter.FillByVigentes(Me.SegurosDS.Ciclos)
        Me.ContClie1TableAdapter.Fill(Me.ProductionDataSet.ContClie1)
        SacaLineas()
    End Sub

    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            ContClie1BindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
        Else
            ContClie1BindingSource.Filter = ""
        End If
    End Sub

    Private Sub TxtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMonto.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Sub SacaLineas()
        If CmbCliente.SelectedIndex >= 0 And CmbCiclo.SelectedIndex >= 0 And CmbCultivo.SelectedIndex >= 0 Then
            Me.CRED_LineasCreditoTableAdapter.Fill(Me.CreditoDS.CRED_LineasCredito, CmbCliente.SelectedValue, CmbCiclo.SelectedValue, CmbCultivo.SelectedValue)
            If Me.CreditoDS.CRED_LineasCredito.Rows.Count > 0 Then
                If Me.CREDLineasCreditoBindingSource.Current("ESTATUS") = 1 Then ' SOLO MODIFICAR LOS PENDIETES
                    GRPdATOS.Enabled = True
                Else
                    GRPdATOS.Enabled = False
                End If
            Else
                GRPdATOS.Enabled = False
            End If
        Else
            GRPdATOS.Enabled = False
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If Me.CRED_LineasCreditoTableAdapter.TieneVigentesPendientes(CmbCliente.SelectedValue, CmbCiclo.SelectedValue, CmbCultivo.SelectedValue, 1, 2) <= 0 Then ' 2 es vigente
            Me.CREDLineasCreditoBindingSource.AddNew()
            Me.CREDLineasCreditoBindingSource.Current("Cliente") = CmbCliente.SelectedValue
            Me.CREDLineasCreditoBindingSource.Current("Ciclo") = CmbCiclo.SelectedValue
            Me.CREDLineasCreditoBindingSource.Current("idCultivo") = CmbCultivo.SelectedValue
            Me.CREDLineasCreditoBindingSource.Current("MontoLinea") = 0
            Me.CREDLineasCreditoBindingSource.Current("Fechaalta") = Date.Now
            Me.CREDLineasCreditoBindingSource.Current("FechaModif") = Date.Now
            Me.CREDLineasCreditoBindingSource.Current("Vigencia") = Date.Now
            Me.CREDLineasCreditoBindingSource.Current("TIPOLINEA") = "AVIO"
            Me.CREDLineasCreditoBindingSource.Current("USUARIO") = UsuarioGlobal
            Me.CREDLineasCreditoBindingSource.Current("ESTATUS") = 1 ' NACE pENDIENTE
            GRPdATOS.Enabled = True
        Else
            MessageBox.Show("El cliente tiene línea vigente.", "Lineas Avío", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CmbCiclo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCiclo.SelectedIndexChanged
        SacaLineas()
    End Sub

    Private Sub CmbCultivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCultivo.SelectedIndexChanged
        SacaLineas()
    End Sub

    Private Sub CmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCliente.SelectedIndexChanged
        SacaLineas()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.CREDLineasCreditoBindingSource.Current("FechaModif") = Date.Now
            Me.CREDLineasCreditoBindingSource.EndEdit()
            Me.CRED_LineasCreditoTableAdapter.Update(Me.CreditoDS.CRED_LineasCredito)
            SacaLineas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class