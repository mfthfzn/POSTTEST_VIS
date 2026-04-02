<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Input
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        lblJudul = New Label()
        PictureBoxLogo = New PictureBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        cbKomunitas = New ComboBox()
        lblKomunitas = New Label()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        lblKelamin = New Label()
        dtpTglLahir = New DateTimePicker()
        lblTglLahir = New Label()
        txtID = New TextBox()
        lblID = New Label()
        txtNama = New TextBox()
        lblNama = New Label()
        TabPage2 = New TabPage()
        txtAlamat = New TextBox()
        lblAlamat = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        mtbTelepon = New MaskedTextBox()
        lblTelepon = New Label()
        TabPage3 = New TabPage()
        btnSimpanCetak = New Button()
        GroupBoxHobby = New GroupBox()
        chkHobi8 = New CheckBox()
        chkHobi7 = New CheckBox()
        chkHobi6 = New CheckBox()
        chkHobi5 = New CheckBox()
        chkHobi4 = New CheckBox()
        chkHobi3 = New CheckBox()
        chkHobi2 = New CheckBox()
        chkHobi1 = New CheckBox()
        GroupBoxPeran = New GroupBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        PictureBoxProfil = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Panel1 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel2 = New Panel()
        Panel4 = New Panel()
        MenuStrip.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBoxHobby.SuspendLayout()
        GroupBoxPeran.SuspendLayout()
        CType(PictureBoxProfil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.BackColor = Color.FromArgb(CByte(26), CByte(42), CByte(58))
        MenuStrip.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip.ImageScalingSize = New Size(20, 20)
        MenuStrip.ImeMode = ImeMode.NoControl
        MenuStrip.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Size = New Size(721, 28)
        MenuStrip.TabIndex = 0
        MenuStrip.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.ForeColor = Color.White
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(98, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.ForeColor = Color.White
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(101, 24)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.ForeColor = Color.White
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(112, 24)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.ForeColor = Color.White
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(95, 24)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.ForeColor = Color.White
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(68, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.BackColor = Color.FromArgb(CByte(26), CByte(42), CByte(58))
        lblJudul.Font = New Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(12, 59)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(572, 34)
        lblJudul.TabIndex = 1
        lblJudul.Text = "Aplikasi Pembuat Kartu Komunitas"
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackColor = Color.White
        PictureBoxLogo.BorderStyle = BorderStyle.FixedSingle
        PictureBoxLogo.Location = New Point(620, 37)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(82, 80)
        PictureBoxLogo.TabIndex = 2
        PictureBoxLogo.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(12, 148)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(697, 311)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.White
        TabPage1.Controls.Add(cbKomunitas)
        TabPage1.Controls.Add(lblKomunitas)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(lblKelamin)
        TabPage1.Controls.Add(dtpTglLahir)
        TabPage1.Controls.Add(lblTglLahir)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(lblID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(lblNama)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(689, 278)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' cbKomunitas
        ' 
        cbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cbKomunitas.FormattingEnabled = True
        cbKomunitas.Items.AddRange(New Object() {"Teknologi", "Seni & Budaya", "Olahraga", "Sosial", "Pendidikan"})
        cbKomunitas.Location = New Point(219, 175)
        cbKomunitas.Name = "cbKomunitas"
        cbKomunitas.Size = New Size(289, 28)
        cbKomunitas.TabIndex = 10
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        lblKomunitas.Location = New Point(23, 178)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(150, 25)
        lblKomunitas.TabIndex = 9
        lblKomunitas.Text = "Jenis Komunitas"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(375, 137)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(108, 24)
        rbPerempuan.TabIndex = 8
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(221, 137)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(90, 24)
        rbLaki.TabIndex = 7
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' lblKelamin
        ' 
        lblKelamin.AutoSize = True
        lblKelamin.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        lblKelamin.Location = New Point(23, 139)
        lblKelamin.Name = "lblKelamin"
        lblKelamin.Size = New Size(128, 25)
        lblKelamin.TabIndex = 6
        lblKelamin.Text = "Jenis Kelamin"
        ' 
        ' dtpTglLahir
        ' 
        dtpTglLahir.Location = New Point(219, 97)
        dtpTglLahir.Name = "dtpTglLahir"
        dtpTglLahir.Size = New Size(289, 27)
        dtpTglLahir.TabIndex = 5
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        lblTglLahir.Location = New Point(23, 102)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(126, 25)
        lblTglLahir.TabIndex = 4
        lblTglLahir.Text = "Tanggal Lahir"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(219, 60)
        txtID.Name = "txtID"
        txtID.Size = New Size(289, 27)
        txtID.TabIndex = 3
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        lblID.Location = New Point(23, 63)
        lblID.Name = "lblID"
        lblID.Size = New Size(110, 25)
        lblID.TabIndex = 2
        lblID.Text = "ID Anggota"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(219, 23)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(289, 27)
        txtNama.TabIndex = 1
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        lblNama.Location = New Point(23, 26)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(139, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama Lengkap"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.White
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(lblAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(lblEmail)
        TabPage2.Controls.Add(mtbTelepon)
        TabPage2.Controls.Add(lblTelepon)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(689, 278)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(125, 107)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(250, 69)
        txtAlamat.TabIndex = 5
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        lblAlamat.Location = New Point(25, 110)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(68, 23)
        lblAlamat.TabIndex = 4
        lblAlamat.Text = "Alamat"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(125, 66)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 27)
        txtEmail.TabIndex = 3
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        lblEmail.Location = New Point(25, 69)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 23)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(125, 27)
        mtbTelepon.Mask = "(9999) 0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(250, 27)
        mtbTelepon.TabIndex = 1
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        lblTelepon.Location = New Point(25, 30)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(71, 23)
        lblTelepon.TabIndex = 0
        lblTelepon.Text = "No Telp"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.White
        TabPage3.Controls.Add(btnSimpanCetak)
        TabPage3.Controls.Add(GroupBoxHobby)
        TabPage3.Controls.Add(GroupBoxPeran)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(PictureBoxProfil)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(689, 278)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.DodgerBlue
        btnSimpanCetak.Cursor = Cursors.Hand
        btnSimpanCetak.FlatAppearance.BorderSize = 0
        btnSimpanCetak.FlatStyle = FlatStyle.Flat
        btnSimpanCetak.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpanCetak.ForeColor = Color.White
        btnSimpanCetak.Location = New Point(504, 227)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(159, 38)
        btnSimpanCetak.TabIndex = 4
        btnSimpanCetak.Text = "Simpan Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' GroupBoxHobby
        ' 
        GroupBoxHobby.Controls.Add(chkHobi8)
        GroupBoxHobby.Controls.Add(chkHobi7)
        GroupBoxHobby.Controls.Add(chkHobi6)
        GroupBoxHobby.Controls.Add(chkHobi5)
        GroupBoxHobby.Controls.Add(chkHobi4)
        GroupBoxHobby.Controls.Add(chkHobi3)
        GroupBoxHobby.Controls.Add(chkHobi2)
        GroupBoxHobby.Controls.Add(chkHobi1)
        GroupBoxHobby.Location = New Point(145, 118)
        GroupBoxHobby.Name = "GroupBoxHobby"
        GroupBoxHobby.Size = New Size(518, 103)
        GroupBoxHobby.TabIndex = 3
        GroupBoxHobby.TabStop = False
        GroupBoxHobby.Text = "Hobby / Aktivitas"
        ' 
        ' chkHobi8
        ' 
        chkHobi8.AutoSize = True
        chkHobi8.Location = New Point(396, 59)
        chkHobi8.Name = "chkHobi8"
        chkHobi8.Size = New Size(98, 24)
        chkHobi8.TabIndex = 7
        chkHobi8.Text = "Travelling"
        chkHobi8.UseVisualStyleBackColor = True
        ' 
        ' chkHobi7
        ' 
        chkHobi7.AutoSize = True
        chkHobi7.Location = New Point(257, 59)
        chkHobi7.Name = "chkHobi7"
        chkHobi7.Size = New Size(94, 24)
        chkHobi7.TabIndex = 6
        chkHobi7.Text = "Fotografi"
        chkHobi7.UseVisualStyleBackColor = True
        ' 
        ' chkHobi6
        ' 
        chkHobi6.AutoSize = True
        chkHobi6.Location = New Point(125, 59)
        chkHobi6.Name = "chkHobi6"
        chkHobi6.Size = New Size(77, 24)
        chkHobi6.TabIndex = 5
        chkHobi6.Text = "Desain"
        chkHobi6.UseVisualStyleBackColor = True
        ' 
        ' chkHobi5
        ' 
        chkHobi5.AutoSize = True
        chkHobi5.Location = New Point(19, 59)
        chkHobi5.Name = "chkHobi5"
        chkHobi5.Size = New Size(72, 24)
        chkHobi5.TabIndex = 4
        chkHobi5.Text = "Musik"
        chkHobi5.UseVisualStyleBackColor = True
        ' 
        ' chkHobi4
        ' 
        chkHobi4.AutoSize = True
        chkHobi4.Location = New Point(396, 25)
        chkHobi4.Name = "chkHobi4"
        chkHobi4.Size = New Size(79, 24)
        chkHobi4.TabIndex = 3
        chkHobi4.Text = "Diskusi"
        chkHobi4.UseVisualStyleBackColor = True
        ' 
        ' chkHobi3
        ' 
        chkHobi3.AutoSize = True
        chkHobi3.Location = New Point(257, 25)
        chkHobi3.Name = "chkHobi3"
        chkHobi3.Size = New Size(85, 24)
        chkHobi3.TabIndex = 2
        chkHobi3.Text = "Menulis"
        chkHobi3.UseVisualStyleBackColor = True
        ' 
        ' chkHobi2
        ' 
        chkHobi2.AutoSize = True
        chkHobi2.Location = New Point(125, 25)
        chkHobi2.Name = "chkHobi2"
        chkHobi2.Size = New Size(98, 24)
        chkHobi2.TabIndex = 1
        chkHobi2.Text = "Membaca"
        chkHobi2.UseVisualStyleBackColor = True
        ' 
        ' chkHobi1
        ' 
        chkHobi1.AutoSize = True
        chkHobi1.Location = New Point(19, 25)
        chkHobi1.Name = "chkHobi1"
        chkHobi1.Size = New Size(80, 24)
        chkHobi1.TabIndex = 0
        chkHobi1.Text = "Coding"
        chkHobi1.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxPeran
        ' 
        GroupBoxPeran.Controls.Add(rbAdmin)
        GroupBoxPeran.Controls.Add(rbAnggota)
        GroupBoxPeran.Controls.Add(rbKetua)
        GroupBoxPeran.Location = New Point(145, 18)
        GroupBoxPeran.Name = "GroupBoxPeran"
        GroupBoxPeran.Size = New Size(334, 85)
        GroupBoxPeran.TabIndex = 2
        GroupBoxPeran.TabStop = False
        GroupBoxPeran.Text = "Pilihan Peran"
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(242, 39)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(75, 24)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(118, 39)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(89, 24)
        rbAnggota.TabIndex = 1
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(19, 39)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(69, 24)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Cursor = Cursors.Hand
        btnBrowse.Location = New Point(21, 142)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(95, 27)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' PictureBoxProfil
        ' 
        PictureBoxProfil.BackColor = Color.WhiteSmoke
        PictureBoxProfil.BorderStyle = BorderStyle.FixedSingle
        PictureBoxProfil.Location = New Point(21, 18)
        PictureBoxProfil.Name = "PictureBoxProfil"
        PictureBoxProfil.Size = New Size(95, 118)
        PictureBoxProfil.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxProfil.TabIndex = 0
        PictureBoxProfil.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(26), CByte(42), CByte(58))
        Panel1.Location = New Point(0, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(721, 96)
        Panel1.TabIndex = 4
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.FromArgb(CByte(26), CByte(42), CByte(58))
        FlowLayoutPanel1.ForeColor = SystemColors.ControlText
        FlowLayoutPanel1.Location = New Point(0, 475)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(721, 28)
        FlowLayoutPanel1.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Panel2.Location = New Point(0, 126)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(721, 5)
        Panel2.TabIndex = 11
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Panel4.Location = New Point(0, 471)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(721, 5)
        Panel4.TabIndex = 13
        ' 
        ' Form_Input
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 19.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(721, 503)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(TabControl1)
        Controls.Add(PictureBoxLogo)
        Controls.Add(lblJudul)
        Controls.Add(MenuStrip)
        Controls.Add(Panel1)
        Controls.Add(FlowLayoutPanel1)
        Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip
        Name = "Form_Input"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aplikasi Kartu Komunitas"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        GroupBoxHobby.ResumeLayout(False)
        GroupBoxHobby.PerformLayout()
        GroupBoxPeran.ResumeLayout(False)
        GroupBoxPeran.PerformLayout()
        CType(PictureBoxProfil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents dtpTglLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTglLahir As System.Windows.Forms.Label
    Friend WithEvents rbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents rbLaki As System.Windows.Forms.RadioButton
    Friend WithEvents lblKelamin As System.Windows.Forms.Label
    Friend WithEvents cbKomunitas As System.Windows.Forms.ComboBox
    Friend WithEvents lblKomunitas As System.Windows.Forms.Label
    Friend WithEvents lblTelepon As System.Windows.Forms.Label
    Friend WithEvents mtbTelepon As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents PictureBoxProfil As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents GroupBoxPeran As System.Windows.Forms.GroupBox
    Friend WithEvents rbAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents rbAnggota As System.Windows.Forms.RadioButton
    Friend WithEvents rbKetua As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBoxHobby As System.Windows.Forms.GroupBox
    Friend WithEvents chkHobi8 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHobi7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHobi6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHobi5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHobi4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHobi3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHobi2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHobi1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnSimpanCetak As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel

End Class