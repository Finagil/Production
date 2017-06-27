<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGrupoLista
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
        Me.ListGR = New System.Windows.Forms.ListBox
        Me.ClientesConGrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS
        Me.ClientesConGrupoTableAdapter = New Agil.GeneralDSTableAdapters.ClientesConGrupoTableAdapter
        Me.ListRC = New System.Windows.Forms.ListBox
        Me.ClientesConGrupoComunBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesConGrupoComunTableAdapter = New Agil.GeneralDSTableAdapters.ClientesConGrupoComunTableAdapter
        Me.BttRC = New System.Windows.Forms.Button
        CType(Me.ClientesConGrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesConGrupoComunBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListGR
        '
        Me.ListGR.DataSource = Me.ClientesConGrupoBindingSource
        Me.ListGR.DisplayMember = "Descr"
        Me.ListGR.FormattingEnabled = True
        Me.ListGR.Location = New System.Drawing.Point(12, 12)
        Me.ListGR.Name = "ListGR"
        Me.ListGR.Size = New System.Drawing.Size(424, 420)
        Me.ListGR.TabIndex = 0
        Me.ListGR.ValueMember = "Cliente"
        Me.ListGR.Visible = False
        '
        'ClientesConGrupoBindingSource
        '
        Me.ClientesConGrupoBindingSource.DataMember = "ClientesConGrupo"
        Me.ClientesConGrupoBindingSource.DataSource = Me.GeneralDS
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesConGrupoTableAdapter
        '
        Me.ClientesConGrupoTableAdapter.ClearBeforeFill = True
        '
        'ListRC
        '
        Me.ListRC.DataSource = Me.ClientesConGrupoComunBindingSource
        Me.ListRC.DisplayMember = "Descr"
        Me.ListRC.FormattingEnabled = True
        Me.ListRC.Location = New System.Drawing.Point(12, 11)
        Me.ListRC.Name = "ListRC"
        Me.ListRC.Size = New System.Drawing.Size(424, 420)
        Me.ListRC.TabIndex = 1
        Me.ListRC.ValueMember = "Cliente"
        Me.ListRC.Visible = False
        '
        'ClientesConGrupoComunBindingSource
        '
        Me.ClientesConGrupoComunBindingSource.DataMember = "ClientesConGrupoComun"
        Me.ClientesConGrupoComunBindingSource.DataSource = Me.GeneralDS
        '
        'ClientesConGrupoComunTableAdapter
        '
        Me.ClientesConGrupoComunTableAdapter.ClearBeforeFill = True
        '
        'BttRC
        '
        Me.BttRC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BttRC.Location = New System.Drawing.Point(338, 386)
        Me.BttRC.Name = "BttRC"
        Me.BttRC.Size = New System.Drawing.Size(88, 35)
        Me.BttRC.TabIndex = 122
        Me.BttRC.Text = "Saldo RC"
        Me.BttRC.UseVisualStyleBackColor = True
        Me.BttRC.Visible = False
        '
        'FrmGrupoLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 443)
        Me.Controls.Add(Me.BttRC)
        Me.Controls.Add(Me.ListRC)
        Me.Controls.Add(Me.ListGR)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGrupoLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmGrupoLista"
        CType(Me.ClientesConGrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesConGrupoComunBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListGR As System.Windows.Forms.ListBox
    Friend WithEvents ClientesConGrupoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDS As Agil.GeneralDS
    Friend WithEvents ClientesConGrupoTableAdapter As Agil.GeneralDSTableAdapters.ClientesConGrupoTableAdapter
    Friend WithEvents ListRC As System.Windows.Forms.ListBox
    Friend WithEvents ClientesConGrupoComunBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesConGrupoComunTableAdapter As Agil.GeneralDSTableAdapters.ClientesConGrupoComunTableAdapter
    Friend WithEvents BttRC As System.Windows.Forms.Button
End Class
