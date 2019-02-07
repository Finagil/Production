<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAltaLiquidezAut
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
        Me.PromocionDS = New Agil.PromocionDS()
        Me.PROM_SolicitudesLIQ_AutorizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROM_SolicitudesLIQ_AutorizacionTableAdapter = New Agil.PromocionDSTableAdapters.PROM_SolicitudesLIQ_AutorizacionTableAdapter()
        Me.TableAdapterManager = New Agil.PromocionDSTableAdapters.TableAdapterManager()
        Me.TasaTextBox = New System.Windows.Forms.TextBox()
        Me.CondicionesTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.Cliente_finagilCheckBox = New System.Windows.Forms.CheckBox()
        Me.Saldo_insolutoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        TasaLabel = New System.Windows.Forms.Label()
        CondicionesLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        Saldo_insolutoLabel = New System.Windows.Forms.Label()
        BcLabel = New System.Windows.Forms.Label()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TasaLabel
        '
        TasaLabel.AutoSize = True
        TasaLabel.Location = New System.Drawing.Point(250, 150)
        TasaLabel.Name = "TasaLabel"
        TasaLabel.Size = New System.Drawing.Size(34, 13)
        TasaLabel.TabIndex = 2
        TasaLabel.Text = "Tasa:"
        '
        'CondicionesLabel
        '
        CondicionesLabel.AutoSize = True
        CondicionesLabel.Location = New System.Drawing.Point(26, 42)
        CondicionesLabel.Name = "CondicionesLabel"
        CondicionesLabel.Size = New System.Drawing.Size(68, 13)
        CondicionesLabel.TabIndex = 4
        CondicionesLabel.Text = "Condiciones:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(14, 96)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 6
        ObservacionesLabel.Text = "Observaciones:"
        '
        'Saldo_insolutoLabel
        '
        Saldo_insolutoLabel.AutoSize = True
        Saldo_insolutoLabel.Location = New System.Drawing.Point(124, 18)
        Saldo_insolutoLabel.Name = "Saldo_insolutoLabel"
        Saldo_insolutoLabel.Size = New System.Drawing.Size(74, 13)
        Saldo_insolutoLabel.TabIndex = 10
        Saldo_insolutoLabel.Text = "Saldo Insoluto"
        '
        'BcLabel
        '
        BcLabel.AutoSize = True
        BcLabel.Location = New System.Drawing.Point(10, 150)
        BcLabel.Name = "BcLabel"
        BcLabel.Size = New System.Drawing.Size(83, 13)
        BcLabel.TabIndex = 12
        BcLabel.Text = "Buró de Crédito:"
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
        Me.TableAdapterManager.Cargos_ExtrasTableAdapter = Nothing
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
        Me.TasaTextBox.Location = New System.Drawing.Point(286, 147)
        Me.TasaTextBox.Name = "TasaTextBox"
        Me.TasaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TasaTextBox.TabIndex = 6
        '
        'CondicionesTextBox
        '
        Me.CondicionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, "condiciones", True))
        Me.CondicionesTextBox.Location = New System.Drawing.Point(99, 39)
        Me.CondicionesTextBox.Multiline = True
        Me.CondicionesTextBox.Name = "CondicionesTextBox"
        Me.CondicionesTextBox.Size = New System.Drawing.Size(664, 48)
        Me.CondicionesTextBox.TabIndex = 3
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, "observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(99, 93)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(664, 48)
        Me.ObservacionesTextBox.TabIndex = 4
        '
        'Cliente_finagilCheckBox
        '
        Me.Cliente_finagilCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cliente_finagilCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, "cliente_finagil", True))
        Me.Cliente_finagilCheckBox.Enabled = False
        Me.Cliente_finagilCheckBox.Location = New System.Drawing.Point(12, 13)
        Me.Cliente_finagilCheckBox.Name = "Cliente_finagilCheckBox"
        Me.Cliente_finagilCheckBox.Size = New System.Drawing.Size(106, 24)
        Me.Cliente_finagilCheckBox.TabIndex = 1
        Me.Cliente_finagilCheckBox.Text = "Cliente FINAGIL:"
        Me.Cliente_finagilCheckBox.UseVisualStyleBackColor = True
        '
        'Saldo_insolutoTextBox
        '
        Me.Saldo_insolutoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, "saldo_insoluto", True))
        Me.Saldo_insolutoTextBox.Location = New System.Drawing.Point(204, 15)
        Me.Saldo_insolutoTextBox.Name = "Saldo_insolutoTextBox"
        Me.Saldo_insolutoTextBox.ReadOnly = True
        Me.Saldo_insolutoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Saldo_insolutoTextBox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(607, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, "bc", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"BUENO", "REGULAR", "MALO"})
        Me.ComboBox1.Location = New System.Drawing.Point(99, 147)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.Text = "BUENO"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(688, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmAltaLiquidezAut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 175)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
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
        Me.Name = "frmAltaLiquidezAut"
        Me.Text = "Autorización"
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROM_SolicitudesLIQ_AutorizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
End Class
