Public Class FrmLineasCreditoJUR
    Dim Ampliacion As String = ""
    Private Sub FrmLineasCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CRED_CatalogoEstatusTableAdapter.Fill(Me.CreditoDS.CRED_CatalogoEstatus)
        Me.GEN_CultivosTableAdapter.Fill(Me.SegurosDS.GEN_Cultivos)
        Me.CiclosTableAdapter.FillconCC(Me.SegurosDS.Ciclos)
        Me.ContClie1TableAdapter.FillByConLineaCC_Factor(Me.ProductionDataSet.ContClie1)
        Me.GENCultivosBindingSource.Filter = "idCultivo = 9"
        Me.CiclosBindingSource.Filter = "Ciclo = '00' or Ciclo = 'XX'"
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
                If Me.CREDLineasCreditoBindingSource.Current("ESTATUS") = 1 Then ' SOLO MODIFICAR LOS PENDIENTES
                    GRPdATOS.Enabled = True
                Else
                    GRPdATOS.Enabled = False
                End If
            Else
                GRPdATOS.Enabled = False
            End If
            If CmbCiclo.Text = "Factoraje" And Cmblineas.SelectedValue > 0 Then ' indice 1 Factoraje
                BtnFactor.Enabled = True
            Else
                BtnFactor.Enabled = False
            End If
        Else
            BtnFactor.Enabled = False
            GRPdATOS.Enabled = False
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

    Private Sub BtnFactor_Click(sender As Object, e As EventArgs) Handles BtnFactor.Click
        Dim f As New FrmCRED_FechasFactoraje
        f.Id_linea = Cmblineas.SelectedValue
        f.TextNombre.Text = Trim(CmbCliente.Text)
        f.Show()
    End Sub
End Class