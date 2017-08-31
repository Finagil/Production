<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTiposCambio
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
        Me.ComboMoneda = New System.Windows.Forms.ComboBox()
        Me.MonedasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContaDS = New Agil.ContaDS()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPmoneda = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTipoCambio = New System.Windows.Forms.TextBox()
        Me.TiposDeCambioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.MonedasTableAdapter = New Agil.ContaDSTableAdapters.MonedasTableAdapter()
        Me.TiposDeCambioTableAdapter = New Agil.ContaDSTableAdapters.TiposDeCambioTableAdapter()
        Me.BtnNew = New System.Windows.Forms.Button()
        CType(Me.MonedasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDeCambioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboMoneda
        '
        Me.ComboMoneda.DataSource = Me.MonedasBindingSource
        Me.ComboMoneda.DisplayMember = "Titulo"
        Me.ComboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMoneda.FormattingEnabled = True
        Me.ComboMoneda.Location = New System.Drawing.Point(12, 25)
        Me.ComboMoneda.Name = "ComboMoneda"
        Me.ComboMoneda.Size = New System.Drawing.Size(179, 21)
        Me.ComboMoneda.TabIndex = 0
        Me.ComboMoneda.ValueMember = "Moneda"
        '
        'MonedasBindingSource
        '
        Me.MonedasBindingSource.DataMember = "Monedas"
        Me.MonedasBindingSource.DataSource = Me.ContaDS
        '
        'ContaDS
        '
        Me.ContaDS.DataSetName = "ContaDS"
        Me.ContaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Moneda"
        '
        'DTPmoneda
        '
        Me.DTPmoneda.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPmoneda.Location = New System.Drawing.Point(12, 52)
        Me.DTPmoneda.Name = "DTPmoneda"
        Me.DTPmoneda.Size = New System.Drawing.Size(179, 20)
        Me.DTPmoneda.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MonedasBindingSource, "PesosPor", True))
        Me.Label2.Location = New System.Drawing.Point(67, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pesos por "
        '
        'TxtTipoCambio
        '
        Me.TxtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiposDeCambioBindingSource, "TipoCambio", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N4"))
        Me.TxtTipoCambio.Location = New System.Drawing.Point(70, 95)
        Me.TxtTipoCambio.Name = "TxtTipoCambio"
        Me.TxtTipoCambio.Size = New System.Drawing.Size(121, 20)
        Me.TxtTipoCambio.TabIndex = 4
        '
        'TiposDeCambioBindingSource
        '
        Me.TiposDeCambioBindingSource.DataMember = "TiposDeCambio"
        Me.TiposDeCambioBindingSource.DataSource = Me.ContaDS
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(104, 121)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(87, 23)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'MonedasTableAdapter
        '
        Me.MonedasTableAdapter.ClearBeforeFill = True
        '
        'TiposDeCambioTableAdapter
        '
        Me.TiposDeCambioTableAdapter.ClearBeforeFill = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(11, 120)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(87, 23)
        Me.BtnNew.TabIndex = 6
        Me.BtnNew.Text = "Nuevo"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'FrmTiposCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 155)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtTipoCambio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTPmoneda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboMoneda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTiposCambio"
        Me.Text = "Tipos de Cambio"
        CType(Me.MonedasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDeCambioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboMoneda As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPmoneda As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTipoCambio As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents ContaDS As ContaDS
    Friend WithEvents MonedasBindingSource As BindingSource
    Friend WithEvents MonedasTableAdapter As ContaDSTableAdapters.MonedasTableAdapter
    Friend WithEvents TiposDeCambioBindingSource As BindingSource
    Friend WithEvents TiposDeCambioTableAdapter As ContaDSTableAdapters.TiposDeCambioTableAdapter
    Friend WithEvents BtnNew As Button
End Class
