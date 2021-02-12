<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDiasFestivos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DiaFestivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENDiasFestivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GEN_DiasFestivosTableAdapter = New Agil.GeneralDSTableAdapters.GEN_DiasFestivosTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GENDiasFestivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(202, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Agregar Día"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DiaFestivoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GENDiasFestivosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(300, 340)
        Me.DataGridView1.TabIndex = 2
        '
        'DiaFestivoDataGridViewTextBoxColumn
        '
        Me.DiaFestivoDataGridViewTextBoxColumn.DataPropertyName = "DiaFestivo"
        DataGridViewCellStyle1.Format = "D"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DiaFestivoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DiaFestivoDataGridViewTextBoxColumn.HeaderText = "DiaFestivo"
        Me.DiaFestivoDataGridViewTextBoxColumn.Name = "DiaFestivoDataGridViewTextBoxColumn"
        Me.DiaFestivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiaFestivoDataGridViewTextBoxColumn.Width = 200
        '
        'GENDiasFestivosBindingSource
        '
        Me.GENDiasFestivosBindingSource.DataMember = "GEN_DiasFestivos"
        Me.GENDiasFestivosBindingSource.DataSource = Me.GeneralDS
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(204, 384)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 22)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Guardar Cambios"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GEN_DiasFestivosTableAdapter
        '
        Me.GEN_DiasFestivosTableAdapter.ClearBeforeFill = True
        '
        'FrmDiasFestivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 411)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "FrmDiasFestivos"
        Me.Text = "Dias Festivos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GENDiasFestivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DiaFestivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GENDiasFestivosBindingSource As BindingSource
    Friend WithEvents GeneralDS As GeneralDS
    Friend WithEvents Button2 As Button
    Friend WithEvents GEN_DiasFestivosTableAdapter As GeneralDSTableAdapters.GEN_DiasFestivosTableAdapter
End Class
