Public Class FrmCambioTasa
    Public NvoEstatus As String
    Public NvoReestructura As String
    Public Anexo As String
    Public Ciclo As String
    Public CambTasa As String
    Public Tipar As String
    Public TasaIVACliente As Decimal
    Private Sub FrmCambioTasa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NvoEstatus = "VENCIDA" Then
            Label3.ForeColor = Color.Red
            Label3.Font = New Font(Label3.Font, FontStyle.Bold)
        End If
        TxtStatus.Text = NvoEstatus
        If TxtTipoTasa.Text.ToUpper = "FIJA" Then
            TxtDifNew.ReadOnly = True
            TxtDifNew.Text = "0.0"
        Else
            TxtTasaNew.ReadOnly = True
            TxtTasaNew.Text = "0.0"
        End If
    End Sub

    Private Sub BtnCambiar_Click(sender As Object, e As EventArgs) Handles BtnCambiar.Click

        If Not IsNumeric(TxtTasa.Text) Then
            MessageBox.Show("Tasa Invalida", "Error de Dato", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CambTasa = "+" Then
            If TxtTipoTasa.Text.ToUpper = "FIJA" Then
                If CDec(TxtTasaNew.Text) <= Val(TxtTasa.Text) Then
                    MessageBox.Show("La tasa nueva no es mayor a la actual", "Error de Dato", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                If CDec(TxtDifNew.Text) <= Val(TxtDif.Text) Then
                    MessageBox.Show("El diferencial nuevo no es mayor al actual", "Error de Dato", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        ElseIf CambTasa = "-" Then
            If TxtTipoTasa.Text.ToUpper = "FIJA" Then
                If CDec(TxtTasaNew.Text) >= Val(TxtTasa.Text) Then
                    MessageBox.Show("La tasa nueva no es menor a la actual", "Error de Dato", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                If CDec(TxtDifNew.Text) >= Val(TxtDif.Text) Then
                    MessageBox.Show("El diferencial nuevo no es menor al actual", "Error de Dato", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        Else
            MessageBox.Show("Error en parametros del sistema", "Error de Dato", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' proceso de cambio de tasa
        Dim ta As New ReestructDSTableAdapters.CambiosAnexosTableAdapter
        If ta.HayCambioTasa(Anexo, Ciclo) > 0 Then
            MessageBox.Show("Este Anexo ya tiene cambio de tasa", "Error de Dato", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ta.Insert(Anexo, Ciclo, FECHA_APLICACION, TxtTasa.Text, TxtDif.Text, FECHA_APLICACION, UsuarioGlobal, TxtTasaNew.Text, TxtDifNew.Text)

        If Ciclo.Trim.Length > 0 Then ' CAMBIA LA TASA
            ta.CambiaTasaAV(TxtDifNew.Text, TxtTasaNew.Text, NvoReestructura, NvoEstatus, Anexo, Ciclo)
        Else
            DesBloqueaContrato(Anexo)
            ta.CambiaTasaTRA(TxtDifNew.Text, TxtTasaNew.Text, NvoReestructura, NvoEstatus, Anexo)
            BloqueaContrato(Anexo)
            HistoriaEdoCtaV(Anexo) ' respalda EDOCTAV
            CambiaInteresTabla()
        End If
        If NvoEstatus = "VENCIDA" Then
            ta.VencidaXReestructura(Anexo, Ciclo, FECHA_APLICACION)
        End If
        MessageBox.Show("Datos actualizados", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Sub CambiaInteresTabla()
        Dim taV As New ReestructDSTableAdapters.EdoctavSinFactTableAdapter
        Dim taS As New ReestructDSTableAdapters.EdoctasSinFactTableAdapter
        Dim taO As New ReestructDSTableAdapters.EdoctaoSinFactTableAdapter
        Dim tV As New ReestructDS.EdoctavSinFactDataTable
        Dim tS As New ReestructDS.EdoctasSinFactDataTable
        Dim ttO As New ReestructDS.EdoctaoSinFactDataTable
        Dim Tasa As Decimal = TxtTasaNew.Text
        Dim Difer As Decimal = TxtDifNew.Text
        Dim Fecha As Date = FECHA_APLICACION
        Dim FechaVEN As Date = FECHA_APLICACION
        Dim cont As Integer = 0
        Dim Dias As Integer = 0
        taV.Fill(tV, Anexo)
        ' TABLA DEL PRINCIPAL
        For Each r As ReestructDS.EdoctavSinFactRow In tV.Rows
            FechaVEN = CTOD(r.Feven)
            If cont = 0 Then
                cont = TaQUERY.DiasEntreVecimientos(Anexo)
                If cont < 28 Then
                    Fecha = FechaVEN.AddDays(cont * -1)
                ElseIf cont >= 28 And cont <= 32 Then
                    Fecha = FechaVEN.AddMonths(-1)
                Else
                    Fecha = FechaVEN.AddDays(cont * -1)
                End If
            End If
            Dias = DateDiff(DateInterval.Day, Fecha, FechaVEN)
            r.Inter = Math.Round(r.Saldo * ((Tasa + Difer) / 100 / 360) * Dias, 2)
            If r.Iva > 0 Then
                r.Iva = Math.Round(r.Inter * (TasaIVACliente / 100), 2)
            End If
            Fecha = FechaVEN
        Next
        tV.GetChanges()
        taV.Update(tV)
        ' TABLA DEL SEGURO
        For Each r As ReestructDS.EdoctasSinFactRow In tS.Rows
            FechaVEN = CTOD(r.Feven)
            If cont = 0 Then
                cont = TaQUERY.DiasEntreVecimientos(Anexo)
                If cont < 28 Then
                    Fecha = FechaVEN.AddDays(cont * -1)
                ElseIf cont >= 28 And cont <= 32 Then
                    Fecha = FechaVEN.AddMonths(-1)
                Else
                    Fecha = FechaVEN.AddDays(cont * -1)
                End If
            End If
            Dias = DateDiff(DateInterval.Day, Fecha, FechaVEN)
            r.Inter = Math.Round(r.Saldo * ((Tasa + Difer) / 100 / 360) * Dias, 2)
            If r.Iva > 0 Then
                r.Iva = Math.Round(r.Inter * (TasaIVACliente / 100), 2)
            End If
            Fecha = FechaVEN
        Next
        tS.GetChanges()
        taS.Update(tS)
        ' TABLA DE OTROS ADEUDOS
        For Each r As ReestructDS.EdoctaoSinFactRow In ttO.Rows
            FechaVEN = CTOD(r.Feven)
            If cont = 0 Then
                cont = TaQUERY.DiasEntreVecimientos(Anexo)
                If cont < 28 Then
                    Fecha = FechaVEN.AddDays(cont * -1)
                ElseIf cont >= 28 And cont <= 32 Then
                    Fecha = FechaVEN.AddMonths(-1)
                Else
                    Fecha = FechaVEN.AddDays(cont * -1)
                End If
            End If
            Dias = DateDiff(DateInterval.Day, Fecha, FechaVEN)
            r.Inter = Math.Round(r.Saldo * ((Tasa + Difer) / 100 / 360) * Dias, 2)
            If r.Iva > 0 Then
                r.Iva = Math.Round(r.Inter * (TasaIVACliente / 100), 2)
            End If
            Fecha = FechaVEN
        Next
        ttO.GetChanges()
        taO.Update(ttO)
    End Sub

    Private Sub TxtTasaNew_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTasaNew.KeyPress, TxtDifNew.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

End Class