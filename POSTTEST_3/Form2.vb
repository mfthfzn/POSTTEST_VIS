Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = DataModule.Name
        txtAge.Text = DataModule.Age
        txtPhoneNumber.Text = DataModule.PhoneNumber
        txtBirthDate.Text = DataModule.BirthDate
        txtAddress.Text = DataModule.Adress
        txtGender.Text = DataModule.Gender
        txtHobbies.Text = DataModule.Hobbies
        PictureBox1.Image = Image.FromFile(DataModule.Foto)
    End Sub

End Class