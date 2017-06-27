<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPromotores
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
        Me.ConsultasDS = New Agil.ConsultasDS()
        Me.PromotoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromotoresTableAdapter = New Agil.ConsultasDSTableAdapters.PromotoresTableAdapter()
        Me.PromotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescPromotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InicialesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusPromotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultasDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PromotorDataGridViewTextBoxColumn, Me.DescPromotorDataGridViewTextBoxColumn, Me.InicialesDataGridViewTextBoxColumn, Me.StatusPromotorDataGridViewTextBoxColumn, Me.Correo})
        Me.DataGridView1.DataSource = Me.PromotoresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(691, 414)
        Me.DataGridView1.TabIndex = 0
        '
        'ConsultasDS
        '
        Me.ConsultasDS.DataSetName = "ConsultasDS"
        Me.ConsultasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PromotoresBindingSource
        '
        Me.PromotoresBindingSource.DataMember = "Promotores"
        Me.PromotoresBindingSource.DataSource = Me.ConsultasDS
        '
        'PromotoresTableAdapter
        '
        Me.PromotoresTableAdapter.ClearBeforeFill = True
        '
        'PromotorDataGridViewTextBoxColumn
        '
        Me.PromotorDataGridViewTextBoxColumn.DataPropertyName = "Promotor"
        Me.PromotorDataGridViewTextBoxColumn.HeaderText = "No. Promotor"
        Me.PromotorDataGridViewTextBoxColumn.Name = "PromotorDataGridViewTextBoxColumn"
        Me.PromotorDataGridViewTextBoxColumn.ReadOnly = True
        Me.PromotorDataGridViewTextBoxColumn.Width = 60
        '
        'DescPromotorDataGridViewTextBoxColumn
        '
        Me.DescPromotorDataGridViewTextBoxColumn.DataPropertyName = "DescPromotor"
        Me.DescPromotorDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.DescPromotorDataGridViewTextBoxColumn.Name = "DescPromotorDataGridViewTextBoxColumn"
        Me.DescPromotorDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescPromotorDataGridViewTextBoxColumn.Width = 250
        '
        'InicialesDataGridViewTextBoxColumn
        '
        Me.InicialesDataGridViewTextBoxColumn.DataPropertyName = "Iniciales"
        Me.InicialesDataGridViewTextBoxColumn.HeaderText = "Iniciales"
        Me.InicialesDataGridViewTextBoxColumn.Name = "InicialesDataGridViewTextBoxColumn"
        Me.InicialesDataGridViewTextBoxColumn.ReadOnly = True
        Me.InicialesDataGridViewTextBoxColumn.Width = 50
        '
        'StatusPromotorDataGridViewTextBoxColumn
        '
        Me.StatusPromotorDataGridViewTextBoxColumn.DataPropertyName = "StatusPromotor"
        Me.StatusPromotorDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.StatusPromotorDataGridViewTextBoxColumn.Name = "StatusPromotorDataGridViewTextBoxColumn"
        Me.StatusPromotorDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusPromotorDataGridViewTextBoxColumn.Width = 50
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "Correo"
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        Me.Correo.Width = 200
        '
        'FrmPromotores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 438)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmPromotores"
        Me.Text = "Promotores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultasDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ConsultasDS As ConsultasDS
    Friend WithEvents PromotoresBindingSource As BindingSource
    Friend WithEvents PromotoresTableAdapter As ConsultasDSTableAdapters.PromotoresTableAdapter
    Friend WithEvents PromotorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescPromotorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InicialesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusPromotorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
End Class
