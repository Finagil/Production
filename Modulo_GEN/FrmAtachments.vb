﻿Imports System.ComponentModel
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


    Private Sub FrmAtachments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Documentos " & Carpeta & " " & Nombre & " " & Anexo
        If id_Externo > 0 Then
            Me.GEN_AtachmentsTableAdapter.FillByidExterno(GeneralDS.GEN_Atachments, id_Externo, Carpeta)
        ElseIf Cliente > "" Then
            Me.GEN_AtachmentsTableAdapter.FillByCliente(GeneralDS.GEN_Atachments, Cliente, Carpeta)
        ElseIf Anexo > "" Then
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
        Botones(True)
        TxtDesc.Focus()
        GENAtachmentsBindingSource.Current("Carpeta") = Carpeta
        GENAtachmentsBindingSource.Current("Fecha") = Today
        GENAtachmentsBindingSource.Current("Usuario") = UsuarioGlobal
        GENAtachmentsBindingSource.Current("Anexo") = Anexo
        GENAtachmentsBindingSource.Current("Ciclo") = Ciclo
        GENAtachmentsBindingSource.Current("Cliente") = Cliente
        GENAtachmentsBindingSource.Current("id_Externo") = id_Externo
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
        Botones(True)
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If TxtDesc.Text = "" Then
            MessageBox.Show("Falta descripcíon del archivo", "Adjuntar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Txtfile.Text = "" Then
            MessageBox.Show("Falta adjuntar archivo", "Adjuntar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            GENAtachmentsBindingSource.EndEdit()
            GeneralDS.GEN_Atachments.GetChanges()
            Me.GEN_AtachmentsTableAdapter.Update(GeneralDS.GEN_Atachments)
            My.Computer.FileSystem.RenameFile(RutaOnbase & Carpeta & "\" & GENAtachmentsBindingSource.Current("Documento"), GENAtachmentsBindingSource.Current("Id_Atachment") & GENAtachmentsBindingSource.Current("Documento"))
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        If GeneralDS.GEN_Atachments.Rows.Count <= 0 Then
            MessageBox.Show("No existen datos para borrar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                File.Copy(RutaOnbase & Carpeta & "\" & GENAtachmentsBindingSource.Current("Id_Atachment") & GENAtachmentsBindingSource.Current("Documento"), Archivo, True)
                Dim procID As Integer
                Dim newProc As Diagnostics.Process
                newProc = Diagnostics.Process.Start(Archivo)
                'procID = newProc.Id
                'Dim procEC As Integer = -1
                'If newProc.HasExited Then
                '    procEC = newProc.ExitCode
                'End If
                'newProc.Close()
                'newProc.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error " & Archivo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Cursor.Current = Cursors.Default
        End If
    End Sub

End Class