<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdoCtaAvio
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lblInicial = New System.Windows.Forms.Label()
        Me.dtpProceso = New System.Windows.Forms.DateTimePicker()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.txtAnexo = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreProductor = New System.Windows.Forms.TextBox()
        Me.btnSaldos = New System.Windows.Forms.Button()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblCiclo = New System.Windows.Forms.Label()
        Me.GEN_CultivosTableAdapter1 = New Agil.SegurosDSTableAdapters.GEN_CultivosTableAdapter()
        Me.BtnOnbase = New System.Windows.Forms.Button()
        Me.TxtContMarco = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LbFondeo = New System.Windows.Forms.Label()
        Me.LbGarLiq = New System.Windows.Forms.Label()
        Me.LbTasaF = New System.Windows.Forms.Label()
        Me.LbTasaV = New System.Windows.Forms.Label()
        Me.LbSegVid = New System.Windows.Forms.Label()
        Me.BtnOnbaseCRE = New System.Windows.Forms.Button()
        Me.Lbuser = New System.Windows.Forms.Label()
        Me.GastosEXT = New Agil.ControlGastosEXT()
        Me.BtnOnbaseFira = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No. de Contrato"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(735, 32)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 6
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'lblInicial
        '
        Me.lblInicial.AutoSize = True
        Me.lblInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicial.Location = New System.Drawing.Point(488, 34)
        Me.lblInicial.Name = "lblInicial"
        Me.lblInicial.Size = New System.Drawing.Size(94, 13)
        Me.lblInicial.TabIndex = 7
        Me.lblInicial.Text = "Fecha de Proceso"
        Me.lblInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpProceso
        '
        Me.dtpProceso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProceso.Location = New System.Drawing.Point(588, 30)
        Me.dtpProceso.Name = "dtpProceso"
        Me.dtpProceso.Size = New System.Drawing.Size(88, 20)
        Me.dtpProceso.TabIndex = 8
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(15, 108)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(992, 582)
        Me.CrystalReportViewer1.TabIndex = 9
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'txtAnexo
        '
        Me.txtAnexo.Location = New System.Drawing.Point(139, 31)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.ReadOnly = True
        Me.txtAnexo.Size = New System.Drawing.Size(69, 20)
        Me.txtAnexo.TabIndex = 10
        Me.txtAnexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(929, 33)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(20, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 17)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Nombre del Productor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombreProductor
        '
        Me.txtNombreProductor.Location = New System.Drawing.Point(139, 7)
        Me.txtNombreProductor.Name = "txtNombreProductor"
        Me.txtNombreProductor.ReadOnly = True
        Me.txtNombreProductor.Size = New System.Drawing.Size(865, 20)
        Me.txtNombreProductor.TabIndex = 55
        Me.txtNombreProductor.TabStop = False
        '
        'btnSaldos
        '
        Me.btnSaldos.Enabled = False
        Me.btnSaldos.Location = New System.Drawing.Point(826, 33)
        Me.btnSaldos.Name = "btnSaldos"
        Me.btnSaldos.Size = New System.Drawing.Size(75, 23)
        Me.btnSaldos.TabIndex = 60
        Me.btnSaldos.Text = "Rep. Saldos"
        Me.btnSaldos.UseVisualStyleBackColor = True
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(20, 60)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(48, 13)
        Me.lblSucursal.TabIndex = 61
        Me.lblSucursal.Text = "Sucursal"
        '
        'lblCiclo
        '
        Me.lblCiclo.AutoSize = True
        Me.lblCiclo.Location = New System.Drawing.Point(228, 34)
        Me.lblCiclo.Name = "lblCiclo"
        Me.lblCiclo.Size = New System.Drawing.Size(76, 13)
        Me.lblCiclo.TabIndex = 62
        Me.lblCiclo.Text = "Ciclo o Pagar�"
        '
        'GEN_CultivosTableAdapter1
        '
        Me.GEN_CultivosTableAdapter1.ClearBeforeFill = True
        '
        'BtnOnbase
        '
        Me.BtnOnbase.Location = New System.Drawing.Point(667, 66)
        Me.BtnOnbase.Name = "BtnOnbase"
        Me.BtnOnbase.Size = New System.Drawing.Size(74, 35)
        Me.BtnOnbase.TabIndex = 100
        Me.BtnOnbase.Text = "OnBase Contrato"
        '
        'TxtContMarco
        '
        Me.TxtContMarco.Location = New System.Drawing.Point(139, 81)
        Me.TxtContMarco.Name = "TxtContMarco"
        Me.TxtContMarco.ReadOnly = True
        Me.TxtContMarco.Size = New System.Drawing.Size(130, 20)
        Me.TxtContMarco.TabIndex = 130
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(20, 81)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(118, 19)
        Me.Label21.TabIndex = 129
        Me.Label21.Text = "No. de Contrato Marco"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbFondeo
        '
        Me.LbFondeo.AutoSize = True
        Me.LbFondeo.Location = New System.Drawing.Point(177, 60)
        Me.LbFondeo.Name = "LbFondeo"
        Me.LbFondeo.Size = New System.Drawing.Size(43, 13)
        Me.LbFondeo.TabIndex = 131
        Me.LbFondeo.Text = "Fondeo"
        '
        'LbGarLiq
        '
        Me.LbGarLiq.AutoSize = True
        Me.LbGarLiq.Location = New System.Drawing.Point(317, 60)
        Me.LbGarLiq.Name = "LbGarLiq"
        Me.LbGarLiq.Size = New System.Drawing.Size(47, 13)
        Me.LbGarLiq.TabIndex = 132
        Me.LbGarLiq.Text = "Garantia"
        '
        'LbTasaF
        '
        Me.LbTasaF.AutoSize = True
        Me.LbTasaF.Location = New System.Drawing.Point(275, 87)
        Me.LbTasaF.Name = "LbTasaF"
        Me.LbTasaF.Size = New System.Drawing.Size(53, 13)
        Me.LbTasaF.TabIndex = 133
        Me.LbTasaF.Text = "Tasa Fija:"
        '
        'LbTasaV
        '
        Me.LbTasaV.AutoSize = True
        Me.LbTasaV.Location = New System.Drawing.Point(362, 87)
        Me.LbTasaV.Name = "LbTasaV"
        Me.LbTasaV.Size = New System.Drawing.Size(75, 13)
        Me.LbTasaV.TabIndex = 134
        Me.LbTasaV.Text = "Tasa Variable:"
        '
        'LbSegVid
        '
        Me.LbSegVid.AutoSize = True
        Me.LbSegVid.Location = New System.Drawing.Point(481, 87)
        Me.LbSegVid.Name = "LbSegVid"
        Me.LbSegVid.Size = New System.Drawing.Size(83, 13)
        Me.LbSegVid.TabIndex = 135
        Me.LbSegVid.Text = "Seguro de Vida:"
        '
        'BtnOnbaseCRE
        '
        Me.BtnOnbaseCRE.Location = New System.Drawing.Point(747, 65)
        Me.BtnOnbaseCRE.Name = "BtnOnbaseCRE"
        Me.BtnOnbaseCRE.Size = New System.Drawing.Size(74, 35)
        Me.BtnOnbaseCRE.TabIndex = 136
        Me.BtnOnbaseCRE.Text = "OnBase Cr�dito"
        '
        'Lbuser
        '
        Me.Lbuser.Location = New System.Drawing.Point(481, 57)
        Me.Lbuser.Name = "Lbuser"
        Me.Lbuser.Size = New System.Drawing.Size(118, 19)
        Me.Lbuser.TabIndex = 137
        Me.Lbuser.Text = "Usuario"
        Me.Lbuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GastosEXT
        '
        Me.GastosEXT.Location = New System.Drawing.Point(903, 62)
        Me.GastosEXT.Name = "GastosEXT"
        Me.GastosEXT.Size = New System.Drawing.Size(104, 43)
        Me.GastosEXT.TabIndex = 63
        '
        'BtnOnbaseFira
        '
        Me.BtnOnbaseFira.Location = New System.Drawing.Point(827, 65)
        Me.BtnOnbaseFira.Name = "BtnOnbaseFira"
        Me.BtnOnbaseFira.Size = New System.Drawing.Size(74, 35)
        Me.BtnOnbaseFira.TabIndex = 138
        Me.BtnOnbaseFira.Text = "OnBase Sup. Fira"
        '
        'frmEdoCtaAvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 702)
        Me.Controls.Add(Me.BtnOnbaseFira)
        Me.Controls.Add(Me.Lbuser)
        Me.Controls.Add(Me.BtnOnbaseCRE)
        Me.Controls.Add(Me.LbSegVid)
        Me.Controls.Add(Me.LbTasaV)
        Me.Controls.Add(Me.LbTasaF)
        Me.Controls.Add(Me.LbGarLiq)
        Me.Controls.Add(Me.LbFondeo)
        Me.Controls.Add(Me.TxtContMarco)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.BtnOnbase)
        Me.Controls.Add(Me.GastosEXT)
        Me.Controls.Add(Me.lblCiclo)
        Me.Controls.Add(Me.lblSucursal)
        Me.Controls.Add(Me.btnSaldos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNombreProductor)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtAnexo)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.lblInicial)
        Me.Controls.Add(Me.dtpProceso)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEdoCtaAvio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de Cuenta Av�o"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents lblInicial As System.Windows.Forms.Label
    Friend WithEvents dtpProceso As System.Windows.Forms.DateTimePicker
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombreProductor As System.Windows.Forms.TextBox
    Friend WithEvents btnSaldos As System.Windows.Forms.Button
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents lblCiclo As System.Windows.Forms.Label
    Friend WithEvents GEN_CultivosTableAdapter1 As Agil.SegurosDSTableAdapters.GEN_CultivosTableAdapter
    Friend WithEvents GastosEXT As Agil.ControlGastosEXT
    Friend WithEvents BtnOnbase As System.Windows.Forms.Button
    Friend WithEvents TxtContMarco As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LbFondeo As System.Windows.Forms.Label
    Friend WithEvents LbGarLiq As System.Windows.Forms.Label
    Friend WithEvents LbTasaF As System.Windows.Forms.Label
    Friend WithEvents LbTasaV As System.Windows.Forms.Label
    Friend WithEvents LbSegVid As System.Windows.Forms.Label
    Friend WithEvents BtnOnbaseCRE As System.Windows.Forms.Button
    Friend WithEvents Lbuser As System.Windows.Forms.Label
    Friend WithEvents BtnOnbaseFira As System.Windows.Forms.Button
End Class
