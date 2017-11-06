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
' oblusga grafiki w formie: ver.2 - BMP z pamieci kopiowana do picturebox na formie z użyciem objektu graphics
' #####################################################################################################################
Public Class FormularzGłówny
    ' utworz bitmape w pamieci
    Dim BMP As New Bitmap(300, 300, Imaging.PixelFormat.Format24bppRgb)
    'stworz obiekt graphics z BMP w pamieci
    Dim GFX As Graphics = Graphics.FromImage(BMP)


    Private Sub FormularzGłówny_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GFX.Clear(SystemColors.Control)
    End Sub

    Private Sub drawButton_Click(sender As Object, e As EventArgs) Handles drawButton.Click
        GFX.FillRectangle(Brushes.Black, 0, 0, 10, 10)
    End Sub

    Private Sub draw2Button_Click(sender As Object, e As EventArgs) Handles draw2Button.Click
        GFX.FillRectangle(Brushes.Black, 10, 10, 50, 50)
    End Sub

    Private Sub LoadBMPtoPictureBox1Button_Click(sender As Object, e As EventArgs) Handles LoadBMPtoPictureBox1Button.Click
        PictureBox1.Image = BMP
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        'BMP.SetPixel(MousePosition.X - Me.Location.X - PictureBox1.Location.X - 4, MousePosition.Y - Me.Location.Y - PictureBox1.Location.Y - 30, Color.White)
        GFX.DrawString("@#@#@#@#@#@#@#@#@", SystemFonts.DefaultFont, Brushes.Blue, MousePosition.X - Me.Location.X - PictureBox1.Location.X - 18, MousePosition.Y - Me.Location.Y - PictureBox1.Location.Y - 30)
        PictureBox1.Image = BMP
    End Sub

    Private Sub SaveToFileButton_Click(sender As Object, e As EventArgs) Handles SaveToFileButton.Click
        BMP.Save("bitmapa.bmp", Imaging.ImageFormat.Bmp)
    End Sub
End Class


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

