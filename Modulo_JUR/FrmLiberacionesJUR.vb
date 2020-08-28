Public Class FrmLiberacionesJUR
    Private Sub FrmLiberacionesJUR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VW_LiberacionesMCTableAdapter.FillAV(Me.JuridicoDS.VW_LiberacionesMC)
        If RadioAV.Checked Then
            Me.VW_LiberacionesMCTableAdapter.FillAV(Me.JuridicoDS.VW_LiberacionesMC)
            Me.ClientesJURTableAdapter.FillAV(Me.JuridicoDS.ClientesJUR, " ")
        Else
            Me.VW_LiberacionesMCTableAdapter.FillTRA(Me.JuridicoDS.VW_LiberacionesMC)
            Me.ClientesJURTableAdapter.FillTRA(Me.JuridicoDS.ClientesJUR, " ")
        End If
    End Sub

    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltro.TextChanged
        If RadioAV.Checked Then
            Me.ClientesJURTableAdapter.FillAV(Me.JuridicoDS.ClientesJUR, Txtfiltro.Text)
        Else
            Me.ClientesJURTableAdapter.FillTRA(Me.JuridicoDS.ClientesJUR, Txtfiltro.Text)
        End If

        If Me.JuridicoDS.Clientes.Rows.Count > 0 Then
            'CmbClientes.SelectedIndex = 0
        Else
            'Me.JuridicoDS.Anexos.Clear()
        End If
    End Sub

    Private Sub VWLiberacionesMCBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles VWLiberacionesMCBindingSource.CurrentChanged
        If Not IsNothing(Me.VWLiberacionesMCBindingSource.Current) Then
            Me.JuR_LiberacionesMCTableAdapter.Fill(Me.JuridicoDS.JUR_LiberacionesMC, Me.VWLiberacionesMCBindingSource.Current("Anexo"), Me.VWLiberacionesMCBindingSource.Current("Ciclo"))
        End If
    End Sub

    Private Sub ButtonLIB_Click(sender As Object, e As EventArgs) Handles ButtonLIB.Click
        If IsNothing(Me.JURLiberacionesMCBindingSource.Current) Then
            MessageBox.Show("No existe nada para Liberar", "Liberación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("¿Esta seguro de Liberar este contrato " & Me.VWLiberacionesMCBindingSource.Current("AnexoCon") & "?", "Liberación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.JURLiberacionesMCBindingSource.Current("FechaLiberacion") = Date.Now
            Me.JURLiberacionesMCBindingSource.Current("usuario") = UsuarioGlobal
            Me.JURLiberacionesMCBindingSource.Current("Liberado") = True
            Me.JURLiberacionesMCBindingSource.EndEdit()
            GeneraCorreo(True)
            Guardar()
        End If
    End Sub

    Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
        Try
            Dim r As JuridicoDS.JUR_LiberacionesMCRow
            r = Me.JuridicoDS.JUR_LiberacionesMC.NewJUR_LiberacionesMCRow
            r.Anexo = Me.AnexosJURBindingSource.Current("Anexo")
            r.Ciclo = Me.AnexosJURBindingSource.Current("Ciclo")
            r.PlazoMaximo = Date.Now.AddDays(-1).Date
            r.Liberado = False
            r.usuario = UsuarioGlobal
            r.Notas = ""
            Me.JuridicoDS.JUR_LiberacionesMC.AddJUR_LiberacionesMCRow(r)
            Guardar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Guardar()
        If Me.JuridicoDS.VW_LiberacionesMC.Rows.Count >= 0 Then
            Dim x As Integer = Me.VWLiberacionesMCBindingSource.Position
            Me.JuridicoDS.JUR_LiberacionesMC.GetChanges()
            Me.JuR_LiberacionesMCTableAdapter.Update(Me.JuridicoDS.JUR_LiberacionesMC)
            Me.JuridicoDS.JUR_LiberacionesMC.AcceptChanges()
            Me.JuridicoDS.JUR_LiberacionesMC.Clear()
            If RadioAV.Checked Then
                Me.VW_LiberacionesMCTableAdapter.FillAV(Me.JuridicoDS.VW_LiberacionesMC)
            Else
                Me.VW_LiberacionesMCTableAdapter.FillTRA(Me.JuridicoDS.VW_LiberacionesMC)
            End If
            If Me.JuridicoDS.VW_LiberacionesMC.Rows.Count > 0 Then
                Me.VWLiberacionesMCBindingSource.Position = x
            End If
        End If
    End Sub

    Sub GeneraCorreo(Libera As Boolean)
        Dim Asunto As String = ""
        If Libera = True Then
            Asunto = "Liberación de JURIDICO: " & Me.VWLiberacionesMCBindingSource.Current("AnexoCon")
        Else
            Asunto = "Comentario de JURIDICO: " & Me.VWLiberacionesMCBindingSource.Current("AnexoCon")
        End If
        Dim Mensaje As String = ""
        Mensaje += "Cliente: " & Me.VWLiberacionesMCBindingSource.Current("Descr") & "<br>"
        Mensaje += "Contrato: " & Me.VWLiberacionesMCBindingSource.Current("AnexoCon") & "<br>"
        Mensaje += "Sucursal: " & Me.VWLiberacionesMCBindingSource.Current("Nombre_Sucursal") & "<br>"
        Mensaje += "Promotor: " & Me.VWLiberacionesMCBindingSource.Current("Nombre_Promotor") & "<br>"
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

        If Me.JURLiberacionesMCBindingSource.Current("Ciclo").ToString.Trim = "" Then ' no es avío
            MandaCorreoPROMO(Me.JURLiberacionesMCBindingSource.Current("Anexo"), Asunto, Mensaje, True, False)
            MandaCorreoFase(UsuarioGlobalCorreo, Me.VWLiberacionesMCBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
        Else
            MandaCorreoFase(UsuarioGlobalCorreo, Me.VWLiberacionesMCBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
            MandaCorreoFase(UsuarioGlobalCorreo, "JUR_" & Me.VWLiberacionesMCBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
        End If

        MandaCorreoFase(UsuarioGlobalCorreo, "JURIDICO", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "MESA_CONTROL", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", Asunto, Mensaje)
        MessageBox.Show("Correo Enviado", "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.JURLiberacionesMCBindingSource.EndEdit()
        Guardar()
        GeneraCorreo(False)
    End Sub

    Private Sub RadioAV_CheckedChanged(sender As Object, e As EventArgs) Handles RadioAV.CheckedChanged
        FrmLiberacionesJUR_Load(Nothing, Nothing)
    End Sub

    Private Sub RadioTRA_CheckedChanged(sender As Object, e As EventArgs) Handles RadioTRA.CheckedChanged
        FrmLiberacionesJUR_Load(Nothing, Nothing)
    End Sub

    Private Sub AnexosJURBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles AnexosJURBindingSource.CurrentChanged
        If Not IsNothing(AnexosJURBindingSource.Current) Then
            If Me.JuR_LiberacionesMCTableAdapter.TieneLiberaciones(Me.AnexosJURBindingSource.Current("Anexo"), Me.AnexosJURBindingSource.Current("Ciclo")) > 0 Then
                ButtonADD.Enabled = False
            Else
                ButtonADD.Enabled = True
            End If
        End If
    End Sub

    Private Sub ClientesjurBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ClientesJURBindingSource.CurrentChanged
        If Not IsNothing(ClientesJURBindingSource.Current) Then
            Me.JuridicoDS.AnexosJUR.Clear()
            If RadioAV.Checked Then
                Me.AnexosJURTableAdapter.FillAV(Me.JuridicoDS.AnexosJUR, ClientesJURBindingSource.Current("Cliente"))
            Else
                Me.AnexosJURTableAdapter.FillTRA(Me.JuridicoDS.AnexosJUR, ClientesJURBindingSource.Current("Cliente"))
            End If
            If Me.JuridicoDS.AnexosJUR.Rows.Count > 0 Then
                CmbAnexo.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.JURLiberacionesMCBindingSource.EndEdit()
        Guardar()
    End Sub

End Class