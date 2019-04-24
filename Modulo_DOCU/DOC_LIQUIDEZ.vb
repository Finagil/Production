Imports Microsoft.Office.Interop
Module DOC_LIQUIDEZ

    Public Sub SacaConvenio(Anexo As String)
        Dim ta As New DocumentosDSTableAdapters.AnexosConvenioTableAdapter
        Dim t As New DocumentosDS.AnexosConvenioDataTable
        Dim r As DocumentosDS.AnexosConvenioRow
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        Dim Doc As String = "C:\Contratos\Convenio_LIQ" & Anexo & ".doc"
        FileCopy(My.Settings.RootDoc & "Plantillas\Convenio_LIQ.doc", Doc)
        ta.Fill(t, Anexo)
        r = t.Rows(0)

        Documento = MSWord.Documents.Open(Doc)
        Documento.Bookmarks.Item("Anexo1").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Anexo2").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Anexo3").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Anexo4").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Anexo5").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Anexo6").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Anexo7").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Anexo8").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Anexo9").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Acreditado1").Range.Text = r.Descr.Trim
        Documento.Bookmarks.Item("Acreditado2").Range.Text = r.Descr.Trim
        Documento.Bookmarks.Item("FechaConLetra").Range.Text = Cant_LetrasSinParentesis(r.FechaCon.Day, "").ToLower & " de " & MonthName(r.FechaCon.Month).ToLower & " del " & Cant_LetrasSinParentesis(r.FechaCon.Year, "").ToLower.Trim
        Documento.Bookmarks.Item("FechaLetra").Range.Text = Cant_LetrasSinParentesis(r.FechaCon.Day, "").ToLower & " de " & MonthName(r.FechaCon.Month).ToLower & " del " & Cant_LetrasSinParentesis(r.FechaCon.Year, "").ToLower.Trim
        Documento.Bookmarks.Item("Fechalarga").Range.Text = Date.Now.Day & " de " & MonthName(Date.Now.Month).ToLower & " del " & Date.Now.Year & "."
        Documento.Bookmarks.Item("Importe").Range.Text = (r.MontoFinanciado + r.Inte + r.Iva).ToString("n2")
        Documento.Bookmarks.Item("ImporteLetra").Range.Text = Letras((r.MontoFinanciado + r.Inte + r.Iva).ToString())
        Documento.Bookmarks.Item("Inicia").Range.Text = Cant_LetrasSinParentesis(r.FechaCon.Day, "").ToLower & " de " & MonthName(r.FechaCon.Month).ToLower & " del " & Cant_LetrasSinParentesis(r.FechaCon.Year, "").ToLower.Trim
        Documento.Bookmarks.Item("TerminaLetra").Range.Text = Cant_LetrasSinParentesis(r.FechaVen.Day, "").ToLower & " de " & MonthName(r.FechaVen.Month).ToLower & " del " & Cant_LetrasSinParentesis(r.FechaVen.Year, "").ToLower.Trim
        Documento.Bookmarks.Item("Interes").Range.Text = r.Inte.ToString("n2")
        Documento.Bookmarks.Item("Iva").Range.Text = r.Iva.ToString("n2")
        Documento.Bookmarks.Item("MontoFin").Range.Text = r.MontoFinanciado.ToString("n2")
        Documento.Bookmarks.Item("Plazo").Range.Text = r.Plazo
        Documento.Bookmarks.Item("Tasa").Range.Text = r.Tasas.ToString("n2")
        Documento.Bookmarks.Item("TasaLetra").Range.Text = Cant_Letras((r.Tasas.ToString("n2")), "")
        Documento.Bookmarks.Item("TipoCredito1").Range.Text = r.TipoCredito
        Documento.Bookmarks.Item("TipoCredito2").Range.Text = r.TipoCredito
        Documento.Bookmarks.Item("TipoPago").Range.Text = r.Vencimiento.ToLower.Trim & "es"
        Documento.Protect(Word.WdProtectionType.wdAllowOnlyReading, False, "FinagilSofmomENR", False, False)
        Documento.Save()
        MSWord.Documents.Close()
        MSWord.Application.Quit()
        Process.Start(Doc)
    End Sub

    Public Sub SacaCartaAutoriza(Anexo As String)
        Dim ta As New DocumentosDSTableAdapters.CartaAutorizacionTableAdapter
        Dim t As New DocumentosDS.CartaAutorizacionDataTable
        Dim r As DocumentosDS.CartaAutorizacionRow
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        Dim Doc As String = "C:\Contratos\CartaAutorizacion" & Anexo & ".doc"
        FileCopy(My.Settings.RootDoc & "CS\CARTA_AUTORIZACION.doc", Doc)
        ta.Fill(t, Anexo)
        r = t.Rows(0)

        Documento = MSWord.Documents.Open(Doc)
        Documento.Bookmarks.Item("Fecha").Range.Text = "a " & r.Fechacon.ToString("dd") & " de " & r.Fechacon.ToString("MMMM") & " de " & r.Fechacon.ToString("yyyy")
        Documento.Bookmarks.Item("Nombre1").Range.Text = r.Descr.Trim
        Documento.Bookmarks.Item("Nombre2").Range.Text = r.Descr.Trim
        Documento.Bookmarks.Item("Cargo").Range.Text = r.PE_Cargo.Trim
        Documento.Bookmarks.Item("Empresa1").Range.Text = r.PE_Empleador.Trim
        Documento.Bookmarks.Item("Empresa2").Range.Text = r.PE_Empleador.Trim
        Documento.Bookmarks.Item("Empresa3").Range.Text = r.PE_Empleador.Trim
        Documento.Bookmarks.Item("Empresa4").Range.Text = r.PE_Empleador.Trim
        Documento.Bookmarks.Item("Empresa5").Range.Text = r.PE_Empleador.Trim
        Documento.Bookmarks.Item("Empresa6").Range.Text = r.PE_Empleador.Trim
        Documento.Bookmarks.Item("Empresa7").Range.Text = r.PE_Empleador.Trim
        Documento.Bookmarks.Item("Empresa8").Range.Text = r.PE_Empleador.Trim
        Documento.Bookmarks.Item("Empresa9").Range.Text = r.PE_Empleador.Trim
        Documento.Bookmarks.Item("Empresa10").Range.Text = r.PE_Empleador.Trim


        Documento.Protect(Word.WdProtectionType.wdAllowOnlyReading, False, "FinagilSofmomENR", False, False)
        Documento.Save()
        MSWord.Documents.Close()
        MSWord.Application.Quit()
        Process.Start(Doc)


    End Sub

End Module
