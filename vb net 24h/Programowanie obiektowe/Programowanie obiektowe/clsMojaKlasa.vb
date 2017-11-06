Public Class clsMojaKlasa
    Private m_intWysokość As Integer

    Public Property Wysokość() As Integer
        Get
            Return m_intWysokość
        End Get
        Set(Wartość As Integer)
            If Wartość < 10 Then Exit Property
            m_intWysokość = Wartość
        End Set
    End Property

    Public Function DodajDwieLiczby(intLiczba1 As Integer, intLiczba2 As Integer) As Long
        Return intLiczba1 + intLiczba2
    End Function



    Public Sub WyświetlMaksimum()
        MsgBox("maksimum")
    End Sub

    Public ReadOnly Property WyrzućDoKosza() As Integer
        Get
            Return CInt(1000000)
        End Get
    End Property
End Class
