Imports System.Security.Principal.WindowsIdentity
Imports System.Security
Public Class frmJURBitacora
    Dim ta As New JuridicoDSTableAdapters.Vw_ActivosTableAdapter
    Dim Cliente As String
    Dim Contrato As String = ""
    Dim Ciclo As String
    Dim FeLimite As Date = "01/01/1900"
    Dim myIdentity As Principal.WindowsIdentity
    Dim DescCiclo As String = ""


    Private Sub frmJURBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SucursalesTableAdapter.Fill(Me.JuridicoDS.Sucursales)
        Me.ListaClientesTableAdapter.Fill(Me.JuridicoDS.ListaClientes)
    End Sub

    Private Sub CmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCliente.SelectedIndexChanged
        Cliente = CmbCliente.SelectedValue

        If rbActivos.Checked = True Then
            Dim ta2 As New JuridicoDSTableAdapters.Vw_ActivosTableAdapter
            Dim t2 As New JuridicoDS.Vw_ActivosDataTable
            If Not IsNothing(Cliente) Then
                ta2.Fill(t2, Cliente)
                DataGridView1.DataSource = t2
            End If
        ElseIf rbNoACTIVOS.Checked = True Then
            Dim ta1 As New JuridicoDSTableAdapters.Vw_ActivosTableAdapter
            Dim t1 As New JuridicoDS.Vw_ActivosDataTable

            ta1.FillByTxCte(t1, Cliente)
            DataGridView1.DataSource = t1
        End If

    End Sub

    Private Sub DataGridView1_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Contrato = Trim(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        Ciclo = Trim(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
        DescCiclo = Trim(DataGridView1.Rows(e.RowIndex).Cells(2).Value)

        Dim ta3 As New JuridicoDSTableAdapters.InfBitacoraTableAdapter
        Dim t3 As New JuridicoDS.InfBitacoraDataTable

        If Ciclo = "" Then
            Ciclo = " "
        End If

        ta3.Fill(t3, Contrato, Ciclo)

        If t3.Rows.Count = 0 Then
            ta3.InsertBitacora(Contrato, Ciclo)
        End If
        If Ciclo = " " Then
            DatosAnexos(Contrato)
        Else
            DatosAvios(Contrato, Ciclo)
        End If
        Me.Text = Mid(Contrato, 1, 5) & "/" & Mid(Contrato, 6, 4) & " " & Trim(DataGridView1.Rows(e.RowIndex).Cells(3).Value) ''''''
    End Sub

    Private Sub bSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSave.Click
        Dim ta5 As New JuridicoDSTableAdapters.InfBitacoraTableAdapter
        Dim t5 As New JuridicoDS.InfBitacoraDataTable

        ta5.Fill(t5, Contrato, Ciclo)
        ta5.UpdateBitacora(DTIngNot.Value, DTFirmaPro.Value, txtHora.Text, txtNotario.Text, DTFirmaNot.Value, DTIngRPP.Value, DTProcuNot.Value, DTEntregaNot.Value, DTEntregaGV.Value, DTInscripRUG.Value, DTEntGVSucur.Value, txtCosto.Text, txtRecibo.Text, DTFechaPago.Value, DTEntGV.Value, DTEntFisica.Value, FeLimite, txtObserva.Text, txtObservaMC.Text, CmbLib.SelectedItem, DTFechaLib.Value, DescCiclo, Contrato, Ciclo)
        MessageBox.Show("Datos Actualizados Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        DataGridView1.ClearSelection()
        rbActivos.Checked = False
        rbNoACTIVOS.Checked = False
        ta.Connection.Close()
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim newDatosBitacora As New FRMDatosBitacora
        newDatosBitacora.Show()
    End Sub

    Private Sub DTEntregaNot_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTEntregaNot.ValueChanged
        If DTEntregaNot.Value > "01/01/1900" Then
            FeLimite = DateAdd(DateInterval.Day, 30, DTEntregaNot.Value)
            Label30.Text = "Fecha Limite es " & FeLimite
        End If
    End Sub

    Private Sub rbAAvio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAAvio.CheckedChanged
        cbSucursal.Enabled = True
        rbActivos.Checked = False
        rbNoACTIVOS.Checked = False
        rbATrad.Checked = False
        CmbCliente.Enabled = False
        CmbCtos.Enabled = True

        Dim ta2 As New JuridicoDSTableAdapters.Vw_ActivosTableAdapter
        Dim t2 As New JuridicoDS.Vw_ActivosDataTable
        Dim r2 As JuridicoDS.Vw_ActivosRow

        If cbSucursal.SelectedIndex > 0 Then
            ta2.FillByAvioSucur(t2, cbSucursal.SelectedValue)
            DataGridView1.DataSource = t2
        Else
            ta2.FillByAvios(t2)
            DataGridView1.DataSource = t2
        End If
        CmbCtos.Items.Clear()
        For Each r2 In t2.Rows
            CmbCtos.Items.Add(r2.Anexo)
        Next

    End Sub

    Private Sub rbATrad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbATrad.CheckedChanged
        cbSucursal.Enabled = True
        rbActivos.Checked = False
        rbNoACTIVOS.Checked = False
        rbAAvio.Checked = False
        CmbCliente.Enabled = False
        CmbCtos.Enabled = True

        Dim ta2 As New JuridicoDSTableAdapters.Vw_ActivosTableAdapter
        Dim t2 As New JuridicoDS.Vw_ActivosDataTable
        Dim r2 As JuridicoDS.Vw_ActivosRow

        If cbSucursal.SelectedIndex > 0 Then
            ta2.FillByAnexoSucur(t2, cbSucursal.SelectedValue)
            DataGridView1.DataSource = t2
        Else
            ta2.FillByAnexos(t2)
            DataGridView1.DataSource = t2
        End If
        CmbCtos.Items.Clear()
        For Each r2 In t2.Rows
            CmbCtos.Items.Add(r2.Anexo)
        Next

    End Sub

    Private Sub CmbCtos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCtos.SelectedIndexChanged
        DataGridView1.FirstDisplayedScrollingRowIndex = CmbCtos.SelectedIndex
    End Sub

    Private Sub rbActivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbActivos.CheckedChanged
        CmbCliente.Enabled = True
        CmbCtos.Enabled = False
    End Sub

    Private Sub rbNoACTIVOS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoACTIVOS.CheckedChanged
        CmbCliente.Enabled = True
        CmbCtos.Enabled = False
    End Sub

    Private Sub cbSucursal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSucursal.SelectedIndexChanged
        CmbCliente.Enabled = False
    End Sub

    Sub DatosAnexos(ByVal Contrato As String)

        Dim ta4 As New JuridicoDSTableAdapters.AnexoBitacoraTableAdapter
        Dim t4 As New JuridicoDS.AnexoBitacoraDataTable
        Dim r4 As JuridicoDS.AnexoBitacoraRow

        ta4.Fill(t4, Contrato)
        r4 = t4.Rows(0)

        DTAutorizacion.Enabled = False
        DTIniCto.Value = CTOD(r4.Fechacon)
        DTTermino.Enabled = False
        cbPrenda.Checked = False
        cbHipotec.Checked = False
        If r4.Prenda = "S" Then
            cbPrenda.Checked = True
        End If
        If r4.GHipotec = "S" Then
            cbHipotec.Checked = True
        End If

        DTIngNot.Value = r4.FIngNotaria
        DTFirmaPro.Value = r4.FFProd
        txtHora.Text = r4.Hora
        txtNotario.Text = r4.Notario
        DTFirmaNot.Value = r4.FFNotaria
        DTIngRPP.Value = r4.FIRPP
        DTProcuNot.Value = r4.FPNotara
        DTEntregaNot.Value = r4.FENotaria
        DTEntregaGV.Value = r4.FEGVsinRUG
        DTInscripRUG.Value = r4.FInscripcion
        DTEntGVSucur.Value = r4.FEGVSucursal
        txtObserva.Text = r4.Observaciones
        txtCosto.Text = r4.Costo
        txtRecibo.Text = r4.NumRecibo
        DTFechaPago.Value = r4.FPago
        DTEntGV.Value = r4.FEGV
        DTEntFisica.Value = r4.FEFisica
        txtObservaMC.Text = r4.NotasMC
        CmbLib.Text = r4.Liberado
        DTFechaLib.Value = r4.FechaLib

        If UsuarioGlobal = "lmercado" Then
            DTIngNot.Enabled = False
            DTFirmaPro.Enabled = False
            txtHora.Enabled = False
            txtNotario.Enabled = False
            DTFirmaNot.Enabled = False
            DTIngRPP.Enabled = False
            DTProcuNot.Enabled = False
            DTEntregaNot.Enabled = False
            DTEntregaGV.Enabled = False
            DTInscripRUG.Enabled = False
            DTEntGVSucur.Enabled = False
            txtObserva.Enabled = False

            txtCosto.Enabled = True
            txtRecibo.Enabled = True
            DTFechaPago.Enabled = True
            DTEntGV.Enabled = True
            DTEntFisica.Enabled = True
            txtObservaMC.Enabled = True
            CmbLib.Enabled = True
            DTFechaLib.Enabled = True
        ElseIf UsuarioGlobal = "tcortez" Then
            DTIngNot.Enabled = True
            DTFirmaPro.Enabled = True
            txtHora.Enabled = True
            txtNotario.Enabled = True
            DTFirmaNot.Enabled = True
            DTIngRPP.Enabled = True
            DTProcuNot.Enabled = True
            DTEntregaNot.Enabled = True
            DTEntregaGV.Enabled = True
            DTInscripRUG.Enabled = True
            DTEntGVSucur.Enabled = True
            txtObserva.Enabled = True

            txtCosto.Enabled = True
            txtRecibo.Enabled = True
            DTFechaPago.Enabled = True
            DTEntGV.Enabled = True
            DTEntFisica.Enabled = True
            txtObservaMC.Enabled = True
            CmbLib.Enabled = False
            DTFechaLib.Enabled = False
        End If

    End Sub

    Sub DatosAvios(ByVal Contrato As String, ByVal Ciclo As String)

        Dim ta4 As New JuridicoDSTableAdapters.DatosBitacoraTableAdapter
        Dim t4 As New JuridicoDS.DatosBitacoraDataTable
        Dim r4 As JuridicoDS.DatosBitacoraRow

        ta4.Fill(t4, Contrato, Ciclo)
        r4 = t4.Rows(0)

        DTAutorizacion.Enabled = False
        DTTermino.Enabled = True
        DTAutorizacion.Value = CTOD(r4.FechaAutorizacion)
        DTIniCto.Value = CTOD(r4.FechaContrato)
        DTTermino.Value = CTOD(r4.FechaTerminacion)
        cbPrenda.Checked = False
        cbHipotec.Checked = False
        If r4.GarantiaPrendaria = "SI" Then
            cbPrenda.Checked = True
        End If
        If r4.GarantiaHipotecaria = "SI" Then
            cbHipotec.Checked = True
        End If

        DTIngNot.Value = r4.FIngNotaria
        DTFirmaPro.Value = r4.FFProd
        txtHora.Text = r4.Hora
        txtNotario.Text = r4.Notario
        DTFirmaNot.Value = r4.FFNotaria
        DTIngRPP.Value = r4.FIRPP
        DTProcuNot.Value = r4.FPNotara
        DTEntregaNot.Value = r4.FENotaria
        DTEntregaGV.Value = r4.FEGVsinRUG
        DTInscripRUG.Value = r4.FInscripcion
        DTEntGVSucur.Value = r4.FEGVSucursal
        txtObserva.Text = r4.Observaciones
        txtCosto.Text = r4.Costo
        txtRecibo.Text = r4.NumRecibo
        DTFechaPago.Value = r4.FPago
        DTEntGV.Value = r4.FEGV
        DTEntFisica.Value = r4.FEFisica
        txtObservaMC.Text = r4.NotasMC
        CmbLib.Text = r4.Liberado
        DTFechaLib.Value = r4.FechaLib

        If UsuarioGlobal = "lmercado" Then
            DTIngNot.Enabled = False
            DTFirmaPro.Enabled = False
            txtHora.Enabled = False
            txtNotario.Enabled = False
            DTFirmaNot.Enabled = False
            DTIngRPP.Enabled = False
            DTProcuNot.Enabled = False
            DTEntregaNot.Enabled = False
            DTEntregaGV.Enabled = False
            DTInscripRUG.Enabled = False
            DTEntGVSucur.Enabled = False
            txtObserva.Enabled = False

            txtCosto.Enabled = True
            txtRecibo.Enabled = True
            DTFechaPago.Enabled = True
            DTEntGV.Enabled = True
            DTEntFisica.Enabled = True
            txtObservaMC.Enabled = True
            CmbLib.Enabled = True
            DTFechaLib.Enabled = True

        ElseIf UsuarioGlobal = "tcortez" Then
            DTIngNot.Enabled = True
            DTFirmaPro.Enabled = True
            txtHora.Enabled = True
            txtNotario.Enabled = True
            DTFirmaNot.Enabled = True
            DTIngRPP.Enabled = True
            DTProcuNot.Enabled = True
            DTEntregaNot.Enabled = True
            DTEntregaGV.Enabled = True
            DTInscripRUG.Enabled = True
            DTEntGVSucur.Enabled = True
            txtObserva.Enabled = True

            txtCosto.Enabled = True
            txtRecibo.Enabled = True
            DTFechaPago.Enabled = True
            DTEntGV.Enabled = True
            DTEntFisica.Enabled = True
            txtObservaMC.Enabled = True
            CmbLib.Enabled = False
            DTFechaLib.Enabled = False
        End If

    End Sub


End Class