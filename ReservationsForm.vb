Public Class ReservationsForm

    Private Sub CustomerDetailsButton_Click(sender As Object, e As EventArgs) Handles CustomerDetailsButton.Click
        Me.Hide()
        CustomerDetailsForm.Show()
    End Sub

    Private Sub ViewReservationsButton_Click(sender As Object, e As EventArgs) Handles ViewReservationsButton.Click
        Me.Hide()
        ViewReservationForm.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

End Class