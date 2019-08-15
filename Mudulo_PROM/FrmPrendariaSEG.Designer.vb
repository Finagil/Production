<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrendariaSEG
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
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGarantia = New System.Windows.Forms.RichTextBox()
        Me.txtAnexo = New System.Windows.Forms.TextBox()
        Me.lblGarantia = New System.Windows.Forms.Label()
        Me.lblContrato = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCusnam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorGarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPrendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeguroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS = New Agil.PromocionDS()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.ButtonDEL = New System.Windows.Forms.Button()
        Me.ButtonSAVE = New System.Windows.Forms.Button()
        Me.ButtonEXIT = New System.Windows.Forms.Button()
        Me.PrendaTableAdapter = New Agil.PromocionDSTableAdapters.PrendaTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(547, 55)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(417, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Valor de la(s) Garantía(s)"
        '
        'txtGarantia
        '
        Me.txtGarantia.AcceptsTab = True
        Me.txtGarantia.Location = New System.Drawing.Point(12, 78)
        Me.txtGarantia.Name = "txtGarantia"
        Me.txtGarantia.Size = New System.Drawing.Size(635, 129)
        Me.txtGarantia.TabIndex = 17
        Me.txtGarantia.TabStop = False
        Me.txtGarantia.Text = ""
        '
        'txtAnexo
        '
        Me.txtAnexo.Location = New System.Drawing.Point(73, 32)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.ReadOnly = True
        Me.txtAnexo.Size = New System.Drawing.Size(80, 20)
        Me.txtAnexo.TabIndex = 21
        Me.txtAnexo.TabStop = False
        '
        'lblGarantia
        '
        Me.lblGarantia.Location = New System.Drawing.Point(12, 58)
        Me.lblGarantia.Name = "lblGarantia"
        Me.lblGarantia.Size = New System.Drawing.Size(152, 16)
        Me.lblGarantia.TabIndex = 20
        Me.lblGarantia.Text = "Descripción la(s) Garantía(s)"
        '
        'lblContrato
        '
        Me.lblContrato.Location = New System.Drawing.Point(12, 35)
        Me.lblContrato.Name = "lblContrato"
        Me.lblContrato.Size = New System.Drawing.Size(48, 16)
        Me.lblContrato.TabIndex = 19
        Me.lblContrato.Text = "Contrato"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(12, 9)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(56, 16)
        Me.lblCliente.TabIndex = 18
        Me.lblCliente.Text = "Cliente"
        '
        'txtCusnam
        '
        Me.txtCusnam.Location = New System.Drawing.Point(73, 6)
        Me.txtCusnam.Name = "txtCusnam"
        Me.txtCusnam.ReadOnly = True
        Me.txtCusnam.Size = New System.Drawing.Size(536, 20)
        Me.txtCusnam.TabIndex = 16
        Me.txtCusnam.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Garantias para Asegurar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.PrendaDataGridViewTextBoxColumn, Me.ValorGarDataGridViewTextBoxColumn, Me.IDPrendaDataGridViewTextBoxColumn, Me.SeguroDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PrendaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 230)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(632, 150)
        Me.DataGridView1.TabIndex = 25
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.Width = 80
        '
        'PrendaDataGridViewTextBoxColumn
        '
        Me.PrendaDataGridViewTextBoxColumn.DataPropertyName = "Prenda"
        Me.PrendaDataGridViewTextBoxColumn.HeaderText = "Prenda"
        Me.PrendaDataGridViewTextBoxColumn.Name = "PrendaDataGridViewTextBoxColumn"
        Me.PrendaDataGridViewTextBoxColumn.Width = 400
        '
        'ValorGarDataGridViewTextBoxColumn
        '
        Me.ValorGarDataGridViewTextBoxColumn.DataPropertyName = "ValorGar"
        Me.ValorGarDataGridViewTextBoxColumn.HeaderText = "Valor"
        Me.ValorGarDataGridViewTextBoxColumn.Name = "ValorGarDataGridViewTextBoxColumn"
        '
        'IDPrendaDataGridViewTextBoxColumn
        '
        Me.IDPrendaDataGridViewTextBoxColumn.DataPropertyName = "IDPrenda"
        Me.IDPrendaDataGridViewTextBoxColumn.HeaderText = "IDPrenda"
        Me.IDPrendaDataGridViewTextBoxColumn.Name = "IDPrendaDataGridViewTextBoxColumn"
        Me.IDPrendaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPrendaDataGridViewTextBoxColumn.Visible = False
        '
        'SeguroDataGridViewTextBoxColumn
        '
        Me.SeguroDataGridViewTextBoxColumn.DataPropertyName = "Seguro"
        Me.SeguroDataGridViewTextBoxColumn.HeaderText = "Seguro"
        Me.SeguroDataGridViewTextBoxColumn.Name = "SeguroDataGridViewTextBoxColumn"
        Me.SeguroDataGridViewTextBoxColumn.Visible = False
        '
        'PrendaBindingSource
        '
        Me.PrendaBindingSource.DataMember = "Prenda"
        Me.PrendaBindingSource.DataSource = Me.PromocionDS
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonNew
        '
        Me.ButtonNew.Location = New System.Drawing.Point(15, 386)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNew.TabIndex = 26
        Me.ButtonNew.Text = "Nuevo"
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'ButtonDEL
        '
        Me.ButtonDEL.Location = New System.Drawing.Point(96, 386)
        Me.ButtonDEL.Name = "ButtonDEL"
        Me.ButtonDEL.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDEL.TabIndex = 27
        Me.ButtonDEL.Text = "Borrar"
        Me.ButtonDEL.UseVisualStyleBackColor = True
        '
        'ButtonSAVE
        '
        Me.ButtonSAVE.Location = New System.Drawing.Point(177, 386)
        Me.ButtonSAVE.Name = "ButtonSAVE"
        Me.ButtonSAVE.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSAVE.TabIndex = 28
        Me.ButtonSAVE.Text = "Guardar"
        Me.ButtonSAVE.UseVisualStyleBackColor = True
        '
        'ButtonEXIT
        '
        Me.ButtonEXIT.Location = New System.Drawing.Point(572, 386)
        Me.ButtonEXIT.Name = "ButtonEXIT"
        Me.ButtonEXIT.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEXIT.TabIndex = 29
        Me.ButtonEXIT.Text = "Salir"
        Me.ButtonEXIT.UseVisualStyleBackColor = True
        '
        'PrendaTableAdapter
        '
        Me.PrendaTableAdapter.ClearBeforeFill = True
        '
        'FrmPrendariaSEG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 417)
        Me.Controls.Add(Me.ButtonEXIT)
        Me.Controls.Add(Me.ButtonSAVE)
        Me.Controls.Add(Me.ButtonDEL)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGarantia)
        Me.Controls.Add(Me.txtAnexo)
        Me.Controls.Add(Me.lblGarantia)
        Me.Controls.Add(Me.lblContrato)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtCusnam)
        Me.Name = "FrmPrendariaSEG"
        Me.Text = "Captura de Garatias prendarias para Asegurar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGarantia As RichTextBox
    Friend WithEvents txtAnexo As TextBox
    Friend WithEvents lblGarantia As Label
    Friend WithEvents lblContrato As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtCusnam As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonNew As Button
    Friend WithEvents ButtonDEL As Button
    Friend WithEvents ButtonSAVE As Button
    Friend WithEvents ButtonEXIT As Button
    Friend WithEvents PrendaBindingSource As BindingSource
    Friend WithEvents PromocionDS As PromocionDS
    Friend WithEvents PrendaTableAdapter As PromocionDSTableAdapters.PrendaTableAdapter
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrendaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorGarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDPrendaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeguroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
