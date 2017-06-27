Option Explicit On

Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Math
Public Class frmALtaTasasvig

    Private Sub frmAltaTasasvig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daPeriodos As New SqlDataAdapter(cm1)
        Dim drPeriod As DataRow
        Dim drTabla As DataRow

        Dim nPeriodo As Integer
        Dim cFechai As String
        Dim dFechaf As Date
        Dim dFecha As Date

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Periodo, FechaInip, FechaFinp, Vigente FROM PeriodoTasas Order by Periodo"
            .Connection = cnAgil
        End With
        daPeriodos.Fill(dsAgil, "Periodos")

        For Each drPeriod In dsAgil.Tables("Periodos").Rows
            If drPeriod("Vigente") = "S" Then
                nPeriodo = drPeriod("Periodo")
                cFechai = drPeriod("FechaFinp")
            End If
        Next
        txtPeriodo.Text = nPeriodo + 1
        dFecha = CTOD(cFechai)
        dFecha = DateAdd(DateInterval.Day, 1, dFecha)
        dFechaf = DateAdd(DateInterval.Day, 6, dFecha)
        dtpFecha.Value = dFecha
        dtpFecha2.Value = dFechaf
    End Sub

    Private Sub txtTF1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTF1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtTF1.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTF2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTF2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtTF2.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTF3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTF3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtTF3.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTF4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTF4.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtTF4.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTF5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTF5.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtTF5.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTV1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTV1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtTV1.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTV2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTV2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtTV2.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTV3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTV3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtTV3.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTV4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTV4.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtTV4.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTV5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTV5.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtTV5.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPTF1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTF1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtPTF1.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPTF2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTF2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtPTF2.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPTF3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTF3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtPTF3.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPTF4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTF4.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtPTF4.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPTV1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTV1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtPTV1.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPTV2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTV2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtPTV2.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPTV3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTV3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtPTV3.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPTV4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTV4.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtPTV4.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtRD1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRD1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtRD1.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtRD2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRD2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtRD2.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtRD3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRD3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtRD3.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtDG1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDG1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtDG1.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtDG2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDG2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtDG2.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtDG3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDG3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtDG3.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtDG4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDG4.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtDG4.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR1.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR2.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR3.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR4.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR4.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR1RD1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR1RD1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR1RD1.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR1RD2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR1RD2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR1RD2.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR1RD3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR1RD3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR1RD3.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR1RD4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR1RD4.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR1RD4.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR2RD1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR2RD1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR2RD1.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR2RD2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR2RD2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR2RD2.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR2RD3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR2RD3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR2RD3.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR2RD4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR2RD4.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR2RD4.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR3RD1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR3RD1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR3RD1.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR3RD2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR3RD2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR3RD2.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR3RD3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR3RD3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR3RD3.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtVR3RD4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVR3RD4.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, txtVR3RD4.Text))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Declaración de variables de conexión ADO .NET
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim strInsert As String
        Dim i As Byte

        cnAgil.Open()
        strInsert = "INSERT INTO PeriodoTasas(Periodo, FechaInip, FechaFinp, Vigente)"
        strInsert = strInsert & " VALUES ('" & txtPeriodo.Text & "', '" & DTOC(dtpFecha.Value) & "', '"
        strInsert = strInsert & DTOC(dtpFecha2.Value) & "', '"
        strInsert = strInsert & "N" & "')"
        cm1 = New SqlCommand(strInsert, cnAgil)
        cm1.ExecuteNonQuery()
        cnAgil.Close()

        cnAgil.Open()
        For i = 1 To 48
            strInsert = "INSERT INTO TasasAplicables(Periodo,TipoCredito,LimiteInferior,LimiteSuperior,TasaAplicable,RD1,RD2,RD3,DG,DG5,DG10,DG15,VR,VR1RD,VR2RD,VR3RD)"
            If i <= 5 Then
                strInsert = strInsert & " VALUES ('" & txtPeriodo.Text & "', '" & "AFCONIVA" & "', '"
                Select Case i
                    Case 1
                        strInsert = strInsert & "1" & "', '"
                        strInsert = strInsert & "12" & "', '"
                        strInsert = strInsert & txtTF1.Text & "', '"
                    Case 2
                        strInsert = strInsert & "13" & "', '"
                        strInsert = strInsert & "24" & "', '"
                        strInsert = strInsert & txtTF2.Text & "', '"
                    Case 3
                        strInsert = strInsert & "25" & "', '"
                        strInsert = strInsert & "36" & "', '"
                        strInsert = strInsert & txtTF3.Text & "', '"
                    Case 4
                        strInsert = strInsert & "37" & "', '"
                        strInsert = strInsert & "48" & "', '"
                        strInsert = strInsert & txtTF4.Text & "', '"
                    Case 5
                        strInsert = strInsert & "49" & "', '"
                        strInsert = strInsert & "60" & "', '"
                        strInsert = strInsert & txtTF5.Text & "', '"
                End Select
                strInsert = strInsert & txtRD1.Text & "', '"
                strInsert = strInsert & txtRD2.Text & "', '"
                strInsert = strInsert & txtRD3.Text & "', '"
                strInsert = strInsert & txtDG1.Text & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "')"
            ElseIf i > 5 And i <= 10 Then
                strInsert = strInsert & " VALUES ('" & txtPeriodo.Text & "', '" & "AFSINIVA" & "', '"
                Select Case i
                    Case 6
                        strInsert = strInsert & "1" & "', '"
                        strInsert = strInsert & "12" & "', '"
                        strInsert = strInsert & txtTF1.Text & "', '"
                    Case 7
                        strInsert = strInsert & "13" & "', '"
                        strInsert = strInsert & "24" & "', '"
                        strInsert = strInsert & txtTF2.Text & "', '"
                    Case 8
                        strInsert = strInsert & "25" & "', '"
                        strInsert = strInsert & "36" & "', '"
                        strInsert = strInsert & txtTF3.Text & "', '"
                    Case 9
                        strInsert = strInsert & "37" & "', '"
                        strInsert = strInsert & "48" & "', '"
                        strInsert = strInsert & txtTF4.Text & "', '"
                    Case 10
                        strInsert = strInsert & "49" & "', '"
                        strInsert = strInsert & "60" & "', '"
                        strInsert = strInsert & txtTF5.Text & "', '"
                End Select
                strInsert = strInsert & txtRD1.Text & "', '"
                strInsert = strInsert & txtRD2.Text & "', '"
                strInsert = strInsert & txtRD3.Text & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "')"
            ElseIf i > 10 And i <= 14 Then
                strInsert = strInsert & " VALUES ('" & txtPeriodo.Text & "', '" & "AP" & "', '"
                Select Case i
                    Case 11
                        strInsert = strInsert & "24" & "', '"
                        strInsert = strInsert & "35" & "', '"
                        strInsert = strInsert & txtPTF1.Text & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & txtVR1.Text & "', '"
                        strInsert = strInsert & txtVR1RD1.Text & "', '"
                        strInsert = strInsert & txtVR2RD1.Text & "', '"
                        strInsert = strInsert & txtVR3RD1.Text & "')"
                    Case 12
                        strInsert = strInsert & "36" & "', '"
                        strInsert = strInsert & "47" & "', '"
                        strInsert = strInsert & txtPTF2.Text & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & txtVR2.Text & "', '"
                        strInsert = strInsert & txtVR1RD2.Text & "', '"
                        strInsert = strInsert & txtVR2RD2.Text & "', '"
                        strInsert = strInsert & txtVR3RD2.Text & "')"
                    Case 13
                        strInsert = strInsert & "48" & "', '"
                        strInsert = strInsert & "59" & "', '"
                        strInsert = strInsert & txtPTF3.Text & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & txtVR3.Text & "', '"
                        strInsert = strInsert & txtVR1RD3.Text & "', '"
                        strInsert = strInsert & txtVR2RD3.Text & "', '"
                        strInsert = strInsert & txtVR3RD3.Text & "')"
                    Case 14
                        strInsert = strInsert & "60" & "', '"
                        strInsert = strInsert & "60" & "', '"
                        strInsert = strInsert & txtPTF4.Text & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & txtVR4.Text & "', '"
                        strInsert = strInsert & txtVR1RD4.Text & "', '"
                        strInsert = strInsert & txtVR2RD4.Text & "', '"
                        strInsert = strInsert & txtVR3RD4.Text & "')"
                End Select
            ElseIf i > 14 And i <= 19 Then
                strInsert = strInsert & " VALUES ('" & txtPeriodo.Text & "', '" & "CR" & "', '"
                Select Case i
                    Case 15
                        strInsert = strInsert & "1" & "', '"
                        strInsert = strInsert & "12" & "', '"
                        strInsert = strInsert & txtTF1.Text & "', '"
                    Case 16
                        strInsert = strInsert & "13" & "', '"
                        strInsert = strInsert & "24" & "', '"
                        strInsert = strInsert & txtTF2.Text & "', '"
                    Case 17
                        strInsert = strInsert & "25" & "', '"
                        strInsert = strInsert & "36" & "', '"
                        strInsert = strInsert & txtTF3.Text & "', '"
                    Case 18
                        strInsert = strInsert & "37" & "', '"
                        strInsert = strInsert & "48" & "', '"
                        strInsert = strInsert & txtTF4.Text & "', '"
                    Case 19
                        strInsert = strInsert & "49" & "', '"
                        strInsert = strInsert & "60" & "', '"
                        strInsert = strInsert & txtTF5.Text & "', '"
                End Select
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & txtDG2.Text & "', '"
                strInsert = strInsert & txtDG3.Text & "', '"
                strInsert = strInsert & txtDG4.Text & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "')"
            ElseIf i > 19 And i <= 24 Then
                strInsert = strInsert & " VALUES ('" & txtPeriodo.Text & "', '" & "CS" & "', '"
                Select Case i
                    Case 20
                        strInsert = strInsert & "1" & "', '"
                        strInsert = strInsert & "12" & "', '"
                        strInsert = strInsert & txtTF1.Text & "', '"
                    Case 21
                        strInsert = strInsert & "13" & "', '"
                        strInsert = strInsert & "24" & "', '"
                        strInsert = strInsert & txtTF2.Text & "', '"
                    Case 22
                        strInsert = strInsert & "25" & "', '"
                        strInsert = strInsert & "36" & "', '"
                        strInsert = strInsert & txtTF3.Text & "', '"
                    Case 23
                        strInsert = strInsert & "37" & "', '"
                        strInsert = strInsert & "48" & "', '"
                        strInsert = strInsert & txtTF4.Text & "', '"
                    Case 24
                        strInsert = strInsert & "49" & "', '"
                        strInsert = strInsert & "60" & "', '"
                        strInsert = strInsert & txtTF5.Text & "', '"
                End Select
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "')"
            ElseIf i > 24 And i <= 29 Then
                strInsert = strInsert & " VALUES ('" & txtPeriodo.Text & "', '" & "TVAFCONIVA" & "', '"
                Select Case i
                    Case 25
                        strInsert = strInsert & "1" & "', '"
                        strInsert = strInsert & "12" & "', '"
                        strInsert = strInsert & txtTV1.Text & "', '"
                    Case 26
                        strInsert = strInsert & "13" & "', '"
                        strInsert = strInsert & "24" & "', '"
                        strInsert = strInsert & txtTV2.Text & "', '"
                    Case 27
                        strInsert = strInsert & "25" & "', '"
                        strInsert = strInsert & "36" & "', '"
                        strInsert = strInsert & txtTV3.Text & "', '"
                    Case 28
                        strInsert = strInsert & "37" & "', '"
                        strInsert = strInsert & "48" & "', '"
                        strInsert = strInsert & txtTV4.Text & "', '"
                    Case 29
                        strInsert = strInsert & "49" & "', '"
                        strInsert = strInsert & "60" & "', '"
                        strInsert = strInsert & txtTV5.Text & "', '"
                End Select
                strInsert = strInsert & txtRD1.Text & "', '"
                strInsert = strInsert & txtRD2.Text & "', '"
                strInsert = strInsert & txtRD3.Text & "', '"
                strInsert = strInsert & txtDG1.Text & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "')"
            ElseIf i > 29 And i <= 34 Then
                strInsert = strInsert & " VALUES ('" & txtPeriodo.Text & "', '" & "TVAFSINIVA" & "', '"
                Select Case i
                    Case 30
                        strInsert = strInsert & "1" & "', '"
                        strInsert = strInsert & "12" & "', '"
                        strInsert = strInsert & txtTV1.Text & "', '"
                    Case 31
                        strInsert = strInsert & "13" & "', '"
                        strInsert = strInsert & "24" & "', '"
                        strInsert = strInsert & txtTV2.Text & "', '"
                    Case 32
                        strInsert = strInsert & "25" & "', '"
                        strInsert = strInsert & "36" & "', '"
                        strInsert = strInsert & txtTV3.Text & "', '"
                    Case 33
                        strInsert = strInsert & "37" & "', '"
                        strInsert = strInsert & "48" & "', '"
                        strInsert = strInsert & txtTV4.Text & "', '"
                    Case 34
                        strInsert = strInsert & "49" & "', '"
                        strInsert = strInsert & "60" & "', '"
                        strInsert = strInsert & txtTV5.Text & "', '"
                End Select
                strInsert = strInsert & txtRD1.Text & "', '"
                strInsert = strInsert & txtRD2.Text & "', '"
                strInsert = strInsert & txtRD3.Text & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "')"
            ElseIf i > 34 And i <= 38 Then
                strInsert = strInsert & " VALUES ('" & txtPeriodo.Text & "', '" & "TVAP" & "', '"
                Select Case i
                    Case 35
                        strInsert = strInsert & "24" & "', '"
                        strInsert = strInsert & "35" & "', '"
                        strInsert = strInsert & txtPTF1.Text & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & txtVR1.Text & "', '"
                        strInsert = strInsert & txtVR1RD1.Text & "', '"
                        strInsert = strInsert & txtVR2RD1.Text & "', '"
                        strInsert = strInsert & txtVR3RD1.Text & "')"
                    Case 36
                        strInsert = strInsert & "36" & "', '"
                        strInsert = strInsert & "47" & "', '"
                        strInsert = strInsert & txtPTF2.Text & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & txtVR2.Text & "', '"
                        strInsert = strInsert & txtVR1RD2.Text & "', '"
                        strInsert = strInsert & txtVR2RD2.Text & "', '"
                        strInsert = strInsert & txtVR3RD2.Text & "')"
                    Case 37
                        strInsert = strInsert & "48" & "', '"
                        strInsert = strInsert & "59" & "', '"
                        strInsert = strInsert & txtPTF3.Text & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & txtVR3.Text & "', '"
                        strInsert = strInsert & txtVR1RD3.Text & "', '"
                        strInsert = strInsert & txtVR2RD3.Text & "', '"
                        strInsert = strInsert & txtVR3RD3.Text & "')"
                    Case 38
                        strInsert = strInsert & "60" & "', '"
                        strInsert = strInsert & "60" & "', '"
                        strInsert = strInsert & txtPTF4.Text & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & "0" & "', '"
                        strInsert = strInsert & txtVR4.Text & "', '"
                        strInsert = strInsert & txtVR1RD4.Text & "', '"
                        strInsert = strInsert & txtVR2RD4.Text & "', '"
                        strInsert = strInsert & txtVR3RD4.Text & "')"
                End Select
            ElseIf i > 38 And i <= 43 Then
                strInsert = strInsert & " VALUES ('" & txtPeriodo.Text & "', '" & "TVCR" & "', '"
                Select Case i
                    Case 39
                        strInsert = strInsert & "1" & "', '"
                        strInsert = strInsert & "12" & "', '"
                        strInsert = strInsert & txtTV1.Text & "', '"
                    Case 40
                        strInsert = strInsert & "13" & "', '"
                        strInsert = strInsert & "24" & "', '"
                        strInsert = strInsert & txtTV2.Text & "', '"
                    Case 41
                        strInsert = strInsert & "25" & "', '"
                        strInsert = strInsert & "36" & "', '"
                        strInsert = strInsert & txtTV3.Text & "', '"
                    Case 42
                        strInsert = strInsert & "37" & "', '"
                        strInsert = strInsert & "48" & "', '"
                        strInsert = strInsert & txtTV4.Text & "', '"
                    Case 43
                        strInsert = strInsert & "49" & "', '"
                        strInsert = strInsert & "60" & "', '"
                        strInsert = strInsert & txtTV5.Text & "', '"
                End Select
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & txtDG2.Text & "', '"
                strInsert = strInsert & txtDG3.Text & "', '"
                strInsert = strInsert & txtDG4.Text & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "')"
            ElseIf i > 43 And i <= 48 Then
                strInsert = strInsert & " VALUES ('" & txtPeriodo.Text & "', '" & "TVCS" & "', '"
                Select Case i
                    Case 44
                        strInsert = strInsert & "1" & "', '"
                        strInsert = strInsert & "12" & "', '"
                        strInsert = strInsert & txtTV1.Text & "', '"
                    Case 45
                        strInsert = strInsert & "13" & "', '"
                        strInsert = strInsert & "24" & "', '"
                        strInsert = strInsert & txtTV2.Text & "', '"
                    Case 46
                        strInsert = strInsert & "25" & "', '"
                        strInsert = strInsert & "36" & "', '"
                        strInsert = strInsert & txtTV3.Text & "', '"
                    Case 47
                        strInsert = strInsert & "37" & "', '"
                        strInsert = strInsert & "48" & "', '"
                        strInsert = strInsert & txtTV4.Text & "', '"
                    Case 48
                        strInsert = strInsert & "49" & "', '"
                        strInsert = strInsert & "60" & "', '"
                        strInsert = strInsert & txtTV5.Text & "', '"
                End Select
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "', '"
                strInsert = strInsert & "0" & "')"
            End If

            cm2 = New SqlCommand(strInsert, cnAgil)
            cm2.ExecuteNonQuery()
        Next
        cnAgil.Close()
        MsgBox("Datos Actualizados Correctamente", MsgBoxStyle.Information)

    End Sub

    Private Sub btnProceso_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProceso.Click
        MsgBox("Revisa bien los Datos antes de Oprimir el boton que Salva los Datos", MsgBoxStyle.Information)
        btnSave.Enabled = True
    End Sub

End Class