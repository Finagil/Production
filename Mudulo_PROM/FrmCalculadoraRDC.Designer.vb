<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalculadoraRDC
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
        Dim PagoPasivosLabel As System.Windows.Forms.Label
        Dim IngresosAdicionalesLabel As System.Windows.Forms.Label
        Dim PasivosLabel As System.Windows.Forms.Label
        Dim SalarioNetoLabel As System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalIngresosMensuales = New System.Windows.Forms.TextBox()
        Me.PagoPasivosTextBox = New System.Windows.Forms.TextBox()
        Me.IngresosAdicionalesTextBox = New System.Windows.Forms.TextBox()
        Me.PasivosTextBox = New System.Windows.Forms.TextBox()
        Me.SalarioNetoTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbClaves = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmboAtrasos = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbExpe = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPagofin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        PagoPasivosLabel = New System.Windows.Forms.Label()
        IngresosAdicionalesLabel = New System.Windows.Forms.Label()
        PasivosLabel = New System.Windows.Forms.Label()
        SalarioNetoLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PagoPasivosLabel
        '
        PagoPasivosLabel.AutoSize = True
        PagoPasivosLabel.Location = New System.Drawing.Point(252, 215)
        PagoPasivosLabel.Name = "PagoPasivosLabel"
        PagoPasivosLabel.Size = New System.Drawing.Size(75, 13)
        PagoPasivosLabel.TabIndex = 85
        PagoPasivosLabel.Text = "Pago Pasivos:"
        '
        'IngresosAdicionalesLabel
        '
        IngresosAdicionalesLabel.AutoSize = True
        IngresosAdicionalesLabel.Location = New System.Drawing.Point(14, 218)
        IngresosAdicionalesLabel.Name = "IngresosAdicionalesLabel"
        IngresosAdicionalesLabel.Size = New System.Drawing.Size(107, 13)
        IngresosAdicionalesLabel.TabIndex = 84
        IngresosAdicionalesLabel.Text = "Ingresos Adicionales:"
        '
        'PasivosLabel
        '
        PasivosLabel.AutoSize = True
        PasivosLabel.Location = New System.Drawing.Point(253, 189)
        PasivosLabel.Name = "PasivosLabel"
        PasivosLabel.Size = New System.Drawing.Size(74, 13)
        PasivosLabel.TabIndex = 83
        PasivosLabel.Text = "Total Pasivos:"
        '
        'SalarioNetoLabel
        '
        SalarioNetoLabel.AutoSize = True
        SalarioNetoLabel.Location = New System.Drawing.Point(53, 192)
        SalarioNetoLabel.Name = "SalarioNetoLabel"
        SalarioNetoLabel.Size = New System.Drawing.Size(68, 13)
        SalarioNetoLabel.TabIndex = 82
        SalarioNetoLabel.Text = "Salario Neto:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(87, 244)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "Total:"
        '
        'txtTotalIngresosMensuales
        '
        Me.txtTotalIngresosMensuales.Location = New System.Drawing.Point(127, 241)
        Me.txtTotalIngresosMensuales.Name = "txtTotalIngresosMensuales"
        Me.txtTotalIngresosMensuales.ReadOnly = True
        Me.txtTotalIngresosMensuales.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalIngresosMensuales.TabIndex = 87
        '
        'PagoPasivosTextBox
        '
        Me.PagoPasivosTextBox.Location = New System.Drawing.Point(333, 212)
        Me.PagoPasivosTextBox.Name = "PagoPasivosTextBox"
        Me.PagoPasivosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PagoPasivosTextBox.TabIndex = 86
        Me.PagoPasivosTextBox.Text = "0"
        '
        'IngresosAdicionalesTextBox
        '
        Me.IngresosAdicionalesTextBox.Location = New System.Drawing.Point(127, 215)
        Me.IngresosAdicionalesTextBox.Name = "IngresosAdicionalesTextBox"
        Me.IngresosAdicionalesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IngresosAdicionalesTextBox.TabIndex = 70
        Me.IngresosAdicionalesTextBox.Text = "0"
        '
        'PasivosTextBox
        '
        Me.PasivosTextBox.Location = New System.Drawing.Point(333, 186)
        Me.PasivosTextBox.Name = "PasivosTextBox"
        Me.PasivosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasivosTextBox.TabIndex = 71
        Me.PasivosTextBox.Text = "0"
        '
        'SalarioNetoTextBox
        '
        Me.SalarioNetoTextBox.Location = New System.Drawing.Point(127, 189)
        Me.SalarioNetoTextBox.Name = "SalarioNetoTextBox"
        Me.SalarioNetoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalarioNetoTextBox.TabIndex = 69
        Me.SalarioNetoTextBox.Text = "0"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(174, 288)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(170, 20)
        Me.TextBox4.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(171, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Estatus"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 13)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Claves de Prevención BC."
        '
        'CmbClaves
        '
        Me.CmbClaves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClaves.FormattingEnabled = True
        Me.CmbClaves.Items.AddRange(New Object() {"SIN CLAVES DE PREVENCIÓN", "CON CLAVES DE PREVENCION = COMUNICACIONES", "CON CLAVES DE PREVENCIÓN <> COMUNICACIONES"})
        Me.CmbClaves.Location = New System.Drawing.Point(14, 67)
        Me.CmbClaves.Name = "CmbClaves"
        Me.CmbClaves.Size = New System.Drawing.Size(418, 21)
        Me.CmbClaves.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Atrasos Vigentes BC."
        '
        'CmboAtrasos
        '
        Me.CmboAtrasos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboAtrasos.FormattingEnabled = True
        Me.CmboAtrasos.Items.AddRange(New Object() {"SIN ATRASOS VIGENTES", "CON ATRASOS VIGENTES < AL 10% DEL MONTO SOLICITADO DE HASTA 29 DÍAS", "CON ATRASOS VIGENTES > AL 10% DEL MONTO SOLICITADO DE HASTA 29 DÍAS"})
        Me.CmboAtrasos.Location = New System.Drawing.Point(14, 149)
        Me.CmboAtrasos.Name = "CmboAtrasos"
        Me.CmboAtrasos.Size = New System.Drawing.Size(418, 21)
        Me.CmboAtrasos.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Experiencia de Pago BC."
        '
        'CmbExpe
        '
        Me.CmbExpe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbExpe.FormattingEnabled = True
        Me.CmbExpe.Items.AddRange(New Object() {"PAGOS PUNTUALES/SIN EXPERIENCIA", "HASTA 10 ATRASOS DE HASTA 29 DÍAS", "DESDE 11 ATRASOS DE HASTA 29 DÍAS"})
        Me.CmbExpe.Location = New System.Drawing.Point(14, 109)
        Me.CmbExpe.Name = "CmbExpe"
        Me.CmbExpe.Size = New System.Drawing.Size(418, 21)
        Me.CmbExpe.TabIndex = 67
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(121, 288)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(47, 20)
        Me.TextBox6.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(118, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "RCD"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(350, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Calcular RDC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(252, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 13)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Egresos netos (BC y Otros)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Ingresos Netos"
        '
        'TxtPagofin
        '
        Me.TxtPagofin.Location = New System.Drawing.Point(14, 27)
        Me.TxtPagofin.Name = "TxtPagofin"
        Me.TxtPagofin.Size = New System.Drawing.Size(100, 20)
        Me.TxtPagofin.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Pago Finagil"
        '
        'DtpFechaIngreso
        '
        Me.DtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIngreso.Location = New System.Drawing.Point(120, 27)
        Me.DtpFechaIngreso.Name = "DtpFechaIngreso"
        Me.DtpFechaIngreso.Size = New System.Drawing.Size(100, 20)
        Me.DtpFechaIngreso.TabIndex = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Fecha Ingreso"
        '
        'FrmCalculadoraRDC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 315)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtpFechaIngreso)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTotalIngresosMensuales)
        Me.Controls.Add(PagoPasivosLabel)
        Me.Controls.Add(Me.PagoPasivosTextBox)
        Me.Controls.Add(IngresosAdicionalesLabel)
        Me.Controls.Add(Me.IngresosAdicionalesTextBox)
        Me.Controls.Add(PasivosLabel)
        Me.Controls.Add(Me.PasivosTextBox)
        Me.Controls.Add(SalarioNetoLabel)
        Me.Controls.Add(Me.SalarioNetoTextBox)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CmbClaves)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CmboAtrasos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmbExpe)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtPagofin)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FrmCalculadoraRDC"
        Me.Text = "Calculadora RDC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotalIngresosMensuales As TextBox
    Friend WithEvents PagoPasivosTextBox As TextBox
    Friend WithEvents IngresosAdicionalesTextBox As TextBox
    Friend WithEvents PasivosTextBox As TextBox
    Friend WithEvents SalarioNetoTextBox As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CmbClaves As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CmboAtrasos As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbExpe As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPagofin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DtpFechaIngreso As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
