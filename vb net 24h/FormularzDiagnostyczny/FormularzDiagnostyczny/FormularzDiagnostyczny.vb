Public Class FormularzDiagnostyczny

    Private Sub btnWykonajDzielenie_Click(sender As Object, e As EventArgs) Handles btnWykonajDzielenie.Click
        ' Ta procedura dzieli liczbę 100 przez liczbę wpisaną przez użytkownika w polu txtDane.
        Dim sngOdpowiedź As Single

        sngOdpowiedź = (100 / CLng(txtDane.Text))
        MessageBox.Show("100/" & txtDane.Text & " is " & sngOdpowiedź)


    End Sub
End Class
