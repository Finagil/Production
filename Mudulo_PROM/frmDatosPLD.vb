Option Explicit On

Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Security
Imports System.Security.Principal.WindowsIdentity
Public Class frmDatosPLD

    Public Sub New(ByVal cCliente As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtPassword.Text = cCliente

    End Sub

    Dim cCopos As String = "01000"
    Dim lFirstTime As Boolean = True
    Protected Const TABLE_NAME As String = "Codigos"
    Private Sub frmDatosPLD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim dsAgil As New DataSet()
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim daClientes As New SqlDataAdapter(cm1)
        Dim daActiv As New SqlDataAdapter(cm2)
        Dim daCopos As New SqlDataAdapter(cm3)
        Dim daPLD As New SqlDataAdapter(cm4)
        Dim drCliente As DataRow
        Dim drPLD As DataRow

        ' Declaración de variables de datos

        Dim cCliente As String
        Dim cTipo As String

        cCliente = txtPassword.Text

        ' El siguiente Stored Procedure trae todos los atributos de la tabla Clientes, para un cliente dado

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Descr, Tipo, Curp, PaisNacimiento, Nacionalidad, Genero, SerieFiel FROM Clientes WHERE Cliente = " & cCliente
            .Connection = cnAgil
        End With

        ' El siguiente Stored Procedure trae todos los atributos de todas las Actividades Economicas

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Actividad_Eco Order by AE_Descrip"
            .Connection = cnAgil
        End With

        ' El siguiente Stored Procedure trae todos los atributos de todas los Codigos Postales

        With cm3
            .CommandType = CommandType.Text
            .CommandText = "SELECT Distinct Copos, Delegacion FROM Codigos Order by Copos"
            .Connection = cnAgil
        End With

        ' El siguiente Stored Procedure trae todos los atributos de la Base de Datos PLD

        With cm4
            .CommandType = CommandType.Text
            .CommandText = "SELECT PLD_Calle, PLD_Numext, PLD_Numint, PLD_Copos, PLD_Asentamiento, PLD_Tipoasent, PLD_Delegacion, PLD_Ciudad, PLD_Estado, PLD_ClaveAE, PLD_EstadoNac FROM Datos_PLD WHERE Cliente = " & cCliente
            .Connection = cnAgil
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daClientes.Fill(dsAgil, "Clientes")
        daActiv.Fill(dsAgil, "Actividad")
        daCopos.Fill(dsAgil, "Copos")
        daPLD.Fill(dsAgil, "PLD")

        Try

            ' Ligar la tabla Actividad del dataset dsAgil al ComboBox Actividad

            ComboBox1.DataSource = dsAgil
            ComboBox1.DisplayMember = "Actividad.AE_Descrip"
            ComboBox1.ValueMember = "Actividad.AE_Clave"

            ' Ligar la tabla Codigos del dataset dsAgil al ComboBox de C.P.

            cbCopos.DataSource = dsAgil
            cbCopos.ValueMember = "Copos.Copos"

            If dsAgil.Tables("Clientes").Rows.Count > 0 Then

                drCliente = dsAgil.Tables("Clientes").Rows(0)
                txtDescr.Text = drCliente("Descr")
                cTipo = drCliente("Tipo")
                If cTipo = "F" Then
                    txtDescTipo.Text = "PERSONA FISICA"
                ElseIf cTipo = "E" Then
                    txtDescTipo.Text = "PERSONA FISICA CON ACTIVIDAD EMPRESARIAL"
                ElseIf cTipo = "M" Then
                    txtDescTipo.Text = "PERSONA MORAL"
                    mtxtCURP.Enabled = False
                    txtPaisNac.Enabled = False
                    cbGenero.SelectedIndex = 2
                    cbGenero.Enabled = False
                    txtEdoNac.Enabled = False
                End If
                mtxtCURP.Text = drCliente("CURP")
                txtPaisNac.Text = Trim(drCliente("PaisNacimiento"))
                txtNacion.Text = Trim(drCliente("Nacionalidad"))
                txtFiel.Text = Trim(drCliente("SerieFiel"))
                Select Case Trim(drCliente("Genero"))
                    Case "Masculino"
                        cbGenero.SelectedIndex = 0
                    Case "Femenino"
                        cbGenero.SelectedIndex = 1
                    Case "No Aplica"
                        cbGenero.SelectedIndex = 2
                End Select

            End If

            If dsAgil.Tables("PLD").Rows.Count > 0 Then

                drPLD = dsAgil.Tables("PLD").Rows(0)

                txtCalle.Text = RTrim(drPLD("PLD_Calle"))
                txtNext.Text = drPLD("PLD_Numext")
                txtNint.Text = drPLD("PLD_Numint")
                mtxtColonia.Text = drPLD("PLD_Asentamiento")
                txtDelegacion.Text = drPLD("PLD_Delegacion")
                txtEstado.Text = drPLD("PLD_Estado")
                cCopos = Trim(drPLD("PLD_Copos"))
                cbCopos.SelectedValue = cCopos
                txtCopos.Text = cCopos
                lFirstTime = False
                txtTipoAs.Text = Trim(drPLD("PLD_TipoAsent"))
                txtCity.Text = Trim(drPLD("PLD_Ciudad"))
                ComboBox1.SelectedValue = Trim(drPLD("PLD_ClaveAE"))
                txtEdoNac.Text = drPLD("PLD_EstadoNac")

            End If

            BindDataGrid()

        Catch eException As Exception
            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
        End Try

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()

    End Sub
    Private Sub BindDataGrid()

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daBitac As New SqlDataAdapter(cm1)
        Dim da2 As New SqlDataAdapter
        Dim dsAgil As New DataSet()

        ' Declaración de variables de datos

        Dim nCount As Integer

        ' Con este Stored Procedure obtengo los renglones insertados en la bitacora
        ' para este cliente

        If txtCopos.Text = "" Then
            txtCopos.Text = "01000"
            lFirstTime = False
        End If

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Asentamiento, Tipo, Delegacion, Ciudad, Estado FROM Codigos WHERE Copos = " & txtCopos.Text
            .Connection = cnAgil
        End With
        daBitac.Fill(dsAgil, "Codigos")
        nCount = dsAgil.Tables("Codigos").Rows.Count

        If Not IsNothing(dsAgil.Tables(TABLE_NAME)) Then

            ' Limpia el existente estilo de la tabla.

            With DataGrid1
                .BackgroundColor = SystemColors.InactiveCaptionText
                .CaptionText = ""
                .CaptionBackColor = SystemColors.ActiveCaption
                .TableStyles.Clear()
                .ResetAlternatingBackColor()
                .ResetBackColor()
                .ResetForeColor()
                .ResetGridLineColor()
                .ResetHeaderBackColor()
                .ResetHeaderFont()
                .ResetHeaderForeColor()
                .ResetSelectionBackColor()
                .ResetSelectionForeColor()
                .ResetText()
            End With

        End If

        DataGrid1.Visible = True
        DataGrid1.DataSource = dsAgil.Tables("Codigos")
        DataGrid1.CurrentCell = New DataGridCell(nCount - 1, nCount - 1)
        FormatGridWithBothTableAndColumnStyles()

    End Sub

    Private Sub FormatGridWithBothTableAndColumnStyles()

        ' Contiene las propiedades del DataGrid pero seran modificadas
        ' en el propiedades del DataGridTableStyle.

        With DataGrid1
            .BackColor = Color.GhostWhite
            .BackgroundColor = Color.Lavender
            .BorderStyle = BorderStyle.None
            .CaptionBackColor = Color.RoyalBlue
            .CaptionFont = New Font("Tahoma", 10.0!, FontStyle.Bold)
            .CaptionForeColor = Color.Bisque
            .Font = New Font("Tahoma", 8.0!)
            .ParentRowsBackColor = Color.Lavender
            .ParentRowsForeColor = Color.MidnightBlue
            .SelectionBackColor = Color.Teal
            .SelectionForeColor = Color.PaleGreen
        End With

        ' Proporcionamos el formato que deseamos se muestre en el Grid para 
        ' cada una de sus celdas.

        Dim grdTableStyle1 As New DataGridTableStyle()

        With grdTableStyle1
            .AlternatingBackColor = Color.GhostWhite
            .BackColor = Color.GhostWhite
            .ForeColor = Color.MidnightBlue
            .GridLineColor = Color.RoyalBlue
            .HeaderBackColor = Color.MidnightBlue
            .HeaderFont = New Font("Tahoma", 8.0!, FontStyle.Bold)
            .HeaderForeColor = Color.Lavender
            .SelectionBackColor = Color.Teal
            .SelectionForeColor = Color.PaleGreen
            .MappingName = TABLE_NAME
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .SelectionBackColor = Color.Teal
            .SelectionForeColor = Color.PaleGreen
        End With

        ' Formato asignado a cada una de las celdas del DataGrid.

        Dim grdColStyle1 As New DataGridTextBoxColumn()

        With grdColStyle1
            .HeaderText = "ASENTAMIENTO"
            .MappingName = "Asentamiento"
            .Width = 200
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn()

        With grdColStyle2
            .HeaderText = "TIPO ASENT."
            .MappingName = "Tipo"
            .Width = 150
            .Alignment = HorizontalAlignment.Left
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn()

        With grdColStyle3
            .HeaderText = "DELEGACION  O MUNICIPIO"
            .MappingName = "Delegacion"
            .Width = 200
            .ReadOnly = True
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn()
        With grdColStyle4
            .HeaderText = "CIUDAD"
            .MappingName = "Ciudad"
            .Width = 200
            .Alignment = HorizontalAlignment.Left
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn()
        With grdColStyle5
            .HeaderText = "ESTADO"
            .MappingName = "Estado"
            .Width = 200
            .Alignment = HorizontalAlignment.Left
        End With

        ' Agregar el estilo de la columnas al DataGrid 

        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4, grdColStyle5})
        DataGrid1.TableStyles.Add(grdTableStyle1)

    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        mtxtColonia.Text = Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))
        txtTipoAs.Text = Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 1))
        txtDelegacion.Text = Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2))
        txtCity.Text = Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 3))
        txtEstado.Text = Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 4))
    End Sub

    Private Sub cbCopos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCopos.SelectedIndexChanged

        If Not cbCopos.SelectedValue Is Nothing And lFirstTime = False Then
            txtCopos.Text = cbCopos.SelectedValue.ToString()
            BindDataGrid()
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim dsAgil As New DataSet()
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim strUpdate As String
        Dim strInsert As String
        Dim daPLD As New SqlDataAdapter(cm2)
        Dim drPLD As DataRow

        ' Declaración de variables de datos

        Dim lCorrecto As Boolean

        ' El siguiente Stored Procedure trae todos los atributos de todas las Plazas

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Datos_PLD WHERE Cliente = " & txtPassword.Text
            .Connection = cnAgil
        End With
        daPLD.Fill(dsAgil, "Datos")

        lCorrecto = True

        ' Falta realizar algunas validaciones.   Por ejemplo, que no se deje la dirección 
        ' en(blanco)

        If txtCopos.Text = "" Then
            MsgBox("Debe introducirse un Código Postal existente", MsgBoxStyle.Critical, "Error de Validación")
            lCorrecto = False
        End If

        If mtxtColonia.Text = "" Or txtTipoAs.Text = "" Or txtDelegacion.Text = "" Or txtEstado.Text = "" Then
            MsgBox("Debe seleccionar un Registro del Grid que se muestra para llenar estos campos", MsgBoxStyle.Critical, "Error de Validación")
            lCorrecto = False
        End If

        mtxtColonia.Text = Mid(mtxtColonia.Text, 1, 60)
        txtTipoAs.Text = Mid(txtTipoAs.Text, 1, 60)
        txtDelegacion.Text = Mid(txtDelegacion.Text, 1, 60)
        txtCity.Text = Mid(txtCity.Text, 1, 60)
        txtEstado.Text = Mid(txtEstado.Text, 1, 60)

        If lCorrecto = True Then

            strUpdate = "UPDATE Clientes SET CURP = '" & mtxtCURP.Text & "'"
            strUpdate = strUpdate & ", PaisNacimiento = '" & txtPaisNac.Text & "'"
            strUpdate = strUpdate & ", Nacionalidad = '" & txtNacion.Text & "'"
            strUpdate = strUpdate & ", Genero = '" & cbGenero.SelectedItem & "'"
            strUpdate = strUpdate & ", SerieFiel = '" & txtFiel.Text & "'"
            strUpdate = strUpdate & " WHERE Cliente = '" & txtPassword.Text & "'"
            Try
                cnAgil.Open()
                cm1 = New SqlCommand(strUpdate, cnAgil)
                cm1.ExecuteNonQuery()
          
            Catch eException As Exception
                MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje")
            End Try
        End If


        If dsAgil.Tables("Datos").Rows.Count > 0 Then

            If lCorrecto = True Then

                strUpdate = "UPDATE Datos_PLD SET PLD_Calle = '" & txtCalle.Text & "'"
                strUpdate = strUpdate & ", PLD_Numext = '" & txtNext.Text & "'"
                strUpdate = strUpdate & ", PLD_Numint = '" & txtNint.Text & "'"
                strUpdate = strUpdate & ", PLD_Copos = '" & cbCopos.SelectedValue.ToString & "'"
                strUpdate = strUpdate & ", PLD_Asentamiento = '" & mtxtColonia.Text & "'"
                strUpdate = strUpdate & ", PLD_Tipoasent = '" & txtTipoAs.Text & "'"
                strUpdate = strUpdate & ", PLD_Delegacion = '" & txtDelegacion.Text & "'"
                strUpdate = strUpdate & ", PLD_Ciudad = '" & txtCity.Text & "'"
                strUpdate = strUpdate & ", PLD_Estado = '" & txtEstado.Text & "'"
                strUpdate = strUpdate & ", PLD_ClaveAE = '" & ComboBox1.SelectedValue & "'"
                strUpdate = strUpdate & ", PLD_EstadoNac = '" & txtEdoNac.Text & "'"
                strUpdate = strUpdate & " WHERE Cliente = '" & txtPassword.Text & "'"
                Try
                    cm1 = New SqlCommand(strUpdate, cnAgil)
                    cm1.ExecuteNonQuery()
          
                Catch eException As Exception
                    MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje")
                End Try
            End If

        Else

            If lCorrecto = True Then
                strInsert = "INSERT INTO Datos_PLD (Cliente, PLD_Calle, PLD_Numext, PLD_Numint, PLD_Copos, PLD_Asentamiento, PLD_Tipoasent, PLD_Delegacion, PLD_Ciudad, PLD_Estado, PLD_ClaveAE, PLD_EstadoNac)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & txtPassword.Text & "', '"
                strInsert = strInsert & txtCalle.Text & "', '"
                strInsert = strInsert & txtNext.Text & "', '"
                strInsert = strInsert & txtNint.Text & "', '"
                strInsert = strInsert & txtCopos.Text & "', '"
                strInsert = strInsert & mtxtColonia.Text & "', '"
                strInsert = strInsert & txtTipoAs.Text & "', '"
                strInsert = strInsert & txtDelegacion.Text & "', '"
                strInsert = strInsert & txtCity.Text & "', '"
                strInsert = strInsert & txtEstado.Text & "', '"
                strInsert = strInsert & ComboBox1.SelectedValue.ToString & "', '"
                strInsert = strInsert & txtEdoNac.Text & "'"
                strInsert = strInsert & ")"
                Try

                    cm1 = New SqlCommand(strInsert, cnAgil)
                    cm1.ExecuteNonQuery()

                Catch eException As Exception
                    MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
                End Try

            End If

        End If

        cnAgil.Close()
        cnAgil.Dispose()
        cm1.Dispose()

        MsgBox("Se Actualizaron Adecuadamente los Datos", MsgBoxStyle.Information, "Mensaje del Sistema")

    End Sub

    Private Sub txtCalle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCalle.TextChanged

    End Sub
End Class