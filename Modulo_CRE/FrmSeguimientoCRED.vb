Imports System.IO
Public Class FrmSeguimientoCRED
    Dim Archivo As String
    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            ContClie1BindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
        Else
            ContClie1BindingSource.Filter = ""
        End If
        ComboClientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub ComboClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboClientes.SelectedIndexChanged
        If ComboClientes.SelectedIndex >= 0 Then
            Select Case UsuarioGlobalDepto
                Case "CREDITO", "JURIDICO", "MESA DE CONTROL", "OPERACIONES", "SEGUROS"
                    Me.AnexosCREDTableAdapter.Fill_MasSinContrato(Me.CreditoDS.AnexosCRED, ComboClientes.SelectedValue)
                    Me.AnexosCREDTableAdapter.Fill(Me.CreditoDS1.AnexosCRED, ComboClientes.SelectedValue)
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
                Case "CREDITO", "JURIDICO", "SEGUROS", "PLD", "MESA DE CONTROL", "AUDITORIA", "OPERACIONES"
                    If UsuarioGlobalDepto = "AUDITORIA" Then
                        Me.CRED_SeguimientoTableAdapter.FillCreditoAuditor(Me.CreditoDS.CRED_Seguimiento, CmbAnexos.SelectedValue, ComboClientes.SelectedValue, UsuarioGlobal)
                    Else
                        Me.CRED_SeguimientoTableAdapter.FillCredito(Me.CreditoDS.CRED_Seguimiento, CmbAnexos.SelectedValue, ComboClientes.SelectedValue, UsuarioGlobal, UsuarioGlobal, UsuarioGlobal)
                    End If
                    If CmbAnexos.Text = "00000/0000" And Me.CreditoDS.CRED_Seguimiento.Rows.Count > 0 Then
                        BtnReea.Enabled = True
                        CmbAnexos2.Enabled = True
                        GroupAnalista.Visible = True
                        Btnnew2.Visible = False
                        CkFiltroCRED2.Visible = False
                    Else
                        BtnReea.Enabled = False
                        CmbAnexos2.Enabled = False
                        GroupAnalista.Visible = False
                        Btnnew2.Visible = True
                        CkFiltroCRED2.Visible = True
                        If Me.CreditoDS.CRED_Seguimiento.Rows.Count > 0 Then
                            If Me.CREDSeguimientoBindingSource.Current("Estatus") = "En Vobo" Or Me.CREDSeguimientoBindingSource.Current("Estatus") = "Pendiente" Then
                                GroupAnalista.Visible = True
                                Btnnew2.Visible = False
                                CkFiltroCRED2.Visible = False
                            End If
                        End If
                    End If
                Case Else
                    Me.CRED_SeguimientoTableAdapter.FillOtros(Me.CreditoDS.CRED_Seguimiento, CmbAnexos.SelectedValue, UsuarioGlobal, ComboClientes.SelectedValue)
            End Select
            If Me.CreditoDS.CRED_Seguimiento.Rows.Count > 0 Then CmbCompromisos_SelectedIndexChanged(Nothing, Nothing)
        Else
            Me.CreditoDS.CRED_Seguimiento.Clear()
        End If
    End Sub

    Private Sub FrmSeguimientoCRED_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Altura As Integer = 553
        If Screen.PrimaryScreen.Bounds.Height = 1080 Then
            Altura += 130
        End If
        If UsuarioGlobal = "desarrollo" Or TaQUERY.SacaPermisoModulo("SEG_CRED_AUDIT", UsuarioGlobal) > 0 Then
            UsuarioGlobal = InputBox("usuario").ToLower
            UsuarioGlobalDepto = InputBox("Depto").ToUpper
        End If
        Me.UsuariosFinagilTableAdapter.FillByDepto(Me.AuditoresDS.UsuariosFinagil, "AUDITORIA")
        Me.UsuariosFinagilTableAdapter.FillByDepto(Me.PersonalDS1.UsuariosFinagil, "PROMOCION")
        Me.UsuariosFinagilTableAdapter.FillByCredSeguiVobo(Me.PersonalDS2.UsuariosFinagil)

        Select Case UsuarioGlobalDepto.ToUpper
            Case "CREDITO", "JURIDICO", "MESA DE CONTROL", "OPERACIONES", "SEGUROS"
                GroupAnalista.Visible = True
                Me.ContClie1TableAdapter.Fill(Me.ProductionDataSet.ContClie1)
                GroupAnalista.Location = New Point(15, Altura)
            Case "PROMOCION"
                GroupPersonal.Visible = True
                Me.ContClie1TableAdapter.FillConSeguimientoPROM(Me.ProductionDataSet.ContClie1, UsuarioGlobal)
                GroupPersonal.Location = New Point(15, Altura)
            Case "AUDITORIA"
                GroupAuditor.Visible = True
                Me.ContClie1TableAdapter.FillConSeguimientoAUDIT(Me.ProductionDataSet.ContClie1, UsuarioGlobal)
                GroupAuditor.Location = New Point(15, Altura)
        End Select
        If ComboClientes.SelectedIndex >= 0 Then
            ComboClientes_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        DTPcompromiso.Enabled = True
        CREDSeguimientoBindingSource.AddNew()
        DTPAlta.Value = Date.Now
        DTPcompromiso.Value = "01/01/1900"
        TxtEstatus.Text = "Pendiente"
        TxtAnalista.Text = UsuarioGlobal
        CmbAsignado.SelectedIndex = 0
        CREDSeguimientoBindingSource.Current("Anexo") = CmbAnexos.SelectedValue
        CREDSeguimientoBindingSource.Current("Cliente") = ComboClientes.SelectedValue
        CREDSeguimientoBindingSource.Current("Enviado") = False
        CREDSeguimientoBindingSource.Current("Seg") = False
        CREDSeguimientoBindingSource.Current("Tipo") = UsuarioGlobalDepto
        CREDSeguimientoBindingSource.Current("Vobo") = TxtAnalista.Text
        Select Case UsuarioGlobalDepto
            Case "MESA DE CONTROL"
                CREDSeguimientoBindingSource.Current("Auditor") = "Auditor"
            Case "CREDITO"
                CREDSeguimientoBindingSource.Current("Auditor") = TaQUERY.ConfigDATO("AUDITOR")
            Case Else
                CREDSeguimientoBindingSource.Current("Auditor") = TaQUERY.ConfigDATO("AUDITOR")
        End Select
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
            If DTPcompromiso.Value > Date.Now.AddYears(-2) Then
                If MessageBox.Show("¿Deseas enviar correo a la persona asignada?", "Envío de Correo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    GeneraCorreo("Pendiente")
                End If
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
            'If Not IsNothing(Me.CREDSeguimientoBindingSource.Current) Then
            '    If Not IsDBNull(Me.CREDSeguimientoBindingSource.Current("Estatus")) Then
            '        If Me.CREDSeguimientoBindingSource.Current("Estatus") = "Pendiente" And CmbAnexos.SelectedValue <> "000000000" And
            '        IsDBNull(Me.CREDSeguimientoBindingSource.Current("FechaVobo")) And IsDBNull(Me.CREDSeguimientoBindingSource.Current("FechaSubsanar")) Then
            '            If Me.CRED_SeguimientoTableAdapter.TieneCiclicos(CmbCompromisos.SelectedValue) > 0 Then
            '                BttCicloca.Enabled = False
            '            Else
            '                BttCicloca.Enabled = True
            '                If DTPcompromiso.Value = CDate("1900-01-01") Then
            '                    DTPcompromiso.Enabled = True
            '                Else
            '                    DTPcompromiso.Enabled = False
            '                End If
            '            End If
            '        End If
            '    Else
            '        BttCicloca.Enabled = False
            '    End If
            'Else
            '    BttCicloca.Enabled = False
            'End If
        End If
    End Sub

    Private Sub CkFiltroCRED_CheckedChanged(sender As Object, e As EventArgs) Handles CkFiltroCRED.CheckedChanged
        CkFiltroCRED2.Checked = CkFiltroCRED.Checked
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
            MessageBox.Show("No se pueden subir documentos, estatus incorrecto: " & TxtEstatus.Text, "Error de Estatus", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim op As New OpenFileDialog

        Dim id As String = ""
        op.Multiselect = False
        If MessageBox.Show("¿Deseas agregar un documento?", "Solventar Compromiso.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Dim notasDoc As String = InputBox("Favor de realziar algun comentario", "Notas", "Comentario")
            Me.CRED_SeguimientoDocumentosTableAdapter.InsertaDoc(CmbCompromisos.SelectedValue, "Sin Documento", Mid(notasDoc, 1, 400))
            Me.CRED_SeguimientoDocumentosTableAdapter.Fill(Me.CreditoDS.CRED_SeguimientoDocumentos, CmbCompromisos.SelectedValue)
            Me.CRED_SeguimientoTableAdapter.Subsanar(Date.Now, CmbCompromisos.SelectedValue)
            GeneraCorreo("En Vobo")
            MessageBox.Show("Pendiente Solventado", "Subir Documentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If op.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                If op.SafeFileName.Length > 50 Then
                    MessageBox.Show("Nombre de archivo muy Largo (maximo 50 caracteres)", "Subir documentos Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Try
                    Cursor.Current = Cursors.WaitCursor
                    Dim notasDoc As String = InputBox("Favor de realziar algun comentario", "Notas Documento", "Comentario")
                    Me.CRED_SeguimientoDocumentosTableAdapter.InsertaDoc(CmbCompromisos.SelectedValue, op.SafeFileName, Mid(notasDoc, 1, 400))
                    id = Me.CRED_SeguimientoDocumentosTableAdapter.SacaUltimoID(CmbCompromisos.SelectedValue)
                    File.Copy(op.FileName, "\\server-nas\OnBase\DATFinagil\" & id & op.SafeFileName)
                    Me.CRED_SeguimientoDocumentosTableAdapter.Fill(Me.CreditoDS.CRED_SeguimientoDocumentos, CmbCompromisos.SelectedValue)
                    Me.CRED_SeguimientoTableAdapter.Subsanar(Date.Now, CmbCompromisos.SelectedValue)
                    GeneraCorreo("En Vobo")
                    Cursor.Current = Cursors.Default
                    MessageBox.Show("Archivo guardado", "Subir documentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Subir documentos Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
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
        Mensaje += "Area de Seguimiento: " & Me.CREDSeguimientoBindingSource.Current("Tipo") & "<br>"
        Mensaje += "Número de Seguimiento: " & CmbCompromisos.SelectedValue & "<br>"
        Mensaje += "Fecha Alta: " & Me.CREDSeguimientoBindingSource.Current("Fecha_Alta") & "<br>"
        Mensaje += "Fecha Compromiso: " & CDate(Me.CREDSeguimientoBindingSource.Current("Fecha_Compromiso")).ToShortDateString & "<br>"
        Mensaje += "Asignado por: " & Me.CREDSeguimientoBindingSource.Current("Analista") & "<br>"
        Mensaje += "Visto Bueno: " & Me.CREDSeguimientoBindingSource.Current("Vobo") & "<br>"
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
                Asunto = "Seguimiento regresado a pendiente por " & Me.CREDSeguimientoBindingSource.Current("Tipo") & ": " & Me.ContClie1BindingSource.Current("Descr")
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Asignado"), Asunto, Mensaje)
                MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
            Case "PendienteBack"
                Asunto = "Seguimiento regresado a pendiente por auditor: " & Me.ContClie1BindingSource.Current("Descr")
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Asignado"), Asunto, Mensaje)
                If Me.CREDSeguimientoBindingSource.Current("Analista") <> Me.UsuariosFinagilBindingSource.Current("id_usuario") Then
                    MandaCorreoUser(DE, Me.UsuariosFinagilBindingSource.Current("id_usuario"), Asunto, Mensaje)
                Else
                    MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Analista"), Asunto, Mensaje)
                End If
                MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
            Case "Pendiente"
                Asunto = "Asignación de Seguimiento de " & Me.CREDSeguimientoBindingSource.Current("Tipo") & ": " & Me.ContClie1BindingSource.Current("Descr")
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Asignado"), Asunto, Mensaje)
                MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
            Case "En Vobo"
                Asunto = "Se requiere Visto Bueno de " & Me.CREDSeguimientoBindingSource.Current("Tipo") & ": " & Me.ContClie1BindingSource.Current("Descr")
                If Me.CREDSeguimientoBindingSource.Current("Analista") <> Me.UsuariosFinagilBindingSource.Current("id_usuario") Then
                    MandaCorreoUser(DE, Me.UsuariosFinagilBindingSource.Current("id_usuario"), Asunto, Mensaje)
                Else
                    MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Analista"), Asunto, Mensaje)
                End If
                MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
            Case "En Liberación"
                If UsuarioGlobalDepto = "MESA DE CONTROL" Then
                    Me.CRED_SeguimientoTableAdapter.Liberar(CmbCompromisos.SelectedValue)
                    Asunto = "Liberación de Seguimiento de " & Me.CREDSeguimientoBindingSource.Current("Tipo") & ": " & Me.ContClie1BindingSource.Current("Descr")
                    MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Asignado"), Asunto, Mensaje)
                    If Me.CREDSeguimientoBindingSource.Current("Analista") <> Me.UsuariosFinagilBindingSource.Current("id_usuario") Then
                        MandaCorreoUser(DE, Me.UsuariosFinagilBindingSource.Current("id_usuario"), Asunto, Mensaje)
                    Else
                        MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Analista"), Asunto, Mensaje)
                    End If
                    MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
                Else
                    Asunto = "Se requiere liberación del Auditor: " & Me.ContClie1BindingSource.Current("Descr")
                    MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Auditor"), Asunto, Mensaje)
                    MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
                End If
            Case "Liberado"
                Asunto = "Liberación de Seguimiento de " & Me.CREDSeguimientoBindingSource.Current("Tipo") & ": " & Me.ContClie1BindingSource.Current("Descr")
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Asignado"), Asunto, Mensaje)
                If Me.CREDSeguimientoBindingSource.Current("Analista") <> Me.UsuariosFinagilBindingSource.Current("id_usuario") Then
                    MandaCorreoUser(DE, Me.UsuariosFinagilBindingSource.Current("id_usuario"), Asunto, Mensaje)
                Else
                    MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Analista"), Asunto, Mensaje)
                End If
                MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
            Case "Cancelado"
                Asunto = "Cancelación de Seguimiento de " & Me.CREDSeguimientoBindingSource.Current("Tipo") & ": " & Me.ContClie1BindingSource.Current("Descr")
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Asignado"), Asunto, Mensaje)
                MandaCorreoUser(DE, Me.CREDSeguimientoBindingSource.Current("Auditor"), Asunto, Mensaje)
                MandaCorreoUser(DE, "ecacerest@finagil.com.mx", Asunto, Mensaje)
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListDocs.SelectedIndex >= 0 Then
            If Me.CREDSeguimientoDocumentosBindingSource.Current("Documento") = "Sin Documento" Then
                MessageBox.Show("Sin Documento", "Error " & Archivo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Button3.Enabled = False
            Cursor.Current = Cursors.WaitCursor
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
            Cursor.Current = Cursors.Default
            Button3.Enabled = True
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

    Private Sub BtnReea_Click(sender As Object, e As EventArgs) Handles BtnReea.Click
        If MessageBox.Show("¿Estas seguro de reasignar este contrato?", CmbAnexos2.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.CRED_SeguimientoTableAdapter.ReeAsignaContrato(CmbAnexos2.SelectedValue, CmbCompromisos.SelectedValue)
            ComboClientes_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub Btnnew2_Click(sender As Object, e As EventArgs) Handles Btnnew2.Click ' nuevo de analista
        DTPcompromiso.Enabled = True
        CREDSeguimientoBindingSource.AddNew()
        DTPAlta.Value = Date.Now
        DTPcompromiso.Value = "01/01/1900"
        TxtEstatus.Text = "Pendiente"
        TxtAnalista.Text = UsuarioGlobal
        CmbAsignado.SelectedIndex = 0
        CREDSeguimientoBindingSource.Current("Anexo") = CmbAnexos.SelectedValue
        CREDSeguimientoBindingSource.Current("Cliente") = ComboClientes.SelectedValue
        CREDSeguimientoBindingSource.Current("Enviado") = False
        CREDSeguimientoBindingSource.Current("Seg") = False
        CREDSeguimientoBindingSource.Current("Tipo") = UsuarioGlobalDepto
        CREDSeguimientoBindingSource.Current("Vobo") = TxtAnalista.Text
        Select Case UsuarioGlobalDepto
            Case "MESA DE CONTROL"
                CREDSeguimientoBindingSource.Current("Auditor") = "Auditor"
            Case "CREDITO"
                CREDSeguimientoBindingSource.Current("Auditor") = TaQUERY.ConfigDATO("AUDITOR")
            Case Else
                CREDSeguimientoBindingSource.Current("Auditor") = TaQUERY.ConfigDATO("AUDITOR")
        End Select
        Btnnew2.Visible = False
        CkFiltroCRED2.Visible = False
        GroupAnalista.Visible = True
    End Sub

    Private Sub CkFiltroCRED2_CheckedChanged(sender As Object, e As EventArgs) Handles CkFiltroCRED2.CheckedChanged
        CkFiltroCRED.Checked = CkFiltroCRED2.Checked
        If CkFiltroCRED2.Checked = True Then
            Me.ContClie1TableAdapter.FillConSeguimientoCRED(Me.ProductionDataSet.ContClie1, UsuarioGlobal)
        Else
            Me.ContClie1TableAdapter.Fill(Me.ProductionDataSet.ContClie1)
        End If
        ComboClientes_SelectedIndexChanged(Nothing, Nothing)
        CmbAnexos_SelectedIndexChanged(Nothing, Nothing)
        CmbCompromisos_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub BttCicloca_Click(sender As Object, e As EventArgs) Handles BttCicloca.Click
        Dim F As New frmSeguimientoCiclico
        F.Id_ORG = CmbCompromisos.SelectedValue
        If F.ShowDialog() = DialogResult.OK Then
            BttCicloca.Enabled = False
            CmbAnexos_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub PersonalBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles PersonalBindingSource.CurrentChanged
        If Me.PersonalBindingSource.Current("Estado") <> "Activo" Then
            MessageBox.Show("Usuario INACTIVO", "Asignado a:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub CREDSeguimientoBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CREDSeguimientoBindingSource.CurrentChanged
        If Not IsNothing(Me.CREDSeguimientoBindingSource.Current) Then
            If Not IsDBNull(Me.CREDSeguimientoBindingSource.Current("Estatus")) Then
                If Me.CREDSeguimientoBindingSource.Current("Estatus") = "Pendiente" And CmbAnexos.SelectedValue <> "000000000" And
                IsDBNull(Me.CREDSeguimientoBindingSource.Current("FechaVobo")) And IsDBNull(Me.CREDSeguimientoBindingSource.Current("FechaSubsanar")) Then
                    If Me.CRED_SeguimientoDocumentosTableAdapter.TieneCiclicos(CmbCompromisos.SelectedValue) > 0 Then
                        BttCicloca.Enabled = False
                    Else
                        BttCicloca.Enabled = True

                        If IsDBNull(Me.CREDSeguimientoBindingSource.Current("Fecha_Compromiso")) Then
                            DTPcompromiso.Value = CDate("1900-01-01")
                        End If
                        If DTPcompromiso.Value = CDate("1900-01-01") Then
                            DTPcompromiso.Enabled = True
                        Else
                            DTPcompromiso.Enabled = False
                        End If
                    End If
                End If
            Else
                BttCicloca.Enabled = False
            End If
        Else
            BttCicloca.Enabled = False
        End If
    End Sub
End Class