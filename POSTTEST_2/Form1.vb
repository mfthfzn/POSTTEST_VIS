Public Class Form1
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        If txtJudulBuku.Text = "" Or txtGenreBuku.Text = "" Then
            MessageBox.Show("Judul dan genre buku harus diisi")
            Return
        End If

        Library.TambahBuku(txtJudulBuku.Text, txtGenreBuku.Text)
        MessageBox.Show("Buku berhasil ditambahkan")
        tampilkanBuku()
        txtJudulBuku.Clear()
        txtGenreBuku.Clear()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click

        If txtHapusBuku.Text = "" Then
            MessageBox.Show("Judul buku harus diisi")
            Return
        End If

        Dim judulBuku = txtHapusBuku.Text
        Dim result As Boolean = Library.HapusBuku(judulBuku)
        If result Then
            MessageBox.Show("Buku berhasil dihapus")
        Else
            MessageBox.Show("Judul buku '" & judulBuku & "' tidak ditemukan!")
        End If
        tampilkanBuku()
        txtHapusBuku.Clear()
    End Sub

    Private Sub tampilkanBuku()
        dgvHasil.Rows.Clear()
        For i As Integer = 0 To Library.jumlahBuku - 1
            dgvHasil.Rows.Add(Library.daftarBuku(i, 0), Library.daftarBuku(i, 1))
        Next
    End Sub
End Class
