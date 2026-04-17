<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        dgvPakaian = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Panel5 = New Panel()
        Panel3 = New Panel()
        lblCari = New Label()
        txtSearch = New TextBox()
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
        Panel1.Size = New Size(854, 89)
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
        Panel2.Size = New Size(855, 5)
        Panel2.TabIndex = 3
        ' 
        ' dgvPakaian
        ' 
        dgvPakaian.AllowUserToResizeColumns = False
        dgvPakaian.AllowUserToResizeRows = False
        dgvPakaian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPakaian.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgvPakaian.Location = New Point(25, 194)
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
        ' Panel5
        ' 
        Panel5.BackColor = Color.MidnightBlue
        Panel5.Location = New Point(0, 528)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(855, 19)
        Panel5.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.SteelBlue
        Panel3.Location = New Point(1, 528)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(855, 5)
        Panel3.TabIndex = 4
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblCari.ForeColor = Color.Black
        lblCari.Location = New Point(25, 146)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(111, 25)
        lblCari.TabIndex = 16
        lblCari.Text = "Cari Pakaian"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(168, 147)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(661, 27)
        txtSearch.TabIndex = 17
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
        menuStrip.Size = New Size(855, 31)
        menuStrip.TabIndex = 23
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
        ' Form_Main
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(855, 546)
        Controls.Add(txtSearch)
        Controls.Add(lblCari)
        Controls.Add(Panel3)
        Controls.Add(Panel5)
        Controls.Add(dgvPakaian)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(menuStrip)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = menuStrip
        Name = "Form_Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form_Main"
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
    Friend WithEvents dgvPakaian As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCari As Label
    Friend WithEvents txtSearch As TextBox
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
