Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports System.Text.ASCIIEncoding
Imports Microsoft.VisualBasic
Public Class frmDomiciliacion
    Inherits System.Windows.Forms.Form

    Dim dsAgil As New DataSet()
    Dim i As Integer = 0
    Dim j As Integer = 0
    Dim dtDomiciliacion As New DataTable("Domic")
    Dim dtTemporal As New DataTable("Temporal")
    Dim dtPagos As New DataTable("Cobros")
    Dim dtTemp As New DataTable("Cambios")
    Dim dtAdicional As New DataTable("CobroAd")
    Dim oKey(1) As DataColumn

    Dim drDomic As DataRow
    Dim cCuentaant As String
    Dim cTitularant As String
    Dim cNameant As String
    Dim cBancoant As String
    Dim cContratoant As String
    Dim cContrato As String
    Dim cLetra As String
    Dim cVencimiento As String
    Dim cUltimoPago As String
    Dim nSaldoTotal As Decimal
    Dim nIvaMoratorios As Decimal
    Dim nMoratorios As Decimal
    Dim nSaldo As Decimal
    Dim nRenglones As Integer
    Dim lFirstTime As Boolean = True

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim drAnexo As DataRow

        Dim cFeven As String
        Dim flag As String = ""
  
        Dim daAnexos As New SqlDataAdapter(cm1)

        btnLayOut.Visible = False
        Label3.Visible = False
        cbDeudor.Visible = False
        lblSaldos.Visible = False
        DataGridView1.Visible = False
        Label4.Visible = False
        cbSinAdeudo.Visible = False
        Label5.Visible = False
        DataGridView2.Visible = False
        lblPagos.Visible = False
        DataGridView3.Visible = False

        cFeven = DTOC(dtpProcesar.Value)

        'Imprime el Archivo Plano para los Pagos con Cuenta Bancomer

        cnAgil.Open()

        If rbBmer.Checked = True Then
            With cm1
                .CommandType = CommandType.Text
                .CommandText = "SELECT SaldoFac, Descr, CuentasDomi.Banco, CuentasDomi.CuentaCLABE, CuentasDomi.NumTarjeta, CuentasDomi.CuentaEJE, CuentasDomi.TitularCta, Referencia, Facturas.Letra, Anexos.Autoriza, Facturas.Anexo, Tipo, Facturas.Feven, Facturas.Fepag FROM Facturas " &
                               " Inner Join Clientes On Facturas.Cliente = Clientes.Cliente " &
                               " INNER JOIN CuentasDomi ON CuentasDomi.ANEXO = FACTURAS.ANEXO " &
                               " INNER JOIN ANEXOS ON ANEXOS.ANEXO = FACTURAS.ANEXO " &
                               " WHERE Feven = '" & cFeven & "' And Anexos.Autoriza = 'S' And CuentasDomi.CuentaCLABE = '' And Facturas.SaldoFac > 0 UNION " &
                               "SELECT SaldoFac, Descr, CuentasDomi.Banco, CuentasDomi.CuentaCLABE, CuentasDomi.NumTarjeta, CuentasDomi.CuentaEJE, CuentasDomi.TitularCta, Referencia, Facturas.Letra, Anexos.Autoriza, Facturas.Anexo, Tipo, Facturas.Feven, Facturas.Fepag FROM Facturas " &
                               " Inner Join Clientes On Facturas.Cliente = Clientes.Cliente " &
                               " INNER JOIN CuentasDomi ON CuentasDomi.ANEXO = FACTURAS.ANEXO " &
                               " INNER JOIN ANEXOS ON ANEXOS.ANEXO = FACTURAS.ANEXO " &
                               " WHERE Feven = '" & cFeven & "' And Anexos.Autoriza = 'S' And CuentasDomi.CuentaCLABE <> '' And CuentasDomi.Banco = '" & "BANCOMER" & "' And Facturas.SaldoFac > 0"
                .Connection = cnAgil

            End With
            daAnexos.Fill(dsAgil, "Pagos")
        End If

        If rbNoBmer.Checked = True Then
            With cm1
                .CommandType = CommandType.Text
                .CommandText = "SELECT SaldoFac, Descr, CuentasDomi.Banco, CuentasDomi.CuentaCLABE, CuentasDomi.NumTarjeta, CuentasDomi.CuentaEJE, CuentasDomi.TitularCta, Referencia, Facturas.Letra, Anexos.Autoriza, Facturas.Anexo, Tipo, Facturas.Feven, Facturas.Fepag FROM Facturas " &
                                  " Inner Join Clientes On Facturas.Cliente = Clientes.Cliente " &
                                  " INNER JOIN CuentasDomi ON CuentasDomi.ANEXO = FACTURAS.ANEXO " &
                                  " INNER JOIN ANEXOS ON ANEXOS.ANEXO = FACTURAS.ANEXO " &
                                  " WHERE Feven = '" & cFeven & "' And Anexos.Autoriza = 'S' And CuentasDomi.CuentaCLABE <> '' And CuentasDomi.Banco <> '" & "BANCOMER" & "' And Facturas.SaldoFac > 0"
                .Connection = cnAgil

            End With
            daAnexos.Fill(dsAgil, "Pagos")
        End If

      
        ' Luego creo dos tablas necesarias para ir guardando los adeudos

        dtDomiciliacion.Columns.Add("Contrato", Type.GetType("System.String"))
        dtDomiciliacion.Columns.Add("Letra", Type.GetType("System.String"))
        dtDomiciliacion.Columns.Add("Vencimiento", Type.GetType("System.String"))
        dtDomiciliacion.Columns.Add("UltimoPago", Type.GetType("System.String"))
        dtDomiciliacion.Columns.Add("Saldo", Type.GetType("System.Decimal"))
        dtDomiciliacion.Columns.Add("Banco", Type.GetType("System.String"))
        dtDomiciliacion.Columns.Add("Tipo", Type.GetType("System.String"))
        dtDomiciliacion.Columns.Add("Cuenta", Type.GetType("System.String"))
        dtDomiciliacion.Columns.Add("Titular", Type.GetType("System.String"))
        dtDomiciliacion.Columns.Add("Name", Type.GetType("System.String"))
        dtDomiciliacion.Columns.Add("Referencia", Type.GetType("System.String"))
        oKey(0) = dtDomiciliacion.Columns("Contrato")
        oKey(1) = dtDomiciliacion.Columns("Letra")
        dtDomiciliacion.PrimaryKey = oKey

        ' Luego creo dos tablas necesarias para ir guardando los adeudos

        dtTemporal.Columns.Add("Contrato", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Letra", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Vencimiento", Type.GetType("System.String"))
        dtTemporal.Columns.Add("UltimoPago", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Saldo", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("Moratorios", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("IVA Moratorios", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("Pago Total", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("Banco", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Cuenta", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Titular", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Name", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Referencia", Type.GetType("System.String"))
        dtTemporal.Clear()

        ' Luego creo dos tablas necesarias para ir guardando los adeudos

        dtTemp.Columns.Add("Contrato", Type.GetType("System.String"))
        dtTemp.Columns.Add("Letra", Type.GetType("System.String"))
        dtTemp.Columns.Add("Vencimiento", Type.GetType("System.String"))
        dtTemp.Columns.Add("UltimoPago", Type.GetType("System.String"))
        dtTemp.Columns.Add("Saldo", Type.GetType("System.Decimal"))
        dtTemp.Columns.Add("Moratorios", Type.GetType("System.Decimal"))
        dtTemp.Columns.Add("IVA Moratorios", Type.GetType("System.Decimal"))
        dtTemp.Columns.Add("Pago Total", Type.GetType("System.Decimal"))
        dtTemp.Columns.Add("Banco", Type.GetType("System.String"))
        dtTemp.Columns.Add("Cuenta", Type.GetType("System.String"))
        dtTemp.Columns.Add("Titular", Type.GetType("System.String"))
        dtTemp.Columns.Add("Name", Type.GetType("System.String"))
        dtTemp.Columns.Add("Referencia", Type.GetType("System.String"))
        dtTemp.Clear()
        dtAdicional = dtTemp.Clone()

        For Each drAnexo In dsAgil.Tables("Pagos").Rows
            drDomic = dtDomiciliacion.NewRow()
            drDomic("Contrato") = drAnexo("Anexo")
            drDomic("Letra") = drAnexo("Letra")
            If Trim(drAnexo("Feven")) <> "" Then
                drDomic("Vencimiento") = drAnexo("Feven")
            Else
                drDomic("Vencimiento") = "        "
            End If
            If Trim(drAnexo("Fepag")) <> "" Then
                drDomic("UltimoPago") = drAnexo("Fepag")
            Else
                drDomic("UltimoPago") = "        "
            End If
            drDomic("Saldo") = drAnexo("SaldoFac")
            drDomic("Banco") = drAnexo("Banco")
            drDomic("Tipo") = drAnexo("Tipo")
            If Trim(drAnexo("CuentaCLABE")) <> "" Then
                drDomic("Cuenta") = drAnexo("CuentaCLABE")
            ElseIf Trim(drAnexo("NumTarjeta")) <> "" Then
                drDomic("Cuenta") = drAnexo("NumTarjeta")
            Else
                drDomic("Cuenta") = drAnexo("CuentaEJE")
            End If
            drDomic("Titular") = drAnexo("TitularCta")
            drDomic("Name") = drAnexo("Descr")
            drDomic("Referencia") = drAnexo("Referencia")
            dtDomiciliacion.Rows.Add(drDomic)
        Next
     
        btnProcesar.Enabled = False
        btnAdd.Enabled = True

        MsgBox("Proceso Terminado", MsgBoxStyle.Information, "Mensaje")
    
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand
        Dim daDeudores As New SqlDataAdapter(cm2)
        Dim daSinAdeudo As New SqlDataAdapter(cm3)
        Dim dsAgil As New DataSet()
        Dim myColArray(1) As DataColumn
        Dim drSinAd As DataRow
        Dim drDatos As DataRow
        Dim dtNoAdeudo As New DataTable("CtesNoAd")
       
        ' Declaración de variables de datos

        Dim cFechaPago As String
        Dim cCliente As String
        Dim cContrato As String
        Dim cDescr As String
        Dim nCons As Integer
        Dim nSuma As Decimal
        Dim nImporte As Decimal
        Dim oKey1(1) As DataColumn

        cFechaPago = DTOC(dtpProcesar.Value)

        btnLayOut.Visible = True
        btnLayOut.Enabled = True
        Label3.Visible = True
        cbDeudor.Visible = True
        lblSaldos.Visible = True
        DataGridView1.Visible = True
        Label4.Visible = True
        cbSinAdeudo.Visible = True
        Label5.Visible = True
        DataGridView2.Visible = True
        lblPagos.Visible = True
        DataGridView3.Visible = True

        dtNoAdeudo.Columns.Add("Cliente", Type.GetType("System.String"))
        dtNoAdeudo.Columns.Add("Descr", Type.GetType("System.String"))
       
        If rbBmer.Checked = True Then
            With cm2
                .CommandType = CommandType.Text
                .CommandText = "SELECT Distinct Anexos.Anexo, Anexos.Cliente, Descr FROM Anexos " & _
                              "INNER JOIN Clientes ON Clientes.Cliente = Anexos.Cliente " & _
                              "INNER JOIN Facturas ON Facturas.Anexo = Anexos.Anexo " & _
                              "INNER JOIN CuentasDomi ON CuentasDomi.Anexo = Anexos.Anexo " & _
                              "WHERE Anexos.Autoriza = " & "'" & "S" & "'" & " And Flcan = " & "'" & "A" & "'" & " And Facturas.Saldofac > " & 0 & " And CuentasDomi.CuentaCLABE = " & "'" & "'" & " And Feven < " & " '" & cFechaPago & "'" & " UNION " & _
                              "SELECT Distinct Anexos.Anexo, Anexos.Cliente, Descr FROM Anexos " & _
                              "INNER JOIN Clientes ON Clientes.Cliente = Anexos.Cliente " & _
                              "INNER JOIN Facturas ON Facturas.Anexo = Anexos.Anexo " & _
                              "INNER JOIN CuentasDomi ON CuentasDomi.Anexo = Anexos.Anexo " & _
                              "WHERE Anexos.Autoriza = " & "'" & "S" & "'" & " And Flcan = " & "'" & "A" & "'" & " And Facturas.Saldofac > " & 0 & " And CuentasDomi.CuentaCLABE <> " & "'" & "'" & " And CuentasDomi.Banco = " & "'" & "BANCOMER" & "'" & " And Feven < " & " '" & cFechaPago & "'" & " ORDER BY Descr"
                .Connection = cnAgil
            End With
            daDeudores.Fill(dsAgil, "Deudores")

            With cm3
                .CommandType = CommandType.Text
                .CommandText = "SELECT Anexos.anexo, Anexos.cliente, Descr, Sum(SaldoFac) As Saldot, Feven, CuentasDomi.Banco, CuentasDomi.CuentaCLABE, NumTarjeta, TitularCta  FROM Anexos " & _
                               "LEFT JOIN Facturas ON Facturas.Anexo = Anexos.Anexo " & _
                               "LEFT JOIN Clientes ON Clientes.Cliente = Anexos.Cliente " & _
                               "LEFT JOIN CuentasDomi ON CuentasDomi.Anexo = Anexos.Anexo " & _
                               "WHERE Anexos.Autoriza = " & "'" & "S" & "'" & " AND Flcan = " & "'" & "A" & "'" & " And CuentasDomi.Banco = " & "'BANCOMER'" & " AND Feven <= " & "'" & cFechaPago & "'" & _
                               "GROUP BY Anexos.anexo, Anexos.cliente, anexos.autoriza, descr, flcan, feven, cuentasdomi.banco, Cuentasdomi.cuentaclabe, cuentasdomi.numtarjeta, cuentasdomi.titularcta " & _
                               "ORDER BY Descr, Anexos.Anexo"
                '             "HAVING  SUM(Facturas.Saldofac) = 0 ORDER BY Descr, Anexos.Anexo"
                .Connection = cnAgil
            End With
            daSinAdeudo.Fill(dsAgil, "SinAdeudo")
        End If

        If rbNoBmer.Checked = True Then
            With cm2
                .CommandType = CommandType.Text
                .CommandText = "SELECT Distinct Anexos.Anexo, Anexos.Cliente, Descr FROM Anexos " & _
                               "INNER JOIN Clientes ON Clientes.Cliente = Anexos.Cliente " & _
                               "INNER JOIN Facturas ON Facturas.Anexo = Anexos.Anexo " & _
                               "INNER JOIN CuentasDomi ON CuentasDomi.Anexo = Anexos.Anexo " & _
                               "WHERE Anexos.Autoriza = " & "'" & "S" & "'" & " And Flcan = " & "'" & "A" & "'" & " And Facturas.Saldofac > " & 0 & " And CuentasDomi.CuentaCLABE <> " & "'" & "'" & " And CuentasDomi.Banco <> " & "'" & "BANCOMER" & "'" & " And Feven < " & " '" & cFechaPago & "'" & " ORDER BY Descr"
                .Connection = cnAgil
            End With
            daDeudores.Fill(dsAgil, "Deudores")

            With cm3
                .CommandType = CommandType.Text
                .CommandText = "SELECT Anexos.anexo, Anexos.cliente, Descr, Sum(SaldoFac) As Saldot, Feven,CuentasDomi.Banco, CuentasDomi.CuentaCLABE, NumTarjeta, TitularCta  FROM Anexos " & _
                               "LEFT JOIN Facturas ON Facturas.Anexo = Anexos.Anexo " & _
                               "LEFT JOIN Clientes ON Clientes.Cliente = Anexos.Cliente " & _
                               "LEFT JOIN CuentasDomi ON CuentasDomi.Anexo = Anexos.Anexo " & _
                               "WHERE Anexos.Autoriza = " & "'" & "S" & "'" & " AND Flcan = " & "'" & "A" & "'" & " And CuentasDomi.Banco <> " & "'BANCOMER'" & " AND Feven <= " & "'" & cFechaPago & "'" & _
                               "GROUP BY Anexos.anexo, Anexos.cliente, anexos.autoriza, descr, flcan, feven, cuentasdomi.banco, Cuentasdomi.cuentaclabe, cuentasdomi.numtarjeta, cuentasdomi.titularcta " & _
                               "ORDER BY Descr, Anexos.Anexo"
                '                            "HAVING  SUM(Facturas.Saldofac) = 0 ORDER BY Descr, Anexos.Anexo"
                .Connection = cnAgil
            End With
            daSinAdeudo.Fill(dsAgil, "SinAdeudo")
        End If

        ' Ligar la tabla Deudores del Dataset dsAgil al ComboBox de Deudores

        cbDeudor.DataSource = dsAgil
        cbDeudor.DisplayMember = "Deudores.Descr"
        cbDeudor.ValueMember = "Deudores.Cliente"
        lFirstTime = False

        nCons = 0
        For Each drDatos In dsAgil.Tables("SinAdeudo").Rows
            'cCliente = drDatos("Cliente")
            'cDescr = drDatos("Descr")
            'drSinAd = dtNoAdeudo.NewRow()
            'drSinAd("Cliente") = cCliente
            'drSinAd("Descr") = cDescr
            'dtNoAdeudo.Rows.Add(drSinAd)
            'cContrato = drDatos("Anexo")
            If drDatos("Anexo") = "037620001" Then
                cContrato = drDatos("Anexo")
            End If
            If nCons = 0 Then
                nSuma = 0
                nSuma = nSuma + drDatos("Saldot")
            ElseIf drDatos("Cliente") = cCliente And nCons > 0 Then
                nSuma = nSuma + drDatos("Saldot")
                ' Este importe me va a permitir controlar que solo pasen los clientes que solo tienen un adeudo
                If drDatos("Feven") = cFechaPago Then
                    nImporte = drDatos("Saldot")
                End If
            ElseIf drDatos("Cliente") <> cCliente And nSuma = 0 Then
                drSinAd = dtNoAdeudo.NewRow()
                drSinAd("Cliente") = cCliente
                drSinAd("Descr") = cDescr
                dtNoAdeudo.Rows.Add(drSinAd)
                nCons = 0
                ' Aqui solo pasaran los contratos cuyo unico adeudo sea el de la fecha solicitada
            ElseIf drDatos("Cliente") <> cCliente And nSuma = nImporte Then
                drSinAd = dtNoAdeudo.NewRow()
                drSinAd("Cliente") = cCliente
                drSinAd("Descr") = cDescr
                dtNoAdeudo.Rows.Add(drSinAd)
                nCons = 0
            ElseIf drDatos("Cliente") <> cCliente And nSuma > 0 Then
                nSuma = 0
                nCons = 0
                nImporte = 0
            End If
            cContrato = drDatos("Anexo")
            cCliente = drDatos("Cliente")
            cDescr = drDatos("Descr")
            nCons += 1
        Next

        ' Ligar la Tabla SinAdeudo del Dataset dsAgil al ComboBox de los NO Deudores

        cbSinAdeudo.DataSource = dtNoAdeudo
        cbSinAdeudo.DisplayMember = "Descr"
        cbSinAdeudo.ValueMember = "Cliente"
     
    End Sub

    'Private Sub lvSaldos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    ' Declaración de variables de datos

    '    Dim cnAgil As New SqlConnection(strConn)
    '    Dim cm1 As New SqlCommand()
    '    Dim drAnexo As DataRow
    '    Dim daAnexos As New SqlDataAdapter(cm1)

    '    Dim cAnexo As String
    '    Dim nTotalMoratorios As Decimal
    '    j = 0
    '    i = 0

    '    'SIN MORATORIOS POR DOMICILIACION EXTRAORDINARIA++++++++++++++++++++++++
    '    If CDate(cVencimiento) <= CDate("09/01/2015") And cContrato = "03273/0002" Then
    '        nMoratorios = 0
    '        nIvaMoratorios = 0
    '        nTotalMoratorios = 0
    '    ElseIf CDate(cVencimiento) = CDate("23/01/2015") Then
    '        Select Case cContrato
    '            Case "001020012", "011840004", "013260002", "013430003", "015660002", "017010002", "017980003", "022960002", "030520002", "030530002", _
    '            "030580002", "030690001", "030800001", "030910001", "030940002", "030980001", "031010001", "031040001", "031060001", "031100001", _
    '            "031120001", "031140001", "031170001", "031310001", "031330001", "031340001", "031350002", "031370002", "031560001", "031760002", _
    '            "031880002", "031960001", "032000001", "032020001", "032240002", "032630001", "032640001", "032660001", "033020001", "033220001", _
    '            "033480001", "033600001", "033750001", "033840001", "034530001", "034750001", "034930001", "034970001", "035550001"
    '                nMoratorios = 0
    '                nIvaMoratorios = 0
    '                nTotalMoratorios = 0
    '        End Select
    '    End If
    '    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    '    nSaldoTotal = Round(nSaldo + nMoratorios + nIvaMoratorios, 2)

    '    txtNvoImp.Text = nSaldoTotal

    '    j = j + 1
    '    i = i - 1

    'End Sub

    Private Sub btnLayOut_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLayOut.Click

        Dim drAnexo As DataRow

        Dim cRenglon As String
        Dim cAnexo As String
        Dim cDescr As String
        Dim cBanco As String
        Dim cTipo As String
        Dim cDia As String
        Dim cFeven As String
        Dim cRefBancomer As String
        Dim cReferencia As String
        Dim cLeyenda As String = ""
        Dim flag As String = ""
        Dim cCuenta As String
        Dim cTitular As String
        Dim cLetra As String
        Dim cPago As String
        Dim entero As String
        Dim dec As String
        Dim cSumaPago As String
        Dim cArchivo As String
        Dim nCount As Integer
        Dim n As Integer
        Dim nPago As Decimal
        Dim nPago2 As Decimal
        Dim nSumaPago As Decimal
        Dim nResultado As Decimal
        Dim nSumaBancomer As Decimal

        cDia = Mid(DTOC(Today), 7, 2) & Mid(DTOC(Today), 5, 2)
        cFeven = DTOC(dtpProcesar.Value)

        If rbBmer.Checked = True Then
            cArchivo = "C:\Files\Pagos BANCOMER_"
        End If

        If rbNoBmer.Checked = True Then
            cArchivo = "C:\Files\Pagos OTROS BANCOS_"
        End If

        Dim stmPCC As New FileStream(cArchivo & cDia & Mid(cFeven, 1, 4) & ".txt", FileMode.Create, FileAccess.Write, FileShare.None)
        Dim stmWriter As New StreamWriter(stmPCC, System.Text.Encoding.Default)

        nCount = 1
        For Each drAnexo In dtDomiciliacion.Rows

            cAnexo = drAnexo("Contrato")
            If Len(cAnexo) > 9 Then
                cAnexo = Mid(cAnexo, 1, 5) & Mid(cAnexo, 7, 4)
            End If
            cLetra = drAnexo("Letra")

            cReferencia = drAnexo("Referencia")

            If cReferencia = "C" Then
                cRefBancomer = "90" + Mid(cAnexo, 1, 5)
            Else
                cRefBancomer = Mid(cAnexo, 2, 4) + Mid(cAnexo, 7, 3)
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

            cRefBancomer += nResultado.ToString
            cRefBancomer = "PAGO " & cLetra & " DEL CONTRATO " & cRefBancomer

            nPago = drAnexo("Saldo")
            nPago2 = 0
            If nPago > 50000.0 Then
                nPago = 50000.0
                nPago2 = drAnexo("Saldo") - nPago
                nPago = 50000.01
            End If
            cDescr = Mid(Trim(drAnexo("Name")), 1, 40)
            cTitular = drAnexo("Titular")

            cBanco = Trim(drAnexo("Banco"))
            cCuenta = Trim(drAnexo("Cuenta"))

            If cBanco = "BANCOMER" Then
                cBanco = "012"
                cLeyenda = "CARGO DOMICILIADO A BANCO BANCOMER"
            Else
                Select Case cBanco
                    Case "BANAMEX"
                        cBanco = "002"
                        cLeyenda = "CARGO DOMICILIADO A BANCO BANAMEX"
                    Case "SANTANDER"
                        cBanco = "014"
                        cLeyenda = "CARGO DOMICILIADO A BANCO SANTANDER"
                    Case "BANJERCITO"
                        cBanco = "019"
                        cLeyenda = "CARGO DOMICILIADO A BANCO BANJERCITO"
                    Case "HSBC"
                        cBanco = "021"
                        cLeyenda = "CARGO DOMICILIADO A BANCO HSBC"
                    Case "BANCO DEL BAJIO"
                        cBanco = "030"
                        cLeyenda = "CARGO DOMICILIADO A BANCO DEL BAJIO"
                    Case "IXE"
                        cBanco = "032"
                        cLeyenda = "CARGO DOMICILIADO A BANCO IXE"
                    Case "INBURSA"
                        cBanco = "036"
                        cLeyenda = "CARGO DOMICILIADO A BANCO INBURSA"
                    Case "INTERACCIONES"
                        cBanco = "037"
                        cLeyenda = "CARGO DOMICILIADO A BANCO INTERACCIONES"
                    Case "BANCA MIFEL"
                        cBanco = "042"
                        cLeyenda = "CARGO DOMICILIADO A BANCO MIFEL"
                    Case "SCOTIABANK"
                        cBanco = "044"
                        cLeyenda = "CARGO DOMICILIADO A BANCO SCOTIABANK"
                    Case "BANORTE"
                        cBanco = "072"
                        cLeyenda = "CARGO DOMICILIADO A BANCO BANORTE"
                    Case "AZTECA"
                        cBanco = "127"
                        cLeyenda = "CARGO DOMICILIADO A BANCO AZTECA"
                    Case "AHORRO"
                        cBanco = "131"
                        cLeyenda = "CARGO DOMICILIADO A BANCO AHORRO"
                    Case "BANCOPPEL"
                        cBanco = "137"
                        cLeyenda = "CARGO DOMICILIADO A BANCO BANCOPPEL"
                End Select
            End If

            If Len(cCuenta) = 18 Then
                cTipo = "40"
            ElseIf Len(cCuenta) = 16 Then
                cTipo = "03"
            ElseIf Len(cCuenta) = 10 Then
                cTipo = "01"
            End If
            cFeven = DTOC(DiaSemana(dtpProcesar.Value))

            If nCount = 1 Then
                cRenglon = "01000000130012E2" & Mid(cDia, 1, 2) & Stuff(nCount.ToString, "I", "0", 5) & DTOC(Today) & "0100                         " & "FINAGIL SA DE CV SOFOM ENR              " & "FIN 940905AX7     " & Space(182)
                stmWriter.WriteLine(cRenglon)
            End If
            nCount += 1
            cPago = ""
            entero = ""
            dec = ""
            cPago = nPago.ToString

            For n = 1 To Len(cPago)
                If Mid(cPago, n, 1) = "." Then
                    flag = "S"
                Else
                    If flag = "S" Then
                        dec = dec + Mid(cPago, n, 1)
                    Else
                        entero = entero + Mid(cPago, n, 1)
                    End If
                End If
            Next n
            If dec = "" And nPago < 50000.01 Then
                dec = "00"
            End If
            cPago = entero & dec

            cRenglon = "02" & Stuff(nCount.ToString, "I", "0", 7) & "3001" & Stuff(cPago, "I", "0", 15) & DTOC(Today) & Space(24) & "51" & DTOC(Today) & cBanco
            cRenglon = cRenglon & cTipo & Stuff(cCuenta, "I", "0", 20) & Stuff(Trim(cTitular), "D", " ", 40) & Stuff(cRefBancomer, "D", " ", 40) & Stuff(cDescr, "D", " ", 40)
            cRenglon = cRenglon & "000000000000000" & Stuff((nCount - 1).ToString, "I", "0", 7) & Stuff(cLeyenda, "D", " ", 40) & "00" & Space(21)

            cRenglon = cRenglon.Replace("Ñ", Chr(78))
            cRenglon = cRenglon.Replace("ñ", Chr(110))
            stmWriter.WriteLine(cRenglon)
            nSumaPago += nPago
            If nPago2 > 0 Then
                nCount += 1
                cPago = ""
                entero = ""
                dec = ""
                cPago = nPago2.ToString

                For n = 1 To Len(cPago)
                    If Mid(cPago, n, 1) = "." Then
                        flag = "S"
                    Else
                        If flag = "S" Then
                            dec = dec + Mid(cPago, n, 1)
                        Else
                            entero = entero + Mid(cPago, n, 1)
                        End If
                    End If
                Next n
                If dec = "" Then
                    dec = "00"
                End If
                cPago = entero & dec

                cRenglon = "02" & Stuff(nCount.ToString, "I", "0", 7) & "3001" & Stuff(cPago, "I", "0", 15) & DTOC(Today) & Space(24) & "51" & DTOC(Today) & cBanco
                cRenglon = cRenglon & cTipo & Stuff(cCuenta, "I", "0", 20) & Stuff(Trim(cTitular), "D", " ", 40) & Stuff(cRefBancomer, "D", " ", 40) & Stuff(cDescr, "D", " ", 40)
                cRenglon = cRenglon & "000000000000000" & Stuff((nCount - 1).ToString, "I", "0", 7) & Stuff(cLeyenda, "D", " ", 40) & "00" & Space(21)
                cRenglon = cRenglon.Replace("Ñ", Chr(78))
                cRenglon = cRenglon.Replace("ñ", Chr(110))
                stmWriter.WriteLine(cRenglon)
                nSumaPago += nPago
            End If
        Next
        nCount += 1
        cSumaPago = nSumaPago.ToString
        entero = ""
        dec = ""

        For n = 1 To Len(cSumaPago)
            If Mid(cSumaPago, n, 1) = "." Then
                flag = "S"
            Else
                If flag = "S" Then
                    dec = dec + Mid(cSumaPago, n, 1)
                Else
                    entero = entero + Mid(cSumaPago, n, 1)
                End If
            End If
        Next
        If dec = "" Then
            dec = "00"
        End If
        cSumaPago = entero & dec

        cRenglon = "09" & Stuff(nCount.ToString, "I", "0", 7) & "30" & Mid(cDia, 1, 2) & "00001" & Stuff((nCount - 2).ToString, "I", "0", 7) & Stuff(cSumaPago, "I", "0", 18) & Space(17) & Space(240)
        stmWriter.WriteLine(cRenglon)

        stmWriter.Flush()
        stmPCC.Flush()
        stmPCC.Close()

        MsgBox("Archivo Construido correctamente", MsgBoxStyle.Exclamation, "Mensaje")
        Me.Close()

    End Sub

    Public Function DiaSemana(ByVal dFecha As Date)

        Dim nDay As Byte
        Dim nYear As Integer
        Dim nMonth As Byte
        Dim nAños As Integer
        Dim nAñosb As Integer
        Dim nLeap As Byte
        Dim i As Integer
        Dim nMes As Integer
        Dim nDia As Integer

        nDay = Day(dFecha)
        nMonth = Month(dFecha)
        nYear = Year(dFecha)

        nAños = nYear - 1933
        nLeap = 0
        nAñosb = 0

        For i = 1933 To nYear
            nLeap = Leap(i)
            If nLeap = 1 Then
                nAñosb += 1
                nLeap = 0
            End If
        Next

        Select Case nMonth
            Case 1, 10
                nMes = 0
            Case 2, 3, 11
                nMes = 3
            Case 4, 7
                nMes = 6
            Case 5
                nMes = 1
            Case 6
                nMes = 4
            Case 8
                nMes = 2
            Case 9, 12
                nMes = 5
        End Select

        nDia = (nAños + nAñosb + nMes + nDay) Mod 7
        If nDia = 1 Then
            dFecha = DateAdd(DateInterval.Day, 1, dFecha)
        ElseIf nDia = 0 Then
            dFecha = DateAdd(DateInterval.Day, 2, dFecha)
        End If

        DiaSemana = dFecha.ToShortDateString

    End Function

    Private Sub btnModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifica.Click
        nSaldoTotal = txtNvoImp.Text

        DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value + nSaldoTotal
        DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value + nSaldoTotal
        DataGridView1.Refresh()

        txtNvoImp.Text = 0

    End Sub

    Private Sub cbDeudor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDeudor.SelectedIndexChanged

        If Not cbDeudor.SelectedValue Is Nothing And lFirstTime = False Then
            txtCliente.Text = cbDeudor.SelectedValue.ToString()
            LlenaDatos()
        End If

    End Sub

    Private Sub LlenaDatos()
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim daFacturas As New SqlDataAdapter(cm1)
        Dim daUdis As New SqlDataAdapter(cm4)
        Dim dsAgil As New DataSet()
        Dim drTemporal As DataRow
        Dim drSaldo As DataRow
        Dim drUdis As DataRowCollection
        Dim myColArray(1) As DataColumn

        ' Declaración de variables de datos

        Dim cFechaPago As String
        Dim cFepag As String
        Dim cFeven As String
        Dim cTipar As String
        Dim cTipo As String
        Dim cCta As String
        Dim nDiasMoratorios As Decimal
        Dim nIvaMoratorios As Decimal
        Dim nMoratorios As Decimal
        Dim nSaldo As Decimal
        Dim nSaldoTotal As Decimal
        Dim nTasaMoratoria As Decimal
        Dim nTasaIvaCliente As Decimal
 
        oKey(0) = dtDomiciliacion.Columns("Contrato")
        oKey(1) = dtDomiciliacion.Columns("Letra")
        dtDomiciliacion.PrimaryKey = oKey

        cFechaPago = DTOC(dtpProcesar.Value)

        ' El siguiente Stored Procedure trae todos los contratos con saldo en facturas 
        ' correspondientes al cliente dado aun cuando la factura no sea exigible todavía

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT SaldoFac, Descr, CuentasDomi.Banco, CuentasDomi.CuentaCLABE, CuentasDomi.NumTarjeta, CuentasDomi.CuentaEJE, CuentasDomi.TitularCta, " &
                           " Referencia, Facturas.Letra, Anexos.Autoriza, Facturas.Anexo, Tipo, Tipar, Anexos.Tasas, Anexos.Difer, Facturas.Feven, Facturas.Fepag, " &
                           " TasaIVACliente,Anexos.Fechacon FROM Facturas " &
                           " Inner Join Clientes On Facturas.Cliente = Clientes.Cliente " &
                           " INNER JOIN CuentasDomi ON CuentasDomi.ANEXO = FACTURAS.ANEXO " &
                           " INNER JOIN ANEXOS ON ANEXOS.ANEXO = FACTURAS.ANEXO " &
                           " WHERE Feven < " & "'" & cFechaPago & "'" & " And Anexos.Autoriza = " & "'" & "S" & "'" & " And Facturas.SaldoFac > " & 0 & " And Facturas.Cliente = " & txtCliente.Text &
                           " order by Anexos.anexo, letra"
            .Connection = cnAgil
        End With

        ' Este Stored Procedure regresa todas las UDIS ordenadas por vigencia

        With cm4
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TraeUdis1"
            .Connection = cnAgil
        End With

        Try

            ' Llenar el DataSet lo cual abre y cierra la conexión

            daFacturas.Fill(dsAgil, "Facturas")
            daUdis.Fill(dsAgil, "Udis")

        Catch eException As Exception

            MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

        ' En drFacturas tengo los contratos del cliente seleccionado, siempre y cuando tengan SALDO EN FACTURAS, por lo que añadiré elementos a la tabla dtTemporal por este concepto

        ' También genero el DataRowCollection drUdis ya que necesito enviarlo como
        ' argumento a la función CalcMora que calcula los moratorios ya que esta lo
        ' envía a su vez a la función CalcIvaU.

        drUdis = dsAgil.Tables("Udis").Rows

        dtTemporal.Clear()
        For Each drSaldo In dsAgil.Tables("Facturas").Rows

            cTipar = drSaldo("Tipar")
            cTipo = drSaldo("Tipo")
            nSaldo = drSaldo("SaldoFac")
            nDiasMoratorios = 0
            nTasaMoratoria = (drSaldo("Tasas") + drSaldo("Difer")) * 2
            nMoratorios = 0
            nIvaMoratorios = 0
            cFeven = drSaldo("Feven")
            cFepag = drSaldo("Fepag")
            nTasaIvaCliente = drSaldo("TasaIVACliente")

            If Trim(cFepag) = "" Then
                nDiasMoratorios = DateDiff(DateInterval.Day, CTOD(cFeven), CTOD(cFechaPago))
            Else
                If cFeven >= cFepag Then
                    nDiasMoratorios = DateDiff(DateInterval.Day, CTOD(cFeven), CTOD(cFechaPago))
                Else
                    nDiasMoratorios = DateDiff(DateInterval.Day, CTOD(cFepag), CTOD(cFechaPago))
                End If
            End If
            If nDiasMoratorios < 0 Then
                nDiasMoratorios = 0
            End If

            If nDiasMoratorios > 0 Then
                CalcMora(cTipar, cTipo, cFechaPago, drUdis, nSaldo, nTasaMoratoria, nDiasMoratorios, nMoratorios, nIvaMoratorios, nTasaIvaCliente, drSaldo("Anexo"), "", drSaldo("Fechacon"))
            End If

            nSaldoTotal = nSaldo + nMoratorios + nIvaMoratorios

            ' Insertar un registro en la tabla dtTemporal

            drTemporal = dtTemporal.NewRow()
            drTemporal("Contrato") = Mid(drSaldo("Anexo"), 1, 5) & "/" & Mid(drSaldo("Anexo"), 6, 4)
            drTemporal("Letra") = drSaldo("Letra")
            If Trim(drSaldo("Feven")) <> "" Then
                drTemporal("Vencimiento") = drSaldo("Feven")
            Else
                drTemporal("Vencimiento") = "        "
            End If
            If Trim(drSaldo("Fepag")) <> "" Then
                drTemporal("UltimoPago") = drSaldo("Fepag")
            Else
                drTemporal("UltimoPago") = "        "
            End If
            drTemporal("Saldo") = nSaldo
            drTemporal("Moratorios") = nMoratorios
            drTemporal("IVA Moratorios") = nIvaMoratorios
            drTemporal("Pago Total") = nSaldoTotal
            drTemporal("Banco") = drSaldo("Banco")
            If Trim(drSaldo("CuentaCLABE")) <> "" Then
                cCta = drSaldo("CuentaCLABE")
            ElseIf Trim(drSaldo("NumTarjeta")) <> "" Then
                cCta = drSaldo("NumTarjeta")
            Else
                cCta = drSaldo("CuentaEJE")
            End If
            drTemporal("Cuenta") = cCta
            drTemporal("Titular") = drSaldo("TitularCta")
            drTemporal("Name") = drSaldo("Descr")
            drTemporal("Referencia") = drSaldo("Referencia")
            dtTemporal.Rows.Add(drTemporal)

        Next
        DataGridView1.DataSource = dtTemporal

        cnAgil.Dispose()
        cm1.Dispose()
        cm4.Dispose()

    End Sub

    Private Sub cbSinAdeudo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSinAdeudo.SelectedIndexChanged
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm4 As New SqlCommand()
        Dim daAdicional As New SqlDataAdapter(cm4)
        Dim dsAgil As New DataSet()
        Dim myColArray(1) As DataColumn
        Dim drAdic As DataRow
        Dim drFinal As DataRow
   
        ' Declaración de variables de datos

        Dim cFechaPago As String
   
        cFechaPago = DTOC(dtpProcesar.Value)
        txtCte.Text = cbSinAdeudo.SelectedValue.ToString()

        With cm4
            .CommandType = CommandType.Text
            .CommandText = "SELECT Anexos.anexo, CuentasDomi.Banco, CuentasDomi.CuentaCLABE, NumTarjeta, CuentaEJE, TitularCta, Descr, Tipo  FROM Anexos " & _
                           "INNER JOIN CuentasDomi ON CuentasDomi.Anexo = Anexos.Anexo " & _
                           "INNER JOIN Clientes ON Clientes.Cliente = Anexos.Cliente " & _
                           "WHERE Anexos.Autoriza = " & "'" & "S" & "'" & " AND Flcan = " & "'" & "A" & "'" & " AND Anexos.Cliente = " & "'" & txtCte.Text & "'" & " ORDER BY Anexos.Anexo"
            .Connection = cnAgil
        End With
        daAdicional.Fill(dsAgil, "CobroExt")

        For Each drAdic In dsAgil.Tables("CobroExt").Rows
            drFinal = dtAdicional.NewRow()
            drFinal("Contrato") = Mid(drAdic("Anexo"), 1, 5) & "/" & Mid(drAdic("Anexo"), 6, 4)
            drFinal("Letra") = "000"
            drFinal("Vencimiento") = " "
            drFinal("UltimoPago") = " "
            drFinal("Saldo") = 0
            drFinal("Moratorios") = 0
            drFinal("IVA Moratorios") = 0
            drFinal("Pago Total") = 0
            drFinal("Banco") = drAdic("Banco")
            If Trim(drAdic("CuentaCLABE")) <> "" Then
                drFinal("Cuenta") = drAdic("CuentaCLABE")
            ElseIf Trim(drAdic("NumTarjeta")) <> "" Then
                drFinal("Cuenta") = drAdic("NumTarjeta")
            ElseIf Trim(drAdic("CuentaEJE")) <> "" Then
                drFinal("Cuenta") = drAdic("CuentaEJE")
            End If
            drFinal("Titular") = drAdic("TitularCta")
            drFinal("Name") = drAdic("Descr")
            drFinal("Referencia") = ""
            dtAdicional.Rows.Add(drFinal)
        Next
        DataGridView2.DataSource = dtAdicional

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        DataGridView2.Item(4, DataGridView2.CurrentRow.Index).Value = DataGridView2.Item(4, DataGridView2.CurrentRow.Index).Value + txtImpExt.Text
        DataGridView2.Item(7, DataGridView2.CurrentRow.Index).Value = DataGridView2.Item(7, DataGridView2.CurrentRow.Index).Value + txtImpExt.Text
        DataGridView2.Refresh()

        txtImpExt.Text = 0

    End Sub

    Private Sub DataGridView2_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.Click
        Dim nImporteAd As Decimal

        nImporteAd = DataGridView2.Item(4, DataGridView2.CurrentRow.Index).Value
        txtImpExt.Text = nImporteAd
        Label6.Visible = True
        txtImpExt.Visible = True
        btnAdicionar.Visible = True

    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Dim nImporte As Decimal

        nImporte = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        txtNvoImp.Text = nImporte
        Label2.Visible = True
        txtNvoImp.Visible = True
        btnModifica.Visible = True

    End Sub

    Private Sub DataGridView1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim drDato1 As DataRow
        Dim drDomi1 As DataRow
  
        drDato1 = dtTemp.NewRow()
        drDato1("Contrato") = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        drDato1("Letra") = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        drDato1("Vencimiento") = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        drDato1("UltimoPago") = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        drDato1("Saldo") = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        drDato1("Moratorios") = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        drDato1("IVA Moratorios") = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        drDato1("Pago Total") = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        drDato1("Banco") = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        drDato1("Cuenta") = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        drDato1("Titular") = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
        drDato1("Name") = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value
        drDato1("Referencia") = DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value
        dtTemp.Rows.Add(drDato1)

        'Estos datos los guardo para que en dado caso que aplique para insertar un pago adicional como adelanto a capital se cargue al contrato correcto

        cContratoant = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        cBancoant = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        cCuentaant = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        cTitularant = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
        cNameant = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value

        drDomi1 = dtDomiciliacion.NewRow()
        drDomi1("Contrato") = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        drDomi1("Letra") = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        drDomi1("Vencimiento") = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        drDomi1("UltimoPago") = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        drDomi1("Saldo") = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        drDomi1("Tipo") = "F"
        drDomi1("Banco") = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        drDomi1("Cuenta") = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        drDomi1("Titular") = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
        drDomi1("Name") = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value
        drDomi1("Referencia") = DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value
        dtDomiciliacion.Rows.Add(drDomi1)

        txtNvoImp.Text = 0

        DataGridView3.DataSource = dtTemp
        DataGridView3.Refresh()
        nRenglones = DataGridView1.RowCount()

        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            ' Eliminamos la fila. 
            dtTemporal.Rows.RemoveAt(row.Index)
            nRenglones = nRenglones - 1
        Next
        DataGridView1.DataSource = dtTemporal
        DataGridView1.Refresh()

        If nRenglones = 0 Then
            Label7.Visible = True
            txtAdelanto.Visible = True
            btnAdelanto.Visible = True
        End If

    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        Dim drDato2 As DataRow
        Dim drDomi2 As DataRow

        drDato2 = dtTemp.NewRow()
        drDato2("Contrato") = DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value
        drDato2("Letra") = DataGridView2.Item(1, DataGridView2.CurrentRow.Index).Value
        drDato2("Vencimiento") = DataGridView2.Item(2, DataGridView2.CurrentRow.Index).Value
        drDato2("UltimoPago") = DataGridView2.Item(3, DataGridView2.CurrentRow.Index).Value
        drDato2("Saldo") = DataGridView2.Item(4, DataGridView2.CurrentRow.Index).Value
        drDato2("Moratorios") = DataGridView2.Item(5, DataGridView2.CurrentRow.Index).Value
        drDato2("IVA Moratorios") = DataGridView2.Item(6, DataGridView2.CurrentRow.Index).Value
        drDato2("Pago Total") = DataGridView2.Item(7, DataGridView2.CurrentRow.Index).Value
        drDato2("Banco") = DataGridView2.Item(8, DataGridView2.CurrentRow.Index).Value
        drDato2("Cuenta") = DataGridView2.Item(9, DataGridView2.CurrentRow.Index).Value
        drDato2("Titular") = DataGridView2.Item(10, DataGridView2.CurrentRow.Index).Value
        drDato2("Name") = DataGridView2.Item(11, DataGridView2.CurrentRow.Index).Value
        drDato2("Referencia") = DataGridView2.Item(12, DataGridView2.CurrentRow.Index).Value
        dtTemp.Rows.Add(drDato2)

        drDomi2 = dtDomiciliacion.NewRow()
        drDomi2("Contrato") = DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value
        drDomi2("Letra") = "ADI"
        drDomi2("Vencimiento") = DataGridView2.Item(2, DataGridView2.CurrentRow.Index).Value
        drDomi2("UltimoPago") = DataGridView2.Item(3, DataGridView2.CurrentRow.Index).Value
        drDomi2("Saldo") = DataGridView2.Item(7, DataGridView2.CurrentRow.Index).Value
        drDomi2("Tipo") = "F"
        drDomi2("Banco") = DataGridView2.Item(8, DataGridView2.CurrentRow.Index).Value
        drDomi2("Cuenta") = DataGridView2.Item(9, DataGridView2.CurrentRow.Index).Value
        drDomi2("Titular") = DataGridView2.Item(10, DataGridView2.CurrentRow.Index).Value
        drDomi2("Name") = DataGridView2.Item(11, DataGridView2.CurrentRow.Index).Value
        drDomi2("Referencia") = DataGridView2.Item(12, DataGridView2.CurrentRow.Index).Value
        dtDomiciliacion.Rows.Add(drDomi2)

        txtImpExt.Text = 0

        DataGridView3.DataSource = dtTemp
        DataGridView3.Refresh()

        For Each row As DataGridViewRow In DataGridView2.SelectedRows
            ' Eliminamos la fila. 
            dtAdicional.Rows.RemoveAt(row.Index)
        Next
        DataGridView2.DataSource = dtAdicional
        DataGridView2.Refresh()

    End Sub

    Private Sub btnAdelanto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdelanto.Click
        Dim drDato3 As DataRow
        Dim drDomi3 As DataRow

        drDato3 = dtTemp.NewRow()
        drDato3("Contrato") = cContratoant
        drDato3("Letra") = "000"
        drDato3("Vencimiento") = " "
        drDato3("UltimoPago") = " "
        drDato3("Saldo") = txtAdelanto.Text
        drDato3("Moratorios") = 0
        drDato3("IVA Moratorios") = 0
        drDato3("Pago Total") = txtAdelanto.Text
        drDato3("Banco") = cBancoant
        drDato3("Cuenta") = cCuentaant
        drDato3("Titular") = cTitularant
        drDato3("Name") = cNameant
        drDato3("Referencia") = ""
        dtTemp.Rows.Add(drDato3)

        drDomi3 = dtDomiciliacion.NewRow()
        drDomi3("Contrato") = cContratoant
        drDomi3("Letra") = "ADI"
        drDomi3("Vencimiento") = " "
        drDomi3("UltimoPago") = " "
        drDomi3("Saldo") = txtAdelanto.Text
        drDomi3("Tipo") = "F"
        drDomi3("Banco") = cBancoant
        drDomi3("Cuenta") = cCuentaant
        drDomi3("Titular") = cTitularant
        drDomi3("Name") = cNameant
        drDomi3("Referencia") = ""
        dtDomiciliacion.Rows.Add(drDomi3)

        DataGridView3.DataSource = dtTemp
        DataGridView3.Refresh()

        txtAdelanto.Text = 0
        Label7.Visible = False
        txtAdelanto.Visible = False
        btnAdelanto.Visible = False

    End Sub
End Class
