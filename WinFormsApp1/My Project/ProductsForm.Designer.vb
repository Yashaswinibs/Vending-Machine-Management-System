<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsForm
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
        Panel1 = New Panel()
        Label1 = New Label()
        Product1 = New Product()
        Product2 = New Product()
        Product3 = New Product()
        Product4 = New Product()
        Product5 = New Product()
        Product6 = New Product()
        Product7 = New Product()
        Product8 = New Product()
        Product9 = New Product()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(Product7)
        Panel1.Controls.Add(Product8)
        Panel1.Controls.Add(Product9)
        Panel1.Controls.Add(Product4)
        Panel1.Controls.Add(Product5)
        Panel1.Controls.Add(Product6)
        Panel1.Controls.Add(Product3)
        Panel1.Controls.Add(Product2)
        Panel1.Controls.Add(Product1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 100)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1348, 573)
        Panel1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, -63)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 38)
        Label1.TabIndex = 0
        Label1.Text = "VendIT - Products"
        ' 
        ' Product1
        ' 
        Product1.BackColor = SystemColors.ControlLightLight
        Product1.Location = New Point(33, 33)
        Product1.Name = "Product1"
        Product1.Size = New Size(384, 384)
        Product1.TabIndex = 1
        ' 
        ' Product2
        ' 
        Product2.BackColor = SystemColors.ControlLightLight
        Product2.Location = New Point(486, 33)
        Product2.Name = "Product2"
        Product2.Size = New Size(384, 384)
        Product2.TabIndex = 2
        ' 
        ' Product3
        ' 
        Product3.BackColor = SystemColors.ControlLightLight
        Product3.Location = New Point(930, 33)
        Product3.Name = "Product3"
        Product3.Size = New Size(384, 384)
        Product3.TabIndex = 3
        ' 
        ' Product4
        ' 
        Product4.BackColor = SystemColors.ControlLightLight
        Product4.Location = New Point(930, 476)
        Product4.Name = "Product4"
        Product4.Size = New Size(384, 384)
        Product4.TabIndex = 6
        ' 
        ' Product5
        ' 
        Product5.BackColor = SystemColors.ControlLightLight
        Product5.Location = New Point(486, 476)
        Product5.Name = "Product5"
        Product5.Size = New Size(384, 384)
        Product5.TabIndex = 5
        ' 
        ' Product6
        ' 
        Product6.BackColor = SystemColors.ControlLightLight
        Product6.Location = New Point(33, 476)
        Product6.Name = "Product6"
        Product6.Size = New Size(384, 384)
        Product6.TabIndex = 4
        ' 
        ' Product7
        ' 
        Product7.BackColor = SystemColors.ControlLightLight
        Product7.Location = New Point(930, 920)
        Product7.Name = "Product7"
        Product7.Size = New Size(384, 384)
        Product7.TabIndex = 9
        ' 
        ' Product8
        ' 
        Product8.BackColor = SystemColors.ControlLightLight
        Product8.Location = New Point(486, 920)
        Product8.Name = "Product8"
        Product8.Size = New Size(384, 384)
        Product8.TabIndex = 8
        ' 
        ' Product9
        ' 
        Product9.BackColor = SystemColors.ControlLightLight
        Product9.Location = New Point(33, 920)
        Product9.Name = "Product9"
        Product9.Size = New Size(384, 384)
        Product9.TabIndex = 7
        ' 
        ' ProductsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 673)
        Controls.Add(Panel1)
        Name = "ProductsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "VendIT - Products"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Product7 As Product
    Friend WithEvents Product8 As Product
    Friend WithEvents Product9 As Product
    Friend WithEvents Product4 As Product
    Friend WithEvents Product5 As Product
    Friend WithEvents Product6 As Product
    Friend WithEvents Product3 As Product
    Friend WithEvents Product2 As Product
    Friend WithEvents Product1 As Product
End Class
