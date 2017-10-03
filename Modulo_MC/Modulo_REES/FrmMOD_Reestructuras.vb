﻿Public Class FrmMOD_Reestructuras
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

        PorcCapital = AnexosBindingSource.Current("MontoFinanciado") / AnexosBindingSource.Current("SaldoInsoluto")

        If AnexosBindingSource.Current("Tipar") = "H" Or AnexosBindingSource.Current("Tipar") = "A" Or AnexosBindingSource.Current("Tipar") = "C" Then
            If AnexosBindingSource.Current("FechaTerminacionAV") <= Today.ToString("yyyyMMdd") Then 'VIGENTE
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

            f.ShowDialog()
        End If

        If RBAsociar.Checked = True Then

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


    End Sub

End Class