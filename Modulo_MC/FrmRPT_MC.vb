Imports System.IO
Public Class FrmRPT_MC
    Public RPTTit As String
    Public anexo_id As String = ""
    Public NombreCli As String = ""
    Public IDCambio As Decimal
    Public NombreSUB As String = ""


    Private Sub FrmRPT_MC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Reporte de " & RPTTit

        Select Case RPTTit
            Case "Resguardo"
                Dim ta As New MesaControlDSTableAdapters.Vw_resguardo_anexo_docTableAdapter
                Dim Dt_resguardos As New MesaControlDS
                ta.Fill(Dt_resguardos.Vw_resguardo_anexo_doc, anexo_id)
                Dim rpt As New rpt_resguardos()
                rpt.SetDataSource(Dt_resguardos)
                Crv.ReportSource = rpt
            Case "Hoja de Cambios"
                BtnMail.Visible = True
                Dim ta As New MesaControlDSTableAdapters.Vw_MC_cambios_condicionesTableAdapter
                Dim MC As New MesaControlDS
                ta.Fill(MC.Vw_MC_cambios_condiciones, IDCambio)
                Dim rpt As New rpt_cambios()
                rpt.SetDataSource(MC)
                rpt.SetParameterValue("NombreSub", NombreSUB.ToUpper)
                Crv.ReportSource = rpt
        End Select

    End Sub

    Private Sub BtnMail_Click(sender As Object, e As EventArgs) Handles BtnMail.Click
        Cursor.Current = Cursors.WaitCursor
        Dim Archivo As String = "c:\Contratos\HolaDeCambios_" & anexo_id & ".pdf"
        Dim Nombre As String = "HolaDeCambios_" & anexo_id & ".pdf"

        Dim t1 As New MesaControlDSTableAdapters.Vw_MC_cambios_condicionesTableAdapter
        Dim MC As New MesaControlDS
        t1.Fill(MC.Vw_MC_cambios_condiciones, IDCambio)
        Dim rpt As New rpt_cambios()
        rpt.SetDataSource(MC)
        Try
            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Archivo)
            File.Copy(Archivo, My.Settings.RutaTMP & Nombre, True)
            MandaCorreoPROMO(anexo_id, "Hoja de Cambios Anexo " & NombreCli, "Hoja de Cambios Anexo " & NombreCli, True, True, Nombre)
            MessageBox.Show("Mensaje Enviado", "Envio de Correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Cursor.Current = Cursors.Default
    End Sub
End Class