Option Explicit On

Imports System.Data.SqlClient
Imports System.Math

Public Class frmCargaGPS
    Dim cAnexo As String
    Dim cFecha As String
    Dim cFeven As String
    Dim nTasaApli As Decimal
    Dim nVencimiento As Int32
    Dim nSaldoAnt As Decimal
    Dim cAdeudo As String
    Dim Fila As Integer
    Dim CargaFinan As Decimal
    Dim CargaFinanNEW As Decimal
    Dim cCliente As String

    Public Sub New(ByVal cAnexox As String)
        InitializeComponent()
        Me.Text = "Capitalización de Adeudo del Contrato " & cAnexox
        cAnexo = Mid(cAnexox, 1, 5) & Mid(cAnexox, 7, 4)
    End Sub

    Private Sub frmCapitalizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daAnexos As New SqlDataAdapter(cm1)
        Dim daEdoctav As New SqlDataAdapter(cm2)
        Dim daEdoctao As New SqlDataAdapter(cm3)
        Dim drEdoctav As DataRow()
        Dim drAnexo As DataRow
        Dim drDato As DataRow
        Dim relAnexoEdoctav As DataRelation
        Dim Cont As Integer
        Dim nIntEquipo As Decimal
        Dim nCarEquipo As Decimal
        Dim nSaldoEquipo As Decimal


        Dim nCount As Integer


        cFecha = DTOC(Today)

        ' El siguiente Stored Procedure trae todos los atributos de la tabla Anexos,
        ' para un anexo dado

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DatosCon1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
        End With

        ' Con este Stored Procedure obtengo la tabla de amortización del Equipo

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TablaEquipo1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
        End With

        ' Con este Stored Procedure obtengo la información de adeudos 
        ' capitalizados anteriormente para un contrato dado

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TraeAdeudos"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daAnexos.Fill(dsAgil, "Anexos")
        daEdoctav.Fill(dsAgil, "Edoctav")
        daEdoctao.Fill(dsAgil, "Edoctao")

        ' Establecer la relación entre Anexos y Edoctav

        relAnexoEdoctav = New DataRelation("AnexoEdoctav", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Edoctav").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctav)

        ' Validando que el contrato esté Activo

        If dsAgil.Tables("Anexos").Rows.Count <= 0 Then
            MessageBox.Show("El anexo no existe", "Anexo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End If

        drAnexo = dsAgil.Tables("Anexos").Rows(0)
        cCliente = drAnexo("Cliente")
        nCount = dsAgil.Tables("Edoctao").Rows.Count
        nTasaApli = (drAnexo("Tasas") + drAnexo("Difer")) / 1200

        If drAnexo("Flcan") <> "A" Then
            MsgBox("El contrato NO esta activo", MsgBoxStyle.OkOnly, "Mensaje")
            Me.Close()
        Else
            drEdoctav = drAnexo.GetChildRows("AnexoEdoctav")
            nIntEquipo = 0
            nCarEquipo = 0
            nSaldoEquipo = 0

            TraeSald(drEdoctav, cFecha, nSaldoEquipo, nIntEquipo, nCarEquipo, True, drAnexo("Tipar"))

            If nSaldoEquipo = 0 Then
                MsgBox("Contrato SIN saldo insoluto", MsgBoxStyle.OkOnly, "Mensaje")
                Me.Close()
            Else
                nVencimiento = 0
                Cont = 0
                For Each drDato In drEdoctav
                    If drDato("Nufac") = 0 And drDato("Indrec") = "S" Then
                        Cont += 1
                        If nVencimiento = 0 Then
                            nVencimiento = Val(drDato("Letra"))
                            cFeven = drDato("Feven")
                        End If
                    End If
                Next

                If Cont = 1 Then
                    lblPlazomax.Text = "Le queda " & Cont.ToString & " mes de plazo para poder capitalizar su Adeudo"
                Else
                    lblPlazomax.Text = "Le quedan " & Cont.ToString & " meses de plazo para poder capitalizar su Adeudo"
                End If
                CargaFinan = 0
                If nCount > 0 Then
                    lblAdeudoant.Visible = True
                    lblAdeudoant.Text = "El Contrato ya cuenta con una capitalización de adeudo anterior"
                    cAdeudo = "S"
                    nSaldoAnt = 0
                    For Each drDato In dsAgil.Tables("Edoctao").Rows
                        If drDato("Nufac") = 0 And drDato("Indrec") = "S" Then
                            If nSaldoAnt = 0 Then
                                nSaldoAnt = drDato("Saldo")
                            End If
                            CargaFinan += drDato("Inter")
                        End If
                    Next
                End If


                If nVencimiento = 0 Then
                    MsgBox("Existe algún ERROR en el contrato", MsgBoxStyle.OkOnly, "Mensaje")
                    Me.Close()
                End If
            End If
        End If

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()

    End Sub

    Private Sub btnIniciar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        Dim drDato As DataRow
        Dim dtCreaTabla As New DataTable("Adeudos")
        Dim cString As String
        Dim nVenciAnt As Int32
        Dim i As Integer
        Dim nPlazoX As Integer
        Dim nSaldo As Decimal
        Dim nInteres As Decimal
        Dim nCapital As Decimal
        Dim nIva As Decimal
        Dim nRenta As Decimal
        Dim nValorIva As Decimal

        Fila = 1
        nValorIva = 0.16
        nPlazoX = txtPlazo.Text
        If Val(txtPlazo.Text) > Val(nPlazoX) Then
            MsgBox("El plazo máximo es de " & nPlazoX, MsgBoxStyle.OkOnly, "Mensaje")
        End If

        If Val(txtMonto.Text) > 0 And Val(txtPlazo.Text) <= nPlazoX Then

            nSaldo = txtMonto.Text + nSaldoAnt
            nRenta = Round((nSaldo * nTasaApli) / (1 - Pow((1 + nTasaApli), -txtPlazo.Text)), 2)

            ' Defino una Tabla Temporal para cargar la capitalización

            dtCreaTabla.Columns.Add("Anexo", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Letra", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Feven", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Nufac", Type.GetType("System.Decimal"))
            dtCreaTabla.Columns.Add("Saldo", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Capital", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Interes", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Iva", Type.GetType("System.String"))

            For i = 1 To txtPlazo.Text
                If i = 1 And nSaldoAnt > 0 Then
                    nVenciAnt = nVencimiento - 1
                    drDato = dtCreaTabla.NewRow()
                    drDato("Anexo") = cAnexo
                    drDato("Letra") = Stuff(nVenciAnt.ToString, i, 0, 3)
                    drDato("Feven") = Mid(Today.ToString, 1, 10)
                    drDato("Nufac") = 7777777
                    drDato("Saldo") = nSaldoAnt
                    drDato("Capital") = -txtMonto.Text
                    drDato("Interes") = 0
                    drDato("Iva") = 0
                    dtCreaTabla.Rows.Add(drDato)
                    Fila = 0
                End If

                cString = Stuff(nVencimiento.ToString, i, 0, 3)
                If i > 1 Then
                    cFeven = DTOC(DateAdd(DateInterval.Month, 1, CTOD(cFeven)))
                End If
                nInteres = Round(nSaldo * nTasaApli, 2)
                nCapital = Round(nRenta - nInteres, 2)
                nIva = Round(nInteres * nValorIva, 2)
                drDato = dtCreaTabla.NewRow()
                drDato("Anexo") = cAnexo
                drDato("Letra") = cString
                drDato("Feven") = CTOD(cFeven).ToShortDateString
                If Val(Mid(cFeven, 7, 2)) > 25 Then
                    drDato("Feven") = DayWeek(CTOD(cFeven).ToShortDateString)
                End If
                drDato("Nufac") = 0
                drDato("Saldo") = nSaldo
                drDato("Capital") = nCapital
                drDato("Interes") = nInteres
                CargaFinanNEW += nInteres
                drDato("Iva") = nIva
                dtCreaTabla.Rows.Add(drDato)
                nSaldo = nSaldo - nCapital
                nVencimiento += 1
            Next
            DataGrid1.DataSource = dtCreaTabla
            DataGrid1.Visible = True
            btnSave.Enabled = True
            btnIniciar.Enabled = False
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim strInsert As String
        Dim strUpdate As String
        Dim i As Int32

        nVencimiento = Val(txtPlazo.Text) - Fila


        Try

            cnAgil.Open()
            Dim taGps As New SegurosDSTableAdapters.GPSTableAdapter
            taGps.DeleteMismaFecha(cAnexo, cFecha)
            taGps.Insert(cAnexo, cCliente, cFecha, "GPS", "02", nVencimiento, cFecha, TaQUERY.UltimaLetra(cAnexo), txtMonto.Text + nSaldoAnt, CargaFinanNEW - CargaFinan)

            If cAdeudo = "S" Then
                With cm3
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "BorraAdeudo"
                    .Connection = cnAgil
                    .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                    .Parameters(0).Value = cAnexo
                End With
                cm3.ExecuteNonQuery()

            End If

            For i = 0 To nVencimiento
                strInsert = "INSERT INTO Edoctao( Anexo, Letra, Feven, Nufac, Indrec, Saldo, Abcap, Inter, Iva )"
                strInsert = strInsert & "VALUES('"
                strInsert = strInsert & DataGrid1.Item(i, 0) & "', '"
                strInsert = strInsert & DataGrid1.Item(i, 1) & "', '"
                strInsert = strInsert & DTOC(DataGrid1.Item(i, 2)) & "', '"
                strInsert = strInsert & DataGrid1.Item(i, 3) & "', '"
                strInsert = strInsert & "S" & "', '"
                strInsert = strInsert & DataGrid1.Item(i, 4) & "', '"
                strInsert = strInsert & DataGrid1.Item(i, 5) & "', '"
                strInsert = strInsert & DataGrid1.Item(i, 6) & "', '"
                strInsert = strInsert & DataGrid1.Item(i, 7) & "')"
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
            Next
            Dim BLOQ As Integer = DesBloqueaContrato(cAnexo) 'DESBLOQUEO MESA DE CONTROL+++++++++++++
            strUpdate = "UPDATE Anexos SET  Adeudo = 'S'" & ""
            strUpdate = strUpdate & " WHERE Anexo = '" & cAnexo & "'"
            cm2 = New SqlCommand(strUpdate, cnAgil)
            cm2.ExecuteNonQuery()
            BloqueaContrato(cAnexo, BLOQ) '*******************BLOQUEO MESA DE CONTROL++++++++++++++++
            cnAgil.Close()

        Catch eException As Exception

            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje")

        End Try

        MsgBox("Datos actualizados", MsgBoxStyle.Information, "Mensaje del Sistema")

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        btnSave.Enabled = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class