<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cart
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
        TotalLabel = New Label()
        Checkout = New Button()
        ClearCart = New Button()
        CartListBox = New ListBox()
        SuspendLayout()
        ' 
        ' TotalLabel
        ' 
        TotalLabel.AutoSize = True
        TotalLabel.Location = New Point(596, 233)
        TotalLabel.Margin = New Padding(2, 0, 2, 0)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New Size(32, 15)
        TotalLabel.TabIndex = 1
        TotalLabel.Text = "Total"
        ' 
        ' Checkout
        ' 
        Checkout.Location = New Point(110, 261)
        Checkout.Margin = New Padding(2, 2, 2, 2)
        Checkout.Name = "Checkout"
        Checkout.Size = New Size(164, 20)
        Checkout.TabIndex = 2
        Checkout.Text = "Checkout"
        Checkout.UseVisualStyleBackColor = True
        ' 
        ' ClearCart
        ' 
        ClearCart.Location = New Point(564, 261)
        ClearCart.Margin = New Padding(2, 2, 2, 2)
        ClearCart.Name = "ClearCart"
        ClearCart.Size = New Size(178, 20)
        ClearCart.TabIndex = 3
        ClearCart.Text = "ClearCart"
        ClearCart.UseVisualStyleBackColor = True
        ' 
        ' CartListBox
        ' 
        CartListBox.FormattingEnabled = True
        CartListBox.ItemHeight = 15
        CartListBox.Location = New Point(21, 20)
        CartListBox.Margin = New Padding(2, 2, 2, 2)
        CartListBox.Name = "CartListBox"
        CartListBox.Size = New Size(794, 199)
        CartListBox.TabIndex = 4
        ' 
        ' Cart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(832, 327)
        Controls.Add(CartListBox)
        Controls.Add(ClearCart)
        Controls.Add(Checkout)
        Controls.Add(TotalLabel)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Cart"
        Text = "Cart"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CartListBox As ListBox
    Friend WithEvents ClearCart As Button
    Friend WithEvents Checkout As Button
End Class
