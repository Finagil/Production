Option Explicit On

Imports System.Math
Imports System.Data.SqlClient
Imports System.IO


Public Class frmCheckList
    Dim cBotonActiva As Boolean
    Dim cIdentificacionOf As String = "NO"
    Dim cRFC As String = "NO"
    Dim cActaNacimiento As String = "NO"
    Dim cActaMatrimonio As String = "NO"
    Dim cRelacionPat As String = "NO"
    Dim cComprobanteDom As String = "NO"
    Dim cComprobanteIng As String = "NO"
    Dim cEdosFinancieros As String = "NO"
    Dim cEdosCtaBancaria As String = "NO"
    Dim cIdentificacionOfAval As String = "NO"
    Dim cRFCAval As String = "NO"
    Dim cActaNacimientoAval As String = "NO"
    Dim cActaMatrimonioAval As String = "NO"
    Dim cRelacionPatAval As String = "NO"
    Dim cComprobanteDomAval As String = "NO"
    Dim cComprobanteIngAval As String = "NO"
    Dim cSolicitud As String = "NO"
    Dim cAutorizacionBuro As String = "NO"
    Dim cEscriturasBienes As String = "NO"
    Dim cFacturasEq As String = "NO"
    Dim cCartaConstancia As String = "NO"

    Public Sub New(ByVal cAnexo As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtAnexo.Text = cAnexo

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm2 As New SqlCommand()
        Dim daDocumento As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()
        Dim drDocument As DataRow

        Dim cAnexo As String

        Me.Text = "Registro de Documentación del Contrato " & txtAnexo.Text
        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)
        cBotonActiva = False
        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Documentos WHERE Anexo = " & "'" & cAnexo & "'"
            .Connection = cnAgil
        End With

        daDocumento.Fill(dsAgil, "Datos")
        If dsAgil.Tables("Datos").Rows.Count > 0 Then
            drDocument = dsAgil.Tables("Datos").Rows(0)
            cBotonActiva = True
            If drDocument("IdenOf") = "SI" Then
                clIdentificacionOf.Checked = True
            End If
            If drDocument("RFC1") = "SI" Then
                clRFC.Checked = True
            End If
            If drDocument("ActaNac") = "SI" Then
                clActaNacimiento.Checked = True
            End If
            If drDocument("ActaMat") = "SI" Then
                clActaMatrimonio.Checked = True
            End If
            If drDocument("RelaPat") = "SI" Then
                clRelacionPat.Checked = True
            End If
            If drDocument("CompDom") = "SI" Then
                clComprobanteDom.Checked = True
            End If
            If drDocument("CompIng") = "SI" Then
                clComprobanteIng.Checked = True
            End If

            If drDocument("EdosFin") = "SI" Then
                clEdosFinancieros.Checked = True
            End If
            If drDocument("EdosCtaB") = "SI" Then
                clEdosCtaBancaria.Checked = True
            End If
            If drDocument("IdenOfAv") = "SI" Then
                clIdentificacionOfAval.Checked = True
            End If
            If drDocument("RFCAv") = "SI" Then
                clRFCAval.Checked = True
            End If
            If drDocument("ActaNacAv") = "SI" Then
                clActaNacimientoAval.Checked = True
            End If
            If drDocument("ActaMatAv") = "SI" Then
                clActaMatrimonioAval.Checked = True
            End If
            If drDocument("RelaPatAv") = "SI" Then
                clRelacionPatAval.Checked = True
            End If
            If drDocument("CompDomAv") = "SI" Then
                clComprobanteDomAval.Checked = True
            End If
            If drDocument("CompIngAv") = "SI" Then
                clComprobanteIngAval.Checked = True
            End If
            If drDocument("Solicitud1") = "SI" Then
                clSolicitud.Checked = True
            End If
            If drDocument("AutBuro") = "SI" Then
                clAutorizacionBuro.Checked = True
            End If
            If drDocument("EscBienes") = "SI" Then
                clEscriturasBienes.Checked = True
            End If
            If drDocument("FactuEq") = "SI" Then
                clFacturasEq.Checked = True
            End If
            If drDocument("CartaCons") = "SI" Then
                clCartaConstancia.Checked = True
            End If

        End If

        If cBotonActiva = False Then
            Button1.Enabled = True
            Button2.Enabled = False
        Else
            Button1.Enabled = False
            Button2.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()

        Dim cAnexo As String = "013890001"
        Dim strInsert As String

        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)

        If clIdentificacionOf.Checked = True Then
            cIdentificacionOf = "SI"
        End If
        If clRFC.Checked = True Then
            cRFC = "SI"
        End If
        If clActaNacimiento.Checked = True Then
            cActaNacimiento = "SI"
        End If
        If clActaMatrimonio.Checked = True Then
            cActaMatrimonio = "SI"
        End If
        If clRelacionPat.Checked = True Then
            cRelacionPat = "SI"
        End If
        If clComprobanteDom.Checked = True Then
            cComprobanteDom = "SI"
        End If
        If clComprobanteIng.Checked = True Then
            cComprobanteIng = "SI"
        End If

        If clEdosFinancieros.Checked = True Then
            cEdosFinancieros = "SI"
        End If
        If clEdosCtaBancaria.Checked = True Then
            cEdosCtaBancaria = "SI"
        End If
        If clIdentificacionOfAval.Checked = True Then
            cIdentificacionOfAval = "SI"
        End If
        If clRFCAval.Checked = True Then
            cRFCAval = "SI"
        End If
        If clActaNacimientoAval.Checked = True Then
            cActaNacimientoAval = "SI"
        End If
        If clActaMatrimonioAval.Checked = True Then
            cActaMatrimonioAval = "SI"
        End If
        If clRelacionPatAval.Checked = True Then
            cRelacionPatAval = "SI"
        End If
        If clComprobanteDomAval.Checked = True Then
            cComprobanteDomAval = "SI"
        End If
        If clComprobanteIngAval.Checked = True Then
            cComprobanteIngAval = "SI"
        End If
        If clSolicitud.Checked = True Then
            cSolicitud = "SI"
        End If
        If clAutorizacionBuro.Checked = True Then
            cAutorizacionBuro = "SI"
        End If
        If clEscriturasBienes.Checked = True Then
            cEscriturasBienes = "SI"
        End If
        If clFacturasEq.Checked = True Then
            cFacturasEq = "SI"
        End If
        If clCartaConstancia.Checked = True Then
            cCartaConstancia = "SI"
        End If

        cnAgil.Open()
        strInsert = "INSERT INTO Documentos(Anexo,IdenOf,RFC1,ActaNac,ActaMat,RelaPat,CompDom,CompIng,EdosFin,EdosCtaB,IdenOfAv,RFCAv,ActaNacAv,ActaMatAv,RelaPatAv,CompDomAv,CompIngAv,Solicitud1,AutBuro,EscBienes,FactuEq,CartaCons)"
        strInsert = strInsert & " VALUES ('" & cAnexo & "', '" & cIdentificacionOf & "', '"
        strInsert = strInsert & cRFC & "', '" & cActaNacimiento & "','"
        strInsert = strInsert & cActaMatrimonio & "', '" & cRelacionPat & "','"
        strInsert = strInsert & cComprobanteDom & "', '" & cComprobanteIng & "','"
        strInsert = strInsert & cEdosFinancieros & "', '" & cEdosCtaBancaria & "','"
        strInsert = strInsert & cIdentificacionOfAval & "', '" & cRFCAval & "','"
        strInsert = strInsert & cActaNacimientoAval & "', '" & cActaMatrimonioAval & "','"
        strInsert = strInsert & cRelacionPatAval & "', '" & cComprobanteDomAval & "','"
        strInsert = strInsert & cComprobanteIngAval & "', '" & cSolicitud & "','"
        strInsert = strInsert & cAutorizacionBuro & "', '" & cEscriturasBienes & "','"
        strInsert = strInsert & cFacturasEq & "','" & cCartaConstancia & "')"
        cm1 = New SqlCommand(strInsert, cnAgil)
        cm1.ExecuteNonQuery()
        cnAgil.Close()
        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim daDocumento As New SqlDataAdapter(cm2)

        Dim cAnexo As String
        Dim strUpdate As String

        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)

        If clIdentificacionOf.Checked = True Then
            cIdentificacionOf = "SI"
        End If
        If clRFC.Checked = True Then
            cRFC = "SI"
        End If
        If clActaNacimiento.Checked = True Then
            cActaNacimiento = "SI"
        End If
        If clActaMatrimonio.Checked = True Then
            cActaMatrimonio = "SI"
        End If
        If clRelacionPat.Checked = True Then
            cRelacionPat = "SI"
        End If
        If clComprobanteDom.Checked = True Then
            cComprobanteDom = "SI"
        End If
        If clComprobanteIng.Checked = True Then
            cComprobanteIng = "SI"
        End If

        If clEdosFinancieros.Checked = True Then
            cEdosFinancieros = "SI"
        End If
        If clEdosCtaBancaria.Checked = True Then
            cEdosCtaBancaria = "SI"
        End If
        If clIdentificacionOfAval.Checked = True Then
            cIdentificacionOfAval = "SI"
        End If
        If clRFCAval.Checked = True Then
            cRFCAval = "SI"
        End If
        If clActaNacimientoAval.Checked = True Then
            cActaNacimientoAval = "SI"
        End If
        If clActaMatrimonioAval.Checked = True Then
            cActaMatrimonioAval = "SI"
        End If
        If clRelacionPatAval.Checked = True Then
            cRelacionPatAval = "SI"
        End If
        If clComprobanteDomAval.Checked = True Then
            cComprobanteDomAval = "SI"
        End If
        If clComprobanteIngAval.Checked = True Then
            cComprobanteIngAval = "SI"
        End If
        If clSolicitud.Checked = True Then
            cSolicitud = "SI"
        End If
        If clAutorizacionBuro.Checked = True Then
            cAutorizacionBuro = "SI"
        End If
        If clEscriturasBienes.Checked = True Then
            cEscriturasBienes = "SI"
        End If
        If clFacturasEq.Checked = True Then
            cFacturasEq = "SI"
        End If
        If clCartaConstancia.Checked = True Then
            cCartaConstancia = "SI"
        End If

        strUpdate = "UPDATE Documentos SET IdenOf = '" & cIdentificacionOf & "'"
        strUpdate = strUpdate & ", RFC1 = '" & cRFC & "'"
        strUpdate = strUpdate & ", ActaNac = '" & cActaNacimiento & "'"
        strUpdate = strUpdate & ", ActaMat = '" & cActaMatrimonio & "'"
        strUpdate = strUpdate & ", RelaPat = '" & cRelacionPat & "'"
        strUpdate = strUpdate & ", CompDom = '" & cComprobanteDom & "'"
        strUpdate = strUpdate & ", CompIng = '" & cComprobanteIng & "'"
        strUpdate = strUpdate & ", EdosFin = '" & cEdosFinancieros & "'"
        strUpdate = strUpdate & ", EdosCtaB = '" & cEdosCtaBancaria & "'"
        strUpdate = strUpdate & ", IdenOfAv = '" & cIdentificacionOfAval & "'"
        strUpdate = strUpdate & ", RFCAv = '" & cRFCAval & "'"
        strUpdate = strUpdate & ", ActaNacAv = '" & cActaNacimientoAval & "'"
        strUpdate = strUpdate & ", ActaMatAv = '" & cActaMatrimonioAval & "'"
        strUpdate = strUpdate & ", RelaPatAv = '" & cRelacionPatAval & "'"
        strUpdate = strUpdate & ", CompDomAv = '" & cComprobanteDomAval & "'"
        strUpdate = strUpdate & ", CompIngAv = '" & cComprobanteIngAval & "'"
        strUpdate = strUpdate & ", Solicitud1 = '" & cSolicitud & "'"
        strUpdate = strUpdate & ", AutBuro = '" & cAutorizacionBuro & "'"
        strUpdate = strUpdate & ", EscBienes = '" & cEscriturasBienes & "'"
        strUpdate = strUpdate & ", FactuEq = '" & cFacturasEq & "'"
        strUpdate = strUpdate & ", CartaCons = '" & cCartaConstancia & "'"
        strUpdate = strUpdate & " WHERE Anexo = '" & cAnexo & "'"
        cnAgil.Open()
        cm1 = New SqlCommand(strUpdate, cnAgil)
        cm1.ExecuteNonQuery()
        cnAgil.Close()
        cnAgil = Nothing
        Button2.Enabled = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
