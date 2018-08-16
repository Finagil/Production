<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprRelDocOrig
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CreditoDS = New Agil.CreditoDS()
        Me.CRED_RelDocumentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRED_RelDocumentosTableAdapter = New Agil.CreditoDSTableAdapters.CRED_RelDocumentosTableAdapter()
        Me.TableAdapterManager = New Agil.CreditoDSTableAdapters.TableAdapterManager()
        Me.CreditoDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CREDRelDocumentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtFiltroReimpresion = New System.Windows.Forms.TextBox()
        Me.cmbFolios = New System.Windows.Forms.ComboBox()
        Me.lbFiltroCliente = New System.Windows.Forms.Label()
        Me.lbFiltroImprimir = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRED_RelDocumentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditoDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CREDRelDocumentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CreditoDS
        '
        Me.CreditoDS.DataSetName = "CreditoDS"
        Me.CreditoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AviosDetTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CRED_CatalogoEstatusTableAdapter = Nothing
        Me.TableAdapterManager.CRED_LineasCreditoTableAdapter = Nothing
        Me.TableAdapterManager.CRED_RelDocumentosTableAdapter = Me.CRED_RelDocumentosTableAdapter
        Me.TableAdapterManager.CRED_SeguimientoDocumentosTableAdapter = Nothing
        Me.TableAdapterManager.CRED_SeguimientoTableAdapter = Nothing
        Me.TableAdapterManager.GEN_ProductosFinagilTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Agil.CreditoDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CreditoDSBindingSource
        '
        Me.CreditoDSBindingSource.DataSource = Me.CreditoDS
        Me.CreditoDSBindingSource.Position = 0
        '
        'CREDRelDocumentosBindingSource
        '
        Me.CREDRelDocumentosBindingSource.DataMember = "CRED_RelDocumentos"
        Me.CREDRelDocumentosBindingSource.DataSource = Me.CreditoDSBindingSource
        '
        'txtFiltroReimpresion
        '
        Me.txtFiltroReimpresion.Location = New System.Drawing.Point(15, 28)
        Me.txtFiltroReimpresion.Name = "txtFiltroReimpresion"
        Me.txtFiltroReimpresion.Size = New System.Drawing.Size(322, 20)
        Me.txtFiltroReimpresion.TabIndex = 0
        '
        'cmbFolios
        '
        Me.cmbFolios.DataSource = Me.CREDRelDocumentosBindingSource
        Me.cmbFolios.DisplayMember = "id_solicitud"
        Me.cmbFolios.FormattingEnabled = True
        Me.cmbFolios.Location = New System.Drawing.Point(15, 67)
        Me.cmbFolios.Name = "cmbFolios"
        Me.cmbFolios.Size = New System.Drawing.Size(322, 21)
        Me.cmbFolios.TabIndex = 1
        Me.cmbFolios.ValueMember = "id_solicitud"
        '
        'lbFiltroCliente
        '
        Me.lbFiltroCliente.AutoSize = True
        Me.lbFiltroCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFiltroCliente.Location = New System.Drawing.Point(15, 9)
        Me.lbFiltroCliente.Name = "lbFiltroCliente"
        Me.lbFiltroCliente.Size = New System.Drawing.Size(35, 13)
        Me.lbFiltroCliente.TabIndex = 2
        Me.lbFiltroCliente.Text = "Filtro"
        '
        'lbFiltroImprimir
        '
        Me.lbFiltroImprimir.AutoSize = True
        Me.lbFiltroImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFiltroImprimir.Location = New System.Drawing.Point(15, 51)
        Me.lbFiltroImprimir.Name = "lbFiltroImprimir"
        Me.lbFiltroImprimir.Size = New System.Drawing.Size(155, 13)
        Me.lbFiltroImprimir.TabIndex = 3
        Me.lbFiltroImprimir.Text = "Seleccione folio a imprimir"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(149, 94)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Imprimir"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmImprRelDocOrig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 131)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lbFiltroImprimir)
        Me.Controls.Add(Me.lbFiltroCliente)
        Me.Controls.Add(Me.cmbFolios)
        Me.Controls.Add(Me.txtFiltroReimpresion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmImprRelDocOrig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresión "
        CType(Me.CreditoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRED_RelDocumentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditoDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CREDRelDocumentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CreditoDS As CreditoDS
    Friend WithEvents CRED_RelDocumentosBindingSource As BindingSource
    Friend WithEvents CRED_RelDocumentosTableAdapter As CreditoDSTableAdapters.CRED_RelDocumentosTableAdapter
    Friend WithEvents TableAdapterManager As CreditoDSTableAdapters.TableAdapterManager
    Friend WithEvents CreditoDSBindingSource As BindingSource
    Friend WithEvents CREDRelDocumentosBindingSource As BindingSource
    Friend WithEvents txtFiltroReimpresion As TextBox
    Friend WithEvents cmbFolios As ComboBox
    Friend WithEvents lbFiltroCliente As Label
    Friend WithEvents lbFiltroImprimir As Label
    Friend WithEvents btnAceptar As Button
End Class
