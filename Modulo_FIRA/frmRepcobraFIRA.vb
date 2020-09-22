Option Explicit On 

Imports System.Data.SqlClient

Public Class frmRepcobraFIRA
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnCobranza As System.Windows.Forms.Button
    Friend WithEvents lblReporte As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCobranza = New System.Windows.Forms.Button()
        Me.lblReporte = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCobranza
        '
        Me.btnCobranza.Location = New System.Drawing.Point(210, 14)
        Me.btnCobranza.Name = "btnCobranza"
        Me.btnCobranza.Size = New System.Drawing.Size(80, 24)
        Me.btnCobranza.TabIndex = 25
        Me.btnCobranza.Text = "Procesar"
        '
        'lblReporte
        '
        Me.lblReporte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReporte.Location = New System.Drawing.Point(24, 14)
        Me.lblReporte.Name = "lblReporte"
        Me.lblReporte.Size = New System.Drawing.Size(192, 24)
        Me.lblReporte.TabIndex = 24
        Me.lblReporte.Text = "Selecciona la fecha del Reporte"
        Me.lblReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(16, 56)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(976, 624)
        Me.CrystalReportViewer1.TabIndex = 26
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(296, 14)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 24)
        Me.btnSalir.TabIndex = 27
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmRepcobraFIRA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1008, 702)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.btnCobranza)
        Me.Controls.Add(Me.lblReporte)
        Me.Name = "frmRepcobraFIRA"
        Me.Text = "Reporte de Cobranza FIRA"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Structure Molino
        Public MXL As Decimal
        Public HPI As Decimal
        Public TAM As Decimal
    End Structure

    Private Sub btnCobranza_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCobranza.Click
        Cursor.Current = Cursors.WaitCursor
        Dim FechaProceso As DateTime = Date.Now
        ' Declaración de variables de conexión ADO .NET
        Dim taHist As New FiraDSTableAdapters.HistoriaFIRATableAdapter
        Dim taRptFira As New FiraDSTableAdapters.FIRA_RptCrobranzaFIRATableAdapter
        Dim dtAnexos As New FiraDS.HistoriaFIRADataTable
        Dim drAnexo As FiraDS.HistoriaFIRARow
        Dim drTemporal As DataRow
        Dim dtCobranza As New DataTable("Cobranza")
        Dim cAnexo As String = ""
        Dim nImporteDocumento As Decimal = 0
        Dim nGrupo As Integer
        ' Declaración de variables de Crystal Reports
        Dim newrptRepCobra As New rptRepCobraFira()

        ' Creo una tabla dtCobranza donde almaceno los datos que formarán parte del reporte final
        dtCobranza.Columns.Add("Nombre", Type.GetType("System.String"))
        dtCobranza.Columns.Add("Documento", Type.GetType("System.String"))
        dtCobranza.Columns.Add("Anexo", Type.GetType("System.String"))
        dtCobranza.Columns.Add("Ven", Type.GetType("System.String"))
        dtCobranza.Columns.Add("Concepto", Type.GetType("System.String"))
        dtCobranza.Columns.Add("Cheque", Type.GetType("System.String"))
        dtCobranza.Columns.Add("Depositado en", Type.GetType("System.String"))
        dtCobranza.Columns.Add("Importe", Type.GetType("System.Decimal"))
        dtCobranza.Columns.Add("Orden", Type.GetType("System.Decimal"))
        dtCobranza.Columns.Add("Fondeo", Type.GetType("System.String"))
        dtCobranza.Columns.Add("InstrumentoMonetario", Type.GetType("System.String"))
        dtCobranza.Columns.Add("FechaAplicacion", Type.GetType("System.String"))
        dtCobranza.Columns.Add("FechaPago", Type.GetType("System.DateTime"))

        ' Con este Stored Procedure obtengo todos los movimientos de la cobranza del 
        ' dia que se está solicitando.
        taHist.Fill(dtAnexos)
        nGrupo = 0

        For Each drAnexo In dtAnexos.Rows
            drTemporal = dtCobranza.NewRow()
            If nGrupo = 0 Then
                nGrupo = 1
            ElseIf Mid(drAnexo.Anexo, 1, 5) <> Mid(cAnexo, 1, 5) Then
                nGrupo += 1
            End If

            drTemporal("Nombre") = drAnexo.Descr
            drTemporal("Anexo") = Mid(drAnexo.Anexo, 1, 5) & "/" & Mid(drAnexo.Anexo, 6, 4)
            drTemporal("Ven") = drAnexo.Letra
            drTemporal("Concepto") = drAnexo.Observa1
            drTemporal("Cheque") = drAnexo.Cheque
            drTemporal("Depositado en") = drAnexo("DescBanco")
            drTemporal("Importe") = drAnexo.Importe
            drTemporal("Orden") = nGrupo
            drTemporal("Fondeo") = drAnexo.Fondeo
            drTemporal("InstrumentoMonetario") = drAnexo.InstrumentoMonetario
            drTemporal("FechaPago") = drAnexo.FechaPago
            drTemporal("FechaAplicacion") = drAnexo.Fecha

            nImporteDocumento = taHist.SacaImporteMov(drAnexo.Fecha, drAnexo.Numero)
            Select Case drAnexo.Documento
                Case 1
                    drTemporal("Documento") = "Nota de Cargo " & Str(drAnexo.Numero) & " por $" & Format(nImporteDocumento, "##,##0.00")
                Case 2
                    drTemporal("Documento") = "Recibo " & Str(drAnexo.Numero) & " por $" & Format(nImporteDocumento, "##,##0.00")
                Case 4
                    drTemporal("Documento") = "Cargo Interno " & Str(drAnexo.Numero) & " por $" & Format(nImporteDocumento, "##,##0.00")
                Case 5
                    drTemporal("Documento") = "Abono Interno " & Str(drAnexo.Numero) & " por $" & Format(nImporteDocumento, "##,##0.00")
                Case 6
                    drTemporal("Documento") = "Factura " & drAnexo.Serie & Trim(Str(drAnexo.Numero)) & " por $" & Format(nImporteDocumento, "##,##0.00")
                Case 7
                    drTemporal("Documento") = "Activo Fijo " & Str(drAnexo.Numero) & " por $" & Format(nImporteDocumento, "##,##0.00")
            End Select

            dtCobranza.Rows.Add(drTemporal)
            cAnexo = drAnexo("Anexo")
            taRptFira.Insert(drAnexo.id_historia, UsuarioGlobal, FechaProceso)
        Next

        Dim dsAgil As New DataSet()
        dsAgil.Tables.Add(dtCobranza)

        ' Descomentar la siguiente línea en caso de que deseara modificarse el reporte rptRepCobra
        'dsAgil.WriteXml("D:\Temporal\Schema16.xml", XmlWriteMode.WriteSchema)

        newrptRepCobra.SetDataSource(dsAgil)
        newrptRepCobra.SummaryInfo.ReportComments = "REPORTE DE COBRANZA GENERADO DEL DIA " & Date.Now.ToShortDateString
        CrystalReportViewer1.ReportSource = newrptRepCobra
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
