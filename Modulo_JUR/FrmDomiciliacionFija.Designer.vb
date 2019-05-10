<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDomiciliacionFija
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboCli = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JuridicoDS = New Agil.JuridicoDS()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboAnex = New System.Windows.Forms.ComboBox()
        Me.AnexosDomiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextImporte = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwDomiciliacionFijaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextImporte2 = New System.Windows.Forms.TextBox()
        Me.JURDomiciliacionFijaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckActivo = New System.Windows.Forms.CheckBox()
        Me.ClientesTableAdapter = New Agil.JuridicoDSTableAdapters.ClientesTableAdapter()
        Me.AnexosDomiTableAdapter = New Agil.JuridicoDSTableAdapters.AnexosDomiTableAdapter()
        Me.Vw_DomiciliacionFijaTableAdapter = New Agil.JuridicoDSTableAdapters.Vw_DomiciliacionFijaTableAdapter()
        Me.JUR_DomiciliacionFijaTableAdapter = New Agil.JuridicoDSTableAdapters.JUR_DomiciliacionFijaTableAdapter()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosDomiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDomiciliacionFijaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JURDomiciliacionFijaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes Domiciliados"
        '
        'ComboCli
        '
        Me.ComboCli.DataSource = Me.ClientesBindingSource
        Me.ComboCli.DisplayMember = "Nombre"
        Me.ComboCli.FormattingEnabled = True
        Me.ComboCli.Location = New System.Drawing.Point(13, 26)
        Me.ComboCli.Name = "ComboCli"
        Me.ComboCli.Size = New System.Drawing.Size(477, 21)
        Me.ComboCli.TabIndex = 1
        Me.ComboCli.ValueMember = "Cliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.JuridicoDS
        '
        'JuridicoDS
        '
        Me.JuridicoDS.DataSetName = "JuridicoDS"
        Me.JuridicoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Anexos Domiciliados"
        '
        'ComboAnex
        '
        Me.ComboAnex.DataSource = Me.AnexosDomiBindingSource
        Me.ComboAnex.DisplayMember = "AnexoCon"
        Me.ComboAnex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboAnex.FormattingEnabled = True
        Me.ComboAnex.Location = New System.Drawing.Point(13, 70)
        Me.ComboAnex.Name = "ComboAnex"
        Me.ComboAnex.Size = New System.Drawing.Size(121, 21)
        Me.ComboAnex.TabIndex = 3
        Me.ComboAnex.ValueMember = "Anexo"
        '
        'AnexosDomiBindingSource
        '
        Me.AnexosDomiBindingSource.DataMember = "AnexosDomi"
        Me.AnexosDomiBindingSource.DataSource = Me.JuridicoDS
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Importe Fijo"
        '
        'TextImporte
        '
        Me.TextImporte.Location = New System.Drawing.Point(140, 70)
        Me.TextImporte.Name = "TextImporte"
        Me.TextImporte.Size = New System.Drawing.Size(118, 20)
        Me.TextImporte.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescrDataGridViewTextBoxColumn, Me.AnexoConDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.ActivoDataGridViewCheckBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.FechaAltaDataGridViewTextBoxColumn, Me.Estatus})
        Me.DataGridView1.DataSource = Me.VwDomiciliacionFijaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1098, 340)
        Me.DataGridView1.TabIndex = 7
        '
        'DescrDataGridViewTextBoxColumn
        '
        Me.DescrDataGridViewTextBoxColumn.DataPropertyName = "Descr"
        Me.DescrDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.DescrDataGridViewTextBoxColumn.Name = "DescrDataGridViewTextBoxColumn"
        Me.DescrDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescrDataGridViewTextBoxColumn.Width = 300
        '
        'AnexoConDataGridViewTextBoxColumn
        '
        Me.AnexoConDataGridViewTextBoxColumn.DataPropertyName = "AnexoCon"
        Me.AnexoConDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoConDataGridViewTextBoxColumn.Name = "AnexoConDataGridViewTextBoxColumn"
        Me.AnexoConDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoConDataGridViewTextBoxColumn.Width = 90
        '
        'TipoCreditoDataGridViewTextBoxColumn
        '
        Me.TipoCreditoDataGridViewTextBoxColumn.DataPropertyName = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "Tipo Credito"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCreditoDataGridViewTextBoxColumn.Width = 200
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
        Me.ImporteDataGridViewTextBoxColumn.Width = 90
        '
        'ActivoDataGridViewCheckBoxColumn
        '
        Me.ActivoDataGridViewCheckBoxColumn.DataPropertyName = "Activo"
        Me.ActivoDataGridViewCheckBoxColumn.HeaderText = "Activo"
        Me.ActivoDataGridViewCheckBoxColumn.Name = "ActivoDataGridViewCheckBoxColumn"
        Me.ActivoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ActivoDataGridViewCheckBoxColumn.Width = 80
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Width = 90
        '
        'FechaAltaDataGridViewTextBoxColumn
        '
        Me.FechaAltaDataGridViewTextBoxColumn.DataPropertyName = "FechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.HeaderText = "Fecha Alta"
        Me.FechaAltaDataGridViewTextBoxColumn.Name = "FechaAltaDataGridViewTextBoxColumn"
        Me.FechaAltaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaAltaDataGridViewTextBoxColumn.Width = 90
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Status"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        '
        'VwDomiciliacionFijaBindingSource
        '
        Me.VwDomiciliacionFijaBindingSource.DataMember = "Vw_DomiciliacionFija"
        Me.VwDomiciliacionFijaBindingSource.DataSource = Me.JuridicoDS
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(203, 453)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextImporte2
        '
        Me.TextImporte2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JURDomiciliacionFijaBindingSource, "Importe", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextImporte2.Location = New System.Drawing.Point(16, 456)
        Me.TextImporte2.Name = "TextImporte2"
        Me.TextImporte2.Size = New System.Drawing.Size(118, 20)
        Me.TextImporte2.TabIndex = 10
        '
        'JURDomiciliacionFijaBindingSource
        '
        Me.JURDomiciliacionFijaBindingSource.DataMember = "JUR_DomiciliacionFija"
        Me.JURDomiciliacionFijaBindingSource.DataSource = Me.JuridicoDS
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 440)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Importe Fijo"
        '
        'CheckActivo
        '
        Me.CheckActivo.AutoSize = True
        Me.CheckActivo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.JURDomiciliacionFijaBindingSource, "Activo", True))
        Me.CheckActivo.Location = New System.Drawing.Point(141, 456)
        Me.CheckActivo.Name = "CheckActivo"
        Me.CheckActivo.Size = New System.Drawing.Size(56, 17)
        Me.CheckActivo.TabIndex = 11
        Me.CheckActivo.Text = "Activo"
        Me.CheckActivo.UseVisualStyleBackColor = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'AnexosDomiTableAdapter
        '
        Me.AnexosDomiTableAdapter.ClearBeforeFill = True
        '
        'Vw_DomiciliacionFijaTableAdapter
        '
        Me.Vw_DomiciliacionFijaTableAdapter.ClearBeforeFill = True
        '
        'JUR_DomiciliacionFijaTableAdapter
        '
        Me.JUR_DomiciliacionFijaTableAdapter.ClearBeforeFill = True
        '
        'FrmDomiciliacionFija
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 481)
        Me.Controls.Add(Me.CheckActivo)
        Me.Controls.Add(Me.TextImporte2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextImporte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboAnex)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboCli)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDomiciliacionFija"
        Me.Text = "Configurar Pago Fijo Domiciliado"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosDomiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDomiciliacionFijaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JURDomiciliacionFijaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboCli As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboAnex As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextImporte As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents TextImporte2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckActivo As CheckBox
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents JuridicoDS As JuridicoDS
    Friend WithEvents AnexosDomiBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As JuridicoDSTableAdapters.ClientesTableAdapter
    Friend WithEvents AnexosDomiTableAdapter As JuridicoDSTableAdapters.AnexosDomiTableAdapter
    Friend WithEvents VwDomiciliacionFijaBindingSource As BindingSource
    Friend WithEvents Vw_DomiciliacionFijaTableAdapter As JuridicoDSTableAdapters.Vw_DomiciliacionFijaTableAdapter
    Friend WithEvents JURDomiciliacionFijaBindingSource As BindingSource
    Friend WithEvents JUR_DomiciliacionFijaTableAdapter As JuridicoDSTableAdapters.JUR_DomiciliacionFijaTableAdapter
    Friend WithEvents DescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoConDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActivoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Estatus As DataGridViewTextBoxColumn
End Class
