Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop
Imports System.Security
Imports System.Security.Principal.WindowsIdentity

Public Class frmImpCtoAvio

    ' Declaraci�n de variables de datos de alcance privado
    Dim Cultivos As New GeneralDSTableAdapters.CultivosTableAdapter
    Dim cAnexo As String = ""
    Dim cAval1 As String = ""
    Dim cAval2 As String = ""
    Dim cAval3 As String = ""
    Dim cAval4 As String = ""
    Dim cAval1b As String = ""
    Dim cAval2b As String = ""
    Dim cAval3b As String = ""
    Dim cAval4b As String = ""
    Dim cAvales As String = ""
    Dim cCiclo As String = ""
    Dim cCliente As String = ""
    Dim cTipo As String = ""
    Dim cRepresentante As String = ""
    Dim cRepresentante2 As String = ""
    Dim cRepresentante1 As String = ""
    Dim cParrafoRepres As String = ""
    Dim cEncabezado As String = ""
    Dim cEncabezado2 As String = ""
    Dim cFirmaAval1 As String = ""
    Dim cFirmaAval2 As String = ""
    Dim cFirmaAval3 As String = ""
    Dim cFirmaAval4 As String = ""
    Dim cFirmaTestigo1 As String = ""
    Dim cFirmaTestigo2 As String = ""
    Dim cFirmaFINAGIL As String = ""
    Dim cEmpcv As String = ""
    Dim cLugar As String = ""
    Dim cTestigos As String = ""
    Dim cSucursal As String = ""
    Dim cNuevoNombre As String
    Dim cDescr As String = ""
    Dim cRfc As String
    Dim cCalle As String
    Dim cColonia As String
    Dim cCopos As String
    Dim cDelegacion As String
    Dim cEstado As String
    Dim cComision As String = ""
    Dim cInmuebles As String = "NO APLICA"
    Dim cMuebles As String = "NO APLICA"
    Dim cUsufructo As String = "NO APLICA"
    Dim cGeneClie As String
    Dim cCantidad As String
    Dim cFirmaRegistrador As String = ""
    Dim cApliGarLIQ As String = ""
    Dim cImporte As String
    Dim cDiferencialFINAGIL As String
    Dim cFechaAutorizacion As String
    Dim cFechaTermino As String
    Dim cFechaFirma As String = ""
    Dim cPredios As String
    Dim cParrafoHipoteca As String
    Dim cParrafoPrenda As String
    Dim cGravamen As String = ""
    Dim nHectareas As Decimal = 0
    Dim nToneladas As Decimal = 0
    Dim nRendimiento As Decimal = 0
    Dim cRendimiento As String = "0"
    Dim nImporte As Decimal = 0
    Dim nMontoInv As Decimal = 0
    Dim nAportInv As Decimal = 0
    Dim nLineaMax As Decimal = 0
    Dim nCostoMaxHa As Decimal = 0
    Dim nPorcomi As Decimal = 0
    Dim nPorcFEGA As Decimal = 0
    Dim nCAT As Decimal = 0
    Dim nVMUdi As Decimal = 900000.0
    Dim nUdi As Decimal = 0
    Dim cGarantiaHipotecaria As String = ""
    Dim cGarantiaPrendaria As String = ""
    Dim cGarantiaUsufructo As String = ""
    Dim cHectareas As String = "0"
    Dim cToneladas As String = "0"
    Dim cLeyendaRegistrador As String = ""
    Dim cLeyendaNotario As String = ""
    Dim cDatosAval As String = ""
    Dim cSemilla As String = ""
    Dim cUnidadEsp As String = ""
    Dim cFirman As String = ""
    Dim cOtros As String = ""
    Dim cAgroquimi As String = ""
    Dim cAgroquimi2 As String = ""
    Dim cGarPrend As String = ""
    Dim cGarHipot As String = ""
    Dim cGarantias As String = ""
    Dim cPirineos As String = ""
    Dim cC_Venta As String = ""
    Dim cC_Venta2 As String = ""
    Dim cCtoC_Venta As String = ""
    Dim cTrianual As String = ""
    Dim cPrimera As String = ""
    Dim cSegunda As String = ""
    Dim cDescCiclo As String = ""
    Dim cFechaSiembra As String = ""
    Dim cFechaCosecha As String = ""
    Dim cGenA1 As String = ""
    Dim cGenA2 As String = ""
    Dim cGenA3 As String = ""
    Dim cGenA4 As String = ""
    Dim cPodA1 As String = ""
    Dim cPodA2 As String = ""
    Dim cPodA3 As String = ""
    Dim cPodA4 As String = ""
    Dim cVenA�o2 As String = ""
    Dim cVenA�o3 As String = ""
    Dim cCiclo2 As String = ""
    Dim cCiclo3 As String = ""
    Dim cFSiembra2 As String = ""
    Dim cFSiembra3 As String = ""
    Dim cFCosecha2 As String = ""
    Dim cFCosecha3 As String = ""
    Dim cFLimite2 As String = ""
    Dim cFLimite3 As String = ""
    Dim cFTermino2 As String = ""
    Dim cFTermino3 As String = ""
    Dim cCURP As String = ""
    Dim cGaranteHip As String = ""
    Dim cGarantePre As String = ""
    Dim cGtoAdmin As String = ""
    Dim cFactorGA As String = ""
    Dim cDescCiclo2 As String = ""
    Dim cFertilizante As String = ""
    Dim cHerbicidas As String = ""
    Dim cCiclod1 As String = ""
    Dim cCiclod2 As String = ""
    Dim cCiclod3 As String = ""
    Dim cGarliq As String = ""
    Dim cReca As String = "N/A"
    Dim nPlazoCred As Integer
    Dim nTaspen As Decimal
    Dim cNum As String
    Dim cNum1 As String
    Dim cNum2 As String
    Dim cParafin As String
    Dim nContratoMarco As Double
    Dim cFondeo As String

    Dim myIdentity As Principal.WindowsIdentity
    Dim cUsuario As String
    Dim HCsol As Boolean
    Dim oWord As Word.Application
    Dim oWordDoc As Microsoft.Office.Interop.Word.Document

    Public Sub New(ByVal cLinea As String)

        MyBase.New()

        'This call is required by the Windows Form Designer.

        InitializeComponent()

        cAnexo = Mid(cLinea, 1, 10)
        txtAnexo.Text = Mid(cLinea, 1, 10)

        If Mid(cLinea, 12, 6) = "PAGARE" Then
            Me.Text = "Impresi�n del Cr�dito en Cuenta Corriente " & Mid(cLinea, 1, 10)
        Else
            Me.Text = "Impresi�n del Contrato de Av�o " & Mid(cLinea, 1, 10)
        End If

        cAnexo = Mid(cLinea, 1, 5) & Mid(cLinea, 7, 4)
        If Mid(cLinea, 12, 6) = "PAGARE" Then
            cCiclo = Mid(cLinea, 19, 2)
        Else
            cCiclo = Mid(cLinea, 18, 2)
        End If

    End Sub

    Private Sub frmImpCtoAvio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Declaraci�n de variables de conexi�n ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim cm5 As New SqlCommand()
        Dim cm6 As New SqlCommand()
        Dim daDatos As New SqlDataAdapter(cm1)
        Dim daTiie As New SqlDataAdapter(cm2)
        Dim daCiclos As New SqlDataAdapter(cm3)
        Dim daGtoAd As New SqlDataAdapter(cm4)
        Dim daCultivo As New SqlDataAdapter(cm5)
        Dim daUdi As New SqlDataAdapter(cm6)

        Dim dsAgil As New DataSet
        Dim drDato As DataRow
        Dim drTiie As DataRow
        Dim drCiclo As DataRow
        Dim drGtoAd As DataRow
        Dim drUdi As DataRow

        Dim nCultivo As Integer

        myIdentity = GetCurrent()
        cUsuario = myIdentity.Name

        If Mid(Me.Text, 15, 16) = "Contrato de Av�o" Then

            With cm1
                .CommandType = CommandType.Text
                .CommandText = "SELECT Avios.*, Clientes.*, DescPlaza FROM Avios " &
                               "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " &
                               "INNER JOIN Plazas ON Clientes.Plaza = Plazas.Plaza " &
                               "WHERE Anexo = " & "'" & cAnexo & "'" & " AND Ciclo = " & "'" & cCiclo & "'"
                .Connection = cnAgil
            End With

            ' Llenar el dataset lo cual abre y cierra la conexi�n

            daDatos.Fill(dsAgil, "Datos")

            drDato = dsAgil.Tables("Datos").Rows(0)
            cCliente = drDato("Cliente")
            cDescr = Trim(drDato("Descr"))
            cGenA1 = Trim(drDato("Generepr"))
            cPodA1 = Trim(drDato("Poderepr"))
            cGenA2 = Trim(drDato("Generep2"))
            cPodA2 = Trim(drDato("Poderep2"))
            cGenA3 = Trim(drDato("Genercoa"))
            cPodA3 = Trim(drDato("Podercoa"))
            cGenA4 = Trim(drDato("GenerObl"))
            cPodA4 = Trim(drDato("PoderObl"))
            cVenA�o2 = Trim(drDato("FechaTermino2"))
            cVenA�o3 = Trim(drDato("FechaTermino3"))
            cCiclo2 = Trim(drDato("SegundoCiclo"))
            cCiclo3 = Trim(drDato("TercerCiclo"))
            cFSiembra2 = Trim(drDato("FechaSiembra2"))
            cFSiembra3 = Trim(drDato("FechaSiembra3"))
            cFCosecha2 = Trim(drDato("FechaCosecha2"))
            cFCosecha3 = Trim(drDato("FechaCosecha3"))
            cFLimite2 = Trim(drDato("FechaLimiteDTC2"))
            cFLimite3 = Trim(drDato("FechaLimiteDTC3"))
            cFTermino2 = drDato("FechaTermino2")
            cFTermino3 = drDato("FechaTermino3")
            nContratoMarco = Val(drDato("ContratoMarco"))
            nPorcFEGA = (drDato("PorcFega"))
            If nPorcFEGA = 0 Then
                nPorcFEGA = PORC_FEGA
            End If
            cGarliq = drDato("AplicaGarantiaLIQ")
            TxtContMarco.Text = SacaContratoMarcoLargo(nContratoMarco, cAnexo)
            cTipo = Trim(drDato("Tipo"))
            cRfc = drDato("Rfc")
            cCURP = drDato("CURP")
            cCalle = Trim(drDato("Calle"))
            cColonia = Trim(drDato("Colonia"))
            cCopos = drDato("Copos")
            cDelegacion = Trim(drDato("Delegacion"))
            cEstado = Trim(drDato("Estado"))
            cGeneClie = Replace(drDato("GeneClie"), Chr(13) + Chr(10), "")
            cApliGarLIQ = drDato("AplicaGarantiaLIQ")
            nHectareas = drDato("HectareasActual")
            nImporte = drDato("LineaActual")
            nCAT = drDato("CAT")
            nTaspen = drDato("Taspen")
            If cSemilla = "A" Then
                nAportInv = Round((nImporte / 0.685565) - nImporte, 2)
                nMontoInv = Round(nImporte + nAportInv, 2)
            Else
                nAportInv = Round((nImporte / 0.8) - nImporte, 2)
                nMontoInv = Round(nImporte + nAportInv, 2)
            End If
            'nCostoMaxHa = drDato("CostoMaxHa")
            'nLineaMax = drDato("LineaMax")
            cImporte = FormatNumber(nImporte).ToString
            cCantidad = Letras(nImporte)
            cDiferencialFINAGIL = drDato("DiferencialFINAGIL").ToString
            cPredios = drDato("Predios").ToString
            cFechaAutorizacion = Trim(drDato("FechaAutorizacion"))
            cFechaTermino = Trim(drDato("FechaTerminacion"))
            cRepresentante1 = Trim(drDato("Nomrepr"))
            cRepresentante2 = Trim(drDato("Nomrepr2"))
            cSemilla = drDato("Semilla")
            cSucursal = drDato("Sucursal")
            cGarPrend = drDato("GarantiaPrendaria")
            cGarHipot = drDato("GarantiaHipotecaria")
            cParafin = drDato("Parafin")
            cCiclo = drDato("Ciclo")
            cGaranteHip = drDato("GaranteHip")
            cGarantePre = drDato("GarantePre")

            If Trim(cGaranteHip) = "" And Trim(cGarantePre) = "" Then
                txtGHipotecario.ReadOnly = False
                txtGPrendario.ReadOnly = False
            Else
                txtGHipotecario.Text = Trim(cGaranteHip)
                txtGHipotecario.ReadOnly = True
                txtGPrendario.Text = Trim(cGarantePre)
                txtGPrendario.ReadOnly = True
            End If

            cFechaSiembra = "DEL " & Mes(drDato("FechaSiembrai")) & " AL " & Mes(drDato("FechaSiembraf"))
            'If cFSiembra2 <> "" Then
            '    cFechaSiembra = cFechaSiembra & ", " & cFSiembra2
            'End If
            'If cFSiembra3 <> "" Then
            '    cFechaSiembra = cFechaSiembra & ", " & cFSiembra3
            'End If
            cFechaCosecha = "DEL " & Mes(drDato("FechaCosechai")) & " AL " & Mes(drDato("Fechacosechaf"))
            'If cFCosecha2 <> "" Then
            '    cFechaCosecha = cFechaCosecha & ", " & cFCosecha2
            'End If
            'If cFCosecha3 <> "" Then
            '    cFechaCosecha = cFechaCosecha & ", " & cFCosecha3
            'End If
            cComision = "N/A"

            If cParafin = "S" Then
                Label12.Visible = True
                txtPorcomi.Visible = True
                txtPorcomi.Text = drDato("Porcomi")
            End If

            If Trim(drDato("FechaContrato")) <> "" Then
                cFechaFirma = drDato("FechaContrato")
                DateTimePicker1.Value = CTOD(drDato("FechaContrato"))
            Else
                cFechaFirma = DTOC(DateTimePicker1.Value)
            End If

            If Trim(drDato("FechaLimiteDTC")) <> "" Then
                DateTimePicker2.Value = CTOD(drDato("FechaLimiteDTC"))
            End If

            With cm3
                .CommandType = CommandType.Text
                .CommandText = "SELECT Ciclos.* FROM Ciclos WHERE Ciclo = " & "'" & cCiclo & "'"
                .Connection = cnAgil
            End With
            daCiclos.Fill(dsAgil, "Ciclos")

            drCiclo = dsAgil.Tables("Ciclos").Rows(0)
            cCiclod1 = drCiclo("DescCiclo")
            If cCiclo2 <> "" Then
                cCiclod2 = Mid(drCiclo("DescCiclo"), 1, 4) & " " & drDato("SegundoCiclo")
            End If
            If cCiclo3 <> "" Then
                cCiclod3 = Mid(drCiclo("DescCiclo"), 1, 4) & " " & drDato("TercerCiclo")
            End If
            If Mid(drCiclo("DescCiclo"), 1, 4) = "P.V." Then
                If cSemilla <> "A" Then
                    cDescCiclo = "Primavera-Verano " & Trim(Mid(drCiclo("DescCiclo"), 6, 4))
                    cDescCiclo2 = "Primavera-Verano " & Trim(Mid(drCiclo("DescCiclo"), 6, 4))
                Else
                    cDescCiclo = "Primavera-Verano " & Trim(Mid(drCiclo("DescCiclo"), 6, 4)) & "-" & Trim(Mid(drCiclo("DescCiclo"), 6, 4))
                    cDescCiclo2 = "Primavera-Verano " & Trim(Mid(drCiclo("DescCiclo"), 6, 4)) & "-" & Trim(Mid(drCiclo("DescCiclo"), 6, 4))
                End If
                If cCiclo2 <> "" Then
                    If cSemilla <> "A" Then
                        cDescCiclo = cDescCiclo & ", Primavera-Verano " & cCiclo2
                        cDescCiclo2 = cDescCiclo2 & ". A partir de los ciclos Primavera-Verano " & cCiclo2
                    Else
                        cDescCiclo = cDescCiclo & ". A partir de los ciclos Primavera-Verano " & cCiclo2 & "-" & cCiclo2
                    End If
                End If
                If cCiclo3 <> "" Then
                    If cSemilla <> "A" Then
                        cDescCiclo = cDescCiclo & ", Primavera-Verano " & cCiclo3
                        cDescCiclo2 = cDescCiclo2 & " y Primavera-Verano " & cCiclo3
                    Else
                        cDescCiclo = cDescCiclo & ", Primavera-Verano " & cCiclo3 & "-" & cCiclo3
                        cDescCiclo2 = cDescCiclo2 & " y Primavera-Verano " & cCiclo3 & "-" & cCiclo3
                    End If
                End If
            Else
                cDescCiclo = "Oto�o-Invierno " & Trim(Mid(drCiclo("DescCiclo"), 6, 9))
                cDescCiclo2 = "Oto�o-Invierno " & Trim(Mid(drCiclo("DescCiclo"), 6, 9))
                If cCiclo2 <> "" Then
                    cDescCiclo = cDescCiclo & ", Oto�o-Invierno " & cCiclo2
                    cDescCiclo2 = cDescCiclo2 & ". A partir de los ciclos Oto�o-Invierno " & cCiclo2
                End If
                If cCiclo3 <> "" Then
                    cDescCiclo = cDescCiclo & ", Oto�o-Invierno " & cCiclo3
                    cDescCiclo2 = cDescCiclo2 & " y Oto�o-Invierno " & cCiclo3
                End If
            End If

            Dim nMeses As Integer
            Dim n As Integer
            Dim nDiasInt As Integer
            Dim nBaseImp As Decimal
            Dim nTasas As Decimal
            Dim nInteres As Decimal
            Dim nTIR As Decimal
            Dim cFechai As String
            Dim cFechaf As String

            nMeses = DateDiff(DateInterval.Month, CTOD(cFechaAutorizacion), CTOD(cFechaTermino)) + 1
            nBaseImp = Round(nImporte / nMeses, 2)

            'Procedemos a llenar el arreglo para el c�lculo de TIR
            Dim Valores(nMeses + 1) As Double
            Dim Guess As Double

            With cm2
                .CommandType = CommandType.Text
                .CommandText = "SELECT Valor FROM Hista WHERE Vigencia = '" & cFechaAutorizacion & "'"
                .Connection = cnAgil
            End With
            daTiie.Fill(dsAgil, "Tiie")

            With cm6
                .CommandType = CommandType.Text
                .CommandText = "SELECT Udi FROM Udis WHERE Vigencia = " & "'" & cFechaAutorizacion & "'"
                .Connection = cnAgil
            End With
            daUdi.Fill(dsAgil, "Udi")

            If dsAgil.Tables("Udi").Rows.Count <= 0 Then
                MessageBox.Show("Falta capturar UDI", "UDI", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Dispose()
                Exit Sub
            Else
                drUdi = dsAgil.Tables("Udi").Rows(0)
                nUdi = drUdi("Udi")
            End If


            ''If dsAgil.Tables("Tiie").Rows.Count <= 0 Then
            ''    MessageBox.Show("Falta capturar TIIE, favor de reportar a tesoreria.", "TIIE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ''    Me.Dispose()
            ''    Exit Sub
            ''Else
            ''    drTiie = dsAgil.Tables("Tiie").Rows(0)
            ''    nTasas = drTiie("Valor") + Val(cDiferencialFINAGIL)
            ''End If

            ''Valores(0) = -nImporte
            ''For n = 1 To nMeses
            ''    If n = 1 Then
            ''        cFechai = cFechaAutorizacion
            ''        cFechaf = DTOC(DateSerial(Year(CTOD(cFechai)), Month(CTOD(cFechai)) + 1, 0))
            ''        nDiasInt = DateDiff(DateInterval.Day, CTOD(cFechai), CTOD(cFechaf))
            ''        nInteres = Round(((nImporte * nTasas / 100) / 360) * nDiasInt, 2)
            ''        Valores(n) = nBaseImp + nInteres
            ''    End If
            ''    cFechai = cFechaf
            ''    cFechaf = DTOC(DateAdd(DateInterval.Day, 1, CTOD(cFechaf)))
            ''    cFechaf = DTOC(DateSerial(Year(CTOD(cFechaf)), Month(CTOD(cFechaf)) + 1, 0))
            ''    nImporte = nImporte + nInteres
            ''    nDiasInt = DateDiff(DateInterval.Day, CTOD(cFechai), CTOD(cFechaf))
            ''    nInteres = Round(((nImporte * nTasas / 100) / 360) * nDiasInt, 2)
            ''    Valores(n) = nBaseImp + nInteres
            ''Next
            ''Guess = 0.05
            ''nTIR = Round(IRR(Valores, Guess) * 100, 3)
            '''     nCAT = Round((Round(Pow(1 + (nTIR / 100), 12), 8) - 1) * 100, 2)

            If Trim(cRepresentante1) <> "" Or Trim(cRepresentante2) <> "" Then
                cParrafoRepres = ", QUIENES MANIFIESTAN BAJO PROTESTA DE DECIR VERDAD QUE LAS FACULTADES  DE REPRESENTACION QUE LES FUERON OTORGADAS"
                cParrafoRepres = cParrafoRepres & ", NO LES HAN SIDO REVOCADAS NI LIMITADAS EN FORMA ALGUNA A LA FECHA DE CELEBRACION  DE ESTE ACTO."
                If LTrim(cRepresentante2) <> "" Then
                    cRepresentante = " REPRESENTADA EN ESTE ACTO POR " & LTrim(cRepresentante1) & " Y POR " & LTrim(cRepresentante2)
                    cFirman = cRepresentante1 & " Y " & cRepresentante2
                Else
                    cRepresentante = " REPRESENTADA EN ESTE ACTO POR " & LTrim(cRepresentante1)
                    cFirman = cRepresentante1
                End If
            End If

            If cGarPrend = "SI" And cGarHipot = "SI" Then
                cGarantias = "GARANTIA PRENDARIA Y GARANTIA HIPOTECARIA"
            ElseIf cGarPrend = "SI" And cGarHipot <> "SI" Then
                cGarantias = "GARANTIA PRENDARIA"
            ElseIf cGarPrend <> "SI" And cGarHipot = "SI" Then
                cGarantias = "GARANTIA HIPOTECARIA"
            End If

            ' Jalar los Cultivos desde Tabla SEG_Cultivo
            With cm5
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM GEN_Cultivos "
                .Connection = cnAgil
            End With

            ' Llenar el dataset lo cual abre y cierra la conexi�n

            daCultivo.Fill(dsAgil, "Cultivos")

            ' Ligar la tabla Cultivos del dataset dsAgil al ComboBox de Cultivos

            cbCultivos.DataSource = dsAgil
            cbCultivos.DisplayMember = "Cultivos.Cultivo"
            cbCultivos.ValueMember = "Cultivos.idCultivo"
            cbCultivos.SelectedIndex = 0

            If cSemilla = "" Then
                cbCultivos.Enabled = True
            Else
                cbCultivos.Text = Cultivos.SacaCultivo(cSemilla)
                cbCultivos.Enabled = False
            End If

            If cSucursal = "04" Then
                rbMolinos.Enabled = True
                rbArfin.Enabled = True
                If cUsuario = "AGIL\janeth-ibarra" Or cUsuario = "AGIL\sandra-duarte" Or cUsuario = "AGIL\avelina-rojas" Then
                    btnConvenio.Enabled = True
                End If
            Else
                rbMolinos.Enabled = False
                rbArfin.Enabled = False
            End If

            ' Proceso los nombres de los avales

            cAval1 = Trim(drDato("NomCoac"))
            If Trim(drDato("NomrCoac")) <> "" Then
                cAval1b = "REPRESENTADA EN ESTE ACTO POR " & Trim(drDato("NomrCoac"))
            End If
            cAval2 = Trim(drDato("NomObli"))
            If Trim(drDato("NomrObl")) <> "" Then
                cAval2b = "REPRESENTADA EN ESTE ACTO POR " & Trim(drDato("NomrObl"))
            End If
            cAval3 = Trim(drDato("NomAval1"))
            If Trim(drDato("NomrAva1")) <> "" Then
                cAval3b = "REPRESENTADA EN ESTE ACTO POR " & Trim(drDato("NomrAva1"))
            End If
            cAval4 = Trim(drDato("NomAval2"))
            If Trim(drDato("NomrAva2")) <> "" Then
                cAval4b = "REPRESENTADA EN ESTE ACTO POR " & Trim(drDato("NomrAva2"))
            End If

            If cAval1 <> "" Then
                lbAvales.Items.Add(cAval1)
                If drDato("TipCoac") = "M" Then
                    If drDato("Coac") = "C" Then
                        cDatosAval = Chr(10) & "DECLARA EL COACREDITADO POR CONDUCTO DE SU REPRESENTANTE: " & drDato("GeneCoac")
                    Else
                        cDatosAval = Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL POR CONDUCTO DE SU REPRESENTANTE: " & drDato("GeneCoac")
                    End If
                    cDatosAval = cDatosAval & Chr(10) & " SU REPRESENTANTE " & drDato("NomrCoac") & Chr(10) & drDato("Genercoa") & Chr(10) & Chr(10) & drDato("PoderCoa")
                Else
                    If drDato("Coac") = "C" Then
                        cDatosAval = Chr(10) & "DECLARA EL COACREDITADO:" & drDato("GeneCoac")
                    Else
                        cDatosAval = Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL:" & drDato("GeneCoac")
                    End If
                End If
            End If
            If cAval2 <> "" Then
                lbAvales.Items.Add(cAval2)
                If drDato("TipoObli") = "M" Then
                    cDatosAval = cDatosAval & Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL POR CONDUCTO DE SU REPRESENTANTE: " & drDato("GeneObli")
                    cDatosAval = cDatosAval & Chr(10) & " SU REPRESENTANTE " & drDato("NomrObl") & Chr(10) & drDato("GenerObl") & Chr(10) & Chr(10) & drDato("PoderObl")
                Else
                    cDatosAval = cDatosAval & Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL: " & drDato("GeneObli")
                End If
            End If
            If cAval3 <> "" Then
                lbAvales.Items.Add(cAval3)
                If drDato("TipAval1") = "M" Then
                    cDatosAval = cDatosAval & Chr(10) & Chr(10) & "ODECLARA EL OBLIGADO SOLIDARIO Y AVAL POR CONDUCTO DE SU REPRESENTANTE: " & drDato("Geneava1")
                    cDatosAval = cDatosAval & Chr(10) & " SU REPRESENTANTE " & drDato("NomrAva1") & Chr(10) & drDato("GenerAv1") & Chr(10) & Chr(10) & drDato("Poderav1")
                Else
                    cDatosAval = cDatosAval & Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL: " & drDato("GeneAva1")
                End If
            End If
            If cAval4 <> "" Then
                lbAvales.Items.Add(cAval4)
                If drDato("TipAval2") = "M" Then
                    cDatosAval = cDatosAval & Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL POR CONDUCTO DE SE REPRESENTANTE: " & drDato("GeneAva2")
                    cDatosAval = cDatosAval & Chr(10) & " SU REPRESENTANTE " & drDato("NomrAva2") & Chr(10) & drDato("GenerAv2") & Chr(10) & Chr(10) & drDato("Poderav2")
                Else
                    cDatosAval = cDatosAval & Chr(10) & Chr(10) & "DECLARA EL OBLIGADO SOLIDARIO Y AVAL: " & drDato("GeneAva2")
                End If
            End If

            If cSucursal = "05" Then
                cNum = "III. " & "Declara(n) el(los) Obligado(s) y Aval(es):" & Chr(10) & Chr(10) & cDatosAval & Chr(10)
                cNum1 = "IV."
                cNum2 = "V. "
            Else
                cNum = ""
                cNum1 = "III." & "Declara(n) el(los) Obligado(s) y Aval(es):" & Chr(10) & Chr(10) & cDatosAval & Chr(10)
                cNum2 = "IV. "
            End If

            cGarantiaPrendaria = drDato("GarantiaPrendaria")
            cGarantiaHipotecaria = drDato("GarantiaHipotecaria")
            cGarantiaUsufructo = drDato("GarantiaUsufructo")
            nRendimiento = drDato("ToneladasHectarea")
            cFondeo = drDato("Fondeo")
            If cFondeo = "01" Then
                TxtFondeo.Text = "PROPIOS"
            ElseIf cFondeo = "03" Then
                TxtFondeo.Text = "FIRA"
            Else
                TxtFondeo.Text = "NAFIN"
            End If
            nToneladas = nHectareas * nRendimiento
            cHectareas = Format(nHectareas, "##,##0.00")
            cToneladas = Format(nToneladas, "##,##0.00")
            cRendimiento = Format(nRendimiento, "##,##0.00")
            nPlazoCred = DateDiff(DateInterval.Day, CTOD(cFechaFirma), CTOD(cFechaTermino))

            If cFechaAutorizacion = "" Or nRendimiento = 0 Or nHectareas = 0 Or nImporte = 0 Or Val(cDiferencialFINAGIL) = 0 Then
                btnImprimir.Enabled = False
                btnImpPagare.Enabled = False
                gbPagare.Visible = False
            End If

            nCultivo = TaQUERY.sacaidCultivo(cSemilla)

            With cm4
                .CommandType = CommandType.Text
                .CommandText = "SELECT GastosAdminHecta FROM AVI_Parametros WHERE id_Ciclo = " & "'" & cCiclo & "'" & " And id_Sucursal = " & "'" & cSucursal & "'" & " And id_Cultivo = " & nCultivo.ToString
                .Connection = cnAgil
            End With

            daGtoAd.Fill(dsAgil, "GtoAdmin")
            If dsAgil.Tables("GtoAdmin").Rows.Count > 0 Then
                drGtoAd = dsAgil.Tables("GtoAdmin").Rows(0)
                cFactorGA = drGtoAd("GastosAdminHecta").ToString
            End If

            cGtoAdmin = "$ " & Trim(cFactorGA) & "/HA"
            cFertilizante = "UREA" & Chr(13) & "FOSFORO" & Chr(13) & "SULFATO DE AMONIO(ESTANDAR Y GRANULADO)" & Chr(13) & "MEZCLA 300-100" & Chr(13) & "MEZCLA 400-100" & Chr(13)
            cFertilizante = cFertilizante & "AMONIACO C/SERVICIO" & Chr(13) & "AMINIACO S/SERVICIO" & Chr(13) & "FOSFORO LIQUIDO"
            If cSemilla = "C" And cSucursal = "04" Then
                cHerbicidas = "MURALLA MAX (Insecticida)" & Chr(13) & "OPUS (Fungicida)" & Chr(13) & "CLOROTALONI (Fungicida)" & Chr(13) & "SURFACID (Adherente)"
            Else
                cHerbicidas = "DIAMINE 400" & Chr(13) & "PERFEKTION" & Chr(13) & "DIAMINE 480" & Chr(13) & "AMINA 4" & Chr(13) & "SUTUIXL" & Chr(13) & "ETC."
            End If
            If cSucursal = "03" Then
                cEmpcv = "TABLEX MILLER S DE RL DE CV"
                cLugar = "Navojoa, Sonora"
                cOtros = "JUPARE" & Chr(13) & "NACORI" & Chr(13) & "ALTAR" & Chr(13) & "BANAMICHI" & Chr(13) & "SAMAYOA" & Chr(13) & "CIRNO" & Chr(13) & "SAWALLI" & Chr(13) & "PATRONATO" & Chr(13) & "CHAPULTEPEC" & Chr(13) & "IMPERIAL" & Chr(13) & "MOVAS" & Chr(13) & "HUATABAMBO"
                If cSemilla = "M" Or cSemilla = "N" Then
                    cOtros = "DAS2355" & Chr(13) & "DAS2303" & Chr(13) & "WX7314MAX" & Chr(13) & "MAX915" & Chr(13) & "AS-501" & Chr(13) & "TORNADO XR" & Chr(13) & "XR47" & Chr(13) & "BISONTE" & Chr(13) & "CEBU" & Chr(13) & "GARA�ON"
                    cOtros = cOtros & Chr(13) & "P30P49W" & Chr(13) & "30P45W" & Chr(13) & "NOROESTE 339" & Chr(13) & "NOROESTE 478" & Chr(13) & "NH5" & Chr(13) & "NV10" & Chr(13) & "NB17" & Chr(13) & "GENEX 766" & Chr(13) & "PANTERA"
                    cOtros = cOtros & Chr(13) & "PUMA" & Chr(13) & "DEKALB 2020" & Chr(13) & "PIONEER 31G66" & Chr(13) & "A7573" & Chr(13) & "ETC."
                End If
                If cSemilla = "Y" Then
                    cOtros = "NAINARI" & Chr(13) & "GUAYPARIME" & Chr(13) & "S-10" & Chr(13) & "SUAQUI-86" & Chr(13) & "HARBAR-88" & Chr(13) & "CAJEME"
                    cFertilizante = "FOSFATO MONOAMONICO" & Chr(13) & "UREA" & Chr(13) & "SULFATO DE AMONIO" & Chr(13) & "AMONIACO ANHIDRO" & Chr(13) & "FOSFONITRATO" & Chr(13)
                    cFertilizante = cFertilizante & "AGUA AMONIACAL"
                    cHerbicidas = "OTILAN" & Chr(13) & "TRETOX" & Chr(13) & "PERMERLIN" & Chr(13) & "BLAZER" & Chr(13) & "FLEX" & Chr(13) & "SELECT" & Chr(13) & "FUSILADE"
                End If
                cTestigos = "DECLARA EL TESTIGO LLAMARSE MAGDA IRASEMA CORONADO SOTO, DE PROFESION LICENCIADA EN ADMINISTRACION CON ESPECIALIDAD EN MERCADOTECNIA, ORIGINARIA DE NAVOJOA, SONORA LUGAR DONDE NACIO EL 21 DE AGOSTO DE 1978, CON R.F.C. COSM7808211G2, DE ESTADO CIVIL SOLTERA"
                'cTestigos = cTestigos & " 2 DE FEBRERO DE 1966, CON R.F.C. LEAR660202L82, DE ESTADO CIVIL CASADO. "
                cTestigos = cTestigos & Chr(10) & "DECLARA EL TESTIGO LLAMARSE MITZI LOPEZ BOJORQUEZ, DE PROFESION LICENCIADA EN SISTEMAS DE INFORMACION ADMINISTRATIVA, ORIGINARIO DE LA CIUDAD DE MEXICO DISTRITO FEDERAL LUGAR DONDE NACIO EL "
                cTestigos = cTestigos & " 07 DE NOVIEMBRE DE 1980, CON R.F.C. LOBM8011071JA, DE ESTADO CIVIL SOLTERA. "
                cFirmaTestigo1 = "LIC. MAGDA IRASEMA CORONADO SOTO"
                cFirmaTestigo2 = "LIC. MITZI LOPEZ BOJORQUEZ"
                cUnidadEsp = "Avenida No Reelecci�n n�mero 712 (setecientos doce) sur, colonia Centro, entre las calles de Manuel Doblado y Nicol�s Bravo, C.P. 85800 (ochenta y cinco mil ochocientos), Navojoa, Sonora, los tel�fonos de atenci�n a usuarios ser�n: (642) 422 56 50 y 01 800 836 23 92, "
                If cSemilla = "T" Then
                    cTrianual = " ANUAL"
                    cPrimera = " Dicho monto se otorgara por cada ciclo o periodo productivo autorizado a favor del productor acreditado quien acepta el cr�dito."
                    cSegunda = Chr(10) & Chr(10) & "SEGUNDA.- PLAZO DEL CREDITO. El cr�dito mencionado en la clausula primera se otorgara por un plazo de tres a�os, contados a partir de la fecha de la primera disposici�n del primer ciclo del periodo productivo."
                End If
            ElseIf cSucursal = "04" Then
                cEmpcv = "MOLINOS DEL SUDESTE SA DE CV"
                cLugar = "Mexicali, Baja California"
                cTestigos = "DECLARA EL TESTIGO LLAMARSE JANETH IBARRA BIBIANO, DE PROFESION LICENCIADA EN DERECHO, ORIGINARIO DE LA CIUDAD DE MEXICALI, BAJA CALIFORNIA, LUGAR DONDE NACIO EL  28 DE ABRIL DE 1986, CON R.F.C. IABJ860428TP8. "
                cTestigos = cTestigos & Chr(10) & "DECLARA EL TESTIGO LLAMARSE DAIEL RENTERIA, DE PROFESION LICENCIADO EN ADMINISTRACION, ORIGINARIO DE ENSENADA, BAJA CALIFORNIA, LUGAR DONDE NACIO EL 15 DE OCTUBRE DE 1959, CON R.F.C. REDA591015HU8."
                cFirmaTestigo1 = "LIC. JANETH IBARRA BIBIANO"
                cFirmaTestigo2 = "LIC DANIEL RENTERIA"


                cUnidadEsp = "Avenida Rio San Angel n�mero 48 (cuarenta y ocho) interior 7 (siete) y 8 (ocho), fraccionamiento Valle de Puebla, C.P. 21384 (veinti�n mil trescientos ochenta y cuatro), Mexicali, Baja California, los tel�fonos de atenci�n a usuarios ser�n: (686) 577 80 60, (686) 577 80 50 y 01 800 626 02 27, "
                If cSemilla = "C" Then
                    cOtros = "CIANO-OL"
                Else
                    cOtros = "ATIL" & Chr(13) & "CEMEXI" & Chr(13) & "RARI" & Chr(13) & "RIO COLORADO" & Chr(13) & "ORITA"
                End If
            ElseIf cSucursal = "05" Then
                cEmpcv = "'AGROPRODUCTORES DE LA RIBERA DEL LERMA' SOCIEDAD DE PRODUCCION RURAL DE RESPONSABILIDAD LIMITADA a trav�s de HARINERA LOS PIRINEOS SA DE CV"
                cPirineos = " a trav�s de HARINERA LOS PIRINEOS S.A. DE C.V., "
                cC_Venta = "Lo anterior en base al "
                cC_Venta2 = "de conformidad con el "
                cCtoC_Venta = "contrato de compraventa del Ciclo Agr�cola Primavera-Verano 2011 suscrito entre 'AGROPRODUCTORES DE LA RIBERA DEL LERMA' SOCIEDAD DE PRODUCCION RURAL DE RESPONSABILIDAD LIMITADA Y HARINERA LOS PIRINEOS S.A. DE C.V."
                If cSemilla = "S" Then
                    cOtros = "8133 PIONNER" & Chr(13) & "81T91 PIONNER" & Chr(13) & "81G47 PIONNER" & Chr(13) & "84G48 PIONNER" & Chr(13) & "GALIO ASGROW" & Chr(13) & "KILATE ASGROW" & Chr(13) & "NIQUEL ASGROW" & Chr(13) & "PINO AVANTE" & Chr(13) & "MEZQUITE AVANTE" & Chr(13) & "FRESNO AVANTE" & Chr(13) & "NOGAL AVANTE" & Chr(13) & "DKS43 DKALB" & Chr(13) & "DKS74 DKALB" & Chr(13) & "DKS46 DKALB"
                ElseIf cSemilla = "M" Or cSemilla = "N" Then
                    cOtros = "P3368W PIONNER" & Chr(13) & "P2946W PIONNER" & Chr(13) & "32D06 PIONNER" & Chr(13) & "30P16 PIONNER" & Chr(13) & "RIO GRANDE AVANTE" & Chr(13) & "TRES RIOS AVANTE"
                ElseIf cSemilla = "T" Then
                    cOtros = "JUPARE" & Chr(13) & "NACORI" & Chr(13) & "ALTAR" & Chr(13) & "BANAMICHI" & Chr(13) & "SAMAYOA" & Chr(13) & "OTRA"
                End If

                'cGtoAdmin = "$ " & Trim(cFactorGA) & "/HA para el ciclo " & cDescCiclo2 & ", se aplicar� la siguiente formula GA = ga + (ga x 2i)" & Chr(13) & Chr(13) & "GA = Gastos administrativos a aplicar al ciclo correspondiente, redondeando a las unidades de pesos (si el resultado �tomando en consideraci�n los decimales- es menor a 0.5," & _
                '" se redondear� a la unidad inmediata anterior, si es mayor o igual a 0.5 se cerrar� a la unidad inmediata superior)." & "ga = gastos administrativos del ciclo inmediato anterior al correspondiente." & Chr(13) & "i = Inflaci�n anual (del 1 de enero al 31 de diciembre que determine el Banco de M�xico) al cierre del ejercicio fiscal del a�o inmediato anterior al ciclo correspondiente."

                cLugar = "Irapuato, Guanajuato"
                cTestigos = "DECLARA EL TESTIGO LLAMARSE VIOLETA MARIA LUCIA TEZCUCANO CONTRERAS, DE PROFESION LICENCIADA EN CONTADURIA, ORIGINARIA DE IRAPUATO, GUANAJUATO LUGAR DONDE NACIO EL "
                cTestigos = cTestigos & " 17 DE ENERO DE 1984, CON R.F.C. TECV8401179F0, DE ESTADO CIVIL CASADA. "
                cTestigos = cTestigos & Chr(10) & "DECLARA EL TESTIGO LLAMARSE JOSE JUAN CARLOS RAZO GUERRA, DE PROFESION INGENIERO AGROINDUSTRIAL, ORIGINARIO DE ABASOLO, GUANAJUATO LUGAR DONDE NACIO EL "
                cTestigos = cTestigos & " 03 DE MAYO DE 1984, CON R.F.C. RAGJ840503K35, DE ESTADO CIVIL SOLTERO. "
                cFirmaTestigo1 = "LIC. VIOLETA MARIA LUCIA TEZCUCANO CONTRERAS"
                ''cTestigos = "DECLARA EL TESTIGO LLAMARSE VIANEY ALEJANDRA YA�EZ ORTIZ, DE OCUPACION ESTUDIANTE, ORIGINARIA DE IRAPUATO, GUANAJUATO LUGAR DONDE NACIO EL "
                ''cTestigos = cTestigos & " 15 DE MAYO DE 1991, CON R.F.C. YAOV910515480, DE ESTADO CIVIL SOLTERA. "
                ''cTestigos = cTestigos & Chr(10) & "DECLARA EL TESTIGO LLAMARSE JOSE JUAN CARLOS RAZO GUERRA, DE PROFESION INGENIERO AGROINDUSTRIAL, ORIGINARIO DE ABASOLO, GUANAJUATO LUGAR DONDE NACIO EL "
                ''cTestigos = cTestigos & " 03 DE MAYO DE 1984, CON R.F.C. RAGJ840503K35, DE ESTADO CIVIL SOLTERO. "
                ''cFirmaTestigo1 = "VIANEY ALEJANDRA YA�EZ ORTIZ"
                cFirmaTestigo2 = "ING. JOSE JUAN CARLOS RAZO GUERRA"
                cUnidadEsp = "Avenida de los Insurgentes n�mero 2604 (dos mil seiscientos cuatro), Local B-4, Plaza Inn, colonia Los Fresnos, C.P. 36555 (treinta y seis mil quinientos cincuenta y cinco), Irapuato, Guanajuato, los tel�fonos de atenci�n a usuarios ser�n: (462) 623 62 31, (462) 623 64 61 y 01 800 837 74 76, "
            ElseIf cSucursal = "06" Then
                cEmpcv = "MOLINOS DEL FENIX SA DE CV"
                cLugar = "Saltillo, Coahuila"
                cTestigos = "DECLARA EL TESTIGO LLAMARSE MARIO RUIZ URBINA, DE PROFESION INGENIERO AGRONOMO, ORIGINARIO DE MONTERREY, NUEVO LEON, LUGAR DONDE NACIO EL "
                cTestigos = cTestigos & " 19 DE ENERO DE 1961, CON R.F.C. RUUM610119MG3, DE ESTADO CIVIL CASADO. "
                cTestigos = cTestigos & Chr(10) & "DECLARA EL TESTIGO LLAMARSE FRANCISCO JAVIER MARTINEZ GARCIA, DE PROFESION INGENIERO AGRONOMO, ORIGINARIO DE SALTILLO, COAHUILA, LUGAR DONDE NACIO EL "
                cTestigos = cTestigos & " 03 DE SEPTIEMBRE DE 1955, CON R.F.C. MAGF550903, DE ESTADO CIVIL CASADO. "
                cFirmaTestigo1 = "ING. MARIO RUIZ URBINA"
                cFirmaTestigo2 = "ING. FRANCISCO JAVIER MARTINEZ GARCIA"
            End If

            If cSemilla = "A" Then
                cOtros = "DELTA PINE 0912" & Chr(13) & "DELTA PINE 0935" & Chr(13) & "FIBER MAX 1740" & "FIBER MAX 5458"
                cAgroquimi = "COLOSO" & Chr(13) & "FAENA FORTE" & Chr(13) & "GLIFOX MAX"
                cAgroquimi2 = "METAMIDOFOS" & Chr(13) & "TALSTAR" & Chr(13) & "THIODAN"
            Else
                cAgroquimi = "DIAMIME(400)" & Chr(13) & "PERFEKTION()" & Chr(13) & "DIAMINE(480)" & Chr(13) & "AMINA(4)" & Chr(13) & "SUTUI(XL)" & Chr(13) & "ETC."
                cAgroquimi2 = "NO APLICA"
            End If

            txtNombreProductor.Text = Trim(cDescr)
            txtNombreRepresentante.Text = Trim(cRepresentante)
            txtHectareas.Text = Format(nHectareas, "##,##0.00")
            txtToneladasHectarea.Text = Format(nRendimiento, "##,##0.00")
            txtDiferencialFINAGIL.Text = cDiferencialFINAGIL
            lblFechaFirma.Text = cFechaFirma
            lblGarantiaPrendaria.Text = cGarantiaPrendaria
            lblGarantiaHipotecaria.Text = cGarantiaHipotecaria
            lblMontoCredito.Text = "$" & cImporte & " " & cCantidad

            If Val(cCliente) < 8501 Or Val(cCliente) > 8600 Then
                If cGarantiaHipotecaria = "SI" Then
                    lblNotarioRegistrador.Text = "Enviar a firma con el Notario P�blico 67 de Navojoa, Sonora el Lic. Jorge de Jes�s Mart�nez Almada"
                Else
                    lblNotarioRegistrador.Text = "Enviar a firma con el Registrador de Cr�dito Agr�cola el Lic. Genaro Rojas Ca�ez"
                End If
            Else
                lblNotarioRegistrador.Text = "Contrato de GUANAJUATO"
            End If

            If cTipo = "M" Then
                cEncabezado = txtAnexo.Text & " QUE CELEBRAN POR UNA PARTE " & txtNombreProductor.Text &
                                    " REPRESENTADA POR " & cRepresentante & " EN LO SUCESIVO EL " &
                                      Chr(34) & "PRODUCTOR ACREDITADO" & Chr(34)
                cEncabezado2 = "LOS QUE SUSCRIBEN " & txtNombreProductor.Text & " REPRESENTADA POR " & cRepresentante
            Else
                cEncabezado = txtAnexo.Text & " QUE CELEBRAN POR UNA PARTE " & txtNombreProductor.Text &
                                      " EN LO SUCESIVO EL " &
                                      Chr(34) & "PRODUCTOR ACREDITADO" & Chr(34)
                cEncabezado2 = "LOS QUE SUSCRIBEN " & txtNombreProductor.Text
            End If

            If lbAvales.Items.Count > 0 Then
                If lbAvales.Items.Count = 1 Then
                    cEncabezado = cEncabezado & " Y COMO AVAL " & lbAvales.Items(0) & " EN LO SUCESIVO EL " &
                                  Chr(34) & "AVAL" & Chr(34)
                    cEncabezado2 = cEncabezado2 & " Y COMO AVAL " & lbAvales.Items(0)
                ElseIf lbAvales.Items.Count = 2 Then
                    cEncabezado = cEncabezado & " Y COMO AVALES " & lbAvales.Items(0) & " Y " & lbAvales.Items(1)
                    cEncabezado2 = cEncabezado2 & " Y COMO AVALES " & lbAvales.Items(0) & " Y " & lbAvales.Items(1)
                ElseIf lbAvales.Items.Count = 3 Then
                    cEncabezado = cEncabezado & " Y COMO AVALES " & lbAvales.Items(0) & ", " & lbAvales.Items(1) & " Y " & lbAvales.Items(2)
                    cEncabezado2 = cEncabezado2 & " Y COMO AVALES " & lbAvales.Items(0) & ", " & lbAvales.Items(1) & " Y " & lbAvales.Items(2)
                ElseIf lbAvales.Items.Count = 4 Then
                    cEncabezado = cEncabezado & " Y COMO AVALES " & lbAvales.Items(0) & ", " & lbAvales.Items(1) & ", " & lbAvales.Items(2) & " Y " & lbAvales.Items(3)
                    cEncabezado2 = cEncabezado2 & " Y COMO AVALES " & lbAvales.Items(0) & ", " & lbAvales.Items(1) & ", " & lbAvales.Items(2) & " Y " & lbAvales.Items(3)
                End If
            End If

            cEncabezado = cEncabezado & " Y POR OTRA PARTE FINAGIL, S.A. DE C.V. SOFOM, E.N.R. EN LO SUCESIVO " &
                          Chr(34) & "FINAGIL" & Chr(34) &
                          " AL TENOR DE LAS SIGUIENTES DECLARACIONES Y CL�USULAS."

            If cGarantiaPrendaria = "SI" Then

                cMuebles = drDato("Muebles")

                cParrafoPrenda = Chr(13) & Chr(10) & "Adicionalmente, el PRODUCTOR ACREDITADO constituye prenda sobre el(los) bien(es) mueble(s) (cuyas caracter�sticas mencionadas en el inciso l) " &
                                "de la Declaraci�n I se  tienen por reproducidas �ntegramente en la presente cl�usula como si se insertasen a la letra) a favor de FINAGIL, " &
                                "la cual acepta en este acto (en lo sucesivo, la PRENDA) quedando �ste(os) en posesi�n del PRODUCTOR ACREDITADO, y constituy�ndose en depositario judicial " &
                                "de los mismos para efectos de responsabilidades civiles o penales, de conformidad con lo que establece el art�culo 329 de la LGTOC, " &
                                "d�ndose por recibido de los mismos y designando como lugar de dep�sito el ubicado en "
                cParrafoPrenda = cParrafoPrenda & cCalle & ", COL. " & cColonia & ", C.P. " & cCopos & ", " & cDelegacion & ", " & cEstado & "."

            End If

            ' If Val(cCliente) < 8501 Or Val(cCliente) > 8600 Then
            If cSucursal = "03" Then
                If cGarantiaHipotecaria = "SI" Then
                    cInmuebles = drDato("Inmuebles")

                    cGravamen = Chr(13) & Chr(10) & "m)  Que a la fecha del presente contrato dicho(s) inmueble(s) se encuentra(n) libre(s) de todo gravamen y limitaci�n de dominio, seg�n consta " &
                                    "en el (los) certificado(s) de grav�menes de fecha _______ emitido(s) por el Registro P�blico de la Propiedad de _________."

                    cParrafoHipoteca = "Asimismo, en garant�a del cumplimiento parcial o total de las Obligaciones Garantizadas, el PRODUCTOR ACREDITADO en este acto constituye hipoteca en primer lugar y grado sobre el(los) inmueble(s) (cuyas caracter�sticas mencionadas en el inciso l) de la Declaraci�n I se  tienen por reproducidas �ntegramente en la presente cl�usula como si se insertasen a la letra) a favor de FINAGIL, la cual acepta en este acto (en lo sucesivo, la Hipoteca)." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "a) Registro. La Hipoteca deber� ser registrada en t�rminos del Cap�tulo correspondiente del C�digo Civil del Estado de Sonora." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "b) Vigencia. La Hipoteca permanecer� vigente hasta la fecha en que se hayan cumplido todas y cada una de las Obligaciones Garantizadas, y subsistir� �ntegra aunque �stas se reduzcan, independientemente de la causa de su reducci�n. Asimismo, subsistir� no obstante cualquier modificaci�n a las Obligaciones Garantizadas, incluyendo de manera enunciativa pero no limitativa, quita, pr�rroga o espera." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "c) Intereses. Las partes expresamente convienen en que la Hipoteca garantiza los intereses que devengue el Cr�dito a�n en exceso del t�rmino de tres a�os, lo que deber� hacerse constar en la inscripci�n que de esta escritura se realice en el Registro P�blico, seg�n lo dispuesto por el art�culo 2915 del C�digo Civil Federal." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "d) Impuestos y Gastos. Todos los impuestos y gastos que se deriven de la constituci�n de la Hipoteca ser�n por exclusiva cuenta del PRODUCTOR ACREDITADO, as� como aqu�llos que se deriven de su registro ante el Registro P�blico de la Propiedad del Estado de Sonora. Si FINAGIL efectuare cualquier pago por los conceptos que se se�alan en esta cl�usula podr� repercutir en contra del PRODUCTOR ACREDITADO el importe de dichos pagos m�s intereses a raz�n de la tasa de inter�s de car�cter moratorio prevista en la Cl�usula NOVENA del presente contrato, a partir de la fecha en que se efect�en dichos pagos y hasta la fecha en que se reembolse la totalidad de los mismos, quedando dicho reembolso garantizado con la Hipoteca." & Chr(13) & Chr(10)
                End If
            ElseIf cSucursal = "05" Then
                If cGarantiaHipotecaria = "SI" Then
                    cInmuebles = drDato("Inmuebles")

                    cParrafoHipoteca = "Asimismo, en garant�a del cumplimiento parcial o total de las Obligaciones Garantizadas, el PRODUCTOR ACREDITADO en este acto constituye hipoteca en primer lugar y grado sobre el(los) inmueble(s) (cuyas caracter�sticas mencionadas en el inciso l) de la Declaraci�n I se  tienen por reproducidas �ntegramente en la presente cl�usula como si se insertasen a la letra) a favor de FINAGIL, la cual acepta en este acto (en lo sucesivo, la Hipoteca)." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "a) Registro. La Hipoteca deber� ser registrada en t�rminos del Cap�tulo correspondiente del C�digo Civil del Estado de Guanajuato." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "b) Vigencia. La Hipoteca permanecer� vigente hasta la fecha en que se hayan cumplido todas y cada una de las Obligaciones Garantizadas, y subsistir� �ntegra aunque �stas se reduzcan, independientemente de la causa de su reducci�n. Asimismo, subsistir� no obstante cualquier modificaci�n a las Obligaciones Garantizadas, incluyendo de manera enunciativa pero no limitativa, quita, pr�rroga o espera." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "c) Intereses. Las partes expresamente convienen en que la Hipoteca garantiza los intereses que devengue el Cr�dito a�n en exceso del t�rmino de tres a�os, lo que deber� hacerse constar en la inscripci�n que de esta escritura se realice en el Registro P�blico, seg�n lo dispuesto por el art�culo 2915 del C�digo Civil Federal." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "d) Impuestos y Gastos. Todos los impuestos y gastos que se deriven de la constituci�n de la Hipoteca ser�n por exclusiva cuenta del PRODUCTOR ACREDITADO, as� como aqu�llos que se deriven de su registro ante el Registro P�blico de la Propiedad del Estado de Guanajuato. Si FINAGIL efectuare cualquier pago por los conceptos que se se�alan en esta cl�usula podr� repercutir en contra del PRODUCTOR ACREDITADO el importe de dichos pagos m�s intereses a raz�n de la tasa de inter�s de car�cter moratorio prevista en la Cl�usula NOVENA del presente contrato, a partir de la fecha en que se efect�en dichos pagos y hasta la fecha en que se reembolse la totalidad de los mismos, quedando dicho reembolso garantizado con la Hipoteca." & Chr(13) & Chr(10)
                End If
            End If

            If cSucursal = "04" Then
                If cGarantiaHipotecaria = "SI" Then
                    cInmuebles = drDato("Inmuebles")

                    cParrafoHipoteca = "Asimismo, en garant�a del cumplimiento parcial o total de las Obligaciones Garantizadas, el PRODUCTOR ACREDITADO en este acto constituye hipoteca en primer lugar y grado sobre el(los) inmueble(s) (cuyas caracter�sticas mencionadas en el inciso l) de la Declaraci�n I se  tienen por reproducidas �ntegramente en la presente cl�usula como si se insertasen a la letra) a favor de FINAGIL, la cual acepta en este acto (en lo sucesivo, la Hipoteca)." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "a) Registro. La Hipoteca deber� ser registrada en t�rminos del Cap�tulo correspondiente del C�digo Civil del Estado de Baja California." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "b) Vigencia. La Hipoteca permanecer� vigente hasta la fecha en que se hayan cumplido todas y cada una de las Obligaciones Garantizadas, y subsistir� �ntegra aunque �stas se reduzcan, independientemente de la causa de su reducci�n. Asimismo, subsistir� no obstante cualquier modificaci�n a las Obligaciones Garantizadas, incluyendo de manera enunciativa pero no limitativa, quita, pr�rroga o espera." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "c) Intereses. Las partes expresamente convienen en que la Hipoteca garantiza los intereses que devengue el Cr�dito a�n en exceso del t�rmino de tres a�os, lo que deber� hacerse constar en la inscripci�n que de esta escritura se realice en el Registro P�blico, seg�n lo dispuesto por el art�culo 2915 del C�digo Civil Federal." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "d) Impuestos y Gastos. Todos los impuestos y gastos que se deriven de la constituci�n de la Hipoteca ser�n por exclusiva cuenta del PRODUCTOR ACREDITADO, as� como aqu�llos que se deriven de su registro ante el Registro P�blico de la Propiedad del Estado de Baja California. Si FINAGIL efectuare cualquier pago por los conceptos que se se�alan en esta cl�usula podr� repercutir en contra del PRODUCTOR ACREDITADO el importe de dichos pagos m�s intereses a raz�n de la tasa de inter�s de car�cter moratorio prevista en la Cl�usula NOVENA del presente contrato, a partir de la fecha en que se efect�en dichos pagos y hasta la fecha en que se reembolse la totalidad de los mismos, quedando dicho reembolso garantizado con la Hipoteca." & Chr(13) & Chr(10)
                End If
            End If

            If cSucursal = "06" Then
                If cGarantiaHipotecaria = "SI" Then
                    cInmuebles = drDato("Inmuebles")

                    cParrafoHipoteca = "Asimismo, en garant�a del cumplimiento parcial o total de las Obligaciones Garantizadas, el PRODUCTOR ACREDITADO en este acto constituye hipoteca en primer lugar y grado sobre el(los) inmueble(s) (cuyas caracter�sticas mencionadas en el inciso l) de la Declaraci�n I se  tienen por reproducidas �ntegramente en la presente cl�usula como si se insertasen a la letra) a favor de FINAGIL, la cual acepta en este acto (en lo sucesivo, la Hipoteca)." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "a) Registro. La Hipoteca deber� ser registrada en t�rminos del Cap�tulo correspondiente del C�digo Civil del Estado de Coahuila." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "b) Vigencia. La Hipoteca permanecer� vigente hasta la fecha en que se hayan cumplido todas y cada una de las Obligaciones Garantizadas, y subsistir� �ntegra aunque �stas se reduzcan, independientemente de la causa de su reducci�n. Asimismo, subsistir� no obstante cualquier modificaci�n a las Obligaciones Garantizadas, incluyendo de manera enunciativa pero no limitativa, quita, pr�rroga o espera." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "c) Intereses. Las partes expresamente convienen en que la Hipoteca garantiza los intereses que devengue el Cr�dito a�n en exceso del t�rmino de tres a�os, lo que deber� hacerse constar en la inscripci�n que de esta escritura se realice en el Registro P�blico, seg�n lo dispuesto por el art�culo 2915 del C�digo Civil Federal." & Chr(13) & Chr(10) &
                                        Chr(13) & Chr(10) & "d) Impuestos y Gastos. Todos los impuestos y gastos que se deriven de la constituci�n de la Hipoteca ser�n por exclusiva cuenta del PRODUCTOR ACREDITADO, as� como aqu�llos que se deriven de su registro ante el Registro P�blico de la Propiedad del Estado de Coahuila. Si FINAGIL efectuare cualquier pago por los conceptos que se se�alan en esta cl�usula podr� repercutir en contra del PRODUCTOR ACREDITADO el importe de dichos pagos m�s intereses a raz�n de la tasa de inter�s de car�cter moratorio prevista en la Cl�usula NOVENA del presente contrato, a partir de la fecha en que se efect�en dichos pagos y hasta la fecha en que se reembolse la totalidad de los mismos, quedando dicho reembolso garantizado con la Hipoteca." & Chr(13) & Chr(10)
                End If
            End If

            If cGarantiaUsufructo = "SI" Then
                cUsufructo = drDato("Usufructo")
            End If

            If cAval1 = "" And cAval2 = "" And cAval3 = "" And cAval4 = "" Then
                cAvales = ""
            ElseIf cAval1 <> "" And cAval2 <> "" And cAval3 <> "" And cAval4 <> "" Then
                cAvales = cAval1 & ", " & cAval2 & ", " & cAval3 & " Y " & cAval4
            ElseIf cAval1 <> "" And cAval2 <> "" And cAval3 <> "" And cAval4 = "" Then
                cAvales = cAval1 & ", " & cAval2 & " Y " & cAval3
            ElseIf cAval1 <> "" And cAval2 <> "" And cAval3 = "" And cAval4 = "" Then
                cAvales = cAval1 & " Y " & cAval2
            ElseIf cAval1 <> "" And cAval2 = "" And cAval3 = "" And cAval4 = "" Then
                cAvales = cAval1
            ElseIf cAval1 <> "" And cAval2 <> "" And cAval3 = "" And cAval4 <> "" Then
                cAvales = cAval1 & ", " & cAval2 & " Y " & cAval4
            ElseIf cAval1 <> "" And cAval2 = "" And cAval3 <> "" And cAval4 <> "" Then
                cAvales = cAval1 & ", " & cAval3 & " Y " & cAval4
            ElseIf cAval1 <> "" And cAval2 = "" And cAval3 <> "" And cAval4 = "" Then
                cAvales = cAval1 & " Y " & cAval3
            ElseIf cAval1 <> "" And cAval2 = "" And cAval3 = "" And cAval4 <> "" Then
                cAvales = cAval1 & " Y " & cAval4
            ElseIf cAval1 = "" And cAval2 <> "" And cAval3 <> "" And cAval4 <> "" Then
                cAvales = cAval2 & ", " & cAval3 & " Y " & cAval4
            ElseIf cAval1 = "" And cAval2 <> "" And cAval3 <> "" And cAval4 = "" Then
                cAvales = cAval2 & " Y " & cAval3
            ElseIf cAval1 = "" And cAval2 <> "" And cAval3 = "" And cAval4 <> "" Then
                cAvales = cAval2 & " Y " & cAval4
            ElseIf cAval1 = "" And cAval2 <> "" And cAval3 = "" And cAval4 = "" Then
                cAvales = cAval2
            ElseIf cAval1 = "" And cAval2 = "" And cAval3 <> "" And cAval4 = "" Then
                cAvales = cAval3
            ElseIf cAval1 = "" And cAval2 = "" And cAval3 <> "" And cAval4 <> "" Then
                cAvales = cAval3 & " Y " & cAval4
            End If

            If cAval1 <> "" Then
                If drDato("Coac") = "C" Then
                    cFirmaAval1 = Chr(34) & "COACREDITADO" & Chr(34) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "_________________________________" & Chr(10) & cAval1
                Else
                    cFirmaAval1 = Chr(34) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(34) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "_________________________________" & Chr(10) & cAval1
                End If
            End If
            If cAval2 <> "" Then
                cFirmaAval2 = Chr(10) & Chr(10) & Chr(34) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(34) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "_________________________________" & Chr(10) & cAval2
            End If
            If cAval3 <> "" Then
                cFirmaAval3 = Chr(10) & Chr(10) & Chr(34) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(34) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "_________________________________" & Chr(10) & cAval3
            End If
            If cAval4 <> "" Then
                cFirmaAval4 = Chr(10) & Chr(10) & Chr(34) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(34) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "_________________________________" & Chr(10) & cAval4
            End If
            cFirmaFINAGIL = Chr(10) & Chr(34) & "POR FINAGIL" & Chr(34) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & "_________________________________" & Chr(10) & "FINAGIL, S.A. DE C.V. SOFOM E.N.R." & Chr(10) & "APODERADO LEGAL" & Chr(13)
            If cFirmaTestigo1 <> "" And cFirmaTestigo2 <> "" Then
                cFirmaFINAGIL = cFirmaFINAGIL & Chr(10) & Chr(10) & Chr(10) & Chr(34) & "TESTIGOS" & Chr(34) & Chr(10) & Chr(10) & Chr(10) & Chr(10) & "_________________________________" & Chr(10) & cFirmaTestigo1 & Chr(10) & Chr(10) & Chr(10) & Chr(10) & "_________________________________" & Chr(10) & cFirmaTestigo2
            End If

            If Val(cCliente) < 8501 Or Val(cCliente) > 8600 Then

                If cGarantiaHipotecaria = "SI" Then
                    If cSucursal = "03" Then
                        cLeyendaNotario = "En la Ciudad Obreg�n, Sonora comparecen ante m� Lic. Luis Carlos Aceves Guti�rrez, Notario P�blico No. 69 habilitado en todas las clases de " &
                            "ejercicio, el REPRESENTANTE LEGAL de FINAGIL, S.A. DE C.V. SOFOM E.N.R., en su car�cter de ACREDITANTE, y por otra parte " &
                            txtNombreProductor.Text & " en su car�cter de PRODUCTOR ACREDITADO para hacer constar lo siguiente :" & Chr(13) & Chr(10) & Chr(13) & Chr(10) &
                            "En los t�rminos de lo dispuesto en el art�culo 408 de la Ley General de T�tulos y Operaciones de Cr�dito, comparecen en este acto ante el suscrito fedatario " &
                            "por ser la fiel expresi�n de sus voluntades, para ratificar el contenido del Contrato de Cr�dito de Habilitaci�n o Av�o No. " & txtAnexo.Text & " " &
                            "y de los Anexos que forman parte integrante del contrato celebrado entre las partes anteriormente citadas con fecha " & cFechaFirma & " " &
                            "y reconocer las firmas que lo calzan, por haber sido plasmadas de su pu�o y letra ante m� y ser las que usan en todos sus actos." & Chr(13) & Chr(10) & Chr(13) & Chr(10) &
                            "Por lo antes expuesto, yo el fedatario que suscribe, doy fe" & Chr(13) & Chr(10) & Chr(13) & Chr(10) &
                            "PRIMERO : Que conozco a los comparecientes, quienes tienen capacidad legal para contratar y obligarse." & Chr(13) & Chr(10) & Chr(13) & Chr(10) &
                            "SEGUNDO : Que los generales y personalidades acreditadas por los comparecientes en las declaraciones del Contrato de Cr�dito de Habilitaci�n o Av�o No. " & txtAnexo.Text & " " &
                            "fueron debidamente comprobadas por m�, d�ndolas por reproducidas en el presente instrumento, como si se insertasen a la letra." & Chr(13) & Chr(10) & Chr(13) & Chr(10) &
                            "TERCERO : Que los comparecientes ratifican en este acto el contenido del Contrato de Cr�dito de Habilitaci�n o Av�o No. " & txtAnexo.Text & " " &
                            "y de los Anexos adjuntos,  as� como las firmas que lo calzan; y" & Chr(13) & Chr(10) & Chr(13) & Chr(10) &
                            "CUARTO : Que le�do que fue este instrumento a los comparecientes y explicado su valor y fuerza legal, determinaron firmarlo de conformidad con lo expresado, " &
                            "en presencia y uni�n del suscrito NOTARIO el d�a " & cFechaFirma & ". DOY FE."
                    ElseIf cSucursal = "04" Then
                        cLeyendaNotario = "En la Ciudad de Mexicali, Baja California comparecen ante m� Lic. Francisco Javier Brise�o Arce, Registrador Especial con funciones de Notario, " &
                        "habilitado en todas las clases de ejercicio, el REPRESENTANTE LEGAL de FINAGIL, S.A. DE C.V. SOFOM E.N.R., en su car�cter de ACREDITANTE, y por otra parte " &
                        txtNombreProductor.Text & " en su car�cter de PRODUCTOR ACREDITADO para hacer constar lo siguiente :" & Chr(13) & Chr(10) & Chr(13) & Chr(10) &
                        "En los t�rminos de lo dispuesto en el art�culo 408 de la Ley General de T�tulos y Operaciones de Cr�dito, comparecen en este acto ante el suscrito fedatario " &
                        "por ser la fiel expresi�n de sus voluntades, para ratificar el contenido del Contrato de Cr�dito de Habilitaci�n o Av�o No. " & txtAnexo.Text & " " &
                        "y de los Anexos que forman parte integrante del contrato celebrado entre las partes anteriormente citadas con fecha " & cFechaFirma & " " &
                        "y reconocer las firmas que lo calzan, por haber sido plasmadas de su pu�o y letra ante m� y ser las que usan en todos sus actos." & Chr(13) & Chr(10) & Chr(13) & Chr(10) &
                        "Por lo antes expuesto, yo el fedatario que suscribe, doy fe" & Chr(13) & Chr(10) & Chr(13) & Chr(10) &
                        "PRIMERO : Que conozco a los comparecientes, quienes tienen capacidad legal para contratar y obligarse." & Chr(13) & Chr(10) & Chr(13) & Chr(10) &
                        "SEGUNDO : Que los generales y personalidades acreditadas por los comparecientes en las declaraciones del Contrato de Cr�dito de Habilitaci�n o Av�o No. " & txtAnexo.Text & " " &
                        "fueron debidamente comprobadas por m�, d�ndolas por reproducidas en el presente instrumento, como si se insertasen a la letra." & Chr(13) & Chr(10) & Chr(13) & Chr(10) &
                        "TERCERO : Que los comparecientes ratifican en este acto el contenido del Contrato de Cr�dito de Habilitaci�n o Av�o No. " & txtAnexo.Text & " " &
                        "y de los Anexos adjuntos,  as� como las firmas que lo calzan; y" & Chr(13) & Chr(10) & Chr(13) & Chr(10) &
                        "CUARTO : Que le�do que fue este instrumento a los comparecientes y explicado su valor y fuerza legal, determinaron firmarlo de conformidad con lo expresado, " &
                        "en presencia y uni�n del suscrito NOTARIO el d�a " & cFechaFirma & ". DOY FE."
                    End If
                Else
                    If cSucursal = "03" Then
                        cLeyendaRegistrador = "En Ciudad Obreg�n, Sonora, siendo las ____ horas del d�a ___________________________________________, yo Lic. GENARO ROJAS CA�EZ, " &
                                                      "Registrador Especial de Cr�dito Agr�cola del Distrito Judicial de CAJEME, con residencia en esta ciudad, en funciones de Notario P�blico " &
                                                      "de acuerdo a lo dispuesto por los art�culos 112 y 115 de la Ley de Cr�dito Agr�cola, en vigor de conformidad con el contenido del art�culo " &
                                                      "s�ptimo transitorio de la Ley Agraria, hago constar que me fue presentado para su inscripci�n el Contrato de apertura de Cr�dito de " &
                                                      "Habilitaci�n o Av�o No. " & txtAnexo.Text & " POR UN MONTO DE " & lblMontoCredito.Text &
                                                      "que celebran por una parte FINAGIL, S.A. DE C.V. SOFOM, E.N.R., a trav�s de su REPRESENTANTE LEGAL " &
                                                      "en su car�cter de apoderado legal a quien para los efectos de este contrato se le designar� como FINAGIL y de la otra parte " &
                                                      cDescr & " a quien en lo sucesivo se le designar� como el PRODUCTOR ACREDITADO." & Chr(13) & Chr(10) &
                                                      "Hago constar que comparecieron ante m� el apoderado legal de FINAGIL, S.A. DE C.V. SOFOM, E.N.R., " &
                                                      "quien acredita su personalidad mediante testimonio de escritura p�blica No. 40770, Volumen MCLX (MIL CIENTO SESENTA), " &
                                                      "de fecha (18) dieciocho de octubre de 2007 (DOS MIL SIETE), otorgada ante la fe del Lic. Jorge Vald�s Ram�rez, Notario P�blico No. 24, " &
                                                      "de la Ciudad de Toluca, Estado de M�xico, en el cual se contiene Poder General para Pleitos y Cobranzas y Actos de Administraci�n, " &
                                                      "el cual doy fe de tenerlo a la vista, misma persona quien en este acto se identifica con Credencial de Elector con fotograf�a " &
                                                      "con n�mero de folio 5188007775044, as� como la otra parte " & cDescr & ", quien manifest� " & cGeneClie & " con domicilio en " &
                                                      cCalle & " y quien se identific� con Credencial de Elector con fotograf�a con n�mero de folio ______________________." & Chr(13) & Chr(10) &
                                                      "Y los TESTIGOS quienes manifiestan:" & Chr(13) & Chr(10) &
                                                      "Llamarse MAGDA IRASEMA CORONADO SOTO,  licenciada en administraci�n con especialidad en mercadotecnia, originario de Navojoa, " &
                                                      "Sonora lugar donde naci� el 21 de agosto de 1978, con R.F.C. COSM7808211G2, de estado civil soltera y quien en este acto se identifica " &
                                                      "con Credencial de Elector con fotograf�a con n�mero de folio ______________." & Chr(13) & Chr(10) &
                                                      "Llamarse ADOLFO PACHECO MENDEZ, de profesi�n Ingeniero Agr�nomo Irrigador, originario de Cd. Obreg�n, Sonora lugar donde naci� " &
                                                      "el 1�. de marzo de 1964, con R.F.C. PAMA6403012V1, de estado civil casado y quien en este acto se identifica " &
                                                      "con Credencial de Elector con fotograf�a con n�mero de folio ______________." & Chr(13) & Chr(10) &
                                                      "Y que cumplidos los requisitos de Ley procedo a inscribir el presente documento en los libros del Registro a mi cargo, habi�ndose inscrito " &
                                                      "bajo el N�MERO _________, LIBRO _______, VOLUMEN _______, de este Oficio." & Chr(13) & Chr(10) & Chr(13) & Chr(10) &
                                                      "------------------------------------------------------------------PERSONALIDAD-----------------------------------------------------------------" & Chr(13) & Chr(10) &
                                                      "EL SE�OR CONTADOR PUBLICO JOSE ANTONIO PADILLA AGUILAR PARA ACREDITAR SU CAR�CTER DE APODERADO DE FINAGIL, S.A. DE C.V. SOFOM, E.N.R., SUS FACULTADES, " &
                                                      "ASI COMO LA EXISTENCIA LEGAL, DE LA CITADA FINANCIERA, ME EXHIBE EL SIGUIENTE DOCUMENTO: ESCRITURA PUBLICA NUMERO No. 40770, " &
                                                      "VOLUMEN MCLX (MIL CIENTO SESENTA), DE FECHA (18) DIECIOCHO DE OCTUBRE DE (2007) DOS MIL SIETE, OTORGADA ANTE LA FE DEL LIC. JORGE VALD�S RAM�REZ, " &
                                                      "NOTARIO PUBLICO No. 24, DE LA CIUDAD DE TOLUCA, ESTADO DE M�XICO, E INSCRITO ANTE EL REGISTRO P�BLICO DE LA PROPIEDAD DE ESA CIUDAD CON FECHA (26) " &
                                                      "VEINTIS�IS DE OCTUBRE DEL A�O (2007) DOS MIL SIETE BAJO FOLIO MERCANTIL ELECTR�NICO N�MERO (3829*17) TRES MIL OCHOCIENTOS VEINTINUEVE * DIECISIETE " &
                                                      "Y CONTROL INTERNO (5) CINCO, AS� COMO PARTIDA N�MERO (212) DOSCIENTOS DOCE DEL VOLUMEN (53) CINCUENTA Y TRES, LIBRO (I) PRIMERO Y SECCION " &
                                                      "REGISTRO COMERCIO; MISMO QUE EN LA PARTE CONDUCENTE TRANSCRIBO: NUMERO CUARENTA MIL SETECIENTOS SETENTA� VOLUMEN MCLX�EN LA CIUDAD DE TOLUCA, " &
                                                      "ESTADO DE MEXICO, A LOS DIECIOCHO D�AS DEL MES DE DE OCTUBRE DE DOS MIL SIETE, ANTE M�, EL LICENCIADO JORGE VALDES RAMIREZ." &
                                                      "QUE CON FUNDAMENTO EN LO DISPUESTO POR LOS ARTICULOS 112 Y 115 DE LA LEY DE CREDITO AGRICOLA EN VIGOR EL SUSCRITO REGISTRADOR " &
                                                      "EN FUNCIONES DE NOTARIO PUBLICO ELEVA A ESCRITURA PUBLICA EL PRESENTE DOCUMENTO, PARA SURTIR SUS EFECTOS COMO PRIMER TESTIMONIO " &
                                                      "DE ESCRITURA EN LOS TERMINOS DE LAS DISPOSICIONES ANTES MENCIONADAS, LO QUE AUTORIZO Y FIRMO, DOY FE."


                        cFirmaRegistrador = "C. REGISTRADOR ESPECIAL DE CR�DITO AGR�COLA" & Chr(13) & Chr(10) & "EN FUNCIONES DE NOTARIO P�BLICO" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "_________________________________" & Chr(10) & "LIC. GENARO ROJAS CA�EZ"
                    ElseIf cSucursal = "04" Then
                        cLeyendaRegistrador = "EN LA CIUDAD DE MEXICALI, BAJA CALIFORNIA, A LOS ___ D�AS DEL MES DE ________ DEL ____, ANTE EL SUSCRITO LICENCIADO FRANCISCO JAVIER BRISE�O ARCE, " &
                        "REGISTRADOR ESPECIAL DEL REGISTRO DE CR�DITO AGR�COLA, ACTUALMENTE REGISTRO PUBLICO DE CR�DITO RURAL, ATENTO A LO PREVISTO POR LOS ART�CULOS 99, 101, 108, 112  Y RELATIVOS " &
                        "DE LA LEY DE CR�DITO AGR�COLA EN RELACI�N AL S�PTIMO TRANSITORIO DE LA LEY AGRARIA, HAGO CONSTAR QUE COMPARECIERON ANTE MI LOS SE�ORES CONTADOR PUBLICO JOSE ANTONIO PADILLA AGUILAR, EN SU " &
                        "CALIDAD DE APODERADO LEGAL DE FINAGIL, S.A. DE C.V. SOFOM E.N.R, QUIEN ACREDITA SU PERSONALIDAD MEDIANTE TESTIMONIO DE ESCRITURA PUBLICA NUMERO No. 40770, VOLUMEN MCLX, " &
                        "DE FECHA 18 DE OCTUBRE DE 2007, OTORGADA ANTE LA FE DEL LIC. JORGE VALDES RAMIREZ, NOTARIO PUBLICO NUMERO 24, DE LA CIUDAD DE TOLUCA, ESTADO DE MEXICO, EN EL CUAL SE " &
                        "CONTIENE PODER GENERAL PARA PLEITOS Y COBRANZAS Y ACTOS DE ADMINISTRACI�N, EL CUAL DOY FE DE TENERLO A LA VISTA, MISMA PERSONA QUIEN EN ESTE ACTO SE IDENTIFICA CON CREDENCIAL " &
                        "FEDERAL CON FOTOGRAF�A CON FOLIO NUMERO 5188007775044 Y POR OTRA PARTE " & cDescr & cRepresentante & " EN LO SECESIVO EL 'ACREDITADO' Y COMO AVAL(ES) " & cAvales & ", EN LO SUCESIVO " &
                        "EL(LOS) 'AVAL(ES)', LOS COMPARECIENTES MANIFIESTAN QUE SIN PRESI�N NI COACCI�N ALGUNA, RATIFICAN EN TODAS SUS PARTES EL CONTENIDO DEL CONTRATO DE CR�DITO DE HABILITACI�N O AV�O NUMERO " &
                        txtAnexo.Text & ", POR LA CANTIDAD DE $ " & lblMontoCredito.Text & "Y SABIENDO DE LAS CONSECUENCIAS LEGALES QUE SE DESPRENDEN DEL MISMO PARA TODOS Y CADA UNOS DE LOS EFECTOS LEGALES " &
                        "A QUE HAYA LUGAR, FIRMANDO AL CALCE PARA CONSTANCIA DE LA PRESENTE, AS� COMO AL MARGEN DEL MENCIONADO CONTRATO. "

                        cFirmaRegistrador = Chr(10) & "POR EL ACREDITANTE" & Chr(10) & Chr(10) & "_______________________________" & Chr(13) &
                        "FINAGIL, S.A. DE C.V. SOFOM E.N.R." & Chr(13) & "C.P. JOSE ANTONIO PADILLA AGUILAR" & Chr(13) & "APODERADO(LEGAL)" & Chr(10) & Chr(10) & Chr(10) & "POR EL ACREDITADO" & Chr(10) & Chr(10) & Chr(10) &
                        "_______________________________" & Chr(13) & cDescr & Chr(10) & Chr(10) & Chr(10) & "EL NOTARIO Y REGISTRADOR PUBLICO" & Chr(13) & "DE CR�DITO AGR�COLA" & Chr(10) & Chr(10) &
                        "____________________________________" & Chr(13) & "LIC. FRANCISCO JAVIER BRISE�O ARCE"
                    End If

                End If

            End If
            If cSucursal = "06" Then
                cLeyendaRegistrador = "Yo  Licenciado JUAN FERNANDO AGUIRRE VALDES, Notario P�blico N�mero Veinticuatro del Distrito de Saltillo y del Patrimonio Inmueble Federal con residencia en Irlanda 244 Col. Villa Ol�mpica en Saltillo Coahuila C E R T I F I C O: Que " &
                "a solicitud del Contador P�blico JOSE ANTONIO PADILLA AGUILAR, en su car�cter de Apoderado de la empresa denominada 'FINAGIL', SOCIEDAD ANONIMA DE CAPITAL VARIABLE, SOCIEDAD FINANCIERA " &
                " DE OBJETO MULTIPLE ENTIDAD NO REGULADA, acreditando la legal existencia de su representada as� como las facultades con las que comparece en el CONTRATO DE CREDITO DE HABILITACION O AVIO NUMERO " &
                Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4)) & ", realizado con la sociedad denominada " & Trim(cDescr) & cRepresentante & " en lo sucesivo denominado el 'ACREDITADO', y los se�ores " & cAvales &
                ", en su car�cter de 'AVALES', sociedad denominada MOLINOS DEL FENIX SOCIEDAD ANONIMA DE CAPITAL VARIABLE, representada por el ingeniero LUIS MIGUEL MONROY CARRILLO, en lo sucesivo denominado el 'COMPRADOR,'" &
                " se�ores MARIO RUIZ URBINA y FRANCISCO JAVIER MARTINEZ GARCIA  en su car�cter de 'TESTIGOS'; personalidad que acredita con la escritura p�blica n�mero 40770 cuarenta mil setecientos setenta, del Volumen " &
                "MCLX mil ciento sesenta, con fecha dieciocho de octubre de dos mil siete, otorgada en esta propia notaria, e inscrita en el Registro P�blico de la Propiedad y del Comercio, bajo la partida n�mero 212, Volumen " &
                "53, Libro Primero, Secci�n Comercio de fecha veintinueve de octubre de dos mil siete, en Toluca, Estado de M�xico; quienes por no ser de mi personal conocimiento se identifican en t�rminos de ley, se reconocen " &
                "mutuamente suficiente capacidad para contratar y obligarse en t�rminos del presente contrato y del que se desprende que las firmas que lo calzan son las que utilizan en todos los negocios en que intervienen y al " &
                "que me remito y a solicitud de los mismos lo RATIFICAN, levantando para constancia el Instrumento 44303, del Volumen MCCXXIII, en el cual consta la Ratificaci�n de Firmas y Contenido. DOY FE.--------------------- " &
                " Y A SOLICITUD DE LOS INTERESADOS, EXPIDO LA PRESENTE CERTIFICACION, EN LA CIUDAD DE TOLUCA, ESTADO DE MEXICO, A LOS QUINCE DIAS DEL MES DE DICIEMBRE DEL DOS MIL NUEVE.- DOY FE. ---------------------------- "
            End If
            BtnPLD.Enabled = True
        Else

            ' Se trata de un Cr�dito en Cuenta Corriente para el cual no aplica este formato

            btnImprimir.Enabled = False
            btnImpPagare.Enabled = False
            BtnPLD.Enabled = True

        End If

        'Tiene ministraciones
        With cm5
            .CommandType = CommandType.Text
            .CommandText = "Select Count(Anexo) from detallefinagil where Anexo = '" & cAnexo & "'"
            .Connection = cnAgil
        End With
        cnAgil.Open()
        Dim NumMinis As Integer = cm5.ExecuteScalar
        cnAgil.Close()

        If NumMinis > 0 Then
            HCsol = False
        Else
            HCsol = True
        End If

        cm1.Dispose()
        cm2.Dispose()
        cm3.Dispose()

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm2 As New SqlCommand()
        Dim strUpdate As String
        Dim cFTermino As String

        cFTermino = Mes(cFechaTermino).ToLower
        'cFTermino = cFTermino & Mes(cVenA�o2).ToLower & " Y EL " & Mes(cVenA�o3).ToLower & " PREVIA AUTORIZACION DE FINAGIL."

        cFechaFirma = Mes(DTOC(DateTimePicker1.Value)).ToLower

        If cbCultivos.SelectedIndex < 0 Then
            MsgBox("Selecciona el Tipo de Semilla para el Contrato", MsgBoxStyle.Critical, "Mensaje")
        Else
            Dim oNulo As Object = System.Reflection.Missing.Value
            Dim oRuta As New Object
            Dim myMField As Microsoft.Office.Interop.Word.Field
            Dim rFieldCode As Microsoft.Office.Interop.Word.Range
            Dim cFieldText As String
            Dim finMerge As Integer
            Dim fieldNameLen As Integer
            Dim cfName As String
            Dim cTipoSemilla As String = ""
            Dim cVarSemilla As String = ""
            Dim cEnajenado As String = ""
            Dim cDatoFega As String = "1.5 %"
            Dim cDescSemilla As String = ""

            'PARA COMBO DE CULTIVOS++++++++++++++++++++++++++++++++++++++
            cTipoSemilla = cbCultivos.Text
            cSemilla = Cultivos.SacaLetraCultivo(cbCultivos.SelectedValue)

            If cSemilla = "C" Then
                cOtros = "CIANO-OL"
            End If
            'PARA COMBO DE CULTIVOS++++++++++++++++++++++++++++++++++++++

            cDescSemilla = ":" & cbCultivos.Text
            cVarSemilla = "se�alada en el Contrato de Compraventa de " & cTipoSemilla
            cEnajenado = "FINAGIL"

            If cParafin = "S" Then
                cComision = txtPorcomi.Text & " % por comisi�n + IVA por cada Disposici�n"
            End If

            If cSemilla = "C" Then
                cVarSemilla = "seleccionada por el productor "
                cEnajenado = "SERVICIOS ARFIN, S.A. DE C.V."
                cDescSemilla = " CUALQUIER VARIEDAD AUTORIZADA POR EL INIFAP, TALES COMO:"
            End If



            'strUpdate = "UPDATE Avios SET Semilla = '" & cSemilla & "'"
            strUpdate = "UPDATE Avios SET "
            strUpdate = strUpdate & " FechaContrato = '" & DTOC(DateTimePicker1.Value) & "'"
            strUpdate = strUpdate & ", FechaLimiteDTC = '" & DTOC(DateTimePicker2.Value) & "'"
            strUpdate = strUpdate & ", Porcomi = '" & Val(txtPorcomi.Text) & "'"
            strUpdate = strUpdate & ", GaranteHip = '" & txtGHipotecario.Text & "'"
            strUpdate = strUpdate & ", GarantePre = '" & txtGPrendario.Text & "'"
            strUpdate = strUpdate & " WHERE Anexo = '" & cAnexo & "'"

            cm2 = New SqlCommand(strUpdate, cnAgil)
            cnAgil.Open()
            cm2.ExecuteNonQuery()
            cnAgil.Close()
            cnAgil.Dispose()

            ' If cSemilla <> "A" Then
            oRuta = "F:\AV\ContratoAVIO.doc"
            ' Else
            'oRuta = "F:\ContratoAVIO_Algodon.doc"
            ' End If

            oWord = New Microsoft.Office.Interop.Word.Application()

            oWordDoc = New Microsoft.Office.Interop.Word.Document()

            ' Cargo la plantilla

            oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)
            With oWordDoc.Sections(1)
                .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                If Round(nImporte / nUdi, 2) < nVMUdi Then
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-136-029241/01-01243-0318 ")
                    cReca = "1907-136-028629/01-06685-1217 "
                End If
                .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "CONTRATO DE HABILITACION O AVIO N0. " & Mid(cAnexo, 1, 5))
            End With

            '        .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddHorizontalLineStandard()

            ' Abro el Contrato


            For Each myMField In oWordDoc.Fields

                rFieldCode = myMField.Code

                cFieldText = rFieldCode.Text

                ' Como los Campos de Word Comienzan por el nombre MERGEFIELD, solo tratamos estos campos

                If cFieldText.StartsWith(" MERGEFIELD") Then

                    ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo �nicamente

                    finMerge = cFieldText.IndexOf("\")

                    fieldNameLen = cFieldText.Length - finMerge

                    cfName = cFieldText.Substring(11, finMerge - 11)

                    ' Guardamos el nombre del campo en la variable, quit�ndole los espacios en blanco

                    cfName = cfName.Trim()

                    ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                    ' y si es asi le aplicamos el valor de la variable

                    Select Case cfName

                        Case "mContrato"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4))
                        Case "mDisposicion"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Mid(cAnexo, 6, 4)
                        Case "mCtoMaestro"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Mid(cAnexo, 1, 5)
                        Case "mEncabezado"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cEncabezado
                        Case "mEncabezado2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cEncabezado2
                        Case "mDescr"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cDescr) & Chr(13) & Chr(13) & " DECLARA EL ACREDITADO QUE " & cGeneClie & ", CON CURP: " & cCURP
                        Case "mDescr2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cDescr)
                        Case "mRepresentante"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRepresentante
                        Case "mParrafoRepres"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRepresentante & cParrafoRepres
                        Case "mRfc"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cRfc)
                        Case "mCalle"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cCalle)
                        Case "mColonia"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cColonia)
                        Case "mCopos"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cCopos)
                        Case "mDelegacion"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cDelegacion)
                        Case "mEstado"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cEstado)
                        Case "mInmuebles"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cInmuebles.ToUpper
                        Case "mMuebles"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cMuebles.ToUpper
                        Case "mUsufructo"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cUsufructo.ToUpper
                        Case "mGeneClie"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cGeneClie.ToUpper
                        Case "mImporte"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cImporte.ToUpper
                        Case "mImporteLetra"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cCantidad.ToUpper
                        Case "mPlazoCred"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            'If Trim(cFTermino2) <> "" And Trim(cFTermino3) <> "" Then
                            '    myMField.Result.Text = "ANUAL, CON FECHAS DE VENCIMIENTO EL " & cFTermino.ToUpper & ", " & (Mes(cFTermino2).ToLower).ToUpper & ", " & (Mes(cFTermino3).ToLower).ToUpper
                            'Else
                            myMField.Result.Text = "ANUAL, CON FECHA DE VENCIMIENTO EL " & cFTermino.ToUpper
                            '     End If
                        Case "mDiferencialFINAGIL"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDiferencialFINAGIL
                        Case "mAval1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cAval1.ToUpper
                        Case "mHectareas"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cHectareas
                        Case "mToneladas"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cToneladas
                        Case "mRendimiento"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRendimiento
                        Case "mPredios"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cPredios
                        Case "mParrafoHipoteca"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cParrafoHipoteca
                        Case "mParrafoPrenda"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cParrafoPrenda
                        Case "mGravamen"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cGravamen
                        Case "mGa"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cGtoAdmin
                        Case "mReca"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cReca
                        Case "mFechaLimiteDTC"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            ' If cFLimite2 = "" And cFLimite3 = "" Then
                            myMField.Result.Text = Mes(DTOC(DateTimePicker2.Value)).ToLower
                            'ElseIf cFLimite2 <> "" And cFLimite3 = "" Then
                            '    myMField.Result.Text = Mes(DTOC(DateTimePicker2.Value)).ToLower & ", " & Mes(cFLimite2).ToLower
                            'ElseIf cFLimite2 <> "" And cFLimite3 <> "" Then
                            '    myMField.Result.Text = Mes(DTOC(DateTimePicker2.Value)).ToLower & ", " & Mes(cFLimite2).ToLower & ", " & Mes(cFLimite3).ToLower
                            'End If
                        Case "mFechaFirma"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFechaFirma
                        Case "mFirmaAval1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval1 & " " & cAval1b
                        Case "mFirmaAval2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval2 & " " & cAval2b
                        Case "mFirmaAval3"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval3 & " " & cAval3b
                        Case "mFirmaAval4"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval4 & " " & cAval4b
                        Case "mLeyendaNotario"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cLeyendaNotario
                        Case "mLeyendaRegistrador"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cLeyendaRegistrador
                        Case "mFirmaRegistrador"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaRegistrador
                        Case "mTipoSemilla"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cTipoSemilla
                        Case "mVarSemillas"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cVarSemilla
                        Case "mDescSemilla"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDescSemilla
                        Case "mEnajenado"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cEnajenado
                        Case "mFechaSiembra"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFechaSiembra
                        Case "mFechaCosecha"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFechaCosecha
                        Case "mDatosAv"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDatosAval
                        Case "mEmpcv"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cEmpcv
                        Case "mC_Venta"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cC_Venta
                        Case "mC_Venta2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cC_Venta2
                        Case "mCtoC_Venta"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cCtoC_Venta
                        Case "mPirineos"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cPirineos
                        Case "mLugar"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cLugar
                        Case "mTestigos"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Chr(13) & cTestigos
                        Case "mFirmaTestigo1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaTestigo1
                        Case "mFirmaTestigo2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaTestigo2
                        Case "mFirmaFINAGIL"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaFINAGIL
                        Case "mAvales"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cAvales & Chr(10) & cDatosAval
                        Case "mUnidadEsp"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cUnidadEsp
                        Case "mFirman"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If Trim(cFirman) <> "" Then
                                myMField.Result.Text = Chr(13) & "PERSONAS QUE FIRMAN EN REPRESENTACION DE LA EMPRESA: " & cFirman & " " & cParrafoRepres
                            Else
                                myMField.Result.Text = ""
                            End If
                        Case "mGarantias"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cGarantias
                        Case "mAgroquimi"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cAgroquimi
                        Case "mAgroquimi2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cAgroquimi2
                        Case "mOtros"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cOtros
                        Case "mAportInv"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = "$ " & FormatNumber(nAportInv).ToString
                        Case "mAportInvLetra"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Letras(nAportInv)
                        Case "mMontoInv"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = "$ " & FormatNumber(nMontoInv).ToString
                        Case "mMtoInvLetra"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Letras(nMontoInv)
                        Case "mHcAct"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = nHectareas
                        Case "mFechaTer"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Mes(cFechaTermino).ToLower
                        Case "mNum"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cNum
                        Case "mNum1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cNum1
                        Case "mNum2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cNum2
                        Case "mDatoFega"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDatoFega
                        Case "mTrianual"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cTrianual
                        Case "mPrimera"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cPrimera
                        Case "mSegunda"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cSegunda
                        Case "mCAT"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Round(nCAT, 1).ToString & "%"
                        Case "mDesCiclo"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDescCiclo
                        Case "mComision"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cComision
                        Case "mDescFrec"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            'If Trim(cFTermino2) <> "" And Trim(cFTermino3) <> "" Then
                            '    myMField.Result.Text = Mes(cFechaTermino).ToLower & ", " & Mes(cFTermino2).ToLower & ", " & Mes(cFTermino3).ToLower
                            'Else
                            myMField.Result.Text = Mes(cFechaTermino).ToLower
                            '   End If
                        Case "mGHip"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(txtGHipotecario.Text)
                        Case "mGPre"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(txtGPrendario.Text)
                    End Select

                    oWord.Selection.Fields.Update()

                End If

            Next

            'Guardo el documento

            oWord.ActiveDocument.Select()

            oWord.ActiveDocument.SaveAs("C:\Contratos\" & Trim(cDescr) & ".DOC")

            oWord.ActiveDocument.Close()

            OpenFile("C:\Contratos\" & Trim(cDescr) & ".DOC")

        End If

    End Sub

    Public Sub OpenFile(ByVal Path As String)

        Try

            Dim InfoProceso As New System.Diagnostics.ProcessStartInfo

            Dim Proceso As New System.Diagnostics.Process

            With InfoProceso

                .FileName = Path

                .CreateNoWindow = True

                .ErrorDialog = True

                .UseShellExecute = True

                .WindowStyle = ProcessWindowStyle.Normal

            End With

            Proceso.StartInfo = InfoProceso

            Proceso.Start()

            Proceso.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al abrir el documento")

        End Try

        Me.Close()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    'Private Sub ckbMaiz_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    ckbTrigo.Checked = False
    '    ckbSorgo.Checked = False
    '    ckbCartamo.Checked = False
    '    ckbAlgodon.Checked = False
    '    ckbGarbanzo.Checked = False
    'End Sub

    'Private Sub ckbSorgo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    ckbMaiz.Checked = False
    '    ckbTrigo.Checked = False
    '    ckbCartamo.Checked = False
    '    ckbAlgodon.Checked = False
    '    ckbGarbanzo.Checked = False
    'End Sub

    'Private Sub ckbTrigo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    ckbMaiz.Checked = False
    '    ckbSorgo.Checked = False
    '    ckbCartamo.Checked = False
    '    ckbAlgodon.Checked = False
    '    ckbGarbanzo.Checked = False
    'End Sub

    Private Sub btnImpPagare_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImpPagare.Click

        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String

        Dim nImpPag2 As Decimal
        Dim cEmpOrden As String
        Dim cDomEmpOrd As String

        If Not IsNumeric(txtImporte.Text) Then
            MessageBox.Show("Falta importe", "Importe pagar�")
            txtImporte.Focus()
            Exit Sub
        End If

        nImpPag2 = txtImporte.Text * 0.1

        'oRuta = "C:\Contratos\Pagares.doc"
        oRuta = "F:\AV\Pagares.doc"

        oWord = New Microsoft.Office.Interop.Word.Application()

        'oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantilla

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

        With oWordDoc.Sections(1)
            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
        End With

        If cSucursal = "03" Then
            cEmpOrden = "TABLEX MILLER S. DE R.L. DE C.V."
            cDomEmpOrd = "Carrt. Fedederal Mochis Obregon Km. 173 mas 175 S/N., C.P. 85236, Navojoa Sonora, M�xico"

        ElseIf cSucursal = "04" Then
            If rbMolinos.Checked = True Then
                cEmpOrden = "MOLINOS DEL SUDESTE S.A. DE C.V."
                cDomEmpOrd = "Av. Industrial Puebla # 562, Colonia Parque Industrial Puebla C.P. 21620, Mexicali Baja California"
            ElseIf rbArfin.Checked = True Then
                cEmpOrden = "SERVICIOS ARFIN S.A. DE C.V."
                cDomEmpOrd = "calle Leandro Valle numero 402, segundo Piso, Colonia Reforma y Ferrocarriles Nacionales, C.P. 50070, en la entidad de Toluca, Estado de M�xico,"
            End If
        ElseIf cSucursal = "05" Then
            cEmpOrden = "HARINERA LOS PIRINEOS S.A. DE C.V."
            cDomEmpOrd = "Blvd. Paseo Solidaridad # 10781, Colonia Esfuerzo Obrero C.P. 36580, Irapuato Guanajuato"
        End If

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            ' Como los Campos de Word Comienzan por el nombre MERGEFIELD, solo tratamos estos campos

            If cFieldText.StartsWith(" MERGEFIELD") Then

                ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo �nicamente

                finMerge = cFieldText.IndexOf("\")

                fieldNameLen = cFieldText.Length - finMerge

                cfName = cFieldText.Substring(11, finMerge - 11)

                ' Guardamos el nombre del campo en la variable, quit�ndole los espacios en blanco

                cfName = cfName.Trim()

                ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                ' y si es asi le aplicamos el valor de la variable

                Select Case cfName

                    Case "mDescr"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDescr)
                    Case "mRepresentante"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cRepresentante)
                    Case "mCalle"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCalle)
                    Case "mColonia"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cColonia)
                    Case "mCopos"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cCopos)
                    Case "mDelegacion"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDelegacion)
                    Case "mEstado"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cEstado)
                    Case "mEmpOrden"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cEmpOrden
                    Case "mDomEmpOrd"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDomEmpOrd
                    Case "mImporte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(txtImporte.Text, 2)
                    Case "mImporte2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = FormatNumber(nImpPag2, 2)
                    Case "mImporteLetra"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Letras(txtImporte.Text)
                    Case "mImporteLetra2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Letras(Round(nImpPag2, 2))
                    Case "mDiferencialFINAGIL"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDiferencialFINAGIL & " " & Cant_Letras(Val(cDiferencialFINAGIL), "")
                    Case "mFechaFirma"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(DTOC(dtpFFirma.Value))
                    Case "mFechaPago"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(DTOC(dtpFPago.Value))
                    Case "mFirmaAval1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval1 & " " & cAval1b
                    Case "mFirmaAval2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval2 & " " & cAval2b
                    Case "mFirmaAval3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval3 & " " & cAval3b
                    Case "mFirmaAval4"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval4 & " " & cAval4b
                    Case "mLugar"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cLugar
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        oWord.ActiveDocument.Select()

        oWord.ActiveDocument.SaveAs("C:\Contratos\" & "Pagar� de " & Trim(cDescr) & ".DOC")

        oWord.ActiveDocument.Close()

        Process.Start("C:\Contratos\" & "Pagar� de " & Trim(cDescr) & ".DOC")



    End Sub

    'Private Sub ckbCartamo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ckbMaiz.Checked = False
    '    ckbSorgo.Checked = False
    '    ckbTrigo.Checked = False
    '    ckbAlgodon.Checked = False
    '    ckbGarbanzo.Checked = False
    'End Sub

    'Private Sub ckbAlgodon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ckbMaiz.Checked = False
    '    ckbSorgo.Checked = False
    '    ckbCartamo.Checked = False
    '    ckbTrigo.Checked = False
    '    ckbGarbanzo.Checked = False
    'End Sub

    'Private Sub ckbGarbanzo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ckbMaiz.Checked = False
    '    ckbSorgo.Checked = False
    '    ckbCartamo.Checked = False
    '    ckbAlgodon.Checked = False
    '    ckbTrigo.Checked = False
    'End Sub

    Private Sub btnAnexos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnexos.Click
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm2 As New SqlCommand()
        Dim strUpdate As String
        Dim cFTermino As String

        cFTermino = Mes(cFechaTermino).ToLower
        'cFTermino = cFTermino & Mes(cVenA�o2).ToLower & " Y EL " & Mes(cVenA�o3).ToLower & " PREVIA AUTORIZACION DE FINAGIL."

        cFechaFirma = Mes(DTOC(DateTimePicker1.Value)).ToLower


        If cbCultivos.SelectedIndex < 0 Then
            MsgBox("Selecciona el Tipo de Semilla para el Contrato", MsgBoxStyle.Critical, "Mensaje")
        Else
            Dim oNulo As Object = System.Reflection.Missing.Value
            Dim oRuta As New Object
            Dim myMField As Microsoft.Office.Interop.Word.Field
            Dim rFieldCode As Microsoft.Office.Interop.Word.Range
            Dim cFieldText As String
            Dim finMerge As Integer
            Dim fieldNameLen As Integer
            Dim cfName As String
            Dim cTipoSemilla As String = ""
            Dim cVarSemilla As String = ""
            Dim cEnajenado As String = ""
            Dim cDatoFega As String = "1.5 %"
            Dim cDescSemilla As String = ""
            Dim nDiasCto As Integer
            Dim nDiasCto2 As Integer
            Dim nDiasCto3 As Integer

            nDiasCto = DateDiff(DateInterval.Day, DateTimePicker1.Value, CTOD(cFechaTermino))
            nDiasCto2 = DateDiff(DateInterval.Day, DateTimePicker1.Value, CTOD(cFTermino2))
            nDiasCto3 = DateDiff(DateInterval.Day, DateTimePicker1.Value, CTOD(cFTermino3))

            'PARA COMBO DE CULTIVOS++++++++++++++++++++++++++++++++++++++
            cTipoSemilla = cbCultivos.Text
            cSemilla = Cultivos.SacaLetraCultivo(cbCultivos.SelectedValue)

            If cSemilla = "C" Then
                cOtros = "CIANO-OL"
            End If
            'PARA COMBO DE CULTIVOS++++++++++++++++++++++++++++++++++++++

            cDescSemilla = ":" & cbCultivos.Text
            cVarSemilla = "se�alada en el Contrato de Compraventa de " & cTipoSemilla
            cEnajenado = "FINAGIL"

            If cParafin = "S" Then
                cComision = txtPorcomi.Text & " % por comisi�n + IVA por cada Disposici�n"
            End If

            If cSemilla = "C" Then
                cVarSemilla = "seleccionada por el productor "
                cEnajenado = "SERVICIOS ARFIN, S.A. DE C.V."
                cDescSemilla = " CUALQUIER VARIEDAD AUTORIZADA POR EL INIFAP, TALES COMO:"
            End If

            'strUpdate = "UPDATE Avios SET Semilla = '" & cSemilla & "'"
            strUpdate = "UPDATE Avios SET "
            strUpdate = strUpdate & " FechaContrato = '" & DTOC(DateTimePicker1.Value) & "'"
            strUpdate = strUpdate & ", FechaLimiteDTC = '" & DTOC(DateTimePicker2.Value) & "'"
            strUpdate = strUpdate & ", Porcomi = '" & Val(txtPorcomi.Text) & "'"
            strUpdate = strUpdate & ", GaranteHip = '" & txtGHipotecario.Text & "'"
            strUpdate = strUpdate & ", GarantePre = '" & txtGPrendario.Text & "'"
            strUpdate = strUpdate & " WHERE Anexo = '" & cAnexo & "'"

            cm2 = New SqlCommand(strUpdate, cnAgil)
            cnAgil.Open()
            cm2.ExecuteNonQuery()
            cnAgil.Close()
            cnAgil.Dispose()

            oRuta = "F:\AV\ContratoAVIO_Anexos.doc"

            oWord = New Microsoft.Office.Interop.Word.Application()

            oWordDoc = New Microsoft.Office.Interop.Word.Document()

            ' Cargo la plantilla

            oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)
            With oWordDoc.Sections(1)
                .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
                If Round(nImporte / nUdi, 2) < nVMUdi Then
                    .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 1907-136-029241/01-01243-0318 ")
                    cReca = "1907-136-029241/01-01243-0318 "
                End If
                .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "CONTRATO DE HABILITACION Y AVIO NO. " & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4))
            End With

            '        .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddHorizontalLineStandard()

            ' Abro el Contrato


            For Each myMField In oWordDoc.Fields

                rFieldCode = myMField.Code

                cFieldText = rFieldCode.Text

                ' Como los Campos de Word Comienzan por el nombre MERGEFIELD, solo tratamos estos campos

                If cFieldText.StartsWith(" MERGEFIELD") Then

                    ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo �nicamente

                    finMerge = cFieldText.IndexOf("\")

                    fieldNameLen = cFieldText.Length - finMerge

                    cfName = cFieldText.Substring(11, finMerge - 11)

                    ' Guardamos el nombre del campo en la variable, quit�ndole los espacios en blanco

                    cfName = cfName.Trim()

                    ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                    ' y si es asi le aplicamos el valor de la variable

                    Select Case cfName
                        Case "mFondeo"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            Select Case cFondeo
                                Case "01"
                                    myMField.Result.Text = "FIRA (   )                NAFIN (   )           PROPIOS ( X )"
                                Case "02"
                                    myMField.Result.Text = "FIRA (   )                NAFIN ( X )           PROPIOS (   )"
                                Case "03"
                                    myMField.Result.Text = "FIRA ( X )                NAFIN (   )           PROPIOS (   )"
                            End Select
                        Case "mContrato"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4))
                        Case "mFEGA"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = (nPorcFEGA * 100).ToString("n2")
                        Case "mDisposicion"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Mid(cAnexo, 6, 4)
                        Case "mCtoMaestro"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Mid(cAnexo, 1, 5)
                        Case "mEncabezado"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cEncabezado
                        Case "mEncabezado2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cEncabezado2
                        Case "mDescr"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cDescr) & Chr(10) & " DECLARA EL ACREDITADO " & cGeneClie & ", CON CURP: " & cCURP
                        Case "mDescr2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cDescr)
                        Case "mRepresentante"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRepresentante
                        Case "mParrafoRepres"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRepresentante & cParrafoRepres
                        Case "mRfc"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cRfc)
                        Case "mCalle"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cCalle)
                        Case "mColonia"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cColonia)
                        Case "mCopos"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cCopos)
                        Case "mDelegacion"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cDelegacion)
                        Case "mEstado"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cEstado)
                        Case "mReca"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cReca
                        Case "mInmuebles"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cInmuebles.ToUpper
                        Case "mMuebles"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cMuebles.ToUpper
                        Case "mUsufructo"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cUsufructo.ToUpper
                        Case "mGeneClie"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cGeneClie.ToUpper
                        Case "mImporte"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cImporte.ToUpper
                        Case "mImporteLetra"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cCantidad.ToUpper
                        Case "mPlazoCred"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            'If Trim(cFTermino2) <> "" And Trim(cFTermino3) <> "" Then
                            '    myMField.Result.Text = nDiasCto.ToString & " DIAS, CON FECHA DE VENCIMIENTO EL " & cFTermino & " del ciclo " & Trim(cCiclod1) & ", " & nDiasCto2.ToString & " DIAS, CON FECHA DE VENCIMIENTO EL " & Mes(cFTermino2).ToLower & " del ciclo " & Trim(cCiclod2) & ", " & nDiasCto3.ToString & " DIAS, CON FECHA DE VENCIMIENTO EL " & Mes(cFTermino3).ToLower & " del ciclo " & Trim(cCiclod3) & ".D�as contados a partir de la fecha de firma del contrato."
                            'Else
                            myMField.Result.Text = nDiasCto.ToString & " DIAS, CON FECHA DE VENCIMIENTO EL " & cFTermino
                            '  End If
                        Case "mDiferencialFINAGIL"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDiferencialFINAGIL
                        Case "mAval1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cAval1.ToUpper
                        Case "mHectareas"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cHectareas
                        Case "mToneladas"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cToneladas
                        Case "mReca"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cReca
                        Case "mRendimiento"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cRendimiento
                        Case "mPredios"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cPredios
                        Case "mParrafoHipoteca"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cParrafoHipoteca
                        Case "mParrafoPrenda"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cParrafoPrenda
                        Case "mGravamen"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cGravamen
                        Case "mGa"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cGtoAdmin
                        Case "mFechaLimiteDTC"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            ' If cFLimite2 = "" And cFLimite3 = "" Then
                            myMField.Result.Text = Mes(DTOC(DateTimePicker2.Value)).ToLower
                            'ElseIf cFLimite2 <> "" And cFLimite3 = "" Then
                            'myMField.Result.Text = Mes(DTOC(DateTimePicker2.Value)).ToLower & ", " & Mes(cFLimite2).ToLower
                            'ElseIf cFLimite2 <> "" And cFLimite3 <> "" Then
                            'myMField.Result.Text = Mes(DTOC(DateTimePicker2.Value)).ToLower & ", " & Mes(cFLimite2).ToLower & ", " & Mes(cFLimite3).ToLower
                            'End If
                        Case "mFechaFirma"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFechaFirma
                        Case "mFirmaAval1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval1 & " " & cAval1b
                        Case "mFirmaAval2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval2 & " " & cAval2b
                        Case "mFirmaAval3"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval3 & " " & cAval3b
                        Case "mFirmaAval4"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval4 & " " & cAval4b
                        Case "mLeyendaNotario"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cLeyendaNotario
                        Case "mLeyendaRegistrador"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cLeyendaRegistrador
                        Case "mFirmaRegistrador"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaRegistrador
                        Case "mTipoSemilla"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cTipoSemilla
                        Case "mVarSemillas"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cVarSemilla
                        Case "mDescSemilla"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDescSemilla
                        Case "mEnajenado"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cEnajenado
                        Case "mFechaSiembra"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFechaSiembra
                        Case "mFechaCosecha"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFechaCosecha
                        Case "mDatosAv"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDatosAval
                        Case "mEmpcv"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cEmpcv
                        Case "mC_Venta"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cC_Venta
                        Case "mC_Venta2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cC_Venta2
                        Case "mCtoC_Venta"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cCtoC_Venta
                        Case "mPirineos"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cPirineos
                        Case "mLugar"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cLugar
                        Case "mTestigos"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Chr(13) & cTestigos
                        Case "mFirmaTestigo1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaTestigo1
                        Case "mFirmaTestigo2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaTestigo2
                        Case "mFirmaFINAGIL"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaFINAGIL
                        Case "mAvales"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cAvales & Chr(10) & cDatosAval
                        Case "mUnidadEsp"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cUnidadEsp
                        Case "mFirman"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If Trim(cFirman) <> "" Then
                                myMField.Result.Text = Chr(13) & Chr(13) & "PERSONAS QUE FIRMAN EN REPRESENTACION DE LA EMPRESA: " & cFirman & " " & cParrafoRepres
                            Else
                                myMField.Result.Text = ""
                            End If
                        Case "mGarantias"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cGarantias
                        Case "mAgroquimi"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cAgroquimi
                        Case "mAgroquimi2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cAgroquimi2
                        Case "mFertilizante"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFertilizante
                        Case "mHerbicidas"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cHerbicidas
                        Case "mOtros"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cOtros
                        Case "mAportInv"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = "$ " & FormatNumber(nAportInv).ToString
                        Case "mAportInvLetra"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Letras(nAportInv)
                        Case "mMontoInv"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = "$ " & FormatNumber(nMontoInv).ToString
                        Case "mMtoInvLetra"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Letras(nMontoInv)
                        Case "mHcAct"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = nHectareas
                        Case "mFechaTer"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            'If Trim(cFTermino2) <> "" And Trim(cFTermino3) <> "" Then
                            '    myMField.Result.Text = "CON FECHAS DE VENCIMIENTO EL " & cFTermino & ", " & Mes(cFTermino2).ToLower & ", " & Mes(cFTermino3).ToLower
                            'Else
                            myMField.Result.Text = "CON FECHA DE VENCIMIENTO EL " & cFTermino
                            '     End If
                        Case "mFechaTer2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFTermino
                        Case "mNum"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cNum
                        Case "mNum1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cNum1
                        Case "mNum2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cNum2
                        Case "mDatoFega"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDatoFega
                        Case "mTrianual"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cTrianual
                        Case "mPrimera"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cPrimera
                        Case "mSegunda"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cSegunda
                        Case "mCAT"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Round(nCAT, 1).ToString & "%"
                        Case "mDesCiclo"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDescCiclo
                        Case "mComision"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cComision
                        Case "mTaspen"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If nTaspen = 0 Then
                                myMField.Result.Text = "N/A"
                            Else
                                myMField.Result.Text = nTaspen.ToString & "% del monto que se pague con aticipaci�n"
                            End If
                        Case "mSVbco"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cTipo = "F" Or cTipo = "E" Then
                                myMField.Result.Text = "Seguro de Vida: A elecci�n del cliente"
                            Else
                                myMField.Result.Text = ""
                            End If
                        Case "mSVclau"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cTipo = "F" Or cTipo = "E" Then
                                myMField.Result.Text = "Vig�sima Octava: Seguro de Vida"
                            Else
                                myMField.Result.Text = ""
                            End If
                        Case "mSVparr1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = "SEGURO DE VIDA: "
                        Case "mSVparr"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cTipo = "F" Or cTipo = "E" Then
                                myMField.Result.Text = "CONTRATADO CON GRUPO NACIONAL PROVINCIAL, S.A.B. CON LAS SIGUIENTES CONDICIONES APLICABLES:"
                            Else
                                myMField.Result.Text = "N/A"
                            End If
                        Case "mSegV1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cTipo = "F" Or cTipo = "E" Then
                                myMField.Result.Text = "Del 01 de noviembre de 2016 al 01 de noviembre de 2017, renovable anualmente hasta la total liquidaci�n del contrato con la aseguradora que seleccione el acreditado con la conformidad de la acreditante."
                            Else
                                myMField.Result.Text = "N/A"
                            End If
                        Case "mSegV2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cTipo = "F" Or cTipo = "E" Then
                                myMField.Result.Text = "Mensual vencida"
                            Else
                                myMField.Result.Text = "N/A"
                            End If
                        Case "mSegV3"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cTipo = "F" Or cTipo = "E" Then
                                myMField.Result.Text = "sobre el saldo insoluto, con un monto m�ximo por asegurado de $ 5�000,000.00"
                            Else
                                myMField.Result.Text = "N/A"
                            End If
                        Case "mSegV4"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cTipo = "F" Or cTipo = "E" Then
                                myMField.Result.Text = "70 a�os"
                            Else
                                myMField.Result.Text = "N/A"
                            End If
                        Case "mSegV5"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cTipo = "F" Or cTipo = "E" Then
                                myMField.Result.Text = "75 a�os"
                            Else
                                myMField.Result.Text = "N/A"
                            End If
                        Case "mSegV6"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cTipo = "F" Or cTipo = "E" Then
                                myMField.Result.Text = "El costo de la prima ser� mensual de 1 al millar sobre saldos insolutos"
                            Else
                                myMField.Result.Text = "N/A"
                            End If
                        Case "mSegV7"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cTipo = "F" Or cTipo = "E" Then
                                myMField.Result.Text = "Se establece que las condiciones del seguro de vida contratado se renovar�n anualmente, en los t�rminos que establece la Aseguradora."
                            Else
                                myMField.Result.Text = ""
                            End If
                        Case "mDescFrec"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            'If Trim(cFTermino2) <> "" And Trim(cFTermino3) <> "" Then
                            '    myMField.Result.Text = Mes(cFechaTermino).ToLower & ", " & Mes(cFTermino2).ToLower & ", " & Mes(cFTermino3).ToLower
                            'Else
                            myMField.Result.Text = Mes(cFechaTermino).ToLower
                            '        End If
                        Case "mGHip"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(txtGHipotecario.Text)
                        Case "mGPre"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(txtGPrendario.Text)
                        Case "mAGarLIQ"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cApliGarLIQ = "SI" Then
                                myMField.Result.Text = "10% DEL MONTO DE CADA DISPOSICION"
                            Else
                                myMField.Result.Text = "0% DEL MONTO DE CADA DISPOSICION"
                            End If
                    End Select

                    oWord.Selection.Fields.Update()

                End If

            Next

            'Guardo el documento

            oWord.ActiveDocument.Select()

            oWord.ActiveDocument.SaveAs("C:\Contratos\" & Trim(cDescr) & "_Anexos.DOC")

            oWord.ActiveDocument.Close()

            OpenFile("C:\Contratos\" & Trim(cDescr) & "_Anexos.DOC")

        End If

    End Sub

    Private Sub btnConvenio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvenio.Click
        Dim newfrmConvenio As New frmConvenio(cAnexo & cCiclo)
        newfrmConvenio.Show()
    End Sub

    Private Sub btnPagGL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagGL.Click
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String

        Dim nImpPag2 As Decimal
        Dim cEmpOrden As String
        Dim cDomEmpOrd As String



        If cGarliq = "SI" Then
            If Not IsNumeric(txtImporte.Text) Then
                MessageBox.Show("Falta importe", "Importe pagar�")
                txtImporte.Focus()
                Exit Sub
            End If
            nImpPag2 = txtImporte.Text * 0.1

            'oRuta = "C:\Contratos\Pagares.doc"
            oRuta = "F:\AV\PagaresGL.doc"

            oWord = New Microsoft.Office.Interop.Word.Application()

            oWordDoc = New Microsoft.Office.Interop.Word.Document()

            ' Cargo la plantilla

            oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

            If cSemilla = "T" Then
                If rbArfin.Checked = True Then
                    cEmpOrden = "SERVICIOS ARFIN S.A. DE C.V."
                    cDomEmpOrd = "calle Leandro Valle numero 402, segundo Piso, Colonia Reforma y Ferrocarriles Nacionales, C.P. 50070, en la entidad de Toluca, Estado de M�xico,"
                ElseIf cSucursal = "03" Then
                    cEmpOrden = "TABLEX MILLER S. DE R.L. DE C.V."
                    cDomEmpOrd = "Carrt. Fedederal Mochis Obregon Km. 173 mas 175 S/N., C.P. 85236, Navojoa Sonora, M�xico"
                ElseIf cSucursal = "04" Then
                    cEmpOrden = "MOLINOS DEL SUDESTE S.A. DE C.V."
                    cDomEmpOrd = "Av. Industrial Puebla # 562, Colonia Parque Industrial Puebla C.P. 21620, Mexicali Baja California"
                ElseIf cSucursal = "05" Then
                    cEmpOrden = "HARINERA LOS PIRINEOS S.A. DE C.V."
                    cDomEmpOrd = "Blvd. Paseo Solidaridad # 10781, Colonia Esfuerzo Obrero C.P. 36580, Irapuato Guanajuato"
                End If
            Else
                cEmpOrden = "SERVICIOS ARFIN S.A. DE C.V."
                cDomEmpOrd = "calle Leandro Valle numero 402, segundo Piso, Colonia Reforma y Ferrocarriles Nacionales, C.P. 50070, en la entidad de Toluca, Estado de M�xico,"
            End If

            For Each myMField In oWordDoc.Fields

                rFieldCode = myMField.Code

                cFieldText = rFieldCode.Text

                ' Como los Campos de Word Comienzan por el nombre MERGEFIELD, solo tratamos estos campos

                If cFieldText.StartsWith(" MERGEFIELD") Then

                    ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo �nicamente

                    finMerge = cFieldText.IndexOf("\")

                    fieldNameLen = cFieldText.Length - finMerge

                    cfName = cFieldText.Substring(11, finMerge - 11)

                    ' Guardamos el nombre del campo en la variable, quit�ndole los espacios en blanco

                    cfName = cfName.Trim()

                    ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                    ' y si es asi le aplicamos el valor de la variable

                    Select Case cfName

                        Case "mDescr"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cDescr)
                        Case "mRepresentante"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cRepresentante)
                        Case "mCalle"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cCalle)
                        Case "mColonia"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cColonia)
                        Case "mCopos"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cCopos)
                        Case "mDelegacion"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cDelegacion)
                        Case "mEstado"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Trim(cEstado)
                        Case "mEmpOrden"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cEmpOrden
                        Case "mDomEmpOrd"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDomEmpOrd
                        Case "mImporte"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = FormatNumber(txtImporte.Text, 2)
                        Case "mImporte2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = FormatNumber(nImpPag2, 2)
                        Case "mImporteLetra"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Letras(txtImporte.Text)
                        Case "mImporteLetra2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Letras(Round(nImpPag2, 2))
                        Case "mDiferencialFINAGIL"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cDiferencialFINAGIL & " " & Cant_Letras(Val(cDiferencialFINAGIL), "")
                        Case "mFechaFirma"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Mes(DTOC(dtpFFirma.Value))
                        Case "mFechaPago"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Mes(DTOC(dtpFPago.Value))
                        Case "mFirmaAval1"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval1 & " " & cAval1b
                        Case "mFirmaAval2"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval2 & " " & cAval2b
                        Case "mFirmaAval3"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval3 & " " & cAval3b
                        Case "mFirmaAval4"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cFirmaAval4 & " " & cAval4b
                        Case "mLugar"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cLugar
                    End Select

                    oWord.Selection.Fields.Update()

                End If

            Next

            'Guardo el documento

            oWord.ActiveDocument.Select()

            oWord.ActiveDocument.SaveAs("C:\Contratos\" & "Pagar� GL de " & Trim(cDescr) & ".DOC")

            oWord.ActiveDocument.Close()

            OpenFile("C:\Contratos\" & "Pagar� GL de " & Trim(cDescr) & ".DOC")
        Else

            MsgBox("NO Aplica Garant�a L�quida para este Contrato", MsgBoxStyle.Critical, "Mensaje")

        End If

    End Sub

    Private Sub BtnPLD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPLD.Click
        DOC_Pld.CreaDocumento(cAnexo, cCiclo)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New FrmHojaCambios
        f.BanSolHC = True ' HCsol
        f.cAnexo = cAnexo
        f.Show()
    End Sub
End Class
