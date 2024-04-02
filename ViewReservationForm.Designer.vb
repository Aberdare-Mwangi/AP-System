<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReservationForm
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
        ViewReservationDataGridView = New DataGridView()
        BackButton = New Button()
        DisplayButton = New Button()
        CType(ViewReservationDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ViewReservationDataGridView
        ' 
        ViewReservationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ViewReservationDataGridView.Location = New Point(52, 55)
        ViewReservationDataGridView.Name = "ViewReservationDataGridView"
        ViewReservationDataGridView.Size = New Size(697, 283)
        ViewReservationDataGridView.TabIndex = 5
        ' 
        ' BackButton
        ' 
        BackButton.BackColor = Color.Red
        BackButton.ForeColor = SystemColors.ButtonHighlight
        BackButton.Location = New Point(606, 365)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(78, 30)
        BackButton.TabIndex = 4
        BackButton.Text = "BACK"
        BackButton.UseVisualStyleBackColor = False
        ' 
        ' DisplayButton
        ' 
        DisplayButton.BackColor = Color.RoyalBlue
        DisplayButton.ForeColor = SystemColors.ButtonHighlight
        DisplayButton.Location = New Point(85, 365)
        DisplayButton.Name = "DisplayButton"
        DisplayButton.Size = New Size(107, 30)
        DisplayButton.TabIndex = 3
        DisplayButton.Text = "Display Details"
        DisplayButton.UseVisualStyleBackColor = False
        ' 
        ' ViewReservationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ViewReservationDataGridView)
        Controls.Add(BackButton)
        Controls.Add(DisplayButton)
        Name = "ViewReservationForm"
        Text = "ViewReservationForm"
        CType(ViewReservationDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ViewReservationDataGridView As DataGridView
    Friend WithEvents BackButton As Button
    Friend WithEvents DisplayButton As Button
End Class
