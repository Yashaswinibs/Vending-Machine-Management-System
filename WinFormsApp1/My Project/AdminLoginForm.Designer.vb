<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLoginForm
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
        LoginBtn = New Button()
        PasswordTB = New TextBox()
        UsernameTB = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        backLink = New LinkLabel()
        SuspendLayout()
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Location = New Point(610, 439)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(128, 48)
        LoginBtn.TabIndex = 17
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = True
        ' 
        ' PasswordTB
        ' 
        PasswordTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordTB.Location = New Point(611, 349)
        PasswordTB.Name = "PasswordTB"
        PasswordTB.Size = New Size(275, 34)
        PasswordTB.TabIndex = 16
        PasswordTB.UseSystemPasswordChar = True
        ' 
        ' UsernameTB
        ' 
        UsernameTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameTB.Location = New Point(611, 277)
        UsernameTB.Name = "UsernameTB"
        UsernameTB.Size = New Size(275, 34)
        UsernameTB.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(463, 353)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 28)
        Label3.TabIndex = 14
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(463, 284)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 28)
        Label4.TabIndex = 13
        Label4.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(632, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(226, 46)
        Label2.TabIndex = 12
        Label2.Text = "Admin Login"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(490, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 42)
        Label1.TabIndex = 11
        Label1.Text = "VendIT - "
        ' 
        ' backLink
        ' 
        backLink.AutoSize = True
        backLink.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        backLink.Location = New Point(1232, 27)
        backLink.Name = "backLink"
        backLink.Size = New Size(71, 28)
        backLink.TabIndex = 18
        backLink.TabStop = True
        backLink.Text = "< Back"
        ' 
        ' AdminLoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(backLink)
        Controls.Add(LoginBtn)
        Controls.Add(PasswordTB)
        Controls.Add(UsernameTB)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AdminLoginForm"
        Text = "AdminLoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoginBtn As Button
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents UsernameTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents backLink As LinkLabel
End Class
