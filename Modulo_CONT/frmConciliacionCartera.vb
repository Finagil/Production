Option Explicit On
Imports System.IO
Imports System.Data.SqlClient

Public Class frmConciliacionCartera
    Dim cFecha As String
    Dim cFechaInt As String
    Dim cFechaCortoPalzo As String
    Dim cYear As String
    Dim R As ContaDS.CarteraGlobalRow


    Private Sub btnProceso_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProceso.Click
        Cursor.Current = Cursors.WaitCursor
        Dim strConnAux As String
        Dim DB As String = "Production"
        If CmbDB.SelectedIndex <> 0 Then DB = CmbDB.Text
        strConnAux = "Server=SERVER-RAID; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"

        Dim cnAgil As New SqlConnection(strConnAux)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()



        Dim daAnexo As New SqlDataAdapter(cm1)
        Dim daEdoctav As New SqlDataAdapter(cm2)
        Dim daFacturas As New SqlDataAdapter(cm3)
        Dim drAnexo As DataRow
        Dim dsAgil As New DataSet()
        Dim relAnexoEdoctav As DataRelation
        Dim relAnexoFacturas As DataRelation
        Dim cAnexo As String = ""
        Dim cTipta As String = ""
        Dim cCliente As String = ""
        Dim cTipar As String = ""

        If CmbDB.SelectedIndex = 0 Then
            cFecha = DTPFecha.Value.ToString("yyyyMMdd")
        Else
            cFecha = CmbDB.SelectedValue
        End If
        cFechaCortoPalzo = CTOD(cFecha).AddYears(1).ToString("yyyyMMdd")
        cFechaInt = CTOD(cFecha).AddDays(1).ToString("yyyyMMdd")


        ' Primero creo la tabla Temporal que me permitirá acumular los saldos de los 
        ' contratos por cliente

        cYear = Mid(cFecha, 1, 4)
        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv11"
            .Connection = cnAgil
            .Parameters.Add("@Fechafin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Con este Store Procedure obtengo la tabla de amortización del equipo de todos los contratos activos a la fecha solicitada

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv22"
            .Connection = cnAgil
            .Parameters.Add("@Fechafin", SqlDbType.NVarChar)
            .Parameters.Add("@FechaInt", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
            .Parameters(1).Value = cFechaInt
        End With

        ' Este Stored Procedure trae todas las facturas no pagadas de todos los contratos activos con fecha de
        ' contratación menor o igual a la de proceso

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "CalcAnti1"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daAnexo.Fill(dsAgil, "Anexos")
        daEdoctav.Fill(dsAgil, "Edoctav")
        daFacturas.Fill(dsAgil, "Facturas")

        ' Establecer la relación entre Anexos y Edoctav

        relAnexoEdoctav = New DataRelation("AnexoEdoctav", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Edoctav").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctav)

        ' Establecer la relación entre Anexos y Facturas

        relAnexoFacturas = New DataRelation("AnexoFacturas", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Facturas").Columns("Anexo"))
        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoFacturas)

        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cAnexo = Trim(drAnexo("Anexo"))
            cTipar = drAnexo("Tipar")
            cTipta = drAnexo("Tipta")
            cCliente = drAnexo("Cliente")

            'excluye castigados por valentin
            If InStr("021360003|022640002|025960001|027070001|027290001|027790001|027800001|027870001|030200001|019820004|027650001|022840002|009130005|014280004|014400005|017040007|017940006|018450004|019010003|022670002|023230002|023490002|023750001|025060001|025330001|025420001|025950002|026850001|027060002|027300001|027300002|028020001|028560002|029360001'", cAnexo) <= 0 Then
                Proyecta(cCliente, cAnexo, drAnexo, cTipta, cTipar)
            End If
        Next

        Dim rptCarteraGlobal1 As New rptConciliacionCartera
        rptCarteraGlobal1.SetDataSource(ContaDS)
        rptCarteraGlobal1.SetParameterValue("titulo", CTOD(cFecha).ToString("dd \DE MMMM \DEL yyyy").ToUpper)
        CRViewer.ReportSource = rptCarteraGlobal1

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Proyecta(ByVal cCliente As String, ByVal cAnexo As String, ByVal drAnexo As DataRow, ByVal cTipta As String, ByVal cTipar As String)
        Dim drEdocta As DataRow
        Dim drEstados As DataRow()
        Dim drFacturas As DataRow()
        'Dim lConsiderar As Boolean = False
        'Dim nCounter As Integer
        Dim nMaxCounter As Integer = 100
        Dim cOrigen As String = ""
        Dim cCiclo As String = ""
        Dim cad As String = ""
        Dim CliNom As String = ""
        Dim nMontoC As Decimal
        Dim nMontoL As Decimal
        Dim nMontoIC As Decimal
        Dim nMontoIL As Decimal
        Dim cAnexoX As String = ""
        Dim cTipoCredito As String = ""

        If taQuery.EsParteRelacionada(cCliente) > 0 Then
            cad = "Relacionados" & vbTab
        Else
            cad = "No Relacionados" & vbTab
        End If

        drFacturas = drAnexo.GetChildRows("AnexoFacturas")
        CalcAnti(cAnexo, cFecha, nMaxCounter, 0, drFacturas)
        drEstados = drAnexo.GetChildRows("AnexoEdoctav")
        For Each drEdocta In drEstados
            If (drEdocta("Feven") > cFecha) And drEdocta("Nufac") <> 9999999 Then
                If taQuery.EsParteRelacionada(cCliente) > 0 Then
                    cad = "Relacionados"
                Else
                    cad = "No Relacionados"
                End If
                cTipoCredito = taQuery.SacaTipoCreditoAnexo(cAnexo)
                cAnexoX = Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4)
                cOrigen = drEdocta("origen")
                If cOrigen = "Contratos" Or cOrigen = "Contratos Otros" Then
                    If taQuery.SacaEstatusContable(cAnexo) <> "VENCIDA" Then
                        cOrigen = "Contratos Vigentes"
                    Else
                        cOrigen = "Contratos Vencidos"
                    End If
                End If
                If cOrigen = "Seguros" Then
                    If taQuery.SacaEstatusContable(cAnexo) <> "VENCIDA" Then
                        cOrigen = "Seguros Vigentes"
                    Else
                        cOrigen = "Seguros Vencidos"
                    End If
                End If

                If cOrigen = "Avios" Then
                    cAnexoX = Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & drEdocta("letra")
                    If cTipar = "C" Then
                        cOrigen = "Cuenta Corriente"
                    End If
                    If taQuery.SacaEstatusContable(cAnexo) <> "VENCIDA" Then
                        cOrigen = cOrigen & " Vigentes"
                    Else
                        cOrigen = cOrigen & " Vencidos"
                    End If
                End If

                If cOrigen = "Garantias" Then
                    cTipoCredito = "CREDITO SIMPLE"
                End If

                If drEdocta("Feven") <= cFechaCortoPalzo Then
                    nMontoC = drEdocta("Abcap")
                    nMontoIC = drEdocta("Inter")
                    nMontoL = 0
                    nMontoIL = 0
                Else
                    nMontoL = drEdocta("Abcap")
                    nMontoIL = drEdocta("Inter")
                    nMontoC = 0
                    nMontoIC = 0
                End If


                'f2.WriteLine(cAnexo & vbTab & CliNom & vbTab & cTipar & vbTab & nMonto & vbTab & nMontoI & vbTab & cad & vbTab & cOrigen & vbTab & nMontoC & vbTab & nMontoIC & vbTab & nMontoL & vbTab & nMontoIL & vbTab & drEdocta("FechaIni") & vbTab & drEdocta("Feven"))
                R = ContaDS.CarteraGlobal.NewCarteraGlobalRow()
                R.Anexo = cAnexoX
                R.Cliente = drEdocta("Descr").Trim
                R.TipoCredito = cTipoCredito
                R.Monto = drEdocta("Abcap")
                R.Interes = drEdocta("Inter")
                R.Partes = cad
                R.Origen = cOrigen
                R.Monto_Corto = nMontoC
                R.Inte_Corto = nMontoIC
                R.Monto_Largo = nMontoL
                R.Inte_Largo = nMontoIL
                R.FechaContrato = CTOD(drEdocta("FechaIni"))
                R.FechaVencimiento = CTOD(drEdocta("Feven"))
                ContaDS.CarteraGlobal.AddCarteraGlobalRow(R)
            End If
        Next

    End Sub

    Private Sub frmCarteraGlobal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New DataTable
        Dim r As DataRow
        t.Columns.Add("ID")
        t.Columns.Add("TIT")

        Dim Fecha As Date = Date.Now
        r = t.NewRow
        r("ID") = Date.Now.ToString("yyyyMMdd")
        r("TIT") = "A la Fecha"
        t.Rows.Add(r)

        For x As Integer = 0 To 11
            Fecha = Fecha.AddDays(-1 * Fecha.Day)
            If Fecha >= "01/01/2016" Then
                r = t.NewRow
                r("ID") = Fecha.ToString("yyyyMMdd")
                r("TIT") = Mid(Fecha.ToString("yyyyMMM").ToUpper, 1, 7)
                t.Rows.Add(r)
            End If
        Next
        CmbDB.DataSource = t
        CmbDB.DisplayMember = t.Columns("TIT").ToString
        CmbDB.ValueMember = t.Columns("ID").ToString
        CmbDB.SelectedIndex = 1
    End Sub

    Private Sub CmbDB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDB.SelectedIndexChanged
        If CmbDB.SelectedIndex = 0 Then
            DTPFecha.Enabled = True
            DTPFecha.MinDate = FECHA_APLICACION.AddDays(FECHA_APLICACION.Day * -1).AddDays(1)
            DTPFecha.MaxDate = FECHA_APLICACION
        Else
            DTPFecha.Enabled = False
        End If
    End Sub

End Class
