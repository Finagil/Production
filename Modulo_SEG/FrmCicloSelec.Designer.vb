<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPAGOSelec
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
        Me.CmbCiclo = New System.Windows.Forms.ComboBox
        Me.CiclosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS
        Me.lblNumc = New System.Windows.Forms.Label
        Me.BttCancel = New System.Windows.Forms.Button
        Me.BttSave = New System.Windows.Forms.Button
        Me.CiclosTableAdapter = New Agil.SegurosDSTableAdapters.CiclosTableAdapter
        CType(Me.CiclosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbCiclo
        '
        Me.CmbCiclo.DataSource = Me.CiclosBindingSource
        Me.CmbCiclo.DisplayMember = "DescCiclo"
        Me.CmbCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCiclo.FormattingEnabled = True
        Me.CmbCiclo.Location = New System.Drawing.Point(42, 12)
        Me.CmbCiclo.Name = "CmbCiclo"
        Me.CmbCiclo.Size = New System.Drawing.Size(126, 21)
        Me.CmbCiclo.TabIndex = 67
        Me.CmbCiclo.ValueMember = "Ciclo"
        '
        'CiclosBindingSource
        '
        Me.CiclosBindingSource.DataMember = "Ciclos"
        Me.CiclosBindingSource.DataSource = Me.SegurosDS
        '
        'SegurosDS
        '
        Me.SegurosDS.DataSetName = "SegurosDS"
        Me.SegurosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblNumc
        '
        Me.lblNumc.Location = New System.Drawing.Point(3, 13)
        Me.lblNumc.Name = "lblNumc"
        Me.lblNumc.Size = New System.Drawing.Size(48, 16)
        Me.lblNumc.TabIndex = 66
        Me.lblNumc.Text = "Ciclo"
        Me.lblNumc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BttCancel
        '
        Me.BttCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttCancel.Location = New System.Drawing.Point(264, 9)
        Me.BttCancel.Name = "BttCancel"
        Me.BttCancel.Size = New System.Drawing.Size(72, 27)
        Me.BttCancel.TabIndex = 113
        Me.BttCancel.Text = "Cancelar"
        Me.BttCancel.UseVisualStyleBackColor = True
        '
        'BttSave
        '
        Me.BttSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttSave.Location = New System.Drawing.Point(183, 9)
        Me.BttSave.Name = "BttSave"
        Me.BttSave.Size = New System.Drawing.Size(72, 27)
        Me.BttSave.TabIndex = 112
        Me.BttSave.Text = "OK"
        Me.BttSave.UseVisualStyleBackColor = True
        '
        'CiclosTableAdapter
        '
        Me.CiclosTableAdapter.ClearBeforeFill = True
        '
        'FrmCicloSelec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 47)
        Me.ControlBox = False
        Me.Controls.Add(Me.BttCancel)
        Me.Controls.Add(Me.BttSave)
        Me.Controls.Add(Me.CmbCiclo)
        Me.Controls.Add(Me.lblNumc)
        Me.Name = "FrmCicloSelec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleciona un Ciclo"
        CType(Me.CiclosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmbCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents lblNumc As System.Windows.Forms.Label
    Friend WithEvents BttCancel As System.Windows.Forms.Button
    Friend WithEvents BttSave As System.Windows.Forms.Button
    Friend WithEvents SegurosDS As Agil.SegurosDS
    Friend WithEvents CiclosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CiclosTableAdapter As Agil.SegurosDSTableAdapters.CiclosTableAdapter
End Class
