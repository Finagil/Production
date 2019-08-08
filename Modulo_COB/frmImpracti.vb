Option Explicit On 

Imports System.Data.SqlClient
Imports System.Math
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO


Public Class frmImpracti

    Inherits System.Windows.Forms.Form

    ' Declaración de variables de datos de alcance privado

    Dim cAnexo As String
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtNamerep As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Dim nNumero As Decimal
    Dim nPorInt As Decimal
    Dim dsAgil1 As New DataSet()
    Dim cCuentaPago As String
    Dim cFormaPago As String
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents txtEMail As System.Windows.Forms.TextBox
    Friend WithEvents TxtIvaOpcion As System.Windows.Forms.TextBox
    Friend WithEvents CmbInstruMon As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GeneralDS As GeneralDS
    Friend WithEvents InstrumentoMonetarioBindingSource As BindingSource
    Friend WithEvents InstrumentoMonetarioTableAdapter As GeneralDSTableAdapters.InstrumentoMonetarioTableAdapter
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Txtunidad As TextBox
    Friend WithEvents TxtUsoCFDI As TextBox
    Friend WithEvents TxtDesc As TextBox
    Dim cCliente As String


#Region " Windows Form Designer generated code "

    Public Sub New(ByVal cAnexo As String)

        MyBase.New()

        'This call is required by the Windows Form Designer.

        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        txtAnexo.Text = cAnexo

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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtRfc As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtCol As System.Windows.Forms.TextBox
    Friend WithEvents txtCp As System.Windows.Forms.TextBox
    Friend WithEvents txtDeleg As System.Windows.Forms.TextBox
    Friend WithEvents txtEdo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtFacturaActivo As System.Windows.Forms.TextBox
    Friend WithEvents lblFacturaActivo As System.Windows.Forms.Label
    Friend WithEvents txtOpcion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtAnexo = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtCol = New System.Windows.Forms.TextBox()
        Me.txtCp = New System.Windows.Forms.TextBox()
        Me.txtDeleg = New System.Windows.Forms.TextBox()
        Me.txtEdo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.txtFacturaActivo = New System.Windows.Forms.TextBox()
        Me.lblFacturaActivo = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtNamerep = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.TxtIvaOpcion = New System.Windows.Forms.TextBox()
        Me.CmbInstruMon = New System.Windows.Forms.ComboBox()
        Me.InstrumentoMonetarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDS = New Agil.GeneralDS()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.InstrumentoMonetarioTableAdapter = New Agil.GeneralDSTableAdapters.InstrumentoMonetarioTableAdapter()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Txtunidad = New System.Windows.Forms.TextBox()
        Me.TxtUsoCFDI = New System.Windows.Forms.TextBox()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        CType(Me.InstrumentoMonetarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(24, 16)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(472, 160)
        Me.ListBox1.TabIndex = 12
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(520, 64)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(136, 23)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(520, 392)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(136, 23)
        Me.btnImprimir.TabIndex = 17
        Me.btnImprimir.Text = "Imprimir Factura"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(520, 24)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(136, 23)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Text = "Modificar Datos"
        '
        'txtAnexo
        '
        Me.txtAnexo.Location = New System.Drawing.Point(632, 184)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.Size = New System.Drawing.Size(8, 21)
        Me.txtAnexo.TabIndex = 19
        Me.txtAnexo.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(128, 224)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(520, 21)
        Me.txtName.TabIndex = 20
        '
        'txtRfc
        '
        Me.txtRfc.Location = New System.Drawing.Point(128, 248)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.ReadOnly = True
        Me.txtRfc.Size = New System.Drawing.Size(144, 21)
        Me.txtRfc.TabIndex = 21
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(128, 272)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.ReadOnly = True
        Me.txtCalle.Size = New System.Drawing.Size(520, 21)
        Me.txtCalle.TabIndex = 22
        '
        'txtCol
        '
        Me.txtCol.Location = New System.Drawing.Point(128, 296)
        Me.txtCol.Name = "txtCol"
        Me.txtCol.ReadOnly = True
        Me.txtCol.Size = New System.Drawing.Size(296, 21)
        Me.txtCol.TabIndex = 23
        '
        'txtCp
        '
        Me.txtCp.Location = New System.Drawing.Point(536, 296)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.ReadOnly = True
        Me.txtCp.Size = New System.Drawing.Size(112, 21)
        Me.txtCp.TabIndex = 24
        '
        'txtDeleg
        '
        Me.txtDeleg.Location = New System.Drawing.Point(128, 320)
        Me.txtDeleg.Name = "txtDeleg"
        Me.txtDeleg.ReadOnly = True
        Me.txtDeleg.Size = New System.Drawing.Size(352, 21)
        Me.txtDeleg.TabIndex = 25
        '
        'txtEdo
        '
        Me.txtEdo.Location = New System.Drawing.Point(128, 344)
        Me.txtEdo.Name = "txtEdo"
        Me.txtEdo.ReadOnly = True
        Me.txtEdo.Size = New System.Drawing.Size(352, 21)
        Me.txtEdo.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "R.F.C."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Calle"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Colonia"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(496, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "C.P."
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Delegación"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(24, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Estado"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Datos para facturar"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(616, 184)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(8, 21)
        Me.txtImporte.TabIndex = 35
        Me.txtImporte.Visible = False
        '
        'txtOpcion
        '
        Me.txtOpcion.Location = New System.Drawing.Point(600, 184)
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.Size = New System.Drawing.Size(8, 21)
        Me.txtOpcion.TabIndex = 36
        Me.txtOpcion.Visible = False
        '
        'txtFacturaActivo
        '
        Me.txtFacturaActivo.Location = New System.Drawing.Point(264, 397)
        Me.txtFacturaActivo.Name = "txtFacturaActivo"
        Me.txtFacturaActivo.Size = New System.Drawing.Size(100, 21)
        Me.txtFacturaActivo.TabIndex = 37
        Me.txtFacturaActivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFacturaActivo
        '
        Me.lblFacturaActivo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacturaActivo.Location = New System.Drawing.Point(25, 398)
        Me.lblFacturaActivo.Name = "lblFacturaActivo"
        Me.lblFacturaActivo.Size = New System.Drawing.Size(233, 13)
        Me.lblFacturaActivo.TabIndex = 38
        Me.lblFacturaActivo.Text = "Factura de Activo Fijo a Imprimir"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(572, 184)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(8, 21)
        Me.txtTipo.TabIndex = 39
        Me.txtTipo.Visible = False
        '
        'txtNamerep
        '
        Me.txtNamerep.Location = New System.Drawing.Point(586, 184)
        Me.txtNamerep.Name = "txtNamerep"
        Me.txtNamerep.Size = New System.Drawing.Size(8, 21)
        Me.txtNamerep.TabIndex = 40
        Me.txtNamerep.Visible = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(520, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.TabStop = False
        Me.Button1.Text = "Carta Responsiva"
        '
        'btnGenerar
        '
        Me.btnGenerar.Enabled = False
        Me.btnGenerar.Location = New System.Drawing.Point(520, 365)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(136, 23)
        Me.btnGenerar.TabIndex = 42
        Me.btnGenerar.Text = "Genera Fact. Elect."
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(558, 184)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(8, 21)
        Me.txtEMail.TabIndex = 43
        Me.txtEMail.Visible = False
        '
        'TxtIvaOpcion
        '
        Me.TxtIvaOpcion.Location = New System.Drawing.Point(646, 184)
        Me.TxtIvaOpcion.Name = "TxtIvaOpcion"
        Me.TxtIvaOpcion.Size = New System.Drawing.Size(8, 21)
        Me.TxtIvaOpcion.TabIndex = 44
        Me.TxtIvaOpcion.Visible = False
        '
        'CmbInstruMon
        '
        Me.CmbInstruMon.DataSource = Me.InstrumentoMonetarioBindingSource
        Me.CmbInstruMon.DisplayMember = "Titulo"
        Me.CmbInstruMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbInstruMon.FormattingEnabled = True
        Me.CmbInstruMon.Location = New System.Drawing.Point(27, 433)
        Me.CmbInstruMon.Name = "CmbInstruMon"
        Me.CmbInstruMon.Size = New System.Drawing.Size(251, 21)
        Me.CmbInstruMon.TabIndex = 135
        Me.CmbInstruMon.ValueMember = "Clave"
        '
        'InstrumentoMonetarioBindingSource
        '
        Me.InstrumentoMonetarioBindingSource.DataMember = "InstrumentoMonetario"
        Me.InstrumentoMonetarioBindingSource.DataSource = Me.GeneralDS
        '
        'GeneralDS
        '
        Me.GeneralDS.DataSetName = "GeneralDS"
        Me.GeneralDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 417)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 13)
        Me.Label9.TabIndex = 134
        Me.Label9.Text = "Instrumento Monetario"
        '
        'InstrumentoMonetarioTableAdapter
        '
        Me.InstrumentoMonetarioTableAdapter.ClearBeforeFill = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(25, 370)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 136
        Me.Label10.Text = "Datos CFDI"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(300, 371)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(94, 21)
        Me.TxtCodigo.TabIndex = 137
        '
        'Txtunidad
        '
        Me.Txtunidad.Location = New System.Drawing.Point(400, 371)
        Me.Txtunidad.Name = "Txtunidad"
        Me.Txtunidad.ReadOnly = True
        Me.Txtunidad.Size = New System.Drawing.Size(37, 21)
        Me.Txtunidad.TabIndex = 138
        '
        'TxtUsoCFDI
        '
        Me.TxtUsoCFDI.Location = New System.Drawing.Point(443, 370)
        Me.TxtUsoCFDI.Name = "TxtUsoCFDI"
        Me.TxtUsoCFDI.ReadOnly = True
        Me.TxtUsoCFDI.Size = New System.Drawing.Size(37, 21)
        Me.TxtUsoCFDI.TabIndex = 139
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(128, 370)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.ReadOnly = True
        Me.TxtDesc.Size = New System.Drawing.Size(166, 21)
        Me.TxtDesc.TabIndex = 140
        '
        'frmImpracti
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(680, 466)
        Me.Controls.Add(Me.TxtDesc)
        Me.Controls.Add(Me.TxtUsoCFDI)
        Me.Controls.Add(Me.Txtunidad)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CmbInstruMon)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtIvaOpcion)
        Me.Controls.Add(Me.txtEMail)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNamerep)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.lblFacturaActivo)
        Me.Controls.Add(Me.txtFacturaActivo)
        Me.Controls.Add(Me.txtOpcion)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEdo)
        Me.Controls.Add(Me.txtDeleg)
        Me.Controls.Add(Me.txtCp)
        Me.Controls.Add(Me.txtCol)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtRfc)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtAnexo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmImpracti"
        Me.Text = "Impresión de la Factura de Activo Fijo"
        CType(Me.InstrumentoMonetarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmImpracti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.InstrumentoMonetarioTableAdapter.Fill(Me.GeneralDS.InstrumentoMonetario)
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim drActifijo As DataRow
        Dim drCliente As DataRow
        Dim drDatoActifij As DataRowCollection
        Dim daActifijo As New SqlDataAdapter(cm1)
        Dim daCliente As New SqlDataAdapter(cm2)

        ' Declaración de variables de datos

        Dim cFactura As String
        Dim cProveed As String
        Dim cImporte As String
        Dim cFactact As String
        Dim cIndice As String
        Dim nFactact As Decimal
        Dim nImporte As Decimal
        Dim nProximo As Integer
        Dim nCounter As Integer
        Dim i As Integer

        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 10)

        ' Este Stored Procedure trae los datos de TODOS los bienes de un contrato dado del archivo Actifijo

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DatosEquipo1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
        End With

        ' Trae los datos del cliente para el contrato que se va a imprimir su factura de activo fijo

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Actifijo3"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
        End With

        ' Trae el número consecutivo de facturas de activo fijo

        With cm3
            .CommandType = CommandType.Text
            .CommandText = "SELECT ConInv FROM Llaves"
            .Connection = cnAgil
        End With

        ' Incrementa en uno el número de factura de activo fijo

        cnAgil.Open()
        nNumero = CInt(cm3.ExecuteScalar()) + 1
        cnAgil.Close()

        txtFacturaActivo.Text = nNumero.ToString

        Try

            'Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

            daActifijo.Fill(dsAgil, "ActiFijo")
            daCliente.Fill(dsAgil, "Cliente")

            drDatoActifij = dsAgil.Tables("ActiFijo").Rows      ' Contiene n bienes
            drCliente = dsAgil.Tables("Cliente").Rows(0)          ' Contiene 1 registro con los datos del cliente

            nCounter = dsAgil.Tables("Actifijo").Rows.Count

            If nCounter = 0 Then
                MessageBox.Show("Contrato sin Activo Fijo capturado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

            If Not drCliente("Opcion") Is System.DBNull.Value Then

                If drCliente("Pagado") = "N" Then
                    MessageBox.Show("Opción de Compra NO pagada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Exit Sub
                End If

                ListBox1.Items.Clear()

                nProximo = 0
                nImporte = 0
                For Each drActifijo In drDatoActifij
                    cIndice = nProximo.ToString
                    cFactura = drActifijo("Factura")
                    cProveed = Mid(drActifijo("Proveedor"), 1, 35)
                    cImporte = FormatNumber(drActifijo("Importe")).ToString
                    nFactact = drActifijo("FactFij")
                    cFactact = nFactact.ToString
                    nImporte += drActifijo("Importe")
                    ListBox1.Items.Add(cIndice & " " & cFactura & " " & cProveed & " " & cImporte & "   " & cFactact)
                    nProximo += 1
                    If Not IsDBNull(drActifijo("Descripcion")) Then TxtDesc.Text = drActifijo("Descripcion")
                    If Not IsDBNull(drActifijo("CodigoSAT")) Then TxtCodigo.Text = drActifijo("CodigoSAT")
                    If Not IsDBNull(drActifijo("Unidad")) Then Txtunidad.Text = drActifijo("Unidad")
                    If Not IsDBNull(drActifijo("UsoCFDI")) Then TxtUsoCFDI.Text = drActifijo("UsoCFDI")
                Next

                txtName.Text = drCliente("Descr")
                txtRfc.Text = drCliente("RFC")
                txtCalle.Text = drCliente("Calle")
                txtCol.Text = drCliente("Colonia")
                txtCp.Text = drCliente("Copos")
                txtDeleg.Text = drCliente("Delegacion")
                txtEdo.Text = drCliente("Descplaza")
                txtImporte.Text = nImporte
                txtOpcion.Text = drCliente("Opcion")
                TxtIvaOpcion.Text = drCliente("IVAOpcion")
                txtTipo.Text = drCliente("Tipo")
                txtNamerep.Text = drCliente("Nomrepr")
                txtEMail.Text = drCliente("EMail1")
                nPorInt = drCliente("PorInt")
                cCliente = drCliente("Cliente")

                For i = 1 To 5
                    Select Case i
                        Case 1
                            If RTrim(drCliente("CuentadePago1")) <> "0" And RTrim(drCliente("FormadePago1")) <> "EFECTIVO" Then
                                cCuentaPago = drCliente("CuentadePago1")
                                cFormaPago = RTrim(drCliente("FormadePago1"))
                            ElseIf RTrim(drCliente("CuentadePago1")) = "0" And RTrim(drCliente("FormadePago1")) = "EFECTIVO" Then
                                cCuentaPago = "NO IDENTIFICABLE"
                                cFormaPago = RTrim(drCliente("FormadePago1"))
                            End If
                        Case 2
                            If RTrim(drCliente("CuentadePago2")) <> "0" And RTrim(drCliente("FormadePago2")) <> "EFECTIVO" Then
                                cCuentaPago = cCuentaPago & "," & drCliente("CuentadePago2")
                                cFormaPago = cFormaPago & "," & RTrim(drCliente("FormadePago2"))
                            ElseIf RTrim(drCliente("CuentadePago2")) = "0" And RTrim(drCliente("FormadePago2")) = "EFECTIVO" Then
                                cCuentaPago = cCuentaPago & "," & "NO IDENTIFICABLE"
                                cFormaPago = cFormaPago & "," & RTrim(drCliente("FormadePago2"))
                            End If
                        Case 3
                            If RTrim(drCliente("CuentadePago3")) <> "0" And RTrim(drCliente("FormadePago3")) <> "EFECTIVO" Then
                                cCuentaPago = cCuentaPago & "," & drCliente("CuentadePago3")
                                cFormaPago = cFormaPago & "," & RTrim(drCliente("FormadePago3"))
                            ElseIf RTrim(drCliente("CuentadePago3")) = "0" And RTrim(drCliente("FormadePago3")) = "EFECTIVO" Then
                                cCuentaPago = cCuentaPago & "," & "NO IDENTIFICABLE"
                                cFormaPago = cFormaPago & "," & RTrim(drCliente("FormadePago3"))
                            End If
                        Case 4
                            If RTrim(drCliente("CuentadePago4")) <> "0" And RTrim(drCliente("FormadePago4")) <> "EFECTIVO" Then
                                cCuentaPago = cCuentaPago & "," & drCliente("CuentadePago4")
                                cFormaPago = cFormaPago & "," & RTrim(drCliente("FormadePago4"))
                            ElseIf RTrim(drCliente("CuentadePago4")) = "0" And RTrim(drCliente("FormadePago4")) = "EFECTIVO" Then
                                cCuentaPago = cCuentaPago & "," & "NO IDENTIFICABLE"
                                cFormaPago = cFormaPago & "," & RTrim(drCliente("FormadePago4"))
                            End If
                        Case 5
                            If cCuentaPago = "" And cFormaPago = "" Then
                                cCuentaPago = "NO IDENTIFICABLE"
                                cFormaPago = "NO IDENTIFICABLE"
                            End If
                    End Select
                Next

            Else
                MessageBox.Show("Contrato sin Opción de Compra capturada", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

        Catch eException As Exception
            MessageBox.Show(eException.Source & " " & eException.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()

    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If ListBox1.SelectedItem = Nothing Then
            MessageBox.Show("Hay que seleccionar una Factura", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            txtName.ReadOnly = False
            txtRfc.ReadOnly = False
            txtCalle.ReadOnly = False
            txtCol.ReadOnly = False
            txtCp.ReadOnly = False
            txtDeleg.ReadOnly = False
            txtEdo.ReadOnly = False
            txtName.Focus()
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If TxtDesc.Text = "" Then
            MessageBox.Show("El activo no tiene Datos CFDI, favor de validar con Contabilidad", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim drActifijo As DataRow
        Dim drDatos As DataRow
        Dim daActiFijo As New SqlDataAdapter(cm1)
        Dim dtReporte As New DataTable("Reporte")

        ' Declaración de variables de datos

        Dim cFactsele As String
        Dim cFactura As String
        Dim cProveed As String
        Dim cImporte As String
        Dim cFactact As String
        Dim cIndice As String
        Dim ccadena As String
        Dim cSerie As String
        Dim cFecha As String
        Dim cTime As String
        Dim strUpdate As String
        Dim cRenglon As String
        Dim nFactact As Decimal
        Dim nPorcen As Decimal
        Dim nSubtot As Decimal
        Dim nTotal As Decimal
        Dim nIva As Decimal
        Dim nProximo As Integer
        Dim nNumero As Integer
        Dim i As Integer

        ' Declaración de Clases para generación de los Certificados Fiscales Digitales 

        Dim newCFD As New clsComprobante
        Dim newConcepto As clsConcepto

        ' Declaración de variables de Crystal Reports

        Dim newrptImpracti As New rptImpracti()

        ' Defino las columnas de la Tabla Reporte

        dtReporte.Columns.Add("Nombre", Type.GetType("System.String"))
        dtReporte.Columns.Add("RFC", Type.GetType("System.String"))
        dtReporte.Columns.Add("Calle", Type.GetType("System.String"))
        dtReporte.Columns.Add("Colonia", Type.GetType("System.String"))
        dtReporte.Columns.Add("Del", Type.GetType("System.String"))
        dtReporte.Columns.Add("Copos", Type.GetType("System.String"))
        dtReporte.Columns.Add("Plaza", Type.GetType("System.String"))
        dtReporte.Columns.Add("Fecha", Type.GetType("System.String"))
        dtReporte.Columns.Add("Detalle", Type.GetType("System.String"))
        dtReporte.Columns.Add("Modelo", Type.GetType("System.String"))
        dtReporte.Columns.Add("Motor", Type.GetType("System.String"))
        dtReporte.Columns.Add("Serie", Type.GetType("System.String"))
        dtReporte.Columns.Add("SubTot", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("Iva", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("Total", Type.GetType("System.Decimal"))
        dtReporte.Columns.Add("Letra", Type.GetType("System.String"))
        dtReporte.Columns.Add("Contrato", Type.GetType("System.String"))
        dtReporte.Columns.Add("Numero", Type.GetType("System.String"))
        dtReporte.Columns.Add("Namerep", Type.GetType("System.String"))
        dtReporte.Columns.Add("Tipo", Type.GetType("System.String"))

        If ListBox1.SelectedItem = Nothing Then

            MessageBox.Show("Hay que seleccionar una Factura para Imprimir", "MEnsaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            cFactsele = ListBox1.Items(ListBox1.SelectedIndex)

            ' Este Stored Procedure trae los datos de TODOS los bienes de un contrato dado del archivo Actifijo

            With cm1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "DatosEquipo1"
                .Connection = cnAgil
                .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                .Parameters(0).Value = cAnexo
            End With

            Try
                daActiFijo.Fill(dsAgil1, "ActiFijo")

            Catch eException As Exception
                MessageBox.Show(eException.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            nProximo = 0

            For Each drActifijo In dsAgil1.Tables("ActiFijo").Rows

                cIndice = nProximo.ToString
                cFactura = drActifijo("Factura")
                cProveed = Mid(drActifijo("Proveedor"), 1, 35)
                cImporte = FormatNumber(drActifijo("Importe")).ToString
                nFactact = drActifijo("FactFij")
                cFactact = nFactact.ToString
                nPorcen = Round((drActifijo("Importe") * 100) / Val(txtImporte.Text), 4)
                nSubtot = Round(Val(txtOpcion.Text) * (nPorcen / 100), 2)
                nIva = Round(nSubtot * 0.16, 2)
                nTotal = nSubtot + nIva
                ccadena = cIndice & " " & cFactura & " " & cProveed & " " & cImporte & "   " & cFactact

                If ccadena = cFactsele Then

                    If Val(cFactact) <> 0 Then
                        MessageBox.Show("Este bien ya está Facturado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else

                        nNumero = CDbl(txtFacturaActivo.Text)
                        drDatos = dtReporte.NewRow()
                        drDatos("Nombre") = txtName.Text
                        drDatos("RFC") = txtRfc.Text
                        drDatos("Calle") = txtCalle.Text
                        drDatos("Colonia") = txtCol.Text
                        drDatos("Del") = txtDeleg.Text
                        drDatos("Copos") = txtCp.Text
                        drDatos("Plaza") = txtEdo.Text
                        drDatos("Fecha") = Mes(DTOC(Today))
                        drDatos("Detalle") = drActifijo("Detalle")
                        drDatos("Modelo") = drActifijo("Modelo")
                        drDatos("Motor") = drActifijo("Motor")
                        drDatos("Serie") = drActifijo("Serie")
                        cSerie = drActifijo("Serie")
                        drDatos("SubTot") = nSubtot
                        drDatos("Iva") = nIva
                        drDatos("Total") = nTotal
                        drDatos("Letra") = Letras(nTotal.ToString)
                        drDatos("Contrato") = txtAnexo.Text
                        drDatos("Numero") = nNumero.ToString
                        drDatos("Namerep") = txtNamerep.Text
                        drDatos("Tipo") = txtTipo.Text
                        dtReporte.Rows.Add(drDatos)

                        dsAgil1.Tables.Add(dtReporte)

                        ' En esta parte del proceso se genera el archivo txt que se envia al directorios de EDCInvoice para generar la factura electrónica

                        Dim stmFactura As New FileStream("C:\Facturas\Serie B\FACTURA_" & "B" & "_" & nNumero & ".txt", FileMode.Create, FileAccess.Write, FileShare.None)
                        Dim stmWriter As New StreamWriter(stmFactura, System.Text.Encoding.Default)

                        If Mid(Now.TimeOfDay.ToString, 1, 2) < 12 Then
                            cTime = "a.m."
                        Else
                            cTime = "p.m."
                        End If

                        stmWriter.WriteLine("H1|" & FECHA_APLICACION.ToShortDateString & "|PUE|" & TaQUERY.SacaInstrumemtoMoneSAT(CmbInstruMon.SelectedValue) & "|")

                        If Trim(txtEMail.Text) = "" Then
                            cRenglon = "M1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|B|" & nNumero & "|" & UsuarioGlobalCorreo & "|" & FECHA_APLICACION.ToShortDateString & "|finagil|"
                        Else
                            cRenglon = "M1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|B|" & nNumero & "|" & Trim(txtEMail.Text) & "|" & FECHA_APLICACION.ToShortDateString & "|finagil|"
                        End If
                        stmWriter.WriteLine(cRenglon)

                        cRenglon = "H3|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|B|" & nNumero & "|" & Trim(txtName.Text) & "|" &
                        Trim(txtCalle.Text) & "|||" & Trim(txtCol.Text) & "|" & Trim(txtDeleg.Text) & "|" & Trim(txtEdo.Text) & "|" & txtCp.Text & "|" & cCuentaPago & "|" & cFormaPago & "|MEXICO|" & Trim(txtRfc.Text) & "|M.N.|" &
                        "|FACTURA|" & cCliente & "|LEANDRO VALLE 402||REFORMA Y FFCCNN|TOLUCA|ESTADO DE MEXICO|50070|MEXICO|" & cAnexo & "|000|"

                        cRenglon = cRenglon.Replace("Ñ", Chr(78))
                        cRenglon = cRenglon.Replace("ñ", Chr(110))
                        cRenglon = cRenglon.Replace("á", Chr(97))
                        cRenglon = cRenglon.Replace("é", Chr(101))
                        cRenglon = cRenglon.Replace("í", Chr(105))
                        cRenglon = cRenglon.Replace("ó", Chr(111))
                        cRenglon = cRenglon.Replace("ú", Chr(117))
                        cRenglon = cRenglon.Replace("Á", Chr(65))
                        cRenglon = cRenglon.Replace("É", Chr(69))
                        cRenglon = cRenglon.Replace("Ó", Chr(79))
                        cRenglon = cRenglon.Replace("Ú", Chr(85))
                        cRenglon = cRenglon.Replace("°", Chr(111))
                        stmWriter.WriteLine(cRenglon)

                        ' Aqui no tenemos conceptos de pago unicamente la descripción del BIEN

                        For i = 1 To 5
                            newConcepto = New clsConcepto
                            Select Case i
                                Case 1
                                    cRenglon = "D1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|B|" & nNumero & "|1|PZA||" & Replace(Replace(drActifijo("Detalle"), Chr(10), " "), Chr(13), " ") & "||" & nSubtot & "|" & nIva & "|" & drActifijo("CodigoSAT") & "|" & drActifijo("UsoCFDI") & "|" & drActifijo("Unidad")
                                Case 2
                                    cRenglon = "D1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|B|" & nNumero & "|1|PZA||" & "USADO EN EL ESTADO EN QUE SE ENCUENTRA" & "||" & 0 & "|" & 0 & "|" & drActifijo("CodigoSAT") & "|" & drActifijo("UsoCFDI") & "|" & drActifijo("Unidad")
                                Case 3
                                    cRenglon = "D1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|B|" & nNumero & "|1|PZA||" & "MODELO: " & Trim(drActifijo("Modelo")) & "||" & 0 & "|" & 0 & "|" & drActifijo("CodigoSAT") & "|" & drActifijo("UsoCFDI") & "|" & drActifijo("Unidad")
                                Case 4
                                    cRenglon = "D1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|B|" & nNumero & "|1|PZA||" & "MOTOR: " & Trim(drActifijo("Motor")) & "||" & 0 & "|" & 0 & "|" & drActifijo("CodigoSAT") & "|" & drActifijo("UsoCFDI") & "|" & drActifijo("Unidad")
                                Case 5
                                    cRenglon = "D1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|B|" & nNumero & "|1|PZA||" & "NO. DE SERIE: " & Trim(drActifijo("Serie")) & "||" & 0 & "|" & 0 & "|" & drActifijo("CodigoSAT") & "|" & drActifijo("UsoCFDI") & "|" & drActifijo("Unidad")
                            End Select
                            stmWriter.WriteLine(cRenglon)
                        Next

                        If nIva = 0 Then
                            cRenglon = "S1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|B|" & nNumero & "|" & nSubtot & "|" & nIva & "|" & nTotal & "|" & Letras(nTotal.ToString) & "|||0"
                        Else
                            cRenglon = "S1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|B|" & nNumero & "|" & nSubtot & "|" & nIva & "|" & nTotal & "|" & Letras(nTotal.ToString) & "|||16"
                        End If
                        stmWriter.WriteLine(cRenglon)
                        cRenglon = "Z1|" & cCliente & "|" & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "|B|" & nNumero & "|" & cFormaPago & "|" & Trim(txtRfc.Text) & "|"
                        stmWriter.WriteLine(cRenglon)

                        stmWriter.Flush()
                        stmFactura.Flush()
                        stmFactura.Close()


                        ' Actualización de la tabla Llaves 
                        strUpdate = "UPDATE Llaves SET ConInv = " & nNumero
                        cm2 = New SqlCommand(strUpdate, cnAgil)
                        cnAgil.Open()
                        cm2.ExecuteNonQuery()
                        cnAgil.Close()
                        ' Actualización de la tabla Actifijo para marcar la Factura de Activo
                        strUpdate = "UPDATE Actifijo SET FactFij = " & nNumero
                        strUpdate = strUpdate & " WHERE Anexo = '" & cAnexo & "'"
                        strUpdate = strUpdate & " AND Factura = '" & cFactura & "'"
                        strUpdate = strUpdate & " AND Serie = '" & cSerie & "'"
                        cm2 = New SqlCommand(strUpdate, cnAgil)
                        cnAgil.Open()
                        cm2.ExecuteNonQuery()
                        cnAgil.Close()
                    End If

                End If
                nProximo += 1
            Next
        End If
        Button1.Enabled = True
        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim newrptImpracti As New rptCartaResponsiva()

        newrptImpracti.SetDataSource(dsAgil1)
        newrptImpracti.PrintOptions.PaperOrientation = PaperOrientation.Portrait
        newrptImpracti.PrintToPrinter(2, False, 0, 0)

    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim cRenglon As String
        Dim cDigito As String
        Dim cRenglonOriginal As String
        Dim cFolio As String = ""
        Dim nInicial As Integer
        Dim nFinal As Integer
        Dim cIdentificador As String
        Dim cCliente As String
        Dim nSubTotal As Decimal = 0
        Dim nIva As Decimal = 0
        Dim nTotal As Decimal = 0
        Dim cAnexo As String
        Dim cNombre As String
        Dim cCalle As String
        Dim cNumeroExterior As String
        Dim cNumeroInterior As String
        Dim cColonia As String
        Dim cDelegacion As String
        Dim cEstado As String
        Dim cCopos As String
        Dim cCheque As String
        Dim cRfc As String
        Dim cDescripcion As String
        Dim nImporte As Decimal
        Dim cFecha As String = ""
        Dim cLeyenda As String = ""
        Dim nEspacios As Integer = 0

        ' Declaración de clases para generación de Certificado Fiscal Digital

        Dim newCFD As clsComprobante
        Dim newConcepto As clsConcepto

        Dim oArchivo As StreamReader

        For i = Val(txtFacturaActivo.Text) To Val(txtFacturaActivo.Text)

            cFecha = DTOC(Today)
            cLeyenda = ""

            newCFD = New clsComprobante

            oArchivo = New StreamReader("C:\FACTURAS\\Serie B\FACTURA_B_" & i.ToString & ".TXT")

            While (oArchivo.Peek() > -1)

                cRenglonOriginal = RTrim(LTrim(oArchivo.ReadLine()))
                cIdentificador = Mid(cRenglonOriginal, 1, 2)
                If cIdentificador = "H3" Then
                    cRenglonOriginal = cRenglonOriginal.ToUpper()
                End If
                cRenglon = ""

                ' Tengo que quitar los espacios dobles intermedios

                nEspacios = 1
                For j = 1 To Len(cRenglonOriginal)
                    cDigito = Mid(cRenglonOriginal, j, 1)
                    Select Case Asc(cDigito)
                        Case 32             ' space
                        Case 35             ' #
                        Case 36             ' $
                        Case 38             ' &
                        Case 40 To 41       ' ()
                        Case 44             ' ,
                        Case 45             ' -
                        Case 46             ' .
                        Case 47             ' /
                        Case 48 To 57       ' 0 - 9
                        Case 63, 209        ' Ñ o sus variantes 
                        Case 65 To 90       ' A - Z
                        Case 97             ' a (por 2a. sección por ejemplo)
                        Case 111            ' o (cuando modifique la captura de los generales del cliente ya no lo voy a aceptar)
                        Case 118, 115       ' vs
                        Case 124            ' |
                        Case Else
                            cLeyenda = "ERROR"
                    End Select
                    If cDigito = " " Then
                        If nEspacios = 1 Then
                            cRenglon += cDigito
                            nEspacios += 1
                        End If
                    Else
                        If Asc(cDigito) = 63 Or Asc(cDigito) = 209 Then
                            cDigito = Chr(38)
                        End If
                        cRenglon += cDigito
                        nEspacios = 1
                    End If
                Next

                cAnexo = Mid(cRenglon, 10, 5) + Mid(cRenglon, 16, 4)

                ' Para la serie B

                cFolio = Mid(cRenglon, 23, Len(i.ToString))
                cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - (23 + Len(i.ToString)))

                Select Case cIdentificador

                    Case "H3"

                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        cNombre = Mid(cRenglon, nInicial, nFinal)

                        cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(cNombre) - 1)
                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        cCalle = Mid(cRenglon, nInicial, nFinal)
                        cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(cCalle) - 1)
                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        cNumeroExterior = Mid(cRenglon, nInicial, nFinal)

                        cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(cNumeroExterior) - 1)
                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        cNumeroInterior = Mid(cRenglon, nInicial, nFinal)

                        cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(cNumeroInterior) - 1)
                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        cColonia = Mid(cRenglon, nInicial, nFinal)

                        cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(cColonia) - 1)
                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        cDelegacion = Mid(cRenglon, nInicial, nFinal)

                        cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(cDelegacion) - 1)
                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        cEstado = Mid(cRenglon, nInicial, nFinal)

                        cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(cEstado) - 1)
                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        cCopos = Mid(cRenglon, nInicial, nFinal)

                        cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(cCopos) - 1)
                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        cCuentaPago = Mid(cRenglon, nInicial, nFinal)

                        cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(cCuentaPago) - 1)
                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        cFormaPago = Mid(cRenglon, nInicial, nFinal)
                    Case "D1"

                        newConcepto = New clsConcepto
                        With newConcepto
                            .cantidad = 1
                            cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - 4)
                            nInicial = 1
                            nFinal = cRenglon.IndexOf("|")
                            cDescripcion = Mid(cRenglon, nInicial, nFinal)
                            .descripcion = cDescripcion

                            cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(cDescripcion) - 2)
                            nImporte = Round(CDbl(cRenglon), 2)
                            .valorUnitario = nImporte
                            .importe = nImporte

                        End With
                        newCFD.lstConceptos.Add(newConcepto)

                    Case "S1"

                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        nSubTotal = Mid(cRenglon, nInicial, nFinal)

                        cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(nSubTotal.ToString) - 1)
                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        nIva = Mid(cRenglon, nInicial, nFinal)

                        cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(nIva.ToString) - 1)
                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        nTotal = Mid(cRenglon, nInicial, nFinal)

                        nSubTotal = Round(CDbl(nSubTotal), 2)
                        nIva = Round(CDbl(nIva), 2)
                        nTotal = Round(CDbl(nTotal), 2)

                    Case "Z1"

                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        cCheque = Mid(cRenglon, nInicial, nFinal)

                        cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(cCheque) - 1)
                        nInicial = 1
                        nFinal = cRenglon.IndexOf("|")
                        cRfc = Mid(cRenglon, nInicial, nFinal)

                        cRenglon = Microsoft.VisualBasic.Right(cRenglon, Len(cRenglon) - Len(cRfc) - 1)
                        cLeyenda = cRenglon

                End Select

            End While

            ' Una vez que cerré la conexión y que generé los asientos contables, podría generar el CFD (Certificado Fiscal Digital)

            cFecha = Mid(cFecha, 1, 4) + "-" + Mid(cFecha, 5, 2) + "-" + Mid(cFecha, 7, 2) + "T" + Mid(Now.TimeOfDay.ToString, 1, 8)

            With newCFD
                .version = "2.2"                                ' La versión siempre es la 2.0
                .serie = "B"                                    ' La serie dependerá de la sucursal que esté expidiendo el CFD
                .folio = cFolio
                .fecha = cFecha                                 ' Esta fecha es la de aplicación del pago (cFecha), no la de realización del pago
                .noAprobacion = "194645"                        ' El número de aprobación dependerá de la sucursal que esté expidiendo el CFD
                .anoAprobacion = "2010"                         ' El año de aprobación dependerá de la sucursal que esté expidiendo el CFD
                .formaDePago = "PAGO EN UNA SOLA EXHIBICION"
                .subTotal = nSubTotal
                .total = nTotal
                .tipoDeComprobante = "ingreso"
                .anexo = cAnexo
                .importeLetra = Letras(nTotal.ToString)
                .leyenda = cLeyenda
                .monto = 0.0
                .iva = 0.0
                .metodoDePago = cFormaPago
                .LugarExpedicion = "TOLUCA, ESTADO DE MEXICO"
                .NumCtaPago = cCuentaPago
                .cadenaOriginal = ""
            End With

            ' Los datos de expedición dependerán de la sucursal que esté expidiendo el CFD

            With newCFD.emisor
                .expedidoEn_calle = "LEANDRO VALLE 402"
                .expedidoEn_colonia = "REFORMA Y FFCCNN"
                .expedidoEn_municipio = "TOLUCA"
                .expedidoEn_estado = "ESTADO DE MEXICO"
                .expedidoEn_pais = "MEXICO"
                .expedidoEn_codigoPostal = "50070"
            End With

            With newCFD.receptor
                .rfc = Trim(cRfc)
                .nombre = Trim(cNombre)
                .calle = Trim(cCalle)
                .colonia = Trim(cColonia)
                .municipio = Trim(cDelegacion)
                .estado = Trim(cEstado)
                .pais = "MEXICO"
                .codigoPostal = Trim(cCopos)
            End With

            With newCFD.impuestos
                .impuesto = "IVA"
                .tasa = IIf(nIva > 0, "16.00", "0.00")          ' La tasa del impuesto dependerá del lugar de expedición
                .importe = nIva
            End With

            'CFD(newCFD)

            oArchivo.Close()
            oArchivo = Nothing

        Next

        MsgBox("Generación de FACTURAS DE ACTIVO FIJO electrónicas terminado", MsgBoxStyle.Information, "Mensaje")

    End Sub


End Class
