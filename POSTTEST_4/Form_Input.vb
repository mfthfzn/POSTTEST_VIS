Public Class Form_Input

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        ValidationModule.HanyaHuruf(e)
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbProfil.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If Not ValidationModule.ValidasiSemuaInput(ErrorProvider1, txtNama, txtID, cbKomunitas, mtbTelepon, txtEmail, txtAlamat, GroupBoxHobby, pbProfil) Then
            MessageBox.Show("Silakan lengkapi data yang ditandai dengan ikon error!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi = MessageBox.Show("Apakah Anda yakin data sudah benar dan ingin mencetak kartu?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Dim fOutput As New Form_Output()

            fOutput.lblValueNama.Text = txtNama.Text
            fOutput.lblValueID.Text = txtID.Text
            fOutput.lblValueKomunitas.Text = cbKomunitas.Text
            fOutput.lblValueKontak.Text = mtbTelepon.Text
            fOutput.PictureBoxFoto.Image = pbProfil.Image

            Dim daftarHobi As String = ""
            For Each ctrl As Control In GroupBoxHobby.Controls
                If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                    daftarHobi &= "- " & ctrl.Text & vbCrLf
                End If
            Next
            fOutput.lblValueHobby.Text = daftarHobi.Trim()

            fOutput.ShowDialog()
        End If
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        Me.Hide()
        Form_Output.Show()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        If Not ValidationModule.ValidasiSemuaInput(ErrorProvider1, txtNama, txtID, cbKomunitas, mtbTelepon, txtEmail, txtAlamat, GroupBoxHobby, pbProfil) Then
            MessageBox.Show("Lengkapi data terlebih dahulu sebelum menyimpan file!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim daftarHobi As String = ""
        For Each ctrl As Control In GroupBoxHobby.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                daftarHobi &= ctrl.Text & vbCrLf
            End If
        Next

        Dim isiTeks = DataModule.BuatIsiFile(txtNama.Text, txtID.Text, cbKomunitas.Text, mtbTelepon.Text, txtEmail.Text, txtAlamat.Text, daftarHobi)
        Dim namaFileDefault = txtID.Text & "_" & txtNama.Text.Replace(" ", "_")

        If DataModule.SimpanDataKeFile(SaveFileDialog1, isiTeks, namaFileDefault) Then
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim dataDict = DataModule.BukaDataDariFile(OpenFileDialog1)

        If dataDict IsNot Nothing AndAlso dataDict.Count > 0 Then
            txtNama.Text = DataModule.AmbilNilai(dataDict, "Nama")
            txtID.Text = DataModule.AmbilNilai(dataDict, "ID")
            cbKomunitas.Text = DataModule.AmbilNilai(dataDict, "Komunitas")
            mtbTelepon.Text = DataModule.AmbilNilai(dataDict, "Telepon")
            txtEmail.Text = DataModule.AmbilNilai(dataDict, "Email")
            txtAlamat.Text = DataModule.AmbilNilai(dataDict, "Alamat")

            Dim hobiTersimpan As String = DataModule.AmbilNilai(dataDict, "Hobi")
            MessageBox.Show("Data berhasil dimuat!" & vbCrLf & "Hobi: " & hobiTersimpan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabPage1.Show()
        TabControl1.SelectedTab = TabPage1
    End Sub
End Class