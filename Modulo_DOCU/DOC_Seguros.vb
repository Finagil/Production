Imports Microsoft.Office.Interop
Module DOC_Seguros
    Public Function NOTIFICACION_PROXIMA_VENCER(Cliente As String, Serie As String, FechaVecn As Date, TipoCredito As String, Anexo As String) As String
        Dim ta As New DocumentosDSTableAdapters.AnexosConvenioTableAdapter
        Dim t As New DocumentosDS.AnexosConvenioDataTable
        Dim r As DocumentosDS.AnexosConvenioRow
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        Dim Archivo As String = "NOTIFICACION_PROXIMA_VENCER" & Anexo.Replace("/", "")
        Dim Doc As String = "C:\Contratos\" & Archivo & ".docx"
        Dim Doc2 As String = "SEG\" & Archivo & ".pdf"
        FileCopy(My.Settings.RootDoc & "SEG\NOTIFICACION_PROXIMA_VENCER.docx", Doc)

        Documento = MSWord.Documents.Open(Doc)
        Documento.Bookmarks.Item("Cliente").Range.Text = Cliente.Trim
        Documento.Bookmarks.Item("Anexo").Range.Text = Anexo.Trim
        Documento.Bookmarks.Item("Serie").Range.Text = Serie.Trim
        Documento.Bookmarks.Item("TipoCredito").Range.Text = TipoCredito.Trim
        Documento.Bookmarks.Item("FechaVenc").Range.Text = FechaVecn.ToShortDateString
        Documento.Bookmarks.Item("Fecha").Range.Text = Date.Now.ToString("d \de MMMM \del yyyy")
        Documento.Bookmarks.Item("Usuario").Range.Text = UsuarioGlobalNombre
        Documento.SaveAs(My.Settings.RutaTMP & Doc2, Word.WdSaveFormat.wdFormatPDF)
        MSWord.Documents.Close()
        MSWord.Application.Quit()
        Return "SEG\" & Archivo & ".pdf"
    End Function

    Public Function AVISO_TERMINACIÓN_CONTRATO(Cliente As String, Serie As String, FechaVecn As Date, TipoCredito As String, Anexo As String) As String
        Dim ta As New DocumentosDSTableAdapters.AnexosConvenioTableAdapter
        Dim t As New DocumentosDS.AnexosConvenioDataTable
        Dim r As DocumentosDS.AnexosConvenioRow
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        Dim Archivo As String = "AVISO_TERMINACIÓN_CONTRATO" & Anexo.Replace("/", "")
        Dim Doc As String = "C:\Contratos\" & Archivo & ".docx"
        Dim Doc2 As String = "SEG\" & Archivo & ".pdf"
        FileCopy(My.Settings.RootDoc & "SEG\AVISO_TERMINACIÓN_CONTRATO.docx", Doc)

        Documento = MSWord.Documents.Open(Doc)
        Documento.Bookmarks.Item("Cliente").Range.Text = Cliente.Trim
        Documento.Bookmarks.Item("Anexo").Range.Text = Anexo.Trim
        'Documento.Bookmarks.Item("Serie").Range.Text = Serie.Trim
        Documento.Bookmarks.Item("TipoCredito").Range.Text = TipoCredito.Trim
        Documento.Bookmarks.Item("FechaVenc").Range.Text = FechaVecn.ToShortDateString
        Documento.Bookmarks.Item("Fecha").Range.Text = Date.Now.ToString("d \de MMMM \del yyyy")
        Documento.Bookmarks.Item("Usuario").Range.Text = UsuarioGlobalNombre
        Documento.SaveAs(My.Settings.RutaTMP & Doc2, Word.WdSaveFormat.wdFormatPDF)
        MSWord.Documents.Close()
        MSWord.Application.Quit()
        Return "SEG\" & Archivo & ".pdf"
    End Function

    Public Function NOTIFICACION_RENOVACION_POLIZA(Cliente As String, Serie As String, FechaVecn As Date, TipoCredito As String, Anexo As String) As String
        Dim ta As New DocumentosDSTableAdapters.AnexosConvenioTableAdapter
        Dim t As New DocumentosDS.AnexosConvenioDataTable
        Dim r As DocumentosDS.AnexosConvenioRow
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document

        Dim Archivo As String = "NOTIFICACION_RENOVACION_POLIZA" & Anexo.Replace("/", "")
        Dim Doc As String = "C:\Contratos\" & Archivo & ".docx"
        Dim Doc2 As String = "SEG\" & Archivo & ".pdf"
        FileCopy(My.Settings.RootDoc & "SEG\NOTIFICACION_RENOVACION_POLIZA.docx", Doc)

        Documento = MSWord.Documents.Open(Doc)
        Documento.Bookmarks.Item("Cliente").Range.Text = Cliente.Trim
        Documento.Bookmarks.Item("Anexo").Range.Text = Anexo.Trim
        'Documento.Bookmarks.Item("Serie").Range.Text = Serie.Trim
        Documento.Bookmarks.Item("TipoCredito").Range.Text = TipoCredito.Trim
        'Documento.Bookmarks.Item("FechaVenc").Range.Text = FechaVecn.ToShortDateString
        Documento.Bookmarks.Item("Fecha").Range.Text = Date.Now.ToString("d \de MMMM \del yyyy")
        Documento.Bookmarks.Item("Usuario").Range.Text = UsuarioGlobalNombre
        Documento.SaveAs(My.Settings.RutaTMP & Doc2, Word.WdSaveFormat.wdFormatPDF)
        MSWord.Documents.Close()
        MSWord.Application.Quit()
        Return "SEG\" & Archivo & ".pdf"
    End Function

End Module
