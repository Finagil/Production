<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHojaCambios
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
        Me.CmbHoja = New System.Windows.Forms.ComboBox()
        Me.CambiocondicionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MesaControlDS = New Agil.MesaControlDS()
        Me.Cambio_condicionesTableAdapter = New Agil.MesaControlDSTableAdapters.Cambio_condicionesTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.CambiocondicionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hojas de Cambios"
        '
        'CmbHoja
        '
        Me.CmbHoja.DataSource = Me.CambiocondicionesBindingSource
        Me.CmbHoja.DisplayMember = "fe_cambios"
        Me.CmbHoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbHoja.FormattingEnabled = True
        Me.CmbHoja.Location = New System.Drawing.Point(16, 30)
        Me.CmbHoja.Name = "CmbHoja"
        Me.CmbHoja.Size = New System.Drawing.Size(229, 21)
        Me.CmbHoja.TabIndex = 1
        Me.CmbHoja.ValueMember = "id_hojaCambios"
        '
        'CambiocondicionesBindingSource
        '
        Me.CambiocondicionesBindingSource.DataMember = "Cambio_condiciones"
        Me.CambiocondicionesBindingSource.DataSource = Me.MesaControlDS
        '
        'MesaControlDS
        '
        Me.MesaControlDS.DataSetName = "MesaControlDS"
        Me.MesaControlDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cambio_condicionesTableAdapter
        '
        Me.Cambio_condicionesTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Solicitar Hoja de Cambios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(251, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Consultar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmHojaCambios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 104)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmbHoja)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmHojaCambios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hoja de Cambios Anexo:"
        CType(Me.CambiocondicionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CmbHoja As ComboBox
    Friend WithEvents CambiocondicionesBindingSource As BindingSource
    Friend WithEvents MesaControlDS As MesaControlDS
    Friend WithEvents Cambio_condicionesTableAdapter As MesaControlDSTableAdapters.Cambio_condicionesTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
