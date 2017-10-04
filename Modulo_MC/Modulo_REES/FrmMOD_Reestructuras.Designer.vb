<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMOD_Reestructuras
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
        Me.Txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.ComboCli = New System.Windows.Forms.ComboBox()
        Me.ClientesConAdeudoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReestructDS = New Agil.ReestructDS()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboAnexo = New System.Windows.Forms.ComboBox()
        Me.AnexosConAdeudoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPlazoTrans = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTipoTasa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AnexosTableAdapter = New Agil.ReestructDSTableAdapters.AnexosTableAdapter()
        Me.TxtEstatus = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDif = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ClientesConAdeudoTableAdapter = New Agil.ReestructDSTableAdapters.ClientesConAdeudoTableAdapter()
        Me.AnexosConAdeudoTableAdapter = New Agil.ReestructDSTableAdapters.AnexosConAdeudoTableAdapter()
        Me.TxtMontoFin = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtSaldoInsol = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtSaldoFact = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBTasaMENOS = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RBGracia = New System.Windows.Forms.RadioButton()
        Me.RBAsociar = New System.Windows.Forms.RadioButton()
        Me.RBOtros = New System.Windows.Forms.RadioButton()
        Me.RBPlazo = New System.Windows.Forms.RadioButton()
        Me.RBTasaMAS = New System.Windows.Forms.RadioButton()
        Me.TxtSaldoAV = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.ClientesConAdeudoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReestructDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosConAdeudoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtfiltro
        '
        Me.Txtfiltro.Location = New System.Drawing.Point(15, 28)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(424, 20)
        Me.Txtfiltro.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 16)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Filtro"
        '
        'lblClientes
        '
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(16, 51)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(432, 16)
        Me.lblClientes.TabIndex = 61
        Me.lblClientes.Text = "Selecciona un Cliente de la siguiente Lista"
        '
        'ComboCli
        '
        Me.ComboCli.DataSource = Me.ClientesConAdeudoBindingSource
        Me.ComboCli.DisplayMember = "Descr"
        Me.ComboCli.Location = New System.Drawing.Point(15, 69)
        Me.ComboCli.MaxDropDownItems = 25
        Me.ComboCli.Name = "ComboCli"
        Me.ComboCli.Size = New System.Drawing.Size(424, 21)
        Me.ComboCli.TabIndex = 62
        Me.ComboCli.ValueMember = "Cliente"
        '
        'ClientesConAdeudoBindingSource
        '
        Me.ClientesConAdeudoBindingSource.DataMember = "ClientesConAdeudo"
        Me.ClientesConAdeudoBindingSource.DataSource = Me.ReestructDS
        '
        'ReestructDS
        '
        Me.ReestructDS.DataSetName = "ReestructDS"
        Me.ReestructDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Contrato"
        '
        'ComboAnexo
        '
        Me.ComboAnexo.DataSource = Me.AnexosConAdeudoBindingSource
        Me.ComboAnexo.DisplayMember = "Titulo"
        Me.ComboAnexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboAnexo.Location = New System.Drawing.Point(15, 111)
        Me.ComboAnexo.MaxDropDownItems = 25
        Me.ComboAnexo.Name = "ComboAnexo"
        Me.ComboAnexo.Size = New System.Drawing.Size(187, 21)
        Me.ComboAnexo.TabIndex = 65
        Me.ComboAnexo.ValueMember = "Anexo"
        '
        'AnexosConAdeudoBindingSource
        '
        Me.AnexosConAdeudoBindingSource.DataMember = "AnexosConAdeudo"
        Me.AnexosConAdeudoBindingSource.DataSource = Me.ReestructDS
        '
        'AnexosBindingSource
        '
        Me.AnexosBindingSource.DataMember = "Anexos"
        Me.AnexosBindingSource.DataSource = Me.ReestructDS
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "TipoCredito", True))
        Me.TextBox1.Location = New System.Drawing.Point(15, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(187, 20)
        Me.TextBox1.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Tipo Crédito"
        '
        'TxtPlazoTrans
        '
        Me.TxtPlazoTrans.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "Transcurrido", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtPlazoTrans.Location = New System.Drawing.Point(208, 158)
        Me.TxtPlazoTrans.Name = "TxtPlazoTrans"
        Me.TxtPlazoTrans.ReadOnly = True
        Me.TxtPlazoTrans.Size = New System.Drawing.Size(95, 20)
        Me.TxtPlazoTrans.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(205, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "% Plazo Trancurido"
        '
        'TxtTipoTasa
        '
        Me.TxtTipoTasa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "TipoTasa", True))
        Me.TxtTipoTasa.Location = New System.Drawing.Point(159, 200)
        Me.TxtTipoTasa.Name = "TxtTipoTasa"
        Me.TxtTipoTasa.ReadOnly = True
        Me.TxtTipoTasa.Size = New System.Drawing.Size(70, 20)
        Me.TxtTipoTasa.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(156, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Tipo Tasa"
        '
        'TxtTasa
        '
        Me.TxtTasa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "TasaOrg", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N4"))
        Me.TxtTasa.Location = New System.Drawing.Point(15, 200)
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.ReadOnly = True
        Me.TxtTasa.Size = New System.Drawing.Size(68, 20)
        Me.TxtTasa.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Tasa"
        '
        'AnexosTableAdapter
        '
        Me.AnexosTableAdapter.ClearBeforeFill = True
        '
        'TxtEstatus
        '
        Me.TxtEstatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "EstatusContable", True))
        Me.TxtEstatus.Location = New System.Drawing.Point(310, 158)
        Me.TxtEstatus.Name = "TxtEstatus"
        Me.TxtEstatus.ReadOnly = True
        Me.TxtEstatus.Size = New System.Drawing.Size(84, 20)
        Me.TxtEstatus.TabIndex = 76
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(307, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Estatus Contable"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "Reestructura", True))
        Me.TextBox7.Location = New System.Drawing.Point(400, 158)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(70, 20)
        Me.TextBox7.TabIndex = 78
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(397, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Reestructura"
        '
        'TxtDif
        '
        Me.TxtDif.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "DiffORG", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N4"))
        Me.TxtDif.Location = New System.Drawing.Point(89, 200)
        Me.TxtDif.Name = "TxtDif"
        Me.TxtDif.ReadOnly = True
        Me.TxtDif.Size = New System.Drawing.Size(64, 20)
        Me.TxtDif.TabIndex = 83
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(86, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Diff."
        '
        'ClientesConAdeudoTableAdapter
        '
        Me.ClientesConAdeudoTableAdapter.ClearBeforeFill = True
        '
        'AnexosConAdeudoTableAdapter
        '
        Me.AnexosConAdeudoTableAdapter.ClearBeforeFill = True
        '
        'TxtMontoFin
        '
        Me.TxtMontoFin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "MontoFinanciado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtMontoFin.Location = New System.Drawing.Point(15, 245)
        Me.TxtMontoFin.Name = "TxtMontoFin"
        Me.TxtMontoFin.ReadOnly = True
        Me.TxtMontoFin.Size = New System.Drawing.Size(84, 20)
        Me.TxtMontoFin.TabIndex = 85
        Me.TxtMontoFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 226)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Monto Finan."
        '
        'TxtSaldoInsol
        '
        Me.TxtSaldoInsol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "SaldoInsoluto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtSaldoInsol.Location = New System.Drawing.Point(105, 245)
        Me.TxtSaldoInsol.Name = "TxtSaldoInsol"
        Me.TxtSaldoInsol.ReadOnly = True
        Me.TxtSaldoInsol.Size = New System.Drawing.Size(84, 20)
        Me.TxtSaldoInsol.TabIndex = 87
        Me.TxtSaldoInsol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(102, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "Saldo Insoluto"
        '
        'TxtSaldoFact
        '
        Me.TxtSaldoFact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "SaldoFac", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtSaldoFact.Location = New System.Drawing.Point(195, 245)
        Me.TxtSaldoFact.Name = "TxtSaldoFact"
        Me.TxtSaldoFact.ReadOnly = True
        Me.TxtSaldoFact.Size = New System.Drawing.Size(84, 20)
        Me.TxtSaldoFact.TabIndex = 89
        Me.TxtSaldoFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(192, 226)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "Saldo Facturas."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBTasaMENOS)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.RBGracia)
        Me.GroupBox1.Controls.Add(Me.RBAsociar)
        Me.GroupBox1.Controls.Add(Me.RBOtros)
        Me.GroupBox1.Controls.Add(Me.RBPlazo)
        Me.GroupBox1.Controls.Add(Me.RBTasaMAS)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 140)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Reestructura"
        '
        'RBTasaMENOS
        '
        Me.RBTasaMENOS.AutoSize = True
        Me.RBTasaMENOS.Location = New System.Drawing.Point(9, 41)
        Me.RBTasaMENOS.Name = "RBTasaMENOS"
        Me.RBTasaMENOS.Size = New System.Drawing.Size(95, 17)
        Me.RBTasaMENOS.TabIndex = 1
        Me.RBTasaMENOS.TabStop = True
        Me.RBTasaMENOS.Text = "Cambio tasa (-)"
        Me.RBTasaMENOS.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(325, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Genera Reestructura"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RBGracia
        '
        Me.RBGracia.AutoSize = True
        Me.RBGracia.Location = New System.Drawing.Point(9, 87)
        Me.RBGracia.Name = "RBGracia"
        Me.RBGracia.Size = New System.Drawing.Size(110, 17)
        Me.RBGracia.TabIndex = 3
        Me.RBGracia.TabStop = True
        Me.RBGracia.Text = "Periodo de Gracia"
        Me.RBGracia.UseVisualStyleBackColor = True
        '
        'RBAsociar
        '
        Me.RBAsociar.AutoSize = True
        Me.RBAsociar.Location = New System.Drawing.Point(160, 18)
        Me.RBAsociar.Name = "RBAsociar"
        Me.RBAsociar.Size = New System.Drawing.Size(128, 17)
        Me.RBAsociar.TabIndex = 5
        Me.RBAsociar.TabStop = True
        Me.RBAsociar.Text = "Asociar Anexo Nuevo"
        Me.RBAsociar.UseVisualStyleBackColor = True
        '
        'RBOtros
        '
        Me.RBOtros.AutoSize = True
        Me.RBOtros.Location = New System.Drawing.Point(9, 110)
        Me.RBOtros.Name = "RBOtros"
        Me.RBOtros.Size = New System.Drawing.Size(141, 17)
        Me.RBOtros.TabIndex = 4
        Me.RBOtros.TabStop = True
        Me.RBOtros.Text = "Agregar Adeudos (Otros)"
        Me.RBOtros.UseVisualStyleBackColor = True
        '
        'RBPlazo
        '
        Me.RBPlazo.AutoSize = True
        Me.RBPlazo.Location = New System.Drawing.Point(9, 64)
        Me.RBPlazo.Name = "RBPlazo"
        Me.RBPlazo.Size = New System.Drawing.Size(89, 17)
        Me.RBPlazo.TabIndex = 2
        Me.RBPlazo.TabStop = True
        Me.RBPlazo.Text = "Cambio Plazo"
        Me.RBPlazo.UseVisualStyleBackColor = True
        '
        'RBTasaMAS
        '
        Me.RBTasaMAS.AutoSize = True
        Me.RBTasaMAS.Location = New System.Drawing.Point(9, 18)
        Me.RBTasaMAS.Name = "RBTasaMAS"
        Me.RBTasaMAS.Size = New System.Drawing.Size(98, 17)
        Me.RBTasaMAS.TabIndex = 0
        Me.RBTasaMAS.TabStop = True
        Me.RBTasaMAS.Text = "Cambio tasa (+)"
        Me.RBTasaMAS.UseVisualStyleBackColor = True
        '
        'TxtSaldoAV
        '
        Me.TxtSaldoAV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "SaldoAvio", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtSaldoAV.Location = New System.Drawing.Point(285, 245)
        Me.TxtSaldoAV.Name = "TxtSaldoAV"
        Me.TxtSaldoAV.ReadOnly = True
        Me.TxtSaldoAV.Size = New System.Drawing.Size(84, 20)
        Me.TxtSaldoAV.TabIndex = 92
        Me.TxtSaldoAV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(282, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Saldo Avio."
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "FechaTerminacionAV", True))
        Me.TextBox2.Location = New System.Drawing.Point(375, 245)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(84, 20)
        Me.TextBox2.TabIndex = 94
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(372, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Fecha Venc. AV."
        '
        'FrmMOD_Reestructuras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 434)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtSaldoAV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtSaldoFact)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtSaldoInsol)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtMontoFin)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtDif)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtEstatus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTasa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTipoTasa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPlazoTrans)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboAnexo)
        Me.Controls.Add(Me.Txtfiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.ComboCli)
        Me.Name = "FrmMOD_Reestructuras"
        Me.Text = "Reestructura por Cambio de Tasa"
        CType(Me.ClientesConAdeudoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReestructDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosConAdeudoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtfiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClientes As Label
    Friend WithEvents ComboCli As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboAnexo As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPlazoTrans As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTipoTasa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTasa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AnexosBindingSource As BindingSource
    Friend WithEvents ReestructDS As ReestructDS
    Friend WithEvents AnexosTableAdapter As ReestructDSTableAdapters.AnexosTableAdapter
    Friend WithEvents TxtEstatus As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDif As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ClientesConAdeudoBindingSource As BindingSource
    Friend WithEvents ClientesConAdeudoTableAdapter As ReestructDSTableAdapters.ClientesConAdeudoTableAdapter
    Friend WithEvents AnexosConAdeudoBindingSource As BindingSource
    Friend WithEvents AnexosConAdeudoTableAdapter As ReestructDSTableAdapters.AnexosConAdeudoTableAdapter
    Friend WithEvents TxtMontoFin As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtSaldoInsol As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtSaldoFact As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RBGracia As RadioButton
    Friend WithEvents RBAsociar As RadioButton
    Friend WithEvents RBOtros As RadioButton
    Friend WithEvents RBPlazo As RadioButton
    Friend WithEvents RBTasaMAS As RadioButton
    Friend WithEvents TxtSaldoAV As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RBTasaMENOS As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
End Class
