Imports System.IO
Public Class FrmWatch
    Private Sub FrmWatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BC_WatchTableAdapter.Fill(Me.CreditoDS.BC_Watch)
        Me.ContClie1TableAdapter.Fill(Me.ProductionDataSet.ContClie1)
        Try
        Catch ex As Exception
            MessageBox.Show(ex.Source & " " & ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            ContClie1BindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
        Else
            ContClie1BindingSource.Filter = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
        If CmbClie.SelectedIndex >= 0 Then
            Try
                Me.BC_WatchTableAdapter.InsertRFC(Me.ContClie1BindingSource.Current("RFC"))
                Me.BC_WatchTableAdapter.Fill(Me.CreditoDS.BC_Watch)
                BITACORA.Insert(UsuarioGlobal, "BC_Watch", Date.Now, "ReporteWatch", System.Environment.MachineName, "ADD Cliente a Watch")
            Catch ex As Exception
                MessageBox.Show(ex.Source & " " & ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ButtonDEL_Click(sender As Object, e As EventArgs) Handles ButtonDEL.Click
        If ListClie.SelectedIndex >= 0 Then
            If MessageBox.Show("¿Esta seguro de eliminar al cliente " & Me.BCWatchBindingSource.Current("Cliente") & "?", "Watch Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.BC_WatchTableAdapter.DeleteID(BCWatchBindingSource.Current("id_watch"))
                Me.BC_WatchTableAdapter.Fill(Me.CreditoDS.BC_Watch)
                BITACORA.Insert(UsuarioGlobal, "BC_Watch", Date.Now, "ReporteWatch", System.Environment.MachineName, "DELETE Cliente a Watch")
            End If
        End If
    End Sub

    Private Sub ButtonSEND_Click(sender As Object, e As EventArgs) Handles ButtonSEND.Click
        Try
            Dim Nombre As String = "Watch_" & Date.Now.ToString("yyyyMMddmmss") & ".txt"
            '''CREA ARCHIVO begin
            Dim ta As New CreditoDSTableAdapters.Vw_Buro_WatchTableAdapter
            ta.Fill(Me.CreditoDS.Vw_Buro_Watch)
            Dim Attach As New StreamWriter(My.Settings.RutaTMP & Nombre, False)
            For Each r As CreditoDS.Vw_Buro_WatchRow In Me.CreditoDS.Vw_Buro_Watch.Rows
                If r.TipoPersona = "M" Then
                    Attach.WriteLine(r(0) & "|" & Trim(r(1)) & "|" & Trim(r(2)) & "|" & Trim(r(3)) & "|" & Trim(r(7)) & "|" & Trim(r(8)) & "|" & Trim(r(9)) & "|" & Trim(r(10)) & "|" & Trim(r(11)) & "|" & Trim(r(12)) & "|" & Trim(r(13)) & "|" & Trim(r(14)))
                Else
                    Attach.WriteLine(r(0) & "|" & Trim(r(1)) & "|" & Trim(r(2)) & "|" & Trim(r(3)) & "|" & Trim(r(4)) & "|" & Trim(r(5)) & "|" & Trim(r(6)) & "|" & Trim(r(7)) & "|" & Trim(r(8)) & "|" & Trim(r(9)) & "|" & Trim(r(10)) & "|" & Trim(r(11)) & "|" & Trim(r(12)) & "|" & Trim(r(13)) & "|" & Trim(r(14)))
                End If
            Next
            Attach.Close()
            '''CREA ARCHIVO end
            MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS_BURO", "Lista Watch", "Favor de actualizar lista Watch", Nombre)
            MandaCorreo(UsuarioGlobalCorreo, UsuarioGlobalCorreo, "Lista Watch", "Favor de actualizar lista Watch", Nombre)
            MessageBox.Show("Solicitud Enviada a SISTEMAS_BURO", "Mensaje Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Source & " " & ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class