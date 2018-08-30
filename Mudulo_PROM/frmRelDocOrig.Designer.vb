<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelDocOrig
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
        Dim TipoLabel As System.Windows.Forms.Label
        Dim SucursalLabel As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditoDS = New Agil.CreditoDS()
        Me.CreditoDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Agil.CreditoDSTableAdapters.ClientesTableAdapter()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.TableAdapterManager = New Agil.CreditoDSTableAdapters.TableAdapterManager()
        Me.txtFiltroCliente = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.SucursalTextBox = New System.Windows.Forms.TextBox()
        Me.cmbAnalista = New System.Windows.Forms.ComboBox()
        Me.UsuariosFinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguridadDS = New Agil.SeguridadDS()
        Me.UsuariosFinagilTableAdapter = New Agil.SeguridadDSTableAdapters.UsuariosFinagilTableAdapter()
        Me.txtSucursalName = New System.Windows.Forms.TextBox()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.gbxDocumentos = New System.Windows.Forms.GroupBox()
        Me.lbSellCotejo = New System.Windows.Forms.Label()
        Me.lbCopOrig = New System.Windows.Forms.Label()
        Me.lbOrig = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chk_cot18 = New System.Windows.Forms.CheckBox()
        Me.chk_cot17 = New System.Windows.Forms.CheckBox()
        Me.chk_cot16 = New System.Windows.Forms.CheckBox()
        Me.chk_cot15 = New System.Windows.Forms.CheckBox()
        Me.chk_cot14 = New System.Windows.Forms.CheckBox()
        Me.chk_cot13 = New System.Windows.Forms.CheckBox()
        Me.chk_cot12 = New System.Windows.Forms.CheckBox()
        Me.chk_cot11 = New System.Windows.Forms.CheckBox()
        Me.chk_cot10 = New System.Windows.Forms.CheckBox()
        Me.chk_cot9 = New System.Windows.Forms.CheckBox()
        Me.chk_cot8 = New System.Windows.Forms.CheckBox()
        Me.chk_cot7 = New System.Windows.Forms.CheckBox()
        Me.chk_cot6 = New System.Windows.Forms.CheckBox()
        Me.chk_cot5 = New System.Windows.Forms.CheckBox()
        Me.chk_cot4 = New System.Windows.Forms.CheckBox()
        Me.chk_cot3 = New System.Windows.Forms.CheckBox()
        Me.chk_cot2 = New System.Windows.Forms.CheckBox()
        Me.chk_cot1 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_18 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_17 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_16 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_15 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_14 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_13 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_12 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_11 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_10 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_9 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_8 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_7 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_6 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_5 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_4 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_3 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_2 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_1 = New System.Windows.Forms.CheckBox()
        Me.txtObs_18 = New System.Windows.Forms.TextBox()
        Me.txtObs_17 = New System.Windows.Forms.TextBox()
        Me.txtObs_16 = New System.Windows.Forms.TextBox()
        Me.txtObs_15 = New System.Windows.Forms.TextBox()
        Me.txtObs_14 = New System.Windows.Forms.TextBox()
        Me.txtObs_13 = New System.Windows.Forms.TextBox()
        Me.txtObs_12 = New System.Windows.Forms.TextBox()
        Me.txtObs_11 = New System.Windows.Forms.TextBox()
        Me.txtObs_10 = New System.Windows.Forms.TextBox()
        Me.txtObs_9 = New System.Windows.Forms.TextBox()
        Me.txtObs_8 = New System.Windows.Forms.TextBox()
        Me.txtObs_7 = New System.Windows.Forms.TextBox()
        Me.txtObs_6 = New System.Windows.Forms.TextBox()
        Me.txtObs_5 = New System.Windows.Forms.TextBox()
        Me.txtObs_4 = New System.Windows.Forms.TextBox()
        Me.txtObs_3 = New System.Windows.Forms.TextBox()
        Me.txtObs_2 = New System.Windows.Forms.TextBox()
        Me.txtObs_1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkb_18 = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chkb_17 = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkb_16 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkb_15 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkb_14 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkb_13 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkb_12 = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkb_11 = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkb_10 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkb_9 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkb_8 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkb_7 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkb_6 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkb_5 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkb_4 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkb_3 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkb_2 = New System.Windows.Forms.CheckBox()
        Me.lb_1 = New System.Windows.Forms.Label()
        Me.chkb_1 = New System.Windows.Forms.CheckBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lbObservaciones = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.CRED_RelDocumentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRED_RelDocumentosTableAdapter = New Agil.CreditoDSTableAdapters.CRED_RelDocumentosTableAdapter()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.GENProductosFinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEN_ProductosFinagilTableAdapter = New Agil.CreditoDSTableAdapters.GEN_ProductosFinagilTableAdapter()
        Me.lbProducto = New System.Windows.Forms.Label()
        Me.lbAnalista = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.gbFiltroCliente = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.lbFiltroClientesCb = New System.Windows.Forms.Label()
        Me.btnReimprimir = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbObservacionesDet = New System.Windows.Forms.Label()
        Me.chk_cot19 = New System.Windows.Forms.CheckBox()
        Me.chkb_cop_19 = New System.Windows.Forms.CheckBox()
        Me.txtObs_19 = New System.Windows.Forms.TextBox()
        Me.chkb_19 = New System.Windows.Forms.CheckBox()
        TipoLabel = New System.Windows.Forms.Label()
        SucursalLabel = New System.Windows.Forms.Label()
        ClienteLabel = New System.Windows.Forms.Label()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosFinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDocumentos.SuspendLayout()
        CType(Me.CRED_RelDocumentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GENProductosFinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltroCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Enabled = False
        TipoLabel.Location = New System.Drawing.Point(742, 13)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 2
        TipoLabel.Text = "Tipo:"
        '
        'SucursalLabel
        '
        SucursalLabel.AutoSize = True
        SucursalLabel.Enabled = False
        SucursalLabel.Location = New System.Drawing.Point(811, 13)
        SucursalLabel.Name = "SucursalLabel"
        SucursalLabel.Size = New System.Drawing.Size(51, 13)
        SucursalLabel.TabIndex = 4
        SucursalLabel.Text = "Sucursal:"
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Location = New System.Drawing.Point(585, 14)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(42, 13)
        ClienteLabel.TabIndex = 67
        ClienteLabel.Text = "Cliente:"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.CreditoDS
        '
        'CreditoDS
        '
        Me.CreditoDS.DataSetName = "CreditoDS"
        Me.CreditoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CreditoDSBindingSource
        '
        Me.CreditoDSBindingSource.DataSource = Me.CreditoDS
        Me.CreditoDSBindingSource.Position = 0
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'cmbClientes
        '
        Me.cmbClientes.DataSource = Me.ClientesBindingSource
        Me.cmbClientes.DisplayMember = "Descr"
        Me.cmbClientes.Enabled = False
        Me.cmbClientes.Location = New System.Drawing.Point(17, 68)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(535, 21)
        Me.cmbClientes.TabIndex = 2
        Me.cmbClientes.ValueMember = "Cliente"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AviosDetTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.CRED_CatalogoEstatusTableAdapter = Nothing
        Me.TableAdapterManager.CRED_LineasCreditoTableAdapter = Nothing
        Me.TableAdapterManager.CRED_RelDocumentosTableAdapter = Nothing
        Me.TableAdapterManager.CRED_SeguimientoDocumentosTableAdapter = Nothing
        Me.TableAdapterManager.CRED_SeguimientoTableAdapter = Nothing
        Me.TableAdapterManager.GEN_ProductosFinagilTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Agil.CreditoDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtFiltroCliente
        '
        Me.txtFiltroCliente.Location = New System.Drawing.Point(17, 26)
        Me.txtFiltroCliente.Name = "txtFiltroCliente"
        Me.txtFiltroCliente.Size = New System.Drawing.Size(455, 20)
        Me.txtFiltroCliente.TabIndex = 1
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Tipo", True))
        Me.TipoTextBox.Enabled = False
        Me.TipoTextBox.Location = New System.Drawing.Point(774, 11)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(27, 20)
        Me.TipoTextBox.TabIndex = 2
        '
        'SucursalTextBox
        '
        Me.SucursalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Sucursal", True))
        Me.SucursalTextBox.Enabled = False
        Me.SucursalTextBox.Location = New System.Drawing.Point(864, 10)
        Me.SucursalTextBox.Name = "SucursalTextBox"
        Me.SucursalTextBox.Size = New System.Drawing.Size(27, 20)
        Me.SucursalTextBox.TabIndex = 3
        '
        'cmbAnalista
        '
        Me.cmbAnalista.DataSource = Me.UsuariosFinagilBindingSource
        Me.cmbAnalista.DisplayMember = "NombreCompleto"
        Me.cmbAnalista.FormattingEnabled = True
        Me.cmbAnalista.Location = New System.Drawing.Point(644, 64)
        Me.cmbAnalista.Name = "cmbAnalista"
        Me.cmbAnalista.Size = New System.Drawing.Size(382, 21)
        Me.cmbAnalista.TabIndex = 6
        '
        'UsuariosFinagilBindingSource
        '
        Me.UsuariosFinagilBindingSource.DataMember = "UsuariosFinagil"
        Me.UsuariosFinagilBindingSource.DataSource = Me.SeguridadDS
        '
        'SeguridadDS
        '
        Me.SeguridadDS.DataSetName = "SeguridadDS"
        Me.SeguridadDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosFinagilTableAdapter
        '
        Me.UsuariosFinagilTableAdapter.ClearBeforeFill = True
        '
        'txtSucursalName
        '
        Me.txtSucursalName.Enabled = False
        Me.txtSucursalName.Location = New System.Drawing.Point(897, 10)
        Me.txtSucursalName.Name = "txtSucursalName"
        Me.txtSucursalName.Size = New System.Drawing.Size(129, 20)
        Me.txtSucursalName.TabIndex = 4
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataSource = Me.CreditoDS
        Me.SucursalesBindingSource.Position = 0
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(644, 91)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(203, 20)
        Me.dtpFecha.TabIndex = 7
        '
        'gbxDocumentos
        '
        Me.gbxDocumentos.Controls.Add(Me.chk_cot19)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_19)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_19)
        Me.gbxDocumentos.Controls.Add(Me.chkb_19)
        Me.gbxDocumentos.Controls.Add(Me.lbObservacionesDet)
        Me.gbxDocumentos.Controls.Add(Me.Label19)
        Me.gbxDocumentos.Controls.Add(Me.lbSellCotejo)
        Me.gbxDocumentos.Controls.Add(Me.lbCopOrig)
        Me.gbxDocumentos.Controls.Add(Me.lbOrig)
        Me.gbxDocumentos.Controls.Add(Me.Label18)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot18)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot17)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot16)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot15)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot14)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot13)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot12)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot11)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot10)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot9)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot8)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot7)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot6)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot5)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot4)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot3)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot2)
        Me.gbxDocumentos.Controls.Add(Me.chk_cot1)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_18)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_17)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_16)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_15)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_14)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_13)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_12)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_11)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_10)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_9)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_8)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_7)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_6)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_5)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_4)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_3)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_2)
        Me.gbxDocumentos.Controls.Add(Me.chkb_cop_1)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_18)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_17)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_16)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_15)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_14)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_13)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_12)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_11)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_10)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_9)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_8)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_7)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_6)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_5)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_4)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_3)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_2)
        Me.gbxDocumentos.Controls.Add(Me.txtObs_1)
        Me.gbxDocumentos.Controls.Add(Me.Label17)
        Me.gbxDocumentos.Controls.Add(Me.chkb_18)
        Me.gbxDocumentos.Controls.Add(Me.Label16)
        Me.gbxDocumentos.Controls.Add(Me.chkb_17)
        Me.gbxDocumentos.Controls.Add(Me.Label15)
        Me.gbxDocumentos.Controls.Add(Me.chkb_16)
        Me.gbxDocumentos.Controls.Add(Me.Label14)
        Me.gbxDocumentos.Controls.Add(Me.chkb_15)
        Me.gbxDocumentos.Controls.Add(Me.Label13)
        Me.gbxDocumentos.Controls.Add(Me.chkb_14)
        Me.gbxDocumentos.Controls.Add(Me.Label12)
        Me.gbxDocumentos.Controls.Add(Me.chkb_13)
        Me.gbxDocumentos.Controls.Add(Me.Label11)
        Me.gbxDocumentos.Controls.Add(Me.chkb_12)
        Me.gbxDocumentos.Controls.Add(Me.Label10)
        Me.gbxDocumentos.Controls.Add(Me.chkb_11)
        Me.gbxDocumentos.Controls.Add(Me.Label9)
        Me.gbxDocumentos.Controls.Add(Me.chkb_10)
        Me.gbxDocumentos.Controls.Add(Me.Label8)
        Me.gbxDocumentos.Controls.Add(Me.chkb_9)
        Me.gbxDocumentos.Controls.Add(Me.Label7)
        Me.gbxDocumentos.Controls.Add(Me.chkb_8)
        Me.gbxDocumentos.Controls.Add(Me.Label6)
        Me.gbxDocumentos.Controls.Add(Me.chkb_7)
        Me.gbxDocumentos.Controls.Add(Me.Label5)
        Me.gbxDocumentos.Controls.Add(Me.chkb_6)
        Me.gbxDocumentos.Controls.Add(Me.Label4)
        Me.gbxDocumentos.Controls.Add(Me.chkb_5)
        Me.gbxDocumentos.Controls.Add(Me.Label3)
        Me.gbxDocumentos.Controls.Add(Me.chkb_4)
        Me.gbxDocumentos.Controls.Add(Me.Label2)
        Me.gbxDocumentos.Controls.Add(Me.chkb_3)
        Me.gbxDocumentos.Controls.Add(Me.Label1)
        Me.gbxDocumentos.Controls.Add(Me.chkb_2)
        Me.gbxDocumentos.Controls.Add(Me.lb_1)
        Me.gbxDocumentos.Controls.Add(Me.chkb_1)
        Me.gbxDocumentos.Location = New System.Drawing.Point(15, 116)
        Me.gbxDocumentos.Name = "gbxDocumentos"
        Me.gbxDocumentos.Size = New System.Drawing.Size(1011, 514)
        Me.gbxDocumentos.TabIndex = 41
        Me.gbxDocumentos.TabStop = False
        Me.gbxDocumentos.Text = "Documentos:"
        '
        'lbSellCotejo
        '
        Me.lbSellCotejo.AutoSize = True
        Me.lbSellCotejo.Location = New System.Drawing.Point(608, 12)
        Me.lbSellCotejo.Name = "lbSellCotejo"
        Me.lbSellCotejo.Size = New System.Drawing.Size(63, 13)
        Me.lbSellCotejo.TabIndex = 83
        Me.lbSellCotejo.Text = "Cop. S/Cot."
        '
        'lbCopOrig
        '
        Me.lbCopOrig.AutoSize = True
        Me.lbCopOrig.Location = New System.Drawing.Point(530, 12)
        Me.lbCopOrig.Name = "lbCopOrig"
        Me.lbCopOrig.Size = New System.Drawing.Size(63, 13)
        Me.lbCopOrig.TabIndex = 82
        Me.lbCopOrig.Text = "Cop. C/Cot."
        '
        'lbOrig
        '
        Me.lbOrig.AutoSize = True
        Me.lbOrig.Location = New System.Drawing.Point(470, 12)
        Me.lbOrig.Name = "lbOrig"
        Me.lbOrig.Size = New System.Drawing.Size(42, 13)
        Me.lbOrig.TabIndex = 81
        Me.lbOrig.Text = "Original"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 347)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(172, 13)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "       firmadas por el cliente y/o R.L."
        '
        'chk_cot18
        '
        Me.chk_cot18.AutoSize = True
        Me.chk_cot18.Location = New System.Drawing.Point(612, 465)
        Me.chk_cot18.Name = "chk_cot18"
        Me.chk_cot18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot18.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot18.TabIndex = 78
        Me.chk_cot18.Text = "-"
        Me.chk_cot18.UseVisualStyleBackColor = True
        '
        'chk_cot17
        '
        Me.chk_cot17.AutoSize = True
        Me.chk_cot17.Location = New System.Drawing.Point(611, 440)
        Me.chk_cot17.Name = "chk_cot17"
        Me.chk_cot17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot17.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot17.TabIndex = 74
        Me.chk_cot17.Text = "-"
        Me.chk_cot17.UseVisualStyleBackColor = True
        '
        'chk_cot16
        '
        Me.chk_cot16.AutoSize = True
        Me.chk_cot16.Location = New System.Drawing.Point(611, 415)
        Me.chk_cot16.Name = "chk_cot16"
        Me.chk_cot16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot16.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot16.TabIndex = 70
        Me.chk_cot16.Text = "-"
        Me.chk_cot16.UseVisualStyleBackColor = True
        '
        'chk_cot15
        '
        Me.chk_cot15.AutoSize = True
        Me.chk_cot15.Location = New System.Drawing.Point(611, 390)
        Me.chk_cot15.Name = "chk_cot15"
        Me.chk_cot15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot15.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot15.TabIndex = 66
        Me.chk_cot15.Text = "-"
        Me.chk_cot15.UseVisualStyleBackColor = True
        '
        'chk_cot14
        '
        Me.chk_cot14.AutoSize = True
        Me.chk_cot14.Location = New System.Drawing.Point(611, 365)
        Me.chk_cot14.Name = "chk_cot14"
        Me.chk_cot14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot14.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot14.TabIndex = 62
        Me.chk_cot14.Text = "-"
        Me.chk_cot14.UseVisualStyleBackColor = True
        '
        'chk_cot13
        '
        Me.chk_cot13.AutoSize = True
        Me.chk_cot13.Location = New System.Drawing.Point(611, 331)
        Me.chk_cot13.Name = "chk_cot13"
        Me.chk_cot13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot13.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot13.TabIndex = 58
        Me.chk_cot13.Text = "-"
        Me.chk_cot13.UseVisualStyleBackColor = True
        '
        'chk_cot12
        '
        Me.chk_cot12.AutoSize = True
        Me.chk_cot12.Location = New System.Drawing.Point(611, 307)
        Me.chk_cot12.Name = "chk_cot12"
        Me.chk_cot12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot12.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot12.TabIndex = 54
        Me.chk_cot12.Text = "-"
        Me.chk_cot12.UseVisualStyleBackColor = True
        '
        'chk_cot11
        '
        Me.chk_cot11.AutoSize = True
        Me.chk_cot11.Location = New System.Drawing.Point(612, 283)
        Me.chk_cot11.Name = "chk_cot11"
        Me.chk_cot11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot11.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot11.TabIndex = 50
        Me.chk_cot11.Text = "-"
        Me.chk_cot11.UseVisualStyleBackColor = True
        '
        'chk_cot10
        '
        Me.chk_cot10.AutoSize = True
        Me.chk_cot10.Location = New System.Drawing.Point(611, 259)
        Me.chk_cot10.Name = "chk_cot10"
        Me.chk_cot10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot10.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot10.TabIndex = 46
        Me.chk_cot10.Text = "-"
        Me.chk_cot10.UseVisualStyleBackColor = True
        '
        'chk_cot9
        '
        Me.chk_cot9.AutoSize = True
        Me.chk_cot9.Location = New System.Drawing.Point(611, 235)
        Me.chk_cot9.Name = "chk_cot9"
        Me.chk_cot9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot9.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot9.TabIndex = 42
        Me.chk_cot9.Text = "-"
        Me.chk_cot9.UseVisualStyleBackColor = True
        '
        'chk_cot8
        '
        Me.chk_cot8.AutoSize = True
        Me.chk_cot8.Location = New System.Drawing.Point(611, 211)
        Me.chk_cot8.Name = "chk_cot8"
        Me.chk_cot8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot8.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot8.TabIndex = 38
        Me.chk_cot8.Text = "-"
        Me.chk_cot8.UseVisualStyleBackColor = True
        '
        'chk_cot7
        '
        Me.chk_cot7.AutoSize = True
        Me.chk_cot7.Location = New System.Drawing.Point(611, 187)
        Me.chk_cot7.Name = "chk_cot7"
        Me.chk_cot7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot7.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot7.TabIndex = 34
        Me.chk_cot7.Text = "-"
        Me.chk_cot7.UseVisualStyleBackColor = True
        '
        'chk_cot6
        '
        Me.chk_cot6.AutoSize = True
        Me.chk_cot6.Location = New System.Drawing.Point(611, 163)
        Me.chk_cot6.Name = "chk_cot6"
        Me.chk_cot6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot6.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot6.TabIndex = 30
        Me.chk_cot6.Text = "-"
        Me.chk_cot6.UseVisualStyleBackColor = True
        '
        'chk_cot5
        '
        Me.chk_cot5.AutoSize = True
        Me.chk_cot5.Location = New System.Drawing.Point(611, 139)
        Me.chk_cot5.Name = "chk_cot5"
        Me.chk_cot5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot5.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot5.TabIndex = 26
        Me.chk_cot5.Text = "-"
        Me.chk_cot5.UseVisualStyleBackColor = True
        '
        'chk_cot4
        '
        Me.chk_cot4.AutoSize = True
        Me.chk_cot4.Location = New System.Drawing.Point(611, 115)
        Me.chk_cot4.Name = "chk_cot4"
        Me.chk_cot4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot4.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot4.TabIndex = 22
        Me.chk_cot4.Text = "-"
        Me.chk_cot4.UseVisualStyleBackColor = True
        '
        'chk_cot3
        '
        Me.chk_cot3.AutoSize = True
        Me.chk_cot3.Location = New System.Drawing.Point(611, 91)
        Me.chk_cot3.Name = "chk_cot3"
        Me.chk_cot3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot3.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot3.TabIndex = 18
        Me.chk_cot3.Text = "-"
        Me.chk_cot3.UseVisualStyleBackColor = True
        '
        'chk_cot2
        '
        Me.chk_cot2.AutoSize = True
        Me.chk_cot2.Location = New System.Drawing.Point(611, 67)
        Me.chk_cot2.Name = "chk_cot2"
        Me.chk_cot2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot2.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot2.TabIndex = 14
        Me.chk_cot2.Text = "-"
        Me.chk_cot2.UseVisualStyleBackColor = True
        '
        'chk_cot1
        '
        Me.chk_cot1.AutoSize = True
        Me.chk_cot1.Location = New System.Drawing.Point(611, 43)
        Me.chk_cot1.Name = "chk_cot1"
        Me.chk_cot1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot1.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot1.TabIndex = 10
        Me.chk_cot1.Text = "-"
        Me.chk_cot1.UseVisualStyleBackColor = True
        '
        'chkb_cop_18
        '
        Me.chkb_cop_18.AutoSize = True
        Me.chkb_cop_18.Location = New System.Drawing.Point(545, 465)
        Me.chkb_cop_18.Name = "chkb_cop_18"
        Me.chkb_cop_18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_18.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_18.TabIndex = 77
        Me.chkb_cop_18.Text = "-"
        Me.chkb_cop_18.UseVisualStyleBackColor = True
        '
        'chkb_cop_17
        '
        Me.chkb_cop_17.AutoSize = True
        Me.chkb_cop_17.Location = New System.Drawing.Point(544, 440)
        Me.chkb_cop_17.Name = "chkb_cop_17"
        Me.chkb_cop_17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_17.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_17.TabIndex = 73
        Me.chkb_cop_17.Text = "-"
        Me.chkb_cop_17.UseVisualStyleBackColor = True
        '
        'chkb_cop_16
        '
        Me.chkb_cop_16.AutoSize = True
        Me.chkb_cop_16.Location = New System.Drawing.Point(544, 415)
        Me.chkb_cop_16.Name = "chkb_cop_16"
        Me.chkb_cop_16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_16.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_16.TabIndex = 69
        Me.chkb_cop_16.Text = "-"
        Me.chkb_cop_16.UseVisualStyleBackColor = True
        '
        'chkb_cop_15
        '
        Me.chkb_cop_15.AutoSize = True
        Me.chkb_cop_15.Location = New System.Drawing.Point(544, 390)
        Me.chkb_cop_15.Name = "chkb_cop_15"
        Me.chkb_cop_15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_15.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_15.TabIndex = 65
        Me.chkb_cop_15.Text = "-"
        Me.chkb_cop_15.UseVisualStyleBackColor = True
        '
        'chkb_cop_14
        '
        Me.chkb_cop_14.AutoSize = True
        Me.chkb_cop_14.Location = New System.Drawing.Point(544, 365)
        Me.chkb_cop_14.Name = "chkb_cop_14"
        Me.chkb_cop_14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_14.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_14.TabIndex = 61
        Me.chkb_cop_14.Text = "-"
        Me.chkb_cop_14.UseVisualStyleBackColor = True
        '
        'chkb_cop_13
        '
        Me.chkb_cop_13.AutoSize = True
        Me.chkb_cop_13.Location = New System.Drawing.Point(544, 331)
        Me.chkb_cop_13.Name = "chkb_cop_13"
        Me.chkb_cop_13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_13.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_13.TabIndex = 57
        Me.chkb_cop_13.Text = "-"
        Me.chkb_cop_13.UseVisualStyleBackColor = True
        '
        'chkb_cop_12
        '
        Me.chkb_cop_12.AutoSize = True
        Me.chkb_cop_12.Location = New System.Drawing.Point(544, 307)
        Me.chkb_cop_12.Name = "chkb_cop_12"
        Me.chkb_cop_12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_12.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_12.TabIndex = 53
        Me.chkb_cop_12.Text = "-"
        Me.chkb_cop_12.UseVisualStyleBackColor = True
        '
        'chkb_cop_11
        '
        Me.chkb_cop_11.AutoSize = True
        Me.chkb_cop_11.Location = New System.Drawing.Point(545, 283)
        Me.chkb_cop_11.Name = "chkb_cop_11"
        Me.chkb_cop_11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_11.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_11.TabIndex = 49
        Me.chkb_cop_11.Text = "-"
        Me.chkb_cop_11.UseVisualStyleBackColor = True
        '
        'chkb_cop_10
        '
        Me.chkb_cop_10.AutoSize = True
        Me.chkb_cop_10.Location = New System.Drawing.Point(544, 259)
        Me.chkb_cop_10.Name = "chkb_cop_10"
        Me.chkb_cop_10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_10.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_10.TabIndex = 45
        Me.chkb_cop_10.Text = "-"
        Me.chkb_cop_10.UseVisualStyleBackColor = True
        '
        'chkb_cop_9
        '
        Me.chkb_cop_9.AutoSize = True
        Me.chkb_cop_9.Location = New System.Drawing.Point(544, 235)
        Me.chkb_cop_9.Name = "chkb_cop_9"
        Me.chkb_cop_9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_9.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_9.TabIndex = 41
        Me.chkb_cop_9.Text = "-"
        Me.chkb_cop_9.UseVisualStyleBackColor = True
        '
        'chkb_cop_8
        '
        Me.chkb_cop_8.AutoSize = True
        Me.chkb_cop_8.Location = New System.Drawing.Point(544, 211)
        Me.chkb_cop_8.Name = "chkb_cop_8"
        Me.chkb_cop_8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_8.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_8.TabIndex = 37
        Me.chkb_cop_8.Text = "-"
        Me.chkb_cop_8.UseVisualStyleBackColor = True
        '
        'chkb_cop_7
        '
        Me.chkb_cop_7.AutoSize = True
        Me.chkb_cop_7.Location = New System.Drawing.Point(544, 187)
        Me.chkb_cop_7.Name = "chkb_cop_7"
        Me.chkb_cop_7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_7.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_7.TabIndex = 33
        Me.chkb_cop_7.Text = "-"
        Me.chkb_cop_7.UseVisualStyleBackColor = True
        '
        'chkb_cop_6
        '
        Me.chkb_cop_6.AutoSize = True
        Me.chkb_cop_6.Location = New System.Drawing.Point(544, 163)
        Me.chkb_cop_6.Name = "chkb_cop_6"
        Me.chkb_cop_6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_6.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_6.TabIndex = 29
        Me.chkb_cop_6.Text = "-"
        Me.chkb_cop_6.UseVisualStyleBackColor = True
        '
        'chkb_cop_5
        '
        Me.chkb_cop_5.AutoSize = True
        Me.chkb_cop_5.Location = New System.Drawing.Point(544, 139)
        Me.chkb_cop_5.Name = "chkb_cop_5"
        Me.chkb_cop_5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_5.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_5.TabIndex = 25
        Me.chkb_cop_5.Text = "-"
        Me.chkb_cop_5.UseVisualStyleBackColor = True
        '
        'chkb_cop_4
        '
        Me.chkb_cop_4.AutoSize = True
        Me.chkb_cop_4.Location = New System.Drawing.Point(544, 115)
        Me.chkb_cop_4.Name = "chkb_cop_4"
        Me.chkb_cop_4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_4.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_4.TabIndex = 21
        Me.chkb_cop_4.Text = "-"
        Me.chkb_cop_4.UseVisualStyleBackColor = True
        '
        'chkb_cop_3
        '
        Me.chkb_cop_3.AutoSize = True
        Me.chkb_cop_3.Location = New System.Drawing.Point(544, 91)
        Me.chkb_cop_3.Name = "chkb_cop_3"
        Me.chkb_cop_3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_3.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_3.TabIndex = 17
        Me.chkb_cop_3.Text = "-"
        Me.chkb_cop_3.UseVisualStyleBackColor = True
        '
        'chkb_cop_2
        '
        Me.chkb_cop_2.AutoSize = True
        Me.chkb_cop_2.Location = New System.Drawing.Point(544, 67)
        Me.chkb_cop_2.Name = "chkb_cop_2"
        Me.chkb_cop_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_2.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_2.TabIndex = 13
        Me.chkb_cop_2.Text = "-"
        Me.chkb_cop_2.UseVisualStyleBackColor = True
        '
        'chkb_cop_1
        '
        Me.chkb_cop_1.AutoSize = True
        Me.chkb_cop_1.Location = New System.Drawing.Point(544, 43)
        Me.chkb_cop_1.Name = "chkb_cop_1"
        Me.chkb_cop_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_1.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_1.TabIndex = 9
        Me.chkb_cop_1.Text = "-"
        Me.chkb_cop_1.UseVisualStyleBackColor = True
        '
        'txtObs_18
        '
        Me.txtObs_18.Location = New System.Drawing.Point(667, 463)
        Me.txtObs_18.Multiline = True
        Me.txtObs_18.Name = "txtObs_18"
        Me.txtObs_18.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_18.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_18.TabIndex = 79
        '
        'txtObs_17
        '
        Me.txtObs_17.Location = New System.Drawing.Point(667, 438)
        Me.txtObs_17.Multiline = True
        Me.txtObs_17.Name = "txtObs_17"
        Me.txtObs_17.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_17.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_17.TabIndex = 75
        '
        'txtObs_16
        '
        Me.txtObs_16.Location = New System.Drawing.Point(667, 413)
        Me.txtObs_16.Multiline = True
        Me.txtObs_16.Name = "txtObs_16"
        Me.txtObs_16.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_16.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_16.TabIndex = 71
        '
        'txtObs_15
        '
        Me.txtObs_15.Location = New System.Drawing.Point(667, 388)
        Me.txtObs_15.Multiline = True
        Me.txtObs_15.Name = "txtObs_15"
        Me.txtObs_15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_15.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_15.TabIndex = 67
        '
        'txtObs_14
        '
        Me.txtObs_14.Location = New System.Drawing.Point(667, 363)
        Me.txtObs_14.Multiline = True
        Me.txtObs_14.Name = "txtObs_14"
        Me.txtObs_14.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_14.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_14.TabIndex = 63
        '
        'txtObs_13
        '
        Me.txtObs_13.Location = New System.Drawing.Point(667, 329)
        Me.txtObs_13.Multiline = True
        Me.txtObs_13.Name = "txtObs_13"
        Me.txtObs_13.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_13.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_13.TabIndex = 59
        '
        'txtObs_12
        '
        Me.txtObs_12.Location = New System.Drawing.Point(667, 305)
        Me.txtObs_12.Multiline = True
        Me.txtObs_12.Name = "txtObs_12"
        Me.txtObs_12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_12.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_12.TabIndex = 55
        '
        'txtObs_11
        '
        Me.txtObs_11.Location = New System.Drawing.Point(667, 281)
        Me.txtObs_11.Multiline = True
        Me.txtObs_11.Name = "txtObs_11"
        Me.txtObs_11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_11.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_11.TabIndex = 51
        '
        'txtObs_10
        '
        Me.txtObs_10.Location = New System.Drawing.Point(667, 257)
        Me.txtObs_10.Multiline = True
        Me.txtObs_10.Name = "txtObs_10"
        Me.txtObs_10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_10.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_10.TabIndex = 47
        '
        'txtObs_9
        '
        Me.txtObs_9.Location = New System.Drawing.Point(667, 233)
        Me.txtObs_9.Multiline = True
        Me.txtObs_9.Name = "txtObs_9"
        Me.txtObs_9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_9.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_9.TabIndex = 43
        '
        'txtObs_8
        '
        Me.txtObs_8.Location = New System.Drawing.Point(667, 209)
        Me.txtObs_8.Multiline = True
        Me.txtObs_8.Name = "txtObs_8"
        Me.txtObs_8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_8.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_8.TabIndex = 39
        '
        'txtObs_7
        '
        Me.txtObs_7.Location = New System.Drawing.Point(667, 185)
        Me.txtObs_7.Multiline = True
        Me.txtObs_7.Name = "txtObs_7"
        Me.txtObs_7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_7.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_7.TabIndex = 35
        '
        'txtObs_6
        '
        Me.txtObs_6.Location = New System.Drawing.Point(667, 161)
        Me.txtObs_6.Multiline = True
        Me.txtObs_6.Name = "txtObs_6"
        Me.txtObs_6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_6.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_6.TabIndex = 31
        '
        'txtObs_5
        '
        Me.txtObs_5.Location = New System.Drawing.Point(667, 137)
        Me.txtObs_5.Multiline = True
        Me.txtObs_5.Name = "txtObs_5"
        Me.txtObs_5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_5.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_5.TabIndex = 27
        '
        'txtObs_4
        '
        Me.txtObs_4.Location = New System.Drawing.Point(667, 113)
        Me.txtObs_4.Multiline = True
        Me.txtObs_4.Name = "txtObs_4"
        Me.txtObs_4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_4.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_4.TabIndex = 23
        '
        'txtObs_3
        '
        Me.txtObs_3.Location = New System.Drawing.Point(667, 89)
        Me.txtObs_3.Multiline = True
        Me.txtObs_3.Name = "txtObs_3"
        Me.txtObs_3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_3.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_3.TabIndex = 19
        '
        'txtObs_2
        '
        Me.txtObs_2.Location = New System.Drawing.Point(667, 65)
        Me.txtObs_2.Multiline = True
        Me.txtObs_2.Name = "txtObs_2"
        Me.txtObs_2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_2.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_2.TabIndex = 15
        '
        'txtObs_1
        '
        Me.txtObs_1.Location = New System.Drawing.Point(667, 41)
        Me.txtObs_1.Multiline = True
        Me.txtObs_1.Name = "txtObs_1"
        Me.txtObs_1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_1.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_1.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 467)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(226, 13)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "18 - Avaluo de garantía prendaría (si procede)"
        '
        'chkb_18
        '
        Me.chkb_18.AutoSize = True
        Me.chkb_18.Location = New System.Drawing.Point(473, 465)
        Me.chkb_18.Name = "chkb_18"
        Me.chkb_18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_18.Size = New System.Drawing.Size(29, 17)
        Me.chkb_18.TabIndex = 76
        Me.chkb_18.Text = "-"
        Me.chkb_18.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 442)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(232, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "17 - Avaluo de garantía hipotecaria (si procede)"
        '
        'chkb_17
        '
        Me.chkb_17.AutoSize = True
        Me.chkb_17.Location = New System.Drawing.Point(472, 440)
        Me.chkb_17.Name = "chkb_17"
        Me.chkb_17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_17.Size = New System.Drawing.Size(29, 17)
        Me.chkb_17.TabIndex = 72
        Me.chkb_17.Text = "-"
        Me.chkb_17.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 417)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(178, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "16 - Hoja de terminos y condiciones."
        '
        'chkb_16
        '
        Me.chkb_16.AutoSize = True
        Me.chkb_16.Location = New System.Drawing.Point(472, 415)
        Me.chkb_16.Name = "chkb_16"
        Me.chkb_16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_16.Size = New System.Drawing.Size(29, 17)
        Me.chkb_16.TabIndex = 68
        Me.chkb_16.Text = "-"
        Me.chkb_16.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 392)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(147, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "15 - CVT o Dictamen técnico."
        '
        'chkb_15
        '
        Me.chkb_15.AutoSize = True
        Me.chkb_15.Location = New System.Drawing.Point(472, 390)
        Me.chkb_15.Name = "chkb_15"
        Me.chkb_15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_15.Size = New System.Drawing.Size(29, 17)
        Me.chkb_15.TabIndex = 64
        Me.chkb_15.Text = "-"
        Me.chkb_15.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 367)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(332, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "14 - Relación Patrimonial Firmada (Acreditado(a), Rep. Legales, O.S.)"
        '
        'chkb_14
        '
        Me.chkb_14.AutoSize = True
        Me.chkb_14.Location = New System.Drawing.Point(472, 365)
        Me.chkb_14.Name = "chkb_14"
        Me.chkb_14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_14.Size = New System.Drawing.Size(29, 17)
        Me.chkb_14.TabIndex = 60
        Me.chkb_14.Text = "-"
        Me.chkb_14.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(437, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "13 - Estados Financieros de los dos últimos ejercicios completos y un parcial con" &
    " analíticas,"
        '
        'chkb_13
        '
        Me.chkb_13.AutoSize = True
        Me.chkb_13.Location = New System.Drawing.Point(472, 331)
        Me.chkb_13.Name = "chkb_13"
        Me.chkb_13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_13.Size = New System.Drawing.Size(29, 17)
        Me.chkb_13.TabIndex = 56
        Me.chkb_13.Text = "-"
        Me.chkb_13.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 309)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(302, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "12 - Poderes de quienes sucriben los contratos y pagarés (PM)"
        '
        'chkb_12
        '
        Me.chkb_12.AutoSize = True
        Me.chkb_12.Location = New System.Drawing.Point(472, 307)
        Me.chkb_12.Name = "chkb_12"
        Me.chkb_12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_12.Size = New System.Drawing.Size(29, 17)
        Me.chkb_12.TabIndex = 52
        Me.chkb_12.Text = "-"
        Me.chkb_12.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(305, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "11 - Acta Constitutiva y Modificaciones con datos en RPP (PM)"
        '
        'chkb_11
        '
        Me.chkb_11.AutoSize = True
        Me.chkb_11.Location = New System.Drawing.Point(473, 283)
        Me.chkb_11.Name = "chkb_11"
        Me.chkb_11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_11.Size = New System.Drawing.Size(29, 17)
        Me.chkb_11.TabIndex = 48
        Me.chkb_11.Text = "-"
        Me.chkb_11.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(256, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "10 - Carta de no contar con documentos (si procede)"
        '
        'chkb_10
        '
        Me.chkb_10.AutoSize = True
        Me.chkb_10.Location = New System.Drawing.Point(472, 259)
        Me.chkb_10.Name = "chkb_10"
        Me.chkb_10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_10.Size = New System.Drawing.Size(29, 17)
        Me.chkb_10.TabIndex = 44
        Me.chkb_10.Text = "-"
        Me.chkb_10.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(335, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "9  - Acta de matrimonio si procede (Acreditado(a), Rep. Legales, O.S.)"
        '
        'chkb_9
        '
        Me.chkb_9.AutoSize = True
        Me.chkb_9.Location = New System.Drawing.Point(472, 235)
        Me.chkb_9.Name = "chkb_9"
        Me.chkb_9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_9.Size = New System.Drawing.Size(29, 17)
        Me.chkb_9.TabIndex = 40
        Me.chkb_9.Text = "-"
        Me.chkb_9.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(286, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "8  - Acta de Nacimiento (Acreditado(a), Rep. Legales, O.S.)"
        '
        'chkb_8
        '
        Me.chkb_8.AutoSize = True
        Me.chkb_8.Location = New System.Drawing.Point(472, 211)
        Me.chkb_8.Name = "chkb_8"
        Me.chkb_8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_8.Size = New System.Drawing.Size(29, 17)
        Me.chkb_8.TabIndex = 36
        Me.chkb_8.Text = "-"
        Me.chkb_8.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "7  - CURP (Acreditado(a), Rep. Legales, O.S.)"
        '
        'chkb_7
        '
        Me.chkb_7.AutoSize = True
        Me.chkb_7.Location = New System.Drawing.Point(472, 187)
        Me.chkb_7.Name = "chkb_7"
        Me.chkb_7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_7.Size = New System.Drawing.Size(29, 17)
        Me.chkb_7.TabIndex = 32
        Me.chkb_7.Text = "-"
        Me.chkb_7.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(288, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "6  - Identificación Oficial (Acreditado(a), Rep. Legales, O.S.)"
        '
        'chkb_6
        '
        Me.chkb_6.AutoSize = True
        Me.chkb_6.Location = New System.Drawing.Point(472, 163)
        Me.chkb_6.Name = "chkb_6"
        Me.chkb_6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_6.Size = New System.Drawing.Size(29, 17)
        Me.chkb_6.TabIndex = 28
        Me.chkb_6.Text = "-"
        Me.chkb_6.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(316, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "5  - Comprobante de Domicilio (Acreditado(a), Rep. Legales, O.S.)"
        '
        'chkb_5
        '
        Me.chkb_5.AutoSize = True
        Me.chkb_5.Location = New System.Drawing.Point(472, 139)
        Me.chkb_5.Name = "chkb_5"
        Me.chkb_5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_5.Size = New System.Drawing.Size(29, 17)
        Me.chkb_5.TabIndex = 24
        Me.chkb_5.Text = "-"
        Me.chkb_5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "4  - Constancia de la e-firma (Acreditado(a), Rep. Legales, O.S.)"
        '
        'chkb_4
        '
        Me.chkb_4.AutoSize = True
        Me.chkb_4.Location = New System.Drawing.Point(472, 115)
        Me.chkb_4.Name = "chkb_4"
        Me.chkb_4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_4.Size = New System.Drawing.Size(29, 17)
        Me.chkb_4.TabIndex = 20
        Me.chkb_4.Text = "-"
        Me.chkb_4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "3  - Cédula de Identificación Fiscal (Acreditado(a), Rep. Legales, O.S.)"
        '
        'chkb_3
        '
        Me.chkb_3.AutoSize = True
        Me.chkb_3.Location = New System.Drawing.Point(472, 91)
        Me.chkb_3.Name = "chkb_3"
        Me.chkb_3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_3.Size = New System.Drawing.Size(29, 17)
        Me.chkb_3.TabIndex = 16
        Me.chkb_3.Text = "-"
        Me.chkb_3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "2  - Solicitud de Financiamiento (Debidamente requisitada y firmada en todas las " &
    "hojas)"
        '
        'chkb_2
        '
        Me.chkb_2.AutoSize = True
        Me.chkb_2.Location = New System.Drawing.Point(472, 67)
        Me.chkb_2.Name = "chkb_2"
        Me.chkb_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_2.Size = New System.Drawing.Size(29, 17)
        Me.chkb_2.TabIndex = 12
        Me.chkb_2.Text = "-"
        Me.chkb_2.UseVisualStyleBackColor = True
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.lb_1.Location = New System.Drawing.Point(9, 45)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(404, 13)
        Me.lb_1.TabIndex = 1
        Me.lb_1.Text = "1  - Autorización de Consulta de Buró de Crédito (Acreditado(a), Rep. Legales, O." &
    " S.)"
        '
        'chkb_1
        '
        Me.chkb_1.AutoSize = True
        Me.chkb_1.Location = New System.Drawing.Point(472, 43)
        Me.chkb_1.Name = "chkb_1"
        Me.chkb_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_1.Size = New System.Drawing.Size(29, 17)
        Me.chkb_1.TabIndex = 8
        Me.chkb_1.Text = "-"
        Me.chkb_1.UseVisualStyleBackColor = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(15, 651)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(550, 27)
        Me.txtObservaciones.TabIndex = 84
        '
        'lbObservaciones
        '
        Me.lbObservaciones.AutoSize = True
        Me.lbObservaciones.Location = New System.Drawing.Point(15, 633)
        Me.lbObservaciones.Name = "lbObservaciones"
        Me.lbObservaciones.Size = New System.Drawing.Size(81, 13)
        Me.lbObservaciones.TabIndex = 11
        Me.lbObservaciones.Text = "Observaciones:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(588, 651)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 85
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(692, 651)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 86
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'CRED_RelDocumentosBindingSource
        '
        Me.CRED_RelDocumentosBindingSource.DataMember = "CRED_RelDocumentos"
        Me.CRED_RelDocumentosBindingSource.DataSource = Me.CreditoDS
        '
        'CRED_RelDocumentosTableAdapter
        '
        Me.CRED_RelDocumentosTableAdapter.ClearBeforeFill = True
        '
        'cmbProducto
        '
        Me.cmbProducto.DataSource = Me.GENProductosFinagilBindingSource
        Me.cmbProducto.DisplayMember = "Producto"
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(644, 37)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(382, 21)
        Me.cmbProducto.TabIndex = 5
        Me.cmbProducto.ValueMember = "Producto"
        '
        'GENProductosFinagilBindingSource
        '
        Me.GENProductosFinagilBindingSource.DataMember = "GEN_ProductosFinagil"
        Me.GENProductosFinagilBindingSource.DataSource = Me.CreditoDSBindingSource
        '
        'GEN_ProductosFinagilTableAdapter
        '
        Me.GEN_ProductosFinagilTableAdapter.ClearBeforeFill = True
        '
        'lbProducto
        '
        Me.lbProducto.AutoSize = True
        Me.lbProducto.Location = New System.Drawing.Point(586, 40)
        Me.lbProducto.Name = "lbProducto"
        Me.lbProducto.Size = New System.Drawing.Size(53, 13)
        Me.lbProducto.TabIndex = 65
        Me.lbProducto.Text = "Producto:"
        '
        'lbAnalista
        '
        Me.lbAnalista.AutoSize = True
        Me.lbAnalista.Location = New System.Drawing.Point(591, 67)
        Me.lbAnalista.Name = "lbAnalista"
        Me.lbAnalista.Size = New System.Drawing.Size(47, 13)
        Me.lbAnalista.TabIndex = 66
        Me.lbAnalista.Text = "Analista:"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(599, 94)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(40, 13)
        Me.lbFecha.TabIndex = 67
        Me.lbFecha.Text = "Fecha:"
        '
        'ClienteTextBox
        '
        Me.ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Cliente", True))
        Me.ClienteTextBox.Enabled = False
        Me.ClienteTextBox.Location = New System.Drawing.Point(644, 10)
        Me.ClienteTextBox.Name = "ClienteTextBox"
        Me.ClienteTextBox.Size = New System.Drawing.Size(91, 20)
        Me.ClienteTextBox.TabIndex = 68
        '
        'lbCliente
        '
        Me.lbCliente.AutoSize = True
        Me.lbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCliente.Location = New System.Drawing.Point(14, 12)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.Size = New System.Drawing.Size(35, 13)
        Me.lbCliente.TabIndex = 69
        Me.lbCliente.Text = "Filtro"
        '
        'gbFiltroCliente
        '
        Me.gbFiltroCliente.Controls.Add(Me.BtnBuscar)
        Me.gbFiltroCliente.Controls.Add(Me.lbFiltroClientesCb)
        Me.gbFiltroCliente.Controls.Add(Me.txtFiltroCliente)
        Me.gbFiltroCliente.Controls.Add(Me.lbCliente)
        Me.gbFiltroCliente.Controls.Add(Me.cmbClientes)
        Me.gbFiltroCliente.Location = New System.Drawing.Point(13, 2)
        Me.gbFiltroCliente.Name = "gbFiltroCliente"
        Me.gbFiltroCliente.Size = New System.Drawing.Size(566, 109)
        Me.gbFiltroCliente.TabIndex = 83
        Me.gbFiltroCliente.TabStop = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(477, 26)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'lbFiltroClientesCb
        '
        Me.lbFiltroClientesCb.AutoSize = True
        Me.lbFiltroClientesCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFiltroClientesCb.Location = New System.Drawing.Point(16, 51)
        Me.lbFiltroClientesCb.Name = "lbFiltroClientesCb"
        Me.lbFiltroClientesCb.Size = New System.Drawing.Size(249, 13)
        Me.lbFiltroClientesCb.TabIndex = 70
        Me.lbFiltroClientesCb.Text = "Selecciona un Cliente de la siguiente Lista"
        '
        'btnReimprimir
        '
        Me.btnReimprimir.Location = New System.Drawing.Point(797, 651)
        Me.btnReimprimir.Name = "btnReimprimir"
        Me.btnReimprimir.Size = New System.Drawing.Size(94, 23)
        Me.btnReimprimir.TabIndex = 87
        Me.btnReimprimir.Text = "Re-Impresión "
        Me.btnReimprimir.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(10, 493)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(195, 13)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "19 - Manifiesto de garantias (si procede)"
        '
        'lbObservacionesDet
        '
        Me.lbObservacionesDet.AutoSize = True
        Me.lbObservacionesDet.Location = New System.Drawing.Point(779, 12)
        Me.lbObservacionesDet.Name = "lbObservacionesDet"
        Me.lbObservacionesDet.Size = New System.Drawing.Size(78, 13)
        Me.lbObservacionesDet.TabIndex = 85
        Me.lbObservacionesDet.Text = "Observaciones"
        '
        'chk_cot19
        '
        Me.chk_cot19.AutoSize = True
        Me.chk_cot19.Location = New System.Drawing.Point(612, 490)
        Me.chk_cot19.Name = "chk_cot19"
        Me.chk_cot19.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_cot19.Size = New System.Drawing.Size(29, 17)
        Me.chk_cot19.TabIndex = 82
        Me.chk_cot19.Text = "-"
        Me.chk_cot19.UseVisualStyleBackColor = True
        '
        'chkb_cop_19
        '
        Me.chkb_cop_19.AutoSize = True
        Me.chkb_cop_19.Location = New System.Drawing.Point(545, 490)
        Me.chkb_cop_19.Name = "chkb_cop_19"
        Me.chkb_cop_19.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_cop_19.Size = New System.Drawing.Size(29, 17)
        Me.chkb_cop_19.TabIndex = 81
        Me.chkb_cop_19.Text = "-"
        Me.chkb_cop_19.UseVisualStyleBackColor = True
        '
        'txtObs_19
        '
        Me.txtObs_19.Location = New System.Drawing.Point(667, 488)
        Me.txtObs_19.Multiline = True
        Me.txtObs_19.Name = "txtObs_19"
        Me.txtObs_19.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs_19.Size = New System.Drawing.Size(338, 20)
        Me.txtObs_19.TabIndex = 83
        '
        'chkb_19
        '
        Me.chkb_19.AutoSize = True
        Me.chkb_19.Location = New System.Drawing.Point(473, 490)
        Me.chkb_19.Name = "chkb_19"
        Me.chkb_19.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkb_19.Size = New System.Drawing.Size(29, 17)
        Me.chkb_19.TabIndex = 80
        Me.chkb_19.Text = "-"
        Me.chkb_19.UseVisualStyleBackColor = True
        '
        'frmRelDocOrig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 687)
        Me.Controls.Add(Me.btnReimprimir)
        Me.Controls.Add(Me.gbFiltroCliente)
        Me.Controls.Add(ClienteLabel)
        Me.Controls.Add(Me.ClienteTextBox)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.lbAnalista)
        Me.Controls.Add(Me.lbProducto)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lbObservaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.gbxDocumentos)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtSucursalName)
        Me.Controls.Add(Me.cmbAnalista)
        Me.Controls.Add(SucursalLabel)
        Me.Controls.Add(Me.SucursalTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Name = "frmRelDocOrig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relación de documentos originales"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosFinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDocumentos.ResumeLayout(False)
        Me.gbxDocumentos.PerformLayout()
        CType(Me.CRED_RelDocumentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GENProductosFinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltroCliente.ResumeLayout(False)
        Me.gbFiltroCliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CreditoDSBindingSource As BindingSource
    Friend WithEvents CreditoDS As CreditoDS
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As CreditoDSTableAdapters.ClientesTableAdapter
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents TableAdapterManager As CreditoDSTableAdapters.TableAdapterManager
    Friend WithEvents txtFiltroCliente As TextBox
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents SucursalTextBox As TextBox
    Friend WithEvents cmbAnalista As ComboBox
    Friend WithEvents SeguridadDS As SeguridadDS
    Friend WithEvents UsuariosFinagilBindingSource As BindingSource
    Friend WithEvents UsuariosFinagilTableAdapter As SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
    Friend WithEvents txtSucursalName As TextBox
    Friend WithEvents SucursalesBindingSource As BindingSource
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents gbxDocumentos As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents chkb_18 As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents chkb_17 As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents chkb_16 As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents chkb_15 As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents chkb_14 As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents chkb_13 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents chkb_12 As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents chkb_11 As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents chkb_10 As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents chkb_9 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkb_8 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkb_7 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkb_6 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkb_5 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkb_4 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkb_3 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkb_2 As CheckBox
    Friend WithEvents lb_1 As Label
    Friend WithEvents chkb_1 As CheckBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents lbObservaciones As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents CRED_RelDocumentosBindingSource As BindingSource
    Friend WithEvents CRED_RelDocumentosTableAdapter As CreditoDSTableAdapters.CRED_RelDocumentosTableAdapter
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents GENProductosFinagilBindingSource As BindingSource
    Friend WithEvents GEN_ProductosFinagilTableAdapter As CreditoDSTableAdapters.GEN_ProductosFinagilTableAdapter
    Friend WithEvents txtObs_18 As TextBox
    Friend WithEvents txtObs_17 As TextBox
    Friend WithEvents txtObs_16 As TextBox
    Friend WithEvents txtObs_15 As TextBox
    Friend WithEvents txtObs_14 As TextBox
    Friend WithEvents txtObs_13 As TextBox
    Friend WithEvents txtObs_12 As TextBox
    Friend WithEvents txtObs_11 As TextBox
    Friend WithEvents txtObs_10 As TextBox
    Friend WithEvents txtObs_9 As TextBox
    Friend WithEvents txtObs_8 As TextBox
    Friend WithEvents txtObs_7 As TextBox
    Friend WithEvents txtObs_6 As TextBox
    Friend WithEvents txtObs_5 As TextBox
    Friend WithEvents txtObs_4 As TextBox
    Friend WithEvents txtObs_3 As TextBox
    Friend WithEvents txtObs_2 As TextBox
    Friend WithEvents txtObs_1 As TextBox
    Friend WithEvents chkb_cop_18 As CheckBox
    Friend WithEvents chkb_cop_17 As CheckBox
    Friend WithEvents chkb_cop_16 As CheckBox
    Friend WithEvents chkb_cop_15 As CheckBox
    Friend WithEvents chkb_cop_14 As CheckBox
    Friend WithEvents chkb_cop_13 As CheckBox
    Friend WithEvents chkb_cop_12 As CheckBox
    Friend WithEvents chkb_cop_11 As CheckBox
    Friend WithEvents chkb_cop_10 As CheckBox
    Friend WithEvents chkb_cop_9 As CheckBox
    Friend WithEvents chkb_cop_8 As CheckBox
    Friend WithEvents chkb_cop_7 As CheckBox
    Friend WithEvents chkb_cop_6 As CheckBox
    Friend WithEvents chkb_cop_5 As CheckBox
    Friend WithEvents chkb_cop_4 As CheckBox
    Friend WithEvents chkb_cop_3 As CheckBox
    Friend WithEvents chkb_cop_2 As CheckBox
    Friend WithEvents chkb_cop_1 As CheckBox
    Friend WithEvents lbProducto As Label
    Friend WithEvents lbAnalista As Label
    Friend WithEvents lbFecha As Label
    Friend WithEvents ClienteTextBox As TextBox
    Friend WithEvents lbCliente As Label
    Friend WithEvents chk_cot18 As CheckBox
    Friend WithEvents chk_cot17 As CheckBox
    Friend WithEvents chk_cot16 As CheckBox
    Friend WithEvents chk_cot15 As CheckBox
    Friend WithEvents chk_cot14 As CheckBox
    Friend WithEvents chk_cot13 As CheckBox
    Friend WithEvents chk_cot12 As CheckBox
    Friend WithEvents chk_cot11 As CheckBox
    Friend WithEvents chk_cot10 As CheckBox
    Friend WithEvents chk_cot9 As CheckBox
    Friend WithEvents chk_cot8 As CheckBox
    Friend WithEvents chk_cot7 As CheckBox
    Friend WithEvents chk_cot6 As CheckBox
    Friend WithEvents chk_cot5 As CheckBox
    Friend WithEvents chk_cot4 As CheckBox
    Friend WithEvents chk_cot3 As CheckBox
    Friend WithEvents chk_cot2 As CheckBox
    Friend WithEvents chk_cot1 As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents gbFiltroCliente As GroupBox
    Friend WithEvents lbFiltroClientesCb As Label
    Friend WithEvents lbSellCotejo As Label
    Friend WithEvents lbCopOrig As Label
    Friend WithEvents lbOrig As Label
    Friend WithEvents btnReimprimir As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents chk_cot19 As CheckBox
    Friend WithEvents chkb_cop_19 As CheckBox
    Friend WithEvents txtObs_19 As TextBox
    Friend WithEvents chkb_19 As CheckBox
    Friend WithEvents lbObservacionesDet As Label
    Friend WithEvents Label19 As Label
End Class
