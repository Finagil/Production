﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLiberacionesSEG
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
        Me.CmbAnexo = New System.Windows.Forms.ComboBox()
        Me.AnexosSEGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbClientes = New System.Windows.Forms.ComboBox()
        Me.ClientesSEGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonADD = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Descr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloPagareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlazoMaximoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LiberadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VWLiberacionesMCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTPplazo = New System.Windows.Forms.DateTimePicker()
        Me.SEGLiberacionesMCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextNotas = New System.Windows.Forms.TextBox()
        Me.ButtonLIB = New System.Windows.Forms.Button()
        Me.ClientesSEGTableAdapter = New Agil.SegurosDSTableAdapters.ClientesSEGTableAdapter()
        Me.AnexosSEGTableAdapter = New Agil.SegurosDSTableAdapters.AnexosSEGTableAdapter()
        Me.VW_LiberacionesMCTableAdapter = New Agil.SegurosDSTableAdapters.VW_LiberacionesMCTableAdapter()
        Me.SEG_LiberacionesMCTableAdapter = New Agil.SegurosDSTableAdapters.SEG_LiberacionesMCTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.AnexosSEGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesSEGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWLiberacionesMCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGLiberacionesMCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbAnexo
        '
        Me.CmbAnexo.DataSource = Me.AnexosSEGBindingSource
        Me.CmbAnexo.DisplayMember = "titulo"
        Me.CmbAnexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnexo.FormattingEnabled = True
        Me.CmbAnexo.Location = New System.Drawing.Point(12, 88)
        Me.CmbAnexo.Name = "CmbAnexo"
        Me.CmbAnexo.Size = New System.Drawing.Size(234, 21)
        Me.CmbAnexo.TabIndex = 14
        Me.CmbAnexo.ValueMember = "Anexo"
        '
        'AnexosSEGBindingSource
        '
        Me.AnexosSEGBindingSource.DataMember = "AnexosSEG"
        Me.AnexosSEGBindingSource.DataSource = Me.SegurosDS
        '
        'SegurosDS
        '
        Me.SegurosDS.DataSetName = "SegurosDS"
        Me.SegurosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = " Anexos"
        '
        'CmbClientes
        '
        Me.CmbClientes.DataSource = Me.ClientesSEGBindingSource
        Me.CmbClientes.DisplayMember = "Descr"
        Me.CmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(12, 47)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(425, 21)
        Me.CmbClientes.TabIndex = 12
        Me.CmbClientes.ValueMember = "Cliente"
        '
        'ClientesSEGBindingSource
        '
        Me.ClientesSEGBindingSource.DataMember = "ClientesSEG"
        Me.ClientesSEGBindingSource.DataSource = Me.SegurosDS
        '
        'Txtfiltro
        '
        Me.Txtfiltro.Location = New System.Drawing.Point(12, 21)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(425, 20)
        Me.Txtfiltro.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Filtro Cliente"
        '
        'ButtonADD
        '
        Me.ButtonADD.Location = New System.Drawing.Point(326, 88)
        Me.ButtonADD.Name = "ButtonADD"
        Me.ButtonADD.Size = New System.Drawing.Size(111, 23)
        Me.ButtonADD.TabIndex = 15
        Me.ButtonADD.Text = "Agregar Liberación"
        Me.ButtonADD.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Liberaciones"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descr, Me.AnexoConDataGridViewTextBoxColumn, Me.CicloPagareDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn, Me.PlazoMaximoDataGridViewTextBoxColumn, Me.LiberadoDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.VWLiberacionesMCBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(861, 234)
        Me.DataGridView1.TabIndex = 17
        '
        'Descr
        '
        Me.Descr.DataPropertyName = "Descr"
        Me.Descr.HeaderText = "Cliente"
        Me.Descr.Name = "Descr"
        Me.Descr.ReadOnly = True
        Me.Descr.Width = 250
        '
        'AnexoConDataGridViewTextBoxColumn
        '
        Me.AnexoConDataGridViewTextBoxColumn.DataPropertyName = "AnexoCon"
        Me.AnexoConDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoConDataGridViewTextBoxColumn.Name = "AnexoConDataGridViewTextBoxColumn"
        Me.AnexoConDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoConDataGridViewTextBoxColumn.Width = 90
        '
        'CicloPagareDataGridViewTextBoxColumn
        '
        Me.CicloPagareDataGridViewTextBoxColumn.DataPropertyName = "CicloPagare"
        Me.CicloPagareDataGridViewTextBoxColumn.HeaderText = "Ciclo"
        Me.CicloPagareDataGridViewTextBoxColumn.Name = "CicloPagareDataGridViewTextBoxColumn"
        Me.CicloPagareDataGridViewTextBoxColumn.ReadOnly = True
        Me.CicloPagareDataGridViewTextBoxColumn.Width = 80
        '
        'TipoCreditoDataGridViewTextBoxColumn
        '
        Me.TipoCreditoDataGridViewTextBoxColumn.DataPropertyName = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "Tipo de Crédito"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCreditoDataGridViewTextBoxColumn.Width = 200
        '
        'PlazoMaximoDataGridViewTextBoxColumn
        '
        Me.PlazoMaximoDataGridViewTextBoxColumn.DataPropertyName = "PlazoMaximo"
        Me.PlazoMaximoDataGridViewTextBoxColumn.HeaderText = "Plazo Máximo"
        Me.PlazoMaximoDataGridViewTextBoxColumn.Name = "PlazoMaximoDataGridViewTextBoxColumn"
        Me.PlazoMaximoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LiberadoDataGridViewCheckBoxColumn
        '
        Me.LiberadoDataGridViewCheckBoxColumn.DataPropertyName = "Liberado"
        Me.LiberadoDataGridViewCheckBoxColumn.HeaderText = "Liberado"
        Me.LiberadoDataGridViewCheckBoxColumn.Name = "LiberadoDataGridViewCheckBoxColumn"
        Me.LiberadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.LiberadoDataGridViewCheckBoxColumn.Width = 70
        '
        'VWLiberacionesMCBindingSource
        '
        Me.VWLiberacionesMCBindingSource.DataMember = "VW_LiberacionesMC"
        Me.VWLiberacionesMCBindingSource.DataSource = Me.SegurosDS
        '
        'DTPplazo
        '
        Me.DTPplazo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SEGLiberacionesMCBindingSource, "PlazoMaximo", True))
        Me.DTPplazo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPplazo.Location = New System.Drawing.Point(14, 384)
        Me.DTPplazo.Name = "DTPplazo"
        Me.DTPplazo.Size = New System.Drawing.Size(108, 20)
        Me.DTPplazo.TabIndex = 18
        '
        'SEGLiberacionesMCBindingSource
        '
        Me.SEGLiberacionesMCBindingSource.DataMember = "SEG_LiberacionesMC"
        Me.SEGLiberacionesMCBindingSource.DataSource = Me.SegurosDS
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "PlazoMaximo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(133, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Observaciones"
        '
        'TextNotas
        '
        Me.TextNotas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGLiberacionesMCBindingSource, "Notas", True))
        Me.TextNotas.Location = New System.Drawing.Point(136, 384)
        Me.TextNotas.MaxLength = 200
        Me.TextNotas.Multiline = True
        Me.TextNotas.Name = "TextNotas"
        Me.TextNotas.Size = New System.Drawing.Size(518, 46)
        Me.TextNotas.TabIndex = 21
        '
        'ButtonLIB
        '
        Me.ButtonLIB.Location = New System.Drawing.Point(799, 385)
        Me.ButtonLIB.Name = "ButtonLIB"
        Me.ButtonLIB.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLIB.TabIndex = 23
        Me.ButtonLIB.Text = "Liberar"
        Me.ButtonLIB.UseVisualStyleBackColor = True
        '
        'ClientesSEGTableAdapter
        '
        Me.ClientesSEGTableAdapter.ClearBeforeFill = True
        '
        'AnexosSEGTableAdapter
        '
        Me.AnexosSEGTableAdapter.ClearBeforeFill = True
        '
        'VW_LiberacionesMCTableAdapter
        '
        Me.VW_LiberacionesMCTableAdapter.ClearBeforeFill = True
        '
        'SEG_LiberacionesMCTableAdapter
        '
        Me.SEG_LiberacionesMCTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(660, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Correo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmLiberacionesSEG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 437)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonLIB)
        Me.Controls.Add(Me.TextNotas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DTPplazo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonADD)
        Me.Controls.Add(Me.CmbAnexo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbClientes)
        Me.Controls.Add(Me.Txtfiltro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLiberacionesSEG"
        Me.Text = "Liberaciones de Seguros para Mesa de Control"
        CType(Me.AnexosSEGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesSEGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWLiberacionesMCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGLiberacionesMCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbAnexo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbClientes As ComboBox
    Friend WithEvents Txtfiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonADD As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DTPplazo As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextNotas As TextBox
    Friend WithEvents ButtonLIB As Button
    Friend WithEvents SegurosDS As SegurosDS
    Friend WithEvents ClientesSEGBindingSource As BindingSource
    Friend WithEvents ClientesSEGTableAdapter As SegurosDSTableAdapters.ClientesSEGTableAdapter
    Friend WithEvents AnexosSEGBindingSource As BindingSource
    Friend WithEvents AnexosSEGTableAdapter As SegurosDSTableAdapters.AnexosSEGTableAdapter
    Friend WithEvents VWLiberacionesMCBindingSource As BindingSource
    Friend WithEvents VW_LiberacionesMCTableAdapter As SegurosDSTableAdapters.VW_LiberacionesMCTableAdapter
    Friend WithEvents Descr As DataGridViewTextBoxColumn
    Friend WithEvents AnexoConDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloPagareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlazoMaximoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LiberadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SEGLiberacionesMCBindingSource As BindingSource
    Friend WithEvents SEG_LiberacionesMCTableAdapter As SegurosDSTableAdapters.SEG_LiberacionesMCTableAdapter
    Friend WithEvents Button1 As Button
End Class