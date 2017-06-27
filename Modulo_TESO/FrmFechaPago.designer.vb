<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFechaPago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextAnexo = New System.Windows.Forms.TextBox()
        Me.TextCliente = New System.Windows.Forms.TextBox()
        Me.GridFechas = New System.Windows.Forms.DataGridView()
        Me.DateFecha = New System.Windows.Forms.DateTimePicker()
        Me.ButtFecha = New System.Windows.Forms.Button()
        Me.TextAnexoX = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFecAct = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateFechaAct = New System.Windows.Forms.DateTimePicker()
        Me.TxtTipar = New System.Windows.Forms.TextBox()
        Me.TxtIVAeq = New System.Windows.Forms.TextBox()
        Me.TxtIvaAmorIn = New System.Windows.Forms.TextBox()
        Me.CheckAll = New System.Windows.Forms.CheckBox()
        Me.VwFechaPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New Agil.TesoreriaDS()
        Me.Vw_FechaPagosTableAdapter = New Agil.TesoreriaDSTableAdapters.Vw_FechaPagosTableAdapter()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteEquipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoFinanciadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaActivacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ivaeq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Iniciales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GridFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwFechaPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Anexo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'TextAnexo
        '
        Me.TextAnexo.Location = New System.Drawing.Point(25, 26)
        Me.TextAnexo.Name = "TextAnexo"
        Me.TextAnexo.Size = New System.Drawing.Size(100, 20)
        Me.TextAnexo.TabIndex = 2
        '
        'TextCliente
        '
        Me.TextCliente.Location = New System.Drawing.Point(137, 25)
        Me.TextCliente.Name = "TextCliente"
        Me.TextCliente.Size = New System.Drawing.Size(323, 20)
        Me.TextCliente.TabIndex = 3
        '
        'GridFechas
        '
        Me.GridFechas.AllowUserToAddRows = False
        Me.GridFechas.AllowUserToDeleteRows = False
        Me.GridFechas.AutoGenerateColumns = False
        Me.GridFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridFechas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.ImporteEquipoDataGridViewTextBoxColumn, Me.MontoFinanciadoDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn, Me.FechaActivacion, Me.Tipar, Me.Ivaeq, Me.Iniciales})
        Me.GridFechas.DataSource = Me.VwFechaPagosBindingSource
        Me.GridFechas.Location = New System.Drawing.Point(25, 52)
        Me.GridFechas.MultiSelect = False
        Me.GridFechas.Name = "GridFechas"
        Me.GridFechas.ReadOnly = True
        Me.GridFechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridFechas.Size = New System.Drawing.Size(802, 353)
        Me.GridFechas.TabIndex = 4
        '
        'DateFecha
        '
        Me.DateFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFecha.Location = New System.Drawing.Point(117, 428)
        Me.DateFecha.Name = "DateFecha"
        Me.DateFecha.Size = New System.Drawing.Size(100, 20)
        Me.DateFecha.TabIndex = 5
        '
        'ButtFecha
        '
        Me.ButtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtFecha.Location = New System.Drawing.Point(223, 425)
        Me.ButtFecha.Name = "ButtFecha"
        Me.ButtFecha.Size = New System.Drawing.Size(201, 23)
        Me.ButtFecha.TabIndex = 6
        Me.ButtFecha.Text = "Asignar Fechas (Pag. Act.)"
        Me.ButtFecha.UseVisualStyleBackColor = True
        '
        'TextAnexoX
        '
        Me.TextAnexoX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFechaPagosBindingSource, "Anexo", True))
        Me.TextAnexoX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAnexoX.Location = New System.Drawing.Point(25, 428)
        Me.TextAnexoX.Name = "TextAnexoX"
        Me.TextAnexoX.ReadOnly = True
        Me.TextAnexoX.Size = New System.Drawing.Size(86, 20)
        Me.TextAnexoX.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Anexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha Pago"
        '
        'TxtFecAct
        '
        Me.TxtFecAct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFechaPagosBindingSource, "FechaActivacion", True))
        Me.TxtFecAct.Enabled = False
        Me.TxtFecAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecAct.Location = New System.Drawing.Point(94, 342)
        Me.TxtFecAct.Name = "TxtFecAct"
        Me.TxtFecAct.ReadOnly = True
        Me.TxtFecAct.Size = New System.Drawing.Size(86, 20)
        Me.TxtFecAct.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(114, 453)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Fecha Activación"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(223, 470)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Asignar Solo Fecha Activación"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateFechaAct
        '
        Me.DateFechaAct.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaAct.Location = New System.Drawing.Point(117, 473)
        Me.DateFechaAct.Name = "DateFechaAct"
        Me.DateFechaAct.Size = New System.Drawing.Size(100, 20)
        Me.DateFechaAct.TabIndex = 11
        '
        'TxtTipar
        '
        Me.TxtTipar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFechaPagosBindingSource, "Tipar", True))
        Me.TxtTipar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipar.Location = New System.Drawing.Point(71, 297)
        Me.TxtTipar.Name = "TxtTipar"
        Me.TxtTipar.ReadOnly = True
        Me.TxtTipar.Size = New System.Drawing.Size(18, 20)
        Me.TxtTipar.TabIndex = 14
        '
        'TxtIVAeq
        '
        Me.TxtIVAeq.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFechaPagosBindingSource, "Ivaeq", True))
        Me.TxtIVAeq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIVAeq.Location = New System.Drawing.Point(46, 370)
        Me.TxtIVAeq.Name = "TxtIVAeq"
        Me.TxtIVAeq.ReadOnly = True
        Me.TxtIVAeq.Size = New System.Drawing.Size(18, 20)
        Me.TxtIVAeq.TabIndex = 15
        '
        'TxtIvaAmorIn
        '
        Me.TxtIvaAmorIn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFechaPagosBindingSource, "IvaAmorin", True))
        Me.TxtIvaAmorIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIvaAmorIn.Location = New System.Drawing.Point(223, 307)
        Me.TxtIvaAmorIn.Name = "TxtIvaAmorIn"
        Me.TxtIvaAmorIn.ReadOnly = True
        Me.TxtIvaAmorIn.Size = New System.Drawing.Size(18, 20)
        Me.TxtIvaAmorIn.TabIndex = 16
        '
        'CheckAll
        '
        Me.CheckAll.AutoSize = True
        Me.CheckAll.Location = New System.Drawing.Point(467, 26)
        Me.CheckAll.Name = "CheckAll"
        Me.CheckAll.Size = New System.Drawing.Size(56, 17)
        Me.CheckAll.TabIndex = 17
        Me.CheckAll.Text = "Todas"
        Me.CheckAll.UseVisualStyleBackColor = True
        '
        'VwFechaPagosBindingSource
        '
        Me.VwFechaPagosBindingSource.DataMember = "Vw_FechaPagos"
        Me.VwFechaPagosBindingSource.DataSource = Me.ProductionDataSet
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_FechaPagosTableAdapter
        '
        Me.Vw_FechaPagosTableAdapter.ClearBeforeFill = True
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 300
        '
        'ImporteEquipoDataGridViewTextBoxColumn
        '
        Me.ImporteEquipoDataGridViewTextBoxColumn.DataPropertyName = "Importe Equipo"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ImporteEquipoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ImporteEquipoDataGridViewTextBoxColumn.HeaderText = "Importe Equipo"
        Me.ImporteEquipoDataGridViewTextBoxColumn.Name = "ImporteEquipoDataGridViewTextBoxColumn"
        Me.ImporteEquipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoFinanciadoDataGridViewTextBoxColumn
        '
        Me.MontoFinanciadoDataGridViewTextBoxColumn.DataPropertyName = "Monto Financiado"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.MontoFinanciadoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.MontoFinanciadoDataGridViewTextBoxColumn.HeaderText = "Monto Financiado"
        Me.MontoFinanciadoDataGridViewTextBoxColumn.Name = "MontoFinanciadoDataGridViewTextBoxColumn"
        Me.MontoFinanciadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaPagoDataGridViewTextBoxColumn
        '
        Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Pago"
        Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "Fecha Pago"
        Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
        Me.FechaPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaPagoDataGridViewTextBoxColumn.Visible = False
        '
        'FechaActivacion
        '
        Me.FechaActivacion.DataPropertyName = "FechaActivacion"
        Me.FechaActivacion.HeaderText = "Fecha Activacion"
        Me.FechaActivacion.Name = "FechaActivacion"
        Me.FechaActivacion.ReadOnly = True
        Me.FechaActivacion.Width = 80
        '
        'Tipar
        '
        Me.Tipar.DataPropertyName = "Tipar"
        Me.Tipar.HeaderText = "Tipar"
        Me.Tipar.Name = "Tipar"
        Me.Tipar.ReadOnly = True
        Me.Tipar.Visible = False
        '
        'Ivaeq
        '
        Me.Ivaeq.DataPropertyName = "Ivaeq"
        Me.Ivaeq.HeaderText = "Ivaeq"
        Me.Ivaeq.Name = "Ivaeq"
        Me.Ivaeq.ReadOnly = True
        Me.Ivaeq.Visible = False
        '
        'Iniciales
        '
        Me.Iniciales.DataPropertyName = "Iniciales"
        Me.Iniciales.HeaderText = "Promotor"
        Me.Iniciales.Name = "Iniciales"
        Me.Iniciales.ReadOnly = True
        Me.Iniciales.Width = 70
        '
        'FrmFechaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 505)
        Me.Controls.Add(Me.CheckAll)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateFechaAct)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextAnexoX)
        Me.Controls.Add(Me.ButtFecha)
        Me.Controls.Add(Me.DateFecha)
        Me.Controls.Add(Me.GridFechas)
        Me.Controls.Add(Me.TextCliente)
        Me.Controls.Add(Me.TextAnexo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFecAct)
        Me.Controls.Add(Me.TxtIVAeq)
        Me.Controls.Add(Me.TxtTipar)
        Me.Controls.Add(Me.TxtIvaAmorIn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFechaPago"
        Me.Text = "Fechas de Pago"
        CType(Me.GridFechas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwFechaPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextAnexo As System.Windows.Forms.TextBox
    Friend WithEvents TextCliente As System.Windows.Forms.TextBox
    Friend WithEvents GridFechas As System.Windows.Forms.DataGridView
    Friend WithEvents ProductionDataSet As Agil.TesoreriaDS
    Friend WithEvents VwFechaPagosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_FechaPagosTableAdapter As Agil.TesoreriaDSTableAdapters.Vw_FechaPagosTableAdapter
    Friend WithEvents DateFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtFecha As System.Windows.Forms.Button
    Friend WithEvents TextAnexoX As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtFecAct As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateFechaAct As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtTipar As System.Windows.Forms.TextBox
    Friend WithEvents TxtIVAeq As System.Windows.Forms.TextBox
    Friend WithEvents TxtIvaAmorIn As System.Windows.Forms.TextBox
    Friend WithEvents CheckAll As CheckBox
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteEquipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoFinanciadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaActivacion As DataGridViewTextBoxColumn
    Friend WithEvents Tipar As DataGridViewTextBoxColumn
    Friend WithEvents Ivaeq As DataGridViewTextBoxColumn
    Friend WithEvents Iniciales As DataGridViewTextBoxColumn
End Class
