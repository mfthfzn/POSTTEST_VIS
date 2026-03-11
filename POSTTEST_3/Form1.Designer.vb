<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        labelName = New Label()
        labelAge = New Label()
        Panel1 = New Panel()
        pbImage = New PictureBox()
        btnChooseImage = New Button()
        btnPrint = New Button()
        GroupBox1 = New GroupBox()
        cbBadminton = New CheckBox()
        cbRunning = New CheckBox()
        cbFishing = New CheckBox()
        cbSinging = New CheckBox()
        cbSwimming = New CheckBox()
        cbHiking = New CheckBox()
        cbGaming = New CheckBox()
        cbWriting = New CheckBox()
        cbReading = New CheckBox()
        cbPainting = New CheckBox()
        labelHobby = New Label()
        labelGender = New Label()
        gbGender = New GroupBox()
        rbFemale = New RadioButton()
        rbMale = New RadioButton()
        dtpBirthDate = New DateTimePicker()
        txtAddress = New TextBox()
        txtPhoneNumber = New TextBox()
        txtAge = New TextBox()
        txtName = New TextBox()
        labelAddress = New Label()
        labelBirthDate = New Label()
        labelNoTelp = New Label()
        Panel1.SuspendLayout()
        CType(pbImage, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        gbGender.SuspendLayout()
        SuspendLayout()
        ' 
        ' labelName
        ' 
        labelName.AutoSize = True
        labelName.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelName.Location = New Point(332, 30)
        labelName.Name = "labelName"
        labelName.Size = New Size(130, 21)
        labelName.TabIndex = 0
        labelName.Text = "Nama Lengkap"
        ' 
        ' labelAge
        ' 
        labelAge.AutoSize = True
        labelAge.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelAge.Location = New Point(332, 74)
        labelAge.Name = "labelAge"
        labelAge.Size = New Size(50, 21)
        labelAge.TabIndex = 1
        labelAge.Text = "Umur"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.backgorund_form
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(pbImage)
        Panel1.Controls.Add(btnChooseImage)
        Panel1.Controls.Add(btnPrint)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(labelHobby)
        Panel1.Controls.Add(labelGender)
        Panel1.Controls.Add(gbGender)
        Panel1.Controls.Add(dtpBirthDate)
        Panel1.Controls.Add(txtAddress)
        Panel1.Controls.Add(txtPhoneNumber)
        Panel1.Controls.Add(txtAge)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(labelAddress)
        Panel1.Controls.Add(labelBirthDate)
        Panel1.Controls.Add(labelNoTelp)
        Panel1.Controls.Add(labelAge)
        Panel1.Controls.Add(labelName)
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(799, 480)
        Panel1.TabIndex = 0
        ' 
        ' pbImage
        ' 
        pbImage.Location = New Point(11, 24)
        pbImage.Name = "pbImage"
        pbImage.Size = New Size(301, 220)
        pbImage.SizeMode = PictureBoxSizeMode.Zoom
        pbImage.TabIndex = 15
        pbImage.TabStop = False
        ' 
        ' btnChooseImage
        ' 
        btnChooseImage.Location = New Point(11, 250)
        btnChooseImage.Name = "btnChooseImage"
        btnChooseImage.Size = New Size(110, 29)
        btnChooseImage.TabIndex = 14
        btnChooseImage.Text = "Pilih Gambar"
        btnChooseImage.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(347, 408)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(94, 29)
        btnPrint.TabIndex = 13
        btnPrint.Text = "Cetak"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbBadminton)
        GroupBox1.Controls.Add(cbRunning)
        GroupBox1.Controls.Add(cbFishing)
        GroupBox1.Controls.Add(cbSinging)
        GroupBox1.Controls.Add(cbSwimming)
        GroupBox1.Controls.Add(cbHiking)
        GroupBox1.Controls.Add(cbGaming)
        GroupBox1.Controls.Add(cbWriting)
        GroupBox1.Controls.Add(cbReading)
        GroupBox1.Controls.Add(cbPainting)
        GroupBox1.Location = New Point(11, 319)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 83)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        ' 
        ' cbBadminton
        ' 
        cbBadminton.AutoSize = True
        cbBadminton.Location = New Point(649, 53)
        cbBadminton.Name = "cbBadminton"
        cbBadminton.Size = New Size(104, 24)
        cbBadminton.TabIndex = 9
        cbBadminton.Text = "Badminton"
        cbBadminton.UseVisualStyleBackColor = True
        ' 
        ' cbRunning
        ' 
        cbRunning.AutoSize = True
        cbRunning.Location = New Point(493, 53)
        cbRunning.Name = "cbRunning"
        cbRunning.Size = New Size(74, 24)
        cbRunning.TabIndex = 8
        cbRunning.Text = "Berlari"
        cbRunning.UseVisualStyleBackColor = True
        ' 
        ' cbFishing
        ' 
        cbFishing.AutoSize = True
        cbFishing.Location = New Point(330, 53)
        cbFishing.Name = "cbFishing"
        cbFishing.Size = New Size(109, 24)
        cbFishing.TabIndex = 7
        cbFishing.Text = "Memancing"
        cbFishing.UseVisualStyleBackColor = True
        ' 
        ' cbSinging
        ' 
        cbSinging.AutoSize = True
        cbSinging.Location = New Point(174, 53)
        cbSinging.Name = "cbSinging"
        cbSinging.Size = New Size(95, 24)
        cbSinging.TabIndex = 6
        cbSinging.Text = "Bernyanyi"
        cbSinging.UseVisualStyleBackColor = True
        ' 
        ' cbSwimming
        ' 
        cbSwimming.AutoSize = True
        cbSwimming.Location = New Point(649, 13)
        cbSwimming.Name = "cbSwimming"
        cbSwimming.Size = New Size(94, 24)
        cbSwimming.TabIndex = 5
        cbSwimming.Text = "Berenang"
        cbSwimming.UseVisualStyleBackColor = True
        ' 
        ' cbHiking
        ' 
        cbHiking.AutoSize = True
        cbHiking.Location = New Point(493, 13)
        cbHiking.Name = "cbHiking"
        cbHiking.Size = New Size(74, 24)
        cbHiking.TabIndex = 4
        cbHiking.Text = "Hiking"
        cbHiking.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(330, 13)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(83, 24)
        cbGaming.TabIndex = 3
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbWriting
        ' 
        cbWriting.AutoSize = True
        cbWriting.Location = New Point(174, 13)
        cbWriting.Name = "cbWriting"
        cbWriting.Size = New Size(82, 24)
        cbWriting.TabIndex = 2
        cbWriting.Text = "Menulis"
        cbWriting.UseVisualStyleBackColor = True
        ' 
        ' cbReading
        ' 
        cbReading.AutoSize = True
        cbReading.Location = New Point(16, 53)
        cbReading.Name = "cbReading"
        cbReading.Size = New Size(97, 24)
        cbReading.TabIndex = 1
        cbReading.Text = "Membaca"
        cbReading.UseVisualStyleBackColor = True
        ' 
        ' cbPainting
        ' 
        cbPainting.AutoSize = True
        cbPainting.Location = New Point(16, 13)
        cbPainting.Name = "cbPainting"
        cbPainting.Size = New Size(81, 24)
        cbPainting.TabIndex = 0
        cbPainting.Text = "Melukis"
        cbPainting.UseVisualStyleBackColor = True
        ' 
        ' labelHobby
        ' 
        labelHobby.AutoSize = True
        labelHobby.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelHobby.Location = New Point(27, 293)
        labelHobby.Name = "labelHobby"
        labelHobby.Size = New Size(50, 21)
        labelHobby.TabIndex = 12
        labelHobby.Text = "Hobi"
        ' 
        ' labelGender
        ' 
        labelGender.AutoSize = True
        labelGender.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelGender.Location = New Point(332, 250)
        labelGender.Name = "labelGender"
        labelGender.Size = New Size(140, 21)
        labelGender.TabIndex = 11
        labelGender.Text = "Jenis Kelamin"
        ' 
        ' gbGender
        ' 
        gbGender.Controls.Add(rbFemale)
        gbGender.Controls.Add(rbMale)
        gbGender.Location = New Point(513, 250)
        gbGender.Name = "gbGender"
        gbGender.Size = New Size(274, 48)
        gbGender.TabIndex = 10
        gbGender.TabStop = False
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Location = New Point(147, 18)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(104, 24)
        rbFemale.TabIndex = 1
        rbFemale.TabStop = True
        rbFemale.Text = "Perempuan"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Location = New Point(6, 18)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(88, 24)
        rbMale.TabIndex = 0
        rbMale.TabStop = True
        rbMale.Text = "Laki-Laki"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.Location = New Point(513, 159)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.Size = New Size(274, 27)
        dtpBirthDate.TabIndex = 9
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(513, 203)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(274, 27)
        txtAddress.TabIndex = 8
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(513, 112)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(274, 27)
        txtPhoneNumber.TabIndex = 7
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(513, 72)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(274, 27)
        txtAge.TabIndex = 6
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(513, 24)
        txtName.Name = "txtName"
        txtName.Size = New Size(274, 27)
        txtName.TabIndex = 5
        ' 
        ' labelAddress
        ' 
        labelAddress.AutoSize = True
        labelAddress.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelAddress.Location = New Point(332, 205)
        labelAddress.Name = "labelAddress"
        labelAddress.Size = New Size(70, 21)
        labelAddress.TabIndex = 4
        labelAddress.Text = "Alamat"
        ' 
        ' labelBirthDate
        ' 
        labelBirthDate.AutoSize = True
        labelBirthDate.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelBirthDate.Location = New Point(332, 159)
        labelBirthDate.Name = "labelBirthDate"
        labelBirthDate.Size = New Size(140, 21)
        labelBirthDate.TabIndex = 3
        labelBirthDate.Text = "Tanggal Lahir"
        ' 
        ' labelNoTelp
        ' 
        labelNoTelp.AutoSize = True
        labelNoTelp.Font = New Font("Ubuntu Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelNoTelp.Location = New Point(332, 114)
        labelNoTelp.Name = "labelNoTelp"
        labelNoTelp.Size = New Size(80, 21)
        labelNoTelp.TabIndex = 2
        labelNoTelp.Text = "No Telp"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 481)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbImage, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        gbGender.ResumeLayout(False)
        gbGender.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents labelName As Label
    Friend WithEvents labelAge As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelAddress As Label
    Friend WithEvents labelBirthDate As Label
    Friend WithEvents labelNoTelp As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents labelGender As Label
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents labelHobby As Label
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents btnChooseImage As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents cbSwimming As CheckBox
    Friend WithEvents cbHiking As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbWriting As CheckBox
    Friend WithEvents cbReading As CheckBox
    Friend WithEvents cbPainting As CheckBox
    Friend WithEvents cbBadminton As CheckBox
    Friend WithEvents cbRunning As CheckBox
    Friend WithEvents cbFishing As CheckBox
    Friend WithEvents cbSinging As CheckBox

End Class
