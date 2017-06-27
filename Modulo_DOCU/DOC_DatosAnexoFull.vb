
Module DOC_DatosAnexoFull

    Public Sub GeneraDoc(ByVal Anexo As String)
        Cursor.Current = Cursors.WaitCursor
        Dim Archivo As String = "c:\Contratos\Datos" & Anexo & ".Doc"
        Dim ArchivoII As String = "c:\Contratos\DatosRes" & Anexo & ".Doc"
        Dim reporte As New RptDatosAnexoFull
        Dim reporteII As New RptDatosAnexoFull_LM
        Dim DS As New DocumentosDS
        Dim T1 As New DocumentosDSTableAdapters.DatosFullTableAdapter
        Dim T2 As New DocumentosDSTableAdapters.ServiciosFullTableAdapter

        T1.Fill(DS.DatosFull, Anexo)
        T2.Fill(DS.ServiciosFull, Anexo)

        reporte.SetDataSource(DS)
        reporte.Subreports.Item(0).SetDataSource(DS)

        reporteII.SetDataSource(DS)
        reporteII.Subreports.Item(0).SetDataSource(DS)

        Try
            reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, Archivo)
            reporteII.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, ArchivoII)
            Process.Start(Archivo)
            Process.Start(ArchivoII)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Cursor.Current = Cursors.Default
    End Sub



End Module
