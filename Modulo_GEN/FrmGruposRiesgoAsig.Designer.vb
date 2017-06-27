<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGruposRiesgoAsig
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
        Me.CmbGrupo = New System.Windows.Forms.ComboBox
        Me.GruposRiesgosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS
        Me.Label1 = New System.Windows.Forms.Label
        Me.GruposRiesgosTableAdapter = New Agil.GeneralDSTableAdapters.GruposRiesgosTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txtfiltro = New System.Windows.Forms.TextBox
        Me.ListaSin = New System.Windows.Forms.ListBox
        Me.ClientesSinGrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesSinGrupoTableAdapter = New Agil.GeneralDSTableAdapters.ClientesSinGrupoTableAdapter
        Me.ListaCon = New System.Windows.Forms.ListBox
        Me.ClientesConGrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtFiltro2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ClientesConGrupoTableAdapter = New Agil.GeneralDSTableAdapters.ClientesConGrupoTableAdapter
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.GruposRiesgosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesSinGrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesConGrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.CmbGrupo.TabIndex = 3
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Grupo de Negocios"
        '
        'GruposRiesgosTableAdapter
        '
        Me.GruposRiesgosTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Clientes sin Grupo de Negocios"
        '
        'Txtfiltro
        '
        Me.Txtfiltro.Location = New System.Drawing.Point(47, 77)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(283, 20)
        Me.Txtfiltro.TabIndex = 5
        '
        'ListaSin
        '
        Me.ListaSin.DataSource = Me.ClientesSinGrupoBindingSource
        Me.ListaSin.DisplayMember = "Descr"
        Me.ListaSin.FormattingEnabled = True
        Me.ListaSin.Location = New System.Drawing.Point(15, 104)
        Me.ListaSin.Name = "ListaSin"
        Me.ListaSin.Size = New System.Drawing.Size(315, 368)
        Me.ListaSin.TabIndex = 6
        Me.ListaSin.ValueMember = "Cliente"
        '
        'ClientesSinGrupoBindingSource
        '
        Me.ClientesSinGrupoBindingSource.DataMember = "ClientesSinGrupo"
        Me.ClientesSinGrupoBindingSource.DataSource = Me.GeneralDS
        '
        'ClientesSinGrupoTableAdapter
        '
        Me.ClientesSinGrupoTableAdapter.ClearBeforeFill = True
        '
        'ListaCon
        '
        Me.ListaCon.DataSource = Me.ClientesConGrupoBindingSource
        Me.ListaCon.DisplayMember = "Descr"
        Me.ListaCon.FormattingEnabled = True
        Me.ListaCon.Location = New System.Drawing.Point(349, 104)
        Me.ListaCon.Name = "ListaCon"
        Me.ListaCon.Size = New System.Drawing.Size(315, 368)
        Me.ListaCon.TabIndex = 9
        Me.ListaCon.ValueMember = "Cliente"
        '
        'ClientesConGrupoBindingSource
        '
        Me.ClientesConGrupoBindingSource.DataMember = "ClientesConGrupo"
        Me.ClientesConGrupoBindingSource.DataSource = Me.GeneralDS
        '
        'TxtFiltro2
        '
        Me.TxtFiltro2.Location = New System.Drawing.Point(381, 77)
        Me.TxtFiltro2.Name = "TxtFiltro2"
        Me.TxtFiltro2.Size = New System.Drawing.Size(283, 20)
        Me.TxtFiltro2.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(346, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Grupo de Negocios"
        '
        'ClientesConGrupoTableAdapter
        '
        Me.ClientesConGrupoTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Filtro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(346, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Filtro"
        '
        'FrmGruposRiesgoAsig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 486)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListaCon)
        Me.Controls.Add(Me.TxtFiltro2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListaSin)
        Me.Controls.Add(Me.Txtfiltro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbGrupo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmGruposRiesgoAsig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignación de Grupos de Negocios"
        CType(Me.GruposRiesgosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesSinGrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesConGrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GeneralDS As Agil.GeneralDS
    Friend WithEvents GruposRiesgosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GruposRiesgosTableAdapter As Agil.GeneralDSTableAdapters.GruposRiesgosTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents ListaSin As System.Windows.Forms.ListBox
    Friend WithEvents ClientesSinGrupoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesSinGrupoTableAdapter As Agil.GeneralDSTableAdapters.ClientesSinGrupoTableAdapter
    Friend WithEvents ListaCon As System.Windows.Forms.ListBox
    Friend WithEvents TxtFiltro2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ClientesConGrupoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesConGrupoTableAdapter As Agil.GeneralDSTableAdapters.ClientesConGrupoTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
