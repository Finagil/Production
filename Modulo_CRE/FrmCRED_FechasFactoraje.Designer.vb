<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCRED_FechasFactoraje
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
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpIni = New System.Windows.Forms.DateTimePicker()
        Me.Dtpfin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CreditoDS = New Agil.CreditoDS()
        Me.CREDFactorajeFechasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRED_FactorajeFechasTableAdapter = New Agil.CreditoDSTableAdapters.CRED_FactorajeFechasTableAdapter()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CREDFactorajeFechasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(13, 30)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.ReadOnly = True
        Me.TextNombre.Size = New System.Drawing.Size(477, 20)
        Me.TextNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Inicio"
        '
        'DtpIni
        '
        Me.DtpIni.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CREDFactorajeFechasBindingSource, "FechaInicio", True))
        Me.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIni.Location = New System.Drawing.Point(81, 56)
        Me.DtpIni.Name = "DtpIni"
        Me.DtpIni.Size = New System.Drawing.Size(111, 20)
        Me.DtpIni.TabIndex = 3
        '
        'Dtpfin
        '
        Me.Dtpfin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CREDFactorajeFechasBindingSource, "FechaFin", True))
        Me.Dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtpfin.Location = New System.Drawing.Point(272, 56)
        Me.Dtpfin.Name = "Dtpfin"
        Me.Dtpfin.Size = New System.Drawing.Size(111, 20)
        Me.Dtpfin.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Vecn."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(420, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CreditoDS
        '
        Me.CreditoDS.DataSetName = "CreditoDS"
        Me.CreditoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CREDFactorajeFechasBindingSource
        '
        Me.CREDFactorajeFechasBindingSource.DataMember = "CRED_FactorajeFechas"
        Me.CREDFactorajeFechasBindingSource.DataSource = Me.CreditoDS
        '
        'CRED_FactorajeFechasTableAdapter
        '
        Me.CRED_FactorajeFechasTableAdapter.ClearBeforeFill = True
        '
        'FrmCRED_FechasFactoraje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 88)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Dtpfin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DtpIni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCRED_FechasFactoraje"
        Me.Text = "Fechas de Contrato de Factoraje"
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CREDFactorajeFechasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpIni As DateTimePicker
    Friend WithEvents Dtpfin As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CREDFactorajeFechasBindingSource As BindingSource
    Friend WithEvents CreditoDS As CreditoDS
    Friend WithEvents CRED_FactorajeFechasTableAdapter As CreditoDSTableAdapters.CRED_FactorajeFechasTableAdapter
End Class
