Option Explicit On 

Imports System.Data.SqlClient

Public Class frmRepoIvaPP

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
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpProceso1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dtpProceso2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpProceso1 = New System.Windows.Forms.DateTimePicker
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnSalir = New System.Windows.Forms.Button
        Me.dtpProceso2 = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(370, 12)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(80, 24)
        Me.btnProcesar.TabIndex = 30
        Me.btnProcesar.Text = "Procesar"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Fecha de Proceso"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpProceso1
        '
        Me.dtpProceso1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProceso1.Location = New System.Drawing.Point(144, 14)
        Me.dtpProceso1.Name = "dtpProceso1"
        Me.dtpProceso1.Size = New System.Drawing.Size(88, 20)
        Me.dtpProceso1.TabIndex = 28
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 56)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1008, 640)
        Me.CrystalReportViewer1.TabIndex = 31
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(474, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 24)
        Me.btnSalir.TabIndex = 32
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dtpProceso2
        '
        Me.dtpProceso2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProceso2.Location = New System.Drawing.Point(256, 14)
        Me.dtpProceso2.Name = "dtpProceso2"
        Me.dtpProceso2.Size = New System.Drawing.Size(88, 20)
        Me.dtpProceso2.TabIndex = 29
        '
        'frmIntIvaPP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1024, 702)
        Me.Controls.Add(Me.dtpProceso2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpProceso1)
        Me.Name = "frmIntIvaPP"
        Me.Text = "Integración de IVA por pagar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daHistoria As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet()
        Dim drHistoria As DataRow
        Dim dtReporte As New DataTable("Reporte")
        Dim drReporte As DataRow

        ' Declaración de variables de datos

        Dim cConcepto As String
        Dim Fecha1 As String
        Dim Fecha2 As String
        Dim cLetra As String
        Dim nImp0001 As Decimal
        Dim nImp0003 As Decimal
        Dim nImp0004 As Decimal
        Dim nImp0005 As Decimal
        Dim nImp0006 As Decimal
        Dim nImp0007 As Decimal
        Dim nImp0008 As Decimal
        Dim nImp0010 As Decimal
        Dim nImp0090 As Decimal

        ' Declaración de variables de Crystal Reports

        Dim newrptIntIvaPP As New rptIvaPP()

        Fecha1 = DTOC(dtpProceso1.Value)
        Fecha2 = DTOC(dtpProceso2.Value)

        ' Lo primero que hago es crear la tabla Reporte que será la base del reporte

        dtReporte.Columns.Add("Factura", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("Fecha", Type.GetType("System.String"))
        dtReporte.Columns.Add("Anexo", Type.GetType("System.String"))
        dtReporte.Columns.Add("Concepto", Type.GetType("System.String"))
        dtReporte.Columns.Add("c0001", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("c0003", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("c0004", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("c0005", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("c0006", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("c0007", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("c0008", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("c0010", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("c0090", Type.GetType("System.Decimal"))

        ' El siguiente Stored Procedure me trae todos los conceptos de IVA
        ' que aparezcan el la historia de pagos para un mes en específico

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_IntIvaPP1"
            .Connection = cnAgil
            .Parameters.Add("@FechaI", SqlDbType.NVarChar)
            .Parameters(0).Value = Fecha1
            'Se agrego para unsan rango de fechas
            .Parameters.Add("@FechaF", SqlDbType.NVarChar)
            .Parameters(1).Value = Fecha2
        End With

        Try

            ' Llenar el DataSet lo cual abre y cierra la conexión

            daHistoria.Fill(dsAgil, "Historia")

            For Each drHistoria In dsAgil.Tables("Historia").Rows

                nImp0001 = 0
                nImp0003 = 0
                nImp0004 = 0
                nImp0005 = 0
                nImp0006 = 0
                nImp0007 = 0
                nImp0008 = 0
                nImp0010 = 0
                nImp0090 = 0

                drReporte = dtReporte.NewRow

                drReporte("Factura") = drHistoria("Numero")
                drReporte("Fecha") = drHistoria("Fecha")
                drReporte("Anexo") = drHistoria("Anexo")
                cLetra = drHistoria("Letra")
                cConcepto = Trim(drHistoria("Observa1"))
                cLetra = drHistoria("Letra")
                drReporte("Concepto") = cConcepto
                Select Case cConcepto
                    Case "IVA CAPITAL", "IVA DE LA AMORTIZACION", "IVA DEL CAPITAL EQUIPO", "IVA DEL SALDO INSOLUTO"
                        nImp0001 = drHistoria("Importe")
                    Case "IVA INTERESES"
                        If cLetra <> "888" Then
                            nImp0003 = drHistoria("Importe")
                        Else
                            nImp0090 = drHistoria("Importe")
                        End If
                    Case "IVA RENTA EN DEPOSITO", "IVA EN DEPOSITO"
                        nImp0004 = drHistoria("Importe")
                    Case "IVA DE LA COMISION", "IVA DE COMISION POR PREPAGO", "IVA COMISION POR ADELANTO"
                        nImp0005 = drHistoria("Importe")
                    Case "IVA GASTOS RATIFICACION"
                        nImp0006 = drHistoria("Importe")
                    Case "IVA MORATORIOS"
                        nImp0007 = drHistoria("Importe")
                    Case "IVA OPCION DE COMPRA"
                        nImp0008 = drHistoria("Importe")
                    Case "IVA DEL DEPOSITO", "APLICACION DEPOSITO vs IVA CAPITAL"
                        nImp0010 = drHistoria("Importe")
                    Case "IVA DE INTERESES POR PREPAGO", "IVA INTERES OTROS ADEUDOS"
                        nImp0090 = drHistoria("Importe")
                End Select
                drReporte("c0001") = nImp0001
                drReporte("c0003") = nImp0003
                drReporte("c0004") = nImp0004
                drReporte("c0005") = nImp0005
                drReporte("c0006") = nImp0006
                drReporte("c0007") = nImp0007
                drReporte("c0008") = nImp0008
                drReporte("c0010") = nImp0010
                drReporte("c0090") = nImp0090
                dtReporte.Rows.Add(drReporte)
            Next

            dsAgil.Tables.Remove("Historia")
            dsAgil.Tables.Add(dtReporte)

            ' Descomentar la siguiente línea en caso de que se deseara modificar el reporte rptIntIvaPP
            ' dsAgil.WriteXml("C:\Schema18.xml", XmlWriteMode.WriteSchema)
            newrptIntIvaPP.SummaryInfo.ReportTitle = "Reporte Mensual de IVA"
            newrptIntIvaPP.SetDataSource(dsAgil)
            CrystalReportViewer1.ReportSource = newrptIntIvaPP

        Catch eException As Exception

            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class
