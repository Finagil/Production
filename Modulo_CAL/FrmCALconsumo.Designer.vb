<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCALconsumo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CalificacionDS = New Agil.CalificacionDS()
        Me.CmbDB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.CalificacionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 37)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1008, 601)
        Me.CrystalReportViewer1.TabIndex = 4
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'CalificacionDS
        '
        Me.CalificacionDS.DataSetName = "CalificacionDS"
        Me.CalificacionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbDB
        '
        Me.CmbDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDB.FormattingEnabled = True
        Me.CmbDB.Location = New System.Drawing.Point(50, 10)
        Me.CmbDB.Name = "CmbDB"
        Me.CmbDB.Size = New System.Drawing.Size(121, 21)
        Me.CmbDB.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Mes"
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(177, 8)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(104, 23)
        Me.btnProcesar.TabIndex = 38
        Me.btnProcesar.Text = "Procesar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(287, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Genera Layout"
        '
        'FrmCALconsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 655)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmbDB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FrmCALconsumo"
        Me.Text = "Calificacion de la Cartera de Consumo"
        CType(Me.CalificacionDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CalificacionDS As Agil.CalificacionDS
    Friend WithEvents CmbDB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnProcesar As Button
    Friend WithEvents Button1 As Button
End Class
