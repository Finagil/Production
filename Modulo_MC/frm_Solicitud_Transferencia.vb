
Public Class frm_Solicitud_Transferencia

    Inherits System.Windows.Forms.Form


    'Controls
    Dim X As Integer
    Dim Y As Integer
    Dim i As Integer
    Dim index As Integer
    Dim suma As Double
    Dim suma2 As Double
    Dim MyNewObject As Control
    Dim MyNewEtiqueta As Control
    Dim MyTipo_txt As System.Type
    Dim MyTipo_label As System.Type
    Dim fechacreacion As String
    Public fecha As Date
    Public Shared id_anexo As String
    Public Shared id_Ciclo As String
    Public Shared fechapago As String
    Public Shared TipoRecurso As String
    Public Shared fecha_p As Date
    Public Shared recursos_fira As Double
    Public Shared IMPORTE_T As Double
    Public Anexo As String
    Public Shared Ciclo As String


    Private Sub txtcliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcliente.TextChanged
        If txtcliente.Text.Length > 4 Then
            txt_anexo.Text = ""
            Me.ClientesTableAdapter.selectclientes(Me.Bitacora_anexosDS.Clientes, txtcliente.Text)
            If Not cbclientes.SelectedValue Is Nothing Then
                Me.Vw_AnexosTableAdapter.FillByAnexo(Me.Bitacora_anexosDS.Vw_Anexos, Anexo, Ciclo)
            End If
        End If
    End Sub

    Private Sub txt_anexo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_anexo.TextChanged

        If txt_anexo.Text.Length > 2 Then
            txtcliente.Text = ""
            Me.Vw_AnexosTableAdapter.SelectAnexo(Me.Bitacora_anexosDS.Vw_Anexos, txt_anexo.Text)
            If Not cbanexos.SelectedValue Is Nothing Then
                Me.ClientesTableAdapter.ObtenerCliente(Me.Bitacora_anexosDS.Clientes, cbanexos.SelectedValue)
            End If
        End If
    End Sub

    Private Sub cbclientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbclientes.SelectedIndexChanged
        If cbclientes.SelectedValue > 0 And txt_anexo.Text.Length = 0 Then
            Me.Vw_AnexosTableAdapter.Anexoporcliente(Me.Bitacora_anexosDS.Vw_Anexos, cbclientes.SelectedValue)
        End If
    End Sub

    Private Sub cbanexos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbanexos.SelectedIndexChanged
        If cbanexos.SelectedValue > 0 And txtcliente.Text.Length = 0 Then
            Me.ClientesTableAdapter.ObtenerCliente(Me.Bitacora_anexosDS.Clientes, cbanexos.SelectedValue)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      

    End Sub
    Private Function del()
        'POR CADA CONTROL AGREGADO A LA LISTA OCULTA SE ELIMINAN, CUANDO SE CAMBIA EL NUMERO ANEXO
        For Each item As String In ListBox1.Items
            Dim Eliminar As Control
            For Each Eliminar In Me.GroupBox1.Controls
                If Eliminar.Name = item Then
                    Me.GroupBox1.Controls.Remove(Eliminar)
                End If
            Next
        Next
        ListBox1.Items.Clear()

    End Function

    Private Function Add(ByVal nombre As String, ByVal valor As Double, ByVal Y As Integer)
        'Creo una nueva instancia del control
        MyNewObject = New TextBox
        MyNewEtiqueta = New Label
        'Levanto el tipo del nuevo objeto
        MyTipo_txt = MyNewObject.GetType
        MyTipo_label = MyNewEtiqueta.GetType
        'Con el nombre del tipo y el contador le doy un nombre
        MyNewObject.Name = Convert.ToString(nombre)
        MyNewEtiqueta.Name = "Label"
        ListBox1.Items.Add(MyNewObject.Name)
        ListBox1.Items.Add(MyNewEtiqueta.Name)
        MyNewObject.Enabled = False
        MyNewObject.Text = valor.ToString("C")
        MyNewEtiqueta.Text = nombre
        'Ubico el nuevo control segun indicado
        MyNewEtiqueta.Location = New System.Drawing.Point(155, Y)
        MyNewObject.Location = New System.Drawing.Point(265, Y)
        MyNewObject.Width = 100
        MyNewEtiqueta.Width = 100
        Me.GroupBox1.Controls.Add(MyNewEtiqueta)
        Me.GroupBox1.Controls.Add(MyNewObject)
    End Function

    Private Sub TXT_CUENTA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CUENTA.TextChanged

        '  ID_SOLICITUD_T = Me.MC_SOLICITUD_TRANSFERENCIATableAdapter.ScalarQueryID_SOLICITUD(TXT_CUENTA.Text, dt_solicitud.Text)
        Y = 40
        suma = 0
        suma2 = 0
        del() 'ELIMINAR CONTROLES 

        ' If ID_SOLICITUD_T = 0 Then
        'CREAR CONTROLES DE ACUERDO A INFORMACION CAPTURADA EN LA BASE
        fecha = dt_solicitud.Text
        fechacreacion = fecha.ToString("yyyyMMdd")
        'For Each row As DataRow In Vw_mfinagilTableAdapter.GetDataByFecha(TXT_CUENTA.Text, fechacreacion)
        For Each row As MesaControlDS.vw_mfinagilRow In Vw_mfinagilTableAdapter.GetDataByFecha(TXT_CUENTA.Text, Ciclo)
            Dim doc As String
            doc = row("Documento")
            If row.MesaControlAut = True Then
                If doc.ToUpper = "EFECTIVO" Then
                    suma2 = suma2 + row("Importe")
                Else
                    Add(doc.ToUpper, row("Importe"), Y)
                    suma = suma + row("Importe")
                    Y += 22
                End If
            End If
        Next

        If suma2 > 0 Then
            Add("SOLICITUD", suma2, Y)
            Y += 22
        End If
        Add("RECURSOS FIRA", suma + suma2, Y)


      
      
    End Sub

    Private Sub dt_solicitud_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dt_solicitud.TextChanged
        Y = 40
        suma = 0
        suma2 = 0
        del() 'ELIMINAR CONTROLES 

        ' If ID_SOLICITUD_T = 0 Then
        'CREAR CONTROLES DE ACUERDO A INFORMACION CAPTURADA EN LA BASE

        fecha = dt_solicitud.Text
        fechacreacion = fecha.ToString("yyyyMMdd")
        fechapago = fechacreacion
        'For Each row As DataRow In Vw_mfinagilTableAdapter.GetDataByfecha(TXT_CUENTA.Text, fechacreacion)
        For Each r As MesaControlDS.vw_mfinagilRow In Vw_mfinagilTableAdapter.GetDataByFecha(TXT_CUENTA.Text, Ciclo)
            Dim doc As String
            doc = r("Documento")
            If r.MesaControlAut = True Then

                If doc.ToUpper = "EFECTIVO" Then
                    suma2 = suma2 + r("Importe")
                Else
                    Add(doc.ToUpper, r("Importe"), Y)
                    suma = suma + r("Importe")
                    Y += 22
                End If
            End If
        Next
        If suma2 > 0 Then
            Add("SOLICITUD", suma2, Y)
            Y += 22
        End If
        Add("RECURSOS FIRA", suma + suma2, Y)


    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        id_anexo = TXT_CUENTA.Text
        IMPORTE_T = suma2
        recursos_fira = suma + suma2
        fecha_p = dt_solicitud.Text
        TipoRecurso = txt_tipo.Text.ToUpper
        frm_rpt_solicitud_transferencia.Show()

    End Sub

    Private Sub frm_Solicitud_Transferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_solicitud.Value = fecha
        fechapago = fecha.ToString("yyyyMMdd")
        txt_anexo.Text = Anexo

    End Sub
End Class
