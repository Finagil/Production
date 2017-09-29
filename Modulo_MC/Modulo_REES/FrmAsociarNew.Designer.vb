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
        Me.ReestructDS = New Agil.ReestructDS()
        Me.AnexosSinActivarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexosSinActivarTableAdapter = New Agil.ReestructDSTableAdapters.AnexosSinActivarTableAdapter()
        Me.AnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexosTableAdapter = New Agil.ReestructDSTableAdapters.AnexosTableAdapter()
        CType(Me.ReestructDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosSinActivarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "Anexo"
        '
        'ReestructDS
        '
        Me.ReestructDS.DataSetName = "ReestructDS"
        Me.ReestructDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnexosSinActivarBindingSource
        '
        Me.AnexosSinActivarBindingSource.DataMember = "AnexosSinActivar"
        Me.AnexosSinActivarBindingSource.DataSource = Me.ReestructDS
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
        'FrmAsociarNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 261)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAsociarNew"
        Me.Text = "Asociar nuevo contrato para Reestructura"
        CType(Me.ReestructDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosSinActivarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
