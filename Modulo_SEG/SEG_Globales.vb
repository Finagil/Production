Module SEG_Globales
    Public Sub GeneraPolizasLuquidez()
        Dim taSEG_Polizas As New SegurosDSTableAdapters.SEG_PolizasBienesTableAdapter
        Dim Anexos As New SegurosDSTableAdapters.AnexosTableAdapter
        Dim Activos As New SegurosDSTableAdapters.ActifijoTableAdapter
        Dim Ane As New SegurosDS.AnexosDataTable
        Dim ACT As New SegurosDS.ActifijoDataTable
        Dim rr As SegurosDS.AnexosRow
        Activos.FillByLiquidez(ACT)
        For Each r As SegurosDS.ActifijoRow In ACT.Rows
            Anexos.FillByAnexo(Ane, r.Anexo)
            If Ane.Rows.Count > 0 Then
                rr = Ane.Rows(0)
                taSEG_Polizas.InsertPoliza("No Aplica", rr.FPrimera, rr.Fultima, 0,
                0, rr.FPrimera, 15, r.ID, rr.AnexoCon & "-LIQ", "", "NO", "SI", "SI")
            End If
        Next
    End Sub
End Module
