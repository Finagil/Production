<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaGPS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargaGPS))
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.lblPlazomax = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblAdeudoant = New System.Windows.Forms.Label()
        Me.CkSaltar = New System.Windows.Forms.CheckBox()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(125, 51)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(96, 20)
        Me.txtMonto.TabIndex = 1
        '
        'txtPlazo
        '
        Me.txtPlazo.Location = New System.Drawing.Point(261, 51)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.Size = New System.Drawing.Size(25, 20)
        Me.txtPlazo.TabIndex = 2
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(470, 49)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(87, 23)
        Me.btnIniciar.TabIndex = 3
        Me.btnIniciar.Text = "Procesar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Monto a Capitalizar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Plazo"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(20, 80)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(636, 379)
        Me.DataGrid1.TabIndex = 14
        Me.DataGrid1.Visible = False
        '
        'lblPlazomax
        '
        Me.lblPlazomax.AutoSize = True
        Me.lblPlazomax.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlazomax.Location = New System.Drawing.Point(17, 9)
        Me.lblPlazomax.Name = "lblPlazomax"
        Me.lblPlazomax.Size = New System.Drawing.Size(43, 14)
        Me.lblPlazomax.TabIndex = 15
        Me.lblPlazomax.Text = "Label3"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(569, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 23)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(569, 49)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 23)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Salvar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblAdeudoant
        '
        Me.lblAdeudoant.AutoSize = True
        Me.lblAdeudoant.Location = New System.Drawing.Point(16, 29)
        Me.lblAdeudoant.Name = "lblAdeudoant"
        Me.lblAdeudoant.Size = New System.Drawing.Size(39, 13)
        Me.lblAdeudoant.TabIndex = 23
        Me.lblAdeudoant.Text = "Label3"
        Me.lblAdeudoant.Visible = False
        '
        'CkSaltar
        '
        Me.CkSaltar.AutoSize = True
        Me.CkSaltar.Location = New System.Drawing.Point(303, 53)
        Me.CkSaltar.Name = "CkSaltar"
        Me.CkSaltar.Size = New System.Drawing.Size(154, 17)
        Me.CkSaltar.TabIndex = 41
        Me.CkSaltar.Text = "Saltar Primera Amortización"
        Me.CkSaltar.UseVisualStyleBackColor = True
        '
        'frmCargaGPS
        '
        Me.ClientSize = New System.Drawing.Size(677, 471)
        Me.Controls.Add(Me.CkSaltar)
        Me.Controls.Add(Me.lblAdeudoant)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPlazomax)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.txtPlazo)
        Me.Controls.Add(Me.txtMonto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCargaGPS"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents lblPlazomax As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblAdeudoant As System.Windows.Forms.Label
    Friend WithEvents CkSaltar As CheckBox
End Class
