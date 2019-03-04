Public Class frmAjusteSuperficie
    Dim cAnexo As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        cAnexo = txtAnexo.Text.Substring(0, 5) + txtAnexo.Text.Substring(6, 4)
        Me.VW_AjustesTableAdapter.Fill(Me.AviosDSX.VW_Ajustes, cAnexo)
        If Me.AviosDSX.VW_Ajustes.Rows.Count <= 0 Then
            MessageBox.Show("No existe el contrato", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Me.VWAjustesBindingSource.Current("tipar") <> "H" Then
                MessageBox.Show("El contrato es un avio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.AviosDSX.VW_Ajustes.Clear()
            ElseIf Me.VWAjustesBindingSource.Current("flcan") <> "A" Then
                MessageBox.Show("El contrato no esta Activo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.AviosDSX.VW_Ajustes.Clear()
            Else
                GroupAjustes.Enabled = 1
            End If
        End If
    End Sub

    Private Sub frmAjusteSuperficie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtusuario.Text = UsuarioGlobal
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TxtSuperficie.LostFocus
        If IsNumeric(TxtSuperficie.Text) Then
            TxtnewLine.Text = CDec(Me.VWAjustesBindingSource.Current("Cuota") * CDec(TxtSuperficie.Text)).ToString("n2")
        Else
            TxtnewLine.Text = ""
        End If
    End Sub

    Private Sub BtnAjustar_Click(sender As Object, e As EventArgs) Handles BtnAjustar.Click
        Dim Ministrado As Decimal = Me.VW_AjustesTableAdapter.Ministrado(Me.VWAjustesBindingSource.Current("Anexo"), Me.VWAjustesBindingSource.Current("Ciclo"))
        If Not IsNumeric(TxtSuperficie.Text) Then
            MessageBox.Show("Superficie Invalida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtSuperficie.Text = ""
            TxtSuperficie.Focus()
        Else
            TxtnewLine.Text = CDec(Me.VWAjustesBindingSource.Current("Cuota") * CDec(TxtSuperficie.Text)).ToString("n2")
            Dim ta As New AviosDSXTableAdapters.AVI_AjustesHectareasTableAdapter
            If MessageBox.Show("¿Esta seguro de Ajustar la superficie?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ta.Insert(Me.VWAjustesBindingSource.Current("Anexo"),
                       Me.VWAjustesBindingSource.Current("Ciclo"),
                       Txtusuario.Text, Me.VWAjustesBindingSource.Current("HectareasActual"),
                       TxtSuperficie.Text, Me.VWAjustesBindingSource.Current("Cuota"), Date.Now)
                ta.UpdateAvio(TxtnewLine.Text, TxtSuperficie.Text, Me.VWAjustesBindingSource.Current("Anexo"), Me.VWAjustesBindingSource.Current("Ciclo"))
                MessageBox.Show("Contrato Ajustado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                GeneraCorreo()
                Me.Close()
            End If
        End If
    End Sub

    Sub GeneraCorreo()
        Dim Asunto As String = ""
        Dim para As String = UsuarioGlobalCorreo

        Asunto = "Ajuste de Superficie Contrato: " & Me.VWAjustesBindingSource.Current("AnexoCon")
        Dim Mensaje As String = ""
        Mensaje += "Cliente: " & Me.VWAjustesBindingSource.Current("Descr") & "<br>"
        Mensaje += "Contrato: " & Me.VWAjustesBindingSource.Current("AnexoCon") & "<br>"
        Mensaje += "Ciclo: " & Me.VWAjustesBindingSource.Current("CicloPagare") & "<br>"
        Mensaje += "Superficie Anterior: " & CDec(Me.VWAjustesBindingSource.Current("HectareasActual")).ToString("n2") & "<br>"
        Mensaje += "Superficie Ajustada: " & CDec(TxtSuperficie.Text).ToString("n2") & "<br>"
        Mensaje += "Linea Anterior: " & CDec(Me.VWAjustesBindingSource.Current("LineaActual")).ToString("n2") & "<br>"
        Mensaje += "Linea Ajustada: " & TxtnewLine.Text & "<br>"
        Mensaje += "Fecha Ajuste: " & Date.Now.ToShortDateString & "<br>"


        MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", Asunto, Mensaje)
        'MandaCorreoUser(UsuarioGlobalCorreo, UsuarioGlobalCorreo, Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "MESA_CONTROL", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "CREDITO_AV", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "JUR_" & VWAjustesBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "JEFE_" & VWAjustesBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, VWAjustesBindingSource.Current("Nombre_Sucursal"), Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "SEGUROS", Asunto, Mensaje)
        MandaCorreoFase(UsuarioGlobalCorreo, "FIRA", Asunto, Mensaje)
    End Sub
End Class