Option Explicit On 

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports System.Security.Principal.WindowsIdentity

Public Class frmDepoRefe

    Inherits System.Windows.Forms.Form
    Dim dsRPT As New ReportesDS
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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents btnSubeXml As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnSubeXml = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 56)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1008, 640)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'btnSubeXml
        '
        Me.btnSubeXml.Location = New System.Drawing.Point(808, 12)
        Me.btnSubeXml.Name = "btnSubeXml"
        Me.btnSubeXml.Size = New System.Drawing.Size(96, 23)
        Me.btnSubeXml.TabIndex = 1
        Me.btnSubeXml.Text = "Subir al Sistema"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(918, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(1002, 41)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(10, 20)
        Me.txtFecha.TabIndex = 3
        Me.txtFecha.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(178, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Indica la Fecha de los Datos"
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(285, 9)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(96, 23)
        Me.btnProcesar.TabIndex = 25
        Me.btnProcesar.Text = "Procesar"
        '
        'frmDepoRefe
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1024, 702)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSubeXml)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmDepoRefe"
        Me.Text = "Depósitos Referenciados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnSubeXml_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubeXml.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As SqlCommand
        Dim cm2 As New SqlCommand()
        Dim daDeporef As New SqlDataAdapter(cm2)
        Dim drDato As ReportesDS.DepoRefeRow
        Dim drFecha As DataRow
        Dim strInsert As String
        Dim dsDeporefe As New DataSet

        ' Declaración de variables de datos

        Dim cFecha As String
        Dim nDatos As Integer

        ' Llenar el DataSet desde el archivo XML


        drFecha = dsRPT.DepoRefe.Rows(0)
        cFecha = drFecha("Fecha")

        ' Este Stored Procedure trae los movimientos x deposito referenciado del dia solicitado

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TraeReferenciado1"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Llenar el dataset lo cual abre y cierra la conexión

        daDeporef.Fill(dsDeporefe, "Referen")
        nDatos = dsDeporefe.Tables("Referen").Rows.Count

        If nDatos > 0 Then
            MsgBox("Ya Existe esta Información", MsgBoxStyle.Information, "Mensaje del Sistema")
        Else
            Try
                cnAgil.Open()
                For Each drDato In dsRPT.DepoRefe.Rows
                    strInsert = "INSERT INTO Referenciado( Fecha, Banco, Referencia, Nombre, Importe, RefBanco, SBC,Domiciliacion, efectivo, Interbancario,InstrumentoMonetario)"
                    strInsert = strInsert & "VALUES('"
                    strInsert = strInsert & drDato("Fecha") & "', '"
                    strInsert = strInsert & drDato("Banco") & "', '"
                    strInsert = strInsert & drDato("Referencia") & "', '"
                    strInsert = strInsert & drDato("Nombre") & "', '"
                    strInsert = strInsert & drDato("Importe") & "', '"
                    strInsert = strInsert & drDato("RefBanco") & "', '"
                    strInsert = strInsert & drDato("Sbc") & "', "
                    strInsert = strInsert & IIf(drDato.Domiciliacion = True, 1, 0) & ","
                    strInsert = strInsert & IIf(drDato.Efectivo = True, 1, 0) & ","
                    strInsert = strInsert & IIf(drDato.InterBancario = True, 1, 0) & ",'"
                    strInsert = strInsert & drDato.InstrumentoMonetario & "')"

                    cm1 = New SqlCommand(strInsert, cnAgil)
                    cm1.ExecuteNonQuery()
                Next
                cnAgil.Close()
                MsgBox("Datos Cargados Exitosamente", MsgBoxStyle.Information, "Mensaje del Sistema")
            Catch eException As Exception
                MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
            End Try
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        dsRPT.DepoRefe.Clear()

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As SqlCommand
        Dim drDepoRefe As ReportesDS.DepoRefeRow

        ' Declaración de variables de datos

        Dim cBanco As String
        Dim cCusnam As String
        Dim cTipoCredito As String
        Dim cFecha As String
        Dim cFechaMAX As String
        Dim cFechaDatos As String
        Dim cMonto As String
        Dim cMontoSinComas As String
        Dim cReferencia As String
        Dim cRefBanco As String
        Dim cRenglon As String
        Dim cSBC As String
        Dim cTipoRef As String
        Dim i As Byte
        Dim nMonto As Decimal
        Dim oArchivo As StreamReader
        Dim Efectivo As Boolean
        Dim InterBancario As Boolean
        Dim BanamexEF(2, 1000) As String
        Dim InstrumentoMonetario As String

        ' Declaración de variables de Crystal Reports

        Dim newrptDepoRefe As New rptDepoRefe()
        Dim cReportTitle As String
        Dim x As Integer
        InstrumentoMonetario = ""
        If DateTimePicker1.Value.Date <= Today.Date Then
            ' Abro la conexión aquí para no tener que abrirla y cerrarla n veces

            cnAgil.Open()

            cFechaDatos = DTOC(DateTimePicker1.Value)
            cFecha = " "
            cSBC = "N"
