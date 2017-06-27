<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReestructuras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReestructuras))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbMesg = New System.Windows.Forms.ComboBox
        Me.rbNog = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.rbSig = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbNoa = New System.Windows.Forms.RadioButton
        Me.rbSia = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbMesp = New System.Windows.Forms.ComboBox
        Me.rbNop = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.rbSip = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTableStyle5 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTableStyle6 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTableStyle7 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTableStyle8 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTableStyle9 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.bProcesa = New System.Windows.Forms.Button
        Me.bSave = New System.Windows.Forms.Button
        Me.bAborta = New System.Windows.Forms.Button
        Me.bImprime = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.txtAnexo = New System.Windows.Forms.TextBox
        Me.txtRow = New System.Windows.Forms.TextBox
        Me.txtAde = New System.Windows.Forms.TextBox
        Me.txtPzo = New System.Windows.Forms.TextBox
        Me.txtFven = New System.Windows.Forms.TextBox
        Me.txtVen = New System.Windows.Forms.TextBox
        Me.txtTap = New System.Windows.Forms.TextBox
        Me.txtSant = New System.Windows.Forms.TextBox
        Me.txtPlazo = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.txtSaldoeq = New System.Windows.Forms.TextBox
        Me.txtFecfin = New System.Windows.Forms.TextBox
        Me.txtPzoIni = New System.Windows.Forms.TextBox
        Me.txtPzorest = New System.Windows.Forms.TextBox
        Me.bPruebas = New System.Windows.Forms.Button
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.CrystalReportViewer3 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbMesg)
        Me.GroupBox1.Controls.Add(Me.rbNog)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rbSig)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 49)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "en Equipo"
        '
        'cbMesg
        '
        Me.cbMesg.Enabled = False
        Me.cbMesg.FormattingEnabled = True
        Me.cbMesg.Location = New System.Drawing.Point(205, 17)
        Me.cbMesg.Name = "cbMesg"
        Me.cbMesg.Size = New System.Drawing.Size(40, 21)
        Me.cbMesg.TabIndex = 17
        '
        'rbNog
        '
        Me.rbNog.AutoSize = True
        Me.rbNog.Checked = True
        Me.rbNog.Location = New System.Drawing.Point(90, 20)
        Me.rbNog.Name = "rbNog"
        Me.rbNog.Size = New System.Drawing.Size(41, 17)
        Me.rbNog.TabIndex = 1
        Me.rbNog.TabStop = True
        Me.rbNog.Text = "No"
        Me.rbNog.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "meses"
        '
        'rbSig
        '
        Me.rbSig.AutoSize = True
        Me.rbSig.Location = New System.Drawing.Point(19, 20)
        Me.rbSig.Name = "rbSig"
        Me.rbSig.Size = New System.Drawing.Size(36, 17)
        Me.rbSig.TabIndex = 0
        Me.rbSig.Text = "Si"
        Me.rbSig.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "cuantos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "PERIODO DE GRACIA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbNoa)
        Me.GroupBox2.Controls.Add(Me.rbSia)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(150, 50)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "en Otros Adeudos"
        '
        'rbNoa
        '
        Me.rbNoa.AutoSize = True
        Me.rbNoa.Checked = True
        Me.rbNoa.Location = New System.Drawing.Point(90, 22)
        Me.rbNoa.Name = "rbNoa"
        Me.rbNoa.Size = New System.Drawing.Size(41, 17)
        Me.rbNoa.TabIndex = 1
        Me.rbNoa.TabStop = True
        Me.rbNoa.Text = "No"
        Me.rbNoa.UseVisualStyleBackColor = True
        '
        'rbSia
        '
        Me.rbSia.AutoSize = True
        Me.rbSia.Location = New System.Drawing.Point(19, 22)
        Me.rbSia.Name = "rbSia"
        Me.rbSia.Size = New System.Drawing.Size(36, 17)
        Me.rbSia.TabIndex = 0
        Me.rbSia.Text = "Si"
        Me.rbSia.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "AMPLIACION DE PLAZO"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbMesp)
        Me.GroupBox3.Controls.Add(Me.rbNop)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.rbSip)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(21, 238)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 49)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "en Equipo"
        '
        'cbMesp
        '
        Me.cbMesp.Enabled = False
        Me.cbMesp.FormattingEnabled = True
        Me.cbMesp.Location = New System.Drawing.Point(205, 17)
        Me.cbMesp.Name = "cbMesp"
        Me.cbMesp.Size = New System.Drawing.Size(41, 21)
        Me.cbMesp.TabIndex = 17
        '
        'rbNop
        '
        Me.rbNop.AutoSize = True
        Me.rbNop.Checked = True
        Me.rbNop.Location = New System.Drawing.Point(90, 20)
        Me.rbNop.Name = "rbNop"
        Me.rbNop.Size = New System.Drawing.Size(41, 17)
        Me.rbNop.TabIndex = 1
        Me.rbNop.TabStop = True
        Me.rbNop.Text = "No"
        Me.rbNop.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(250, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "meses"
        '
        'rbSip
        '
        Me.rbSip.AutoSize = True
        Me.rbSip.Location = New System.Drawing.Point(19, 20)
        Me.rbSip.Name = "rbSip"
        Me.rbSip.Size = New System.Drawing.Size(36, 17)
        Me.rbSip.TabIndex = 0
        Me.rbSip.Text = "Si"
        Me.rbSip.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(147, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "cuantos"
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "DETALLE  DE  NUEVA  TABLA  DE  AMORTIZACION  DEL  EQUIPO"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(363, 55)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(19, 34)
        Me.DataGrid1.TabIndex = 26
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1, Me.DataGridTableStyle2, Me.DataGridTableStyle3, Me.DataGridTableStyle4, Me.DataGridTableStyle5, Me.DataGridTableStyle6, Me.DataGridTableStyle7, Me.DataGridTableStyle8, Me.DataGridTableStyle9})
        Me.DataGrid1.Visible = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Letra"
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "Feven"
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "Nuifac"
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "Indrec"
        '
        'DataGridTableStyle5
        '
        Me.DataGridTableStyle5.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle5.MappingName = "Saldo"
        '
        'DataGridTableStyle6
        '
        Me.DataGridTableStyle6.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle6.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle6.MappingName = "abcap"
        '
        'DataGridTableStyle7
        '
        Me.DataGridTableStyle7.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle7.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle7.MappingName = "Inter"
        '
        'DataGridTableStyle8
        '
        Me.DataGridTableStyle8.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle8.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle8.MappingName = "Iva"
        '
        'DataGridTableStyle9
        '
        Me.DataGridTableStyle9.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle9.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle9.MappingName = "Ivacap"
        '
        'DataGrid2
        '
        Me.DataGrid2.CaptionText = "DETALLE  DE  NUEVA  TABLA  DE  AMORTIZACION  DE  OTROS  ADEUDOS "
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(363, 346)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ReadOnly = True
        Me.DataGrid2.Size = New System.Drawing.Size(19, 42)
        Me.DataGrid2.TabIndex = 27
        Me.DataGrid2.Visible = False
        '
        'bProcesa
        '
        Me.bProcesa.Location = New System.Drawing.Point(22, 521)
        Me.bProcesa.Name = "bProcesa"
        Me.bProcesa.Size = New System.Drawing.Size(101, 31)
        Me.bProcesa.TabIndex = 28
        Me.bProcesa.Text = "Procesar"
        Me.bProcesa.UseVisualStyleBackColor = True
        '
        'bSave
        '
        Me.bSave.Enabled = False
        Me.bSave.Location = New System.Drawing.Point(22, 561)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(100, 31)
        Me.bSave.TabIndex = 29
        Me.bSave.Text = "Guardar"
        Me.bSave.UseVisualStyleBackColor = True
        '
        'bAborta
        '
        Me.bAborta.Enabled = False
        Me.bAborta.Location = New System.Drawing.Point(23, 447)
        Me.bAborta.Name = "bAborta"
        Me.bAborta.Size = New System.Drawing.Size(100, 31)
        Me.bAborta.TabIndex = 31
        Me.bAborta.Text = "Cancelar"
        Me.bAborta.UseVisualStyleBackColor = True
        '
        'bImprime
        '
        Me.bImprime.Enabled = False
        Me.bImprime.Location = New System.Drawing.Point(22, 484)
        Me.bImprime.Name = "bImprime"
        Me.bImprime.Size = New System.Drawing.Size(100, 31)
        Me.bImprime.TabIndex = 32
        Me.bImprime.Text = "Imprime"
        Me.bImprime.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "IMPORTE  DE LA CAPITALIZACION"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(21, 358)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(101, 20)
        Me.txtMonto.TabIndex = 34
        '
        'txtAnexo
        '
        Me.txtAnexo.Location = New System.Drawing.Point(22, 678)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.Size = New System.Drawing.Size(10, 20)
        Me.txtAnexo.TabIndex = 35
        Me.txtAnexo.Visible = False
        '
        'txtRow
        '
        Me.txtRow.Location = New System.Drawing.Point(148, 679)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(10, 20)
        Me.txtRow.TabIndex = 42
        Me.txtRow.Text = "N"
        Me.txtRow.Visible = False
        '
        'txtAde
        '
        Me.txtAde.Location = New System.Drawing.Point(132, 679)
        Me.txtAde.Name = "txtAde"
        Me.txtAde.Size = New System.Drawing.Size(10, 20)
        Me.txtAde.TabIndex = 41
        Me.txtAde.Text = "N"
        Me.txtAde.Visible = False
        '
        'txtPzo
        '
        Me.txtPzo.Location = New System.Drawing.Point(116, 679)
        Me.txtPzo.Name = "txtPzo"
        Me.txtPzo.Size = New System.Drawing.Size(10, 20)
        Me.txtPzo.TabIndex = 40
        Me.txtPzo.Visible = False
        '
        'txtFven
        '
        Me.txtFven.Location = New System.Drawing.Point(98, 679)
        Me.txtFven.Name = "txtFven"
        Me.txtFven.Size = New System.Drawing.Size(10, 20)
        Me.txtFven.TabIndex = 39
        Me.txtFven.Visible = False
        '
        'txtVen
        '
        Me.txtVen.Location = New System.Drawing.Point(82, 679)
        Me.txtVen.Name = "txtVen"
        Me.txtVen.Size = New System.Drawing.Size(10, 20)
        Me.txtVen.TabIndex = 38
        Me.txtVen.Visible = False
        '
        'txtTap
        '
        Me.txtTap.Location = New System.Drawing.Point(66, 679)
        Me.txtTap.Name = "txtTap"
        Me.txtTap.Size = New System.Drawing.Size(10, 20)
        Me.txtTap.TabIndex = 37
        Me.txtTap.Visible = False
        '
        'txtSant
        '
        Me.txtSant.Location = New System.Drawing.Point(50, 679)
        Me.txtSant.Name = "txtSant"
        Me.txtSant.Size = New System.Drawing.Size(10, 20)
        Me.txtSant.TabIndex = 36
        Me.txtSant.Visible = False
        '
        'txtPlazo
        '
        Me.txtPlazo.Location = New System.Drawing.Point(164, 679)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.Size = New System.Drawing.Size(10, 20)
        Me.txtPlazo.TabIndex = 43
        Me.txtPlazo.Text = "N"
        Me.txtPlazo.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 598)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 31)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(363, 638)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.ShowZoomButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(868, 298)
        Me.CrystalReportViewer1.TabIndex = 45
        Me.CrystalReportViewer1.UseWaitCursor = True
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        Me.CrystalReportViewer1.Visible = False
        '
        'txtSaldoeq
        '
        Me.txtSaldoeq.Location = New System.Drawing.Point(180, 679)
        Me.txtSaldoeq.Name = "txtSaldoeq"
        Me.txtSaldoeq.Size = New System.Drawing.Size(10, 20)
        Me.txtSaldoeq.TabIndex = 46
        Me.txtSaldoeq.Text = "N"
        Me.txtSaldoeq.Visible = False
        '
        'txtFecfin
        '
        Me.txtFecfin.Location = New System.Drawing.Point(212, 679)
        Me.txtFecfin.Name = "txtFecfin"
        Me.txtFecfin.Size = New System.Drawing.Size(10, 20)
        Me.txtFecfin.TabIndex = 47
        Me.txtFecfin.Text = "N"
        Me.txtFecfin.Visible = False
        '
        'txtPzoIni
        '
        Me.txtPzoIni.AcceptsReturn = True
        Me.txtPzoIni.Location = New System.Drawing.Point(196, 679)
        Me.txtPzoIni.Name = "txtPzoIni"
        Me.txtPzoIni.Size = New System.Drawing.Size(10, 20)
        Me.txtPzoIni.TabIndex = 48
        Me.txtPzoIni.Text = "N"
        Me.txtPzoIni.Visible = False
        '
        'txtPzorest
        '
        Me.txtPzorest.Location = New System.Drawing.Point(228, 679)
        Me.txtPzorest.Name = "txtPzorest"
        Me.txtPzorest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPzorest.Size = New System.Drawing.Size(10, 20)
        Me.txtPzorest.TabIndex = 49
        Me.txtPzorest.Text = "0"
        Me.txtPzorest.Visible = False
        '
        'bPruebas
        '
        Me.bPruebas.Location = New System.Drawing.Point(23, 410)
        Me.bPruebas.Name = "bPruebas"
        Me.bPruebas.Size = New System.Drawing.Size(100, 31)
        Me.bPruebas.TabIndex = 50
        Me.bPruebas.Text = "Pruebas"
        Me.bPruebas.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.DisplayGroupTree = False
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(363, 10)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.SelectionFormula = ""
        Me.CrystalReportViewer2.ShowGroupTreeButton = False
        Me.CrystalReportViewer2.ShowRefreshButton = False
        Me.CrystalReportViewer2.ShowTextSearchButton = False
        Me.CrystalReportViewer2.ShowZoomButton = False
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(868, 311)
        Me.CrystalReportViewer2.TabIndex = 51
        Me.CrystalReportViewer2.UseWaitCursor = True
        Me.CrystalReportViewer2.ViewTimeSelectionFormula = ""
        Me.CrystalReportViewer2.Visible = False
        '
        'CrystalReportViewer3
        '
        Me.CrystalReportViewer3.ActiveViewIndex = -1
        Me.CrystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer3.DisplayGroupTree = False
        Me.CrystalReportViewer3.Location = New System.Drawing.Point(363, 325)
        Me.CrystalReportViewer3.Name = "CrystalReportViewer3"
        Me.CrystalReportViewer3.SelectionFormula = ""
        Me.CrystalReportViewer3.ShowGroupTreeButton = False
        Me.CrystalReportViewer3.ShowRefreshButton = False
        Me.CrystalReportViewer3.ShowTextSearchButton = False
        Me.CrystalReportViewer3.ShowZoomButton = False
        Me.CrystalReportViewer3.Size = New System.Drawing.Size(868, 307)
        Me.CrystalReportViewer3.TabIndex = 52
        Me.CrystalReportViewer3.UseWaitCursor = True
        Me.CrystalReportViewer3.ViewTimeSelectionFormula = ""
        Me.CrystalReportViewer3.Visible = False
        '
        'frmReestructuras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 948)
        Me.Controls.Add(Me.CrystalReportViewer3)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.bPruebas)
        Me.Controls.Add(Me.txtPzorest)
        Me.Controls.Add(Me.txtPzoIni)
        Me.Controls.Add(Me.txtFecfin)
        Me.Controls.Add(Me.txtSaldoeq)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPlazo)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.txtAde)
        Me.Controls.Add(Me.txtPzo)
        Me.Controls.Add(Me.txtFven)
        Me.Controls.Add(Me.txtVen)
        Me.Controls.Add(Me.txtTap)
        Me.Controls.Add(Me.txtSant)
        Me.Controls.Add(Me.txtAnexo)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bImprime)
        Me.Controls.Add(Me.bAborta)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bProcesa)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReestructuras"
        Me.Text = "frmReestructuras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMesg As System.Windows.Forms.ComboBox
    Friend WithEvents rbNog As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbSig As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNoa As System.Windows.Forms.RadioButton
    Friend WithEvents rbSia As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMesp As System.Windows.Forms.ComboBox
    Friend WithEvents rbNop As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbSip As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents bProcesa As System.Windows.Forms.Button
    Friend WithEvents bSave As System.Windows.Forms.Button
    Friend WithEvents bAborta As System.Windows.Forms.Button
    Friend WithEvents bImprime As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents txtRow As System.Windows.Forms.TextBox
    Friend WithEvents txtAde As System.Windows.Forms.TextBox
    Friend WithEvents txtPzo As System.Windows.Forms.TextBox
    Friend WithEvents txtFven As System.Windows.Forms.TextBox
    Friend WithEvents txtVen As System.Windows.Forms.TextBox
    Friend WithEvents txtTap As System.Windows.Forms.TextBox
    Friend WithEvents txtSant As System.Windows.Forms.TextBox
    Friend WithEvents txtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle5 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle6 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle7 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle8 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle9 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtSaldoeq As System.Windows.Forms.TextBox
    Friend WithEvents txtFecfin As System.Windows.Forms.TextBox
    Friend WithEvents txtPzoIni As System.Windows.Forms.TextBox
    Friend WithEvents txtPzorest As System.Windows.Forms.TextBox
    Friend WithEvents bPruebas As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportViewer3 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
