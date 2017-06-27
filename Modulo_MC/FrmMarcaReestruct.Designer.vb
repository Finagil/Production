<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarcaReestruct
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
        Me.components = New System.ComponentModel.Container()
        Me.LstAnexos = New System.Windows.Forms.ListBox()
        Me.AnexosSinPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MesaControlDS = New Agil.MesaControlDS()
        Me.BttMarcar = New System.Windows.Forms.Button()
        Me.AnexosSinPagoTableAdapter = New Agil.MesaControlDSTableAdapters.AnexosSinPagoTableAdapter()
        Me.Dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.CmbAcumula = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbReest = New System.Windows.Forms.ComboBox()
        CType(Me.AnexosSinPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstAnexos
        '
        Me.LstAnexos.DataSource = Me.AnexosSinPagoBindingSource
        Me.LstAnexos.DisplayMember = "Titulo"
        Me.LstAnexos.FormattingEnabled = True
        Me.LstAnexos.Location = New System.Drawing.Point(12, 22)
        Me.LstAnexos.Name = "LstAnexos"
        Me.LstAnexos.Size = New System.Drawing.Size(494, 108)
        Me.LstAnexos.TabIndex = 0
        Me.LstAnexos.ValueMember = "Anexo"
        '
        'AnexosSinPagoBindingSource
        '
        Me.AnexosSinPagoBindingSource.DataMember = "AnexosSinPago"
        Me.AnexosSinPagoBindingSource.DataSource = Me.MesaControlDS
        '
        'MesaControlDS
        '
        Me.MesaControlDS.DataSetName = "MesaControlDS"
        Me.MesaControlDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BttMarcar
        '
        Me.BttMarcar.Location = New System.Drawing.Point(402, 148)
        Me.BttMarcar.Name = "BttMarcar"
        Me.BttMarcar.Size = New System.Drawing.Size(104, 24)
        Me.BttMarcar.TabIndex = 2
        Me.BttMarcar.Text = "Activar Contrato"
        Me.BttMarcar.UseVisualStyleBackColor = True
        '
        'AnexosSinPagoTableAdapter
        '
        Me.AnexosSinPagoTableAdapter.ClearBeforeFill = True
        '
        'Dtp1
        '
        Me.Dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp1.Location = New System.Drawing.Point(12, 152)
        Me.Dtp1.Name = "Dtp1"
        Me.Dtp1.Size = New System.Drawing.Size(168, 20)
        Me.Dtp1.TabIndex = 3
        '
        'CmbAcumula
        '
        Me.CmbAcumula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAcumula.FormattingEnabled = True
        Me.CmbAcumula.Items.AddRange(New Object() {"SI", "NO"})
        Me.CmbAcumula.Location = New System.Drawing.Point(186, 151)
        Me.CmbAcumula.Name = "CmbAcumula"
        Me.CmbAcumula.Size = New System.Drawing.Size(95, 21)
        Me.CmbAcumula.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Contrato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha Pago"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(183, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Acumula Interes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Reestructura"
        '
        'CmbReest
        '
        Me.CmbReest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbReest.FormattingEnabled = True
        Me.CmbReest.Items.AddRange(New Object() {"SI", "NO"})
        Me.CmbReest.Location = New System.Drawing.Point(300, 151)
        Me.CmbReest.Name = "CmbReest"
        Me.CmbReest.Size = New System.Drawing.Size(95, 21)
        Me.CmbReest.TabIndex = 8
        '
        'FrmMarcaReestruct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 182)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbReest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbAcumula)
        Me.Controls.Add(Me.Dtp1)
        Me.Controls.Add(Me.BttMarcar)
        Me.Controls.Add(Me.LstAnexos)
        Me.Name = "FrmMarcaReestruct"
        Me.Text = "Marcar como Reestructura"
        CType(Me.AnexosSinPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LstAnexos As System.Windows.Forms.ListBox
    Friend WithEvents BttMarcar As System.Windows.Forms.Button
    Friend WithEvents MesaControlDS As Agil.MesaControlDS
    Friend WithEvents AnexosSinPagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexosSinPagoTableAdapter As Agil.MesaControlDSTableAdapters.AnexosSinPagoTableAdapter
    Friend WithEvents Dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbAcumula As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbReest As ComboBox
End Class
