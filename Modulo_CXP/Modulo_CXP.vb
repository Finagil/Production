Module Modulo_CXP
    Public Sub Inserta_CXP_MOVS()
        Dim Folio As Decimal
        Dim TaPAg As New CxpDSTableAdapters.CXP_PagosTesoreriaTableAdapter
        Dim taCuent As New CxpDSTableAdapters.CXP_CuentasBancariasProvTableAdapter
        Dim taProv As New CxpDSTableAdapters.CXP_ProveedoresTableAdapter
        Dim TaMinis As New CxpDSTableAdapters.TESO_Datos_LayOut_CXPTableAdapter
        Dim tMinis As New CxpDS.TESO_Datos_LayOut_CXPDataTable
        TaMinis.Fill(tMinis)
        Dim cFecha As String = Today.ToString("yyyyMMdd")
        For Each r As CxpDS.TESO_Datos_LayOut_CXPRow In tMinis.Rows
            If r.IsclabeNull Then
                MandaCorreoFase("Avios@cmoderna.com", "sistemas", "Prductor sin idProveedor", r.Anexo & r.Ciclo & Stuff(r.Ministracion.ToString, "I", "0", 2))
            Else
                Folio = FOLIOS.FolioCXP_AVI()
                FOLIOS.ConsumeFolioCXP_AVI()
                TaPAg.InsertPago("AVI", Folio, r.idCuentas, r.Importe, CTOD(r.FechaAlta), CTOD(r.FechaAlta), r.Moneda, Date.Now, r.Anexo & r.Ciclo & Stuff(r.Ministracion.ToString, "I", "0", 2), r.idProveedor)
                TaMinis.UpdateMinistracion(cFecha, cFecha, UsuarioGlobal, r.Anexo, r.Ciclo, r.Ministracion)
            End If
        Next
    End Sub
End Module
