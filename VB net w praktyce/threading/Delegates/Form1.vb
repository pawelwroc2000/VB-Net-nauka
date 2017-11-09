Imports System.Collections.Concurrent
Imports System.Threading
Imports System.Threading.Tasks

Public Structure mess
    Dim cmd As UInteger
    Dim data() As Byte
End Structure

Public Class Form1
    ' Construct a ConcurrentQueue 
    Dim cq As New ConcurrentQueue(Of Integer)()
    Dim outerSum As Integer = 0
    Dim wiadomosc As New mess

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim newThread1 As New System.Threading.Thread(AddressOf watek1)
        Dim newThread2 As New System.Threading.Thread(AddressOf watek2)
        Dim newThread3 As New System.Threading.Thread(AddressOf watek3)
        Dim newThread4 As New System.Threading.Thread(AddressOf watek4)
        Dim newThread5 As New System.Threading.Thread(AddressOf watek5)

        ' Populate the queue 
        For i As Integer = 0 To 999
            cq.Enqueue(i)
        Next

        newThread1.Start()
        newThread2.Start()
        newThread3.Start()
        newThread4.Start()
        newThread5.Start()

        '' Peek at the first element 
        'Dim result As Integer
        'If Not cq.TryPeek(result) Then
        '    Console.WriteLine("CQ: TryPeek failed when it should have succeeded")
        'ElseIf result <> 0 Then
        '    Console.WriteLine("CQ: Expected TryPeek result of 0, got {0}", result)
        'End If

        'Dim outerSum As Integer = 0

        '' An action to consume the ConcurrentQueue 
        'Dim action As Action =
        '    Sub()
        '    Dim localSum As Integer = 0
        '    Dim localValue As Integer
        '    While cq.TryDequeue(localValue)
        '        Console.WriteLine("Sciagnieto: {0}", localValue)
        '        localSum += localValue
        '    End While
        '    Interlocked.Add(outerSum, localSum)
        'End Sub

        '' Start 4 concurrent consuming actions
        'Parallel.Invoke(action, action, action, action)

        'Console.WriteLine("outerSum = {0}, should be 49995000", outerSum)

    End Sub

    Private Sub watek1()
        Dim localValue As Integer
        While cq.TryDequeue(localValue)
            Console.WriteLine("Sciagnieto watek1: {0}", localValue)
            ' Thread.Sleep(1)
        End While
    End Sub

    Private Sub watek2()
        Dim localValue As Integer
        While cq.TryDequeue(localValue)
            Console.WriteLine("Sciagnieto watek2: {0}", localValue)
        End While
    End Sub

    Private Sub watek3()
        Dim localValue As Integer
        While cq.TryDequeue(localValue)
            Console.WriteLine("Sciagnieto watek3: {0}", localValue)
        End While
    End Sub

    Private Sub watek4()
        Dim localValue As Integer
        While cq.TryDequeue(localValue)
            Console.WriteLine("Sciagnieto watek4: {0}", localValue)
        End While
    End Sub

    Private Sub watek5()
        Dim localValue As Integer
        While cq.TryDequeue(localValue)
            Console.WriteLine("Sciagnieto watek5: {0}", localValue)
        End While
    End Sub

End Class
