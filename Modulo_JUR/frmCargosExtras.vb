Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports System.Text.ASCIIEncoding
Imports Microsoft.VisualBasic

Public Class frmCargosExtras

    Inherits System.Windows.Forms.Form

    ' Declaración de variables de conexión ADO .NET de alcance privado

    Dim dsAgil As New DataSet
    Dim drUdis As DataRowCollection

    ' Declaración de variables de datos de alcance privado

    Dim cAnexo As String = ""
    Dim cFechaCon As String = ""
    Dim cCliente As String = ""
    Dim cNombreCliente As String = ""
    Dim cLetra As String = ""
    Dim cTipar As String = ""
    Dim cTipo As String = ""
    Dim cTipta As String = ""
    Dim nTasa As Decimal = 0
    Dim nDifer As Decimal = 0
    Dim cFeven As String = ""
    Dim cFepag As String = ""
    Dim cFechaMora As String = ""

    Dim nSaldo As Decimal = 0
    Dim nTasaIvaCliente As Decimal = 0
    Dim nDiasMoratorios As Integer = 0
    Dim nTasaMoratoria As Decimal = 0
    Dim nMoratorios As Decimal = 0
    Dim nIvaMoratorios As Decimal = 0
    Dim nCargoTotal As Decimal = 0

    Dim cBanco As String = ""
    Dim cCuentaCLABE As String = ""
    Dim cTarjeta As String = ""
    Dim cCuentaBancomer As String = ""
    Dim promocionds As New PromocionDSTableAdapters.PROM_Cargos_ExtrasTableAdapter


    Private Sub frmCargosExtras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UsuarioGlobal = "maria.vidal" Then
            txtMoratorios.Enabled = True
        End If
        cFeven = Today.Date.ToString("yyyyMMdd")
        Me.Cargos_ExtrasTableAdapter.Fill(PromocionDS1.Cargos_Extras, ChkProc.Checked)
        Me.DeudoresTableAdapter.Fill(PromocionDS1.Deudores, Today.Date.ToString("yyyyMMdd"))
        Dim i As Integer = 0
        Dim daUdis As New PromocionDSTableAdapters.TraeUdisTableAdapter
        daUdis.Fill(PromocionDS1.TraeUdis)
        drUdis = PromocionDS1.TraeUdis.Rows
        dgvCargosRegistrados.DataSource = PromocionDS1.Cargos_Extras
        dgvCargosRegistrados.Columns(0).Width = 36         ' Contrato
        dgvCargosRegistrados.Columns(1).Width = 15         ' Letra
        dgvCargosRegistrados.Columns(2).Width = 114        ' Nombre del Cliente
        dgvCargosRegistrados.Columns(3).Width = 35         ' Fecha del cargo
        dgvCargosRegistrados.Columns(4).Width = 40         ' Adeudo
        dgvCargosRegistrados.Columns(5).Width = 35         ' Moratorios
        dgvCargosRegistrados.Columns(6).Width = 35         ' Iva Moratorios
        dgvCargosRegistrados.Columns(7).Width = 70        ' Importe del Cargo
        dgvCargosRegistrados.Columns(9).Width = 70        ' Usuario
        dgvCargosRegistrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For i = 0 To dgvCargosRegistrados.Columns.Count - 1
            If i = 0 Or i = 1 Or i = 3 Then
                dgvCargosRegistrados.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el encabezado
                dgvCargosRegistrados.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el contenido
            ElseIf i >= 4 Then
                dgvCargosRegistrados.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el encabezado
                dgvCargosRegistrados.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el contenido
            End If
        Next

    End Sub

    Private Sub btnAdeudos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdeudos.Click

        If Not cbDeudores.SelectedValue Is Nothing Then
            GroupBox1.Visible = True
            cCliente = cbDeudores.SelectedValue.ToString()
            LlenaDatos()
        End If

    End Sub

    Private Sub LlenaDatos()
        Me.FacturasTableAdapter.Fill(PromocionDS1.Facturas, Today.Date.ToString("yyyyMMdd"), cCliente)
        dgvAdeudos.DataSource = PromocionDS1.Facturas
        dgvAdeudos.Columns(0).Width = 30         ' Anexo
        dgvAdeudos.Columns(1).Width = 20         ' Letra
        dgvAdeudos.Columns(2).Width = 150        ' Nombre del Cliente
        dgvAdeudos.Columns(3).Width = 50         ' Adeudo
        dgvAdeudos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dim i As Integer
        For i = 0 To dgvAdeudos.Columns.Count - 1
            If i = 0 Or i = 1 Then
                dgvAdeudos.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el encabezado
                dgvAdeudos.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinea el contenido
            ElseIf i = 3 Then
                dgvAdeudos.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el encabezado
                dgvAdeudos.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight ' Alinea el contenido
            End If
            If i > 3 Then
                dgvAdeudos.Columns(i).Visible = False
            End If
        Next
    End Sub

    Private Sub btnEditarAdeudo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarAdeudo.Click

        ' Debo traerme el tipo de financiamiento, el tipo de cliente, la tasa (del contrato si no tiene adeudos o de la factura vencida),
        ' la fecha de último pago (en el caso de las facturas vencidas)

        cAnexo = dgvAdeudos.Item(0, dgvAdeudos.CurrentRow.Index).Value
        cLetra = dgvAdeudos.Item(1, dgvAdeudos.CurrentRow.Index).Value
        cNombreCliente = dgvAdeudos.Item(2, dgvAdeudos.CurrentRow.Index).Value
        nSaldo = dgvAdeudos.Item(3, dgvAdeudos.CurrentRow.Index).Value
        cBanco = Trim(dgvAdeudos.Item(4, dgvAdeudos.CurrentRow.Index).Value)
        cCuentaCLABE = Trim(dgvAdeudos.Item(5, dgvAdeudos.CurrentRow.Index).Value)
        cTarjeta = Trim(dgvAdeudos.Item(6, dgvAdeudos.CurrentRow.Index).Value)
        cCuentaBancomer = Trim(dgvAdeudos.Item(7, dgvAdeudos.CurrentRow.Index).Value)
        cTipo = dgvAdeudos.Item(11, dgvAdeudos.CurrentRow.Index).Value
        cTipar = dgvAdeudos.Item(12, dgvAdeudos.CurrentRow.Index).Value
        nTasa = dgvAdeudos.Item(13, dgvAdeudos.CurrentRow.Index).Value
        nDifer = dgvAdeudos.Item(14, dgvAdeudos.CurrentRow.Index).Value
        cFeven = dgvAdeudos.Item(15, dgvAdeudos.CurrentRow.Index).Value
        cFepag = dgvAdeudos.Item(16, dgvAdeudos.CurrentRow.Index).Value
        nTasaIvaCliente = dgvAdeudos.Item(17, dgvAdeudos.CurrentRow.Index).Value
        Try
            cFechaCon = Me.CargosExtrasBindingSource.Current("FechaCon")
        Catch ex As Exception
            cFechaCon = Date.Now.ToString("yyyyMMdd")
        End Try

        txtBanco.Text = cBanco
        txtCuentaCLABE.Text = cCuentaCLABE
        txtCuentaBancomer.Text = cCuentaBancomer
        txtTarjeta.Text = cTarjeta

        txtAdeudo.Text = nSaldo.ToString
        If cLetra = "" Then
            txtAdeudo.Enabled = True
        Else
            txtAdeudo.Enabled = False
        End If
        txtMoratorios.Text = "0.00"
        txtIvaMoratorios.Text = "0.00"
        txtCargoTotal.Text = nSaldo.ToString

        dtpFechaMora.Value = Today.Date
        dtpFechaCargo.Value = Today.Date
        GroupBox2.Visible = True

    End Sub

    Private Sub dtpFechaMora_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaMora.ValueChanged
        'ValidaFechaCargo()
        'CalculaDatos()
    End Sub

    Private Sub btnIncluirCargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluirCargo.Click
        If ValidaFechaCargo() = True Then
            CalculaDatos()
            InsertPROM_CARGOS_EXTRAS(cAnexo, nSaldo, dtpFechaCargo.Value.ToString("yyyyMMdd"))
            Me.Cargos_ExtrasTableAdapter.Fill(PromocionDS1.Cargos_Extras, ChkProc.Checked)
            btnIncluirCargo.Enabled = False
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub InsertPROM_CARGOS_EXTRAS(ByVal cAnexo As String, ByVal nSaldo As Decimal, ByVal cFechaCargo As String)
        Dim tmpTime As DateTime = Format(Now, "yyyy-MM-dd h:mm tt")
        promocionds.Insert(Mid(cAnexo, 1, 5) + Mid(cAnexo, 7, 4), cLetra, nSaldo, nMoratorios, nIvaMoratorios, nCargoTotal, cFechaCargo, tmpTime, False, UsuarioGlobal)
    End Sub

    Private Sub cbDeudores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDeudores.SelectedIndexChanged
        If GroupBox1.Visible = True Then
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub btnOmitirCargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOmitirCargo.Click
        GroupBox2.Visible = False
    End Sub

    Private Function ValidaFechaCargo() As Boolean
        lblMensajeFecha.Text = ""
        btnIncluirCargo.Enabled = False
        Dim nDiasCargo As Decimal = 0
        nDiasCargo = DateDiff(DateInterval.Day, Today.Date, dtpFechaCargo.Value.Date)
        If cCuentaCLABE <> "" And cBanco <> "BANCOMER" Then
            If nDiasCargo < 1 Then
                lblMensajeFecha.Text = "Debe haber por lo menos 1 día entre hoy y la fecha de cargo"
                Return (False)
                Exit Function
            End If
        Else
            If nDiasCargo < 1 Then
                lblMensajeFecha.Text = "Debe haber por lo menos 1 días entre hoy y la fecha de cargo"
                Return (False)
                Exit Function
            End If
        End If
        btnIncluirCargo.Enabled = True
        Return (True)
    End Function

    Private Sub dtpFechaCargo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaCargo.ValueChanged
        dtpFechaMora.Value = dtpFechaCargo.Value
        ValidaFechaCargo()
        CalculaDatos()
    End Sub

    Private Sub CalculaDatos()
        nDiasMoratorios = 0
        nTasaMoratoria = 0
        nMoratorios = 0
        nIvaMoratorios = 0
        nCargoTotal = 0
        cFechaMora = dtpFechaMora.Value.ToString("yyyyMMdd")
        nSaldo = CType(txtAdeudo.Text, Double)
        If cLetra <> "" Then
            nTasaMoratoria = Round((nTasa + nDifer) * 2, 2)
            If Trim(cFepag) = "" Then
                nDiasMoratorios = DateDiff(DateInterval.Day, CTOD(cFeven), CTOD(cFechaMora))
            Else
                If cFeven >= cFepag Then
                    nDiasMoratorios = DateDiff(DateInterval.Day, CTOD(cFeven), CTOD(cFechaMora))
                Else
                    nDiasMoratorios = DateDiff(DateInterval.Day, CTOD(cFepag), CTOD(cFechaMora))
                End If
            End If
            If nDiasMoratorios < 0 Then
                nDiasMoratorios = 0
            End If
            If nDiasMoratorios > 0 Then
                CalcMora(cTipar, cTipo, cFechaMora, drUdis, nSaldo, nTasaMoratoria, nDiasMoratorios, nMoratorios, nIvaMoratorios, nTasaIvaCliente, cAnexo, "", cFechaCon)
            End If

        End If

        nCargoTotal = Round(nSaldo + nMoratorios + nIvaMoratorios, 2)
        txtMoratorios.Text = nMoratorios
        txtIvaMoratorios.Text = nIvaMoratorios
        txtCargoTotal.Text = nCargoTotal

    End Sub

    Private Sub ChkProc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkProc.CheckedChanged
        Me.Cargos_ExtrasTableAdapter.Fill(PromocionDS1.Cargos_Extras, ChkProc.Checked)
    End Sub

    Private Sub dgvCargosRegistrados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCargosRegistrados.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            If MessageBox.Show("¿Esta seguro de borrar el Cargo extra de " & dgvCargosRegistrados.Rows(e.RowIndex).Cells(2).Value & "?", "Eliminar Fila", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cargos_ExtrasTableAdapter.BorraCargoAnexo(dgvCargosRegistrados.Rows(e.RowIndex).Cells(8).Value)
                Me.Cargos_ExtrasTableAdapter.Fill(PromocionDS1.Cargos_Extras, ChkProc.Checked)
            End If
        End If
    End Sub
End Class
