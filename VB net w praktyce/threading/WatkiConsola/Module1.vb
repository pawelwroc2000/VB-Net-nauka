Imports System.Threading

Module Module1
    Private r As Random = New Random()
    'ReadOnly ileWatkow As Integer = System.Environment.ProcessorCount
    Const ileWatkow As Integer = 10
    Private pi As Double = 0

    Private ewht(ileWatkow - 1) As EventWaitHandle

    Sub Main()
        'uruchamianieObliczenPi()
        Dim czasPoczatkowy As Integer = Environment.TickCount
        'tworzenie wątków
        ThreadPool.SetMaxThreads(30, 100)
        Dim metodaWatku As WaitCallback = New WaitCallback(AddressOf uruchamianieObliczenPi)
        For i As Integer = 0 To ileWatkow - 1
            ewht(i) = New EventWaitHandle(False, EventResetMode.AutoReset)
            ThreadPool.QueueUserWorkItem(metodaWatku, i)
        Next
        'czekanie na zakończenie wątków
        For i As Integer = 0 To ileWatkow - 1 : ewht(i).WaitOne() : Next
        pi /= ileWatkow
        Console.WriteLine("Wszystkie wątki zakończyły działanie." & vbNewLine &
        "Uśrednione Pi={0}, błąd={1}", pi, Math.Abs(Math.PI - pi))
        Dim czasKoncowy As Integer = Environment.TickCount
        Dim roznica As Integer = czasKoncowy - czasPoczatkowy
        Console.WriteLine("Czas obliczeń: " & roznica.ToString())
    End Sub

    Private Function obliczPi(ilośćPrób As Long) As Double
        Dim r As Random = New Random(Module1.r.Next() And DateTime.Now.Millisecond)
        Dim x, y As Double
        Dim ilośćTrafień As Long = 0
        For i As Long = 0 To ilośćPrób - 1
            'synchronizacja na półmetku obliczeń wątku
            'If i = ilośćPrób \ 2 Then
            '    SyncLock Module1.r
            '        Console.WriteLine("Synchronizacja: wątek nr {0} osiągnął półmetek",
            '        Thread.CurrentThread.ManagedThreadId)
            '    End SyncLock
            'End If
            x = r.NextDouble()
            y = r.NextDouble()
            If x * x + y * y < 1 Then ilośćTrafień += 1
        Next
        Return 4.0 * ilośćTrafień / ilośćPrób
    End Function

    Private Sub uruchamianieObliczenPi(parametr As Object)
        Try
            Dim indeks As Integer = CInt(parametr)
            Console.WriteLine("Uruchamianie obliczeń, wątek nr {0}, indeks {1}...",
            Thread.CurrentThread.ManagedThreadId, indeks)
            Dim czasPoczatkowy As Integer = Environment.TickCount
            Dim ilośćPrób As Long = 100000000L \ ileWatkow
            Dim pi As Double = obliczPi(ilośćPrób)
            Module1.pi += pi
            Console.WriteLine("Pi={0}, błąd={1}, wątek nr {2}",
            pi, Math.Abs(Math.PI - pi),
            Thread.CurrentThread.ManagedThreadId)
            ewht(indeks).Set()
            Dim czasKoncowy As Integer = Environment.TickCount
            Dim roznica As Integer = czasKoncowy - czasPoczatkowy
        Catch exc As ThreadAbortException
            Console.WriteLine("Działanie wątku zostało przerwane (" & exc.Message & ")")
        Catch exc As Exception
            Console.WriteLine("Wyjątek (" & exc.Message & ")")
        End Try
    End Sub

End Module
