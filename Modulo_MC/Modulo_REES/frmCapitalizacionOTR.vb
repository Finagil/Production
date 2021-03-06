Option Explicit On

Imports System.Data.SqlClient
Imports System.Math

Public Class frmCapitalizacionOTR
    Public Anexo As String
    Public NvoReestructura As String
    Public NvoEstatus As String
    Public TasaIVACliente As Decimal

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

        ' Declaraci�n de variables de datos
        Dim cFecha As String
        Dim cFeven As String
        Dim nVencimiento As Int32
        Dim nPlazoX As Int32
        Dim nIntEquipo As Decimal
        Dim nCarEquipo As Decimal
        Dim nSaldoEquipo As Decimal
        Dim nSaldoAnt As Decimal
        Dim nTasaApli As Decimal
        Dim nCount As Integer

        cFecha = FECHA_APLICACION.ToString("yyyyMMdd")

        ' El siguiente Stored Procedure trae todos los atributos de la tabla Anexos,
        ' para un anexo dado

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DatosCon1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = Anexo
        End With

        ' Con este Stored Procedure obtengo la tabla de amortizaci�n del Equipo

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TablaEquipo1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = Anexo
        End With

        ' Con este Stored Procedure obtengo la informaci�n de adeudos 
        ' capitalizados anteriormente para un contrato dado

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TraeAdeudos"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = Anexo
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexi�n

        daAnexos.Fill(dsAgil, "Anexos")
        daEdoctav.Fill(dsAgil, "Edoctav")
        daEdoctao.Fill(dsAgil, "Edoctao")

        ' Establecer la relaci�n entre Anexos y Edoctav

        relAnexoEdoctav = New DataRelation("AnexoEdoctav", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Edoctav").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctav)

        ' Validando que el contrato est� Activo

        drAnexo = dsAgil.Tables("Anexos").Rows(0)
        nCount = dsAgil.Tables("Edoctao").Rows.Count
        nTasaApli = (drAnexo("Tasas") + drAnexo("Difer")) / 1200

        If drAnexo("Flcan") <> "A" Then

            MsgBox("El contrato NO esta activo", MsgBoxStyle.OkOnly, "Mensaje")
            Me.Close()

        Else

            ' Validando que el Contrato tenga saldo insoluto 
            ' (que tenga por lo menos un mes por transcurrir) 

            drEdoctav = drAnexo.GetChildRows("AnexoEdoctav")

            nIntEquipo = 0
            nCarEquipo = 0
            nSaldoEquipo = 0

            TraeSald(drEdoctav, cFecha, nSaldoEquipo, nIntEquipo, nCarEquipo, True, drAnexo("Tipar"))

            If nSaldoEquipo = 0 Then

                MsgBox("Contrato SIN saldo insoluto", MsgBoxStyle.OkOnly, "Mensaje")
                Me.Close()

            Else

                ' Identificamos a partir de cu�l vencimiento inicia la reestructura

                nVencimiento = 0
                nPlazoX = 0
                For Each drDato In drEdoctav
                    If drDato("Nufac") = 0 And drDato("Indrec") = "S" Then
                        nPlazoX += 1
                        If nVencimiento = 0 Then
                            nVencimiento = Val(drDato("Letra"))
                            cFeven = drDato("Feven")
                            txtFven.Text = cFeven
                        End If
                    End If
                Next
                txtTap.Text = nTasaApli
                txtVen.Text = nVencimiento
                txtPzo.Text = nPlazoX

                If nPlazoX = 1 Then
                    lblPlazomax.Text = "Le queda " & nPlazoX.ToString & " mes de plazo para poder capitalizar su Adeudo"
                Else
                    lblPlazomax.Text = "Le quedan " & nPlazoX.ToString & " meses de plazo para poder capitalizar su Adeudo"
                End If

                If nCount > 0 Then
                    lblAdeudoant.Visible = True
                    lblAdeudoant.Text = "El Contrato ya cuenta con una capitalizaci�n de adeudo anterior"
                    txtAde.Text = "S"
                    nSaldoAnt = 0
                    For Each drDato In dsAgil.Tables("Edoctao").Rows
                        If drDato("Nufac") = 0 And drDato("Indrec") = "S" Then
                            If nSaldoAnt = 0 Then
                                nSaldoAnt = drDato("Saldo")
                            End If
                        End If
                    Next
                End If
                txtSant.Text = nSaldoAnt

                If nVencimiento = 0 Then
                    MsgBox("Existe alg�n ERROR en el contrato", MsgBoxStyle.OkOnly, "Mensaje")
                    Me.Close()
                End If
            End If
        End If

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()

    End Sub

    Private Sub btnIniciar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIniciar.Click

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim drDato As DataRow
        Dim dtCreaTabla As New DataTable("Adeudos")

        ' Declaraci�n de variables de datos

        Dim cFecha As String
        Dim cFeven As String
        Dim cString As String
        Dim nVencimiento As Int32
        Dim nVenciAnt As Int32
        Dim i As Integer
        Dim nPlazoX As Integer
        Dim nSaldo As Decimal
        Dim nInteres As Decimal
        Dim nCapital As Decimal
        Dim nIva As Decimal
        Dim nTasaApli As Decimal
        Dim nRenta As Decimal
        Dim nSdoAnt As Decimal
        Dim nValorIva As Decimal

        cFecha = DTOC(FECHA_APLICACION)
        nVencimiento = txtVen.Text
        nPlazoX = txtPzo.Text
        nSdoAnt = txtSant.Text
        nTasaApli = txtTap.Text
        cFeven = txtFven.Text
        txtRow.Text = 1
        nValorIva = TasaIVACliente / 100

        If Val(txtPlazo.Text) > Val(txtPzo.Text) Then
            MsgBox("El plazo m�ximo es de " & txtPzo.Text, MsgBoxStyle.OkOnly, "Mensaje")
        End If

        If Val(txtMonto.Text) > 0 And Val(txtPlazo.Text) <= nPlazoX Then

            nSaldo = txtMonto.Text + nSdoAnt
            nRenta = Round((nSaldo * nTasaApli) / (1 - Pow((1 + nTasaApli), -txtPlazo.Text)), 2)

            ' Defino una Tabla Temporal para cargar la capitalizaci�n

            dtCreaTabla.Columns.Add("Anexo", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Letra", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Feven", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Nufac", Type.GetType("System.Decimal"))
            dtCreaTabla.Columns.Add("Saldo", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Capital", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Interes", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Iva", Type.GetType("System.String"))

            For i = 1 To txtPlazo.Text
                If i = 1 And nSdoAnt > 0 Then
                    nVenciAnt = txtVen.Text - 1
                    drDato = dtCreaTabla.NewRow()
                    drDato("Anexo") = Anexo
                    drDato("Letra") = Stuff(nVenciAnt.ToString, i, 0, 3)
                    drDato("Feven") = Mid(FECHA_APLICACION.ToString, 1, 10)
                    drDato("Nufac") = 7777777
                    drDato("Saldo") = nSdoAnt
                    drDato("Capital") = -txtMonto.Text
                    drDato("Interes") = 0
                    drDato("Iva") = 0
                    dtCreaTabla.Rows.Add(drDato)
                    txtRow.Text = 0
                End If

                cString = Stuff(nVencimiento.ToString, i, 0, 3)
                If i > 1 Then
                    cFeven = DTOC(DateAdd(DateInterval.Month, 1, CTOD(cFeven)))
                End If
                nInteres = Round(nSaldo * txtTap.Text, 2)
                nCapital = Round(nRenta - nInteres, 2)
                nIva = Round(nInteres * nValorIva, 2)
                drDato = dtCreaTabla.NewRow()
                drDato("Anexo") = Anexo
                drDato("Letra") = cString
                drDato("Feven") = CTOD(cFeven).ToShortDateString
                If Val(Mid(cFeven, 7, 2)) > 25 Then
                    drDato("Feven") = DayWeek(CTOD(cFeven).ToShortDateString)
                End If
                drDato("Nufac") = 0
                drDato("Saldo") = nSaldo
                drDato("Capital") = nCapital
                drDato("Interes") = nInteres
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
        Dim ta As New ReestructDSTableAdapters.EdoctaoTableAdapter
        Dim ta1 As New ReestructDSTableAdapters.CambiosAnexosTableAdapter
        Dim nVencimiento As Int32
        Dim i As Int32
        nVencimiento = Val(txtPlazo.Text) - Val(txtRow.Text)

        'Try
        If txtAde.Text = "S" Then
            ta.BorraAdeudo(Anexo)
        End If
        Dim x(7) As String

        For i = 0 To nVencimiento
            For y As Integer = 0 To 7
                x(y) = DataGrid1.Item(i, y)
            Next
            ta.Insert(DataGrid1.Item(i, 0), DataGrid1.Item(i, 1), DTOC(DataGrid1.Item(i, 2)), 0, "S", CDec(DataGrid1.Item(i, 4)), CDec(DataGrid1.Item(i, 5)), CDec(DataGrid1.Item(i, 6)), CDec(DataGrid1.Item(i, 7)))
        Next

        Dim BLOQ As Integer = DesBloqueaContrato(Anexo) 'DESBLOQUEO MESA DE CONTROL+++++++++++++
        ta.UpdateAdeudo("S", Anexo)
        ta1.CambiaAnexoTRA("S", IIf(NvoEstatus = "VIGENTE", "", NvoEstatus), Anexo)
        BloqueaContrato(Anexo, BLOQ) '*******************BLOQUEO MESA DE CONTROL++++++++++++++++
        If NvoEstatus = "VENCIDA" Then
            ta1.DeleteReestructura(Anexo, "")
            ta1.VencidaXReestructura(Anexo, "", FECHA_APLICACION.Date)
        End If
        'Catch eException As Exception
        '    MessageBox.Show(eException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try


        MsgBox("Datos actualizados", MsgBoxStyle.Information, "Mensaje del Sistema")
        DialogResult = Windows.Forms.DialogResult.Yes

    End Sub


    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub txtPlazo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPlazo.KeyPress
        NumerosEnteros(sender, e)
    End Sub


End Class