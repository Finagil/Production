<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAplicacion
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
        Me.CKaplicaBlanco = New System.Windows.Forms.CheckBox()
        Me.LbGarantia = New System.Windows.Forms.Label()
        Me.btnCalcularIntereses = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpProceso = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAumentar = New System.Windows.Forms.Button()
        Me.txtPagoTotal = New System.Windows.Forms.TextBox()
        Me.txtPagoParcial = New System.Windows.Forms.TextBox()
        Me.rbParcial = New System.Windows.Forms.RadioButton()
        Me.rbTotal = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ControlGastosEXT1 = New Agil.ControlGastosEXT()
        Me.CmbInstruMon = New System.Windows.Forms.ComboBox()
        Me.InstrumentoMonetarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.InstrumentoMonetarioTableAdapter = New Agil.GeneralDSTableAdapters.InstrumentoMonetarioTableAdapter()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgvDeudores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPagados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstrumentoMonetarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvDeudores.Size = New System.Drawing.Size(998, 190)
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
        Me.dgvPagados.Location = New System.Drawing.Point(12, 353)
        Me.dgvPagados.Name = "dgvPagados"
        Me.dgvPagados.ReadOnly = True
        Me.dgvPagados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPagados.Size = New System.Drawing.Size(1000, 156)
        Me.dgvPagados.TabIndex = 22
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Location = New System.Drawing.Point(910, 516)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoTotal.TabIndex = 23
        Me.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(801, 519)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Monto total a aplicar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CKaplicaBlanco)
        Me.Panel1.Controls.Add(Me.LbGarantia)
        Me.Panel1.Controls.Add(Me.btnCalcularIntereses)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtpProceso)
        Me.Panel1.Location = New System.Drawing.Point(30, 234)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 89)
        Me.Panel1.TabIndex = 25
        '
        'CKaplicaBlanco
        '
        Me.CKaplicaBlanco.AutoSize = True
        Me.CKaplicaBlanco.Location = New System.Drawing.Point(304, 10)
        Me.CKaplicaBlanco.Name = "CKaplicaBlanco"
        Me.CKaplicaBlanco.Size = New System.Drawing.Size(106, 17)
        Me.CKaplicaBlanco.TabIndex = 139
        Me.CKaplicaBlanco.Text = "Aplica en Blanco"
        Me.CKaplicaBlanco.UseVisualStyleBackColor = True
        '
        'LbGarantia
        '
        Me.LbGarantia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGarantia.ForeColor = System.Drawing.Color.Red
        Me.LbGarantia.Location = New System.Drawing.Point(3, 61)
        Me.LbGarantia.Name = "LbGarantia"
        Me.LbGarantia.Size = New System.Drawing.Size(443, 27)
        Me.LbGarantia.TabIndex = 28
        Me.LbGarantia.Text = "CONTRATO CON GARANTÍAS DE FIRA EJERCIDAS FAVOR DE VERIFICAR SU APLICACIÓN CON CON" &
    "TRALORÍA"
        Me.LbGarantia.Visible = False
        '
        'btnCalcularIntereses
        '
        Me.btnCalcularIntereses.Enabled = False
        Me.btnCalcularIntereses.Location = New System.Drawing.Point(304, 33)
        Me.btnCalcularIntereses.Name = "btnCalcularIntereses"
        Me.btnCalcularIntereses.Size = New System.Drawing.Size(114, 23)
        Me.btnCalcularIntereses.TabIndex = 27
        Me.btnCalcularIntereses.Text = "Calcular Intereses"
        Me.btnCalcularIntereses.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Fecha de corte de intereses"
        '
        'dtpProceso
        '
        Me.dtpProceso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProceso.Location = New System.Drawing.Point(173, 33)
        Me.dtpProceso.Name = "dtpProceso"
        Me.dtpProceso.Size = New System.Drawing.Size(93, 20)
        Me.dtpProceso.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAumentar)
        Me.Panel2.Controls.Add(Me.txtPagoTotal)
        Me.Panel2.Controls.Add(Me.txtPagoParcial)
        Me.Panel2.Controls.Add(Me.rbParcial)
        Me.Panel2.Controls.Add(Me.rbTotal)
        Me.Panel2.Location = New System.Drawing.Point(485, 233)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(411, 90)
        Me.Panel2.TabIndex = 26
        '
        'btnAumentar
        '
        Me.btnAumentar.Enabled = False
        Me.btnAumentar.Location = New System.Drawing.Point(269, 34)
        Me.btnAumentar.Name = "btnAumentar"
        Me.btnAumentar.Size = New System.Drawing.Size(114, 23)
        Me.btnAumentar.TabIndex = 33
        Me.btnAumentar.Text = "Añadir a la lista"
        Me.btnAumentar.UseVisualStyleBackColor = True
        '
        'txtPagoTotal
        '
        Me.txtPagoTotal.Location = New System.Drawing.Point(126, 23)
        Me.txtPagoTotal.Name = "txtPagoTotal"
        Me.txtPagoTotal.ReadOnly = True
        Me.txtPagoTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtPagoTotal.TabIndex = 29
        Me.txtPagoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPagoParcial
        '
        Me.txtPagoParcial.Location = New System.Drawing.Point(126, 49)
        Me.txtPagoParcial.Name = "txtPagoParcial"
        Me.txtPagoParcial.Size = New System.Drawing.Size(100, 20)
        Me.txtPagoParcial.TabIndex = 32
        Me.txtPagoParcial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rbParcial
        '
        Me.rbParcial.Location = New System.Drawing.Point(34, 51)
        Me.rbParcial.Name = "rbParcial"
        Me.rbParcial.Size = New System.Drawing.Size(88, 17)
        Me.rbParcial.TabIndex = 31
        Me.rbParcial.TabStop = True
        Me.rbParcial.Text = "Pago Parcial"
        Me.rbParcial.UseVisualStyleBackColor = True
        '
        'rbTotal
        '
        Me.rbTotal.Location = New System.Drawing.Point(34, 25)
        Me.rbTotal.Name = "rbTotal"
        Me.rbTotal.Size = New System.Drawing.Size(88, 17)
        Me.rbTotal.TabIndex = 30
        Me.rbTotal.TabStop = True
        Me.rbTotal.Text = "Pago Total"
        Me.rbTotal.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Contratos a pagar"
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(935, 561)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicar.TabIndex = 28
        Me.btnAplicar.Text = "Aplicar pagos"
        Me.btnAplicar.UseVisualStyleBackColor = True
        Me.btnAplicar.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 680)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1284, 22)
        Me.StatusStrip1.TabIndex = 31
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(433, 530)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 23)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Seleccione el Banco"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(287, 531)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "No. de Cheque"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtCheque
        '
        Me.txtCheque.Location = New System.Drawing.Point(287, 563)
        Me.txtCheque.MaxLength = 15
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(120, 20)
        Me.txtCheque.TabIndex = 32
        '
        'cbBancos
        '
        Me.cbBancos.Location = New System.Drawing.Point(433, 562)
        Me.cbBancos.MaxDropDownItems = 10
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(224, 21)
        Me.cbBancos.TabIndex = 33
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(169, 559)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(85, 20)
        Me.txtFolio.TabIndex = 122
        Me.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 531)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 23)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Seleccione la Serie a Usar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label8.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1053, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(384, 477)
        Me.DataGridView1.TabIndex = 129
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(223, 6)
        Me.TxtFiltro.MaxLength = 15
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(404, 20)
        Me.TxtFiltro.TabIndex = 132
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(182, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 131
        Me.Label14.Text = "Filtro: "
        '
        'ControlGastosEXT1
        '
        Me.ControlGastosEXT1.Location = New System.Drawing.Point(902, 258)
        Me.ControlGastosEXT1.Name = "ControlGastosEXT1"
        Me.ControlGastosEXT1.Size = New System.Drawing.Size(102, 44)
        Me.ControlGastosEXT1.TabIndex = 133
        '
        'CmbInstruMon
        '
        Me.CmbInstruMon.DataSource = Me.InstrumentoMonetarioBindingSource
        Me.CmbInstruMon.DisplayMember = "Titulo"
        Me.CmbInstruMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbInstruMon.FormattingEnabled = True
        Me.CmbInstruMon.Location = New System.Drawing.Point(663, 563)
        Me.CmbInstruMon.Name = "CmbInstruMon"
        Me.CmbInstruMon.Size = New System.Drawing.Size(251, 21)
        Me.CmbInstruMon.TabIndex = 137
        Me.CmbInstruMon.ValueMember = "Clave"
        '
        'InstrumentoMonetarioBindingSource
        '
        Me.InstrumentoMonetarioBindingSource.DataMember = "InstrumentoMonetario"
        Me.InstrumentoMonetarioBindingSource.DataSource = Me.GeneralDS
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(660, 541)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 13)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "Instrumento Monetario"
        '
        'InstrumentoMonetarioTableAdapter
        '
        Me.InstrumentoMonetarioTableAdapter.ClearBeforeFill = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(99, 562)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "Serie X"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'frmAplicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 702)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CmbInstruMon)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ControlGastosEXT1)
        Me.Controls.Add(Me.TxtFiltro)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCheque)
        Me.Controls.Add(Me.cbBancos)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMontoTotal)
        Me.Controls.Add(Me.dgvPagados)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDeudores)
        Me.Name = "frmAplicacion"
        Me.Text = "Pagos de Avío Productor-FINAGIL"
        CType(Me.dgvDeudores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPagados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstrumentoMonetarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtPagoTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtPagoParcial As System.Windows.Forms.TextBox
    Friend WithEvents rbParcial As System.Windows.Forms.RadioButton
    Friend WithEvents rbTotal As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LbGarantia As System.Windows.Forms.Label
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ControlGastosEXT1 As Agil.ControlGastosEXT
    Friend WithEvents CmbInstruMon As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GeneralDS As GeneralDS
    Friend WithEvents InstrumentoMonetarioBindingSource As BindingSource
    Friend WithEvents InstrumentoMonetarioTableAdapter As GeneralDSTableAdapters.InstrumentoMonetarioTableAdapter
    Friend WithEvents Label10 As Label
    Friend WithEvents CKaplicaBlanco As CheckBox
End Class
