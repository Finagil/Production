Public Class FrmTasasAvio
    Private Sub FrmTasasAvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CultivosTableAdapter.FillByALL(Me.GeneralDS.Cultivos)
        Me.CiclosTableAdapter.FillVigentes(Me.AviosDSX.Ciclos)
        Me.ContClie1TableAdapter.Fill(Me.ProductionDataSet.ContClie1)
        Me.AVI_Tasa_ClienteTableAdapter.FillByALL(Me.AviosDSX.AVI_Tasa_Cliente, Me.CiclosBindingSource.Current("Ciclo"), Me.CultivosBindingSource.Current("idCultivo"))
    End Sub

    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltro.TextChanged
        If Txtfiltro.Text.Length > 0 Then
            ContClie1BindingSource.Filter = "descr like '%" & Txtfiltro.Text & "%'"
        Else
            ContClie1BindingSource.Filter = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNothing(Me.ContClie1BindingSource.Current) Then
            If Me.AVI_Tasa_ClienteTableAdapter.EstaElCliente(Me.ContClie1BindingSource.Current("Descr"), Me.CiclosBindingSource.Current("Ciclo"), Me.CultivosBindingSource.Current("idCultivo")) > 0 Then
                MessageBox.Show("El Cliente ya está en la lista", "Tasas Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Me.AVI_Tasa_ClienteTableAdapter.Inserta(Trim(Me.ContClie1BindingSource.Current("Descr")), Me.CiclosBindingSource.Current("Ciclo"), Texttasa.Text, Me.CultivosBindingSource.Current("idCultivo"))
                Me.AVI_Tasa_ClienteTableAdapter.FillByALL(Me.AviosDSX.AVI_Tasa_Cliente, Me.CiclosBindingSource.Current("Ciclo"), Me.CultivosBindingSource.Current("idCultivo"))
                MessageBox.Show("El Cliente fue agregado.", "Tasas Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not IsNothing(Me.AVITasaClienteBindingSource.Current) Then
            If MessageBox.Show("Desea eliminar a " & Me.AVITasaClienteBindingSource.Current("NombreCliente"), "Tasa Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.AVI_Tasa_ClienteTableAdapter.DeleteCliente(Me.AVITasaClienteBindingSource.Current("NombreCliente"), Me.CiclosBindingSource.Current("Ciclo"), Me.CultivosBindingSource.Current("idCultivo"))
                Me.AVI_Tasa_ClienteTableAdapter.FillByALL(Me.AviosDSX.AVI_Tasa_Cliente, Me.CiclosBindingSource.Current("Ciclo"), Me.CultivosBindingSource.Current("idCultivo"))
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.AVITasaClienteBindingSource.EndEdit()
        Me.AviosDSX.AVI_Tasa_Cliente.GetChanges()
        Me.AVI_Tasa_ClienteTableAdapter.Update(Me.AviosDSX.AVI_Tasa_Cliente)
        MessageBox.Show("Datos Guardados.", "Tasas Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CiclosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CiclosBindingSource.CurrentChanged
        If IsNothing(Me.CultivosBindingSource.Current) Then Exit Sub
        Me.AVI_Tasa_ClienteTableAdapter.FillByALL(Me.AviosDSX.AVI_Tasa_Cliente, Me.CiclosBindingSource.Current("Ciclo"), Me.CultivosBindingSource.Current("idCultivo"))
    End Sub

    Private Sub Texttasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Texttasa.KeyPress
        NumerosyDecimal(Texttasa, e)
    End Sub

    Private Sub CultivosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CultivosBindingSource.CurrentChanged
        If IsNothing(Me.CiclosBindingSource.Current) Then Exit Sub
        Me.AVI_Tasa_ClienteTableAdapter.FillByALL(Me.AviosDSX.AVI_Tasa_Cliente, Me.CiclosBindingSource.Current("Ciclo"), Me.CultivosBindingSource.Current("idCultivo"))
    End Sub


End Class