<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employess
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
        DataGridView1 = New DataGridView()
        Display = New Button()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(972, 359)
        DataGridView1.TabIndex = 0
        ' 
        ' Display
        ' 
        Display.BackColor = Color.DodgerBlue
        Display.Location = New Point(163, 380)
        Display.Name = "Display"
        Display.Size = New Size(75, 23)
        Display.TabIndex = 1
        Display.Text = "Display"
        Display.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(347, 380)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 2
        Button2.Text = "Log Out"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Employess
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(996, 450)
        Controls.Add(Button2)
        Controls.Add(Display)
        Controls.Add(DataGridView1)
        Name = "Employess"
        Text = "Employees"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Display As Button
    Friend WithEvents Button2 As Button
End Class
