Imports System.Threading
Public Class Form1
    Dim i As UInteger

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tr As New Threading.Thread(AddressOf tr1)
        tr.Start()
        Dim trr As New Threading.Thread(AddressOf tr2)
        trr.Start()
    End Sub

    Private Sub tr1()
        Do
            i = i + 1

            If Me.TextBox1.InvokeRequired Then
                Me.TextBox1.Invoke(New MethodInvoker(AddressOf TextBoxText))
            Else
                Me.TextBox1.Text = i
            End If
            Thread.Sleep(4000)
        Loop
    End Sub

    Private Sub tr2()
        Do
            If Me.TextBox1.InvokeRequired Then
                Me.TextBox1.Invoke(New MethodInvoker(AddressOf TextBoxText))
            Else
                Me.TextBox1.Text = "99999999"
            End If
            Thread.Sleep(2000)
        Loop
    End Sub

    Private Sub TextBoxText()
        Me.TextBox1.Text = i
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

End Class
