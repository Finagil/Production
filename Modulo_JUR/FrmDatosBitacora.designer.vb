<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatosBitacora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DatosConsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JuridicoDS = New Agil.JuridicoDS
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.bSalir = New System.Windows.Forms.Button
        Me.InfBitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosBitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosBitacoraTableAdapter = New Agil.JuridicoDSTableAdapters.DatosBitacoraTableAdapter
        Me.InfBitacoraTableAdapter = New Agil.JuridicoDSTableAdapters.InfBitacoraTableAdapter
        Me.DatosConsultaTableAdapter = New Agil.JuridicoDSTableAdapters.DatosConsultaTableAdapter
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbReporte = New System.Windows.Forms.ComboBox
        Me.CmbSucursal = New System.Windows.Forms.ComboBox
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.SucursalesTableAdapter = New Agil.JuridicoDSTableAdapters.SucursalesTableAdapter
        Me.Tipar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaAut = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCicloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescCiclo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Prenda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GHipotec = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fechacon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaTer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FIngNotariaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FFProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FFNotariaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FIRPPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FPNotaraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FENotariaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FEGVsinRUGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FInscripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FEGVSucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FLimiteGV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumReciboDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FEGVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FEFisicaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotasMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Liberado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosConsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfBitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosBitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipar, Me.AnexoDataGridViewTextBoxColumn, Me.FechaAut, Me.IdCicloDataGridViewTextBoxColumn, Me.DescCiclo, Me.Descr, Me.Prenda, Me.GHipotec, Me.Fechacon, Me.FechaTer, Me.FIngNotariaDataGridViewTextBoxColumn, Me.FFProdDataGridViewTextBoxColumn, Me.HoraDataGridViewTextBoxColumn, Me.NotarioDataGridViewTextBoxColumn, Me.FFNotariaDataGridViewTextBoxColumn, Me.FIRPPDataGridViewTextBoxColumn, Me.FPNotaraDataGridViewTextBoxColumn, Me.FENotariaDataGridViewTextBoxColumn, Me.FEGVsinRUGDataGridViewTextBoxColumn, Me.FInscripcionDataGridViewTextBoxColumn, Me.FEGVSucursalDataGridViewTextBoxColumn, Me.FLimiteGV, Me.Observaciones, Me.CostoDataGridViewTextBoxColumn, Me.NumReciboDataGridViewTextBoxColumn, Me.FPagoDataGridViewTextBoxColumn, Me.FEGVDataGridViewTextBoxColumn, Me.FEFisicaDataGridViewTextBoxColumn, Me.Nombre_Sucursal, Me.NotasMC, Me.Liberado, Me.DataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.DatosConsultaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1180, 573)
        Me.DataGridView1.TabIndex = 0
        '
        'DatosConsultaBindingSource
        '
        Me.DatosConsultaBindingSource.DataMember = "DatosConsulta"
        Me.DatosConsultaBindingSource.DataSource = Me.JuridicoDS
        '
        'JuridicoDS
        '
        Me.JuridicoDS.DataSetName = "MC_BitacoraDSX"
        Me.JuridicoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "(H) Habilitación o Avio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "(CC) Cuenta Corriente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(156, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "(F) Financiero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "(R) Refacccionario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(283, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "(S) Simple"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(283, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "(P) Puro"
        '
        'bSalir
        '
        Me.bSalir.Location = New System.Drawing.Point(1112, 34)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(75, 23)
        Me.bSalir.TabIndex = 7
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'InfBitacoraBindingSource
        '
        Me.InfBitacoraBindingSource.DataMember = "InfBitacora"
        Me.InfBitacoraBindingSource.DataSource = Me.JuridicoDS
        '
        'DatosBitacoraBindingSource
        '
        Me.DatosBitacoraBindingSource.DataMember = "DatosBitacora"
        Me.DatosBitacoraBindingSource.DataSource = Me.JuridicoDS
        '
        'DatosBitacoraTableAdapter
        '
        Me.DatosBitacoraTableAdapter.ClearBeforeFill = True
        '
        'InfBitacoraTableAdapter
        '
        Me.InfBitacoraTableAdapter.ClearBeforeFill = True
        '
        'DatosConsultaTableAdapter
        '
        Me.DatosConsultaTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(363, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "(B) Full Service"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(784, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Elige Tipo de Reporte"
        '
        'CmbReporte
        '
        Me.CmbReporte.FormattingEnabled = True
        Me.CmbReporte.Items.AddRange(New Object() {"GLOBAL", "CREDITOS TRAD.", "CREDITOS AVIO", "POR SUCURSAL"})
        Me.CmbReporte.Location = New System.Drawing.Point(785, 32)
        Me.CmbReporte.Name = "CmbReporte"
        Me.CmbReporte.Size = New System.Drawing.Size(121, 21)
        Me.CmbReporte.TabIndex = 12
        '
        'CmbSucursal
        '
        Me.CmbSucursal.DataSource = Me.SucursalesBindingSource
        Me.CmbSucursal.DisplayMember = "Nombre_Sucursal"
        Me.CmbSucursal.FormattingEnabled = True
        Me.CmbSucursal.Location = New System.Drawing.Point(943, 32)
        Me.CmbSucursal.Name = "CmbSucursal"
        Me.CmbSucursal.Size = New System.Drawing.Size(101, 21)
        Me.CmbSucursal.TabIndex = 13
        Me.CmbSucursal.ValueMember = "Nombre_Sucursal"
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.JuridicoDS
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(940, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Elige Sucursal"
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
        '
        'Tipar
        '
        Me.Tipar.DataPropertyName = "Tipar"
        Me.Tipar.HeaderText = "T."
        Me.Tipar.Name = "Tipar"
        Me.Tipar.ReadOnly = True
        Me.Tipar.Width = 35
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Contrato"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Width = 80
        '
        'FechaAut
        '
        Me.FechaAut.DataPropertyName = "FechaAut"
        Me.FechaAut.HeaderText = "Fecha Aut"
        Me.FechaAut.Name = "FechaAut"
        Me.FechaAut.ReadOnly = True
        Me.FechaAut.Width = 80
        '
        'IdCicloDataGridViewTextBoxColumn
        '
        Me.IdCicloDataGridViewTextBoxColumn.DataPropertyName = "Id_Ciclo"
        Me.IdCicloDataGridViewTextBoxColumn.HeaderText = "Ciclo"
        Me.IdCicloDataGridViewTextBoxColumn.Name = "IdCicloDataGridViewTextBoxColumn"
        Me.IdCicloDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCicloDataGridViewTextBoxColumn.Width = 35
        '
        'DescCiclo
        '
        Me.DescCiclo.DataPropertyName = "DescCiclo"
        Me.DescCiclo.HeaderText = "DescCiclo"
        Me.DescCiclo.Name = "DescCiclo"
        Me.DescCiclo.ReadOnly = True
        '
        'Descr
        '
        Me.Descr.DataPropertyName = "Descr"
        Me.Descr.HeaderText = "Nombre Cte."
        Me.Descr.Name = "Descr"
        Me.Descr.ReadOnly = True
        Me.Descr.Width = 220
        '
        'Prenda
        '
        Me.Prenda.DataPropertyName = "Prenda"
        Me.Prenda.HeaderText = "G.P."
        Me.Prenda.Name = "Prenda"
        Me.Prenda.ReadOnly = True
        Me.Prenda.Width = 35
        '
        'GHipotec
        '
        Me.GHipotec.DataPropertyName = "GHipotec"
        Me.GHipotec.HeaderText = "G.H."
        Me.GHipotec.Name = "GHipotec"
        Me.GHipotec.ReadOnly = True
        Me.GHipotec.Width = 35
        '
        'Fechacon
        '
        Me.Fechacon.DataPropertyName = "Fechacon"
        Me.Fechacon.HeaderText = "F.Ini.Cto."
        Me.Fechacon.Name = "Fechacon"
        Me.Fechacon.ReadOnly = True
        Me.Fechacon.Width = 80
        '
        'FechaTer
        '
        Me.FechaTer.DataPropertyName = "FechaTer"
        Me.FechaTer.HeaderText = "F.Ter.Cto."
        Me.FechaTer.Name = "FechaTer"
        Me.FechaTer.ReadOnly = True
        Me.FechaTer.Width = 80
        '
        'FIngNotariaDataGridViewTextBoxColumn
        '
        Me.FIngNotariaDataGridViewTextBoxColumn.DataPropertyName = "FIngNotaria"
        Me.FIngNotariaDataGridViewTextBoxColumn.HeaderText = "F.Ing.Not."
        Me.FIngNotariaDataGridViewTextBoxColumn.Name = "FIngNotariaDataGridViewTextBoxColumn"
        Me.FIngNotariaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FIngNotariaDataGridViewTextBoxColumn.Width = 80
        '
        'FFProdDataGridViewTextBoxColumn
        '
        Me.FFProdDataGridViewTextBoxColumn.DataPropertyName = "FFProd"
        Me.FFProdDataGridViewTextBoxColumn.HeaderText = "FirmaPro."
        Me.FFProdDataGridViewTextBoxColumn.Name = "FFProdDataGridViewTextBoxColumn"
        Me.FFProdDataGridViewTextBoxColumn.ReadOnly = True
        Me.FFProdDataGridViewTextBoxColumn.Width = 80
        '
        'HoraDataGridViewTextBoxColumn
        '
        Me.HoraDataGridViewTextBoxColumn.DataPropertyName = "Hora"
        Me.HoraDataGridViewTextBoxColumn.HeaderText = "Hora"
        Me.HoraDataGridViewTextBoxColumn.Name = "HoraDataGridViewTextBoxColumn"
        Me.HoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoraDataGridViewTextBoxColumn.Width = 75
        '
        'NotarioDataGridViewTextBoxColumn
        '
        Me.NotarioDataGridViewTextBoxColumn.DataPropertyName = "Notario"
        Me.NotarioDataGridViewTextBoxColumn.HeaderText = "Notario"
        Me.NotarioDataGridViewTextBoxColumn.Name = "NotarioDataGridViewTextBoxColumn"
        Me.NotarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.NotarioDataGridViewTextBoxColumn.Width = 130
        '
        'FFNotariaDataGridViewTextBoxColumn
        '
        Me.FFNotariaDataGridViewTextBoxColumn.DataPropertyName = "FFNotaria"
        Me.FFNotariaDataGridViewTextBoxColumn.HeaderText = "FirmaNot."
        Me.FFNotariaDataGridViewTextBoxColumn.Name = "FFNotariaDataGridViewTextBoxColumn"
        Me.FFNotariaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FFNotariaDataGridViewTextBoxColumn.Width = 80
        '
        'FIRPPDataGridViewTextBoxColumn
        '
        Me.FIRPPDataGridViewTextBoxColumn.DataPropertyName = "FIRPP"
        Me.FIRPPDataGridViewTextBoxColumn.HeaderText = "Ing.RPP"
        Me.FIRPPDataGridViewTextBoxColumn.Name = "FIRPPDataGridViewTextBoxColumn"
        Me.FIRPPDataGridViewTextBoxColumn.ReadOnly = True
        Me.FIRPPDataGridViewTextBoxColumn.Width = 80
        '
        'FPNotaraDataGridViewTextBoxColumn
        '
        Me.FPNotaraDataGridViewTextBoxColumn.DataPropertyName = "FPNotara"
        Me.FPNotaraDataGridViewTextBoxColumn.HeaderText = "F.Pro.Not."
        Me.FPNotaraDataGridViewTextBoxColumn.Name = "FPNotaraDataGridViewTextBoxColumn"
        Me.FPNotaraDataGridViewTextBoxColumn.ReadOnly = True
        Me.FPNotaraDataGridViewTextBoxColumn.Width = 80
        '
        'FENotariaDataGridViewTextBoxColumn
        '
        Me.FENotariaDataGridViewTextBoxColumn.DataPropertyName = "FENotaria"
        Me.FENotariaDataGridViewTextBoxColumn.HeaderText = "F.Ent.Not."
        Me.FENotariaDataGridViewTextBoxColumn.Name = "FENotariaDataGridViewTextBoxColumn"
        Me.FENotariaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FENotariaDataGridViewTextBoxColumn.Width = 80
        '
        'FEGVsinRUGDataGridViewTextBoxColumn
        '
        Me.FEGVsinRUGDataGridViewTextBoxColumn.DataPropertyName = "FEGVsinRUG"
        Me.FEGVsinRUGDataGridViewTextBoxColumn.HeaderText = "Ent.GVs/RUG"
        Me.FEGVsinRUGDataGridViewTextBoxColumn.Name = "FEGVsinRUGDataGridViewTextBoxColumn"
        Me.FEGVsinRUGDataGridViewTextBoxColumn.ReadOnly = True
        Me.FEGVsinRUGDataGridViewTextBoxColumn.Width = 80
        '
        'FInscripcionDataGridViewTextBoxColumn
        '
        Me.FInscripcionDataGridViewTextBoxColumn.DataPropertyName = "FInscripcion"
        Me.FInscripcionDataGridViewTextBoxColumn.HeaderText = "F.Insc.RUG"
        Me.FInscripcionDataGridViewTextBoxColumn.Name = "FInscripcionDataGridViewTextBoxColumn"
        Me.FInscripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FInscripcionDataGridViewTextBoxColumn.Width = 80
        '
        'FEGVSucursalDataGridViewTextBoxColumn
        '
        Me.FEGVSucursalDataGridViewTextBoxColumn.DataPropertyName = "FEGVSucursal"
        Me.FEGVSucursalDataGridViewTextBoxColumn.HeaderText = "Ent.GVSuc."
        Me.FEGVSucursalDataGridViewTextBoxColumn.Name = "FEGVSucursalDataGridViewTextBoxColumn"
        Me.FEGVSucursalDataGridViewTextBoxColumn.ReadOnly = True
        Me.FEGVSucursalDataGridViewTextBoxColumn.Width = 80
        '
        'FLimiteGV
        '
        Me.FLimiteGV.DataPropertyName = "FLimiteGV"
        Me.FLimiteGV.HeaderText = "Fecha Limite"
        Me.FLimiteGV.Name = "FLimiteGV"
        Me.FLimiteGV.ReadOnly = True
        '
        'Observaciones
        '
        Me.Observaciones.DataPropertyName = "Observaciones"
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumReciboDataGridViewTextBoxColumn
        '
        Me.NumReciboDataGridViewTextBoxColumn.DataPropertyName = "NumRecibo"
        Me.NumReciboDataGridViewTextBoxColumn.HeaderText = "Num.Rec."
        Me.NumReciboDataGridViewTextBoxColumn.Name = "NumReciboDataGridViewTextBoxColumn"
        Me.NumReciboDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumReciboDataGridViewTextBoxColumn.Width = 80
        '
        'FPagoDataGridViewTextBoxColumn
        '
        Me.FPagoDataGridViewTextBoxColumn.DataPropertyName = "FPago"
        Me.FPagoDataGridViewTextBoxColumn.HeaderText = "F.Pago"
        Me.FPagoDataGridViewTextBoxColumn.Name = "FPagoDataGridViewTextBoxColumn"
        Me.FPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FPagoDataGridViewTextBoxColumn.Width = 80
        '
        'FEGVDataGridViewTextBoxColumn
        '
        Me.FEGVDataGridViewTextBoxColumn.DataPropertyName = "FEGV"
        Me.FEGVDataGridViewTextBoxColumn.HeaderText = "F.Ent.GV"
        Me.FEGVDataGridViewTextBoxColumn.Name = "FEGVDataGridViewTextBoxColumn"
        Me.FEGVDataGridViewTextBoxColumn.ReadOnly = True
        Me.FEGVDataGridViewTextBoxColumn.Width = 80
        '
        'FEFisicaDataGridViewTextBoxColumn
        '
        Me.FEFisicaDataGridViewTextBoxColumn.DataPropertyName = "FEFisica"
        Me.FEFisicaDataGridViewTextBoxColumn.HeaderText = "Ent.Fisica"
        Me.FEFisicaDataGridViewTextBoxColumn.Name = "FEFisicaDataGridViewTextBoxColumn"
        Me.FEFisicaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FEFisicaDataGridViewTextBoxColumn.Width = 80
        '
        'Nombre_Sucursal
        '
        Me.Nombre_Sucursal.DataPropertyName = "Nombre_Sucursal"
        Me.Nombre_Sucursal.HeaderText = "Nombre Sucursal"
        Me.Nombre_Sucursal.Name = "Nombre_Sucursal"
        Me.Nombre_Sucursal.ReadOnly = True
        Me.Nombre_Sucursal.Width = 110
        '
        'NotasMC
        '
        Me.NotasMC.DataPropertyName = "NotasMC"
        Me.NotasMC.HeaderText = "NotasMC"
        Me.NotasMC.Name = "NotasMC"
        Me.NotasMC.ReadOnly = True
        '
        'Liberado
        '
        Me.Liberado.DataPropertyName = "Liberado"
        Me.Liberado.HeaderText = "Liberado"
        Me.Liberado.Name = "Liberado"
        Me.Liberado.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FechaLib"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha Lib."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'FrmDatosBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 662)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CmbSucursal)
        Me.Controls.Add(Me.CmbReporte)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmDatosBitacora"
        Me.Text = "Reporte de Datos de la Bitacora Jurídica"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosConsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfBitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosBitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DatosBitacoraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JuridicoDS As Agil.JuridicoDS
    Friend WithEvents DatosBitacoraTableAdapter As Agil.JuridicoDSTableAdapters.DatosBitacoraTableAdapter
    Friend WithEvents InfBitacoraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InfBitacoraTableAdapter As Agil.JuridicoDSTableAdapters.InfBitacoraTableAdapter
    Friend WithEvents DatosConsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatosConsultaTableAdapter As Agil.JuridicoDSTableAdapters.DatosConsultaTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbReporte As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SucursalesTableAdapter As Agil.JuridicoDSTableAdapters.SucursalesTableAdapter
    Friend WithEvents Tipar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCicloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescCiclo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prenda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GHipotec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fechacon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaTer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIngNotariaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FFProdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FFNotariaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIRPPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FPNotaraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FENotariaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FEGVsinRUGDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FInscripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FEGVSucursalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLimiteGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumReciboDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FEGVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FEFisicaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotasMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Liberado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
