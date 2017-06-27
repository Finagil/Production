Public Class FrmSubePagosAV
    Dim Pag As New Pago
    Dim ta1 As New TesoreriaDSTableAdapters.PagosAvioTableAdapter
    Dim ta As New TesoreriaDSTableAdapters.mFINAGILTableAdapter
    Structure Pago
        Public Refe As String
        Public Cliente As String
        Public Importe As Decimal
        Public Fecha As Date
    End Structure
    Private Sub FrmSubePagosAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bloquea(False)
    End Sub

    Private Sub BtnFile_Click(sender As Object, e As EventArgs) Handles BtnFile.Click
        Dim Errror As String = ""
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Archivo Export|*.exp|Archivo de texto|*.txt"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim t As New TesoreriaDS.mFINAGILDataTable
            Dim r As TesoreriaDS.mFINAGILRow

            Dim t1 As New TesoreriaDS.PagosAvioDataTable
            Dim t2 As New TesoreriaDS.PagosAvioDataTable
            Dim Linea As String = ""
            Dim Filtro As String = ""
            Try


                Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
                While Not sr.EndOfStream
                    Linea = sr.ReadLine
                    Pag.Fecha = CDate(Linea.Substring(40, 20))
                    Pag.Importe = Val(Linea.Substring(75, 16))
                    Pag.Cliente = Linea.Substring(91, 30)
                    Pag.Refe = Linea.Substring(121, 4)
                    Filtro = "0" & Pag.Refe & "%"

                    ta.Fill(t, Pag.Importe, Filtro)
                    If t.Rows.Count <= 0 Then
                        Errror += "Anexo no encontrado " & Pag.Refe & " Importe: " & Pag.Importe.ToString("n2") & vbCrLf
                    Else
                        r = t.Rows(0)
                        ta1.Fill(t1, Pag.Refe, Pag.Importe, Pag.Fecha.AddMinutes(-5), Pag.Fecha.AddMinutes(5))
                        If t1.Rows.Count > 0 Then
                            Errror += "Anexo procesado para estado de cuenta: " & Pag.Refe & " Importe: " & Pag.Importe.ToString("n2") & vbCrLf
                        Else
                            ta1.Insert(Pag.Refe, Pag.Fecha, Pag.Cliente, True, Pag.Importe, r.Anexo, r.Ciclo, r.Ministracion, False)
                        End If
                    End If
                End While
                sr.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Errores de carga", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Pag.Fecha = Nothing
            End Try
            Me.VW_PAgosAvioTableAdapter.Fill(Me.TesoreriaDS.VW_PAgosAvio, Pag.Fecha.AddMinutes(-5), Pag.Fecha.AddMinutes(5))
            TextBox1.Text = Val(Me.VW_PAgosAvioTableAdapter.Total(Pag.Fecha.AddMinutes(-5), Pag.Fecha.AddMinutes(5))).ToString("n2")
            If Errror.Length > 0 Then
                MessageBox.Show(Errror, "Errores de carga", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If Me.TesoreriaDS.VW_PAgosAvio.Rows.Count > 0 Then
                Bloquea(True)
            End If
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.TesoreriaDS.VW_PAgosAvio.Clear()
        Bloquea(False)
        Pag.Fecha = Nothing
    End Sub

    Private Sub Bloquea(B As Boolean)
        BtnFile.Enabled = Not B
        BtnCancel.Enabled = B
        BtnUp.Enabled = B
    End Sub

    Private Sub BtnUp_Click(sender As Object, e As EventArgs) Handles BtnUp.Click
        Dim cont As Integer = 0
        For Each r As TesoreriaDS.VW_PAgosAvioRow In Me.TesoreriaDS.VW_PAgosAvio.Rows
            If r.Confirmado = True And r.Aplicado = False Then
                cont += 1
                ta.ActualizaFechas(r.FechaPago.ToString("yyyyMMdd"), r.FechaPago.ToString("yyyyMMdd"), r.AnexoSin, r.CicloSin, r.Ministracion)
                ta1.Aplicado(True, r.id_pago, r.id_pago)
            End If
            If r.Confirmado = False Then
                ta1.Confirmado(False, r.id_pago)
            End If
        Next
        MessageBox.Show("Se Confirmaron " & cont & " pagos a contratos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.VW_PAgosAvioTableAdapter.Fill(Me.TesoreriaDS.VW_PAgosAvio, Pag.Fecha.AddMinutes(-5), Pag.Fecha.AddMinutes(5))
        TextBox1.Text = Val(Me.VW_PAgosAvioTableAdapter.Total(Pag.Fecha.AddMinutes(-5), Pag.Fecha.AddMinutes(5))).ToString("n2")
        Bloquea(False)
    End Sub
End Class