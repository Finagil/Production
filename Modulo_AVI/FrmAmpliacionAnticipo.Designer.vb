<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAmpliacionAnticipo
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
        Me.Cmbclie = New System.Windows.Forms.ComboBox
        Me.AmpliacionAnticiposBindingSourceCLIE = New System.Windows.Forms.BindingSource(Me.components)
        Me.AviosDSXCLIE = New Agil.AviosDSX
        Me.Label1 = New System.Windows.Forms.Label
        Me.AmpliacionAnticiposTableAdapter = New Agil.AviosDSXTableAdapters.AmpliacionAnticiposTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbAnexo = New System.Windows.Forms.ComboBox
        Me.AmpliacionAnticiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AviosDSX = New Agil.AviosDSX
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtLinea = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.Txtsuma = New System.Windows.Forms.TextBox
        Me.TxtImporte = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.AmpliacionAnticiposBindingSourceCLIE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosDSXCLIE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmpliacionAnticiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cmbclie
        '
        Me.Cmbclie.DataSource = Me.AmpliacionAnticiposBindingSourceCLIE
        Me.Cmbclie.DisplayMember = "Cliente"
        Me.Cmbclie.FormattingEnabled = True
        Me.Cmbclie.Location = New System.Drawing.Point(12, 24)
        Me.Cmbclie.Name = "Cmbclie"
        Me.Cmbclie.Size = New System.Drawing.Size(503, 21)
        Me.Cmbclie.TabIndex = 0
        Me.Cmbclie.ValueMember = "Cliente"
        '
        'AmpliacionAnticiposBindingSourceCLIE
        '
        Me.AmpliacionAnticiposBindingSourceCLIE.DataMember = "AmpliacionAnticipos"
        Me.AmpliacionAnticiposBindingSourceCLIE.DataSource = Me.AviosDSXCLIE
        '
        'AviosDSXCLIE
        '
        Me.AviosDSXCLIE.DataSetName = "AviosDSX"
        Me.AviosDSXCLIE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'AmpliacionAnticiposTableAdapter
        '
        Me.AmpliacionAnticiposTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Anexos"
        '
        'CmbAnexo
        '
        Me.CmbAnexo.DataSource = Me.AmpliacionAnticiposBindingSource
        Me.CmbAnexo.DisplayMember = "Anexo"
        Me.CmbAnexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnexo.FormattingEnabled = True
        Me.CmbAnexo.Location = New System.Drawing.Point(12, 64)
        Me.CmbAnexo.Name = "CmbAnexo"
        Me.CmbAnexo.Size = New System.Drawing.Size(257, 21)
        Me.CmbAnexo.TabIndex = 3
        Me.CmbAnexo.ValueMember = "AnexoFull"
        '
        'AmpliacionAnticiposBindingSource
        '
        Me.AmpliacionAnticiposBindingSource.DataMember = "AmpliacionAnticipos"
        Me.AmpliacionAnticiposBindingSource.DataSource = Me.AviosDSX
        '
        'AviosDSX
        '
        Me.AviosDSX.DataSetName = "AviosDSX"
        Me.AviosDSX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Linea Actual"
        '
        'TxtLinea
        '
        Me.TxtLinea.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmpliacionAnticiposBindingSource, "LineaActual", True))
        Me.TxtLinea.Location = New System.Drawing.Point(12, 104)
        Me.TxtLinea.Name = "TxtLinea"
        Me.TxtLinea.ReadOnly = True
        Me.TxtLinea.Size = New System.Drawing.Size(171, 20)
        Me.TxtLinea.TabIndex = 5
        Me.TxtLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 131)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Sumar a la Linea"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 155)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(103, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.Text = "Cambiar la Linea"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Txtsuma
        '
        Me.Txtsuma.Location = New System.Drawing.Point(122, 131)
        Me.Txtsuma.Name = "Txtsuma"
        Me.Txtsuma.Size = New System.Drawing.Size(133, 20)
        Me.Txtsuma.TabIndex = 8
        Me.Txtsuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(122, 157)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(133, 20)
        Me.TxtImporte.TabIndex = 9
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cambiar Linea"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmAmpliacionAnticipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 197)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtImporte)
        Me.Controls.Add(Me.Txtsuma)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TxtLinea)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbAnexo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmbclie)
        Me.Name = "FrmAmpliacionAnticipo"
        Me.Text = "Ampliaciones de Linea de Anticipos"
        CType(Me.AmpliacionAnticiposBindingSourceCLIE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosDSXCLIE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmpliacionAnticiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cmbclie As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AmpliacionAnticiposBindingSourceCLIE As System.Windows.Forms.BindingSource
    Friend WithEvents AviosDSXCLIE As Agil.AviosDSX
    Friend WithEvents AmpliacionAnticiposTableAdapter As Agil.AviosDSXTableAdapters.AmpliacionAnticiposTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbAnexo As System.Windows.Forms.ComboBox
    Friend WithEvents AviosDSX As Agil.AviosDSX
    Friend WithEvents AmpliacionAnticiposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtLinea As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Txtsuma As System.Windows.Forms.TextBox
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
