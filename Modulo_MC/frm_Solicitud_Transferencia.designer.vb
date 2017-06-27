<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Solicitud_Transferencia
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
        Me.components = New System.ComponentModel.Container()
        Me.cbclientes = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bitacora_anexosDS = New Agil.MesaControlDS()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Contrato = New System.Windows.Forms.Label()
        Me.txt_anexo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbanexos = New System.Windows.Forms.ComboBox()
        Me.VwAnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.ClientesTableAdapter = New Agil.MesaControlDSTableAdapters.ClientesTableAdapter()
        Me.Vw_AnexosTableAdapter = New Agil.MesaControlDSTableAdapters.Vw_AnexosTableAdapter()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.txt_sucursal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_solicitud = New System.Windows.Forms.DateTimePicker()
        Me.Solicitud_transDS = New Agil.MesaControlDS()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_CUENTA = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.Vw_mfinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_mfinagilTableAdapter = New Agil.MesaControlDSTableAdapters.vw_mfinagilTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bitacora_anexosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwAnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Solicitud_transDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Vw_mfinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbclientes
        '
        Me.cbclientes.DataSource = Me.ClientesBindingSource
        Me.cbclientes.DisplayMember = "Descr"
        Me.cbclientes.Enabled = False
        Me.cbclientes.FormattingEnabled = True
        Me.cbclientes.Location = New System.Drawing.Point(15, 84)
        Me.cbclientes.Name = "cbclientes"
        Me.cbclientes.Size = New System.Drawing.Size(269, 21)
        Me.cbclientes.TabIndex = 43
        Me.cbclientes.ValueMember = "Cliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.Bitacora_anexosDS
        '
        'Bitacora_anexosDS
        '
        Me.Bitacora_anexosDS.DataSetName = "Bitacora_anexosDS"
        Me.Bitacora_anexosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(384, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Selecciona un contrato  de la lista"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Selecciona un cliente de la lista"
        '
        'Contrato
        '
        Me.Contrato.AutoSize = True
        Me.Contrato.Enabled = False
        Me.Contrato.Location = New System.Drawing.Point(384, 25)
        Me.Contrato.Name = "Contrato"
        Me.Contrato.Size = New System.Drawing.Size(72, 13)
        Me.Contrato.TabIndex = 40
        Me.Contrato.Text = "Filtro Contrato"
        '
        'txt_anexo
        '
        Me.txt_anexo.Enabled = False
        Me.txt_anexo.Location = New System.Drawing.Point(387, 45)
        Me.txt_anexo.Name = "txt_anexo"
        Me.txt_anexo.Size = New System.Drawing.Size(91, 20)
        Me.txt_anexo.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Filtro Clientes"
        '
        'cbanexos
        '
        Me.cbanexos.DataSource = Me.VwAnexosBindingSource
        Me.cbanexos.DisplayMember = "AnexoCon"
        Me.cbanexos.Enabled = False
        Me.cbanexos.FormattingEnabled = True
        Me.cbanexos.Location = New System.Drawing.Point(387, 84)
        Me.cbanexos.Name = "cbanexos"
        Me.cbanexos.Size = New System.Drawing.Size(116, 21)
        Me.cbanexos.TabIndex = 37
        Me.cbanexos.ValueMember = "Anexo"
        '
        'VwAnexosBindingSource
        '
        Me.VwAnexosBindingSource.DataMember = "Vw_Anexos"
        Me.VwAnexosBindingSource.DataSource = Me.Bitacora_anexosDS
        '
        'txtcliente
        '
        Me.txtcliente.Enabled = False
        Me.txtcliente.Location = New System.Drawing.Point(12, 45)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(272, 20)
        Me.txtcliente.TabIndex = 36
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Vw_AnexosTableAdapter
        '
        Me.Vw_AnexosTableAdapter.ClearBeforeFill = True
        '
        'txt_tipo
        '
        Me.txt_tipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwAnexosBindingSource, "Fondeotit", True))
        Me.txt_tipo.Enabled = False
        Me.txt_tipo.Location = New System.Drawing.Point(64, 112)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(100, 20)
        Me.txt_tipo.TabIndex = 113
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Enabled = False
        Me.Label24.Location = New System.Drawing.Point(12, 115)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 13)
        Me.Label24.TabIndex = 112
        Me.Label24.Text = "Fondeo "
        '
        'txt_producto
        '
        Me.txt_producto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwAnexosBindingSource, "Cultivo", True))
        Me.txt_producto.Enabled = False
        Me.txt_producto.Location = New System.Drawing.Point(451, 115)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(100, 20)
        Me.txt_producto.TabIndex = 87
        '
        'txt_sucursal
        '
        Me.txt_sucursal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwAnexosBindingSource, "Nombre_Sucursal", True))
        Me.txt_sucursal.Enabled = False
        Me.txt_sucursal.Location = New System.Drawing.Point(252, 112)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Size = New System.Drawing.Size(100, 20)
        Me.txt_sucursal.TabIndex = 84
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Location = New System.Drawing.Point(384, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Producto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Location = New System.Drawing.Point(198, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Sucursal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(19, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha Alta"
        '
        'dt_solicitud
        '
        Me.dt_solicitud.Enabled = False
        Me.dt_solicitud.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_solicitud.Location = New System.Drawing.Point(83, 138)
        Me.dt_solicitud.Name = "dt_solicitud"
        Me.dt_solicitud.Size = New System.Drawing.Size(107, 20)
        Me.dt_solicitud.TabIndex = 46
        '
        'Solicitud_transDS
        '
        Me.Solicitud_transDS.DataSetName = "solicitud_transDS"
        Me.Solicitud_transDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(92, 17)
        Me.ListBox1.TabIndex = 4
        Me.ListBox1.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Anexo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(214, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Concepto"
        '
        'TXT_CUENTA
        '
        Me.TXT_CUENTA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwAnexosBindingSource, "Anexo", True))
        Me.TXT_CUENTA.Enabled = False
        Me.TXT_CUENTA.Location = New System.Drawing.Point(6, 36)
        Me.TXT_CUENTA.Name = "TXT_CUENTA"
        Me.TXT_CUENTA.Size = New System.Drawing.Size(100, 20)
        Me.TXT_CUENTA.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_CUENTA)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.txt_fecha)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 271)
        Me.GroupBox1.TabIndex = 114
        Me.GroupBox1.TabStop = False
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(6, 36)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.ReadOnly = True
        Me.txt_fecha.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha.TabIndex = 6
        '
        'Vw_mfinagilBindingSource
        '
        Me.Vw_mfinagilBindingSource.DataMember = "vw_mfinagil"
        Me.Vw_mfinagilBindingSource.DataSource = Me.Solicitud_transDS
        '
        'Vw_mfinagilTableAdapter
        '
        Me.Vw_mfinagilTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(512, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 115
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_Solicitud_Transferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 454)
        Me.Controls.Add(Me.dt_solicitud)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_tipo)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txt_producto)
        Me.Controls.Add(Me.txt_sucursal)
        Me.Controls.Add(Me.cbclientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Contrato)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_anexo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbanexos)
        Me.Controls.Add(Me.txtcliente)
        Me.Name = "frm_Solicitud_Transferencia"
        Me.Text = "Solicitud de Transferencia"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bitacora_anexosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwAnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Solicitud_transDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Vw_mfinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbclientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Contrato As System.Windows.Forms.Label
    Friend WithEvents txt_anexo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbanexos As System.Windows.Forms.ComboBox
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents Bitacora_anexosDS As Agil.MesaControlDS
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Agil.MesaControlDSTableAdapters.ClientesTableAdapter
    Friend WithEvents VwAnexosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_AnexosTableAdapter As Agil.MesaControlDSTableAdapters.Vw_AnexosTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_solicitud As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_sucursal As System.Windows.Forms.TextBox
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_tipo As System.Windows.Forms.TextBox
    Friend WithEvents Solicitud_transDS As Agil.MesaControlDS
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXT_CUENTA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Vw_mfinagilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_mfinagilTableAdapter As Agil.MesaControlDSTableAdapters.vw_mfinagilTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
End Class
