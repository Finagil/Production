Option Explicit On 

Imports System.Data.SqlClient
Imports System.Math
Imports CrystalDecisions.Shared

Public Class frmHistoria
    Inherits System.Windows.Forms.Form
    Dim Resumen As Boolean = False

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal cAnexo As String, Ciclo As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.Text = "Historia de pagos del Contrato " & cAnexo
        txtAnexo.Text = cAnexo
        TxtCiclo.Text = Ciclo
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCiclo As TextBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtAnexo = New System.Windows.Forms.TextBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TxtCiclo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtAnexo
        '
        Me.txtAnexo.Location = New System.Drawing.Point(12, 6)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.Size = New System.Drawing.Size(62, 20)
        Me.txtAnexo.TabIndex = 25
        Me.txtAnexo.Visible = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1024, 702)
        Me.CrystalReportViewer1.TabIndex = 29
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'TxtCiclo
        '
        Me.TxtCiclo.Location = New System.Drawing.Point(210, 12)
        Me.TxtCiclo.Name = "TxtCiclo"
        Me.TxtCiclo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCiclo.TabIndex = 30
        Me.TxtCiclo.Visible = False
        '
        'frmHistoria
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1024, 702)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.txtAnexo)
        Me.Controls.Add(Me.TxtCiclo)
        Me.Name = "frmHistoria"
        Me.Text = "Historia de Pagos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmHistoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TxtCiclo.Text = "" Then
            ReporteTradicional()
        Else
            ReporteAvio()
        End If
    End Sub

    Sub HistariaConcetrada(ByVal Cliente As String, ByRef DSAgilORG As DataSet, ByVal Nombre As String)
        Dim Historial As New GeneralDS.ResumenHistoriaDataTable
        Dim r As GeneralDS.ResumenHistoriaRow
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm0 As New SqlCommand()
        Dim cm4 As New SqlCommand()

        Dim daContratos As New SqlDataAdapter(cm0)
        Dim drHistoria As DataRow
        Dim drContrato As DataRow
        Dim drFactura As DataRow
        Dim drPago As DataRow
        Dim cAnexo As String



        cm0.CommandType = CommandType.Text
        cm0.CommandText = "select anexo from anexos where cliente ='" & Cliente & "'"
        cm0.Connection = cnAgil
        cm4.Connection = cnAgil
        cnAgil.Open()
        daContratos.Fill(DSAgilORG, "Contratos")
        If DSAgilORG.Tables("Contratos").Rows.Count < 1 Then
            cnAgil.Close()
            Exit Sub
        End If
        cnAgil.Close()
        Resumen = True

        Dim nNumAtrasos As Double
        Dim nPromDias As Double
        Dim nPromMonto As Double
        Dim nMaxDias As Double
        Dim nMaxMonto As Double
        Dim nNumAdelantos As Double
        Dim nNumPenalizaciones As Double
        Dim nMontoAdelantos As Double
        Dim nMontoPenalizaciones As Double
        Dim Ndias As Double
        Dim nMora As Double
        Dim nNumAmort As Integer

        For Each drContrato In DSAgilORG.Tables("Contratos").Rows
            cAnexo = drContrato.Item("Anexo")
            nNumAtrasos = 0
            nPromDias = 0
            nPromMonto = 0
            nMaxDias = 0
            nMaxMonto = 0
            nNumAdelantos = 0
            nNumPenalizaciones = 0
            nMontoAdelantos = 0
            nMontoPenalizaciones = 0
            Ndias = 0
            nMora = 0
            nNumAmort = 0

            Dim DSagil As New DataSet
            Dim cm1 As New SqlCommand()
            Dim cm2 As New SqlCommand()
            Dim daHistoria As New SqlDataAdapter(cm1)
            Dim daFacturas As New SqlDataAdapter(cm2)

            cm1.CommandType = CommandType.StoredProcedure
            cm1.CommandText = "Historia1"
            cm1.Connection = cnAgil
            cm1.Parameters.Add("@Anexo", SqlDbType.NVarChar)
            cm1.Parameters(0).Value = cAnexo

            cm2.CommandType = CommandType.StoredProcedure
            cm2.CommandText = "Historia2"
            cm2.Connection = cnAgil
            cm2.Parameters.Add("@Anexo", SqlDbType.NVarChar)
            cm2.Parameters(0).Value = cAnexo
            cm2.Parameters.Add("@Fecha", SqlDbType.NVarChar)
            cm2.Parameters(1).Value = Date.Now.ToString("yyyyMMdd")

            cnAgil.Open()
            daHistoria.Fill(DSagil, "Historia")
            daFacturas.Fill(DSagil, "Facturas")
            daHistoria.Dispose()
            daFacturas.Dispose()

            cm1.Dispose()
            cm2.Dispose()

            For Each drFactura In DSagil.Tables("Facturas").Rows
                Ndias = DateDiff(DateInterval.Day, CTOD(drFactura("Feven")), CTOD(drFactura("Fepag")))
                If Ndias > 0 Then
                    cm4.CommandText = "SELECT isnull(sum(Importe),0) as mora FROM Historia WHERE Observa1 = 'MORATORIOS' and Anexo = '" & cAnexo & "' and letra = '" & drFactura("Letra") & "'"
                    nMora = cm4.ExecuteScalar
                    If nMora > 0 Then
                        nNumAtrasos += 1
                        nPromDias += Ndias
                        If nMaxMonto <= drFactura("ImporteFac") Then
                            nMaxMonto = drFactura("ImporteFac")
                        End If
                        nPromMonto += drFactura("ImporteFac")
                        If nMaxDias <= Ndias Then
                            nMaxDias = Ndias
                        End If
                    End If
                End If
            Next
            cm4.CommandText = "SELECT Count(letra) as Amort FROM EdoctaV WHERE Anexo = '" & cAnexo & "'"
            nNumAmort = cm4.ExecuteScalar
            cnAgil.Close()

            For Each drPago In DSagil.Tables("Historia").Rows
                If Trim(drPago.Item("Observa1")) = "COMISION POR PREPAGO" Or Trim(drPago.Item("Observa1")) = "COMISION POR ADELANTO" Then
                    If drPago.Item("Importe") > 0 Then
                        nNumPenalizaciones += 1
                        nMontoPenalizaciones += drPago.Item("Importe")
                    End If
                ElseIf Mid(drPago.Item("Observa1"), 1, 16) = "ADELANTO CAPITAL" Then
                    If drPago.Item("Importe") > 0 Then
                        nNumAdelantos += 1
                        nMontoAdelantos += drPago.Item("Importe")
                    End If
                End If
            Next
            r = Historial.NewRow
            r.Anexo = Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4)
            If r.Anexo = "03490/0001" Then
                nNumAtrasos -= 2
                nMaxDias = 0
                nMaxMonto = 0
            End If
            r.Cliente = Cliente
            r.Nombre = Nombre
            r.Atrasos = nNumAtrasos
            If nNumAtrasos > 0 Then
                nPromDias = nPromDias / nNumAtrasos
                nPromMonto = nPromMonto / nNumAtrasos
            Else
                nPromDias = 0
                nPromMonto = 0
            End If
            r.DiasProm = nPromDias
            r.MontoProm = nPromMonto
            r.DiasMax = nMaxDias
            r.MontoMax = nMaxMonto

            r.Adelantos = nNumAdelantos
            r.MontoAdelanto = nMontoAdelantos
            r.Penalizaciones = nNumPenalizaciones
            r.MontoPena = nMontoPenalizaciones
            r.Amortizaciones = nNumAmort
            Historial.AddResumenHistoriaRow(r)

            DSagil.Dispose()
        Next

        DSAgilORG.Tables.Add(Historial)

    End Sub

    Sub ReporteTradicional()
        Dim BHistoria As DialogResult
        BHistoria = MessageBox.Show("¿Desea generar el histórico de pagos de todos los contratos del cliente?", "Historia de Pagos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim daHistoria As New SqlDataAdapter(cm1)
        Dim daFacturas As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet()
        Dim drHistoria As DataRow
        Dim drFactura As DataRow
        Dim drPago As DataRow
        Dim drPagos As DataRow()
        Dim dtHistoria As New DataTable("Historia")
        Dim dtTemporal As New DataTable()
        'Declaración de variables de datos

        Dim cAnexo As String
        Dim cCliente As String
        Dim cCusnam As String
        Dim cFecha As String
        Dim cTempFec As String
        Dim i As Integer
        Dim nBalance As Decimal
        Dim nDocumento As Byte
        Dim nPlazo As Byte
        Dim nPromDias As Decimal
        Dim nPromMonto As Decimal
        Dim nPromMontoAux As Decimal
        Dim nMaxDias As Decimal
        Dim nMaxMonto As Decimal
        Dim nNumAtrasos As Decimal
        Dim cFechaAux As String
        Dim cChequeAux As String
        Dim Ndias As Decimal
        Dim ImporteAux As Decimal
        Dim nMora As Decimal

        ' Declaración de variables de Crystal Reports

        Dim newrptHistoria As New rptHistoria()
        Dim cReportTitle As String
        Dim cReportComments As String

        cAnexo = Mid(txtAnexo.Text, 1, 5) & Mid(txtAnexo.Text, 7, 4)
        cFecha = DTOC(Now())
        'cFecha = "2017022"
        ' Defino Tabla dtHistoria para guardar datos de Historia de pagos

        dtHistoria.Columns.Add("Fecha", Type.GetType("System.String"))
        dtHistoria.Columns.Add("Concepto", Type.GetType("System.String"))
        dtHistoria.Columns.Add("Cargo", Type.GetType("System.Decimal"))
        dtHistoria.Columns.Add("Abono", Type.GetType("System.Decimal"))
        dtHistoria.Columns.Add("Balance", Type.GetType("System.Decimal"))
        dtHistoria.Columns.Add("Documento", Type.GetType("System.String"))
        dtHistoria.Columns.Add("Cheque", Type.GetType("System.String"))
        dtHistoria.Columns.Add("Depositado", Type.GetType("System.String"))
        dtHistoria.Columns.Add("Ven", Type.GetType("System.String"))

        ' Defino Tabla dtTemporal para guardar datos de Historia de pagos

        dtTemporal.Columns.Add("Fecha", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Concepto", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Cargo", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("Abono", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("Balance", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("Documento", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Cheque", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Depositado", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Ven", Type.GetType("System.String"))

        ' Este Stored Procedure obtiene todos los pagos realizados a un anexo

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Historia1"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
        End With

        ' El siguiente Stored Procedure trae todas las Facturas generadas para un anexo

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Historia2"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters(1).Value = cFecha
        End With

        ' El siguiente comando me regresa el nombre del cliente

        With cm3
            .CommandType = CommandType.Text
            .CommandText = "SELECT Descr FROM Clientes INNER JOIN Anexos ON Clientes.Cliente = Anexos.Cliente WHERE Anexo = '" & cAnexo & "'"
            .Connection = cnAgil
        End With

        With cm4
            .CommandType = CommandType.Text
            .CommandText = "SELECT sum(Importe) as mora FROM Historia WHERE Anexo = '" & cAnexo & "'"
            .Connection = cnAgil
        End With

        ' Llenar el dataset lo cual abre y cierra la conexión

        daHistoria.Fill(dsAgil, "Historia")
        daFacturas.Fill(dsAgil, "Facturas")



        cnAgil.Open()
        cCusnam = cm3.ExecuteScalar()

        For Each drFactura In dsAgil.Tables("Facturas").Rows
            drHistoria = dtHistoria.NewRow()
            drHistoria("Fecha") = drFactura("Feven")
            If drHistoria("Fecha") < "20171201" Then
                drHistoria("Concepto") = "Aviso No. " & drFactura("Factura")
            Else
                If IsDBNull(drFactura("SerieCFDI")) Then
                    drHistoria("Concepto") = "Aviso No. " & drFactura("Factura") & " - "
                Else
                    drHistoria("Concepto") = "Aviso No. " & drFactura("Factura") & " - " & drFactura("SerieCFDI").trim & drFactura("NofacturaCFDI")
                End If

            End If

            drHistoria("Cargo") = drFactura("Importefac")
            drHistoria("Abono") = 0
            drHistoria("Balance") = 0
            drHistoria("Documento") = drHistoria("Concepto")
            drHistoria("Cheque") = " "
            drHistoria("Depositado") = " "
            drHistoria("Ven") = drFactura("Letra")
            dtHistoria.Rows.Add(drHistoria)

            cCliente = drFactura("Cliente")
            Ndias = DateDiff(DateInterval.Day, CTOD(drFactura("Feven")), CTOD(drFactura("Fepag")))
            If Ndias > 0 Then
                cm4.CommandText = "SELECT isnull(sum(Importe),0) as mora FROM Historia WHERE Observa1 = 'MORATORIOS' and Anexo = '" & cAnexo & "' and letra = '" & drFactura("Letra") & "'"
                nMora = cm4.ExecuteScalar
                If nMora > 0 Then
                    nNumAtrasos += 1
                    nPromDias += Ndias
                    If nMaxMonto <= drFactura("ImporteFac") Then
                        nMaxMonto = drFactura("ImporteFac")
                    End If
                    nPromMonto += drFactura("ImporteFac")
                    If nMaxDias <= Ndias Then
                        nMaxDias = Ndias
                    End If
                End If

            End If

        Next

        cnAgil.Close()

        For Each drPago In dsAgil.Tables("Historia").Rows
            drHistoria = dtHistoria.NewRow()
            drHistoria("Fecha") = drPago("Fecha")
            drHistoria("Concepto") = drPago("Observa1")

            If drPago("Balance") = "N" Then
                drHistoria("Cargo") = drPago("Importe")
                drHistoria("Abono") = drPago("Importe")
            Else
                drHistoria("Cargo") = 0
                drHistoria("Abono") = drPago("Importe")
            End If
            drHistoria("Balance") = 0
            nDocumento = drPago("Documento")
            Select Case nDocumento
                Case 1
                    drHistoria("Documento") = "Nota de Cargo No. " & drPago("Numero")
                Case 2
                    drHistoria("Documento") = "Recibo de caja No. " & drPago("Numero")
                Case 4
                    drHistoria("Documento") = "Cargo Interno "
                Case 5
                    drHistoria("Documento") = "Abono Interno "
                Case 6
                    If drHistoria("Fecha") < "20171201" Then
                        drHistoria("Documento") = "Factura de pago No. " & drPago("Numero")
                    Else
                        drHistoria("Documento") = "Factura de pago No. " & drPago("Serie").trim & drPago("Numero")
                    End If

                Case 7
                    drHistoria("Documento") = "Factura de Activo Fijo"
            End Select
            drHistoria("Cheque") = drPago("Cheque")
            drHistoria("Depositado") = drPago("DescBanco")
            drHistoria("Ven") = drPago("Letra")
            dtHistoria.Rows.Add(drHistoria)
        Next

        ' Aquí tengo que ordenar la tabla dtHistoria de acuerdo a la fecha del movimiento
        ' dejándola en la tabla dtTemporal

        drPagos = dtHistoria.Select(True, "Fecha, ven, Documento")

        For Each drPago In drPagos
            dtTemporal.ImportRow(drPago)
        Next

        ' Enseguida copio la tabla dtTemporal en dtHistoria y elimino los registros de dtTemporal,
        ' al mismo tiempo que modifico su estructura para que no sea idéntica a la de dtHistoria

        dtHistoria = dtTemporal.Copy()
        dtTemporal.Clear()
        dtTemporal.Columns.Remove("Ven")
        dtTemporal.Columns.Add("Vencimiento", Type.GetType("System.String"))

        ' Ahora barro la tabla dtHistoria para determinar el balance después de cada movimiento

        nBalance = 0
        cChequeAux = "INICIAL"
        For Each drPago In dtHistoria.Rows

            If cChequeAux <> drPago("Cheque").ToString.Trim And nPromMontoAux > 0 Then
                'If nMaxMonto <= nPromMontoAux Then
                'nMaxMonto = nPromMontoAux
                'End If

                nPromMontoAux = 0
            End If

            nBalance = nBalance + drPago("Cargo")
            nBalance = nBalance - drPago("Abono")

            drHistoria = dtTemporal.NewRow()
            drHistoria("Fecha") = drPago("Fecha")
            drHistoria("Concepto") = drPago("Concepto")
            drHistoria("Cargo") = drPago("Cargo")
            drHistoria("Abono") = drPago("Abono")
            drHistoria("Balance") = Round(nBalance, 2)
            drHistoria("Documento") = drPago("Documento")
            drHistoria("Cheque") = drPago("Cheque")
            drHistoria("Depositado") = drPago("Depositado")
            drHistoria("Vencimiento") = drPago("Ven")
            If InStr(drPago("Concepto").ToString.Trim, "Aviso de vencimiento") Then
                cFechaAux = drHistoria("Fecha")
                ImporteAux = drPago("Cargo")
            ElseIf (drPago("Concepto").ToString.Trim = "MORATORIOS" Or drPago("Concepto").ToString.Trim = "IVA MORATORIOS") And cChequeAux <> drPago("Cheque").ToString.Trim Then

                cChequeAux = drPago("Cheque").ToString.Trim
            End If
            If cChequeAux = drPago("Cheque").ToString.Trim Then
                'nPromMontoAux += drPago("Abono")
            End If
            dtTemporal.Rows.Add(drHistoria)

        Next

        'If nPromMontoAux > 0 Then
        'nPromMonto += nPromMontoAux
        'nPromMontoAux = 0
        'End If


        dtHistoria = dtTemporal.Copy()

        dsAgil.Relations.Clear()
        dsAgil.Tables("Historia").Constraints.Clear()
        dsAgil.Tables("Facturas").Constraints.Clear()
        dsAgil.Tables.Remove("Historia")
        dsAgil.Tables.Remove("Facturas")
        dsAgil.Tables.Add(dtHistoria)

        ' Descomentar la siguiente línea en caso de que desee modificarse el reporte rptHistoria
        ' dsAgil.WriteXml("C:\Schema13.xml", XmlWriteMode.WriteSchema)

        cReportTitle = "HISTORIA DE PAGOS DEL CONTRATO " & txtAnexo.Text & " AL " & Mes(cFecha)
        cReportComments = Trim(cCusnam)
        If BHistoria = Windows.Forms.DialogResult.Yes Then
            HistariaConcetrada(cCliente, dsAgil, cCusnam.Trim)
        End If


        newrptHistoria.SummaryInfo.ReportTitle = cReportTitle
        newrptHistoria.SummaryInfo.ReportComments = cReportComments

        newrptHistoria.SetDataSource(dsAgil)
        newrptHistoria.Subreports(0).SetDataSource(dsAgil)
        newrptHistoria.SetParameterValue("Resumen", Not Resumen)
        newrptHistoria.SetParameterValue("MaxDias", nMaxDias)
        newrptHistoria.SetParameterValue("MaxMonto", nMaxMonto)
        If nNumAtrasos = 0 Then
            newrptHistoria.SetParameterValue("PromMonto", 0)
            newrptHistoria.SetParameterValue("PromDias", 0)
        Else
            newrptHistoria.SetParameterValue("PromMonto", nPromMonto / nNumAtrasos)
            newrptHistoria.SetParameterValue("PromDias", nPromDias / nNumAtrasos)
        End If
        newrptHistoria.SetParameterValue("NumAtrasos", nNumAtrasos)

        CrystalReportViewer1.ReportSource = newrptHistoria

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
    End Sub

    Sub ReporteAvio()
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim daHistoria As New AviosDSXTableAdapters.HistoriaAVTableAdapter
        Dim daFacturas As New SqlDataAdapter(cm2)
        Dim dsAgil As New AviosDSX
        Dim drHistoria As DataRow
        Dim drFactura As DataRow
        Dim drPago As DataRow
        Dim drPagos As DataRow()
        Dim dtHistoria As New DataTable("Historia")
        Dim dtTemporal As New DataTable()
        'Declaración de variables de datos

        Dim cAnexo As String
        Dim cCliente As String
        Dim cCusnam As String
        Dim cFecha As String
        Dim cTempFec As String
        Dim i As Integer
        Dim nBalance As Decimal
        Dim nDocumento As Byte
        Dim nPlazo As Byte
        Dim nPromDias As Decimal
        Dim nPromMonto As Decimal
        Dim nPromMontoAux As Decimal
        Dim nMaxDias As Decimal
        Dim nMaxMonto As Decimal
        Dim nNumAtrasos As Decimal
        Dim cFechaAux As String
        Dim cChequeAux As String
        Dim Ndias As Decimal
        Dim ImporteAux As Decimal
        Dim nMora As Decimal

        ' Declaración de variables de Crystal Reports

        Dim newrptHistoria As New rptHistoria()
        Dim cReportTitle As String
        Dim cReportComments As String

        cAnexo = txtAnexo.Text
        cFecha = DTOC(Now())
        'cFecha = "2017022"
        ' Defino Tabla dtHistoria para guardar datos de Historia de pagos

        dtHistoria.Columns.Add("Fecha", Type.GetType("System.String"))
        dtHistoria.Columns.Add("Concepto", Type.GetType("System.String"))
        dtHistoria.Columns.Add("Cargo", Type.GetType("System.Decimal"))
        dtHistoria.Columns.Add("Abono", Type.GetType("System.Decimal"))
        dtHistoria.Columns.Add("Balance", Type.GetType("System.Decimal"))
        dtHistoria.Columns.Add("Documento", Type.GetType("System.String"))
        dtHistoria.Columns.Add("Cheque", Type.GetType("System.String"))
        dtHistoria.Columns.Add("Depositado", Type.GetType("System.String"))
        dtHistoria.Columns.Add("Ven", Type.GetType("System.String"))

        ' Defino Tabla dtTemporal para guardar datos de Historia de pagos

        dtTemporal.Columns.Add("Fecha", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Concepto", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Cargo", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("Abono", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("Balance", Type.GetType("System.Decimal"))
        dtTemporal.Columns.Add("Documento", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Cheque", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Depositado", Type.GetType("System.String"))
        dtTemporal.Columns.Add("Ven", Type.GetType("System.String"))

        ' Este Stored Procedure obtiene todos los pagos realizados a un anexo

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "HistoriaAV"
            .Connection = cnAgil
            .Parameters.Add("@Anexo", SqlDbType.NVarChar)
            .Parameters.Add("@Ciclo", SqlDbType.NVarChar)
            .Parameters(0).Value = cAnexo
            .Parameters(1).Value = TxtCiclo.Text
        End With

        ' El siguiente Stored Procedure trae todas las Facturas generadas para un anexo
        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Facturas WHERE Anexo = '" & cAnexo & "'"
            .Connection = cnAgil
        End With
        With cm4
            .CommandType = CommandType.Text
            .CommandText = "SELECT sum(Importe) as mora FROM Historia WHERE Anexo = '" & cAnexo & "'"
            .Connection = cnAgil
        End With

        ' Llenar el dataset lo cual abre y cierra la conexión

        daHistoria.Fill(dsAgil.HistoriaAV, cAnexo, TxtCiclo.Text)
        daFacturas.Fill(dsAgil, "Facturas")

        cnAgil.Open()
        'For Each drFactura In dsAgil.Tables("Facturas").Rows
        '    cCusnam = drFactura("Descr")
        '    drHistoria = dtHistoria.NewRow()
        '    drHistoria("Fecha") = drFactura("Feven")
        '    If drHistoria("Fecha") < "20171201" Then
        '        drHistoria("Concepto") = "Aviso No. " & drFactura("Factura")
        '    Else
        '        If IsDBNull(drFactura("SerieCFDI")) Then
        '            drHistoria("Concepto") = "Aviso No. " & drFactura("Factura") & " - "
        '        Else
        '            drHistoria("Concepto") = "Aviso No. " & drFactura("Factura") & " - " & drFactura("SerieCFDI").trim & drFactura("NofacturaCFDI")
        '        End If

        '    End If

        '    drHistoria("Cargo") = drFactura("Importefac")
        '    drHistoria("Abono") = 0
        '    drHistoria("Balance") = 0
        '    drHistoria("Documento") = drHistoria("Concepto")
        '    drHistoria("Cheque") = " "
        '    drHistoria("Depositado") = " "
        '    drHistoria("Ven") = drFactura("Letra")
        '    dtHistoria.Rows.Add(drHistoria)

        '    cCliente = drFactura("Cliente")
        '    Ndias = DateDiff(DateInterval.Day, CTOD(drFactura("Feven")), CTOD(drFactura("Fepag")))
        '    If Ndias > 0 Then
        '        cm4.CommandText = "SELECT isnull(sum(Importe),0) as mora FROM Historia WHERE Observa1 = 'MORATORIOS' and Anexo = '" & cAnexo & "' and letra = '" & drFactura("Letra") & "'"
        '        nMora = cm4.ExecuteScalar
        '        If nMora > 0 Then
        '            nNumAtrasos += 1
        '            nPromDias += Ndias
        '            If nMaxMonto <= drFactura("ImporteFac") Then
        '                nMaxMonto = drFactura("ImporteFac")
        '            End If
        '            nPromMonto += drFactura("ImporteFac")
        '            If nMaxDias <= Ndias Then
        '                nMaxDias = Ndias
        '            End If
        '        End If

        '    End If

        'Next

        cnAgil.Close()

        For Each drPago In dsAgil.HistoriaAV.Rows
            cCusnam = drPago("Descr")
            drHistoria = dtHistoria.NewRow()
            drHistoria("Fecha") = drPago("Fecha")
            drHistoria("Concepto") = drPago("Observa1")

            If drPago("Balance") = "N" Then
                drHistoria("Cargo") = drPago("Importe")
                drHistoria("Abono") = drPago("Importe")
            Else
                drHistoria("Cargo") = 0
                drHistoria("Abono") = drPago("Importe")
            End If
            drHistoria("Balance") = 0
            nDocumento = drPago("Documento")
            Select Case nDocumento
                Case 1
                    drHistoria("Documento") = "Nota de Cargo No. " & drPago("Numero")
                Case 2
                    drHistoria("Documento") = "Recibo de caja No. " & drPago("Numero")
                Case 4
                    drHistoria("Documento") = "Cargo Interno "
                Case 5
                    drHistoria("Documento") = "Abono Interno "
                Case 6
                    If drHistoria("Fecha") < "20171201" Then
                        drHistoria("Documento") = "Factura de pago No. " & drPago("Numero")
                    Else
                        drHistoria("Documento") = "Factura de pago No. " & drPago("Serie").trim & drPago("Numero")
                    End If

                Case 7
                    drHistoria("Documento") = "Factura de Activo Fijo"
            End Select
            drHistoria("Cheque") = drPago("Cheque")
            drHistoria("Depositado") = drPago("DescBanco")
            drHistoria("Ven") = drPago("Letra")
            dtHistoria.Rows.Add(drHistoria)
        Next

        ' Aquí tengo que ordenar la tabla dtHistoria de acuerdo a la fecha del movimiento
        ' dejándola en la tabla dtTemporal

        drPagos = dtHistoria.Select(True, "Fecha, ven, Documento")

        For Each drPago In drPagos
            dtTemporal.ImportRow(drPago)
        Next

        ' Enseguida copio la tabla dtTemporal en dtHistoria y elimino los registros de dtTemporal,
        ' al mismo tiempo que modifico su estructura para que no sea idéntica a la de dtHistoria

        dtHistoria = dtTemporal.Copy()
        dtTemporal.Clear()
        dtTemporal.Columns.Remove("Ven")
        dtTemporal.Columns.Add("Vencimiento", Type.GetType("System.String"))

        ' Ahora barro la tabla dtHistoria para determinar el balance después de cada movimiento

        nBalance = 0
        cChequeAux = "INICIAL"
        For Each drPago In dtHistoria.Rows

            If cChequeAux <> drPago("Cheque").ToString.Trim And nPromMontoAux > 0 Then
                'If nMaxMonto <= nPromMontoAux Then
                'nMaxMonto = nPromMontoAux
                'End If

                nPromMontoAux = 0
            End If

            nBalance = nBalance + drPago("Cargo")
            nBalance = nBalance - drPago("Abono")

            drHistoria = dtTemporal.NewRow()
            drHistoria("Fecha") = drPago("Fecha")
            drHistoria("Concepto") = drPago("Concepto")
            drHistoria("Cargo") = drPago("Cargo")
            drHistoria("Abono") = drPago("Abono")
            drHistoria("Balance") = Round(nBalance, 2)
            drHistoria("Documento") = drPago("Documento")
            drHistoria("Cheque") = drPago("Cheque")
            drHistoria("Depositado") = drPago("Depositado")
            drHistoria("Vencimiento") = drPago("Ven")
            If InStr(drPago("Concepto").ToString.Trim, "Aviso de vencimiento") Then
                cFechaAux = drHistoria("Fecha")
                ImporteAux = drPago("Cargo")
            ElseIf (drPago("Concepto").ToString.Trim = "MORATORIOS" Or drPago("Concepto").ToString.Trim = "IVA MORATORIOS") And cChequeAux <> drPago("Cheque").ToString.Trim Then

                cChequeAux = drPago("Cheque").ToString.Trim
            End If
            If cChequeAux = drPago("Cheque").ToString.Trim Then
                'nPromMontoAux += drPago("Abono")
            End If
            dtTemporal.Rows.Add(drHistoria)

        Next

        'If nPromMontoAux > 0 Then
        'nPromMonto += nPromMontoAux
        'nPromMontoAux = 0
        'End If


        dtHistoria = dtTemporal.Copy()

        dsAgil.Relations.Clear()
        'dsAgil.Tables("Historia").Constraints.Clear()
        dsAgil.Tables("Facturas").Constraints.Clear()
        'dsAgil.Tables.Remove("Historia")
        dsAgil.Tables.Remove("Facturas")
        dsAgil.Tables.Add(dtHistoria)

        ' Descomentar la siguiente línea en caso de que desee modificarse el reporte rptHistoria
        ' dsAgil.WriteXml("C:\Schema13.xml", XmlWriteMode.WriteSchema)

        cReportTitle = "HISTORIA DE PAGOS DEL CONTRATO " & txtAnexo.Text & " AL " & Mes(cFecha)
        cReportComments = Trim(cCusnam)

        newrptHistoria.SummaryInfo.ReportTitle = cReportTitle
        newrptHistoria.SummaryInfo.ReportComments = cReportComments

        newrptHistoria.SetDataSource(dsAgil)
        newrptHistoria.Subreports(0).SetDataSource(dsAgil)
        newrptHistoria.SetParameterValue("Resumen", Not Resumen)
        newrptHistoria.SetParameterValue("MaxDias", nMaxDias)
        newrptHistoria.SetParameterValue("MaxMonto", nMaxMonto)
        If nNumAtrasos = 0 Then
            newrptHistoria.SetParameterValue("PromMonto", 0)
            newrptHistoria.SetParameterValue("PromDias", 0)
        Else
            newrptHistoria.SetParameterValue("PromMonto", nPromMonto / nNumAtrasos)
            newrptHistoria.SetParameterValue("PromDias", nPromDias / nNumAtrasos)
        End If
        newrptHistoria.SetParameterValue("NumAtrasos", nNumAtrasos)

        CrystalReportViewer1.ReportSource = newrptHistoria

        cnAgil.Dispose()
        cm1.Dispose()
    End Sub

End Class
