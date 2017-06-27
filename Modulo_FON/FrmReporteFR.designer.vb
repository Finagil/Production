<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteFR
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
        Me.RadioSaldos = New System.Windows.Forms.RadioButton()
        Me.RadioRecuperar = New System.Windows.Forms.RadioButton()
        Me.BtnProcesar = New System.Windows.Forms.Button()
        Me.ReportViewerFondo = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.FondoResarvaDS1 = New Agil.FondoResarvaDS()
        CType(Me.FondoResarvaDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioSaldos
        '
        Me.RadioSaldos.AutoSize = True
        Me.RadioSaldos.Checked = True
        Me.RadioSaldos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioSaldos.Location = New System.Drawing.Point(32, 13)
        Me.RadioSaldos.Name = "RadioSaldos"
        Me.RadioSaldos.Size = New System.Drawing.Size(63, 17)
        Me.RadioSaldos.TabIndex = 0
        Me.RadioSaldos.TabStop = True
        Me.RadioSaldos.Text = "Saldos"
        Me.RadioSaldos.UseVisualStyleBackColor = True
        '
        'RadioRecuperar
        '
        Me.RadioRecuperar.AutoSize = True
        Me.RadioRecuperar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioRecuperar.Location = New System.Drawing.Point(110, 13)
        Me.RadioRecuperar.Name = "RadioRecuperar"
        Me.RadioRecuperar.Size = New System.Drawing.Size(107, 17)
        Me.RadioRecuperar.TabIndex = 1
        Me.RadioRecuperar.Text = "Por Recuperar"
        Me.RadioRecuperar.UseVisualStyleBackColor = True
        '
        'BtnProcesar
        '
        Me.BtnProcesar.Location = New System.Drawing.Point(240, 16)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(81, 26)
        Me.BtnProcesar.TabIndex = 2
        Me.BtnProcesar.Text = "Procesar"
        Me.BtnProcesar.UseVisualStyleBackColor = True
        '
        'ReportViewerFondo
        '
        Me.ReportViewerFondo.ActiveViewIndex = -1
        Me.ReportViewerFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportViewerFondo.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReportViewerFondo.Location = New System.Drawing.Point(12, 13)
        Me.ReportViewerFondo.Name = "ReportViewerFondo"
        Me.ReportViewerFondo.SelectionFormula = ""
        Me.ReportViewerFondo.Size = New System.Drawing.Size(887, 527)
        Me.ReportViewerFondo.TabIndex = 3
        Me.ReportViewerFondo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.ReportViewerFondo.ViewTimeSelectionFormula = ""
        '
        'FondoResarvaDS1
        '
        Me.FondoResarvaDS1.DataSetName = "FondoResarvaDS"
        Me.FondoResarvaDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrmReporteFR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 552)
        Me.Controls.Add(Me.ReportViewerFondo)
        Me.Controls.Add(Me.BtnProcesar)
        Me.Controls.Add(Me.RadioRecuperar)
        Me.Controls.Add(Me.RadioSaldos)
        Me.Name = "FrmReporteFR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes Fondo de Reserva"
        CType(Me.FondoResarvaDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioSaldos As System.Windows.Forms.RadioButton
    Friend WithEvents RadioRecuperar As System.Windows.Forms.RadioButton
    Friend WithEvents BtnProcesar As System.Windows.Forms.Button
    Friend WithEvents ReportViewerFondo As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents FondoResarvaDS1 As Agil.FondoResarvaDS
End Class
