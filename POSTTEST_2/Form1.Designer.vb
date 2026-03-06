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
        Label1 = New Label()
        Panel1 = New Panel()
        addButton = New Button()
        txtGenreBuku = New TextBox()
        txtJudulBuku = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        deleteButton = New Button()
        txtHapusBuku = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        dgvHasil = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 23)
        Label1.TabIndex = 0
        Label1.Text = "Tambah Buku"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(addButton)
        Panel1.Controls.Add(txtGenreBuku)
        Panel1.Controls.Add(txtJudulBuku)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(12, 26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(359, 185)
        Panel1.TabIndex = 1
        ' 
        ' addButton
        ' 
        addButton.Location = New Point(247, 142)
        addButton.Name = "addButton"
        addButton.Size = New Size(94, 29)
        addButton.TabIndex = 4
        addButton.Text = "Tambah"
        addButton.UseVisualStyleBackColor = True
        ' 
        ' txtGenreBuku
        ' 
        txtGenreBuku.Location = New Point(126, 90)
        txtGenreBuku.Name = "txtGenreBuku"
        txtGenreBuku.Size = New Size(215, 27)
        txtGenreBuku.TabIndex = 6
        ' 
        ' txtJudulBuku
        ' 
        txtJudulBuku.Location = New Point(126, 40)
        txtJudulBuku.Name = "txtJudulBuku"
        txtJudulBuku.Size = New Size(215, 27)
        txtJudulBuku.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 90)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 20)
        Label4.TabIndex = 5
        Label4.Text = "Genre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 4
        Label3.Text = "Judul Buku"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(deleteButton)
        Panel2.Controls.Add(txtHapusBuku)
        Panel2.Controls.Add(Label5)
        Panel2.ForeColor = SystemColors.ControlText
        Panel2.Location = New Point(414, 26)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(359, 185)
        Panel2.TabIndex = 2
        ' 
        ' deleteButton
        ' 
        deleteButton.Location = New Point(246, 142)
        deleteButton.Name = "deleteButton"
        deleteButton.Size = New Size(94, 29)
        deleteButton.TabIndex = 7
        deleteButton.Text = "Hapus"
        deleteButton.UseVisualStyleBackColor = True
        ' 
        ' txtHapusBuku
        ' 
        txtHapusBuku.Location = New Point(125, 40)
        txtHapusBuku.Name = "txtHapusBuku"
        txtHapusBuku.Size = New Size(215, 27)
        txtHapusBuku.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 20)
        Label5.TabIndex = 6
        Label5.Text = "Judul Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(439, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 23)
        Label2.TabIndex = 3
        Label2.Text = "Hapus Buku"
        ' 
        ' dgvHasil
        ' 
        dgvHasil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHasil.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgvHasil.Location = New Point(187, 250)
        dgvHasil.Name = "dgvHasil"
        dgvHasil.RowHeadersWidth = 51
        dgvHasil.Size = New Size(453, 188)
        dgvHasil.TabIndex = 4
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Judul Buku"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 200
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Genre"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 200
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(785, 450)
        Controls.Add(dgvHasil)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGenreBuku As TextBox
    Friend WithEvents txtJudulBuku As TextBox
    Friend WithEvents txtHapusBuku As TextBox
    Friend WithEvents addButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents dgvHasil As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn

End Class
