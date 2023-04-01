<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        RegisterBtn = New Button()
        custLoginBtn = New Button()
        admLoginBtn = New Button()
        VendIT = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' RegisterBtn
        ' 
        RegisterBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RegisterBtn.Location = New Point(159, 359)
        RegisterBtn.Name = "RegisterBtn"
        RegisterBtn.Size = New Size(128, 64)
        RegisterBtn.TabIndex = 0
        RegisterBtn.Text = "Register"
        RegisterBtn.UseVisualStyleBackColor = True
        ' 
        ' custLoginBtn
        ' 
        custLoginBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        custLoginBtn.Location = New Point(696, 359)
        custLoginBtn.Name = "custLoginBtn"
        custLoginBtn.Size = New Size(128, 64)
        custLoginBtn.TabIndex = 2
        custLoginBtn.Text = "Customer Login"
        custLoginBtn.UseVisualStyleBackColor = True
        ' 
        ' admLoginBtn
        ' 
        admLoginBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        admLoginBtn.Location = New Point(427, 359)
        admLoginBtn.Name = "admLoginBtn"
        admLoginBtn.Size = New Size(128, 64)
        admLoginBtn.TabIndex = 1
        admLoginBtn.Text = "Admin Login"
        admLoginBtn.UseVisualStyleBackColor = True
        ' 
        ' VendIT
        ' 
        VendIT.AutoSize = True
        VendIT.Font = New Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point)
        VendIT.Location = New Point(408, 43)
        VendIT.Name = "VendIT"
        VendIT.Size = New Size(166, 59)
        VendIT.TabIndex = 3
        VendIT.Text = "VendIT "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(290, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(534, 38)
        Label1.TabIndex = 4
        Label1.Text = "Vending Machine Management System"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 553)
        Controls.Add(Label1)
        Controls.Add(VendIT)
        Controls.Add(admLoginBtn)
        Controls.Add(custLoginBtn)
        Controls.Add(RegisterBtn)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "VendIT - Vending Machine Management System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RegisterBtn As Button
    Friend WithEvents custLoginBtn As Button
    Friend WithEvents admLoginBtn As Button
    Friend WithEvents VendIT As Label
    Friend WithEvents Label1 As Label
End Class
