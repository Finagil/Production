<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsociarNew
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
        Me.AnexosSinActivarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReestructDS = New Agil.ReestructDS()
        Me.AnexosSinActivarTableAdapter = New Agil.ReestructDSTableAdapters.AnexosSinActivarTableAdapter()
        Me.AnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexosTableAdapter = New Agil.ReestructDSTableAdapters.AnexosTableAdapter()
        Me.TxtSaldoInsol = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtMontoFin = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtDif = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtEstatus = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.TxtTipoTasa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPlazoTrans = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnAsociar = New System.Windows.Forms.Button()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.AnexosSinActivarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReestructDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Anexo"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.AnexosSinActivarBindingSource
        Me.ComboBox1.DisplayMember = "AnexoCon"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(13, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(188, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "Anexo"
        '
        'AnexosSinActivarBindingSource
        '
        Me.AnexosSinActivarBindingSource.DataMember = "AnexosSinActivar"
        Me.AnexosSinActivarBindingSource.DataSource = Me.ReestructDS
        '
        'ReestructDS
        '
        Me.ReestructDS.DataSetName = "ReestructDS"
        Me.ReestructDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnexosSinActivarTableAdapter
        '
        Me.AnexosSinActivarTableAdapter.ClearBeforeFill = True
        '
        'AnexosBindingSource
        '
        Me.AnexosBindingSource.DataMember = "Anexos"
        Me.AnexosBindingSource.DataSource = Me.ReestructDS
        '
        'AnexosTableAdapter
        '
        Me.AnexosTableAdapter.ClearBeforeFill = True
        '
        'TxtSaldoInsol
        '
        Me.TxtSaldoInsol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "SaldoInsoluto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtSaldoInsol.Location = New System.Drawing.Point(324, 115)
        Me.TxtSaldoInsol.Name = "TxtSaldoInsol"
        Me.TxtSaldoInsol.ReadOnly = True
        Me.TxtSaldoInsol.Size = New System.Drawing.Size(84, 20)
        Me.TxtSaldoInsol.TabIndex = 112
        Me.TxtSaldoInsol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(321, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "Saldo Insoluto"
        '
        'TxtMontoFin
        '
        Me.TxtMontoFin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "MontoFinanciado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtMontoFin.Location = New System.Drawing.Point(234, 115)
        Me.TxtMontoFin.Name = "TxtMontoFin"
        Me.TxtMontoFin.ReadOnly = True
        Me.TxtMontoFin.Size = New System.Drawing.Size(84, 20)
        Me.TxtMontoFin.TabIndex = 110
        Me.TxtMontoFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(231, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = "Monto Finan."
        '
        'TxtDif
        '
        Me.TxtDif.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "DiffORG", True))
        Me.TxtDif.Location = New System.Drawing.Point(86, 115)
        Me.TxtDif.Name = "TxtDif"
        Me.TxtDif.ReadOnly = True
        Me.TxtDif.Size = New System.Drawing.Size(64, 20)
        Me.TxtDif.TabIndex = 108
        Me.TxtDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(83, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 109
        Me.Label11.Text = "Diff."
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "Reestructura", True))
        Me.TextBox7.Location = New System.Drawing.Point(397, 73)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(70, 20)
        Me.TextBox7.TabIndex = 106
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(394, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Reestructura"
        '
        'TxtEstatus
        '
        Me.TxtEstatus.Location = New System.Drawing.Point(307, 73)
        Me.TxtEstatus.Name = "TxtEstatus"
        Me.TxtEstatus.ReadOnly = True
        Me.TxtEstatus.Size = New System.Drawing.Size(84, 20)
        Me.TxtEstatus.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(304, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Estatus Contable"
        '
        'TxtTasa
        '
        Me.TxtTasa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "TasaOrg", True))
        Me.TxtTasa.Location = New System.Drawing.Point(12, 115)
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.ReadOnly = True
        Me.TxtTasa.Size = New System.Drawing.Size(68, 20)
        Me.TxtTasa.TabIndex = 103
        Me.TxtTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTipoTasa
        '
        Me.TxtTipoTasa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "TipoTasa", True))
        Me.TxtTipoTasa.Location = New System.Drawing.Point(156, 115)
        Me.TxtTipoTasa.Name = "TxtTipoTasa"
        Me.TxtTipoTasa.ReadOnly = True
        Me.TxtTipoTasa.Size = New System.Drawing.Size(70, 20)
        Me.TxtTipoTasa.TabIndex = 101
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(153, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Tipo Tasa"
        '
        'TxtPlazoTrans
        '
        Me.TxtPlazoTrans.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "Transcurrido", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N4"))
        Me.TxtPlazoTrans.Location = New System.Drawing.Point(205, 73)
        Me.TxtPlazoTrans.Name = "TxtPlazoTrans"
        Me.TxtPlazoTrans.ReadOnly = True
        Me.TxtPlazoTrans.Size = New System.Drawing.Size(95, 20)
        Me.TxtPlazoTrans.TabIndex = 99
        Me.TxtPlazoTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(202, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "% Plazo Trancurido"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "TipoCredito", True))
        Me.TextBox1.Location = New System.Drawing.Point(12, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(187, 20)
        Me.TextBox1.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Tipo Crédito"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Tasa"
        '
        'BtnAsociar
        '
        Me.BtnAsociar.Location = New System.Drawing.Point(333, 143)
        Me.BtnAsociar.Name = "BtnAsociar"
        Me.BtnAsociar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAsociar.TabIndex = 115
        Me.BtnAsociar.Text = "Asociar"
        Me.BtnAsociar.UseVisualStyleBackColor = True
        '
        'DTP1
        '
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(221, 144)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(97, 20)
        Me.DTP1.TabIndex = 116
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(122, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Fecha Activacion "
        '
        'FrmAsociarNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 174)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.BtnAsociar)
        Me.Controls.Add(Me.Label6)
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
        Me.Controls.Add(Me.TxtTipoTasa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPlazoTrans)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsociarNew"
        Me.Text = "Asociar nuevo contrato para Reestructura"
        CType(Me.AnexosSinActivarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReestructDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AnexosSinActivarBindingSource As BindingSource
    Friend WithEvents ReestructDS As ReestructDS
    Friend WithEvents AnexosSinActivarTableAdapter As ReestructDSTableAdapters.AnexosSinActivarTableAdapter
    Friend WithEvents AnexosBindingSource As BindingSource
    Friend WithEvents AnexosTableAdapter As ReestructDSTableAdapters.AnexosTableAdapter
    Friend WithEvents TxtSaldoInsol As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtMontoFin As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtDif As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtEstatus As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTasa As TextBox
    Friend WithEvents TxtTipoTasa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPlazoTrans As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnAsociar As Button
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
