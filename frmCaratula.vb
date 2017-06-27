Option Explicit On 

Imports System.Data.SqlClient

Public Class frmCaratula
    Inherits System.Windows.Forms.Form
    Dim dsAg As New DataSet()
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal dsAgil As DataSet)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        dsAg = dsAgil

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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 56)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1008, 640)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'frmCaratula
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1024, 702)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.CrystalReportViewer1})
        Me.Name = "frmCaratula"
        Me.Text = "Car�tula de Resoluci�n de Cr�dito"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmPideCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As SqlConnection = New SqlConnection(strConn)
        Dim dsAgil As New DataSet()
        Dim newrptCaratula As New rptCaratula()

        ' Declaraci�n de variables de datos

        Dim nTerm As Integer
        Dim nActi As Integer

        'Descomentar para cuando requiera modificarse la informaci�n contenida en el Dataset
        'dsAgil.ReadXml("C:\Schema12.xml", XmlReadMode.ReadSchema)
     
        newrptCaratula.SetDataSource(dsAg)
        CrystalReportViewer1.ReportSource = newrptCaratula
        CrystalReportViewer1.Visible = True

    End Sub

End Class
