<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderSummaryForm
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
        DGV = New DataGridView()
        ProdName = New DataGridViewTextBoxColumn()
        ProdQty = New DataGridViewTextBoxColumn()
        ProdPrice = New DataGridViewTextBoxColumn()
        Total = New DataGridViewTextBoxColumn()
        ProgressBar1 = New ProgressBar()
        CheckoutBtn = New Button()
        backBtn = New LinkLabel()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(382, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 38)
        Label1.TabIndex = 0
        Label1.Text = "Order Summary"
        ' 
        ' DGV
        ' 
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Columns.AddRange(New DataGridViewColumn() {ProdName, ProdQty, ProdPrice, Total})
        DGV.Location = New Point(88, 136)
        DGV.Name = "DGV"
        DGV.RowHeadersWidth = 51
        DGV.RowTemplate.Height = 29
        DGV.Size = New Size(806, 288)
        DGV.TabIndex = 1
        ' 
        ' ProdName
        ' 
        ProdName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ProdName.HeaderText = "Product"
        ProdName.MinimumWidth = 6
        ProdName.Name = "ProdName"
        ' 
        ' ProdQty
        ' 
        ProdQty.HeaderText = "Quantity"
        ProdQty.MinimumWidth = 6
        ProdQty.Name = "ProdQty"
        ProdQty.Width = 125
        ' 
        ' ProdPrice
        ' 
        ProdPrice.HeaderText = "Price"
        ProdPrice.MinimumWidth = 6
        ProdPrice.Name = "ProdPrice"
        ProdPrice.Width = 125
        ' 
        ' Total
        ' 
        Total.HeaderText = "Total"
        Total.MinimumWidth = 6
        Total.Name = "Total"
        Total.Width = 125
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(88, 464)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(621, 40)
        ProgressBar1.TabIndex = 2
        ' 
        ' CheckoutBtn
        ' 
        CheckoutBtn.Location = New Point(766, 464)
        CheckoutBtn.Name = "CheckoutBtn"
        CheckoutBtn.Size = New Size(128, 48)
        CheckoutBtn.TabIndex = 3
        CheckoutBtn.Text = "Checkout"
        CheckoutBtn.UseVisualStyleBackColor = True
        ' 
        ' backBtn
        ' 
        backBtn.AutoSize = True
        backBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        backBtn.Location = New Point(790, 46)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(104, 25)
        backBtn.TabIndex = 10
        backBtn.TabStop = True
        backBtn.Text = "< Go Back"
        ' 
        ' OrderSummaryForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 553)
        Controls.Add(backBtn)
        Controls.Add(CheckoutBtn)
        Controls.Add(ProgressBar1)
        Controls.Add(DGV)
        Controls.Add(Label1)
        Name = "OrderSummaryForm"
        Text = "VendIT - Order Summary"
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents ProdQty As DataGridViewTextBoxColumn
    Friend WithEvents ProdPrice As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents CheckoutBtn As Button
    Friend WithEvents backBtn As LinkLabel
End Class
