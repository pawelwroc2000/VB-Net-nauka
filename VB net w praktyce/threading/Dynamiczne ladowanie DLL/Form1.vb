Imports System.IO
Imports System.Reflection

Public Class Form1
    Private nazwaPlikuDLL As String = System.IO.Path.Combine(System.Environment.CurrentDirectory, "SystemInfo.dll")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Not System.IO.File.Exists(nazwaPlikuDLL) Then
                Throw New Exception("Brak pliku biblioteki DLL")
            End If
            Dim a As Assembly = Assembly.LoadFrom(nazwaPlikuDLL)
            MessageBox.Show("Wczytano podzespół:" & vbNewLine & a.FullName & vbNewLine & "z pliku " & a.Location)
        Catch exc As Exception
            MessageBox.Show("Wczytanie podzespołu z pliku " & nazwaPlikuDLL & " nie powiodło się (" & exc.Message & ").")
            Return
        End Try
    End Sub
End Class
