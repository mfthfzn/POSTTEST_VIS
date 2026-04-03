Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cbo As ComboBox, pesan As String) As Boolean
        If cbo.SelectedIndex = -1 OrElse cbo.Text.Trim() = "" Then
            ep.SetError(cbo, pesan)
            Return False
        Else
            ep.SetError(cbo, "")
            Return True
        End If
    End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    Public Function ValidasiPictureBox(ep As ErrorProvider, pb As PictureBox, pesan As String) As Boolean
        If pb.Image Is Nothing Then
            ep.SetError(pb, pesan)
            Return False
        Else
            ep.SetError(pb, "")
            Return True
        End If
    End Function

    Public Function ValidasiHobi(ep As ErrorProvider, gb As GroupBox, pesan As String) As Boolean
        Dim adaHobi As Boolean = False
        For Each ctrl As Control In gb.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    adaHobi = True
                    Exit For
                End If
            End If
        Next

        If Not adaHobi Then
            ep.SetError(gb, pesan)
            Return False
        Else
            ep.SetError(gb, "")
            Return True
        End If
    End Function

    Public Function ValidasiSemuaInput(
        ep As ErrorProvider,
        txtNama As TextBox,
        txtID As TextBox,
        cbKomunitas As ComboBox,
        mtbTelepon As MaskedTextBox,
        txtEmail As TextBox,
        txtAlamat As TextBox,
        gbHobby As GroupBox,
        pbProfil As PictureBox
    ) As Boolean

        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama tidak boleh kosong")
        Dim idValid As Boolean = ValidasiTextBox(ep, txtID, "ID Anggota tidak boleh kosong")
        Dim komunitasValid As Boolean = ValidasiComboBox(ep, cbKomunitas, "Jenis komunitas harus dipilih")
        Dim telpValid As Boolean = ValidasiMaskedTextBox(ep, mtbTelepon, "Nomor Telepon belum lengkap")
        Dim emailValid As Boolean = ValidasiTextBox(ep, txtEmail, "Email tidak boleh kosong")
        Dim alamatValid As Boolean = ValidasiTextBox(ep, txtAlamat, "Alamat tidak boleh kosong")
        Dim hobiValid As Boolean = ValidasiHobi(ep, gbHobby, "Pilih minimal satu hobi")
        Dim fotoValid As Boolean = ValidasiPictureBox(ep, pbProfil, "Foto profil harus diunggah")

        Return namaValid And idValid And komunitasValid And telpValid And emailValid And alamatValid And hobiValid And fotoValid
    End Function

End Module