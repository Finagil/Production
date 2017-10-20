<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsoCFDI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.AnexosSinUsoCFDIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContaDS = New Agil.ContaDS()
        Me.UsosCFDIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexosSinUsoCFDITableAdapter = New Agil.ContaDSTableAdapters.AnexosSinUsoCFDITableAdapter()
        Me.UsosCFDITableAdapter = New Agil.ContaDSTableAdapters.UsosCFDITableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CmbUsoCFDI = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloPagareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsoCFDIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RBSinDefinir = New System.Windows.Forms.RadioButton()
        Me.RBactivos = New System.Windows.Forms.RadioButton()
        Me.CmbProduct = New System.Windows.Forms.ComboBox()
        Me.ProductosFinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductosFinagilTableAdapter = New Agil.GeneralDSTableAdapters.ProductosFinagilTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbDivision = New System.Windows.Forms.ComboBox()
        Me.CFDIDivisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbGrupo = New System.Windows.Forms.ComboBox()
        Me.CFDIGrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbClase = New System.Windows.Forms.ComboBox()
        Me.CFDIClaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbClave = New System.Windows.Forms.ComboBox()
        Me.CFDIClaveProsServBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CFDI_DivisionTableAdapter = New Agil.ContaDSTableAdapters.CFDI_DivisionTableAdapter()
        Me.CFDI_GrupoTableAdapter = New Agil.ContaDSTableAdapters.CFDI_GrupoTableAdapter()
        Me.CFDI_ClaseTableAdapter = New Agil.ContaDSTableAdapters.CFDI_ClaseTableAdapter()
        Me.CFDI_ClaveProsServTableAdapter = New Agil.ContaDSTableAdapters.CFDI_ClaveProsServTableAdapter()
        CType(Me.AnexosSinUsoCFDIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsosCFDIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosFinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDIDivisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDIGrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDIClaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDIClaveProsServBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnexosSinUsoCFDIBindingSource
        '
        Me.AnexosSinUsoCFDIBindingSource.DataMember = "AnexosSinUsoCFDI"
        Me.AnexosSinUsoCFDIBindingSource.DataSource = Me.ContaDS
        '
        'ContaDS
        '
        Me.ContaDS.DataSetName = "ContaDS"
        Me.ContaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsosCFDIBindingSource
        '
        Me.UsosCFDIBindingSource.DataMember = "UsosCFDI"
        Me.UsosCFDIBindingSource.DataSource = Me.ContaDS
        '
        'AnexosSinUsoCFDITableAdapter
        '
        Me.AnexosSinUsoCFDITableAdapter.ClearBeforeFill = True
        '
        'UsosCFDITableAdapter
        '
        Me.UsosCFDITableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(838, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Guardar "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CmbUsoCFDI
        '
        Me.CmbUsoCFDI.DataSource = Me.UsosCFDIBindingSource
        Me.CmbUsoCFDI.DisplayMember = "Descripcion"
        Me.CmbUsoCFDI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUsoCFDI.FormattingEnabled = True
        Me.CmbUsoCFDI.Location = New System.Drawing.Point(16, 299)
        Me.CmbUsoCFDI.Name = "CmbUsoCFDI"
        Me.CmbUsoCFDI.Size = New System.Drawing.Size(816, 21)
        Me.CmbUsoCFDI.TabIndex = 9
        Me.CmbUsoCFDI.ValueMember = "UsoCFDI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Uso CFDI"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 408)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(922, 90)
        Me.TextBox1.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.CicloDataGridViewTextBoxColumn, Me.AnexoConDataGridViewTextBoxColumn, Me.CicloPagareDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn, Me.UsoCFDIDataGridViewTextBoxColumn, Me.Codigo})
        Me.DataGridView1.DataSource = Me.AnexosSinUsoCFDIBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(922, 233)
        Me.DataGridView1.TabIndex = 6
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Visible = False
        '
        'CicloDataGridViewTextBoxColumn
        '
        Me.CicloDataGridViewTextBoxColumn.DataPropertyName = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.HeaderText = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.Name = "CicloDataGridViewTextBoxColumn"
        Me.CicloDataGridViewTextBoxColumn.ReadOnly = True
        Me.CicloDataGridViewTextBoxColumn.Visible = False
        '
        'AnexoConDataGridViewTextBoxColumn
        '
        Me.AnexoConDataGridViewTextBoxColumn.DataPropertyName = "AnexoCon"
        Me.AnexoConDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoConDataGridViewTextBoxColumn.Name = "AnexoConDataGridViewTextBoxColumn"
        Me.AnexoConDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoConDataGridViewTextBoxColumn.Width = 80
        '
        'CicloPagareDataGridViewTextBoxColumn
        '
        Me.CicloPagareDataGridViewTextBoxColumn.DataPropertyName = "CicloPagare"
        Me.CicloPagareDataGridViewTextBoxColumn.HeaderText = "Ciclo Pagare"
        Me.CicloPagareDataGridViewTextBoxColumn.Name = "CicloPagareDataGridViewTextBoxColumn"
        Me.CicloPagareDataGridViewTextBoxColumn.ReadOnly = True
        Me.CicloPagareDataGridViewTextBoxColumn.Width = 80
        '
        'DescrDataGridViewTextBoxColumn
        '
        Me.DescrDataGridViewTextBoxColumn.DataPropertyName = "Descr"
        Me.DescrDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.DescrDataGridViewTextBoxColumn.Name = "DescrDataGridViewTextBoxColumn"
        Me.DescrDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescrDataGridViewTextBoxColumn.Width = 300
        '
        'TipoCreditoDataGridViewTextBoxColumn
        '
        Me.TipoCreditoDataGridViewTextBoxColumn.DataPropertyName = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "Tipo Credito"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCreditoDataGridViewTextBoxColumn.Width = 200
        '
        'UsoCFDIDataGridViewTextBoxColumn
        '
        Me.UsoCFDIDataGridViewTextBoxColumn.DataPropertyName = "UsoCFDI"
        Me.UsoCFDIDataGridViewTextBoxColumn.HeaderText = "Uso CFDI"
        Me.UsoCFDIDataGridViewTextBoxColumn.Name = "UsoCFDIDataGridViewTextBoxColumn"
        Me.UsoCFDIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo Art."
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'RBSinDefinir
        '
        Me.RBSinDefinir.AutoSize = True
        Me.RBSinDefinir.Checked = True
        Me.RBSinDefinir.Location = New System.Drawing.Point(260, 22)
        Me.RBSinDefinir.Name = "RBSinDefinir"
        Me.RBSinDefinir.Size = New System.Drawing.Size(89, 17)
        Me.RBSinDefinir.TabIndex = 11
        Me.RBSinDefinir.TabStop = True
        Me.RBSinDefinir.Text = "Sin Uso CFDI"
        Me.RBSinDefinir.UseVisualStyleBackColor = True
        '
        'RBactivos
        '
        Me.RBactivos.AutoSize = True
        Me.RBactivos.Location = New System.Drawing.Point(355, 22)
        Me.RBactivos.Name = "RBactivos"
        Me.RBactivos.Size = New System.Drawing.Size(119, 17)
        Me.RBactivos.TabIndex = 12
        Me.RBactivos.Text = "Todos los Contratos"
        Me.RBactivos.UseVisualStyleBackColor = True
        '
        'CmbProduct
        '
        Me.CmbProduct.DataSource = Me.ProductosFinagilBindingSource
        Me.CmbProduct.DisplayMember = "Producto"
        Me.CmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProduct.FormattingEnabled = True
        Me.CmbProduct.Location = New System.Drawing.Point(16, 18)
        Me.CmbProduct.Name = "CmbProduct"
        Me.CmbProduct.Size = New System.Drawing.Size(238, 21)
        Me.CmbProduct.TabIndex = 14
        Me.CmbProduct.ValueMember = "Tipar"
        '
        'ProductosFinagilBindingSource
        '
        Me.ProductosFinagilBindingSource.DataMember = "ProductosFinagil"
        Me.ProductosFinagilBindingSource.DataSource = Me.GeneralDS
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Producto"
        '
        'ProductosFinagilTableAdapter
        '
        Me.ProductosFinagilTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Division"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Grupo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(486, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Clase"
        '
        'CmbDivision
        '
        Me.CmbDivision.DataSource = Me.CFDIDivisionBindingSource
        Me.CmbDivision.DisplayMember = "Division"
        Me.CmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDivision.FormattingEnabled = True
        Me.CmbDivision.Location = New System.Drawing.Point(16, 340)
        Me.CmbDivision.Name = "CmbDivision"
        Me.CmbDivision.Size = New System.Drawing.Size(109, 21)
        Me.CmbDivision.TabIndex = 10
        Me.CmbDivision.ValueMember = "Division"
        '
        'CFDIDivisionBindingSource
        '
        Me.CFDIDivisionBindingSource.DataMember = "CFDI_Division"
        Me.CFDIDivisionBindingSource.DataSource = Me.ContaDS
        '
        'CmbGrupo
        '
        Me.CmbGrupo.DataSource = Me.CFDIGrupoBindingSource
        Me.CmbGrupo.DisplayMember = "Grupo"
        Me.CmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGrupo.FormattingEnabled = True
        Me.CmbGrupo.Location = New System.Drawing.Point(131, 340)
        Me.CmbGrupo.Name = "CmbGrupo"
        Me.CmbGrupo.Size = New System.Drawing.Size(352, 21)
        Me.CmbGrupo.TabIndex = 11
        Me.CmbGrupo.ValueMember = "Grupo"
        '
        'CFDIGrupoBindingSource
        '
        Me.CFDIGrupoBindingSource.DataMember = "CFDI_Grupo"
        Me.CFDIGrupoBindingSource.DataSource = Me.ContaDS
        '
        'CmbClase
        '
        Me.CmbClase.DataSource = Me.CFDIClaseBindingSource
        Me.CmbClase.DisplayMember = "Clase"
        Me.CmbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClase.FormattingEnabled = True
        Me.CmbClase.Location = New System.Drawing.Point(489, 340)
        Me.CmbClase.Name = "CmbClase"
        Me.CmbClase.Size = New System.Drawing.Size(442, 21)
        Me.CmbClase.TabIndex = 12
        Me.CmbClase.ValueMember = "Clase"
        '
        'CFDIClaseBindingSource
        '
        Me.CFDIClaseBindingSource.DataMember = "CFDI_Clase"
        Me.CFDIClaseBindingSource.DataSource = Me.ContaDS
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Descripción"
        '
        'CmbClave
        '
        Me.CmbClave.DataSource = Me.CFDIClaveProsServBindingSource
        Me.CmbClave.DisplayMember = "Descripcion"
        Me.CmbClave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClave.FormattingEnabled = True
        Me.CmbClave.Location = New System.Drawing.Point(16, 381)
        Me.CmbClave.Name = "CmbClave"
        Me.CmbClave.Size = New System.Drawing.Size(915, 21)
        Me.CmbClave.TabIndex = 13
        Me.CmbClave.ValueMember = "Clave"
        '
        'CFDIClaveProsServBindingSource
        '
        Me.CFDIClaveProsServBindingSource.DataMember = "CFDI_ClaveProsServ"
        Me.CFDIClaveProsServBindingSource.DataSource = Me.ContaDS
        '
        'CFDI_DivisionTableAdapter
        '
        Me.CFDI_DivisionTableAdapter.ClearBeforeFill = True
        '
        'CFDI_GrupoTableAdapter
        '
        Me.CFDI_GrupoTableAdapter.ClearBeforeFill = True
        '
        'CFDI_ClaseTableAdapter
        '
        Me.CFDI_ClaseTableAdapter.ClearBeforeFill = True
        '
        'CFDI_ClaveProsServTableAdapter
        '
        Me.CFDI_ClaveProsServTableAdapter.ClearBeforeFill = True
        '
        'FrmUsoCFDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 505)
        Me.Controls.Add(Me.CmbClave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbClase)
        Me.Controls.Add(Me.CmbGrupo)
        Me.Controls.Add(Me.CmbDivision)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbProduct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RBactivos)
        Me.Controls.Add(Me.RBSinDefinir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmbUsoCFDI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmUsoCFDI"
        Me.Text = "Uso CFDI por contrato"
        CType(Me.AnexosSinUsoCFDIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsosCFDIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosFinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDIDivisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDIGrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDIClaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDIClaveProsServBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContaDS As ContaDS
    Friend WithEvents AnexosSinUsoCFDIBindingSource As BindingSource
    Friend WithEvents AnexosSinUsoCFDITableAdapter As ContaDSTableAdapters.AnexosSinUsoCFDITableAdapter
    Friend WithEvents UsosCFDIBindingSource As BindingSource
    Friend WithEvents UsosCFDITableAdapter As ContaDSTableAdapters.UsosCFDITableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents CmbUsoCFDI As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RBSinDefinir As RadioButton
    Friend WithEvents RBactivos As RadioButton
    Friend WithEvents CmbProduct As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GeneralDS As GeneralDS
    Friend WithEvents ProductosFinagilBindingSource As BindingSource
    Friend WithEvents ProductosFinagilTableAdapter As GeneralDSTableAdapters.ProductosFinagilTableAdapter
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoConDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloPagareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsoCFDIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbDivision As ComboBox
    Friend WithEvents CmbGrupo As ComboBox
    Friend WithEvents CmbClase As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbClave As ComboBox
    Friend WithEvents CFDIDivisionBindingSource As BindingSource
    Friend WithEvents CFDI_DivisionTableAdapter As ContaDSTableAdapters.CFDI_DivisionTableAdapter
    Friend WithEvents CFDIGrupoBindingSource As BindingSource
    Friend WithEvents CFDIClaseBindingSource As BindingSource
    Friend WithEvents CFDIClaveProsServBindingSource As BindingSource
    Friend WithEvents CFDI_GrupoTableAdapter As ContaDSTableAdapters.CFDI_GrupoTableAdapter
    Friend WithEvents CFDI_ClaseTableAdapter As ContaDSTableAdapters.CFDI_ClaseTableAdapter
    Friend WithEvents CFDI_ClaveProsServTableAdapter As ContaDSTableAdapters.CFDI_ClaveProsServTableAdapter
End Class
