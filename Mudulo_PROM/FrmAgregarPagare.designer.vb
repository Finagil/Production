<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarPagare
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CmbContrato = New System.Windows.Forms.ComboBox()
        Me.ContratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS = New Agil.PromocionDS()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridPag = New System.Windows.Forms.DataGridView()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAutorizacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaTerminacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineaActualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tasas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diferencial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AplicaFega = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FegaFlat = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PagaresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.BtAdd = New System.Windows.Forms.Button()
        Me.ContratosTableAdapter = New Agil.PromocionDSTableAdapters.ContratosTableAdapter()
        Me.PagaresTableAdapter = New Agil.PromocionDSTableAdapters.PagaresTableAdapter()
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDifer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTipta = New System.Windows.Forms.TextBox()
        Me.TextDisponoble = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.ContratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagaresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbContrato
        '
        Me.CmbContrato.DataSource = Me.ContratosBindingSource
        Me.CmbContrato.DisplayMember = "Anexo"
        Me.CmbContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbContrato.FormattingEnabled = True
        Me.CmbContrato.Location = New System.Drawing.Point(26, 34)
        Me.CmbContrato.Name = "CmbContrato"
        Me.CmbContrato.Size = New System.Drawing.Size(160, 21)
        Me.CmbContrato.TabIndex = 0
        Me.CmbContrato.ValueMember = "AnexoSin"
        '
        'ContratosBindingSource
        '
        Me.ContratosBindingSource.DataMember = "Contratos"
        Me.ContratosBindingSource.DataSource = Me.PromocionDS
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contrato"
        '
        'GridPag
        '
        Me.GridPag.AllowUserToAddRows = False
        Me.GridPag.AutoGenerateColumns = False
        Me.GridPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPag.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.PagareDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.FechaAutorizacionDataGridViewTextBoxColumn, Me.FechaTerminacionDataGridViewTextBoxColumn, Me.LineaActualDataGridViewTextBoxColumn, Me.Tasas, Me.Diferencial, Me.AplicaFega, Me.FegaFlat})
        Me.GridPag.DataSource = Me.PagaresBindingSource
        Me.GridPag.Location = New System.Drawing.Point(29, 62)
        Me.GridPag.Name = "GridPag"
        Me.GridPag.ReadOnly = True
        Me.GridPag.Size = New System.Drawing.Size(919, 136)
        Me.GridPag.TabIndex = 2
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Width = 80
        '
        'PagareDataGridViewTextBoxColumn
        '
        Me.PagareDataGridViewTextBoxColumn.DataPropertyName = "Pagare"
        Me.PagareDataGridViewTextBoxColumn.HeaderText = "Pagare"
        Me.PagareDataGridViewTextBoxColumn.Name = "PagareDataGridViewTextBoxColumn"
        Me.PagareDataGridViewTextBoxColumn.ReadOnly = True
        Me.PagareDataGridViewTextBoxColumn.Width = 60
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 200
        '
        'FechaAutorizacionDataGridViewTextBoxColumn
        '
        Me.FechaAutorizacionDataGridViewTextBoxColumn.DataPropertyName = "FechaAutorizacion"
        Me.FechaAutorizacionDataGridViewTextBoxColumn.HeaderText = "Fecha Autorizacion"
        Me.FechaAutorizacionDataGridViewTextBoxColumn.Name = "FechaAutorizacionDataGridViewTextBoxColumn"
        Me.FechaAutorizacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaAutorizacionDataGridViewTextBoxColumn.Width = 80
        '
        'FechaTerminacionDataGridViewTextBoxColumn
        '
        Me.FechaTerminacionDataGridViewTextBoxColumn.DataPropertyName = "FechaTerminacion"
        Me.FechaTerminacionDataGridViewTextBoxColumn.HeaderText = "Fecha Terminacion"
        Me.FechaTerminacionDataGridViewTextBoxColumn.Name = "FechaTerminacionDataGridViewTextBoxColumn"
        Me.FechaTerminacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaTerminacionDataGridViewTextBoxColumn.Width = 80
        '
        'LineaActualDataGridViewTextBoxColumn
        '
        Me.LineaActualDataGridViewTextBoxColumn.DataPropertyName = "LineaActual"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.LineaActualDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.LineaActualDataGridViewTextBoxColumn.HeaderText = "Linea Actual"
        Me.LineaActualDataGridViewTextBoxColumn.Name = "LineaActualDataGridViewTextBoxColumn"
        Me.LineaActualDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Tasas
        '
        Me.Tasas.DataPropertyName = "Tasas"
        Me.Tasas.HeaderText = "Tasa"
        Me.Tasas.Name = "Tasas"
        Me.Tasas.ReadOnly = True
        Me.Tasas.Width = 60
        '
        'Diferencial
        '
        Me.Diferencial.DataPropertyName = "Diferencial"
        Me.Diferencial.HeaderText = "Diferencial"
        Me.Diferencial.Name = "Diferencial"
        Me.Diferencial.ReadOnly = True
        Me.Diferencial.Width = 80
        '
        'AplicaFega
        '
        Me.AplicaFega.DataPropertyName = "AplicaFega"
        Me.AplicaFega.HeaderText = "Aplica Fega"
        Me.AplicaFega.Name = "AplicaFega"
        Me.AplicaFega.ReadOnly = True
        Me.AplicaFega.Width = 60
        '
        'FegaFlat
        '
        Me.FegaFlat.DataPropertyName = "FegaFlat"
        Me.FegaFlat.HeaderText = "FegaFlat"
        Me.FegaFlat.Name = "FegaFlat"
        Me.FegaFlat.ReadOnly = True
        Me.FegaFlat.Width = 60
        '
        'PagaresBindingSource
        '
        Me.PagaresBindingSource.DataMember = "Pagares"
        Me.PagaresBindingSource.DataSource = Me.PromocionDS
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Vencimiento"
        '
        'DTFecha
        '
        Me.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFecha.Location = New System.Drawing.Point(29, 218)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(134, 20)
        Me.DTFecha.TabIndex = 4
        Me.DTFecha.Value = New Date(2014, 5, 26, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(178, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Monto"
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(181, 217)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(142, 20)
        Me.TxtMonto.TabIndex = 6
        '
        'BtAdd
        '
        Me.BtAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAdd.Location = New System.Drawing.Point(459, 217)
        Me.BtAdd.Name = "BtAdd"
        Me.BtAdd.Size = New System.Drawing.Size(132, 23)
        Me.BtAdd.TabIndex = 9
        Me.BtAdd.Text = "Agregar Pagare"
        Me.BtAdd.UseVisualStyleBackColor = True
        '
        'ContratosTableAdapter
        '
        Me.ContratosTableAdapter.ClearBeforeFill = True
        '
        'PagaresTableAdapter
        '
        Me.PagaresTableAdapter.ClearBeforeFill = True
        '
        'TxtTasa
        '
        Me.TxtTasa.Enabled = False
        Me.TxtTasa.Location = New System.Drawing.Point(329, 218)
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.Size = New System.Drawing.Size(53, 20)
        Me.TxtTasa.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(326, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tasa"
        '
        'TxtDifer
        '
        Me.TxtDifer.Enabled = False
        Me.TxtDifer.Location = New System.Drawing.Point(388, 218)
        Me.TxtDifer.Name = "TxtDifer"
        Me.TxtDifer.Size = New System.Drawing.Size(65, 20)
        Me.TxtDifer.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(385, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Diferencial"
        '
        'TxtTipta
        '
        Me.TxtTipta.Enabled = False
        Me.TxtTipta.Location = New System.Drawing.Point(566, 219)
        Me.TxtTipta.Name = "TxtTipta"
        Me.TxtTipta.Size = New System.Drawing.Size(16, 20)
        Me.TxtTipta.TabIndex = 11
        '
        'TextDisponoble
        '
        Me.TextDisponoble.Location = New System.Drawing.Point(597, 220)
        Me.TextDisponoble.Name = "TextDisponoble"
        Me.TextDisponoble.ReadOnly = True
        Me.TextDisponoble.Size = New System.Drawing.Size(109, 20)
        Me.TextDisponoble.TabIndex = 13
        Me.TextDisponoble.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(594, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Linea Disponible"
        '
        'FrmAgregarPagare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 259)
        Me.Controls.Add(Me.TextDisponoble)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtDifer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTasa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtAdd)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GridPag)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbContrato)
        Me.Controls.Add(Me.TxtTipta)
        Me.Name = "FrmAgregarPagare"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Pagare"
        CType(Me.ContratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagaresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbContrato As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PromocionDS As Agil.PromocionDS
    Friend WithEvents ContratosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContratosTableAdapter As Agil.PromocionDSTableAdapters.ContratosTableAdapter
    Friend WithEvents GridPag As System.Windows.Forms.DataGridView
    Friend WithEvents PagaresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagaresTableAdapter As Agil.PromocionDSTableAdapters.PagaresTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtMonto As System.Windows.Forms.TextBox
    Friend WithEvents BtAdd As System.Windows.Forms.Button
    Friend WithEvents TxtTasa As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtDifer As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTipta As System.Windows.Forms.TextBox
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAutorizacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaTerminacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LineaActualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Tasas As DataGridViewTextBoxColumn
    Friend WithEvents Diferencial As DataGridViewTextBoxColumn
    Friend WithEvents AplicaFega As DataGridViewCheckBoxColumn
    Friend WithEvents FegaFlat As DataGridViewCheckBoxColumn
    Friend WithEvents TextDisponoble As TextBox
    Friend WithEvents Label6 As Label
End Class
