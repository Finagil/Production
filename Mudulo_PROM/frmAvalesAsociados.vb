Option Explicit On

Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Security
Imports System.Security.Principal.WindowsIdentity

Public Class frmAvalesAsociados

    Public Sub New(ByVal cCliente As String, ByVal cName As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtPass.Text = cCliente
        txtNombre.Text = cName
    End Sub

    Dim cAnexo As String
    Dim cCiclo As String
    Dim cBorraA As String
    Dim cBorraC As String
    Dim cBorraCte As String

    Private Sub frmAvalesAsociados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As SqlConnection = New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim dsAgil As DataSet = New DataSet()
        Dim daTradicional As New SqlDataAdapter(cm1)
        Dim daAvios As New SqlDataAdapter(cm2)
        Dim daClientes As New SqlDataAdapter(cm3)
        Dim daAvales As New SqlDataAdapter(cm4)
        Dim dtAnexos As New DataTable("Tradicionales")
        Dim dtAvios As New DataTable("Habilitacion")
        Dim drAnexos As DataRow
        Dim drAvios As DataRow
        Dim drTradic As DataRow
        Dim drHabili As DataRow
        Dim nCount As Integer = 0

        ' Este Stored Procedure trae TODOS los clientes que existan en la tabla Clientes sin
        ' importar si tienen o no solicitudes dadas de alta
        If UsuarioGlobal.ToUpper = "DESARROLLO" Or UsuarioGlobal = "vely" Then
            With cm1
                .CommandType = CommandType.Text
                .CommandText = "SELECT Anexo, Tipar, flcan FROM Anexos WHERE Cliente = " & txtPass.Text
                .Connection = cnAgil
            End With
            With cm2
                .CommandType = CommandType.Text
                .CommandText = "SELECT Anexo, Avios.Ciclo, DescCiclo, Estado, Tipar, flcan FROM Avios INNER JOIN Ciclos ON Ciclos.Ciclo = Avios.Ciclo WHERE Cliente = " & txtPass.Text
                .Connection = cnAgil
            End With
        Else
            With cm1
                .CommandType = CommandType.Text
                .CommandText = "SELECT Anexo, Tipar, flcan FROM Anexos WHERE Cliente = " & txtPass.Text & " AND (Flcan = 'A' or Flcan = 'S')"
                .Connection = cnAgil
            End With
            With cm2
                .CommandType = CommandType.Text
                .CommandText = "SELECT Anexo, Avios.Ciclo, DescCiclo, Estado, Tipar, flcan FROM Avios INNER JOIN Ciclos ON Ciclos.Ciclo = Avios.Ciclo WHERE Cliente = " & txtPass.Text & " AND Flcan = 'A'"
                .Connection = cnAgil
            End With
        End If


        Try

            ' Llenar el DataSet

            daTradicional.Fill(dsAgil, "Anexos")
            daAvios.Fill(dsAgil, "Avios")

            ' Ahora creo la tabla Anexos y Avios para mostrar todos los contratos del cliente

            dtAnexos.Columns.Add("Anexo", Type.GetType("System.String"))
            dtAnexos.Columns.Add("Tipar", Type.GetType("System.String"))
            dtAnexos.Columns.Add("Flcan", Type.GetType("System.String"))

            dtAvios.Columns.Add("Anexo", Type.GetType("System.String"))
            dtAvios.Columns.Add("Ciclo", Type.GetType("System.String"))
            dtAvios.Columns.Add("DescCiclo", Type.GetType("System.String"))
            dtAvios.Columns.Add("Estado", Type.GetType("System.String"))
            dtAvios.Columns.Add("Tipar", Type.GetType("System.String"))
            dtAvios.Columns.Add("Flcan", Type.GetType("System.String"))

            If dsAgil.Tables("Anexos").Rows.Count > 0 Then
                nCount += 1
                For Each drAnexos In dsAgil.Tables("Anexos").Rows
                    drTradic = dtAnexos.NewRow()
                    drTradic("Anexo") = drAnexos("Anexo")
                    Select Case drAnexos("Tipar")
                        Case "F"
                            drTradic("Tipar") = "Financiero"
                        Case "P"
                            drTradic("Tipar") = "Puro"
                        Case "S"
                            drTradic("Tipar") = "Simple"
                        Case "R"
                            drTradic("Tipar") = "Refaccionario"
                        Case "B"
                            drTradic("Tipar") = "Full Service"
                    End Select
                    drTradic("Flcan") = "Activo"
                    dtAnexos.Rows.Add(drTradic)
                Next
            End If

            If dsAgil.Tables("Avios").Rows.Count > 0 Then
                nCount += 1
                For Each drAvios In dsAgil.Tables("Avios").Rows
                    drHabili = dtAvios.NewRow()
                    drHabili("Anexo") = drAvios("Anexo")
                    drHabili("Ciclo") = drAvios("Ciclo")
                    drHabili("DescCiclo") = drAvios("DescCiclo")
                    Select Case drAvios("Estado")
                        Case "T"
                            drHabili("Estado") = "Terminado"
                        Case "V"
                            drHabili("Estado") = "Vigente"
                    End Select
                    Select Case drAvios("Tipar")
                        Case "H"
                            drHabili("Tipar") = "Habilitacion y Avio"
                        Case "A"
                            drHabili("Tipar") = "Anticipo"
                        Case "C"
                            drHabili("Tipar") = "Cuenta Corriente"
                    End Select
                    drHabili("Flcan") = "Activo"
                    dtAvios.Rows.Add(drHabili)
                Next
            End If

            If nCount = 0 Then
                MsgBox("El Cliente NO tiene ningún Contrato", MsgBoxStyle.Information, "Mensaje del Sistema")
                Me.Close()
            Else
                DataGridView1.DataSource = dtAnexos
                DataGridView2.DataSource = dtAvios

                ' Este Stored Procedure trae TODOS los clientes que existan en la tabla Clientes sin importar 
                ' si tienen o no contratos o solicitudes generadas

                cnAgil.Open()

                With cm3
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "ContClie1"
                    .Connection = cnAgil
                End With

                With cm4
                    .CommandType = CommandType.Text
                    .CommandText = "SELECT * FROM GEN_Personalidades"
                    .Connection = cnAgil
                End With

                ComboBox1.MaxDropDownItems = 25
                ComboBox2.MaxDropDownItems = 5

                ' Llenar el DataSet a través del DataAdapter lo cual abre y cierra la conexión

                daClientes.Fill(dsAgil, "Clientes")
                daAvales.Fill(dsAgil, "Avales")

                ' Ligar la tabla Clientes del dataset dsAgil al ComboBox

                ComboBox1.DataSource = dsAgil
                ComboBox1.DisplayMember = Trim("Clientes.Descr")
                ComboBox1.ValueMember = "Clientes.Cliente"

                ComboBox2.DataSource = dsAgil
                ComboBox2.DisplayMember = Trim("Avales.DescripPers")
                ComboBox2.ValueMember = "Avales.Id_Personalidad"

            End If

        Catch eException As Exception

            MsgBox(eException.Source & " " & eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim strInsert As String

        Dim IdPers As String
        Dim cCliente As String

        IdPers = ComboBox2.SelectedValue.ToString()
        cCliente = ComboBox1.SelectedValue.ToString()

        cnAgil.Open()
        strInsert = "INSERT INTO GEN_Avales(Anexo, Ciclo, Cliente, Id_Personalidad)"
        strInsert = strInsert & " VALUES ('" & cAnexo & "', '" & cCiclo & "', '"
        strInsert = strInsert & cCliente & "', '"
        strInsert = strInsert & IdPers & "')"
        cm1 = New SqlCommand(strInsert, cnAgil)
        cm1.ExecuteNonQuery()
        cnAgil.Close()
        ActualizaGrid()

    End Sub

    Private Sub ActualizaGrid()

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daAsoc As New SqlDataAdapter(cm1)
        Dim da2 As New SqlDataAdapter
        Dim dsAgil As New DataSet()

        ' Declaración de variables de datos

        Dim nCount As Integer

        ' Con este Stored Procedure obtengo los renglones insertados en la bitacora
        ' para este cliente

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Anexo, GEN_Avales.Ciclo, DescCiclo, GEN_Avales.Cliente, Descr, GEN_Avales.Id_Personalidad, DescripPers FROM GEN_Avales INNER JOIN Clientes ON GEN_Avales.Cliente = Clientes.Cliente INNER JOIN GEN_Personalidades ON GEN_Personalidades.Id_Personalidad = GEN_Avales.Id_Personalidad LEFT JOIN Ciclos ON Ciclos.Ciclo = GEN_Avales.Ciclo WHERE Anexo = " & cAnexo
            .Connection = cnAgil
        End With

        daAsoc.Fill(dsAgil, "Asociados")
        nCount = dsAgil.Tables("Asociados").Rows.Count

        If nCount = 0 Then

            MsgBox("No hay Asociados para este Cliente-Contrato", MsgBoxStyle.Information, "Mensaje del Sistema")

            DataGridView3.Visible = False

        Else

            DataGridView3.Visible = True
            DataGridView3.DataSource = dsAgil.Tables("Asociados")

        End If

    End Sub

    Private Sub DataGridView1_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cAnexo = Trim(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        cCiclo = "  "
        ActualizaGrid()
    End Sub

    Private Sub DataGridView2_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If DataGridView2.Rows(e.RowIndex).Cells(5).Value <> "Activo" Then
            MsgBox("Este Ciclo ya no esta Vigente Selecciona Otro Contrato", MsgBoxStyle.Information, "Mensaje del Sistema")
        Else
            cAnexo = Trim(DataGridView2.Rows(e.RowIndex).Cells(0).Value)
            cCiclo = DataGridView2.Rows(e.RowIndex).Cells(1).Value
            ActualizaGrid()
        End If

    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()

        Dim strDelete As String

        strDelete = "DELETE FROM GEN_Avales WHERE Anexo = " & cBorraA & " AND Ciclo = '" & cBorraC & "'" & " AND Cliente = '" & cBorraCte & "'"
        cm1 = New SqlCommand(strDelete, cnAgil)
        cnAgil.Open()
        cm1.ExecuteNonQuery()
        cnAgil.Close()
        ActualizaGrid()

    End Sub

    Private Sub DataGridView3_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        cBorraA = Trim(DataGridView3.Rows(e.RowIndex).Cells(0).Value)
        If IsDBNull(DataGridView3.Rows(e.RowIndex).Cells(1).Value) Then
            cBorraC = ""
        Else
            cBorraC = DataGridView3.Rows(e.RowIndex).Cells(1).Value
        End If
        cBorraCte = DataGridView3.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class