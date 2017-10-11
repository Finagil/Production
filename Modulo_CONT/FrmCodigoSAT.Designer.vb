<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCodigoSAT
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GeneralDS = New Agil.GeneralDS()
        Me.GeneralDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosFinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosFinagilTableAdapter = New Agil.GeneralDSTableAdapters.ProductosFinagilTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TiparDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoSATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosFinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TiparDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn, Me.CodigoSATDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductosFinagilBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(449, 351)
        Me.DataGridView1.TabIndex = 0
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneralDSBindingSource
        '
        Me.GeneralDSBindingSource.DataSource = Me.GeneralDS
        Me.GeneralDSBindingSource.Position = 0
        '
        'ProductosFinagilBindingSource
        '
        Me.ProductosFinagilBindingSource.DataMember = "ProductosFinagil"
        Me.ProductosFinagilBindingSource.DataSource = Me.GeneralDSBindingSource
        '
        'ProductosFinagilTableAdapter
        '
        Me.ProductosFinagilTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(386, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TiparDataGridViewTextBoxColumn
        '
        Me.TiparDataGridViewTextBoxColumn.DataPropertyName = "Tipar"
        Me.TiparDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.TiparDataGridViewTextBoxColumn.Name = "TiparDataGridViewTextBoxColumn"
        Me.TiparDataGridViewTextBoxColumn.ReadOnly = True
        Me.TiparDataGridViewTextBoxColumn.Width = 50
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductoDataGridViewTextBoxColumn.Width = 200
        '
        'CodigoSATDataGridViewTextBoxColumn
        '
        Me.CodigoSATDataGridViewTextBoxColumn.DataPropertyName = "CodigoSAT"
        Me.CodigoSATDataGridViewTextBoxColumn.HeaderText = "CodigoSAT"
        Me.CodigoSATDataGridViewTextBoxColumn.Name = "CodigoSATDataGridViewTextBoxColumn"
        '
        'FrmCodigoSAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 398)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmCodigoSAT"
        Me.Text = "Codigo SAT por Producto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosFinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GeneralDSBindingSource As BindingSource
    Friend WithEvents GeneralDS As GeneralDS
    Friend WithEvents ProductosFinagilBindingSource As BindingSource
    Friend WithEvents ProductosFinagilTableAdapter As GeneralDSTableAdapters.ProductosFinagilTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents TiparDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoSATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
