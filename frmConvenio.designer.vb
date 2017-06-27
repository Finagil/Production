<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvenio
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
        Me.txtNameFP = New System.Windows.Forms.TextBox
        Me.txtRepFP = New System.Windows.Forms.TextBox
        Me.txtGeneRep = New System.Windows.Forms.TextBox
        Me.txtFacultadesRep = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnImpConv = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.btnNvaFP = New System.Windows.Forms.Button
        Me.btnModif = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtDatos = New System.Windows.Forms.TextBox
        Me.txtModo = New System.Windows.Forms.TextBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtNameFP
        '
        Me.txtNameFP.Location = New System.Drawing.Point(58, 72)
        Me.txtNameFP.Name = "txtNameFP"
        Me.txtNameFP.Size = New System.Drawing.Size(594, 20)
        Me.txtNameFP.TabIndex = 0
        Me.txtNameFP.Visible = False
        '
        'txtRepFP
        '
        Me.txtRepFP.Location = New System.Drawing.Point(58, 125)
        Me.txtRepFP.Name = "txtRepFP"
        Me.txtRepFP.Size = New System.Drawing.Size(594, 20)
        Me.txtRepFP.TabIndex = 1
        '
        'txtGeneRep
        '
        Me.txtGeneRep.AccessibleDescription = "Text box containing the text to write to or text read from a file."
        Me.txtGeneRep.AccessibleName = "File Text TextBox"
        Me.txtGeneRep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGeneRep.Location = New System.Drawing.Point(58, 182)
        Me.txtGeneRep.Multiline = True
        Me.txtGeneRep.Name = "txtGeneRep"
        Me.txtGeneRep.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGeneRep.Size = New System.Drawing.Size(770, 103)
        Me.txtGeneRep.TabIndex = 14
        '
        'txtFacultadesRep
        '
        Me.txtFacultadesRep.AccessibleDescription = "Text box containing the text to write to or text read from a file."
        Me.txtFacultadesRep.AccessibleName = "File Text TextBox"
        Me.txtFacultadesRep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFacultadesRep.Location = New System.Drawing.Point(58, 327)
        Me.txtFacultadesRep.Multiline = True
        Me.txtFacultadesRep.Name = "txtFacultadesRep"
        Me.txtFacultadesRep.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFacultadesRep.Size = New System.Drawing.Size(770, 122)
        Me.txtFacultadesRep.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre Fuente de Pago"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre del Representante Fuente de Pago"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Generalesl Representante Fuente de Pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Facultades Representante Fuente de Pago"
        '
        'btnImpConv
        '
        Me.btnImpConv.Location = New System.Drawing.Point(666, 461)
        Me.btnImpConv.Name = "btnImpConv"
        Me.btnImpConv.Size = New System.Drawing.Size(75, 23)
        Me.btnImpConv.TabIndex = 20
        Me.btnImpConv.Text = "Imprimir"
        Me.btnImpConv.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(58, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(594, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'btnNvaFP
        '
        Me.btnNvaFP.Location = New System.Drawing.Point(753, 44)
        Me.btnNvaFP.Name = "btnNvaFP"
        Me.btnNvaFP.Size = New System.Drawing.Size(75, 23)
        Me.btnNvaFP.TabIndex = 22
        Me.btnNvaFP.Text = "Nueva F.P."
        Me.btnNvaFP.UseVisualStyleBackColor = True
        '
        'btnModif
        '
        Me.btnModif.Location = New System.Drawing.Point(492, 461)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(75, 23)
        Me.btnModif.TabIndex = 23
        Me.btnModif.Text = "Modificar"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(578, 461)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtDatos
        '
        Me.txtDatos.Location = New System.Drawing.Point(58, 464)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(11, 20)
        Me.txtDatos.TabIndex = 25
        Me.txtDatos.Visible = False
        '
        'txtModo
        '
        Me.txtModo.Location = New System.Drawing.Point(75, 464)
        Me.txtModo.Name = "txtModo"
        Me.txtModo.Size = New System.Drawing.Size(11, 20)
        Me.txtModo.TabIndex = 26
        Me.txtModo.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(753, 461)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 27
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 496)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtModo)
        Me.Controls.Add(Me.txtDatos)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnNvaFP)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnImpConv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFacultadesRep)
        Me.Controls.Add(Me.txtGeneRep)
        Me.Controls.Add(Me.txtRepFP)
        Me.Controls.Add(Me.txtNameFP)
        Me.Name = "frmConvenio"
        Me.Text = "Datos para Convenio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNameFP As System.Windows.Forms.TextBox
    Friend WithEvents txtRepFP As System.Windows.Forms.TextBox
    Friend WithEvents txtGeneRep As System.Windows.Forms.TextBox
    Friend WithEvents txtFacultadesRep As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnImpConv As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnNvaFP As System.Windows.Forms.Button
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtDatos As System.Windows.Forms.TextBox
    Friend WithEvents txtModo As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
