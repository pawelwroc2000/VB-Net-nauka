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
    Dim BMP As New Bitmap(300, 300, Imaging.PixelFormat.Format32bppArgb)
    Dim BMPS As New Bitmap(300, 300, Imaging.PixelFormat.Format32bppArgb)

    Private Sub FormularzGłówny_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colors As Color = Drawing.Color.Yellow
        colors = Color.FromArgb(255, colors.R, colors.G, colors.B)

        For i = 0 To 299
            colors = Color.FromArgb(i / 2, colors.R, colors.G, colors.B)
            For j = 0 To 299
                BMP.SetPixel(i, j, colors)
            Next
        Next
        PictureBox1.Image = BMP
    End Sub

    ' na ruch myszka nad picturebox ustaw pixele w BMP i przypisz BMP do PictureBox1
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

        Try
            Dim alpha As Double = (MousePosition.X - Me.Location.X - PictureBox1.Location.X - 18) / 285
            Dim color As Color = Drawing.Color.White

            'c = Color.FromArgb(alpha * 255, c.R, c.G, c.B)
            color = color.FromArgb((MousePosition.X - Me.Location.X - PictureBox1.Location.X - 18), color.R, color.G, color.B)

            BMP.SetPixel(MousePosition.X - Me.Location.X - PictureBox1.Location.X - 18, MousePosition.Y - Me.Location.Y - PictureBox1.Location.Y - 30, color)
        Catch ex As Exception
        End Try
        PictureBox1.Image = BMP
    End Sub

    Private Sub SaveToFileButton_Click(sender As Object, e As EventArgs) Handles SaveToFileButton.Click
        ' BMP.Save("bitmapa.png", Imaging.ImageFormat.Png)
        Me.PictureBox1.Image.Save("picturebox.png", Imaging.ImageFormat.Png)
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






