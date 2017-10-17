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
        Me.RBSinDefinir = New System.Windows.Forms.RadioButton()
        Me.RBactivos = New System.Windows.Forms.RadioButton()
        CType(Me.AnexosSinUsoCFDIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsosCFDIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Button1.Location = New System.Drawing.Point(778, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 10
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
        Me.CmbUsoCFDI.Size = New System.Drawing.Size(756, 21)
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
        Me.TextBox1.Location = New System.Drawing.Point(12, 326)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(859, 119)
        Me.TextBox1.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.CicloDataGridViewTextBoxColumn, Me.AnexoConDataGridViewTextBoxColumn, Me.CicloPagareDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn, Me.UsoCFDIDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AnexosSinUsoCFDIBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(859, 245)
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
        'RBSinDefinir
        '
        Me.RBSinDefinir.AutoSize = True
        Me.RBSinDefinir.Checked = True
        Me.RBSinDefinir.Location = New System.Drawing.Point(16, 8)
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
        Me.RBactivos.Location = New System.Drawing.Point(113, 8)
        Me.RBactivos.Name = "RBactivos"
        Me.RBactivos.Size = New System.Drawing.Size(108, 17)
        Me.RBactivos.TabIndex = 12
        Me.RBactivos.Text = "Contratos Activos"
        Me.RBactivos.UseVisualStyleBackColor = True
        '
        'FrmUsoCFDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 460)
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
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoConDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloPagareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsoCFDIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RBSinDefinir As RadioButton
    Friend WithEvents RBactivos As RadioButton
End Class
