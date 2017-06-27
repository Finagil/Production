<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSubePagosAV
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VWPAgosAvioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TesoreriaDS = New Agil.TesoreriaDS()
        Me.BtnFile = New System.Windows.Forms.Button()
        Me.BtnUp = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.VW_PAgosAvioTableAdapter = New Agil.TesoreriaDSTableAdapters.VW_PAgosAvioTableAdapter()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinistracionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConfirmadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aplicado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWPAgosAvioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TesoreriaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteDataGridViewTextBoxColumn, Me.AnexoDataGridViewTextBoxColumn, Me.CicloDataGridViewTextBoxColumn, Me.MinistracionDataGridViewTextBoxColumn, Me.ReferenciaDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.ConfirmadoDataGridViewCheckBoxColumn, Me.id_pago, Me.Aplicado})
        Me.DataGridView1.DataSource = Me.VWPAgosAvioBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(928, 570)
        Me.DataGridView1.TabIndex = 0
        '
        'VWPAgosAvioBindingSource
        '
        Me.VWPAgosAvioBindingSource.DataMember = "VW_PAgosAvio"
        Me.VWPAgosAvioBindingSource.DataSource = Me.TesoreriaDS
        '
        'TesoreriaDS
        '
        Me.TesoreriaDS.DataSetName = "TesoreriaDS"
        Me.TesoreriaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnFile
        '
        Me.BtnFile.Location = New System.Drawing.Point(13, 590)
        Me.BtnFile.Name = "BtnFile"
        Me.BtnFile.Size = New System.Drawing.Size(126, 23)
        Me.BtnFile.TabIndex = 1
        Me.BtnFile.Text = "Cargar Archivo"
        Me.BtnFile.UseVisualStyleBackColor = True
        '
        'BtnUp
        '
        Me.BtnUp.Enabled = False
        Me.BtnUp.Location = New System.Drawing.Point(620, 590)
        Me.BtnUp.Name = "BtnUp"
        Me.BtnUp.Size = New System.Drawing.Size(96, 23)
        Me.BtnUp.TabIndex = 3
        Me.BtnUp.Text = "Subir Pagos"
        Me.BtnUp.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(759, 590)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(132, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(722, 595)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total"
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.Location = New System.Drawing.Point(518, 590)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(96, 23)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancelar "
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'VW_PAgosAvioTableAdapter
        '
        Me.VW_PAgosAvioTableAdapter.ClearBeforeFill = True
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 150
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Width = 90
        '
        'CicloDataGridViewTextBoxColumn
        '
        Me.CicloDataGridViewTextBoxColumn.DataPropertyName = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.HeaderText = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.Name = "CicloDataGridViewTextBoxColumn"
        Me.CicloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MinistracionDataGridViewTextBoxColumn
        '
        Me.MinistracionDataGridViewTextBoxColumn.DataPropertyName = "Ministracion"
        Me.MinistracionDataGridViewTextBoxColumn.HeaderText = "Ministracion"
        Me.MinistracionDataGridViewTextBoxColumn.Name = "MinistracionDataGridViewTextBoxColumn"
        Me.MinistracionDataGridViewTextBoxColumn.ReadOnly = True
        Me.MinistracionDataGridViewTextBoxColumn.Width = 80
        '
        'ReferenciaDataGridViewTextBoxColumn
        '
        Me.ReferenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.Name = "ReferenciaDataGridViewTextBoxColumn"
        Me.ReferenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaPagoDataGridViewTextBoxColumn
        '
        Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago"
        Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "Fecha Pago"
        Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
        Me.FechaPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaPagoDataGridViewTextBoxColumn.Width = 120
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "n2"
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Width = 80
        '
        'ConfirmadoDataGridViewCheckBoxColumn
        '
        Me.ConfirmadoDataGridViewCheckBoxColumn.DataPropertyName = "Confirmado"
        Me.ConfirmadoDataGridViewCheckBoxColumn.HeaderText = "Confirmado"
        Me.ConfirmadoDataGridViewCheckBoxColumn.Name = "ConfirmadoDataGridViewCheckBoxColumn"
        Me.ConfirmadoDataGridViewCheckBoxColumn.Width = 70
        '
        'id_pago
        '
        Me.id_pago.DataPropertyName = "id_pago"
        Me.id_pago.HeaderText = "id_pago"
        Me.id_pago.Name = "id_pago"
        Me.id_pago.ReadOnly = True
        Me.id_pago.Visible = False
        '
        'Aplicado
        '
        Me.Aplicado.DataPropertyName = "Aplicado"
        Me.Aplicado.HeaderText = "Aplicado"
        Me.Aplicado.Name = "Aplicado"
        Me.Aplicado.ReadOnly = True
        Me.Aplicado.Width = 70
        '
        'FrmSubePagosAV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 624)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnUp)
        Me.Controls.Add(Me.BtnFile)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmSubePagosAV"
        Me.Text = "Subir Pagos de Avio"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWPAgosAvioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TesoreriaDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TesoreriaDS As TesoreriaDS
    Friend WithEvents VWPAgosAvioBindingSource As BindingSource
    Friend WithEvents VW_PAgosAvioTableAdapter As TesoreriaDSTableAdapters.VW_PAgosAvioTableAdapter
    Friend WithEvents BtnFile As Button
    Friend WithEvents BtnUp As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinistracionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConfirmadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents id_pago As DataGridViewTextBoxColumn
    Friend WithEvents Aplicado As DataGridViewCheckBoxColumn
End Class
