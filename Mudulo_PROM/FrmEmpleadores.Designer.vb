<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleadores
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
        Me.PromocionDS = New Agil.PromocionDS()
        Me.GENEmpleadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEN_EmpleadoresTableAdapter = New Agil.PromocionDSTableAdapters.GEN_EmpleadoresTableAdapter()
        Me.IdEmpleadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelegacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoposDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumTelefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtTelefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumFaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GENEmpleadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleadorDataGridViewTextBoxColumn, Me.EmpleadorDataGridViewTextBoxColumn, Me.Calle1DataGridViewTextBoxColumn, Me.Calle2DataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.DelegacionDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.CoposDataGridViewTextBoxColumn, Me.NumTelefDataGridViewTextBoxColumn, Me.ExtTelefDataGridViewTextBoxColumn, Me.NumFaxDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GENEmpleadoresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(775, 405)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Guardar Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GENEmpleadoresBindingSource
        '
        Me.GENEmpleadoresBindingSource.DataMember = "GEN_Empleadores"
        Me.GENEmpleadoresBindingSource.DataSource = Me.PromocionDS
        '
        'GEN_EmpleadoresTableAdapter
        '
        Me.GEN_EmpleadoresTableAdapter.ClearBeforeFill = True
        '
        'IdEmpleadorDataGridViewTextBoxColumn
        '
        Me.IdEmpleadorDataGridViewTextBoxColumn.DataPropertyName = "id_Empleador"
        Me.IdEmpleadorDataGridViewTextBoxColumn.HeaderText = "id_Empleador"
        Me.IdEmpleadorDataGridViewTextBoxColumn.Name = "IdEmpleadorDataGridViewTextBoxColumn"
        Me.IdEmpleadorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEmpleadorDataGridViewTextBoxColumn.Visible = False
        '
        'EmpleadorDataGridViewTextBoxColumn
        '
        Me.EmpleadorDataGridViewTextBoxColumn.DataPropertyName = "Empleador"
        Me.EmpleadorDataGridViewTextBoxColumn.HeaderText = "Empleador"
        Me.EmpleadorDataGridViewTextBoxColumn.Name = "EmpleadorDataGridViewTextBoxColumn"
        Me.EmpleadorDataGridViewTextBoxColumn.Width = 200
        '
        'Calle1DataGridViewTextBoxColumn
        '
        Me.Calle1DataGridViewTextBoxColumn.DataPropertyName = "Calle1"
        Me.Calle1DataGridViewTextBoxColumn.HeaderText = "Calle1"
        Me.Calle1DataGridViewTextBoxColumn.Name = "Calle1DataGridViewTextBoxColumn"
        Me.Calle1DataGridViewTextBoxColumn.Width = 150
        '
        'Calle2DataGridViewTextBoxColumn
        '
        Me.Calle2DataGridViewTextBoxColumn.DataPropertyName = "Calle2"
        Me.Calle2DataGridViewTextBoxColumn.HeaderText = "Calle2"
        Me.Calle2DataGridViewTextBoxColumn.Name = "Calle2DataGridViewTextBoxColumn"
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        '
        'DelegacionDataGridViewTextBoxColumn
        '
        Me.DelegacionDataGridViewTextBoxColumn.DataPropertyName = "Delegacion"
        Me.DelegacionDataGridViewTextBoxColumn.HeaderText = "Delegacion"
        Me.DelegacionDataGridViewTextBoxColumn.Name = "DelegacionDataGridViewTextBoxColumn"
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        '
        'CoposDataGridViewTextBoxColumn
        '
        Me.CoposDataGridViewTextBoxColumn.DataPropertyName = "Copos"
        Me.CoposDataGridViewTextBoxColumn.HeaderText = "C.P."
        Me.CoposDataGridViewTextBoxColumn.Name = "CoposDataGridViewTextBoxColumn"
        '
        'NumTelefDataGridViewTextBoxColumn
        '
        Me.NumTelefDataGridViewTextBoxColumn.DataPropertyName = "NumTelef"
        Me.NumTelefDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.NumTelefDataGridViewTextBoxColumn.Name = "NumTelefDataGridViewTextBoxColumn"
        '
        'ExtTelefDataGridViewTextBoxColumn
        '
        Me.ExtTelefDataGridViewTextBoxColumn.DataPropertyName = "ExtTelef"
        Me.ExtTelefDataGridViewTextBoxColumn.HeaderText = "Extensión"
        Me.ExtTelefDataGridViewTextBoxColumn.Name = "ExtTelefDataGridViewTextBoxColumn"
        '
        'NumFaxDataGridViewTextBoxColumn
        '
        Me.NumFaxDataGridViewTextBoxColumn.DataPropertyName = "NumFax"
        Me.NumFaxDataGridViewTextBoxColumn.HeaderText = "Fax"
        Me.NumFaxDataGridViewTextBoxColumn.Name = "NumFaxDataGridViewTextBoxColumn"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Seleccionar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmEmpleadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmEmpleadores"
        Me.Text = "Empleadores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GENEmpleadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents PromocionDS As PromocionDS
    Friend WithEvents GENEmpleadoresBindingSource As BindingSource
    Friend WithEvents GEN_EmpleadoresTableAdapter As PromocionDSTableAdapters.GEN_EmpleadoresTableAdapter
    Friend WithEvents IdEmpleadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Calle1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Calle2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DelegacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoposDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumTelefDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtTelefDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumFaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
