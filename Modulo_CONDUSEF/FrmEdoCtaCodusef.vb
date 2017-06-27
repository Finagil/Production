Public Class FrmEdoCtaCodusef

    Private Sub FrmEdoCtaCodusef_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ClientesActivosTableAdapter.Fill(Me.ProductionDataSet.ClientesActivos)
        CmbClientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub CmbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbClientes.SelectedIndexChanged
        If CmbClientes.SelectedValue <> Nothing Then
            Me.AnexosActivosTableAdapter.Fill(Me.ProductionDataSet.AnexosActivos, CmbClientes.SelectedValue)
            LstAnexos_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub LstAnexos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstAnexos.SelectedIndexChanged
        If LstAnexos.SelectedValue <> Nothing Then
            Me.PeriodosTableAdapter.Fill(Me.ProductionDataSet.Periodos, LstAnexos.SelectedValue)
        Else
            Me.ProductionDataSet.Periodos.Rows.Clear()
        End If
    End Sub

    Private Sub BttConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttConsulta.Click
        Cursor = Cursors.WaitCursor
        Dim IntePag As Double = 0
        Dim TotalPag As Double = 0
        Dim Comision As Double = 0
        Dim SaldoAnt As Double = 0
        Dim MontoMora As Double = 0
        Dim SaldoVenc As Double = 0

        If IsNumeric(LbSaldoAnt.Text) Then SaldoAnt = CDbl(LbSaldoAnt.Text)

        Dim rep As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim DS As New ProductionDataSet
        Dim Ta As New ProductionDataSetTableAdapters.AnexosTableAdapter
        Dim Tf As New ProductionDataSetTableAdapters.FacturasTableAdapter
        If Not IsDBNull(Tf.ScalarSaldoVenc(LstAnexos.SelectedValue, LbLetra.Text)) Then SaldoVenc = Tf.ScalarSaldoVenc(LstAnexos.SelectedValue, LbLetra.Text)


        LLena_Abonos(DS, CDate(LbFI.Text), CDate(LbFF.Text), IntePag, TotalPag, Comision, MontoMora)
        LLena_Cargos(DS, CDate(LbFI.Text), CDate(LbFF.Text))

        Ta.FillByAnexo(DS.Tables("Anexos"), LstAnexos.SelectedValue)
        Tf.FillFactura(DS.Tables("Facturas"), LstAnexos.SelectedValue, LstPeriodos.SelectedValue)

        'For Each rr As FinagilDS.TablaLetrasRow In T1.Rows
        'DS.Tables("TablaLetras").ImportRow(rr)
        'Next

        Dim newrpt As New rptEdoCtaAF
        newrpt.SetDataSource(DS)
        newrpt.SetParameterValue("IntePag", IntePag)
        newrpt.SetParameterValue("Comision", Comision)
        newrpt.SetParameterValue("TotalMes", TotalPag)
        newrpt.SetParameterValue("totalVenc", SaldoVenc)
        newrpt.SetParameterValue("PagVecn", SaldoVenc)
        newrpt.SetParameterValue("SaldoAnterior", SaldoAnt)
        newrpt.SetParameterValue("PagAnticipado", 0)
        newrpt.SetParameterValue("MontoMora", MontoMora)
        newrpt.SetParameterValue("Periodo", UCase(CDate(LbFI.Text).ToString("dd \de MMMM") & " al " & CDate(LbFF.Text).ToString("dd \de MMMM \del yyyy")))
        CRVReporte.ReportSource = newrpt
        Cursor = Cursors.Default
    End Sub

    Private Sub LstPeriodos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstPeriodos.SelectedIndexChanged
        If LstPeriodos.SelectedValue <> Nothing Then
        End If
    End Sub

    Sub LLena_Cargos(ByRef DS As ProductionDataSet, ByVal FI As Date, ByVal FF As Date)
        Dim Consec As Integer = 100
        Dim r As ProductionDataSet.TdetalleRow
        Dim Facturas As New ProductionDataSetTableAdapters.FacturasTableAdapter
        Dim Fact As New ProductionDataSet.FacturasDataTable
        Facturas.FillFactura(Fact, LstAnexos.SelectedValue, LstPeriodos.SelectedValue)
        Dim rr As ProductionDataSet.FacturasRow = Fact.Rows(0)
        'Cargos
        Consec += 1
        r = DS.Tables("Tdetalle").NewRow
        r.Anexo = LstAnexos.SelectedValue
        r.Fecha = CTOD(rr.Feven)
        r.Consec = Consec
        r.Abono = 0
        r.Cargo = rr.RenPr - rr.IntPr
        r.Concepto = "CAPITAL"
        If r.Cargo <> 0 Then DS.Tables("Tdetalle").Rows.Add(r)
        'Cargos
        'Cargos
        Consec += 1
        r = DS.Tables("Tdetalle").NewRow
        r.Anexo = LstAnexos.SelectedValue
        r.Fecha = CTOD(rr.Feven)
        r.Consec = Consec
        r.Abono = 0
        r.Cargo = rr.IvaCapital
        r.Concepto = "IVA CAPITAL"
        If r.Cargo > 0 Then DS.Tables("Tdetalle").Rows.Add(r)
        'Cargos
        'Cargos
        Consec += 1
        r = DS.Tables("Tdetalle").NewRow
        r.Anexo = LstAnexos.SelectedValue
        r.Fecha = CTOD(rr.Feven)
        r.Consec = Consec
        r.Abono = 0
        r.Cargo = rr.RenSe
        r.Concepto = "CAPITAL DEL SEGURO"
        If r.Cargo <> 0 Then DS.Tables("Tdetalle").Rows.Add(r)
        'Cargos
        'Cargos
        Consec += 1
        r = DS.Tables("Tdetalle").NewRow
        r.Anexo = LstAnexos.SelectedValue
        r.Fecha = CTOD(rr.Feven)
        r.Consec = Consec
        r.Abono = 0
        r.Cargo = rr.IvaSe
        r.Concepto = "IVA DEL SEGURO"
        If r.Cargo <> 0 Then DS.Tables("Tdetalle").Rows.Add(r)
        'Cargos
        'Cargos
        Consec += 1
        r = DS.Tables("Tdetalle").NewRow
        r.Anexo = LstAnexos.SelectedValue
        r.Fecha = CTOD(rr.Feven)
        r.Consec = Consec
        r.Abono = 0
        r.Cargo = rr.CapitalOt
        r.Concepto = "CAPITAL OTROS"
        If r.Cargo <> 0 Then DS.Tables("Tdetalle").Rows.Add(r)
        'Cargos
        'Cargos
        Consec += 1
        r = DS.Tables("Tdetalle").NewRow
        r.Anexo = LstAnexos.SelectedValue
        r.Fecha = CTOD(rr.Feven)
        r.Consec = Consec
        r.Abono = 0
        r.Cargo = rr.IvaOt
        r.Concepto = "IVA OTROS"
        If r.Cargo <> 0 Then DS.Tables("Tdetalle").Rows.Add(r)
        'Cargos
        'Cargos
        Consec += 1
        r = DS.Tables("Tdetalle").NewRow
        r.Anexo = LstAnexos.SelectedValue
        r.Fecha = CTOD(rr.Feven)
        r.Consec = Consec
        r.Abono = 0
        r.Cargo = rr.IntPr + rr.IntSe + rr.InteresOt + rr.VarSe + rr.VarOt + rr.VarPr
        r.Concepto = "INTERESES"
        If r.Cargo <> 0 Then DS.Tables("Tdetalle").Rows.Add(r)
        'Cargos
        'Cargos
        Consec += 1
        r = DS.Tables("Tdetalle").NewRow
        r.Anexo = LstAnexos.SelectedValue
        r.Fecha = CTOD(rr.Feven)
        r.Consec = Consec
        r.Abono = 0
        r.Cargo = rr.IvaPr
        r.Concepto = "IVA INTERESES"
        If r.Cargo <> 0 Then DS.Tables("Tdetalle").Rows.Add(r)
        'Cargos
        'Cargos
        Consec += 1
        r = DS.Tables("Tdetalle").NewRow
        r.Anexo = LstAnexos.SelectedValue
        r.Fecha = CTOD(rr.Feven)
        r.Consec = Consec
        r.Abono = 0
        r.Cargo = rr.Opcion
        r.Concepto = "OPCION A COMPRA"
        If r.Cargo <> 0 Then DS.Tables("Tdetalle").Rows.Add(r)
        'Cargos
        'Cargos
        Consec += 1
        r = DS.Tables("Tdetalle").NewRow
        r.Anexo = LstAnexos.SelectedValue
        r.Fecha = CTOD(rr.Feven)
        r.Consec = Consec
        r.Abono = 0
        r.Cargo = rr.IvaOpcion
        r.Concepto = "IVA OPCION"
        If r.Cargo <> 0 Then DS.Tables("Tdetalle").Rows.Add(r)
        'Cargos
        'Cargos
        Consec += 1
        r = DS.Tables("Tdetalle").NewRow
        r.Anexo = LstAnexos.SelectedValue
        r.Fecha = CTOD(rr.Feven)
        r.Consec = Consec
        r.Abono = 0
        r.Cargo = rr.Bonifica * -1
        r.Concepto = "BONIFICACION"
        If r.Cargo <> 0 Then DS.Tables("Tdetalle").Rows.Add(r)
        'Cargos
        'Cargos
        Consec += 1
        r = DS.Tables("Tdetalle").NewRow
        r.Anexo = LstAnexos.SelectedValue
        r.Fecha = CTOD(rr.Feven)
        r.Consec = Consec
        r.Abono = 0
        r.Cargo = rr.SeguroVida
        r.Concepto = "SEGURO DE VIDA"
        If r.Cargo <> 0 Then DS.Tables("Tdetalle").Rows.Add(r)
        'Cargos
        'Cargos
        Consec += 1
        r = DS.Tables("Tdetalle").NewRow
        r.Anexo = LstAnexos.SelectedValue
        r.Fecha = CTOD(rr.Feven)
        r.Consec = Consec
        r.Abono = 0
        r.Cargo = rr.ImporteFEGA
        r.Concepto = "GARANTIA FEGA"
        If r.Cargo <> 0 Then DS.Tables("Tdetalle").Rows.Add(r)
        'Cargos

    End Sub

    Sub LLena_Abonos(ByRef DS As ProductionDataSet, ByVal FI As Date, ByVal FF As Date, ByRef IntePag As Double, ByRef TotalPag As Double, ByRef Comi As Double, ByRef Mora As Double)
        Dim Consec As Integer = 0
        Dim r As ProductionDataSet.TdetalleRow
        Dim Pagos As New ProductionDataSetTableAdapters.HistoriaTableAdapter
        Dim Pag As New ProductionDataSet.HistoriaDataTable
        Pagos.FillByFecha(Pag, LstAnexos.SelectedValue, FI.ToString("yyyyMMdd"), FF.ToString("yyyyMMdd"))
        For Each rr As ProductionDataSet.HistoriaRow In Pag.Rows
            Consec += 1
            r = DS.Tables("Tdetalle").NewRow
            r.Anexo = rr.Anexo
            r.Consec = Consec
            r.Concepto = rr.Observa1
            r.Cargo = 0
            r.Abono = rr.Importe
            TotalPag += rr.Importe
            If Mid(rr.Observa1, 1, 7) = "INTERES" Then
                IntePag += rr.Importe
            End If
            If Mid(rr.Observa1, 1, 8) = "COMISION" Then
                Comi += rr.Importe
            End If
            If Mid(rr.Observa1, 1, 4) = "MORA" Then
                Dim Tf As New ProductionDataSetTableAdapters.FacturasTableAdapter
                Mora = Tf.ImporteFac(LbFacAnt.Text)
            End If
            r.Fecha = CTOD(rr.Fecha)
            DS.Tables("Tdetalle").Rows.Add(r)
        Next
    End Sub

   
    Private Sub CRVReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRVReporte.Load

    End Sub
End Class