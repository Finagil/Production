<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNoDomiciliarAviso
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnADD = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AvisoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FevenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwNoDomiciliarAvisoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JuridicoDS = New Agil.JuridicoDS()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Vw_NoDomiciliarAvisoTableAdapter = New Agil.JuridicoDSTableAdapters.Vw_NoDomiciliarAvisoTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwNoDomiciliarAvisoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No Aviso"
        '
        'BtnADD
        '
        Me.BtnADD.Location = New System.Drawing.Point(119, 31)
        Me.BtnADD.Name = "BtnADD"
        Me.BtnADD.Size = New System.Drawing.Size(75, 23)
        Me.BtnADD.TabIndex = 2
        Me.BtnADD.Text = "Agregar"
        Me.BtnADD.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AvisoDataGridViewTextBoxColumn, Me.AnexoDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn, Me.LetraDataGridViewTextBoxColumn, Me.FevenDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VwNoDomiciliarAvisoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(902, 225)
        Me.DataGridView1.TabIndex = 3
        '
        'AvisoDataGridViewTextBoxColumn
        '
        Me.AvisoDataGridViewTextBoxColumn.DataPropertyName = "Aviso"
        Me.AvisoDataGridViewTextBoxColumn.HeaderText = "Aviso"
        Me.AvisoDataGridViewTextBoxColumn.Name = "AvisoDataGridViewTextBoxColumn"
        Me.AvisoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AvisoDataGridViewTextBoxColumn.Width = 80
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Width = 80
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 250
        '
        'TipoCreditoDataGridViewTextBoxColumn
        '
        Me.TipoCreditoDataGridViewTextBoxColumn.DataPropertyName = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "Tipo Crédito"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCreditoDataGridViewTextBoxColumn.Width = 200
        '
        'LetraDataGridViewTextBoxColumn
        '
        Me.LetraDataGridViewTextBoxColumn.DataPropertyName = "Letra"
        Me.LetraDataGridViewTextBoxColumn.HeaderText = "Letra"
        Me.LetraDataGridViewTextBoxColumn.Name = "LetraDataGridViewTextBoxColumn"
        Me.LetraDataGridViewTextBoxColumn.ReadOnly = True
        Me.LetraDataGridViewTextBoxColumn.Width = 50
        '
        'FevenDataGridViewTextBoxColumn
        '
        Me.FevenDataGridViewTextBoxColumn.DataPropertyName = "Feven"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FevenDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FevenDataGridViewTextBoxColumn.HeaderText = "Vencimiento"
        Me.FevenDataGridViewTextBoxColumn.Name = "FevenDataGridViewTextBoxColumn"
        Me.FevenDataGridViewTextBoxColumn.ReadOnly = True
        Me.FevenDataGridViewTextBoxColumn.Width = 90
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwNoDomiciliarAvisoBindingSource
        '
        Me.VwNoDomiciliarAvisoBindingSource.DataMember = "Vw_NoDomiciliarAviso"
        Me.VwNoDomiciliarAvisoBindingSource.DataSource = Me.JuridicoDS
        '
        'JuridicoDS
        '
        Me.JuridicoDS.DataSetName = "JuridicoDS"
        Me.JuridicoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(820, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Borrar Aviso"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Vw_NoDomiciliarAvisoTableAdapter
        '
        Me.Vw_NoDomiciliarAvisoTableAdapter.ClearBeforeFill = True
        '
        'FrmNoDomiciliarAviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 318)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnADD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "FrmNoDomiciliarAviso"
        Me.Text = "No Domiciliar Aviso de Vencimiento"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwNoDomiciliarAvisoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnADD As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents JuridicoDS As JuridicoDS
    Friend WithEvents VwNoDomiciliarAvisoBindingSource As BindingSource
    Friend WithEvents Vw_NoDomiciliarAvisoTableAdapter As JuridicoDSTableAdapters.Vw_NoDomiciliarAvisoTableAdapter
    Friend WithEvents AvisoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LetraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FevenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
