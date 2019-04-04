<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFechasSupervision
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbClientes = New System.Windows.Forms.ComboBox()
        Me.ClientesFiraActivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AviosDSX = New Agil.AviosDSX()
        Me.ClientesFiraActivosTableAdapter = New Agil.AviosDSXTableAdapters.ClientesFiraActivosTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbAnexos = New System.Windows.Forms.ComboBox()
        Me.AnexosFiraActivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexosFiraActivosTableAdapter = New Agil.AviosDSXTableAdapters.AnexosFiraActivosTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtFechaCon = New System.Windows.Forms.TextBox()
        Me.TxtFechaVen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSucursal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPlazo = New System.Windows.Forms.TextBox()
        Me.GridFechas = New System.Windows.Forms.DataGridView()
        Me.IdSupervisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaOriginalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRealDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Autorizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechasSupervisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FechasSupervisionTableAdapter = New Agil.AviosDSXTableAdapters.FechasSupervisionTableAdapter()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ClientesFiraActivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosFiraActivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechasSupervisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'CmbClientes
        '
        Me.CmbClientes.DataSource = Me.ClientesFiraActivosBindingSource
        Me.CmbClientes.DisplayMember = "Nombre"
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(15, 26)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(474, 21)
        Me.CmbClientes.TabIndex = 1
        Me.CmbClientes.ValueMember = "Cliente"
        '
        'ClientesFiraActivosBindingSource
        '
        Me.ClientesFiraActivosBindingSource.DataMember = "ClientesFiraActivos"
        Me.ClientesFiraActivosBindingSource.DataSource = Me.AviosDSX
        '
        'AviosDSX
        '
        Me.AviosDSX.DataSetName = "AviosDSX"
        Me.AviosDSX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesFiraActivosTableAdapter
        '
        Me.ClientesFiraActivosTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Anexos"
        '
        'CmbAnexos
        '
        Me.CmbAnexos.DataSource = Me.AnexosFiraActivosBindingSource
        Me.CmbAnexos.DisplayMember = "Anexo"
        Me.CmbAnexos.FormattingEnabled = True
        Me.CmbAnexos.Location = New System.Drawing.Point(15, 67)
        Me.CmbAnexos.Name = "CmbAnexos"
        Me.CmbAnexos.Size = New System.Drawing.Size(162, 21)
        Me.CmbAnexos.TabIndex = 3
        Me.CmbAnexos.ValueMember = "AnexoFull"
        '
        'AnexosFiraActivosBindingSource
        '
        Me.AnexosFiraActivosBindingSource.DataMember = "AnexosFiraActivos"
        Me.AnexosFiraActivosBindingSource.DataSource = Me.AviosDSX
        '
        'AnexosFiraActivosTableAdapter
        '
        Me.AnexosFiraActivosTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosFiraActivosBindingSource, "TipoCredito", True))
        Me.Label3.Location = New System.Drawing.Point(183, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha Contrato"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(119, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha Vencimiento"
        '
        'TxtFechaCon
        '
        Me.TxtFechaCon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosFiraActivosBindingSource, "FechaContrato", True))
        Me.TxtFechaCon.Enabled = False
        Me.TxtFechaCon.Location = New System.Drawing.Point(18, 112)
        Me.TxtFechaCon.Name = "TxtFechaCon"
        Me.TxtFechaCon.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaCon.TabIndex = 7
        '
        'TxtFechaVen
        '
        Me.TxtFechaVen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosFiraActivosBindingSource, "FechaVencimiento", True))
        Me.TxtFechaVen.Enabled = False
        Me.TxtFechaVen.Location = New System.Drawing.Point(124, 112)
        Me.TxtFechaVen.Name = "TxtFechaVen"
        Me.TxtFechaVen.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaVen.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(231, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sucursal"
        '
        'TxtSucursal
        '
        Me.TxtSucursal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosFiraActivosBindingSource, "Sucursal", True))
        Me.TxtSucursal.Enabled = False
        Me.TxtSucursal.Location = New System.Drawing.Point(234, 112)
        Me.TxtSucursal.Name = "TxtSucursal"
        Me.TxtSucursal.Size = New System.Drawing.Size(179, 20)
        Me.TxtSucursal.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(419, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Plazo"
        '
        'TxtPlazo
        '
        Me.TxtPlazo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosFiraActivosBindingSource, "Plazo", True))
        Me.TxtPlazo.Enabled = False
        Me.TxtPlazo.Location = New System.Drawing.Point(419, 112)
        Me.TxtPlazo.Name = "TxtPlazo"
        Me.TxtPlazo.Size = New System.Drawing.Size(48, 20)
        Me.TxtPlazo.TabIndex = 12
        '
        'GridFechas
        '
        Me.GridFechas.AllowUserToAddRows = False
        Me.GridFechas.AllowUserToDeleteRows = False
        Me.GridFechas.AutoGenerateColumns = False
        Me.GridFechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridFechas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSupervisionDataGridViewTextBoxColumn, Me.AnexoDataGridViewTextBoxColumn, Me.CicloDataGridViewTextBoxColumn, Me.FechaOriginalDataGridViewTextBoxColumn, Me.FechaRealDataGridViewTextBoxColumn, Me.NotasDataGridViewTextBoxColumn, Me.Autorizacion})
        Me.GridFechas.DataSource = Me.FechasSupervisionBindingSource
        Me.GridFechas.Location = New System.Drawing.Point(18, 155)
        Me.GridFechas.Name = "GridFechas"
        Me.GridFechas.Size = New System.Drawing.Size(741, 189)
        Me.GridFechas.TabIndex = 13
        '
        'IdSupervisionDataGridViewTextBoxColumn
        '
        Me.IdSupervisionDataGridViewTextBoxColumn.DataPropertyName = "Id_Supervision"
        Me.IdSupervisionDataGridViewTextBoxColumn.HeaderText = "Id_Supervision"
        Me.IdSupervisionDataGridViewTextBoxColumn.Name = "IdSupervisionDataGridViewTextBoxColumn"
        Me.IdSupervisionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdSupervisionDataGridViewTextBoxColumn.Visible = False
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.Visible = False
        '
        'CicloDataGridViewTextBoxColumn
        '
        Me.CicloDataGridViewTextBoxColumn.DataPropertyName = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.HeaderText = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.Name = "CicloDataGridViewTextBoxColumn"
        Me.CicloDataGridViewTextBoxColumn.Visible = False
        '
        'FechaOriginalDataGridViewTextBoxColumn
        '
        Me.FechaOriginalDataGridViewTextBoxColumn.DataPropertyName = "FechaOriginal"
        DataGridViewCellStyle3.Format = "d"
        Me.FechaOriginalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaOriginalDataGridViewTextBoxColumn.FillWeight = 15.0!
        Me.FechaOriginalDataGridViewTextBoxColumn.HeaderText = "FechaOriginal"
        Me.FechaOriginalDataGridViewTextBoxColumn.Name = "FechaOriginalDataGridViewTextBoxColumn"
        Me.FechaOriginalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaRealDataGridViewTextBoxColumn
        '
        Me.FechaRealDataGridViewTextBoxColumn.DataPropertyName = "FechaReal"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.FechaRealDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechaRealDataGridViewTextBoxColumn.FillWeight = 15.0!
        Me.FechaRealDataGridViewTextBoxColumn.HeaderText = "FechaReal"
        Me.FechaRealDataGridViewTextBoxColumn.Name = "FechaRealDataGridViewTextBoxColumn"
        '
        'NotasDataGridViewTextBoxColumn
        '
        Me.NotasDataGridViewTextBoxColumn.DataPropertyName = "Notas"
        Me.NotasDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.NotasDataGridViewTextBoxColumn.HeaderText = "Notas"
        Me.NotasDataGridViewTextBoxColumn.MaxInputLength = 200
        Me.NotasDataGridViewTextBoxColumn.Name = "NotasDataGridViewTextBoxColumn"
        '
        'Autorizacion
        '
        Me.Autorizacion.DataPropertyName = "Autorizacion"
        Me.Autorizacion.FillWeight = 20.0!
        Me.Autorizacion.HeaderText = "Autorizacion"
        Me.Autorizacion.MaxInputLength = 120
        Me.Autorizacion.Name = "Autorizacion"
        '
        'FechasSupervisionBindingSource
        '
        Me.FechasSupervisionBindingSource.DataMember = "FechasSupervision"
        Me.FechasSupervisionBindingSource.DataSource = Me.AviosDSX
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fechas de Supervisión"
        '
        'FechasSupervisionTableAdapter
        '
        Me.FechasSupervisionTableAdapter.ClearBeforeFill = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(684, 126)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 15
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(666, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Supervisiones"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmFechasSupervision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 356)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GridFechas)
        Me.Controls.Add(Me.TxtPlazo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtSucursal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtFechaVen)
        Me.Controls.Add(Me.TxtFechaCon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbAnexos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbClientes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmFechasSupervision"
        Me.Text = "Fechas de Supervisión"
        CType(Me.ClientesFiraActivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosFiraActivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFechas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechasSupervisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CmbClientes As ComboBox
    Friend WithEvents AviosDSX As AviosDSX
    Friend WithEvents ClientesFiraActivosBindingSource As BindingSource
    Friend WithEvents ClientesFiraActivosTableAdapter As AviosDSXTableAdapters.ClientesFiraActivosTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbAnexos As ComboBox
    Friend WithEvents AnexosFiraActivosBindingSource As BindingSource
    Friend WithEvents AnexosFiraActivosTableAdapter As AviosDSXTableAdapters.AnexosFiraActivosTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtFechaCon As TextBox
    Friend WithEvents TxtFechaVen As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSucursal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPlazo As TextBox
    Friend WithEvents GridFechas As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents FechasSupervisionBindingSource As BindingSource
    Friend WithEvents FechasSupervisionTableAdapter As AviosDSXTableAdapters.FechasSupervisionTableAdapter
    Friend WithEvents BtnSave As Button
    Friend WithEvents IdSupervisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaOriginalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaRealDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Autorizacion As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
