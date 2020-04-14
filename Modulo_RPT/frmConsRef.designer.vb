<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsRef
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsRef))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReporte = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGarantias = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.CkFecApli = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(595, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(421, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "ComboBox1"
        Me.ComboBox1.Visible = False
        '
        'lblClientes
        '
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(595, 17)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(264, 15)
        Me.lblClientes.TabIndex = 3
        Me.lblClientes.Text = "Selecciona un Cliente de la siguiente Lista"
        Me.lblClientes.Visible = False
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(302, 35)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 4
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.Visible = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 78)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1008, 614)
        Me.CrystalReportViewer1.TabIndex = 5
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker1.TabIndex = 7
        Me.DateTimePicker1.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(110, 38)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker2.TabIndex = 8
        Me.DateTimePicker2.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha Inicial"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha Final"
        Me.Label2.Visible = False
        '
        'txtReporte
        '
        Me.txtReporte.Location = New System.Drawing.Point(273, -6)
        Me.txtReporte.Name = "txtReporte"
        Me.txtReporte.Size = New System.Drawing.Size(19, 20)
        Me.txtReporte.TabIndex = 12
        Me.txtReporte.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(503, 35)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(72, 23)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGarantias
        '
        Me.btnGarantias.Location = New System.Drawing.Point(383, 35)
        Me.btnGarantias.Name = "btnGarantias"
        Me.btnGarantias.Size = New System.Drawing.Size(114, 23)
        Me.btnGarantias.TabIndex = 14
        Me.btnGarantias.Text = "Garantías Ejercidas"
        Me.btnGarantias.UseVisualStyleBackColor = True
        Me.btnGarantias.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Fecha Aplicación"
        Me.Label3.Visible = False
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(204, 38)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker3.TabIndex = 15
        Me.DateTimePicker3.Visible = False
        '
        'CkFecApli
        '
        Me.CkFecApli.AutoSize = True
        Me.CkFecApli.Location = New System.Drawing.Point(316, 15)
        Me.CkFecApli.Name = "CkFecApli"
        Me.CkFecApli.Size = New System.Drawing.Size(111, 17)
        Me.CkFecApli.TabIndex = 17
        Me.CkFecApli.Text = "Rango de Fechas"
        Me.CkFecApli.UseVisualStyleBackColor = True
        '
        'frmConsRef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 702)
        Me.Controls.Add(Me.CkFecApli)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.btnGarantias)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtReporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.ComboBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsRef"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Depósitos Referenciados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblClientes As System.Windows.Forms.Label
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReporte As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGarantias As System.Windows.Forms.Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents CkFecApli As CheckBox
End Class
