Public Class FrmCRED_FechasFactoraje
    Public Id_linea As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CREDFactorajeFechasBindingSource.EndEdit()
        Me.CreditoDS.CRED_FactorajeFechas.GetChanges()
        Me.CRED_FactorajeFechasTableAdapter.Update(Me.CreditoDS)
    End Sub

    Private Sub FrmCRED_FechasFactoraje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CRED_FactorajeFechasTableAdapter.Fill(Me.CreditoDS.CRED_FactorajeFechas, Id_linea)
        If Me.CreditoDS.CRED_FactorajeFechas.Rows.Count <= 0 Then
            Dim r As CreditoDS.CRED_FactorajeFechasRow
            r = Me.CreditoDS.CRED_FactorajeFechas.NewCRED_FactorajeFechasRow
            r.id_lineaCredito = Id_linea
            r.FechaInicio = Date.Now.Date
            r.FechaFin = Date.Now.AddYears(1).Date
            Me.CreditoDS.CRED_FactorajeFechas.AddCRED_FactorajeFechasRow(r)
        End If
    End Sub
End Class