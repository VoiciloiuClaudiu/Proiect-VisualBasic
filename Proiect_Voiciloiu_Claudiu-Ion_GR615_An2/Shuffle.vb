Public Class Shuffle
    Public Count As Integer

    Private Sub Shuffle_Load(sender As Object, e As EventArgs)
        Main.Hide()
        ShuffleV()
    End Sub

    '1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 2,5
        CheckButton(Button3, Button4)
        CheckButton(Button3, Button7)

        CheckSolved()
    End Sub

    '2
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' 1,3,6
        CheckButton(Button4, Button3)
        CheckButton(Button4, Button5)
        CheckButton(Button4, Button8)

        CheckSolved()
    End Sub

    '3
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' 2,4,7
        CheckButton(Button5, Button4)
        CheckButton(Button5, Button6)
        CheckButton(Button5, Button9)

        CheckSolved()
    End Sub

    '4
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' 3,8
        CheckButton(Button6, Button5)
        CheckButton(Button6, Button10)

        CheckSolved()
    End Sub

    '5
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' 1,6,9
        CheckButton(Button7, Button3)
        CheckButton(Button7, Button8)
        CheckButton(Button7, Button11)

        CheckSolved()
    End Sub

    '6
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' 2,5,7,10
        CheckButton(Button8, Button4)
        CheckButton(Button8, Button7)
        CheckButton(Button8, Button9)
        CheckButton(Button8, Button12)

        CheckSolved()
    End Sub

    '7
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' 3,6,8,11
        CheckButton(Button9, Button5)
        CheckButton(Button9, Button8)
        CheckButton(Button9, Button10)
        CheckButton(Button9, Button13)

        CheckSolved()
    End Sub

    '8
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ' 4,7,12
        CheckButton(Button10, Button6)
        CheckButton(Button10, Button9)
        CheckButton(Button10, Button14)

        CheckSolved()
    End Sub

    '9
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ' 5,10,13
        CheckButton(Button11, Button7)
        CheckButton(Button11, Button12)
        CheckButton(Button11, Button15)

        CheckSolved()
    End Sub

    '10
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ' 6,9,11,14
        CheckButton(Button12, Button8)
        CheckButton(Button12, Button11)
        CheckButton(Button12, Button13)
        CheckButton(Button12, Button16)

        CheckSolved()
    End Sub

    '11
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ' 7,10,12,15
        CheckButton(Button13, Button9)
        CheckButton(Button13, Button12)
        CheckButton(Button13, Button14)
        CheckButton(Button13, Button17)

        CheckSolved()
    End Sub

    '12
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ' 8,11,16
        CheckButton(Button14, Button10)
        CheckButton(Button14, Button13)
        CheckButton(Button14, Button18)

        CheckSolved()
    End Sub

    '13
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ' 9,14
        CheckButton(Button15, Button11)
        CheckButton(Button15, Button16)

        CheckSolved()
    End Sub

    '14
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ' 10,13,15
        CheckButton(Button16, Button12)
        CheckButton(Button16, Button15)
        CheckButton(Button16, Button17)

        CheckSolved()
    End Sub

    '15
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        ' 11,14,16
        CheckButton(Button17, Button13)
        CheckButton(Button17, Button16)
        CheckButton(Button17, Button18)

        CheckSolved()
    End Sub

    '16
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        ' 12,15
        CheckButton(Button18, Button14)
        CheckButton(Button18, Button17)

        CheckSolved()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ShuffleV()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class