<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSolicitaLineaDG
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
        Me.Txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ClientesConLineaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditoDS = New Agil.CreditoDS()
        Me.ClientesConLineaTableAdapter = New Agil.CreditoDSTableAdapters.ClientesConLineaTableAdapter()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.TextNotas = New System.Windows.Forms.TextBox()
        Me.CREDSolicitudLineaDGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextImporte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CRED_SolicitudLineaDGTableAdapter = New Agil.CreditoDSTableAdapters.CRED_SolicitudLineaDGTableAdapter()
        CType(Me.ClientesConLineaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CREDSolicitudLineaDGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtfiltro
        '
        Me.Txtfiltro.Location = New System.Drawing.Point(10, 28)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(424, 20)
        Me.Txtfiltro.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 16)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Filtro"
        '
        'lblClientes
        '
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(11, 51)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(432, 16)
        Me.lblClientes.TabIndex = 61
        Me.lblClientes.Text = "Selecciona un Cliente de la siguiente Lista"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClientesConLineaBindingSource
        Me.ComboBox1.DisplayMember = "Descr"
        Me.ComboBox1.Location = New System.Drawing.Point(10, 69)
        Me.ComboBox1.MaxDropDownItems = 25
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(424, 21)
        Me.ComboBox1.TabIndex = 62
        Me.ComboBox1.ValueMember = "Cliente"
        '
        'ClientesConLineaBindingSource
        '
        Me.ClientesConLineaBindingSource.DataMember = "ClientesConLinea"
        Me.ClientesConLineaBindingSource.DataSource = Me.CreditoDS
        '
        'CreditoDS
        '
        Me.CreditoDS.DataSetName = "CreditoDS"
        Me.CreditoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesConLineaTableAdapter
        '
        Me.ClientesConLineaTableAdapter.ClearBeforeFill = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(337, 96)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(97, 23)
        Me.ButtonAdd.TabIndex = 64
        Me.ButtonAdd.Text = "Agregar Sol."
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonSend)
        Me.GroupBox1.Controls.Add(Me.ButtonCancel)
        Me.GroupBox1.Controls.Add(Me.TextNotas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextImporte)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(14, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 220)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Solicitud de Linea"
        '
        'ButtonSend
        '
        Me.ButtonSend.Location = New System.Drawing.Point(317, 185)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(97, 23)
        Me.ButtonSend.TabIndex = 68
        Me.ButtonSend.Text = "Enviar Sol."
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(9, 185)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(97, 23)
        Me.ButtonCancel.TabIndex = 67
        Me.ButtonCancel.Text = "Cancelar Sol."
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'TextNotas
        '
        Me.TextNotas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSolicitudLineaDGBindingSource, "Notas", True))
        Me.TextNotas.Location = New System.Drawing.Point(9, 81)
        Me.TextNotas.MaxLength = 500
        Me.TextNotas.Multiline = True
        Me.TextNotas.Name = "TextNotas"
        Me.TextNotas.Size = New System.Drawing.Size(405, 98)
        Me.TextNotas.TabIndex = 3
        '
        'CREDSolicitudLineaDGBindingSource
        '
        Me.CREDSolicitudLineaDGBindingSource.DataMember = "CRED_SolicitudLineaDG"
        Me.CREDSolicitudLineaDGBindingSource.DataSource = Me.CreditoDS
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Observaciones"
        '
        'TextImporte
        '
        Me.TextImporte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CREDSolicitudLineaDGBindingSource, "Importe", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextImporte.Location = New System.Drawing.Point(9, 42)
        Me.TextImporte.Name = "TextImporte"
        Me.TextImporte.Size = New System.Drawing.Size(114, 20)
        Me.TextImporte.TabIndex = 1
        Me.TextImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total de la Linea"
        '
        'CRED_SolicitudLineaDGTableAdapter
        '
        Me.CRED_SolicitudLineaDGTableAdapter.ClearBeforeFill = True
        '
        'FrmSolicitaLineaDG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.Txtfiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "FrmSolicitaLineaDG"
        Me.Text = "Solicitud de Linea a Direccion General"
        CType(Me.ClientesConLineaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CREDSolicitudLineaDGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtfiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClientes As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ClientesConLineaBindingSource As BindingSource
    Friend WithEvents CreditoDS As CreditoDS
    Friend WithEvents ClientesConLineaTableAdapter As CreditoDSTableAdapters.ClientesConLineaTableAdapter
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextNotas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextImporte As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents CREDSolicitudLineaDGBindingSource As BindingSource
    Friend WithEvents CRED_SolicitudLineaDGTableAdapter As CreditoDSTableAdapters.CRED_SolicitudLineaDGTableAdapter
    Friend WithEvents ButtonSend As Button
End Class
