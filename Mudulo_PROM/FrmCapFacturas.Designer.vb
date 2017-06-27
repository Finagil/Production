<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCapFacturas
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnCambioFact = New System.Windows.Forms.Button
        Me.btnAltaFact = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPlaca = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDetalle = New System.Windows.Forms.RichTextBox
        Me.btnIgnorar = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtImporte = New System.Windows.Forms.TextBox
        Me.txtMotor = New System.Windows.Forms.TextBox
        Me.txtSerie = New System.Windows.Forms.TextBox
        Me.txtProveedor = New System.Windows.Forms.TextBox
        Me.txtFactura = New System.Windows.Forms.TextBox
        Me.ActifijoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New Agil.ProductionDataSet
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrimaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FactfijDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AseguradorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumpolizDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IniciosegDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VigencsegDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EndosoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CoberturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoPolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PolPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BPreferenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDaCTIVODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ActifijoTableAdapter = New Agil.ProductionDataSetTableAdapters.ActifijoTableAdapter
        Me.txtModelo = New System.Windows.Forms.MaskedTextBox
        Me.TxtID = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ActifijoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.FacturaDataGridViewTextBoxColumn, Me.ProveedorDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.PrimaDataGridViewTextBoxColumn, Me.DetalleDataGridViewTextBoxColumn, Me.FactfijDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.MotorDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.PlacaDataGridViewTextBoxColumn, Me.AseguradorDataGridViewTextBoxColumn, Me.NumpolizDataGridViewTextBoxColumn, Me.IniciosegDataGridViewTextBoxColumn, Me.VigencsegDataGridViewTextBoxColumn, Me.EndosoDataGridViewTextBoxColumn, Me.CoberturaDataGridViewTextBoxColumn, Me.TipoPolDataGridViewTextBoxColumn, Me.PolPagoDataGridViewTextBoxColumn, Me.BPreferenteDataGridViewTextBoxColumn, Me.IDaCTIVODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ActifijoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(696, 206)
        Me.DataGridView1.TabIndex = 19
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(572, 228)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(136, 23)
        Me.btnSalir.TabIndex = 24
        Me.btnSalir.Text = "Salir"
        '
        'btnCambioFact
        '
        Me.btnCambioFact.Location = New System.Drawing.Point(172, 228)
        Me.btnCambioFact.Name = "btnCambioFact"
        Me.btnCambioFact.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnCambioFact.Size = New System.Drawing.Size(136, 23)
        Me.btnCambioFact.TabIndex = 22
        Me.btnCambioFact.Text = "Modificar Factura"
        '
        'btnAltaFact
        '
        Me.btnAltaFact.Location = New System.Drawing.Point(20, 228)
        Me.btnAltaFact.Name = "btnAltaFact"
        Me.btnAltaFact.Size = New System.Drawing.Size(136, 23)
        Me.btnAltaFact.TabIndex = 21
        Me.btnAltaFact.Text = "Alta Factura"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtModelo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtPlaca)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtDetalle)
        Me.Panel1.Controls.Add(Me.btnIgnorar)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtImporte)
        Me.Panel1.Controls.Add(Me.txtMotor)
        Me.Panel1.Controls.Add(Me.txtSerie)
        Me.Panel1.Controls.Add(Me.txtProveedor)
        Me.Panel1.Controls.Add(Me.txtFactura)
        Me.Panel1.Location = New System.Drawing.Point(12, 268)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 252)
        Me.Panel1.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(18, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "No. de Placa"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPlaca
        '
        Me.txtPlaca.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "Placa", True))
        Me.txtPlaca.Location = New System.Drawing.Point(137, 114)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(63, 20)
        Me.txtPlaca.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(656, 23)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "En el campo ""Importe"" debes capturar el valor total de cada una de las facturas"
        '
        'txtDetalle
        '
        Me.txtDetalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "Detalle", True))
        Me.txtDetalle.Location = New System.Drawing.Point(136, 146)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(536, 88)
        Me.txtDetalle.TabIndex = 7
        Me.txtDetalle.Text = ""
        '
        'btnIgnorar
        '
        Me.btnIgnorar.Location = New System.Drawing.Point(24, 210)
        Me.btnIgnorar.Name = "btnIgnorar"
        Me.btnIgnorar.Size = New System.Drawing.Size(75, 23)
        Me.btnIgnorar.TabIndex = 9
        Me.btnIgnorar.Text = "No Guardar"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(24, 170)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Guardar"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(520, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Importe"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Descripción del Bien"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(588, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Modelo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(323, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "No. de Motor"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "No. de Serie"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Proveedor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Factura No."
        '
        'txtImporte
        '
        Me.txtImporte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "Importe", True))
        Me.txtImporte.Location = New System.Drawing.Point(573, 40)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 1
        '
        'txtMotor
        '
        Me.txtMotor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "Motor", True))
        Me.txtMotor.Location = New System.Drawing.Point(401, 88)
        Me.txtMotor.Name = "txtMotor"
        Me.txtMotor.Size = New System.Drawing.Size(145, 20)
        Me.txtMotor.TabIndex = 4
        '
        'txtSerie
        '
        Me.txtSerie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "Serie", True))
        Me.txtSerie.Location = New System.Drawing.Point(136, 88)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(151, 20)
        Me.txtSerie.TabIndex = 3
        '
        'txtProveedor
        '
        Me.txtProveedor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "Proveedor", True))
        Me.txtProveedor.Location = New System.Drawing.Point(136, 64)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(536, 20)
        Me.txtProveedor.TabIndex = 2
        '
        'txtFactura
        '
        Me.txtFactura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "Factura", True))
        Me.txtFactura.Location = New System.Drawing.Point(136, 40)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtFactura.TabIndex = 0
        '
        'ActifijoBindingSource
        '
        Me.ActifijoBindingSource.DataMember = "Actifijo"
        Me.ActifijoBindingSource.DataSource = Me.ProductionDataSet
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AnexoDataGridViewTextBoxColumn.Visible = False
        '
        'FacturaDataGridViewTextBoxColumn
        '
        Me.FacturaDataGridViewTextBoxColumn.DataPropertyName = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.HeaderText = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.Name = "FacturaDataGridViewTextBoxColumn"
        Me.FacturaDataGridViewTextBoxColumn.Width = 90
        '
        'ProveedorDataGridViewTextBoxColumn
        '
        Me.ProveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.Name = "ProveedorDataGridViewTextBoxColumn"
        Me.ProveedorDataGridViewTextBoxColumn.Width = 350
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.Width = 90
        '
        'PrimaDataGridViewTextBoxColumn
        '
        Me.PrimaDataGridViewTextBoxColumn.DataPropertyName = "Prima"
        Me.PrimaDataGridViewTextBoxColumn.HeaderText = "Prima"
        Me.PrimaDataGridViewTextBoxColumn.Name = "PrimaDataGridViewTextBoxColumn"
        Me.PrimaDataGridViewTextBoxColumn.Visible = False
        '
        'DetalleDataGridViewTextBoxColumn
        '
        Me.DetalleDataGridViewTextBoxColumn.DataPropertyName = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.HeaderText = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.Name = "DetalleDataGridViewTextBoxColumn"
        Me.DetalleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DetalleDataGridViewTextBoxColumn.Visible = False
        '
        'FactfijDataGridViewTextBoxColumn
        '
        Me.FactfijDataGridViewTextBoxColumn.DataPropertyName = "Factfij"
        Me.FactfijDataGridViewTextBoxColumn.HeaderText = "Fact. Activo"
        Me.FactfijDataGridViewTextBoxColumn.Name = "FactfijDataGridViewTextBoxColumn"
        Me.FactfijDataGridViewTextBoxColumn.Visible = False
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.Width = 50
        '
        'MotorDataGridViewTextBoxColumn
        '
        Me.MotorDataGridViewTextBoxColumn.DataPropertyName = "Motor"
        Me.MotorDataGridViewTextBoxColumn.HeaderText = "Motor"
        Me.MotorDataGridViewTextBoxColumn.Name = "MotorDataGridViewTextBoxColumn"
        Me.MotorDataGridViewTextBoxColumn.Width = 150
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "Serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.Width = 150
        '
        'PlacaDataGridViewTextBoxColumn
        '
        Me.PlacaDataGridViewTextBoxColumn.DataPropertyName = "Placa"
        Me.PlacaDataGridViewTextBoxColumn.HeaderText = "Placa"
        Me.PlacaDataGridViewTextBoxColumn.Name = "PlacaDataGridViewTextBoxColumn"
        Me.PlacaDataGridViewTextBoxColumn.Visible = False
        '
        'AseguradorDataGridViewTextBoxColumn
        '
        Me.AseguradorDataGridViewTextBoxColumn.DataPropertyName = "Asegurador"
        Me.AseguradorDataGridViewTextBoxColumn.HeaderText = "Asegurador"
        Me.AseguradorDataGridViewTextBoxColumn.Name = "AseguradorDataGridViewTextBoxColumn"
        Me.AseguradorDataGridViewTextBoxColumn.Visible = False
        '
        'NumpolizDataGridViewTextBoxColumn
        '
        Me.NumpolizDataGridViewTextBoxColumn.DataPropertyName = "Numpoliz"
        Me.NumpolizDataGridViewTextBoxColumn.HeaderText = "Numpoliz"
        Me.NumpolizDataGridViewTextBoxColumn.Name = "NumpolizDataGridViewTextBoxColumn"
        Me.NumpolizDataGridViewTextBoxColumn.Visible = False
        '
        'IniciosegDataGridViewTextBoxColumn
        '
        Me.IniciosegDataGridViewTextBoxColumn.DataPropertyName = "Inicioseg"
        Me.IniciosegDataGridViewTextBoxColumn.HeaderText = "Inicioseg"
        Me.IniciosegDataGridViewTextBoxColumn.Name = "IniciosegDataGridViewTextBoxColumn"
        Me.IniciosegDataGridViewTextBoxColumn.Visible = False
        '
        'VigencsegDataGridViewTextBoxColumn
        '
        Me.VigencsegDataGridViewTextBoxColumn.DataPropertyName = "Vigencseg"
        Me.VigencsegDataGridViewTextBoxColumn.HeaderText = "Vigencseg"
        Me.VigencsegDataGridViewTextBoxColumn.Name = "VigencsegDataGridViewTextBoxColumn"
        Me.VigencsegDataGridViewTextBoxColumn.Visible = False
        '
        'EndosoDataGridViewTextBoxColumn
        '
        Me.EndosoDataGridViewTextBoxColumn.DataPropertyName = "Endoso"
        Me.EndosoDataGridViewTextBoxColumn.HeaderText = "Endoso"
        Me.EndosoDataGridViewTextBoxColumn.Name = "EndosoDataGridViewTextBoxColumn"
        Me.EndosoDataGridViewTextBoxColumn.Visible = False
        '
        'CoberturaDataGridViewTextBoxColumn
        '
        Me.CoberturaDataGridViewTextBoxColumn.DataPropertyName = "Cobertura"
        Me.CoberturaDataGridViewTextBoxColumn.HeaderText = "Cobertura"
        Me.CoberturaDataGridViewTextBoxColumn.Name = "CoberturaDataGridViewTextBoxColumn"
        Me.CoberturaDataGridViewTextBoxColumn.Visible = False
        '
        'TipoPolDataGridViewTextBoxColumn
        '
        Me.TipoPolDataGridViewTextBoxColumn.DataPropertyName = "TipoPol"
        Me.TipoPolDataGridViewTextBoxColumn.HeaderText = "TipoPol"
        Me.TipoPolDataGridViewTextBoxColumn.Name = "TipoPolDataGridViewTextBoxColumn"
        Me.TipoPolDataGridViewTextBoxColumn.Visible = False
        '
        'PolPagoDataGridViewTextBoxColumn
        '
        Me.PolPagoDataGridViewTextBoxColumn.DataPropertyName = "PolPago"
        Me.PolPagoDataGridViewTextBoxColumn.HeaderText = "PolPago"
        Me.PolPagoDataGridViewTextBoxColumn.Name = "PolPagoDataGridViewTextBoxColumn"
        Me.PolPagoDataGridViewTextBoxColumn.Visible = False
        '
        'BPreferenteDataGridViewTextBoxColumn
        '
        Me.BPreferenteDataGridViewTextBoxColumn.DataPropertyName = "BPreferente"
        Me.BPreferenteDataGridViewTextBoxColumn.HeaderText = "BPreferente"
        Me.BPreferenteDataGridViewTextBoxColumn.Name = "BPreferenteDataGridViewTextBoxColumn"
        Me.BPreferenteDataGridViewTextBoxColumn.Visible = False
        '
        'IDaCTIVODataGridViewTextBoxColumn
        '
        Me.IDaCTIVODataGridViewTextBoxColumn.DataPropertyName = "IDaCTIVO"
        Me.IDaCTIVODataGridViewTextBoxColumn.HeaderText = "IDaCTIVO"
        Me.IDaCTIVODataGridViewTextBoxColumn.Name = "IDaCTIVODataGridViewTextBoxColumn"
        Me.IDaCTIVODataGridViewTextBoxColumn.ReadOnly = True
        Me.IDaCTIVODataGridViewTextBoxColumn.Visible = False
        '
        'ActifijoTableAdapter
        '
        Me.ActifijoTableAdapter.ClearBeforeFill = True
        '
        'txtModelo
        '
        Me.txtModelo.BeepOnError = True
        Me.txtModelo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "Modelo", True))
        Me.txtModelo.Location = New System.Drawing.Point(643, 88)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(31, 20)
        Me.txtModelo.TabIndex = 5
        '
        'TxtID
        '
        Me.TxtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActifijoBindingSource, "IDaCTIVO", True))
        Me.TxtID.Location = New System.Drawing.Point(585, 230)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(10, 20)
        Me.TxtID.TabIndex = 26
        '
        'FrmCapFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 529)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCambioFact)
        Me.Controls.Add(Me.btnAltaFact)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtID)
        Me.Name = "FrmCapFacturas"
        Me.Text = "Facturas Originales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ActifijoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCambioFact As System.Windows.Forms.Button
    Friend WithEvents btnAltaFact As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPlaca As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As System.Windows.Forms.RichTextBox
    Friend WithEvents btnIgnorar As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtMotor As System.Windows.Forms.TextBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents ActifijoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductionDataSet As Agil.ProductionDataSet
    Friend WithEvents ActifijoTableAdapter As Agil.ProductionDataSetTableAdapters.ActifijoTableAdapter
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FactfijDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlacaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AseguradorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumpolizDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IniciosegDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VigencsegDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndosoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CoberturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoPolDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PolPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BPreferenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDaCTIVODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtModelo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
End Class
