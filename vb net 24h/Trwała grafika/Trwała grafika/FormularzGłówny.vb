'#####################################################################################################################
'oblusga grafiki w formie: ver.1 - BMP z pamieci kopiowana do picturebox na formie bez użycia graphics
'#####################################################################################################################
'Public Class FormularzGłówny
'    ' utworz bitmape w pamieci
'    Dim BMP As New Bitmap(300, 300, Imaging.PixelFormat.Format24bppRgb)

'    ' na ruch myszka nad picturebox ustaw pixele w BMP i przypisz BMP do PictureBox1
'    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
'        Try
'            BMP.SetPixel(MousePosition.X - Me.Location.X - PictureBox1.Location.X - 18, MousePosition.Y - Me.Location.Y - PictureBox1.Location.Y - 30, Color.White)
'        Catch ex As Exception
'        End Try
'        PictureBox1.Image = BMP
'    End Sub

'    Private Sub FormularzGłówny_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub
'End Class

'#####################################################################################################################
'oblusga grafiki w formie: ver.1.1 - BMP z pamieci kopiowana do picturebox na formie bez użycia graphics ale z kanalem alpha
'#####################################################################################################################
Public Class FormularzGłówny
    ' utworz bitmape w pamieci
    Dim main_layer_bmp As New Bitmap(100, 100, Imaging.PixelFormat.Format32bppArgb)
    Dim rain_layer_bmp As New Bitmap(100, 100, Imaging.PixelFormat.Format32bppArgb)
    Dim snow_layer_bmp As New Bitmap(100, 100, Imaging.PixelFormat.Format32bppArgb)
    Dim map_layer_bmp As New Bitmap("polska.jpg")
    Dim flake_layer_bmp As New Bitmap(16, 16, Imaging.PixelFormat.Format32bppArgb)


    Dim BMP As New Bitmap(600, 600, Imaging.PixelFormat.Format32bppArgb)
    Dim BMPS As New Bitmap(600, 600, Imaging.PixelFormat.Format32bppArgb)
    '  Dim BMPJ As New Bitmap("jelly.jpg")
    Dim BMPT As New Bitmap(300, 300, Imaging.PixelFormat.Format32bppArgb)


    Private Sub FormularzGłówny_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim x As Byte
        Dim y As Byte
        Dim kolor As Color

        flake_layer_bmp = CType(Image.FromFile("snow_flake.png"), Bitmap)


        ' displayColor = sourceColor×alpha / 255 + backgroundColor×(255 – alpha) / 255 

        ' Add a 50% transparent red pixel over an opaque white pixel:
        ' sourceColor(127,255,0,0) ( Red, 50% transparent)
        ' background Color(255,255,255,255) (Opaque white)

        ' STEPS:

        ' 1.set back layer with map
        ' map_layer_bmp already set
        snow_PictureBox.Image = map_layer_bmp
        'map_layer_bmp.MakeTransparent()

        ' 2.set up layer with red, a=127
        ' set rain layer bmp in memory
        ' kolor = Color.FromArgb(255, 255, 0, 0)
        ' rain_layer_bmp.MakeTransparent()

        Dim alpha As Byte = 255
        kolor = Color.FromArgb(alpha, 255, 255, 255)
        For x = 0 To 99
            For y = 0 To 99
                rain_layer_bmp.SetPixel(x, y, kolor)
            Next
        Next
        rain_PictureBox.Image = rain_layer_bmp

        ' 3.mix both layer and set main layer
        Dim sourceColor As Color
        Dim backColor As Color
        Dim displayColorRed As Double
        Dim displayColorGreen As Double
        Dim displayColorBlue As Double

        alpha = 127

        For x = 0 To 99
            For y = 0 To 99
                alpha = CByte(x * 2.5)
                backColor = map_layer_bmp.GetPixel(x, y)
                sourceColor = rain_layer_bmp.GetPixel(x, y)

                displayColorRed = (CInt(sourceColor.R) * alpha / 255) + (backColor.R) * (255 - alpha) / 255
                displayColorGreen = (CInt(sourceColor.G) * alpha / 255) + (backColor.G) * (255 - alpha) / 255
                displayColorBlue = (CInt(sourceColor.B) * alpha / 255) + (backColor.B) * (255 - alpha) / 255

                kolor = Color.FromArgb(255, CInt(displayColorRed), CInt(displayColorGreen), CInt(displayColorBlue))

                main_layer_bmp.SetPixel(x, y, kolor)
            Next
        Next


        ' 4.display main layer in picture box
        main_PictureBox.Image = main_layer_bmp

        main_layer_bmp.Save("layers.png", System.Drawing.Imaging.ImageFormat.Png)



        Me.Refresh()



        '' set snow layer in memory
        'kolor = Color.FromArgb(255, 0, 0, 255)
        'For x = 3 To 9
        '    For y = 3 To 9
        '        '  snow_layer_bmp.SetPixel(x, y, kolor)
        '    Next
        'Next

        '' set main layer with map
        'For x = 0 To 50
        '    For y = 0 To 50
        '        main_layer_bmp.SetPixel(x, y, map_layer_bmp.GetPixel(x, y))
        '    Next
        'Next





        ''add rain layers
        'For x = 0 To 30
        '    For y = 0 To 30
        '        kolor = rain_layer_bmp.GetPixel(x, y)
        '        If kolor.A > 0 Then
        '            '   main_layer_bmp.SetPixel(x, y, rain_layer_bmp.GetPixel(x, y))
        '        End If
        '    Next
        'Next

        ''add snow layer
        'For x = 0 To 9
        '    For y = 0 To 9
        '        kolor = snow_layer_bmp.GetPixel(x, y)
        '        If kolor.A > 0 Then
        '            '    main_layer_bmp.SetPixel(x, y, snow_layer_bmp.GetPixel(x, y))
        '        End If
        '    Next
        'Next


        ''add flake layer
        'For x = 0 To 15
        '    For y = 0 To 15
        '        kolor = flake_layer_bmp.GetPixel(x, y)
        '        If kolor.A > 0 Then
        '            '   main_layer_bmp.SetPixel(x + 5, y + 5, flake_layer_bmp.GetPixel(x, y))
        '        End If
        '    Next
        'Next


        'rain_PictureBox.Image = rain_layer_bmp
        'snow_PictureBox.Image = snow_layer_bmp
        'main_PictureBox.Image = main_layer_bmp

        '' PictureBox2.Parent = PictureBox1
        'PictureBox2.BackColor = Color.Transparent

        ''Label1.Parent = PictureBox2
        ''Label1.BackColor = Color.Transparent


        'Me.Show()

        'BMPT.MakeTransparent()
        'Dim colors As Color = Drawing.Color.DeepSkyBlue

        'Dim i, j As UInteger

        'For i = 1 To 255
        '    colors = Color.FromArgb(i, colors.R, colors.G, colors.B)
        '    For j = 0 To 100 Step 5
        '        BMPT.SetPixel(j, i, colors)
        '        BMPT.SetPixel(j + 1, i, colors)

        '    Next
        'Next i
        'PictureBox2.Image = BMPT
        ''BMPT.Save("bitmapaaa.png", Imaging.ImageFormat.Png)

        'BMPS.MakeTransparent(Color.Gray)

        'For i = 0 To 599
        '    '  colors = Color.FromArgb(i / 2, colors.R, colors.G, colors.B)
        '    For j = 0 To 599

        '        Dim clr As Color ' = BMPJ.GetPixel(i, j)
        '        clr = Color.FromArgb(200, clr.R, clr.G, clr.B)
        '        BMP.SetPixel(i, j, clr)

        '        ' BMP.SetPixel(i, j, colors)
        '    Next
        'Next
        '' PictureBox1.Image = BMP


        'For i = 0 To 299
        '    For j = 0 To 299
        '        colors = Color.FromArgb(0, colors.R, colors.G, colors.B)
        '        BMPS.SetPixel(i, j, colors)
        '    Next
        'Next
        'PictureBox2.Image = BMPS



    End Sub

    ' na ruch myszka nad picturebox ustaw pixele w BMP i przypisz BMP do PictureBox1
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

        'Try
        '    Dim alpha As Double = (MousePosition.X - Me.Location.X - PictureBox1.Location.X - 18) / 285
        '    Dim color As Color = Drawing.Color.Black

        '    'c = Color.FromArgb(alpha * 255, c.R, c.G, c.B)
        '    color = color.FromArgb(alpha * 255, color.R, color.G, color.B)

        '    BMPS.SetPixel(MousePosition.X - Me.Location.X - PictureBox1.Location.X - 18, MousePosition.Y - Me.Location.Y - PictureBox1.Location.Y - 30, color)
        'Catch ex As Exception
        'End Try
        'PictureBox2.Image = BMPS
    End Sub

    Private Sub SaveToFileButton_Click(sender As Object, e As EventArgs) Handles SaveToFileButton.Click
        ' BMP.Save("bitmapa.png", Imaging.ImageFormat.Png)
        '  Me.PictureBox2.Image.Save("picturebox.png", Imaging.ImageFormat.Png)


        'Dim graph As Graphics = Nothing
        'Dim frmleft As System.Drawing.Point = Me.Bounds.Location
        'Dim img As New Bitmap(Me.Bounds.Width + 0, Me.Bounds.Height + 0)
        'graph = Graphics.FromImage(img)
        'Dim screenx As Integer = frmleft.X
        'Dim screeny As Integer = frmleft.Y
        'graph.CopyFromScreen(screenx - 0, screeny - 0, 0, 0, img.Size)
        'img.Save("filename.png", System.Drawing.Imaging.ImageFormat.Png)
        SaveForm()
    End Sub

    Private Sub SaveForm()
        Static Dim i As Byte

        Dim graph As Graphics = Nothing
        Dim frmleft As System.Drawing.Point = Me.Bounds.Location
        Dim img As New Bitmap(Me.Bounds.Width + 0, Me.Bounds.Height + 0)
        graph = Graphics.FromImage(img)
        Dim screenx As Integer = frmleft.X
        Dim screeny As Integer = frmleft.Y
        graph.CopyFromScreen(screenx - 0, screeny - 0, 0, 0, img.Size)
        img.Save("form" & i.ToString & ".png", System.Drawing.Imaging.ImageFormat.Png)
        i = CByte(i + 1)
    End Sub


    '    I've actually figured it out :)

    'i'm using this code:

    '    Dim myGraphic As Graphics = Nothing
    '    Dim imgBack As Image, imgFore As Image, newImg As Image
    '        imgBack = pbox.BackgroundImage
    '        imgFore = pbox.Image

    '        newImg = pbox.BackgroundImage

    '        myGraphic = Graphics.FromImage(newImg)
    '        myGraphic.DrawImageUnscaled(imgBack , 0, 0)
    '        myGraphic.DrawImageUnscaled(imgFore , 0, 0)
    '        myGraphic.Save()
    '        newImg.Save("c:\abc.bmp")



    ' http://www.vb-helper.com/howto_net_gradient_alpha_double.html
    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal _
    '    e As System.EventArgs) Handles MyBase.Load
    '    Dim bm_src1 As Bitmap = picSource1.Image.Clone
    '    Dim bm_src2 As Bitmap = picSource2.Image.Clone
    '    Dim bm_out As New Bitmap(bm_src1.Width, bm_src1.Height)
    '    Dim gr As Graphics = Graphics.FromImage(bm_out)

    '    ' Give the images alpha gradients.
    '    Dim alpha As Integer
    '    For x As Integer = 0 To bm_src1.Width - 1
    '        alpha = (255 * x) \ bm_src1.Width
    '        For y As Integer = 0 To bm_src1.Height - 1
    '            Dim clr As Color = bm_src1.GetPixel(x, y)
    '            clr = Color.FromArgb(alpha, clr.R, clr.G, clr.B)
    '            bm_src1.SetPixel(x, y, clr)

    '            clr = bm_src2.GetPixel(x, y)
    '            clr = Color.FromArgb(255 - alpha, clr.R, clr.G, _
    '                clr.B)
    '            bm_src2.SetPixel(x, y, clr)
    '        Next y
    '    Next x

    '    ' Draw the images onto the result.
    '    gr.DrawImage(bm_src1, 0, 0)
    '    gr.DrawImage(bm_src2, 0, 0)

    '    ' Display the result.
    '    picResult.Image = bm_out
    'End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static Dim i As Byte
        If i < 30 Then
            PictureBox2.Left = PictureBox2.Left + 10
            PictureBox2.Top = PictureBox2.Top + 10
            i = CByte(i + 1)
            PictureBox2.Refresh()
            Me.Refresh()
            SaveForm()
        End If
    End Sub
