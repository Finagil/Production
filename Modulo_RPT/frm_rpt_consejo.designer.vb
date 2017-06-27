<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt_consejo
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
        Me.ReportesDS = New Agil.ReportesDS()
        Me.VW_ACTIVACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VW_ACTIVACIONESTableAdapter = New Agil.ReportesDSTableAdapters.VW_ACTIVACIONESTableAdapter()
        Me.bt_procesar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_feini = New System.Windows.Forms.DateTimePicker()
        Me.dt_fefin = New System.Windows.Forms.DateTimePicker()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VW_ACTIVACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportesDS
        '
        Me.ReportesDS.DataSetName = "ReportesDS"
        Me.ReportesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VW_ACTIVACIONESBindingSource
        '
        Me.VW_ACTIVACIONESBindingSource.DataMember = "VW_ACTIVACIONES"
        Me.VW_ACTIVACIONESBindingSource.DataSource = Me.ReportesDS
        '
        'VW_ACTIVACIONESTableAdapter
        '
        Me.VW_ACTIVACIONESTableAdapter.ClearBeforeFill = True
        '
        'bt_procesar
        '
        Me.bt_procesar.Location = New System.Drawing.Point(387, 8)
        Me.bt_procesar.Name = "bt_procesar"
        Me.bt_procesar.Size = New System.Drawing.Size(75, 23)
        Me.bt_procesar.TabIndex = 0
        Me.bt_procesar.Text = "Procesar"
        Me.bt_procesar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Location = New System.Drawing.Point(0, 768)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha Final"
        '
        'dt_feini
        '
        Me.dt_feini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_feini.Location = New System.Drawing.Point(97, 10)
        Me.dt_feini.Name = "dt_feini"
        Me.dt_feini.Size = New System.Drawing.Size(89, 20)
        Me.dt_feini.TabIndex = 4
        '
        'dt_fefin
        '
        Me.dt_fefin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fefin.Location = New System.Drawing.Point(282, 10)
        Me.dt_fefin.Name = "dt_fefin"
        Me.dt_fefin.Size = New System.Drawing.Size(88, 20)
        Me.dt_fefin.TabIndex = 5
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Location = New System.Drawing.Point(7, 37)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(1048, 731)
        Me.crv.TabIndex = 6
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frm_rpt_consejo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 781)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.dt_fefin)
        Me.Controls.Add(Me.dt_feini)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_procesar)
        Me.Name = "frm_rpt_consejo"
        Me.Text = "frm_rpt_consejo"
        CType(Me.ReportesDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VW_ACTIVACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportesDS As ReportesDS
    Friend WithEvents VW_ACTIVACIONESBindingSource As BindingSource
    Friend WithEvents VW_ACTIVACIONESTableAdapter As ReportesDSTableAdapters.VW_ACTIVACIONESTableAdapter
    Friend WithEvents bt_procesar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dt_feini As DateTimePicker
    Friend WithEvents dt_fefin As DateTimePicker
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
