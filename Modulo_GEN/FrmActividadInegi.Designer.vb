<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActividadInegi
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
        Me.GENActividadInegiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS = New Agil.PromocionDS()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GEN_ActividadInegiTableAdapter = New Agil.PromocionDSTableAdapters.GEN_ActividadInegiTableAdapter()
        CType(Me.GENActividadInegiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Favor de seleccionar un Actividad INEGI"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.GENActividadInegiBindingSource
        Me.ComboBox1.DisplayMember = "ActividadInegi"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(15, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(913, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "Id_ActividadInegi"
        '
        'GENActividadInegiBindingSource
        '
        Me.GENActividadInegiBindingSource.DataMember = "GEN_ActividadInegi"
        Me.GENActividadInegiBindingSource.DataSource = Me.PromocionDSBindingSource
        '
        'PromocionDSBindingSource
        '
        Me.PromocionDSBindingSource.DataSource = Me.PromocionDS
        Me.PromocionDSBindingSource.Position = 0
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GEN_ActividadInegiTableAdapter
        '
        Me.GEN_ActividadInegiTableAdapter.ClearBeforeFill = True
        '
        'FrmActividadInegi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 85)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmActividadInegi"
        Me.Text = "Actividades INEGI"
        CType(Me.GENActividadInegiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PromocionDSBindingSource As BindingSource
    Friend WithEvents PromocionDS As PromocionDS
    Friend WithEvents Button1 As Button
    Friend WithEvents GENActividadInegiBindingSource As BindingSource
    Friend WithEvents GEN_ActividadInegiTableAdapter As PromocionDSTableAdapters.GEN_ActividadInegiTableAdapter
End Class