#Region "BANCOMER"
            If File.Exists("C:\Files\BANCOMER.TXT") Then

                cBanco = "BANCOMER"

                oArchivo = New StreamReader("C:\Files\BANCOMER.TXT")

                While (oArchivo.Peek() > -1)

                    cRenglon = oArchivo.ReadLine()


                    If cFecha = " " Then
                        cFecha = "20" & Mid(cRenglon, 27, 2) & Mid(cRenglon, 29, 2) & Mid(cRenglon, 31, 2)
                        txtFecha.Text = cFecha
                    End If

                    If Mid(cRenglon, 1, 6) = "220074" Then
                        Efectivo = False
                        nMonto = Round(Val(Mid(cRenglon, 30, 13)) / 100, 2)
                        cRefBanco = Mid(cRenglon, 67, 8)
                        cReferencia = Mid(cRenglon, 67, 8)

                        InstrumentoMonetario = Mid(cRenglon, 25, 3)
                        If InstrumentoMonetario = "Y15" Then ' IDENTIFICA EFECTIVO
                            Efectivo = True
                        End If

                        If Trim(cRefBanco) = "" Then
                            cRefBanco = Mid(cRenglon, 55, 8)
                            cReferencia = Mid(cRenglon, 55, 8)
                        End If

                        If Mid(cReferencia, 1, 1) = "9" Then
                            cReferencia = Mid(cReferencia, 3, 5) + "0001"
                            cTipoRef = "C"   ' Referencia corta
                        Else
                            cReferencia = "0" + Mid(cReferencia, 1, 4) + "0" + Mid(cReferencia, 5, 3)
                            cTipoRef = "L"   ' Referencia larga
                        End If
                    End If

                    If Mid(cRenglon, 36, 6) = "581034" Or Mid(cRenglon, 36, 6) = "244159" Then

                        ' El siguiente comando me regresa el nombre del cliente

                        cm1 = New SqlCommand()
                        With cm1
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "DepoRefe1"
                            .Connection = cnAgil
                            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                            .Parameters(0).Value = cReferencia
                        End With
                        cCusnam = cm1.ExecuteScalar()
                        cTipoCredito = Mid(cCusnam, 1, 1)
                        cCusnam = Mid(cCusnam, 2, Len(cCusnam))

                        If cTipoRef = "C" Then
                            cReferencia = Mid(cReferencia, 1, 5)
                        Else
                            cReferencia = Mid(cReferencia, 1, 5) + "/" + Mid(cReferencia, 6, 4)
                        End If

                        ' nMonto = Val(Mid(cRenglon, 93, 13))
                        If cFecha = cFechaDatos Then
                            drDepoRefe = dsRPT.DepoRefe.NewRow()
                            drDepoRefe("Fecha") = cFecha
                            drDepoRefe("Banco") = cBanco
                            drDepoRefe("Referencia") = cReferencia
                            drDepoRefe("Nombre") = cCusnam
                            drDepoRefe("Importe") = nMonto
                            drDepoRefe("RefBanco") = cRefBanco
                            drDepoRefe("SBC") = cSBC
                            drDepoRefe("Domiciliacion") = False
                            drDepoRefe("TipoCredito") = cTipoCredito
                            drDepoRefe("Efectivo") = Efectivo
                            drDepoRefe("InstrumentoMonetario") = InstrumentoMonetario
                            drDepoRefe.InterBancario = False
                            dsRPT.DepoRefe.Rows.Add(drDepoRefe)
                        End If
                    End If

                End While

                oArchivo.Close()

            End If
