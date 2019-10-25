<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenAnexoLiquidez
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PromocionDS = New Agil.PromocionDS()
        Me.LineasLQBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineasLQTableAdapter = New Agil.PromocionDSTableAdapters.LineasLQTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextLinea = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextMonto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoLineaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VigenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineasLQBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteDataGridViewTextBoxColumn, Me.SolicitudDataGridViewTextBoxColumn, Me.MontoLineaDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.FechaAltaDataGridViewTextBoxColumn, Me.VigenciaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LineasLQBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(775, 303)
        Me.DataGridView1.TabIndex = 0
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LineasLQBindingSource
        '
        Me.LineasLQBindingSource.DataMember = "LineasLQ"
        Me.LineasLQBindingSource.DataSource = Me.PromocionDS
        '
        'LineasLQTableAdapter
        '
        Me.LineasLQTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LineasLQBindingSource, "Cliente", True))
        Me.TextBox1.Location = New System.Drawing.Point(16, 340)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(514, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextLinea
        '
        Me.TextLinea.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LineasLQBindingSource, "MontoLinea", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextLinea.Location = New System.Drawing.Point(536, 340)
        Me.TextLinea.Name = "TextLinea"
        Me.TextLinea.ReadOnly = True
        Me.TextLinea.Size = New System.Drawing.Size(135, 20)
        Me.TextLinea.TabIndex = 4
        Me.TextLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(533, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Monto de la Linea"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(677, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Genera Contrato"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextMonto
        '
        Me.TextMonto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LineasLQBindingSource, "MontoLinea", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextMonto.Location = New System.Drawing.Point(677, 339)
        Me.TextMonto.Name = "TextMonto"
        Me.TextMonto.Size = New System.Drawing.Size(111, 20)
        Me.TextMonto.TabIndex = 7
        Me.TextMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(695, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Monto a Disponer"
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 250
        '
        'SolicitudDataGridViewTextBoxColumn
        '
        Me.SolicitudDataGridViewTextBoxColumn.DataPropertyName = "Solicitud"
        Me.SolicitudDataGridViewTextBoxColumn.HeaderText = "Solicitud"
        Me.SolicitudDataGridViewTextBoxColumn.Name = "SolicitudDataGridViewTextBoxColumn"
        Me.SolicitudDataGridViewTextBoxColumn.ReadOnly = True
        Me.SolicitudDataGridViewTextBoxColumn.Width = 70
        '
        'MontoLineaDataGridViewTextBoxColumn
        '
        Me.MontoLineaDataGridViewTextBoxColumn.DataPropertyName = "MontoLinea"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.MontoLineaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MontoLineaDataGridViewTextBoxColumn.HeaderText = "MontoLinea"
        Me.MontoLineaDataGridViewTextBoxColumn.Name = "MontoLineaDataGridViewTextBoxColumn"
        Me.MontoLineaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaAltaDataGridViewTextBoxColumn
        '
        Me.FechaAltaDataGridViewTextBoxColumn.DataPropertyName = "FechaAlta"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FechaAltaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaAltaDataGridViewTextBoxColumn.HeaderText = "FechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.Name = "FechaAltaDataGridViewTextBoxColumn"
        Me.FechaAltaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VigenciaDataGridViewTextBoxColumn
        '
        Me.VigenciaDataGridViewTextBoxColumn.DataPropertyName = "Vigencia"
        DataGridViewCellStyle3.Format = "d"
        Me.VigenciaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.VigenciaDataGridViewTextBoxColumn.HeaderText = "Vigencia"
        Me.VigenciaDataGridViewTextBoxColumn.Name = "VigenciaDataGridViewTextBoxColumn"
        Me.VigenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmGenAnexoLiquidez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 393)
        Me.Controls.Add(Me.TextMonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextLinea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmGenAnexoLiquidez"
        Me.Text = "Generacion de Contrato Liquidez Inmediata"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineasLQBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PromocionDS As PromocionDS
    Friend WithEvents LineasLQBindingSource As BindingSource
    Friend WithEvents LineasLQTableAdapter As PromocionDSTableAdapters.LineasLQTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextLinea As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextMonto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoLineaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VigenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
