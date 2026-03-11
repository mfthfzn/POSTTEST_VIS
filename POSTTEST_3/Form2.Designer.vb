<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        txtHobbies = New TextBox()
        txtGender = New TextBox()
        txtAddress = New TextBox()
        txtBirthDate = New TextBox()
        txtPhoneNumber = New TextBox()
        txtAge = New TextBox()
        txtName = New TextBox()
        labelHobby = New Label()
        labelGender = New Label()
        labelAddress = New Label()
        labelBirthDate = New Label()
        labelNoTelp = New Label()
        labelAge = New Label()
        labelName = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.background_card
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(txtHobbies)
        Panel1.Controls.Add(txtGender)
        Panel1.Controls.Add(txtAddress)
        Panel1.Controls.Add(txtBirthDate)
        Panel1.Controls.Add(txtPhoneNumber)
        Panel1.Controls.Add(txtAge)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(labelHobby)
        Panel1.Controls.Add(labelGender)
        Panel1.Controls.Add(labelAddress)
        Panel1.Controls.Add(labelBirthDate)
        Panel1.Controls.Add(labelNoTelp)
        Panel1.Controls.Add(labelAge)
        Panel1.Controls.Add(labelName)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 449)
        Panel1.TabIndex = 0
        ' 
        ' txtHobbies
        ' 
        txtHobbies.Location = New Point(428, 341)
        txtHobbies.Name = "txtHobbies"
        txtHobbies.ReadOnly = True
        txtHobbies.Size = New Size(319, 27)
        txtHobbies.TabIndex = 20
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(428, 308)
        txtGender.Name = "txtGender"
        txtGender.ReadOnly = True
        txtGender.Size = New Size(319, 27)
        txtGender.TabIndex = 19
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(428, 274)
        txtAddress.Name = "txtAddress"
        txtAddress.ReadOnly = True
        txtAddress.Size = New Size(319, 27)
        txtAddress.TabIndex = 18
        ' 
        ' txtBirthDate
        ' 
        txtBirthDate.Location = New Point(428, 241)
        txtBirthDate.Name = "txtBirthDate"
        txtBirthDate.ReadOnly = True
        txtBirthDate.Size = New Size(319, 27)
        txtBirthDate.TabIndex = 17
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(428, 208)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.ReadOnly = True
        txtPhoneNumber.Size = New Size(319, 27)
        txtPhoneNumber.TabIndex = 16
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(428, 174)
        txtAge.Name = "txtAge"
        txtAge.ReadOnly = True
        txtAge.Size = New Size(319, 27)
        txtAge.TabIndex = 15
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(428, 140)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(319, 27)
        txtName.TabIndex = 14
        ' 
        ' labelHobby
        ' 
        labelHobby.AutoSize = True
        labelHobby.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelHobby.Location = New Point(270, 345)
        labelHobby.Name = "labelHobby"
        labelHobby.Size = New Size(50, 21)
        labelHobby.TabIndex = 13
        labelHobby.Text = "Hobi"
        ' 
        ' labelGender
        ' 
        labelGender.AutoSize = True
        labelGender.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelGender.Location = New Point(270, 311)
        labelGender.Name = "labelGender"
        labelGender.Size = New Size(140, 21)
        labelGender.TabIndex = 12
        labelGender.Text = "Jenis Kelamin"
        ' 
        ' labelAddress
        ' 
        labelAddress.AutoSize = True
        labelAddress.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelAddress.Location = New Point(270, 277)
        labelAddress.Name = "labelAddress"
        labelAddress.Size = New Size(70, 21)
        labelAddress.TabIndex = 5
        labelAddress.Text = "Alamat"
        ' 
        ' labelBirthDate
        ' 
        labelBirthDate.AutoSize = True
        labelBirthDate.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelBirthDate.Location = New Point(270, 244)
        labelBirthDate.Name = "labelBirthDate"
        labelBirthDate.Size = New Size(140, 21)
        labelBirthDate.TabIndex = 4
        labelBirthDate.Text = "Tanggal Lahir"
        ' 
        ' labelNoTelp
        ' 
        labelNoTelp.AutoSize = True
        labelNoTelp.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelNoTelp.Location = New Point(270, 212)
        labelNoTelp.Name = "labelNoTelp"
        labelNoTelp.Size = New Size(80, 21)
        labelNoTelp.TabIndex = 3
        labelNoTelp.Text = "No Telp"
        ' 
        ' labelAge
        ' 
        labelAge.AutoSize = True
        labelAge.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelAge.Location = New Point(270, 179)
        labelAge.Name = "labelAge"
        labelAge.Size = New Size(50, 21)
        labelAge.TabIndex = 2
        labelAge.Text = "Umur"
        ' 
        ' labelName
        ' 
        labelName.AutoSize = True
        labelName.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelName.Location = New Point(270, 146)
        labelName.Name = "labelName"
        labelName.Size = New Size(130, 21)
        labelName.TabIndex = 1
        labelName.Text = "Nama Lengkap"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 136)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(224, 269)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelName As Label
    Friend WithEvents labelAge As Label
    Friend WithEvents labelNoTelp As Label
    Friend WithEvents labelBirthDate As Label
    Friend WithEvents labelAddress As Label
    Friend WithEvents labelGender As Label
    Friend WithEvents labelHobby As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtBirthDate As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtHobbies As TextBox
End Class
