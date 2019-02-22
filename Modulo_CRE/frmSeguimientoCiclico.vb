Public Class frmSeguimientoCiclico
    Public Id_ORG As Decimal
    Private Sub frmSeguimientoCiclico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboPeriodicidad.SelectedIndex = 0
        Me.CRED_SeguimientoTableAdapter.FillByID(Me.CreditoDS.CRED_Seguimiento, Id_ORG)
        DtpVenc.Value = TaQUERY.FechaTerminacion(Me.CreditoDS.CRED_Seguimiento.Rows(0).Item("Anexo"))
        DtpVenc.Value = DtpVenc.Value.AddYears(1)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Me.CreditoDS.CRED_SeguimientoCiclico.Rows.Count <= 0 Then
            MessageBox.Show("No hay Fechas Programadas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("¿Esta seguro de Crear los nuevos seguimientos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim X As Integer
            Me.CreditoDS.CRED_Seguimiento.GetChanges()
            Me.CRED_SeguimientoTableAdapter.Update(Me.CreditoDS.CRED_Seguimiento)
            For Each R As CreditoDS.CRED_SeguimientoCiclicoRow In CreditoDS.CRED_SeguimientoCiclico
                R.id_Seguimiento = Me.CreditoDS.CRED_Seguimiento.Rows(X + 1).Item("id_Seguimiento")

                X += 1
            Next
            Me.CreditoDS.CRED_SeguimientoCiclico.GetChanges()
            Me.CRED_SeguimientoCiclicoTableAdapter.Update(Me.CreditoDS.CRED_SeguimientoCiclico)
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub BtnTry_Click(sender As Object, e As EventArgs) Handles BtnTry.Click
        Dim rNew As CreditoDS.CRED_SeguimientoRow
        Dim rOrg As CreditoDS.CRED_SeguimientoRow
        Me.CRED_SeguimientoTableAdapter.FillByID(Me.CreditoDS.CRED_Seguimiento, Id_ORG)
        rOrg = Me.CreditoDS.CRED_Seguimiento.Rows(0)
        CreditoDS.CRED_SeguimientoCiclico.Clear()
        Dim F As Date = DTPcompromiso.Value
        Dim r As CreditoDS.CRED_SeguimientoCiclicoRow
        Dim Meses As Integer
        Select Case ComboPeriodicidad.Text.ToUpper
            Case "MENSUAL"
                Meses = 1
            Case "BIMESTRAL"
                Meses = (2)
            Case "TRIMESTRAL"
                Meses = (3)
            Case "SEMESTRAL"
                Meses = (6)
            Case "ANUAL"
                Meses = (12)
        End Select
        F = F.AddMonths(Meses)
        Dim X As Integer = 1
        While F <= DtpVenc.Value
            r = CreditoDS.CRED_SeguimientoCiclico.NewCRED_SeguimientoCiclicoRow
            r.id_SeguimientoORG = Id_ORG
            r.id_Seguimiento = X
            r.TipoCiclo = ComboPeriodicidad.Text
            r.Fecha = F
            CreditoDS.CRED_SeguimientoCiclico.AddCRED_SeguimientoCiclicoRow(r)
            ' nueva Fila de Seguimiento
            rNew = Me.CreditoDS.CRED_Seguimiento.NewCRED_SeguimientoRow()
            rNew.ItemArray = Me.CreditoDS.CRED_Seguimiento.Rows(0).ItemArray
            rNew.Fecha_Compromiso = F
            rNew.id_Seguimiento = -X
            Me.CreditoDS.CRED_Seguimiento.AddCRED_SeguimientoRow(rNew)
            F = F.AddMonths(Meses)
            X += 1
        End While

    End Sub
End Class