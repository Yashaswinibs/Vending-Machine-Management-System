<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        AddQtyBtn = New Button()
        RemQtyBtn = New Button()
        SelectedQtyLbl = New Label()
        ProdImg = New PictureBox()
        prodLbl = New Label()
        CType(ProdImg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AddQtyBtn
        ' 
        AddQtyBtn.Location = New Point(267, 328)
        AddQtyBtn.Name = "AddQtyBtn"
        AddQtyBtn.Size = New Size(94, 29)
        AddQtyBtn.TabIndex = 2
        AddQtyBtn.Text = "Add"
        AddQtyBtn.UseVisualStyleBackColor = True
        ' 
        ' RemQtyBtn
        ' 
        RemQtyBtn.Location = New Point(24, 328)
        RemQtyBtn.Name = "RemQtyBtn"
        RemQtyBtn.Size = New Size(94, 29)
        RemQtyBtn.TabIndex = 3
        RemQtyBtn.Text = "Remove"
        RemQtyBtn.UseVisualStyleBackColor = True
        ' 
        ' SelectedQtyLbl
        ' 
        SelectedQtyLbl.AutoSize = True
        SelectedQtyLbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SelectedQtyLbl.Location = New Point(361, 281)
        SelectedQtyLbl.Name = "SelectedQtyLbl"
        SelectedQtyLbl.Size = New Size(0, 28)
        SelectedQtyLbl.TabIndex = 4
        ' 
        ' ProdImg
        ' 
        ProdImg.BackgroundImageLayout = ImageLayout.Center
        ProdImg.Location = New Point(24, 27)
        ProdImg.Name = "ProdImg"
        ProdImg.Size = New Size(337, 251)
        ProdImg.TabIndex = 5
        ProdImg.TabStop = False
        ' 
        ' prodLbl
        ' 
        prodLbl.AutoSize = True
        prodLbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        prodLbl.Location = New Point(24, 281)
        prodLbl.Name = "prodLbl"
        prodLbl.Size = New Size(138, 28)
        prodLbl.TabIndex = 6
        prodLbl.Text = "Product Name"
        ' 
        ' Product
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        Controls.Add(prodLbl)
        Controls.Add(ProdImg)
        Controls.Add(SelectedQtyLbl)
        Controls.Add(RemQtyBtn)
        Controls.Add(AddQtyBtn)
        Name = "Product"
        Size = New Size(384, 384)
        CType(ProdImg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents AddQtyBtn As Button
    Friend WithEvents RemQtyBtn As Button
    Friend WithEvents SelectedQtyLbl As Label
    Friend WithEvents ProdImg As PictureBox
    Friend WithEvents prodLbl As Label
End Class
