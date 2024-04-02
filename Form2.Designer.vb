<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

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


    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        BtnPanel2 = New Panel()
        SuppliesButton = New Button()
        ReservationsButton = New Button()
        Button1 = New Button()
        MenuButton = New Button()
        BtnPanel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        EmployeesButton = New Button()
        BtnPanel2.SuspendLayout()
        BtnPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnPanel2
        ' 
        BtnPanel2.BackColor = Color.Maroon
        BtnPanel2.Controls.Add(EmployeesButton)
        BtnPanel2.Controls.Add(SuppliesButton)
        BtnPanel2.Controls.Add(ReservationsButton)
        BtnPanel2.Controls.Add(Button1)
        BtnPanel2.Controls.Add(MenuButton)
        BtnPanel2.Location = New Point(1, 0)
        BtnPanel2.Name = "BtnPanel2"
        BtnPanel2.Size = New Size(199, 450)
        BtnPanel2.TabIndex = 0
        ' 
        ' SuppliesButton
        ' 
        SuppliesButton.BackColor = Color.Maroon
        SuppliesButton.FlatStyle = FlatStyle.Flat
        SuppliesButton.Font = New Font("Segoe UI", 12F)
        SuppliesButton.ForeColor = Color.OrangeRed
        SuppliesButton.Location = New Point(3, 146)
        SuppliesButton.Name = "SuppliesButton"
        SuppliesButton.Size = New Size(193, 34)
        SuppliesButton.TabIndex = 6
        SuppliesButton.Text = "Supplies"
        SuppliesButton.UseVisualStyleBackColor = False
        ' 
        ' ReservationsButton
        ' 
        ReservationsButton.BackColor = Color.Maroon
        ReservationsButton.FlatStyle = FlatStyle.Flat
        ReservationsButton.Font = New Font("Segoe UI", 12F)
        ReservationsButton.ForeColor = Color.OrangeRed
        ReservationsButton.Location = New Point(0, 212)
        ReservationsButton.Name = "ReservationsButton"
        ReservationsButton.Size = New Size(193, 34)
        ReservationsButton.TabIndex = 5
        ReservationsButton.Text = "Reservations"
        ReservationsButton.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.ForeColor = Color.OrangeRed
        Button1.Location = New Point(3, 386)
        Button1.Name = "Button1"
        Button1.Size = New Size(196, 33)
        Button1.TabIndex = 4
        Button1.Text = "Log out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MenuButton
        ' 
        MenuButton.FlatStyle = FlatStyle.Flat
        MenuButton.Font = New Font("Segoe UI", 12F)
        MenuButton.ForeColor = Color.OrangeRed
        MenuButton.Location = New Point(3, 64)
        MenuButton.Name = "MenuButton"
        MenuButton.Size = New Size(193, 34)
        MenuButton.TabIndex = 0
        MenuButton.Text = "Menu"
        MenuButton.UseVisualStyleBackColor = True
        ' 
        ' BtnPanel1
        ' 
        BtnPanel1.BackColor = Color.Orange
        BtnPanel1.Controls.Add(Label1)
        BtnPanel1.Dock = DockStyle.Top
        BtnPanel1.Location = New Point(0, 0)
        BtnPanel1.Name = "BtnPanel1"
        BtnPanel1.Size = New Size(912, 39)
        BtnPanel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(328, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 32)
        Label1.TabIndex = 0
        Label1.Text = "LUNCHBOX RESTAURANT"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(206, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(706, 405)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' EmployeesButton
        ' 
        EmployeesButton.BackColor = Color.Maroon
        EmployeesButton.FlatStyle = FlatStyle.Flat
        EmployeesButton.Font = New Font("Segoe UI", 12F)
        EmployeesButton.ForeColor = Color.OrangeRed
        EmployeesButton.Location = New Point(3, 283)
        EmployeesButton.Name = "EmployeesButton"
        EmployeesButton.Size = New Size(193, 34)
        EmployeesButton.TabIndex = 7
        EmployeesButton.Text = "Employees"
        EmployeesButton.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(912, 450)
        Controls.Add(PictureBox1)
        Controls.Add(BtnPanel1)
        Controls.Add(BtnPanel2)
        Name = "Form2"
        Text = "Restaurant system"
        BtnPanel2.ResumeLayout(False)
        BtnPanel1.ResumeLayout(False)
        BtnPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnPanel2 As Panel
    Friend WithEvents MenuButton As Button
    Friend WithEvents BtnPanel1 As Panel
    Friend WithEvents Label1 As Label



    Private Sub BtnPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BtnPanel1.Paint

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ReservationsButton As Button
    Friend WithEvents SuppliesButton As Button
    Friend WithEvents EmployeesButton As Button
End Class
