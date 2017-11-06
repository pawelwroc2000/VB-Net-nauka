Public Class Potomek1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Potomek2.MdiParent = Me.MdiParent
        Potomek2.Show()
    End Sub
End Class