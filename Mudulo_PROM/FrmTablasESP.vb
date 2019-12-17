Public Class FrmTablasESP
    Dim TasaIVA As Decimal = 0.16
    Dim Valida As Boolean = True
    Dim Corrige As DialogResult
    Dim AnexosGEN As New ProductionDataSetTableAdapters.AnexosTableAdapter

    Private Sub FrmTablasESP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtTasPen.ReadOnly = False
        TxtTasa.ReadOnly = False
        TxtDif.ReadOnly = False
        TxtPorcComi.ReadOnly = False
        CmbAcumInte.Enabled = True
        CmbLiquidez.Enabled = True
        Me.ClientesTablaESPTableAdapter.FillByALL(Me.PromocionDS.ClientesTablaESP)
        If UsuarioGlobal.ToUpper = "ACAMACHO" Then
            ClientesTablaESPBindingSource.Filter = "PROMO = '026'"
        End If
        CmbCLI_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub CmbCLI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCLI.SelectedIndexChanged
        If CmbCLI.SelectedIndex >= 0 Then
            Me.AnexosTablaESPTableAdapter.FillByALL(Me.PromocionDS.AnexosTablaESP, CmbCLI.SelectedValue)
            Bttclear_Click(Nothing, Nothing)
            CmbAnexos_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Sub Formatear()

        If IsNumeric(TxtMF.Text) Then TxtMF.Text = CDec(TxtMF.Text).ToString("N2")
        If IsNumeric(TxtComi.Text) Then TxtComi.Text = CDec(TxtComi.Text).ToString("N2")
        If IsNumeric(TxtGastos.Text) Then TxtGastos.Text = CDec(TxtGastos.Text).ToString("N2")
        If IsNumeric(TxtIvaGtos.Text) Then TxtIvaGtos.Text = CDec(TxtIvaGtos.Text).ToString("N2")
        If IsNumeric(TxtDere.Text) Then TxtDere.Text = CDec(TxtDere.Text).ToString("N2")
        If IsNumeric(TxtImpRd.Text) Then TxtImpRd.Text = CDec(TxtImpRd.Text).ToString("N2")
        If IsNumeric(TxtDG.Text) Then TxtDG.Text = CDec(TxtDG.Text).ToString("N2")
        If IsNumeric(TxtIvadg.Text) Then TxtIvadg.Text = CDec(TxtIvadg.Text).ToString("N2")
        If IsNumeric(TxtIvaRd.Text) Then TxtIvaRd.Text = CDec(TxtIvaRd.Text).ToString("N2")
        If IsNumeric(TxtOpcion.Text) Then TxtOpcion.Text = CDec(TxtOpcion.Text).ToString("N2")
        If IsNumeric(TxtMensu.Text) Then TxtMensu.Text = CDec(TxtMensu.Text).ToString("N2")
        If IsNumeric(TxtRD.Text) Then
            If CInt(TxtRD.Text) > 0 Then
                TxtRD.ReadOnly = False
            End If
        End If
        If AnexosGEN.CapitalDeTrabajo(CmbAnexos.SelectedValue) > 0 Then
            CmbFega.SelectedIndex = 1
        Else
            CmbFega.SelectedIndex = 0
        End If

        DTPContrato.Value = CTOD(TxtFEcCon.Text)
        'DateTimePicker1.Value = CTOD(TxtFvenc.Text)
        If TxtTipta.Text = "7" Then CmbTipoTasa.SelectedIndex = 0 Else CmbTipoTasa.SelectedIndex = 1
        If AnexosTablaESPBindingSource.Current("prenda").ToString.Trim = "S" Then CombopPrenda.Text = "S" Else CombopPrenda.Text = "N"
        If AnexosTablaESPBindingSource.Current("ghipotec").ToString.Trim = "S" Then ComboHipotec.Text = "S" Else ComboHipotec.Text = "N"


    End Sub

    Private Sub CmbAnexos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAnexos.SelectedIndexChanged
        If CmbAnexos.SelectedIndex >= 0 Then
            Me.TablaESPTableAdapter.Fill(Me.PromocionDS.TablaESP, CmbAnexos.SelectedValue)
            Formatear()
            If TxtTipta.Text = "7" Then ' fija
                CmbTipoTasa.SelectedIndex = 0
            Else
                CmbTipoTasa.SelectedIndex = 1
            End If
            If TxtLiquidez.Text = "False" Then ' fija
                CmbLiquidez.SelectedIndex = 0
            Else
                CmbLiquidez.SelectedIndex = 1
            End If
            If TxtDomi.Text = "S" Then
                BtnDomi.Enabled = False
            Else
                BtnDomi.Enabled = True
            End If
        End If
    End Sub

    Private Sub Bttclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttclear.Click
        Me.PromocionDS.TablaESPTMP.Clear()
        CmbAnexos_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub BttPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttPaste.Click
        Try
            Dim ClipboardData As IDataObject = Clipboard.GetDataObject()
            Me.PromocionDS.TablaESPTMP.Clear()
            If Not ClipboardData Is Nothing Then
                If (ClipboardData.GetDataPresent(DataFormats.CommaSeparatedValue)) Then

                    Dim ClipboardStream As New IO.StreamReader(
                       CType(ClipboardData.GetData(DataFormats.CommaSeparatedValue), IO.Stream))

                    Dim FormattedData As String = ""

                    While (ClipboardStream.Peek() > 0)
                        Dim SingleRowData As Array
                        Dim LoopCounter As Integer = 0

                        FormattedData = ClipboardStream.ReadLine()
                        SingleRowData = FormattedData.Split(",".ToCharArray)

                        Dim rowNew As PromocionDS.TablaESPTMPRow
                        rowNew = Me.PromocionDS.TablaESPTMP.NewRow()

                        For LoopCounter = 0 To SingleRowData.GetUpperBound(0)
                            rowNew(LoopCounter) = SingleRowData.GetValue(LoopCounter)
                        Next

                        LoopCounter = 0

                        Me.PromocionDS.TablaESPTMP.Rows.Add(rowNew)

                        rowNew = Nothing
                    End While

                    ClipboardStream.Close()
                    DataGridView2.DataSource = Me.PromocionDS.TablaESPTMP
                    'RevisaTasa()
                Else
                    MessageBox.Show("Datos de Portapapeles no parece ser copiado de Excel!", "Portapapeles", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("El portapapeles esta vacio!", "Portapapeles", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DataGridView2.Rows.Count <= 0 Then
            If MessageBox.Show("¿Desea solo guardar datos del contrato?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim Cobertura, Fondeo, AplicaFega As String
                Dim Liquidez As Boolean
                AnexosGEN.DeleteCapitalTrabajo(CmbAnexos.SelectedValue)
                If CmbFega.SelectedIndex = 1 Then
                    AnexosGEN.InsertCapitalTrabajo(CmbAnexos.SelectedValue)
                    Fondeo = "03"
                    Cobertura = "S"
                    AplicaFega = "S"
                Else
                    Fondeo = "01"
                    Cobertura = "N"
                    AplicaFega = "N"
                End If

                If CmbLiquidez.SelectedIndex = 0 Then
                    Liquidez = False
                Else
                    Liquidez = True
                End If
                TxtComi.Text = (CDec(TxtMF.Text) * (CDec(TxtPorcComi.Text) / 100) * 1.16).ToString("n2")
                Me.AnexosTablaESPTableAdapter.CambiaDatosAnexoSinTabla(TxtTasa.Text, TxtDif.Text,
                             CmbAcumInte.Text, TxtDG.Text, TxtIvadg.Text, TxtRD.Text, TxtImpRd.Text, TxtIvaRd.Text, TxtTasPen.Text,
                             Fondeo, Cobertura, Liquidez, TxtOpcion.Text, DTPContrato.Value.ToString("yyyyMMdd"), TxtDere.Text, TxtPorcComi.Text,
                             TxtComi.Text, AplicaFega, TxtIvaGtos.Text, TxtGastos.Text, CombopPrenda.Text, ComboHipotec.Text, CmbAnexos.SelectedValue)
                Exit Sub
            End If

        End If

        Valida = True
        Dim Tcapital, IVAinter, IVAcap, SaldoIni, Plazo As Decimal
        Dim ErrorFecha As Boolean = False
        Dim ErrorIVAInte As Boolean = False
        Dim ErrorIVAcap As Boolean = False
        Dim FecAnt As Date
        Dim FechaIni As Date
        Dim FechaCon As Date = CTOD(TxtFEcCon.Text)

        For Each r As PromocionDS.TablaESPTMPRow In Me.PromocionDS.TablaESPTMP
            Plazo += 1

            Tcapital += Math.Round(r.Capital, 2)
            IVAinter += Math.Round(r.IvaInteres)
            IVAcap += Math.Round(r.IvaCapital)

            If r.IvaCapital > 0 Then
                If Math.Round(r.IvaCapital / r.Capital, 2) <> TasaIVA Then
                    ErrorIVAcap = True
                End If
            End If

            If r.IvaInteres > 0 Then
                If Math.Round(r.IvaInteres / r.Interes, 2) <> TasaIVA And TxtTipar.Text <> "P" Then
                    ErrorIVAInte = True
                End If
                If Math.Round(r.IvaInteres / (r.Interes + r.Capital), 2) <> TasaIVA And TxtTipar.Text = "P" Then
                    ErrorIVAInte = True
                End If

            End If

            If Plazo = 1 Then
                SaldoIni = r.Saldo
                FechaIni = r.Fecha
            Else
                If FecAnt >= r.Fecha Then
                    ErrorFecha = True
                End If
            End If
            FecAnt = r.Fecha
        Next

        If CDec(TxtMF.Text) <> SaldoIni Then
            MessageBox.Show("el monto financiado no coincide con el Saldo inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If MessageBox.Show("¿deseas continuar con el error?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
        End If
        If Math.Abs(CDec(TxtMF.Text) - Tcapital) > 0.001 Then
            MessageBox.Show("La suma de Capital no coincide con el monto financiado" & vbCrLf _
            & "MF  =" & TxtMF.Text & vbCrLf & "SUM=" & Tcapital.ToString("n2") _
            , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If MessageBox.Show("¿deseas continuar con el error?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
        End If
        If FechaCon >= FechaIni Then
            MessageBox.Show("Fecha de contratación mayor o igual a la fecha de primer vencimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Date.Now >= FechaIni And Valida = True Then
            MessageBox.Show("Fecha de primer vencimiento menor o igual al dia de hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ErrorFecha = True Then
            MessageBox.Show("Error en Fechas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not IsNumeric(TxtTasPen.Text) Then
            MessageBox.Show("Penalización por prepago no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtTasPen.Focus()
            Exit Sub
        End If
        If CDec((TxtTasPen.Text)) > 2 Or CDec((TxtTasPen.Text)) < 0 Then
            MessageBox.Show("Penalización por prepago no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtTasPen.Focus()
            Exit Sub
        End If
        If RevisaTasa() = False Then
            Exit Sub
        End If
        If TxtRD.ReadOnly = False Then
            If Not IsNumeric(TxtRD.Text) Then
                MessageBox.Show("Numero de rentas en depoisto no validas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CInt(TxtRD.Text) > 3 Or CInt(TxtRD.Text) < 1 Then
                MessageBox.Show("Numero de rentas en depoisto no validas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If TxtTipar.Text = "F" Then
            If IVAcap = 0 Then
                MessageBox.Show("Falta Iva de Capital", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If IVAinter = 0 Then
                MessageBox.Show("Falta Iva de Inetereses", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If ErrorIVAcap = True Then
                MessageBox.Show("Error en calculo de Iva de Capital", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If ErrorIVAInte = True Then
                MessageBox.Show("Error en calculo de Iva de Interes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If TxtTipar.Text = "P" Then
            If IVAinter = 0 Then
                MessageBox.Show("Falta Iva de la renta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If ErrorIVAInte = True Then
                MessageBox.Show("Error en calculo de Iva de Interes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If LbTipoP.Text = "F" Then
            If IVAinter = 0 Then
                MessageBox.Show("Falta Iva de Inetereses en este crédito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If ErrorIVAInte = True Then
                MessageBox.Show("Error en calculo de Iva de Interes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            If IVAinter <> 0 And TxtTipar.Text <> "F" And TxtTipar.Text <> "P" Then
                MessageBox.Show("No lleva  Iva de Inetereses en este crédito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        InsertaAnexo(Plazo, FechaIni)
    End Sub

    Private Sub BttnDomi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDomi.Click
        Me.AnexosTablaESPTableAdapter.ActivaDomi("S", CmbAnexos.SelectedValue)
        MessageBox.Show("Domiciliación Activada", "Domiciliación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BtnDomi.Enabled = False
    End Sub

    Function RevisaTasa() As Boolean
        If Me.PromocionDS.TablaESPTMP.Rows.Count >= 2 Then
            Dim FecIni As Date
            Dim Dias, Cont, X As Integer
            Dim Interes1, Interes2 As Decimal
            Dim r1 As PromocionDS.TablaESPTMPRow
            Dim r2 As PromocionDS.TablaESPTMPRow
            Dim drTemporal As DataRow
            Cont = 1
            TxtTasa.ReadOnly = True
            CmbAcumInte.Enabled = False

            For X = 0 To Me.PromocionDS.TablaESPTMP.Rows.Count - 1
                Cont += 1
                If X = 0 Then
                    r1 = Me.PromocionDS.TablaESPTMP.Rows(X)
                    FecIni = DTPContrato.Value
                Else
                    r1 = Me.PromocionDS.TablaESPTMP.Rows(X - 1)
                    FecIni = r1.Fecha
                End If
                r2 = Me.PromocionDS.TablaESPTMP.Rows(X)
                If X > 0 Then
                    If IsDate(r1.Fecha) = False Or IsDate(r2.Fecha) = False Then
                        MessageBox.Show("Error en fechas de la tabla especial. Linea: " & Cont, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                        Exit Function
                    End If
                    Dias = DateDiff(DateInterval.Day, CDate(r1.Fecha), CDate(r2.Fecha))
                Else
                    Dias = DateDiff(DateInterval.Day, DTPContrato.Value, CDate(r2.Fecha)) + 1
                End If

                Interes1 = 0
                If CmbAcumInte.Text.ToUpper = "NO" Then ' fija
                    Interes1 = Math.Round(r2.Saldo * ((CDec(TxtTasa.Text) + CDec(TxtDif.Text)) / 36000) * Dias, 2)
                Else
                    For Each drTemporal In InteresAcumulado(CmbAnexos.SelectedValue, TxtTipta.Text, "FINAGIL", CDate(FecIni).ToString("yyyyMMdd"),
                    r2.Saldo, TxtTasa.Text, TxtDif.Text, CDate(r2.Fecha).ToString("yyyyMMdd"), Nothing, CDate(r2.Fecha).ToString("yyyyMMdd"), TxtTipar.Text, True).Rows
                        Interes1 += drTemporal("Interes")
                    Next
                End If

                Interes2 = r2.Interes

                If Math.Abs(Interes1 - Interes2) > 0.5 And Corrige <> Windows.Forms.DialogResult.Yes Then
                    MessageBox.Show("Error en el calculo de interes. Linea: " & Cont, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Corrige = MessageBox.Show("¿Corregir intereses?", "Correccion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If Corrige <> Windows.Forms.DialogResult.Yes Then
                        Return False
                    End If
                End If
                If Corrige = Windows.Forms.DialogResult.Yes Then
                    r2.Interes = Interes1
                    If TxtTipar.Text = "P" Then
                        r2.IvaInteres = (r2.Interes + r2.Capital) * TasaIVA
                    Else
                        If r2.IvaInteres > 0 Then
                            r2.IvaInteres = (r2.Interes) * TasaIVA
                        End If
                    End If
                End If
            Next
            Return True
        End If
    End Function

    Sub InsertaAnexo(ByVal Plazo As Integer, ByVal FechaIni As Date)
        If MessageBox.Show("¿esta seguro de cargar la Tabla solicitada?", "Tabla Especial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim Tabla As New PromocionDSTableAdapters.EdoctavTableAdapter
            Dim ta As New PromocionDSTableAdapters.RentasdepTableAdapter
            Dim Rentas As Integer = 0
            Dim RD As Decimal = 0
            Dim RDIva As Decimal = 0
            Dim Mensu As Decimal = 0

            If IsNumeric(TxtRD.Text) Then
                If CInt(TxtRD.Text) > 0 Then
                    Rentas = TxtRD.Text
                    Rentas = Plazo - Rentas
                    ta.BorraRentas(CmbAnexos.SelectedValue)
                Else
                    Rentas = 9999
                End If
            End If
            Tabla.DeleteAnexo(CmbAnexos.SelectedValue)
            Dim Letra As String = ""
            Dim LetraN As Integer = 0
            For Each r As PromocionDS.TablaESPTMPRow In Me.PromocionDS.TablaESPTMP
                LetraN += 1
                If LetraN = 1 Then
                    Mensu = r.Capital + r.Interes + r.IvaCapital + r.IvaInteres
                End If
                Letra = Stuff(LetraN.ToString, "I", "0", 3)
                Tabla.Insert(CmbAnexos.SelectedValue, Letra, CDate(r.Fecha).ToString("yyyyMMdd"), 0, "S", r.Saldo, r.Capital, r.Interes, r.IvaInteres, r.IvaCapital, 0, 0)
                If LetraN >= Rentas Then
                    ta.Insert(CmbAnexos.SelectedValue, Letra, CDate(r.Fecha).ToString("yyyyMMdd"), 0, "S", r.Saldo, r.Capital, r.Interes, r.IvaInteres, r.IvaCapital, "N")
                    RD += r.Capital + r.Interes
                    RDIva += r.IvaCapital + r.IvaInteres
                End If
            Next
            'terminado***********************
            Dim Fondeo, Cobertura, AplicaFega As String
            Dim Liquidez As Boolean = False
            AnexosGEN.DeleteCapitalTrabajo(CmbAnexos.SelectedValue)
            If CmbFega.SelectedIndex = 1 Then
                AnexosGEN.InsertCapitalTrabajo(CmbAnexos.SelectedValue)
                Fondeo = "03"
                Cobertura = "S"
                AplicaFega = "S"
            Else
                Fondeo = "01"
                Cobertura = "N"
                AplicaFega = "N"
            End If

            If CmbLiquidez.SelectedIndex = 0 Then
                Liquidez = False
            Else
                Liquidez = True
            End If
            TxtComi.Text = (CDec(TxtMF.Text) * (CDec(TxtPorcComi.Text) / 100) * 1.16).ToString("n2")
            Me.AnexosTablaESPTableAdapter.CambiaDatosAnexo(TxtTasa.Text, TxtDif.Text, Plazo,
             CmbAcumInte.Text, TxtDG.Text, TxtIvadg.Text, TxtRD.Text, RD, RDIva, TxtTasPen.Text,
             Fondeo, Cobertura, FechaIni.ToString("yyyyMMdd"), Liquidez, TxtOpcion.Text, Mensu,
             DTPContrato.Value.ToString("yyyyMMdd"), TxtDere.Text, TxtPorcComi.Text, TxtComi.Text, AplicaFega,
             TxtGastos.Text, TxtIvaGtos.Text, CombopPrenda.Text, ComboHipotec.Text, CmbAnexos.SelectedValue)

            Me.PromocionDS.TablaESPTMP.Clear()
            CmbAnexos_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub


End Class