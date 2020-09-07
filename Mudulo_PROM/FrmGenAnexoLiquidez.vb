Imports System.Data.SqlClient
Public Class FrmGenAnexoLiquidez
    Private Sub FrmGenAnexoLiquidez_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LineasLQTableAdapter.Fill(Me.PromocionDS.LineasLQ)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextMonto.Text) = False Then
            MessageBox.Show("Error en el monto a disponer", "Monto a Disponer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CDec(TextMonto.Text) > CDec(TextLinea.Text) Then
            MessageBox.Show("Error en el monto a disponer", "Monto a Disponer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ModuloCRE.AltaLineaCreditoLIQUIDEZ2(Me.LineasLQBindingSource.Current("NoCliente"), CDec(TextMonto.Text), Me.LineasLQBindingSource.Current("FechaAutorizacion"))
            Dim Anexo As String = Genera_ContratoLQ()
            Me.LineasLQTableAdapter.ConsumeLinea("LQ-" & Anexo, Me.LineasLQBindingSource.Current("ID_LINEACREDITO"))
            Me.LineasLQTableAdapter.Fill(Me.PromocionDS.LineasLQ)
        End If
    End Sub

    Function Genera_ContratoLQ() As String
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim strInsert As String

        Dim Disposicion As String = Me.LineasLQTableAdapter.SacaDisposicion(Me.LineasLQBindingSource.Current("NoCliente"))
        Dim AnexoNuevo As String = Me.LineasLQTableAdapter.SacaContrato(Me.LineasLQBindingSource.Current("NoCliente"))
        AnexoNuevo += Stuff(Disposicion, "I", "0", 4)

        Try
            cnAgil.Open()
            Dim ContratoMarco As String = Genera_Contrato_Marco(AnexoNuevo, Me.LineasLQBindingSource.Current("NoCliente"), "L")
            strInsert = "INSERT INTO Anexos(Anexo, Flcan, Cliente, ImpEq, Plazo, IvaEq, Porieq, Amorin, IvaAmorin, Tippe, Tipta, Tasas, Difer, Tipar, 
                                Forca, RtasD, ImpRD, IvaRD, Porco, Comis, Porop, Fechacon, Fvenc, Fondeo, DepNafin, Critas, Tipeq, Gastos, IvaGastos, Mensu, RD, ImpDG, 
                                IvaDG,Derechos, FondoReserva, Prenda, Autoriza, PagaEmp, CNom, TipoFrecuencia, ValorFrecuencia, Amortizaciones, CNEmpresa, CNPlanta, DG, 
                                AplicaFEGA, EsAvio, ContratoMarco, TasaIvaCapital, Automovil, Taspen, SeguroVida, Cobertura, GHipotec, porcFega,PorcReserva,IvaAnexo,Id_ActividadInegi)"
            strInsert += " VALUES ('" & AnexoNuevo & "', 'S', '"
            strInsert += Me.LineasLQBindingSource.Current("NoCliente") & "', '"
            strInsert += CDec(TextMonto.Text) & "', '"
            strInsert += Me.LineasLQBindingSource.Current("Plazo") & "', '0','"
            strInsert += TASA_IVA_SISTEM * 100 & "', '0','0','01','7','99','0','L',"
            strInsert += "'1', '0', '0', '0', '0', '0', '0', '"
            strInsert += Today.ToString("yyyyMMdd") & "', '"
            strInsert += Today.ToString("yyyyMMdd") & "', '"
            strInsert += "01', '0','01','3', '0','0','0','0','0','0','0','0','N','S','N','CN','MESES',1,'1','"
            strInsert += Me.LineasLQBindingSource.Current("NomCorto") & "', '"
            strInsert += Me.LineasLQBindingSource.Current("Planta") & "', '"
            strInsert += "0','S',0,'" & ContratoMarco & "','','N',"
            strInsert += "0," & PORC_SEG & ", 'N', 'N', 0, .3,0,2)"
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()
            TaQUERY.UpdatePromoActualAnexos()

            strInsert = "INSERT INTO Opciones(Anexo, Opcion, IvaOpcion, Porcentaje, Exigible, Pagado)"
            strInsert += " VALUES ('" & AnexoNuevo & "',0,0,0,'N','N')"
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()

            strInsert = "INSERT INTO Actifijo (Anexo,Proveedor,Importe,Detalle,id_ConceptoActivo,factfij)"
            strInsert += " VALUES ('" & AnexoNuevo & "','" & Me.LineasLQBindingSource.Current("Cliente") & "'," & CDec(TextMonto.Text) & ",'LIQUIDEZ INMEDIATA-" & Me.LineasLQBindingSource.Current("DestinoCredito") & "',13,0)"
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()

            strInsert = "INSERT INTO Edoctav(Anexo, Letra, Feven, Nufac, IndRec, Saldo, Abcap, Inter, Iva, IvaCapital)"
            strInsert += " VALUES ('" & AnexoNuevo & "', '001'," & Today.ToString("yyyyMMdd") & ",0,'S'," & CDec(TextMonto.Text) & "," & CDec(TextMonto.Text) & ",0,0,0)"
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()
            MessageBox.Show("Se generó el contrato " & Mid(AnexoNuevo, 1, 5) & "/" & Mid(AnexoNuevo, 6, 4) & " para esta disposición", "Liquidez Inmediata", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim procID As Integer
            Dim newProc As Diagnostics.Process
            newProc = Diagnostics.Process.Start("\\server-raid2\contratos$\Executables\LiquidezInmediata.exe", Me.LineasLQBindingSource.Current("NoCliente"))
            procID = newProc.Id
            Dim procEC As Integer = -1
            If newProc.HasExited Then
                procEC = newProc.ExitCode
            End If
            newProc.Close()
            newProc.Dispose()

        Catch eException As Exception
            MessageBox.Show(eException.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cnAgil.Dispose()
        cm1.Dispose()
        Return AnexoNuevo
    End Function

End Class