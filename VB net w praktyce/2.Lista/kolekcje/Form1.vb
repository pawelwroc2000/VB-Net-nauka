Imports System
Imports System.Collections


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rozmiar As Integer = 30
        Dim r As Random = New Random()
        Dim ti(rozmiar - 1) As Integer
        'utworz liste o ti elementach
        Dim a As List(Of Integer) = New List(Of Integer)(ti)
        'zainicjuj losowymi danymi
        For i As Integer = 0 To a.Count - 1
            a(i) = r.Next(50)
        Next
        'zmien rozmiar tablicy do 10 elementow o wartosci 0 kazdy (inicjalizacja)
        ReDim ti(9)
        ' dodaj taka tablice do konca listy
        a.AddRange(ti)
        'utworz tablice pieciu -1
        Dim i5() As Integer = {-1, -1, -1, -1, -1}
        'wstaw tablice w polowie listy
        a.InsertRange(rozmiar \ 2, i5)
        'na pierwszej pozycji wstaw 1
        a.Insert(0, 1)
        'usun elementy wieksze od 20
        Dim j As Integer = 0
        Do
            If a(j) > 20 Then
                a.RemoveAt(j)
            Else
                j = j + 1
            End If
        Loop While j < a.Count
        'sortuj liste
        a.Sort()

    End Sub
End Class
