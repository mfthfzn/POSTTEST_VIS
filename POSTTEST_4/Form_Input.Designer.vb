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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.InputDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatKartuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cbKomunitas = New System.Windows.Forms.ComboBox()
        Me.lblKomunitas = New System.Windows.Forms.Label()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.lblKelamin = New System.Windows.Forms.Label()
        Me.dtpTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.lblTglLahir = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.mtbTelepon = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnSimpanCetak = New System.Windows.Forms.Button()
        Me.GroupBoxHobby = New System.Windows.Forms.GroupBox()
        Me.chkHobi8 = New System.Windows.Forms.CheckBox()
        Me.chkHobi7 = New System.Windows.Forms.CheckBox()
        Me.chkHobi6 = New System.Windows.Forms.CheckBox()
        Me.chkHobi5 = New System.Windows.Forms.CheckBox()
        Me.chkHobi4 = New System.Windows.Forms.CheckBox()
        Me.chkHobi3 = New System.Windows.Forms.CheckBox()
        Me.chkHobi2 = New System.Windows.Forms.CheckBox()
        Me.chkHobi1 = New System.Windows.Forms.CheckBox()
        Me.GroupBoxPeran = New System.Windows.Forms.GroupBox()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbAnggota = New System.Windows.Forms.RadioButton()
        Me.rbKetua = New System.Windows.Forms.RadioButton()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.PictureBoxProfil = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBoxHobby.SuspendLayout()
        Me.GroupBoxPeran.SuspendLayout()
        CType(Me.PictureBoxProfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataToolStripMenuItem, Me.LihatKartuToolStripMenuItem, Me.SimpanDataToolStripMenuItem, Me.BukaDataToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip1"
        Me.MenuStrip.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'InputDataToolStripMenuItem
        '
        Me.InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        Me.InputDataToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.InputDataToolStripMenuItem.Text = "Input Data"
        '
        'LihatKartuToolStripMenuItem
        '
        Me.LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        Me.LihatKartuToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        '
        'SimpanDataToolStripMenuItem
        '
        Me.SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        Me.SimpanDataToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.SimpanDataToolStripMenuItem.Text = "Simpan Data"
        '
        'BukaDataToolStripMenuItem
        '
        Me.BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        Me.BukaDataToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.BukaDataToolStripMenuItem.Text = "Buka Data"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Navy
        Me.lblJudul.Location = New System.Drawing.Point(12, 43)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(365, 30)
        Me.lblJudul.TabIndex = 1
        Me.lblJudul.Text = "Aplikasi Pembuat Kartu Komunitas"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.White
        Me.PictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxLogo.Location = New System.Drawing.Point(492, 34)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(80, 80)
        Me.PictureBoxLogo.TabIndex = 2
        Me.PictureBoxLogo.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 130)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(560, 311)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.cbKomunitas)
        Me.TabPage1.Controls.Add(Me.lblKomunitas)
        Me.TabPage1.Controls.Add(Me.rbPerempuan)
        Me.TabPage1.Controls.Add(Me.rbLaki)
        Me.TabPage1.Controls.Add(Me.lblKelamin)
        Me.TabPage1.Controls.Add(Me.dtpTglLahir)
        Me.TabPage1.Controls.Add(Me.lblTglLahir)
        Me.TabPage1.Controls.Add(Me.txtID)
        Me.TabPage1.Controls.Add(Me.lblID)
        Me.TabPage1.Controls.Add(Me.txtNama)
        Me.TabPage1.Controls.Add(Me.lblNama)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(552, 283)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Utama"
        '
        'cbKomunitas
        '
        Me.cbKomunitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKomunitas.FormattingEnabled = True
        Me.cbKomunitas.Items.AddRange(New Object() {"Teknologi", "Seni & Budaya", "Olahraga", "Sosial", "Pendidikan"})
        Me.cbKomunitas.Location = New System.Drawing.Point(135, 175)
        Me.cbKomunitas.Name = "cbKomunitas"
        Me.cbKomunitas.Size = New System.Drawing.Size(200, 23)
        Me.cbKomunitas.TabIndex = 10
        '
        'lblKomunitas
        '
        Me.lblKomunitas.AutoSize = True
        Me.lblKomunitas.Location = New System.Drawing.Point(23, 178)
        Me.lblKomunitas.Name = "lblKomunitas"
        Me.lblKomunitas.Size = New System.Drawing.Size(92, 15)
        Me.lblKomunitas.TabIndex = 9
        Me.lblKomunitas.Text = "Jenis Komunitas"
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(219, 137)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(86, 19)
        Me.rbPerempuan.TabIndex = 8
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Location = New System.Drawing.Point(135, 137)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(73, 19)
        Me.rbLaki.TabIndex = 7
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki-Laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'lblKelamin
        '
        Me.lblKelamin.AutoSize = True
        Me.lblKelamin.Location = New System.Drawing.Point(23, 139)
        Me.lblKelamin.Name = "lblKelamin"
        Me.lblKelamin.Size = New System.Drawing.Size(78, 15)
        Me.lblKelamin.TabIndex = 6
        Me.lblKelamin.Text = "Jenis Kelamin"
        '
        'dtpTglLahir
        '
        Me.dtpTglLahir.Location = New System.Drawing.Point(135, 98)
        Me.dtpTglLahir.Name = "dtpTglLahir"
        Me.dtpTglLahir.Size = New System.Drawing.Size(200, 23)
        Me.dtpTglLahir.TabIndex = 5
        '
        'lblTglLahir
        '
        Me.lblTglLahir.AutoSize = True
        Me.lblTglLahir.Location = New System.Drawing.Point(23, 102)
        Me.lblTglLahir.Name = "lblTglLahir"
        Me.lblTglLahir.Size = New System.Drawing.Size(77, 15)
        Me.lblTglLahir.TabIndex = 4
        Me.lblTglLahir.Text = "Tanggal Lahir"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(135, 60)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(200, 23)
        Me.txtID.TabIndex = 3
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(23, 63)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(66, 15)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID Anggota"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(135, 23)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(200, 23)
        Me.txtNama.TabIndex = 1
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(23, 26)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(87, 15)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Nama Lengkap"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.txtAlamat)
        Me.TabPage2.Controls.Add(Me.lblAlamat)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Controls.Add(Me.lblEmail)
        Me.TabPage2.Controls.Add(Me.mtbTelepon)
        Me.TabPage2.Controls.Add(Me.lblTelepon)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(552, 283)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Kontak & Info"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(125, 107)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(250, 69)
        Me.txtAlamat.TabIndex = 5
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(25, 110)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(45, 15)
        Me.lblAlamat.TabIndex = 4
        Me.lblAlamat.Text = "Alamat"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(125, 66)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 23)
        Me.txtEmail.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(25, 69)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(36, 15)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email"
        '
        'mtbTelepon
        '
        Me.mtbTelepon.Location = New System.Drawing.Point(125, 27)
        Me.mtbTelepon.Mask = "(9999) 0000-0000"
        Me.mtbTelepon.Name = "mtbTelepon"
        Me.mtbTelepon.Size = New System.Drawing.Size(250, 23)
        Me.mtbTelepon.TabIndex = 1
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.Location = New System.Drawing.Point(25, 30)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(50, 15)
        Me.lblTelepon.TabIndex = 0
        Me.lblTelepon.Text = "No Telp"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.btnSimpanCetak)
        Me.TabPage3.Controls.Add(Me.GroupBoxHobby)
        Me.TabPage3.Controls.Add(Me.GroupBoxPeran)
        Me.TabPage3.Controls.Add(Me.btnBrowse)
        Me.TabPage3.Controls.Add(Me.PictureBoxProfil)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(552, 283)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Profil & Aktivitas"
        '
        'btnSimpanCetak
        '
        Me.btnSimpanCetak.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSimpanCetak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpanCetak.FlatAppearance.BorderSize = 0
        Me.btnSimpanCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanCetak.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanCetak.ForeColor = System.Drawing.Color.White
        Me.btnSimpanCetak.Location = New System.Drawing.Point(367, 230)
        Me.btnSimpanCetak.Name = "btnSimpanCetak"
        Me.btnSimpanCetak.Size = New System.Drawing.Size(159, 38)
        Me.btnSimpanCetak.TabIndex = 4
        Me.btnSimpanCetak.Text = "Simpan & Cetak Kartu"
        Me.btnSimpanCetak.UseVisualStyleBackColor = False
        '
        'GroupBoxHobby
        '
        Me.GroupBoxHobby.Controls.Add(Me.chkHobi8)
        Me.GroupBoxHobby.Controls.Add(Me.chkHobi7)
        Me.GroupBoxHobby.Controls.Add(Me.chkHobi6)
        Me.GroupBoxHobby.Controls.Add(Me.chkHobi5)
        Me.GroupBoxHobby.Controls.Add(Me.chkHobi4)
        Me.GroupBoxHobby.Controls.Add(Me.chkHobi3)
        Me.GroupBoxHobby.Controls.Add(Me.chkHobi2)
        Me.GroupBoxHobby.Controls.Add(Me.chkHobi1)
        Me.GroupBoxHobby.Location = New System.Drawing.Point(145, 118)
        Me.GroupBoxHobby.Name = "GroupBoxHobby"
        Me.GroupBoxHobby.Size = New System.Drawing.Size(381, 103)
        Me.GroupBoxHobby.TabIndex = 3
        Me.GroupBoxHobby.TabStop = False
        Me.GroupBoxHobby.Text = "Hobby / Aktivitas"
        '
        'chkHobi8
        '
        Me.chkHobi8.AutoSize = True
        Me.chkHobi8.Location = New System.Drawing.Point(265, 59)
        Me.chkHobi8.Name = "chkHobi8"
        Me.chkHobi8.Size = New System.Drawing.Size(77, 19)
        Me.chkHobi8.TabIndex = 7
        Me.chkHobi8.Text = "Travelling"
        Me.chkHobi8.UseVisualStyleBackColor = True
        '
        'chkHobi7
        '
        Me.chkHobi7.AutoSize = True
        Me.chkHobi7.Location = New System.Drawing.Point(179, 59)
        Me.chkHobi7.Name = "chkHobi7"
        Me.chkHobi7.Size = New System.Drawing.Size(73, 19)
        Me.chkHobi7.TabIndex = 6
        Me.chkHobi7.Text = "Fotografi"
        Me.chkHobi7.UseVisualStyleBackColor = True
        '
        'chkHobi6
        '
        Me.chkHobi6.AutoSize = True
        Me.chkHobi6.Location = New System.Drawing.Point(92, 59)
        Me.chkHobi6.Name = "chkHobi6"
        Me.chkHobi6.Size = New System.Drawing.Size(61, 19)
        Me.chkHobi6.TabIndex = 5
        Me.chkHobi6.Text = "Desain"
        Me.chkHobi6.UseVisualStyleBackColor = True
        '
        'chkHobi5
        '
        Me.chkHobi5.AutoSize = True
        Me.chkHobi5.Location = New System.Drawing.Point(19, 59)
        Me.chkHobi5.Name = "chkHobi5"
        Me.chkHobi5.Size = New System.Drawing.Size(58, 19)
        Me.chkHobi5.TabIndex = 4
        Me.chkHobi5.Text = "Musik"
        Me.chkHobi5.UseVisualStyleBackColor = True
        '
        'chkHobi4
        '
        Me.chkHobi4.AutoSize = True
        Me.chkHobi4.Location = New System.Drawing.Point(265, 25)
        Me.chkHobi4.Name = "chkHobi4"
        Me.chkHobi4.Size = New System.Drawing.Size(63, 19)
        Me.chkHobi4.TabIndex = 3
        Me.chkHobi4.Text = "Diskusi"
        Me.chkHobi4.UseVisualStyleBackColor = True
        '
        'chkHobi3
        '
        Me.chkHobi3.AutoSize = True
        Me.chkHobi3.Location = New System.Drawing.Point(179, 25)
        Me.chkHobi3.Name = "chkHobi3"
        Me.chkHobi3.Size = New System.Drawing.Size(69, 19)
        Me.chkHobi3.TabIndex = 2
        Me.chkHobi3.Text = "Menulis"
        Me.chkHobi3.UseVisualStyleBackColor = True
        '
        'chkHobi2
        '
        Me.chkHobi2.AutoSize = True
        Me.chkHobi2.Location = New System.Drawing.Point(92, 25)
        Me.chkHobi2.Name = "chkHobi2"
        Me.chkHobi2.Size = New System.Drawing.Size(80, 19)
        Me.chkHobi2.TabIndex = 1
        Me.chkHobi2.Text = "Membaca"
        Me.chkHobi2.UseVisualStyleBackColor = True
        '
        'chkHobi1
        '
        Me.chkHobi1.AutoSize = True
        Me.chkHobi1.Location = New System.Drawing.Point(19, 25)
        Me.chkHobi1.Name = "chkHobi1"
        Me.chkHobi1.Size = New System.Drawing.Size(65, 19)
        Me.chkHobi1.TabIndex = 0
        Me.chkHobi1.Text = "Coding"
        Me.chkHobi1.UseVisualStyleBackColor = True
        '
        'GroupBoxPeran
        '
        Me.GroupBoxPeran.Controls.Add(Me.rbAdmin)
        Me.GroupBoxPeran.Controls.Add(Me.rbAnggota)
        Me.GroupBoxPeran.Controls.Add(Me.rbKetua)
        Me.GroupBoxPeran.Location = New System.Drawing.Point(145, 18)
        Me.GroupBoxPeran.Name = "GroupBoxPeran"
        Me.GroupBoxPeran.Size = New System.Drawing.Size(381, 85)
        Me.GroupBoxPeran.TabIndex = 2
        Me.GroupBoxPeran.TabStop = False
        Me.GroupBoxPeran.Text = "Pilihan Peran"
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.Location = New System.Drawing.Point(179, 39)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(61, 19)
        Me.rbAdmin.TabIndex = 2
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.UseVisualStyleBackColor = True
        '
        'rbAnggota
        '
        Me.rbAnggota.AutoSize = True
        Me.rbAnggota.Location = New System.Drawing.Point(92, 39)
        Me.rbAnggota.Name = "rbAnggota"
        Me.rbAnggota.Size = New System.Drawing.Size(71, 19)
        Me.rbAnggota.TabIndex = 1
        Me.rbAnggota.TabStop = True
        Me.rbAnggota.Text = "Anggota"
        Me.rbAnggota.UseVisualStyleBackColor = True
        '
        'rbKetua
        '
        Me.rbKetua.AutoSize = True
        Me.rbKetua.Location = New System.Drawing.Point(19, 39)
        Me.rbKetua.Name = "rbKetua"
        Me.rbKetua.Size = New System.Drawing.Size(55, 19)
        Me.rbKetua.TabIndex = 0
        Me.rbKetua.TabStop = True
        Me.rbKetua.Text = "Ketua"
        Me.rbKetua.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Location = New System.Drawing.Point(21, 142)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(95, 27)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse Foto"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'PictureBoxProfil
        '
        Me.PictureBoxProfil.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBoxProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxProfil.Location = New System.Drawing.Point(21, 18)
        Me.PictureBoxProfil.Name = "PictureBoxProfil"
        Me.PictureBoxProfil.Size = New System.Drawing.Size(95, 118)
        Me.PictureBoxProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxProfil.TabIndex = 0
        Me.PictureBoxProfil.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Kartu Komunitas"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBoxHobby.ResumeLayout(False)
        Me.GroupBoxHobby.PerformLayout()
        Me.GroupBoxPeran.ResumeLayout(False)
        Me.GroupBoxPeran.PerformLayout()
        CType(Me.PictureBoxProfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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

End Class