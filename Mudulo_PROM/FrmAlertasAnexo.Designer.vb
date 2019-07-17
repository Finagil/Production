<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlertasAnexo
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextLE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextMensaje = New System.Windows.Forms.TextBox()
        Me.TextCorreos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextFacturadas = New System.Windows.Forms.TextBox()
        Me.TextTletras = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VwZPromedioDiasVencBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromocionDS = New Agil.PromocionDS()
        Me.GENNotificacionesAnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEN_NotificacionesAnexosTableAdapter = New Agil.PromocionDSTableAdapters.GEN_NotificacionesAnexosTableAdapter()
        Me.Vw_ZPromedioDiasVencTableAdapter = New Agil.PromocionDSTableAdapters.Vw_ZPromedioDiasVencTableAdapter()
        Me.IdnotificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetraExactaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mensaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreosAdicionales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwZPromedioDiasVencBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GENNotificacionesAnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdnotificacionDataGridViewTextBoxColumn, Me.AnexoDataGridViewTextBoxColumn, Me.LetraExactaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.Mensaje, Me.CorreosAdicionales})
        Me.DataGridView1.DataSource = Me.GENNotificacionesAnexosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(603, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Anexo"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GENNotificacionesAnexosBindingSource, "Anexo", True))
        Me.TextBox1.Location = New System.Drawing.Point(16, 187)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(75, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Letra"
        '
        'TextLE
        '
        Me.TextLE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GENNotificacionesAnexosBindingSource, "LetraExacta", True))
        Me.TextLE.Location = New System.Drawing.Point(96, 187)
        Me.TextLE.Name = "TextLE"
        Me.TextLE.Size = New System.Drawing.Size(100, 20)
        Me.TextLE.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mensaje"
        '
        'TextMensaje
        '
        Me.TextMensaje.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GENNotificacionesAnexosBindingSource, "Mensaje", True))
        Me.TextMensaje.Location = New System.Drawing.Point(16, 229)
        Me.TextMensaje.MaxLength = 400
        Me.TextMensaje.Multiline = True
        Me.TextMensaje.Name = "TextMensaje"
        Me.TextMensaje.Size = New System.Drawing.Size(308, 78)
        Me.TextMensaje.TabIndex = 8
        '
        'TextCorreos
        '
        Me.TextCorreos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GENNotificacionesAnexosBindingSource, "CorreosAdicionales", True))
        Me.TextCorreos.Location = New System.Drawing.Point(330, 228)
        Me.TextCorreos.MaxLength = 500
        Me.TextCorreos.Multiline = True
        Me.TextCorreos.Name = "TextCorreos"
        Me.TextCorreos.Size = New System.Drawing.Size(286, 78)
        Me.TextCorreos.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(327, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(251, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Correos Adicionales (sin el promotor, separado por ;)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(377, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(458, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(539, 312)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextFacturadas
        '
        Me.TextFacturadas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwZPromedioDiasVencBindingSource, "Facturadas", True))
        Me.TextFacturadas.Location = New System.Drawing.Point(411, 187)
        Me.TextFacturadas.Name = "TextFacturadas"
        Me.TextFacturadas.ReadOnly = True
        Me.TextFacturadas.Size = New System.Drawing.Size(100, 20)
        Me.TextFacturadas.TabIndex = 17
        '
        'TextTletras
        '
        Me.TextTletras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwZPromedioDiasVencBindingSource, "Letras", True))
        Me.TextTletras.Location = New System.Drawing.Point(306, 187)
        Me.TextTletras.Name = "TextTletras"
        Me.TextTletras.ReadOnly = True
        Me.TextTletras.Size = New System.Drawing.Size(100, 20)
        Me.TextTletras.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(407, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Letras Facturadas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(305, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Total de Letras"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwZPromedioDiasVencBindingSource, "Vencimiento", True))
        Me.TextBox4.Location = New System.Drawing.Point(516, 187)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(513, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Periodicidad"
        '
        'VwZPromedioDiasVencBindingSource
        '
        Me.VwZPromedioDiasVencBindingSource.DataMember = "Vw_ZPromedioDiasVenc"
        Me.VwZPromedioDiasVencBindingSource.DataSource = Me.PromocionDS
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GENNotificacionesAnexosBindingSource
        '
        Me.GENNotificacionesAnexosBindingSource.DataMember = "GEN_NotificacionesAnexos"
        Me.GENNotificacionesAnexosBindingSource.DataSource = Me.PromocionDS
        '
        'GEN_NotificacionesAnexosTableAdapter
        '
        Me.GEN_NotificacionesAnexosTableAdapter.ClearBeforeFill = True
        '
        'Vw_ZPromedioDiasVencTableAdapter
        '
        Me.Vw_ZPromedioDiasVencTableAdapter.ClearBeforeFill = True
        '
        'IdnotificacionDataGridViewTextBoxColumn
        '
        Me.IdnotificacionDataGridViewTextBoxColumn.DataPropertyName = "id_notificacion"
        Me.IdnotificacionDataGridViewTextBoxColumn.HeaderText = "id_notificacion"
        Me.IdnotificacionDataGridViewTextBoxColumn.Name = "IdnotificacionDataGridViewTextBoxColumn"
        Me.IdnotificacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdnotificacionDataGridViewTextBoxColumn.Visible = False
        Me.IdnotificacionDataGridViewTextBoxColumn.Width = 90
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LetraExactaDataGridViewTextBoxColumn
        '
        Me.LetraExactaDataGridViewTextBoxColumn.DataPropertyName = "LetraExacta"
        Me.LetraExactaDataGridViewTextBoxColumn.HeaderText = "Letra"
        Me.LetraExactaDataGridViewTextBoxColumn.Name = "LetraExactaDataGridViewTextBoxColumn"
        Me.LetraExactaDataGridViewTextBoxColumn.ReadOnly = True
        Me.LetraExactaDataGridViewTextBoxColumn.Width = 90
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha Alta"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 120
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Mensaje
        '
        Me.Mensaje.DataPropertyName = "Mensaje"
        Me.Mensaje.HeaderText = "Mensaje"
        Me.Mensaje.Name = "Mensaje"
        Me.Mensaje.ReadOnly = True
        Me.Mensaje.Width = 200
        '
        'CorreosAdicionales
        '
        Me.CorreosAdicionales.DataPropertyName = "CorreosAdicionales"
        Me.CorreosAdicionales.HeaderText = "Correos Adicionales"
        Me.CorreosAdicionales.Name = "CorreosAdicionales"
        Me.CorreosAdicionales.ReadOnly = True
        Me.CorreosAdicionales.Width = 200
        '
        'FrmAlertasAnexo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 343)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextFacturadas)
        Me.Controls.Add(Me.TextTletras)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextCorreos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextMensaje)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextLE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmAlertasAnexo"
        Me.Text = "Notificaciones por Anexo por Letra (Alertas)"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwZPromedioDiasVencBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GENNotificacionesAnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GENNotificacionesAnexosBindingSource As BindingSource
    Friend WithEvents PromocionDS As PromocionDS
    Friend WithEvents GEN_NotificacionesAnexosTableAdapter As PromocionDSTableAdapters.GEN_NotificacionesAnexosTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextLE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextMensaje As TextBox
    Friend WithEvents TextCorreos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextFacturadas As TextBox
    Friend WithEvents TextTletras As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents VwZPromedioDiasVencBindingSource As BindingSource
    Friend WithEvents Vw_ZPromedioDiasVencTableAdapter As PromocionDSTableAdapters.Vw_ZPromedioDiasVencTableAdapter
    Friend WithEvents IdnotificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LetraExactaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Mensaje As DataGridViewTextBoxColumn
    Friend WithEvents CorreosAdicionales As DataGridViewTextBoxColumn
End Class
