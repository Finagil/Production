Option Explicit On

Imports System.Math
Imports System.Data.SqlClient
Imports System.IO
Public Class frmConsultaCheckList

    Public Sub New(ByVal cAnexo As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtAnexo.Text = cAnexo

    End Sub

    Private Sub frmConsultaCheckList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm2 As New SqlCommand()
        Dim daDocumento As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()
        Dim drDocument As DataRow

        Dim cAnexo As String
        Me.Text = "Documentación Recabada del Contrato " & txtAnexo.Text

        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Documentos WHERE Anexo = " & "'" & cAnexo & "'"
            .Connection = cnAgil
        End With

        daDocumento.Fill(dsAgil, "Datos")
        If dsAgil.Tables("Datos").Rows.Count > 0 Then
            drDocument = dsAgil.Tables("Datos").Rows(0)

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

    End Sub
End Class