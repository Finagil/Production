<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelecProd
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
        Me.components = New System.ComponentModel.Container
        Me.CmbProducto = New System.Windows.Forms.ComboBox
        Me.BttCancel = New System.Windows.Forms.Button
        Me.BttSave = New System.Windows.Forms.Button
        Me.PromocionDS = New Agil.PromocionDS
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Agil.PromocionDSTableAdapters.ProductosTableAdapter
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbProducto
        '
        Me.CmbProducto.DataSource = Me.ProductosBindingSource
        Me.CmbProducto.DisplayMember = "Producto"
        Me.CmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProducto.FormattingEnabled = True
        Me.CmbProducto.Location = New System.Drawing.Point(12, 12)
        Me.CmbProducto.Name = "CmbProducto"
        Me.CmbProducto.Size = New System.Drawing.Size(215, 21)
        Me.CmbProducto.TabIndex = 67
        Me.CmbProducto.ValueMember = "Tipar"
        '
        'BttCancel
        '
        Me.BttCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttCancel.Location = New System.Drawing.Point(329, 9)
        Me.BttCancel.Name = "BttCancel"
        Me.BttCancel.Size = New System.Drawing.Size(72, 27)
        Me.BttCancel.TabIndex = 113
        Me.BttCancel.Text = "Cancelar"
        Me.BttCancel.UseVisualStyleBackColor = True
        '
        'BttSave
        '
        Me.BttSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttSave.Location = New System.Drawing.Point(248, 9)
        Me.BttSave.Name = "BttSave"
        Me.BttSave.Size = New System.Drawing.Size(72, 27)
        Me.BttSave.TabIndex = 112
        Me.BttSave.Text = "OK"
        Me.BttSave.UseVisualStyleBackColor = True
        '
        'PromocionDS
        '
        Me.PromocionDS.DataSetName = "PromocionDS"
        Me.PromocionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.PromocionDS
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'FrmSelecProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 47)
        Me.ControlBox = False
        Me.Controls.Add(Me.BttCancel)
        Me.Controls.Add(Me.BttSave)
        Me.Controls.Add(Me.CmbProducto)
        Me.Name = "FrmSelecProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleciona Producto"
        CType(Me.PromocionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents BttCancel As System.Windows.Forms.Button
    Friend WithEvents BttSave As System.Windows.Forms.Button
    Friend WithEvents PromocionDS As Agil.PromocionDS
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Agil.PromocionDSTableAdapters.ProductosTableAdapter
End Class
