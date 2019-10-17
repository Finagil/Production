Option Explicit On
Imports System.io
Imports System.Data.SqlClient
Imports System.Math
Imports System.ComponentModel
'Imports EdoCtaAvioDLL.EdoCtaNamespace


Public Class frmEdoCtaAvio

    ' Declaración de variables de datos de alcance privado

    Dim cAnexo As String = ""
    Dim cCiclo As String = ""
    Dim nSegVida As Decimal
    Dim cDescCiclo As String = ""
    Dim cFechaTerminacion As String = ""
    Dim cNombreProductor As String = ""
    Dim cNombreSucursal As String = ""
    Dim Proyectado As Boolean
    Dim Banamex As String = ""
    Dim Bancomer As String = ""
    Dim Banorte As String = ""
    Dim BBVCIE As String = ""
    Dim cFondeo As String = ""
    Dim cCliente As String = ""
    Dim dsAgil As New DataSet()
    Dim cTipo As String = ""
    Dim cTipoPersona As String = ""
    Dim cSemilla As String = ""
    Dim cCicloRpt As String = ""
    Dim cVencRpt As String = ""
    Dim cReportTitle As String = ""
    Dim cReportTitleSaldos As String = ""
    Dim ProcesadoEdoCta As Boolean = False



    Public Sub New(ByVal cLinea As String)

        MyBase.New()

        'This call is required by the Windows Form Designer.

        InitializeComponent()

        'Add any initialization after the InitializeComponent() call



        txtAnexo.Text = Mid(cLinea, 1, 10)
        lblCiclo.Text = Mid(cLinea, 12, 47)
        cDescCiclo = lblCiclo.Text

        cAnexo = Mid(txtAnexo.Text, 1, 5) + Mid(txtAnexo.Text, 7, 4)

        If Mid(cDescCiclo, 1, 6) = "PAGARE" Then
            cCiclo = Mid(lblCiclo.Text, 8, 2)
        Else
            cCiclo = Mid(lblCiclo.Text, 7, 2)
        End If

        If Not System.IO.File.Exists(My.Settings.RootDoc & "Executables\EstadoCuentaAVCC.exe") Then
            If Not System.IO.Directory.Exists(My.Settings.RootDoc) Then
                MessageBox.Show("No existe Diretorio " & My.Settings.RootDoc & " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnProcesar.Enabled = False
            Else
                MessageBox.Show("No se puede calcular estado de cuenta ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnProcesar.Enabled = False
            End If

        End If

        If Mid(cDescCiclo, 1, 6) = "PAGARE" Then
            Me.Text = "Estado de Cuenta del Crédito en Cuenta Corriente " & Mid(cLinea, 1, 10)
        Else
            Me.Text = "Estado de Cuenta del Contrato de Avío " & Mid(cLinea, 1, 10)
        End If

    End Sub

    Private Sub frmEdoCtaAvio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TaQUERY.SacaPermisoModulo("APLICA_PAGOS", UsuarioGlobal) > 0 Then
            dtpProceso.Value = FECHA_APLICACION
            dtpProceso.MinDate = FECHA_APLICACION.AddDays((FECHA_APLICACION.Day - 1) * -1)
            dtpProceso.MaxDate = FECHA_APLICACION
        Else
            dtpProceso.MinDate = Today.AddDays((Today.Day - 1) * -1)
            dtpProceso.MaxDate = dtpProceso.MinDate.AddMonths(2).AddDays(-1)
        End If



        Lbuser.Text = UsuarioGlobal


        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim AplicaFEGA As Boolean
        Dim FegaFlat As Boolean
        Dim CAT As Decimal
        Dim PorcFega As Decimal

        ' Declaración de variables de datos

        Dim cCliente_Sucursal As String = ""

        cAnexo = Mid(txtAnexo.Text, 1, 5) + Mid(txtAnexo.Text, 7, 4)
        TxtContMarco.Text = SacaContratoMarcoLargo(0, cAnexo)

        If Mid(cDescCiclo, 1, 6) = "PAGARE" Then
            cCiclo = Mid(lblCiclo.Text, 8, 2)
        Else
            cCiclo = Mid(lblCiclo.Text, 7, 2)
        End If

        GastosEXT.CargaXAnexo(Trim(cAnexo) & Trim(cCiclo))
        GastosEXT.Refresh()

        ' El siguiente Command trae el nombre del Productor y la Sucursal que lo atiende

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT SUBSTRING(Descr, 1, 100) + SUBSTRING(Nombre_Sucursal,1,50) AS Cliente_Sucursal FROM Avios " &
                           "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " &
                           "INNER JOIN Sucursales ON Sucursales.ID_Sucursal = Clientes.Sucursal " &
                           "WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
            .Connection = cnAgil
        End With
        cnAgil.Open()

        cCliente_Sucursal = cm1.ExecuteScalar

        cm1.CommandText = "SELECT Cliente FROM Avios WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
        cCliente = cm1.ExecuteScalar

        cm1.CommandText = "SELECT Tipo FROM Clientes WHERE Cliente = '" & cCliente & "'"
        cTipoPersona = cm1.ExecuteScalar

        cm1.CommandText = "SELECT AplicaFega FROM Avios WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
        AplicaFEGA = cm1.ExecuteScalar

        cm1.CommandText = "SELECT PorcFega FROM Avios WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
        PorcFega = cm1.ExecuteScalar

        cm1.CommandText = "SELECT FegaFlat FROM Avios WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
        FegaFlat = cm1.ExecuteScalar

        cm1.CommandText = "SELECT CAT FROM Avios WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
        CAT = cm1.ExecuteScalar
        CAT = CAT / 100
        LBcat.Text = "CAT: " & CAT.ToString("p2")

        If AplicaFEGA = True Then
            If FegaFlat = True Then
                Lbuser.Text = "FEGA: SI FLAT"
            Else
                Lbuser.Text = "FEGA: SI Dias Reales"
            End If
        Else
            Lbuser.Text = "FEGA: NO"
        End If

        cm1.CommandText = "SELECT AplicaGarantiaLiq FROM Avios WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
        LbGarLiq.Text = "Garantía Liquida: " & cm1.ExecuteScalar

        cm1.CommandText = "SELECT SeguroVida FROM Avios WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
        LbSegVid.Text = "Seguro de Vida: " & cm1.ExecuteScalar
        nSegVida = cm1.ExecuteScalar

        cm1.CommandText = "SELECT Tasas FROM Avios WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
        LbTasaF.Text = "Tasa Fija: " & CDbl(cm1.ExecuteScalar).ToString("n2")

        cm1.CommandText = "SELECT DiferencialFinagil FROM Avios WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
        LbTasaV.Text = "Tasa Variable: " & CDbl(cm1.ExecuteScalar).ToString("n2")
        cnAgil.Close()

        cNombreProductor = Mid(cCliente_Sucursal, 1, 100)
        cNombreSucursal = Mid(cCliente_Sucursal, 101, 50)
        txtNombreProductor.Text = cNombreProductor
        lblSucursal.Text = "Sucursal " & RTrim(cNombreSucursal)
        LbPorcFecga.Text = "Fega: " & (PorcFega * 100).ToString("n2") & " %"


        cnAgil.Dispose()
        cm1.Dispose()
        ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++
        Dim TaOnbase As New GeneralDSTableAdapters.OnBaseTableAdapter
        cFondeo = TaOnbase.SacaFondeoAvio(cCiclo, cAnexo)
        If cFondeo = "02" Then
            cFondeo = "Recursos: Nafin"
        ElseIf cFondeo = "03" Then
            cFondeo = "Recursos: Fira"
        Else
            cFondeo = "Recursos: Propios"
        End If
        LbFondeo.Text = cFondeo

        If TaOnbase.ScalarCuantosAreaAnexo("Mesa de Control", CadOnbase(cAnexo)) > 0 Then
            BtnOnbase.Enabled = True
        Else
            BtnOnbase.Enabled = False
        End If

        If TaOnbase.ScalarCuantosAreaAnexo("Credito", CadOnbase(cCliente)) > 0 Then
            BtnOnbaseCRE.Enabled = True
        Else
            BtnOnbaseCRE.Enabled = False
        End If
        If TaOnbase.ScalarCuantosAreaAnexo("Supervision Fira", CadOnbase(cAnexo)) > 0 Then
            BtnOnbaseFira.Enabled = True
        Else
            BtnOnbaseFira.Enabled = False
        End If
        ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++

    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Dim ta As New AviosDSXTableAdapters.AviosTableAdapter
        If ta.Castigados(cAnexo, cCiclo) > 0 Then
            MessageBox.Show("Crédito CASTIGADO", "Castigados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'dtpProceso.MinDate = "08/01/2017"
        'dtpProceso.Value = "08/01/2017"
        Cursor.Current = Cursors.WaitCursor
        Dim res As Object
        If dtpProceso.Value.Month = dtpProceso.MinDate.Month Then
            If TaQUERY.SacaPermisoModulo("APLICA_PAGOS", UsuarioGlobal) > 0 Then
                If ProcesadoEdoCta = False Then
                    If dtpProceso.Value >= FECHA_APLICACION Then
                        Shell(My.Settings.RootDoc & "Executables\EstadoCuentaAVCC.exe " & cAnexo & " " & cCiclo & " FIN 0 " & UsuarioGlobal & " " & 0, AppWinStyle.NormalFocus, True)
                    Else
                        Shell(My.Settings.RootDoc & "Executables\EstadoCuentaAVCC.exe " & cAnexo & " " & cCiclo & " FIN 0 " & UsuarioGlobal & " " & DIAS_MENOS, AppWinStyle.NormalFocus, True)
                    End If
                    ProcesadoEdoCta = True
                End If
                res = DBNull.Value
            Else
                Proyectado = False
                If ProcesadoEdoCta = False Then
                    res = Estado_de_Cuenta_Avio(cAnexo, cCiclo, 0, UsuarioGlobal, dtpProceso.Value.ToString("yyyyMMdd"))
                    ProcesadoEdoCta = True
                Else
                    res = DBNull.Value
                End If
            End If
        Else
            Proyectado = True
            If ProcesadoEdoCta = False Then
                res = Estado_de_Cuenta_Avio(cAnexo, cCiclo, 1, UsuarioGlobal, dtpProceso.Value.ToString("yyyyMMdd"))
                ProcesadoEdoCta = True
            Else
                res = DBNull.Value
            End If
        End If

        If Not IsDBNull(res) Then
            If cCiclo >= "04" Or Mid(cDescCiclo, 1, 6) = "PAGARE" Then
                Cursor.Current = Cursors.Default
                MessageBox.Show(res, "Error Estado de Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnProcesar.Enabled = False
                If res = "No existen ministraciones de este contrato" Then
                    EdoCtaUno()
                End If
            Else
                EdoCtaDos()
                Cursor.Current = Cursors.Default
            End If
        Else
            If cCiclo >= "04" Or Mid(cDescCiclo, 1, 6) = "PAGARE" Then
                EdoCtaUno()
                btnSaldos.Enabled = True
            Else
                EdoCtaDos()
            End If
            Cursor.Current = Cursors.Default
        End If
        btnProcesar.Enabled = False
        btnSaldos.Enabled = True

    End Sub

    Private Sub EdoCtaUno()
        Dim Cultivos As New GeneralDSTableAdapters.CultivosTableAdapter
        Dim TaTasaMora As New Agil.AviosDSXTableAdapters.AnexosTasaMoraFecORdTableAdapter
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daDetalle As New SqlDataAdapter(cm1)
        Dim drDetalle As DataRow
        Dim dtTIIE As New DataTable()
        Dim drTIIE As DataRow
        Dim myKeySearch(0) As String
        Dim newrptEdoCtaNew As New rptEdoCtaNew()
        Dim cCliente As String = ""
        Dim cPagado As String = ""
        Dim cFecha As String = ""
        Dim cFechaFinal As String = ""
        Dim cFechaInicial As String = ""
        Dim cTipta As String = ""
        Dim cTipar As String = ""
        Dim cUltimoCorte As String = ""
        Dim nConsecutivo As Integer = 0
        Dim nDias As Integer = 0
        Dim nDiferencial As Decimal = 0
        Dim nIntereses As Decimal = 0
        Dim nSaldoFinal As Decimal = 0
        Dim nSaldoFinalX As Decimal = 0
        Dim nSaldoInicial As Decimal = 0
        Dim nSumaIntereses As Decimal = 0
        Dim nTasa As Decimal = 0
        Dim nTasaBP As Decimal = 0
        Dim nTasaBPX As Decimal = 0
        Dim cAmpliacion As String = ""
        Dim cSinMoratorios As String = "N"
        Dim nImporteSEGVID As Decimal
        ' Genero la tabla que contiene las TIIE promedio por mes 
        ' Para FINAGIL considera todos los días del mes y redondea a 4 decimales

        dtTIIE = TIIEavg("FINAGIL")
        dsAgil = New DataSet()
        ' El siguiente Command trae los movimientos que existan en DetalleFINAGIL del contrato seleccionado

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT DetalleFINAGIL.*, Tipta, Tasas, DiferencialFINAGIL, UltimoCorte, FechaTerminacion, Nombre_Sucursal, tipar, rtrim(concepto)+ ' - ' + rtrim(Factura) as ConceptoX, fondeo, semilla, ampliacion, sinMoratorios FROM DetalleFINAGIL " &
                           "INNER JOIN Avios ON DetalleFINAGIL.Anexo = Avios.Anexo AND DetalleFINAGIL.Ciclo = Avios.Ciclo " &
                           "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " &
                           "INNER JOIN Sucursales ON Clientes.Sucursal = Sucursales.ID_Sucursal " &
                           "WHERE DetalleFINAGIL.Anexo = '" & cAnexo & "' AND DetalleFINAGIL.Ciclo = '" & cCiclo & "' " &
                           "ORDER BY Consecutivo"
            .Connection = cnAgil
        End With

        ' Tengo que copiar estos registros en una tabla temporal para poder calcular el registro de intereses ordinarios
        ' (si procedieran) sin necesidad de insertar un registro en la tabla física

        cFecha = DTOC(dtpProceso.Value)

        ' Llenar el DataSet lo cual abre y cierra la conexión
        daDetalle.Fill(dsAgil, "Detalle")

        For Each drDetalle In dsAgil.Tables("Detalle").Rows
            cTipar = drDetalle("tipar")
            cAmpliacion = drDetalle("Ampliacion")
            nTasa = drDetalle("Tasas")
            nDiferencial = drDetalle("DiferencialFINAGIL")
            cTipta = drDetalle("Tipta")
            cUltimoCorte = drDetalle("UltimoCorte")
            cFechaTerminacion = drDetalle("FechaTerminacion")
            cSinMoratorios = drDetalle("SinMoratorios")

            cCliente = drDetalle("Cliente")
            nConsecutivo = drDetalle("Consecutivo")
            cFechaInicial = drDetalle("FechaFinal")
            nSaldoInicial = drDetalle("SaldoFinal")
            cSemilla = drDetalle("Semilla")
            If Not IsDBNull(drDetalle("ConceptoX")) Then
                If Mid(Trim(drDetalle("ConceptoX")), Trim(drDetalle("ConceptoX")).Length, 1) <> "-" And Trim(drDetalle("Concepto")) <> "INTERESES" Then
                    drDetalle("Concepto") = Trim(drDetalle("ConceptoX"))
                End If
            End If


        Next

        If cFecha < cFechaInicial Then

            ' Se desea obtener el Estado de Cuenta a una fecha anterior al último movimiento registrado
            ' lo cual no es posible.   Lo que hace el sistema es cambiar la fecha de cálculo a la fecha
            ' del último movimiento registrado

            cFecha = cFechaInicial

        End If

        nConsecutivo += 1

        If cTipta = "7" Then 'tasa fija

            nTasaBP = Round(nTasa + nDiferencial, 4)

        Else

            ' Construyo una fecha que me permita buscar el promedio de la tasa TIIE del mes inmediato anterior

            If Proyectado = False Then
                myKeySearch(0) = Mid(DTOC(DateAdd(DateInterval.Month, -1, CTOD(cFecha))), 1, 6)
            Else
                myKeySearch(0) = Mid(DTOC(DateAdd(DateInterval.Month, -2, CTOD(cFecha))), 1, 6)
            End If

            drTIIE = dtTIIE.Rows.Find(myKeySearch)

            If drTIIE Is Nothing Then
                nTasaBP = 0
            Else
                nTasaBP = drTIIE("Promedio")
                If Proyectado = True Then
                    nTasaBP = nTasaBP + 0.2
                End If
            End If

            nTasaBP = Round(nTasaBP + nDiferencial, 4)

            'SOLICITADO POR ELISANDER DEBIDO A PRORROGA, SE SUMA UN PUNTO PORCENTUAL A PARTIR DE ENERO++++++++++++
            If (cAnexo = "070320012" Or cAnexo = "070860007" Or cAnexo = "070790010" Or cAnexo = "070780012" Or cAnexo = "070600011" Or cAnexo = "071330006") And CTOD(cFecha) >= CDate("01/01/2015") Then
                nTasaBP += 1
            End If
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        End If

        Select Case cAnexo 'PRUEBA ELISANDER
            Case "032620003"
                nTasaBP = 12.2915
            Case "086250006", "086310009"
                nTasaBP = Round(nTasaBP / 3, 4)
                If cFecha = "20161216" And cAnexo = "086310009" Then nTasaBP = 1.7571
                If cFecha = "20161222" And cAnexo = "086250006" Then nTasaBP = 7.2823
            Case Else
                nTasaBPX = nTasaBP
                If cFecha > cFechaTerminacion And cTipar <> "C" And cSinMoratorios = "N" Then
                    nTasaBP = Round(nTasaBP * 3, 4)
                ElseIf cFecha > cFechaTerminacion And cTipar = "C" And cSinMoratorios = "N" Then
                    nTasaBP = Round(nTasaBP * 2, 4)
                End If
                '++++++++++REVISA SI TIENE DESPCUENTO PO DISMINUCION DE TASA
                If TaTasaMora.TieneTasaOrdinaria(cAnexo, cCiclo) > 0 Then
                    nTasaBP = nTasaBPX
                    If TaTasaMora.TieneTercioDeTasa(cAnexo, cCiclo, True) > 0 Then
                        nTasaBP = Math.Round(nTasaBPX / 3, 4)
                    End If
                End If
                '++++++++++REVISA SI TIENE DESPCUENTO PO DISMINUCION DE TASA
        End Select



        If cTipar = "A" And cAmpliacion = "S" Then
            cTipo = "Tipo: Ampliación Linea Avio"
        ElseIf cTipar = "A" And cAmpliacion = "N" Then
            cTipo = "Tipo: Anticipo de Avio"
        ElseIf cTipar = "C" Then
            cTipo = "Tipo: Crédito en Cuenta Corriente"
        Else
            cTipo = "Tipo: Crédito de Habilitación o Avío"
        End If

        Select Case cTipar
            Case "A", "H", "S"
                cSemilla = Cultivos.SacaAliasTXT(cSemilla)
                cSemilla = "Cultivo: " & cSemilla
            Case "C"
                cSemilla = ""
        End Select


        nDias = DateDiff(DateInterval.Day, CTOD(cFechaInicial), CTOD(cFecha))

        If cFecha <= cFechaTerminacion And cFechaTerminacion >= cUltimoCorte Then ' corte de interes ordinarios
            drDetalle = dsAgil.Tables("Detalle").NewRow
            drDetalle("Anexo") = cAnexo
            drDetalle("Cliente") = cCliente
            drDetalle("Consecutivo") = nConsecutivo
            drDetalle("FechaInicial") = cFechaInicial
            drDetalle("FechaFinal") = cFecha
            drDetalle("Dias") = nDias
            drDetalle("TasaBP") = nTasaBP
            drDetalle("SaldoInicial") = nSaldoInicial
            drDetalle("SaldoFinal") = nSaldoFinal
            drDetalle("Concepto") = "INTERESES"
            drDetalle("Importe") = 0
            drDetalle("FEGA") = 0
            drDetalle("Garantia") = 0
            nIntereses = Round(nSaldoInicial * nTasaBP / 36000 * nDias, 2)
            nSaldoFinal = nSaldoInicial + nIntereses
            drDetalle("Intereses") = nIntereses
            drDetalle("SaldoFinal") = nSaldoFinal
            dsAgil.Tables("Detalle").Rows.Add(drDetalle)
            nDias = 0
            nIntereses = 0
        Else
            If nDias > 0 Then
                nIntereses = Round(nSaldoInicial * nTasaBP / 36000 * nDias, 2)
                nImporteSEGVID = ((nSaldoInicial) / 1000 * (nSegVida / 30) * nDias)
                If cTipoPersona = "M" Then
                    nImporteSEGVID = 0
                End If
            End If
        End If

        nSumaIntereses = 0
        If nSaldoInicial = 0 Then
            cPagado = "S"
        Else
            cPagado = "N"
        End If

        ' Descomentar la siguiente línea en caso de que desee modificarse el reporte rptEdoCtaNew
        ' dsAgil.WriteXml("C:\FILES\frmEdoCtaNew.xml", XmlWriteMode.WriteSchema)
        Dim ProyectadoT As String = ""
        If Proyectado = True Then
            ProyectadoT = " (Proyectado)"
        End If
        If Val(Mid(cFecha, 7, 2)) < 10 Then
            cReportTitle = "SALDO AL  " + Mid(Mes(cFecha), 2, Len(Mes(cFecha))) & ProyectadoT
            cReportTitleSaldos = "INTEGRACION DE SALDOS AL  " + Mid(Mes(cFecha), 2, Len(Mes(cFecha))) & ProyectadoT
        Else
            cReportTitle = "SALDO AL  " + Mes(cFecha) & ProyectadoT
            cReportTitleSaldos = "INTEGRACION DE SALDOS AL  " + Mes(cFecha) & ProyectadoT
        End If

        newrptEdoCtaNew.SummaryInfo.ReportTitle = cReportTitle
        newrptEdoCtaNew.SummaryInfo.ReportComments = "Cliente : " & cNombreProductor & Space(1) & cDescCiclo
        Dim poss As Integer
        poss = InStr(cDescCiclo, "Venci")
        cCicloRpt = Trim(Mid(cDescCiclo, 1, poss - 1))
        cVencRpt = Trim(Mid(cDescCiclo, poss, cDescCiclo.Length))


        newrptEdoCtaNew.SetDataSource(dsAgil)
        ReFerencia(cAnexo)
        newrptEdoCtaNew.SetParameterValue("Refe1", Banamex)
        newrptEdoCtaNew.SetParameterValue("Refe2", Bancomer)
        newrptEdoCtaNew.SetParameterValue("Refe3", BBVCIE)
        newrptEdoCtaNew.SetParameterValue("Refe4", Banorte)
        newrptEdoCtaNew.SetParameterValue("Tipo", cTipo)
        newrptEdoCtaNew.SetParameterValue("Fondeo", cFondeo)
        newrptEdoCtaNew.SetParameterValue("Semilla", cSemilla)
        newrptEdoCtaNew.SetParameterValue("Vencimiento", cVencRpt)
        newrptEdoCtaNew.SetParameterValue("Ciclo", cCicloRpt)
        newrptEdoCtaNew.SetParameterValue("Moratorios", nIntereses)
        newrptEdoCtaNew.SetParameterValue("SeguroVida", nImporteSEGVID)
        newrptEdoCtaNew.SetParameterValue("Dias", nDias)
        newrptEdoCtaNew.SetParameterValue("TasaMora", nTasaBP)
        CrystalReportViewer1.ReportSource = newrptEdoCtaNew
        CrystalReportViewer1.Zoom(89)

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub EdoCtaDos()

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim daEncabezado As New SqlDataAdapter(cm1)
        Dim daMinistracion As New SqlDataAdapter(cm2)

        Dim dsAgil As New DataSet()
        Dim dtEncabezado As New DataTable("Encabezado")
        Dim dtEdoDetAvio As New DataTable("EdoDetAvio")
        Dim dtTIIE As New DataTable()
        Dim drMinistracion As DataRow
        Dim drEdoDetAvio As DataRow
        Dim drTemporal As DataRow

        ' Declaración de variables de Crystal Reports

        Dim newrptEdoCtaAvio As New rptEdoCtaAvio()
        Dim newrptEdoDetAvio As New rptEdoDetAvio()
        Dim cReportComments As String

        ' Declaración de variables de datos

        Dim cDocumento As String = ""
        Dim cFecha As String = ""
        Dim cFechaDocumento As String = ""
        Dim cFechaInicioIntereses As String = ""
        Dim cFechaTerminacionGarantia As String = ""
        Dim cReferencia As String = "FINAGIL"
        Dim cTipta As String = ""
        Dim cUltimoPago As String = ""
        Dim nImporte As Decimal = 0
        Dim nImporteAcumulado As Decimal = 0
        Dim nImporteMinistrado As Decimal = 0
        Dim nMinistracion As Decimal = 0
        Dim nGarantiaLiquida As Decimal = 0
        Dim nInteresGarantia As Decimal = 0
        Dim nDiferencialFINAGIL As Decimal = 0
        Dim nSaldoGarantia As Decimal = 0
        Dim nSaldoMinistracion As Decimal = 0
        Dim nSaldoTotal As Decimal = 0
        Dim nSumatoria As Decimal = 0
        Dim nSumatoriaGL As Decimal = 0
        Dim nTasas As Decimal = 0

        cFecha = DTOC(dtpProceso.Value)

        dsAgil.Tables.Add(EdoCtaAvio(cAnexo, cFecha))

        ' Descomentar la siguiente línea en caso de que desee modificarse el reporte rptEdoCtaAvio
        ' dsAgil.WriteXml("C:\frmEdoCtaAvio.xml", XmlWriteMode.WriteSchema)

        If Val(Mid(cFecha, 7, 2)) < 10 Then
            cReportComments = "AL " + Mid(Mes(cFecha), 2, Len(Mes(cFecha)))
        Else
            cReportComments = "AL " + Mes(cFecha)
        End If
        newrptEdoCtaAvio.SummaryInfo.ReportComments = cReportComments

        newrptEdoCtaAvio.SetDataSource(dsAgil)
        CrystalReportViewer1.ReportSource = newrptEdoCtaAvio

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
        cm4.Dispose()

    End Sub

    Protected Sub ReFerencia(ByVal cAnexo As String)
        'Parte correspondiente a obtener Las cuentas para Depositos Referenciados

        Dim nResultado As Decimal
        Dim nSumaBanamex As Decimal
        Dim nSumaBancomer As Decimal

        Dim cRefBanamex As String
        Dim cRefBanorte As String
        Dim cRefBancomer As String

        cRefBanamex = Mid(cAnexo, 1, 5) + Mid(cAnexo, 7, 3)
        cRefBancomer = Mid(cAnexo, 2, 4) + Mid(cAnexo, 7, 3)
        cRefBanorte = Mid(cAnexo, 2, 4) + Mid(cAnexo, 7, 3)

        nSumaBanamex = 1235
        nSumaBanamex += Val(Mid(cRefBanamex, 1, 1)) * 11
        nSumaBanamex += Val(Mid(cRefBanamex, 2, 1)) * 13
        nSumaBanamex += Val(Mid(cRefBanamex, 3, 1)) * 17
        nSumaBanamex += Val(Mid(cRefBanamex, 4, 1)) * 19
        nSumaBanamex += Val(Mid(cRefBanamex, 5, 1)) * 23
        nSumaBanamex += Val(Mid(cRefBanamex, 6, 1)) * 29
        nSumaBanamex += Val(Mid(cRefBanamex, 7, 1)) * 31
        nSumaBanamex += Val(Mid(cRefBanamex, 8, 1)) * 37

        nResultado = 99 - (nSumaBanamex Mod 97)
        If nResultado > 9 Then
            cRefBanamex += "-" + nResultado.ToString
        Else
            cRefBanamex += "-" + "0" + nResultado.ToString
        End If

        nSumaBancomer = 0
        nResultado = Val(Mid(cRefBancomer, 1, 1)) * 2
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 2, 1)) * 1
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 3, 1)) * 2
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 4, 1)) * 1
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 5, 1)) * 2
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 6, 1)) * 1
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If
        nResultado = Val(Mid(cRefBancomer, 7, 1)) * 2
        If nResultado > 9 Then
            nSumaBancomer += Val(Mid(nResultado.ToString, 1, 1)) + Val(Mid(nResultado.ToString, 2, 1))
        Else
            nSumaBancomer += nResultado
        End If

        If nSumaBancomer > 60 Then
            nResultado = 70 - nSumaBancomer
        ElseIf nSumaBancomer > 50 Then
            nResultado = 60 - nSumaBancomer
        ElseIf nSumaBancomer > 40 Then
            nResultado = 50 - nSumaBancomer
        ElseIf nSumaBancomer > 30 Then
            nResultado = 40 - nSumaBancomer
        ElseIf nSumaBancomer > 20 Then
            nResultado = 30 - nSumaBancomer
        ElseIf nSumaBancomer > 10 Then
            nResultado = 20 - nSumaBancomer
        ElseIf nSumaBancomer > 0 Then
            nResultado = 10 - nSumaBancomer
        Else
            nResultado = 0
        End If

        cRefBancomer += "-" + nResultado.ToString
        cRefBanorte = cRefBancomer

        Banamex = "BANAMEX		Suc. 285 Cuenta 7944154	Referencia: " & cRefBanamex
        Bancomer = "BANCOMER		Convenio 581034			Referencia: " & cRefBancomer
        Banorte = "BANORTE		CEP 36832				Referencia: " & cRefBanorte
        BBVCIE = "BANCOMER  INTERBANCARIO  Convenio CIE 1244159  CIE Interbancario 012914002012441593  Referencia: " & cRefBancomer

    End Sub

    Private Sub BtnOnbase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOnbase.Click
        Dim f As New FrmDocOnbase
        f.Area = "Mesa de Control"
        f.AnexoOcliente = cAnexo
        f.Titulo = Me.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        f.Dispose()
    End Sub

    Private Sub BtnOnbaseCRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOnbaseCRE.Click
        Dim f As New FrmDocOnbase
        f.Area = "Credito"
        f.AnexoOcliente = cCliente
        f.Titulo = Me.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        f.Dispose()
    End Sub

    Private Sub btnReferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaldos.Click
        ProcesadoEdoCta = False
        Dim Avi As New AviosDSX
        Dim r As DataRow
        Dim Cap As Decimal
        Dim CapMora As Decimal
        Dim Inte As Decimal
        Dim InteMora As Decimal
        Dim Gara As Decimal
        Dim GaraMora As Decimal
        Dim Pago As Decimal
        Dim PagoI As Decimal
        Dim PagoC As Decimal
        Dim PagoG As Decimal
        Dim PagoM As Decimal
        Dim PagoS As Decimal
        Dim SegVid As Decimal
        Dim SaldoAnexo As Decimal


        For Each r In dsAgil.Tables("Detalle").Rows
            If r.Item("FechaFinal") <= cFechaTerminacion Then ' ANTES DE MORATORIOS
                Select Case Trim(r.Item("Concepto"))
                    Case "INTERESES"
                        Inte += r.Item("Intereses")
                    Case Else
                        If InStr(Trim(r.Item("Concepto")), "PAGO") > 0 Or InStr(Trim(r.Item("Concepto")), "NC") > 0 Then
                            PagoC += Abs(r.Item("importe") + r.Item("Fega"))
                            PagoI += Abs(r.Item("Intereses"))
                            PagoG += Abs(r.Item("Garantia"))
                        Else
                            Cap += r.Item("Importe") + r.Item("Fega")
                            Gara += r.Item("Garantia")
                        End If
                End Select
            Else ' DESPUES DE MORATORIOS
                Select Case Trim(r.Item("Concepto"))
                    Case "INTERESES"
                        InteMora += r.Item("Intereses")
                    Case "PAGO"

                    Case Else
                        If InStr(Trim(r.Item("Concepto")), "SEGURO DE VIDA") > 0 Then
                            SegVid += r.Item("importe") + r.Item("Fega") + r.Item("Garantia") + r.Item("Intereses")
                        ElseIf InStr(Trim(r.Item("Concepto")), "PAGO") > 0 Or InStr(Trim(r.Item("Concepto")), "NC") > 0 Then
                            'Pago += Abs(r.Item("importe") + r.Item("Fega") + r.Item("Garantia") + r.Item("Intereses"))
                            PagoC += Abs(r.Item("importe") + r.Item("Fega"))
                            PagoI += Abs(r.Item("Intereses"))
                            PagoG += Abs(r.Item("Garantia"))
                        Else
                            CapMora += r.Item("Importe") + r.Item("Fega")
                            GaraMora += r.Item("Garantia")
                        End If

                End Select
            End If
        Next

        If PagoC > Cap Then
            PagoS += PagoC - Cap
            PagoC = Cap
        End If

        If PagoI > Inte Then
            PagoM += PagoI - Inte
            PagoI = Inte
        End If

        Dim rr As AviosDSX.SaldosIntegradosRow
        'CAPITAL+++++++++++++++++++++++++++++++++
        rr = Avi.SaldosIntegrados.NewSaldosIntegradosRow
        rr.Anexo = txtAnexo.Text
        rr.Concepto = "Capital"
        rr.Importe = Cap
        rr.Pagos = PagoC
        rr.Saldo = Cap - PagoC
        Avi.SaldosIntegrados.AddSaldosIntegradosRow(rr)
        'INTERES+++++++++++++++++++++++++++++++++
        rr = Avi.SaldosIntegrados.NewSaldosIntegradosRow
        rr.Anexo = txtAnexo.Text
        rr.Concepto = "Interes"
        rr.Importe = Inte
        rr.Pagos = PagoI
        rr.Saldo = Inte - PagoI
        Avi.SaldosIntegrados.AddSaldosIntegradosRow(rr)
        'GARANTIA+++++++++++++++++++++++++++++++++
        rr = Avi.SaldosIntegrados.NewSaldosIntegradosRow
        rr.Anexo = txtAnexo.Text
        rr.Concepto = "Garantía Líquida"
        rr.Importe = Gara
        rr.Pagos = PagoG
        rr.Saldo = Gara - PagoG
        Avi.SaldosIntegrados.AddSaldosIntegradosRow(rr)
        'TOTALES+++++++++++++++++++++++++++++++++
        rr = Avi.SaldosIntegrados.NewSaldosIntegradosRow
        rr.Anexo = txtAnexo.Text
        rr.Concepto = "Total al vencimiento"
        rr.Importe = Gara + Inte + Cap
        rr.Pagos = PagoC + PagoG + PagoI
        rr.Saldo = rr.Importe - rr.Pagos
        Avi.SaldosIntegrados.AddSaldosIntegradosRow(rr)
        'MORATORIOS+++++++++++++++++++++++++++++++++
        rr = Avi.SaldosIntegrados.NewSaldosIntegradosRow
        rr.Anexo = txtAnexo.Text
        rr.Concepto = "Intereses Moratorios"
        rr.Importe = InteMora
        rr.Pagos = PagoM
        rr.Saldo = rr.Importe - rr.Pagos
        Avi.SaldosIntegrados.AddSaldosIntegradosRow(rr)
        'SEGURO DE VIDA+++++++++++++++++++++++++++++++++
        rr = Avi.SaldosIntegrados.NewSaldosIntegradosRow
        rr.Anexo = txtAnexo.Text
        rr.Concepto = "Seguro de Vida cobrados después del vencimiento"
        rr.Importe = SegVid
        rr.Pagos = PagoS
        rr.Saldo = rr.Importe - rr.Pagos
        Avi.SaldosIntegrados.AddSaldosIntegradosRow(rr)

        'Totales+++++++++++++++++++++++++++++++++
        rr = Avi.SaldosIntegrados.NewSaldosIntegradosRow
        rr.Anexo = txtAnexo.Text
        rr.Concepto = "Saldos después de Pagos al Vencimiento"
        rr.Importe = Cap + Inte + Gara + InteMora + SegVid
        rr.Pagos = PagoC + PagoG + PagoI + PagoM + PagoS
        rr.Saldo = rr.Importe - rr.Pagos
        SaldoAnexo = rr.Saldo - (Gara - PagoG)
        Avi.SaldosIntegrados.AddSaldosIntegradosRow(rr)

        Dim RptNewSaldos As New rptEdoCtaSaldos
        RptNewSaldos.SummaryInfo.ReportTitle = cReportTitleSaldos
        RptNewSaldos.SummaryInfo.ReportComments = "Cliente : " & cNombreProductor & Space(1) & cDescCiclo
        Dim poss As Integer
        poss = InStr(cDescCiclo, "Venci")
        cCicloRpt = Trim(Mid(cDescCiclo, 1, poss - 1))
        cVencRpt = Trim(Mid(cDescCiclo, poss, cDescCiclo.Length))


        RptNewSaldos.SetDataSource(Avi)
        RptNewSaldos.SetParameterValue("Tipo", cTipo)
        RptNewSaldos.SetParameterValue("Fondeo", cFondeo)
        RptNewSaldos.SetParameterValue("Semilla", cSemilla)
        RptNewSaldos.SetParameterValue("Vencimiento", cVencRpt)
        RptNewSaldos.SetParameterValue("Ciclo", cCicloRpt)
        RptNewSaldos.SetParameterValue("Remanente", Gara - PagoG)
        RptNewSaldos.SetParameterValue("SaldoAnexo", SaldoAnexo)
        CrystalReportViewer1.ReportSource = RptNewSaldos
        CrystalReportViewer1.Zoom(100)
        btnProcesar.Enabled = True
        btnSaldos.Enabled = False
    End Sub

    Private Sub BtnOnbaseFira_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnOnbaseFira.Click
        Dim f As New FrmDocOnbase
        f.Area = "Supervision Fira"
        f.AnexoOcliente = cAnexo
        f.Titulo = Me.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        f.Dispose()
    End Sub

    Private Sub BtnSoldoc_Click(sender As Object, e As EventArgs) Handles BtnSoldoc.Click
        Dim F As New frmbitacora_anexos
        F.cAnexo = cAnexo
        F.cCiclo = cCiclo
        If F.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Private Sub btnHist_Click(sender As Object, e As EventArgs) Handles btnHist.Click
        Dim newfrmHistoria As New frmHistoria(cAnexo, cCiclo)
        Cursor.Current = Cursors.WaitCursor
        newfrmHistoria.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New FrmAtachments
        f.Anexo = cAnexo
        f.Ciclo = cCiclo
        f.Carpeta = "Seguros"
        If TaQUERY.SacaPermisoModulo("SEGUROS_DOC", UsuarioGlobal) > 0 Then
            f.Consulta = False
        Else
            f.Consulta = True
        End If
        f.Nombre = cNombreProductor
        If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New FrmAtachments
        f.Anexo = cAnexo
        f.Ciclo = cCiclo
        f.Carpeta = "Avío"
        If TaQUERY.SacaPermisoModulo("AVIO_DOC", UsuarioGlobal) > 0 Then
            f.Consulta = False
        Else
            f.Consulta = True
        End If
        f.Nombre = cNombreProductor
        If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub btnDatosCliente_Click(sender As Object, e As EventArgs) Handles btnDatosCliente.Click
        Dim newfrmDatosClie As New frmDatosclie(cCliente)
        newfrmDatosClie.Show()
    End Sub

    Private Sub frmEdoCtaAvio_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub frmEdoCtaAvio_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        If Proyectado = True Then
            'regreso el estado de cuneta a su fecha de corte
            Estado_de_Cuenta_Avio(cAnexo, cCiclo, 0, UsuarioGlobal, FECHA_APLICACION.ToString("yyyyMMdd"))
        End If
    End Sub
End Class