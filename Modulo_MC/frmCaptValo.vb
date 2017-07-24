Option Explicit On 

Imports System.Data.SqlClient

Public Class frmCaptValo
    Inherits System.Windows.Forms.Form
    Dim cAnexoOnbase As String

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnModifica As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents rbFsi As System.Windows.Forms.RadioButton
    Friend WithEvents rbGsi As System.Windows.Forms.RadioButton
    Friend WithEvents rbPsi As System.Windows.Forms.RadioButton
    Friend WithEvents rbCsi As System.Windows.Forms.RadioButton
    Friend WithEvents txtObser As System.Windows.Forms.TextBox
    Friend WithEvents txtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rbFno As System.Windows.Forms.RadioButton
    Friend WithEvents rbCno As System.Windows.Forms.RadioButton
    Friend WithEvents rbPno As System.Windows.Forms.RadioButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents rbGHNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbGHSi As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents rbEsNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbEsSi As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNotaria As System.Windows.Forms.TextBox
    Friend WithEvents txtEscritura As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtLugar As System.Windows.Forms.TextBox
    Friend WithEvents lbSobre As System.Windows.Forms.Label
    Friend WithEvents txtArchivo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtValorHipo As System.Windows.Forms.TextBox
    Friend WithEvents rbFna As System.Windows.Forms.RadioButton
    Friend WithEvents rbCna As System.Windows.Forms.RadioButton
    Friend WithEvents rbGna As System.Windows.Forms.RadioButton
    Friend WithEvents rbPna As System.Windows.Forms.RadioButton
    Friend WithEvents rbGHNa As System.Windows.Forms.RadioButton
    Friend WithEvents rbEsNa As System.Windows.Forms.RadioButton
    Friend WithEvents TxtFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LbSucursal As System.Windows.Forms.Label
    Friend WithEvents LbStatus As System.Windows.Forms.Label
    Friend WithEvents LbTipoCredi As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents rdRUGna As System.Windows.Forms.RadioButton
    Friend WithEvents RdrugNo As System.Windows.Forms.RadioButton
    Friend WithEvents RdRugSi As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCobranza As System.Windows.Forms.TextBox
    Friend WithEvents txtJuridico As System.Windows.Forms.TextBox
    Friend WithEvents LbCast As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents rbPldna As System.Windows.Forms.RadioButton
    Friend WithEvents rbPldno As System.Windows.Forms.RadioButton
    Friend WithEvents rbPldsi As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BtnOnbase As Button
    Friend WithEvents rbGno As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnModifica = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.rbFsi = New System.Windows.Forms.RadioButton()
        Me.rbGsi = New System.Windows.Forms.RadioButton()
        Me.rbPsi = New System.Windows.Forms.RadioButton()
        Me.rbCsi = New System.Windows.Forms.RadioButton()
        Me.txtObser = New System.Windows.Forms.TextBox()
        Me.txtAnexo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbFna = New System.Windows.Forms.RadioButton()
        Me.rbFno = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbCna = New System.Windows.Forms.RadioButton()
        Me.rbCno = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rbGna = New System.Windows.Forms.RadioButton()
        Me.rbGno = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbPna = New System.Windows.Forms.RadioButton()
        Me.rbPno = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.rbGHNa = New System.Windows.Forms.RadioButton()
        Me.rbGHNo = New System.Windows.Forms.RadioButton()
        Me.rbGHSi = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.rbEsNa = New System.Windows.Forms.RadioButton()
        Me.rbEsNo = New System.Windows.Forms.RadioButton()
        Me.rbEsSi = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNotaria = New System.Windows.Forms.TextBox()
        Me.txtEscritura = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbSobre = New System.Windows.Forms.Label()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtValorHipo = New System.Windows.Forms.TextBox()
        Me.TxtFolder = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LbSucursal = New System.Windows.Forms.Label()
        Me.LbStatus = New System.Windows.Forms.Label()
        Me.LbTipoCredi = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.rdRUGna = New System.Windows.Forms.RadioButton()
        Me.RdrugNo = New System.Windows.Forms.RadioButton()
        Me.RdRugSi = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCobranza = New System.Windows.Forms.TextBox()
        Me.txtJuridico = New System.Windows.Forms.TextBox()
        Me.LbCast = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.rbPldna = New System.Windows.Forms.RadioButton()
        Me.rbPldno = New System.Windows.Forms.RadioButton()
        Me.rbPldsi = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnOnbase = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(413, 192)
        Me.txtLugar.MaxLength = 30
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(210, 20)
        Me.txtLugar.TabIndex = 29
        Me.txtLugar.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Facturas Originales "
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contrato Ratificado "
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pagaré"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Garantía Prendaria"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "OBSERVACIONES"
        '
        'btnModifica
        '
        Me.btnModifica.Location = New System.Drawing.Point(248, 447)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(96, 24)
        Me.btnModifica.TabIndex = 9
        Me.btnModifica.Text = "Modificar"
        '
        'btnSalvar
        '
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.Location = New System.Drawing.Point(384, 447)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(96, 24)
        Me.btnSalvar.TabIndex = 10
        Me.btnSalvar.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(512, 447)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 24)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Regresar"
        '
        'rbFsi
        '
        Me.rbFsi.Enabled = False
        Me.rbFsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFsi.Location = New System.Drawing.Point(136, 8)
        Me.rbFsi.Name = "rbFsi"
        Me.rbFsi.Size = New System.Drawing.Size(42, 18)
        Me.rbFsi.TabIndex = 13
        Me.rbFsi.Text = "Sí"
        '
        'rbGsi
        '
        Me.rbGsi.Enabled = False
        Me.rbGsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGsi.Location = New System.Drawing.Point(136, 8)
        Me.rbGsi.Name = "rbGsi"
        Me.rbGsi.Size = New System.Drawing.Size(42, 18)
        Me.rbGsi.TabIndex = 14
        Me.rbGsi.Text = "Sí"
        '
        'rbPsi
        '
        Me.rbPsi.Enabled = False
        Me.rbPsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPsi.Location = New System.Drawing.Point(136, 8)
        Me.rbPsi.Name = "rbPsi"
        Me.rbPsi.Size = New System.Drawing.Size(42, 18)
        Me.rbPsi.TabIndex = 15
        Me.rbPsi.Text = "Sí"
        '
        'rbCsi
        '
        Me.rbCsi.Enabled = False
        Me.rbCsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCsi.Location = New System.Drawing.Point(136, 8)
        Me.rbCsi.Name = "rbCsi"
        Me.rbCsi.Size = New System.Drawing.Size(42, 18)
        Me.rbCsi.TabIndex = 16
        Me.rbCsi.Text = "Sí"
        '
        'txtObser
        '
        Me.txtObser.Location = New System.Drawing.Point(136, 352)
        Me.txtObser.Name = "txtObser"
        Me.txtObser.ReadOnly = True
        Me.txtObser.Size = New System.Drawing.Size(487, 20)
        Me.txtObser.TabIndex = 21
        '
        'txtAnexo
        '
        Me.txtAnexo.Location = New System.Drawing.Point(621, 75)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.Size = New System.Drawing.Size(8, 20)
        Me.txtAnexo.TabIndex = 22
        Me.txtAnexo.Text = "TextBox1"
        Me.txtAnexo.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbFna)
        Me.Panel1.Controls.Add(Me.rbFno)
        Me.Panel1.Controls.Add(Me.rbFsi)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(17, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 32)
        Me.Panel1.TabIndex = 23
        '
        'rbFna
        '
        Me.rbFna.Enabled = False
        Me.rbFna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFna.Location = New System.Drawing.Point(231, 8)
        Me.rbFna.Name = "rbFna"
        Me.rbFna.Size = New System.Drawing.Size(45, 18)
        Me.rbFna.TabIndex = 15
        Me.rbFna.Text = "N/A"
        '
        'rbFno
        '
        Me.rbFno.Enabled = False
        Me.rbFno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFno.Location = New System.Drawing.Point(184, 8)
        Me.rbFno.Name = "rbFno"
        Me.rbFno.Size = New System.Drawing.Size(42, 18)
        Me.rbFno.TabIndex = 14
        Me.rbFno.Text = "No"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbCna)
        Me.Panel2.Controls.Add(Me.rbCno)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.rbCsi)
        Me.Panel2.Location = New System.Drawing.Point(17, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(283, 32)
        Me.Panel2.TabIndex = 24
        '
        'rbCna
        '
        Me.rbCna.Enabled = False
        Me.rbCna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCna.Location = New System.Drawing.Point(232, 8)
        Me.rbCna.Name = "rbCna"
        Me.rbCna.Size = New System.Drawing.Size(45, 18)
        Me.rbCna.TabIndex = 18
        Me.rbCna.Text = "N/A"
        '
        'rbCno
        '
        Me.rbCno.Enabled = False
        Me.rbCno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCno.Location = New System.Drawing.Point(184, 8)
        Me.rbCno.Name = "rbCno"
        Me.rbCno.Size = New System.Drawing.Size(42, 18)
        Me.rbCno.TabIndex = 17
        Me.rbCno.Text = "No"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbGna)
        Me.Panel3.Controls.Add(Me.rbGno)
        Me.Panel3.Controls.Add(Me.rbGsi)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(17, 165)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(283, 32)
        Me.Panel3.TabIndex = 25
        '
        'rbGna
        '
        Me.rbGna.Enabled = False
        Me.rbGna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGna.Location = New System.Drawing.Point(231, 8)
        Me.rbGna.Name = "rbGna"
        Me.rbGna.Size = New System.Drawing.Size(45, 18)
        Me.rbGna.TabIndex = 16
        Me.rbGna.Text = "N/A"
        '
        'rbGno
        '
        Me.rbGno.Enabled = False
        Me.rbGno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGno.Location = New System.Drawing.Point(184, 8)
        Me.rbGno.Name = "rbGno"
        Me.rbGno.Size = New System.Drawing.Size(42, 18)
        Me.rbGno.TabIndex = 15
        Me.rbGno.Text = "No"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbPna)
        Me.Panel4.Controls.Add(Me.rbPno)
        Me.Panel4.Controls.Add(Me.rbPsi)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(17, 133)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(283, 32)
        Me.Panel4.TabIndex = 26
        '
        'rbPna
        '
        Me.rbPna.Enabled = False
        Me.rbPna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPna.Location = New System.Drawing.Point(231, 8)
        Me.rbPna.Name = "rbPna"
        Me.rbPna.Size = New System.Drawing.Size(45, 18)
        Me.rbPna.TabIndex = 17
        Me.rbPna.Text = "N/A"
        '
        'rbPno
        '
        Me.rbPno.Enabled = False
        Me.rbPno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPno.Location = New System.Drawing.Point(184, 8)
        Me.rbPno.Name = "rbPno"
        Me.rbPno.Size = New System.Drawing.Size(42, 18)
        Me.rbPno.TabIndex = 16
        Me.rbPno.Text = "No"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.rbGHNa)
        Me.Panel5.Controls.Add(Me.rbGHNo)
        Me.Panel5.Controls.Add(Me.rbGHSi)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(17, 197)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(283, 32)
        Me.Panel5.TabIndex = 27
        '
        'rbGHNa
        '
        Me.rbGHNa.Enabled = False
        Me.rbGHNa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGHNa.Location = New System.Drawing.Point(232, 8)
        Me.rbGHNa.Name = "rbGHNa"
        Me.rbGHNa.Size = New System.Drawing.Size(45, 18)
        Me.rbGHNa.TabIndex = 16
        Me.rbGHNa.Text = "N/A"
        '
        'rbGHNo
        '
        Me.rbGHNo.Enabled = False
        Me.rbGHNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGHNo.Location = New System.Drawing.Point(184, 8)
        Me.rbGHNo.Name = "rbGHNo"
        Me.rbGHNo.Size = New System.Drawing.Size(42, 18)
        Me.rbGHNo.TabIndex = 15
        Me.rbGHNo.Text = "No"
        '
        'rbGHSi
        '
        Me.rbGHSi.Enabled = False
        Me.rbGHSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGHSi.Location = New System.Drawing.Point(136, 8)
        Me.rbGHSi.Name = "rbGHSi"
        Me.rbGHSi.Size = New System.Drawing.Size(42, 18)
        Me.rbGHSi.TabIndex = 14
        Me.rbGHSi.Text = "Sí"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Garantía Hipotecaría"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.rbEsNa)
        Me.Panel6.Controls.Add(Me.rbEsNo)
        Me.Panel6.Controls.Add(Me.rbEsSi)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Location = New System.Drawing.Point(17, 229)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(283, 32)
        Me.Panel6.TabIndex = 28
        '
        'rbEsNa
        '
        Me.rbEsNa.Enabled = False
        Me.rbEsNa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEsNa.Location = New System.Drawing.Point(232, 8)
        Me.rbEsNa.Name = "rbEsNa"
        Me.rbEsNa.Size = New System.Drawing.Size(45, 18)
        Me.rbEsNa.TabIndex = 16
        Me.rbEsNa.Text = "N/A"
        '
        'rbEsNo
        '
        Me.rbEsNo.Enabled = False
        Me.rbEsNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEsNo.Location = New System.Drawing.Point(184, 8)
        Me.rbEsNo.Name = "rbEsNo"
        Me.rbEsNo.Size = New System.Drawing.Size(42, 18)
        Me.rbEsNo.TabIndex = 15
        Me.rbEsNo.Text = "No"
        '
        'rbEsSi
        '
        Me.rbEsSi.Enabled = False
        Me.rbEsSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEsSi.Location = New System.Drawing.Point(136, 8)
        Me.rbEsSi.Name = "rbEsSi"
        Me.rbEsSi.Size = New System.Drawing.Size(42, 18)
        Me.rbEsSi.TabIndex = 14
        Me.rbEsSi.Text = "Sí"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Escaneado"
        '
        'txtNotaria
        '
        Me.txtNotaria.Location = New System.Drawing.Point(413, 219)
        Me.txtNotaria.MaxLength = 30
        Me.txtNotaria.Name = "txtNotaria"
        Me.txtNotaria.Size = New System.Drawing.Size(210, 20)
        Me.txtNotaria.TabIndex = 30
        Me.txtNotaria.Visible = False
        '
        'txtEscritura
        '
        Me.txtEscritura.Location = New System.Drawing.Point(413, 245)
        Me.txtEscritura.MaxLength = 30
        Me.txtEscritura.Name = "txtEscritura"
        Me.txtEscritura.Size = New System.Drawing.Size(210, 20)
        Me.txtEscritura.TabIndex = 31
        Me.txtEscritura.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(357, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Lugar"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(357, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Notaría"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(357, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Escritura"
        Me.Label10.Visible = False
        '
        'lbSobre
        '
        Me.lbSobre.AutoSize = True
        Me.lbSobre.Location = New System.Drawing.Point(357, 80)
        Me.lbSobre.Name = "lbSobre"
        Me.lbSobre.Size = New System.Drawing.Size(35, 13)
        Me.lbSobre.TabIndex = 36
        Me.lbSobre.Text = "Sobre"
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(413, 77)
        Me.txtArchivo.MaxLength = 55
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.ReadOnly = True
        Me.txtArchivo.Size = New System.Drawing.Size(210, 20)
        Me.txtArchivo.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(330, 274)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Valor Hipoteca"
        Me.Label12.Visible = False
        '
        'TxtValorHipo
        '
        Me.TxtValorHipo.Location = New System.Drawing.Point(413, 271)
        Me.TxtValorHipo.MaxLength = 30
        Me.TxtValorHipo.Name = "TxtValorHipo"
        Me.TxtValorHipo.Size = New System.Drawing.Size(210, 20)
        Me.TxtValorHipo.TabIndex = 38
        Me.TxtValorHipo.Visible = False
        '
        'TxtFolder
        '
        Me.TxtFolder.Location = New System.Drawing.Point(413, 103)
        Me.TxtFolder.MaxLength = 55
        Me.TxtFolder.Name = "TxtFolder"
        Me.TxtFolder.ReadOnly = True
        Me.TxtFolder.Size = New System.Drawing.Size(210, 20)
        Me.TxtFolder.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(357, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Folder"
        '
        'LbSucursal
        '
        Me.LbSucursal.AutoSize = True
        Me.LbSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSucursal.Location = New System.Drawing.Point(16, 9)
        Me.LbSucursal.Name = "LbSucursal"
        Me.LbSucursal.Size = New System.Drawing.Size(60, 13)
        Me.LbSucursal.TabIndex = 42
        Me.LbSucursal.Text = "Sucursal:"
        '
        'LbStatus
        '
        Me.LbStatus.AutoSize = True
        Me.LbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbStatus.Location = New System.Drawing.Point(16, 27)
        Me.LbStatus.Name = "LbStatus"
        Me.LbStatus.Size = New System.Drawing.Size(53, 13)
        Me.LbStatus.TabIndex = 43
        Me.LbStatus.Text = "Estatus:"
        '
        'LbTipoCredi
        '
        Me.LbTipoCredi.AutoSize = True
        Me.LbTipoCredi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTipoCredi.Location = New System.Drawing.Point(17, 46)
        Me.LbTipoCredi.Name = "LbTipoCredi"
        Me.LbTipoCredi.Size = New System.Drawing.Size(98, 13)
        Me.LbTipoCredi.TabIndex = 44
        Me.LbTipoCredi.Text = "Tipo de Crédito:"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.rdRUGna)
        Me.Panel7.Controls.Add(Me.RdrugNo)
        Me.Panel7.Controls.Add(Me.RdRugSi)
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Location = New System.Drawing.Point(17, 261)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(283, 32)
        Me.Panel7.TabIndex = 29
        '
        'rdRUGna
        '
        Me.rdRUGna.Enabled = False
        Me.rdRUGna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdRUGna.Location = New System.Drawing.Point(232, 8)
        Me.rdRUGna.Name = "rdRUGna"
        Me.rdRUGna.Size = New System.Drawing.Size(45, 18)
        Me.rdRUGna.TabIndex = 16
        Me.rdRUGna.Text = "N/A"
        '
        'RdrugNo
        '
        Me.RdrugNo.Enabled = False
        Me.RdrugNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdrugNo.Location = New System.Drawing.Point(184, 8)
        Me.RdrugNo.Name = "RdrugNo"
        Me.RdrugNo.Size = New System.Drawing.Size(42, 18)
        Me.RdrugNo.TabIndex = 15
        Me.RdrugNo.Text = "No"
        '
        'RdRugSi
        '
        Me.RdRugSi.Enabled = False
        Me.RdRugSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdRugSi.Location = New System.Drawing.Point(136, 8)
        Me.RdRugSi.Name = "RdRugSi"
        Me.RdRugSi.Size = New System.Drawing.Size(42, 18)
        Me.RdRugSi.TabIndex = 14
        Me.RdRugSi.Text = "Sí"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "RUG"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 379)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 16)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "COBRANZA"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 410)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 16)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "JURIDICO"
        '
        'txtCobranza
        '
        Me.txtCobranza.Location = New System.Drawing.Point(136, 379)
        Me.txtCobranza.Name = "txtCobranza"
        Me.txtCobranza.ReadOnly = True
        Me.txtCobranza.Size = New System.Drawing.Size(487, 20)
        Me.txtCobranza.TabIndex = 47
        '
        'txtJuridico
        '
        Me.txtJuridico.Location = New System.Drawing.Point(136, 406)
        Me.txtJuridico.Name = "txtJuridico"
        Me.txtJuridico.ReadOnly = True
        Me.txtJuridico.Size = New System.Drawing.Size(487, 20)
        Me.txtJuridico.TabIndex = 48
        '
        'LbCast
        '
        Me.LbCast.AutoSize = True
        Me.LbCast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCast.ForeColor = System.Drawing.Color.Red
        Me.LbCast.Location = New System.Drawing.Point(161, 27)
        Me.LbCast.Name = "LbCast"
        Me.LbCast.Size = New System.Drawing.Size(0, 13)
        Me.LbCast.TabIndex = 49
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.rbPldna)
        Me.Panel8.Controls.Add(Me.rbPldno)
        Me.Panel8.Controls.Add(Me.rbPldsi)
        Me.Panel8.Controls.Add(Me.Label16)
        Me.Panel8.Location = New System.Drawing.Point(17, 293)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(283, 32)
        Me.Panel8.TabIndex = 50
        '
        'rbPldna
        '
        Me.rbPldna.Enabled = False
        Me.rbPldna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPldna.Location = New System.Drawing.Point(232, 8)
        Me.rbPldna.Name = "rbPldna"
        Me.rbPldna.Size = New System.Drawing.Size(45, 18)
        Me.rbPldna.TabIndex = 16
        Me.rbPldna.Text = "N/A"
        '
        'rbPldno
        '
        Me.rbPldno.Enabled = False
        Me.rbPldno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPldno.Location = New System.Drawing.Point(184, 8)
        Me.rbPldno.Name = "rbPldno"
        Me.rbPldno.Size = New System.Drawing.Size(42, 18)
        Me.rbPldno.TabIndex = 15
        Me.rbPldno.Text = "No"
        '
        'rbPldsi
        '
        Me.rbPldsi.Enabled = False
        Me.rbPldsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPldsi.Location = New System.Drawing.Point(136, 8)
        Me.rbPldsi.Name = "rbPldsi"
        Me.rbPldsi.Size = New System.Drawing.Size(42, 18)
        Me.rbPldsi.TabIndex = 14
        Me.rbPldsi.Text = "Sí"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 16)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "PLD"
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Enabled = False
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(413, 130)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha1.TabIndex = 51
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(505, 130)
        Me.txtName.MaxLength = 55
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(118, 20)
        Me.txtName.TabIndex = 52
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(310, 134)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 13)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Contrato Cliente"
        '
        'BtnOnbase
        '
        Me.BtnOnbase.Location = New System.Drawing.Point(101, 447)
        Me.BtnOnbase.Name = "BtnOnbase"
        Me.BtnOnbase.Size = New System.Drawing.Size(104, 24)
        Me.BtnOnbase.TabIndex = 100
        Me.BtnOnbase.Text = "OnBase Contrato"
        '
        'frmCaptValo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(638, 483)
        Me.Controls.Add(Me.BtnOnbase)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.LbCast)
        Me.Controls.Add(Me.txtJuridico)
        Me.Controls.Add(Me.txtCobranza)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.LbTipoCredi)
        Me.Controls.Add(Me.LbStatus)
        Me.Controls.Add(Me.LbSucursal)
        Me.Controls.Add(Me.TxtFolder)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtValorHipo)
        Me.Controls.Add(Me.txtArchivo)
        Me.Controls.Add(Me.lbSobre)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEscritura)
        Me.Controls.Add(Me.txtNotaria)
        Me.Controls.Add(Me.txtLugar)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtAnexo)
        Me.Controls.Add(Me.txtObser)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmCaptValo"
        Me.Text = "Captura de Valores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmCaptValo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim dsAgil As New DataSet()
        Dim cm1 As New SqlCommand()
        Dim daAnexos As New SqlDataAdapter(cm1)
        Dim drAnexo As DataRow

        'Declaración de variables de datos

        Dim cAnexo As String
        Dim cDoc1 As String
        Dim cDoc2 As String
        Dim cDoc3 As String
        Dim cRUG As String
        Dim cLugar As String
        Dim cNotaria As String
        Dim cEscritura As String
        Dim cCusnam As String
        Dim cGarantia As String
        Dim cScaneo As String
        Dim cArchivo As String
        Dim cFolder As String
        Dim cStatus As String
        Dim cCastigada As String
        Dim cCtoCliente As String
        Dim cPld As String
        Dim nHipoteca As Decimal

        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)
        cAnexoOnbase = "% " & CDbl(Mid(cAnexo, 2, 8)) & " %"
        ' El siguiente Stored Procedure trae todos los atributos de la tabla Anexos,
        ' para un anexo dado

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DatosCon1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daAnexos.Fill(dsAgil, "Anexos")

        ' Validando que el Contrato esté Activo

        drAnexo = dsAgil.Tables("Anexos").Rows(0)

        cCusnam = drAnexo("Descr")
        cDoc1 = drAnexo("Doc1")
        cDoc2 = drAnexo("Doc2")
        cDoc3 = drAnexo("Doc3")
        cRUG = drAnexo("rug")
        cPld = drAnexo("Pld")
        cLugar = drAnexo("Lugar")
        cNotaria = drAnexo("Notaria")
        cEscritura = drAnexo("Escritura")
        cGarantia = drAnexo("Prendaria")
        cScaneo = drAnexo("Scaneo")
        cArchivo = drAnexo("Archivo")
        nHipoteca = drAnexo("ValorHipoteca")
        cFolder = drAnexo("Folder")
        cStatus = drAnexo("flcan")
        cCastigada = drAnexo("Vencida")
        cCtoCliente = drAnexo("ReferenCC")
        LbSucursal.Text = LbSucursal.Text & " " & drAnexo("Nombre_Sucursal")

        Select Case cStatus
            Case "A"
                LbStatus.Text = "Estatus: ACTIVO"
            Case "C"
                LbStatus.Text = "Estatus: CANCELADO"
            Case "B"
                LbStatus.Text = "Estatus: BAJA"
            Case "T"
                LbStatus.Text = "Estatus: TERMINADO"
        End Select

        If cCastigada = "C" Then
            LbCast.Text = " Cuenta Castigada"
        End If

        LbTipoCredi.Text = LbTipoCredi.Text & " " & drAnexo("TipoCredito")

        Me.Text = txtAnexo.Text & "   " & cCusnam
        If cDoc1 = "S" Then
            rbFsi.Checked = True
            rbFno.Checked = False
            rbFna.Checked = False
        ElseIf cDoc1 = "N" Then
            rbFsi.Checked = False
            rbFno.Checked = True
            rbFna.Checked = False
        Else
            rbFsi.Checked = False
            rbFno.Checked = False
            rbFna.Checked = True
        End If

        If cDoc2 = "S" Then
            rbCsi.Checked = True
            rbCno.Checked = False
            rbCna.Checked = False
        ElseIf cDoc2 = "N" Then
            rbCsi.Checked = False
            rbCno.Checked = True
            rbCna.Checked = False
        Else
            rbCsi.Checked = False
            rbCno.Checked = False
            rbCna.Checked = True
        End If

        If cDoc3 = "S" Then
            rbPsi.Checked = True
            rbPno.Checked = False
            rbPna.Checked = False
        ElseIf cDoc3 = "N" Then
            rbPsi.Checked = False
            rbPno.Checked = True
            rbPna.Checked = False
        Else
            rbPsi.Checked = False
            rbPno.Checked = False
            rbPna.Checked = True
        End If

        If cRUG = "S" Then
            RdRugSi.Checked = True
            RdrugNo.Checked = False
            rdRUGna.Checked = False
        ElseIf cRUG = "N" Then
            RdRugSi.Checked = False
            RdrugNo.Checked = True
            rdRUGna.Checked = False
        Else
            RdRugSi.Checked = False
            RdrugNo.Checked = False
            rdRUGna.Checked = True
        End If

        If Trim(drAnexo("Pld")) = "S" Then
            rbPldsi.Checked = True
            rbPldno.Checked = False
            rbPldna.Checked = False
        ElseIf Trim(drAnexo("Pld")) = "N" Or Trim(drAnexo("Pld")) = "" Then
            rbPldsi.Checked = False
            rbPldno.Checked = True
            rbPldna.Checked = False
        Else
            rbPldsi.Checked = False
            rbPldno.Checked = False
            rbPldna.Checked = True
        End If

        If Trim(cLugar) <> "" Or Trim(cNotaria) <> "" Or Trim(cEscritura) <> "" Then
            rbGHSi.Checked = True
            rbGHNo.Checked = False
            Label8.Visible = True
            txtLugar.Text = cLugar
            txtLugar.Visible = True
            txtLugar.ReadOnly = True
            Label9.Visible = True
            txtNotaria.Text = cNotaria
            txtNotaria.Visible = True
            txtNotaria.ReadOnly = True
            TxtValorHipo.Text = nHipoteca.ToString("N2")
            TxtValorHipo.Visible = True
            TxtValorHipo.ReadOnly = True
            Label10.Visible = True
            txtEscritura.Text = cEscritura
            txtEscritura.Visible = True
            txtEscritura.ReadOnly = True
        Else
            rbGHSi.Checked = False
            rbGHNo.Checked = True
            rbGHNa.Checked = False
        End If

        If cScaneo = "S" Then
            rbEsSi.Checked = True
            rbEsNo.Checked = False
            rbEsNa.Checked = False
        ElseIf cScaneo = "N" Then
            rbEsSi.Checked = False
            rbEsNo.Checked = True
            rbEsNa.Checked = False
        Else
            rbEsSi.Checked = False
            rbEsNo.Checked = False
            rbEsNa.Checked = True
        End If

        If cGarantia = "S" Then
            rbGsi.Checked = True
            rbGno.Checked = False
            rbGna.Checked = False
        ElseIf cGarantia = "N" Then
            rbGsi.Checked = False
            rbGno.Checked = True
            rbGna.Checked = False
        Else
            rbGsi.Checked = False
            rbGno.Checked = False
            rbGna.Checked = True
        End If

        txtArchivo.Text = drAnexo("Archivo")
        TxtFolder.Text = drAnexo("Folder")
        txtArchivo.ReadOnly = True
        TxtFolder.ReadOnly = True
        txtObser.Text = drAnexo("Observa")
        txtCobranza.Text = drAnexo("ObCobranza")
        txtJuridico.Text = drAnexo("ObJuridico")

        If Trim(cCtoCliente) <> "" Then
            dtpFecha1.Value = CTOD(Mid(cCtoCliente, 1, 8))
            txtName.Text = Mid(cCtoCliente, 10, 12)
        End If
        dtpFecha1.Enabled = False
        txtName.ReadOnly = True

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnModifica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifica.Click
        btnSalvar.Enabled = True
        rbFsi.Enabled = True
        rbCsi.Enabled = True
        rbPsi.Enabled = True
        rbGsi.Enabled = True
        rbFno.Enabled = True
        rbCno.Enabled = True
        rbPno.Enabled = True
        rbGno.Enabled = True
        rbGHSi.Enabled = True
        rbGHNo.Enabled = True
        rbEsSi.Enabled = True
        rbEsNo.Enabled = True
        rbFna.Enabled = True
        rbCna.Enabled = True
        rbPna.Enabled = True
        rbGna.Enabled = True
        rbGHNa.Enabled = True
        rbEsNa.Enabled = True
        RdRugSi.Enabled = True
        RdrugNo.Enabled = True
        rdRUGna.Enabled = True
        rbPldsi.Enabled = True
        rbPldno.Enabled = True
        rbPldna.Enabled = True

        txtLugar.ReadOnly = False
        txtNotaria.ReadOnly = False
        txtEscritura.ReadOnly = False
        txtObser.ReadOnly = False
        txtCobranza.ReadOnly = False
        txtJuridico.ReadOnly = False
        txtArchivo.ReadOnly = False
        dtpFecha1.Enabled = True
        txtName.ReadOnly = False
        TxtFolder.ReadOnly = False
        TxtValorHipo.ReadOnly = False
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim dsAgil As New DataSet()
        Dim cm1 As New SqlCommand()
        Dim strUpdate As String

        ' Declaración de variables de datos

        Dim cDoc1 As String
        Dim cDoc2 As String
        Dim cDoc3 As String
        Dim cRuG As String
        Dim cAnexo As String
        Dim cGarantia As String
        Dim cObserva As String
        Dim cNotaria As String
        Dim cEscritura As String
        Dim cArchivo As String
        Dim cfolder As String
        Dim cLugar As String
        Dim cGHip As String
        Dim cObCobr As String
        Dim cObJuri As String
        Dim cEsc As String
        Dim cPld As String
        Dim cRefCC As String
        Dim nHipoteca As Decimal

        cDoc1 = "N"
        cDoc2 = "N"
        cDoc3 = "N"
        cRuG = "N"
        cGarantia = "N"
        cGHip = "N"
        cEsc = "N"
        cPld = "N"
        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)

        btnModifica.Enabled = False
        rbFsi.Enabled = False
        rbCsi.Enabled = False
        rbPsi.Enabled = False
        rbGsi.Enabled = False
        rbFno.Enabled = False
        rbCno.Enabled = False
        rbPno.Enabled = False
        rbGno.Enabled = False
        rbGHSi.Enabled = False
        rbGHNo.Enabled = False
        rbEsSi.Enabled = False
        rbEsNo.Enabled = False
        rbFna.Enabled = False
        rbCna.Enabled = False
        rbPna.Enabled = False
        rbGna.Enabled = False
        rbGHNa.Enabled = False
        rbEsNa.Enabled = False
        RdRugSi.Enabled = False
        RdrugNo.Enabled = False
        rdRUGna.Enabled = False
        rbPldsi.Enabled = False
        rbPldno.Enabled = False
        rbPldna.Enabled = False

        txtLugar.ReadOnly = True
        txtNotaria.ReadOnly = True
        txtEscritura.ReadOnly = True
        txtObser.ReadOnly = True
        txtCobranza.ReadOnly = True
        txtJuridico.ReadOnly = True
        txtArchivo.ReadOnly = True
        txtName.ReadOnly = True
        dtpFecha1.Enabled = False
        TxtFolder.ReadOnly = True
        btnSalvar.Enabled = False
        TxtValorHipo.ReadOnly = True

        If rbFsi.Checked = True Then
            cDoc1 = "S"
        End If
        If rbCsi.Checked = True Then
            cDoc2 = "S"
        End If
        If rbPsi.Checked = True Then
            cDoc3 = "S"
        End If
        If RdRugSi.Checked = True Then
            cRuG = "S"
        End If
        If rbPldsi.Checked = True Then
            cPld = "S"
        End If
        If rbGsi.Checked = True Then
            cGarantia = "S"
        End If
        If rbGHSi.Checked = True Then
            cGHip = "S"
        End If
        If rbEsSi.Checked = True Then
            cEsc = "S"
        End If

        If rbFna.Checked = True Then
            cDoc1 = "X"
        End If
        If rbCna.Checked = True Then
            cDoc2 = "X"
        End If
        If rbPna.Checked = True Then
            cDoc3 = "X"
        End If
        If rdRUGna.Checked = True Then
            cRuG = "X"
        End If
        If rbPldna.Checked = True Then
            cPld = "X"
        End If
        If rbGna.Checked = True Then
            cGarantia = "X"
        End If
        If rbGHNa.Checked = True Then
            cGHip = "X"
        End If
        If rbEsNa.Checked = True Then
            cEsc = "X"
        End If

        cObserva = txtObser.Text
        cObCobr = txtCobranza.Text
        cObJuri = txtJuridico.Text
        cLugar = txtLugar.Text
        cNotaria = txtNotaria.Text
        cEscritura = txtEscritura.Text
        cArchivo = txtArchivo.Text
        cfolder = TxtFolder.Text
        cRefCC = DTOC(dtpFecha1.Value) & " " & txtName.Text
        If TxtValorHipo.Text = "" Then TxtValorHipo.Text = 0
        nHipoteca = Val(TxtValorHipo.Text)

        strUpdate = "UPDATE Anexos SET Doc1 = " & "'" & cDoc1 & "'," 'factura
        strUpdate = strUpdate & " Doc2 = " & "'" & cDoc2 & "'," ' Contrato
        strUpdate = strUpdate & " Doc3 = " & "'" & cDoc3 & "',"
        strUpdate = strUpdate & " RUG = " & "'" & cRuG & "',"
        strUpdate = strUpdate & " PLD = " & "'" & cPld & "',"
        strUpdate = strUpdate & " GHipotec = " & "'" & cGHip & "',"
        strUpdate = strUpdate & " Lugar = " & "'" & cLugar & "',"
        strUpdate = strUpdate & " Notaria = " & "'" & cNotaria & "',"
        strUpdate = strUpdate & " Escritura = " & "'" & cEscritura & "',"
        strUpdate = strUpdate & " Scaneo = " & "'" & cEsc & "',"
        strUpdate = strUpdate & " Prendaria = " & "'" & cGarantia & "',"
        strUpdate = strUpdate & " Archivo = " & "'" & cArchivo & "',"
        strUpdate = strUpdate & " ReferenCC = " & "'" & cRefCC & "',"
        strUpdate = strUpdate & " Folder = " & "'" & cfolder & "',"
        strUpdate = strUpdate & " ValorHipoteca = " & "'" & nHipoteca & "',"
        strUpdate = strUpdate & " ObCobranza = " & "'" & cObCobr & "',"
        strUpdate = strUpdate & " ObJuridico = " & "'" & cObJuri & "',"
        strUpdate = strUpdate & " Observa = " & "'" & cObserva & "' "
        strUpdate = strUpdate & " WHERE Anexo = " & "'" & cAnexo & "'"

        Try
            Dim BLOQ As Integer = DesBloqueaContrato(cAnexo) 'DESBLOQUEO MESA DE CONTROL+++++++++++++
            cm1 = New SqlCommand(strUpdate, cnAgil)
            cnAgil.Open()
            cm1.ExecuteNonQuery()
            BloqueaContrato(cAnexo, BLOQ) '*******************BLOQUEO MESA DE CONTROL++++++++++++++++
            cnAgil.Close()
        Catch eException As Exception
            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
        End Try

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub rbGHSi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbGHSi.Click
        Label8.Visible = True
        txtLugar.Visible = True
        Label9.Visible = True
        txtNotaria.Visible = True
        Label10.Visible = True
        txtEscritura.Visible = True
    End Sub

    Private Sub rbGHNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbGHNo.Click
        Label8.Visible = False
        txtLugar.Visible = False
        Label9.Visible = False
        txtNotaria.Visible = False
        Label10.Visible = False
        txtEscritura.Visible = False
    End Sub

    Private Sub rbGHNa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGHNa.Click
        Label8.Visible = False
        txtLugar.Visible = False
        Label9.Visible = False
        txtNotaria.Visible = False
        Label10.Visible = False
        txtEscritura.Visible = False
    End Sub

    Private Sub BtnOnbase_Click(sender As Object, e As EventArgs) Handles BtnOnbase.Click
        Dim f As New FrmDocOnbase
        f.Cadena1 = "Mesa de Control%"
        'f.Cadena2 = "%" & Mid(lblDescr.Text, 1, 10) & "%"
        f.Cadena2 = cAnexoOnbase
        f.Titulo = Me.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        f.Dispose()
    End Sub
End Class
