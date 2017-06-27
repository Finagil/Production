<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGruposRiesgo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbGrupo = New System.Windows.Forms.ComboBox
        Me.GruposRiesgosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS
        Me.GruposRiesgosTableAdapter = New Agil.GeneralDSTableAdapters.GruposRiesgosTableAdapter
        Me.TxtGrupo = New System.Windows.Forms.TextBox
        Me.BttNew = New System.Windows.Forms.Button
        Me.BttMOD = New System.Windows.Forms.Button
        Me.BttSave = New System.Windows.Forms.Button
        Me.BttCancel = New System.Windows.Forms.Button
        Me.BttAsig = New System.Windows.Forms.Button
        CType(Me.GruposRiesgosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grupo de Negocios"
        '
        'CmbGrupo
        '
        Me.CmbGrupo.DataSource = Me.GruposRiesgosBindingSource
        Me.CmbGrupo.DisplayMember = "NombreGrupo"
        Me.CmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGrupo.FormattingEnabled = True
        Me.CmbGrupo.Location = New System.Drawing.Point(15, 25)
        Me.CmbGrupo.Name = "CmbGrupo"
        Me.CmbGrupo.Size = New System.Drawing.Size(359, 21)
        Me.CmbGrupo.TabIndex = 1
        Me.CmbGrupo.ValueMember = "id_GrupoRiesgo"
        '
        'GruposRiesgosBindingSource
        '
        Me.GruposRiesgosBindingSource.DataMember = "GruposRiesgos"
        Me.GruposRiesgosBindingSource.DataSource = Me.GeneralDS
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GruposRiesgosTableAdapter
        '
        Me.GruposRiesgosTableAdapter.ClearBeforeFill = True
        '
        'TxtGrupo
        '
        Me.TxtGrupo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GruposRiesgosBindingSource, "NombreGrupo", True))
        Me.TxtGrupo.Location = New System.Drawing.Point(15, 53)
        Me.TxtGrupo.MaxLength = 50
        Me.TxtGrupo.Name = "TxtGrupo"
        Me.TxtGrupo.Size = New System.Drawing.Size(359, 20)
        Me.TxtGrupo.TabIndex = 2
        '
        'BttNew
        '
        Me.BttNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttNew.Location = New System.Drawing.Point(15, 79)
        Me.BttNew.Name = "BttNew"
        Me.BttNew.Size = New System.Drawing.Size(69, 35)
        Me.BttNew.TabIndex = 3
        Me.BttNew.Text = "Nuevo"
        Me.BttNew.UseVisualStyleBackColor = True
        '
        'BttMOD
        '
        Me.BttMOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttMOD.Location = New System.Drawing.Point(87, 79)
        Me.BttMOD.Name = "BttMOD"
        Me.BttMOD.Size = New System.Drawing.Size(69, 35)
        Me.BttMOD.TabIndex = 4
        Me.BttMOD.Text = "Modificar"
        Me.BttMOD.UseVisualStyleBackColor = True
        '
        'BttSave
        '
        Me.BttSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttSave.Location = New System.Drawing.Point(159, 79)
        Me.BttSave.Name = "BttSave"
        Me.BttSave.Size = New System.Drawing.Size(69, 35)
        Me.BttSave.TabIndex = 5
        Me.BttSave.Text = "Guardar"
        Me.BttSave.UseVisualStyleBackColor = True
        '
        'BttCancel
        '
        Me.BttCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttCancel.Location = New System.Drawing.Point(231, 79)
        Me.BttCancel.Name = "BttCancel"
        Me.BttCancel.Size = New System.Drawing.Size(69, 35)
        Me.BttCancel.TabIndex = 6
        Me.BttCancel.Text = "Cancelar"
        Me.BttCancel.UseVisualStyleBackColor = True
        '
        'BttAsig
        '
        Me.BttAsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttAsig.Location = New System.Drawing.Point(303, 79)
        Me.BttAsig.Name = "BttAsig"
        Me.BttAsig.Size = New System.Drawing.Size(69, 35)
        Me.BttAsig.TabIndex = 7
        Me.BttAsig.Text = "Asignar Grupos"
        Me.BttAsig.UseVisualStyleBackColor = True
        '
        'FrmGruposRiesgo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 134)
        Me.Controls.Add(Me.BttAsig)
        Me.Controls.Add(Me.BttCancel)
        Me.Controls.Add(Me.BttSave)
        Me.Controls.Add(Me.BttMOD)
        Me.Controls.Add(Me.BttNew)
        Me.Controls.Add(Me.TxtGrupo)
        Me.Controls.Add(Me.CmbGrupo)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGruposRiesgo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos de Negocios"
        CType(Me.GruposRiesgosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents GeneralDS As Agil.GeneralDS
    Friend WithEvents GruposRiesgosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GruposRiesgosTableAdapter As Agil.GeneralDSTableAdapters.GruposRiesgosTableAdapter
    Friend WithEvents TxtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents BttNew As System.Windows.Forms.Button
    Friend WithEvents BttMOD As System.Windows.Forms.Button
    Friend WithEvents BttSave As System.Windows.Forms.Button
    Friend WithEvents BttCancel As System.Windows.Forms.Button
    Friend WithEvents BttAsig As System.Windows.Forms.Button
End Class
