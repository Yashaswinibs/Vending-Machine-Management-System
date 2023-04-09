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
        Label1 = New Label()
        Label2 = New Label()
        UsernameTB = New TextBox()
        PasswordTB = New TextBox()
        ConfirmPasswordTB = New TextBox()
        Label3 = New Label()
        RegisterBtn = New Button()
        backLink = New LinkLabel()
        Label4 = New Label()
        FullNameTB = New TextBox()
        PromoOfferYes = New RadioButton()
        PromoOfferNo = New RadioButton()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(429, 227)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 28)
        Label1.TabIndex = 100
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(429, 277)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 28)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' UsernameTB
        ' 
        UsernameTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameTB.Location = New Point(645, 224)
        UsernameTB.Name = "UsernameTB"
        UsernameTB.Size = New Size(275, 34)
        UsernameTB.TabIndex = 2
        ' 
        ' PasswordTB
        ' 
        PasswordTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordTB.Location = New Point(645, 274)
        PasswordTB.Name = "PasswordTB"
        PasswordTB.Size = New Size(275, 34)
        PasswordTB.TabIndex = 3
        PasswordTB.UseSystemPasswordChar = True
        ' 
        ' ConfirmPasswordTB
        ' 
        ConfirmPasswordTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ConfirmPasswordTB.Location = New Point(645, 346)
        ConfirmPasswordTB.Name = "ConfirmPasswordTB"
        ConfirmPasswordTB.Size = New Size(275, 34)
        ConfirmPasswordTB.TabIndex = 4
        ConfirmPasswordTB.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(429, 349)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 28)
        Label3.TabIndex = 5
        Label3.Text = "Confirm Password"
        ' 
        ' RegisterBtn
        ' 
        RegisterBtn.Location = New Point(645, 499)
        RegisterBtn.Name = "RegisterBtn"
        RegisterBtn.Size = New Size(128, 48)
        RegisterBtn.TabIndex = 6
        RegisterBtn.Text = "Register"
        RegisterBtn.UseVisualStyleBackColor = True
        ' 
        ' backLink
        ' 
        backLink.AutoSize = True
        backLink.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        backLink.Location = New Point(1250, 20)
        backLink.Name = "backLink"
        backLink.Size = New Size(71, 28)
        backLink.TabIndex = 8
        backLink.TabStop = True
        backLink.Text = "< Back"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(429, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 28)
        Label4.TabIndex = 9
        Label4.Text = "Full Name"
        ' 
        ' FullNameTB
        ' 
        FullNameTB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FullNameTB.Location = New Point(645, 173)
        FullNameTB.Name = "FullNameTB"
        FullNameTB.Size = New Size(275, 34)
        FullNameTB.TabIndex = 1
        ' 
        ' PromoOfferYes
        ' 
        PromoOfferYes.AutoSize = True
        PromoOfferYes.Checked = True
        PromoOfferYes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PromoOfferYes.Location = New Point(689, 420)
        PromoOfferYes.Name = "PromoOfferYes"
        PromoOfferYes.Size = New Size(60, 32)
        PromoOfferYes.TabIndex = 101
        PromoOfferYes.TabStop = True
        PromoOfferYes.Text = "Yes"
        PromoOfferYes.UseVisualStyleBackColor = True
        ' 
        ' PromoOfferNo
        ' 
        PromoOfferNo.AutoSize = True
        PromoOfferNo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PromoOfferNo.Location = New Point(790, 420)
        PromoOfferNo.Name = "PromoOfferNo"
        PromoOfferNo.Size = New Size(60, 32)
        PromoOfferNo.TabIndex = 102
        PromoOfferNo.Text = "No"
        PromoOfferNo.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(429, 420)
        Label5.Name = "Label5"
        Label5.Size = New Size(168, 28)
        Label5.TabIndex = 103
        Label5.Text = "Avail Promo Offer"
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(Label5)
        Controls.Add(PromoOfferNo)
        Controls.Add(PromoOfferYes)
        Controls.Add(FullNameTB)
        Controls.Add(Label4)
        Controls.Add(backLink)
        Controls.Add(RegisterBtn)
        Controls.Add(Label3)
        Controls.Add(ConfirmPasswordTB)
        Controls.Add(PasswordTB)
        Controls.Add(UsernameTB)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "VendIT - Registration"
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents PromoOfferYes As RadioButton
    Friend WithEvents PromoOfferNo As RadioButton
    Friend WithEvents Label5 As Label
End Class
