Imports System
Imports System.Text
Imports System.Drawing
Imports System.IO.Ports
Imports System.Windows.Forms


Public Class FormularzObiektowy

    Private Sub btnUtwórzObiekt_Click(sender As Object, e As EventArgs) Handles btnUtwórzObiekt.Click
        Dim obj1 As New clsMojaKlasa
        obj1.Wysokość = CInt(100)
        Debug.WriteLine(obj1.Wysokość.ToString())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New clsMojaKlasa
        Debug.WriteLine("Wyrzuc do kosza = " & obj.WyrzućDoKosza.ToString())
    End Sub

    Private Sub FormularzObiektowy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (MessageBox.Show("Czy chcesz wykonać operację XXX?", "Przykładowy komunikat",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
        Windows.Forms.DialogResult.Yes) Then
            ' Kod operacji XXX
            MessageBox.Show("YES")

        End If

    End Sub
End Class
