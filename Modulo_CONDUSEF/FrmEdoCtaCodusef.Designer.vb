<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEdoCtaCodusef
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbClientes = New System.Windows.Forms.ComboBox()
        Me.ClientesActivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New Agil.ProductionDataSet()
        Me.ClientesActivosTableAdapter = New Agil.ProductionDataSetTableAdapters.ClientesActivosTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LstAnexos = New System.Windows.Forms.ListBox()
        Me.AnexosActivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexosActivosTableAdapter = New Agil.ProductionDataSetTableAdapters.AnexosActivosTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LstPeriodos = New System.Windows.Forms.ListBox()
        Me.PeriodosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeriodosTableAdapter = New Agil.ProductionDataSetTableAdapters.PeriodosTableAdapter()
        Me.BttConsulta = New System.Windows.Forms.Button()
        Me.CRVReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.LbFI = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LbFF = New System.Windows.Forms.Label()
        Me.LbSaldoAnt = New System.Windows.Forms.Label()
        Me.LbLetra = New System.Windows.Forms.Label()
        Me.LbFacAnt = New System.Windows.Forms.Label()
        CType(Me.ClientesActivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosActivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'CmbClientes
        '
        Me.CmbClientes.DataSource = Me.ClientesActivosBindingSource
        Me.CmbClientes.DisplayMember = "Nombre"
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(13, 26)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(475, 21)
        Me.CmbClientes.TabIndex = 1
        Me.CmbClientes.ValueMember = "Cliente"
        '
        'ClientesActivosBindingSource
        '
        Me.ClientesActivosBindingSource.DataMember = "ClientesActivos"
        Me.ClientesActivosBindingSource.DataSource = Me.ProductionDataSet
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesActivosTableAdapter
        '
        Me.ClientesActivosTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contratos Activos"
        '
        'LstAnexos
        '
        Me.LstAnexos.DataSource = Me.AnexosActivosBindingSource
        Me.LstAnexos.DisplayMember = "Titulo"
        Me.LstAnexos.FormattingEnabled = True
        Me.LstAnexos.Location = New System.Drawing.Point(15, 66)
        Me.LstAnexos.Name = "LstAnexos"
        Me.LstAnexos.Size = New System.Drawing.Size(366, 69)
        Me.LstAnexos.TabIndex = 3
        Me.LstAnexos.ValueMember = "AnexoX"
        '
        'AnexosActivosBindingSource
        '
        Me.AnexosActivosBindingSource.DataMember = "AnexosActivos"
        Me.AnexosActivosBindingSource.DataSource = Me.ProductionDataSet
        '
        'AnexosActivosTableAdapter
        '
        Me.AnexosActivosTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(382, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Periodos del "
        '
        'LstPeriodos
        '
        Me.LstPeriodos.DataSource = Me.PeriodosBindingSource
        Me.LstPeriodos.DisplayMember = "titulo"
        Me.LstPeriodos.FormattingEnabled = True
        Me.LstPeriodos.Location = New System.Drawing.Point(387, 66)
        Me.LstPeriodos.Name = "LstPeriodos"
        Me.LstPeriodos.Size = New System.Drawing.Size(320, 69)
        Me.LstPeriodos.TabIndex = 5
        Me.LstPeriodos.ValueMember = "NufacAct"
        '
        'PeriodosBindingSource
        '
        Me.PeriodosBindingSource.DataMember = "Periodos"
        Me.PeriodosBindingSource.DataSource = Me.ProductionDataSet
        '
        'PeriodosTableAdapter
        '
        Me.PeriodosTableAdapter.ClearBeforeFill = True
        '
        'BttConsulta
        '
        Me.BttConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttConsulta.Location = New System.Drawing.Point(713, 112)
        Me.BttConsulta.Name = "BttConsulta"
        Me.BttConsulta.Size = New System.Drawing.Size(295, 23)
        Me.BttConsulta.TabIndex = 6
        Me.BttConsulta.Text = "Imprimir"
        Me.BttConsulta.UseVisualStyleBackColor = True
        '
        'CRVReporte
        '
        Me.CRVReporte.ActiveViewIndex = -1
        Me.CRVReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReporte.Location = New System.Drawing.Point(15, 141)
        Me.CRVReporte.Name = "CRVReporte"
        Me.CRVReporte.SelectionFormula = ""
        Me.CRVReporte.ShowGroupTreeButton = False
        Me.CRVReporte.Size = New System.Drawing.Size(997, 450)
        Me.CRVReporte.TabIndex = 7
        Me.CRVReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CRVReporte.ViewTimeSelectionFormula = ""
        '
        'LbFI
        '
        Me.LbFI.AutoSize = True
        Me.LbFI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeriodosBindingSource, "FechaIni", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.LbFI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFI.Location = New System.Drawing.Point(469, 50)
        Me.LbFI.Name = "LbFI"
        Me.LbFI.Size = New System.Drawing.Size(32, 13)
        Me.LbFI.TabIndex = 8
        Me.LbFI.Text = "LbFI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(536, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "al"
        '
        'LbFF
        '
        Me.LbFF.AutoSize = True
        Me.LbFF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeriodosBindingSource, "FechaFin", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.LbFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFF.Location = New System.Drawing.Point(559, 50)
        Me.LbFF.Name = "LbFF"
        Me.LbFF.Size = New System.Drawing.Size(35, 13)
        Me.LbFF.TabIndex = 10
        Me.LbFF.Text = "LbFF"
        '
        'LbSaldoAnt
        '
        Me.LbSaldoAnt.AutoSize = True
        Me.LbSaldoAnt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeriodosBindingSource, "Saldo", True))
        Me.LbSaldoAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSaldoAnt.Location = New System.Drawing.Point(599, 91)
        Me.LbSaldoAnt.Name = "LbSaldoAnt"
        Me.LbSaldoAnt.Size = New System.Drawing.Size(45, 13)
        Me.LbSaldoAnt.TabIndex = 11
        Me.LbSaldoAnt.Text = "Label4"
        '
        'LbLetra
        '
        Me.LbLetra.AutoSize = True
        Me.LbLetra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeriodosBindingSource, "Letra", True))
        Me.LbLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLetra.Location = New System.Drawing.Point(599, 104)
        Me.LbLetra.Name = "LbLetra"
        Me.LbLetra.Size = New System.Drawing.Size(45, 13)
        Me.LbLetra.TabIndex = 12
        Me.LbLetra.Text = "Label4"
        '
        'LbFacAnt
        '
        Me.LbFacAnt.AutoSize = True
        Me.LbFacAnt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeriodosBindingSource, "NufacAnt", True))
        Me.LbFacAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFacAnt.Location = New System.Drawing.Point(517, 104)
        Me.LbFacAnt.Name = "LbFacAnt"
        Me.LbFacAnt.Size = New System.Drawing.Size(45, 13)
        Me.LbFacAnt.TabIndex = 13
        Me.LbFacAnt.Text = "Label4"
        '
        'FrmEdoCtaCodusef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 603)
        Me.Controls.Add(Me.LbFF)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LbFI)
        Me.Controls.Add(Me.CRVReporte)
        Me.Controls.Add(Me.BttConsulta)
        Me.Controls.Add(Me.LstPeriodos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LstAnexos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbClientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbSaldoAnt)
        Me.Controls.Add(Me.LbLetra)
        Me.Controls.Add(Me.LbFacAnt)
        Me.Name = "FrmEdoCtaCodusef"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de Cuenta CONDUSEF"
        CType(Me.ClientesActivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosActivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents ProductionDataSet As Agil.ProductionDataSet
    Friend WithEvents ClientesActivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesActivosTableAdapter As Agil.ProductionDataSetTableAdapters.ClientesActivosTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LstAnexos As System.Windows.Forms.ListBox
    Friend WithEvents AnexosActivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexosActivosTableAdapter As Agil.ProductionDataSetTableAdapters.AnexosActivosTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LstPeriodos As System.Windows.Forms.ListBox
    Friend WithEvents PeriodosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeriodosTableAdapter As Agil.ProductionDataSetTableAdapters.PeriodosTableAdapter
    Friend WithEvents BttConsulta As System.Windows.Forms.Button
    Friend WithEvents CRVReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LbFI As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LbFF As System.Windows.Forms.Label
    Friend WithEvents LbSaldoAnt As System.Windows.Forms.Label
    Friend WithEvents LbLetra As System.Windows.Forms.Label
    Friend WithEvents LbFacAnt As System.Windows.Forms.Label
End Class
