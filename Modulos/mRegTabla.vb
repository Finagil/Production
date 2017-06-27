Option Explicit On 

Imports System.Data.SqlClient
Imports System.Math

Module mRegTabla
  
    Public Sub RegTabla(ByVal cAnexo As String, ByVal nSaldoInsoluto As Decimal, ByVal nPlazoRestante As Integer, ByVal cTabla As String)

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daTabla As New SqlDataAdapter(cm1)
        Dim daAnexo As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()
        Dim drCambios As DataRow
        Dim drDatos As DataRow
        Dim dtCambios As New DataTable("Cambios")
        Dim strUpdate As String

        ' Declaración de variables de datos

        Dim nAbcap As Decimal
        Dim nInter As Decimal
        Dim nIva As Decimal
        Dim nIvacapital As Decimal
        Dim nNuevoSaldo As Decimal
        Dim nFactorIva As Decimal
        Dim nFactorCap As Decimal
        Dim nFactorInt As Decimal
        Dim n As Integer

        Select Case cTabla
            Case "E"
                With cm1
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "TablaEquipo1"
                    .Connection = cnAgil
                    .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                    .Parameters(0).Value = cAnexo
                End With
            Case "S"
                With cm1
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "TablaSeguro1"
                    .Connection = cnAgil
                    .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                    .Parameters(0).Value = cAnexo
                End With
            Case "O"
                With cm1
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "TraeAdeudos"
                    .Connection = cnAgil
                    .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                    .Parameters(0).Value = cAnexo
                End With
        End Select
        daTabla.Fill(dsAgil, "Tabla")

        ' Creo la estructura de la tabla temporal que guardará los cambios a la Tabla

        If cTabla = "E" Then
            dtCambios.Columns.Add("Letra", Type.GetType("System.String"))
            dtCambios.Columns.Add("Saldo", Type.GetType("System.String"))
            dtCambios.Columns.Add("Inter", Type.GetType("System.String"))
            dtCambios.Columns.Add("Abcap", Type.GetType("System.String"))
            dtCambios.Columns.Add("Iva", Type.GetType("System.String"))
            dtCambios.Columns.Add("Ivacap", Type.GetType("System.String"))
        Else
            dtCambios.Columns.Add("Letra", Type.GetType("System.String"))
            dtCambios.Columns.Add("Saldo", Type.GetType("System.String"))
            dtCambios.Columns.Add("Inter", Type.GetType("System.String"))
            dtCambios.Columns.Add("Abcap", Type.GetType("System.String"))
            dtCambios.Columns.Add("Iva", Type.GetType("System.String"))
        End If
        
        n = 0
        nIva = 0
        nIvacapital = 0
        For Each drCambios In dsAgil.Tables("Tabla").Rows
            If drCambios("Nufac") = 0 Then
                nFactorCap = drCambios("Abcap") / drCambios("Saldo")
                nFactorInt = drCambios("Inter") / drCambios("Saldo")

                If n = 0 Then
                    nNuevoSaldo = nSaldoInsoluto
                    n = 1
                Else
                    nNuevoSaldo = nNuevoSaldo - nAbcap
                End If

                nAbcap = nNuevoSaldo * nFactorCap
                nInter = nNuevoSaldo * nFactorInt

                If drCambios("Iva") > 0 Then
                    nFactorIva = drCambios("Iva") / drCambios("Inter")
                    nIva = nInter * nFactorIva
                End If

                If cTabla = "E" Then
                    If drCambios("Ivacapital") > 0 Then
                        nIvacapital = nAbcap * nFactorIva
                    End If
                End If
                
                drDatos = dtCambios.NewRow()
                drDatos("Letra") = drCambios("Letra")
                drDatos("Saldo") = nNuevoSaldo
                drDatos("Inter") = nInter
                drDatos("Abcap") = nAbcap
                drDatos("Iva") = nIva
                If cTabla = "E" Then
                    drDatos("Ivacap") = nIvacapital
                End If
                dtCambios.Rows.Add(drDatos)

            End If
        Next

        dsAgil.Tables.Add(dtCambios)

        cnAgil.Open()

        For Each drCambios In dsAgil.Tables("Cambios").Rows
            Select Case cTabla
                Case "E"
                    strUpdate = "UPDATE Edoctav SET Saldo = " & "'" & drCambios("Saldo") & "',"
                    strUpdate = strUpdate & " Abcap = " & " '" & drCambios("Abcap") & "',"
                    strUpdate = strUpdate & " Inter = " & "'" & drCambios("Inter") & "',"
                    strUpdate = strUpdate & " Iva = " & "'" & drCambios("Iva") & "',"
                    strUpdate = strUpdate & " IvaCapital = " & "'" & drCambios("Ivacap") & "'"
                    strUpdate = strUpdate & "WHERE Anexo = " & "'" & cAnexo & "'"
                    strUpdate = strUpdate & "And Letra = " & "'" & drCambios("Letra") & "'"
                Case "S"
                    strUpdate = "UPDATE Edoctas SET Saldo = " & "'" & drCambios("Saldo") & "',"
                    strUpdate = strUpdate & " Abcap = " & " '" & drCambios("Abcap") & "',"
                    strUpdate = strUpdate & " Inter = " & "'" & drCambios("Inter") & "',"
                    strUpdate = strUpdate & " Iva = " & "'" & drCambios("Iva") & "'"
                    strUpdate = strUpdate & "WHERE Anexo = " & "'" & cAnexo & "'"
                    strUpdate = strUpdate & "And Letra = " & "'" & drCambios("Letra") & "'"
                Case "O"
                    strUpdate = "UPDATE Edoctao SET Saldo = " & "'" & drCambios("Saldo") & "',"
                    strUpdate = strUpdate & " Abcap = " & " '" & drCambios("Abcap") & "',"
                    strUpdate = strUpdate & " Inter = " & "'" & drCambios("Inter") & "',"
                    strUpdate = strUpdate & " Iva = " & "'" & drCambios("Iva") & "'"
                    strUpdate = strUpdate & "WHERE Anexo = " & "'" & cAnexo & "'"
                    strUpdate = strUpdate & "And Letra = " & "'" & drCambios("Letra") & "'"
            End Select

            Try
                cm2 = New SqlCommand(strUpdate, cnAgil)
                cm2.ExecuteNonQuery()
            Catch eException As Exception
                MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje")
            End Try

        Next

        cnAgil.Close()

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()

    End Sub

End Module
