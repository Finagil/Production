Option Explicit On 

Imports System.Data.SqlClient
Imports System.Math

Module mIngresos

    Public Sub Ingresos(ByVal dtMovimientos As DataTable)

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim drMovimiento As DataRow
        Dim strInsert As String

        ' Declaración de variables de datos

        Dim cAnexo As String = ""
        Dim cBanco As String = ""
        Dim cCoa As String = ""
        Dim cFepag As String = ""
        Dim cConcepto As String = ""
        Dim nEsp As Decimal = 0
        Dim nImporteBanco As Decimal = 0
        Dim NoGrupo As Decimal = 0
        Dim cCatal As String = "F"
        Dim REP As String
        Dim FACT As String

        ' Es importante resaltar que solamente deberá hacerse un cargo a Bancos

        For Each drMovimiento In dtMovimientos.Rows
            If Mid(drMovimiento("Factura"), 1, 3) = "REP" And REP = "" Then
                REP = drMovimiento("Factura")
            End If
            If Mid(drMovimiento("Factura"), 1, 3) <> "REP" And FACT = "" Then
                FACT = drMovimiento("Factura")
            End If
            If drMovimiento("Catal") = "B" Then
                cCatal = drMovimiento("Catal")
            End If
            cAnexo = drMovimiento("Anexo")
            cCoa = drMovimiento("Coa")
            If cCoa = "0" Then
                nImporteBanco += drMovimiento("Imp")
            Else
                nImporteBanco -= drMovimiento("Imp")
            End If
            cFepag = drMovimiento("Fepag")
            cBanco = drMovimiento("Banco")
            cConcepto = drMovimiento("Concepto")
            NoGrupo = drMovimiento("Grupo")
        Next
        If REP <> "" Then
            FACT = REP
        End If
        If nImporteBanco < 0 Then
            nImporteBanco = Abs(nImporteBanco)
            cCoa = "0"
        ElseIf nImporteBanco > 0 Then
            cCoa = "1"
        End If

        Try

            cnAgil.Open()

            ' En primera instancia grabo los datos del movimiento BANCOS, en el cual en vez de guardar
            ' el número de anexo grabo el número de cliente ya que el cliente pudiera estar pagando más
            ' de un contrato.

            strInsert = "INSERT INTO Hisgin(Anexo, Letra, Tipos, Fepag, Cve, Imp, Tip, Catal, Esp, Coa, Tipmon, Banco, Concepto, Grupo, Factura)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & cAnexo & "', '"
            strInsert = strInsert & " " & "', '"
            strInsert = strInsert & " " & "', '"
            strInsert = strInsert & cFepag & "', '"
            strInsert = strInsert & "99" & "', '"
            strInsert = strInsert & nImporteBanco & "', '"
            strInsert = strInsert & "S" & "', '"
            strInsert = strInsert & cCatal & "', '"
            strInsert = strInsert & nEsp & "', '"
            strInsert = strInsert & cCoa & "', '"
            strInsert = strInsert & "01" & "', '"
            strInsert = strInsert & drMovimiento("Banco") & "', '"
            strInsert = strInsert & cConcepto
            strInsert = strInsert & "', " & NoGrupo & ",'" & FACT & "')"

            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()

            ' Ahora procedo a guardar todos los movimientos generados por el pago

            For Each drMovimiento In dtMovimientos.Rows

                strInsert = "INSERT INTO Hisgin(Anexo, Letra, Tipos, Fepag, Cve, Imp, Tip, Catal, Esp, Coa, Tipmon, Banco, Concepto, Factura, Grupo)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & drMovimiento("Anexo") & "', '"
                strInsert = strInsert & drMovimiento("Letra") & "', '"
                strInsert = strInsert & drMovimiento("Tipos") & "', '"
                strInsert = strInsert & drMovimiento("Fepag") & "', '"
                strInsert = strInsert & drMovimiento("Cve") & "', '"
                strInsert = strInsert & drMovimiento("Imp") & "', '"
                strInsert = strInsert & drMovimiento("Tip") & "', '"
                strInsert = strInsert & drMovimiento("Catal") & "', '"
                strInsert = strInsert & drMovimiento("Esp") & "', '"
                strInsert = strInsert & drMovimiento("Coa") & "', '"
                strInsert = strInsert & drMovimiento("Tipmon") & "', '"
                strInsert = strInsert & drMovimiento("Banco") & "', '"
                strInsert = strInsert & cConcepto & "', '"
                strInsert = strInsert & drMovimiento("Factura") & "',"
                strInsert = strInsert & drMovimiento("Grupo") & ")"

                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()

            Next

            cnAgil.Close()

        Catch eException As Exception

            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Public Sub IngresosFR(ByVal dtMovimientos As DataTable)

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim drMovimiento As DataRow
        Dim strInsert As String

        ' Declaración de variables de datos

        Dim cAnexo As String = ""
        Dim cBanco As String = ""
        Dim cCoa As String = ""
        Dim cFepag As String = ""
        Dim cConcepto As String = ""
        Dim nEsp As Decimal = 0
        Dim nImporteBanco As Decimal = 0
        Dim NoGrupo As Decimal = 0

        ' Es importante resaltar que solamente deberá hacerse un cargo al fondo de reserva

        For Each drMovimiento In dtMovimientos.Rows
            cAnexo = drMovimiento("Anexo")
            cCoa = drMovimiento("Coa")
            If cCoa = "0" Then
                nImporteBanco += drMovimiento("Imp")
            Else
                nImporteBanco -= drMovimiento("Imp")
            End If
            cFepag = drMovimiento("Fepag")
            cBanco = drMovimiento("Banco")
            cConcepto = drMovimiento("Concepto")
            NoGrupo = drMovimiento("Grupo")
        Next
        If nImporteBanco < 0 Then
            nImporteBanco = Abs(nImporteBanco)
            cCoa = "0"
        ElseIf nImporteBanco > 0 Then
            cCoa = "1"
        End If

        Try

            cnAgil.Open()

            ' En primera instancia grabo los datos del movimiento BANCOS, en el cual en vez de guardar
            ' el número de anexo grabo el número de cliente ya que el cliente pudiera estar pagando más
            ' de un contrato.

            strInsert = "INSERT INTO Hisgin(Anexo, Letra, Tipos, Fepag, Cve, Imp, Tip, Catal, Esp, Coa, Tipmon, Banco, Concepto, Grupo)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & cAnexo & "', '"
            strInsert = strInsert & " " & "', '"
            strInsert = strInsert & " " & "', '"
            strInsert = strInsert & cFepag & "', '"
            strInsert = strInsert & "68" & "', '"
            strInsert = strInsert & nImporteBanco & "', '"
            strInsert = strInsert & "S" & "', '"
            strInsert = strInsert & "F" & "', '"
            strInsert = strInsert & nEsp & "', '"
            strInsert = strInsert & cCoa & "', '"
            strInsert = strInsert & "01" & "', '"
            strInsert = strInsert & drMovimiento("Banco") & "', '"
            strInsert = strInsert & cConcepto
            strInsert = strInsert & "', " & NoGrupo & ")"

            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()

            ' Ahora procedo a guardar todos los movimientos generados por el pago

            For Each drMovimiento In dtMovimientos.Rows

                strInsert = "INSERT INTO Hisgin(Anexo, Letra, Tipos, Fepag, Cve, Imp, Tip, Catal, Esp, Coa, Tipmon, Banco, Concepto, Factura)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & drMovimiento("Anexo") & "', '"
                strInsert = strInsert & drMovimiento("Letra") & "', '"
                strInsert = strInsert & drMovimiento("Tipos") & "', '"
                strInsert = strInsert & drMovimiento("Fepag") & "', '"
                strInsert = strInsert & drMovimiento("Cve") & "', '"
                strInsert = strInsert & drMovimiento("Imp") & "', '"
                strInsert = strInsert & drMovimiento("Tip") & "', '"
                strInsert = strInsert & drMovimiento("Catal") & "', '"
                strInsert = strInsert & drMovimiento("Esp") & "', '"
                strInsert = strInsert & drMovimiento("Coa") & "', '"
                strInsert = strInsert & drMovimiento("Tipmon") & "', '"
                strInsert = strInsert & drMovimiento("Banco") & "', '"
                strInsert = strInsert & cConcepto & "', '"
                strInsert = strInsert & drMovimiento("Factura") & "',"
                strInsert = strInsert & drMovimiento("Grupo") & ")"

                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()

            Next

            cnAgil.Close()

        Catch eException As Exception

            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

End Module
