Option Explicit On 

Imports System.Data.SqlClient

Public Class frmAltaClie

    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescr As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFisica As System.Windows.Forms.RadioButton
    Friend WithEvents rbMoral As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFecha1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mtxtRfc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbSucursales As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtxtCURP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbGenero As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFiel As System.Windows.Forms.TextBox
    Friend WithEvents txtNacion As System.Windows.Forms.TextBox
    Friend WithEvents txtPaisNac As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtVentas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CmbPromo As System.Windows.Forms.ComboBox
    Friend WithEvents GeneralDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDS As Agil.GeneralDS
    Friend WithEvents PromotoresActivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PromotoresActivosTableAdapter As Agil.GeneralDSTableAdapters.PromotoresActivosTableAdapter
    Friend WithEvents rbEmpresarial As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CmbPromo = New System.Windows.Forms.ComboBox
        Me.PromotoresActivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtVentas = New System.Windows.Forms.TextBox
        Me.txtFiel = New System.Windows.Forms.TextBox
        Me.txtNacion = New System.Windows.Forms.TextBox
        Me.txtPaisNac = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbGenero = New System.Windows.Forms.ComboBox
        Me.mtxtCURP = New System.Windows.Forms.MaskedTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbSucursales = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.mtxtRfc = New System.Windows.Forms.MaskedTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.lblFecha1 = New System.Windows.Forms.Label
        Me.rbFisica = New System.Windows.Forms.RadioButton
        Me.rbMoral = New System.Windows.Forms.RadioButton
        Me.rbEmpresarial = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDescr = New System.Windows.Forms.TextBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.PromotoresActivosTableAdapter = New Agil.GeneralDSTableAdapters.PromotoresActivosTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.PromotoresActivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CmbPromo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtVentas)
        Me.GroupBox1.Controls.Add(Me.txtFiel)
        Me.GroupBox1.Controls.Add(Me.txtNacion)
        Me.GroupBox1.Controls.Add(Me.txtPaisNac)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbGenero)
        Me.GroupBox1.Controls.Add(Me.mtxtCURP)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbSucursales)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mtxtRfc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtpFecha1)
        Me.GroupBox1.Controls.Add(Me.lblFecha1)
        Me.GroupBox1.Controls.Add(Me.rbFisica)
        Me.GroupBox1.Controls.Add(Me.rbMoral)
        Me.GroupBox1.Controls.Add(Me.rbEmpresarial)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 246)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(236, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Promotor"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbPromo
        '
        Me.CmbPromo.DataSource = Me.PromotoresActivosBindingSource
        Me.CmbPromo.DisplayMember = "DescPromotor"
        Me.CmbPromo.FormattingEnabled = True
        Me.CmbPromo.Location = New System.Drawing.Point(239, 202)
        Me.CmbPromo.Name = "CmbPromo"
        Me.CmbPromo.Size = New System.Drawing.Size(252, 21)
        Me.CmbPromo.TabIndex = 14
        Me.CmbPromo.ValueMember = "Promotor"
        '
        'PromotoresActivosBindingSource
        '
        Me.PromotoresActivosBindingSource.DataMember = "PromotoresActivos"
        Me.PromotoresActivosBindingSource.DataSource = Me.GeneralDSBindingSource
        '
        'GeneralDSBindingSource
        '
        Me.GeneralDSBindingSource.DataSource = Me.GeneralDS
        Me.GeneralDSBindingSource.Position = 0
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(125, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Ventas Anuales"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVentas
        '
        Me.txtVentas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVentas.Enabled = False
        Me.txtVentas.Location = New System.Drawing.Point(128, 202)
        Me.txtVentas.Name = "txtVentas"
        Me.txtVentas.Size = New System.Drawing.Size(105, 20)
        Me.txtVentas.TabIndex = 13
        Me.txtVentas.TabStop = False
        '
        'txtFiel
        '
        Me.txtFiel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiel.Enabled = False
        Me.txtFiel.Location = New System.Drawing.Point(339, 154)
        Me.txtFiel.Name = "txtFiel"
        Me.txtFiel.Size = New System.Drawing.Size(152, 20)
        Me.txtFiel.TabIndex = 11
        Me.txtFiel.TabStop = False
        '
        'txtNacion
        '
        Me.txtNacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNacion.Enabled = False
        Me.txtNacion.Location = New System.Drawing.Point(179, 154)
        Me.txtNacion.Name = "txtNacion"
        Me.txtNacion.Size = New System.Drawing.Size(152, 20)
        Me.txtNacion.TabIndex = 10
        Me.txtNacion.TabStop = False
        '
        'txtPaisNac
        '
        Me.txtPaisNac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaisNac.Enabled = False
        Me.txtPaisNac.Location = New System.Drawing.Point(19, 154)
        Me.txtPaisNac.Name = "txtPaisNac"
        Me.txtPaisNac.Size = New System.Drawing.Size(152, 20)
        Me.txtPaisNac.TabIndex = 9
        Me.txtPaisNac.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Genero"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(339, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Serie Fiel"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(181, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Nacionalidad"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Pais de Nacimiento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbGenero
        '
        Me.cbGenero.Enabled = False
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Items.AddRange(New Object() {"Masculino", "Femenino", "No Aplica", "   "})
        Me.cbGenero.Location = New System.Drawing.Point(20, 202)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(94, 21)
        Me.cbGenero.TabIndex = 12
        '
        'mtxtCURP
        '
        Me.mtxtCURP.BeepOnError = True
        Me.mtxtCURP.Enabled = False
        Me.mtxtCURP.Location = New System.Drawing.Point(169, 104)
        Me.mtxtCURP.Name = "mtxtCURP"
        Me.mtxtCURP.Size = New System.Drawing.Size(128, 20)
        Me.mtxtCURP.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(166, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "CURP"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cbSucursales
        '
        Me.cbSucursales.FormattingEnabled = True
        Me.cbSucursales.Location = New System.Drawing.Point(337, 104)
        Me.cbSucursales.Name = "cbSucursales"
        Me.cbSucursales.Size = New System.Drawing.Size(142, 21)
        Me.cbSucursales.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(338, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Sucursal que lo atenderá"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mtxtRfc
        '
        Me.mtxtRfc.BeepOnError = True
        Me.mtxtRfc.Location = New System.Drawing.Point(20, 105)
        Me.mtxtRfc.Name = "mtxtRfc"
        Me.mtxtRfc.Size = New System.Drawing.Size(94, 20)
        Me.mtxtRfc.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(17, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "R.F.C."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(208, 59)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha1.TabIndex = 60
        '
        'lblFecha1
        '
        Me.lblFecha1.Location = New System.Drawing.Point(16, 60)
        Me.lblFecha1.Name = "lblFecha1"
        Me.lblFecha1.Size = New System.Drawing.Size(187, 16)
        Me.lblFecha1.TabIndex = 59
        Me.lblFecha1.Text = "Fecha de Nacimiento o Constitución"
        Me.lblFecha1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'rbFisica
        '
        Me.rbFisica.Location = New System.Drawing.Point(16, 24)
        Me.rbFisica.Name = "rbFisica"
        Me.rbFisica.Size = New System.Drawing.Size(112, 16)
        Me.rbFisica.TabIndex = 2
        Me.rbFisica.Text = "Persona Física"
        '
        'rbMoral
        '
        Me.rbMoral.Location = New System.Drawing.Point(364, 24)
        Me.rbMoral.Name = "rbMoral"
        Me.rbMoral.Size = New System.Drawing.Size(99, 16)
        Me.rbMoral.TabIndex = 4
        Me.rbMoral.Text = "Persona Moral"
        '
        'rbEmpresarial
        '
        Me.rbEmpresarial.Location = New System.Drawing.Point(128, 20)
        Me.rbEmpresarial.Name = "rbEmpresarial"
        Me.rbEmpresarial.Size = New System.Drawing.Size(248, 24)
        Me.rbEmpresarial.TabIndex = 3
        Me.rbEmpresarial.Text = "Persona Física con Actividad Empresarial"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Antes de dar de alta a un cliente, asegurarse que no está dado de alta"
        '
        'txtDescr
        '
        Me.txtDescr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescr.Location = New System.Drawing.Point(16, 104)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(504, 20)
        Me.txtDescr.TabIndex = 1
        Me.txtDescr.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(420, 406)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 32)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(260, 406)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(96, 32)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Nombre o Razón Social del Cliente"
        '
        'PromotoresActivosTableAdapter
        '
        Me.PromotoresActivosTableAdapter.ClearBeforeFill = True
        '
        'frmAltaClie
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(538, 503)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.txtDescr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAltaClie"
        Me.Text = "Alta de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PromotoresActivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmAltaClie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GeneralDS.PromotoresActivos' table. You can move, or remove it, as needed.
        Me.PromotoresActivosTableAdapter.Fill(Me.GeneralDS.PromotoresActivos)

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daSucursales As New SqlDataAdapter(cm1)

        Dim dsAgil As New DataSet()

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Sucursales ORDER BY ID_Sucursal"
            .Connection = cnAgil
        End With

        Try

            ' Llenar el DataSet lo cual abre y cierra la conexión

            daSucursales.Fill(dsAgil, "Sucursales")

            ' Ligar la tabla Sucursales del dataset dsAgil al ComboBox Sucursales

            cbSucursales.DataSource = dsAgil
            cbSucursales.DisplayMember = "Sucursales.Nombre_Sucursal"
            cbSucursales.ValueMember = "Sucursales.ID_Sucursal"
            cbSucursales.SelectedIndex = 0

        Catch eException As Exception

            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim daNames As New SqlDataAdapter(cm2)

        Dim dsAgil As New DataSet()

        Dim strInsert As String
        Dim strUpdate As String

        ' Declaración de variables de datos

        Dim cCliente As String
        Dim cCadena As String
        Dim cDescr As String
        Dim cFecha As String
        Dim cFechaRFC As String
        Dim cPlaza As String = ""
        Dim cEstado As String = ""
        Dim cSucursal As String
        Dim cGenero As String
        Dim cSegVida As String
        Dim cTipo As String
        Dim lAlta As Boolean
        Dim nCliente As Integer
        Dim nCount As Integer

        ' Este programa debe validar que se haya insertado información en el nombre del cliente, así como que
        ' se haya seleccionado el tipo de cliente.   Adicionalmente deberá convertir a mayúsculas el nombre
        ' del cliente.

        lAlta = True

        cDescr = txtDescr.Text.ToUpper()
        cCadena = Mid(cDescr, 1, 35)

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BuscaName"
            .Connection = cnAgil
            .Parameters.Add("@Cadena", SqlDbType.NVarChar)
            .Parameters(0).Value = cCadena
        End With
        daNames.Fill(dsAgil, "Names")
        nCount = dsAgil.Tables("Names").Rows.Count

        If Trim(txtDescr.Text) = "" Then
            MsgBox("Falta capturar el nombre del cliente", MsgBoxStyle.Critical, "Error de validación")
            lAlta = False
        End If

        If rbFisica.Checked = False And rbEmpresarial.Checked = False And rbMoral.Checked = False Then
            MsgBox("Falta especificar el tipo de cliente", MsgBoxStyle.Critical, "Error de validación")
            lAlta = False
        End If

        If nCount > 0 Then
            MsgBox("Es probable que ya exista este cliente", MsgBoxStyle.Critical, "Error de validación")
            lAlta = False
        End If

        If rbFisica.Checked = True Or rbEmpresarial.Checked = True Then
            cFecha = DTOC(dtpFecha1.Value)
            cFechaRFC = Mid(cFecha, 3, 6)
            If Len(LTrim(mtxtRfc.Text)) = 13 Or Len(LTrim(mtxtRfc.Text)) = 10 Then
                If Mid(mtxtRfc.Text, 5, 6) <> cFechaRFC Then
                    lAlta = False
                    MsgBox("La Fecha del RFC es ERRONEA", MsgBoxStyle.Critical, "Error de validación")
                End If
            ElseIf rbEmpresarial.Checked = True Or Len(LTrim(mtxtRfc.Text)) = 10 Then
                MsgBox("Con este RFC no puede tener Actividad empresarial.", MsgBoxStyle.Critical, "Error de validación")
                lAlta = False
            ElseIf rbEmpresarial.Checked = True And Len(LTrim(mtxtRfc.Text)) = 13 And MID(mtxtRfc.Text, 11, 3) = "000" Then
                MsgBox("Con este RFC no puede tener Actividad empresarial.", MsgBoxStyle.Critical, "Error de validación")
                lAlta = False
            Else
                lAlta = False
                MsgBox("El RFC debe ser de 13 ó 10 caracteres", MsgBoxStyle.Critical, "Error de validación")
            End If

            If Len(LTrim(mtxtCURP.Text)) < 18 Then
                lAlta = False
                MsgBox("La CURP debe tener 18 caracteres", MsgBoxStyle.Critical, "Error de validación")
            End If
            If Trim(txtPaisNac.Text) = "" Or Len(Trim(txtPaisNac.Text)) < 3 Then
                MsgBox("Falta capturar el País de Nacimiento", MsgBoxStyle.Critical, "Error de validación")
                lAlta = False
            End If

            If Trim(txtNacion.Text) = "" Or Len(Trim(txtNacion.Text)) < 3 Then
                MsgBox("Falta capturar la Nacionalidad", MsgBoxStyle.Critical, "Error de validación")
                lAlta = False
            End If

            If Trim(txtFiel.Text) = "" Or Len(Trim(txtFiel.Text)) < 3 Then
                MsgBox("Falta capturar la Serie FIEL", MsgBoxStyle.Critical, "Error de validación")
                lAlta = False
            End If

            If Trim(cbGenero.Text) = "" Then
                MsgBox("Falta capturar el Genero del Cliente", MsgBoxStyle.Critical, "Error de validación")
                lAlta = False
            End If
        ElseIf rbMoral.Checked = True Then

            cFechaRFC = Mid(mtxtRfc.Text, 4, 6)

            If Year(dtpFecha1.Value) >= 2000 Then
                cFecha = "20" & Mid(cFechaRFC, 1, 2) & Mid(cFechaRFC, 3, 2) & Mid(cFechaRFC, 5, 2)
            Else
                cFecha = "19" & Mid(cFechaRFC, 1, 2) & Mid(cFechaRFC, 3, 2) & Mid(cFechaRFC, 5, 2)
            End If

            If ValidaFecha(cFecha) = False Then
                lAlta = False
                MsgBox("La fecha del RFC es ERRONEA", MsgBoxStyle.Critical, "Error de validación")
            End If

            If Len(LTrim(mtxtRfc.Text)) = 12 Then
                If Not IsDate(CTOD(cFecha)) Then
                    lAlta = False
                    MsgBox("La fecha del RFC es ERRONEA", MsgBoxStyle.Critical, "Error de validación")
                End If
            Else
                lAlta = False
                MsgBox("El RFC debe ser de 12 caracteres", MsgBoxStyle.Critical, "Error de validación")
            End If

        End If

        If lAlta = True Then

            txtDescr.Enabled = False
            GroupBox1.Enabled = False
            btnActualizar.Enabled = False

            ' Una vez hechas las validaciones y la conversión a mayúsculas, procedo a darlo de alta en la tabla Clientes

            If rbFisica.Checked = True Then
                cTipo = "F"
            ElseIf rbEmpresarial.Checked = True Then
                cTipo = "E"
            ElseIf rbMoral.Checked = True Then
                cTipo = "M"
            End If

            cSegVida = "N"
            If cTipo <> "M" Then
                cSegVida = "S"
            End If

            cSucursal = cbSucursales.SelectedValue
            cGenero = cbGenero.SelectedValue
       
            With cm1
                .CommandType = CommandType.Text
                .CommandText = "SELECT IDCliente FROM Llaves"
                .Connection = cnAgil
            End With

            With cm3
                .CommandType = CommandType.Text
                .CommandText = "SELECT Plaza_Sucursal FROM Sucursales WHERE ID_Sucursal = '" & cSucursal & "'"
                .Connection = cnAgil
            End With

            Try
                cnAgil.Open()

                cPlaza = cm3.ExecuteScalar()

                With cm4
                    .CommandType = CommandType.Text
                    .CommandText = "SELECT DescSEPOMEX FROM PLAZAS WHERE PLAZA = '" & cPlaza & "'"
                    .Connection = cnAgil
                End With

                cEstado = cm4.ExecuteScalar()

                nCliente = CInt(cm1.ExecuteScalar()) + 1
                If nCliente >= 5000 And nCliente <= 5076 Then
                    nCliente = 5077
                ElseIf nCliente >= 7000 And nCliente <= 7007 Then
                    nCliente = 7008
                ElseIf nCliente >= 8001 And nCliente <= 8362 Then
                    nCliente = 8363
                ElseIf nCliente >= 8501 And nCliente <= 8531 Then
                    nCliente = 8532
                ElseIf nCliente >= 8999 And nCliente <= 9000 Then
                    nCliente = 9001
                End If
                cCliente = Stuff(nCliente.ToString, "I", "0", 5)

                ' Debe insertar un registro en la tabla Clientes

                strInsert = "INSERT INTO Clientes(Cliente, Descr, Tipo, Fecha1, RFC, CURP, Sucursal, Plaza, PaisNacimiento, Nacionalidad, SerieFiel, VentasAnuales, Genero, SegVida, promo, estado, FormadePago1)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & cCliente & "', '"
                strInsert = strInsert & cDescr & "', '"
                strInsert = strInsert & cTipo & "', '"
                strInsert = strInsert & DTOC(dtpFecha1.Value) & "', '"
                strInsert = strInsert & mtxtRfc.Text & "', '"
                strInsert = strInsert & mtxtCURP.Text & "', '"
                strInsert = strInsert & cSucursal & "', '"
                strInsert = strInsert & cPlaza & "', '"
                strInsert = strInsert & Trim(txtPaisNac.Text) & "', '"
                strInsert = strInsert & Trim(txtNacion.Text) & "', '"
                strInsert = strInsert & Trim(txtFiel.Text) & "', '"
                strInsert = strInsert & txtVentas.Text & "', '"
                strInsert = strInsert & cGenero & "', '"
                strInsert = strInsert & cSegVida
                strInsert = strInsert & "','" & CmbPromo.SelectedValue & "','" & cEstado & "','Otros')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()

                ' Debe actualizar el atributo IDCliente de la tabla Llaves

                strUpdate = "UPDATE Llaves SET IDCliente = " & nCliente
                cm1 = New SqlCommand(strUpdate, cnAgil)
                cm1.ExecuteNonQuery()

                cnAgil.Close()

                MsgBox("Cliente dado de Alta", MsgBoxStyle.Information, "Mensaje del Sistema")

                Me.Close()

            Catch eException As Exception
                MsgBox(eException.Message, MsgBoxStyle.Information, "Mensaje de error")
            End Try

        End If

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub rbFisica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFisica.Click
        mtxtRfc.Clear()
        mtxtRfc.TextAlign = HorizontalAlignment.Left
        mtxtRfc.Mask = "????999999AAA"
        mtxtCURP.Enabled = True
        mtxtCURP.Clear()
        mtxtCURP.TextAlign = HorizontalAlignment.Left
        mtxtCURP.Mask = "????999999AAAAAAAA"
        txtPaisNac.Clear()
        txtPaisNac.Enabled = True
        txtNacion.Clear()
        txtNacion.Enabled = True
        txtFiel.Clear()
        txtFiel.Enabled = True
        txtVentas.Text = 0
        txtVentas.Enabled = True
        cbGenero.SelectedIndex = 3
        cbGenero.Enabled = True
    End Sub

    Private Sub rbEmpresarial_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEmpresarial.Click
        mtxtRfc.Clear()
        mtxtRfc.TextAlign = HorizontalAlignment.Left
        mtxtRfc.Mask = "????999999AAA"
        mtxtCURP.Enabled = True
        mtxtCURP.Clear()
        mtxtCURP.TextAlign = HorizontalAlignment.Left
        mtxtCURP.Mask = "????999999AAAAAAAA"
        txtPaisNac.Clear()
        txtPaisNac.Enabled = True
        txtNacion.Clear()
        txtNacion.Enabled = True
        txtFiel.Clear()
        txtFiel.Enabled = True
        txtVentas.Text = 0
        txtVentas.Enabled = True
        cbGenero.SelectedIndex = 3
        cbGenero.Enabled = True
    End Sub

    Private Sub rbMoral_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbMoral.Click
        mtxtRfc.Clear()
        mtxtRfc.TextAlign = HorizontalAlignment.Left
        mtxtRfc.Mask = "???999999AAA"
        mtxtCURP.Enabled = False
        mtxtCURP.Clear()
        txtPaisNac.Clear()
        txtPaisNac.Enabled = False
        txtNacion.Clear()
        txtNacion.Enabled = False
        txtFiel.Clear()
        txtFiel.Enabled = False
        txtVentas.Text = 0
        txtVentas.Enabled = False
        cbGenero.SelectedIndex = 2
        cbGenero.Enabled = False
    End Sub

    Public Function ValidaFecha(ByVal cFecha As String) As Boolean

        Dim nMes As Integer
        Dim nAgno As Integer
        Dim nDia As Integer
        Dim dHoy As Date

        dHoy = Today()

        nMes = Val(Mid(cFecha, 5, 2))
        nAgno = Val(Mid(cFecha, 1, 4))
        nDia = Val(Mid(cFecha, 7, 2))
        ValidaFecha = True

        If CTOD(cFecha) > dHoy Then
            ValidaFecha = False    ' La Fecha no puede ser mayor al día que se está registrando
        End If

        If nAgno < 1900 Or nAgno > Year(Today) Then
            ValidaFecha = False    ' Valido el año 
        End If

        If nMes < 1 Or nMes > 12 Then
            ValidaFecha = False     ' Valido el mes
        End If

        If nDia < 1 Or nDia > 31 Then
            ValidaFecha = False     ' Valido el día
        End If

        If nMes = 4 Or nMes = 6 Or nMes = 9 Or nMes = 11 Then
            If nDia > 30 Then
                ValidaFecha = False
            End If
        End If

        If nMes = 2 Then
            If Leap(nAgno) = 0 And nDia > 28 Then
                ValidaFecha = False
            ElseIf Leap(nAgno) = 1 And nDia > 29 Then
                ValidaFecha = False
            End If
        End If

    End Function

    Private Sub txtFiel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiel.TextChanged

    End Sub
End Class
