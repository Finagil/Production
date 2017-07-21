Imports Word = Microsoft.Office.Interop.Word
Module DOC_Pld

    Public Sub CreaDocumentoF3_aval(ByVal Anexo As String, Optional ByVal Ciclo As String = "")
        Dim ta As New DocumentosDSTableAdapters.PLD_datosTableAdapter
        Dim t As New DocumentosDS.PLD_datosDataTable
        Dim r As DocumentosDS.PLD_datosRow
        ta.FillAvales(t, Anexo)
        If (t.Rows.Count > 0) Then
            For Each r In t.Rows
                F3_AVAL_PF(r.Acreditado.Trim, r.Personalidad.Trim, r.Cliente.Trim, Mes(r.Fechacon.ToString("yyyyMMdd")), Anexo, "")
            Next
        End If
    End Sub

    Public Sub CreaDocumento(ByVal Anexo As String, Optional ByVal Ciclo As String = "")
        If Ciclo = "" Then
            Dim ta As New DocumentosDSTableAdapters.PLD_datosTableAdapter
            Dim t As New DocumentosDS.PLD_datosDataTable
            Dim r As DocumentosDS.PLD_datosRow
            ta.FillAcreditado(t, Anexo)
            If (t.Rows.Count > 0) Then
                For Each r In t.Rows
                    DocPLD(r.Acreditado, 0, r.Representante, Anexo, r.Tipo, r.Representante, r.Lugar, r.Fechacon.ToString("yyyyMMdd"), "F")
                Next
            End If
            ta.FillAvales(t, Anexo)
            If (t.Rows.Count > 0) Then
                For Each r In t.Rows
                    DocPLD(r.Acreditado, 1, r.Representante, Anexo, r.Tipo, r.Representante, r.Lugar, r.Fechacon.ToString("yyyyMMdd"), r.Tipo)
                Next
            End If
        Else
            Dim ta As New DocumentosDSTableAdapters.PLD_datosAVITableAdapter
            Dim t As New DocumentosDS.PLD_datosAVIDataTable
            Dim r As DocumentosDS.PLD_datosAVIRow
            ta.FillAcreditado(t, Anexo, Ciclo)
            If (t.Rows.Count > 0) Then
                For Each r In t.Rows
                    DocPLD(r.Acreditado, 0, r.Representante, Anexo, r.Tipo, r.Representante, r.Lugar, r.FechaCon.ToString("yyyyMMdd"), "F")

                Next
            End If
            ta.FillAvales(t, Anexo, Ciclo)
            If (t.Rows.Count > 0) Then
                For Each r In t.Rows
                    DocPLD(r.Acreditado, 1, r.Representante, Anexo, r.Tipo, r.Representante, r.Lugar, r.FechaCon.ToString("yyyyMMdd"), r.Tipo)
                Next
            End If
        End If



    End Sub

    Private Sub DocPLD( _
    ByVal cName As String, _
    ByVal cDato As Integer, _
    ByVal cRepaval As String, _
    ByVal cAnexo As String, _
    ByVal cTipoCli As String, _
    ByVal cRepresentante As String, _
    ByVal cLugar As String, _
    ByVal cFechacon As String, _
    ByVal cTipoAval As String)

        Dim id As String = Date.Now.ToString("_hhmmss_")
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As Object
        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document
        Dim cContrato As String

        If cDato = 0 Then
            If cTipoCli <> "M" Then
                oRuta = "F:\PLD\PLD_ClientePF.doc"
            Else
                oRuta = "F:PLD\PLD_CTE_PM.doc"
            End If
        Else
            If cTipoCli = "M" Then
                If cTipoAval <> "M" Then
                    oRuta = "F:\PLD\PLD_AvalPF_CPM.doc"
                Else
                    oRuta = "F:PLD\PLD_AvalPM.doc"
                End If
            Else
                oRuta = "F:\PLD\PLD_AvalPF.doc"
            End If
        End If
        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantillatR

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        With oWordDoc.Sections(1)
            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
        End With

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            If cFieldText.StartsWith(" MERGEFIELD") Then
                finMerge = cFieldText.IndexOf("\")
                fieldNameLen = cFieldText.Length - finMerge
                cfName = cFieldText.Substring(11, finMerge - 11)
                cfName = cfName.Trim()
                Select Case cfName

                    Case "mRef"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4))
                    Case "mCte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cName)
                    Case "mRepre"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cRepresentante)
                    Case "mRepav"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cRepaval)
                    Case "mLugar"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLugar
                    Case "mFecha"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFechacon).ToLower
                End Select
                oWord.Selection.Fields.Update()
            End If
        Next

        'Guardo el documento

        Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
        Dim oMissing As Object = System.Reflection.Missing.Value

        Dim oSaveAsFile As Object
        Try
            If cDato = 0 Then
                oSaveAsFile = "C:\contratos\" & cName.Trim & "_PLD_CTEPF" & cContrato & id & ".doc"
                oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
            Else
                If cTipoCli = "M" Then
                    If cTipoAval <> "M" Then
                        oSaveAsFile = "C:\contratos\" & cName.Trim & "_PLD_AVALPF_CPM" & cContrato & id & ".doc"
                        oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
                    Else
                        oSaveAsFile = "C:\contratos\" & cName.Trim & "_PLD_AVALPM" & cContrato & id & ".doc"
                        oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
                    End If
                Else
                    oSaveAsFile = "C:\contratos\" & cName.Trim & "_PLD_AVALPF" & cContrato & id & ".doc"
                    oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
                End If
            End If

            oWordDoc.Close()
            oWord.Quit()
            Process.Start(oSaveAsFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oWordDoc.Close(SaveChanges:=False)
            oWord.Quit(SaveChanges:=False)
        End Try
    End Sub


    Public Sub F3_AVAL_PF(Aval As String, Personalidad As String, Cliente As String, Fecha As String, Anexo As String, lugar As String)


        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        Dim Doc As String = "C:\Contratos\PLD_F3_PF_Aval_" & Aval & ".doc"
        FileCopy("F:\PLD\PLD_F3_aval_PF.doc", Doc)

        Documento = MSWord.Documents.Open(Doc)
        Documento.Bookmarks.Item("Fecha").Range.Text = Fecha
        Documento.Bookmarks.Item("Lugar").Range.Text = lugar
        Documento.Bookmarks.Item("NombreAval").Range.Text = Aval
        Documento.Bookmarks.Item("NombreAval2").Range.Text = Aval
        Documento.Bookmarks.Item("NombreCliente").Range.Text = Cliente
        Documento.Bookmarks.Item("Personalidad1").Range.Text = Personalidad
        Documento.Bookmarks.Item("Personalidad2").Range.Text = Personalidad
        Documento.Bookmarks.Item("Personalidad3").Range.Text = Personalidad

        Documento.Protect(Word.WdProtectionType.wdAllowOnlyReading, False, "FinagilSofmomENR", False, False)
        Documento.Save()
        MSWord.Documents.Close()
        MSWord.Application.Quit()
        Process.Start(Doc)


    End Sub

    Public Sub F3_AVAL_PM(Aval As String, Personalidad As String, Cliente As String, Fecha As String, Anexo As String, lugar As String, Representante As String)


        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        Dim Doc As String = "C:\Contratos\PLD_F3_aval_PM_" & Aval & ".doc"
        FileCopy("F:\PLD\PLD_F3_aval_PM.doc", Doc)

        Documento = MSWord.Documents.Open(Doc)
        Documento.Bookmarks.Item("Fecha").Range.Text = Fecha
        Documento.Bookmarks.Item("Lugar").Range.Text = lugar
        Documento.Bookmarks.Item("Aval").Range.Text = Aval
        Documento.Bookmarks.Item("Aval1").Range.Text = Aval
        Documento.Bookmarks.Item("Representante").Range.Text = Representante.Trim
        Documento.Bookmarks.Item("Representante1").Range.Text = Representante.Trim
        Documento.Bookmarks.Item("Cliente").Range.Text = Cliente
        Documento.Bookmarks.Item("Personalidad2").Range.Text = Personalidad
        Documento.Bookmarks.Item("Personalidad3").Range.Text = Personalidad

        Documento.Protect(Word.WdProtectionType.wdAllowOnlyReading, False, "FinagilSofmomENR", False, False)
        Documento.Save()
        MSWord.Documents.Close()
        MSWord.Application.Quit()
        Process.Start(Doc)


    End Sub

End Module
