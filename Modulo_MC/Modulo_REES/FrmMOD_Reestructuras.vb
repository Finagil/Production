Public Class FrmMOD_Reestructuras
    Dim PorcCapital As Decimal = 0
    Private Sub FrmCambioTasa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesConAdeudoTableAdapter.Fill(Me.ReestructDS.ClientesConAdeudo)
        ComboCli.SelectedIndex = 0
        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            ClientesConAdeudoBindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
            ComboBox1_SelectedIndexChanged(Nothing, Nothing)
        Else
            ClientesConAdeudoBindingSource.Filter = ""
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCli.SelectedIndexChanged
        If ComboCli.SelectedIndex >= 0 Then
            Me.AnexosConAdeudoTableAdapter.Fill(Me.ReestructDS.AnexosConAdeudo, False, ComboCli.SelectedValue)
            If Me.ReestructDS.AnexosConAdeudo.Count > 0 Then
                ComboAnexo.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub AnexosConAdeudoBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles AnexosConAdeudoBindingSource.CurrentChanged
        If Not IsNothing(AnexosConAdeudoBindingSource.Current) Then
            Me.AnexosTableAdapter.Fill(Me.ReestructDS.Anexos, AnexosConAdeudoBindingSource.Current("Anexo"), AnexosConAdeudoBindingSource.Current("Ciclo"))
            If AnexosBindingSource.Current("SaldoInsoluto") > 0 Then
                PorcCapital = 1 - (AnexosBindingSource.Current("SaldoInsoluto") / AnexosBindingSource.Current("MontoFinanciado"))
            End If
            TxtCapPag.Text = (PorcCapital * 100).ToString("n2")
        Else
            Me.ReestructDS.Anexos.Clear()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If RBAsociar.Checked = False And RBOtros.Checked = False And RBPlazo.Checked = False And RBTasaMAS.Checked = False And RBTasaMENOS.Checked = False Then
            MessageBox.Show("Debe escoger una opción para restructurar", "Reestructura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim NvoReestructura As String = "S"
        Dim NvoEstatus As String = "VIGENTE"


        If TxtEstatus.Text = "VENCIDA" Then
            MessageBox.Show("No se puede Reestructurar credito que esta en Cartera Vencida.", "Reestructura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If AnexosBindingSource.Current("SaldoInsoluto") > 0 Then
            PorcCapital = 1 - (AnexosBindingSource.Current("SaldoInsoluto") / AnexosBindingSource.Current("MontoFinanciado"))
        End If


        If AnexosBindingSource.Current("Tipar") = "H" Or AnexosBindingSource.Current("Tipar") = "A" Or AnexosBindingSource.Current("Tipar") = "C" Then
            If RBOtros.Checked = True Then
                MessageBox.Show("No se puede agregar otros adeudos para Avío o cuenta corriente.", "Reestructura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If AnexosBindingSource.Current("FechaTerminacionAV") >= Today.ToString("yyyyMMdd") Then 'VIGENTE
                If RBTasaMAS.Checked = True Or RBPlazo.Checked = True Then
                    NvoEstatus = "VENCIDA"
                    'se genera la reestructura
                    GeneraREESTRUCTURA(NvoEstatus, NvoReestructura)
                ElseIf RBTasaMENOS.Checked = True Then
                    'se genera la reestructura
                    GeneraREESTRUCTURA(NvoEstatus, NvoReestructura)
                ElseIf RBAsociar.Checked = True Then
                    NvoEstatus = "VENCIDA"
                    'se genera la reestructura
                    GeneraREESTRUCTURA(NvoEstatus, NvoReestructura)
                End If

            Else 'VENCIDO
                NvoEstatus = "VENCIDA"
                If RBAsociar.Checked = True Then
                    'se genera la reestructura
                    GeneraREESTRUCTURA(NvoEstatus, NvoReestructura)
                Else
                    MessageBox.Show("No se puede Reestructurar credito Vencido.", "Reestructura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        Else
            If Val(TxtSaldoFact.Text) <= 0 Then 'SIN FACTURAS VENCIDAS
                If Val(TxtPlazoTrans.Text) / 100 <= 0.8 Then
                    'se genera la reestructura sin cambios en el contrao
                    GeneraREESTRUCTURA(NvoEstatus, NvoReestructura)
                Else
                    If PorcCapital <= 0.6 Then
                        'se genera la reestructura
                        NvoEstatus = "VENCIDA"
                        GeneraREESTRUCTURA(NvoEstatus, NvoReestructura)
                    Else
                        'se genera la reestructura.
                        GeneraREESTRUCTURA(NvoEstatus, NvoReestructura)
                    End If
                End If
            Else ' CON ADEUDOS
                'se genera la reestructura
                NvoEstatus = "VENCIDA"
                GeneraREESTRUCTURA(NvoEstatus, NvoReestructura)
            End If
        End If
    End Sub

    Sub GeneraREESTRUCTURA(ByVal NvoEstatus As String, ByVal NvoReestructura As String)

        If RBTasaMENOS.Checked = True Or RBTasaMAS.Checked = True Then
            Dim f As New FrmCambioTasa
            f.Text += " " & ComboAnexo.Text & " - " & ComboCli.Text.Trim
            f.TxtTasa.Text = TxtTasa.Text
            f.TxtDif.Text = TxtDif.Text
            f.TxtTipoTasa.Text = TxtTipoTasa.Text
            f.NvoEstatus = NvoEstatus
            f.NvoReestructura = NvoReestructura
            f.Anexo = AnexosBindingSource.Current("Anexo")
            f.Ciclo = AnexosBindingSource.Current("Ciclo")
            f.Tipar = AnexosBindingSource.Current("Tipar")
            f.TasaIVACliente = AnexosBindingSource.Current("TasaIVACliente")
            If RBTasaMAS.Checked = True Then
                f.CambTasa = "+"
            Else
                f.CambTasa = "-"
            End If
            If f.ShowDialog() = DialogResult.Yes Then
                Me.Dispose()
            End If
        End If

        If RBAsociar.Checked = True Then
            Dim f As New FrmAsociarNew
            f.Cliente = ComboCli.SelectedValue
            f.Anexo = AnexosBindingSource.Current("Anexo")
            f.Ciclo = AnexosBindingSource.Current("Ciclo")
            f.Text += " " & ComboAnexo.Text & " - " & ComboCli.Text.Trim
            f.NvoEstatus = NvoEstatus
            f.TxtEstatus.Text = NvoEstatus
            f.NvoReestructura = NvoReestructura
            If f.ShowDialog() = DialogResult.Yes Then
                Me.Dispose()
            End If
        End If

        If RBOtros.Checked = True Then
            NvoEstatus = "VENCIDA" 'al agregar otros siempre va vencida
            Dim F As New frmCapitalizacionOTR()
            F.Anexo = AnexosBindingSource.Current("Anexo")
            F.Text += " " & ComboAnexo.Text & " - " & ComboCli.Text.Trim
            F.TxtStatus.Text = NvoEstatus
            F.NvoEstatus = NvoEstatus
            F.NvoReestructura = NvoReestructura
            F.TasaIVACliente = AnexosBindingSource.Current("TasaIVACliente")
            If F.ShowDialog() = DialogResult.Yes Then
                Me.Dispose()
            End If
        End If

        If RBPlazo.Checked = True Then
            If AnexosBindingSource.Current("Tipar") = "H" Or AnexosBindingSource.Current("Tipar") = "A" Or AnexosBindingSource.Current("Tipar") = "C" Then
                'NvoEstatus = "VENCIDA" 'al agregar otros siempre va vencida
                Dim F As New FrmCambioPlazoAV()
                F.Anexo = AnexosBindingSource.Current("Anexo")
                F.Ciclo = AnexosBindingSource.Current("Ciclo")
                F.NvoEstatus = NvoEstatus
                If F.ShowDialog() = DialogResult.Yes Then
                    Me.Dispose()
                End If
            Else
                If Val(TxtSaldoFact.Text) > 0 Then
                    NvoEstatus = "VENCIDA"
                Else
                    NvoEstatus = "VIGENTE"
                End If
                'NvoEstatus = "VENCIDA" 'al agregar otros siempre va vencida
                Dim F As New frmCambiarPlazo()
                F.txtMonto.Text = TxtSaldoFact.Text
                F.TxtSaldoInsoluto.Text = TxtSaldoInsol.Text
                F.Anexo = AnexosBindingSource.Current("Anexo")
                F.Text += " " & ComboAnexo.Text & " - " & ComboCli.Text.Trim
                F.TxtStatus.Text = NvoEstatus
                F.NvoEstatus = NvoEstatus
                F.NvoReestructura = NvoReestructura
                F.TasaIVACliente = AnexosBindingSource.Current("TasaIVACliente")
                If F.ShowDialog() = DialogResult.Yes Then
                    Me.Dispose()
                End If
            End If

        End If
    End Sub

End Class