<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Output
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
        PanelKartu = New Panel()
        btnTutup = New Button()
        PanelHeader = New Panel()
        pbLogo = New PictureBox()
        lblHeaderTitle = New Label()
        lblValueHobby = New Label()
        lblStaticHobby = New Label()
        lblValueKontak = New Label()
        lblStaticKontak = New Label()
        lblValueKomunitas = New Label()
        lblStaticDivisi = New Label()
        lblValueID = New Label()
        lblStaticID = New Label()
        lblValueNama = New Label()
        lblStaticNama = New Label()
        PictureBoxFoto = New PictureBox()
        PanelKartu.SuspendLayout()
        PanelHeader.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelKartu
        ' 
        PanelKartu.BackColor = Color.White
        PanelKartu.BorderStyle = BorderStyle.FixedSingle
        PanelKartu.Controls.Add(btnTutup)
        PanelKartu.Controls.Add(PanelHeader)
        PanelKartu.Controls.Add(lblValueHobby)
        PanelKartu.Controls.Add(lblStaticHobby)
        PanelKartu.Controls.Add(lblValueKontak)
        PanelKartu.Controls.Add(lblStaticKontak)
        PanelKartu.Controls.Add(lblValueKomunitas)
        PanelKartu.Controls.Add(lblStaticDivisi)
        PanelKartu.Controls.Add(lblValueID)
        PanelKartu.Controls.Add(lblStaticID)
        PanelKartu.Controls.Add(lblValueNama)
        PanelKartu.Controls.Add(lblStaticNama)
        PanelKartu.Controls.Add(PictureBoxFoto)
        PanelKartu.Location = New Point(12, 12)
        PanelKartu.Name = "PanelKartu"
        PanelKartu.Size = New Size(526, 277)
        PanelKartu.TabIndex = 0
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.Red
        btnTutup.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(229, 237)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(94, 29)
        btnTutup.TabIndex = 12
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.MidnightBlue
        PanelHeader.Controls.Add(pbLogo)
        PanelHeader.Controls.Add(lblHeaderTitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(524, 50)
        PanelHeader.TabIndex = 11
        ' 
        ' pbLogo
        ' 
        pbLogo.BackColor = Color.WhiteSmoke
        pbLogo.BorderStyle = BorderStyle.FixedSingle
        pbLogo.Image = My.Resources.Resources.logo_gsw
        pbLogo.Location = New Point(457, 1)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(49, 48)
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbLogo.TabIndex = 3
        pbLogo.TabStop = False
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(12, 12)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(372, 32)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "KARTU IDENTITAS KOMUNITAS"
        ' 
        ' lblValueHobby
        ' 
        lblValueHobby.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblValueHobby.Location = New Point(296, 196)
        lblValueHobby.Name = "lblValueHobby"
        lblValueHobby.Size = New Size(190, 48)
        lblValueHobby.TabIndex = 10
        lblValueHobby.Text = " "
        ' 
        ' lblStaticHobby
        ' 
        lblStaticHobby.AutoSize = True
        lblStaticHobby.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStaticHobby.ForeColor = Color.Gray
        lblStaticHobby.Location = New Point(155, 196)
        lblStaticHobby.Name = "lblStaticHobby"
        lblStaticHobby.Size = New Size(131, 19)
        lblStaticHobby.TabIndex = 9
        lblStaticHobby.Text = "Hobby / Aktivitas:"
        ' 
        ' lblValueKontak
        ' 
        lblValueKontak.AutoSize = True
        lblValueKontak.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblValueKontak.Location = New Point(296, 166)
        lblValueKontak.Name = "lblValueKontak"
        lblValueKontak.Size = New Size(13, 20)
        lblValueKontak.TabIndex = 8
        lblValueKontak.Text = " "
        ' 
        ' lblStaticKontak
        ' 
        lblStaticKontak.AutoSize = True
        lblStaticKontak.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStaticKontak.ForeColor = Color.Gray
        lblStaticKontak.Location = New Point(155, 166)
        lblStaticKontak.Name = "lblStaticKontak"
        lblStaticKontak.Size = New Size(61, 19)
        lblStaticKontak.TabIndex = 7
        lblStaticKontak.Text = "Kontak:"
        ' 
        ' lblValueKomunitas
        ' 
        lblValueKomunitas.AutoSize = True
        lblValueKomunitas.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblValueKomunitas.Location = New Point(296, 136)
        lblValueKomunitas.Name = "lblValueKomunitas"
        lblValueKomunitas.Size = New Size(13, 20)
        lblValueKomunitas.TabIndex = 6
        lblValueKomunitas.Text = " "
        ' 
        ' lblStaticDivisi
        ' 
        lblStaticDivisi.AutoSize = True
        lblStaticDivisi.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStaticDivisi.ForeColor = Color.Gray
        lblStaticDivisi.Location = New Point(155, 136)
        lblStaticDivisi.Name = "lblStaticDivisi"
        lblStaticDivisi.Size = New Size(49, 19)
        lblStaticDivisi.TabIndex = 5
        lblStaticDivisi.Text = "Divisi:"
        ' 
        ' lblValueID
        ' 
        lblValueID.AutoSize = True
        lblValueID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblValueID.Location = New Point(296, 106)
        lblValueID.Name = "lblValueID"
        lblValueID.Size = New Size(13, 20)
        lblValueID.TabIndex = 4
        lblValueID.Text = " "
        ' 
        ' lblStaticID
        ' 
        lblStaticID.AutoSize = True
        lblStaticID.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStaticID.ForeColor = Color.Gray
        lblStaticID.Location = New Point(155, 106)
        lblStaticID.Name = "lblStaticID"
        lblStaticID.Size = New Size(89, 19)
        lblStaticID.TabIndex = 3
        lblStaticID.Text = "ID Anggota:"
        ' 
        ' lblValueNama
        ' 
        lblValueNama.AutoSize = True
        lblValueNama.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblValueNama.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblValueNama.Location = New Point(296, 76)
        lblValueNama.Name = "lblValueNama"
        lblValueNama.Size = New Size(18, 28)
        lblValueNama.TabIndex = 2
        lblValueNama.Text = " "
        ' 
        ' lblStaticNama
        ' 
        lblStaticNama.AutoSize = True
        lblStaticNama.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStaticNama.ForeColor = Color.Gray
        lblStaticNama.Location = New Point(155, 82)
        lblStaticNama.Name = "lblStaticNama"
        lblStaticNama.Size = New Size(53, 19)
        lblStaticNama.TabIndex = 1
        lblStaticNama.Text = "Nama:"
        ' 
        ' PictureBoxFoto
        ' 
        PictureBoxFoto.BackColor = Color.WhiteSmoke
        PictureBoxFoto.BorderStyle = BorderStyle.FixedSingle
        PictureBoxFoto.Location = New Point(20, 75)
        PictureBoxFoto.Name = "PictureBoxFoto"
        PictureBoxFoto.Size = New Size(110, 140)
        PictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxFoto.TabIndex = 0
        PictureBoxFoto.TabStop = False
        ' 
        ' Form_Output
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(550, 301)
        Controls.Add(PanelKartu)
        Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form_Output"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kartu Komunitas Fans Golden State Warrior"
        PanelKartu.ResumeLayout(False)
        PanelKartu.PerformLayout()
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelKartu As System.Windows.Forms.Panel
    Friend WithEvents PictureBoxFoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblValueNama As System.Windows.Forms.Label
    Friend WithEvents lblStaticNama As System.Windows.Forms.Label
    Friend WithEvents lblValueHobby As System.Windows.Forms.Label
    Friend WithEvents lblStaticHobby As System.Windows.Forms.Label
    Friend WithEvents lblValueKontak As System.Windows.Forms.Label
    Friend WithEvents lblStaticKontak As System.Windows.Forms.Label
    Friend WithEvents lblValueKomunitas As System.Windows.Forms.Label
    Friend WithEvents lblStaticDivisi As System.Windows.Forms.Label
    Friend WithEvents lblValueID As System.Windows.Forms.Label
    Friend WithEvents lblStaticID As System.Windows.Forms.Label
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents btnTutup As Button
End Class