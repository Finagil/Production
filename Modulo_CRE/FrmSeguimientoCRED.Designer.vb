<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeguimientoCRED
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
        Me.ProductionDataSet = New Agil.ProductionDataSet()
        Me.ContClie1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContClie1TableAdapter = New Agil.ProductionDataSetTableAdapters.ContClie1TableAdapter()
        Me.Txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.ComboClientes = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.AnexosCREDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditoDS = New Agil.CreditoDS()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbAnexos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AnexosCREDTableAdapter = New Agil.CreditoDSTableAdapters.AnexosCREDTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CREDSeguimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CRED_SeguimientoTableAdapter = New Agil.CreditoDSTableAdapters.CRED_SeguimientoTableAdapter()
        Me.DTPAlta = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTPcompromiso = New System.Windows.Forms.DateTimePicker()
        Me.CmbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtResponsable = New System.Windows.Forms.TextBox()
        Me.TxtNotas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.TxtCompromiso = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosCREDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CREDSeguimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContClie1BindingSource
        '
        Me.ContClie1BindingSource.DataMember = "ContClie1"
        Me.ContClie1BindingSource.DataSource = Me.ProductionDataSet
        '
        'ContClie1TableAdapter
        '
        Me.ContClie1TableAdapter.ClearBeforeFill = True
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
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Filtro"
        '
        'lblClientes
        '
        Me.lblClientes.AutoSize = True
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(16, 51)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(206, 13)
        Me.lblClientes.TabIndex = 61
        Me.lblClientes.Text = "Selecciona un Cliente de la siguiente Lista"
        '
        'ComboClientes
        '
        Me.ComboClientes.DataSource = Me.ContClie1BindingSource
        Me.ComboClientes.DisplayMember = "Descr"
        Me.ComboClientes.Location = New System.Drawing.Point(15, 69)
        Me.ComboClientes.MaxDropDownItems = 25
        Me.ComboClientes.Name = "ComboClientes"
        Me.ComboClientes.Size = New System.Drawing.Size(424, 21)
        Me.ComboClientes.TabIndex = 62
        Me.ComboClientes.ValueMember = "Cliente"
        '
        'Label25
        '
        Me.Label25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosCREDBindingSource, "Flcan", True))
        Me.Label25.Location = New System.Drawing.Point(196, 116)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(21, 13)
        Me.Label25.TabIndex = 68
        Me.Label25.Text = "."
        '
        'AnexosCREDBindingSource
        '
        Me.AnexosCREDBindingSource.DataMember = "AnexosCRED"
        Me.AnexosCREDBindingSource.DataSource = Me.CreditoDS
        '
        'CreditoDS
        '
        Me.CreditoDS.DataSetName = "CreditoDS"
        Me.CreditoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosCREDBindingSource, "TipoCredito", True))
        Me.Label3.Location = New System.Drawing.Point(223, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "."
        '
        'CmbAnexos
        '
        Me.CmbAnexos.DataSource = Me.AnexosCREDBindingSource
        Me.CmbAnexos.DisplayMember = "AnexoCon"
        Me.CmbAnexos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnexos.FormattingEnabled = True
        Me.CmbAnexos.Location = New System.Drawing.Point(15, 113)
        Me.CmbAnexos.Name = "CmbAnexos"
        Me.CmbAnexos.Size = New System.Drawing.Size(170, 21)
        Me.CmbAnexos.TabIndex = 66
        Me.CmbAnexos.ValueMember = "Anexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Anexos"
        '
        'AnexosCREDTableAdapter
        '
        Me.AnexosCREDTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.CREDSeguimientoBindingSource
        Me.ComboBox2.DisplayMember = "Fecha_Alta"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(15, 155)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(170, 21)
        Me.ComboBox2.TabIndex = 70
        Me.ComboBox2.ValueMember = "id_Seguimiento"
        '
        'CREDSeguimientoBindingSource
        '
        Me.CREDSeguimientoBindingSource.DataMember = "CRED_Seguimiento"
        Me.CREDSeguimientoBindingSource.DataSource = Me.CreditoDS
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Compromisos"
        '
        'CRED_SeguimientoTableAdapter
        '
        Me.CRED_SeguimientoTableAdapter.ClearBeforeFill = True
        '
        'DTPAlta
        '
        Me.DTPAlta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CREDSeguimientoBindingSource, "Fecha_Alta", True))
        Me.DTPAlta.Enabled = False
        Me.DTPAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPAlta.Location = New System.Drawing.Point(15, 201)
        Me.DTPAlta.Name = "DTPAlta"
        Me.DTPAlta.Size = New System.Drawing.Size(118, 20)
        Me.DTPAlta.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Fecha Alta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Fecha Compromiso"
        '
        'DTPcompromiso
        '
        Me.DTPcompromiso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CREDSeguimientoBindingSource, "Fecha_Compromiso", True))
        Me.DTPcompromiso.DataBindings.Add(New System.Windows.Forms.Binding("MinDate", Me.CREDSeguimientoBindingSource, "Fecha_Alta", True))
        Me.DTPcompromiso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPcompromiso.Location = New System.Drawing.Point(139, 201)
        Me.DTPcompromiso.Name = "DTPcompromiso"
        Me.DTPcompromiso.Size = New System.Drawing.Size(118, 20)
        Me.DTPcompromiso.TabIndex = 73
        '
        'CmbEstatus
        '
        Me.CmbEstatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "Estatus", True))
        Me.CmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEstatus.FormattingEnabled = True
        Me.CmbEstatus.Items.AddRange(New Object() {"Pendiente", "Cancelado", "Terminado"})
        Me.CmbEstatus.Location = New System.Drawing.Point(269, 201)
        Me.CmbEstatus.Name = "CmbEstatus"
        Me.CmbEstatus.Size = New System.Drawing.Size(122, 21)
        Me.CmbEstatus.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(270, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Estatus"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Responsable"
        '
        'TxtResponsable
        '
        Me.TxtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtResponsable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "Responsable", True))
        Me.TxtResponsable.Location = New System.Drawing.Point(15, 241)
        Me.TxtResponsable.MaxLength = 50
        Me.TxtResponsable.Name = "TxtResponsable"
        Me.TxtResponsable.Size = New System.Drawing.Size(424, 20)
        Me.TxtResponsable.TabIndex = 78
        '
        'TxtNotas
        '
        Me.TxtNotas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "Notas", True))
        Me.TxtNotas.Location = New System.Drawing.Point(15, 324)
        Me.TxtNotas.MaxLength = 300
        Me.TxtNotas.Multiline = True
        Me.TxtNotas.Name = "TxtNotas"
        Me.TxtNotas.Size = New System.Drawing.Size(424, 164)
        Me.TxtNotas.TabIndex = 80
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Notas"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(202, 494)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 81
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(283, 494)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(75, 23)
        Me.BtnNew.TabIndex = 82
        Me.BtnNew.Text = "Nuevo"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'TxtCompromiso
        '
        Me.TxtCompromiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCompromiso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSeguimientoBindingSource, "Compromiso", True))
        Me.TxtCompromiso.Location = New System.Drawing.Point(15, 284)
        Me.TxtCompromiso.MaxLength = 50
        Me.TxtCompromiso.Name = "TxtCompromiso"
        Me.TxtCompromiso.Size = New System.Drawing.Size(424, 20)
        Me.TxtCompromiso.TabIndex = 79
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Compromiso"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(364, 494)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 84
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FrmSeguimientoCRED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 525)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtCompromiso)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtNotas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtResponsable)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbEstatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DTPcompromiso)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTPAlta)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbAnexos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtfiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.ComboClientes)
        Me.Name = "FrmSeguimientoCRED"
        Me.Text = "Seguimiento de Pendientes"
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosCREDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CREDSeguimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents ContClie1BindingSource As BindingSource
    Friend WithEvents ContClie1TableAdapter As ProductionDataSetTableAdapters.ContClie1TableAdapter
    Friend WithEvents Txtfiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClientes As Label
    Friend WithEvents ComboClientes As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbAnexos As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AnexosCREDBindingSource As BindingSource
    Friend WithEvents CreditoDS As CreditoDS
    Friend WithEvents AnexosCREDTableAdapter As CreditoDSTableAdapters.AnexosCREDTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CREDSeguimientoBindingSource As BindingSource
    Friend WithEvents CRED_SeguimientoTableAdapter As CreditoDSTableAdapters.CRED_SeguimientoTableAdapter
    Friend WithEvents DTPAlta As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DTPcompromiso As DateTimePicker
    Friend WithEvents CmbEstatus As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtResponsable As TextBox
    Friend WithEvents TxtNotas As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents TxtCompromiso As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnCancel As Button
End Class
