Public Class Form1
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim strUsername As String = txtusername.Text
        Dim strPassword As String = txtpassword.Text

        ' Validate the entered credentials
        If strUsername = "admin" AndAlso strPassword = "password" Then
            Me.Hide()
            mainwindow.Show()

        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub
End Class
