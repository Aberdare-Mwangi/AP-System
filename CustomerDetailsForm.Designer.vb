<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetailsForm
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
        components = New ComponentModel.Container()
        BindingSource1 = New BindingSource(components)
        CustomerTabControl = New TabControl()
        CustomerDetailsTabPage = New TabPage()
        CustomerDetailsDataGridView = New DataGridView()
        BackButton = New Button()
        DisplayButton = New Button()
        SearchTabPage = New TabPage()
        SearchDataGridView = New DataGridView()
        CidTextBox = New TextBox()
        CidLabel = New Label()
        BindingSource2 = New BindingSource(components)
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        CustomerTabControl.SuspendLayout()
        CustomerDetailsTabPage.SuspendLayout()
        CType(CustomerDetailsDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SearchTabPage.SuspendLayout()
        CType(SearchDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CustomerTabControl
        ' 
        CustomerTabControl.Alignment = TabAlignment.Bottom
        CustomerTabControl.Controls.Add(CustomerDetailsTabPage)
        CustomerTabControl.Controls.Add(SearchTabPage)
        CustomerTabControl.Location = New Point(12, 12)
        CustomerTabControl.Name = "CustomerTabControl"
        CustomerTabControl.SelectedIndex = 0
        CustomerTabControl.Size = New Size(757, 415)
        CustomerTabControl.TabIndex = 0
        ' 
        ' CustomerDetailsTabPage
        ' 
        CustomerDetailsTabPage.Controls.Add(CustomerDetailsDataGridView)
        CustomerDetailsTabPage.Controls.Add(BackButton)
        CustomerDetailsTabPage.Controls.Add(DisplayButton)
        CustomerDetailsTabPage.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CustomerDetailsTabPage.Location = New Point(4, 4)
        CustomerDetailsTabPage.Name = "CustomerDetailsTabPage"
        CustomerDetailsTabPage.Padding = New Padding(3)
        CustomerDetailsTabPage.Size = New Size(749, 387)
        CustomerDetailsTabPage.TabIndex = 1
        CustomerDetailsTabPage.Text = "Customer Details"
        CustomerDetailsTabPage.UseVisualStyleBackColor = True
        ' 
        ' CustomerDetailsDataGridView
        ' 
        CustomerDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CustomerDetailsDataGridView.Location = New Point(27, 22)
        CustomerDetailsDataGridView.Name = "CustomerDetailsDataGridView"
        CustomerDetailsDataGridView.Size = New Size(697, 283)
        CustomerDetailsDataGridView.TabIndex = 2
        ' 
        ' BackButton
        ' 
        BackButton.BackColor = Color.Red
        BackButton.ForeColor = SystemColors.ButtonHighlight
        BackButton.Location = New Point(581, 332)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(78, 30)
        BackButton.TabIndex = 1
        BackButton.Text = "BACK"
        BackButton.UseVisualStyleBackColor = False
        ' 
        ' DisplayButton
        ' 
        DisplayButton.BackColor = Color.RoyalBlue
        DisplayButton.ForeColor = SystemColors.ButtonHighlight
        DisplayButton.Location = New Point(60, 332)
        DisplayButton.Name = "DisplayButton"
        DisplayButton.Size = New Size(107, 30)
        DisplayButton.TabIndex = 0
        DisplayButton.Text = "Display Details"
        DisplayButton.UseVisualStyleBackColor = False
        ' 
        ' SearchTabPage
        ' 
        SearchTabPage.Controls.Add(SearchDataGridView)
        SearchTabPage.Controls.Add(CidTextBox)
        SearchTabPage.Controls.Add(CidLabel)
        SearchTabPage.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SearchTabPage.Location = New Point(4, 4)
        SearchTabPage.Name = "SearchTabPage"
        SearchTabPage.Padding = New Padding(3)
        SearchTabPage.Size = New Size(749, 387)
        SearchTabPage.TabIndex = 2
        SearchTabPage.Text = "Search Customer"
        SearchTabPage.UseVisualStyleBackColor = True
        ' 
        ' SearchDataGridView
        ' 
        SearchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SearchDataGridView.Location = New Point(25, 77)
        SearchDataGridView.Name = "SearchDataGridView"
        SearchDataGridView.Size = New Size(706, 282)
        SearchDataGridView.TabIndex = 2
        ' 
        ' CidTextBox
        ' 
        CidTextBox.Location = New Point(197, 28)
        CidTextBox.Name = "CidTextBox"
        CidTextBox.Size = New Size(177, 23)
        CidTextBox.TabIndex = 1
        ' 
        ' CidLabel
        ' 
        CidLabel.AutoSize = True
        CidLabel.Location = New Point(76, 36)
        CidLabel.Name = "CidLabel"
        CidLabel.Size = New Size(77, 15)
        CidLabel.TabIndex = 0
        CidLabel.Text = "Customer ID:"
        ' 
        ' CustomerDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CustomerTabControl)
        Name = "CustomerDetailsForm"
        Text = "CustomerDetailsForm"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        CustomerTabControl.ResumeLayout(False)
        CustomerDetailsTabPage.ResumeLayout(False)
        CType(CustomerDetailsDataGridView, ComponentModel.ISupportInitialize).EndInit()
        SearchTabPage.ResumeLayout(False)
        SearchTabPage.PerformLayout()
        CType(SearchDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents CustomerTabControl As TabControl
    Friend WithEvents CustomerDetailsTabPage As TabPage
    Friend WithEvents DisplayButton As Button
    Friend WithEvents SearchTabPage As TabPage
    Friend WithEvents CustomerDetailsDataGridView As DataGridView
    Friend WithEvents BackButton As Button
    Friend WithEvents CidTextBox As TextBox
    Friend WithEvents CidLabel As Label
    Friend WithEvents SearchDataGridView As DataGridView
    Friend WithEvents BindingSource2 As BindingSource
End Class
