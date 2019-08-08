Option Explicit On

Imports System.Data.SqlClient

Public Class frmPideAnexo

    Inherits System.Windows.Forms.Form
    Dim ClienteAux As String = ""

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal cMenu As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtMenu.Text = cMenu

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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lblAnexos As System.Windows.Forms.Label
    Friend WithEvents lblClientes As System.Windows.Forms.Label
    Friend WithEvents BtnOnbaseCRE As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtMenu As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.lblAnexos = New System.Windows.Forms.Label()
        Me.txtMenu = New System.Windows.Forms.TextBox()
        Me.BtnOnbaseCRE = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(16, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(424, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "ComboBox1"
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(446, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(181, 472)
        Me.ListBox1.TabIndex = 4
        Me.ListBox1.Visible = False
        '
        'lblClientes
        '
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(16, 16)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(432, 16)
        Me.lblClientes.TabIndex = 1
        Me.lblClientes.Text = "Selecciona un Cliente de la siguiente Lista"
        '
        'lblAnexos
        '
        Me.lblAnexos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnexos.Location = New System.Drawing.Point(465, 16)
        Me.lblAnexos.Name = "lblAnexos"
        Me.lblAnexos.Size = New System.Drawing.Size(149, 16)
        Me.lblAnexos.TabIndex = 3
        Me.lblAnexos.Text = "Contratos de este cliente"
        Me.lblAnexos.Visible = False
        '
        'txtMenu
        '
        Me.txtMenu.Location = New System.Drawing.Point(16, 112)
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.ReadOnly = True
        Me.txtMenu.Size = New System.Drawing.Size(40, 20)
        Me.txtMenu.TabIndex = 5
        Me.txtMenu.Visible = False
        '
        'BtnOnbaseCRE
        '
        Me.BtnOnbaseCRE.Enabled = False
        Me.BtnOnbaseCRE.Location = New System.Drawing.Point(16, 67)
        Me.BtnOnbaseCRE.Name = "BtnOnbaseCRE"
        Me.BtnOnbaseCRE.Size = New System.Drawing.Size(104, 24)
        Me.BtnOnbaseCRE.TabIndex = 136
        Me.BtnOnbaseCRE.Text = "OnBase Crédito"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 137
        Me.Button1.Text = "Doctos. Crédito"
        '
        'frmPideAnexo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(633, 526)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnOnbaseCRE)
        Me.Controls.Add(Me.txtMenu)
        Me.Controls.Add(Me.lblAnexos)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmPideAnexo"
        Me.Text = "Selección de Cliente y Contrato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmPideAnexo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daClientes As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet()

        Select Case txtMenu.Text
            Case "mnuDatosCon"
                Me.Text = "Selección de Cliente y Contrato para Consulta de Datos del Contrato"
            Case "mnuActiAnex"
                Me.Text = "Selección de Cliente y Contrato para Activación de Anexos"
            Case "mnuCaptFact"
                Me.Text = "Selección de Cliente y Contrato para Captura de Facturas Originales"
            Case "mnuPrendaria"
                Me.Text = "Selección de Cliente y Contrato para Captura de Garantía Prendaria"
            Case "mnuDesactiv"
                Me.Text = "Selección de Cliente y Contrato para Desactivación de Anexos"
            Case "mnuSegumanu"
                Me.Text = "Selección de Cliente y Contrato para Captura de Seguros Financiados"
            Case "mnuCalcfini"
                Me.Text = "Selección de Cliente y Contrato para Cálculo de Finiquito"
            Case "mnuAdelanto"
                Me.Text = "Selección de Cliente y Contrato para Adelanto a Capital"
            Case "mnuFiniquito"
                Me.Text = "Selección de Cliente y Contrato para Finiquito"
            Case "mnuImprActi"
                Me.Text = "Selección de Cliente y Contrato para Imprimir la Factura de Activo Fijo"
            Case "mnuCTradicional"
                Me.Text = "Selección de Cliente y Contrato para Captura de Valores"
            Case "mnuCaptSegu"
                Me.Text = "Selección de Cliente y Contrato para Captura de Seguros"
            Case "mnuCartaRat"
                Me.Text = "Selección de Cliente y Contrato para Carta de Ratificación"
            Case "mnuImprCert"
                Me.Text = "Selección de Cliente y Contrato para Estado de Cuenta Certificado"
            Case "mnuReestructuras"
                Me.Text = "Selección de Cliente y Contrato para Reestructurar"
            Case "mnuCheckList"
                Me.Text = "Selección de Cliente y Contrato para Captura ó Modificación de Documentos"
            Case "mnuConsultaCL"
                Me.Text = "Selección de Cliente y Contrato para Consulta de Documentos"
            Case "mnuAltacta"
                Me.Text = "Selección de Cliente y Contrato para Alta de Cuentas para Domiciliación"
            Case "mnuSiniestros"
                Me.Text = "Selección de Cliente y Contrato para Alta Siniestros y Devoluciones"
            Case "FrmAlertasAnexo"
                Me.Text = "Notificaciones por Anexo por Letra (Alertas)"
        End Select

        ' Este Stored Procedure trae TODOS los clientes que tengan generado por lo menos 1 contrato, sin
        ' importar si se trata de contratos activos, cancelados, terminados, en suspenso, o dados de baja
        Select Case txtMenu.Text
            Case "mnuCartaRat"
                With cm1
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "PideAnex11"
                    .Connection = cnAgil
                End With
            Case Else
                With cm1
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "PideAnex1"
                    .Connection = cnAgil
                End With
        End Select


        ComboBox1.MaxDropDownItems = 35

        Try

            ' Llenar el DataSet a través del DataAdapter lo cual abre y cierra la conexión

            daClientes.Fill(dsAgil, "Clientes")

            ' Ligar la tabla Clientes del dataset dsAgil al ComboBox
            Select Case txtMenu.Text
                Case "mnuCartaRat"
                    ComboBox1.DataSource = dsAgil
                    ComboBox1.DisplayMember = "Clientes.Descr"
                    ComboBox1.ValueMember = "Clientes.Cliente"

                Case Else
                    ComboBox1.DataSource = dsAgil
                    ComboBox1.DisplayMember = "Clientes.Descr"
                    ComboBox1.ValueMember = "Clientes.Cliente"
            End Select


        Catch eException As Exception

            MsgBox(eException.Source & " " & eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")

        End Try

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        ' Declaración de variables de conexíón ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daAnexos As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet()

        ' Declaración de variables de datos

        Dim cAnexo As String
        Dim cCliente As String
        Dim cFlcan As String
        Dim cStatus As String
        Dim cNombre As String

        ' Crear 2 DataRow (El primero mantiene 1 solo anexo y el segundo n anexos)

        Dim drAnexo As DataRow
        Dim drAnexos As DataRowCollection
        If Not ComboBox1.SelectedValue Is Nothing Then

            cCliente = ComboBox1.SelectedValue.ToString()
            SacaAlerta(cCliente, "")
            ' Este Stored Procedure trae los contratos del cliente seleccionado en el ComboBox, por lo que es 
            ' óptimo que traer TODOS los contratos y a TODOS los clientes como lo había pensado originalmente

            Select Case txtMenu.Text
                Case "mnuCartaRat"
                    With cm1
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "PideAnex22"
                        .Connection = cnAgil
                        .Parameters.Add("@Cliente", SqlDbType.NVarChar)
                        .Parameters(0).Value = cCliente
                    End With
                Case Else
                    With cm1
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "PideAnex2"
                        .Connection = cnAgil
                        .Parameters.Add("@Cliente", SqlDbType.NVarChar)
                        .Parameters(0).Value = cCliente
                    End With
            End Select



            ' Buscar a dicho cliente en el DataSet y retornar sus datos en el DataRow

            daAnexos.Fill(dsAgil, "Anexos")
            drAnexos = dsAgil.Tables("Anexos").Rows

            lblAnexos.Visible = True
            ListBox1.Visible = True
            ListBox1.Items.Clear()

            For Each drAnexo In drAnexos
                cAnexo = Mid(drAnexo("Anexo"), 1, 5) & "/" & Mid(drAnexo("Anexo"), 6, 4)
                cFlcan = drAnexo("Flcan")
                cStatus = "**ERROR**"
                Select Case cFlcan
                    Case "S"
                        cStatus = "SUSPENSO "
                    Case "A"
                        cStatus = "ACTIVO   "
                    Case "T"
                        cStatus = "TERMINADO"
                    Case "C"
                        cStatus = "CANCELADO"
                    Case "B"
                        cStatus = "BAJA     "
                    Case "W"
                        cStatus = "TERMINADO C/SALDO"
                End Select
                Select Case txtMenu.Text
                    Case "mnuCartaRat"
                        ListBox1.Items.Add(cAnexo & " " & cStatus & " " & drAnexo("Titulo") & " " & drAnexo("Pag"))
                    Case Else
                        ListBox1.Items.Add(cAnexo & " " & cStatus)
                End Select


            Next

        End If

        ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++
        Dim TaOnbase As New GeneralDSTableAdapters.OnBaseTableAdapter
        ClienteAux = cCliente
        cNombre = ComboBox1.Text.Trim
        If TaOnbase.ScalarCuantos("Credito%", "% " & ClienteAux & " %") > 0 Then
            BtnOnbaseCRE.Enabled = True
        Else
            BtnOnbaseCRE.Enabled = False
        End If
        ' esto es para conuslta Onbase+++++++++++++++++++++++++++++++

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim cAnexo As String = Mid(ListBox1.SelectedItem, 1, 5) & Mid(ListBox1.SelectedItem, 7, 4)

        Dim ta As New ProductionDataSetTableAdapters.AnexosTableAdapter 'SACA TIPAR
        Dim TipoCredito As String = ta.SacaTipar(cAnexo)
        Dim EstatusCredito As String = TaQUERY.SacaFlcan(cAnexo, "")

        Select Case txtMenu.Text
            Case "mnuDatosCon"
                If TipoCredito = "B" Then ' FULL SERVICE
                    Dim newfrmDatosCon As New frmDatosconFull(Mid(ListBox1.SelectedItem, 1, 10))
                    newfrmDatosCon.Show()
                Else
                    Dim newfrmDatosCon As New frmDatoscon(Mid(ListBox1.SelectedItem, 1, 10))
                    newfrmDatosCon.Show()
                End If
            Case "mnuActiAnex"
                Select Case TipoCredito
                    Case "B"
                        Dim newfrmActiAnex As New frmActiAnexFull(Mid(ListBox1.SelectedItem, 1, 10), ComboBox1.Text)
                        newfrmActiAnex.Show()
                    Case "F"
                        Dim newfrmActiAnex As New frmActiAnexAF(Mid(ListBox1.SelectedItem, 1, 10))
                        newfrmActiAnex.Show()
                    Case "S"
                        Dim newfrmActiAnex As New frmActiAnexCS(Mid(ListBox1.SelectedItem, 1, 10))
                        newfrmActiAnex.Show()
                    Case "L"
                        Dim newfrmActiAnex As New frmActiAnexCL(Mid(ListBox1.SelectedItem, 1, 10))
                        newfrmActiAnex.Show()
                    Case "R"
                        Dim newfrmActiAnex As New frmActiAnexCR(Mid(ListBox1.SelectedItem, 1, 10))
                        newfrmActiAnex.Show()
                    Case Else
                        Dim newfrmActiAnex As New frmActiAnexAP(Mid(ListBox1.SelectedItem, 1, 10))
                        newfrmActiAnex.Show()
                End Select


            Case "mnuCaptFact"
                If TipoCredito = "B" Then ' FULL SERVICE
                    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                Dim f As New FrmCapFacturas()
                f.cAnexo = Mid(ListBox1.SelectedItem, 1, 5) & Mid(ListBox1.SelectedItem, 7, 4)
                f.Show()
            Case "mnuPrendaria"
                If TipoCredito = "B" Then ' FULL SERVICE
                    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                Dim newfrmPrendaria As New frmPrendaria(Mid(ListBox1.SelectedItem, 1, 10))
                newfrmPrendaria.Show()
            Case "mnuDesactiv"
                If TipoCredito = "B" And TaQUERY.SacaPermisoModulo("DESACTIVAR_FULLSERVICE", UsuarioGlobal) <= 0 Then ' FULL SERVICE
                    MessageBox.Show("No tiene permisos para Desactivar Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                Dim newfrmDesactiv As New frmDesactiv(Mid(ListBox1.SelectedItem, 1, 10))
                newfrmDesactiv.Show()
            Case "mnuSegumanu"
                If TipoCredito = "B" Then ' FULL SERVICE
                    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                If TipoCredito = "L" Then ' Liquidez
                    MessageBox.Show("Esta operación no se puede para Credito de Liquidez", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                Dim newfrmSegumanu As New frmSegumanu(Mid(ListBox1.SelectedItem, 1, 10))
                newfrmSegumanu.Show()
            Case "mnuCalcfini"
                If TipoCredito = "B" Then ' FULL SERVICE
                    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                If TipoCredito = "P" Then
                    Dim newfrmCalcfini1 As New frmCalcfiniAP(Mid(ListBox1.SelectedItem, 1, 10))
                    newfrmCalcfini1.Show()
                Else
                    Dim newfrmCalcfini2 As New frmCalcfini(Mid(ListBox1.SelectedItem, 1, 10))
                    newfrmCalcfini2.Show()
                End If

            Case "mnuAdelanto"
                If TipoCredito = "B" Then ' FULL SERVICE
                    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                If TipoCredito = "PP" Then
                    MessageBox.Show("¡No se puede hacer adelantos para Arrendamineto Puro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim newfrmAdelanto As New frmAdelanto(Mid(ListBox1.SelectedItem, 1, 10))
                    newfrmAdelanto.Show()
                End If
            Case "mnuFiniquito"
                If TipoCredito = "B" Then ' FULL SERVICE
                    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                If TipoCredito = "P" Then
                    Dim newfrmFiniquito1 As New frmFiniquitoAP(Mid(ListBox1.SelectedItem, 1, 10))
                    newfrmFiniquito1.Show()
                Else
                    Dim newfrmFiniquito2 As New frmFiniquito(Mid(ListBox1.SelectedItem, 1, 10))
                    newfrmFiniquito2.Show()
                End If
            Case "mnuImprActi"
                If TipoCredito = "B" Then ' FULL SERVICE
                    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                Dim newfrmImprActi As New frmImpracti(Mid(ListBox1.SelectedItem, 1, 10))
                newfrmImprActi.Show()
            Case "mnuCTradicional"
                Dim newfrmCaptValo As New frmCaptValo(Mid(ListBox1.SelectedItem, 1, 10))
                newfrmCaptValo.Show()
            Case "mnuCaptSegu"
                If TipoCredito = "B" Then ' FULL SERVICE
                    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                Dim newfrmCaptSegu As New frmCaptsegu(Mid(ListBox1.SelectedItem, 1, 10))
                newfrmCaptSegu.Show()
            Case "mnuCartaRat"
                'If TipoCredito = "B" Then ' FULL SERVICE
                'MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Exit Select
                'End If
                Dim newfrmCartaRat As New frmCartaRat(Mid(ListBox1.SelectedItem, 1, 10))
                newfrmCartaRat.Show()
            Case "mnuImprCert"
                If TipoCredito = "B" Then ' FULL SERVICE
                    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                Dim newfrmImprCert As New frmImprCert(Mid(ListBox1.SelectedItem, 1, 10))
                newfrmImprCert.Show()
            Case "mnuReestructuras"
                If TipoCredito = "B" Then ' FULL SERVICE
                    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                Dim newfrmReestructuras As New frmReestructuras(Mid(ListBox1.SelectedItem, 1, 10))
                newfrmReestructuras.Show()
            Case "mnuCheckList"
                If TipoCredito = "B" Then ' FULL SERVICE
                    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                Dim newfrmCheckList As New frmCheckList(Mid(ListBox1.SelectedItem, 1, 10))
                newfrmCheckList.Show()
            Case "mnuConsultaCL"
                If TipoCredito = "B" Then ' FULL SERVICE
                    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                Dim newfrmConsultaCL As New frmConsultaCheckList(Mid(ListBox1.SelectedItem, 1, 10))
                newfrmConsultaCL.Show()
            Case "mnuAltacta"
                If TipoCredito = "B" Then ' FULL SERVICE
                    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                Dim newfrmAltaCuentaDom As New frmAltaCuentaDom(Mid(ListBox1.SelectedItem, 1, 10))
                newfrmAltaCuentaDom.Show()
            Case "mnuSiniestros"
                'If TipoCredito = "B" Then ' FULL SERVICE
                '    MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Exit Select
                'End If
                Dim FrmSiniestros As New FrmSiniestrosBienes()
                FrmSiniestros.Anexo = Mid(ListBox1.SelectedItem, 1, 5) & Mid(ListBox1.SelectedItem, 7, 4)
                FrmSiniestros.Show()
            Case "FrmAlertasAnexo"
                If EstatusCredito <> "A" Then
                    MessageBox.Show("El contrato de estar ACTIVO", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If
                Dim Frm As New FrmAlertasAnexo
                Frm.Text += " " & ComboBox1.Text.Trim & "-" & Mid(ListBox1.SelectedItem, 1, 10)
                Frm.cAnexo = Mid(ListBox1.SelectedItem, 1, 5) & Mid(ListBox1.SelectedItem, 7, 4)
                Frm.Show()
        End Select
    End Sub

    Private Sub BtnOnbaseCRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOnbaseCRE.Click
        Dim f As New FrmDocOnbase
        f.Cadena1 = "Credito%"
        f.Cadena2 = "% " & ComboBox1.SelectedValue.Trim & " %"
        f.Titulo = Me.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        f.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New FrmAtachments
        f.Cliente = ClienteAux
        f.Carpeta = "Crédito"
        If TaQUERY.SacaPermisoModulo("CREDITO_DOC", UsuarioGlobal) > 0 Then
            f.Consulta = False
        Else
            f.Consulta = True
        End If
        f.Nombre = ComboBox1.SelectedText
        If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        End If
    End Sub
End Class
