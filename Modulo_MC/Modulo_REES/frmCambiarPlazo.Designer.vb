<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCambiarPlazo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambiarPlazo))
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.lblPlazomax = New System.Windows.Forms.Label()
        Me.txtSant = New System.Windows.Forms.TextBox()
        Me.txtTap = New System.Windows.Forms.TextBox()
        Me.txtVen = New System.Windows.Forms.TextBox()
        Me.txtFven = New System.Windows.Forms.TextBox()
        Me.txtPzo = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblAdeudoant = New System.Windows.Forms.Label()
        Me.txtAde = New System.Windows.Forms.TextBox()
        Me.txtRow = New System.Windows.Forms.TextBox()
        Me.TxtStatus = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGrid2 = New System.Windows.Forms.DataGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSaldoInsoluto = New System.Windows.Forms.TextBox()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(125, 51)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(96, 20)
        Me.txtMonto.TabIndex = 1
        '
        'txtPlazo
        '
        Me.txtPlazo.Location = New System.Drawing.Point(457, 51)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.Size = New System.Drawing.Size(25, 20)
        Me.txtPlazo.TabIndex = 2
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(514, 51)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(108, 23)
        Me.btnIniciar.TabIndex = 3
        Me.btnIniciar.Text = "Calcular"
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
        Me.Label2.Location = New System.Drawing.Point(418, 54)
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
        Me.DataGrid1.Size = New System.Drawing.Size(608, 379)
        Me.DataGrid1.TabIndex = 14
        Me.DataGrid1.Visible = False
        '
        'lblPlazomax
        '
        Me.lblPlazomax.AutoSize = True
        Me.lblPlazomax.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlazomax.Location = New System.Drawing.Point(17, 14)
        Me.lblPlazomax.Name = "lblPlazomax"
        Me.lblPlazomax.Size = New System.Drawing.Size(43, 14)
        Me.lblPlazomax.TabIndex = 15
        Me.lblPlazomax.Text = "Label3"
        '
        'txtSant
        '
        Me.txtSant.Location = New System.Drawing.Point(402, 439)
        Me.txtSant.Name = "txtSant"
        Me.txtSant.Size = New System.Drawing.Size(10, 20)
        Me.txtSant.TabIndex = 16
        Me.txtSant.Visible = False
        '
        'txtTap
        '
        Me.txtTap.Location = New System.Drawing.Point(418, 439)
        Me.txtTap.Name = "txtTap"
        Me.txtTap.Size = New System.Drawing.Size(10, 20)
        Me.txtTap.TabIndex = 17
        Me.txtTap.Visible = False
        '
        'txtVen
        '
        Me.txtVen.Location = New System.Drawing.Point(434, 439)
        Me.txtVen.Name = "txtVen"
        Me.txtVen.Size = New System.Drawing.Size(10, 20)
        Me.txtVen.TabIndex = 18
        Me.txtVen.Visible = False
        '
        'txtFven
        '
        Me.txtFven.Location = New System.Drawing.Point(450, 439)
        Me.txtFven.Name = "txtFven"
        Me.txtFven.Size = New System.Drawing.Size(10, 20)
        Me.txtFven.TabIndex = 19
        Me.txtFven.Visible = False
        '
        'txtPzo
        '
        Me.txtPzo.Location = New System.Drawing.Point(468, 439)
        Me.txtPzo.Name = "txtPzo"
        Me.txtPzo.Size = New System.Drawing.Size(10, 20)
        Me.txtPzo.TabIndex = 20
        Me.txtPzo.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(634, 51)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 23)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Cambiar Plazo"
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
        'txtAde
        '
        Me.txtAde.Location = New System.Drawing.Point(484, 439)
        Me.txtAde.Name = "txtAde"
        Me.txtAde.Size = New System.Drawing.Size(10, 20)
        Me.txtAde.TabIndex = 24
        Me.txtAde.Text = "N"
        Me.txtAde.Visible = False
        '
        'txtRow
        '
        Me.txtRow.Location = New System.Drawing.Point(500, 439)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(10, 20)
        Me.txtRow.TabIndex = 25
        Me.txtRow.Text = "N"
        Me.txtRow.Visible = False
        '
        'TxtStatus
        '
        Me.TxtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStatus.Location = New System.Drawing.Point(1149, 22)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.ReadOnly = True
        Me.TxtStatus.Size = New System.Drawing.Size(70, 20)
        Me.TxtStatus.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(1146, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Nuevo Estatus"
        '
        'DataGrid2
        '
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(634, 80)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ReadOnly = True
        Me.DataGrid2.Size = New System.Drawing.Size(588, 379)
        Me.DataGrid2.TabIndex = 100
        Me.DataGrid2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Saldo Insoluto"
        '
        'TxtSaldoInsoluto
        '
        Me.TxtSaldoInsoluto.Location = New System.Drawing.Point(303, 51)
        Me.TxtSaldoInsoluto.Name = "TxtSaldoInsoluto"
        Me.TxtSaldoInsoluto.ReadOnly = True
        Me.TxtSaldoInsoluto.Size = New System.Drawing.Size(96, 20)
        Me.TxtSaldoInsoluto.TabIndex = 101
        '
        'frmCambiarPlazo
        '
        Me.ClientSize = New System.Drawing.Size(1231, 471)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtSaldoInsoluto)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.TxtStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.txtAde)
        Me.Controls.Add(Me.lblAdeudoant)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPzo)
        Me.Controls.Add(Me.txtFven)
        Me.Controls.Add(Me.txtVen)
        Me.Controls.Add(Me.txtTap)
        Me.Controls.Add(Me.txtSant)
        Me.Controls.Add(Me.lblPlazomax)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.txtPlazo)
        Me.Controls.Add(Me.txtMonto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambiarPlazo"
        Me.Text = "Cambio de Plazo Créditos Tradicionales"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtSant As System.Windows.Forms.TextBox
    Friend WithEvents txtTap As System.Windows.Forms.TextBox
    Friend WithEvents txtVen As System.Windows.Forms.TextBox
    Friend WithEvents txtFven As System.Windows.Forms.TextBox
    Friend WithEvents txtPzo As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblAdeudoant As System.Windows.Forms.Label
    Friend WithEvents txtAde As System.Windows.Forms.TextBox
    Friend WithEvents txtRow As System.Windows.Forms.TextBox
    Friend WithEvents TxtStatus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGrid2 As DataGrid
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSaldoInsoluto As TextBox
End Class
