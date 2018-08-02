Imports System.Text.RegularExpressions
Public Class FrmDatosVehiculo
    Public Contrato As String
    Public Nombre As String
    Public Bloqueado As Boolean = False

    Dim ta As New PromocionDSTableAdapters.VehiculosTableAdapter

    Private Sub FrmDatosVehiculo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PromocionDS1.Niveles' Puede moverla o quitarla según sea necesario.
        Me.NivelesTableAdapter.Fill(Me.PromocionDS1.Niveles)
        ta.Fill(PromocionDS1.Vehiculos, Contrato)
        If PromocionDS1.Vehiculos.Rows.Count <= 0 Then
            ta.InsertVehiculo(Contrato)
            ta.Fill(PromocionDS1.Vehiculos, Contrato)
        End If
        Label1.Text = "Anexo: " & Mid(Contrato, 1, 5) & "/" & Mid(Contrato, 6, 4)
        Label2.Text = "Nombre: " & Nombre
        If Bloqueado = True Then
            BttSafe.Enabled = Not Bloqueado
            Dim objControl As Control
            For Each objControl In Me.Controls
                If TypeOf (objControl) Is TextBox Or TypeOf (objControl) Is MaskedTextBox Or TypeOf (objControl) Is ComboBox Then
                    objControl.Enabled = Not Bloqueado
                End If
            Next
        End If
    End Sub

    Private Sub BttSafe_Click(sender As Object, e As EventArgs) Handles BttSafe.Click

        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is TextBox Then
                If ctl.Text = "" And ctl.Name <> "TxtDatosadd" Then
                    MessageBox.Show("error de datos.", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ctl.Focus()
                    Exit Sub
                Else
                    ctl.Text = ctl.Text.ToUpper()
                End If
            End If
        Next ctl

        If Not IsDate(TxtFechaEntrega.Text) Then
            MessageBox.Show("Fecha no valida.", "Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtFechaEntrega.Focus()
            Exit Sub
        End If
        If ValidateEmail(TxtCorreo.Text) = False Then
            MessageBox.Show("Correo no Valido.", "Correo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtCorreo.Focus()
            Exit Sub
        End If

        ta.UpdateVehiculo(TxtMarca.Text, TxtSubmarca.Text, Txtversion.Text, Txtcolor.Text, Txtmodelo.Text, TxtNoVehic.Text, TxtSerie.Text,
                          TxtMotor.Text, TxtCapacidad.Text, TxtPlacas.Text, TxtDatosadd.Text, TxtLugarEnt.Text, TxtFechaEntrega.Text, TxtPersona.Text,
                          TxtCorreo.Text, TxtProvee.Text, TxtCosto.Text, CmbNivel.SelectedValue, TxtTipoCambio.Text, Contrato, Contrato)
        MessageBox.Show("Datos Guardados", "Datos Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TxtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCosto.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        SoloNumeros(KeyAscii, TxtCosto.Text)
    End Sub
    Private Sub txtTipoCambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTipoCambio.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        SoloNumeros(KeyAscii, TxtTipoCambio.Text)
    End Sub


End Class