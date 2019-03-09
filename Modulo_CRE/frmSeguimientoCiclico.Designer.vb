<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguimientoCiclico
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
        Me.TxtCompromiso = New System.Windows.Forms.TextBox()
        Me.CREDSeguimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditoDS = New Agil.CreditoDS()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtResponsable = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTPcompromiso = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPAlta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpVenc = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboPeriodicidad = New System.Windows.Forms.ComboBox()
        Me.BtnTry = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdSeguimientoORGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSeguimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCicloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREDSeguimientoCiclicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRED_SeguimientoTableAdapter = New Agil.CreditoDSTableAdapters.CRED_SeguimientoTableAdapter()
        Me.CRED_SeguimientoCiclicoTableAdapter = New Agil.CreditoDSTableAdapters.CRED_SeguimientoCiclicoTableAdapter()
        CType(Me.CREDSeguimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CREDSeguimientoCiclicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCompromiso
        '
        Me.TxtCompromiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCompromiso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "Compromiso", True))
        Me.TxtCompromiso.Location = New System.Drawing.Point(11, 107)
        Me.TxtCompromiso.MaxLength = 50
        Me.TxtCompromiso.Name = "TxtCompromiso"
        Me.TxtCompromiso.ReadOnly = True
        Me.TxtCompromiso.Size = New System.Drawing.Size(495, 20)
        Me.TxtCompromiso.TabIndex = 97
        '
        'CREDSeguimientoBindingSource
        '
        Me.CREDSeguimientoBindingSource.DataMember = "CRED_Seguimiento"
        Me.CREDSeguimientoBindingSource.DataSource = Me.CreditoDS
        '
        'CreditoDS
        '
        Me.CreditoDS.DataSetName = "CreditoDS"
        Me.CreditoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Compromiso"
        '
        'TxtResponsable
        '
        Me.TxtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtResponsable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "Responsable", True))
        Me.TxtResponsable.Location = New System.Drawing.Point(11, 70)
        Me.TxtResponsable.MaxLength = 50
        Me.TxtResponsable.Name = "TxtResponsable"
        Me.TxtResponsable.ReadOnly = True
        Me.TxtResponsable.Size = New System.Drawing.Size(495, 20)
        Me.TxtResponsable.TabIndex = 96
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Responsable"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(136, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Fecha Compromiso"
        '
        'DTPcompromiso
        '
        Me.DTPcompromiso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CREDSeguimientoBindingSource, "Fecha_Compromiso", True))
        Me.DTPcompromiso.Enabled = False
        Me.DTPcompromiso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPcompromiso.Location = New System.Drawing.Point(135, 26)
        Me.DTPcompromiso.Name = "DTPcompromiso"
        Me.DTPcompromiso.Size = New System.Drawing.Size(118, 20)
        Me.DTPcompromiso.TabIndex = 95
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Fecha Alta"
        '
        'DTPAlta
        '
        Me.DTPAlta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CREDSeguimientoBindingSource, "Fecha_Alta", True))
        Me.DTPAlta.Enabled = False
        Me.DTPAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPAlta.Location = New System.Drawing.Point(11, 26)
        Me.DTPAlta.Name = "DTPAlta"
        Me.DTPAlta.Size = New System.Drawing.Size(118, 20)
        Me.DTPAlta.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Anexo Venc."
        '
        'DtpVenc
        '
        Me.DtpVenc.Enabled = False
        Me.DtpVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpVenc.Location = New System.Drawing.Point(259, 26)
        Me.DtpVenc.Name = "DtpVenc"
        Me.DtpVenc.Size = New System.Drawing.Size(118, 20)
        Me.DtpVenc.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(382, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Periodicidad"
        '
        'ComboPeriodicidad
        '
        Me.ComboPeriodicidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPeriodicidad.FormattingEnabled = True
        Me.ComboPeriodicidad.Items.AddRange(New Object() {"Mensual", "Bimestral", "Trimestral", "Semestral", "Anual"})
        Me.ComboPeriodicidad.Location = New System.Drawing.Point(385, 26)
        Me.ComboPeriodicidad.Name = "ComboPeriodicidad"
        Me.ComboPeriodicidad.Size = New System.Drawing.Size(121, 21)
        Me.ComboPeriodicidad.TabIndex = 106
        '
        'BtnTry
        '
        Me.BtnTry.Location = New System.Drawing.Point(277, 133)
        Me.BtnTry.Name = "BtnTry"
        Me.BtnTry.Size = New System.Drawing.Size(140, 28)
        Me.BtnTry.TabIndex = 107
        Me.BtnTry.Text = "Crear Seguimientos"
        Me.BtnTry.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(277, 409)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(140, 28)
        Me.BtnSave.TabIndex = 108
        Me.BtnSave.Text = "Guardar Seguimientos"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSeguimientoORGDataGridViewTextBoxColumn, Me.IdSeguimientoDataGridViewTextBoxColumn, Me.TipoCicloDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CREDSeguimientoCiclicoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(260, 304)
        Me.DataGridView1.TabIndex = 109
        '
        'IdSeguimientoORGDataGridViewTextBoxColumn
        '
        Me.IdSeguimientoORGDataGridViewTextBoxColumn.DataPropertyName = "id_SeguimientoORG"
        Me.IdSeguimientoORGDataGridViewTextBoxColumn.HeaderText = "id_SeguimientoORG"
        Me.IdSeguimientoORGDataGridViewTextBoxColumn.Name = "IdSeguimientoORGDataGridViewTextBoxColumn"
        Me.IdSeguimientoORGDataGridViewTextBoxColumn.Visible = False
        '
        'IdSeguimientoDataGridViewTextBoxColumn
        '
        Me.IdSeguimientoDataGridViewTextBoxColumn.DataPropertyName = "id_Seguimiento"
        Me.IdSeguimientoDataGridViewTextBoxColumn.HeaderText = "id_Seguimiento"
        Me.IdSeguimientoDataGridViewTextBoxColumn.Name = "IdSeguimientoDataGridViewTextBoxColumn"
        Me.IdSeguimientoDataGridViewTextBoxColumn.Visible = False
        '
        'TipoCicloDataGridViewTextBoxColumn
        '
        Me.TipoCicloDataGridViewTextBoxColumn.DataPropertyName = "TipoCiclo"
        Me.TipoCicloDataGridViewTextBoxColumn.HeaderText = "TipoCiclo"
        Me.TipoCicloDataGridViewTextBoxColumn.Name = "TipoCicloDataGridViewTextBoxColumn"
        Me.TipoCicloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "d"
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'CREDSeguimientoCiclicoBindingSource
        '
        Me.CREDSeguimientoCiclicoBindingSource.DataMember = "CRED_SeguimientoCiclico"
        Me.CREDSeguimientoCiclicoBindingSource.DataSource = Me.CreditoDS
        '
        'CRED_SeguimientoTableAdapter
        '
        Me.CRED_SeguimientoTableAdapter.ClearBeforeFill = True
        '
        'CRED_SeguimientoCiclicoTableAdapter
        '
        Me.CRED_SeguimientoCiclicoTableAdapter.ClearBeforeFill = True
        '
        'frmSeguimientoCiclico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnTry)
        Me.Controls.Add(Me.ComboPeriodicidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtpVenc)
        Me.Controls.Add(Me.TxtCompromiso)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtResponsable)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DTPcompromiso)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTPAlta)
        Me.Name = "frmSeguimientoCiclico"
        Me.Text = "Creación de Seguimientos Ciclicos"
        CType(Me.CREDSeguimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CREDSeguimientoCiclicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCompromiso As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtResponsable As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DTPcompromiso As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DTPAlta As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DtpVenc As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboPeriodicidad As ComboBox
    Friend WithEvents CREDSeguimientoBindingSource As BindingSource
    Friend WithEvents CreditoDS As CreditoDS
    Friend WithEvents CRED_SeguimientoTableAdapter As CreditoDSTableAdapters.CRED_SeguimientoTableAdapter
    Friend WithEvents BtnTry As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CREDSeguimientoCiclicoBindingSource As BindingSource
    Friend WithEvents CRED_SeguimientoCiclicoTableAdapter As CreditoDSTableAdapters.CRED_SeguimientoCiclicoTableAdapter
    Friend WithEvents IdSeguimientoORGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdSeguimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCicloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
