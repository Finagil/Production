Public Class FrmLiberacionesSEG
    Private Sub FrmLiberacionesSEG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RadioAV.Checked Then
            Me.VW_LiberacionesMCTableAdapter.FillAV(Me.SegurosDS.VW_LiberacionesMC)
            Me.ClientesSEGTableAdapter.FillAV(Me.SegurosDS.ClientesSEG, " ")
        Else
            Me.VW_LiberacionesMCTableAdapter.FillTRA(Me.SegurosDS.VW_LiberacionesMC)
            Me.ClientesSEGTableAdapter.FillTRA(Me.SegurosDS.ClientesSEG, " ")
        End If
    End Sub

    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltro.TextChanged
        If RadioAV.Checked Then
            Me.ClientesSEGTableAdapter.FillAV(Me.SegurosDS.ClientesSEG, Txtfiltro.Text)
        Else
            Me.ClientesSEGTableAdapter.FillTRA(Me.SegurosDS.ClientesSEG, Txtfiltro.Text)
        End If

        If Me.SegurosDS.Clientes.Rows.Count > 0 Then
            'CmbClientes.SelectedIndex = 0
        Else
            'Me.SegurosDS.Anexos.Clear()
        End If
    End Sub

    Private Sub CmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbClientes.SelectedIndexChanged

    End Sub

    Private Sub VWLiberacionesMCBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles VWLiberacionesMCBindingSource.CurrentChanged
        If Not IsNothing(Me.VWLiberacionesMCBindingSource.Current) Then
            Me.SEG_LiberacionesMCTableAdapter.Fill(Me.SegurosDS.SEG_LiberacionesMC, Me.VWLiberacionesMCBindingSource.Current("Anexo"), Me.VWLiberacionesMCBindingSource.Current("Ciclo"))
        End If
    End Sub

    Private Sub CmbAnexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAnexo.SelectedIndexChanged

    End Sub

    Private Sub ButtonLIB_Click(sender As Object, e As EventArgs) Handles ButtonLIB.Click
        If IsNothing(Me.SEGLiberacionesMCBindingSource.Current) Then
            MessageBox.Show("No existe nada para Liberar", "Liberación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("¿Esta seguro de Liberar este contrato " & Me.VWLiberacionesMCBindingSource.Current("AnexoCon") & "?", "Liberación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.SEGLiberacionesMCBindingSource.Current("FechaLiberacion") = Date.Now
            Me.SEGLiberacionesMCBindingSource.Current("usuario") = UsuarioGlobal
            Me.SEGLiberacionesMCBindingSource.Current("Liberado") = True
            Me.SEGLiberacionesMCBindingSource.EndEdit()
            GeneraCorreo(True)
            Guardar(True)

        End If
    End Sub

    Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
        Try
            Dim r As SegurosDS.SEG_LiberacionesMCRow
            r = Me.SegurosDS.SEG_LiberacionesMC.NewSEG_LiberacionesMCRow
            r.Anexo = Me.AnexosSEGBindingSource.Current("Anexo")
            r.Ciclo = Me.AnexosSEGBindingSource.Current("Ciclo")
            r.PlazoMaximo = Date.Now.AddDays(-1).Date
            r.Liberado = False
            r.usuario = UsuarioGlobal
            r.Notas = ""
            Me.SegurosDS.SEG_LiberacionesMC.AddSEG_LiberacionesMCRow(r)
            Guardar(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Guardar(ActualizaGrid As Boolean)
        Me.SegurosDS.SEG_LiberacionesMC.GetChanges()
        Me.SEG_LiberacionesMCTableAdapter.Update(Me.SegurosDS.SEG_LiberacionesMC)
        If ActualizaGrid = True Then
            Me.SegurosDS.SEG_LiberacionesMC.Clear()
            If RadioAV.Checked Then
                Me.VW_LiberacionesMCTableAdapter.FillAV(Me.SegurosDS.VW_LiberacionesMC)
            Else
                Me.VW_LiberacionesMCTableAdapter.FillTRA(Me.SegurosDS.VW_LiberacionesMC)
            End If
        End If
    End Sub

    Private Sub TextNotas_LostFocus(sender As Object, e As EventArgs) Handles TextNotas.LostFocus
        Me.SEGLiberacionesMCBindingSource.EndEdit()
        Guardar(False)
    End Sub

    Private Sub DTPplazo_ValueChanged(sender As Object, e As EventArgs) Handles DTPplazo.ValueChanged
        Me.SEGLiberacionesMCBindingSource.EndEdit()
        Guardar(False)
    End Sub

    Sub GeneraCorreo(Libera As Boolean)
        Dim Asunto As String = ""
        If Libera = True Then
            Asunto = "Liberación de SEGUROS: " & Me.VWLiberacionesMCBindingSource.Current("AnexoCon")
        Else
            Asunto = "Comentario de SEGUROS: " & Me.VWLiberacionesMCBindingSource.Current("AnexoCon")
        End If
        Dim Mensaje As String = ""
        Mensaje += "Cliente: " & Me.VWLiberacionesMCBindingSource.Current("Descr") & "<br>"
        Mensaje += "Contrato: " & Me.VWLiberacionesMCBindingSource.Current("AnexoCon") & "<br>"
        If Libera = True Then
            Mensaje += "Estatus: LIBERADO <br>"
        Else
            Mensaje += "Estatus: PENDIENTE <br>"
        End If
        Mensaje += "Plazo Maximo: " & Me.VWLiberacionesMCBindingSource.Current("PlazoMaximo") & "<br>"
        If Libera = True Then
            Mensaje += "Fecha Liberación: " & Date.Now & "<br>"
        Else
            Mensaje += "Fecha Liberación: <br>"
        End If

        Mensaje += "Observaciones: " & TextNotas.Text & "<br>"

        If Me.AnexosSEGBindingSource.Current("Ciclo") = "" Then ' no es avío
            MandaCorreoPROMO(Me.AnexosSEGBindingSource.Current("Anexo"), Asunto, Mensaje, True, False)
            MandaCorreoFase(UsuarioGlobalCorreo, "ASIST_" & Me.VWLiberacionesMCBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
        Else
            MandaCorreoFase(UsuarioGlobalCorreo, Me.VWLiberacionesMCBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
        End If
        MandaCorreoFase(UsuarioGlobalCorreo, "MESA_CONTROL", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "SEGUROS", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", Asunto, Mensaje)
        MessageBox.Show("Correo Enviado", "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Guardar(False)
        GeneraCorreo(False)
    End Sub

    Private Sub RadioAV_CheckedChanged(sender As Object, e As EventArgs) Handles RadioAV.CheckedChanged
        FrmLiberacionesSEG_Load(Nothing, Nothing)
    End Sub

    Private Sub RadioTRA_CheckedChanged(sender As Object, e As EventArgs) Handles RadioTRA.CheckedChanged
        FrmLiberacionesSEG_Load(Nothing, Nothing)
    End Sub

    Private Sub AnexosSEGBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles AnexosSEGBindingSource.CurrentChanged
        If Not IsNothing(AnexosSEGBindingSource.Current) Then
            If Me.SEG_LiberacionesMCTableAdapter.TieneLiberacion(Me.AnexosSEGBindingSource.Current("Anexo"), Me.AnexosSEGBindingSource.Current("Ciclo")) > 0 Then
                ButtonADD.Enabled = False
            Else
                ButtonADD.Enabled = True
            End If
        End If
    End Sub

    Private Sub ClientesSEGBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ClientesSEGBindingSource.CurrentChanged
        If Not IsNothing(ClientesSEGBindingSource.Current) Then
            Me.SegurosDS.Anexos.Clear()
            If RadioAV.Checked Then
                Me.AnexosSEGTableAdapter.FillAV(Me.SegurosDS.AnexosSEG, ClientesSEGBindingSource.Current("Cliente"))
            Else
                Me.AnexosSEGTableAdapter.FillTRA(Me.SegurosDS.AnexosSEG, ClientesSEGBindingSource.Current("Cliente"))
            End If
            If Me.SegurosDS.AnexosSEG.Rows.Count > 0 Then
                CmbAnexo.SelectedIndex = 0
            End If
        End If
    End Sub
End Class