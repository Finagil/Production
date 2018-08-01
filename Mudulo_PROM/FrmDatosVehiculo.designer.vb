<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatosVehiculo
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS1 = New Agil.PromocionDS()
        Me.TxtSubmarca = New System.Windows.Forms.TextBox()
        Me.Txtversion = New System.Windows.Forms.TextBox()
        Me.Txtcolor = New System.Windows.Forms.TextBox()
        Me.Txtmodelo = New System.Windows.Forms.TextBox()
        Me.TxtNoVehic = New System.Windows.Forms.TextBox()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.TxtMotor = New System.Windows.Forms.TextBox()
        Me.TxtCapacidad = New System.Windows.Forms.TextBox()
        Me.BttSafe = New System.Windows.Forms.Button()
        Me.TxtDatosadd = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtPlacas = New System.Windows.Forms.TextBox()
        Me.TxtLugarEnt = New System.Windows.Forms.TextBox()
        Me.TxtPersona = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtFechaEntrega = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtProvee = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.VehiculosTableAdapter = New Agil.PromocionDSTableAdapters.VehiculosTableAdapter()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CmbNivel = New System.Windows.Forms.ComboBox()
        Me.NivelesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NivelesTableAdapter = New Agil.PromocionDSTableAdapters.NivelesTableAdapter()
        Me.TxtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NivelesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SubMarca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Versión"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(484, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Color"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Modelo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "No de Identificación Vehicular"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(227, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Serie"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(383, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Motor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Capacidad"
        '
        'TxtMarca
        '
        Me.TxtMarca.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Marca", True))
        Me.TxtMarca.Location = New System.Drawing.Point(14, 70)
        Me.TxtMarca.MaxLength = 20
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(150, 20)
        Me.TxtMarca.TabIndex = 11
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Vehiculos"
        Me.BindingSource1.DataSource = Me.PromocionDS1
        '
        'PromocionDS1
        '
        Me.PromocionDS1.DataSetName = "PromocionDS"
        Me.PromocionDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtSubmarca
        '
        Me.TxtSubmarca.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "SubMarca", True))
        Me.TxtSubmarca.Location = New System.Drawing.Point(172, 70)
        Me.TxtSubmarca.MaxLength = 20
        Me.TxtSubmarca.Name = "TxtSubmarca"
        Me.TxtSubmarca.Size = New System.Drawing.Size(150, 20)
        Me.TxtSubmarca.TabIndex = 12
        '
        'Txtversion
        '
        Me.Txtversion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Version", True))
        Me.Txtversion.Location = New System.Drawing.Point(328, 70)
        Me.Txtversion.MaxLength = 20
        Me.Txtversion.Name = "Txtversion"
        Me.Txtversion.Size = New System.Drawing.Size(150, 20)
        Me.Txtversion.TabIndex = 13
        '
        'Txtcolor
        '
        Me.Txtcolor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Color", True))
        Me.Txtcolor.Location = New System.Drawing.Point(484, 70)
        Me.Txtcolor.MaxLength = 20
        Me.Txtcolor.Name = "Txtcolor"
        Me.Txtcolor.Size = New System.Drawing.Size(150, 20)
        Me.Txtcolor.TabIndex = 14
        '
        'Txtmodelo
        '
        Me.Txtmodelo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Modelo", True))
        Me.Txtmodelo.Location = New System.Drawing.Point(14, 109)
        Me.Txtmodelo.MaxLength = 4
        Me.Txtmodelo.Name = "Txtmodelo"
        Me.Txtmodelo.Size = New System.Drawing.Size(50, 20)
        Me.Txtmodelo.TabIndex = 15
        '
        'TxtNoVehic
        '
        Me.TxtNoVehic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "NoIdentificacionVehic", True))
        Me.TxtNoVehic.Location = New System.Drawing.Point(71, 109)
        Me.TxtNoVehic.MaxLength = 20
        Me.TxtNoVehic.Name = "TxtNoVehic"
        Me.TxtNoVehic.Size = New System.Drawing.Size(150, 20)
        Me.TxtNoVehic.TabIndex = 16
        '
        'TxtSerie
        '
        Me.TxtSerie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Serie", True))
        Me.TxtSerie.Location = New System.Drawing.Point(227, 109)
        Me.TxtSerie.MaxLength = 20
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(150, 20)
        Me.TxtSerie.TabIndex = 17
        '
        'TxtMotor
        '
        Me.TxtMotor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Motor", True))
        Me.TxtMotor.Location = New System.Drawing.Point(383, 109)
        Me.TxtMotor.MaxLength = 20
        Me.TxtMotor.Name = "TxtMotor"
        Me.TxtMotor.Size = New System.Drawing.Size(150, 20)
        Me.TxtMotor.TabIndex = 18
        '
        'TxtCapacidad
        '
        Me.TxtCapacidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Capacidad", True))
        Me.TxtCapacidad.Location = New System.Drawing.Point(14, 148)
        Me.TxtCapacidad.MaxLength = 30
        Me.TxtCapacidad.Name = "TxtCapacidad"
        Me.TxtCapacidad.Size = New System.Drawing.Size(250, 20)
        Me.TxtCapacidad.TabIndex = 19
        '
        'BttSafe
        '
        Me.BttSafe.Location = New System.Drawing.Point(14, 480)
        Me.BttSafe.Name = "BttSafe"
        Me.BttSafe.Size = New System.Drawing.Size(75, 23)
        Me.BttSafe.TabIndex = 27
        Me.BttSafe.Text = "Guardar"
        Me.BttSafe.UseVisualStyleBackColor = True
        '
        'TxtDatosadd
        '
        Me.TxtDatosadd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "DatosAdicionales", True))
        Me.TxtDatosadd.Location = New System.Drawing.Point(14, 346)
        Me.TxtDatosadd.MaxLength = 200
        Me.TxtDatosadd.Multiline = True
        Me.TxtDatosadd.Name = "TxtDatosadd"
        Me.TxtDatosadd.Size = New System.Drawing.Size(618, 47)
        Me.TxtDatosadd.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(272, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Placas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 329)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Datos Adicionales"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 175)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Lugar de Entrega"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 212)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Fecha de Entrega"
        '
        'TxtPlacas
        '
        Me.TxtPlacas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Placas", True))
        Me.TxtPlacas.Location = New System.Drawing.Point(272, 148)
        Me.TxtPlacas.MaxLength = 10
        Me.TxtPlacas.Name = "TxtPlacas"
        Me.TxtPlacas.Size = New System.Drawing.Size(105, 20)
        Me.TxtPlacas.TabIndex = 20
        '
        'TxtLugarEnt
        '
        Me.TxtLugarEnt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "LugarEntrega", True))
        Me.TxtLugarEnt.Location = New System.Drawing.Point(14, 191)
        Me.TxtLugarEnt.MaxLength = 100
        Me.TxtLugarEnt.Name = "TxtLugarEnt"
        Me.TxtLugarEnt.Size = New System.Drawing.Size(361, 20)
        Me.TxtLugarEnt.TabIndex = 21
        '
        'TxtPersona
        '
        Me.TxtPersona.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Persona", True))
        Me.TxtPersona.Location = New System.Drawing.Point(14, 266)
        Me.TxtPersona.MaxLength = 100
        Me.TxtPersona.Name = "TxtPersona"
        Me.TxtPersona.Size = New System.Drawing.Size(361, 20)
        Me.TxtPersona.TabIndex = 23
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 250)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Persona a quien se Entrega"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 291)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(187, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Correo de Persona a quien se Entrega"
        '
        'TxtFechaEntrega
        '
        Me.TxtFechaEntrega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "FechaEntrega", True))
        Me.TxtFechaEntrega.Location = New System.Drawing.Point(14, 227)
        Me.TxtFechaEntrega.Mask = "00/00/0000"
        Me.TxtFechaEntrega.Name = "TxtFechaEntrega"
        Me.TxtFechaEntrega.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaEntrega.TabIndex = 22
        Me.TxtFechaEntrega.ValidatingType = GetType(Date)
        '
        'TxtCorreo
        '
        Me.TxtCorreo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Correo", True))
        Me.TxtCorreo.Location = New System.Drawing.Point(14, 307)
        Me.TxtCorreo.MaxLength = 100
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(361, 20)
        Me.TxtCorreo.TabIndex = 24
        '
        'TxtProvee
        '
        Me.TxtProvee.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Proveedor", True))
        Me.TxtProvee.Location = New System.Drawing.Point(14, 412)
        Me.TxtProvee.MaxLength = 100
        Me.TxtProvee.Name = "TxtProvee"
        Me.TxtProvee.Size = New System.Drawing.Size(361, 20)
        Me.TxtProvee.TabIndex = 26
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 396)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Proveedor"
        '
        'VehiculosTableAdapter
        '
        Me.VehiculosTableAdapter.ClearBeforeFill = True
        '
        'TxtCosto
        '
        Me.TxtCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CostoUnidad", True))
        Me.TxtCosto.Location = New System.Drawing.Point(14, 454)
        Me.TxtCosto.MaxLength = 20
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(150, 20)
        Me.TxtCosto.TabIndex = 35
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 438)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 13)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Costo del Vehículo"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(171, 439)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 13)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Nivel de Empleado"
        '
        'CmbNivel
        '
        Me.CmbNivel.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BindingSource1, "Nivel", True))
        Me.CmbNivel.DataSource = Me.NivelesBindingSource
        Me.CmbNivel.DisplayMember = "Nivel"
        Me.CmbNivel.FormattingEnabled = True
        Me.CmbNivel.Location = New System.Drawing.Point(174, 455)
        Me.CmbNivel.Name = "CmbNivel"
        Me.CmbNivel.Size = New System.Drawing.Size(280, 21)
        Me.CmbNivel.TabIndex = 37
        Me.CmbNivel.ValueMember = "id_nivel"
        '
        'NivelesBindingSource
        '
        Me.NivelesBindingSource.DataMember = "Niveles"
        Me.NivelesBindingSource.DataSource = Me.PromocionDS1
        '
        'NivelesTableAdapter
        '
        Me.NivelesTableAdapter.ClearBeforeFill = True
        '
        'TxtTipoCambio
        '
        Me.TxtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "TipoCambio", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtTipoCambio.Location = New System.Drawing.Point(460, 455)
        Me.TxtTipoCambio.MaxLength = 20
        Me.TxtTipoCambio.Name = "TxtTipoCambio"
        Me.TxtTipoCambio.Size = New System.Drawing.Size(79, 20)
        Me.TxtTipoCambio.TabIndex = 39
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(458, 439)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 13)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Tipo de Cambio"
        '
        'FrmDatosVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 551)
        Me.Controls.Add(Me.TxtTipoCambio)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.CmbNivel)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TxtProvee)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtFechaEntrega)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtPersona)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtLugarEnt)
        Me.Controls.Add(Me.TxtPlacas)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtDatosadd)
        Me.Controls.Add(Me.BttSafe)
        Me.Controls.Add(Me.TxtCapacidad)
        Me.Controls.Add(Me.TxtMotor)
        Me.Controls.Add(Me.TxtSerie)
        Me.Controls.Add(Me.TxtNoVehic)
        Me.Controls.Add(Me.Txtmodelo)
        Me.Controls.Add(Me.Txtcolor)
        Me.Controls.Add(Me.Txtversion)
        Me.Controls.Add(Me.TxtSubmarca)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDatosVehiculo"
        Me.Text = "Datos Vehículo"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NivelesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents TxtSubmarca As TextBox
    Friend WithEvents Txtversion As TextBox
    Friend WithEvents Txtcolor As TextBox
    Friend WithEvents Txtmodelo As TextBox
    Friend WithEvents TxtNoVehic As TextBox
    Friend WithEvents TxtSerie As TextBox
    Friend WithEvents TxtMotor As TextBox
    Friend WithEvents TxtCapacidad As TextBox
    Friend WithEvents BttSafe As Button
    Friend WithEvents TxtDatosadd As TextBox
    Friend WithEvents PromocionDS1 As PromocionDS
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents VehiculosTableAdapter As PromocionDSTableAdapters.VehiculosTableAdapter
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtPlacas As TextBox
    Friend WithEvents TxtLugarEnt As TextBox
    Friend WithEvents TxtPersona As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtFechaEntrega As MaskedTextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtProvee As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents CmbNivel As ComboBox
    Friend WithEvents NivelesBindingSource As BindingSource
    Friend WithEvents NivelesTableAdapter As PromocionDSTableAdapters.NivelesTableAdapter
    Friend WithEvents TxtTipoCambio As TextBox
    Friend WithEvents Label21 As Label
End Class
