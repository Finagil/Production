Module mConexion

    ' Esta variable es global para toda la aplicación por lo que puede usarse en todos los programas
    ' que requieran esta cadena de conexión

    Public strConn As String

    Public Sub CreaCadenaConexion(ByVal Usuario As String, ByVal Password As String, ByVal BaseDatos As String, Servidor As String)
        strConn = "Server=" & Servidor & "; DataBase=" & BaseDatos & "; User ID=" & Usuario & "; pwd=" & Password
        If UsuarioGlobal.ToUpper = "MCHAVEZ" Then
            strConn = strConn.Replace("SERVER-RAID", "192.168.29.41")
        End If
    End Sub

End Module
