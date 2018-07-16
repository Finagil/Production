Public Class frmImprRelDocOrig
    Private Sub CRED_RelDocumentosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CRED_RelDocumentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CreditoDS)

    End Sub

    Private Sub frmImprRelDocOrig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CreditoDS.CRED_RelDocumentos' Puede moverla o quitarla según sea necesario.
        Me.CRED_RelDocumentosTableAdapter.Obt_Por_User_FillBy(Me.CreditoDS.CRED_RelDocumentos, UsuarioGlobal)

    End Sub

    Private Sub txtFiltroReimpresion_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroReimpresion.TextChanged
        If txtFiltroReimpresion.Text.Length > 0 Then
            CREDRelDocumentosBindingSource.Filter = "cliente like '%" & txtFiltroReimpresion.Text & "%' AND user_id='" & UsuarioGlobal & "'"
        Else
            CREDRelDocumentosBindingSource.Filter = ""
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim ultimoID As String = Me.CRED_RelDocumentosTableAdapter.UltimoID.ToString
        Me.CRED_RelDocumentosTableAdapter.Obt_Doc_FillBy(Me.CreditoDS.CRED_RelDocumentos, cmbFolios.Text)
        Dim rpt As New rptDoctosRelacionados
        rpt.SetDataSource(CreditoDS)
        frmRepRelDocOrig.crv_doc.ReportSource = rpt
        frmRepRelDocOrig.Show()
        Me.CRED_RelDocumentosTableAdapter.Obt_Por_User_FillBy(Me.CreditoDS.CRED_RelDocumentos, UsuarioGlobal)
        txtFiltroReimpresion.Text = ""
        cmbFolios.Text = ""
    End Sub
End Class