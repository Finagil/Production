<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPendientes
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
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbArea = New System.Windows.Forms.ComboBox
        Me.DepartamentosFinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguridadDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguridadDS = New Agil.SeguridadDS
        Me.CmbPersona = New System.Windows.Forms.ComboBox
        Me.UsuariosFinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtAsunto = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.DepartamentosFinagilTableAdapter = New Agil.SeguridadDSTableAdapters.DepartamentosFinagilTableAdapter
        Me.UsuariosFinagilTableAdapter = New Agil.SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
        Me.DTFecha = New System.Windows.Forms.DateTimePicker
        Me.CmbCliente = New System.Windows.Forms.ComboBox
        Me.ContClie1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New Agil.ProductionDataSet
        Me.Label5 = New System.Windows.Forms.Label
        Me.ContClie1TableAdapter = New Agil.ProductionDataSetTableAdapters.ContClie1TableAdapter
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtFiltro = New System.Windows.Forms.TextBox
        CType(Me.DepartamentosFinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosFinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(176, 396)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 11
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Area"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Persona"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Asunto o Compromiso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha Vencimiento"
        '
        'CmbArea
        '
        Me.CmbArea.DataSource = Me.DepartamentosFinagilBindingSource
        Me.CmbArea.DisplayMember = "Departamento"
        Me.CmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbArea.FormattingEnabled = True
        Me.CmbArea.Location = New System.Drawing.Point(16, 30)
        Me.CmbArea.Name = "CmbArea"
        Me.CmbArea.Size = New System.Drawing.Size(315, 21)
        Me.CmbArea.TabIndex = 5
        '
        'DepartamentosFinagilBindingSource
        '
        Me.DepartamentosFinagilBindingSource.DataMember = "DepartamentosFinagil"
        Me.DepartamentosFinagilBindingSource.DataSource = Me.SeguridadDSBindingSource
        '
        'SeguridadDSBindingSource
        '
        Me.SeguridadDSBindingSource.DataSource = Me.SeguridadDS
        Me.SeguridadDSBindingSource.Position = 0
        '
        'SeguridadDS
        '
        Me.SeguridadDS.DataSetName = "SeguridadDS"
        Me.SeguridadDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbPersona
        '
        Me.CmbPersona.DataSource = Me.UsuariosFinagilBindingSource
        Me.CmbPersona.DisplayMember = "NombreCompleto"
        Me.CmbPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPersona.FormattingEnabled = True
        Me.CmbPersona.Location = New System.Drawing.Point(16, 70)
        Me.CmbPersona.Name = "CmbPersona"
        Me.CmbPersona.Size = New System.Drawing.Size(315, 21)
        Me.CmbPersona.TabIndex = 6
        Me.CmbPersona.ValueMember = "id_usuario"
        '
        'UsuariosFinagilBindingSource
        '
        Me.UsuariosFinagilBindingSource.DataMember = "UsuariosFinagil"
        Me.UsuariosFinagilBindingSource.DataSource = Me.SeguridadDSBindingSource
        '
        'TxtAsunto
        '
        Me.TxtAsunto.Location = New System.Drawing.Point(13, 235)
        Me.TxtAsunto.MaxLength = 400
        Me.TxtAsunto.Multiline = True
        Me.TxtAsunto.Name = "TxtAsunto"
        Me.TxtAsunto.Size = New System.Drawing.Size(319, 155)
        Me.TxtAsunto.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(257, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DepartamentosFinagilTableAdapter
        '
        Me.DepartamentosFinagilTableAdapter.ClearBeforeFill = True
        '
        'UsuariosFinagilTableAdapter
        '
        Me.UsuariosFinagilTableAdapter.ClearBeforeFill = True
        '
        'DTFecha
        '
        Me.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFecha.Location = New System.Drawing.Point(17, 196)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(178, 20)
        Me.DTFecha.TabIndex = 9
        '
        'CmbCliente
        '
        Me.CmbCliente.DataSource = Me.ContClie1BindingSource
        Me.CmbCliente.DisplayMember = "Descr"
        Me.CmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(17, 150)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(315, 21)
        Me.CmbCliente.TabIndex = 8
        Me.CmbCliente.ValueMember = "Cliente"
        '
        'ContClie1BindingSource
        '
        Me.ContClie1BindingSource.DataMember = "ContClie1"
        Me.ContClie1BindingSource.DataSource = Me.ProductionDataSet
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cliente"
        '
        'ContClie1TableAdapter
        '
        Me.ContClie1TableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Filtro Cliente"
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(16, 111)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(315, 20)
        Me.TxtFiltro.TabIndex = 7
        '
        'FrmPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 429)
        Me.Controls.Add(Me.TxtFiltro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTFecha)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtAsunto)
        Me.Controls.Add(Me.CmbPersona)
        Me.Controls.Add(Me.CmbArea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSave)
        Me.Name = "FrmPendientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Asunto"
        CType(Me.DepartamentosFinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosFinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPersona As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SeguridadDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeguridadDS As Agil.SeguridadDS
    Friend WithEvents DepartamentosFinagilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartamentosFinagilTableAdapter As Agil.SeguridadDSTableAdapters.DepartamentosFinagilTableAdapter
    Friend WithEvents UsuariosFinagilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosFinagilTableAdapter As Agil.SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
    Friend WithEvents DTFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProductionDataSet As Agil.ProductionDataSet
    Friend WithEvents ContClie1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContClie1TableAdapter As Agil.ProductionDataSetTableAdapters.ContClie1TableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
End Class
