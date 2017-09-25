Public Class FrmCambioTasa
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
        Else
            Me.ReestructDS.Anexos.Clear()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If RBAsociar.Checked = False And RBGracia.Checked = False And RBOtros.Checked = False And RBPlazo.Checked = False And RBTasaMAS.Checked = False And RBTasaMENOS.Checked = False Then
            MessageBox.Show("Debe escoger una opción para restructurar", "Reestructura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim NvoReestructura As String = "S"
        Dim NvoEstatus As String = ""
        Dim PorcCapital As Decimal = 0

        If TxtEstatus.Text = "VENCIDA" Then
            MessageBox.Show("No se puede Reestructurar credito que esta en Cartera Vencida.", "Reestructura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        PorcCapital = AnexosConAdeudoBindingSource.Current("MontoFinanciado") / AnexosConAdeudoBindingSource.Current("SaldoIsnoluto")

        If AnexosConAdeudoBindingSource.Current("Tipar") = "H" Or AnexosConAdeudoBindingSource.Current("Tipar") = "A" Or AnexosConAdeudoBindingSource.Current("Tipar") = "C" Then
            If AnexosConAdeudoBindingSource.Current("FechaTerminacionAV") <= Today.ToString("yyyyMMdd") Then 'VIGENTE
                If RBTasaMAS.Checked = True Or RBPlazo.Checked = True Or RBGracia.Checked = True Then
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
                If Val(TxtPlazoTrans.Text) <= 0.8 Then
                    'se genera la reestructura sin cambios en el contrao
                    GeneraREESTRUCTURA(NvoEstatus, NvoReestructura)
                Else
                    If PorcCapital < 0.6 Then
                        'se genera la reestructura
                        NvoEstatus = "VENCIDA"
                        GeneraREESTRUCTURA(NvoEstatus, NvoReestructura)
                    Else
                        'se genera la reestructura
                        GeneraREESTRUCTURA(NvoEstatus, NvoReestructura)
                    End If
                End If
            Else ' CON ADEUDOS
                NvoEstatus = "VENCIDA"
                'se genera la reestructura
                GeneraREESTRUCTURA(NvoEstatus, NvoReestructura)
            End If
        End If

        'Private Sub TxtTasaN_KeyPress(sender As Object, e As KeyPressEventArgs)
        '    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        '    KeyAscii = CShort(SoloNumeros(KeyAscii, TxtTasaN.Text))
        '    If KeyAscii = 0 Then
        '        e.Handled = True
        '    End If
        'End Sub
    End Sub

    Sub GeneraREESTRUCTURA(ByVal NvoEstatus As String, ByVal NvoReestructura As String)
        If RBAsociar.Checked = True Then
            MessageBox.Show("Proceso en construnción.1", "En Construcción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If RBGracia.Checked = True Then
            MessageBox.Show("Proceso en construnción.2", "En Construcción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If RBOtros.Checked = True Then
            MessageBox.Show("Proceso en construnción.3", "En Construcción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If RBPlazo.Checked = True Then
            MessageBox.Show("Proceso en construnción.4", "En Construcción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If RBTasaMAS.Checked = True Then
            MessageBox.Show("Proceso en construnción.5", "En Construcción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If RBTasaMENOS.Checked = True Then
            MessageBox.Show("Proceso en construnción.6", "En Construcción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class