End Class


' #####################################################################################################################
' oblusga grafiki w formie: ver.2 - BMP w pamieci jako zmienna, kopiowana do picturebox na formie z użyciem objektu graphics
' #####################################################################################################################
'Public Class FormularzGłówny
'    ' utworz bitmape w pamieci
'    Dim BMP As New Bitmap(300, 300, Imaging.PixelFormat.Format24bppRgb)
'    'stworz obiekt graphics z BMP w pamieci
'    Dim GFX As Graphics = Graphics.FromImage(BMP)


'    Private Sub FormularzGłówny_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        GFX.Clear(SystemColors.Control)
'    End Sub

'    Private Sub drawButton_Click(sender As Object, e As EventArgs) Handles drawButton.Click
'        GFX.FillRectangle(Brushes.Black, 0, 0, 10, 10)
'    End Sub

'    Private Sub draw2Button_Click(sender As Object, e As EventArgs) Handles draw2Button.Click
'        GFX.FillRectangle(Brushes.Black, 10, 10, 50, 50)
'    End Sub

'    Private Sub LoadBMPtoPictureBox1Button_Click(sender As Object, e As EventArgs) Handles LoadBMPtoPictureBox1Button.Click
'        PictureBox1.Image = BMP
'    End Sub

'    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
'        'BMP.SetPixel(MousePosition.X - Me.Location.X - PictureBox1.Location.X - 4, MousePosition.Y - Me.Location.Y - PictureBox1.Location.Y - 30, Color.White)
'        GFX.DrawString("@#@#@#@#@#@#@#@#@", SystemFonts.DefaultFont, Brushes.Blue, MousePosition.X - Me.Location.X - PictureBox1.Location.X - 18, MousePosition.Y - Me.Location.Y - PictureBox1.Location.Y - 30)
'        PictureBox1.Image = BMP
'    End Sub

