<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRestiFondo
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbClientes = New System.Windows.Forms.ComboBox
        Me.ClientesConFondoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FondoResarvaDS = New Agil.FondoResarvaDS
        Me.ListContratos = New System.Windows.Forms.ListBox
        Me.AnexosConFondoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtFondo = New System.Windows.Forms.TextBox
        Me.TxtSaldo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtMov = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.ClientesConFondoTableAdapter = New Agil.FondoResarvaDSTableAdapters.ClientesConFondoTableAdapter
        Me.AnexosConFondoTableAdapter = New Agil.FondoResarvaDSTableAdapters.AnexosConFondoTableAdapter
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbBanco = New System.Windows.Forms.ComboBox
        Me.BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancosTableAdapter = New Agil.FondoResarvaDSTableAdapters.BancosTableAdapter
        Me.Label7 = New System.Windows.Forms.Label
        Me.DTFecha = New System.Windows.Forms.DateTimePicker
        CType(Me.ClientesConFondoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FondoResarvaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosConFondoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'CmbClientes
        '
        Me.CmbClientes.DataSource = Me.ClientesConFondoBindingSource
        Me.CmbClientes.DisplayMember = "Descr"
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(12, 26)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(316, 21)
        Me.CmbClientes.TabIndex = 1
        Me.CmbClientes.ValueMember = "Cliente"
        '
        'ClientesConFondoBindingSource
        '
        Me.ClientesConFondoBindingSource.DataMember = "ClientesConFondo"
        Me.ClientesConFondoBindingSource.DataSource = Me.FondoResarvaDS
        '
        'FondoResarvaDS
        '
        Me.FondoResarvaDS.DataSetName = "FondoResarvaDS"
        Me.FondoResarvaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListContratos
        '
        Me.ListContratos.DataSource = Me.AnexosConFondoBindingSource
        Me.ListContratos.DisplayMember = "AnexoCon"
        Me.ListContratos.FormattingEnabled = True
        Me.ListContratos.Location = New System.Drawing.Point(12, 66)
        Me.ListContratos.Name = "ListContratos"
        Me.ListContratos.Size = New System.Drawing.Size(222, 56)
        Me.ListContratos.TabIndex = 2
        Me.ListContratos.ValueMember = "Anexo"
        '
        'AnexosConFondoBindingSource
        '
        Me.AnexosConFondoBindingSource.DataMember = "AnexosConFondo"
        Me.AnexosConFondoBindingSource.DataSource = Me.FondoResarvaDS
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contratos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fondo de Reserva"
        '
        'TxtFondo
        '
        Me.TxtFondo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosConFondoBindingSource, "FondoReserva", True))
        Me.TxtFondo.Enabled = False
        Me.TxtFondo.Location = New System.Drawing.Point(12, 142)
        Me.TxtFondo.Name = "TxtFondo"
        Me.TxtFondo.Size = New System.Drawing.Size(100, 20)
        Me.TxtFondo.TabIndex = 5
        Me.TxtFondo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Enabled = False
        Me.TxtSaldo.Location = New System.Drawing.Point(12, 180)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.TxtSaldo.TabIndex = 7
        Me.TxtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Saldo de Reserva"
        '
        'TxtMov
        '
        Me.TxtMov.Location = New System.Drawing.Point(134, 142)
        Me.TxtMov.Name = "TxtMov"
        Me.TxtMov.Size = New System.Drawing.Size(100, 20)
        Me.TxtMov.TabIndex = 9
        Me.TxtMov.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(134, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Restitución"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(223, 220)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 23)
        Me.BtnSave.TabIndex = 11
        Me.BtnSave.Text = "Restituir"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ClientesConFondoTableAdapter
        '
        Me.ClientesConFondoTableAdapter.ClearBeforeFill = True
        '
        'AnexosConFondoTableAdapter
        '
        Me.AnexosConFondoTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(134, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Banco"
        '
        'CmbBanco
        '
        Me.CmbBanco.DataSource = Me.BancosBindingSource
        Me.CmbBanco.DisplayMember = "DescBanco"
        Me.CmbBanco.FormattingEnabled = True
        Me.CmbBanco.Location = New System.Drawing.Point(134, 180)
        Me.CmbBanco.Name = "CmbBanco"
        Me.CmbBanco.Size = New System.Drawing.Size(189, 21)
        Me.CmbBanco.TabIndex = 10
        Me.CmbBanco.ValueMember = "Banco"
        '
        'BancosBindingSource
        '
        Me.BancosBindingSource.DataMember = "Bancos"
        Me.BancosBindingSource.DataSource = Me.FondoResarvaDS
        '
        'BancosTableAdapter
        '
        Me.BancosTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Saldo de Reserva"
        '
        'DTFecha
        '
        Me.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFecha.Location = New System.Drawing.Point(12, 221)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(100, 20)
        Me.DTFecha.TabIndex = 13
        '
        'FrmRestiFondo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 253)
        Me.Controls.Add(Me.DTFecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmbBanco)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtMov)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSaldo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtFondo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListContratos)
        Me.Controls.Add(Me.CmbClientes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmRestiFondo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Restitucion de Fondo de Reserva"
        CType(Me.ClientesConFondoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FondoResarvaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosConFondoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents ListContratos As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtFondo As System.Windows.Forms.TextBox
    Friend WithEvents TxtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMov As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents FondoResarvaDS As Agil.FondoResarvaDS
    Friend WithEvents ClientesConFondoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesConFondoTableAdapter As Agil.FondoResarvaDSTableAdapters.ClientesConFondoTableAdapter
    Friend WithEvents AnexosConFondoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexosConFondoTableAdapter As Agil.FondoResarvaDSTableAdapters.AnexosConFondoTableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents BancosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BancosTableAdapter As Agil.FondoResarvaDSTableAdapters.BancosTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DTFecha As System.Windows.Forms.DateTimePicker
End Class
