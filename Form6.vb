Public Class paymentform
    Private intamount As Integer
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        Dim intdistance As Integer
        Const fixedAmount As Integer = 100

        Integer.TryParse(txtdistance.Text, intdistance)
        intamount = intdistance * fixedAmount
        txtamount.Text = intamount.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intbalance As Integer
        Dim intdeposit As Integer
        Integer.TryParse(txtdeposit.Text, intdeposit)
        If intamount < intdeposit Then
            intbalance = intdeposit - intamount
        Else
            MessageBox.Show("Insufficient fund to complete order!")

        End If
        txtbalance.Text = intbalance.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        mainwindow.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class