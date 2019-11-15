<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepoColocaAV
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboSucursal = New System.Windows.Forms.ComboBox()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportesDS = New Agil.ReportesDS()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.CmbDB = New System.Windows.Forms.ComboBox()
        Me.BtnProc = New System.Windows.Forms.Button()
        Me.SucursalesTableAdapter = New Agil.ReportesDSTableAdapters.SucursalesTableAdapter()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TiparDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GarantiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoContratosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpColocacionAvioResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpColocacionAvioDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_ColocacionAvioDetalleTableAdapter = New Agil.ReportesDSTableAdapters.sp_ColocacionAvioDetalleTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sp_ColocacionAvioResumenTableAdapter = New Agil.ReportesDSTableAdapters.sp_ColocacionAvioResumenTableAdapter()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpColocacionAvioResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpColocacionAvioDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Sucursal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboSucursal
        '
        Me.ComboSucursal.DataSource = Me.SucursalesBindingSource
        Me.ComboSucursal.DisplayMember = "Nombre_Sucursal"
        Me.ComboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSucursal.FormattingEnabled = True
        Me.ComboSucursal.Location = New System.Drawing.Point(185, 12)
        Me.ComboSucursal.Name = "ComboSucursal"
        Me.ComboSucursal.Size = New System.Drawing.Size(121, 21)
        Me.ComboSucursal.TabIndex = 42
        Me.ComboSucursal.ValueMember = "ID_Sucursal"
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.ReportesDS
        '
        'ReportesDS
        '
        Me.ReportesDS.DataSetName = "ReportesDS"
        Me.ReportesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DTPFecha
        '
        Me.DTPFecha.Enabled = False
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(393, 13)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(98, 20)
        Me.DTPFecha.TabIndex = 43
        '
        'CmbDB
        '
        Me.CmbDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDB.FormattingEnabled = True
        Me.CmbDB.Location = New System.Drawing.Point(6, 13)
        Me.CmbDB.Name = "CmbDB"
        Me.CmbDB.Size = New System.Drawing.Size(121, 21)
        Me.CmbDB.TabIndex = 41
        '
        'BtnProc
        '
        Me.BtnProc.Location = New System.Drawing.Point(312, 11)
        Me.BtnProc.Name = "BtnProc"
        Me.BtnProc.Size = New System.Drawing.Size(75, 23)
        Me.BtnProc.TabIndex = 40
        Me.BtnProc.Text = "Procesar"
        Me.BtnProc.UseVisualStyleBackColor = True
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(6, 40)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(952, 398)
        Me.CrystalReportViewer1.TabIndex = 45
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TiparDataGridViewTextBoxColumn, Me.CicloDataGridViewTextBoxColumn, Me.SucursalDataGridViewTextBoxColumn, Me.AvioDataGridViewTextBoxColumn, Me.FegaDataGridViewTextBoxColumn, Me.GarantiaDataGridViewTextBoxColumn, Me.NoContratosDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SpColocacionAvioResumenBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 444)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(952, 69)
        Me.DataGridView1.TabIndex = 46
        '
        'TiparDataGridViewTextBoxColumn
        '
        Me.TiparDataGridViewTextBoxColumn.DataPropertyName = "Tipar"
        Me.TiparDataGridViewTextBoxColumn.HeaderText = "Tipar"
        Me.TiparDataGridViewTextBoxColumn.Name = "TiparDataGridViewTextBoxColumn"
        Me.TiparDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CicloDataGridViewTextBoxColumn
        '
        Me.CicloDataGridViewTextBoxColumn.DataPropertyName = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.HeaderText = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.Name = "CicloDataGridViewTextBoxColumn"
        Me.CicloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SucursalDataGridViewTextBoxColumn
        '
        Me.SucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.Name = "SucursalDataGridViewTextBoxColumn"
        Me.SucursalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AvioDataGridViewTextBoxColumn
        '
        Me.AvioDataGridViewTextBoxColumn.DataPropertyName = "Avio"
        Me.AvioDataGridViewTextBoxColumn.HeaderText = "Avio"
        Me.AvioDataGridViewTextBoxColumn.Name = "AvioDataGridViewTextBoxColumn"
        Me.AvioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FegaDataGridViewTextBoxColumn
        '
        Me.FegaDataGridViewTextBoxColumn.DataPropertyName = "Fega"
        Me.FegaDataGridViewTextBoxColumn.HeaderText = "Fega"
        Me.FegaDataGridViewTextBoxColumn.Name = "FegaDataGridViewTextBoxColumn"
        Me.FegaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GarantiaDataGridViewTextBoxColumn
        '
        Me.GarantiaDataGridViewTextBoxColumn.DataPropertyName = "Garantia"
        Me.GarantiaDataGridViewTextBoxColumn.HeaderText = "Garantia"
        Me.GarantiaDataGridViewTextBoxColumn.Name = "GarantiaDataGridViewTextBoxColumn"
        Me.GarantiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoContratosDataGridViewTextBoxColumn
        '
        Me.NoContratosDataGridViewTextBoxColumn.DataPropertyName = "NoContratos"
        Me.NoContratosDataGridViewTextBoxColumn.HeaderText = "NoContratos"
        Me.NoContratosDataGridViewTextBoxColumn.Name = "NoContratosDataGridViewTextBoxColumn"
        Me.NoContratosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpColocacionAvioResumenBindingSource
        '
        Me.SpColocacionAvioResumenBindingSource.DataMember = "sp_ColocacionAvioResumen"
        Me.SpColocacionAvioResumenBindingSource.DataSource = Me.ReportesDS
        '
        'SpColocacionAvioDetalleBindingSource
        '
        Me.SpColocacionAvioDetalleBindingSource.DataMember = "sp_ColocacionAvioDetalle"
        Me.SpColocacionAvioDetalleBindingSource.DataSource = Me.ReportesDS
        '
        'Sp_ColocacionAvioDetalleTableAdapter
        '
        Me.Sp_ColocacionAvioDetalleTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.DataGridView2.DataSource = Me.SpColocacionAvioDetalleBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(6, 519)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(952, 69)
        Me.DataGridView2.TabIndex = 47
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Tipar"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipar"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ciclo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ciclo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Sucursal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sucursal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Avio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Avio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fega"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fega"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Garantia"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Garantia"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Anexo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Anexo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Concepto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Concepto"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Consecutivo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Consecutivo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Fondeo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Fondeo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Promotor"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Promotor"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FechaTerminacion"
        Me.DataGridViewTextBoxColumn14.HeaderText = "FechaTerminacion"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Cultivo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Cultivo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "HectareasActual"
        Me.DataGridViewTextBoxColumn16.HeaderText = "HectareasActual"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'Sp_ColocacionAvioResumenTableAdapter
        '
        Me.Sp_ColocacionAvioResumenTableAdapter.ClearBeforeFill = True
        '
        'frmRepoColocaAV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 597)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboSucursal)
        Me.Controls.Add(Me.DTPFecha)
        Me.Controls.Add(Me.CmbDB)
        Me.Controls.Add(Me.BtnProc)
        Me.Name = "frmRepoColocaAV"
        Me.Text = "Reporte de Colocación Avio"
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpColocacionAvioResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpColocacionAvioDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents ComboSucursal As ComboBox
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents CmbDB As ComboBox
    Friend WithEvents BtnProc As Button
    Friend WithEvents SucursalesBindingSource As BindingSource
    Friend WithEvents ReportesDS As ReportesDS
    Friend WithEvents SucursalesTableAdapter As ReportesDSTableAdapters.SucursalesTableAdapter
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SpColocacionAvioDetalleBindingSource As BindingSource
    Friend WithEvents Sp_ColocacionAvioDetalleTableAdapter As ReportesDSTableAdapters.sp_ColocacionAvioDetalleTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents TiparDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AvioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GarantiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoContratosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpColocacionAvioResumenBindingSource As BindingSource
    Friend WithEvents Sp_ColocacionAvioResumenTableAdapter As ReportesDSTableAdapters.sp_ColocacionAvioResumenTableAdapter
End Class
