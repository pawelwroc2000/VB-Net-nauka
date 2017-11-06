Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim u2 As Ulamek = New Ulamek(2, 1)
        Dim u0 As Ulamek = Ulamek.Zero
        Dim uP As Ulamek = Ulamek.Polowa
        MessageBox.Show(uP.ToString())
        MessageBox.Show(uP.ToDouble())
        MessageBox.Show(Ulamek.Info())

        Dim u As Ulamek = New Ulamek(4, -2)
        'u.Uprosc()
        u.Mianownik = 1
        MessageBox.Show(u.ToDouble())


        Dim tablica(10) As Ulamek
        For i As Integer = 0 To tablica.Length - 1
            tablica(i) = New Ulamek(1, i + 1)
        Next
    End Sub
End Class
