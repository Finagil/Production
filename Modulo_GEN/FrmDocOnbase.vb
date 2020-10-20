Imports System.IO
Public Class FrmDocOnbase
    Public Area As String = ""
    Public NombreCliente As String = ""
    Public AnexoOcliente As String = ""
    Public Titulo As String
    Dim Impresion As Boolean

    Private Sub FrmDocOnbase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Arreglo() As String
        If Area = "" Then
            LbBusqueda.Visible = True
            TxtBusqueda.Visible = True
        Else
            If NombreCliente <> "" Then
                Me.OnBaseTableAdapter.FillByAreaNombre(GeneralDS.OnBase, Area, NombreCliente)
            Else
                Arreglo = CadOnbase(AnexoOcliente)
                Me.OnBaseTableAdapter.FillByAreaAnexo(GeneralDS.OnBase, Area, Arreglo(0), Arreglo(1), Arreglo(2), Arreglo(3))
            End If
        End If
        Me.Text = Titulo
        If UCase(UsuarioGlobal) = "DESARROLLO" Then
            BtnvALIDA.Visible = True
        End If
        If Area.ToUpper = "CREDITO" Or TaQUERY.SacaPermisoModulo("ONBASE_IMPRE", UsuarioGlobal) > 0 Then
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
            Cursor.Current = Cursors.WaitCursor
            Dim ta As New GeneralDSTableAdapters.OnBaseDETTableAdapter
            Dim tt As New GeneralDS.OnBaseDETDataTable
            ta.Fill_itemname(tt, LstImagenes.SelectedValue)
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
                Cursor.Current = Cursors.Default
                If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                End If
                f.Dispose()

            ElseIf File.Exists(Ruta(0)) And InStr(UCase(Ruta(0)), ".PDF") > 0 Then
                Dim Proc As New System.Diagnostics.Process
                Proc.StartInfo.FileName = Ruta(0)
                Cursor.Current = Cursors.Default
                Proc.Start()
            Else
                Cursor.Current = Cursors.Default
                MessageBox.Show("El archivo no existe.", "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    'Private Sub BtnvALIDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnvALIDA.Click
    '    Me.Cursor.Current = Cursors.WaitCursor
    '    Dim f As New StreamWriter("c:\Files\Onbase.txt", False)
    '    Dim ta As New GeneralDSTableAdapters.Vw_AnexosTableAdapter
    '    Dim t As New GeneralDS.Vw_AnexosDataTable
    '    Dim R As GeneralDS.Vw_AnexosRow
    '    Dim Rr As GeneralDS.OnBaseRow
    '    Dim X As New GeneralDS.OnBaseDataTable

    '    '+++++++++++TODOS
    '    If MessageBox.Show("¿Desea Generar todo el hisotrial?", "OnBase", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '        ta.Fill(t)
    '        For Each R In t.Rows
    '            Cadena1 = "% " + CDbl(Mid(R.Anexo, 2, 9)).ToString + " %"
    '            Cadena2 = "%" + Mid(R.Descr, 1, 10) + "%"
    '            Me.OnBaseTableAdapter.FillByCAD3(X, Cadena1, Cadena2)
    '            For Each Rr In X.Rows
    '                f.WriteLine(Cadena1 & vbTab & Cadena2 & vbTab & R.Descr.Trim & vbTab & Rr.titulo)
    '            Next
    '        Next
    '        f.Close()
    '    End If
    '    '+++++++++++ACTIVOS
    '    If MessageBox.Show("¿Desea Generar contratos Activos?", "OnBase", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '        f = New StreamWriter("c:\Files\OnbaseActivos.txt", False)
    '        ta.FillByActivos(t)
    '        For Each R In t.Rows
    '            Cadena1 = "% " + CDbl(Mid(R.Anexo, 2, 9)).ToString + " %"
    '            Cadena2 = "%" + Mid(R.Descr, 1, 10) + "%"
    '            Me.OnBaseTableAdapter.FillByCAD3(X, Cadena1, Cadena2)
    '            For Each Rr In X.Rows
    '                f.WriteLine(Cadena1 & vbTab & Cadena2 & vbTab & R.Descr.Trim & vbTab & Rr.titulo)
    '            Next
    '        Next
    '        f.Close()
    '    End If
    '    '+++++++++++TERMINADOS CON SALDO
    '    If MessageBox.Show("¿Desea Generar contratos Terminados con Saldo?", "OnBase", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '        f = New StreamWriter("c:\Files\OnbaseTerminadosConSaldo.txt", False)
    '        ta.FillByTerminadoConSaldo(t)
    '        For Each R In t.Rows
    '            Cadena1 = "% " + CDbl(Mid(R.Anexo, 2, 9)).ToString + " %"
    '            Cadena2 = "%" + Mid(R.Descr, 1, 10) + "%"
    '            Me.OnBaseTableAdapter.FillByCAD3(X, Cadena1, Cadena2)
    '            For Each Rr In X.Rows
    '                f.WriteLine(Cadena1 & vbTab & Cadena2 & vbTab & R.Descr.Trim & vbTab & Rr.titulo)
    '            Next
    '        Next
    '        f.Close()
    '    End If

    '    Me.Cursor.Current = Cursors.Default
    '    MessageBox.Show("Terminado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'End Sub

    Private Sub TxtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBusqueda.TextChanged
        Dim Cadena As String
        If TxtBusqueda.Text.Length > 4 Then
            Cadena = TxtBusqueda.Text.Trim
            Me.OnBaseTableAdapter.FillCAD(GeneralDS.OnBase, "%" & Cadena & "%")
        Else
            GeneralDS.OnBase.Clear()
        End If
    End Sub
End Class