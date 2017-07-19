<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCastigoGaratia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ClientesConAnexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContaDS = New Agil.ContaDS()
        Me.ClientesConAnexoTableAdapter = New Agil.ContaDSTableAdapters.ClientesConAnexoTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.AnexosClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexosClienteTableAdapter = New Agil.ContaDSTableAdapters.AnexosClienteTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.TxtInte = New System.Windows.Forms.TextBox()
        Me.CONTCastigosGarantiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtPago = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtGarant = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCasti = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtAdd = New System.Windows.Forms.Button()
        Me.CONT_Castigos_GarantiasTableAdapter = New Agil.ContaDSTableAdapters.CONT_Castigos_GarantiasTableAdapter()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        CType(Me.ClientesConAnexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CONTCastigosGarantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClientesConAnexoBindingSource
        Me.ComboBox1.DisplayMember = "Descr"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(129, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(517, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "Cliente"
        '
        'ClientesConAnexoBindingSource
        '
        Me.ClientesConAnexoBindingSource.DataMember = "ClientesConAnexo"
        Me.ClientesConAnexoBindingSource.DataSource = Me.ContaDS
        '
        'ContaDS
        '
        Me.ContaDS.DataSetName = "ContaDS"
        Me.ContaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesConAnexoTableAdapter
        '
        Me.ClientesConAnexoTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Anexos"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.AnexosClienteBindingSource
        Me.ComboBox2.DisplayMember = "AnexoCon"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(19, 75)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.ValueMember = "Anexo"
        '
        'AnexosClienteBindingSource
        '
        Me.AnexosClienteBindingSource.DataMember = "AnexosCliente"
        Me.AnexosClienteBindingSource.DataSource = Me.ContaDS
        '
        'AnexosClienteTableAdapter
        '
        Me.AnexosClienteTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ciclo Pagaré"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosClienteBindingSource, "CicloPagare", True))
        Me.TextBox1.Location = New System.Drawing.Point(149, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(91, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosClienteBindingSource, "TipoCredito", True))
        Me.TextBox2.Location = New System.Drawing.Point(246, 75)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(181, 20)
        Me.TextBox2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo Crédito"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosClienteBindingSource, "Status", True))
        Me.TextBox3.Location = New System.Drawing.Point(433, 75)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(430, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Estatus"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosClienteBindingSource, "MontoFinanciado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextBox4.Location = New System.Drawing.Point(539, 75)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(536, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Monto Finanaciado"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosClienteBindingSource, "Fondeotit", True))
        Me.TextBox5.Location = New System.Drawing.Point(645, 74)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(83, 20)
        Me.TextBox5.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(642, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fondeo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtSave)
        Me.GroupBox1.Controls.Add(Me.TxtInte)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtPago)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtGarant)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtCasti)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(19, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 81)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos:"
        '
        'BtSave
        '
        Me.BtSave.Location = New System.Drawing.Point(552, 34)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(75, 23)
        Me.BtSave.TabIndex = 10
        Me.BtSave.Text = "Guardar"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'TxtInte
        '
        Me.TxtInte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTCastigosGarantiasBindingSource, "Interes", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtInte.Location = New System.Drawing.Point(446, 37)
        Me.TxtInte.Name = "TxtInte"
        Me.TxtInte.Size = New System.Drawing.Size(100, 20)
        Me.TxtInte.TabIndex = 9
        '
        'CONTCastigosGarantiasBindingSource
        '
        Me.CONTCastigosGarantiasBindingSource.DataMember = "CONT_Castigos_Garantias"
        Me.CONTCastigosGarantiasBindingSource.DataSource = Me.ContaDS
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(448, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Interés"
        '
        'TxtPago
        '
        Me.TxtPago.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTCastigosGarantiasBindingSource, "Pago", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtPago.Location = New System.Drawing.Point(340, 37)
        Me.TxtPago.Name = "TxtPago"
        Me.TxtPago.Size = New System.Drawing.Size(100, 20)
        Me.TxtPago.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(342, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Pago"
        '
        'TxtGarant
        '
        Me.TxtGarant.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTCastigosGarantiasBindingSource, "Garantia", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtGarant.Location = New System.Drawing.Point(234, 37)
        Me.TxtGarant.Name = "TxtGarant"
        Me.TxtGarant.Size = New System.Drawing.Size(100, 20)
        Me.TxtGarant.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(236, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Garantía"
        '
        'TxtCasti
        '
        Me.TxtCasti.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTCastigosGarantiasBindingSource, "Castigo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtCasti.Location = New System.Drawing.Point(127, 37)
        Me.TxtCasti.Name = "TxtCasti"
        Me.TxtCasti.Size = New System.Drawing.Size(100, 20)
        Me.TxtCasti.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Castigo"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CONTCastigosGarantiasBindingSource, "Fecha", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(7, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(114, 20)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Fecha"
        '
        'BtAdd
        '
        Me.BtAdd.Location = New System.Drawing.Point(645, 190)
        Me.BtAdd.Name = "BtAdd"
        Me.BtAdd.Size = New System.Drawing.Size(83, 23)
        Me.BtAdd.TabIndex = 15
        Me.BtAdd.Text = "Agregar Datos"
        Me.BtAdd.UseVisualStyleBackColor = True
        '
        'CONT_Castigos_GarantiasTableAdapter
        '
        Me.CONT_Castigos_GarantiasTableAdapter.ClearBeforeFill = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Filtro Anexo"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(19, 33)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 17
        '
        'FrmCastigoGaratia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 224)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCastigoGaratia"
        Me.Text = "Captura Castigos y garantias Ejercidas"
        CType(Me.ClientesConAnexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CONTCastigosGarantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ContaDS As ContaDS
    Friend WithEvents ClientesConAnexoBindingSource As BindingSource
    Friend WithEvents ClientesConAnexoTableAdapter As ContaDSTableAdapters.ClientesConAnexoTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents AnexosClienteBindingSource As BindingSource
    Friend WithEvents AnexosClienteTableAdapter As ContaDSTableAdapters.AnexosClienteTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCasti As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents BtSave As Button
    Friend WithEvents TxtInte As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtPago As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtGarant As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtAdd As Button
    Friend WithEvents CONTCastigosGarantiasBindingSource As BindingSource
    Friend WithEvents CONT_Castigos_GarantiasTableAdapter As ContaDSTableAdapters.CONT_Castigos_GarantiasTableAdapter
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox6 As TextBox
End Class
