Imports System.Windows.Forms
Public Class bookingform
    Private Class Booking
        Public Property Name As String
        Public Property PhoneNumber As String
        Public Property PickupLocation As String
        Public Property Destination As String
    End Class
    Private bookings As New List(Of Booking)()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newBooking As Booking = GetBookingInput()
        BookRide(newBooking)
        MessageBox.Show($"Thank you! Your ride from {newBooking.PickupLocation} to {newBooking.Destination} is booked.", "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Function GetBookingInput() As Booking
        Dim newBooking As New Booking()

        newBooking.Name = txtName.Text
        newBooking.PhoneNumber = txtNumber.Text
        newBooking.PickupLocation = txtsource.Text
        newBooking.Destination = txtdestination.Text

        Return newBooking
    End Function

    Private Sub BookRide(booking As Booking)
        bookings.Add(booking)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        mainwindow.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class