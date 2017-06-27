<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConvenioJUR
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
        Me.CmbAnexo = New System.Windows.Forms.ComboBox
        Me.VwAnexosResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JuridicoDS = New Agil.JuridicoDS
        Me.CmbClientes = New System.Windows.Forms.ComboBox
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Txtfiltro = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ClientesTableAdapter = New Agil.JuridicoDSTableAdapters.ClientesTableAdapter
        Me.Vw_AnexosResumenTableAdapter = New Agil.JuridicoDSTableAdapters.Vw_AnexosResumenTableAdapter
        Me.TxtTipo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ListConvenioJUR = New System.Windows.Forms.ListBox
        Me.AnexosConvenioJURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexosConvenioJURTableAdapter = New Agil.JuridicoDSTableAdapters.AnexosConvenioJURTableAdapter
        CType(Me.VwAnexosResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosConvenioJURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbAnexo
        '
        Me.CmbAnexo.DataSource = Me.VwAnexosResumenBindingSource
        Me.CmbAnexo.DisplayMember = "Titulo"
        Me.CmbAnexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnexo.FormattingEnabled = True
        Me.CmbAnexo.Location = New System.Drawing.Point(15, 94)
        Me.CmbAnexo.Name = "CmbAnexo"
        Me.CmbAnexo.Size = New System.Drawing.Size(427, 21)
        Me.CmbAnexo.TabIndex = 13
        Me.CmbAnexo.ValueMember = "Expr1"
        '
        'VwAnexosResumenBindingSource
        '
        Me.VwAnexosResumenBindingSource.DataMember = "Vw_AnexosResumen"
        Me.VwAnexosResumenBindingSource.DataSource = Me.JuridicoDS
        '
        'JuridicoDS
        '
        Me.JuridicoDS.DataSetName = "JuridicoDS"
        Me.JuridicoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbClientes
        '
        Me.CmbClientes.DataSource = Me.ClientesBindingSource
        Me.CmbClientes.DisplayMember = "Nombre"
        Me.CmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(15, 52)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(425, 21)
        Me.CmbClientes.TabIndex = 12
        Me.CmbClientes.ValueMember = "Cliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.JuridicoDS
        '
        'Txtfiltro
        '
        Me.Txtfiltro.Location = New System.Drawing.Point(15, 26)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(425, 20)
        Me.Txtfiltro.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Filtro Clientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Anexos"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Vw_AnexosResumenTableAdapter
        '
        Me.Vw_AnexosResumenTableAdapter.ClearBeforeFill = True
        '
        'TxtTipo
        '
        Me.TxtTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Tipo", True))
        Me.TxtTipo.Location = New System.Drawing.Point(403, 53)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.Size = New System.Drawing.Size(19, 20)
        Me.TxtTipo.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Contratos con Convenio Judicial"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Agregar contrato"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListConvenioJUR
        '
        Me.ListConvenioJUR.DataSource = Me.AnexosConvenioJURBindingSource
        Me.ListConvenioJUR.DisplayMember = "Titulo"
        Me.ListConvenioJUR.FormattingEnabled = True
        Me.ListConvenioJUR.Location = New System.Drawing.Point(15, 172)
        Me.ListConvenioJUR.Name = "ListConvenioJUR"
        Me.ListConvenioJUR.Size = New System.Drawing.Size(425, 238)
        Me.ListConvenioJUR.TabIndex = 20
        Me.ListConvenioJUR.ValueMember = "Anexo"
        '
        'AnexosConvenioJURBindingSource
        '
        Me.AnexosConvenioJURBindingSource.DataMember = "AnexosConvenioJUR"
        Me.AnexosConvenioJURBindingSource.DataSource = Me.JuridicoDS
        '
        'AnexosConvenioJURTableAdapter
        '
        Me.AnexosConvenioJURTableAdapter.ClearBeforeFill = True
        '
        'FrmConvenioJUR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 418)
        Me.Controls.Add(Me.ListConvenioJUR)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbAnexo)
        Me.Controls.Add(Me.CmbClientes)
        Me.Controls.Add(Me.Txtfiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTipo)
        Me.Name = "FrmConvenioJUR"
        Me.Text = "Contratos con Convenio Judicial"
        CType(Me.VwAnexosResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosConvenioJURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbAnexo As System.Windows.Forms.ComboBox
    Friend WithEvents CmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents Txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JuridicoDS As Agil.JuridicoDS
    Friend WithEvents ClientesTableAdapter As Agil.JuridicoDSTableAdapters.ClientesTableAdapter
    Friend WithEvents VwAnexosResumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_AnexosResumenTableAdapter As Agil.JuridicoDSTableAdapters.Vw_AnexosResumenTableAdapter
    Friend WithEvents TxtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListConvenioJUR As System.Windows.Forms.ListBox
    Friend WithEvents AnexosConvenioJURBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexosConvenioJURTableAdapter As Agil.JuridicoDSTableAdapters.AnexosConvenioJURTableAdapter
End Class
