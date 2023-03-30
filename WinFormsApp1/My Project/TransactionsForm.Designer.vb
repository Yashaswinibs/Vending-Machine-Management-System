<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionsForm
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
        backBtn = New LinkLabel()
        TransactionsDGV = New DataGridView()
        ProdName = New DataGridViewTextBoxColumn()
        ProdPrice = New DataGridViewTextBoxColumn()
        ProdQty = New DataGridViewTextBoxColumn()
        PaymentMthd = New DataGridViewTextBoxColumn()
        PurchaseTm = New DataGridViewTextBoxColumn()
        CType(TransactionsDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(358, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 38)
        Label1.TabIndex = 1
        Label1.Text = "Transaction History"
        ' 
        ' backBtn
        ' 
        backBtn.AutoSize = True
        backBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        backBtn.Location = New Point(839, 22)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(104, 25)
        backBtn.TabIndex = 11
        backBtn.TabStop = True
        backBtn.Text = "< Go Back"
        ' 
        ' TransactionsDGV
        ' 
        TransactionsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TransactionsDGV.Columns.AddRange(New DataGridViewColumn() {ProdName, ProdPrice, ProdQty, PaymentMthd, PurchaseTm})
        TransactionsDGV.Location = New Point(37, 187)
        TransactionsDGV.Name = "TransactionsDGV"
        TransactionsDGV.RowHeadersWidth = 51
        TransactionsDGV.RowTemplate.Height = 29
        TransactionsDGV.Size = New Size(906, 320)
        TransactionsDGV.TabIndex = 12
        ' 
        ' ProdName
        ' 
        ProdName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ProdName.HeaderText = "Product"
        ProdName.MinimumWidth = 6
        ProdName.Name = "ProdName"
        ' 
        ' ProdPrice
        ' 
        ProdPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ProdPrice.HeaderText = "Price"
        ProdPrice.MinimumWidth = 6
        ProdPrice.Name = "ProdPrice"
        ' 
        ' ProdQty
        ' 
        ProdQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ProdQty.HeaderText = "Quantity"
        ProdQty.MinimumWidth = 6
        ProdQty.Name = "ProdQty"
        ' 
        ' PaymentMthd
        ' 
        PaymentMthd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        PaymentMthd.HeaderText = "Payment Method"
        PaymentMthd.MinimumWidth = 6
        PaymentMthd.Name = "PaymentMthd"
        ' 
        ' PurchaseTm
        ' 
        PurchaseTm.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        PurchaseTm.HeaderText = "Purchase Time"
        PurchaseTm.MinimumWidth = 6
        PurchaseTm.Name = "PurchaseTm"
        ' 
        ' TransactionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 553)
        Controls.Add(TransactionsDGV)
        Controls.Add(backBtn)
        Controls.Add(Label1)
        Name = "TransactionsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "VendIT - Transactions"
        CType(TransactionsDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents backBtn As LinkLabel
    Friend WithEvents TransactionsDGV As DataGridView
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents ProdPrice As DataGridViewTextBoxColumn
    Friend WithEvents ProdQty As DataGridViewTextBoxColumn
    Friend WithEvents PaymentMthd As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseTm As DataGridViewTextBoxColumn
End Class
