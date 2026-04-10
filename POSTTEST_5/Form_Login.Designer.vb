<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Login
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
        lblSubHeader = New Label()
        Panel4 = New Panel()
        lblUsername = New Label()
        Label1 = New Label()
        Panel5 = New Panel()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        btnKeluar = New Button()
        Panel1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(lblHeader)
        Panel1.Location = New Point(1, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(553, 89)
        Panel1.TabIndex = 0
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(38, 24)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(355, 38)
        lblHeader.TabIndex = 2
        lblHeader.Text = "Welcome to Stocka App..."
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Location = New Point(1, 95)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(553, 5)
        Panel2.TabIndex = 1
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubHeader.ForeColor = Color.Black
        lblSubHeader.Location = New Point(39, 117)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(300, 28)
        lblSubHeader.TabIndex = 3
        lblSubHeader.Text = "Silahkan login terlebih dahulu..."
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.SteelBlue
        Panel4.Location = New Point(0, 321)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(560, 5)
        Panel4.TabIndex = 2
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.Black
        lblUsername.Location = New Point(39, 169)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(104, 28)
        lblUsername.TabIndex = 4
        lblUsername.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(39, 230)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 28)
        Label1.TabIndex = 5
        Label1.Text = "Password"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.MidnightBlue
        Panel5.Location = New Point(0, 326)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(560, 19)
        Panel5.TabIndex = 3
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(184, 173)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(319, 27)
        txtUsername.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(184, 234)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(319, 27)
        txtPassword.TabIndex = 7
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.MidnightBlue
        btnLogin.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(409, 277)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 38)
        btnLogin.TabIndex = 8
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.MidnightBlue
        btnKeluar.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeluar.ForeColor = Color.White
        btnKeluar.Location = New Point(39, 277)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 38)
        btnKeluar.TabIndex = 9
        btnKeluar.Text = "Close"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' Form_Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(555, 345)
        Controls.Add(btnKeluar)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Panel5)
        Controls.Add(Label1)
        Controls.Add(lblUsername)
        Controls.Add(Panel4)
        Controls.Add(lblSubHeader)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form_Login"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblSubHeader As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnKeluar As Button
End Class
