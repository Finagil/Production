<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConciliacionCartera
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConciliacionCartera))
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnProceso = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoCortoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteCortoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoLargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteLargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarteraGlobalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContaDS = New Agil.ContaDS()
        Me.CmbDB = New System.Windows.Forms.ComboBox()
        Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarteraGlobalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTPFecha
        '
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(238, 15)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(112, 20)
        Me.DTPFecha.TabIndex = 3
        '
        'btnProceso
        '
        Me.btnProceso.Location = New System.Drawing.Point(139, 14)
        Me.btnProceso.Name = "btnProceso"
        Me.btnProceso.Size = New System.Drawing.Size(93, 23)
        Me.btnProceso.TabIndex = 2
        Me.btnProceso.Text = "Procesar"
        Me.btnProceso.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.InteresDataGridViewTextBoxColumn, Me.PartesDataGridViewTextBoxColumn, Me.OrigenDataGridViewTextBoxColumn, Me.MontoCortoDataGridViewTextBoxColumn, Me.InteCortoDataGridViewTextBoxColumn, Me.MontoLargoDataGridViewTextBoxColumn, Me.InteLargoDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.FechaContratoDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CarteraGlobalBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 494)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(989, 71)
        Me.DataGridView1.TabIndex = 27
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoCreditoDataGridViewTextBoxColumn
        '
        Me.TipoCreditoDataGridViewTextBoxColumn.DataPropertyName = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InteresDataGridViewTextBoxColumn
        '
        Me.InteresDataGridViewTextBoxColumn.DataPropertyName = "Interes"
        Me.InteresDataGridViewTextBoxColumn.HeaderText = "Interes"
        Me.InteresDataGridViewTextBoxColumn.Name = "InteresDataGridViewTextBoxColumn"
        Me.InteresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PartesDataGridViewTextBoxColumn
        '
        Me.PartesDataGridViewTextBoxColumn.DataPropertyName = "Partes"
        Me.PartesDataGridViewTextBoxColumn.HeaderText = "Partes"
        Me.PartesDataGridViewTextBoxColumn.Name = "PartesDataGridViewTextBoxColumn"
        Me.PartesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrigenDataGridViewTextBoxColumn
        '
        Me.OrigenDataGridViewTextBoxColumn.DataPropertyName = "Origen"
        Me.OrigenDataGridViewTextBoxColumn.HeaderText = "Origen"
        Me.OrigenDataGridViewTextBoxColumn.Name = "OrigenDataGridViewTextBoxColumn"
        Me.OrigenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoCortoDataGridViewTextBoxColumn
        '
        Me.MontoCortoDataGridViewTextBoxColumn.DataPropertyName = "Monto Corto"
        Me.MontoCortoDataGridViewTextBoxColumn.HeaderText = "Monto Corto"
        Me.MontoCortoDataGridViewTextBoxColumn.Name = "MontoCortoDataGridViewTextBoxColumn"
        Me.MontoCortoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InteCortoDataGridViewTextBoxColumn
        '
        Me.InteCortoDataGridViewTextBoxColumn.DataPropertyName = "Inte Corto"
        Me.InteCortoDataGridViewTextBoxColumn.HeaderText = "Inte Corto"
        Me.InteCortoDataGridViewTextBoxColumn.Name = "InteCortoDataGridViewTextBoxColumn"
        Me.InteCortoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoLargoDataGridViewTextBoxColumn
        '
        Me.MontoLargoDataGridViewTextBoxColumn.DataPropertyName = "Monto Largo"
        Me.MontoLargoDataGridViewTextBoxColumn.HeaderText = "Monto Largo"
        Me.MontoLargoDataGridViewTextBoxColumn.Name = "MontoLargoDataGridViewTextBoxColumn"
        Me.MontoLargoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InteLargoDataGridViewTextBoxColumn
        '
        Me.InteLargoDataGridViewTextBoxColumn.DataPropertyName = "Inte Largo"
        Me.InteLargoDataGridViewTextBoxColumn.HeaderText = "Inte Largo"
        Me.InteLargoDataGridViewTextBoxColumn.Name = "InteLargoDataGridViewTextBoxColumn"
        Me.InteLargoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaContratoDataGridViewTextBoxColumn
        '
        Me.FechaContratoDataGridViewTextBoxColumn.DataPropertyName = "FechaContrato"
        Me.FechaContratoDataGridViewTextBoxColumn.HeaderText = "FechaContrato"
        Me.FechaContratoDataGridViewTextBoxColumn.Name = "FechaContratoDataGridViewTextBoxColumn"
        Me.FechaContratoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaVencimientoDataGridViewTextBoxColumn
        '
        Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "FechaVencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
        Me.FechaVencimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CarteraGlobalBindingSource
        '
        Me.CarteraGlobalBindingSource.DataMember = "CarteraGlobal"
        Me.CarteraGlobalBindingSource.DataSource = Me.ContaDS
        '
        'ContaDS
        '
        Me.ContaDS.DataSetName = "ContaDS"
        Me.ContaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbDB
        '
        Me.CmbDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDB.FormattingEnabled = True
        Me.CmbDB.Location = New System.Drawing.Point(12, 16)
        Me.CmbDB.Name = "CmbDB"
        Me.CmbDB.Size = New System.Drawing.Size(121, 21)
        Me.CmbDB.TabIndex = 1
        '
        'CRViewer
        '
        Me.CRViewer.ActiveViewIndex = -1
        Me.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewer.Location = New System.Drawing.Point(12, 43)
        Me.CRViewer.Name = "CRViewer"
        Me.CRViewer.Size = New System.Drawing.Size(989, 445)
        Me.CRViewer.TabIndex = 28
        Me.CRViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmCarteraGlobal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 577)
        Me.Controls.Add(Me.CRViewer)
        Me.Controls.Add(Me.CmbDB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnProceso)
        Me.Controls.Add(Me.DTPFecha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCarteraGlobal"
        Me.Text = "Reporte Integral de la Cartera"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarteraGlobalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnProceso As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InteresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PartesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrigenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoCortoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InteCortoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoLargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InteLargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaContratoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataColumn1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarteraGlobalBindingSource As BindingSource
    Friend WithEvents ContaDS As ContaDS
    Friend WithEvents CmbDB As ComboBox
    Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
