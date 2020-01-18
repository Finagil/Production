Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports Microsoft.VisualBasic
Imports System.Security
Imports System.Security.Principal.WindowsIdentity


Public Class frmPideProductor
    Dim myIdentity As Principal.WindowsIdentity
    Dim cUsuario As String
    Dim cCliente As String = ""

    Public Sub New(ByVal cMenu As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtMenu.Text = cMenu

    End Sub

    ' Declaración de variables de alcance privado

    Dim cProductor As String = ""
    Dim lFirstTime As Boolean = True
    Dim cnAgil As New SqlConnection(strConn)
    Dim cm1 As New SqlCommand()
    Dim daClientes As New SqlDataAdapter(cm1)
    Dim dsAgil As New DataSet()

    Private Sub frmPideProductor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Declaración de variables de conexión ADO .NET

        

        myIdentity = GetCurrent()
        cUsuario = myIdentity.Name
        Label1.Text = cUsuario & " " & UsuarioGlobal



        Select Case txtMenu.Text
            Case "mnuECPP"
                Me.Text = "Selección de Cliente de Avío para Estado de Cuenta"
            Case "mnuPorProductor"
                Me.Text = "Selección de Cliente de Avío para Captura de Ministraciones"
            Case "mnuModCtoAvioPorProductor"
                Me.Text = "Selección de Cliente de Avío para modificación"
            Case "mnuPagaresPorProductor"
                Me.Text = "Selección de Cliente de Avío para captura de Pagarés"
            Case "mnuCapturaPMIPorProductor"
                Me.Text = "Selección de Cliente de Avío para captura de Predios y Garantías"
            Case "mnuImpCtoAvioPorProductor"
                Me.Text = "Selección de Cliente de Avío para impresión de Contrato"
            Case "mnuCAvio"
                Me.Text = "Selección de Cliente de Avío para Captura de Valores"
        End Select

        ' Este Stored Procedure trae los clientes que pertenezcan a la Sucursal de NAVOJOA, MEXICALI e IRAPUATO

        With cm1
            .CommandType = CommandType.StoredProcedure
            If UsuarioGlobal.ToUpper = "MCHAVEZ" Then
                .CommandText = "ContClieMEXICALI"
                .CommandTimeout = 60
            Else
                .CommandText = "ContClie2"

            End If
            .Connection = cnAgil

        End With

        cbProductores.MaxDropDownItems = 25

        Try

            ' Llenar el DataSet

            daClientes.Fill(dsAgil, "Clientes")

            ' Ligar la tabla Clientes del dataset dsAgil al ComboBox

            cbProductores.DataSource = dsAgil
            cbProductores.DisplayMember = "Clientes.Descr"
            cbProductores.ValueMember = "Clientes.Cliente"
            lFirstTime = False

        Catch eException As Exception

            MsgBox(eException.Source & " " & eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

        

    End Sub

    Private Sub cbProductores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProductores.SelectedIndexChanged

        ' Declaración de variables de conexíón ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daContratos As New SqlDataAdapter(cm1)

        Dim dsAgil As New DataSet()
        Dim drContrato As DataRow

        ' Declaración de variables de datos

        Dim cAnexo As String = ""
        Dim cCiclo As String = ""
        Dim cDescCiclo As String = ""
        Dim cNombre As String = ""

        If Not cbProductores.SelectedValue Is Nothing And lFirstTime = False Then

            cProductor = cbProductores.SelectedValue.ToString()
            SacaAlerta(cProductor, "")
            ' El siguiente Command trae los contratos del Productor seleccionado

            With cm1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_PideProductorAnexosAV"
                .Parameters.Add("@Cliente", SqlDbType.NVarChar)
                .Parameters(0).Value = cProductor
                .Connection = cnAgil
            End With

            ' Llenar el DataSet lo cual abre y cierra la conexión

            daContratos.Fill(dsAgil, "Contratos")

            ' Ya que se escogió un productor del listado, se llama a la forma frmAgricola mandándole
            ' como parámetro el número del productor seleccionado el cual coincide con el del contrato

            lblContratos.Visible = True
            lbContratos.Visible = True
            lbContratos.Items.Clear()

            For Each drContrato In dsAgil.Tables("Contratos").Rows
                cAnexo = Mid(drContrato("Anexo"), 1, 5) & "/" & Mid(drContrato("Anexo"), 6, 4)
                cCiclo = drContrato("Ciclo")
                cDescCiclo = RTrim(drContrato("CicloPagare"))
                lbContratos.Items.Add(cAnexo & " " & cDescCiclo)
            Next

        End If
        ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++
        Dim TaOnbase As New GeneralDSTableAdapters.OnBaseTableAdapter
        If TaOnbase.ScalarCuantosAreaAnexo("Credito", CadOnbase(cProductor)) > 0 Then
            BtnOnbaseCRE.Enabled = True
        Else
            BtnOnbaseCRE.Enabled = False
        End If
        ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++

    End Sub

    Private Sub lbContratos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbContratos.SelectedIndexChanged
        Dim ta As New ProductionDataSetTableAdapters.AviosBloqueadosTableAdapter
        Dim t As New ProductionDataSet.AviosBloqueadosDataTable
        Dim cAnexo As String = Mid(lbContratos.SelectedItem, 1, 5) & Mid(lbContratos.SelectedItem, 7, 4)
        Dim cCiclo As String = Mid(lbContratos.SelectedItem, 18, 2)
        ta.Fill(t, cAnexo, cCiclo)
        If t.Rows.Count > 0 Then
            If LCase(UsuarioGlobal) <> "jjavier" And
            LCase(UsuarioGlobal) <> "mleal" And
            LCase(UsuarioGlobal) <> "lmercado" And
            LCase(UsuarioGlobal) <> "vcruz" Then
                MessageBox.Show("CUENTA BLOQUEDA, FAVOR DE COMUNICARSE AL ÁREA JURÍDICA", "CUENTA BLOQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                MessageBox.Show("CUENTA BLOQUEDA", "CUENTA BLOQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        Select Case txtMenu.Text
            Case "mnuECPP"
                Dim newfrmEdoCtaAvio As New frmEdoCtaAvio(Mid(lbContratos.SelectedItem, 1, 58))     ' Corregido
                newfrmEdoCtaAvio.Show()
            Case "mnuPorProductor"
                Dim newfrmAgricola As New frmAgricola(Mid(lbContratos.SelectedItem, 1, 58))         ' Corregido
                newfrmAgricola.Show()
            Case "mnuModCtoAvioPorProductor"
                Dim newfrmModCtoAvio As New frmModCtoAvio(Mid(lbContratos.SelectedItem, 1, 58))     ' Corregido
                ''If LCase(UsuarioGlobal) = "cjuarez" Or LCase(UsuarioGlobal) = "vely" #ECT20141022 ya no se ocupa, se agredo idgarantia
                ''    newfrmModCtoAvio.Refaccionarios = True
                ''End If
                newfrmModCtoAvio.Show()
            Case "mnuPagaresPorProductor"
                Dim newfrmPagares As New frmPagares(Mid(lbContratos.SelectedItem, 1, 58))           ' Corregido
                newfrmPagares.Show()
            Case "mnuCapturaPMIPorProductor"
                Dim newfrmCapturaPMI As New frmCapturaPMI(Mid(lbContratos.SelectedItem, 1, 58))     ' Corregido
                newfrmCapturaPMI.Show()
            Case "mnuImpCtoAvioPorProductor"
                Dim newfrmImpCtoAvio As New frmImpCtoAvio(Mid(lbContratos.SelectedItem, 1, 58))     ' Corregido
                newfrmImpCtoAvio.Show()
            Case "mnuCAvio"
                Dim newfrmCaptValoAVIO As New frmCaptValoAVIO(Mid(lbContratos.SelectedItem, 1, 58))
                newfrmCaptValoAVIO.Show()
        End Select

    End Sub

    Private Sub BtnOnbaseCRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOnbaseCRE.Click
        Dim f As New FrmDocOnbase
        f.Area = "Credito"
        f.AnexoOcliente = cProductor
        f.Titulo = Me.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        f.Dispose()
    End Sub

    Private Sub Txtanexo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtanexo.TextChanged
        If lFirstTime = False Then
            Dim cAnexo As String
            If Txtanexo.Text.Trim.Length <= 6 Then
                cAnexo = Mid(Txtanexo.Text.Trim, 1, Txtanexo.Text.Trim.Length - 1)
            Else
                cAnexo = Mid(Txtanexo.Text.Trim, 1, 5) & Mid(Txtanexo.Text.Trim, 7, Txtanexo.Text.Trim.Length)
            End If

            cm1.CommandType = CommandType.StoredProcedure
            cm1.Parameters.Clear()

            If cAnexo.Trim.Length > 1 Then
                cm1.CommandText = "ContClie3"
                cm1.Parameters.Add("@Anexo", SqlDbType.NVarChar)
                cm1.Parameters(0).Value = cAnexo.Trim & "%"
            Else
                cm1.CommandText = "ContClie2"
            End If
            cm1.Connection = cnAgil
            dsAgil.Clear()
            daClientes = New SqlDataAdapter(cm1)
            daClientes.Fill(dsAgil, "Clientes")

            cbProductores.DataSource = dsAgil
            'cbProductores.DisplayMember = "Clientes.Descr"
            'cbProductores.ValueMember = "Clientes.Cliente"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New FrmAtachments
        f.Cliente = cCliente
        f.Carpeta = "Crédito"
        If TaQUERY.SacaPermisoModulo("CREDITO_DOC", UsuarioGlobal) > 0 Then
            f.Consulta = False
        Else
            f.Consulta = True
        End If
        f.Nombre = cbProductores.Text
        If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        End If
    End Sub
End Class