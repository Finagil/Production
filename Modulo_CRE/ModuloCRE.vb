Module ModuloCRE

    Public Sub AltaLineaCreditoLIQUIDEZ1(Cliente As String, Monto As Decimal, Notas As String, Id_sol As Integer)
        Try
            Dim TaLinea As New CreditoDSTableAdapters.CRED_LineasCreditoTableAdapter
            TaLinea.Insert(Cliente, "", Id_sol, Monto, "LIQUIDEZ", 2, Date.Now, Date.Now, Date.Now.AddDays(30), Notas, UsuarioGlobal)
            BITACORA.Insert(UsuarioGlobal, "Automatica LQ", Date.Now, "LineaCredito1", System.Environment.MachineName, Monto.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Alta de Linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub AltaLineaCreditoLIQUIDEZ2(Cliente As String, Monto As Decimal)
        Try
            Dim SolStr As String = ""
            Dim Anexo As String = ""
            Dim Dispo As String
            Dim TaCredit As New CreditoDSTableAdapters.CreditTableAdapter
            Dim taDetSol As New CreditoDSTableAdapters.DetSolTableAdapter
            Dim NoContratos As Integer = taDetSol.NoContratos(Cliente)
            Dim NoDispo As Integer = taDetSol.NoDispo(Cliente)
            If NoContratos = 0 Then
                SolStr = taDetSol.SacaSolCreStr(Cliente)
                If SolStr.Trim <> "" Then
                    TaCredit.DeleteALL(SolStr)
                    taDetSol.DeleteAll(SolStr)
                End If
            End If
            If taDetSol.NoSolicitudes(Cliente) = 0 Then
                Dispo = "001"
                SolStr = FOLIOS.FolioSolCre
                Anexo = FOLIOS.FolioAnexo
                SolStr = Stuff(SolStr, "I", "0", 6)
                Anexo = Stuff(Anexo, "I", "0", 5)
                TaCredit.Insert(SolStr, Date.Now.ToString("yyyyMMdd"), 1, Date.Now.ToString("yyyyMMdd"), Date.Now.ToString("yyyyMMdd"), "", Monto, Date.Now.ToString("yyyyMMdd"), Anexo,
                                Date.Now.AddDays(30).ToString("yyyyMMdd"), Monto, "LIQUIDEZ", "")
                FOLIOS.ConsumeSolCre()
                FOLIOS.ConsumeFolioAnexo()
                taDetSol.InsertDispo(SolStr, Dispo, Cliente, Monto)
            Else
                If NoContratos > NoDispo Then ' iguala contratos contra solicitudes
                    For x As Integer = NoDispo + 1 To NoContratos
                        taDetSol.InsertDispo(SolStr, Stuff(x, "I", "0", 3), Cliente, Monto)
                    Next
                End If
                SolStr = taDetSol.SacaSolCreStr(Cliente)
                TaCredit.UpdateLinea(5, Date.Now.ToString("yyyyMMdd"), "", Monto, Date.Now.ToString("yyyyMMdd"), Date.Now.AddDays(30).ToString("yyyyMMdd"), "LIQUIDEZ", SolStr, 0)
                Dispo = NoDispo + 1
                Dispo = Stuff(Dispo, "I", "0", 3)
                If NoContratos >= NoDispo Then
                    taDetSol.InsertDispo(SolStr, Dispo, Cliente, Monto)
                End If
            End If

            BITACORA.Insert(UsuarioGlobal, "Automatica LQ", Date.Now, "LineaCredito2", System.Environment.MachineName, Monto.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Alta de Linea", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

End Module
