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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Title = New Label()
        Label2 = New Label()
        Label1 = New Label()
        predicateLabel = New Label()
        inputIP = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        AddButton = New Button()
        ResetButton = New Button()
        ipkField = New TextBox()
        messageError = New Label()
        msgError = New Label()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title.Location = New Point(280, 29)
        Title.Name = "Title"
        Title.Size = New Size(244, 38)
        Title.TabIndex = 0
        Title.Text = "Kalkulator IPK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(105, 238)
        Label2.Name = "Label2"
        Label2.Size = New Size(208, 38)
        Label2.TabIndex = 1
        Label2.Text = "IP Kumulatif"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(105, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 38)
        Label1.TabIndex = 2
        Label1.Text = "IP Per Semester"
        ' 
        ' predicateLabel
        ' 
        predicateLabel.AutoSize = True
        predicateLabel.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        predicateLabel.Location = New Point(408, 307)
        predicateLabel.Name = "predicateLabel"
        predicateLabel.Size = New Size(26, 38)
        predicateLabel.TabIndex = 3
        predicateLabel.Text = " "
        predicateLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' inputIP
        ' 
        inputIP.Location = New Point(406, 113)
        inputIP.Name = "inputIP"
        inputIP.Size = New Size(257, 27)
        inputIP.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(360, 238)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 38)
        Label5.TabIndex = 5
        Label5.Text = ":"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(360, 102)
        Label6.Name = "Label6"
        Label6.Size = New Size(28, 38)
        Label6.TabIndex = 6
        Label6.Text = ":"
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(406, 182)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(122, 39)
        AddButton.TabIndex = 7
        AddButton.Text = "Tambah"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' ResetButton
        ' 
        ResetButton.Location = New Point(541, 182)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(122, 39)
        ResetButton.TabIndex = 8
        ResetButton.Text = "Reset"
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' ipkField
        ' 
        ipkField.Location = New Point(406, 249)
        ipkField.Name = "ipkField"
        ipkField.ReadOnly = True
        ipkField.Size = New Size(257, 27)
        ipkField.TabIndex = 9
        ' 
        ' messageError
        ' 
        messageError.AutoSize = True
        messageError.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        messageError.Location = New Point(408, 143)
        messageError.Name = "messageError"
        messageError.Size = New Size(0, 23)
        messageError.TabIndex = 10
        ' 
        ' msgError
        ' 
        msgError.AutoSize = True
        msgError.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        msgError.Location = New Point(406, 143)
        msgError.Name = "msgError"
        msgError.Size = New Size(15, 23)
        msgError.TabIndex = 11
        msgError.Text = " "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(msgError)
        Controls.Add(messageError)
        Controls.Add(ipkField)
        Controls.Add(ResetButton)
        Controls.Add(AddButton)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(inputIP)
        Controls.Add(predicateLabel)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Title)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Kalkulator IPK"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents predicateLabel As Label
    Friend WithEvents inputIP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents ipkField As TextBox
    Friend WithEvents messageError As Label
    Friend WithEvents msgError As Label

End Class
