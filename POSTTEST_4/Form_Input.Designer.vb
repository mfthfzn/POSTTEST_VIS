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
        components = New ComponentModel.Container()
        MenuStrip = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        lblJudul1 = New Label()
        pbLogo = New PictureBox()
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
        cbHobi8 = New CheckBox()
        cbHobi7 = New CheckBox()
        cbHobi6 = New CheckBox()
        cbHobi5 = New CheckBox()
        cbHobi4 = New CheckBox()
        cbHobi3 = New CheckBox()
        cbHobi2 = New CheckBox()
        cbHobi1 = New CheckBox()
        GroupBoxPeran = New GroupBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        pbProfil = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Panel1 = New Panel()
        lblJudul2 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel2 = New Panel()
        Panel4 = New Panel()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBoxHobby.SuspendLayout()
        GroupBoxPeran.SuspendLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.BackColor = Color.MidnightBlue
        MenuStrip.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        ' lblJudul1
        ' 
        lblJudul1.AutoSize = True
        lblJudul1.BackColor = Color.MidnightBlue
        lblJudul1.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul1.ForeColor = Color.White
        lblJudul1.Location = New Point(12, 49)
        lblJudul1.Name = "lblJudul1"
        lblJudul1.Size = New Size(458, 28)
        lblJudul1.TabIndex = 1
        lblJudul1.Text = "Aplikasi Pembuat Kartu Komunitas"
        ' 
        ' pbLogo
        ' 
        pbLogo.BackColor = Color.Transparent
        pbLogo.BorderStyle = BorderStyle.FixedSingle
        pbLogo.Image = My.Resources.Resources.logo_gsw
        pbLogo.Location = New Point(620, 39)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(82, 80)
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbLogo.TabIndex = 2
        pbLogo.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        txtAlamat.Location = New Point(136, 107)
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
        txtEmail.Location = New Point(136, 66)
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
        mtbTelepon.Location = New Point(136, 27)
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
        lblTelepon.Size = New Size(91, 23)
        lblTelepon.TabIndex = 0
        lblTelepon.Text = "No Telpon"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.White
        TabPage3.Controls.Add(btnSimpanCetak)
        TabPage3.Controls.Add(GroupBoxHobby)
        TabPage3.Controls.Add(GroupBoxPeran)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(pbProfil)
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
        btnSimpanCetak.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpanCetak.ForeColor = Color.White
        btnSimpanCetak.Location = New Point(462, 227)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(201, 38)
        btnSimpanCetak.TabIndex = 4
        btnSimpanCetak.Text = "Simpan dan Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' GroupBoxHobby
        ' 
        GroupBoxHobby.Controls.Add(cbHobi8)
        GroupBoxHobby.Controls.Add(cbHobi7)
        GroupBoxHobby.Controls.Add(cbHobi6)
        GroupBoxHobby.Controls.Add(cbHobi5)
        GroupBoxHobby.Controls.Add(cbHobi4)
        GroupBoxHobby.Controls.Add(cbHobi3)
        GroupBoxHobby.Controls.Add(cbHobi2)
        GroupBoxHobby.Controls.Add(cbHobi1)
        GroupBoxHobby.Location = New Point(145, 118)
        GroupBoxHobby.Name = "GroupBoxHobby"
        GroupBoxHobby.Size = New Size(518, 103)
        GroupBoxHobby.TabIndex = 3
        GroupBoxHobby.TabStop = False
        GroupBoxHobby.Text = "Hobby / Aktivitas"
        ' 
        ' cbHobi8
        ' 
        cbHobi8.AutoSize = True
        cbHobi8.Location = New Point(396, 59)
        cbHobi8.Name = "cbHobi8"
        cbHobi8.Size = New Size(98, 24)
        cbHobi8.TabIndex = 7
        cbHobi8.Text = "Travelling"
        cbHobi8.UseVisualStyleBackColor = True
        ' 
        ' cbHobi7
        ' 
        cbHobi7.AutoSize = True
        cbHobi7.Location = New Point(257, 59)
        cbHobi7.Name = "cbHobi7"
        cbHobi7.Size = New Size(94, 24)
        cbHobi7.TabIndex = 6
        cbHobi7.Text = "Fotografi"
        cbHobi7.UseVisualStyleBackColor = True
        ' 
        ' cbHobi6
        ' 
        cbHobi6.AutoSize = True
        cbHobi6.Location = New Point(125, 59)
        cbHobi6.Name = "cbHobi6"
        cbHobi6.Size = New Size(77, 24)
        cbHobi6.TabIndex = 5
        cbHobi6.Text = "Desain"
        cbHobi6.UseVisualStyleBackColor = True
        ' 
        ' cbHobi5
        ' 
        cbHobi5.AutoSize = True
        cbHobi5.Location = New Point(19, 59)
        cbHobi5.Name = "cbHobi5"
        cbHobi5.Size = New Size(72, 24)
        cbHobi5.TabIndex = 4
        cbHobi5.Text = "Musik"
        cbHobi5.UseVisualStyleBackColor = True
        ' 
        ' cbHobi4
        ' 
        cbHobi4.AutoSize = True
        cbHobi4.Location = New Point(396, 25)
        cbHobi4.Name = "cbHobi4"
        cbHobi4.Size = New Size(79, 24)
        cbHobi4.TabIndex = 3
        cbHobi4.Text = "Diskusi"
        cbHobi4.UseVisualStyleBackColor = True
        ' 
        ' cbHobi3
        ' 
        cbHobi3.AutoSize = True
        cbHobi3.Location = New Point(257, 25)
        cbHobi3.Name = "cbHobi3"
        cbHobi3.Size = New Size(85, 24)
        cbHobi3.TabIndex = 2
        cbHobi3.Text = "Menulis"
        cbHobi3.UseVisualStyleBackColor = True
        ' 
        ' cbHobi2
        ' 
        cbHobi2.AutoSize = True
        cbHobi2.Location = New Point(125, 25)
        cbHobi2.Name = "cbHobi2"
        cbHobi2.Size = New Size(98, 24)
        cbHobi2.TabIndex = 1
        cbHobi2.Text = "Membaca"
        cbHobi2.UseVisualStyleBackColor = True
        ' 
        ' cbHobi1
        ' 
        cbHobi1.AutoSize = True
        cbHobi1.Location = New Point(19, 25)
        cbHobi1.Name = "cbHobi1"
        cbHobi1.Size = New Size(80, 24)
        cbHobi1.TabIndex = 0
        cbHobi1.Text = "Coding"
        cbHobi1.UseVisualStyleBackColor = True
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
        ' pbProfil
        ' 
        pbProfil.BackColor = Color.WhiteSmoke
        pbProfil.BorderStyle = BorderStyle.FixedSingle
        pbProfil.Location = New Point(21, 18)
        pbProfil.Name = "pbProfil"
        pbProfil.Size = New Size(95, 118)
        pbProfil.SizeMode = PictureBoxSizeMode.StretchImage
        pbProfil.TabIndex = 0
        pbProfil.TabStop = False
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
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(lblJudul2)
        Panel1.Location = New Point(0, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(721, 96)
        Panel1.TabIndex = 4
        ' 
        ' lblJudul2
        ' 
        lblJudul2.AutoSize = True
        lblJudul2.BackColor = Color.MidnightBlue
        lblJudul2.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul2.ForeColor = Color.White
        lblJudul2.Location = New Point(12, 49)
        lblJudul2.Name = "lblJudul2"
        lblJudul2.Size = New Size(296, 28)
        lblJudul2.TabIndex = 14
        lblJudul2.Text = "Golden State Warriors"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.MidnightBlue
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
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form_Input
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(721, 503)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(TabControl1)
        Controls.Add(pbLogo)
        Controls.Add(lblJudul1)
        Controls.Add(MenuStrip)
        Controls.Add(Panel1)
        Controls.Add(FlowLayoutPanel1)
        Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip
        Name = "Form_Input"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aplikasi Kartu Komunitas "
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
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
        CType(pbProfil, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblJudul1 As System.Windows.Forms.Label
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
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
    Friend WithEvents pbProfil As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents GroupBoxPeran As System.Windows.Forms.GroupBox
    Friend WithEvents rbAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents rbAnggota As System.Windows.Forms.RadioButton
    Friend WithEvents rbKetua As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBoxHobby As System.Windows.Forms.GroupBox
    Friend WithEvents cbHobi8 As System.Windows.Forms.CheckBox
    Friend WithEvents cbHobi7 As System.Windows.Forms.CheckBox
    Friend WithEvents cbHobi6 As System.Windows.Forms.CheckBox
    Friend WithEvents cbHobi5 As System.Windows.Forms.CheckBox
    Friend WithEvents cbHobi4 As System.Windows.Forms.CheckBox
    Friend WithEvents cbHobi3 As System.Windows.Forms.CheckBox
    Friend WithEvents cbHobi2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbHobi1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnSimpanCetak As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblJudul2 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class