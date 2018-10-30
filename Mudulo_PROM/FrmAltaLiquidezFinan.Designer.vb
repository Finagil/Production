<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAltaLiquidezFinan
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
        Dim SalarioNetoLabel As System.Windows.Forms.Label
        Dim PasivosLabel As System.Windows.Forms.Label
        Dim IngresosAdicionalesLabel As System.Windows.Forms.Label
        Dim PagoPasivosLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PROMSolicitudesLIQBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS = New Agil.PromocionDS()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNumAmort = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPagofin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PROMSolicitudesLIQImportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PROMSolicitudesLIQImportesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS1 = New Agil.PromocionDS()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CmbExpe = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmboAtrasos = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbClaves = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PROM_SolicitudesLIQTableAdapter = New Agil.PromocionDSTableAdapters.PROM_SolicitudesLIQTableAdapter()
        Me.PROM_SolicitudesLIQ_ImportesTableAdapter = New Agil.PromocionDSTableAdapters.PROM_SolicitudesLIQ_ImportesTableAdapter()
        Me.TableAdapterManager = New Agil.PromocionDSTableAdapters.TableAdapterManager()
        Me.SalarioNetoTextBox = New System.Windows.Forms.TextBox()
        Me.PasivosTextBox = New System.Windows.Forms.TextBox()
        Me.IngresosAdicionalesTextBox = New System.Windows.Forms.TextBox()
        Me.PagoPasivosTextBox = New System.Windows.Forms.TextBox()
        Me.txtTotalIngresosMensuales = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        SalarioNetoLabel = New System.Windows.Forms.Label()
        PasivosLabel = New System.Windows.Forms.Label()
        IngresosAdicionalesLabel = New System.Windows.Forms.Label()
        PagoPasivosLabel = New System.Windows.Forms.Label()
        CType(Me.PROMSolicitudesLIQBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROMSolicitudesLIQImportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROMSolicitudesLIQImportesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalarioNetoLabel
        '
        SalarioNetoLabel.AutoSize = True
        SalarioNetoLabel.Location = New System.Drawing.Point(48, 250)
        SalarioNetoLabel.Name = "SalarioNetoLabel"
        SalarioNetoLabel.Size = New System.Drawing.Size(68, 13)
        SalarioNetoLabel.TabIndex = 31
        SalarioNetoLabel.Text = "Salario Neto:"
        '
        'PasivosLabel
        '
        PasivosLabel.AutoSize = True
        PasivosLabel.Location = New System.Drawing.Point(281, 247)
        PasivosLabel.Name = "PasivosLabel"
        PasivosLabel.Size = New System.Drawing.Size(47, 13)
        PasivosLabel.TabIndex = 32
        PasivosLabel.Text = "Pasivos:"
        '
        'IngresosAdicionalesLabel
        '
        IngresosAdicionalesLabel.AutoSize = True
        IngresosAdicionalesLabel.Location = New System.Drawing.Point(9, 276)
        IngresosAdicionalesLabel.Name = "IngresosAdicionalesLabel"
        IngresosAdicionalesLabel.Size = New System.Drawing.Size(107, 13)
        IngresosAdicionalesLabel.TabIndex = 34
        IngresosAdicionalesLabel.Text = "Ingresos Adicionales:"
        '
        'PagoPasivosLabel
        '
        PagoPasivosLabel.AutoSize = True
        PagoPasivosLabel.Location = New System.Drawing.Point(253, 273)
        PagoPasivosLabel.Name = "PagoPasivosLabel"
        PagoPasivosLabel.Size = New System.Drawing.Size(75, 13)
        PagoPasivosLabel.TabIndex = 35
        PagoPasivosLabel.Text = "Pago Pasivos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto Solicitado"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "MontoFinanciado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextBox1.Location = New System.Drawing.Point(16, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'PROMSolicitudesLIQBindingSource
        '
        Me.PROMSolicitudesLIQBindingSource.DataMember = "PROM_SolicitudesLIQ"
        Me.PROMSolicitudesLIQBindingSource.DataSource = Me.PromocionDS
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Plazo", True))
        Me.TextBox2.Location = New System.Drawing.Point(122, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Plazo"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Periodicidad", True))
        Me.TextBox3.Location = New System.Drawing.Point(228, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Periodicidad"
        '
        'TxtNumAmort
        '
        Me.TxtNumAmort.Location = New System.Drawing.Point(334, 24)
        Me.TxtNumAmort.Name = "TxtNumAmort"
        Me.TxtNumAmort.ReadOnly = True
        Me.TxtNumAmort.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumAmort.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(331, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No. Amortizaciones"
        '
        'TxtPagofin
        '
        Me.TxtPagofin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "PagoFinagil", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtPagofin.Location = New System.Drawing.Point(16, 67)
        Me.TxtPagofin.Name = "TxtPagofin"
        Me.TxtPagofin.Size = New System.Drawing.Size(100, 20)
        Me.TxtPagofin.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Pago Finagil"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Ingresos Netos Mensuales"
        '
        'PROMSolicitudesLIQImportesBindingSource
        '
        Me.PROMSolicitudesLIQImportesBindingSource.DataMember = "PROM_SolicitudesLIQ_Importes"
        Me.PROMSolicitudesLIQImportesBindingSource.DataSource = Me.PromocionDS
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(173, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Egresos netos Mesuales (BC y Otros)"
        '
        'PROMSolicitudesLIQImportesBindingSource1
        '
        Me.PROMSolicitudesLIQImportesBindingSource1.DataMember = "PROM_SolicitudesLIQ_Importes"
        Me.PROMSolicitudesLIQImportesBindingSource1.DataSource = Me.PromocionDS1
        '
        'PromocionDS1
        '
        Me.PromocionDS1.DataSetName = "PromocionDS"
        Me.PromocionDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Calcular RDC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(102, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "RCD"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "RCD", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "p2"))
        Me.TextBox6.Location = New System.Drawing.Point(105, 407)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(47, 20)
        Me.TextBox6.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(351, 405)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Procesar Solicitud"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CmbExpe
        '
        Me.CmbExpe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "ExperienciaBC", True))
        Me.CmbExpe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbExpe.FormattingEnabled = True
        Me.CmbExpe.Items.AddRange(New Object() {"PAGOS PUNTUALES/SIN EXPERIENCIA", "HASTA 10 ATRASOS DE HASTA 29 DÍAS", "DESDE 11 ATRASOS DE HASTA 29 DÍAS"})
        Me.CmbExpe.Location = New System.Drawing.Point(16, 149)
        Me.CmbExpe.Name = "CmbExpe"
        Me.CmbExpe.Size = New System.Drawing.Size(418, 21)
        Me.CmbExpe.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Experiencia de Pago"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Atrasos Vigentes"
        '
        'CmboAtrasos
        '
        Me.CmboAtrasos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "AtrasosBC", True))
        Me.CmboAtrasos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboAtrasos.FormattingEnabled = True
        Me.CmboAtrasos.Items.AddRange(New Object() {"SIN ATRASOS VIGENTES", "CON ATRASOS VIGENTES < AL 10% DEL MONTO SOLICITADO DE HASTA 29 DÍAS", "CON ATRASOS VIGENTES > AL 10% DEL MONTO SOLICITADO DE HASTA 29 DÍAS"})
        Me.CmboAtrasos.Location = New System.Drawing.Point(16, 189)
        Me.CmboAtrasos.Name = "CmboAtrasos"
        Me.CmboAtrasos.Size = New System.Drawing.Size(418, 21)
        Me.CmboAtrasos.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Claves de Prevención"
        '
        'CmbClaves
        '
        Me.CmbClaves.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "ClavesBC", True))
        Me.CmbClaves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClaves.FormattingEnabled = True
        Me.CmbClaves.Items.AddRange(New Object() {"SIN CLAVES DE PREVENCIÓN", "CON CLAVES DE PREVENCION = COMUNICACIONES", "CON CLAVES DE PREVENCIÓN <> COMUNICACIONES"})
        Me.CmbClaves.Location = New System.Drawing.Point(16, 107)
        Me.CmbClaves.Name = "CmbClaves"
        Me.CmbClaves.Size = New System.Drawing.Size(418, 21)
        Me.CmbClaves.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Estatus", True))
        Me.TextBox4.Location = New System.Drawing.Point(158, 407)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(170, 20)
        Me.TextBox4.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(155, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Estatus"
        '
        'PROM_SolicitudesLIQTableAdapter
        '
        Me.PROM_SolicitudesLIQTableAdapter.ClearBeforeFill = True
        '
        'PROM_SolicitudesLIQ_ImportesTableAdapter
        '
        Me.PROM_SolicitudesLIQ_ImportesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Cargos_ExtrasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CorreosAnexosTableAdapter = Nothing
        Me.TableAdapterManager.DatosLegalesTableAdapter = Nothing
        Me.TableAdapterManager.EdoctavTableAdapter = Nothing
        Me.TableAdapterManager.LI_PeriodosTableAdapter = Nothing
        Me.TableAdapterManager.LI_PlazosTableAdapter = Nothing
        Me.TableAdapterManager.MetodoPagoTableAdapter = Nothing
        Me.TableAdapterManager.NivelesTableAdapter = Nothing
        Me.TableAdapterManager.PlazasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.PROM_Cargos_ExtrasTableAdapter = Nothing
        Me.TableAdapterManager.PROM_SolicitudesLIQ_AutorizacionTableAdapter = Nothing
        Me.TableAdapterManager.PROM_SolicitudesLIQ_ImportesTableAdapter = Nothing
        Me.TableAdapterManager.PROM_SolicitudesLIQTableAdapter = Nothing
        Me.TableAdapterManager.RentasdepTableAdapter = Nothing
        Me.TableAdapterManager.TablaESPTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Agil.PromocionDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehiculosTableAdapter = Nothing
        '
        'SalarioNetoTextBox
        '
        Me.SalarioNetoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "SalarioNeto", True))
        Me.SalarioNetoTextBox.Location = New System.Drawing.Point(122, 247)
        Me.SalarioNetoTextBox.Name = "SalarioNetoTextBox"
        Me.SalarioNetoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalarioNetoTextBox.TabIndex = 32
        Me.SalarioNetoTextBox.Text = "0"
        '
        'PasivosTextBox
        '
        Me.PasivosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "Pasivos", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.PasivosTextBox.Location = New System.Drawing.Point(334, 244)
        Me.PasivosTextBox.Name = "PasivosTextBox"
        Me.PasivosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasivosTextBox.TabIndex = 33
        Me.PasivosTextBox.Text = "0"
        '
        'IngresosAdicionalesTextBox
        '
        Me.IngresosAdicionalesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "IngresosAdicionales", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.IngresosAdicionalesTextBox.Location = New System.Drawing.Point(122, 273)
        Me.IngresosAdicionalesTextBox.Name = "IngresosAdicionalesTextBox"
        Me.IngresosAdicionalesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IngresosAdicionalesTextBox.TabIndex = 35
        Me.IngresosAdicionalesTextBox.Text = "0"
        '
        'PagoPasivosTextBox
        '
        Me.PagoPasivosTextBox.Location = New System.Drawing.Point(334, 270)
        Me.PagoPasivosTextBox.Name = "PagoPasivosTextBox"
        Me.PagoPasivosTextBox.ReadOnly = True
        Me.PagoPasivosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PagoPasivosTextBox.TabIndex = 36
        Me.PagoPasivosTextBox.Text = "0.00"
        '
        'txtTotalIngresosMensuales
        '
        Me.txtTotalIngresosMensuales.Location = New System.Drawing.Point(122, 323)
        Me.txtTotalIngresosMensuales.Name = "txtTotalIngresosMensuales"
        Me.txtTotalIngresosMensuales.ReadOnly = True
        Me.txtTotalIngresosMensuales.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalIngresosMensuales.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(82, 326)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Total:"
        '
        'FrmAltaLiquidezFinan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 448)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTotalIngresosMensuales)
        Me.Controls.Add(PagoPasivosLabel)
        Me.Controls.Add(Me.PagoPasivosTextBox)
        Me.Controls.Add(IngresosAdicionalesLabel)
        Me.Controls.Add(Me.IngresosAdicionalesTextBox)
        Me.Controls.Add(PasivosLabel)
        Me.Controls.Add(Me.PasivosTextBox)
        Me.Controls.Add(SalarioNetoLabel)
        Me.Controls.Add(Me.SalarioNetoTextBox)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CmbClaves)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CmboAtrasos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmbExpe)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtPagofin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNumAmort)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROMSolicitudesLIQBindingSource, "MontoFinanciado", True))
        Me.Name = "FrmAltaLiquidezFinan"
        Me.Text = "Datos Financieros Liquidez Inmediata"
        CType(Me.PROMSolicitudesLIQBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROMSolicitudesLIQImportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROMSolicitudesLIQImportesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNumAmort As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPagofin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PromocionDS As PromocionDS
    Friend WithEvents PROMSolicitudesLIQBindingSource As BindingSource
    Friend WithEvents PROM_SolicitudesLIQTableAdapter As PromocionDSTableAdapters.PROM_SolicitudesLIQTableAdapter
    Friend WithEvents Label9 As Label
    Friend WithEvents PROMSolicitudesLIQImportesBindingSource As BindingSource
    Friend WithEvents PROM_SolicitudesLIQ_ImportesTableAdapter As PromocionDSTableAdapters.PROM_SolicitudesLIQ_ImportesTableAdapter
    Friend WithEvents Label10 As Label
    Friend WithEvents PromocionDS1 As PromocionDS
    Friend WithEvents PROMSolicitudesLIQImportesBindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents CmbExpe As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CmboAtrasos As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CmbClaves As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TableAdapterManager As PromocionDSTableAdapters.TableAdapterManager
    Friend WithEvents SalarioNetoTextBox As TextBox
    Friend WithEvents PasivosTextBox As TextBox
    Friend WithEvents IngresosAdicionalesTextBox As TextBox
    Friend WithEvents PagoPasivosTextBox As TextBox
    Friend WithEvents txtTotalIngresosMensuales As TextBox
    Friend WithEvents Label13 As Label
End Class
