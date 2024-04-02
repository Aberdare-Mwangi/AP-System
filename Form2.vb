Public Class Form2
    Private Sub BtnBilling_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReservationsButton_Click(sender As Object, e As EventArgs) Handles ReservationsButton.Click
        ReservationsForm.Show()
    End Sub

    Private Sub SuppliesButton_Click(sender As Object, e As EventArgs) Handles SuppliesButton.Click
        SuppliesForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        Dim cartForm As New Cart
        Dim menuForm As New Menu(cartForm)
        menuForm.Show()
    End Sub

    Private Sub EmployeesButton_Click(sender As Object, e As EventArgs) Handles EmployeesButton.Click
        Employess.Show()
    End Sub
End Class
