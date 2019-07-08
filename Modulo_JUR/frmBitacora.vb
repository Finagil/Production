Option Explicit On 

Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Security
Imports System.Security.Principal.WindowsIdentity


Public Class frmBitacora

    Inherits System.Windows.Forms.Form

    Protected Const TABLE_NAME As String = "Bitacora"

    Dim cQuien As String
    Dim myIdentity As Principal.WindowsIdentity
    Friend WithEvents JuridicoDS As JuridicoDS
    Friend WithEvents JURBitacoraCOBBindingSource As BindingSource
    Friend WithEvents JUR_BitacoraCOBTableAdapter As JuridicoDSTableAdapters.JUR_BitacoraCOBTableAdapter
    Friend WithEvents DataGrid1 As DataGridView
    Friend WithEvents PersonaQueLlamóDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DíaDeLlamadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RespuestaQueObtuvoConLaLlmadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromesaDePagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdBitacoraCobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextobsGen As TextBox
    Friend WithEvents JURBitacoraCOBOBSBindingSource As BindingSource
    Friend WithEvents JUR_BitacoraCOB_OBSTableAdapter As JuridicoDSTableAdapters.JUR_BitacoraCOB_OBSTableAdapter
    Friend WithEvents ContClie1BindingSource As BindingSource
    Friend WithEvents ContClie1TableAdapter As JuridicoDSTableAdapters.ContClie1TableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As System.Windows.Forms.Label


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtResp As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblClientes As System.Windows.Forms.Label
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.JURBitacoraCOBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JuridicoDS = New Agil.JuridicoDS()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResp = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ContClie1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGrid1 = New System.Windows.Forms.DataGridView()
        Me.PersonaQueLlamóDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DíaDeLlamadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RespuestaQueObtuvoConLaLlmadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromesaDePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdBitacoraCobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextobsGen = New System.Windows.Forms.TextBox()
        Me.JURBitacoraCOBOBSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JUR_BitacoraCOBTableAdapter = New Agil.JuridicoDSTableAdapters.JUR_BitacoraCOBTableAdapter()
        Me.JUR_BitacoraCOB_OBSTableAdapter = New Agil.JuridicoDSTableAdapters.JUR_BitacoraCOB_OBSTableAdapter()
        Me.ContClie1TableAdapter = New Agil.JuridicoDSTableAdapters.ContClie1TableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbDatos.SuspendLayout()
        CType(Me.JURBitacoraCOBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JURBitacoraCOBOBSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(26, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Salir"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(121, 415)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 14
        Me.btnInsert.Text = "Insertar"
        '
        'btnModif
        '
        Me.btnModif.Location = New System.Drawing.Point(217, 415)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(80, 24)
        Me.btnModif.TabIndex = 15
        Me.btnModif.Text = "Modificar"
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.DateTimePicker2)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.txtResp)
        Me.gbDatos.Controls.Add(Me.DateTimePicker1)
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.Location = New System.Drawing.Point(24, 445)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(795, 87)
        Me.gbDatos.TabIndex = 4
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Captura de Datos"
        Me.gbDatos.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(668, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Promesa de pago"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JURBitacoraCOBBindingSource, "Promesa de pago", True))
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(668, 56)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker2.TabIndex = 19
        '
        'JURBitacoraCOBBindingSource
        '
        Me.JURBitacoraCOBBindingSource.DataMember = "JUR_BitacoraCOB"
        Me.JURBitacoraCOBBindingSource.DataSource = Me.JuridicoDS
        '
        'JuridicoDS
        '
        Me.JuridicoDS.DataSetName = "JuridicoDS"
        Me.JuridicoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Respuesta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Día llamada"
        '
        'txtResp
        '
        Me.txtResp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JURBitacoraCOBBindingSource, "Respuesta que obtuvo con la llmada", True))
        Me.txtResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResp.Location = New System.Drawing.Point(121, 56)
        Me.txtResp.MaxLength = 100
        Me.txtResp.Name = "txtResp"
        Me.txtResp.Size = New System.Drawing.Size(520, 20)
        Me.txtResp.TabIndex = 18
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JURBitacoraCOBBindingSource, "Día de llamada", True))
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 56)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 17
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(303, 416)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Salvar"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ContClie1BindingSource
        Me.ComboBox1.DisplayMember = "Descr"
        Me.ComboBox1.Location = New System.Drawing.Point(26, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(424, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.ValueMember = "Cliente"
        '
        'ContClie1BindingSource
        '
        Me.ContClie1BindingSource.DataMember = "ContClie1"
        Me.ContClie1BindingSource.DataSource = Me.JuridicoDS
        '
        'lblClientes
        '
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(23, 18)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(432, 16)
        Me.lblClientes.TabIndex = 8
        Me.lblClientes.Text = "Selecciona un Cliente de la siguiente Lista"
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(471, 36)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(80, 24)
        Me.btnConsulta.TabIndex = 9
        Me.btnConsulta.Text = "Consultar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(569, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Label4"
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowUserToAddRows = False
        Me.DataGrid1.AllowUserToDeleteRows = False
        Me.DataGrid1.AutoGenerateColumns = False
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PersonaQueLlamóDataGridViewTextBoxColumn, Me.DíaDeLlamadaDataGridViewTextBoxColumn, Me.RespuestaQueObtuvoConLaLlmadaDataGridViewTextBoxColumn, Me.PromesaDePagoDataGridViewTextBoxColumn, Me.IdBitacoraCobDataGridViewTextBoxColumn})
        Me.DataGrid1.DataSource = Me.JURBitacoraCOBBindingSource
        Me.DataGrid1.Location = New System.Drawing.Point(22, 135)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(795, 268)
        Me.DataGrid1.TabIndex = 12
        '
        'PersonaQueLlamóDataGridViewTextBoxColumn
        '
        Me.PersonaQueLlamóDataGridViewTextBoxColumn.DataPropertyName = "Persona que llamó"
        Me.PersonaQueLlamóDataGridViewTextBoxColumn.HeaderText = "Persona que llamó"
        Me.PersonaQueLlamóDataGridViewTextBoxColumn.Name = "PersonaQueLlamóDataGridViewTextBoxColumn"
        Me.PersonaQueLlamóDataGridViewTextBoxColumn.ReadOnly = True
        Me.PersonaQueLlamóDataGridViewTextBoxColumn.Width = 200
        '
        'DíaDeLlamadaDataGridViewTextBoxColumn
        '
        Me.DíaDeLlamadaDataGridViewTextBoxColumn.DataPropertyName = "Día de llamada"
        Me.DíaDeLlamadaDataGridViewTextBoxColumn.HeaderText = "Día de llamada"
        Me.DíaDeLlamadaDataGridViewTextBoxColumn.Name = "DíaDeLlamadaDataGridViewTextBoxColumn"
        Me.DíaDeLlamadaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DíaDeLlamadaDataGridViewTextBoxColumn.Width = 110
        '
        'RespuestaQueObtuvoConLaLlmadaDataGridViewTextBoxColumn
        '
        Me.RespuestaQueObtuvoConLaLlmadaDataGridViewTextBoxColumn.DataPropertyName = "Respuesta que obtuvo con la llmada"
        Me.RespuestaQueObtuvoConLaLlmadaDataGridViewTextBoxColumn.HeaderText = "Respuesta que obtuvo con la llmada"
        Me.RespuestaQueObtuvoConLaLlmadaDataGridViewTextBoxColumn.Name = "RespuestaQueObtuvoConLaLlmadaDataGridViewTextBoxColumn"
        Me.RespuestaQueObtuvoConLaLlmadaDataGridViewTextBoxColumn.ReadOnly = True
        Me.RespuestaQueObtuvoConLaLlmadaDataGridViewTextBoxColumn.Width = 350
        '
        'PromesaDePagoDataGridViewTextBoxColumn
        '
        Me.PromesaDePagoDataGridViewTextBoxColumn.DataPropertyName = "Promesa de pago"
        Me.PromesaDePagoDataGridViewTextBoxColumn.HeaderText = "Promesa de pago"
        Me.PromesaDePagoDataGridViewTextBoxColumn.Name = "PromesaDePagoDataGridViewTextBoxColumn"
        Me.PromesaDePagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PromesaDePagoDataGridViewTextBoxColumn.Width = 120
        '
        'IdBitacoraCobDataGridViewTextBoxColumn
        '
        Me.IdBitacoraCobDataGridViewTextBoxColumn.DataPropertyName = "id_BitacoraCob"
        Me.IdBitacoraCobDataGridViewTextBoxColumn.HeaderText = "id_BitacoraCob"
        Me.IdBitacoraCobDataGridViewTextBoxColumn.Name = "IdBitacoraCobDataGridViewTextBoxColumn"
        Me.IdBitacoraCobDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdBitacoraCobDataGridViewTextBoxColumn.Visible = False
        '
        'TextobsGen
        '
        Me.TextobsGen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextobsGen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JURBitacoraCOBOBSBindingSource, "Observaciones", True))
        Me.TextobsGen.Location = New System.Drawing.Point(24, 82)
        Me.TextobsGen.MaxLength = 500
        Me.TextobsGen.Multiline = True
        Me.TextobsGen.Name = "TextobsGen"
        Me.TextobsGen.Size = New System.Drawing.Size(793, 47)
        Me.TextobsGen.TabIndex = 10
        '
        'JURBitacoraCOBOBSBindingSource
        '
        Me.JURBitacoraCOBOBSBindingSource.DataMember = "JUR_BitacoraCOB_OBS"
        Me.JURBitacoraCOBOBSBindingSource.DataSource = Me.JuridicoDS
        '
        'JUR_BitacoraCOBTableAdapter
        '
        Me.JUR_BitacoraCOBTableAdapter.ClearBeforeFill = True
        '
        'JUR_BitacoraCOB_OBSTableAdapter
        '
        Me.JUR_BitacoraCOB_OBSTableAdapter.ClearBeforeFill = True
        '
        'ContClie1TableAdapter
        '
        Me.ContClie1TableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(432, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Observaciones del Cliente"
        '
        'frmBitacora
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(834, 544)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextobsGen)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmBitacora"
        Me.Text = "Seguimiento de Cobranza"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        CType(Me.JURBitacoraCOBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuridicoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContClie1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JURBitacoraCOBOBSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ContClie1TableAdapter.Fill(Me.JuridicoDS.ContClie1)
        Try
            myIdentity = GetCurrent()
            Label4.Text = myIdentity.Name
            cQuien = Mid(UsuarioGlobalNombre, 1, 20)
            ComboBox1.MaxDropDownItems = 35
        Catch eException As Exception
            MsgBox(eException.Source & " " & eException.Message, MsgBoxStyle.Critical, "Mensaje de Error")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Not ComboBox1.SelectedValue Is Nothing Then
            BindDataGrid()
            If cQuien <> "" Then
                btnInsert.Enabled = True
                btnModif.Enabled = True
            End If
        Else
            Me.JuridicoDS.JUR_BitacoraCOB.Clear()
            Me.JuridicoDS.JUR_BitacoraCOB_OBS.Clear()
        End If
    End Sub

    Private Sub BindDataGrid()
        JUR_BitacoraCOBTableAdapter.Fill(JuridicoDS.JUR_BitacoraCOB, ComboBox1.SelectedValue.ToString())
        JUR_BitacoraCOB_OBSTableAdapter.Fill(JuridicoDS.JUR_BitacoraCOB_OBS, ComboBox1.SelectedValue.ToString())
        If JuridicoDS.JUR_BitacoraCOB_OBS.Rows.Count <= 0 Then
            JUR_BitacoraCOB_OBSTableAdapter.Insert(ComboBox1.SelectedValue, "")
            JUR_BitacoraCOB_OBSTableAdapter.Fill(JuridicoDS.JUR_BitacoraCOB_OBS, ComboBox1.SelectedValue.ToString())
        End If
        JURBitacoraCOBBindingSource.MoveLast()
    End Sub

    Private Sub btnInsert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        JUR_BitacoraCOBTableAdapter.InsertaBitacora(ComboBox1.SelectedValue.ToString(), cQuien, DTOC(Today), "", "")
        BindDataGrid()
        DataGrid1.Refresh()
        DateTimePicker1.Value = Today
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        gbDatos.Visible = True
        btnInsert.Enabled = False
        btnModif.Enabled = False
        btnSave.Enabled = True
        txtResp.Clear()
        txtResp.Focus()
    End Sub

    Private Sub btnModif_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModif.Click
        gbDatos.Visible = True
        btnInsert.Enabled = False
        btnModif.Enabled = False
        btnSave.Enabled = True
        DateTimePicker2.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        JUR_BitacoraCOBTableAdapter.UpdateBitacora(cQuien, txtResp.Text, DateTimePicker2.Value.ToString("yyyyMMdd"), Me.JURBitacoraCOBBindingSource.Current("id_bitacoraCob"), Me.JURBitacoraCOBBindingSource.Current("id_bitacoracob"))
        BindDataGrid()
        btnInsert.Enabled = True
        btnModif.Enabled = True
        gbDatos.Visible = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub TextobsGen_LostFocus(sender As Object, e As EventArgs) Handles TextobsGen.LostFocus
        Me.JURBitacoraCOBOBSBindingSource.EndEdit()
        Me.JuridicoDS.JUR_BitacoraCOB_OBS.GetChanges()
        Me.JUR_BitacoraCOB_OBSTableAdapter.Update(Me.JuridicoDS.JUR_BitacoraCOB_OBS)
    End Sub
End Class
