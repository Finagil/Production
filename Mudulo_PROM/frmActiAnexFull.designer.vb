<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActiAnexFull
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
        Me.TxtContMarco = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cReportTitle = New System.Windows.Forms.TextBox
        Me.txtPrenda = New System.Windows.Forms.TextBox
        Me.txtCusnam = New System.Windows.Forms.TextBox
        Me.txtAnexo = New System.Windows.Forms.TextBox
        Me.btnCtom = New System.Windows.Forms.Button
        Me.btnACto = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.BtnDatosVehi = New System.Windows.Forms.Button
        Me.btnActivar = New System.Windows.Forms.Button
        Me.BtnFPC = New System.Windows.Forms.Button
        Me.btnAvisoP = New System.Windows.Forms.Button
        Me.BtnPagare = New System.Windows.Forms.Button
        Me.BtnPld = New System.Windows.Forms.Button
        Me.BtnHoja = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TxtContMarco
        '
        Me.TxtContMarco.Location = New System.Drawing.Point(838, 18)
        Me.TxtContMarco.Name = "TxtContMarco"
        Me.TxtContMarco.ReadOnly = True
        Me.TxtContMarco.Size = New System.Drawing.Size(130, 20)
        Me.TxtContMarco.TabIndex = 138
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(719, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "No. de Contrato Marco"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cReportTitle
        '
        Me.cReportTitle.Location = New System.Drawing.Point(681, 18)
        Me.cReportTitle.Name = "cReportTitle"
        Me.cReportTitle.Size = New System.Drawing.Size(16, 20)
        Me.cReportTitle.TabIndex = 136
        Me.cReportTitle.Visible = False
        '
        'txtPrenda
        '
        Me.txtPrenda.Location = New System.Drawing.Point(657, 18)
        Me.txtPrenda.Name = "txtPrenda"
        Me.txtPrenda.Size = New System.Drawing.Size(16, 20)
        Me.txtPrenda.TabIndex = 135
        Me.txtPrenda.Visible = False
        '
        'txtCusnam
        '
        Me.txtCusnam.Enabled = False
        Me.txtCusnam.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusnam.Location = New System.Drawing.Point(105, 18)
        Me.txtCusnam.Name = "txtCusnam"
        Me.txtCusnam.Size = New System.Drawing.Size(504, 21)
        Me.txtCusnam.TabIndex = 134
        '
        'txtAnexo
        '
        Me.txtAnexo.Enabled = False
        Me.txtAnexo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnexo.Location = New System.Drawing.Point(17, 18)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.Size = New System.Drawing.Size(72, 21)
        Me.txtAnexo.TabIndex = 133
        '
        'btnCtom
        '
        Me.btnCtom.Location = New System.Drawing.Point(134, 70)
        Me.btnCtom.Name = "btnCtom"
        Me.btnCtom.Size = New System.Drawing.Size(100, 36)
        Me.btnCtom.TabIndex = 2
        Me.btnCtom.Text = " Contrato Maestro "
        '
        'btnACto
        '
        Me.btnACto.Location = New System.Drawing.Point(239, 70)
        Me.btnACto.Name = "btnACto"
        Me.btnACto.Size = New System.Drawing.Size(100, 36)
        Me.btnACto.TabIndex = 3
        Me.btnACto.Text = " Anexos Contrato. "
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(871, 70)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 36)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        '
        'BtnDatosVehi
        '
        Me.BtnDatosVehi.Location = New System.Drawing.Point(659, 70)
        Me.BtnDatosVehi.Name = "BtnDatosVehi"
        Me.BtnDatosVehi.Size = New System.Drawing.Size(100, 36)
        Me.BtnDatosVehi.TabIndex = 7
        Me.BtnDatosVehi.Text = "Datos Vehículo "
        '
        'btnActivar
        '
        Me.btnActivar.Location = New System.Drawing.Point(29, 70)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(100, 36)
        Me.btnActivar.TabIndex = 1
        Me.btnActivar.Text = "Activar"
        '
        'BtnFPC
        '
        Me.BtnFPC.Location = New System.Drawing.Point(449, 70)
        Me.BtnFPC.Name = "BtnFPC"
        Me.BtnFPC.Size = New System.Drawing.Size(100, 36)
        Me.BtnFPC.TabIndex = 5
        Me.BtnFPC.Text = "Promesa de Compra"
        '
        'btnAvisoP
        '
        Me.btnAvisoP.Location = New System.Drawing.Point(554, 70)
        Me.btnAvisoP.Name = "btnAvisoP"
        Me.btnAvisoP.Size = New System.Drawing.Size(100, 36)
        Me.btnAvisoP.TabIndex = 6
        Me.btnAvisoP.Text = "Aviso de Privacidad"
        '
        'BtnPagare
        '
        Me.BtnPagare.Location = New System.Drawing.Point(344, 70)
        Me.BtnPagare.Name = "BtnPagare"
        Me.BtnPagare.Size = New System.Drawing.Size(100, 36)
        Me.BtnPagare.TabIndex = 4
        Me.BtnPagare.Text = "Pagaré"
        '
        'BtnPld
        '
        Me.BtnPld.Location = New System.Drawing.Point(765, 70)
        Me.BtnPld.Name = "BtnPld"
        Me.BtnPld.Size = New System.Drawing.Size(100, 36)
        Me.BtnPld.TabIndex = 9
        Me.BtnPld.Text = "Docs. PLD"
        '
        'BtnHoja
        '
        Me.BtnHoja.Location = New System.Drawing.Point(659, 112)
        Me.BtnHoja.Name = "BtnHoja"
        Me.BtnHoja.Size = New System.Drawing.Size(100, 36)
        Me.BtnHoja.TabIndex = 8
        Me.BtnHoja.Text = "Hoja Datos "
        '
        'frmActiAnexFull
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 155)
        Me.Controls.Add(Me.BtnHoja)
        Me.Controls.Add(Me.BtnPld)
        Me.Controls.Add(Me.BtnPagare)
        Me.Controls.Add(Me.btnAvisoP)
        Me.Controls.Add(Me.BtnFPC)
        Me.Controls.Add(Me.btnActivar)
        Me.Controls.Add(Me.BtnDatosVehi)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCtom)
        Me.Controls.Add(Me.btnACto)
        Me.Controls.Add(Me.TxtContMarco)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cReportTitle)
        Me.Controls.Add(Me.txtPrenda)
        Me.Controls.Add(Me.txtCusnam)
        Me.Controls.Add(Me.txtAnexo)
        Me.Name = "frmActiAnexFull"
        Me.Text = "Acticación de Contratos FULL Service"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtContMarco As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cReportTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenda As System.Windows.Forms.TextBox
    Friend WithEvents txtCusnam As System.Windows.Forms.TextBox
    Friend WithEvents txtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents btnCtom As System.Windows.Forms.Button
    Friend WithEvents btnACto As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnDatosVehi As Button
    Friend WithEvents btnActivar As Button
    Friend WithEvents BtnFPC As Button
    Friend WithEvents btnAvisoP As Button
    Friend WithEvents BtnPagare As Button
    Friend WithEvents BtnPld As System.Windows.Forms.Button
    Friend WithEvents BtnHoja As System.Windows.Forms.Button
End Class
