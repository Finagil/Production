Public Class FrmAutoroizaAV_CRED
    Private Sub FrmAutoroizaAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AviosCRETableAdapter.Fill(Me.CreditoDS.AviosCRE)
        If Me.CreditoDS.AviosCRE.Rows.Count > 0 Then
            LlenaDatos()
        Else
            Me.CreditoDS.AviosDet.Clear()
            Me.CreditoDS1.AviosDet.Clear()
            BtnLiberar.Enabled = False
            BtnMail.Enabled = False
        End If
    End Sub

    Private Sub AviosCREBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles AviosCREBindingSource.CurrentChanged
        If Me.AviosCREBindingSource.Count > 0 Then
            LlenaDatos()
        End If
    End Sub

    Private Sub LlenaDatos()
        Cursor.Current = Cursors.WaitCursor
        Dim ta As New CreditoDSTableAdapters.AviosCRETableAdapter
        Dim ta1 As New MesaControlDSTableAdapters.AviosDetTableAdapter
        Me.AviosDetTableAdapter.Fill(Me.CreditoDS.AviosDet, Me.AviosCREBindingSource.Current("Anexo"), Me.AviosCREBindingSource.Current("Ciclo"))
        Me.AviosDetTableAdapter.FillByProc(Me.CreditoDS1.AviosDet, Me.AviosCREBindingSource.Current("Anexo"), Me.AviosCREBindingSource.Current("Ciclo"))
        TxtSaldoAv.Text = Val(ta.SaldoVencAV(Me.AviosCREBindingSource.Current("Cliente"), Date.Now.ToString("yyyyMMdd"))).ToString("n2")
        TxtSaldoTRA.Text = Val(ta.SaldoVencTRA(Me.AviosCREBindingSource.Current("Cliente"), Date.Now.ToString("yyyyMMdd"))).ToString("n2")
        TxttotMinis.Text = Val(ta1.TotalMinistrado(Me.AviosCREBindingSource.Current("Anexo"), Me.AviosCREBindingSource.Current("Ciclo"))).ToString("n2")
        If Me.CreditoDS.AviosDet.Rows.Count <= 0 Then
            BtnLiberar.Enabled = False
            BtnMail.Enabled = False
        Else
            BtnLiberar.Enabled = True
            BtnMail.Enabled = True
        End If


        ta.Dispose()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        Dim Nuevo As Boolean = False
        For Each i As DataGridViewRow In GridDet.Rows
            If i.Cells("CreditoAut").Value = True Then
                Me.AviosDetTableAdapter.UpdateMinistracion(i.Cells("CreditoAut").Value, "#" & UsuarioGlobal, "MesaControlX", TxtObs.Text, i.Cells("AnexoDataGrid").Value, i.Cells("CicloDataGrid").Value, i.Cells("MinistracionDataGrid").Value, i.Cells("AnexoDataGrid").Value, i.Cells("CicloDataGrid").Value, i.Cells("MinistracionDataGrid").Value)
                Nuevo = True
            End If
        Next
        If Nuevo = True Then
            FrmAutoroizaAV_Load(Nothing, Nothing)
            MessageBox.Show("Movimientos liberados.", "Liberación Avío", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No existen Movimientos para guardar.", "Liberación Avío", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnMail_Click(sender As Object, e As EventArgs) Handles BtnMail.Click
        GeneraCorreo(False)
    End Sub

    Sub GeneraCorreo(Libera As Boolean)
        Dim Asunto As String = ""
        Dim para As String = AviosCREBindingSource.Current("Nombre_Sucursal")
        'para = "ecacerest@finagil.com.mx"
        Asunto = "Comentario CREDITO contrato Avío/Anticipo/pagare: " & AviosCREBindingSource.Current("AnexoCon")

        Dim Mensaje As String = ""

        Mensaje += "Cliente: " & AviosCREBindingSource.Current("Descr") & "<br>"
        Mensaje += "Contrato: " & AviosCREBindingSource.Current("AnexoCon") & "<br>"
        Mensaje += "Ciclo: " & AviosCREBindingSource.Current("CicloPagare") & "<br>"
        Mensaje += "Ministración: " & AviosDetBindingSource.Current("Ministracion") & "<br>"
        Mensaje += "Concepto: " & AviosDetBindingSource.Current("Concepto") & "<br>"
        Mensaje += "Tipo Credito: " & AviosCREBindingSource.Current("TipoCredito") & "<br>"

        Mensaje += "Observaciones: " & TxtObs.Text & "<br>"

        Me.AviosDetTableAdapter.UpdateNotas(TxtObs.Text, AviosDetBindingSource.Current("Anexo"),
                                           AviosDetBindingSource.Current("Ciclo"),
                                           AviosDetBindingSource.Current("Ministracion"))

        MandaCorreoUser(UsuarioGlobalCorreo, "DESARROLLO", Asunto, Mensaje)
        If AviosCREBindingSource.Current("Tipar") = "C" Then
            MandaCorreoPROMO(AviosCREBindingSource.Current("Anexo"), Asunto, Mensaje, True, False, True)
        Else
            MandaCorreoFase(UsuarioGlobalCorreo, para.Trim, Asunto, Mensaje)
            MessageBox.Show("Correo Enviado a " & para, "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        MandaCorreoFase(UsuarioGlobalCorreo, "CREDITO_AV", Asunto, Mensaje)

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
            Me.AviosDetTableAdapter.Fill(Me.CreditoDS.AviosDet, Me.AviosCREBindingSource.Current("Anexo"), Me.AviosCREBindingSource.Current("Ciclo"))
            SumaTotal()
        End If
    End Sub

    Private Sub SumaTotal()
        Dim Total As Decimal = 0
        For x As Integer = 0 To GridDet.Rows.Count - 1
            If GridDet.Item("CreditoAut", x).Value = True Then
                Total += GridDet.Item("ImporteDataGridViewTextBoxColumn", x).Value
            End If
        Next
        TxtTotPen.Text = Total.ToString("n2")
    End Sub

    Private Sub GridDet_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridDet.CellContentClick
        If e.ColumnIndex = Me.GridDet.Columns.Item("CreditoAut").Index Then
            Dim Total As Decimal = 0
            Dim chkCell As DataGridViewCheckBoxCell = Me.GridDet.Rows(e.RowIndex).Cells("CreditoAut")
            chkCell.Value = Not chkCell.Value
            For x As Integer = 0 To GridDet.Rows.Count - 1
                If GridDet.Item("CreditoAut", x).Value = True Then
                    Total += GridDet.Item("ImporteDataGridViewTextBoxColumn", x).Value
                End If
            Next
            TxtTotPen.Text = Total.ToString("n2")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmAutoroizaAV_Load(Nothing, Nothing)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BttnDG.Click
        Dim Nuevo As Boolean = False
        For Each i As DataGridViewRow In GridDet.Rows
            If i.Cells("CreditoAut").Value = True Then
                Me.AviosDetTableAdapter.UpdateMinistracion(False, "DGX", "", TxtObs.Text, i.Cells("AnexoDataGrid").Value & " (" & UsuarioGlobal & ")", i.Cells("CicloDataGrid").Value, i.Cells("MinistracionDataGrid").Value, i.Cells("AnexoDataGrid").Value, i.Cells("CicloDataGrid").Value, i.Cells("MinistracionDataGrid").Value)
                Nuevo = True
            End If
        Next
        If Nuevo = True Then
            FrmAutoroizaAV_Load(Nothing, Nothing)
            MessageBox.Show("Movimientos enviados a Direccion General.", "Dirección Genreral", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No existen Movimientos para enviar.", "Dirección Genreral", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class