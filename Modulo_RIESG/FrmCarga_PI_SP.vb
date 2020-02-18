Imports System.IO
Public Class FrmCarga_PI_SP
    Dim Ta_Pi As New RiesgosDSTableAdapters.FIRA_PITableAdapter
    Dim Ta_Sp As New RiesgosDSTableAdapters.FIRA_SPTableAdapter
    Dim F1 As StreamReader
    Dim ContPI As Integer
    Dim ContSP As Integer
    Private Sub ButtonSelect_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click
        TextF1.Clear()
        TextF2.Clear()
        OpenFileDialog1.FileName = "INFORMACION_PARA_PI_SP"
        OpenFileDialog1.Title = "Seleciona Archvivos PI y SP"
        OpenFileDialog1.Filter = "CSV files (*.csv)|*.csv"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim selectfiles() As String = OpenFileDialog1.FileNames
            If selectfiles.Length >= 1 Then TextF1.Text = selectfiles(0)
            If selectfiles.Length >= 2 Then TextF2.Text = selectfiles(1)
            If TextF1.Text <> "" And TextF2.Text <> "" Then
                ButtonCarga.Enabled = True
            Else
                MessageBox.Show("Faltan Archivos", "Error de Archivos seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ButtonCarga.Enabled = False
            End If
        End If
    End Sub

    Private Sub ButtonCarga_Click(sender As Object, e As EventArgs) Handles ButtonCarga.Click
        Ta_Pi.DeleteALL()
        Ta_Sp.DeleteALL()
        Try
            ContPI = 0
            ContSP = 0

            Cursor.Current = Cursors.WaitCursor
            F1 = New StreamReader(TextF1.Text)
            CargaArchivo(F1)
            F1.Close()

            F1 = New StreamReader(TextF2.Text)
            CargaArchivo(F1)
            F1.Close()
            MessageBox.Show("Datos PI : " & ContPI & vbCr & "Datos SP: " & ContSP, "Archivos Cargados.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            F1.Close()
            Cursor.Current = Cursors.Default
            MessageBox.Show(ex.Message, "Error de Archivos seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub CargaArchivo(ByRef FX As StreamReader)
        Dim PriemeraFila As Boolean = True
        Dim Lin As String
        Dim Cad() As String
        While FX.EndOfStream = False
            If PriemeraFila = True Then
                Lin = FX.ReadLine()
                Cad = Lin.Split(",")
                PriemeraFila = False
            End If

            If (Cad.Length <> 87 And Cad.Length <> 42) And (ContPI = 0 Or ContSP = 0) Then
                MessageBox.Show("Archivo No valido.", "Error de Archivos seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Lin = FX.ReadLine()
                Cad = Lin.Split(",")
            End If

            If Cad.Length = 87 Then
                ContPI += 1
                Cad(0) = Cad(0).Replace("""", "")
                Cad(1) = Cad(1).Replace("""", "")
                Try
                    Ta_Pi.Insert(Cad(0), Cad(1), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                Catch ex As Exception
                End Try
            ElseIf Cad.Length = 42 Then
                Cad(0) = Cad(0).Replace("""", "")
                Cad(1) = Cad(1).Replace("""", "")
                Cad(2) = Cad(2).Replace("""", "")
                Cad(3) = Cad(3).Replace("""", "")
                ContSP += 1
                Try
                    Ta_Sp.Insert(Cad(0), Cad(1), Cad(2), Cad(3), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                Catch ex As Exception
                End Try
            End If
        End While

    End Sub
End Class