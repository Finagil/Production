<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPagoAnticipos
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
        Me.ReportesDS = New Agil.ReportesDS()
        Me.Vw_PagosAnticipadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_PagosAnticipadosTableAdapter = New Agil.ReportesDSTableAdapters.Vw_PagosAnticipadosTableAdapter()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.crvPagosAnticipados = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptPagosAnticipados1 = New Agil.rptPagosAnticipados()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_PagosAnticipadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportesDS
        '
        Me.ReportesDS.DataSetName = "ReportesDS"
        Me.ReportesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_PagosAnticipadosBindingSource
        '
        Me.Vw_PagosAnticipadosBindingSource.DataMember = "Vw_PagosAnticipados"
        Me.Vw_PagosAnticipadosBindingSource.DataSource = Me.ReportesDS
        '
        'Vw_PagosAnticipadosTableAdapter
        '
        Me.Vw_PagosAnticipadosTableAdapter.ClearBeforeFill = True
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Location = New System.Drawing.Point(12, 13)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha1.TabIndex = 0
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Location = New System.Drawing.Point(229, 13)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha2.TabIndex = 1
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(435, 12)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 2
        Me.btnEnviar.Text = "Procesar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'crvPagosAnticipados
        '
        Me.crvPagosAnticipados.ActiveViewIndex = -1
        Me.crvPagosAnticipados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvPagosAnticipados.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvPagosAnticipados.Location = New System.Drawing.Point(12, 49)
        Me.crvPagosAnticipados.Name = "crvPagosAnticipados"
        Me.crvPagosAnticipados.Size = New System.Drawing.Size(1231, 470)
        Me.crvPagosAnticipados.TabIndex = 3
        Me.crvPagosAnticipados.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmPagoAnticipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 531)
        Me.Controls.Add(Me.crvPagosAnticipados)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Name = "frmPagoAnticipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago Anticipos"
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_PagosAnticipadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportesDS As ReportesDS
    Friend WithEvents Vw_PagosAnticipadosBindingSource As BindingSource
    Friend WithEvents Vw_PagosAnticipadosTableAdapter As ReportesDSTableAdapters.Vw_PagosAnticipadosTableAdapter
    Friend WithEvents dtpFecha1 As DateTimePicker
    Friend WithEvents dtpFecha2 As DateTimePicker
    Friend WithEvents btnEnviar As Button
    Friend WithEvents crvPagosAnticipados As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptPagosAnticipados1 As Agil.rptPagosAnticipados
End Class
