Public Class FrmCancelaMov
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ta As New GeneralDSTableAdapters.AviosXTableAdapter
        ta.CancelaPagoAvio(TxtAnexo.Text, TxtFecha.Text, Txtnum.Text, TxtFact.Text)
        MessageBox.Show("Movimiento Realizado", "Avio", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TaQUERY.CambioFechaAplicacion(TxtAnexo1.Text, TxtFecORG.Text, TxtFecNEW.Text, Txtnum1.Text)
        MessageBox.Show("Movimiento Realizado", "Historia", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TaQUERY.CancelaPago(TxtAnexo3.Text, Txtfecha3.Text, TxtNumFact3.Text, TxtFactura3.Text)
        MessageBox.Show("Movimiento Realizado", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub FrmCancelaMov_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Cad As String
        TxtMoraDiaFest.Text = CANCELA_MORA_DIA_FEST(0) & ";" & CANCELA_MORA_DIA_FEST(1) & ";" & CANCELA_MORA_DIA_FEST(2)
        Cad = "Parametro1: Fecha en que se aplica el pago (yyyymmdd)" & vbCrLf
        Cad += "Parametro2: Domiciliado (V=Solo Domiciliado, F=Solo referenciado, VF= todos)" & vbCrLf
        Cad += "Parametro3: Dias de mora, los dia de mora que se van a condonar"

        ToolTip1.SetToolTip(Button6, Cad)
        ToolTip1.SetToolTip(TxtMoraDiaFest, Cad)
        TxtMesCalif.Text = TaQUERY.SacaMesCalifFira
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            CANCELA_MORA_DIA_FEST = TxtMoraDiaFest.Text.Split(";")
            If CANCELA_MORA_DIA_FEST.Length <> 3 Then
                MessageBox.Show("Error en numero de parametros", "Error Cancela Moratorios dìa Festivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                TaQUERY.UpdateMoraDiaFest(TxtMoraDiaFest.Text.ToUpper)
                CANCELA_MORA_DIA_FEST = TxtMoraDiaFest.Text.ToUpper.Split(";")
                MessageBox.Show("Cambio de Fecha Realizado", "Cancela Moratorios dia Festivo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim Fecha As Date = CTOD(TxtMesCalif.Text)
            Dim Fecha1 As Date = Fecha.AddMonths(-1)
            Dim Fecha2 As Date = Fecha1.AddMonths(-1)
            Dim f As String = Fecha.ToString("MMM").Substring(0, 3).ToUpper & " " & Fecha.Year
            Dim f1 As String = Fecha1.ToString("MMM").Substring(0, 3).ToUpper & " " & Fecha1.Year
            Dim f2 As String = Fecha2.ToString("MMM").Substring(0, 3).ToUpper & " " & Fecha2.Year

            TaQUERY.UpdateMesCalifFira(TxtMesCalif.Text, f, f1, f2)
            MessageBox.Show("Cambio de Fecha Realizado", "Mes Calificación Fira", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim ta As New GeneralDSTableAdapters.ClientesGENTableAdapter
        Try
            ta.CambiaRFC(txtRFCnvo.Text, TxtNumCli1.Text)
            MessageBox.Show("Cambio de RFC hecho.", "RFC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim ta As New GeneralDSTableAdapters.ClientesGENTableAdapter
        Try
            ta.CambiaNombre(TxtNom.Text, TxtNumCli2.Text)
            MessageBox.Show("Cambio de Nombre hecho.", "Nombre Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ta As New GeneralDSTableAdapters.QueryVariosTableAdapter
        Try
            ta.CancelaCFDI(TextSerie.Text, TxtFacturaCFDI.Text)
            MessageBox.Show("CFDI cancelado.", "Cancela CFDI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextAnexoRDDG.TextChanged
        If TextAnexoRDDG.Text.Length = 9 Then
            TextRD.Text = TaQUERY.SacaRD(TextAnexoRDDG.Text)
            TextDG.Text = TaQUERY.SacaDG(TextAnexoRDDG.Text)
            TextIVARD.Text = TaQUERY.SacaIvaRD(TextAnexoRDDG.Text)
            TextIVADG.Text = TaQUERY.SacaIvaDG(TextAnexoRDDG.Text)
        Else
            TextRD.Clear()
            TextDG.Clear()
            TextIVARD.Clear()
            TextIVADG.Clear()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            TaQUERY.CambiaRD(TextRD.Text, TextIVARD.Text, TextAnexoRDDG.Text)
            MessageBox.Show("Renta en deposito Cambiada", "Cambio RD", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            TaQUERY.CambiaDG(TextDG.Text, TextIVADG.Text, TextAnexoRDDG.Text)
            MessageBox.Show("Depósito en garantía Cambiada", "Cambio DG", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Dim ta As New PromocionDSTableAdapters.PROM_SolicitudesLIQTableAdapter
            Dim talinea As New CreditoDSTableAdapters.CRED_LineasCreditoTableAdapter
            ta.RegresaSolLiq(TextsolLiq.Text)
            talinea.DeleteLineaLQ(TextsolLiq.Text)
            MessageBox.Show("Solicitud Regresada", "LIQ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Dim ta As New GeneralDSTableAdapters.AviosXTableAdapter
            If ta.NoMovimientosEdoCta(TxtAnexoDel.Text, TxtCicloDel.Text) <= 0 Then
                ta.BorraAnexoAV(TxtAnexoDel.Text, TxtCicloDel.Text)
                MessageBox.Show("Anexo Borrado", "Avio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("este contrato ya tiene movimientos en el estado de cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class