<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambioRusuarioCXP
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GENCorreosFasesMCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MesaControlDS = New Agil.MesaControlDS()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.UsuariosFinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguridadDS = New Agil.SeguridadDS()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GEN_CorreosFasesMCTableAdapter = New Agil.MesaControlDSTableAdapters.GEN_CorreosFasesMCTableAdapter()
        Me.UsuariosFinagilTableAdapter = New Agil.SeguridadDSTableAdapters.UsuariosFinagilTableAdapter()
        CType(Me.GENCorreosFasesMCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosFinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario Actual"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GENCorreosFasesMCBindingSource, "Nombre", True))
        Me.TextBox1.Location = New System.Drawing.Point(15, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(348, 20)
        Me.TextBox1.TabIndex = 1
        '
        'GENCorreosFasesMCBindingSource
        '
        Me.GENCorreosFasesMCBindingSource.DataMember = "GEN_CorreosFasesMC"
        Me.GENCorreosFasesMCBindingSource.DataSource = Me.MesaControlDS
        '
        'MesaControlDS
        '
        Me.MesaControlDS.DataSetName = "MesaControlDS"
        Me.MesaControlDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuarios Mesa de Control"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.UsuariosFinagilBindingSource
        Me.ComboBox1.DisplayMember = "NombreCompleto"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(15, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(348, 21)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.ValueMember = "correo"
        '
        'UsuariosFinagilBindingSource
        '
        Me.UsuariosFinagilBindingSource.DataMember = "UsuariosFinagil"
        Me.UsuariosFinagilBindingSource.DataSource = Me.SeguridadDS
        '
        'SeguridadDS
        '
        Me.SeguridadDS.DataSetName = "SeguridadDS"
        Me.SeguridadDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(348, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cambiar Usuario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GEN_CorreosFasesMCTableAdapter
        '
        Me.GEN_CorreosFasesMCTableAdapter.ClearBeforeFill = True
        '
        'UsuariosFinagilTableAdapter
        '
        Me.UsuariosFinagilTableAdapter.ClearBeforeFill = True
        '
        'FrmCambioRusuarioCXP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 127)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCambioRusuarioCXP"
        Me.Text = "Cambio de Usuario CXP"
        CType(Me.GENCorreosFasesMCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosFinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MesaControlDS As MesaControlDS
    Friend WithEvents GENCorreosFasesMCBindingSource As BindingSource
    Friend WithEvents GEN_CorreosFasesMCTableAdapter As MesaControlDSTableAdapters.GEN_CorreosFasesMCTableAdapter
    Friend WithEvents SeguridadDS As SeguridadDS
    Friend WithEvents UsuariosFinagilBindingSource As BindingSource
    Friend WithEvents UsuariosFinagilTableAdapter As SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
End Class
