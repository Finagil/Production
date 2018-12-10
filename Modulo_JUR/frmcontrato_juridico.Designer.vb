<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcontrato_juridico
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
        Me.cbclientes = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MesaControlDS = New Agil.MesaControlDS()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbanexos = New System.Windows.Forms.ComboBox()
        Me.ContratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JuridicoDS = New Agil.JuridicoDS()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.TxtCiclo = New System.Windows.Forms.TextBox()
        Me.ClientesTableAdapter = New Agil.MesaControlDSTableAdapters.ClientesTableAdapter()
        Me.ContratosSinDispersionTableAdapter = New Agil.JuridicoDSTableAdapters.ContratosSinDispersionTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_contrato = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_fecontrato = New System.Windows.Forms.DateTimePicker()
        Me.bt_cambiar = New System.Windows.Forms.Button()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbclientes
        '
        Me.cbclientes.DataSource = Me.ClientesBindingSource
        Me.cbclientes.DisplayMember = "Descr"
        Me.cbclientes.FormattingEnabled = True
        Me.cbclientes.Location = New System.Drawing.Point(25, 68)
        Me.cbclientes.Name = "cbclientes"
        Me.cbclientes.Size = New System.Drawing.Size(269, 21)
        Me.cbclientes.TabIndex = 46
        Me.cbclientes.ValueMember = "Cliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.MesaControlDS
        '
        'MesaControlDS
        '
        Me.MesaControlDS.DataSetName = "MesaControlDS"
        Me.MesaControlDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Selecciona un contrato  de la lista"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Selecciona un cliente de la lista"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Filtro Clientes"
        '
        'cbanexos
        '
        Me.cbanexos.DataSource = Me.ContratosBindingSource
        Me.cbanexos.DisplayMember = "AnexoCon"
        Me.cbanexos.FormattingEnabled = True
        Me.cbanexos.Location = New System.Drawing.Point(27, 109)
        Me.cbanexos.Name = "cbanexos"
        Me.cbanexos.Size = New System.Drawing.Size(123, 21)
        Me.cbanexos.TabIndex = 40
        Me.cbanexos.ValueMember = "Anexo"
        '
        'ContratosBindingSource
        '
        Me.ContratosBindingSource.DataMember = "ContratosSinDispersion"
        Me.ContratosBindingSource.DataSource = Me.JuridicoDS
        '
        'JuridicoDS
        '
        Me.JuridicoDS.DataSetName = "JuridicoDS"
        Me.JuridicoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(25, 29)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(272, 20)
        Me.txtcliente.TabIndex = 39
        '
        'TxtCiclo
        '
        Me.TxtCiclo.Location = New System.Drawing.Point(126, 109)
        Me.TxtCiclo.Name = "TxtCiclo"
        Me.TxtCiclo.ReadOnly = True
        Me.TxtCiclo.Size = New System.Drawing.Size(10, 20)
        Me.TxtCiclo.TabIndex = 47
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ContratosSinDispersionTableAdapter
        '
        Me.ContratosSinDispersionTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 49
        '
        'txt_contrato
        '
        Me.txt_contrato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContratosBindingSource, "FechaCon", True))
        Me.txt_contrato.Enabled = False
        Me.txt_contrato.Location = New System.Drawing.Point(239, 110)
        Me.txt_contrato.Name = "txt_contrato"
        Me.txt_contrato.Size = New System.Drawing.Size(113, 20)
        Me.txt_contrato.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Fecha Contrato"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Nueva Fecha"
        '
        'dt_fecontrato
        '
        Me.dt_fecontrato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecontrato.Location = New System.Drawing.Point(100, 136)
        Me.dt_fecontrato.Name = "dt_fecontrato"
        Me.dt_fecontrato.Size = New System.Drawing.Size(89, 20)
        Me.dt_fecontrato.TabIndex = 53
        '
        'bt_cambiar
        '
        Me.bt_cambiar.Location = New System.Drawing.Point(208, 136)
        Me.bt_cambiar.Name = "bt_cambiar"
        Me.bt_cambiar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cambiar.TabIndex = 54
        Me.bt_cambiar.Text = "Cambiar"
        Me.bt_cambiar.UseVisualStyleBackColor = True
        '
        'frmcontrato_juridico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 173)
        Me.Controls.Add(Me.bt_cambiar)
        Me.Controls.Add(Me.dt_fecontrato)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_contrato)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbclientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbanexos)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.TxtCiclo)
        Me.Name = "frmcontrato_juridico"
        Me.Text = "Cambio de Fecha de Contrato"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbclientes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbanexos As ComboBox
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents TxtCiclo As TextBox
    Friend WithEvents MesaControlDS As MesaControlDS
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As MesaControlDSTableAdapters.ClientesTableAdapter
    Friend WithEvents JuridicoDS As JuridicoDS
    Friend WithEvents ContratosBindingSource As BindingSource
    Friend WithEvents ContratosSinDispersionTableAdapter As JuridicoDSTableAdapters.ContratosSinDispersionTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_contrato As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dt_fecontrato As DateTimePicker
    Friend WithEvents bt_cambiar As Button
End Class
