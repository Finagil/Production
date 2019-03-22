<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAplicaSaldoFavor
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AnexoConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwSaldosFavorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JuridicoDS = New Agil.JuridicoDS()
        Me.VwSaldosFavorTableAdapter = New Agil.JuridicoDSTableAdapters.VwSaldosFavorTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextIntrMone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextComenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSaldosFavorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoConDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VwSaldosFavorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(4, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(784, 386)
        Me.DataGridView1.TabIndex = 0
        '
        'AnexoConDataGridViewTextBoxColumn
        '
        Me.AnexoConDataGridViewTextBoxColumn.DataPropertyName = "AnexoCon"
        Me.AnexoConDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoConDataGridViewTextBoxColumn.Name = "AnexoConDataGridViewTextBoxColumn"
        Me.AnexoConDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "Tipo de Crédito"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCreditoDataGridViewTextBoxColumn.Width = 120
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
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwSaldosFavorBindingSource
        '
        Me.VwSaldosFavorBindingSource.DataMember = "VwSaldosFavor"
        Me.VwSaldosFavorBindingSource.DataSource = Me.JuridicoDS
        '
        'JuridicoDS
        '
        Me.JuridicoDS.DataSetName = "JuridicoDS"
        Me.JuridicoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwSaldosFavorTableAdapter
        '
        Me.VwSaldosFavorTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Anexo"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwSaldosFavorBindingSource, "AnexoCon", True))
        Me.TextBox1.Location = New System.Drawing.Point(7, 419)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(80, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwSaldosFavorBindingSource, "Descr", True))
        Me.TextBox2.Location = New System.Drawing.Point(93, 419)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(227, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 402)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cliente"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwSaldosFavorBindingSource, "Importe", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextBox3.Location = New System.Drawing.Point(326, 419)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(323, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Importe"
        '
        'TextIntrMone
        '
        Me.TextIntrMone.Location = New System.Drawing.Point(432, 419)
        Me.TextIntrMone.Name = "TextIntrMone"
        Me.TextIntrMone.ReadOnly = True
        Me.TextIntrMone.Size = New System.Drawing.Size(80, 20)
        Me.TextIntrMone.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(429, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Instr. Mone."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(661, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Solicitar Aplicación"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextComenta
        '
        Me.TextComenta.Location = New System.Drawing.Point(519, 419)
        Me.TextComenta.MaxLength = 300
        Me.TextComenta.Multiline = True
        Me.TextComenta.Name = "TextComenta"
        Me.TextComenta.Size = New System.Drawing.Size(269, 37)
        Me.TextComenta.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(516, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Comentario Correo"
        '
        'FrmAplicaSaldoFavor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 494)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextComenta)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextIntrMone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmAplicaSaldoFavor"
        Me.Text = "Solicitar Aplicar Saldo a Favor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSaldosFavorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents JuridicoDS As JuridicoDS
    Friend WithEvents VwSaldosFavorBindingSource As BindingSource
    Friend WithEvents VwSaldosFavorTableAdapter As JuridicoDSTableAdapters.VwSaldosFavorTableAdapter
    Friend WithEvents AnexoConDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextIntrMone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextComenta As TextBox
    Friend WithEvents Label5 As Label
End Class
