<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAutoroizaAV_CRED
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GridAnexos = New System.Windows.Forms.DataGridView()
        Me.Ciclo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridDet = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSaldoAv = New System.Windows.Forms.TextBox()
        Me.TxtSaldoTRA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnLiberar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTotPen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxttotMinis = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtLinea = New System.Windows.Forms.TextBox()
        Me.BtnMail = New System.Windows.Forms.Button()
        Me.TxtObs = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AviosDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditoDS = New Agil.CreditoDS()
        Me.AviosCREBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AviosDetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditoDS1 = New Agil.CreditoDS()
        Me.NombreSucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloPagareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CultivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AviosCRETableAdapter = New Agil.CreditoDSTableAdapters.AviosCRETableAdapter()
        Me.AviosDetTableAdapter = New Agil.CreditoDSTableAdapters.AviosDetTableAdapter()
        Me.FechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoDataGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloDataGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinistracionDataGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Autoriza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditoAut = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MesaControl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotasCreditoDataGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditoDataGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GridAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosCREBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosDetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridAnexos
        '
        Me.GridAnexos.AllowUserToAddRows = False
        Me.GridAnexos.AllowUserToDeleteRows = False
        Me.GridAnexos.AutoGenerateColumns = False
        Me.GridAnexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAnexos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreSucursalDataGridViewTextBoxColumn, Me.AnexoConDataGridViewTextBoxColumn, Me.CicloPagareDataGridViewTextBoxColumn, Me.CultivoDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn, Me.AnexoDataGridViewTextBoxColumn, Me.Ciclo})
        Me.GridAnexos.DataSource = Me.AviosCREBindingSource
        Me.GridAnexos.Location = New System.Drawing.Point(13, 29)
        Me.GridAnexos.Name = "GridAnexos"
        Me.GridAnexos.ReadOnly = True
        Me.GridAnexos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridAnexos.Size = New System.Drawing.Size(976, 260)
        Me.GridAnexos.TabIndex = 0
        '
        'Ciclo
        '
        Me.Ciclo.DataPropertyName = "Ciclo"
        Me.Ciclo.HeaderText = "Ciclo"
        Me.Ciclo.Name = "Ciclo"
        Me.Ciclo.ReadOnly = True
        Me.Ciclo.Visible = False
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
        'GridDet
        '
        Me.GridDet.AllowUserToAddRows = False
        Me.GridDet.AllowUserToDeleteRows = False
        Me.GridDet.AutoGenerateColumns = False
        Me.GridDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaAlta, Me.AnexoDataGrid, Me.CicloDataGrid, Me.MinistracionDataGrid, Me.ConceptoDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.Autoriza, Me.CreditoAut, Me.MesaControl, Me.NotasCreditoDataGrid, Me.CreditoDataGrid})
        Me.GridDet.DataSource = Me.AviosDetBindingSource
        Me.GridDet.Location = New System.Drawing.Point(16, 317)
        Me.GridDet.Name = "GridDet"
        Me.GridDet.Size = New System.Drawing.Size(417, 150)
        Me.GridDet.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Detalle para Liberar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(454, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Saldo Vencido Avio"
        '
        'TxtSaldoAv
        '
        Me.TxtSaldoAv.Location = New System.Drawing.Point(451, 342)
        Me.TxtSaldoAv.Name = "TxtSaldoAv"
        Me.TxtSaldoAv.ReadOnly = True
        Me.TxtSaldoAv.Size = New System.Drawing.Size(107, 20)
        Me.TxtSaldoAv.TabIndex = 5
        Me.TxtSaldoAv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSaldoTRA
        '
        Me.TxtSaldoTRA.Location = New System.Drawing.Point(451, 389)
        Me.TxtSaldoTRA.Name = "TxtSaldoTRA"
        Me.TxtSaldoTRA.ReadOnly = True
        Me.TxtSaldoTRA.Size = New System.Drawing.Size(107, 20)
        Me.TxtSaldoTRA.TabIndex = 7
        Me.TxtSaldoTRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(439, 369)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Saldo Vencido Tradicional"
        '
        'BtnLiberar
        '
        Me.BtnLiberar.Location = New System.Drawing.Point(451, 415)
        Me.BtnLiberar.Name = "BtnLiberar"
        Me.BtnLiberar.Size = New System.Drawing.Size(107, 23)
        Me.BtnLiberar.TabIndex = 8
        Me.BtnLiberar.Text = "Liberar"
        Me.BtnLiberar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(569, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Detalle para Liberar"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView2.DataSource = Me.AviosDetBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(573, 318)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(417, 150)
        Me.DataGridView2.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FechaAlta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha Alta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'TxtTotPen
        '
        Me.TxtTotPen.Location = New System.Drawing.Point(326, 473)
        Me.TxtTotPen.Name = "TxtTotPen"
        Me.TxtTotPen.ReadOnly = True
        Me.TxtTotPen.Size = New System.Drawing.Size(107, 20)
        Me.TxtTotPen.TabIndex = 12
        Me.TxtTotPen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(286, 476)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total "
        '
        'TxttotMinis
        '
        Me.TxttotMinis.Location = New System.Drawing.Point(882, 473)
        Me.TxttotMinis.Name = "TxttotMinis"
        Me.TxttotMinis.ReadOnly = True
        Me.TxttotMinis.Size = New System.Drawing.Size(107, 20)
        Me.TxttotMinis.TabIndex = 14
        Me.TxttotMinis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(842, 476)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Total "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(790, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Linea Autorizada"
        '
        'TxtLinea
        '
        Me.TxtLinea.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AviosCREBindingSource, "MontoFinanciado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtLinea.Location = New System.Drawing.Point(882, 293)
        Me.TxtLinea.Name = "TxtLinea"
        Me.TxtLinea.ReadOnly = True
        Me.TxtLinea.Size = New System.Drawing.Size(107, 20)
        Me.TxtLinea.TabIndex = 16
        Me.TxtLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnMail
        '
        Me.BtnMail.Location = New System.Drawing.Point(641, 574)
        Me.BtnMail.Name = "BtnMail"
        Me.BtnMail.Size = New System.Drawing.Size(47, 21)
        Me.BtnMail.TabIndex = 151
        Me.BtnMail.Text = "Correo"
        '
        'TxtObs
        '
        Me.TxtObs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AviosDetBindingSource, "NotasCredito", True))
        Me.TxtObs.Location = New System.Drawing.Point(16, 499)
        Me.TxtObs.MaxLength = 1000
        Me.TxtObs.Multiline = True
        Me.TxtObs.Name = "TxtObs"
        Me.TxtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObs.Size = New System.Drawing.Size(619, 96)
        Me.TxtObs.TabIndex = 153
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 483)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 152
        Me.Label9.Text = "Observaciones"
        '
        'AviosDetBindingSource
        '
        Me.AviosDetBindingSource.DataMember = "AviosDet"
        Me.AviosDetBindingSource.DataSource = Me.CreditoDS
        '
        'CreditoDS
        '
        Me.CreditoDS.DataSetName = "CreditoDS"
        Me.CreditoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AviosCREBindingSource
        '
        Me.AviosCREBindingSource.DataMember = "AviosCRE"
        Me.AviosCREBindingSource.DataSource = Me.CreditoDS
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Anexo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Anexo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Ciclo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ciclo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ministracion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ministracion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Concepto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Concepto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Importe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'AviosDetBindingSource1
        '
        Me.AviosDetBindingSource1.DataMember = "AviosDet"
        Me.AviosDetBindingSource1.DataSource = Me.CreditoDS1
        '
        'CreditoDS1
        '
        Me.CreditoDS1.DataSetName = "CreditoDS"
        Me.CreditoDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreSucursalDataGridViewTextBoxColumn
        '
        Me.NombreSucursalDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Sucursal"
        Me.NombreSucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.NombreSucursalDataGridViewTextBoxColumn.Name = "NombreSucursalDataGridViewTextBoxColumn"
        Me.NombreSucursalDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreSucursalDataGridViewTextBoxColumn.Width = 80
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
        Me.CicloPagareDataGridViewTextBoxColumn.Width = 80
        '
        'CultivoDataGridViewTextBoxColumn
        '
        Me.CultivoDataGridViewTextBoxColumn.DataPropertyName = "Cultivo"
        Me.CultivoDataGridViewTextBoxColumn.HeaderText = "Cultivo"
        Me.CultivoDataGridViewTextBoxColumn.Name = "CultivoDataGridViewTextBoxColumn"
        Me.CultivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CultivoDataGridViewTextBoxColumn.Width = 80
        '
        'DescrDataGridViewTextBoxColumn
        '
        Me.DescrDataGridViewTextBoxColumn.DataPropertyName = "Descr"
        Me.DescrDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.DescrDataGridViewTextBoxColumn.Name = "DescrDataGridViewTextBoxColumn"
        Me.DescrDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescrDataGridViewTextBoxColumn.Width = 250
        '
        'TipoCreditoDataGridViewTextBoxColumn
        '
        Me.TipoCreditoDataGridViewTextBoxColumn.DataPropertyName = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCreditoDataGridViewTextBoxColumn.Width = 150
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Visible = False
        '
        'AviosCRETableAdapter
        '
        Me.AviosCRETableAdapter.ClearBeforeFill = True
        '
        'AviosDetTableAdapter
        '
        Me.AviosDetTableAdapter.ClearBeforeFill = True
        '
        'FechaAlta
        '
        Me.FechaAlta.DataPropertyName = "FechaAlta"
        Me.FechaAlta.HeaderText = "Fecha Alta"
        Me.FechaAlta.Name = "FechaAlta"
        Me.FechaAlta.ReadOnly = True
        Me.FechaAlta.Width = 80
        '
        'AnexoDataGrid
        '
        Me.AnexoDataGrid.DataPropertyName = "Anexo"
        Me.AnexoDataGrid.HeaderText = "Anexo"
        Me.AnexoDataGrid.Name = "AnexoDataGrid"
        Me.AnexoDataGrid.ReadOnly = True
        Me.AnexoDataGrid.Visible = False
        '
        'CicloDataGrid
        '
        Me.CicloDataGrid.DataPropertyName = "Ciclo"
        Me.CicloDataGrid.HeaderText = "Ciclo"
        Me.CicloDataGrid.Name = "CicloDataGrid"
        Me.CicloDataGrid.ReadOnly = True
        Me.CicloDataGrid.Visible = False
        '
        'MinistracionDataGrid
        '
        Me.MinistracionDataGrid.DataPropertyName = "Ministracion"
        Me.MinistracionDataGrid.HeaderText = "Ministracion"
        Me.MinistracionDataGrid.Name = "MinistracionDataGrid"
        Me.MinistracionDataGrid.ReadOnly = True
        Me.MinistracionDataGrid.Visible = False
        '
        'ConceptoDataGridViewTextBoxColumn
        '
        Me.ConceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.HeaderText = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.Name = "ConceptoDataGridViewTextBoxColumn"
        Me.ConceptoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConceptoDataGridViewTextBoxColumn.Width = 120
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
        Me.ImporteDataGridViewTextBoxColumn.Width = 80
        '
        'Autoriza
        '
        Me.Autoriza.DataPropertyName = "Autoriza"
        Me.Autoriza.HeaderText = "Autoriza"
        Me.Autoriza.Name = "Autoriza"
        Me.Autoriza.ReadOnly = True
        Me.Autoriza.Visible = False
        '
        'CreditoAut
        '
        Me.CreditoAut.DataPropertyName = "CreditoAut"
        Me.CreditoAut.HeaderText = "Revisado"
        Me.CreditoAut.Name = "CreditoAut"
        Me.CreditoAut.Width = 60
        '
        'MesaControl
        '
        Me.MesaControl.DataPropertyName = "MesaControl"
        Me.MesaControl.HeaderText = "MesaControl"
        Me.MesaControl.Name = "MesaControl"
        Me.MesaControl.Visible = False
        '
        'NotasCreditoDataGrid
        '
        Me.NotasCreditoDataGrid.DataPropertyName = "NotasCredito"
        Me.NotasCreditoDataGrid.HeaderText = "NotasCredito"
        Me.NotasCreditoDataGrid.Name = "NotasCreditoDataGrid"
        Me.NotasCreditoDataGrid.Visible = False
        '
        'CreditoDataGrid
        '
        Me.CreditoDataGrid.DataPropertyName = "Credito"
        Me.CreditoDataGrid.HeaderText = "Credito"
        Me.CreditoDataGrid.Name = "CreditoDataGrid"
        Me.CreditoDataGrid.Visible = False
        '
        'FrmAutoroizaAV_CRED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 603)
        Me.Controls.Add(Me.BtnMail)
        Me.Controls.Add(Me.TxtObs)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtLinea)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxttotMinis)
        Me.Controls.Add(Me.TxtTotPen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.BtnLiberar)
        Me.Controls.Add(Me.TxtSaldoTRA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtSaldoAv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GridDet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridAnexos)
        Me.Name = "FrmAutoroizaAV_CRED"
        Me.Text = " Liberacion de Ministraciones CREDITO"
        CType(Me.GridAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosCREBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosDetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridAnexos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CreditoDS As CreditoDS
    Friend WithEvents AviosCREBindingSource As BindingSource
    Friend WithEvents AviosCRETableAdapter As CreditoDSTableAdapters.AviosCRETableAdapter
    Friend WithEvents GridDet As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents AviosDetBindingSource As BindingSource
    Friend WithEvents AviosDetTableAdapter As CreditoDSTableAdapters.AviosDetTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSaldoAv As TextBox
    Friend WithEvents TxtSaldoTRA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnLiberar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents AviosDetBindingSource1 As BindingSource
    Friend WithEvents CreditoDS1 As CreditoDS
    Friend WithEvents TxtTotPen As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxttotMinis As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtLinea As TextBox
    Friend WithEvents BtnMail As Button
    Friend WithEvents TxtObs As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents NombreSucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoConDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloPagareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CultivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ciclo As DataGridViewTextBoxColumn
    Friend WithEvents MesaControlAutDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FechaAlta As DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGrid As DataGridViewTextBoxColumn
    Friend WithEvents CicloDataGrid As DataGridViewTextBoxColumn
    Friend WithEvents MinistracionDataGrid As DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Autoriza As DataGridViewTextBoxColumn
    Friend WithEvents CreditoAut As DataGridViewCheckBoxColumn
    Friend WithEvents MesaControl As DataGridViewTextBoxColumn
    Friend WithEvents NotasCreditoDataGrid As DataGridViewTextBoxColumn
    Friend WithEvents CreditoDataGrid As DataGridViewTextBoxColumn
End Class
