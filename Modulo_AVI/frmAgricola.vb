Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports Microsoft.VisualBasic
Imports System.Security
Imports System.Security.Principal.WindowsIdentity

Public Class frmAgricola

    ' Declaraci�n de variables de conexi�n ADO .NET de alcance privado
    Dim Cultivos As New GeneralDSTableAdapters.CultivosTableAdapter
    Dim TaMfinagil As New AviosDSXTableAdapters.mFINAGILTableAdapter
    Dim taHojaCamb As New MesaControlDSTableAdapters.AnexosLiberacionTableAdapter
    Dim cnAgil As New SqlConnection(strConn)
    Dim dtPagares As New DataTable
    Dim dtFIRA As New DataTable
    Dim myKeySearch(0) As String

    ' Declaraci�n de variables de datos de alcance privado

    Dim cAnexo As String = ""
    Dim cTipar As String = ""
    Dim Sucursal As String = ""
    Dim cCiclo As String = ""
    Dim cCliente As String = ""
    Dim lInsertFINAGIL As Boolean
    Dim lInsertFIRA As Boolean
    Dim lUpdateFIRA As Boolean
    Dim nImporteAnterior As Decimal = 0
    Dim nMinistradoFIRA As Decimal = 0
    Dim nMinistradoFINAGIL As Decimal = 0
    Dim nRowsFINAGIL As Byte
    Dim nRowsFIRA As Byte
    Dim nRegistroFINAGIL As Byte
    Dim nRegistroFIRA As Byte
    Dim cFechaAutorizacion As String
    Dim cFechaTerminacion As String
    Dim AplicaFega, FegaFlat As Boolean
    Dim nPorcFega As Decimal = 0
    Dim lFirstTime As Boolean = True
    Dim myIdentity As Principal.WindowsIdentity
    Dim cUsuario As String

    Public Sub New(ByVal cLinea As String)

        MyBase.New()

        'This call is required by the Windows Form Designer.

        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        cAnexo = Mid(cLinea, 1, 10)

        If Mid(cLinea, 12, 6) = "PAGARE" Then
            Me.Text = "Control de Ministraciones del Cr�dito en Cuenta Corriente " & cAnexo
        Else
            Me.Text = "Control de Ministraciones del Contrato de Av�o " & cAnexo
        End If

        lblAnexo.Text = cAnexo
        txtCiclo.Text = Mid(cLinea, 12, 47)

        cAnexo = Mid(lblAnexo.Text, 1, 5) & Mid(lblAnexo.Text, 7, 4)
        If Mid(cLinea, 12, 6) = "PAGARE" Then
            cCiclo = Mid(cLinea, 19, 2)
            cTipar = "C"
        Else
            cCiclo = Mid(cLinea, 18, 2)
            cTipar = "H"
        End If

        ' Crear la tabla que contendr� la informaci�n de las ministraciones FINAGIL - Productor
        Dim myColArray(0) As DataColumn
        ' Crear la tabla que contendr� la informaci�n de los pagar�s firmados por el Productor

        dtPagares.Columns.Add("No.", Type.GetType("System.Decimal"))
        dtPagares.Columns.Add("Fecha Pagar�", Type.GetType("System.String"))
        dtPagares.Columns.Add("Importe", Type.GetType("System.String"))
        dtPagares.Columns.Add("Garantia", Type.GetType("System.String"))

        ' Crear la tabla que contendr� la informaci�n de las ministraciones FIRA - FINAGIL

        dtFIRA.Columns.Add("No.", Type.GetType("System.Decimal"))
        dtFIRA.Columns.Add("Fecha Programada", Type.GetType("System.String"))
        dtFIRA.Columns.Add("Importe", Type.GetType("System.String"))
        dtFIRA.Columns.Add("FEGA", Type.GetType("System.String"))
        dtFIRA.Columns.Add("Estado", Type.GetType("System.String"))

        ' Tengo que definir una llave primaria para la tabla dtFIRA a fin de buscar un registro cuando desee actualizarlo

        myColArray(0) = dtFIRA.Columns("No.")
        dtFIRA.PrimaryKey = myColArray
    End Sub

    Private Sub FrmAgricola_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AVI_AjustesHectareasTableAdapter.Fill(Me.AviosDSX.AVI_AjustesHectareas, cAnexo, cCiclo)
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim daAvio As New SqlDataAdapter(cm1)
        Dim daFIRA As New SqlDataAdapter(cm2)
        Dim daPagares As New SqlDataAdapter(cm4)

        Dim dsAgil As New DataSet()
        Dim drAvio As DataRow
        Dim drPagare As DataRow
        Dim drMinistracion As DataRow
        Dim drAux As DataRow


        ' Declaraci�n de variables de datos

        Dim cFlcan As String = ""
        Dim cNombreProductor As String = ""
        Dim i As Byte
        Dim nRendimiento As Decimal = 0
        Dim nVariacion As Decimal = 0
        Dim nSumaPagares As Decimal = 0

        myIdentity = GetCurrent()
        cUsuario = myIdentity.Name
        Label4.Text = cUsuario


        ' Aqu� tengo que validar si se trata de un Contrato Terminado en cuyo caso solo se podr�
        ' consultar la informaci�n de las ministraciones otorgadas sin opci�n a modificar nada


        ' El siguiente Command trae los datos del contrato de Habilitaci�n o Av�o

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Avios.*, Descr, Banco, CuentaBancomer, CuentaCLABE, Nombre_Sucursal, Clientes.Sucursal FROM Avios " &
                           "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " &
                           "INNER JOIN Sucursales ON Clientes.Sucursal = Sucursales.ID_Sucursal " &
                           "WHERE Anexo = " & "'" & cAnexo & "' AND Ciclo = '" & cCiclo & "'"
            .Connection = cnAgil
        End With

        ' El siguiente Command trae los datos de las ministraciones FIRA - FINAGIL

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM mFIRA " &
                           "WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "' " &
                           "ORDER BY Ministracion"
            .Connection = cnAgil
        End With

        ' El siguiente Command trae los datos de los pagar�s firmados por el Productor

        With cm4
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM PagaresAvio " &
                           "WHERE Anexo = '" & cAnexo & "' AND Ciclo = '" & cCiclo & "' " &
                           "ORDER BY Numero"
            .Connection = cnAgil
        End With

        nMinistradoFIRA = 0

        cbFEGA.Items.Add("NO")
        cbFEGA.Items.Add("SI")

        cbEstado.Items.Add("PENDIENTE")
        cbEstado.Items.Add("OTORGADO")

        btnModificarFIRA.Visible = False
        panelFIRA.Visible = False

        If TaQUERY.SacaPermisoModulo("MINISTRAR_SEG", UsuarioGlobal) > 0 Then
            cbDocumento.Items.Add("SEGURO")
        Else
            cbDocumento.Items.Add("EFECTIVO")
            cbDocumento.Items.Add("EFECTIVO 2")
            cbDocumento.Items.Add("NOTARIO")
            cbDocumento.Items.Add("VALE")
            cbDocumento.Items.Add("BURO")
            cbDocumento.Items.Add("GASTOS")
            cbDocumento.Items.Add("ASISTENCIA")
            cbDocumento.Items.Add("COMISION")
            cbDocumento.Items.Add("ANALISIS DE SUELOS")
            cbDocumento.Items.Add("AVALUO")
            cbDocumento.Items.Add("RPP")
        End If

        btnModificarFINAGIL.Visible = False
        panelFINAGIL.Visible = False

        ' Llenar el dataset lo cual abre y cierra la conexi�n

        daAvio.Fill(dsAgil, "Avios")
        daFIRA.Fill(dsAgil, "FIRA")
        Me.Sp_AVI_MinistracionesTableAdapter.Fill(AviosDSX.sp_AVI_Ministraciones, cAnexo, cCiclo)
        nMinistradoFINAGIL = Me.Sp_AVI_MinistracionesTableAdapter.TotalMinistrado(cAnexo, cCiclo)
        SpAVIMinistracionesBindingSource.MoveLast()
        daPagares.Fill(dsAgil, "Pagares")

        ' Informaci�n del contrato de habilitaci�n o av�o

        drAvio = dsAgil.Tables("Avios").Rows(0)

        cFlcan = drAvio("Flcan")
        If drAvio("Tasas") = 0 And drAvio("DiferencialFinagil") = 0 Then
            MessageBox.Show("Contrato sin Tasa de Interes, favor de notificar a Contabilidad.", "Error en Contrato.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnInsertarFINAGIL.Enabled = False
            btnInsertarFIRA.Enabled = False
            Exit Sub
        End If

        cNombreProductor = Trim(Mid(drAvio("Descr"), 1, 80))

        lblAnexo.Text = lblAnexo.Text.Substring(0, 10) & "   " & cNombreProductor
        TxtSucursal.Text = "Sucursal: " & Trim(drAvio("Nombre_Sucursal"))
        TxtidCred.Text = "ID Cr�dito:" & drAvio("IDCredito")
        cCliente = Trim(drAvio("Cliente"))
        Sucursal = Trim(drAvio("Sucursal"))
        Select Case drAvio("tipar")
            Case "A"
                TxtTipo.Text = "Tipo: ANTICIPO  "
            Case "C"
                TxtTipo.Text = "Tipo: CUENTA CORREIENTE "
            Case "H"
                TxtTipo.Text = "Tipo: AVIO "
        End Select
        If drAvio("tipar") <> "C" Then
            TxtCultivo.Text = Cultivos.SacaCultivo(drAvio("Semilla"))
            TxtCultivo.Text = "Cultivo: " & TxtCultivo.Text
        Else
            TxtCultivo.Text = ""
        End If


        txtLineaAutorizada.Text = Format(drAvio("LineaActual"), "##,##0.00")
        txtHectareasActual.Text = Format(drAvio("HectareasActual"), "##,##0.00")
        AplicaFega = drAvio("AplicaFega")
        FegaFlat = drAvio("FegaFlat")
        cFechaAutorizacion = drAvio("FechaAutorizacion")
        cFechaTerminacion = drAvio("FechaTerminacion")
        nPorcFega = drAvio("PorcFega")

        If cFlcan <> "A" And cFlcan <> "F" Then
            btnInsertarFIRA.Enabled = False
            btnModificarFIRA.Enabled = False
            panelFIRA.Enabled = False
            btnModificarFINAGIL.Enabled = False
        End If

        ' Informaci�n de las ministraciones FINAGIL - Productor
        nRowsFINAGIL = AviosDSX.sp_AVI_Ministraciones.Rows.Count()
        If nRowsFINAGIL > 0 Then
            btnModificarFINAGIL.Visible = True
        End If

        If nMinistradoFINAGIL > 0 Then
            lblMinistradoFINAGIL.Text = "Total Ministrado por FINAGIL al Productor $" & Format(nMinistradoFINAGIL, "##,##0.00")
        Else
            lblMinistradoFINAGIL.Text = ""
        End If

        'dgvFINAGIL.DataSource = dtFINAGIL
        dgvFINAGIL.Columns(0).Width = 25
        dgvFINAGIL.Columns(1).Width = 90
        dgvFINAGIL.Columns(2).Width = 65
        dgvFINAGIL.Columns(3).Width = 100
        dgvFINAGIL.Columns(4).Width = 100
        dgvFINAGIL.Columns(5).Width = 60
        dgvFINAGIL.Columns(6).Width = 90


        For i = 0 To dgvFINAGIL.Columns.Count - 1
            dgvFINAGIL.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            If i = 0 Or i = 2 Or i = 5 Then
                dgvFINAGIL.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el encabezado
                dgvFINAGIL.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el contenido
            ElseIf i = 1 Then
                dgvFINAGIL.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft ' Alinea el encabezado
                dgvFINAGIL.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft ' Alinea el contenido
            ElseIf i = 3 Or i = 4 Then
                dgvFINAGIL.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el encabezado
                dgvFINAGIL.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el contenido
            ElseIf i = 6 Then
            End If
        Next

        With dgvFINAGIL
            .BackColor = Color.GhostWhite
            .BackgroundColor = Color.Lavender
            .BorderStyle = BorderStyle.None
            .Font = New Font("Tahoma", 8.0!)
            .ForeColor = Color.MidnightBlue
        End With


        ' Informaci�n de los pagar�s firmados por el Productor

        dtPagares.Clear()

        For Each drPagare In dsAgil.Tables("Pagares").Rows
            drAux = dtPagares.NewRow()
            drAux("No.") = drPagare("Numero")
            If drPagare("FechaPagare") <> "" Then
                drAux("Fecha Pagar�") = Mid(drPagare("FechaPagare"), 7, 2) & "/" & Mid(drPagare("FechaPagare"), 5, 2) & "/" & Mid(drPagare("FechaPagare"), 1, 4)
            Else
                drAux("Fecha Pagar�") = ""
            End If
            drAux("Importe") = Format(drPagare("Importe"), "##,##0.00")
            drAux("Garantia") = Format(drPagare("Garantia"), "##,##0.00")
            dtPagares.Rows.Add(drAux)
            nSumaPagares = nSumaPagares + drPagare("Importe")
        Next

        If nSumaPagares > 0 Then
            lblSumaPagares.Text = "Suma de los pagar�s capturados $" & Format(nSumaPagares, "##,##0.00")
        Else
            lblSumaPagares.Text = ""
        End If

        dgvPagares.DataSource = dtPagares
        dgvPagares.Columns(0).Width = 25
        dgvPagares.Columns(1).Width = 120
        dgvPagares.Columns(2).Width = 100
        dgvPagares.Columns(3).Width = 100

        For i = 0 To dgvPagares.Columns.Count - 1
            dgvPagares.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            If i = 0 Or i = 1 Then
                dgvPagares.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el encabezado
                dgvPagares.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el contenido
            ElseIf i = 2 Or i = 3 Then
                dgvPagares.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el encabezado
                dgvPagares.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el contenido
            End If
        Next

        With dgvPagares
            .BackColor = Color.GhostWhite
            .BackgroundColor = Color.Lavender
            .BorderStyle = BorderStyle.None
            .Font = New Font("Tahoma", 8.0!)
            .ForeColor = Color.MidnightBlue
        End With

        ' Informaci�n de las ministraciones FIRA - FINAGIL

        dtFIRA.Clear()
        nRowsFIRA = dsAgil.Tables("FIRA").Rows.Count()

        If nRowsFIRA > 0 Then
            btnModificarFIRA.Visible = True
        End If

        For Each drMinistracion In dsAgil.Tables("FIRA").Rows
            drAux = dtFIRA.NewRow()
            drAux("No.") = drMinistracion("Ministracion")
            If drMinistracion("FechaProgramada") <> "" Then
                drAux("Fecha Programada") = Mid(drMinistracion("FechaProgramada"), 7, 2) & "/" & Mid(drMinistracion("FechaProgramada"), 5, 2) & "/" & Mid(drMinistracion("FechaProgramada"), 1, 4)
            Else
                drAux("Fecha Programada") = ""
            End If
            drAux("Importe") = Format(drMinistracion("Importe"), "##,##0.00")
            drAux("FEGA") = drMinistracion("Fega")
            drAux("Estado") = drMinistracion("Estado")
            dtFIRA.Rows.Add(drAux)
            nMinistradoFIRA = nMinistradoFIRA + drMinistracion("Importe")
        Next

        If nMinistradoFIRA > 0 Then
            lblMinistradoFIRA.Text = "Total Ministrado por FIRA a FINAGIL $" & Format(nMinistradoFIRA, "##,##0.00")
        Else
            lblMinistradoFIRA.Text = ""
        End If

        dgvFIRA.DataSource = dtFIRA
        dgvFIRA.Columns(0).Width = 25
        dgvFIRA.Columns(1).Width = 120
        dgvFIRA.Columns(2).Width = 100
        dgvFIRA.Columns(3).Width = 50
        dgvFIRA.Columns(4).Width = 80

        For i = 0 To dgvFIRA.Columns.Count - 1
            dgvFIRA.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            If i = 0 Or i = 1 Or i = 3 Then
                dgvFIRA.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el encabezado
                dgvFIRA.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el contenido
            ElseIf i = 2 Then
                dgvFIRA.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el encabezado
                dgvFIRA.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el contenido
            End If
        Next

        With dgvFIRA
            .BackColor = Color.GhostWhite
            .BackgroundColor = Color.Lavender
            .BorderStyle = BorderStyle.None
            .Font = New Font("Tahoma", 8.0!)
            .ForeColor = Color.MidnightBlue
        End With

        Me.CxP_CuentasBancariasProvTableAdapter.FillByCliente(CxpDS.CXP_CuentasBancariasProv, Trim(drAvio("Cliente")))
        If CxpDS.CXP_CuentasBancariasProv.Count <= 0 Then
            btnInsertarFINAGIL.Visible = False
            btnModificarFINAGIL.Visible = False
            Lbcuenta.Visible = True
            MessageBox.Show("Productor sin cuenta bancaria registrada o autorizada.", "Cuenta Bancaria CXP", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Lbcuenta.Visible = False
        End If

        cnAgil.Dispose()
        cm1.Dispose()
        cm2.Dispose()
        cm4.Dispose()

    End Sub

    Private Sub BtnInsertarFINAGIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertarFINAGIL.Click
        If cbDocumento.Items.Count <= 0 Then
            MessageBox.Show("No existen conceptos que puedas ministrar", "Error Ministraciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        panelFINAGIL.Visible = True
        btnInsertarFINAGIL.Enabled = False
        If btnModificarFINAGIL.Visible = True Then
            btnModificarFINAGIL.Enabled = False
        End If
        txtImporteFINAGIL.Text = ""
        cbDocumento.SelectedIndex = 0
        lInsertFINAGIL = True
    End Sub

    Private Sub BtnInsertarFIRA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertarFIRA.Click

        panelFIRA.Visible = True
        btnInsertarFIRA.Enabled = False
        If btnModificarFIRA.Visible = True Then
            btnModificarFIRA.Enabled = False
        End If
        txtImporteFIRA.Text = ""
        cbFEGA.SelectedIndex = 0
        cbEstado.SelectedIndex = 0
        lInsertFIRA = True
        lUpdateFIRA = False

    End Sub

    Private Sub BtnModificarFINAGIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarFINAGIL.Click
        If dgvFINAGIL.Item(5, dgvFINAGIL.CurrentRow.Index).Value = True Then
            MessageBox.Show("No se puede Eliminar una ministraci�n Procesada", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dgvFINAGIL.Item(1, dgvFINAGIL.CurrentRow.Index).Value = "SEGURO" And UsuarioGlobalDepto <> "SEGUROS" Then
            MessageBox.Show("No se puede Eliminar una ministraci�n de seguro", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("�Estas seguro de eliminar la minitracion " & dgvFINAGIL.Item(0, dgvFINAGIL.CurrentRow.Index).Value & "?", "Eliminar Ministraci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                TaMfinagil.DeleteMinistracion(cAnexo, cCiclo, dgvFINAGIL.Item(0, dgvFINAGIL.CurrentRow.Index).Value)
                TaMfinagil.Renumera(cAnexo, cCiclo, dgvFINAGIL.Item(0, dgvFINAGIL.CurrentRow.Index).Value)
                FrmAgricola_Load(Nothing, Nothing)
            End If
        End If

    End Sub

    Private Sub BtnModificarFIRA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarFIRA.Click

        panelFIRA.Visible = True
        btnInsertarFIRA.Enabled = False
        btnModificarFIRA.Enabled = False

        ' Tengo que leer la informaci�n del registro del Grid sobre el cual est� posicionado para mostrarla y poder corregirla

        nRegistroFIRA = dgvFIRA.Item(0, dgvFIRA.CurrentRow.Index).Value
        dtpFechaFIRA.Value = dgvFIRA.Item(1, dgvFIRA.CurrentRow.Index).Value
        txtImporteFIRA.Text = dgvFIRA.Item(2, dgvFIRA.CurrentRow.Index).Value
        cbFEGA.SelectedItem = dgvFIRA.Item(3, dgvFIRA.CurrentRow.Index).Value
        cbEstado.SelectedItem = RTrim(dgvFIRA.Item(4, dgvFIRA.CurrentRow.Index).Value)

        lInsertFIRA = False
        lUpdateFIRA = True

    End Sub

    Private Sub BtnGuardarFINAGIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarFINAGIL.Click

        ' Declaraci�n de variables de conexi�n ADO .NET
        If cbDocumento.SelectedItem = "" Then
            MsgBox("Concepto no valido", MsgBoxStyle.Critical, "Mensaje del Sistema")
            Exit Sub
        End If

        If taHojaCamb.TieneHojaCambPendiete(cAnexo) > 0 Then
            MessageBox.Show("el Contrato tiene Hoja de Cambios pendiente", "Hojas de Cambios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cm1 As New SqlCommand()
        Dim drTemporal As DataRow
        Dim strInsert As String
        Dim strUpdate As String
        Dim EfectivoPendiente As Integer = TaMfinagil.Efect_Pendiente(cAnexo, cCiclo)

        ' Declaraci�n de variables de datos

        Dim cFechaAlta As String = DTOC(Now())
        Dim nGarantiaLiq As Decimal = 0
        Dim nGarantiaFega As Decimal = 0
        If EfectivoPendiente > 0 And cTipar = "H" And cbDocumento.Text = "EFECTIVO" Then
            MsgBox("No puedes solcitar mas EFECTIVO, ya que existen misnitraciones en proceso de pago.", MsgBoxStyle.Critical, "Mensaje del Sistema")
        ElseIf nMinistradoFINAGIL + CDec(txtImporteFINAGIL.Text) > CDec(txtLineaAutorizada.Text) + MARGEN_LINEA_AV_IMP + (CDec(txtLineaAutorizada.Text) * MARGEN_LINEA_AV_PORC) Then
            MsgBox("Con esta Ministraci�n Exceder�a su L�nea de Cr�dito (" & (nMinistradoFINAGIL + CDec(txtImporteFINAGIL.Text)) - (CDec(txtLineaAutorizada.Text) + MARGEN_LINEA_AV_IMP + (CDec(txtLineaAutorizada.Text) * MARGEN_LINEA_AV_PORC)) & ")", MsgBoxStyle.Critical, "Mensaje del Sistema")
        ElseIf cFechaTerminacion = "19000101" Then
            MsgBox("Falta fecha de Terminacion de contrato", MsgBoxStyle.Critical, "Mensaje del Sistema")
        Else

            ' Falta validar que se haya capturado informaci�n
            nGarantiaLiq = Round(CDbl(txtImporteFINAGIL.Text) * CDec(TaMfinagil.SacaPorcGarLiq(cAnexo, cCiclo)), 2)
            nGarantiaFega = CalculaFEGA(CDbl(txtImporteFINAGIL.Text), FegaFlat, cFechaTerminacion, AplicaFega, nPorcFega, cCliente, Sucursal, "AV")

            If lInsertFINAGIL = True Then

                nRowsFINAGIL = nRowsFINAGIL + 1

                strInsert = "INSERT INTO mFINAGIL (Anexo, Ciclo, Ministracion, Importe, Garantia, Documento, FechaAlta, SaldoMinistracion, SaldoGarantia, UltimoPago, usuario, Fega,procesado, MesaControlAut,CuentaDestino)"
                strInsert = strInsert & " VALUES ('"
                strInsert = strInsert & cAnexo & "', '"
                strInsert = strInsert & cCiclo & "', '"
                strInsert = strInsert & nRowsFINAGIL & "', "
                strInsert = strInsert & txtImporteFINAGIL.Text & ", "
                strInsert = strInsert & nGarantiaLiq & ", '"
                strInsert = strInsert & cbDocumento.SelectedItem & "', '"
                strInsert = strInsert & cFechaAlta & "', "
                strInsert = strInsert & txtImporteFINAGIL.Text & ", "
                strInsert = strInsert & nGarantiaLiq & ", '','" & UsuarioGlobal.Trim & "', " & nGarantiaFega & ",0,0,'" & CxP_CuentasBancariasProvBindingSource.Current("Clabe") & "')"
                Try
                    cm1 = New SqlCommand(strInsert, cnAgil)
                    cnAgil.Open()
                    cm1.ExecuteNonQuery()
                    cnAgil.Close()
                Catch eException As Exception
                    MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
                End Try

                Me.Sp_AVI_MinistracionesTableAdapter.Fill(AviosDSX.sp_AVI_Ministraciones, cAnexo, cCiclo)
                Me.SpAVIMinistracionesBindingSource.MoveLast()

                nMinistradoFINAGIL = Me.Sp_AVI_MinistracionesTableAdapter.TotalMinistrado(cAnexo, cCiclo)
                lblMinistradoFINAGIL.Text = "Total Ministrado por FINAGIL al Productor $" & Format(nMinistradoFINAGIL, "##,##0.00")
            End If

            cm1.Dispose()
            panelFINAGIL.Visible = False
            btnInsertarFINAGIL.Enabled = True
            If btnModificarFINAGIL.Visible = False Then
                btnModificarFINAGIL.Visible = True
            End If
            If btnModificarFINAGIL.Visible = True Then
                btnModificarFINAGIL.Enabled = True
            End If

            dgvFINAGIL.Refresh()

        End If

    End Sub

    Private Sub BtnGuardarFIRA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarFIRA.Click

        Dim cm1 As New SqlCommand()
        Dim drTemporal As DataRow
        Dim strInsert As String
        Dim strUpdate As String

        ' Falta validar que se haya capturado informaci�n

        ' Lo primero que tengo que revisar es si se trata de una inserci�n o una actualizaci�n

        If lInsertFIRA = True Then

            nRowsFIRA = nRowsFIRA + 1

            strInsert = "INSERT INTO mFIRA (Anexo, Ciclo, Ministracion, FechaProgramada, Importe, Fega, Estado)"
            strInsert = strInsert & " VALUES ('"
            strInsert = strInsert & cAnexo & "', '"
            strInsert = strInsert & cCiclo & "', '"
            strInsert = strInsert & nRowsFIRA & "', '"
            strInsert = strInsert & DTOC(dtpFechaFIRA.Value) & "', '"
            strInsert = strInsert & txtImporteFIRA.Text & "', '"
            strInsert = strInsert & cbFEGA.SelectedItem & "', '"
            strInsert = strInsert & cbEstado.SelectedItem
            strInsert = strInsert & "')"
            Try
                cm1 = New SqlCommand(strInsert, cnAgil)
                cnAgil.Open()
                cm1.ExecuteNonQuery()
                cnAgil.Close()
            Catch eException As Exception
                MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
            End Try

            drTemporal = dtFIRA.NewRow()
            drTemporal("No.") = nRowsFIRA
            drTemporal("Fecha Programada") = Mid(DTOC(dtpFechaFIRA.Value), 7, 2) & "/" & Mid(DTOC(dtpFechaFIRA.Value), 5, 2) & "/" & Mid(DTOC(dtpFechaFIRA.Value), 1, 4)
            drTemporal("Importe") = Format(CDbl(txtImporteFIRA.Text), "##,##0.00")
            drTemporal("FEGA") = cbFEGA.SelectedItem
            drTemporal("Estado") = cbEstado.SelectedItem
            dtFIRA.Rows.Add(drTemporal)

            nMinistradoFIRA = nMinistradoFIRA + CDbl(txtImporteFIRA.Text)
            lblMinistradoFIRA.Text = "Total Ministrado por FIRA a FINAGIL $" & Format(nMinistradoFIRA, "##,##0.00")

        ElseIf lUpdateFIRA = True Then

            strUpdate = "UPDATE mFIRA SET FechaProgramada = '" & DTOC(dtpFechaFIRA.Value) & "', "
            strUpdate = strUpdate & "Importe = " & CDbl(txtImporteFIRA.Text) & ", "
            strUpdate = strUpdate & "Fega = '" & cbFEGA.SelectedItem & "', "
            strUpdate = strUpdate & "Estado = '" & cbEstado.SelectedItem & "' "
            strUpdate = strUpdate & "WHERE Anexo = '" & cAnexo & "' "
            strUpdate = strUpdate & "AND Ciclo = '" & cCiclo & "' "
            strUpdate = strUpdate & "AND Ministracion = " & nRegistroFIRA
            Try
                cm1 = New SqlCommand(strUpdate, cnAgil)
                cnAgil.Open()
                cm1.ExecuteNonQuery()
                cnAgil.Close()
            Catch eException As Exception
                MsgBox(eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
            End Try

            myKeySearch(0) = nRegistroFIRA
            drTemporal = dtFIRA.Rows.Find(myKeySearch)
            nImporteAnterior = drTemporal("Importe")
            drTemporal("Fecha Programada") = Mid(DTOC(dtpFechaFIRA.Value), 7, 2) & "/" & Mid(DTOC(dtpFechaFIRA.Value), 5, 2) & "/" & Mid(DTOC(dtpFechaFIRA.Value), 1, 4)
            drTemporal("Importe") = Format(CDbl(txtImporteFIRA.Text), "##,##0.00")
            drTemporal("FEGA") = cbFEGA.SelectedItem
            drTemporal("Estado") = cbEstado.SelectedItem

            nMinistradoFIRA = nMinistradoFIRA - nImporteAnterior + CDbl(txtImporteFIRA.Text)
            lblMinistradoFIRA.Text = "Total Ministrado por FIRA a FINAGIL $" & Format(nMinistradoFIRA, "##,##0.00")

        End If

        cm1.Dispose()

        panelFIRA.Visible = False
        btnInsertarFIRA.Enabled = True
        If btnModificarFIRA.Visible = False Then
            btnModificarFIRA.Visible = True
        End If
        If btnModificarFIRA.Visible = True Then
            btnModificarFIRA.Enabled = True
        End If

        dgvFIRA.Refresh()

    End Sub

    Private Sub BtnCancelarFINAGIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarFINAGIL.Click
        panelFINAGIL.Visible = False
        btnInsertarFINAGIL.Enabled = True
        If btnModificarFINAGIL.Visible = True Then
            btnModificarFINAGIL.Enabled = True
        End If
    End Sub

    Private Sub BtnCancelarFIRA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarFIRA.Click
        panelFIRA.Visible = False
        btnInsertarFIRA.Enabled = True
        If btnModificarFIRA.Visible = True Then
            btnModificarFIRA.Enabled = True
        End If
    End Sub

    Private Sub cbDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDocumento.SelectedIndexChanged
        If cbDocumento.Text = "EFECTIVO" Then
            CmbCuenta.Enabled = True
        Else
            CmbCuenta.Enabled = False
        End If
    End Sub

    Private Sub dgvFINAGIL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFINAGIL.CellContentClick
        If e.ColumnIndex = 6 Then
            If dgvFINAGIL.CurrentCell.Value.ToString.Length > 0 Then 'or check NULL
                Dim Arch As String = My.Settings.RutaTMP & "CXP\ComPago\" & SpAVIMinistracionesBindingSource.Current("uuidPago") & ".pdf"
                Try
                    Process.Start(Arch)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error Referencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub



End Class