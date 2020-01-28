Option Explicit On

Imports System.Data.SqlClient

Public Class frmCapturaPMI

    ' Declaraci�n de variables de alcance privado

    Dim cAnexo As String = ""
    Dim cCiclo As String = ""

    Public Sub New(ByVal cLinea As String)

        MyBase.New()

        'This call is required by the Windows Form Designer.

        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        cAnexo = Mid(cLinea, 1, 10)
        If Mid(cLinea, 12, 6) = "PAGARE" Then
            Me.Text = "Captura de Predios y Garant�as del Cr�dito en Cuenta Corriente " & Mid(cLinea, 1, 10)
        Else
            Me.Text = "Captura de Predios y Garant�as del Contrato de Av�o " & Mid(cLinea, 1, 10)
        End If

        cAnexo = Mid(cLinea, 1, 5) & Mid(cLinea, 7, 4)
        If Mid(cLinea, 12, 6) = "PAGARE" Then
            cCiclo = Mid(cLinea, 19, 2)
        Else
            cCiclo = Mid(cLinea, 18, 2)
        End If

        txtAnexo.Text = cLinea

    End Sub

    Private Sub frmCapturaPMI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daAvio As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet
        Dim drAvio As DataRow

        ' Declaraci�n de variables de datos

        Dim cEstratoActual As String = ""
        Dim cFlcan As String = ""
        Dim cNombreProductor As String = ""

        ' Aqu� tengo que validar si se trata de un Contrato Terminado en cuyo caso solo se podr�
        ' consultar la informaci�n de los Predios y Garant�as sin opci�n a modificar nada

        ' El siguiente Command trae los datos del contrato de Av�o

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Avios.*, Descr FROM Avios INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente WHERE Anexo = " & "'" & cAnexo & "'" & " And Ciclo = " & "'" & cCiclo & "'"
            .Connection = cnAgil
        End With

        ' Llenar el dataset lo cual abre y cierra la conexi�n

        daAvio.Fill(dsAgil, "Avios")

        drAvio = dsAgil.Tables("Avios").Rows(0)

        cFlcan = drAvio("Flcan")
        cNombreProductor = Trim(Mid(drAvio("Descr"), 1, 80))

        If cFlcan <> "F" Then
            btnGuardar.Enabled = False
        End If

        txtNombreProductor.Text = cNombreProductor
        txtLineaAutorizada.Text = Format(drAvio("LineaActual"), "##,##0.00")
        txtHectareas.Text = Format(drAvio("HectareasActual"), "##,##0.0000")
        If drAvio("GarantiaPrendaria") = "SI" Then
            chkPrendaria.Checked = True
        Else
            chkPrendaria.Checked = False
        End If
        If drAvio("GarantiaHipotecaria") = "SI" Then
            chkHipotecaria.Checked = True
        Else
            chkHipotecaria.Checked = False
        End If
        txtPredios.Text = Trim(drAvio("Predios"))
        txtMuebles.Text = Trim(drAvio("Muebles"))
        txtInmuebles.Text = Trim(drAvio("Inmuebles"))

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim strUpdate As String

        ' Declaraci�n de variables de datos

        Dim cGarantiaPrendaria As String = "NO"
        Dim cGarantiaHipotecaria As String = "NO"

        If chkPrendaria.Checked = True Then
            cGarantiaPrendaria = "SI"
        End If

        If chkHipotecaria.Checked = True Then
            cGarantiaHipotecaria = "SI"
        End If

        ' Debe actualizar los datos del contrato del productor seleccionado

        strUpdate = "UPDATE Avios SET"
        strUpdate = strUpdate & " GarantiaPrendaria = '" & cGarantiaPrendaria & "', "
        strUpdate = strUpdate & " GarantiaHipotecaria = '" & cGarantiaHipotecaria & "', "
        strUpdate = strUpdate & " Predios = '" & txtPredios.Text & "',"
        strUpdate = strUpdate & " Muebles = '" & txtMuebles.Text & "',"
        strUpdate = strUpdate & " Inmuebles = '" & txtInmuebles.Text & "'"
        strUpdate = strUpdate & " WHERE Anexo = '" & cAnexo & "'" & " And Ciclo = " & "'" & cCiclo & "'"

        cm1 = New SqlCommand(strUpdate, cnAgil)
        cnAgil.Open()
        cm1.ExecuteNonQuery()
        cnAgil.Close()

        cnAgil.Dispose()
        cm1.Dispose()

        gbPredios.Enabled = False
        gbMuebles.Enabled = False
        gbInmuebles.Enabled = False
        lblHectareas.Enabled = False
        chkPrendaria.Enabled = False
        chkHipotecaria.Enabled = False
        txtHectareas.Enabled = False
        btnGuardar.Enabled = False

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

End Class