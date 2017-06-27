Public Class FrmDatosLegales
    Public Cliente As String
    Public Nombre As String


    Private Sub FrmDatosLegales_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        DatosLegalesTableAdapter.FillByRepre(PromocionDS2.DatosLegales, Cliente)
        DatosLegalesTableAdapter.Fill(PromocionDS1.DatosLegales, Cliente, CmbReprese.SelectedValue)
        If PromocionDS1.DatosLegales.Rows.Count <= 0 Then
            DatosLegalesTableAdapter.InsertCliente(Cliente)
            DatosLegalesTableAdapter.FillByRepre(PromocionDS2.DatosLegales, Cliente)
            DatosLegalesTableAdapter.Fill(PromocionDS1.DatosLegales, Cliente, CmbReprese.SelectedValue)
            BtnAdd.Visible = False
            BtnDelete.Visible = False
        Else
            BtnAdd.Visible = True
            BtnDelete.Visible = True
        End If
        Label1.Text = "Cliente: " & Cliente
        Label2.Text = "Nombre: " & Nombre
        Try
            LLenaTexto()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BttSafe_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BttSafe.Click
        Dim Indice As Integer = CmbReprese.SelectedIndex
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is TextBox Then
                If ctl.Text = "" And ctl.Name <> "TextBox11" And ctl.Name <> "TextBox10" Then
                    MessageBox.Show("error de datos.", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ctl.Focus()
                    Exit Sub
                End If
            End If
        Next ctl

        If Not IsDate(TxtFechaEscri.Text) Then
            MessageBox.Show("Fecha no valida.", "Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtFechaEscri.Focus()
            Exit Sub
        End If
        If Not IsDate(TxtFechaFol.Text) Then
            MessageBox.Show("Fecha no valida.", "Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtFechaFol.Focus()
            Exit Sub
        End If
        DatosLegalesTableAdapter.UpdateLegales(TxtEscritura.Text, TxtFechaEscri.Text, TxtFE.Text, TxtNoNotario.Text, TxtNotarioDE.Text, TxtRegPublic.Text, TxtFolioMerc.Text, TxtFechaFol.Text, TxtRepre.Text, TxtAtte.Text, Cliente, CmbReprese.SelectedValue)
        DatosLegalesTableAdapter.FillByRepre(PromocionDS2.DatosLegales, Cliente)
        DatosLegalesTableAdapter.FillByRepre(PromocionDS2.DatosLegales, Cliente)
        CmbReprese.SelectedIndex = Indice
        DatosLegalesTableAdapter.Fill(PromocionDS1.DatosLegales, Cliente, CmbReprese.SelectedValue)
        BtnAdd.Visible = True
        BtnDelete.Visible = True
        LLenaTexto()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim Indice As Integer = CmbReprese.Items.Count
        DatosLegalesTableAdapter.InsertCliente(Cliente)
        DatosLegalesTableAdapter.FillByRepre(PromocionDS2.DatosLegales, Cliente)
        DatosLegalesTableAdapter.FillByRepre(PromocionDS2.DatosLegales, Cliente)
        CmbReprese.SelectedIndex = Indice
        DatosLegalesTableAdapter.Fill(PromocionDS1.DatosLegales, Cliente, CmbReprese.SelectedValue)
        BtnAdd.Visible = False
        BtnDelete.Visible = False
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next ctl
    End Sub

    Private Sub CmbReprese_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbReprese.SelectedIndexChanged
        DatosLegalesTableAdapter.Fill(PromocionDS1.DatosLegales, Cliente, CmbReprese.SelectedValue)
        LLenaTexto()
    End Sub

    Private Sub LLenaTexto()
        Try
            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox10.Text = "a) Que es una persona moral constituida conforme a las leyes de los Estados Unidos Mexicanos, según consta en la escritura pública número " & TxtEscritura.Text & " de fecha " & CDate(TxtFechaEscri.Text).Day & " de " & MonthName(CDate(TxtFechaEscri.Text).Month) & " de " & CDate(TxtFechaEscri.Text).Year & ", otorgada ante la fe del licenciado " & TxtFE.Text & ", Notario público número " & TxtNoNotario.Text & " de " & TxtNotarioDE.Text & ", inscrita en el Registro Público del Comercio de " & TxtRegPublic.Text & " bajo el folio mercantil número " & TxtFolioMerc.Text & ", de fecha " & CDate(TxtFechaFol.Text).Day & " de " & MonthName(CDate(TxtFechaFol.Text).Month) & " de " & CDate(TxtFechaFol.Text).Year & "."
            TextBox11.Text = "f) " & TxtRepre.Text & " posee las facultades suficientes y necesarias para celebrar en su representación el presente Contrato, obligándola en los términos del mismo, lo cual se acredita con la escritura pública número , de fecha " & CDate(TxtFechaEscri.Text).Day & " de " & MonthName(CDate(TxtFechaEscri.Text).Month) & " de " & CDate(TxtFechaEscri.Text).Year & ", otorgada ante la fe del notario público número " & TxtNoNotario.Text & " de " & TxtNotarioDE.Text & ", licenciado " & TxtFE.Text & ", inscrita en el Registro Público de la Propiedad y del Comercio de " & TxtRegPublic.Text & " bajo el folio mercantil número " & TxtFolioMerc.Text & ", de fecha " & CDate(TxtFechaFol.Text).Day & " de " & MonthName(CDate(TxtFechaFol.Text).Month) & " de " & CDate(TxtFechaFol.Text).Year & ", facultades que no le han sido modificadas, revocadas ni limitadas de forma alguna."
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("Esta seguro de eliminar los datos de este representante", "Eliminar Representante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.DatosLegalesTableAdapter.DeleteRepre(CmbReprese.SelectedValue)
            DatosLegalesTableAdapter.FillByRepre(PromocionDS2.DatosLegales, Cliente)
            DatosLegalesTableAdapter.FillByRepre(PromocionDS2.DatosLegales, Cliente)
            DatosLegalesTableAdapter.Fill(PromocionDS1.DatosLegales, Cliente, CmbReprese.SelectedValue)
        End If
    End Sub
End Class