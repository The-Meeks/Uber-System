Public Class registrationform
    Private Class User
        Public Property Name As String
        Public Property Email As String
        Public Property Password As String
        Public Property PhoneNumber As String
    End Class
    Private users As New List(Of User)()
    Private Function GetUserInput() As User
        Dim newUser As New User()
        newUser.Name = txtName.Text
        newUser.Email = txtEmail.Text
        newUser.Password = txtpassword.Text
        newUser.PhoneNumber = txtNumber.Text

        Return newUser

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newUser As User = GetUserInput()
        RegisterUser(newUser)
        MessageBox.Show($"Thank you for registering, {newUser.Name}!", "Registration Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub RegisterUser(user As User)

        users.Add(user)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mainwindow.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class