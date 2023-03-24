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
        Me.ProductNameLabel = New System.Windows.Forms.Label()
        Me.AddQtyBtn = New System.Windows.Forms.Button()
        Me.RemQtyBtn = New System.Windows.Forms.Button()
        Me.SelectedQtyLbl = New System.Windows.Forms.Label()
        Me.ProdImg = New System.Windows.Forms.PictureBox()
        CType(Me.ProdImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductNameLabel
        '
        Me.ProductNameLabel.AutoSize = True
        Me.ProductNameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProductNameLabel.Location = New System.Drawing.Point(52, 199)
        Me.ProductNameLabel.Name = "ProductNameLabel"
        Me.ProductNameLabel.Size = New System.Drawing.Size(173, 28)
        Me.ProductNameLabel.TabIndex = 1
        Me.ProductNameLabel.Text = "LAYS CHIPS 80GM"
        '
        'AddQtyBtn
        '
        Me.AddQtyBtn.Location = New System.Drawing.Point(165, 246)
        Me.AddQtyBtn.Name = "AddQtyBtn"
        Me.AddQtyBtn.Size = New System.Drawing.Size(94, 29)
        Me.AddQtyBtn.TabIndex = 2
        Me.AddQtyBtn.Text = "Add"
        Me.AddQtyBtn.UseVisualStyleBackColor = True
        '
        'RemQtyBtn
        '
        Me.RemQtyBtn.Location = New System.Drawing.Point(41, 246)
        Me.RemQtyBtn.Name = "RemQtyBtn"
        Me.RemQtyBtn.Size = New System.Drawing.Size(94, 29)
        Me.RemQtyBtn.TabIndex = 3
        Me.RemQtyBtn.Text = "Remove"
        Me.RemQtyBtn.UseVisualStyleBackColor = True
        '
        'SelectedQtyLbl
        '
        Me.SelectedQtyLbl.AutoSize = True
        Me.SelectedQtyLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SelectedQtyLbl.Location = New System.Drawing.Point(231, 199)
        Me.SelectedQtyLbl.Name = "SelectedQtyLbl"
        Me.SelectedQtyLbl.Size = New System.Drawing.Size(17, 28)
        Me.SelectedQtyLbl.TabIndex = 4
        Me.SelectedQtyLbl.Text = " "
        '
        'ProdImg
        '
        Me.ProdImg.Location = New System.Drawing.Point(65, 24)
        Me.ProdImg.Name = "ProdImg"
        Me.ProdImg.Size = New System.Drawing.Size(160, 160)
        Me.ProdImg.TabIndex = 5
        Me.ProdImg.TabStop = False
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.ProdImg)
        Me.Controls.Add(Me.SelectedQtyLbl)
        Me.Controls.Add(Me.RemQtyBtn)
        Me.Controls.Add(Me.AddQtyBtn)
        Me.Controls.Add(Me.ProductNameLabel)
        Me.Name = "Product"
        Me.Size = New System.Drawing.Size(300, 300)
        CType(Me.ProdImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductNameLabel As Label
    Friend WithEvents AddQtyBtn As Button
    Friend WithEvents RemQtyBtn As Button
    Friend WithEvents SelectedQtyLbl As Label
    Friend WithEvents ProdImg As PictureBox
End Class
