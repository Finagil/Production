Public Class FrmLiberacionesSEG
    Private Sub FrmLiberacionesSEG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RadioAV.Checked Then
            Me.VW_LiberacionesMCTableAdapter.FillAV(Me.SegurosDS.VW_LiberacionesMC)
            Me.VW_LiberacionesMCTableAdapter.FillAV1(Me.SegurosDS1.VW_LiberacionesMC)
            Me.ClientesSEGTableAdapter.FillAV(Me.SegurosDS.ClientesSEG, " ")
        Else
            Me.VW_LiberacionesMCTableAdapter.FillTRA(Me.SegurosDS.VW_LiberacionesMC)
            Me.VW_LiberacionesMCTableAdapter.FillTRA1(Me.SegurosDS1.VW_LiberacionesMC)
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

    Private Sub VWLiberacionesMCBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles VWLiberacionesMCBindingSource.CurrentChanged
        If Not IsNothing(Me.VWLiberacionesMCBindingSource.Current) Then
            Me.SEG_LiberacionesMCTableAdapter.Fill(Me.SegurosDS.SEG_LiberacionesMC, Me.VWLiberacionesMCBindingSource.Current("Anexo"), Me.VWLiberacionesMCBindingSource.Current("Ciclo"))
        End If
    End Sub

    Private Sub VWLiberacionesMCBindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles VWLiberacionesMCBindingSource1.CurrentChanged
        If Not IsNothing(Me.VWLiberacionesMCBindingSource1.Current) Then
            Me.SEG_LiberacionesMCTableAdapter.Fill(Me.SegurosDS1.SEG_LiberacionesMC, Me.VWLiberacionesMCBindingSource1.Current("Anexo"), Me.VWLiberacionesMCBindingSource1.Current("Ciclo"))
        End If
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
            Guardar()
        End If
    End Sub

    Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
        Try
            Dim r As SegurosDS.SEG_LiberacionesMCRow
            r = Me.SegurosDS.SEG_LiberacionesMC.NewSEG_LiberacionesMCRow
            r.Anexo = Me.AnexosSEGBindingSource.Current("Anexo")
            r.Ciclo = Me.AnexosSEGBindingSource.Current("Ciclo")
            r.PlazoMaximo = Date.Now.AddDays(-1).Date
            r.FechaRecepcion = Date.Now
            r.Liberado = False
            r.usuario = UsuarioGlobal & "1"
            r.Notas = ""
            Me.SegurosDS.SEG_LiberacionesMC.AddSEG_LiberacionesMCRow(r)
            GeneraCorreo1(r)
            Guardar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Guardar()
        If Me.SegurosDS.VW_LiberacionesMC.Rows.Count > 0 Then
            Dim x As Integer = Me.VWLiberacionesMCBindingSource.Position
            Me.SegurosDS.SEG_LiberacionesMC.GetChanges()
            Me.SEG_LiberacionesMCTableAdapter.Update(Me.SegurosDS.SEG_LiberacionesMC)
            Me.SegurosDS.SEG_LiberacionesMC.AcceptChanges()
            Me.SegurosDS.SEG_LiberacionesMC.Clear()
            If RadioAV.Checked Then
                Me.VW_LiberacionesMCTableAdapter.FillAV(Me.SegurosDS.VW_LiberacionesMC)
                Me.VW_LiberacionesMCTableAdapter.FillAV1(Me.SegurosDS1.VW_LiberacionesMC)
            Else
                Me.VW_LiberacionesMCTableAdapter.FillTRA(Me.SegurosDS.VW_LiberacionesMC)
                Me.VW_LiberacionesMCTableAdapter.FillTRA1(Me.SegurosDS1.VW_LiberacionesMC)
            End If
            If Me.SegurosDS.VW_LiberacionesMC.Rows.Count > 0 Then
                Me.VWLiberacionesMCBindingSource.Position = x
            End If
        End If
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

        If Me.SEGLiberacionesMCBindingSource.Current("Ciclo").ToString.Trim = "" Then ' no es avío
            MandaCorreoPROMO(Me.SEGLiberacionesMCBindingSource.Current("Anexo"), Asunto, Mensaje, True, False)
            MandaCorreoFase(UsuarioGlobalCorreo, Me.VWLiberacionesMCBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
        Else
            MandaCorreoFase(UsuarioGlobalCorreo, Me.VWLiberacionesMCBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
        End If

        MandaCorreoFase(UsuarioGlobalCorreo, "MESA_CONTROL", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "SEGUROS", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", Asunto, Mensaje)
        MessageBox.Show("Correo Enviado", "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SEGLiberacionesMCBindingSource.EndEdit()
        Guardar()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.SEGLiberacionesMCBindingSource.EndEdit()
        Guardar()
    End Sub

    Sub GeneraCorreo1(ByRef r As SegurosDS.SEG_LiberacionesMCRow)
        Dim Asunto As String = "Solicitud de SEGUROS: " & CmbAnexo.Text
        Dim Mensaje As String = ""
        Mensaje += "Cliente: " & CmbClientes.Text & "<br>"
        Mensaje += "Contrato: " & CmbAnexo.Text & "<br>"
        Mensaje += "Estatus: INFORMACION SOLICITADA <br>"
        Mensaje += "Estimado promotor, solicitamos el envío de la hoja de resolución y/o autorización de crédito, para revisar las condiciones del seguro en caso de proceder el seguro :<br> "
        Mensaje += "-Póliza externa se requiere : póliza, beneficiario a favor de FINAGIL y factura de pago de la misma.<br>"
        Mensaje += "-Póliza interna: solicitar la misma al área e indicar si esta será financiada o pagada por el cliente .<br><br>Quedo atenta a la información solicitada.<br>"


        If r.Ciclo.ToString.Trim = "" Then ' no es avío
            MandaCorreoPROMO(r.Anexo, Asunto, Mensaje, True, False)
            MandaCorreoFase(UsuarioGlobalCorreo, AnexosSEGBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
        Else
            MandaCorreoFase(UsuarioGlobalCorreo, AnexosSEGBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
        End If
        MandaCorreoFase(UsuarioGlobalCorreo, "SEGUROS", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", Asunto, Mensaje)
        MessageBox.Show("Correo Enviado", "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.SEGLiberacionesMCBindingSource1.EndEdit()
        Guardar1()
    End Sub

    Sub Guardar1()
        If Me.SegurosDS1.VW_LiberacionesMC.Rows.Count > 0 Then
            Dim x As Integer = Me.VWLiberacionesMCBindingSource1.Position
            Me.SegurosDS1.SEG_LiberacionesMC.GetChanges()
            Me.SEG_LiberacionesMCTableAdapter.Update(Me.SegurosDS1.SEG_LiberacionesMC)
            Me.SegurosDS1.SEG_LiberacionesMC.AcceptChanges()
            Me.SegurosDS1.SEG_LiberacionesMC.Clear()
            If RadioAV.Checked Then
                Me.VW_LiberacionesMCTableAdapter.FillAV(Me.SegurosDS1.VW_LiberacionesMC)
                Me.VW_LiberacionesMCTableAdapter.FillAV1(Me.SegurosDS1.VW_LiberacionesMC)
            Else
                Me.VW_LiberacionesMCTableAdapter.FillTRA(Me.SegurosDS1.VW_LiberacionesMC)
                Me.VW_LiberacionesMCTableAdapter.FillTRA1(Me.SegurosDS1.VW_LiberacionesMC)
            End If
            If Me.SegurosDS1.VW_LiberacionesMC.Rows.Count > 0 Then
                Me.VWLiberacionesMCBindingSource1.Position = x
            End If
            Me.VW_LiberacionesMCTableAdapter.FillTRA1(Me.SegurosDS1.VW_LiberacionesMC)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNothing(Me.SEGLiberacionesMCBindingSource1.Current) Then
            MessageBox.Show("No existe nada para Recibir", "Recibir Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("¿Esta seguro de recibir información este contrato " & Me.VWLiberacionesMCBindingSource1.Current("AnexoCon") & "?", "Liberación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.SEGLiberacionesMCBindingSource1.Current("FechaRecepcion") = Date.Now
            Me.SEGLiberacionesMCBindingSource1.Current("usuario") = UsuarioGlobal
            Me.SEGLiberacionesMCBindingSource1.Current("Liberado") = False
            Me.SEGLiberacionesMCBindingSource1.EndEdit()
            Guardar1()
            MessageBox.Show("Contrato Recibido", "Información Recibida", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.SEGLiberacionesMCBindingSource1.Current("usuario") = UsuarioGlobal & "2"
        Me.SEGLiberacionesMCBindingSource1.EndEdit()
        Guardar1()
        GeneraCorreo2()
    End Sub
    Sub GeneraCorreo2()
        Dim Asunto As String = "Solicitud de SEGUROS: " & Me.VWLiberacionesMCBindingSource1.Current("AnexoCon")
        Dim Mensaje As String = ""
        Mensaje += "Cliente: " & Me.VWLiberacionesMCBindingSource1.Current("Descr") & "<br>"
        Mensaje += "Contrato: " & Me.VWLiberacionesMCBindingSource1.Current("AnexoCon") & "<br>"
        Mensaje += "Estatus: INFORMACION SOLICITADA SIN RESPUESTA <br>"
        Mensaje += "Estimado promotor, solicitamos el envío de la hoja de resolución y/o autorización de crédito, para revisar las condiciones del seguro en caso de proceder el seguro :<br> "
        Mensaje += "-Póliza externa se requiere : póliza, beneficiario a favor de FINAGIL y factura de pago de la misma.<br>"
        Mensaje += "-Póliza interna: solicitar la misma al área e indicar si esta será financiada o pagada por el cliente .<br><br>Quedo atenta a la información solicitada.<br>"
        Mensaje += "Observaciones: " & TxtNotas1.Text & "<br>"

        If Me.SEGLiberacionesMCBindingSource1.Current("Ciclo").ToString.Trim = "" Then ' no es avío
            MandaCorreoPROMO(Me.SEGLiberacionesMCBindingSource1.Current("Anexo"), Asunto, Mensaje, True, False)
            MandaCorreoFase(UsuarioGlobalCorreo, Me.VWLiberacionesMCBindingSource1.Current("Nombre_Sucursal"), Asunto, Mensaje)
        Else
            MandaCorreoFase(UsuarioGlobalCorreo, Me.VWLiberacionesMCBindingSource1.Current("Nombre_Sucursal"), Asunto, Mensaje)
        End If
        'MandaCorreoFase(UsuarioGlobalCorreo, "MESA_CONTROL", Asunto, Mensaje)
        'MandaCorreoFase(UsuarioGlobalCorreo, "SEGUROS", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", Asunto, Mensaje)
        MessageBox.Show("Correo Enviado", "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class