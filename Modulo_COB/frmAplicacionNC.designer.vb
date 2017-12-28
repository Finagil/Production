<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAplicacionNC
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvDeudores = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPagados = New System.Windows.Forms.DataGridView()
        Me.txtMontoTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCalcularIntereses = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpProceso = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DTPDesde = New System.Windows.Forms.DateTimePicker()
        Me.BtnSugerir = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtInteNC = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtFegaNC = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtGarantiaNC = New System.Windows.Forms.TextBox()
        Me.CmbConceptos = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPagoTotal = New System.Windows.Forms.TextBox()
        Me.btnAumentar = New System.Windows.Forms.Button()
        Me.txtMontoNC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.txtFactuPago = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.txtSerieA = New System.Windows.Forms.TextBox()
        Me.rbSerieA = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AviosDSX = New Agil.AviosDSX()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.CmbInstruMon = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ContaDS = New Agil.ContaDS()
        Me.GeneralDS = New Agil.GeneralDS()
        Me.InstrumentoMonetarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstrumentoMonetarioTableAdapter = New Agil.GeneralDSTableAdapters.InstrumentoMonetarioTableAdapter()
        CType(Me.dgvDeudores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPagados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstrumentoMonetarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDeudores
        '
        Me.dgvDeudores.AllowUserToDeleteRows = False
        Me.dgvDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDeudores.Location = New System.Drawing.Point(12, 32)
        Me.dgvDeudores.Name = "dgvDeudores"
        Me.dgvDeudores.ReadOnly = True
        Me.dgvDeudores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDeudores.Size = New System.Drawing.Size(1014, 190)
        Me.dgvDeudores.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Contratos con Adeudo"
        '
        'dgvPagados
        '
        Me.dgvPagados.AllowUserToDeleteRows = False
        Me.dgvPagados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagados.Location = New System.Drawing.Point(12, 326)
        Me.dgvPagados.Name = "dgvPagados"
        Me.dgvPagados.ReadOnly = True
        Me.dgvPagados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPagados.Size = New System.Drawing.Size(1000, 156)
        Me.dgvPagados.TabIndex = 22
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Location = New System.Drawing.Point(910, 488)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoTotal.TabIndex = 23
        Me.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(801, 491)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Monto total a aplicar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCalcularIntereses)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtpProceso)
        Me.Panel1.Location = New System.Drawing.Point(12, 228)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 56)
        Me.Panel1.TabIndex = 25
        '
        'btnCalcularIntereses
        '
        Me.btnCalcularIntereses.Enabled = False
        Me.btnCalcularIntereses.Location = New System.Drawing.Point(148, 21)
        Me.btnCalcularIntereses.Name = "btnCalcularIntereses"
        Me.btnCalcularIntereses.Size = New System.Drawing.Size(114, 23)
        Me.btnCalcularIntereses.TabIndex = 27
        Me.btnCalcularIntereses.Text = "Calcular Intereses"
        Me.btnCalcularIntereses.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Fecha de corte de intereses"
        '
        'dtpProceso
        '
        Me.dtpProceso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProceso.Location = New System.Drawing.Point(6, 24)
        Me.dtpProceso.Name = "dtpProceso"
        Me.dtpProceso.Size = New System.Drawing.Size(93, 20)
        Me.dtpProceso.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.DTPDesde)
        Me.Panel2.Controls.Add(Me.BtnSugerir)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.TxtInteNC)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TxtFegaNC)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TxtGarantiaNC)
        Me.Panel2.Controls.Add(Me.CmbConceptos)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtPagoTotal)
        Me.Panel2.Controls.Add(Me.btnAumentar)
        Me.Panel2.Controls.Add(Me.txtMontoNC)
        Me.Panel2.Location = New System.Drawing.Point(288, 230)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(738, 89)
        Me.Panel2.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(306, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Fecha de Cargo"
        '
        'DTPDesde
        '
        Me.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDesde.Location = New System.Drawing.Point(395, 49)
        Me.DTPDesde.Name = "DTPDesde"
        Me.DTPDesde.Size = New System.Drawing.Size(93, 20)
        Me.DTPDesde.TabIndex = 44
        '
        'BtnSugerir
        '
        Me.BtnSugerir.Enabled = False
        Me.BtnSugerir.Location = New System.Drawing.Point(494, 48)
        Me.BtnSugerir.Name = "BtnSugerir"
        Me.BtnSugerir.Size = New System.Drawing.Size(114, 23)
        Me.BtnSugerir.TabIndex = 38
        Me.BtnSugerir.Text = "Sugerir Nota"
        Me.BtnSugerir.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(321, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Intereses"
        '
        'TxtInteNC
        '
        Me.TxtInteNC.Location = New System.Drawing.Point(321, 23)
        Me.TxtInteNC.Name = "TxtInteNC"
        Me.TxtInteNC.Size = New System.Drawing.Size(100, 20)
        Me.TxtInteNC.TabIndex = 35
        Me.TxtInteNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(215, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Fega"
        '
        'TxtFegaNC
        '
        Me.TxtFegaNC.Location = New System.Drawing.Point(215, 23)
        Me.TxtFegaNC.Name = "TxtFegaNC"
        Me.TxtFegaNC.Size = New System.Drawing.Size(100, 20)
        Me.TxtFegaNC.TabIndex = 34
        Me.TxtFegaNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(109, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Garantia"
        '
        'TxtGarantiaNC
        '
        Me.TxtGarantiaNC.Location = New System.Drawing.Point(109, 23)
        Me.TxtGarantiaNC.Name = "TxtGarantiaNC"
        Me.TxtGarantiaNC.Size = New System.Drawing.Size(100, 20)
        Me.TxtGarantiaNC.TabIndex = 33
        Me.TxtGarantiaNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbConceptos
        '
        Me.CmbConceptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbConceptos.FormattingEnabled = True
        Me.CmbConceptos.Items.AddRange(New Object() {"NC ANALISIS DE SUELOS", "NC ASISTENCIA", "NC AVALUO", "NC BURO", "NC COMISION", "NC GASTOS", "NC INTERESES", "NC NOTARIO", "NC RPP", "NC SEGURO", "NC SEGURO DE VIDA", "NC VALE"})
        Me.CmbConceptos.Location = New System.Drawing.Point(533, 21)
        Me.CmbConceptos.Name = "CmbConceptos"
        Me.CmbConceptos.Size = New System.Drawing.Size(195, 21)
        Me.CmbConceptos.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(526, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Concepto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(420, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Adedudo Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Importe"
        '
        'txtPagoTotal
        '
        Me.txtPagoTotal.Location = New System.Drawing.Point(427, 22)
        Me.txtPagoTotal.Name = "txtPagoTotal"
        Me.txtPagoTotal.ReadOnly = True
        Me.txtPagoTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtPagoTotal.TabIndex = 36
        Me.txtPagoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAumentar
        '
        Me.btnAumentar.Enabled = False
        Me.btnAumentar.Location = New System.Drawing.Point(614, 48)
        Me.btnAumentar.Name = "btnAumentar"
        Me.btnAumentar.Size = New System.Drawing.Size(114, 23)
        Me.btnAumentar.TabIndex = 39
        Me.btnAumentar.Text = "Añadir a la lista"
        Me.btnAumentar.UseVisualStyleBackColor = True
        '
        'txtMontoNC
        '
        Me.txtMontoNC.Location = New System.Drawing.Point(3, 23)
        Me.txtMontoNC.Name = "txtMontoNC"
        Me.txtMontoNC.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoNC.TabIndex = 32
        Me.txtMontoNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Contratos para aplicar Notas de Crédito"
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(935, 513)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicar.TabIndex = 28
        Me.btnAplicar.Text = "Aplicar Nota"
        Me.btnAplicar.UseVisualStyleBackColor = True
        Me.btnAplicar.Visible = False
        '
        'txtFactuPago
        '
        Me.txtFactuPago.Location = New System.Drawing.Point(391, 517)
        Me.txtFactuPago.Name = "txtFactuPago"
        Me.txtFactuPago.Size = New System.Drawing.Size(100, 20)
        Me.txtFactuPago.TabIndex = 29
        Me.txtFactuPago.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(388, 494)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "No. de Factura de Pago"
        Me.Label5.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 548)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1048, 22)
        Me.StatusStrip1.TabIndex = 31
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(265, 485)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Referencia"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label7.Visible = False
        '
        'txtCheque
        '
        Me.txtCheque.Location = New System.Drawing.Point(265, 517)
        Me.txtCheque.MaxLength = 15
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(120, 20)
        Me.txtCheque.TabIndex = 32
        Me.txtCheque.Visible = False
        '
        'txtSerieA
        '
        Me.txtSerieA.Location = New System.Drawing.Point(150, 516)
        Me.txtSerieA.Name = "txtSerieA"
        Me.txtSerieA.ReadOnly = True
        Me.txtSerieA.Size = New System.Drawing.Size(85, 20)
        Me.txtSerieA.TabIndex = 122
        Me.txtSerieA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSerieA.Visible = False
        '
        'rbSerieA
        '
        Me.rbSerieA.AutoSize = True
        Me.rbSerieA.Location = New System.Drawing.Point(14, 518)
        Me.rbSerieA.Name = "rbSerieA"
        Me.rbSerieA.Size = New System.Drawing.Size(110, 17)
        Me.rbSerieA.TabIndex = 126
        Me.rbSerieA.TabStop = True
        Me.rbSerieA.Text = "Consecutivo Nota"
        Me.rbSerieA.UseVisualStyleBackColor = True
        Me.rbSerieA.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 485)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 23)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Seleccione la Serie a Usar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label8.Visible = False
        '
        'AviosDSX
        '
        Me.AviosDSX.DataSetName = "AviosDSX"
        Me.AviosDSX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(158, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "Filtro: "
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(199, 6)
        Me.TxtFiltro.MaxLength = 15
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(404, 20)
        Me.TxtFiltro.TabIndex = 130
        '
        'CmbInstruMon
        '
        Me.CmbInstruMon.DataSource = Me.InstrumentoMonetarioBindingSource
        Me.CmbInstruMon.DisplayMember = "Titulo"
        Me.CmbInstruMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbInstruMon.FormattingEnabled = True
        Me.CmbInstruMon.Location = New System.Drawing.Point(525, 516)
        Me.CmbInstruMon.Name = "CmbInstruMon"
        Me.CmbInstruMon.Size = New System.Drawing.Size(251, 21)
        Me.CmbInstruMon.TabIndex = 139
        Me.CmbInstruMon.ValueMember = "Clave"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(522, 494)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 13)
        Me.Label16.TabIndex = 138
        Me.Label16.Text = "Instrumento Monetario"
        '
        'ContaDS
        '
        Me.ContaDS.DataSetName = "ContaDS"
        Me.ContaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InstrumentoMonetarioBindingSource
        '
        Me.InstrumentoMonetarioBindingSource.DataMember = "InstrumentoMonetario"
        Me.InstrumentoMonetarioBindingSource.DataSource = Me.GeneralDS
        '
        'InstrumentoMonetarioTableAdapter
        '
        Me.InstrumentoMonetarioTableAdapter.ClearBeforeFill = True
        '
        'frmAplicacionNC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 570)
        Me.Controls.Add(Me.CmbInstruMon)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtFiltro)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rbSerieA)
        Me.Controls.Add(Me.txtSerieA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCheque)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFactuPago)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMontoTotal)
        Me.Controls.Add(Me.dgvPagados)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDeudores)
        Me.Name = "frmAplicacionNC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas de Crédito Avío"
        CType(Me.dgvDeudores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPagados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstrumentoMonetarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDeudores As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvPagados As System.Windows.Forms.DataGridView
    Friend WithEvents txtMontoTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCalcularIntereses As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpProceso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAumentar As System.Windows.Forms.Button
    Friend WithEvents txtMontoNC As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents txtFactuPago As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents txtSerieA As System.Windows.Forms.TextBox
    Friend WithEvents rbSerieA As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPagoTotal As System.Windows.Forms.TextBox
    Friend WithEvents CmbConceptos As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtInteNC As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtFegaNC As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtGarantiaNC As System.Windows.Forms.TextBox
    Friend WithEvents BtnSugerir As System.Windows.Forms.Button
    Friend WithEvents AviosDSX As Agil.AviosDSX
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DTPDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbInstruMon As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ContaDS As ContaDS
    Friend WithEvents GeneralDS As GeneralDS
    Friend WithEvents InstrumentoMonetarioBindingSource As BindingSource
    Friend WithEvents InstrumentoMonetarioTableAdapter As GeneralDSTableAdapters.InstrumentoMonetarioTableAdapter
End Class
