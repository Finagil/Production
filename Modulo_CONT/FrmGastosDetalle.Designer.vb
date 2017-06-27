<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGastosDetalle
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
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GastosDS = New Agil.GastosDS
        Me.VwGastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_GastosTableAdapter = New Agil.GastosDSTableAdapters.Vw_GastosTableAdapter
        Me.ContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PagadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.TxtImporte = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwGastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(738, 165)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ContratoDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.PagadoDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.VwGastosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(802, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'GastosDS
        '
        Me.GastosDS.DataSetName = "GastosDS"
        Me.GastosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwGastosBindingSource
        '
        Me.VwGastosBindingSource.DataMember = "Vw_Gastos"
        Me.VwGastosBindingSource.DataSource = Me.GastosDS
        '
        'Vw_GastosTableAdapter
        '
        Me.Vw_GastosTableAdapter.ClearBeforeFill = True
        '
        'ContratoDataGridViewTextBoxColumn
        '
        Me.ContratoDataGridViewTextBoxColumn.DataPropertyName = "Contrato"
        Me.ContratoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.ContratoDataGridViewTextBoxColumn.Name = "ContratoDataGridViewTextBoxColumn"
        Me.ContratoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 200
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 200
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagadoDataGridViewCheckBoxColumn
        '
        Me.PagadoDataGridViewCheckBoxColumn.DataPropertyName = "Pagado"
        Me.PagadoDataGridViewCheckBoxColumn.HeaderText = "Pagado"
        Me.PagadoDataGridViewCheckBoxColumn.Name = "PagadoDataGridViewCheckBoxColumn"
        Me.PagadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.PagadoDataGridViewCheckBoxColumn.Width = 50
        '
        'TxtImporte
        '
        Me.TxtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImporte.ForeColor = System.Drawing.Color.Black
        Me.TxtImporte.Location = New System.Drawing.Point(560, 167)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.ReadOnly = True
        Me.TxtImporte.Size = New System.Drawing.Size(92, 20)
        Me.TxtImporte.TabIndex = 2
        Me.TxtImporte.Text = "0.0"
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmGastosDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtImporte)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FrmGastosDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Gastos Adicionales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwGastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ContratoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents VwGastosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GastosDS As Agil.GastosDS
    Friend WithEvents Vw_GastosTableAdapter As Agil.GastosDSTableAdapters.Vw_GastosTableAdapter
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
End Class
