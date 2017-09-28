<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambioTasa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtDif = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTipoTasa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDifNew = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTasaNew = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCambiar = New System.Windows.Forms.Button()
        Me.TxtStatus = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtDif
        '
        Me.TxtDif.Location = New System.Drawing.Point(83, 32)
        Me.TxtDif.Name = "TxtDif"
        Me.TxtDif.ReadOnly = True
        Me.TxtDif.Size = New System.Drawing.Size(64, 20)
        Me.TxtDif.TabIndex = 89
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(80, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Diff."
        '
        'TxtTasa
        '
        Me.TxtTasa.Location = New System.Drawing.Point(9, 32)
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.ReadOnly = True
        Me.TxtTasa.Size = New System.Drawing.Size(68, 20)
        Me.TxtTasa.TabIndex = 87
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Tasa"
        '
        'TxtTipoTasa
        '
        Me.TxtTipoTasa.Location = New System.Drawing.Point(153, 32)
        Me.TxtTipoTasa.Name = "TxtTipoTasa"
        Me.TxtTipoTasa.ReadOnly = True
        Me.TxtTipoTasa.Size = New System.Drawing.Size(70, 20)
        Me.TxtTipoTasa.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(150, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Tipo Tasa"
        '
        'TxtDifNew
        '
        Me.TxtDifNew.Location = New System.Drawing.Point(379, 32)
        Me.TxtDifNew.Name = "TxtDifNew"
        Me.TxtDifNew.Size = New System.Drawing.Size(64, 20)
        Me.TxtDifNew.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Diff. Nvo."
        '
        'TxtTasaNew
        '
        Me.TxtTasaNew.Location = New System.Drawing.Point(305, 32)
        Me.TxtTasaNew.Name = "TxtTasaNew"
        Me.TxtTasaNew.Size = New System.Drawing.Size(68, 20)
        Me.TxtTasaNew.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Tasa Nva."
        '
        'BtnCambiar
        '
        Me.BtnCambiar.Location = New System.Drawing.Point(449, 30)
        Me.BtnCambiar.Name = "BtnCambiar"
        Me.BtnCambiar.Size = New System.Drawing.Size(97, 23)
        Me.BtnCambiar.TabIndex = 95
        Me.BtnCambiar.Text = "Cambiar Tasa"
        Me.BtnCambiar.UseVisualStyleBackColor = True
        '
        'TxtStatus
        '
        Me.TxtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStatus.Location = New System.Drawing.Point(229, 32)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.ReadOnly = True
        Me.TxtStatus.Size = New System.Drawing.Size(70, 20)
        Me.TxtStatus.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(226, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Nuevo Estatus"
        '
        'FrmCambioTasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 65)
        Me.Controls.Add(Me.TxtStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCambiar)
        Me.Controls.Add(Me.TxtDifNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTasaNew)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDif)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtTasa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTipoTasa)
        Me.Controls.Add(Me.Label5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCambioTasa"
        Me.Text = "Cambio de Tasa Contrato:"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtDif As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtTasa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTipoTasa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDifNew As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTasaNew As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCambiar As Button
    Friend WithEvents TxtStatus As TextBox
    Friend WithEvents Label3 As Label
End Class
