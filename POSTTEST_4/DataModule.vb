Imports System.IO
Imports System.Text

Module DataModule

    Public Function BuatRingkasan(
        nama As String,
        id As String,
        komunitas As String,
        telepon As String,
        email As String,
        alamat As String,
        hobi As String
    ) As String

        Return "Nama            : " & nama & Environment.NewLine &
               "ID Anggota      : " & id & Environment.NewLine &
               "Komunitas       : " & komunitas & Environment.NewLine &
               "Telepon         : " & telepon & Environment.NewLine &
               "Email           : " & email & Environment.NewLine &
               "Alamat          : " & alamat & Environment.NewLine &
               "Hobi/Aktivitas  : " & hobi.Replace(vbCrLf, ", ")
    End Function
    Public Function BuatIsiFile(
        nama As String,
        id As String,
        komunitas As String,
        telepon As String,
        email As String,
        alamat As String,
        hobi As String
    ) As String

        Dim sb As New StringBuilder()

        sb.AppendLine("Nama=" & nama.Trim())
        sb.AppendLine("ID=" & id.Trim())
        sb.AppendLine("Komunitas=" & komunitas.Trim())
        sb.AppendLine("Telepon=" & telepon.Trim())
        sb.AppendLine("Email=" & email.Trim())

        Dim hobiSatuBaris As String = hobi.Replace(vbCrLf, ", ").Replace("- ", "").Trim(New Char() {","c, " "c})
        sb.AppendLine("Hobi=" & hobiSatuBaris)

        sb.Append("Alamat=" & alamat.Trim())

        Return sb.ToString()
    End Function

    Public Function SimpanDataKeFile(
        sfd As SaveFileDialog,
        isi As String,
        namaFileDefault As String
    ) As Boolean

        sfd.Filter = "Text File|*.txt|CSV File|*.csv"
        sfd.Title = "Simpan Data Komunitas"
        sfd.FileName = namaFileDefault

        If sfd.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sfd.FileName, isi)
            Return True
        End If

        Return False
    End Function

    Public Function BukaDataDariFile(ofd As OpenFileDialog) As Dictionary(Of String, String)
        ofd.Filter = "Text File|*.txt|CSV File|*.csv"
        ofd.Title = "Buka Data Komunitas"

        If ofd.ShowDialog() <> DialogResult.OK Then
            Return Nothing
        End If

        Dim hasil As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        Dim barisFile() As String = File.ReadAllLines(ofd.FileName)

        For Each baris As String In barisFile
            If String.IsNullOrWhiteSpace(baris) Then Continue For

            ' Pisahkan teks berdasarkan tanda sama dengan "="
            Dim bagian() As String = baris.Split(New Char() {"="c}, 2)

            If bagian.Length = 2 Then
                hasil(bagian(0).Trim()) = bagian(1).Trim()
            End If
        Next

        Return hasil
    End Function

    Public Function AmbilNilai(data As Dictionary(Of String, String), key As String) As String
        If data IsNot Nothing AndAlso data.ContainsKey(key) Then
            Return data(key)
        End If

        Return ""
    End Function

End Module