<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaPolizaAvio
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
        Me.lblNumc = New System.Windows.Forms.Label()
        Me.CmbCiclo = New System.Windows.Forms.ComboBox()
        Me.CiclosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegurosDS = New Agil.SegurosDS()
        Me.CiclosTableAdapter = New Agil.SegurosDSTableAdapters.CiclosTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbPol = New System.Windows.Forms.ComboBox()
        Me.SEGPolizasAvioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SEG_PolizasAvioTableAdapter = New Agil.SegurosDSTableAdapters.SEG_PolizasAvioTableAdapter()
        Me.SEGAseguradorasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BttNew = New System.Windows.Forms.Button()
        Me.BttMod = New System.Windows.Forms.Button()
        Me.BttSave = New System.Windows.Forms.Button()
        Me.BttCancel = New System.Windows.Forms.Button()
        Me.SEG_AseguradorasTableAdapter = New Agil.SegurosDSTableAdapters.SEG_AseguradorasTableAdapter()
        Me.BttDel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupDatos = New System.Windows.Forms.GroupBox()
        Me.TxtDiff = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtSinCont = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtConCont = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txtsuper = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTpag = New System.Windows.Forms.DateTimePicker()
        Me.DtFin = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPrima = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DTini = New System.Windows.Forms.DateTimePicker()
        Me.DTpol = New System.Windows.Forms.DateTimePicker()
        Me.TxtSumaAseg = New System.Windows.Forms.TextBox()
        Me.Txtcuota = New System.Windows.Forms.TextBox()
        Me.CmbAseg = New System.Windows.Forms.ComboBox()
        Me.CmbCultivo = New System.Windows.Forms.ComboBox()
        Me.SEGCultivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtPol = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BttSiniestros = New System.Windows.Forms.Button()
        Me.GEN_CultivosTableAdapter = New Agil.SegurosDSTableAdapters.GEN_CultivosTableAdapter()
        Me.BttCatalogos = New System.Windows.Forms.Button()
        CType(Me.CiclosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGPolizasAvioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDatos.SuspendLayout()
        CType(Me.SEGCultivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumc
        '
        Me.lblNumc.Location = New System.Drawing.Point(12, 9)
        Me.lblNumc.Name = "lblNumc"
        Me.lblNumc.Size = New System.Drawing.Size(48, 16)
        Me.lblNumc.TabIndex = 63
        Me.lblNumc.Text = "Ciclo"
        Me.lblNumc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbCiclo
        '
        Me.CmbCiclo.DataSource = Me.CiclosBindingSource
        Me.CmbCiclo.DisplayMember = "DescCiclo"
        Me.CmbCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCiclo.FormattingEnabled = True
        Me.CmbCiclo.Location = New System.Drawing.Point(51, 8)
        Me.CmbCiclo.Name = "CmbCiclo"
        Me.CmbCiclo.Size = New System.Drawing.Size(126, 21)
        Me.CmbCiclo.TabIndex = 65
        Me.CmbCiclo.ValueMember = "Ciclo"
        '
        'CiclosBindingSource
        '
        Me.CiclosBindingSource.DataMember = "Ciclos"
        Me.CiclosBindingSource.DataSource = Me.SegurosDS
        '
        'SegurosDS
        '
        Me.SegurosDS.DataSetName = "SegurosDS"
        Me.SegurosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CiclosTableAdapter
        '
        Me.CiclosTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Polizas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbPol
        '
        Me.CmbPol.DataSource = Me.SEGPolizasAvioBindingSource
        Me.CmbPol.DisplayMember = "Poliza"
        Me.CmbPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPol.FormattingEnabled = True
        Me.CmbPol.Location = New System.Drawing.Point(51, 35)
        Me.CmbPol.Name = "CmbPol"
        Me.CmbPol.Size = New System.Drawing.Size(178, 21)
        Me.CmbPol.TabIndex = 67
        Me.CmbPol.ValueMember = "IdPoliza"
        '
        'SEGPolizasAvioBindingSource
        '
        Me.SEGPolizasAvioBindingSource.DataMember = "SEG_PolizasAvio"
        Me.SEGPolizasAvioBindingSource.DataSource = Me.SegurosDS
        '
        'SEG_PolizasAvioTableAdapter
        '
        Me.SEG_PolizasAvioTableAdapter.ClearBeforeFill = True
        '
        'SEGAseguradorasBindingSource
        '
        Me.SEGAseguradorasBindingSource.DataMember = "SEG_Aseguradoras"
        Me.SEGAseguradorasBindingSource.DataSource = Me.SegurosDS
        '
        'BttNew
        '
        Me.BttNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttNew.Location = New System.Drawing.Point(14, 225)
        Me.BttNew.Name = "BttNew"
        Me.BttNew.Size = New System.Drawing.Size(72, 42)
        Me.BttNew.TabIndex = 108
        Me.BttNew.Text = "Nuevo"
        Me.BttNew.UseVisualStyleBackColor = True
        '
        'BttMod
        '
        Me.BttMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttMod.Location = New System.Drawing.Point(95, 225)
        Me.BttMod.Name = "BttMod"
        Me.BttMod.Size = New System.Drawing.Size(72, 42)
        Me.BttMod.TabIndex = 109
        Me.BttMod.Text = "Modificar"
        Me.BttMod.UseVisualStyleBackColor = True
        '
        'BttSave
        '
        Me.BttSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttSave.Location = New System.Drawing.Point(176, 225)
        Me.BttSave.Name = "BttSave"
        Me.BttSave.Size = New System.Drawing.Size(72, 42)
        Me.BttSave.TabIndex = 110
        Me.BttSave.Text = "Guardar"
        Me.BttSave.UseVisualStyleBackColor = True
        '
        'BttCancel
        '
        Me.BttCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttCancel.Location = New System.Drawing.Point(257, 225)
        Me.BttCancel.Name = "BttCancel"
        Me.BttCancel.Size = New System.Drawing.Size(72, 42)
        Me.BttCancel.TabIndex = 111
        Me.BttCancel.Text = "Cancelar"
        Me.BttCancel.UseVisualStyleBackColor = True
        '
        'SEG_AseguradorasTableAdapter
        '
        Me.SEG_AseguradorasTableAdapter.ClearBeforeFill = True
        '
        'BttDel
        '
        Me.BttDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttDel.Location = New System.Drawing.Point(338, 225)
        Me.BttDel.Name = "BttDel"
        Me.BttDel.Size = New System.Drawing.Size(72, 42)
        Me.BttDel.TabIndex = 112
        Me.BttDel.Text = "Eliminar"
        Me.BttDel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(419, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 42)
        Me.Button1.TabIndex = 113
        Me.Button1.Text = "Alta de Superficies"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupDatos
        '
        Me.GroupDatos.Controls.Add(Me.TxtDiff)
        Me.GroupDatos.Controls.Add(Me.Label15)
        Me.GroupDatos.Controls.Add(Me.TxtSinCont)
        Me.GroupDatos.Controls.Add(Me.Label14)
        Me.GroupDatos.Controls.Add(Me.TxtConCont)
        Me.GroupDatos.Controls.Add(Me.Label13)
        Me.GroupDatos.Controls.Add(Me.Txtsuper)
        Me.GroupDatos.Controls.Add(Me.Label12)
        Me.GroupDatos.Controls.Add(Me.DTpag)
        Me.GroupDatos.Controls.Add(Me.DtFin)
        Me.GroupDatos.Controls.Add(Me.Label10)
        Me.GroupDatos.Controls.Add(Me.Label5)
        Me.GroupDatos.Controls.Add(Me.TxtPrima)
        Me.GroupDatos.Controls.Add(Me.Label11)
        Me.GroupDatos.Controls.Add(Me.DTini)
        Me.GroupDatos.Controls.Add(Me.DTpol)
        Me.GroupDatos.Controls.Add(Me.TxtSumaAseg)
        Me.GroupDatos.Controls.Add(Me.Txtcuota)
        Me.GroupDatos.Controls.Add(Me.CmbAseg)
        Me.GroupDatos.Controls.Add(Me.CmbCultivo)
        Me.GroupDatos.Controls.Add(Me.TxtPol)
        Me.GroupDatos.Controls.Add(Me.Label9)
        Me.GroupDatos.Controls.Add(Me.Label8)
        Me.GroupDatos.Controls.Add(Me.Label7)
        Me.GroupDatos.Controls.Add(Me.Label6)
        Me.GroupDatos.Controls.Add(Me.Label4)
        Me.GroupDatos.Controls.Add(Me.Label3)
        Me.GroupDatos.Controls.Add(Me.Label2)
        Me.GroupDatos.Location = New System.Drawing.Point(15, 62)
        Me.GroupDatos.Name = "GroupDatos"
        Me.GroupDatos.Size = New System.Drawing.Size(653, 157)
        Me.GroupDatos.TabIndex = 94
        Me.GroupDatos.TabStop = False
        Me.GroupDatos.Text = "Datos de la Poliza"
        '
        'TxtDiff
        '
        Me.TxtDiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiff.ForeColor = System.Drawing.Color.Black
        Me.TxtDiff.Location = New System.Drawing.Point(521, 126)
        Me.TxtDiff.Name = "TxtDiff"
        Me.TxtDiff.ReadOnly = True
        Me.TxtDiff.Size = New System.Drawing.Size(120, 21)
        Me.TxtDiff.TabIndex = 199
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(518, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 118
        Me.Label15.Text = "Diferencias"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtSinCont
        '
        Me.TxtSinCont.Location = New System.Drawing.Point(395, 126)
        Me.TxtSinCont.Name = "TxtSinCont"
        Me.TxtSinCont.ReadOnly = True
        Me.TxtSinCont.Size = New System.Drawing.Size(120, 20)
        Me.TxtSinCont.TabIndex = 199
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(392, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 13)
        Me.Label14.TabIndex = 116
        Me.Label14.Text = "Sup. sin Contratos"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtConCont
        '
        Me.TxtConCont.Location = New System.Drawing.Point(269, 126)
        Me.TxtConCont.Name = "TxtConCont"
        Me.TxtConCont.ReadOnly = True
        Me.TxtConCont.Size = New System.Drawing.Size(120, 20)
        Me.TxtConCont.TabIndex = 199
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(266, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "Sup. con Contratos"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txtsuper
        '
        Me.Txtsuper.Location = New System.Drawing.Point(143, 126)
        Me.Txtsuper.Name = "Txtsuper"
        Me.Txtsuper.Size = New System.Drawing.Size(120, 20)
        Me.Txtsuper.TabIndex = 107
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(140, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 13)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "Superficie Asegurada"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DTpag
        '
        Me.DTpag.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTpag.Location = New System.Drawing.Point(518, 40)
        Me.DTpag.Name = "DTpag"
        Me.DTpag.Size = New System.Drawing.Size(100, 20)
        Me.DTpag.TabIndex = 102
        '
        'DtFin
        '
        Me.DtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFin.Location = New System.Drawing.Point(407, 40)
        Me.DtFin.Name = "DtFin"
        Me.DtFin.Size = New System.Drawing.Size(100, 20)
        Me.DtFin.TabIndex = 101
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(515, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Fecha de Pago"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(404, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Fecha Termina"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPrima
        '
        Me.TxtPrima.Location = New System.Drawing.Point(17, 126)
        Me.TxtPrima.Name = "TxtPrima"
        Me.TxtPrima.ReadOnly = True
        Me.TxtPrima.Size = New System.Drawing.Size(120, 20)
        Me.TxtPrima.TabIndex = 199
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "Prima"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DTini
        '
        Me.DTini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTini.Location = New System.Drawing.Point(299, 41)
        Me.DTini.Name = "DTini"
        Me.DTini.Size = New System.Drawing.Size(100, 20)
        Me.DTini.TabIndex = 100
        '
        'DTpol
        '
        Me.DTpol.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTpol.Location = New System.Drawing.Point(188, 42)
        Me.DTpol.Name = "DTpol"
        Me.DTpol.Size = New System.Drawing.Size(100, 20)
        Me.DTpol.TabIndex = 99
        '
        'TxtSumaAseg
        '
        Me.TxtSumaAseg.Location = New System.Drawing.Point(528, 84)
        Me.TxtSumaAseg.Name = "TxtSumaAseg"
        Me.TxtSumaAseg.Size = New System.Drawing.Size(120, 20)
        Me.TxtSumaAseg.TabIndex = 106
        '
        'Txtcuota
        '
        Me.Txtcuota.Location = New System.Drawing.Point(410, 84)
        Me.Txtcuota.Name = "Txtcuota"
        Me.Txtcuota.Size = New System.Drawing.Size(100, 20)
        Me.Txtcuota.TabIndex = 105
        '
        'CmbAseg
        '
        Me.CmbAseg.DataSource = Me.SEGAseguradorasBindingSource
        Me.CmbAseg.DisplayMember = "Aseguradora"
        Me.CmbAseg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAseg.FormattingEnabled = True
        Me.CmbAseg.Location = New System.Drawing.Point(123, 84)
        Me.CmbAseg.Name = "CmbAseg"
        Me.CmbAseg.Size = New System.Drawing.Size(281, 21)
        Me.CmbAseg.TabIndex = 104
        Me.CmbAseg.ValueMember = "IdAseguradora"
        '
        'CmbCultivo
        '
        Me.CmbCultivo.DataSource = Me.SEGCultivosBindingSource
        Me.CmbCultivo.DisplayMember = "TitCombo"
        Me.CmbCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCultivo.FormattingEnabled = True
        Me.CmbCultivo.Location = New System.Drawing.Point(17, 85)
        Me.CmbCultivo.Name = "CmbCultivo"
        Me.CmbCultivo.Size = New System.Drawing.Size(100, 21)
        Me.CmbCultivo.TabIndex = 103
        Me.CmbCultivo.ValueMember = "idCultivo"
        '
        'SEGCultivosBindingSource
        '
        Me.SEGCultivosBindingSource.DataMember = "GEN_Cultivos"
        Me.SEGCultivosBindingSource.DataSource = Me.SegurosDS
        '
        'TxtPol
        '
        Me.TxtPol.Location = New System.Drawing.Point(20, 41)
        Me.TxtPol.MaxLength = 25
        Me.TxtPol.Name = "TxtPol"
        Me.TxtPol.Size = New System.Drawing.Size(157, 20)
        Me.TxtPol.TabIndex = 98
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(525, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "Suma Asegurada"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(407, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Cuota"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Aseguradora"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Cultivo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Fecha Inicia"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(187, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Fecha Poliza"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Poliza"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BttSiniestros
        '
        Me.BttSiniestros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttSiniestros.Location = New System.Drawing.Point(497, 225)
        Me.BttSiniestros.Name = "BttSiniestros"
        Me.BttSiniestros.Size = New System.Drawing.Size(72, 42)
        Me.BttSiniestros.TabIndex = 114
        Me.BttSiniestros.Text = "Siniestros y  Devol."
        Me.BttSiniestros.UseVisualStyleBackColor = True
        '
        'GEN_CultivosTableAdapter
        '
        Me.GEN_CultivosTableAdapter.ClearBeforeFill = True
        '
        'BttCatalogos
        '
        Me.BttCatalogos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttCatalogos.Location = New System.Drawing.Point(575, 225)
        Me.BttCatalogos.Name = "BttCatalogos"
        Me.BttCatalogos.Size = New System.Drawing.Size(72, 42)
        Me.BttCatalogos.TabIndex = 115
        Me.BttCatalogos.Text = "Catalogos"
        Me.BttCatalogos.UseVisualStyleBackColor = True
        '
        'FrmAltaPolizaAvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 275)
        Me.Controls.Add(Me.BttCatalogos)
        Me.Controls.Add(Me.BttSiniestros)
        Me.Controls.Add(Me.GroupDatos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BttDel)
        Me.Controls.Add(Me.BttCancel)
        Me.Controls.Add(Me.BttSave)
        Me.Controls.Add(Me.BttMod)
        Me.Controls.Add(Me.BttNew)
        Me.Controls.Add(Me.CmbPol)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbCiclo)
        Me.Controls.Add(Me.lblNumc)
        Me.Name = "FrmAltaPolizaAvio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Poliza de Avio"
        CType(Me.CiclosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegurosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGPolizasAvioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGAseguradorasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDatos.ResumeLayout(False)
        Me.GroupDatos.PerformLayout()
        CType(Me.SEGCultivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNumc As System.Windows.Forms.Label
    Friend WithEvents CmbCiclo As System.Windows.Forms.ComboBox
    Friend WithEvents SegurosDS As Agil.SegurosDS
    Friend WithEvents CiclosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CiclosTableAdapter As Agil.SegurosDSTableAdapters.CiclosTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbPol As System.Windows.Forms.ComboBox
    Friend WithEvents SEGPolizasAvioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEG_PolizasAvioTableAdapter As Agil.SegurosDSTableAdapters.SEG_PolizasAvioTableAdapter
    Friend WithEvents BttNew As System.Windows.Forms.Button
    Friend WithEvents BttMod As System.Windows.Forms.Button
    Friend WithEvents BttSave As System.Windows.Forms.Button
    Friend WithEvents BttCancel As System.Windows.Forms.Button
    Friend WithEvents SEGAseguradorasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEG_AseguradorasTableAdapter As Agil.SegurosDSTableAdapters.SEG_AseguradorasTableAdapter
    Friend WithEvents BttDel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupDatos As System.Windows.Forms.GroupBox
    Friend WithEvents DTpag As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPrima As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DTini As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTpol As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtSumaAseg As System.Windows.Forms.TextBox
    Friend WithEvents Txtcuota As System.Windows.Forms.TextBox
    Friend WithEvents CmbAseg As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCultivo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPol As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BttSiniestros As System.Windows.Forms.Button
    Friend WithEvents Txtsuper As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SEGCultivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GEN_CultivosTableAdapter As Agil.SegurosDSTableAdapters.GEN_CultivosTableAdapter
    Friend WithEvents BttCatalogos As System.Windows.Forms.Button
    Friend WithEvents TxtSinCont As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtConCont As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtDiff As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
