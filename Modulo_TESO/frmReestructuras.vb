Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports CrystalDecisions.Shared

Public Class frmReestructuras
    Dim dtTabla As New DataTable("Original")
    Dim dtCreaTabla As New DataTable("Adeudos")

    Public Sub New(ByVal cAnexo As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtAnexo.Text = cAnexo

    End Sub
    Private Sub frmReestructuras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Declaración de variables de conexión ADO .NET

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

        ' Declaración de variables de datos

        Dim cAnexo As String
        Dim cFecha As String
        Dim cFeven As String
        Dim cCusnam As String
        Dim nVencimiento As Int32
        Dim nPlazo As Int32
        Dim nIntEquipo As Decimal
        Dim nCarEquipo As Decimal
        Dim nSaldoEquipo As Decimal
        Dim nSaldoAnt As Decimal
        Dim nTasaApli As Decimal
        Dim nCount As Integer

        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)
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

        drAnexo = dsAgil.Tables("Anexos").Rows(0)
        nCount = dsAgil.Tables("Edoctao").Rows.Count
        nTasaApli = (drAnexo("Tasas") + drAnexo("Difer")) / 1200
        cCusnam = drAnexo("Descr")
        Me.Text = " Reestructura del Contrato " & txtAnexo.Text & "  " & cCusnam

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

                ' Identificamos a partir de cuál vencimiento inicia la reestructura

                nVencimiento = 0
                nPlazo = 0
                For Each drDato In drEdoctav
                    If drDato("Nufac") = 0 And drDato("Indrec") = "S" Then
                        nPlazo += 1
                        If nVencimiento = 0 Then
                            nVencimiento = Val(drDato("Letra"))
                            cFeven = drDato("Feven")
                            txtFven.Text = cFeven
                            txtPzoIni.Text = drDato("Letra")
                        End If
                    End If
                Next
                txtTap.Text = nTasaApli
                txtVen.Text = nVencimiento
                txtPzo.Text = nPlazo

        
                If nCount > 0 Then
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
                    MsgBox("Existe algún ERROR en el contrato", MsgBoxStyle.OkOnly, "Mensaje")
                    Me.Close()
                End If
            End If
        End If

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()

        ' Llenar el comboBox para mostrar el número de periodos de gracia en Capital

        cbMesg.Items.Add("0")
        cbMesg.Items.Add("1")
        cbMesg.Items.Add("2")
        cbMesg.Items.Add("3")
        cbMesg.Items.Add("4")
        cbMesg.Items.Add("5")
        cbMesg.Items.Add("6")
        cbMesg.Items.Add("7")
        cbMesg.Items.Add("8")
        cbMesg.Items.Add("9")
        cbMesg.Items.Add("10")
        cbMesg.SelectedIndex = 0

        ' Llenar el comboBox para mostrsr el numero de meses que se aumentaran en la Tabla de Edoctav

        cbMesp.Items.Add("0")
        cbMesp.Items.Add("1")
        cbMesp.Items.Add("2")
        cbMesp.Items.Add("3")
        cbMesp.Items.Add("4")
        cbMesp.Items.Add("5")
        cbMesp.Items.Add("6")
        cbMesp.Items.Add("7")
        cbMesp.Items.Add("8")
        cbMesp.Items.Add("9")
        cbMesp.Items.Add("10")
        cbMesp.Items.Add("11")
        cbMesp.Items.Add("12")
        cbMesp.Items.Add("13")
        cbMesp.Items.Add("14")
        cbMesp.Items.Add("15")
        cbMesp.Items.Add("16")
        cbMesp.Items.Add("17")
        cbMesp.Items.Add("18")
        cbMesp.Items.Add("19")
        cbMesp.Items.Add("20")
        cbMesp.Items.Add("21")
        cbMesp.Items.Add("22")
        cbMesp.Items.Add("23")
        cbMesp.Items.Add("24")
        cbMesp.Items.Add("25")
        cbMesp.Items.Add("26")
        cbMesp.Items.Add("27")
        cbMesp.Items.Add("28")
        cbMesp.Items.Add("29")
        cbMesp.Items.Add("30")
        cbMesp.Items.Add("31")
        cbMesp.SelectedIndex = 0

        bAborta.Enabled = True
        bImprime.Enabled = False

    End Sub

    Private Sub bPruebas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bPruebas.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand
        Dim daEdoctav As New SqlDataAdapter(cm1)
        Dim daAnexo As New SqlDataAdapter(cm2)
        Dim daTablanva As New SqlDataAdapter(cm3)
        Dim dsAgil As New DataSet()
        Dim drDatos As DataRow
        Dim drEdoctav As DataRow
        Dim drCambios As DataRow
        Dim drAnexo As DataRow
        Dim dtCambios As New DataTable("Cambios")
        Dim dtEdoctav As New DataTable("Edoctav")
        Dim newrptTablaEquipo As New rptTablaEquipo()
        Dim newrptTablaEqdepo As New rptTablaEquipodep()

        ' Declaración de variables de datos

        Dim nLetra As Integer
        Dim nPlazo As Integer
        Dim nVeces As Integer
        Dim i As Integer
        Dim l As Integer
        Dim nLant As Integer
        Dim nPlazoRestante As Integer
        Dim nPlazoIni As Integer
        Dim nSaldoEquipo As Decimal
        Dim nInter As Decimal
        Dim nIva As Decimal
        Dim nAbcap As Decimal
        Dim nSaldo As Decimal
        Dim nIvaeq As Decimal
        Dim nIvaCapital As Decimal
        Dim nPorieq As Decimal
        Dim nValorIva As Decimal
        Dim nRtasd As Integer
        Dim n As Integer
        Dim nImprd As Decimal
        Dim cAnexo As String
        Dim cLetra As String
        Dim cFecha As String
        Dim cFondeo As String
        Dim cFechacon As String
        Dim nTasa As Decimal
        Dim nTasas As Decimal
        Dim nDifer As Decimal
        Dim nRenta As Decimal
        Dim cForca As String
        Dim cTipar As String
        Dim cTipo As String
        Dim cReportTitle As String
        Dim cBonifica As String
        Dim bAmplia As Boolean

        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)

        ' Obtengo la tabla de amortización del Equipo

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TablaEquipo1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
        End With

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DatosCon1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
        End With

        daEdoctav.Fill(dsAgil, "Edoctav")
        daAnexo.Fill(dsAgil, "Anexo")

        drAnexo = dsAgil.Tables("Anexo").Rows(0)
        cFondeo = drAnexo("Fondeo")
        nPlazo = drAnexo("Plazo")
        nTasas = drAnexo("Tasas")
        nDifer = drAnexo("Difer")
        cForca = drAnexo("Forca")
        cTipo = drAnexo("Tipo")
        cTipar = drAnexo("Tipar")
        nRtasd = drAnexo("Rtasd")
        nImprd = drAnexo("Imprd")
        nIvaeq = drAnexo("Ivaeq")
        cFechacon = drAnexo("Fechacon")
        nPorieq = drAnexo("Porieq")
        nTasa = (nTasas + nDifer) / 1200
 
        ' Creo la estructura de la tabla para guardar los datos originales antes del cambio

        dtTabla.Columns.Add("Anexo", Type.GetType("System.String"))
        dtTabla.Columns.Add("Letra", Type.GetType("System.String"))
        dtTabla.Columns.Add("Feven", Type.GetType("System.String"))
        dtTabla.Columns.Add("Nufac", Type.GetType("System.String"))
        dtTabla.Columns.Add("Indrec", Type.GetType("System.String"))
        dtTabla.Columns.Add("Saldo", Type.GetType("System.String"))
        dtTabla.Columns.Add("Inter", Type.GetType("System.String"))
        dtTabla.Columns.Add("Abcap", Type.GetType("System.String"))
        dtTabla.Columns.Add("Iva", Type.GetType("System.String"))
        dtTabla.Columns.Add("Ivacap", Type.GetType("System.String"))

        bAmplia = False
        If rbNog.Checked = True And rbNop.Checked = True Then
            ' Guardo los datos originales de la Tabla de Edoctav
            txtSaldoeq.Text = txtMonto.Text
            For Each drEdoctav In dsAgil.Tables("Edoctav").Rows

                drDatos = dtTabla.NewRow()
                drDatos("Anexo") = drEdoctav("Anexo")
                drDatos("Letra") = drEdoctav("Letra")
                drDatos("Feven") = drEdoctav("Feven")
                drDatos("Nufac") = drEdoctav("Nufac")
                drDatos("Indrec") = drEdoctav("Indrec")
                drDatos("Saldo") = drEdoctav("Saldo")
                drDatos("Inter") = drEdoctav("Inter")
                drDatos("Abcap") = drEdoctav("Abcap")
                drDatos("Iva") = drEdoctav("Iva")
                drDatos("Ivacap") = drEdoctav("Ivacapital")
                dtTabla.Rows.Add(drDatos)

            Next

        End If

        nValorIva = 0.16
        If rbSig.Checked = True Or rbSip.Checked = True Then

            nVeces = cbMesg.SelectedIndex
            nPlazoIni = 0
            i = 0
            txtSaldoeq.Text = 0

            For Each drEdoctav In dsAgil.Tables("Edoctav").Rows

                If drEdoctav("Nufac") > 0 Then

                    drDatos = dtTabla.NewRow()
                    drDatos("Anexo") = drEdoctav("Anexo")
                    drDatos("Letra") = drEdoctav("Letra")
                    drDatos("Feven") = drEdoctav("Feven")
                    drDatos("Nufac") = drEdoctav("Nufac")
                    drDatos("Indrec") = drEdoctav("Indrec")
                    drDatos("Saldo") = drEdoctav("Saldo")
                    drDatos("Inter") = drEdoctav("Inter")
                    drDatos("Abcap") = drEdoctav("Abcap")
                    drDatos("Iva") = drEdoctav("Iva")
                    drDatos("Ivacap") = drEdoctav("Ivacapital")
                    dtTabla.Rows.Add(drDatos)

                End If

                If drEdoctav("Nufac") = 0 And rbSig.Checked = True Then
                    i = i + 1
                    If i = 1 And rbSig.Checked = True Then
                        nSaldoEquipo = drEdoctav("Saldo")
                        txtSaldoeq.Text = nSaldoEquipo
                        nInter = drEdoctav("Inter")
                        nIva = drEdoctav("Iva")
                        nPlazoIni = Val(drEdoctav("Letra")) - 1
                        If cbMesg.SelectedIndex >= (nPlazo - nPlazoIni) And rbNop.Checked = True Then
                            MsgBox("El plazo NO cubre esta operación tienes que ampliar el plazo original", MsgBoxStyle.OkOnly, "Mensaje")
                            Me.Close()
                        End If
                    End If
                    If i <= nVeces Then
                        drDatos = dtTabla.NewRow()
                        drDatos("Anexo") = drEdoctav("Anexo")
                        drDatos("Letra") = drEdoctav("Letra")
                        drDatos("Feven") = drEdoctav("Feven")
                        drDatos("Nufac") = 0
                        drDatos("Indrec") = "S"
                        drDatos("Saldo") = nSaldoEquipo
                        drDatos("Inter") = nInter
                        drDatos("Abcap") = 0
                        drDatos("Iva") = nIva
                        drDatos("Ivacap") = 0
                        dtTabla.Rows.Add(drDatos)
                    End If
                    If i = nVeces + 1 Then
                        If cbMesp.SelectedIndex > 0 Then
                            nPlazo = nPlazo + cbMesp.SelectedIndex
                        End If

                        nPlazoRestante = nPlazo - nPlazoIni - nVeces
                        nRenta = Round(nSaldoEquipo * nTasa / (1 - Pow((1 + nTasa), -nPlazoRestante)), 2)
                        nAbcap = Round(nSaldoEquipo / nPlazoRestante, 2)

                    End If
                    If i > nVeces Then
                        If cForca = "1" Or cForca = "4" Then
                            If drEdoctav("Nufac") = 0 And Val(drEdoctav("Letra")) >= nLetra Then
                                nInter = Round(nSaldoEquipo * nTasa, 2)
                                nSaldo = nSaldoEquipo
                                nAbcap = IIf(Val(drEdoctav("Letra")) = nPlazo, nSaldo, Round(nRenta - nInter, 2))
                                If cTipar = "R" Then
                                    If cTipo = "M" Or cTipo = "E" Then
                                        nIva = 0
                                    Else
                                        nIva = Round(nInter * nValorIva, 2)
                                    End If
                                ElseIf cTipar = "P" Then
                                    nIva = Round((nAbcap + nInter) * nValorIva, 2)
                                Else
                                    nIva = Round(nInter * nValorIva, 2)
                                End If
                                If cFechacon >= "20020301" And nIvaeq > 0 Then
                                    nIvaCapital = Round(nAbcap * nPorieq / 100, 2)
                                ElseIf nRtasd = 0 And nImprd > 0 And cTipar <> "R" Then
                                    nIvaCapital = Round(nAbcap * nValorIva)
                                End If
                                drDatos = dtTabla.NewRow()
                                drDatos("Anexo") = drEdoctav("Anexo")
                                drDatos("Letra") = drEdoctav("Letra")
                                drDatos("Feven") = drEdoctav("Feven")
                                drDatos("Nufac") = 0
                                drDatos("Indrec") = "S"
                                drDatos("Saldo") = nSaldo
                                drDatos("Inter") = nInter
                                drDatos("Abcap") = nAbcap
                                drDatos("Iva") = nIva
                                drDatos("Ivacap") = nIvaCapital
                                dtTabla.Rows.Add(drDatos)
                                nSaldoEquipo = Round(nSaldo - nAbcap, 2)
                            End If
                        ElseIf cForca = "2" Then
                            If drEdoctav("Nufac") = 0 And drEdoctav("Letra") >= nLetra Then
                                nInter = Round(nSaldoEquipo * nTasa, 2)
                                nSaldo = nSaldoEquipo
                                nAbcap = IIf(drEdoctav("Letra") = nPlazo, nSaldo, nAbcap)
                                If cTipar = "R" Then
                                    If cTipo = "M" Or cTipo = "E" Then
                                        nIva = 0
                                    Else
                                        nIva = Round(nInter * nValorIva, 2)
                                    End If
                                ElseIf cTipar = "P" Then
                                    nIva = Round((nAbcap + nInter) * nValorIva, 2)
                                Else
                                    nIva = Round(nInter * nValorIva, 2)
                                End If
                                If cFechacon >= "20020301" And nIvaeq > 0 Then
                                    nIvaCapital = Round(nAbcap * nPorieq / 100, 2)
                                ElseIf nRtasd = 0 And nImprd > 0 And cTipar <> "R" Then
                                    nIvaCapital = Round(nAbcap * nValorIva)
                                End If
                                drDatos = dtTabla.NewRow()
                                drDatos("Anexo") = drEdoctav("Anexo")
                                drDatos("Letra") = drEdoctav("Letra")
                                drDatos("Feven") = drEdoctav("Feven")
                                drDatos("Nufac") = 0
                                drDatos("Indrec") = "S"
                                drDatos("Saldo") = nSaldo
                                drDatos("Inter") = nInter
                                drDatos("Abcap") = nAbcap
                                drDatos("Iva") = nIva
                                drDatos("Ivacap") = nIvaCapital
                                dtTabla.Rows.Add(drDatos)
                                nSaldoEquipo = Round(nSaldo - nAbcap, 2)
                            End If
                        End If
                    End If
                    nLetra = Val(drEdoctav("Letra"))
                    cFecha = drEdoctav("Feven")
                    nLant = Val(drEdoctav("Letra"))
                ElseIf drEdoctav("Nufac") = 0 And rbSig.Checked = False Then

                    i = i + 1
                    If i = 1 Then
                        nSaldoEquipo = drEdoctav("Saldo")
                        txtSaldoeq.Text = nSaldoEquipo
                        nInter = drEdoctav("Inter")
                        nIva = drEdoctav("Iva")
                        nPlazoIni = Val(drEdoctav("Letra"))
                        If cbMesg.SelectedIndex >= (nPlazo - nPlazoIni) And rbNop.Checked = True Then
                            MsgBox("El plazo NO cubre esta operación tienes que ampliar el plazo original", MsgBoxStyle.OkOnly, "Mensaje")
                            Me.Close()
                        End If
                    End If
                    If i = nVeces + 1 Then
                        If cbMesp.SelectedIndex > 0 Then
                            nPlazo = nPlazo + cbMesp.SelectedIndex
                        End If

                        nPlazoRestante = nPlazo - nPlazoIni + 1
                        nRenta = Round(nSaldoEquipo * nTasa / (1 - Pow((1 + nTasa), -nPlazoRestante)), 2)
                        nAbcap = Round(nSaldoEquipo / nPlazoRestante, 2)

                    End If
                    If i > nVeces Then
                        If cForca = "1" Or cForca = "4" Then
                            If drEdoctav("Nufac") = 0 And Val(drEdoctav("Letra")) >= nLetra Then
                                nInter = Round(nSaldoEquipo * nTasa, 2)
                                nSaldo = nSaldoEquipo
                                nAbcap = IIf(Val(drEdoctav("Letra")) = nPlazo, nSaldo, Round(nRenta - nInter, 2))
                                If cTipar = "R" Then
                                    If cTipo = "M" Or cTipo = "E" Then
                                        nIva = 0
                                    Else
                                        nIva = Round(nInter * nValorIva, 2)
                                    End If
                                ElseIf cTipar = "P" Then
                                    nIva = Round((nAbcap + nInter) * nValorIva, 2)
                                Else
                                    nIva = Round(nInter * nValorIva, 2)
                                End If
                                If cFechacon >= "20020301" And nIvaeq > 0 Then
                                    nIvaCapital = Round(nAbcap * nPorieq / 100, 2)
                                ElseIf nRtasd = 0 And nImprd > 0 And cTipar <> "R" Then
                                    nIvaCapital = Round(nAbcap * nValorIva)
                                End If
                                drDatos = dtTabla.NewRow()
                                drDatos("Anexo") = drEdoctav("Anexo")
                                drDatos("Letra") = drEdoctav("Letra")
                                drDatos("Feven") = drEdoctav("Feven")
                                drDatos("Nufac") = 0
                                drDatos("Indrec") = "S"
                                drDatos("Saldo") = nSaldo
                                drDatos("Inter") = nInter
                                drDatos("Abcap") = nAbcap
                                drDatos("Iva") = nIva
                                drDatos("Ivacap") = nIvaCapital
                                dtTabla.Rows.Add(drDatos)
                                nSaldoEquipo = Round(nSaldo - nAbcap, 2)
                            End If
                        ElseIf cForca = "2" Then
                            If drEdoctav("Nufac") = 0 And drEdoctav("Letra") >= nLetra Then
                                nInter = Round(nSaldoEquipo * nTasa, 2)
                                nSaldo = nSaldoEquipo
                                nAbcap = IIf(drEdoctav("Letra") = nPlazo, nSaldo, nAbcap)
                                If cTipar = "R" Then
                                    If cTipo = "M" Or cTipo = "E" Then
                                        nIva = 0
                                    Else
                                        nIva = Round(nInter * nValorIva, 2)
                                    End If
                                ElseIf cTipar = "P" Then
                                    nIva = Round((nAbcap + nInter) * nValorIva, 2)
                                Else
                                    nIva = Round(nInter * nValorIva, 2)
                                End If
                                If cFechacon >= "20020301" And nIvaeq > 0 Then
                                    nIvaCapital = Round(nAbcap * nPorieq / 100, 2)
                                ElseIf nRtasd = 0 And nImprd > 0 And cTipar <> "R" Then
                                    nIvaCapital = Round(nAbcap * nValorIva)
                                End If
                                drDatos = dtTabla.NewRow()
                                drDatos("Anexo") = drEdoctav("Anexo")
                                drDatos("Letra") = drEdoctav("Letra")
                                drDatos("Feven") = drEdoctav("Feven")
                                drDatos("Nufac") = 0
                                drDatos("Indrec") = "S"
                                drDatos("Saldo") = nSaldo
                                drDatos("Inter") = nInter
                                drDatos("Abcap") = nAbcap
                                drDatos("Iva") = nIva
                                drDatos("Ivacap") = nIvaCapital
                                dtTabla.Rows.Add(drDatos)
                                nSaldoEquipo = Round(nSaldo - nAbcap, 2)
                            End If
                        End If
                    End If
                    nLetra = Val(drEdoctav("Letra"))
                    cFecha = drEdoctav("Feven")
                    nLant = Val(drEdoctav("Letra"))

                End If
            Next

            If i < nVeces And cbMesp.SelectedIndex > 0 Then
                nPlazo = nPlazo + cbMesp.SelectedIndex
                txtPzo.Text = i + cbMesp.SelectedIndex
            ElseIf i = nVeces And cbMesp.SelectedIndex > 0 Then
                nPlazo = nPlazo + cbMesp.SelectedIndex
                txtPzo.Text = i + cbMesp.SelectedIndex
                nPlazoRestante = Val(txtPzo.Text) - nVeces
                nRenta = Round(nSaldoEquipo * nTasa / (1 - Pow((1 + nTasa), -nPlazoRestante)), 2)
                bAmplia = True
            End If


            If rbSip.Checked = True Then

                For l = (nLant + 1) To nPlazo
                    nLetra = nLetra + 1
                    cLetra = GeneraLetra(nLetra, cFecha, cFondeo)
                    txtFecfin.Text = cFecha

                    i += 1
                    If i <= nVeces And bAmplia = False Then
                        drDatos = dtTabla.NewRow()
                        drDatos("Anexo") = cAnexo
                        drDatos("Letra") = cLetra
                        drDatos("Feven") = cFecha
                        drDatos("Nufac") = 0
                        drDatos("Indrec") = "S"
                        drDatos("Saldo") = nSaldoEquipo
                        drDatos("Inter") = nInter
                        drDatos("Abcap") = 0
                        drDatos("Iva") = nIva
                        drDatos("Ivacap") = 0
                        dtTabla.Rows.Add(drDatos)
                        nPlazoRestante = Val(txtPzo.Text) - nVeces
                        nRenta = Round(nSaldoEquipo * nTasa / (1 - Pow((1 + nTasa), -nPlazoRestante)), 2)
                        bAmplia = True
                    ElseIf cForca = "1" Or cForca = "4" Then
                        nInter = Round(nSaldoEquipo * nTasa, 2)
                        nSaldo = nSaldoEquipo
                        nAbcap = IIf(nLetra = nPlazo, nSaldo, Round(nRenta - nInter, 2))
                        If cTipar = "R" Then
                            If cTipo = "M" Or cTipo = "E" Then
                                nIva = 0
                            Else
                                nIva = Round(nInter * nValorIva, 2)
                            End If
                        ElseIf cTipar = "P" Then
                            nIva = Round((nAbcap + nInter) * nValorIva, 2)
                        Else
                            nIva = Round(nInter * nValorIva, 2)
                        End If
                        If cFechacon >= "20020301" And nIvaeq > 0 Then
                            nIvaCapital = Round(nAbcap * nPorieq / 100, 2)
                        ElseIf nRtasd = 0 And nImprd > 0 And cTipar <> "R" Then
                            nIvaCapital = Round(nAbcap * nValorIva)
                        End If
                        drDatos = dtTabla.NewRow()
                        drDatos("Anexo") = cAnexo
                        drDatos("Letra") = cLetra
                        drDatos("Feven") = cFecha
                        drDatos("Nufac") = 0
                        drDatos("Indrec") = "S"
                        drDatos("Saldo") = nSaldo
                        drDatos("Inter") = nInter
                        drDatos("Abcap") = nAbcap
                        drDatos("Iva") = nIva
                        drDatos("Ivacap") = nIvaCapital
                        dtTabla.Rows.Add(drDatos)
                        nSaldoEquipo = Round(nSaldo - nAbcap, 2)
                    ElseIf cForca = "2" Then
                        nInter = Round(nSaldoEquipo * nTasa, 2)
                        nSaldo = nSaldoEquipo
                        nAbcap = IIf(nLetra = nPlazo, nSaldo, nAbcap)
                        If cTipar = "R" Then
                            If cTipo = "M" Or cTipo = "E" Then
                                nIva = 0
                            Else
                                nIva = Round(nInter * nValorIva, 2)
                            End If
                        ElseIf cTipar = "P" Then
                            nIva = Round((nAbcap + nInter) * nValorIva, 2)
                        Else
                            nIva = Round(nInter * nValorIva, 2)
                        End If
                        If cFechacon >= "20020301" And nIvaeq > 0 Then
                            nIvaCapital = Round(nAbcap * nPorieq / 100, 2)
                        ElseIf nRtasd = 0 And nImprd > 0 And cTipar <> "R" Then
                            nIvaCapital = Round(nAbcap * nValorIva)
                        End If
                        drDatos = dtTabla.NewRow()
                        drDatos("Anexo") = cAnexo
                        drDatos("Letra") = cLetra
                        drDatos("Feven") = cFecha
                        drDatos("Nufac") = 0
                        drDatos("Indrec") = "S"
                        drDatos("Saldo") = nSaldo
                        drDatos("Inter") = nInter
                        drDatos("Abcap") = nAbcap
                        drDatos("Iva") = nIva
                        drDatos("Ivacap") = nIvaCapital
                        dtTabla.Rows.Add(drDatos)
                        nSaldoEquipo = Round(nSaldo - nAbcap, 2)
                    End If
                    nLetra = Val(cLetra)
                    cFecha = cFecha
                Next
            End If
        End If

        dsAgil.Tables.Remove("Edoctav")
        dsAgil.Tables.Remove("Anexo")

        If bAmplia = False Then
            If rbNog.Checked = True And rbNop.Checked = True Then
                nPlazoRestante = Val(txtPzo.Text)
            ElseIf rbSig.Checked = True And rbSip.Checked = True Then
                nPlazoRestante = Val(txtPzo.Text) + cbMesp.SelectedIndex
            ElseIf rbNog.Checked = True And rbSip.Checked = True Then
                nPlazoRestante = Val(txtPzo.Text) + cbMesp.SelectedIndex
            ElseIf rbSig.Checked = True And rbNop.Checked = True Then
                nPlazoRestante = Val(txtPzo.Text)
            End If
        ElseIf bAmplia = True Then
            nPlazoRestante = Val(txtPzo.Text)
        End If
        Capitaliza(nPlazoRestante)

        DataGrid1.DataSource = dtTabla
        ' DataGrid1.Visible = True

        ' Defino una Tabla Temporal para crear el reporte de la Tabla de Otros Adeudos prospecto

        dtEdoctav.Columns.Add("Anexo", Type.GetType("System.String"))
        dtEdoctav.Columns.Add("Letra", Type.GetType("System.String"))
        dtEdoctav.Columns.Add("Nufac", Type.GetType("System.Decimal"))
        dtEdoctav.Columns.Add("Indrec", Type.GetType("System.String"))
        dtEdoctav.Columns.Add("Feven", Type.GetType("System.String"))
        dtEdoctav.Columns.Add("Vence", Type.GetType("System.String"))
        dtEdoctav.Columns.Add("Saldo", Type.GetType("System.Decimal"))
        dtEdoctav.Columns.Add("Abcap", Type.GetType("System.Decimal"))
        dtEdoctav.Columns.Add("Abono", Type.GetType("System.Decimal"))
        dtEdoctav.Columns.Add("Inter", Type.GetType("System.Decimal"))
        dtEdoctav.Columns.Add("Interes", Type.GetType("System.Decimal"))
        dtEdoctav.Columns.Add("Renta", Type.GetType("System.Decimal"))
        dtEdoctav.Columns.Add("IvaCapital", Type.GetType("System.Decimal"))
        dtEdoctav.Columns.Add("Iva", Type.GetType("System.Decimal"))
        dtEdoctav.Columns.Add("Descr", Type.GetType("System.String"))

        n = dtTabla.Rows.Count()

        For n = 0 To n - 1
            drCambios = dtEdoctav.NewRow()
            drCambios("Anexo") = cAnexo
            drCambios("Letra") = DataGrid1.Item(n, 1)
            drCambios("Nufac") = DataGrid1.Item(n, 3)
            drCambios("Indrec") = DataGrid1.Item(n, 4)
            drCambios("Feven") = DataGrid1.Item(n, 2)
            drCambios("Vence") = DataGrid1.Item(n, 2)
            drCambios("Saldo") = DataGrid1.Item(n, 5)
            drCambios("Abcap") = DataGrid1.Item(n, 7)
            drCambios("Abono") = DataGrid1.Item(n, 7)
            drCambios("Inter") = DataGrid1.Item(n, 6)
            drCambios("Interes") = DataGrid1.Item(n, 6)
            drCambios("Renta") = Val(DataGrid1.Item(n, 6)) + Val(DataGrid1.Item(n, 7))
            drCambios("Ivacapital") = DataGrid1.Item(n, 9)
            drCambios("Iva") = DataGrid1.Item(n, 8)
            drCambios("Descr") = " "
            dtEdoctav.Rows.Add(drCambios)
        Next

        cReportTitle = "TABLA NO VALIDA SOLO ES UNA PROPUESTA"
        cBonifica = "N"

        If nRtasd = 0 And nImprd > 0 Then
            newrptTablaEqdepo.SummaryInfo.ReportTitle = cReportTitle
            newrptTablaEqdepo.SummaryInfo.ReportAuthor = " "
            cBonifica = "S"
        Else
            newrptTablaEquipo.SummaryInfo.ReportTitle = cReportTitle
            newrptTablaEquipo.SummaryInfo.ReportAuthor = " "
        End If

        If nRtasd = 0 And nImprd > 0 Then
            newrptTablaEqdepo.SummaryInfo.ReportComments = " "
            newrptTablaEqdepo.SetDataSource(dtEdoctav)
            CrystalReportViewer2.ReportSource = newrptTablaEqdepo
        Else
            newrptTablaEquipo.SummaryInfo.ReportComments = " "
            newrptTablaEquipo.SetDataSource(dtEdoctav)
            CrystalReportViewer2.ReportSource = newrptTablaEquipo
        End If
        CrystalReportViewer2.Visible = True

        bAborta.Enabled = True
        bSave.Enabled = False
        bImprime.Enabled = False

        cnAgil.Close()
        dsAgil.Dispose()
        dtCambios.Dispose()

    End Sub

    Private Sub bProcesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bProcesa.Click
        bImprime.Enabled = True
        bSave.Enabled = True
        bProcesa.Enabled = False
        MsgBox("Se han activado los botones para Guardar e Imprimir los cambios una vez que oprimas GUARDAR se afectara la Información Actual", MsgBoxStyle.OkOnly, "Mensaje")
    End Sub

    Public Function Capitaliza(ByVal nPlazorest As Integer)

        ' Declaración de variables de conexión ADO .NET

        Dim drDato As DataRow
        Dim drDato1 As DataRow
        Dim dtEdoctao As New DataTable("Edoctao")
        Dim newrptTablaOtros As New rptTablaOtros()

        ' Declaración de variables de datos

        Dim cAnexo As String
        Dim cFecha As String
        Dim cFeven As String
        Dim cString As String
        Dim cReportTitle As String
        Dim nVencimiento As Int32
        Dim nVenciAnt As Int32
        Dim i As Integer
        Dim n As Integer
        Dim nPlazo As Integer
        Dim nSaldo As Decimal
        Dim nInteres As Decimal
        Dim nCapital As Decimal
        Dim nIva As Decimal
        Dim nTasaApli As Decimal
        Dim nRenta As Decimal
        Dim nSdoAnt As Decimal
        Dim nValorIva As Decimal

        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)
        cFecha = DTOC(Today)
        nVencimiento = txtVen.Text
        nPlazo = IIf(cbMesp.SelectedIndex = 0, txtPzo.Text, txtPzo.Text + cbMesp.SelectedIndex)

        nSdoAnt = txtSant.Text
        nTasaApli = txtTap.Text

        If rbNog.Checked = True And rbSip.Checked = True Then
            cFeven = txtFven.Text
        ElseIf rbNoa.Checked = True And rbSig.Checked = True Then
            cFeven = txtFven.Text
        ElseIf rbSia.Checked = True And rbSig.Checked = True Then
            cFeven = DTOC(DateAdd(DateInterval.Month, -1, CTOD(txtFven.Text)))
        ElseIf rbNog.Checked = True And rbNop.Checked = True Then
            cFeven = txtFven.Text
        Else
            cFeven = DTOC(DateAdd(DateInterval.Month, -1, CTOD(txtFven.Text)))
        End If
        txtRow.Text = 1

        nValorIva = 0.16
        If Val(txtMonto.Text) > 0 And nPlazorest <= nPlazo Then

            nSaldo = txtMonto.Text + nSdoAnt
            nRenta = Round((nSaldo * nTasaApli) / (1 - Pow((1 + nTasaApli), -nPlazorest)), 2)

            ' Defino una Tabla Temporal para cargar la capitalización

            dtCreaTabla.Columns.Add("Anexo", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Letra", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Feven", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Nufac", Type.GetType("System.Decimal"))
            dtCreaTabla.Columns.Add("Saldo", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Capital", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Interes", Type.GetType("System.String"))
            dtCreaTabla.Columns.Add("Iva", Type.GetType("System.String"))

            n = 1
            For i = 1 To nPlazorest
                If i = 1 And nSdoAnt > 0 Then
                    nVenciAnt = txtVen.Text - 1
                    drDato = dtCreaTabla.NewRow()
                    drDato("Anexo") = cAnexo
                    drDato("Letra") = Stuff(nVenciAnt.ToString, i, 0, 3)
                    drDato("Feven") = Mid(Today.ToString, 1, 10)
                    drDato("Nufac") = 7777777
                    drDato("Saldo") = nSdoAnt
                    drDato("Capital") = -txtMonto.Text
                    drDato("Interes") = 0
                    drDato("Iva") = 0
                    dtCreaTabla.Rows.Add(drDato)
                    txtRow.Text = 0
                End If

                If rbSia.Checked = True And n <= cbMesg.SelectedIndex Then
                    nRenta = Round((nSaldo * nTasaApli) / (1 - Pow((1 + nTasaApli), -(nPlazorest - n))), 2)
                    nInteres = Round(nSaldo * txtTap.Text, 2)
                    nIva = Round(nInteres * nValorIva, 2)

                    cString = Stuff(nVencimiento.ToString, i, 0, 3)
                    cFeven = DTOC(DateAdd(DateInterval.Month, 1, CTOD(cFeven)))
                    drDato = dtCreaTabla.NewRow()
                    drDato("Anexo") = cAnexo
                    drDato("Letra") = cString
                    drDato("Feven") = CTOD(cFeven).ToShortDateString
                    If Val(Mid(cFeven, 7, 2)) > 25 Then
                        drDato("Feven") = DayWeek(CTOD(cFeven).ToShortDateString)
                    End If
                    drDato("Nufac") = 0
                    drDato("Saldo") = nSaldo
                    drDato("Capital") = 0
                    drDato("Interes") = nInteres
                    drDato("Iva") = nIva
                    dtCreaTabla.Rows.Add(drDato)
                    nVencimiento += 1
                    n = n + 1

                Else

                    cString = Stuff(nVencimiento.ToString, i, 0, 3)
                    If i > 1 Then
                        cFeven = DTOC(DateAdd(DateInterval.Month, 1, CTOD(cFeven)))
                    End If
                    nInteres = Round(nSaldo * txtTap.Text, 2)
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
                    drDato("Iva") = nIva
                    dtCreaTabla.Rows.Add(drDato)
                    nSaldo = nSaldo - nCapital
                    nVencimiento += 1

                End If
            Next
            txtPzorest.Text = nVencimiento
            txtPlazo.Text = nPlazorest

            DataGrid2.DataSource = dtCreaTabla
            ' DataGrid2.Visible = True

            ' Defino una Tabla Temporal para crear el reporte de la Tabla de Otros Adeudos prospecto

            dtEdoctao.Columns.Add("Anexo", Type.GetType("System.String"))
            dtEdoctao.Columns.Add("Letra", Type.GetType("System.String"))
            dtEdoctao.Columns.Add("Feven", Type.GetType("System.String"))
            dtEdoctao.Columns.Add("Nufac", Type.GetType("System.Decimal"))
            dtEdoctao.Columns.Add("Indrec", Type.GetType("System.String"))
            dtEdoctao.Columns.Add("Saldo", Type.GetType("System.Decimal"))
            dtEdoctao.Columns.Add("Abcap", Type.GetType("System.Decimal"))
            dtEdoctao.Columns.Add("Inter", Type.GetType("System.Decimal"))
            dtEdoctao.Columns.Add("Iva", Type.GetType("System.Decimal"))
            dtEdoctao.Columns.Add("Descr", Type.GetType("System.String"))

            n = dtCreaTabla.Rows.Count()

            For i = 0 To n - 1
                drDato1 = dtEdoctao.NewRow()
                drDato1("Anexo") = cAnexo
                drDato1("Letra") = DataGrid2.Item(i, 1)
                drDato1("Feven") = DTOC(DataGrid2.Item(i, 2))
                drDato1("Nufac") = DataGrid2.Item(i, 3)
                drDato1("Indrec") = "S"
                drDato1("Saldo") = DataGrid2.Item(i, 4)
                drDato1("Abcap") = DataGrid2.Item(i, 5)
                drDato1("Inter") = DataGrid2.Item(i, 6)
                drDato1("Iva") = DataGrid2.Item(i, 7)
                drDato1("Descr") = " "
                dtEdoctao.Rows.Add(drDato1)
          Next

            cReportTitle = "TABLA NO VALIDA SOLO ES UNA PROPUESTA"

            newrptTablaOtros.SummaryInfo.ReportTitle = cReportTitle
            newrptTablaOtros.SummaryInfo.ReportComments = " "
            newrptTablaOtros.SetDataSource(dtEdoctao)

            CrystalReportViewer3.ReportSource = newrptTablaOtros
            CrystalReportViewer3.Visible = True

        End If

    End Function

    Private Sub bAborta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAborta.Click
        dtTabla.Reset()
        dtCreaTabla.Reset()
        Me.Close()
    End Sub

    Private Sub bSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSave.Click
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim drTablaeq As DataRow
        Dim drTablaad As DataRow
        Dim strInsert As String
        Dim strUpdate As String

        ' Declaración de variables de datos

        Dim cAnexo As String
        Dim cFecha As String
        Dim nVencimiento As Int32
        Dim nPlazo As Integer
        Dim i As Int32
        Dim n As Integer

        cFecha = DTOC(Today)
        nVencimiento = Val(txtPlazo.Text) - Val(txtRow.Text)
        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)
        HistoriaEdoCtaV(cAnexo) 'ESTA SIRVE PARA RESPALDAR LA HISTORIA DEL EdoCtaV

        Try

            If Val(txtMonto.Text) > 0 Then
                cnAgil.Open()

                With cm3
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "BorraAdeudo"
                    .Connection = cnAgil
                    .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                    .Parameters(0).Value = cAnexo
                End With
                cm3.ExecuteNonQuery()

                For Each drTablaad In dtCreaTabla.Rows
                    '  If drTablaad("Nufac") = 0 Then
                    strInsert = "INSERT INTO Edoctao( Anexo, Letra, Feven, Nufac, Indrec, Saldo, Abcap, Inter, Iva )"
                    strInsert = strInsert & "VALUES('"
                    strInsert = strInsert & drTablaad("Anexo") & "', '"
                    strInsert = strInsert & drTablaad("Letra") & "', '"
                    strInsert = strInsert & DTOC(drTablaad("Feven")) & "', '"
                    strInsert = strInsert & drTablaad("Nufac") & "', '"
                    strInsert = strInsert & "S" & "', '"
                    strInsert = strInsert & drTablaad("Saldo") & "', '"
                    strInsert = strInsert & drTablaad("Capital") & "', '"
                    strInsert = strInsert & drTablaad("Interes") & "', '"
                    strInsert = strInsert & drTablaad("Iva") & "')"
                    cm1 = New SqlCommand(strInsert, cnAgil)
                    cm1.ExecuteNonQuery()
                    ' End If
                Next

                Dim Bloqueo As Boolean = False
                If EstaBloqueadoAnexo(cAnexo) = True Then
                    DesBloqueaContrato(cAnexo)
                    Bloqueo = True
                End If
                strUpdate = "UPDATE Anexos SET  Adeudo = 'S'" & ""
                    strUpdate = strUpdate & " WHERE Anexo = '" & cAnexo & "'"
                    cm2 = New SqlCommand(strUpdate, cnAgil)
                    cm2.ExecuteNonQuery()
                cnAgil.Close()

                If Bloqueo = True Then
                    BloqueaContrato(cAnexo)
                End If

            End If

                If rbSig.Checked = True Or rbSip.Checked = True Then
                cnAgil.Open()

                With cm4
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "BorraTabla"
                    .Connection = cnAgil
                    .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                    .Parameters(0).Value = cAnexo
                End With
                cm4.ExecuteNonQuery()

                For Each drTablaeq In dtTabla.Rows
                    If drTablaeq("Nufac") = 0 Then
                        strInsert = "INSERT INTO Edoctav( Anexo, Letra, Feven, Nufac, Indrec, Saldo, Abcap, Inter, Iva, IvaCapital )"
                        strInsert = strInsert & "VALUES('"
                        strInsert = strInsert & drTablaeq("Anexo") & "', '"
                        strInsert = strInsert & drTablaeq("Letra") & "', '"
                        strInsert = strInsert & drTablaeq("Feven") & "', '"
                        strInsert = strInsert & drTablaeq("Nufac") & "', '"
                        strInsert = strInsert & drTablaeq("Indrec") & "', '"
                        strInsert = strInsert & drTablaeq("Saldo") & "', '"
                        strInsert = strInsert & drTablaeq("Abcap") & "', '"
                        strInsert = strInsert & drTablaeq("Inter") & "', '"
                        strInsert = strInsert & drTablaeq("Iva") & "', '"
                        strInsert = strInsert & drTablaeq("Ivacap") & "')"
                        cm3 = New SqlCommand(strInsert, cnAgil)
                        cm3.ExecuteNonQuery()
                    End If
                    nPlazo = Val(drTablaeq("Letra"))
                Next
                Dim BLOQ As Integer = DesBloqueaContrato(cAnexo) 'DESBLOQUEO MESA DE CONTROL+++++++++++++
                strUpdate = "UPDATE Anexos SET  Plazo = " & nPlazo
                strUpdate = strUpdate & " WHERE Anexo = '" & cAnexo & "'"
                cm2 = New SqlCommand(strUpdate, cnAgil)
                cm2.ExecuteNonQuery()
                BloqueaContrato(cAnexo, BLOQ) '*******************BLOQUEO MESA DE CONTROL++++++++++++++++
                cnAgil.Close()
                cnAgil.Close()
            End If

        Catch eException As Exception

            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje")

        End Try

        bSave.Enabled = False
        MsgBox("Datos actualizados", MsgBoxStyle.Information, "Mensaje del Sistema")
       
        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()

    End Sub

    Private Sub bImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bImprime.Click
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daDatoscon As New SqlDataAdapter(cm1)
        Dim drAnexo As DataRow
        Dim drDato As DataRow
        Dim drEquipo As DataRow
        Dim dtTemporal As New DataTable("Datos")
        Dim dtAdeudo As New DataTable("Adeudo")
        Dim dtNvaTabla As New DataTable("NvaTabla")

        ' Declaración de variables de datos

        Dim cAnexo As String
        Dim nImpeq As Double
        Dim cPlazo As String
        Dim cImpeq As String
        Dim cSaldo As String
        Dim cRentasv As String
        Dim cNvopzo As String
        Dim cAdeudo As String
        Dim cAdeudo2 As String
        Dim i As Integer
        Dim nDeuda As Decimal
        Dim nDeuda2 As Decimal
        Dim nPlazo As Integer
        Dim newrptReestructura As rptReestructura

        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)

        ' Obtengo los Datos Generales del Contrato

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "DatosCon2"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
        End With

        daDatoscon.Fill(dsAgil, "Contrato")

        drAnexo = dsAgil.Tables("Contrato").Rows(0)
        nImpeq = drAnexo("Impeq") - drAnexo("Ivaeq") - drAnexo("Amorin")
        cImpeq = Letras(nImpeq)
        cPlazo = drAnexo("Plazo") - cbMesp.SelectedIndex
        cSaldo = Letras(txtSaldoeq.Text)
        cRentasv = IIf(Val(txtMonto.Text) > 0, Letras(txtMonto.Text), "")
        cNvopzo = IIf(Val(txtPlazo.Text) > 0, Letras(txtPlazo.Text), "")

        ' Obtengo la tabla de amortización del Equipo ya con modificaciones
        ' Creo la estructura de la tabla para guardar los datos originales antes del cambio

        dtNvaTabla.Columns.Add("Anexo", Type.GetType("System.String"))
        dtNvaTabla.Columns.Add("Letra", Type.GetType("System.String"))
        dtNvaTabla.Columns.Add("Feven", Type.GetType("System.String"))
        dtNvaTabla.Columns.Add("Nufac", Type.GetType("System.String"))
        dtNvaTabla.Columns.Add("Indrec", Type.GetType("System.String"))
        dtNvaTabla.Columns.Add("Saldo", Type.GetType("System.String"))
        dtNvaTabla.Columns.Add("Inter", Type.GetType("System.String"))
        dtNvaTabla.Columns.Add("Abcap", Type.GetType("System.String"))
        dtNvaTabla.Columns.Add("Iva", Type.GetType("System.String"))
        dtNvaTabla.Columns.Add("Ivacap", Type.GetType("System.String"))

        ' Guardo los datos originales de la Tabla de Edoctav

        nDeuda = 0
        nDeuda2 = 0
        nPlazo = dtTabla.Rows.Count()

        For i = 0 To nPlazo - 1
            If DataGrid1.Item(i, 3) = 0 Then
                drEquipo = dtNvaTabla.NewRow()
                drEquipo("Anexo") = cAnexo
                drEquipo("Letra") = DataGrid1.Item(i, 1)
                drEquipo("Feven") = DataGrid1.Item(i, 2)
                drEquipo("Nufac") = DataGrid1.Item(i, 3)
                drEquipo("Indrec") = DataGrid1.Item(i, 4)
                drEquipo("Saldo") = DataGrid1.Item(i, 5)
                drEquipo("Inter") = DataGrid1.Item(i, 6)
                drEquipo("Abcap") = DataGrid1.Item(i, 7)
                drEquipo("Iva") = DataGrid1.Item(i, 8)
                drEquipo("Ivacap") = DataGrid1.Item(i, 9)
                dtNvaTabla.Rows.Add(drEquipo)
                nDeuda = nDeuda + DataGrid1.Item(i, 7) + DataGrid1.Item(i, 6)
            End If
        Next
        cAdeudo = Letras(nDeuda)
        dsAgil.Tables.Add(dtNvaTabla)

        'Defino una Tabla Temporal para cargar el Adeudo

        dtAdeudo.Columns.Add("Anexo", Type.GetType("System.String"))
        dtAdeudo.Columns.Add("Letra", Type.GetType("System.String"))
        dtAdeudo.Columns.Add("Fecha", Type.GetType("System.String"))
        dtAdeudo.Columns.Add("Importe", Type.GetType("System.String"))

        For i = 0 To (Val(txtPlazo.Text) - 1)
            If DataGrid2.Item(i, 3) = "0" Then
                drAnexo = dtAdeudo.NewRow()
                drAnexo("Anexo") = cAnexo
                drAnexo("Letra") = DataGrid2.Item(i, 1)
                drAnexo("Fecha") = DataGrid2.Item(i, 2)
                drAnexo("Importe") = Val(DataGrid2.Item(i, 5)) + Val(DataGrid2.Item(i, 6))
                nDeuda2 = nDeuda2 + Val(DataGrid2.Item(i, 5)) + Val(DataGrid2.Item(i, 6))
                dtAdeudo.Rows.Add(drAnexo)
            End If
        Next
        cAdeudo2 = Letras(nDeuda2)

        ' Defino una Tabla Temporal para cargar la capitalización

        dtTemporal.Columns.Add("Anexo", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Impeq", Type.GetType("System.String"))
        dtTemporal.Columns.Add("cImpeq", Type.GetType("System.String"))
        dtTemporal.Columns.Add("cPlazo", Type.GetType("System.String"))
        dtTemporal.Columns.Add("nSaldo", Type.GetType("System.String"))
        dtTemporal.Columns.Add("cSaldo", Type.GetType("System.String"))
        dtTemporal.Columns.Add("nRtasv", Type.GetType("System.String"))
        dtTemporal.Columns.Add("cRentasv", Type.GetType("System.String"))
        dtTemporal.Columns.Add("nNvopzo", Type.GetType("System.String"))
        dtTemporal.Columns.Add("cNvopzo", Type.GetType("System.String"))
        dtTemporal.Columns.Add("FecIni", Type.GetType("System.String"))
        dtTemporal.Columns.Add("FecFin", Type.GetType("System.String"))
        dtTemporal.Columns.Add("PzoIni", Type.GetType("System.String"))
        dtTemporal.Columns.Add("nDeuda", Type.GetType("System.String"))
        dtTemporal.Columns.Add("nDeuda2", Type.GetType("System.String"))
        dtTemporal.Columns.Add("cAdeudo", Type.GetType("System.String"))
        dtTemporal.Columns.Add("cAdeudo2", Type.GetType("System.String"))


        drDato = dtTemporal.NewRow()
        drDato("Anexo") = txtAnexo.Text
        drDato("Impeq") = FormatNumber(nImpeq).ToString
        drDato("cImpeq") = cImpeq
        drDato("cPlazo") = cPlazo
        drDato("nSaldo") = FormatNumber(txtSaldoeq.Text).ToString
        drDato("cSaldo") = cSaldo
        If Val(txtMonto.Text) > 0 Then
            drDato("nRtasv") = FormatNumber(txtMonto.Text).ToString
            drDato("FecIni") = txtFven.Text
            drDato("FecFin") = txtFecfin.Text
        Else
            drDato("nRtasv") = 0
            drDato("FecIni") = ""
            drDato("FecFin") = ""
        End If
        drDato("cRentasv") = cRentasv
        drDato("nNvopzo") = txtPlazo.Text
        drDato("cNvopzo") = cNvopzo
        drDato("PzoIni") = txtPzoIni.Text
        drDato("nDeuda") = FormatNumber(nDeuda).ToString
        drDato("nDeuda2") = FormatNumber(nDeuda2).ToString
        drDato("cAdeudo") = cAdeudo
        drDato("cAdeudo2") = cAdeudo2
        dtTemporal.Rows.Add(drDato)

        dsAgil.Tables.Add(dtTemporal)
        dsAgil.Tables.Add(dtAdeudo)

        newrptReestructura = New rptReestructura()

        Try

            ' Descomentar la siguiente línea en caso de que deseara modificarse el reporte rptRepoProm
            dsAgil.WriteXml("C:\Reestructura.xml", XmlWriteMode.WriteSchema)

            newrptReestructura.SetDataSource(dsAgil)
            CrystalReportViewer1.ReportSource = newrptReestructura
            CrystalReportViewer1.Visible = True

        Catch eException As Exception
            MsgBox(eException.Source, MsgBoxStyle.Critical, eException.Message)
        End Try

        bImprime.Enabled = False
        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub rbSig_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSig.CheckedChanged
        cbMesg.Enabled = True
    End Sub

    Private Sub rbNog_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbNog.CheckedChanged
        cbMesg.SelectedIndex = -1
        cbMesg.Enabled = False
        rbNoa.Checked = True
    End Sub

    Private Sub rbSip_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSip.CheckedChanged
        cbMesp.Enabled = True
    End Sub

    Private Sub rbNop_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbNop.CheckedChanged
        cbMesp.SelectedIndex = -1
        cbMesp.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub rbSia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSia.Click
        If rbNog.Checked = True Then
            rbNoa.Checked = True
            MsgBox("NO puedes asignar Plazo de Gracia unicamente a Tabla de Adeudo", MsgBoxStyle.OkOnly, "Mensaje")
        End If
    End Sub

   End Class