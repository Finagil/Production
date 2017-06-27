<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbitacora_anexos
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
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BitacoraanexosDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MesaControlDS = New Agil.MesaControlDS()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtjustificacion = New System.Windows.Forms.TextBox()
        Me.ckescritura = New System.Windows.Forms.CheckBox()
        Me.ckfactura = New System.Windows.Forms.CheckBox()
        Me.ckgarantia = New System.Windows.Forms.CheckBox()
        Me.ckconvenio = New System.Windows.Forms.CheckBox()
        Me.ckcontrato = New System.Windows.Forms.CheckBox()
        Me.ckpagare = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Contrato = New System.Windows.Forms.Label()
        Me.txt_anexo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbanexos = New System.Windows.Forms.ComboBox()
        Me.VwAnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.bt_solicitar = New System.Windows.Forms.Button()
        Me.ClientesTableAdapter = New Agil.MesaControlDSTableAdapters.ClientesTableAdapter()
        Me.Vw_AnexosTableAdapter = New Agil.MesaControlDSTableAdapters.Vw_AnexosTableAdapter()
        Me.TxtCiclo = New System.Windows.Forms.TextBox()
        Me.TxtcicloPag = New System.Windows.Forms.TextBox()
        Me.CkAuditoria = New System.Windows.Forms.CheckBox()
        Me.CkNoAdeudo = New System.Windows.Forms.CheckBox()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitacoraanexosDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwAnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbclientes
        '
        Me.cbclientes.DataSource = Me.ClientesBindingSource1
        Me.cbclientes.DisplayMember = "Descr"
        Me.cbclientes.FormattingEnabled = True
        Me.cbclientes.Location = New System.Drawing.Point(24, 80)
        Me.cbclientes.Name = "cbclientes"
        Me.cbclientes.Size = New System.Drawing.Size(269, 21)
        Me.cbclientes.TabIndex = 35
        Me.cbclientes.ValueMember = "Cliente"
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Clientes"
        Me.ClientesBindingSource1.DataSource = Me.BitacoraanexosDSBindingSource
        '
        'BitacoraanexosDSBindingSource
        '
        Me.BitacoraanexosDSBindingSource.DataSource = Me.MesaControlDS
        Me.BitacoraanexosDSBindingSource.Position = 0
        '
        'MesaControlDS
        '
        Me.MesaControlDS.DataSetName = "MesaControlDS"
        Me.MesaControlDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.MesaControlDS
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Justificación"
        '
        'txtjustificacion
        '
        Me.txtjustificacion.Location = New System.Drawing.Point(24, 222)
        Me.txtjustificacion.MaxLength = 500
        Me.txtjustificacion.Multiline = True
        Me.txtjustificacion.Name = "txtjustificacion"
        Me.txtjustificacion.Size = New System.Drawing.Size(388, 105)
        Me.txtjustificacion.TabIndex = 34
        '
        'ckescritura
        '
        Me.ckescritura.AutoSize = True
        Me.ckescritura.Location = New System.Drawing.Point(246, 183)
        Me.ckescritura.Name = "ckescritura"
        Me.ckescritura.Size = New System.Drawing.Size(72, 17)
        Me.ckescritura.TabIndex = 32
        Me.ckescritura.Text = "Escrituras"
        Me.ckescritura.UseVisualStyleBackColor = True
        '
        'ckfactura
        '
        Me.ckfactura.AutoSize = True
        Me.ckfactura.Location = New System.Drawing.Point(245, 151)
        Me.ckfactura.Name = "ckfactura"
        Me.ckfactura.Size = New System.Drawing.Size(67, 17)
        Me.ckfactura.TabIndex = 31
        Me.ckfactura.Text = "Facturas"
        Me.ckfactura.UseVisualStyleBackColor = True
        '
        'ckgarantia
        '
        Me.ckgarantia.AutoSize = True
        Me.ckgarantia.Location = New System.Drawing.Point(131, 183)
        Me.ckgarantia.Name = "ckgarantia"
        Me.ckgarantia.Size = New System.Drawing.Size(68, 17)
        Me.ckgarantia.TabIndex = 30
        Me.ckgarantia.Text = "Garantía"
        Me.ckgarantia.UseVisualStyleBackColor = True
        '
        'ckconvenio
        '
        Me.ckconvenio.AutoSize = True
        Me.ckconvenio.Location = New System.Drawing.Point(131, 151)
        Me.ckconvenio.Name = "ckconvenio"
        Me.ckconvenio.Size = New System.Drawing.Size(71, 17)
        Me.ckconvenio.TabIndex = 29
        Me.ckconvenio.Text = "Convenio"
        Me.ckconvenio.UseVisualStyleBackColor = True
        '
        'ckcontrato
        '
        Me.ckcontrato.AutoSize = True
        Me.ckcontrato.Location = New System.Drawing.Point(24, 183)
        Me.ckcontrato.Name = "ckcontrato"
        Me.ckcontrato.Size = New System.Drawing.Size(66, 17)
        Me.ckcontrato.TabIndex = 28
        Me.ckcontrato.Text = "Contrato"
        Me.ckcontrato.UseVisualStyleBackColor = True
        '
        'ckpagare
        '
        Me.ckpagare.AutoSize = True
        Me.ckpagare.Location = New System.Drawing.Point(24, 151)
        Me.ckpagare.Name = "ckpagare"
        Me.ckpagare.Size = New System.Drawing.Size(60, 17)
        Me.ckpagare.TabIndex = 27
        Me.ckpagare.Text = "Pagaré"
        Me.ckpagare.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Selecciona un contrato  de la lista"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Selecciona un cliente de la lista"
        '
        'Contrato
        '
        Me.Contrato.AutoSize = True
        Me.Contrato.Location = New System.Drawing.Point(299, 21)
        Me.Contrato.Name = "Contrato"
        Me.Contrato.Size = New System.Drawing.Size(72, 13)
        Me.Contrato.TabIndex = 24
        Me.Contrato.Text = "Filtro Contrato"
        '
        'txt_anexo
        '
        Me.txt_anexo.Location = New System.Drawing.Point(302, 41)
        Me.txt_anexo.Name = "txt_anexo"
        Me.txt_anexo.Size = New System.Drawing.Size(91, 20)
        Me.txt_anexo.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Filtro Clientes"
        '
        'cbanexos
        '
        Me.cbanexos.DataSource = Me.VwAnexosBindingSource
        Me.cbanexos.DisplayMember = "AnexoCon"
        Me.cbanexos.FormattingEnabled = True
        Me.cbanexos.Location = New System.Drawing.Point(26, 121)
        Me.cbanexos.Name = "cbanexos"
        Me.cbanexos.Size = New System.Drawing.Size(123, 21)
        Me.cbanexos.TabIndex = 21
        Me.cbanexos.ValueMember = "Anexo"
        '
        'VwAnexosBindingSource
        '
        Me.VwAnexosBindingSource.DataMember = "Vw_Anexos"
        Me.VwAnexosBindingSource.DataSource = Me.BitacoraanexosDSBindingSource
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(24, 41)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(272, 20)
        Me.txtcliente.TabIndex = 20
        '
        'bt_solicitar
        '
        Me.bt_solicitar.Location = New System.Drawing.Point(329, 333)
        Me.bt_solicitar.Name = "bt_solicitar"
        Me.bt_solicitar.Size = New System.Drawing.Size(83, 29)
        Me.bt_solicitar.TabIndex = 36
        Me.bt_solicitar.Text = "Solicitar"
        Me.bt_solicitar.UseVisualStyleBackColor = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Vw_AnexosTableAdapter
        '
        Me.Vw_AnexosTableAdapter.ClearBeforeFill = True
        '
        'TxtCiclo
        '
        Me.TxtCiclo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwAnexosBindingSource, "Ciclo", True))
        Me.TxtCiclo.Location = New System.Drawing.Point(125, 121)
        Me.TxtCiclo.Name = "TxtCiclo"
        Me.TxtCiclo.ReadOnly = True
        Me.TxtCiclo.Size = New System.Drawing.Size(10, 20)
        Me.TxtCiclo.TabIndex = 37
        '
        'TxtcicloPag
        '
        Me.TxtcicloPag.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwAnexosBindingSource, "CicloPagare", True))
        Me.TxtcicloPag.Location = New System.Drawing.Point(155, 121)
        Me.TxtcicloPag.Name = "TxtcicloPag"
        Me.TxtcicloPag.ReadOnly = True
        Me.TxtcicloPag.Size = New System.Drawing.Size(138, 20)
        Me.TxtcicloPag.TabIndex = 38
        '
        'CkAuditoria
        '
        Me.CkAuditoria.AutoSize = True
        Me.CkAuditoria.Location = New System.Drawing.Point(26, 333)
        Me.CkAuditoria.Name = "CkAuditoria"
        Me.CkAuditoria.Size = New System.Drawing.Size(120, 17)
        Me.CkAuditoria.TabIndex = 35
        Me.CkAuditoria.Text = "Es auditoria Externa"
        Me.CkAuditoria.UseVisualStyleBackColor = True
        '
        'CkNoAdeudo
        '
        Me.CkNoAdeudo.AutoSize = True
        Me.CkNoAdeudo.Location = New System.Drawing.Point(329, 204)
        Me.CkNoAdeudo.Name = "CkNoAdeudo"
        Me.CkNoAdeudo.Size = New System.Drawing.Size(80, 17)
        Me.CkNoAdeudo.TabIndex = 33
        Me.CkNoAdeudo.Text = "No Adeudo"
        Me.CkNoAdeudo.UseVisualStyleBackColor = True
        '
        'frmbitacora_anexos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 373)
        Me.Controls.Add(Me.CkNoAdeudo)
        Me.Controls.Add(Me.CkAuditoria)
        Me.Controls.Add(Me.TxtcicloPag)
        Me.Controls.Add(Me.bt_solicitar)
        Me.Controls.Add(Me.cbclientes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtjustificacion)
        Me.Controls.Add(Me.ckescritura)
        Me.Controls.Add(Me.ckfactura)
        Me.Controls.Add(Me.ckgarantia)
        Me.Controls.Add(Me.ckconvenio)
        Me.Controls.Add(Me.ckcontrato)
        Me.Controls.Add(Me.ckpagare)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Contrato)
        Me.Controls.Add(Me.txt_anexo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbanexos)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.TxtCiclo)
        Me.Name = "frmbitacora_anexos"
        Me.Text = "Bitacora "
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitacoraanexosDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwAnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbclientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtjustificacion As System.Windows.Forms.TextBox
    Friend WithEvents ckescritura As System.Windows.Forms.CheckBox
    Friend WithEvents ckfactura As System.Windows.Forms.CheckBox
    Friend WithEvents ckgarantia As System.Windows.Forms.CheckBox
    Friend WithEvents ckconvenio As System.Windows.Forms.CheckBox
    Friend WithEvents ckcontrato As System.Windows.Forms.CheckBox
    Friend WithEvents ckpagare As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Contrato As System.Windows.Forms.Label
    Friend WithEvents txt_anexo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbanexos As System.Windows.Forms.ComboBox
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents bt_solicitar As System.Windows.Forms.Button
    Friend WithEvents MesaControlDS As Agil.MesaControlDS
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Agil.MesaControlDSTableAdapters.ClientesTableAdapter
    Friend WithEvents ClientesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BitacoraanexosDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwAnexosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_AnexosTableAdapter As Agil.MesaControlDSTableAdapters.Vw_AnexosTableAdapter
    Friend WithEvents TxtCiclo As TextBox
    Friend WithEvents TxtcicloPag As TextBox
    Friend WithEvents CkAuditoria As CheckBox
    Friend WithEvents CkNoAdeudo As CheckBox
End Class
