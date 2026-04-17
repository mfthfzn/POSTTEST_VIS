Public Class Form_Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If Not ValidasiLogin(ErrorProvider1, txtUsername, txtPassword) Then
            Return
        End If

        If getUser(txtUsername.Text.Trim(), txtPassword.Text.Trim()) Then
            MessageBox.Show("Login berhasil!", "Sukses Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form_Main.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        txtUsername.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Apakah Anda yakin ingin menutup aplikasi?", "Konfirmasi Menutup", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class