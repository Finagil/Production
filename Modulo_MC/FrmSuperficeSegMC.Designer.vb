<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSuperficeSegMC
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SuperficesAltasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS()
        Me.SuperficesAltasTableAdapter = New Agil.SegurosDSTableAdapters.SuperficesAltasTableAdapter()
        Me.GridAltas = New System.Windows.Forms.DataGridView()
        Me.IdPolizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDsuperficieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CultivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuperficieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AseguradoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PolizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.SuperficesAltasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAltas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperficesAltasBindingSource
        '
        Me.SuperficesAltasBindingSource.DataMember = "SuperficesAltas"
        Me.SuperficesAltasBindingSource.DataSource = Me.SegurosDS
        '
        'SegurosDS
        '
        Me.SegurosDS.DataSetName = "SegurosDS"
        Me.SegurosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuperficesAltasTableAdapter
        '
        Me.SuperficesAltasTableAdapter.ClearBeforeFill = True
        '
        'GridAltas
        '
        Me.GridAltas.AllowUserToAddRows = False
        Me.GridAltas.AllowUserToDeleteRows = False
        Me.GridAltas.AutoGenerateColumns = False
        Me.GridAltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAltas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPolizaDataGridViewTextBoxColumn, Me.IDsuperficieDataGridViewTextBoxColumn, Me.CultivoDataGridViewTextBoxColumn, Me.SuperficieDataGridViewTextBoxColumn, Me.CuotaDataGridViewTextBoxColumn, Me.AseguradoraDataGridViewTextBoxColumn, Me.PolizaDataGridViewTextBoxColumn, Me.PrimaDataGridViewTextBoxColumn, Me.Pagada})
        Me.GridAltas.DataSource = Me.SuperficesAltasBindingSource
        Me.GridAltas.Location = New System.Drawing.Point(12, 10)
        Me.GridAltas.Name = "GridAltas"
        Me.GridAltas.ReadOnly = True
        Me.GridAltas.Size = New System.Drawing.Size(715, 152)
        Me.GridAltas.TabIndex = 14
        '
        'IdPolizaDataGridViewTextBoxColumn
        '
        Me.IdPolizaDataGridViewTextBoxColumn.DataPropertyName = "IdPoliza"
        Me.IdPolizaDataGridViewTextBoxColumn.HeaderText = "IdPoliza"
        Me.IdPolizaDataGridViewTextBoxColumn.Name = "IdPolizaDataGridViewTextBoxColumn"
        Me.IdPolizaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPolizaDataGridViewTextBoxColumn.Visible = False
        '
        'IDsuperficieDataGridViewTextBoxColumn
        '
        Me.IDsuperficieDataGridViewTextBoxColumn.DataPropertyName = "IDsuperficie"
        Me.IDsuperficieDataGridViewTextBoxColumn.HeaderText = "IDsuperficie"
        Me.IDsuperficieDataGridViewTextBoxColumn.Name = "IDsuperficieDataGridViewTextBoxColumn"
        Me.IDsuperficieDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDsuperficieDataGridViewTextBoxColumn.Visible = False
        '
        'CultivoDataGridViewTextBoxColumn
        '
        Me.CultivoDataGridViewTextBoxColumn.DataPropertyName = "Cultivo"
        Me.CultivoDataGridViewTextBoxColumn.HeaderText = "Cultivo"
        Me.CultivoDataGridViewTextBoxColumn.Name = "CultivoDataGridViewTextBoxColumn"
        Me.CultivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CultivoDataGridViewTextBoxColumn.Width = 70
        '
        'SuperficieDataGridViewTextBoxColumn
        '
        Me.SuperficieDataGridViewTextBoxColumn.DataPropertyName = "Superficie"
        Me.SuperficieDataGridViewTextBoxColumn.HeaderText = "Superficie"
        Me.SuperficieDataGridViewTextBoxColumn.Name = "SuperficieDataGridViewTextBoxColumn"
        Me.SuperficieDataGridViewTextBoxColumn.ReadOnly = True
        Me.SuperficieDataGridViewTextBoxColumn.Width = 70
        '
        'CuotaDataGridViewTextBoxColumn
        '
        Me.CuotaDataGridViewTextBoxColumn.DataPropertyName = "Cuota"
        DataGridViewCellStyle5.Format = "N2"
        Me.CuotaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.CuotaDataGridViewTextBoxColumn.HeaderText = "Cuota"
        Me.CuotaDataGridViewTextBoxColumn.Name = "CuotaDataGridViewTextBoxColumn"
        Me.CuotaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuotaDataGridViewTextBoxColumn.Width = 70
        '
        'AseguradoraDataGridViewTextBoxColumn
        '
        Me.AseguradoraDataGridViewTextBoxColumn.DataPropertyName = "Aseguradora"
        Me.AseguradoraDataGridViewTextBoxColumn.HeaderText = "Aseguradora"
        Me.AseguradoraDataGridViewTextBoxColumn.Name = "AseguradoraDataGridViewTextBoxColumn"
        Me.AseguradoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.AseguradoraDataGridViewTextBoxColumn.Width = 190
        '
        'PolizaDataGridViewTextBoxColumn
        '
        Me.PolizaDataGridViewTextBoxColumn.DataPropertyName = "Poliza"
        Me.PolizaDataGridViewTextBoxColumn.HeaderText = "Poliza"
        Me.PolizaDataGridViewTextBoxColumn.Name = "PolizaDataGridViewTextBoxColumn"
        Me.PolizaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimaDataGridViewTextBoxColumn
        '
        Me.PrimaDataGridViewTextBoxColumn.DataPropertyName = "Prima"
        DataGridViewCellStyle6.Format = "N2"
        Me.PrimaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrimaDataGridViewTextBoxColumn.HeaderText = "Prima"
        Me.PrimaDataGridViewTextBoxColumn.Name = "PrimaDataGridViewTextBoxColumn"
        Me.PrimaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Pagada
        '
        Me.Pagada.DataPropertyName = "Pagada"
        Me.Pagada.HeaderText = "Pagada"
        Me.Pagada.Name = "Pagada"
        Me.Pagada.ReadOnly = True
        Me.Pagada.Width = 50
        '
        'FrmSuperficeSegMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 174)
        Me.Controls.Add(Me.GridAltas)
        Me.Name = "FrmSuperficeSegMC"
        Me.Text = "Superfice Asegurada Avío"
        CType(Me.SuperficesAltasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAltas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SuperficesAltasBindingSource As BindingSource
    Friend WithEvents SegurosDS As SegurosDS
    Friend WithEvents SuperficesAltasTableAdapter As SegurosDSTableAdapters.SuperficesAltasTableAdapter
    Friend WithEvents GridAltas As DataGridView
    Friend WithEvents IdPolizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDsuperficieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CultivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuperficieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AseguradoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PolizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Pagada As DataGridViewCheckBoxColumn
End Class
