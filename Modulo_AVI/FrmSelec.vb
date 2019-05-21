Public Class FrmSelec
    Public Origen As String
    Public Destino As String

    Private Sub FrmCicloSelec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UCase(Origen) = "PAGOAVIO" Then
            CmbMovimiento.Items.Add("Pago de Avio")
            CmbMovimiento.Items.Add("Nota de crédito Avio")
        ElseIf UCase(Origen) = "CICLOS" Then
            Dim TA As New AviosDSXTableAdapters.CiclosTableAdapter
            Dim T As New AviosDSX.CiclosDataTable
            CmbMovimiento.DataSource = T
            CmbMovimiento.DisplayMember = "DescCiclo"
            CmbMovimiento.ValueMember = "Ciclo"
            lblNumc.Text = "Ciclos"
            TA.FillByALL(T)
        End If
        CmbMovimiento.SelectedIndex = 0
    End Sub

    Private Sub BttSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttSave.Click
        If UCase(Origen) = "PAGOAVIO" Then
            Destino = UCase(CmbMovimiento.Text)
        ElseIf UCase(Origen) = "CICLOS" Then
            Destino = CmbMovimiento.SelectedValue & "," & CmbMovimiento.Text
        End If
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BttCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class