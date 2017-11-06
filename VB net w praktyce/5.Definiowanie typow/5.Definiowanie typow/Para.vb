Public Class Para(Of T)
    Private pierwszy As T 'przypisana zostanie domyślna wartość typu T
    Private drugi As T
    Public Sub New(pierwszy As T, drugi As T)
        Me.pierwszy = pierwszy
        Me.drugi = drugi
    End Sub
    Public Overrides Function ToString() As String
        Return pierwszy.ToString() & vbTab & drugi.ToString()
    End Function
End Class

Public Class Para2(Of T As IComparable(Of T), C As IComparable(Of C))
    Implements IComparable(Of Para2(Of T, C))
    Private pierwszy As T 'przypisana zostanie domyślna wartość typu T
    Private drugi As C
    Public Sub New(pierwszy As T, drugi As C)
        Me.pierwszy = pierwszy
        Me.drugi = drugi
    End Sub
    Public Overrides Function ToString() As String
        Return pierwszy.ToString() & vbTab & drugi.ToString()
    End Function
    Public Function CompareTo(innaPara As Para2(Of T, C)) As Integer _
    Implements IComparable(Of Para2(Of T, C)).CompareTo
        Dim wartosc As Integer = pierwszy.CompareTo(innaPara.pierwszy)
        If wartosc <> 0 Then
            Return wartosc
        Else
            Return drugi.CompareTo(innaPara.drugi)
        End If
    End Function
End Class