'    Private Sub SaveToFileButton_Click(sender As Object, e As EventArgs) Handles SaveToFileButton.Click
'        BMP.Save("bitmapa.bmp", Imaging.ImageFormat.Bmp)
'    End Sub
'End Class



'' #####################################################################################################################
'' oblusga grafiki w formie: ver.3 - malujemy na skojarzonym obiekcie na zadanie lub Paint event , bez BMP w pamieci
'' tworzymy zmienna graphics, nastepnie kojarzymy z danym obiekiem, nastepnie malujemy co chcemy a nastepnie sztucznie
'' trigerujemy Paint event poprzed Me.Invalidate()
'' #####################################################################################################################
'Public Class FormularzGłówny

'    ' stworz wlasny pen
'    Dim pen_one As Pen
'    Dim draw_options As Integer = 0

'    Private Sub FormularzGłówny_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub

'    ' rysuj grafike na zadanie przycisku
'    Private Sub drawButton_Click(sender As Object, e As EventArgs) Handles drawButton.Click
'        'Dim objGrafika As Graphics
'        'objGrafika = Me.CreateGraphics()
'        ''objGrafika = txtRysowanie.CreateGraphics()
'        ''objGrafika = PictureBox1.CreateGraphics()
'        '' stworz wlasny pen
'        ''Dim pen_one As New Pen(Color.Black, 10)
'        'objGrafika.DrawLine(Pens.Blue, 0, 0, 100, 100)

