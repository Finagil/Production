Public Class FrmAutoroizaAV
    Private Sub FrmAutoroizaAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AviosMCTableAdapter.Fill(Me.MesaControlDS.AviosMC)
        If Me.MesaControlDS.AviosMC.Rows.Count > 0 Then
            LlenaDatos()
        Else
            Me.MesaControlDS.AviosDet.Clear()
            Me.MesaControlDS1.AviosDet.Clear()
            BtnLiberar.Enabled = False
            BtnMail.Enabled = False
            BtnSolTransf.Enabled = False
        End If
    End Sub

    Private Sub AviosMCBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles AviosMCBindingSource.CurrentChanged
        If Me.AviosMCBindingSource.Count > 0 Then
            LlenaDatos()
        End If
    End Sub

    Private Sub LlenaDatos()
        Cursor.Current = Cursors.WaitCursor
        Dim ta As New MesaControlDSTableAdapters.AviosMCTableAdapter
        Dim ta1 As New MesaControlDSTableAdapters.AviosDetTableAdapter
        Me.AviosDetTableAdapter.Fill(Me.MesaControlDS.AviosDet, Me.AviosMCBindingSource.Current("Anexo"), Me.AviosMCBindingSource.Current("Ciclo"))
        Me.AviosDetTableAdapter.FillByProc(Me.MesaControlDS1.AviosDet, Me.AviosMCBindingSource.Current("Anexo"), Me.AviosMCBindingSource.Current("Ciclo"))
        TxtSaldoAv.Text = Val(ta.SaldoVencAV(Me.AviosMCBindingSource.Current("Cliente"), Date.Now.ToString("yyyyMMdd"))).ToString("n2")
        TxtSaldoTRA.Text = Val(ta.SaldoVencTRA(Me.AviosMCBindingSource.Current("Cliente"), Date.Now.ToString("yyyyMMdd"))).ToString("n2")
        '        TxtTotPen.Text = Val(ta1.TotalMinistrado(Me.AviosMCBindingSource.Current("Anexo"), Me.AviosMCBindingSource.Current("Ciclo"))).ToString("n2")
        TxttotMinis.Text = Val(ta1.TotalMinistrado(Me.AviosMCBindingSource.Current("Anexo"), Me.AviosMCBindingSource.Current("Ciclo"))).ToString("n2")
        If Me.MesaControlDS.AviosDet.Rows.Count <= 0 Then
            BtnLiberar.Enabled = False
            BtnMail.Enabled = False
            BtnSolTransf.Enabled = False
        Else
            BtnLiberar.Enabled = True
            BtnMail.Enabled = True
            BtnSolTransf.Enabled = True
        End If


        ta.Dispose()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        Dim Nuevo As Boolean = False
        Button1_Click(Nothing, Nothing)
        For Each i As DataGridViewRow In GridDet.Rows
            If i.Cells("MesaControlAutDataGridViewCheckBoxColumn").Value = True Then
                Dim Aut As String = Me.MesaControlDS.AviosDet.Rows(i.Index).Item("Autoriza").ToString
                Dim Sucur As String = AviosMCBindingSource.Current("Nombre_Sucursal")
                Dim TiparX As String = AviosMCBindingSource.Current("TipoCredito")

                If Aut.Length <= 0 Then
                    If Sucur.Trim = "IRAPUATO" Then
                        Me.MesaControlDS.AviosDet.Rows(i.Index).Item("Autoriza") = "FiraZ"
                    Else
                        If TiparX = "ANTICIPO AVIO" Then
                        Else
                            Me.MesaControlDS.AviosDet.Rows(i.Index).Item("Autoriza") = "Fira"
                        End If
                        Me.MesaControlDS.AviosDet.Rows(i.Index).Item("AutorizaAut") = True
                        Me.MesaControlDS.AviosDet.Rows(i.Index).Item("Tesoreria") = "TesoreriaX"
                    End If

                Else
                    If TiparX = "ANTICIPO AVIO" Then
                    Else
                        Me.MesaControlDS.AviosDet.Rows(i.Index).Item("Autoriza") = "Fira"
                    End If

                    Me.MesaControlDS.AviosDet.Rows(i.Index).Item("AutorizaAut") = True
                    Me.MesaControlDS.AviosDet.Rows(i.Index).Item("Tesoreria") = "TesoreriaX"
                End If
                Me.MesaControlDS.AviosDet.Rows(i.Index).Item("mesacontrol") = UsuarioGlobal
                Nuevo = True
            End If
        Next
        If Nuevo = True Then
            Me.MesaControlDS.AviosDet.GetChanges()
            Me.AviosDetTableAdapter.Update(Me.MesaControlDS.AviosDet)
            FrmAutoroizaAV_Load(Nothing, Nothing)
            MessageBox.Show("Movimientos liberados.", "Liberación Avío", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No existen Movimientos para guardar.", "Liberación Avío", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSolTransf.Click
        If Me.MesaControlDS.AviosDet.Rows.Count > 0 Then
            Me.MesaControlDS.AviosDet.GetChanges()
            Me.AviosDetTableAdapter.Update(Me.MesaControlDS.AviosDet)

            Cursor.Current = Cursors.WaitCursor
            Dim f As New frm_Solicitud_Transferencia
            f.Anexo = AviosDetBindingSource.Current("Anexo")
            f.Ciclo = AviosDetBindingSource.Current("Ciclo")
            f.fecha = CTOD(AviosDetBindingSource.Current("FechaAlta"))
            f.WindowState = FormWindowState.Minimized
            f.Show()
            f.Button1_Click(Nothing, Nothing)
            f.Close()
            f.Dispose()
            Cursor.Current = Cursors.Default
        Else
            MessageBox.Show("No existen movimientos.", "Solicitud de Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub BtnMail_Click(sender As Object, e As EventArgs) Handles BtnMail.Click
        GeneraCorreo(False)
    End Sub

    Sub GeneraCorreo(Libera As Boolean)
        Dim Asunto As String = ""
        Dim para As String = AviosMCBindingSource.Current("Nombre_Sucursal")
        'para = "ecacerest@finagil.com.mx"
        Asunto = "Comentario MC contrato Avío/Anticipo/pagare: " & AviosMCBindingSource.Current("AnexoCon")

        Dim Mensaje As String = ""

        Mensaje += "Cliente: " & AviosMCBindingSource.Current("cliente") & "<br>"
        Mensaje += "Contrato: " & AviosMCBindingSource.Current("AnexoCon") & "<br>"
        Mensaje += "Ciclo: " & AviosMCBindingSource.Current("CicloPagare") & "<br>"
        Mensaje += "Ministración: " & AviosDetBindingSource.Current("Ministracion") & "<br>"
        Mensaje += "Concepto: " & AviosDetBindingSource.Current("Concepto") & "<br>"
        Mensaje += "Tipo Credito: " & AviosMCBindingSource.Current("TipoCredito") & "<br>"

        Mensaje += "Observaciones: " & TxtObs.Text & "<br>"

        Me.AviosDetTableAdapter.UpdateNota(TxtObs.Text, AviosDetBindingSource.Current("Anexo"),
                                           AviosDetBindingSource.Current("Ciclo"),
                                           AviosDetBindingSource.Current("Ministracion"),
                                           AviosDetBindingSource.Current("Anexo"),
                                           AviosDetBindingSource.Current("Ciclo"),
                                           AviosDetBindingSource.Current("Ministracion"))

        MandaCorreoUser(UsuarioGlobalCorreo, "DESARROLLO", Asunto, Mensaje)
        If AviosMCBindingSource.Current("Tipar") = "C" Then
            MandaCorreoPROMO(AviosMCBindingSource.Current("Anexo"), Asunto, Mensaje, True, False, True)
        Else
            MandaCorreoFase(UsuarioGlobalCorreo, para.Trim, Asunto, Mensaje)
            MessageBox.Show("Correo Enviado a " & para, "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        MandaCorreoFase(UsuarioGlobalCorreo, "MESA_CONTROL", Asunto, Mensaje)

    End Sub

    Private Sub GridDet_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GridDet.CellEndEdit
        If e.ColumnIndex = 5 Then
            Dim ta As New MesaControlDSTableAdapters.mFINAGILTableAdapter
            Dim ta1 As New MesaControlDSTableAdapters.AviosDetTableAdapter
            ta.ActualizaImporte(AviosDetBindingSource.Current("Importe"),
                                AviosDetBindingSource.Current("Anexo"),
                                AviosDetBindingSource.Current("ciclo"),
                                AviosDetBindingSource.Current("Ministracion"),
                                AviosDetBindingSource.Current("Anexo"),
                                AviosDetBindingSource.Current("ciclo"),
                                AviosDetBindingSource.Current("Ministracion"))
            Me.AviosDetTableAdapter.Fill(Me.MesaControlDS.AviosDet, Me.AviosMCBindingSource.Current("Anexo"), Me.AviosMCBindingSource.Current("Ciclo"))
            SumaTotal()
        End If
    End Sub

    Private Sub SumaTotal()
        Dim Total As Decimal = 0
        For x As Integer = 0 To GridDet.Rows.Count - 1
            If GridDet.Item("MesaControlAutDataGridViewCheckBoxColumn", x).Value = True Then
                Total += GridDet.Item("ImporteDataGridViewTextBoxColumn", x).Value
            End If
        Next
        TxtTotPen.Text = Total.ToString("n2")
    End Sub

    Private Sub GridDet_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridDet.CellContentClick
        If e.ColumnIndex = Me.GridDet.Columns.Item("MesaControlAutDataGridViewCheckBoxColumn").Index Then
            Dim Total As Decimal = 0
            Dim chkCell As DataGridViewCheckBoxCell = Me.GridDet.Rows(e.RowIndex).Cells("MesaControlAutDataGridViewCheckBoxColumn")
            chkCell.Value = Not chkCell.Value
            For x As Integer = 0 To GridDet.Rows.Count - 1
                If GridDet.Item("MesaControlAutDataGridViewCheckBoxColumn", x).Value = True Then
                    Total += GridDet.Item("ImporteDataGridViewTextBoxColumn", x).Value
                End If
            Next
            TxtTotPen.Text = Total.ToString("n2")
        End If


    End Sub
End Class