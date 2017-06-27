<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValidaHojaTasa
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
        Me.Txtfirma = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ListHojas = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.MesaControlDS = New Agil.MesaControlDS
        Me.HojaTasaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HojaTasaTableAdapter = New Agil.MesaControlDSTableAdapters.HojaTasaTableAdapter
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HojaTasaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contrato o  Firma Digital (3 caracteres min.)"
        '
        'Txtfirma
        '
        Me.Txtfirma.Location = New System.Drawing.Point(13, 26)
        Me.Txtfirma.Name = "Txtfirma"
        Me.Txtfirma.Size = New System.Drawing.Size(272, 20)
        Me.Txtfirma.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hojas de Tasa Especial"
        '
        'ListHojas
        '
        Me.ListHojas.DataSource = Me.HojaTasaBindingSource
        Me.ListHojas.DisplayMember = "AnexoCon"
        Me.ListHojas.FormattingEnabled = True
        Me.ListHojas.Location = New System.Drawing.Point(15, 66)
        Me.ListHojas.Name = "ListHojas"
        Me.ListHojas.Size = New System.Drawing.Size(270, 95)
        Me.ListHojas.TabIndex = 3
        Me.ListHojas.ValueMember = "id"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(210, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MesaControlDS
        '
        Me.MesaControlDS.DataSetName = "MesaControlDS"
        Me.MesaControlDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HojaTasaBindingSource
        '
        Me.HojaTasaBindingSource.DataMember = "HojaTasa"
        Me.HojaTasaBindingSource.DataSource = Me.MesaControlDS
        '
        'HojaTasaTableAdapter
        '
        Me.HojaTasaTableAdapter.ClearBeforeFill = True
        '
        'FrmValidaHojaTasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 201)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListHojas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtfirma)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmValidaHojaTasa"
        Me.Text = "Hoja de Tasa Especial"
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HojaTasaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtfirma As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListHojas As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HojaTasaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MesaControlDS As Agil.MesaControlDS
    Friend WithEvents HojaTasaTableAdapter As Agil.MesaControlDSTableAdapters.HojaTasaTableAdapter
End Class