#End Region

#Region "HSBC"

            If File.Exists("C:\Files\HSBC.TXT") Then

                cBanco = "HSBC"

                oArchivo = New StreamReader("C:\Files\HSBC.TXT")

                While (oArchivo.Peek() > -1)
                    Efectivo = False
                    cRenglon = oArchivo.ReadLine()

                    If cFecha = " " Then
                        cFecha = Mid(cRenglon, 19, 10)
                        If Mid(cFecha, 1, 5) <> "FECHA" Then
                            cFecha = Mid(cFecha, 7, 4) & Mid(cFecha, 4, 2) & Mid(cFecha, 1, 2)
                            txtFecha.Text = Mid(cFecha, 7, 4) & Mid(cFecha, 4, 2) & Mid(cFecha, 1, 2)
                        End If
                    End If
                    If Mid(cFecha, 1, 5) = "FECHA" Then
                        cFecha = " "
                    End If

                    If Mid(cRenglon, 127, 1) = "C" Then
                        cReferencia = Mid(cRenglon, 149, 7)
                        cRefBanco = Mid(cRenglon, 149, 8)

                        If Mid(cReferencia, 1, 1) = "9" Then
                            cReferencia = Mid(cReferencia, 3, 5) + "0001"
                            cTipoRef = "C"   ' Referencia corta
                        Else
                            cReferencia = "0" + Mid(cReferencia, 1, 4) + "0" + Mid(cReferencia, 5, 3)
                            cTipoRef = "L"   ' Referencia larga
                        End If

                        ' El siguiente comando me regresa el nombre del cliente

                        cm1 = New SqlCommand()
                        With cm1
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "DepoRefe1"
                            .Connection = cnAgil
                            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                            .Parameters(0).Value = cReferencia
                        End With
                        cCusnam = cm1.ExecuteScalar()
                        cTipoCredito = Mid(cCusnam, 1, 1)
                        cCusnam = Mid(cCusnam, 2, Len(cCusnam))

                        If cTipoRef = "C" Then
                            cReferencia = Mid(cReferencia, 1, 5)
                        Else
                            cReferencia = Mid(cReferencia, 1, 5) + "/" + Mid(cReferencia, 6, 4)
                        End If

                        nMonto = Round(Val(Mid(cRenglon, 101, 13)) / 100, 2)
                        If cFecha = cFechaDatos Then
                            drDepoRefe = dsRPT.DepoRefe.NewRow()
                            drDepoRefe("Fecha") = cFecha
                            drDepoRefe("Banco") = cBanco
                            drDepoRefe("Referencia") = cReferencia
                            drDepoRefe("Nombre") = cCusnam
                            drDepoRefe("Importe") = nMonto
                            drDepoRefe("RefBanco") = cRefBanco
                            drDepoRefe("SBC") = cSBC
                            drDepoRefe("Domiciliacion") = False
                            drDepoRefe("TipoCredito") = cTipoCredito
                            drDepoRefe("Efectivo") = Efectivo
                            drDepoRefe.InterBancario = False
                            drDepoRefe("InstrumentoMonetario") = ""
                            dsRPT.DepoRefe.Rows.Add(drDepoRefe)
                        End If
                    End If

                End While

                oArchivo.Close()

            End If
#End Region

