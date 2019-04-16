Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class frmFisicas

    Inherits System.Windows.Forms.Form
    Dim TAval As New GeneralDSTableAdapters.AvalesTableAdapter
    Dim Tav As New GeneralDS.AvalesDataTable
    Dim TAvalDat As New GeneralDSTableAdapters.DatosClie1TableAdapter
    Dim taEmpleo As New GeneralDSTableAdapters.EmpleadoresTableAdapter
    Dim taEmpleo1 As New BuroDSTableAdapters.EmpleadoresTableAdapter
    Dim TavDaT As New GeneralDS.DatosClie1DataTable
    Dim r1 As GeneralDS.AvalesRow
    Dim rx As GeneralDS.DatosClie1Row
    Friend WithEvents CmbDB As ComboBox
    Friend WithEvents Label1 As Label
    Dim StrConnX As String = ""
    Friend WithEvents BuroDS As BuroDS
    Friend WithEvents HistoriaBindingSource As BindingSource
    Friend WithEvents HistoriaTableAdapter As BuroDSTableAdapters.HistoriaTableAdapter
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents FacturasTableAdapter As BuroDSTableAdapters.FacturasTableAdapter
    Friend WithEvents AviosBindingSource As BindingSource
    Friend WithEvents AviosTableAdapter As BuroDSTableAdapters.AviosTableAdapter
    Dim cnAgil As New SqlConnection(strConn)
    Dim TaRetrasos As New BuroDSTableAdapters.RetrasosJustificadosTableAdapter
    Friend WithEvents CheckParcial As CheckBox
    Dim TLtipoContrato As String

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
    Friend WithEvents btnGeneraF As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lblProceso = New System.Windows.Forms.Label()
        Me.dtpProceso = New System.Windows.Forms.DateTimePicker()
        Me.btnGeneraF = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CmbDB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BuroDS = New Agil.BuroDS()
        Me.HistoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistoriaTableAdapter = New Agil.BuroDSTableAdapters.HistoriaTableAdapter()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasTableAdapter = New Agil.BuroDSTableAdapters.FacturasTableAdapter()
        Me.AviosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AviosTableAdapter = New Agil.BuroDSTableAdapters.AviosTableAdapter()
        Me.CheckParcial = New System.Windows.Forms.CheckBox()
        CType(Me.BuroDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AviosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(401, 26)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(104, 23)
        Me.btnProcesar.TabIndex = 24
        Me.btnProcesar.Text = "Procesar"
        '
        'lblProceso
        '
        Me.lblProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProceso.Location = New System.Drawing.Point(180, 29)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Size = New System.Drawing.Size(110, 16)
        Me.lblProceso.TabIndex = 23
        Me.lblProceso.Text = "Fecha de Proceso"
        '
        'dtpProceso
        '
        Me.dtpProceso.Enabled = False
        Me.dtpProceso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProceso.Location = New System.Drawing.Point(297, 27)
        Me.dtpProceso.Name = "dtpProceso"
        Me.dtpProceso.Size = New System.Drawing.Size(88, 20)
        Me.dtpProceso.TabIndex = 22
        '
        'btnGeneraF
        '
        Me.btnGeneraF.Enabled = False
        Me.btnGeneraF.Location = New System.Drawing.Point(511, 26)
        Me.btnGeneraF.Name = "btnGeneraF"
        Me.btnGeneraF.Size = New System.Drawing.Size(104, 23)
        Me.btnGeneraF.TabIndex = 29
        Me.btnGeneraF.Text = "Generar Archivo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(621, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Formato 2015"
        '
        'CmbDB
        '
        Me.CmbDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDB.FormattingEnabled = True
        Me.CmbDB.Location = New System.Drawing.Point(51, 23)
        Me.CmbDB.Name = "CmbDB"
        Me.CmbDB.Size = New System.Drawing.Size(121, 21)
        Me.CmbDB.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Mes"
        '
        'BuroDS
        '
        Me.BuroDS.DataSetName = "BuroDS"
        Me.BuroDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistoriaBindingSource
        '
        Me.HistoriaBindingSource.DataMember = "Historia"
        Me.HistoriaBindingSource.DataSource = Me.BuroDS
        '
        'HistoriaTableAdapter
        '
        Me.HistoriaTableAdapter.ClearBeforeFill = True
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.BuroDS
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'AviosBindingSource
        '
        Me.AviosBindingSource.DataMember = "Avios"
        Me.AviosBindingSource.DataSource = Me.BuroDS
        '
        'AviosTableAdapter
        '
        Me.AviosTableAdapter.ClearBeforeFill = True
        '
        'CheckParcial
        '
        Me.CheckParcial.AutoSize = True
        Me.CheckParcial.Enabled = False
        Me.CheckParcial.Location = New System.Drawing.Point(731, 27)
        Me.CheckParcial.Name = "CheckParcial"
        Me.CheckParcial.Size = New System.Drawing.Size(58, 17)
        Me.CheckParcial.TabIndex = 39
        Me.CheckParcial.Text = "Parcial"
        Me.CheckParcial.UseVisualStyleBackColor = True
        '
        'frmFisicas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(797, 69)
        Me.Controls.Add(Me.CheckParcial)
        Me.Controls.Add(Me.CmbDB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGeneraF)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.lblProceso)
        Me.Controls.Add(Me.dtpProceso)
        Me.Name = "frmFisicas"
        Me.Text = "Buró de Crédito Personas Físicas"
        CType(Me.BuroDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AviosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Cursor.Current = Cursors.WaitCursor
        ' Declaración de variables de conexión ADO .NET
        If CmbDB.Text = "Production" Then
            StrConnX = "Server=" & My.Settings.ServidorPROD & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        Else
            StrConnX = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        End If

        cnAgil = New SqlConnection(StrConnX)


        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim cm5 As New SqlCommand()

        Dim cm6 As SqlCommand
        Dim dsAgil As New DataSet()
        Dim daAnexos As New SqlDataAdapter(cm1)
        Dim daEdoctav As New SqlDataAdapter(cm2)
        Dim daEdoctas As New SqlDataAdapter(cm3)
        Dim daEdoctao As New SqlDataAdapter(cm4)
        Dim daFacturas As New SqlDataAdapter(cm5)
        Dim drAnexo As DataRow
        Dim drEdoctav As DataRow()
        Dim drEdoctas As DataRow()
        Dim drEdoctao As DataRow()
        Dim drFactura As DataRow
        Dim drFacturas As DataRow()
        Dim relAnexoEdoctav As DataRelation
        Dim relAnexoEdoctas As DataRelation
        Dim relAnexoEdoctao As DataRelation
        Dim relAnexoFacturas As DataRelation
        Dim strDelete As String
        Dim strInsert As String
        Dim cont_avales As Integer

        ' Declaración de variables de datos

        Dim cAnexo As String
        Dim ctipo As String
        Dim cApertura As String
        Dim cCalle As String
        Dim cCalle2 As String = ""
        Dim cCiudad As String
        Dim cCliente As String
        Dim cColonia As String
        Dim cCP As String
        Dim cCusnam As String
        Dim cDelega As String
        Dim cEstado As String
        Dim cFecha As String
        Dim cFechaFin As String
        Dim cFepag As String
        Dim cFeven As String
        Dim cFlcan As String
        Dim cIndPag As String
        Dim cMaterno As String
        Dim cPaterno As String
        Dim cTerConSaldo As String
        Dim cTermina As String
        Dim cMop As String
        Dim cNombre As String
        Dim cRFC As String
        Dim cUltPago As String
        Dim i As Integer
        Dim lReportar As Boolean
        Dim nCarteraEquipo As Decimal = 0
        Dim nCarteraSeguro As Decimal = 0
        Dim nCarteraOtros As Decimal = 0
        Dim nDias As Integer
        Dim nEspacios As Byte
        Dim nInteresEquipo As Decimal = 0
        Dim nInteresSeguro As Decimal = 0
        Dim nInteresOtros As Decimal = 0
        Dim nMoi As Decimal
        Dim nMop As Integer
        Dim nPlazo As Integer
        Dim nRenta As Decimal
        Dim nSaldoEquipo As Decimal = 0
        Dim nSaldoSeguro As Decimal = 0
        Dim nSaldoOtros As Decimal = 0
        Dim nSaldoFac As Decimal
        Dim nSaldPag As Decimal
        Dim nSaldVen As Decimal
        Dim ANEXO As String
        Dim newfrmPideNombre As frmPideNombre
        Dim FechaJustificacion As Date

        btnProcesar.Enabled = False
        dtpProceso.Enabled = False
        cCalle2 = ""
        cFecha = DTOC(dtpProceso.Value)
        Call LlenaNombres(cnAgil)

        ' Este Stored Procedure regresa todos los contratos que no estén dados de baja,
        ' ni en suspenso y que hayan sido contratados hasta la fecha de proceso.  Trae
        ' exclusivamente los contratos de los clientes que sean Personas Físicas sin
        ' actividad empresarial.

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Fisicas1"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortización del equipo de todos los contratos activos
        ' con fecha de contratación menor o igual a la de proceso

        With cm2
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv2"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortización del seguro de todos los contratos activos
        ' con fecha de contratación menor o igual a la de proceso

        With cm3
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv3"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae la tabla de amortización de otros adeudos de todos los contratos activos
        ' con fecha de contratación menor o igual a la de proceso

        With cm4
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneProv4"
            .Connection = cnAgil
            .Parameters.Add("@FechaFin", SqlDbType.NVarChar)
            .Parameters(0).Value = cFecha
        End With

        ' Este Stored Procedure trae las facturas de los contratos activos o terminados
        ' con fecha de terminación mayor o igual al 1o. de enero de 2005, sin importar
        ' si están pagadas o no.

        With cm5
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Fisicas2"
            .Connection = cnAgil
        End With

        '  Try



        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión
        'InsertaAvalesAvio()
        daAnexos.Fill(dsAgil, "Anexos")
        daEdoctav.Fill(dsAgil, "Edoctav")
        daEdoctas.Fill(dsAgil, "Edoctas")
        daEdoctao.Fill(dsAgil, "Edoctao")
        daFacturas.Fill(dsAgil, "Facturas")

        ' Establecer la relación entre Anexos y Edoctav

        relAnexoEdoctav = New DataRelation("AnexoEdoctav", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Edoctav").Columns("Anexo"))

        ' Establecer la relación entre Anexos y Edoctas

        relAnexoEdoctas = New DataRelation("AnexoEdoctas", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Edoctas").Columns("Anexo"))

        ' Establecer la relación entre Anexos y Edoctao

        relAnexoEdoctao = New DataRelation("AnexoEdoctao", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Edoctao").Columns("Anexo"))

        ' Establecer la relación entre Anexos y Facturas

        relAnexoFacturas = New DataRelation("AnexoFacturas", dsAgil.Tables("Anexos").Columns("Anexo"), dsAgil.Tables("Facturas").Columns("Anexo"))

        dsAgil.EnforceConstraints = False
        dsAgil.Relations.Add(relAnexoEdoctav)
        dsAgil.Relations.Add(relAnexoEdoctas)
        dsAgil.Relations.Add(relAnexoEdoctao)
        dsAgil.Relations.Add(relAnexoFacturas)

        ' Ahora elimino todos los registros de la tabla Fisicas

        cnAgil.Open()
        strDelete = "DELETE FROM Fisicas"
        cm6 = New SqlClient.SqlCommand(strDelete, cnAgil)
        cm6.ExecuteNonQuery()
        cnAgil.Close()

        For Each drAnexo In dsAgil.Tables("Anexos").Rows

            cCusnam = Trim(drAnexo("Descr"))
            cCliente = Trim(drAnexo("Cli"))
            cNombre = Space(26)
            cPaterno = Space(26)
            cMaterno = Space(26)

            newfrmPideNombre = New frmPideNombre("F", cCusnam, cCliente)
            newfrmPideNombre.ShowDialog()
            cNombre = newfrmPideNombre.Nombre
            cPaterno = newfrmPideNombre.Paterno
            cMaterno = newfrmPideNombre.Materno

            cAnexo = drAnexo("Anexo")
            SacaTLtipoContrato(drAnexo("Tipar"), drAnexo("Fechacon"), TLtipoContrato)
            cRFC = drAnexo("Rfc")
            cCalle = Trim(drAnexo("Calle"))
            Dim dir As String = cCalle
            Dim size As Integer = dir.Length
            dir = Replace(dir, "SIN NUMERO", "SN")
            dir = Replace(dir, "S/N", "SN")
            'dir = Replace(dir, "SN", "")

            'End If

            cCalle2 = ""
            Dim re As New Regex("\d+")
            Dim m As Match = re.Match(dir)


            If m.Success Then
                ' Return m.Value
            Else
                Dim s3 As String = dir
                Dim s4 As String = "SN"
                Dim b1 As Boolean = s3.Contains(s4)
                If b1 Then
                Else
                    dir = dir & " SN"
                End If

            End If

            '  cCalle = Mid(drAnexo("Calle"), 1, 40)


            If size <= 40 Then
                cCalle = Mid(dir, 1, 40)
            Else
                If size <= 80 Then
                    cCalle = Mid(dir, 1, 40)
                    cCalle2 = Mid(dir, 41, 40)
                Else
                    cCalle = Mid(dir, 1, 40)
                    Dim s3 As String = dir
                    Dim s4 As String = "SN"
                    Dim b1 As Boolean = s3.Contains(s4)
                    If b1 Then
                        cCalle2 = Mid(dir, 41, 37) & " SN"
                    End If
                End If
            End If



            cColonia = drAnexo("Colonia")
            cDelega = Mid(drAnexo("Delegacion"), 1, 40)
            cCiudad = drAnexo("DescPlaza")
            cEstado = drAnexo("Abreviado")
            cCP = drAnexo("Copos")
            nPlazo = drAnexo("Plazo")
            cFlcan = drAnexo("Flcan")
            cApertura = drAnexo("Fechacon")
            cTermina = DTOC(Termina(cAnexo))
            cFechaFin = drAnexo("Fechafin")
            If cFlcan = "A" Or cFlcan = "T" Then
                If cTermina <= cFecha Then
                    cFechaFin = cTermina
                End If
                cUltPago = drAnexo("Fechacon")
            ElseIf cFlcan = "C" Then
                cUltPago = cFechaFin
            End If
            nMoi = drAnexo("ImpEq") - drAnexo("IvaEq") - drAnexo("Amorin")
            nRenta = drAnexo("Mensu")
            If nRenta = 0 Then
                nRenta = nMoi / nPlazo
            End If
            If cFlcan = "C" Then
                nRenta = 0
            End If

            ' Cálculo del Saldo Insoluto del equipo, del Seguro y de Otros Adeudos

            nSaldoEquipo = 0
            nInteresEquipo = 0
            nCarteraEquipo = 0

            nSaldoSeguro = 0
            nInteresSeguro = 0
            nCarteraSeguro = 0

            nSaldoOtros = 0
            nInteresOtros = 0
            nCarteraOtros = 0

            ' Los contratos TER o CAN ya no tienen saldo insoluto ni de Equipo, ni de Seguro,
            ' ni de Otros Adeudos

            If cFlcan = "A" Then

                ' Esta instrucción trae la tabla de amortización del Equipo única y exclusivamente del contrato
                ' que está siendo procesado

                drEdoctav = drAnexo.GetChildRows("AnexoEdoctav")
                TraeSald(drEdoctav, cFecha, nSaldoEquipo, nInteresEquipo, nCarteraEquipo, True, drAnexo("Tipar"))

                drEdoctas = drAnexo.GetChildRows("AnexoEdoctas")
                TraeSald(drEdoctas, cFecha, nSaldoSeguro, nInteresSeguro, nCarteraSeguro, False, drAnexo("Tipar"))

                drEdoctao = drAnexo.GetChildRows("AnexoEdoctao")
                TraeSald(drEdoctao, cFecha, nSaldoOtros, nInteresOtros, nCarteraOtros, False, drAnexo("Tipar"))

                nSaldoEquipo = Round(nSaldoEquipo + nSaldoSeguro + nSaldoOtros, 2)

            End If

            ' Ahora determino el saldo vencido de los contratos ACT o TER

            nSaldVen = 0
            nSaldPag = 0
            nMop = 0

            If cFlcan = "A" Or cFlcan = "T" Then

                ' Esta instrucción trae las facturas única y exclusivamente del contrato
                ' que está siendo procesado

                drFacturas = drAnexo.GetChildRows("AnexoFacturas")

                For Each drFactura In drFacturas

                    cFeven = drFactura("Feven")
                    cFepag = drFactura("Fepag")
                    cIndPag = drFactura("IndPag")
                    nSaldoFac = drFactura("SaldoFac")
                    nDias = 0

                    ' Solo considero facturas exigibles

                    If cFeven <= cFecha Then

                        ' Determino la fecha de último pago

                        If cFepag > cUltPago Then
                            cUltPago = cFepag
                        End If

                        ' Solo proceso facturas no pagadas (que tienen saldo)

                        If cIndPag <> "P" And nSaldoFac > 0 Then
                            nDias = DateDiff(DateInterval.Day, CTOD(cFeven), CTOD(cFecha))
                            If cAnexo = "019180002" Or cAnexo = "040760001" Then nDias = 0 'por prepago de Contratos Ing. Francisco Monroy
                            TaRetrasos.FillByAnexo(BuroDS.RetrasosJustificados, drFactura("Anexo"), drFactura("Letra"))
                            If BuroDS.RetrasosJustificados.Rows.Count > 0 Then
                                nDias = DateDiff(DateInterval.Day, CTOD(cFeven), BuroDS.RetrasosJustificados.Rows(0).Item("FechaPago"))
                                If nDias < 0 Then nDias = 0
                            End If
                            If nDias > 0 Then
                                If nMop = 0 Then
                                    nMop = nDias
                                End If
                                nSaldVen += nSaldoFac
                                nSaldPag += 1
                            End If
                        End If

                    End If

                Next

            End If

            If nSaldVen > nSaldoEquipo Then
                nSaldoEquipo = nSaldVen
            End If

            cTerConSaldo = "N"
            lReportar = True

            If cFlcan = "T" Then

                If nSaldVen > 0 Then

                    cTerConSaldo = "S"

                    ' Lo reporto NORMAL con saldo pero sin fechafin e igualo el pago mínimo,
                    ' el saldo actual, y el saldo vencido

                    cFechaFin = Space(8)

                    nSaldoEquipo = nSaldVen

                    If nSaldoEquipo > nMoi Then
                        nMoi = nSaldoEquipo
                    End If

                    nRenta = nSaldVen

                ElseIf nSaldVen = 0 Then

                    ' Terminó y no tiene saldo vencido aunque pudo haber terminado con saldo
                    ' en algún mes anterior al actual

                    If cTermina <= cUltPago Then

                        ' Terminó con saldo pero ya no lo debe, por lo que ahora debo checar
                        ' cuándo pagó dicho adeudo ya que si lo pagó en el mes que se está
                        ' reportando, tengo que reportarlo como CERRADO en ceros; pero si lo
                        ' pagó en un mes anterior, lo más seguro es que ya lo haya reportado
                        ' anteriormente.

                        If Mid(cUltPago, 1, 6) = Mid(cFecha, 1, 6) Then

                            nSaldoEquipo = 0
                            nSaldVen = 0
                            nSaldPag = 0
                            nRenta = 0

                        Else

                            ' Significa que lo reporté anteriormente

                            lReportar = False

                        End If

                    Else

                        ' Significa que terminó sin saldo

                        lReportar = False

                    End If

                End If

            End If

            If cFechaFin <> Space(8) And cUltPago > cFechaFin Then
                cFechaFin = cUltPago
            End If

            If nMop <= 5 Then
                cMop = "01"
                nSaldVen = 0
                nSaldPag = 0
            ElseIf nMop > 5 And nMop < 30 Then
                cMop = "02"
            ElseIf nMop >= 30 And nMop < 60 Then
                cMop = "03"
            ElseIf nMop >= 60 And nMop < 90 Then
                cMop = "04"
            ElseIf nMop >= 90 And nMop < 120 Then
                cMop = "05"
            ElseIf nMop >= 120 And nMop < 150 Then
                cMop = "06"
            ElseIf nMop >= 150 And nMop < 366 Then
                cMop = "07"
            ElseIf nMop >= 366 Then
                cMop = "96"
            End If

            If lReportar = True Then
                strInsert = "INSERT INTO Fisicas(PNPaterno, PNMaterno, PNNombre, PNRfc, PACalle, PACalle2, PAColonia, PADelega, PACiudad, PAEstado, PACP, TLCuenCli, TLPlazo, TLRenta, TLApertura, TLUltPago, TLFechaFin, TLMoi, TLSaldAct, TLSaldVen, TLSaldPag, TLMop, Flcan, TerConSaldo, Cliente,TLtipoRespon,TLtipoContrato)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & cPaterno & "', '"
                strInsert = strInsert & cMaterno & "', '"
                strInsert = strInsert & cNombre & "', '"
                strInsert = strInsert & cRFC & "', '"
                strInsert = strInsert & cCalle & "', '"
                strInsert = strInsert & cCalle2 & "', '"
                strInsert = strInsert & cColonia & "', '"
                strInsert = strInsert & cDelega & "', '"
                strInsert = strInsert & cCiudad & "', '"
                strInsert = strInsert & cEstado & "', '"
                strInsert = strInsert & cCP & "', '"
                strInsert = strInsert & Mid(cAnexo, 1, 5) & "-" & Mid(cAnexo, 6, 4) & "', '"
                strInsert = strInsert & nPlazo.ToString & "', '"
                strInsert = strInsert & Round(nRenta, 0).ToString & "', '"
                strInsert = strInsert & Mid(cApertura, 7, 2) & Mid(cApertura, 5, 2) & Mid(cApertura, 1, 4) & "', '"
                strInsert = strInsert & Mid(cUltPago, 7, 2) & Mid(cUltPago, 5, 2) & Mid(cUltPago, 1, 4) & "', '"
                strInsert = strInsert & Mid(cFechaFin, 7, 2) & Mid(cFechaFin, 5, 2) & Mid(cFechaFin, 1, 4) & "', '"
                strInsert = strInsert & Round(nMoi, 0).ToString & "', '"
                strInsert = strInsert & Round(nSaldoEquipo, 0).ToString & "', '"
                strInsert = strInsert & Round(nSaldVen, 0).ToString & "', '"
                strInsert = strInsert & Round(nSaldPag, 0).ToString & "', '"
                strInsert = strInsert & cMop & "', '"
                strInsert = strInsert & cFlcan & "', '"
                strInsert = strInsert & cTerConSaldo & "', '"
                strInsert = strInsert & cCliente & "',"
                strInsert = strInsert & "'I', '" & TLtipoContrato & "'"
                strInsert = strInsert & ")"
                cnAgil.Open()
                cm1 = New SqlCommand(strInsert, cnAgil)
                cm1.ExecuteNonQuery()
                cnAgil.Close()

                ' SE INSERTAN AVALES
                TAval.FillByFisicas(Tav, cAnexo)
                For Each r1 In Tav.Rows

                    ANEXO = ANEXO & " OR GEN_Avales.Anexo= '" & cAnexo & "' "
                    TAvalDat.Fill(TavDaT, r1.Cliente)
                    rx = TavDaT.Rows(TavDaT.Rows.Count - 1)

                    If rx.Calle.Trim = "" Or rx.Colonia.Trim = "" Then
                        Continue For
                    End If

                    If IsDBNull(rx.DescPlaza) Then
                        rx.DescPlaza = "ESTADO DE MEXICO"
                        rx.Abreviado = "EM"
                    End If

                    newfrmPideNombre = New frmPideNombre("M", rx.Descr.Trim(), rx.Cliente)
                    newfrmPideNombre.ShowDialog()
                    cNombre = newfrmPideNombre.Nombre
                    cPaterno = newfrmPideNombre.Paterno
                    cMaterno = newfrmPideNombre.Materno

                    cPaterno = Mid(cPaterno, 1, 25)
                    cMaterno = Mid(cMaterno, 1, 25)

                    cCalle = rx.Calle
                    Dim dir1 As String = cCalle
                    dir1 = Trim(dir1)
                    Dim size1 As Integer = dir1.Length
                    dir1 = Replace(dir1, "SIN NUMERO", "")
                    dir1 = Replace(dir1, "S/N", "")
                    'dir1 = Replace(dir1, "SN", "")

                    'End If


                    Dim re1 As New Regex("\d+")
                    Dim m1 As Match = re1.Match(dir1)


                    If m1.Success Then
                        ' Return m.Value
                    Else
                        Dim s3 As String = dir1
                        Dim s4 As String = "SN"
                        Dim b1 As Boolean = s3.Contains(s4)
                        If b1 Then
                        Else
                            dir1 = dir1 & " SN"
                        End If

                    End If

                    '  cCalle = Mid(drAnexo("Calle"), 1, 40)

                    cCalle2 = ""
                    If size1 <= 40 Then
                        cCalle = Mid(dir1, 1, 40)
                    Else
                        If size1 <= 80 Then
                            cCalle = Mid(dir1, 1, 40)
                            cCalle2 = Mid(dir1, 41, 40)
                        Else
                            cCalle = Mid(dir1, 1, 40)
                            Dim s3 As String = dir1
                            Dim s4 As String = "SN"
                            Dim b1 As Boolean = s3.Contains(s4)
                            If b1 Then
                                cCalle2 = Mid(dir1, 41, 37) & " SN"
                            End If
                        End If
                    End If

                    strInsert = "INSERT INTO Fisicas(PNPaterno, PNMaterno, PNNombre, PNRfc, PACalle,PACalle2,PAColonia, PADelega, PACiudad, PAEstado, PACP, TLCuenCli, TLPlazo, TLRenta, TLApertura, TLUltPago, TLFechaFin, TLMoi, TLSaldAct, TLSaldVen, TLSaldPag, TLMop, Flcan, TerConSaldo, Cliente,TLtipoRespon,TLtipoContrato)"
                    strInsert = strInsert & " VALUES ('"
                    strInsert = strInsert & cPaterno & "', '"
                    strInsert = strInsert & cMaterno & "', '"
                    strInsert = strInsert & cNombre & "', '"
                    strInsert = strInsert & rx.RFC & "', '"
                    strInsert = strInsert & cCalle & "', '"
                    strInsert = strInsert & cCalle2 & "', '"
                    strInsert = strInsert & rx.Colonia & "', '"
                    strInsert = strInsert & rx.Delegacion.Substring(0, 39) & "', '"
                    strInsert = strInsert & rx.DescPlaza & "', '"
                    strInsert = strInsert & rx.Abreviado & "', '"
                    strInsert = strInsert & rx.Copos & "', '"
                    strInsert = strInsert & Mid(cAnexo, 1, 5) & "-" & Mid(cAnexo, 6, 4) & "', '"
                    strInsert = strInsert & nPlazo.ToString & "', '"
                    strInsert = strInsert & Round(nRenta, 0).ToString & "', '"
                    strInsert = strInsert & Mid(cApertura, 7, 2) & Mid(cApertura, 5, 2) & Mid(cApertura, 1, 4) & "', '"
                    strInsert = strInsert & Mid(cUltPago, 7, 2) & Mid(cUltPago, 5, 2) & Mid(cUltPago, 1, 4) & "', '"
                    strInsert = strInsert & Mid(cFechaFin, 7, 2) & Mid(cFechaFin, 5, 2) & Mid(cFechaFin, 1, 4) & "', '"
                    strInsert = strInsert & Round(nMoi, 0).ToString & "', '"
                    strInsert = strInsert & Round(nSaldoEquipo, 0).ToString & "', '"
                    strInsert = strInsert & Round(nSaldVen, 0).ToString & "', '"
                    strInsert = strInsert & Round(nSaldPag, 0).ToString & "', '"
                    strInsert = strInsert & cMop & "', '"
                    strInsert = strInsert & cFlcan & "', '"
                    strInsert = strInsert & cTerConSaldo & "', '"
                    strInsert = strInsert & rx.Cliente & "',"
                    strInsert = strInsert & "'C', '" & TLtipoContrato & "'"
                    strInsert = strInsert & ")"
                    cnAgil.Open()
                    cm1 = New SqlCommand(strInsert, cnAgil)
                    cm1.ExecuteNonQuery()
                    cnAgil.Close()
                    cont_avales = cont_avales + 1
                Next



            End If

        Next
        Dim MM As String = ANEXO
        Dim sumaavales As Integer
        sumaavales = cont_avales
        ' Por último, inserto el registro correspondiente al Fraude de José Luis Cruz Medina

        strInsert = "INSERT INTO Fisicas(PNPaterno, PNMaterno, PNNombre, PNRfc, PACalle, PAColonia, PADelega, PACiudad, PAEstado, PACP, TLCuenCli, TLPlazo, TLRenta, TLApertura, TLUltPago, TLFechaFin, TLMoi, TLSaldAct, TLSaldVen, TLSaldPag, TLMop, Flcan, TerConSaldo,TLtipoRespon,TLtipoContrato)"
        strInsert = strInsert & " VALUES ('"
        strInsert = strInsert & "CRUZ" & "', '"
        strInsert = strInsert & "MEDINA" & "', '"
        strInsert = strInsert & "JOSE LUIS" & "', '"
        strInsert = strInsert & "CUML670427163" & "', '"
        strInsert = strInsert & "NARANJA # 47" & "', '"
        strInsert = strInsert & "IZCALLI TOLUCA" & "', '"
        strInsert = strInsert & "TOLUCA" & "', '"
        strInsert = strInsert & "ESTADO DE MEXICO" & "', '"
        strInsert = strInsert & "EM" & "', '"
        strInsert = strInsert & "50150" & "', '"
        strInsert = strInsert & "00896-0001" & "', '"
        strInsert = strInsert & "36" & "', '"
        strInsert = strInsert & "163718" & "', '"
        strInsert = strInsert & "11062001" & "', '"
        strInsert = strInsert & "30042002" & "', '"
        strInsert = strInsert & "        " & "', '"
        strInsert = strInsert & "163718" & "', '"
        strInsert = strInsert & "163718" & "', '"
        strInsert = strInsert & "163718" & "', '"
        strInsert = strInsert & "27" & "', '"
        strInsert = strInsert & "99" & "', '"
        strInsert = strInsert & "T" & "', '"
        strInsert = strInsert & "S"
        strInsert = strInsert & "','I','LS')"
        cnAgil.Open()
        cm1 = New SqlCommand(strInsert, cnAgil)
        cm1.ExecuteNonQuery()
        cnAgil.Close()

        InsertaAvalesAvio() ' inserta avales de avios a personas fisicas
        InsertaAvales() ' inserta avales de tradicionales a personas fisicas


        'Catch eException As Exception
        '    MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
        'End Try

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()
        cm4.Dispose()
        cm5.Dispose()
        cm6.Dispose()
        Cursor.Current = Cursors.Default

        MsgBox("Proceso  de carga Terminado", MsgBoxStyle.Information, "Mensaje del Sistema")



    End Sub

    Private Sub btnGeneraF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraF.Click
        Cursor.Current = Cursors.WaitCursor
        ' Declaración de variables de conexión ADO .NET
        If CmbDB.Text = "Production" Then
            StrConnX = "Server=" & My.Settings.ServidorPROD & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        Else
            StrConnX = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        End If
        Dim cnAgil As New SqlConnection(StrConnX)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daFisicas As New SqlDataAdapter(cm1)
        Dim drFisica As DataRow

        ' Declaración de variables de datos

        Dim cCicloNumero As String = Space(2)
        Dim cClaveOtorgante As String = "LS16090001"
        Dim cFecha As String
        Dim cFechaReporte As String
        Dim cInformacionAdic As String = Space(98)
        Dim cLongitud As String
        Dim cNombreOtorgante As String = "FINAGIL         "
        Dim cString As String
        Dim cUsoFuturo As String = "0000000000"
        Dim nLongitud As Decimal
        Dim nRegistros As Decimal = 0
        Dim nSumaTLSaldAct As Decimal = 0
        Dim nSumaTLSaldVen As Decimal = 0
        Dim oReporte As StreamWriter

        cFecha = DTOC(dtpProceso.Value)

        cFechaReporte = Mid(cFecha, 7, 2) & Mid(cFecha, 5, 2) & Mid(cFecha, 1, 4)

        ' Este Stored Procedure regresa todos los registros que aparecen en la tabla Fisicas

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneraF1"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daFisicas.Fill(dsAgil, "Fisicas")

        ' SEGMENTO DE ENCABEZADO

        cString = "INTF10" & cClaveOtorgante & cNombreOtorgante & cCicloNumero & cFechaReporte & cUsoFuturo & cInformacionAdic

        For Each drFisica In dsAgil.Tables("Fisicas").Rows

            ' SEGMENTO DE NOMBRE (PN)

            nLongitud = Len(Trim(drFisica("PNPaterno")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "PN" & cLongitud & Trim(drFisica("PNPaterno"))

            nLongitud = Len(Trim(drFisica("PNMaterno")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "00" & cLongitud & Trim(drFisica("PNMaterno"))

            nLongitud = Len(Trim(drFisica("PNNombre")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "02" & cLongitud & Trim(drFisica("PNNombre"))

            nLongitud = Len(Trim(drFisica("PNRfc")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "05" & cLongitud & Trim(drFisica("PNRfc"))

            ' SEGMENTO DE DIRECCION (PA)

            nLongitud = Len(Trim(drFisica("PACalle")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "PA" & cLongitud & Trim(drFisica("PACalle"))

            nLongitud = Len(Trim(drFisica("PAColonia")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "01" & cLongitud & Trim(drFisica("PAColonia"))

            nLongitud = Len(Trim(drFisica("PADelega")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "02" & cLongitud & Trim(drFisica("PADelega"))

            nLongitud = Len(Trim(drFisica("PACiudad")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "03" & cLongitud & Trim(drFisica("PACiudad"))

            nLongitud = Len(Trim(drFisica("PAEstado")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "04" & cLongitud & Trim(drFisica("PAEstado"))

            cString = cString & "0505" + Trim(drFisica("PACp"))

            ' SEGMENTO DE CUENTAS (TL)

            cString = cString & "TL" & "02" & "TL" & "01" & "10" & cClaveOtorgante

            nLongitud = Len(Trim(cNombreOtorgante))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "02" & cLongitud & Trim(cNombreOtorgante)

            cString = cString & "04" & "10" & drFisica("TLCuenCli")
            Dim c As Integer
            c = c + 1

            cString = cString & "05" & "01" & drFisica("TLtipoRespon") '"I" ' tipo de resposabilidad "OBLIGADO SOLIDARIOS = C"
            cString = cString & "06" & "01" & "I" ' tipo de cuenta
            cString = cString & "07" & "02" & drFisica("TLtipoContrato") '"LS" ' tipo de contrato
            cString = cString & "08" & "02" & "MX"

            nLongitud = Len(Trim(drFisica("TLPlazo")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "10" & cLongitud & Trim(drFisica("TLPlazo"))

            '++++++RENTA Y PERIODICIDAD
            Dim Divisor As Integer = 1
            Select Case taEmpleo.PromedioDias(drFisica("TLCuenCli"))
                Case 0
                    Select Case taEmpleo.PromedioDiasAV(drFisica("TLCuenCli"))
                        Case 0
                            cString = cString & "11" & "01" & "M"
                        Case 1 To 45
                            cString = cString & "11" & "01" & "M"
                        Case 46 To 80
                            cString = cString & "11" & "01" & "B"
                            Divisor = 2
                        Case 81 To 140
                            cString = cString & "11" & "01" & "Q"
                            Divisor = 3
                        Case 141 To 300
                            cString = cString & "11" & "01" & "H"
                            Divisor = 6
                        Case Else
                            cString = cString & "11" & "01" & "Y"
                            Divisor = 12
                    End Select
                Case 7
                    cString = cString & "11" & "01" & "W"
                Case 14
                    cString = cString & "11" & "01" & "K"
                Case 15 To 18
                    cString = cString & "11" & "01" & "S"
                Case 19 To 45
                    cString = cString & "11" & "01" & "M"
                Case 46 To 80
                    cString = cString & "11" & "01" & "B"
                Case 81 To 140
                    cString = cString & "11" & "01" & "Q"
                Case 141 To 300
                    cString = cString & "11" & "01" & "H"
                Case Else
                    cString = cString & "11" & "01" & "Y"
            End Select
            Dim RentaAux As Decimal = Round(drFisica("TLRenta") / Divisor, 2)
            nLongitud = Len(Trim(RentaAux))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "12" & cLongitud & Trim(RentaAux)
            '++++++RENTA Y PERIODICIDAD

            cString = cString & "13" & "08" & drFisica("TLApertura")




            If drFisica("TLFechaFin") <> Space(8) Then
                cString = cString & "16" & "08" & drFisica("TLFechaFin")
            End If

            nLongitud = Len(Trim(drFisica("TLMoi")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "21" & cLongitud & Trim(drFisica("TLMoi"))

            nLongitud = Len(Trim(drFisica("TLSaldAct")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "22" & cLongitud & Trim(drFisica("TLSaldAct"))

            nSumaTLSaldAct += CDbl(Trim(drFisica("TLSaldAct")))

            ' El número de pagos vencidos así como su monto solo se especifican para las cuentas con atraso

            If drFisica("TLMop") <> "01" Then

                nLongitud = Len(Trim(drFisica("TLSaldVen")))
                If nLongitud < 10 Then
                    cLongitud = "0" + Trim(Str(nLongitud))
                Else
                    cLongitud = Trim(Str(nLongitud))
                End If
                cString = cString & "24" & cLongitud & Trim(drFisica("TLSaldVen"))

                nSumaTLSaldVen += CDbl(Trim(drFisica("TLSaldVen")))

                nLongitud = Len(Trim(drFisica("TLSaldPag")))
                If nLongitud < 10 Then
                    cLongitud = "0" + Trim(Str(nLongitud))
                Else
                    cLongitud = Trim(Str(nLongitud))
                End If
                cString = cString & "25" & cLongitud & Trim(drFisica("TLSaldPag"))

            End If

            cString = cString & "26" & "02" & Trim(drFisica("TLMop"))

            If Trim(drFisica("TLObservacion")) <> "" Then
                cString = cString & "30" & "02" & Trim(drFisica("TLObservacion"))
            End If

            cString = cString & "99" & "03" & "END"

        Next

        nRegistros = dsAgil.Tables("Fisicas").Rows.Count

        ' SEGMENTO DE CIFRAS DE CONTROL (TR)

        cString = cString & "TRLR"
        cString = cString & Stuff(nSumaTLSaldAct.ToString, "I", "0", 14)
        cString = cString & Stuff(nSumaTLSaldVen.ToString, "I", "0", 14)
        cString = cString & "001"
        cString = cString & Stuff(nRegistros.ToString, "I", "0", 9)
        cString = cString & Stuff(nRegistros.ToString, "I", "0", 9)
        cString = cString & "000000000"
        cString = cString & Stuff(nRegistros.ToString, "I", "0", 9)
        cString = cString & "000000"
        cString = cString & Stuff("AGIL", "D", " ", 16)
        cString = cString & Stuff("LEANDRO VALLE 402 1er. PISO, COL. REFORMA Y FFCCNN, C.P. 50070, TOLUCA, ESTADO DE MEXICO", "D", " ", 160)

        oReporte = New StreamWriter("c:\Files\FISICAS.TXT", False, System.Text.Encoding.Default)
        Dim textAscii As New ASCIIEncoding()

        cString = cString.Replace("Á", "A")
        cString = cString.Replace("É", "E")
        cString = cString.Replace("Í", "I")
        cString = cString.Replace("Ó", "O")
        cString = cString.Replace("Ú", "U")

        Dim encodedBytes As Byte() = textAscii.GetBytes(cString)
        Dim decodedString As String = textAscii.GetString(encodedBytes)
        decodedString = decodedString.Replace("?", "Ñ")
        oReporte.WriteLine(decodedString)
        oReporte.Close()

        cnAgil.Dispose()
        cm1.Dispose()
        Cursor.Current = Cursors.Default
        'MsgBox("Recuerda cambiar ? por Ñ", MsgBoxStyle.Information, "Mensaje del Sistema")
        MsgBox("Terminado", MsgBoxStyle.Information, "Mensaje del Sistema")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor.Current = Cursors.WaitCursor
        If CheckParcial.Checked = True Then
            EliminaInfoSinPagos()
        End If
        ' Declaración de variables de conexión ADO .NET
        If CmbDB.Text = "Production" Then
            StrConnX = "Server=" & My.Settings.ServidorPROD & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        Else
            StrConnX = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        End If
        Dim cnAgil As New SqlConnection(StrConnX)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daFisicas As New SqlDataAdapter(cm1)
        Dim drFisica As DataRow

        ' Declaración de variables de datos

        Dim cCicloNumero As String = Space(2)
        Dim cClaveOtorgante As String = "LS16090001"
        Dim cFecha As String
        Dim cFechaReporte As String
        Dim cInformacionAdic As String = Space(98)
        Dim cUSOFUT As String = Space(2)
        Dim cLongitud As String
        Dim cNombreOtorgante As String = "FINAGIL         "
        Dim cString As String
        Dim cUsoFuturo As String = "0000000000"
        Dim nLongitud As Decimal
        Dim nRegistros As Decimal = 0
        Dim nSumaTLSaldAct As Decimal = 0
        Dim nSumaTLSaldVen As Decimal = 0
        Dim oReporte As StreamWriter
        Dim cNombre1 As String
        Dim cNombre2 As String
        Dim FechaNac As Date
        Dim cFechaNac As String
        Dim cAux As String
        Dim tEmpleo As New GeneralDS.EmpleadoresDataTable
        Dim tEmpleo1 As New BuroDS.EmpleadoresDataTable
        Dim r As GeneralDS.EmpleadoresRow
        Dim tlplazoM As Decimal = 0
        Dim c As Integer
        Dim cx As Integer
        Dim anexos As String
        Dim Ca As Integer
        cFecha = DTOC(dtpProceso.Value)

        cFechaReporte = Mid(cFecha, 7, 2) & Mid(cFecha, 5, 2) & Mid(cFecha, 1, 4)

        ' Este Stored Procedure regresa todos los registros que aparecen en la tabla Fisicas

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GeneraF1"
            .Connection = cnAgil
        End With

        ' Llenar el DataSet a través del DataAdapter, lo cual abre y cierra la conexión

        daFisicas.Fill(dsAgil, "Fisicas")

        ' SEGMENTO DE ENCABEZADO

        cString = "INTF14" & cClaveOtorgante & cNombreOtorgante & cCicloNumero & cFechaReporte & cUsoFuturo & cInformacionAdic

        For Each drFisica In dsAgil.Tables("Fisicas").Rows

            ' SEGMENTO DE NOMBRE (PN)

            nLongitud = Len(Trim(drFisica("PNPaterno")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "PN" & cLongitud & Trim(drFisica("PNPaterno"))

            nLongitud = Len(Trim(drFisica("PNMaterno")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            If nLongitud >= 26 Then
                Dim c1 As String = "error"
            End If

            cString = cString & "00" & cLongitud & Trim(drFisica("PNMaterno"))

            cNombre1 = PrimerNombre(Trim(drFisica("PNNombre")))
            cNombre2 = SegundoNombre(Trim(drFisica("PNNombre")))

            nLongitud = Len(cNombre1)
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "02" & cLongitud & cNombre1
            If nLongitud >= 26 Then
                Dim c1 As String = "error"
            End If
            nLongitud = Len(cNombre2)
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "03" & cLongitud & cNombre2

            nLongitud = Len(Trim(drFisica("PNRfc")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If

            cFechaNac = Mid(drFisica("PNRfc"), 5, 6)
            Dim valor As Integer = Val(Mid(20, 1, 2))
            Dim anio As Integer = Date.Now.Year - 2000
            Dim resta As Integer = valor - anio
            If Val(Mid(cFechaNac, 1, 2)) - (2000 - Date.Now.Year) < 0 Then
                cFechaNac = "20" & cFechaNac
            Else

                cFechaNac = "19" & cFechaNac

            End If
            Dim v As String = Val(Mid(cFechaNac, 1, 2))
            Dim fecha As String = Mid(cFechaNac, 7, 2) & Mid(cFechaNac, 5, 2) & Mid(cFechaNac, 1, 4)
            '  FechaNac = New Date(Mid(cFechaNac, 1, 4), Mid(cFechaNac, 7, 2), Mid(cFechaNac, 5, 2))
            cString = cString & "0408" & fecha
            cString = cString & "05" & cLongitud & Trim(drFisica("PNRfc"))
            cString = cString & "08" & "02MX"

            ' SEGMENTO DE DIRECCION (PA)

            nLongitud = Len(Trim(drFisica("PACalle")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "PA" & cLongitud & Trim(drFisica("PACalle"))
            Dim calle2 As String
            If Not IsDBNull(drFisica("PACalle2")) Then
                nLongitud = Len(Trim(drFisica("PACalle2")))
                calle2 = Trim(drFisica("PACalle2"))
            Else
                nLongitud = 0
                calle2 = ""

            End If

            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If

            cString = cString & "00" & cLongitud & calle2

            nLongitud = Len(Trim(drFisica("PAColonia")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "01" & cLongitud & Trim(drFisica("PAColonia"))

            nLongitud = Len(Trim(drFisica("PADelega")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "02" & cLongitud & Trim(drFisica("PADelega"))

            nLongitud = Len(Trim(drFisica("PACiudad")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "03" & cLongitud & Trim(drFisica("PACiudad"))

            nLongitud = Len(Trim(drFisica("PAEstado")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "04" & cLongitud & Trim(drFisica("PAEstado"))

            cString = cString & "0505" + Trim(drFisica("PACp"))
            cString = cString & "1202MX"
            Dim cliente As String

            ' SEGMENTO DE DIRECCION (PE)
            If Not IsDBNull(drFisica("Cliente")) Then

                cliente = drFisica("Cliente")
            Else
                cliente = "0"
            End If
            taEmpleo.Fill(tEmpleo, cliente)
            If tEmpleo.Rows.Count > 0 Then
                r = tEmpleo.Rows(0)
                cAux = r.PE_Empleador
                nLongitud = Len(Trim(cAux))
                If nLongitud < 10 Then
                    cLongitud = "0" + Trim(Str(nLongitud))
                Else
                    cLongitud = Trim(Str(nLongitud))
                End If
                cString = cString & "PE" & cLongitud & Trim(cAux) 'cambip de pn a pe  datps del empleador  DAGL

                cAux = r.PE_Calle1
                nLongitud = Len(Trim(cAux))
                If nLongitud < 10 Then
                    cLongitud = "0" + Trim(Str(nLongitud))
                Else
                    cLongitud = Trim(Str(nLongitud))
                End If
                cString = cString & "00" & cLongitud & Trim(cAux)

                cAux = r.PE_Calle2
                nLongitud = Len(Trim(cAux))
                If nLongitud < 10 Then
                    cLongitud = "0" + Trim(Str(nLongitud))
                Else
                    cLongitud = Trim(Str(nLongitud))
                End If
                cString = cString & "01" & cLongitud & Trim(cAux)

                cAux = r.PE_Colonia
                nLongitud = Len(Trim(cAux))
                If nLongitud < 10 Then
                    cLongitud = "0" + Trim(Str(nLongitud))
                Else
                    cLongitud = Trim(Str(nLongitud))
                End If
                cString = cString & "02" & cLongitud & Trim(cAux)

                cAux = r.PE_Delegacion
                nLongitud = Len(Trim(cAux))
                If nLongitud < 10 Then
                    cLongitud = "0" + Trim(Str(nLongitud))
                Else
                    cLongitud = Trim(Str(nLongitud))
                End If
                cString = cString & "03" & cLongitud & Trim(cAux)

                cAux = r.PE_Ciudad
                nLongitud = Len(Trim(cAux))
                If nLongitud < 10 Then
                    cLongitud = "0" + Trim(Str(nLongitud))
                Else
                    cLongitud = Trim(Str(nLongitud))
                End If
                cString = cString & "04" & cLongitud & Trim(cAux)

                cAux = r.PE_Estado
                nLongitud = Len(Trim(cAux))
                If nLongitud < 10 Then
                    cLongitud = "0" + Trim(Str(nLongitud))
                Else
                    cLongitud = Trim(Str(nLongitud))
                End If
                cString = cString & "05" & cLongitud & Trim(cAux)

                cAux = r.PE_Copos
                nLongitud = Len(Trim(cAux))
                If nLongitud < 10 Then
                    cLongitud = "0" + Trim(Str(nLongitud))
                Else
                    cLongitud = Trim(Str(nLongitud))
                End If
                cString = cString & "06" & cLongitud & Trim(cAux)
                cString = cString & "18" & "02MX"
            End If

            ' SEGMENTO DE CUENTAS (TL)

            cString = cString & "TL" & "02" & "TL" & "01" & "10" & cClaveOtorgante

            nLongitud = Len(Trim(cNombreOtorgante))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "02" & cLongitud & Trim(cNombreOtorgante)

            cString = cString & "04" & "10" & drFisica("TLCuenCli")
            cString = cString & "05" & "01" & drFisica("TLtipoRespon")

            If drFisica("TLtipoRespon") = "C" Then
                Ca = Ca + 1
            End If

            cString = cString & "06" & "01" & "I"
            cString = cString & "07" & "02" & "LS"
            cString = cString & "08" & "02" & "MX"

            nLongitud = Len(Trim(drFisica("TLPlazo")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "10" & cLongitud & Trim(drFisica("TLPlazo"))

            '++++++RENTA Y PERIODICIDAD
            Dim Divisor As Integer = 1
            Dim anexo = Replace(Replace(drFisica("TLCuenCli"), "-", ""), "/", "")
            Dim monto As Decimal = 0
            Dim fecha_ult As String
            Dim aval As Boolean = False
            Dim anexo_his = Me.HistoriaTableAdapter.Scalaranexo(anexo)
            Dim ultpago_avio As String

            If anexo_his > 0 Then
                monto = Me.HistoriaTableAdapter.monto(anexo)

                '  If monto > 0 Then
                fecha_ult = Me.HistoriaTableAdapter.ScalarQuery(anexo)
                fecha_ult = Mid(fecha_ult, 7, 2) & Mid(fecha_ult, 5, 2) & Mid(fecha_ult, 1, 4)
                ' End If
            Else ' CUANDO SON AVALES
                fecha_ult = Trim(drFisica("TLUltPago"))

                If fecha_ult = "" Then
                    ultpago_avio = Me.AviosTableAdapter.Scalarultpago(anexo)
                    If ultpago_avio = "" Then
                        fecha_ult = "01011900"
                    Else
                        fecha_ult = Mid(ultpago_avio, 7, 2) & Mid(ultpago_avio, 5, 2) & Mid(ultpago_avio, 1, 4)
                    End If
                    anexos = anexos & " / " & anexo
                    'fecha_ult = ultpago_avio
                End If
            End If
            '  Me.HistoriaTableAdapter.Fill(Me.BuroDS.Historia)
            Select Case taEmpleo.PromedioDias(drFisica("TLCuenCli"))
                Case 0
                    Select Case taEmpleo.PromedioDiasAV(drFisica("TLCuenCli"))
                        Case 0
                            cString = cString & "11" & "01" & "M"
                            tlplazoM = Trim(drFisica("TLPlazo")) * 1
                        Case 1 To 45
                            cString = cString & "11" & "01" & "M"
                            tlplazoM = Trim(drFisica("TLPlazo")) * 1
                        Case 46 To 80
                            cString = cString & "11" & "01" & "B"
                            tlplazoM = Trim(drFisica("TLPlazo")) * 2
                        Case 81 To 140
                            cString = cString & "11" & "01" & "Q"
                            tlplazoM = Trim(drFisica("TLPlazo")) * 3
                        Case 141 To 300
                            cString = cString & "11" & "01" & "H"
                            tlplazoM = Trim(drFisica("TLPlazo")) * 6
                        Case Else
                            cString = cString & "11" & "01" & "Y"
                            tlplazoM = Trim(drFisica("TLPlazo")) * 12
                    End Select
                Case 7
                    cString = cString & "11" & "01" & "W" 'semanal *6 .../30.4
                    tlplazoM = (Trim(drFisica("TLPlazo")) * 6) / 30.4

                Case 14
                    cString = cString & "11" & "01" & "K" 'catorcenal *14 .../30.4
                    tlplazoM = (Trim(drFisica("TLPlazo")) * 6) / 30.4

                Case 15 To 18
                    cString = cString & "11" & "01" & "S" 'quinc *15 .../30.4
                    tlplazoM = (Trim(drFisica("TLPlazo")) * 6) / 30.4

                Case 19 To 45
                    cString = cString & "11" & "01" & "M" 'mensual *1
                Case 46 To 80
                    cString = cString & "11" & "01" & "B" 'bimes *2
                Case 81 To 140
                    cString = cString & "11" & "01" & "Q" 'trim *3
                Case 141 To 300
                    cString = cString & "11" & "01" & "H" 'sem *6
                Case Else
                    cString = cString & "11" & "01" & "Y" 'anual *12
            End Select
            Dim RentaAux As Decimal = Round(drFisica("TLRenta") / Divisor, 2)
            nLongitud = Len(Trim(RentaAux))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "12" & cLongitud & Trim(RentaAux)
            '++++++RENTA Y PERIODICIDAD

            cString = cString & "13" & "08" & drFisica("TLApertura")
            nLongitud = Len(Trim(fecha_ult))
            ' nLongitud = Len(Trim(drFisica("TLUltPago")))

            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If

            cString = cString & "14" & cLongitud & fecha_ult




            'cString = cString & "14" & "00"

            cString = cString & "15" & "08" & drFisica("TLApertura")

            If drFisica("TLFechaFin") <> Space(8) Then
                cString = cString & "16" & "08" & drFisica("TLFechaFin")
            End If

            nLongitud = Len(Trim(drFisica("TLMoi")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "21" & cLongitud & Trim(drFisica("TLMoi"))

            nLongitud = Len(Trim(drFisica("TLSaldAct")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "22" & cLongitud & Trim(drFisica("TLSaldAct"))

            nLongitud = Len(Trim(drFisica("TLMoi")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "23" & cLongitud & Trim(drFisica("TLMoi"))
            'cString = cString & "2300" & "  "  ' limite de credito
            nSumaTLSaldAct += CDbl(Trim(drFisica("TLSaldAct")))

            ' El número de pagos vencidos así como su monto solo se especifican para las cuentas con atraso

            If drFisica("TLMop") <> "01" Then

                nLongitud = Len(Trim(drFisica("TLSaldVen")))
                If nLongitud < 10 Then
                    cLongitud = "0" + Trim(Str(nLongitud))
                Else
                    cLongitud = Trim(Str(nLongitud))
                End If
                cString = cString & "24" & cLongitud & Trim(drFisica("TLSaldVen"))
                ' cString = cString & "2400" & ""  ' limite de credito
                nSumaTLSaldVen += CDbl(Trim(drFisica("TLSaldVen")))

                nLongitud = Len(Trim(drFisica("TLSaldPag")))
                If nLongitud < 10 Then
                    cLongitud = "0" + Trim(Str(nLongitud))
                Else
                    cLongitud = Trim(Str(nLongitud))
                End If
                'cString = cString & "25" & cLongitud & Trim(drFisica("TLSaldPag"))
            Else
                cString = cString & "2400" & ""  ' limite de credito
            End If

            cString = cString & "26" & "02" & Trim(drFisica("TLMop"))

            If Trim(drFisica("TLObservacion")) <> "" Then
                cString = cString & "30" & "02" & Trim(drFisica("TLObservacion"))
            End If

            If drFisica("TLMop") <> "01" And drFisica("TLMop") <> "00" Then
                Dim anexofis As String = Replace(Replace(drFisica("TLCuenCli"), "/", ""), "-", "")
                Dim fecha_inc As String
                fecha_inc = Me.FacturasTableAdapter.ScalarFechaInc(anexofis)
                If fecha_inc = "" Then
                    Dim d As String = Me.AviosTableAdapter.fecinc2(anexofis)
                    Dim anio1 As String = Mid(d, 1, 4)
                    ' Returns "Demo".
                    Dim mes As String = Mid(d, 5, 2)
                    ' Returns "Function Demo".
                    Dim dia As String = Mid(d, 7, 2)
                    Dim fechainc = dia & mes & anio1

                    If fechainc = "00000000" Then
                        fecha_inc = "01011900"
                    Else
                        fecha_inc = fechainc
                    End If


                Else
                    fecha_inc = Mid(fecha_inc, 7, 2) & Mid(fecha_inc, 5, 2) & Mid(fecha_inc, 1, 4)

                End If


                cString = cString & "43" & "08" & fecha_inc
            Else
                cString = cString & "43" & "08" & "01011900" 'fecha de primer incumplimiento
            End If



            nLongitud = Len(Trim(drFisica("TLSaldAct")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "44" & cLongitud & Trim(drFisica("TLSaldAct"))

            nLongitud = Len(Trim(monto))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If

            If monto = 0 Then
                '    cString = cString & "4500" & "" 'monto ultimo pago
                cx = cx + 1
            Else
                '   cString = cString & "45" & cLongitud & monto 'monto ultimo pago
                c = c + 1
            End If
            cString = cString & "45" & "00"



            tlplazoM = Round(tlplazoM, 2)
            nLongitud = Len(Trim(Round(tlplazoM, 2)))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "50" & cLongitud & tlplazoM 'plazo en meses
            nLongitud = Len(Trim(drFisica("TLMoi")))
            If nLongitud < 10 Then
                cLongitud = "0" + Trim(Str(nLongitud))
            Else
                cLongitud = Trim(Str(nLongitud))
            End If
            cString = cString & "51" & cLongitud & Trim(drFisica("TLMoi"))

            If drFisica("TLCuenCli") = "00239/0011" Then
                Dim s As String = "ssss"
            End If
            cString = cString & "99" & "03" & "END"

        Next
        Dim cont1 As Integer = c
        Dim cont11 As Integer = cx
        anexos = anexos & ""

        nRegistros = dsAgil.Tables("Fisicas").Rows.Count

        ' SEGMENTO DE CIFRAS DE CONTROL (TR)

        cString = cString & "TRLR"
        cString = cString & Stuff(nSumaTLSaldAct.ToString, "I", "0", 14)
        cString = cString & Stuff(nSumaTLSaldVen.ToString, "I", "0", 14)
        cString = cString & "001"
        cString = cString & Stuff(nRegistros.ToString, "I", "0", 9)
        cString = cString & Stuff(nRegistros.ToString, "I", "0", 9)
        cString = cString & "000000000"
        cString = cString & Stuff(nRegistros.ToString, "I", "0", 9)
        cString = cString & "000000"
        cString = cString & Stuff("AGIL", "D", " ", 16)
        cString = cString & Stuff("LEANDRO VALLE 402 1er. PISO, COL. REFORMA Y FFCCNN, C.P. 50070, TOLUCA, ESTADO DE MEXICO", "D", " ", 160)

        oReporte = New StreamWriter("c:\Files\FISICAS.TXT", False, System.Text.Encoding.Default)
        Dim textAscii As New ASCIIEncoding()
        Dim contar As Integer
        contar = Ca
        cString = cString.Replace("Á", "A")
        cString = cString.Replace("É", "E")
        cString = cString.Replace("Í", "I")
        cString = cString.Replace("Ó", "O")
        cString = cString.Replace("Ú", "U")
        cString = cString.Replace(".", " ")
        cString = cString.Replace(",", " ")


        Dim encodedBytes As Byte() = textAscii.GetBytes(cString)
        Dim decodedString As String = textAscii.GetString(encodedBytes)
        decodedString = decodedString.Replace("?", "Ñ")
        oReporte.WriteLine(decodedString)
        oReporte.Close()

        cnAgil.Dispose()
        cm1.Dispose()
        Cursor.Current = Cursors.Default
        'MsgBox("Recuerda cambiar ? por Ñ", MsgBoxStyle.Information, "Mensaje del Sistema")
        MsgBox("Terminado", MsgBoxStyle.Information, "Mensaje del Sistema")

    End Sub

    Function PrimerNombre(ByVal Nom) As String
        Dim espacio As Integer = InStr(Nom, " ")
        If espacio = 0 Then
            PrimerNombre = Trim(Nom)
        Else
            PrimerNombre = Trim(Mid(Nom, 1, espacio))
        End If

        If PrimerNombre.Length > 26 Then
            PrimerNombre = Mid(PrimerNombre, 1, 26)
        Else
            PrimerNombre = PrimerNombre '& Space(26 - PrimerNombre.Length)
        End If
        Return Trim(PrimerNombre)
    End Function

    Function SegundoNombre(ByVal Nom As String) As String
        Dim espacio As Integer = InStr(Nom, " ")
        If espacio > 0 Then
            SegundoNombre = Trim(Mid(Nom, espacio, Nom.Length))
            If SegundoNombre.Length > 26 Then
                SegundoNombre = Mid(SegundoNombre, 1, 26)
            Else
                SegundoNombre = SegundoNombre '& Space(26 - SegundoNombre.Length)
            End If
        End If

        Return Trim(SegundoNombre)
    End Function

    Sub InsertaAvalesAvio()

        Dim cfecha As String = DTOC(dtpProceso.Value)
        Dim cfechaF As String = dtpProceso.Value.ToString("yyyy-MM-dd")
        Dim cFechaAnt As String = DTOC(dtpProceso.Value.AddDays(dtpProceso.Value.Day * -1))

        Dim cnAgil As New SqlConnection(strConn)
        Dim dsAgil As New DataSet()
        Dim cm7 As New SqlCommand()
        Dim cm8 As New SqlCommand()
        Dim cm9 As New SqlCommand()
        Dim drAvioCAS As DataRow
        Dim drAvio As DataRow
        Dim drAvioC As DataRow
        Dim daAviosCAS As New SqlDataAdapter(cm7)
        Dim daAvios As New SqlDataAdapter(cm8)
        Dim daAviosC As New SqlDataAdapter(cm9)
        'Stored procedure que trae los avios 

        With cm7
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BuroAvioCastigado"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters.Add("@FechaF", SqlDbType.NVarChar)
            .Parameters(0).Value = cfecha
            .Parameters(1).Value = cfechaF
        End With

        With cm8
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BuroAvio"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters.Add("@FechaF", SqlDbType.NVarChar)
            .Parameters(0).Value = cfecha
            .Parameters(1).Value = cfechaF
        End With

        'Stored procedure que trae los avios cerrados

        With cm9
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BuroAvioCerrado"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters.Add("@FechaAnt", SqlDbType.NVarChar)
            .Parameters(0).Value = cfecha
            .Parameters(1).Value = cFechaAnt
        End With

        'AVIO
        'aqui se llenan los datos de Avio

        ' ''daAviosCAS.Fill(dsAgil, "AviosCas")
        ' ''For Each drAvioCAS In dsAgil.Tables("AviosCas").Rows
        ' ''    AgregaAvalesAV(drAvioCAS("Anexo"), drAvioCAS("Ciclo"), drAvioCAS)
        ' ''Next

        daAvios.Fill(dsAgil, "Avios")
        For Each drAvio In dsAgil.Tables("Avios").Rows
            AgregaAvalesAV(drAvio("Anexo"), drAvio("Ciclo"), drAvio)
        Next

        daAviosC.Fill(dsAgil, "AviosC")
        For Each drAvioC In dsAgil.Tables("AviosC").Rows
            AgregaAvalesAV(drAvioC("Anexo"), drAvioC("Ciclo"), drAvioC)
        Next

    End Sub

    Sub InsertaAvales()
        If CmbDB.Text = "Production" Then
            StrConnX = "Server=" & My.Settings.ServidorPROD & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        Else
            StrConnX = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & CmbDB.Text & "; User ID=User_PRO; pwd=User_PRO2015"
        End If
        Dim cfecha As String = DTOC(dtpProceso.Value)
        Dim cfechaF As String = dtpProceso.Value.ToString("yyyy-MM-dd")
        Dim cFechaAnt As String = DTOC(dtpProceso.Value.AddDays(dtpProceso.Value.Day * -1))
        Dim cnAgil As New SqlConnection(StrConnX)
        Dim dsAgil As New DataSet()
        Dim cm8 As New SqlCommand()
        Dim cm9 As New SqlCommand()
        Dim drAvio As DataRow
        Dim daAvios As New SqlDataAdapter(cm8)

        'Stored procedure que trae los tradicionales 


        With cm8
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BuroTradicional"
            .Connection = cnAgil
            .Parameters.Add("@Fecha", SqlDbType.NVarChar)
            .Parameters.Add("@FechaF", SqlDbType.NVarChar)
            .Parameters(0).Value = cfecha
            .Parameters(1).Value = cfechaF
        End With



        'Tradicionales
        daAvios.Fill(dsAgil, "Tradicionales")
        Dim AnexoAux As String = ""
        For Each drAvio In dsAgil.Tables("Tradicionales").Rows
            If AnexoAux = drAvio("CRContrato") Then Continue For
            AgregaAvales(drAvio("CRContrato"), drAvio)
            AnexoAux = drAvio("CRContrato")
        Next

    End Sub

    Sub AgregaAvales(ByVal Anexo As String, ByRef rr As DataRow)
        Dim nEspacios, i As Integer
        Dim cNombre, cPaterno, cMaterno As String
        Dim newfrmPideNombre As frmPideNombre
        Dim strInsert As String
        Dim cm1 As New SqlCommand()
        Dim cTerConSaldo As String = "N"
        Dim cMop As String
        Dim nSaldVen As Decimal = 0
        Dim nSaldPag As Decimal = 0
        Dim cUltPago As String = ""
        Dim nSaldoEquipo As Decimal
        Dim nMoi As Decimal
        Dim nRenta As Decimal
        Dim nMeses As Decimal

        Anexo = Mid(Anexo, 1, 5) & Mid(Anexo, 7, 4)
        TAval.FillByFisicas(Tav, Anexo)

        For Each r1 In Tav.Rows
            SacaTLtipoContrato(r1.Tipar, r1.FechaCon, TLtipoContrato)
            TAvalDat.Fill(TavDaT, r1.Cliente)
            rx = TavDaT.Rows(TavDaT.Rows.Count - 1)
            If rx.Calle.Trim = "" Or rx.Colonia.Trim = "" Then
                Continue For
            End If
            If TAval.EsAccionista(rx.RFC.Trim) > 0 Then
                Continue For
            End If

            If IsDBNull(rx.DescPlaza) Then
                rx.DescPlaza = "ESTADO DE MEXICO"
                rx.Abreviado = "EM"
            End If
            If rx.DescPlaza.Trim = "VERACRUZ" Then
                rx.DescPlaza = "VERACRUZ DE IGNACIO DE LA LLAVE"
                rx.Abreviado = "VER"
            End If


            If rx.RFC.Trim = "AAPL650710CB1" Or IsDBNull(rx.DescPlaza) Then
                rx.RFC = "AAPL650710CB1"
            End If

            nEspacios = 0
            For i = 1 To Len(rx.Descr.Trim())
                If Mid(rx.Descr.Trim(), i, 1) = " " Then
                    nEspacios += 1
                End If
            Next

            If nEspacios = 2 Then

                cNombre = ""
                i = 1
                While Mid(rx.Descr.Trim(), i, 1) <> " "
                    cNombre += Mid(rx.Descr.Trim(), i, 1)
                    i += 1
                End While
                i += 1

                cPaterno = ""
                While Mid(rx.Descr.Trim(), i, 1) <> " "
                    cPaterno += Mid(rx.Descr.Trim(), i, 1)
                    i += 1
                End While
                i += 1

                cMaterno = ""
                While i <= Len(rx.Descr.Trim())
                    cMaterno += Mid(rx.Descr.Trim(), i, 1)
                    i += 1
                End While

            End If

            If nEspacios = 1 Or nEspacios > 3 Then
                newfrmPideNombre = New frmPideNombre("M", rx.Descr.Trim(), rx.Cliente)
                newfrmPideNombre.ShowDialog()
                cNombre = newfrmPideNombre.Nombre
                cPaterno = newfrmPideNombre.Paterno
                cMaterno = newfrmPideNombre.Materno
            End If

            If nEspacios = 3 Then

                cNombre = ""
                i = 1
                While Mid(rx.Descr.Trim(), i, 1) <> " "
                    cNombre += Mid(rx.Descr.Trim(), i, 1)
                    i += 1
                End While
                i += 1
                cNombre += " "

                While Mid(rx.Descr.Trim(), i, 1) <> " "
                    cNombre += Mid(rx.Descr.Trim(), i, 1)
                    i += 1
                End While
                i += 1

                cPaterno = ""
                While Mid(rx.Descr.Trim(), i, 1) <> " "
                    cPaterno += Mid(rx.Descr.Trim(), i, 1)
                    i += 1
                End While
                i += 1

                cMaterno = ""
                While i <= Len(rx.Descr.Trim())
                    cMaterno += Mid(rx.Descr.Trim(), i, 1)
                    i += 1
                End While

                If Len(cPaterno) < 4 Then
                    nEspacios = 2
                End If

            End If

            cPaterno = Mid(cPaterno, 1, 25)
            cMaterno = Mid(cMaterno, 1, 25)
            cNombre = Mid(cNombre, 1, 25)

            If rr("Flcan") = "A" Then
                cUltPago = rr("CRApertura")
            ElseIf rr("Flcan") = "T" Then
                cUltPago = rr("CRFechaFin")
            End If

            If cUltPago = "" Then
                Dim pago As String = "ssss"
            End If

            nSaldVen = rr("CRSaldoInsoluto")
            nSaldoEquipo = rr("CRSaldoInsoluto")
            nMoi = rr("CRMoi")
            nRenta = rr("CRPago")
            nSaldPag = 1
            If rr("DERetraso") <= 5 Then
                cMop = "01"
                nSaldVen = 0
                nSaldPag = 0
                cUltPago = ""
            ElseIf rr("DERetraso") > 5 And rr("DERetraso") < 30 Then
                cMop = "02"
            ElseIf rr("DERetraso") >= 30 And rr("DERetraso") < 60 Then
                cMop = "03"
            ElseIf rr("DERetraso") >= 60 And rr("DERetraso") < 90 Then
                cMop = "04"
            ElseIf rr("DERetraso") >= 90 And rr("DERetraso") < 120 Then
                cMop = "05"
            ElseIf rr("DERetraso") >= 120 And rr("DERetraso") < 150 Then
                cMop = "06"
            ElseIf rr("DERetraso") >= 150 And rr("DERetraso") < 366 Then
                cMop = "07"
            ElseIf rr("DERetraso") >= 366 Then
                cMop = "96"
            End If
            ''cString = cString & vbCrLf

            strInsert = "INSERT INTO Fisicas(PNPaterno, PNMaterno, PNNombre, PNRfc, PACalle, PAColonia, PADelega, PACiudad, PAEstado, PACP, TLCuenCli, TLPlazo, TLRenta, TLApertura, TLUltPago, TLFechaFin, TLMoi, TLSaldAct, TLSaldVen, TLSaldPag, TLMop, Flcan, TerConSaldo, Cliente,TLtipoRespon,TLtipoContrato)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & cPaterno & "', '"
            strInsert = strInsert & cMaterno & "', '"
            strInsert = strInsert & cNombre & "', '"
            strInsert = strInsert & rx.RFC & "', '"
            strInsert = strInsert & rx.Calle.Substring(0, 39) & "', '"
            strInsert = strInsert & rx.Colonia & "', '"
            strInsert = strInsert & rx.Delegacion.Substring(0, 39) & "', '"
            strInsert = strInsert & rx.DescPlaza & "', '"
            strInsert = strInsert & rx.Abreviado & "', '"
            strInsert = strInsert & rx.Copos & "', '"
            strInsert = strInsert & Mid(Anexo, 1, 5) & "/" & Mid(Anexo, 6, 4) & "', '"
            strInsert = strInsert & "1', '"
            strInsert = strInsert & Round(nRenta, 0).ToString & "', '"
            strInsert = strInsert & rr("CRApertura") & "', '"
            strInsert = strInsert & cUltPago & "', '"
            strInsert = strInsert & "', '" ' no se pone fecha de cierre
            strInsert = strInsert & Round(nMoi, 0).ToString & "', '"
            strInsert = strInsert & Round(nSaldoEquipo, 0).ToString & "', '"
            strInsert = strInsert & Round(nSaldVen, 0).ToString & "', '"
            strInsert = strInsert & Round(nSaldPag, 0).ToString & "', '"
            strInsert = strInsert & cMop & "', '"
            strInsert = strInsert & rr("Flcan") & "', '"
            If rr("Flcan") = "T" Then cTerConSaldo = "S" Else cTerConSaldo = "N"
            strInsert = strInsert & cTerConSaldo & "', '"
            strInsert = strInsert & rr("EMNumCli") & "',"
            strInsert = strInsert & "'C', '" & TLtipoContrato & "'"
            strInsert = strInsert & ")"
            cnAgil.Open()
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()
            cnAgil.Close()
        Next
    End Sub

    Sub AgregaAvalesAV(ByVal Anexo As String, ByVal Ciclo As String, ByRef r As DataRow)
        Dim nEspacios, i As Integer
        Dim cNombre, cPaterno, cMaterno As String
        Dim newfrmPideNombre As frmPideNombre
        Dim strInsert As String
        Dim cm1 As New SqlCommand()
        Dim cTerConSaldo As String = "N"
        Dim cMop As String
        Dim nSaldVen As Decimal = 0
        Dim nSaldPag As Decimal = 0
        Dim cUltPago As String = ""
        Dim nSaldoEquipo As Decimal
        Dim nMoi As Decimal
        Dim nRenta As Decimal
        Dim nMeses As Integer = 0


        Anexo = Mid(Anexo, 1, 5) & Mid(Anexo, 7, 4)
        TAval.FillByCicloFisicas(Tav, Anexo, Ciclo)

        For Each r1 In Tav.Rows
            SacaTLtipoContrato(r1.Tipar, r1.FechaCon, TLtipoContrato)
            TAvalDat.Fill(TavDaT, r1.Cliente)
            rx = TavDaT.Rows(TavDaT.Rows.Count - 1)
            If rx.Calle.Trim = "" And rx.Colonia.Trim = "" Then
                Continue For
            End If
            If TAval.EsAccionista(rx.RFC.Trim) > 0 Then
                Continue For
            End If
            If IsDBNull(rx.DescPlaza) Then
                rx.DescPlaza = "ESTADO DE MEXICO"
                rx.Abreviado = "EM"
            End If

            If rx.RFC.Trim = "AAPL650710CB1" Or IsDBNull(rx.DescPlaza) Then
                rx.RFC = "AAPL650710CB1"
            End If

            newfrmPideNombre = New frmPideNombre("M", rx.Descr.Trim(), rx.Cliente)
            newfrmPideNombre.ShowDialog()
            cNombre = newfrmPideNombre.Nombre
            cPaterno = newfrmPideNombre.Paterno
            cMaterno = newfrmPideNombre.Materno

            cPaterno = Mid(cPaterno, 1, 25)
            cMaterno = Mid(cMaterno, 1, 25)

            If r("Flcan") = "A" Then
                cUltPago = CDate(r("Fecha Inicio")).ToString("ddMMyyyy")
            ElseIf r("Flcan") = "T" Then
                cUltPago = CDate(r("FechaTerminacion")).ToString("ddMMyyyy")
            End If

            nSaldVen = r("saldo")
            nSaldoEquipo = r("saldo")
            nMoi = r("LineaActual")
            nRenta = r("saldo")
            nSaldPag = 1
            If r("Retraso") <= 0 Then
                cMop = "01"
                nSaldVen = 0
                nSaldPag = 0
                cUltPago = ""
            ElseIf r("Retraso") >= 1 And r("Retraso") < 30 Then
                cMop = "02"
            ElseIf r("Retraso") >= 30 And r("Retraso") < 60 Then
                cMop = "03"
            ElseIf r("Retraso") >= 60 And r("Retraso") < 90 Then
                cMop = "04"
            ElseIf r("Retraso") >= 90 And r("Retraso") < 120 Then
                cMop = "05"
            ElseIf r("Retraso") >= 120 And r("Retraso") < 150 Then
                cMop = "06"
            ElseIf r("Retraso") >= 150 And r("Retraso") < 366 Then
                cMop = "07"
            ElseIf r("Retraso") >= 366 Then
                cMop = "96"
            End If
            ''cString = cString & vbCrLf

            strInsert = "INSERT INTO Fisicas(PNPaterno, PNMaterno, PNNombre, PNRfc, PACalle, PAColonia, PADelega, PACiudad, PAEstado, PACP, TLCuenCli, TLPlazo, TLRenta, TLApertura, TLUltPago, TLFechaFin, TLMoi, TLSaldAct, TLSaldVen, TLSaldPag, TLMop, Flcan, TerConSaldo, Cliente,TLtipoRespon,TLtipoContrato)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & cPaterno & "', '"
            strInsert = strInsert & cMaterno & "', '"
            strInsert = strInsert & cNombre & "', '"
            strInsert = strInsert & rx.RFC & "', '"
            strInsert = strInsert & rx.Calle.Substring(0, 39) & "', '"
            strInsert = strInsert & rx.Colonia & "', '"
            strInsert = strInsert & rx.Delegacion.Substring(0, 39) & "', '"
            strInsert = strInsert & rx.DescPlaza & "', '"
            strInsert = strInsert & rx.Abreviado & "', '"
            strInsert = strInsert & rx.Copos & "', '"
            strInsert = strInsert & Mid(Anexo, 1, 5) & "/" & Mid(Anexo, 6, 4) & "', '"
            strInsert = strInsert & "1', '"
            strInsert = strInsert & Round(nRenta, 0).ToString & "', '"
            strInsert = strInsert & CDate(r("Fecha Inicio")).ToString("ddMMyyyy") & "', '"
            strInsert = strInsert & cUltPago & "', '"
            strInsert = strInsert & "', '" ' no se pone fecha de cierre
            strInsert = strInsert & Round(nMoi, 0).ToString & "', '"
            strInsert = strInsert & Round(nSaldoEquipo, 0).ToString & "', '"
            strInsert = strInsert & Round(nSaldVen, 0).ToString & "', '"
            strInsert = strInsert & Round(nSaldPag, 0).ToString & "', '"
            strInsert = strInsert & cMop & "', '"
            strInsert = strInsert & r("Flcan") & "', '"
            If r("Flcan") = "T" Then cTerConSaldo = "S" Else cTerConSaldo = "N"
            strInsert = strInsert & cTerConSaldo & "', '"
            strInsert = strInsert & r("Cliente") & "',"
            strInsert = strInsert & "'C', '" & TLtipoContrato & "'"
            strInsert = strInsert & ")"
            cnAgil.Open()
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()
            cnAgil.Close()
        Next
    End Sub

    Private Sub frmFisicas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AviosTableAdapter.Fill(Me.BuroDS.Avios)
        MessageBox.Show("Recuerda Correr primero personas Morales", "Buro de Credito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim t As New DataTable
        Dim r As DataRow
        t.Columns.Add("ID")
        t.Columns.Add("TIT")
        Dim Fecha As Date = Date.Now
        r = t.NewRow
        r("ID") = Date.Now.ToString("yyyyMM01")
        r("TIT") = "Production"
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
        CmbDB.SelectedIndex = 0
        dtpProceso.Value = CTOD(CmbDB.SelectedValue)
        CmbDB_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub CmbDB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDB.SelectedIndexChanged
        If CmbDB.SelectedIndex >= 0 And CmbDB.ValueMember <> "" Then
            dtpProceso.Value = CTOD(CmbDB.SelectedValue)
            If CmbDB.Text = "Production" Then
                dtpProceso.Enabled = True
                CheckParcial.Checked = True
                dtpProceso.Value = Date.Now.Date
            Else
                dtpProceso.Enabled = False
                CheckParcial.Checked = False
            End If
        End If
    End Sub

    Sub SacaTLtipoContrato(Tipar As String, FecCon As String, ByRef TLtipoContrato As String)
        If FecCon >= "20190401" Then ' abril 2019 ya se reportan correctamente
            Select Case Tipar
                Case "L"
                    TLtipoContrato = "PL"
                Case "P", "F"
                    TLtipoContrato = "LS"
                Case "S"
                    TLtipoContrato = "CS"
                Case "R"
                    TLtipoContrato = "EQ"
                Case "H"
                    TLtipoContrato = "HA"
                Case "C"
                    TLtipoContrato = "CS"
                Case Else
                    TLtipoContrato = "CS"
            End Select
        Else
            TLtipoContrato = "LS"
        End If
    End Sub

    Sub EliminaInfoSinPagos()
        Dim Anexo As String = ""
        Dim Aux As String = ""
        Dim FechaIni As String = ""
        Dim FechaFin As String = ""
        Dim ta As New BuroDSTableAdapters.FisicasTableAdapter
        FechaIni = dtpProceso.Value.AddDays(-7).ToString("yyyyMMdd")
        FechaFin = dtpProceso.Value.ToString("yyyyMMdd")

        ta.Fill(BuroDS.Fisicas)
        For Each r As BuroDS.FisicasRow In BuroDS.Fisicas.Rows
            If Aux <> r.TLCuenCli Then
                Anexo = r.TLCuenCli.Replace("-", "").Trim
                Anexo = Anexo.Replace("/", "").Trim
                Aux = r.TLCuenCli
                If ta.PagosTRA(FechaIni, FechaFin, Anexo) <= 0 Then
                    r.Delete()
                End If
            Else
                Aux = r.TLCuenCli
            End If
        Next
        BuroDS.MoraDeta.GetChanges()
        ta.Update(BuroDS.Fisicas)
    End Sub

End Class
