Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
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

    Public Function ValidasiLogin(ep As ErrorProvider, txtUsername As TextBox, txtPassword As TextBox) As Boolean
        Dim usernameValid As Boolean = ValidasiTextBox(ep, txtUsername, "Username tidak boleh kosong")
        Dim passwordValid As Boolean = ValidasiTextBox(ep, txtPassword, "Password tidak boleh kosong")

        Return usernameValid And passwordValid
    End Function

    Public Function ValidasiDataPakaian(ep As ErrorProvider, txtSku As TextBox, txtNamaPakaian As TextBox, cbUkuran As ComboBox, txtHarga As TextBox, txtStok As TextBox) As Boolean
        Dim skuValid As Boolean = ValidasiTextBox(ep, txtSku, "Sku tidak boleh kosong")
        Dim namaPakaianValid As Boolean = ValidasiTextBox(ep, txtNamaPakaian, "Nama Pakaian tidak boleh kosong")
        Dim ukuranValid As Boolean = ValidasiComboBox(ep, cbUkuran, "Ukuran harus dipilih")
        Dim hargaValid As Boolean = ValidasiTextBox(ep, txtHarga, "Harga tidak boleh kosong")
        Dim stokValid As Boolean = ValidasiTextBox(ep, txtStok, "Stok tidak boleh kosong")

        Return skuValid And namaPakaianValid And ukuranValid And hargaValid And stokValid
    End Function

    Public Function ValidasiDataUkuran(ep As ErrorProvider, txtIdUkuran As TextBox, txtUkuran As TextBox) As Boolean
        Dim skuValid As Boolean = ValidasiTextBox(ep, txtIdUkuran, "Sku tidak boleh kosong")
        Dim namaPakaianValid As Boolean = ValidasiTextBox(ep, txtUkuran, "Nama Pakaian tidak boleh kosong")

        Return skuValid And namaPakaianValid
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

End Module