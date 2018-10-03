<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDocOnbase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.LstImagenes = New System.Windows.Forms.ListBox()
        Me.OnBaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS()
        Me.OnBaseTableAdapter = New Agil.GeneralDSTableAdapters.OnBaseTableAdapter()
        Me.BtnvALIDA = New System.Windows.Forms.Button()
        Me.LbBusqueda = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        CType(Me.OnBaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(477, 322)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'LstImagenes
        '
        Me.LstImagenes.DataSource = Me.OnBaseBindingSource
        Me.LstImagenes.DisplayMember = "titulo"
        Me.LstImagenes.FormattingEnabled = True
        Me.LstImagenes.Location = New System.Drawing.Point(12, 12)
        Me.LstImagenes.Name = "LstImagenes"
        Me.LstImagenes.Size = New System.Drawing.Size(798, 303)
        Me.LstImagenes.TabIndex = 1
        Me.LstImagenes.ValueMember = "itemname"
        '
        'OnBaseBindingSource
        '
        Me.OnBaseBindingSource.DataMember = "OnBase"
        Me.OnBaseBindingSource.DataSource = Me.GeneralDS
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OnBaseTableAdapter
        '
        Me.OnBaseTableAdapter.ClearBeforeFill = True
        '
        'BtnvALIDA
        '
        Me.BtnvALIDA.Location = New System.Drawing.Point(383, 321)
        Me.BtnvALIDA.Name = "BtnvALIDA"
        Me.BtnvALIDA.Size = New System.Drawing.Size(88, 23)
        Me.BtnvALIDA.TabIndex = 2
        Me.BtnvALIDA.Text = "Valida Datos"
        Me.BtnvALIDA.UseVisualStyleBackColor = True
        Me.BtnvALIDA.Visible = False
        '
        'LbBusqueda
        '
        Me.LbBusqueda.AutoSize = True
        Me.LbBusqueda.Location = New System.Drawing.Point(12, 326)
        Me.LbBusqueda.Name = "LbBusqueda"
        Me.LbBusqueda.Size = New System.Drawing.Size(55, 13)
        Me.LbBusqueda.TabIndex = 3
        Me.LbBusqueda.Text = "Busqueda"
        Me.LbBusqueda.Visible = False
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(73, 323)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(303, 20)
        Me.TxtBusqueda.TabIndex = 4
        Me.TxtBusqueda.Visible = False
        '
        'FrmDocOnbase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.LbBusqueda)
        Me.Controls.Add(Me.BtnvALIDA)
        Me.Controls.Add(Me.LstImagenes)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FrmDocOnbase"
        Me.Text = "FrmDocOnbase"
        CType(Me.OnBaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents LstImagenes As System.Windows.Forms.ListBox
    Friend WithEvents OnBaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDS As Agil.GeneralDS
    Friend WithEvents OnBaseTableAdapter As Agil.GeneralDSTableAdapters.OnBaseTableAdapter
    Friend WithEvents BtnvALIDA As System.Windows.Forms.Button
    Friend WithEvents LbBusqueda As System.Windows.Forms.Label
    Friend WithEvents TxtBusqueda As System.Windows.Forms.TextBox
End Class
