Imports System.IO

Public Class Form1
    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton
    Private Function CekData() As Boolean
        grupHobi = {cbBadminton, cbFishing, cbGaming, cbHiking, cbPainting, cbReading,
                    cbRunning, cbSinging, cbSwimming, cbWriting}
        grupJK = {rbMale, rbFemale}
        If Not ValidasiTextBox(txtName, "Nama Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtAge, "NIM Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtPhoneNumber, "NIM Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtAddress, "NIM Tidak Boleh Kosong") Then Return False
        If Not ValidasiRadioButton(grupJK, "Pilih Jenis Kelamin Anda") Then Return False
        If Not ValidasiCheckBox(grupHobi, "Pilih Minimal 1 Hobi") Then Return False
        If Not ValidasiPictureBox(pbImage, "Gambar Tidak Boleh Kosong") Then Return False
        Return True
    End Function

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If CekData() Then
            grupHobi = {cbBadminton, cbFishing, cbGaming, cbHiking, cbPainting, cbReading,
                    cbRunning, cbSinging, cbSwimming, cbWriting}
            grupJK = {rbMale, rbFemale}
            Dim hobibies_Selected As String = GetSelectedCheckBox(grupHobi)
            Dim gender_selected As String = GetSelectedRadioButton(grupJK)
            DataModule.Name = txtName.Text
            DataModule.Age = txtAge.Text
            DataModule.PhoneNumber = txtPhoneNumber.Text
            DataModule.Adress = txtAddress.Text
            DataModule.Hobbies = hobibies_Selected
            DataModule.Gender = gender_selected
            DataModule.BirthDate = dtpBirthDate.Value.ToShortDateString()
            Form2.Show()
        End If
    End Sub

    Private Sub btnChooseImage_Click(sender As Object, e As EventArgs) Handles btnChooseImage.Click
        If ValidasiTextBox(txtName, "Nama Tidak Boleh Kosong") Then
            Dim NamaFile As String = txtName.Text.Trim()
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If
                File.Copy(openFileDialog.FileName, destinationPath, True)
                DataModule.Foto = destinationPath
                pbImage.Image = Image.FromFile(destinationPath)
                MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        ValidationModule.HanyaHuruf(sender, e)
    End Sub
    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub
    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub

End Class