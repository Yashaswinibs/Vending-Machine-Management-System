<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        LocationVM1 = New Button()
        VM1 = New GroupBox()
        VM1ViewPurchasesBtn = New Button()
        InteractBtnVM1 = New Button()
        VM3 = New GroupBox()
        Button1 = New Button()
        InteractBtnVM3 = New Button()
        LocationVM3 = New Button()
        VM4 = New GroupBox()
        Button5 = New Button()
        InteractBtnVM4 = New Button()
        LocationVM4 = New Button()
        VM2 = New GroupBox()
        Button8 = New Button()
        InteractBtnVM2 = New Button()
        LocationVM2 = New Button()
        VM5 = New GroupBox()
        Button11 = New Button()
        InteractBtnVM5 = New Button()
        LocationVM5 = New Button()
        VM6 = New GroupBox()
        Button14 = New Button()
        InteractBtnVM6 = New Button()
        LocationVM6 = New Button()
        GreetingLbl = New Label()
        LogOutBtn = New Button()
        VM1.SuspendLayout()
        VM3.SuspendLayout()
        VM4.SuspendLayout()
        VM2.SuspendLayout()
        VM5.SuspendLayout()
        VM6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(16, -87)
        Label1.Name = "Label1"
        Label1.Size = New Size(304, 54)
        Label1.TabIndex = 0
        Label1.Text = "Welcome Shakir"
        ' 
        ' LocationVM1
        ' 
        LocationVM1.BackColor = SystemColors.MenuHighlight
        LocationVM1.FlatStyle = FlatStyle.Popup
        LocationVM1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LocationVM1.ForeColor = SystemColors.ButtonFace
        LocationVM1.Location = New Point(28, 42)
        LocationVM1.Name = "LocationVM1"
        LocationVM1.Size = New Size(256, 128)
        LocationVM1.TabIndex = 2
        LocationVM1.Text = " "
        LocationVM1.UseVisualStyleBackColor = False
        ' 
        ' VM1
        ' 
        VM1.BackColor = SystemColors.GradientInactiveCaption
        VM1.Controls.Add(VM1ViewPurchasesBtn)
        VM1.Controls.Add(InteractBtnVM1)
        VM1.Controls.Add(LocationVM1)
        VM1.ForeColor = SystemColors.ActiveCaptionText
        VM1.Location = New Point(104, 86)
        VM1.Margin = New Padding(6)
        VM1.Name = "VM1"
        VM1.Size = New Size(320, 300)
        VM1.TabIndex = 3
        VM1.TabStop = False
        VM1.Text = "Vending Machine 1"
        ' 
        ' VM1ViewPurchasesBtn
        ' 
        VM1ViewPurchasesBtn.Location = New Point(28, 246)
        VM1ViewPurchasesBtn.Name = "VM1ViewPurchasesBtn"
        VM1ViewPurchasesBtn.Size = New Size(256, 32)
        VM1ViewPurchasesBtn.TabIndex = 4
        VM1ViewPurchasesBtn.Text = "View Purchases"
        VM1ViewPurchasesBtn.UseVisualStyleBackColor = True
        ' 
        ' InteractBtnVM1
        ' 
        InteractBtnVM1.Location = New Point(28, 199)
        InteractBtnVM1.Name = "InteractBtnVM1"
        InteractBtnVM1.Size = New Size(256, 32)
        InteractBtnVM1.TabIndex = 3
        InteractBtnVM1.Text = "Interact"
        InteractBtnVM1.UseVisualStyleBackColor = True
        ' 
        ' VM3
        ' 
        VM3.BackColor = SystemColors.GradientInactiveCaption
        VM3.Controls.Add(Button1)
        VM3.Controls.Add(InteractBtnVM3)
        VM3.Controls.Add(LocationVM3)
        VM3.ForeColor = SystemColors.ActiveCaptionText
        VM3.Location = New Point(925, 86)
        VM3.Margin = New Padding(6)
        VM3.Name = "VM3"
        VM3.Size = New Size(320, 300)
        VM3.TabIndex = 5
        VM3.TabStop = False
        VM3.Text = "Vending Machine 3"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(28, 246)
        Button1.Name = "Button1"
        Button1.Size = New Size(256, 32)
        Button1.TabIndex = 4
        Button1.Text = "View Purchases"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' InteractBtnVM3
        ' 
        InteractBtnVM3.Location = New Point(28, 199)
        InteractBtnVM3.Name = "InteractBtnVM3"
        InteractBtnVM3.Size = New Size(256, 32)
        InteractBtnVM3.TabIndex = 3
        InteractBtnVM3.Text = "Interact"
        InteractBtnVM3.UseVisualStyleBackColor = True
        ' 
        ' LocationVM3
        ' 
        LocationVM3.BackColor = SystemColors.MenuHighlight
        LocationVM3.FlatStyle = FlatStyle.Popup
        LocationVM3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LocationVM3.ForeColor = SystemColors.ButtonFace
        LocationVM3.Location = New Point(28, 42)
        LocationVM3.Name = "LocationVM3"
        LocationVM3.Size = New Size(256, 128)
        LocationVM3.TabIndex = 2
        LocationVM3.Text = " " & vbCrLf
        LocationVM3.UseVisualStyleBackColor = False
        ' 
        ' VM4
        ' 
        VM4.BackColor = SystemColors.GradientInactiveCaption
        VM4.Controls.Add(Button5)
        VM4.Controls.Add(InteractBtnVM4)
        VM4.Controls.Add(LocationVM4)
        VM4.ForeColor = SystemColors.ActiveCaptionText
        VM4.Location = New Point(104, 409)
        VM4.Name = "VM4"
        VM4.Size = New Size(320, 300)
        VM4.TabIndex = 5
        VM4.TabStop = False
        VM4.Text = "Vending Machine 4"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(28, 246)
        Button5.Name = "Button5"
        Button5.Size = New Size(256, 32)
        Button5.TabIndex = 4
        Button5.Text = "View Purchases"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' InteractBtnVM4
        ' 
        InteractBtnVM4.Location = New Point(28, 199)
        InteractBtnVM4.Name = "InteractBtnVM4"
        InteractBtnVM4.Size = New Size(256, 32)
        InteractBtnVM4.TabIndex = 3
        InteractBtnVM4.Text = "Interact"
        InteractBtnVM4.UseVisualStyleBackColor = True
        ' 
        ' LocationVM4
        ' 
        LocationVM4.BackColor = SystemColors.MenuHighlight
        LocationVM4.FlatStyle = FlatStyle.Popup
        LocationVM4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LocationVM4.ForeColor = SystemColors.ButtonFace
        LocationVM4.Location = New Point(28, 42)
        LocationVM4.Name = "LocationVM4"
        LocationVM4.Size = New Size(256, 128)
        LocationVM4.TabIndex = 2
        LocationVM4.Text = " "
        LocationVM4.UseVisualStyleBackColor = False
        ' 
        ' VM2
        ' 
        VM2.BackColor = SystemColors.GradientInactiveCaption
        VM2.Controls.Add(Button8)
        VM2.Controls.Add(InteractBtnVM2)
        VM2.Controls.Add(LocationVM2)
        VM2.ForeColor = SystemColors.ActiveCaptionText
        VM2.Location = New Point(522, 86)
        VM2.Margin = New Padding(6)
        VM2.Name = "VM2"
        VM2.Size = New Size(320, 300)
        VM2.TabIndex = 5
        VM2.TabStop = False
        VM2.Text = "Vending Machine 2"
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(28, 246)
        Button8.Name = "Button8"
        Button8.Size = New Size(256, 32)
        Button8.TabIndex = 4
        Button8.Text = "View Purchases"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' InteractBtnVM2
        ' 
        InteractBtnVM2.Location = New Point(28, 199)
        InteractBtnVM2.Name = "InteractBtnVM2"
        InteractBtnVM2.Size = New Size(256, 32)
        InteractBtnVM2.TabIndex = 3
        InteractBtnVM2.Text = "Interact"
        InteractBtnVM2.UseVisualStyleBackColor = True
        ' 
        ' LocationVM2
        ' 
        LocationVM2.BackColor = SystemColors.MenuHighlight
        LocationVM2.FlatStyle = FlatStyle.Popup
        LocationVM2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LocationVM2.ForeColor = SystemColors.ButtonFace
        LocationVM2.Location = New Point(28, 42)
        LocationVM2.Name = "LocationVM2"
        LocationVM2.Size = New Size(256, 128)
        LocationVM2.TabIndex = 2
        LocationVM2.UseVisualStyleBackColor = False
        ' 
        ' VM5
        ' 
        VM5.BackColor = SystemColors.GradientInactiveCaption
        VM5.Controls.Add(Button11)
        VM5.Controls.Add(InteractBtnVM5)
        VM5.Controls.Add(LocationVM5)
        VM5.ForeColor = SystemColors.ActiveCaptionText
        VM5.Location = New Point(522, 409)
        VM5.Name = "VM5"
        VM5.Size = New Size(320, 300)
        VM5.TabIndex = 6
        VM5.TabStop = False
        VM5.Text = "Vending Machine 5"
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(28, 246)
        Button11.Name = "Button11"
        Button11.Size = New Size(256, 32)
        Button11.TabIndex = 4
        Button11.Text = "View Purchases"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' InteractBtnVM5
        ' 
        InteractBtnVM5.Location = New Point(28, 199)
        InteractBtnVM5.Name = "InteractBtnVM5"
        InteractBtnVM5.Size = New Size(256, 32)
        InteractBtnVM5.TabIndex = 3
        InteractBtnVM5.Text = "Interact"
        InteractBtnVM5.UseVisualStyleBackColor = True
        ' 
        ' LocationVM5
        ' 
        LocationVM5.BackColor = SystemColors.MenuHighlight
        LocationVM5.FlatStyle = FlatStyle.Popup
        LocationVM5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LocationVM5.ForeColor = SystemColors.ButtonFace
        LocationVM5.Location = New Point(28, 42)
        LocationVM5.Name = "LocationVM5"
        LocationVM5.Size = New Size(256, 128)
        LocationVM5.TabIndex = 2
        LocationVM5.Text = " " & vbCrLf
        LocationVM5.UseVisualStyleBackColor = False
        ' 
        ' VM6
        ' 
        VM6.BackColor = SystemColors.GradientInactiveCaption
        VM6.Controls.Add(Button14)
        VM6.Controls.Add(InteractBtnVM6)
        VM6.Controls.Add(LocationVM6)
        VM6.ForeColor = SystemColors.ActiveCaptionText
        VM6.Location = New Point(925, 409)
        VM6.Name = "VM6"
        VM6.Size = New Size(320, 300)
        VM6.TabIndex = 7
        VM6.TabStop = False
        VM6.Text = "Vending Machine 6"
        ' 
        ' Button14
        ' 
        Button14.Location = New Point(28, 246)
        Button14.Name = "Button14"
        Button14.Size = New Size(256, 32)
        Button14.TabIndex = 4
        Button14.Text = "View Purchases"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' InteractBtnVM6
        ' 
        InteractBtnVM6.Location = New Point(28, 199)
        InteractBtnVM6.Name = "InteractBtnVM6"
        InteractBtnVM6.Size = New Size(256, 32)
        InteractBtnVM6.TabIndex = 3
        InteractBtnVM6.Text = "Interact"
        InteractBtnVM6.UseVisualStyleBackColor = True
        ' 
        ' LocationVM6
        ' 
        LocationVM6.BackColor = SystemColors.MenuHighlight
        LocationVM6.FlatStyle = FlatStyle.Popup
        LocationVM6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LocationVM6.ForeColor = SystemColors.ButtonFace
        LocationVM6.Location = New Point(28, 42)
        LocationVM6.Name = "LocationVM6"
        LocationVM6.Size = New Size(256, 128)
        LocationVM6.TabIndex = 2
        LocationVM6.Text = " " & vbCrLf
        LocationVM6.UseVisualStyleBackColor = False
        ' 
        ' GreetingLbl
        ' 
        GreetingLbl.AutoSize = True
        GreetingLbl.Font = New Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        GreetingLbl.Location = New Point(24, 20)
        GreetingLbl.Name = "GreetingLbl"
        GreetingLbl.Size = New Size(250, 38)
        GreetingLbl.TabIndex = 5
        GreetingLbl.Text = "Welcome, Shakir"
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.Location = New Point(1214, 20)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(100, 32)
        LogOutBtn.TabIndex = 8
        LogOutBtn.Text = "Log Out"
        LogOutBtn.UseVisualStyleBackColor = True
        ' 
        ' HomeForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1348, 721)
        Controls.Add(LogOutBtn)
        Controls.Add(GreetingLbl)
        Controls.Add(VM6)
        Controls.Add(VM5)
        Controls.Add(VM3)
        Controls.Add(VM4)
        Controls.Add(VM2)
        Controls.Add(VM1)
        Controls.Add(Label1)
        Name = "HomeForm"
        Text = "VendIT - Home"
        VM1.ResumeLayout(False)
        VM3.ResumeLayout(False)
        VM4.ResumeLayout(False)
        VM2.ResumeLayout(False)
        VM5.ResumeLayout(False)
        VM6.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LocationVM1 As Button
    Friend WithEvents VM1 As GroupBox
    Friend WithEvents VM1ViewPurchasesBtn As Button
    Friend WithEvents InteractBtnVM1 As Button
    Friend WithEvents VM3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents InteractBtnVM3 As Button
    Friend WithEvents LocationVM3 As Button
    Friend WithEvents VM4 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents InteractBtnVM4 As Button
    Friend WithEvents LocationVM4 As Button
    Friend WithEvents VM2 As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents InteractBtnVM2 As Button
    Friend WithEvents LocationVM2 As Button
    Friend WithEvents VM5 As GroupBox
    Friend WithEvents Button11 As Button
    Friend WithEvents InteractBtnVM5 As Button
    Friend WithEvents LocationVM5 As Button
    Friend WithEvents VM6 As GroupBox
    Friend WithEvents Button14 As Button
    Friend WithEvents InteractBtnVM6 As Button
    Friend WithEvents LocationVM6 As Button
    Friend WithEvents GreetingLbl As Label
    Friend WithEvents LogOutBtn As Button
End Class
