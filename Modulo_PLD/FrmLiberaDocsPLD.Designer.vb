<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLiberaDocsPLD
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BitacoraMCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLD_DS = New Agil.PLD_DS()
        Me.BitacoraMCTableAdapter = New Agil.PLD_DSTableAdapters.BitacoraMCTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IdBitacoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagareDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PagareORGDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ContratoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ContratoORGDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ConvenioDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ConvenioORGDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EscrituraDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EscrituraORGDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FacturasDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FacturasORGDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GarantiasDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GarantiasORGDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FechaSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDevolucionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JustificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolicitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoboDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitacoraMCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLD_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBitacoraDataGridViewTextBoxColumn, Me.AnexoDataGridViewTextBoxColumn, Me.AnexoConDataGridViewTextBoxColumn, Me.CicloDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn, Me.PagareDataGridViewCheckBoxColumn, Me.PagareORGDataGridViewCheckBoxColumn, Me.ContratoDataGridViewCheckBoxColumn, Me.ContratoORGDataGridViewCheckBoxColumn, Me.ConvenioDataGridViewCheckBoxColumn, Me.ConvenioORGDataGridViewCheckBoxColumn, Me.EscrituraDataGridViewCheckBoxColumn, Me.EscrituraORGDataGridViewCheckBoxColumn, Me.FacturasDataGridViewCheckBoxColumn, Me.FacturasORGDataGridViewCheckBoxColumn, Me.GarantiasDataGridViewCheckBoxColumn, Me.GarantiasORGDataGridViewCheckBoxColumn, Me.FechaSolicitudDataGridViewTextBoxColumn, Me.FechaEntregaDataGridViewTextBoxColumn, Me.FechaDevolucionDataGridViewTextBoxColumn, Me.JustificacionDataGridViewTextBoxColumn, Me.NotaDataGridViewTextBoxColumn, Me.SolicitoDataGridViewTextBoxColumn, Me.VoboDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BitacoraMCBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(866, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'BitacoraMCBindingSource
        '
        Me.BitacoraMCBindingSource.DataMember = "BitacoraMC"
        Me.BitacoraMCBindingSource.DataSource = Me.PLD_DS
        '
        'PLD_DS
        '
        Me.PLD_DS.DataSetName = "PLD_DS"
        Me.PLD_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BitacoraMCTableAdapter
        '
        Me.BitacoraMCTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Anexo"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BitacoraMCBindingSource, "Anexo", True))
        Me.TextBox1.Location = New System.Drawing.Point(12, 181)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(88, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BitacoraMCBindingSource, "Ciclo", True))
        Me.TextBox2.Location = New System.Drawing.Point(106, 181)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(88, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ciclo"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BitacoraMCBindingSource, "Descr", True))
        Me.TextBox3.Location = New System.Drawing.Point(200, 181)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(350, 20)
        Me.TextBox3.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(197, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cliente"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BitacoraMCBindingSource, "Justificacion", True))
        Me.TextBox4.Location = New System.Drawing.Point(12, 219)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(538, 45)
        Me.TextBox4.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Justificación"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(475, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Liberar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IdBitacoraDataGridViewTextBoxColumn
        '
        Me.IdBitacoraDataGridViewTextBoxColumn.DataPropertyName = "Id_Bitacora"
        Me.IdBitacoraDataGridViewTextBoxColumn.HeaderText = "Id_Bitacora"
        Me.IdBitacoraDataGridViewTextBoxColumn.Name = "IdBitacoraDataGridViewTextBoxColumn"
        Me.IdBitacoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdBitacoraDataGridViewTextBoxColumn.Visible = False
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Visible = False
        Me.AnexoDataGridViewTextBoxColumn.Width = 80
        '
        'AnexoConDataGridViewTextBoxColumn
        '
        Me.AnexoConDataGridViewTextBoxColumn.DataPropertyName = "AnexoCon"
        Me.AnexoConDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoConDataGridViewTextBoxColumn.Name = "AnexoConDataGridViewTextBoxColumn"
        Me.AnexoConDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CicloDataGridViewTextBoxColumn
        '
        Me.CicloDataGridViewTextBoxColumn.DataPropertyName = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.HeaderText = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.Name = "CicloDataGridViewTextBoxColumn"
        Me.CicloDataGridViewTextBoxColumn.ReadOnly = True
        Me.CicloDataGridViewTextBoxColumn.Width = 50
        '
        'DescrDataGridViewTextBoxColumn
        '
        Me.DescrDataGridViewTextBoxColumn.DataPropertyName = "Descr"
        Me.DescrDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.DescrDataGridViewTextBoxColumn.Name = "DescrDataGridViewTextBoxColumn"
        Me.DescrDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescrDataGridViewTextBoxColumn.Width = 150
        '
        'TipoCreditoDataGridViewTextBoxColumn
        '
        Me.TipoCreditoDataGridViewTextBoxColumn.DataPropertyName = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCreditoDataGridViewTextBoxColumn.Width = 80
        '
        'PagareDataGridViewCheckBoxColumn
        '
        Me.PagareDataGridViewCheckBoxColumn.DataPropertyName = "Pagare"
        Me.PagareDataGridViewCheckBoxColumn.HeaderText = "Pagare"
        Me.PagareDataGridViewCheckBoxColumn.Name = "PagareDataGridViewCheckBoxColumn"
        Me.PagareDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PagareORGDataGridViewCheckBoxColumn
        '
        Me.PagareORGDataGridViewCheckBoxColumn.DataPropertyName = "PagareORG"
        Me.PagareORGDataGridViewCheckBoxColumn.HeaderText = "PagareORG"
        Me.PagareORGDataGridViewCheckBoxColumn.Name = "PagareORGDataGridViewCheckBoxColumn"
        Me.PagareORGDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ContratoDataGridViewCheckBoxColumn
        '
        Me.ContratoDataGridViewCheckBoxColumn.DataPropertyName = "Contrato"
        Me.ContratoDataGridViewCheckBoxColumn.HeaderText = "Contrato"
        Me.ContratoDataGridViewCheckBoxColumn.Name = "ContratoDataGridViewCheckBoxColumn"
        Me.ContratoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ContratoORGDataGridViewCheckBoxColumn
        '
        Me.ContratoORGDataGridViewCheckBoxColumn.DataPropertyName = "ContratoORG"
        Me.ContratoORGDataGridViewCheckBoxColumn.HeaderText = "ContratoORG"
        Me.ContratoORGDataGridViewCheckBoxColumn.Name = "ContratoORGDataGridViewCheckBoxColumn"
        Me.ContratoORGDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ConvenioDataGridViewCheckBoxColumn
        '
        Me.ConvenioDataGridViewCheckBoxColumn.DataPropertyName = "Convenio"
        Me.ConvenioDataGridViewCheckBoxColumn.HeaderText = "Convenio"
        Me.ConvenioDataGridViewCheckBoxColumn.Name = "ConvenioDataGridViewCheckBoxColumn"
        Me.ConvenioDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ConvenioORGDataGridViewCheckBoxColumn
        '
        Me.ConvenioORGDataGridViewCheckBoxColumn.DataPropertyName = "ConvenioORG"
        Me.ConvenioORGDataGridViewCheckBoxColumn.HeaderText = "ConvenioORG"
        Me.ConvenioORGDataGridViewCheckBoxColumn.Name = "ConvenioORGDataGridViewCheckBoxColumn"
        Me.ConvenioORGDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'EscrituraDataGridViewCheckBoxColumn
        '
        Me.EscrituraDataGridViewCheckBoxColumn.DataPropertyName = "Escritura"
        Me.EscrituraDataGridViewCheckBoxColumn.HeaderText = "Escritura"
        Me.EscrituraDataGridViewCheckBoxColumn.Name = "EscrituraDataGridViewCheckBoxColumn"
        Me.EscrituraDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'EscrituraORGDataGridViewCheckBoxColumn
        '
        Me.EscrituraORGDataGridViewCheckBoxColumn.DataPropertyName = "EscrituraORG"
        Me.EscrituraORGDataGridViewCheckBoxColumn.HeaderText = "EscrituraORG"
        Me.EscrituraORGDataGridViewCheckBoxColumn.Name = "EscrituraORGDataGridViewCheckBoxColumn"
        Me.EscrituraORGDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FacturasDataGridViewCheckBoxColumn
        '
        Me.FacturasDataGridViewCheckBoxColumn.DataPropertyName = "Facturas"
        Me.FacturasDataGridViewCheckBoxColumn.HeaderText = "Facturas"
        Me.FacturasDataGridViewCheckBoxColumn.Name = "FacturasDataGridViewCheckBoxColumn"
        Me.FacturasDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FacturasORGDataGridViewCheckBoxColumn
        '
        Me.FacturasORGDataGridViewCheckBoxColumn.DataPropertyName = "FacturasORG"
        Me.FacturasORGDataGridViewCheckBoxColumn.HeaderText = "FacturasORG"
        Me.FacturasORGDataGridViewCheckBoxColumn.Name = "FacturasORGDataGridViewCheckBoxColumn"
        Me.FacturasORGDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'GarantiasDataGridViewCheckBoxColumn
        '
        Me.GarantiasDataGridViewCheckBoxColumn.DataPropertyName = "Garantias"
        Me.GarantiasDataGridViewCheckBoxColumn.HeaderText = "Garantias"
        Me.GarantiasDataGridViewCheckBoxColumn.Name = "GarantiasDataGridViewCheckBoxColumn"
        Me.GarantiasDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'GarantiasORGDataGridViewCheckBoxColumn
        '
        Me.GarantiasORGDataGridViewCheckBoxColumn.DataPropertyName = "GarantiasORG"
        Me.GarantiasORGDataGridViewCheckBoxColumn.HeaderText = "GarantiasORG"
        Me.GarantiasORGDataGridViewCheckBoxColumn.Name = "GarantiasORGDataGridViewCheckBoxColumn"
        Me.GarantiasORGDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FechaSolicitudDataGridViewTextBoxColumn
        '
        Me.FechaSolicitudDataGridViewTextBoxColumn.DataPropertyName = "FechaSolicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.HeaderText = "FechaSolicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.Name = "FechaSolicitudDataGridViewTextBoxColumn"
        Me.FechaSolicitudDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaEntregaDataGridViewTextBoxColumn
        '
        Me.FechaEntregaDataGridViewTextBoxColumn.DataPropertyName = "FechaEntrega"
        Me.FechaEntregaDataGridViewTextBoxColumn.HeaderText = "FechaEntrega"
        Me.FechaEntregaDataGridViewTextBoxColumn.Name = "FechaEntregaDataGridViewTextBoxColumn"
        Me.FechaEntregaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDevolucionDataGridViewTextBoxColumn
        '
        Me.FechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaDevolucion"
        Me.FechaDevolucionDataGridViewTextBoxColumn.HeaderText = "FechaDevolucion"
        Me.FechaDevolucionDataGridViewTextBoxColumn.Name = "FechaDevolucionDataGridViewTextBoxColumn"
        Me.FechaDevolucionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JustificacionDataGridViewTextBoxColumn
        '
        Me.JustificacionDataGridViewTextBoxColumn.DataPropertyName = "Justificacion"
        Me.JustificacionDataGridViewTextBoxColumn.HeaderText = "Justificacion"
        Me.JustificacionDataGridViewTextBoxColumn.Name = "JustificacionDataGridViewTextBoxColumn"
        Me.JustificacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotaDataGridViewTextBoxColumn
        '
        Me.NotaDataGridViewTextBoxColumn.DataPropertyName = "Nota"
        Me.NotaDataGridViewTextBoxColumn.HeaderText = "Nota"
        Me.NotaDataGridViewTextBoxColumn.Name = "NotaDataGridViewTextBoxColumn"
        Me.NotaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SolicitoDataGridViewTextBoxColumn
        '
        Me.SolicitoDataGridViewTextBoxColumn.DataPropertyName = "Solicito"
        Me.SolicitoDataGridViewTextBoxColumn.HeaderText = "Solicito"
        Me.SolicitoDataGridViewTextBoxColumn.Name = "SolicitoDataGridViewTextBoxColumn"
        Me.SolicitoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VoboDataGridViewTextBoxColumn
        '
        Me.VoboDataGridViewTextBoxColumn.DataPropertyName = "vobo"
        Me.VoboDataGridViewTextBoxColumn.HeaderText = "vobo"
        Me.VoboDataGridViewTextBoxColumn.Name = "VoboDataGridViewTextBoxColumn"
        Me.VoboDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmLiberaDocsPLD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 301)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmLiberaDocsPLD"
        Me.Text = "Liberacion de Expedientes (PLD)"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitacoraMCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLD_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PLD_DS As PLD_DS
    Friend WithEvents BitacoraMCBindingSource As BindingSource
    Friend WithEvents BitacoraMCTableAdapter As PLD_DSTableAdapters.BitacoraMCTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents IdBitacoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoConDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagareDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PagareORGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ContratoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ContratoORGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ConvenioDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ConvenioORGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EscrituraDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EscrituraORGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FacturasDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FacturasORGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents GarantiasDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents GarantiasORGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FechaSolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntregaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDevolucionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JustificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SolicitoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VoboDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
