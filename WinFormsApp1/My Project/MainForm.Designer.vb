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
        LoginBtn = New Button()
        SuspendLayout()
        ' 
        ' RegisterBtn
        ' 
        RegisterBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RegisterBtn.Location = New Point(479, 328)
        RegisterBtn.Name = "RegisterBtn"
        RegisterBtn.Size = New Size(128, 64)
        RegisterBtn.TabIndex = 0
        RegisterBtn.Text = "Register"
        RegisterBtn.UseVisualStyleBackColor = True
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LoginBtn.Location = New Point(741, 328)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(128, 64)
        LoginBtn.TabIndex = 1
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(LoginBtn)
        Controls.Add(RegisterBtn)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "VendIT - Vending Machine Management System"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RegisterBtn As Button
    Friend WithEvents LoginBtn As Button
End Class