'        pen_one = New Pen(Color.Red, 4)
'        draw_options = 1
'        Me.Invalidate()

'    End Sub

'    ' maluj grafike na Paint event formularza
'    Private Sub FormularzGłówny_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
'        ' malowanie na skojarzonym obiekcie
'        'Dim objGrafika As Graphics
'        'objGrafika = Me.CreateGraphics()
'        'objGrafika = txtRysowanie.CreateGraphics()
'        'objGrafika = PictureBox1.CreateGraphics()

'        ' rysowanie bezposrednio na formie przy pomocy zmiennej e


'        If draw_options = 1 Then
'            'objGrafika.DrawLine(pen_one, 0, 0, 100, 100)
'            e.Graphics.DrawLine(pen_one, 10, 10, 100, 10)
'        End If

'    End Sub
'End Class



' #####################################################################################################################
' oblusga grafiki w formie: ver.4 - BMP z pamieci kopiowana do obszaru rectangle , nie ma uzycia picturebox
' #####################################################################################################################
'Public Class FormularzGłówny

'    ' utworz bitmape w pamieci
'    Dim BMP As New Bitmap(600, 600, Imaging.PixelFormat.Format24bppRgb)
'    'stworz obiekt graphics reprezentujacy utworzona wyzej BMP w pamieci
'    Dim GFX As Graphics = Graphics.FromImage(BMP)

