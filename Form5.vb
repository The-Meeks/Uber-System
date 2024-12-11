Public Class deliveryform
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim newItem As String = txtitems.Text
        ListBox1.Items.Add(newItem)

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex())
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim index As Integer = ListBox1.SelectedIndex
        ListBox1.Items.RemoveAt(index)
        ListBox1.Items.Insert(index, txtitems.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enteredText As String = txtpickup.Text
        Dim enteredText2 As String = txtdestination.Text
        MessageBox.Show($"Thank you! Your delivery order from {enteredText} to {enteredText2} is booked.", "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        mainwindow.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class