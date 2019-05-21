<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_solicitudes
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
        Me.rb_pendientes = New System.Windows.Forms.RadioButton()
        Me.rb_entregados = New System.Windows.Forms.RadioButton()
        Me.rb_devueltos = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcontrato = New System.Windows.Forms.TextBox()
        Me.VwBitacoraanexoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MesaControlDS = New Agil.MesaControlDS()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnota = New System.Windows.Forms.TextBox()
        Me.btn_entregar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.IdBitacoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolicitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoboDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoboB = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FechaSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDevolucionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagareDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PagareORGDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PagareTXTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContratoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ContratoORGDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ContratoTXTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConvenioDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ConvenioORGDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ConvenioTXTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EscrituraDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EscrituraORGDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EscrituraTXTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FacturasORGDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FacturasTXTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GarantiasDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GarantiasORGDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GarantiasTXTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JustificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Autoriza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorizaB = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NoAdeudo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AuditoriaExterna = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupCont = New System.Windows.Forms.GroupBox()
        Me.contrato_org = New System.Windows.Forms.CheckBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.GroupConv = New System.Windows.Forms.GroupBox()
        Me.convenio_org = New System.Windows.Forms.CheckBox()
        Me.txtconvenio = New System.Windows.Forms.TextBox()
        Me.GroupEscri = New System.Windows.Forms.GroupBox()
        Me.escrituras_org = New System.Windows.Forms.CheckBox()
        Me.txtescrituras = New System.Windows.Forms.TextBox()
        Me.txtpagare = New System.Windows.Forms.TextBox()
        Me.GroupPag = New System.Windows.Forms.GroupBox()
        Me.pagare_org = New System.Windows.Forms.CheckBox()
        Me.GroupGarant = New System.Windows.Forms.GroupBox()
        Me.garantias_org = New System.Windows.Forms.CheckBox()
        Me.txtgarantias = New System.Windows.Forms.TextBox()
        Me.GroupFact = New System.Windows.Forms.GroupBox()
        Me.txtfacturas = New System.Windows.Forms.TextBox()
        Me.facturas_org = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.grupo = New System.Windows.Forms.GroupBox()
        Me.CkPagare = New System.Windows.Forms.CheckBox()
        Me.CkGarant = New System.Windows.Forms.CheckBox()
        Me.CkFact = New System.Windows.Forms.CheckBox()
        Me.CkEscri = New System.Windows.Forms.CheckBox()
        Me.CkConv = New System.Windows.Forms.CheckBox()
        Me.CkCont = New System.Windows.Forms.CheckBox()
        Me.CkAutoriza = New System.Windows.Forms.CheckBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFiltroCliente = New System.Windows.Forms.TextBox()
        Me.TxtFiltroAnexo = New System.Windows.Forms.MaskedTextBox()
        Me.TxtFiltroUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VwBitacoraanexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MCBitacoraBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MCBitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Agil.MesaControlDSTableAdapters.ClientesTableAdapter()
        Me.MC_BitacoraTableAdapter = New Agil.MesaControlDSTableAdapters.MC_BitacoraTableAdapter()
        Me.MCBitacoraBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_Bitacora_anexoTableAdapter = New Agil.MesaControlDSTableAdapters.Vw_Bitacora_anexoTableAdapter()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        CType(Me.VwBitacoraanexoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupCont.SuspendLayout()
        Me.GroupConv.SuspendLayout()
        Me.GroupEscri.SuspendLayout()
        Me.GroupPag.SuspendLayout()
        Me.GroupGarant.SuspendLayout()
        Me.GroupFact.SuspendLayout()
        Me.grupo.SuspendLayout()
        CType(Me.VwBitacoraanexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCBitacoraBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCBitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCBitacoraBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rb_pendientes
        '
        Me.rb_pendientes.AutoSize = True
        Me.rb_pendientes.Location = New System.Drawing.Point(30, 35)
        Me.rb_pendientes.Name = "rb_pendientes"
        Me.rb_pendientes.Size = New System.Drawing.Size(78, 17)
        Me.rb_pendientes.TabIndex = 1
        Me.rb_pendientes.TabStop = True
        Me.rb_pendientes.Text = "Pendientes"
        Me.rb_pendientes.UseVisualStyleBackColor = True
        '
        'rb_entregados
        '
        Me.rb_entregados.AutoSize = True
        Me.rb_entregados.Location = New System.Drawing.Point(141, 35)
        Me.rb_entregados.Name = "rb_entregados"
        Me.rb_entregados.Size = New System.Drawing.Size(79, 17)
        Me.rb_entregados.TabIndex = 2
        Me.rb_entregados.TabStop = True
        Me.rb_entregados.Text = "Entregados"
        Me.rb_entregados.UseVisualStyleBackColor = True
        '
        'rb_devueltos
        '
        Me.rb_devueltos.AutoSize = True
        Me.rb_devueltos.Location = New System.Drawing.Point(260, 35)
        Me.rb_devueltos.Name = "rb_devueltos"
        Me.rb_devueltos.Size = New System.Drawing.Size(73, 17)
        Me.rb_devueltos.TabIndex = 3
        Me.rb_devueltos.TabStop = True
        Me.rb_devueltos.Text = "Devueltos"
        Me.rb_devueltos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Estatus"
        '
        'txtcontrato
        '
        Me.txtcontrato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwBitacoraanexoBindingSource1, "ContratoTXT", True))
        Me.txtcontrato.Location = New System.Drawing.Point(6, 30)
        Me.txtcontrato.Name = "txtcontrato"
        Me.txtcontrato.Size = New System.Drawing.Size(259, 20)
        Me.txtcontrato.TabIndex = 6
        '
        'VwBitacoraanexoBindingSource1
        '
        Me.VwBitacoraanexoBindingSource1.DataMember = "Vw_Bitacora_anexo"
        Me.VwBitacoraanexoBindingSource1.DataSource = Me.MesaControlDS
        '
        'MesaControlDS
        '
        Me.MesaControlDS.DataSetName = "MesaControlDS"
        Me.MesaControlDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Nota"
        '
        'txtnota
        '
        Me.txtnota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwBitacoraanexoBindingSource1, "Nota", True))
        Me.txtnota.Location = New System.Drawing.Point(6, 256)
        Me.txtnota.Multiline = True
        Me.txtnota.Name = "txtnota"
        Me.txtnota.Size = New System.Drawing.Size(467, 72)
        Me.txtnota.TabIndex = 45
        '
        'btn_entregar
        '
        Me.btn_entregar.Location = New System.Drawing.Point(759, 534)
        Me.btn_entregar.Name = "btn_entregar"
        Me.btn_entregar.Size = New System.Drawing.Size(76, 29)
        Me.btn_entregar.TabIndex = 46
        Me.btn_entregar.Text = "Entregar"
        Me.btn_entregar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(841, 534)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(76, 29)
        Me.btn_guardar.TabIndex = 47
        Me.btn_guardar.Text = "Devuelto"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AutoGenerateColumns = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBitacoraDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.AnexoDataGridViewTextBoxColumn, Me.TipoCredito, Me.Sucursal, Me.CicloDataGridViewTextBoxColumn, Me.SolicitoDataGridViewTextBoxColumn, Me.VoboDataGridViewTextBoxColumn, Me.VoboB, Me.FechaSolicitudDataGridViewTextBoxColumn, Me.FechaEntregaDataGridViewTextBoxColumn, Me.FechaDevolucionDataGridViewTextBoxColumn, Me.PagareDataGridViewCheckBoxColumn, Me.PagareORGDataGridViewCheckBoxColumn, Me.PagareTXTDataGridViewTextBoxColumn, Me.ContratoDataGridViewCheckBoxColumn, Me.ContratoORGDataGridViewCheckBoxColumn, Me.ContratoTXTDataGridViewTextBoxColumn, Me.ConvenioDataGridViewCheckBoxColumn, Me.ConvenioORGDataGridViewCheckBoxColumn, Me.ConvenioTXTDataGridViewTextBoxColumn, Me.EscrituraDataGridViewCheckBoxColumn, Me.EscrituraORGDataGridViewCheckBoxColumn, Me.EscrituraTXTDataGridViewTextBoxColumn, Me.FacturasDataGridViewCheckBoxColumn, Me.FacturasORGDataGridViewCheckBoxColumn, Me.FacturasTXTDataGridViewTextBoxColumn, Me.GarantiasDataGridViewCheckBoxColumn, Me.GarantiasORGDataGridViewCheckBoxColumn, Me.GarantiasTXTDataGridViewTextBoxColumn, Me.JustificacionDataGridViewTextBoxColumn, Me.NotaDataGridViewTextBoxColumn, Me.Autoriza, Me.AutorizaB, Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1, Me.NoAdeudo, Me.AuditoriaExterna})
        Me.DGV.DataSource = Me.VwBitacoraanexoBindingSource1
        Me.DGV.Location = New System.Drawing.Point(30, 61)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(967, 119)
        Me.DGV.TabIndex = 48
        '
        'IdBitacoraDataGridViewTextBoxColumn
        '
        Me.IdBitacoraDataGridViewTextBoxColumn.DataPropertyName = "Id_Bitacora"
        Me.IdBitacoraDataGridViewTextBoxColumn.HeaderText = "Id_Bitacora"
        Me.IdBitacoraDataGridViewTextBoxColumn.Name = "IdBitacoraDataGridViewTextBoxColumn"
        Me.IdBitacoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdBitacoraDataGridViewTextBoxColumn.Visible = False
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 300
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoCredito
        '
        Me.TipoCredito.DataPropertyName = "TipoCredito"
        Me.TipoCredito.HeaderText = "Tipo Crédito"
        Me.TipoCredito.Name = "TipoCredito"
        Me.TipoCredito.ReadOnly = True
        '
        'Sucursal
        '
        Me.Sucursal.DataPropertyName = "Nombre_Sucursal"
        Me.Sucursal.HeaderText = "Sucursal"
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.ReadOnly = True
        Me.Sucursal.Width = 90
        '
        'CicloDataGridViewTextBoxColumn
        '
        Me.CicloDataGridViewTextBoxColumn.DataPropertyName = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.HeaderText = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.Name = "CicloDataGridViewTextBoxColumn"
        Me.CicloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SolicitoDataGridViewTextBoxColumn
        '
        Me.SolicitoDataGridViewTextBoxColumn.DataPropertyName = "Solicito"
        Me.SolicitoDataGridViewTextBoxColumn.HeaderText = "Solicito"
        Me.SolicitoDataGridViewTextBoxColumn.Name = "SolicitoDataGridViewTextBoxColumn"
        Me.SolicitoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VoboDataGridViewTextBoxColumn
        '
        Me.VoboDataGridViewTextBoxColumn.DataPropertyName = "vobo"
        Me.VoboDataGridViewTextBoxColumn.HeaderText = "Vobo"
        Me.VoboDataGridViewTextBoxColumn.Name = "VoboDataGridViewTextBoxColumn"
        Me.VoboDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VoboB
        '
        Me.VoboB.DataPropertyName = "VoboB"
        Me.VoboB.HeaderText = "Vobo Aut."
        Me.VoboB.Name = "VoboB"
        Me.VoboB.ReadOnly = True
        '
        'FechaSolicitudDataGridViewTextBoxColumn
        '
        Me.FechaSolicitudDataGridViewTextBoxColumn.DataPropertyName = "FechaSolicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.HeaderText = "FechaSolicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.Name = "FechaSolicitudDataGridViewTextBoxColumn"
        Me.FechaSolicitudDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaEntregaDataGridViewTextBoxColumn
        '
        Me.FechaEntregaDataGridViewTextBoxColumn.DataPropertyName = "FechaEntrega"
        Me.FechaEntregaDataGridViewTextBoxColumn.HeaderText = "FechaEntrega"
        Me.FechaEntregaDataGridViewTextBoxColumn.Name = "FechaEntregaDataGridViewTextBoxColumn"
        Me.FechaEntregaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDevolucionDataGridViewTextBoxColumn
        '
        Me.FechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaDevolucion"
        Me.FechaDevolucionDataGridViewTextBoxColumn.HeaderText = "FechaDevolucion"
        Me.FechaDevolucionDataGridViewTextBoxColumn.Name = "FechaDevolucionDataGridViewTextBoxColumn"
        Me.FechaDevolucionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagareDataGridViewCheckBoxColumn
        '
        Me.PagareDataGridViewCheckBoxColumn.DataPropertyName = "Pagare"
        Me.PagareDataGridViewCheckBoxColumn.HeaderText = "Pagare"
        Me.PagareDataGridViewCheckBoxColumn.Name = "PagareDataGridViewCheckBoxColumn"
        Me.PagareDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PagareORGDataGridViewCheckBoxColumn
        '
        Me.PagareORGDataGridViewCheckBoxColumn.DataPropertyName = "PagareORG"
        Me.PagareORGDataGridViewCheckBoxColumn.HeaderText = "PagareORG"
        Me.PagareORGDataGridViewCheckBoxColumn.Name = "PagareORGDataGridViewCheckBoxColumn"
        Me.PagareORGDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PagareTXTDataGridViewTextBoxColumn
        '
        Me.PagareTXTDataGridViewTextBoxColumn.DataPropertyName = "PagareTXT"
        Me.PagareTXTDataGridViewTextBoxColumn.HeaderText = "PagareTXT"
        Me.PagareTXTDataGridViewTextBoxColumn.Name = "PagareTXTDataGridViewTextBoxColumn"
        Me.PagareTXTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContratoDataGridViewCheckBoxColumn
        '
        Me.ContratoDataGridViewCheckBoxColumn.DataPropertyName = "Contrato"
        Me.ContratoDataGridViewCheckBoxColumn.HeaderText = "Contrato"
        Me.ContratoDataGridViewCheckBoxColumn.Name = "ContratoDataGridViewCheckBoxColumn"
        Me.ContratoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ContratoORGDataGridViewCheckBoxColumn
        '
        Me.ContratoORGDataGridViewCheckBoxColumn.DataPropertyName = "ContratoORG"
        Me.ContratoORGDataGridViewCheckBoxColumn.HeaderText = "ContratoORG"
        Me.ContratoORGDataGridViewCheckBoxColumn.Name = "ContratoORGDataGridViewCheckBoxColumn"
        Me.ContratoORGDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ContratoTXTDataGridViewTextBoxColumn
        '
        Me.ContratoTXTDataGridViewTextBoxColumn.DataPropertyName = "ContratoTXT"
        Me.ContratoTXTDataGridViewTextBoxColumn.HeaderText = "ContratoTXT"
        Me.ContratoTXTDataGridViewTextBoxColumn.Name = "ContratoTXTDataGridViewTextBoxColumn"
        Me.ContratoTXTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConvenioDataGridViewCheckBoxColumn
        '
        Me.ConvenioDataGridViewCheckBoxColumn.DataPropertyName = "Convenio"
        Me.ConvenioDataGridViewCheckBoxColumn.HeaderText = "Convenio"
        Me.ConvenioDataGridViewCheckBoxColumn.Name = "ConvenioDataGridViewCheckBoxColumn"
        Me.ConvenioDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ConvenioORGDataGridViewCheckBoxColumn
        '
        Me.ConvenioORGDataGridViewCheckBoxColumn.DataPropertyName = "ConvenioORG"
        Me.ConvenioORGDataGridViewCheckBoxColumn.HeaderText = "ConvenioORG"
        Me.ConvenioORGDataGridViewCheckBoxColumn.Name = "ConvenioORGDataGridViewCheckBoxColumn"
        Me.ConvenioORGDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ConvenioTXTDataGridViewTextBoxColumn
        '
        Me.ConvenioTXTDataGridViewTextBoxColumn.DataPropertyName = "ConvenioTXT"
        Me.ConvenioTXTDataGridViewTextBoxColumn.HeaderText = "ConvenioTXT"
        Me.ConvenioTXTDataGridViewTextBoxColumn.Name = "ConvenioTXTDataGridViewTextBoxColumn"
        Me.ConvenioTXTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EscrituraDataGridViewCheckBoxColumn
        '
        Me.EscrituraDataGridViewCheckBoxColumn.DataPropertyName = "Escritura"
        Me.EscrituraDataGridViewCheckBoxColumn.HeaderText = "Escritura"
        Me.EscrituraDataGridViewCheckBoxColumn.Name = "EscrituraDataGridViewCheckBoxColumn"
        Me.EscrituraDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'EscrituraORGDataGridViewCheckBoxColumn
        '
        Me.EscrituraORGDataGridViewCheckBoxColumn.DataPropertyName = "EscrituraORG"
        Me.EscrituraORGDataGridViewCheckBoxColumn.HeaderText = "EscrituraORG"
        Me.EscrituraORGDataGridViewCheckBoxColumn.Name = "EscrituraORGDataGridViewCheckBoxColumn"
        Me.EscrituraORGDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'EscrituraTXTDataGridViewTextBoxColumn
        '
        Me.EscrituraTXTDataGridViewTextBoxColumn.DataPropertyName = "EscrituraTXT"
        Me.EscrituraTXTDataGridViewTextBoxColumn.HeaderText = "EscrituraTXT"
        Me.EscrituraTXTDataGridViewTextBoxColumn.Name = "EscrituraTXTDataGridViewTextBoxColumn"
        Me.EscrituraTXTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacturasDataGridViewCheckBoxColumn
        '
        Me.FacturasDataGridViewCheckBoxColumn.DataPropertyName = "Facturas"
        Me.FacturasDataGridViewCheckBoxColumn.HeaderText = "Facturas"
        Me.FacturasDataGridViewCheckBoxColumn.Name = "FacturasDataGridViewCheckBoxColumn"
        Me.FacturasDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FacturasORGDataGridViewCheckBoxColumn
        '
        Me.FacturasORGDataGridViewCheckBoxColumn.DataPropertyName = "FacturasORG"
        Me.FacturasORGDataGridViewCheckBoxColumn.HeaderText = "FacturasORG"
        Me.FacturasORGDataGridViewCheckBoxColumn.Name = "FacturasORGDataGridViewCheckBoxColumn"
        Me.FacturasORGDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FacturasTXTDataGridViewTextBoxColumn
        '
        Me.FacturasTXTDataGridViewTextBoxColumn.DataPropertyName = "FacturasTXT"
        Me.FacturasTXTDataGridViewTextBoxColumn.HeaderText = "FacturasTXT"
        Me.FacturasTXTDataGridViewTextBoxColumn.Name = "FacturasTXTDataGridViewTextBoxColumn"
        Me.FacturasTXTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GarantiasDataGridViewCheckBoxColumn
        '
        Me.GarantiasDataGridViewCheckBoxColumn.DataPropertyName = "Garantias"
        Me.GarantiasDataGridViewCheckBoxColumn.HeaderText = "Garantias"
        Me.GarantiasDataGridViewCheckBoxColumn.Name = "GarantiasDataGridViewCheckBoxColumn"
        Me.GarantiasDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'GarantiasORGDataGridViewCheckBoxColumn
        '
        Me.GarantiasORGDataGridViewCheckBoxColumn.DataPropertyName = "GarantiasORG"
        Me.GarantiasORGDataGridViewCheckBoxColumn.HeaderText = "GarantiasORG"
        Me.GarantiasORGDataGridViewCheckBoxColumn.Name = "GarantiasORGDataGridViewCheckBoxColumn"
        Me.GarantiasORGDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'GarantiasTXTDataGridViewTextBoxColumn
        '
        Me.GarantiasTXTDataGridViewTextBoxColumn.DataPropertyName = "GarantiasTXT"
        Me.GarantiasTXTDataGridViewTextBoxColumn.HeaderText = "GarantiasTXT"
        Me.GarantiasTXTDataGridViewTextBoxColumn.Name = "GarantiasTXTDataGridViewTextBoxColumn"
        Me.GarantiasTXTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JustificacionDataGridViewTextBoxColumn
        '
        Me.JustificacionDataGridViewTextBoxColumn.DataPropertyName = "Justificacion"
        Me.JustificacionDataGridViewTextBoxColumn.HeaderText = "Justificacion"
        Me.JustificacionDataGridViewTextBoxColumn.Name = "JustificacionDataGridViewTextBoxColumn"
        Me.JustificacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotaDataGridViewTextBoxColumn
        '
        Me.NotaDataGridViewTextBoxColumn.DataPropertyName = "Nota"
        Me.NotaDataGridViewTextBoxColumn.HeaderText = "Nota"
        Me.NotaDataGridViewTextBoxColumn.Name = "NotaDataGridViewTextBoxColumn"
        Me.NotaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Autoriza
        '
        Me.Autoriza.DataPropertyName = "Autoriza"
        Me.Autoriza.HeaderText = "Autoriza"
        Me.Autoriza.Name = "Autoriza"
        Me.Autoriza.ReadOnly = True
        '
        'AutorizaB
        '
        Me.AutorizaB.DataPropertyName = "AutorizaB"
        Me.AutorizaB.HeaderText = "Autorizada"
        Me.AutorizaB.Name = "AutorizaB"
        Me.AutorizaB.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Pld"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Pld"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "PldB"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Pld Aut."
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'NoAdeudo
        '
        Me.NoAdeudo.DataPropertyName = "NoAdeudo"
        Me.NoAdeudo.HeaderText = "NoAdeudo"
        Me.NoAdeudo.Name = "NoAdeudo"
        Me.NoAdeudo.ReadOnly = True
        '
        'AuditoriaExterna
        '
        Me.AuditoriaExterna.DataPropertyName = "AuditoriaExterna"
        Me.AuditoriaExterna.HeaderText = "AuditoriaExterna"
        Me.AuditoriaExterna.Name = "AuditoriaExterna"
        Me.AuditoriaExterna.ReadOnly = True
        '
        'GroupCont
        '
        Me.GroupCont.Controls.Add(Me.contrato_org)
        Me.GroupCont.Controls.Add(Me.txtcontrato)
        Me.GroupCont.Controls.Add(Me.txtid)
        Me.GroupCont.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VwBitacoraanexoBindingSource1, "Contrato", True))
        Me.GroupCont.Location = New System.Drawing.Point(6, 19)
        Me.GroupCont.Name = "GroupCont"
        Me.GroupCont.Size = New System.Drawing.Size(418, 68)
        Me.GroupCont.TabIndex = 49
        Me.GroupCont.TabStop = False
        Me.GroupCont.Text = "Contrato"
        '
        'contrato_org
        '
        Me.contrato_org.AutoSize = True
        Me.contrato_org.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VwBitacoraanexoBindingSource1, "ContratoORG", True))
        Me.contrato_org.Location = New System.Drawing.Point(291, 32)
        Me.contrato_org.Name = "contrato_org"
        Me.contrato_org.Size = New System.Drawing.Size(61, 17)
        Me.contrato_org.TabIndex = 7
        Me.contrato_org.Text = "Original"
        Me.contrato_org.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwBitacoraanexoBindingSource1, "Id_Bitacora", True))
        Me.txtid.Location = New System.Drawing.Point(25, 30)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(47, 20)
        Me.txtid.TabIndex = 57
        '
        'GroupConv
        '
        Me.GroupConv.Controls.Add(Me.convenio_org)
        Me.GroupConv.Controls.Add(Me.txtconvenio)
        Me.GroupConv.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VwBitacoraanexoBindingSource1, "Convenio", True))
        Me.GroupConv.Location = New System.Drawing.Point(6, 93)
        Me.GroupConv.Name = "GroupConv"
        Me.GroupConv.Size = New System.Drawing.Size(418, 68)
        Me.GroupConv.TabIndex = 50
        Me.GroupConv.TabStop = False
        Me.GroupConv.Text = "Convenio"
        '
        'convenio_org
        '
        Me.convenio_org.AutoSize = True
        Me.convenio_org.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VwBitacoraanexoBindingSource1, "ContratoORG", True))
        Me.convenio_org.Location = New System.Drawing.Point(291, 35)
        Me.convenio_org.Name = "convenio_org"
        Me.convenio_org.Size = New System.Drawing.Size(61, 17)
        Me.convenio_org.TabIndex = 9
        Me.convenio_org.Text = "Original"
        Me.convenio_org.UseVisualStyleBackColor = True
        '
        'txtconvenio
        '
        Me.txtconvenio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwBitacoraanexoBindingSource1, "ConvenioTXT", True))
        Me.txtconvenio.Location = New System.Drawing.Point(6, 29)
        Me.txtconvenio.Name = "txtconvenio"
        Me.txtconvenio.Size = New System.Drawing.Size(259, 20)
        Me.txtconvenio.TabIndex = 6
        '
        'GroupEscri
        '
        Me.GroupEscri.Controls.Add(Me.escrituras_org)
        Me.GroupEscri.Controls.Add(Me.txtescrituras)
        Me.GroupEscri.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VwBitacoraanexoBindingSource1, "Escritura", True))
        Me.GroupEscri.Location = New System.Drawing.Point(6, 167)
        Me.GroupEscri.Name = "GroupEscri"
        Me.GroupEscri.Size = New System.Drawing.Size(418, 68)
        Me.GroupEscri.TabIndex = 50
        Me.GroupEscri.TabStop = False
        Me.GroupEscri.Text = "Escrituras"
        '
        'escrituras_org
        '
        Me.escrituras_org.AutoSize = True
        Me.escrituras_org.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VwBitacoraanexoBindingSource1, "EscrituraORG", True))
        Me.escrituras_org.Location = New System.Drawing.Point(285, 29)
        Me.escrituras_org.Name = "escrituras_org"
        Me.escrituras_org.Size = New System.Drawing.Size(61, 17)
        Me.escrituras_org.TabIndex = 10
        Me.escrituras_org.Text = "Original"
        Me.escrituras_org.UseVisualStyleBackColor = True
        '
        'txtescrituras
        '
        Me.txtescrituras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwBitacoraanexoBindingSource1, "EscrituraTXT", True))
        Me.txtescrituras.Location = New System.Drawing.Point(6, 31)
        Me.txtescrituras.Name = "txtescrituras"
        Me.txtescrituras.Size = New System.Drawing.Size(259, 20)
        Me.txtescrituras.TabIndex = 6
        '
        'txtpagare
        '
        Me.txtpagare.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwBitacoraanexoBindingSource1, "PagareTXT", True))
        Me.txtpagare.Location = New System.Drawing.Point(6, 31)
        Me.txtpagare.Name = "txtpagare"
        Me.txtpagare.Size = New System.Drawing.Size(259, 20)
        Me.txtpagare.TabIndex = 11
        '
        'GroupPag
        '
        Me.GroupPag.Controls.Add(Me.pagare_org)
        Me.GroupPag.Controls.Add(Me.txtpagare)
        Me.GroupPag.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VwBitacoraanexoBindingSource1, "Pagare", True))
        Me.GroupPag.Location = New System.Drawing.Point(521, 167)
        Me.GroupPag.Name = "GroupPag"
        Me.GroupPag.Size = New System.Drawing.Size(418, 68)
        Me.GroupPag.TabIndex = 53
        Me.GroupPag.TabStop = False
        Me.GroupPag.Text = "Pagaré"
        '
        'pagare_org
        '
        Me.pagare_org.AutoSize = True
        Me.pagare_org.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VwBitacoraanexoBindingSource1, "PagareORG", True))
        Me.pagare_org.Location = New System.Drawing.Point(290, 31)
        Me.pagare_org.Name = "pagare_org"
        Me.pagare_org.Size = New System.Drawing.Size(61, 17)
        Me.pagare_org.TabIndex = 12
        Me.pagare_org.Text = "Original"
        Me.pagare_org.UseVisualStyleBackColor = True
        '
        'GroupGarant
        '
        Me.GroupGarant.Controls.Add(Me.garantias_org)
        Me.GroupGarant.Controls.Add(Me.txtgarantias)
        Me.GroupGarant.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VwBitacoraanexoBindingSource1, "Garantias", True))
        Me.GroupGarant.Location = New System.Drawing.Point(521, 93)
        Me.GroupGarant.Name = "GroupGarant"
        Me.GroupGarant.Size = New System.Drawing.Size(418, 68)
        Me.GroupGarant.TabIndex = 52
        Me.GroupGarant.TabStop = False
        Me.GroupGarant.Text = "Garantias"
        '
        'garantias_org
        '
        Me.garantias_org.AutoSize = True
        Me.garantias_org.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VwBitacoraanexoBindingSource1, "GarantiasORG", True))
        Me.garantias_org.Location = New System.Drawing.Point(290, 29)
        Me.garantias_org.Name = "garantias_org"
        Me.garantias_org.Size = New System.Drawing.Size(61, 17)
        Me.garantias_org.TabIndex = 10
        Me.garantias_org.Text = "Original"
        Me.garantias_org.UseVisualStyleBackColor = True
        '
        'txtgarantias
        '
        Me.txtgarantias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwBitacoraanexoBindingSource1, "GarantiasTXT", True))
        Me.txtgarantias.Location = New System.Drawing.Point(6, 32)
        Me.txtgarantias.Name = "txtgarantias"
        Me.txtgarantias.Size = New System.Drawing.Size(259, 20)
        Me.txtgarantias.TabIndex = 9
        '
        'GroupFact
        '
        Me.GroupFact.Controls.Add(Me.txtfacturas)
        Me.GroupFact.Controls.Add(Me.facturas_org)
        Me.GroupFact.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VwBitacoraanexoBindingSource1, "Facturas", True))
        Me.GroupFact.Location = New System.Drawing.Point(521, 19)
        Me.GroupFact.Name = "GroupFact"
        Me.GroupFact.Size = New System.Drawing.Size(418, 68)
        Me.GroupFact.TabIndex = 51
        Me.GroupFact.TabStop = False
        Me.GroupFact.Text = "Facturas"
        '
        'txtfacturas
        '
        Me.txtfacturas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwBitacoraanexoBindingSource1, "FacturasTXT", True))
        Me.txtfacturas.Location = New System.Drawing.Point(6, 29)
        Me.txtfacturas.Name = "txtfacturas"
        Me.txtfacturas.Size = New System.Drawing.Size(259, 20)
        Me.txtfacturas.TabIndex = 6
        '
        'facturas_org
        '
        Me.facturas_org.AutoSize = True
        Me.facturas_org.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VwBitacoraanexoBindingSource1, "FacturasORG", True))
        Me.facturas_org.Location = New System.Drawing.Point(290, 32)
        Me.facturas_org.Name = "facturas_org"
        Me.facturas_org.Size = New System.Drawing.Size(61, 17)
        Me.facturas_org.TabIndex = 8
        Me.facturas_org.Text = "Original"
        Me.facturas_org.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Fe. Devolución"
        '
        'dt
        '
        Me.dt.Location = New System.Drawing.Point(471, 32)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(233, 20)
        Me.dt.TabIndex = 55
        '
        'grupo
        '
        Me.grupo.Controls.Add(Me.CkPagare)
        Me.grupo.Controls.Add(Me.CkGarant)
        Me.grupo.Controls.Add(Me.CkFact)
        Me.grupo.Controls.Add(Me.CkEscri)
        Me.grupo.Controls.Add(Me.CkConv)
        Me.grupo.Controls.Add(Me.CkCont)
        Me.grupo.Controls.Add(Me.GroupCont)
        Me.grupo.Controls.Add(Me.Label9)
        Me.grupo.Controls.Add(Me.txtnota)
        Me.grupo.Controls.Add(Me.GroupPag)
        Me.grupo.Controls.Add(Me.GroupConv)
        Me.grupo.Controls.Add(Me.GroupEscri)
        Me.grupo.Controls.Add(Me.GroupFact)
        Me.grupo.Controls.Add(Me.GroupGarant)
        Me.grupo.Controls.Add(Me.CkAutoriza)
        Me.grupo.Location = New System.Drawing.Point(30, 186)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(967, 342)
        Me.grupo.TabIndex = 56
        Me.grupo.TabStop = False
        '
        'CkPagare
        '
        Me.CkPagare.AutoSize = True
        Me.CkPagare.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VwBitacoraanexoBindingSource1, "Pagare", True))
        Me.CkPagare.Location = New System.Drawing.Point(946, 167)
        Me.CkPagare.Name = "CkPagare"
        Me.CkPagare.Size = New System.Drawing.Size(15, 14)
        Me.CkPagare.TabIndex = 63
        Me.CkPagare.UseVisualStyleBackColor = True
        '
        'CkGarant
        '
        Me.CkGarant.AutoSize = True
        Me.CkGarant.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VwBitacoraanexoBindingSource1, "Garantias", True))
        Me.CkGarant.Location = New System.Drawing.Point(945, 93)
        Me.CkGarant.Name = "CkGarant"
        Me.CkGarant.Size = New System.Drawing.Size(15, 14)
        Me.CkGarant.TabIndex = 62
        Me.CkGarant.UseVisualStyleBackColor = True
        '
        'CkFact
        '
        Me.CkFact.AutoSize = True
        Me.CkFact.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VwBitacoraanexoBindingSource1, "Facturas", True))
        Me.CkFact.Location = New System.Drawing.Point(946, 19)
        Me.CkFact.Name = "CkFact"
        Me.CkFact.Size = New System.Drawing.Size(15, 14)
        Me.CkFact.TabIndex = 61
        Me.CkFact.UseVisualStyleBackColor = True
        '
        'CkEscri
        '
        Me.CkEscri.AutoSize = True
        Me.CkEscri.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VwBitacoraanexoBindingSource1, "Escritura", True))
        Me.CkEscri.Location = New System.Drawing.Point(430, 167)
        Me.CkEscri.Name = "CkEscri"
        Me.CkEscri.Size = New System.Drawing.Size(15, 14)
        Me.CkEscri.TabIndex = 60
        Me.CkEscri.UseVisualStyleBackColor = True
        '
        'CkConv
        '
        Me.CkConv.AutoSize = True
        Me.CkConv.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VwBitacoraanexoBindingSource1, "Convenio", True))
        Me.CkConv.Location = New System.Drawing.Point(430, 93)
        Me.CkConv.Name = "CkConv"
        Me.CkConv.Size = New System.Drawing.Size(15, 14)
        Me.CkConv.TabIndex = 59
        Me.CkConv.UseVisualStyleBackColor = True
        '
        'CkCont
        '
        Me.CkCont.AutoSize = True
        Me.CkCont.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VwBitacoraanexoBindingSource1, "Contrato", True))
        Me.CkCont.Location = New System.Drawing.Point(430, 19)
        Me.CkCont.Name = "CkCont"
        Me.CkCont.Size = New System.Drawing.Size(15, 14)
        Me.CkCont.TabIndex = 58
        Me.CkCont.UseVisualStyleBackColor = True
        '
        'CkAutoriza
        '
        Me.CkAutoriza.AutoSize = True
        Me.CkAutoriza.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VwBitacoraanexoBindingSource1, "AutorizaB", True))
        Me.CkAutoriza.Enabled = False
        Me.CkAutoriza.Location = New System.Drawing.Point(452, 294)
        Me.CkAutoriza.Name = "CkAutoriza"
        Me.CkAutoriza.Size = New System.Drawing.Size(15, 14)
        Me.CkAutoriza.TabIndex = 64
        Me.CkAutoriza.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(677, 534)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(76, 29)
        Me.BtnPrint.TabIndex = 57
        Me.BtnPrint.Text = "Imprimir"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(433, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Filtro Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(719, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Filtro Anexo"
        '
        'TxtFiltroCliente
        '
        Me.TxtFiltroCliente.Location = New System.Drawing.Point(503, 6)
        Me.TxtFiltroCliente.Name = "TxtFiltroCliente"
        Me.TxtFiltroCliente.Size = New System.Drawing.Size(210, 20)
        Me.TxtFiltroCliente.TabIndex = 60
        '
        'TxtFiltroAnexo
        '
        Me.TxtFiltroAnexo.Location = New System.Drawing.Point(787, 6)
        Me.TxtFiltroAnexo.Mask = "00000/0000"
        Me.TxtFiltroAnexo.Name = "TxtFiltroAnexo"
        Me.TxtFiltroAnexo.Size = New System.Drawing.Size(74, 20)
        Me.TxtFiltroAnexo.TabIndex = 61
        '
        'TxtFiltroUser
        '
        Me.TxtFiltroUser.Location = New System.Drawing.Point(938, 6)
        Me.TxtFiltroUser.Name = "TxtFiltroUser"
        Me.TxtFiltroUser.Size = New System.Drawing.Size(59, 20)
        Me.TxtFiltroUser.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(867, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Filtro Usuario"
        '
        'VwBitacoraanexoBindingSource
        '
        Me.VwBitacoraanexoBindingSource.DataMember = "Vw_Bitacora_anexo"
        Me.VwBitacoraanexoBindingSource.DataSource = Me.MesaControlDS
        '
        'MCBitacoraBindingSource2
        '
        Me.MCBitacoraBindingSource2.DataMember = "MC_Bitacora"
        Me.MCBitacoraBindingSource2.DataSource = Me.MesaControlDS
        '
        'MCBitacoraBindingSource
        '
        Me.MCBitacoraBindingSource.DataMember = "MC_Bitacora"
        Me.MCBitacoraBindingSource.DataSource = Me.MesaControlDS
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.MesaControlDS
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'MC_BitacoraTableAdapter
        '
        Me.MC_BitacoraTableAdapter.ClearBeforeFill = True
        '
        'MCBitacoraBindingSource1
        '
        Me.MCBitacoraBindingSource1.DataMember = "MC_Bitacora"
        Me.MCBitacoraBindingSource1.DataSource = Me.MesaControlDS
        '
        'Vw_Bitacora_anexoTableAdapter
        '
        Me.Vw_Bitacora_anexoTableAdapter.ClearBeforeFill = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Enabled = False
        Me.ButtonDelete.Location = New System.Drawing.Point(921, 534)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(76, 29)
        Me.ButtonDelete.TabIndex = 64
        Me.ButtonDelete.Text = "Borrar"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'frm_solicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 573)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.TxtFiltroUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtFiltroAnexo)
        Me.Controls.Add(Me.TxtFiltroCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.grupo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_entregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rb_devueltos)
        Me.Controls.Add(Me.rb_entregados)
        Me.Controls.Add(Me.rb_pendientes)
        Me.Name = "frm_solicitudes"
        Me.Text = "Solicitudes"
        CType(Me.VwBitacoraanexoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesaControlDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupCont.ResumeLayout(False)
        Me.GroupCont.PerformLayout()
        Me.GroupConv.ResumeLayout(False)
        Me.GroupConv.PerformLayout()
        Me.GroupEscri.ResumeLayout(False)
        Me.GroupEscri.PerformLayout()
        Me.GroupPag.ResumeLayout(False)
        Me.GroupPag.PerformLayout()
        Me.GroupGarant.ResumeLayout(False)
        Me.GroupGarant.PerformLayout()
        Me.GroupFact.ResumeLayout(False)
        Me.GroupFact.PerformLayout()
        Me.grupo.ResumeLayout(False)
        Me.grupo.PerformLayout()
        CType(Me.VwBitacoraanexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCBitacoraBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCBitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCBitacoraBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MesaControlDS As Agil.MesaControlDS
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Agil.MesaControlDSTableAdapters.ClientesTableAdapter
    Friend WithEvents rb_pendientes As System.Windows.Forms.RadioButton
    Friend WithEvents rb_entregados As System.Windows.Forms.RadioButton
    Friend WithEvents rb_devueltos As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MCBitacoraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MC_BitacoraTableAdapter As Agil.MesaControlDSTableAdapters.MC_BitacoraTableAdapter
    Friend WithEvents txtcontrato As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtnota As System.Windows.Forms.TextBox
    Friend WithEvents btn_entregar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents MCBitacoraBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MCBitacoraBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents VwBitacoraanexoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_Bitacora_anexoTableAdapter As Agil.MesaControlDSTableAdapters.Vw_Bitacora_anexoTableAdapter
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents VwBitacoraanexoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GroupCont As System.Windows.Forms.GroupBox
    Friend WithEvents GroupConv As System.Windows.Forms.GroupBox
    Friend WithEvents txtconvenio As System.Windows.Forms.TextBox
    Friend WithEvents GroupEscri As System.Windows.Forms.GroupBox
    Friend WithEvents txtescrituras As System.Windows.Forms.TextBox
    Friend WithEvents txtpagare As System.Windows.Forms.TextBox
    Friend WithEvents GroupPag As System.Windows.Forms.GroupBox
    Friend WithEvents GroupGarant As System.Windows.Forms.GroupBox
    Friend WithEvents txtgarantias As System.Windows.Forms.TextBox
    Friend WithEvents GroupFact As System.Windows.Forms.GroupBox
    Friend WithEvents txtfacturas As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents grupo As System.Windows.Forms.GroupBox
    Friend WithEvents contrato_org As System.Windows.Forms.CheckBox
    Friend WithEvents convenio_org As System.Windows.Forms.CheckBox
    Friend WithEvents escrituras_org As System.Windows.Forms.CheckBox
    Friend WithEvents pagare_org As System.Windows.Forms.CheckBox
    Friend WithEvents garantias_org As System.Windows.Forms.CheckBox
    Friend WithEvents facturas_org As System.Windows.Forms.CheckBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrint As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtFiltroCliente As TextBox
    Friend WithEvents TxtFiltroAnexo As MaskedTextBox
    Friend WithEvents CkPagare As CheckBox
    Friend WithEvents CkGarant As CheckBox
    Friend WithEvents CkFact As CheckBox
    Friend WithEvents CkEscri As CheckBox
    Friend WithEvents CkConv As CheckBox
    Friend WithEvents CkCont As CheckBox
    Friend WithEvents TxtFiltroUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CkAutoriza As CheckBox
    Friend WithEvents IdBitacoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCredito As DataGridViewTextBoxColumn
    Friend WithEvents Sucursal As DataGridViewTextBoxColumn
    Friend WithEvents CicloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SolicitoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VoboDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VoboB As DataGridViewCheckBoxColumn
    Friend WithEvents FechaSolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntregaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDevolucionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagareDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PagareORGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PagareTXTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContratoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ContratoORGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ContratoTXTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConvenioDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ConvenioORGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ConvenioTXTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EscrituraDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EscrituraORGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EscrituraTXTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturasDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FacturasORGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FacturasTXTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GarantiasDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents GarantiasORGDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents GarantiasTXTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JustificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Autoriza As DataGridViewTextBoxColumn
    Friend WithEvents AutorizaB As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents NoAdeudo As DataGridViewCheckBoxColumn
    Friend WithEvents AuditoriaExterna As DataGridViewCheckBoxColumn
    Friend WithEvents ButtonDelete As Button
End Class
