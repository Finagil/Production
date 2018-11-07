Public Class FrmAltaLiquidez

    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            ContClie1BindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
            CmbCli_SelectedIndexChanged(Nothing, Nothing)
        Else
            ContClie1BindingSource.Filter = ""
        End If
    End Sub

    Private Sub FrmAltaLiquidez_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PromocionDS.GEN_Empleadores' Puede moverla o quitarla según sea necesario.
        Me.GEN_EmpleadoresTableAdapter.Fill(Me.PromocionDS.GEN_Empleadores)
        Me.PlazasTableAdapter.Fill(Me.PromocionDS.Plazas)
        Me.PlazasTableAdapter.Fill(Me.PromocionDS1.Plazas)
        Me.LI_PeriodosTableAdapter.Fill(Me.PromocionDS.LI_Periodos)
        Me.LI_PlazosTableAdapter.Fill(Me.PromocionDS.LI_Plazos)
        Me.ContClie1TableAdapter.FillByPersonas(Me.ProductionDataSet.ContClie1)
    End Sub

    Private Sub BttNewCli_Click(sender As Object, e As EventArgs) Handles BttNewCli.Click
        Dim f As New frmAltaClie
        If f.ShowDialog = DialogResult.OK Then
            Me.ContClie1TableAdapter.FillByPersonas(Me.ProductionDataSet.ContClie1)
        End If
    End Sub

    Private Sub CmbCli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCli.SelectedIndexChanged
        If CmbCli.SelectedIndex >= 0 Then
            Me.ClientesTableAdapter.Fill(PromocionDS.Clientes, CmbCli.SelectedValue)
            Me.PROM_SolicitudesLIQTableAdapter.FillByProcesado(PromocionDS.PROM_SolicitudesLIQ, CmbCli.SelectedValue, False)
            If PromocionDS.PROM_SolicitudesLIQ.Rows.Count > 0 Then
                Botones(False)
                ProcesaRFC()
            Else
                Botones(True)
            End If
        End If
    End Sub

    Private Sub BtnNewSol_Click(sender As Object, e As EventArgs) Handles BtnNewSol.Click
        Me.PROMSolicitudesLIQBindingSource.AddNew()
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0
        ComboBox5.SelectedIndex = 0
        ComboBox6.SelectedIndex = 0
        ComboBox7.SelectedIndex = 0
        ComboBox8.SelectedIndex = 0
        Me.PROMSolicitudesLIQBindingSource.Current("fecha") = DtpFecSol.Value
        Me.PROMSolicitudesLIQBindingSource.Current("fecha") = DTPIngreso.Value
        ProcesaRFC()
        Me.PROMSolicitudesLIQBindingSource.Current("Cliente") = CmbCli.SelectedValue
        DTPIngreso.MaxDate = Date.Now.Date.AddYears(-2)
        DTPIngreso.Value = Date.Now.Date.AddYears(-2)
        Botones(False)
    End Sub

    Private Sub TxtRFC_TextChanged(sender As Object, e As EventArgs) Handles TxtRFC.TextChanged
        ProcesaRFC()
    End Sub

    Sub ProcesaRFC()
        If TxtRFC.Text.Trim.Length >= 10 Then
            Dim f As Date
            f = SacaFechaRFC(TxtRFC.Text).ToShortDateString
            Txtfecnac.Text = f.ToShortDateString
            Txtedad.Text = DateDiff(DateInterval.Year, f, Date.Now)
        Else
            Txtedad.Text = 0
            Txtfecnac.Text = "01/01/1900"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As EventArgs) Handles TextBox1.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TextBox23_KeyPress(sender As Object, e As EventArgs) Handles TextBox23.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub TextBox30_Leave(sender As Object, e As EventArgs) Handles TextBox30.Leave
        If validar_Mail(TextBox30.Text) = False Then
            MessageBox.Show("Correo Invalido", "Correo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        GuardarDatos()
    End Sub

    Function GuardarDatos() As Boolean
        Try
            PROMSolicitudesLIQBindingSource.EndEdit()
            If CheckGrales.Checked = True Then
                GuardaOtrosDAtos()
            End If
            PROM_SolicitudesLIQTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ)
            Return True
        Catch ex As Exception
            If ex.Message <> "Infracción de simultaneidad: UpdateCommand afectó a 0 de los 1 registros esperados." Then
                MessageBox.Show(ex.Message, "Error al guardar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If
        End Try
    End Function

    Sub Botones(B As Boolean)
        BtnNewSol.Enabled = B
        BtnSave.Enabled = Not B
        BtnPrint.Enabled = Not B
        BtnDatos.Enabled = Not B
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Dim taAltaLiquidez As New PromocionDSTableAdapters.VW__SolLiqTableAdapter
        taAltaLiquidez.Fill(Me.PromocionDS.VW__SolLiq, Me.PROMSolicitudesLIQBindingSource.Current("Id_Solicitud"))

        Dim genero As String = ""
        Dim regimen As String = ""
        Dim empleoExt As String = ""
        Dim nivel As String = ""
        Dim residencia As String = ""
        Dim otrosIngresos As String = ""
        Dim aportacionesAdic As String = ""


        genero = validaNull(Me.ClientesBindingSource.Current("Genero").Replace("Masculino", "F ( )  M (X)").Replace("Femenino", "F (X)  M ( )"))
        If Me.PROMSolicitudesLIQBindingSource.Current("RegimenConyugal") = "SEPARACION DE BIENES" Then
            regimen = "( )  Sociedad Conyugal    (X)  Separación de Bienes    ( )  N/A"
        ElseIf Me.PROMSolicitudesLIQBindingSource.Current("RegimenConyugal") = "SOCIEDAD CONYUGAL" Then
            regimen = "(X)  Sociedad Conyugal    ( )  Separación de Bienes    ( )  N/A"
        ElseIf Me.PROMSolicitudesLIQBindingSource.Current("RegimenConyugal") = "N/A" Then
            regimen = "( )  Sociedad Conyugal    ( )  Separación de Bienes    (X)  N/A"
        End If
        empleoExt = IIf(Me.PROMSolicitudesLIQBindingSource.Current("CargoPublico") = True, "Si (X)    No ( )", "Si ( )    No (X)")
        nivel = validaNull(Me.PROMSolicitudesLIQBindingSource.Current("Nivel").Replace("Local", "Local  (X)    Estatal  ( )    Federal  ( )").Replace("Estatal", "Local  ( )    Estatal  (X)    Federal  ( )").Replace("Federal", "Local  ( )    Estatal  ( )    Federal  (X)"))
        residencia = validaNull(Me.PROMSolicitudesLIQBindingSource.Current("ResidenciaExtranjero").ToString.Replace("True", "Si  (X)    No  ( )").Replace("False", "Si  ( )    No  (X)"))
        otrosIngresos = validaNull(Me.PROMSolicitudesLIQBindingSource.Current("OtrosIngresos").ToString.Replace("True", "Si  (X)    No  ( )").Replace("False", "Si  ( )    No  (X)"))
        aportacionesAdic = validaNull(Me.PROMSolicitudesLIQBindingSource.Current("AportacionesAdicionales").ToString.Replace("True", "Si  (X)    No  ( )").Replace("False", "Si  ( )    No  (X)"))


        Dim rpt As New rptAltaLiquidez
        rpt.SetDataSource(Me.PromocionDS)
        rpt.SetParameterValue("var_genero", genero, "rptAltaLiquidezAnverso")
        rpt.SetParameterValue("var_regimen", regimen, "rptAltaLiquidezAnverso")
        rpt.SetParameterValue("var_empleoExt", empleoExt, "rptAltaLiquidezAnverso")
        rpt.SetParameterValue("var_nivel", nivel, "rptAltaLiquidezAnverso")
        rpt.SetParameterValue("var_residencia", residencia, "rptAltaLiquidezAnverso")
        rpt.SetParameterValue("var_otrosIngresos", otrosIngresos, "rptAltaLiquidezAnverso")
        rpt.SetParameterValue("var_aportacionesAdic", aportacionesAdic, "rptAltaLiquidezAnverso")

        frmRPTAltaLiquidez.CrystalReportViewer1.ReportSource = rpt
        frmRPTAltaLiquidez.Show()
    End Sub

    Public Function validaNull(valor As Object)
        If String.IsNullOrEmpty(valor) Then
            Return ""
            Exit Function
        Else
            Return valor
            Exit Function
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDatos.Click
        If GuardarDatos() = True Then
            Dim f As New FrmAltaLiquidezFinan
            f.ID_sol = Me.PROMSolicitudesLIQBindingSource.Current("Id_Solicitud")
            If f.ShowDialog Then
                FrmAltaLiquidez_Load(Nothing, Nothing)
                CmbCli_SelectedIndexChanged(Nothing, Nothing)
            End If
        End If
    End Sub

    Sub GuardaOtrosDatos()
        Try
            If Me.PROMSolicitudesLIQBindingSource.Current("NumInt").ToString.Length > 0 Then
                Me.ClientesBindingSource.Current("Calle") = PROMSolicitudesLIQBindingSource.Current("Calle") & " NO EXT." & PROMSolicitudesLIQBindingSource.Current("NumExt") & " NO INT." & PROMSolicitudesLIQBindingSource.Current("NumInt")
            Else
                Me.ClientesBindingSource.Current("Calle") = PROMSolicitudesLIQBindingSource.Current("Calle") & " NO EXT." & PROMSolicitudesLIQBindingSource.Current("NumExt")
            End If
            If Me.ClientesBindingSource.Current("PaisNacimiento").ToString.Trim = "MEXICO" Then
                Me.ClientesBindingSource.Current("Nacionalidad") = "MEXICANA"
            Else
                Me.ClientesBindingSource.Current("Nacionalidad") = "EXTRANJERA"
            End If

            Me.ClientesBindingSource.Current("GeneClie") = "LLAMARSE " & Me.ClientesBindingSource.Current("Descr").ToString.Trim
            Me.ClientesBindingSource.Current("GeneClie") += ", MANIFIESTA POR SUS GENERALES SER DE NACIONALIDAD " & Me.ClientesBindingSource.Current("Nacionalidad").ToString.Trim
            Me.ClientesBindingSource.Current("GeneClie") += ", ORIGINARIO(A) DE " & PROMSolicitudesLIQBindingSource.Current("Originario").ToString.Trim
            Me.ClientesBindingSource.Current("GeneClie") += ", LUGAR DONDE NACIO EL " & CDate(Txtfecnac.Text).ToLongDateString.ToUpper & ", DE ESTADO CIVIL " & Me.PROMSolicitudesLIQBindingSource.Current("EstadoCivil")
            Me.ClientesBindingSource.Current("GeneClie") += ", CON DOMICILIO EN " & Me.ClientesBindingSource.Current("Calle").ToString.Trim & ", C.P. " & Me.ClientesBindingSource.Current("Copos").ToString.Trim
            Me.ClientesBindingSource.Current("GeneClie") += ", " & Me.ClientesBindingSource.Current("Ciudad").ToString.Trim & ", ESTADO DE " & Me.ClientesBindingSource.Current("Estado").ToString.Trim & "."
            ClientesBindingSource.EndEdit()
            ClientesTableAdapter.Update(PromocionDS.Clientes)

            Dim taEmple As New PromocionDSTableAdapters.EmpleadoresTableAdapter
            If taEmple.ExisteCliente(Me.ClientesBindingSource.Current("Cliente")) > 0 Then
                taEmple.UpdateDatos(Me.GENEmpleadoresBindingSource.Current("Empleador"), Me.GENEmpleadoresBindingSource.Current("Calle1"),
                                    Me.GENEmpleadoresBindingSource.Current("Calle2"), Me.GENEmpleadoresBindingSource.Current("Colonia"),
                                    Me.GENEmpleadoresBindingSource.Current("Delegacion"), Me.GENEmpleadoresBindingSource.Current("Ciudad"),
                                    Me.GENEmpleadoresBindingSource.Current("Estado"), Me.GENEmpleadoresBindingSource.Current("copos"),
                                    Me.GENEmpleadoresBindingSource.Current("NumTelef"), Me.GENEmpleadoresBindingSource.Current("ExtTelef"),
                                    Me.GENEmpleadoresBindingSource.Current("NumFax"), Me.ClientesBindingSource.Current("Cliente"),
                                    Me.ClientesBindingSource.Current("Cliente"))
            Else
                taEmple.Insert(Me.ClientesBindingSource.Current("Cliente"), Me.GENEmpleadoresBindingSource.Current("Empleador"), Me.GENEmpleadoresBindingSource.Current("Calle1"),
                                    Me.GENEmpleadoresBindingSource.Current("Calle2"), Me.GENEmpleadoresBindingSource.Current("Colonia"),
                                    Me.GENEmpleadoresBindingSource.Current("Delegacion"), Me.GENEmpleadoresBindingSource.Current("Ciudad"),
                                    Me.GENEmpleadoresBindingSource.Current("Estado"), Me.GENEmpleadoresBindingSource.Current("copos"),
                                    Me.GENEmpleadoresBindingSource.Current("NumTelef"), Me.GENEmpleadoresBindingSource.Current("ExtTelef"),
                                    Me.GENEmpleadoresBindingSource.Current("NumFax"), "", "", "", 0, "", "", "", "", "")
            End If

            Dim taPLD As New PromocionDSTableAdapters.Datos_PLDTableAdapter
            If taPLD.ExisteCliente(Me.ClientesBindingSource.Current("Cliente")) > 0 Then
                taPLD.UpdateDatos(PROMSolicitudesLIQBindingSource.Current("Calle"), PROMSolicitudesLIQBindingSource.Current("NumExt"),
                                  PROMSolicitudesLIQBindingSource.Current("NumInt"), Me.ClientesBindingSource.Current("Copos"),
                                  PROMSolicitudesLIQBindingSource.Current("EstadoNacimiento"), Me.ClientesBindingSource.Current("Cliente"),
                                  Me.ClientesBindingSource.Current("Cliente"))
            Else
                taPLD.Insert(Me.ClientesBindingSource.Current("Cliente"), PROMSolicitudesLIQBindingSource.Current("Calle"),
                             PROMSolicitudesLIQBindingSource.Current("NumExt"), PROMSolicitudesLIQBindingSource.Current("NumInt"),
                             Me.ClientesBindingSource.Current("Copos"), "", "", "",
                             "", Me.ClientesBindingSource.Current("Estado"), "",
                             PROMSolicitudesLIQBindingSource.Current("EstadoNacimiento"))
            End If
            MessageBox.Show("Datos Generales guardados.", "Datos Generales", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class