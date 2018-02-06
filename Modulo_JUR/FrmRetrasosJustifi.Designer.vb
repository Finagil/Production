<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRetrasosJustifi
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
        Me.BuroDS = New Agil.BuroDS()
        Me.RetrasosJustificadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RetrasosJustificadosTableAdapter1 = New Agil.BuroDSTableAdapters.RetrasosJustificadosTableAdapter()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloLetraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuroDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetrasosJustificadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.CicloLetraDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RetrasosJustificadosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(501, 273)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(437, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BuroDS
        '
        Me.BuroDS.DataSetName = "BuroDS"
        Me.BuroDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RetrasosJustificadosBindingSource
        '
        Me.RetrasosJustificadosBindingSource.DataMember = "RetrasosJustificados"
        Me.RetrasosJustificadosBindingSource.DataSource = Me.BuroDS
        '
        'RetrasosJustificadosTableAdapter1
        '
        Me.RetrasosJustificadosTableAdapter1.ClearBeforeFill = True
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.MaxInputLength = 9
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        '
        'CicloLetraDataGridViewTextBoxColumn
        '
        Me.CicloLetraDataGridViewTextBoxColumn.DataPropertyName = "CicloLetra"
        Me.CicloLetraDataGridViewTextBoxColumn.HeaderText = "CicloLetra"
        Me.CicloLetraDataGridViewTextBoxColumn.MaxInputLength = 3
        Me.CicloLetraDataGridViewTextBoxColumn.Name = "CicloLetraDataGridViewTextBoxColumn"
        '
        'FechaPagoDataGridViewTextBoxColumn
        '
        Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago"
        Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago"
        Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.MaxInputLength = 20
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmRetrasosJustifi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 323)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmRetrasosJustifi"
        Me.Text = "Retrasos Justificados para Buró de Crédito"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuroDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetrasosJustificadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RetrasosJustificadosTableAdapter As BuroDSTableAdapters.RetrasosJustificadosTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents BuroDS As BuroDS
    Friend WithEvents RetrasosJustificadosBindingSource As BindingSource
    Friend WithEvents RetrasosJustificadosTableAdapter1 As BuroDSTableAdapters.RetrasosJustificadosTableAdapter
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloLetraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
