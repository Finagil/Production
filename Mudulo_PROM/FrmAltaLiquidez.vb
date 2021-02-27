Imports System.Data.SqlClient
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
        Me.GEN_EstadoCivilTableAdapter.Fill(Me.GeneralDS.GEN_EstadoCivil)
        'TODO: esta línea de código carga datos en la tabla 'PromocionDS.GEN_Empleadores' Puede moverla o quitarla según sea necesario.
        Me.GEN_EmpleadoresTableAdapter.Fill(Me.PromocionDS.GEN_Empleadores)
        Me.PlazasTableAdapter.Fill(Me.PromocionDS.Plazas)
        Me.PlazasTableAdapter.Fill(Me.PromocionDS1.Plazas)
        Me.LI_PeriodosTableAdapter.Fill(Me.PromocionDS.LI_Periodos)
        Me.LI_PlazosTableAdapter.FillHasta36(Me.PromocionDS.LI_Plazos)
        If TaQUERY.SacaPermisoModulo("SOL_LIQUIDEZ", UsuarioGlobal) > 0 Then
            Me.ContClie1TableAdapter.FillByPersonas(Me.ProductionDataSet.ContClie1)
        Else
            Me.ContClie1TableAdapter.FillByPersonasPromo(Me.ProductionDataSet.ContClie1, UsuarioGlobalCorreo)
        End If
    End Sub

    Private Sub BttNewCli_Click(sender As Object, e As EventArgs) Handles BttNewCli.Click
        Dim f As New frmAltaClie
        If f.ShowDialog = DialogResult.OK Then
            If UsuarioGlobal = "desarrollo" Then
                Me.ContClie1TableAdapter.FillByPersonas(Me.ProductionDataSet.ContClie1)
            Else
                Me.ContClie1TableAdapter.FillByPersonasPromo(Me.ProductionDataSet.ContClie1, UsuarioGlobalCorreo)
            End If
        End If
    End Sub

    Private Sub CmbCli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCli.SelectedIndexChanged
        If CmbCli.SelectedIndex >= 0 Then
            Me.ClientesTableAdapter.Fill(PromocionDS.Clientes, CmbCli.SelectedValue)
            Me.PROM_SolicitudesLIQTableAdapter.Fill(PromocionDS.PROM_SolicitudesLIQ, CmbCli.SelectedValue)
        End If
    End Sub

    Private Sub BtnNewSol_Click(sender As Object, e As EventArgs) Handles BtnNewSol.Click
        If PromocionDS.PROM_SolicitudesLIQ.Rows.Count <= 0 Then
            Me.PROMSolicitudesLIQBindingSource.AddNew()
            ComboBox1.SelectedIndex = 0
            ComboBox2.SelectedIndex = 0
            ComboBox3.SelectedIndex = 0
            ComboBox4.SelectedIndex = 0
            ComboBox5.SelectedIndex = 0
            ComboBox6.SelectedIndex = 0
            ComboBox7.SelectedIndex = 0
            ComboBox8.SelectedIndex = 0
            CmbtipoVivienda.SelectedIndex = 0
            DtpFecSol.Value = Now.Date
            Me.PROMSolicitudesLIQBindingSource.Current("FirmaPROM") = ""
            Me.PROMSolicitudesLIQBindingSource.Current("FirmaCRE") = ""
            Me.PROMSolicitudesLIQBindingSource.Current("FirmaDG") = ""
            Me.PROMSolicitudesLIQBindingSource.Current("calle") = ""
            Me.PROMSolicitudesLIQBindingSource.Current("empresa") = ""
            Me.PROMSolicitudesLIQBindingSource.Current("entrecalles") = ""
            Me.PROMSolicitudesLIQBindingSource.Current("ocupacion") = ""
            Me.PROMSolicitudesLIQBindingSource.Current("fecha") = DtpFecSol.Value
            Me.PROMSolicitudesLIQBindingSource.Current("TipoVivienda") = "Propia"
            DTPIngreso.Value = Date.Now.Date.AddYears(-2)
            Me.PROMSolicitudesLIQBindingSource.Current("fechaIngreso") = DTPIngreso.Value
            ProcesaRFC()
            Me.PROMSolicitudesLIQBindingSource.Current("Cliente") = CmbCli.SelectedValue
        Else
            Dim r As PromocionDS.PROM_SolicitudesLIQRow
            r = PromocionDS.PROM_SolicitudesLIQ.NewPROM_SolicitudesLIQRow
            r.ItemArray = PromocionDS.PROM_SolicitudesLIQ.Rows(PromocionDS.PROM_SolicitudesLIQ.Rows.Count - 1).ItemArray
            r.Id_Solicitud = -1
            r.MontoFinanciado = 0
            r.Procesado = False
            r.UsuarioCredito = ""
            r.Estatus = "PENDIENTE"
            r.RCD = 0
            r.ClavesBC = ""
            r.AtrasosBC = ""
            r.ExperienciaBC = ""
            r.SalarioNeto = 0
            r.Pasivos = 0
            r.Fecha = Now.Date
            DtpFecSol.Value = Now.Date
            PromocionDS.PROM_SolicitudesLIQ.AddPROM_SolicitudesLIQRow(r)
            Combosol.SelectedIndex = Combosol.Items.Count - 1
        End If
        BtnNewSol.Enabled = 0
        BtnCancel.Enabled = 1
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
            Txtedad.Text = Fix(DateDiff(DateInterval.Day, f, Date.Now) / 365)
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
            If Not IsNumeric(TextBox1.Text) Then
                MessageBox.Show("Monto financiado incorrecto", "Monto Financiado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            ElseIf val(TextBox1.Text) > 500000 Then
                MessageBox.Show("Monto solo puede ser hasta 500,000.", "Monto Financiado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            ElseIf DTPIngreso.Value > Date.Now.Date.AddYears(-1) Then
                MessageBox.Show("No tiene la Antigüedad para este producto", "Antigüedad", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                PROMSolicitudesLIQBindingSource.EndEdit()
                If CheckGrales.Checked = True Then
                    GuardaOtrosDatos()
                End If
                PROM_SolicitudesLIQTableAdapter.Update(PromocionDS.PROM_SolicitudesLIQ)
                Return True
            End If
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
        'BtnNewSol.Enabled = B
        BtnSave.Enabled = Not B
        BtnPrint.Enabled = Not B
        BtnDatos.Enabled = Not B
        CheckGrales.Enabled = Not B
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
            regimen = "( )  Sociedad Conyugal    (X)  Separación de Bienes    ( )"
        ElseIf Me.PROMSolicitudesLIQBindingSource.Current("RegimenConyugal") = "SOCIEDAD CONYUGAL" Then
            regimen = "(X)  Sociedad Conyugal    ( )  Separación de Bienes    ( )"
        ElseIf Me.PROMSolicitudesLIQBindingSource.Current("RegimenConyugal") = "N/A" Then
            regimen = "( )  Sociedad Conyugal    ( )  Separación de Bienes    (X)"
        End If
        empleoExt = IIf(Me.PROMSolicitudesLIQBindingSource.Current("CargoPublico") = True, "Si (X)    No ( )", "Si ( )    No (X)")
        nivel = validaNull(Me.PROMSolicitudesLIQBindingSource.Current("Nivel").Replace("Local", "Local  (X)    Estatal  ( )    Federal  ( )").Replace("Estatal", "Local  ( )    Estatal  (X)    Federal  ( )").Replace("Federal", "Local  ( )    Estatal  ( )    Federal  (X)"))
        residencia = validaNull(Me.PROMSolicitudesLIQBindingSource.Current("ResidenciaExtranjero").ToString.Replace("True", "Si  (X)    No  ( )").Replace("False", "Si  ( )    No  (X)"))
        otrosIngresos = validaNull(Me.PROMSolicitudesLIQBindingSource.Current("OtrosIngresos").ToString.Replace("True", "Si  (X)    No  ( )").Replace("False", "Si  ( )    No  (X)"))
        aportacionesAdic = validaNull(Me.PROMSolicitudesLIQBindingSource.Current("AportacionesAdicionales").ToString.Replace("True", "Si  (X)    No  ( )").Replace("False", "Si  ( )    No  (X)"))


        Dim rpt As New rptAltaLiquidezTodo

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
            f.GeneroCli = ClientesBindingSource.Current("Genero")
            If f.ShowDialog Then
                FrmAltaLiquidez_Load(Nothing, Nothing)
                CmbCli_SelectedIndexChanged(Nothing, Nothing)
            End If
        End If
    End Sub

    Sub GuardaOtrosDatos()
        Try
            If Me.PROMSolicitudesLIQBindingSource.Current("NumInt").ToString.Length > 0 Then
                Me.ClientesBindingSource.Current("Calle") = PROMSolicitudesLIQBindingSource.Current("Calle") & " NO." & PROMSolicitudesLIQBindingSource.Current("NumExt") & " INT." & PROMSolicitudesLIQBindingSource.Current("NumInt")
            Else
                Me.ClientesBindingSource.Current("Calle") = PROMSolicitudesLIQBindingSource.Current("Calle") & " NO." & PROMSolicitudesLIQBindingSource.Current("NumExt")
            End If
            If Me.ClientesBindingSource.Current("PaisNacimiento").ToString.Trim = "MEXICO" Then
                Me.ClientesBindingSource.Current("Nacionalidad") = "MEXICANA"
            Else
                Me.ClientesBindingSource.Current("Nacionalidad") = "EXTRANJERA"
            End If
            If PROMSolicitudesLIQBindingSource.Current("Calle").ToString.Length > 0 Then
                Me.ClientesBindingSource.Current("Ubicacion") = PROMSolicitudesLIQBindingSource.Current("Ubicacion")
            End If

            Me.ClientesBindingSource.Current("GeneClie") = "LLAMARSE " & Me.ClientesBindingSource.Current("Descr").ToString.Trim
            Me.ClientesBindingSource.Current("GeneClie") += ", MANIFIESTA POR SUS GENERALES SER DE NACIONALIDAD " & Me.ClientesBindingSource.Current("Nacionalidad").ToString.Trim
            Me.ClientesBindingSource.Current("GeneClie") += ", ORIGINARIO(A) DE " & PROMSolicitudesLIQBindingSource.Current("Originario").ToString.Trim
            Me.ClientesBindingSource.Current("GeneClie") += ", LUGAR DONDE NACIO EL " & CDate(Txtfecnac.Text).ToLongDateString.ToUpper & ", DE ESTADO CIVIL " & Me.PROMSolicitudesLIQBindingSource.Current("EstadoCivil")
            Me.ClientesBindingSource.Current("GeneClie") += ", CON DOMICILIO EN " & Me.ClientesBindingSource.Current("Calle").ToString.Trim & ", COLONIA " & Me.ClientesBindingSource.Current("Colonia").ToString.Trim & " C.P. " & Me.ClientesBindingSource.Current("Copos").ToString.Trim
            Me.ClientesBindingSource.Current("GeneClie") += ", " & Me.ClientesBindingSource.Current("Ciudad").ToString.Trim & ", ESTADO DE " & Me.ClientesBindingSource.Current("Estado").ToString.Trim
            Me.ClientesBindingSource.Current("GeneClie") += ", CON RFC: " & Me.ClientesBindingSource.Current("RFC").ToString.Trim
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If TextLiga.Text <> "" Then
            If Mid(TextLiga.Text.ToLower, 1, 20) = "https://goo.gl/maps/" Then
                Process.Start(TextLiga.Text)
            Else
                MessageBox.Show("Liga no valida", "Google Maps", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Process.Start("https://www.google.com.mx/maps")
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        BtnNewSol.Enabled = 1
        BtnCancel.Enabled = 0
        PROMSolicitudesLIQBindingSource.CancelEdit()
    End Sub

    Private Sub DTPIngreso_LostFocus(sender As Object, e As EventArgs) Handles DTPIngreso.LostFocus
        If DTPIngreso.Value > Date.Now.Date.AddYears(-1) Then
            MessageBox.Show("No tiene la Antigüedad para este producto", "Antigüedad", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox17_LostFocus(sender As Object, e As EventArgs) Handles TextBox17.LostFocus
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daCodigos As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet()
        Dim drCodigo As DataRow

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT DISTINCT Copos, Estado, Delegacion FROM Codigos WHERE Copos = " & TextBox17.Text
            .Connection = cnAgil
        End With

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Plazas"
            .Connection = cnAgil
        End With

        daCodigos.Fill(dsAgil, "Codigos")
        If dsAgil.Tables("Codigos").Rows.Count > 0 Then
            Dim Estado As String
            drCodigo = dsAgil.Tables("Codigos").Rows(0)
            Estado = Trim(drCodigo("Estado")).ToUpper
            TextBox14.Text = Trim(drCodigo("Delegacion")).ToUpper

            Estado = Estado.Replace("Á", "A")
            Estado = Estado.Replace("É", "E")
            Estado = Estado.Replace("Í", "I")
            Estado = Estado.Replace("Ó", "O")
            Estado = Estado.Replace("Ü", "U")
            ComboBox7.Text = Estado
        Else
            Me.PromocionDS.ClavesFira.Clear()
            TextBox14.Text = ""
        End If

        cnAgil.Dispose()
        cm1.Dispose()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New FrmCalculadoraRDC
        f.Show()
    End Sub

    Private Sub PROMSolicitudesLIQBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles PROMSolicitudesLIQBindingSource.CurrentChanged
        If PromocionDS.PROM_SolicitudesLIQ.Rows.Count > 0 And Not IsNothing(Me.PROMSolicitudesLIQBindingSource.Current) Then
            If Me.PROMSolicitudesLIQBindingSource.Current("Procesado") Then
                Botones(True)
                BtnPrint.Enabled = True
            Else
                Botones(False)
                ProcesaRFC()
            End If
        End If
    End Sub

    Private Sub LbAut_Click(sender As Object, e As EventArgs) Handles LbAut.Click
        Try
            Dim id As Integer
            Dim Fecha As Date
            If IsNumeric(Combosol.Text) Then
                id = Combosol.Text
                Fecha = DTPIngreso.Value.ToShortDateString
            Else
                id = InputBox("id")
                Fecha = InputBox("Fecha Ingreso")
            End If
            Dim f As New FrmAltaLiquidezFinan
            f.GeneraCorreoAUTX(id, Fecha)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class