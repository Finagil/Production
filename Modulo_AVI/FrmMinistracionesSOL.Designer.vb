<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMinistracionesSOL
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.BttMinistraciones = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Grid1 = New System.Windows.Forms.DataGridView
        Me.IDMinistracionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdsolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorcentajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AVIMinistracionesSolicitudesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AviosDSX = New Agil.AviosDSX
        Me.BttValidar = New System.Windows.Forms.Button
        Me.LbCAT = New System.Windows.Forms.Label
        Me.Grid2 = New System.Windows.Forms.DataGridView
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaIniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EfectivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BuroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GastosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeguroAgricolaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeguroVidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Garantia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Intereses = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoFinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoCuentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AVI_MinistracionesSolicitudesTableAdapter = New Agil.AviosDSXTableAdapters.AVI_MinistracionesSolicitudesTableAdapter
        Me.LbCATtir = New System.Windows.Forms.Label
        Me.LbCAT1min = New System.Windows.Forms.Label
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AVIMinistracionesSolicitudesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoCuentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BttMinistraciones
        '
        Me.BttMinistraciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttMinistraciones.Location = New System.Drawing.Point(796, 523)
        Me.BttMinistraciones.Name = "BttMinistraciones"
        Me.BttMinistraciones.Size = New System.Drawing.Size(79, 32)
        Me.BttMinistraciones.TabIndex = 120
        Me.BttMinistraciones.Text = "Guardar"
        Me.BttMinistraciones.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(881, 523)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 32)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Grid1
        '
        Me.Grid1.AllowUserToAddRows = False
        Me.Grid1.AllowUserToDeleteRows = False
        Me.Grid1.AutoGenerateColumns = False
        Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDMinistracionDataGridViewTextBoxColumn, Me.IdsolicitudDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.PorcentajeDataGridViewTextBoxColumn})
        Me.Grid1.DataSource = Me.AVIMinistracionesSolicitudesBindingSource
        Me.Grid1.Location = New System.Drawing.Point(12, 12)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(399, 201)
        Me.Grid1.TabIndex = 122
        '
        'IDMinistracionDataGridViewTextBoxColumn
        '
        Me.IDMinistracionDataGridViewTextBoxColumn.DataPropertyName = "ID_Ministracion"
        Me.IDMinistracionDataGridViewTextBoxColumn.HeaderText = "ID_Ministracion"
        Me.IDMinistracionDataGridViewTextBoxColumn.Name = "IDMinistracionDataGridViewTextBoxColumn"
        Me.IDMinistracionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDMinistracionDataGridViewTextBoxColumn.Visible = False
        '
        'IdsolicitudDataGridViewTextBoxColumn
        '
        Me.IdsolicitudDataGridViewTextBoxColumn.DataPropertyName = "Id_solicitud"
        Me.IdsolicitudDataGridViewTextBoxColumn.HeaderText = "Id_solicitud"
        Me.IdsolicitudDataGridViewTextBoxColumn.Name = "IdsolicitudDataGridViewTextBoxColumn"
        Me.IdsolicitudDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdsolicitudDataGridViewTextBoxColumn.Visible = False
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Format = "N2"
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PorcentajeDataGridViewTextBoxColumn
        '
        Me.PorcentajeDataGridViewTextBoxColumn.DataPropertyName = "Porcentaje"
        DataGridViewCellStyle2.Format = "P2"
        Me.PorcentajeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PorcentajeDataGridViewTextBoxColumn.HeaderText = "Porcentaje"
        Me.PorcentajeDataGridViewTextBoxColumn.Name = "PorcentajeDataGridViewTextBoxColumn"
        Me.PorcentajeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AVIMinistracionesSolicitudesBindingSource
        '
        Me.AVIMinistracionesSolicitudesBindingSource.DataMember = "AVI_MinistracionesSolicitudes"
        Me.AVIMinistracionesSolicitudesBindingSource.DataSource = Me.AviosDSX
        '
        'AviosDSX
        '
        Me.AviosDSX.DataSetName = "AviosDSX"
        Me.AviosDSX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BttValidar
        '
        Me.BttValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttValidar.Location = New System.Drawing.Point(711, 523)
        Me.BttValidar.Name = "BttValidar"
        Me.BttValidar.Size = New System.Drawing.Size(79, 32)
        Me.BttValidar.TabIndex = 123
        Me.BttValidar.Text = "Validar"
        Me.BttValidar.UseVisualStyleBackColor = True
        '
        'LbCAT
        '
        Me.LbCAT.AutoSize = True
        Me.LbCAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCAT.Location = New System.Drawing.Point(619, 533)
        Me.LbCAT.Name = "LbCAT"
        Me.LbCAT.Size = New System.Drawing.Size(35, 13)
        Me.LbCAT.TabIndex = 124
        Me.LbCAT.Text = "CAT:"
        '
        'Grid2
        '
        Me.Grid2.AllowUserToAddRows = False
        Me.Grid2.AllowUserToDeleteRows = False
        Me.Grid2.AutoGenerateColumns = False
        Me.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FechaIniDataGridViewTextBoxColumn, Me.FechaFinDataGridViewTextBoxColumn, Me.DiasDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn, Me.EfectivoDataGridViewTextBoxColumn, Me.BuroDataGridViewTextBoxColumn, Me.GastosDataGridViewTextBoxColumn, Me.SeguroAgricolaDataGridViewTextBoxColumn, Me.SeguroVidaDataGridViewTextBoxColumn, Me.FegaDataGridViewTextBoxColumn, Me.Garantia, Me.Intereses, Me.SaldoFinalDataGridViewTextBoxColumn})
        Me.Grid2.DataSource = Me.EstadoCuentaBindingSource
        Me.Grid2.Location = New System.Drawing.Point(12, 219)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.ReadOnly = True
        Me.Grid2.Size = New System.Drawing.Size(948, 298)
        Me.Grid2.TabIndex = 125
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'FechaIniDataGridViewTextBoxColumn
        '
        Me.FechaIniDataGridViewTextBoxColumn.DataPropertyName = "FechaIni"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaIniDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaIniDataGridViewTextBoxColumn.HeaderText = "Fecha Ini"
        Me.FechaIniDataGridViewTextBoxColumn.Name = "FechaIniDataGridViewTextBoxColumn"
        Me.FechaIniDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaIniDataGridViewTextBoxColumn.Width = 70
        '
        'FechaFinDataGridViewTextBoxColumn
        '
        Me.FechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin"
        DataGridViewCellStyle4.Format = "d"
        Me.FechaFinDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechaFinDataGridViewTextBoxColumn.HeaderText = "Fecha Fin"
        Me.FechaFinDataGridViewTextBoxColumn.Name = "FechaFinDataGridViewTextBoxColumn"
        Me.FechaFinDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaFinDataGridViewTextBoxColumn.Width = 70
        '
        'DiasDataGridViewTextBoxColumn
        '
        Me.DiasDataGridViewTextBoxColumn.DataPropertyName = "Dias"
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DiasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.DiasDataGridViewTextBoxColumn.HeaderText = "Dias"
        Me.DiasDataGridViewTextBoxColumn.Name = "DiasDataGridViewTextBoxColumn"
        Me.DiasDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiasDataGridViewTextBoxColumn.Width = 40
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.SaldoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoDataGridViewTextBoxColumn.Width = 80
        '
        'EfectivoDataGridViewTextBoxColumn
        '
        Me.EfectivoDataGridViewTextBoxColumn.DataPropertyName = "Efectivo"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.EfectivoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.EfectivoDataGridViewTextBoxColumn.HeaderText = "Efectivo"
        Me.EfectivoDataGridViewTextBoxColumn.Name = "EfectivoDataGridViewTextBoxColumn"
        Me.EfectivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EfectivoDataGridViewTextBoxColumn.Width = 80
        '
        'BuroDataGridViewTextBoxColumn
        '
        Me.BuroDataGridViewTextBoxColumn.DataPropertyName = "Buro"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.BuroDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.BuroDataGridViewTextBoxColumn.HeaderText = "Buro"
        Me.BuroDataGridViewTextBoxColumn.Name = "BuroDataGridViewTextBoxColumn"
        Me.BuroDataGridViewTextBoxColumn.ReadOnly = True
        Me.BuroDataGridViewTextBoxColumn.Visible = False
        Me.BuroDataGridViewTextBoxColumn.Width = 80
        '
        'GastosDataGridViewTextBoxColumn
        '
        Me.GastosDataGridViewTextBoxColumn.DataPropertyName = "Gastos"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.GastosDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.GastosDataGridViewTextBoxColumn.HeaderText = "Gastos"
        Me.GastosDataGridViewTextBoxColumn.Name = "GastosDataGridViewTextBoxColumn"
        Me.GastosDataGridViewTextBoxColumn.ReadOnly = True
        Me.GastosDataGridViewTextBoxColumn.Width = 80
        '
        'SeguroAgricolaDataGridViewTextBoxColumn
        '
        Me.SeguroAgricolaDataGridViewTextBoxColumn.DataPropertyName = "SeguroAgricola"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.SeguroAgricolaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.SeguroAgricolaDataGridViewTextBoxColumn.HeaderText = "Seg. Agricola"
        Me.SeguroAgricolaDataGridViewTextBoxColumn.Name = "SeguroAgricolaDataGridViewTextBoxColumn"
        Me.SeguroAgricolaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SeguroAgricolaDataGridViewTextBoxColumn.Width = 80
        '
        'SeguroVidaDataGridViewTextBoxColumn
        '
        Me.SeguroVidaDataGridViewTextBoxColumn.DataPropertyName = "SeguroVida"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.SeguroVidaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.SeguroVidaDataGridViewTextBoxColumn.HeaderText = "Seg. Vida"
        Me.SeguroVidaDataGridViewTextBoxColumn.Name = "SeguroVidaDataGridViewTextBoxColumn"
        Me.SeguroVidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SeguroVidaDataGridViewTextBoxColumn.Width = 80
        '
        'FegaDataGridViewTextBoxColumn
        '
        Me.FegaDataGridViewTextBoxColumn.DataPropertyName = "Fega"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.FegaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.FegaDataGridViewTextBoxColumn.HeaderText = "Fega"
        Me.FegaDataGridViewTextBoxColumn.Name = "FegaDataGridViewTextBoxColumn"
        Me.FegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FegaDataGridViewTextBoxColumn.Width = 80
        '
        'Garantia
        '
        Me.Garantia.DataPropertyName = "Garantia"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "n2"
        Me.Garantia.DefaultCellStyle = DataGridViewCellStyle13
        Me.Garantia.HeaderText = "Garantia"
        Me.Garantia.Name = "Garantia"
        Me.Garantia.ReadOnly = True
        Me.Garantia.Width = 70
        '
        'Intereses
        '
        Me.Intereses.DataPropertyName = "Intereses"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "n2"
        Me.Intereses.DefaultCellStyle = DataGridViewCellStyle14
        Me.Intereses.HeaderText = "Intereses"
        Me.Intereses.Name = "Intereses"
        Me.Intereses.ReadOnly = True
        Me.Intereses.Width = 80
        '
        'SaldoFinalDataGridViewTextBoxColumn
        '
        Me.SaldoFinalDataGridViewTextBoxColumn.DataPropertyName = "SaldoFinal"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        Me.SaldoFinalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.SaldoFinalDataGridViewTextBoxColumn.HeaderText = "SaldoFinal"
        Me.SaldoFinalDataGridViewTextBoxColumn.Name = "SaldoFinalDataGridViewTextBoxColumn"
        Me.SaldoFinalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoFinalDataGridViewTextBoxColumn.Width = 80
        '
        'EstadoCuentaBindingSource
        '
        Me.EstadoCuentaBindingSource.DataMember = "EstadoCuenta"
        Me.EstadoCuentaBindingSource.DataSource = Me.AviosDSX
        '
        'AVI_MinistracionesSolicitudesTableAdapter
        '
        Me.AVI_MinistracionesSolicitudesTableAdapter.ClearBeforeFill = True
        '
        'LbCATtir
        '
        Me.LbCATtir.AutoSize = True
        Me.LbCATtir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCATtir.Location = New System.Drawing.Point(12, 533)
        Me.LbCATtir.Name = "LbCATtir"
        Me.LbCATtir.Size = New System.Drawing.Size(60, 13)
        Me.LbCATtir.TabIndex = 126
        Me.LbCATtir.Text = "CAT TIR:"
        '
        'LbCAT1min
        '
        Me.LbCAT1min.AutoSize = True
        Me.LbCAT1min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCAT1min.Location = New System.Drawing.Point(274, 533)
        Me.LbCAT1min.Name = "LbCAT1min"
        Me.LbCAT1min.Size = New System.Drawing.Size(78, 13)
        Me.LbCAT1min.TabIndex = 127
        Me.LbCAT1min.Text = "CAT 1 minis:"
        '
        'FrmMinistracionesSOL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.LbCAT1min)
        Me.Controls.Add(Me.LbCATtir)
        Me.Controls.Add(Me.Grid2)
        Me.Controls.Add(Me.LbCAT)
        Me.Controls.Add(Me.BttValidar)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BttMinistraciones)
        Me.Name = "FrmMinistracionesSOL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ministraciones "
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AVIMinistracionesSolicitudesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosDSX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoCuentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BttMinistraciones As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents AviosDSX As Agil.AviosDSX
    Friend WithEvents AVIMinistracionesSolicitudesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AVI_MinistracionesSolicitudesTableAdapter As Agil.AviosDSXTableAdapters.AVI_MinistracionesSolicitudesTableAdapter
    Friend WithEvents BttValidar As System.Windows.Forms.Button
    Friend WithEvents IDMinistracionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdsolicitudDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LbCAT As System.Windows.Forms.Label
    Friend WithEvents Grid2 As System.Windows.Forms.DataGridView
    Friend WithEvents EstadoCuentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaIniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EfectivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GastosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeguroAgricolaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeguroVidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FegaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Garantia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Intereses As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoFinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LbCATtir As System.Windows.Forms.Label
    Friend WithEvents LbCAT1min As System.Windows.Forms.Label
End Class
