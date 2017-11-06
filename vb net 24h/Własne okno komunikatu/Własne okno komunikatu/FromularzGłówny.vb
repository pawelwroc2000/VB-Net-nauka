Public Class FromularzGłówny

    Private Sub btnWyświetlWłasneOkno_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtWłasnyKomunikat_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub FromularzGłówny_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnWyświetlWłasneOkno_Click_1(sender As Object, e As EventArgs) Handles btnWyświetlWłasneOkno.Click
        If WłasneOknoKomunikatu.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("Kliknąłeś przycisk OK.")
        Else
            MessageBox.Show("Kliknąłeś przycisk Anuluj.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strWynik As String
        Dim intWiek As Integer
        strWynik = InputBox("Podaj swój wiek.", "Podaj wiek")
        If strWynik = "" Then
            MessageBox.Show("Kliknąłeś Anuluj!")
        ElseIf IsNumeric(strWynik) Then
            ' Użytkownik wpisał liczbę, więc można ją zapisać w zmiennej typu liczbowego.
            intWiek = CInt(strWynik)
            MessageBox.Show("Podałeś wiek " & intWiek & " lat.")
        Else
            MessageBox.Show("To nie jest liczba.")
        End If
    End Sub
End Class
