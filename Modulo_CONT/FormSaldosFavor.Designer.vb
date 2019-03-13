<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSaldosFavor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ClientesSaldoFavorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContaDS = New Agil.ContaDS()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdSaldoFavorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTSaldosFavorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextSaldo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextDescuento = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ClientesSaldoFavorTableAdapter = New Agil.ContaDSTableAdapters.ClientesSaldoFavorTableAdapter()
        Me.CONT_SaldosFavorTableAdapter = New Agil.ContaDSTableAdapters.CONT_SaldosFavorTableAdapter()
        Me.TextNotas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.ClientesSaldoFavorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTSaldosFavorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClientesSaldoFavorBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(16, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(522, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "Cliente"
        '
        'ClientesSaldoFavorBindingSource
        '
        Me.ClientesSaldoFavorBindingSource.DataMember = "ClientesSaldoFavor"
        Me.ClientesSaldoFavorBindingSource.DataSource = Me.ContaDS
        '
        'ContaDS
        '
        Me.ContaDS.DataSetName = "ContaDS"
        Me.ContaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSaldoFavorDataGridViewTextBoxColumn, Me.AnexoDataGridViewTextBoxColumn, Me.CicloDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CONTSaldosFavorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(522, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'IdSaldoFavorDataGridViewTextBoxColumn
        '
        Me.IdSaldoFavorDataGridViewTextBoxColumn.DataPropertyName = "id_SaldoFavor"
        Me.IdSaldoFavorDataGridViewTextBoxColumn.HeaderText = "id_SaldoFavor"
        Me.IdSaldoFavorDataGridViewTextBoxColumn.Name = "IdSaldoFavorDataGridViewTextBoxColumn"
        Me.IdSaldoFavorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdSaldoFavorDataGridViewTextBoxColumn.Visible = False
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Width = 90
        '
        'CicloDataGridViewTextBoxColumn
        '
        Me.CicloDataGridViewTextBoxColumn.DataPropertyName = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.HeaderText = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.Name = "CicloDataGridViewTextBoxColumn"
        Me.CicloDataGridViewTextBoxColumn.ReadOnly = True
        Me.CicloDataGridViewTextBoxColumn.Width = 50
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Width = 90
        '
        'CONTSaldosFavorBindingSource
        '
        Me.CONTSaldosFavorBindingSource.DataMember = "CONT_SaldosFavor"
        Me.CONTSaldosFavorBindingSource.DataSource = Me.ContaDS
        '
        'TextSaldo
        '
        Me.TextSaldo.Location = New System.Drawing.Point(16, 231)
        Me.TextSaldo.Name = "TextSaldo"
        Me.TextSaldo.ReadOnly = True
        Me.TextSaldo.Size = New System.Drawing.Size(100, 20)
        Me.TextSaldo.TabIndex = 3
        Me.TextSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Saldo a Favor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Monto a Descontar"
        '
        'TextDescuento
        '
        Me.TextDescuento.Location = New System.Drawing.Point(122, 231)
        Me.TextDescuento.Name = "TextDescuento"
        Me.TextDescuento.Size = New System.Drawing.Size(100, 20)
        Me.TextDescuento.TabIndex = 6
        Me.TextDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(463, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Descontar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ClientesSaldoFavorTableAdapter
        '
        Me.ClientesSaldoFavorTableAdapter.ClearBeforeFill = True
        '
        'CONT_SaldosFavorTableAdapter
        '
        Me.CONT_SaldosFavorTableAdapter.ClearBeforeFill = True
        '
        'TextNotas
        '
        Me.TextNotas.Location = New System.Drawing.Point(229, 230)
        Me.TextNotas.Multiline = True
        Me.TextNotas.Name = "TextNotas"
        Me.TextNotas.Size = New System.Drawing.Size(228, 61)
        Me.TextNotas.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(229, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Oberbaciones para la aplicación:"
        '
        'FormSaldosFavor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 296)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextNotas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextDescuento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextSaldo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormSaldosFavor"
        Me.Text = "FormSaldosFavor"
        CType(Me.ClientesSaldoFavorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTSaldosFavorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextSaldo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextDescuento As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ContaDS As ContaDS
    Friend WithEvents ClientesSaldoFavorBindingSource As BindingSource
    Friend WithEvents ClientesSaldoFavorTableAdapter As ContaDSTableAdapters.ClientesSaldoFavorTableAdapter
    Friend WithEvents IdSaldoFavorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAplicacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTSaldosFavorBindingSource As BindingSource
    Friend WithEvents CONT_SaldosFavorTableAdapter As ContaDSTableAdapters.CONT_SaldosFavorTableAdapter
    Friend WithEvents TextNotas As TextBox
    Friend WithEvents Label4 As Label
End Class
