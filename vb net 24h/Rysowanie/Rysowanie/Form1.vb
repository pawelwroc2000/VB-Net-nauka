Public Class FormularzGłówny

    Private m_objGrafika As Graphics

    Private Sub FormularzGłówny_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        m_objGrafika.Dispose()
    End Sub

    Private Sub FormularzGłówny_Load(sender As Object, e As EventArgs) Handles MyBase.Load    
        m_objGrafika = Me.CreateGraphics

    End Sub

    Private Sub FormularzGłówny_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        m_objGrafika.Clear(BackColor)
    End Sub

    Private Sub FormularzGłówny_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim rectElipsa As Rectangle
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        With rectElipsa
            .X = e.X - 1
            .Y = e.Y - 1
            .Width = 5
            .Height = 5
        End With
        m_objGrafika.DrawEllipse(System.Drawing.Pens.Blue, rectElipsa)
    End Sub
End Class