#Region "BANAMEX"
            If File.Exists("C:\Files\BANAMEX.TXT") Then

                cBanco = "BANAMEX"

                oArchivo = New StreamReader("C:\Files\BANAMEX.TXT")
                While (oArchivo.Peek() > -1)
                    cRenglon = oArchivo.ReadLine()
                    cReferencia = Mid(cRenglon, 8, 8)
                    If Mid(cRenglon, 1, 3) = "A07" And Mid(cRenglon, 55, 2) = "31" Then
                        BanamexEF(1, x) = Mid(cRenglon, 8, 8)
                        BanamexEF(2, x) = "Y15"
                    ElseIf Mid(cRenglon, 1, 3) = "A07" And Mid(cRenglon, 55, 2) = "32" Then
                        BanamexEF(1, x) = Mid(cRenglon, 8, 8)
                        BanamexEF(2, x) = "Y05"
                    End If
                    x += 1
                End While
                oArchivo.Close()
                x = 0
                oArchivo = New StreamReader("C:\Files\BANAMEX.TXT")
                While (oArchivo.Peek() > -1)
                    Efectivo = False
                    cRenglon = oArchivo.ReadLine()

                    If cFecha = " " Then
                        cFecha = "20" & Mid(cRenglon, 5, 2) & Mid(cRenglon, 3, 2) & Mid(cRenglon, 1, 2)
                        txtFecha.Text = cFecha
                    End If

                    If (Mid(cRenglon, 1, 3) = "A13" Or Mid(cRenglon, 1, 3) = "A15" Or Mid(cRenglon, 1, 3) = "A17") And Mid(cRenglon, 8, 8) <> "00000000" Then
                        cReferencia = Mid(cRenglon, 8, 8)
                        cRefBanco = Mid(cRenglon, 9, 9)

                        If cReferencia = BanamexEF(1, x + 1) Then ' Tiene datos adicionales
                            InstrumentoMonetario = BanamexEF(2, x + 1)
                            If BanamexEF(2, x + 1) = "Y15" Then
                                Efectivo = True
                            End If
                        Else
                            InstrumentoMonetario = "Y16"
                        End If

                        If Mid(cReferencia, 1, 1) = "9" Then
                            cReferencia = Mid(cReferencia, 4, 5) + "0001"
                            cTipoRef = "C"   ' Referencia corta
                        Else
                            cReferencia = Mid(cReferencia, 1, 5) + "0" + Mid(cReferencia, 6, 3)
                            cTipoRef = "L"   ' Referencia larga
                        End If



                        ' El siguiente comando me regresa el nombre del cliente

                        cm1 = New SqlCommand()
                        With cm1
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "DepoRefe1"
                            .Connection = cnAgil
                            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                            .Parameters(0).Value = cReferencia
                        End With
                        cCusnam = cm1.ExecuteScalar()
                        cTipoCredito = Mid(cCusnam, 1, 1)
                        cCusnam = Mid(cCusnam, 2, Len(cCusnam))

                        If cTipoRef = "C" Then
                            cReferencia = Mid(cReferencia, 1, 5)
                        Else
                            cReferencia = Mid(cReferencia, 1, 5) + "/" + Mid(cReferencia, 6, 4)
                        End If

                        nMonto = Round(Val(Mid(cRenglon, 42, 13)) / 100, 2)
                        If Mid(cRenglon, 1, 3) = "A13" Then
                            cSBC = "S"
                        Else
                            cSBC = "N"
                        End If

                        If cFecha = cFechaDatos Then
                            drDepoRefe = dsRPT.DepoRefe.NewRow()
                            drDepoRefe("Fecha") = cFecha
                            drDepoRefe("Banco") = cBanco
                            drDepoRefe("Referencia") = cReferencia
                            drDepoRefe("Nombre") = cCusnam
                            drDepoRefe("Importe") = nMonto
                            drDepoRefe("RefBanco") = cRefBanco
                            drDepoRefe("SBC") = cSBC
                            drDepoRefe("Domiciliacion") = False
                            drDepoRefe("TipoCredito") = cTipoCredito
                            drDepoRefe("Efectivo") = Efectivo
                            drDepoRefe("InstrumentoMonetario") = InstrumentoMonetario
                            drDepoRefe.InterBancario = False
                            dsRPT.DepoRefe.Rows.Add(drDepoRefe)
                        End If

                    End If
                    x += 1
                End While

                oArchivo.Close()

            End If
