Imports Word = Microsoft.Office.Interop.Word
Module DOC_Pld
    Public Sub CreaDocumento(ByVal Anexo As String, Optional ByVal Ciclo As String = "")
        If Ciclo = "" Then
            Dim ta As New DocumentosDSTableAdapters.PLD_DatosTableAdapter
            Dim t As New DocumentosDS.PLD_DatosDataTable
            Dim r As DocumentosDS.PLD_DatosRow
            ta.FillAcreditado(t, Anexo)
            If (t.Rows.Count > 0) Then
                For Each r In t.Rows
                    DocPLD_doc(r.Acreditado, 0, r.Representante, Anexo, r.Tipo, r.Representante, r.Lugar, (r.Fechacon.ToString("yyyyMMdd")), "F")
                Next
            End If
            ta.FillAvales(t, Anexo)
            If (t.Rows.Count > 0) Then
                For Each r In t.Rows
                    DocPLD_doc(r.Acreditado, 1, r.Representante, Anexo, r.Tipo, r.Representante, r.Lugar, (r.Fechacon.ToString("yyyyMMdd")), r.Tipo)
                Next
            End If
        Else
            Dim ta As New DocumentosDSTableAdapters.PLD_datosAVITableAdapter
            Dim t As New DocumentosDS.PLD_datosAVIDataTable
            Dim r As DocumentosDS.PLD_datosAVIRow
            Dim Acreditado As String = ""
            ta.FillAcreditado(t, Anexo, Ciclo)
            If (t.Rows.Count > 0) Then
                For Each r In t.Rows
                    DocPLD_doc(r.Acreditado, 0, r.Representante, Anexo, r.Tipo, r.Representante, r.Lugar, (r.FechaCon.ToString("yyyyMMdd")), "F")
                    Acreditado = r.Acreditado
                Next
            End If
            ta.FillAvales(t, Anexo, Ciclo)
            If (t.Rows.Count > 0) Then
                For Each r In t.Rows
                    DocPLD_doc(r.Acreditado, 1, r.Representante, Anexo, r.Tipo, r.Representante, r.Lugar, (r.FechaCon.ToString("yyyyMMdd")), r.Tipo)
                    If r.Tipo = "M" Then
                        F3_AVAL_PM(r.Acreditado, "aval/obligado solidario", Acreditado, (r.FechaCon.ToString("yyyyMMdd")), Anexo, r.Lugar, r.Representante)
                    Else
                        F3_AVAL_PF(r.Acreditado, "aval/obligado solidario", Acreditado, (r.FechaCon.ToString("yyyyMMdd")), Anexo, r.Lugar)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub DocPLD_doc(
    ByVal cName As String,
    ByVal cDato As Integer,
    ByVal cRepaval As String,
    ByVal cAnexo As String,
    ByVal cTipoCli As String,
    ByVal cRepresentante As String,
    ByVal cLugar As String,
    ByVal cFechacon As String,
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
                oRuta = "F:PLD\PLD_ClientePM.doc"
            End If
        Else
            If cTipoCli = "M" Then
                If cTipoAval <> "M" Then
                    oRuta = "F:\PLD\PLD_F5_AvalPF.doc"
                Else
                    oRuta = "F:PLD\PLD_F5_AvalPM.doc"
                End If
            Else
                oRuta = "F:\PLD\PLD_F5_AvalPF.doc"
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
        Dim Doc As String = "C:\Contratos\PLD_F3_PF_Aval_" & Aval & "-" & Mid(Personalidad, 1, 3) & ".doc"
        FileCopy("F:\PLD\PLD_F3_aval_PF.doc", Doc)

        Documento = MSWord.Documents.Open(Doc)
        Documento.Bookmarks.Item("Fecha").Range.Text = Mes(Fecha.Trim).ToLower
        Documento.Bookmarks.Item("Lugar").Range.Text = lugar.Trim
        Documento.Bookmarks.Item("NombreAval").Range.Text = Aval.Trim
        Documento.Bookmarks.Item("NombreAval2").Range.Text = Aval.Trim
        Documento.Bookmarks.Item("NombreCliente").Range.Text = Cliente.Trim
        Documento.Bookmarks.Item("Personalidad1").Range.Text = Personalidad.Trim
        Documento.Bookmarks.Item("Personalidad2").Range.Text = Personalidad.Trim
        'Documento.Bookmarks.Item("Personalidad3").Range.Text = Personalidad.Trim

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
        Documento.Bookmarks.Item("Fecha").Range.Text = Mes(Fecha.Trim).ToLower
        Documento.Bookmarks.Item("Lugar").Range.Text = lugar.Trim
        Documento.Bookmarks.Item("Aval").Range.Text = Aval.Trim
        Documento.Bookmarks.Item("Aval1").Range.Text = Aval.Trim
        Documento.Bookmarks.Item("Representante").Range.Text = Representante.Trim
        Documento.Bookmarks.Item("Representante1").Range.Text = Representante.Trim
        Documento.Bookmarks.Item("Cliente").Range.Text = Cliente.Trim
        Documento.Bookmarks.Item("Personalidad2").Range.Text = Personalidad.Trim
        Documento.Bookmarks.Item("Personalidad3").Range.Text = Personalidad.Trim

        Documento.Protect(Word.WdProtectionType.wdAllowOnlyReading, False, "FinagilSofmomENR", False, False)
        Documento.Save()
        MSWord.Documents.Close()
        MSWord.Application.Quit()
        Process.Start(Doc)


    End Sub

End Module
