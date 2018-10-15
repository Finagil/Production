Public Class frm_resguardoAV
    Public cAnexo As String = ""
    Private Sub frm_resguardoAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MesaControlDS.Anexo_Resguardo_DocAV' Puede moverla o quitarla según sea necesario.
        ' Me.Anexo_Resguardo_DocAVTableAdapter.Fill(Me.MesaControlDS.Anexo_Resguardo_DocAV)
        'TODO: esta línea de código carga datos en la tabla 'MesaControlDS.Clientes' Puede moverla o quitarla según sea necesario.
        'Me.ClientesTableAdapter.Fill(Me.MesaControlDS.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'MesaControlDS.Vw_Anexos' Puede moverla o quitarla según sea necesario.
        'Me.Vw_AnexosTableAdapter.Fill(Me.MesaControlDS.Vw_Anexos)
        Dim rsi As New RadioButton()
        Dim rno As New RadioButton()
        Dim rna As New RadioButton()
        Dim txtobs As New TextBox()
        Me.Vw_AnexosTableAdapter.SelectAnexo(Me.MesaControlDS.Vw_Anexos, cAnexo)
        cbanexos.SelectedValue = cAnexo
        If Not cbanexos.SelectedValue Is Nothing Then
            Me.ClientesTableAdapter.ObtenerCliente(Me.MesaControlDS.Clientes, cbanexos.SelectedValue)
            Me.Vw_AnexosTableAdapter.SelectAnexo(Me.MesaControlDS.Vw_Anexos, cbanexos.SelectedValue)
            Me.Resguardo_AnexoAVTableAdapter.Fill(Me.MesaControlDS.Resguardo_AnexoAV, cbanexos.SelectedValue)
            If Me.MesaControlDS.Resguardo_AnexoAV.Count > 0 Then
                For i As Integer = 1 To 12
                    rsi = CType(Me.Controls.Find("RS_" & i, True)(0), RadioButton)
                    rno = CType(Me.Controls.Find("RN_" & i, True)(0), RadioButton)
                    rna = CType(Me.Controls.Find("RNA_" & i, True)(0), RadioButton)
                    txtobs = CType(Me.Controls.Find("TXT_" & i, True)(0), TextBox)

                    txtobs.Text = Me.Anexo_Resguardo_DocAVTableAdapter.OBSDOC(cbanexos.SelectedValue, i)
                    rsi.Checked = Me.Anexo_Resguardo_DocAVTableAdapter.Obtener_SI(cbanexos.SelectedValue, i)
                    rno.Checked = Me.Anexo_Resguardo_DocAVTableAdapter.Obtener_no(cbanexos.SelectedValue, i)
                    rna.Checked = Me.Anexo_Resguardo_DocAVTableAdapter.Obtener_NA(cbanexos.SelectedValue, i)

                Next
            End If
        End If
    End Sub

    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        'MsgBox(cbanexos.SelectedValue)
        Dim entrega As String = ""
        Dim recibe As String = ""
        Dim rsi As New RadioButton()
        Dim rno As New RadioButton()
        Dim rna As New RadioButton()
        Dim txtobs As New TextBox()

        If txt_existe1.Text.Length = 0 Then
            'guardar primera vez
            If Not cAnexo Is Nothing Then
                Me.Resguardo_AnexoAVTableAdapter.InsertQueryAnexo_resguardo(cAnexo, date_mc.Text, date_gv.Text, rd_contrato.Checked, rd_anticipo.Checked, rd_ampli.Checked, entrega, recibe)
                MessageBox.Show("Datos Guardado", "RESGUARDO AVIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            'editar
            Me.Resguardo_AnexoAVTableAdapter.UpdateQuerydocumentos(date_mc.Text, date_gv.Text, rd_contrato.Checked, rd_anticipo.Checked, rd_ampli.Checked, entrega, recibe, cAnexo)
            MessageBox.Show("Datos Modificados", "RESGUARDO AVIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        'POR CADA DOCUMENTO GUARDA VALORES SELECCIONADOS POR ANEXO
        For i As Integer = 1 To 12
            rsi = CType(Me.Controls.Find("RS_" & i, True)(0), RadioButton)
            rno = CType(Me.Controls.Find("RN_" & i, True)(0), RadioButton)
            rna = CType(Me.Controls.Find("RNA_" & i, True)(0), RadioButton)
            txtobs = CType(Me.Controls.Find("TXT_" & i, True)(0), TextBox)
            If txt_existe1.Text.Length = 0 Then
                'guardar primera vez
                If Not cAnexo Is Nothing Then
                    Me.Anexo_Resguardo_DocAVTableAdapter.InsertQuery(i, cAnexo, rsi.Checked, rno.Checked, rna.Checked, txtobs.Text)
                End If
            Else
                'editar
                Me.Anexo_Resguardo_DocAVTableAdapter.UpdateQueryPORDOCUMENTO(rsi.Checked, rno.Checked, rna.Checked, txtobs.Text, cAnexo, i)
            End If
        Next

    End Sub

    Private Sub BT_IMPRIMIR_Click(sender As Object, e As EventArgs) Handles BT_IMPRIMIR.Click
        If cAnexo.Length > 0 Then
            Dim f As New FrmRPT_MC
            f.RPTTit = "Resguardo Avío"
            f.anexo_id = cbanexos.SelectedValue
            f.ciclo = txt_ciclo.Text
            f.Show()
        End If
    End Sub
End Class