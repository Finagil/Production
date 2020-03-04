Option Explicit On

Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Math
Public Class frmConsTasasvig
  
    Private Sub frmConsTasasvig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Declaración de variables de conexión ADO .NET
        CmbTipoTasa.SelectedIndex = 0
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daPeriodos As New SqlDataAdapter(cm1)
        Dim drPeriod As DataRow
        Dim drTabla As DataRow
        Dim dtTabla As New DataTable("PeriodoTasas")

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Periodo, FechaInip, FechaFinp FROM PeriodoTasas Order by Periodo"
            .Connection = cnAgil
        End With
        daPeriodos.Fill(dsAgil, "Periodos")

        ' Creo la tabla dtPeriodoTasas que me permitirá almacenar la información de la Tasas Vigentes

        dtTabla.Columns.Add("Periodo", Type.GetType("System.String"))
        dtTabla.Columns.Add("Fechai", Type.GetType("System.String"))
        dtTabla.Columns.Add("Fechaf", Type.GetType("System.String"))

        For Each drPeriod In dsAgil.Tables("Periodos").Rows
            drTabla = dtTabla.NewRow()
            drTabla("Periodo") = drPeriod("Periodo")
            drTabla("Fechai") = CTOD(drPeriod("FechaInip")).ToShortDateString
            drTabla("Fechaf") = CTOD(drPeriod("FechaFinp")).ToShortDateString
            dtTabla.Rows.Add(drTabla)
        Next

        DataGridView1.DataSource = dtTabla

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        ' Declaración de variables de conexión ADO .NET
      
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim cm4 As New SqlCommand()
        Dim dsAgil As New DataSet()
        Dim daTasasAplicables As New SqlDataAdapter(cm1)

        Dim nPeriodo As Integer
        Dim cFechai As String
        Dim cFechaf As String
        Dim i As Byte

        nPeriodo = Trim(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        cFechai = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        cFechaf = DataGridView1.Rows(e.RowIndex).Cells(2).Value

        ' El siguiente Stored Procedure trae todas las tasas aplicables para el tipo de crédito especificado

        With cm1
            .CommandType = CommandType.StoredProcedure
            .CommandText = "TasasAplicables1"
            .Connection = cnAgil
            .Parameters.Add("@TipoCredito", SqlDbType.NVarChar)
            .Parameters(0).Value = "AFsinIVA"
            .Parameters.Add("@Periodo", SqlDbType.Int)
            .Parameters(1).Value = nPeriodo
            .Parameters.Add("@TipoTasa", SqlDbType.NVarChar)
            .Parameters(2).Value = CmbTipoTasa.Text
        End With

        ' Llenar el DataSet lo cual abre y cierra la conexión

        daTasasAplicables.Fill(dsAgil, "AFsinIVA")
        i = dsAgil.Tables("AFsinIVA").Rows.Count

        ' Ahora defino el segundo tipo de crédito

        cm1.Parameters(0).Value = "AFconIVA"
        daTasasAplicables.Fill(dsAgil, "AFconIVA")

        ' Ahora defino el tercer tipo de crédito

        cm1.Parameters(0).Value = "AP"
        daTasasAplicables.Fill(dsAgil, "AP")

        ' Ahora defino el cuarto tipo de crédito

        cm1.Parameters(0).Value = "CR"
        daTasasAplicables.Fill(dsAgil, "CR")

        ' Ahora defino el cuarto tipo de crédito

        cm1.Parameters(0).Value = "CS"
        daTasasAplicables.Fill(dsAgil, "CS")

        ' Ahora defino el quinto tipo de crédito

        cm1.Parameters(0).Value = "TVAFsinIVA"
        daTasasAplicables.Fill(dsAgil, "TVAFsinIVA")

        ' Ahora defino el sexto tipo de crédito

        cm1.Parameters(0).Value = "TVAFconIVA"
        daTasasAplicables.Fill(dsAgil, "TVAFconIVA")

        ' Ahora defino el séptimo tipo de crédito

        cm1.Parameters(0).Value = "TVCR"
        daTasasAplicables.Fill(dsAgil, "TVCR")

        ' Ahora defino el octavo tipo de crédito

        cm1.Parameters(0).Value = "TVAP"
        daTasasAplicables.Fill(dsAgil, "TVAP")

        'Definimos el decimo tipo de crédito

        cm1.Parameters(0).Value = "TVCS"
        daTasasAplicables.Fill(dsAgil, "TVCS")

        ' Asigno cada tabla a su correspondiente DataGridView

        dgvAFsinIVA.DataSource = dsAgil.Tables("AFsinIVA")
        dgvAFconIVA.DataSource = dsAgil.Tables("AFconIVA")
        dgvCR.DataSource = dsAgil.Tables("CR")
        dgvAP.DataSource = dsAgil.Tables("AP")
        dgvCS.DataSource = dsAgil.Tables("CS")
        dgvTVAFsinIVA.DataSource = dsAgil.Tables("TVAFsinIVA")
        dgvTVAFconIVA.DataSource = dsAgil.Tables("TVAFconIVA")
        dgvTVCR.DataSource = dsAgil.Tables("TVCR")
        dgvTVAP.DataSource = dsAgil.Tables("TVAP")
        dgvTVCS.DataSource = dsAgil.Tables("TVCS")

        Label12.Text = "Vigencia del " & cFechai & " al " & cFechaf
        Label12.Visible = True
        'Label13.Text = "Vigencia del " & cFechai & " al " & cFechaf
        'Label13.Visible = True

    End Sub

End Class