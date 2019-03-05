Option Explicit On

Imports System.Data.SqlClient

Public Class frmModCtoAvio

    ' Declaración de variables de datos de alcance privado
    Public Refaccionarios As Boolean = False
    Dim cAnexo As String = ""
    Dim cCiclo As String = ""
    Dim cAnexoOnbase As String = ""
    Public Sub New(ByVal cLinea As String)

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        cAnexo = Mid(cLinea, 1, 10)
        cAnexoOnbase = Mid(cLinea, 1, 10)
        If Mid(cLinea, 12, 6) = "PAGARE" Then
            Me.Text = "Modificar Crédito en Cuenta Corriente " & Mid(cLinea, 1, 10)
        Else
            Me.Text = "Modificar Contrato de Avío " & Mid(cLinea, 1, 10)
        End If

        cAnexo = Mid(cLinea, 1, 5) & Mid(cLinea, 7, 4)
        If Mid(cLinea, 12, 6) = "PAGARE" Then
            cCiclo = Mid(cLinea, 19, 2)
        Else
            cCiclo = Mid(cLinea, 18, 2)
        End If

        txtAnexo.Text = cLinea

    End Sub

    Private Sub frmModCtoAvio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FIRA_EstadosTableAdapter.Fill(Me.AviosDSX1.FIRA_Estados)
        Me.FIRA_EstadosTableAdapter.Fill(Me.AviosDSX2.FIRA_Estados)


        FirA_AnexosDatosTableAdapter1.Fill(AviosDSX1.FIRA_AnexosDatos, cAnexo, cCiclo)
        If AviosDSX1.FIRA_AnexosDatos.Rows.Count <= 0 Then
            Dim semilla As String = FirA_AnexosDatosTableAdapter1.Semilla(cAnexo, cCiclo)
            FirA_AnexosDatosTableAdapter1.InsertAnexo(cAnexo, cCiclo, semilla.Trim)
            FirA_AnexosDatosTableAdapter1.Fill(AviosDSX1.FIRA_AnexosDatos, cAnexo, cCiclo)
        End If
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daAvio As New SqlDataAdapter(cm1)

        Dim dsAgil As New DataSet
        Dim drAvio As DataRow

        ' Declaración de variables de datos

        Dim cEstratoActual As String = ""
        Dim cFlcan As String = ""
        Dim cNombreProductor As String = ""
        Dim cZ25 As String = ""
        Dim cZ08 As String = ""

        cbEstratoActual.Items.Add("NE ")
        cbEstratoActual.Items.Add("PD1")
        cbEstratoActual.Items.Add("PD2")
        cbEstratoActual.Items.Add("PD3")


        cbZ25.Items.Add("N")
        cbZ25.Items.Add("S")


        CmbZ08.Items.Add("N")
        CmbZ08.Items.Add("S")

        ' Aquí tengo que validar si se trata de un Contrato Terminado en cuyo caso solo se podrá
        ' consultar la información de las ministraciones otorgadas sin opción a modificar nada

        ' El siguiente Command trae los datos del contrato de Habilitación o Avío

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Avios.*, Descr FROM Avios " & _
                           "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " & _
                           "WHERE Anexo = " & "'" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
            .Connection = cnAgil
        End With

        ' Llenar el dataset lo cual abre y cierra la conexión

        daAvio.Fill(dsAgil, "Avios")

        drAvio = dsAgil.Tables("Avios").Rows(0)

        cFlcan = drAvio("Flcan")
        cNombreProductor = Trim(Mid(drAvio("Descr"), 1, 80))
        TxtContMarco.Text = SacaContratoMarcoLargo(0, cAnexo)
        txtAnexo.Text = txtAnexo.Text & "   " & cNombreProductor

        If cFlcan <> "A" Then
            gbDatosFINAGIL.Enabled = False
            gbDatosFIRA.Enabled = False
            btnGuardar.Enabled = False
        End If

        If Trim(drAvio("FechaAutorizacion")) <> "" Then
            dtpFechaAutorizacion.Value = CTOD(drAvio("FechaAutorizacion"))
        Else
            dtpFechaAutorizacion.Value = Today()
        End If

        txtIDPersona.Text = Trim(drAvio("IDPersona"))
        txtIDContrato.Text = Trim(drAvio("IDContrato"))
        txtIDDTU.Text = Trim(drAvio("IDDTU"))
        txtIDCredito.Text = Trim(drAvio("IDCredito"))
        TxtIDgarantia.Text = Trim(drAvio("IDGarantia"))
        If Trim(drAvio("GarantiaFecha")) <> "" Then
            DtGarantia.Value = CTOD(drAvio("GarantiaFecha"))
        Else
            DtGarantia.Value = "01/01/1900"
        End If

        txtLineaActual.Text = Format(drAvio("LineaActual"), "##,##0.00")
        txtHectareasActual.Text = Format(drAvio("HectareasActual"), "##,##0.00")
        CkGarantiaSinFondeo.Checked = drAvio("GarantiaSinFondeo")

        txtCostoHectarea.Text = Format(drAvio("CostoHectarea"), "##,##0.00")
        txtDiferencialFINAGIL.Text = Format(drAvio("DiferencialFINAGIL"), "##,##0.00")
        cEstratoActual = drAvio("EstratoActual")
        txtSustraeActual.Text = drAvio("SustraeActual")
        cZ25 = drAvio("Z25")
        cZ08 = drAvio("Z08")

        Select Case cEstratoActual
            Case "NE "
                cbEstratoActual.SelectedIndex = 0
            Case "PD1"
                cbEstratoActual.SelectedIndex = 1
            Case "PD2"
                cbEstratoActual.SelectedIndex = 2
            Case "PD3"
                cbEstratoActual.SelectedIndex = 3
        End Select

        Select Case cZ25
            Case "N"
                cbZ25.SelectedIndex = 0
            Case "S"
                cbZ25.SelectedIndex = 1
        End Select

        Select Case cZ08
            Case "N"
                CmbZ08.SelectedIndex = 0
            Case "S"
                CmbZ08.SelectedIndex = 1
        End Select

        cnAgil.Dispose()
        cm1.Dispose()
        BtnRefa.Visible = Refaccionarios


        ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++
        Dim TaOnbase As New GeneralDSTableAdapters.OnBaseTableAdapter
        cAnexoOnbase = "% " & CDbl(Mid(cAnexo, 2, 8)) & " %"
        If TaOnbase.ScalarCuantos(cAnexoOnbase, cAnexoOnbase) > 0 Then
            BtnOnbase.Enabled = True
        Else
            BtnOnbase.Enabled = False
        End If
        ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim strUpdate As String

        ' Declaración de variables de datos

        Dim cEstratoActual As String = "NE "

        Select Case cbEstratoActual.SelectedIndex
            Case 0
                cEstratoActual = "NE "
            Case 1
                cEstratoActual = "PD1"
            Case 2
                cEstratoActual = "PD2"
            Case 3
                cEstratoActual = "PD3"
        End Select

        Dim cZ25 As String = "N"
        Select Case cbZ25.SelectedIndex
            Case 0
                cZ25 = "N"
            Case 1
                cZ25 = "S"
        End Select

        Dim cZ08 As String = "N"
        Select Case CmbZ08.SelectedIndex
            Case 0
                cZ08 = "N"
            Case 1
                cZ08 = "S"
        End Select
        ' Debe actualizar los datos del contrato del productor seleccionado
        Dim FechaGarantia As String = ""
        If TxtIDgarantia.Text <> 0 Then
            FechaGarantia = DtGarantia.Value.ToString("yyyyMMdd")
        End If

        strUpdate = "UPDATE Avios SET"
        strUpdate = strUpdate & " FechaAutorizacion = '" & DTOC(dtpFechaAutorizacion.Value) & "',"
        strUpdate = strUpdate & " IDPersona = '" & txtIDPersona.Text & "',"
        strUpdate = strUpdate & " IDContrato = '" & txtIDContrato.Text & "',"
        strUpdate = strUpdate & " IDDTU = '" & txtIDDTU.Text & "',"
        strUpdate = strUpdate & " IDCredito = '" & txtIDCredito.Text & "',"
        strUpdate = strUpdate & " IDGarantia = " & TxtIDgarantia.Text & ","
        strUpdate = strUpdate & " GarantiaFecha = '" & FechaGarantia & "',"
        strUpdate = strUpdate & " EstratoActual = '" & cEstratoActual & "',"
        strUpdate = strUpdate & " Z25 = '" & cZ25 & "',"
        strUpdate = strUpdate & " Z08 = '" & cZ08 & "',"
        strUpdate = strUpdate & " LineaActual = " & CDbl(txtLineaActual.Text) & ","
        strUpdate = strUpdate & " HectareasActual = " & CDbl(txtHectareasActual.Text) & ","
        strUpdate = strUpdate & " CostoHectarea = " & CDbl(txtCostoHectarea.Text) & ","
        strUpdate = strUpdate & " GarantiaSinFondeo = '" & CkGarantiaSinFondeo.Checked & "',"
        strUpdate = strUpdate & " DiferencialFINAGIL = " & CDbl(txtDiferencialFINAGIL.Text)
        strUpdate = strUpdate & " WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"

        cm1 = New SqlCommand(strUpdate, cnAgil)
        cnAgil.Open()
        cm1.ExecuteNonQuery()
        cnAgil.Close()

        cnAgil.Dispose()
        cm1.Dispose()

        gbDatosFINAGIL.Enabled = False
        gbDatosFIRA.Enabled = False
        btnGuardar.Enabled = False

        Try
            FiraDatosBindingSource.EndEdit()
            Me.FirA_AnexosDatosTableAdapter1.Update(AviosDSX1.FIRA_AnexosDatos)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al Guardar Datos Fira Anexos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnRefa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefa.Click
        Dim f As New FrmAVI_Refa
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub BtnOnbase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOnbase.Click
        Dim f As New FrmDocOnbase
        f.Cadena1 = "Mesa de Control%"
        f.Cadena2 = cAnexoOnbase
        f.Titulo = Me.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        f.Dispose()
    End Sub

    Private Sub CbBEdoAcre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbBEdoAcre.SelectedIndexChanged
        If CbBEdoAcre.SelectedIndex >= 0 Then
            Me.FIRA_MunicipiosTableAdapter.Fill(Me.AviosDSX1.FIRA_Municipios, CbBEdoAcre.SelectedValue)
        End If
    End Sub

    Private Sub CmbMuniAcre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMuniAcre.SelectedIndexChanged
        If CmbMuniAcre.SelectedIndex >= 0 Then
            Me.FIRA_LocalidadesTableAdapter.Fill(Me.AviosDSX1.FIRA_Localidades, CbBEdoAcre.SelectedValue, CmbMuniAcre.SelectedValue)
        End If
    End Sub

    Private Sub CmbEdoInver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEdoInver.SelectedIndexChanged
        If CmbEdoInver.SelectedIndex >= 0 Then
            Me.FIRA_MunicipiosTableAdapter.Fill(Me.AviosDSX2.FIRA_Municipios, CmbEdoInver.SelectedValue)
        End If
    End Sub

    Private Sub CmbMuniInver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMuniInver.SelectedIndexChanged
        If CmbMuniInver.SelectedIndex >= 0 Then
            Me.FIRA_LocalidadesTableAdapter.Fill(Me.AviosDSX2.FIRA_Localidades, CmbEdoInver.SelectedValue, CmbMuniInver.SelectedValue)
        End If
    End Sub

End Class