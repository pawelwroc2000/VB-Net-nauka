Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim artysci As SortedList(Of String, String) = New SortedList(Of String, String)()
        artysci.Add("Sting", "Gordon Matthew Sumner")
        artysci.Add("Bolesław Prus", "Aleksander Głowacki")
        artysci.Add("Pola Negri", "Barbara Apolonia Chałupiec")
        artysci.Add("John Wayne", "Marion Michael Morrison")
        artysci.Add("Chico", "Leonard Marx")
        artysci.Add("Harpo", "Arthur Marx")
        artysci.Add("Groucho", "Julius Marx")
        artysci.Add("Bono", "Paul Hewson")
        artysci.Add("Ronaldo", "Luiz Nazario de Lima")
        artysci.Add("Madonna", "Madonna Louise Veronica Ciccone")
        artysci.Add("Gabriela Zapolska", "Maria G. Śnieżko-Błocka")
        Dim komunikat As String = "Zawartość listy:" & vbNewLine & vbNewLine
        For Each artysta As KeyValuePair(Of String, String) In artysci
            komunikat &= artysta.Key & " - " & artysta.Value & vbNewLine
        Next
        MessageBox.Show(komunikat)
    End Sub
End Class
