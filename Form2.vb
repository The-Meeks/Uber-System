Public Class mainwindow
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Me.Hide()
        registrationform.Show()


    End Sub

    Private Sub btnbooking_Click(sender As Object, e As EventArgs) Handles btnbooking.Click
        Me.Hide()
        bookingform.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        deliveryform.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        paymentform.Show()
    End Sub
End Class