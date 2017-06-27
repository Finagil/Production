<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatalogos
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IdAseguradoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AseguradoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEGAseguradorasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.IdCultivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CultivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEGCultivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BttAltaNew = New System.Windows.Forms.Button
        Me.SEG_AseguradorasTableAdapter = New Agil.SegurosDSTableAdapters.SEG_AseguradorasTableAdapter
        Me.GEN_CultivosTableAdapter = New Agil.SegurosDSTableAdapters.GEN_CultivosTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGCultivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAseguradoraDataGridViewTextBoxColumn, Me.AseguradoraDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SEGAseguradorasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(459, 209)
        Me.DataGridView1.TabIndex = 0
        '
        'IdAseguradoraDataGridViewTextBoxColumn
        '
        Me.IdAseguradoraDataGridViewTextBoxColumn.DataPropertyName = "IdAseguradora"
        Me.IdAseguradoraDataGridViewTextBoxColumn.HeaderText = "IdAseguradora"
        Me.IdAseguradoraDataGridViewTextBoxColumn.Name = "IdAseguradoraDataGridViewTextBoxColumn"
        Me.IdAseguradoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAseguradoraDataGridViewTextBoxColumn.Visible = False
        '
        'AseguradoraDataGridViewTextBoxColumn
        '
        Me.AseguradoraDataGridViewTextBoxColumn.DataPropertyName = "Aseguradora"
        Me.AseguradoraDataGridViewTextBoxColumn.HeaderText = "Aseguradora"
        Me.AseguradoraDataGridViewTextBoxColumn.MaxInputLength = 50
        Me.AseguradoraDataGridViewTextBoxColumn.Name = "AseguradoraDataGridViewTextBoxColumn"
        Me.AseguradoraDataGridViewTextBoxColumn.Width = 400
        '
        'SEGAseguradorasBindingSource
        '
        Me.SEGAseguradorasBindingSource.DataMember = "SEG_Aseguradoras"
        Me.SEGAseguradorasBindingSource.DataSource = Me.SegurosDS
        '
        'SegurosDS
        '
        Me.SegurosDS.DataSetName = "SegurosDS"
        Me.SegurosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCultivoDataGridViewTextBoxColumn, Me.CultivoDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.SEGCultivosBindingSource
        Me.DataGridView2.Enabled = False
        Me.DataGridView2.Location = New System.Drawing.Point(11, 227)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(459, 209)
        Me.DataGridView2.TabIndex = 1
        '
        'IdCultivoDataGridViewTextBoxColumn
        '
        Me.IdCultivoDataGridViewTextBoxColumn.DataPropertyName = "idCultivo"
        Me.IdCultivoDataGridViewTextBoxColumn.HeaderText = "idCultivo"
        Me.IdCultivoDataGridViewTextBoxColumn.Name = "IdCultivoDataGridViewTextBoxColumn"
        Me.IdCultivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCultivoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdCultivoDataGridViewTextBoxColumn.Visible = False
        '
        'CultivoDataGridViewTextBoxColumn
        '
        Me.CultivoDataGridViewTextBoxColumn.DataPropertyName = "Cultivo"
        Me.CultivoDataGridViewTextBoxColumn.HeaderText = "Cultivo"
        Me.CultivoDataGridViewTextBoxColumn.MaxInputLength = 20
        Me.CultivoDataGridViewTextBoxColumn.Name = "CultivoDataGridViewTextBoxColumn"
        Me.CultivoDataGridViewTextBoxColumn.Width = 300
        '
        'SEGCultivosBindingSource
        '
        Me.SEGCultivosBindingSource.DataMember = "GEN_Cultivos"
        Me.SEGCultivosBindingSource.DataSource = Me.SegurosDS
        '
        'BttAltaNew
        '
        Me.BttAltaNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttAltaNew.Location = New System.Drawing.Point(377, 442)
        Me.BttAltaNew.Name = "BttAltaNew"
        Me.BttAltaNew.Size = New System.Drawing.Size(93, 34)
        Me.BttAltaNew.TabIndex = 95
        Me.BttAltaNew.Text = "Guadar Datos"
        Me.BttAltaNew.UseVisualStyleBackColor = True
        '
        'SEG_AseguradorasTableAdapter
        '
        Me.SEG_AseguradorasTableAdapter.ClearBeforeFill = True
        '
        'GEN_CultivosTableAdapter
        '
        Me.GEN_CultivosTableAdapter.ClearBeforeFill = True
        '
        'FrmCatalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 479)
        Me.Controls.Add(Me.BttAltaNew)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmCatalogos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aseguradores y Cultivos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGCultivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SegurosDS As Agil.SegurosDS
    Friend WithEvents SEGAseguradorasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEG_AseguradorasTableAdapter As Agil.SegurosDSTableAdapters.SEG_AseguradorasTableAdapter
    Friend WithEvents IdAseguradoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AseguradoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents SEGCultivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GEN_CultivosTableAdapter As Agil.SegurosDSTableAdapters.GEN_CultivosTableAdapter
    Friend WithEvents IdCultivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CultivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BttAltaNew As System.Windows.Forms.Button
End Class
