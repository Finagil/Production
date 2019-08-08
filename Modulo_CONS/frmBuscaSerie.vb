Option Explicit On

Imports System.Data.SqlClient
Public Class frmBuscaSerie
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Cursor.Current = Cursors.WaitCursor
        txtDetalle.Clear()
        BuscaTRadicionales()
        BuscaAvio()

        BuscaFullService()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub DataGridView2_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
        If DataGridView2.Rows.Count > 1 Then
            txtDetalle.Text = DataGridView2.Rows(e.RowIndex).Cells(9).Value
        End If
    End Sub

    Sub BuscaTRadicionales()
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim drRenglon As DataRow
        Dim drRegistro As DataRow
        Dim drEncontrados As DataRowCollection
        Dim daActivo1 As New SqlDataAdapter(cm1)
        Dim daActivo2 As New SqlDataAdapter(cm2)
        Dim daActivo3 As New SqlDataAdapter(cm4)
        Dim daPrenda As New SqlDataAdapter(cm3)
        Dim dtBusqueda As DataTable

        Dim nCount As Integer
        Dim cString As String
        Dim cStatus As String

        cString = (txtBuscar.Text).ToUpper

        ' El siguiente Stored Procedure trae todos los contratos en los que encuentre
        ' el dato solicitado

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BuscaSerie"
            .Connection = cnAgil
            .Parameters.Add("@Dato", SqlDbType.NVarChar)
            .Parameters(0).Value = cString
        End With

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BuscaMotor"
            .Connection = cnAgil
            .Parameters.Add("@Dato", SqlDbType.NVarChar)
            .Parameters(0).Value = cString
        End With

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BuscaPrenda"
            .Connection = cnAgil
            .Parameters.Add("@Dato", SqlDbType.NVarChar)
            .Parameters(0).Value = cString
        End With

        With cm4
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BuscaPlaca"
            .Connection = cnAgil
            .Parameters.Add("@Dato", SqlDbType.NVarChar)
            .Parameters(0).Value = cString
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daActivo1.Fill(dsAgil, "Activo1")
        daActivo2.Fill(dsAgil, "Activo2")
        daActivo3.Fill(dsAgil, "Activo3")
        daPrenda.Fill(dsAgil, "Prenda")
        daPrenda.Fill(dsAgil, "FullService")

        ' Defino la Tabla que va a mostrar los datos en el Reporte

        dtBusqueda = New DataTable("Temporal")
        dtBusqueda.Columns.Add("Contrato", Type.GetType("System.String"))
        dtBusqueda.Columns.Add("Status", Type.GetType("System.String"))
        dtBusqueda.Columns.Add("Nombre", Type.GetType("System.String"))
        dtBusqueda.Columns.Add("Factura", Type.GetType("System.String"))
        dtBusqueda.Columns.Add("Proveedor", Type.GetType("System.String"))
        dtBusqueda.Columns.Add("Serie", Type.GetType("System.String"))
        dtBusqueda.Columns.Add("Motor", Type.GetType("System.String"))
        dtBusqueda.Columns.Add("Placa", Type.GetType("System.String"))
        dtBusqueda.Columns.Add("Modelo", Type.GetType("System.String"))
        dtBusqueda.Columns.Add("Como", Type.GetType("System.String"))
        dtBusqueda.Columns.Add("Detalle", Type.GetType("System.String"))
        dtBusqueda.Clear()

        drEncontrados = dsAgil.Tables("Activo1").Rows

        For Each drRenglon In drEncontrados
            Select Case drRenglon("Flcan")
                Case "A"
                    cStatus = "ACT"
                Case "S"
                    cStatus = "SUS"
                Case "T"
                    cStatus = "TER"
                Case "W"
                    cStatus = "TCS"
                Case "C"
                    cStatus = "CAN"
                Case "B"
                    cStatus = "BAJ"
            End Select
            drRegistro = dtBusqueda.NewRow()
            drRegistro("Contrato") = Mid(drRenglon("Anexo"), 1, 5) & "/" & Mid(drRenglon("Anexo"), 6, 4)
            drRegistro("Status") = cStatus
            drRegistro("Nombre") = drRenglon("Descr")
            drRegistro("Factura") = drRenglon("Factura")
            drRegistro("Proveedor") = drRenglon("Proveedor")
            drRegistro("Serie") = drRenglon("Serie")
            drRegistro("Motor") = drRenglon("Motor")
            drRegistro("Modelo") = drRenglon("Modelo")
            drRegistro("Placa") = drRenglon("Placa")
            drRegistro("Como") = "Financiado"
            drRegistro("Detalle") = drRenglon("Detalle")
            dtBusqueda.Rows.Add(drRegistro)
        Next

        drEncontrados = dsAgil.Tables("Activo2").Rows
        For Each drRenglon In drEncontrados
            Select Case drRenglon("Flcan")
                Case "A"
                    cStatus = "ACT"
                Case "S"
                    cStatus = "SUS"
                Case "T"
                    cStatus = "TER"
                Case "W"
                    cStatus = "TCS"
                Case "C"
                    cStatus = "CAN"
                Case "B"
                    cStatus = "BAJ"
            End Select
            drRegistro = dtBusqueda.NewRow()
            drRegistro("Contrato") = Mid(drRenglon("Anexo"), 1, 5) & "/" & Mid(drRenglon("Anexo"), 6, 4)
            drRegistro("Status") = cStatus
            drRegistro("Nombre") = drRenglon("Descr")
            drRegistro("Factura") = drRenglon("Factura")
            drRegistro("Proveedor") = drRenglon("Proveedor")
            drRegistro("Serie") = drRenglon("Serie")
            drRegistro("Motor") = drRenglon("Motor")
            drRegistro("Placa") = drRenglon("Placa")
            drRegistro("Modelo") = drRenglon("Modelo")
            drRegistro("Como") = "Financiado"
            drRegistro("Detalle") = drRenglon("Detalle")
            dtBusqueda.Rows.Add(drRegistro)
        Next

        drEncontrados = dsAgil.Tables("Activo3").Rows
        For Each drRenglon In drEncontrados
            Select Case drRenglon("Flcan")
                Case "A"
                    cStatus = "ACT"
                Case "S"
                    cStatus = "SUS"
                Case "T"
                    cStatus = "TER"
                Case "W"
                    cStatus = "TCS"
                Case "C"
                    cStatus = "CAN"
                Case "B"
                    cStatus = "BAJ"
            End Select
            drRegistro = dtBusqueda.NewRow()
            drRegistro("Contrato") = Mid(drRenglon("Anexo"), 1, 5) & "/" & Mid(drRenglon("Anexo"), 6, 4)
            drRegistro("Status") = cStatus
            drRegistro("Nombre") = drRenglon("Descr")
            drRegistro("Factura") = drRenglon("Factura")
            drRegistro("Proveedor") = drRenglon("Proveedor")
            drRegistro("Serie") = drRenglon("Serie")
            drRegistro("Motor") = drRenglon("Motor")
            drRegistro("Modelo") = drRenglon("Modelo")
            drRegistro("Placa") = drRenglon("Placa")
            drRegistro("Como") = "Financiado"
            drRegistro("Detalle") = drRenglon("Detalle")
            dtBusqueda.Rows.Add(drRegistro)
        Next

        drEncontrados = dsAgil.Tables("Prenda").Rows

        For Each drRenglon In drEncontrados
            Select Case drRenglon("Flcan")
                Case "A"
                    cStatus = "ACT"
                Case "S"
                    cStatus = "SUS"
                Case "T"
                    cStatus = "TER"
                Case "W"
                    cStatus = "TCS"
                Case "C"
                    cStatus = "CAN"
                Case "B"
                    cStatus = "BAJ"
            End Select
            drRegistro = dtBusqueda.NewRow()
            drRegistro("Contrato") = Mid(drRenglon("Anexo"), 1, 5) & "/" & Mid(drRenglon("Anexo"), 6, 4)
            drRegistro("Status") = cStatus
            drRegistro("Nombre") = drRenglon("Descr")
            drRegistro("Factura") = " "
            drRegistro("Proveedor") = " "
            drRegistro("Serie") = " "
            drRegistro("Motor") = " "
            drRegistro("Modelo") = " "
            drRegistro("Como") = "Garantia"
            drRegistro("Detalle") = drRenglon("Prenda")
            dtBusqueda.Rows.Add(drRegistro)
        Next

        DataGridView2.DataSource = dtBusqueda
        DataGridView2.Visible = True
    End Sub

    Sub BuscaAvio()
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daActivo1 As New SqlDataAdapter(cm1)
        Dim cString As String

        cString = (txtBuscar.Text).ToUpper

        ' El siguiente Stored Procedure trae todos los contratos en los que encuentre
        ' el dato solicitado

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BuscaEnAvio"
            .Connection = cnAgil
            .Parameters.Add("@Dato", SqlDbType.NVarChar)
            .Parameters(0).Value = cString
        End With

        daActivo1.Fill(dsAgil, "Activo1")
        DataGridView1.DataSource = dsAgil.Tables("Activo1")
        DataGridView1.Visible = True

    End Sub

    Sub BuscaFullService()
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daActivo1 As New SqlDataAdapter(cm1)
        Dim cString As String

        cString = (txtBuscar.Text).ToUpper

        ' El siguiente Stored Procedure trae todos los contratos en los que encuentre
        ' el dato solicitado

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BuscaEnFull"
            .Connection = cnAgil
            .Parameters.Add("@Dato", SqlDbType.NVarChar)
            .Parameters(0).Value = cString
        End With

        daActivo1.Fill(dsAgil, "Activo1")
        DataGridView3.DataSource = dsAgil.Tables("Activo1")
        DataGridView3.Visible = True

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        If DataGridView1.Rows.Count > 0 Then
            txtDetalle.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        End If

    End Sub
End Class
