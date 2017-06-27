' Los archivos INGRESO.PRN y COSTO.PRN surgen de la contabilidad al emitir los movimientos auxiliares de todo el año
' Las cuentas 5201 01 02 y 5201 02 02 deben conformar el archivo INGRESO.PRN
' Las cuentas 5201 01 01 y 5201 02 01 deben conformar el archivo COSTO.PRN

Option Explicit On

Imports System.Data.SqlClient
Imports System.IO

Public Class frmIntCosto

    Private Sub frmIntCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ta As New ContaDSTableAdapters.AnexosResumenTableAdapter
        Dim t As New ContaDS.AnexosResumenDataTable
        Dim r As ContaDS.AnexosResumenRow
        Dim dtCosto As New DataTable("Costo")
        Dim drCosto As DataRow
        Dim myColArray(1) As DataColumn

        ' Declaración de variables de datos

        Dim cAnexo As String
        Dim cConcepto As String
        Dim cRenglon As String
        Dim myKeySearch(0) As String
        Dim nImporte As Decimal

        Dim oArchivo As StreamReader

        ' Primero creo la tabla dtDepoRefe que será la base del reporte

        dtCosto.Columns.Add("Anexo", Type.GetType("System.String"))
        dtCosto.Columns.Add("TipoCredito", Type.GetType("System.String"))
        dtCosto.Columns.Add("Cliente", Type.GetType("System.String"))
        dtCosto.Columns.Add("Ingreso", Type.GetType("System.Decimal"))
        dtCosto.Columns.Add("Costo", Type.GetType("System.Decimal"))
        dtCosto.Columns.Add("Interes", Type.GetType("System.Decimal"))
        dtCosto.Columns.Add("Amortiza", Type.GetType("System.Decimal"))
        dtCosto.Columns.Add("Traspasos", Type.GetType("System.Decimal"))
        dtCosto.Columns.Add("Prepagos", Type.GetType("System.Decimal"))
        dtCosto.Columns.Add("Polizas", Type.GetType("System.Decimal"))

        ' Tengo que definir una llave primaria para la tabla dtCosto a fin de buscar un anexo
        ' para acumular saldos

        myColArray(0) = dtCosto.Columns("Anexo")
        dtCosto.PrimaryKey = myColArray

        If File.Exists("C:\FILES\INGRESO.txt") Then

            oArchivo = New StreamReader("C:\FILES\INGRESO.txt")

            While (oArchivo.Peek() > -1)

                cRenglon = oArchivo.ReadLine()

                cAnexo = Mid(cRenglon, 113, 10)

                If Mid(cAnexo, 6, 1) = "/" Then

                    cConcepto = Mid(cRenglon, 60, 20)

                    nImporte = 0

                    If Trim(Mid(cRenglon, 168, 20)) <> "" Then
                        nImporte = Mid(cRenglon, 168, 20)
                    ElseIf Trim(Mid(cRenglon, 142, 20)) <> "" Then
                        nImporte = Mid(cRenglon, 142, 20)
                        nImporte = nImporte * -1
                    End If

                    myKeySearch(0) = cAnexo

                    drCosto = dtCosto.Rows.Find(myKeySearch)

                    If drCosto Is Nothing Then
                        ta.FillByCon(t, cAnexo)
                        r = t.Rows(0)
                        drCosto = dtCosto.NewRow()
                        drCosto("Anexo") = cAnexo
                        drCosto("TipoCredito") = r.Descr
                        drCosto("Cliente") = r.TipoCredito
                        drCosto("Ingreso") = nImporte
                        drCosto("Costo") = 0
                        drCosto("Interes") = 0
                        drCosto("Amortiza") = 0
                        drCosto("Traspasos") = 0
                        drCosto("Prepagos") = 0
                        drCosto("Polizas") = 0
                        dtCosto.Rows.Add(drCosto)
                    Else
                        drCosto("Ingreso") += nImporte
                    End If

                End If

            End While

            oArchivo.Close()

        End If

        ' Ahora procedo a leer el archivo del costo

        If File.Exists("C:\FILES\COSTO.txt") Then

            oArchivo = New StreamReader("C:\FILES\COSTO.txt")

            While (oArchivo.Peek() > -1)

                cRenglon = oArchivo.ReadLine()

                cAnexo = Mid(cRenglon, 113, 10)

                If Mid(cAnexo, 6, 1) = "/" Then

                    cConcepto = Trim(Mid(cRenglon, 60, 20))

                    nImporte = 0

                    If Trim(Mid(cRenglon, 142, 20)) <> "" Then
                        nImporte = Mid(cRenglon, 142, 20)
                    ElseIf Trim(Mid(cRenglon, 168, 20)) <> "" Then
                        nImporte = Mid(cRenglon, 168, 20)
                        nImporte = nImporte * -1
                    End If

                    myKeySearch(0) = cAnexo

                    drCosto = dtCosto.Rows.Find(myKeySearch)

                    If drCosto Is Nothing Then
                        ta.FillByCon(t, cAnexo)
                        r = t.Rows(0)
                        drCosto = dtCosto.NewRow()
                        drCosto("Anexo") = cAnexo
                        drCosto("TipoCredito") = r.Descr
                        drCosto("Cliente") = r.TipoCredito
                        drCosto("Ingreso") = 0
                        drCosto("Costo") = nImporte
                        If cConcepto = "ALTA DE OPERACIONES" Then
                            drCosto("Amortiza") = nImporte
                            drCosto("Traspasos") = 0
                            drCosto("Prepagos") = 0
                            drCosto("Polizas") = 0
                        ElseIf cConcepto = "TRASPASOS DE CARTERA" Then
                            drCosto("Amortiza") = 0
                            drCosto("Traspasos") = nImporte
                            drCosto("Prepagos") = 0
                            drCosto("Polizas") = 0
                        ElseIf cConcepto = "INGRESOS" Then
                            drCosto("Amortiza") = 0
                            drCosto("Traspasos") = 0
                            drCosto("Prepagos") = nImporte
                            drCosto("Polizas") = 0
                        Else
                            drCosto("Amortiza") = 0
                            drCosto("Traspasos") = 0
                            drCosto("Prepagos") = 0
                            drCosto("Polizas") = nImporte
                        End If
                        drCosto("Interes") = drCosto("Ingreso") - drCosto("Costo")
                        dtCosto.Rows.Add(drCosto)
                    Else
                        drCosto("Costo") += nImporte
                        If cConcepto = "ALTA DE OPERACIONES" Then
                            drCosto("Amortiza") += nImporte
                        ElseIf cConcepto = "TRASPASOS DE CARTERA" Then
                            drCosto("Traspasos") += nImporte
                        ElseIf cConcepto = "INGRESOS" Then
                            drCosto("Prepagos") += nImporte
                        Else
                            drCosto("Polizas") += nImporte
                        End If
                        drCosto("Interes") = drCosto("Ingreso") - drCosto("Costo")
                    End If

                End If

            End While

            oArchivo.Close()

        End If

        DataGridView1.DataSource = dtCosto

    End Sub

End Class