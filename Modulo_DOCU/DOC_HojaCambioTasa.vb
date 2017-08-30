Imports Word = Microsoft.Office.Interop.Word
Module DOC_HojaCambioTasa
    Sub SacaHojaCambioTasa(cAnexo As String)
        If InStr(cAnexo, "/") > 0 Then
            cAnexo = cAnexo.Substring(0, 5) & cAnexo.Substring(6, 4)
        End If
        Dim MesaControlDS As New MesaControlDS
        Dim tax As New MesaControlDSTableAdapters.HojaTasaTableAdapter
        tax.FillByAnexo(MesaControlDS.HojaTasa, cAnexo)
        If MesaControlDS.HojaTasa.Rows.Count > 0 Then
            Dim r As MesaControlDS.HojaTasaRow = MesaControlDS.HojaTasa.Rows(0)
            If r.AutorizadoRI = False Then
                MessageBox.Show("Falta autorizacion del área de Reiesgos", "Hoja de Cambio de Tasas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If r.AutorizadoDG = False Then
                MessageBox.Show("Falta autorizacion de Dirección General", "Hoja de Cambio de Tasas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim cDetalle As String = ""
            Dim MSWord As New Word.Application
            Dim Documento As Word.Document
            Dim Doc As String = "C:\Contratos\TasaEspecial" & r.Anexo & ".doc"

            Dim ta As New MesaControlDSTableAdapters.ActifijoTableAdapter
            ta.Fill(MesaControlDS.Actifijo, r.Anexo)
            For Each rr As MesaControlDS.ActifijoRow In MesaControlDS.Actifijo
                cDetalle += rr.Detalle & " "
            Next
            Try
                If r.Autoriza = "DG" Or r.Autoriza = "AUTOMATICO" Then
                    FileCopy("F:\Plantillas\TasaEspecial.doc", Doc)
                Else
                    FileCopy("F:\Plantillas\TasaEspecialR.doc", Doc)
                End If

                Documento = MSWord.Documents.Open(Doc)
                Documento.Bookmarks.Item("Anexo").Range.Text = r.AnexoCon
                Documento.Bookmarks.Item("ComentariosPromo").Range.Text = r.ComentarioPromo
                Documento.Bookmarks.Item("ComentariosRiesgos").Range.Text = r.ComentarioRiesgos
                Documento.Bookmarks.Item("ComisionApert").Range.Text = r.Porco & "%"
                Documento.Bookmarks.Item("ComisionDisp").Range.Text = ""
                Documento.Bookmarks.Item("Destino").Range.Text = cDetalle
                Documento.Bookmarks.Item("DG").Range.Text = r.ImpRD.ToString("n2") ' se cambio por que esta alrevez
                Documento.Bookmarks.Item("Fecha").Range.Text = Date.Now.ToLongDateString
                Documento.Bookmarks.Item("FechaImpre").Range.Text = Date.Now.ToShortDateString & " " & Date.Now.ToShortTimeString
                Documento.Bookmarks.Item("FR").Range.Text = r.FondoReserva.ToString("n")
                Documento.Bookmarks.Item("Indicadores").Range.Text = r.Indicadores
                Documento.Bookmarks.Item("MontoFin").Range.Text = r.MontoFin.ToString("n2")
                Documento.Bookmarks.Item("NombreCli").Range.Text = r.Descr
                If r.Tipar = "P" Then
                    Documento.Bookmarks.Item("OC").Range.Text = r.Porop.ToString("n2") & "%"
                Else
                    Documento.Bookmarks.Item("OC").Range.Text = ""
                End If
                Documento.Bookmarks.Item("Penalizacion").Range.Text = r.Taspen.ToString("n2")
                Documento.Bookmarks.Item("Plazo").Range.Text = r.Plazo
                Documento.Bookmarks.Item("producto").Range.Text = r.TipoCredito
                Documento.Bookmarks.Item("Promotor").Range.Text = r.DescPromotor
                If r.Nombre_Sucursal.Trim = "NAVOJOA" Or r.Nombre_Sucursal.Trim = "MEXICALI" Then
                    Documento.Bookmarks.Item("Subdirector").Range.Text = "DAVID OÑATE"
                Else
                    Documento.Bookmarks.Item("Subdirector").Range.Text = "MIGUEL ANGEL LEAL"
                End If
                Documento.Bookmarks.Item("Promotor1").Range.Text = r.DescPromotor
                Documento.Bookmarks.Item("RD").Range.Text = r.RD.ToString("n")
                If r.Tipta = "7" Then
                    Documento.Bookmarks.Item("TasaPol").Range.Text = r.TasaPol.ToString("n2")
                    Documento.Bookmarks.Item("Tasasol").Range.Text = r.TasaSol.ToString("n2")
                Else
                    Documento.Bookmarks.Item("TasaPol").Range.Text = "TIIE + " & r.TasaPol.ToString("n2")
                    Documento.Bookmarks.Item("Tasasol").Range.Text = "TIIE + " & r.TasaSol.ToString("n2")
                End If

                Documento.Bookmarks.Item("Autoriza").Range.Text = r.Autoriza
                Documento.Bookmarks.Item("Fprom").Range.Text = r.FirmaPromo
                Documento.Bookmarks.Item("Fsub").Range.Text = r.FirmaSubPromo
                Documento.Bookmarks.Item("Friesgos").Range.Text = r.FirmaRiesgos
                Documento.Bookmarks.Item("Fdireccion").Range.Text = r.FirmaDireccion


                Documento.Protect(Word.WdProtectionType.wdAllowOnlyReading, False, "FinagilSofmomENR", False, False)
                Documento.Save()
                MSWord.Visible = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try



        Else
            MessageBox.Show("No tiene hoja de cambio de tasa", "Hoja de Cambio de Tasas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Module
