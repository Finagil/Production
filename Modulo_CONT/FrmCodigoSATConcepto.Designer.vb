<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCodigoSATConcepto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbProduct = New System.Windows.Forms.ComboBox()
        Me.ProductosFinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS()
        Me.ProductosFinagilTableAdapter = New Agil.GeneralDSTableAdapters.ProductosFinagilTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdCodigoSATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiparDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdendaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CodigosSATConceptoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContaDS = New Agil.ContaDS()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CodigosSAT_ConceptoTableAdapter = New Agil.ContaDSTableAdapters.CodigosSAT_ConceptoTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ProductosFinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosSATConceptoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto"
        '
        'CmbProduct
        '
        Me.CmbProduct.DataSource = Me.ProductosFinagilBindingSource
        Me.CmbProduct.DisplayMember = "Producto"
        Me.CmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProduct.FormattingEnabled = True
        Me.CmbProduct.Location = New System.Drawing.Point(13, 26)
        Me.CmbProduct.Name = "CmbProduct"
        Me.CmbProduct.Size = New System.Drawing.Size(238, 21)
        Me.CmbProduct.TabIndex = 1
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
        'ProductosFinagilTableAdapter
        '
        Me.ProductosFinagilTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCodigoSATDataGridViewTextBoxColumn, Me.TiparDataGridViewTextBoxColumn, Me.ConceptoDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.UnidadDataGridViewTextBoxColumn, Me.AdendaDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.CodigosSATConceptoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(640, 477)
        Me.DataGridView1.TabIndex = 2
        '
        'IdCodigoSATDataGridViewTextBoxColumn
        '
        Me.IdCodigoSATDataGridViewTextBoxColumn.DataPropertyName = "id_CodigoSAT"
        Me.IdCodigoSATDataGridViewTextBoxColumn.HeaderText = "id_CodigoSAT"
        Me.IdCodigoSATDataGridViewTextBoxColumn.Name = "IdCodigoSATDataGridViewTextBoxColumn"
        Me.IdCodigoSATDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCodigoSATDataGridViewTextBoxColumn.Visible = False
        '
        'TiparDataGridViewTextBoxColumn
        '
        Me.TiparDataGridViewTextBoxColumn.DataPropertyName = "Tipar"
        Me.TiparDataGridViewTextBoxColumn.HeaderText = "Tipar"
        Me.TiparDataGridViewTextBoxColumn.Name = "TiparDataGridViewTextBoxColumn"
        Me.TiparDataGridViewTextBoxColumn.Visible = False
        '
        'ConceptoDataGridViewTextBoxColumn
        '
        Me.ConceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.HeaderText = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.Name = "ConceptoDataGridViewTextBoxColumn"
        Me.ConceptoDataGridViewTextBoxColumn.Width = 250
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        '
        'AdendaDataGridViewCheckBoxColumn
        '
        Me.AdendaDataGridViewCheckBoxColumn.DataPropertyName = "Adenda"
        Me.AdendaDataGridViewCheckBoxColumn.HeaderText = "Adenda"
        Me.AdendaDataGridViewCheckBoxColumn.Name = "AdendaDataGridViewCheckBoxColumn"
        '
        'CodigosSATConceptoBindingSource
        '
        Me.CodigosSATConceptoBindingSource.DataMember = "CodigosSAT_Concepto"
        Me.CodigosSATConceptoBindingSource.DataSource = Me.ContaDS
        '
        'ContaDS
        '
        Me.ContaDS.DataSetName = "ContaDS"
        Me.ContaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Conceptos"
        '
        'CodigosSAT_ConceptoTableAdapter
        '
        Me.CodigosSAT_ConceptoTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(578, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmCodigoSATConcepto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 561)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmbProduct)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCodigoSATConcepto"
        Me.Text = "Código SAT por Producto y Concepto"
        CType(Me.ProductosFinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosSATConceptoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CmbProduct As ComboBox
    Friend WithEvents GeneralDS As GeneralDS
    Friend WithEvents ProductosFinagilBindingSource As BindingSource
    Friend WithEvents ProductosFinagilTableAdapter As GeneralDSTableAdapters.ProductosFinagilTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents IdCodigoSATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiparDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdendaDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CodigosSATConceptoBindingSource As BindingSource
    Friend WithEvents ContaDS As ContaDS
    Friend WithEvents CodigosSAT_ConceptoTableAdapter As ContaDSTableAdapters.CodigosSAT_ConceptoTableAdapter
    Friend WithEvents Button1 As Button
End Class
