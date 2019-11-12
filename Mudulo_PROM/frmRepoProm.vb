Option Explicit On 

Imports System.Data.SqlClient
Imports CrystalDecisions.Shared

Public Class frmRepoProm

    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblPromotores As System.Windows.Forms.Label
    Friend WithEvents cbPromotores As System.Windows.Forms.ComboBox
    Friend WithEvents lblInicial As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFinal As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents ChkAll As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpEqDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IvaEqDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlazoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TasasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiferDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PorcoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaconDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescEquipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinanciadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiparDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepositoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoTasaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecursosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InicialesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaActivacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreSucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RepoPromRPTBindingSource As BindingSource
    Friend WithEvents ReportesDS As ReportesDS
    Friend WithEvents RepoPromRPTTableAdapter As ReportesDSTableAdapters.RepoPromRPTTableAdapter
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lblInicial = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cbPromotores = New System.Windows.Forms.ComboBox()
        Me.lblPromotores = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ChkAll = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReportesDS = New Agil.ReportesDS()
        Me.RepoPromRPTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepoPromRPTTableAdapter = New Agil.ReportesDSTableAdapters.RepoPromRPTTableAdapter()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpEqDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaEqDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlazoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiferDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaconDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescEquipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinanciadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiparDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepositoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoTasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecursosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InicialesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaActivacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreSucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoPromRPTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(435, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(617, 15)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker2.TabIndex = 5
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(837, 13)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 24)
        Me.btnProcesar.TabIndex = 9
        Me.btnProcesar.Text = "Procesar"
        '
        'lblInicial
        '
        Me.lblInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicial.Location = New System.Drawing.Point(352, 17)
        Me.lblInicial.Name = "lblInicial"
        Me.lblInicial.Size = New System.Drawing.Size(80, 16)
        Me.lblInicial.TabIndex = 2
        Me.lblInicial.Text = "Fecha Inicial"
        '
        'lblFinal
        '
        Me.lblFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(541, 17)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(73, 16)
        Me.lblFinal.TabIndex = 4
        Me.lblFinal.Text = "Fecha Final"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 56)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1008, 538)
        Me.CrystalReportViewer1.TabIndex = 10
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'cbPromotores
        '
        Me.cbPromotores.Location = New System.Drawing.Point(112, 15)
        Me.cbPromotores.Name = "cbPromotores"
        Me.cbPromotores.Size = New System.Drawing.Size(232, 21)
        Me.cbPromotores.TabIndex = 1
        '
        'lblPromotores
        '
        Me.lblPromotores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromotores.Location = New System.Drawing.Point(8, 17)
        Me.lblPromotores.Name = "lblPromotores"
        Me.lblPromotores.Size = New System.Drawing.Size(100, 16)
        Me.lblPromotores.TabIndex = 0
        Me.lblPromotores.Text = "Activaciones de"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(922, 13)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 24)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ChkAll
        '
        Me.ChkAll.AutoSize = True
        Me.ChkAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAll.Location = New System.Drawing.Point(711, 16)
        Me.ChkAll.Name = "ChkAll"
        Me.ChkAll.Size = New System.Drawing.Size(116, 17)
        Me.ChkAll.TabIndex = 6
        Me.ChkAll.Text = "Sin Fecha Pago"
        Me.ChkAll.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.ImpEqDataGridViewTextBoxColumn, Me.IvaEqDataGridViewTextBoxColumn, Me.PlazoDataGridViewTextBoxColumn, Me.TasasDataGridViewTextBoxColumn, Me.DiferDataGridViewTextBoxColumn, Me.ComisDataGridViewTextBoxColumn, Me.PorcoDataGridViewTextBoxColumn, Me.FechaconDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn, Me.DescEquipoDataGridViewTextBoxColumn, Me.RDDataGridViewTextBoxColumn, Me.FinanciadoDataGridViewTextBoxColumn, Me.TiparDataGridViewTextBoxColumn, Me.DepositoDataGridViewTextBoxColumn, Me.TipoTasaDataGridViewTextBoxColumn, Me.RecursosDataGridViewTextBoxColumn, Me.PromoDataGridViewTextBoxColumn, Me.InicialesDataGridViewTextBoxColumn, Me.FechaActivacionDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.NombreSucursalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RepoPromRPTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(8, 600)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1008, 90)
        Me.DataGridView1.TabIndex = 12
        '
        'ReportesDS
        '
        Me.ReportesDS.DataSetName = "ReportesDS"
        Me.ReportesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepoPromRPTBindingSource
        '
        Me.RepoPromRPTBindingSource.DataMember = "RepoPromRPT"
        Me.RepoPromRPTBindingSource.DataSource = Me.ReportesDS
        '
        'RepoPromRPTTableAdapter
        '
        Me.RepoPromRPTTableAdapter.ClearBeforeFill = True
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescrDataGridViewTextBoxColumn
        '
        Me.DescrDataGridViewTextBoxColumn.DataPropertyName = "Descr"
        Me.DescrDataGridViewTextBoxColumn.HeaderText = "Descr"
        Me.DescrDataGridViewTextBoxColumn.Name = "DescrDataGridViewTextBoxColumn"
        Me.DescrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImpEqDataGridViewTextBoxColumn
        '
        Me.ImpEqDataGridViewTextBoxColumn.DataPropertyName = "ImpEq"
        Me.ImpEqDataGridViewTextBoxColumn.HeaderText = "ImpEq"
        Me.ImpEqDataGridViewTextBoxColumn.Name = "ImpEqDataGridViewTextBoxColumn"
        Me.ImpEqDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IvaEqDataGridViewTextBoxColumn
        '
        Me.IvaEqDataGridViewTextBoxColumn.DataPropertyName = "IvaEq"
        Me.IvaEqDataGridViewTextBoxColumn.HeaderText = "IvaEq"
        Me.IvaEqDataGridViewTextBoxColumn.Name = "IvaEqDataGridViewTextBoxColumn"
        Me.IvaEqDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlazoDataGridViewTextBoxColumn
        '
        Me.PlazoDataGridViewTextBoxColumn.DataPropertyName = "Plazo"
        Me.PlazoDataGridViewTextBoxColumn.HeaderText = "Plazo"
        Me.PlazoDataGridViewTextBoxColumn.Name = "PlazoDataGridViewTextBoxColumn"
        Me.PlazoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TasasDataGridViewTextBoxColumn
        '
        Me.TasasDataGridViewTextBoxColumn.DataPropertyName = "Tasas"
        Me.TasasDataGridViewTextBoxColumn.HeaderText = "Tasas"
        Me.TasasDataGridViewTextBoxColumn.Name = "TasasDataGridViewTextBoxColumn"
        Me.TasasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiferDataGridViewTextBoxColumn
        '
        Me.DiferDataGridViewTextBoxColumn.DataPropertyName = "Difer"
        Me.DiferDataGridViewTextBoxColumn.HeaderText = "Difer"
        Me.DiferDataGridViewTextBoxColumn.Name = "DiferDataGridViewTextBoxColumn"
        Me.DiferDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComisDataGridViewTextBoxColumn
        '
        Me.ComisDataGridViewTextBoxColumn.DataPropertyName = "Comis"
        Me.ComisDataGridViewTextBoxColumn.HeaderText = "Comis"
        Me.ComisDataGridViewTextBoxColumn.Name = "ComisDataGridViewTextBoxColumn"
        Me.ComisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PorcoDataGridViewTextBoxColumn
        '
        Me.PorcoDataGridViewTextBoxColumn.DataPropertyName = "Porco"
        Me.PorcoDataGridViewTextBoxColumn.HeaderText = "Porco"
        Me.PorcoDataGridViewTextBoxColumn.Name = "PorcoDataGridViewTextBoxColumn"
        Me.PorcoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaconDataGridViewTextBoxColumn
        '
        Me.FechaconDataGridViewTextBoxColumn.DataPropertyName = "Fechacon"
        Me.FechaconDataGridViewTextBoxColumn.HeaderText = "Fechacon"
        Me.FechaconDataGridViewTextBoxColumn.Name = "FechaconDataGridViewTextBoxColumn"
        Me.FechaconDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaPagoDataGridViewTextBoxColumn
        '
        Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Pago"
        Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "Fecha_Pago"
        Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
        Me.FechaPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescEquipoDataGridViewTextBoxColumn
        '
        Me.DescEquipoDataGridViewTextBoxColumn.DataPropertyName = "DescEquipo"
        Me.DescEquipoDataGridViewTextBoxColumn.HeaderText = "DescEquipo"
        Me.DescEquipoDataGridViewTextBoxColumn.Name = "DescEquipoDataGridViewTextBoxColumn"
        Me.DescEquipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RDDataGridViewTextBoxColumn
        '
        Me.RDDataGridViewTextBoxColumn.DataPropertyName = "RD"
        Me.RDDataGridViewTextBoxColumn.HeaderText = "RD"
        Me.RDDataGridViewTextBoxColumn.Name = "RDDataGridViewTextBoxColumn"
        Me.RDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FinanciadoDataGridViewTextBoxColumn
        '
        Me.FinanciadoDataGridViewTextBoxColumn.DataPropertyName = "Financiado"
        Me.FinanciadoDataGridViewTextBoxColumn.HeaderText = "Financiado"
        Me.FinanciadoDataGridViewTextBoxColumn.Name = "FinanciadoDataGridViewTextBoxColumn"
        Me.FinanciadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TiparDataGridViewTextBoxColumn
        '
        Me.TiparDataGridViewTextBoxColumn.DataPropertyName = "Tipar"
        Me.TiparDataGridViewTextBoxColumn.HeaderText = "Tipar"
        Me.TiparDataGridViewTextBoxColumn.Name = "TiparDataGridViewTextBoxColumn"
        Me.TiparDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepositoDataGridViewTextBoxColumn
        '
        Me.DepositoDataGridViewTextBoxColumn.DataPropertyName = "Deposito"
        Me.DepositoDataGridViewTextBoxColumn.HeaderText = "Deposito"
        Me.DepositoDataGridViewTextBoxColumn.Name = "DepositoDataGridViewTextBoxColumn"
        Me.DepositoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoTasaDataGridViewTextBoxColumn
        '
        Me.TipoTasaDataGridViewTextBoxColumn.DataPropertyName = "TipoTasa"
        Me.TipoTasaDataGridViewTextBoxColumn.HeaderText = "TipoTasa"
        Me.TipoTasaDataGridViewTextBoxColumn.Name = "TipoTasaDataGridViewTextBoxColumn"
        Me.TipoTasaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecursosDataGridViewTextBoxColumn
        '
        Me.RecursosDataGridViewTextBoxColumn.DataPropertyName = "Recursos"
        Me.RecursosDataGridViewTextBoxColumn.HeaderText = "Recursos"
        Me.RecursosDataGridViewTextBoxColumn.Name = "RecursosDataGridViewTextBoxColumn"
        Me.RecursosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PromoDataGridViewTextBoxColumn
        '
        Me.PromoDataGridViewTextBoxColumn.DataPropertyName = "Promo"
        Me.PromoDataGridViewTextBoxColumn.HeaderText = "Promo"
        Me.PromoDataGridViewTextBoxColumn.Name = "PromoDataGridViewTextBoxColumn"
        Me.PromoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InicialesDataGridViewTextBoxColumn
        '
        Me.InicialesDataGridViewTextBoxColumn.DataPropertyName = "Iniciales"
        Me.InicialesDataGridViewTextBoxColumn.HeaderText = "Iniciales"
        Me.InicialesDataGridViewTextBoxColumn.Name = "InicialesDataGridViewTextBoxColumn"
        Me.InicialesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaActivacionDataGridViewTextBoxColumn
        '
        Me.FechaActivacionDataGridViewTextBoxColumn.DataPropertyName = "FechaActivacion"
        Me.FechaActivacionDataGridViewTextBoxColumn.HeaderText = "FechaActivacion"
        Me.FechaActivacionDataGridViewTextBoxColumn.Name = "FechaActivacionDataGridViewTextBoxColumn"
        Me.FechaActivacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreSucursalDataGridViewTextBoxColumn
        '
        Me.NombreSucursalDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Sucursal"
        Me.NombreSucursalDataGridViewTextBoxColumn.HeaderText = "Nombre_Sucursal"
        Me.NombreSucursalDataGridViewTextBoxColumn.Name = "NombreSucursalDataGridViewTextBoxColumn"
        Me.NombreSucursalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmRepoProm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1024, 702)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ChkAll)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblPromotores)
        Me.Controls.Add(Me.cbPromotores)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblInicial)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmRepoProm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Activaciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoPromRPTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' Declaración de variables de Crystal Reports de alcance privado

    Dim newrptRepoProm As rptRepoProm

    Private Sub frmRepoProm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daPromotores As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet()
        Dim drPromotor As DataRow
        Dim drPromotores As DataRowCollection

        ' El siguiente Stored Procedure trae el nombre de todos los promotores

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Promotores1"
            .Connection = cnAgil
        End With

        daPromotores.Fill(dsAgil, "Promotores")
        drPromotores = dsAgil.Tables("Promotores").Rows
        cbPromotores.Items.Add("CONTRATACION EN GENERAL")
        cbPromotores.Items.Add("REPORTE GENERAL DE REESTRUCTURAS")
        For Each drPromotor In drPromotores
            cbPromotores.Items.Add(Trim(drPromotor("DescPromotor")) & " " & drPromotor("Promotor"))
        Next
        cbPromotores.SelectedIndex = 0

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Dim cFechaInicio As String
        Dim cFechaFinal As String
        Dim cReportTitle As String
        Dim cReportComments As String
        Dim TipoCambio As Decimal

        cFechaInicio = DTOC(DateTimePicker1.Value)
        cFechaFinal = DTOC(DateTimePicker2.Value)

        newrptRepoProm = New rptRepoProm()
        Me.ReportesDS.RepoPromRPT.Clear()

        If cbPromotores.SelectedIndex = 0 Then 'reporte general
            Me.RepoPromRPTTableAdapter.Fill_RepoProm1(Me.ReportesDS.RepoPromRPT, cFechaInicio, cFechaFinal)
        ElseIf cbPromotores.SelectedIndex = 1 Then ' reporte Reestructuras
            Me.RepoPromRPTTableAdapter.Fill_RepoProm3(Me.ReportesDS.RepoPromRPT, cFechaInicio, cFechaFinal)
        Else
            Me.RepoPromRPTTableAdapter.Fill_RepoProm2(Me.ReportesDS.RepoPromRPT, cFechaInicio, cFechaFinal, CInt(Mid(cbPromotores.Text, cbPromotores.Text.Length - 3, 4))) ' reporte por promotor
        End If

        For Each r As ReportesDS.RepoPromRPTRow In Me.ReportesDS.RepoPromRPT
            If r.Moneda <> "MXN" Then
                TipoCambio = TaQUERY.SacaTipoCambio(r.Moneda, CTOD(r.Fecha_Pago))
                If TipoCambio = 0 And r.Fecha_Pago.Trim.Length > 0 Then
                    MandaCorreoFase(UsuarioGlobalCorreo, "SISTEMAS", "Error tipo de cambio", "No existe tipo de cambio: " & r.Moneda & ":" & r.Fecha_Pago)
                    MandaCorreoFase(UsuarioGlobalCorreo, "CONTABILIDAD", "Error tipo de cambio", "No existe tipo de cambio: " & r.Moneda & ":" & r.Fecha_Pago)
                End If
                r.Comis = r.Comis * TipoCambio
                r.Deposito = r.Deposito * TipoCambio
                r.Financiado = r.Financiado * TipoCambio
                r.ImpEq = r.ImpEq * TipoCambio
                r.IvaEq = r.IvaEq * TipoCambio
                r.AcceptChanges()
            End If
        Next

        Try
            cReportTitle = "REPORTE DE ACTIVACIONES DEL " & Mid(CTOD(cFechaInicio).ToString, 1, 10) & " AL " & Mid(CTOD(cFechaFinal).ToString, 1, 10)
            If cbPromotores.SelectedIndex = 0 Then
                cReportComments = "COLOCACIÓN GENERAL"
            ElseIf cbPromotores.SelectedIndex = 1 Then
                cReportTitle = "REPORTE DE REESTRUCTURAS DEL " & Mid(CTOD(cFechaInicio).ToString, 1, 10) & " AL " & Mid(CTOD(cFechaFinal).ToString, 1, 10)
                cReportComments = ""
            Else
                cReportComments = "COLOCACIÓN DEL " & RTrim(cbPromotores.SelectedItem)
            End If

            newrptRepoProm.SetDataSource(Me.ReportesDS)
            newrptRepoProm.SummaryInfo.ReportTitle = cReportTitle
            newrptRepoProm.SummaryInfo.ReportComments = cReportComments
            If ChkAll.Checked = True Then
                newrptRepoProm.SetParameterValue("Todo", "")
                Me.RepoPromRPTBindingSource.Filter = ""
            Else
                newrptRepoProm.SetParameterValue("Todo", "0")
                Me.RepoPromRPTBindingSource.Filter = "Fecha_Pago > '1' "
            End If


            CrystalReportViewer1.ReportSource = newrptRepoProm
            CrystalReportViewer1.ReportSource = newrptRepoProm
        Catch eException As Exception
            MsgBox(eException.Source, MsgBoxStyle.Critical, eException.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class
