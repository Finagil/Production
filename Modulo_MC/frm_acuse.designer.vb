<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_acuse
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
        Me.components = New System.ComponentModel.Container()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Bitacora_anexosDS = New Agil.MesaControlDS()
        Me.Vw_Bitacora_anexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_Bitacora_anexoTableAdapter = New Agil.MesaControlDSTableAdapters.Vw_Bitacora_anexoTableAdapter()
        CType(Me.Bitacora_anexosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_Bitacora_anexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(591, 448)
        Me.crv.TabIndex = 0
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'Bitacora_anexosDS
        '
        Me.Bitacora_anexosDS.DataSetName = "Bitacora_anexosDS"
        Me.Bitacora_anexosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_Bitacora_anexoBindingSource
        '
        Me.Vw_Bitacora_anexoBindingSource.DataMember = "Vw_Bitacora_anexo"
        Me.Vw_Bitacora_anexoBindingSource.DataSource = Me.Bitacora_anexosDS
        '
        'Vw_Bitacora_anexoTableAdapter
        '
        Me.Vw_Bitacora_anexoTableAdapter.ClearBeforeFill = True
        '
        'frm_acuse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 448)
        Me.Controls.Add(Me.crv)
        Me.Name = "frm_acuse"
        Me.Text = "Acuse de Recibo de Documentos Valor"
        CType(Me.Bitacora_anexosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_Bitacora_anexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bitacora_anexosDS As Agil.MesaControlDS
    Friend WithEvents Vw_Bitacora_anexoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_Bitacora_anexoTableAdapter As Agil.MesaControlDSTableAdapters.Vw_Bitacora_anexoTableAdapter
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
