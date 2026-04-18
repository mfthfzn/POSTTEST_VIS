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
        txtIdUkuran = New TextBox()
        dgvUkuran = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        lblIdUkuran = New Label()
        Panel5 = New Panel()
        Panel3 = New Panel()
        lblUkuran = New Label()
        txtUkuran = New TextBox()
        lblCariUkuran = New Label()
        txtSearchUkuran = New TextBox()
        btnSimpan = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnClear = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        menuStrip = New MenuStrip()
        ProductToolStripMenuItem = New ToolStripMenuItem()
        SizeToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        Panel1.SuspendLayout()
        CType(dgvUkuran, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Size = New Size(761, 89)
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
        ' txtIdUkuran
        ' 
        txtIdUkuran.Location = New Point(159, 147)
        txtIdUkuran.MaxLength = 3
        txtIdUkuran.Name = "txtIdUkuran"
        txtIdUkuran.Size = New Size(232, 27)
        txtIdUkuran.TabIndex = 5
        ' 
        ' dgvUkuran
        ' 
        dgvUkuran.AllowUserToResizeColumns = False
        dgvUkuran.AllowUserToResizeRows = False
        dgvUkuran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUkuran.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgvUkuran.Location = New Point(440, 194)
        dgvUkuran.Name = "dgvUkuran"
        dgvUkuran.RowHeadersWidth = 51
        dgvUkuran.Size = New Size(303, 139)
        dgvUkuran.TabIndex = 6
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "id"
        Column1.HeaderText = "ID ukuran"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "nama"
        Column2.HeaderText = "Ukuran"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' lblIdUkuran
        ' 
        lblIdUkuran.AutoSize = True
        lblIdUkuran.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblIdUkuran.ForeColor = Color.Black
        lblIdUkuran.Location = New Point(14, 149)
        lblIdUkuran.Name = "lblIdUkuran"
        lblIdUkuran.Size = New Size(93, 25)
        lblIdUkuran.TabIndex = 7
        lblIdUkuran.Text = "ID ukuran"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.MidnightBlue
        Panel5.Location = New Point(0, 356)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(764, 19)
        Panel5.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.SteelBlue
        Panel3.Location = New Point(1, 356)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(765, 5)
        Panel3.TabIndex = 4
        ' 
        ' lblUkuran
        ' 
        lblUkuran.AutoSize = True
        lblUkuran.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblUkuran.ForeColor = Color.Black
        lblUkuran.Location = New Point(14, 197)
        lblUkuran.Name = "lblUkuran"
        lblUkuran.Size = New Size(72, 25)
        lblUkuran.TabIndex = 8
        lblUkuran.Text = "Ukuran"
        ' 
        ' txtUkuran
        ' 
        txtUkuran.Location = New Point(159, 195)
        txtUkuran.Name = "txtUkuran"
        txtUkuran.Size = New Size(232, 27)
        txtUkuran.TabIndex = 14
        ' 
        ' lblCariUkuran
        ' 
        lblCariUkuran.AutoSize = True
        lblCariUkuran.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblCariUkuran.ForeColor = Color.Black
        lblCariUkuran.Location = New Point(440, 146)
        lblCariUkuran.Name = "lblCariUkuran"
        lblCariUkuran.Size = New Size(109, 25)
        lblCariUkuran.TabIndex = 16
        lblCariUkuran.Text = "Cari Ukuran"
        ' 
        ' txtSearchUkuran
        ' 
        txtSearchUkuran.Location = New Point(555, 147)
        txtSearchUkuran.Name = "txtSearchUkuran"
        txtSearchUkuran.Size = New Size(188, 27)
        txtSearchUkuran.TabIndex = 17
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(14, 254)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 18
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(297, 254)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 19
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(159, 254)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 20
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(14, 304)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 21
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' menuStrip
        ' 
        menuStrip.AutoSize = False
        menuStrip.BackColor = Color.MidnightBlue
        menuStrip.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuStrip.ImageScalingSize = New Size(20, 20)
        menuStrip.Items.AddRange(New ToolStripItem() {ProductToolStripMenuItem, SizeToolStripMenuItem, LogOutToolStripMenuItem})
        menuStrip.Location = New Point(0, 0)
        menuStrip.Name = "menuStrip"
        menuStrip.Size = New Size(763, 31)
        menuStrip.TabIndex = 24
        menuStrip.Text = "MenuStrip1"
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
        ' Form_Size
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(763, 375)
        Controls.Add(menuStrip)
        Controls.Add(btnClear)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearchUkuran)
        Controls.Add(lblCariUkuran)
        Controls.Add(txtUkuran)
        Controls.Add(lblUkuran)
        Controls.Add(Panel3)
        Controls.Add(Panel5)
        Controls.Add(lblIdUkuran)
        Controls.Add(dgvUkuran)
        Controls.Add(txtIdUkuran)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form_Size"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form_Size"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvUkuran, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        menuStrip.ResumeLayout(False)
        menuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtIdUkuran As TextBox
    Friend WithEvents dgvUkuran As DataGridView
    Friend WithEvents lblIdUkuran As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblUkuran As Label
    Friend WithEvents txtUkuran As TextBox
    Friend WithEvents lblCariUkuran As Label
    Friend WithEvents txtSearchUkuran As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
