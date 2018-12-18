Imports System
Imports System.IO
Public Class frmCargaListaNegra
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProcesarArchivo.Click
        Dim openFileDialog1 As New OpenFileDialog()


        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "txt files (*.csv)|*.csv"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim objReader As New System.IO.StreamReader(openFileDialog1.FileName)
            Dim sLine() As String
            Dim arrText As New ArrayList()
            Dim cont As Integer = 0
            Dim bandera As String = ""
            Dim errores As String = ""
            Dim ta69 As New CreditoDSTableAdapters.CRED_Lista_Art69TableAdapter
            Dim ta69B As New CreditoDSTableAdapters.CRED_Lista_Art69BTableAdapter
            Dim ta69F As New CreditoDSTableAdapters.CRED_ListaFechaArf69TableAdapter

            ta69F.DeleteQuery()
            ta69F.Insert(Date.Now.ToString)
            Try
                While Not objReader.EndOfStream
                    Try
                        sLine = objReader.ReadLine().Split(",")

                        If sLine(0) = "RFC" Then
                            bandera = "Art69"
                            ta69.DeleteQuery()
                        ElseIf sLine(0) = "No." Then
                            ta69B.DeleteQuery()
                            bandera = "Art69B"
                        End If

                        If bandera = "Art69" And cont > 0 Then
                            ta69.Insert(sLine(0), sLine(2), sLine(3), sLine(1))
                        ElseIf bandera = "Art69B" And cont > 2 Then
                            ta69B.Insert(sLine(1), sLine(3), sLine(2))
                        End If
                        cont += 1
                        tssbContador.Text = "Leyendo línea: " + cont.ToString + " RFC: " + sLine(1) + " / " + sLine(2)
                        Me.Update()
                        sLine = Nothing
                    Catch ex1 As Exception
                        MsgBox(ex1.ToString)
                    End Try
                End While
            Catch ex As Exception
                errores += "Error: " + ex.ToString + " en linea " + cont.ToString + vbNewLine
                MsgBox(cont.ToString,, "Líneas procesadas...")
            End Try
            objReader.Close()
            MsgBox("Proceso terminado...")
        End If
    End Sub
End Class