<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGastosExtra
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCAD = New System.Windows.Forms.TextBox
        Me.CmbClientes = New System.Windows.Forms.ComboBox
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GastosDS = New Agil.GastosDS
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbAnexo = New System.Windows.Forms.ComboBox
        Me.VwAnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTFecha = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtImporte = New System.Windows.Forms.TextBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CONTGastosExtrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.ClientesTableAdapter = New Agil.GastosDSTableAdapters.ClientesTableAdapter
        Me.Vw_AnexosTableAdapter = New Agil.GastosDSTableAdapters.Vw_AnexosTableAdapter
        Me.CONT_GastosExtrasTableAdapter = New Agil.GastosDSTableAdapters.CONT_GastosExtrasTableAdapter
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtDescrip = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.IdgastoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PagadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwAnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTGastosExtrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'TxtCAD
        '
        Me.TxtCAD.Location = New System.Drawing.Point(15, 25)
        Me.TxtCAD.Name = "TxtCAD"
        Me.TxtCAD.Size = New System.Drawing.Size(194, 20)
        Me.TxtCAD.TabIndex = 1
        '
        'CmbClientes
        '
        Me.CmbClientes.DataSource = Me.ClientesBindingSource
        Me.CmbClientes.DisplayMember = "Descr"
        Me.CmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(15, 48)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(417, 21)
        Me.CmbClientes.TabIndex = 2
        Me.CmbClientes.ValueMember = "Cliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.GastosDS
        '
        'GastosDS
        '
        Me.GastosDS.DataSetName = "GastosDS"
        Me.GastosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contratos"
        '
        'CmbAnexo
        '
        Me.CmbAnexo.DataSource = Me.VwAnexosBindingSource
        Me.CmbAnexo.DisplayMember = "AnexoConFull"
        Me.CmbAnexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnexo.FormattingEnabled = True
        Me.CmbAnexo.Location = New System.Drawing.Point(15, 89)
        Me.CmbAnexo.Name = "CmbAnexo"
        Me.CmbAnexo.Size = New System.Drawing.Size(194, 21)
        Me.CmbAnexo.TabIndex = 4
        Me.CmbAnexo.ValueMember = "AnexoFull"
        '
        'VwAnexosBindingSource
        '
        Me.VwAnexosBindingSource.DataMember = "Vw_Anexos"
        Me.VwAnexosBindingSource.DataSource = Me.GastosDS
        '
        'DTFecha
        '
        Me.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFecha.Location = New System.Drawing.Point(14, 131)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(196, 20)
        Me.DTFecha.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Importe"
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(15, 213)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(94, 20)
        Me.TxtImporte.TabIndex = 7
        Me.TxtImporte.Text = "0.0"
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(115, 206)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(96, 27)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Agregar Gasto"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdgastoDataGridViewTextBoxColumn, Me.AnexoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.PagadoDataGridViewCheckBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CONTGastosExtrasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 237)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(634, 150)
        Me.DataGridView1.TabIndex = 10
        '
        'CONTGastosExtrasBindingSource
        '
        Me.CONTGastosExtrasBindingSource.DataMember = "CONT_GastosExtras"
        Me.CONTGastosExtrasBindingSource.DataSource = Me.GastosDS
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(555, 395)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(94, 20)
        Me.TxtTotal.TabIndex = 11
        Me.TxtTotal.Text = "0.0"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(453, 395)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(96, 35)
        Me.BtnSave.TabIndex = 13
        Me.BtnSave.Text = "Guardar Cambios"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Vw_AnexosTableAdapter
        '
        Me.Vw_AnexosTableAdapter.ClearBeforeFill = True
        '
        'CONT_GastosExtrasTableAdapter
        '
        Me.CONT_GastosExtrasTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Descripción"
        '
        'TxtDescrip
        '
        Me.TxtDescrip.Location = New System.Drawing.Point(15, 172)
        Me.TxtDescrip.MaxLength = 50
        Me.TxtDescrip.Name = "TxtDescrip"
        Me.TxtDescrip.Size = New System.Drawing.Size(417, 20)
        Me.TxtDescrip.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwAnexosBindingSource, "TipoCredito", True))
        Me.Label6.Location = New System.Drawing.Point(215, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Tipo Crédito"
        '
        'Label7
        '
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwAnexosBindingSource, "Status", True))
        Me.Label7.Location = New System.Drawing.Point(101, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 14)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Status"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdgastoDataGridViewTextBoxColumn
        '
        Me.IdgastoDataGridViewTextBoxColumn.DataPropertyName = "id_gasto"
        Me.IdgastoDataGridViewTextBoxColumn.HeaderText = "id_gasto"
        Me.IdgastoDataGridViewTextBoxColumn.Name = "IdgastoDataGridViewTextBoxColumn"
        Me.IdgastoDataGridViewTextBoxColumn.Visible = False
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.Width = 200
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 80
        '
        'PagadoDataGridViewCheckBoxColumn
        '
        Me.PagadoDataGridViewCheckBoxColumn.DataPropertyName = "Pagado"
        Me.PagadoDataGridViewCheckBoxColumn.HeaderText = "Pagado"
        Me.PagadoDataGridViewCheckBoxColumn.Name = "PagadoDataGridViewCheckBoxColumn"
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.Visible = False
        '
        'FrmGastosExtra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 433)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtDescrip)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtImporte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTFecha)
        Me.Controls.Add(Me.CmbAnexo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbClientes)
        Me.Controls.Add(Me.TxtCAD)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmGastosExtra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura de Gastos Extraordinarios"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwAnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTGastosExtrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCAD As System.Windows.Forms.TextBox
    Friend WithEvents CmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbAnexo As System.Windows.Forms.ComboBox
    Friend WithEvents DTFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GastosDS As Agil.GastosDS
    Friend WithEvents VwAnexosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Agil.GastosDSTableAdapters.ClientesTableAdapter
    Friend WithEvents Vw_AnexosTableAdapter As Agil.GastosDSTableAdapters.Vw_AnexosTableAdapter
    Friend WithEvents CONTGastosExtrasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_GastosExtrasTableAdapter As Agil.GastosDSTableAdapters.CONT_GastosExtrasTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IdgastoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
