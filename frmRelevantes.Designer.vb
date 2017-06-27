<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelevantes
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblInicial = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.btProcesa2 = New System.Windows.Forms.Button()
        Me.btnProcesoI = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(731, 17)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(17, 56)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1136, 675)
        Me.CrystalReportViewer1.TabIndex = 30
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'lblFinal
        '
        Me.lblFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(225, 17)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(76, 16)
        Me.lblFinal.TabIndex = 27
        Me.lblFinal.Text = "Fecha Final"
        Me.lblFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInicial
        '
        Me.lblInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicial.Location = New System.Drawing.Point(25, 17)
        Me.lblInicial.Name = "lblInicial"
        Me.lblInicial.Size = New System.Drawing.Size(82, 16)
        Me.lblInicial.TabIndex = 25
        Me.lblInicial.Text = "Fecha Inicial"
        Me.lblInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(525, 17)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(90, 23)
        Me.btnProcesar.TabIndex = 29
        Me.btnProcesar.Text = "Relevantes C1"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(305, 17)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(108, 20)
        Me.dtpFechaFin.TabIndex = 28
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(113, 17)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechaIni.TabIndex = 26
        '
        'btProcesa2
        '
        Me.btProcesa2.Location = New System.Drawing.Point(629, 18)
        Me.btProcesa2.Name = "btProcesa2"
        Me.btProcesa2.Size = New System.Drawing.Size(88, 23)
        Me.btProcesa2.TabIndex = 32
        Me.btProcesa2.Text = "Relevantes C2"
        '
        'btnProcesoI
        '
        Me.btnProcesoI.Location = New System.Drawing.Point(419, 18)
        Me.btnProcesoI.Name = "btnProcesoI"
        Me.btnProcesoI.Size = New System.Drawing.Size(90, 23)
        Me.btnProcesoI.TabIndex = 33
        Me.btnProcesoI.Text = "Inusuales"
        '
        'frmRelevantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 744)
        Me.Controls.Add(Me.btnProcesoI)
        Me.Controls.Add(Me.btProcesa2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblInicial)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Name = "frmRelevantes"
        Me.Text = "Operaciones Relevantes Criterio 1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblFinal As System.Windows.Forms.Label
    Friend WithEvents lblInicial As System.Windows.Forms.Label
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents btProcesa2 As System.Windows.Forms.Button
    Friend WithEvents btnProcesoI As System.Windows.Forms.Button
End Class
