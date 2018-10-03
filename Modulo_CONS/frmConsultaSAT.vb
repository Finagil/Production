Public Class frmConsultaSAT

    Public Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        txtxNoExiste69.Visible = False
        txtxNoExiste69B.Visible = False
        txtNombre.Text = CRED_Lista_Art69TableAdapter.Obt_Nombre_ScalarQuery(txtRFC.Text.Trim)
        txtRFCN.Text = CRED_Lista_Art69TableAdapter.Obt_RFC_ScalarQuery(txtRFC.Text.Trim)
        txtTipoPersona.Text = CRED_Lista_Art69TableAdapter.Obt_TP_ScalarQuery(txtRFC.Text.Trim)

        If txtNombre.Text = "" Then
            txtNombre.Text = CRED_Lista_Art69BTableAdapter.Obt_Nombre_ScalarQuery(txtRFC.Text.Trim)
            txtRFCN.Text = txtRFC.Text
            If txtRFCN.Text.Length = 12 Then
                txtTipoPersona.Text = "M"
            Else
                txtTipoPersona.Text = "F"
            End If
        End If

        Try
            Me.CRED_Lista_Art69TableAdapter.Art69_FillBy(Me.CreditoDS.CRED_Lista_Art69, txtRFC.Text)
            Me.CRED_Lista_Art69BTableAdapter.Art69B_FillBy(Me.CreditoDS.CRED_Lista_Art69B, txtRFC.Text)

            If DataGridView1.Rows.Count = 0 Then
                txtxNoExiste69.Text = "No existe en la lista"
                txtxNoExiste69.Visible = True
            ElseIf DataGridView2.Rows.Count = 0 Then
                txtxNoExiste69B.Text = "No existe en la lista"
                txtxNoExiste69B.Visible = True
            End If

            If DataGridView1.Rows.Count = 0 And DataGridView2.Rows.Count = 0 Then
                Dim nombreCont As String = InputBox("El contribuyente no existe en la lista, ingresa el nombre para poder generar el reporte", "Validación SAT")
                txtNombre.Text = nombreCont.ToUpper
                txtRFCN.Text = txtRFC.Text
                txtxNoExiste69B.Visible = False
                txtxNoExiste69.Visible = False
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click

        Dim taArt69F As New CreditoDSTableAdapters.CRED_ListaFechaArf69TableAdapter
        Dim val1 As String = ""
        Dim valB As String = ""
        Dim val2 As String = ""
        Dim val2_pago As String = ""

        For Each row As DataGridViewRow In DataGridView1.Rows
            Select Case row.Cells(0).Value
                Case "FIRMES"
                    val1 = "1. DE CONTRIBUYENTE QUE TIENE CRÉDITOS FISCALES FIRMES"
                Case "EXIGIBLES"
                    val1 = "2. CRÉDITOS EXIGIBLES, NO PAGADOS O GARANTIZADOS"
                Case "CANCELADOS"
                    val1 = "3. CRÉDITOS CANCELADOS"
                Case "CONDONADOS"
                    val1 = "4. CRÉDITOS CONDONADOS"
                Case "SENTENCIA"
                    val1 = "5. DE CONTRIBUYENTE QUE TIENE SENTENCIA CONDENATORIA EJECUTORIA POR LA COMISIÓN DE UN DELITO FISCAL"
                Case "NO LOCALIZADO"
                    val1 = "NO LOCALIZADO"
            End Select
            valB += val1 + vbNewLine
        Next

        For Each row As DataGridViewRow In DataGridView2.Rows
            val2 += row.Cells(0).Value + vbNewLine
        Next

        If val2.Trim = "Desvirtuado" Or val2 = "" Then
            val2_pago = "PAGO PROCEDENTE A PROVEEDOR"
        Else
            val2_pago = "NO PROCEDE EL PAGO A PROVEEDOR, SOLICITAR ACLARACION"
        End If

        Dim rpt As New rptConsultaSAT

        rpt.SetParameterValue("var_nombre", txtNombre.Text)
        rpt.SetParameterValue("var_rfc", txtRFC.Text)
        rpt.SetParameterValue("var_tipo_contribuyente", txtTipoPersona.Text.ToString.Replace("F", "Física").Replace("M", "Moral"))
        rpt.SetParameterValue("var_1", valB)
        rpt.SetParameterValue("var_2", val2)
        rpt.SetParameterValue("var_pago", val2_pago)
        rpt.SetParameterValue("fecha_consulta_SAT", taArt69F.Obt_fecha_ScalarQuery)

        frmRptConsultaSAT.CrystalReportViewer1.ReportSource = rpt
        frmRptConsultaSAT.Show()
    End Sub

    Private Sub frmConsultaSAT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class