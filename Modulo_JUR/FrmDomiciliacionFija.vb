Public Class FrmDomiciliacionFija
    Dim r As JuridicoDS.JUR_DomiciliacionFijaRow
    Private Sub FrmDomiciliacionFija_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter.FillByDomiciliados(Me.JuridicoDS.Clientes)
        Me.Vw_DomiciliacionFijaTableAdapter.Fill(Me.JuridicoDS.Vw_DomiciliacionFija)
    End Sub

    Private Sub TextImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextImporte.KeyPress
        NumerosyDecimal(TextImporte, e)
    End Sub

    Private Sub TextImporte2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextImporte2.KeyPress
        NumerosyDecimal(TextImporte2, e)
    End Sub

    Private Sub ClientesBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ClientesBindingSource.CurrentChanged
        If Not IsNothing(ClientesBindingSource.Current) Then
            Me.AnexosDomiTableAdapter.Fill(Me.JuridicoDS.AnexosDomi, ClientesBindingSource.Current("Cliente"))
        End If
    End Sub

    Private Sub VwDomiciliacionFijaBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles VwDomiciliacionFijaBindingSource.CurrentChanged
        If Not IsNothing(VwDomiciliacionFijaBindingSource.Current) Then
            Dim Anexo As String = Mid(VwDomiciliacionFijaBindingSource.Current("Anexocon"), 1, 5) & Mid(VwDomiciliacionFijaBindingSource.Current("Anexocon"), 7, 4)
            Me.JUR_DomiciliacionFijaTableAdapter.Fill(Me.JuridicoDS.JUR_DomiciliacionFija, Anexo)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNothing(AnexosDomiBindingSource.Current) Then
            MessageBox.Show("No exite anexo para agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Val(TextImporte.Text) > 50000 Then
            MessageBox.Show("el importe no puede ser mayor a 50 mil pesos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Try
            r = Me.JuridicoDS.JUR_DomiciliacionFija.NewJUR_DomiciliacionFijaRow
            r.id_DomiciliacionFija = -1
            r.usuario = UsuarioGlobal
            r.FechaAlta = Date.Now
            r.Anexo = ComboAnex.SelectedValue
            r.Activo = True
            r.Importe = TextImporte.Text
            Me.JuridicoDS.JUR_DomiciliacionFija.AddJUR_DomiciliacionFijaRow(r)
            Guardar()
            TextImporte.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.JURDomiciliacionFijaBindingSource.Current("usuario") = UsuarioGlobal
            Me.JURDomiciliacionFijaBindingSource.EndEdit()
            Guardar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Guardar()
        Me.JuridicoDS.JUR_DomiciliacionFija.GetChanges()
        Me.JUR_DomiciliacionFijaTableAdapter.Update(Me.JuridicoDS.JUR_DomiciliacionFija)
        FrmDomiciliacionFija_Load(Nothing, Nothing)
    End Sub


End Class