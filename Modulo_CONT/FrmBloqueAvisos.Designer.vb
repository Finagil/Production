<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBloqueAvisos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComboFondeo = New System.Windows.Forms.ComboBox()
        Me.AnexoBloqBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContaDS = New Agil.ContaDS()
        Me.FondeosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AvisoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloqueadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FacturasBloqBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FacturasBloqTableAdapter = New Agil.ContaDSTableAdapters.FacturasBloqTableAdapter()
        Me.FondeosTableAdapter = New Agil.ContaDSTableAdapters.FondeosTableAdapter()
        Me.AnexoBloqTableAdapter = New Agil.ContaDSTableAdapters.AnexoBloqTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboAnexo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClientesBloqBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBloqTableAdapter = New Agil.ContaDSTableAdapters.ClientesBloqTableAdapter()
        Me.ComboCli = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.AnexoBloqBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FondeosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBloqBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBloqBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboFondeo
        '
        Me.ComboFondeo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AnexoBloqBindingSource, "Fondeo", True))
        Me.ComboFondeo.DataSource = Me.FondeosBindingSource
        Me.ComboFondeo.DisplayMember = "Fondeo"
        Me.ComboFondeo.FormattingEnabled = True
        Me.ComboFondeo.Location = New System.Drawing.Point(22, 113)
        Me.ComboFondeo.Name = "ComboFondeo"
        Me.ComboFondeo.Size = New System.Drawing.Size(121, 21)
        Me.ComboFondeo.TabIndex = 3
        Me.ComboFondeo.ValueMember = "id"
        '
        'AnexoBloqBindingSource
        '
        Me.AnexoBloqBindingSource.DataMember = "AnexoBloq"
        Me.AnexoBloqBindingSource.DataSource = Me.ContaDS
        '
        'ContaDS
        '
        Me.ContaDS.DataSetName = "ContaDS"
        Me.ContaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FondeosBindingSource
        '
        Me.FondeosBindingSource.DataMember = "Fondeos"
        Me.FondeosBindingSource.DataSource = Me.ContaDS
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fondeo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Avisos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AvisoDataGridViewTextBoxColumn, Me.FechaVencDataGridViewTextBoxColumn, Me.LetraDataGridViewTextBoxColumn, Me.ImporteFacturaDataGridViewTextBoxColumn, Me.SaldoFacturaDataGridViewTextBoxColumn, Me.BloqueadoDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.FacturasBloqBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(24, 154)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(553, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'AvisoDataGridViewTextBoxColumn
        '
        Me.AvisoDataGridViewTextBoxColumn.DataPropertyName = "Aviso"
        Me.AvisoDataGridViewTextBoxColumn.HeaderText = "Aviso"
        Me.AvisoDataGridViewTextBoxColumn.Name = "AvisoDataGridViewTextBoxColumn"
        Me.AvisoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AvisoDataGridViewTextBoxColumn.Width = 60
        '
        'FechaVencDataGridViewTextBoxColumn
        '
        Me.FechaVencDataGridViewTextBoxColumn.DataPropertyName = "FechaVenc"
        Me.FechaVencDataGridViewTextBoxColumn.HeaderText = "Fecha Venc."
        Me.FechaVencDataGridViewTextBoxColumn.Name = "FechaVencDataGridViewTextBoxColumn"
        Me.FechaVencDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LetraDataGridViewTextBoxColumn
        '
        Me.LetraDataGridViewTextBoxColumn.DataPropertyName = "Letra"
        Me.LetraDataGridViewTextBoxColumn.HeaderText = "Letra"
        Me.LetraDataGridViewTextBoxColumn.Name = "LetraDataGridViewTextBoxColumn"
        Me.LetraDataGridViewTextBoxColumn.ReadOnly = True
        Me.LetraDataGridViewTextBoxColumn.Width = 40
        '
        'ImporteFacturaDataGridViewTextBoxColumn
        '
        Me.ImporteFacturaDataGridViewTextBoxColumn.DataPropertyName = "ImporteFactura"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "n2"
        Me.ImporteFacturaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ImporteFacturaDataGridViewTextBoxColumn.HeaderText = "ImporteFactura"
        Me.ImporteFacturaDataGridViewTextBoxColumn.Name = "ImporteFacturaDataGridViewTextBoxColumn"
        Me.ImporteFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoFacturaDataGridViewTextBoxColumn
        '
        Me.SaldoFacturaDataGridViewTextBoxColumn.DataPropertyName = "SaldoFactura"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.SaldoFacturaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.SaldoFacturaDataGridViewTextBoxColumn.HeaderText = "SaldoFactura"
        Me.SaldoFacturaDataGridViewTextBoxColumn.Name = "SaldoFacturaDataGridViewTextBoxColumn"
        Me.SaldoFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BloqueadoDataGridViewCheckBoxColumn
        '
        Me.BloqueadoDataGridViewCheckBoxColumn.DataPropertyName = "Bloqueado"
        Me.BloqueadoDataGridViewCheckBoxColumn.HeaderText = "Bloqueado"
        Me.BloqueadoDataGridViewCheckBoxColumn.Name = "BloqueadoDataGridViewCheckBoxColumn"
        Me.BloqueadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.BloqueadoDataGridViewCheckBoxColumn.Width = 70
        '
        'FacturasBloqBindingSource
        '
        Me.FacturasBloqBindingSource.DataMember = "FacturasBloq"
        Me.FacturasBloqBindingSource.DataSource = Me.ContaDS
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(22, 310)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Bloqueo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FacturasBloqTableAdapter
        '
        Me.FacturasBloqTableAdapter.ClearBeforeFill = True
        '
        'FondeosTableAdapter
        '
        Me.FondeosTableAdapter.ClearBeforeFill = True
        '
        'AnexoBloqTableAdapter
        '
        Me.AnexoBloqTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Anexos"
        '
        'ComboAnexo
        '
        Me.ComboAnexo.DataSource = Me.AnexoBloqBindingSource
        Me.ComboAnexo.DisplayMember = "Anexo"
        Me.ComboAnexo.FormattingEnabled = True
        Me.ComboAnexo.Location = New System.Drawing.Point(20, 71)
        Me.ComboAnexo.Name = "ComboAnexo"
        Me.ComboAnexo.Size = New System.Drawing.Size(121, 21)
        Me.ComboAnexo.TabIndex = 2
        Me.ComboAnexo.ValueMember = "Anexo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Clientes"
        '
        'ClientesBloqBindingSource
        '
        Me.ClientesBloqBindingSource.DataMember = "ClientesBloq"
        Me.ClientesBloqBindingSource.DataSource = Me.ContaDS
        '
        'ClientesBloqTableAdapter
        '
        Me.ClientesBloqTableAdapter.ClearBeforeFill = True
        '
        'ComboCli
        '
        Me.ComboCli.DataSource = Me.ClientesBloqBindingSource
        Me.ComboCli.DisplayMember = "Descr"
        Me.ComboCli.FormattingEnabled = True
        Me.ComboCli.Location = New System.Drawing.Point(22, 27)
        Me.ComboCli.Name = "ComboCli"
        Me.ComboCli.Size = New System.Drawing.Size(555, 21)
        Me.ComboCli.TabIndex = 1
        Me.ComboCli.ValueMember = "Cliente"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FacturasBloqBindingSource, "Bloqueado", True))
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(562, 137)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FrmBloqueAvisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 350)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboCli)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboAnexo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboFondeo)
        Me.Name = "FrmBloqueAvisos"
        Me.Text = "Bloqueo y Desbloqueo de Contratos"
        CType(Me.AnexoBloqBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FondeosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBloqBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBloqBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboFondeo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents AvisoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LetraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BloqueadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FacturasBloqBindingSource As BindingSource
    Friend WithEvents ContaDS As ContaDS
    Friend WithEvents FacturasBloqTableAdapter As ContaDSTableAdapters.FacturasBloqTableAdapter
    Friend WithEvents FondeosBindingSource As BindingSource
    Friend WithEvents FondeosTableAdapter As ContaDSTableAdapters.FondeosTableAdapter
    Friend WithEvents AnexoBloqBindingSource As BindingSource
    Friend WithEvents AnexoBloqTableAdapter As ContaDSTableAdapters.AnexoBloqTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboAnexo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ClientesBloqBindingSource As BindingSource
    Friend WithEvents ClientesBloqTableAdapter As ContaDSTableAdapters.ClientesBloqTableAdapter
    Friend WithEvents ComboCli As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
