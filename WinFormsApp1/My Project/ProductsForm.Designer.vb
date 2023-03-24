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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Product4 = New VendIT.Product()
        Me.Product5 = New VendIT.Product()
        Me.Product6 = New VendIT.Product()
        Me.Product3 = New VendIT.Product()
        Me.Product2 = New VendIT.Product()
        Me.Product1 = New VendIT.Product()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Product4)
        Me.Panel1.Controls.Add(Me.Product5)
        Me.Panel1.Controls.Add(Me.Product6)
        Me.Panel1.Controls.Add(Me.Product3)
        Me.Panel1.Controls.Add(Me.Product2)
        Me.Panel1.Controls.Add(Me.Product1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1348, 673)
        Me.Panel1.TabIndex = 4
        '
        'Product4
        '
        Me.Product4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Product4.Location = New System.Drawing.Point(530, 458)
        Me.Product4.Name = "Product4"
        Me.Product4.Size = New System.Drawing.Size(300, 300)
        Me.Product4.TabIndex = 6
        '
        'Product5
        '
        Me.Product5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Product5.Location = New System.Drawing.Point(968, 458)
        Me.Product5.Name = "Product5"
        Me.Product5.Size = New System.Drawing.Size(300, 300)
        Me.Product5.TabIndex = 5
        '
        'Product6
        '
        Me.Product6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Product6.Location = New System.Drawing.Point(70, 458)
        Me.Product6.Name = "Product6"
        Me.Product6.Size = New System.Drawing.Size(300, 300)
        Me.Product6.TabIndex = 4
        '
        'Product3
        '
        Me.Product3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Product3.Location = New System.Drawing.Point(530, 96)
        Me.Product3.Name = "Product3"
        Me.Product3.Size = New System.Drawing.Size(300, 300)
        Me.Product3.TabIndex = 3
        '
        'Product2
        '
        Me.Product2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Product2.Location = New System.Drawing.Point(968, 96)
        Me.Product2.Name = "Product2"
        Me.Product2.Size = New System.Drawing.Size(300, 300)
        Me.Product2.TabIndex = 2
        '
        'Product1
        '
        Me.Product1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Product1.Location = New System.Drawing.Point(70, 96)
        Me.Product1.Name = "Product1"
        Me.Product1.Size = New System.Drawing.Size(300, 300)
        Me.Product1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VendIT - Products"
        '
        'ProductsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ProductsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VendIT - Products"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Product4 As Product
    Friend WithEvents Product5 As Product
    Friend WithEvents Product6 As Product
    Friend WithEvents Product3 As Product
    Friend WithEvents Product2 As Product
    Friend WithEvents Product1 As Product
    Friend WithEvents Label1 As Label
End Class
