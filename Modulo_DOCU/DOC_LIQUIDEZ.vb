Imports Microsoft.Office.Interop
Module DOC_LIQUIDEZ

    Public Sub SacaConvenio(Anexo As String)
        Dim ta As New DocumentosDSTableAdapters.AnexosConvenioTableAdapter
        Dim ta_edoctav As New PromocionDSTableAdapters.EdoctavTableAdapter
        Dim t As New DocumentosDS.AnexosConvenioDataTable
        Dim r As DocumentosDS.AnexosConvenioRow
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        Dim dsTemporal As New DataSet()
        Dim drAnexo As DataRow


        ' Doc2 = Word.Documents.Add
        Dim Doc As String = "C:\Contratos\Convenio_LIQ" & Anexo & ".doc"
        FileCopy(My.Settings.RootDoc & "Plantillas\Convenio_LIQ2.docx", Doc)
        ta.Fill(t, Anexo)
        r = t.Rows(0)

        Documento = MSWord.Documents.Open(Doc)

        Dim oTable As Word.Table
        Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph
        Dim oPara3 As Word.Paragraph, oPara4 As Word.Paragraph
        Dim oRng As Word.Range
        Dim oShape As Word.InlineShape
        Dim oChart As Object
        Dim Pos As Double

        Dim r1 As Integer, c As Integer
        Dim renglones As Integer = ta_edoctav.GetEdoCta(r.Anexo).Rows.Count
        'oTable = Documento.Tables.Add(Documento.Bookmarks("\endofdoc").Range, 3, 5)
        oTable = Documento.Tables.Add(Documento.Bookmarks("Tabla").Range, renglones, 8)
        oTable.Range.ParagraphFormat.SpaceAfter = 6

        'Leer tabla historia
        Dim i As Integer = 2
        'DAR DE ALTA ENCABEZADOS DE LA TABLA

        oTable.Cell(1, 1).Range.Text = "Letra"
        oTable.Cell(1, 2).Range.Text = "Fecha"
        oTable.Cell(1, 3).Range.Text = "Saldo"
        oTable.Cell(1, 4).Range.Text = "Capital"
        oTable.Cell(1, 5).Range.Text = "Intereses"
        oTable.Cell(1, 6).Range.Text = "Pago sin IVA"
        oTable.Cell(1, 7).Range.Text = "IVA intereses"
        oTable.Cell(1, 8).Range.Text = "Pago con IVA"
        'For c = 1 To 8 'celdas
        For Each row As DataRow In ta_edoctav.GetEdoCta(r.Anexo)
            '  For Each row As DataRow In Dataset1.Tables("nombreDeTabla").Rows
            'Dim dato As String
            'dato = row("nombreDeCampo")

            oTable.Cell(i, 1).Range.Text = row("Letra")
            oTable.Cell(i, 2).Range.Text = CTOD(row("Feven")).ToShortDateString
            oTable.Cell(i, 3).Range.Text = CDec(row("Saldo")).ToString("n2")
            oTable.Cell(i, 4).Range.Text = CDec(row("Abcap")).ToString("n2")
            oTable.Cell(i, 5).Range.Text = CDec(row("Inter")).ToString("n2")
            oTable.Cell(i, 6).Range.Text = CDec(row("Abcap") + row("Inter")).ToString("n2")
            oTable.Cell(i, 7).Range.Text = CDec(row("Iva")).ToString("n2")
            oTable.Cell(i, 8).Range.Text = CDec(row("Abcap") + row("Inter") + row("Iva")).ToString("n2")
            i = i + 1
            ' Next

        Next

        ' Dim renglones As Integer = ta_edoctav.GetEdoCta(r.AnexoCon).Rows.Count

        'For r1 = 1 To renglones 'renglones
        'For c = 1 To 5 'celdas
        'oTable.Cell(r1, 1).Range.Text = row("nombreDeCampo")
        'Next
        'Next


        oTable.Rows(1).Range.Font.Bold = True
        oTable.Rows(1).Range.Font.Italic = True


        Documento.Bookmarks.Item("Anexo1").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Anexo2").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Anexo3").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Anexo4").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Anexo5").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Anexo6").Range.Text = r.AnexoCon
        'Documento.Bookmarks.Item("Anexo7").Range.Text = r.AnexoCon
        'Documento.Bookmarks.Item("Anexo8").Range.Text = r.AnexoCon
        'Documento.Bookmarks.Item("Anexo9").Range.Text = r.AnexoCon
        Documento.Bookmarks.Item("Acreditado1").Range.Text = r.Descr.Trim
        Documento.Bookmarks.Item("Acreditado2").Range.Text = r.Descr.Trim
        Documento.Bookmarks.Item("Acreditado3").Range.Text = r.Descr.Trim
        Documento.Bookmarks.Item("Acreditado4").Range.Text = r.Descr.Trim
        'Documento.Bookmarks.Item("FechaConLetra").Range.Text = Cant_LetrasSinParentesis(r.FechaCon.Day, "").ToLower & " de " & MonthName(r.FechaCon.Month).ToLower & " del " & Cant_LetrasSinParentesis(r.FechaCon.Year, "").ToLower.Trim
        'Documento.Bookmarks.Item("FechaLetra").Range.Text = Cant_LetrasSinParentesis(r.FechaCon.Day, "").ToLower & " de " & MonthName(r.FechaCon.Month).ToLower & " del " & Cant_LetrasSinParentesis(r.FechaCon.Year, "").ToLower.Trim
        Documento.Bookmarks.Item("Fechalarga").Range.Text = Date.Now.Day & " de " & MonthName(Date.Now.Month).ToLower & " del " & Date.Now.Year & "."
        Documento.Bookmarks.Item("Importe").Range.Text = (r.MontoFinanciado).ToString("n2")
        Documento.Bookmarks.Item("ImporteLetra").Range.Text = Letras((r.MontoFinanciado).ToString())
        'Documento.Bookmarks.Item("Inicia").Range.Text = Cant_LetrasSinParentesis(r.FechaCon.Day, "").ToLower & " de " & MonthName(r.FechaCon.Month).ToLower & " del " & Cant_LetrasSinParentesis(r.FechaCon.Year, "").ToLower.Trim
        Documento.Bookmarks.Item("TerminaLetra").Range.Text = Cant_LetrasSinParentesis(r.FechaVen.Day, "").ToLower & " de " & MonthName(r.FechaVen.Month).ToLower & " del " & Cant_LetrasSinParentesis(r.FechaVen.Year, "").ToLower.Trim
        'Documento.Bookmarks.Item("Interes").Range.Text = r.Inte.ToString("n2")
        'Documento.Bookmarks.Item("Iva").Range.Text = r.Iva.ToString("n2")
        'Documento.Bookmarks.Item("MontoFin").Range.Text = r.MontoFinanciado.ToString("n2")
        Documento.Bookmarks.Item("Plazo").Range.Text = r.Plazo
        Documento.Bookmarks.Item("Plazo2").Range.Text = r.Plazo
        Documento.Bookmarks.Item("Tasa").Range.Text = r.Tasas.ToString("n2")
        'Documento.Bookmarks.Item("TasaLetra").Range.Text = Cant_Letras((r.Tasas.ToString("n2")), "")
        'Documento.Bookmarks.Item("TipoCredito1").Range.Text = r.TipoCredito
        'Documento.Bookmarks.Item("TipoCredito2").Range.Text = r.TipoCredito
        Documento.Bookmarks.Item("TipoPago").Range.Text = r.Vencimiento.ToLower.Trim & "es"
        'Nos vamos al marcador llamado "tabla" en el documento, _  

        'tabla





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
