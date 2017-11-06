Public Structure Ulamek
    Private _licznik, _mianownik As Integer

    Public Sub New(ByVal Licznik As Integer, Optional ByVal Mianownik As Integer = 1)
        If Mianownik = 0 Then Throw New Exception("Mianownik musi być różny od zera")
        Me._licznik = Licznik
        Me._mianownik = Mianownik
    End Sub

    Public Shared Zero As Ulamek = New Ulamek(0)
    Public Shared Jeden As Ulamek = New Ulamek(1)
    Public Shared Polowa As Ulamek = New Ulamek(1, 2)
    Public Shared Cwierc As Ulamek = New Ulamek(1, 4)

    Public Shared Function Info() As String
        Return "Struktura Ulamek, (c) Jacek Matulewski 2010"
    End Function

    Public Overrides Function ToString() As String
        Return _licznik.ToString() & "/" & _mianownik.ToString()
    End Function

    Public Function ToDouble() As Double
        Return _licznik / _mianownik
    End Function

    Public Sub Uprosc()
        'NWD
        Dim mniejsza As Integer = Math.Min(Math.Abs(_licznik), Math.Abs(_mianownik))
        For i As Integer = mniejsza To 1 Step -1
            If (_licznik Mod i = 0) AndAlso (_mianownik Mod i = 0) Then
                _licznik \= i
                _mianownik \= i
            End If
        Next
        'znaki
        If _licznik * _mianownik < 0 Then
            _licznik = -Math.Abs(_licznik)
            _mianownik = Math.Abs(_mianownik)
        Else
            _licznik = Math.Abs(_licznik)
            _mianownik = Math.Abs(_mianownik)
        End If
    End Sub


#Region "Wlasnosci"
    Public Property Licznik As Integer
        Get 'odczyt
            Return _licznik
        End Get
        Set(value As Integer) 'zapis
            _licznik = value
        End Set
    End Property
    Public Property Mianownik As Integer
        Get 'odczyt
            Return _mianownik
        End Get
        Set(value As Integer) 'zapis
            If value = 0 Then Throw New Exception("Mianownik musi być różny od zera")
            _mianownik = value
        End Set
    End Property
#End Region

End Structure

