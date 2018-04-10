Imports System.IO
Public Class FrmSeguimientoCRED
    Dim Archivo As String
    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            ContClie1BindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
        Else
            ContClie1BindingSource.Filter = ""
        End If
    End Sub

    Private Sub ComboClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboClientes.SelectedIndexChanged
        If ComboClientes.SelectedIndex >= 0 Then
            Select Case UsuarioGlobalDepto
                Case "CREDITO"
                    Me.AnexosCREDTableAdapter.Fill_MasSinContrato(Me.CreditoDS.AnexosCRED, ComboClientes.SelectedValue)
                Case Else
                    Me.AnexosCREDTableAdapter.FillByPendientes(Me.CreditoDS.AnexosCRED, ComboClientes.SelectedValue)
            End Select
            If Me.CreditoDS.AnexosCRED.Rows.Count > 0 Then CmbAnexos_SelectedIndexChanged(Nothing, Nothing)
        Else
            Me.CreditoDS.AnexosCRED.Clear()
        End If
    End Sub

    Private Sub CmbAnexos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAnexos.SelectedIndexChanged
        If CmbAnexos.SelectedIndex >= 0 Then
            Select Case UsuarioGlobalDepto
                Case "CREDITO"
                    Me.CRED_SeguimientoTableAdapter.FillCredito(Me.CreditoDS.CRED_Seguimiento, CmbAnexos.SelectedValue, UsuarioGlobal, ComboClientes.SelectedValue, UsuarioGlobal)
                Case Else
                    Me.CRED_SeguimientoTableAdapter.FillOtros(Me.CreditoDS.CRED_Seguimiento, CmbAnexos.SelectedValue, UsuarioGlobal, ComboClientes.SelectedValue)
            End Select
            If Me.CreditoDS.CRED_Seguimiento.Rows.Count > 0 Then CmbCompromisos_SelectedIndexChanged(Nothing, Nothing)
        Else
            Me.CreditoDS.CRED_Seguimiento.Clear()
        End If
    End Sub

    Private Sub FrmSeguimientoCRED_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UsuarioGlobal = "desarrollo" Or UsuarioGlobal = "christian.valderrama" Then
            UsuarioGlobal = InputBox("usuario").ToLower
            UsuarioGlobalDepto = InputBox("Depto").ToUpper
        End If
        Me.UsuariosFinagilTableAdapter.FillByDepto(Me.AuditoresDS.UsuariosFinagil, "AUDITORIA")
        Me.UsuariosFinagilTableAdapter.FillByDepto(Me.PersonalDS1.UsuariosFinagil, "PROMOCION")

        Select Case UsuarioGlobalDepto
            Case "CREDITO"
                GroupAnalista.Visible = True
                Me.ContClie1TableAdapter.Fill(Me.ProductionDataSet.ContClie1)
                GroupAnalista.Location = New Point(15, 553)
            Case "PROMOCION"
                GroupPersonal.Visible = True
                Me.ContClie1TableAdapter.FillConSeguimientoPROM(Me.ProductionDataSet.ContClie1, UsuarioGlobal)
                GroupPersonal.Location = New Point(15, 553)
            Case "AUDITORIA"
                GroupAuditor.Visible = True
                Me.ContClie1TableAdapter.FillConSeguimientoAUDIT(Me.ProductionDataSet.ContClie1, UsuarioGlobal)
                GroupAuditor.Location = New Point(15, 553)
        End Select
        If ComboClientes.SelectedIndex >= 0 Then
            ComboClientes_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        DTPcompromiso.Enabled = True
        CREDSeguimientoBindingSource.AddNew()
        DTPAlta.Value = Date.Now
        DTPcompromiso.Value = Date.Now
        TxtEstatus.Text = "Pendiente"
        TxtAnalista.Text = UsuarioGlobal
        CmbAuditor.SelectedIndex = 0
        CmbAsignado.SelectedIndex = 0
        CREDSeguimientoBindingSource.Current("Anexo") = CmbAnexos.SelectedValue
        CREDSeguimientoBindingSource.Current("Cliente") = ComboClientes.SelectedValue
        CREDSeguimientoBindingSource.Current("Enviado") = False
    End Sub

    Private Sub BtnSave_Click_1(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TxtEstatus.Text <> "Pendiente" Then
            MessageBox.Show("No se puede modificar seguimiento, estatus incorrecto: " & TxtEstatus.Text, "Error de Estatus", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Try
            CREDSeguimientoBindingSource.EndEdit()
            Me.CRED_SeguimientoTableAdapter.Update(Me.CreditoDS.CRED_Seguimiento)
            DTPcompromiso.Enabled = False
            CmbCompromisos_SelectedIndexChanged(Nothing, Nothing)
            If MessageBox.Show("¿Deseas enviar correo a la persona asignada?", "Envío de Correo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                GeneraCorreo("Pendiente")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        CREDSeguimientoBindingSource.CancelEdit()
    End Sub

    Private Sub CmbCompromisos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCompromisos.SelectedIndexChanged
        If CmbAnexos.SelectedIndex < 0 Then
            Me.CreditoDS.CRED_Seguimiento.Clear()
            Me.CreditoDS.CRED_SeguimientoDocumentos.Clear()
        Else
            Me.CRED_SeguimientoDocumentosTableAdapter.Fill(Me.CreditoDS.CRED_SeguimientoDocumentos, CmbCompromisos.SelectedValue)
        End If
    End Sub

    Private Sub CkFiltroCRED_CheckedChanged(sender As Object, e As EventArgs) Handles CkFiltroCRED.CheckedChanged
        If CkFiltroCRED.Checked = True Then
            Me.ContClie1TableAdapter.FillConSeguimientoCRED(Me.ProductionDataSet.ContClie1, UsuarioGlobal)
        Else
            Me.ContClie1TableAdapter.Fill(Me.ProductionDataSet.ContClie1)
        End If
        ComboClientes_SelectedIndexChanged(Nothing, Nothing)
        CmbAnexos_SelectedIndexChanged(Nothing, Nothing)
        CmbCompromisos_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TxtEstatus.Text <> "Pendiente" And TxtEstatus.Text <> "En Vobo" Then
            MessageBox.Show("No se pueden subir nocumentos, estatus incorrecto: " & TxtEstatus.Text, "Error de Estatus", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim op As New OpenFileDialog
        Dim id As String = ""
        op.Multiselect = False
        If op.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim notasDoc As String = InputBox("Favor de realziar algun comentario", "Notas Documento", "Comentario")
                Me.CRED_SeguimientoDocumentosTableAdapter.InsertaDoc(CmbCompromisos.SelectedValue, op.SafeFileName, Mid(notasDoc, 1, 400))
                id = Me.CRED_SeguimientoDocumentosTableAdapter.SacaUltimoID(CmbCompromisos.SelectedValue)
                File.Copy(op.FileName, "\\server-nas\OnBase\DATFinagil\" & id & op.SafeFileName)
                Me.CRED_SeguimientoDocumentosTableAdapter.Fill(Me.CreditoDS.CRED_SeguimientoDocumentos, CmbCompromisos.SelectedValue)
                Me.CRED_SeguimientoTableAdapter.Subsanar(Date.Now, CmbCompromisos.SelectedValue)
                GeneraCorreo("En Vobo")
                MessageBox.Show("Archivo guardado", "Subir documentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Subir documentos Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub BttLiberar_Click(sender As Object, e As EventArgs) Handles BttLiberar.Click
        If TxtEstatus.Text <> "En Liberación" Then
            MessageBox.Show("No se puede liberar, estatus incorrecto: " & TxtEstatus.Text, "Error de Estatus", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.CRED_SeguimientoTableAdapter.Liberar(CmbCompromisos.SelectedValue)
            CmbCompromisos_SelectedIndexChanged(Nothing, Nothing)
            GeneraCorreo("Liberado")
            MessageBox.Show("Seguimiento Liberado", "Liberación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        If TxtEstatus.Text <> "En Liberación" Then
            MessageBox.Show("No se puede regresar a Visto bueno, estatus incorrecto: " & TxtEstatus.Text, "Error de Estatus", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.CRED_SeguimientoTableAdapter.VistoBuenoBACK(CmbCompromisos.SelectedValue)
            CmbCompromisos_SelectedIndexChanged(Nothing, Nothing)
            GeneraCorreo("PendienteBack")
            MessageBox.Show("Seguimiento de vuelta con el analista", "Liberación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtEstatus.Text <> "En Vobo" Then
            MessageBox.Show("No se puede dar Visto bueno, estatus incorrecto: " & TxtEstatus.Text, "Error de Estatus", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.CRED_SeguimientoTableAdapter.VistoBueno(CmbCompromisos.SelectedValue)
            CmbCompromisos_SelectedIndexChanged(Nothing, Nothing)
            GeneraCorreo("En Liberación")
            MessageBox.Show("Seguimiento en liberación", "Liberación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TxtEstatus.Text = "Cancelado" Or TxtEstatus.Text = "Liberado" Then
            MessageBox.Show("No se puede Cancelar, estatus incorrecto: " & TxtEstatus.Text, "Error de Estatus", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("¿Esta seguro de Cancelar el Seguimiento?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.CRED_SeguimientoTableAdapter.Cancelar(CmbCompromisos.SelectedValue)
                CmbCompromisos_SelectedIndexChanged(Nothing, Nothing)
                GeneraCorreo("Cancelado")
                MessageBox.Show("Seguimiento Cancelado", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Sub GeneraCorreo(Status As String)
        Dim Asunto As String = ""
        Dim DE As String = UsuarioGlobalCorreo
        Dim Mensaje As String = ""


        Mensaje += "Contrato: " & Me.AnexosCREDBindingSource.Current("AnexoCon") & "<br>"
        Mensaje += "Cliente: " & Me.ContClie1BindingSource.Current("Descr") & "<br>"
        Mensaje += "Estatus: " & Status & "<br>"
        Mensaje += "Fecha Alta: " & Me.CREDSeguimientoBindingSource.Current("Fecha_Alta") & "<br>"
        Mensaje += "Fecha Compromiso: " & CDate(Me.CREDSeguimientoBindingSource.Current("Fecha_Compromiso")).ToShortDateString & "<br>"
        Mensaje += "Analista: " & Me.CREDSeguimientoBindingSource.Current("Analista") & "<br>"
        Mensaje += "Observaciones: " & Me.CREDSeguimientoBindingSource.Current("Notas") & "<br>"

        For Each r As CreditoDS.CRED_SeguimientoDocumentosRow In Me.CreditoDS.CRED_SeguimientoDocumentos.Rows
            If r.NotasDoc <> "" Then
                Mensaje += "Nota Documento: " & r.Documento & "-" & r.NotasDoc & "<br>"
            End If
            If r.NotasDevolucion <> "" Then
                Mensaje += "Nota Devolución: " & r.Documento & "-" & r.NotasDevolucion & "<br>"
            End If
        Next


        Select Case Status
            Case "PendienteBack_Analist"
                Asunto = "Seguimiento regresado a pendiente por analista de Crédito: " & Me.ContClie1BindingSource.Current("Descr")
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Asignado"), Asunto, Mensaje)
                MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
            Case "PendienteBack"
                Asunto = "Seguimiento regresado a pendiente por auditor de Crédito: " & Me.ContClie1BindingSource.Current("Descr")
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Asignado"), Asunto, Mensaje)
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Analista"), Asunto, Mensaje)
                MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
            Case "Pendiente"
                Asunto = "Asignación de Seguimiento de Crédito: " & Me.ContClie1BindingSource.Current("Descr")
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Asignado"), Asunto, Mensaje)
                MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
            Case "En Vobo"
                Asunto = "Se requiere Visto Bueno del Analista: " & Me.ContClie1BindingSource.Current("Descr")
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Analista"), Asunto, Mensaje)
                MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
            Case "En Liberación"
                Asunto = "Se requiere liberación del Auditor: " & Me.ContClie1BindingSource.Current("Descr")
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Auditor"), Asunto, Mensaje)
                MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
            Case "Liberado"
                Asunto = "Liberación de Seguimiento de Crédito: " & Me.ContClie1BindingSource.Current("Descr")
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Asignado"), Asunto, Mensaje)
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Analista"), Asunto, Mensaje)
                MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
            Case "Cancelado"
                Asunto = "Cancelación de Seguimiento de Crédito: " & Me.ContClie1BindingSource.Current("Descr")
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Asignado"), Asunto, Mensaje)
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Auditor"), Asunto, Mensaje)
                MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListDocs.SelectedIndex >= 0 Then
            Archivo = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & Me.CREDSeguimientoDocumentosBindingSource.Current("doc")
            Try
                File.Copy("\\server-nas\OnBase\DATFinagil\" & Me.CREDSeguimientoDocumentosBindingSource.Current("doc"), Archivo, True)
                Dim procID As Integer
                Dim newProc As Diagnostics.Process
                newProc = Diagnostics.Process.Start(Archivo)
                procID = newProc.Id
                Dim procEC As Integer = -1
                If newProc.HasExited Then
                    procEC = newProc.ExitCode
                End If
                newProc.Close()
                newProc.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error " & Archivo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Devolver_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If TxtEstatus.Text <> "En Vobo" Then
            MessageBox.Show("No se puede devolver el documento, estatus incorrecto: " & TxtEstatus.Text, "Error de Estatus", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ListDocs.SelectedIndex < 0 Then
            MessageBox.Show("No hay Documentos Selecionados para devolver", "Error de Documento", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim notasDoc As String = InputBox("Favor de realziar algun comentario", "Notas Devolución", "Comentario")
            Me.CRED_SeguimientoDocumentosTableAdapter.NotaDevolucion(Mid(notasDoc, 1, 400), Me.CREDSeguimientoDocumentosBindingSource.Current("id_documento"))
            Me.CRED_SeguimientoTableAdapter.VistoBuenoBACK(CmbCompromisos.SelectedValue)
            CmbCompromisos_SelectedIndexChanged(Nothing, Nothing)
            GeneraCorreo("PendienteBack_Analist")
            MessageBox.Show("Seguimiento de vuelta con la Persona Asignada", "Devolución", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class