#End Region

#Region "BANORTE"

            If File.Exists("C:\Files\BANORTE.TXT") Then

                cBanco = "BANORTE"

                oArchivo = New StreamReader("C:\Files\BANORTE.TXT")

                While (oArchivo.Peek() > -1)
                    Efectivo = False
                    cRenglon = oArchivo.ReadLine()

                    If Mid(cRenglon, 1, 5) = "36832" Then

                        If cFecha = " " Or cFecha < DTOC(Today) Then
                            cFecha = Microsoft.VisualBasic.Right(cRenglon, 10)
                            cFecha = Mid(cFecha, 7, 4) & Mid(cFecha, 4, 2) & Mid(cFecha, 1, 2)
                            txtFecha.Text = cFecha
                        End If

                        cFecha = Microsoft.VisualBasic.Right(cRenglon, 10)
                        cFecha = Mid(cFecha, 7, 4) & Mid(cFecha, 4, 2) & Mid(cFecha, 1, 2)

                        cReferencia = Mid(cRenglon, 39, 7)
                        cRefBanco = Mid(cRenglon, 37, 10)
                        cReferencia = "0" + Mid(cReferencia, 1, 4) + "0" + Mid(cReferencia, 5, 3)

                        ' El siguiente comando me regresa el nombre del cliente

                        cm1 = New SqlCommand()
                        With cm1
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "DepoRefe1"
                            .Connection = cnAgil
                            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                            .Parameters(0).Value = cReferencia
                        End With
                        cCusnam = cm1.ExecuteScalar()
                        cTipoCredito = Mid(cCusnam, 1, 1)
                        cCusnam = Mid(cCusnam, 2, Len(cCusnam))

                        cReferencia = Mid(cReferencia, 1, 5) + "/" + Mid(cReferencia, 6, 4)

                        cMonto = Mid(cRenglon, 52, 30)
                        cMonto = Mid(cRenglon, 52, InStr(cMonto, "|", CompareMethod.Text) - 1)

                        cMontoSinComas = ""
                        For i = 1 To Len(cMonto)
                            If Mid(cMonto, i, 1) <> "," Then
                                cMontoSinComas += Mid(cMonto, i, 1)
                            End If
                        Next

                        nMonto = Val(cMontoSinComas)

                        If cFecha = cFechaDatos Then
                            drDepoRefe = dsRPT.DepoRefe.NewRow()
                            drDepoRefe("Fecha") = cFecha
                            drDepoRefe("Banco") = cBanco
                            drDepoRefe("Referencia") = cReferencia
                            drDepoRefe("Nombre") = cCusnam
                            drDepoRefe("Importe") = nMonto
                            drDepoRefe("RefBanco") = cRefBanco
                            drDepoRefe("SBC") = cSBC
                            drDepoRefe("Domiciliacion") = False
                            drDepoRefe("TipoCredito") = cTipoCredito
                            drDepoRefe("Efectivo") = Efectivo
                            drDepoRefe.InterBancario = False
                            drDepoRefe("InstrumentoMonetario") = ""
                            dsRPT.DepoRefe.Rows.Add(drDepoRefe)
                        End If

                    End If

                End While

                oArchivo.Close()

            End If
#End Region

