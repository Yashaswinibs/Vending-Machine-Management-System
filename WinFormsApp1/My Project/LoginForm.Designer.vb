<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        UsernameTB = New TextBox()
        PasswordTB = New TextBox()
        LoginBtn = New Button()
        backLink = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(463, 256)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 28)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(463, 325)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 28)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' UsernameTB
        ' 
        UsernameTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameTB.Location = New Point(611, 249)
        UsernameTB.Name = "UsernameTB"
        UsernameTB.Size = New Size(275, 34)
        UsernameTB.TabIndex = 2
        ' 
        ' PasswordTB
        ' 
        PasswordTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordTB.Location = New Point(611, 321)
        PasswordTB.Name = "PasswordTB"
        PasswordTB.Size = New Size(275, 34)
        PasswordTB.TabIndex = 3
        PasswordTB.UseSystemPasswordChar = True
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LoginBtn.Location = New Point(597, 423)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(128, 48)
        LoginBtn.TabIndex = 4
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = True
        ' 
        ' backLink
        ' 
        backLink.AutoSize = True
        backLink.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        backLink.Location = New Point(1250, 20)
        backLink.Name = "backLink"
        backLink.Size = New Size(71, 28)
        backLink.TabIndex = 9
        backLink.TabStop = True
        backLink.Text = "< Back"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(backLink)
        Controls.Add(LoginBtn)
        Controls.Add(PasswordTB)
        Controls.Add(UsernameTB)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "VendIT - Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UsernameTB As TextBox
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents backLink As LinkLabel
End Class
