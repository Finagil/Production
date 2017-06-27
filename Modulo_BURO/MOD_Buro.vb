Module MOD_Buro

    Sub LlenaNombres(ByRef cONN As SqlClient.SqlConnection)
        Cursor.Current = Cursors.WaitCursor
        Dim taClientes As New BuroDSTableAdapters.ClientesTableAdapter
        taClientes.Connection = cONN
        Dim t As New BuroDS.ClientesDataTable
        Dim r As BuroDS.ClientesRow
        Dim cCusnam As String = ""
        Dim cNombre As String = ""
        Dim cPaterno As String = ""
        Dim cMaterno As String = ""
        Dim i As Integer
        Dim nEspacios As Integer
        Dim newfrmPideNombre As frmPideNombre
        taClientes.Fill(t)
        For Each r In t.Rows
            cCusnam = r.Descr.Trim()
            nEspacios = 0
            For i = 1 To Len(cCusnam)
                If Mid(cCusnam, i, 1) = " " Then
                    nEspacios += 1
                End If
            Next

            If nEspacios = 1 Then

                cNombre = ""
                i = 1
                While Mid(cCusnam, i, 1) <> " "
                    cNombre += Mid(cCusnam, i, 1)
                    i += 1
                End While
                i += 1

                cPaterno = ""
                While i <= Len(cCusnam)
                    cPaterno += Mid(cCusnam, i, 1)
                    i += 1
                End While
                i += 1
                cMaterno = ""
                taClientes.llenaNombre(cNombre, cPaterno, cMaterno, r.Cliente)
            End If

            If nEspacios = 2 Then

                cNombre = ""
                i = 1
                While Mid(cCusnam, i, 1) <> " "
                    cNombre += Mid(cCusnam, i, 1)
                    i += 1
                End While
                i += 1

                cPaterno = ""
                While Mid(cCusnam, i, 1) <> " "
                    cPaterno += Mid(cCusnam, i, 1)
                    i += 1
                End While
                i += 1

                cMaterno = ""
                While i <= Len(cCusnam)
                    cMaterno += Mid(cCusnam, i, 1)
                    i += 1
                End While
                taClientes.llenaNombre(cNombre, cPaterno, cMaterno, r.Cliente)
            End If


            If nEspacios = 1 Or nEspacios > 3 Then
                newfrmPideNombre = New frmPideNombre("M", cCusnam, r.Cliente)
                newfrmPideNombre.ShowDialog()
                cNombre = newfrmPideNombre.Nombre
                cPaterno = newfrmPideNombre.Paterno
                cMaterno = newfrmPideNombre.Materno
            End If

            If nEspacios = 3 Then
                cNombre = ""
                i = 1
                While Mid(cCusnam, i, 1) <> " "
                    cNombre += Mid(cCusnam, i, 1)
                    i += 1
                End While
                i += 1
                cNombre += " "

                While Mid(cCusnam, i, 1) <> " "
                    cNombre += Mid(cCusnam, i, 1)
                    i += 1
                End While
                i += 1

                cPaterno = ""
                While Mid(cCusnam, i, 1) <> " "
                    cPaterno += Mid(cCusnam, i, 1)
                    i += 1
                End While
                i += 1

                cMaterno = ""
                While i <= Len(cCusnam)
                    cMaterno += Mid(cCusnam, i, 1)
                    i += 1
                End While
                taClientes.llenaNombre(cNombre, cPaterno, cMaterno, r.Cliente)
            End If
        Next
        Cursor.Current = Cursors.Default
        MessageBox.Show("Proceso Lectura de nombres Terminado", "Llenar Nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

End Module
