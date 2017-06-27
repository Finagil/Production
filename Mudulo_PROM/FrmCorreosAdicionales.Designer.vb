<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCorreosAdicionales
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ClientesActivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS = New Agil.PromocionDS()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ClientesActivosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS1 = New Agil.PromocionDS()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreosAnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesActivosTableAdapter = New Agil.PromocionDSTableAdapters.ClientesActivosTableAdapter()
        Me.CorreosAnexosTableAdapter = New Agil.PromocionDSTableAdapters.CorreosAnexosTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ClientesActivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesActivosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CorreosAnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClientesActivosBindingSource
        Me.ComboBox1.DisplayMember = "Descr"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(16, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(570, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "Cliente"
        '
        'ClientesActivosBindingSource
        '
        Me.ClientesActivosBindingSource.DataMember = "ClientesActivos"
        Me.ClientesActivosBindingSource.DataSource = Me.PromocionDS
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ClientesActivosBindingSource1
        Me.ComboBox2.DisplayMember = "AnexoCon"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(16, 71)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.ValueMember = "Anexo"
        '
        'ClientesActivosBindingSource1
        '
        Me.ClientesActivosBindingSource1.DataMember = "ClientesActivos"
        Me.ClientesActivosBindingSource1.DataSource = Me.PromocionDS1
        '
        'PromocionDS1
        '
        Me.PromocionDS1.DataSetName = "PromocionDS"
        Me.PromocionDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contratos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.Correo1DataGridViewTextBoxColumn, Me.Correo2DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CorreosAnexosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(663, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.Visible = False
        '
        'Correo1DataGridViewTextBoxColumn
        '
        Me.Correo1DataGridViewTextBoxColumn.DataPropertyName = "Correo1"
        Me.Correo1DataGridViewTextBoxColumn.HeaderText = "Correo1"
        Me.Correo1DataGridViewTextBoxColumn.MaxInputLength = 50
        Me.Correo1DataGridViewTextBoxColumn.Name = "Correo1DataGridViewTextBoxColumn"
        Me.Correo1DataGridViewTextBoxColumn.Width = 300
        '
        'Correo2DataGridViewTextBoxColumn
        '
        Me.Correo2DataGridViewTextBoxColumn.DataPropertyName = "Correo2"
        Me.Correo2DataGridViewTextBoxColumn.HeaderText = "Correo2"
        Me.Correo2DataGridViewTextBoxColumn.MaxInputLength = 50
        Me.Correo2DataGridViewTextBoxColumn.Name = "Correo2DataGridViewTextBoxColumn"
        Me.Correo2DataGridViewTextBoxColumn.Width = 300
        '
        'CorreosAnexosBindingSource
        '
        Me.CorreosAnexosBindingSource.DataMember = "CorreosAnexos"
        Me.CorreosAnexosBindingSource.DataSource = Me.PromocionDS
        '
        'ClientesActivosTableAdapter
        '
        Me.ClientesActivosTableAdapter.ClearBeforeFill = True
        '
        'CorreosAnexosTableAdapter
        '
        Me.CorreosAnexosTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(604, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Nuevo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmCorreosAdicionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 283)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCorreosAdicionales"
        Me.Text = "Correos Adicionales por Contrato"
        CType(Me.ClientesActivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesActivosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CorreosAnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PromocionDS As PromocionDS
    Friend WithEvents ClientesActivosBindingSource As BindingSource
    Friend WithEvents ClientesActivosTableAdapter As PromocionDSTableAdapters.ClientesActivosTableAdapter
    Friend WithEvents PromocionDS1 As PromocionDS
    Friend WithEvents ClientesActivosBindingSource1 As BindingSource
    Friend WithEvents CorreosAnexosBindingSource As BindingSource
    Friend WithEvents CorreosAnexosTableAdapter As PromocionDSTableAdapters.CorreosAnexosTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Correo1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Correo2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
