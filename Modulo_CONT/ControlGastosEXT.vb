Public Class ControlGastosEXT
    Public Saldo As Decimal
    Dim Opcion As String
    Public Sub CargaXCliente(ByVal Cliente As String)
        Dim ta As New GastosDSTableAdapters.CONT_GastosExtrasTableAdapter
        Dim importe As Decimal = ta.TotalCliente(Cliente)
        TxtImporte.Text = importe.ToString("n2")
        Saldo = importe
        ta.Dispose()
        If importe > 0 Then
            TxtImporte.BackColor = Color.Red
        Else
            TxtImporte.BackColor = SystemColors.Control
        End If
        Opcion = Cliente
    End Sub

    Public Sub CargaXAnexo(ByVal Anexo As String)
        Dim ta As New GastosDSTableAdapters.CONT_GastosExtrasTableAdapter
        Dim importe As Decimal = ta.TotalAnexo(Anexo)
        Saldo = importe
        TxtImporte.Text = importe.ToString("n2")
        ta.Dispose()
        If importe > 0 Then
            TxtImporte.BackColor = Color.Red
        Else
            TxtImporte.BackColor = SystemColors.Control
        End If
        Opcion = Anexo
    End Sub

    Private Sub TxtImporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtImporte.Click
        If Val(TxtImporte.Text) > 0 Then
            Dim f As New FrmGastosDetalle
            f.Opcion = Opcion
            f.TxtImporte.Text = TxtImporte.Text
            If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            End If
        End If
    End Sub

    Public Function SacaCliente(ByVal Anexo As String)
        Dim Cliente As String
        Dim ta As New GastosDSTableAdapters.CONT_GastosExtrasTableAdapter
        Cliente = ta.SacaCliente(Anexo)
        ta.Dispose()
        Return Cliente
    End Function

End Class
