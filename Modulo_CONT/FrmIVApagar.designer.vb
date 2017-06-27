<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIVApagar
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
        Me.components = New System.ComponentModel.Container()
        Me.CmbFecha = New System.Windows.Forms.ComboBox()
        Me.BtnProc = New System.Windows.Forms.Button()
        Me.GridIva = New System.Windows.Forms.DataGridView()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiferencialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UdiInicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UdiFinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adelanto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaActivacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaTerminacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVApagarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContaDS = New Agil.ContaDS()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.CRV1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.GridIva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IVApagarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbFecha
        '
        Me.CmbFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFecha.FormattingEnabled = True
        Me.CmbFecha.Location = New System.Drawing.Point(13, 13)
        Me.CmbFecha.Name = "CmbFecha"
        Me.CmbFecha.Size = New System.Drawing.Size(146, 21)
        Me.CmbFecha.TabIndex = 0
        '
        'BtnProc
        '
        Me.BtnProc.Location = New System.Drawing.Point(174, 12)
        Me.BtnProc.Name = "BtnProc"
        Me.BtnProc.Size = New System.Drawing.Size(75, 23)
        Me.BtnProc.TabIndex = 1
        Me.BtnProc.Text = "Procesar"
        Me.BtnProc.UseVisualStyleBackColor = True
        '
        'GridIva
        '
        Me.GridIva.AutoGenerateColumns = False
        Me.GridIva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridIva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn, Me.TasaDataGridViewTextBoxColumn, Me.DiferencialDataGridViewTextBoxColumn, Me.DiasDataGridViewTextBoxColumn, Me.InicioDataGridViewTextBoxColumn, Me.FinDataGridViewTextBoxColumn, Me.UdiInicialDataGridViewTextBoxColumn, Me.UdiFinalDataGridViewTextBoxColumn, Me.IvaDataGridViewTextBoxColumn, Me.Adelanto, Me.FechaActivacion, Me.FechaTerminacion})
        Me.GridIva.DataSource = Me.IVApagarBindingSource
        Me.GridIva.Location = New System.Drawing.Point(12, 397)
        Me.GridIva.Name = "GridIva"
        Me.GridIva.Size = New System.Drawing.Size(968, 76)
        Me.GridIva.TabIndex = 2
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.Width = 80
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        '
        'TasaDataGridViewTextBoxColumn
        '
        Me.TasaDataGridViewTextBoxColumn.DataPropertyName = "Tasa"
        Me.TasaDataGridViewTextBoxColumn.HeaderText = "Tasa"
        Me.TasaDataGridViewTextBoxColumn.Name = "TasaDataGridViewTextBoxColumn"
        Me.TasaDataGridViewTextBoxColumn.Width = 70
        '
        'DiferencialDataGridViewTextBoxColumn
        '
        Me.DiferencialDataGridViewTextBoxColumn.DataPropertyName = "Diferencial"
        Me.DiferencialDataGridViewTextBoxColumn.HeaderText = "Diferencial"
        Me.DiferencialDataGridViewTextBoxColumn.Name = "DiferencialDataGridViewTextBoxColumn"
        Me.DiferencialDataGridViewTextBoxColumn.Width = 70
        '
        'DiasDataGridViewTextBoxColumn
        '
        Me.DiasDataGridViewTextBoxColumn.DataPropertyName = "Dias"
        Me.DiasDataGridViewTextBoxColumn.HeaderText = "Dias"
        Me.DiasDataGridViewTextBoxColumn.Name = "DiasDataGridViewTextBoxColumn"
        Me.DiasDataGridViewTextBoxColumn.Width = 60
        '
        'InicioDataGridViewTextBoxColumn
        '
        Me.InicioDataGridViewTextBoxColumn.DataPropertyName = "Inicio"
        Me.InicioDataGridViewTextBoxColumn.HeaderText = "Inicio"
        Me.InicioDataGridViewTextBoxColumn.Name = "InicioDataGridViewTextBoxColumn"
        '
        'FinDataGridViewTextBoxColumn
        '
        Me.FinDataGridViewTextBoxColumn.DataPropertyName = "Fin"
        Me.FinDataGridViewTextBoxColumn.HeaderText = "Fin"
        Me.FinDataGridViewTextBoxColumn.Name = "FinDataGridViewTextBoxColumn"
        '
        'UdiInicialDataGridViewTextBoxColumn
        '
        Me.UdiInicialDataGridViewTextBoxColumn.DataPropertyName = "UdiInicial"
        Me.UdiInicialDataGridViewTextBoxColumn.HeaderText = "UdiInicial"
        Me.UdiInicialDataGridViewTextBoxColumn.Name = "UdiInicialDataGridViewTextBoxColumn"
        Me.UdiInicialDataGridViewTextBoxColumn.Width = 80
        '
        'UdiFinalDataGridViewTextBoxColumn
        '
        Me.UdiFinalDataGridViewTextBoxColumn.DataPropertyName = "UdiFinal"
        Me.UdiFinalDataGridViewTextBoxColumn.HeaderText = "UdiFinal"
        Me.UdiFinalDataGridViewTextBoxColumn.Name = "UdiFinalDataGridViewTextBoxColumn"
        Me.UdiFinalDataGridViewTextBoxColumn.Width = 80
        '
        'IvaDataGridViewTextBoxColumn
        '
        Me.IvaDataGridViewTextBoxColumn.DataPropertyName = "Iva"
        Me.IvaDataGridViewTextBoxColumn.HeaderText = "Iva"
        Me.IvaDataGridViewTextBoxColumn.Name = "IvaDataGridViewTextBoxColumn"
        '
        'Adelanto
        '
        Me.Adelanto.DataPropertyName = "Adelanto"
        Me.Adelanto.HeaderText = "Adelanto"
        Me.Adelanto.Name = "Adelanto"
        Me.Adelanto.Width = 70
        '
        'FechaActivacion
        '
        Me.FechaActivacion.DataPropertyName = "FechaActivacion"
        Me.FechaActivacion.HeaderText = "FechaActivacion"
        Me.FechaActivacion.Name = "FechaActivacion"
        '
        'FechaTerminacion
        '
        Me.FechaTerminacion.DataPropertyName = "FechaTerminacion"
        Me.FechaTerminacion.HeaderText = "FechaTerminacion"
        Me.FechaTerminacion.Name = "FechaTerminacion"
        '
        'IVApagarBindingSource
        '
        Me.IVApagarBindingSource.DataMember = "IVApagar"
        Me.IVApagarBindingSource.DataSource = Me.ContaDS
        '
        'ContaDS
        '
        Me.ContaDS.DataSetName = "ContaDS"
        Me.ContaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(256, 11)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(725, 23)
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Visible = False
        '
        'CRV1
        '
        Me.CRV1.ActiveViewIndex = -1
        Me.CRV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV1.Location = New System.Drawing.Point(12, 40)
        Me.CRV1.Name = "CRV1"
        Me.CRV1.SelectionFormula = ""
        Me.CRV1.Size = New System.Drawing.Size(968, 351)
        Me.CRV1.TabIndex = 4
        Me.CRV1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CRV1.ViewTimeSelectionFormula = ""
        '
        'FrmIVApagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 485)
        Me.Controls.Add(Me.CRV1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GridIva)
        Me.Controls.Add(Me.BtnProc)
        Me.Controls.Add(Me.CmbFecha)
        Me.Name = "FrmIVApagar"
        Me.Text = "Reporte de Iva por Pagar."
        CType(Me.GridIva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IVApagarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmbFecha As System.Windows.Forms.ComboBox
    Friend WithEvents BtnProc As System.Windows.Forms.Button
    Friend WithEvents GridIva As System.Windows.Forms.DataGridView
    Friend WithEvents IVApagarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContaDS As Agil.ContaDS
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TasaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiferencialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UdiInicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UdiFinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adelanto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaActivacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaTerminacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRV1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
