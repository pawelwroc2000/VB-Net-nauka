Module Module1

    'Informacje o bieżącym użytkowniku
    Dim użytkownik As String = "Informacje o bieżącym użytkowniku:" _
    & vbNewLine & "Nazwa użytkownika: " & Environment.UserName _
    & vbNewLine & "Katalogi specjalne użytkownika:" _
    & vbNewLine & "katalog 'Moje dokumenty' = " &
    Environment.GetFolderPath(Environment.SpecialFolder.Personal) _
    & vbNewLine & "katalog 'Pulpit' = " &
    Environment.GetFolderPath(Environment.SpecialFolder.Desktop) _
    & vbNewLine & "katalog 'Moje obrazy' = " &
    Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) _
    & vbNewLine & "katalog menu Start = " &
    Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) _
    & vbNewLine & "katalog 'Programy' = " &
    Environment.GetFolderPath(Environment.SpecialFolder.Programs) _
    & vbNewLine & "katalog 'Autostart' = " &
    Environment.GetFolderPath(Environment.SpecialFolder.Startup)



    'Informacje o systemie
    Dim system As String = "Informacje o systemie:" _
    & vbNewLine & "Wersja systemu: " & Environment.OSVersion.ToString() _
    & vbNewLine & "Wersja Microsoft .NET Framework: " &
    Environment.Version.ToString() _
    & vbNewLine & "Nazwa komputera: " & Environment.MachineName.ToString() _
    & vbNewLine & "Katalog systemowy: " &
    Environment.SystemDirectory.ToString()
    Sub Main()
        Console.WriteLine("SystemInfo" & vbNewLine & "----------" & vbNewLine)
        Console.WriteLine(system & vbNewLine)
        Console.WriteLine(użytkownik & vbNewLine)
    End Sub


    'prog1
    'Sub Main(args As String())
    '    Console.WriteLine("Jak Ci na imię?")
    '    Console.Write("Napisz tutaj swoje imię: ")
    '    Dim imie As String = Console.ReadLine()
    '    If imie.Length = 0 Then
    '        Console.Error.WriteLine(vbNewLine & vbNewLine & vbTab & "*** Błąd: nie podano imienia!" & vbNewLine & vbNewLine)
    '        Return
    '    End If
    '    Dim niewiasta As Boolean = (imie.ToLower()(imie.Length - 1) = "a")
    '    If imie = "Kuba" OrElse imie = "Barnaba" Then niewiasta = False
    '    Console.WriteLine("Niech zgadnę, jesteś " & If(niewiasta, "dziewczyną", "chłopakiem") & "!")
    '    Console.WriteLine("Naciśnij jakikolwiek klawisz...")
    '    System.Windows.Forms.MessageBox.Show("Witaj Świecie!")
    '    Console.Read()
    'End Sub

End Module
