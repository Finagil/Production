Imports System.Data.SqlClient
Imports System.Math
Imports System.Security
Imports Microsoft.VisualBasic.Financial
Imports System.IO
Imports Word = Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop

Public Class FrmSolicitudesAVI
    Dim tasa As New AviosDSXTableAdapters.AVI_Tasa_ClienteTableAdapter
    Dim TaCred As New CreditoDSTableAdapters.CRED_LineasCreditoTableAdapter
    Dim Nuevo As Boolean = False
    Public Usuario As String
    Dim rrr As AviosDSX.ParametrosRow

    Private Sub FrmParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ParametrosTableAdapter.Fill(Me.AvioDS.Parametros)
        Me.GEN_CultivosTableAdapter.Fill(Me.SegurosDS.GEN_Cultivos)
        Me.CiclosTableAdapter.FillByVigentes(Me.SegurosDS.Ciclos)
        Me.SucursalesTableAdapter.Fill(Me.AvioDS.Sucursales)
        Bloquea(True)
        CargaDatos()
    End Sub

    Sub CargaDatos()
        If CmbCiclo.SelectedIndex > -1 And CmbSucursal.SelectedIndex > -1 And CmbCultivo.SelectedIndex > -1 Then
            Me.ParametrosTableAdapter.FillByFiltro(Me.AvioDS.Parametros, CmbCiclo.SelectedValue, CmbSucursal.SelectedValue, CmbCultivo.SelectedValue)
            If Me.AvioDS.Parametros.Rows.Count <= 0 Then
                Me.ParametrosTableAdapter.Insert(CmbCiclo.SelectedValue, CmbSucursal.SelectedValue, CmbCultivo.SelectedValue, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", 0, 0, "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", "19000101", "19000101")
                Me.ParametrosTableAdapter.FillByFiltro(Me.AvioDS.Parametros, CmbCiclo.SelectedValue, CmbSucursal.SelectedValue, CmbCultivo.SelectedValue)
            End If
            rrr = Me.AvioDS.Parametros.Rows(0)
            Me.ClientesTableAdapter.Fill(Me.AvioDS.Clientes, CmbSucursal.SelectedValue)
            CmbClientes_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub CmbCiclo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCiclo.SelectedIndexChanged
        CargaDatos()
    End Sub

    Private Sub CmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSucursal.SelectedIndexChanged
        CargaDatos()
    End Sub

    Private Sub CmbCultivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCultivo.SelectedIndexChanged
        CargaDatos()
    End Sub

    Private Sub CmbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbClientes.SelectedIndexChanged
        If CmbClientes.SelectedIndex > -1 Then
            Me.SolicitudesTableAdapter.Fill(Me.AvioDS.Solicitudes, Txtid.Text, CmbClientes.SelectedValue)
            Cmbsolicitudes_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Sub Bloquea(ByVal B As Boolean)
        GroupDatos.Enabled = B
        CmbClientes.Enabled = B
        BtnInegi.Enabled = B
        Cmbsolicitudes.Enabled = B
        BttNew.Enabled = B
        BttMod.Enabled = B
        BttMinistraciones.Enabled = B
        BtnAnexo.Enabled = B
        BttDel.Enabled = B
        BttSave.Enabled = Not B
        BttCancel.Enabled = Not B
        GroupSolicitud.Enabled = Not B
    End Sub

    Private Sub BttSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttSave.Click
        Dim CAT As Decimal = 0
        If CmbTipoSol.Text = "Habilitacion (H)" Then
            CAT = 0
        Else
            CAT = 0.01
        End If
        If Valida() = True Then
            SacaTIIE()
            Dim ta As New AviosDSXTableAdapters.AVI_SolicitudesTableAdapter
            Dim Importe As Decimal = 0
            If CmbTipoSol.Text = "Habilitacion (H)" Then
                'Importe = CDec(TxtSuper.Text) * CDec(TxtCuota.Text)
                Importe = CDec(TxtLinea.Text)
            Else
                Importe = CDec(TxtLinea.Text)
            End If

            If Nuevo = True Then
                ta.Insert(Txtid.Text, DTfecha.Value.ToString("yyyyMMdd"), CmbClientes.SelectedValue, TxtSuper.Text,
                TxtTIIE.Text, TxtPerBuro.Text, TxtPerBuroPM.Text, TxtRendi.Text, TxtDif.Text, TxtSegVida.Text, "S", CmbTipoSol.Text, CAT,
                CmbFondeo.Text, TxtAnexo.Text, CmbCiclo.SelectedValue, Usuario, Cmbz25.Text, CmbGarantia.Text, Importe, CmbTrianual.Text, DtFechaVenAnticipo.Value.ToString("yyyyMMdd"), "6", "NO", 0, "NO", 0, 0, CmbFega.Text)
            Else
                ta.UpdateSol(Txtid.Text, DTfecha.Value.ToString("yyyyMMdd"), CmbClientes.SelectedValue, TxtSuper.Text,
                TxtTIIE.Text, TxtPerBuro.Text, TxtPerBuroPM.Text, TxtRendi.Text, TxtDif.Text, TxtSegVida.Text, "S", CmbTipoSol.Text,
                CAT, CmbFondeo.Text, TxtAnexo.Text, CmbCiclo.SelectedValue, Usuario, Cmbz25.Text, CmbGarantia.Text, Importe, CmbTrianual.Text, DtFechaVenAnticipo.Value.ToString("yyyyMMdd"), "6", "NO", 0, "NO", 0, 0, CmbFega.Text, TxtIdSol.Text, TxtIdSol.Text)
            End If
            Bloquea(True)
            'CargaDatos()
            CmbClientes_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub BttCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCancel.Click
        Bloquea(True)
        CargaDatos()
    End Sub

    Private Sub BttNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttNew.Click
        If Val(TxtCuota.Text) = 0 Or Val(TxtBuro.Text) = 0 Or Val(TxtBuroPM.Text) = 0 Or Val(TxtSegAgri.Text) = 0 Or Val(TxtSegVid.Text) = 0 Then
            MessageBox.Show("Falta Capturar Parametros de Ciclo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtTipoPersona.Text = "F" Then
            MessageBox.Show("No se puede dar de alta un contrato de avio para persona Fisica (Sin actividad empresarial)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If tasa.SacaTasa(CmbClientes.Text.Trim, CiclosBindingSource.Current("Ciclo"), SEGCultivosBindingSource.Current("idCultivo")) <= 0 And Trim(SucursalesBindingSource.Current("Nombre_Sucursal")) <> "IRAPUATO" Then
            MessageBox.Show("el Cliente no tiene tasa configurada, favor de comunicarse con el area de Riesgos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Nuevo = True
        CargaDatosSOL(0)
        Bloquea(False)
    End Sub

    Private Sub BttMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttMod.Click
        If TxtIdSol.Text = "" Then
            MessageBox.Show("No hay Solicitud para Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If tasa.SacaTasa(CmbClientes.Text.Trim, CiclosBindingSource.Current("Ciclo"), SEGCultivosBindingSource.Current("idCultivo")) <= 0 And Trim(SucursalesBindingSource.Current("Nombre_Sucursal")) <> "IRAPUATO" Then
            MessageBox.Show("el Cliente no tiene tasa configurada, favor de comunicarse con el area de Riesgos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Nuevo = False
        CargaDatosSOL(Cmbsolicitudes.SelectedValue)
        Bloquea(False)
    End Sub

    Private Sub Cmbsolicitudes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbsolicitudes.SelectedIndexChanged
        If Cmbsolicitudes.SelectedIndex > -1 Then
            CargaDatosSOL(Cmbsolicitudes.SelectedValue)
        Else
            CargaDatosSOL(0)
        End If
    End Sub

    Sub CargaDatosSOL(ByVal Id As Integer)

        Dim ta As New AviosDSXTableAdapters.Vw_SolicitudesTableAdapter
        Dim T As New AviosDSX.Vw_SolicitudesDataTable
        ta.Fill(T, Id)
        If T.Rows.Count <= 0 Then
            'limpia campos
            DTfecha.Value = Date.Now
            DtFechaVenAnticipo.Value = Date.Now.AddDays(30)
            TxtSuper.Text = ""
            TxtPerBuro.Text = ""
            TxtPerBuroPM.Text = ""
            TxtRendi.Text = ""
            TxtDif.Text = tasa.SacaTasa(CmbClientes.Text.Trim, CiclosBindingSource.Current("Ciclo"), SEGCultivosBindingSource.Current("idCultivo"))
            If Trim(SucursalesBindingSource.Current("Nombre_Sucursal")) = "IRAPUATO" Then
                TxtDif.Text = TASA_AV_IRA
                TxtDif.Enabled = True
            Else
                TxtDif.Enabled = False
            End If
            CmbTipoSol.SelectedIndex = 0
                CmbFondeo.SelectedIndex = 1
                Cmbz25.SelectedIndex = 0
                CmbGarantia.SelectedIndex = 0
                CmbTrianual.SelectedIndex = 1
                TxtGastosAdmin.Text = ""
                TxtComi.Text = ""
                TxtBuroT.Text = ""
                TxtSegAgriT.Text = ""
                TxtSegVida.Text = ""
                TxtTIIE.Text = ""
                TxtLinea.Text = ""
                TxtCAT.Text = ""
                TxtAnexo.Text = ""
                BtnAnexo.Enabled = False
                CmbFega.Text = "Flat"
                If CmbSucursal.Text.Trim = "IRAPUATO" And CmbTipoSol.Text = "Habilitacion (H)" Then
                    CmbTrianual.Enabled = True
                Else
                    CmbTrianual.Enabled = False
                End If
            Else
                Dim R As AviosDSX.Vw_SolicitudesRow = T.Rows(0)
            DTfecha.Value = CTOD(R.FechaSolicitud)
            DtFechaVenAnticipo.Value = CTOD(R.FechaVencimiento)
            TxtSuper.Text = R.Superficie.ToString("n2")
            TxtPerBuro.Text = R.PersonasBuro
            TxtPerBuroPM.Text = R.PersonasBuroPM
            TxtRendi.Text = R.Rendimiento.ToString("n2")
            TxtDif.Text = tasa.SacaTasa(CmbClientes.Text.Trim, CiclosBindingSource.Current("Ciclo"), SEGCultivosBindingSource.Current("idCultivo"))
            If Trim(SucursalesBindingSource.Current("Nombre_Sucursal")) = "IRAPUATO" Then
                TxtDif.Text = R.Diferencial.ToString("n2")
                TxtDif.Enabled = True
            Else
                TxtDif.Enabled = False
            End If
            CmbTipoSol.Text = R.Tipo
            CmbFondeo.Text = R.Fondeo
            Cmbz25.Text = R.Z25
            TxtGastosAdmin.Text = R.GastosAdmin.ToString("n2")
            TxtComi.Text = R.Comision.ToString("n2")
            TxtBuroT.Text = R.Buro.ToString("n2")
            TxtSegAgriT.Text = R.SegAgricola.ToString("n2")
            If (R.TipoP = "E" Or R.TipoP = "F") And R.Tipo = "Habilitacion (H)" Then
                TxtSegVida.Text = R.SeguroVida.ToString("n2")
            Else
                TxtSegVida.Text = 0
            End If
            TxtTIIE.Text = R.TIIE
            TxtLinea.Text = R.Importe.ToString("n2")
            TxtCAT.Text = R.CAT.ToString("p1")
            TxtAnexo.Text = R.Anexo
            If CmbTipoSol.Text <> "Aumento Lin." Then
                TxtAnexo.ReadOnly = True
            Else
                TxtAnexo.ReadOnly = False
            End If
            CmbGarantia.Text = R.AplicaGarantiaLIQ
            If CmbSucursal.Text.Trim = "IRAPUATO" And CmbTipoSol.Text = "Habilitacion (H)" Then
                CmbTrianual.Enabled = True
            Else
                CmbTrianual.Enabled = False
            End If
            CmbTrianual.Text = R.Trianual

            If R.CAT <= 0 Then
                BtnAnexo.Enabled = False
            Else
                BtnAnexo.Enabled = True
            End If
            If CmbTipoSol.Text = "Habilitacion (H)" Then
                BttMinistraciones.Enabled = True
            Else
                BttMinistraciones.Enabled = False
            End If
            CmbFega.Text = R.Fega
        End If
        ta.Dispose()
        T.Dispose()
    End Sub

    Sub SacaTIIE()
        Dim Mes As String = Date.Now.ToString("yyyyMMdd")
        Dim TIIE As New AviosDSXTableAdapters.Vw_SolicitudesTableAdapter
        Dim fec As Date = CTOD(Mes)
        fec = fec.AddMonths(-1)
        Mes = fec.ToString("yyyyMM")
        TxtTIIE.Text = TIIE.TIIE(Mes)
    End Sub

    Private Sub BttDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttDel.Click
        If TxtIdSol.Text = "" Then
            MessageBox.Show("No hay Solicitud para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("¿Esta seguro de eliminar esta solicitud?", "Eliminar Solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.SolicitudesTableAdapter.DeleteSolicitud(TxtIdSol.Text)
            Me.SolicitudesTableAdapter.DeleteMinistraciones(TxtIdSol.Text)
            Bloquea(True)
            CargaDatos()
            CmbClientes_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub BttMinistraciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttMinistraciones.Click
        Dim ta As New AviosDSXTableAdapters.AVI_MinistracionesParametrosTableAdapter
        If Trim(SucursalesBindingSource.Current("Nombre_Sucursal")) = "IRAPUATO" And Val(TxtDif.Text) < TASA_AV_IRA Then
            MessageBox.Show("el diferencial menor es " & TASA_AV_IRA.ToString("n4") & ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If InStr(Trim(SEGCultivosBindingSource.Current("Cultivo")), "TRIGO") <= 0 And
                InStr(Trim(SEGCultivosBindingSource.Current("Cultivo")), "MAIZ") <= 0 And
                InStr(Trim(SEGCultivosBindingSource.Current("Cultivo")), "ALGODON") <= 0 Then
                If Val(TxtDif.Text) < TASA_AV_OTRO Then
                    MessageBox.Show("el diferencial menor es " & TASA_AV_OTRO.ToString("n4") & ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        End If

        If ta.ScalarMinistraciones(Txtid.Text) <= 0 Then
            ta.Dispose()
            MessageBox.Show("Ciclo sin ministraciones configuradas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ta.Dispose()
        If TxtIdSol.Text = "" Then
            MessageBox.Show("No hay Solicitud selecionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim f As New FrmMinistracionesSOL
        f.ID = TxtIdSol.Text
        f.IDparametro = Txtid.Text
        f.Importe = TxtLinea.Text
        f.TIEE = TxtTIIE.Text
        f.Diferencial = TxtDif.Text
        f.GastosIniciales = CDec(TxtGastosAdmin.Text) + CDec(TxtBuroT.Text) ' + CDec(TxtComi.Text) 
        f.Tvida = TxtSegVida.Text
        f.Fondeo = CmbFondeo.Text
        f.SegAgri = 0
        f.Fecha = CTOD(TxtFinCiclo.Text)
        f.Sucursal = ClientesBindingSource.Current("Sucursal")
        f.Cliente = ClientesBindingSource.Current("Cliente")
        If CmbFega.Text = "Flat" Then
            f.FegaFlat = True
        Else
            f.FegaFlat = False
        End If
        f.DiasVenc = DateDiff(DateInterval.Day, DTfecha.Value, DtFechaVenAnticipo.Value)
        f.AplicaGarantiaLIQ = CmbGarantia.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Cmbsolicitudes_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub CmbTipoSol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTipoSol.SelectedIndexChanged
        If CmbSucursal.Text.Trim = "IRAPUATO" And CmbTipoSol.Text = "Habilitacion (H)" Then
            CmbTrianual.Enabled = True
        Else
            CmbTrianual.Enabled = False
        End If
        CmbTrianual.SelectedIndex = 1

        If CmbTipoSol.Text = "Aumento Lin." Then
            TxtAnexo.Text = ""
            TxtAnexo.ReadOnly = False
        Else
            TxtAnexo.Text = ""
            TxtAnexo.ReadOnly = True
            If CmbTipoSol.Text = "Anticipo (A)" Or CmbTipoSol.Text = "Ampliación (AM)" Then
                CmbFondeo.SelectedIndex = 1
                CmbFondeo.Enabled = False
                TxtLinea.ReadOnly = False
                DtFechaVenAnticipo.Visible = True
                DtFechaVenAnticipo.Enabled = True
                Label38.Visible = True
                If CmbTipoSol.Text = "Ampliación (AM)" Then
                    CmbFondeo.Enabled = True
                    TxtLinea.ReadOnly = False
                End If
            Else
                CmbFondeo.Enabled = True
                CmbFondeo.SelectedIndex = 0
                'TxtLinea.ReadOnly = True se deja cambiar la linea en H pero solo hacia abajo
                DtFechaVenAnticipo.Visible = False
                DtFechaVenAnticipo.Enabled = False
                Label38.Visible = False
            End If
        End If
    End Sub

    Function Valida() As Boolean
        Valida = True
        If CmbTipoSol.Text = "Habilitacion (H)" Then
            If TaCred.TieneVigentesPendientes(CmbClientes.SelectedValue, CmbCiclo.SelectedValue, CmbCultivo.SelectedValue, 2, 2) <= 0 Then ' estatus dos autorizada
                MessageBox.Show("No tiene Linea de Crédito asignada para este ciclo. Favor de comunicarse al area de CREDIO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtSuper.Focus()
                Valida = False
                Exit Function
            End If
        End If
        If TxtSuper.Text = "" Or Not IsNumeric(TxtSuper.Text) Then
            MessageBox.Show("Error en Superficie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtSuper.Focus()
            Valida = False
            Exit Function
        End If

        If TxtPerBuro.Text = "" Or Not IsNumeric(TxtPerBuro.Text) Then
            MessageBox.Show("Error en Personas buro. PF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPerBuro.Focus()
            Valida = False
            Exit Function
        End If
        If TxtPerBuroPM.Text = "" Or Not IsNumeric(TxtPerBuroPM.Text) Then
            MessageBox.Show("Error en Personas buro. PM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPerBuroPM.Focus()
            Valida = False
            Exit Function
        End If
        If TxtTipoPersona.Text <> "M" Then
            If Val(TxtPerBuro.Text) < 1 Then
                MessageBox.Show("Error en Personas buro, debe ser mayor a 1. PF- PFAE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtPerBuro.Focus()
                Valida = False
                Exit Function
            End If
        Else
            If Val(TxtPerBuroPM.Text) < 1 Then
                MessageBox.Show("Error en Personas buro, debe ser mayor a 1. PM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtPerBuroPM.Focus()
                Valida = False
                Exit Function
            End If
        End If
        If TxtDif.Text = "" Or Not IsNumeric(TxtDif.Text) Then
            MessageBox.Show("Error en Diferencial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtDif.Focus()
            Valida = False
            Exit Function
        End If
        If Val(TxtDif.Text) > Val(TxtMax.Text) Or Val(TxtDif.Text) < Val(TxtMin.Text) Then
            MessageBox.Show("Error en Diferencial, fuera de rango.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtDif.Focus()
            Valida = False
            Exit Function
        End If
        If TxtRendi.Text = "" Or Not IsNumeric(TxtRendi.Text) Then
            MessageBox.Show("Error en Superficie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtRendi.Focus()
            Valida = False
            Exit Function
        End If
        If CmbTipoSol.Text = "Aumento Lin." And TxtAnexo.Text = "" Then
            MessageBox.Show("Error en Anexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtAnexo.Focus()
            Valida = False
            Exit Function
        End If
        If CmbTipoSol.Text = "Aumento Lin." Then
            If Me.SolicitudesTableAdapter.ScalarAnexos(TxtAnexo.Text, CmbCiclo.SelectedValue) <= 0 Then
                MessageBox.Show("Anexo No encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtAnexo.Focus()
                Valida = False
                Exit Function
            End If
        End If
        If DtFechaVenAnticipo.Value < DTfecha.Value Then
            MessageBox.Show("La fecha de vencimiento no puede ser menor a la fecha de solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DtFechaVenAnticipo.Focus()
            Valida = False
            Exit Function
        End If

        If (TxtTipoPersona.Text = "E" Or TxtTipoPersona.Text = "F") And CmbTipoSol.Text = "Habilitacion (H)" Then
            TxtSegVida.Text = TxtSegVid.Text
        Else
            TxtSegVida.Text = 0
        End If
        If TxtLinea.Text = "" Or Not IsNumeric(TxtLinea.Text) Then
            MessageBox.Show("Error en Monto del credito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtLinea.Focus()
            Valida = False
            Exit Function
        End If

        If CmbTipoSol.Text <> "Habilitacion (H)" Then
            If DTfecha.Value >= DtFechaVenAnticipo.Value Then
                MessageBox.Show("Fecha de Vencimiento menor a la fecha del solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtLinea.Focus()
                Valida = False
                Exit Function
            End If
        Else
            Dim Disponible As Decimal = TaCred.LineaPorDisponer(CmbClientes.SelectedValue, CmbCiclo.SelectedValue, CmbCultivo.SelectedValue, 2)
            If Disponible < CDec(TxtLinea.Text) Then
                MessageBox.Show("Línea de crédito insuficiente. Solo tiene para disponer " & Disponible.ToString("n2"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtLinea.Focus()
                Valida = False
                Exit Function
            End If
            If CDec(TxtLinea.Text) > (CDec(TxtSuper.Text) * CDec(TxtCuota.Text)) Then
                MessageBox.Show("El importe sobrepasa la cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtLinea.Focus()
                Valida = False
                Exit Function
            End If
        End If

    End Function

    Private Sub BtnInegi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInegi.Click
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daDatos As New SqlDataAdapter(cm1)
        Dim dsAgil As New DataSet()
        Dim drDatos As DataRow
        ' Declaración de variables de datos

        Dim oWord As New Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document
        Dim dsTemporal As New DataSet()
        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String

        Dim cAPaterno As String = ""
        Dim cAMaterno As String = ""
        Dim cNombre As String = ""
        Dim cDescr As String = ""
        Dim cRFC As String = ""
        Dim cCURP As String = ""
        Dim cNomrepr As String = ""
        Dim cTelef As String = ""
        Dim cEMail As String = ""
        Dim cCliente As String = ""
        Dim cTipo As String = ""

        cCliente = CmbClientes.SelectedValue

        ' El siguiente Stored Procedure trae todos los atributos de la tabla Anexos,
        ' para un anexo dado

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT NombreCliente, ApellidoPaterno, ApellidoMaterno, Descr, RFC, CURP, Nomrepr, Telef1, EMail1, Tipo FROM Clientes WHERE Cliente = " & cCliente
            .Connection = cnAgil
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daDatos.Fill(dsAgil, "Datos")

        drDatos = dsAgil.Tables("Datos").Rows(0)

        cAPaterno = Trim(drDatos("ApellidoPaterno"))
        cAMaterno = Trim(drDatos("ApellidoMaterno"))
        cNombre = Trim(drDatos("NombreCliente"))
        cDescr = Trim(drDatos("Descr"))
        cRFC = Trim(drDatos("RFC"))
        cCURP = Trim(drDatos("CURP"))
        cNomrepr = Trim(drDatos("Nomrepr"))
        cTelef = Trim(drDatos("Telef1"))
        cEMail = Trim(drDatos("EMail1"))
        cTipo = drDatos("Tipo")

        oRuta = My.Settings.RootDoc & "AV\Norma Tecnica INEGI.docx"

        oWord = New Microsoft.Office.Interop.Word.Application()

        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        If File.Exists("\\server-nas\Fira\FormatoNormaTecnica\" & cCliente & "_" & cDescr & ".docx") = True Then
            OpenFile("\\server-nas\Fira\FormatoNormaTecnica\" & cCliente & "_" & cDescr & ".docx")
        Else

            ' Cargo la plantilla

            oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)

            For Each myMField In oWordDoc.Fields

                rFieldCode = myMField.Code

                cFieldText = rFieldCode.Text

                If cFieldText.StartsWith(" MERGEFIELD") Then

                    ' Los campos tienen el formato MERGEFIELD NombreCampo \* MERGETYPE, por lo que con estas sentencias extraemos la parte NombreCampo únicamente

                    finMerge = cFieldText.IndexOf("\")

                    fieldNameLen = cFieldText.Length - finMerge

                    cfName = cFieldText.Substring(11, finMerge - 11)

                    ' Guardamos el nombre del campo en la variable, quitándole los espacios en blanco

                    cfName = cfName.Trim()

                    ' Ahora comprobamos si el nombre del campo coincide con el que nosotros queremos,
                    ' y si es asi le aplicamos el valor de la variable

                    Select Case cfName

                        Case "mAPaterno"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Stuff(cAPaterno, "D", " ", 40)
                        Case "mAMaterno"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Stuff(cAMaterno, "D", " ", 37)
                        Case "mNombres"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cNombre
                        Case "mDescr"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cTipo = "M" Then
                                myMField.Result.Text = cDescr
                            Else
                                myMField.Result.Text = "________________________________________________________________________"
                            End If
                        Case "mRFC"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Stuff(cRFC, "D", " ", 28)
                        Case "mCURP"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Stuff(cCURP, "D", " ", 43)
                        Case "mTelef"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = Stuff(cTelef, "D", " ", 46)
                        Case "mRepre"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            If cNomrepr <> "" Then
                                myMField.Result.Text = cNomrepr
                            Else
                                myMField.Result.Text = "________________________________________________________________________"
                            End If
                        Case "mEmail"
                            oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                            myMField.Result.Text = cEMail
                    End Select

                    oWord.Selection.Fields.Update()

                End If

            Next

            'Guardo el documento

            Dim Format As Object = Word.WdSaveFormat.wdFormatDocumentDefault
            Dim oMissing = System.Reflection.Missing.Value

            oWord.ActiveDocument.Select()
            oWord.WordBasic.ToString()
            oWord.Visible = True

            Dim oSaveAsFile = "H:\" & cCliente & "_" & cDescr & ".docx"

            oWordDoc.SaveAs(oSaveAsFile, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
        End If
    End Sub

    Public Sub OpenFile(ByVal Path As String)

        Try

            Dim InfoProceso As New System.Diagnostics.ProcessStartInfo

            Dim Proceso As New System.Diagnostics.Process

            With InfoProceso
                .FileName = Path
                .CreateNoWindow = True
                .ErrorDialog = True
                .UseShellExecute = True
                .WindowStyle = ProcessWindowStyle.Normal
            End With

            Proceso.StartInfo = InfoProceso

            Proceso.Start()

            Proceso.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al abrir el documento")

        End Try

        Me.Close()

    End Sub

    Private Sub CmbFondeo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbFondeo.SelectedIndexChanged
        If CmbFondeo.Text = "Fira" Then
            Label23.Visible = True
            TxtGastosAdmin.Visible = True
            Label22.Visible = False
            TxtComi.Visible = False
            CmbGarantia.SelectedIndex = 0
            CmbGarantia.Enabled = True
            CmbFega.Enabled = True
            CmbFega.SelectedIndex = 0
        Else
            Label23.Visible = False
            TxtGastosAdmin.Visible = False
            Label22.Visible = True
            TxtComi.Visible = True
            CmbGarantia.SelectedIndex = 1
            CmbGarantia.Enabled = False
            CmbFega.Enabled = False
            CmbFega.SelectedIndex = 2
        End If
    End Sub

    Private Sub BtnAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnexo.Click
        Dim IVA_Cliente As Decimal = 0
        If MessageBox.Show("¿esta seguro de generar el contrato?", "Contrato de Avío", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim taAV As New AviosDSXTableAdapters.AviosTableAdapter
        Dim taFira As New AviosDSXTableAdapters.FIRA_AnexosDatosTableAdapter
        Dim Cultivos As New GeneralDSTableAdapters.CultivosTableAdapter
        Dim cAnexo As String = taAV.AnexoMAX(CmbClientes.SelectedValue)
        Dim Prefijo As String
        Dim Tipar As String
        Dim x As Integer = 0

        If cAnexo.Trim = "0" Then
            Dim Id As Integer = taAV.SacaLlave()
            While x = 0
                Id += 1
                cAnexo = "0" & Id.ToString & "0001"
                If taAV.ExisteAnexoTRadicional(cAnexo) = 0 And taAV.ExisteAnexoAvio(cAnexo) = 0 Then
                    taAV.UpdateLLave(Id)
                    x = 1
                End If
            End While
        Else
            While x = 0
                Prefijo = Val(Mid(cAnexo, 6, 4)) + 1
                Select Case Prefijo.Length
                    Case 1
                        Prefijo = "000" & Prefijo
                    Case 2
                        Prefijo = "00" & Prefijo
                    Case 3
                        Prefijo = "0" & Prefijo
                End Select
                cAnexo = Mid(cAnexo, 1, 5) & Prefijo
                If taAV.ExisteAnexoAvio(cAnexo) = 0 Then
                    x = 1
                End If
            End While
        End If
        Dim Fondeo As String = "01"
        Dim Ampli As String = "N"
        Dim Cultivo As String = Cultivos.SacaLetraCultivo(CmbCultivo.SelectedValue)
        Dim AplicaFega As Boolean
        Dim FegaFlat As Boolean
        Dim PorcFega As Decimal = 0
        Dim PorcReserva As Decimal = 0

        If CmbTipoSol.Text = "Ampliación (AM)" Then Ampli = "S"

        If CmbFondeo.Text = "Fira" Then
            Fondeo = "03"
            If CmbFega.Text = "No Aplica" Then
                AplicaFega = False
                FegaFlat = False
            Else
                AplicaFega = True
                If CmbFega.Text = "Flat" Then
                    FegaFlat = True
                Else
                    FegaFlat = False
                End If
                If CmbSucursal.SelectedValue = "03" Or CmbSucursal.SelectedValue = "04" Or CmbSucursal.SelectedValue = "08" Then ' mexicali, san luis y navojoa
                    PorcFega = PORC_FEGA_NORTE_AV  ' FEGA 1.79 + IVA
                Else
                    PorcFega = PORC_FEGA_AV ' FEGA 2.0 + IVA
                End If
            End If
        Else
            PorcReserva = 0.5
        End If
        Dim cat As Decimal = Math.Round(CDec(Mid(TxtCAT.Text, 1, TxtCAT.Text.Length - 1)), 1)
        Dim ContratoMarco As String = "0000000"
        Dim Termina As String = rrr.FechaTerminacion
        If Mid(CmbTipoSol.Text, 1, 1) = "A" Then
            Termina = DtFechaVenAnticipo.Value.ToString("yyyyMMdd")
            If Mid(CmbTipoSol.Text, 1, 2) = "Am" And Fondeo = "03" Then
                Tipar = "H"
            Else
                Tipar = "A"
            End If
        Else
            Tipar = "H"
        End If
        If CmbSucursal.SelectedValue = "04" Or CmbSucursal.SelectedValue = "08" Then
            If MessageBox.Show("¿Desea aplicar IVA al 8% en este contrato?", "IVA 8%", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                IVA_Cliente = 8
                Dim taIva As New ContaDSTableAdapters.CONT_AutorizarIVATableAdapter
                taIva.Insert(cAnexo, CmbCiclo.SelectedValue, False, "ContabilidadX")
            Else
                IVA_Cliente = TaQUERY.TasaIvaCliente(CmbClientes.SelectedValue)
            End If
        End If
        ContratoMarco = Genera_Contrato_Marco(cAnexo, CmbClientes.SelectedValue, Tipar)
        Me.SolicitudesTableAdapter.UpdateSol("A", cAnexo, Cmbsolicitudes.SelectedValue)
        taAV.InsertAnexo(CmbCiclo.SelectedValue, cAnexo, "A", Tipar, CmbClientes.SelectedValue,
        DTfecha.Value.ToString("yyyyMMdd"), Termina, TxtLinea.Text, TxtSuper.Text, TxtDif.Text,
        rrr.CuotaHectarea, rrr.PrecioTonelada, TxtRendi.Text, Cultivo, DTfecha.Value.ToString("yyyyMMdd"),
        rrr.FechaLimiteDTC, DTfecha.Value.ToString("yyyyMMdd"), rrr.FechaSiembrai, rrr.FechaSiembraf, rrr.FechaCosechai, rrr.FechaCosechaf,
        Fondeo, TxtSegVid.Text, Mid(Cmbz25.Text, 1, 1), "", UCase(CmbGarantia.Text), ContratoMarco, cat, Ampli, AplicaFega, FegaFlat, PorcFega,
        PorcReserva, IVA_Cliente)
        taFira.InsertAnexo(cAnexo, CmbClientes.SelectedValue, Cultivo)
        TaQUERY.UpdatePromoActualAvios()
        ContratoMarco = SacaContratoMarcoLargo(0, cAnexo)
        MessageBox.Show("Se genero el contrato: " & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4) & vbCrLf &
        "Se genero el contrato Marco: " & ContratoMarco, "Contrato Avío")
        'mexicalli(7000)
        'navojoa se toma conscutivo
        'irapuato(8695)
        'tradicionales 3590
        If CmbTrianual.Text.ToUpper = "SI" Then
            Dim FC2 As String = CTOD(rrr.FechaCosechai2).ToString("DEL dd DE MMMM DEL yyyy al ").ToUpper & CTOD(rrr.FechaCosechaf2).ToString("dd DE MMMM DEL yyyy").ToUpper
            Dim FS2 As String = CTOD(rrr.FechaSiembrai2).ToString("DEL dd DE MMMM DEL yyyy al ").ToUpper & CTOD(rrr.FechaSiembraf2).ToString("dd DE MMMM DEL yyyy").ToUpper
            Dim FC3 As String = CTOD(rrr.FechaCosechai3).ToString("DEL dd DE MMMM DEL yyyy al ").ToUpper & CTOD(rrr.FechaCosechaf3).ToString("dd DE MMMM DEL yyyy").ToUpper
            Dim FS3 As String = CTOD(rrr.FechaSiembrai3).ToString("DEL dd DE MMMM DEL yyyy al ").ToUpper & CTOD(rrr.FechaSiembraf3).ToString("dd DE MMMM DEL yyyy").ToUpper

            taAV.UpdateAños2y3(rrr.FechaLimiteDTC2, rrr.FechaLimiteDTC3, rrr.FechaTerminacion2, rrr.FechaTerminacion3, FS2, FS3, FC2, FC3, cAnexo, CmbCiclo.SelectedValue)

        End If
        CmbClientes_SelectedIndexChanged(Nothing, Nothing)

    End Sub
    Private Sub TxtSuper_Leave(sender As Object, e As EventArgs) Handles TxtSuper.Leave
        If IsNumeric(TxtSuper.Text) Then
            TxtLinea.Text = (CDec(TxtSuper.Text) * CDec(TxtCuota.Text)).ToString("n2")
        End If
    End Sub
End Class