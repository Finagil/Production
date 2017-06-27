Option Explicit On

Imports System.Data.SqlClient
Imports System.Math

Public Class frmActuatas

    Inherits System.Windows.Forms.Form

    Dim cFecha As String
    Friend WithEvents txtTIIE365 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label



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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTIIE As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtTIIE91 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTIIE182 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTIIE = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtTIIE91 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTIIE182 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTIIE365 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TIIE"
        '
        'txtTIIE
        '
        Me.txtTIIE.Enabled = False
        Me.txtTIIE.Location = New System.Drawing.Point(98, 33)
        Me.txtTIIE.Name = "txtTIIE"
        Me.txtTIIE.Size = New System.Drawing.Size(100, 20)
        Me.txtTIIE.TabIndex = 2
        Me.txtTIIE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(123, 137)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Salir"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(42, 137)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Guardar"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(82, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "FECHA"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtTIIE91
        '
        Me.txtTIIE91.Enabled = False
        Me.txtTIIE91.Location = New System.Drawing.Point(98, 59)
        Me.txtTIIE91.Name = "txtTIIE91"
        Me.txtTIIE91.Size = New System.Drawing.Size(100, 20)
        Me.txtTIIE91.TabIndex = 3
        Me.txtTIIE91.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "TIIE 91"
        '
        'txtTIIE182
        '
        Me.txtTIIE182.Enabled = False
        Me.txtTIIE182.Location = New System.Drawing.Point(98, 85)
        Me.txtTIIE182.Name = "txtTIIE182"
        Me.txtTIIE182.Size = New System.Drawing.Size(100, 20)
        Me.txtTIIE182.TabIndex = 4
        Me.txtTIIE182.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "TIIE 182"
        '
        'txtTIIE365
        '
        Me.txtTIIE365.Enabled = False
        Me.txtTIIE365.Location = New System.Drawing.Point(98, 111)
        Me.txtTIIE365.Name = "txtTIIE365"
        Me.txtTIIE365.Size = New System.Drawing.Size(100, 20)
        Me.txtTIIE365.TabIndex = 5
        Me.txtTIIE365.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "TIIE 365"
        '
        'frmActuatas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(217, 175)
        Me.Controls.Add(Me.txtTIIE365)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTIIE182)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTIIE91)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtTIIE)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmActuatas"
        Me.Text = "Captura diaria de la tasa TIIE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim strInsert As String
        Dim strUpdate As String

        Dim i As Int16
        Dim cTas As String
        Dim nVal As Decimal
        Try
            If txtTIIE91.Enabled = True Then
                cnAgil.Open()
                strInsert = "delete from hista where tasa = '9' and vigencia = '" & cFecha & "'"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
                cnAgil.Close()

                cnAgil.Open()
                strInsert = "INSERT INTO Hista(Tasa, Vigencia, Valor) VALUES ('9', '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & txtTIIE91.Text & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
                cnAgil.Close()
            End If
            If txtTIIE182.Enabled = True Then
                cnAgil.Open()
                strInsert = "delete from hista where tasa = '10' and vigencia = '" & cFecha & "'"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
                cnAgil.Close()

                cnAgil.Open()
                strInsert = "INSERT INTO Hista(Tasa, Vigencia, Valor) VALUES ('10', '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & txtTIIE182.Text & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
                cnAgil.Close()
            End If
            If txtTIIE365.Enabled = True Then
                cnAgil.Open()
                strInsert = "delete from hista where tasa = '11' and vigencia = '" & cFecha & "'"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
                cnAgil.Close()

                cnAgil.Open()
                strInsert = "INSERT INTO Hista(Tasa, Vigencia, Valor) VALUES ('11', '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & txtTIIE365.Text & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
                cnAgil.Close()
            End If
            If txtTIIE.Enabled = True Then
                cnAgil.Open()
                strInsert = "delete from hista where tasa = '4' and vigencia = '" & cFecha & "'"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
                cnAgil.Close()

                cnAgil.Open()
                strInsert = "INSERT INTO Hista(Tasa, Vigencia, Valor) VALUES ('4', '"
                strInsert = strInsert & cFecha & "', '"
                strInsert = strInsert & txtTIIE.Text & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
                cnAgil.Close()
            End If
            SacaDatosTTIIE()

        Catch eException As Exception
            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de error")
        End Try

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmActuatas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SacaDatosTTIIE()
    End Sub

    Sub SacaDatosTTIIE()
        cFecha = DateTimePicker1.Value.ToString("yyyyMMdd")
        txtTIIE.Enabled = False
        txtTIIE91.Enabled = False
        txtTIIE182.Enabled = False
        txtTIIE365.Enabled = False

        Dim ta As New TesoreriaDSTableAdapters.HistaTableAdapter
        Dim t As New TesoreriaDS.HistaDataTable
        Dim r As TesoreriaDS.HistaRow
        ta.Fill(t, DateTimePicker1.Value.ToString("yyyyMMdd"), 4) 'TIIE 28
        If t.Rows.Count > 0 Then
            r = t.Rows(0)
            txtTIIE.Text = r.Valor.ToString("n4")
            If r.Valor <= 0 Then
                txtTIIE.Enabled = True
            End If
        Else
            txtTIIE.Text = 0.ToString("n4")
            txtTIIE.Enabled = True
        End If

        ta.Fill(t, DateTimePicker1.Value.ToString("yyyyMMdd"), 9) 'TIIE 91
        If t.Rows.Count > 0 Then
            r = t.Rows(0)
            txtTIIE91.Text = r.Valor.ToString("n4")
            If r.Valor <= 0 Then
                txtTIIE91.Enabled = True
            End If
        Else
            txtTIIE91.Text = 0.ToString("n4")
            txtTIIE91.Enabled = True
        End If
        ta.Fill(t, DateTimePicker1.Value.ToString("yyyyMMdd"), 10) 'TIIE 182
        If t.Rows.Count > 0 Then
            r = t.Rows(0)
            txtTIIE182.Text = r.Valor.ToString("n4")
            If r.Valor <= 0 Then
                txtTIIE182.Enabled = True
            End If
        Else
            txtTIIE182.Text = 0.ToString("n4")
            txtTIIE182.Enabled = True
        End If
        ta.Fill(t, DateTimePicker1.Value.ToString("yyyyMMdd"), 11) 'TIIE 365
        If t.Rows.Count > 0 Then
            r = t.Rows(0)
            txtTIIE365.Text = r.Valor.ToString("n4")
            If r.Valor <= 0 Then
                txtTIIE365.Enabled = True
            End If
        Else
            txtTIIE365.Text = 0.ToString("n4")
            txtTIIE365.Enabled = True
        End If
        If txtTIIE.Enabled = True Or txtTIIE91.Enabled = True Or txtTIIE182.Enabled = True Or txtTIIE365.Enabled = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        SacaDatosTTIIE()
    End Sub


End Class
