<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAVI_Refa
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
        Me.BttValidar = New System.Windows.Forms.Button
        Me.IdcreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Z25DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FIRArefaccionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AviosDSX = New Agil.AviosDSX
        Me.FIRArefaccionariosTableAdapter = New Agil.AviosDSXTableAdapters.FIRArefaccionariosTableAdapter
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FIRArefaccionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BttMinistraciones
        '
        Me.BttMinistraciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttMinistraciones.Location = New System.Drawing.Point(217, 549)
        Me.BttMinistraciones.Name = "BttMinistraciones"
        Me.BttMinistraciones.Size = New System.Drawing.Size(79, 32)
        Me.BttMinistraciones.TabIndex = 120
        Me.BttMinistraciones.Text = "Guardar"
        Me.BttMinistraciones.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(302, 549)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 32)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Grid1
        '
        Me.Grid1.AllowUserToOrderColumns = True
        Me.Grid1.AutoGenerateColumns = False
        Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcreditoDataGridViewTextBoxColumn, Me.AnexoDataGridViewTextBoxColumn, Me.Z25DataGridViewTextBoxColumn})
        Me.Grid1.DataSource = Me.FIRArefaccionariosBindingSource
        Me.Grid1.Location = New System.Drawing.Point(12, 12)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(369, 531)
        Me.Grid1.TabIndex = 122
        '
        'BttValidar
        '
        Me.BttValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttValidar.Location = New System.Drawing.Point(132, 549)
        Me.BttValidar.Name = "BttValidar"
        Me.BttValidar.Size = New System.Drawing.Size(79, 32)
        Me.BttValidar.TabIndex = 123
        Me.BttValidar.Text = "Validar"
        Me.BttValidar.UseVisualStyleBackColor = True
        '
        'IdcreditoDataGridViewTextBoxColumn
        '
        Me.IdcreditoDataGridViewTextBoxColumn.DataPropertyName = "idcredito"
        Me.IdcreditoDataGridViewTextBoxColumn.HeaderText = "ID Credito"
        Me.IdcreditoDataGridViewTextBoxColumn.Name = "IdcreditoDataGridViewTextBoxColumn"
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        '
        'Z25DataGridViewTextBoxColumn
        '
        Me.Z25DataGridViewTextBoxColumn.DataPropertyName = "Z25"
        Me.Z25DataGridViewTextBoxColumn.HeaderText = "Z25"
        Me.Z25DataGridViewTextBoxColumn.Name = "Z25DataGridViewTextBoxColumn"
        '
        'FIRArefaccionariosBindingSource
        '
        Me.FIRArefaccionariosBindingSource.DataMember = "FIRArefaccionarios"
        Me.FIRArefaccionariosBindingSource.DataSource = Me.AviosDSX
        '
        'AviosDSX
        '
        Me.AviosDSX.DataSetName = "AviosDSX"
        Me.AviosDSX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FIRArefaccionariosTableAdapter
        '
        Me.FIRArefaccionariosTableAdapter.ClearBeforeFill = True
        '
        'FrmAVI_Refa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 593)
        Me.ControlBox = False
        Me.Controls.Add(Me.BttValidar)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BttMinistraciones)
        Me.Name = "FrmAVI_Refa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ID creditos Refaccionarios"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FIRArefaccionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BttMinistraciones As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents BttValidar As System.Windows.Forms.Button
    Friend WithEvents AviosDSX As Agil.AviosDSX
    Friend WithEvents FIRArefaccionariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FIRArefaccionariosTableAdapter As Agil.AviosDSXTableAdapters.FIRArefaccionariosTableAdapter
    Friend WithEvents IdcreditoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Z25DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
