Option Explicit On 

Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Module mGenCatal
    Dim ta As New ProductionDataSetTableAdapters.ClientesActivosTableAdapter
    Dim daCatalogo As New ContaDSTableAdapters.Catalogo2TableAdapter
    Dim SAT As New ContaDSTableAdapters.AgrupadorSATTableAdapter
    Dim ds As New ContaDS
    Public Sub GenCatal()
        Dim fs As FileStream
        Dim oCatalogo As StreamWriter
        Dim Linea As String

        daCatalogo.Fill(ds.Catalogo2)

        fs = New FileStream("C:\Files\CATALOGO.TXT", FileMode.Create)
        oCatalogo = New StreamWriter(fs, System.Text.Encoding.ASCII)
        oCatalogo.WriteLine("F  1103000000000000               ")

        For Each r As ContaDS.Catalogo2Row In ds.Catalogo2.Rows()
            Linea = r("Id") & r("Acc") & r("AccName") & r("OtherName") & r("AccAditive") & r("AccType") & r("AccStatus") & r("ClaveFinan") _
            & r("AccFlow") & r("StatusDate") & r("AccSource") & r("AccCoin") & r("Agrupador") & r("IdSegNeg") & r("SegNegMovto") _
            & " 0 " & AgrupadorSAT(Mid(r("Acc"), 1, 8), "0" & Mid(r("Acc"), 9, 8), Mid(r("Acc"), 9, 4))
            oCatalogo.WriteLine(Linea)
        Next
        oCatalogo.Close()
        oCatalogo = Nothing
        daCatalogo.UpdateCatalogo()


    End Sub

    Function AgrupadorSAT(ByVal Cuenta As String, ByVal Anexo As String, ByVal Pasivo As String) As String
        Dim EsRela As Integer = ta.EsRelacionado(Anexo)
        Dim r As ContaDS.AgrupadorSATRow

        If Cuenta = "23110190" Then
            SAT.Fill(ds.AgrupadorSAT, Cuenta & Pasivo)
        Else
            SAT.Fill(ds.AgrupadorSAT, Cuenta)
        End If

        If ds.AgrupadorSAT.Rows.Count > 0 Then
            r = ds.AgrupadorSAT.Rows(0)
            If EsRela > 0 Then
                AgrupadorSAT = r.PR
            Else
                AgrupadorSAT = r.NPR
            End If
        Else
            AgrupadorSAT = "000.00"
        End If
        Return AgrupadorSAT
    End Function

    Sub SubeFTP(Archivo As String, Ruta As String, Copia As Boolean)
        Dim wrUpload As FtpWebRequest
        Dim btfile() As Byte
        Dim strFile As Stream
        wrUpload = DirectCast(WebRequest.Create("ftp://192.168.10.230/PolEnt/" & Archivo), FtpWebRequest)
        wrUpload.Proxy = Nothing
        wrUpload.Credentials = New NetworkCredential("sistemas", "sistemas")
        wrUpload.Method = WebRequestMethods.Ftp.UploadFile
        btfile = File.ReadAllBytes(Ruta & Archivo)
        strFile = wrUpload.GetRequestStream()
        strFile.Write(btfile, 0, btfile.Length)
        strFile.Close()
        If Copia = False Then
            File.Delete(Ruta & Archivo)
        End If
    End Sub

    Sub ListaFTP()
        Dim wrDEL As FtpWebRequest
        Dim strFile As StreamReader
        wrDEL = DirectCast(WebRequest.Create("ftp://192.168.10.230/PolEnt/"), FtpWebRequest)
        wrDEL.Proxy = Nothing
        wrDEL.Credentials = New NetworkCredential("sistemas", "sistemas")
        wrDEL.Method = WebRequestMethods.Ftp.ListDirectory
        strFile = New StreamReader(wrDEL.GetResponse().GetResponseStream())
        While Not strFile.EndOfStream
            BorraFTP(strFile.ReadLine)
        End While
        strFile.Close()
    End Sub

    Sub BorraFTP(Archivo As String)
        Dim wrDEL As FtpWebRequest
        wrDEL = DirectCast(WebRequest.Create("ftp://192.168.10.230/PolEnt/" & Archivo), FtpWebRequest)
        wrDEL.Proxy = Nothing
        wrDEL.Credentials = New NetworkCredential("sistemas", "sistemas")
        wrDEL.Method = WebRequestMethods.Ftp.DeleteFile
        wrDEL.GetResponse()
    End Sub

End Module




