<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaSAT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaSAT))
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.CreditoDS = New Agil.CreditoDS()
        Me.CRED_Lista_Art69BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRED_Lista_Art69TableAdapter = New Agil.CreditoDSTableAdapters.CRED_Lista_Art69TableAdapter()
        Me.TableAdapterManager = New Agil.CreditoDSTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CRED_Lista_Art69BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRED_Lista_Art69BTableAdapter = New Agil.CreditoDSTableAdapters.CRED_Lista_Art69BTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.StatuscontDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtxNoExiste69 = New System.Windows.Forms.TextBox()
        Me.txtxNoExiste69B = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTipoPersona = New System.Windows.Forms.TextBox()
        Me.txtRFCN = New System.Windows.Forms.TextBox()
        Me.btnReporte = New System.Windows.Forms.Button()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRED_Lista_Art69BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRED_Lista_Art69BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(210, 18)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(74, 23)
        Me.btnEnviar.TabIndex = 1
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRFC.Location = New System.Drawing.Point(75, 20)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(128, 20)
        Me.txtRFC.TabIndex = 0
        '
        'CreditoDS
        '
        Me.CreditoDS.DataSetName = "CreditoDS"
        Me.CreditoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CRED_Lista_Art69BindingSource
        '
        Me.CRED_Lista_Art69BindingSource.DataMember = "CRED_Lista_Art69"
        Me.CRED_Lista_Art69BindingSource.DataSource = Me.CreditoDS
        '
        'CRED_Lista_Art69TableAdapter
        '
        Me.CRED_Lista_Art69TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AviosDetTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CRED_CatalogoEstatusTableAdapter = Nothing
        Me.TableAdapterManager.CRED_LineasCreditoTableAdapter = Nothing
        Me.TableAdapterManager.CRED_Lista_Art69BTableAdapter = Nothing
        Me.TableAdapterManager.CRED_Lista_Art69TableAdapter = Nothing
        Me.TableAdapterManager.CRED_ListaFechaArf69TableAdapter = Nothing
        Me.TableAdapterManager.CRED_RelDocumentosTableAdapter = Nothing
        Me.TableAdapterManager.CRED_SeguimientoDocumentosTableAdapter = Nothing
        Me.TableAdapterManager.CRED_SeguimientoTableAdapter = Nothing
        Me.TableAdapterManager.GEN_ProductosFinagilTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Agil.CreditoDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupuestoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CRED_Lista_Art69BindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(442, 109)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(169, 86)
        Me.DataGridView1.TabIndex = 2
        '
        'SupuestoDataGridViewTextBoxColumn
        '
        Me.SupuestoDataGridViewTextBoxColumn.DataPropertyName = "supuesto"
        Me.SupuestoDataGridViewTextBoxColumn.HeaderText = "supuesto"
        Me.SupuestoDataGridViewTextBoxColumn.Name = "SupuestoDataGridViewTextBoxColumn"
        Me.SupuestoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupuestoDataGridViewTextBoxColumn.Width = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "RFC:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 226)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(411, 86)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Artículo 69 B (Operaciones inexistentes):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Artículo 69 (Créditos fiscales):"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 108)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(411, 86)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'CRED_Lista_Art69BBindingSource
        '
        Me.CRED_Lista_Art69BBindingSource.DataMember = "CRED_Lista_Art69B"
        Me.CRED_Lista_Art69BBindingSource.DataSource = Me.CreditoDS
        '
        'CRED_Lista_Art69BTableAdapter
        '
        Me.CRED_Lista_Art69BTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ColumnHeadersVisible = False
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StatuscontDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.CRED_Lista_Art69BBindingSource
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(442, 227)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(169, 86)
        Me.DataGridView2.TabIndex = 8
        '
        'StatuscontDataGridViewTextBoxColumn
        '
        Me.StatuscontDataGridViewTextBoxColumn.DataPropertyName = "status_cont"
        Me.StatuscontDataGridViewTextBoxColumn.HeaderText = "status_cont"
        Me.StatuscontDataGridViewTextBoxColumn.Name = "StatuscontDataGridViewTextBoxColumn"
        Me.StatuscontDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatuscontDataGridViewTextBoxColumn.Width = 120
        '
        'txtxNoExiste69
        '
        Me.txtxNoExiste69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtxNoExiste69.Location = New System.Drawing.Point(442, 145)
        Me.txtxNoExiste69.Name = "txtxNoExiste69"
        Me.txtxNoExiste69.ReadOnly = True
        Me.txtxNoExiste69.Size = New System.Drawing.Size(169, 20)
        Me.txtxNoExiste69.TabIndex = 9
        Me.txtxNoExiste69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtxNoExiste69.Visible = False
        '
        'txtxNoExiste69B
        '
        Me.txtxNoExiste69B.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtxNoExiste69B.Location = New System.Drawing.Point(442, 262)
        Me.txtxNoExiste69B.Name = "txtxNoExiste69B"
        Me.txtxNoExiste69B.ReadOnly = True
        Me.txtxNoExiste69B.Size = New System.Drawing.Size(169, 20)
        Me.txtxNoExiste69B.TabIndex = 10
        Me.txtxNoExiste69B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtxNoExiste69B.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(308, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(308, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tipo de persona:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "RFC:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(361, 18)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(258, 20)
        Me.txtNombre.TabIndex = 14
        '
        'txtTipoPersona
        '
        Me.txtTipoPersona.Location = New System.Drawing.Point(519, 43)
        Me.txtTipoPersona.Name = "txtTipoPersona"
        Me.txtTipoPersona.ReadOnly = True
        Me.txtTipoPersona.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoPersona.TabIndex = 15
        '
        'txtRFCN
        '
        Me.txtRFCN.Location = New System.Drawing.Point(442, 68)
        Me.txtRFCN.Name = "txtRFCN"
        Me.txtRFCN.ReadOnly = True
        Me.txtRFCN.Size = New System.Drawing.Size(178, 20)
        Me.txtRFCN.TabIndex = 16
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(464, 319)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(131, 23)
        Me.btnReporte.TabIndex = 17
        Me.btnReporte.Text = "Imprimir Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'frmConsultaSAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 352)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.txtRFCN)
        Me.Controls.Add(Me.txtTipoPersona)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtxNoExiste69B)
        Me.Controls.Add(Me.txtxNoExiste69)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.btnEnviar)
        Me.Name = "frmConsultaSAT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta estatus SAT"
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRED_Lista_Art69BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRED_Lista_Art69BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnviar As Button
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents CreditoDS As CreditoDS
    Friend WithEvents CRED_Lista_Art69BindingSource As BindingSource
    Friend WithEvents CRED_Lista_Art69TableAdapter As CreditoDSTableAdapters.CRED_Lista_Art69TableAdapter
    Friend WithEvents TableAdapterManager As CreditoDSTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CRED_Lista_Art69BBindingSource As BindingSource
    Friend WithEvents CRED_Lista_Art69BTableAdapter As CreditoDSTableAdapters.CRED_Lista_Art69BTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents SupuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatuscontDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtxNoExiste69 As TextBox
    Friend WithEvents txtxNoExiste69B As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTipoPersona As TextBox
    Friend WithEvents txtRFCN As TextBox
    Friend WithEvents btnReporte As Button
End Class
