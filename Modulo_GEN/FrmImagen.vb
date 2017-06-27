Public Class FrmImagen
    Public Titulo As String
    Public Ruta() As String
    Public Impresion As Boolean = False
    Dim Pos As Integer = 0
    Private _scale As Single = 1
    Dim original As Image = Nothing 'original image used for zoom feature


    Private Sub FrmImagen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Titulo
        Carga_Imagen(True)
        If Ruta.Length = 1 Then
            Button2.Enabled = False
            Button3.Enabled = False
        End If
        BtnImpresion.Enabled = Impresion
        BtnImpresion.Enabled = True 'TODOS PUEDEN IMPRIMIR VERONICA GOMEZ
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        Panel1.AutoScrollMinSize = PictureBox1.Image.Size 'Asignamos a las barras de desplazamiento del panel el tamaño de la imagen
        Panel1.AutoScroll = True 'Ponemos a True esta opción para que se muestren las barras de desplazamiento
        PictureBox1.Refresh()
    End Sub

    Private Sub Anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Pos - 1 >= 0 Then
            Pos = Pos - 1
            Carga_Imagen()
            If Pos = 0 Then
                Button2.Enabled = False
                Button3.Enabled = True
            Else
                Button2.Enabled = True
                Button3.Enabled = True
            End If
        End If
    End Sub

    Private Sub Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Todas As Integer = Ruta.Length - 1
        If Pos + 1 <= Todas Then
            Pos = Pos + 1
            Carga_Imagen()
            If Pos = Todas Then
                Button2.Enabled = True
                Button3.Enabled = False
            Else
                Button2.Enabled = True
                Button3.Enabled = True

            End If
        End If
    End Sub

    Public Sub ZoomImage(ByRef ZoomValue As Int32)
        'Check to see if there is a valid image
        If original Is Nothing Then
            Exit Sub
        End If
        'Create a new image based on the zoom parameters we require
        Dim zoomImage As New Bitmap(original, _
            (Convert.ToInt32(original.Width * (ZoomValue) / 100)), _
            (Convert.ToInt32(original.Height * (ZoomValue / 100))))

        'Create a new graphics object based on the new image
        Dim converted As Graphics = Graphics.FromImage(zoomImage)

        'Clean up the image
        converted.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic

        'Clear out the original image
        PictureBox1.Image = Nothing

        'Display the new "zoomed" image
        PictureBox1.Image = zoomImage

    End Sub

    Sub Carga_Imagen(Optional ByVal Carga As Boolean = False)
        If InStr(Ruta(Pos), ".tif") Then
            If Pos = 0 And Carga = True Then
                original = Image.FromFile(Ruta(Pos))
            End If
            original.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Page, Pos)
        Else
            original = Image.FromFile(Ruta(Pos))
        End If
        'original = Image.FromFile(Ruta(Pos))
        _scale = Panel1.Size.Width / original.Size.Width
        Label1.Text = Pos + 1 & " de " & Ruta.Length
        ZoomImage(CInt(_scale * 100) - 2)
        Panel1.AutoScrollMinSize = PictureBox1.Image.Size 'Asignamos a las barras de desplazamiento del panel el tamaño de la imagen
        Panel1.AutoScroll = True 'Ponemos a True esta opción para que se muestren las barras de desplazamiento
        PictureBox1.Refresh()
    End Sub



    Private Sub BtnImpresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImpresion.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(PictureBox1.Image, 1, 1, 850, 1300) 'PB1 ES EL NOMBRE DEL PICTUREBOX
    End Sub

End Class