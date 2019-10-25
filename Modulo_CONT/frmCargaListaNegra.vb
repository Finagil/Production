Imports System
Imports System.IO
Imports System.Text.RegularExpressions
Public Class frmCargaListaNegra
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProcesarArchivo.Click
        Dim openFileDialog1 As New OpenFileDialog()


        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "txt files (*.csv)|*.csv"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        openFileDialog1.Multiselect = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then


            Dim sLine() As String
            Dim arrText As New ArrayList()
            Dim cont As Integer = 0
            Dim contE As Integer = 0
            Dim bandera As String = ""
            Dim errores As String = ""
            Dim ta69 As New CreditoDSTableAdapters.CRED_Lista_Art69TableAdapter
            Dim ta69B As New CreditoDSTableAdapters.CRED_Lista_Art69BTableAdapter
            Dim ta69F As New CreditoDSTableAdapters.CRED_ListaFechaArf69TableAdapter

            ta69F.DeleteQuery()
            ta69.DeleteQuery()
            ta69B.DeleteQuery()
            ta69F.Insert(Date.Now.ToString)

            For Each files As String In openFileDialog1.FileNames
                Dim objReader As New System.IO.StreamReader(files)
                ' Dim partes As MatchCollection
                Try
                    While Not objReader.EndOfStream
                        Try
                            Dim lineas As String = objReader.ReadLine().Replace(Chr(34) & Chr(34), "") '.Replace(", ", " ").Replace(",, ", " ").Replace(",.", " ")

                            'partes = Regex.Matches(lineas, "\d+")

                            sLine = lineas.Split(",")

                            If sLine(0).Trim = "RFC" Then
                                bandera = "Art69"
                            ElseIf sLine(0).Trim = "No." Or sLine(0).Trim = "No" Then
                                bandera = "Art69B"
                            ElseIf sLine(1).Trim = "Tipo persona" Then
                                bandera = "CAN"
                            End If

                            If bandera = "Art69" And cont > 0 Then
                                sLine = lineas.Split(Chr(34))
                                Dim sLinea As String
                                If sLine.Length > 1 Then
                                    sLinea = sLine(0) & sLine(1).Replace(",", "").Replace(Chr(34), "") & sLine(2)
                                Else
                                    sLinea = sLine(0)
                                End If

                                sLine = sLinea.Split(",")
                                If sLine(0) <> "" Then
                                    ta69.Insert(sLine(0), sLine(2), sLine(3), sLine(1))
                                End If

                            ElseIf bandera = "CAN" And cont > 0 Then
                                    sLine = lineas.Split(Chr(34))
                                    Dim sLinea As String
                                    If sLine.Length > 1 Then
                                        sLinea = sLine(0) & sLine(1).Replace(",", "").Replace(Chr(34), "") & sLine(2)
                                    Else
                                        sLinea = sLine(0)
                                    End If

                                sLine = sLinea.Split(",")
                                If sLine(0) <> "" Then
                                    ta69.Insert(sLine(2), sLine(1).Replace("Persona F¡sica", "F").Replace("Persona Moral", "M"), "CANCELADOS", sLine(3))
                                End If

                            ElseIf bandera = "Art69B" And cont > 2 Then
                                    sLine = lineas.Split(Chr(34))
                                Dim sLineb As String
                                If sLine.Length > 1 Then
                                    sLineb = sLine(0) & sLine(1).Replace(",", "").Replace(Chr(34), "") & sLine(2)
                                Else
                                    sLineb = sLine(0)
                                End If

                                sLine = sLineb.Split(",")
                                If sLine(0) <> "" Then
                                    ta69B.Insert(sLine(1), sLine(3), sLine(2))
                                End If
                            End If
                                cont += 1
                            tssbContador.Text = "Leyendo línea: " + cont.ToString + " RFC: " + sLine(1) + " / " + sLine(2)
                            Me.Update()
                            sLine = Nothing
                        Catch ex1 As Exception
                            'MsgBox(partes.Item(1))
                            contE += 1
                        End Try
                    End While
                Catch ex As Exception
                    'errores += "Error: " + ex.ToString + " en linea " + cont.ToString + vbNewLine
                    MsgBox(cont.ToString, MsgBoxStyle.Exclamation, "Líneas procesadas...")
                    MsgBox(contE.ToString, MsgBoxStyle.Exclamation, "Líneas con errores...")
                End Try
                objReader.Close()
            Next
            MsgBox(cont.ToString, MsgBoxStyle.Exclamation, "Líneas procesadas...")
            MsgBox(contE.ToString, MsgBoxStyle.Exclamation, "Líneas con errores...")
            MsgBox("Proceso terminado...", MsgBoxStyle.Information)
        End If
    End Sub
End Class