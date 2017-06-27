Public Class FrmGruposRiesgoAsigComunX

    Private Sub FrmGruposRiesgoAsig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RiesgoComunTableAdapter.Fill(Me.GeneralDS.RiesgoComun)
        Call Cargar()
    End Sub

    Private Sub Txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            ClientesSinGrupoComunBindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
        Else
            ClientesSinGrupoComunBindingSource.Filter = ""
        End If
    End Sub

    Private Sub TxtFiltro2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFiltro2.TextChanged
        If TxtFiltro2.Text.Length > 0 Then
            ClientesConGrupoComunBindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
        Else
            ClientesConGrupoComunBindingSource.Filter = ""
        End If
    End Sub

    Private Sub ListaSin_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSin.DoubleClick
        If ListaSin.SelectedIndex >= 0 Then
            Me.ClientesSinGrupoComunTableAdapter.UpdateGrupo(CmbGrupo.SelectedValue, ListaSin.SelectedValue)
            Me.GeneralDS.ClientesConGrupoComun.AddClientesConGrupoComunRow(ListaSin.SelectedValue, ListaSin.Text, CmbGrupo.SelectedValue)
            ClientesSinGrupoComunBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub ListaCon_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCon.DoubleClick
        If ListaCon.SelectedIndex >= 0 Then
            'If UsuarioGlobal <> "asirvent" Then
            'MessageBox.Show("No tienes permiso para Quitar a un cliente de un grupo")
            'Exit Sub
            'End If
            Me.ClientesSinGrupoComunTableAdapter.UpdateGrupo(0, ListaCon.SelectedValue)
            Me.GeneralDS.ClientesSinGrupo.AddClientesSinGrupoRow(ListaCon.SelectedValue, ListaCon.Text, 0)
            ClientesConGrupoComunBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub CmbGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbGrupo.SelectedIndexChanged
        cargar()
    End Sub
    Sub Cargar()
        Me.ClientesSinGrupoComunTableAdapter.Fill(Me.GeneralDS.ClientesSinGrupoComun)
        Me.ClientesConGrupoComunTableAdapter.Fill(Me.GeneralDS.ClientesConGrupoComun, CmbGrupo.SelectedValue)
    End Sub


    
End Class