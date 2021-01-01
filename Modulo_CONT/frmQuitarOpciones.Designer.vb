<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuitarOpciones
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextAmorin = New System.Windows.Forms.TextBox()
        Me.ButtonOP = New System.Windows.Forms.Button()
        Me.TextGastos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.cbclientes.TabIndex = 2
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
        Me.cbanexos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbanexos.FormattingEnabled = True
        Me.cbanexos.Location = New System.Drawing.Point(27, 109)
        Me.cbanexos.Name = "cbanexos"
        Me.cbanexos.Size = New System.Drawing.Size(123, 21)
        Me.cbanexos.TabIndex = 3
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
        Me.txtcliente.TabIndex = 1
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Iva Opción"
        '
        'TextAmorin
        '
        Me.TextAmorin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContratosBindingSource, "IvaOpcion", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextAmorin.Enabled = False
        Me.TextAmorin.Location = New System.Drawing.Point(170, 170)
        Me.TextAmorin.Name = "TextAmorin"
        Me.TextAmorin.ReadOnly = True
        Me.TextAmorin.Size = New System.Drawing.Size(89, 20)
        Me.TextAmorin.TabIndex = 56
        Me.TextAmorin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonOP
        '
        Me.ButtonOP.Location = New System.Drawing.Point(265, 173)
        Me.ButtonOP.Name = "ButtonOP"
        Me.ButtonOP.Size = New System.Drawing.Size(101, 47)
        Me.ButtonOP.TabIndex = 4
        Me.ButtonOP.Text = "Quitar Opcion a Comp."
        Me.ButtonOP.UseVisualStyleBackColor = True
        '
        'TextGastos
        '
        Me.TextGastos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContratosBindingSource, "Pagado", True))
        Me.TextGastos.Enabled = False
        Me.TextGastos.Location = New System.Drawing.Point(170, 199)
        Me.TextGastos.Name = "TextGastos"
        Me.TextGastos.ReadOnly = True
        Me.TextGastos.Size = New System.Drawing.Size(89, 20)
        Me.TextGastos.TabIndex = 59
        Me.TextGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(106, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Pagada"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContratosBindingSource, "Opcion", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(170, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(89, 20)
        Me.TextBox1.TabIndex = 62
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(106, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Opción"
        '
        'frmQuitarOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 229)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonOP)
        Me.Controls.Add(Me.TextGastos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextAmorin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbclientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbanexos)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.TxtCiclo)
        Me.Name = "frmQuitarOpciones"
        Me.Text = "Cambio Op. a Compra o Valor Residual"
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
    Friend WithEvents Label7 As Label
    Friend WithEvents TextAmorin As TextBox
    Friend WithEvents ButtonOP As Button
    Friend WithEvents TextGastos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
End Class
