<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgrupadorSAT
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContaDS = New Agil.ContaDS()
        Me.AgrupadorSATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgrupadorSATTableAdapter = New Agil.ContaDSTableAdapters.AgrupadorSATTableAdapter()
        Me.CuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgrupadorSATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CuentaDataGridViewTextBoxColumn, Me.NPRDataGridViewTextBoxColumn, Me.PRDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AgrupadorSATBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(373, 584)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(310, 602)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContaDS
        '
        Me.ContaDS.DataSetName = "ContaDS"
        Me.ContaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgrupadorSATBindingSource
        '
        Me.AgrupadorSATBindingSource.DataMember = "AgrupadorSAT"
        Me.AgrupadorSATBindingSource.DataSource = Me.ContaDS
        '
        'AgrupadorSATTableAdapter
        '
        Me.AgrupadorSATTableAdapter.ClearBeforeFill = True
        '
        'CuentaDataGridViewTextBoxColumn
        '
        Me.CuentaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta"
        Me.CuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta"
        Me.CuentaDataGridViewTextBoxColumn.Name = "CuentaDataGridViewTextBoxColumn"
        '
        'NPRDataGridViewTextBoxColumn
        '
        Me.NPRDataGridViewTextBoxColumn.DataPropertyName = "NPR"
        Me.NPRDataGridViewTextBoxColumn.HeaderText = "NPR"
        Me.NPRDataGridViewTextBoxColumn.Name = "NPRDataGridViewTextBoxColumn"
        '
        'PRDataGridViewTextBoxColumn
        '
        Me.PRDataGridViewTextBoxColumn.DataPropertyName = "PR"
        Me.PRDataGridViewTextBoxColumn.HeaderText = "PR"
        Me.PRDataGridViewTextBoxColumn.Name = "PRDataGridViewTextBoxColumn"
        '
        'FrmAgrupadorSAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 630)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmAgrupadorSAT"
        Me.Text = "Digito Agrupador SAT"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgrupadorSATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NPRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgrupadorSATBindingSource As BindingSource
    Friend WithEvents ContaDS As ContaDS
    Friend WithEvents Button1 As Button
    Friend WithEvents AgrupadorSATTableAdapter As ContaDSTableAdapters.AgrupadorSATTableAdapter
End Class
