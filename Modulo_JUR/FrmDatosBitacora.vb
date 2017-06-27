Imports System.Security.Principal.WindowsIdentity
Imports System.Security
Imports System.IO
Imports Microsoft.Office.Interop

Public Class FrmDatosBitacora
    'Dim ta As New MC_BitacoraDSXTableAdapters.DatosConsultaTableAdapter

    Private Sub DatosBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JuridicoDS.Sucursales' table. You can move, or remove it, as needed.
        Me.SucursalesTableAdapter.Fill(Me.JuridicoDS.Sucursales)
        'TODO: This line of code loads data into the 'MC_BitacoraDSX.DatosConsulta' table. You can move, or remove it, as needed.
        Me.DatosConsultaTableAdapter.Fill(Me.JuridicoDS.DatosConsulta)
    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub CmbReporte_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbReporte.SelectedIndexChanged
        Dim ta4 As New JuridicoDSTableAdapters.DatosConsultaTableAdapter
        Dim t2 As New JuridicoDS.DatosConsultaDataTable
        Select Case Trim(CmbReporte.Text)
            Case "GLOBAL"
                ta4.Fill(t2)
            Case "CREDITOS TRAD."
                ta4.FillByTrad(t2)
            Case "CREDITOS AVIO"
                ta4.FillByAvio(t2)
            Case "POR SUCURSAL"
                ta4.FillBySuc(t2, Trim(CmbSucursal.SelectedValue))
        End Select
        DataGridView1.DataSource = t2
    End Sub
End Class