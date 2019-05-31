<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAltaLiquidezAutCRE
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
        Dim TasaLabel As System.Windows.Forms.Label
        Dim CondicionesLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim Saldo_insolutoLabel As System.Windows.Forms.Label
        Dim BcLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.PromocionDS = New Agil.PromocionDS()
        Me.PROM_SolicitudesLIQ_AutorizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter = New Agil.PromocionDSTableAdapters.PROM_SolicitudesLIQ_AutorizacionTableAdapter()
        Me.TableAdapterManager = New Agil.PromocionDSTableAdapters.TableAdapterManager()
        Me.TasaTextBox = New System.Windows.Forms.TextBox()
        Me.CondicionesTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.Cliente_finagilCheckBox = New System.Windows.Forms.CheckBox()
        Me.Saldo_insolutoTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ClientesLiqBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditoDS = New Agil.CreditoDS()
        Me.ClientesLiqTableAdapter = New Agil.CreditoDSTableAdapters.ClientesLiqTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextNotasDG = New System.Windows.Forms.TextBox()
        TasaLabel = New System.Windows.Forms.Label()
        CondicionesLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        Saldo_insolutoLabel = New System.Windows.Forms.Label()
        BcLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesLiqBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TasaLabel
        '
        TasaLabel.AutoSize = True
        TasaLabel.Location = New System.Drawing.Point(252, 228)
        TasaLabel.Name = "TasaLabel"
        TasaLabel.Size = New System.Drawing.Size(34, 13)
        TasaLabel.TabIndex = 2
        TasaLabel.Text = "Tasa:"
        '
        'CondicionesLabel
        '
        CondicionesLabel.AutoSize = True
        CondicionesLabel.Location = New System.Drawing.Point(26, 66)
        CondicionesLabel.Name = "CondicionesLabel"
        CondicionesLabel.Size = New System.Drawing.Size(68, 13)
        CondicionesLabel.TabIndex = 4
        CondicionesLabel.Text = "Condiciones:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(14, 120)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 6
        ObservacionesLabel.Text = "Observaciones:"
        '
        'Saldo_insolutoLabel
        '
        Saldo_insolutoLabel.AutoSize = True
        Saldo_insolutoLabel.Location = New System.Drawing.Point(124, 42)
        Saldo_insolutoLabel.Name = "Saldo_insolutoLabel"
        Saldo_insolutoLabel.Size = New System.Drawing.Size(74, 13)
        Saldo_insolutoLabel.TabIndex = 10
        Saldo_insolutoLabel.Text = "Saldo Insoluto"
        '
        'BcLabel
        '
        BcLabel.AutoSize = True
        BcLabel.Location = New System.Drawing.Point(12, 228)
        BcLabel.Name = "BcLabel"
        BcLabel.Size = New System.Drawing.Size(83, 13)
        BcLabel.TabIndex = 12
        BcLabel.Text = "Buró de Crédito:"
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(31, 174)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(62, 45)
        Label2.TabIndex = 19
        Label2.Text = "Notas Dirección General:"
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROM_SolicitudesLIQ_AutorizacionBindingSource
        '
        Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.DataMember = "PROM_SolicitudesLIQ_Autorizacion"
        Me.PROM_SolicitudesLIQ_AutorizacionBindingSource.DataSource = Me.PromocionDS
        '
        'PROM_SolicitudesLIQ_AutorizacionTableAdapter
        '
        Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CorreosAnexosTableAdapter = Nothing
        Me.TableAdapterManager.Datos_PLDTableAdapter = Nothing
        Me.TableAdapterManager.DatosLegalesTableAdapter = Nothing
        Me.TableAdapterManager.EdoctavTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoresTableAdapter = Nothing
        Me.TableAdapterManager.GEN_EmpleadoresTableAdapter = Nothing
        Me.TableAdapterManager.LI_PeriodosTableAdapter = Nothing
        Me.TableAdapterManager.LI_PlazosTableAdapter = Nothing
        Me.TableAdapterManager.MetodoPagoTableAdapter = Nothing
        Me.TableAdapterManager.NivelesTableAdapter = Nothing
        Me.TableAdapterManager.PlazasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.PROM_Cargos_ExtrasTableAdapter = Nothing
        Me.TableAdapterManager.PROM_SolicitudesLIQ_AutorizacionTableAdapter = Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter
        Me.TableAdapterManager.PROM_SolicitudesLIQ_ImportesTableAdapter = Nothing
        Me.TableAdapterManager.PROM_SolicitudesLIQTableAdapter = Nothing
        Me.TableAdapterManager.RentasdepTableAdapter = Nothing
        Me.TableAdapterManager.TablaESPTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Agil.PromocionDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehiculosTableAdapter = Nothing
        '
        'TasaTextBox
        '
        Me.TasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, "tasa", True))
        Me.TasaTextBox.Location = New System.Drawing.Point(288, 225)
        Me.TasaTextBox.Name = "TasaTextBox"
        Me.TasaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TasaTextBox.TabIndex = 7
        '
        'CondicionesTextBox
        '
        Me.CondicionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, "condiciones", True))
        Me.CondicionesTextBox.Location = New System.Drawing.Point(99, 63)
        Me.CondicionesTextBox.Multiline = True
        Me.CondicionesTextBox.Name = "CondicionesTextBox"
        Me.CondicionesTextBox.Size = New System.Drawing.Size(664, 48)
        Me.CondicionesTextBox.TabIndex = 3
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, "observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(99, 117)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(664, 48)
        Me.ObservacionesTextBox.TabIndex = 4
        '
        'Cliente_finagilCheckBox
        '
        Me.Cliente_finagilCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cliente_finagilCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, "cliente_finagil", True))
        Me.Cliente_finagilCheckBox.Enabled = False
        Me.Cliente_finagilCheckBox.Location = New System.Drawing.Point(12, 37)
        Me.Cliente_finagilCheckBox.Name = "Cliente_finagilCheckBox"
        Me.Cliente_finagilCheckBox.Size = New System.Drawing.Size(106, 24)
        Me.Cliente_finagilCheckBox.TabIndex = 1
        Me.Cliente_finagilCheckBox.Text = "Cliente FINAGIL:"
        Me.Cliente_finagilCheckBox.UseVisualStyleBackColor = True
        '
        'Saldo_insolutoTextBox
        '
        Me.Saldo_insolutoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, "saldo_insoluto", True))
        Me.Saldo_insolutoTextBox.Location = New System.Drawing.Point(204, 39)
        Me.Saldo_insolutoTextBox.Name = "Saldo_insolutoTextBox"
        Me.Saldo_insolutoTextBox.ReadOnly = True
        Me.Saldo_insolutoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Saldo_insolutoTextBox.TabIndex = 2
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(394, 225)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 8
        Me.ButtonSave.Text = "Guardar"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, "bc", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"BUENO", "REGULAR", "MALO"})
        Me.ComboBox1.Location = New System.Drawing.Point(101, 225)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.Text = "BUENO"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(526, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Aprobado"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cliente"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ClientesLiqBindingSource
        Me.ComboBox2.DisplayMember = "Descr"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(58, 10)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(519, 21)
        Me.ComboBox2.TabIndex = 14
        Me.ComboBox2.ValueMember = "Id_Solicitud"
        '
        'ClientesLiqBindingSource
        '
        Me.ClientesLiqBindingSource.DataMember = "ClientesLiq"
        Me.ClientesLiqBindingSource.DataSource = Me.CreditoDS
        '
        'CreditoDS
        '
        Me.CreditoDS.DataSetName = "CreditoDS"
        Me.CreditoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesLiqTableAdapter
        '
        Me.ClientesLiqTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(607, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Rechazar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(688, 225)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Pasa a DG"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(688, 34)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Datos Sol."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextNotasDG
        '
        Me.TextNotasDG.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesLiqBindingSource, "NotaParaDG", True))
        Me.TextNotasDG.Location = New System.Drawing.Point(99, 171)
        Me.TextNotasDG.MaxLength = 500
        Me.TextNotasDG.Multiline = True
        Me.TextNotasDG.Name = "TextNotasDG"
        Me.TextNotasDG.Size = New System.Drawing.Size(664, 48)
        Me.TextNotasDG.TabIndex = 5
        '
        'frmAltaLiquidezAutCRE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 257)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextNotasDG)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(BcLabel)
        Me.Controls.Add(Saldo_insolutoLabel)
        Me.Controls.Add(Me.Saldo_insolutoTextBox)
        Me.Controls.Add(Me.Cliente_finagilCheckBox)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesTextBox)
        Me.Controls.Add(CondicionesLabel)
        Me.Controls.Add(Me.CondicionesTextBox)
        Me.Controls.Add(TasaLabel)
        Me.Controls.Add(Me.TasaTextBox)
        Me.Name = "frmAltaLiquidezAutCRE"
        Me.Text = "Autorización"
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesLiqBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PromocionDS As PromocionDS
    Friend WithEvents PROM_SolicitudesLIQ_AutorizacionBindingSource As BindingSource
    Friend WithEvents PROM_SolicitudesLIQ_AutorizacionTableAdapter As PromocionDSTableAdapters.PROM_SolicitudesLIQ_AutorizacionTableAdapter
    Friend WithEvents TableAdapterManager As PromocionDSTableAdapters.TableAdapterManager
    Friend WithEvents TasaTextBox As TextBox
    Friend WithEvents CondicionesTextBox As TextBox
    Friend WithEvents ObservacionesTextBox As TextBox
    Friend WithEvents Cliente_finagilCheckBox As CheckBox
    Friend WithEvents Saldo_insolutoTextBox As TextBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CreditoDS As CreditoDS
    Friend WithEvents ClientesLiqBindingSource As BindingSource
    Friend WithEvents ClientesLiqTableAdapter As CreditoDSTableAdapters.ClientesLiqTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextNotasDG As TextBox
End Class
