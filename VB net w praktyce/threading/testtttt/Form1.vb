Imports System.Threading
Public Class Form1


    Dim i As UInteger

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim tr As New Threading.Thread(AddressOf tr1)
        'tr.Start()
        'Dim trr As New Threading.Thread(AddressOf tr2)
        'trr.Start()

        Dim ts As ParameterizedThreadStart = New ParameterizedThreadStart(AddressOf tr3)
        Dim partr As Thread
        partr = New Thread(ts)
        partr.Start("witaj")

    End Sub


    Private Sub tr3(parametr As Object)
        Do
            If Me.TextBox1.InvokeRequired Then
                '  Me.TextBox1.Invoke(New MethodInvoker(AddressOf TextBoxText))
            Else
                Me.TextBox1.Text = parametr
            End If
            Thread.Sleep(400)
        Loop
    End Sub

    'Private Sub tr1()
    '    Do
    '        i = i + 1

    '        If Me.TextBox1.InvokeRequired Then
    '            Me.TextBox1.Invoke(New MethodInvoker(AddressOf TextBoxText))
    '        Else
    '            Me.TextBox1.Text = i
    '        End If
    '        Thread.Sleep(4000)
    '    Loop
    'End Sub

    'Private Sub tr2()
    '    Do
    '        If Me.TextBox1.InvokeRequired Then
    '            Me.TextBox1.Invoke(New MethodInvoker(AddressOf TextBoxText))
    '        Else
    '            Me.TextBox1.Text = "99999999"
    '        End If
    '        Thread.Sleep(2000)
    '    Loop
    'End Sub

    Private Sub TextBoxText(tekst As String)
        Me.TextBox1.Text = tekst
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TextBox1.Text = 999
    End Sub


    Private Sub ResetTextBoxText()
        If Me.TextBox1.InvokeRequired Then

        Else
            Me.TextBox1.ResetText()
        End If
    End Sub


    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim akcja As Func(Of Object, Long) = Function(argument As Object)
                                                 MessageBox.Show("Zatrzymujemy działanie akcji - " &
                                                 argument.ToString())
                                                 Return DateTime.Now.Ticks
                                             End Function
        'akcja wykonywana asynchronicznie - async/await
        Dim zadanie3 As Task(Of Long) = New Task(Of Long)(akcja, "Async/Await")
        zadanie3.Start()
        MessageBox.Show("Akcja została uruchomiona")
        Dim wynik3 As Long = Await zadanie3
        MessageBox.Show("Await: " & wynik3.ToString())
    End Sub
End Class
