<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDomiciliacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dtpProcesar = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.lblPagos = New System.Windows.Forms.Label
        Me.lblSaldos = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnLayOut = New System.Windows.Forms.Button
        Me.txtNvoImp = New System.Windows.Forms.TextBox
        Me.btnModifica = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbDeudor = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbSinAdeudo = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.txtCte = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnAdicionar = New System.Windows.Forms.Button
        Me.txtImpExt = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.rbBmer = New System.Windows.Forms.RadioButton
        Me.rbNoBmer = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnAdelanto = New System.Windows.Forms.Button
        Me.txtAdelanto = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpProcesar
        '
        Me.dtpProcesar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProcesar.Location = New System.Drawing.Point(218, 23)
        Me.dtpProcesar.Name = "dtpProcesar"
        Me.dtpProcesar.Size = New System.Drawing.Size(88, 20)
        Me.dtpProcesar.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Selecciona día a procesar"
        '
        'btnProcesar
        '
        Me.btnProcesar.ForeColor = System.Drawing.Color.Black
        Me.btnProcesar.Location = New System.Drawing.Point(639, 22)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(78, 23)
        Me.btnProcesar.TabIndex = 14
        Me.btnProcesar.Text = "Generar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'lblPagos
        '
        Me.lblPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagos.Location = New System.Drawing.Point(19, 534)
        Me.lblPagos.Name = "lblPagos"
        Me.lblPagos.Size = New System.Drawing.Size(377, 23)
        Me.lblPagos.TabIndex = 22
        Me.lblPagos.Text = "Estos son los ADEUDOS que se añadiran al cobro domiciliado "
        Me.lblPagos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblPagos.Visible = False
        '
        'lblSaldos
        '
        Me.lblSaldos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldos.Location = New System.Drawing.Point(19, 108)
        Me.lblSaldos.Name = "lblSaldos"
        Me.lblSaldos.Size = New System.Drawing.Size(533, 20)
        Me.lblSaldos.TabIndex = 21
        Me.lblSaldos.Text = "1 Click para cobrar otro Importe y 2 Clicks para AGREGAR el cobro a la Domiciliac" & _
            "ion"
        Me.lblSaldos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblSaldos.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(735, 23)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(109, 23)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "Añadir Elementos"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnLayOut
        '
        Me.btnLayOut.Enabled = False
        Me.btnLayOut.ForeColor = System.Drawing.Color.Black
        Me.btnLayOut.Location = New System.Drawing.Point(1010, 601)
        Me.btnLayOut.Name = "btnLayOut"
        Me.btnLayOut.Size = New System.Drawing.Size(109, 23)
        Me.btnLayOut.TabIndex = 24
        Me.btnLayOut.Text = "Generar LayOut"
        Me.btnLayOut.UseVisualStyleBackColor = True
        Me.btnLayOut.Visible = False
        '
        'txtNvoImp
        '
        Me.txtNvoImp.Location = New System.Drawing.Point(1008, 146)
        Me.txtNvoImp.Name = "txtNvoImp"
        Me.txtNvoImp.Size = New System.Drawing.Size(111, 20)
        Me.txtNvoImp.TabIndex = 25
        Me.txtNvoImp.Visible = False
        '
        'btnModifica
        '
        Me.btnModifica.ForeColor = System.Drawing.Color.Black
        Me.btnModifica.Location = New System.Drawing.Point(1010, 172)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(109, 23)
        Me.btnModifica.TabIndex = 26
        Me.btnModifica.Text = "Modificar Importe"
        Me.btnModifica.UseVisualStyleBackColor = True
        Me.btnModifica.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1007, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nuevo Importe"
        Me.Label2.Visible = False
        '
        'cbDeudor
        '
        Me.cbDeudor.FormattingEnabled = True
        Me.cbDeudor.Location = New System.Drawing.Point(19, 81)
        Me.cbDeudor.Name = "cbDeudor"
        Me.cbDeudor.Size = New System.Drawing.Size(533, 21)
        Me.cbDeudor.TabIndex = 28
        Me.cbDeudor.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(329, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Clientes con ADEUDO "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(329, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Clientes sin ADEUDO "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label4.Visible = False
        '
        'cbSinAdeudo
        '
        Me.cbSinAdeudo.FormattingEnabled = True
        Me.cbSinAdeudo.Location = New System.Drawing.Point(23, 319)
        Me.cbSinAdeudo.Name = "cbSinAdeudo"
        Me.cbSinAdeudo.Size = New System.Drawing.Size(533, 21)
        Me.cbSinAdeudo.TabIndex = 30
        Me.cbSinAdeudo.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(532, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "1 Click para ingresar Importe y 2 Clicks para  AGRECAR el  cobro a la Domiciliaci" & _
            "on"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label5.Visible = False
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(1125, 138)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(10, 20)
        Me.txtCliente.TabIndex = 34
        Me.txtCliente.Visible = False
        '
        'txtCte
        '
        Me.txtCte.Location = New System.Drawing.Point(1109, 381)
        Me.txtCte.Name = "txtCte"
        Me.txtCte.Size = New System.Drawing.Size(10, 20)
        Me.txtCte.TabIndex = 41
        Me.txtCte.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1007, 388)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Importe Adicional"
        Me.Label6.Visible = False
        '
        'btnAdicionar
        '
        Me.btnAdicionar.ForeColor = System.Drawing.Color.Black
        Me.btnAdicionar.Location = New System.Drawing.Point(1010, 439)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(109, 23)
        Me.btnAdicionar.TabIndex = 43
        Me.btnAdicionar.Text = "Ingresar Importe"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        Me.btnAdicionar.Visible = False
        '
        'txtImpExt
        '
        Me.txtImpExt.Location = New System.Drawing.Point(1008, 413)
        Me.txtImpExt.Name = "txtImpExt"
        Me.txtImpExt.Size = New System.Drawing.Size(111, 20)
        Me.txtImpExt.TabIndex = 42
        Me.txtImpExt.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.Location = New System.Drawing.Point(17, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.RowTemplate.Height = 20
        Me.DataGridView1.Size = New System.Drawing.Size(967, 156)
        Me.DataGridView1.TabIndex = 45
        Me.DataGridView1.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView2.Location = New System.Drawing.Point(19, 375)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.RowHeadersWidth = 30
        Me.DataGridView2.RowTemplate.Height = 20
        Me.DataGridView2.Size = New System.Drawing.Size(967, 156)
        Me.DataGridView2.TabIndex = 46
        Me.DataGridView2.Visible = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView3.GridColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView3.Location = New System.Drawing.Point(17, 560)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView3.RowHeadersWidth = 30
        Me.DataGridView3.RowTemplate.Height = 20
        Me.DataGridView3.Size = New System.Drawing.Size(967, 156)
        Me.DataGridView3.TabIndex = 47
        Me.DataGridView3.Visible = False
        '
        'rbBmer
        '
        Me.rbBmer.AutoSize = True
        Me.rbBmer.Location = New System.Drawing.Point(340, 23)
        Me.rbBmer.Name = "rbBmer"
        Me.rbBmer.Size = New System.Drawing.Size(231, 17)
        Me.rbBmer.TabIndex = 48
        Me.rbBmer.TabStop = True
        Me.rbBmer.Text = "Solo Contratos con Cuenta en BANCOMER"
        Me.rbBmer.UseVisualStyleBackColor = True
        '
        'rbNoBmer
        '
        Me.rbNoBmer.AutoSize = True
        Me.rbNoBmer.Location = New System.Drawing.Point(340, 46)
        Me.rbNoBmer.Name = "rbNoBmer"
        Me.rbNoBmer.Size = New System.Drawing.Size(255, 17)
        Me.rbNoBmer.TabIndex = 49
        Me.rbNoBmer.TabStop = True
        Me.rbNoBmer.Text = "Solo Contratos con Cuenta en OTROS BANCOS"
        Me.rbNoBmer.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1007, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Adelanto a Capital"
        Me.Label7.Visible = False
        '
        'btnAdelanto
        '
        Me.btnAdelanto.ForeColor = System.Drawing.Color.Black
        Me.btnAdelanto.Location = New System.Drawing.Point(1010, 261)
        Me.btnAdelanto.Name = "btnAdelanto"
        Me.btnAdelanto.Size = New System.Drawing.Size(109, 23)
        Me.btnAdelanto.TabIndex = 51
        Me.btnAdelanto.Text = "Ingresar Adelanto"
        Me.btnAdelanto.UseVisualStyleBackColor = True
        Me.btnAdelanto.Visible = False
        '
        'txtAdelanto
        '
        Me.txtAdelanto.Location = New System.Drawing.Point(1008, 235)
        Me.txtAdelanto.Name = "txtAdelanto"
        Me.txtAdelanto.Size = New System.Drawing.Size(111, 20)
        Me.txtAdelanto.TabIndex = 50
        Me.txtAdelanto.Visible = False
        '
        'frmDomiciliacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 741)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAdelanto)
        Me.Controls.Add(Me.txtAdelanto)
        Me.Controls.Add(Me.rbNoBmer)
        Me.Controls.Add(Me.rbBmer)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.txtImpExt)
        Me.Controls.Add(Me.txtCte)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbSinAdeudo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbDeudor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.txtNvoImp)
        Me.Controls.Add(Me.btnLayOut)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblPagos)
        Me.Controls.Add(Me.lblSaldos)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpProcesar)
        Me.Name = "frmDomiciliacion"
        Me.Text = "Generación de Lay Out para Domiciliación"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpProcesar As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents lblPagos As System.Windows.Forms.Label
    Friend WithEvents lblSaldos As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnLayOut As System.Windows.Forms.Button
    Friend WithEvents txtNvoImp As System.Windows.Forms.TextBox
    Friend WithEvents btnModifica As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbDeudor As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbSinAdeudo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtCte As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents txtImpExt As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents rbBmer As System.Windows.Forms.RadioButton
    Friend WithEvents rbNoBmer As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAdelanto As System.Windows.Forms.Button
    Friend WithEvents txtAdelanto As System.Windows.Forms.TextBox

End Class
