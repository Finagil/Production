<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaListaNegra
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
        Me.btnProcesarArchivo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ofdSeleccionaArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnProcesarArchivo
        '
        Me.btnProcesarArchivo.Location = New System.Drawing.Point(140, 43)
        Me.btnProcesarArchivo.Name = "btnProcesarArchivo"
        Me.btnProcesarArchivo.Size = New System.Drawing.Size(126, 23)
        Me.btnProcesarArchivo.TabIndex = 0
        Me.btnProcesarArchivo.Text = "Seleccionar archivo "
        Me.btnProcesarArchivo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(307, 92)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmCargaListaNegra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 127)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnProcesarArchivo)
        Me.Name = "frmCargaListaNegra"
        Me.Text = "Carga Lista EFO SAT"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProcesarArchivo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents ofdSeleccionaArchivo As OpenFileDialog
End Class
