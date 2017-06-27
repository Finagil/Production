Public Class FrmIVApagar

    Dim rx As ContaDS.IVApagarRow
    Dim taudis As New ContaDSTableAdapters.UdisTableAdapter
    Dim udis As New ContaDS.UdisDataTable
    Dim udiR As ContaDS.UdisRow
    Dim UDI As Decimal
    Dim taS As New ContaDSTableAdapters.EdoctasTableAdapter
    Dim taO As New ContaDSTableAdapters.EdoctaoTableAdapter
    Dim ts As New ContaDS.EdoctasDataTable
    Dim tto As New ContaDS.EdoctaoDataTable
    Dim taV As New ContaDSTableAdapters.EdoctavTableAdapter
    Dim tv As New ContaDS.EdoctavDataTable
    Dim rr As ContaDS.EdoctavRow
    Dim rrS As ContaDS.EdoctasRow
    Dim rrO As ContaDS.EdoctaoRow
    Dim LetraU As String
    Dim PrimerVenc As String
    Dim TiieAct As Decimal
    Dim TiieAnt As Decimal
    Dim tabla As New ContaDS.IVApagarDataTable
    Dim ta As New ContaDSTableAdapters.AnexosIVApagarTableAdapter
    Dim t As New ContaDS.AnexosIVApagarDataTable
    Dim t2 As New ContaDS.AnexosIVApagarDataTable
    Dim r As ContaDS.AnexosIVApagarRow
    Dim cad As String



    Private Sub FrmIVApagar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As Date = Date.Now.AddMonths(-12)
        Dim dt As New DataTable
        Dim r As DataRow
        dt.Columns.Add("Fecha", System.Type.GetType("System.String"))
        dt.Columns.Add("Titulo", System.Type.GetType("System.String"))
        CmbFecha.ValueMember = "Fecha"
        CmbFecha.DisplayMember = "titulo"

        For X As Integer = 1 To 12
            r = dt.NewRow
            r.Item(0) = f.ToString("yyyyMM")
            r.Item(1) = f.ToString("MMM yyyy").ToUpper
            dt.Rows.Add(r)
            f = f.AddMonths(1)
        Next

        CmbFecha.DataSource = dt
        CmbFecha.SelectedIndex = CmbFecha.Items.Count - 1
    End Sub

    Private Sub BtnProc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProc.Click
        Cursor.Current = Cursors.WaitCursor
        ProgressBar1.Visible = True
        ContaDS.IVApagar.Clear()
        cad = CmbFecha.SelectedValue
        'cad = "200507"
        Dim Ant As String = CTOD(cad & "01").AddMonths(-1).ToString("yyyyMM")
        Dim contador As Integer = 0
        TiieAct = ta.SacaTIIE(cad)
        TiieAnt = ta.SacaTIIE(Ant)

        ta.Fill(t, cad & "%")
        ta.FillByNEWS(t2, cad & "31", cad & "%")

        ProgressBar1.Maximum = t.Rows.Count + t2.Rows.Count
        For Each r In t.Rows
            contador += 1
            ProgressBar1.Value = contador
            'If r.Anexo <> "036400001" Then Continue For ' para pruebas
            genera_Datos(cad, r, TiieAct, TiieAnt)
            'If contador = 10 Then Exit For
        Next
        For Each r In t2.Rows
            contador += 1
            ProgressBar1.Value = contador
            If r.Anexo = "038240001" Then Continue For ' credito ing leal
            If r.Anexo = "025620003" Then Continue For ' Transforma
            genera_Datos(cad, r, TiieAct, TiieAnt)
            'If contador = 10 Then Exit For
        Next
        Dim rpt As New RptIvaPagar
        rpt.SetDataSource(ContaDS)
        rpt.SetParameterValue("Mes", CTOD(cad).ToString("MMMM yyyy"))
        CRV1.ReportSource = rpt
        GridIva.DataSource = ContaDS.IVApagar
        ProgressBar1.Visible = False
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub genera_Datos(ByVal Mes As String, ByVal r As ContaDS.AnexosIVApagarRow, ByVal TieAct As Decimal, ByVal TieAnt As Decimal)
        Try


            LetraU = taV.UltimaLetra(r.Anexo)
            PrimerVenc = taV.FechaPrimerVenc(r.Anexo)
            Dim Adela As String = ""
            Dim Filas As Integer
            Dim fechaI As Date = CTOD(Mes & "01")
            Dim FechaF As Date = fechaI.AddMonths(1)
            Dim Primera As Boolean = True
            Dim SaldoT As Decimal = 0
            Dim SeguroT As Decimal = 0
            Dim OtrosT As Decimal = 0
            FechaF = FechaF.AddDays(-1)
            taV.FillSinAdelantos(tv, r.Anexo, Mes & "%")
            Filas = 1

            If r.Anexo = "036400001" Then
                r.Anexo = "036400001"
            End If

            If tv.Rows.Count > 0 Then ' TIENE LETRAS EN EL MES
                For Each rr In tv.Rows
                    'If rr.Nufac >= 7777777 And Primera = True Then
                    '    SaldoAdela1 = SacaSaldo()
                    '    Filas += 1
                    '    Primera = False
                    '    Continue For
                    'End If
                    If r.Tipta = "7" Then
                        TieAct = r.Tasas
                        TieAnt = r.Tasas
                    End If
                    If rr.Nufac >= 7777777 Then
                        Adela = "Si"
                    End If
                    If fechaI.Day = 1 Then 'PRIMERA LINEA
                        rx = ContaDS.IVApagar.NewRow
                        rx.Anexo = r.AnexoCon
                        'If SaldoAdela1 > 0 Then
                        '    rx.Saldo = SaldoAdela1
                        '    SaldoAdela1 = 0
                        'Else
                        rx.Saldo = SacaSaldo(SaldoT, SeguroT, OtrosT, r.Tipo, r.Tipar)
                        'End If

                        rx.Tasa = TieAnt
                        rx.Diferencial = r.Difer
                        rx.Inicio = fechaI
                        SacaUDI(fechaI)
                        rx.UdiInicial = UDI
                        fechaI = CTOD(rr.Feven)
                        SacaUDI(fechaI)
                        rx.UdiFinal = UDI
                        rx.Fin = fechaI.AddDays(-1)
                        rx.Dias = DateDiff(DateInterval.Day, rx.Inicio, rx.Fin) + 1
                        rx.Iva = CalculaIVA(r.TasaIVACliente / 100)
                        rx.Adelanto = Adela
                        rx.AnexoSin = r.Anexo
                        rx.Tipar = r.Tipar
                        rx.FechaActivacion = CTOD(r.Fecha_Pago).ToShortDateString
                        rx.FechaTerminacion = CTOD(r.FechaVen).ToShortDateString

                        If rx.Dias <> 0 And SaldoT > 0 Then ContaDS.IVApagar.Rows.Add(rx)
                    End If
                    If Filas = tv.Rows.Count Then ' ULTIMA LINEA
                        If rr.Letra <> LetraU Then ' NO ES ULTIMA LETRA
                            rx = ContaDS.IVApagar.NewRow
                            rx.Anexo = r.AnexoCon
                            rx.Saldo = SacaSaldoACT(SaldoT, SeguroT, OtrosT, rr.Letra, r.Tipo, r.Tipar)
                            rx.Tasa = TieAct
                            rx.Diferencial = r.Difer
                            rx.Inicio = fechaI
                            SacaUDI(fechaI)
                            rx.UdiInicial = UDI
                            fechaI = FechaF.AddDays(1)
                            SacaUDI(fechaI)
                            rx.UdiFinal = UDI
                            rx.Fin = FechaF
                            rx.Dias = DateDiff(DateInterval.Day, rx.Inicio, rx.Fin) + 1
                            rx.Iva = CalculaIVA(r.TasaIVACliente / 100)
                            rx.Adelanto = Adela
                            rx.AnexoSin = r.Anexo
                            rx.Tipar = r.Tipar
                            rx.FechaActivacion = CTOD(r.Fecha_Pago).ToShortDateString
                            rx.FechaTerminacion = CTOD(r.FechaVen).ToShortDateString
                            If rx.Dias <> 0 And SaldoT > 0 Then ContaDS.IVApagar.Rows.Add(rx)

                        End If
                    Else 'LETRA INTERMEDIA
                        Filas += 1
                        rx = ContaDS.IVApagar.NewRow
                        rx.Anexo = r.AnexoCon
                        rx.Saldo = SacaSaldoACT(SaldoT, SeguroT, OtrosT, rr.Letra, r.Tipo, r.Tipar)
                        rx.Tasa = TieAnt
                        rx.Diferencial = r.Difer
                        rx.Inicio = fechaI
                        SacaUDI(fechaI)
                        rx.UdiInicial = UDI
                        fechaI = CTOD(tv.Rows(Filas - 1).Item("Feven"))
                        SacaUDI(fechaI)
                        rx.UdiFinal = UDI
                        rx.Fin = fechaI.AddDays(-1)
                        rx.Dias = DateDiff(DateInterval.Day, rx.Inicio, rx.Fin) + 1
                        rx.Iva = CalculaIVA(r.TasaIVACliente / 100)
                        rx.Adelanto = Adela
                        rx.AnexoSin = r.Anexo
                        rx.Tipar = r.Tipar
                        rx.FechaActivacion = CTOD(r.Fecha_Pago).ToShortDateString
                        rx.FechaTerminacion = CTOD(r.FechaVen).ToShortDateString
                        If rx.Dias = -1 Then
                            fechaI = fechaI.AddDays(1)
                            rx.Dias = 0
                        End If
                        If rx.Dias <> 0 And SaldoT > 0 Then ContaDS.IVApagar.Rows.Add(rx)

                    End If
                Next
            Else 'NO TIENE LETRAS EN EL MES
                If r.Tipta = "7" Then
                    TieAct = r.Tasas
                    TieAnt = r.Tasas
                End If

                If PrimerVenc > FechaF.ToString("yyyyMMdd") Then
                    If CTOD(r.Fecha_Pago) > fechaI And CTOD(r.Fecha_Pago) <= FechaF Then
                        fechaI = CTOD(r.Fecha_Pago)
                    End If

                    'Cierre
                    rx = ContaDS.IVApagar.NewRow
                    rx.Anexo = r.AnexoCon
                    SaldoT = r.MontoFinanciado
                    rx.Saldo = SaldoT
                    rx.Tasa = TieAct
                    rx.Diferencial = r.Difer
                    rx.Inicio = fechaI
                    SacaUDI(fechaI.AddDays(1))
                    rx.UdiInicial = UDI
                    fechaI = FechaF.AddDays(1)
                    SacaUDI(fechaI)
                    rx.UdiFinal = UDI
                    rx.Fin = FechaF
                    rx.Dias = DateDiff(DateInterval.Day, rx.Inicio, rx.Fin) + 1
                    rx.Iva = CalculaIVA(r.TasaIVACliente / 100)
                    rx.Adelanto = ""
                    rx.AnexoSin = r.Anexo
                    rx.Tipar = r.Tipar
                    rx.FechaActivacion = CTOD(r.Fecha_Pago).ToShortDateString
                    rx.FechaTerminacion = CTOD(r.FechaVen).ToShortDateString
                    If rx.Dias <> 0 And SaldoT > 0 Then ContaDS.IVApagar.Rows.Add(rx)
                Else
                    taV.FillByLetraSinFact(tv, r.Anexo)
                    rr = tv.Rows(0)

                    rx = ContaDS.IVApagar.NewRow
                    rx.Anexo = r.AnexoCon
                    SacaSaldo(SaldoT, SeguroT, OtrosT, r.Tipo, r.Tipar)
                    rx.Saldo = SaldoT
                    rx.Tasa = TieAct
                    rx.Diferencial = r.Difer
                    rx.Inicio = fechaI
                    SacaUDI(fechaI.AddDays(1))
                    rx.UdiInicial = UDI
                    fechaI = FechaF.AddDays(1)
                    SacaUDI(fechaI)
                    rx.UdiFinal = UDI
                    rx.Fin = FechaF
                    rx.Dias = DateDiff(DateInterval.Day, rx.Inicio, rx.Fin) + 1
                    rx.Iva = CalculaIVA(r.TasaIVACliente / 100)
                    rx.Adelanto = ""
                    rx.AnexoSin = r.Anexo
                    rx.Tipar = r.Tipar
                    rx.FechaActivacion = CTOD(r.Fecha_Pago).ToShortDateString
                    rx.FechaTerminacion = CTOD(r.FechaVen).ToShortDateString
                    If rx.Dias <> 0 And SaldoT > 0 Then ContaDS.IVApagar.Rows.Add(rx)
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, r.Anexo)
        End Try
    End Sub

    Private Sub SacaUDI(ByVal fec As Date)
        taudis.Fill(udis, fec)
        udiR = udis.Rows(0)
        UDI = udiR.Udi
    End Sub

    Private Function CalculaIVA(ByVal IVA As Decimal) As Decimal
        Dim factor As Decimal = (rx.UdiFinal / rx.UdiInicial) - 1
        Dim inte As Decimal = 0
        Dim Interes As Decimal = 0
        If factor <= 0 Then
            inte = (((rx.Tasa + rx.Diferencial) / 36000) * rx.Dias)
        Else
            inte = (((rx.Tasa + rx.Diferencial) / 36000) * rx.Dias) - factor
        End If
        Interes = rx.Saldo * inte
        CalculaIVA = Math.Round(Interes * IVA, 2)
        If CalculaIVA < 0 Then
            CalculaIVA = 0
        End If

    End Function

    Private Function SacaSaldo(ByRef SaldoT As Decimal, ByRef SEG As Decimal, ByRef OTRO As Decimal, ByVal Tipo As String, ByVal Tipar As String) As Decimal
        If SaldoT = 0 Then
            SEG = 0
            OTRO = 0
            SaldoT = rr.Saldo
            If Tipo <> "F" And Tipar = "F" Then
                '**** NO SUMA SEGURO NI OTROS ADEUDOS****
            Else
                'SEGURO
                taS.Fill(ts, rr.Anexo, rr.Letra)
                For Each rrS In ts.Rows
                    If rrS.Nufac < 7777777 And rrS.Feven.Substring(0, 6) = cad Then
                        SaldoT += rrS.Saldo
                        SEG = rrS.Abcap
                    End If
                Next
                'OTROS
                taO.Fill(tto, rr.Anexo, rr.Letra)
                For Each rrO In tto.Rows
                    If rrO.Nufac < 7777777 And rrO.Feven.Substring(0, 6) = cad Then
                        SaldoT += rrO.Saldo
                        OTRO = rrO.Abcap
                    End If
                Next
            End If
        Else
            SaldoT = "A"
            SaldoT -= rr.Abcap
            'SEGURO
            taS.Fill(ts, rr.Anexo, rr.Letra)
            For Each rrS In ts.Rows
                If rrS.Nufac < 7777777 And rrS.Feven.Substring(0, 6) = cad Then
                    SaldoT -= rrS.Abcap
                End If
            Next
            'OTROS
            taO.Fill(tto, rr.Anexo, rr.Letra)
            For Each rrO In tto.Rows
                If rrO.Nufac < 7777777 And rrO.Feven.Substring(0, 6) = cad Then
                    SaldoT -= rrO.Abcap
                End If
            Next

        End If
        Return SaldoT
    End Function

    Private Function SacaSaldoACT(ByRef SaldoT As Decimal, ByRef SEG As Decimal, ByRef OTRO As Decimal, ByVal Letra As String, ByVal Tipo As String, ByVal Tipar As String) As Decimal
        If Letra <> "000" Then
            Dim Nletras As Integer = CInt(Letra) + 1
            Letra = Microsoft.VisualBasic.Right("000" & Nletras.ToString, 3)
        Else
            Letra = rr.Letra
        End If
        SaldoT -= rr.Abcap + SEG + OTRO
        SEG = 0
        OTRO = 0


        If Tipo <> "F" And Tipar = "F" Then
            '**** NO SUMA SEGURO NI OTROS ADEUDOS****
        Else ' suma SEG y OTROS para personas Fisicas
            'SEGURO
            taS.Fill(ts, rr.Anexo, Letra)
            For Each rrS In ts.Rows
                If rrS.Nufac < 7777777 And rrS.Feven.Substring(0, 6) = cad Then
                    'SaldoT += rrS.Saldo
                    SEG = rrS.Abcap
                End If
            Next
            'OTROS
            taO.Fill(tto, rr.Anexo, rr.Letra)
            For Each rrO In tto.Rows
                If rrO.Nufac < 7777777 And rrO.Feven.Substring(0, 6) = cad Then
                    'SaldoT += rrO.Saldo
                    OTRO = rrO.Abcap
                End If
            Next
        End If
        Return SaldoT
    End Function

    Public Function GeneraIVAdevengado(ByVal Fecha As String) As ContaDS.IVApagarDataTable
        ContaDS.IVApagar.Clear()
        cad = Fecha
        Dim Ant As String = CTOD(cad & "01").AddMonths(-1).ToString("yyyyMM")
        TiieAct = ta.SacaTIIE(cad)
        TiieAnt = ta.SacaTIIE(Ant)
        ta.Fill(t, cad & "%")
        ta.FillByNEWS(t2, cad & "31", cad & "%")
        For Each r In t.Rows
            genera_Datos(cad, r, TiieAct, TiieAnt)
        Next
        For Each r In t2.Rows
            If r.Anexo = "038240001" Then Continue For ' credito ing leal
            genera_Datos(cad, r, TiieAct, TiieAnt)
        Next
        Return ContaDS.IVApagar
    End Function

End Class