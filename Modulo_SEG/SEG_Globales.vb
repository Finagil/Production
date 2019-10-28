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

    Sub Aplica_Seguro_Vida()
        Dim ta As New SegurosDSTableAdapters.VwSegVidaTableAdapter
        Dim t As New SegurosDS.VwSegVidaDataTable
        Dim R As SegurosDS.VwSegVidaRow
        Dim Para As String = ""
        Dim asunto As String = ""
        Dim Mensaje As String = ""

        ta.Fill(t)
        Console.WriteLine("SEGUROSVIDA")
        For Each R In t.Rows
            If R.Tipo = "M" Then
                ta.UpdateSegVida("N", 0, R.Anexo, R.Ciclo)
            Else
                Dim FechaCon As Date = CTOD(R.Fechacon)
                Dim cad As String = R.RFC.Substring(4, 6)
                If CInt(cad.Substring(0, 2)) <= Date.Now.Year - 2000 Then
                    cad = "20" & cad
                Else
                    cad = "19" & cad
                End If
                Dim FechaNac As Date = CTOD(cad)
                Dim Edad As Integer = DateDiff(DateInterval.Year, FechaNac, FechaCon)
                If Edad >= 70 Then
                    ta.UpdateSegVida("N", 0, R.Anexo, R.Ciclo)
                    asunto = "Contrato sin seguro de Vida " & R.AnexoCon
                    Mensaje = "Contrato Sin seguro de Vida por la edad de Cliente: <br>"
                Else
                    ta.UpdateSegVida("S", R.SeguroVida, R.Anexo, R.Ciclo)
                    asunto = "Contrato con seguro de Vida " & R.AnexoCon
                    Mensaje = "Contrato con seguro de Vida por la edad de Cliente: <br>"
                End If
                Mensaje += "Cliente: " & R.Descr & "<br>"
                Mensaje += "Contrato: " & R.AnexoCon & "<br>"
                Mensaje += "Tipo Crédito: " & R.TipoCredito & "<br>"
                Mensaje += "Fecha de Nacimiento: " & FechaNac.ToShortDateString & "<br>"
                Mensaje += "Edad: " & Edad & "<br>"
                MandaCorreoFase("SEGUROSVIDA@Finagil.com.mx", "SEGUROSVIDA", asunto, Mensaje, )
            End If
        Next
    End Sub
End Module
