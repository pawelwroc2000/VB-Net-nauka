Public Class FormularzKlawiatury

    Private Sub txtDane_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDane.KeyPress
        If Not (IsNumeric(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

End Class
