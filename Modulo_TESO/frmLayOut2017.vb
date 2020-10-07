Option Explicit On

Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.ASCIIEncoding
Imports Microsoft.VisualBasic
Imports System.Security
Imports System.Security.Principal.WindowsIdentity

Public Class frmLayOut2017
    Inherits System.Windows.Forms.Form
    Dim dtConCtaBmer As New DataTable("ConCtaBmer")
    Dim dtSinCtaBmer As New DataTable("SinCtaBmer")
    Dim dtPagos As New DataTable("GeneraPago")
    Dim dtRevisar As New DataTable("Faltantes")

    Private Sub frmLayOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BancosTableAdapter.Fill(Me.ProductionDataSet.Bancos)

        'Dim cnAgil As New SqlConnection(strConn)
        Dim dsCxpDS As New CxpDS
        'Dim oTablaClientes As DataTable
        Dim taClientes As New CxpDSTableAdapters.TESO_Datos_LayOut_CXPTableAdapter
        Dim drDato As DataRow
        Dim drRegistro As CxpDS.TESO_Datos_LayOut_CXPRow

        Dim i As Integer
        dtConCtaBmer.Columns.Add("Nombre", Type.GetType("System.String"))
        dtConCtaBmer.Columns.Add("Contrato", Type.GetType("System.String"))
        dtConCtaBmer.Columns.Add("Importe", Type.GetType("System.String"))
        dtConCtaBmer.Columns.Add("Banco", Type.GetType("System.String"))
        dtConCtaBmer.Columns.Add("CuentaBancomer", Type.GetType("System.String"))
        dtConCtaBmer.Columns.Add("CuentaCLABE", Type.GetType("System.String"))
        dtConCtaBmer.Columns.Add("Observacion", Type.GetType("System.String"))
        dtConCtaBmer.Columns.Add("Ministracion", Type.GetType("System.String"))
        dtConCtaBmer.Columns.Add("Cliente", Type.GetType("System.String"))
        dtConCtaBmer.Columns.Add("Ciclo", Type.GetType("System.String"))

        dtSinCtaBmer = dtConCtaBmer.Clone()
        dtPagos = dtConCtaBmer.Clone()
        dtRevisar = dtConCtaBmer.Clone()
        taClientes.Fill(dsCxpDS.TESO_Datos_LayOut_CXP)
        For Each drRegistro In dsCxpDS.TESO_Datos_LayOut_CXP.Rows
            If Trim(drRegistro.Banco) = "BANCOMER" Then
                If Trim(drRegistro.CuentaBancomer) = "" Then
                    drDato = dtRevisar.NewRow()
                    drDato("Nombre") = drRegistro.Descr
                    drDato("Contrato") = Mid(drRegistro.Anexo, 1, 5) & "/" & Mid(drRegistro.Anexo, 6, 4)
                    drDato("Importe") = drRegistro.Importe
                    drDato("Banco") = drRegistro.Banco
                    drDato("CuentaBancomer") = drRegistro.CuentaBancomer
                    drDato("CuentaCLABE") = drRegistro.CuentaCLABE
                    drDato("Observacion") = "Revisa Datos"
                    drDato("Ministracion") = drRegistro.Ministracion
                    drDato("Cliente") = drRegistro.Cliente
                    drDato("Ciclo") = drRegistro.Ciclo
                    dtRevisar.Rows.Add(drDato)
                Else
                    drDato = dtConCtaBmer.NewRow()
                    drDato("Nombre") = drRegistro.Descr
                    drDato("Contrato") = Mid(drRegistro.Anexo, 1, 5) & "/" & Mid(drRegistro.Anexo, 6, 4)
                    drDato("Importe") = drRegistro.Importe
                    drDato("Banco") = drRegistro.Banco
                    drDato("CuentaBancomer") = drRegistro.CuentaBancomer
                    drDato("CuentaCLABE") = drRegistro.CuentaCLABE
                    drDato("Observacion") = "Ok"
                    drDato("Ministracion") = drRegistro.Ministracion
                    drDato("Cliente") = drRegistro.Cliente
                    drDato("Ciclo") = drRegistro.Ciclo
                    dtConCtaBmer.Rows.Add(drDato)
                End If
            Else
                If Trim(drRegistro.CuentaCLABE) = "" Then
                    drDato = dtRevisar.NewRow()
                    drDato("Nombre") = drRegistro.Descr
                    drDato("Contrato") = Mid(drRegistro.Anexo, 1, 5) & "/" & Mid(drRegistro.Anexo, 6, 4)
                    drDato("Importe") = drRegistro.Importe
                    drDato("Banco") = drRegistro.Banco
                    drDato("CuentaBancomer") = drRegistro.CuentaBancomer
                    drDato("CuentaCLABE") = drRegistro.CuentaCLABE
                    drDato("Observacion") = "Revisa Datos"
                    drDato("Ministracion") = drRegistro.Ministracion
                    drDato("Cliente") = drRegistro.Cliente
                    drDato("Ciclo") = drRegistro.Ciclo
                    dtRevisar.Rows.Add(drDato)
                Else
                    drDato = dtSinCtaBmer.NewRow()
                    drDato("Nombre") = drRegistro.Descr
                    drDato("Contrato") = Mid(drRegistro.Anexo, 1, 5) & "/" & Mid(drRegistro.Anexo, 6, 4)
                    drDato("Importe") = drRegistro.Importe
                    drDato("Banco") = drRegistro.Banco
                    drDato("CuentaBancomer") = drRegistro.CuentaBancomer
                    drDato("CuentaCLABE") = drRegistro.CuentaCLABE
                    drDato("Observacion") = "Ok"
                    drDato("Ministracion") = drRegistro.Ministracion
                    drDato("Cliente") = drRegistro.Cliente
                    drDato("Ciclo") = drRegistro.Ciclo
                    dtSinCtaBmer.Rows.Add(drDato)
                End If
            End If
        Next
        DataGridView1.DataSource = dtConCtaBmer
        DataGridView2.DataSource = dtSinCtaBmer
        i = dtRevisar.Rows.Count()
        If UsuarioGlobal.ToUpper = "LMERCADO" Then
            DataGridView1.Enabled = False
            DataGridView2.Enabled = False
            DataGridView3.Visible = False
            btnGenera.Visible = False
            Label4.Visible = False
            txtSuma.Visible = False
        Else
            If i > 0 Then
                DataGridView4.DataSource = dtRevisar
                DataGridView4.Visible = True
                Label5.Visible = True
            End If
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim drDato1 As DataRow
        Dim nImporte As Decimal
        Dim nSuma As Decimal

        drDato1 = dtPagos.NewRow()
        drDato1("Nombre") = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        drDato1("Contrato") = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        drDato1("Importe") = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        drDato1("Banco") = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        drDato1("CuentaBancomer") = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        drDato1("CuentaCLABE") = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        drDato1("Observacion") = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        drDato1("Ministracion") = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        drDato1("Cliente") = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        drDato1("Ciclo") = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        dtPagos.Rows.Add(drDato1)

        DataGridView3.DataSource = dtPagos
        nImporte = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        nSuma = Val(txtTemp.Text)
        txtTemp.Text = nSuma + nImporte
        txtSuma.Text = FormatNumber(txtTemp.Text)

        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            dtConCtaBmer.Rows.RemoveAt(row.Index)
        Next
        DataGridView1.Refresh()
        DataGridView3.Refresh()

    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        Dim drDato1 As DataRow
        Dim nImporte As Decimal
        Dim nSuma As Decimal

        drDato1 = dtPagos.NewRow()
        drDato1("Nombre") = DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value
        drDato1("Contrato") = DataGridView2.Item(1, DataGridView2.CurrentRow.Index).Value
        drDato1("Importe") = DataGridView2.Item(2, DataGridView2.CurrentRow.Index).Value
        drDato1("Banco") = DataGridView2.Item(3, DataGridView2.CurrentRow.Index).Value
        drDato1("CuentaBancomer") = DataGridView2.Item(4, DataGridView2.CurrentRow.Index).Value
        drDato1("CuentaCLABE") = DataGridView2.Item(5, DataGridView2.CurrentRow.Index).Value
        drDato1("Observacion") = DataGridView2.Item(6, DataGridView2.CurrentRow.Index).Value
        drDato1("Ministracion") = DataGridView2.Item(7, DataGridView2.CurrentRow.Index).Value
        drDato1("Cliente") = DataGridView2.Item(8, DataGridView2.CurrentRow.Index).Value
        drDato1("Ciclo") = DataGridView2.Item(9, DataGridView2.CurrentRow.Index).Value
        dtPagos.Rows.Add(drDato1)

        DataGridView3.DataSource = dtPagos
        nImporte = DataGridView2.Item(2, DataGridView2.CurrentRow.Index).Value
        nSuma = Val(txtTemp.Text)
        txtTemp.Text = nSuma + nImporte
        txtSuma.Text = FormatNumber(txtTemp.Text)

        For Each row As DataGridViewRow In DataGridView2.SelectedRows
            dtSinCtaBmer.Rows.RemoveAt(row.Index)
        Next
        DataGridView2.Refresh()
        DataGridView3.Refresh()
    End Sub

    Private Sub DataGridView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView3.DoubleClick
        Dim drDato1 As DataRow
        Dim drDato2 As DataRow
        Dim nImporte As Decimal
        Dim nSuma As Decimal

        If Trim(DataGridView3.Item(3, DataGridView3.CurrentRow.Index).Value) <> "BANCOMER" Then
            drDato1 = dtSinCtaBmer.NewRow()
            drDato1("Nombre") = DataGridView3.Item(0, DataGridView3.CurrentRow.Index).Value
            drDato1("Contrato") = DataGridView3.Item(1, DataGridView3.CurrentRow.Index).Value
            drDato1("Importe") = DataGridView3.Item(2, DataGridView3.CurrentRow.Index).Value
            drDato1("Banco") = DataGridView3.Item(3, DataGridView3.CurrentRow.Index).Value
            drDato1("CuentaBancomer") = DataGridView3.Item(4, DataGridView3.CurrentRow.Index).Value
            drDato1("CuentaCLABE") = DataGridView3.Item(5, DataGridView3.CurrentRow.Index).Value
            drDato1("Observacion") = DataGridView3.Item(6, DataGridView3.CurrentRow.Index).Value
            drDato1("Ministracion") = DataGridView3.Item(7, DataGridView3.CurrentRow.Index).Value
            drDato1("Cliente") = DataGridView3.Item(8, DataGridView3.CurrentRow.Index).Value
            drDato1("Ciclo") = DataGridView3.Item(9, DataGridView3.CurrentRow.Index).Value
            dtSinCtaBmer.Rows.Add(drDato1)

            DataGridView2.DataSource = dtSinCtaBmer
            nImporte = DataGridView3.Item(2, DataGridView3.CurrentRow.Index).Value
            nSuma = Val(txtTemp.Text)
            txtTemp.Text = nSuma - nImporte
            txtSuma.Text = FormatNumber(txtTemp.Text)

            For Each row As DataGridViewRow In DataGridView3.SelectedRows
                dtPagos.Rows.RemoveAt(row.Index)
            Next
            DataGridView3.Refresh()
            DataGridView2.Refresh()

        ElseIf Trim(DataGridView3.Item(3, DataGridView3.CurrentRow.Index).Value) = "BANCOMER" Then
            drDato2 = dtConCtaBmer.NewRow()
            drDato2("Nombre") = DataGridView3.Item(0, DataGridView3.CurrentRow.Index).Value
            drDato2("Contrato") = DataGridView3.Item(1, DataGridView3.CurrentRow.Index).Value
            drDato2("Importe") = DataGridView3.Item(2, DataGridView3.CurrentRow.Index).Value
            drDato2("Banco") = DataGridView3.Item(3, DataGridView3.CurrentRow.Index).Value
            drDato2("CuentaBancomer") = DataGridView3.Item(4, DataGridView3.CurrentRow.Index).Value
            drDato2("CuentaCLABE") = DataGridView3.Item(5, DataGridView3.CurrentRow.Index).Value
            drDato2("Observacion") = DataGridView3.Item(6, DataGridView3.CurrentRow.Index).Value
            drDato2("Ministracion") = DataGridView3.Item(7, DataGridView3.CurrentRow.Index).Value
            drDato2("Cliente") = DataGridView3.Item(8, DataGridView3.CurrentRow.Index).Value
            drDato2("Ciclo") = DataGridView3.Item(9, DataGridView3.CurrentRow.Index).Value
            dtConCtaBmer.Rows.Add(drDato2)

            DataGridView1.DataSource = dtConCtaBmer
            nImporte = DataGridView3.Item(2, DataGridView3.CurrentRow.Index).Value
            nSuma = Val(txtTemp.Text)
            txtTemp.Text = nSuma - nImporte
            txtSuma.Text = FormatNumber(txtTemp.Text)

            For Each row As DataGridViewRow In DataGridView3.SelectedRows
                dtPagos.Rows.RemoveAt(row.Index)
            Next
            DataGridView3.Refresh()
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub DataGridView4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView4.DoubleClick
        If Trim(DataGridView4.Item(3, DataGridView4.CurrentRow.Index).Value) = "" Then
            cbBanco.Visible = True
        Else
            If Trim(DataGridView4.Item(3, DataGridView4.CurrentRow.Index).Value) = "BANCOMER" Then
                Label6.Text = "Dame la Cuenta BANCOMER"
                txtCuenta.MaxLength = 10
            Else
                Label6.Text = "Dame la Cuenta CLABE"
                txtCuenta.MaxLength = 18
            End If
            Label6.Visible = True
            btnSave.Visible = True
            txtCuenta.Visible = True
        End If
    End Sub

    Private Sub cbBanco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBanco.SelectedIndexChanged
        If cbBanco.SelectedIndex = 0 Then
            Label6.Text = "Dame la Cuenta BANCOMER"
            txtCuenta.MaxLength = 10
        Else
            Label6.Text = "Dame la Cuenta CLABE"
            txtCuenta.MaxLength = 18
        End If
        Label6.Visible = True
        btnSave.Visible = True
        txtCuenta.Visible = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Val(txtCuenta.Text) = 0 Then
            MsgBox("NO se ha capturado la CUENTA", MsgBoxStyle.Information, "Mensaje")
        Else
            Dim cnAgil As New SqlConnection(strConn)
            Dim cm1 As New SqlCommand()
            Dim drDato1 As DataRow
            Dim strUpdate As String
            Dim cCliente As String = ""
            Dim cBanco As String

            cCliente = DataGridView4.Item(8, DataGridView4.CurrentRow.Index).Value
            cBanco = cbBanco.Text

            cnAgil.Open()
            If Trim(DataGridView4.Item(3, DataGridView4.CurrentRow.Index).Value) = "BANCOMER" Or cbBanco.SelectedIndex = 0 Then
                drDato1 = dtConCtaBmer.NewRow()
                drDato1("Nombre") = DataGridView4.Item(0, DataGridView4.CurrentRow.Index).Value
                drDato1("Contrato") = DataGridView4.Item(1, DataGridView4.CurrentRow.Index).Value
                drDato1("Importe") = DataGridView4.Item(2, DataGridView4.CurrentRow.Index).Value
                drDato1("Banco") = cBanco
                drDato1("CuentaBancomer") = txtCuenta.Text
                drDato1("CuentaCLABE") = DataGridView4.Item(5, DataGridView4.CurrentRow.Index).Value
                drDato1("Observacion") = "Ok"
                drDato1("Ministracion") = DataGridView4.Item(7, DataGridView4.CurrentRow.Index).Value
                drDato1("Cliente") = DataGridView4.Item(8, DataGridView4.CurrentRow.Index).Value
                drDato1("Ciclo") = DataGridView4.Item(9, DataGridView4.CurrentRow.Index).Value
                dtConCtaBmer.Rows.Add(drDato1)

                DataGridView1.DataSource = dtConCtaBmer

                strUpdate = "UPDATE Clientes Set CuentaBancomer = '" & txtCuenta.Text & "'"
                strUpdate = strUpdate & ", Banco = '" & cBanco & "'"
                strUpdate = strUpdate & ", CuentaCLABE = '" & " " & "'"
                strUpdate = strUpdate & " WHERE Cliente = '" & cCliente & "'"
                cm1 = New SqlCommand(strUpdate, cnAgil)
                cm1.ExecuteNonQuery()

                For Each row As DataGridViewRow In DataGridView4.SelectedRows
                    dtRevisar.Rows.RemoveAt(row.Index)
                Next

                DataGridView4.Refresh()
                DataGridView1.Refresh()
            Else
                drDato1 = dtSinCtaBmer.NewRow()
                drDato1("Nombre") = DataGridView4.Item(0, DataGridView4.CurrentRow.Index).Value
                drDato1("Contrato") = DataGridView4.Item(1, DataGridView4.CurrentRow.Index).Value
                drDato1("Importe") = DataGridView4.Item(2, DataGridView4.CurrentRow.Index).Value
                drDato1("Banco") = cBanco
                drDato1("CuentaBancomer") = DataGridView4.Item(4, DataGridView4.CurrentRow.Index).Value
                drDato1("CuentaCLABE") = txtCuenta.Text
                drDato1("Observacion") = "Ok"
                drDato1("Ministracion") = DataGridView4.Item(7, DataGridView4.CurrentRow.Index).Value
                drDato1("Cliente") = DataGridView4.Item(8, DataGridView4.CurrentRow.Index).Value
                drDato1("Ciclo") = DataGridView4.Item(9, DataGridView4.CurrentRow.Index).Value
                dtSinCtaBmer.Rows.Add(drDato1)

                DataGridView2.DataSource = dtSinCtaBmer

                strUpdate = "UPDATE Clientes SET CuentaCLABE = '" & txtCuenta.Text & "'"
                strUpdate = strUpdate & ", Banco = '" & cBanco & "'"
                strUpdate = strUpdate & ", CuentaBancomer = '" & " " & "'"
                strUpdate = strUpdate & " WHERE Cliente = '" & cCliente & "'"
                cm1 = New SqlCommand(strUpdate, cnAgil)
                cm1.ExecuteNonQuery()

                For Each row As DataGridViewRow In DataGridView4.SelectedRows
                    dtRevisar.Rows.RemoveAt(row.Index)
                Next
                DataGridView4.Refresh()
                DataGridView2.Refresh()
            End If

            If dtRevisar.Rows.Count() = 0 Then
                DataGridView4.Visible = False
                Label5.Visible = False
            End If

            Label6.Visible = False
            btnSave.Visible = False
            txtCuenta.Text = ""
            txtCuenta.Visible = False
            cbBanco.Visible = False
            cnAgil.Close()
            cnAgil = Nothing
        End If
    End Sub

    Private Sub btnGenera_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGenera.Click

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()

        Dim cDia As String
        Dim i As Integer
        Dim cRenglon As String
        Dim cRenglon1 As String
        Dim cImporte As String
        Dim cAnexo As String
        Dim cCiclo As String = ""
        Dim cFecha As String
        Dim cName As String
        Dim strUpdate As String
        Dim cMinistracion As String
        Dim Motivo As String
        Dim nCounter As Integer

        cDia = Mid(DTOC(Today), 7, 2) & Mid(DTOC(Today), 5, 2)
        cFecha = DTOC(Today)

        nCounter = dtPagos.Rows.Count

        Dim stmPCC As New FileStream("C:\Files\PAGO_MIXTO_AVIO_" & cDia & ".txt", FileMode.Create, FileAccess.Write, FileShare.None)
        '  Dim stmPAT As New FileStream("C:\Files\PAT" & cDia & ".txt", FileMode.Create, FileAccess.Write, FileShare.None)
        Dim stmWriter As New StreamWriter(stmPCC, System.Text.Encoding.Default)
        ' Dim stmWriter1 As New StreamWriter(stmPAT, System.Text.Encoding.Default)

        'Imprime el Archivo Plano para los Pagos con Cuenta Bancomer

        cnAgil.Open()
        For i = 0 To nCounter - 1
            cImporte = Stuff((DataGridView3.Rows(i).Cells(2).Value).ToString, "I", "0", 16)
            cName = DataGridView3.Rows(i).Cells(0).Value
            cAnexo = Mid(DataGridView3.Rows(i).Cells(1).Value, 1, 5) & Mid(DataGridView3.Rows(i).Cells(1).Value, 7, 4)
            cMinistracion = DataGridView3.Rows(i).Cells(7).Value
            cCiclo = DataGridView3.Rows(i).Cells(9).Value
            cName = cName.Replace("Ñ", "N")
            cName = cName.Replace("ñ", "n")
            cName = cName.Replace("á", "a")
            cName = cName.Replace("é", "e")
            cName = cName.Replace("í", "i")
            cName = cName.Replace("ó", "o")
            cName = cName.Replace("ú", "u")
            cName = cName.Replace("Á", "A")
            cName = cName.Replace("É", "E")
            cName = cName.Replace("Ó", "O")
            cName = cName.Replace("Ú", "U")
            cName = cName.Replace("°", "o")
            cName = cName.Replace("Ü", "U")
            cName = cName.Replace(".", "")
            cName = cName.Replace(",", "")
            cName = Mid(cName, 1, 30)
            Motivo = cAnexo & "-" & cCiclo & " FINAGIL SA DE CV "

            If Trim(DataGridView3.Rows(i).Cells(5).Value) <> "" And Trim(DataGridView3.Rows(i).Cells(3).Value) <> "BANCOMER" Then
                cRenglon = "PSC" & DataGridView3.Rows(i).Cells(5).Value & "000000000148359725MXP" & cImporte & cName & "40" & Mid(DataGridView3.Rows(i).Cells(5).Value, 1, 3) & Motivo & Mid((DataGridView3.Rows(i).Cells(1).Value).ToString, 2, 4) & Mid((DataGridView3.Rows(i).Cells(1).Value).ToString, 8, 3) & "H0" & "                  000000000000.00"
                stmWriter.WriteLine(cRenglon)
            ElseIf DataGridView3.Rows(i).Cells(5).Value <> "" And Trim(DataGridView3.Rows(i).Cells(3).Value) = "BANCOMER" Then
                cRenglon1 = "PTC00000000" & DataGridView3.Rows(i).Cells(4).Value & "000000000148359725MXP" & cImporte & Motivo & "0                  000000000000.00"
                stmWriter.WriteLine(cRenglon1)
            End If

            strUpdate = "UPDATE mFINAGIL SET FechaPago = '" & cFecha & "'"
            strUpdate = strUpdate & ", FechaDocumento = '" & cFecha & "', Tesoreria = '" & UsuarioGlobal & "', TesoreriaAut = 1"
            strUpdate = strUpdate & " WHERE Anexo = " & cAnexo & " AND Ciclo = '" & cCiclo & "' AND " & "Ministracion = " & cMinistracion
            cm1 = New SqlCommand(strUpdate, cnAgil)
            cm1.ExecuteNonQuery()
        Next

        stmWriter.Flush()
        stmPCC.Flush()
        stmPCC.Close()
        cnAgil.Close()
        MsgBox("Proceso Terminado", MsgBoxStyle.Information, "Mensaje")

    End Sub

    Private Sub btnModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifica.Click
        Dim newfrmCambioCuenta As New frmCambioCuenta()
        newfrmCambioCuenta.Show()
    End Sub

    Private Sub Inserta_CXP_MOVS()
        Dim TaPAg As New CxpDSTableAdapters.CXP_PagosTesoreriaTableAdapter
        Dim taCuent As New CxpDSTableAdapters.CXP_CuentasBancariasProvTableAdapter
        Dim taProv As New CxpDSTableAdapters.CXP_ProveedoresTableAdapter
        Dim TaMinis As New CxpDSTableAdapters.TESO_Datos_LayOut_CXPTableAdapter
        Dim tMinis As New CxpDS.TESO_Datos_LayOut_CXPDataTable
        TaMinis.Fill(tMinis)
        For Each r As CxpDS.TESO_Datos_LayOut_CXPRow In tMinis.Rows
            taCuent.InsertCuenta(r.idProveedor, r.idBancos, r.CuentaBancomer, r.CuentaCLABE, "Ministracion AV " & r.Anexo & "-" & r.Ministracion, r.Usuario, r.FechaAlta, r.Anexo & r.Ciclo & r.Ministracion)
        Next
    End Sub
End Class
