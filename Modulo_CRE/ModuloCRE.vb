Module ModuloCRE

    Public Sub AltaLineaCreditoLIQUIDEZ(Cliente As String, Monto As Decimal, Notas As String)
        Try
            Dim SolStr As String = ""
            Dim Dispo As String
            Dim TaCredit As New CreditoDSTableAdapters.CreditTableAdapter
            Dim taDetSol As New CreditoDSTableAdapters.DetSolTableAdapter
            Dim TaLinea As New CreditoDSTableAdapters.CRED_LineasCreditoTableAdapter
            Dim TLinea As New CreditoDS.CRED_LineasCreditoDataTable
            TaLinea.Insert(Cliente, "", 0, Monto, "LIQUIDEZ", 2, Date.Now, Date.Now, Date.Now.AddDays(30), Notas, UsuarioGlobal)
            If taDetSol.NoSolicitudes(Cliente) = 0 Then
                Dispo = "001"
                SolStr = FOLIOS.FolioSolCre
                SolStr = Stuff(SolStr, "I", "0", 6)
                TaCredit.Insert(SolStr, Date.Now.ToString("yyyyMMdd"), 5, Date.Now.ToString("yyyyMMdd"), "", "A", Monto, Date.Now.ToString("yyyyMMdd"), "",
                                Date.Now.AddDays(30).ToString("yyyyMMdd"), Monto, "LIQUIDEZ", "")
                FOLIOS.ConsumeSolCre()
                taDetSol.InsertDispo(SolStr, Dispo, Cliente, Monto)
            Else
                SolStr = taDetSol.SacaSolCreStr(Cliente)
                TaCredit.UpdateLinea(5, Date.Now.ToString("yyyyMMdd"), "A", Monto, Date.Now.ToString("yyyyMMdd"), Date.Now.AddDays(30).ToString("yyyyMMdd"), "LIQUIDEZ", SolStr, 0)
                Dispo = taDetSol.NoDispo(Cliente) + 1
                Dispo = Stuff(Dispo, "I", "0", 3)
            End If

            BITACORA.Insert(UsuarioGlobal, "Automatica LQ", Date.Now, "LineaCredito", System.Environment.MachineName, Monto.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Alta de Linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
