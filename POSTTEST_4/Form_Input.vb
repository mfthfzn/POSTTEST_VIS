Imports System.IO

Public Class Form_Input
    Private fotoPath As String = ""

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub mtbTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbTelepon.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        ValidasiTextBox(ErrorProvider1, txtID, "ID tidak boleh kosong")
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ValidasiTextBox(ErrorProvider1, txtEmail, "Email tidak boleh kosong")
    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged
        ValidasiTextBox(ErrorProvider1, txtAlamat, "Alamat tidak boleh kosong")
    End Sub

    Private Sub cbDivisi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDivisi.SelectedIndexChanged
        ValidasiComboBox(ErrorProvider1, cbDivisi, "Pilih divisi komunitas")
    End Sub

    Private Sub mtbTelepon_TextChanged(sender As Object, e As EventArgs) Handles mtbTelepon.TextChanged
        ValidasiMaskedTextBox(ErrorProvider1, mtbTelepon, "Nomor telepon belum lengkap")
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        OpenFileDialog1.Title = "Pilih Foto Profil"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            fotoPath = OpenFileDialog1.FileName
            pbProfil.Image = Image.FromFile(fotoPath)
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click, SimpanDataToolStripMenuItem.Click
        If Not ValidasiSemuaInput(ErrorProvider1, txtNama, txtID, cbDivisi, mtbTelepon, txtEmail, txtAlamat) Then
            MessageBox.Show("Masih ada data yang kosong atau tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim dialogResult As DialogResult = MessageBox.Show("Apakah ingin menyimpan data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.No Then
            Exit Sub
        Else
            Dim jk As String = GetSelectedRadioButton({rbLaki, rbPerempuan})
            Dim peran As String = GetSelectedRadioButton({rbKetua, rbWakil, rbAnggota})
            Dim hobi As String = GetSelectedCheckBox({cbHobi1, cbHobi2, cbHobi3, cbHobi4, cbHobi5, cbHobi6, cbHobi7, cbHobi8})

            Dim isiData As String =
                "Nama=" & txtNama.Text & vbCrLf &
                "ID=" & txtID.Text & vbCrLf &
                "TglLahir=" & dtpTglLahir.Value.ToString("dd-MM-yyyy") & vbCrLf &
                "JenisKelamin=" & jk & vbCrLf &
                "Divisi=" & cbDivisi.Text & vbCrLf &
                "Telepon=" & mtbTelepon.Text & vbCrLf &
                "Email=" & txtEmail.Text & vbCrLf &
                "Alamat=" & txtAlamat.Text & vbCrLf &
                "Peran=" & peran & vbCrLf &
                "Hobi=" & hobi & vbCrLf &
                "FotoPath=" & fotoPath

            If SimpanDataKeFile(SaveFileDialog1, isiData, "Data_" & txtID.Text & ".txt") Then
                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilkanKartu()
            End If
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim data As Dictionary(Of String, String) = BukaDataDariFile(OpenFileDialog1)

        If data Is Nothing Then Exit Sub

        txtNama.Text = AmbilNilai(data, "Nama")
        txtID.Text = AmbilNilai(data, "ID")
        cbDivisi.Text = AmbilNilai(data, "Divisi")
        mtbTelepon.Text = AmbilNilai(data, "Telepon")
        txtEmail.Text = AmbilNilai(data, "Email")
        txtAlamat.Text = AmbilNilai(data, "Alamat")

        Dim tglString As String = AmbilNilai(data, "TglLahir")
        Dim tglHasil As DateTime

        If DateTime.TryParseExact(tglString, "dd-MM-yyyy", Nothing, Nothing, tglHasil) Then
            dtpTglLahir.Value = tglHasil
        Else
            dtpTglLahir.Value = DateTime.Now
        End If

        Dim jk As String = AmbilNilai(data, "JenisKelamin")
        If jk = "Laki-Laki" Then
            rbLaki.Checked = True
        ElseIf jk = "Perempuan" Then
            rbPerempuan.Checked = True
        End If

        Dim peran As String = AmbilNilai(data, "Peran")
        If peran = "Ketua" Then
            rbKetua.Checked = True
        ElseIf peran = "Wakil" Then
            rbWakil.Checked = True
        ElseIf peran = "Anggota" Then
            rbWakil.Checked = True
        End If

        Dim hobiString As String = AmbilNilai(data, "Hobi")
        Dim arrayHobi() As CheckBox = {cbHobi1, cbHobi2, cbHobi3, cbHobi4, cbHobi5, cbHobi6, cbHobi7, cbHobi8}

        For Each cb As CheckBox In arrayHobi
            cb.Checked = hobiString.Contains(cb.Text)
        Next

        fotoPath = AmbilNilai(data, "FotoPath")
        If File.Exists(fotoPath) Then
            pbProfil.Image = Image.FromFile(fotoPath)
        Else
            pbProfil.Image = Nothing
        End If

        MessageBox.Show("Data berhasil dimuat!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TampilkanKartu()
        Dim formOutput As New Form_Output()
        Dim hobi As String = GetSelectedCheckBox({cbHobi1, cbHobi2, cbHobi3, cbHobi4, cbHobi5, cbHobi6, cbHobi7, cbHobi8})
        Dim kontak As String = mtbTelepon.Text

        formOutput.lblValueNama.Text = txtNama.Text.ToUpper()
        formOutput.lblValueID.Text = txtID.Text
        formOutput.lblValueKomunitas.Text = cbDivisi.Text
        formOutput.lblValueKontak.Text = kontak
        formOutput.lblValueHobby.Text = hobi

        If pbProfil.Image IsNot Nothing Then
            formOutput.PictureBoxFoto.Image = pbProfil.Image
        End If

        formOutput.ShowDialog()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If Not ValidasiSemuaInput(ErrorProvider1, txtNama, txtID, cbDivisi, mtbTelepon, txtEmail, txtAlamat) Then
            MessageBox.Show("Harap isi data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            TampilkanKartu()
        End If
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage1
        txtNama.Focus()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Apakah yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class