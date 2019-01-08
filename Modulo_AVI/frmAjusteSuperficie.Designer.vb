<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjusteSuperficie
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
        Me.components = New System.ComponentModel.Container()
        Me.txtAnexo = New System.Windows.Forms.MaskedTextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupAjustes = New System.Windows.Forms.GroupBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txtusuario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAjustar = New System.Windows.Forms.Button()
        Me.TxtnewLine = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtSuperficie = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VWAjustesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AviosDSX = New Agil.AviosDSX()
        Me.VW_AjustesTableAdapter = New Agil.AviosDSXTableAdapters.VW_AjustesTableAdapter()
        Me.GroupAjustes.SuspendLayout()
        CType(Me.VWAjustesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAnexo
        '
        Me.txtAnexo.Location = New System.Drawing.Point(13, 13)
        Me.txtAnexo.Mask = "00000/0000"
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.Size = New System.Drawing.Size(74, 20)
        Me.txtAnexo.TabIndex = 0
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(93, 10)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 1
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'GroupAjustes
        '
        Me.GroupAjustes.Controls.Add(Me.TextBox10)
        Me.GroupAjustes.Controls.Add(Me.Label10)
        Me.GroupAjustes.Controls.Add(Me.Txtusuario)
        Me.GroupAjustes.Controls.Add(Me.Label9)
        Me.GroupAjustes.Controls.Add(Me.BtnAjustar)
        Me.GroupAjustes.Controls.Add(Me.TxtnewLine)
        Me.GroupAjustes.Controls.Add(Me.Label8)
        Me.GroupAjustes.Controls.Add(Me.TxtSuperficie)
        Me.GroupAjustes.Controls.Add(Me.Label7)
        Me.GroupAjustes.Controls.Add(Me.TextBox6)
        Me.GroupAjustes.Controls.Add(Me.TextBox5)
        Me.GroupAjustes.Controls.Add(Me.TextBox4)
        Me.GroupAjustes.Controls.Add(Me.TextBox3)
        Me.GroupAjustes.Controls.Add(Me.TextBox2)
        Me.GroupAjustes.Controls.Add(Me.TextBox1)
        Me.GroupAjustes.Controls.Add(Me.Label6)
        Me.GroupAjustes.Controls.Add(Me.Label5)
        Me.GroupAjustes.Controls.Add(Me.Label4)
        Me.GroupAjustes.Controls.Add(Me.Label3)
        Me.GroupAjustes.Controls.Add(Me.Label2)
        Me.GroupAjustes.Controls.Add(Me.Label1)
        Me.GroupAjustes.Enabled = False
        Me.GroupAjustes.Location = New System.Drawing.Point(13, 40)
        Me.GroupAjustes.Name = "GroupAjustes"
        Me.GroupAjustes.Size = New System.Drawing.Size(693, 108)
        Me.GroupAjustes.TabIndex = 2
        Me.GroupAjustes.TabStop = False
        Me.GroupAjustes.Text = "Datos del Contrato"
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWAjustesBindingSource, "Cuota", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextBox10.Location = New System.Drawing.Point(215, 76)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(96, 20)
        Me.TextBox10.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(212, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Cuota por Hect."
        '
        'Txtusuario
        '
        Me.Txtusuario.Location = New System.Drawing.Point(611, 75)
        Me.Txtusuario.Name = "Txtusuario"
        Me.Txtusuario.ReadOnly = True
        Me.Txtusuario.Size = New System.Drawing.Size(72, 20)
        Me.Txtusuario.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(608, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Usuario"
        '
        'BtnAjustar
        '
        Me.BtnAjustar.Location = New System.Drawing.Point(524, 74)
        Me.BtnAjustar.Name = "BtnAjustar"
        Me.BtnAjustar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAjustar.TabIndex = 16
        Me.BtnAjustar.Text = "Ajustar"
        Me.BtnAjustar.UseVisualStyleBackColor = True
        '
        'TxtnewLine
        '
        Me.TxtnewLine.Location = New System.Drawing.Point(422, 76)
        Me.TxtnewLine.Name = "TxtnewLine"
        Me.TxtnewLine.ReadOnly = True
        Me.TxtnewLine.Size = New System.Drawing.Size(96, 20)
        Me.TxtnewLine.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(419, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Linea Nueva"
        '
        'TxtSuperficie
        '
        Me.TxtSuperficie.Location = New System.Drawing.Point(316, 76)
        Me.TxtSuperficie.Name = "TxtSuperficie"
        Me.TxtSuperficie.Size = New System.Drawing.Size(100, 20)
        Me.TxtSuperficie.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(313, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Superficie Nueva"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWAjustesBindingSource, "HectareasActual", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextBox6.Location = New System.Drawing.Point(113, 76)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(96, 20)
        Me.TextBox6.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWAjustesBindingSource, "LineaActual", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextBox5.Location = New System.Drawing.Point(11, 76)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(96, 20)
        Me.TextBox5.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWAjustesBindingSource, "Nombre_Sucursal", True))
        Me.TextBox4.Location = New System.Drawing.Point(558, 37)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(125, 20)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWAjustesBindingSource, "Descr", True))
        Me.TextBox3.Location = New System.Drawing.Point(177, 37)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(375, 20)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWAjustesBindingSource, "CicloPagare", True))
        Me.TextBox2.Location = New System.Drawing.Point(80, 37)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(91, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWAjustesBindingSource, "AnexoCon", True))
        Me.TextBox1.Location = New System.Drawing.Point(10, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(110, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Superficie Actual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Linea Actual"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(555, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sucursal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ciclo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Anexo"
        '
        'VWAjustesBindingSource
        '
        Me.VWAjustesBindingSource.DataMember = "VW_Ajustes"
        Me.VWAjustesBindingSource.DataSource = Me.AviosDSX
        '
        'AviosDSX
        '
        Me.AviosDSX.DataSetName = "AviosDSX"
        Me.AviosDSX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VW_AjustesTableAdapter
        '
        Me.VW_AjustesTableAdapter.ClearBeforeFill = True
        '
        'frmAjusteSuperficie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 159)
        Me.Controls.Add(Me.GroupAjustes)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.txtAnexo)
        Me.Name = "frmAjusteSuperficie"
        Me.Text = "Ajustes de Superficie Avio"
        Me.GroupAjustes.ResumeLayout(False)
        Me.GroupAjustes.PerformLayout()
        CType(Me.VWAjustesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAnexo As MaskedTextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents GroupAjustes As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnAjustar As Button
    Friend WithEvents TxtnewLine As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtSuperficie As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtusuario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents VWAjustesBindingSource As BindingSource
    Friend WithEvents AviosDSX As AviosDSX
    Friend WithEvents Label10 As Label
    Friend WithEvents VW_AjustesTableAdapter As AviosDSXTableAdapters.VW_AjustesTableAdapter
End Class
