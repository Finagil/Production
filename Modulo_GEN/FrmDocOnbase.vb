Imports System.IO
Public Class FrmDocOnbase
    Public Cadena1 As String = ""
    Public Cadena2 As String = ""
    Public Cadena3 As String = ""
    Public Titulo As String
    Dim Impresion As Boolean

    Private Sub FrmDocOnbase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Mid(Cadena1, 1, 1) = "0" Then Cadena1 = Mid(Cadena1, 2, 9)
        If Mid(Cadena1, 1, 1) = "0" Then Cadena1 = Mid(Cadena1, 2, 9)
        If Mid(Cadena1, 1, 1) = "0" Then Cadena1 = Mid(Cadena1, 2, 9)
        If Cadena1 = "" And Cadena3 = "" And Cadena3 = "" Then
            LbBusqueda.Visible = True
            TxtBusqueda.Visible = True
        ElseIf Cadena3.Trim = "" Then
            Me.OnBaseTableAdapter.FillByCAD2(GeneralDS.OnBase, Cadena1, Cadena2)
        Else
            Me.OnBaseTableAdapter.FillByCAD4(GeneralDS.OnBase, Cadena1, Cadena2, Cadena3)
        End If

        Me.Text = Titulo
        If UCase(UsuarioGlobal) = "DESARROLLO" Then
            BtnvALIDA.Visible = True
        End If
        If Cadena1 = "Credito%" Or UsuarioGlobal.ToLower = "mtorres" Or UsuarioGlobal.ToLower = "asangar" Then
            Impresion = True
        Else
            Impresion = False
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub LstImagenes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstImagenes.SelectedIndexChanged
        If LstImagenes.SelectedIndex >= 0 Then
            Dim ta As New GeneralDSTableAdapters.OnBaseDETTableAdapter
            Dim tt As New GeneralDS.OnBaseDETDataTable
            ta.FillCAD(tt, LstImagenes.SelectedValue)
            Dim Ruta(tt.Rows.Count - 1) As String
            Dim x As Integer = 0
            For Each r As GeneralDS.OnBaseDETRow In tt.Rows
                Ruta(x) = "\\server-nas\OnBase" & r.filepath
                x += 1
            Next
            If File.Exists(Ruta(0)) And InStr(UCase(Ruta(0)), ".PDF") <= 0 Then
                Dim f As New FrmImagen
                f.Titulo = LstImagenes.Text
                f.Ruta = Ruta
                f.Impresion = Impresion
                If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                End If
                f.Dispose()
            ElseIf File.Exists(Ruta(0)) And InStr(UCase(Ruta(0)), ".PDF") > 0 Then
                Dim Proc As New System.Diagnostics.Process
                Proc.StartInfo.FileName = Ruta(0)
                Proc.Start()
            Else
                MessageBox.Show("El archivo no existe.", "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub BtnvALIDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnvALIDA.Click
        Me.Cursor.Current = Cursors.WaitCursor
        Dim f As New StreamWriter("c:\Files\Onbase.txt", False)
        Dim ta As New GeneralDSTableAdapters.Vw_AnexosTableAdapter
        Dim t As New GeneralDS.Vw_AnexosDataTable
        Dim R As GeneralDS.Vw_AnexosRow
        Dim Rr As GeneralDS.OnBaseRow
        Dim X As New GeneralDS.OnBaseDataTable

        '+++++++++++TODOS
        If MessageBox.Show("¿Desea Generar todo el hisotrial?", "OnBase", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ta.Fill(t)
            For Each R In t.Rows
                Cadena1 = "% " + CDbl(Mid(R.Anexo, 2, 9)).ToString + " %"
                Cadena2 = "%" + Mid(R.Descr, 1, 10) + "%"
                Me.OnBaseTableAdapter.FillByCAD3(X, Cadena1, Cadena2)
                For Each Rr In X.Rows
                    f.WriteLine(Cadena1 & vbTab & Cadena2 & vbTab & R.Descr.Trim & vbTab & Rr.titulo)
                Next
            Next
            f.Close()
        End If
        '+++++++++++ACTIVOS
        If MessageBox.Show("¿Desea Generar contratos Activos?", "OnBase", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            f = New StreamWriter("c:\Files\OnbaseActivos.txt", False)
            ta.FillByActivos(t)
            For Each R In t.Rows
                Cadena1 = "% " + CDbl(Mid(R.Anexo, 2, 9)).ToString + " %"
                Cadena2 = "%" + Mid(R.Descr, 1, 10) + "%"
                Me.OnBaseTableAdapter.FillByCAD3(X, Cadena1, Cadena2)
                For Each Rr In X.Rows
                    f.WriteLine(Cadena1 & vbTab & Cadena2 & vbTab & R.Descr.Trim & vbTab & Rr.titulo)
                Next
            Next
            f.Close()
        End If
        '+++++++++++TERMINADOS CON SALDO
        If MessageBox.Show("¿Desea Generar contratos Terminados con Saldo?", "OnBase", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            f = New StreamWriter("c:\Files\OnbaseTerminadosConSaldo.txt", False)
            ta.FillByTerminadoConSaldo(t)
            For Each R In t.Rows
                Cadena1 = "% " + CDbl(Mid(R.Anexo, 2, 9)).ToString + " %"
                Cadena2 = "%" + Mid(R.Descr, 1, 10) + "%"
                Me.OnBaseTableAdapter.FillByCAD3(X, Cadena1, Cadena2)
                For Each Rr In X.Rows
                    f.WriteLine(Cadena1 & vbTab & Cadena2 & vbTab & R.Descr.Trim & vbTab & Rr.titulo)
                Next
            Next
            f.Close()
        End If

        Me.Cursor.Current = Cursors.Default
        MessageBox.Show("Terminado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TxtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text.Length > 4 Then
            Cadena1 = TxtBusqueda.Text
            Me.OnBaseTableAdapter.FillByCAD2(GeneralDS.OnBase, "%" & Cadena1 & "%", "%" & Cadena1 & "%")
        Else
            GeneralDS.OnBase.Clear()
        End If
    End Sub
End Class