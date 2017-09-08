Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports System.Text

Public Class frmMorales

    Inherits System.Windows.Forms.Form
    Dim tb As New JuridicoDSTableAdapters.AsignacionClavesOBSTableAdapter
    Friend WithEvents btnLoteFIRA As System.Windows.Forms.Button
    Friend WithEvents CmbDB As ComboBox
    Friend WithEvents Label1 As Label
    Dim ClaveOBS As String = ""
    Dim StrConnX As String = ""
    Dim cnAgil As New SqlConnection(strConn)

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents lblProceso As System.Windows.Forms.Label
    Friend WithEvents dtpProceso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnGeneraM As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnGeneraM = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lblProceso = New System.Windows.Forms.Label()
        Me.dtpProceso = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLoteFIRA = New System.Windows.Forms.Button()
        Me.CmbDB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGeneraM
        '
        Me.btnGeneraM.Location = New System.Drawing.Point(479, 21)
        Me.btnGeneraM.Name = "btnGeneraM"
        Me.btnGeneraM.Size = New System.Drawing.Size(104, 23)
        Me.btnGeneraM.TabIndex = 33
        Me.btnGeneraM.Text = "Generar 3.0"
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(369, 21)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(104, 23)
        Me.btnProcesar.TabIndex = 32
        Me.btnProcesar.Text = "Procesar"
        '
        'lblProceso
        '
        Me.lblProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProceso.Location = New System.Drawing.Point(160, 25)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Size = New System.Drawing.Size(110, 16)
        Me.lblProceso.TabIndex = 31
        Me.lblProceso.Text = "Fecha de Proceso"
        '
        'dtpProceso
        '
        Me.dtpProceso.Enabled = False
        Me.dtpProceso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProceso.Location = New System.Drawing.Point(275, 23)
        Me.dtpProceso.Name = "dtpProceso"
        Me.dtpProceso.Size = New System.Drawing.Size(88, 20)
        Me.dtpProceso.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(589, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Generar 4.0"
        '
        'btnLoteFIRA
        '
        Me.btnLoteFIRA.Location = New System.Drawing.Point(699, 21)
        Me.btnLoteFIRA.Name = "btnLoteFIRA"
        Me.btnLoteFIRA.Size = New System.Drawing.Size(104, 23)
        Me.btnLoteFIRA.TabIndex = 35
        Me.btnLoteFIRA.Text = "Lote FIRA PI"
        '
        'CmbDB
        '
        Me.CmbDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDB.FormattingEnabled = True
        Me.CmbDB.Location = New System.Drawing.Point(34, 23)
        Me.CmbDB.Name = "CmbDB"
        Me.CmbDB.Size = New System.Drawing.Size(121, 21)
        Me.CmbDB.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Mes"
        '
        'frmMorales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(815, 64)
        Me.Controls.Add(Me.CmbDB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLoteFIRA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGeneraM)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.lblProceso)
        Me.Controls.Add(Me.dtpProceso)
        Me.Name = "frmMorales"
        Me.Text = "Buró de Crédito Personas Morales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        ' Declaración de variables de conexión ADO .NET
        StrConnX = "Server=SERVER-RAID; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"

        cnAgil = New SqlConnection(StrConnX)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim cm5 As New SqlCommand()
        Dim cm6 As New SqlCommand()
        Dim cm7 As SqlCommand
        Dim cm8 As New SqlCommand()
        Dim cm9 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daMorales As New SqlDataAdapter(cm1)
        Dim daMoraDeta As New SqlDataAdapter(cm2)
        Dim daEdoctav As New SqlDataAdapter(cm3)
        Dim daEdoctas As New SqlDataAdapter(cm4)
        Dim daEdoctao As New SqlDataAdapter(cm5)
        Dim daFacturas As New SqlDataAdapter(cm6)
        Dim daAvios As New SqlDataAdapter(cm8)
        Dim daAviosC As New SqlDataAdapter(cm9)
        Dim daClientes As SqlDataAdapter
        Dim daAnexos As New BuroDSTableAdapters.DatosCon1TableAdapter
        Dim TTAnexos As New BuroDS.DatosCon1DataTable
        Dim drMoral As DataRow
        Dim drCliente As DataRow
        Dim drMoraDeta As DataRow
        Dim drAnexo As DataRow
        Dim drFactura As DataRow
        Dim drEdoctav() As DataRow
        Dim drEdoctas() As DataRow
        Dim drEdoctao() As DataRow
        Dim drFacturas() As DataRow
        Dim drAvio As DataRow
        Dim drAvioC As DataRow
        Dim relMoraDetaEdoctav As DataRelation
        Dim relMoraDetaEdoctas As DataRelation
        Dim relMoraDetaEdoctao As DataRelation
        Dim relMoraDetaFacturas As DataRelation
        Dim strDelete As String
        Dim strInsert As String
        Dim fecha As Date
        Dim fechaU As Date
        Dim cMoneda As String

        ' Declaración de variables de datos

        Dim cAnexo As String
        Dim cApertura As String
        Dim cCalle As String
        Dim cCiudad As String
        Dim cCliente As String
        Dim cColonia As String
        Dim cCP As String
        Dim cCusnam As String
        Dim cDelega As String
        Dim cEmpresa As String
        Dim cEstado As String
        Dim cFecha As String
        Dim cFechaF As String
        Dim cFechaAnt As String
        Dim cFechaFin As String
        Dim cFepag As String
        Dim cFeven As String
        Dim cFlcan As String
        Dim cIndPag As String
        Dim cMaterno As String
        Dim cNombre As String
        Dim cPaterno As String
        Dim cRFC As String
        Dim cTerConSaldo As String
        Dim cTipar As String
        Dim cTipo As String
        Dim cUltPago As String
        Dim i As Integer
        Dim nCarteraEquipo As Decimal = 0
        Dim nCarteraSeguro As Decimal = 0
        Dim nCarteraOtros As Decimal = 0
        Dim nDias As Integer
        Dim nEspacios As Byte
        Dim nInteresEquipo As Decimal = 0
        Dim nInteresSeguro As Decimal = 0
        Dim nInteresOtros As Decimal = 0
        Dim nMoi As Decimal
        Dim nPlazo As Integer
        Dim nPlazoFactor As Decimal
        Dim nSaldoEquipo As Decimal = 0
        Dim nSaldoSeguro As Decimal = 0
        Dim nSaldoOtros As Decimal = 0
        Dim nSaldoFac As Decimal
        Dim nFrecuencia As Integer
        Dim nMensualidad As Decimal
        Dim sUltPag As String
        Dim ta As New ProductionDataSetTableAdapters.AnexosTableAdapter
        ta.Connection.ConnectionString = StrConnX
        Dim newfrmPideNombre As frmPideNombre

        btnProcesar.Enabled = False
        dtpProceso.Enabled = False

        cFecha = DTOC(dtpProceso.Value)
        cFechaF = dtpProceso.Value.ToString("yyyy-MM-dd")
        cFechaAnt = DTOC(dtpProceso.Value.AddDays(dtpProceso.Value.Day * -1))
        Call LlenaNombres(cnAgil)

        If MessageBox.Show("¿es para version 3.0?", "Version", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            nPlazoFactor = 1
        Else
            nPlazoFactor = 30.4
        End If

        ' Este Stored Procedure regresa todos los clientes que sean persona moral o
        ' persona física con actividad empresarial y que tengan por lo menos
        ' un contrato con alguna de las siguientes características:

        ' Activo
        ' Terminado con saldo
        ' Cancelado o Terminado en el mes de proceso
        ' Terminado en algún mes anterior al de proceso y que pagaron en el actual

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Morales1"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters.Add("@FechaAnt", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
            .Parameters(1).Value = cFechaAnt
        End With

        ' Este Stored Procedure regresa todos los contratos de clientes que sean persona moral o
        ' persona física con actividad empresarial que estén activos o terminados con saldo
        ' o cancelados/terminados en el mes de proceso.

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MoraDeta1"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortización del equipo de todos los contratos activos
        ' con fecha de contratación menor o igual a la de proceso y que el cliente sea persona moral
        ' o persona física con actividad empresarial

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv2"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortización del seguro de todos los contratos activos
        ' con fecha de contratación menor o igual a la de proceso y que el cliente sea persona moral
        ' o persona física con actividad empresarial

        With cm4
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv3"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortización de Otros Adeudos de todos los contratos activos
        ' con fecha de contratación menor o igual a la de proceso y que el cliente sea persona moral
        ' o persona física con actividad empresarial

        With cm5
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv4"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae las facturas de los contratos activos o terminados
        ' con fecha de terminación mayor o igual al 1o. de enero de 2005, sin importar
        ' si están pagadas o no.

        With cm6
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MoraDeta3"
            .Connection = cnAgil
        End With

        'Stored procedure que trae los avios 

        With cm8
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BuroAvio"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters.Add("@FechaF", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
            .Parameters(1).Value = cFechaF
        End With

        'Stored procedure que trae los avios cerrados

        With cm9
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BuroAvioCerrado"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters.Add("@FechaAnt", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
            .Parameters(1).Value = cFechaAnt
        End With

        ' Primero elimino todos los registros de la tabla Morales

        cnAgil.Open()
        strDelete = "DELETE FROM Morales"
        cm7 = New SqlClient.SqlCommand(strDelete, cnAgil)
        cm7.ExecuteNonQuery()
        cnAgil.Close()

        ' A continuación elimino todos los registros de la tabla MoraDeta

        cnAgil.Open()
        strDelete = "DELETE FROM MoraDeta"
        cm7 = New SqlClient.SqlCommand(strDelete, cnAgil)
        cm7.ExecuteNonQuery()
        cnAgil.Close()

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daMorales.Fill(dsAgil, "Morales")
        daMoraDeta.Fill(dsAgil, "MoraDeta")
        daEdoctav.Fill(dsAgil, "Edoctav")
        daEdoctas.Fill(dsAgil, "Edoctas")
        daEdoctao.Fill(dsAgil, "Edoctao")
        daFacturas.Fill(dsAgil, "Facturas")

        ' Establecer la relación entre Anexos y Edoctav

        relMoraDetaEdoctav = New DataRelation("MoraDetaEdoctav", dsAgil.Tables("MoraDeta").Columns("Anexo"), dsAgil.Tables("Edoctav").Columns("Anexo"))

        ' Establecer la relación entre Anexos y Edoctas

        relMoraDetaEdoctas = New DataRelation("MoraDetaEdoctas", dsAgil.Tables("MoraDeta").Columns("Anexo"), dsAgil.Tables("Edoctas").Columns("Anexo"))

        ' Establecer la relación entre Anexos y Edoctao

        relMoraDetaEdoctao = New DataRelation("MoraDetaEdoctao", dsAgil.Tables("MoraDeta").Columns("Anexo"), dsAgil.Tables("Edoctao").Columns("Anexo"))

        ' Establecer la relación entre Anexos y Facturas

        relMoraDetaFacturas = New DataRelation("MoraDetaFacturas", dsAgil.Tables("MoraDeta").Columns("Anexo"), dsAgil.Tables("Facturas").Columns("Anexo"))

        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relMoraDetaEdoctav)
        dsAgil.Relations.Add(relMoraDetaEdoctas)
        dsAgil.Relations.Add(relMoraDetaEdoctao)
        dsAgil.Relations.Add(relMoraDetaFacturas)

        For Each drMoral In dsAgil.Tables("Morales").Rows

            cCliente = drMoral("Cliente")
            If cCliente = "05852" Then
                'Continue For
            End If

            ' El siguiente Stored Procedure trae todos los atributos de la tabla Clientes,
            ' para un cliente dado.

            cm7 = New SqlCommand()
            With cm7
                .CommandType = CommandType.StoredProcedure
                .CommandText = "DatosClie1"
                .Connection = cnAgil
                .Parameters.Add("@Cliente", SqlDbType.NVarChar)
                .Parameters(0).Value = cCliente
            End With
            daClientes = New SqlDataAdapter(cm7)
            daClientes.Fill(dsAgil, "Clientes")
            drCliente = dsAgil.Tables("Clientes").Rows(0)

            cEmpresa = Space(75)
            cNombre = Space(75)
            cPaterno = Space(25)
            cMaterno = Space(25)
            nEspacios = 0

            cCusnam = Trim(drCliente("Descr"))
            cRFC = drCliente("Rfc")
            cTipo = drCliente("Tipo")
            cCalle = Mid(drCliente("Calle"), 1, 40)
            cColonia = drCliente("Colonia")
            cDelega = Mid(drCliente("Delegacion"), 1, 40)
            cCiudad = drCliente("DescPlaza")
            cEstado = drCliente("Abreviado")
            cCP = drCliente("Copos")

            If cTipo = "M" Then

                cEmpresa = Mid(cCusnam, 1, 75)

            Else
                newfrmPideNombre = New frmPideNombre("M", cCusnam, cCliente)
                newfrmPideNombre.ShowDialog()
                cNombre = newfrmPideNombre.Nombre
                cPaterno = newfrmPideNombre.Paterno
                cMaterno = newfrmPideNombre.Materno
            End If

            If cTipo = "M" Then
                cTipo = "1"
            ElseIf cTipo = "E" Or cTipo = "F" Then
                cTipo = "2"
            End If

            strInsert = "INSERT INTO Morales(EMRfc, EMEmpresa, EMNombre, EMPaterno, EMMaterno, EMCalifica, EMActivida, EMCalle, EMColonia, EMDelega, EMCiudad, EMEstado, EMCp, EMTipCli, EMNumCli)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & cRFC & "', '"
            strInsert = strInsert & cEmpresa & "', '"
            strInsert = strInsert & cNombre & "', '"
            strInsert = strInsert & cPaterno & "', '"
            strInsert = strInsert & cMaterno & "', '"
            strInsert = strInsert & Space(2) & "', '"
            strInsert = strInsert & "99999999999" & "', '"
            strInsert = strInsert & cCalle & "', '"
            strInsert = strInsert & cColonia & "', '"
            strInsert = strInsert & cDelega & "', '"
            strInsert = strInsert & cCiudad & "', '"
            strInsert = strInsert & cEstado & "', '"
            strInsert = strInsert & cCP & "', '"
            strInsert = strInsert & cTipo & "', '"
            strInsert = strInsert & cCliente
            strInsert = strInsert & "')"
            cnAgil.Open()
            cm7 = New SqlCommand(strInsert, cnAgil)
            cm7.ExecuteNonQuery()
            cnAgil.Close()

            dsAgil.Tables.Remove("Clientes")

        Next

        ' Por último, inserto el registro correspondiente al Fraude de Plegadizos Nacionales

        strInsert = "INSERT INTO Morales(EMRfc, EMEmpresa, EMNombre, EMPaterno, EMMaterno, EMCalifica, EMActivida, EMCalle, EMColonia, EMDelega, EMCiudad, EMEstado, EMCp, EMTipCli, EMNumCli)"
        strInsert = strInsert & " VALUES ('"
        strInsert = strInsert & "PNA970703CIO" & "', '"
        strInsert = strInsert & "PLEGADIZOS NACIONALES S.A. DE C.V." & "', '"
        strInsert = strInsert & Space(75) & "', '"
        strInsert = strInsert & Space(25) & "', '"
        strInsert = strInsert & Space(25) & "', '"
        strInsert = strInsert & Space(2) & "', '"
        strInsert = strInsert & "99999999999" & "', '"
        strInsert = strInsert & "MONROVIA # 722" & "', '"
        strInsert = strInsert & "PORTALES" & "', '"
        strInsert = strInsert & "BENITO JUAREZ" & "', '"
        strInsert = strInsert & "DISTRITO FEDERAL" & "', '"
        strInsert = strInsert & "DF" & "', '"
        strInsert = strInsert & "03300" & "', '"
        strInsert = strInsert & "1" & "', '"
        strInsert = strInsert & "01438"
        strInsert = strInsert & "')"
        cnAgil.Open()
        cm7 = New SqlCommand(strInsert, cnAgil)
        cm7.ExecuteNonQuery()
        cnAgil.Close()

        For Each drMoraDeta In dsAgil.Tables("MoraDeta").Rows

            cAnexo = drMoraDeta("Anexo")
            If cAnexo = "036610001" Then
                cAnexo = "036610001"
            End If

            ' El siguiente Stored Procedure trae todos los atributos de la tabla Anexos,            ' para un anexo dado

            'cm7 = New SqlCommand()
            'With cm7
            '.CommandType = CommandType.StoredProcedure
            '.CommandText = "DatosCon1"
            '.Connection = cnAgil
            '.Parameters.Add("@Anexo", SqlDbType.NVarChar)
            '.Parameters(0).Value = cAnexo
            'End With
            'daAnexos = New SqlDataAdapter(cm7)
            'dsAgil.Tables("Anexos").Dispose()

            daAnexos.Fill(TTAnexos, cAnexo)
            If TTAnexos.Rows.Count <= 0 Then
                MessageBox.Show("Sin Datos " & cAnexo)
                Continue For
            End If

            drAnexo = TTAnexos.Rows(0)

            cFlcan = drAnexo("Flcan")
            cCliente = drAnexo("Cliente")
            cApertura = drAnexo("Fechacon")
            nPlazo = Round(drAnexo("Plazo"))
            nPlazo = Round(drAnexo("Plazo") / nPlazoFactor)


            cTipar = drAnexo("Tipar")
            If cTipar = "B" Then
                Continue For 'SE OMITE EL FULL SERVICE
            End If
            If cTipar = "P" Then
                cTipar = "1300" ' ls
            ElseIf cTipar = "S" Then
                cTipar = "1305"
            ElseIf cTipar = "R" Then
                cTipar = "1308"
            ElseIf cTipar = "F" Then
                cTipar = "1320"
            ElseIf cTipar = "H" Then
                cTipar = "1307"
            Else
                cTipar = "0000"
            End If
            nMoi = Round(drAnexo("ImpEq") - drAnexo("IvaEq") - drAnexo("Amorin"), 0)
            cFechaFin = drAnexo("FechaFin")
            nSaldoFac = 0
            cTerConSaldo = "N"

            ' Determino el saldo vencido de los contratos ACT o TER

            If cFlcan = "A" Or cFlcan = "T" Then

                ' Esta instrucción trae las facturas única y exclusivamente del contrato
                ' que está siendo procesado

                drFacturas = drMoraDeta.GetChildRows("MoraDetaFacturas")

                For Each drFactura In drFacturas

                    cFeven = drFactura("Feven")
                    cFepag = drFactura("Fepag")
                    cIndPag = drFactura("IndPag")
                    nSaldoFac = drFactura("SaldoFac")
                    nSaldoEquipo = drFactura("Saldo")
                    nDias = 0
                    cTerConSaldo = "N"

                    ' Solo considero facturas exigibles

                    If cFeven <= cFecha Then

                        ' Determino la fecha de último pago

                        If cFepag > cUltPago Then
                            cUltPago = cFepag
                        End If

                        ' Solo proceso facturas no pagadas (que tienen saldo)

                        If cIndPag = " " And nSaldoFac > 0 Then

                            nDias = DateDiff(DateInterval.Day, CTOD(cFeven), CTOD(cFecha)) + 1

                            If nDias > 999 Then
                                nDias = 999
                            End If
                            If InStr(cAnexo, "00388") > 0 Then nDias = 0 'no mostrar retrasos apara Palm AndriaBecerril
                            If cAnexo = "019180002" Or cAnexo = "040760001" Then nDias = 0 'por prepago de Contratos Ing. Francisco Monroy


                            If nDias > 0 Then

                                nSaldoFac = Round(nSaldoFac, 0)
                                nSaldoEquipo = Round(nSaldoEquipo, 0)

                                If cFlcan = "T" Then
                                    cTerConSaldo = "S"
                                End If

                                'nuevos datos version 04 #ECT20150121.n
                                nFrecuencia = ta.Dias(cAnexo)
                                sUltPag = ta.UltimoPago(cAnexo)
                                sUltPag = Mid(sUltPag, 7, 2) & Mid(sUltPag, 5, 2) & Mid(sUltPag, 1, 4)
                                nMensualidad = ta.Mensualidad(cAnexo)
                                nMensualidad = Round(nMensualidad, 0)
                                'nuevos datos version 04 #ECT20150121.n

                                ' Ahora tengo que insertar un registro por cada factura que tenga vencida
                                ' lo cual no se venía haciendo hasta el reporte del mes de diciembre de 2006

                                strInsert = "INSERT INTO MoraDeta(EMNumCli, CRContrato, CRApertura, CRPlazo, CRTipar, CRMoi, CRMoneda, CRFechaFin, DERetraso, DEImporte, TerConSaldo,CRFrecuencia,CRPago,CRUltimoPag,CRSaldoInsoluto)"
                                strInsert = strInsert & " VALUES ('"
                                strInsert = strInsert & cCliente & "', '"
                                strInsert = strInsert & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "', '"
                                strInsert = strInsert & Mid(cApertura, 7, 2) & Mid(cApertura, 5, 2) & Mid(cApertura, 1, 4) & "', '"
                                strInsert = strInsert & Stuff(Trim(CStr(nPlazo)), "I", "0", 5) & "', '"
                                strInsert = strInsert & cTipar & "', '"
                                strInsert = strInsert & Stuff(Trim(CStr(nMoi)), "I", "0", 20) & "', '"
                                strInsert = strInsert & "001" & "', '"
                                strInsert = strInsert & "        " & "', '"
                                strInsert = strInsert & Stuff(Trim(CStr(nDias)), "I", "0", 3) & "', '"
                                strInsert = strInsert & Stuff(Trim(CStr(nSaldoFac)), "I", "0", 20) & "', '"
                                strInsert = strInsert & cTerConSaldo & "', '"
                                strInsert = strInsert & Stuff(Trim(CStr(nFrecuencia)), "I", "0", 5) & "', '"
                                strInsert = strInsert & Stuff(Trim(CStr(nMensualidad)), "I", "0", 20) & "', '"
                                strInsert = strInsert & Stuff(Trim(CStr(sUltPag)), "I", "0", 8) & "', '"
                                strInsert = strInsert & Stuff(Trim(CStr(nSaldoEquipo)), "I", "0", 20)
                                strInsert = strInsert & "')"
                                cnAgil.Open()
                                cm7 = New SqlCommand(strInsert, cnAgil)
                                cm7.ExecuteNonQuery()
                                cnAgil.Close()
                            End If

                        End If

                    End If

                Next

            End If

            ' Cálculo del Saldo Insoluto del equipo para lo cual necesito traer la tabla de
            ' amortización del equipo, del seguro y de otros adeudos de este contrato en particular

            nSaldoEquipo = 0
            nInteresEquipo = 0
            nCarteraEquipo = 0

            nSaldoSeguro = 0
            nInteresSeguro = 0
            nCarteraSeguro = 0

            nSaldoOtros = 0
            nInteresOtros = 0
            nCarteraOtros = 0

            ' Los contratos TER o CAN ya no tienen saldo insoluto ni de equipo, ni de seguro,
            ' ni de otros adeudos

            If cFlcan = "A" Then

                ' Esta instrucción trae la tabla de amortización del Equipo única y exclusivamente del contrato
                ' que está siendo procesado

                drEdoctav = drMoraDeta.GetChildRows("MoraDetaEdoctav")
                TraeSald(drEdoctav, cFecha, nSaldoEquipo, nInteresEquipo, nCarteraEquipo)

                drEdoctas = drMoraDeta.GetChildRows("MoraDetaEdoctas")
                TraeSald(drEdoctas, cFecha, nSaldoSeguro, nInteresSeguro, nCarteraSeguro)

                drEdoctao = drMoraDeta.GetChildRows("MoraDetaEdoctao")
                TraeSald(drEdoctao, cFecha, nSaldoOtros, nInteresOtros, nCarteraOtros)

            End If

            nSaldoEquipo = Round(nSaldoEquipo + nSaldoSeguro + nSaldoOtros, 0)

            If nSaldoEquipo = 0 And nSaldoFac > 0 Then
                cFechaFin = Space(8)
            End If

            ' Debo insertar un registro por el saldo vigente con DERetraso = 0 y DEImporte = Saldo Insoluto

            If nSaldoEquipo <> 0 Or cFechaFin <> "        " Or cTerConSaldo <> "S" Then
                'nuevos datos version 04 #ECT20150121.n
                nFrecuencia = ta.Dias(cAnexo)
                sUltPag = ta.UltimoPago(cAnexo)
                sUltPag = Mid(sUltPag, 7, 2) & Mid(sUltPag, 5, 2) & Mid(sUltPag, 1, 4)
                nMensualidad = ta.Mensualidad(cAnexo)
                nMensualidad = Round(nMensualidad, 0)
                'nuevos datos version 04 #ECT20150121.n

                strInsert = "INSERT INTO MoraDeta(EMNumCli, CRContrato, CRApertura, CRPlazo, CRTipar, CRMoi, CRMoneda, CRFechaFin, DERetraso, DEImporte, TerConSaldo,CRFrecuencia,CRPago,CRUltimoPag,CRSaldoInsoluto)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & cCliente & "', '"
                strInsert = strInsert & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & "', '"
                strInsert = strInsert & Mid(cApertura, 7, 2) & Mid(cApertura, 5, 2) & Mid(cApertura, 1, 4) & "', '"
                strInsert = strInsert & Stuff(Trim(CStr(nPlazo)), "I", "0", 5) & "', '"
                strInsert = strInsert & cTipar & "', '"
                strInsert = strInsert & Stuff(Trim(CStr(nMoi)), "I", "0", 20) & "', '"
                strInsert = strInsert & "001" & "', '"
                strInsert = strInsert & Mid(cFechaFin, 7, 2) & Mid(cFechaFin, 5, 2) & Mid(cFechaFin, 1, 4) & "', '"
                strInsert = strInsert & "000" & "', '"
                strInsert = strInsert & Stuff(Trim(CStr(nSaldoEquipo)), "I", "0", 20) & "', '"
                strInsert = strInsert & cTerConSaldo & "', '"
                strInsert = strInsert & Stuff(Trim(CStr(nFrecuencia)), "I", "0", 5) & "', '"
                strInsert = strInsert & Stuff(Trim(CStr(nMensualidad)), "I", "0", 20) & "', '"
                strInsert = strInsert & Stuff(Trim(CStr(sUltPag)), "I", "0", 8) & "', '"
                strInsert = strInsert & Stuff(Trim(CStr(nSaldoEquipo)), "I", "0", 20)
                strInsert = strInsert & "')"
                cnAgil.Open()
                cm7 = New SqlCommand(strInsert, cnAgil)
                cm7.ExecuteNonQuery()
                cnAgil.Close()
            End If

            'dsAgil.Tables.Remove("Anexos")

        Next

        ' Por último, inserto el registro correspondiente al Fraude de Plegadizos Nacionales

        strInsert = "INSERT INTO MoraDeta(EMNumCli, CRContrato, CRApertura, CRPlazo, CRTipar, CRMoi, CRMoneda, CRFechaFin, DERetraso, DEImporte, TerConSaldo,CRFrecuencia,CRPago,CRUltimoPag,CRSaldoInsoluto)"
        strInsert = strInsert & " VALUES ('"
        strInsert = strInsert & "01438" & "', '"
        strInsert = strInsert & "00839/0001" & "', '"
        strInsert = strInsert & "15012001" & "', '"
        strInsert = strInsert & "00024" & "', '"
        strInsert = strInsert & "1320" & "', '"
        strInsert = strInsert & "00000000000000614772" & "', '"
        strInsert = strInsert & "001" & "', '"
        strInsert = strInsert & "        " & "', '"
        strInsert = strInsert & "999" & "', '"
        strInsert = strInsert & "00000000000000768352" & "', '"
        strInsert = strInsert & "S','030','00000000000000768352','00000000','00000000000000614772'"
        strInsert = strInsert & ")"
        cnAgil.Open()
        cm7 = New SqlCommand(strInsert, cnAgil)
        cm7.ExecuteNonQuery()

        'AVIO
        'aqui se llenan los datos de Avio
        daAvios.Fill(dsAgil, "Avios")


        For Each drAvio In dsAgil.Tables("Avios").Rows
            cTipar = drAvio("Tipo")
            If cTipar = "A" Then
                cTipar = "1307"
            ElseIf cTipar = "H" Then
                cTipar = "1307"
            ElseIf cTipar = "C" Then
                cTipar = "1305"
            Else
                cTipar = "0000"
            End If

            nPlazo = DateDiff(DateInterval.Day, drAvio("Fecha Inicio"), drAvio("FechaTerminacion"))
            nPlazo = Round(nPlazo / nPlazoFactor, 0)
            nMoi = Round(drAvio("Saldo"), 0)
            nSaldoEquipo = Round(drAvio("Saldo"), 0)
            cFechaFin = ""
            If drAvio("FechaTerminacion") <= dtpProceso.Value Then
                cTerConSaldo = "S"
            Else
                cTerConSaldo = "N"
            End If

            'nuevos datos version 04 #ECT20150121.n
            nFrecuencia = 0
            nFrecuencia = DateDiff(DateInterval.Day, drAvio("Fecha Inicio"), drAvio("FechaTerminacion"))
            nDias = drAvio("Retraso")
            If nDias > 999 Then nDias = 999
            If nDias < 0 Then nDias = 0
            sUltPag = ta.UltimoPagoAV(cAnexo, drAvio("Ciclo"))
            sUltPag = Mid(sUltPag, 7, 2) & Mid(sUltPag, 5, 2) & Mid(sUltPag, 1, 4)
            nMensualidad = nMoi
            nMensualidad = Round(nMensualidad, 0)
            'nuevos datos version 04 #ECT20150121.n

            fecha = drAvio("Fecha Inicio")
            If fecha > CDate("30/11/2015") Then 'A PARTIR DE ESTA FECHA SE REPORTE EL CICLO 
                cAnexo = drAvio("Anexo") & "-" & drAvio("Ciclo")
            Else
                cAnexo = drAvio("Anexo")
            End If

            strInsert = "INSERT INTO MoraDeta(EMNumCli, CRContrato, CRApertura, CRPlazo, CRTipar, CRMoi, CRMoneda, CRFechaFin, DERetraso, DEImporte, TerConSaldo,CRFrecuencia,CRPago,CRUltimoPag,CRSaldoInsoluto)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & drAvio("Cliente") & "', '"
            strInsert = strInsert & cAnexo & "', '"
            strInsert = strInsert & fecha.ToString("ddMMyyyy") & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(nPlazo)), "I", "0", 5) & "', '"
            strInsert = strInsert & cTipar & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(nMoi)), "I", "0", 20) & "', '"
            strInsert = strInsert & "001" & "', '"
            strInsert = strInsert & Mid(cFechaFin, 7, 2) & Mid(cFechaFin, 5, 2) & Mid(cFechaFin, 1, 4) & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(nDias)), "I", "0", 3) & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(nSaldoEquipo)), "I", "0", 20) & "', '"
            strInsert = strInsert & cTerConSaldo & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(nFrecuencia)), "I", "0", 3) & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(nMensualidad)), "I", "0", 20) & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(sUltPag)), "I", "0", 8) & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(nSaldoEquipo)), "I", "0", 20)
            strInsert = strInsert & "')"
            If cnAgil.State <> ConnectionState.Open Then cnAgil.Open()
            cm7 = New SqlCommand(strInsert, cnAgil)
            cm7.ExecuteNonQuery()
            cnAgil.Close()
        Next



        daAviosC.Fill(dsAgil, "AviosC")
        For Each drAvioC In dsAgil.Tables("AviosC").Rows
            cTipar = drAvioC("Tipar")
            If cTipar = "A" Then
                cTipar = "1307"
            ElseIf cTipar = "H" Then
                cTipar = "1307"
            ElseIf cTipar = "C" Then
                cTipar = "1305"
            Else
                cTipar = "0000"
            End If

            fecha = CTOD(drAvioC("FechaAutorizacion"))
            If fecha > CDate("30/11/2015") Then
                cAnexo = Mid(drAvioC("Anexo"), 1, 5) & "/" & Mid(drAvioC("Anexo"), 6, 4) & "-" & drAvioC("Ciclo")
            Else
                cAnexo = Mid(drAvioC("Anexo"), 1, 5) & "/" & Mid(drAvioC("Anexo"), 6, 4)
            End If
            fechaU = CTOD(drAvioC("UltimoCorte"))
            nPlazo = DateDiff(DateInterval.Day, fecha, fechaU)
            nPlazo = Round(nPlazo / nPlazoFactor, 0) 'cambiar a meses ECT
            nMoi = Round(drAvioC("MOI"), 0)
            nSaldoEquipo = 0
            cFechaFin = drAvioC("UltimoCorte")
            cTerConSaldo = "N"

            'nuevos datos version 04 #ECT20150121.n
            nFrecuencia = 0
            nFrecuencia = DateDiff(DateInterval.Day, fecha, fechaU)
            sUltPag = ta.UltimoPago(cAnexo)
            sUltPag = Mid(sUltPag, 7, 2) & Mid(sUltPag, 5, 2) & Mid(sUltPag, 1, 4)
            nMensualidad = nMoi
            nMensualidad = Round(nMensualidad, 0)
            'nuevos datos version 04 #ECT20150121.n

            strInsert = "INSERT INTO MoraDeta(EMNumCli, CRContrato, CRApertura, CRPlazo, CRTipar, CRMoi, CRMoneda, CRFechaFin, DERetraso, DEImporte, TerConSaldo,CRFrecuencia,CRPago,CRUltimoPag,CRSaldoInsoluto)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & drAvioC("Cliente") & "', '"
            strInsert = strInsert & cAnexo & "', '"
            strInsert = strInsert & fecha.ToString("ddMMyyyy") & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(nPlazo)), "I", "0", 5) & "', '"
            strInsert = strInsert & cTipar & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(nMoi)), "I", "0", 20) & "', '"
            strInsert = strInsert & "001" & "', '"
            strInsert = strInsert & Mid(cFechaFin, 7, 2) & Mid(cFechaFin, 5, 2) & Mid(cFechaFin, 1, 4) & "', '"
            strInsert = strInsert & "000" & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(nSaldoEquipo)), "I", "0", 20) & "', '"
            strInsert = strInsert & cTerConSaldo & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(nFrecuencia)), "I", "0", 3) & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(nMensualidad)), "I", "0", 20) & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(sUltPag)), "I", "0", 8) & "', '"
            strInsert = strInsert & Stuff(Trim(CStr(nSaldoEquipo)), "I", "0", 20)
            strInsert = strInsert & "')"
            If cnAgil.State <> ConnectionState.Open Then cnAgil.Open()
            cm7 = New SqlCommand(strInsert, cnAgil)
            cm7.ExecuteNonQuery()
            cnAgil.Close()

        Next
        'AVIO

        'PROCESO PARA SUBIR FACTORAJE
        Dim Ruta As String = "C:\Files\BURO.TXT"
        If File.Exists(Ruta) = True Then
            If MessageBox.Show("Desea procesar Factoraje", "Factojare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim Arch As New StreamReader(Ruta)
                Dim Linea As String = "Primera"
                Dim CAD As String = ""
                Dim cTipop As String = ""
                Dim LineaX As String()
                While Not Arch.EndOfStream
                    CAD = ""
                    If Linea = "Primera" Then
                        Linea = Arch.ReadLine
                    End If
                    Linea = Arch.ReadLine
                    For X As Integer = 1 To Linea.Length
                        If Mid(Linea, X, 1) <> """" Then
                            CAD = CAD & Mid(Linea, X, 1)
                        End If
                    Next
                    Linea = CAD
                    LineaX = Linea.Split(vbTab)
                    If LineaX(0) <> "" Then
                        strInsert = "INSERT INTO Morales(EMRfc, EMEmpresa, EMNombre, EMPaterno, EMMaterno, EMCalifica, EMActivida, EMCalle, EMColonia, EMDelega, EMCiudad, EMEstado, EMCp, EMTipCli, EMNumCli)"
                        strInsert = strInsert & " VALUES ('"
                        strInsert = strInsert & LineaX(0) & "', '" 'rfc
                        strInsert = strInsert & LineaX(1) & "', '" 'empresa
                        If LineaX(1) = "" Then
                            strInsert = strInsert & LineaX(2) & "', '" 'nom
                            strInsert = strInsert & LineaX(3) & "', '" 'appp
                            strInsert = strInsert & LineaX(4) & "', '" 'appm
                            cTipop = "2"
                        Else
                            strInsert = strInsert & Space(75) & "', '" 'nom
                            strInsert = strInsert & Space(25) & "', '" 'appp
                            strInsert = strInsert & Space(25) & "', '" 'appm
                            cTipop = "1"
                        End If

                        strInsert = strInsert & Space(2) & "', '" 'califica
                        strInsert = strInsert & "99999999999" & "', '" 'activida
                        strInsert = strInsert & Mid(LineaX(7), 1, 40) & "', '" 'calle 40
                        strInsert = strInsert & Mid(LineaX(8), 1, 60) & "', '" 'col 60
                        strInsert = strInsert & Mid(LineaX(9), 1, 40) & "', '" 'delegacion 40
                        strInsert = strInsert & Mid(LineaX(10), 1, 40) & "', '" 'cuidad 40
                        strInsert = strInsert & SacaEstado(LineaX(11)) & "', '" 'estado 4
                        strInsert = strInsert & Stuff(Trim(LineaX(12)), "I", "0", 5) & "', '" 'cp
                        strInsert = strInsert & cTipop & "', '" 'tipcli
                        strInsert = strInsert & LineaX(14) 'numcli
                        strInsert = strInsert & "')"
                        If cnAgil.State <> ConnectionState.Open Then cnAgil.Open()
                        cm7 = New SqlCommand(strInsert, cnAgil)
                        cm7.ExecuteNonQuery()
                        cnAgil.Close()
                        cCliente = LineaX(14)
                        cAnexo = LineaX(15)

                    End If
                    LineaX(16) = Replace(LineaX(16), "ene", "jan", 1, 1, CompareMethod.Text)
                    LineaX(16) = Replace(LineaX(16), "ago", "aug", 1, 1, CompareMethod.Text)
                    LineaX(16) = Replace(LineaX(16), "dic", "dec", 1, 1, CompareMethod.Text)

                    fecha = LineaX(16)
                    nPlazo = LineaX(17)
                    If InStr(LineaX(19), "-") > 0 Then
                        LineaX(19) = "0"
                    End If
                    nMoi = Trim(LineaX(19))
                    nMoi = Round(nMoi, 0)
                    cFechaFin = ""
                    If UCase(Trim(LineaX(20))) = "PESOS" Then
                        cMoneda = "001"
                    ElseIf UCase(Trim(LineaX(20))) = "DÓLARES" Then
                        cMoneda = "005"
                    Else
                        cMoneda = "001"
                    End If
                    If InStr(LineaX(24), "-") > 0 Then
                        LineaX(24) = "0"
                    End If
                    nSaldoEquipo = Trim(LineaX(24))
                    nSaldoEquipo = Round(nSaldoEquipo, 0)
                    cTerConSaldo = "N"
                    cTipar = LineaX(26)
                    If cTipar.Length > 4 Then
                        cTipar = Mid(cTipar, 1, 4)
                    End If
                    If Val(LineaX(23)) > 999 Then LineaX(23) = 999

                    'nuevos datos version 04 #ECT20150121.n
                    nFrecuencia = 30
                    sUltPag = "00000000"
                    nMensualidad = nMoi
                    nMensualidad = Round(nMensualidad, 0)
                    'nuevos datos version 04 #ECT20150121.n

                    strInsert = "INSERT INTO MoraDeta(EMNumCli, CRContrato, CRApertura, CRPlazo, CRTipar, CRMoi, CRMoneda, CRFechaFin, DERetraso, DEImporte, TerConSaldo,CRFrecuencia,CRPago,CRUltimoPag,CRSaldoInsoluto)"
                    strInsert = strInsert & " VALUES ('"
                    strInsert = strInsert & cCliente & "', '"
                    strInsert = strInsert & cAnexo & "', '"
                    strInsert = strInsert & fecha.ToString("ddMMyyyy") & "', '"
                    strInsert = strInsert & Stuff(Trim(CStr(nPlazo)), "I", "0", 5) & "', '"
                    strInsert = strInsert & cTipar & "', '"
                    strInsert = strInsert & Stuff(Trim(CStr(nMoi)), "I", "0", 20) & "', '"
                    strInsert = strInsert & cMoneda & "', '"
                    strInsert = strInsert & Mid(cFechaFin, 7, 2) & Mid(cFechaFin, 5, 2) & Mid(cFechaFin, 1, 4) & "', '"
                    strInsert = strInsert & Stuff(Trim(CStr(Math.Abs(CInt(LineaX(23))))), "I", "0", 3) & "', '"
                    strInsert = strInsert & Stuff(Trim(CStr(nSaldoEquipo)), "I", "0", 20) & "', '"
                    strInsert = strInsert & cTerConSaldo & "', '"
                    strInsert = strInsert & Stuff(Trim(CStr(nFrecuencia)), "I", "0", 5) & "', '"
                    strInsert = strInsert & Stuff(Trim(CStr(nMensualidad)), "I", "0", 20) & "', '"
                    strInsert = strInsert & Stuff(Trim(CStr(sUltPag)), "I", "0", 8) & "', '"
                    strInsert = strInsert & Stuff(Trim(CStr(nSaldoEquipo)), "I", "0", 20)
                    strInsert = strInsert & "')"
                    If cnAgil.State <> ConnectionState.Open Then cnAgil.Open()
                    cm7 = New SqlCommand(strInsert, cnAgil)
                    cm7.ExecuteNonQuery()
                    cnAgil.Close()

                End While

            End If
        End If

        MsgBox("Proceso de carga Terminado", MsgBoxStyle.Information, "Mensaje del Sistema")
        cnAgil.Close()
        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
        cm4.Dispose()
        cm5.Dispose()
        cm6.Dispose()
        cm7.Dispose()

        'Catch eException As Exception

        '    MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        'End Try

    End Sub

    Private Sub btnGeneraM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraM.Click
        StrConnX = "Server=SERVER-RAID; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(StrConnX)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daMorales As New SqlDataAdapter(cm1)
        Dim daMoraDeta As New SqlDataAdapter(cm2)
        Dim drMoral As DataRow
        Dim drMoraDeta As DataRow
        Dim drDetalle() As DataRow
        Dim relMoralesMoraDeta As DataRelation

        ' Declaración de variables de datos

        Dim cCliente As String
        Dim cAnexo As String
        Dim cCiclo As String
        Dim cFecha As String
        Dim cFechaReporte As String
        Dim cRfc As String
        Dim cString As String
        Dim nEmpresas As Decimal
        Dim nSumatoria As Decimal
        Dim oReporte As StreamWriter
        Dim oMonitor1 As StreamWriter
        Dim oMonitor2 As StreamWriter
        Dim textAscii As New ASCIIEncoding()
        Dim encodedBytes As Byte()
        Dim decodedString As String
        Dim ta As New GeneralDSTableAdapters.MoraDetaTableAdapter
        ta.Connection.ConnectionString = StrConnX

        ta.BorraRechazadosOld()
        cFecha = DTOC(dtpProceso.Value)

        cFechaReporte = Mid(cFecha, 7, 2) & Mid(cFecha, 5, 2) & Mid(cFecha, 1, 4)

        ' Este Stored Procedure regresa todos los registros que aparecen en la tabla Morales

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Morales2"
            .Connection = cnAgil
        End With

        ' Este Stored Procedure regresa todos los registros que aparecen en la tabla MoraDeta

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneraM1"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daMorales.Fill(dsAgil, "Morales")
        daMoraDeta.Fill(dsAgil, "MoraDeta")

        ' Establecer la relación entre Anexos y Edoctav

        relMoralesMoraDeta = New DataRelation("MoralesMoraDeta", dsAgil.Tables("Morales").Columns("EMNumCli"), dsAgil.Tables("MoraDeta").Columns("EMNumCli"))

        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relMoralesMoraDeta)

        oReporte = New StreamWriter("c:\Files\MORALES.TXT", False, System.Text.Encoding.Default)

        cString = "HD" & "BNCPM"
        cString = cString & "00" & "3171"
        cString = cString & "01" & "0000"
        cString = cString & "02" & "002"
        cString = cString & "03" & "1"
        cString = cString & "04" & cFechaReporte
        cString = cString & "05" & Mid(cFechaReporte, 3, 6)
        cString = cString & "06" & Space(53)

        encodedBytes = textAscii.GetBytes(cString)
        decodedString = textAscii.GetString(encodedBytes)
        oReporte.Write(decodedString)

        nEmpresas = 0
        nSumatoria = 0
        Dim Contador As Integer = 0
        Dim Cad As String
        For Each drMoral In dsAgil.Tables("Morales").Rows


            ' SEGMENTO DE COMPAÑÍA

            cCliente = drMoral("EMNumCli")
            cRfc = drMoral("EMRfc")

            If ta.TieneDetalle(cCliente.Trim) <= 0 Then
                Continue For
            End If

            cString = "EM" & "EM"
            cString = cString & "00" & cRfc
            cString = cString & "01" & Space(18)
            cString = cString & "02" & Space(10)

            If drMoral("EMTipCli") = "1" Then
                cString = cString & "03" & drMoral("EMEmpresa")
                cString = cString & "04" & Space(75)
                cString = cString & "05" & Space(75)
                cString = cString & "06" & Space(25)
                cString = cString & "07" & Space(25)
            Else
                cString = cString & "03" & Space(75)
                cString = cString & "04" & drMoral("EMNombre")
                cString = cString & "05" & Space(75)
                cString = cString & "06" & drMoral("EMPaterno")
                cString = cString & "07" & drMoral("EMMaterno")
                If Trim(drMoral("EMMaterno")) = "MONTAÑO" Then
                    cString = cString
                End If
            End If
            cString = cString & "08" & Space(2) 'MX
            cString = cString & "09" & drMoral("EMCalifica")
            cString = cString & "10" & drMoral("EMActivida")
            cString = cString & "11" & Space(11)
            cString = cString & "12" & Space(11)
            cString = cString & "13" & drMoral("EMCalle")
            cString = cString & "14" & Space(40)
            cString = cString & "15" & drMoral("EMColonia")
            cString = cString & "16" & drMoral("EMDelega")
            cString = cString & "17" & drMoral("EMCiudad")
            cString = cString & "18" & drMoral("EMEstado")
            cString = cString & "19" & drMoral("EMCp")
            cString = cString & "20" & Space(11)
            cString = cString & "21" & Space(8)
            cString = cString & "22" & Space(11)
            cString = cString & "23" & drMoral("EMTipCli")
            cString = cString & "24" & Space(128)
            '''cString = cString & "25MX" ' version 4.0

            ' Esta instrucción trae exclusivamente los contratos del cliente que está siendo procesado

            drDetalle = drMoral.GetChildRows("MoralesMoraDeta")

            For Each drMoraDeta In drDetalle

                ' SEGMENTO DE CRÉDITO
                If Trim(drMoraDeta("CRContrato")) = "08999/0008" Then
                    Continue For
                End If

                cString = cString & "CR" & "CR"
                cString = cString & "00" & cRfc
                cString = cString & "01" & Space(6)
                cString = cString & "02" & drMoraDeta("CRContrato")
                cString = cString & "03" & Space(25)
                cString = cString & "04" & drMoraDeta("CRApertura")
                cString = cString & "05" & drMoraDeta("CRplazo")
                cString = cString & "06" & drMoraDeta("CRTipar")
                cString = cString & "07" & drMoraDeta("CRMoi")
                cString = cString & "08" & drMoraDeta("CRMoneda")
                cString = cString & "09" & Space(4)
                cString = cString & "10" & Space(3) ' version 4.0 cabia a 5 posiciones
                cString = cString & "11" & Space(20) ' version 4.0
                cString = cString & "12" & Space(8)
                cString = cString & "13" & Space(8)
                cString = cString & "14" & Space(20)
                cString = cString & "15" & drMoraDeta("CRFechaFin")
                cString = cString & "16" & Space(20)
                cString = cString & "17" & Space(20)
                cString = cString & "18" & Space(20)
                ClaveOBS = tb.ClaveOBS(Mid(Trim(drMoraDeta("CRContrato")), 1, 5) & Mid(Trim(drMoraDeta("CRContrato")), 7, 4))
                If Trim(ClaveOBS) <> "" Then
                    cString = cString & "19" & Trim(ClaveOBS) & Space(2)
                Else
                    cString = cString & "19" & Space(4)
                End If
                cString = cString & "20" & Space(110)

                ' SEGMENTO DETALLE DEL CRÉDITO

                cString = cString & "DE" & "DE"
                cString = cString & "00" & cRfc
                cString = cString & "01" & drMoraDeta("CRContrato")
                cString = cString & "02" & drMoraDeta("DERetraso")
                cString = cString & "03" & drMoraDeta("DEImporte")
                cString = cString & "04" & Space(75)
                nSumatoria = nSumatoria + Val(drMoraDeta("DEImporte"))

                'SEGMENTO AVALES+++++++++++++++++++++++++++++++++++++++
                If InStr(drMoraDeta("CRContrato"), "-") > 0 Then
                    cAnexo = Mid(drMoraDeta("CRContrato"), 1, 5) & Mid(drMoraDeta("CRContrato"), 7, 4)
                    cCiclo = Mid(drMoraDeta("CRContrato"), 12, 2)
                Else
                    cAnexo = Mid(drMoraDeta("CRContrato"), 1, 5) & Mid(drMoraDeta("CRContrato"), 7, 4)
                    cCiclo = "00"
                End If
                AgregaAvales(cAnexo, cCiclo, cString)
                'AVALES+++++++++++++++++++++++++++++++++++++++

            Next

            cString = cString.Replace("Á", "A")
            cString = cString.Replace("É", "E")
            cString = cString.Replace("Í", "I")
            cString = cString.Replace("Ó", "O")
            cString = cString.Replace("Ú", "U")

            encodedBytes = textAscii.GetBytes(cString)
            decodedString = textAscii.GetString(encodedBytes)
            decodedString = decodedString.Replace("?", "Ñ")
            oReporte.Write(decodedString)

            nEmpresas = nEmpresas + 1

        Next

        ' SEGMENTO DE CIERRE DE ARCHIVO

        cString = "TS" & "TS"
        cString = cString & "00" & Stuff(Trim(Str(nEmpresas)), "I", "0", 7)
        cString = cString & "01" & Stuff(Trim(Str(nSumatoria)), "I", "0", 30)
        cString = cString & "02" & Space(53)

        encodedBytes = textAscii.GetBytes(cString)
        decodedString = textAscii.GetString(encodedBytes)
        oReporte.Write(decodedString)


        ' reporte de monitor**************************************************
        Dim taF As New ProductionDataSetTableAdapters.Vw_BuroMonitorPFAETableAdapter
        Dim taM As New ProductionDataSetTableAdapters.Vw_BuroMonitorPMTableAdapter
        Dim tF As New ProductionDataSet.Vw_BuroMonitorPFAEDataTable
        Dim tM As New ProductionDataSet.Vw_BuroMonitorPMDataTable
        '''Fira
        Dim taFF As New ProductionDataSetTableAdapters.Vw_BuroMonitorPFAE_FiraTableAdapter
        Dim taMF As New ProductionDataSetTableAdapters.Vw_BuroMonitorPM_FiraTableAdapter
        Dim tFF As New ProductionDataSet.Vw_BuroMonitorPFAE_FiraDataTable
        Dim tMF As New ProductionDataSet.Vw_BuroMonitorPM_FiraDataTable
        Dim RFC As String = ""
        'taF.Fill(tF)
        'taM.Fill(tM)
        Contador += 1
        'oMonitor1 = New StreamWriter("c:\Files\MORALES-MonitorPM.TXT", False)
        'oMonitor2 = New StreamWriter("c:\Files\MORALES-MonitorPFAE.TXT", False)

        For Each rr As ProductionDataSet.Vw_BuroMonitorPFAERow In tF.Rows
            If Trim(RFC) <> Trim(rr.EMRfc) Then
                Cad = Contador & "|F|" & Trim(rr.EMRfc) & "|" & Trim(rr.EMNombre) & "|" & Trim(rr.EMNombre2) & "|" & Trim(rr.EMPaterno) & "|" _
                & Trim(rr.EMMaterno) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCp) & "|" & Trim(rr.EMColonia) & "|" _
                & Trim(rr.EMCiudad) & "|" & Trim(rr.EMEstado) & "|MX|" & Trim(rr.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                Cad = Cad.Replace(".", "")
                Cad = Cad.Replace("""", "")
                oMonitor2.WriteLine(Cad)
                Contador += 1
            End If
            RFC = Trim(rr.EMRfc)
        Next
        For Each r As ProductionDataSet.Vw_BuroMonitorPMRow In tM.Rows
            If Trim(RFC) <> Trim(r.EMRfc) Then
                Cad = Contador & "|M|" & Trim(r.EMRfc) & "|" & Trim(r.EMEmpresa) & "|" & Trim(r.EMCalle1) & "|" & Trim(r.EMCalle2) & "|" & Trim(r.EMCp) _
                & "|" & Trim(r.EMColonia) & "|" & Trim(r.EMCiudad) & "|" & Trim(r.EMEstado) & "|MX|" & Trim(r.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                oMonitor1.WriteLine(Cad)
                Contador += 1
            End If
            RFC = Trim(r.EMRfc)
        Next
        'oMonitor1.Close()
        'oMonitor2.Close()
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'taFF.Fill(tFF)
        'taMF.Fill(tMF)
        Contador = 1
        'oMonitor1 = New StreamWriter("c:\Files\MORALES-MonitorPM_Fira.TXT", False)
        'oMonitor2 = New StreamWriter("c:\Files\MORALES-MonitorPFAE_Fira.TXT", False)

        For Each rr As ProductionDataSet.Vw_BuroMonitorPFAE_FiraRow In tFF.Rows
            If Trim(RFC) <> Trim(rr.EMRfc) Then
                Cad = Contador & "|F|" & Trim(rr.EMRfc) & "|" & Trim(rr.EMNombre) & "|" & Trim(rr.EMNombre2) & "|" & Trim(rr.EMPaterno) & "|" _
                & Trim(rr.EMMaterno) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCp) & "|" & Trim(rr.EMColonia) & "|" _
                & Trim(rr.EMCiudad) & "|" & Trim(rr.EMEstado) & "|MX|" & Trim(rr.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                Cad = Cad.Replace(".", "")
                Cad = Cad.Replace("""", "")
                oMonitor2.WriteLine(Cad)
                Contador += 1
            End If
            RFC = Trim(rr.EMRfc)
        Next
        For Each r As ProductionDataSet.Vw_BuroMonitorPM_FiraRow In tMF.Rows
            If Trim(RFC) <> Trim(r.EMRfc) Then
                Cad = Contador & "|M|" & Trim(r.EMRfc) & "|" & Trim(r.EMEmpresa) & "|" & Trim(r.EMCalle1) & "|" & Trim(r.EMCalle2) & "|" & Trim(r.EMCp) _
                & "|" & Trim(r.EMColonia) & "|" & Trim(r.EMCiudad) & "|" & Trim(r.EMEstado) & "|MX|" & Trim(r.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                oMonitor1.WriteLine(Cad)
                Contador += 1
            End If
            RFC = Trim(r.EMRfc)
        Next
        'oMonitor1.Close()
        'oMonitor2.Close()
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        taF.FillNoHits(tF)
        taM.FillNoHits(tM)
        Contador = 0
        oMonitor1 = New StreamWriter("c:\Files\MORALES-MonitorPM-NoHits.TXT", False)
        oMonitor2 = New StreamWriter("c:\Files\MORALES-MonitorPFAE-NoHits.TXT", False)

        For Each rr As ProductionDataSet.Vw_BuroMonitorPFAERow In tF.Rows
            If Trim(RFC) <> Trim(rr.EMRfc) Then
                Cad = Contador & "|F|" & Trim(rr.EMRfc) & "|" & Trim(rr.EMNombre) & "|" & Trim(rr.EMNombre2) & "|" & Trim(rr.EMPaterno) & "|" _
                & Trim(rr.EMMaterno) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCp) & "|" & Trim(rr.EMColonia) & "|" _
                & Trim(rr.EMCiudad) & "|" & Trim(rr.EMEstado) & "|MX|" & Trim(rr.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                Cad = Cad.Replace(".", "")
                Cad = Cad.Replace("""", "")
                oMonitor2.WriteLine(Cad)
                Contador += 1
            End If
            RFC = Trim(rr.EMRfc)
        Next
        For Each r As ProductionDataSet.Vw_BuroMonitorPMRow In tM.Rows
            If Trim(RFC) <> Trim(r.EMRfc) Then
                Cad = Contador & "|M|" & Trim(r.EMRfc) & "|" & Trim(r.EMEmpresa) & "|" & Trim(r.EMCalle1) & "|" & Trim(r.EMCalle2) & "|" & Trim(r.EMCp) _
                & "|" & Trim(r.EMColonia) & "|" & Trim(r.EMCiudad) & "|" & Trim(r.EMEstado) & "|MX|" & Trim(r.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                oMonitor1.WriteLine(Cad)
                Contador += 1
            End If
            RFC = Trim(r.EMRfc)
        Next
        oMonitor1.Close()
        oMonitor2.Close()
        'Call TodoMonitor()
        ' reporte de monitor**************************************************

        oReporte.WriteLine()
        oReporte.Close()

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()

        'MsgBox("Recuerda cambiar ? por Ñ", MsgBoxStyle.Information, "Mensaje del Sistema")
        MsgBox("Terminado", MsgBoxStyle.Information, "Mensaje del Sistema")

    End Sub

    Function SacaEstado(ByVal estado As String) As String
        Dim cnAgil As New SqlConnection(strConn)
        Dim cmd As New SqlCommand()
        Dim resp As String
        If cnAgil.State <> ConnectionState.Open Then cnAgil.Open()
        If estado = "GUADALAJARA" Then estado = "JALISCO"
        cmd = New SqlCommand("select max(Abreviado) from plazas where descplaza = '" & Trim(estado) & "'", cnAgil)
        resp = cmd.ExecuteScalar()
        cnAgil.Close()
        cnAgil.Dispose()
        cmd.Dispose()
        Return resp
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Declaración de variables de conexión ADO .NET
        StrConnX = "Server=SERVER-RAID; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        Dim cnAgil As New SqlConnection(StrConnX)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daMorales As New SqlDataAdapter(cm1)
        Dim daMoraDeta As New SqlDataAdapter(cm2)
        Dim drMoral As DataRow
        Dim drMoraDeta As DataRow
        Dim drDetalle() As DataRow
        Dim relMoralesMoraDeta As DataRelation

        ' Declaración de variables de datos
        Dim cCliente As String
        Dim cFecha As String
        Dim cFechaReporte As String
        Dim cRfc As String
        Dim cString As String
        Dim nEmpresas As Decimal
        Dim nSumatoria As Decimal
        Dim oReporte As StreamWriter
        Dim oMonitor1 As StreamWriter
        Dim oMonitor2 As StreamWriter
        Dim textAscii As New ASCIIEncoding()
        Dim encodedBytes As Byte()
        Dim decodedString As String
        Dim ta As New GeneralDSTableAdapters.MoraDetaTableAdapter
        ta.Connection.ConnectionString = StrConnX

        cFecha = DTOC(dtpProceso.Value)

        cFechaReporte = Mid(cFecha, 7, 2) & Mid(cFecha, 5, 2) & Mid(cFecha, 1, 4)

        ' Este Stored Procedure regresa todos los registros que aparecen en la tabla Morales

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Morales2"
            .Connection = cnAgil
        End With

        ' Este Stored Procedure regresa todos los registros que aparecen en la tabla MoraDeta

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneraM1"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daMorales.Fill(dsAgil, "Morales")
        daMoraDeta.Fill(dsAgil, "MoraDeta")

        ' Establecer la relación entre Anexos y Edoctav

        relMoralesMoraDeta = New DataRelation("MoralesMoraDeta", dsAgil.Tables("Morales").Columns("EMNumCli"), dsAgil.Tables("MoraDeta").Columns("EMNumCli"))

        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relMoralesMoraDeta)

        oReporte = New StreamWriter("c:\Files\MORALES.TXT", False, System.Text.Encoding.Default)

        cString = "HD" & "BNCPM"
        cString = cString & "00" & "3171"
        cString = cString & "01" & "0000"
        cString = cString & "02" & "002"
        cString = cString & "03" & "1"
        cString = cString & "04" & cFechaReporte
        cString = cString & "05" & Mid(cFechaReporte, 3, 6)
        cString = cString & "06" & "04"
        cString = cString & "07" & "ARRENDADORA AGIL SA DE CV" & Space(50)
        cString = cString & "08" & Space(52)

        encodedBytes = textAscii.GetBytes(cString)
        decodedString = textAscii.GetString(encodedBytes)
        oReporte.Write(decodedString)

        nEmpresas = 0
        nSumatoria = 0
        Dim Contador As Integer = 0
        Dim Cad As String
        For Each drMoral In dsAgil.Tables("Morales").Rows

            cCliente = drMoral("EMNumCli")
            cRfc = drMoral("EMRfc")

            If ta.TieneDetalle(cCliente) <= 0 Then
                Continue For
            End If


            cString = "EM" & "EM"
            cString = cString & "00" & cRfc
            cString = cString & "01" & Space(18) ' AQUI SE PUEDE REPORTAR EL CURP
            cString = cString & "02" & Space(10)

            If drMoral("EMTipCli") = "1" Then
                cString = cString & "03" & drMoral("EMEmpresa") & Space(75) ' CAMBIO A 150 CARACTERES
                cString = cString & "04" & Space(30)
                cString = cString & "05" & Space(30)
                cString = cString & "06" & Space(25)
                cString = cString & "07" & Space(25)
            Else
                cString = cString & "03" & Space(150)
                cString = cString & "04" & PrimerNombre(drMoral("EMNombre"))
                cString = cString & "05" & SegundoNombre(drMoral("EMNombre"))
                cString = cString & "06" & drMoral("EMPaterno")
                cString = cString & "07" & drMoral("EMMaterno")
                If Trim(drMoral("EMMaterno")) = "MONTAÑO" Then
                    cString = cString
                End If
            End If
            cString = cString & "08" & "MX"
            cString = cString & "09" & drMoral("EMCalifica")
            cString = cString & "10" & "00009999999"
            cString = cString & "11" & "00000000000"
            cString = cString & "12" & "00000000000"
            cString = cString & "13" & drMoral("EMCalle")
            cString = cString & "14" & Space(40)
            cString = cString & "15" & drMoral("EMColonia")
            cString = cString & "16" & drMoral("EMDelega")
            cString = cString & "17" & drMoral("EMCiudad")
            cString = cString & "18" & drMoral("EMEstado")
            cString = cString & "19" & drMoral("EMCp")
            cString = cString & "20" & Space(11)
            cString = cString & "21" & Space(8)
            cString = cString & "22" & Space(11)
            cString = cString & "23" & drMoral("EMTipCli")
            cString = cString & "24" & Space(40)
            cString = cString & "25" & "MX"
            cString = cString & "26" & Space(8)
            cString = cString & "27" & Space(87)

            ' Esta instrucción trae exclusivamente los contratos del cliente que está siendo procesado

            drDetalle = drMoral.GetChildRows("MoralesMoraDeta")

            For Each drMoraDeta In drDetalle

                ' SEGMENTO DE CRÉDITO
                cString = cString & "CR" & "CR"
                cString = cString & "00" & cRfc
                cString = cString & "01" & Space(6)
                cString = cString & "02" & drMoraDeta("CRContrato")
                cString = cString & "03" & Space(25)
                cString = cString & "04" & drMoraDeta("CRApertura")
                cString = cString & "05" & drMoraDeta("CRplazo")
                cString = cString & "06" & drMoraDeta("CRTipar")
                cString = cString & "07" & drMoraDeta("CRMoi")
                cString = cString & "08" & drMoraDeta("CRMoneda")
                cString = cString & "09" & Space(4)
                cString = cString & "10" & drMoraDeta("CRFrecuencia")
                cString = cString & "11" & drMoraDeta("CRPago")
                cString = cString & "12" & drMoraDeta("CRUltimoPag")
                cString = cString & "13" & Space(8)
                cString = cString & "14" & Space(20)
                cString = cString & "15" & drMoraDeta("CRFechaFin")
                cString = cString & "16" & Space(20)
                cString = cString & "17" & Space(20)
                cString = cString & "18" & Space(20)

                ClaveOBS = tb.ClaveOBS(Mid(Trim(drMoraDeta("CRContrato")), 1, 5) & Mid(Trim(drMoraDeta("CRContrato")), 7, 4))
                If Trim(ClaveOBS) <> "" Then
                    cString = cString & "19" & Trim(ClaveOBS) & Space(2)
                Else
                    cString = cString & "19" & Space(4)
                End If
                cString = cString & "20" & Space(1)
                cString = cString & "21" & "00000000"
                cString = cString & "22" & drMoraDeta("CRSaldoInsoluto")
                cString = cString & "23" & Space(20)
                cString = cString & "24" & Space(51)



                ' SEGMENTO DETALLE DEL CRÉDITO

                cString = cString & "DE" & "DE"
                cString = cString & "00" & cRfc
                cString = cString & "01" & drMoraDeta("CRContrato")
                cString = cString & "02" & drMoraDeta("DERetraso")
                cString = cString & "03" & drMoraDeta("DEImporte")
                cString = cString & "04" & Space(75)

                nSumatoria = nSumatoria + Val(drMoraDeta("DEImporte"))

            Next
            cString = cString.Replace("Á", "A")
            cString = cString.Replace("É", "E")
            cString = cString.Replace("Í", "I")
            cString = cString.Replace("Ó", "O")
            cString = cString.Replace("Ú", "U")

            encodedBytes = textAscii.GetBytes(cString)
            decodedString = textAscii.GetString(encodedBytes)
            decodedString = decodedString.Replace("?", "Ñ")
            oReporte.Write(decodedString)

            nEmpresas = nEmpresas + 1

        Next

        ' SEGMENTO DE CIERRE DE ARCHIVO

        cString = "TS" & "TS"
        cString = cString & "00" & Stuff(Trim(Str(nEmpresas)), "I", "0", 7)
        cString = cString & "01" & Stuff(Trim(Str(nSumatoria)), "I", "0", 30)
        cString = cString & "02" & Space(53)

        encodedBytes = textAscii.GetBytes(cString)
        decodedString = textAscii.GetString(encodedBytes)
        oReporte.Write(decodedString)


        ' reporte de monitor**************************************************
        Dim taF As New ProductionDataSetTableAdapters.Vw_BuroMonitorPFAETableAdapter
        Dim taM As New ProductionDataSetTableAdapters.Vw_BuroMonitorPMTableAdapter
        Dim tF As New ProductionDataSet.Vw_BuroMonitorPFAEDataTable
        Dim tM As New ProductionDataSet.Vw_BuroMonitorPMDataTable
        Dim RFC As String = ""
        taF.Fill(tF)
        taM.Fill(tM)
        Contador += 1
        oMonitor1 = New StreamWriter("c:\Files\MORALES-MonitorPM.TXT", False)
        oMonitor2 = New StreamWriter("c:\Files\MORALES-MonitorPFAE.TXT", False)

        For Each rr As ProductionDataSet.Vw_BuroMonitorPFAERow In tF.Rows
            If Trim(RFC) <> Trim(rr.EMRfc) Then
                Cad = Contador & "|F|" & Trim(rr.EMRfc) & "|" & Trim(rr.EMNombre) & "|" & Trim(rr.EMNombre2) & "|" & Trim(rr.EMPaterno) & "|" _
                & Trim(rr.EMMaterno) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCp) & "|" & Trim(rr.EMColonia) & "|" _
                & Trim(rr.EMCiudad) & "|" & Trim(rr.EMEstado) & "|MX|" & Trim(rr.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                Cad = Cad.Replace(".", "")
                Cad = Cad.Replace("""", "")
                oMonitor2.WriteLine(Cad)
                Contador += 1
            End If
            RFC = Trim(rr.EMRfc)
        Next
        For Each r As ProductionDataSet.Vw_BuroMonitorPMRow In tM.Rows
            If Trim(RFC) <> Trim(r.EMRfc) Then
                Cad = Contador & "|M|" & Trim(r.EMRfc) & "|" & Trim(r.EMEmpresa) & "|" & Trim(r.EMCalle1) & "|" & Trim(r.EMCalle2) & "|" & Trim(r.EMCp) _
                & "|" & Trim(r.EMColonia) & "|" & Trim(r.EMCiudad) & "|" & Trim(r.EMEstado) & "|MX|" & Trim(r.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                oMonitor1.WriteLine(Cad)
                Contador += 1
            End If
            RFC = Trim(r.EMRfc)
        Next
        oMonitor1.Close()
        oMonitor2.Close()
        taF.FillNoHits(tF)
        taM.FillNoHits(tM)
        Contador = 0
        oMonitor1 = New StreamWriter("c:\Files\MORALES-MonitorPM-NoHits.TXT", False)
        oMonitor2 = New StreamWriter("c:\Files\MORALES-MonitorPFAE-NoHits.TXT", False)

        For Each rr As ProductionDataSet.Vw_BuroMonitorPFAERow In tF.Rows
            If Trim(RFC) <> Trim(rr.EMRfc) Then
                Cad = Contador & "|F|" & Trim(rr.EMRfc) & "|" & Trim(rr.EMNombre) & "|" & Trim(rr.EMNombre2) & "|" & Trim(rr.EMPaterno) & "|" _
                & Trim(rr.EMMaterno) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCp) & "|" & Trim(rr.EMColonia) & "|" _
                & Trim(rr.EMCiudad) & "|" & Trim(rr.EMEstado) & "|MX|" & Trim(rr.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                Cad = Cad.Replace(".", "")
                Cad = Cad.Replace("""", "")
                oMonitor2.WriteLine(Cad)
                Contador += 1
            End If
            RFC = Trim(rr.EMRfc)
        Next
        For Each r As ProductionDataSet.Vw_BuroMonitorPMRow In tM.Rows
            If Trim(RFC) <> Trim(r.EMRfc) Then
                Cad = Contador & "|M|" & Trim(r.EMRfc) & "|" & Trim(r.EMEmpresa) & "|" & Trim(r.EMCalle1) & "|" & Trim(r.EMCalle2) & "|" & Trim(r.EMCp) _
                & "|" & Trim(r.EMColonia) & "|" & Trim(r.EMCiudad) & "|" & Trim(r.EMEstado) & "|MX|" & Trim(r.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                oMonitor1.WriteLine(Cad)
                Contador += 1
            End If
            RFC = Trim(r.EMRfc)
        Next
        oMonitor1.Close()
        oMonitor2.Close()
        ' reporte de monitor**************************************************

        oReporte.WriteLine()
        oReporte.Close()

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()

        'MsgBox("Recuerda cambiar ? por Ñ", MsgBoxStyle.Information, "Mensaje del Sistema")
        MsgBox("Terminado", MsgBoxStyle.Information, "Mensaje del Sistema")
    End Sub

    Function PrimerNombre(ByVal Nom) As String
        Dim espacio As Integer = InStr(Nom, " ")
        PrimerNombre = Trim(Mid(Nom, 1, espacio))
        If PrimerNombre.Length > 30 Then
            PrimerNombre = Mid(PrimerNombre, 1, 30)
        Else
            PrimerNombre = PrimerNombre & Space(30 - PrimerNombre.Length)
        End If
        Return PrimerNombre
    End Function

    Function SegundoNombre(ByVal Nom As String) As String
        Dim espacio As Integer = InStr(Nom, " ")
        SegundoNombre = Trim(Mid(Nom, espacio, Nom.Length))
        If SegundoNombre.Length > 30 Then
            SegundoNombre = Mid(SegundoNombre, 1, 30)
        Else
            SegundoNombre = SegundoNombre & Space(30 - SegundoNombre.Length)
        End If
        Return SegundoNombre
    End Function

    Sub TodoMonitor()
        ' reporte de monitor**************************************************
        Dim oMonitor1 As StreamWriter
        Dim oMonitor2 As StreamWriter
        Dim oMonitor3 As StreamWriter
        Dim contador As Integer = 0
        Dim Cad As String
        Dim taF As New ProductionDataSetTableAdapters.Vw_BuroMonitor_TODOS_PFAETableAdapter
        Dim taM As New ProductionDataSetTableAdapters.Vw_BuroMonitor_TODOS_MTableAdapter
        Dim tF As New ProductionDataSet.Vw_BuroMonitor_TODOS_PFAEDataTable
        Dim tM As New ProductionDataSet.Vw_BuroMonitor_TODOS_MDataTable
        Dim taFF As New ProductionDataSetTableAdapters.Vw_BuroMonitorFactorajeTableAdapter
        Dim tFF As New ProductionDataSet.Vw_BuroMonitorFactorajeDataTable
        Dim RFC As String = ""
        taF.Fill(tF)
        taM.Fill(tM)
        taFF.Fill(tFF)

        contador = 1
        oMonitor1 = New StreamWriter("c:\Files\MORALES-MonitorPM.TXT", False)
        oMonitor2 = New StreamWriter("c:\Files\MORALES-MonitorPFAE.TXT", False)
        oMonitor3 = New StreamWriter("c:\Files\MORALES-MonitorPM-Factor.TXT", False)

        For Each rr As ProductionDataSet.Vw_BuroMonitor_TODOS_PFAERow In tF.Rows
            If Trim(RFC) <> Trim(rr.EMRfc) Then
                Cad = contador & "|F|" & Trim(rr.EMRfc) & "|" & Trim(rr.EMNombre) & "|" & Trim(rr.EMNombre2) & "|" & Trim(rr.EMPaterno) & "|" _
                & Trim(rr.EMMaterno) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCp) & "|" & Trim(rr.EMColonia) & "|" _
                & Trim(rr.EMCiudad) & "|" & Trim(rr.EMEstado) & "|MX|" & Trim(rr.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                Cad = Cad.Replace(".", "")
                Cad = Cad.Replace("""", "")
                oMonitor2.WriteLine(Cad)
                contador += 1
            End If
            RFC = Trim(rr.EMRfc)
        Next
        contador = 1
        For Each r As ProductionDataSet.Vw_BuroMonitor_TODOS_MRow In tM.Rows
            If Trim(RFC) <> Trim(r.EMRfc) Then
                Cad = contador & "|M|" & Trim(r.EMRfc) & "|" & Trim(r.EMEmpresa) & "|" & Trim(r.EMCalle1) & "|" & Trim(r.EMCalle2) & "|" & Trim(r.EMCp) _
                & "|" & Trim(r.EMColonia) & "|" & Trim(r.EMCiudad) & "|" & Trim(r.EMEstado) & "|MX|" & Trim(r.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                oMonitor1.WriteLine(Cad)
                contador += 1
            End If
            RFC = Trim(r.EMRfc)
        Next
        contador = 1
        For Each r As ProductionDataSet.Vw_BuroMonitorFactorajeRow In tFF.Rows
            If Trim(RFC) <> Trim(r.EMRfc) Then
                Cad = contador & "|M|" & Trim(r.EMRfc) & "|" & Trim(r.EMEmpresa) & "|" & Trim(r.EMCalle1) & "|" & Trim(r.EMCalle2) & "|" & Trim(r.EMCp) _
                & "|" & Trim(r.EMColonia) & "|" & Trim(r.EMCiudad) & "|" & Trim(r.EMEstado) & "|MX|" & Trim(r.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                oMonitor3.WriteLine(Cad)
                contador += 1
            End If
            RFC = Trim(r.EMRfc)
        Next
        oMonitor1.Close()
        oMonitor2.Close()
        oMonitor3.Close()
        ' reporte de monitor**************************************************

    End Sub

    Sub TodoMonitorII()
        ' reporte de monitor**************************************************
        Dim oMonitor1 As StreamWriter
        Dim oMonitor2 As StreamWriter
        Dim contador As Integer = 0
        Dim Cad As String
        Dim taF As New ProductionDataSetTableAdapters.Vw_BuroMonitorPFAE_Fira_PITableAdapter
        Dim taM As New ProductionDataSetTableAdapters.Vw_BuroMonitorPM_Fira_PITableAdapter
        Dim tF As New ProductionDataSet.Vw_BuroMonitorPFAE_Fira_PIDataTable
        Dim tM As New ProductionDataSet.Vw_BuroMonitorPM_Fira_PIDataTable
        Dim RFC As String = ""
        taF.Fill(tF)
        taM.Fill(tM)
        Dim messs As String = dtpProceso.Value.ToString("MMM").Substring(0, 3) & " " & dtpProceso.Value.ToString("yyyy")
        contador = 1
        oMonitor1 = New StreamWriter("c:\Files\MORALES-Monitor_FIRA_PM_" & messs & ".TXT", False)
        oMonitor2 = New StreamWriter("c:\Files\MORALES-Monitor_FIRA_PFAE_" & messs & ".TXT", False)


        For Each rr As ProductionDataSet.Vw_BuroMonitorPFAE_Fira_PIRow In tF.Rows
            If Trim(RFC) <> Trim(rr.EMRfc) Then
                Cad = contador & "|F|" & Trim(rr.EMRfc) & "|" & Trim(rr.EMNombre) & "|" & Trim(rr.EMNombre2) & "|" & Trim(rr.EMPaterno) & "|" _
                & Trim(rr.EMMaterno) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCalle1) & "|" & Trim(rr.EMCp) & "|" & Trim(rr.EMColonia) & "|" _
                & Trim(rr.EMCiudad) & "|" & Trim(rr.EMEstado) & "|MX|" & Trim(rr.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                Cad = Cad.Replace(".", "")
                Cad = Cad.Replace("""", "")
                oMonitor2.WriteLine(Cad)
                contador += 1
            End If
            RFC = Trim(rr.EMRfc)
        Next
        contador = 1
        For Each r As ProductionDataSet.Vw_BuroMonitorPM_Fira_PIRow In tM.Rows
            If Trim(RFC) <> Trim(r.EMRfc) Then
                Cad = contador & "|M|" & Trim(r.EMRfc) & "|" & Trim(r.EMEmpresa) & "|" & Trim(r.EMCalle1) & "|" & Trim(r.EMCalle2) & "|" & Trim(r.EMCp) _
                & "|" & Trim(r.EMColonia) & "|" & Trim(r.EMCiudad) & "|" & Trim(r.EMEstado) & "|MX|" & Trim(r.CRContrato)
                Cad = Cad.Replace("Á", "A")
                Cad = Cad.Replace("É", "E")
                Cad = Cad.Replace("Í", "I")
                Cad = Cad.Replace("Ó", "O")
                Cad = Cad.Replace("Ú", "U")
                Cad = Cad.Replace("?", "A")
                Cad = Cad.Replace("Ñ", "N")
                Cad = Cad.Replace("´", " ")
                Cad = Cad.Replace("(", "")
                Cad = Cad.Replace(")", "")
                oMonitor1.WriteLine(Cad)
                contador += 1
            End If
            RFC = Trim(r.EMRfc)
        Next
        oMonitor1.Close()
        oMonitor2.Close()
        ' reporte de monitor**************************************************

    End Sub

    Private Sub btnLoteFIRA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoteFIRA.Click
        StrConnX = "Server=SERVER-RAID; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        ' Declaración de variables de conexión ADO .NET
        Dim ExtQuery As String
        ''If MessageBox.Show("¿ya validaste la vista Vw_FIRA_Valida_Acreditados para coincidencia de nombres?", "Vista", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
        ''Exit Sub
        ''End If
        If MessageBox.Show("¿ya validaste la tabla Llaves (MesCalFira 1 y 2)?", "Vista", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Dim tx As New BuroDSTableAdapters.LlavesTableAdapter
            Dim A As String = InputBox("MesCal1", "mes 1")
            Dim B As String = InputBox("MesCal2", "mes 2")
            tx.CambiaMesCalFira12(A, B)
        End If
        If MessageBox.Show("¿solo complemento?", "Generacion de Lote", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            'ExtQuery = "select cliente from Vw_FIRA_Valida_Acreditados where RFC_buro is null "
            ExtQuery = "SELECT * FROM Vw_FIRA_BC_FINAGIL where nombre1 is null"
        Else
            If MessageBox.Show("¿Toda la cartera?", "Generacion de Lote", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim messs As String = dtpProceso.Value.ToString("MMM").Substring(0, 3) & " " & dtpProceso.Value.ToString("yyyy")
                'ExtQuery = "select cliente from Vw_FIRA_Valida_AcreditadosALL where mes = '" & messs & "' "
                ExtQuery = "SELECT * FROM Vw_FIRA_BC_FINAGIL"
            Else
                'ExtQuery = "select cliente from Vw_FIRA_Valida_Acreditados"
                ExtQuery = "SELECT * FROM Vw_FIRA_BC_FINAGIL where nombre1 is null"
            End If
        End If
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm7 As SqlCommand
        Dim dsAgil As New DataSet()
        Dim daMorales As New SqlDataAdapter(cm1)
        Dim daClientes As SqlDataAdapter
        Dim Mess As String
        Dim drMoral As DataRow
        Dim drCliente As DataRow
        Dim strDelete As String
        Dim strInsert As String

        ' Declaración de variables de datos

        Dim cCalle As String
        Dim cCiudad As String
        Dim cCliente As String
        Dim cColonia As String
        Dim cCP As String
        Dim cCusnam As String
        Dim cDelega As String
        Dim cEmpresa As String
        Dim cEstado As String
        Dim cFecha As String
        Dim cFechaF As String
        Dim cFechaAnt As String
        Dim cMaterno As String
        Dim cNombre As String
        Dim cPaterno As String
        Dim cRFC As String
        Dim cTipo As String

        Dim i As Integer
        Dim nCarteraEquipo As Decimal = 0
        Dim nCarteraSeguro As Decimal = 0
        Dim nCarteraOtros As Decimal = 0
        Dim nEspacios As Byte
        Dim nInteresEquipo As Decimal = 0
        Dim nInteresSeguro As Decimal = 0
        Dim nInteresOtros As Decimal = 0
        Dim nSaldoEquipo As Decimal = 0
        Dim nSaldoSeguro As Decimal = 0
        Dim nSaldoOtros As Decimal = 0
        Dim ta As New ProductionDataSetTableAdapters.AnexosTableAdapter
        ta.Connection.ConnectionString = StrConnX
        Dim newfrmPideNombre As frmPideNombre

        cFecha = DTOC(dtpProceso.Value)
        Mess = dtpProceso.Value.ToString("MMM yyyy")
        cFechaF = dtpProceso.Value.ToString("yyyy-MM-dd")
        cFechaAnt = DTOC(dtpProceso.Value.AddDays(dtpProceso.Value.Day * -1))

        ' Este Stored Procedure regresa todos los clientes que sean persona moral o
        ' persona física con actividad empresarial y que tengan por lo menos
        ' un contrato con alguna de las siguientes características:
        With cm1
            .CommandType = CommandType.Text
            .CommandText = ExtQuery
            .Connection = cnAgil
        End With

        ' Primero elimino todos los registros de la tabla Morales menos factoraje

        cnAgil.Open()
        strDelete = "DELETE FROM Morales WHERE (LEFT(Emnumcli, 1) <> '1')"
        strDelete = "DELETE FROM Morales"

        cm7 = New SqlClient.SqlCommand(strDelete, cnAgil)
        cm7.ExecuteNonQuery()
        cnAgil.Close()

        ' A continuación elimino todos los registros de la tabla MoraDeta

        cnAgil.Open()
        strDelete = "DELETE FROM MoraDeta"
        cm7 = New SqlClient.SqlCommand(strDelete, cnAgil)
        cm7.ExecuteNonQuery()
        cnAgil.Close()

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daMorales.Fill(dsAgil, "Morales")

        For Each drMoral In dsAgil.Tables("Morales").Rows

            cCliente = drMoral("Cliente")
            If cCliente = "05852" Then
                'Continue For
            End If

            ' El siguiente Stored Procedure trae todos los atributos de la tabla Clientes,
            ' para un cliente dado.

            cm7 = New SqlCommand()
            With cm7
                .CommandType = CommandType.StoredProcedure
                .CommandText = "DatosClie1"
                .Connection = cnAgil
                .Parameters.Add("@Cliente", SqlDbType.NVarChar)
                .Parameters(0).Value = cCliente
            End With
            daClientes = New SqlDataAdapter(cm7)
            daClientes.Fill(dsAgil, "Clientes")

            drCliente = dsAgil.Tables("Clientes").Rows(0)

            cEmpresa = Space(75)
            cNombre = Space(75)
            cPaterno = Space(25)
            cMaterno = Space(25)
            nEspacios = 0

            cCusnam = Trim(drCliente("Descr"))
            cRFC = drCliente("Rfc")
            cTipo = drCliente("Tipo")
            cCalle = Mid(drCliente("Calle"), 1, 40)
            cColonia = drCliente("Colonia")
            cDelega = Mid(drCliente("Delegacion"), 1, 40)
            cCiudad = drCliente("DescPlaza")

            cEstado = drCliente("Abreviado")
            cCP = drCliente("Copos")

            If cTipo = "M" Then
                cEmpresa = Mid(cCusnam, 1, 75)
            Else
                For i = 1 To Len(cCusnam)
                    If Mid(cCusnam, i, 1) = " " Then
                        nEspacios += 1
                    End If
                Next

                If nEspacios = 2 Then
                    cNombre = ""
                    i = 1
                    While Mid(cCusnam, i, 1) <> " "
                        cNombre += Mid(cCusnam, i, 1)
                        i += 1
                    End While
                    i += 1

                    cPaterno = ""
                    While Mid(cCusnam, i, 1) <> " "
                        cPaterno += Mid(cCusnam, i, 1)
                        i += 1
                    End While
                    i += 1

                    cMaterno = ""
                    While i <= Len(cCusnam)
                        cMaterno += Mid(cCusnam, i, 1)
                        i += 1
                    End While

                End If

                If nEspacios = 1 Or nEspacios > 3 Then
                    newfrmPideNombre = New frmPideNombre("M", cCusnam, cCliente)
                    newfrmPideNombre.ShowDialog()
                    cNombre = newfrmPideNombre.Nombre
                    cPaterno = newfrmPideNombre.Paterno
                    cMaterno = newfrmPideNombre.Materno
                End If

                If nEspacios = 3 Then

                    cNombre = ""
                    i = 1
                    While Mid(cCusnam, i, 1) <> " "
                        cNombre += Mid(cCusnam, i, 1)
                        i += 1
                    End While
                    i += 1
                    cNombre += " "

                    While Mid(cCusnam, i, 1) <> " "
                        cNombre += Mid(cCusnam, i, 1)
                        i += 1
                    End While
                    i += 1

                    cPaterno = ""
                    While Mid(cCusnam, i, 1) <> " "
                        cPaterno += Mid(cCusnam, i, 1)
                        i += 1
                    End While
                    i += 1

                    cMaterno = ""
                    While i <= Len(cCusnam)
                        cMaterno += Mid(cCusnam, i, 1)
                        i += 1
                    End While

                    If Len(cPaterno) < 4 Then
                        nEspacios = 2
                    End If

                End If

            End If

            If cTipo = "M" Then
                cTipo = "1"
            ElseIf cTipo = "E" Or cTipo = "F" Then
                cTipo = "2"
            End If

            strInsert = "INSERT INTO Morales(EMRfc, EMEmpresa, EMNombre, EMPaterno, EMMaterno, EMCalifica, EMActivida, EMCalle, EMColonia, EMDelega, EMCiudad, EMEstado, EMCp, EMTipCli, EMNumCli)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & cRFC & "', '"
            strInsert = strInsert & cEmpresa & "', '"
            strInsert = strInsert & cNombre & "', '"
            strInsert = strInsert & cPaterno & "', '"
            strInsert = strInsert & cMaterno & "', '"
            strInsert = strInsert & Space(2) & "', '"
            strInsert = strInsert & "99999999999" & "', '"
            strInsert = strInsert & cCalle & "', '"
            strInsert = strInsert & cColonia & "', '"
            strInsert = strInsert & cDelega & "', '"
            strInsert = strInsert & cCiudad & "', '"
            strInsert = strInsert & cEstado & "', '"
            strInsert = strInsert & cCP & "', '"
            strInsert = strInsert & cTipo & "', '"
            strInsert = strInsert & cCliente
            strInsert = strInsert & "')"
            cnAgil.Open()
            cm7 = New SqlCommand(strInsert, cnAgil)
            cm7.ExecuteNonQuery()
            cnAgil.Close()

            dsAgil.Tables.Remove("Clientes")

        Next
        TodoMonitorII()
        MsgBox("Proceso Terminado", MsgBoxStyle.Information, "Mensaje del Sistema")
        cnAgil.Close()
        cnAgil.Dispose()
        cm1.Dispose()
        cm7.Dispose()
    End Sub

    Sub AgregaAvales(ByVal Anexo As String, ByVal Ciclo As String, ByRef cString As String)
        Dim TAval As New GeneralDSTableAdapters.AvalesTableAdapter
        Dim Tav As New GeneralDS.AvalesDataTable
        Dim TAvalDat As New GeneralDSTableAdapters.DatosClie1TableAdapter
        Dim TavDaT As New GeneralDS.DatosClie1DataTable
        Dim r1 As GeneralDS.AvalesRow
        Dim rx As GeneralDS.DatosClie1Row
        Dim nEspacios, i As Integer
        Dim cNombre, cPaterno, cMaterno As String
        Dim newfrmPideNombre As frmPideNombre


        TAval.FillByCiclo(Tav, Anexo, Ciclo)
        If Tav.Rows.Count <= 0 Then
            TAval.Fill(Tav, Anexo)
        End If
        For Each r1 In Tav.Rows
            TAvalDat.Fill(TavDaT, r1.Cliente)
            rx = TavDaT.Rows(TavDaT.Rows.Count - 1)
            If rx.Calle.Trim = "" Or rx.Colonia.Trim = "" Then
                Continue For
            End If
            ''cString = cString & vbCrLf

            cString = cString & "AV" & "AV"
            cString = cString & "00" & rx.RFC
            cString = cString & "01" & rx.CURP
            cString = cString & "02" & Space(10)

            If rx.Tipo = "M" Then
                cString = cString & "03" & Mid(rx.Descr.Trim(), 1, 75) & Space(75 - Mid(rx.Descr.Trim(), 1, 75).Length)
                cString = cString & "04" & Space(75)
                cString = cString & "05" & Space(75)
                cString = cString & "06" & Space(25)
                cString = cString & "07" & Space(25)
            Else

                newfrmPideNombre = New frmPideNombre("M", rx.Descr.Trim(), rx.Cliente)
                newfrmPideNombre.ShowDialog()
                cNombre = newfrmPideNombre.Nombre
                cPaterno = newfrmPideNombre.Paterno
                cMaterno = newfrmPideNombre.Materno

                cPaterno = Mid(cPaterno, 1, 25)
                cMaterno = Mid(cMaterno, 1, 25)

                cString = cString & "03" & Space(75)
                cString = cString & "04" & cNombre & Space(75 - cNombre.Length)
                cString = cString & "05" & Space(75)
                cString = cString & "06" & cPaterno & Space(25 - cPaterno.Length)
                cString = cString & "07" & cMaterno & Space(25 - cMaterno.Length)

            End If

            cString = cString & "08" & Mid(rx.Calle, 1, 40)
            cString = cString & "09" & Space(40)
            cString = cString & "10" & Mid(rx.Colonia, 1, 60) & Space(60 - Mid(rx.Colonia, 1, 60).Length)
            cString = cString & "11" & Mid(rx.Delegacion, 1, 40)
            cString = cString & "12" & Mid(rx.Ciudad, 1, 40)
            cString = cString & "13" & rx.Abreviado.Trim & Space(4 - rx.Abreviado.Trim.Length)
            cString = cString & "14" & rx.Copos & Space(5)
            cString = cString & "15" & Space(11)
            cString = cString & "16" & Space(8)
            cString = cString & "17" & Space(11)
            cString = cString & "18" & IIf(rx.Tipo = "M", "1", "2")
            cString = cString & "19" & Space(40)
            cString = cString & "20" & "MX"
            cString = cString & "21" & Space(79)
            ''cString = cString & vbCrLf
        Next
        'AVALES+++++++++++++++++++++++++++++++++++++++

    End Sub

    Private Sub frmMorales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New DataTable
        Dim r As DataRow
        t.Columns.Add("ID")
        t.Columns.Add("TIT")

        Dim Fecha As Date = Date.Now
        'r = t.NewRow
        'r("ID") = Date.Now.ToString("yyyyMM01")
        'r("TIT") = "Production"
        't.Rows.Add(r)


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
        CmbDB.SelectedIndex = 0
        dtpProceso.Value = CTOD(CmbDB.SelectedValue)
    End Sub

    Private Sub CmbDB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDB.SelectedIndexChanged
        If CmbDB.SelectedIndex >= 0 And CmbDB.ValueMember <> "" Then
            dtpProceso.Value = CTOD(CmbDB.SelectedValue)
        End If

    End Sub


End Class