'    Private Sub FormularzGłówny_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' definiujemy prostokat w ktorym bedzie wyswietlana BMP
'        Dim rectProstokąt As New Rectangle(0, 0, 600, 600)
'        GFX.DrawLine(Pens.Black, 0, 0, 50, 50)
'        GFX.DrawRectangle(Pens.Blue, 10, 10, 50, 50)
'        GFX.DrawEllipse(Pens.Orange, rectProstokąt)
'    End Sub

'    Private Sub drawButton_Click(sender As Object, e As EventArgs) Handles drawButton.Click
'        'GFX.FillRectangle(Brushes.Black, 0, 0, 10, 10)
'        Dim objGrafika As Graphics
'        objGrafika = Me.CreateGraphics()
'        'objGrafika = txtRysowanie.CreateGraphics()

'        ' Nie można bezpośrednio modyfikować obiektu e.Graphics.
'        ' objGrafika = e.
'        ' Wyświetl zawartość mapy w formularzu.
'        objGrafika.DrawImage(BMP, 0, 0, BMP.Width, BMP.Height)
'    End Sub

'    Private Sub draw2Button_Click(sender As Object, e As EventArgs) Handles draw2Button.Click
'        GFX.FillRectangle(Brushes.Black, 10, 10, 50, 50)
'    End Sub

'    Private Sub LoadBMPtoPictureBox1Button_Click(sender As Object, e As EventArgs) Handles LoadBMPtoPictureBox1Button.Click
'        PictureBox1.Image = BMP
'    End Sub

'    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
'        'BMP.SetPixel(MousePosition.X - Me.Location.X - PictureBox1.Location.X - 4, MousePosition.Y - Me.Location.Y - PictureBox1.Location.Y - 30, Color.White)
'        GFX.DrawString("XXXXXXXXXX", SystemFonts.DefaultFont, Brushes.Blue, MousePosition.X - Me.Location.X - PictureBox1.Location.X - 18, MousePosition.Y - Me.Location.Y - PictureBox1.Location.Y - 30)
'        PictureBox1.Image = BMP
'    End Sub

'    Private Sub SaveToFileButton_Click(sender As Object, e As EventArgs) Handles SaveToFileButton.Click
'        BMP.Save("bitmapa.bmp", Imaging.ImageFormat.Bmp)
'    End Sub

'    Private Sub FormularzGłówny_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
'        '  Dim objGrafika As Graphics
'        ' Nie można bezpośrednio modyfikować obiektu e.Graphics.
'        '   objGrafika = e.Graphics
'        ' Wyświetl zawartość mapy w formularzu.
'        ' objGrafika.DrawImage(BMP, 0, 0, BMP.Width, BMP.Height)
'    End Sub

'End Class






