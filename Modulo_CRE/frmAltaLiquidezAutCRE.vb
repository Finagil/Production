Imports System.IO
Public Class frmAltaLiquidezAutCRE
    Private Sub frmAltaLiquidezAutCRE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesLiqTableAdapter.Fill(Me.CreditoDS.ClientesLiq)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.EndEdit()
        Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ_Autorizacion)
    End Sub

    Private Sub Saldo_insolutoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Saldo_insolutoTextBox.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TasaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TasaTextBox.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("¿Etas seguro de aprobar la solicitud de " & ComboBox2.Text & "?", "Aprobar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim NotaDG As String
            If ClientesLiqBindingSource.Current("MontoFinanciado") > CDec(TaQUERY.ConfigDATO("LIQ_MONTO_CRE")) Then ' PASA A DIRECCION gENERAL
                NotaDG = InputBox("Favor de agregar comentario para Dirección General", "Comentario DG", "Comentario")
                ClientesLiqTableAdapter.UpdateEstatus("gbello", UsuarioGlobal, NotaDG, ClientesLiqBindingSource.Current("ID_SOLICITUD"))
                GeneraCorreoDG(True)
                MessageBox.Show("Se paso a Dirección General", "Dirección General", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmAltaLiquidezAutCRE_Load(Nothing, Nothing)
            Else ' CREDITO LO PASA
                NotaDG = InputBox("Favor de agregar comentario para Sub Dirección de Crédito", "Comentario CREDITO", "Comentario")
                ClientesLiqTableAdapter.UpdateEstatus("vgomez", UsuarioGlobal, NotaDG, ClientesLiqBindingSource.Current("ID_SOLICITUD"))
                GeneraCorreoDG(False)
                MessageBox.Show("Se paso a la Sub Dirección de Crédito", "Sub Dirección de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmAltaLiquidezAutCRE_Load(Nothing, Nothing)
            End If
        End If
    End Sub
    Private Sub ClientesLiqBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ClientesLiqBindingSource.CurrentChanged
        If Not IsNothing(ClientesLiqBindingSource.Current) Then
            Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Fill(Me.PromocionDS.PROM_SolicitudesLIQ_Autorizacion, ClientesLiqBindingSource.Current("id_solicitud"))
            If PROM_SolicitudesLIQ_AutorizacionBindingSource.Count = 0 Then
                Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.AddNew()
                Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.Current("id_solicitud") = ClientesLiqBindingSource.Current("id_solicitud")
                Me.Validate()
                Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.EndEdit()
                Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ_Autorizacion)
                Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.Fill(Me.PromocionDS.PROM_SolicitudesLIQ_Autorizacion, ClientesLiqBindingSource.Current("id_solicitud"))
            End If
            If TaQUERY.EsClienteFinagil(ClientesLiqBindingSource.Current("Cliente")) > 0 Then
                Cliente_finagilCheckBox.Checked = True
            Else
                Cliente_finagilCheckBox.Checked = False
            End If
            Saldo_insolutoTextBox.Text = CDec(TaQUERY.SaldoInsolutoTRA(ClientesLiqBindingSource.Current("Cliente"))).ToString("n2")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("¿Etas seguro de rechazar la solicitud de " & ComboBox2.Text & "?", "Rechazar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim NotaDG As String = InputBox("Favor de agregar cometario para Dirección Gneral", "Comentario DG", "Comentario")
            ClientesLiqTableAdapter.UpdateEstatus("RECHAZADO", UsuarioGlobal, "", ClientesLiqBindingSource.Current("ID_SOLICITUD"))
            GeneraCorreoREC()
            frmAltaLiquidezAutCRE_Load(Nothing, Nothing)
        End If
    End Sub

    Sub GeneraCorreoREC()
        Dim Asunto As String = ""
        'para = "ecacerest@finagil.com.mx"
        Asunto = "Solicitud de Liquidez Inmediata Rechazada: " & ComboBox2.Text
        Dim Mensaje As String = ""

        Mensaje += "Cliente: " & ComboBox2.Text & "<br>"
        Mensaje += "Monto Financiado: " & CDec(ClientesLiqBindingSource.Current("MontoFinanciado")).ToString("n2") & "<br>"

        MandaCorreo(UsuarioGlobalCorreo, "ecacerest@finagil.com.mx", Asunto, Mensaje)
        MandaCorreo(UsuarioGlobalCorreo, UsuarioGlobalCorreo, Asunto, Mensaje)
        MandaCorreoUser(UsuarioGlobalCorreo, TaQUERY.SacaCorreoPromo(ClientesLiqBindingSource.Current("Cliente")), Asunto, Mensaje)
    End Sub

    Sub GeneraCorreoDG(DG As Boolean)
        Dim Asunto As String = ""
        Dim Antiguedad As Integer = DateDiff(DateInterval.Year, Date.Now, ClientesLiqBindingSource.Current("FechaIngreso"))
        'para = "ecacerest@finagil.com.mx"
        Asunto = "Solicitud de Liquidez Inmediata para Autorización: " & ComboBox2.Text
        Dim Mensaje As String = ""
        Mensaje += "Cliente: " & ComboBox2.Text & "<br>"
        Mensaje += "Monto Financiado: " & CDec(ClientesLiqBindingSource.Current("MontoFinanciado")).ToString("n2") & "<br>"
        GeneraDocAutorizacion(ClientesLiqBindingSource.Current("ID_SOLICITUD"), Math.Abs(Antiguedad).ToString)
        If DG Then
            Mensaje += "<A HREF='http://finagil.com.mx/WEBtasas/232db951-DGLQ.aspx?User=gbello&ID=0'>Liga para Autorización.</A>"
            MandaCorreoFase(UsuarioGlobalCorreo, "DG", Asunto, Mensaje)
        Else
            Mensaje += "<A HREF='http://finagil.com.mx/WEBtasas/232db951-DGLQ.aspx?User=vgomez&ID=0'>Liga para Autorización.</A>"
            MandaCorreoFase(UsuarioGlobalCorreo, "CREDITO", Asunto, Mensaje)
        End If
        MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", Asunto, Mensaje)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim NotaDG As String = InputBox("Favor de agregar comentario para Dirección General", "Comentario DG", "Comentario")
        ClientesLiqTableAdapter.UpdateEstatus("gbello", UsuarioGlobal, NotaDG.Substring(1, 200), ClientesLiqBindingSource.Current("ID_SOLICITUD"))
        GeneraCorreoDG(True)
        MessageBox.Show("Se paso a Dirección General", "Dirección General", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frmAltaLiquidezAutCRE_Load(Nothing, Nothing)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f As New FrmAltaLiquidezFinan
        f.Consulta = True
        f.ID_sol = ClientesLiqBindingSource.Current("ID_SOLICITUD")
        f.GeneroCli = ClientesLiqBindingSource.Current("Genero")
        If f.ShowDialog Then
        End If

    End Sub

    Function GeneraDocAutorizacion(ID_Sol2 As Integer, Antiguedad As String) As String
        Cursor.Current = Cursors.WaitCursor
        Dim Archivo As String = My.Settings.RutaTMP & "Autoriza" & ID_Sol2 & ".Pdf"
        Dim Archivo2 As String = "Autoriza" & ID_Sol2 & ".Pdf"
        Dim reporte As New rptAltaLiquidezAutorizacion
        Dim ta As New PromocionDSTableAdapters.AutorizacionRPTTableAdapter
        ta.Fill(Me.PromocionDS.AutorizacionRPT, ID_Sol2)

        reporte.SetDataSource(Me.PromocionDS)
        reporte.SetParameterValue("var_antiguedad", Antiguedad & " años")
        reporte.SetParameterValue("Autorizo", "-----------")
        reporte.SetParameterValue("AreaAutorizo", "-----------")
        reporte.SetParameterValue("Firma", "")
        reporte.SetParameterValue("Analista", UsuarioGlobalNombre)
        reporte.SetParameterValue("FirmaAnalista", "")
        reporte.SetParameterValue("FirmaPromo", "")
        Try
            File.Delete(Archivo)
            reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Archivo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Cursor.Current = Cursors.Default
        Return Archivo2
    End Function

End Class