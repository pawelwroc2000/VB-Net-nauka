Imports System.Windows.Forms

Public Class SystemInfo

    Public Shared Function [Get]() As String
        Dim informacje As String = "Informacje o systemie:" &
        vbNewLine & "Wersja systemu: " & Environment.OSVersion.ToString() &
        vbNewLine & "Wersja Microsoft .NET Framework: " & Environment.Version.ToString() & "Nazwa komputera: " & Environment.MachineName & "Katalog systemowy: " & Environment.SystemDirectory
        Return informacje
    End Function

    Public Shared Sub Show()
        Dim informacje As String = [Get]()
        MessageBox.Show(informacje, "Informacje o platformie .NET")
    End Sub

End Class
