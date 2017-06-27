<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt_solicitud_transferencia
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
        Me.Solicitud_transDS = New Agil.MesaControlDS()
        Me.Vw_MC_SOLICITUD_TRANSFERENCIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_MC_SOLICITUD_TRANSFERENCIATableAdapter = New Agil.MesaControlDSTableAdapters.vw_MC_SOLICITUD_TRANSFERENCIATableAdapter()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.Solicitud_transDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_MC_SOLICITUD_TRANSFERENCIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Solicitud_transDS
        '
        Me.Solicitud_transDS.DataSetName = "solicitud_transDS"
        Me.Solicitud_transDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_MC_SOLICITUD_TRANSFERENCIABindingSource
        '
        Me.Vw_MC_SOLICITUD_TRANSFERENCIABindingSource.DataMember = "vw_MC_SOLICITUD_TRANSFERENCIA"
        Me.Vw_MC_SOLICITUD_TRANSFERENCIABindingSource.DataSource = Me.Solicitud_transDS
        '
        'Vw_MC_SOLICITUD_TRANSFERENCIATableAdapter
        '
        Me.Vw_MC_SOLICITUD_TRANSFERENCIATableAdapter.ClearBeforeFill = True
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
        Me.crv.Size = New System.Drawing.Size(732, 701)
        Me.crv.TabIndex = 0
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'frm_rpt_solicitud_transferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 701)
        Me.Controls.Add(Me.crv)
        Me.Name = "frm_rpt_solicitud_transferencia"
        Me.Text = "SOLICITUD DE TRANSFERENCIA"
        CType(Me.Solicitud_transDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_MC_SOLICITUD_TRANSFERENCIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Solicitud_transDS As Agil.MesaControlDS
    Friend WithEvents Vw_MC_SOLICITUD_TRANSFERENCIABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_MC_SOLICITUD_TRANSFERENCIATableAdapter As Agil.MesaControlDSTableAdapters.vw_MC_SOLICITUD_TRANSFERENCIATableAdapter
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
