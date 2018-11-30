Option Explicit On

Imports System.Data.SqlClient

Public Class frmPideContrato

    Public Sub New(ByVal cMenu As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtMenu.Text = cMenu

    End Sub

    Private Sub frmPideContrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case txtMenu.Text
            Case "mnuDatosCon"
                Me.Text = "Selección de Contrato para Consulta de Datos"
            Case "mnuAdelanto"
                Me.Text = "Selección de Contrato para Adelanto a Capital"
            Case "mnuCalcfini"
                Me.Text = "Selección de Contrato para Cálculo de Finiquito"
            Case "mnuFiniquito"
                Me.Text = "Selección de Contrato para Finiquito"
            Case "mnuRegenera"
                Me.Text = "Selección de Contrato para regenerar su Tabla"
            Case "mnuCartaRat"
                Me.Text = "Selección de Contrato para Carta de Ratificación"
            Case "mnuCapitalizacion"
                Me.Text = "Selección de Contrato para Capitalización"
            Case "mnuImprCert"
                Me.Text = "Selección de Contrato para Estado de Cuenta Certificado"
            Case "mnuMinistracionesPorContrato"
                Me.Text = "Selección de Contrato de Avío para Ministraciones"
            Case "mnuModCtoAvioPorContrato"
                Me.Text = "Selección de Contrato de Avío para Modificación"
            Case "mnuPagaresPorContrato"
                Me.Text = "Selección de Contrato de Avío para captura de Pagarés"
            Case "mnuCapturaPMIPorContrato"
                Me.Text = "Selección de Contrato de Avío para captura de Predios y Garantías"
            Case "mnuImpCtoAvioPorContrato"
                Me.Text = "Selección de Contrato de Avío para impresión"
        End Select

        mtxtContrato.Mask = "A0000/0000"

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim ta As New ProductionDataSetTableAdapters.AnexosTableAdapter 'SACA TIPAR
        Dim TipoCredito As String = ""
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daAvios As New SqlDataAdapter(cm1)

        Dim dsAgil As New DataSet()
        Dim drAnexo As DataRow

        ' Declaración de variables de datos

        Dim cAnexo As String

        If mtxtContrato.MaskFull = True Then

            cAnexo = Mid(mtxtContrato.Text, 1, 5) + Mid(mtxtContrato.Text, 7, 4)
            TipoCredito = ta.SacaTipar(cAnexo)
            SacaAlerta("", cAnexo)
            Select Case txtMenu.Text
                Case "mnuDatosCon"
                    If TipoCredito = "B" Then ' FULL SERVICE
                        Dim newfrmDatosCon As New frmDatosconFull(mtxtContrato.Text)
                        newfrmDatosCon.Show()
                    Else
                        Dim newfrmDatosCon As New frmDatoscon(mtxtContrato.Text)
                        newfrmDatosCon.Show()
                    End If
                Case "mnuAdelanto"
                    If TipoCredito = "B" Then ' FULL SERVICE
                        MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Select
                    End If
                    With cm1
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT Anexo, tipar FROM Anexos WHERE Anexo = '" & cAnexo & "'"
                        .Connection = cnAgil
                        .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                        .Parameters(0).Value = cAnexo
                    End With

                    ' Llenar el DataSet lo cual abre y cierra la conexión

                    daAvios.Fill(dsAgil, "Anexos")

                    If dsAgil.Tables("Anexos").Rows.Count = 0 Then

                        lblMensaje.Text = "¡Contrato inexistente!"
                        lblMensaje.Visible = True

                    Else
                        If dsAgil.Tables("Anexos").Rows(0).Item("Tipar") = "PP" Then
                            lblMensaje.Text = "¡No se puede hacer adelantos para Arrendamineto Puro!"
                            lblMensaje.Visible = True
                        Else
                            lblMensaje.Visible = False
                            Dim newfrmAdelanto As New frmAdelanto(mtxtContrato.Text)
                            newfrmAdelanto.Show()
                        End If
                    End If



                Case "mnuCalcfini"
                    If TipoCredito = "B" Then ' FULL SERVICE
                        MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Select
                    End If
                    If TipoCredito = "P" Then
                        Dim newfrmCalcfini1 As New frmCalcfiniAP(mtxtContrato.Text)
                        newfrmCalcfini1.Show()
                    Else
                        Dim newfrmCalcfini2 As New frmCalcfini(mtxtContrato.Text)
                        newfrmCalcfini2.Show()
                    End If

                Case "mnuFiniquito"
                    If TipoCredito = "B" Then ' FULL SERVICE
                        MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Select
                    End If
                    If TipoCredito = "P" Then
                        Dim newfrmFiniquito1 As New frmFiniquitoAP(mtxtContrato.Text)
                        newfrmFiniquito1.Show()
                    Else
                        Dim newfrmFiniquito2 As New frmFiniquito(mtxtContrato.Text)
                        newfrmFiniquito2.Show()
                    End If

                Case "mnuCartaRat"
                    If TipoCredito = "B" Then ' FULL SERVICE
                        MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Select
                    End If
                    Dim newfrmCartaRat As New frmCartaRat(mtxtContrato.Text)
                    newfrmCartaRat.Show()
                Case "mnuCargaGPS"
                    If TipoCredito = "B" Then ' FULL SERVICE
                        MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Select
                    End If
                    Dim newfrmCapitalizacion As New frmCargaGPS(mtxtContrato.Text)
                    newfrmCapitalizacion.Show()
                Case "mnuImprCert"
                    If TipoCredito = "B" Then ' FULL SERVICE
                        MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Select
                    End If
                    Dim newfrmImprCert As New frmImprCert(mtxtContrato.Text)
                    newfrmImprCert.Show()
                Case "mnuMinistracionesPorContrato"
                    If TipoCredito = "B" Then ' FULL SERVICE
                        MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Select
                    End If
                    ' El siguiente Command verifica que exista el Crédito de Avío

                    With cm1
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT Anexo FROM Avios WHERE Anexo = '" & cAnexo & "'"
                        .Connection = cnAgil
                        .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                        .Parameters(0).Value = cAnexo
                    End With

                    ' Llenar el DataSet lo cual abre y cierra la conexión

                    daAvios.Fill(dsAgil, "Avios")

                    If dsAgil.Tables("Avios").Rows.Count = 0 Then

                        lblMensaje.Text = "¡Contrato inexistente o no es de Avío!"

                    Else

                        Dim newfrmAgricola As New frmAgricola(mtxtContrato.Text)
                        newfrmAgricola.Show()

                    End If

                Case "mnuModCtoAvioPorContrato"
                    If TipoCredito = "B" Then ' FULL SERVICE
                        MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Select
                    End If
                    ' El siguiente Command verifica que exista el Crédito de Avío

                    With cm1
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT Anexo FROM Avios WHERE Anexo = '" & cAnexo & "'"
                        .Connection = cnAgil
                        .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                        .Parameters(0).Value = cAnexo
                    End With

                    ' Llenar el DataSet lo cual abre y cierra la conexión

                    daAvios.Fill(dsAgil, "Avios")

                    If dsAgil.Tables("Avios").Rows.Count = 0 Then

                        lblMensaje.Text = "¡Contrato inexistente o no es de Avío!"
                        lblMensaje.Visible = True

                    Else

                        lblMensaje.Visible = False
                        Dim newfrmModCtoAvio As New frmModCtoAvio(mtxtContrato.Text)
                        newfrmModCtoAvio.Show()

                    End If

                Case "mnuPagaresPorContrato"
                    If TipoCredito = "B" Then ' FULL SERVICE
                        MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Select
                    End If
                    ' El siguiente Command verifica que exista el Crédito de Avío

                    With cm1
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT Anexo FROM Avios WHERE Anexo = '" & cAnexo & "'"
                        .Connection = cnAgil
                        .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                        .Parameters(0).Value = cAnexo
                    End With

                    ' Llenar el DataSet lo cual abre y cierra la conexión

                    daAvios.Fill(dsAgil, "Avios")

                    If dsAgil.Tables("Avios").Rows.Count = 0 Then

                        lblMensaje.Text = "¡Contrato inexistente o no es de Avío!"
                        lblMensaje.Visible = True

                    Else

                        lblMensaje.Visible = False
                        Dim newfrmPagares As New frmPagares(mtxtContrato.Text)
                        newfrmPagares.Show()

                    End If

                Case "mnuCapturaPMIPorContrato"
                    If TipoCredito = "B" Then ' FULL SERVICE
                        MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Select
                    End If
                    ' El siguiente Command verifica que exista el Crédito de Avío

                    With cm1
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT Anexo FROM Avios WHERE Anexo = '" & cAnexo & "'"
                        .Connection = cnAgil
                        .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                        .Parameters(0).Value = cAnexo
                    End With

                    ' Llenar el DataSet lo cual abre y cierra la conexión

                    daAvios.Fill(dsAgil, "Avios")

                    If dsAgil.Tables("Avios").Rows.Count = 0 Then

                        lblMensaje.Text = "¡Contrato inexistente o no es de Avío!"
                        lblMensaje.Visible = True

                    Else

                        lblMensaje.Visible = False
                        Dim newfrmCapturaPMI As New frmCapturaPMI(mtxtContrato.Text)
                        newfrmCapturaPMI.Show()

                    End If

                Case "mnuImpCtoAvioPorContrato"
                    If TipoCredito = "B" Then ' FULL SERVICE
                        MessageBox.Show("Esta operación no se puede para Full Service", "Operación Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Select
                    End If
                    ' El siguiente Command verifica que exista el Crédito de Avío

                    With cm1
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT Anexo FROM Avios WHERE Anexo = '" & cAnexo & "'"
                        .Connection = cnAgil
                        .Parameters.Add("@Anexo", SqlDbType.NVarChar)
                        .Parameters(0).Value = cAnexo
                    End With

                    ' Llenar el DataSet lo cual abre y cierra la conexión

                    daAvios.Fill(dsAgil, "Avios")

                    If dsAgil.Tables("Avios").Rows.Count = 0 Then

                        lblMensaje.Text = "¡Contrato inexistente o no es de Avío!"
                        lblMensaje.Visible = True

                    Else

                        lblMensaje.Visible = False
                        Dim newfrmImpCtoAvio As New frmImpCtoAvio(mtxtContrato.Text)
                        newfrmImpCtoAvio.Show()

                    End If

            End Select

        End If

        cnAgil.Dispose()
        cm1.Dispose()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class