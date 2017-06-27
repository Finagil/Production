Option Explicit On

Imports System.Data.SqlClient

Public Class frmAltaContratos

    ' Declaraci�n de variables de alcance privado

    Dim cCliente As String = ""

    Private Sub frmAltaContratos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daClientes As New SqlDataAdapter(cm1)

        cbEstrato.Items.Add("PD1")
        cbEstrato.Items.Add("PD2")
        cbEstrato.Items.Add("PD3")
        cbEstrato.SelectedIndex = 0

        cbSustrae.Items.Add("NO")
        cbSustrae.Items.Add("SI")
        cbSustrae.SelectedIndex = 0

        ' Este Stored Procedure trae los clientes que tengan numeraci�n correspondiente a SONORA

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "ContClie2"
            .Connection = cnAgil
        End With

        cbProductores.MaxDropDownItems = 25

        Try

            ' Llenar el DataSet

            daClientes.Fill(dsAgil, "Clientes")

            ' Ligar la tabla Clientes del dataset dsAgil al ComboBox

            cbProductores.DataSource = dsAgil
            cbProductores.DisplayMember = "Clientes.Descr"
            cbProductores.ValueMember = "Clientes.Cliente"

            txtProductor.Text = cbProductores.SelectedValue.ToString()

        Catch eException As Exception

            MsgBox(eException.Source & " " & eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub cbProductores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProductores.SelectedIndexChanged

        txtProductor.Text = cbProductores.SelectedValue.ToString()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim strInsert As String
        Dim strUpdate As String

        ' Declaraci�n de variables de datos

        Dim cCredito As String
        Dim cEstrato As String
        Dim cSustrae As String
        Dim cTipar As String = "H"
        Dim nCredito As Integer
        Dim nDiferencialFIRA As Decimal = 0

        ' La asignaci�n del n�mero de contrato se har� hasta este momento

        cCliente = cbProductores.SelectedValue.ToString()

        If cCliente = "" Then

            MsgBox("Selecciona un cliente de la lista", MsgBoxStyle.Critical, "Mensaje del Sistema")

        Else

            cEstrato = cbEstrato.SelectedItem
            cSustrae = cbSustrae.SelectedItem

            If cEstrato = "PD1" Then
                nDiferencialFIRA = -6
            Else
                nDiferencialFIRA = 0
            End If

            With cm1
                .CommandType = CommandType.Text
                .CommandText = "SELECT IDCredito FROM Llaves"
                .Connection = cnAgil
            End With

            cnAgil.Open()
            nCredito = CInt(cm1.ExecuteScalar()) + 1
            cCredito = Stuff(nCredito.ToString, "I", "0", 5)
            cnAgil.Close()

            'strInsert = "INSERT INTO Avios (Anexo, Tipar, Cliente, Estrato, Sustrae, FechaAutorizacion, LineaAutorizada, HectareasAnterior, FinanciamientoAnterior, HectareasActual, FinanciamientoActual, DiferencialFINAGIL, DiferencialFIRA, CostoHectarea, PrecioTonelada, ToneladasHectarea)"
            strInsert = "INSERT INTO Avios (Anexo, Tipar, Cliente, DiferencialFINAGIL)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & cCliente & "0001', '"
            strInsert = strInsert & cTipar & "', '"
            strInsert = strInsert & cCliente & "', "
            'strInsert = strInsert & cEstrato & "', '"
            'strInsert = strInsert & cSustrae & "', '"
            'strInsert = strInsert & DTOC(dtpFechaAutorizacion.Value) & "', "
            'strInsert = strInsert & CDbl(txtLineaAutorizada.Text) & ", "
            'strInsert = strInsert & CDbl(txtHectareasAnterior.Text) & ", "
            'strInsert = strInsert & CDbl(txtFinanciamientoAnterior.Text) & ", "
            'strInsert = strInsert & CDbl(txtHectareasActual.Text) & ", "
            'strInsert = strInsert & CDbl(txtFinanciamientoActual.Text) & ", "
            'strInsert = strInsert & CDbl(txtDiferencialFINAGIL.Text) & ", "
            'strInsert = strInsert & nDiferencialFIRA & ", "
            strInsert = strInsert & nDiferencialFIRA & " "
            'strInsert = strInsert & CDbl(txtCostoHectarea.Text) & ", "
            'strInsert = strInsert & CDbl(txtPrecioTonelada.Text) & ", "
            'strInsert = strInsert & CDbl(txtToneladasHectarea.Text)
            strInsert = strInsert & ")"
            Try

                cnAgil.Open()

                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()

                ' Debe actualizar el atributo IDCredito de la tabla Llaves

                'strUpdate = "UPDATE Llaves SET IDCredito = " & nCredito
                'cm1 = New SqlCommand(strUpdate, cnAgil)
                'cm1.ExecuteNonQuery()

                cnAgil.Close()

                MsgBox("Se asign� el contrato " & cCliente & "/0001" & " a este productor", MsgBoxStyle.Information, "Mensaje del Sistema")

            Catch eException As Exception
                MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
            End Try

        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class