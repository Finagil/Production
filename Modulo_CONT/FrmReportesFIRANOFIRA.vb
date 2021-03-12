Imports System.IO
Public Class FrmReportesFIRANOFIRA
    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Dim EncabezadoNF As String = "NO. CREDITO BANCO,NOMBRE ACREDITADO, FECHA OPERACION,TIPO PERSONA,RFC,CURP,MONEDA DE ORIGEN,CADENA PRODUCTIVA,ENTIDAD FEDERATIVA,PORCENTAJE GTIA LIQUIDA,TRATAMIENTO CREDITICIO,DESCRIPCION TRATAMIENTO CREDITICIO,SALDO INSOLUTO IF-ACREDITADO,ESTATUS DE LA CARTERA,TIPO CREDITO,METODOLOGIA DE CALIFICACION,DIAS MAXIMO INCUMPLIMIENTO,NC VALOR AJUSTADO GTÍAS,A1 VALOR AJUSTADO GTÍAS,A2 VALOR AJUSTADO GTÍAS,B1 VALOR AJUSTADO GTÍAS,B2 VALOR AJUSTADO GTÍAS,B3 VALOR AJUSTADO GTÍAS,C1 VALOR AJUSTADO GTÍAS,C2 VALOR AJUSTADO GTÍAS,D VALOR AJUSTADO GTÍAS,E VALOR AJUSTADO GTÍAS,CALIF INICIAL PORC EXPUESTA (DEUDOR),LÍMITE DE ESTIMACIONES,PAGO SOSTENIDO,DIAS CUMPLIMIENTO POSTERIOR RESTRUCTURA,DIAS INCUMPLIMIENTO PREVIO RESTRUCTURA,DIAS INCUMPLIMIENTO DESPUES RESTRUCTURA,DIAS AMORTIZACION ORIGINAL,PI,SP,EI,% RESERVAS POR PERDIDA ESPERADA,NIVEL DE RIESGO POR PERDIDA ESPERADA,SALDO EXPUESTO,SALDO EXPUESTO FINAL,RESERVAS GARANTIA LIQUIDA,RESERVAS ""B"" OTRAS GTIAS,RESERVAS SALDO EXPUESTO FINAL,RESERVAS TOTALES,"
        Dim Arre As String() = EncabezadoNF.Split(",")
        Dim Mezcla As New ContaDS.sp_CONT_RPT_MEZCLADataTable
        Dim MezclaR() As ContaDS.sp_CONT_RPT_MEZCLARow
        Dim ta As New ContaDSTableAdapters.sp_CONT_RPT_MEZCLATableAdapter

        Cursor.Current = Cursors.WaitCursor
        'Try
        Lberror.Visible = False
        Dim cAnexo, cTipar, id_credito As String
        Dim DB As String = My.Settings.BaseDatos
        DB = cbBase.Text
        Dim Conn As String = "Server=" & My.Settings.ServidorBACK & "; DataBase=" & DB & "; User ID=User_PRO; pwd=User_PRO2015"
        ta.Connection.ConnectionString = Conn
        Dim cFecha As String
        Dim Mes As String = DB.Substring(4, 3) & " " & DB.Substring(0, 4)
        ta.Fill(Mezcla, Mes)
        Dim AA As New StreamReader(TextFile.Text, System.Text.Encoding.Default)
        Dim CF As New StreamWriter("c:\Files\CarteraFira" & DB & ".csv", False, System.Text.Encoding.Default)
        Dim Cad As String = AA.ReadLine
        Dim CadX As String()
        CF.WriteLine(Cad)
        While AA.EndOfStream = False
            Cad = AA.ReadLine
            Cad = Cad.Replace(Chr(34) & Chr(44) & Chr(34), Chr(34) & Chr(124) & Chr(34)) 'coma 44 pipe 124 comilla doble 34
            Cad = Cad.Replace(Chr(34) & Chr(34) & Chr(44), Chr(34) & Chr(34) & Chr(124))
            CadX = Cad.Split("|")
            id_credito = CadX(0).Replace("""", "")
            CadX(21) = ta.SacaAnexo(id_credito)
            If IsNothing(CadX(21)) Then
                CadX(21) = ""
            Else
                CadX(21) = CadX(21).Replace(" ", "")
            End If
            CadX(22) = 0
            CadX(25) = 0
            If CadX(21).Length < 9 Then
                id_credito = CadX(1).Replace("""", "")
                If ta.EsClienteFactoraje(id_credito) > 0 Then
                    CadX(21) = "88888/8888"
                Else
                    CadX(21) = ""
                End If
            ElseIf CadX(21) = "00000/0000" Then
                Lberror.Visible = True
                Lberror.Text = "Contratos no encontrados en el Pasivo Fira"
            Else
                cAnexo = CadX(21).Replace("/", "")
                cTipar = TaQUERY.SacaTipar(cAnexo)
                If cTipar = "H" Or cTipar = "A" Or cTipar = "C" Then
                    CadX(25) = ta.SacaMaxDiasAtraso_AV(cAnexo)
                    If IsNumeric(CadX(25)) Then
                        If Val(CadX(25)) < 0 Then
                            CadX(25) = 0
                        End If
                    End If
                Else
                    CadX(25) = ta.SacaMaxDiasAtraso_TRA(cAnexo)
                End If
                CadX(22) = ta.SacaSaldoMezcla(Mes, CadX(21))
                MezclaR = Mezcla.Select("Anexo ='" & CadX(21) & "'")
                For Each r As ContaDS.sp_CONT_RPT_MEZCLARow In MezclaR
                    Mezcla.Removesp_CONT_RPT_MEZCLARow(r)
                Next
            End If
            CadX(21) = """" & CadX(21) & """"
            CadX(22) = """" & CadX(22) & """"
            CadX(23) = """VIGENTE"""
            CadX(24) = """PE"""
            CadX(25) = """" & CadX(25) & """"
            CadX(26) = """0"""
            CadX(36) = """A1"""
            CadX(37) = """SUPERIOR"""
            CadX(38) = """SI"""
            CadX(39) = """0"""
            CadX(40) = """0"""
            CadX(41) = """0"""
            CadX(42) = """0"""
            Cad = String.Join(",", CadX)
            CF.WriteLine(Cad)
        End While
        AA.Close()
        CF.Close()

        Dim Ta1 As New ContaDSTableAdapters.DatosAnexoTableAdapter
        Dim T1 As New ContaDS.DatosAnexoDataTable
        Dim r1 As ContaDS.DatosAnexoRow
        Dim CN As New StreamWriter("c:\Files\CarteraNoFira" & DB & ".csv", False, System.Text.Encoding.Default)
        Ta1.Connection.ConnectionString = Conn
        CN.WriteLine(EncabezadoNF)
        For Each r As ContaDS.sp_CONT_RPT_MEZCLARow In Mezcla.Rows
            If r.Total <= 0 Then Continue For
            Array.Clear(Arre, 0, Arre.Length)
            Arre(0) = r.Anexo
            Arre(1) = r.Nombre

            Ta1.Fill(T1, r.Anexo)
            If T1.Rows.Count > 0 Then
                r1 = T1.Rows(0)
                Arre(2) = r1.FechaContrato
                Arre(3) = r1.TipoPersona
                Arre(4) = r1.RFC
                Arre(5) = r1.CURP
                Arre(6) = r1.Moneda 'mn usd
                Arre(8) = r1.Estado
                Arre(13) = r1.EstatusContable
                If r1.Reestructura = "S" Then
                    Arre(10) = "SI"
                    Arre(11) = "PRORROGA"
                    Arre(29) = "SI"
                Else
                    Arre(10) = "NO"
                    Arre(11) = ""
                    Arre(29) = ""
                End If
                cTipar = TaQUERY.SacaTipar(r.AnexoSin)
                If cTipar = "H" Or cTipar = "A" Or cTipar = "C" Then
                    Arre(16) = ta.SacaMaxDiasAtraso_AV(r.AnexoSin)
                Else
                    Arre(16) = ta.SacaMaxDiasAtraso_TRA(r.AnexoSin)
                End If
            End If
            Arre(7) = "OTRAS CADENAS PRODUC"
            Arre(9) = 0
            Arre(12) = r.Total
            Arre(14) = r.Producto
            Arre(15) = "PE"

            For x As Integer = 17 To 28
                Arre(x) = 0
            Next
            For x As Integer = 30 To 33
                Arre(x) = 0
            Next
            Arre(36) = r.CapitalCartera
            For x As Integer = 0 To Arre.Length - 1
                Arre(x) = Chr(34) & Arre(x) & Chr(34)
            Next
            CN.WriteLine(String.Join(",", Arre))
        Next
        CN.Close()
        cFecha = cbBase.SelectedValue
        MessageBox.Show("Proceso Terminado", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub FrmReportesFIRANOFIRA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New DataTable
        Dim r As DataRow
        t.Columns.Add("ID")
        t.Columns.Add("TIT")
        Dim Fecha As Date = Date.Now
        r = t.NewRow
        For x As Integer = 0 To 1
            Fecha = Fecha.AddDays(-1 * Fecha.Day)
            If Fecha >= "01/07/2019" Then
                r = t.NewRow
                r("ID") = Fecha.ToString("yyyyMMdd")
                r("TIT") = Mid(Fecha.ToString("yyyyMMM").ToUpper, 1, 7)
                t.Rows.Add(r)
            End If
        Next
        cbBase.DataSource = t
        cbBase.DisplayMember = t.Columns("TIT").ToString
        cbBase.ValueMember = t.Columns("ID").ToString
        cbBase.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New OpenFileDialog
        f.Title = "Seleccione el archivir CSV para subir"
        f.Multiselect = False
        f.Filter = "Archivos Csv  (*.csv)|*.csv"
        f.FilterIndex = 1
        f.RestoreDirectory = True
        If f.ShowDialog = DialogResult.OK Then
            TextFile.Text = f.FileName
            Dim Archi As New StreamReader(TextFile.Text)
            Dim Cad As String = Archi.ReadLine
            If InStr(Cad, "CREDITO ID,NOMBRE ACREDITADO, FECHA OPERACION") <= 0 Then
                MessageBox.Show("Archivo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextFile.Text = ""
            End If
            Archi.Close()
        Else
            TextFile.Text = ""
        End If
    End Sub
End Class