#Region "DOMICILIACION"
            If File.Exists("C:\Files\DOMICILIACION.TXT") Then

                oArchivo = New StreamReader("C:\Files\DOMICILIACION.TXT")

                While (oArchivo.Peek() > -1)
                    cBanco = "BANCOMER"
                    cRenglon = oArchivo.ReadLine()
                    Efectivo = False
                    InterBancario = False
                    InstrumentoMonetario = "P17"
                    'If cFecha = " " Then
                    'cFecha = Mid(cRenglon, 24, 8)
                    'txtFecha.Text = cFecha
                    'End If

                    If Mid(cRenglon, 1, 2) = "02" And Mid(cRenglon, 278, 2) = "00" Then '00 exitosos 04 sin fondos

                        cFecha = Mid(cRenglon, 29, 8)
                        txtFecha.Text = cFecha

                        If cFecha >= cFechaMAX Then
                            cFechaMAX = cFecha
                        End If

                        If InStr(cRenglon, cBanco) <= 0 Then ' para identificar domiciliados interbancarios
                            InterBancario = True
                            InstrumentoMonetario = "P35"
                        End If

                        nMonto = Round(Val(Mid(cRenglon, 14, 15)) / 100, 2)
                        cRefBanco = Mid(cRenglon, 158, 8)
                        cReferencia = Mid(cRenglon, 158, 8)
                        If Mid(cReferencia, 1, 1) = "9" Then
                            cReferencia = Mid(cReferencia, 3, 5) + "0001"
                            cTipoRef = "C"   ' Referencia corta
                        Else
                            cReferencia = "0" + Mid(cReferencia, 1, 4) + "0" + Mid(cReferencia, 5, 3)
                            cTipoRef = "L"   ' Referencia larga
                        End If


                        If Mid(cRenglon, 37, 6) = "      " Then

                            ' El siguiente comando me regresa el nombre del cliente

                            cm1 = New SqlCommand()
                            With cm1
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "DepoRefe1"
                                .Connection = cnAgil
                                .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                                .Parameters(0).Value = cReferencia
                            End With
                            cCusnam = cm1.ExecuteScalar()
                            cTipoCredito = Mid(cCusnam, 1, 1)
                            cCusnam = Mid(cCusnam, 2, Len(cCusnam))

                            If cTipoRef = "C" Then
                                cReferencia = Mid(cReferencia, 1, 5)
                            Else
                                cReferencia = Mid(cReferencia, 1, 5) + "/" + Mid(cReferencia, 6, 4)
                            End If

                            ' nMonto = Val(Mid(cRenglon, 93, 13))
                            If cFecha = cFechaDatos Then
                                drDepoRefe = dsRPT.DepoRefe.NewRow()
                                drDepoRefe("Fecha") = cFecha
                                drDepoRefe("Banco") = cBanco
                                drDepoRefe("Referencia") = cReferencia
                                drDepoRefe("Nombre") = cCusnam
                                drDepoRefe("Importe") = nMonto
                                drDepoRefe("RefBanco") = cRefBanco
                                drDepoRefe("SBC") = cSBC
                                drDepoRefe("Domiciliacion") = True
                                drDepoRefe("TipoCredito") = cTipoCredito
                                drDepoRefe("Efectivo") = Efectivo
                                drDepoRefe("InstrumentoMonetario") = InstrumentoMonetario
                                drDepoRefe.InterBancario = InterBancario
                                dsRPT.DepoRefe.Rows.Add(drDepoRefe)
                            End If
                        End If
                    End If
                End While
                oArchivo.Close()
#End Region

            End If
            'If cFecha < cFechaMAX Then
            cFecha = cFechaDatos
            'End If

            oArchivo = Nothing

            ' Aquí cierro y destruyo la conexión

            cnAgil.Close()
            cnAgil = Nothing
            cm1 = Nothing

            cReportTitle = "COBRANZA VIA DEPOSITO REFERENCIADO AL " & Mes(cFecha)
            newrptDepoRefe.SetDataSource(dsRPT)
            newrptDepoRefe.SummaryInfo.ReportTitle = cReportTitle
            CrystalReportViewer1.ReportSource = newrptDepoRefe

        End If

    End Sub
End Class
