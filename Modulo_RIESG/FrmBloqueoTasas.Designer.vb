<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBloqueoTasas
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
        Me.components = New System.ComponentModel.Container()
        Me.GridAnexos = New System.Windows.Forms.DataGridView()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexosBloqueadoTasaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.RiesgosDS()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTasaPol = New System.Windows.Forms.TextBox()
        Me.TxtTasasol = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtComents = New System.Windows.Forms.TextBox()
        Me.TxtIndica = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.AnexosBloqueadoTasaTableAdapter = New Agil.RiesgosDSTableAdapters.AnexosBloqueadoTasaTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComentarioRiesgos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaPol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaSol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexosBloqueadoTasaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS1 = New Agil.RiesgosDS()
        CType(Me.GridAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosBloqueadoTasaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosBloqueadoTasaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridAnexos
        '
        Me.GridAnexos.AllowUserToAddRows = False
        Me.GridAnexos.AllowUserToDeleteRows = False
        Me.GridAnexos.AutoGenerateColumns = False
        Me.GridAnexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAnexos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.AnexoConDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn})
        Me.GridAnexos.DataSource = Me.AnexosBloqueadoTasaBindingSource
        Me.GridAnexos.Location = New System.Drawing.Point(12, 12)
        Me.GridAnexos.Name = "GridAnexos"
        Me.GridAnexos.ReadOnly = True
        Me.GridAnexos.Size = New System.Drawing.Size(784, 150)
        Me.GridAnexos.TabIndex = 0
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Visible = False
        '
        'AnexoConDataGridViewTextBoxColumn
        '
        Me.AnexoConDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.AnexoConDataGridViewTextBoxColumn.DataPropertyName = "AnexoCon"
        Me.AnexoConDataGridViewTextBoxColumn.HeaderText = "Contrato"
        Me.AnexoConDataGridViewTextBoxColumn.Name = "AnexoConDataGridViewTextBoxColumn"
        Me.AnexoConDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoConDataGridViewTextBoxColumn.Width = 80
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 80
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
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCreditoDataGridViewTextBoxColumn.Width = 200
        '
        'AnexosBloqueadoTasaBindingSource
        '
        Me.AnexosBloqueadoTasaBindingSource.DataMember = "AnexosBloqueadoTasa"
        Me.AnexosBloqueadoTasaBindingSource.DataSource = Me.GeneralDS
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBloqueadoTasaBindingSource, "ComentarioPromo", True))
        Me.TextBox1.Location = New System.Drawing.Point(13, 184)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(282, 76)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Comentarios Promoción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tasa Política"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(298, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tasa Solicitada"
        '
        'TxtTasaPol
        '
        Me.TxtTasaPol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBloqueadoTasaBindingSource, "TasaPol", True))
        Me.TxtTasaPol.Location = New System.Drawing.Point(301, 184)
        Me.TxtTasaPol.Name = "TxtTasaPol"
        Me.TxtTasaPol.ReadOnly = True
        Me.TxtTasaPol.Size = New System.Drawing.Size(77, 20)
        Me.TxtTasaPol.TabIndex = 5
        '
        'TxtTasasol
        '
        Me.TxtTasasol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBloqueadoTasaBindingSource, "TasaSol", True))
        Me.TxtTasasol.Location = New System.Drawing.Point(301, 240)
        Me.TxtTasasol.Name = "TxtTasasol"
        Me.TxtTasasol.ReadOnly = True
        Me.TxtTasasol.Size = New System.Drawing.Size(77, 20)
        Me.TxtTasasol.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Comentarios Riesgos"
        '
        'TxtComents
        '
        Me.TxtComents.Location = New System.Drawing.Point(387, 182)
        Me.TxtComents.MaxLength = 400
        Me.TxtComents.Multiline = True
        Me.TxtComents.Name = "TxtComents"
        Me.TxtComents.Size = New System.Drawing.Size(323, 38)
        Me.TxtComents.TabIndex = 8
        '
        'TxtIndica
        '
        Me.TxtIndica.Location = New System.Drawing.Point(387, 241)
        Me.TxtIndica.MaxLength = 200
        Me.TxtIndica.Name = "TxtIndica"
        Me.TxtIndica.Size = New System.Drawing.Size(323, 20)
        Me.TxtIndica.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(384, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Indicadores"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(721, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Autorizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtID
        '
        Me.TxtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBloqueadoTasaBindingSource, "id", True))
        Me.TxtID.Location = New System.Drawing.Point(719, 120)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(77, 20)
        Me.TxtID.TabIndex = 12
        '
        'AnexosBloqueadoTasaTableAdapter
        '
        Me.AnexosBloqueadoTasaTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.ComentarioRiesgos, Me.TasaPol, Me.TasaSol})
        Me.DataGridView1.DataSource = Me.AnexosBloqueadoTasaBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 276)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(784, 150)
        Me.DataGridView1.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Anexo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Anexo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AnexoCon"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Contrato"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descr"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TipoCredito"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'ComentarioRiesgos
        '
        Me.ComentarioRiesgos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.ComentarioRiesgos.DataPropertyName = "ComentarioRiesgos"
        Me.ComentarioRiesgos.HeaderText = "Comentario Riesgos"
        Me.ComentarioRiesgos.MinimumWidth = 100
        Me.ComentarioRiesgos.Name = "ComentarioRiesgos"
        Me.ComentarioRiesgos.ReadOnly = True
        '
        'TasaPol
        '
        Me.TasaPol.DataPropertyName = "TasaPol"
        Me.TasaPol.HeaderText = "Tasa Politica"
        Me.TasaPol.Name = "TasaPol"
        Me.TasaPol.ReadOnly = True
        '
        'TasaSol
        '
        Me.TasaSol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.TasaSol.DataPropertyName = "TasaSol"
        Me.TasaSol.HeaderText = "Tasa Solicitada"
        Me.TasaSol.Name = "TasaSol"
        Me.TasaSol.ReadOnly = True
        Me.TasaSol.Width = 5
        '
        'AnexosBloqueadoTasaBindingSource1
        '
        Me.AnexosBloqueadoTasaBindingSource1.DataMember = "AnexosBloqueadoTasa"
        Me.AnexosBloqueadoTasaBindingSource1.DataSource = Me.GeneralDS1
        '
        'GeneralDS1
        '
        Me.GeneralDS1.DataSetName = "GeneralDS"
        Me.GeneralDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrmBloqueoTasas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 442)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtIndica)
        Me.Controls.Add(Me.TxtComents)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTasasol)
        Me.Controls.Add(Me.TxtTasaPol)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GridAnexos)
        Me.Controls.Add(Me.TxtID)
        Me.Name = "FrmBloqueoTasas"
        Me.Text = "Anexos Bloqueados por Tasa"
        CType(Me.GridAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosBloqueadoTasaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosBloqueadoTasaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridAnexos As System.Windows.Forms.DataGridView
    Friend WithEvents GeneralDS As Agil.RiesgosDS
    Friend WithEvents AnexosBloqueadoTasaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexosBloqueadoTasaTableAdapter As Agil.RiesgosDSTableAdapters.AnexosBloqueadoTasaTableAdapter
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnexoConDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutorizadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTasaPol As System.Windows.Forms.TextBox
    Friend WithEvents TxtTasasol As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtComents As System.Windows.Forms.TextBox
    Friend WithEvents TxtIndica As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GeneralDS1 As Agil.RiesgosDS
    Friend WithEvents AnexosBloqueadoTasaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComentarioRiesgos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TasaPol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TasaSol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
