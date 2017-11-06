Public Class RodzicMDI



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Potomek1.MdiParent = Me
        Potomek1.Show()
    End Sub

End Class
