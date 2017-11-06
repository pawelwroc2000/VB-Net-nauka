Public Class FormularzObsługiBłędów

    Private Sub btnPrzechwyćWyjątek_Click(sender As Object, e As EventArgs) Handles btnPrzechwyćWyjątek.Click
        Dim lngLicznik As Long = 10
        Dim lngMianownik As Long = 0
        Dim lngWynik As Long
        Try
            Debug.WriteLine("Try")
            lngWynik = lngLicznik / lngMianownik
        Catch ex As Exception
            Debug.WriteLine("Catch")
            MessageBox.Show("Wystąpił błąd: " & ex.Message)
        Finally
            Debug.WriteLine("Finally")
        End Try
        Debug.WriteLine("Koniec obsługi")
    End Sub
End Class
