Public Class Form_Size

    Private Sub kosong()
        txtIdUkuran.Clear()
        txtUkuran.Clear()
        ErrorProvider1.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        kosong()
        txtIdUkuran.Focus()
    End Sub

    Private Sub TampilData()
        dgvUkuran.DataSource = GetAllUkuran()
    End Sub

    Private Sub Form_Size_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kosong()
        TampilData()
    End Sub

    Private Sub Form_Size_Active(sender As Object, e As EventArgs) Handles MyBase.Activated
        kosong()
        TampilData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiDataUkuran(ErrorProvider1, txtIdUkuran, txtUkuran) Then Exit Sub

        Dim idUkuran As String = txtIdUkuran.Text.Trim()
        Dim ukuran As String = txtUkuran.Text.Trim()

        If DataSudahAdaUkuran(idUkuran, ukuran) Then
            MessageBox.Show("Id ukuran atau ukuran sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIdUkuran.Focus()
            Exit Sub
        End If

        If SimpanUkuran(idUkuran, ukuran) Then
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()

        If Not ValidasiDataUkuran(ErrorProvider1, txtIdUkuran, txtUkuran) Then Exit Sub

        Dim idUkuran As String = txtIdUkuran.Text.Trim()
        Dim ukuran As String = txtUkuran.Text.Trim()

        If UbahUkuran(idUkuran, ukuran) Then
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            kosong()
        Else
            MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim idUkuran As String = txtIdUkuran.Text.Trim()

        If idUkuran = "" Then
            MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIdUkuran.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusUkuran(idUkuran) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                kosong()
            Else
                MessageBox.Show("Gagal menghapus! Pastikan id benar atau pastikan data tidak digunakan di tabel pakaian", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub dgvPakaian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUkuran.CellClick
        If e.RowIndex >= 0 Then
            txtIdUkuran.Text = dgvUkuran.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtUkuran.Text = dgvUkuran.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUkuran.TextChanged

        Dim kata As String = txtSearchUkuran.Text.Trim()

        If kata = "" Then
            TampilData()
        Else
            dgvUkuran.DataSource = SearchUkuran(kata)
        End If
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        Me.Hide()
        Form_Product.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Form_Login.Show()
            Me.Close()
        End If
    End Sub

End Class