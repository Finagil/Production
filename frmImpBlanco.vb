Option Explicit On

Imports System.Data.SqlClient
Imports CrystalDecisions.Shared

Public Class frmImpBlanco

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim i As Integer
        Dim cInicio As String
        Dim cFecha As String
        Dim cAnexo As String
        Dim cFPago As String
        Dim cCusnam As String
        Dim cRFC As String
        Dim cCalle As String
        Dim cColonia As String
        Dim cCopos As String
        Dim cDelegacion As String
        Dim cEstado As String
        Dim cImpLetra As String
        Dim y As Integer
        Dim n As Integer
        Dim nSubtotal As Decimal
        Dim nIVA As Decimal
        Dim nTotal As Decimal
        Dim dsAgil As New DataSet()
        Dim dtImportes As New DataTable("Importes")
        Dim dtDatos As New DataTable("Datos")
        Dim drAdd As DataRow
        Dim newrptDocenBlanco As New rptDocenBlanco()

        Using MyReader As New _
        Microsoft.VisualBasic.FileIO.TextFieldParser("C:\DocumentosenBlanco\Factura.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("|")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        Me.demoListBox.Items.Add(currentField)
                    Next
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & _
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using

        ' Primero creo la tablas que contendras la información de los Conceptos e Importes
        ' asi como la tabla de los datos generales

        dtImportes.Columns.Add("Concepto", Type.GetType("System.String"))
        dtImportes.Columns.Add("Importe", Type.GetType("System.Decimal"))

        dtDatos.Columns.Add("Fecha", Type.GetType("System.String"))
        dtDatos.Columns.Add("Anexo", Type.GetType("System.String"))
        dtDatos.Columns.Add("Formap", Type.GetType("System.String"))
        dtDatos.Columns.Add("ImpLetra", Type.GetType("System.String"))
        dtDatos.Columns.Add("Cusnam", Type.GetType("System.String"))
        dtDatos.Columns.Add("RFC", Type.GetType("System.String"))
        dtDatos.Columns.Add("Calle", Type.GetType("System.String"))
        dtDatos.Columns.Add("Colonia", Type.GetType("System.String"))
        dtDatos.Columns.Add("Delegacion", Type.GetType("System.String"))
        dtDatos.Columns.Add("Estado", Type.GetType("System.String"))
        dtDatos.Columns.Add("Copos", Type.GetType("System.String"))
        dtDatos.Columns.Add("SubTotal", Type.GetType("System.Decimal"))
        dtDatos.Columns.Add("IVA", Type.GetType("System.Decimal"))
        dtDatos.Columns.Add("Total", Type.GetType("System.Decimal"))

        ' Obtengo los datos que necesito de Listbox

        cFecha = Mes(DTOC(Today))

        y = 0
        For i = 1 To Me.demoListBox.Items.Count - 1
            Select Case i
                Case 2
                    cAnexo = Me.demoListBox.Items(i)
                Case 5
                    cCusnam = Me.demoListBox.Items(i)
                Case 14
                    cRFC = Me.demoListBox.Items(i)
                Case 6
                    cCalle = Me.demoListBox.Items(i)
                Case 9
                    cColonia = Me.demoListBox.Items(i)
                Case 10
                    cDelegacion = Me.demoListBox.Items(i)
                Case 11
                    cEstado = Me.demoListBox.Items(i)
                Case 12
                    cCopos = Me.demoListBox.Items(i)
            End Select
            If Me.demoListBox.Items(i) = "D1" Then
                cInicio = Me.demoListBox.Items(i)
                n = 0
            End If
            If cInicio = "D1" Then
                n += 1
                Select Case n
                    Case 9
                        drAdd = dtImportes.NewRow()
                        drAdd("Concepto") = Me.demoListBox.Items(i)
                    Case 11
                        drAdd("Importe") = Me.demoListBox.Items(i)
                        dtImportes.Rows.Add(drAdd)
                End Select
            End If
            If Me.demoListBox.Items(i) = "S1" Then
                cInicio = Me.demoListBox.Items(i)
            End If
            If cInicio = "S1" Then
                y += 1
                Select Case y
                    Case 6
                        nSubtotal = Me.demoListBox.Items(i)
                    Case 7
                        nIVA = Me.demoListBox.Items(i)
                    Case 8
                        nTotal = Me.demoListBox.Items(i)
                    Case 9
                        cImpLetra = Me.demoListBox.Items(i)
                End Select
            End If
            If Me.demoListBox.Items(i) = "Z1" Then
                cInicio = Me.demoListBox.Items(i)
                y = 0
            End If
            If cInicio = "Z1" Then
                y += 1
                Select Case y
                    Case 6
                        cFPago = Me.demoListBox.Items(i)
                End Select
            End If
        Next
        '   cFecha = "20" & Mid(cFecha, 7, 2) & Mid(cFecha, 4, 2) & Mid(cFecha, 1, 2)

        drAdd = dtDatos.NewRow()
        drAdd("Fecha") = cFecha
        drAdd("Anexo") = cAnexo
        drAdd("Formap") = cFPago
        drAdd("ImpLetra") = cImpLetra
        drAdd("Cusnam") = cCusnam
        drAdd("RFC") = cRFC
        drAdd("Calle") = cCalle
        drAdd("Colonia") = cColonia
        drAdd("Delegacion") = cDelegacion
        drAdd("Estado") = cEstado
        drAdd("Copos") = cCopos
        drAdd("SubTotal") = nSubtotal
        drAdd("IVA") = nIVA
        drAdd("Total") = nTotal
        dtDatos.Rows.Add(drAdd)

        dsAgil.Tables.Add(dtDatos)
        dsAgil.Tables.Add(dtImportes)

        ' Descomentar la siguiente línea en caso de que se deseara modificar el reporte rptDocBlanco
        'dsAgil.WriteXml("C:\Schema29.xml", XmlWriteMode.WriteSchema)

        CrystalReportViewer1.Visible = True
        newrptDocenBlanco.SetDataSource(dsAgil)
        CrystalReportViewer1.ReportSource = newrptDocenBlanco

        Dim FileToDelete As String

        FileToDelete = "C:\DocumentosenBlanco\Factura.txt"

        If System.IO.File.Exists(FileToDelete) = True Then
            If System.IO.File.Exists(FileToDelete) = True Then
                System.IO.File.Delete(FileToDelete)
            End If
        End If

    End Sub

End Class
