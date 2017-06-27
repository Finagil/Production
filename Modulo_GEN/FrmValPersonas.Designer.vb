<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValPersonas
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtPersona = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoPersonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoCredito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoInsoluto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Acreditado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConAtraso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HistoriaPersonasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS
        Me.RdbActivos = New System.Windows.Forms.RadioButton
        Me.RdBTodos = New System.Windows.Forms.RadioButton
        Me.BtnOnbase = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HistoriaPersonasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistoriaPersonasTableAdapter = New Agil.GeneralDSTableAdapters.HistoriaPersonasTableAdapter
        Me.HistoriaPersonas1TableAdapter = New Agil.GeneralDSTableAdapters.HistoriaPersonas1TableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoriaPersonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoriaPersonasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de la Persona a Validar (Min. 6 caracteres)"
        '
        'TxtPersona
        '
        Me.TxtPersona.Location = New System.Drawing.Point(15, 26)
        Me.TxtPersona.Name = "TxtPersona"
        Me.TxtPersona.Size = New System.Drawing.Size(671, 20)
        Me.TxtPersona.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.TipoPersonaDataGridViewTextBoxColumn, Me.FechaContratoDataGridViewTextBoxColumn, Me.Estatus, Me.TipoCredito, Me.SaldoInsoluto, Me.Acreditado, Me.ConAtraso})
        Me.DataGridView1.DataSource = Me.HistoriaPersonasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1034, 209)
        Me.DataGridView1.TabIndex = 2
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Width = 90
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 250
        '
        'TipoPersonaDataGridViewTextBoxColumn
        '
        Me.TipoPersonaDataGridViewTextBoxColumn.DataPropertyName = "TipoPersona"
        Me.TipoPersonaDataGridViewTextBoxColumn.HeaderText = "Tipo Persona"
        Me.TipoPersonaDataGridViewTextBoxColumn.Name = "TipoPersonaDataGridViewTextBoxColumn"
        Me.TipoPersonaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoPersonaDataGridViewTextBoxColumn.Width = 90
        '
        'FechaContratoDataGridViewTextBoxColumn
        '
        Me.FechaContratoDataGridViewTextBoxColumn.DataPropertyName = "FechaContrato"
        Me.FechaContratoDataGridViewTextBoxColumn.HeaderText = "Fecha Contrato"
        Me.FechaContratoDataGridViewTextBoxColumn.Name = "FechaContratoDataGridViewTextBoxColumn"
        Me.FechaContratoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaContratoDataGridViewTextBoxColumn.Width = 80
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        Me.Estatus.Width = 50
        '
        'TipoCredito
        '
        Me.TipoCredito.DataPropertyName = "TipoCredito"
        Me.TipoCredito.HeaderText = "Tipo Credito"
        Me.TipoCredito.Name = "TipoCredito"
        Me.TipoCredito.ReadOnly = True
        Me.TipoCredito.Width = 50
        '
        'SaldoInsoluto
        '
        Me.SaldoInsoluto.DataPropertyName = "SaldoInsoluto"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "n"
        Me.SaldoInsoluto.DefaultCellStyle = DataGridViewCellStyle1
        Me.SaldoInsoluto.HeaderText = "Saldo Insoluto"
        Me.SaldoInsoluto.Name = "SaldoInsoluto"
        Me.SaldoInsoluto.ReadOnly = True
        '
        'Acreditado
        '
        Me.Acreditado.DataPropertyName = "Acreditado"
        Me.Acreditado.HeaderText = "Acreditado"
        Me.Acreditado.Name = "Acreditado"
        Me.Acreditado.ReadOnly = True
        Me.Acreditado.Width = 200
        '
        'ConAtraso
        '
        Me.ConAtraso.DataPropertyName = "ConAtraso"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ConAtraso.DefaultCellStyle = DataGridViewCellStyle2
        Me.ConAtraso.HeaderText = "Con Atraso"
        Me.ConAtraso.Name = "ConAtraso"
        Me.ConAtraso.ReadOnly = True
        Me.ConAtraso.Width = 50
        '
        'HistoriaPersonasBindingSource
        '
        Me.HistoriaPersonasBindingSource.DataMember = "HistoriaPersonas"
        Me.HistoriaPersonasBindingSource.DataSource = Me.GeneralDSBindingSource
        '
        'GeneralDSBindingSource
        '
        Me.GeneralDSBindingSource.DataSource = Me.GeneralDS
        Me.GeneralDSBindingSource.Position = 0
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RdbActivos
        '
        Me.RdbActivos.AutoSize = True
        Me.RdbActivos.Checked = True
        Me.RdbActivos.Location = New System.Drawing.Point(693, 28)
        Me.RdbActivos.Name = "RdbActivos"
        Me.RdbActivos.Size = New System.Drawing.Size(60, 17)
        Me.RdbActivos.TabIndex = 3
        Me.RdbActivos.TabStop = True
        Me.RdbActivos.Text = "Activos"
        Me.RdbActivos.UseVisualStyleBackColor = True
        '
        'RdBTodos
        '
        Me.RdBTodos.AutoSize = True
        Me.RdBTodos.Location = New System.Drawing.Point(759, 27)
        Me.RdBTodos.Name = "RdBTodos"
        Me.RdBTodos.Size = New System.Drawing.Size(55, 17)
        Me.RdBTodos.TabIndex = 4
        Me.RdBTodos.Text = "Todos"
        Me.RdBTodos.UseVisualStyleBackColor = True
        '
        'BtnOnbase
        '
        Me.BtnOnbase.Enabled = False
        Me.BtnOnbase.Location = New System.Drawing.Point(945, 20)
        Me.BtnOnbase.Name = "BtnOnbase"
        Me.BtnOnbase.Size = New System.Drawing.Size(104, 24)
        Me.BtnOnbase.TabIndex = 101
        Me.BtnOnbase.Text = "OnBase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 13)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Personas Relacionados al contrato"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DataGridView2.DataSource = Me.HistoriaPersonasBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(10, 280)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1034, 209)
        Me.DataGridView2.TabIndex = 103
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Anexo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Anexo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TipoPersona"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo Persona"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FechaContrato"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha Contrato"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TipoCredito"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tipo Credito"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SaldoInsoluto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "n"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn7.HeaderText = "Saldo Insoluto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Acreditado"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Acreditado"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 200
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ConAtraso"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn9.HeaderText = "Con Atraso"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'HistoriaPersonasBindingSource1
        '
        Me.HistoriaPersonasBindingSource1.DataMember = "HistoriaPersonas1"
        Me.HistoriaPersonasBindingSource1.DataSource = Me.GeneralDSBindingSource
        '
        'HistoriaPersonasTableAdapter
        '
        Me.HistoriaPersonasTableAdapter.ClearBeforeFill = True
        '
        'HistoriaPersonas1TableAdapter
        '
        Me.HistoriaPersonas1TableAdapter.ClearBeforeFill = True
        '
        'FrmValPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 498)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnOnbase)
        Me.Controls.Add(Me.RdBTodos)
        Me.Controls.Add(Me.RdbActivos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtPersona)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmValPersonas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes Relacionadas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoriaPersonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoriaPersonasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPersona As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HistoriaPersonasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDS As Agil.GeneralDS
    Friend WithEvents HistoriaPersonasTableAdapter As Agil.GeneralDSTableAdapters.HistoriaPersonasTableAdapter
    Friend WithEvents RdbActivos As System.Windows.Forms.RadioButton
    Friend WithEvents RdBTodos As System.Windows.Forms.RadioButton
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoPersonaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaContratoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCredito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoInsoluto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Acreditado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConAtraso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnOnbase As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents HistoriaPersonasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HistoriaPersonas1TableAdapter As Agil.GeneralDSTableAdapters.HistoriaPersonas1TableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
