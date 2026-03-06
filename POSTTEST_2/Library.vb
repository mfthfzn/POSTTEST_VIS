Module Library
    Public daftarBuku(49, 1) As String
    Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(ByVal judulBuku As String, ByVal genreBuku As String)
        If jumlahBuku < 50 Then
            daftarBuku(jumlahBuku, 0) = judulBuku
            daftarBuku(jumlahBuku, 1) = genreBuku
            jumlahBuku = jumlahBuku + 1
        End If
    End Sub

    Public Function HapusBuku(ByRef judulBuku As String) As Boolean
        Dim index As Integer = -1
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judulBuku.ToLower() Then
                index = i
                Exit For
            End If
        Next

        If index <> -1 Then
            For j As Integer = index To jumlahBuku - 2
                daftarBuku(j, 0) = daftarBuku(j + 1, 0)
                daftarBuku(j, 1) = daftarBuku(j + 1, 1)
            Next
            jumlahBuku = jumlahBuku - 1
            daftarBuku(jumlahBuku, 0) = Nothing
            daftarBuku(jumlahBuku, 1) = Nothing
            Return True
        End If
        Return False
    End Function

End Module
