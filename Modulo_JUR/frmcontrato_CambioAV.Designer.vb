<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcontrato_CambioAV
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
        Me.cbanexos = New System.Windows.Forms.ComboBox()
        Me.AviosCambiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtCiclo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelCiclo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_fecTerminacion = New System.Windows.Forms.DateTimePicker()
        Me.bt_cambiarfec = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextDif = New System.Windows.Forms.TextBox()
        Me.ButtonDif = New System.Windows.Forms.Button()
        Me.ButtonFondeo = New System.Windows.Forms.Button()
        Me.TextFondeo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AviosCambiosTableAdapter = New Agil.MesaControlDSTableAdapters.AviosCambiosTableAdapter()
        Me.ClientesTableAdapter = New Agil.MesaControlDSTableAdapters.ClientesTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DTp_FechaCont = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosCambiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbclientes
        '
        Me.cbclientes.DataSource = Me.ClientesBindingSource
        Me.cbclientes.DisplayMember = "Descr"
        Me.cbclientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbclientes.FormattingEnabled = True
        Me.cbclientes.Location = New System.Drawing.Point(15, 25)
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
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Selecciona un contrato  de la lista"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Selecciona un cliente de la lista"
        '
        'cbanexos
        '
        Me.cbanexos.DataSource = Me.AviosCambiosBindingSource
        Me.cbanexos.DisplayMember = "AnexoCon"
        Me.cbanexos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbanexos.FormattingEnabled = True
        Me.cbanexos.Location = New System.Drawing.Point(17, 66)
        Me.cbanexos.Name = "cbanexos"
        Me.cbanexos.Size = New System.Drawing.Size(123, 21)
        Me.cbanexos.TabIndex = 40
        Me.cbanexos.ValueMember = "Anexo"
        '
        'AviosCambiosBindingSource
        '
        Me.AviosCambiosBindingSource.DataMember = "AviosCambios"
        Me.AviosCambiosBindingSource.DataSource = Me.MesaControlDS
        '
        'TxtCiclo
        '
        Me.TxtCiclo.Location = New System.Drawing.Point(116, 66)
        Me.TxtCiclo.Name = "TxtCiclo"
        Me.TxtCiclo.ReadOnly = True
        Me.TxtCiclo.Size = New System.Drawing.Size(10, 20)
        Me.TxtCiclo.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 49
        '
        'LabelCiclo
        '
        Me.LabelCiclo.AutoSize = True
        Me.LabelCiclo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AviosCambiosBindingSource, "CicloPagare", True))
        Me.LabelCiclo.Location = New System.Drawing.Point(146, 69)
        Me.LabelCiclo.Name = "LabelCiclo"
        Me.LabelCiclo.Size = New System.Drawing.Size(67, 13)
        Me.LabelCiclo.TabIndex = 51
        Me.LabelCiclo.Text = "Ciclo Pagare"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Nueva Fecha Term."
        '
        'dt_fecTerminacion
        '
        Me.dt_fecTerminacion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AviosCambiosBindingSource, "fechaVEN", True))
        Me.dt_fecTerminacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecTerminacion.Location = New System.Drawing.Point(107, 127)
        Me.dt_fecTerminacion.Name = "dt_fecTerminacion"
        Me.dt_fecTerminacion.Size = New System.Drawing.Size(89, 20)
        Me.dt_fecTerminacion.TabIndex = 53
        '
        'bt_cambiarfec
        '
        Me.bt_cambiarfec.Location = New System.Drawing.Point(201, 125)
        Me.bt_cambiarfec.Name = "bt_cambiarfec"
        Me.bt_cambiarfec.Size = New System.Drawing.Size(153, 23)
        Me.bt_cambiarfec.TabIndex = 54
        Me.bt_cambiarfec.Text = "Cambiar Fecha Terminación"
        Me.bt_cambiarfec.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Diferencial"
        '
        'TextDif
        '
        Me.TextDif.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AviosCambiosBindingSource, "DiffORG", True))
        Me.TextDif.Enabled = False
        Me.TextDif.Location = New System.Drawing.Point(107, 158)
        Me.TextDif.Name = "TextDif"
        Me.TextDif.ReadOnly = True
        Me.TextDif.Size = New System.Drawing.Size(89, 20)
        Me.TextDif.TabIndex = 56
        Me.TextDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonDif
        '
        Me.ButtonDif.Location = New System.Drawing.Point(201, 156)
        Me.ButtonDif.Name = "ButtonDif"
        Me.ButtonDif.Size = New System.Drawing.Size(153, 23)
        Me.ButtonDif.TabIndex = 57
        Me.ButtonDif.Text = "Cambiar Diferencial"
        Me.ButtonDif.UseVisualStyleBackColor = True
        '
        'ButtonFondeo
        '
        Me.ButtonFondeo.Location = New System.Drawing.Point(201, 187)
        Me.ButtonFondeo.Name = "ButtonFondeo"
        Me.ButtonFondeo.Size = New System.Drawing.Size(153, 23)
        Me.ButtonFondeo.TabIndex = 60
        Me.ButtonFondeo.Text = "Cambiar Recursos"
        Me.ButtonFondeo.UseVisualStyleBackColor = True
        '
        'TextFondeo
        '
        Me.TextFondeo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AviosCambiosBindingSource, "Fondeotit", True))
        Me.TextFondeo.Enabled = False
        Me.TextFondeo.Location = New System.Drawing.Point(107, 187)
        Me.TextFondeo.Name = "TextFondeo"
        Me.TextFondeo.ReadOnly = True
        Me.TextFondeo.Size = New System.Drawing.Size(89, 20)
        Me.TextFondeo.TabIndex = 59
        Me.TextFondeo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Recursos"
        '
        'AviosCambiosTableAdapter
        '
        Me.AviosCambiosTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(201, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 23)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Cambiar Fecha Contrato"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DTp_FechaCont
        '
        Me.DTp_FechaCont.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AviosCambiosBindingSource, "fechaCont", True))
        Me.DTp_FechaCont.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTp_FechaCont.Location = New System.Drawing.Point(107, 98)
        Me.DTp_FechaCont.Name = "DTp_FechaCont"
        Me.DTp_FechaCont.Size = New System.Drawing.Size(89, 20)
        Me.DTp_FechaCont.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Nueva Fecha Cont"
        '
        'frmcontrato_CambioAV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 219)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DTp_FechaCont)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonFondeo)
        Me.Controls.Add(Me.TextFondeo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonDif)
        Me.Controls.Add(Me.TextDif)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bt_cambiarfec)
        Me.Controls.Add(Me.dt_fecTerminacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelCiclo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbclientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbanexos)
        Me.Controls.Add(Me.TxtCiclo)
        Me.Name = "frmcontrato_CambioAV"
        Me.Text = "Cambio de Fecha de Contrato AVI"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosCambiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbclientes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbanexos As ComboBox
    Friend WithEvents TxtCiclo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelCiclo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dt_fecTerminacion As DateTimePicker
    Friend WithEvents bt_cambiarfec As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextDif As TextBox
    Friend WithEvents ButtonDif As Button
    Friend WithEvents ButtonFondeo As Button
    Friend WithEvents TextFondeo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents AviosCambiosBindingSource As BindingSource
    Friend WithEvents MesaControlDS As MesaControlDS
    Friend WithEvents AviosCambiosTableAdapter As MesaControlDSTableAdapters.AviosCambiosTableAdapter
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As MesaControlDSTableAdapters.ClientesTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents DTp_FechaCont As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
