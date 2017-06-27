<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMinistracionesParametros
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
        Me.BttMinistraciones = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Grid1 = New System.Windows.Forms.DataGridView
        Me.IDMinistracionPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdParametroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorcentajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AVIMinistracionesParametrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AviosDSX = New Agil.AviosDSX
        Me.BttValidar = New System.Windows.Forms.Button
        Me.AVI_MinistracionesParametrosTableAdapter = New Agil.AviosDSXTableAdapters.AVI_MinistracionesParametrosTableAdapter
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AVIMinistracionesParametrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BttMinistraciones
        '
        Me.BttMinistraciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttMinistraciones.Location = New System.Drawing.Point(247, 219)
        Me.BttMinistraciones.Name = "BttMinistraciones"
        Me.BttMinistraciones.Size = New System.Drawing.Size(79, 32)
        Me.BttMinistraciones.TabIndex = 120
        Me.BttMinistraciones.Text = "Guardar"
        Me.BttMinistraciones.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(332, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 32)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Grid1
        '
        Me.Grid1.AutoGenerateColumns = False
        Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDMinistracionPDataGridViewTextBoxColumn, Me.IdParametroDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.PorcentajeDataGridViewTextBoxColumn})
        Me.Grid1.DataSource = Me.AVIMinistracionesParametrosBindingSource
        Me.Grid1.Location = New System.Drawing.Point(12, 12)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(399, 201)
        Me.Grid1.TabIndex = 122
        '
        'IDMinistracionPDataGridViewTextBoxColumn
        '
        Me.IDMinistracionPDataGridViewTextBoxColumn.DataPropertyName = "ID_MinistracionP"
        Me.IDMinistracionPDataGridViewTextBoxColumn.HeaderText = "ID_MinistracionP"
        Me.IDMinistracionPDataGridViewTextBoxColumn.Name = "IDMinistracionPDataGridViewTextBoxColumn"
        Me.IDMinistracionPDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDMinistracionPDataGridViewTextBoxColumn.Visible = False
        '
        'IdParametroDataGridViewTextBoxColumn
        '
        Me.IdParametroDataGridViewTextBoxColumn.DataPropertyName = "Id_Parametro"
        Me.IdParametroDataGridViewTextBoxColumn.HeaderText = "Id_Parametro"
        Me.IdParametroDataGridViewTextBoxColumn.Name = "IdParametroDataGridViewTextBoxColumn"
        Me.IdParametroDataGridViewTextBoxColumn.Visible = False
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'PorcentajeDataGridViewTextBoxColumn
        '
        Me.PorcentajeDataGridViewTextBoxColumn.DataPropertyName = "Porcentaje"
        Me.PorcentajeDataGridViewTextBoxColumn.HeaderText = "Porcentaje"
        Me.PorcentajeDataGridViewTextBoxColumn.Name = "PorcentajeDataGridViewTextBoxColumn"
        '
        'AVIMinistracionesParametrosBindingSource
        '
        Me.AVIMinistracionesParametrosBindingSource.DataMember = "AVI_MinistracionesParametros"
        Me.AVIMinistracionesParametrosBindingSource.DataSource = Me.AviosDSX
        '
        'AviosDSX
        '
        Me.AviosDSX.DataSetName = "AviosDSX"
        Me.AviosDSX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BttValidar
        '
        Me.BttValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttValidar.Location = New System.Drawing.Point(162, 219)
        Me.BttValidar.Name = "BttValidar"
        Me.BttValidar.Size = New System.Drawing.Size(79, 32)
        Me.BttValidar.TabIndex = 123
        Me.BttValidar.Text = "Validar"
        Me.BttValidar.UseVisualStyleBackColor = True
        '
        'AVI_MinistracionesParametrosTableAdapter
        '
        Me.AVI_MinistracionesParametrosTableAdapter.ClearBeforeFill = True
        '
        'FrmMinistracionesParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.BttValidar)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BttMinistraciones)
        Me.Name = "FrmMinistracionesParametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ministraciones por Ciclo"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AVIMinistracionesParametrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BttMinistraciones As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents BttValidar As System.Windows.Forms.Button
    Friend WithEvents IDMinistracionPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdParametroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AVIMinistracionesParametrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AviosDSX As Agil.AviosDSX
    Friend WithEvents AVI_MinistracionesParametrosTableAdapter As Agil.AviosDSXTableAdapters.AVI_MinistracionesParametrosTableAdapter
End Class
