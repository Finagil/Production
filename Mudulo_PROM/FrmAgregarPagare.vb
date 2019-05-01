Public Class FrmAgregarPagare
    Dim Disponible As Decimal
    Dim TaCred As New CreditoDSTableAdapters.CRED_LineasCreditoTableAdapter
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PromocionDS.Contratos' Puede moverla o quitarla según sea necesario.
        Me.ContratosTableAdapter.Fill(Me.PromocionDS.Contratos)
        CmbContrato.SelectedIndex = 1
        CmbContrato.SelectedIndex = 0
        DTFecha.MinDate = Date.Now
        DTFecha.MaxDate = Date.Now.AddDays(190)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbContrato.SelectedIndexChanged
        If CmbContrato.SelectedValue <> Nothing Then
            Me.PagaresTableAdapter.FillAnexo(Me.PromocionDS.Pagares, CmbContrato.SelectedValue)
            TxtTasa.Text = Me.PromocionDS.Pagares.Rows(Me.PromocionDS.Pagares.Rows.Count - 1).Item("Tasas")
            TxtDifer.Text = Me.PromocionDS.Pagares.Rows(Me.PromocionDS.Pagares.Rows.Count - 1).Item("Diferencial")
            TxtTipta.Text = Me.PromocionDS.Pagares.Rows(Me.PromocionDS.Pagares.Rows.Count - 1).Item("Tipta")
            If TxtTipta.Text = "7" Then
                'TxtTasa.Enabled = True
                'TxtDifer.Enabled = False
                TxtDifer.Text = 0
            Else
                'TxtTasa.Enabled = False
                TxtTasa.Text = 0
                'TxtDifer.Enabled = True
            End If
            Disponible = TaCred.MontoLineaCC(Me.PagaresBindingSource.Current("Cli"), "00", 2) - TaCred.SaldoCC(Me.PagaresBindingSource.Current("Cli"), "00", 2)
            TextDisponoble.Text = Disponible.ToString("n2")
            Dim EnProceso As Decimal = TaCred.EnProceso(Me.PagaresBindingSource.Current("Cli"), "00", 2)
            TextEnProceso.Text = EnProceso.ToString("n2")
            Disponible -= EnProceso
        End If
    End Sub

    Private Sub BtAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAdd.Click
        If TaCred.TieneVigentesPendientes(Me.PagaresBindingSource.Current("Cli"), "00", 9, 2, 2) <= 0 Then ' estatus dos autorizada
            MessageBox.Show("No tiene Linea de Crédito asignada para cuenta corriente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If IsNumeric(TxtMonto.Text) = False Then
            MessageBox.Show("Monto No Valido", "Error Monto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Focus()
            Exit Sub
        End If
        If CDbl(TxtMonto.Text) <= 0 Then
            MessageBox.Show("Monto No Valido", "Error Monto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Focus()
            Exit Sub
        End If

        If IsNumeric(TxtTasa.Text) = False Then
            MessageBox.Show("Tasa No Valida", "Error Tasa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Focus()
            Exit Sub
        End If

        If IsNumeric(TxtDifer.Text) = False Then
            MessageBox.Show("Diferencial No Valido", "Error Diferencial", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtDifer.Focus()
            Exit Sub
        End If

        If TxtTipta.Text = "7" And CDbl(TxtTasa.Text) <= 0 Then
            MessageBox.Show("Tasa No Valida", "Error en Tasas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Focus()
            Exit Sub
        End If

        If TxtTipta.Text <> "7" And CDbl(TxtDifer.Text) <= 0 Then
            MessageBox.Show("Diferencial No Valido", "Error en Diferencial", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Focus()
            Exit Sub
        End If
        If Disponible < CDec(TxtMonto.Text) Then
            MessageBox.Show("Línea de crédito insuficiente. Solo tiene para disponer " & Disponible.ToString("n2"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Focus()
            Exit Sub
        End If


        Dim PagareNew As Integer = CInt(GridPag.Item("PagareDataGridViewTextBoxColumn", GridPag.Rows.Count - 1).Value)
        Dim Pagare As String = PagareNew
        If Me.PromocionDS.Pagares.Rows.Count > 0 Then
            Dim Paga As String = GridPag.Item("PagareDataGridViewTextBoxColumn", GridPag.Rows.Count - 1).Value
            PagareNew += 1
            If PagareNew.ToString.Length = 1 Then
                Pagare = "0" & PagareNew.ToString
            Else
                Pagare = PagareNew.ToString
            End If
            If MessageBox.Show("¿Esta Seguro de Agregar el pagare " & PagareNew.ToString & " al Contrato " & CmbContrato.Text & " ?", "Agregar Pagare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim avios As New PromocionDSTableAdapters.AviosTableAdapter
                Dim T As New PromocionDS.AviosDataTable
                avios.Fill(T, Paga, CmbContrato.SelectedValue)
                Dim r As PromocionDS.AviosRow
                r = T.Rows(0)
                avios.Insert1(Pagare, r.Anexo, "A", "", r.Tipar, r.Cliente, "", "", "", "", "", "", Date.Now.ToString("yyyyMMdd"), DTFecha.Value.ToString("yyyyMMdd"), "", "", "",
                              TxtMonto.Text, r.HectareasActual, r.Tipta, TxtTasa.Text, r.DiferencialFINAGIL, 0, 0, 0, 0, "", "", "", "", "", "", Date.Now.ToString("yyyyMMdd"),
                              r.Parafin, Date.Now.ToString("yyyyMMdd"), "", "", "", "", "", 0, "", "", "", "", "", "", "", "", "", "", 0, 0, UsuarioGlobal, "", r.Fondeo, False,
                              r.AplicaGarantiaLIQ, r.AplicaFega, r.FegaFlat, r.Promotor, Me.PagaresBindingSource.Current("IvaAnexo"))
                Me.PagaresTableAdapter.FillAnexo(Me.PromocionDS.Pagares, CmbContrato.SelectedValue)
                CreaSeguimiento(r, Pagare)
                TxtMonto.Clear()
                TxtTasa.Clear()
            End If
        Else
            MessageBox.Show("No tiene Pagares", "Error Pagaré", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub CreaSeguimiento(ByRef r As PromocionDS.AviosRow, ByVal Pagare As String)
        Dim ta As New GeneralDSTableAdapters.GEN_PendientesTableAdapter
        Dim taU As New SeguridadDSTableAdapters.UsuariosFinagilTableAdapter
        Dim tu As New SeguridadDS.UsuariosFinagilDataTable
        taU.FillByUsuario(tu, UsuarioGlobal)
        Dim Nom As String = tu.Item(0).NombreCompleto

        ta.Insert("", Date.Now, DTFecha.Value, "Alta de Pagare CC Anexo: " & r.Anexo & " Pagaré: " & Pagare & " Importe: " & CDec(TxtMonto.Text).ToString("n2"), UsuarioGlobal, "atorres", "PCC", UsuarioGlobal, Nom, "PROMOCION", "atorres", r.Cliente)

    End Sub

    Private Sub TxtMonto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtMonto.Leave
        If IsNumeric(TxtMonto.Text) = True Then
            TxtMonto.Text = CDbl(TxtMonto.Text).ToString("N2")
        Else
            TxtMonto.Text = 0
        End If

    End Sub

    Private Sub GridPag_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles GridPag.UserDeletingRow
        Dim ciclo As String = GridPag.Item("PagareDataGridViewTextBoxColumn", e.Row.Index).Value
        Dim x As Double = Me.PagaresTableAdapter.ScalarCuantos(CmbContrato.SelectedValue, ciclo)
        If ciclo = "01" Then
            MessageBox.Show("el pagare 01 no se puede Eliminar ", "Error Pagaré", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        ElseIf x > 0 Then
            MessageBox.Show("Este pagare ya tiene movimientos", "Error Pagaré", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        Else
            If MessageBox.Show("¿Esta Seguro de eliminar el pagare " & ciclo.ToString & " del Contrato " & CmbContrato.Text & " ?", "Eliminar Pagare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
            Else
                e.Cancel = True
                Me.PagaresTableAdapter.DeletePagare(CmbContrato.SelectedValue, ciclo)
                Me.PagaresTableAdapter.FillAnexo(Me.PromocionDS.Pagares, CmbContrato.SelectedValue)
            End If
        End If
    End Sub

    Private Sub TxtTasa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTasa.Leave
        If IsNumeric(TxtTasa.Text) = True Then
            TxtTasa.Text = CDbl(TxtTasa.Text).ToString("N2")
        Else
            TxtTasa.Text = 0
        End If
    End Sub



End Class
