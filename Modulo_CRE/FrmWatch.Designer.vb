<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWatch
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
        Me.Txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.CmbClie = New System.Windows.Forms.ComboBox()
        Me.ContClie1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New Agil.ProductionDataSet()
        Me.ContClie1TableAdapter = New Agil.ProductionDataSetTableAdapters.ContClie1TableAdapter()
        Me.ListClie = New System.Windows.Forms.ListBox()
        Me.BCWatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditoDS = New Agil.CreditoDS()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BC_WatchTableAdapter = New Agil.CreditoDSTableAdapters.BC_WatchTableAdapter()
        Me.ButtonADD = New System.Windows.Forms.Button()
        Me.ButtonDEL = New System.Windows.Forms.Button()
        Me.ButtonSEND = New System.Windows.Forms.Button()
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCWatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtfiltro
        '
        Me.Txtfiltro.Location = New System.Drawing.Point(15, 28)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(424, 20)
        Me.Txtfiltro.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 16)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Filtro"
        '
        'lblClientes
        '
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(12, 50)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(346, 16)
        Me.lblClientes.TabIndex = 61
        Me.lblClientes.Text = "Selecciona un Cliente de la siguiente Lista"
        '
        'CmbClie
        '
        Me.CmbClie.DataSource = Me.ContClie1BindingSource
        Me.CmbClie.DisplayMember = "Descr"
        Me.CmbClie.Location = New System.Drawing.Point(15, 69)
        Me.CmbClie.MaxDropDownItems = 25
        Me.CmbClie.Name = "CmbClie"
        Me.CmbClie.Size = New System.Drawing.Size(424, 21)
        Me.CmbClie.TabIndex = 62
        Me.CmbClie.ValueMember = "Cliente"
        '
        'ContClie1BindingSource
        '
        Me.ContClie1BindingSource.DataMember = "ContClie1"
        Me.ContClie1BindingSource.DataSource = Me.ProductionDataSet
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContClie1TableAdapter
        '
        Me.ContClie1TableAdapter.ClearBeforeFill = True
        '
        'ListClie
        '
        Me.ListClie.DataSource = Me.BCWatchBindingSource
        Me.ListClie.DisplayMember = "Cliente"
        Me.ListClie.FormattingEnabled = True
        Me.ListClie.Location = New System.Drawing.Point(12, 165)
        Me.ListClie.Name = "ListClie"
        Me.ListClie.Size = New System.Drawing.Size(427, 394)
        Me.ListClie.TabIndex = 64
        Me.ListClie.ValueMember = "id_Watch"
        '
        'BCWatchBindingSource
        '
        Me.BCWatchBindingSource.DataMember = "BC_Watch"
        Me.BCWatchBindingSource.DataSource = Me.CreditoDS
        '
        'CreditoDS
        '
        Me.CreditoDS.DataSetName = "CreditoDS"
        Me.CreditoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 16)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Lista de Clientes WATCH"
        '
        'BC_WatchTableAdapter
        '
        Me.BC_WatchTableAdapter.ClearBeforeFill = True
        '
        'ButtonADD
        '
        Me.ButtonADD.Location = New System.Drawing.Point(364, 93)
        Me.ButtonADD.Name = "ButtonADD"
        Me.ButtonADD.Size = New System.Drawing.Size(75, 23)
        Me.ButtonADD.TabIndex = 66
        Me.ButtonADD.Text = "Agregar"
        Me.ButtonADD.UseVisualStyleBackColor = True
        '
        'ButtonDEL
        '
        Me.ButtonDEL.Location = New System.Drawing.Point(283, 139)
        Me.ButtonDEL.Name = "ButtonDEL"
        Me.ButtonDEL.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDEL.TabIndex = 67
        Me.ButtonDEL.Text = "Eliminar"
        Me.ButtonDEL.UseVisualStyleBackColor = True
        '
        'ButtonSEND
        '
        Me.ButtonSEND.Location = New System.Drawing.Point(364, 139)
        Me.ButtonSEND.Name = "ButtonSEND"
        Me.ButtonSEND.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSEND.TabIndex = 68
        Me.ButtonSEND.Text = "Enviar"
        Me.ButtonSEND.UseVisualStyleBackColor = True
        '
        'FrmWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 568)
        Me.Controls.Add(Me.ButtonSEND)
        Me.Controls.Add(Me.ButtonDEL)
        Me.Controls.Add(Me.ButtonADD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListClie)
        Me.Controls.Add(Me.Txtfiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.CmbClie)
        Me.Name = "FrmWatch"
        Me.Text = "Watch Alta de Clientes"
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCWatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtfiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClientes As Label
    Friend WithEvents CmbClie As ComboBox
    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents ContClie1BindingSource As BindingSource
    Friend WithEvents ContClie1TableAdapter As ProductionDataSetTableAdapters.ContClie1TableAdapter
    Friend WithEvents ListClie As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CreditoDS As CreditoDS
    Friend WithEvents BCWatchBindingSource As BindingSource
    Friend WithEvents BC_WatchTableAdapter As CreditoDSTableAdapters.BC_WatchTableAdapter
    Friend WithEvents ButtonADD As Button
    Friend WithEvents ButtonDEL As Button
    Friend WithEvents ButtonSEND As Button
End Class
