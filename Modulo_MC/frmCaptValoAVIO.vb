Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports Microsoft.VisualBasic
Imports System.Security
Imports System.Security.Principal.WindowsIdentity

Public Class frmCaptValoAVIO
    ' Declaración de variables de conexión ADO .NET de alcance privado

    Dim cnAgil As New SqlConnection(strConn)
    Dim dtPagares As New DataTable
    Dim dtFIRA As New DataTable
    Dim dtFINAGIL As New DataTable
    Dim myKeySearch(0) As String

    ' Declaración de variables de datos de alcance privado

    Dim cAnexo As String = ""
    Dim cCiclo As String = ""
    Dim cSave As String = "I"
   
    Dim lFirstTime As Boolean = True
    Dim myIdentity As Principal.WindowsIdentity
    Dim cUsuario As String

    Public Sub New(ByVal cLinea As String)

        MyBase.New()

        'This call is required by the Windows Form Designer.

        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        cAnexo = Mid(cLinea, 1, 10)

        Me.Text = "Captura de Valores contrato de Avio " & cAnexo
     
        lblAnexo.Text = cAnexo
        txtCiclo.Text = Mid(cLinea, 12, 47)

        If Mid(cLinea, 12, 6) = "PAGARE" Then
            cCiclo = Mid(cLinea, 19, 2)
        Else
            cCiclo = Mid(cLinea, 18, 2)
        End If

        cAnexo = Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4)
      
    End Sub

    Private Sub frmCaptValoAVIO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daAvio As New SqlDataAdapter(cm1)
        Dim daCEF As New SqlDataAdapter(cm2)
    
        Dim dsAgil As New DataSet()
        Dim drAvio As DataRow
        Dim drCEF As DataRow
        Dim myColArray(0) As DataColumn

        ' Declaración de variables de datos

        Dim cFlcan As String = ""
        Dim cNombreProductor As String = ""
        Dim cRecurso As String = ""

       
        ' Aquí tengo que validar si se trata de un Contrato Terminado en cuyo caso solo se podrá
        ' consultar la información de las ministraciones otorgadas sin opción a modificar nada

        ' El siguiente Command trae los datos del contrato de Habilitación o Avío

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Avios.*, Descr, Banco, CuentaBancomer, CuentaCLABE, Nombre_Sucursal FROM Avios " & _
                           "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " & _
                           "INNER JOIN Sucursales ON Clientes.Sucursal = Sucursales.ID_Sucursal " & _
                           "WHERE Anexo = " & "'" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
            .Connection = cnAgil
        End With
        daAvio.Fill(dsAgil, "Avios")

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT Valores_Avio.* FROM Valores_Avio WHERE Anexo = " & "'" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
            .Connection = cnAgil
        End With
        daCEF.Fill(dsAgil, "CEF")

        ' Información del contrato de habilitación o avío

        drAvio = dsAgil.Tables("Avios").Rows(0)

        cFlcan = drAvio("Flcan")
        cNombreProductor = Trim(Mid(drAvio("Descr"), 1, 80))

        lblAnexo.Text = lblAnexo.Text & "   " & cNombreProductor
        TxtSucursal.Text = "Sucursal: " & Trim(drAvio("Nombre_Sucursal"))

        Select Case drAvio("Fondeo")
            Case "01"
                cRecurso = "PROPIOS"
            Case "03"
                cRecurso = "FIRA"
        End Select

        Select Case drAvio("tipar")
            Case "A"
                TxtTipo.Text = "Tipo: ANTICIPO  " & " Recursos: " & cRecurso
            Case "C"
                TxtTipo.Text = "Tipo: CUENTA CORRIENTE " & " Recursos: " & cRecurso
            Case "H"
                TxtTipo.Text = "Tipo: AVIO " & " Recursos: " & cRecurso
        End Select

        If drAvio("tipar") <> "C" Then
            Select Case drAvio("Semilla")
                Case "T"
                    TxtCultivo.Text = "Cultivo: TRIGO"
                Case "M"
                    TxtCultivo.Text = "Cultivo: MAIZ"
                Case "C"
                    TxtCultivo.Text = "Cultivo: CARTAMO"
                Case "S"
                    TxtCultivo.Text = "Cultivo: SORGO"
                Case "Y"
                    TxtCultivo.Text = "Cultivo: SOYA"
                Case Else
                    TxtCultivo.Text = "Cultivo: NO IDENTIFICADO"
            End Select
        Else
            TxtCultivo.Text = ""
        End If

        If dsAgil.Tables("CEF").Rows.Count > 0 Then
            cSave = "M"
            drCEF = dsAgil.Tables("CEF").Rows(0)

            If Trim(drCEF("CtoRatif")) = "S" Then
                rbCsi.Checked = True
                rbCno.Checked = False
                rbCna.Checked = False
            ElseIf Trim(drCEF("CtoRatif")) = "N" Then
                rbCsi.Checked = False
                rbCno.Checked = True
                rbCna.Checked = False
            Else
                rbCsi.Checked = False
                rbCno.Checked = False
                rbCna.Checked = True
            End If

            If Trim(drCEF("Pagare")) = "S" Then
                rbPsi.Checked = True
                rbPno.Checked = False
                rbPna.Checked = False
            ElseIf Trim(drCEF("Pagare")) = "N" Then
                rbPsi.Checked = False
                rbPno.Checked = True
                rbPna.Checked = False
            Else
                rbPsi.Checked = False
                rbPno.Checked = False
                rbPna.Checked = True
            End If

            If Trim(drCEF("Rug")) = "S" Then
                RdRugSi.Checked = True
                RdrugNo.Checked = False
                rdRUGna.Checked = False
            ElseIf Trim(drCEF("Rug")) = "N" Then
                RdRugSi.Checked = False
                RdrugNo.Checked = True
                rdRUGna.Checked = False
            Else
                RdRugSi.Checked = False
                RdrugNo.Checked = False
                rdRUGna.Checked = True
            End If

            If Trim(drCEF("Pld")) = "S" Then
                rdPldsi.Checked = True
                rdPldno.Checked = False
                rdPldna.Checked = False
            ElseIf Trim(drCEF("Pld")) = "N" Then
                rdPldsi.Checked = False
                rdPldno.Checked = True
                rdPldna.Checked = False
            Else
                rdPldsi.Checked = False
                rdPldno.Checked = False
                rdPldna.Checked = True
            End If

            If Trim(drCEF("Lugar")) <> "" Or Trim(drCEF("Notario")) <> "" Or Trim(drCEF("Escritura")) <> "" Then
                rbGHSi.Checked = True
                rbGHNo.Checked = False
                Label8.Visible = True
                txtLugar.Text = Trim(drCEF("Lugar"))
                txtLugar.Visible = True
                txtLugar.ReadOnly = True
                Label9.Visible = True
                txtNotaria.Text = Trim(drCEF("Notario"))
                txtNotaria.Visible = True
                txtNotaria.ReadOnly = True
                TxtValorHipo.Text = drCEF("ValorHipoteca").ToString
                TxtValorHipo.Visible = True
                TxtValorHipo.ReadOnly = True
                Label10.Visible = True
                Label12.Visible = True
                txtEscritura.Text = Trim(drCEF("Escritura"))
                txtEscritura.Visible = True
                txtEscritura.ReadOnly = True
            Else
                rbGHSi.Checked = False
                rbGHNo.Checked = True
                rbGHNa.Checked = False
            End If

            If Trim(drCEF("Escaneo")) = "S" Then
                rbEsSi.Checked = True
                rbEsNo.Checked = False
                rbEsNa.Checked = False
            ElseIf Trim(drCEF("Escaneo")) = "N" Then
                rbEsSi.Checked = False
                rbEsNo.Checked = True
                rbEsNa.Checked = False
            Else
                rbEsSi.Checked = False
                rbEsNo.Checked = False
                rbEsNa.Checked = True
            End If

            If Trim(drCEF("GPrend")) = "S" Then
                rbGsi.Checked = True
                rbGno.Checked = False
                rbGna.Checked = False
            ElseIf Trim(drCEF("GPrend")) = "N" Then
                rbGsi.Checked = False
                rbGno.Checked = True
                rbGna.Checked = False
            Else
                rbGsi.Checked = False
                rbGno.Checked = False
                rbGna.Checked = True
            End If

            txtArchivo.Text = Trim(drCEF("Sobre"))
            TxtFolder.Text = Trim(drCEF("Folder"))
            txtArchivo.ReadOnly = True
            TxtFolder.ReadOnly = True
            txtObser.Text = Trim(drCEF("Observa"))
            txtCobranza.Text = Trim(drCEF("ObCobr"))
            txtJuridico.Text = Trim(drCEF("ObJuridic"))

            cnAgil.Dispose()
            cm1.Dispose()

        End If

    End Sub

    Private Sub btnModifica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifica.Click
        btnSalvar.Enabled = True
        rbCsi.Enabled = True
        rbPsi.Enabled = True
        rbGsi.Enabled = True
        rbCno.Enabled = True
        rbPno.Enabled = True
        rbGno.Enabled = True
        rbGHSi.Enabled = True
        rbGHNo.Enabled = True
        rbEsSi.Enabled = True
        rbEsNo.Enabled = True
        rbCna.Enabled = True
        rbPna.Enabled = True
        rbGna.Enabled = True
        rbGHNa.Enabled = True
        rbEsNa.Enabled = True
        RdRugSi.Enabled = True
        RdrugNo.Enabled = True
        rdRUGna.Enabled = True
        rdPldsi.Enabled = True
        rdPldno.Enabled = True
        rdPldna.Enabled = True

        txtLugar.ReadOnly = False
        txtNotaria.ReadOnly = False
        txtEscritura.ReadOnly = False
        txtObser.ReadOnly = False
        txtCobranza.ReadOnly = False
        txtJuridico.ReadOnly = False
        txtArchivo.ReadOnly = False
        TxtFolder.ReadOnly = False
        TxtValorHipo.ReadOnly = False
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim dsAgil As New DataSet()
        Dim cm1 As New SqlCommand()
        Dim strUpdate As String
        Dim strInsert As String

        ' Declaración de variables de datos

        Dim cCtora As String
        Dim cPagare As String
        Dim cGarant As String
        Dim cGHipot As String
        Dim cEscane As String
        Dim cRug As String
        Dim cPld As String

  
        btnModifica.Enabled = False
        rbCsi.Enabled = False
        rbPsi.Enabled = False
        rbGsi.Enabled = False
        rbCno.Enabled = False
        rbPno.Enabled = False
        rbGno.Enabled = False
        rbGHSi.Enabled = False
        rbGHNo.Enabled = False
        rbEsSi.Enabled = False
        rbEsNo.Enabled = False
        rbCna.Enabled = False
        rbPna.Enabled = False
        rbGna.Enabled = False
        rbGHNa.Enabled = False
        rbEsNa.Enabled = False
        RdRugSi.Enabled = False
        RdrugNo.Enabled = False
        rdRUGna.Enabled = False
        rdPldsi.Enabled = False
        rdPldno.Enabled = False
        rdPldna.Enabled = False

        txtLugar.ReadOnly = True
        txtNotaria.ReadOnly = True
        txtEscritura.ReadOnly = True
        txtObser.ReadOnly = True
        txtCobranza.ReadOnly = True
        txtJuridico.ReadOnly = True
        txtArchivo.ReadOnly = True
        TxtFolder.ReadOnly = True
        btnSalvar.Enabled = False
        TxtValorHipo.ReadOnly = True

        If rbCsi.Checked = True Then
            cCtora = "S"
        ElseIf rbCno.Checked = True Then
            cCtora = "N"
        ElseIf rbCna.Checked = True Then
            cCtora = "NA"
        End If
        If rbPsi.Checked = True Then
            cPagare = "S"
        ElseIf rbPno.Checked = True Then
            cPagare = "N"
        ElseIf rbPna.Checked = True Then
            cPagare = "NA"
        End If
        If rbGsi.Checked = True Then
            cGarant = "S"
        ElseIf rbGno.Checked = True Then
            cGarant = "N"
        ElseIf rbGna.Checked = True Then
            cGarant = "NA"
        End If
        If rbGHSi.Checked = True Then
            cGHipot = "S"
        ElseIf rbGHNo.Checked = True Then
            cGHipot = "N"
        ElseIf rbGHNa.Checked = True Then
            cGHipot = "NA"
        End If
        If rbEsSi.Checked = True Then
            cEscane = "S"
        ElseIf rbEsNo.Checked = True Then
            cEscane = "N"
        ElseIf rbEsNa.Checked = True Then
            cEscane = "NA"
        End If
        If RdRugSi.Checked = True Then
            cRug = "S"
        ElseIf RdrugNo.Checked = True Then
            cRug = "N"
        ElseIf rdRUGna.Checked = True Then
            cRug = "NA"
        End If
        If rdPldsi.Checked = True Then
            cPld = "S"
        ElseIf rdPldno.Checked = True Then
            cPld = "N"
        ElseIf rdPldna.Checked = True Then
            cPld = "NA"
        End If

        cnAgil.Open()
        If cSave = "M" Then

            strUpdate = "UPDATE Valores_Avio SET CtoRatif = " & "'" & cCtora & "',"
            strUpdate = strUpdate & " Pagare = " & "'" & cPagare & "',"
            strUpdate = strUpdate & " GPrend = " & "'" & cGarant & "',"
            strUpdate = strUpdate & " GHipotec = " & "'" & cGHipot & "',"
            strUpdate = strUpdate & " Escaneo = " & "'" & cEscane & "',"
            strUpdate = strUpdate & " Rug = " & "'" & cRug & "',"
            strUpdate = strUpdate & " Pld = " & "'" & cPld & "',"
            strUpdate = strUpdate & " Sobre = " & "'" & txtArchivo.Text & "',"
            strUpdate = strUpdate & " Folder = " & "'" & TxtFolder.Text & "',"
            strUpdate = strUpdate & " Lugar = " & "'" & txtLugar.Text & "',"
            strUpdate = strUpdate & " Notario = " & "'" & txtNotaria.Text & "',"
            strUpdate = strUpdate & " Escritura = " & "'" & txtEscritura.Text & "',"
            strUpdate = strUpdate & " ValorHipoteca = " & "'" & Val(TxtValorHipo.Text) & "',"
            strUpdate = strUpdate & " Observa = " & "'" & txtObser.Text & "',"
            strUpdate = strUpdate & " ObCobr = " & "'" & txtCobranza.Text & "',"
            strUpdate = strUpdate & " ObJuridic = " & "'" & txtJuridico.Text & "' "
            strUpdate = strUpdate & " WHERE Anexo = " & "'" & cAnexo & "'" & " AND Ciclo = " & cCiclo
            cm1 = New SqlCommand(strUpdate, cnAgil)
            cm1.ExecuteNonQuery()
            cnAgil.Close()
            MsgBox("Datos Actualizados Correctamente", MsgBoxStyle.Critical, "Mensaje de Sistema")
        Else

            strInsert = "INSERT into Valores_Avio(Anexo,Ciclo,CtoRatif,Pagare,GPrend,GHipotec,Escaneo,Rug,Pld,Sobre,Folder,Lugar,Notario,Escritura,ValorHipoteca,Observa,ObCobr,ObJuridic)"
            strInsert = strInsert & " VALUES ('" & cAnexo & "', '" & cCiclo & "', '" & cCtora & "','" & cPagare & "','" & cGarant & "', '" & cGHipot & "', '"
            strInsert = strInsert & cEscane & "', '" & cRug & "','" & cPld & "', '"
            strInsert = strInsert & txtArchivo.Text & "', '" & TxtFolder.Text & "','" & txtLugar.Text & "', '"
            strInsert = strInsert & txtNotaria.Text & "', '" & txtEscritura.Text & "','" & Val(TxtValorHipo.Text) & "', '"
            strInsert = strInsert & txtObser.Text & "', '" & txtCobranza.Text & "','" & txtJuridico.Text & "')"
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()
            cnAgil.Close()
            MsgBox("Datos Ingresados Correctamente", MsgBoxStyle.Critical, "Mensaje de Sistema")

        End If

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub
    Private Sub rbGHSi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbGHSi.Click
        Label8.Visible = True
        txtLugar.Visible = True
        Label9.Visible = True
        txtNotaria.Visible = True
        Label10.Visible = True
        txtEscritura.Visible = True
        Label12.Visible = True
        TxtValorHipo.Visible = True
    End Sub

    Private Sub rbGHNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbGHNo.Click
        Label8.Visible = False
        txtLugar.Visible = False
        Label9.Visible = False
        txtNotaria.Visible = False
        Label10.Visible = False
        txtEscritura.Visible = False
        Label12.Visible = False
        TxtValorHipo.Visible = False
    End Sub

    Private Sub rbGHNa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGHNa.Click
        Label8.Visible = False
        txtLugar.Visible = False
        Label9.Visible = False
        txtNotaria.Visible = False
        Label10.Visible = False
        txtEscritura.Visible = False
        Label12.Visible = False
        TxtValorHipo.Visible = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class
