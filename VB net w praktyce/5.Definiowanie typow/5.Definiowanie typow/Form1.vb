Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As Random = New Random()
        'Integer
        Dim pi(9) As Para(Of Integer)
        For i As Integer = 0 To pi.Length - 1
            pi(i) = New Para(Of Integer)(r.Next(10), r.Next(10))
        Next
        Dim si As String = "Para(Of Integer)" & vbNewLine
        For Each para As Para(Of Integer) In pi
            si &= para.ToString() & vbNewLine
        Next
        MessageBox.Show(si)

        'Double
        Dim pd(9) As Para(Of Double)
        For i As Integer = 0 To pi.Length - 1
            pd(i) = New Para(Of Double)(r.NextDouble(), r.NextDouble())
        Next
        Dim sd As String = "Para(Of Double)" & vbNewLine
        For Each para As Para(Of Double) In pd
            sd &= para.ToString() & vbNewLine
        Next
        MessageBox.Show(sd)

        'String
        Dim ps(11) As Para(Of String)
        ps(0) = New Para(Of String)("Bester", "Alfred")
        ps(1) = New Para(Of String)("Dick", "Philip")
        ps(2) = New Para(Of String)("Tolkien", "John")
        ps(3) = New Para(Of String)("Lem", "Stanisław")
        ps(4) = New Para(Of String)("Anderson", "Poul")
        ps(5) = New Para(Of String)("Pohl", "Frederik")
        ps(6) = New Para(Of String)("Le Guin", "Ursula")
        ps(7) = New Para(Of String)("Card", "Orson")
        ps(8) = New Para(Of String)("Gibson", "William")
        ps(9) = New Para(Of String)("Asimov", "Isaac")
        ps(10) = New Para(Of String)("Niven", "Larry")
        ps(11) = New Para(Of String)("Herbert", "Frank")
        Dim ss As String = "Para(Of String)" & vbNewLine
        For Each para As Para(Of String) In ps
            ss &= para.ToString() & vbNewLine
        Next
        MessageBox.Show(ss)


        Dim rr As Random = New Random()
        'Integer-Double
        Dim pid(9) As Para2(Of Integer, Double)
        For i As Integer = 0 To pid.Length - 1
            pid(i) = New Para2(Of Integer, Double)(rr.Next(10), rr.NextDouble())
        Next
        Dim sid As String = "ParaIntDouble przed sortowaniem" & vbNewLine
        For Each para As Para2(Of Integer, Double) In pid
            sid &= para.ToString() & vbNewLine
        Next
        MessageBox.Show(sid)
        Array.Sort(pid)
        sid = "ParaIntDouble po sortowaniu" & vbNewLine
        For Each para As Para2(Of Integer, Double) In pid
            sid &= para.ToString() & vbNewLine
        Next
        MessageBox.Show(sid)

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Dim przycisk As Button = New Button()
        przycisk.Width = 100
        przycisk.Height = 30
        przycisk.Left = e.X - przycisk.Width \ 2
        przycisk.Top = e.Y - przycisk.Height \ 2
        przycisk.Text = e.Button.ToString()
        przycisk.Parent = Me
        Me.Text = "Ostatni przycisk: " & przycisk.ToString()
    End Sub
End Class

