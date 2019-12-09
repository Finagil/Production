Imports System.Data.SqlClient
Public Class Frm_Resguardo
    Public cAnexo As String = ""
    Private Sub Frm_resguardo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rsi As New RadioButton()
        Dim rno As New RadioButton()
        Dim rna As New RadioButton()
        Dim txtobs As New TextBox()
        Me.Vw_AnexosTableAdapter.SelectAnexo(Me.Bitacora_anexosDS.Vw_Anexos, cAnexo)
        cbanexos.SelectedValue = cAnexo
        If Not cbanexos.SelectedValue Is Nothing Then
            Me.ClientesTableAdapter.ObtenerCliente(Me.Bitacora_anexosDS.Clientes, cbanexos.SelectedValue)
            Me.Vw_AnexosTableAdapter.SelectAnexo(Me.Bitacora_anexosDS.Vw_Anexos, cbanexos.SelectedValue)
            Me.RESGUARDO_ANEXOTableAdapter.Fill(Me.Dt_resguardos.Resguardo_Anexo, cbanexos.SelectedValue)
            If Me.Dt_resguardos.Resguardo_Anexo.Count > 0 Then
                For i As Integer = 1 To 28
                    rsi = CType(Me.Controls.Find("RS_" & i, True)(0), RadioButton)
                    rno = CType(Me.Controls.Find("RN_" & i, True)(0), RadioButton)
                    rna = CType(Me.Controls.Find("RNA_" & i, True)(0), RadioButton)
                    txtobs = CType(Me.Controls.Find("TXT_" & i, True)(0), TextBox)

                    txtobs.Text = Me.ANEXO_RESGUARDO_DOCTableAdapter.OBSDOC(cbanexos.SelectedValue, i)
                    rsi.Checked = Me.ANEXO_RESGUARDO_DOCTableAdapter.Obtener_SI(cbanexos.SelectedValue, i)
                    rno.Checked = Me.ANEXO_RESGUARDO_DOCTableAdapter.Obtener_NO(cbanexos.SelectedValue, i)
                    rna.Checked = Me.ANEXO_RESGUARDO_DOCTableAdapter.Obtener_NA(cbanexos.SelectedValue, i)
                Next
            End If
        End If
    End Sub

    Private Sub BT_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_GUARDAR.Click
        'MsgBox(cbanexos.SelectedValue)
        Dim entrega As String = ""
        Dim recibe As String = ""
        Dim rsi As New RadioButton()
        Dim rno As New RadioButton()
        Dim rna As New RadioButton()
        Dim txtobs As New TextBox()

        If txt_existe.Text.Length = 0 Then
            'guardar primera vez
            If Not cAnexo Is Nothing Then
                Me.RESGUARDO_ANEXOTableAdapter.InsertQueryAnexo_resguardo(cAnexo, date_mc.Text, date_gv.Text, rd_contrato.Checked, rd_reestructura.Checked, rd_equipo.Checked, entrega, recibe)
            End If
        Else
            'editar
            Me.RESGUARDO_ANEXOTableAdapter.UpdateQuerydocumentos(date_mc.Text, date_gv.Text, rd_contrato.Checked, rd_reestructura.Checked, rd_equipo.Checked, entrega, recibe, cAnexo)

        End If
        'POR CADA DOCUMENTO GUARDA VALORES SELECCIONADOS POR ANEXO
        For i As Integer = 1 To 28
            rsi = CType(Me.Controls.Find("RS_" & i, True)(0), RadioButton)
            rno = CType(Me.Controls.Find("RN_" & i, True)(0), RadioButton)
            rna = CType(Me.Controls.Find("RNA_" & i, True)(0), RadioButton)
            txtobs = CType(Me.Controls.Find("TXT_" & i, True)(0), TextBox)
            If txt_existe.Text.Length = 0 Then
                'guardar primera vez
                If Not cAnexo Is Nothing Then
                    Me.ANEXO_RESGUARDO_DOCTableAdapter.InsertQuery(i, cAnexo, rsi.Checked, rno.Checked, rna.Checked, txtobs.Text)
                End If
            Else
                'editar
                Me.ANEXO_RESGUARDO_DOCTableAdapter.UpdateQueryPOR_DOCUMENTO(rsi.Checked, rno.Checked, rna.Checked, txtobs.Text, cAnexo, i)
            End If
        Next



    End Sub
    Private Sub BT_IMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_IMPRIMIR.Click
        If cAnexo.Length > 0 Then
            Dim f As New FrmRPT_MC
            f.RPTTit = "Resguardo"
            f.anexo_id = cbanexos.SelectedValue
            f.Show()
            Me.RESGUARDO_ANEXOTableAdapter.DocumentoImpreso(cAnexo, cAnexo)
        End If
    End Sub

End Class