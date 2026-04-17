Public Class Form_Product

    Private Sub kosong()
        txtSku.Clear()
        txtNamaPakaian.Clear()
        txtHarga.Clear()
        txtStok.Clear()
        txtSearch.Clear()
        cbUkuran.SelectedIndex = -1
        ErrorProvider1.Clear()
        txtSku.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        kosong()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
            Form_Login.Show()
        End If
    End Sub

    Private Sub TampilData()
        dgvPakaian.DataSource = GetAllPakaian()
    End Sub

    Private Sub Form_Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kosong()
        TampilData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiDataPakaian(ErrorProvider1, txtSku, txtNamaPakaian, cbUkuran, txtHarga, txtStok) Then Exit Sub

        Dim sku As String = txtSku.Text.Trim()
        Dim namaPakaian As String = txtNamaPakaian.Text.Trim()
        Dim ukuran As String = GetSelectedUkuran(cbUkuran)
        Dim harga As String = txtHarga.Text.Trim()
        Dim stok As String = txtStok.Text.Trim()

        If DataSudahAdaPakaian(sku) Then
            MessageBox.Show("Kode SKU sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSku.Focus()
            Exit Sub
        End If

        If SimpanPakaian(sku, namaPakaian, ukuran, harga, stok) Then
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()

        If Not ValidasiDataPakaian(ErrorProvider1, txtSku, txtNamaPakaian, cbUkuran, txtHarga, txtStok) Then Exit Sub

        Dim sku As String = txtSku.Text.Trim()
        Dim namaPakaian As String = txtNamaPakaian.Text.Trim()
        Dim ukuran As String = GetSelectedUkuran(cbUkuran)
        Dim harga As String = txtHarga.Text.Trim()
        Dim stok As String = txtStok.Text.Trim()

        If UbahPakaian(sku, namaPakaian, ukuran, harga, stok) Then
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            kosong()
        Else
            MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtSku.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSku.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusPakaian(txtSku.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                kosong()
            End If
        End If
    End Sub

    Private Sub dgvPakaian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPakaian.CellClick
        If e.RowIndex >= 0 Then
            txtSku.Text = dgvPakaian.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNamaPakaian.Text = dgvPakaian.Rows(e.RowIndex).Cells(1).Value.ToString()
            cbUkuran.Text = dgvPakaian.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtHarga.Text = dgvPakaian.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtStok.Text = dgvPakaian.Rows(e.RowIndex).Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub txtSku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSku.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            txtNamaPakaian.Focus()
        End If
    End Sub

    Private Sub txtNamaPakaian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaPakaian.KeyPress
        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            cbUkuran.Focus()
        End If
    End Sub

    Private Sub cbUkuran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbUkuran.KeyPress
        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            txtHarga.Focus()
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngka(e)
        If IsEnterKey(e) Then
            e.Handled = True
            txtStok.Focus()
        End If
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        HanyaAngka(e)
        If IsEnterKey(e) Then
            e.Handled = True
            btnSimpan.Focus()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvPakaian.DataSource = SearchPakaian(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form_Main.Show()
    End Sub

    Private Sub SizeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form_Size.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Apakah anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Form_Login.Show()
            Close()
        End If
    End Sub

End Class