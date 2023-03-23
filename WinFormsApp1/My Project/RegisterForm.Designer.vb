<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsernameTB = New System.Windows.Forms.TextBox()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RegisterBtn = New System.Windows.Forms.Button()
        Me.backLink = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FullNameTB = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(429, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 28)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(429, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'UsernameTB
        '
        Me.UsernameTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UsernameTB.Location = New System.Drawing.Point(645, 263)
        Me.UsernameTB.Name = "UsernameTB"
        Me.UsernameTB.Size = New System.Drawing.Size(275, 34)
        Me.UsernameTB.TabIndex = 2
        '
        'PasswordTB
        '
        Me.PasswordTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PasswordTB.Location = New System.Drawing.Point(645, 313)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.Size = New System.Drawing.Size(275, 34)
        Me.PasswordTB.TabIndex = 3
        Me.PasswordTB.UseSystemPasswordChar = True
        '
        'ConfirmPasswordTB
        '
        Me.ConfirmPasswordTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmPasswordTB.Location = New System.Drawing.Point(645, 385)
        Me.ConfirmPasswordTB.Name = "ConfirmPasswordTB"
        Me.ConfirmPasswordTB.Size = New System.Drawing.Size(275, 34)
        Me.ConfirmPasswordTB.TabIndex = 4
        Me.ConfirmPasswordTB.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(429, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirm Password"
        '
        'RegisterBtn
        '
        Me.RegisterBtn.Location = New System.Drawing.Point(610, 460)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Size = New System.Drawing.Size(128, 48)
        Me.RegisterBtn.TabIndex = 6
        Me.RegisterBtn.Text = "Register"
        Me.RegisterBtn.UseVisualStyleBackColor = True
        '
        'backLink
        '
        Me.backLink.AutoSize = True
        Me.backLink.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.backLink.Location = New System.Drawing.Point(1250, 20)
        Me.backLink.Name = "backLink"
        Me.backLink.Size = New System.Drawing.Size(71, 28)
        Me.backLink.TabIndex = 8
        Me.backLink.TabStop = True
        Me.backLink.Text = "< Back"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(429, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Full Name"
        '
        'FullNameTB
        '
        Me.FullNameTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FullNameTB.Location = New System.Drawing.Point(645, 212)
        Me.FullNameTB.Name = "FullNameTB"
        Me.FullNameTB.Size = New System.Drawing.Size(275, 34)
        Me.FullNameTB.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.FullNameTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.backLink)
        Me.Controls.Add(Me.RegisterBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ConfirmPasswordTB)
        Me.Controls.Add(Me.PasswordTB)
        Me.Controls.Add(Me.UsernameTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UsernameTB As TextBox
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents ConfirmPasswordTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RegisterBtn As Button
    Friend WithEvents backLink As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents FullNameTB As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
