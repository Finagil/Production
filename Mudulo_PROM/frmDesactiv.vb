Option Explicit On 

Imports System.Data.SqlClient

Public Class frmDesactiv

    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal cAnexo As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.Text = "Desactivación del Contrato " & cAnexo
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
    Friend WithEvents txtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents btnDesactivar As System.Windows.Forms.Button
    Friend WithEvents txtFechacon As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtFecAct As TextBox
    Friend WithEvents TextTipar As TextBox
    Friend WithEvents txtDescr As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtAnexo = New System.Windows.Forms.TextBox()
        Me.btnDesactivar = New System.Windows.Forms.Button()
        Me.txtDescr = New System.Windows.Forms.TextBox()
        Me.txtFechacon = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFecAct = New System.Windows.Forms.TextBox()
        Me.TextTipar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtAnexo
        '
        Me.txtAnexo.Location = New System.Drawing.Point(112, 23)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.ReadOnly = True
        Me.txtAnexo.Size = New System.Drawing.Size(72, 20)
        Me.txtAnexo.TabIndex = 0
        Me.txtAnexo.TabStop = False
        '
        'btnDesactivar
        '
        Me.btnDesactivar.Location = New System.Drawing.Point(515, 23)
        Me.btnDesactivar.Name = "btnDesactivar"
        Me.btnDesactivar.Size = New System.Drawing.Size(75, 23)
        Me.btnDesactivar.TabIndex = 1
        Me.btnDesactivar.Text = "Desactivar"
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(112, 62)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.ReadOnly = True
        Me.txtDescr.Size = New System.Drawing.Size(368, 20)
        Me.txtDescr.TabIndex = 2
        Me.txtDescr.TabStop = False
        '
        'txtFechacon
        '
        Me.txtFechacon.Location = New System.Drawing.Point(112, 102)
        Me.txtFechacon.Name = "txtFechacon"
        Me.txtFechacon.ReadOnly = True
        Me.txtFechacon.Size = New System.Drawing.Size(173, 20)
        Me.txtFechacon.TabIndex = 3
        Me.txtFechacon.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(515, 62)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Contrato"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(18, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(18, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha Contrato"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(291, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha Activacion"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFecAct
        '
        Me.TxtFecAct.Location = New System.Drawing.Point(385, 102)
        Me.TxtFecAct.Name = "TxtFecAct"
        Me.TxtFecAct.ReadOnly = True
        Me.TxtFecAct.Size = New System.Drawing.Size(173, 20)
        Me.TxtFecAct.TabIndex = 8
        Me.TxtFecAct.TabStop = False
        '
        'TextTipar
        '
        Me.TextTipar.Location = New System.Drawing.Point(190, 23)
        Me.TextTipar.Name = "TextTipar"
        Me.TextTipar.ReadOnly = True
        Me.TextTipar.Size = New System.Drawing.Size(25, 20)
        Me.TextTipar.TabIndex = 10
        Me.TextTipar.TabStop = False
        '
        'frmDesactiv
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 161)
        Me.Controls.Add(Me.TextTipar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtFecAct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtFechacon)
        Me.Controls.Add(Me.txtDescr)
        Me.Controls.Add(Me.btnDesactivar)
        Me.Controls.Add(Me.txtAnexo)
        Me.Name = "frmDesactiv"
        Me.Text = "Desactivación de Contratos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmDesactiv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daAnexo As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet()
        Dim drAnexo As DataRow
        Dim cContrato As String

        cContrato = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)
        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DatosCon1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cContrato
        End With

        Try
            daAnexo.Fill(dsAgil, "Anexo")
            drAnexo = dsAgil.Tables("Anexo").Rows(0)
            TextTipar.Text = drAnexo("Tipar")
            txtDescr.Text = drAnexo("Descr")
            txtFechacon.Text = CTOD(drAnexo("Fechacon")).ToShortDateString
            If drAnexo("FechaActivacion") > "0" Then
                TxtFecAct.Text = CTOD(drAnexo("FechaActivacion")).ToShortDateString
            End If
        Catch eException As Exception
            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
        End Try

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnDesactivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesactivar.Click

        ' Declaración de variables de conexión

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim cm5 As New SqlCommand()
        Dim daAnexo As New SqlDataAdapter(cm1)
        Dim daEdoctav As New SqlDataAdapter(cm2)
        Dim daHistoria As New SqlDataAdapter(cm3)
        Dim daEdoctas As New SqlDataAdapter(cm5)
        Dim dsAgil As New DataSet()
        Dim drAnexo As DataRow
        Dim drEdoctav As DataRow
        Dim drEdoctas As DataRow
        Dim strBorrar As String

        ' Declaración de variables de datos

        Dim cContrato As String
        Dim cFlcan As String
        Dim cMotivo As String
        Dim lDesactivar As Boolean
        Dim nNufac As Decimal

        cContrato = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)

        btnDesactivar.Enabled = False

        ' Este Stored Procedure trae los datos del contrato financiado

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DatosCon1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cContrato
        End With

        ' Este Stored Procedure trae los datos de la Tabla del Equipo

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TablaEquipo1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cContrato
        End With

        ' Este Stored Procedure trae los datos de la Tbla del Seguro Financiado

        With cm5
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TablaSeguro1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cContrato
        End With

        ' Este Stored Procedure trae los datos de la Historia de Pagos

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Historia1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cContrato
        End With

        Try

            lDesactivar = True
            cMotivo = ""
            nNufac = 0

            ' Llenar el dataset lo cual abre y cierra la conexión

            daAnexo.Fill(dsAgil, "Anexo")
            daEdoctav.Fill(dsAgil, "Edoctav")
            daHistoria.Fill(dsAgil, "Historia")
            daEdoctas.Fill(dsAgil, "Edoctas")

            drAnexo = dsAgil.Tables("Anexo").Rows(0)
            cFlcan = drAnexo("Flcan")

            If dsAgil.Tables("Edoctav").Rows.Count > 0 Then
                drEdoctav = dsAgil.Tables("Edoctav").Rows(0)
                nNufac = drEdoctav("Nufac")
            End If

            Select Case cFlcan
                Case "T", "C", "B", "W"
                    lDesactivar = False
                    cMotivo = "No se pueden desactivar contratos TERMINADOS, CANCELADOS o dados de BAJA"
                Case "A", "S"
                    If TxtFecAct.Text > "" Then
                        lDesactivar = False
                        cMotivo = "El contrato ya fue dispersado"
                    ElseIf dsAgil.Tables("Historia").Rows.Count > 0 Then
                        lDesactivar = False
                        cMotivo = "Existen pagos realizados a este contrato"
                    ElseIf nNufac <> 0 Then
                        lDesactivar = False
                        cMotivo = "Este contrato tiene vencimientos facturados"
                    ElseIf dsAgil.Tables("Edoctas").Rows.Count > 0 Then
                        lDesactivar = False
                        cMotivo = "Este contrato tiene cargo por seguro financiado"
                    End If
            End Select

            If lDesactivar = True Then

                ' Quitamos la información de las tablas que nos marca el contrato como Activo

                cnAgil.Open()
                strBorrar = "DELETE FROM Anexos WHERE Anexo = '" & cContrato & "'"
                cm4 = New SqlCommand(strBorrar, cnAgil)
                cm4.ExecuteNonQuery()

                strBorrar = "DELETE FROM Edoctav WHERE Anexo = '" & cContrato & "'"
                cm4 = New SqlCommand(strBorrar, cnAgil)
                cm4.ExecuteNonQuery()

                strBorrar = "DELETE FROM Edoctas WHERE Anexo = '" & cContrato & "'"
                cm4 = New SqlCommand(strBorrar, cnAgil)
                cm4.ExecuteNonQuery()

                strBorrar = "DELETE FROM Opciones WHERE Anexo = '" & cContrato & "'"
                cm4 = New SqlCommand(strBorrar, cnAgil)
                cm4.ExecuteNonQuery()

                strBorrar = "DELETE FROM Rentasdep WHERE Anexo = '" & cContrato & "'"
                cm4 = New SqlCommand(strBorrar, cnAgil)
                cm4.ExecuteNonQuery()
                cnAgil.Close()

                MsgBox("Contrato desactivado correctamente", MsgBoxStyle.Information, "Mensaje del Sistema")

            Else

                MsgBox(cMotivo, MsgBoxStyle.Critical, "Error al desactivar")

            End If

        Catch eException As Exception

            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
        cm4.Dispose()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtDescr_TextChanged(sender As Object, e As EventArgs) Handles txtDescr.TextChanged

    End Sub
End Class
