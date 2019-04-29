Option Explicit On

Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports Word = Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop

Public Class frmConvenio
    Dim nIdFP As Decimal
    Dim nConFP As Integer
    Dim lFirstTime As Boolean = True
    Public Sub New(ByVal cContrato As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        txtDatos.Text = cContrato

    End Sub
  
    Private Sub frmConvenio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As SqlConnection = New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim dsAgil As DataSet = New DataSet()
        Dim daFuentep As New SqlDataAdapter(cm1)

        ' Este Stored Procedure trae TODOS los Nombres de las Fuentes de Pago registradas hasta el momento

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM FuentePago_Avio"
            .Connection = cnAgil
        End With

        ComboBox1.MaxDropDownItems = 15

        ' Llenar el DataSet

        daFuentep.Fill(dsAgil, "Comprador")

        If dsAgil.Tables("Comprador").Rows.Count > 0 Then

            ' Ligar la tabla Clientes del dataset dsAgil al ComboBox

            ComboBox1.DataSource = dsAgil
            ComboBox1.DisplayMember = Trim("Comprador.NomFtepag")
            ComboBox1.ValueMember = "Comprador.IDFtepag"
            lFirstTime = False

        Else

            Dim cGenRepFP As String
            Dim cPoderFP As String

            cGenRepFP = "Llmarse ___, manifiesta por sus generales ser de nacionalidad ___, "
            cGenRepFP = cGenRepFP & "originario de la ciudad de ___, lugar donde nacio el ___, de estado "
            cGenRepFP = cGenRepFP & "civil ___, con domicilio ubicado en ___, con CURP. _____ y con R.F.C. ___."

            cPoderFP = "Mismo que cuenta con facultades suficientes para obligarla en los términos del presente "
            cPoderFP = cPoderFP & "contrato, como se acredita con la Escritura pública número ___, ante la fe del ___, "
            cPoderFP = cPoderFP & "titular de la Notaria Publica número ___, con fecha ___, e inscrita bajo Folio Mercantil Electrónico "
            cPoderFP = cPoderFP & "número ___,en el Registro Público de la Propiedad y de Comercio del ____ de fecha ____, "
            cPoderFP = cPoderFP & "facultades que bajo protesta de decir verdad manifiestan no les han sido modificadas ni renovadas a la "
            cPoderFP = cPoderFP & "fecha de celebración de este acto."

            txtNameFP.Visible = True
            ComboBox1.Enabled = False
            txtGeneRep.Text = cGenRepFP
            txtFacultadesRep.Text = cPoderFP
            txtModo.Text = "I"

        End If

    End Sub

    Private Sub btnNvaFP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNvaFP.Click

        Dim cGenRepFP As String
        Dim cPoderFP As String

        cGenRepFP = "Llmarse ___, manifiesta por sus generales ser de nacionalidad ___, "
        cGenRepFP = cGenRepFP & "originario de la ciudad de ___, lugar donde nacio el ___, de estado "
        cGenRepFP = cGenRepFP & "civil ___, con domicilio ubicado en ___, con CURP. _____ y con R.F.C. ___."

        cPoderFP = "Mismo que cuenta con facultades suficientes para obligarla en los términos del presente "
        cPoderFP = cPoderFP & "contrato, como se acredita con la Escritura pública número ___, ante la fe del ___, "
        cPoderFP = cPoderFP & "titular de la Notaria Publica número ___, con fecha ___, e inscrita bajo Folio Mercantil Electrónico "
        cPoderFP = cPoderFP & "número ___,en el Registro Público de la Propiedad y de Comercio del ____ de fecha ____, "
        cPoderFP = cPoderFP & "facultades que bajo protesta de decir verdad manifiestan no les han sido modificadas ni renovadas a la "
        cPoderFP = cPoderFP & "fecha de celebración de este acto."

        txtNameFP.Text = ""
        txtNameFP.Visible = True
        txtRepFP.Text = ""
        txtRepFP.ReadOnly = False
        ComboBox1.Enabled = False
        txtGeneRep.Text = cGenRepFP
        txtGeneRep.ReadOnly = False
        txtFacultadesRep.Text = cPoderFP
        txtFacultadesRep.ReadOnly = False

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim strInsert As String
        Dim strUpdate As String

        Dim cAnexo As String
        Dim cCiclo As String

        cAnexo = Mid(txtDatos.Text, 1, 9)
        cCiclo = Mid(txtDatos.Text, 10, 2)

        If txtModo.Text = "I" Then

            With cm2
                .CommandType = CommandType.Text
                .CommandText = "SELECT IDConFP FROM Llaves"
                .Connection = cnAgil
            End With

            cnAgil.Open()

            nConFP = CInt(cm2.ExecuteScalar()) + 1

            strInsert = "INSERT INTO FuentePago_Avio(IDFtepag, NomFtepag, NomRepFtepag, GeneFtepga, FacFtepag)"
            strInsert = strInsert & " VALUES ('" & nConFP & "', '" & txtNameFP.Text & "', '"
            strInsert = strInsert & txtRepFP.Text & "', '"
            strInsert = strInsert & txtGeneRep.Text & "', '"
            strInsert = strInsert & txtFacultadesRep.Text & "')"
            cm1 = New SqlCommand(strInsert, cnAgil)
            cm1.ExecuteNonQuery()

            ' Debe actualizar el atributo IDConFP de la tabla Llaves

            strUpdate = "UPDATE Llaves SET IDConFP = " & nConFP
            cm1 = New SqlCommand(strUpdate, cnAgil)
            cm1.ExecuteNonQuery()

            cnAgil.Close()

        ElseIf txtModo.Text = "A" Then

            cnAgil.Open()

            strUpdate = "UPDATE FuentePago_Avio SET NomFtepag = " & "'" & Trim(txtNameFP.Text) & "',"
            strUpdate = strUpdate & " NomRepFtepag = " & "'" & Trim(txtRepFP.Text) & "',"
            strUpdate = strUpdate & " GeneFtepga = " & "'" & Trim(txtGeneRep.Text) & "',"
            strUpdate = strUpdate & " FacFtepag = " & "'" & Trim(txtFacultadesRep.Text) & "' "
            strUpdate = strUpdate & " WHERE IDFtepag = " & nIdFP
            cm1 = New SqlCommand(strUpdate, cnAgil)
            cm1.ExecuteNonQuery()

            cnAgil.Close()

        End If

        MsgBox("Datos Actualizados correctamente", MsgBoxStyle.Exclamation, "Mensaje")

    End Sub

    Private Sub btnModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModif.Click

        txtNameFP.Text = ComboBox1.Text
        txtNameFP.Visible = True
        txtRepFP.ReadOnly = False
        txtGeneRep.ReadOnly = False
        txtFacultadesRep.ReadOnly = False
        txtModo.Text = "A"
        btnSave.Enabled = True
        ComboBox1.Enabled = False

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged

        ' Declaración de variables de conexión ADO .NET

        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim daFuentep As New SqlDataAdapter(cm1)
        Dim dsAgil As DataSet = New DataSet()
        Dim drFuentep As DataRow

        Dim cIdFP As String

        If Not ComboBox1.SelectedValue Is Nothing And lFirstTime = False Then

            cIdFP = ComboBox1.SelectedValue.ToString
            nIdFP = Val(cIdFP)

            With cm1
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM FuentePago_Avio WHERE IDFtepag = " & nIdFP
                .Connection = cnAgil
            End With

            daFuentep.Fill(dsAgil, "Comprador")
            drFuentep = dsAgil.Tables("Comprador").Rows(0)

            txtNameFP.Text = drFuentep("NomFtepag")
            txtRepFP.Text = drFuentep("NomRepFtepag")
            txtRepFP.ReadOnly = True
            txtGeneRep.Text = drFuentep("GeneFtepga")
            txtGeneRep.ReadOnly = True
            txtFacultadesRep.Text = drFuentep("FacFtepag")
            txtFacultadesRep.ReadOnly = True
            btnSave.Enabled = False

        End If

    End Sub

    Private Sub btnImpConv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpConv.Click
        ' Declaración de variables de conexión ADO .NET
        Dim Cultivos As New GeneralDSTableAdapters.CultivosTableAdapter
        Dim cnAgil As New SqlConnection(strConn)
        Dim cm1 As New SqlCommand()
        Dim cm2 As New SqlCommand()
        Dim cm3 As New SqlCommand()
        Dim daDatos As New SqlDataAdapter(cm1)
        Dim daCiclos As New SqlDataAdapter(cm2)
        Dim dsAgil As New DataSet
        Dim drDato As DataRow
        Dim drCiclo As DataRow
    
        Dim cAnexo As String
        Dim cCiclo As String
        Dim cCliente As String
        Dim cDescr As String
        Dim cGenA1 As String
        Dim cPodA1 As String
        Dim cGenA2 As String
        Dim cPodA2 As String
        Dim cGenA3 As String
        Dim cPodA3 As String
        Dim cGenA4 As String
        Dim cPodA4 As String
        Dim cGeneClie As String
        Dim cImporte As String
        Dim cCantidad As String
        Dim cSemilla As String
        Dim cSucursal As String
        Dim cFechaFirma As String
        Dim cRepresentante As String
        Dim cRepresentante1 As String
        Dim cRepresentante2 As String
        Dim cFirman As String
        Dim cCultivo As String
        Dim cAval1 As String
        Dim cAval2 As String
        Dim cAval3 As String
        Dim cAval4 As String
        Dim cDatosAval As String
        Dim cAvales As String
        Dim cFrep As String
        Dim cHectareas As String
        Dim cFirmaAval1 As String
        Dim cFirmaAval2 As String
        Dim cFirmaAval3 As String
        Dim cFirmaAval4 As String
        Dim cFirmaFinagil As String
        Dim cFechaTermino As String
        Dim cDescCiclo As String
        Dim strUpdate As String
        Dim nHectareas As Decimal
        Dim nImporte As Decimal

        Dim oNulo As Object = System.Reflection.Missing.Value
        Dim oRuta As New Object
        Dim myMField As Microsoft.Office.Interop.Word.Field
        Dim rFieldCode As Microsoft.Office.Interop.Word.Range
        Dim cFieldText As String
        Dim finMerge As Integer
        Dim fieldNameLen As Integer
        Dim cfName As String
        Dim oWord As Word.Application
        Dim oWordDoc As Microsoft.Office.Interop.Word.Document

        cAnexo = Mid(txtDatos.Text, 1, 9)
        cCiclo = Mid(txtDatos.Text, 10, 2)

        ' Debe actualizar el atributo IDFtepag de la tabla Avios

        cnAgil.Open()

        strUpdate = "UPDATE Avios SET IDFtepag = " & nIdFP & "WHERE Anexo = " & cAnexo & "And ciclo = " & cCiclo
        cm3 = New SqlCommand(strUpdate, cnAgil)
        cm3.ExecuteNonQuery()

        With cm1
            .CommandType = CommandType.Text
            .CommandText = "SELECT Avios.*, Clientes.* FROM Avios " & _
                           "INNER JOIN Clientes ON Avios.Cliente = Clientes.Cliente " & _
                           "WHERE Anexo = " & "'" & cAnexo & "'" & " AND Ciclo = " & "'" & cCiclo & "'"
            .Connection = cnAgil
        End With

        ' Llenar el dataset lo cual abre y cierra la conexión

        daDatos.Fill(dsAgil, "Datos")

        drDato = dsAgil.Tables("Datos").Rows(0)
        cCliente = drDato("Cliente")
        cDescr = Trim(drDato("Descr"))
        cGenA1 = Trim(drDato("Generepr"))
        cPodA1 = Trim(drDato("Poderepr"))
        cGenA2 = Trim(drDato("Generep2"))
        cPodA2 = Trim(drDato("Poderep2"))
        cGenA3 = Trim(drDato("Genercoa"))
        cPodA3 = Trim(drDato("Podercoa"))
        cGenA4 = Trim(drDato("GenerObl"))
        cPodA4 = Trim(drDato("PoderObl"))
        cGeneClie = Replace(drDato("GeneClie"), Chr(13) + Chr(10), "")
        nHectareas = drDato("HectareasActual")
        nImporte = drDato("LineaActual")
        cImporte = FormatNumber(nImporte).ToString
        cCantidad = Letras(nImporte)
        cSemilla = drDato("Semilla")
        cSucursal = drDato("Sucursal")

        cFechaFirma = drDato("FechaContrato")
        cFechaTermino = Trim(drDato("FechaTerminacion"))
        cRepresentante1 = Trim(drDato("Nomrepr"))
        cRepresentante2 = Trim(drDato("Nomrepr2"))


        If Trim(cRepresentante1) <> "" Or Trim(cRepresentante2) <> "" Then
            If LTrim(cRepresentante2) <> "" Then
                cRepresentante = " REPRESENTADA EN ESTE ACTO POR " & LTrim(cRepresentante1) & " Y POR " & LTrim(cRepresentante2)
                cFirman = cRepresentante1 & " Y " & cRepresentante2
            Else
                cRepresentante = " REPRESENTADA EN ESTE ACTO POR " & LTrim(cRepresentante1)
                cFirman = cRepresentante1
            End If
        End If

        cCultivo = Cultivos.SacaAliasTXT(cSemilla)

        ' Proceso los nombres de los avales

        cAval1 = Trim(drDato("NomCoac"))
        cAval2 = Trim(drDato("NomObli"))
        cAval3 = Trim(drDato("NomAval1"))
        cAval4 = Trim(drDato("NomAval2"))

        If cAval1 <> "" Then
            If drDato("TipCoac") = "M" Then
                cDatosAval = Chr(10) & "Obligado Solidario y Aval " & cAval1 & " por conducto de su representante declara: " & Chr(10) & drDato("GeneCoac")
                cDatosAval = cDatosAval & Chr(10) & " su representante " & drDato("NomrCoac") & Chr(10) & drDato("Genercoa") & Chr(10) & Chr(10) & drDato("PoderCoa")
            Else
                cDatosAval = Chr(10) & "Obligado Solidario y Aval " & cAval1 & " declara: " & Chr(10) & drDato("GeneCoac")
            End If
        End If
        If cAval2 <> "" Then
            If drDato("TipoObli") = "M" Then
                cDatosAval = cDatosAval & Chr(10) & Chr(10) & "Obligado Solidario y Aval " & cAval2 & " por conducto de su representante declara: " & Chr(10) & drDato("GeneObli")
                cDatosAval = cDatosAval & Chr(10) & " su representante " & drDato("NomrObl") & Chr(10) & drDato("GenerObl") & Chr(10) & Chr(10) & drDato("PoderObl")
            Else
                cDatosAval = cDatosAval & Chr(10) & Chr(10) & "Obligado Solidario y Aval " & cAval2 & " declara: " & Chr(10) & drDato("GeneObli")
            End If
        End If
        If cAval3 <> "" Then
            If drDato("TipAval1") = "M" Then
                cDatosAval = cDatosAval & Chr(10) & Chr(10) & "Obligado Solidario y Aval " & cAval3 & " por conducto de su representante declara: " & drDato("Geneava1")
                cDatosAval = cDatosAval & Chr(10) & " su representante " & drDato("NomrAva1") & Chr(10) & drDato("GenerAv1") & Chr(10) & Chr(10) & drDato("Poderav1")
            Else
                cDatosAval = cDatosAval & Chr(10) & Chr(10) & "Obligado Solidario y Aval " & cAval3 & " declara: " & Chr(10) & drDato("GeneAva1")
            End If
        End If
        If cAval4 <> "" Then
            If drDato("TipAval2") = "M" Then
                cDatosAval = cDatosAval & Chr(10) & Chr(10) & "Obligado Solidario y Aval " & cAval4 & " por conducto de su representante declara: " & drDato("GeneAva2")
                cDatosAval = cDatosAval & Chr(10) & " su representante " & drDato("NomrAva2") & Chr(10) & drDato("GenerAv2") & Chr(10) & Chr(10) & drDato("Poderav2")
            Else
                cDatosAval = cDatosAval & Chr(10) & Chr(10) & "Obligado Solidario y Aval " & cAval4 & " declara: " & Chr(10) & drDato("GeneAva2")
            End If
        End If

        If cSucursal = "05" Then
            cFrep = "ALBINO ROSENDO RAMIREZ AGUILAR"
        ElseIf cSucursal = "04" Or cSucursal = "08" Then
            cFrep = "FRANCISCO KOZO WAKIDA SUZUKI"
        ElseIf cSucursal = "03" Then
            cFrep = "ADOLFO PACHECO MENDEZ"
        End If

        cHectareas = Format(nHectareas, "##,##0.00")


        If cAval1 = "" And cAval2 = "" And cAval3 = "" And cAval4 = "" Then
            cAvales = ""
        ElseIf cAval1 <> "" And cAval2 <> "" And cAval3 <> "" And cAval4 <> "" Then
            cAvales = cAval1 & ", " & cAval2 & ", " & cAval3 & " Y " & cAval4
        ElseIf cAval1 <> "" And cAval2 <> "" And cAval3 <> "" And cAval4 = "" Then
            cAvales = cAval1 & ", " & cAval2 & " Y " & cAval3
        ElseIf cAval1 <> "" And cAval2 <> "" And cAval3 = "" And cAval4 = "" Then
            cAvales = cAval1 & " Y " & cAval2
        ElseIf cAval1 <> "" And cAval2 = "" And cAval3 = "" And cAval4 = "" Then
            cAvales = cAval1
        ElseIf cAval1 <> "" And cAval2 <> "" And cAval3 = "" And cAval4 <> "" Then
            cAvales = cAval1 & ", " & cAval2 & " Y " & cAval4
        ElseIf cAval1 <> "" And cAval2 = "" And cAval3 <> "" And cAval4 <> "" Then
            cAvales = cAval1 & ", " & cAval3 & " Y " & cAval4
        ElseIf cAval1 <> "" And cAval2 = "" And cAval3 <> "" And cAval4 = "" Then
            cAvales = cAval1 & " Y " & cAval3
        ElseIf cAval1 <> "" And cAval2 = "" And cAval3 = "" And cAval4 <> "" Then
            cAvales = cAval1 & " Y " & cAval4
        ElseIf cAval1 = "" And cAval2 <> "" And cAval3 <> "" And cAval4 <> "" Then
            cAvales = cAval2 & ", " & cAval3 & " Y " & cAval4
        ElseIf cAval1 = "" And cAval2 <> "" And cAval3 <> "" And cAval4 = "" Then
            cAvales = cAval2 & " Y " & cAval3
        ElseIf cAval1 = "" And cAval2 <> "" And cAval3 = "" And cAval4 <> "" Then
            cAvales = cAval2 & " Y " & cAval4
        ElseIf cAval1 = "" And cAval2 <> "" And cAval3 = "" And cAval4 = "" Then
            cAvales = cAval2
        ElseIf cAval1 = "" And cAval2 = "" And cAval3 <> "" And cAval4 = "" Then
            cAvales = cAval3
        ElseIf cAval1 = "" And cAval2 = "" And cAval3 <> "" And cAval4 <> "" Then
            cAvales = cAval3 & " Y " & cAval4
        End If

        If cAval1 <> "" Then
            cFirmaAval1 = Chr(34) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(34) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "_________________________________" & Chr(10) & cAval1
        End If
        If cAval2 <> "" Then
            cFirmaAval2 = Chr(10) & Chr(10) & Chr(34) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(34) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "_________________________________" & Chr(10) & cAval2
        End If
        If cAval3 <> "" Then
            cFirmaAval3 = Chr(10) & Chr(10) & Chr(34) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(34) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "_________________________________" & Chr(10) & cAval3
        End If
        If cAval4 <> "" Then
            cFirmaAval4 = Chr(10) & Chr(10) & Chr(34) & "OBLIGADO SOLIDARIO Y AVAL" & Chr(34) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "_________________________________" & Chr(10) & cAval4
        End If
        cFirmaFinagil = Chr(10) & Chr(10) & Chr(34) & "POR FINAGIL" & Chr(34) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "_________________________________" & Chr(10) & "FINAGIL, S.A. DE C.V. SOFOM E.N.R." & Chr(10) & "APODERADO LEGAL"

        With cm2
            .CommandType = CommandType.Text
            .CommandText = "SELECT Ciclos.* FROM Ciclos WHERE Ciclo = " & "'" & cCiclo & "'"
            .Connection = cnAgil
        End With
        daCiclos.Fill(dsAgil, "Ciclos")

        drCiclo = dsAgil.Tables("Ciclos").Rows(0)

        If Mid(drCiclo("DescCiclo"), 1, 4) = "P.V." Then
            cDescCiclo = "Primavera-Verano " & Trim(Mid(drCiclo("DescCiclo"), 6, 4))
        Else
            cDescCiclo = "Otoño-Invierno " & Trim(Mid(drCiclo("DescCiclo"), 6, 9))
        End If

        cm1.Dispose()
        cm2.Dispose()

        oRuta = My.Settings.RootDoc & "Convenio_FP.doc"

        oWord = New Microsoft.Office.Interop.Word.Application()

        oWordDoc = New Microsoft.Office.Interop.Word.Document()

        ' Cargo la plantilla

        oWordDoc = oWord.Documents.Add(oRuta, oNulo, oNulo, oNulo)
        With oWordDoc.Sections(1)
            .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InlineShapes.AddPicture(LOGO_PATH)
            ' .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.InsertAfter(Chr(13) & "No. RECA 0073-136-015052/01-00019-0114  Contrato No. " & Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4))
        End With

        For Each myMField In oWordDoc.Fields

            rFieldCode = myMField.Code

            cFieldText = rFieldCode.Text

            ' Como los Campos de Word Comienzan por el nombre MERGEFIELD, solo tratamos estos campos

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

                    Case "mFrep"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFrep
                    Case "mAvales"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cAvales
                    Case "mFuentepag"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(txtNameFP.Text)
                    Case "mRepFtep"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(txtRepFP.Text)
                    Case "mContrato"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(Mid(cAnexo, 1, 5) & "/" & Mid(cAnexo, 6, 4))
                    Case "mGenRepFP"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(txtGeneRep.Text)
                    Case "mDescr"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Trim(cDescr)
                    Case "mRepresentante"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cRepresentante
                    Case "mPodFP"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = txtFacultadesRep.Text
                    Case "mGeneClie"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cGeneClie
                    Case "mImporte"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cImporte.ToUpper
                    Case "mImporteLetra"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCantidad.ToUpper
                    Case "mHectareas"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cHectareas
                    Case "mFechaFirma"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFechaFirma).ToLower
                    Case "mFirmaA1"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval1
                    Case "mFirmaA2"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval2
                    Case "mFirmaA3"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval3
                    Case "mFirmaA4"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cFirmaAval4
                    Case "mCultivo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCultivo
                    Case "mCultivoCiclo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cCultivo & " " & Trim(Mid(drCiclo("DescCiclo"), 6, 9))
                    Case "mDatosAv"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDatosAval
                    Case "mFechaTer"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = Mes(cFechaTermino).ToLower
                    Case "mDesCiclo"
                        oWord.Selection.GoTo(What:=Word.WdGoToItem.wdGoToField, Name:=cfName)
                        myMField.Result.Text = cDescCiclo
                End Select

                oWord.Selection.Fields.Update()

            End If

        Next

        'Guardo el documento

        oWord.ActiveDocument.Select()

        oWord.ActiveDocument.SaveAs("C:\Contratos\" & Trim(cDescr) & "_CONV.DOC")

        oWord.ActiveDocument.Close()

        OpenFile("C:\Contratos\" & Trim(cDescr) & "_CONV.DOC")

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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class