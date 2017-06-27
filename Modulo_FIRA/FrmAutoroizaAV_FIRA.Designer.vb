<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAutoroizaAV_FIRA
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
        Me.GridAnexos = New System.Windows.Forms.DataGridView()
        Me.NombreSucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CultivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloPagareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorizaAutDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AviosFiraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FiraDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FiraDS = New Agil.FiraDS()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLiberar = New System.Windows.Forms.Button()
        Me.TxttotMinis = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AviosFiraTableAdapter = New Agil.FiraDSTableAdapters.AviosFIRATableAdapter()
        CType(Me.GridAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosFiraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiraDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiraDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridAnexos
        '
        Me.GridAnexos.AllowUserToAddRows = False
        Me.GridAnexos.AllowUserToDeleteRows = False
        Me.GridAnexos.AutoGenerateColumns = False
        Me.GridAnexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAnexos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreSucursalDataGridViewTextBoxColumn, Me.CultivoDataGridViewTextBoxColumn, Me.AnexoConDataGridViewTextBoxColumn, Me.CicloPagareDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn, Me.DocumentoDataGridViewTextBoxColumn, Me.AutorizaAutDataGridViewCheckBoxColumn})
        Me.GridAnexos.DataSource = Me.AviosFiraBindingSource
        Me.GridAnexos.Location = New System.Drawing.Point(13, 29)
        Me.GridAnexos.Name = "GridAnexos"
        Me.GridAnexos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridAnexos.Size = New System.Drawing.Size(976, 442)
        Me.GridAnexos.TabIndex = 0
        '
        'NombreSucursalDataGridViewTextBoxColumn
        '
        Me.NombreSucursalDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Sucursal"
        Me.NombreSucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.NombreSucursalDataGridViewTextBoxColumn.Name = "NombreSucursalDataGridViewTextBoxColumn"
        Me.NombreSucursalDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreSucursalDataGridViewTextBoxColumn.Width = 80
        '
        'CultivoDataGridViewTextBoxColumn
        '
        Me.CultivoDataGridViewTextBoxColumn.DataPropertyName = "Cultivo"
        Me.CultivoDataGridViewTextBoxColumn.HeaderText = "Cultivo"
        Me.CultivoDataGridViewTextBoxColumn.Name = "CultivoDataGridViewTextBoxColumn"
        Me.CultivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CultivoDataGridViewTextBoxColumn.Width = 70
        '
        'AnexoConDataGridViewTextBoxColumn
        '
        Me.AnexoConDataGridViewTextBoxColumn.DataPropertyName = "AnexoCon"
        Me.AnexoConDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoConDataGridViewTextBoxColumn.Name = "AnexoConDataGridViewTextBoxColumn"
        Me.AnexoConDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoConDataGridViewTextBoxColumn.Width = 80
        '
        'CicloPagareDataGridViewTextBoxColumn
        '
        Me.CicloPagareDataGridViewTextBoxColumn.DataPropertyName = "CicloPagare"
        Me.CicloPagareDataGridViewTextBoxColumn.HeaderText = "Ciclo"
        Me.CicloPagareDataGridViewTextBoxColumn.Name = "CicloPagareDataGridViewTextBoxColumn"
        Me.CicloPagareDataGridViewTextBoxColumn.ReadOnly = True
        Me.CicloPagareDataGridViewTextBoxColumn.Width = 60
        '
        'DescrDataGridViewTextBoxColumn
        '
        Me.DescrDataGridViewTextBoxColumn.DataPropertyName = "Descr"
        Me.DescrDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.DescrDataGridViewTextBoxColumn.Name = "DescrDataGridViewTextBoxColumn"
        Me.DescrDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescrDataGridViewTextBoxColumn.Width = 150
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Width = 80
        '
        'TipoCreditoDataGridViewTextBoxColumn
        '
        Me.TipoCreditoDataGridViewTextBoxColumn.DataPropertyName = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "Tipo Credito"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCreditoDataGridViewTextBoxColumn.Width = 130
        '
        'DocumentoDataGridViewTextBoxColumn
        '
        Me.DocumentoDataGridViewTextBoxColumn.DataPropertyName = "Documento"
        Me.DocumentoDataGridViewTextBoxColumn.HeaderText = "Concepto"
        Me.DocumentoDataGridViewTextBoxColumn.Name = "DocumentoDataGridViewTextBoxColumn"
        Me.DocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AutorizaAutDataGridViewCheckBoxColumn
        '
        Me.AutorizaAutDataGridViewCheckBoxColumn.DataPropertyName = "AutorizaAut"
        Me.AutorizaAutDataGridViewCheckBoxColumn.HeaderText = "Autoriza"
        Me.AutorizaAutDataGridViewCheckBoxColumn.Name = "AutorizaAutDataGridViewCheckBoxColumn"
        '
        'AviosFiraBindingSource
        '
        Me.AviosFiraBindingSource.DataMember = "AviosFira"
        Me.AviosFiraBindingSource.DataSource = Me.FiraDSBindingSource
        '
        'FiraDSBindingSource
        '
        Me.FiraDSBindingSource.DataSource = Me.FiraDS
        Me.FiraDSBindingSource.Position = 0
        '
        'FiraDS
        '
        Me.FiraDS.DataSetName = "FiraDS"
        Me.FiraDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contratos Pendientes"
        '
        'BtnLiberar
        '
        Me.BtnLiberar.Location = New System.Drawing.Point(729, 477)
        Me.BtnLiberar.Name = "BtnLiberar"
        Me.BtnLiberar.Size = New System.Drawing.Size(107, 23)
        Me.BtnLiberar.TabIndex = 8
        Me.BtnLiberar.Text = "Liberar"
        Me.BtnLiberar.UseVisualStyleBackColor = True
        '
        'TxttotMinis
        '
        Me.TxttotMinis.Location = New System.Drawing.Point(882, 479)
        Me.TxttotMinis.Name = "TxttotMinis"
        Me.TxttotMinis.ReadOnly = True
        Me.TxttotMinis.Size = New System.Drawing.Size(107, 20)
        Me.TxttotMinis.TabIndex = 14
        Me.TxttotMinis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(842, 482)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Total "
        '
        'AviosFiraTableAdapter
        '
        Me.AviosFiraTableAdapter.ClearBeforeFill = True
        '
        'FrmAutoroizaAV_FIRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 506)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxttotMinis)
        Me.Controls.Add(Me.BtnLiberar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridAnexos)
        Me.Name = "FrmAutoroizaAV_FIRA"
        Me.Text = "Descuentos Fira AVIO"
        CType(Me.GridAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosFiraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiraDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiraDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridAnexos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLiberar As Button
    Friend WithEvents TxttotMinis As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents FiraDSBindingSource As BindingSource
    Friend WithEvents FiraDS As FiraDS
    Friend WithEvents AviosFiraBindingSource As BindingSource
    Friend WithEvents AviosFiraTableAdapter As FiraDSTableAdapters.AviosFIRATableAdapter
    Friend WithEvents NombreSucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CultivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoConDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloPagareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutorizaAutDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
