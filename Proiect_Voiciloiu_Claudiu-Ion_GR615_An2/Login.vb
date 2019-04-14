Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" AndAlso TextBox2.Text = "admin" Then
            Main.Show()
            MessageBox.Show("Welcome Admin Overlord!")
        Else
            MessageBox.Show("You entered a wrong username or password. Please try again.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
