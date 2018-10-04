<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosPLD
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
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.txtFiel = New System.Windows.Forms.TextBox()
        Me.txtNacion = New System.Windows.Forms.TextBox()
        Me.txtPaisNac = New System.Windows.Forms.TextBox()
        Me.mtxtCURP = New System.Windows.Forms.MaskedTextBox()
        Me.txtDescTipo = New System.Windows.Forms.TextBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtDescr = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCopos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtTipoAs = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.mtxtColonia = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDeleg = New System.Windows.Forms.Label()
        Me.txtDelegacion = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.txtNint = New System.Windows.Forms.TextBox()
        Me.txtNext = New System.Windows.Forms.TextBox()
        Me.cbCopos = New System.Windows.Forms.ComboBox()
        Me.lblPostal = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEdoNac = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbGenero
        '
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Items.AddRange(New Object() {"Masculino", "Femenino", "No Aplica", "   "})
        Me.cbGenero.Location = New System.Drawing.Point(733, 44)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(94, 21)
        Me.cbGenero.TabIndex = 94
        '
        'txtFiel
        '
        Me.txtFiel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiel.Location = New System.Drawing.Point(858, 45)
        Me.txtFiel.MaxLength = 20
        Me.txtFiel.Name = "txtFiel"
        Me.txtFiel.Size = New System.Drawing.Size(152, 20)
        Me.txtFiel.TabIndex = 93
        Me.txtFiel.TabStop = False
        '
        'txtNacion
        '
        Me.txtNacion.Location = New System.Drawing.Point(563, 44)
        Me.txtNacion.MaxLength = 50
        Me.txtNacion.Name = "txtNacion"
        Me.txtNacion.Size = New System.Drawing.Size(152, 20)
        Me.txtNacion.TabIndex = 92
        Me.txtNacion.TabStop = False
        '
        'txtPaisNac
        '
        Me.txtPaisNac.Location = New System.Drawing.Point(184, 43)
        Me.txtPaisNac.Name = "txtPaisNac"
        Me.txtPaisNac.Size = New System.Drawing.Size(152, 20)
        Me.txtPaisNac.TabIndex = 91
        Me.txtPaisNac.TabStop = False
        '
        'mtxtCURP
        '
        Me.mtxtCURP.BeepOnError = True
        Me.mtxtCURP.Location = New System.Drawing.Point(21, 44)
        Me.mtxtCURP.Name = "mtxtCURP"
        Me.mtxtCURP.Size = New System.Drawing.Size(128, 20)
        Me.mtxtCURP.TabIndex = 90
        '
        'txtDescTipo
        '
        Me.txtDescTipo.Location = New System.Drawing.Point(91, 48)
        Me.txtDescTipo.Name = "txtDescTipo"
        Me.txtDescTipo.ReadOnly = True
        Me.txtDescTipo.Size = New System.Drawing.Size(504, 20)
        Me.txtDescTipo.TabIndex = 89
        Me.txtDescTipo.TabStop = False
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(-140, 259)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(56, 16)
        Me.lblTipo.TabIndex = 88
        Me.lblTipo.Text = "Tipo"
        Me.lblTipo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(91, 24)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.ReadOnly = True
        Me.txtDescr.Size = New System.Drawing.Size(504, 20)
        Me.txtDescr.TabIndex = 87
        Me.txtDescr.TabStop = False
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(-140, 235)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(56, 16)
        Me.lblName.TabIndex = 86
        Me.lblName.Text = "Nombre"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Tipo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(730, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 101
        Me.Label20.Text = "Genero"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(855, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 100
        Me.Label17.Text = "Serie Fiel"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(561, 27)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 99
        Me.Label18.Text = "Nacionalidad"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(184, 27)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 13)
        Me.Label19.TabIndex = 98
        Me.Label19.Text = "Pais de Nacimiento"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "CURP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtCopos
        '
        Me.txtCopos.Location = New System.Drawing.Point(798, 107)
        Me.txtCopos.MaxLength = 5
        Me.txtCopos.Name = "txtCopos"
        Me.txtCopos.Size = New System.Drawing.Size(10, 20)
        Me.txtCopos.TabIndex = 126
        Me.txtCopos.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 457)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 13)
        Me.Label13.TabIndex = 125
        Me.Label13.Text = "Actividad Económica"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(168, 455)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(422, 21)
        Me.ComboBox1.TabIndex = 124
        '
        'txtTipoAs
        '
        Me.txtTipoAs.AcceptsReturn = True
        Me.txtTipoAs.Location = New System.Drawing.Point(642, 368)
        Me.txtTipoAs.Name = "txtTipoAs"
        Me.txtTipoAs.ReadOnly = True
        Me.txtTipoAs.Size = New System.Drawing.Size(342, 20)
        Me.txtTipoAs.TabIndex = 123
        Me.txtTipoAs.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(535, 398)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 122
        Me.Label16.Text = "Ciudad"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(534, 373)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 121
        Me.Label15.Text = "Tipo Asent."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 372)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 120
        Me.Label14.Text = "Asentamiento"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCity
        '
        Me.txtCity.AcceptsReturn = True
        Me.txtCity.Location = New System.Drawing.Point(643, 393)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(342, 20)
        Me.txtCity.TabIndex = 119
        Me.txtCity.TabStop = False
        '
        'mtxtColonia
        '
        Me.mtxtColonia.BeepOnError = True
        Me.mtxtColonia.Location = New System.Drawing.Point(167, 368)
        Me.mtxtColonia.Name = "mtxtColonia"
        Me.mtxtColonia.ReadOnly = True
        Me.mtxtColonia.Size = New System.Drawing.Size(342, 20)
        Me.mtxtColonia.TabIndex = 115
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "Estado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeleg
        '
        Me.lblDeleg.AutoSize = True
        Me.lblDeleg.Location = New System.Drawing.Point(20, 396)
        Me.lblDeleg.Name = "lblDeleg"
        Me.lblDeleg.Size = New System.Drawing.Size(118, 13)
        Me.lblDeleg.TabIndex = 117
        Me.lblDeleg.Text = "Delegación o Municipio"
        Me.lblDeleg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDelegacion
        '
        Me.txtDelegacion.Location = New System.Drawing.Point(167, 394)
        Me.txtDelegacion.MaxLength = 45
        Me.txtDelegacion.Name = "txtDelegacion"
        Me.txtDelegacion.ReadOnly = True
        Me.txtDelegacion.Size = New System.Drawing.Size(342, 20)
        Me.txtDelegacion.TabIndex = 116
        Me.txtDelegacion.TabStop = False
        '
        'txtEstado
        '
        Me.txtEstado.AcceptsReturn = True
        Me.txtEstado.Location = New System.Drawing.Point(167, 420)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(342, 20)
        Me.txtEstado.TabIndex = 114
        Me.txtEstado.TabStop = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(677, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "No. Interior"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(561, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "No. Exterior"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(21, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "DOMICILIO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(21, 136)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(1002, 226)
        Me.DataGrid1.TabIndex = 110
        Me.DataGrid1.TabStop = False
        Me.DataGrid1.Visible = False
        '
        'txtNint
        '
        Me.txtNint.Location = New System.Drawing.Point(680, 107)
        Me.txtNint.MaxLength = 7
        Me.txtNint.Name = "txtNint"
        Me.txtNint.Size = New System.Drawing.Size(93, 20)
        Me.txtNint.TabIndex = 109
        Me.txtNint.TabStop = False
        '
        'txtNext
        '
        Me.txtNext.Location = New System.Drawing.Point(564, 107)
        Me.txtNext.MaxLength = 5
        Me.txtNext.Name = "txtNext"
        Me.txtNext.Size = New System.Drawing.Size(93, 20)
        Me.txtNext.TabIndex = 108
        Me.txtNext.TabStop = False
        '
        'cbCopos
        '
        Me.cbCopos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCopos.Location = New System.Drawing.Point(817, 107)
        Me.cbCopos.Name = "cbCopos"
        Me.cbCopos.Size = New System.Drawing.Size(73, 21)
        Me.cbCopos.TabIndex = 107
        '
        'lblPostal
        '
        Me.lblPostal.Location = New System.Drawing.Point(814, 88)
        Me.lblPostal.Name = "lblPostal"
        Me.lblPostal.Size = New System.Drawing.Size(83, 16)
        Me.lblPostal.TabIndex = 106
        Me.lblPostal.Text = "Código Postal"
        Me.lblPostal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCalle
        '
        Me.lblCalle.Location = New System.Drawing.Point(19, 88)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(64, 16)
        Me.lblCalle.TabIndex = 105
        Me.lblCalle.Text = "Calle"
        Me.lblCalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(22, 107)
        Me.txtCalle.MaxLength = 90
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(504, 20)
        Me.txtCalle.TabIndex = 104
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Estado donde Nacio"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEdoNac
        '
        Me.txtEdoNac.Location = New System.Drawing.Point(369, 43)
        Me.txtEdoNac.MaxLength = 50
        Me.txtEdoNac.Name = "txtEdoNac"
        Me.txtEdoNac.Size = New System.Drawing.Size(152, 20)
        Me.txtEdoNac.TabIndex = 102
        Me.txtEdoNac.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(958, 585)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 32)
        Me.btnCancelar.TabIndex = 104
        Me.btnCancelar.Text = "Salir"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(848, 586)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(96, 32)
        Me.btnActualizar.TabIndex = 103
        Me.btnActualizar.Text = "Guardar Datos"
        '
        'txtPassword
        '
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPassword.Location = New System.Drawing.Point(700, 580)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(10, 20)
        Me.txtPassword.TabIndex = 110
        Me.txtPassword.TabStop = False
        Me.txtPassword.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtCopos)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.txtPaisNac)
        Me.GroupBox1.Controls.Add(Me.txtTipoAs)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cbGenero)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.txtFiel)
        Me.GroupBox1.Controls.Add(Me.mtxtColonia)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNacion)
        Me.GroupBox1.Controls.Add(Me.lblDeleg)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtDelegacion)
        Me.GroupBox1.Controls.Add(Me.mtxtCURP)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtEdoNac)
        Me.GroupBox1.Controls.Add(Me.DataGrid1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCalle)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblCalle)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblPostal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbCopos)
        Me.GroupBox1.Controls.Add(Me.txtNext)
        Me.GroupBox1.Controls.Add(Me.txtNint)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1041, 494)
        Me.GroupBox1.TabIndex = 111
        Me.GroupBox1.TabStop = False
        '
        'frmDatosPLD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 628)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescTipo)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.txtDescr)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmDatosPLD"
        Me.Text = "Captura de Datos para PLD"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbGenero As System.Windows.Forms.ComboBox
    Friend WithEvents txtFiel As System.Windows.Forms.TextBox
    Friend WithEvents txtNacion As System.Windows.Forms.TextBox
    Friend WithEvents txtPaisNac As System.Windows.Forms.TextBox
    Friend WithEvents mtxtCURP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDescTipo As System.Windows.Forms.TextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents txtDescr As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEdoNac As System.Windows.Forms.TextBox
    Friend WithEvents txtNint As System.Windows.Forms.TextBox
    Friend WithEvents txtNext As System.Windows.Forms.TextBox
    Friend WithEvents cbCopos As System.Windows.Forms.ComboBox
    Friend WithEvents lblPostal As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTipoAs As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents mtxtColonia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDeleg As System.Windows.Forms.Label
    Friend WithEvents txtDelegacion As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtCopos As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
