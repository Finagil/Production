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

    Dim cBorraA As String
    Dim cBorraC As String
    Dim cBorraCte As String

    Private Sub frmAvalesAsociados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnAgil As SqlConnection = New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim dsAgil As DataSet = New DataSet()
        Dim daClientes As New SqlDataAdapter(cm3)
        Dim daAvales As New SqlDataAdapter(cm4)
        Try

            Me.ContratosActivosTableAdapter.Fill(Me.PromocionDS.ContratosActivos, txtPass.Text)


            If Me.PromocionDS.ContratosActivos.Count = 0 Then
                MsgBox("El Cliente NO tiene ningún Contrato", MsgBoxStyle.Information, "Mensaje del Sistema")
                Me.Close()
            Else

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
                ActualizaGrid()
            End If

        Catch eException As Exception

            MsgBox(eException.Source & " " & eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If IsNothing(Me.ContratosActivosBindingSource.Current) Then
            MessageBox.Show("No hay contrato selecionado ", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim strInsert As String

        cnAgil.Open()
        strInsert = "INSERT INTO GEN_Avales(Anexo, Ciclo, Cliente, Id_Personalidad)"
        strInsert = strInsert & " VALUES ('" & Me.ContratosActivosBindingSource.Current("Anexo") & "', '" & Me.ContratosActivosBindingSource.Current("Ciclo") & "', '"
        strInsert = strInsert & ComboBox1.SelectedValue & "', '"
        strInsert = strInsert & ComboBox2.SelectedValue & "')"
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
            .CommandText = "SELECT Anexo, GEN_Avales.Ciclo, DescCiclo, GEN_Avales.Cliente, Descr, GEN_Avales.Id_Personalidad, " _
            & "DescripPers FROM GEN_Avales INNER JOIN Clientes ON GEN_Avales.Cliente = Clientes.Cliente INNER JOIN GEN_Personalidades " _
            & "On GEN_Personalidades.Id_Personalidad = GEN_Avales.Id_Personalidad LEFT JOIN Ciclos On Ciclos.Ciclo = GEN_Avales.Ciclo WHERE Anexo = " & Me.ContratosActivosBindingSource.Current("Anexo")
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

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()

        Dim strDelete As String

        strDelete = "DELETE FROM GEN_Avales WHERE Anexo = " & cBorraA & " And Ciclo = '" & cBorraC & "'" & " AND Cliente = '" & cBorraCte & "'"
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

    Private Sub ContratosActivosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ContratosActivosBindingSource.CurrentChanged
        If Not IsNothing(Me.ContratosActivosBindingSource.Current) Then
            ActualizaGrid()
        End If
    End Sub
End Class