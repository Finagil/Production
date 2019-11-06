Imports System.ComponentModel
Imports System.IO
Public Class FrmAtachments
    Dim RutaOnbase As String = "\\server-nas\OnBase\DATFinagil\"
    Public Carpeta As String
    Public id_Externo As Decimal
    Public Cliente As String
    Public Anexo As String
    Public Ciclo As String
    Public Nombre As String
    Public Consulta As Boolean = True
    Dim AdjuntoNEW As Boolean = False


    Private Sub FrmAtachments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists(RutaOnbase & Carpeta) Then
            Directory.CreateDirectory(RutaOnbase & Carpeta)
        End If

        Me.GEN_AtachmentsTipoAttachTableAdapter.Fill(Me.GeneralDS.GEN_AtachmentsTipoAttach, Carpeta)
        Me.Text = "Documentos " & Carpeta & " " & Nombre & " " & Anexo
        If id_Externo > 0 Then
            Me.GEN_AtachmentsTableAdapter.FillByidExterno(GeneralDS.GEN_Atachments, id_Externo, Carpeta)
        ElseIf Cliente > "" Then
            Me.GEN_AtachmentsTableAdapter.FillByCliente(GeneralDS.GEN_Atachments, Cliente, Carpeta)
        ElseIf Anexo > "" Then
            Me.GEN_AtachmentsTableAdapter.FillByAnexo(GeneralDS.GEN_Atachments, Anexo, Ciclo, Carpeta)
        ElseIf Ciclo > "" Then
            Me.GEN_AtachmentsTableAdapter.FillByAnexo(GeneralDS.GEN_Atachments, Anexo, Ciclo, Carpeta)
        End If
        If GeneralDS.GEN_Atachments.Rows.Count > 0 And Consulta = False Then
            Buttonmod.Enabled = True
            ButtonDel.Enabled = True
            Buttonnew.Enabled = True
        ElseIf Consulta = False Then
            Buttonnew.Enabled = True
        End If
    End Sub

    Private Sub Buttonnew_Click(sender As Object, e As EventArgs) Handles Buttonnew.Click
        GENAtachmentsBindingSource.AddNew()
        GENAtachmentsBindingSource.Current("Carpeta") = Carpeta
        GENAtachmentsBindingSource.Current("Fecha") = Today
        GENAtachmentsBindingSource.Current("Usuario") = UsuarioGlobal
        GENAtachmentsBindingSource.Current("Anexo") = Anexo
        GENAtachmentsBindingSource.Current("Ciclo") = Ciclo
        GENAtachmentsBindingSource.Current("Cliente") = Cliente
        GENAtachmentsBindingSource.Current("id_Externo") = id_Externo
        Botones(True)
        ComboBox1.Focus()
    End Sub

    Sub Botones(ban As Boolean)
        Buttonnew.Enabled = Not ban
        Buttonmod.Enabled = Not ban
        ButtonDel.Enabled = Not ban
        ButtonSave.Enabled = ban
        ButtonCancel.Enabled = ban
        Grpdatos.Enabled = ban
    End Sub

    Private Sub Buttonmod_Click(sender As Object, e As EventArgs) Handles Buttonmod.Click
        If GENAtachmentsBindingSource.Current("Usuario") <> UsuarioGlobal Then
            MessageBox.Show("No puedes Modificar documentos de otro usuario. " & GENAtachmentsBindingSource.Current("Usuario"), "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Botones(True)
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If TxtDesc.Text = "" Then
            MessageBox.Show("Falta descripcíon del archivo", "Adjuntar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Txtfile.Text = "" Then
            MessageBox.Show("Falta adjuntar archivo", "Adjuntar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If Carpeta = "Observaciones" Then
                If MessageBox.Show("¿Desea guardar sin archivo adjunto?", "Adjuntar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    GENAtachmentsBindingSource.Current("Documento") = "Finagil.png"
                    My.Computer.FileSystem.CopyFile(RutaOnbase & Carpeta & "\" & "Finagil.png", RutaOnbase & Carpeta & "\" & GENAtachmentsBindingSource.Current("Id_Atachment") & "Finagil.png", True)
                    AdjuntoNEW = False
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If

        End If
        Try
            GENAtachmentsBindingSource.Current("Titulo") = Mid(ComboBox1.Text.Trim & "-" & TxtDesc.Text.Trim, 1, 100)
            GENAtachmentsBindingSource.EndEdit()
            GeneralDS.GEN_Atachments.GetChanges()
            Me.GEN_AtachmentsTableAdapter.Update(GeneralDS.GEN_Atachments)
            If AdjuntoNEW Then
                My.Computer.FileSystem.RenameFile(RutaOnbase & Carpeta & "\" & GENAtachmentsBindingSource.Current("Documento"), GENAtachmentsBindingSource.Current("Id_Atachment") & GENAtachmentsBindingSource.Current("Documento"))
                AdjuntoNEW = False
            End If
            'DialogResult = Windows.Forms.DialogResult.OK
            Botones(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        If GeneralDS.GEN_Atachments.Rows.Count <= 0 Then
            MessageBox.Show("No existen datos para borrar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If GENAtachmentsBindingSource.Current("Usuario") <> UsuarioGlobal Then
            MessageBox.Show("No puedes eliminar documentos de otro usuario. " & GENAtachmentsBindingSource.Current("Usuario"), "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("¿estas seguro de eliminar el documento?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            GENAtachmentsBindingSource.RemoveCurrent()
            GeneralDS.GEN_Atachments.GetChanges()
            Me.GEN_AtachmentsTableAdapter.Update(GeneralDS.GEN_Atachments)
            Botones(False)
            FrmAtachments_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        FrmAtachments_Load(Nothing, Nothing)
        Botones(False)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AdjuntoNEW = False
        Dim op As New OpenFileDialog
        Dim id As String = ""
        op.Multiselect = False
        If op.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If op.SafeFileName.Length > 100 Then
                MessageBox.Show("Nombre de archivo muy Largo (maximo 100 caracteres)", "Subir documentos Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Cursor.Current = Cursors.WaitCursor
                Txtfile.Text = op.SafeFileName
                File.Copy(op.FileName, RutaOnbase & Carpeta & "\" & op.SafeFileName, True)
                Cursor.Current = Cursors.Default
                AdjuntoNEW = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Subir documentos Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub LstDoctos_DoubleClick(sender As Object, e As EventArgs) Handles LstDoctos.DoubleClick
        If LstDoctos.SelectedIndex >= 0 Then
            Cursor.Current = Cursors.WaitCursor
            Dim Archivo As String
            Archivo = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & GENAtachmentsBindingSource.Current("Id_Atachment") & GENAtachmentsBindingSource.Current("Documento")
            Try
                If InStr(Archivo, "Finagil.png") > 0 Then
                    File.Copy(RutaOnbase & Carpeta & "\Finagil.png", Archivo, True)
                Else
                    File.Copy(RutaOnbase & Carpeta & "\" & GENAtachmentsBindingSource.Current("Id_Atachment") & GENAtachmentsBindingSource.Current("Documento"), Archivo, True)
                End If
                Dim procID As Integer
                Dim newProc As Diagnostics.Process
                newProc = Diagnostics.Process.Start(Archivo)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error " & Archivo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Asunto As String = "Aviso de actualizacion: " & Me.Text
        Dim Mensaje As String = ""

        For Each item As DataRowView In LstDoctos.Items
            Dim row As DataRow = item.Row
            Mensaje += item.Row(0)
        Next

        If MandaCorreoFase(UsuarioGlobalCorreo, "DOC_" & Carpeta, Asunto, Mensaje) = True Then
            MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", Asunto, Mensaje)
            MessageBox.Show("Correo Enviado ", "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No Hay Correos configurados para " & Carpeta, "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Txtfile_DragDrop(sender As Object, e As DragEventArgs) Handles Txtfile.DragDrop
        Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files IsNot Nothing AndAlso files.Length <> 0 Then
            Dim f As New FileInfo(files(0))
            Try
                Cursor.Current = Cursors.WaitCursor
                Txtfile.Text = f.Name
                File.Copy(f.FullName, RutaOnbase & Carpeta & "\" & f.Name, True)
                Cursor.Current = Cursors.Default
                AdjuntoNEW = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Subir documentos Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Txtfile_DragEnter(sender As Object, e As DragEventArgs) Handles Txtfile.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            'Mostramos el puntero de copia en una operación arrastrar y soltar.
            e.Effect = DragDropEffects.Copy
        Else
            'Mostramos el puntero normal.
            e.Effect = DragDropEffects.None
        End If

    End Sub
End Class