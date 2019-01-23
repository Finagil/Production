Option Explicit On 

Imports System.Data.SqlClient

Public Class frmTablaEquipo
    Inherits System.Windows.Forms.Form
    Dim cAnexo As String
    Dim Tipar As String

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal cAnexo As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.Text = "Tabla del Equipo Contrato " & cAnexo
        txtAnexo.Text = cAnexo
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
    Friend WithEvents txtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents CmbHist As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtAnexo = New System.Windows.Forms.TextBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CmbHist = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAnexo
        '
        Me.txtAnexo.Location = New System.Drawing.Point(903, 8)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.Size = New System.Drawing.Size(32, 20)
        Me.txtAnexo.TabIndex = 1
        Me.txtAnexo.Visible = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 32)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1008, 664)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'CmbHist
        '
        Me.CmbHist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbHist.FormattingEnabled = True
        Me.CmbHist.Location = New System.Drawing.Point(75, 5)
        Me.CmbHist.Name = "CmbHist"
        Me.CmbHist.Size = New System.Drawing.Size(194, 21)
        Me.CmbHist.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Histórico"
        '
        'frmTablaEquipo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1022, 700)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbHist)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.txtAnexo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmTablaEquipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabla del Equipo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmTablaEquipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)

        Dim Hist As New ProductionDataSetTableAdapters.EdoctavHistoriaTableAdapter
        Dim NumTablas As Integer = Hist.ScalarNumTabla(cAnexo)
        Tipar = Hist.SacaTipar(cAnexo)
        If NumTablas = 0 Then
            HistoriaEdoCtaV(cAnexo) 'ESTA SIRVE PARA RESPALDAR LA HISTORIA DEL EdoCtaV
            NumTablas = Hist.ScalarNumTabla(cAnexo)
        End If

        For x As Integer = 1 To NumTablas
            CmbHist.Items.Add("Tabla " & x)
        Next
        If Tipar = "B" And (UsuarioGlobal = "mleal" Or
                            UsuarioGlobal = "epineda" Or
                            UsuarioGlobal = "vcruz" Or
                            UsuarioGlobal = "desarrollo") Then
            CmbHist.Items.Add("Tabla Costo")
        End If
        CmbHist.Items.Add("Tabla Actual")
        CmbHist.SelectedIndex = CmbHist.Items.Count - 1
    End Sub

    Sub CargaTabla()
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim dsAgil As New DataSet()
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daTablaEquipo As New SqlDataAdapter(cm1)
        Dim daAnexo As New SqlDataAdapter(cm2)
        Dim drRegistro As DataRow
        Dim drAnexo As DataRow
        Dim TaConsultas As New ConsultasDSTableAdapters.TablaEquipo1TableAdapter
        Dim DSAgil2 As New ConsultasDS
        ' Declaración de variables de Crystal Reports

        Dim cReportTitle As String
        Dim cTipta As String
        Dim cTipar As String
        Dim cLeyenda As String
        Dim nRtasd As Integer
        Dim nImprd As Decimal
        Dim newrptTablaEquipo As New rptTablaEquipo()
        Dim newrptTablaEqdepo As New rptTablaEquipodep()
        Dim newrptTablaRefacc As New rptTablaRefacc()
        Dim newrptTablaPuro As New rptTablaPuro()
        Dim newrptTablaFull As New rptTablaFull
        Dim newrptTablaFullCosto As New rptTablaFullCosto



        ' Declaración de variables de datos
        ' El siguiente Stored Procedure trae todos los atributos de la tabla Edoctav,
        ' para un anexo dado
        If CmbHist.Text = "Tabla Actual" Or CmbHist.Text = "Tabla Costo" Then
            With cm1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "TablaEquipo1"
                .Connection = cnAgil
                .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                .Parameters(0).Value = cAnexo
            End With
        Else
            With cm1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "TablaEquipo1Hist"
                .Connection = cnAgil
                .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                .Parameters.Add("@Num", SqlDbType.Int)
                .Parameters(0).Value = cAnexo
                .Parameters(1).Value = CInt(Mid(CmbHist.Text, 6, 10))
            End With
        End If
        

        ' El siguiente Stored Procedure trae todos los atributos de la tabla Clientes,
        ' para un cliente dado.

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DatosCon1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión
        If Tipar = "B" Then
            TaConsultas.Fill(DSAgil2.TablaEquipo1, cAnexo)
        End If
        daTablaEquipo.Fill(dsAgil, "Edoctav")
        daAnexo.Fill(dsAgil, "Anexo")
        drRegistro = dsAgil.Tables("Edoctav").Rows(0)
        cTipta = drRegistro("Tipta")
        drAnexo = dsAgil.Tables("Anexo").Rows(0)
        nRtasd = drAnexo("Rtasd")
        nImprd = drAnexo("Imprd")
        cTipar = drAnexo("Tipar")

        ' Descomentar la siguiente línea cuando necesitemos modificar el reporte rptTablaEquipo
        'dsAgil.WriteXml("C:\Schema5.xml", XmlWriteMode.WriteSchema)


        If cTipta = "7" Then
            cLeyenda = "Este documento no tiene ninguna validez legal ya que es sólo hipotética, "
            cLeyenda = cLeyenda & " ejemplificativa e ilustrativa, toda vez que para la elaboración de esta tabla"
            cLeyenda = cLeyenda & " se tomó como base los meses con 30 días, por lo que puede haber variación"
            cLeyenda = cLeyenda & " de acuerdo al número real de días que tenga cada mes."
        Else
            cLeyenda = "Este documento no tiene ninguna validez legal ya que es sólo hipotética, "
            cLeyenda = cLeyenda & "ejemplificativa e ilustrativa, por ser imposible conocer la variación de las "
            cLeyenda = cLeyenda & "tasas en el futuro, en consecuencia no implica obligación alguna para "
            cLeyenda = cLeyenda & "FINAGIL SA DE CV SOFOM ENR."
        End If

        If cTipar = "F" Then

            cReportTitle = Trim(drRegistro("Descr")) & Chr(13) & Chr(10) & "Arrendamiento Financiero No. " & txtAnexo.Text

            'If nRtasd = 0 And nImprd > 0 Then
            '    ' Tabla de amortización con Bonificación por Depósito en Garantía
            '    newrptTablaEqdepo.SummaryInfo.ReportTitle = cReportTitle
            '    newrptTablaEqdepo.SummaryInfo.ReportComments = cLeyenda
            '    newrptTablaEqdepo.SetDataSource(dsAgil)
            '    CrystalReportViewer1.ReportSource = newrptTablaEqdepo
            'Else
            ' Tabla de amortización sin Bonificación
            newrptTablaEquipo.SummaryInfo.ReportTitle = cReportTitle
            newrptTablaEquipo.SummaryInfo.ReportComments = cLeyenda
            newrptTablaEquipo.SetDataSource(dsAgil)
            CrystalReportViewer1.ReportSource = newrptTablaEquipo
            'End If
        ElseIf cTipar = "P" Then
            cReportTitle = Trim(drRegistro("Descr")) & Chr(13) & Chr(10) & "Arrendamiento Puro No. " & txtAnexo.Text
            newrptTablaPuro.SummaryInfo.ReportTitle = cReportTitle
            newrptTablaPuro.SummaryInfo.ReportComments = cLeyenda
            newrptTablaPuro.SetDataSource(dsAgil)
            CrystalReportViewer1.ReportSource = newrptTablaPuro
        ElseIf cTipar = "R" Then
            cReportTitle = Trim(drRegistro("Descr")) & Chr(13) & Chr(10) & "Crédito Refaccionario No. " & txtAnexo.Text
            newrptTablaRefacc.SummaryInfo.ReportTitle = cReportTitle
            newrptTablaRefacc.SummaryInfo.ReportComments = cLeyenda
            newrptTablaRefacc.SetDataSource(dsAgil)
            CrystalReportViewer1.ReportSource = newrptTablaRefacc
        ElseIf cTipar = "S" Then
            cReportTitle = Trim(drRegistro("Descr")) & Chr(13) & Chr(10) & "Crédito Simple No. " & txtAnexo.Text
            newrptTablaRefacc.SummaryInfo.ReportTitle = cReportTitle
            newrptTablaRefacc.SummaryInfo.ReportComments = cLeyenda
            newrptTablaRefacc.SetDataSource(dsAgil)
            CrystalReportViewer1.ReportSource = newrptTablaRefacc
        ElseIf cTipar = "L" Then
            cReportTitle = Trim(drRegistro("Descr")) & Chr(13) & Chr(10) & "Crédito de Liquidez Inmediata No. " & txtAnexo.Text
            newrptTablaRefacc.SummaryInfo.ReportTitle = cReportTitle
            newrptTablaRefacc.SummaryInfo.ReportComments = cLeyenda
            newrptTablaRefacc.SetDataSource(dsAgil)
            CrystalReportViewer1.ReportSource = newrptTablaRefacc
        ElseIf cTipar = "B" Then
            If CmbHist.Text = "Tabla Costo" Then
                cReportTitle = Trim(drRegistro("Descr")) & Chr(13) & Chr(10) & "Full Service No. " & txtAnexo.Text
                newrptTablaFullCosto.SummaryInfo.ReportTitle = cReportTitle
                newrptTablaFullCosto.SummaryInfo.ReportComments = cLeyenda
                newrptTablaFullCosto.SetDataSource(DSAgil2)
                CrystalReportViewer1.ReportSource = newrptTablaFullCosto
            Else
                cReportTitle = Trim(drRegistro("Descr")) & Chr(13) & Chr(10) & "Full Service No. " & txtAnexo.Text
                newrptTablaFull.SummaryInfo.ReportTitle = cReportTitle
                newrptTablaFull.SummaryInfo.ReportComments = cLeyenda
                newrptTablaFull.SetDataSource(DSAgil2)
                CrystalReportViewer1.ReportSource = newrptTablaFull
            End If

        End If

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
    End Sub

    Private Sub CmbHist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbHist.SelectedIndexChanged
        If CmbHist.SelectedIndex >= 0 Then
            CargaTabla()
        End If
    End Sub
End Class
