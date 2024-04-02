<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationsForm
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
        ViewReservationsButton = New Button()
        CustomerDetailsButton = New Button()
        BackButton = New Button()
        SuspendLayout()
        ' 
        ' ViewReservationsButton
        ' 
        ViewReservationsButton.Location = New Point(317, 179)
        ViewReservationsButton.Name = "ViewReservationsButton"
        ViewReservationsButton.Size = New Size(145, 46)
        ViewReservationsButton.TabIndex = 1
        ViewReservationsButton.Text = "View Reservations"
        ViewReservationsButton.UseVisualStyleBackColor = True
        ' 
        ' CustomerDetailsButton
        ' 
        CustomerDetailsButton.Location = New Point(317, 250)
        CustomerDetailsButton.Name = "CustomerDetailsButton"
        CustomerDetailsButton.Size = New Size(145, 47)
        CustomerDetailsButton.TabIndex = 2
        CustomerDetailsButton.Text = "Customer Details"
        CustomerDetailsButton.UseVisualStyleBackColor = True
        ' 
        ' BackButton
        ' 
        BackButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BackButton.Location = New Point(334, 350)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(104, 40)
        BackButton.TabIndex = 3
        BackButton.Text = "BACK"
        BackButton.UseVisualStyleBackColor = True
        ' 
        ' ReservationsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BackButton)
        Controls.Add(CustomerDetailsButton)
        Controls.Add(ViewReservationsButton)
        Name = "ReservationsForm"
        Text = "ReservationsForm"
        ResumeLayout(False)
    End Sub
    Friend WithEvents ViewReservationsButton As Button
    Friend WithEvents CustomerDetailsButton As Button
    Friend WithEvents BackButton As Button
End Class
