<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Size
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
        Panel1 = New Panel()
        lblHeader = New Label()
        Panel2 = New Panel()
        txtSku = New TextBox()
        dgvPakaian = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        lblSku = New Label()
        Panel5 = New Panel()
        Panel3 = New Panel()
        lblNamaPakaian = New Label()
        lblUkuran = New Label()
        lblHarga = New Label()
        lblStok = New Label()
        txtHarga = New TextBox()
        txtStok = New TextBox()
        txtNamaPakaian = New TextBox()
        cbUkuran = New ComboBox()
        lblCari = New Label()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnClear = New Button()
        btnKeluar = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        menuStrip = New MenuStrip()
        MainToolStripMenuItem = New ToolStripMenuItem()
        ProductToolStripMenuItem = New ToolStripMenuItem()
        SizeToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        Panel1.SuspendLayout()
        CType(dgvPakaian, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        menuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(lblHeader)
        Panel1.Location = New Point(1, 35)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1287, 89)
        Panel1.TabIndex = 1
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(13, 24)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(104, 38)
        lblHeader.TabIndex = 2
        lblHeader.Text = "Stocka"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Location = New Point(1, 124)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1287, 5)
        Panel2.TabIndex = 3
        ' 
        ' txtSku
        ' 
        txtSku.Location = New Point(159, 147)
        txtSku.MaxLength = 15
        txtSku.Name = "txtSku"
        txtSku.Size = New Size(232, 27)
        txtSku.TabIndex = 5
        ' 
        ' dgvPakaian
        ' 
        dgvPakaian.AllowUserToResizeColumns = False
        dgvPakaian.AllowUserToResizeRows = False
        dgvPakaian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPakaian.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgvPakaian.Location = New Point(440, 194)
        dgvPakaian.Name = "dgvPakaian"
        dgvPakaian.RowHeadersWidth = 51
        dgvPakaian.Size = New Size(804, 319)
        dgvPakaian.TabIndex = 6
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "sku"
        Column1.HeaderText = "SKU"
        Column1.MaxInputLength = 15
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "nama"
        Column2.HeaderText = "Nama Pakaian"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 300
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "ukuran"
        Column3.HeaderText = "Ukuran"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 75
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column4.DataPropertyName = "harga"
        Column4.HeaderText = "Harga"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column5.DataPropertyName = "stok"
        Column5.HeaderText = "Stok"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' lblSku
        ' 
        lblSku.AutoSize = True
        lblSku.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblSku.ForeColor = Color.Black
        lblSku.Location = New Point(14, 149)
        lblSku.Name = "lblSku"
        lblSku.Size = New Size(46, 25)
        lblSku.TabIndex = 7
        lblSku.Text = "SKU"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.MidnightBlue
        Panel5.Location = New Point(0, 528)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1287, 19)
        Panel5.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.SteelBlue
        Panel3.Location = New Point(1, 528)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1287, 5)
        Panel3.TabIndex = 4
        ' 
        ' lblNamaPakaian
        ' 
        lblNamaPakaian.AutoSize = True
        lblNamaPakaian.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblNamaPakaian.ForeColor = Color.Black
        lblNamaPakaian.Location = New Point(14, 197)
        lblNamaPakaian.Name = "lblNamaPakaian"
        lblNamaPakaian.Size = New Size(127, 25)
        lblNamaPakaian.TabIndex = 8
        lblNamaPakaian.Text = "Nama Pakaian"
        ' 
        ' lblUkuran
        ' 
        lblUkuran.AutoSize = True
        lblUkuran.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblUkuran.ForeColor = Color.Black
        lblUkuran.Location = New Point(14, 249)
        lblUkuran.Name = "lblUkuran"
        lblUkuran.Size = New Size(72, 25)
        lblUkuran.TabIndex = 9
        lblUkuran.Text = "Ukuran"
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblHarga.ForeColor = Color.Black
        lblHarga.Location = New Point(14, 307)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(61, 25)
        lblHarga.TabIndex = 10
        lblHarga.Text = "Harga"
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblStok.ForeColor = Color.Black
        lblStok.Location = New Point(14, 363)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(48, 25)
        lblStok.TabIndex = 11
        lblStok.Text = "Stok"
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(159, 305)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(232, 27)
        txtHarga.TabIndex = 12
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(159, 361)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(232, 27)
        txtStok.TabIndex = 13
        ' 
        ' txtNamaPakaian
        ' 
        txtNamaPakaian.Location = New Point(159, 195)
        txtNamaPakaian.Name = "txtNamaPakaian"
        txtNamaPakaian.Size = New Size(232, 27)
        txtNamaPakaian.TabIndex = 14
        ' 
        ' cbUkuran
        ' 
        cbUkuran.FormattingEnabled = True
        cbUkuran.Items.AddRange(New Object() {"25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "S", "M", "L", "XL", "XXL", "XXXL"})
        cbUkuran.Location = New Point(159, 250)
        cbUkuran.Name = "cbUkuran"
        cbUkuran.Size = New Size(232, 28)
        cbUkuran.TabIndex = 15
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblCari.ForeColor = Color.Black
        lblCari.Location = New Point(440, 146)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(111, 25)
        lblCari.TabIndex = 16
        lblCari.Text = "Cari Pakaian"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(583, 147)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(661, 27)
        txtSearch.TabIndex = 17
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(14, 425)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 18
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(297, 425)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 19
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(159, 425)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 20
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(14, 475)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 21
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(297, 475)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 22
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' menuStrip
        ' 
        menuStrip.BackColor = Color.MidnightBlue
        menuStrip.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuStrip.ImageScalingSize = New Size(20, 20)
        menuStrip.Items.AddRange(New ToolStripItem() {MainToolStripMenuItem, ProductToolStripMenuItem, SizeToolStripMenuItem, LogOutToolStripMenuItem})
        menuStrip.Location = New Point(0, 0)
        menuStrip.Name = "menuStrip"
        menuStrip.Size = New Size(1261, 31)
        menuStrip.TabIndex = 24
        menuStrip.Text = "MenuStrip1"
        ' 
        ' MainToolStripMenuItem
        ' 
        MainToolStripMenuItem.ForeColor = Color.White
        MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        MainToolStripMenuItem.Size = New Size(63, 27)
        MainToolStripMenuItem.Text = "Main"
        ' 
        ' ProductToolStripMenuItem
        ' 
        ProductToolStripMenuItem.ForeColor = Color.White
        ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        ProductToolStripMenuItem.Size = New Size(84, 27)
        ProductToolStripMenuItem.Text = "Product"
        ' 
        ' SizeToolStripMenuItem
        ' 
        SizeToolStripMenuItem.ForeColor = Color.White
        SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        SizeToolStripMenuItem.Size = New Size(54, 27)
        SizeToolStripMenuItem.Text = "Size"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.ForeColor = Color.White
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(86, 27)
        LogOutToolStripMenuItem.Text = "Log Out"
        ' 
        ' Form_Product
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1261, 546)
        Controls.Add(menuStrip)
        Controls.Add(btnKeluar)
        Controls.Add(btnClear)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(lblCari)
        Controls.Add(cbUkuran)
        Controls.Add(txtNamaPakaian)
        Controls.Add(txtStok)
        Controls.Add(txtHarga)
        Controls.Add(lblStok)
        Controls.Add(lblHarga)
        Controls.Add(lblUkuran)
        Controls.Add(lblNamaPakaian)
        Controls.Add(Panel3)
        Controls.Add(Panel5)
        Controls.Add(lblSku)
        Controls.Add(dgvPakaian)
        Controls.Add(txtSku)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form_Size"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form_Size"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvPakaian, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        menuStrip.ResumeLayout(False)
        menuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSku As TextBox
    Friend WithEvents dgvPakaian As DataGridView
    Friend WithEvents lblSku As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNamaPakaian As Label
    Friend WithEvents lblUkuran As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblStok As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtNamaPakaian As TextBox
    Friend WithEvents cbUkuran As ComboBox
    Friend WithEvents lblCari As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
End Class
