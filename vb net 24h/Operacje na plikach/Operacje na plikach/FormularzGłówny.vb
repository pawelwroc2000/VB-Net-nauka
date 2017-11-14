Public Class FormularzGłówny


    ' AKTUALNY FOLDER APLIKACJI
    'System.AppDomain.CurrentDomain.BaseDirectory()

    Private Sub btnOtwórzPlik_Click(sender As Object, e As EventArgs) Handles btnOtwórzPlik.Click
        With OpenFileDialog1
            .InitialDirectory = "C:\"
            .Title = "Wybierz plik"
            .FileName = ""
            .FilterIndex = 1
            If .ShowDialog() <> DialogResult.Cancel Then
                txtPlikŹródłowy.Text = OpenFileDialog1.FileName
            Else
                txtPlikŹródłowy.Text = ""
            End If
        End With



        Dim objPlik As New System.IO.StreamReader(OpenFileDialog1.FileName)
        Dim strZawartośćPliku As String
        ' czytaj do konca pliku
        'strZawartośćPliku = objPlik.ReadToEnd()


        ' czytaj do konca kazdej linii z osobna
        Dim strPojedynczaLinia As String
        strPojedynczaLinia = objPlik.ReadLine()



        Do Until strPojedynczaLinia Is Nothing
            MessageBox.Show(strPojedynczaLinia)

            strPojedynczaLinia = objPlik.ReadLine()
        Loop

        objPlik.Close()
        'MessageBox.Show(strZawartośćPliku)
        MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory.ToString())
    End Sub

    Private Sub FormularzGłówny_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Plik As New System.IO.StreamReader("d:\w14.txt")
        Dim strPojedynczaLinia As String
        Dim wartosci() As String
        Dim pix_x As UInteger
        Dim val As Byte

        strPojedynczaLinia = Plik.ReadLine()

        Do Until strPojedynczaLinia Is Nothing
            wartosci = strPojedynczaLinia.Split(";")

                Byte.TryParse(wartosci(0), pix_x)
            UInteger.TryParse(wartosci(1), val)


            MessageBox.Show(pix_x.ToString)
            MessageBox.Show(val.ToString)

            strPojedynczaLinia = Plik.ReadLine()
        Loop

        Plik.Close()

    End Sub

    Private Sub btnZapiszPlik_Click(sender As Object, e As EventArgs) Handles btnZapiszPlik.Click
        'With SaveFileDialog1
        '    .Title = "Podaj nazwę pliku docelowego"
        '    .Filter = "Pliki tekstowe (*.txt)|*.txt"
        '    .FilterIndex = 1
        '    .OverwritePrompt = True
        '    .CreatePrompt = True
        '    If .ShowDialog() <> DialogResult.Cancel Then
        '        txtPlikDocelowy.Text = .FileName
        '    End If,
        'End With

        ' utworzenie i zapisanie do pliku, 
        ' drugi paramter - True - dopisywanie do istniejacego pliku jezeli takowy istnieje
        ' False - zastapienie nowym plikiem (stare dane zostana utracone)
        Dim objPlik As New System.IO.StreamWriter("D:\test.txt", True)
        With objPlik
            .WriteLine(DateAndTime.Now.ToString())
            .Close()
            .Dispose()
        End With

    End Sub

    Private Function CzyPlikIstnieje() As Boolean
        If Not (System.IO.File.Exists(txtPlikŹródłowy.Text)) Then
            MessageBox.Show("Wskazany plik nie istnieje!")
            Return False
        Else
            Return True
        End If
    End Function

End Class
