<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepoSeguros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtpProcesar = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cbBase = New System.Windows.Forms.ComboBox()
        Me.ReportesDS1 = New Agil.ReportesDS()
        CType(Me.ReportesDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpProcesar
        '
        Me.dtpProcesar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProcesar.Location = New System.Drawing.Point(398, 16)
        Me.dtpProcesar.Name = "dtpProcesar"
        Me.dtpProcesar.Size = New System.Drawing.Size(88, 20)
        Me.dtpProcesar.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Selecciona  Año y Mes de la Base a procesar"
        '
        'btnProcesar
        '
        Me.btnProcesar.ForeColor = System.Drawing.Color.Black
        Me.btnProcesar.Location = New System.Drawing.Point(524, 13)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(78, 23)
        Me.btnProcesar.TabIndex = 14
        Me.btnProcesar.Text = "Generar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(671, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 18
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(28, 48)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.SelectionFormula = ""
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1079, 664)
        Me.CrystalReportViewer2.TabIndex = 22
        Me.CrystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer2.ViewTimeSelectionFormula = ""
        '
        'cbBase
        '
        Me.cbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBase.FormattingEnabled = True
        Me.cbBase.Location = New System.Drawing.Point(304, 15)
        Me.cbBase.Name = "cbBase"
        Me.cbBase.Size = New System.Drawing.Size(69, 21)
        Me.cbBase.TabIndex = 23
        '
        'ReportesDS1
        '
        Me.ReportesDS1.DataSetName = "ReportesDS"
        Me.ReportesDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmRepoSeguros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 725)
        Me.Controls.Add(Me.cbBase)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpProcesar)
        Me.Name = "frmRepoSeguros"
        Me.Text = "Reporte de Seguros (Para Aseguradora)"
        CType(Me.ReportesDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpProcesar As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cbBase As System.Windows.Forms.ComboBox
    Friend WithEvents ReportesDS1 As ReportesDS
End Class
