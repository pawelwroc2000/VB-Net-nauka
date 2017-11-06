' wlasne stale preprocesora
#Const web = 1

Imports System
Imports System.Collections


Public Class Form1
    Delegate Sub Uchwyt(tekst As String)
    Event zdarzenie As Uchwyt

    Private Sub ShowMessage(tekst As String)
        MessageBox.Show(tekst, "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub wpisz_tekst(cos As String)    
        TextBox1.Text = cos.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tab(5) As String
        tab(0) = "abc"
        tab(1) = "etc"
        tab(2) = "nhc"
        tab(3) = "oc"
        tab(4) = "bbc"
        tab(5) = "zbc"

        For Each i As String In tab
            Debug.WriteLine(i.ToString())
        Next

        Array.Sort(tab)
        For Each i As String In tab
            Debug.WriteLine(i.ToString())
        Next

        ' wlasne stale preprocesora
#If web Then
        MessageBox.Show("1")
#Else
        MessageBox.Show("0")
#End If

        ' zmienna debugowa
#If DEBUG Then
        MessageBox.Show("debug")
#Else
        MessageBox.Show("Release")
#End If




        ' delegacje i eventy
        'ShowMessage("tekst bez delegacji")
        'Dim UchwytMetody As Uchwyt = AddressOf ShowMessage
        'UchwytMetody("Tekst z delegacji")
        'UchwytMetody = AddressOf wpisz_tekst
        'UchwytMetody("textbox z delegacji")
        '' dodanie zdarzenia i delegacji do metody oraz wywolanie zdarzenia
        'AddHandler zdarzenie, UchwytMetody
        'RaiseEvent zdarzenie("zdarzenie")
    End Sub



    Dim kolejka As Queue(Of String) = New Queue(Of String)(10)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kolejka.Enqueue(TextBox1.Text)
        Debug.WriteLine("Dodano do kolejki: " & TextBox1.Text.ToString())
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = kolejka.Dequeue()
        Debug.WriteLine("Sciagniejto z kolejki: " & TextBox2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str(100) As String
        Try
            Debug.WriteLine("First: " & kolejka.First().ToString())
            Debug.WriteLine("Peek:" & kolejka.Peek.ToString())
            Debug.WriteLine("Count: " & kolejka.Count.ToString())
            Debug.WriteLine("Element z 2 pozycji " & kolejka.ElementAt(2).ToString())
            Debug.WriteLine("Kolejka zawiera ""222"": " & kolejka.Contains("222").ToString())
            kolejka.CopyTo(str, 0)
            Debug.WriteLine("Jednowymiarowy string: " & str.ToString)

        Catch ex As Exception
        End Try
    End Sub


    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged, TrackBar2.ValueChanged, Button3.Click
        Me.BackColor = Color.FromArgb(TrackBar1.Value, TrackBar2.Value, TrackBar3.Value)
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TrackBar1_ValueChanged(Me, Nothing)

    End Sub


End Class
