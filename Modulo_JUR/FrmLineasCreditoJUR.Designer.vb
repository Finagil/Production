<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLineasCreditoJUR
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
        Me.Txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.CmbCliente = New System.Windows.Forms.ComboBox()
        Me.ContClie1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New Agil.ProductionDataSet()
        Me.ContClie1TableAdapter = New Agil.ProductionDataSetTableAdapters.ContClie1TableAdapter()
        Me.CmbCiclo = New System.Windows.Forms.ComboBox()
        Me.CiclosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbCultivo = New System.Windows.Forms.ComboBox()
        Me.GENCultivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CiclosTableAdapter = New Agil.SegurosDSTableAdapters.CiclosTableAdapter()
        Me.GEN_CultivosTableAdapter = New Agil.SegurosDSTableAdapters.GEN_CultivosTableAdapter()
        Me.GRPdATOS = New System.Windows.Forms.GroupBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.CREDLineasCreditoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditoDS = New Agil.CreditoDS()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DtVigencia = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtMod = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbEstatus = New System.Windows.Forms.ComboBox()
        Me.CREDCatalogoEstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditoDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtAlta = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cmblineas = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CRED_LineasCreditoTableAdapter = New Agil.CreditoDSTableAdapters.CRED_LineasCreditoTableAdapter()
        Me.CRED_CatalogoEstatusTableAdapter = New Agil.CreditoDSTableAdapters.CRED_CatalogoEstatusTableAdapter()
        Me.BtnFactor = New System.Windows.Forms.Button()
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiclosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GENCultivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRPdATOS.SuspendLayout()
        CType(Me.CREDLineasCreditoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CREDCatalogoEstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtfiltro
        '
        Me.Txtfiltro.Location = New System.Drawing.Point(12, 26)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(424, 20)
        Me.Txtfiltro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 16)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Filtro"
        '
        'lblClientes
        '
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(13, 49)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(432, 16)
        Me.lblClientes.TabIndex = 61
        Me.lblClientes.Text = "Selecciona un Cliente de la siguiente Lista"
        '
        'CmbCliente
        '
        Me.CmbCliente.DataSource = Me.ContClie1BindingSource
        Me.CmbCliente.DisplayMember = "Descr"
        Me.CmbCliente.Location = New System.Drawing.Point(12, 67)
        Me.CmbCliente.MaxDropDownItems = 25
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(424, 21)
        Me.CmbCliente.TabIndex = 2
        Me.CmbCliente.ValueMember = "Cliente"
        '
        'ContClie1BindingSource
        '
        Me.ContClie1BindingSource.DataMember = "ContClie1"
        Me.ContClie1BindingSource.DataSource = Me.ProductionDataSet
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContClie1TableAdapter
        '
        Me.ContClie1TableAdapter.ClearBeforeFill = True
        '
        'CmbCiclo
        '
        Me.CmbCiclo.DataSource = Me.CiclosBindingSource
        Me.CmbCiclo.DisplayMember = "DescCiclo"
        Me.CmbCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCiclo.FormattingEnabled = True
        Me.CmbCiclo.Location = New System.Drawing.Point(12, 113)
        Me.CmbCiclo.Name = "CmbCiclo"
        Me.CmbCiclo.Size = New System.Drawing.Size(208, 21)
        Me.CmbCiclo.TabIndex = 3
        Me.CmbCiclo.ValueMember = "Ciclo"
        '
        'CiclosBindingSource
        '
        Me.CiclosBindingSource.DataMember = "Ciclos"
        Me.CiclosBindingSource.DataSource = Me.SegurosDS
        '
        'SegurosDS
        '
        Me.SegurosDS.DataSetName = "SegurosDS"
        Me.SegurosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Ciclo"
        '
        'CmbCultivo
        '
        Me.CmbCultivo.DataSource = Me.GENCultivosBindingSource
        Me.CmbCultivo.DisplayMember = "TitCombo"
        Me.CmbCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCultivo.FormattingEnabled = True
        Me.CmbCultivo.Location = New System.Drawing.Point(12, 153)
        Me.CmbCultivo.Name = "CmbCultivo"
        Me.CmbCultivo.Size = New System.Drawing.Size(208, 21)
        Me.CmbCultivo.TabIndex = 4
        Me.CmbCultivo.ValueMember = "idCultivo"
        '
        'GENCultivosBindingSource
        '
        Me.GENCultivosBindingSource.DataMember = "GEN_Cultivos"
        Me.GENCultivosBindingSource.DataSource = Me.SegurosDS
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Cultivo"
        '
        'CiclosTableAdapter
        '
        Me.CiclosTableAdapter.ClearBeforeFill = True
        '
        'GEN_CultivosTableAdapter
        '
        Me.GEN_CultivosTableAdapter.ClearBeforeFill = True
        '
        'GRPdATOS
        '
        Me.GRPdATOS.Controls.Add(Me.TxtUser)
        Me.GRPdATOS.Controls.Add(Me.Label5)
        Me.GRPdATOS.Controls.Add(Me.TextBox2)
        Me.GRPdATOS.Controls.Add(Me.Label11)
        Me.GRPdATOS.Controls.Add(Me.TxtTipo)
        Me.GRPdATOS.Controls.Add(Me.Label10)
        Me.GRPdATOS.Controls.Add(Me.DtVigencia)
        Me.GRPdATOS.Controls.Add(Me.Label9)
        Me.GRPdATOS.Controls.Add(Me.DtMod)
        Me.GRPdATOS.Controls.Add(Me.Label8)
        Me.GRPdATOS.Controls.Add(Me.CmbEstatus)
        Me.GRPdATOS.Controls.Add(Me.Label7)
        Me.GRPdATOS.Controls.Add(Me.DtAlta)
        Me.GRPdATOS.Controls.Add(Me.Label6)
        Me.GRPdATOS.Controls.Add(Me.TxtMonto)
        Me.GRPdATOS.Controls.Add(Me.Label4)
        Me.GRPdATOS.Location = New System.Drawing.Point(12, 220)
        Me.GRPdATOS.Name = "GRPdATOS"
        Me.GRPdATOS.Size = New System.Drawing.Size(423, 285)
        Me.GRPdATOS.TabIndex = 68
        Me.GRPdATOS.TabStop = False
        Me.GRPdATOS.Text = "Datos de la Linea"
        '
        'TxtUser
        '
        Me.TxtUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDLineasCreditoBindingSource, "usuario", True))
        Me.TxtUser.Location = New System.Drawing.Point(310, 158)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.ReadOnly = True
        Me.TxtUser.Size = New System.Drawing.Size(103, 20)
        Me.TxtUser.TabIndex = 16
        '
        'CREDLineasCreditoBindingSource
        '
        Me.CREDLineasCreditoBindingSource.DataMember = "CRED_LineasCredito"
        Me.CREDLineasCreditoBindingSource.DataSource = Me.CreditoDS
        '
        'CreditoDS
        '
        Me.CreditoDS.DataSetName = "CreditoDS"
        Me.CreditoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(307, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Usuario"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDLineasCreditoBindingSource, "Notas", True))
        Me.TextBox2.Location = New System.Drawing.Point(9, 183)
        Me.TextBox2.MaxLength = 300
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(403, 94)
        Me.TextBox2.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Observaciones"
        '
        'TxtTipo
        '
        Me.TxtTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDLineasCreditoBindingSource, "TipoLinea", True))
        Me.TxtTipo.Location = New System.Drawing.Point(310, 118)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.Size = New System.Drawing.Size(103, 20)
        Me.TxtTipo.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(307, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Tipo de Línea"
        '
        'DtVigencia
        '
        Me.DtVigencia.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CREDLineasCreditoBindingSource, "Vigencia", True))
        Me.DtVigencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtVigencia.Location = New System.Drawing.Point(9, 129)
        Me.DtVigencia.Name = "DtVigencia"
        Me.DtVigencia.Size = New System.Drawing.Size(121, 20)
        Me.DtVigencia.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Vencimiento Linea"
        '
        'DtMod
        '
        Me.DtMod.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CREDLineasCreditoBindingSource, "FechaModif", True))
        Me.DtMod.Enabled = False
        Me.DtMod.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtMod.Location = New System.Drawing.Point(310, 76)
        Me.DtMod.Name = "DtMod"
        Me.DtMod.Size = New System.Drawing.Size(101, 20)
        Me.DtMod.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(307, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fecha Modificacion"
        '
        'CmbEstatus
        '
        Me.CmbEstatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CREDLineasCreditoBindingSource, "Estatus", True))
        Me.CmbEstatus.DataSource = Me.CREDCatalogoEstatusBindingSource
        Me.CmbEstatus.DisplayMember = "Estatus"
        Me.CmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEstatus.FormattingEnabled = True
        Me.CmbEstatus.Location = New System.Drawing.Point(9, 85)
        Me.CmbEstatus.Name = "CmbEstatus"
        Me.CmbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CmbEstatus.TabIndex = 8
        Me.CmbEstatus.ValueMember = "id_EstatusCredito"
        '
        'CREDCatalogoEstatusBindingSource
        '
        Me.CREDCatalogoEstatusBindingSource.DataMember = "CRED_CatalogoEstatus"
        Me.CREDCatalogoEstatusBindingSource.DataSource = Me.CreditoDSBindingSource
        '
        'CreditoDSBindingSource
        '
        Me.CreditoDSBindingSource.DataSource = Me.CreditoDS
        Me.CreditoDSBindingSource.Position = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Estatus"
        '
        'DtAlta
        '
        Me.DtAlta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CREDLineasCreditoBindingSource, "FechaAlta", True))
        Me.DtAlta.Enabled = False
        Me.DtAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtAlta.Location = New System.Drawing.Point(310, 33)
        Me.DtAlta.Name = "DtAlta"
        Me.DtAlta.Size = New System.Drawing.Size(101, 20)
        Me.DtAlta.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(307, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Fecha Alta"
        '
        'TxtMonto
        '
        Me.TxtMonto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDLineasCreditoBindingSource, "MontoLinea", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtMonto.Location = New System.Drawing.Point(9, 43)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(122, 20)
        Me.TxtMonto.TabIndex = 7
        Me.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Monto de la Linea"
        '
        'Cmblineas
        '
        Me.Cmblineas.DataSource = Me.CREDLineasCreditoBindingSource
        Me.Cmblineas.DisplayMember = "id_lineaCredito"
        Me.Cmblineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmblineas.FormattingEnabled = True
        Me.Cmblineas.Location = New System.Drawing.Point(12, 193)
        Me.Cmblineas.Name = "Cmblineas"
        Me.Cmblineas.Size = New System.Drawing.Size(208, 21)
        Me.Cmblineas.TabIndex = 5
        Me.Cmblineas.ValueMember = "id_lineaCredito"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 13)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "No. Línea de Crédito"
        '
        'CRED_LineasCreditoTableAdapter
        '
        Me.CRED_LineasCreditoTableAdapter.ClearBeforeFill = True
        '
        'CRED_CatalogoEstatusTableAdapter
        '
        Me.CRED_CatalogoEstatusTableAdapter.ClearBeforeFill = True
        '
        'BtnFactor
        '
        Me.BtnFactor.Location = New System.Drawing.Point(333, 193)
        Me.BtnFactor.Name = "BtnFactor"
        Me.BtnFactor.Size = New System.Drawing.Size(102, 23)
        Me.BtnFactor.TabIndex = 73
        Me.BtnFactor.Text = "Fechas Factor"
        Me.BtnFactor.UseVisualStyleBackColor = True
        '
        'FrmLineasCreditoJUR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 508)
        Me.Controls.Add(Me.BtnFactor)
        Me.Controls.Add(Me.Cmblineas)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GRPdATOS)
        Me.Controls.Add(Me.CmbCultivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbCiclo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtfiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.CmbCliente)
        Me.Name = "FrmLineasCreditoJUR"
        Me.Text = "Fechas de Contrato CC y FACTORAJE"
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiclosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GENCultivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRPdATOS.ResumeLayout(False)
        Me.GRPdATOS.PerformLayout()
        CType(Me.CREDLineasCreditoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CREDCatalogoEstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtfiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClientes As Label
    Friend WithEvents CmbCliente As ComboBox
    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents ContClie1BindingSource As BindingSource
    Friend WithEvents ContClie1TableAdapter As ProductionDataSetTableAdapters.ContClie1TableAdapter
    Friend WithEvents CmbCiclo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbCultivo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SegurosDS As SegurosDS
    Friend WithEvents CiclosBindingSource As BindingSource
    Friend WithEvents CiclosTableAdapter As SegurosDSTableAdapters.CiclosTableAdapter
    Friend WithEvents GENCultivosBindingSource As BindingSource
    Friend WithEvents GEN_CultivosTableAdapter As SegurosDSTableAdapters.GEN_CultivosTableAdapter
    Friend WithEvents GRPdATOS As GroupBox
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DtAlta As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbEstatus As ComboBox
    Friend WithEvents DtVigencia As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents DtMod As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Cmblineas As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CREDLineasCreditoBindingSource As BindingSource
    Friend WithEvents CreditoDS As CreditoDS
    Friend WithEvents CRED_LineasCreditoTableAdapter As CreditoDSTableAdapters.CRED_LineasCreditoTableAdapter
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CreditoDSBindingSource As BindingSource
    Friend WithEvents CREDCatalogoEstatusBindingSource As BindingSource
    Friend WithEvents CRED_CatalogoEstatusTableAdapter As CreditoDSTableAdapters.CRED_CatalogoEstatusTableAdapter
    Friend WithEvents BtnFactor As Button
End Class
